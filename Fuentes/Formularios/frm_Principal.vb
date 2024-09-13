Public Class frm_Principal
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Laboratorio As System.Windows.Forms.Button
    Friend WithEvents btn_parametros As System.Windows.Forms.Button
    Friend WithEvents lbl_Unidades As System.Windows.Forms.Label
    Friend WithEvents btn_areas As System.Windows.Forms.Button
    Friend WithEvents btn_Equipos As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_Principal))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_parametros = New System.Windows.Forms.Button()
        Me.btn_Laboratorio = New System.Windows.Forms.Button()
        Me.lbl_Unidades = New System.Windows.Forms.Label()
        Me.btn_areas = New System.Windows.Forms.Button()
        Me.btn_Equipos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(358, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Salir"
        '
        'btn_parametros
        '
        Me.btn_parametros.BackColor = System.Drawing.Color.SlateGray
        Me.btn_parametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_parametros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_parametros.ForeColor = System.Drawing.Color.White
        Me.btn_parametros.Location = New System.Drawing.Point(38, 120)
        Me.btn_parametros.Name = "btn_parametros"
        Me.btn_parametros.Size = New System.Drawing.Size(112, 32)
        Me.btn_parametros.TabIndex = 0
        Me.btn_parametros.Text = "&Parámetros"
        '
        'btn_Laboratorio
        '
        Me.btn_Laboratorio.BackColor = System.Drawing.Color.SlateGray
        Me.btn_Laboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Laboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Laboratorio.ForeColor = System.Drawing.Color.White
        Me.btn_Laboratorio.Location = New System.Drawing.Point(16, 80)
        Me.btn_Laboratorio.Name = "btn_Laboratorio"
        Me.btn_Laboratorio.Size = New System.Drawing.Size(112, 32)
        Me.btn_Laboratorio.TabIndex = 2
        Me.btn_Laboratorio.Text = "&Laboratorio"
        '
        'lbl_Unidades
        '
        Me.lbl_Unidades.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Unidades.Font = New System.Drawing.Font("Arial", 15.75!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Unidades.Location = New System.Drawing.Point(38, 18)
        Me.lbl_Unidades.Name = "lbl_Unidades"
        Me.lbl_Unidades.Size = New System.Drawing.Size(170, 27)
        Me.lbl_Unidades.TabIndex = 3
        Me.lbl_Unidades.Text = "Menú Principal"
        '
        'btn_areas
        '
        Me.btn_areas.BackColor = System.Drawing.Color.SlateGray
        Me.btn_areas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_areas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_areas.ForeColor = System.Drawing.Color.White
        Me.btn_areas.Location = New System.Drawing.Point(60, 160)
        Me.btn_areas.Name = "btn_areas"
        Me.btn_areas.Size = New System.Drawing.Size(112, 32)
        Me.btn_areas.TabIndex = 4
        Me.btn_areas.Text = "Á&reas"
        '
        'btn_Equipos
        '
        Me.btn_Equipos.BackColor = System.Drawing.Color.SlateGray
        Me.btn_Equipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Equipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Equipos.ForeColor = System.Drawing.Color.White
        Me.btn_Equipos.Location = New System.Drawing.Point(84, 202)
        Me.btn_Equipos.Name = "btn_Equipos"
        Me.btn_Equipos.Size = New System.Drawing.Size(112, 32)
        Me.btn_Equipos.TabIndex = 5
        Me.btn_Equipos.Text = "&Equipos"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 40)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(120, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Tipos de Test"
        '
        'frm_Principal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(502, 358)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.PictureBox1, Me.btn_Equipos, Me.btn_areas, Me.lbl_Unidades, Me.btn_Laboratorio, Me.btn_parametros, Me.Button1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIS MENU PRINCIPAL"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As Object
        r = MsgBox("Desea abandonar el Sistema? ", MsgBoxStyle.YesNo, "Salir del Sistema")
        If r = vbYes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_parametros.Click
        Dim f1 As New frm_Parametros()
        f1.Show()
    End Sub

    Private Sub btn_Laboratorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Laboratorio.Click
        Dim f1 As New frm_laboratorio()
        f1.Show()
    End Sub

    Private Sub btn_areas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_areas.Click
        Dim f1 As New frm_Areas()
        f1.Show()
    End Sub

    Private Sub btn_Equipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Equipos.Click
        Dim f1 As New frm_Equipos()
        f1.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f1 As New frm_TipoTest()
        f1.Show()
    End Sub
End Class
