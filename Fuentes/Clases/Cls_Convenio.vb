'*************************************************************************
' Nombre:   Cls_Convenio
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla CONVENIO   
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2002
' Autores:  RFN
' Ultima Modificaci�n: 08/08/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Convenio


    Sub LlenarGridConvenios(ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerConvenios().Tables("Registros")
    End Sub


    Public Function LeerConvenios() As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim str_sql As String = "select convenio.CON_NOMBRE, convenio.CON_VALOR, secuencias.sec_desde, secuencias.sec_hasta, secuencias.sec_unidad,  case when (convenio.CON_WEB_EMAIL <> '') then convenio.CON_WEB_EMAIL else 'N/A' end  as email, secuencias.sec_id as sec_id, case when convenio.con_codigo <> '' then convenio.con_codigo else 'N/A' end as codigo, case when convenio.CON_WEB_LOGIN <> '' then convenio.CON_WEB_LOGIN else 'N/A' end as login, convenio.CON_WEB_PASS as pass, convenio.CON_TIPO " & _
                                "from convenio, secuencias " & _
                                "where convenio.CON_NOMBRE = secuencias.sec_nombre order by secuencias.sec_id;  "
                                
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerConvenios = New DataSet("CONVENIOS")
        dt_operacion.Fill(LeerConvenios, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer secuencias", Err)
        Err.Clear()
    End Function


    Public Sub GuardarConvenio(ByVal Max_sec As Integer, ByVal con_nombre As String, ByVal con_valor As Double, ByVal con_codigo As String, ByVal con_login As String, ByVal con_pass As String, ByVal con_email As String, ByVal tipo As Byte)
        'Procedimiento para la insertar un registro en la tabla CONVENIO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into Convenio values (" & Max_sec & ", '" & con_nombre & "', " & con_valor & ", '" & con_login & "','" & con_pass & "','" & con_email & "', " & tipo & ",'" & con_codigo & "')"
        'Dim str_sql1 As String = "Insert into Convenio_bk values ('" & con_nombre & "', " & con_valor & ", GETDATE())"
        opr_conexion.sql_conectar()

        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_conexion.sql_desconn()
        'MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Convenio", "Convenio=" & con_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Convenio", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarConvenioWeb(ByVal con_web_sec As Integer, ByVal con_nombre As String, ByVal con_id As String, ByVal con_web_login As String, ByVal con_web_pass As String, ByVal con_web_email As String)
        'Procedimiento para la insertar un registro en la tabla CONVENIO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into Convenio_web values (" & con_web_sec & ",'" & con_nombre & "', '" & con_id & "','" & con_web_login & "','" & con_web_pass & "','" & con_web_email & "');"
        opr_conexion.sql_conectar()

        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_conexion.sql_desconn()
        'MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Convenio Web", "Convenio=" & con_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Convenio Web", Err)
        Err.Clear()
    End Sub



    Public Sub GuardarPacienteConvenio(ByVal con_nombre As String, ByVal Pac_Id As Integer, ByVal Pac_Hc As String)
        'Procedimiento para la insertar un registro en paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into Paciente values (" & Pac_Id & ",1, '',4,'PACIENTE', '" & con_nombre & "','','','','M','1992-01-01','','" & Format(Now, "dd/MM/yyyy") & "', '" & Pac_Hc & "',1, '" & con_nombre & "','','')"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Paciente", "Paciente=" & Pac_Id, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Convenios", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarConvenio(ByVal con_nombre As String, ByVal con_valor As Double, ByVal con_codigo As Integer, ByVal con_login As String, ByVal con_pass As String, ByVal con_email As String, ByVal tipo As Byte)

        'Procedimiento para la actualizar un registro en la tabla CONVENIO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim emp_codigo As String = Nothing

        emp_codigo = "clab" & CStr(Format(con_codigo, "000"))

        Dim str_Sql As String = "update CONVENIO set CON_NOMBRE = '" & con_nombre & "', con_valor = " & con_valor & ", CON_CODIGO = '" & emp_codigo & "', con_web_login = '" & con_login & "', CON_WEB_PASS = '" & con_pass & "', CON_WEB_EMAIL ='" & con_email & "', CON_TIPO = " & tipo & " where CON_ID  = '" & con_codigo & "'"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_Sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Convenio", "Convenio=" & con_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Convenios", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarConvenio(ByVal con_nombre As String)
        'Procedimiento para la eliminar un registro en la tabla CONVENIO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_Sql As String = "delete from CONVENIO where con_nombre = '" & con_nombre & "'"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_Sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        opr_conexion.sql_desconn()
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Convenio", "Convenio0" & con_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Convenio", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarListaPrecios(ByVal con_nombre As String)
        'Procedimiento que elimina la lista de precios de un convenio determinado 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "delete from LISTA_PRECIO where con_nombre = '" & con_nombre & "'"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Elimina Lista de Precios", "Lista Precio=" & con_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Lista Precio", Err)
        Err.Clear()
    End Sub

    Public Function LeerConvenio() As DataSet
        'Procedimiento para consultar todas los Convenios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select * from CONVENIO", opr_Conexion.conn_sql)
        LeerConvenio = New DataSet()
        oda_operacion.Fill(LeerConvenio, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Convenios", Err)
        Err.Clear()
    End Function

    Sub LlenarComboConvenio(ByRef cmb_convenio As ComboBox)
        On Error Resume Next
        'Para llenar el combo de convenio
        Dim dts_convenio As DataSet
        Dim dtr_fila As DataRow
        dts_convenio = LeerConvenio()
        cmb_convenio.Items.Clear()
        For Each dtr_fila In dts_convenio.Tables("Registros").Rows
            cmb_convenio.Items.Add(dtr_fila("con_nombre").ToString())
        Next
        dts_convenio.Dispose()
        cmb_convenio.SelectedIndex = 0
    End Sub

    Public Sub LeerListaPrecio(ByVal con_nombre As String, ByRef dtt_testeqp As DataTable)
        'Funci�n para consultar la lista de precios de un Convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        str_sql = "SELECT a.tes_id, a.tes_nombre, LISTA_PRECIO.lip_precio FROM TEST as a, LISTA_PRECIO, CONVENIO " & _
                  "WHERE a.TES_TIPO <> 'Parametro' and a.TES_ID = LISTA_PRECIO.TES_ID AND LISTA_PRECIO.CON_NOMBRE = CONVENIO.CON_NOMBRE AND " & _
                  "CONVENIO.CON_NOMBRE='" & con_nombre & "'"
        opr_Conexion.sql_conectar()
        dtt_testeqp.Clear()
        Dim dts_convenio As New DataSet()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_testeqp)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Lista Precio", Err)
        Err.Clear()
    End Sub

    Public Function ExisteListaPrecio(ByVal con_nombre As String) As Boolean
        'Funci�n consultar si un convenio tiene o no una lista de precios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        opr_Conexion.sql_conectar()
        Dim dts_conv As New DataSet()
        oda_operacion.SelectCommand = New SqlCommand("SELECT * FROM lista_precio WHERE CON_NOMBRE = '" & con_nombre & "'", opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_conv, "Registros")
        For Each dtr_fila In dts_conv.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                ExisteListaPrecio = False
            Else
                ExisteListaPrecio = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Existe Lista Precio", Err)
        Err.Clear()
    End Function

    Public Sub LeerPreciosTest(ByVal porcentaje As Double, ByVal dtt_testeqp As DataTable)
        'Funcion para consultar la lista de precios de un Convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        dtt_testeqp.Clear()
        'str_sql = "SELECT test_equipo.tes_id as tes_id, test.tes_nombre as tes_nombre, tes_precio * convenio.con_valor as lip_precio " & _
        '          "FROM test_equipo, test, convenio WHERE test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id AND " & _
        '          "tes_parametro <> 1 and CON_NOMBRE = '" & con_nombre & "' UNION SELECT test.tes_id as tes_id, test.tes_nombre as tes_nombre, " & _
        '          "tes_precio * convenio.con_valor  as lip_precio FROM test, convenio WHERE tes_tproces = 0 and tes_parametro <> 1 and " & _
        '          "convenio.con_nombre = '" & con_nombre & "' "

        str_sql = "SELECT test.tes_id as tes_id, test.tes_nombre as tes_nombre, (lista_precio.LIP_PRECIO * " & porcentaje & " ) as lip_precio, lista_precio.CON_NOMBRE " & _
            "FROM test, lista_precio " & _
            "WHERE lista_precio.CON_NOMBRE = 'NORMAL' " & _
            "and lista_precio .TES_ID = test.TES_ID " & _
            "AND test.tes_parametro <> 1 "

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_testeqp)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Precios Test", Err)
        Err.Clear()
    End Sub


    Public Sub LeerPreciosTestRestaura(ByVal con_nombre As String, ByVal dtt_testeqp As DataTable)
        'Funcion para consultar la lista de precios de un Convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        dtt_testeqp.Clear()
        str_sql = "SELECT test_equipo.tes_id as tes_id, test.tes_nombre as tes_nombre, tes_precio * convenio.con_valor as lip_precio " & _
                   "FROM test_equipo, test, convenio WHERE test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id AND " & _
                   "tes_parametro <> 1 and CON_NOMBRE = '" & con_nombre & "' UNION SELECT test.tes_id as tes_id, test.tes_nombre as tes_nombre, " & _
                   "tes_precio * convenio.con_valor  as lip_precio FROM test, convenio WHERE tes_tproces = 0 and tes_parametro <> 1 and " & _
                   "convenio.con_nombre = '" & con_nombre & "' "

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_testeqp)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Precios Test", Err)
        Err.Clear()
    End Sub


    Public Sub LeerPreciosTest1(ByVal con_nombre As String, ByVal porcentaje As Double, ByVal dtt_testeqp As DataTable, ByVal EsDscto As Integer)
        'Funcion para consultar la lista de precios de un Convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        Dim formula As String = Nothing

        dtt_testeqp.Clear()

        If EsDscto = 1 Then
            formula = "lista_precio.LIP_PRECIO - (lista_precio.LIP_PRECIO  * " & porcentaje / 100 & ")"
        End If

        If EsDscto = 0 Then
            formula = "lista_precio.LIP_PRECIO + (lista_precio.LIP_PRECIO  * " & porcentaje / 100 & ")"
        End If

        'If porcentaje = 1 Then
        ' formula = "(lista_precio.LIP_PRECIO  * " & porcentaje & ")"
        ' End If

        'str_sql = "SELECT test_equipo.tes_id as tes_id, test.tes_nombre as tes_nombre, tes_precio * convenio.con_valor as lip_precio " & _
        '          "FROM test_equipo, test, convenio WHERE test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id AND " & _
        '          "tes_parametro <> 1 and CON_NOMBRE = '" & con_nombre & "' UNION SELECT test.tes_id as tes_id, test.tes_nombre as tes_nombre, " & _
        '          "tes_precio * convenio.con_valor  as lip_precio FROM test, convenio WHERE tes_tproces = 0 and tes_parametro <> 1 and " & _
        '          "convenio.con_nombre = '" & con_nombre & "' "
        str_sql = "SELECT (test.tes_id) as tes_id, test.tes_nombre as tes_nombre, " & formula & " as lip_precio " & _
                "FROM lista_precio, test " & _
                "WHERE lista_precio.tes_id = test.tes_id " & _
                "AND test.tes_parametro <> 1 and lista_precio.CON_NOMBRE = 'NORMAL' "

        'str_sql = "SELECT test.tes_id as tes_id, test.tes_nombre as tes_nombre, (lista_precio.LIP_PRECIO * " & porcentaje & " ) as lip_precio, lista_precio.CON_NOMBRE " & _
        '    "FROM test, lista_precio " & _
        '    "WHERE lista_precio.CON_NOMBRE = 'NORMAL' " & _
        '    "and lista_precio .TES_ID = test.TES_ID " & _
        '    "AND test.tes_parametro <> 1 "

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_testeqp)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Precios Test", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarListaPrecio(ByRef dtv_test As DataView, ByVal x As Integer, ByVal con_nombre As String, Optional ByVal OPERACION As Byte = 0)
        'Procedimiento para la insertar un Lista de precios en la tabla LISTA_PRECIO de un convenio especifico 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction

        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim odbc_strsql2 As SqlCommand
        Dim odbc_strsql3 As SqlCommand

        Dim int_i As Integer
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        Dim str_sql2 As String = ""
        Dim str_sql3 As String = ""
        Dim dtr_fila As DataRow

        'dtv_test.Table.Clear()

        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        'str_sql = "Delete from lista_precio where con_nombre = '" & Trim(con_nombre) & "'"
        'odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        'odbc_strsql.ExecuteNonQuery()
        'For x = 0 To dtv_test.Table.Rows.Count - 1
        '    dtr_fila(0) = GetValue(0).ToString()
        'Next
        '''''''''''''dtv_resAB.Item(x).Row(2)
        For int_i = 0 To (x)
            If OPERACION = 0 Then
                str_sql = "update lista_precio set lip_precio= " & dtv_test.Item(int_i).Row(2) & " where tes_id = " & dtv_test.Item(int_i).Row(0) & " and con_nombre = '" & Trim(con_nombre) & "'"
                'str_sql1 = "update lista_precio_bk set lip_precio= " & dgrd_listaprecio.Item(int_i, 2) & " where tes_id = " & dgrd_listaprecio.Item(int_i, 0) & " and con_nombre = '" & Trim(con_nombre) & "', GETDATE()"
            Else
                str_sql = "Insert into lista_precio values (" & dtv_test.Item(int_i).Row(2) & ", " & dtv_test.Item(int_i).Row(0) & ", '" & Trim(con_nombre) & "')"

                'str_sql3 = "Insert into lista_precio_bk values (" & dgrd_listaprecio.Item(int_i, 2) & ", " & dgrd_listaprecio.Item(int_i, 0) & ", '" & Trim(con_nombre) & "', GETDATE() )"
            End If

            'If OPERACION = 0 Then
            odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()

            'odbc_strsql1 = New SqlCommand(str_sql1, opr_Conexion.conn_sql, odbc_trans)
            'odbc_strsql1.ExecuteNonQuery()

            'Else
            'odbc_strsql2 = New SqlCommand(str_sql2, opr_Conexion.conn_sql, odbc_trans)
            'odbc_strsql2.ExecuteNonQuery()

            'odbc_strsql3 = New SqlCommand(str_sql3, opr_Conexion.conn_sql, odbc_trans)
            'odbc_strsql3.ExecuteNonQuery()
            'End If
        Next
        odbc_trans.Commit()

        opr_Conexion.sql_desconn()
        'MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Lista Precio", Err)
        Err.Clear()
    End Sub

    Public Sub AgregarTestListaPrecio(ByVal tes_id As Integer, ByVal tes_costo As Double, ByVal con_nombre As String, ByVal con_valor As Double)
        'Procedimiento para agregar un test y su precio normal a una lista de precio de un convenio espec�fico
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        opr_conexion.sql_conectar()
        str_sql = "Insert into LISTA_PRECIO values (" & tes_costo * con_valor & ", " & tes_id & " , '" & con_nombre & "')"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Test en Lista de Precios", "Test=" & tes_id & " " & tes_costo & " " & " " & con_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Agregar Test Lista Precio", Err)
        Err.Clear()
    End Sub

    Public Function ConsultarTestConvenioLP(ByVal int_codigo As Integer, ByVal costo As Double) As DataSet
        'Funci�n para la consultar convenios en los que se encuentra un test en las listas de precios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT LISTA_PRECIO.CON_NOMBRE, CONVENIO.CON_VALOR FROM CONVENIO INNER JOIN LISTA_PRECIO ON CONVENIO.CON_NOMBRE = LISTA_PRECIO.CON_NOMBRE where LISTA_PRECIO.tes_id = " & int_codigo & " GROUP BY LISTA_PRECIO.CON_NOMBRE, CONVENIO.CON_VALOR", opr_Conexion.conn_sql)
        ConsultarTestConvenioLP = New DataSet()
        oda_operacion.Fill(ConsultarTestConvenioLP, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Consultar Test ConvenioLP", Err)
        Err.Clear()
    End Function

    Public Sub ActualizarPrecioTestLP(ByVal con_nombre As String, ByVal con_valor As Double, ByVal tes_id As Integer)
        'Procedimiento para la actualizar el precio de un test en una lista de precio de un CONVENIO
        On Error GoTo MsgError

        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("update LISTA_PRECIO set LIP_PRECIO = " & _
        con_valor & " where con_nombre = '" & con_nombre & "' And tes_id = " & tes_id & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Lista Precio Test", "Lista Precio=" & con_nombre & " " & tes_id, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Precio TestLP", Err)
        Err.Clear()
    End Sub

    Sub LlenarComboConvenio2(ByRef cmb_convenio As ComboBox)
        On Error Resume Next
        'Para llenar el combo de convenio
        Dim dts_convenio As DataSet
        Dim dtr_fila As DataRow
        dts_convenio = LeerConvenio()
        cmb_convenio.Items.Clear()
        For Each dtr_fila In dts_convenio.Tables("Registros").Rows
            cmb_convenio.Items.Add(dtr_fila("con_nombre").ToString().PadRight(50) & dtr_fila("con_valor").ToString().PadRight(10))
        Next
        If cmb_convenio.Items.Count() > 0 Then
            cmb_convenio.SelectedIndex = 0
        End If
    End Sub

    Sub ordena_test(ByVal test As String, ByRef data As DataView)
        'funci�n que orderna por test al dataview
        With data
            If Trim(test) <> "" Then
                .RowFilter = "TES_NOMBRE like '" & Trim(test) & "*'"
            Else
                .RowFilter = ""
            End If
            '.Sort = "TES_NOMBRE"
        End With
    End Sub

    Public Function devuelveMaxIdpaciente() As Integer
        'Funcion para la consultar el ID para paciente de un convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        devuelveMaxIdpaciente = CInt(New SqlCommand("select isnull(Max(pac_id),0) as PAC_ID from paciente; ", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Devolver MAX ID PACIENTE, Cls_Convenio", Err)
        Err.Clear()
    End Function

    Public Function devuelveMaxHCpaciente() As String
        'Funcion para la consultar el ID para paciente de un convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        devuelveMaxHCpaciente = New SqlCommand("select isnull(Max(pac_id),0) as PAC_ID from paciente; ", opr_Conexion.conn_sql).ExecuteScalar
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Devolver MAX HC PACIENTE, Cls_Convenio", Err)
        Err.Clear()
    End Function

    Public Function devuelveMaxIdConvenio() As Integer
        'Funcion para la consultar el ID convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        devuelveMaxIdConvenio = New SqlCommand("select isnull(Max(sec_id),0) as sec_id from secuencias;", opr_Conexion.conn_sql).ExecuteScalar
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Devolver MAX HC PACIENTE, Cls_Convenio", Err)
        Err.Clear()
    End Function
End Class
