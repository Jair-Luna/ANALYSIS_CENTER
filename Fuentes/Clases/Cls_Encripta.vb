'*************************************************************************
' Nombre:   Cls_Encripta
' Tipo de Archivo: clase
' Descripcin:  Clase para la empcriptaci�n y desencriptaci�n de datos
' Autores: Ontenida del Internet
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports Scripting
Imports System.IO

Public Class Cls_Encripta

    
    Public Function DevuelveSerialUSB(ByRef str_error As String) As String
        str_error = Nothing
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            Try
                Dim fso As Scripting.FileSystemObject
                Dim oDrive As Drive
                fso = CreateObject("Scripting.FileSystemObject")
                oDrive = fso.GetDrive(drive.Name)
                DevuelveSerialUSB = drive.Name & " " & oDrive.SerialNumber & ","
            Catch ex As Exception
                str_error = ex.ToString
            End Try

        Next
    End Function

    Public Function Genera_usr(ByVal usu_nombre As String, ByVal usu_apellido As String, ByRef usu_login As String, ByVal usu_pass As String) As String
        Dim usuario, pass, link
        Dim letras(51) As String

        Dim n As Integer
        For item As Int32 = 65 To 90
            letras(n) = Chr(item)
            letras(n + 1) = letras(n).ToLower
            n += 2
        Next

        Dim cadenaAleatoria As String = String.Empty

        Dim rnd As New Random(DateTime.Now.Millisecond)

        For n = 0 To 10
            Dim numero As Integer = rnd.Next(0, 51)
            cadenaAleatoria &= letras(numero)
        Next
        usu_login = Mid(usu_nombre, 1, 1) & usu_apellido
        'usu_pass = cadenaAleatoria
        usu_pass = usu_pass

        usuario = "USUARIO: " & (Mid(usu_nombre, 1, 1) & usu_apellido).ToLower()
        pass = "CONTRASEÑA: " & UCase(usu_pass) 'cadenaAleatoria 'RandomString(5, True)"
        link = "LINK: " & System.Configuration.ConfigurationSettings.AppSettings("SITIO")

        Genera_usr = usuario & vbCrLf & pass & vbCrLf & link & vbCrLf & vbCrLf & "Valido por 30 días" & vbCrLf & "correo enviado automaticamente, por favor no responda." & vbCrLf & vbCrLf & vbCrLf & "Powered by TRUESOLUTIONS 2018"
    End Function



    Public Function Genera_empresa(ByVal id_empresa As Integer, ByVal empresa_nombre As String, ByRef emp_codigo As String, ByRef emp_login As String, ByVal emp_pass As String) As String
        Dim codigo, usuario, pass, link
        'Dim letras(51) As String

        
        emp_codigo = "clab" & CStr(Format(id_empresa, "000"))
        emp_login = empresa_nombre
        'emp_pass = cadenaAleatoria

        codigo = "ID EMPRESA: " & "clab" & CStr(Format(CInt(id_empresa), "000"))
        usuario = "USUARIO: " & emp_login
        pass = "CONTRASEñA: " & emp_pass
        link = "LINK: " & System.Configuration.ConfigurationSettings.AppSettings("SITIO")

        Genera_empresa = codigo & vbCrLf & usuario & vbCrLf & pass & vbCrLf & link & vbCrLf & vbCrLf & "Valido por 90 dias" & vbCrLf & "Correo enviado automaticamente, por favor no responda." & vbCrLf & vbCrLf & vbCrLf & "Powered by TRUESOLUTIONS 2021"
    End Function


    Public Function Reenvia_empresa(ByVal id_empresa As Integer, ByVal empresa_nombre As String, ByRef emp_codigo As String, ByVal emp_login As String, ByVal emp_pass As String) As String
        Dim codigo, usuario, pass, link

        
        emp_codigo = "clab" & CStr(Format(id_empresa, "000"))
        emp_login = empresa_nombre

        codigo = "ID EMPRESA: " & "clab" & CStr(Format(CInt(id_empresa), "000"))
        usuario = "USUARIO: " & emp_login
        pass = "CONTRASEñA: " & emp_pass
        link = "LINK: " & System.Configuration.ConfigurationSettings.AppSettings("SITIO")

        Reenvia_empresa = codigo & vbCrLf & usuario & vbCrLf & pass & vbCrLf & link & vbCrLf & vbCrLf & "Valido por 90 dias" & vbCrLf & "Correo enviado automaticamente, por favor no responda." & vbCrLf & vbCrLf & vbCrLf & "Powered by TRUESOLUTIONS 2021"
    End Function



    Public Function Encriptar(ByVal usu_pswd As String) As String
        Dim i As Long, j As Long
        Dim b, s As String
        Dim A1 As Long, A2 As Long, A3 As Long, P
        j = 1
        For i = 1 To Len("pswd")
            P = P & Asc(Mid("pswd", i, 1))
        Next
        For i = 1 To Len(usu_pswd)
            A1 = Asc(Mid(P, j, 1))
            j = j + 1 : If j > Len(P) Then j = 1
            A2 = Asc(Mid(usu_pswd, i, 1))
            A3 = A1 Xor A2
            b = Hex(A3)
            If Len(b) < 2 Then b = "0" + b
            s = s + b
        Next
        Encriptar = s
    End Function

    Function Desencriptar(ByVal usu_pswd As String) As String
        Dim i As Long, j As Long
        Dim b, S As String
        Dim A1 As Long, A2 As Long, A3 As Long, P
        j = 1
        For i = 1 To Len("pswd")
            P = P & Asc(Mid("pswd", i, 1))
        Next
        For i = 1 To Len(usu_pswd) Step 2
            A1 = Asc(Mid(P, j, 1))
            j = j + 1 : If j > Len(P) Then j = 1
            b = Mid(usu_pswd, i, 2)
            A3 = Val("&H" + b)
            A2 = A1 Xor A3
            S = S + Chr(A2)
        Next
        Desencriptar = S
    End Function
End Class
