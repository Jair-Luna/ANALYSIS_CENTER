'*************************************************************************
' Nombre:   Cls_Movimiento
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de los laboratorios
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Laboratorio

    Public Function LeerLab() As DataSet
        'funcion que retorna un dataset con los datos del los laboratorios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select LAB_NOMBRE, LAB_RUC, laboratorio.CIU_ID, LAB_DIRECCION, LAB_FONO, LAB_FAX, LAB_MAIL, LAB_WEB, LAB_ESPECIALIDAD, LAB_REPRESENTANTE, LAB_TIPO, LAB_ID, CIU_NOMBRE from laboratorio, ciudad where laboratorio.ciu_id=ciudad.ciu_id", opr_Conexion.conn_sql)
        LeerLab = New DataSet()
        oda_operacion.Fill(LeerLab, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada", Err)
        Err.Clear()
    End Function

    Public Sub GuardarLab(ByVal lab_id As Integer, ByVal lab_tipo As String, ByVal NomLab As String, ByVal RucLab As String, _
                          ByVal DirLab As String, ByVal TelfLab As String, _
                          ByVal FaxLab As String, ByVal Email As String, _
                          ByVal WebLab As String, ByVal EspLab As String, _
                          ByVal RepLab As String, ByVal idCiudad As Integer)
        'funcion que guarda los datos de un laboratorio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Insert into LABORATORIO(lab_nombre, lab_ruc, ciu_id, lab_direccion, lab_fono, lab_fax, lab_mail, lab_web, lab_especialidad, lab_representante, lab_tipo, lab_id) values ('" & NomLab & "', '" & _
            RucLab & "', " & idCiudad & ", '" & DirLab & "', '" & TelfLab & "', '" & _
            FaxLab & "', '" & Email & "', '" & WebLab & "', '" & EspLab & "', '" & _
            RepLab & "','" & lab_tipo & "'," & lab_id & ")", opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        dts_act = New DataSet()
        oda_operacion.Fill(dts_act, "Registros")
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Laboratorio", "Laboratorio=" & NomLab, g_sng_user, "", "", "")
        MsgBox("El laboratorio fue ingresado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarLab(ByVal lab_id As Integer, ByVal lab_tipo As String, ByVal NomLab As String, ByVal RucLab As String, _
                              ByVal DirLab As String, ByVal TelfLab As String, _
                              ByVal FaxLab As String, ByVal Email As String, _
                              ByVal WebLab As String, ByVal EspLab As String, _
                              ByVal RepLab As String, ByVal idCiudad As Integer)
        'funcion que actualiza los datos de un laboratorio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Update laboratorio set lab_Nombre = '" & NomLab & "', lab_direccion = '" & _
                DirLab & "', lab_fono = '" & TelfLab & "', lab_fax = '" & _
                FaxLab & " ', lab_mail = '" & Email & "', lab_Web = '" & _
                WebLab & "', lab_especialidad = '" & _
                EspLab & "', lab_representante = '" & _
                RepLab & "', ciu_id =" & _
                idCiudad & ", lab_tipo ='" & _
                lab_tipo & "', lab_ruc ='" & _
                RucLab & "' where Lab_id = " & _
                lab_id, opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        oda_operacion.Fill(dts_act, "Registros")
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Laboratorio", "Laboratorio=" & NomLab)
        MsgBox("El laboratorio fue modificado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada", Err)
        Err.Clear()
    End Sub

    Sub LlenarGridLab(ByRef dgrd_Laboratorio As DataGrid)
        'funcion que llena los datos de los laboratorios en un datagrid
        On Error Resume Next
        Dim dts_Laboratorio As DataSet
        Dim dtv_Laboratorio As New DataView()
        dts_Laboratorio = LeerLab()
        With dtv_Laboratorio
            .AllowNew = False
            .Table = dts_Laboratorio.Tables("Registros")
            .Sort = "lab_nombre"
        End With
        dgrd_Laboratorio.DataSource = dtv_Laboratorio
        dgrd_Laboratorio.NavigateTo(0, "Registros")
        dgrd_Laboratorio.CaptionText = "LABORATORIO"
    End Sub

    Public Sub EliminaLab(ByVal lab_id As String)
        'funcion que me permite eliminar un laboratorio, recibe el id del laboratorio
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from Laboratorio where lab_id = " & lab_id & ""
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Laboratorio", "Laboratorio=" & lab_id, g_sng_user, "", "", "")
        MsgBox("El laboratorio fue eliminado", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada", Err)
        Err.Clear()
    End Sub

    Public Function LeerMaxLab() As Integer
        'Procedimiento para extraer el c�digo m�ximo de laboratorio
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxLab = CInt(New SqlCommand("Select isnull(Max(lab_ID), 0) from Laboratorio", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada", Err)
        Err.Clear()
    End Function

    Public Function BuscarLab(ByVal lab_nombre As String) As Boolean
        'funcion que permite verificar la existencia de un laboratorio, recibe el nombre del laboratorio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from laboratorio where lab_nombre = '" & lab_nombre & "'", opr_Conexion.conn_sql)
        Dim dts_bonificacion As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_bonificacion, "Registros")
        For Each dtr_fila In dts_bonificacion.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarLab = False
            Else
                BuscarLab = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada", Err)
        Err.Clear()
    End Function

    Sub LlenarComboLab(ByRef cmb_laboratorio As ComboBox)
        'funcion que permite llenar un combo con los datos de los laboratorios
        On Error Resume Next
        Dim dts_laboratorio As DataSet
        Dim dtr_fila As DataRow
        dts_laboratorio = LeerLab()
        cmb_laboratorio.Items.Clear()
        For Each dtr_fila In dts_laboratorio.Tables("Registros").Rows
            cmb_laboratorio.Items.Add(dtr_fila("lab_nombre").ToString().PadRight(100) & dtr_fila("lab_id").ToString().PadRight(10))
        Next
        dts_laboratorio.Dispose()
        cmb_laboratorio.SelectedIndex = 0
    End Sub

    Sub LlenarComboLab2(ByRef cmb_laboratorio As ComboBox)
        'funcion que llena en un comobo los datos de un laboratior mas otros datos 
        On Error Resume Next
        Dim dts_laboratorio As DataSet
        Dim dtr_fila As DataRow
        dts_laboratorio = LeerLab()
        cmb_laboratorio.Items.Clear()
        For Each dtr_fila In dts_laboratorio.Tables("Registros").Rows
            cmb_laboratorio.Items.Add(dtr_fila("lab_nombre").ToString())
        Next
        cmb_laboratorio.SelectedIndex = 0
    End Sub
End Class
