Imports System.Drawing.Printing

Public Class cls_dgimpresion

    Public RowCount As Integer = 0
    Public PageNumber As Integer = 1

    Private m_dataview As DataView
    Private m_DataGrid As DataGrid


    Private m_PageWidth As Integer
    Private m_PageWidthMinusMargins As Integer
    Private m_PageHeight As Integer
    Private m_AdjColumnBy As Integer
    Private m_IsTooWide As Boolean
    Private m_DataGridWidth As Integer
    Private m_a, m_b, m_c, m_d, m_e, m_f, m_g, m_h, m_i, m_j, m_k, m_urg, m_titulo As String

    Private Const c_TopMargin As Integer = 210
    Private Const c_BottomMargin As Integer = 50
    Private Const c_LeftMargin As Integer = 50
    Private Const c_RightMargin As Integer = 50
    Private Const c_VerticalCellLeeway As Integer = 10
    Private numpag As Integer = 1

    Public Sub New(ByVal dg As DataGrid, ByVal pd As PrintDocument, ByVal dt As DataView, Optional ByVal aa As String = "", Optional ByVal bb As String = "", Optional ByVal cc As String = "", Optional ByVal dd As String = "", Optional ByVal urg As String = "", Optional ByVal tit As String = "", Optional ByVal ee As String = "", Optional ByVal ff As String = "", Optional ByVal gg As String = "", Optional ByVal hh As String = "", Optional ByVal ii As String = "", Optional ByVal jj As String = "", Optional ByVal kk As String = "")
        m_DataGrid = dg
        m_dataview = dt
        m_a = aa
        m_b = bb
        m_c = cc
        m_d = dd
        m_e = ee
        m_f = ff
        m_g = gg
        m_h = hh
        m_i = ii
        m_j = jj
        m_k = kk
        m_urg = urg
        m_titulo = tit

        If m_titulo = "LISTA DE RESULTADOS" Then
            'Obtengo los valores del ancho y el alto de la hoja. IMPRIMO A LO ANCHO
            m_PageHeight = pd.DefaultPageSettings.PaperSize.Width
            m_PageWidth = pd.DefaultPageSettings.PaperSize.Height
            m_PageWidthMinusMargins = m_PageWidth - (c_LeftMargin + c_RightMargin)
            m_DataGridWidth = GetDataGridWidth()
        Else
            'Obtengo los valores del ancho y el alto de la hoja.
            m_PageHeight = pd.DefaultPageSettings.PaperSize.Height
            m_PageWidth = pd.DefaultPageSettings.PaperSize.Width
            m_PageWidthMinusMargins = m_PageWidth - (c_LeftMargin + c_RightMargin)
            m_DataGridWidth = GetDataGridWidth()
        End If


        'Ajustes de margen
        If m_DataGrid.Width > m_PageWidthMinusMargins Then
            m_AdjColumnBy = m_DataGrid.Width - m_PageWidthMinusMargins
            m_DataGridWidth = m_DataGridWidth - m_AdjColumnBy
            m_IsTooWide = True
        Else
            m_AdjColumnBy = m_PageWidthMinusMargins - m_DataGrid.Width
            m_DataGridWidth = m_DataGridWidth + m_AdjColumnBy
            m_IsTooWide = False
        End If
    End Sub

    Public Function DrawDataGrid(ByVal g As Graphics) As Boolean
        Try
            DrawPageHeader(g)
            Return DrawPageRows(g)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
            Return False
        End Try
    End Function

    Private Sub DrawPageHeader(ByVal g As Graphics)
        'Crea el rectangulo de la cabecera
        Dim headerBounds As New RectangleF(c_LeftMargin, c_TopMargin, m_PageWidthMinusMargins, m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway)

        'dibuja el rectangulo de la cabecera
        'g.FillRectangle(New SolidBrush(Color.LightGray), headerBounds)
        If m_titulo <> "RECIBO" Then
            '    g.DrawRectangle(New Pen(m_DataGrid.GridLineColor, 1), c_LeftMargin, c_TopMargin, m_PageWidthMinusMargins - 200, m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway)
            'Else
            g.DrawRectangle(New Pen(m_DataGrid.GridLineColor, 1), c_LeftMargin, c_TopMargin, m_PageWidthMinusMargins, m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway)
        End If

        Dim xPosition As Single = c_LeftMargin + 12

        'Formato definido para graficar
        Dim cellFormat As New StringFormat()
        cellFormat.Trimming = StringTrimming.Word
        cellFormat.FormatFlags = StringFormatFlags.NoWrap Or StringFormatFlags.LineLimit

        'si la lista es una urgencia
        If m_urg = "UR" Then
            g.DrawString("URGENCIA", New Font("Arial", 14, FontStyle.Bold), New SolidBrush(Color.Black), m_PageWidthMinusMargins / 10, 85)
            g.DrawString("URGENCIA", New Font("Arial", 14, FontStyle.Bold), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 90, 85)
        End If
        ' cabecera y pie de pagina
        g.DrawString("LABORATORIO CLINICO", New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 40)
        g.DrawString(g_Titulo, New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 53)

        If m_titulo = "LISTA DE TRABAJO" Then
            g.DrawString(m_titulo, New Font("Arial", 14, FontStyle.Bold), New SolidBrush(Color.Black), (m_PageWidth / 2) - 100, 95)
            g.DrawString("FECHA:   " & Mid(m_a, 1, 40), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 125)
            g.DrawString("EQUIPO: " & Mid(m_b, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 90, 125)
            g.DrawString("AREA:   " & Mid(m_c, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 145)
            g.DrawString("LISTA:   " & Mid(m_d, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 90, 145)
            g.DrawString(CStr(numpag), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidth / 2, m_PageHeight - 60)
            g.DrawString("Tipos de Estado (E):   0 = Pendiente    1 = Procesado    2 = Validado    3 = Enviado    4 = Rechazado", New Font("Courier new", 7), New SolidBrush(Color.Black), c_LeftMargin + 50, m_PageHeight - 75)

        ElseIf m_titulo = "LISTA DE RESULTADOS" Then
            g.DrawString(m_titulo, New Font("Arial", 14, FontStyle.Bold), New SolidBrush(Color.Black), (m_PageWidth / 2) - 100, 95)
            g.DrawString("FECHA:   " & Mid(m_a, 1, 40), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 125)
            g.DrawString("AREA:   " & Mid(m_c, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 145)
            g.DrawString("LISTA:   " & Mid(m_d, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 90, 145)
            g.DrawString(CStr(numpag), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidth / 2, m_PageHeight - 60)

        ElseIf m_titulo = "RECIBO" Then
            g.DrawString("VALE DEL LABORATORIO CLNICO.", New Font("Arial", 12, FontStyle.Bold), New SolidBrush(Color.Black), (m_PageWidth / 2) - 150, 85)
            g.DrawString("TURNO:  " & m_k, New Font("Arial", 10, FontStyle.Bold), New SolidBrush(Color.Black), (m_PageWidth / 2) - 60, 112)
            g.DrawString("PACIENTE:   " & Mid(m_a, 1, 40), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 130)
            g.DrawString("HIST. CLINICA:   " & Mid(m_d, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 120, 130)
            g.DrawString("CEDULA:     " & Mid(m_c, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 145)
            g.DrawString("SERVICIOS:   " & Mid(m_f, 1, 40), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 120, 145)
            g.DrawString("FECHA:      " & Mid(m_urg, 1, 40), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 160)
            g.DrawString("CONVENIO:   " & Mid(m_e, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 120, 160)
            g.DrawString("AFILIACION:   " & Mid(m_h, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 175)
            g.DrawString("OTROS:   " & Mid(m_i, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 120, 175)
            g.DrawString("OBSERVACION:   " & Mid(m_j, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 190)

        ElseIf m_titulo = "KARDEX" Then
            g.DrawString(m_titulo, New Font("Arial", 14, FontStyle.Bold), New SolidBrush(Color.Black), (m_PageWidth / 2) - 50, 95)
            g.DrawString("PRODUCTO:   " & Mid(m_b, 1, 40), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 125)
            g.DrawString("F. Desde: " & Mid(m_a, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 90, 125)
            g.DrawString("BODEGA:   " & Mid(m_c, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), c_LeftMargin, 145)
            g.DrawString("F. Hasta:   " & Mid(m_d, 1, 20), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 90, 145)
            g.DrawString(CStr(numpag), New Font("Arial", 8), New SolidBrush(Color.Black), m_PageWidth / 2, m_PageHeight - 60)
        End If
        'Dibuja el Datagrid

        Dim xPosition1 As Single = 325
        Dim resul As String
        Dim ccont As Integer = 0
        Dim cs As DataGridColumnStyle
        For Each cs In m_DataGrid.TableStyles(0).GridColumnStyles
            If cs.Width > 0 Then
                Dim columnWidth As Integer = cs.Width
                Dim cellBounds As New RectangleF(xPosition, c_TopMargin, columnWidth, m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway)
                Dim cellBounds1 As New RectangleF(xPosition1, c_TopMargin, 50, m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway)
                'Imprime el nombre de la columna
                'JVA 08-DIC-03 CONTROLA LA CABECERA DEL GRID. SI ES LISTA DE RESULTADOS SIMPLEMENTE ESCRIBE EL PEDIDO Y PACIENTE.
                If m_titulo <> "LISTA DE RESULTADOS" Or cs.MappingName = "ped_id" Or cs.MappingName = "paciente" Then
                    g.DrawString(cs.HeaderText, m_DataGrid.HeaderFont, New SolidBrush(Color.Black), cellBounds, cellFormat)
                ElseIf m_titulo = "LISTA DE RESULTADOS" And Trim(Mid(m_c, 1, 20)) = "UROANALISIS" Then
                    Dim yPosition As Single = c_TopMargin + m_DataGrid.HeaderFont.SizeInPoints + (c_VerticalCellLeeway * 2)
                    ccont += 1
                    Select Case ccont
                        Case 1 : resul = "Color"
                        Case 2 : resul = "Aspec."
                        Case 3 : resul = "Dens."
                        Case 4 : resul = "PH"
                        Case 5 : resul = "Leu"
                        Case 6 : resul = "Prot."
                        Case 7 : resul = "Gluc."
                        Case 8 : resul = "Otros"
                    End Select
                    g.DrawString(resul, m_DataGrid.HeaderFont, New SolidBrush(Color.Black), cellBounds1, cellFormat)
                    g.DrawLine(New Pen(m_DataGrid.GridLineColor, 1), xPosition1, yPosition, xPosition1, m_PageHeight - 60)
                    xPosition1 += 75
                    yPosition += m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway + 3
                End If
                'Ajusta la siguiente posicion X
                xPosition += columnWidth
            End If
        Next
    End Sub

    Private Function DrawPageRows(ByVal g As Graphics) As Boolean

        Dim yPosition As Single = c_TopMargin + m_DataGrid.HeaderFont.SizeInPoints + (c_VerticalCellLeeway * 2)

        Dim cellFormat As New StringFormat()
        cellFormat.Trimming = StringTrimming.Word
        cellFormat.FormatFlags = StringFormatFlags.NoWrap Or StringFormatFlags.LineLimit

        Dim i As Integer = 0
        For i = RowCount To (m_dataview.Count - 1)
            Dim ii As Integer = 0
            Dim xPosition As Single = c_LeftMargin + 12

            'Imprime el valor de la celda del datagrid
            Dim cs As DataGridColumnStyle
            For Each cs In m_DataGrid.TableStyles(0).GridColumnStyles
                If cs.Width > 0 Then
                    Dim columnWidth As Integer = cs.Width
                    Dim cellBounds As New RectangleF(xPosition, yPosition, columnWidth, m_DataGrid.Font.SizeInPoints + c_VerticalCellLeeway)

                    'JVA 08-DIC-2003 Sentencia que verifica si es lista de resultados para simplemente desplegar el ID y el Nombre.
                    If m_titulo = "LISTA DE RESULTADOS" Then
                        If cs.MappingName = "ped_id" Or cs.MappingName = "paciente" Then
                            If m_dataview.Item(i).Item(cs.MappingName).GetType() Is GetType(DBNull) Then
                                g.DrawString("", m_DataGrid.Font, New SolidBrush(Color.Black), cellBounds, cellFormat)
                            Else
                                g.DrawString(m_dataview.Item(i).Item(cs.MappingName), m_DataGrid.Font, New SolidBrush(Color.Black), cellBounds, cellFormat)
                            End If
                        End If
                        'g.DrawLine(New Pen(m_DataGrid.GridLineColor, 1), xPosition, yPosition, xPosition, m_PageHeight - 60)
                    Else
                        'Imprime cada dato del datagrid y valida si el dato es Null
                        If m_dataview.Item(i).Item(cs.MappingName).GetType() Is GetType(DBNull) Then
                            g.DrawString("", m_DataGrid.Font, New SolidBrush(Color.Black), cellBounds, cellFormat)
                        Else
                            If cs.MappingName = "precio" Then
                                ' pone los formatos de precio en dos decimales... en recibo.
                                g.DrawString(Format(m_dataview.Item(i).Item(cs.MappingName), "0.00"), m_DataGrid.Font, New SolidBrush(Color.Black), cellBounds, cellFormat)
                            Else
                                g.DrawString(m_dataview.Item(i).Item(cs.MappingName), m_DataGrid.Font, New SolidBrush(Color.Black), cellBounds, cellFormat)
                            End If
                        End If
                    End If

                    'Ajusta la siguiente posicion de X
                    xPosition += columnWidth
                End If
            Next

            'Conteo de las columnas
            RowCount += 1
            'Dibuja la Linea al acabar con cada fila
            'If m_titulo = "RECIBO" Then
            '    g.DrawLine(New Pen(m_DataGrid.GridLineColor, 1), c_LeftMargin, yPosition + m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway - 2, m_PageWidthMinusMargins - 170, yPosition + m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway - 1)
            'Else
            ''g.DrawLine(New Pen(m_DataGrid.GridLineColor, 1), c_LeftMargin, yPosition + m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway - 2, m_PageWidthMinusMargins + c_LeftMargin, yPosition + m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway - 1)
            'End If
            'Ajusta la siguiente posicion Y
            yPosition += m_DataGrid.HeaderFont.SizeInPoints + c_VerticalCellLeeway + 3
            ' Si al final de la pagina continuan los datos, creara otra pagina
            If yPosition * PageNumber > PageNumber * (m_PageHeight - (c_BottomMargin + (c_TopMargin - 90))) Then
                numpag += 1
                Return True
            End If
        Next
        If m_titulo = "RECIBO" Then
            g.DrawString("TOTAL A PAGAR EN DOLARES:   " & Mid(m_b, 1, 20), New Font("Arial", 8, FontStyle.Bold), New SolidBrush(Color.Black), m_PageWidthMinusMargins - 440, yPosition)
        End If
        Return False
    End Function

    Private Function GetDataGridWidth() As Integer
        Try
            Dim cs As DataGridColumnStyle
            Dim dgWidth As Integer = 0
            For Each cs In m_DataGrid.TableStyles(0).GridColumnStyles
                If cs.Width <> 0 Then
                    dgWidth = dgWidth + cs.Width
                End If
            Next
            Return dgWidth
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class


