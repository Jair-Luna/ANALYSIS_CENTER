'*************************************************************************
' Nombre:   Cls_Producto
' Tipo de Archivo: clase
' Descripción:  Clase para la manipulacion de productos
' Autores:  RFN
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data
Imports System.Data.SqlClient



Public Class Cls_i_Producto
    Dim opr_negocio As New Cls_Pedido

    Public Sub LlenarCmbUnidades(ByRef cmb_unidad As ComboBox)
        On Error Resume Next
        'Para llenar el combo de ciudad
        Dim opr_i_unidad As New Cls_i_Unidad()
        Dim dts_uni As DataSet
        Dim dtr_fila As DataRow
        dts_uni = opr_i_unidad.LeerUnidad
        cmb_unidad.Items.Clear()
        For Each dtr_fila In dts_uni.Tables("Registros").Rows
            'cmb_unidad.Items.Add(dtr_fila("i_uni_id").ToString())
            cmb_unidad.Items.Add(dtr_fila("I_uni_descripcion").ToString().PadRight(100) & dtr_fila("i_uni_id").PadRight(10).ToString)
        Next
        cmb_unidad.SelectedIndex = 0
    End Sub

    Public Function LeerProductos(ByVal div_id As Byte, ByRef data As DataView)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim dts_operacion As New DataSet()
        If div_id <> 0 Then
            oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID,I_PRODUCTO.I_PRD_DESCRIPCION,I_PRODUCTO.I_PRD_EXIST_MIN,I_PRODUCTO.I_PRD_EXIST_MAX, I_PRODUCTO.I_MOC_ID,I_PRODUCTO.I_PRD_PERECIBLE,I_PRODUCTO.DIV_ID,I_UNIDAD.I_UNI_ID,I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_CADUC, I_PRODUCTO.I_PRD_PORCADUC, I_AID, PRES_ID FROM I_PRODUCTO,I_UNIDAD WHERE I_PRODUCTO.I_UNI_ID = I_UNIDAD.I_UNI_ID AND I_PRODUCTO.DIV_ID = " & div_id & " order by I_PRD_DESCRIPCION", opr_Conexion.conn_sql)
        Else
            oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID,I_PRODUCTO.I_PRD_DESCRIPCION,I_PRODUCTO.I_PRD_EXIST_MIN,I_PRODUCTO.I_PRD_EXIST_MAX, I_PRODUCTO.I_MOC_ID,I_PRODUCTO.I_PRD_PERECIBLE,I_UNIDAD.I_UNI_ID,I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_CADUC, I_PRODUCTO.I_PRD_PORCADUC, I_AID, I_PRODUCTO.I_PRD_FRASCOS, SER_ID, PRES_ID, I_PRD_ABREV FROM I_PRODUCTO,I_UNIDAD WHERE I_PRODUCTO.I_UNI_ID = I_UNIDAD.I_UNI_ID;", opr_Conexion.conn_sql)
        End If

        oda_operacion.Fill(dts_operacion, "Registros")
        opr_conexion.sql_desconn()
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = dts_operacion.Tables("Registros")
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Productos", Err)
        Err.Clear()
    End Function

    Public Function LeercmbProductos(ByVal div_id As Byte) As DataSet
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        If div_id <> 0 Then
            oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID,I_PRODUCTO.I_PRD_DESCRIPCION,I_PRODUCTO.I_PRD_EXIST_MIN,I_PRODUCTO.I_PRD_EXIST_MAX, I_PRODUCTO.I_MOC_ID,I_PRODUCTO.I_PRD_PERECIBLE,I_PRODUCTO.DIV_ID,I_UNIDAD.I_UNI_ID,I_UNIDAD.I_UNI_DESCRIPCION FROM I_PRODUCTO,I_UNIDAD WHERE I_PRODUCTO.I_UNI_ID = I_UNIDAD.I_UNI_ID AND I_PRODUCTO.DIV_ID = " & div_id & " order by I_PRD_DESCRIPCION", opr_Conexion.conn_sql)
        Else
            oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID,I_PRODUCTO.I_PRD_DESCRIPCION,I_PRODUCTO.I_PRD_EXIST_MIN,I_PRODUCTO.I_PRD_EXIST_MAX, I_PRODUCTO.I_MOC_ID,I_PRODUCTO.I_PRD_PERECIBLE,I_UNIDAD.I_UNI_ID,I_UNIDAD.I_UNI_DESCRIPCION FROM I_PRODUCTO,I_UNIDAD WHERE I_PRODUCTO.I_UNI_ID = I_UNIDAD.I_UNI_ID", opr_Conexion.conn_sql)
        End If
        LeercmbProductos = New DataSet()
        oda_operacion.Fill(LeercmbProductos, "Registros")
        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Productos", Err)
        Err.Clear()
    End Function


    Public Function BuscarProducto(ByVal i_prd_id As String) As Boolean
        'Función para consultar si existe el código de un producto antes de insertar otra igual 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from i_producto where i_prd_id = '" & i_prd_id & "'", opr_Conexion.conn_sql)
        Dim dts_prd As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_prd, "Registros")
        For Each dtr_fila In dts_prd.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarProducto = False
            Else
                BuscarProducto = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Buscar Producto", Err)
        Err.Clear()
    End Function

    Public Sub GuardarProducto(ByVal i_prd_id As String, ByVal i_prd_descripcion As String, _
                                  ByVal i_prd_exist_min As Double, ByVal i_prd_exist_max As Double, _
                                  ByVal i_uni_id As String, ByVal i_moc_id As String, ByVal i_prd_perecible As Byte, ByVal cplazo As Int64, ByVal lplazo As Int64, ByVal are_id As Integer, ByVal PRES_ID As Integer, ByVal i_prd_frascos As Integer, ByVal SER_ID As Integer, ByVal ABREV As String)
        'Procedimiento para la insertar un registro en la tabla I_PRODUCTO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Insert into I_PRODUCTO values ('" & i_prd_id & "', '" & _
            i_prd_descripcion & "', " & i_prd_exist_min & ", " & i_prd_exist_max & ", '" & Trim(i_uni_id) & "', '" & Trim(i_moc_id) & "', " & i_prd_perecible & " , " & 1 & ", " & cplazo & ", " & lplazo & ", " & are_id & ", " & PRES_ID & ", " & i_prd_frascos & ", " & SER_ID & ", '" & ABREV & "')", opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        opr_negocio.VisualizaMensaje("Datos almacenados", g_tiempo)
        'MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra de la transacción realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Producto", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Guardar Producto", Err)
        Err.Clear()
    End Sub

    Public Function LeerMaxIdPrd() As Integer
        'funcion que devuelve el numero máximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim anio As Short
        Dim fec_ini, fec_fin As Date
        Dim str_sql As String

        str_sql = "Select isnull(Max(i_prd_id),0) as codigo from i_producto;"
        opr_conexion.sql_conectar()

        LeerMaxIdPrd = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdPrd >= 0 Then
            LeerMaxIdPrd = LeerMaxIdPrd + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Máximo Codigo", Err)
        Err.Clear()
    End Function

    Public Sub ActualizarProducto(ByVal i_prd_id As String, ByVal i_prd_descripcion As String, _
                              ByVal i_prd_exist_min As Double, ByVal i_prd_exist_max As Double, _
                              ByVal i_uni_id As String, ByVal i_moc_id As String, ByVal i_prd_perecible As Byte, ByVal i_prd_id_ant As String, ByVal cmbdiv As Integer, ByVal cplazo As Int64, ByVal lplazo As Int64, ByVal are_id As Integer, ByVal PRES_ID As Integer, ByVal i_prd_frascos As Integer, ByVal SER_ID As Integer, ByVal ABREV As String)
        'Procedimiento para la actualizar un registro en la tabla I_PRODUCTO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Update I_PRODUCTO set i_prd_id = '" & i_prd_id & "', i_prd_descripcion = '" & _
                      i_prd_descripcion & "', i_prd_exist_min = " & i_prd_exist_min & ", i_prd_exist_max = " & _
                      i_prd_exist_max & ", i_uni_id = '" & Trim(i_uni_id) & "', i_moc_id = '" & Trim(i_moc_id) & "', i_prd_perecible = " & i_prd_perecible & ", div_id =  " & cmbdiv & ", i_prd_caduc =  " & cplazo & ", i_prd_porcaduc =  " & lplazo & ", i_aid = " & are_id & ", PRES_ID = " & PRES_ID & ", i_prd_frascos = " & i_prd_frascos & ", SER_ID = " & SER_ID & ", I_PRD_ABREV = '" & ABREV & "' where i_prd_id = '" & i_prd_id_ant & "'", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        opr_negocio.VisualizaMensaje("Datos actualizados", g_tiempo)
        ''MsgBox("Datos actualizados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transacción realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Producto", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Actualizar Producto", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarProducto(ByVal i_prd_id As String)
        'Procedimiento para la eliminar un producto
        On Error GoTo MsgError
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Delete from I_PRODUCTO where i_prd_id = '" & i_prd_id & "'", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra de la transacción realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Producto", "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Eliminar Producto", Err)
        Err.Clear()
    End Sub

    Public Sub LlenarCmbProductos(ByRef cmb_producto As ComboBox, Optional ByVal div_id As Short = 0)
        On Error Resume Next
        'Para llenar el combo de ciudad
        Dim dts_prd As DataSet
        Dim dtr_fila As DataRow
        dts_prd = LeercmbProductos(div_id)
        cmb_producto.Items.Clear()
        For Each dtr_fila In dts_prd.Tables("Registros").Rows
            cmb_producto.Items.Add(dtr_fila("i_prd_descripcion").ToString().PadRight(100) & dtr_fila("i_prd_id").PadRight(15).ToString)
        Next
        cmb_producto.SelectedIndex = 0
    End Sub

    Public Sub ConsultaProducto(ByVal division As Short, ByRef data As DataView)
        'procedimiento que consulta los productos por división, para llenar un grid
        'division 1 medica, 2 diagnostica
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        'division = 0 AMBAS, 1 MEDICA, 2 DIAGNOSTICA
        If division = 0 Then
            STR_SQL = "SELECT I_PRD_ID as CODIGO, I_PRD_DESCRIPCION as DESCRIPCION, I_PRD_PERECIBLE as PERECIBLE, I_UNI_DESCRIPCION as UNIDAD, I_PRODUCTO.I_PRD_FRASCOS AS FRASCOS, I_PRESENTACION.PRES_DESCRIPCION AS PRESENT FROM I_PRODUCTO, I_UNIDAD, I_PRESENTACION WHERE I_PRODUCTO.I_UNI_ID = I_UNIDAD.I_UNI_ID and i_presentacion.PRES_ID = i_producto.PRES_ID order by I_PRD_ID"
        Else
            STR_SQL = "SELECT I_PRD_ID as CODIGO, I_PRD_DESCRIPCION as DESCRIPCION, I_PRD_PERECIBLE as PERECIBLE, I_UNI_DESCRIPCION as UNIDAD, I_PRODUCTO.I_PRD_FRASCOS AS FRASCOS, I_PRESENTACION.PRES_DESCRIPCION AS PRESENT, I_PRD_ABREV AS ABREV FROM I_PRODUCTO, I_UNIDAD, I_PRESENTACION WHERE I_PRODUCTO.I_UNI_ID = I_UNIDAD.I_UNI_ID and i_presentacion.PRES_ID = i_producto.PRES_ID AND I_PRODUCTO.DIV_ID = " & division & " order by I_PRD_ID"
        End If
        opr_conexion.sql_conectar()
        Dim oda_operacion As New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        opr_conexion.sql_desconn()
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = dts_operacion.Tables("Registros")
    End Sub

    Public Function ConsultaProductoEspecificoGrid(ByVal codigo As String) As String
        'procedimiento que consulta un producto especifico, para llenar sus datos en el grid de movimiento
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String = "SELECT I_PRD_ID as CODIGO, I_PRD_DESCRIPCION as DESCRIPCION, I_PRD_PERECIBLE as PERECIBLE, I_UNI_DESCRIPCION as UNIDAD FROM I_PRODUCTO, I_UNIDAD WHERE I_PRODUCTO.I_UNI_ID = I_UNIDAD.I_UNI_ID AND I_PRD_ID = '" & Trim(codigo) & "' order by I_PRD_ID"
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_Conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            ConsultaProductoEspecificoGrid = odr_operacion.GetValue(0).ToString.PadRight(15) & " " & Mid(odr_operacion.GetValue(1).ToString, 1, 20).PadRight(50) & " " & odr_operacion.GetValue(2).ToString.PadRight(20) & " " & odr_operacion.GetValue(3).ToString.PadRight(50)
        End While
        opr_conexion.sql_desconn()
    End Function

    Public Sub ConsultaLote(ByVal producto As String, ByRef data As DataView)
        'jva sept. 2003
        'procedimiento que consulta los lotes de un determinado producto
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim dtr_fila As DataRow
        Dim int_indice, val As Integer
        STR_SQL = "SELECT I_movimiento_detalle.I_mod_lote as LOTE, I_movimiento_detalle.I_mod_fecven as FECHA_VENCIMIENTO, SUM(I_movimiento_detalle.i_mod_cantidad) as sum_cantidad, i_bodega.i_bod_descripcion, i_bodega.i_bod_id FROM I_movimiento_detalle, i_movimiento, i_bodega WHERE I_movimiento_detalle.i_bod_id = i_bodega.i_bod_id and I_movimiento_detalle.I_prd_ID = '" & producto & "' and I_movimiento_detalle.i_mov_id = i_movimiento.i_mov_id and (I_movimiento_detalle.i_mod_estado = 0 or I_movimiento_detalle.i_mod_estado = 1 ) and (i_movimiento.i_mov_estado <> 0 and i_movimiento.i_mov_estado <> 3) group by I_mod_LOTE, I_movimiento_detalle.I_mod_fecven, i_bodega.I_BOD_DESCRIPCION, i_bodega.I_BOD_ID"
        opr_conexion.sql_conectar()
        Dim oda_operacion As New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        For int_indice = 0 To dts_operacion.Tables(0).Rows.Count - 1
            If dts_operacion.Tables("Registros").Rows.Count > 0 Then
                If dts_operacion.Tables("Registros").Rows(int_indice).Item(2) = 0 Then dts_operacion.Tables("Registros").Rows(int_indice).Delete()
            End If
        Next
        opr_conexion.sql_desconn()
        'data.AllowDelete = False
        data.AllowEdit = True
        data.AllowNew = False
        data.Table = dts_operacion.Tables("Registros")
    End Sub

    Sub ordena_producto(ByVal campo As String, ByVal busqueda As String, ByRef data As DataView)
        'función que orderna por campo al dataview
        With data
            If Trim(busqueda) <> "" Then
                If campo = "ABREV" Then
                    .RowFilter = campo & " like '" & Trim(busqueda) & "*'"
                Else
                    .RowFilter = campo & " like '" & Trim(busqueda) & "*'"
                End If
            Else
                .RowFilter = ""
            End If
            .Sort = campo
        End With
        data.AllowEdit = True
        data.AllowNew = False
    End Sub

    Sub ordena_producto_mov(ByVal campo As String, ByVal busqueda As String, ByVal movi As String, ByRef data As DataView)
        'función que orderna por 2 campos al dataview
        With data
            If Trim(busqueda) <> "" Then
                If campo = "i_mov_id" Then
                    .RowFilter = campo & " = " & Trim(busqueda)
                Else
                    .RowFilter = campo & " like '" & Trim(movi) & "*' and i_prd_id like '" & Trim(busqueda) & "*'"
                End If
            Else
                .RowFilter = ""
            End If
            .Sort = campo
        End With
        data.AllowEdit = True
        data.AllowNew = False
    End Sub

    Public Sub guardarLote(ByVal producto As String, ByRef data As DataView, ByVal lote As String, ByVal fechaven As String, ByVal val As Boolean)
        '******TEMPORAL, CAMBIA LOS LOTES AL VALOR CORRECTO'
        'jva  18 sept. 2003
        'procedimiento que cambia los lotes
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim fv As String
        If fechaven = "" Then
            fv = "Null"
        Else
            fv = "'" & Format(CDate(fechaven), "dd/MM/yyyy") & "'"
        End If

        If val = True Then
            STR_SQL = "update i_movimiento_detalle set i_mod_fecven = " & fv & " where i_prd_id = '" & producto & "' and i_mod_lote = '" & lote & "'"
        Else
            If fv = "Null" Then
                STR_SQL = "update i_movimiento_detalle set i_mod_lote = '" & lote & "' where i_prd_id = '" & producto & "' and isnull(i_mod_fecven) "
            Else
                STR_SQL = "update i_movimiento_detalle set i_mod_lote = '" & lote & "' where i_prd_id = '" & producto & "' and i_mod_fecven = " & fv & ""
            End If
        End If
        opr_conexion.sql_conectar()
        Dim oda_operacion As New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        opr_conexion.sql_desconn()
        'data.Table = dts_operacion.Tables("Registros")
    End Sub

    Public Sub LlenarCmbdivision(ByRef cmb_div As ComboBox)
        On Error Resume Next
        'Para llenar el combo de ciudad
        Dim opr_i_unidad As New Cls_i_Unidad()
        Dim dts_uni As DataSet
        Dim dtr_fila As DataRow
        dts_uni = opr_i_unidad.Leerdiv
        cmb_div.Items.Clear()
        For Each dtr_fila In dts_uni.Tables("Registros").Rows
            'cmb_unidad.Items.Add(dtr_fila("i_uni_id").ToString())
            cmb_div.Items.Add(dtr_fila("div_nombre").ToString().PadRight(50) & dtr_fila("div_id").ToString)
        Next
        cmb_div.SelectedIndex = 19
    End Sub



End Class
