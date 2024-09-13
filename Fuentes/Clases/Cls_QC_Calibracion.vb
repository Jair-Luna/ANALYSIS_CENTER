'*************************************************************************
' Nombre:   Cls_QC_Calibracion 
' Tipo de Archivo: Clase
' Descripcin:  Clase para operar los Controles de Calidad y Calibraciones
' Autores:  RFN
' Fecha de Creaci�n: Julio del 2003
' Autores:  RFN
' Ultima Modificaci�n: 02/07/2003
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.Odbc

Public Class Cls_QC_Calibracion
    Public Sub LlenarCmbTestQC(ByVal equ_id As Short, ByRef cmb_test As ComboBox)
        'procedimiento que llena un combo con los test de un equipo a los que se les a corrido un control de calidad
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        cmb_test.Items.Clear()
        Dim odr_trabajo As SqlDataReader = New SqlCommand("select CTR_TEST from control_calidad where equ_id = " & equ_id & " group by CTR_TEST", opr_conexion.conn_sql).ExecuteReader
        'Dim X As Short = equ_id
        'If X = 2 Then   'Cell Dyn
        '    While odr_trabajo.Read
        '        cmb_test.Items.Add("BIOMETRIA HEMATICA")
        '        cmb_test.SelectedIndex = 0
        '        Exit While
        '    End While
        'Else
        While odr_trabajo.Read
            cmb_test.Items.Add(odr_trabajo.GetValue(0))
            cmb_test.SelectedIndex = 0
        End While
        'End If

        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar CmbEquipos", Err)
        Err.Clear()
    End Sub

    Public Sub LlenarCmbTestCal(ByVal equ_id As Short, ByRef cmb_test As ComboBox)
        'procedimiento que llena un combo con los test de un equipo a los que se les a corrido calibraciones
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        cmb_test.Items.Clear()
        Dim odr_trabajo As SqlDataReader = New SqlCommand("select cal_TEST from calibracion where equ_id = " & equ_id & " group by cal_test", opr_Conexion.conn_sql).ExecuteReader
        While odr_trabajo.Read
            cmb_test.Items.Add(odr_trabajo.GetValue(0))
            cmb_test.SelectedIndex = 0
        End While
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar CmbEquipos", Err)
        Err.Clear()
    End Sub

    Public Sub LlenarGridControles(ByVal equ_id As Short, ByRef dgrd_controles As DataGrid, ByVal ctr_test As String, ByVal fechaI As Date, ByVal fechaF As Date)
        'procedimiento que llena un combo con los test de un equipo a los que se les a corrido un control de calidad
        'Sub LlenarGridTest(ByRef dgrd_test As DataGrid, ByVal tes_nombre As String, ByVal con_nombre As String)
        'funcion que llena en un datagrid los datos de los test
        Dim dts_test As DataSet
        Dim dtv_test As New DataView()
        Dim opr_test As New Cls_Test()
        Dim dtr_fila As DataRow
        dts_test = LeerQC(equ_id, ctr_test, fechaI, fechaF)
        With dtv_test
            .Table = dts_test.Tables("Registros")
            .Sort = "ctr_fecha"
        End With
        dgrd_controles.DataSource = dtv_test
    End Sub

    Public Sub LlenarGridCalibraciones(ByVal equ_id As Short, ByRef dgrd_controles As DataGrid, ByVal cal_test As String, ByVal fechaI As Date, ByVal fechaF As Date)
        'funcion que llena en un datagrid con los controles de calidad 
        Dim dts_test As DataSet
        Dim dtv_test As New DataView()
        Dim opr_test As New Cls_Test()
        dts_test = LeerCalibraciones(equ_id, cal_test, fechaI, fechaF)
        With dtv_test
            .Table = dts_test.Tables("Registros")
            .Sort = "cal_fecha"
        End With
        dgrd_controles.DataSource = dtv_test
    End Sub

    Public Function LeerQC(ByVal equ_id As Short, ByVal ctr_test As String, ByVal fechai As Date, ByVal fechaf As Date) As DataSet
        'Funci�n para consultar todos los controles de calidad en funci�n del equipo, el test y un rango de tiempo
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        'Dim x As Short = equ_id
        'If x <> 3 Then
        str_sql = " select cc.*, concat(cc.ctr_resultado ,'  ', cc.ctr_unidad) as RES_UNI, concat(cc.ctr_ranmin , '---' , cc.ctr_ranmax) AS RANGO_NORMAL, round(concat((cc.ctr_ranmin + cc.ctr_ranmax)/2),2) AS RANGO_MEDIA, ee.err_descripcion from control_calidad as cc,  error_equipo as ee where cc.equ_id = " & equ_id & " and cc.ctr_test = '" & ctr_test & "' and cc.ctr_fecha between '" & Format(fechai, "dd/MM/yyyy") & "' and '" & Format(fechaf, "dd/MM/yyyy") & "' and ee.equ_id = cc.equ_id and ee.err_id = cc.ctr_error "
        'str_sql = " select cc.*, ee.err_descripcion from control_calidad as cc, error_equipo as ee where cc.equ_id = " & equ_id & " and cc.ctr_test = '" & ctr_test & "' and cc.ctr_fecha between '" & Format(fechai, "dd/MM/yyyy") & "' and '" & Format(fechaf, "dd/MM/yyyy") & "' and ee.equ_id = cc.equ_id and ee.err_id = cc.ctr_error"
        'Else
        '    str_sql = "select 'BIOMETRIA' AS CTR_TEST, cc.CTR_NOMBRE, cc.CTR_FECHA, cc.CTR_HORA, cc.CTR_NIVEL,cc.CTR_TIPO,cc.CTR_RESULTADO, cc.CTR_UNIDAD,cc.CTR_ERROR, cc.EQU_ID, ee.err_descripcion from control_calidad as cc, error_equipo as ee where cc.equ_id = " & equ_id & " And cc.ctr_fecha between '" & Format(fechai, "dd/MM/yyyy") & "' and '" & Format(fechaf, "dd/MM/yyyy") & "' and ee.equ_id = cc.equ_id and ee.err_id = cc.ctr_error" 'GROUP BY CTR_FECHA, CTR_HORA"
        'End If
        opr_conexion.sql_conectar()
        oda_test.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerQC = New DataSet()
        oda_test.Fill(LeerQC, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer QC", Err)
        Err.Clear()
    End Function

    Public Function LeerCalibraciones(ByVal equ_id As Short, ByVal cal_test As String, ByVal fechai As Date, ByVal fechaf As Date) As DataSet
        'Funci�n para consultar todos las calibraciones en funci�n del equipo, el test y un rango de tiempo
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        str_sql = "Select * from calibracion where equ_id = " & equ_id & " and cal_test = '" & cal_test & "' and cal_fecha between '" & Format(fechai, "dd/MM/yyyy") & "' and '" & Format(fechaf, "dd/MM/yyyy") & "'"
        opr_conexion.sql_conectar()
        oda_test.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerCalibraciones = New DataSet()
        oda_test.Fill(LeerCalibraciones, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer QC", Err)
        Err.Clear()
    End Function

End Class
