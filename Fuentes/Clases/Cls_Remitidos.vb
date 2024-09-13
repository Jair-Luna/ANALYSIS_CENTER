'*************************************************************************
' Nombre:   Cls_Remitidos
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de los remitidos
' Autores: Rossvan Flores N.
' Fecha de Creaci�n:  22_07-2010
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.IO
Imports System.Data.SqlClient



Public Class Cls_Remitidos

    Public Sub Leerremitidos(ByVal dtt_remitidos As DataTable)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        str_sql = "Select '     ' as btn, remitidos.rem_id,  paciente.PAC_ID, concat(paciente.PAC_APELLIDO, ' ', paciente.PAC_NOMBRE) as paciente, paciente.PAC_DOC, lab_remitidos.lar_nombre, remitidos.rem_fecha, remitidos.rem_file from paciente, remitidos, lab_remitidos, pedido where pedido.PED_ID = remitidos.ped_id  and lab_remitidos.lar_id = remitidos.lar_id and paciente.PAC_ID = pedido.PAC_ID; "
        'str_sql = "Select paciente.PAC_ID, concat(paciente.PAC_APELLIDO, ' ', paciente.PAC_NOMBRE) as paciente, lab_remitidos.lar_nombre, remitidos.rem_fecha, remitidos.rem_obs, remitidos.rem_file from paciente, remitidos, lab_remitidos, pedido where pedido.PED_ID = remitidos.ped_id  and lab_remitidos.lar_id = remitidos.lar_id and paciente.PAC_ID = pedido.PAC_ID ; "
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_remitidos)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Area", Err)
        Err.Clear()
    End Sub



    Public Sub GuardaPDF(ByVal ped_id As String, ByVal pac_id As String, ByVal sec_pac As String, ByVal archivoOrigen As String, ByVal modifica As Integer, ByRef pdf As String)
        'funcion que alamacena en un archivo .pdf 
        On Error GoTo MsgError
        Dim str_archivo As String
        Dim path_paciente As String
        Dim archivoDestino As String
        path_paciente = g_pathremitidos & pac_id

        If Dir(path_paciente, FileAttribute.Directory) = "" Then MkDir(g_pathremitidos & "/" & pac_id)
        str_archivo = ped_id & "_" & sec_pac & ".pdf"
        archivoDestino = path_paciente & "/" & str_archivo
        If File.Exists(str_archivo) = True Then
            'Aqui mensaje de que ya hay un archivo con ese nombre
            File.Delete(archivoDestino)
            File.Copy(archivoOrigen, archivoDestino)
            pdf = str_archivo

        Else
            If (modifica = 0) Then
                File.Delete(archivoDestino)
                File.Copy(archivoOrigen, archivoDestino)
                pdf = str_archivo

            Else
                File.Copy(archivoOrigen, archivoDestino)
                pdf = str_archivo

            End If

        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guarda PDF", Err)
        Err.Clear()
    End Sub


    Public Function LeerSecuencial(ByVal pac_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("Select rem_sec from remitidos_sec where pac_id = " & pac_id & "", opr_Conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerSecuencial = dtr_fila(0) + 1
        Next
        If LeerSecuencial = Nothing Then
            LeerSecuencial = 1
        End If
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Secuencial PDF Paciente", Err)
        Err.Clear()
    End Function


    Public Function LeerRutaPdf(ByVal rem_id As String) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("Select pedido.PAC_ID, remitidos.rem_file from remitidos, pedido where remitidos.ped_id = pedido.ped_id and remitidos.rem_id = " & rem_id & "", opr_Conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerRutaPdf = dtr_fila(0) & "\" & dtr_fila(1)
        Next
        If LeerRutaPdf = Nothing Then
            LeerRutaPdf = ""
        End If
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer ruta pdf", Err)
        Err.Clear()
    End Function


    Public Function MaxRemitidos() As Integer
        'Funcion para la consultar el c�digo m�ximo de remitidos 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        MaxRemitidos = CInt(New SqlCommand("Select isnull(max(rem_id),0) from remitidos", opr_Conexion.conn_sql).ExecuteScalar) + 1
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTestParam", Err)
        Err.Clear()
    End Function



    Public Sub ActualizaSecuencial(ByVal pac_id As Integer, ByVal sec As Integer)
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String
        On Error GoTo MsgError
        opr_Conexion.sql_conectar()
        If (sec <= 1) Then
            str_sql = "insert into remitidos_sec values(" & pac_id & ", " & sec & " ) "
        Else
            str_sql = "update remitidos_sec set rem_sec = " & sec & " where pac_id = " & pac_id & ""
        End If
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Actualiza Remitido", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizaListaTrabajo(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal lab_nombre As String, ByVal modifica As Integer, ByVal validar As Integer, ByVal pdf As String, ByVal rem_fecha As String)

        'opr_remitidos.ActualizaListaTrabajo(ped_id, tes_id, sec_id, abrev, muestra, lab, rem_fecha, pdf, nuevo_modif, validar)

        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim remitido As String
        On Error GoTo MsgError
        opr_Conexion.sql_conectar()

        If (modifica = 1) Then
            'str_sql = "insert into remitidos values(" & rem_id & ", " & ped_id & ", '" & lab_nombre & "', '" & rem_fecha & "', '" & rem_obs & "', '" & pdf & "','', 1 )"
            str_sql = "update lista_trabajo set lis_resmanual = 'Remitido', lis_resestado = 9, lis_rack = '" & rem_fecha & "', lis_equerror = '" & lab_nombre & "', lis_mis =  '" & pdf & "' where ped_id = " & ped_id & " and tes_id = " & tes_id & ";"
        Else
            str_sql = "update lista_trabajo set lis_resestado = 0, lis_rack = '', lis_equerror = '', lis_mis =  '' where ped_id = " & ped_id & " and tes_id = " & tes_id & ";"
        End If

        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        If (validar = 5) Then
            str_sql = "update pedido set ped_estado = 5 where ped_id = " & ped_id & "; "
            Dim odc_valpedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            odc_valpedido.ExecuteNonQuery()
        End If

        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Actualiza Remitido", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizaNota(ByVal ped_id As Integer, ByVal nota As String)
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String

        opr_Conexion.sql_conectar()
        str_sql = "update pedido set ped_nota = 'REMITIDOS: " & nota & "' where ped_id = " & ped_id & " ;"
        Try

            Dim odc_remitido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            odc_remitido.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message + "\t" + ex.StackTrace)
            g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Actualiza Nota Remitido", Err)
        Finally
            opr_conexion.sql_desconn()
        End Try
    End Sub


    Public Sub GuardaRemitido(ByVal rem_id As Integer, ByVal ped_id As Integer, ByVal lab_nombre As String, ByVal rem_fecha As String, ByVal rem_obs As String, ByVal pdf As String, ByVal modifica As Integer)
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String
        On Error GoTo MsgError
        If (modifica = 1) Then
            'str_sql = "insert into remitidos values(" & rem_id & ", " & ped_id & ", '" & lab_nombre & "', '" & rem_fecha & "', '" & rem_obs & "', '" & pdf & "','', 1 )"
            str_sql = "update lista_trabajo set lis_rack = '" & rem_fecha & "', lis_equerror = '" & lab_nombre & "', lis_mis =  '" & pdf & "';"
        Else
            str_sql = "update lista_trabajo set lis_rack = '', lis_equerror = '', lis_mis =  '';"
        End If
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        'If (modifica = 0) Then
        '    'str_sql = "update remitidos set rem_estado = 0 where rem_file like '" & ped_id & "%' "
        '    'opr_Conexion.conn_sql()
        '    'Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        '    'odc_pedido.ExecuteNonQuery()
        '    '
        '    'str_sql = "insert into remitidos values(" & rem_id & ", " & ped_id & ", '" & lab_nombre & "', '" & rem_fecha & "', '" & rem_obs & "', '" & pdf & "','', 1 )"
        '    str_sql = "update lista_trabajo set lis_rack = '" & rem_fecha & "', lis_equerror = '" & lab_nombre & "', lis_mis =  '" & pdf & "';"
        '    opr_Conexion.conn_sql()
        '    Dim odc_pedido1 As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        '    odc_pedido1.ExecuteNonQuery()
        '    opr_conexion.sql_desconn
        'End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Guarda Remitido", Err)
        Err.Clear()
    End Sub

    Sub LlenarGridRemitidos(ByRef dgrd_remitidos As DataGrid, ByVal criterio As String, ByVal parametro As String)
        'llena un datagrid con los datos de los pacientes SEGUN criterio.
        On Error Resume Next
        Dim opr_remitidos As New Cls_Remitidos()
        Dim dts_paciente As DataSet
        Dim dtv_paciente As New DataView()
        dts_paciente = opr_remitidos.FiltraRemitido(parametro, criterio)
        With dtv_paciente
            .Table = dts_paciente.Tables("Registros")
            ' .Sort = "pac_apellido"
        End With
        dts_paciente.Dispose()
        dgrd_remitidos.DataSource = dtv_paciente
        dgrd_remitidos.NavigateTo(0, "Registros")
        dgrd_remitidos.CaptionText = "LISTA DE REMITIDOS"
    End Sub

    Public Function FiltraRemitido(ByVal parametro As String, ByVal criterio As String) As DataSet
        'funcion que devuelve los datos de uno o varios paciente en un dataset,recibe el/los apellido/s o el n�mero de c�dula
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        ' SI tipo = 0 entonces se busca por apellidos 
        Dim STR_SQL As String
        '
        STR_SQL = " "
        '
        Select Case criterio
            Case "apellido"
                STR_SQL = "Select '     ' as btn, remitidos.rem_id,  paciente.PAC_ID, concat(paciente.PAC_APELLIDO, ' ', paciente.PAC_NOMBRE) as paciente, paciente.PAC_DOC, lab_remitidos.lar_nombre, remitidos.rem_fecha, remitidos.rem_file from paciente, remitidos, lab_remitidos, pedido where pedido.PED_ID = remitidos.ped_id  and lab_remitidos.lar_id = remitidos.lar_id and pedido.pac_id = paciente.pac_id and paciente.pac_apellido like '" & parametro & "%'; "
            Case "cedula"
                STR_SQL = "Select '     ' as btn, remitidos.rem_id,  paciente.PAC_ID, concat(paciente.PAC_APELLIDO, ' ', paciente.PAC_NOMBRE) as paciente, paciente.PAC_DOC, lab_remitidos.lar_nombre, remitidos.rem_fecha, remitidos.rem_file from paciente, remitidos, lab_remitidos, pedido where pedido.PED_ID = remitidos.ped_id  and lab_remitidos.lar_id = remitidos.lar_id and pedido.pac_id = paciente.pac_id and paciente.pac_doc like '" & parametro & "%'; "
            Case "codigo"
                STR_SQL = "Select '     ' as btn, remitidos.rem_id,  paciente.PAC_ID, concat(paciente.PAC_APELLIDO, ' ', paciente.PAC_NOMBRE) as paciente, paciente.PAC_DOC, lab_remitidos.lar_nombre, remitidos.rem_fecha, remitidos.rem_file from paciente, remitidos, lab_remitidos, pedido where pedido.PED_ID = remitidos.ped_id  and lab_remitidos.lar_id = remitidos.lar_id and pedido.pac_id = paciente.pac_id and remitidos.rem_id like '" & parametro & "%'; "
        End Select

        oda_paciente.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        FiltraRemitido = New DataSet()
        oda_paciente.Fill(FiltraRemitido, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Paciente por parametro", Err)
        Err.Clear()
    End Function


    Public Function LeerLabRemitidos() As DataSet
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select lar_id, lar_nombre from lab_remitidos where lar_estado = 1 order by lar_id", cls_operacion.conn_sql)

        LeerLabRemitidos = New DataSet()
        oda_operacion.Fill(LeerLabRemitidos, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Bodega", Err)
        Err.Clear()
    End Function



    Public Function LeerTipo(ByVal tes_id As Integer, ByRef tipo As Integer, ByRef abrev As String, ByRef muestra As String)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Select TEST.tes_tproces, TEST_EQUIPO.TEQ_ABRV_FIJA, TEST.TIM_ID from TEST, TEST_EQUIPO WHERE TEST.TES_ID = TEST_EQUIPO.TES_ID and TEST.TES_ID = " & tes_id & ";"
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            tipo = dtr_fila(0)
            If (tipo = 1) Then
                abrev = dtr_fila(1)
                muestra = dtr_fila(2)
            Else
                abrev = ""
                muestra = ""
            End If

        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Secuencial Paciente", Err)
        Err.Clear()
    End Function


End Class
