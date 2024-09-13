<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Autocompletar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Autocompletar))
        Me.cmb_Area = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.txt_test = New System.Windows.Forms.TextBox
        Me.lbl_test = New System.Windows.Forms.Label
        Me.dgrd_Test = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.Ctl_txt_Nombre = New System.Windows.Forms.TextBox
        Me.btn_imprimirAuto = New System.Windows.Forms.Button
        Me.dgrd_Items = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_Area
        '
        Me.cmb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Area.Location = New System.Drawing.Point(85, 40)
        Me.cmb_Area.Name = "cmb_Area"
        Me.cmb_Area.Size = New System.Drawing.Size(215, 21)
        Me.cmb_Area.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "AREA:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(517, 102)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(59, 17)
        Me.lbl_Nombre.TabIndex = 116
        Me.lbl_Nombre.Text = "ITEM"
        '
        'txt_test
        '
        Me.txt_test.BackColor = System.Drawing.Color.LightGreen
        Me.txt_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_test.Location = New System.Drawing.Point(85, 65)
        Me.txt_test.Name = "txt_test"
        Me.txt_test.Size = New System.Drawing.Size(215, 21)
        Me.txt_test.TabIndex = 110
        '
        'lbl_test
        '
        Me.lbl_test.AutoSize = True
        Me.lbl_test.BackColor = System.Drawing.Color.Transparent
        Me.lbl_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test.Location = New System.Drawing.Point(24, 69)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(55, 13)
        Me.lbl_test.TabIndex = 111
        Me.lbl_test.Text = "BUSCAR:"
        '
        'dgrd_Test
        '
        Me.dgrd_Test.AllowNavigation = False
        Me.dgrd_Test.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Test.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Test.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Test.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Test.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Test.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.CaptionText = "TEST DISPONIBLES"
        Me.dgrd_Test.DataMember = ""
        Me.dgrd_Test.FlatMode = True
        Me.dgrd_Test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Test.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Test.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Test.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.Location = New System.Drawing.Point(12, 124)
        Me.dgrd_Test.Name = "dgrd_Test"
        Me.dgrd_Test.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Test.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.PreferredColumnWidth = 95
        Me.dgrd_Test.ReadOnly = True
        Me.dgrd_Test.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Test.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Test.Size = New System.Drawing.Size(448, 317)
        Me.dgrd_Test.TabIndex = 128
        Me.dgrd_Test.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Test.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Test
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID"
        Me.DataGridTextBoxColumn1.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn1.Width = 30
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "TEST"
        Me.DataGridTextBoxColumn2.MappingName = "TES_NOMBRE"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "AREA ID"
        Me.DataGridTextBoxColumn3.MappingName = "ARE_ID"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "AREA"
        Me.DataGridTextBoxColumn7.MappingName = "ARE_NOMBRE"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(13, 6)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(185, 18)
        Me.lbl_textform.TabIndex = 123
        Me.lbl_textform.Text = "VALORES RESULTADOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Enabled = False
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(409, 35)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(73, 40)
        Me.btn_Nuevo.TabIndex = 112
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.UseVisualStyleBackColor = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(705, 35)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(73, 40)
        Me.btn_Salir.TabIndex = 115
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(557, 35)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Eliminar.TabIndex = 114
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(483, 35)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Aceptar.TabIndex = 113
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Ctl_txt_Nombre
        '
        Me.Ctl_txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ctl_txt_Nombre.Location = New System.Drawing.Point(565, 98)
        Me.Ctl_txt_Nombre.Name = "Ctl_txt_Nombre"
        Me.Ctl_txt_Nombre.Size = New System.Drawing.Size(215, 20)
        Me.Ctl_txt_Nombre.TabIndex = 126
        '
        'btn_imprimirAuto
        '
        Me.btn_imprimirAuto.BackColor = System.Drawing.Color.White
        Me.btn_imprimirAuto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirAuto.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirAuto.Image = CType(resources.GetObject("btn_imprimirAuto.Image"), System.Drawing.Image)
        Me.btn_imprimirAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirAuto.Location = New System.Drawing.Point(631, 35)
        Me.btn_imprimirAuto.Name = "btn_imprimirAuto"
        Me.btn_imprimirAuto.Size = New System.Drawing.Size(73, 40)
        Me.btn_imprimirAuto.TabIndex = 127
        Me.btn_imprimirAuto.Text = "Imprimir"
        Me.btn_imprimirAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirAuto.UseVisualStyleBackColor = False
        '
        'dgrd_Items
        '
        Me.dgrd_Items.AllowNavigation = False
        Me.dgrd_Items.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Items.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Items.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Items.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Items.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Items.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Items.CaptionText = "ITEMS"
        Me.dgrd_Items.DataMember = ""
        Me.dgrd_Items.FlatMode = True
        Me.dgrd_Items.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Items.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Items.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Items.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Items.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Items.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Items.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Items.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Items.Location = New System.Drawing.Point(471, 124)
        Me.dgrd_Items.Name = "dgrd_Items"
        Me.dgrd_Items.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Items.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Items.ParentRowsVisible = False
        Me.dgrd_Items.PreferredColumnWidth = 145
        Me.dgrd_Items.ReadOnly = True
        Me.dgrd_Items.RowHeaderWidth = 20
        Me.dgrd_Items.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Items.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Items.Size = New System.Drawing.Size(308, 317)
        Me.dgrd_Items.TabIndex = 129
        Me.dgrd_Items.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgrd_Items.TabStop = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgrd_Items
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Registros2"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "ID"
        Me.DataGridTextBoxColumn4.MappingName = "AUTO_ID"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 30
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "ITEM"
        Me.DataGridTextBoxColumn5.MappingName = "AUTO_NOMBRE"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "TET ID"
        Me.DataGridTextBoxColumn6.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'frm_Autocompletar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(796, 464)
        Me.Controls.Add(Me.dgrd_Items)
        Me.Controls.Add(Me.dgrd_Test)
        Me.Controls.Add(Me.btn_imprimirAuto)
        Me.Controls.Add(Me.Ctl_txt_Nombre)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.cmb_Area)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.txt_test)
        Me.Controls.Add(Me.lbl_test)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Autocompletar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Autocompletar"
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Area As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_test As System.Windows.Forms.TextBox
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_imprimirAuto As System.Windows.Forms.Button
    Friend WithEvents dgrd_Test As System.Windows.Forms.DataGrid
    Friend WithEvents dgrd_Items As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
End Class
