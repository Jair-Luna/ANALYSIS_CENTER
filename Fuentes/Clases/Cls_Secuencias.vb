'*************************************************************************
' Nombre:   Cls_Agenda
' Tipo de Archivo: Clase
' Descripción:  Clase para manipular los archivos de respuestas bajados de los analizadores (SNI)
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.IO
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Secuencias
    Dim opr_conexion As New Cls_Conexion()



    Sub LlenarGridSecuencias(ByRef data As DataView, ByVal estado As Byte)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerSecuencias(estado).Tables("Registros")
    End Sub


    Public Function LeerSecuencias(ByVal estado As Byte) As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim str_sql As String = "select secuencias.sec_id, secuencias.sec_nombre, secuencias.sec_desde, secuencias.sec_hasta, secuencias.sec_eliminar, secuencias.sec_unidad from secuencias where secuencias.sec_estado = " & estado & ";"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerSecuencias = New DataSet("SECUENCIAS")
        dt_operacion.Fill(LeerSecuencias, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer secuencias", Err)
        Err.Clear()
    End Function

    Public Function ValidaChoque(ByVal numero As Integer, ByVal dv_Sec As DataView, ByRef secuencia As String) As Boolean
        Dim x As Integer = 0
        Dim y As Integer = 0
        ValidaChoque = False

        For Each rowView As DataRowView In dv_Sec
            Dim row As DataRow = rowView.Row
            secuencia = row("sec_nombre").ToString
            x = row("sec_desde").ToString
            y = row("sec_hasta").ToString
            If numero >= x And numero <= y Then
                ValidaChoque = True
                Exit Function
            End If
        Next

    End Function


    Public Function BuscarSecuencia(ByVal nombre As String) As Boolean
        'funcion que nos permite ferificar si existe una boniicacion especifica se recibe
        ' le nombre de la bonificacion y se debuelve on boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from secuencias where sec_nombre = '" & nombre & "';", opr_Conexion.conn_sql)
        Dim dts_palabra As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_palabra, "Registros")
        For Each dtr_fila In dts_palabra.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarSecuencia = False
            Else
                BuscarSecuencia = True
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Buscar secuencia", Err)
        Err.Clear()
    End Function


    Public Sub GuardarSecuencia(ByVal sec_id As Integer, ByVal nombre As String, ByVal incio As Integer, ByVal fin As Integer, ByVal unidad As String)
        'funcion que nos permite guardar los datos de una nueva bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "insert into secuencias (SEC_ID,SEC_NOMBRE, SEC_DESDE, SEC_HASTA, SEC_ELIMINAR, SEC_UNIDAD) VALUES (" & sec_id & ", '" & nombre & "', " & incio & ", " & fin & ",1, '" & unidad & "')"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Guardar secuencia", "SECUENCIA=" & nombre & "/" & incio & "/" & fin, g_sng_user, "", "", "")
        'MsgBox("La secuencia fue almacenada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Guardar secuencia", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarListaPrecio(ByVal nombre As String, ByVal nombreOld As String, ByVal porcentaje As Double)
        'funcion que nos permite actualizar los datos de las bonificaciones
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "update lista_precio set con_nombre ='" & nombre & "', lip_precio = (lip_precio * " & porcentaje & ") where con_nombre = '" & nombreOld & "';"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar LISTA PRECIO=" & nombre, "", g_sng_user, "", "", "")
        MsgBox("La Secuencia fue modificada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Actualizar LISTA PRECIO", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarConvenioPedido(ByVal nombre As String, ByVal nombreOld As String)
        'funcion que nos permite actualizar los datos de las bonificaciones
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "update pedido set ped_tipo = '" & nombre & "', con_nombre = '" & nombre & "' where con_nombre = '" & nombreOld & "';"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar pedido en convenio =" & nombre, "", g_sng_user, "", "", "")
        'MsgBox("La Secuencia fue modificada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Actualizar LISTA PRECIO", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarSecuencia(ByVal nombre As String, ByVal inicio As Integer, ByVal fin As Integer, ByVal secId As Integer)
        'funcion que nos permite actualizar los datos de las bonificaciones
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "update secuencias set sec_nombre ='" & nombre & "', sec_desde = " & inicio & ", sec_hasta = " & fin & " where sec_id = " & secId & ";"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Secuencia", "SECUENCIA=" & nombre & "/" & inicio & "/" & fin, g_sng_user, "", "", "")
        ' MsgBox("La Secuancia fue modificada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Actualizar palabra", Err)
        Err.Clear()
    End Sub

    Public Function EliminaSecuencia(ByVal sec_nombre As String) As Boolean
        'funcion que nos permite la eliminacion de una bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        EliminaSecuencia = False
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from secuencias where SEC_NOMBRE = '" & sec_nombre & "' and sec_eliminar = 1;"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        EliminaSecuencia = True
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Secuencia", "SECUENCIA=" & sec_nombre, g_sng_user, "", "", "")
        MsgBox("El secuencia fue eliminado", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Eliminar Antibiotico", Err)
        EliminaSecuencia = False
        Err.Clear()
    End Function


End Class
