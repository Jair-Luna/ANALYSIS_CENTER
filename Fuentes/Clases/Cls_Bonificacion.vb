'*************************************************************************
' Nombre:   Cls_Bonificacion
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de bonificaciones 
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data
Imports System.Data.SqlClient



Public Class Cls_Bonificacion

    Public Function LeerBonificacion() As DataSet
        'funcion que nos permite obtener todos los datos de las bonificaciones
        'y retornalas en un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select bon_nombre, bon_porcentaje, bon_nombre as bon_nombre2 from Bonificacion", cls_operacion.conn_sql)
        LeerBonificacion = New DataSet()
        oda_operacion.Fill(LeerBonificacion, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Bonificacion", Err)
        Err.Clear()
    End Function

    Public Function LeerEspecialidad() As DataSet
        'funcion que nos permite obtener todos los datos de las especialidad de los Medicos
        'y retornalas en un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select esp_desc, esp_id from Especialidad", cls_operacion.conn_sql)
        LeerEspecialidad = New DataSet()
        oda_operacion.Fill(LeerEspecialidad, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Especialidad", Err)
        Err.Clear()
    End Function

    Public Sub EliminaBonificacion(ByVal bon_nombre As String)
        'funcion que nos permite la eliminacion de una bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from Bonificacion where bon_nombre = '" & bon_nombre & "'"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Bonificacion", "Bonificacion=" & bon_nombre, g_sng_user, "", "", "")
        MsgBox("La Bonificacion fue eliminada", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Eliminar Bonificacion", Err)
        Err.Clear()
    End Sub

    Public Sub GuardarBonificacion(ByVal bon_nombre As String, ByVal bon_porcentaje As Double)
        'funcion que nos permite guardar los datos de una nueva bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "insert into bonificacion(bon_nombre, bon_porcentaje) values('" & bon_nombre & "'," & bon_porcentaje & ")"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Guardar Bonificacion", "Bonificacion=" & bon_nombre & " " & bon_porcentaje, g_sng_user, "", "", "")
        MsgBox("La Bonificacion fue almacenada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Bonificacion", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarBonificacion(ByVal bon_nombre As String, ByVal bon_porcentaje As Double, ByVal bon_nombre_antiguo As String)
        'funcion que nos permite actualizar los datos de las bonificaciones
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "update bonificacion set bon_nombre='" & bon_nombre & "', bon_porcentaje=" & bon_porcentaje & " where bon_nombre='" & bon_nombre_antiguo & "'"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Bonificacion", "Bonificacion=" & bon_nombre & " " & bon_porcentaje, g_sng_user, "", "", "")
        MsgBox("La Bonificacion fue modificada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Bonificacion", Err)
        Err.Clear()
    End Sub


    Sub LlenarComboBonificacion(ByRef cmb_bonificacion As ComboBox)
        'funcion para llenar un combo con las bonificaciones
        'se recibe un combo por referencia
        On Error Resume Next
        Dim dts_bonificacion As DataSet
        Dim dtr_fila As DataRow
        dts_bonificacion = LeerBonificacion()
        cmb_bonificacion.Items.Clear()
        For Each dtr_fila In dts_bonificacion.Tables("Registros").Rows
            cmb_bonificacion.Items.Add(dtr_fila("bon_nombre").ToString())
        Next
        cmb_bonificacion.SelectedIndex = 0
    End Sub

    Sub LlenarComboEspecialidad(ByRef cmb_especialidad As ComboBox)
        'funcion para llenar un combo con las especialidades
        On Error Resume Next
        Dim dts_bonificacion As DataSet
        Dim dtr_fila As DataRow
        dts_bonificacion = LeerEspecialidad()
        cmb_especialidad.Items.Clear()
        For Each dtr_fila In dts_bonificacion.Tables("Registros").Rows
            cmb_especialidad.Items.Add(dtr_fila("esp_desc").ToString().PadRight(75) & dtr_fila("esp_id").ToString().PadRight(5))
        Next
        cmb_especialidad.SelectedIndex = 0
    End Sub

    Sub LlenarGridBonificacion(ByRef dgrd_Bonificacion As DataGrid)
        'funcion que nos permite cargar los datos de las bonificaciones en 
        ' un data grid
        On Error Resume Next
        Dim dts_Bonificacion As DataSet
        Dim dtv_Bonificacion As New DataView()
        dts_Bonificacion = LeerBonificacion()
        With dtv_Bonificacion
            .Table = dts_Bonificacion.Tables("Registros")
            .Sort = "bon_nombre"
        End With
        dgrd_Bonificacion.DataSource = dtv_Bonificacion
        dgrd_Bonificacion.NavigateTo(0, "Registros")
        dgrd_Bonificacion.CaptionText = "BONIFICACIONES"

    End Sub

    Public Function BuscarBonificacion(ByVal bon_nombre As String) As Boolean
        'funcion que nos permite ferificar si existe una boniicacion especifica se recibe
        ' le nombre de la bonificacion y se debuelve on boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from bonificacion where bon_nombre = '" & bon_nombre & "'", opr_Conexion.conn_sql)
        Dim dts_bonificacion As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_bonificacion, "Registros")
        For Each dtr_fila In dts_bonificacion.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarBonificacion = False
            Else
                BuscarBonificacion = True
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Buscar Bonificacion", Err)
        Err.Clear()
    End Function
End Class