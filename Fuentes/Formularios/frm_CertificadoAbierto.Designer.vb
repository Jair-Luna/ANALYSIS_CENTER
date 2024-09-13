<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CertificadoAbierto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CertificadoAbierto))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lbl_DMFecha = New System.Windows.Forms.Label
        Me.txt_Titulo = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Cuerpo = New System.Windows.Forms.TextBox
        Me.btn_ImprimirCert = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_enviar = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_DMFecha)
        Me.Panel1.Controls.Add(Me.txt_Titulo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Cuerpo)
        Me.Panel1.Location = New System.Drawing.Point(26, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 592)
        Me.Panel1.TabIndex = 239
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(167, 446)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(94, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 248
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(295, 436)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(154, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 247
        Me.PictureBox2.TabStop = False
        '
        'lbl_DMFecha
        '
        Me.lbl_DMFecha.AutoSize = True
        Me.lbl_DMFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DMFecha.Location = New System.Drawing.Point(152, 532)
        Me.lbl_DMFecha.Name = "lbl_DMFecha"
        Me.lbl_DMFecha.Size = New System.Drawing.Size(68, 15)
        Me.lbl_DMFecha.TabIndex = 246
        Me.lbl_DMFecha.Text = "Quito, D.M."
        '
        'txt_Titulo
        '
        Me.txt_Titulo.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Titulo.Location = New System.Drawing.Point(77, 101)
        Me.txt_Titulo.Name = "txt_Titulo"
        Me.txt_Titulo.Size = New System.Drawing.Size(493, 19)
        Me.txt_Titulo.TabIndex = 1
        Me.txt_Titulo.Text = "CERTIFICADO"
        Me.txt_Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 244
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 479)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 53)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "Dra. MAGDALENA ZURITA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALERGÓLOGA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1031R-06-87-M.S.P."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Cuerpo
        '
        Me.txt_Cuerpo.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_Cuerpo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Cuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cuerpo.Location = New System.Drawing.Point(77, 142)
        Me.txt_Cuerpo.Multiline = True
        Me.txt_Cuerpo.Name = "txt_Cuerpo"
        Me.txt_Cuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Cuerpo.Size = New System.Drawing.Size(493, 288)
        Me.txt_Cuerpo.TabIndex = 2
        '
        'btn_ImprimirCert
        '
        Me.btn_ImprimirCert.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_ImprimirCert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImprimirCert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImprimirCert.ForeColor = System.Drawing.Color.Black
        Me.btn_ImprimirCert.Image = CType(resources.GetObject("btn_ImprimirCert.Image"), System.Drawing.Image)
        Me.btn_ImprimirCert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprimirCert.Location = New System.Drawing.Point(693, 73)
        Me.btn_ImprimirCert.Name = "btn_ImprimirCert"
        Me.btn_ImprimirCert.Size = New System.Drawing.Size(73, 40)
        Me.btn_ImprimirCert.TabIndex = 4
        Me.btn_ImprimirCert.Text = "Imprimir"
        Me.btn_ImprimirCert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImprimirCert.UseVisualStyleBackColor = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_Guardar.Image = CType(resources.GetObject("btn_Guardar.Image"), System.Drawing.Image)
        Me.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.Location = New System.Drawing.Point(693, 32)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Guardar.TabIndex = 3
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'btn_enviar
        '
        Me.btn_enviar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.ForeColor = System.Drawing.Color.Black
        Me.btn_enviar.Image = CType(resources.GetObject("btn_enviar.Image"), System.Drawing.Image)
        Me.btn_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enviar.Location = New System.Drawing.Point(693, 114)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(73, 40)
        Me.btn_enviar.TabIndex = 5
        Me.btn_enviar.Text = "Enviar"
        Me.btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enviar.UseVisualStyleBackColor = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(693, 156)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(73, 40)
        Me.btn_Salir.TabIndex = 6
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'frm_CertificadoAbierto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(795, 650)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.btn_ImprimirCert)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_CertificadoAbierto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_CertificadoAbierto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Cuerpo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Titulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DMFecha As System.Windows.Forms.Label
    Friend WithEvents btn_ImprimirCert As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_enviar As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
