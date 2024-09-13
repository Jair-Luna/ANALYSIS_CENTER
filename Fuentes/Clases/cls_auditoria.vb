'*************************************************************************
' Nombre:   Cls_Auditoria
' Tipo de Archivo: clase
' Descripcin:  Clase para operar transacciones de auditoria
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2007
' Autores:  RFN
' Ultima Modificaci�n: 27/08/2007
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class cls_auditoria

    Public Function GuardaCodigo(ByVal codigo_encriptado As String) As Boolean
        'funcion que nos permite guardar los datos de una nueva bonificacion
        On Error GoTo MsgError
        GuardaCodigo = False
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "update codigo set COD_NUM = '" & codigo_encriptado & "' , Cod_fecValida = GETDATE() where COD_ID = 1 and Cod_Licencia <> '';"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        If odc_palabra.ExecuteNonQuery() Then
            GuardaCodigo = True
        Else
            GuardaCodigo = False
        End If
        cls_operacion.sql_desconn()
        'g_opr_usuario.CargarTransaccion(g_str_login, "Guardar antibiotico", "ANTIBIOTICO=" & antibiotico, g_sng_user, "", "", "")
        'MsgBox("El antibiotico fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar antibiotico", Err)
        Err.Clear()
        GuardaCodigo = False
    End Function

    Public Sub RegistraOperacion(ByVal desc As String, ByVal user As String, _
                                  ByVal invitado As String, ByVal operacion As String)
        'Procedimiento para la insertar un registro en la tabla AREA
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Insert into auditoria (aud_descripcion, aud_user, aud_invitado, aud_sql, aud_fecing) values ('" & desc & "', '" & _
            user & "', '" & invitado & "', '" & operacion & "', '" & Format(Now, "dd/MM/yyyy HH:mm") & "' )"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Registra Operacion AUDIT", Err)
        Err.Clear()
    End Sub

    Public Function LeerClaveAutorizacion(ByVal nivel As Short) As String
        'funci�n para leer la clave de autorizacion para realizar una operacion restringida.
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Select isnull(psw_contrasenia,'-1') from pswd where psw_id=" & nivel
        On Error GoTo MsgError

        opr_conexion.sql_conectar()
        LeerClaveAutorizacion = ""
        LeerClaveAutorizacion = CStr(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerCalveAutorizacion ", Err)
        Err.Clear()
    End Function


End Class
