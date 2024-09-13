'*************************************************************************
' Nombre:   Cls_Unidad
' Tipo de Archivo: clase
' Descripción:  Clase para la manipulacion de las unidades
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



Public Class Cls_i_Unidad

    Public Function LeerUnidad() As DataSet
        'funcion que devuelve un dataset con los datos de las unidades
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select i_uni_id, i_uni_descripcion, i_uni_id as i_uni_id2 from i_unidad order by i_unidad.I_UNI_DESCRIPCION ", cls_operacion.conn_sql)
        LeerUnidad = New DataSet()
        oda_operacion.Fill(LeerUnidad, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Unidad", Err)
        Err.Clear()
    End Function

    Public Sub EliminaUnidad(ByVal i_uni_id As String)
        'funcion que permite eliminar una unidad, recibe el codigo de la unidad
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from i_unidad where i_uni_id = '" & i_uni_id & "'"
        odc_operacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        MsgBox("Unidad eliminada", MsgBoxStyle.Information, "ANALISYS")
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Unidad", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Eliminar Unidad", Err)
        Err.Clear()
    End Sub

    Sub LlenarGridUnidad(ByRef dts_Unidad As DataSet, ByRef dgrd_Unidad As DataGrid)
        'funcion que llena un datagrid con los datos de las unidades
        On Error Resume Next
        Dim dtv_Unidad As New DataView()
        dts_Unidad = LeerUnidad()
        With dtv_Unidad
            .Table = dts_Unidad.Tables("Registros")
            .AllowDelete = True
            .AllowEdit = True
            .AllowNew = True
        End With
        dgrd_Unidad.DataSource = dtv_Unidad
        dgrd_Unidad.NavigateTo(0, "Registros")
        dgrd_Unidad.CaptionText = "UNIDADES"
    End Sub

    Public Function GuardarUnidad(ByVal dts_Unidad As DataSet, ByVal boo_mensaje As Boolean) As Boolean
        'funcion para guardar los datos d las unidades
        On Error GoTo MsgError
        Dim STR_SQL As String
        'Dim cls_operacion As New Cls_Conexion()
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        GuardarUnidad = False
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones 
        Dim int_i As Integer
        For int_i = 0 To dts_Unidad.Tables("registros").Rows.Count() - 1
            If dts_Unidad.Tables("registros").Rows(int_i).Item(2).ToString = "" Then
                STR_SQL = "insert into i_unidad(i_uni_id, i_uni_descripcion) values('" & dts_Unidad.Tables("registros").Rows(int_i).Item(0) & "','" & _
                dts_Unidad.Tables("registros").Rows(int_i).Item(1) & "')"
            Else
                STR_SQL = "update i_unidad set i_uni_id='" & dts_Unidad.Tables("registros").Rows(int_i).Item(0) & "', i_uni_descripcion='" & dts_Unidad.Tables("registros").Rows(int_i).Item(1) & "' where i_uni_id='" & _
                dts_Unidad.Tables("registros").Rows(int_i).Item(2) & "'"
            End If
            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            g_opr_usuario.CargarTransaccion(g_str_login, "Guardar Unidad", "")
        Next
        'si no hubo errores hago un commit
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        GuardarUnidad = True
        If boo_mensaje Then MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Guardar Unidad", Err)
        Err.Clear()
    End Function

    Public Function Leerdiv() As DataSet
        'funcion que devuelve un dataset con los datos de las divisiones
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select div_nombre, div_id  from division", cls_operacion.conn_sql)
        Leerdiv = New DataSet()
        oda_operacion.Fill(Leerdiv, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Unidad", Err)
        Err.Clear()
    End Function

End Class
