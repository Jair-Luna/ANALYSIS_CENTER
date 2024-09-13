Imports System.Security.Cryptography
Imports System.Security
Imports System.IO

Public Class Cls_Criptografia

    Public Enum CryptoAction
        actionEncrypt = 1
        actionDecrypt = 2
    End Enum


    Public Function GetKeyByteArray(ByVal sPassword As String) As Byte()
        Dim byteTemp(7) As Byte
        sPassword = sPassword.PadRight(8)   ' asegurarse de que tenemos 8 caracteres
        Dim iCharIndex As Integer
        For iCharIndex = 0 To 7
            byteTemp(iCharIndex) = Asc(Mid$(sPassword, iCharIndex + 1, 1))
        Next
        Return byteTemp
    End Function


    Public Sub EncryptOrDecryptFile(ByVal sInputFile As String, _
                                     ByVal sOutputFile As String, _
                                     ByVal byteDESKey() As Byte, _
                                     ByVal byteDESIV() As Byte, _
                                     ByVal Direction As CryptoAction)

        'Crea las secuencias de archivo que controlan los archivos de entrada y salida.
        Dim fsInput As New FileStream(sInputFile, _
                                      FileMode.Open, FileAccess.Read)
        Dim fsOutput As New FileStream(sOutputFile, _
                                      FileMode.OpenOrCreate, FileAccess.Write)
        fsOutput.SetLength(0)

        'Variables necesarias durante el proceso de cifrado/descifrado
        Dim byteBuffer(4096) As Byte 'almacena un bloque de bytes para el procesamiento
        Dim nBytesProcessed As Long = 0 'ejecuta un recuento de bytes cifrados
        Dim nFileLength As Long = fsInput.Length
        Dim iBytesInCurrentBlock As Integer
        Dim desProvider As New DESCryptoServiceProvider()
        Dim csMyCryptoStream As CryptoStream

        ' Configuración de cifrado o descifrado
        Select Case Direction
            Case CryptoAction.actionEncrypt
                csMyCryptoStream = New CryptoStream(fsOutput, _
                   desProvider.CreateEncryptor(byteDESKey, byteDESIV), _
                   CryptoStreamMode.Write)
            Case CryptoAction.actionDecrypt
                csMyCryptoStream = New CryptoStream(fsOutput, _
                   desProvider.CreateDecryptor(byteDESKey, byteDESIV), _
                   CryptoStreamMode.Write)
        End Select
        'Lee el archivo de entrada y lo cifra o descifra,
        'a continuación escribe en el archivo de salida.
        While nBytesProcessed < nFileLength
            iBytesInCurrentBlock = fsInput.Read(byteBuffer, 0, 4096)
            csMyCryptoStream.Write(byteBuffer, 0, iBytesInCurrentBlock)
            nBytesProcessed = nBytesProcessed + CLng(iBytesInCurrentBlock)
        End While
        csMyCryptoStream.Close()
        fsInput.Close()
        fsOutput.Close()
    End Sub
End Class