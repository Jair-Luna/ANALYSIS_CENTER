'*************************************************************************
' Nombre:   Cls_Conexin
' Tipo de Archivo: clase
' Descripci�n:  Clase para la conexi�n a la base de datos en Access
' Autores:  RFN 
' Fecha de Creaci�n: Julio del 2012
' Autores Modificaciones: RFN
' Ultima Modificaci�n: 16/07/2012
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient

Public Class Cls_Conexion

    Public Conn_BD As OleDbConnection
    Public conn_odbc As OdbcConnection
    'Public con_sql As SqlConnection
    Public conn_sql As SqlConnection
    Public conn_sql_pdf As SqlConnection


    Public Sub sql_conectar()
        'Procedimiento para la conexi�n a la base de datos SQL
        On Error GoTo MsgError
        If IsNothing(conn_sql) Then
            conn_sql = New SqlConnection(g_str_conexion_SQL)
            conn_sql.Open()
        Else
            If conn_sql.State <> ConnectionState.Open Then
                conn_sql = New SqlConnection(g_str_conexion_SQL)
                conn_sql.Open()
            End If
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos SQL. Consulte con soporte tecnico", Err)
        Err.Clear()
    End Sub


    Public Sub sql_conectarpdf()
        'Procedimiento para la conexi�n a la base de datos SQL
        On Error GoTo MsgError
        If IsNothing(conn_sql_pdf) Then
            conn_sql_pdf = New SqlConnection(g_str_conexion_SQL_PDF)
            conn_sql_pdf.Open()
        Else
            If conn_sql_pdf.State <> ConnectionState.Open Then
                conn_sql_pdf = New SqlConnection(g_str_conexion_SQL_PDF)
                conn_sql_pdf.Open()
            End If
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos SQL. Consulte con soporte tecnico", Err)
        Err.Clear()
    End Sub


    Public Sub conectar()
        'Procedimiento para la conexi�n a la base de datos
        On Error GoTo MsgError
        If IsNothing(Conn_BD) Then
            Conn_BD = New OleDbConnection(g_str_conexion)
            Conn_BD.Open()
        Else
            If Conn_BD.State <> ConnectionState.Open Then
                Conn_BD = New OleDbConnection(g_str_conexion)
                Conn_BD.Open()
            End If
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos. Consulte con soporte tecnico", Err)
        Err.Clear()
    End Sub

    Public Sub desconectar()
        'Procedimiento para finalizar la conexi�n a la base de datos 
        On Error Resume Next
        Conn_BD.Close()
        Conn_BD = Nothing
    End Sub


    Sub sql_conn()
        'Procedimiento para la conexi�n a la base de datos
        On Error GoTo MsgError
        Dim odbc_strsql As SqlCommand
        conn_sql = New SqlConnection()
        conn_sql.ConnectionString = g_str_conexion_SQL
        conn_sql = New SqlConnection(conn_sql.ConnectionString)
        conn_sql.Open()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos. Consulte con soporte tecnico", Err)
        Err.Clear()
    End Sub

    Sub odbc_conn()
        'Procedimiento para la conexi�n a la base de datos
        On Error GoTo MsgError
        Dim odbc_strsql As SqlCommand
        conn_odbc = New OdbcConnection()
        conn_odbc.ConnectionString = g_str_conexion_odbc
        conn_odbc = New OdbcConnection(conn_odbc.ConnectionString)
        conn_odbc.Open()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos. Consulte con soporte tecnico", Err)
        Err.Clear()
    End Sub

    Sub odbc_desconn()
        On Error Resume Next
        conn_odbc.Close()
        conn_odbc = Nothing
    End Sub

    Sub sql_desconn()
        On Error Resume Next
        conn_sql.Close()
        conn_sql = Nothing
    End Sub

    Sub sql_desconn_pdf()
        On Error Resume Next
        conn_sql_pdf.Close()
        conn_sql_pdf = Nothing
    End Sub
End Class
