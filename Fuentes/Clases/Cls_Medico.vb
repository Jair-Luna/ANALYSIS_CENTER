'*************************************************************************
' Nombre:   Cls_Medico
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de los Medicos
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



Public Class Cls_Medico

    Public Function LeerMedico() As DataSet
        'funcion que devuelve los datos de los Medicos en un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select * from Medico where med_id > 1 order by med_obs desc, med_nombre asc  ", cls_operacion.conn_sql)
        LeerMedico = New DataSet()
        oda_operacion.Fill(LeerMedico, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Medico", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxMedico() As Integer
        'Procedimiento para extraer el codigo maximo de Medicos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        LeerMaxMedico = CInt(New SqlCommand("Select isnull(Max(MED_ID), 0) from Medico", cls_operacion.conn_sql).ExecuteScalar)

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codigo Medico", Err)
        Err.Clear()
    End Function

    Public Sub OperaMedico(ByVal FlagOpera As Boolean, ByVal CIU_ID As Integer, _
    ByVal MED_DOC As String, ByVal MED_TIPODOC As Single, ByVal MED_NOMBRE As String, _
    ByVal MED_OBS As String, ByVal MED_FONO As String, ByVal MED_DIRECCION As String, _
    ByVal MED_MAIL As String, ByVal bon_nombre As String, ByVal esp_id As Short, ByRef medicoId As Integer, ByVal med_Hini As String, ByVal med_Hfin As String, ByVal med_Dias As String, ByVal med_Intervalo As String, ByVal prov_id As Integer, ByVal receta As Integer, ByVal grafico As Integer, Optional ByVal MED_ID As Integer = 0)
        'Procedimiento para actualizar o ingresar los datos de un Medico
        On Error GoTo MsgError
        Dim STR_SQL, str_msg As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        cls_operacion.sql_conectar()
        If FlagOpera Then
            MED_ID = LeerMaxMedico() + 1
            STR_SQL = "Insert into Medico (MED_ID, CIU_ID, MED_DOC, MED_TIPODOC, " & _
            "MED_NOMBRE, MED_OBS, MED_FONO, MED_DIRECCION, MED_MAIL, MED_FECING, bon_nombre, esp_id, med_inicio, med_fin, med_dias, med_intervalo, prov_id, med_receta, med_grafico) Values (" & _
            MED_ID & ", " & CIU_ID & ", '" & MED_DOC & "', " & MED_TIPODOC & ", '" & _
            MED_NOMBRE & "', '" & MED_OBS & "', '" & MED_FONO & "', '" & _
            MED_DIRECCION & "', '" & MED_MAIL & "', '" & Now() & "','" & bon_nombre & "', " & esp_id & ", '" & med_Hini & "','" & med_Hfin & "','" & med_Dias & "','" & med_Intervalo & "'," & prov_id & "," & receta & ", " & grafico & ");"
            str_msg = "Datos Registrados"
            medicoId = MED_ID
        Else
            STR_SQL = "Update Medico set " & _
            "CIU_ID=" & CIU_ID & ", " & _
            "MED_DOC='" & MED_DOC & "', " & _
            "MED_TIPODOC=" & MED_TIPODOC & ", " & _
            "MED_NOMBRE='" & MED_NOMBRE & "', " & _
            "MED_OBS='" & MED_OBS & "', " & _
            "MED_FONO='" & MED_FONO & "', " & _
            "MED_DIRECCION='" & MED_DIRECCION & "', " & _
            "MED_MAIL='" & MED_MAIL & "', bon_nombre='" & bon_nombre & "', esp_id = " & esp_id & ", " & _
            "MED_INICIO='" & med_Hini & "', " & _
            "MED_FIN='" & med_Hfin & "', " & _
            "MED_DIAS='" & med_Dias & "', " & _
            "MED_INTERVALO='" & med_Intervalo & "', " & _
            "PROV_ID= " & prov_id & ", " & _
            "MED_RECETA=" & receta & ", " & _
            "MED_GRAFICO=" & grafico & " " & _
            "WHERE MED_ID='" & MED_ID & "';"
            str_msg = "Actualizacion Realizada"
            medicoId = MED_ID
        End If
        odc_operacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizacon Medico", "Medico=" & MED_NOMBRE, g_sng_user, "", "", "")
        MsgBox(str_msg, MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Registra Medico", Err)
        Err.Clear()
    End Sub


    Public Sub EliminaMedico(ByVal MED_ID As Integer)
        'Procedimiento para eliminar un Medico
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from Medico where MED_ID = " & MED_ID
        odc_operacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Elimina Medico", "Medico=" & MED_ID, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Eliminar Medico", Err)
        Err.Clear()
    End Sub

    Function buscamedico(ByVal MED_ID As Integer) As Integer
        'Procedimiento para eliminar un Medico

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        buscamedico = CInt(New SqlCommand("select count(med_id) from pedido where med_id = " & MED_ID, cls_operacion.conn_sql).ExecuteScalar)

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, buscar Medico", Err)
        Err.Clear()


    End Function

    Function buscamedicoNombre(ByVal MED_NOMBRE As String) As Integer
        'Procedimiento para eliminar un Medico

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        buscamedicoNombre = CInt(New SqlCommand("select med_id from medico where med_nombre like '%" & MED_NOMBRE & "%'", cls_operacion.conn_sql).ExecuteScalar)

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, buscar Medico", Err)
        Err.Clear()


    End Function


    Sub LlenarComboMedico(ByRef cmb_medico As ComboBox, ByVal tipo As String)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "Select med_nombre, med_id, med_mail from Medico where med_obs = '" & tipo & "' and med_id > 0 order by med_id asc ;"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_medico.Items.Clear()
        While odr_operacion.Read
            cmb_medico.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & odr_operacion.GetValue(1).ToString().PadRight(5))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_medico.SelectedIndex = 0

        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar Medico", Err)
        Err.Clear()
    End Sub


    Sub LlenarComboActividad(ByRef cmb_actividad As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "Select act_descripcion, act_id from actividad where act_estado = 1 order by act_id asc ;"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_actividad.Items.Clear()
        While odr_operacion.Read
            cmb_actividad.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & odr_operacion.GetValue(1).ToString().PadRight(10))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_actividad.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar Medico", Err)
        Err.Clear()
    End Sub


    Sub LlenarCalendarioMedico(ByRef cmb_hora As ComboBox, ByVal med_id As Integer)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "SELECT * from calendario where med_id =" & med_id & " order by cal_hora;"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_hora.Items.Clear()
        While odr_operacion.Read
            cmb_hora.Items.Add(odr_operacion.GetValue(1).ToString())
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_hora.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar hora caledario", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizaUsuarioWebMedico(ByVal USR_ID As String, ByVal PERFIL_WEB As String, ByVal med_id As Integer)
        'Funcion para consultar los pedidos que no tienen asignadas facturas
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer
        opr_Conexion.sql_conectar()

        STR_SQL = "update medico set USR_ID = '" & USR_ID & "', PERFIL_WEB = '" & PERFIL_WEB & "' where MED_ID = " & med_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()

        MsgBox("Datos Registrados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Usuario Web Medic", Err)
        Err.Clear()
    End Sub


    Sub LlenarComboEspecialidad(ByRef cmb_especialidad As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select esp_desc, esp_id from especialidad order by esp_desc asc"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_especialidad.Items.Clear()
        cmb_especialidad.Items.Add("Todas").ToString().PadRight(100)
        While odr_operacion.Read
            cmb_especialidad.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & odr_operacion.GetValue(1).ToString().PadRight(10))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_especialidad.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar Especialidad", Err)
        Err.Clear()
    End Sub


    Sub LlenarComboPresentacion(ByRef combo As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select pres_descripcion, pres_id from VademecumPresentacion order by pres_descripcion asc"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        combo.Items.Clear()
        combo.Items.Add("Todas").ToString().PadRight(100)
        While odr_operacion.Read
            combo.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & odr_operacion.GetValue(1).ToString().PadRight(5))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        combo.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar Especialidad", Err)
        Err.Clear()
    End Sub


   


    Public Function ComprobarNomMedico(ByVal med_nombre As String) As Integer
        'comprueba la existencia de un paciente, comparando por apellido y nombre
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ComprobarNomMedico = CInt(New SqlCommand("Select isnull(med_id,0) from medico where med_nombre='" & Trim(med_nombre) & "' LIMIT 0, 1", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, comprobar nombres del medico", Err)
        Err.Clear()
    End Function

End Class