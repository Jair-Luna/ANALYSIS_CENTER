<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FiltroAreas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FiltroAreas))
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.cmb_area = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmb_Prioridad = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dgrd_areas = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbl_msg = New System.Windows.Forms.Label
        Me.chk_PorTest = New System.Windows.Forms.CheckBox
        Me.lbl_LabOcup = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_areas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(9, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(65, 18)
        Me.lbl_textform.TabIndex = 93
        Me.lbl_textform.Text = "FILTRO"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_Salir.Location = New System.Drawing.Point(222, 181)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 39)
        Me.btn_Salir.TabIndex = 94
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(139, 71)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(91, 20)
        Me.dtp_ff.TabIndex = 164
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Black
        Me.lbl_hasta.Location = New System.Drawing.Point(97, 75)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(46, 16)
        Me.lbl_hasta.TabIndex = 162
        Me.lbl_hasta.Text = "Hasta:"
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(138, 44)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(91, 20)
        Me.dtp_fi.TabIndex = 163
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Black
        Me.lbl_desde.Location = New System.Drawing.Point(97, 48)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(45, 16)
        Me.lbl_desde.TabIndex = 161
        Me.lbl_desde.Text = "Desde:"
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.Location = New System.Drawing.Point(139, 97)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(170, 21)
        Me.cmb_area.TabIndex = 165
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(97, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 12)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "AREA:"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_buscar.Enabled = False
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(140, 181)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 39)
        Me.btn_buscar.TabIndex = 168
        Me.btn_buscar.Text = "Aceptar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 169
        Me.PictureBox1.TabStop = False
        '
        'cmb_Prioridad
        '
        Me.cmb_Prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Prioridad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Prioridad.ForeColor = System.Drawing.Color.Black
        Me.cmb_Prioridad.Location = New System.Drawing.Point(138, 124)
        Me.cmb_Prioridad.Name = "cmb_Prioridad"
        Me.cmb_Prioridad.Size = New System.Drawing.Size(171, 27)
        Me.cmb_Prioridad.TabIndex = 170
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(74, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "CONVENIO:"
        '
        'dgrd_areas
        '
        Me.dgrd_areas.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_areas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_areas.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_areas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_areas.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_areas.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_areas.CaptionText = "AREAS SELECCIONADAS"
        Me.dgrd_areas.DataMember = ""
        Me.dgrd_areas.FlatMode = True
        Me.dgrd_areas.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_areas.ForeColor = System.Drawing.Color.Black
        Me.dgrd_areas.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_areas.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_areas.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_areas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_areas.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_areas.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_areas.Location = New System.Drawing.Point(327, 44)
        Me.dgrd_areas.Name = "dgrd_areas"
        Me.dgrd_areas.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_areas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_areas.ReadOnly = True
        Me.dgrd_areas.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_areas.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_areas.Size = New System.Drawing.Size(237, 158)
        Me.dgrd_areas.TabIndex = 173
        Me.dgrd_areas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_areas
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = "###,##0;###,##0"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID"
        Me.DataGridTextBoxColumn1.MappingName = "are_id"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 30
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "AREA"
        Me.DataGridTextBoxColumn2.MappingName = "are_nombre"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'lbl_msg
        '
        Me.lbl_msg.AutoSize = True
        Me.lbl_msg.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_msg.Location = New System.Drawing.Point(340, 32)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(0, 13)
        Me.lbl_msg.TabIndex = 174
        '
        'chk_PorTest
        '
        Me.chk_PorTest.AutoSize = True
        Me.chk_PorTest.Location = New System.Drawing.Point(138, 158)
        Me.chk_PorTest.Name = "chk_PorTest"
        Me.chk_PorTest.Size = New System.Drawing.Size(73, 17)
        Me.chk_PorTest.TabIndex = 175
        Me.chk_PorTest.Text = "Por TEST"
        Me.chk_PorTest.UseVisualStyleBackColor = True
        '
        'lbl_LabOcup
        '
        Me.lbl_LabOcup.AutoSize = True
        Me.lbl_LabOcup.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_LabOcup.Location = New System.Drawing.Point(488, 205)
        Me.lbl_LabOcup.Name = "lbl_LabOcup"
        Me.lbl_LabOcup.Size = New System.Drawing.Size(73, 13)
        Me.lbl_LabOcup.TabIndex = 176
        Me.lbl_LabOcup.Text = "(lbl_LabOcup)"
        Me.lbl_LabOcup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_FiltroAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(588, 235)
        Me.Controls.Add(Me.lbl_LabOcup)
        Me.Controls.Add(Me.chk_PorTest)
        Me.Controls.Add(Me.lbl_msg)
        Me.Controls.Add(Me.dgrd_areas)
        Me.Controls.Add(Me.cmb_Prioridad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.lbl_textform)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_FiltroAreas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_areas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_Prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgrd_areas As System.Windows.Forms.DataGrid
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_PorTest As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_LabOcup As System.Windows.Forms.Label
End Class
