<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vacunas
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_Servicio = New System.Windows.Forms.Label
        Me.lbl_tipo = New System.Windows.Forms.Label
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.lbl_nombres = New System.Windows.Forms.Label
        Me.lbl_encabezado = New System.Windows.Forms.Label
        Me.lbl_codigo_barras = New System.Windows.Forms.Label
        Me.dgv_Vacunas = New System.Windows.Forms.DataGridView
        Me.btn_SolicitarVacuna = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Vacunas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_Servicio)
        Me.Panel1.Controls.Add(Me.lbl_tipo)
        Me.Panel1.Controls.Add(Me.lbl_doc)
        Me.Panel1.Controls.Add(Me.lbl_edad)
        Me.Panel1.Controls.Add(Me.lbl_fecha)
        Me.Panel1.Controls.Add(Me.lbl_nombres)
        Me.Panel1.Controls.Add(Me.lbl_encabezado)
        Me.Panel1.Controls.Add(Me.lbl_codigo_barras)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(425, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 138)
        Me.Panel1.TabIndex = 16
        '
        'lbl_Servicio
        '
        Me.lbl_Servicio.BackColor = System.Drawing.Color.White
        Me.lbl_Servicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Servicio.Location = New System.Drawing.Point(13, 118)
        Me.lbl_Servicio.Name = "lbl_Servicio"
        Me.lbl_Servicio.Size = New System.Drawing.Size(239, 16)
        Me.lbl_Servicio.TabIndex = 22
        Me.lbl_Servicio.Text = "SERVICIO"
        Me.lbl_Servicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tipo
        '
        Me.lbl_tipo.BackColor = System.Drawing.Color.White
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.Location = New System.Drawing.Point(190, 52)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(63, 18)
        Me.lbl_tipo.TabIndex = 21
        Me.lbl_tipo.Text = "TIPO"
        Me.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_doc
        '
        Me.lbl_doc.BackColor = System.Drawing.Color.White
        Me.lbl_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doc.Location = New System.Drawing.Point(12, 102)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(124, 16)
        Me.lbl_doc.TabIndex = 20
        Me.lbl_doc.Text = "CI"
        Me.lbl_doc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_edad
        '
        Me.lbl_edad.BackColor = System.Drawing.Color.White
        Me.lbl_edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.Location = New System.Drawing.Point(142, 102)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(110, 16)
        Me.lbl_edad.TabIndex = 19
        Me.lbl_edad.Text = "EDAD"
        Me.lbl_edad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.Color.White
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(13, 90)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(135, 15)
        Me.lbl_fecha.TabIndex = 18
        Me.lbl_fecha.Text = "FECHA"
        Me.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nombres
        '
        Me.lbl_nombres.BackColor = System.Drawing.Color.White
        Me.lbl_nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres.Location = New System.Drawing.Point(12, 20)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(224, 17)
        Me.lbl_nombres.TabIndex = 17
        Me.lbl_nombres.Text = "PACIENTE NOMBRE"
        Me.lbl_nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_encabezado
        '
        Me.lbl_encabezado.BackColor = System.Drawing.Color.White
        Me.lbl_encabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_encabezado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_encabezado.Location = New System.Drawing.Point(0, 2)
        Me.lbl_encabezado.Name = "lbl_encabezado"
        Me.lbl_encabezado.Size = New System.Drawing.Size(254, 18)
        Me.lbl_encabezado.TabIndex = 16
        Me.lbl_encabezado.Tag = ""
        Me.lbl_encabezado.Text = "           VACUNA AMPOLLA 3 ml        "
        Me.lbl_encabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_codigo_barras
        '
        Me.lbl_codigo_barras.BackColor = System.Drawing.Color.White
        Me.lbl_codigo_barras.Font = New System.Drawing.Font("C39HrP24DhTt", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_barras.Location = New System.Drawing.Point(16, 28)
        Me.lbl_codigo_barras.Name = "lbl_codigo_barras"
        Me.lbl_codigo_barras.Size = New System.Drawing.Size(185, 69)
        Me.lbl_codigo_barras.TabIndex = 15
        Me.lbl_codigo_barras.Text = "VACUNA"
        Me.lbl_codigo_barras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_Vacunas
        '
        Me.dgv_Vacunas.AllowUserToAddRows = False
        Me.dgv_Vacunas.AllowUserToDeleteRows = False
        Me.dgv_Vacunas.BackgroundColor = System.Drawing.Color.Gray
        Me.dgv_Vacunas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Vacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Vacunas.Location = New System.Drawing.Point(12, 90)
        Me.dgv_Vacunas.Name = "dgv_Vacunas"
        Me.dgv_Vacunas.ReadOnly = True
        Me.dgv_Vacunas.RowHeadersVisible = False
        Me.dgv_Vacunas.Size = New System.Drawing.Size(393, 211)
        Me.dgv_Vacunas.TabIndex = 219
        '
        'btn_SolicitarVacuna
        '
        Me.btn_SolicitarVacuna.BackColor = System.Drawing.Color.White
        Me.btn_SolicitarVacuna.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SolicitarVacuna.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SolicitarVacuna.Location = New System.Drawing.Point(425, 246)
        Me.btn_SolicitarVacuna.Name = "btn_SolicitarVacuna"
        Me.btn_SolicitarVacuna.Size = New System.Drawing.Size(113, 55)
        Me.btn_SolicitarVacuna.TabIndex = 220
        Me.btn_SolicitarVacuna.Text = "ACEPTAR"
        Me.btn_SolicitarVacuna.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(694, 25)
        Me.pan_barra.TabIndex = 221
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
        Me.lbl_textform.Size = New System.Drawing.Size(170, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "SOLICITAR VACUNAS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 24)
        Me.Label14.TabIndex = 225
        Me.Label14.Text = "PACIENTE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 24)
        Me.Label13.TabIndex = 224
        Me.Label13.Text = "EDAD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(77, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "(EDAD)"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.ForeColor = System.Drawing.Color.Navy
        Me.lbl_paciente.Location = New System.Drawing.Point(124, 31)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(116, 24)
        Me.lbl_paciente.TabIndex = 222
        Me.lbl_paciente.Text = "(PACIENTE)"
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.White
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(566, 246)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(113, 55)
        Me.btn_Salir.TabIndex = 226
        Me.btn_Salir.Text = "SALIR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'frm_Vacunas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(694, 322)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_SolicitarVacuna)
        Me.Controls.Add(Me.dgv_Vacunas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Vacunas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_Vacunas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_Vacunas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Servicio As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_encabezado As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_barras As System.Windows.Forms.Label
    Friend WithEvents dgv_Vacunas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_SolicitarVacuna As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
End Class
