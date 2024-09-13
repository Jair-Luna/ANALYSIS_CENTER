'*************************************************************************
' Nombre:   Cls_NetMail
' Tipo de Archivo: Clase
' Descripción:  Clase para el envio de correo electronico
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

'Imports System.Web.Mail
Imports System.Net.Mail
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Net
Imports System
Imports System.Data
Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient
Imports EASendMailObjLib



Public Class Cls_NetMail

    Public Function RecuperaConfigCorreo() As String
        'Función para consultar todas las ciudades 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_perfil As SqlDataReader = New SqlCommand("select * from correo;", opr_conexion.conn_sql).ExecuteReader
        RecuperaConfigCorreo = Nothing
        While odr_perfil.Read
            If Not IsDBNull(odr_perfil.GetString(0)) Then
                RecuperaConfigCorreo = Trim(odr_perfil.GetString(0)) & "," & Trim(odr_perfil.GetString(1)) & "," & Trim(odr_perfil.GetString(2)) & "," & Trim(odr_perfil.GetString(3)) & "," & Trim(odr_perfil.GetString(4)) & "," & Trim(odr_perfil.GetString(5)) & ","
            End If
        End While
        odr_perfil.Close()
        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Config Correo", Err)
        Err.Clear()
    End Function


    Public Function EnviaCorreo(ByVal Para As String, ByVal Asunto As String, ByVal Texto As String, ByVal cfrom As String, ByVal cport As String, ByVal cserver As String, ByVal cpass As String, ByVal cSSL As String, ByVal pathArchivo As String, ByVal ccopy As String) As Boolean

        'Dim ccopy As String = "rossvanflores@gmail.com"

        If System.Configuration.ConfigurationSettings.AppSettings("Correo") = "Corporativo" Then

            Try
                Dim oSmtp As EASendMailObjLib.Mail
                Dim m_arCharset(27, 1) As String
                Dim ServerAddr = Trim(cserver)

                oSmtp = New EASendMailObjLib.Mail
                oSmtp.LicenseCode = "TryIt"
                oSmtp.ServerAddr = cserver
                oSmtp.ServerPort = cport
                oSmtp.Protocol = 0
                oSmtp.ConnectType = 4

                oSmtp.UserName = Trim(cfrom)
                oSmtp.Password = Trim(cpass)

                oSmtp.ConnectType = 1
                'oSmtp.Charset = m_arCharset(lstCharset.ListIndex, 1)
                oSmtp.Charset = 25
                Dim name, addr As String
                fnParseAddr(cfrom, name, addr)

                'oSmtp.From = name
                oSmtp.From = System.Configuration.ConfigurationSettings.AppSettings("TITULO")
                oSmtp.FromAddr = addr

                oSmtp.SignerCert.Unload()

                oSmtp.AddRecipientEx(Para, 0)  ' 0, Normal recipient, 1, cc, 2, bcc
                'oSmtp.AddRecipientEx(cc_addr, 0)

                Dim recipients As String
                recipients = Para & ","
                fnTrim(recipients, ",")

                Dim i, Count As Integer
                'encrypt email by recipients certificate
                oSmtp.RecipientsCerts.Clear()

                Dim Subject, Bodytext
                Subject = Asunto
                Bodytext = Texto

                Bodytext = Replace(Bodytext, "[$from]", cfrom)
                Bodytext = Replace(Bodytext, "[$to]", recipients)
                Bodytext = Replace(Bodytext, "[$subject]", Subject)

                oSmtp.Subject = Subject
                oSmtp.BodyText = Bodytext
                If pathArchivo <> "" Then
                    oSmtp.AddAttachment(pathArchivo)
                End If



                If InStr(1, recipients, ",", 1) > 1 And ServerAddr = "" Then
                    'To send email without specified smtp server, we have to send the emails one by one
                    ' to multiple recipients. That is because every recipient has different smtp server.
                    DirectSend(oSmtp, recipients)
                    'btnSend.Enabled = True
                    'textStatus.Caption = ""
                    Exit Function
                End If

                If oSmtp.SendMail() = 0 Then

                    'MsgBox("Correo entregado.")

                    EnviaCorreo = True
                Else
                    MsgBox(oSmtp.GetLastErrDescription()) 'Get last error description
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, _
                                "Error al enviar correo", _
                                 MessageBoxButtons.OK)
                EnviaCorreo = False
            End Try

        End If


        If System.Configuration.ConfigurationSettings.AppSettings("Correo") = "Web" Then
            Try

                'Dim email As New System.Net.Mail.MailMessage
                'Dim smtp As New System.Net.Mail.SmtpClient
                'email.IsBodyHtml = False
                'email.From = New System.Net.Mail.MailAddress(cfrom)
                'email.To.Add(PARA)
                'email.Subject = g_Titulo & "-" & Asunto
                'email.SubjectEncoding = System.Text.Encoding.UTF8
                'email.Body = "MENSAJE DEL CORREO"
                'email.BodyEncoding = System.Text.Encoding.UTF8
                'email.Priority = System.Net.Mail.MailPriority.Normal
                'smtp.Credentials = New System.Net.NetworkCredential(cfrom, cpass)
                'smtp.Host = cserver
                'smtp.Port = cport
                'smtp.Send(email)

                Dim mail As New MailMessage
                ' VALIDAR RFN
                mail.From = New MailAddress(Trim(cfrom))

                For Each Cmail As String In Para.Split(New Char() {";"c})
                    mail.To.Add(New System.Net.Mail.MailAddress(Cmail))
                    mail.CC.Add(New System.Net.Mail.MailAddress(ccopy))
                Next

                'mail.To.Add(Trim(Para))
                mail.Subject = g_Titulo & "-" & Asunto
                mail.Body = Texto
                mail.Priority = System.Net.Mail.MailPriority.Normal

                If pathArchivo <> "" Then
                    Dim archivo As New System.Net.Mail.Attachment(pathArchivo)
                    mail.Attachments.Add(archivo)
                End If
                'mail.Body = "<strong>Texto del mensaje de correo</strong>"
                'Dim servidor As New SmtpClient("smtp.live.com")
                Dim servidor As New SmtpClient(cserver)
                servidor.Port = cport
                servidor.EnableSsl = Trim(cSSL)
                servidor.Credentials = New System.Net.NetworkCredential(cfrom, cpass)
                ''CON hOTMAIL
                'ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True
                servidor.Send(mail)
                ''PARA ADJUNTAR PRIMERO GENERAR PDF ANTES


                'MessageBox.Show("Enviado realizado con exito.", _
                '               "Correo enviado", _
                '               MessageBoxButtons.OK)
                EnviaCorreo = True
            Catch ex As Exception
                'MessageBox.Show("Error: " & ex.Message, _
                '               "Error al enviar correo", _
                '                 MessageBoxButtons.OK)
                EnviaCorreo = False

            End Try
        End If

    End Function


    Private Sub DirectSend(ByRef oSmtp As EASendMailObjLib.Mail, ByVal recipients As String)
        Dim arTo() As String

        arTo = Split(recipients, ",")   'split the multiple address to an array
        Dim i, Count
        Dim addr
        Count = UBound(arTo)
        For i = 0 To Count
            addr = arTo(i)
            fnTrim(addr, " ,;")
            If addr <> "" Then
                oSmtp.ClearRecipient()
                oSmtp.AddRecipientEx(addr, 0)
                'textStatus.Caption = "Sending email to " & addr & ", please wait ... "
                If oSmtp.SendMail() = 0 Then
                    MsgBox("Message delivered to " & addr & " successfully!")
                Else
                    MsgBox("Failed to delivery to " & addr & " : " & oSmtp.GetLastErrDescription()) 'Get last error description
                End If
            End If
        Next
    End Sub

    Function fnParseAddr(ByVal src, ByRef name, ByRef addr)
        Dim nIndex
        nIndex = InStr(1, src, "<")
        If nIndex > 0 Then
            name = Mid(src, 1, nIndex - 1)
            addr = Mid(src, nIndex)
        Else
            name = ""
            addr = src
        End If

        Call fnTrim(name, " ,;<>""'")
        Call fnTrim(addr, " ,;<>""'")
    End Function
    '========================================================
    ' fnTrim
    '========================================================
    Function fnTrim(ByRef src, ByVal trimer)
        Dim i, nCount, ch
        nCount = Len(src)
        For i = 1 To nCount
            ch = Mid(src, i, 1)
            If InStr(1, trimer, ch) < 1 Then
                Exit For
            End If
        Next

        src = Mid(src, i)
        nCount = Len(src)
        For i = nCount To 1 Step -1
            ch = Mid(src, i, 1)
            If InStr(1, trimer, ch) < 1 Then
                Exit For
            End If
        Next
        src = Mid(src, 1, i)
    End Function



End Class
