<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cie10Gestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cie10Gestion))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Dgrd_Cie10 = New System.Windows.Forms.DataGrid
        Me.txt_Cod3 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Des3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Des4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Cod4 = New System.Windows.Forms.TextBox
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.Dgrd_Cie10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 25)
        Me.Panel1.TabIndex = 183
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
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "GESTION CIE 10"
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
        Me.Dgrd_Cie10.Location = New System.Drawing.Point(12, 147)
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
        Me.Dgrd_Cie10.Size = New System.Drawing.Size(658, 258)
        Me.Dgrd_Cie10.TabIndex = 187
        Me.Dgrd_Cie10.TabStop = False
        '
        'txt_Cod3
        '
        Me.txt_Cod3.Location = New System.Drawing.Point(100, 86)
        Me.txt_Cod3.Name = "txt_Cod3"
        Me.txt_Cod3.Size = New System.Drawing.Size(66, 20)
        Me.txt_Cod3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "CODIGO 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "DESCRIPCION 3"
        '
        'txt_Des3
        '
        Me.txt_Des3.Location = New System.Drawing.Point(268, 87)
        Me.txt_Des3.Name = "txt_Des3"
        Me.txt_Des3.Size = New System.Drawing.Size(402, 20)
        Me.txt_Des3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "DESCRIPCION 4"
        '
        'txt_Des4
        '
        Me.txt_Des4.Location = New System.Drawing.Point(268, 114)
        Me.txt_Des4.Name = "txt_Des4"
        Me.txt_Des4.Size = New System.Drawing.Size(402, 20)
        Me.txt_Des4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "CODIGO 4"
        '
        'txt_Cod4
        '
        Me.txt_Cod4.Location = New System.Drawing.Point(100, 113)
        Me.txt_Cod4.Name = "txt_Cod4"
        Me.txt_Cod4.Size = New System.Drawing.Size(66, 20)
        Me.txt_Cod4.TabIndex = 3
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(355, 35)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 39)
        Me.btn_Nuevo.TabIndex = 196
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
        Me.btn_Salir.Location = New System.Drawing.Point(592, 35)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 39)
        Me.btn_Salir.TabIndex = 199
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(513, 35)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 39)
        Me.btn_Eliminar.TabIndex = 198
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(434, 35)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 39)
        Me.btn_Aceptar.TabIndex = 197
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'frm_Cie10Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(691, 417)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Des4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Cod4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Des3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Cod3)
        Me.Controls.Add(Me.Dgrd_Cie10)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Cie10Gestion"
        Me.Text = "frm_Cie10Gestion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgrd_Cie10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dgrd_Cie10 As System.Windows.Forms.DataGrid
    Friend WithEvents txt_Cod3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Des3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Des4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Cod4 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
End Class
