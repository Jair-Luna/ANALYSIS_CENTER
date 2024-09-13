Public Class frm_PedFac
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
    Friend WithEvents dgrd_Pedido As System.Windows.Forms.DataGrid
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents rad_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents rad_paciente As System.Windows.Forms.RadioButton
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
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rad_turno As System.Windows.Forms.RadioButton
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rad_cedula As System.Windows.Forms.RadioButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PedFac))
        Me.rad_pedido = New System.Windows.Forms.RadioButton
        Me.rad_paciente = New System.Windows.Forms.RadioButton
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.dgrd_Pedido = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.rad_turno = New System.Windows.Forms.RadioButton
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.rad_cedula = New System.Windows.Forms.RadioButton
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        CType(Me.dgrd_Pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rad_pedido
        '
        Me.rad_pedido.BackColor = System.Drawing.Color.Transparent
        Me.rad_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_pedido.Location = New System.Drawing.Point(159, 150)
        Me.rad_pedido.Name = "rad_pedido"
        Me.rad_pedido.Size = New System.Drawing.Size(64, 16)
        Me.rad_pedido.TabIndex = 1
        Me.rad_pedido.Text = "Pedido"
        Me.rad_pedido.UseVisualStyleBackColor = False
        Me.rad_pedido.Visible = False
        '
        'rad_paciente
        '
        Me.rad_paciente.BackColor = System.Drawing.Color.Transparent
        Me.rad_paciente.Checked = True
        Me.rad_paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_paciente.Location = New System.Drawing.Point(320, 57)
        Me.rad_paciente.Name = "rad_paciente"
        Me.rad_paciente.Size = New System.Drawing.Size(72, 16)
        Me.rad_paciente.TabIndex = 2
        Me.rad_paciente.TabStop = True
        Me.rad_paciente.Text = "Apellido"
        Me.rad_paciente.UseVisualStyleBackColor = False
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(412, 32)
        Me.txt_filtro.MaxLength = 50
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(299, 21)
        Me.txt_filtro.TabIndex = 0
        '
        'dgrd_Pedido
        '
        Me.dgrd_Pedido.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Pedido.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Pedido.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Pedido.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Pedido.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Pedido.CaptionText = "PEDIDOS VALIDADOS"
        Me.dgrd_Pedido.DataMember = ""
        Me.dgrd_Pedido.FlatMode = True
        Me.dgrd_Pedido.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_Pedido.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Pedido.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Pedido.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Pedido.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Pedido.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Pedido.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Pedido.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Pedido.Location = New System.Drawing.Point(12, 105)
        Me.dgrd_Pedido.Name = "dgrd_Pedido"
        Me.dgrd_Pedido.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Pedido.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Pedido.ReadOnly = True
        Me.dgrd_Pedido.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Pedido.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Pedido.Size = New System.Drawing.Size(699, 239)
        Me.dgrd_Pedido.TabIndex = 3
        Me.dgrd_Pedido.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Pedido
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Pedido"
        Me.DataGridTextBoxColumn1.MappingName = "ped_id"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Turno"
        Me.DataGridTextBoxColumn11.MappingName = "ped_turno"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "dd-MMM-yyyy"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn2.MappingName = "ped_fecing"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PAC ID"
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
        Me.DataGridTextBoxColumn6.HeaderText = "Antecedente"
        Me.DataGridTextBoxColumn6.MappingName = "ped_antecedente"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "medicacion"
        Me.DataGridTextBoxColumn7.MappingName = "ped_medicacion"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "med_id"
        Me.DataGridTextBoxColumn8.MappingName = "med_id"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Mdico"
        Me.DataGridTextBoxColumn9.MappingName = "med_nombre"
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "NOTAS"
        Me.DataGridTextBoxColumn10.MappingName = "ped_nota"
        Me.DataGridTextBoxColumn10.Width = 0
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
        Me.DataGridTextBoxColumn13.HeaderText = "C.I."
        Me.DataGridTextBoxColumn13.MappingName = "CI"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = "Remitido"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Remitido"
        Me.DataGridTextBoxColumn14.Width = 20
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(723, 25)
        Me.pan_barra.TabIndex = 93
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(6, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(176, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "BUSCAR RESULTADOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rad_turno
        '
        Me.rad_turno.BackColor = System.Drawing.Color.Transparent
        Me.rad_turno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_turno.Location = New System.Drawing.Point(320, 36)
        Me.rad_turno.Name = "rad_turno"
        Me.rad_turno.Size = New System.Drawing.Size(64, 16)
        Me.rad_turno.TabIndex = 95
        Me.rad_turno.Text = "Turno"
        Me.rad_turno.UseVisualStyleBackColor = False
        '
        'btn_filtrar
        '
        Me.btn_filtrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtrar.ForeColor = System.Drawing.Color.Black
        Me.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filtrar.Location = New System.Drawing.Point(412, 59)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(211, 39)
        Me.btn_filtrar.TabIndex = 154
        Me.btn_filtrar.Text = "INICIAR BUSQUEDA"
        Me.btn_filtrar.UseVisualStyleBackColor = False
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Black
        Me.lbl_hasta.Location = New System.Drawing.Point(162, 78)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(46, 16)
        Me.lbl_hasta.TabIndex = 156
        Me.lbl_hasta.Text = "Hasta:"
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Black
        Me.lbl_desde.Location = New System.Drawing.Point(14, 78)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(46, 16)
        Me.lbl_desde.TabIndex = 155
        Me.lbl_desde.Text = "Desde:"
        '
        'rad_cedula
        '
        Me.rad_cedula.BackColor = System.Drawing.Color.Transparent
        Me.rad_cedula.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_cedula.Location = New System.Drawing.Point(320, 78)
        Me.rad_cedula.Name = "rad_cedula"
        Me.rad_cedula.Size = New System.Drawing.Size(72, 16)
        Me.rad_cedula.TabIndex = 157
        Me.rad_cedula.Text = "Cedula"
        Me.rad_cedula.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(629, 59)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 39)
        Me.btn_cancelar.TabIndex = 158
        Me.btn_cancelar.Tag = "1"
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(206, 73)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(96, 21)
        Me.dtp_ff.TabIndex = 160
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(59, 73)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(95, 21)
        Me.dtp_fi.TabIndex = 161
        '
        'frm_PedFac
        '
        Me.AcceptButton = Me.btn_filtrar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(723, 356)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.rad_cedula)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.rad_turno)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.dgrd_Pedido)
        Me.Controls.Add(Me.rad_paciente)
        Me.Controls.Add(Me.rad_pedido)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_PedFac"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de resultados"
        CType(Me.dgrd_Pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Public orden As String = Nothing

    Dim opr_pedido As New Cls_Pedido()
    Dim opr_resul As New Cls_Resultado()
    Dim dtv_pedido As New DataView()

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_PedFac_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main_form.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main_form.mdiClient1.Width - Me.Width) / 2) + frm_refer_main_form.Pan_Menu.Width


        rad_paciente.Checked = True
        dgrd_Pedido.DataSource = dtv_pedido
        dtp_fi.Value = DateAdd(DateInterval.Day, -45, Now)
        dtp_ff.Value = Now
        opr_pedido.LlenarGridPedValidados(dtv_pedido, dtp_fi.Text, dtp_ff.Text)
        txt_filtro.Focus()
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged

        If rad_paciente.Checked = True Then   'EN CASO DE SER APELLIDOS
            'opr_pedido.ordena_apellido(txt_filtro.Text, dtv_pedido)
            opr_pedido.ordena_pedidoapellido(txt_filtro.Text, dtv_pedido)
        ElseIf rad_cedula.Checked = True Then 'EN CASO DE SER PEDIDOS
            If txt_filtro.Text <> "" Then
                If IsNumeric(txt_filtro.Text) = True Then
                    opr_pedido.ordena_cedula(txt_filtro.Text, dtv_pedido)
                Else
                    MsgBox("El pedido solo puede ser numerico", MsgBoxStyle.Information, "ANALISYS")
                    txt_filtro.Text = ""
                End If
            Else
                dtv_pedido.RowFilter = ""
            End If
        Else 'EN CASO DE SER TURNOS
            If txt_filtro.Text <> "" Then
                If IsNumeric(txt_filtro.Text) = True Then
                    opr_pedido.ordena_turno(txt_filtro.Text, dtv_pedido)
                Else
                    MsgBox("El turno solo puede ser numerico", MsgBoxStyle.Information, "ANALISYS")
                    txt_filtro.Text = ""
                End If
            Else
                dtv_pedido.RowFilter = ""
            End If
        End If

    End Sub

    Private Sub dgrd_pedido_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Pedido.CurrentCellChanged
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = dgrd_Pedido.CurrentCell.RowNumber
        dgrd_Pedido.CurrentCell = dgc_celda
        dgrd_Pedido.Select(dgrd_Pedido.CurrentCell.RowNumber)
    End Sub

    Private Sub dgrd_pedido_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Pedido.DoubleClick
        On Error Resume Next
        'If dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 5) = "VALIDADO COMPLETO" Then
        'If (MsgBox("ADVERTENCIA: El pedido ya esta VALIDADO, desea continuar?.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ANALISYS")) Then
        If dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 10) <> "" Then
4:          orden = dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 1)
        Else
            MsgBox("No ha seleccionado ningun paciente.", MsgBoxStyle.Exclamation, "ANALISYS")
        End If
        Me.Close()
        'End If

        'Else
        'If dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 10) <> "" Then
        '    orden = dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 1)
        'Else
        '    MsgBox("No ha seleccionado ningun paciente.", MsgBoxStyle.Exclamation, "ANALISYS")
        'End If
        'Me.Close()
        'End If


        ''On Error Resume Next
        ''Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ''Dim ctl As frm_VisResul
        ''For Each ctl In frm_refer_main_form.MdiChildren
        ''    If ctl.Name = "frm_VisResul" Then
        ''        'Me.Tag = "ped_turno= " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString & "/*/ped_fecing=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(0).ToString & "/*/pac_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString & "/*/pac_fecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(4).ToString & "/*/ped_antecedentes=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(5).ToString & "/*/ped_medicacion=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(6).ToString & "/*/med_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(7).ToString & "/*/ped_nota=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(9).ToString & "/*/ped_id=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & "/*/pac_usafecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(11).ToString & "/*/pac_doc=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(12).ToString & "/*/ped_orden=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(13).ToString & "/*/LAB=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(16).ToString
        ''        ctl.Tag = "ped_id=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 0).ToString & "/*/ped_fecing=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 2).ToString & "/*/pac_nombre=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 4).ToString & "/*/pac_fecnac=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 5).ToString & "/*/ped_antecedentes=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 6).ToString & "/*/med_nombre=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 9).ToString & "/*/ped_nota=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 10).ToString & "/*/ped_turno=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 1).ToString & "/*/pac_usafecnac=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 11).ToString & "/*/pac_doc=" & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 12).ToString ''''& "/*/remitidos = " & dgrd_Pedido.Item(dgrd_Pedido.CurrentCell.RowNumber, 13).ToString
        ''        ctl.llenadatos("Entrega")
        ''        ctl.Activate()
        ''    End If
        ''Next
        ''Me.Close()
        ''Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub rad_pedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_pedido.CheckedChanged
        txt_filtro.Text = ""
        txt_filtro.Focus()
        If (rad_pedido.Checked = True) Then
            txt_filtro.MaxLength = 8
        End If
    End Sub

    Private Sub rad_paciente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_paciente.CheckedChanged
        txt_filtro.Text = ""
        txt_filtro.Focus()
        If (rad_paciente.Checked = True) Then
            txt_filtro.MaxLength = 50
        End If
    End Sub



    Private Sub rad_turno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_turno.CheckedChanged
        txt_filtro.Text = ""
        txt_filtro.Focus()
    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Me.Cursor = Cursors.WaitCursor
        dtp_ff.Value = Format(dtp_ff.Value, "dd/MM/yyyy")
        dtp_fi.Value = Format(dtp_fi.Value, "dd/MM/yyyy")
        If dtp_ff.Value < dtp_fi.Value Then
            MsgBox("La Fecha Final no puede ser menor a la Fecha Inicial", MsgBoxStyle.OkOnly, "ANALISYS")
        Else
            opr_pedido.LlenarGridPedValidados(dtv_pedido, dtp_fi.Text, dtp_ff.Text)
        End If
        txt_filtro.Text = ""
        txt_filtro.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
