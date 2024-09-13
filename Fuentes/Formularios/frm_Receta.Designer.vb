<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Receta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Receta))
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.txt_Medicacion = New System.Windows.Forms.TextBox
        Me.txt_Indicaciones = New System.Windows.Forms.TextBox
        Me.btn_Vademecum = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_cedula = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_Cie10 = New System.Windows.Forms.TextBox
        Me.lbl_FechaReceta = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Pic_QR = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_FecValidez = New System.Windows.Forms.Label
        Me.txt_RecDieta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_RecMenu = New System.Windows.Forms.Button
        Me.btn_ImprimirReceta = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.pan_barra.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lbl_textform.Size = New System.Drawing.Size(143, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GENERAR RECETA"
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(993, 25)
        Me.pan_barra.TabIndex = 226
        '
        'txt_Medicacion
        '
        Me.txt_Medicacion.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_Medicacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Medicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Medicacion.Location = New System.Drawing.Point(15, 135)
        Me.txt_Medicacion.Multiline = True
        Me.txt_Medicacion.Name = "txt_Medicacion"
        Me.txt_Medicacion.Size = New System.Drawing.Size(464, 255)
        Me.txt_Medicacion.TabIndex = 231
        '
        'txt_Indicaciones
        '
        Me.txt_Indicaciones.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_Indicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Indicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Indicaciones.Location = New System.Drawing.Point(12, 135)
        Me.txt_Indicaciones.Multiline = True
        Me.txt_Indicaciones.Name = "txt_Indicaciones"
        Me.txt_Indicaciones.Size = New System.Drawing.Size(444, 237)
        Me.txt_Indicaciones.TabIndex = 232
        '
        'btn_Vademecum
        '
        Me.btn_Vademecum.BackColor = System.Drawing.Color.White
        Me.btn_Vademecum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Vademecum.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Vademecum.Location = New System.Drawing.Point(362, 52)
        Me.btn_Vademecum.Name = "btn_Vademecum"
        Me.btn_Vademecum.Size = New System.Drawing.Size(99, 23)
        Me.btn_Vademecum.TabIndex = 236
        Me.btn_Vademecum.Text = "VADEMECUM"
        Me.btn_Vademecum.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_cedula)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lbl_paciente)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbl_Cie10)
        Me.Panel1.Controls.Add(Me.txt_Medicacion)
        Me.Panel1.Controls.Add(Me.lbl_FechaReceta)
        Me.Panel1.Location = New System.Drawing.Point(16, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 593)
        Me.Panel1.TabIndex = 238
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cedula.ForeColor = System.Drawing.Color.Black
        Me.lbl_cedula.Location = New System.Drawing.Point(102, 109)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(63, 15)
        Me.lbl_cedula.TabIndex = 250
        Me.lbl_cedula.Text = "(CEDULA)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 15)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "DOCUMENTO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 15)
        Me.Label14.TabIndex = 248
        Me.Label14.Text = "PACIENTE:"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.ForeColor = System.Drawing.Color.Black
        Me.lbl_paciente.Location = New System.Drawing.Point(102, 92)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(73, 15)
        Me.lbl_paciente.TabIndex = 247
        Me.lbl_paciente.Text = "(PACIENTE)"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 568)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(282, 14)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "Firma del Médico"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Cie10
        '
        Me.lbl_Cie10.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lbl_Cie10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_Cie10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cie10.Location = New System.Drawing.Point(15, 396)
        Me.lbl_Cie10.Multiline = True
        Me.lbl_Cie10.Name = "lbl_Cie10"
        Me.lbl_Cie10.Size = New System.Drawing.Size(446, 96)
        Me.lbl_Cie10.TabIndex = 243
        '
        'lbl_FechaReceta
        '
        Me.lbl_FechaReceta.AutoSize = True
        Me.lbl_FechaReceta.BackColor = System.Drawing.Color.White
        Me.lbl_FechaReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaReceta.Location = New System.Drawing.Point(362, 71)
        Me.lbl_FechaReceta.Name = "lbl_FechaReceta"
        Me.lbl_FechaReceta.Size = New System.Drawing.Size(108, 15)
        Me.lbl_FechaReceta.TabIndex = 239
        Me.lbl_FechaReceta.Text = "(FECHA_RECETA)"
        Me.lbl_FechaReceta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Pic_QR)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lbl_FecValidez)
        Me.Panel2.Controls.Add(Me.txt_RecDieta)
        Me.Panel2.Controls.Add(Me.txt_Indicaciones)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(504, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 593)
        Me.Panel2.TabIndex = 239
        '
        'Pic_QR
        '
        Me.Pic_QR.Location = New System.Drawing.Point(386, 9)
        Me.Pic_QR.Name = "Pic_QR"
        Me.Pic_QR.Size = New System.Drawing.Size(70, 62)
        Me.Pic_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_QR.TabIndex = 243
        Me.Pic_QR.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 251
        Me.Label7.Text = "Válido hasta:"
        '
        'lbl_FecValidez
        '
        Me.lbl_FecValidez.AutoSize = True
        Me.lbl_FecValidez.BackColor = System.Drawing.Color.White
        Me.lbl_FecValidez.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FecValidez.Location = New System.Drawing.Point(359, 71)
        Me.lbl_FecValidez.Name = "lbl_FecValidez"
        Me.lbl_FecValidez.Size = New System.Drawing.Size(108, 15)
        Me.lbl_FecValidez.TabIndex = 251
        Me.lbl_FecValidez.Text = "(FECHA_RECETA)"
        Me.lbl_FecValidez.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_RecDieta
        '
        Me.txt_RecDieta.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_RecDieta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_RecDieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RecDieta.Location = New System.Drawing.Point(12, 378)
        Me.txt_RecDieta.Multiline = True
        Me.txt_RecDieta.Name = "txt_RecDieta"
        Me.txt_RecDieta.Size = New System.Drawing.Size(444, 96)
        Me.txt_RecDieta.TabIndex = 244
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "INDICACIONES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 538)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 14)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "GUARDE ESTA PARTE DE LA RECETA"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 551)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 31)
        Me.Label2.TabIndex = 239
        Me.Label2.Text = "Los medicamentos marcados con una  X debe repetir por unos días en caso le volvie" & _
            "ran las molestias."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(261, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 241
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_RecMenu
        '
        Me.btn_RecMenu.BackColor = System.Drawing.Color.White
        Me.btn_RecMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_RecMenu.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RecMenu.Location = New System.Drawing.Point(466, 52)
        Me.btn_RecMenu.Name = "btn_RecMenu"
        Me.btn_RecMenu.Size = New System.Drawing.Size(99, 23)
        Me.btn_RecMenu.TabIndex = 242
        Me.btn_RecMenu.Text = "DIETA"
        Me.btn_RecMenu.UseVisualStyleBackColor = False
        '
        'btn_ImprimirReceta
        '
        Me.btn_ImprimirReceta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_ImprimirReceta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImprimirReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImprimirReceta.ForeColor = System.Drawing.Color.Black
        Me.btn_ImprimirReceta.Image = CType(resources.GetObject("btn_ImprimirReceta.Image"), System.Drawing.Image)
        Me.btn_ImprimirReceta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprimirReceta.Location = New System.Drawing.Point(755, 32)
        Me.btn_ImprimirReceta.Name = "btn_ImprimirReceta"
        Me.btn_ImprimirReceta.Size = New System.Drawing.Size(73, 40)
        Me.btn_ImprimirReceta.TabIndex = 240
        Me.btn_ImprimirReceta.Text = "Imprimir"
        Me.btn_ImprimirReceta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImprimirReceta.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(828, 32)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(73, 40)
        Me.btn_Salir.TabIndex = 234
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_Guardar.Image = CType(resources.GetObject("btn_Guardar.Image"), System.Drawing.Image)
        Me.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.Location = New System.Drawing.Point(683, 32)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Guardar.TabIndex = 233
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'frm_Receta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 702)
        Me.Controls.Add(Me.btn_RecMenu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_ImprimirReceta)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Vademecum)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.pan_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Receta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_Receta"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents txt_Medicacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Indicaciones As System.Windows.Forms.TextBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Vademecum As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_FechaReceta As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_ImprimirReceta As System.Windows.Forms.Button
    Friend WithEvents lbl_Cie10 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_RecMenu As System.Windows.Forms.Button
    Friend WithEvents txt_RecDieta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cedula As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_FecValidez As System.Windows.Forms.Label
    Friend WithEvents Pic_QR As System.Windows.Forms.PictureBox
End Class
