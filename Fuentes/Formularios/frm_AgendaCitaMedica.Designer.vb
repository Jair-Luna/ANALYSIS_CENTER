<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AgendaCitaMedica
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AgendaCitaMedica))
        Me.pnl_AccionAgenda = New System.Windows.Forms.Panel
        Me.lbl_NoDisponible = New System.Windows.Forms.Label
        Me.grp_Certificados = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_CerCI = New System.Windows.Forms.TextBox
        Me.txt_CerTutor = New System.Windows.Forms.TextBox
        Me.chk_CerAs = New System.Windows.Forms.CheckBox
        Me.chk_CerAsiTut = New System.Windows.Forms.CheckBox
        Me.chk_certVac = New System.Windows.Forms.CheckBox
        Me.chk_cerVacTut = New System.Windows.Forms.CheckBox
        Me.cmb_convenio = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_Interpretacion = New System.Windows.Forms.Button
        Me.btn_PruebaCutanea = New System.Windows.Forms.Button
        Me.btn_HistoriaClinica = New System.Windows.Forms.Button
        Me.btn_SignosVitales = New System.Windows.Forms.Button
        Me.lbl_AgendarDia = New System.Windows.Forms.Label
        Me.grp_Accion = New System.Windows.Forms.GroupBox
        Me.lbl_AgendarA = New System.Windows.Forms.Label
        Me.dgv_Agenda = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_MedicoCita = New System.Windows.Forms.Label
        Me.txt_CitaGeneral = New System.Windows.Forms.TextBox
        Me.dgv_AgendaDespacho = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgv_Medico = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_Especialidad = New System.Windows.Forms.ComboBox
        Me.dtp_CitaMedica = New System.Windows.Forms.MonthCalendar
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rbt_All = New System.Windows.Forms.RadioButton
        Me.rbt_Grp = New System.Windows.Forms.RadioButton
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_Solicitud = New System.Windows.Forms.Button
        Me.btn_Consent = New System.Windows.Forms.Button
        Me.btn_CrearCert = New System.Windows.Forms.Button
        Me.btn_certificadoM = New System.Windows.Forms.Button
        Me.btn_GrabaTutor = New System.Windows.Forms.PictureBox
        Me.btn_CerVacTut = New System.Windows.Forms.Button
        Me.btn_CerVac = New System.Windows.Forms.Button
        Me.btn_CerAsistTut = New System.Windows.Forms.Button
        Me.btn_CerAsist = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_buscaAgenda = New System.Windows.Forms.Button
        Me.btn_AgendarPaciente = New System.Windows.Forms.Button
        Me.btn_AgendarActividad = New System.Windows.Forms.Button
        Me.btn_ssalir = New System.Windows.Forms.Button
        Me.btn_Confirmar = New System.Windows.Forms.Button
        Me.btn_ImpAgenda = New System.Windows.Forms.Button
        Me.btn_gguardar = New System.Windows.Forms.Button
        Me.pnl_AccionAgenda.SuspendLayout()
        Me.grp_Certificados.SuspendLayout()
        Me.grp_Accion.SuspendLayout()
        CType(Me.dgv_Agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_AgendaDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        CType(Me.btn_GrabaTutor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_AccionAgenda
        '
        Me.pnl_AccionAgenda.BackColor = System.Drawing.Color.Teal
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_Solicitud)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_Consent)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_CrearCert)
        Me.pnl_AccionAgenda.Controls.Add(Me.lbl_NoDisponible)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_certificadoM)
        Me.pnl_AccionAgenda.Controls.Add(Me.grp_Certificados)
        Me.pnl_AccionAgenda.Controls.Add(Me.cmb_convenio)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_CerVacTut)
        Me.pnl_AccionAgenda.Controls.Add(Me.Label6)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_CerVac)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_CerAsistTut)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_CerAsist)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_Interpretacion)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_PruebaCutanea)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_HistoriaClinica)
        Me.pnl_AccionAgenda.Controls.Add(Me.btn_SignosVitales)
        Me.pnl_AccionAgenda.Controls.Add(Me.PictureBox1)
        Me.pnl_AccionAgenda.Controls.Add(Me.lbl_AgendarDia)
        Me.pnl_AccionAgenda.Controls.Add(Me.grp_Accion)
        Me.pnl_AccionAgenda.Controls.Add(Me.dgv_Agenda)
        Me.pnl_AccionAgenda.Controls.Add(Me.Label1)
        Me.pnl_AccionAgenda.Controls.Add(Me.lbl_MedicoCita)
        Me.pnl_AccionAgenda.Controls.Add(Me.txt_CitaGeneral)
        Me.pnl_AccionAgenda.Controls.Add(Me.dgv_AgendaDespacho)
        Me.pnl_AccionAgenda.Location = New System.Drawing.Point(220, 31)
        Me.pnl_AccionAgenda.Name = "pnl_AccionAgenda"
        Me.pnl_AccionAgenda.Size = New System.Drawing.Size(1128, 553)
        Me.pnl_AccionAgenda.TabIndex = 162
        '
        'lbl_NoDisponible
        '
        Me.lbl_NoDisponible.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_NoDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NoDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NoDisponible.ForeColor = System.Drawing.Color.Red
        Me.lbl_NoDisponible.Location = New System.Drawing.Point(7, 78)
        Me.lbl_NoDisponible.Name = "lbl_NoDisponible"
        Me.lbl_NoDisponible.Size = New System.Drawing.Size(905, 27)
        Me.lbl_NoDisponible.TabIndex = 211
        Me.lbl_NoDisponible.Text = "NO DISPONIBLE"
        Me.lbl_NoDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_NoDisponible.Visible = False
        '
        'grp_Certificados
        '
        Me.grp_Certificados.Controls.Add(Me.btn_GrabaTutor)
        Me.grp_Certificados.Controls.Add(Me.Label4)
        Me.grp_Certificados.Controls.Add(Me.Label2)
        Me.grp_Certificados.Controls.Add(Me.txt_CerCI)
        Me.grp_Certificados.Controls.Add(Me.txt_CerTutor)
        Me.grp_Certificados.Controls.Add(Me.chk_CerAs)
        Me.grp_Certificados.Controls.Add(Me.chk_CerAsiTut)
        Me.grp_Certificados.Controls.Add(Me.chk_certVac)
        Me.grp_Certificados.Controls.Add(Me.chk_cerVacTut)
        Me.grp_Certificados.ForeColor = System.Drawing.Color.White
        Me.grp_Certificados.Location = New System.Drawing.Point(922, 36)
        Me.grp_Certificados.Name = "grp_Certificados"
        Me.grp_Certificados.Size = New System.Drawing.Size(198, 140)
        Me.grp_Certificados.TabIndex = 200
        Me.grp_Certificados.TabStop = False
        Me.grp_Certificados.Text = "Certificados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 15)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "CI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Tutor"
        '
        'txt_CerCI
        '
        Me.txt_CerCI.Location = New System.Drawing.Point(41, 115)
        Me.txt_CerCI.Name = "txt_CerCI"
        Me.txt_CerCI.Size = New System.Drawing.Size(151, 20)
        Me.txt_CerCI.TabIndex = 207
        '
        'txt_CerTutor
        '
        Me.txt_CerTutor.Location = New System.Drawing.Point(41, 94)
        Me.txt_CerTutor.Name = "txt_CerTutor"
        Me.txt_CerTutor.Size = New System.Drawing.Size(151, 20)
        Me.txt_CerTutor.TabIndex = 206
        '
        'chk_CerAs
        '
        Me.chk_CerAs.AutoSize = True
        Me.chk_CerAs.ForeColor = System.Drawing.Color.White
        Me.chk_CerAs.Location = New System.Drawing.Point(10, 14)
        Me.chk_CerAs.Name = "chk_CerAs"
        Me.chk_CerAs.Size = New System.Drawing.Size(74, 17)
        Me.chk_CerAs.TabIndex = 202
        Me.chk_CerAs.Tag = "1"
        Me.chk_CerAs.Text = "Asistencia"
        Me.chk_CerAs.UseVisualStyleBackColor = True
        '
        'chk_CerAsiTut
        '
        Me.chk_CerAsiTut.AutoSize = True
        Me.chk_CerAsiTut.ForeColor = System.Drawing.Color.White
        Me.chk_CerAsiTut.Location = New System.Drawing.Point(10, 34)
        Me.chk_CerAsiTut.Name = "chk_CerAsiTut"
        Me.chk_CerAsiTut.Size = New System.Drawing.Size(111, 17)
        Me.chk_CerAsiTut.TabIndex = 203
        Me.chk_CerAsiTut.Tag = "2"
        Me.chk_CerAsiTut.Text = "Asistencia + Tutor"
        Me.chk_CerAsiTut.UseVisualStyleBackColor = True
        '
        'chk_certVac
        '
        Me.chk_certVac.AutoSize = True
        Me.chk_certVac.ForeColor = System.Drawing.Color.White
        Me.chk_certVac.Location = New System.Drawing.Point(10, 54)
        Me.chk_certVac.Name = "chk_certVac"
        Me.chk_certVac.Size = New System.Drawing.Size(110, 17)
        Me.chk_certVac.TabIndex = 204
        Me.chk_certVac.Tag = "3"
        Me.chk_certVac.Text = "Salida de Vacuna"
        Me.chk_certVac.UseVisualStyleBackColor = True
        '
        'chk_cerVacTut
        '
        Me.chk_cerVacTut.AutoSize = True
        Me.chk_cerVacTut.ForeColor = System.Drawing.Color.White
        Me.chk_cerVacTut.Location = New System.Drawing.Point(10, 74)
        Me.chk_cerVacTut.Name = "chk_cerVacTut"
        Me.chk_cerVacTut.Size = New System.Drawing.Size(147, 17)
        Me.chk_cerVacTut.TabIndex = 205
        Me.chk_cerVacTut.Tag = "4"
        Me.chk_cerVacTut.Text = "Salida de Vacuna + Tutor"
        Me.chk_cerVacTut.UseVisualStyleBackColor = True
        '
        'cmb_convenio
        '
        Me.cmb_convenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_convenio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_convenio.Location = New System.Drawing.Point(345, 43)
        Me.cmb_convenio.Name = "cmb_convenio"
        Me.cmb_convenio.Size = New System.Drawing.Size(197, 21)
        Me.cmb_convenio.TabIndex = 185
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(343, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 14)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "CONVENIO"
        '
        'btn_Interpretacion
        '
        Me.btn_Interpretacion.BackColor = System.Drawing.Color.White
        Me.btn_Interpretacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Interpretacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Interpretacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Interpretacion.Location = New System.Drawing.Point(923, 313)
        Me.btn_Interpretacion.Name = "btn_Interpretacion"
        Me.btn_Interpretacion.Size = New System.Drawing.Size(198, 45)
        Me.btn_Interpretacion.TabIndex = 200
        Me.btn_Interpretacion.Text = "     F6 - Interpretacion "
        Me.btn_Interpretacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Interpretacion.UseVisualStyleBackColor = False
        '
        'btn_PruebaCutanea
        '
        Me.btn_PruebaCutanea.BackColor = System.Drawing.Color.White
        Me.btn_PruebaCutanea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PruebaCutanea.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PruebaCutanea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PruebaCutanea.Location = New System.Drawing.Point(923, 268)
        Me.btn_PruebaCutanea.Name = "btn_PruebaCutanea"
        Me.btn_PruebaCutanea.Size = New System.Drawing.Size(198, 45)
        Me.btn_PruebaCutanea.TabIndex = 199
        Me.btn_PruebaCutanea.Text = "     F5 - Pruebas Cutáneas "
        Me.btn_PruebaCutanea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PruebaCutanea.UseVisualStyleBackColor = False
        '
        'btn_HistoriaClinica
        '
        Me.btn_HistoriaClinica.BackColor = System.Drawing.Color.White
        Me.btn_HistoriaClinica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_HistoriaClinica.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_HistoriaClinica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HistoriaClinica.Location = New System.Drawing.Point(923, 223)
        Me.btn_HistoriaClinica.Name = "btn_HistoriaClinica"
        Me.btn_HistoriaClinica.Size = New System.Drawing.Size(198, 45)
        Me.btn_HistoriaClinica.TabIndex = 198
        Me.btn_HistoriaClinica.Text = "     F4 - Historia Clínica"
        Me.btn_HistoriaClinica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HistoriaClinica.UseVisualStyleBackColor = False
        '
        'btn_SignosVitales
        '
        Me.btn_SignosVitales.BackColor = System.Drawing.Color.White
        Me.btn_SignosVitales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SignosVitales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignosVitales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SignosVitales.Location = New System.Drawing.Point(923, 178)
        Me.btn_SignosVitales.Name = "btn_SignosVitales"
        Me.btn_SignosVitales.Size = New System.Drawing.Size(198, 45)
        Me.btn_SignosVitales.TabIndex = 197
        Me.btn_SignosVitales.Text = "     F3 - Signos Vitales y FR"
        Me.btn_SignosVitales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SignosVitales.UseVisualStyleBackColor = False
        '
        'lbl_AgendarDia
        '
        Me.lbl_AgendarDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_AgendarDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AgendarDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_AgendarDia.Location = New System.Drawing.Point(8, 12)
        Me.lbl_AgendarDia.Name = "lbl_AgendarDia"
        Me.lbl_AgendarDia.Size = New System.Drawing.Size(320, 21)
        Me.lbl_AgendarDia.TabIndex = 183
        Me.lbl_AgendarDia.Text = "(FECHA AGENDA)"
        Me.lbl_AgendarDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_Accion
        '
        Me.grp_Accion.BackColor = System.Drawing.Color.LightSeaGreen
        Me.grp_Accion.Controls.Add(Me.btn_buscaAgenda)
        Me.grp_Accion.Controls.Add(Me.lbl_AgendarA)
        Me.grp_Accion.Controls.Add(Me.btn_AgendarPaciente)
        Me.grp_Accion.Controls.Add(Me.btn_AgendarActividad)
        Me.grp_Accion.Controls.Add(Me.btn_ssalir)
        Me.grp_Accion.Controls.Add(Me.btn_Confirmar)
        Me.grp_Accion.Controls.Add(Me.btn_ImpAgenda)
        Me.grp_Accion.Controls.Add(Me.btn_gguardar)
        Me.grp_Accion.Location = New System.Drawing.Point(3, 463)
        Me.grp_Accion.Name = "grp_Accion"
        Me.grp_Accion.Size = New System.Drawing.Size(905, 74)
        Me.grp_Accion.TabIndex = 177
        Me.grp_Accion.TabStop = False
        '
        'lbl_AgendarA
        '
        Me.lbl_AgendarA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_AgendarA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_AgendarA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AgendarA.ForeColor = System.Drawing.Color.Red
        Me.lbl_AgendarA.Location = New System.Drawing.Point(3, 9)
        Me.lbl_AgendarA.Name = "lbl_AgendarA"
        Me.lbl_AgendarA.Size = New System.Drawing.Size(395, 61)
        Me.lbl_AgendarA.TabIndex = 182
        Me.lbl_AgendarA.Text = "Agenda"
        Me.lbl_AgendarA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_Agenda
        '
        Me.dgv_Agenda.AllowUserToAddRows = False
        Me.dgv_Agenda.AllowUserToDeleteRows = False
        Me.dgv_Agenda.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Agenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Agenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Agenda.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Agenda.Location = New System.Drawing.Point(7, 74)
        Me.dgv_Agenda.MultiSelect = False
        Me.dgv_Agenda.Name = "dgv_Agenda"
        Me.dgv_Agenda.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Agenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Agenda.RowHeadersVisible = False
        Me.dgv_Agenda.Size = New System.Drawing.Size(908, 383)
        Me.dgv_Agenda.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(591, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "OBSERVACIONES"
        '
        'lbl_MedicoCita
        '
        Me.lbl_MedicoCita.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_MedicoCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MedicoCita.ForeColor = System.Drawing.Color.Red
        Me.lbl_MedicoCita.Location = New System.Drawing.Point(41, 34)
        Me.lbl_MedicoCita.Name = "lbl_MedicoCita"
        Me.lbl_MedicoCita.Size = New System.Drawing.Size(287, 34)
        Me.lbl_MedicoCita.TabIndex = 165
        Me.lbl_MedicoCita.Text = "(MEDICO AGENDA)"
        Me.lbl_MedicoCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_CitaGeneral
        '
        Me.txt_CitaGeneral.BackColor = System.Drawing.Color.Khaki
        Me.txt_CitaGeneral.Location = New System.Drawing.Point(594, 39)
        Me.txt_CitaGeneral.Multiline = True
        Me.txt_CitaGeneral.Name = "txt_CitaGeneral"
        Me.txt_CitaGeneral.Size = New System.Drawing.Size(321, 29)
        Me.txt_CitaGeneral.TabIndex = 162
        '
        'dgv_AgendaDespacho
        '
        Me.dgv_AgendaDespacho.AllowUserToAddRows = False
        Me.dgv_AgendaDespacho.AllowUserToDeleteRows = False
        Me.dgv_AgendaDespacho.BackgroundColor = System.Drawing.Color.White
        Me.dgv_AgendaDespacho.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_AgendaDespacho.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_AgendaDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_AgendaDespacho.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_AgendaDespacho.Location = New System.Drawing.Point(7, 74)
        Me.dgv_AgendaDespacho.MultiSelect = False
        Me.dgv_AgendaDespacho.Name = "dgv_AgendaDespacho"
        Me.dgv_AgendaDespacho.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_AgendaDespacho.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_AgendaDespacho.RowHeadersVisible = False
        Me.dgv_AgendaDespacho.Size = New System.Drawing.Size(908, 383)
        Me.dgv_AgendaDespacho.TabIndex = 214
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.dgv_Medico)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmb_Especialidad)
        Me.Panel2.Location = New System.Drawing.Point(2, 232)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 352)
        Me.Panel2.TabIndex = 163
        '
        'dgv_Medico
        '
        Me.dgv_Medico.AllowUserToAddRows = False
        Me.dgv_Medico.AllowUserToDeleteRows = False
        Me.dgv_Medico.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Medico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Medico.ColumnHeadersVisible = False
        Me.dgv_Medico.Location = New System.Drawing.Point(12, 52)
        Me.dgv_Medico.Name = "dgv_Medico"
        Me.dgv_Medico.ReadOnly = True
        Me.dgv_Medico.RowHeadersVisible = False
        Me.dgv_Medico.Size = New System.Drawing.Size(182, 281)
        Me.dgv_Medico.TabIndex = 170
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Filtrar por especialidad"
        '
        'cmb_Especialidad
        '
        Me.cmb_Especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Especialidad.FormattingEnabled = True
        Me.cmb_Especialidad.Location = New System.Drawing.Point(13, 25)
        Me.cmb_Especialidad.Name = "cmb_Especialidad"
        Me.cmb_Especialidad.Size = New System.Drawing.Size(181, 21)
        Me.cmb_Especialidad.TabIndex = 168
        '
        'dtp_CitaMedica
        '
        Me.dtp_CitaMedica.Location = New System.Drawing.Point(12, 22)
        Me.dtp_CitaMedica.Name = "dtp_CitaMedica"
        Me.dtp_CitaMedica.TabIndex = 164
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.rbt_All)
        Me.Panel3.Controls.Add(Me.rbt_Grp)
        Me.Panel3.Controls.Add(Me.dtp_CitaMedica)
        Me.Panel3.Location = New System.Drawing.Point(2, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(216, 203)
        Me.Panel3.TabIndex = 167
        '
        'rbt_All
        '
        Me.rbt_All.AutoSize = True
        Me.rbt_All.ForeColor = System.Drawing.Color.White
        Me.rbt_All.Location = New System.Drawing.Point(94, 186)
        Me.rbt_All.Name = "rbt_All"
        Me.rbt_All.Size = New System.Drawing.Size(55, 17)
        Me.rbt_All.TabIndex = 166
        Me.rbt_All.Text = "Todos"
        Me.rbt_All.UseVisualStyleBackColor = True
        '
        'rbt_Grp
        '
        Me.rbt_Grp.AutoSize = True
        Me.rbt_Grp.Checked = True
        Me.rbt_Grp.ForeColor = System.Drawing.Color.White
        Me.rbt_Grp.Location = New System.Drawing.Point(17, 186)
        Me.rbt_Grp.Name = "rbt_Grp"
        Me.rbt_Grp.Size = New System.Drawing.Size(59, 17)
        Me.rbt_Grp.TabIndex = 165
        Me.rbt_Grp.TabStop = True
        Me.rbt_Grp.Text = "Grupos"
        Me.rbt_Grp.UseVisualStyleBackColor = True
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(1352, 25)
        Me.pan_barra.TabIndex = 168
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(8, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(147, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "AGENDA MEDICOS"
        '
        'btn_Solicitud
        '
        Me.btn_Solicitud.BackColor = System.Drawing.Color.LightGray
        Me.btn_Solicitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Solicitud.Enabled = False
        Me.btn_Solicitud.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Solicitud.Image = CType(resources.GetObject("btn_Solicitud.Image"), System.Drawing.Image)
        Me.btn_Solicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Solicitud.Location = New System.Drawing.Point(1023, 493)
        Me.btn_Solicitud.Name = "btn_Solicitud"
        Me.btn_Solicitud.Size = New System.Drawing.Size(99, 43)
        Me.btn_Solicitud.TabIndex = 215
        Me.btn_Solicitud.Text = "Ver        Solicitud"
        Me.btn_Solicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Solicitud.UseVisualStyleBackColor = False
        '
        'btn_Consent
        '
        Me.btn_Consent.BackColor = System.Drawing.Color.LightGray
        Me.btn_Consent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Consent.Enabled = False
        Me.btn_Consent.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consent.Image = CType(resources.GetObject("btn_Consent.Image"), System.Drawing.Image)
        Me.btn_Consent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Consent.Location = New System.Drawing.Point(923, 493)
        Me.btn_Consent.Name = "btn_Consent"
        Me.btn_Consent.Size = New System.Drawing.Size(99, 43)
        Me.btn_Consent.TabIndex = 213
        Me.btn_Consent.Text = "Consent Informado"
        Me.btn_Consent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consent.UseVisualStyleBackColor = False
        '
        'btn_CrearCert
        '
        Me.btn_CrearCert.BackColor = System.Drawing.Color.LightGray
        Me.btn_CrearCert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CrearCert.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CrearCert.Image = CType(resources.GetObject("btn_CrearCert.Image"), System.Drawing.Image)
        Me.btn_CrearCert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CrearCert.Location = New System.Drawing.Point(1023, 358)
        Me.btn_CrearCert.Name = "btn_CrearCert"
        Me.btn_CrearCert.Size = New System.Drawing.Size(98, 43)
        Me.btn_CrearCert.TabIndex = 212
        Me.btn_CrearCert.Text = "Crear Certificado"
        Me.btn_CrearCert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CrearCert.UseVisualStyleBackColor = False
        '
        'btn_certificadoM
        '
        Me.btn_certificadoM.BackColor = System.Drawing.Color.LightGray
        Me.btn_certificadoM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_certificadoM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_certificadoM.Image = CType(resources.GetObject("btn_certificadoM.Image"), System.Drawing.Image)
        Me.btn_certificadoM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_certificadoM.Location = New System.Drawing.Point(923, 358)
        Me.btn_certificadoM.Name = "btn_certificadoM"
        Me.btn_certificadoM.Size = New System.Drawing.Size(98, 43)
        Me.btn_certificadoM.TabIndex = 210
        Me.btn_certificadoM.Text = "Certificado Medico"
        Me.btn_certificadoM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_certificadoM.UseVisualStyleBackColor = False
        '
        'btn_GrabaTutor
        '
        Me.btn_GrabaTutor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_GrabaTutor.Image = CType(resources.GetObject("btn_GrabaTutor.Image"), System.Drawing.Image)
        Me.btn_GrabaTutor.Location = New System.Drawing.Point(166, 10)
        Me.btn_GrabaTutor.Name = "btn_GrabaTutor"
        Me.btn_GrabaTutor.Size = New System.Drawing.Size(28, 25)
        Me.btn_GrabaTutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_GrabaTutor.TabIndex = 210
        Me.btn_GrabaTutor.TabStop = False
        '
        'btn_CerVacTut
        '
        Me.btn_CerVacTut.BackColor = System.Drawing.Color.LightGray
        Me.btn_CerVacTut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CerVacTut.Enabled = False
        Me.btn_CerVacTut.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CerVacTut.Image = CType(resources.GetObject("btn_CerVacTut.Image"), System.Drawing.Image)
        Me.btn_CerVacTut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CerVacTut.Location = New System.Drawing.Point(1023, 448)
        Me.btn_CerVacTut.Name = "btn_CerVacTut"
        Me.btn_CerVacTut.Size = New System.Drawing.Size(99, 43)
        Me.btn_CerVacTut.TabIndex = 208
        Me.btn_CerVacTut.Text = "Certificado Vac. Tutor"
        Me.btn_CerVacTut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CerVacTut.UseVisualStyleBackColor = False
        '
        'btn_CerVac
        '
        Me.btn_CerVac.BackColor = System.Drawing.Color.LightGray
        Me.btn_CerVac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CerVac.Enabled = False
        Me.btn_CerVac.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CerVac.Image = CType(resources.GetObject("btn_CerVac.Image"), System.Drawing.Image)
        Me.btn_CerVac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CerVac.Location = New System.Drawing.Point(923, 448)
        Me.btn_CerVac.Name = "btn_CerVac"
        Me.btn_CerVac.Size = New System.Drawing.Size(99, 43)
        Me.btn_CerVac.TabIndex = 207
        Me.btn_CerVac.Text = "Certificado Vacuna"
        Me.btn_CerVac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CerVac.UseVisualStyleBackColor = False
        '
        'btn_CerAsistTut
        '
        Me.btn_CerAsistTut.BackColor = System.Drawing.Color.LightGray
        Me.btn_CerAsistTut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CerAsistTut.Enabled = False
        Me.btn_CerAsistTut.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CerAsistTut.Image = CType(resources.GetObject("btn_CerAsistTut.Image"), System.Drawing.Image)
        Me.btn_CerAsistTut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CerAsistTut.Location = New System.Drawing.Point(1023, 403)
        Me.btn_CerAsistTut.Name = "btn_CerAsistTut"
        Me.btn_CerAsistTut.Size = New System.Drawing.Size(99, 43)
        Me.btn_CerAsistTut.TabIndex = 206
        Me.btn_CerAsistTut.Text = "Certificado Asist. Tutor"
        Me.btn_CerAsistTut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CerAsistTut.UseVisualStyleBackColor = False
        '
        'btn_CerAsist
        '
        Me.btn_CerAsist.BackColor = System.Drawing.Color.LightGray
        Me.btn_CerAsist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CerAsist.Enabled = False
        Me.btn_CerAsist.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CerAsist.Image = CType(resources.GetObject("btn_CerAsist.Image"), System.Drawing.Image)
        Me.btn_CerAsist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CerAsist.Location = New System.Drawing.Point(923, 403)
        Me.btn_CerAsist.Name = "btn_CerAsist"
        Me.btn_CerAsist.Size = New System.Drawing.Size(99, 43)
        Me.btn_CerAsist.TabIndex = 201
        Me.btn_CerAsist.Text = "Certificado Asistencia"
        Me.btn_CerAsist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CerAsist.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 188
        Me.PictureBox1.TabStop = False
        '
        'btn_buscaAgenda
        '
        Me.btn_buscaAgenda.BackColor = System.Drawing.Color.White
        Me.btn_buscaAgenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscaAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscaAgenda.Image = CType(resources.GetObject("btn_buscaAgenda.Image"), System.Drawing.Image)
        Me.btn_buscaAgenda.Location = New System.Drawing.Point(776, 9)
        Me.btn_buscaAgenda.Name = "btn_buscaAgenda"
        Me.btn_buscaAgenda.Size = New System.Drawing.Size(64, 62)
        Me.btn_buscaAgenda.TabIndex = 185
        Me.btn_buscaAgenda.Tag = "BUSCAR PACIENTE AGENDADO"
        Me.btn_buscaAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscaAgenda.UseVisualStyleBackColor = False
        '
        'btn_AgendarPaciente
        '
        Me.btn_AgendarPaciente.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_AgendarPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AgendarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgendarPaciente.Image = CType(resources.GetObject("btn_AgendarPaciente.Image"), System.Drawing.Image)
        Me.btn_AgendarPaciente.Location = New System.Drawing.Point(399, 9)
        Me.btn_AgendarPaciente.Name = "btn_AgendarPaciente"
        Me.btn_AgendarPaciente.Size = New System.Drawing.Size(64, 62)
        Me.btn_AgendarPaciente.TabIndex = 179
        Me.btn_AgendarPaciente.Tag = "BUSCA PACIENTE"
        Me.btn_AgendarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgendarPaciente.UseVisualStyleBackColor = False
        '
        'btn_AgendarActividad
        '
        Me.btn_AgendarActividad.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_AgendarActividad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AgendarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgendarActividad.Image = CType(resources.GetObject("btn_AgendarActividad.Image"), System.Drawing.Image)
        Me.btn_AgendarActividad.Location = New System.Drawing.Point(713, 9)
        Me.btn_AgendarActividad.Name = "btn_AgendarActividad"
        Me.btn_AgendarActividad.Size = New System.Drawing.Size(64, 62)
        Me.btn_AgendarActividad.TabIndex = 180
        Me.btn_AgendarActividad.Tag = "AGREGA ACTIVIDAD"
        Me.btn_AgendarActividad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgendarActividad.UseVisualStyleBackColor = False
        '
        'btn_ssalir
        '
        Me.btn_ssalir.BackColor = System.Drawing.Color.White
        Me.btn_ssalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ssalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ssalir.Image = CType(resources.GetObject("btn_ssalir.Image"), System.Drawing.Image)
        Me.btn_ssalir.Location = New System.Drawing.Point(839, 9)
        Me.btn_ssalir.Name = "btn_ssalir"
        Me.btn_ssalir.Size = New System.Drawing.Size(64, 62)
        Me.btn_ssalir.TabIndex = 176
        Me.btn_ssalir.Tag = "CIERRA VENTANA"
        Me.btn_ssalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ssalir.UseVisualStyleBackColor = False
        '
        'btn_Confirmar
        '
        Me.btn_Confirmar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Confirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Confirmar.Image = CType(resources.GetObject("btn_Confirmar.Image"), System.Drawing.Image)
        Me.btn_Confirmar.Location = New System.Drawing.Point(588, 9)
        Me.btn_Confirmar.Name = "btn_Confirmar"
        Me.btn_Confirmar.Size = New System.Drawing.Size(64, 62)
        Me.btn_Confirmar.TabIndex = 183
        Me.btn_Confirmar.Tag = "CONFIRMA AGENDA WEB"
        Me.btn_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Confirmar.UseVisualStyleBackColor = False
        '
        'btn_ImpAgenda
        '
        Me.btn_ImpAgenda.BackColor = System.Drawing.Color.White
        Me.btn_ImpAgenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImpAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpAgenda.Image = CType(resources.GetObject("btn_ImpAgenda.Image"), System.Drawing.Image)
        Me.btn_ImpAgenda.Location = New System.Drawing.Point(525, 9)
        Me.btn_ImpAgenda.Name = "btn_ImpAgenda"
        Me.btn_ImpAgenda.Size = New System.Drawing.Size(64, 62)
        Me.btn_ImpAgenda.TabIndex = 169
        Me.btn_ImpAgenda.Tag = "IMPRIME AGENDA"
        Me.btn_ImpAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpAgenda.UseVisualStyleBackColor = False
        '
        'btn_gguardar
        '
        Me.btn_gguardar.BackColor = System.Drawing.Color.White
        Me.btn_gguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gguardar.Image = CType(resources.GetObject("btn_gguardar.Image"), System.Drawing.Image)
        Me.btn_gguardar.Location = New System.Drawing.Point(462, 9)
        Me.btn_gguardar.Name = "btn_gguardar"
        Me.btn_gguardar.Size = New System.Drawing.Size(64, 62)
        Me.btn_gguardar.TabIndex = 170
        Me.btn_gguardar.Tag = "GUARDA AGENDA"
        Me.btn_gguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gguardar.UseVisualStyleBackColor = False
        '
        'frm_AgendaCitaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 596)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl_AccionAgenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_AgendaCitaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnl_AccionAgenda.ResumeLayout(False)
        Me.pnl_AccionAgenda.PerformLayout()
        Me.grp_Certificados.ResumeLayout(False)
        Me.grp_Certificados.PerformLayout()
        Me.grp_Accion.ResumeLayout(False)
        CType(Me.dgv_Agenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_AgendaDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.btn_GrabaTutor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_AccionAgenda As System.Windows.Forms.Panel
    Friend WithEvents lbl_MedicoCita As System.Windows.Forms.Label
    Friend WithEvents txt_CitaGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_gguardar As System.Windows.Forms.Button
    Friend WithEvents btn_ImpAgenda As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents dgv_Medico As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_Agenda As System.Windows.Forms.DataGridView
    Friend WithEvents grp_Accion As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_AgendarA As System.Windows.Forms.Label
    Friend WithEvents btn_AgendarActividad As System.Windows.Forms.Button
    Friend WithEvents btn_AgendarPaciente As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_convenio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_AgendarDia As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_SignosVitales As System.Windows.Forms.Button
    Friend WithEvents btn_HistoriaClinica As System.Windows.Forms.Button
    Friend WithEvents btn_Interpretacion As System.Windows.Forms.Button
    Friend WithEvents btn_PruebaCutanea As System.Windows.Forms.Button
    Protected WithEvents dtp_CitaMedica As System.Windows.Forms.MonthCalendar
    Friend WithEvents btn_CerAsist As System.Windows.Forms.Button
    Friend WithEvents chk_CerAsiTut As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CerAs As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cerVacTut As System.Windows.Forms.CheckBox
    Friend WithEvents chk_certVac As System.Windows.Forms.CheckBox
    Friend WithEvents btn_CerVacTut As System.Windows.Forms.Button
    Friend WithEvents btn_CerVac As System.Windows.Forms.Button
    Friend WithEvents btn_CerAsistTut As System.Windows.Forms.Button
    Friend WithEvents grp_Certificados As System.Windows.Forms.GroupBox
    Friend WithEvents txt_CerTutor As System.Windows.Forms.TextBox
    Friend WithEvents txt_CerCI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_certificadoM As System.Windows.Forms.Button
    Friend WithEvents btn_Confirmar As System.Windows.Forms.Button
    Friend WithEvents btn_ssalir As System.Windows.Forms.Button
    Friend WithEvents lbl_NoDisponible As System.Windows.Forms.Label
    Friend WithEvents btn_GrabaTutor As System.Windows.Forms.PictureBox
    Friend WithEvents btn_CrearCert As System.Windows.Forms.Button
    Friend WithEvents btn_Consent As System.Windows.Forms.Button
    Friend WithEvents dgv_AgendaDespacho As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Solicitud As System.Windows.Forms.Button
    Friend WithEvents btn_buscaAgenda As System.Windows.Forms.Button
    Friend WithEvents rbt_All As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Grp As System.Windows.Forms.RadioButton
End Class
