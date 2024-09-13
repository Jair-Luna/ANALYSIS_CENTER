Public Class frm_i_movReporte
    Inherits System.Windows.Forms.Form
    Private m_cls_dgimpresion As cls_dgimpresion = Nothing

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents dgrd_movreportes As System.Windows.Forms.DataGrid
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmb_tipomov As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_prod As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_movReporte))
        Me.dgrd_movreportes = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_filtro = New System.Windows.Forms.ComboBox
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.cmb_tipomov = New System.Windows.Forms.ComboBox
        Me.txt_prod = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.dgrd_movreportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrd_movreportes
        '
        Me.dgrd_movreportes.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_movreportes.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_movreportes.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_movreportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_movreportes.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_movreportes.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_movreportes.CaptionText = "Reporte de Movimientos"
        Me.dgrd_movreportes.DataMember = ""
        Me.dgrd_movreportes.FlatMode = True
        Me.dgrd_movreportes.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_movreportes.ForeColor = System.Drawing.Color.Black
        Me.dgrd_movreportes.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_movreportes.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_movreportes.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_movreportes.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_movreportes.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_movreportes.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_movreportes.Location = New System.Drawing.Point(16, 131)
        Me.dgrd_movreportes.Name = "dgrd_movreportes"
        Me.dgrd_movreportes.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_movreportes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_movreportes.ReadOnly = True
        Me.dgrd_movreportes.RowHeaderWidth = 10
        Me.dgrd_movreportes.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_movreportes.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_movreportes.Size = New System.Drawing.Size(696, 485)
        Me.dgrd_movreportes.TabIndex = 67
        Me.dgrd_movreportes.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_movreportes.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_movreportes
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "N. Mov."
        Me.DataGridTextBoxColumn1.MappingName = "i_mov_id"
        Me.DataGridTextBoxColumn1.Width = 45
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "T.Mov"
        Me.DataGridTextBoxColumn9.MappingName = "I_TIM_ID"
        Me.DataGridTextBoxColumn9.Width = 35
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "F. Documento"
        Me.DataGridTextBoxColumn10.MappingName = "I_MOV_FECDOC"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Factura"
        Me.DataGridTextBoxColumn11.MappingName = "I_MOV_DOC"
        Me.DataGridTextBoxColumn11.Width = 130
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "ID. PRD."
        Me.DataGridTextBoxColumn3.MappingName = "I_PRD_ID"
        Me.DataGridTextBoxColumn3.Width = 95
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "I_PRD_DESCRIPCION"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 190
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Bodega"
        Me.DataGridTextBoxColumn4.MappingName = "I_BOD_ID"
        Me.DataGridTextBoxColumn4.Width = 55
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Lote"
        Me.DataGridTextBoxColumn5.MappingName = "I_MOD_LOTE"
        Me.DataGridTextBoxColumn5.Width = 55
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn6.MappingName = "I_MOD_DESCRIPCION"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridTextBoxColumn7.MappingName = "I_mod_Cantidad"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Fec. Venc."
        Me.DataGridTextBoxColumn8.MappingName = "I_mod_fecven"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(539, 62)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 24)
        Me.btn_imprimir.TabIndex = 95
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(625, 62)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancelar.TabIndex = 94
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Busqueda por:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Items.AddRange(New Object() {"Tipo de Movimiento", "Movimiento", "Código de Producto", "Factura", "Bodega"})
        Me.cmb_filtro.Location = New System.Drawing.Point(114, 32)
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(142, 21)
        Me.cmb_filtro.TabIndex = 1
        Me.cmb_filtro.TabStop = False
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(274, 32)
        Me.txt_filtro.MaxLength = 50
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(226, 21)
        Me.txt_filtro.TabIndex = 3
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Reporte De Movimientos"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Black
        Me.lbl_hasta.Location = New System.Drawing.Point(65, 95)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(46, 16)
        Me.lbl_hasta.TabIndex = 140
        Me.lbl_hasta.Text = "Hasta:"
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Black
        Me.lbl_desde.Location = New System.Drawing.Point(65, 69)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(46, 16)
        Me.lbl_desde.TabIndex = 139
        Me.lbl_desde.Text = "Desde:"
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fi.Location = New System.Drawing.Point(115, 63)
        Me.dtp_fi.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(88, 21)
        Me.dtp_fi.TabIndex = 5
        Me.dtp_fi.Value = New Date(2003, 8, 13, 15, 32, 45, 171)
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ff.Location = New System.Drawing.Point(115, 90)
        Me.dtp_ff.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_ff.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(86, 21)
        Me.dtp_ff.TabIndex = 6
        Me.dtp_ff.Value = New Date(2003, 8, 13, 15, 32, 45, 203)
        '
        'cmb_tipomov
        '
        Me.cmb_tipomov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipomov.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipomov.Location = New System.Drawing.Point(262, 31)
        Me.cmb_tipomov.Name = "cmb_tipomov"
        Me.cmb_tipomov.Size = New System.Drawing.Size(238, 22)
        Me.cmb_tipomov.TabIndex = 2
        '
        'txt_prod
        '
        Me.txt_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_prod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod.Location = New System.Drawing.Point(506, 32)
        Me.txt_prod.MaxLength = 50
        Me.txt_prod.Name = "txt_prod"
        Me.txt_prod.Size = New System.Drawing.Size(199, 21)
        Me.txt_prod.TabIndex = 4
        Me.txt_prod.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 25)
        Me.Panel1.TabIndex = 171
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(8, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "REPORTE DE MOVIMIENTOS"
        '
        'frm_i_movReporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(728, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_prod)
        Me.Controls.Add(Me.cmb_tipomov)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_filtro)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dgrd_movreportes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_i_movReporte"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "1"
        Me.Text = "Reporte de Movimientos"
        CType(Me.dgrd_movreportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Código de Formulario"
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseEnter, btn_imprimir.MouseEnter

        'cuando el mouse se mueve por encima del los botones del formulario
        Select Case sender.name
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_closep") Then
                    imageToDraw = CType(m_HtImages("btn_closep"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_closep.jpg")
                        m_HtImages.Add("btn_closep", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Bold)
                    sender.forecolor = Color.White
                    If m_HtImages.ContainsKey("barraMenu1") Then
                        imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
                            m_HtImages.Add("barraMenu1", imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                    sender.BackgroundImage = imageToDraw
                End If
        End Select
    End Sub

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseLeave, btn_imprimir.MouseLeave
        'cuando el mouse se pierde el enfoque del los botones del formulario
        Select Case sender.name
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_close") Then
                    imageToDraw = CType(m_HtImages("btn_close"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_close.jpg")
                        m_HtImages.Add("btn_close", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Regular)
                    sender.forecolor = Color.Black
                    If m_HtImages.ContainsKey("barraMenu2") Then
                        imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
                            m_HtImages.Add("barraMenu2", imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                    sender.BackgroundImage = imageToDraw
                End If
        End Select
    End Sub

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub


#End Region

    Public frm_refer_main As Frm_Main
    Dim opr_i_bodega As New Cls_i_Bodega()
    Dim opr_producto As New Cls_i_Producto()
    Private opr_repmov As New Cls_i_Movimiento()
    Dim dtv_rpmov As New DataView()


    Function campofiltro() As String
        Select Case cmb_filtro.Text
            Case "Tipo de Movimiento"
                campofiltro = "i_tim_id"
            Case "Código de Producto"
                campofiltro = "i_prd_id"
            Case "Factura"
                campofiltro = "i_mov_doc"
            Case "Bodega"
                campofiltro = "I_BOD_ID"
            Case "Movimiento"
                campofiltro = "i_mov_id"

        End Select
    End Function

    Private Sub frm_movReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        cmb_filtro.SelectedIndex = 0
        'Verifico si el usuario pertenece a una division especifica.
        'If g_division = 0 Then
        '    opr_i_bodega.LlenarCombodivision(cmb_divisiones)
        'Else
        '    opr_i_bodega.LlenarCombodivision(cmb_divisiones)
        '    cmb_divisiones.Enabled = False
        '    cmb_divisiones.SelectedIndex = g_division - 1
        'opr_i_bodega.LlenarComboBodega(cmb_bodega, g_division)
        'End If
        Dim MyDate As Date
        MyDate = DateSerial(Year(Today), Month(Today), 1)     'Retorna una fecha
        dtp_fi.Text = MyDate
        dtp_ff.Text = Today
        dgrd_movreportes.DataSource = dtv_rpmov
        opr_repmov.LlenarRepMov(g_division, dtv_rpmov, dtp_fi.Value, dtp_ff.Value)

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    'Private Sub cmb_divisiones_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    opr_i_bodega.LlenarComboBodega(cmb_bodega, CInt(Trim(Mid(cmb_divisiones.SelectedItem, 50))))
    'End Sub


    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        'cuando presiono una tecla mando hacer un filtro 
        If cmb_filtro.Text <> "Tipo de Movimiento" Then opr_producto.ordena_producto(campofiltro, txt_filtro.Text, dtv_rpmov)
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Dim titulo As String = "REPORTE DE MOVIMIENTOS"
        Me.Cursor = Cursors.WaitCursor
        Try
            m_cls_dgimpresion = New cls_dgimpresion(dgrd_movreportes, PrintDocument1, dtv_rpmov, , , , , , titulo)
            PrintPreviewDialog1.ShowDialog()
            Me.Refresh()
        Catch iex As System.Drawing.Printing.InvalidPrinterException
            MsgBox("Error En la Impresora", MsgBoxStyle.Exclamation, "ANALISYS")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.Text = "REPORTE DE MOVIMIENTOS"
        PrintPreviewDialog1.Icon = CType(Me.Icon, System.Drawing.Icon)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Control de paginas. en el caso que exista mas de una hoja
        e.HasMorePages = m_cls_dgimpresion.DrawDataGrid(e.Graphics)
        If e.HasMorePages Then
            m_cls_dgimpresion.PageNumber += 1
        Else
            m_cls_dgimpresion.PageNumber = 1
            m_cls_dgimpresion.RowCount = 0
        End If
    End Sub

    Private Sub dtp_fi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fi.ValueChanged
        opr_repmov.LlenarRepMov(g_division, dtv_rpmov, dtp_fi.Value, dtp_ff.Value)
    End Sub

    Private Sub dtp_ff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_ff.ValueChanged
        opr_repmov.LlenarRepMov(g_division, dtv_rpmov, dtp_fi.Value, dtp_ff.Value)
    End Sub

    Private Sub cmb_filtro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_filtro.SelectedIndexChanged

        If cmb_filtro.Text = "Tipo de Movimiento" Then
            cmb_tipomov.Visible = True
            txt_filtro.Visible = False
            txt_prod.Visible = True
            opr_repmov.LlenarCombotipmov(cmb_tipomov)
        Else
            txt_filtro.Visible = True
            cmb_tipomov.Visible = False
            txt_prod.Visible = False
        End If
        txt_filtro.Text = ""
        txt_prod.Text = ""
        dtv_rpmov.RowFilter = ""
    End Sub

    Private Sub cmb_tipomov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipomov.SelectedIndexChanged
        If cmb_filtro.Text = "Tipo de Movimiento" Then
            opr_producto.ordena_producto(campofiltro, Mid(cmb_tipomov.Text, 1, 10), dtv_rpmov)
            txt_prod.Text = ""
        End If
    End Sub

    Private Sub txt_prod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_prod.TextChanged
        opr_producto.ordena_producto_mov(campofiltro, txt_prod.Text, Mid(cmb_tipomov.Text, 1, 10), dtv_rpmov)
    End Sub
End Class
