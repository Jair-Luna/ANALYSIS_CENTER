'*************************************************************************
' Nombre:   Cls_Muestra
' Tipo de Archivo: clase
' Descripcin:  Clase para obtener el numero de muestras de un pedido
' Autores: RFN
' Fecha de Creaci�n:  
' Autores Modificaciones:
' Ultima Modificaci�n: 19-01-06
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient



Public Class Cls_Muestra


    Public Sub ActualizaFechaToma(ByVal Ped_id As Long)
        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_usuario As SqlCommand
        opr_conexion.sql_conectar()
        str_sql = "update pedido set PED_MEDICACION = getdate() where ped_id = " & Ped_id
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "03 HORA TOMA DE MUESTRA", "Inicio de toma de muestras", g_sng_user, Ped_id, "", "")


    End Sub

    Public Function LeerFechaPedido(ByVal ped_id As Long) As Date
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select PED_MEDICACION from pedido where ped_id=" & ped_id & ""
            opr_conexion.sql_conectar()
            LeerFechaPedido = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar
            opr_conexion.sql_desconn()
        Catch
            MsgBox("No se pudo realizar la operacion solicitada, LeerFechaPedido. ", MsgBoxStyle.Information, "ANALISYS")
            Err.Clear()
        End Try
    End Function


    Sub LlenarGridMuestra(ByRef dgrd_muestra As DataGrid, ByRef dtt_muestra As DataTable, ByVal ped_id As Long)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        If (g_CBpaciente) And (g_CBpedido) Then
            str_sql = "select 'PEDIDO                   ' as tit_nombre , '1' as pee_cantidad, 'IMPRIMIR' as IMPRIMIR UNION select 'PACIENTE                 ' as tit_nombre , '1' as pee_cantidad, 'IMPRIMIR' as IMPRIMIR UNION select tt.TIT_NOMBRE as TIT_NOMBRE, t.TES_CODBARRAS as pee_cantidad, 'IMPRIMIR' as IMPRIMIR  from pedido_detalle as pd, test as t, tipo_muestra as tm, tipo_tubo as tt " & _
            "where t.tes_id = pd.tes_id and pd.ped_id = " & g_lng_ped_id & " and t.tim_id = tm.tim_id and tm.tit_id = tt.tit_id GROUP BY TIT_NOMBRE, t.TES_CODBARRAS"
        Else

            If (g_CBpedido) And (g_CBpaciente = False) Then
                str_sql = "select 'PEDIDO                   ' as tit_nombre , '1' as pee_cantidad, 'IMPRIMIR' as IMPRIMIR UNION select tt.TIT_NOMBRE as TIT_NOMBRE, t.TES_CODBARRAS as pee_cantidad, 'IMPRIMIR' as IMPRIMIR from pedido_detalle as pd, test as t, tipo_muestra as tm, tipo_tubo as tt " & _
            "where t.tes_id = pd.tes_id and pd.ped_id = " & g_lng_ped_id & " and t.tim_id = tm.tim_id and tm.tit_id = tt.tit_id GROUP BY TIT_NOMBRE, TES_CODBARRAS"
            Else
                If (g_CBpaciente) And (g_CBpedido = False) Then
                    str_sql = "select 'PACIENTE                 ' as tit_nombre , '1' as pee_cantidad, 'IMPRIMIR' as IMPRIMIR UNION select tt.TIT_NOMBRE as TIT_NOMBRE, t.TES_CODBARRAS as pee_cantidad, 'IMPRIMIR' as IMPRIMIR from pedido_detalle as pd, test as t, tipo_muestra as tm, tipo_tubo as tt " & _
            "where t.tes_id = pd.tes_id and pd.ped_id = " & g_lng_ped_id & " and t.tim_id = tm.tim_id and tm.tit_id = tt.tit_id GROUP BY TIT_NOMBRE, TES_CODBARRAS"
                End If

                If (g_CBpaciente = False) And (g_CBpedido = False) Then
                    str_sql = "select tt.TIT_NOMBRE as TIT_NOMBRE, t.TES_CODBARRAS as pee_cantidad, 'IMPRIMIR' as IMPRIMIR from pedido_detalle as pd, test as t, tipo_muestra as tm, tipo_tubo as tt where t.tes_id = pd.tes_id and pd.ped_id = " & g_lng_ped_id & " and t.tim_id = tm.tim_id and tm.tit_id = tt.tit_id GROUP BY TIT_NOMBRE, t.TES_CODBARRAS"
                End If

            End If
        End If


        Dim odr_muestra As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_muestra.Read
            dtr_fila = dtt_muestra.NewRow
            dtr_fila(0) = odr_muestra.Item(0)
            dtr_fila(1) = odr_muestra.Item(1)
            dtr_fila(2) = "Imprimir"
            dtt_muestra.Rows.Add(dtr_fila)
        End While
        dgrd_muestra.DataSource = dtt_muestra
        dgrd_muestra.NavigateTo(0, "Registros")
        dgrd_muestra.CaptionText = "MUESTRAS"
        odr_muestra.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub

    Sub LlenarComboMuestra(ByRef cmb_muestra As ComboBox)
        'llena un combo con los diferentes tipos de muestra
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_muestra As SqlDataReader = New SqlCommand("Select tit_nombre from tipo_tubo", opr_Conexion.conn_sql).ExecuteReader
        cmb_muestra.Items.Clear()
        While odr_muestra.Read
            cmb_muestra.Items.Add(odr_muestra.GetString(0))
        End While
        odr_muestra.Close()
        opr_conexion.sql_desconn()
        cmb_muestra.SelectedIndex = 0
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Grid Muestra", Err)
        Err.Clear()
    End Sub

    Public Function Leerturno(ByVal ped_id As Integer) As Integer
        'JPO:
        'Funcion para la consultar el turno diario
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "Select isnull(ped_turno,0) from pedido where ped_id = " & ped_id & ""
        Leerturno = CInt(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, LeerTurno-Cls_Muestra ", Err)
        Err.Clear()
    End Function


    Public Function selec_muestra(ByVal ped_id As Integer, ByVal muestra As String) As Integer
        'JVA : 13-JUL-05
        'Funcion para la consulta del tipo de muestra
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String = "SELECT TIPO_MUESTRA.tiM_id FROM TIPO_MUESTRA, TIPO_TUBO WHERE TIPO_MUESTRA.TIT_ID = TIPO_TUBO.TIT_ID AND " & _
            "TIPO_TUBO.TIT_NOMBRE = '" & muestra & "';"
        opr_Conexion.sql_conectar()
        'selec_muestra = CInt(New SqlCommand("SELECT t.TIM_ID FROM pedido_detalle_desglosado pdd INNER JOIN test t ON pdd.TES_ID = t.TES_ID INNER JOIN tipo_muestra tm ON t.TIM_ID = tm.TIM_ID INNER JOIN tipo_tubo tt ON tm.TIT_ID = tt.TIT_ID WHERE (pdd.PED_ID = " & ped_id & ") and tt.tit_nombre = '" & muestra & "' GROUP BY tt.TIT_NOMBRE, t.TIM_ID, tm.TIM_NOMBRE", opr_Conexion.conn_sql).ExecuteScalar)
        selec_muestra = CInt(New SqlCommand(STR_SQL, opr_Conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, seleccionar muestra", Err)
        Err.Clear()
    End Function



End Class
