Imports System.IO

Public Class Cls_Celda_Grafica

    Inherits System.Windows.Forms.DataGridTextBoxColumn

    Private m_IsRedIfOverDue As Boolean = False
    Private m_headertext As String
    Private c_PriorityImagesPath As String = Application.StartupPath & "\Imagenes\"
    Private m_HtImages As New Hashtable()


    Public Sub New(ByVal headerText As String, ByVal mappingName As String, ByVal width As Integer, ByVal isRedIfOverDue As Boolean)
        MyBase.HeaderText = headerText
        MyBase.MappingName = mappingName
        MyBase.Width = width
        m_headertext = headerText
        m_IsRedIfOverDue = isRedIfOverDue
    End Sub

    Protected Overloads Overrides Sub Edit(ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal bounds As System.Drawing.Rectangle, ByVal isReadOnly As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        'Para que el datagrid sea de solo lectura
    End Sub

    Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, ByVal bounds As System.Drawing.Rectangle, ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal backBrush As System.Drawing.Brush, ByVal foreBrush As System.Drawing.Brush, ByVal alignToRight As Boolean)
        Dim bVal As Object = GetColumnValueAtRow(source, rowNum)
        Dim imageToDraw As Image

        If m_IsRedIfOverDue Then
            'Si la columna actual es esta columna, se coloca  el color de fondo
            If Me.DataGridTableStyle.DataGrid.CurrentRowIndex = rowNum Then
                g.FillRectangle(New SolidBrush(Me.DataGridTableStyle.SelectionBackColor), bounds)
            Else
                g.FillRectangle(backBrush, bounds)
            End If
            If IsDBNull(bVal) Then bVal = ""
            If bVal <> "" Then
                g.DrawString(bVal, Me.DataGridTableStyle.DataGrid.Font, foreBrush, bounds.X + 2, bounds.Y + 2)

            Else
                g.DrawString("", Me.DataGridTableStyle.DataGrid.Font, foreBrush, bounds.X + 2, bounds.Y + 2)
            End If
        Else
            ' Dibuja la imagen de error
            If m_headertext = "ERROR EQP" Or m_headertext = "" Then
                If bVal <> "0" And bVal <> "" And bVal <> "00000" Then
                    'obtenemos la imagen del hashtable()
                    If m_HtImages.ContainsKey(bVal) Then
                        imageToDraw = CType(m_HtImages(bVal), System.Drawing.Image)
                    Else
                        'Tomamos la imagen del disco
                        Try
                            imageToDraw = Image.FromFile(c_PriorityImagesPath & "alert.png")
                            m_HtImages.Add(bVal, imageToDraw)
                            'g.FillRectangle(New SolidBrush(Me.DataGridTableStyle.SelectionBackColor.Red), bounds)
                        Catch
                            Return
                        End Try
                    End If
                Else
                    'vacio
                    imageToDraw = Image.FromFile(c_PriorityImagesPath & "vacio.gif")


                End If

                'Si la columna actual es esta columna, pintamos el fondo
                If Me.DataGridTableStyle.DataGrid.CurrentRowIndex = rowNum Then
                    g.FillRectangle(New SolidBrush(Me.DataGridTableStyle.SelectionBackColor), bounds)

                Else
                    g.FillRectangle(backBrush, bounds)
                End If

                g.DrawImage(imageToDraw, New Point(bounds.X, bounds.Y))

                ' pongo color 
                'g.FillRectangle(New SolidBrush(Me.DataGridTableStyle.SelectionBackColor.Red), bounds.X, bounds.Y, 19, 16)

            ElseIf m_headertext = "st" Then

                Dim grafi As String
                Select Case bVal
                    Case 0 : grafi = "vacio.gif"
                    Case 1 : grafi = "ic_stock1.jpg"
                    Case 2 : grafi = "ic_stock2.jpg"
                    Case 3 : grafi = "ic_stock3.jpg"


                End Select

                If m_HtImages.ContainsKey(bVal) Then
                    imageToDraw = CType(m_HtImages(bVal), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Image.FromFile(c_PriorityImagesPath & grafi)
                        m_HtImages.Add(bVal, imageToDraw)
                        g.FillRectangle(New SolidBrush(Me.DataGridTableStyle.SelectionBackColor.Red), bounds)
                    Catch
                        Return
                    End Try
                End If
                If Me.DataGridTableStyle.DataGrid.CurrentRowIndex = rowNum Then
                    g.FillRectangle(New SolidBrush(Me.DataGridTableStyle.SelectionBackColor.Red), bounds)

                Else
                    g.FillRectangle(backBrush, bounds)

                End If
                g.DrawImage(imageToDraw, New Point(bounds.X, bounds.Y))
            Else
                If bVal >= "1" And bVal <= "9" Then
                    Dim grafi As String
                    Select Case bVal
                        Case 1 : grafi = "azul.gif"
                        Case 2 : grafi = "verde.gif"
                        Case 3 : grafi = "visto.gif"
                        Case 4 : grafi = "x.gif"
                        Case 6 : grafi = "ic_stock2.ICO"
                        Case 8 : grafi = "ic_stock3.ICO"
                        Case 9 : grafi = "adobe.ICO"

                    End Select
                    If m_HtImages.ContainsKey(bVal) Then
                        imageToDraw = CType(m_HtImages(bVal), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Image.FromFile(c_PriorityImagesPath & grafi)
                            m_HtImages.Add(bVal, imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                Else
                    'vacio
                    imageToDraw = Image.FromFile(c_PriorityImagesPath & "vacio.gif")
                End If
                If Me.DataGridTableStyle.DataGrid.CurrentRowIndex = rowNum Then
                    g.FillRectangle(New SolidBrush(Me.DataGridTableStyle.SelectionBackColor), bounds)
                Else
                    g.FillRectangle(backBrush, bounds)
                End If
                g.DrawImage(imageToDraw, New Point(bounds.X, bounds.Y))
            End If
        End If
    End Sub



End Class


Public Class Cls_Celda_NoEditable

    Inherits System.Windows.Forms.DataGridTextBoxColumn

    Public Sub New(ByVal formato As String, ByVal encabezado As String, ByVal mappingName As String, ByVal ancho As Integer, Optional ByVal sololectura As Boolean = True, Optional ByVal textonulo As String = "")
        MyBase.Format = formato
        MyBase.HeaderText = encabezado
        MyBase.MappingName = mappingName
        MyBase.Width = ancho
        MyBase.ReadOnly = sololectura
        MyBase.NullText = textonulo
    End Sub

    Protected Overloads Overrides Sub Edit(ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal bounds As System.Drawing.Rectangle, ByVal isReadOnly As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        'La sobrecarga de esta función sirve para que el texto no sea editable
        'hace que la celda sea readonly, pero no editable
        'no posee código
    End Sub

End Class

Public Class Cls_Celda_Editable

    Inherits System.Windows.Forms.DataGridTextBoxColumn

    Public Sub New(ByVal formato As String, ByVal encabezado As String, ByVal mappingName As String, ByVal ancho As Integer, Optional ByVal sololectura As Boolean = True, Optional ByVal textonulo As String = "")
        MyBase.Format = formato
        MyBase.HeaderText = encabezado
        MyBase.MappingName = mappingName
        MyBase.Width = ancho
        'MyBase.ReadOnly = sololectura
        MyBase.NullText = textonulo
    End Sub

    Protected Overloads Overrides Sub Edit(ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal bounds As System.Drawing.Rectangle, ByVal isReadOnly As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        'La sobrecarga de esta función sirve para que el texto no sea editable
        'hace que la celda sea readonly, pero no editable
        'no posee código
    End Sub

End Class