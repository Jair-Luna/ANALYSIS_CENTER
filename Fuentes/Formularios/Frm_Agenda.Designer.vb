<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Agenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Agenda))
        Me.btn_imprimirCal = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.cal1 = New System.Windows.Forms.MonthCalendar
        Me.dgrd_Cal = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmb_tratante = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Hora = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.lbl_medico = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_imprimirCalDia = New System.Windows.Forms.Button
        Me.btn_imprimirCalSemana = New System.Windows.Forms.Button
        Me.btn_NotificarMail = New System.Windows.Forms.Button
        Me.btn_imprimirCalMedico = New System.Windows.Forms.Button
        Me.chkl_recom = New System.Windows.Forms.CheckedListBox
        CType(Me.dgrd_Cal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_imprimirCal
        '
        Me.btn_imprimirCal.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimirCal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirCal.Enabled = False
        Me.btn_imprimirCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirCal.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirCal.Image = CType(resources.GetObject("btn_imprimirCal.Image"), System.Drawing.Image)
        Me.btn_imprimirCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirCal.Location = New System.Drawing.Point(209, 501)
        Me.btn_imprimirCal.Name = "btn_imprimirCal"
        Me.btn_imprimirCal.Size = New System.Drawing.Size(90, 43)
        Me.btn_imprimirCal.TabIndex = 130
        Me.btn_imprimirCal.Text = "Evento"
        Me.btn_imprimirCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirCal.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.Location = New System.Drawing.Point(573, 502)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(90, 43)
        Me.btn_Salir.TabIndex = 129
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Enabled = False
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.Location = New System.Drawing.Point(27, 501)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(90, 43)
        Me.btn_Aceptar.TabIndex = 128
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(10, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(384, 18)
        Me.lbl_textform.TabIndex = 125
        Me.lbl_textform.Text = "AGENDAMIENTO DE CONSULTAS / LABORATOIRO"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cal1
        '
        Me.cal1.Location = New System.Drawing.Point(30, 35)
        Me.cal1.Name = "cal1"
        Me.cal1.TabIndex = 132
        '
        'dgrd_Cal
        '
        Me.dgrd_Cal.AllowNavigation = False
        Me.dgrd_Cal.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Cal.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Cal.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Cal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Cal.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Cal.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Cal.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Cal.CaptionText = "CALENDARIO"
        Me.dgrd_Cal.DataMember = ""
        Me.dgrd_Cal.FlatMode = True
        Me.dgrd_Cal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Cal.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Cal.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Cal.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Cal.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Cal.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Cal.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Cal.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Cal.Location = New System.Drawing.Point(275, 34)
        Me.dgrd_Cal.Name = "dgrd_Cal"
        Me.dgrd_Cal.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Cal.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Cal.PreferredColumnWidth = 95
        Me.dgrd_Cal.PreferredRowHeight = 24
        Me.dgrd_Cal.ReadOnly = True
        Me.dgrd_Cal.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Cal.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Cal.Size = New System.Drawing.Size(388, 448)
        Me.dgrd_Cal.TabIndex = 133
        Me.dgrd_Cal.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Cal.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Cal
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.PreferredRowHeight = 50
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "HORA"
        Me.DataGridTextBoxColumn6.MappingName = "age_hora"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "AGENDA"
        Me.DataGridTextBoxColumn7.MappingName = "age_resumen"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 250
        '
        'cmb_tratante
        '
        Me.cmb_tratante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tratante.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tratante.Location = New System.Drawing.Point(26, 204)
        Me.cmb_tratante.Name = "cmb_tratante"
        Me.cmb_tratante.Size = New System.Drawing.Size(237, 21)
        Me.cmb_tratante.TabIndex = 134
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "RECOMENDACIONES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(29, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "MEDICO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "FECHA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "HORA:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.lbl_paciente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_Hora)
        Me.Panel1.Controls.Add(Me.lbl_Fecha)
        Me.Panel1.Controls.Add(Me.lbl_medico)
        Me.Panel1.Location = New System.Drawing.Point(24, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 100)
        Me.Panel1.TabIndex = 146
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_paciente.Location = New System.Drawing.Point(71, 66)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(0, 13)
        Me.lbl_paciente.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(4, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "PACIENTE:"
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(63, 20)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(0, 15)
        Me.lbl_Hora.TabIndex = 149
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(63, 2)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(0, 15)
        Me.lbl_Fecha.TabIndex = 148
        '
        'lbl_medico
        '
        Me.lbl_medico.AutoSize = True
        Me.lbl_medico.BackColor = System.Drawing.Color.Transparent
        Me.lbl_medico.Location = New System.Drawing.Point(62, 46)
        Me.lbl_medico.Name = "lbl_medico"
        Me.lbl_medico.Size = New System.Drawing.Size(0, 13)
        Me.lbl_medico.TabIndex = 147
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn3.MappingName = "cal_estado"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "HORA"
        Me.DataGridTextBoxColumn2.MappingName = "cal_hora"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID"
        Me.DataGridTextBoxColumn1.MappingName = "cal_id"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "AGENDA"
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "FECHA"
        Me.DataGridTextBoxColumn5.MappingName = "age_fecha"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'btn_imprimirCalDia
        '
        Me.btn_imprimirCalDia.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimirCalDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirCalDia.Enabled = False
        Me.btn_imprimirCalDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirCalDia.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirCalDia.Image = CType(resources.GetObject("btn_imprimirCalDia.Image"), System.Drawing.Image)
        Me.btn_imprimirCalDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirCalDia.Location = New System.Drawing.Point(300, 501)
        Me.btn_imprimirCalDia.Name = "btn_imprimirCalDia"
        Me.btn_imprimirCalDia.Size = New System.Drawing.Size(90, 43)
        Me.btn_imprimirCalDia.TabIndex = 147
        Me.btn_imprimirCalDia.Text = "Diaria"
        Me.btn_imprimirCalDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirCalDia.UseVisualStyleBackColor = False
        '
        'btn_imprimirCalSemana
        '
        Me.btn_imprimirCalSemana.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimirCalSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirCalSemana.Enabled = False
        Me.btn_imprimirCalSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirCalSemana.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirCalSemana.Image = CType(resources.GetObject("btn_imprimirCalSemana.Image"), System.Drawing.Image)
        Me.btn_imprimirCalSemana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirCalSemana.Location = New System.Drawing.Point(391, 501)
        Me.btn_imprimirCalSemana.Name = "btn_imprimirCalSemana"
        Me.btn_imprimirCalSemana.Size = New System.Drawing.Size(90, 43)
        Me.btn_imprimirCalSemana.TabIndex = 148
        Me.btn_imprimirCalSemana.Text = "Semanal"
        Me.btn_imprimirCalSemana.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirCalSemana.UseVisualStyleBackColor = False
        '
        'btn_NotificarMail
        '
        Me.btn_NotificarMail.BackColor = System.Drawing.SystemColors.Control
        Me.btn_NotificarMail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NotificarMail.Enabled = False
        Me.btn_NotificarMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NotificarMail.ForeColor = System.Drawing.Color.Black
        Me.btn_NotificarMail.Image = CType(resources.GetObject("btn_NotificarMail.Image"), System.Drawing.Image)
        Me.btn_NotificarMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NotificarMail.Location = New System.Drawing.Point(118, 501)
        Me.btn_NotificarMail.Name = "btn_NotificarMail"
        Me.btn_NotificarMail.Size = New System.Drawing.Size(90, 43)
        Me.btn_NotificarMail.TabIndex = 149
        Me.btn_NotificarMail.Text = "Notificar"
        Me.btn_NotificarMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NotificarMail.UseVisualStyleBackColor = False
        '
        'btn_imprimirCalMedico
        '
        Me.btn_imprimirCalMedico.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimirCalMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirCalMedico.Enabled = False
        Me.btn_imprimirCalMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirCalMedico.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirCalMedico.Image = CType(resources.GetObject("btn_imprimirCalMedico.Image"), System.Drawing.Image)
        Me.btn_imprimirCalMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirCalMedico.Location = New System.Drawing.Point(482, 501)
        Me.btn_imprimirCalMedico.Name = "btn_imprimirCalMedico"
        Me.btn_imprimirCalMedico.Size = New System.Drawing.Size(90, 43)
        Me.btn_imprimirCalMedico.TabIndex = 150
        Me.btn_imprimirCalMedico.Text = "Médico"
        Me.btn_imprimirCalMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirCalMedico.UseVisualStyleBackColor = False
        '
        'chkl_recom
        '
        Me.chkl_recom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkl_recom.CheckOnClick = True
        Me.chkl_recom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkl_recom.Location = New System.Drawing.Point(24, 384)
        Me.chkl_recom.Name = "chkl_recom"
        Me.chkl_recom.Size = New System.Drawing.Size(239, 98)
        Me.chkl_recom.TabIndex = 151
        '
        'Frm_Agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(683, 559)
        Me.Controls.Add(Me.chkl_recom)
        Me.Controls.Add(Me.btn_imprimirCalMedico)
        Me.Controls.Add(Me.btn_NotificarMail)
        Me.Controls.Add(Me.btn_imprimirCalSemana)
        Me.Controls.Add(Me.btn_imprimirCalDia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_tratante)
        Me.Controls.Add(Me.dgrd_Cal)
        Me.Controls.Add(Me.cal1)
        Me.Controls.Add(Me.btn_imprimirCal)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Agenda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Agenda"
        CType(Me.dgrd_Cal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_imprimirCal As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents cal1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgrd_Cal As System.Windows.Forms.DataGrid
    Friend WithEvents cmb_tratante As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_medico As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_imprimirCalDia As System.Windows.Forms.Button
    Friend WithEvents btn_imprimirCalSemana As System.Windows.Forms.Button
    Friend WithEvents btn_NotificarMail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents btn_imprimirCalMedico As System.Windows.Forms.Button
    Friend WithEvents chkl_recom As System.Windows.Forms.CheckedListBox
End Class
