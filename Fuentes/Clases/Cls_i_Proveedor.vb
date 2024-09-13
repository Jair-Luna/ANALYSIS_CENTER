'*************************************************************************
' Nombre:   Cls_Proveedor
' Tipo de Archivo: clase
' Descripción:  Clase para la manipulacion de proveedores
' Autores:  RFN
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data
Imports System.Data.SqlClient



Public Class Cls_i_Proveedor

    Public Function LeerProveedor() As DataSet
        'Función para consultar los proveedor
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT * FROM I_PROVEEDOR order by I_PRO_NOMBRE", opr_Conexion.conn_sql)
        LeerProveedor = New DataSet()
        oda_operacion.Fill(LeerProveedor, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Proveedor", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxIdProv() As Integer
        'funcion que devuelve el numero máximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim anio As Short
        Dim fec_ini, fec_fin As Date
        Dim str_sql As String

        str_sql = "Select isnull(Max(I_PRO_ID),0) as codigo from i_proveedor;"
        opr_conexion.sql_conectar()

        LeerMaxIdProv = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdProv >= 0 Then
            LeerMaxIdProv = LeerMaxIdProv + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Máximo Codigo", Err)
        Err.Clear()
    End Function


    Public Function BuscarProveedor(ByVal i_pro_id As String) As Boolean
        'Función para consultar si existe el código de un proveedor antes de insertar otra igual 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from i_proveedor where i_pro_id = '" & i_pro_id & "'", opr_Conexion.conn_sql)
        Dim dts_prd As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_prd, "Registros")
        For Each dtr_fila In dts_prd.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarProveedor = False
            Else
                BuscarProveedor = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Buscar Proveedor", Err)
        Err.Clear()
    End Function

    Public Sub GuardarProveedor(ByVal i_pro_id As String, ByVal i_pro_nombre As String, _
                                  ByVal i_pro_direccion As String, ByVal i_pro_fono As String, _
                                  ByVal i_pro_fax As String, ByVal i_pro_mail As String, _
                                  ByVal i_pro_rep_nombre As String, ByVal i_pro_rep_fono As String, _
                                  ByVal i_pro_rep_cell As String)
        'Procedimiento para la insertar un registro en la tabla I_PROVEEDOR
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into I_PROVEEDOR values ('" & i_pro_id & "', '" & _
            i_pro_nombre & "', '" & i_pro_direccion & "', '" & i_pro_fono & "', '" & i_pro_fax & "', '" & i_pro_mail & "', '" & i_pro_rep_nombre & "', '" & i_pro_rep_fono & "', '" & i_pro_rep_cell & "')"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra de la transacción realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Proveedor", "", g_sng_user)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Guardar Proveedor", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarProveedor(ByVal i_pro_id As String)
        'Procedimiento para la eliminar un proveedor
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Delete from I_PROVEEDOR where i_pro_id = '" & i_pro_id & "'", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra de la transacción realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Proveedor", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Eliminar Proveedor", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarProveedor(ByVal i_pro_id As String, ByVal i_pro_nombre As String, _
                                  ByVal i_pro_direccion As String, ByVal i_pro_fono As String, _
                                  ByVal i_pro_fax As String, ByVal i_pro_mail As String, _
                                  ByVal i_pro_rep_nombre As String, ByVal i_pro_rep_fono As String, _
                                  ByVal i_pro_rep_cell As String, ByVal i_pro_id_ant As String)
        'Procedimiento para la actualizar un registro en la tabla I_PROVEEDOR
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "Update I_PROVEEDOR set i_pro_id = '" & i_pro_id & "' , i_pro_nombre = '" & _
        i_pro_nombre & "', i_pro_direccion = '" & i_pro_direccion & "', i_pro_fono = '" & _
        i_pro_fono & "', i_pro_fax = '" & i_pro_fax & "', i_pro_mail = '" & i_pro_mail & "', i_pro_rep_nombre = '" & _
        i_pro_rep_nombre & "', i_pro_rep_fono = '" & i_pro_rep_fono & "', i_pro_rep_cell = '" & _
        i_pro_rep_cell & "' where i_pro_id = '" & i_pro_id_ant & "'"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos actualizados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transacción realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza Proveedor", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Actualizar Proveedor", Err)
        Err.Clear()
    End Sub
End Class
