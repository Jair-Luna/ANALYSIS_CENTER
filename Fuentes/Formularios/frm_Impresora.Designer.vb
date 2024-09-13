<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Impresora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Impresora))
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.dgrd_Impresoras = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbl_test = New System.Windows.Forms.Label
        Me.cmb_impresoras = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_reportes = New System.Windows.Forms.ComboBox
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra.SuspendLayout()
        CType(Me.dgrd_Impresoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(587, 25)
        Me.pan_barra.TabIndex = 113
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(9, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(111, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "IMPRESORAS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgrd_Impresoras
        '
        Me.dgrd_Impresoras.AllowNavigation = False
        Me.dgrd_Impresoras.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Impresoras.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Impresoras.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Impresoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Impresoras.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Impresoras.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Impresoras.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Impresoras.CaptionText = "DISTRIBUCION"
        Me.dgrd_Impresoras.DataMember = ""
        Me.dgrd_Impresoras.FlatMode = True
        Me.dgrd_Impresoras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Impresoras.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Impresoras.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Impresoras.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Impresoras.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Impresoras.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Impresoras.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Impresoras.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Impresoras.Location = New System.Drawing.Point(12, 131)
        Me.dgrd_Impresoras.Name = "dgrd_Impresoras"
        Me.dgrd_Impresoras.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Impresoras.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Impresoras.PreferredColumnWidth = 95
        Me.dgrd_Impresoras.ReadOnly = True
        Me.dgrd_Impresoras.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Impresoras.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Impresoras.Size = New System.Drawing.Size(563, 253)
        Me.dgrd_Impresoras.TabIndex = 97
        Me.dgrd_Impresoras.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Impresoras.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Impresoras
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.DarkGray
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.SlateBlue
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID"
        Me.DataGridTextBoxColumn1.MappingName = "IMP_ID"
        Me.DataGridTextBoxColumn1.Width = 30
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "IMPRESORA"
        Me.DataGridTextBoxColumn2.MappingName = "IMP_IMPRESORA"
        Me.DataGridTextBoxColumn2.Width = 270
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "REPORTE"
        Me.DataGridTextBoxColumn3.MappingName = "IMP_REPORTE"
        Me.DataGridTextBoxColumn3.Width = 160
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "OBJETO"
        Me.DataGridTextBoxColumn4.MappingName = "IMP_OBJETO"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'lbl_test
        '
        Me.lbl_test.AutoSize = True
        Me.lbl_test.BackColor = System.Drawing.Color.Transparent
        Me.lbl_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test.Location = New System.Drawing.Point(20, 53)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(70, 13)
        Me.lbl_test.TabIndex = 116
        Me.lbl_test.Text = "Impresora:"
        '
        'cmb_impresoras
        '
        Me.cmb_impresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_impresoras.FormattingEnabled = True
        Me.cmb_impresoras.Location = New System.Drawing.Point(96, 49)
        Me.cmb_impresoras.Name = "cmb_impresoras"
        Me.cmb_impresoras.Size = New System.Drawing.Size(224, 21)
        Me.cmb_impresoras.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Reporte:"
        '
        'cmb_reportes
        '
        Me.cmb_reportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_reportes.FormattingEnabled = True
        Me.cmb_reportes.Items.AddRange(New Object() {"Resultados AREA", "Resultados TODO", "Factura TOTAL", "Factura DETALLE", "Nota de venta TOTAL", "Nota de venta DETALLE", "Codigo de barras", "Reportes ESTADISTICA", "Reporte HISTORICO"})
        Me.cmb_reportes.Location = New System.Drawing.Point(96, 77)
        Me.cmb_reportes.Name = "cmb_reportes"
        Me.cmb_reportes.Size = New System.Drawing.Size(224, 21)
        Me.cmb_reportes.TabIndex = 119
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
        Me.btn_Salir.Location = New System.Drawing.Point(502, 59)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(73, 40)
        Me.btn_Salir.TabIndex = 122
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(429, 59)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Eliminar.TabIndex = 121
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(356, 59)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Aceptar.TabIndex = 120
        Me.btn_Aceptar.Text = "Asignar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'frm_Impresora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(587, 399)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.cmb_reportes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_impresoras)
        Me.Controls.Add(Me.lbl_test)
        Me.Controls.Add(Me.dgrd_Impresoras)
        Me.Controls.Add(Me.pan_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Impresora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Impresora"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgrd_Impresoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents dgrd_Impresoras As System.Windows.Forms.DataGrid
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents cmb_impresoras As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_reportes As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
End Class
