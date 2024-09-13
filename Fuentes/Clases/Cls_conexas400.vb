' Tipo de Archivo: clase
' Descripción:  Clase para la conexión a la base de datos con AS-400
' Autores:  RFN
' Fecha de Creación: Diciembre - 2005
' Autores Modificaciones: José Anda
' Ultima Modificación: 12/12/2005
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Data.Odbc
Imports IBM.Data.DB2.iSeries

Public Class Cls_conexas400
    'Public g_ASprovider As String
    'Public g_ASuser As String
    'Public g_ASpassword As String
    'Public Conn_BD As SqlConnection
    Public oConexion As OleDbConnection

    'Usando el Proveedor Nativo de AS400 - iDB2 iSeries
    Public Function IBM_ConectarAS()
        'Dim cn As iDB2Connection
        'Dim oCon As String
        'Try
        '    cn = New iDB2Connection(g_str_idb2)
        '    cn.Open()
        'Catch
        '    MsgBox(Err.Description)
        '    RutinaError(Err.Number, Err.Description)
        '    Err.Clear()
        'End Try
    End Function

    Public Function IBM_desconectarAS()
        ''Dim cn As iDB2Connection
        ''cn.Close()
        ''cn = Nothing
    End Function


    Public ReadOnly Property ConexionAS400() As OleDbConnection
        Get
            Return oConexion
        End Get
    End Property

    Public Function ConectarAS() As Boolean
        Dim Retorno As Boolean = True
        Dim StrConn As String
        Try
            If oConexion Is Nothing Then
                oConexion = New OleDb.OleDbConnection()
                oConexion.ConnectionString = "Provider=IBMDA400;Data Source=" & g_ASdatasource & " ;Force Translate=1;User ID = " & g_ASuser & " ;Password = " & g_ASpassword & ";Connect Timeout= " & g_ASTimeOut
                oConexion.Open()
            End If
        Catch ex As SqlClient.SqlException
            Retorno = False
            g_opr_usuario.MensajeBoxError("No se ha podido establecer conexión con MIS.", Err)
            RutinaError(Err.Number, Err.Description)
        Catch ex As OleDb.OleDbException
            Retorno = False
            g_opr_usuario.MensajeBoxError("No se ha podido establecer conexión con MIS.", Err)
            RutinaError(Err.Number, Err.Description)
        Catch ex As Exception
            Retorno = False
            g_opr_usuario.MensajeBoxError("No se ha podido establecer conexión con MIS.", Err)
            RutinaError(Err.Number, Err.Description)
        Catch ex As System.InvalidOperationException
            Retorno = False
            g_opr_usuario.MensajeBoxError("No se ha podido establecer conexión con MIS.", Err)
            RutinaError(Err.Number, Err.Description)
        Finally
        End Try
        Return Retorno
    End Function

    Public Sub desconectarAS()
        'Procedimiento para finalizar la conexión con el AS400
        On Error Resume Next
        oConexion.Close()
        oConexion = Nothing
    End Sub

    Public Function EjecutaEnAS400(ByVal Sql As String) As OleDb.OleDbDataReader
        Dim oComandoOle As New OleDb.OleDbCommand()
        Dim oLectorOle As OleDb.OleDbDataReader
        Try
            If oConexion.State = ConnectionState.Open Then
                oComandoOle.Connection = oConexion
                oComandoOle.CommandText = Sql
                oComandoOle.CommandType = CommandType.Text
                oLectorOle = oComandoOle.ExecuteReader
            Else
                g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos. Consulte con soporte técnico", Err)
            End If
        Catch ex As SqlClient.SqlException
            oLectorOle = Nothing
            g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos EjecutaEnAS400. Consulte con soporte técnico", Err)

        Catch ex As OleDb.OleDbException

            oLectorOle = Nothing

            g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos EjecutaEnAS400. Consulte con soporte técnico", Err)

        Catch ex As Exception

            oLectorOle = Nothing

            g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos EjecutaEnAS400. Consulte con soporte técnico", Err)

        Catch ex As System.InvalidOperationException

            oLectorOle = Nothing

            g_opr_usuario.MensajeBoxError("Problemas al Conectarse a la Base de Datos EjecutaEnAS400. Consulte con soporte técnico", Err)

        Finally

            If Not oComandoOle Is Nothing Then

                oComandoOle.Dispose()

            End If

        End Try

        Return oLectorOle

    End Function




    '********************Ejemplo de uso



    'oConexionAS400 = New SAC.Utilitarios.ConexionAS400(Me._Sesion)

    'If bAprobarEnAS400 Then ' POR GRABACION Y APROBACION DE ORDEN EN ADAM

    'oConexionAS400.InciarRegistroFallas(Utilitarios.ConexionAS400.Operacion.Aprobacion, Utilitarios.ConexionAS400.ConexionAS.ADAM, Me._Actual.Id.ToString, RegistraFalla)

    ''ActivarMensajes(Me, New MensajeEventArgs("Inicio registro de fallas AS400 - Aprobación", TipoMensaje.Informativo, OrigenMensaje.Metodo, Me.GetType.ToString, "GrabarAS400ADAM"))

    'Else 'SOLO VA LA GRABACION DE LA ORDEN EN ADAM

    'oConexionAS400.InciarRegistroFallas(Utilitarios.ConexionAS400.Operacion.Ingreso, Utilitarios.ConexionAS400.ConexionAS.ADAM, Me._Actual.Id.ToString, RegistraFalla)

    'Me._Actual.UsuarioIngreso = Me._Sesion.Usuario.ID

    ''ActivarMensajes(Me, New MensajeEventArgs("Inicio registro de fallas AS400 - Ingreso ", TipoMensaje.Informativo, OrigenMensaje.Metodo, Me.GetType.ToString, "GrabarAS400ADAM"))

    'End If

    'If oConexionAS400.ConectarAS400() Then

    'sql = "SELECT COUNT(*) FROM " + oConexionAS400.Libreria + ".TOCOH "

    'sql = sql & " WHERE OCOCVE = '" & Me._Actual.CodigoOrdenCompraADAM.Trim & "'"

    'oLectorOle = oConexionAS400.EjecutaEnAS400(sql)

    'If oLectorOle.Read Then

    'If CType(oLectorOle.GetValue(0), Integer) > 0 Then

    '_ExisteOC = True

    'End If

    'End If

    'If Not oLectorOle Is Nothing Then

    'oLectorOle.Close()

    'End If

    'If Not _ExisteOC Then

    'sql = "INSERT INTO " + oConexionAS400.Libreria + ".TOCOH "

    'sql = sql & "(OCOCVE,OCOFEC,CIACVE,OCOFAC,CNCCVE,OCOCOM,OCOTIP,OCOEXP,"

    'sql = sql & "PROCVE,CPACVE,LENCVE,OCOEMB,OCOLAB,OCOADF,OCOTDF,OCOSIT,OCOAUT,CACCVE,"

    'sql = sql & "OCORE1,OCORE2,OCORE3,OCORE4,OCORE5,OCOVA1,OCOVA2,OCOVA3,OCOVA4,OCOVA5) "

    'sql = sql & " VALUES ('" & Me._Actual.CodigoOrdenCompraADAM & "', "

    'sql = sql & Format(Me._Actual.FechaIngreso, "yyyyMMdd") & ", 'JB', 'JB', '00', '" & _Sesion.Usuario.ID & "', '"

    'sql = sql & Me._Actual.TipoCompra.TransaccionInventarioAsociada & "', '" & Me._Actual.UsuarioIngreso & "', '"

    'sql = sql & _Actual.ContactoProveedor.CodigoADAM & "', '"

    'sql = sql & _Actual.ContactoProveedor.CondicionPago & "', '" & _Actual.LugarEntrega.CodLugarEntregaADAM

    'sql = sql & "', '" & Me._Actual.DUI & "', ' ', ' ', " & _Actual.PorcentajeDescuento & ", '" & strSituacionOC & "', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 0, 0, 0, 0, 0)"

    'Retorno = oConexionAS400.EjecutaEnAS400(sql, Me._Actual.Id.ToString)

    'Endif 



End Class
