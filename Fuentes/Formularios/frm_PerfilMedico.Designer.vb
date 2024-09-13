<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PerfilMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PerfilMedico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.dgv_ElementosMed = New System.Windows.Forms.DataGridView
        Me.dgv_Medico = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_Especialidad = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.dgv_GruposMed = New System.Windows.Forms.DataGridView
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.txt_NombreGrupo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ObsGrupo = New System.Windows.Forms.TextBox
        Me.pan_barra.SuspendLayout()
        CType(Me.dgv_ElementosMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_GruposMed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(801, 25)
        Me.pan_barra.TabIndex = 100
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.White
        Me.lbl_textform.Location = New System.Drawing.Point(7, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(188, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "AGRUPACION MEDICOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(599, 31)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 37)
        Me.btn_imprimir.TabIndex = 98
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'dgv_ElementosMed
        '
        Me.dgv_ElementosMed.AllowUserToAddRows = False
        Me.dgv_ElementosMed.AllowUserToDeleteRows = False
        Me.dgv_ElementosMed.BackgroundColor = System.Drawing.Color.White
        Me.dgv_ElementosMed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ElementosMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_ElementosMed.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ElementosMed.Location = New System.Drawing.Point(10, 253)
        Me.dgv_ElementosMed.MultiSelect = False
        Me.dgv_ElementosMed.Name = "dgv_ElementosMed"
        Me.dgv_ElementosMed.ReadOnly = True
        Me.dgv_ElementosMed.RowHeadersVisible = False
        Me.dgv_ElementosMed.Size = New System.Drawing.Size(491, 173)
        Me.dgv_ElementosMed.TabIndex = 174
        '
        'dgv_Medico
        '
        Me.dgv_Medico.AllowUserToAddRows = False
        Me.dgv_Medico.AllowUserToDeleteRows = False
        Me.dgv_Medico.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Medico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Medico.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Medico.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Medico.Location = New System.Drawing.Point(573, 253)
        Me.dgv_Medico.MultiSelect = False
        Me.dgv_Medico.Name = "dgv_Medico"
        Me.dgv_Medico.ReadOnly = True
        Me.dgv_Medico.RowHeadersVisible = False
        Me.dgv_Medico.Size = New System.Drawing.Size(216, 173)
        Me.dgv_Medico.TabIndex = 173
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(455, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Filtrar por especialidad"
        '
        'cmb_Especialidad
        '
        Me.cmb_Especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Especialidad.FormattingEnabled = True
        Me.cmb_Especialidad.Location = New System.Drawing.Point(573, 225)
        Me.cmb_Especialidad.Name = "cmb_Especialidad"
        Me.cmb_Especialidad.Size = New System.Drawing.Size(183, 21)
        Me.cmb_Especialidad.TabIndex = 171
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(105, 87)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(270, 20)
        Me.Ctl_txt_nombre.TabIndex = 0
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.White
        Me.lbl_Nombre.Location = New System.Drawing.Point(10, 91)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(100, 16)
        Me.lbl_Nombre.TabIndex = 26
        Me.lbl_Nombre.Text = "Grupo Nombre:"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(439, 31)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 37)
        Me.btn_Nuevo.TabIndex = 95
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        Me.btn_Nuevo.Visible = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(678, 31)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 37)
        Me.btn_Salir.TabIndex = 99
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(519, 31)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 37)
        Me.btn_Aceptar.TabIndex = 96
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        Me.btn_Aceptar.Visible = False
        '
        'dgv_GruposMed
        '
        Me.dgv_GruposMed.AllowUserToAddRows = False
        Me.dgv_GruposMed.AllowUserToDeleteRows = False
        Me.dgv_GruposMed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_GruposMed.BackgroundColor = System.Drawing.Color.White
        Me.dgv_GruposMed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_GruposMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_GruposMed.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_GruposMed.Location = New System.Drawing.Point(10, 113)
        Me.dgv_GruposMed.MultiSelect = False
        Me.dgv_GruposMed.Name = "dgv_GruposMed"
        Me.dgv_GruposMed.ReadOnly = True
        Me.dgv_GruposMed.RowHeadersVisible = False
        Me.dgv_GruposMed.Size = New System.Drawing.Size(491, 90)
        Me.dgv_GruposMed.TabIndex = 172
        '
        'btn_Agregar
        '
        Me.btn_Agregar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Agregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_Agregar.Image = CType(resources.GetObject("btn_Agregar.Image"), System.Drawing.Image)
        Me.btn_Agregar.Location = New System.Drawing.Point(507, 314)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(56, 43)
        Me.btn_Agregar.TabIndex = 175
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'txt_NombreGrupo
        '
        Me.txt_NombreGrupo.Location = New System.Drawing.Point(573, 110)
        Me.txt_NombreGrupo.Name = "txt_NombreGrupo"
        Me.txt_NombreGrupo.Size = New System.Drawing.Size(185, 20)
        Me.txt_NombreGrupo.TabIndex = 176
        Me.txt_NombreGrupo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(570, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "NOMBRE GRUPO"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(570, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "OBS GRUPO"
        Me.Label2.Visible = False
        '
        'txt_ObsGrupo
        '
        Me.txt_ObsGrupo.Location = New System.Drawing.Point(573, 154)
        Me.txt_ObsGrupo.Multiline = True
        Me.txt_ObsGrupo.Name = "txt_ObsGrupo"
        Me.txt_ObsGrupo.Size = New System.Drawing.Size(185, 49)
        Me.txt_ObsGrupo.TabIndex = 178
        Me.txt_ObsGrupo.Visible = False
        '
        'frm_PerfilMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(801, 444)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ObsGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_NombreGrupo)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.dgv_ElementosMed)
        Me.Controls.Add(Me.dgv_Medico)
        Me.Controls.Add(Me.dgv_GruposMed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.cmb_Especialidad)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Ctl_txt_nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_PerfilMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_PerfilMedico"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgv_ElementosMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_GruposMed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents dgv_Medico As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_ElementosMed As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_GruposMed As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents txt_NombreGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ObsGrupo As System.Windows.Forms.TextBox
End Class
