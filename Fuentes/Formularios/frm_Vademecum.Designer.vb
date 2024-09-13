<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vademecum
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Dgrd_Vademecum = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_BuscaVadem = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.rbt_MedGen = New System.Windows.Forms.RadioButton
        Me.txt_indcaciones = New System.Windows.Forms.TextBox
        Me.rbt_MedCom = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbl_MedTipo = New System.Windows.Forms.Label
        Me.lbl_MedGen = New System.Windows.Forms.Label
        Me.dgv_CargaVadem = New System.Windows.Forms.DataGridView
        Me.btn_Finalizar = New System.Windows.Forms.Button
        Me.btn_limpiar = New System.Windows.Forms.Button
        Me.btnGestionVademecum = New System.Windows.Forms.Button
        CType(Me.Dgrd_Vademecum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_CargaVadem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgrd_Vademecum
        '
        Me.Dgrd_Vademecum.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_Vademecum.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_Vademecum.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_Vademecum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_Vademecum.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_Vademecum.CaptionFont = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Vademecum.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Vademecum.CaptionText = "VADEMECUM"
        Me.Dgrd_Vademecum.DataMember = ""
        Me.Dgrd_Vademecum.FlatMode = True
        Me.Dgrd_Vademecum.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Vademecum.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_Vademecum.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_Vademecum.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_Vademecum.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Vademecum.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Vademecum.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_Vademecum.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Vademecum.Location = New System.Drawing.Point(11, 109)
        Me.Dgrd_Vademecum.Name = "Dgrd_Vademecum"
        Me.Dgrd_Vademecum.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_Vademecum.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_Vademecum.ParentRowsVisible = False
        Me.Dgrd_Vademecum.PreferredColumnWidth = 100
        Me.Dgrd_Vademecum.ReadOnly = True
        Me.Dgrd_Vademecum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_Vademecum.RowHeaderWidth = 0
        Me.Dgrd_Vademecum.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_Vademecum.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_Vademecum.Size = New System.Drawing.Size(721, 297)
        Me.Dgrd_Vademecum.TabIndex = 187
        Me.Dgrd_Vademecum.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_Vademecum.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_Vademecum
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "VAD_ID"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "TIPO"
        Me.DataGridTextBoxColumn2.MappingName = "VAD_TIPO"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "MED GENERICO"
        Me.DataGridTextBoxColumn3.MappingName = "VAD_MEDGENERICO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 250
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "PRESENTACION"
        Me.DataGridTextBoxColumn4.MappingName = "PRES_DESCRIPCION"
        Me.DataGridTextBoxColumn4.Width = 150
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn5.MappingName = "VAD_CANTIDAD"
        Me.DataGridTextBoxColumn5.NullText = "0"
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "MED COMERCIAL"
        Me.DataGridTextBoxColumn6.MappingName = "VAD_MEDCOMERCIAL"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 240
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "INDICACIONES"
        Me.DataGridTextBoxColumn7.MappingName = "VAD_INDICACIONES"
        Me.DataGridTextBoxColumn7.NullText = "0"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Salir.Location = New System.Drawing.Point(939, 53)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(114, 34)
        Me.btn_Salir.TabIndex = 190
        Me.btn_Salir.Text = "Cerrar"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Buscar"
        '
        'txt_BuscaVadem
        '
        Me.txt_BuscaVadem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BuscaVadem.Location = New System.Drawing.Point(66, 81)
        Me.txt_BuscaVadem.Name = "txt_BuscaVadem"
        Me.txt_BuscaVadem.Size = New System.Drawing.Size(378, 22)
        Me.txt_BuscaVadem.TabIndex = 188
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 25)
        Me.Panel1.TabIndex = 191
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
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "VADEMECUM"
        '
        'rbt_MedGen
        '
        Me.rbt_MedGen.AutoSize = True
        Me.rbt_MedGen.Checked = True
        Me.rbt_MedGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_MedGen.Location = New System.Drawing.Point(26, 53)
        Me.rbt_MedGen.Name = "rbt_MedGen"
        Me.rbt_MedGen.Size = New System.Drawing.Size(81, 20)
        Me.rbt_MedGen.TabIndex = 192
        Me.rbt_MedGen.TabStop = True
        Me.rbt_MedGen.Text = "Genérico"
        Me.rbt_MedGen.UseVisualStyleBackColor = True
        '
        'txt_indcaciones
        '
        Me.txt_indcaciones.BackColor = System.Drawing.Color.White
        Me.txt_indcaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indcaciones.ForeColor = System.Drawing.Color.Black
        Me.txt_indcaciones.Location = New System.Drawing.Point(456, 418)
        Me.txt_indcaciones.Multiline = True
        Me.txt_indcaciones.Name = "txt_indcaciones"
        Me.txt_indcaciones.Size = New System.Drawing.Size(276, 79)
        Me.txt_indcaciones.TabIndex = 193
        '
        'rbt_MedCom
        '
        Me.rbt_MedCom.AutoSize = True
        Me.rbt_MedCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_MedCom.Location = New System.Drawing.Point(107, 53)
        Me.rbt_MedCom.Name = "rbt_MedCom"
        Me.rbt_MedCom.Size = New System.Drawing.Size(87, 20)
        Me.rbt_MedCom.TabIndex = 194
        Me.rbt_MedCom.Text = "Comercial"
        Me.rbt_MedCom.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lbl_MedTipo)
        Me.Panel2.Controls.Add(Me.lbl_MedGen)
        Me.Panel2.Location = New System.Drawing.Point(11, 418)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 79)
        Me.Panel2.TabIndex = 197
        '
        'lbl_MedTipo
        '
        Me.lbl_MedTipo.AutoSize = True
        Me.lbl_MedTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MedTipo.ForeColor = System.Drawing.Color.Black
        Me.lbl_MedTipo.Location = New System.Drawing.Point(2, 41)
        Me.lbl_MedTipo.Name = "lbl_MedTipo"
        Me.lbl_MedTipo.Size = New System.Drawing.Size(77, 16)
        Me.lbl_MedTipo.TabIndex = 198
        Me.lbl_MedTipo.Text = "(MEDTIPO)"
        '
        'lbl_MedGen
        '
        Me.lbl_MedGen.AutoSize = True
        Me.lbl_MedGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MedGen.ForeColor = System.Drawing.Color.Black
        Me.lbl_MedGen.Location = New System.Drawing.Point(2, 8)
        Me.lbl_MedGen.Name = "lbl_MedGen"
        Me.lbl_MedGen.Size = New System.Drawing.Size(75, 16)
        Me.lbl_MedGen.TabIndex = 197
        Me.lbl_MedGen.Text = "(MEDGEN)"
        '
        'dgv_CargaVadem
        '
        Me.dgv_CargaVadem.AllowUserToAddRows = False
        Me.dgv_CargaVadem.AllowUserToDeleteRows = False
        Me.dgv_CargaVadem.BackgroundColor = System.Drawing.Color.White
        Me.dgv_CargaVadem.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_CargaVadem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_CargaVadem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_CargaVadem.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_CargaVadem.Location = New System.Drawing.Point(738, 109)
        Me.dgv_CargaVadem.MultiSelect = False
        Me.dgv_CargaVadem.Name = "dgv_CargaVadem"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_CargaVadem.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_CargaVadem.RowHeadersVisible = False
        Me.dgv_CargaVadem.Size = New System.Drawing.Size(317, 297)
        Me.dgv_CargaVadem.TabIndex = 199
        '
        'btn_Finalizar
        '
        Me.btn_Finalizar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Finalizar.Location = New System.Drawing.Point(939, 412)
        Me.btn_Finalizar.Name = "btn_Finalizar"
        Me.btn_Finalizar.Size = New System.Drawing.Size(114, 34)
        Me.btn_Finalizar.TabIndex = 200
        Me.btn_Finalizar.Text = "Enviar"
        Me.btn_Finalizar.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_limpiar.Location = New System.Drawing.Point(822, 412)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(114, 34)
        Me.btn_limpiar.TabIndex = 201
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btnGestionVademecum
        '
        Me.btnGestionVademecum.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGestionVademecum.Location = New System.Drawing.Point(822, 53)
        Me.btnGestionVademecum.Name = "btnGestionVademecum"
        Me.btnGestionVademecum.Size = New System.Drawing.Size(114, 34)
        Me.btnGestionVademecum.TabIndex = 202
        Me.btnGestionVademecum.Text = "Añadir"
        Me.btnGestionVademecum.UseVisualStyleBackColor = False
        '
        'frm_Vademecum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1067, 525)
        Me.Controls.Add(Me.btnGestionVademecum)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_Finalizar)
        Me.Controls.Add(Me.dgv_CargaVadem)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.rbt_MedCom)
        Me.Controls.Add(Me.txt_indcaciones)
        Me.Controls.Add(Me.rbt_MedGen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_BuscaVadem)
        Me.Controls.Add(Me.Dgrd_Vademecum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Vademecum"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Vademecum"
        CType(Me.Dgrd_Vademecum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_CargaVadem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgrd_Vademecum As System.Windows.Forms.DataGrid
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_BuscaVadem As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbt_MedGen As System.Windows.Forms.RadioButton
    Friend WithEvents txt_indcaciones As System.Windows.Forms.TextBox
    Friend WithEvents rbt_MedCom As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_MedTipo As System.Windows.Forms.Label
    Friend WithEvents lbl_MedGen As System.Windows.Forms.Label
    Friend WithEvents dgv_CargaVadem As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btnGestionVademecum As System.Windows.Forms.Button
End Class
