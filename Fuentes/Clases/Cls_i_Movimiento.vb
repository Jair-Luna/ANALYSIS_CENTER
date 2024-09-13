'*************************************************************************
' Nombre:   Cls_Movimiento
' Tipo de Archivo: clase
' Descripción:  Clase para la manipulacion de los movimientos en el inventario
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



Public Class Cls_i_Movimiento

    Public Sub leerMovKardex(ByVal i_prd_id As String, ByVal i_bod_id As String, ByVal fi As Date, ByVal ff As Date, ByRef dtt_mov As DataTable)
        'Procedimiento para consultar los movimientos que ha tenido un producto determinado
        'en una bodega, en un tiempo determinado.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        STR_SQL = "SELECT i_mod_id as MovDet, a.i_mov_id as i_mov_id, i_mov_fecdoc as Fecha, " & _
        "b.i_prd_id as prdCod, c.i_prd_descripcion as Producto, a.I_TIM_ID AS I_TIM_ID, d.I_TIM_descripcion as I_TIM_descripcion,  b.i_mod_descripcion as  i_mod_descripcion, " & _
        "' ' as I_CANTIDAD, ' ' as I_VAL_UNI, ' ' as I_VAL_TOTAL, ' ' as E_CANTIDAD, ' ' as E_VAL_UNI," & _
        "' ' as E_VAL_TOTAL, ' ' as T_CANTIDAD, ' ' as T_VAL_UNI, ' ' as T_VAL_TOTAL, b.I_MOD_LOTE as I_MOD_LOTE, b.I_MOD_FECVEN AS I_MOD_FECVEN, a.I_MOV_DOC AS I_MOV_DOC  " & _
        "FROM I_MOVIMIENTO a, I_MOVIMIENTO_DETALLE b, I_PRODUCTO c, I_TIPO_MOVIMIENTO d " & _
        "WHERE (a.i_tim_id = d.i_tim_id) and (b.i_prd_id = c.i_prd_id) and ( (a.i_mov_id = b.i_mov_id) " & _
        "and (b.I_BOD_ID = '" & i_bod_id & "') and (b.i_prd_id = '" & i_prd_id & "')" & _
        " and ((a.i_mov_fecdoc) Between  '" & Format(fi, "dd/MM/yyyy") & " 00:00:00' and '" & Format(ff, "dd/MM/yyyy") & " 23:59:59')) and (b.I_MOD_ESTADO = 0 or b.I_MOD_ESTADO = 1 ) and (a.I_MOV_ESTADO <> 0 and a.I_MOV_ESTADO <> 3) ORDER BY fecha, i_mov_id"
        ', i_mov_id ASC "

        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_mov)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transacción solicitada, Leer MovKardex", Err)
        Err.Clear()
    End Sub

    Public Function F_leerMovKardex(ByVal i_prd_id As String, ByVal i_bod_id As String, ByVal fi As Date, ByVal ff As Date) As DataSet
        'Función para consultar los movimientos que ha tenido un producto determinado
        'en una bodega, en un tiempo determinado.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        STR_SQL = "SELECT i_mod_id as MovDet, a.i_mov_id as i_mov_id, i_mov_fecmov as Fecha, " & _
        "b.i_prd_id as prdCod, c.i_prd_descripcion as Producto, a.I_TIM_ID AS I_TIM_ID, d.I_TIM_descripcion as I_TIM_descripcion,  b.i_mod_descripcion as  i_mod_descripcion, " & _
        "' ' as I_CANTIDAD, ' ' as I_VAL_UNI, ' ' as I_VAL_TOTAL, ' ' as E_CANTIDAD, ' ' as E_VAL_UNI," & _
        "' ' as E_VAL_TOTAL, ' ' as T_CANTIDAD, ' ' as T_VAL_UNI, ' ' as T_VAL_TOTAL " & _
        "FROM I_MOVIMIENTO a, I_MOVIMIENTO_DETALLE b, I_PRODUCTO c, I_TIPO_MOVIMIENTO d " & _
        "WHERE (a.i_tim_id = d.i_tim_id) and (b.i_prd_id = c.i_prd_id) and ( (a.i_mov_id = b.i_mov_id) " & _
        "and (b.I_BOD_ID = '" & i_bod_id & "') and (b.i_prd_id = '" & i_prd_id & "')" & _
        " and ((a.i_mov_fecmov) Between '" & Format(fi, "dd/MM/yyyy") & "' and '" & Format(ff, "dd/MM/yyyy") & "')) ORDER BY i_mov_fecmov ASC "
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        F_leerMovKardex = New DataSet()
        oda_operacion.Fill(F_leerMovKardex, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transacción solicitada, leer MovKardex", Err)
        Err.Clear()
    End Function

    Public Function LeerMovDet(ByVal i_mod_id As Integer, ByVal i_mov_id As Integer) As DataSet
        'Funcion para la consultar un detalle de movimiento 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT a.I_MOD_CANTIDAD, a.I_MOD_COSTO, b.I_TIM_TIPO " & _
        "FROM I_TIPO_MOVIMIENTO AS b INNER JOIN (I_MOVIMIENTO AS c INNER JOIN I_MOVIMIENTO_DETALLE AS a ON c.I_MOV_ID = a.I_MOV_ID) " & _
        "ON b.I_TIM_ID = c.I_TIM_ID WHERE (((a.I_MOD_ID)=" & i_mod_id & ") AND ((a.I_MOV_ID)= " & i_mov_id & "))", opr_Conexion.conn_sql)
        LeerMovDet = New DataSet()
        oda_operacion.Fill(LeerMovDet, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer MovDeterminado " & ControlChars.CrLf & Err.Description, Err)
        Err.Clear()
    End Function


    Public Function ListaStock(ByVal filtro As Byte, ByVal i_bod_id As String) As Integer
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()

        Dim str_sql As String = Nothing
        str_sql = "select COUNT(I_prd_id) from i_temp_stock where cantidad = " & filtro

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        opr_Conexion.sql_conectar()

        ListaStock = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)

        opr_Conexion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Conteo stock", Err)
        Err.Clear()
    End Function

    Public Function LlenarListaStock(ByVal div_id As Byte, ByRef data As DataView, ByVal i_mov_fecmov As Date, ByVal i_bod_id As String, ByVal dbl_porcentaje As Double, ByVal boton As Boolean, Optional ByVal estado As Int32 = 0, Optional ByVal division As String = "")
        On Error GoTo MsgError
        dbl_porcentaje = System.Configuration.ConfigurationSettings.AppSettings("porcentaje")
        Dim opr_Conexion As New Cls_Conexion()
        Dim int_indice As Integer
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing


        opr_Conexion.sql_conectar()
        'opr_Conexion.conn_sql()
        Dim dts_operacion As New DataSet()
        'Dim aux As String = "I_MOVIMIENTO.I_MOV_ESTADO = 1 or I_MOVIMIENTO.I_MOV_ESTADO = 2"
        Dim aux As String = "(I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 or I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3)"
        Dim aux1 As String = " (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)) "
        If estado = 1 Then
            aux = "(I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3)"
            'aux = "I_MOVIMIENTO.I_MOV_ESTADO = 2"
            aux1 = " (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)*-1) "
        ElseIf estado = 2 Then
            'aux = "I_MOVIMIENTO.I_MOV_ESTADO = 1"
            aux = "(I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3)"
            aux1 = " (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)) "
        End If

        If boton = True Then ' SI LA SELECCION ES POR LOTES
            If i_bod_id = "<Todos>" Then
                If div_id = 0 Then
                    oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE, " & aux1 & " AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD, I_MOD_FECVEN AS VENCIMIENTO  FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(i_mov_fecmov, "dd/MM/yyyy") & "')) and I_PRODUCTO.DIV_ID= '" & division & "' and (" & aux & " ) GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID ORDER BY I_PRODUCTO.I_PRD_ID;", opr_Conexion.conn_sql)
                Else
                    oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE, " & aux1 & " AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD, I_MOD_FECVEN AS VENCIMIENTO  FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(i_mov_fecmov, "dd/MM/yyyy") & "')) and I_PRODUCTO.DIV_ID= '" & div_id & "'  and (" & aux & ") GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID ORDER BY I_PRODUCTO.I_PRD_ID;", opr_Conexion.conn_sql)
                End If
            Else

                str_sql = "SELECT I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, " & _
                    "case when I_MOVIMIENTO_DETALLE.I_MOD_LOTE = NULL or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '' then 'Sin Lote' else I_MOVIMIENTO_DETALLE.I_MOD_LOTE end AS LOTE, (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD))  AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, " & _
                    "case when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1 then 1 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000 then 2 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(0 /100))) then 3 else 0 end AS CANTIDAD, I_MOD_FECVEN AS VENCIMIENTO " & _
                    "FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID " & _
                    "WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(i_mov_fecmov, "dd/MM/yyyy") & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & i_bod_id & "')) and (" & aux & " ) " & _
                    "GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN " & _
                    "ORDER BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN"
                oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
                'oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE,  " & aux1 & " AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX,  if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD, I_MOD_FECVEN AS VENCIMIENTO FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(i_mov_fecmov, "dd/MM/yyyy") & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & i_bod_id & "')) and (" & aux & " ) GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID ORDER BY I_PRODUCTO.I_PRD_ID;", opr_Conexion.conn_sql)
            End If

        Else ' SI LA SELECCION ES DE TODOS LOS PRODUCTOS
            If i_bod_id = "<Todos>" Then
                If div_id = 0 Then
                    oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE, " & aux1 & " AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD, I_MOD_FECVEN AS VENCIMIENTO  FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(i_mov_fecmov, "dd/MM/yyyy") & "')) and I_PRODUCTO.DIV_ID= '" & division & "' and (" & aux & ") GROUP BY I_PRODUCTO.I_PRD_ID, I_UNIDAD.I_UNI_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX ORDER BY I_PRODUCTO.I_PRD_ID;", opr_Conexion.conn_sql)
                Else
                    oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE, " & aux1 & " AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD, I_MOD_FECVEN AS VENCIMIENTO  FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(i_mov_fecmov, "dd/MM/yyyy") & "')) and I_PRODUCTO.DIV_ID= '" & div_id & "'  and (" & aux & ") GROUP BY I_PRODUCTO.I_PRD_ID, I_UNIDAD.I_UNI_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX ORDER BY I_PRODUCTO.I_PRD_ID;", opr_Conexion.conn_sql)
                End If
            Else
                oda_operacion.SelectCommand = New SqlCommand("SELECT I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION,  " & aux1 & " AS SumaDeI_MOD_CANTIDAD FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(i_mov_fecmov, "dd/MM/yyyy") & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & i_bod_id & "')) and (" & aux & ") GROUP BY I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION ORDER BY I_PRODUCTO.I_PRD_ID;", opr_Conexion.conn_sql)
            End If
        End If
        oda_operacion.Fill(dts_operacion, "Registros")

        Dim dtr_operacion As DataRow
        Dim str_sql_insert As String = Nothing
        Dim str_sql_del As String = Nothing
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql_del As SqlCommand
        Dim odbc_strsql_ins As SqlCommand

        str_sql_del = "delete from i_temp_stock;"
        odbc_strsql_del = New SqlCommand(str_sql_del, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql_del.ExecuteNonQuery()

        For Each dtr_operacion In dts_operacion.Tables("Registros").Rows
            str_sql_insert = "Insert into i_temp_stock values ('" & dtr_operacion(0) & "', '" & Trim(dtr_operacion(1)) & "', '" & Trim(dtr_operacion(2)) & "' , " & dtr_operacion(3) & " , '" & Trim(dtr_operacion(4)) & "', " & dtr_operacion(5) & ", " & dtr_operacion(6) & ", " & dtr_operacion(7) & ")   "
            odbc_strsql_ins = New SqlCommand(str_sql_insert, opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql_ins.ExecuteNonQuery()
            str_sql_insert = ""
        Next

        opr_Conexion.sql_desconn()
        'opr_conexion.sql_desconn
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = dts_operacion.Tables("Registros")
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Productos", Err)
        Err.Clear()

    End Function

    Sub LlenarListaCaducado(ByRef lstv_caducado As ListView, ByVal i_bod_id As String, ByVal formulario As String, ByRef conteo As Integer, ByRef dts_operacion As DataSet, Optional ByVal tipo As String = "", Optional ByVal fechai As String = "", Optional ByVal fechaf As String = "")
        'me permite llenar un listview con los datos que estan por caducarse y caducados
        On Error GoTo MsgError
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        lstv_caducado.Items.Clear()
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim strsql1 As String
        conteo = 0
        lstv_caducado.Items.Clear()

        If fechai = "" Then
            strsql1 = "SELECT I_PRODUCTO.I_PRD_DESCRIPCION, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PERECIBLE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PORCADUC, I_PRODUCTO.I_PRD_CADUC FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO_DETALLE INNER JOIN I_MOVIMIENTO ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID ) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE I_MOVIMIENTO_DETALLE.I_BOD_ID = '" & i_bod_id & "' AND I_PRODUCTO.I_PRD_PERECIBLE = 1 AND (I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 or I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3)  GROUP BY I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PERECIBLE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PORCADUC, I_PRODUCTO.I_PRD_CADUC  ORDER BY I_PRODUCTO.I_PRD_ID;"
            '"SELECT I_PRODUCTO.I_PRD_DESCRIPCION, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PERECIBLE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PORCADUC, I_PRODUCTO.I_PRD_CADUC FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & i_bod_id & "')AND ((I_PRODUCTO.I_PRD_PERECIBLE)=1)) GROUP BY I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_ID, I_PRODUCTO.I_PRD_ID ORDER BY I_PRODUCTO.I_PRD_ID;"
        Else
            strsql1 = "SELECT I_PRODUCTO.I_PRD_DESCRIPCION, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PERECIBLE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PORCADUC, I_PRODUCTO.I_PRD_CADUC, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_MOVIMIENTO_DETALLE.I_MOD_LOTE FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO_DETALLE INNER JOIN I_MOVIMIENTO ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE I_MOVIMIENTO_DETALLE.I_BOD_ID = '" & i_bod_id & "' AND I_PRODUCTO.I_PRD_PERECIBLE=1 AND  (I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 or I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3) and I_MOVIMIENTO_DETALLE.I_MOD_FECVEN between '" & Format(CDate(fechai), "yyyy/MM/dd") & "' and '" & Format(CDate(fechaf), "yyyy/MM/dd") & "' GROUP BY I_PRODUCTO.I_PRD_ID,  I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_UNIDAD.I_UNI_ID ORDER BY  I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_PRODUCTO.I_PRD_ID;"
            '"SELECT I_PRODUCTO.I_PRD_DESCRIPCION, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) AS SumaDeI_MOD_CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PERECIBLE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_PORCADUC, I_PRODUCTO.I_PRD_CADUC, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_MOVIMIENTO_DETALLE.I_MOD_LOTE FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & i_bod_id & "')AND ((I_PRODUCTO.I_PRD_PERECIBLE)=1)) and I_MOVIMIENTO_DETALLE.I_MOD_FECVEN between '" & Format(CDate(fechai), "yyyy/MM/dd") & "' and '" & Format(CDate(fechaf), "yyyy/MM/dd") & "' GROUP BY I_PRODUCTO.I_PRD_ID,  I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_UNIDAD.I_UNI_ID ORDER BY  I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_PRODUCTO.I_PRD_ID;"
        End If
        oda_operacion.SelectCommand = New SqlCommand(strsql1, cls_operacion.conn_sql)
        '''Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        oda_operacion.Fill(dts_operacion, "Registros")

        Dim int_i As Integer = 0
        Dim valor As String
        For Each dtr_operacion In dts_operacion.Tables("Registros").Rows
            Dim dts_operacion2 As New DataSet()
            Dim dtr_operacion2 As DataRow

            Dim strsql As String
            If fechai = "" Then
                strsql = "SELECT I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) AS SumaDeI_MOD_CANTIDAD, I_MOVIMIENTO_DETALLE.I_MOD_LOTE FROM I_MOVIMIENTO_DETALLE, I_MOVIMIENTO WHERE I_MOVIMIENTO_DETALLE.I_PRD_ID = '" & dtr_operacion(3).ToString() & "' And I_MOVIMIENTO_DETALLE.I_BOD_ID = '" & i_bod_id & "' AND  (I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 or I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3) AND I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID group by I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN ORDER BY I_MOVIMIENTO_DETALLE.I_MOD_FECVEN DESC;"
                '"SELECT I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD, I_MOVIMIENTO_DETALLE.I_MOV_ID,I_MOVIMIENTO_DETALLE.I_MOD_LOTE FROM(I_MOVIMIENTO_DETALLE)WHERE(((I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) >= 0) And ((I_MOVIMIENTO_DETALLE.I_PRD_ID) = '" & dtr_operacion(3).ToString() & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & i_bod_id & "')) ORDER BY I_MOVIMIENTO_DETALLE.I_MOD_FECVEN DESC;"
            Else
                strsql = "SELECT I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) AS SumaDeI_MOD_CANTIDAD, I_MOVIMIENTO_DETALLE.I_MOD_LOTE FROM I_MOVIMIENTO_DETALLE, I_MOVIMIENTO WHERE I_MOVIMIENTO_DETALLE.I_PRD_ID = '" & dtr_operacion(3).ToString() & "' And I_MOVIMIENTO_DETALLE.I_BOD_ID = '" & i_bod_id & "' AND  (I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 or I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3) AND I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID and I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '" & dtr_operacion(9).ToString() & "' and I_MOVIMIENTO_DETALLE.I_MOD_FECVEN = '" & Format(CDate(dtr_operacion(8)), "dd/MM/yyyy") & "' group by I_MOVIMIENTO_DETALLE.I_MOD_LOTE ORDER BY I_MOVIMIENTO_DETALLE.I_MOD_FECVEN DESC;"
                '"SELECT I_MOVIMIENTO_DETALLE.I_MOD_FECVEN, I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD, I_MOVIMIENTO_DETALLE.I_MOV_ID,I_MOVIMIENTO_DETALLE.I_MOD_LOTE FROM(I_MOVIMIENTO_DETALLE)WHERE(((I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) >= 0) And ((I_MOVIMIENTO_DETALLE.I_PRD_ID) = '" & dtr_operacion(3).ToString() & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & i_bod_id & "'))and I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '" & dtr_operacion(9).ToString() & "' and I_MOVIMIENTO_DETALLE.I_MOD_FECVEN = '" & Format(CDate(dtr_operacion(8)), "dd/MM/yyyy") & "' ORDER BY I_MOVIMIENTO_DETALLE.I_MOD_FECVEN;"
            End If

            oda_operacion.SelectCommand = New SqlCommand(strsql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion2, "Registros")
            Dim bdl_cantidad As Double = dtr_operacion(1)


            'items: Todos     Caducado      Corto plazo       Largo plazo
            Dim imagen As Int16
            If tipo = "" Or tipo = "Todos" Then
                valor = dtr_operacion(6)
            ElseIf tipo = "Caducado" Then
                valor = 0
                imagen = 1
            ElseIf tipo = "Corto plazo" Then
                valor = dtr_operacion(7)
                imagen = 2
            ElseIf tipo = "Largo plazo" Then
                valor = dtr_operacion(6)
                imagen = 0
            End If

            For Each dtr_operacion2 In dts_operacion2.Tables("Registros").Rows
                Dim bdl_cantidad2 As Double = dtr_operacion2(1)

                If bdl_cantidad <= 0 Or dtr_operacion(4).ToString() = "0" Then
                    Exit For
                End If
                If Not IsDBNull(dtr_operacion2(0)) And bdl_cantidad2 <> 0 Then
                    If tipo = "Anual" Then
                        lstv_caducado.Items.Add(dtr_operacion(5).ToString())
                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(0).ToString())
                        If bdl_cantidad >= dtr_operacion2(1) Then
                            lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(1).ToString())
                        Else
                            lstv_caducado.Items(int_i).SubItems.Add(bdl_cantidad)
                        End If
                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(2).ToString())
                        lstv_caducado.Items(int_i).SubItems.Add(Format(CDate(dtr_operacion2(0).ToString), "yyyy/MM/dd"))
                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(2).ToString())
                        'lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(3).ToString())
                        int_i += 1

                    ElseIf Format(dtr_operacion2(0), "yyyy/MM/dd") <= Format(Today, "yyyy/MM/dd") Or Format(dtr_operacion2(0), "yyyy/MM/dd") <= Format((DateAdd(DateInterval.Day, CInt(valor), Today)), "yyyy/MM/dd") Then
                        If tipo = "" Or tipo = "Todos" Then
                            lstv_caducado.Items.Add(dtr_operacion(5).ToString())
                            lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(0).ToString())
                            If bdl_cantidad >= dtr_operacion2(1) Then
                                lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(1).ToString())
                            Else
                                lstv_caducado.Items(int_i).SubItems.Add(bdl_cantidad)
                            End If
                            lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(2).ToString())
                            lstv_caducado.Items(int_i).SubItems.Add(Format(CDate(dtr_operacion2(0).ToString), "yyyy/MM/dd"))
                            lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(2).ToString())
                            'lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(3).ToString())

                            If Format(dtr_operacion2(0), "yyyy/MM/dd") <= Format(Today, "yyyy/MM/dd") Then
                                'Producto Caducado
                                lstv_caducado.Items(int_i).ImageIndex = 1
                            Else
                                If Format(dtr_operacion2(0), "yyyy/MM/dd") <= Format((DateAdd(DateInterval.Day, dtr_operacion(7), Today)), "yyyy/MM/dd") Then
                                    'Caduca a corto plazo
                                    lstv_caducado.Items(int_i).ImageIndex = 2
                                Else
                                    'Caduca a largo plazo
                                    lstv_caducado.Items(int_i).ImageIndex = 0
                                End If
                            End If
                            int_i += 1
                        Else
                            If (Format(dtr_operacion2(0), "yyyy/MM/dd") <= Format(Today, "yyyy/MM/dd")) And tipo = "Caducado" Then
                                'Producto Caducado
                                If formulario <> "semaforo" Then
                                    lstv_caducado.Items.Add(dtr_operacion(5).ToString())
                                    lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(0).ToString())
                                    If bdl_cantidad >= dtr_operacion2(1) Then
                                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(1).ToString())
                                    Else
                                        lstv_caducado.Items(int_i).SubItems.Add(bdl_cantidad)
                                    End If
                                    lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(2).ToString())
                                    lstv_caducado.Items(int_i).SubItems.Add(Format(CDate(dtr_operacion2(0).ToString), "yyyy/MM/dd"))
                                    lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(2).ToString())
                                    'lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(3).ToString())

                                    lstv_caducado.Items(int_i).ImageIndex = 1
                                    int_i += 1
                                Else
                                    conteo = conteo + 1
                                End If
                            Else
                                If (Format(dtr_operacion2(0), "yyyy/MM/dd") <= Format((DateAdd(DateInterval.Day, dtr_operacion(7), Today)), "yyyy/MM/dd")) And (Format(dtr_operacion2(0), "yyyy/MM/dd") > Format(Today, "yyyy/MM/dd")) And tipo = "Corto plazo" Then
                                    'Caduca a corto plazo
                                    If formulario <> "semaforo" Then
                                        lstv_caducado.Items.Add(dtr_operacion(5).ToString())
                                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(0).ToString())
                                        If bdl_cantidad >= dtr_operacion2(1) Then
                                            lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(1).ToString())
                                        Else
                                            lstv_caducado.Items(int_i).SubItems.Add(bdl_cantidad)
                                        End If
                                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(2).ToString())
                                        lstv_caducado.Items(int_i).SubItems.Add(Format(CDate(dtr_operacion2(0).ToString), "yyyy/MM/dd"))
                                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(2).ToString())
                                        'lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(3).ToString())

                                        lstv_caducado.Items(int_i).ImageIndex = 2
                                        int_i += 1
                                    Else
                                        conteo = conteo + 1
                                    End If
                                ElseIf (Format(dtr_operacion2(0), "yyyy/MM/dd") > Format((DateAdd(DateInterval.Day, dtr_operacion(7), Today)), "yyyy/MM/dd")) And tipo = "Largo plazo" Then
                                    'Caduca a largo plazo
                                    lstv_caducado.Items.Add(dtr_operacion(5).ToString())
                                    lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(0).ToString())
                                    If bdl_cantidad >= dtr_operacion2(1) Then
                                        lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(1).ToString())
                                    Else
                                        lstv_caducado.Items(int_i).SubItems.Add(bdl_cantidad)
                                    End If
                                    lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion(2).ToString())
                                    lstv_caducado.Items(int_i).SubItems.Add(Format(CDate(dtr_operacion2(0).ToString), "yyyy/MM/dd"))
                                    lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(2).ToString())
                                    'lstv_caducado.Items(int_i).SubItems.Add(dtr_operacion2(3).ToString())

                                    lstv_caducado.Items(int_i).ImageIndex = 0
                                    int_i += 1
                                End If
                            End If
                        End If
                        'int_i += 1
                    End If
                    bdl_cantidad -= dtr_operacion2(1)
                    If bdl_cantidad <= 0 Then
                        Exit For
                    End If
                End If
            Next
        Next
        cls_operacion.sql_desconn()
        dts_operacion.Clear()
        Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Llenar Lista Caducado", Err)
        Err.Clear()
    End Sub
    Public Function leerbodega(ByVal pro_ID As String, ByVal I_BOD_ID As String, Optional ByVal lote As String = "") As DataSet
        'Procedimiento para ver la bodega de un producto
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        If lote = "" Then
            'STR_SQL = "select i_movimiento_detalle.i_bod_id, SUM(i_movimiento_detalle.i_mod_cantidad) as sum_cantidad from i_movimiento_detalle, i_movimiento  where i_prd_id = '" & pro_ID & "' and i_movimiento_detalle.i_mov_id = i_movimiento.i_mov_id  and (i_movimiento.i_mov_estado = 1 or i_movimiento.i_mov_estado = 2) group by i_movimiento_detalle.i_bod_id"
            STR_SQL = "select i_movimiento_detalle.i_bod_id, SUM(i_movimiento_detalle.i_mod_cantidad) as sum_cantidad, i_movimiento_detalle.I_MOD_LOTE as lote from i_movimiento_detalle, i_movimiento  where i_bod_id = '" & I_BOD_ID & "' and i_prd_id = '" & pro_ID & "' and i_movimiento_detalle.i_mov_id = i_movimiento.i_mov_id  and (i_movimiento_detalle.I_MOD_ESTADO = 0 or i_movimiento_detalle.I_MOD_ESTADO = 1 ) and (i_movimiento.I_MOV_ESTADO <> 0 and i_movimiento.I_MOV_ESTADO <> 3) group by i_movimiento_detalle.i_bod_id, i_movimiento_detalle.I_MOD_LOTE"
        Else
            'STR_SQL = "select i_movimiento_detalle.i_bod_id, SUM(i_movimiento_detalle.i_mod_cantidad) as sum_cantidad from i_movimiento_detalle, i_movimiento  where i_prd_id = '" & pro_ID & "' and i_movimiento_detalle.i_mov_id = i_movimiento.i_mov_id and i_movimiento_detalle.i_mod_lote = '" & lote & "' and (i_movimiento.i_mov_estado = 1 or i_movimiento.i_mov_estado = 2) group by i_movimiento_detalle.i_bod_id"
            STR_SQL = "select i_movimiento_detalle.i_bod_id, SUM(i_movimiento_detalle.i_mod_cantidad) as sum_cantidad, i_movimiento_detalle.I_MOD_LOTE as lote from i_movimiento_detalle, i_movimiento  where i_bod_id = '" & I_BOD_ID & "' and i_prd_id = '" & pro_ID & "' and i_movimiento_detalle.i_mov_id = i_movimiento.i_mov_id and (i_movimiento_detalle.I_MOD_ESTADO = 0 or i_movimiento_detalle.I_MOD_ESTADO = 1 ) and (i_movimiento.I_MOV_ESTADO <> 0 and i_movimiento.I_MOV_ESTADO <> 3) group by i_movimiento_detalle.i_bod_id, i_movimiento_detalle.I_MOD_LOTE"
        End If

        'STR_SQL = "select i_movimiento_detalle.i_bod_id from i_movimiento_detalle, i_movimiento  where i_prd_id = '" & pro_ID & "' and i_movimiento.i_tim_id = 'SI' and i_movimiento_detalle.i_mov_id = i_movimiento.i_mov_id"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        leerbodega = New DataSet()
        oda_operacion.Fill(leerbodega, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, consulta de movimientos", Err)
        Err.Clear()
    End Function
    '********jva 01/10/2003
    Public Function ExisteMovimiento(ByVal MOV_ID As Long, Optional ByRef MOV_ESTADO As Single = 0) As Single
        'Procedimiento para los verificar si una factura existe y su estado
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        Dim STR_SQL As String

        opr_conexion.sql_conectar()
        'STR_SQL = "Select I_MOV_ID, I_MOV_ESTADO from I_MOVIMIENTO where I_MOV_ID = " & MOV_ID
        STR_SQL = "Select a.I_MOV_ID, a.I_MOV_ESTADO, c.DIV_ID, b.I_MOD_ESTADO from I_MOVIMIENTO AS a INNER JOIN (I_MOVIMIENTO_DETALLE AS b INNER JOIN I_PRODUCTO AS c ON b.I_PRD_ID = c.I_PRD_ID) ON a.I_MOV_ID = b.I_MOV_ID  where a.I_MOV_ID = " & MOV_ID & "  GROUP BY a.I_MOV_ID, a.I_MOV_ESTADO, c.DIV_ID, b.I_MOD_ESTADO "
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        oda_operacion.Fill(dts_operacion)
        ExisteMovimiento = 4
        If dts_operacion.Tables(0).Rows.Count() > 0 Then
            ExisteMovimiento = 0
            dtr_operacion = dts_operacion.Tables(0).Rows(0)
            If Not IsDBNull(dtr_operacion(1)) And (dtr_operacion(1)) <> 0 Then
                ExisteMovimiento = 1
                If dtr_operacion(3) = 2 Then ExisteMovimiento = 2
                'MOV_ESTADO = dtr_operacion(1)
            End If
            If (dtr_operacion(2)) <> g_division Then
                ExisteMovimiento = 3
            End If
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Verifica existencia de movimiento", Err)
        Err.Clear()
    End Function

    Public Function MovimientoPosterior(ByVal MOV_ID As Long, ByVal bod_id As String, ByVal prod_id As String) As Boolean
        'busca movimientos de dicho producto posteriores
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        MovimientoPosterior = False
        opr_conexion.sql_conectar()
        STR_SQL = "Select count(i_mov_id) from I_MOVIMIENTO_DETALLE where I_MOV_ID>" & MOV_ID & " and I_BOD_ID='" & bod_id & "' and I_PRD_ID='" & prod_id & "'"
        If CInt(New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteScalar) > 0 Then
            MovimientoPosterior = True
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Verificar movimientos posteriores", Err)
        Err.Clear()
    End Function

    Public Function leerMovimiento(ByVal MOV_ID As Long) As DataSet
        'Procedimiento para los datos de una factura especifica
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        STR_SQL = "SELECT i_movimiento.I_MOV_ID, i_movimiento.I_MOV_FECMOV, i_movimiento.I_MOV_FECDOC, " & _
        "i_movimiento.I_MOV_DOC, i_movimiento.I_PRO_ID, i_movimiento.I_TIM_ID, i_movimiento.I_MOV_ESTADO, " & _
        "i_movimiento.I_MOV_RESPONSABLE, i_movimiento_detalle.I_MOD_ID, i_movimiento_detalle.I_PRD_ID, " & _
        "i_movimiento_detalle.I_MOD_CANTIDAD, i_movimiento_detalle.I_MOD_COSTO, i_movimiento_detalle.I_BOD_ID, " & _
        "i_movimiento_detalle.I_MOD_FECVEN, i_movimiento_detalle.I_MOD_DESCRIPCION, i_producto.I_PRD_DESCRIPCION, " & _
        "i_bodega.I_BOD_DESCRIPCION, i_movimiento.I_MOV_REFMOV,i_movimiento_detalle.I_MOD_LOTE, (invitado.invitado_nombre + ' ' + invitado.invitado_apellido) , i_movimiento.I_MOV_ENTREGADO FROM (i_bodega INNER JOIN (i_movimiento INNER JOIN i_movimiento_detalle ON " & _
        "i_movimiento.I_MOV_ID = i_movimiento_detalle.I_MOV_ID) ON i_bodega.I_BOD_ID = i_movimiento_detalle.I_BOD_ID) " & _
        "INNER JOIN i_producto ON i_movimiento_detalle.I_PRD_ID = i_producto.I_PRD_ID, invitado WHERE i_movimiento_detalle.I_MOV_ID = " & MOV_ID & " and invitado.invitado_id = i_movimiento .invitado_id  "
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        leerMovimiento = New DataSet()
        oda_operacion.Fill(leerMovimiento, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, consulta de movimientos", Err)
        Err.Clear()
    End Function

    Public Function leerMovimientoDev(ByVal MOV_ID As Long) As Boolean
        'Procedimiento que busca si un movimiento, fue operado como devuelto
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        leerMovimientoDev = False
        opr_conexion.sql_conectar()
        STR_SQL = "select count(I_MOV_REFMOV) from I_MOVIMIENTO where I_MOV_REFMOV='" & MOV_ID & "'"
        If CInt(New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteScalar) > 0 Then
            leerMovimientoDev = True
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, consulta de movimientos devueltos", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxMovimiento() As Long
        'Procedimiento para extraer el código máximo para un nuevo movimiento
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxMovimiento = CLng(New SqlCommand("Select isnull(Max(I_MOV_ID), 0) from I_MOVIMIENTO", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Máximo código movimiento", Err)
        Err.Clear()
    End Function

    Public Function OperaMovimiento(ByVal BOO_FLAG As Boolean, ByVal MOV_FECHAMOV As DateTime, ByVal _
    MOV_FECHADOC As DateTime, ByVal MOV_DOC As String, ByVal MOV_PROVEE As String, ByVal MOV_TIPOMOV As String, _
    ByVal MOV_AUTORIZA As String, ByVal DET_MOVIMIENTO As DataTable, ByVal ENTREGADO As String, ByVal I_BOD_ID_2 As String, Optional ByRef MOV_ID As Long = 0, _
    Optional ByVal boo_modDetalle As Boolean = True, Optional ByVal RefMov As String = "", Optional ByVal mov_estado As Short = 1) As Single

        'Procedimiento para actualizar o ingresar los datos de una factura
        On Error GoTo MsgError
        Dim STR_SQL, STR_SQL1, str_fecha, str_sqlaux As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim dts_operacion As New DataSet()
        Dim dtr_fila As DataRow
        Dim int_indice, int_opera_cant As Integer
        OperaMovimiento = 0
        'Nuevo movimiento

        If BOO_FLAG Then MOV_ID = LeerMaxMovimiento() + 1
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        If BOO_FLAG Then

            STR_SQL = "Insert into I_MOVIMIENTO (I_MOV_ID, I_MOV_FECING, I_MOV_FECMOV, I_MOV_FECDOC, " & _
            "I_MOV_DOC, I_PRO_ID, I_TIM_ID, I_MOV_ESTADO, I_MOV_RESPONSABLE, I_MOV_REFMOV, invitado_id, I_MOV_ENTREGADO) Values (" & _
            MOV_ID & ", '" & Format(Now(), "dd/MM/yyyy hh:mm:ss") & "', '" & Format(MOV_FECHAMOV, "dd/MM/yyyy hh:mm:ss") & "', '" & Format(MOV_FECHADOC, "dd/MM/yyyy") & "', '" & _
            MOV_DOC & "', '" & Trim(Mid(DET_MOVIMIENTO.Rows(int_indice).Item(1), 1, 10)) & "', '" & Trim(Mid(MOV_TIPOMOV, 1, 15)) & "'," & mov_estado & ",'" & Trim(MOV_AUTORIZA) & "', '" & Trim(RefMov) & "'," & g_invitadoID & ",'" & Trim(ENTREGADO) & "')"

            If Trim(Mid(MOV_TIPOMOV, 1, 15)) = "TRF" Then
                STR_SQL1 = "Insert into I_MOVIMIENTO (I_MOV_ID, I_MOV_FECING, I_MOV_FECMOV, I_MOV_FECDOC, " & _
                "I_MOV_DOC, I_PRO_ID, I_TIM_ID, I_MOV_ESTADO, I_MOV_RESPONSABLE, I_MOV_REFMOV, invitado_id, I_MOV_ENTREGADO) Values (" & _
                MOV_ID + 1 & ", '" & Format(Now(), "dd/MM/yyyy hh:mm:ss") & "', '" & Format(MOV_FECHAMOV, "dd/MM/yyyy hh:mm:ss") & "', '" & Format(MOV_FECHADOC, "dd/MM/yyyy") & "', '" & _
                MOV_DOC & "', '" & Trim(Mid(DET_MOVIMIENTO.Rows(int_indice).Item(1), 1, 10)) & "', 'ING'," & mov_estado & ",'" & Trim(MOV_AUTORIZA) & "', '" & Trim(RefMov) & "'," & g_invitadoID & ",'" & Trim(ENTREGADO) & "')"
            End If

        Else
            STR_SQL = "Update I_MOVIMIENTO set " & _
            "I_MOV_FECMOV='" & Format(MOV_FECHAMOV, "dd/MM/yyyy hh:mm:ss") & "', " & _
            "I_MOV_FECDOC='" & Format(MOV_FECHADOC, "dd/MM/yyyy") & "', " & _
            "I_MOV_DOC='" & MOV_DOC & "', " & _
            "I_PRO_ID='" & Trim(Mid(DET_MOVIMIENTO.Rows(int_indice).Item(1), 1, 10)) & "', " & _
            "I_TIM_ID='" & Trim(Mid(MOV_TIPOMOV, 1, 15)) & "', " & _
            "I_MOV_RESPONSABLE='" & MOV_AUTORIZA & "', " & _
            "I_MOV_REFMOV='" & Trim(RefMov) & "', " & _
            "I_MOV_ESTADO= " & mov_estado & ", " & _
            "invitado_id = " & g_invitadoID & ", " & _
            "I_MOV_ENTREGADO = '" & Trim(ENTREGADO) & "'" & _
            " where I_MOV_ID = " & MOV_ID
        End If
        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        If Trim(Mid(MOV_TIPOMOV, 1, 15)) = "TRF" Then
            odbc_strsql = New SqlCommand(STR_SQL1, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
        End If

        g_opr_usuario.CargarTransaccion(g_str_login, "Operación de Movimiento Inventario", "")
        If boo_modDetalle Then
            'borra indistintamente el detalle del movimiento
            STR_SQL = "Delete from I_MOVIMIENTO_DETALLE where I_MOV_ID = " & MOV_ID
            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            'verificamos si la operación es egreso, entonces las cantidades son negativas
            If Trim(MOV_TIPOMOV.Substring(42, 10)) = "EGRESO" Then
                int_opera_cant = -1
            Else
                int_opera_cant = 1
            End If
            'en la tabla que devuelve tenemos los valores en las columnas
            '0 --> id de detalle movimiento     '1 --> producto
            '2 --> bodega                       '3 --> descripción del movimiento
            '4 --> cantidad                     '5 --> costo
            '6 --> fecha de vcto del producto ingresado
            Dim veces As Integer

            For int_indice = 0 To DET_MOVIMIENTO.Rows.Count - 1
                dtr_fila = DET_MOVIMIENTO.Rows.Item(int_indice)
                If Trim(dtr_fila(4).ToString) = "" Then dtr_fila(4) = " "
                If Trim(dtr_fila(7).ToString) = "" Or Trim(dtr_fila(7).ToString) = "NP" Then
                    str_sqlaux = ""
                    str_fecha = ""
                Else
                    str_sqlaux = "I_MOD_FECVEN, "

                    If Len(dtr_fila(1).ToString) = 3 Or Len(dtr_fila(1).ToString) = 4 Then
                        If Trim(MOV_TIPOMOV.Substring(42, 10)) = "EGRESO" Then
                            str_fecha = "'" & Format(Now(), "dd/MM/yyyy") & "', "
                        Else
                            str_fecha = "'" & Format(Now(), "dd/MM/yyyy") & "', "
                            'str_fecha = "'" & Format(CDate(dtr_fila(12).ToString), "dd/MM/yyyy") & "', "
                        End If
                    Else
                        str_fecha = "'" & Format(Now(), "dd/MM/yyyy") & "', "
                        'str_fecha = "'" & Format(CDate(dtr_fila(12).ToString), "dd/MM/yyyy") & "', "
                    End If
                End If

                If int_opera_cant = -1 Then dtr_fila(6) = 0
                Dim auxmov, auxmov1 As String
                If mov_estado = 2 Then
                    auxmov = ", I_MOD_ESTADO)"
                    auxmov1 = ",1"
                Else
                    auxmov = ")"
                    auxmov1 = ""
                End If

                If Len(dtr_fila(1).ToString) = 3 Or Len(dtr_fila(1).ToString) = 4 Then
                    If dtr_fila(0).ToString <> "0" Then
                        If Trim(MOV_TIPOMOV.Substring(42, 10)) = "EGRESO" Then
                            STR_SQL = "Insert into I_MOVIMIENTO_DETALLE (I_MOD_ID, I_MOV_ID, I_PRD_ID, I_MOD_CANTIDAD, I_BOD_ID, " & _
                            str_sqlaux & " I_MOD_COSTO, I_MOD_DESCRIPCION, I_MOD_LOTE, I_MOV_FSCO1, I_MOV_FSCO2, I_MOV_FSCO3 " & auxmov & _
                            "values (" & int_indice + 1 & ", " & MOV_ID & ", '" & Trim(Mid(dtr_fila(1), 1, 15)) & "', " & int_opera_cant * CDbl(dtr_fila(5)) & ", '" & _
                            Trim(Mid(I_BOD_ID_2, 1, 10)) & "', " & str_fecha & "0, 'DEVOLUCION TTO PACIENTE' ,'" & dtr_fila(6) & "','Si', 'Si', 'Si'" & auxmov1 & ")"
                        Else
                            STR_SQL = "Insert into I_MOVIMIENTO_DETALLE (I_MOD_ID, I_MOV_ID, I_PRD_ID, I_MOD_CANTIDAD, I_BOD_ID, " & _
                            str_sqlaux & " I_MOD_COSTO, I_MOD_DESCRIPCION, I_MOD_LOTE, I_MOV_FSCO1, I_MOV_FSCO2, I_MOV_FSCO3 " & auxmov & _
                            "values (" & int_indice + 1 & ", " & MOV_ID & ", '" & Trim(Mid(dtr_fila(1), 1, 15)) & "', " & int_opera_cant * CDbl(dtr_fila(5)) & ", '" & _
                            Trim(Mid(I_BOD_ID_2, 1, 10)) & "', " & str_fecha & "0, 'DEVOLUCION A BODEGA','" & dtr_fila(6) & "','Si', 'Si', 'Si'" & auxmov1 & ")"
                        End If

                    Else

                        STR_SQL = "Insert into I_MOVIMIENTO_DETALLE (I_MOD_ID, I_MOV_ID, I_PRD_ID, I_MOD_CANTIDAD, I_BOD_ID, " & _
                        str_sqlaux & " I_MOD_COSTO, I_MOD_DESCRIPCION, I_MOD_LOTE, I_MOV_FSCO1, I_MOV_FSCO2, I_MOV_FSCO3 " & auxmov & _
                        "values (" & int_indice + 1 & ", " & MOV_ID & ", '" & Trim(Mid(dtr_fila(1), 1, 15)) & "', " & int_opera_cant * CDbl(dtr_fila(5)) & ", '" & _
                        Trim(Mid(I_BOD_ID_2, 1, 10)) & "', " & str_fecha & "0, '" & dtr_fila(4) & "','" & dtr_fila(3) & "','" & dtr_fila(11) & "', '" & dtr_fila(12) & "', '" & dtr_fila(13) & "'" & auxmov1 & ")"


                    End If
                Else
                    STR_SQL = "Insert into I_MOVIMIENTO_DETALLE (I_MOD_ID, I_MOV_ID, I_PRD_ID, I_MOD_CANTIDAD, I_BOD_ID, " & _
                        str_sqlaux & " I_MOD_COSTO, I_MOD_DESCRIPCION, I_MOD_LOTE, I_MOV_FSCO1, I_MOV_FSCO2, I_MOV_FSCO3 " & auxmov & _
                        "values (" & int_indice + 1 & ", " & MOV_ID & ", '" & Trim(Mid(dtr_fila(1), 1, 15)) & "', " & int_opera_cant * CDbl(dtr_fila(5)) & ", '" & _
                        Trim(Mid(I_BOD_ID_2, 1, 10)) & "', " & str_fecha & "0, '" & dtr_fila(4) & "','" & dtr_fila(3) & "','" & dtr_fila(11) & "', '" & dtr_fila(12) & "', '" & dtr_fila(13) & "'" & auxmov1 & ")"

                End If
                If Trim(Mid(MOV_TIPOMOV, 1, 15)) = "TRF" Then
                    STR_SQL1 = "Insert into I_MOVIMIENTO_DETALLE (I_MOD_ID, I_MOV_ID, I_PRD_ID, I_MOD_CANTIDAD, I_BOD_ID, " & _
                    str_sqlaux & " I_MOD_COSTO, I_MOD_DESCRIPCION, I_MOD_LOTE, I_MOV_FSCO1, I_MOV_FSCO2, I_MOV_FSCO3 " & auxmov & _
                    "values (" & int_indice + 1 & ", " & MOV_ID + 1 & ", '" & Trim(Mid(dtr_fila(1), 1, 15)) & "', " & CDbl(dtr_fila(5)) & ", '" & _
                    Trim(Mid(dtr_fila(2), 1, 10)) & "', " & str_fecha & "0, '" & dtr_fila(4) & "','" & dtr_fila(3) & "','" & dtr_fila(11) & "', '" & dtr_fila(12) & "', '" & dtr_fila(13) & "'" & auxmov1 & ")"

                End If

                odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()

                If Trim(Mid(MOV_TIPOMOV, 1, 15)) = "TRF" Then
                    odbc_strsql = New SqlCommand(STR_SQL1, opr_conexion.conn_sql, odbc_trans)
                    odbc_strsql.ExecuteNonQuery()
                End If

                g_opr_usuario.CargarTransaccion(g_str_login, "Inserción de detalle movimiento inventario", "")
                If Len(dtr_fila(1).ToString) = 3 Or Len(dtr_fila(1).ToString) = 4 Then
                    Exit For
                Else

                End If
            Next
        End If
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        OperaMovimiento = 1
        MsgBox("Movimiento No. " & MOV_ID & " Registrado", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Operación de Movimiento Inventario", Err)
        Err.Clear()
    End Function

    Sub cambionumpedido(ByVal pedido As String, ByVal documen As String, ByVal numeropedido As String)
        'Procedimiento para anular un movimiento
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        Dim STR_SQL, STR_SQL1 As String
        Dim numpedido(), numpedido1(), pedido1() As String
        Dim ped() As String
        Dim int_i, int_j, int_x As Integer
        Dim i, j, x, y As Integer
        opr_conexion.sql_conectar()
        pedido1 = Split(pedido, ",")
        int_x = UBound(pedido1)
        numpedido = Split(numeropedido, "*,")
        If int_x >= 0 Then
            For x = 0 To (int_x)
                Dim str_aux As String = "where ("
                Dim str_aux1 As String = " and ("
                numpedido1 = Split(numpedido(x), ",")
                int_j = UBound(numpedido1)
                If int_j > 0 Then
                    For j = 1 To (int_j - 1)
                        If j = 1 Then
                            str_aux1 = str_aux1 & "i_movimiento_detalle.i_mod_id = '" & Trim(numpedido1(j)) & "'"
                        Else
                            str_aux1 = str_aux1 & " or i_movimiento_detalle.i_mod_id = '" & Trim(numpedido1(j)) & "' "
                        End If
                    Next
                    str_aux1 = str_aux1 & " ) "
                End If

                STR_SQL1 = "Update i_movimiento_detalle set i_mod_estado = 2 where i_mov_id = " & Trim(numpedido1(0))
                STR_SQL1 = STR_SQL1 & str_aux1
                '***************
                odc_operacion = New SqlCommand(STR_SQL1, opr_conexion.conn_sql)
                odc_operacion.ExecuteNonQuery()

                '***jva 16-06-04
                int_i = 1

                If int_i > 0 Then
                    For i = 0 To (int_i - 1)
                        'STR_SQL = "Update i_movimiento set i_mov_estado = 3, i_mov_doc = '" & Trim(numpedido(i)) & " - " & documen & "' where i_mov_doc LIKE '" & Trim(numpedido(i)) & "'"
                        STR_SQL = "Update i_movimiento set  i_mov_doc = '" & pedido1(x) & " - " & documen & "' where i_mov_doc LIKE '" & pedido1(x) & "'"
                        'STR_SQL = "Update i_movimiento_detalle set i_mod_estado = 2 "
                        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
                        odc_operacion.ExecuteNonQuery()
                    Next
                End If
            Next
        End If


        'STR_SQL = "Update i_movimiento set i_mov_estado = 3 "
        'STR_SQL = STR_SQL & str_aux
        'odc_operacion = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        'odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Cambio Pedido Movimiento", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Cambio número pedido", Err)
        Err.Clear()
    End Sub
    Sub Anularmovimiento(ByVal mov_id As String)
        'Procedimiento para anular un movimiento
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        'Actualiza el estado = 0 (0 = anulado , 1 = registrado)
        STR_SQL = "Update i_movimiento set i_mov_estado = 0 where i_mov_id = '" & mov_id & "'"
        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Anular Movimiento", "")
        MsgBox("El movimiento " & mov_id & " ha sido anulado", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, anular movimiento", Err)
        Err.Clear()
    End Sub

    Public Function LlenarRepMov(ByVal div_id As Byte, ByRef data As DataView, ByVal fi As Date, ByVal ff As Date)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        'Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        opr_Conexion.sql_conectar()
        Dim dts_operacion As New DataSet()
        'oda_operacion.SelectCommand = New SqlCommand("select A.I_MOV_ID,D.I_TIM_ID, A.I_PRD_ID, B.I_PRD_DESCRIPCION, C.I_BOD_ID, A.I_MOD_LOTE, A.I_MOD_DESCRIPCION, A.I_MOD_CANTIDAD, A.I_MOD_FECVEN, D.I_MOV_FECING, D.I_MOV_DOC FROM I_MOVIMIENTO_DETALLE A, I_PRODUCTO B, I_BODEGA C, I_MOVIMIENTO D WHERE A.I_PRD_ID = B.I_PRD_ID AND A.I_BOD_ID = C.I_BOD_ID AND A.I_MOV_ID = D.I_MOV_ID AND B.DIV_ID= " & div_id & " ORDER BY I_MOV_ID", opr_Conexion.conn_sql)
        'oda_operacion.SelectCommand = New SqlCommand("select A.I_MOV_ID,D.I_TIM_ID, A.I_PRD_ID, C.I_BOD_ID, A.I_MOD_LOTE, A.I_MOD_DESCRIPCION, A.I_MOD_CANTIDAD, D.I_MOV_FECDOC, A.I_MOD_FECVEN, D.I_MOV_DOC FROM I_MOVIMIENTO_DETALLE A, I_PRODUCTO B, I_BODEGA C, I_MOVIMIENTO D WHERE A.I_PRD_ID = B.I_PRD_ID AND A.I_BOD_ID = C.I_BOD_ID AND A.I_MOV_ID = D.I_MOV_ID AND B.DIV_ID= " & div_id & " and (D.I_MOV_FECDOC between '" & Format(fi, "dd/MM/yyyy") & "' and '" & Format(ff, "dd/MM/yyyy") & "') and D.I_MOV_ESTADO = 1 ORDER BY I_MOV_ID", opr_Conexion.conn_sql)
        oda_operacion.SelectCommand = New SqlCommand("select A.I_MOV_ID,D.I_TIM_ID, A.I_PRD_ID, B.I_PRD_DESCRIPCION, C.I_BOD_ID, A.I_MOD_LOTE, A.I_MOD_DESCRIPCION, A.I_MOD_CANTIDAD, D.I_MOV_FECDOC, A.I_MOD_FECVEN, D.I_MOV_DOC FROM I_MOVIMIENTO_DETALLE A, I_PRODUCTO B, I_BODEGA C, I_MOVIMIENTO D WHERE A.I_PRD_ID = B.I_PRD_ID AND A.I_BOD_ID = C.I_BOD_ID AND A.I_MOV_ID = D.I_MOV_ID AND B.DIV_ID= " & div_id & " and (D.I_MOV_FECDOC between '" & Format(fi, "dd/MM/yyyy") & "' and '" & Format(ff, "dd/MM/yyyy") & "') and (A.I_MOD_ESTADO = 0 or A.I_MOD_ESTADO = 1 ) and (D.I_MOV_ESTADO <> 0 and D.I_MOV_ESTADO <> 3) ORDER BY I_MOV_ID, I_PRD_ID", opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        opr_Conexion.sql_desconn()
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = dts_operacion.Tables("Registros")
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Productos", Err)
        Err.Clear()
    End Function

    Sub LlenarCombotipmov(ByRef cmb_tipomov As ComboBox)
        'funcion que me permite llenar un combo con los datos de una bodega
        On Error Resume Next
        Dim dts_tipmov As DataSet
        Dim dtr_fila As DataRow
        dts_tipmov = Leertipmov()
        cmb_tipomov.Items.Clear()
        For Each dtr_fila In dts_tipmov.Tables("Registros").Rows
            cmb_tipomov.Items.Add(dtr_fila("I_TIM_ID").ToString().PadRight(10) & " " & Mid(dtr_fila("I_TIM_DESCRIPCION").ToString(), 1, 25).PadRight(50))
        Next
        'cmb_tipomov.SelectedIndex = 0
    End Sub

    Public Function Leertipmov() As DataSet
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from i_tipo_movimiento", cls_operacion.conn_sql)
        Leertipmov = New DataSet()
        oda_operacion.Fill(Leertipmov, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Tipo Movimiento", Err)
        Err.Clear()
    End Function



    Function ProductoBodega(ByVal bod_id As String, ByVal prod_id As String, ByVal lote As String, ByVal valor As Double, ByVal sel_ped As Byte) As Double
        On Error GoTo MsgError
        'función para chequear el stock de un producto en una bodega hasta la fecha presente
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        Dim STR_SQL As String
        ProductoBodega = 0
        cls_operacion.sql_conectar()

        If sel_ped = 1 Then
            'STR_SQL = "select I_MOVIMIENTO_DETALLE.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) from I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID where I_MOVIMIENTO_DETALLE.I_PRD_ID='" & prod_id & "' and I_MOVIMIENTO_DETALLE.I_BOD_ID='" & bod_id & "' and I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '" & lote & "' AND (I_MOVIMIENTO.I_MOV_ESTADO = 1 ) group by I_PRD_ID, I_BOD_ID"
            STR_SQL = "select I_MOVIMIENTO_DETALLE.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) from I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID where I_MOVIMIENTO_DETALLE.I_PRD_ID='" & Trim(prod_id) & "' and I_MOVIMIENTO_DETALLE.I_BOD_ID='" & Trim(Mid(bod_id, 1, 10)) & "' and I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '" & lote & "' AND (I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 ) AND (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3) group by I_PRD_ID, I_BOD_ID"
        Else
            If (lote = "") Then
                STR_SQL = "select I_MOVIMIENTO_DETALLE.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) from I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID where I_MOVIMIENTO_DETALLE.I_PRD_ID='" & Trim(prod_id) & "' and I_MOVIMIENTO_DETALLE.I_BOD_ID='" & Trim(Mid(bod_id, 1, 10)) & "' and I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '" & lote & "' AND (I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 OR I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 ) AND (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3) group by I_PRD_ID, I_BOD_ID"
            Else

                STR_SQL = "select I_MOVIMIENTO_DETALLE.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) from I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID where I_MOVIMIENTO_DETALLE.I_PRD_ID='" & Trim(prod_id) & "' and I_MOVIMIENTO_DETALLE.I_BOD_ID='" & Trim(Mid(bod_id, 1, 10)) & "' and (I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 OR I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 ) AND (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3) group by I_PRD_ID, I_BOD_ID"
            End If
            'STR_SQL = "select I_MOVIMIENTO_DETALLE.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) from I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID where I_MOVIMIENTO_DETALLE.I_PRD_ID='" & prod_id & "' and I_MOVIMIENTO_DETALLE.I_BOD_ID='" & bod_id & "' and I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '" & lote & "' AND (I_MOVIMIENTO.I_MOV_ESTADO = 1 or I_MOVIMIENTO.I_MOV_ESTADO = 2) group by I_PRD_ID, I_BOD_ID"

        End If

        'STR_SQL = "select I_PRD_ID, I_BOD_ID, Sum(I_MOD_CANTIDAD) from I_MOVIMIENTO_DETALLE where I_PRD_ID='" & prod_id & "' and I_BOD_ID='" & bod_id & "' group by I_PRD_ID, I_BOD_ID"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        If dts_operacion.Tables(0).Rows.Count > 0 Then
            dtr_operacion = dts_operacion.Tables(0).Rows(0)
            If Not IsDBNull(dtr_operacion(2)) Then
                ProductoBodega = dtr_operacion(2) - valor
            End If
        Else
            ProductoBodega = -1
        End If

        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Consulta de Stock", Err)
        Err.Clear()
    End Function

    Function ProductoCaducado(ByVal bod_id As String, ByVal prod_id As String) As Boolean
        'funcion que me permite obtener si un determinado producto esta caducado o no
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        Dim STR_SQL As String
        ProductoCaducado = False
        cls_operacion.sql_conectar()
        STR_SQL = "SELECT I_PRODUCTO.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID, I_PRODUCTO.I_PRD_PERECIBLE, " & _
        "Min(I_MOVIMIENTO_DETALLE.I_MOD_FECVEN) FROM I_MOVIMIENTO_DETALLE " & _
        "INNER JOIN I_PRODUCTO ON I_MOVIMIENTO_DETALLE.I_PRD_ID = I_PRODUCTO.I_PRD_ID  " & _
        "WHERE(((I_PRODUCTO.I_PRD_ID) = '" & prod_id & "' ) And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & bod_id & "') " & _
        "And ((I_PRODUCTO.I_PRD_PERECIBLE) = 1)) " & _
        "group by I_PRODUCTO.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID, I_PRODUCTO.I_PRD_PERECIBLE"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        If dts_operacion.Tables(0).Rows.Count > 0 Then
            dtr_operacion = dts_operacion.Tables(0).Rows(0)
            If Not IsDBNull(dtr_operacion(3)) Then  '3 es el campo de la fecha minima
                If Format(CDate(dtr_operacion(3)), "dd/MM/yyyy") <= Format(Today, "dd/MM/yyyy") Then
                    ProductoCaducado = True
                End If
            Else
                'dtr_operacion(3) = "*"
            End If
        End If
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Consulta Productos Caducados", Err)
        Err.Clear()
    End Function

    Sub LlenarListaKardex(ByRef lstv_kardex As ListView, ByVal i_bod_id As String, ByVal i_prd_id As String, ByVal fi As Date, ByVal ff As Date)
        'funcion para llenar ne listview un kardex
        On Error GoTo MsgError
        lstv_kardex.Items.Clear()
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT i_mod_id as MovDet, a.i_mov_id as i_mov_id, i_mov_fecmov as Fecha, " & _
        "b.i_prd_id as prdCod, c.i_prd_descripcion as Producto, a.I_TIM_ID AS I_TIM_ID, d.I_TIM_descripcion as I_TIM_descripcion,  b.i_mod_descripcion as  i_mod_descripcion, " & _
        "' ' as I_CANTIDAD, ' ' as I_VAL_UNI, ' ' as I_VAL_TOTAL, ' ' as E_CANTIDAD, ' ' as E_VAL_UNI," & _
        "' ' as E_VAL_TOTAL, ' ' as T_CANTIDAD, ' ' as T_VAL_UNI, ' ' as T_VAL_TOTAL " & _
        "FROM I_MOVIMIENTO a, I_MOVIMIENTO_DETALLE b, I_PRODUCTO c, I_TIPO_MOVIMIENTO d " & _
        "WHERE (a.i_tim_id = d.i_tim_id) and (b.i_prd_id = c.i_prd_id) and ( (a.i_mov_id = b.i_mov_id) " & _
        "and (b.I_BOD_ID = '" & i_bod_id & "') and (b.i_prd_id = '" & i_prd_id & "')" & _
        " and ((a.i_mov_fecmov) Between '" & fi & "' and '" & ff & "')) ORDER BY i_mov_fecmov ASC ", cls_operacion.conn_sql)
        Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        oda_operacion.Fill(dts_operacion, "Registros")
        Dim int_i As Integer = 0
        For Each dtr_operacion In dts_operacion.Tables("Registros").Rows
            Dim dts_operacion2 As New DataSet()
            Dim dtr_operacion2 As DataRow
            oda_operacion.SelectCommand = New SqlCommand("SELECT a.I_MOD_CANTIDAD, a.I_MOD_COSTO, b.I_TIM_TIPO " & _
                "FROM I_TIPO_MOVIMIENTO AS b INNER JOIN (I_MOVIMIENTO AS c INNER JOIN I_MOVIMIENTO_DETALLE AS a ON c.I_MOV_ID = a.I_MOV_ID) " & _
                "ON b.I_TIM_ID = c.I_TIM_ID WHERE (((a.I_MOD_ID)=" & dtr_operacion("MovDet") & ") AND ((a.I_MOV_ID)= " & dtr_operacion("i_mov_id") & "))", cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion2, "Registros")
            Dim bdl_cantidad As Double = dtr_operacion(0)
            For Each dtr_operacion2 In dts_operacion2.Tables("Registros").Rows
                If bdl_cantidad <= 0 Then
                    Exit For
                End If
                If Not IsDBNull(dtr_operacion2(0)) Then
                    If Format(dtr_operacion2(0), "MM/dd/yyyy") <= Format(Today, "MM/dd/yyyy") Or Format(dtr_operacion2(0), "MM/dd/yyyy") <= Format((DateAdd(DateInterval.Day, 5, Today)), "MM/dd/yyyy") Then
                        lstv_kardex.Items.Add(dtr_operacion(1).ToString())
                        If bdl_cantidad >= dtr_operacion2(1) Then
                            lstv_kardex.Items(int_i).SubItems.Add(dtr_operacion2(1).ToString())
                        Else
                            lstv_kardex.Items(int_i).SubItems.Add(bdl_cantidad)
                        End If
                        lstv_kardex.Items(int_i).SubItems.Add(dtr_operacion(2).ToString())
                        lstv_kardex.Items(int_i).SubItems.Add(Format(CDate(dtr_operacion2(0).ToString), "MM/dd/yyyy"))
                        lstv_kardex.Items(int_i).SubItems.Add(dtr_operacion2(2).ToString())
                    End If
                    bdl_cantidad -= dtr_operacion2(1)
                    If bdl_cantidad <= 0 Then
                        Exit For
                    End If
                End If
            Next
        Next
        cls_operacion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Llenar Lista Caducado", Err)
        Err.Clear()
    End Sub

    Public Function Cons_Movim_Kardex(ByVal i_prd_id As String, ByVal i_bod_id As String, ByVal fi As Date, ByVal ff As Date) As DataSet
        'Función para consultar los movimientos que ha tenido un producto determinado
        'en una bodega, en un tiempo determinado.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        STR_SQL = "SELECT I_MOVIMIENTO.I_MOV_ID, I_MOVIMIENTO.I_MOV_FECMOV, I_MOVIMIENTO_DETALLE.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID " & _
        "FROM I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID" & _
        "GROUP BY I_MOVIMIENTO.I_MOV_ID, I_MOVIMIENTO.I_MOV_FECMOV, I_MOVIMIENTO_DETALLE.I_PRD_ID, I_MOVIMIENTO_DETALLE.I_BOD_ID" & _
        "HAVING (((I_MOVIMIENTO.I_MOV_FECMOV) Between #1/1/2000# And #1/1/2003#) AND ((I_MOVIMIENTO_DETALLE.I_PRD_ID)='" & i_prd_id & "') AND ((I_MOVIMIENTO_DETALLE.I_BOD_ID)= '" & i_bod_id & "')) " & _
        "ORDER BY I_MOV_FECMOV ASC"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        Cons_Movim_Kardex = New DataSet()
        oda_operacion.Fill(Cons_Movim_Kardex, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transacción solicitada, movimiento, Cons_Detalles_Kardex", Err)
        Err.Clear()
    End Function

    Public Function leernpedido(ByVal dato As String, ByVal nped As Integer) As DataSet
        'JVA 10-03-2004
        'Procedimiento para los datos de las notas de pedido
        On Error GoTo MsgError
        Dim int_i As Integer
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim pedido() As String
        Dim STR_SQL As String
        Dim str_aux As String = "and ("

        pedido = Split(dato, ",")
        int_i = UBound(pedido)
        Dim i As Integer
        If int_i > 0 Then
            For i = 0 To (int_i - 1)
                'If i = 0 Then
                '    str_aux = str_aux & "i_movimiento.i_mov_doc LIKE '" & Trim(pedido(i)) & "'"
                'Else
                '    str_aux = str_aux & " or i_movimiento.i_mov_doc LIKE '" & Trim(pedido(i)) & "' "
                'End If
                If i = 0 Then
                    str_aux = str_aux & "i_movimiento_detalle.i_mod_id = '" & Trim(pedido(i)) & "'"
                Else
                    str_aux = str_aux & " or i_movimiento_detalle.i_mod_id = '" & Trim(pedido(i)) & "' "
                End If
            Next
            str_aux = str_aux & " ) "
        End If
        opr_conexion.sql_conectar()
        'STR_SQL = "select i_movimiento_detalle.* from i_movimiento_detalle, i_movimiento where i_movimiento.i_mov_id = i_movimiento_detalle.i_mov_id "
        STR_SQL = "SELECT i_movimiento.I_MOV_ID, i_movimiento.I_MOV_FECMOV, i_movimiento.I_MOV_FECDOC, " & _
        "i_movimiento.I_MOV_DOC, i_movimiento.I_PRO_ID, i_movimiento.I_TIM_ID, i_movimiento.I_MOV_ESTADO, " & _
        "i_movimiento.I_MOV_RESPONSABLE, i_movimiento_detalle.I_MOD_ID, i_movimiento_detalle.I_PRD_ID, " & _
        "i_movimiento_detalle.I_MOD_CANTIDAD, i_movimiento_detalle.I_MOD_COSTO, i_movimiento_detalle.I_BOD_ID, " & _
        "i_movimiento_detalle.I_MOD_FECVEN, i_movimiento_detalle.I_MOD_DESCRIPCION, i_producto.I_PRD_DESCRIPCION, " & _
        "i_bodega.I_BOD_DESCRIPCION, i_movimiento.I_MOV_REFMOV,i_movimiento_detalle.I_MOD_LOTE FROM (i_bodega INNER JOIN (i_movimiento INNER JOIN i_movimiento_detalle ON " & _
        "i_movimiento.I_MOV_ID = i_movimiento_detalle.I_MOV_ID) ON i_bodega.I_BOD_ID = i_movimiento_detalle.I_BOD_ID) " & _
        "INNER JOIN i_producto ON i_movimiento_detalle.I_PRD_ID = i_producto.I_PRD_ID WHERE i_movimiento.I_MOV_ID = " & nped & "  and i_movimiento_detalle.i_mod_estado = 1 "
        '"INNER JOIN i_producto ON i_movimiento_detalle.I_PRD_ID = i_producto.I_PRD_ID WHERE i_movimiento.I_MOV_ID = i_movimiento_detalle.I_MOV_ID"
        STR_SQL = STR_SQL & " " & str_aux
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        leernpedido = New DataSet()
        oda_operacion.Fill(leernpedido, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, consulta de notas de pedido", Err)
        Err.Clear()
    End Function
End Class
