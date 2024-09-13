<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Antibioticos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Antibioticos))
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.dgrd_Antibioticos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgtc_Id = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_Nombre = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_Cod = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_Orden = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_test = New System.Windows.Forms.TextBox
        Me.lbl_test = New System.Windows.Forms.Label
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Ctl_txt_Nombre = New System.Windows.Forms.TextBox
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.txt_orden = New Ctl_txt.ctl_txt_numeros
        CType(Me.dgrd_Antibioticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(14, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(123, 18)
        Me.lbl_textform.TabIndex = 95
        Me.lbl_textform.Text = "ANTIBIOTICOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgrd_Antibioticos
        '
        Me.dgrd_Antibioticos.AllowNavigation = False
        Me.dgrd_Antibioticos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Antibioticos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Antibioticos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Antibioticos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Antibioticos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Antibioticos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Antibioticos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Antibioticos.CaptionText = "ANTIBIOTICOS DISPONIBLES"
        Me.dgrd_Antibioticos.DataMember = ""
        Me.dgrd_Antibioticos.FlatMode = True
        Me.dgrd_Antibioticos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Antibioticos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Antibioticos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Antibioticos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Antibioticos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Antibioticos.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Antibioticos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Antibioticos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Antibioticos.Location = New System.Drawing.Point(17, 91)
        Me.dgrd_Antibioticos.Name = "dgrd_Antibioticos"
        Me.dgrd_Antibioticos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Antibioticos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Antibioticos.PreferredColumnWidth = 95
        Me.dgrd_Antibioticos.ReadOnly = True
        Me.dgrd_Antibioticos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Antibioticos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Antibioticos.Size = New System.Drawing.Size(434, 357)
        Me.dgrd_Antibioticos.TabIndex = 96
        Me.dgrd_Antibioticos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Antibioticos.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Antibioticos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgtc_Id, Me.dgtc_Nombre, Me.dgtc_Cod, Me.dgtc_Orden})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'dgtc_Id
        '
        Me.dgtc_Id.Format = ""
        Me.dgtc_Id.FormatInfo = Nothing
        Me.dgtc_Id.HeaderText = "ID"
        Me.dgtc_Id.MappingName = "ANB_ID"
        Me.dgtc_Id.ReadOnly = True
        Me.dgtc_Id.Width = 30
        '
        'dgtc_Nombre
        '
        Me.dgtc_Nombre.Format = ""
        Me.dgtc_Nombre.FormatInfo = Nothing
        Me.dgtc_Nombre.HeaderText = "NOMBRE"
        Me.dgtc_Nombre.MappingName = "ANB_NOMBRE"
        Me.dgtc_Nombre.ReadOnly = True
        Me.dgtc_Nombre.Width = 210
        '
        'dgtc_Cod
        '
        Me.dgtc_Cod.Format = ""
        Me.dgtc_Cod.FormatInfo = Nothing
        Me.dgtc_Cod.MappingName = "ANB_CODIGO"
        Me.dgtc_Cod.ReadOnly = True
        Me.dgtc_Cod.Width = 70
        '
        'dgtc_Orden
        '
        Me.dgtc_Orden.Format = ""
        Me.dgtc_Orden.FormatInfo = Nothing
        Me.dgtc_Orden.HeaderText = "ORDEN"
        Me.dgtc_Orden.MappingName = "ANB_ORDEN"
        Me.dgtc_Orden.ReadOnly = True
        Me.dgtc_Orden.Width = 60
        '
        'txt_test
        '
        Me.txt_test.BackColor = System.Drawing.Color.LightGreen
        Me.txt_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_test.Location = New System.Drawing.Point(80, 50)
        Me.txt_test.Name = "txt_test"
        Me.txt_test.Size = New System.Drawing.Size(235, 21)
        Me.txt_test.TabIndex = 97
        '
        'lbl_test
        '
        Me.lbl_test.AutoSize = True
        Me.lbl_test.BackColor = System.Drawing.Color.Transparent
        Me.lbl_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test.Location = New System.Drawing.Point(19, 54)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(55, 13)
        Me.lbl_test.TabIndex = 98
        Me.lbl_test.Text = "BUSCAR:"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(438, 35)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(73, 40)
        Me.btn_Nuevo.TabIndex = 99
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.UseVisualStyleBackColor = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(657, 35)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(73, 40)
        Me.btn_Salir.TabIndex = 102
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(583, 35)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Eliminar.TabIndex = 101
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(511, 35)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Aceptar.TabIndex = 100
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(459, 94)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(59, 17)
        Me.lbl_Nombre.TabIndex = 103
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(459, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Orden:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(459, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Codigo:"
        '
        'Ctl_txt_Nombre
        '
        Me.Ctl_txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ctl_txt_Nombre.Location = New System.Drawing.Point(517, 93)
        Me.Ctl_txt_Nombre.Name = "Ctl_txt_Nombre"
        Me.Ctl_txt_Nombre.Size = New System.Drawing.Size(206, 20)
        Me.Ctl_txt_Nombre.TabIndex = 121
        '
        'txt_codigo
        '
        Me.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_codigo.Location = New System.Drawing.Point(517, 116)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(48, 20)
        Me.txt_codigo.TabIndex = 122
        '
        'txt_orden
        '
        Me.txt_orden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orden.Location = New System.Drawing.Point(517, 138)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.Prp_Formato = True
        Me.txt_orden.Prp_NumDecimales = CType(0, Short)
        Me.txt_orden.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.txt_orden.Prp_ValDefault = "9"
        Me.txt_orden.Size = New System.Drawing.Size(48, 20)
        Me.txt_orden.TabIndex = 123
        '
        'frm_Antibioticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(744, 464)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Ctl_txt_Nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.txt_test)
        Me.Controls.Add(Me.lbl_test)
        Me.Controls.Add(Me.dgrd_Antibioticos)
        Me.Controls.Add(Me.lbl_textform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Antibioticos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Antibioticos"
        CType(Me.dgrd_Antibioticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents dgrd_Antibioticos As System.Windows.Forms.DataGrid
    Friend WithEvents txt_test As System.Windows.Forms.TextBox
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgtc_Id As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_Nombre As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_Cod As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_Orden As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Ctl_txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_orden As Ctl_txt.ctl_txt_numeros
End Class
