Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms


Public Class frm_Graficos

    Dim opr_res As New Cls_Resultado()
    Dim opr_pedido As New Cls_Pedido()

    Public pac_id As Integer
    Public graf_name As String
    Public graf_tipo As Integer

    ' Variables para el lápiz
    Public WithEvents panelGrafico As PictureBox
    Private WithEvents g As Graphics
    Private pointAnterior As Point
    Private pen As Pen
    Dim rbt As Integer








    Private Sub frm_Graficos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        panelGrafico = New PictureBox()
        panelGrafico.Location = New Point(12, 65)
        panelGrafico.BackColor = Color.White
        panelGrafico.Width = 466
        panelGrafico.Height = 462
        panelGrafico.SizeMode = PictureBoxSizeMode.StretchImage

        ' Agregar el Panel al formulario
        Me.Controls.Add(panelGrafico)

        ' Inicializar la instancia de Graphics
        g = panelGrafico.CreateGraphics()

        ' Configurar el lápiz
        pen = New Pen(Color.Black)

        rbt = 1

        NumericUpDown1.Minimum = 1
        NumericUpDown1.Maximum = 3
        NumericUpDown1.Value = 1



        Select Case graf_tipo
            Case 1
                graf_name = opr_res.ConsultaGraf_name(pac_id, 1)
                If graf_name = "" Then

                    panelGrafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\Fisiograma.png")
                Else
                    'Dim archivoName As String = Environment.CurrentDirectory & "\Graficos\" & graf_name

                    'Using archivo As New FileStream(archivoName, FileMode.Open)
                    panelGrafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\" & graf_name)
                    'End Using

                End If
            Case 2
                graf_name = opr_res.ConsultaGraf_name(pac_id, 2)
                If graf_name = "" Then
                    panelGrafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\Odontograma.png")
                Else
                    'Dim archivoName As String = Environment.CurrentDirectory & "\Graficos\" & graf_name
                    'Using archivo As New FileStream(archivoName, FileMode.Open)
                    panelGrafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\" & graf_name)
                    'End Using
                End If

        End Select
    End Sub


    Private Sub panelGrafico_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles panelGrafico.MouseEnter
        ' Cambiar el cursor al pasar sobre el control PictureBox
        Cursor = Cursors.Hand ' Puedes elegir el cursor que desees, por ejemplo, Cursors.Cross para un cursor de cruz
    End Sub

    Private Sub panelGrafico_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles panelGrafico.MouseLeave
        ' Restaurar el cursor cuando el mouse sale del control PictureBox
        Cursor = Cursors.Default
    End Sub

    

    Private Sub panelGrafico_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelGrafico.MouseDown
        ' Guardar la posición inicial del mouse
        pointAnterior = e.Location
    End Sub

    Private Sub panelGrafico_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelGrafico.MouseMove
        ' Dibujar una línea desde la posición anterior del mouse a la posición actual
        If e.Button = MouseButtons.Left Then
            g.DrawLine(pen, pointAnterior, e.Location)
            pointAnterior = e.Location
        End If
    End Sub

    Private Sub panelGrafico_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelGrafico.MouseUp
        
    End Sub



    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        rbt = 1
        escojeColor(1, CInt(NumericUpDown1.Value))
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        rbt = 2
        escojeColor(2, CInt(NumericUpDown1.Value))
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        rbt = 3
        escojeColor(3, CInt(NumericUpDown1.Value))
    End Sub

    Private Sub escojeColor(ByVal rbt As Integer, ByVal grosor As Integer)

        Select Case rbt
            Case 1
                Select Case grosor
                    Case 1
                        pen = New Pen(Color.Black)
                        pen.Width = 1
                    Case 2
                        pen = New Pen(Color.Black)
                        pen.Width = 2

                    Case 3
                        pen = New Pen(Color.Black)
                        pen.Width = 3
                End Select


            Case 2
                Select Case grosor
                    Case 1
                        pen = New Pen(Color.Red)
                        pen.Width = 1
                    Case 2
                        pen = New Pen(Color.Red)
                        pen.Width = 2

                    Case 3
                        pen = New Pen(Color.Red)
                        pen.Width = 3
                End Select

            Case 3
                Select Case grosor
                    Case 1
                        pen = New Pen(Color.Blue)
                        pen.Width = 1
                    Case 2
                        pen = New Pen(Color.Blue)
                        pen.Width = 2

                    Case 3
                        pen = New Pen(Color.Blue)
                        pen.Width = 3
                End Select
        End Select
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        escojeColor(rbt, CInt(NumericUpDown1.Value))
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim rutaBorrar As String = graf_name

        Try
            'Dim areaCaptura As New Rectangle(12, 65, 466, 462)
            Dim areaCaptura As New Rectangle(Me.Location.X + 12, Me.Location.Y + 65, Me.Width - 122, Me.Height - 77)

            ' Crear un bitmap para almacenar la captura
            Dim bitmapCaptura As New Bitmap(areaCaptura.Width, areaCaptura.Height)

            ' Crear un objeto Graphics a partir del bitmap
            Using graphicsCaptura As Graphics = Graphics.FromImage(bitmapCaptura)
                ' Capturar el área del formulario
                graphicsCaptura.CopyFromScreen(areaCaptura.Location, New Point(0, 0), areaCaptura.Size)
            End Using

            ' Guardar la imagen capturada
            ''Dim rutaGuardar As String = "captura_formulario.png"
            'Dim rutaGuardar As String = pac_id & ".png" ' Ruta de destino para guardar la imagen
            Dim rutaGuardar As String = lbl_paciente.Text & "_" & Format(Now, "yyyMMddhhmmss") & ".png"



            bitmapCaptura.Save(Environment.CurrentDirectory & "\Graficos\" & rutaGuardar, Imaging.ImageFormat.Png)

            ''If File.Exists(Environment.CurrentDirectory & "\Graficos\" & rutaBorrar) Then
            ''    ' Borrar el archivo
            ''    File.Delete(Environment.CurrentDirectory & "\Graficos\" & rutaBorrar)
            ''Else
            ''    'panelGrafico.Image = Image.FromFile(Environment.CurrentDirectory & "\CARGANDO_info.GIF")


            ''End If

            If pac_id <> 0 Then
                If graf_name <> "" Then
                    opr_res.InsertarGrafico(pac_id, rutaGuardar, graf_tipo, "Update")
                Else
                    opr_res.InsertarGrafico(pac_id, rutaGuardar, graf_tipo, "Insert")
                End If
            End If

            panelGrafico.Image.Dispose()
            panelGrafico.Image = Nothing


            If graf_name <> "" Then
                EliminarImagen(rutaBorrar)
            End If

            opr_pedido.VisualizaMensaje("Fisiograma/Odontograma guardado correctamente.", 350)
        Catch ex As Exception
            'EliminarImagen(rutaBorrar)
            'opr_pedido.VisualizaMensaje("No se pudo guardar " & ex.Message, 450)
        End Try
        Me.Close()

    End Sub

    Private Sub EliminarImagen(ByVal rutaBorrar As String)
        ' Verificar si hay una imagen en el PictureBox
        'If panelGrafico.Image IsNot Nothing Then
        ' Liberar la imagen del PictureBox
        'panelGrafico.Image.Dispose()
        'panelGrafico.Image = Nothing

        GC.Collect()
        GC.WaitForPendingFinalizers()

        ' Especificar la ruta del archivo a eliminar
        'Dim rutaArchivo As String = "ruta_de_la_imagen.jpg"

        ' Verificar si el archivo existe antes de intentar eliminarlo
        If File.Exists(Environment.CurrentDirectory & "\Graficos\" & rutaBorrar) Then
            ' Eliminar el archivo
            File.Delete(Environment.CurrentDirectory & "\Graficos\" & rutaBorrar)

            'MessageBox.Show("Imagen eliminada correctamente del disco.")
        Else
            'MessageBox.Show("El archivo especificado no existe.")
        End If

    End Sub
End Class