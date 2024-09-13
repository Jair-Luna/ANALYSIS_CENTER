'*************************************************************************
' Nombre:   Cls_Areas
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla AREA 
' Autores:  RFN 
' Fecha de Creaci�n: Julio del 2002
' Autores:  RFN
' Ultima Modificaci�n: 18/07/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Cls_Areas


    Public Sub LlenarCmb_Area_Id(ByRef cmb_area As ComboBox)
        'Funcion para la Llenar un combo con todas las areas.
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_filaAre As DataRow
        dts_area = LeerAreas_I()
        For Each dtr_filaAre In dts_area.Tables("Registros").Rows
            'cmb_area.Items.Add(dtr_filaAre("i_ades").ToString())
            cmb_area.Items.Add(dtr_filaAre("i_ades").ToString().PadRight(50) & dtr_filaAre("i_aid").ToString())
        Next
        cmb_area.Text = "TODOS"
    End Sub


    Public Function LeerAreas_I() As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()

        oda_operacion.SelectCommand = New SqlCommand("SELECT I_ADES, I_AID FROM I_AREA order by I_AID", opr_Conexion.conn_sql)

        LeerAreas_I = New DataSet("AREAS")
        oda_operacion.Fill(LeerAreas_I, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Areas INV", Err)
        Err.Clear()


    End Function

    Public Function LeerPadre() As DataSet
        'Funcion para la consultar los datos de la tabla TEST-PADRE
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()

        oda_operacion.SelectCommand = New SqlCommand("SELECT TES_NOMBRE,TES_ID FROM TEST WHERE TES_TIPO = 'Examen' order by tes_nombre asc;", opr_Conexion.conn_sql)
        LeerPadre = New DataSet("PADRES")

        oda_operacion.Fill(LeerPadre, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Areas", Err)
        Err.Clear()
    End Function


    Public Function BuscaTestId(ByVal test As String) As Integer
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDr As SqlDataReader
            Dim str_sql As String
            str_sql = "select tes_id from test where tes_nombre ='" & test & "' "
            opr_conexion.sql_conectar()
            oDr = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
            While oDr.Read
                BuscaTestId = oDr.GetValue(0).ToString()
            End While
            opr_conexion.sql_desconn()
        Catch
            MsgBox("No pudo buscar el nombre del test. busca nombre test", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try


    End Function

    Public Function LeerTest(ByVal test As Integer) As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()

        Dim selectCommand As SqlCommand = New SqlCommand()

        oda_operacion.SelectCommand = New SqlCommand("SELECT TES_ID, TES_NOMBRE FROM TEST order by TES_NOMBRE", opr_Conexion.conn_sql)

        LeerTest = New DataSet("TEST")

        oda_operacion.Fill(LeerTest, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxOrdenArea() As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxOrdenArea = CInt(New SqlCommand("Select isnull(max(are_obs),0) from AREA", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max Orden Area", Err)
        Err.Clear()
    End Function



    Public Function LeerMaxCodArea() As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodArea = CInt(New SqlCommand("Select isnull(max(are_id),0) from AREA", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodArea", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodTestParam() As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodTestParam = CInt(New SqlCommand("Select isnull(max(tpa_id),0) from TEST_PARAMETRO", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTestParam", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxOrdenTestParam(ByVal tes_id) As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxOrdenTestParam = CInt(New SqlCommand("Select isnull(max(tpa_orden),0) from TEST_PARAMETRO where Tes_id = " & Convert.ToInt32(tes_id) & ";", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTestParam", Err)
        Err.Clear()
    End Function

    Public Sub LlenarCmb_Area(ByRef cmb_area As ComboBox)
        'Funcion para la Llenar un combo con todas las areas.
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_filaAre As DataRow
        dts_area.Clear()

        dts_area = LeerAreas()
        cmb_area.Items.Clear()

        For Each dtr_filaAre In dts_area.Tables("Registros").Rows
            cmb_area.Items.Add(dtr_filaAre("are_nombre").ToString().PadRight(100) & dtr_filaAre("ARE_ID").ToString().PadRight(10))
        Next

    End Sub


    Public Sub LlenarCmb_AreaComp(ByRef cmb_area As ComboBox)
        'Funcion para la Llenar un combo con todas las areas.
        On Error Resume Next
        Dim dts_area As DataSet = Nothing
        Dim dtr_filaAre As DataRow
        dts_area = LeerAreas()


        '''AQUI(AREA)
        For Each dtr_filaAre In dts_area.Tables("Registros").Rows
            cmb_area.Items.Add(dtr_filaAre("are_nombre").ToString().PadRight(150) & dtr_filaAre("are_id").ToString().PadRight(10))
        Next
        cmb_area.SelectedIndex = 0
    End Sub



    Public Sub LlenarCmb_Padre(ByRef cmb_tipo As ComboBox)
        'Funcion para la Llenar un combo con todas las areas.
        On Error Resume Next
        Dim dts_tipo As DataSet = Nothing
        Dim dtr_filaTipo As DataRow
        dts_tipo = LeerPadre()
        cmb_tipo.Items.Add("NINGUNO".PadRight(100) & "0".PadRight(10))
        For Each dtr_filaTipo In dts_tipo.Tables("Registros").Rows
            cmb_tipo.Items.Add(dtr_filaTipo("TES_NOMBRE").ToString().PadRight(100) & dtr_filaTipo("TES_ID").ToString().PadRight(10))
        Next
        cmb_tipo.SelectedIndex = 0
    End Sub


    Public Sub LlenarCmb_Test(ByRef cmb_test As ComboBox)
        'Funcion para la Llenar un combo con todos los test.
        On Error Resume Next
        Dim dts_test As DataSet
        Dim dtr_filaTest As DataRow
        dts_test = LeerTest()

        For Each dtr_filaTest In dts_test.Tables("Registros").Rows
            'cmb_test.Items.Insert(dtr_filaTest("tes_id"), dtr_filaTest("tes_nombre"))
            cmb_test.Items.Add(dtr_filaTest("tes_nombre").ToString())
        Next
        cmb_test.SelectedIndex = 0
    End Sub


    Public Sub LlenarCmb_TestParam(ByRef cmb_test As ComboBox, ByVal arreglo As String)
        'Funcion para la Llenar un combo con todos los test.
        On Error Resume Next
        Dim dts_test As DataSet
        Dim dtr_filaTest As DataRow
        dts_test.Clear()
        cmb_test.Items.Clear()
        dts_test = LeerTestPlantillas(Mid(arreglo, 1, Len(arreglo) - 1))

        For Each dtr_filaTest In dts_test.Tables("Registros").Rows
            cmb_test.Items.Add(dtr_filaTest("tes_nombre").ToString().PadRight(100) & dtr_filaTest("tes_id").ToString())
        Next
    End Sub


    Public Function BuscaIdSonPlatilla() As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDr As SqlDataReader
            Dim str_sql As String
            str_sql = "select case when count(tes_id) > 1 or count(tes_id) is not null then 'Si' end as TIENE_HIJOS,test.TES_PADRE from test where test.TES_PADRE <> 0 group by test.TES_PADRE;"
            opr_conexion.sql_conectar()
            oDr = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
            While oDr.Read
                BuscaIdSonPlatilla = BuscaIdSonPlatilla & oDr.GetValue(1).ToString() & ","
            End While
            opr_conexion.sql_desconn()
        Catch
            MsgBox("No pudo buscar el nombre del test. busca nombre test", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try


    End Function



    Public Sub GuardarArea(ByVal areCod As Integer, ByVal areNom As String, _
                              ByVal areObs As String, ByVal tit_id As Integer, ByVal EsOcup As Byte)
        'Procedimiento para la insertar un registro en la tabla AREA
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into AREA values (" & areCod & ", '" & _
            areNom & "', '" & areObs & "', '" & Today & "', " & tit_id & " ," & EsOcup & ")"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nueva Area", "Area=" & areNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, GuardarArea", Err)
        Err.Clear()
    End Sub

    'RF
    Public Sub GuardarTestParametro(ByVal abreviatura As String, ByVal tes_id As String)
        'Procedimiento para la insertar un registro en la tabla AREA
        On Error GoTo MsgError

        If (BuscarTestParam(abreviatura, tes_id) = True) Then
            MessageBox.Show("El nombre de la abreviatura ya existe.", "ANALISYS", MessageBoxButtons.OK)
        Else
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "Insert into test_parametro values (" & (LeerMaxCodTestParam() + 1) & ", '" & abreviatura & "', '" & tes_id & "', " & (LeerMaxOrdenTestParam(tes_id) + 1) & ")"
            opr_conexion.sql_conectar()
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            opr_conexion.sql_desconn()
            MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
            'Se registra de la transaccion realizada
            g_opr_usuario.CargarTransaccion(g_str_login, "Nueva Abreviatura", "Parametro=" & abreviatura, g_sng_user, "", "", "")
        End If


        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, GuardarArea", Err)
        Err.Clear()
    End Sub

    Public Sub EliminaTestParametro(ByVal abreviatura As String, ByVal tes_id As String)
        'Procedimiento para la insertar un registro en la tabla AREA
        On Error GoTo MsgError
        Dim sw As Integer
        sw = MessageBox.Show("Esta seguro de eliminar la abreviatura: " & abreviatura & " ?", "ANALISYS", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If (sw <= 1) Then
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "Delete from test_parametro where tpa_desc = '" & abreviatura & "' and tes_id = '" & tes_id & "'"
            opr_conexion.sql_conectar()
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            opr_conexion.sql_desconn()
            MsgBox("Registro eliminado.", MsgBoxStyle.Information, "ANALISYS")
            'Se registra de la transaccion realizada
            g_opr_usuario.CargarTransaccion(g_str_login, "Elimina Abreviatura", "Abreviatura=" & abreviatura, g_sng_user, "", "", "")
        Else

        End If

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, GuardarArea", Err)
        Err.Clear()
    End Sub

    Public Function BuscarTestParam(ByVal TestParam As String, ByVal tes_id As String) As Boolean
        'Funci�n para consultar si existe el nombre de una area antes de insertar otra igual 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from test_parametro where tpa_desc = '" & TestParam & "' and tes_id = '" & tes_id & "'", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarTestParam = False
            Else
                BuscarTestParam = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar Area", Err)
        Err.Clear()
    End Function


    Public Function BuscarArea(ByVal are_nombre As String) As Boolean
        'Funci�n para consultar si existe el nombre de una area antes de insertar otra igual 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from area where are_nombre = '" & are_nombre & "'", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarArea = False
            Else
                BuscarArea = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar Area", Err)
        Err.Clear()
    End Function

    Public Sub ActualizarAreas(ByVal areCod As Integer, ByVal areNom As String, _
                              ByVal areObs As String, ByVal tit_id As Integer, ByVal EsOcup As Byte)
        'Procedimiento para la actualizar un registro en la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "Update AREA set are_nombre = '" & _
                      areNom & "', are_obs = '" & areObs & "', are_fecing = '" & _
                      Today & "', tit_id = " & tit_id & ", ARE_OCUPACIONAL = " & EsOcup & " where are_id = " & areCod
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada en el LOG
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Area", "Area=" & areNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Area", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarAreasOrden(ByVal areCod As Integer, _
                              ByVal areObs As String)
        'Procedimiento para la actualizar un registro en la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "Update AREA set are_obs = '" & areObs & "'where are_id = " & areCod
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada en el LOG
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Orden Area", "Area=" & areCod, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Area", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarArea(ByVal areaCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla AREA    
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "delete from AREA where are_id = " & areaCod & ""
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Area", "AreaID=" & areaCod, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Area", Err)
        Err.Clear()
    End Sub

    Public Function AreaId(ByVal areaNombre As String) As Integer
        'Funci�n que consulta el area_id de una �rea, enviando el nombre de la misma 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select are_id from AREA where are_nombre = '" & areaNombre & "'", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dt_fila As DataRow
        For Each dt_fila In dts_area.Tables("Registros").Rows
            AreaId = dt_fila(0)
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Area Id", Err)
        Err.Clear()
    End Function

    Public Function AreaNombre(ByVal areaId As Integer) As String
        'Funci�n que consulta el area_Nombre de una �rea, enviando el id de la misma 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select are_Nombre, are_id from AREA where are_id = " & areaId & "", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            AreaNombre = dtr_fila(0).ToString.PadRight(100) & dtr_fila(1).ToString.PadRight(10)
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Area Nombre", Err)
        Err.Clear()
    End Function


    Public Function I_AreaNombre(ByVal I_aid As Integer) As String
        'Funci�n que consulta el area_Nombre de una �rea, enviando el id de la misma 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select I_ades, I_aid from I_AREA where I_aid = " & I_aid & "", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            I_AreaNombre = dtr_fila(0).ToString.PadRight(50) & dtr_fila(1).ToString.PadRight(10)
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Area Nombre", Err)
        Err.Clear()
    End Function


    Public Function PRES_ID_Nombre(ByVal PRES_ID As Integer) As String
        'Funci�n que consulta el area_Nombre de una �rea, enviando el id de la misma 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select i_presentacion.PRES_DESCRIPCION, i_presentacion.PRES_ID from i_presentacion where i_presentacion .PRES_ID = " & PRES_ID & "", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            PRES_ID_Nombre = dtr_fila(0).ToString.PadRight(100) & dtr_fila(1).ToString.PadRight(10)
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Area Nombre", Err)
        Err.Clear()
    End Function

    Public Function I_SerieNombre(ByVal SER_ID As Integer) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select SER_NOMBRE, SER_ID from vacunaSerie where SER_ID = " & SER_ID & "", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            I_SerieNombre = dtr_fila(0).ToString.PadRight(100) & dtr_fila(1).ToString.PadRight(10)
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Serie Nombre", Err)
        Err.Clear()
    End Function


    Sub LlenaGridAreas(ByRef dgrd_paciente As DataGrid)
        'Lleno el grid pasado por refrencia
        On Error Resume Next
        Dim dts_grid As DataSet
        Dim dtv_area As New DataView()
        dts_grid = LeerAreas()
        With dtv_area
            .Table = dts_grid.Tables("registros")
            .Table.Columns(0).ColumnName = "ID"
            .Table.Columns(1).ColumnName = "NOMBRE"
            .Table.Columns(2).ColumnName = "OBSERVACION"
            .Sort = "OBSERVACION"
        End With
        dgrd_paciente.DataSource = dtv_area
        dgrd_paciente.NavigateTo(0, "Registros")
        dgrd_paciente.CaptionText = "AREAS"
    End Sub

    Sub LlenarListaAreas(ByRef chkl_areas As CheckedListBox)
        'funcion que llena en un lista las areas
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_fila As DataRow
        Dim int_i As Integer
        Dim sng_flag As Single
        dts_area = LeerAreas()
        chkl_areas.Items.Clear()
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            chkl_areas.Items.Add(dtr_fila("are_nombre").ToString().PadRight(150) & dtr_fila("are_id").ToString(), False)
        Next
    End Sub


    Public Function LeerAreas() As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        LeerAreas = Nothing
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()


        oda_operacion.SelectCommand = New SqlCommand("SELECT ARE_ID, ARE_NOMBRE, ARE_OBS, tit_id FROM AREA order by ARE_OBS asc", opr_Conexion.conn_sql)
        LeerAreas = New DataSet("AREAS")

        oda_operacion.Fill(LeerAreas, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Areas", Err)
        Err.Clear()
    End Function


    Public Function LeerTest() As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        LeerTest = Nothing
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()

        oda_operacion.SelectCommand = New SqlCommand("SELECT TES_ID, TES_NOMBRE FROM TEST where test.TES_TIPO ='EXAMEN' order by TES_OBS;", opr_Conexion.conn_sql)
        LeerTest = New DataSet("TEST")

        oda_operacion.Fill(LeerTest, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Auto", Err)
        Err.Clear()
    End Function


    Public Function LeerTestPlantillas(ByVal arreglo As String) As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        LeerTestPlantillas = Nothing
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        opr_Conexion.sql_conectar()

        Dim selectCommand As SqlCommand = New SqlCommand()

        str_sql = "SELECT TES_ID, TES_NOMBRE FROM TEST where test.TES_TIPO ='EXAMEN' AND TES_ID IN(" & arreglo & ") order by TES_OBS;"
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerTestPlantillas = New DataSet("TEST")

        oda_operacion.Fill(LeerTestPlantillas, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Auto", Err)
        Err.Clear()
    End Function


    Public Sub Leertestarea(ByVal are_id As Integer, ByVal dtt_test As DataTable)
        'Funci�n para consultar el orden de los tests.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        'str_sql = "SELECT test.tes_id as tes_id, test.tes_nombre as tes_nombre, test.TES_RESDEFECTO as TES_RESDEFECTO, test.tes_ordenimp as tes_ordenimp " & _
        '          "FROM area, test WHERE area.are_id = test.are_id AND " & _
        '          "TES_TIPO  in('EXAMEN') and area.are_nombre = '" & area_nombre & "' order by tes_ordenimp;"
        '
        str_sql = "select TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, TES_RESDEFECTO, TES_ORDENIMP  " & _
                    "from test " & _
                    "where ARE_ID = " & are_id & " AND TES_TIPO IN('Examen','Parametro')" & _
                    "order by TES_ORDENIMP asc"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_test)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Area orden", Err)
        Err.Clear()
    End Sub


    Public Sub LeertestRango(ByVal are_id As Integer, ByVal dtt_test As DataTable)
        'Funci�n para consultar el orden de los tests.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String

        str_sql = "select TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, TES_RESDEFECTO, TES_ORDENIMP  " & _
                    "from test " & _
                    "where ARE_ID = " & are_id & " AND TES_TIPO IN('Examen','Parametro')" & _
                    "order by TES_ORDENIMP asc"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_test)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Area orden", Err)
        Err.Clear()
    End Sub



    Public Sub LeerArea(ByVal dtt_Area As DataTable)
        'Funcion para consultar el orden de los tests.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        str_sql = "SELECT ARE_ID, ARE_NOMBRE, ARE_OBS, tit_id, ARE_OCUPACIONAL FROM AREA order by ARE_OBS ASC"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_Area)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Area orden", Err)
        Err.Clear()
    End Sub




    Public Sub Leertestparametro(ByVal tes_id As String, ByVal dtt_test As DataTable)
        'Funci�n para consultar el id de los tests.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        str_sql = "SELECT param.tpa_id as Codigo, param.tpa_desc as Parametro, param.tes_id as Test, param.tpa_orden as Orden from test_parametro as param " & _
                  "where param.tes_id = " & tes_id & " order by param.tpa_orden, param.tpa_id; "
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_test)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Area", Err)
        Err.Clear()
    End Sub



    Public Sub LeerExamenParametro(ByVal tes_id As String, ByVal dtt_test As DataTable)
        'Funci�n para consultar el id de los tests.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        'rrr
        str_sql = "SELECT TEST.TES_ID, TEST.TES_NOMBRE, TES_RESDEFECTO, TEST.TES_ORDENIMP FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID WHERE TEST.TES_PADRE = " & tes_id & " and TEST.TES_TIPO = 'Parametro' order by TEST.TES_ORDENIMP, TEST.TES_NOMBRE, TEST.TES_ID;"

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_test)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Examen PArametro", Err)
        Err.Clear()
    End Sub

    Public Sub Guardarordentest(ByRef dgrd_testorden As DataGrid, ByVal x As Integer, ByVal nombre As String)
        'Procedimiento para la actualizar el numero de orden de impresion del test
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        For int_i = 0 To (x)
            'str_sql = "update test set test.tes_ordenimp= " & dgrd_testorden.Item(int_i, 2) & " from TEST INNER JOIN AREA ON TEST.ARE_ID  = AREA.ARE_ID where test.tes_id = " & dgrd_testorden.Item(int_i, 0) & "  and area.are_nombre = '" & nombre & "'; "
            str_sql = "update test set test.tes_ordenimp= " & int_i & " from TEST INNER JOIN AREA ON TEST.ARE_ID = AREA.ARE_ID where test.tes_id = " & dgrd_testorden.Item(int_i, 0) & ";"
            odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
        Next
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Orden Test", Err)
        Err.Clear()
    End Sub

    Public Sub GuardarordenArea(ByRef dgrd_Areaorden As DataGrid, ByVal x As Integer)
        'Procedimiento para la actualizar el numero de orden de impresion del test
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        For int_i = 0 To (x)
            'str_sql = "update test set test.tes_ordenimp= " & dgrd_testorden.Item(int_i, 2) & " from TEST INNER JOIN AREA ON TEST.ARE_ID  = AREA.ARE_ID where test.tes_id = " & dgrd_testorden.Item(int_i, 0) & "  and area.are_nombre = '" & nombre & "'; "
            str_sql = "update area set area.are_obs= " & int_i & " from AREA where area.are_id = " & dgrd_Areaorden.Item(int_i, 0) & ";"
            odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
        Next
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Orden Test", Err)
        Err.Clear()
    End Sub
End Class
