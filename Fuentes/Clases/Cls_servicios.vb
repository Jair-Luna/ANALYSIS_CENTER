'*************************************************************************
' Nombre:   Cls_servicios
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla Servicios
' Autores:  RFN
' Fecha de Creaci�n: Junio del 2007
' Autores:  RFN
' Ultima Modificaci�n: 28/06/2007
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_servicios
    Public Sub LlenarCmb_Servicios(ByRef cmb_area As ComboBox)
        'Funcion para la Llenar un combo con todas los servicios
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_filaAre As DataRow
        dts_area = LeerServicios()
        For Each dtr_filaAre In dts_area.Tables("Registros").Rows
            cmb_area.Items.Add(dtr_filaAre("ser_nombre").ToString())
        Next
        cmb_area.SelectedIndex = 0
    End Sub

    Public Function LeerServicios() As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()
        oda_operacion.SelectCommand = New SqlCommand("SELECT SERVICIO.SER_NOMBRE FROM SERVICIO GROUP BY SERVICIO.ser_id, servicio.ser_nombre, servicio.ser_tipo order by SERVICIO.ser_id;", opr_Conexion.conn_sql)
        LeerServicios = New DataSet("Registros")
        oda_operacion.Fill(LeerServicios, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Servicios - Cls_Servicios", Err)
        Err.Clear()
    End Function

    Public Sub LlenarCmb_ExamenTODOS(ByRef cmb_test As ComboBox)
        'Funcion para la Llenar un combo con todas los servicios
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_filaAre As DataRow
        dts_area = LeerTest()
        cmb_test.Items.Add("TODOS")
        For Each dtr_filaAre In dts_area.Tables("Registros").Rows
            cmb_test.Items.Add(dtr_filaAre("Tes_nombre").ToString().PadRight(100) & dtr_filaAre("Tes_nombre").ToString().PadRight(10))
        Next
        cmb_test.SelectedIndex = 0
    End Sub


    Public Sub LlenarCmb_Examen(ByRef cmb_test As ComboBox)
        'Funcion para la Llenar un combo con todas los servicios
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_filaAre As DataRow
        dts_area = LeerTest()
        For Each dtr_filaAre In dts_area.Tables("Registros").Rows
            cmb_test.Items.Add(dtr_filaAre("Tes_nombre").ToString().PadRight(100) & dtr_filaAre("Tes_nombre").ToString().PadRight(10))
        Next
        cmb_test.SelectedIndex = 0
    End Sub

    Public Function LeerTest() As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()
        oda_operacion.SelectCommand = New SqlCommand("SELECT TEST.TES_NOMBRE, TEST.TES_ID FROM TEST where test.TES_TIPO = 'Examen' order by TEST.tes_nombre asc;", opr_Conexion.conn_sql)
        LeerTest = New DataSet("Registros")
        oda_operacion.Fill(LeerTest, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer examen", Err)
        Err.Clear()
    End Function


    Public Function LeerServiciosGrid() As DataSet
        'Funcion para la consultar los datos de la tabla Servicios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()
        oda_operacion.SelectCommand = New SqlCommand("SELECT * FROM Servicio order by ser_tipo, ser_nombre", opr_Conexion.conn_sql)
        LeerServiciosGrid = New DataSet("Registros")
        oda_operacion.Fill(LeerServiciosGrid, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Areas", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodServicios() As Integer
        'Funcion para la consultar el c�digo m�ximo de la tabla Servicio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodServicios = CInt(New SqlCommand("Select isnull(max(ser_id),0) from Servicio;", opr_Conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max Cod Servicio, Cls_Servicio.", Err)
        Err.Clear()
    End Function

    Public Sub GuardarServicio(ByVal ser_Cod As Integer, ByVal serNom As String, ByVal sertipo As String, ByVal correo As String, ByVal celular As String)
        'Procedimiento para la insertar un registro en la tabla Servicio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into Servicio values (" & ser_Cod & ", '" & serNom & "', '" & sertipo & "', '" & correo & "', '" & celular & "')"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Servicio", "SERVICIO=" & serNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Servicio.", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarServicio(ByVal serCod As Integer, ByVal serNom As String, _
                              ByVal serTipo As String, ByVal correo As String, ByVal celular As String)
        'Procedimiento para la actualizar un registro en la tabla Servicio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "Update servicio set ser_nombre = '" & _
                      serNom & "', ser_tipo = '" & serTipo & "', ser_correo = '" & correo & "', ser_telefono = '" & celular & "' where ser_id = " & serCod
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada en el LOG
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Servicio", "SERVICIO=" & serNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Servicio", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarServicio(ByVal serCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla Servicio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "delete from Servicio where ser_id = " & serCod & ""
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Servicio", "SERVICIO=" & serCod, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Servicio", Err)
        Err.Clear()
    End Sub

End Class
