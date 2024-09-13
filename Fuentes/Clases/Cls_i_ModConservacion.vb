'*************************************************************************
' Nombre:   Cls_ModConservacion
' Tipo de Archivo: clase
' Descripción:  Clase para la manipulacion de los Modos de conservación
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient



Public Class Cls_i_ModConservacion

    Sub LlenarCmbModCon(ByRef cmb_ModConserv)
        'Para llenar el combo de Modo de Conservación
        Dim dts_modCon As DataSet
        Dim dtr_fila As DataRow
        dts_modCon = LeerModCon()
        cmb_ModConserv.Items.Clear()
        For Each dtr_fila In dts_modCon.Tables("Registros").Rows
            'cmb_ModConserv.Items.Add(dtr_fila("I_MOC_DESCRIPCION").ToString())
            cmb_ModConserv.Items.Add(dtr_fila("I_MOC_DESCRIPCION").ToString().PadRight(100) & dtr_fila("I_MOC_ID").PadRight(10).ToString)
        Next
        If cmb_ModConserv.Items.Count > 0 Then cmb_ModConserv.SelectedIndex = 0
    End Sub

    
    Public Function LeerModCon() As DataSet
        'funcion para leer todos los modos de conservacion retorna un dataset
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT * FROM I_MODALIDAD_CONSERVACION order by I_MOC_ID", opr_Conexion.conn_sql)
        LeerModCon = New DataSet("AREAS")
        oda_operacion.Fill(LeerModCon, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, ModConservacion", Err)
        Err.Clear()
    End Function

    Sub LlenarCmbSerie(ByRef cmb_Serie)
        'Para llenar el combo de Modo de Conservación
        Dim dts_serie As DataSet
        Dim dtr_fila As DataRow
        dts_serie = LeerSerie()
        cmb_Serie.Items.Clear()
        For Each dtr_fila In dts_serie.Tables("Registros").Rows
            'cmb_ModConserv.Items.Add(dtr_fila("I_MOC_DESCRIPCION").ToString())
            cmb_Serie.Items.Add(dtr_fila("SER_NOMBRE").ToString().PadRight(100) & CStr(dtr_fila("SER_ID")).PadRight(10).ToString)
        Next
        If cmb_Serie.Items.Count > 0 Then cmb_Serie.SelectedIndex = 0
    End Sub

    Sub LlenarCmbPresentacion(ByRef cmb_Presentacion)
        'Para llenar el combo de Modo de Conservación
        Dim dts_serie As DataSet
        Dim dtr_fila As DataRow
        dts_serie = LeerPresentacion()
        cmb_Presentacion.Items.Clear()
        For Each dtr_fila In dts_serie.Tables("Registros").Rows
            'cmb_ModConserv.Items.Add(dtr_fila("I_MOC_DESCRIPCION").ToString())
            cmb_Presentacion.Items.Add(dtr_fila("PRES_DESCRIPCION").ToString().PadRight(100) & CStr(dtr_fila("PRES_ID")).PadRight(10).ToString)
        Next
        If cmb_Presentacion.Items.Count > 0 Then cmb_Presentacion.SelectedIndex = 0
    End Sub


    Public Function LeerSerie() As DataSet
        'funcion para leer todos los modos de conservacion retorna un dataset
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT SER_ID, SER_NOMBRE FROM vacunaSerie order by SER_ID", opr_Conexion.conn_sql)
        LeerSerie = New DataSet("SERIE")
        oda_operacion.Fill(LeerSerie, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Series", Err)
        Err.Clear()
    End Function


    Public Function LeerPresentacion() As DataSet
        'funcion para leer todos los modos de conservacion retorna un dataset
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT PRES_ID, PRES_DESCRIPCION FROM I_PRESENTACION order by PRES_ID", opr_Conexion.conn_sql)
        LeerPresentacion = New DataSet("PRESENTACION")
        oda_operacion.Fill(LeerPresentacion, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Presentacion", Err)
        Err.Clear()
    End Function

    Public Function LeerModConservacion() As DataSet
        'funcion para leer todos los modos de conservacion y otros datos retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select i_moc_id, i_moc_descripcion, i_moc_id as i_moc_id2 from i_modalidad_conservacion", cls_operacion.conn_sql)
        LeerModConservacion = New DataSet()
        oda_operacion.Fill(LeerModConservacion, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Modalidad Conservación", Err)
        Err.Clear()
    End Function

    Public Sub EliminaModConservacion(ByVal i_moc_id As String)
        'funcion para eliminar un modo de conservacion recibe le codigo del modo de conservacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from i_modalidad_conservacion where i_moc_id = '" & i_moc_id & "'"
        odc_operacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        MsgBox("Modo de conservación eliminado", MsgBoxStyle.Information, "ANALISYS")
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Modo de Conservación", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Eliminar Modalidad Conservación", Err)
        Err.Clear()
    End Sub

    Sub LlenarGridModConservacion(ByRef dts_ModConservacion As DataSet, ByRef dgrd_ModConservacion As DataGrid)
        'funcion que permite llenar un grid con los datos de los modos de conservacion
        On Error Resume Next
        Dim dtv_ModConservacion As New DataView()
        dts_ModConservacion = LeerModConservacion()
        With dtv_ModConservacion
            .Table = dts_ModConservacion.Tables("Registros")
            .AllowDelete = True
            .AllowEdit = True
            .AllowNew = True
        End With
        dgrd_ModConservacion.DataSource = dtv_ModConservacion
        dgrd_ModConservacion.NavigateTo(0, "Registros")
        dgrd_ModConservacion.CaptionText = "MODALIDAD DE CONSERVACION"
    End Sub

    Public Function GuardarModConservacion(ByVal dts_ModConservacion As DataSet, ByVal boo_mensaje As Boolean) As Boolean
        'funcion que permite guardar los datos de un nuevo modoe conservacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        opr_conexion.sql_conectar()
        GuardarModConservacion = False
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim int_i As Integer
        For int_i = 0 To dts_ModConservacion.Tables("registros").Rows.Count() - 1
            If dts_ModConservacion.Tables("registros").Rows(int_i).Item(2).ToString = "" Then
                STR_SQL = "insert into i_modalidad_conservacion(i_moc_id, i_moc_descripcion) values('" & dts_ModConservacion.Tables("registros").Rows(int_i).Item(0) & "','" & _
                dts_ModConservacion.Tables("registros").Rows(int_i).Item(1) & "')"
            Else
                STR_SQL = "update i_modalidad_conservacion set i_moc_id='" & dts_ModConservacion.Tables("registros").Rows(int_i).Item(0) & "', i_moc_descripcion='" & dts_ModConservacion.Tables("registros").Rows(int_i).Item(1) & "' where i_moc_id='" & _
                dts_ModConservacion.Tables("registros").Rows(int_i).Item(2) & "'"
            End If
            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            g_opr_usuario.CargarTransaccion(g_str_login, "Guardar Modalidad Conservación", "")
        Next
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        If boo_mensaje Then MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        GuardarModConservacion = True
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Modalidad Conservación", Err)
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        Err.Clear()
    End Function

End Class
