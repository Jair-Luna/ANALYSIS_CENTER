'*************************************************************************
' Nombre:   Cls_Hist
' Tipo de Archivo: clase
' Descripcin:  Clase para operar los datos de los histogramas
' Autores:  RFN 
' Fecha de Creaci�n: Enero del 2003
' Autores:  RFN
' Ultima Modificaci�n: 29/01/2003
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO

Public Class Cls_Hist

    Dim str As String
    Dim arr_wbc(), arr_rbc(), arr_plt() As String
    Dim pen As New Pen(Color.White)
    Dim str_dir As String = Environment.CurrentDirectory & "\~tempimg"
    Dim dts_datos As New DataSet()

    Public Function LeerDatosHistograma(ByVal ped_id As String) As DataSet
        'funcion que devuelve los datos de los histogramas de un pedido 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_paciente.SelectCommand = New SqlCommand("SELECT PTOHISTOGRAMA.his_nombre, PTOHISTOGRAMA.datos, PTOHISTOGRAMA.ped_id FROM PTOHISTOGRAMA WHERE PTOHISTOGRAMA.ped_id=" & ped_id & "", opr_conexion.conn_sql)
        LeerDatosHistograma = New DataSet()
        oda_paciente.Fill(LeerDatosHistograma, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Datos Histograma" & Err.Description, Err)
        Err.Clear()
    End Function

    Public Sub Grafica_Histogramas(ByVal arr_wbc() As String, ByVal arr_rbc() As String, ByVal arr_plt() As String, ByRef pic_wbc As PictureBox, ByRef pic_rbc As PictureBox, ByRef pic_plt As PictureBox)
        Dim int_count As Integer
        Dim pnt_graf As Point()
        Dim sbr_color As New SolidBrush(Color.Blue)
        Dim fnt_letra As New Font("Arial", 7, FontStyle.Regular)
        Dim int_spc_x, int_spc_y As Short
        int_spc_x = 5
        int_spc_y = 10
        'borra la carpeta \~tempimg donde se almacena temporalmente los histogramas en uso
        Try
            If Dir(str_dir, FileAttribute.Directory) <> "" Then Directory.Delete(str_dir, True)
        Catch ex As Exception
        End Try
        'crea la carptea \~tempimg donde se almacena temporalmente los histogramas en uso
        Try
            Directory.CreateDirectory(str_dir)
        Catch ex As Exception
        End Try
        'CELLDYN1700: A todos los puntos se les multiplica por 0.7 para obtener el 70% de sus tama�o real
        'CELLDYN3500: VALOR X: 3 y Y: 0.5
        'Crea el histograma del WBC
        Dim bmp As Bitmap = New Bitmap(pic_wbc.ClientRectangle.Width, pic_wbc.ClientRectangle.Height)
        For int_count = 0 To (UBound(arr_wbc) - 1)
            ReDim Preserve pnt_graf(int_count)
            'pnt_graf(int_count) = New Point(int_count * 3 + int_spc_x, pic_wbc.ClientRectangle.Height - int_spc_y - CShort(arr_wbc(int_count)) * 0.5)
            pnt_graf(int_count) = New Point(int_count * 0.7 + int_spc_x, pic_wbc.ClientRectangle.Height - int_spc_y - CShort(arr_wbc(int_count)) * 0.7)
        Next
        With Graphics.FromImage(bmp)
            .FillRectangle(Brushes.White, pic_wbc.ClientRectangle)
            pen.Color = Color.Black
            sbr_color.Color = pen.Color
            .DrawString("WBC", fnt_letra, sbr_color, pic_wbc.ClientRectangle.Width / 2 - 3, 5)
            'DIBUJA LA LINEA
            .DrawCurve(pen, pnt_graf)
            'DIBUJA EL AREA
            ''.FillClosedCurve(sbr_color, pnt_graf)
            pen.Color = Color.DarkBlue
            sbr_color.Color = pen.Color
            'eje y
            .DrawLine(pen, int_spc_x, int_spc_y, int_spc_x, pic_wbc.ClientRectangle.Height - int_spc_y)
            .DrawString("0" & Space(10) & "100" & Space(12) & "200" & Space(10) & "300" & Space(10) & "400", fnt_letra, sbr_color, 0, pic_wbc.ClientRectangle.Height - int_spc_y)
            'eje x
            .DrawLine(pen, int_spc_x, pic_wbc.ClientRectangle.Height - int_spc_y, 273, pic_wbc.ClientRectangle.Height - int_spc_y)
        End With
        pic_wbc.CreateGraphics.DrawImage(bmp, 0, 0)
        bmp.Save(str_dir & "\pic_wbc.jpg", ImageFormat.Jpeg)
        pic_wbc.Image = System.Drawing.Image.FromFile(str_dir & "\pic_wbc.jpg")
        bmp.Dispose()
        'File.Delete(str_dir & "\pic_wbc.jpg")
        'Crea el histograma del RBC
        bmp = New Bitmap(pic_rbc.ClientRectangle.Width, pic_rbc.ClientRectangle.Height)
        For int_count = 0 To (UBound(arr_rbc) - 1)
            ReDim Preserve pnt_graf(int_count)
            'pnt_graf(int_count) = New Point(int_count * 3 + int_spc_x, pic_rbc.ClientRectangle.Height - int_spc_y - CShort(arr_rbc(int_count)) * 0.5)
            pnt_graf(int_count) = New Point(int_count * 0.7 + int_spc_x, pic_rbc.ClientRectangle.Height - int_spc_y - CShort(arr_rbc(int_count)) * 0.09)
        Next
        With Graphics.FromImage(bmp)
            .FillRectangle(Brushes.White, pic_rbc.ClientRectangle)
            pen.Color = Color.Black
            sbr_color.Color = pen.Color
            .DrawString("RBC", fnt_letra, sbr_color, pic_rbc.ClientRectangle.Width / 2 - 3, 5)
            'DIBUJA LA LINEA
            .DrawCurve(pen, pnt_graf)
            'DIBUJA EL AREA
            ''.FillClosedCurve(sbr_color, pnt_graf)
            pen.Color = Color.DarkBlue
            sbr_color.Color = pen.Color
            'eje y
            .DrawLine(pen, int_spc_x, int_spc_y, int_spc_x, pic_rbc.ClientRectangle.Height - int_spc_y)
            .DrawString("0" & Space(12) & "60" & Space(10) & "125" & Space(10) & "190" & Space(10) & "250", fnt_letra, sbr_color, 0, pic_rbc.ClientRectangle.Height - int_spc_y)
            'eje x
            .DrawLine(pen, int_spc_x, pic_rbc.ClientRectangle.Height - int_spc_y, 273, pic_rbc.ClientRectangle.Height - int_spc_y)
        End With
        pic_rbc.CreateGraphics.DrawImage(bmp, 0, 0)
        bmp.Save(str_dir & "\pic_rbc.jpg", ImageFormat.Jpeg)
        pic_rbc.Image = System.Drawing.Image.FromFile(str_dir & "\pic_rbc.jpg")
        bmp.Dispose()
        'File.Delete(str_dir & "\pic_rbc.jpg")
        'Crea el histograma del PLT
        bmp = New Bitmap(pic_plt.ClientRectangle.Width, pic_plt.ClientRectangle.Height)
        For int_count = 0 To (UBound(arr_plt) - 1)
            ReDim Preserve pnt_graf(int_count)
            pnt_graf(int_count) = New Point(int_count * 1.5 + int_spc_x, pic_plt.ClientRectangle.Height - int_spc_y - CShort(arr_plt(int_count)) * 1)
            'pnt_graf(int_count) = New Point(int_count * 0.7 + int_spc_x, pic_plt.ClientRectangle.Height - int_spc_y - CShort(arr_plt(int_count)) * 0.7)
        Next
        With Graphics.FromImage(bmp)
            .FillRectangle(Brushes.White, pic_plt.ClientRectangle)
            pen.Color = Color.Black
            sbr_color.Color = pen.Color
            .DrawString("PLT", fnt_letra, sbr_color, pic_plt.ClientRectangle.Width / 2 - 3, 5)
            'DIBUJA LA LINEA
            .DrawCurve(pen, pnt_graf)
            'DIBUJA EL AREA
            ''.FillClosedCurve(sbr_color, pnt_graf)
            pen.Color = Color.DarkBlue
            sbr_color.Color = pen.Color
            'eje y
            .DrawLine(pen, int_spc_x, int_spc_y, int_spc_x, pic_plt.ClientRectangle.Height - int_spc_y)
            .DrawString("0" & Space(12) & "5" & Space(12) & "10" & Space(12) & "15" & Space(12) & "20", fnt_letra, sbr_color, 0, pic_plt.ClientRectangle.Height - int_spc_y)
            'eje x
            .DrawLine(pen, int_spc_x, pic_plt.ClientRectangle.Height - int_spc_y, 273, pic_plt.ClientRectangle.Height - int_spc_y)
        End With
        pic_plt.CreateGraphics.DrawImage(bmp, 0, 0)
        bmp.Save(str_dir & "\pic_plt.jpg", ImageFormat.Jpeg)
        pic_plt.Image = System.Drawing.Image.FromFile(str_dir & "\pic_plt.jpg")
        bmp.Dispose()
        'File.Delete(str_dir & "\pic_wbc.jpg")
        'File.Delete(str_dir & "\pic_rbc.jpg")
        'File.Delete(str_dir & "\pic_plt.jpg")
    End Sub
End Class
