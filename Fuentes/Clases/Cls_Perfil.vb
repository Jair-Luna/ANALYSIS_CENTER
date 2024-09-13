'*************************************************************************
' Nombre:   Cls_Perfil
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla PERFIL y PERFIL_TEST 
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2002
' Autores:  RFN
' Ultima Modificaci�n: 05/08/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient



Public Class Cls_Perfil

    Public Function LeerPerfil() As DataSet
        'Funcion para la consultar los datos de la tabla PERFIL
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        dt_operacion.SelectCommand = New SqlCommand("SELECT per_id, per_nombre, per_obs, 'ACTIVO' as estado FROM PERFIL where(per_estado = 1) union SELECT per_id, per_nombre, per_obs, 'INACTIVO' as estado FROM PERFIL where (per_estado = 0);", cls_operacion.conn_sql)
        LeerPerfil = New DataSet()
        dt_operacion.Fill(LeerPerfil, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Perfiles", Err)
        Err.Clear()
    End Function


    Public Function LeerPerfilMedico() As DataSet
        'Funcion para la consultar los datos de la tabla PERFIL
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        dt_operacion.SelectCommand = New SqlCommand("select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS = 'Tratante'", cls_operacion.conn_sql)
        LeerPerfilMedico = New DataSet()
        dt_operacion.Fill(LeerPerfilMedico, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Grupo Medico", Err)
        Err.Clear()
    End Function


    Public Sub GuardarPerfil(ByVal Per_id As Integer, ByVal per_nombre As String, _
                          ByVal per_Obs As String, ByRef lst_testperfil As ListBox, ByVal estado As Single)
        'Procedimiento para la insertar un registro en la tabla PERFIL Y PERFIL_TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql = New SqlCommand("Insert into PERFIL values (" & Per_id & ", '" & per_nombre & "', '" & per_Obs & "', '" & Today & "', " & estado & ")", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        Dim i As Integer
        Dim x As Integer
        Dim s As String
        For i = 0 To (lst_testperfil.Items.Count - 1)
            s = lst_testperfil.Items.Item(i)
            x = s.Substring(100, 6)
            odbc_strsql = New SqlCommand("Insert into PERFIL_TEST values (" & x & ", " & Per_id & ")", opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
        Next
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Perfil", "PERFIL=" & per_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Lista Precio", Err)
        Err.Clear()
    End Sub



    Public Function EliminarPerfil(ByVal per_id As Integer) As Boolean
        'Procedimiento para la eliminar un registro en la tabla PERFIL Y PERFIL_TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        EliminarPerfil = False
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql = New SqlCommand("delete from PERFIL_TEST where per_id = " & per_id & "", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_strsql = New SqlCommand("delete from PERFIL where per_id = " & per_id & "", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Perfil", CStr(per_id), g_invitadoID, "", "", "")
        EliminarPerfil = True
        Exit Function
MsgError:
        EliminarPerfil = False
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Eliminar Perfil", Err)
        Err.Clear()
    End Function

    Public Function BuscarPerfil(ByVal per_nombre As String) As Boolean
        'Funci�n para consultar si existe el nombre de un perfil antes de insertar otra igual 
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        dt_operacion.SelectCommand = New SqlCommand("select * from perfil where per_nombre = '" & per_nombre & "'", cls_operacion.conn_sql)
        Dim act As New DataSet()
        Dim dtrow As DataRow
        dt_operacion.Fill(act, "Registros")
        For Each dtrow In act.Tables("Registros").Rows
            If (IsDBNull(dtrow(0))) Then
                BuscarPerfil = False
            Else
                BuscarPerfil = True
            End If
            Exit For
        Next
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar Perfil", Err)
        Err.Clear()
    End Function

    Public Function BuscarPerfilID(ByVal per_id As Single) As DataSet
        'Funci�n para consultar los datos del perfil de acuerdo al ID del perfil
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        dt_operacion.SelectCommand = New SqlCommand("select per_nombre, per_obs from perfil where per_id = " & per_id & "", cls_operacion.conn_sql)
        BuscarPerfilID = New DataSet()
        dt_operacion.Fill(BuscarPerfilID, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Buscar Perfil", Err)
        Err.Clear()
    End Function

    Public Sub ActualizarPerfil(ByVal Per_id As Integer, ByVal per_nombre As String, _
                          ByVal per_Obs As String, ByRef lst_testperfil As ListBox, ByVal estado As Single)
        'Procedimiento para la actualizar un registro en la tabla PERFIL Y PERFIL_TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        'Guardar los datos generales del Perfil
        Dim str_sql As SqlCommand
        str_sql = New SqlCommand("update PERFIL set per_nombre = '" & _
        per_nombre & "', per_obs = '" & per_Obs & "'  where per_id = " & Per_id & "", cls_operacion.conn_sql)
        str_sql.ExecuteNonQuery()
        'En caso de haber sido utilizado el Perfil en una Factura o Pedido, ya no se pueden realizar cambios
        'en los test que componen el perfil, para lo cual consulto pedidos y facturas.
        If PerfilUtilizado(Per_id) = False Then
            str_sql = New SqlCommand("update PERFIL set per_estado=" & estado & " where per_id = " & Per_id & "", cls_operacion.conn_sql)
            str_sql.ExecuteNonQuery()
            Dim i, x As Integer
            Dim s As String
            'Borro los test anteriores asignados al perfil 
            str_sql = New SqlCommand("delete from perfil_test where per_id = " & Per_id & "", cls_operacion.conn_sql)
            str_sql.ExecuteNonQuery()
            'Guardo los nuevos Test del Perfil
            For i = 0 To (lst_testperfil.Items.Count - 1)
                s = lst_testperfil.Items.Item(i)
                x = s.Substring(100, 6)
                str_sql = New SqlCommand("Insert into PERFIL_TEST values (" & x & ", " & Per_id & ")", cls_operacion.conn_sql)
                str_sql.ExecuteNonQuery()
            Next
            g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Perfil", "PERFIL=" & per_nombre, g_sng_user, "", "", "")
        Else
            MsgBox("La lista Test del Perfil, no puede ser alterada porque el perfil" & Chr(13) & "ya ha sido utilizado en pedidos.", MsgBoxStyle.Information, "ANALISYS")
        End If
        cls_operacion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar perfil", Err)
        Err.Clear()
    End Sub


    Public Sub EliminoPerfilMicro()
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim del As String = "delete from Test_cultivo;"
        cls_operacion.sql_Conectar()
        Dim str_del As SqlCommand
        str_del = New SqlCommand(del, cls_operacion.conn_sql)
        str_del.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar perfil Micro", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarPerfilMicro(ByVal dtv_cultivos As DataView, ByRef lst_ParamPerfil As ListBox)
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str As String = ""
        Dim str_sql As SqlCommand
        Dim i, j As Integer
        cls_operacion.sql_Conectar()
        For i = 0 To dtv_cultivos.Table.Rows.Count - 1
            For j = 0 To lst_ParamPerfil.Items.Count - 1
                str = "insert into Test_cultivo values(" & CInt(dtv_cultivos.Item(i).Row(0)) & "," & Trim(Mid(lst_ParamPerfil.Items(j), 101, Len(lst_ParamPerfil.Items(j)))) & "," & dtv_cultivos.Item(i).Row(3) & ");"
                str_sql = New SqlCommand(str, cls_operacion.conn_sql)
                str_sql.ExecuteNonQuery()
            Next
        Next
        cls_operacion.odbc_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar perfil Micro", Err)
        Err.Clear()
    End Sub


    Public Function LeerMaxCodPerfil() As Integer
        'Funcion para la consultar el c�digo m�ximo de la tabla PERFIL   
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxCodPerfil = CInt(New SqlCommand("Select isnull(Max(per_id),0) from PERFIL", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodPerfil", Err)
        Err.Clear()
    End Function

    Public Function PerfilUtilizado(ByVal per_id As Integer) As Boolean
        'Funci�n para consultar si un perfil ya ha sido utilizado o no en una factura o pedido
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        'Consulto Pedido_detalle
        If CInt(New SqlCommand("SELECT count(PER_ID) from PEDIDO_DETALLE where PER_ID = " & per_id & " ", opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
            PerfilUtilizado = True
        Else
            PerfilUtilizado = False
            'Consulto Factura_Detalle:
            'If CInt(New SqlCommand("SELECT Count(tes_id) FROM(FACTURA_DETALLE) WHERE (TES_ID= " & per_id & " AND FAD_TIPO ='P')", opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
            'PerfilUtilizado = True
            'End If
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Existe Lista Precio", Err)
        Err.Clear()
    End Function

    Public Function LeerPerfil_test(ByVal per_id As Integer) As DataSet
        'Funcion para la consultar los test de un perfil
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_Conectar()
        dt_operacion.SelectCommand = New SqlCommand("SELECT tes_id FROM PERFIL_TEST where per_id = " & per_id & "", cls_operacion.conn_sql)
        LeerPerfil_test = New DataSet()
        dt_operacion.Fill(LeerPerfil_test, "RegistrosP")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Perfil Test", Err)
        Err.Clear()
    End Function

    Sub LlenarListaPerfil(ByRef lst_perfil As ListBox, ByRef con_nombre As String)
        'procedimiento que llena un lista con los datos de un perfil
        'recibe tnambien el convenio para calcular el precio de cada uno de los perfiles
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        lst_perfil.Items.Clear()
        Dim odr_operacion As SqlDataReader = New SqlCommand("SELECT per_id, per_nombre, per_obs FROM PERFIL where per_estado=1 order by per_nombre", cls_operacion.conn_sql).ExecuteReader
        Dim precio As Double
        While odr_operacion.Read
            precio = LeerPrecioPerfil(odr_operacion.GetValue(1).ToString(), con_nombre)
            lst_perfil.Items.Add(odr_operacion.GetValue(1).ToString().PadRight(100) & odr_operacion.GetValue(0).ToString().PadRight(10) & precio.ToString.PadRight(10) & "P".PadRight(5))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Lista Perfil", Err)
        Err.Clear()
    End Sub

    Public Function LeerPrecioPerfil(ByVal per_nombre As String, ByRef con_nombre As String) As Double
        'funcion que obtiene le precion de un determinado perfil
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_perfil As SqlDataReader = New SqlCommand("Select sum(lip_precio) from lista_precio, perfil_test, perfil where lista_precio.con_nombre='" & con_nombre & "' and perfil.per_id=perfil_test.per_id and lista_precio.tes_id=perfil_test.tes_id and perfil.per_nombre='" & per_nombre & "'", opr_conexion.conn_sql).ExecuteReader
        LeerPrecioPerfil = 0
        While odr_perfil.Read
            If Not IsDBNull(odr_perfil.GetValue(0)) Then
                LeerPrecioPerfil = odr_perfil.GetValue(0)
            End If
        End While
        odr_perfil.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Precio Perfil", Err)
        Err.Clear()
    End Function

End Class
