<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ExamenFisico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ExamenFisico))
        Me.grp_ExFisico = New System.Windows.Forms.GroupBox
        Me.lbl_hc_fechaEF = New System.Windows.Forms.Label
        Me.btn_NuevoExFisico = New System.Windows.Forms.Button
        Me.btn_ImpExFisico = New System.Windows.Forms.Button
        Me.btn_HistoricoExFisico = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txt_hc_Extremidades = New System.Windows.Forms.TextBox
        Me.txt_hc_Abdomen = New System.Windows.Forms.TextBox
        Me.txt_hc_Corazon = New System.Windows.Forms.TextBox
        Me.txt_hc_Pulmones = New System.Windows.Forms.TextBox
        Me.txt_hc_Torax = New System.Windows.Forms.TextBox
        Me.txt_hc_Cuello = New System.Windows.Forms.TextBox
        Me.txt_hc_Orofaringe = New System.Windows.Forms.TextBox
        Me.txt_hc_Nariz = New System.Windows.Forms.TextBox
        Me.txt_hc_Oidos = New System.Windows.Forms.TextBox
        Me.txt_hc_Cabeza = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.grp_ExFisico.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_ExFisico
        '
        Me.grp_ExFisico.BackColor = System.Drawing.Color.Silver
        Me.grp_ExFisico.Controls.Add(Me.lbl_hc_fechaEF)
        Me.grp_ExFisico.Controls.Add(Me.btn_NuevoExFisico)
        Me.grp_ExFisico.Controls.Add(Me.btn_ImpExFisico)
        Me.grp_ExFisico.Controls.Add(Me.btn_HistoricoExFisico)
        Me.grp_ExFisico.Controls.Add(Me.Label11)
        Me.grp_ExFisico.Controls.Add(Me.PictureBox1)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Extremidades)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Abdomen)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Corazon)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Pulmones)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Torax)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Cuello)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Orofaringe)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Nariz)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Oidos)
        Me.grp_ExFisico.Controls.Add(Me.txt_hc_Cabeza)
        Me.grp_ExFisico.Controls.Add(Me.Label26)
        Me.grp_ExFisico.Controls.Add(Me.Label25)
        Me.grp_ExFisico.Controls.Add(Me.Label24)
        Me.grp_ExFisico.Controls.Add(Me.Label23)
        Me.grp_ExFisico.Controls.Add(Me.Label22)
        Me.grp_ExFisico.Controls.Add(Me.Label21)
        Me.grp_ExFisico.Controls.Add(Me.Label20)
        Me.grp_ExFisico.Controls.Add(Me.Label19)
        Me.grp_ExFisico.Controls.Add(Me.Label18)
        Me.grp_ExFisico.Controls.Add(Me.Label17)
        Me.grp_ExFisico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_ExFisico.Location = New System.Drawing.Point(12, 23)
        Me.grp_ExFisico.Name = "grp_ExFisico"
        Me.grp_ExFisico.Size = New System.Drawing.Size(980, 240)
        Me.grp_ExFisico.TabIndex = 181
        Me.grp_ExFisico.TabStop = False
        Me.grp_ExFisico.Text = "EXAMEN FISICO"
        '
        'lbl_hc_fechaEF
        '
        Me.lbl_hc_fechaEF.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hc_fechaEF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hc_fechaEF.ForeColor = System.Drawing.Color.Red
        Me.lbl_hc_fechaEF.Location = New System.Drawing.Point(8, 16)
        Me.lbl_hc_fechaEF.Name = "lbl_hc_fechaEF"
        Me.lbl_hc_fechaEF.Size = New System.Drawing.Size(106, 11)
        Me.lbl_hc_fechaEF.TabIndex = 197
        Me.lbl_hc_fechaEF.Text = "FECHA EF"
        '
        'btn_NuevoExFisico
        '
        Me.btn_NuevoExFisico.BackColor = System.Drawing.Color.White
        Me.btn_NuevoExFisico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NuevoExFisico.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NuevoExFisico.Image = CType(resources.GetObject("btn_NuevoExFisico.Image"), System.Drawing.Image)
        Me.btn_NuevoExFisico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NuevoExFisico.Location = New System.Drawing.Point(717, 19)
        Me.btn_NuevoExFisico.Name = "btn_NuevoExFisico"
        Me.btn_NuevoExFisico.Size = New System.Drawing.Size(76, 30)
        Me.btn_NuevoExFisico.TabIndex = 196
        Me.btn_NuevoExFisico.Text = "NUEVO"
        Me.btn_NuevoExFisico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NuevoExFisico.UseVisualStyleBackColor = False
        '
        'btn_ImpExFisico
        '
        Me.btn_ImpExFisico.BackColor = System.Drawing.Color.White
        Me.btn_ImpExFisico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImpExFisico.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpExFisico.Image = CType(resources.GetObject("btn_ImpExFisico.Image"), System.Drawing.Image)
        Me.btn_ImpExFisico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpExFisico.Location = New System.Drawing.Point(794, 19)
        Me.btn_ImpExFisico.Name = "btn_ImpExFisico"
        Me.btn_ImpExFisico.Size = New System.Drawing.Size(76, 30)
        Me.btn_ImpExFisico.TabIndex = 195
        Me.btn_ImpExFisico.Text = "EXAMEN"
        Me.btn_ImpExFisico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpExFisico.UseVisualStyleBackColor = False
        '
        'btn_HistoricoExFisico
        '
        Me.btn_HistoricoExFisico.BackColor = System.Drawing.Color.White
        Me.btn_HistoricoExFisico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_HistoricoExFisico.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_HistoricoExFisico.Image = CType(resources.GetObject("btn_HistoricoExFisico.Image"), System.Drawing.Image)
        Me.btn_HistoricoExFisico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HistoricoExFisico.Location = New System.Drawing.Point(871, 19)
        Me.btn_HistoricoExFisico.Name = "btn_HistoricoExFisico"
        Me.btn_HistoricoExFisico.Size = New System.Drawing.Size(86, 30)
        Me.btn_HistoricoExFisico.TabIndex = 194
        Me.btn_HistoricoExFisico.Text = "HISTORICO"
        Me.btn_HistoricoExFisico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_HistoricoExFisico.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(588, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "INHALANTES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 179
        Me.PictureBox1.TabStop = False
        '
        'txt_hc_Extremidades
        '
        Me.txt_hc_Extremidades.BackColor = System.Drawing.Color.White
        Me.txt_hc_Extremidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Extremidades.Location = New System.Drawing.Point(646, 196)
        Me.txt_hc_Extremidades.Name = "txt_hc_Extremidades"
        Me.txt_hc_Extremidades.Size = New System.Drawing.Size(311, 20)
        Me.txt_hc_Extremidades.TabIndex = 178
        '
        'txt_hc_Abdomen
        '
        Me.txt_hc_Abdomen.BackColor = System.Drawing.Color.White
        Me.txt_hc_Abdomen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Abdomen.Location = New System.Drawing.Point(646, 167)
        Me.txt_hc_Abdomen.Name = "txt_hc_Abdomen"
        Me.txt_hc_Abdomen.Size = New System.Drawing.Size(311, 20)
        Me.txt_hc_Abdomen.TabIndex = 177
        '
        'txt_hc_Corazon
        '
        Me.txt_hc_Corazon.BackColor = System.Drawing.Color.White
        Me.txt_hc_Corazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Corazon.Location = New System.Drawing.Point(646, 138)
        Me.txt_hc_Corazon.Name = "txt_hc_Corazon"
        Me.txt_hc_Corazon.Size = New System.Drawing.Size(311, 20)
        Me.txt_hc_Corazon.TabIndex = 176
        '
        'txt_hc_Pulmones
        '
        Me.txt_hc_Pulmones.BackColor = System.Drawing.Color.White
        Me.txt_hc_Pulmones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Pulmones.Location = New System.Drawing.Point(646, 110)
        Me.txt_hc_Pulmones.Name = "txt_hc_Pulmones"
        Me.txt_hc_Pulmones.Size = New System.Drawing.Size(311, 20)
        Me.txt_hc_Pulmones.TabIndex = 175
        '
        'txt_hc_Torax
        '
        Me.txt_hc_Torax.BackColor = System.Drawing.Color.White
        Me.txt_hc_Torax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Torax.Location = New System.Drawing.Point(646, 82)
        Me.txt_hc_Torax.Name = "txt_hc_Torax"
        Me.txt_hc_Torax.Size = New System.Drawing.Size(311, 20)
        Me.txt_hc_Torax.TabIndex = 174
        '
        'txt_hc_Cuello
        '
        Me.txt_hc_Cuello.BackColor = System.Drawing.Color.White
        Me.txt_hc_Cuello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Cuello.Location = New System.Drawing.Point(646, 55)
        Me.txt_hc_Cuello.Name = "txt_hc_Cuello"
        Me.txt_hc_Cuello.Size = New System.Drawing.Size(311, 20)
        Me.txt_hc_Cuello.TabIndex = 173
        '
        'txt_hc_Orofaringe
        '
        Me.txt_hc_Orofaringe.BackColor = System.Drawing.Color.White
        Me.txt_hc_Orofaringe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Orofaringe.Location = New System.Drawing.Point(230, 183)
        Me.txt_hc_Orofaringe.Multiline = True
        Me.txt_hc_Orofaringe.Name = "txt_hc_Orofaringe"
        Me.txt_hc_Orofaringe.Size = New System.Drawing.Size(311, 47)
        Me.txt_hc_Orofaringe.TabIndex = 172
        '
        'txt_hc_Nariz
        '
        Me.txt_hc_Nariz.BackColor = System.Drawing.Color.White
        Me.txt_hc_Nariz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Nariz.Location = New System.Drawing.Point(230, 130)
        Me.txt_hc_Nariz.Multiline = True
        Me.txt_hc_Nariz.Name = "txt_hc_Nariz"
        Me.txt_hc_Nariz.Size = New System.Drawing.Size(311, 47)
        Me.txt_hc_Nariz.TabIndex = 171
        '
        'txt_hc_Oidos
        '
        Me.txt_hc_Oidos.BackColor = System.Drawing.Color.White
        Me.txt_hc_Oidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Oidos.Location = New System.Drawing.Point(230, 81)
        Me.txt_hc_Oidos.Multiline = True
        Me.txt_hc_Oidos.Name = "txt_hc_Oidos"
        Me.txt_hc_Oidos.Size = New System.Drawing.Size(311, 43)
        Me.txt_hc_Oidos.TabIndex = 170
        '
        'txt_hc_Cabeza
        '
        Me.txt_hc_Cabeza.BackColor = System.Drawing.Color.White
        Me.txt_hc_Cabeza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_Cabeza.Location = New System.Drawing.Point(230, 55)
        Me.txt_hc_Cabeza.Name = "txt_hc_Cabeza"
        Me.txt_hc_Cabeza.Size = New System.Drawing.Size(311, 20)
        Me.txt_hc_Cabeza.TabIndex = 169
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(561, 199)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 16)
        Me.Label26.TabIndex = 168
        Me.Label26.Text = "EXTREMIDADES:"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(560, 171)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 16)
        Me.Label25.TabIndex = 167
        Me.Label25.Text = "ABDOMEN:"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(560, 143)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 16)
        Me.Label24.TabIndex = 166
        Me.Label24.Text = "CORAZON"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(560, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 16)
        Me.Label23.TabIndex = 165
        Me.Label23.Text = "PULMONES:"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(560, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 16)
        Me.Label22.TabIndex = 164
        Me.Label22.Text = "TORAX:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(560, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 16)
        Me.Label21.TabIndex = 163
        Me.Label21.Text = "CUELLO:"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(152, 185)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 16)
        Me.Label20.TabIndex = 162
        Me.Label20.Text = "OROFARINGE:"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(152, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 16)
        Me.Label19.TabIndex = 161
        Me.Label19.Text = "NARIZ:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(152, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 16)
        Me.Label18.TabIndex = 160
        Me.Label18.Text = "OIDOS:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(152, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 16)
        Me.Label17.TabIndex = 159
        Me.Label17.Text = "CABEZA:"
        '
        'frm_ExamenFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 278)
        Me.Controls.Add(Me.grp_ExFisico)
        Me.Name = "frm_ExamenFisico"
        Me.Text = "frm_ExamenFisico"
        Me.grp_ExFisico.ResumeLayout(False)
        Me.grp_ExFisico.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_ExFisico As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_hc_fechaEF As System.Windows.Forms.Label
    Friend WithEvents btn_NuevoExFisico As System.Windows.Forms.Button
    Friend WithEvents btn_ImpExFisico As System.Windows.Forms.Button
    Friend WithEvents btn_HistoricoExFisico As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_hc_Extremidades As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Abdomen As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Corazon As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Pulmones As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Torax As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Cuello As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Orofaringe As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Nariz As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Oidos As System.Windows.Forms.TextBox
    Friend WithEvents txt_hc_Cabeza As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
