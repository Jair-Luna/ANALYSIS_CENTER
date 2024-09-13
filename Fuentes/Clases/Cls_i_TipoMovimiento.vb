'*************************************************************************
' Nombre:   Cls_TipoMovimiento
' Tipo de Archivo: clase
' Descripción:  Clase para la manipulacion de los los tipos de movimientos
' Autores:  RFN
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class Cls_i_TipoMovimiento

    Public Function LeerTipoMovimiento() As DataSet
        'funcion que devuelve en un dataset los datos de los tipos de movimientos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select i_tim_id, i_tim_descripcion, i_tim_tipo, i_tim_id as i_tim_id2 from i_tipo_movimiento", cls_operacion.conn_sql)
        LeerTipoMovimiento = New DataSet()
        oda_operacion.Fill(LeerTipoMovimiento, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Tipo Movimiento", Err)
        Err.Clear()
    End Function

    Sub LlenarGridTipoMovimiento(ByRef dgrd_TipoMovimiento As DataGrid)
        'funcion que carga los datos de los tipos de movimientos en un datagrid
        On Error Resume Next
        Dim dtv_TipoMovimiento As New DataView()
        Dim dts_TipoMovimiento As New DataSet()
        dts_TipoMovimiento = LeerTipoMovimiento()
        With dtv_TipoMovimiento
            .Table = dts_TipoMovimiento.Tables("Registros")
            .AllowDelete = False
            .AllowEdit = False
            .AllowNew = False
        End With
        dgrd_TipoMovimiento.DataSource = dtv_TipoMovimiento
        dgrd_TipoMovimiento.NavigateTo(0, "Registros")
        dgrd_TipoMovimiento.CaptionText = "TIPO DE MOVIMIENTOS"
    End Sub

End Class