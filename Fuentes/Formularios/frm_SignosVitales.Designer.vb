<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SignosVitales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SignosVitales))
        Me.grp_SVitales = New System.Windows.Forms.GroupBox
        Me.txt_hc_Audiometria = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.lbl_hc_fechaSV = New System.Windows.Forms.Label
        Me.btn_ImpSignosV = New System.Windows.Forms.Button
        Me.txt_hc_Peso = New System.Windows.Forms.TextBox
        Me.txt_hc_Saturacion = New System.Windows.Forms.TextBox
        Me.txt_hc_Temperatura = New System.Windows.Forms.TextBox
        Me.txt_hc_FrecResp = New System.Windows.Forms.TextBox
        Me.txt_hc_FreCardiaca = New System.Windows.Forms.TextBox
        Me.txt_hc_TenArterial = New System.Windows.Forms.TextBox
        Me.Label015 = New System.Windows.Forms.Label
        Me.Label014 = New System.Windows.Forms.Label
        Me.Label013 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btn_SalirSignosV = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgv_SignosV = New System.Windows.Forms.DataGridView
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_FR_Drogas = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_AddFR = New System.Windows.Forms.Button
        Me.btn_ImpFR = New System.Windows.Forms.Button
        Me.txt_FR_Sedent = New System.Windows.Forms.TextBox
        Me.txt_FR_Alcohol = New System.Windows.Forms.TextBox
        Me.txt_FR_Cigarro = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lst_Cigarro = New System.Windows.Forms.ListBox
        Me.lst_Alcohol = New System.Windows.Forms.ListBox
        Me.lst_Sedent = New System.Windows.Forms.ListBox
        Me.lst_Drogas = New System.Windows.Forms.ListBox
        Me.grp_SVitales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_SignosV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_SVitales
        '
        Me.grp_SVitales.BackColor = System.Drawing.Color.Silver
        Me.grp_SVitales.Controls.Add(Me.txt_hc_Audiometria)
        Me.grp_SVitales.Controls.Add(Me.Label2)
        Me.grp_SVitales.Controls.Add(Me.Button2)
        Me.grp_SVitales.Controls.Add(Me.lbl_hc_fechaSV)
        Me.grp_SVitales.Controls.Add(Me.btn_ImpSignosV)
        Me.grp_SVitales.Controls.Add(Me.txt_hc_Peso)
        Me.grp_SVitales.Controls.Add(Me.txt_hc_Saturacion)
        Me.grp_SVitales.Controls.Add(Me.txt_hc_Temperatura)
        Me.grp_SVitales.Controls.Add(Me.txt_hc_FrecResp)
        Me.grp_SVitales.Controls.Add(Me.txt_hc_FreCardiaca)
        Me.grp_SVitales.Controls.Add(Me.txt_hc_TenArterial)
        Me.grp_SVitales.Controls.Add(Me.Label015)
        Me.grp_SVitales.Controls.Add(Me.Label014)
        Me.grp_SVitales.Controls.Add(Me.Label013)
        Me.grp_SVitales.Controls.Add(Me.Label12)
        Me.grp_SVitales.Controls.Add(Me.Label11)
        Me.grp_SVitales.Controls.Add(Me.Label10)
        Me.grp_SVitales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_SVitales.Location = New System.Drawing.Point(11, 102)
        Me.grp_SVitales.Name = "grp_SVitales"
        Me.grp_SVitales.Size = New System.Drawing.Size(645, 135)
        Me.grp_SVitales.TabIndex = 180
        Me.grp_SVitales.TabStop = False
        '
        'txt_hc_Audiometria
        '
        Me.txt_hc_Audiometria.BackColor = System.Drawing.Color.White
        Me.txt_hc_Audiometria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Audiometria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hc_Audiometria.Location = New System.Drawing.Point(509, 99)
        Me.txt_hc_Audiometria.Multiline = True
        Me.txt_hc_Audiometria.Name = "txt_hc_Audiometria"
        Me.txt_hc_Audiometria.Size = New System.Drawing.Size(124, 24)
        Me.txt_hc_Audiometria.TabIndex = 198
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(509, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 44)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "ESPIROMETRIA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(481, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 36)
        Me.Button2.TabIndex = 195
        Me.Button2.Text = "AÑADIR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbl_hc_fechaSV
        '
        Me.lbl_hc_fechaSV.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hc_fechaSV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hc_fechaSV.ForeColor = System.Drawing.Color.Red
        Me.lbl_hc_fechaSV.Location = New System.Drawing.Point(7, 15)
        Me.lbl_hc_fechaSV.Name = "lbl_hc_fechaSV"
        Me.lbl_hc_fechaSV.Size = New System.Drawing.Size(96, 15)
        Me.lbl_hc_fechaSV.TabIndex = 194
        Me.lbl_hc_fechaSV.Text = "FECHA SV"
        '
        'btn_ImpSignosV
        '
        Me.btn_ImpSignosV.BackColor = System.Drawing.Color.White
        Me.btn_ImpSignosV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImpSignosV.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpSignosV.Image = CType(resources.GetObject("btn_ImpSignosV.Image"), System.Drawing.Image)
        Me.btn_ImpSignosV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpSignosV.Location = New System.Drawing.Point(558, 15)
        Me.btn_ImpSignosV.Name = "btn_ImpSignosV"
        Me.btn_ImpSignosV.Size = New System.Drawing.Size(76, 36)
        Me.btn_ImpSignosV.TabIndex = 192
        Me.btn_ImpSignosV.Text = "SIGNOS"
        Me.btn_ImpSignosV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpSignosV.UseVisualStyleBackColor = False
        '
        'txt_hc_Peso
        '
        Me.txt_hc_Peso.BackColor = System.Drawing.Color.White
        Me.txt_hc_Peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hc_Peso.Location = New System.Drawing.Point(425, 99)
        Me.txt_hc_Peso.Name = "txt_hc_Peso"
        Me.txt_hc_Peso.Size = New System.Drawing.Size(82, 24)
        Me.txt_hc_Peso.TabIndex = 190
        '
        'txt_hc_Saturacion
        '
        Me.txt_hc_Saturacion.BackColor = System.Drawing.Color.White
        Me.txt_hc_Saturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Saturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hc_Saturacion.Location = New System.Drawing.Point(341, 99)
        Me.txt_hc_Saturacion.Name = "txt_hc_Saturacion"
        Me.txt_hc_Saturacion.Size = New System.Drawing.Size(82, 24)
        Me.txt_hc_Saturacion.TabIndex = 189
        '
        'txt_hc_Temperatura
        '
        Me.txt_hc_Temperatura.BackColor = System.Drawing.Color.White
        Me.txt_hc_Temperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Temperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hc_Temperatura.Location = New System.Drawing.Point(257, 99)
        Me.txt_hc_Temperatura.Name = "txt_hc_Temperatura"
        Me.txt_hc_Temperatura.Size = New System.Drawing.Size(82, 24)
        Me.txt_hc_Temperatura.TabIndex = 188
        '
        'txt_hc_FrecResp
        '
        Me.txt_hc_FrecResp.BackColor = System.Drawing.Color.White
        Me.txt_hc_FrecResp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_FrecResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hc_FrecResp.Location = New System.Drawing.Point(173, 99)
        Me.txt_hc_FrecResp.Name = "txt_hc_FrecResp"
        Me.txt_hc_FrecResp.Size = New System.Drawing.Size(82, 24)
        Me.txt_hc_FrecResp.TabIndex = 187
        '
        'txt_hc_FreCardiaca
        '
        Me.txt_hc_FreCardiaca.BackColor = System.Drawing.Color.White
        Me.txt_hc_FreCardiaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_FreCardiaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hc_FreCardiaca.Location = New System.Drawing.Point(89, 99)
        Me.txt_hc_FreCardiaca.Name = "txt_hc_FreCardiaca"
        Me.txt_hc_FreCardiaca.Size = New System.Drawing.Size(82, 24)
        Me.txt_hc_FreCardiaca.TabIndex = 186
        '
        'txt_hc_TenArterial
        '
        Me.txt_hc_TenArterial.BackColor = System.Drawing.Color.White
        Me.txt_hc_TenArterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_TenArterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hc_TenArterial.Location = New System.Drawing.Point(5, 99)
        Me.txt_hc_TenArterial.Name = "txt_hc_TenArterial"
        Me.txt_hc_TenArterial.Size = New System.Drawing.Size(82, 24)
        Me.txt_hc_TenArterial.TabIndex = 185
        '
        'Label015
        '
        Me.Label015.BackColor = System.Drawing.Color.Transparent
        Me.Label015.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label015.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label015.ForeColor = System.Drawing.Color.Black
        Me.Label015.Location = New System.Drawing.Point(425, 54)
        Me.Label015.Name = "Label015"
        Me.Label015.Size = New System.Drawing.Size(82, 44)
        Me.Label015.TabIndex = 184
        Me.Label015.Text = "       PESO           kg"
        Me.Label015.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label014
        '
        Me.Label014.BackColor = System.Drawing.Color.Transparent
        Me.Label014.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label014.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label014.ForeColor = System.Drawing.Color.Black
        Me.Label014.Location = New System.Drawing.Point(341, 54)
        Me.Label014.Name = "Label014"
        Me.Label014.Size = New System.Drawing.Size(82, 44)
        Me.Label014.TabIndex = 183
        Me.Label014.Text = "SATURACION O %"
        Me.Label014.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label013
        '
        Me.Label013.BackColor = System.Drawing.Color.Transparent
        Me.Label013.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label013.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label013.ForeColor = System.Drawing.Color.Black
        Me.Label013.Location = New System.Drawing.Point(257, 54)
        Me.Label013.Name = "Label013"
        Me.Label013.Size = New System.Drawing.Size(82, 44)
        Me.Label013.TabIndex = 182
        Me.Label013.Text = "TEMPERATURA Cº"
        Me.Label013.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(173, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 44)
        Me.Label12.TabIndex = 181
        Me.Label12.Text = "FRECUENCIA RESPIRATORIA rpm"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(89, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 44)
        Me.Label11.TabIndex = 180
        Me.Label11.Text = "FRECUENCIA CARDIACA   Lpm"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 44)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "PRESION ARTERIAL mmHg"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_SalirSignosV
        '
        Me.btn_SalirSignosV.BackColor = System.Drawing.Color.White
        Me.btn_SalirSignosV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SalirSignosV.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SalirSignosV.Image = CType(resources.GetObject("btn_SalirSignosV.Image"), System.Drawing.Image)
        Me.btn_SalirSignosV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SalirSignosV.Location = New System.Drawing.Point(938, 52)
        Me.btn_SalirSignosV.Name = "btn_SalirSignosV"
        Me.btn_SalirSignosV.Size = New System.Drawing.Size(86, 36)
        Me.btn_SalirSignosV.TabIndex = 196
        Me.btn_SalirSignosV.Text = "SALIR"
        Me.btn_SalirSignosV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_SalirSignosV.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 25)
        Me.Panel1.TabIndex = 181
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "SIGNOS VITALES"
        '
        'dgv_SignosV
        '
        Me.dgv_SignosV.AllowUserToAddRows = False
        Me.dgv_SignosV.AllowUserToDeleteRows = False
        Me.dgv_SignosV.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgv_SignosV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_SignosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SignosV.Location = New System.Drawing.Point(12, 243)
        Me.dgv_SignosV.Name = "dgv_SignosV"
        Me.dgv_SignosV.ReadOnly = True
        Me.dgv_SignosV.RowHeadersVisible = False
        Me.dgv_SignosV.Size = New System.Drawing.Size(644, 184)
        Me.dgv_SignosV.TabIndex = 182
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.ForeColor = System.Drawing.Color.Navy
        Me.lbl_paciente.Location = New System.Drawing.Point(126, 41)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(116, 24)
        Me.lbl_paciente.TabIndex = 183
        Me.lbl_paciente.Text = "(PACIENTE)"
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.ForeColor = System.Drawing.Color.Navy
        Me.lbl_edad.Location = New System.Drawing.Point(79, 65)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(74, 24)
        Me.lbl_edad.TabIndex = 184
        Me.lbl_edad.Text = "(EDAD)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 24)
        Me.Label14.TabIndex = 189
        Me.Label14.Text = "PACIENTE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 24)
        Me.Label13.TabIndex = 188
        Me.Label13.Text = "EDAD:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.txt_FR_Drogas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_AddFR)
        Me.GroupBox1.Controls.Add(Me.btn_ImpFR)
        Me.GroupBox1.Controls.Add(Me.txt_FR_Sedent)
        Me.GroupBox1.Controls.Add(Me.txt_FR_Alcohol)
        Me.GroupBox1.Controls.Add(Me.txt_FR_Cigarro)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(662, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 135)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        '
        'txt_FR_Drogas
        '
        Me.txt_FR_Drogas.BackColor = System.Drawing.Color.White
        Me.txt_FR_Drogas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FR_Drogas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FR_Drogas.Location = New System.Drawing.Point(265, 99)
        Me.txt_FR_Drogas.Name = "txt_FR_Drogas"
        Me.txt_FR_Drogas.ReadOnly = True
        Me.txt_FR_Drogas.Size = New System.Drawing.Size(82, 24)
        Me.txt_FR_Drogas.TabIndex = 197
        Me.txt_FR_Drogas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(265, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 44)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "DROGAS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_AddFR
        '
        Me.btn_AddFR.BackColor = System.Drawing.Color.White
        Me.btn_AddFR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddFR.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddFR.Image = CType(resources.GetObject("btn_AddFR.Image"), System.Drawing.Image)
        Me.btn_AddFR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AddFR.Location = New System.Drawing.Point(173, 14)
        Me.btn_AddFR.Name = "btn_AddFR"
        Me.btn_AddFR.Size = New System.Drawing.Size(76, 36)
        Me.btn_AddFR.TabIndex = 195
        Me.btn_AddFR.Text = "AÑADIR"
        Me.btn_AddFR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AddFR.UseVisualStyleBackColor = False
        '
        'btn_ImpFR
        '
        Me.btn_ImpFR.BackColor = System.Drawing.Color.White
        Me.btn_ImpFR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImpFR.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpFR.Image = CType(resources.GetObject("btn_ImpFR.Image"), System.Drawing.Image)
        Me.btn_ImpFR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpFR.Location = New System.Drawing.Point(251, 14)
        Me.btn_ImpFR.Name = "btn_ImpFR"
        Me.btn_ImpFR.Size = New System.Drawing.Size(94, 36)
        Me.btn_ImpFR.TabIndex = 192
        Me.btn_ImpFR.Text = "Fac. Riesgo"
        Me.btn_ImpFR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpFR.UseVisualStyleBackColor = False
        '
        'txt_FR_Sedent
        '
        Me.txt_FR_Sedent.BackColor = System.Drawing.Color.White
        Me.txt_FR_Sedent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FR_Sedent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FR_Sedent.Location = New System.Drawing.Point(173, 99)
        Me.txt_FR_Sedent.Name = "txt_FR_Sedent"
        Me.txt_FR_Sedent.ReadOnly = True
        Me.txt_FR_Sedent.Size = New System.Drawing.Size(89, 24)
        Me.txt_FR_Sedent.TabIndex = 187
        Me.txt_FR_Sedent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_FR_Alcohol
        '
        Me.txt_FR_Alcohol.BackColor = System.Drawing.Color.White
        Me.txt_FR_Alcohol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FR_Alcohol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FR_Alcohol.Location = New System.Drawing.Point(89, 99)
        Me.txt_FR_Alcohol.Name = "txt_FR_Alcohol"
        Me.txt_FR_Alcohol.ReadOnly = True
        Me.txt_FR_Alcohol.Size = New System.Drawing.Size(82, 24)
        Me.txt_FR_Alcohol.TabIndex = 186
        Me.txt_FR_Alcohol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_FR_Cigarro
        '
        Me.txt_FR_Cigarro.BackColor = System.Drawing.Color.White
        Me.txt_FR_Cigarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FR_Cigarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FR_Cigarro.Location = New System.Drawing.Point(5, 99)
        Me.txt_FR_Cigarro.Name = "txt_FR_Cigarro"
        Me.txt_FR_Cigarro.ReadOnly = True
        Me.txt_FR_Cigarro.Size = New System.Drawing.Size(82, 24)
        Me.txt_FR_Cigarro.TabIndex = 185
        Me.txt_FR_Cigarro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(173, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 44)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "SEDENTARISMO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(89, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 44)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "ALCOHOL"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(5, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 44)
        Me.Label15.TabIndex = 179
        Me.Label15.Text = "CIGARRILO"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lst_Cigarro
        '
        Me.lst_Cigarro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lst_Cigarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Cigarro.FormattingEnabled = True
        Me.lst_Cigarro.ItemHeight = 18
        Me.lst_Cigarro.Items.AddRange(New Object() {"Ninguno", "Medio", "Alto"})
        Me.lst_Cigarro.Location = New System.Drawing.Point(667, 243)
        Me.lst_Cigarro.Name = "lst_Cigarro"
        Me.lst_Cigarro.Size = New System.Drawing.Size(82, 58)
        Me.lst_Cigarro.TabIndex = 203
        '
        'lst_Alcohol
        '
        Me.lst_Alcohol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lst_Alcohol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Alcohol.FormattingEnabled = True
        Me.lst_Alcohol.ItemHeight = 18
        Me.lst_Alcohol.Items.AddRange(New Object() {"Ninguno", "Medio", "Alto"})
        Me.lst_Alcohol.Location = New System.Drawing.Point(752, 243)
        Me.lst_Alcohol.Name = "lst_Alcohol"
        Me.lst_Alcohol.Size = New System.Drawing.Size(82, 58)
        Me.lst_Alcohol.TabIndex = 204
        '
        'lst_Sedent
        '
        Me.lst_Sedent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lst_Sedent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Sedent.FormattingEnabled = True
        Me.lst_Sedent.ItemHeight = 18
        Me.lst_Sedent.Items.AddRange(New Object() {"Ninguno", "Medio", "Alto"})
        Me.lst_Sedent.Location = New System.Drawing.Point(837, 243)
        Me.lst_Sedent.Name = "lst_Sedent"
        Me.lst_Sedent.Size = New System.Drawing.Size(87, 58)
        Me.lst_Sedent.TabIndex = 205
        '
        'lst_Drogas
        '
        Me.lst_Drogas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lst_Drogas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Drogas.FormattingEnabled = True
        Me.lst_Drogas.ItemHeight = 18
        Me.lst_Drogas.Items.AddRange(New Object() {"Ninguno", "Medio", "Alto"})
        Me.lst_Drogas.Location = New System.Drawing.Point(927, 243)
        Me.lst_Drogas.Name = "lst_Drogas"
        Me.lst_Drogas.Size = New System.Drawing.Size(82, 58)
        Me.lst_Drogas.TabIndex = 206
        '
        'frm_SignosVitales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1031, 457)
        Me.Controls.Add(Me.lst_Drogas)
        Me.Controls.Add(Me.lst_Sedent)
        Me.Controls.Add(Me.lst_Alcohol)
        Me.Controls.Add(Me.lst_Cigarro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_SalirSignosV)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_edad)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.dgv_SignosV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grp_SVitales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_SignosVitales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_SignosVitales"
        Me.grp_SVitales.ResumeLayout(False)
        Me.grp_SVitales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_SignosV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_SVitales As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_hc_fechaSV As System.Windows.Forms.Label
    Friend WithEvents btn_ImpSignosV As System.Windows.Forms.Button
    Friend WithEvents txt_hc_Peso As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Saturacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Temperatura As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_FrecResp As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_FreCardiaca As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_TenArterial As System.Windows.Forms.TextBox
    Friend WithEvents Label015 As System.Windows.Forms.Label
    Friend WithEvents Label014 As System.Windows.Forms.Label
    Friend WithEvents Label013 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_SignosV As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_SalirSignosV As System.Windows.Forms.Button
    Friend WithEvents txt_hc_Audiometria As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_AddFR As System.Windows.Forms.Button
    Friend WithEvents btn_ImpFR As System.Windows.Forms.Button
    Friend WithEvents txt_FR_Sedent As System.Windows.Forms.TextBox
    Friend WithEvents txt_FR_Alcohol As System.Windows.Forms.TextBox
    Friend WithEvents txt_FR_Cigarro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_FR_Drogas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lst_Cigarro As System.Windows.Forms.ListBox
    Friend WithEvents lst_Alcohol As System.Windows.Forms.ListBox
    Friend WithEvents lst_Sedent As System.Windows.Forms.ListBox
    Friend WithEvents lst_Drogas As System.Windows.Forms.ListBox
End Class
