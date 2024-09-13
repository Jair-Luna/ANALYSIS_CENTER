'*************************************************************************
' Nombre:   Cls_sistema
' Tipo de Archivo: clase
' Descripcin:  Clase que almacena funciones propias del sistema para mantener estandares
' Autores:  RFN
' Fecha de Creaci�n: Julio del 2005
' Autores:  RFN
' Ultima Modificaci�n: 19/07/2005
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data.SqlClient


Public Class Cls_sistema

    Public Function ahora() As Date
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        STR_SQL = "select getdate();"
        opr_Conexion.sql_conectar()
        Dim oda_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_Conexion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ahora = oda_operacion.GetValue(0).ToString
        End While
        oda_operacion.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Ahora", Err)
        Err.Clear()
    End Function

    Public Function auditoria(ByVal ped_id As Long, ByVal tes_id As Long, ByVal mensaje As Short)
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim tipo As String
        Dim fecha As Date = Format(Now, "dd/MM/yyyy")
        Dim hora As Date = Format(Now, "HH:mm:ss")
        Dim estado As String
        Dim usu_id As String = consulta_usuario(g_str_login)
        Dim strans As SqlTransaction
        Select Case mensaje
            Case 1
                tipo = "Importacion"
                estado = "1"
            Case 2
                tipo = "Ingreso de Resultados"
                estado = "2"
            Case 3
                tipo = "Validacion de Resultados"
                estado = "3"
            Case 4
                tipo = "Envio de Resultados"
                estado = "4"
            Case 5
                tipo = "No se Validaron Resultados"
                estado = "5"
            Case 6
                tipo = "Envio de Cultivos"
                estado = "6"
            Case 7
                tipo = "Anulacion de Ordenes"
                estado = "7"
            Case 8
                tipo = "Pedidos Nuevos"
                estado = "8"
            Case 9
                tipo = "Modificacion de Pedidos"
                estado = "9"
            Case 10
                tipo = "Reapertura de Ordenes"
                estado = 10
            Case 11
                tipo = "Procesado/Para Envio"
                estado = 11
        End Select
        Try
            opr_conexion.sql_conectar()
            strans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
            If tes_id <> 0 Then
                str_sql = "insert into auditoria(ped_id, tes_id, usu_id, fecha, hora, tipo, estado) " & _
                                      "values('" & ped_id & "', '" & tes_id & "', '" & usu_id & "', '" & Format(fecha, "dd/MM/yyyy") & "', '" & hora & "', '" & tipo & "', '" & estado & "' ) "
                Dim oDc As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql, strans)
                oDc.ExecuteNonQuery()
            Else
                str_sql = "insert into auditoria(ped_id, usu_id, fecha, hora, tipo, estado) " & _
                                      "values('" & ped_id & "', '" & usu_id & "', '" & Format(fecha, "dd/MM/yyyy HH:mm") & "', '" & hora & "', '" & tipo & "', '" & estado & "' ) "
                Dim oDc As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql, strans)
                oDc.ExecuteNonQuery()
            End If
            strans.Commit()
        Catch
            MsgBox("No se pudo grabar el registro de auditoria. ", MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            strans.Rollback()
            Err.Clear()
        Finally
            opr_conexion.sql_desconn()
        End Try
    End Function

    Public Function consulta_usuario(ByVal usu_login As String) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String
            str_sql = "select usu_id from usuario where usu_login='" & usu_login & "'"
            opr_conexion.sql_conectar()
            Dim odr As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
            While odr.Read
                consulta_usuario = odr.GetValue(0).ToString
            End While
            opr_conexion.sql_desconn()
        Catch
            MsgBox("No se pudo consultar el codigo del usuario. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function


    Public Function sTiempo(ByVal dInicio As Date, ByVal dFin As Date) As String
        sTiempo = Str((DateDiff("s", dInicio, dFin) \ 86400) Mod 365) & " días,"
        sTiempo = sTiempo & Str((DateDiff("s", dInicio, dFin) \ 3600) Mod 24) & " horas,"
        sTiempo = sTiempo & Str((DateDiff("s", dInicio, dFin) \ 60) Mod 60) & " minutos,"
        sTiempo = sTiempo & Str(DateDiff("s", dInicio, dFin) Mod 60) & " segundos"
    End Function

End Class
