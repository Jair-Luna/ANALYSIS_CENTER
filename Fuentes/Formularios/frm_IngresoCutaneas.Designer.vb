<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_IngresoCutaneas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_IngresoCutaneas))
        Me.lbl_edadPac = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_pacD = New System.Windows.Forms.Label
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.dgv_Alimentos = New System.Windows.Forms.DataGridView
        Me.dgv_Inhalantes = New System.Windows.Forms.DataGridView
        Me.dgv_Medicamentos = New System.Windows.Forms.DataGridView
        Me.chk_Dermografico = New System.Windows.Forms.CheckBox
        Me.dgv_Antibioticos = New System.Windows.Forms.DataGridView
        Me.dgv_Otros = New System.Windows.Forms.DataGridView
        Me.chk_Infante = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMedAines = New System.Windows.Forms.Label
        Me.lblMedAB = New System.Windows.Forms.Label
        Me.lblMedOtros = New System.Windows.Forms.Label
        Me.lblSustancias = New System.Windows.Forms.Label
        Me.dgv_Sustancias = New System.Windows.Forms.DataGridView
        Me.btn_CargaHistoricos = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Alimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Inhalantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Medicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Antibioticos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Otros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Sustancias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_edadPac
        '
        Me.lbl_edadPac.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edadPac.ForeColor = System.Drawing.Color.Black
        Me.lbl_edadPac.Location = New System.Drawing.Point(47, 48)
        Me.lbl_edadPac.Name = "lbl_edadPac"
        Me.lbl_edadPac.Size = New System.Drawing.Size(405, 17)
        Me.lbl_edadPac.TabIndex = 210
        Me.lbl_edadPac.Text = "[EDAD]"
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
        Me.btn_Salir.Location = New System.Drawing.Point(1103, 30)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(82, 40)
        Me.btn_Salir.TabIndex = 203
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
        Me.btn_Guardar.Location = New System.Drawing.Point(1019, 30)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(83, 40)
        Me.btn_Guardar.TabIndex = 202
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'lbl_pacD
        '
        Me.lbl_pacD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pacD.ForeColor = System.Drawing.Color.Black
        Me.lbl_pacD.Location = New System.Drawing.Point(47, 31)
        Me.lbl_pacD.Name = "lbl_pacD"
        Me.lbl_pacD.Size = New System.Drawing.Size(628, 17)
        Me.lbl_pacD.TabIndex = 201
        Me.lbl_pacD.Text = "[PACIENTE]"
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(6, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(182, 19)
        Me.lbl_textform.TabIndex = 213
        Me.lbl_textform.Text = "PRUEBAS CUTANEAS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(1195, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 212
        Me.pic_barra.TabStop = False
        '
        'dgv_Alimentos
        '
        Me.dgv_Alimentos.AllowUserToAddRows = False
        Me.dgv_Alimentos.AllowUserToDeleteRows = False
        Me.dgv_Alimentos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_Alimentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Alimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Alimentos.Location = New System.Drawing.Point(12, 91)
        Me.dgv_Alimentos.MultiSelect = False
        Me.dgv_Alimentos.Name = "dgv_Alimentos"
        Me.dgv_Alimentos.RowHeadersVisible = False
        Me.dgv_Alimentos.Size = New System.Drawing.Size(395, 407)
        Me.dgv_Alimentos.TabIndex = 215
        '
        'dgv_Inhalantes
        '
        Me.dgv_Inhalantes.AllowUserToAddRows = False
        Me.dgv_Inhalantes.AllowUserToDeleteRows = False
        Me.dgv_Inhalantes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_Inhalantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Inhalantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Inhalantes.Location = New System.Drawing.Point(413, 91)
        Me.dgv_Inhalantes.Name = "dgv_Inhalantes"
        Me.dgv_Inhalantes.RowHeadersVisible = False
        Me.dgv_Inhalantes.Size = New System.Drawing.Size(390, 597)
        Me.dgv_Inhalantes.TabIndex = 216
        '
        'dgv_Medicamentos
        '
        Me.dgv_Medicamentos.AllowUserToAddRows = False
        Me.dgv_Medicamentos.AllowUserToDeleteRows = False
        Me.dgv_Medicamentos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_Medicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Medicamentos.Location = New System.Drawing.Point(809, 91)
        Me.dgv_Medicamentos.Name = "dgv_Medicamentos"
        Me.dgv_Medicamentos.RowHeadersVisible = False
        Me.dgv_Medicamentos.Size = New System.Drawing.Size(374, 255)
        Me.dgv_Medicamentos.TabIndex = 217
        '
        'chk_Dermografico
        '
        Me.chk_Dermografico.AutoSize = True
        Me.chk_Dermografico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Dermografico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chk_Dermografico.Location = New System.Drawing.Point(703, 46)
        Me.chk_Dermografico.Name = "chk_Dermografico"
        Me.chk_Dermografico.Size = New System.Drawing.Size(141, 24)
        Me.chk_Dermografico.TabIndex = 218
        Me.chk_Dermografico.Text = "Dermografismo "
        Me.chk_Dermografico.UseVisualStyleBackColor = True
        '
        'dgv_Antibioticos
        '
        Me.dgv_Antibioticos.AllowUserToAddRows = False
        Me.dgv_Antibioticos.AllowUserToDeleteRows = False
        Me.dgv_Antibioticos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_Antibioticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Antibioticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Antibioticos.Location = New System.Drawing.Point(809, 365)
        Me.dgv_Antibioticos.Name = "dgv_Antibioticos"
        Me.dgv_Antibioticos.RowHeadersVisible = False
        Me.dgv_Antibioticos.Size = New System.Drawing.Size(374, 192)
        Me.dgv_Antibioticos.TabIndex = 219
        '
        'dgv_Otros
        '
        Me.dgv_Otros.AllowUserToAddRows = False
        Me.dgv_Otros.AllowUserToDeleteRows = False
        Me.dgv_Otros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_Otros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Otros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Otros.Location = New System.Drawing.Point(809, 576)
        Me.dgv_Otros.Name = "dgv_Otros"
        Me.dgv_Otros.RowHeadersVisible = False
        Me.dgv_Otros.Size = New System.Drawing.Size(374, 112)
        Me.dgv_Otros.TabIndex = 220
        '
        'chk_Infante
        '
        Me.chk_Infante.AutoSize = True
        Me.chk_Infante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Infante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chk_Infante.Location = New System.Drawing.Point(850, 46)
        Me.chk_Infante.Name = "chk_Infante"
        Me.chk_Infante.Size = New System.Drawing.Size(68, 24)
        Me.chk_Infante.TabIndex = 221
        Me.chk_Infante.Text = "Niños"
        Me.chk_Infante.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 13)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "ALIMENTOS"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 13)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "INHALANTES"
        '
        'lblMedAines
        '
        Me.lblMedAines.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMedAines.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedAines.Location = New System.Drawing.Point(808, 75)
        Me.lblMedAines.Name = "lblMedAines"
        Me.lblMedAines.Size = New System.Drawing.Size(376, 13)
        Me.lblMedAines.TabIndex = 224
        Me.lblMedAines.Text = "MEDICAMENTOS - AINES"
        '
        'lblMedAB
        '
        Me.lblMedAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMedAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedAB.Location = New System.Drawing.Point(806, 349)
        Me.lblMedAB.Name = "lblMedAB"
        Me.lblMedAB.Size = New System.Drawing.Size(376, 13)
        Me.lblMedAB.TabIndex = 225
        Me.lblMedAB.Text = "MEDICAMENTOS - ANTIBIOTICOS"
        '
        'lblMedOtros
        '
        Me.lblMedOtros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMedOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedOtros.Location = New System.Drawing.Point(806, 560)
        Me.lblMedOtros.Name = "lblMedOtros"
        Me.lblMedOtros.Size = New System.Drawing.Size(376, 13)
        Me.lblMedOtros.TabIndex = 226
        Me.lblMedOtros.Text = "MEDICAMENTOS - OTROS"
        '
        'lblSustancias
        '
        Me.lblSustancias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSustancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSustancias.Location = New System.Drawing.Point(12, 501)
        Me.lblSustancias.Name = "lblSustancias"
        Me.lblSustancias.Size = New System.Drawing.Size(395, 13)
        Me.lblSustancias.TabIndex = 227
        Me.lblSustancias.Text = "OTRAS SUSTANCIAS"
        '
        'dgv_Sustancias
        '
        Me.dgv_Sustancias.AllowUserToAddRows = False
        Me.dgv_Sustancias.AllowUserToDeleteRows = False
        Me.dgv_Sustancias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_Sustancias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Sustancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Sustancias.Location = New System.Drawing.Point(12, 517)
        Me.dgv_Sustancias.MultiSelect = False
        Me.dgv_Sustancias.Name = "dgv_Sustancias"
        Me.dgv_Sustancias.RowHeadersVisible = False
        Me.dgv_Sustancias.Size = New System.Drawing.Size(395, 171)
        Me.dgv_Sustancias.TabIndex = 228
        '
        'btn_CargaHistoricos
        '
        Me.btn_CargaHistoricos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_CargaHistoricos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CargaHistoricos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CargaHistoricos.ForeColor = System.Drawing.Color.Black
        Me.btn_CargaHistoricos.Image = CType(resources.GetObject("btn_CargaHistoricos.Image"), System.Drawing.Image)
        Me.btn_CargaHistoricos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CargaHistoricos.Location = New System.Drawing.Point(935, 30)
        Me.btn_CargaHistoricos.Name = "btn_CargaHistoricos"
        Me.btn_CargaHistoricos.Size = New System.Drawing.Size(82, 40)
        Me.btn_CargaHistoricos.TabIndex = 229
        Me.btn_CargaHistoricos.Text = "Historicos"
        Me.btn_CargaHistoricos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CargaHistoricos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 230
        Me.PictureBox1.TabStop = False
        '
        'frm_IngresoCutaneas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1195, 700)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_CargaHistoricos)
        Me.Controls.Add(Me.dgv_Sustancias)
        Me.Controls.Add(Me.lblSustancias)
        Me.Controls.Add(Me.lblMedOtros)
        Me.Controls.Add(Me.lblMedAB)
        Me.Controls.Add(Me.lblMedAines)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_Infante)
        Me.Controls.Add(Me.dgv_Otros)
        Me.Controls.Add(Me.dgv_Antibioticos)
        Me.Controls.Add(Me.chk_Dermografico)
        Me.Controls.Add(Me.dgv_Medicamentos)
        Me.Controls.Add(Me.dgv_Inhalantes)
        Me.Controls.Add(Me.dgv_Alimentos)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.pic_barra)
        Me.Controls.Add(Me.lbl_edadPac)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_pacD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_IngresoCutaneas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_IngresoCutaneas"
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Alimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Inhalantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Medicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Antibioticos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Otros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Sustancias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_edadPac As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_pacD As System.Windows.Forms.Label
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_Alimentos As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_Inhalantes As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_Medicamentos As System.Windows.Forms.DataGridView
    Friend WithEvents chk_Dermografico As System.Windows.Forms.CheckBox
    Friend WithEvents dgv_Antibioticos As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_Otros As System.Windows.Forms.DataGridView
    Friend WithEvents chk_Infante As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMedAines As System.Windows.Forms.Label
    Friend WithEvents lblMedAB As System.Windows.Forms.Label
    Friend WithEvents lblMedOtros As System.Windows.Forms.Label
    Friend WithEvents lblSustancias As System.Windows.Forms.Label
    Friend WithEvents dgv_Sustancias As System.Windows.Forms.DataGridView
    Friend WithEvents btn_CargaHistoricos As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
