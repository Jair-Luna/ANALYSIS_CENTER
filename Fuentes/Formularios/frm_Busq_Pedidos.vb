Public Class frm_Busq_Pedidos
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
    Friend WithEvents txt_ped_id As System.Windows.Forms.TextBox
    Friend WithEvents dgrd_pedidos As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents rbtn_turno As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Paciente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_prioridad As System.Windows.Forms.Label
    Friend WithEvents lbl_areas As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Busq_Pedidos))
        Me.dgrd_pedidos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_ped_id = New System.Windows.Forms.TextBox
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.rbtn_turno = New System.Windows.Forms.RadioButton
        Me.rbtn_Paciente = New System.Windows.Forms.RadioButton
        Me.rbtn_pedido = New System.Windows.Forms.RadioButton
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_prioridad = New System.Windows.Forms.Label
        Me.lbl_areas = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrd_pedidos
        '
        Me.dgrd_pedidos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_pedidos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_pedidos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_pedidos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_pedidos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.CaptionText = "ORDENES"
        Me.dgrd_pedidos.DataMember = ""
        Me.dgrd_pedidos.FlatMode = True
        Me.dgrd_pedidos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_pedidos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_pedidos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_pedidos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_pedidos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.Location = New System.Drawing.Point(12, 108)
        Me.dgrd_pedidos.Name = "dgrd_pedidos"
        Me.dgrd_pedidos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_pedidos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.ReadOnly = True
        Me.dgrd_pedidos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_pedidos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.Size = New System.Drawing.Size(697, 239)
        Me.dgrd_pedidos.TabIndex = 1
        Me.dgrd_pedidos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_pedidos
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Turno"
        Me.DataGridTextBoxColumn11.MappingName = "ped_turno"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "dd-MMM-yyyy"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Fecha Ped."
        Me.DataGridTextBoxColumn2.MappingName = "ped_fecing"
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PACIENTE ID"
        Me.DataGridTextBoxColumn3.MappingName = "pac_id"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Paciente"
        Me.DataGridTextBoxColumn4.MappingName = "PACIENTE"
        Me.DataGridTextBoxColumn4.Width = 220
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "PAC FECNAC"
        Me.DataGridTextBoxColumn5.MappingName = "pac_fecnac"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn6.MappingName = "ESTADO"
        Me.DataGridTextBoxColumn6.Width = 150
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "MEDICACION"
        Me.DataGridTextBoxColumn7.MappingName = "ped_medicacion"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "MED_ID"
        Me.DataGridTextBoxColumn8.MappingName = "med_id"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Mdico"
        Me.DataGridTextBoxColumn9.MappingName = "med_nombre"
        Me.DataGridTextBoxColumn9.Width = 120
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "NOTA"
        Me.DataGridTextBoxColumn10.MappingName = "PED_NOTA"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Pedido"
        Me.DataGridTextBoxColumn1.MappingName = "ped_id"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "usa fecha nacimiento"
        Me.DataGridTextBoxColumn12.MappingName = "pac_usafecnac"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "CI"
        Me.DataGridTextBoxColumn13.MappingName = "CI"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Orden MIS"
        Me.DataGridTextBoxColumn14.MappingName = "PED_RECIBO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'txt_ped_id
        '
        Me.txt_ped_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ped_id.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ped_id.Location = New System.Drawing.Point(407, 34)
        Me.txt_ped_id.MaxLength = 8
        Me.txt_ped_id.Name = "txt_ped_id"
        Me.txt_ped_id.Size = New System.Drawing.Size(299, 21)
        Me.txt_ped_id.TabIndex = 0
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(721, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(13, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(140, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "BUSCAR ORDEN"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtn_turno
        '
        Me.rbtn_turno.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_turno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_turno.Location = New System.Drawing.Point(320, 34)
        Me.rbtn_turno.Name = "rbtn_turno"
        Me.rbtn_turno.Size = New System.Drawing.Size(68, 22)
        Me.rbtn_turno.TabIndex = 104
        Me.rbtn_turno.Text = "Turno"
        Me.rbtn_turno.UseVisualStyleBackColor = False
        '
        'rbtn_Paciente
        '
        Me.rbtn_Paciente.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_Paciente.Checked = True
        Me.rbtn_Paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Paciente.Location = New System.Drawing.Point(320, 55)
        Me.rbtn_Paciente.Name = "rbtn_Paciente"
        Me.rbtn_Paciente.Size = New System.Drawing.Size(82, 20)
        Me.rbtn_Paciente.TabIndex = 103
        Me.rbtn_Paciente.TabStop = True
        Me.rbtn_Paciente.Text = "Apellido"
        Me.rbtn_Paciente.UseVisualStyleBackColor = False
        '
        'rbtn_pedido
        '
        Me.rbtn_pedido.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_pedido.Location = New System.Drawing.Point(320, 75)
        Me.rbtn_pedido.Name = "rbtn_pedido"
        Me.rbtn_pedido.Size = New System.Drawing.Size(82, 20)
        Me.rbtn_pedido.TabIndex = 102
        Me.rbtn_pedido.Text = "Cedula"
        Me.rbtn_pedido.UseVisualStyleBackColor = False
        '
        'btn_filtrar
        '
        Me.btn_filtrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtrar.ForeColor = System.Drawing.Color.Black
        Me.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filtrar.Location = New System.Drawing.Point(407, 61)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(213, 41)
        Me.btn_filtrar.TabIndex = 149
        Me.btn_filtrar.Text = "INICIAR BUSQUEDA"
        Me.btn_filtrar.UseVisualStyleBackColor = False
        Me.btn_filtrar.Visible = False
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Black
        Me.lbl_hasta.Location = New System.Drawing.Point(166, 77)
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
        Me.lbl_desde.Location = New System.Drawing.Point(13, 77)
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
        Me.dtp_fi.Location = New System.Drawing.Point(65, 73)
        Me.dtp_fi.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(99, 21)
        Me.dtp_fi.TabIndex = 147
        Me.dtp_fi.Value = New Date(2019, 2, 19, 0, 0, 0, 0)
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ff.Location = New System.Drawing.Point(207, 73)
        Me.dtp_ff.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_ff.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(94, 21)
        Me.dtp_ff.TabIndex = 148
        Me.dtp_ff.Value = New Date(2019, 2, 19, 0, 0, 0, 0)
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(626, 62)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 40)
        Me.btn_cancelar.TabIndex = 153
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "PRIORIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "AREAS::"
        '
        'lbl_prioridad
        '
        Me.lbl_prioridad.AutoSize = True
        Me.lbl_prioridad.Location = New System.Drawing.Point(140, 33)
        Me.lbl_prioridad.Name = "lbl_prioridad"
        Me.lbl_prioridad.Size = New System.Drawing.Size(65, 13)
        Me.lbl_prioridad.TabIndex = 156
        Me.lbl_prioridad.Text = "lbl_prioridad"
        '
        'lbl_areas
        '
        Me.lbl_areas.AutoSize = True
        Me.lbl_areas.Location = New System.Drawing.Point(140, 53)
        Me.lbl_areas.Name = "lbl_areas"
        Me.lbl_areas.Size = New System.Drawing.Size(50, 13)
        Me.lbl_areas.TabIndex = 157
        Me.lbl_areas.Text = "lbl_areas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        '
        'frm_Busq_Pedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(721, 359)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.lbl_areas)
        Me.Controls.Add(Me.lbl_prioridad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.dgrd_pedidos)
        Me.Controls.Add(Me.txt_ped_id)
        Me.Controls.Add(Me.rbtn_turno)
        Me.Controls.Add(Me.rbtn_Paciente)
        Me.Controls.Add(Me.rbtn_pedido)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Busq_Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "C�digo de Formulario"

    

#End Region

    Public frm_refer_main As Frm_Main
    Dim opr_pedido As New Cls_Pedido()
    Dim dts_pedido As DataSet
    Dim dtv_pedido As New DataView()
    'Public CadenaFiltro As String = Nothing
    Public ped_id As String = Nothing
    Public orden As String = Nothing
    Dim arregloAreas As String()
    Dim areas As String = Nothing
    Dim aareas As String = Nothing
    Dim prioridad As String = Nothing
    Dim i As Integer = 0





    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_Busq_Pedidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        'ubica el formulario en el centro del main
        txt_ped_id.Text = ""
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        ''frm_refer_main.Limpia_menu()

        If g_CadenaFiltro <> "" Then
            arregloAreas = Split(g_CadenaFiltro, ",")
            'fechaIni = arregloAreas(0).ToString
            'fechaFin = arregloAreas(1).ToString
            prioridad = arregloAreas(2).ToString
            For i = 3 To UBound(arregloAreas) - 1
                areas = areas & arregloAreas(i) & ","
            Next
            aareas = Mid(areas, 1, areas.Length - 1)
            '''dtv_pedido.Table.Clear()
        End If

        lbl_prioridad.Text = prioridad
        If aareas <> "00" Then
            lbl_areas.Text = opr_pedido.LeerAreas(aareas)
        Else
            lbl_areas.Text = "TODAS"
        End If


        dtp_ff.Value = Format(Now, "dd/MM/yyyy")
        dtp_fi.Value = Format(Now, "dd/MM/yyyy")

        dtp_fi.Value = DateAdd(DateInterval.Day, -28, Now)


        dgrd_pedidos.DataSource = dtv_pedido
        Dim areas_aux As String()
        areas_aux = Split(aareas, ",")
        opr_pedido.LlenarGridValPedidos2(dtv_pedido, dtp_fi.Value.ToString, dtp_ff.Value.ToString, prioridad, Trim(areas_aux(2)))
        txt_ped_id.Focus()
    End Sub

    Private Sub txt_ped_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ped_id.TextChanged
        If rbtn_Paciente.Checked = True Then   'EN CASO DE SER APELLIDOS
            opr_pedido.ordena_pedidoapellido(Trim(txt_ped_id.Text), dtv_pedido)
        ElseIf rbtn_pedido.Checked = True Then 'EN CASO DE SER PEDIDOS
            If txt_ped_id.Text <> "" Then
                If IsNumeric(txt_ped_id.Text) = True Then
                    opr_pedido.ordena_cedula(txt_ped_id.Text, dtv_pedido)
                Else
                    MsgBox("El pedido solo puede ser numerico", MsgBoxStyle.Information, "ANALISYS")
                    txt_ped_id.Text = ""
                End If
            Else
                dtv_pedido.RowFilter = ""
            End If

        Else 'EN CASO DE SER TURNOS
            If txt_ped_id.Text <> "" Then
                If IsNumeric(txt_ped_id.Text) = True Then
                    opr_pedido.ordena_turno(txt_ped_id.Text, dtv_pedido)
                Else
                    MsgBox("El turno solo puede ser numerico", MsgBoxStyle.Information, "ANALISYS")
                    txt_ped_id.Text = ""
                End If
            Else
                dtv_pedido.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub dgrd_pedidos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_pedidos.CurrentCellChanged
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = dgrd_pedidos.CurrentCell.RowNumber
        dgrd_pedidos.CurrentCell = dgc_celda
        dgrd_pedidos.Select(dgrd_pedidos.CurrentCell.RowNumber)


    End Sub

    Private Sub dgrd_pedidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_pedidos.DoubleClick
        On Error Resume Next
        If dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 5) = "VALIDADO COMPLETO" Then
            'If (MsgBox("ADVERTENCIA: El pedido ya esta VALIDADO, desea continuar?.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ANALISYS")) Then
            If dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 10) <> "" Then
                orden = dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 0)
            Else
                MsgBox("No ha seleccionado ningun paciente.", MsgBoxStyle.Exclamation, "ANALISYS")
            End If
            Me.Close()
            'End If

        Else
            If dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 10) <> "" Then
                orden = dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 0)
            Else
                MsgBox("No ha seleccionado ningun paciente.", MsgBoxStyle.Exclamation, "ANALISYS")
            End If
            Me.Close()
        End If


    End Sub

    Private Sub rbtn_Paciente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_Paciente.CheckedChanged
        If rbtn_Paciente.Checked = True Then
            rbtn_pedido.Checked = False
            txt_ped_id.MaxLength = 40
        End If
        txt_ped_id.Text = ""
        txt_ped_id.Focus()
    End Sub

    Private Sub rbtn_pedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_pedido.CheckedChanged
        If rbtn_pedido.Checked = True Then
            rbtn_Paciente.Checked = False
            txt_ped_id.MaxLength = 5
        End If
        txt_ped_id.Text = ""
        txt_ped_id.Focus()

    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click


        Me.Cursor = Cursors.WaitCursor
        dtp_ff.Value = Format(dtp_ff.Value, "dd/MM/yyyy")
        dtp_fi.Value = Format(dtp_fi.Value, "dd/MM/yyyy")
        If dtp_ff.Value < dtp_fi.Value Then
            MsgBox("La Fecha Final no puede ser menor a la Fecha Inicial", MsgBoxStyle.OkOnly, "ANALISYS")
        Else
            opr_pedido.LlenarGridValPedidos2(dtv_pedido, dtp_fi.Text, dtp_ff.Text, prioridad, areas)
        End If
        txt_ped_id.Text = ""
        txt_ped_id.Focus()
        Me.Cursor = Cursors.Default
    End Sub

   

    Private Sub dtp_fi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fi.ValueChanged
        Me.Cursor = Cursors.WaitCursor
        'dtp_ff.Value = Format(dtp_ff.Value, "dd/MM/yyyy")
        'dtp_fi.Value = Format(dtp_fi.Value, "dd/MM/yyyy")


        If dtp_ff.Value < dtp_fi.Value Then
            MsgBox("La Fecha Final no puede ser menor a la Fecha Inicial", MsgBoxStyle.OkOnly, "ANALISYS")
        Else
            opr_pedido.LlenarGridValPedidos2(dtv_pedido, dtp_fi.Value, dtp_ff.Value, prioridad, areas)
        End If
        txt_ped_id.Text = ""
        txt_ped_id.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dtp_ff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_ff.ValueChanged
        Me.Cursor = Cursors.WaitCursor
        'dtp_ff.Value = Format(dtp_ff.Value, "dd/MM/yyyy")
        'dtp_fi.Value = Format(dtp_fi.Value, "dd/MM/yyyy")

        If dtp_ff.Value < dtp_fi.Value Then
            MsgBox("La Fecha Final no puede ser menor a la Fecha Inicial", MsgBoxStyle.OkOnly, "ANALISYS")
        Else
            opr_pedido.LlenarGridValPedidos2(dtv_pedido, dtp_fi.Value, dtp_ff.Value, prioridad, areas)
        End If
        txt_ped_id.Text = ""
        txt_ped_id.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
