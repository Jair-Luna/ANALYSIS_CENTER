'*************************************************************************
' Nombre:   Cls_Ciudad
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla Ciudad 
' Autores:  RFN 
' Fecha de Creaci�n: Julio del 2002
' Autores:  RFN
' Ultima Modificaci�n: 17/07/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient

Public Class Cls_Ciudad

    Public Function LeerCiudad(ByVal prov_id As Integer) As DataSet
        'Funcion para consultar todas las ciudades 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "SELECT p.PROV_ID, PROV_NOMBRE, CIU_ID, CIU_NOMBRE " & _
                                "from provincia as p, CIUDAD as c " & _
                                "where p.PROV_ID = c.PROV_ID and p.PROV_ID = " & prov_id & " order by c.CIU_NOMBRE "

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerCiudad = New DataSet()
        oda_operacion.Fill(LeerCiudad, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Ciudad", Err)
        Err.Clear()
    End Function


    Public Function LeerProvincia() As DataSet
        'Funcion para consultar todas las ciudades 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select * from PROVINCIA order by PROV_nombre;", opr_Conexion.conn_sql)
        LeerProvincia = New DataSet()
        oda_operacion.Fill(LeerProvincia, "RegistrosProv")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Provincia", Err)
        Err.Clear()
    End Function

    Public Function LeerUnaCiudad(ByVal ciu_cod As Integer) As DataSet
        'Funci�n para consultar todas las ciudades 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from ciudad where ciu_codigo = " & ciu_cod & "", opr_Conexion.conn_sql)
        LeerUnaCiudad = New DataSet()
        oda_operacion.Fill(LeerUnaCiudad, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Ciudad", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodCiudad() As Short
        'Funcion para la consultar el c�digo m�ximo de la tabla ciudad
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodCiudad = CInt(New SqlCommand("select isnull(max(ciu_id),0) from CIUDAD ", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodCiudad", Err)
        Err.Clear()
    End Function

    Public Sub GuardarCiudad(ByVal ciu_id As Integer, ByVal ciu_nombre As String)
        'Procedimiento para la insertar un registro en la tabla CIUDAD
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into CIUDAD values (" & ciu_id & ", '" & ciu_nombre & "')"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nueva Ciudad", "Ciudad=" & ciu_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, cls_Ciudad-GuardarCiudad", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarCiudad(ByVal ciu_id As Integer, ByVal ciu_nombre As String, ByVal prov_id As Integer)
        'Procedimiento para la actualizar un registro en la tabla CIUDAD
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "update CIUDAD set ciu_nombre = '" & ciu_nombre & "', prov_id = " & prov_id & " where ciu_id = " & ciu_id & ""
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Ciudad", "Cuidad=" & ciu_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Ciudad", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarCiudad(ByVal ciu_id As Integer)
        'Procedimiento para la eliminar un registro en la tabla CIUDAD
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("delete from CIUDAD where ciu_id = " & ciu_id & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion solicitada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Ciudad", "Ciudad=" & ciu_id & "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Ciudad", Err)
        Err.Clear()
    End Sub

    Public Function BuscarCiudad(ByVal ciu_nombre As String) As Boolean
        'Funci�n para consultar si existe el nombre de una ciudad antes de insertar otra igual 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from ciudad where ciu_nombre = '" & ciu_nombre & "'", opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_act, "Registros")
        For Each dtr_fila In dts_act.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarCiudad = False
            Else
                BuscarCiudad = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar Ciudad", Err)
        Err.Clear()
    End Function

    Sub LlenarComboCiudad(ByRef cmb_ciudad As ComboBox, ByVal prov_id As Integer)
        On Error Resume Next
        'Para llenar el combo de ciudad
        Dim dts_ciudad As DataSet
        Dim dtr_fila As DataRow
        dts_ciudad.Clear()
        dts_ciudad = LeerCiudad(prov_id)
        cmb_ciudad.Items.Clear()
        For Each dtr_fila In dts_ciudad.Tables("Registros").Rows
            cmb_ciudad.Items.Add(dtr_fila("ciu_nombre").ToString().PadRight(100) & dtr_fila("ciu_id").ToString().PadRight(10))
        Next
        cmb_ciudad.SelectedIndex = 0
        
    End Sub

    Sub LlenarComboProvincia(ByRef cmb_provincia As ComboBox)
        On Error Resume Next
        'Para llenar el combo de ciudad
        Dim dts_provincia As DataSet
        Dim dtr_fila As DataRow
        dts_provincia = LeerProvincia()
        cmb_provincia.Items.Clear()
        For Each dtr_fila In dts_provincia.Tables("RegistrosProv").Rows
            cmb_provincia.Items.Add(dtr_fila("prov_nombre").ToString().PadRight(100) & dtr_fila("prov_id").ToString().PadRight(10))
        Next
        cmb_provincia.SelectedIndex = 0


    End Sub

End Class
