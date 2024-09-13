<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ing_Monitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Ing_Monitor))
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.dgrd_trabajo = New System.Windows.Forms.DataGrid
        Me.dtp_fecing = New System.Windows.Forms.DateTimePicker
        Me.cmb_prioridad = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmb_vistas = New System.Windows.Forms.ComboBox
        Me.cmb_area = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_trabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(4, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(89, 19)
        Me.lbl_textform.TabIndex = 95
        Me.lbl_textform.Text = "MONITOR"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(963, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 94
        Me.pic_barra.TabStop = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(856, 75)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(84, 50)
        Me.btn_Salir.TabIndex = 135
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'dgrd_trabajo
        '
        Me.dgrd_trabajo.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_trabajo.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_trabajo.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_trabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_trabajo.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_trabajo.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_trabajo.CaptionText = "CONVENIO"
        Me.dgrd_trabajo.DataMember = ""
        Me.dgrd_trabajo.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_trabajo.ForeColor = System.Drawing.Color.Black
        Me.dgrd_trabajo.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_trabajo.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_trabajo.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_trabajo.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_trabajo.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_trabajo.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_trabajo.Location = New System.Drawing.Point(23, 132)
        Me.dgrd_trabajo.Name = "dgrd_trabajo"
        Me.dgrd_trabajo.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_trabajo.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_trabajo.RowHeaderWidth = 5
        Me.dgrd_trabajo.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_trabajo.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_trabajo.Size = New System.Drawing.Size(917, 424)
        Me.dgrd_trabajo.TabIndex = 136
        '
        'dtp_fecing
        '
        Me.dtp_fecing.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_fecing.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecing.Location = New System.Drawing.Point(202, 46)
        Me.dtp_fecing.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecing.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecing.Name = "dtp_fecing"
        Me.dtp_fecing.Size = New System.Drawing.Size(81, 20)
        Me.dtp_fecing.TabIndex = 137
        '
        'cmb_prioridad
        '
        Me.cmb_prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prioridad.Location = New System.Drawing.Point(302, 46)
        Me.cmb_prioridad.Name = "cmb_prioridad"
        Me.cmb_prioridad.Size = New System.Drawing.Size(115, 21)
        Me.cmb_prioridad.TabIndex = 139
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmb_vistas)
        Me.GroupBox1.Controls.Add(Me.cmb_area)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(458, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 37)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        '
        'cmb_vistas
        '
        Me.cmb_vistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_vistas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_vistas.Items.AddRange(New Object() {"<Todos>", "Pendientes", "Procesados", "Validados", "Enviados", "Rechazados", "Remitidos"})
        Me.cmb_vistas.Location = New System.Drawing.Point(264, 11)
        Me.cmb_vistas.Name = "cmb_vistas"
        Me.cmb_vistas.Size = New System.Drawing.Size(110, 21)
        Me.cmb_vistas.TabIndex = 1
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_area.Location = New System.Drawing.Point(40, 11)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(161, 21)
        Me.cmb_area.TabIndex = 106
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(5, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "AREA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(216, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "ESTADO:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(202, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 51)
        Me.Button1.TabIndex = 140
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(264, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 51)
        Me.Button2.TabIndex = 141
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(326, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 51)
        Me.Button3.TabIndex = 142
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(388, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 51)
        Me.Button4.TabIndex = 143
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 144
        Me.PictureBox1.TabStop = False
        '
        'frm_Ing_Monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(963, 568)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_prioridad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp_fecing)
        Me.Controls.Add(Me.dgrd_trabajo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.pic_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Ing_Monitor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Ing_Monitor"
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_trabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents dgrd_trabajo As System.Windows.Forms.DataGrid
    Friend WithEvents dtp_fecing As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_vistas As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
