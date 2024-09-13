'*************************************************************************
' Nombre:   frm_Pedido2
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite seleccionar un pedido
'               para poder modificarlo
' Autores:  rfn, Jorge Paz
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_Pedido2
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_filtro_apellido As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_seleccionar As System.Windows.Forms.MenuItem
    Friend WithEvents Dgrd_pedido As System.Windows.Forms.DataGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents rbtn_apellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbtn_turno As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pedido2))
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Dgrd_pedido = New System.Windows.Forms.DataGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.Menu_seleccionar = New System.Windows.Forms.MenuItem
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_filtro_apellido = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.rbtn_apellido = New System.Windows.Forms.RadioButton
        Me.rbtn_pedido = New System.Windows.Forms.RadioButton
        Me.rbtn_turno = New System.Windows.Forms.RadioButton
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.Dgrd_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(504, 348)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 35)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Tag = "1"
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Salir de esta ventana")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Dgrd_pedido
        '
        Me.Dgrd_pedido.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_pedido.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_pedido.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_pedido.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_pedido.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_pedido.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_pedido.CaptionText = "PEDIDOS"
        Me.Dgrd_pedido.ContextMenu = Me.ContextMenu1
        Me.Dgrd_pedido.DataMember = ""
        Me.Dgrd_pedido.FlatMode = True
        Me.Dgrd_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_pedido.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_pedido.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_pedido.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_pedido.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_pedido.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_pedido.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_pedido.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_pedido.Location = New System.Drawing.Point(8, 62)
        Me.Dgrd_pedido.Name = "Dgrd_pedido"
        Me.Dgrd_pedido.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_pedido.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_pedido.ParentRowsVisible = False
        Me.Dgrd_pedido.PreferredColumnWidth = 100
        Me.Dgrd_pedido.ReadOnly = True
        Me.Dgrd_pedido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_pedido.RowHeaderWidth = 0
        Me.Dgrd_pedido.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_pedido.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_pedido.Size = New System.Drawing.Size(576, 278)
        Me.Dgrd_pedido.TabIndex = 15
        Me.Dgrd_pedido.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_pedido.TabStop = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_seleccionar})
        '
        'Menu_seleccionar
        '
        Me.Menu_seleccionar.Index = 0
        Me.Menu_seleccionar.Text = "Seleccionar"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_pedido
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Pedido"
        Me.DataGridTextBoxColumn1.MappingName = "ped_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Turno"
        Me.DataGridTextBoxColumn6.MappingName = "ped_turno"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn2.MappingName = "ped_fecing"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 105
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridTextBoxColumn3.MappingName = "pac_apellido"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 130
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nombres"
        Me.DataGridTextBoxColumn4.MappingName = "pac_nombre"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 130
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "ped_tipo"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "H.C."
        Me.DataGridTextBoxColumn7.MappingName = "pac_hist_clinica"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 5
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Recibo"
        Me.DataGridTextBoxColumn8.MappingName = "ped_recibo"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 45
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = "$#0.00"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Total"
        Me.DataGridTextBoxColumn9.MappingName = "total"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 55
        '
        'txt_filtro_apellido
        '
        Me.txt_filtro_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro_apellido.Location = New System.Drawing.Point(244, 32)
        Me.txt_filtro_apellido.MaxLength = 50
        Me.txt_filtro_apellido.Name = "txt_filtro_apellido"
        Me.txt_filtro_apellido.Size = New System.Drawing.Size(176, 21)
        Me.txt_filtro_apellido.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_filtro_apellido, "Ingrese el apellido del paciente")
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(422, 348)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 35)
        Me.btn_imprimir.TabIndex = 153
        Me.btn_imprimir.Tag = "1"
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_imprimir, "Salir de esta ventana")
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(593, 25)
        Me.pan_barra.TabIndex = 96
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(6, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(129, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "EDITAR PEDIDO"
        '
        'rbtn_apellido
        '
        Me.rbtn_apellido.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_apellido.Location = New System.Drawing.Point(76, 32)
        Me.rbtn_apellido.Name = "rbtn_apellido"
        Me.rbtn_apellido.Size = New System.Drawing.Size(72, 22)
        Me.rbtn_apellido.TabIndex = 7
        Me.rbtn_apellido.Text = "Apellido"
        Me.rbtn_apellido.UseVisualStyleBackColor = False
        '
        'rbtn_pedido
        '
        Me.rbtn_pedido.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_pedido.Location = New System.Drawing.Point(144, 32)
        Me.rbtn_pedido.Name = "rbtn_pedido"
        Me.rbtn_pedido.Size = New System.Drawing.Size(96, 22)
        Me.rbtn_pedido.TabIndex = 8
        Me.rbtn_pedido.Text = "Hist. Clinica"
        Me.rbtn_pedido.UseVisualStyleBackColor = False
        '
        'rbtn_turno
        '
        Me.rbtn_turno.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_turno.Checked = True
        Me.rbtn_turno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_turno.Location = New System.Drawing.Point(16, 32)
        Me.rbtn_turno.Name = "rbtn_turno"
        Me.rbtn_turno.Size = New System.Drawing.Size(56, 22)
        Me.rbtn_turno.TabIndex = 6
        Me.rbtn_turno.TabStop = True
        Me.rbtn_turno.Text = "Turno"
        Me.rbtn_turno.UseVisualStyleBackColor = False
        '
        'btn_filtrar
        '
        Me.btn_filtrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtrar.ForeColor = System.Drawing.Color.Black
        Me.btn_filtrar.Image = CType(resources.GetObject("btn_filtrar.Image"), System.Drawing.Image)
        Me.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filtrar.Location = New System.Drawing.Point(288, 5)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(70, 32)
        Me.btn_filtrar.TabIndex = 5
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filtrar.UseVisualStyleBackColor = False
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Black
        Me.lbl_hasta.Location = New System.Drawing.Point(140, 15)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(46, 16)
        Me.lbl_hasta.TabIndex = 151
        Me.lbl_hasta.Text = "Hasta:"
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Black
        Me.lbl_desde.Location = New System.Drawing.Point(4, 15)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(46, 16)
        Me.lbl_desde.TabIndex = 150
        Me.lbl_desde.Text = "Desde:"
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fi.Location = New System.Drawing.Point(52, 11)
        Me.dtp_fi.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(84, 21)
        Me.dtp_fi.TabIndex = 3
        Me.dtp_fi.Value = New Date(2003, 8, 13, 15, 32, 45, 171)
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ff.Location = New System.Drawing.Point(192, 11)
        Me.dtp_ff.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_ff.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(86, 21)
        Me.dtp_ff.TabIndex = 4
        Me.dtp_ff.Value = New Date(2003, 8, 13, 15, 32, 45, 203)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.dtp_ff)
        Me.Panel1.Controls.Add(Me.dtp_fi)
        Me.Panel1.Controls.Add(Me.lbl_hasta)
        Me.Panel1.Controls.Add(Me.lbl_desde)
        Me.Panel1.Controls.Add(Me.btn_filtrar)
        Me.Panel1.Location = New System.Drawing.Point(8, 346)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 48)
        Me.Panel1.TabIndex = 152
        '
        'frm_Pedido2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(593, 395)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbtn_turno)
        Me.Controls.Add(Me.rbtn_pedido)
        Me.Controls.Add(Me.rbtn_apellido)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.txt_filtro_apellido)
        Me.Controls.Add(Me.Dgrd_pedido)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Pedido2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar pedido"
        CType(Me.Dgrd_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "C�digo de Formulario"
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseEnter, btn_filtrar.MouseEnter, btn_imprimir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseLeave, btn_filtrar.MouseLeave, btn_imprimir.MouseLeave
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
    Dim frm_refer_main_form As Frm_Main
    Dim opr_pedido As New Cls_Pedido()
    Dim dtv_pedido As New DataView()

    Private Sub frm_Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        Me.Cursor = Cursors.WaitCursor
        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        Dgrd_pedido.DataSource = dtv_pedido
        'lleno el grid con los datos de los pedidos
        'opr_pedido.LlenarGridPedido(dtv_pedido)
        dtp_fi.Value = DateAdd(DateInterval.Day, -1, Now)
        dtp_ff.Value = Now
        opr_pedido.LlenarGridPedido(dtv_pedido, dtp_fi.Text, dtp_ff.Text)
        txt_filtro_apellido.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub Dgrd_paciente_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_pedido.CurrentCellChanged
        'selecciono toda la filadel grid
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 2
        dgc_celda.RowNumber = Dgrd_pedido.CurrentCell.RowNumber
        Dgrd_pedido.CurrentCell = dgc_celda
        Dgrd_pedido.Select(Dgrd_pedido.CurrentCell.RowNumber)
    End Sub

    Private Sub txt_filtro_apellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro_apellido.TextChanged
        'aplico un fitro a los pedidos meidante el apellido del los pacientes
        'cada vez que e presiona una tecla
        'JVA 14-ENE-2004 FILTRO DE TURNOS
        If rbtn_apellido.Checked = True Then   'EN CASO DE SER APELLIDOS
            opr_pedido.ordena_apellido(txt_filtro_apellido.Text, dtv_pedido)
        ElseIf rbtn_pedido.Checked = True Then 'EN CASO DE SER PEDIDOS
            If txt_filtro_apellido.Text <> "" Then
                opr_pedido.ordena_hclinica(txt_filtro_apellido.Text, dtv_pedido)
            Else
                dtv_pedido.RowFilter = ""
            End If
        Else 'EN CASO DE SER TURNOS
            If txt_filtro_apellido.Text <> "" Then
                If IsNumeric(txt_filtro_apellido.Text) = True Then
                    opr_pedido.ordena_turno(txt_filtro_apellido.Text, dtv_pedido)
                Else
                    MsgBox("El turno solo puede ser num�rico", MsgBoxStyle.Information, "ANALISYS")
                    txt_filtro_apellido.Text = ""
                End If
            Else
                dtv_pedido.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub Selecciona_Paciente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_pedido.DoubleClick, Menu_seleccionar.Click
        'una vez que se ha seleccioando el pedido se pasa el formulario donde se despleiga
        'a detalle el pedido para porder ser modificado
        On Error Resume Next
        Dim frm_MDIChild As New frm_Pedido()
        Me.Close()
        frm_MDIChild.Tag = Dgrd_pedido.Item(Dgrd_pedido.CurrentCell.RowNumber, 0).ToString
        frm_refer_main.Crea_formulario(frm_MDIChild, frm_refer_main)
    End Sub

    Private Sub rbtn_apellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_apellido.CheckedChanged
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()
    End Sub

    Private Sub rbtn_pedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_pedido.CheckedChanged
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()
    End Sub

    Private Sub rbtn_turno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_turno.CheckedChanged
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()
    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Me.Cursor = Cursors.WaitCursor
        dtp_ff.Value = Format(dtp_ff.Value, "dd/MM/yyyy")
        dtp_fi.Value = Format(dtp_fi.Value, "dd/MM/yyyy")
        If dtp_ff.Value < dtp_fi.Value Then
            MsgBox("La Fecha Final no puede ser menor a la Fecha Inicial", MsgBoxStyle.OkOnly, "ANALISYS")
        Else
            opr_pedido.LlenarGridPedido(dtv_pedido, dtp_fi.Text, dtp_ff.Text)
        End If
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        '16 jun 2006 JPO
        'REPORTE DE PEDIDOS E INGRESOS.
        Dim str_sql As String
        Me.Cursor = Cursors.WaitCursor
        frm_refer_main.escribemsj("GENERANDO REPORTE, UN MOMENTO.... ")
        Dim obj_reporte As New rpt_IngresosPedido()
        'turno
        If Me.rbtn_turno.Checked = True And Me.txt_filtro_apellido.Text <> "" Then
            If IsNumeric(txt_filtro_apellido.Text) = True Then
                str_sql = "select p.ped_id, p.con_nombre, p.ped_fecing, pdd.tes_id, lp.lip_precio, " & _
                "'" & Format(dtp_fi.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_ff.Value, "dd/MM/yyyy") & _
                "' AS FECHAF , concat(pac.pac_apellido, ' ', pac.pac_nombre) as paciente, p.ped_turno as turno, " & _
                "pac.pac_hist_clinica, p.ped_tipo as tipo, pac_parentesco, pac_grado, ped_recibo " & _
                "from pedido as p, pedido_detalle_desglosado as pdd, lista_precio as lp , paciente as pac " & _
                "where " & _
                "p.ped_turno = " & Trim(CInt(txt_filtro_apellido.Text)) & " and p.pac_id = pac.pac_id and p.ped_id = pdd.ped_id And p.con_nombre = lp.con_nombre " & _
                "and pdd.tes_id = lp.tes_id and " & _
                "p.ped_fecing between '" & Format(dtp_fi.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_ff.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                "order by con_nombre, ped_id"
            Else
                MsgBox("Par�metro insertado no v�lido", MsgBoxStyle.Information, "ANALISYS")
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

        End If
        'apellido
        If Me.rbtn_apellido.Checked = True And Me.txt_filtro_apellido.Text <> "" Then
            str_sql = "select p.ped_id, p.con_nombre, p.ped_fecing, pdd.tes_id, lp.lip_precio, " & _
                "'" & Format(dtp_fi.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_ff.Value, "dd/MM/yyyy") & _
                "' AS FECHAF , concat(pac.pac_apellido, ' ', pac.pac_nombre) as paciente, p.ped_turno as turno, " & _
                "pac.pac_hist_clinica, p.ped_tipo as tipo, pac_parentesco, pac_grado, ped_recibo " & _
                "from pedido as p, pedido_detalle_desglosado as pdd, lista_precio as lp , paciente as pac " & _
                "where " & _
                "pac.pac_apellido = '" & Trim(txt_filtro_apellido.Text) & "' and p.pac_id = pac.pac_id and p.ped_id = pdd.ped_id And p.con_nombre = lp.con_nombre " & _
                "and pdd.tes_id = lp.tes_id and " & _
                "p.ped_fecing between '" & Format(dtp_fi.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_ff.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                "order by con_nombre, ped_id"
        End If
        'HC
        If Me.rbtn_pedido.Checked = True And Me.txt_filtro_apellido.Text <> "" Then
            str_sql = "select p.ped_id, p.con_nombre, p.ped_fecing, pdd.tes_id, lp.lip_precio, " & _
                "'" & Format(dtp_fi.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_ff.Value, "dd/MM/yyyy") & _
                "' AS FECHAF , concat(pac.pac_apellido, ' ', pac.pac_nombre) as paciente, p.ped_turno as turno, " & _
                "pac.pac_hist_clinica, p.ped_tipo as tipo, pac_parentesco, pac_grado, ped_recibo " & _
                "from pedido as p, pedido_detalle_desglosado as pdd, lista_precio as lp , paciente as pac " & _
                "where " & _
                "pac.pac_hist_clinica = '" & Trim(txt_filtro_apellido.Text) & "' and p.pac_id = pac.pac_id and p.ped_id = pdd.ped_id And p.con_nombre = lp.con_nombre " & _
                "and pdd.tes_id = lp.tes_id and " & _
                "p.ped_fecing between '" & Format(dtp_fi.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_ff.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                "order by con_nombre, ped_id"
        End If
        If txt_filtro_apellido.Text = "" Then
            str_sql = "select p.ped_id, p.con_nombre, p.ped_fecing, pdd.tes_id, lp.lip_precio, " & _
            "'" & Format(dtp_fi.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_ff.Value, "dd/MM/yyyy") & _
            "' AS FECHAF , concat(pac.pac_apellido, ' ', pac.pac_nombre) as paciente, p.ped_turno as turno, " & _
            "pac.pac_hist_clinica, p.ped_tipo as tipo, pac_parentesco, pac_grado, ped_recibo " & _
            "from pedido as p, pedido_detalle_desglosado as pdd, lista_precio as lp , paciente as pac " & _
            "where " & _
            "p.pac_id = pac.pac_id and p.ped_id = pdd.ped_id And p.con_nombre = lp.con_nombre " & _
            "and pdd.tes_id = lp.tes_id and " & _
            "p.ped_fecing between '" & Format(dtp_fi.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_ff.Value, "dd/MM/yyyy") & " 23:59:59' " & _
            "order by con_nombre, ped_id"
        End If

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
        frm_MDIChild.int_alto = frm_refer_main.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main.mdiClient1.Width
        frm_MDIChild.Text = "Reporte de ingresos por pedidos"
        'Me.Close()
        frm_refer_main.Crea_formulario(frm_MDIChild)
        Me.Cursor = Cursors.Arrow
        frm_refer_main.escribemsj("DISPONIBLE")
    End Sub

End Class