Imports System.Security.Cryptography
Imports System.Security
Imports System.IO

Public Class Cls_Interfases

    Public Function GeneraOrdenTxt(ByVal texto As String, ByVal nombre As String) As Boolean
        Dim fs As FileStream


        'Dim archivo As String = Format(Now, "yyyyMMdd") & "0001.ASTM"
        Dim archivo As String = nombre & ".astm"

        Dim ruta As String = System.Configuration.ConfigurationSettings.AppSettings("RUTA")
        'Dim escribir As New StreamWriter(ruta & archivo, True)

        ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(ruta) Then

                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()

                'GeneraOrdenTxt = True
                ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)

                'MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "ANALISYS")
            Else

                ':::Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)

                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                'GeneraOrdenTxt = True
                ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)

                'MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "ANALISYS")
            End If



            Dim escribir As New StreamWriter(ruta & archivo)

            escribir.WriteLine(texto)
            escribir.Close()
            GeneraOrdenTxt = True
            'MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "ANALISYS")




        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "ANALISYS")
            GeneraOrdenTxt = False
        End Try
    End Function

    Public Function ModificaOrdenTxt(ByVal texto As String) As Boolean

    End Function

    Public Function EliminaOrdenTxt(ByVal texto As String) As Boolean

    End Function



    Public Function LeeArchivo(ByVal ruta As String) As String
        Dim objStreamReader As StreamReader
        Dim strLine As String

        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader("ruta")

        'Read the first line of text.
        strLine = objStreamReader.ReadLine

        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing

            'Write the line to the Console window.
            'Console.WriteLine(strLine)

            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop

        'Close the file.
        objStreamReader.Close()

        LeeArchivo = strLine

        'Console.ReadLine()
    End Function
End Class
