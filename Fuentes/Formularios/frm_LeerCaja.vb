Public Class frm_LeerCaja
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents pic_min As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_factura As System.Windows.Forms.TextBox
    Friend WithEvents txt_caja As System.Windows.Forms.TextBox
    Friend WithEvents btn_Leer As System.Windows.Forms.Button
    Friend WithEvents chk_testFactura As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaFac As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LeerCaja))
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.pic_icono = New System.Windows.Forms.PictureBox
        Me.pan_btn = New System.Windows.Forms.Panel
        Me.pic_min = New System.Windows.Forms.PictureBox
        Me.Pic_close = New System.Windows.Forms.PictureBox
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Leer = New System.Windows.Forms.Button
        Me.txt_caja = New System.Windows.Forms.TextBox
        Me.txt_factura = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_testFactura = New System.Windows.Forms.CheckedListBox
        Me.btn_cargar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.lbl_fechaFac = New System.Windows.Forms.Label
        Me.pan_barra.SuspendLayout()
        CType(Me.pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_btn.SuspendLayout()
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.pic_icono)
        Me.pan_barra.Controls.Add(Me.pan_btn)
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Controls.Add(Me.pic_barra)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(639, 25)
        Me.pan_barra.TabIndex = 109
        '
        'pic_icono
        '
        Me.pic_icono.BackColor = System.Drawing.Color.SteelBlue
        Me.pic_icono.Image = CType(resources.GetObject("pic_icono.Image"), System.Drawing.Image)
        Me.pic_icono.Location = New System.Drawing.Point(22, 5)
        Me.pic_icono.Name = "pic_icono"
        Me.pic_icono.Size = New System.Drawing.Size(16, 16)
        Me.pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_icono.TabIndex = 63
        Me.pic_icono.TabStop = False
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.Add(Me.pic_min)
        Me.pan_btn.Controls.Add(Me.Pic_close)
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(543, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(27, 12)
        Me.pan_btn.TabIndex = 3
        '
        'pic_min
        '
        Me.pic_min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pic_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_min.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_min.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pic_min.Image = CType(resources.GetObject("pic_min.Image"), System.Drawing.Image)
        Me.pic_min.Location = New System.Drawing.Point(0, 0)
        Me.pic_min.Name = "pic_min"
        Me.pic_min.Size = New System.Drawing.Size(12, 12)
        Me.pic_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_min.TabIndex = 2
        Me.pic_min.TabStop = False
        '
        'Pic_close
        '
        Me.Pic_close.BackColor = System.Drawing.SystemColors.Control
        Me.Pic_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pic_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pic_close.Image = CType(resources.GetObject("Pic_close.Image"), System.Drawing.Image)
        Me.Pic_close.Location = New System.Drawing.Point(15, 0)
        Me.Pic_close.Name = "Pic_close"
        Me.Pic_close.Size = New System.Drawing.Size(12, 12)
        Me.Pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_close.TabIndex = 1
        Me.Pic_close.TabStop = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.White
        Me.lbl_textform.Image = CType(resources.GetObject("lbl_textform.Image"), System.Drawing.Image)
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(35, 7)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(120, 13)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = " Leer pedido de caja"
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Image = CType(resources.GetObject("pic_barra.Image"), System.Drawing.Image)
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(639, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 91
        Me.pic_barra.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_Leer)
        Me.GroupBox1.Controls.Add(Me.txt_caja)
        Me.GroupBox1.Controls.Add(Me.txt_factura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 57)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE ORIGEN"
        '
        'btn_Leer
        '
        Me.btn_Leer.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Leer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Leer.Enabled = False
        Me.btn_Leer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Leer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Leer.ForeColor = System.Drawing.Color.Black
        Me.btn_Leer.Image = CType(resources.GetObject("btn_Leer.Image"), System.Drawing.Image)
        Me.btn_Leer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Leer.Location = New System.Drawing.Point(429, 24)
        Me.btn_Leer.Name = "btn_Leer"
        Me.btn_Leer.Size = New System.Drawing.Size(80, 24)
        Me.btn_Leer.TabIndex = 110
        Me.btn_Leer.Text = "Leer"
        Me.btn_Leer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Leer.UseVisualStyleBackColor = False
        '
        'txt_caja
        '
        Me.txt_caja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_caja.Location = New System.Drawing.Point(315, 24)
        Me.txt_caja.Name = "txt_caja"
        Me.txt_caja.Size = New System.Drawing.Size(63, 21)
        Me.txt_caja.TabIndex = 3
        '
        'txt_factura
        '
        Me.txt_factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_factura.Location = New System.Drawing.Point(102, 24)
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.Size = New System.Drawing.Size(126, 21)
        Me.txt_factura.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(234, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Caja:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Factura:"
        '
        'chk_testFactura
        '
        Me.chk_testFactura.Location = New System.Drawing.Point(61, 154)
        Me.chk_testFactura.Name = "chk_testFactura"
        Me.chk_testFactura.Size = New System.Drawing.Size(516, 260)
        Me.chk_testFactura.TabIndex = 111
        '
        'btn_cargar
        '
        Me.btn_cargar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cargar.Enabled = False
        Me.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar.ForeColor = System.Drawing.Color.Black
        Me.btn_cargar.Image = CType(resources.GetObject("btn_cargar.Image"), System.Drawing.Image)
        Me.btn_cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cargar.Location = New System.Drawing.Point(251, 426)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cargar.TabIndex = 112
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.Enabled = False
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.Location = New System.Drawing.Point(338, 426)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_salir.TabIndex = 113
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'lbl_paciente
        '
        Me.lbl_paciente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_paciente.Location = New System.Drawing.Point(59, 105)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(520, 18)
        Me.lbl_paciente.TabIndex = 114
        Me.lbl_paciente.Text = "Paciente:"
        '
        'lbl_fechaFac
        '
        Me.lbl_fechaFac.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechaFac.Location = New System.Drawing.Point(60, 126)
        Me.lbl_fechaFac.Name = "lbl_fechaFac"
        Me.lbl_fechaFac.Size = New System.Drawing.Size(518, 18)
        Me.lbl_fechaFac.TabIndex = 115
        Me.lbl_fechaFac.Text = "Fecha Factura:"
        '
        'frm_LeerCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(639, 459)
        Me.Controls.Add(Me.lbl_fechaFac)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.chk_testFactura)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pan_barra)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_LeerCaja"
        Me.ShowInTaskbar = False
        Me.Text = "Leer Pedido"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_btn.ResumeLayout(False)
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public frm_refer_main As Frm_Main

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class
