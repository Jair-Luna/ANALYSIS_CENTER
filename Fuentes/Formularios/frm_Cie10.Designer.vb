<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cie10
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_BuscaCie = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Dgrd_Cie10 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_AddCie = New System.Windows.Forms.Button
        Me.txt_CodCie3 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btn_EliminaCie = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_GuardaCie = New System.Windows.Forms.Button
        Me.txt_DesCie4 = New System.Windows.Forms.TextBox
        Me.txt_DesCie3 = New System.Windows.Forms.TextBox
        Me.txt_CodCie4 = New System.Windows.Forms.TextBox
        Me.btnEditCie = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.Dgrd_Cie10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 25)
        Me.Panel1.TabIndex = 182
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
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "CIE 10"
        '
        'txt_BuscaCie
        '
        Me.txt_BuscaCie.Location = New System.Drawing.Point(80, 52)
        Me.txt_BuscaCie.Name = "txt_BuscaCie"
        Me.txt_BuscaCie.Size = New System.Drawing.Size(331, 20)
        Me.txt_BuscaCie.TabIndex = 184
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "BUSCAR"
        '
        'Dgrd_Cie10
        '
        Me.Dgrd_Cie10.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_Cie10.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_Cie10.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_Cie10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_Cie10.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_Cie10.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Cie10.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Cie10.CaptionText = "CIE 10"
        Me.Dgrd_Cie10.DataMember = ""
        Me.Dgrd_Cie10.FlatMode = True
        Me.Dgrd_Cie10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Cie10.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_Cie10.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_Cie10.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_Cie10.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Cie10.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Cie10.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_Cie10.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Cie10.Location = New System.Drawing.Point(11, 204)
        Me.Dgrd_Cie10.Name = "Dgrd_Cie10"
        Me.Dgrd_Cie10.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_Cie10.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_Cie10.ParentRowsVisible = False
        Me.Dgrd_Cie10.PreferredColumnWidth = 100
        Me.Dgrd_Cie10.ReadOnly = True
        Me.Dgrd_Cie10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_Cie10.RowHeaderWidth = 0
        Me.Dgrd_Cie10.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_Cie10.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_Cie10.Size = New System.Drawing.Size(1025, 287)
        Me.Dgrd_Cie10.TabIndex = 186
        Me.Dgrd_Cie10.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_Cie10.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_Cie10
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "COD 3"
        Me.DataGridTextBoxColumn1.MappingName = "cie_cod3"
        Me.DataGridTextBoxColumn1.Width = 40
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.MappingName = "cie_desc3"
        Me.DataGridTextBoxColumn2.Width = 400
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "COD 4"
        Me.DataGridTextBoxColumn3.MappingName = "cie_cod4"
        Me.DataGridTextBoxColumn3.Width = 40
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn4.MappingName = "cie_desc4"
        Me.DataGridTextBoxColumn4.Width = 550
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Location = New System.Drawing.Point(956, 34)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(81, 38)
        Me.btn_Salir.TabIndex = 187
        Me.btn_Salir.Text = "Cerrar"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_AddCie
        '
        Me.btn_AddCie.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddCie.Enabled = False
        Me.btn_AddCie.Location = New System.Drawing.Point(796, 34)
        Me.btn_AddCie.Name = "btn_AddCie"
        Me.btn_AddCie.Size = New System.Drawing.Size(81, 38)
        Me.btn_AddCie.TabIndex = 188
        Me.btn_AddCie.Text = "Añadir"
        Me.btn_AddCie.UseVisualStyleBackColor = False
        '
        'txt_CodCie3
        '
        Me.txt_CodCie3.Location = New System.Drawing.Point(76, 19)
        Me.txt_CodCie3.Name = "txt_CodCie3"
        Me.txt_CodCie3.Size = New System.Drawing.Size(58, 20)
        Me.txt_CodCie3.TabIndex = 189
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_EliminaCie)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_GuardaCie)
        Me.GroupBox1.Controls.Add(Me.txt_DesCie4)
        Me.GroupBox1.Controls.Add(Me.txt_DesCie3)
        Me.GroupBox1.Controls.Add(Me.txt_CodCie4)
        Me.GroupBox1.Controls.Add(Me.txt_CodCie3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 106)
        Me.GroupBox1.TabIndex = 190
        Me.GroupBox1.TabStop = False
        '
        'Btn_EliminaCie
        '
        Me.Btn_EliminaCie.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_EliminaCie.Location = New System.Drawing.Point(484, 71)
        Me.Btn_EliminaCie.Name = "Btn_EliminaCie"
        Me.Btn_EliminaCie.Size = New System.Drawing.Size(76, 25)
        Me.Btn_EliminaCie.TabIndex = 198
        Me.Btn_EliminaCie.Text = "Eliminar"
        Me.Btn_EliminaCie.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(151, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "DESCRIPCION 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 196
        Me.Label5.Text = "DESCRIPCION 4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "CODIGO 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "CODIGO 3"
        '
        'btn_GuardaCie
        '
        Me.btn_GuardaCie.BackColor = System.Drawing.SystemColors.Control
        Me.btn_GuardaCie.Location = New System.Drawing.Point(559, 71)
        Me.btn_GuardaCie.Name = "btn_GuardaCie"
        Me.btn_GuardaCie.Size = New System.Drawing.Size(76, 25)
        Me.btn_GuardaCie.TabIndex = 193
        Me.btn_GuardaCie.Text = "Guardar"
        Me.btn_GuardaCie.UseVisualStyleBackColor = False
        '
        'txt_DesCie4
        '
        Me.txt_DesCie4.Location = New System.Drawing.Point(242, 45)
        Me.txt_DesCie4.Name = "txt_DesCie4"
        Me.txt_DesCie4.Size = New System.Drawing.Size(393, 20)
        Me.txt_DesCie4.TabIndex = 192
        '
        'txt_DesCie3
        '
        Me.txt_DesCie3.Location = New System.Drawing.Point(242, 19)
        Me.txt_DesCie3.Name = "txt_DesCie3"
        Me.txt_DesCie3.Size = New System.Drawing.Size(393, 20)
        Me.txt_DesCie3.TabIndex = 191
        '
        'txt_CodCie4
        '
        Me.txt_CodCie4.Location = New System.Drawing.Point(76, 45)
        Me.txt_CodCie4.Name = "txt_CodCie4"
        Me.txt_CodCie4.Size = New System.Drawing.Size(58, 20)
        Me.txt_CodCie4.TabIndex = 190
        '
        'btnEditCie
        '
        Me.btnEditCie.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditCie.Enabled = False
        Me.btnEditCie.Location = New System.Drawing.Point(876, 34)
        Me.btnEditCie.Name = "btnEditCie"
        Me.btnEditCie.Size = New System.Drawing.Size(81, 38)
        Me.btnEditCie.TabIndex = 198
        Me.btnEditCie.Text = "Editar"
        Me.btnEditCie.UseVisualStyleBackColor = False
        '
        'frm_Cie10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1048, 503)
        Me.Controls.Add(Me.btnEditCie)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_AddCie)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Dgrd_Cie10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_BuscaCie)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Cie10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_Cie10"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgrd_Cie10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_BuscaCie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dgrd_Cie10 As System.Windows.Forms.DataGrid
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_AddCie As System.Windows.Forms.Button
    Friend WithEvents txt_CodCie3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_GuardaCie As System.Windows.Forms.Button
    Friend WithEvents txt_DesCie4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_DesCie3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CodCie4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnEditCie As System.Windows.Forms.Button
    Friend WithEvents Btn_EliminaCie As System.Windows.Forms.Button
End Class
