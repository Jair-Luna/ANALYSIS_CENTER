Public Class Frm_Main
    Inherits System.Windows.Forms.Form
    Dim opr_Agenda As New Cls_Agenda()
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Num_SinValidar As System.Windows.Forms.Label
    Friend WithEvents Num_SinProcesar As System.Windows.Forms.Label
    Friend WithEvents Num_Impresos As System.Windows.Forms.Label
    Friend WithEvents cmb_convenio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SinValidar As System.Windows.Forms.Label
    Friend WithEvents lbl_Entregados As System.Windows.Forms.Label
    Friend WithEvents lbl_SinProcesar As System.Windows.Forms.Label

    Dim total As Integer = 0
    Dim sin_procesar As Integer = 0
    Dim validados As Integer = 0
    Dim sin_validar As Integer = 0
    Dim impresos As Integer = 0
    Dim enviados As Integer = 0
    Dim pacientes As Integer = 0
    Dim pac_his As Integer = 0
    Dim EsOcup As Boolean = False
    Friend WithEvents lbl_enviados As System.Windows.Forms.Label
    Friend WithEvents Num_Enviados As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Num_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_Validados As System.Windows.Forms.Label
    Friend WithEvents Num_Validados As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Num_Pacientes As System.Windows.Forms.Label
    Friend WithEvents lbl_DiaSemana As System.Windows.Forms.Label
    Friend WithEvents lbl_DiaNum As System.Windows.Forms.Label
    Friend WithEvents lbl_Mes As System.Windows.Forms.Label
    Friend WithEvents btn_dtpUp As System.Windows.Forms.Button
    Friend WithEvents btn_dtpDown As System.Windows.Forms.Button
    Friend WithEvents Dtp_ped_fecing As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_His As System.Windows.Forms.Label
    Friend WithEvents Num_His As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Dim sw_semaforo As SByte

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
    Friend WithEvents timer_main As System.Timers.Timer
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Pan_MenuLnk As System.Windows.Forms.Panel
    Friend WithEvents Pan_OpcionLnk As System.Windows.Forms.Panel
    Friend WithEvents mdiClient1 As System.Windows.Forms.MdiClient
    Friend WithEvents hlp_ayuda As System.Windows.Forms.HelpProvider
    Friend WithEvents imgL_toolbox As System.Windows.Forms.ImageList
    Friend WithEvents Ctm_menu As System.Windows.Forms.ContextMenu
    Friend WithEvents ctm_menu2 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents Pan_Menu As System.Windows.Forms.Panel
    Friend WithEvents btn_menu1 As System.Windows.Forms.Button
    Friend WithEvents Pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents btn_menu6 As System.Windows.Forms.Button
    Friend WithEvents btn_menu3 As System.Windows.Forms.Button
    Friend WithEvents btn_menu2 As System.Windows.Forms.Button
    Friend WithEvents btn_menu4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Splitter As System.Windows.Forms.Splitter
    Friend WithEvents lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents lbl_usr As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_menu5 As System.Windows.Forms.Button
    Friend WithEvents btn_menu7 As System.Windows.Forms.Button
    Friend WithEvents sta_barmain As System.Windows.Forms.StatusBar
    Friend WithEvents sta_panes_mensaje As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sta_panel_fecha As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nti_main As System.Windows.Forms.NotifyIcon
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents btn_monitor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.timer_main = New System.Timers.Timer
        Me.imgL_toolbox = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Pan_MenuLnk = New System.Windows.Forms.Panel
        Me.Pan_OpcionLnk = New System.Windows.Forms.Panel
        Me.Ctm_menu = New System.Windows.Forms.ContextMenu
        Me.mdiClient1 = New System.Windows.Forms.MdiClient
        Me.hlp_ayuda = New System.Windows.Forms.HelpProvider
        Me.ctm_menu2 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pic_barra = New System.Windows.Forms.PictureBox
        Me.Pan_Menu = New System.Windows.Forms.Panel
        Me.btn_menu1 = New System.Windows.Forms.Button
        Me.btn_monitor = New System.Windows.Forms.Button
        Me.btn_menu7 = New System.Windows.Forms.Button
        Me.btn_menu5 = New System.Windows.Forms.Button
        Me.btn_menu6 = New System.Windows.Forms.Button
        Me.lbl_hora = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lbl_perfil = New System.Windows.Forms.Label
        Me.lbl_usr = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_menu4 = New System.Windows.Forms.Button
        Me.btn_menu3 = New System.Windows.Forms.Button
        Me.btn_menu2 = New System.Windows.Forms.Button
        Me.Splitter = New System.Windows.Forms.Splitter
        Me.sta_panel_fecha = New System.Windows.Forms.StatusBarPanel
        Me.sta_panes_mensaje = New System.Windows.Forms.StatusBarPanel
        Me.sta_barmain = New System.Windows.Forms.StatusBar
        Me.nti_main = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lbl_His = New System.Windows.Forms.Label
        Me.Num_His = New System.Windows.Forms.Label
        Me.Dtp_ped_fecing = New System.Windows.Forms.DateTimePicker
        Me.btn_dtpUp = New System.Windows.Forms.Button
        Me.btn_dtpDown = New System.Windows.Forms.Button
        Me.lbl_Mes = New System.Windows.Forms.Label
        Me.lbl_DiaSemana = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Num_Pacientes = New System.Windows.Forms.Label
        Me.lbl_Validados = New System.Windows.Forms.Label
        Me.Num_Validados = New System.Windows.Forms.Label
        Me.lbl_total = New System.Windows.Forms.Label
        Me.Num_Total = New System.Windows.Forms.Label
        Me.lbl_enviados = New System.Windows.Forms.Label
        Me.Num_Enviados = New System.Windows.Forms.Label
        Me.lbl_Entregados = New System.Windows.Forms.Label
        Me.lbl_SinProcesar = New System.Windows.Forms.Label
        Me.lbl_SinValidar = New System.Windows.Forms.Label
        Me.cmb_convenio = New System.Windows.Forms.ComboBox
        Me.Num_SinValidar = New System.Windows.Forms.Label
        Me.Num_SinProcesar = New System.Windows.Forms.Label
        Me.Num_Impresos = New System.Windows.Forms.Label
        Me.lbl_DiaNum = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        CType(Me.timer_main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Menu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sta_panel_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sta_panes_mensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer_main
        '
        Me.timer_main.Enabled = True
        Me.timer_main.Interval = 60000
        Me.timer_main.SynchronizingObject = Me
        '
        'imgL_toolbox
        '
        Me.imgL_toolbox.ImageStream = CType(resources.GetObject("imgL_toolbox.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgL_toolbox.TransparentColor = System.Drawing.Color.Transparent
        Me.imgL_toolbox.Images.SetKeyName(0, "")
        Me.imgL_toolbox.Images.SetKeyName(1, "")
        Me.imgL_toolbox.Images.SetKeyName(2, "")
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        '
        'Pan_MenuLnk
        '
        Me.Pan_MenuLnk.ForeColor = System.Drawing.Color.Black
        Me.Pan_MenuLnk.Location = New System.Drawing.Point(521, 58)
        Me.Pan_MenuLnk.Name = "Pan_MenuLnk"
        Me.Pan_MenuLnk.Size = New System.Drawing.Size(128, 40)
        Me.Pan_MenuLnk.TabIndex = 8
        Me.Pan_MenuLnk.Visible = False
        '
        'Pan_OpcionLnk
        '
        Me.Pan_OpcionLnk.ForeColor = System.Drawing.Color.Black
        Me.Pan_OpcionLnk.Location = New System.Drawing.Point(521, 98)
        Me.Pan_OpcionLnk.Name = "Pan_OpcionLnk"
        Me.Pan_OpcionLnk.Size = New System.Drawing.Size(128, 40)
        Me.Pan_OpcionLnk.TabIndex = 64
        Me.Pan_OpcionLnk.Visible = False
        '
        'mdiClient1
        '
        Me.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mdiClient1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdiClient1.ForeColor = System.Drawing.Color.Black
        Me.mdiClient1.Location = New System.Drawing.Point(167, 53)
        Me.mdiClient1.Name = "mdiClient1"
        Me.mdiClient1.Size = New System.Drawing.Size(1195, 613)
        Me.mdiClient1.TabIndex = 76
        '
        'hlp_ayuda
        '
        Me.hlp_ayuda.HelpNamespace = ""
        '
        'ctm_menu2
        '
        Me.ctm_menu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Ver agenda"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Restaurar"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Salir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = -1
        Me.MenuItem7.Text = ""
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = -1
        Me.MenuItem6.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(509, 365)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 79
        '
        'Pic_barra
        '
        Me.Pic_barra.Location = New System.Drawing.Point(3, 4)
        Me.Pic_barra.Name = "Pic_barra"
        Me.Pic_barra.Size = New System.Drawing.Size(1363, 50)
        Me.Pic_barra.TabIndex = 82
        Me.Pic_barra.TabStop = False
        '
        'Pan_Menu
        '
        Me.Pan_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Pan_Menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pan_Menu.Controls.Add(Me.btn_menu1)
        Me.Pan_Menu.Controls.Add(Me.btn_monitor)
        Me.Pan_Menu.Controls.Add(Me.btn_menu7)
        Me.Pan_Menu.Controls.Add(Me.btn_menu5)
        Me.Pan_Menu.Controls.Add(Me.btn_menu6)
        Me.Pan_Menu.Controls.Add(Me.lbl_hora)
        Me.Pan_Menu.Controls.Add(Me.Label3)
        Me.Pan_Menu.Controls.Add(Me.lbl_fecha)
        Me.Pan_Menu.Controls.Add(Me.PictureBox2)
        Me.Pan_Menu.Controls.Add(Me.lbl_perfil)
        Me.Pan_Menu.Controls.Add(Me.lbl_usr)
        Me.Pan_Menu.Controls.Add(Me.PictureBox1)
        Me.Pan_Menu.Controls.Add(Me.btn_menu4)
        Me.Pan_Menu.Controls.Add(Me.btn_menu3)
        Me.Pan_Menu.Controls.Add(Me.btn_menu2)
        Me.Pan_Menu.Location = New System.Drawing.Point(0, 1)
        Me.Pan_Menu.Name = "Pan_Menu"
        Me.Pan_Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Pan_Menu.Size = New System.Drawing.Size(1357, 53)
        Me.Pan_Menu.TabIndex = 83
        '
        'btn_menu1
        '
        Me.btn_menu1.BackColor = System.Drawing.Color.White
        Me.btn_menu1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu1.ForeColor = System.Drawing.Color.Black
        Me.btn_menu1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu1.Location = New System.Drawing.Point(521, 0)
        Me.btn_menu1.Name = "btn_menu1"
        Me.btn_menu1.Size = New System.Drawing.Size(120, 50)
        Me.btn_menu1.TabIndex = 1
        Me.btn_menu1.TabStop = False
        Me.btn_menu1.Tag = "1"
        Me.btn_menu1.Text = "ORDENES"
        Me.btn_menu1.UseVisualStyleBackColor = False
        '
        'btn_monitor
        '
        Me.btn_monitor.Image = CType(resources.GetObject("btn_monitor.Image"), System.Drawing.Image)
        Me.btn_monitor.Location = New System.Drawing.Point(138, 26)
        Me.btn_monitor.Name = "btn_monitor"
        Me.btn_monitor.Size = New System.Drawing.Size(50, 21)
        Me.btn_monitor.TabIndex = 93
        Me.btn_monitor.UseVisualStyleBackColor = True
        '
        'btn_menu7
        '
        Me.btn_menu7.BackColor = System.Drawing.Color.White
        Me.btn_menu7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_menu7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu7.ForeColor = System.Drawing.Color.Black
        Me.btn_menu7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu7.Location = New System.Drawing.Point(1235, 0)
        Me.btn_menu7.Name = "btn_menu7"
        Me.btn_menu7.Size = New System.Drawing.Size(120, 50)
        Me.btn_menu7.TabIndex = 89
        Me.btn_menu7.TabStop = False
        Me.btn_menu7.Tag = "10."
        Me.btn_menu7.Text = "SALIR"
        Me.btn_menu7.UseVisualStyleBackColor = False
        '
        'btn_menu5
        '
        Me.btn_menu5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu5.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu5.ForeColor = System.Drawing.Color.Black
        Me.btn_menu5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_menu5.Location = New System.Drawing.Point(997, 0)
        Me.btn_menu5.Name = "btn_menu5"
        Me.btn_menu5.Size = New System.Drawing.Size(120, 50)
        Me.btn_menu5.TabIndex = 90
        Me.btn_menu5.TabStop = False
        Me.btn_menu5.Tag = "6"
        Me.btn_menu5.Text = "ADMINISTRACION "
        '
        'btn_menu6
        '
        Me.btn_menu6.BackColor = System.Drawing.Color.White
        Me.btn_menu6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu6.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu6.ForeColor = System.Drawing.Color.Black
        Me.btn_menu6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu6.Location = New System.Drawing.Point(1116, 0)
        Me.btn_menu6.Name = "btn_menu6"
        Me.btn_menu6.Size = New System.Drawing.Size(120, 50)
        Me.btn_menu6.TabIndex = 5
        Me.btn_menu6.TabStop = False
        Me.btn_menu6.Tag = "5"
        Me.btn_menu6.Text = "MAESTROS"
        Me.btn_menu6.UseVisualStyleBackColor = False
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("OCR A Extended", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.Navy
        Me.lbl_hora.Location = New System.Drawing.Point(194, 21)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(66, 23)
        Me.lbl_hora.TabIndex = 92
        Me.lbl_hora.Text = "HORA"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(54, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "CENTER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_fecha.Location = New System.Drawing.Point(141, 6)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(38, 11)
        Me.lbl_fecha.TabIndex = 88
        Me.lbl_fecha.Text = "FECHA"
        Me.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_perfil.Location = New System.Drawing.Point(375, 28)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(38, 12)
        Me.lbl_perfil.TabIndex = 86
        Me.lbl_perfil.Text = "PERFIL"
        Me.lbl_perfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_usr
        '
        Me.lbl_usr.AutoSize = True
        Me.lbl_usr.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usr.Location = New System.Drawing.Point(375, 9)
        Me.lbl_usr.Name = "lbl_usr"
        Me.lbl_usr.Size = New System.Drawing.Size(49, 12)
        Me.lbl_usr.TabIndex = 85
        Me.lbl_usr.Text = "USUARIO"
        Me.lbl_usr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(331, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'btn_menu4
        '
        Me.btn_menu4.BackColor = System.Drawing.Color.White
        Me.btn_menu4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu4.ForeColor = System.Drawing.Color.Black
        Me.btn_menu4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu4.Location = New System.Drawing.Point(878, 0)
        Me.btn_menu4.Name = "btn_menu4"
        Me.btn_menu4.Size = New System.Drawing.Size(120, 50)
        Me.btn_menu4.TabIndex = 8
        Me.btn_menu4.TabStop = False
        Me.btn_menu4.Tag = "8"
        Me.btn_menu4.Text = "CONFIGURACION"
        Me.btn_menu4.UseVisualStyleBackColor = False
        '
        'btn_menu3
        '
        Me.btn_menu3.BackColor = System.Drawing.Color.White
        Me.btn_menu3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu3.ForeColor = System.Drawing.Color.Black
        Me.btn_menu3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu3.Location = New System.Drawing.Point(759, 0)
        Me.btn_menu3.Name = "btn_menu3"
        Me.btn_menu3.Size = New System.Drawing.Size(120, 50)
        Me.btn_menu3.TabIndex = 4
        Me.btn_menu3.TabStop = False
        Me.btn_menu3.Tag = "4"
        Me.btn_menu3.Text = "ESTADISTICAS"
        Me.btn_menu3.UseVisualStyleBackColor = False
        '
        'btn_menu2
        '
        Me.btn_menu2.BackColor = System.Drawing.Color.White
        Me.btn_menu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu2.ForeColor = System.Drawing.Color.Black
        Me.btn_menu2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_menu2.Location = New System.Drawing.Point(640, 0)
        Me.btn_menu2.Name = "btn_menu2"
        Me.btn_menu2.Size = New System.Drawing.Size(120, 50)
        Me.btn_menu2.TabIndex = 3
        Me.btn_menu2.TabStop = False
        Me.btn_menu2.Tag = "3"
        Me.btn_menu2.Text = "RESULTADOS"
        Me.btn_menu2.UseVisualStyleBackColor = False
        '
        'Splitter
        '
        Me.Splitter.BackColor = System.Drawing.Color.White
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter.Location = New System.Drawing.Point(0, 0)
        Me.Splitter.Name = "Splitter"
        Me.Splitter.Size = New System.Drawing.Size(1362, 53)
        Me.Splitter.TabIndex = 84
        Me.Splitter.TabStop = False
        '
        'sta_panel_fecha
        '
        Me.sta_panel_fecha.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.sta_panel_fecha.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.sta_panel_fecha.Name = "sta_panel_fecha"
        Me.sta_panel_fecha.Width = 10
        '
        'sta_panes_mensaje
        '
        Me.sta_panes_mensaje.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.sta_panes_mensaje.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.sta_panes_mensaje.Name = "sta_panes_mensaje"
        Me.sta_panes_mensaje.Width = 1352
        '
        'sta_barmain
        '
        Me.sta_barmain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sta_barmain.Location = New System.Drawing.Point(0, 666)
        Me.sta_barmain.Name = "sta_barmain"
        Me.sta_barmain.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sta_panes_mensaje, Me.sta_panel_fecha})
        Me.sta_barmain.ShowPanels = True
        Me.sta_barmain.Size = New System.Drawing.Size(1362, 1)
        Me.sta_barmain.SizingGrip = False
        Me.sta_barmain.TabIndex = 1
        '
        'nti_main
        '
        Me.nti_main.ContextMenu = Me.ctm_menu2
        Me.nti_main.Icon = CType(resources.GetObject("nti_main.Icon"), System.Drawing.Icon)
        Me.nti_main.Text = "ANALISYS CENTER "
        Me.nti_main.Visible = True
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lbl_His)
        Me.Panel1.Controls.Add(Me.Num_His)
        Me.Panel1.Controls.Add(Me.Dtp_ped_fecing)
        Me.Panel1.Controls.Add(Me.btn_dtpUp)
        Me.Panel1.Controls.Add(Me.btn_dtpDown)
        Me.Panel1.Controls.Add(Me.lbl_Mes)
        Me.Panel1.Controls.Add(Me.lbl_DiaSemana)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Num_Pacientes)
        Me.Panel1.Controls.Add(Me.lbl_Validados)
        Me.Panel1.Controls.Add(Me.Num_Validados)
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.Num_Total)
        Me.Panel1.Controls.Add(Me.lbl_enviados)
        Me.Panel1.Controls.Add(Me.Num_Enviados)
        Me.Panel1.Controls.Add(Me.lbl_Entregados)
        Me.Panel1.Controls.Add(Me.lbl_SinProcesar)
        Me.Panel1.Controls.Add(Me.lbl_SinValidar)
        Me.Panel1.Controls.Add(Me.cmb_convenio)
        Me.Panel1.Controls.Add(Me.Num_SinValidar)
        Me.Panel1.Controls.Add(Me.Num_SinProcesar)
        Me.Panel1.Controls.Add(Me.Num_Impresos)
        Me.Panel1.Controls.Add(Me.lbl_DiaNum)
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(167, 580)
        Me.Panel1.TabIndex = 89
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(126, 185)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 161
        Me.PictureBox3.TabStop = False
        '
        'lbl_His
        '
        Me.lbl_His.AutoSize = True
        Me.lbl_His.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_His.ForeColor = System.Drawing.Color.White
        Me.lbl_His.Location = New System.Drawing.Point(52, 269)
        Me.lbl_His.Name = "lbl_His"
        Me.lbl_His.Size = New System.Drawing.Size(30, 16)
        Me.lbl_His.TabIndex = 160
        Me.lbl_His.Text = "HIS"
        Me.lbl_His.Visible = False
        '
        'Num_His
        '
        Me.Num_His.BackColor = System.Drawing.Color.LightCoral
        Me.Num_His.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_His.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_His.ForeColor = System.Drawing.Color.White
        Me.Num_His.Location = New System.Drawing.Point(8, 261)
        Me.Num_His.Name = "Num_His"
        Me.Num_His.Size = New System.Drawing.Size(42, 32)
        Me.Num_His.TabIndex = 159
        Me.Num_His.Text = "000"
        Me.Num_His.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Num_His.Visible = False
        '
        'Dtp_ped_fecing
        '
        Me.Dtp_ped_fecing.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ped_fecing.Location = New System.Drawing.Point(33, 484)
        Me.Dtp_ped_fecing.Name = "Dtp_ped_fecing"
        Me.Dtp_ped_fecing.Size = New System.Drawing.Size(93, 20)
        Me.Dtp_ped_fecing.TabIndex = 158
        Me.Dtp_ped_fecing.Visible = False
        '
        'btn_dtpUp
        '
        Me.btn_dtpUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dtpUp.ForeColor = System.Drawing.Color.Black
        Me.btn_dtpUp.Image = CType(resources.GetObject("btn_dtpUp.Image"), System.Drawing.Image)
        Me.btn_dtpUp.Location = New System.Drawing.Point(108, 54)
        Me.btn_dtpUp.Name = "btn_dtpUp"
        Me.btn_dtpUp.Size = New System.Drawing.Size(44, 35)
        Me.btn_dtpUp.TabIndex = 157
        Me.btn_dtpUp.UseVisualStyleBackColor = True
        '
        'btn_dtpDown
        '
        Me.btn_dtpDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dtpDown.ForeColor = System.Drawing.Color.Black
        Me.btn_dtpDown.Image = CType(resources.GetObject("btn_dtpDown.Image"), System.Drawing.Image)
        Me.btn_dtpDown.Location = New System.Drawing.Point(9, 53)
        Me.btn_dtpDown.Name = "btn_dtpDown"
        Me.btn_dtpDown.Size = New System.Drawing.Size(44, 35)
        Me.btn_dtpDown.TabIndex = 156
        Me.btn_dtpDown.UseVisualStyleBackColor = True
        '
        'lbl_Mes
        '
        Me.lbl_Mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mes.ForeColor = System.Drawing.Color.White
        Me.lbl_Mes.Location = New System.Drawing.Point(12, 92)
        Me.lbl_Mes.Name = "lbl_Mes"
        Me.lbl_Mes.Size = New System.Drawing.Size(140, 24)
        Me.lbl_Mes.TabIndex = 104
        Me.lbl_Mes.Text = "[mes]"
        Me.lbl_Mes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_DiaSemana
        '
        Me.lbl_DiaSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DiaSemana.ForeColor = System.Drawing.Color.White
        Me.lbl_DiaSemana.Location = New System.Drawing.Point(12, 14)
        Me.lbl_DiaSemana.Name = "lbl_DiaSemana"
        Me.lbl_DiaSemana.Size = New System.Drawing.Size(140, 24)
        Me.lbl_DiaSemana.TabIndex = 103
        Me.lbl_DiaSemana.Text = "[dia]"
        Me.lbl_DiaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(49, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "NUEVOS"
        '
        'Num_Pacientes
        '
        Me.Num_Pacientes.BackColor = System.Drawing.Color.Transparent
        Me.Num_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_Pacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_Pacientes.ForeColor = System.Drawing.Color.White
        Me.Num_Pacientes.Location = New System.Drawing.Point(8, 187)
        Me.Num_Pacientes.Name = "Num_Pacientes"
        Me.Num_Pacientes.Size = New System.Drawing.Size(42, 32)
        Me.Num_Pacientes.TabIndex = 99
        Me.Num_Pacientes.Text = "000"
        Me.Num_Pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Validados
        '
        Me.lbl_Validados.AutoSize = True
        Me.lbl_Validados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Validados.ForeColor = System.Drawing.Color.White
        Me.lbl_Validados.Location = New System.Drawing.Point(52, 374)
        Me.lbl_Validados.Name = "lbl_Validados"
        Me.lbl_Validados.Size = New System.Drawing.Size(84, 16)
        Me.lbl_Validados.TabIndex = 98
        Me.lbl_Validados.Text = "VALIDADOS"
        '
        'Num_Validados
        '
        Me.Num_Validados.BackColor = System.Drawing.Color.LimeGreen
        Me.Num_Validados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_Validados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_Validados.ForeColor = System.Drawing.Color.White
        Me.Num_Validados.Location = New System.Drawing.Point(8, 366)
        Me.Num_Validados.Name = "Num_Validados"
        Me.Num_Validados.Size = New System.Drawing.Size(42, 32)
        Me.Num_Validados.TabIndex = 97
        Me.Num_Validados.Text = "000"
        Me.Num_Validados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(51, 230)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(68, 20)
        Me.lbl_total.TabIndex = 96
        Me.lbl_total.Text = "TOTAL"
        '
        'Num_Total
        '
        Me.Num_Total.BackColor = System.Drawing.Color.Gray
        Me.Num_Total.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_Total.ForeColor = System.Drawing.Color.White
        Me.Num_Total.Location = New System.Drawing.Point(8, 223)
        Me.Num_Total.Name = "Num_Total"
        Me.Num_Total.Size = New System.Drawing.Size(42, 32)
        Me.Num_Total.TabIndex = 95
        Me.Num_Total.Text = "000"
        Me.Num_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_enviados
        '
        Me.lbl_enviados.AutoSize = True
        Me.lbl_enviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enviados.ForeColor = System.Drawing.Color.White
        Me.lbl_enviados.Location = New System.Drawing.Point(52, 444)
        Me.lbl_enviados.Name = "lbl_enviados"
        Me.lbl_enviados.Size = New System.Drawing.Size(77, 16)
        Me.lbl_enviados.TabIndex = 94
        Me.lbl_enviados.Text = "ENVIADOS"
        '
        'Num_Enviados
        '
        Me.Num_Enviados.BackColor = System.Drawing.Color.SkyBlue
        Me.Num_Enviados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_Enviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_Enviados.ForeColor = System.Drawing.Color.White
        Me.Num_Enviados.Location = New System.Drawing.Point(8, 436)
        Me.Num_Enviados.Name = "Num_Enviados"
        Me.Num_Enviados.Size = New System.Drawing.Size(42, 32)
        Me.Num_Enviados.TabIndex = 93
        Me.Num_Enviados.Text = "000"
        Me.Num_Enviados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Entregados
        '
        Me.lbl_Entregados.AutoSize = True
        Me.lbl_Entregados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Entregados.ForeColor = System.Drawing.Color.White
        Me.lbl_Entregados.Location = New System.Drawing.Point(51, 409)
        Me.lbl_Entregados.Name = "lbl_Entregados"
        Me.lbl_Entregados.Size = New System.Drawing.Size(78, 16)
        Me.lbl_Entregados.TabIndex = 92
        Me.lbl_Entregados.Text = "IMPRESOS"
        '
        'lbl_SinProcesar
        '
        Me.lbl_SinProcesar.AutoSize = True
        Me.lbl_SinProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SinProcesar.ForeColor = System.Drawing.Color.White
        Me.lbl_SinProcesar.Location = New System.Drawing.Point(51, 304)
        Me.lbl_SinProcesar.Name = "lbl_SinProcesar"
        Me.lbl_SinProcesar.Size = New System.Drawing.Size(108, 16)
        Me.lbl_SinProcesar.TabIndex = 91
        Me.lbl_SinProcesar.Text = "SIN PROCESAR"
        '
        'lbl_SinValidar
        '
        Me.lbl_SinValidar.AutoSize = True
        Me.lbl_SinValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SinValidar.ForeColor = System.Drawing.Color.White
        Me.lbl_SinValidar.Location = New System.Drawing.Point(50, 339)
        Me.lbl_SinValidar.Name = "lbl_SinValidar"
        Me.lbl_SinValidar.Size = New System.Drawing.Size(90, 16)
        Me.lbl_SinValidar.TabIndex = 90
        Me.lbl_SinValidar.Text = "SIN VALIDAR"
        '
        'cmb_convenio
        '
        Me.cmb_convenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_convenio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_convenio.Location = New System.Drawing.Point(4, 152)
        Me.cmb_convenio.Name = "cmb_convenio"
        Me.cmb_convenio.Size = New System.Drawing.Size(155, 27)
        Me.cmb_convenio.TabIndex = 89
        '
        'Num_SinValidar
        '
        Me.Num_SinValidar.BackColor = System.Drawing.Color.Red
        Me.Num_SinValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_SinValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_SinValidar.ForeColor = System.Drawing.Color.White
        Me.Num_SinValidar.Location = New System.Drawing.Point(8, 331)
        Me.Num_SinValidar.Name = "Num_SinValidar"
        Me.Num_SinValidar.Size = New System.Drawing.Size(42, 32)
        Me.Num_SinValidar.TabIndex = 86
        Me.Num_SinValidar.Text = "000"
        Me.Num_SinValidar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Num_SinProcesar
        '
        Me.Num_SinProcesar.BackColor = System.Drawing.Color.Orange
        Me.Num_SinProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_SinProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_SinProcesar.ForeColor = System.Drawing.Color.White
        Me.Num_SinProcesar.Location = New System.Drawing.Point(8, 296)
        Me.Num_SinProcesar.Name = "Num_SinProcesar"
        Me.Num_SinProcesar.Size = New System.Drawing.Size(42, 32)
        Me.Num_SinProcesar.TabIndex = 87
        Me.Num_SinProcesar.Text = "000"
        Me.Num_SinProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Num_Impresos
        '
        Me.Num_Impresos.BackColor = System.Drawing.Color.LightGreen
        Me.Num_Impresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Num_Impresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_Impresos.ForeColor = System.Drawing.Color.White
        Me.Num_Impresos.Location = New System.Drawing.Point(8, 401)
        Me.Num_Impresos.Name = "Num_Impresos"
        Me.Num_Impresos.Size = New System.Drawing.Size(42, 32)
        Me.Num_Impresos.TabIndex = 88
        Me.Num_Impresos.Text = "000"
        Me.Num_Impresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_DiaNum
        '
        Me.lbl_DiaNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DiaNum.ForeColor = System.Drawing.Color.White
        Me.lbl_DiaNum.Location = New System.Drawing.Point(49, 41)
        Me.lbl_DiaNum.Name = "lbl_DiaNum"
        Me.lbl_DiaNum.Size = New System.Drawing.Size(66, 51)
        Me.lbl_DiaNum.TabIndex = 102
        Me.lbl_DiaNum.Text = "00"
        Me.lbl_DiaNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.DarkGray
        Me.Splitter1.Location = New System.Drawing.Point(0, 53)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(167, 613)
        Me.Splitter1.TabIndex = 90
        Me.Splitter1.TabStop = False
        '
        'Frm_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1362, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Pan_Menu)
        Me.Controls.Add(Me.Pic_barra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pan_OpcionLnk)
        Me.Controls.Add(Me.Pan_MenuLnk)
        Me.Controls.Add(Me.sta_barmain)
        Me.Controls.Add(Me.Splitter)
        Me.Controls.Add(Me.mdiClient1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.hlp_ayuda.SetHelpKeyword(Me, "")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Frm_Main"
        Me.hlp_ayuda.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "    A N A L I S Y S"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.timer_main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Menu.ResumeLayout(False)
        Me.Pan_Menu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sta_panel_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sta_panes_mensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private btn_menuModelo, btn_menuModeloAUX As New Button()
    Private lnk_menuModelo, lnk_menuModeloAUX As New LinkLabel()
    Private lnk_ayuda As New LinkLabel()
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Dim paciente As String = Nothing
    Dim opr_pedido As New Cls_Pedido()



#Region "Funcionalidad de formulario"

    Private Sub timer_main_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles timer_main.Elapsed
        lbl_fecha.Text = (Format(Now(), "dddd, dd DE MMMM DEL yyyy").ToUpper())
        lbl_hora.Text = Format(Now(), "HH:mm")
        'g_Minuto = g_Minuto + 1

        'If g_Minuto = g_MinEspera Then
        '    MsgBox("CHAO")
        '    Me.Close()
        'End If


        '' ''PARA ACTIVAR INTERFAZ******
        ''nuevo_archivo = opr_interfaz.LeeArchivo(System.Configuration.ConfigurationSettings.AppSettings("RUTA"))
        ' ''paciente = opr_Agenda.ConsultaAgendaResumen(CStr(Format(Now(), "dd/MM/yyyy")), CStr(Format(DateAdd(DateInterval.Hour, -1, Now()), "HH:mm")), CStr(Format(DateAdd(DateInterval.Hour, +1, Now()), "HH:mm")))

        ''Me.nti_main.ShowBalloonTip(350000, "NUEVAS ORDENES", paciente, ToolTipIcon.Info)
        'MsgBox("AGENDA PENDIENTE")


        '' '' '' ''PARA ACTIVAR AGENDA ******
        '' '' '' ''If opr_Agenda.ExisteAgendaHoras(CStr(Format(Now(), "dd/MM/yyyy")), CStr(Format(DateAdd(DateInterval.Hour, -1, Now()), "HH:mm")), CStr(Format(DateAdd(DateInterval.Hour, +1, Now()), "HH:mm"))) > 0 Then
        '' '' '' ''    paciente = opr_Agenda.ConsultaAgendaResumen(CStr(Format(Now(), "dd/MM/yyyy")), CStr(Format(DateAdd(DateInterval.Hour, -1, Now()), "HH:mm")), CStr(Format(DateAdd(DateInterval.Hour, +1, Now()), "HH:mm")))

        '' '' '' ''    Me.nti_main.ShowBalloonTip(350000, "AGENDAMIENTO ANALISYS", paciente, ToolTipIcon.Info)
        '' '' '' ''    'MsgBox("AGENDA PENDIENTE")
        '' '' '' ''End If
    End Sub

    'Para el notify icon
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        nti_main.Visible = False
        Me.Close()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.WindowState = FormWindowState.Maximized
        If Not ExisteForm("frm_Agenda") Then
            Dim FrM_MDIChild As New Frm_Agenda()
            Crea_formulario(FrM_MDIChild)
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'Dim hlp_aux As Help
        'hlp_aux.ShowHelp(lnk_ayuda, Environment.CurrentDirectory & "/ayudas/Ayuda.chm")
    End Sub


#End Region

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'borrar variable con la verdadera global
        g_Minuto = 0
        lbl_usr.Text = g_invitado
        'Me.Text = "     A N A L I S Y S          " & g_str_unidad
        'sta_panel_estatus.Text = "Perfil: " & g_str_login 'Conectado"
        lbl_perfil.Text = g_str_login

        'sta_panel_fecha.Text = "Fecha: " & Format(Now(), "dd-MMMM-yyyy") '& "   Hora: " & Format(Now(), "HH:mm")
        lbl_fecha.Text = (Format(Now(), "dddd, dd DE MMMM DEL yyyy").ToUpper())
        lbl_hora.Text = Format(Now(), "HH:mm")
        'mdiClient1.BackColor = Color.Gray
        'hlp_ayuda.HelpNamespace = Environment.CurrentDirectory & "\ayudas\Ayuda.chm"
        'escribemsj("CREANDO REFERENCIA DE MENU")


        Crea_links()
        ' PARA VALIDAR Y QUE APAREZCA
        g_proceso = "En proceso.."
        Add_Handler_Menu()
        'Activacin del menu segun las opciones por usuario
        Dim dts_usuario As DataSet
        Dim dtr_fila As DataRow
        Dim str_menu() As String
        Dim int_arreglo, int_contador As Integer
        escribemsj("CREANDO MENU")
        dts_usuario = g_opr_usuario.LeerMenuSeleccionado(g_sng_user)
        int_arreglo = dts_usuario.Tables("Registros").Rows.Count
        ReDim str_menu(int_arreglo)
        int_contador = 0
        For Each dtr_fila In dts_usuario.Tables("Registros").Rows
            str_menu(int_contador) = dtr_fila(0)
            int_contador += 1
        Next

        Dim ctl_lnk As LinkLabel
        For Each ctl_lnk In Me.Pan_MenuLnk.Controls
            If Microsoft.VisualBasic.Right(ctl_lnk.Tag, 1) = "." Then
                ctl_lnk.Enabled = False
                For int_contador = 0 To int_arreglo - 1
                    If ctl_lnk.Tag = str_menu(int_contador) Then
                        ctl_lnk.Enabled = True
                        Exit For
                    End If
                Next
            End If
        Next
        For Each ctl_lnk In Me.Pan_OpcionLnk.Controls
            ctl_lnk.Enabled = False
            For int_contador = 0 To int_arreglo - 1
                If ctl_lnk.Tag = str_menu(int_contador) Then
                    ctl_lnk.Enabled = True
                    Exit For
                End If
            Next
        Next
        escribemsj("DISPONIBLE")
        Splitter1.Hide()
        Panel1.Hide()
        sw_semaforo = 1
        opr_pedido.LlenarComboPrioridad(cmb_convenio, False, True)
    End Sub

#Region "*** MANEJO DE MENU ***"

    Private Sub Cerrar_Form(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'pregunta para salir del sistema
        'If g_Minuto >= 3 Then
        If MsgBox("Desea salir del sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            'Cambia el estado del uuario en la base a O
            If g_byt_administrador = 0 Then
                g_opr_usuario.CambiarConectado(g_sng_user, 0)
            End If
            e.Cancel = False
        Else
            e.Cancel = True
        End If
        'Else
        'e.Cancel = True
        'End If

    End Sub

    Private Sub Presiona_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mdiClient1.Click
        Limpia_menu()
    End Sub


    Public Sub Limpia_menu()
        Pan_MenuLnk.Visible = False
        Pan_OpcionLnk.Visible = False
    End Sub

    Public Sub Crea_formulario(ByVal FrM_MDIChild As Form, Optional ByVal frm_Padre As Form = Nothing)
        'se usa el parametro opcional, cuando se crea la forma desde otro form que se encuentra como modal
        Call Limpia_menu()
        Dim menuItem As New MenuItem()
        If IsNothing(frm_Padre) Then
            FrM_MDIChild.MdiParent = Me
        Else
            FrM_MDIChild.MdiParent = frm_Padre
        End If
        'If ExisteForm(FrM_MDIChild.Name) Then
        'FrM_MDIChild.Close()
        'End If
        FrM_MDIChild.Show()
        menuItem.Text = FrM_MDIChild.Text
        Ctm_menu.MenuItems.Add(menuItem)
        AddHandler menuItem.Click, AddressOf Me.menuItem_Click
    End Sub

    Public Sub Crea_formularioDialog(ByVal FrM_MDIChild As Form, Optional ByVal frm_Padre As Form = Nothing)
        'se usa el parametro opcional, cuando se crea la forma desde otro form que se encuentra como modal
        Call Limpia_menu()
        Dim menuItem As New MenuItem()
        FrM_MDIChild.ShowDialog()
        Ctm_menu.MenuItems.Add(menuItem)
        AddHandler menuItem.Click, AddressOf Me.menuItem_Click
    End Sub

#Region "//Mouse Move en el status bar//"
    Private Sub sta_barmain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sta_barmain.MouseMove
        Limpia_menu()
    End Sub
#End Region

#Region "//Mouse Move en panel de Menu//"
    Private Sub PanelMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'movimiento del mouse por el panel del menu de controles, cuando no se encuentra a la altura de los botones
        If e.Y < btn_menu1.Top Or e.Y > btn_menu4.Top + btn_menu4.Height Then
            Limpia_menu()
        End If
    End Sub
#End Region

#Region "//Click en los botones//"
    'Click en los botones
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Microsoft.VisualBasic.Right(sender.TAG, 1) = "." Then
            Opera_links(sender, 1, Pan_OpcionLnk)
        End If
    End Sub
#End Region

#Region "//Click en los links//"
    'Click en los links
    Private Sub LnkMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Opera_links(sender, 1, Pan_OpcionLnk)
    End Sub


    Private Sub LnkMenu_Click2(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Opera_links(sender, 1, Pan_OpcionLnk)
    End Sub
#End Region

#Region "//Menu_MouseEnter//"
    'Mouse Enter sobre los miembros del menu
    Private Sub Menu_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim str_name_sender As String
        str_name_sender = UCase(Mid(sender.name, 1, 5))

        Select Case str_name_sender
            Case "PAN_T"
                Limpia_menu()

            Case "BTN_M"
                Pan_OpcionLnk.Visible = False
                sender.Font = New Font("Verdana", 6.75!, FontStyle.Bold)
                sender.focus() ''
                If m_HtImages.ContainsKey("barraMenu2") Then
                    imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
                        m_HtImages.Add("barraMenu2", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.BackgroundImage = imageToDraw
                Opera_links(sender, 0, Pan_MenuLnk)

            Case "LNK_M", "LNK_O"
                sender.LinkColor = Color.Red
                If m_HtImages.ContainsKey("barraMenu2") Then
                    imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
                        m_HtImages.Add("barraMenu2", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
                Opera_links(sender, 0, Pan_OpcionLnk)
        End Select

        If btn_menuModelo.Name <> sender.name And lnk_menuModelo.Name <> sender.name Then
            Select Case str_name_sender
                Case "BTN_M"
                    btn_menuModeloAUX = sender
                    sender = btn_menuModelo
                    sender.Font = New Font("Verdana", 6.75!, FontStyle.Regular)
                    If m_HtImages.ContainsKey("barraMenu2") Then '1'
                        imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
                            m_HtImages.Add("barraMenu2", imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                    sender.BackgroundImage = imageToDraw
                    sender = btn_menuModeloAUX

                Case "LNK_M"
                    lnk_menuModeloAUX = sender
                    sender = lnk_menuModelo
                    sender.LinkColor = Color.Black
                    sender.Image = Nothing
                    sender = lnk_menuModeloAUX
                Case Else
            End Select
        End If
    End Sub
#End Region

#Region "//Menu_MouseLeave//"
    'mouse pierde el enfoque de los miembros del menu
    Private Sub Menu_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case UCase(Mid(sender.name, 1, 5))
            Case "PAN_M"

            Case "PAN_O"

            Case "BTN_M"
                Pan_OpcionLnk.Visible = False
                btn_menuModelo = sender

            Case "LNK_M"
                lnk_menuModelo = sender

            Case "LNK_O"
                sender.LinkColor = Color.Black
                sender.Image = Nothing
        End Select
    End Sub
#End Region

#Region "//Opera_links//"
    Sub Opera_links(ByVal sender As System.Object, ByVal int_flagopr As Integer, ByVal ctl_panel As Panel)

        'En el caso que el link sea opcion

        Select Case Microsoft.VisualBasic.Right(sender.tag, 1)
            Case "."
                If int_flagopr Then
                    'en caso del evento click

                    Select Case sender.name
                        Case "btn_menu1"
                        Case "btn_menu2"
                        Case "btn_menu3"
                        Case "btn_menu4"
                        Case "btn_menu5"
                        Case "btn_menu6"
                        Case "btn_menu7"
                            'Salir
                            nti_main.Visible = False
                            Me.Close()

                        Case "lnk_menu01"
                            'Etiquetas por pedido
                            If Not ExisteForm("frm_Muestra") Then
                                Dim FrM_MDIChild As New frm_Muestra()
                                Crea_formulario(FrM_MDIChild)
                            End If


                        Case "lnk_menu02"


                        Case "lnk_menu03"
                            Dim opr_pedido As New Cls_Pedido()
                            If Not ExisteForm("Frm_Pedido") Then
                                Dim FrM_MDIChild As New frm_Pedido()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu04"
                            If Not ExisteForm("Frm_Agenda") Then
                                Dim FrM_MDIChild As New Frm_Agenda

                                FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                                FrM_MDIChild.Tag = 0
                                'FrM_MDIChild.ShowDialog(Me.ParentForm)
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu05"
                            If Not ExisteFormConTag("Frm_Trabajo", "") Then
                                Dim FrM_MDIChild As New frm_Trabajo()
                                FrM_MDIChild.Tag = ""
                                Crea_formulario(FrM_MDIChild)
                            End If
                            ' Limpia_menu()

                        Case "lnk_menu58"
                            If Not ExisteForm("frm_impresora") Then
                                Call Limpia_menu()
                                Dim FrM_MDIChild As New frm_Impresora()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu06"
                            'laboratorio
                            If Not ExisteForm("frm_FiltroAreas") Then
                                Dim frm_MDIChild As New frm_FiltroAreas
                                frm_MDIChild.LabOcup = 0
                                'frm_MDIChild.Show()
                                Crea_formulario(frm_MDIChild)
                            End If

                        Case "lnk_menu08"
                            'ocupacional
                            If g_EsOcupacional <> 0 Then

                                If Not ExisteForm("frm_AgendaCitaMedica") Then
                                    Dim frm_MDIChild As New frm_AgendaCitaMedica
                                    frm_MDIChild.LabOcup = 1
                                    Crea_formulario(frm_MDIChild)
                                End If
                            Else
                                opr_pedido.VisualizaMensaje("Modulo no autorizado, favor consulte con el administrador del sistema", 400)
                            End If



                        Case "lnk_menu07"

                            If Not ExisteForm("frm_VisResul") Then
                                Dim FrM_MDIChild As New frm_VisResul()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        
                        Case "lnk_menu09"
                            'Estadisticas - Reportes
                            If Not ExisteForm("frm_Rpt_PruebasFecha") Then
                                Dim FrM_MDIChild As New frm_Rpt_PruebasFecha()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu10"
                            If Not ExisteForm("frm_laboratorio") Then
                                Dim FrM_MDIChild As New frm_laboratorio()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu11"
                            'Bonificaciones
                            If Not ExisteForm("frm_Bonificacion") Then
                                Dim FrM_MDIChild As New frm_Bonificacion()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu12"
                            If Not ExisteForm("frm_Convenios") Then
                                Dim FrM_MDIChild As New frm_Convenios()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu13"
                            'CONVENIOS/ Lista de Precios


                        Case "lnk_menu14"
                            'Admin antibioticos
                            If Not ExisteForm("frm_Antibioticos") Then
                                Dim FrM_MDIChild As New frm_Antibioticos()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu15"
                            'Estructura cultivos
                            If Not ExisteForm("frm_EstCultivos") Then
                                Dim FrM_MDIChild As New frm_EstCultivos()
                                Crea_formulario(FrM_MDIChild)
                            End If


                        Case "lnk_menu28"
                            'Estructura autocompletado
                            If Not ExisteForm("frm_Autocompletar") Then
                                Dim FrM_MDIChild As New frm_Autocompletar()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu16"
                            If Not ExisteForm("Frm_Permisos") Then
                                Dim FrM_MDIChild As New frm_Permisos()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu17"
                            'INVITADO
                            If Not ExisteForm("frm_invitados") Then
                                Dim FrM_MDIChild As New frm_Invitados()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu20"
                            If Not ExisteForm("frm_Pswd") Then
                                Dim FrM_MDIChild As New frm_Pswd()
                                Crea_formulario(FrM_MDIChild)
                            End If
                        Case "lnk_menu21"
                            If Not ExisteForm("frm_Areas") Then
                                Dim FrM_MDIChild As New frm_Areas()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu22"
                            If Not ExisteForm("frm_Ciudad") Then
                                Dim FrM_MDIChild As New frm_Ciudad()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu23"
                            If Not ExisteForm("Frm_Medico") Then
                                Dim FrM_MDIChild As New Frm_medico()
                                Crea_formulario(FrM_MDIChild)
                            End If


                        Case "lnk_menu24"
                            If Not ExisteForm("Frm_Paciente") Then
                                Dim FrM_MDIChild As New frm_Paciente()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu25"
                            If Not ExisteForm("frm_Perfil") Then
                                Dim FrM_MDIChild As New frm_Perfil()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu26"
                            If Not ExisteForm("frm_TipoTest") Then
                                Dim FrM_MDIChild As New frm_TipoTest()
                                Crea_formulario(FrM_MDIChild)
                            End If


                        Case "lnk_menu27"
                            'SERVICIOS
                            If Not ExisteForm("frm_Servicio") Then
                                Dim FrM_MDIChild As New frm_servicio()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu32"
                            'INVENTARIO
                            If Not ExisteForm("Frm_i_Movimientos") Then
                                Dim FrM_MDIChild As New Frm_i_Movimientos()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu33"
                            If Not ExisteForm("frm_i_Productos") Then
                                Dim FrM_MDIChild As New frm_i_Productos()
                                Crea_formulario(FrM_MDIChild)
                            End If
                        Case "lnk_menu34"
                            If Not ExisteForm("frm_i_Proveedor") Then
                                Dim FrM_MDIChild As New frm_i_Proveedor()
                                Crea_formulario(FrM_MDIChild)
                            End If
                        Case "lnk_menu35"
                            If Not ExisteForm("frm_i_Stock") Then
                                Dim FrM_MDIChild As New frm_i_Stock()
                                Crea_formulario(FrM_MDIChild)
                            End If
                        Case "lnk_menu36"
                            If Not ExisteForm("frm_i_Bodega") Then
                                Dim FrM_MDIChild As New frm_i_Bodega()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu37"
                            If Not ExisteForm("frm_Kardex") Then
                                Dim FrM_MDIChild As New frm_Kardex()
                                Crea_formulario(FrM_MDIChild)
                            End If



                        Case "lnk_menu29"
                            'PRE ORDEN
                            If Not ExisteForm("frm_Ingreso_Aspirantes") Then
                                Dim FrM_MDIChild As New Ingreso_Aspirantes()
                                Crea_formulario(FrM_MDIChild)
                            End If


                        Case "lnk_menu30"
                            'SECUENCIAS
                            If Not ExisteForm("frm_Secuencias") Then
                                'Dim FrM_MDIChild As New frm_Secuencias()
                                'Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_menu31"
                            'SECUENCIAS
                            If Not ExisteForm("frm_Importar") Then
                                Dim FrM_MDIChild As New frm_Importar()
                                Crea_formulario(FrM_MDIChild)
                            End If


                            'ayuda
                            'Dim hlp_aux As Help
                            'hlp_aux.ShowHelp(lnk_ayuda, Environment.CurrentDirectory & "/ayudas/Ayuda.chm")

                            '*******************************************

                        Case "lnk_opc01"
                            'anular factura
                            If Not ExisteForm("Frm_Factura") Then
                                Dim FrM_MDIChild As New Frm_Factura()
                                FrM_MDIChild.Tag = "5"
                                Crea_formulario(FrM_MDIChild)
                            End If


                        Case "lnk_opc02"
                            'modificacion
                            If Not ExisteForm("Frm_Factura") Then
                                Dim FrM_MDIChild As New Frm_Factura()
                                FrM_MDIChild.Tag = "2"
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc03"
                            'Reportes de facturacion
                            If Not ExisteForm("frm_Rpt_Factura") Then
                                'Call Limpia_menu()
                                Dim FrM_MDIChild As New frm_Rpt_Factura()
                                FrM_MDIChild.frm_refer_main = Me
                                FrM_MDIChild.ShowDialog(Me)
                            End If


                            'Case "lnk_opc04"
                            '    'abonos
                            '   If Not ExisteForm("Frm_Factura") Then
                            'Dim FrM_MDIChild As New Frm_Factura()
                            'FrM_MDIChild.Tag = "4"
                            'Crea_formulario(FrM_MDIChild)
                            'End If

                        Case "lnk_opc05"
                            'generales
                            If Not ExisteForm("frm_FacturaPedido") Then
                                Dim FrM_MDIChild As New Frm_FacturaPedido()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc06"
                            'generales
                            If Not ExisteForm("frm_TipoTest") Then
                                Dim FrM_MDIChild As New frm_TipoTest()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc07"
                            'generales
                            If Not ExisteForm("frm_Parametros") Then
                                Dim FrM_MDIChild As New frm_Parametros()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc08"
                            'generales
                            If Not ExisteForm("frm_Parametros") Then
                                Dim FrM_MDIChild As New frm_Parametros()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc09"
                            'generales
                            If Not ExisteForm("frm_Parametros") Then
                                Dim FrM_MDIChild As New frm_Parametros()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc10"
                            If Not ExisteForm("frm_RangNormal") Then
                                Dim FrM_MDIChild As New frm_RangNormal()
                                Crea_formulario(FrM_MDIChild)
                            End If


                            'INVENTARIOS
                        Case "lnk_opc11"
                            If Not ExisteForm("Frm_i_Movimientos") Then
                                Dim FrM_MDIChild As New Frm_i_Movimientos()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc12"
                            If Not ExisteForm("Frm_i_Movimientos") Then
                                Dim FrM_MDIChild As New Frm_i_Movimientos()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc13"
                            If Not ExisteForm("Frm_i_Productos") Then
                                Dim FrM_MDIChild As New frm_i_Productos()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc14"
                            If Not ExisteForm("frm_i_Proveedor") Then
                                Dim FrM_MDIChild As New frm_i_Proveedor()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc15"
                            If Not ExisteForm("frm_i_Stock") Then
                                Dim FrM_MDIChild As New frm_i_Stock()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc16"
                            If Not ExisteForm("frm_i_movReporte") Then
                                Dim FrM_MDIChild As New frm_i_movReporte()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc17"
                            If Not ExisteForm("frm_i_Bodega") Then
                                Dim FrM_MDIChild As New frm_i_Bodega()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc18"
                            If Not ExisteForm("frm_Kardex") Then
                                Dim FrM_MDIChild As New frm_Kardex()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc19"
                            If Not ExisteForm("frm_Tendencia") Then
                                Dim FrM_MDIChild As New frm_Tendencia()
                                Crea_formulario(FrM_MDIChild)
                            End If

                        Case "lnk_opc20"
                            If Not ExisteForm("frm_Preparacion") Then
                                Dim FrM_MDIChild As New frm_Preparacion()
                                Crea_formulario(FrM_MDIChild)
                            End If

                    End Select
                    Limpia_menu()
                    Exit Sub
                Else
                    'En el caso que el link sea opcion
                    Select Case Mid(sender.Name, 1, 8)
                        Case "Pan_Menu", "lnk_menu"
                            Pan_OpcionLnk.Visible = False
                        Case "Pan_Opci", "btn_menu"
                            Limpia_menu()
                    End Select

                End If

            Case Else
                'En el caso que el link sea menu
                Dim ctl As System.Windows.Forms.LinkLabel
                Dim int_top As Integer = 4
                Dim int_pos As Integer
                Dim str_tag As String

                For Each ctl In ctl_panel.Controls
                    str_tag = ""
                    If LCase(ctl.Name) Like "lnk_m*" Then
                        int_pos = InStr(ctl.Tag, ".")
                        If int_pos > 0 Then str_tag = Mid(ctl.Tag, 1, int_pos - 1)
                    Else
                        str_tag = Microsoft.VisualBasic.Left(ctl.Tag, Len(sender.tag))
                    End If

                    If LCase(ctl.Name) Like "lnk_*" And sender.tag = str_tag Then
                        ctl.Top = int_top
                        int_top = int_top + 21
                        ctl.LinkColor = Color.Black
                        If m_HtImages.ContainsKey("barraMenu1") Then
                            imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
                        Else
                            Try
                                imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
                                m_HtImages.Add("barraMenu1", imageToDraw)
                            Catch
                                Return
                            End Try
                        End If
                        ctl.Image = imageToDraw
                        ctl.Show()
                    Else
                        ctl.Hide()
                    End If
                Next
                ctl_panel.Height = int_top + 5
                ubica_panel(sender, ctl_panel)

        End Select

    End Sub
#End Region

#Region "//ubica_panel//"
    Sub ubica_panel(ByVal sender As System.Object, ByVal ctl_panel As Panel)
        'ubica los paneles de acuerdo al link posesionado
        Dim grp_marco As Graphics
        Dim pen_marco As New Pen(Color.Black, 2)
        ctl_panel.Visible = False
        ctl_panel.Visible = True

        Select Case ctl_panel.Name
            Case "Pan_OpcionLnk"
                ctl_panel.Top = Pan_MenuLnk.Top + sender.top
                ctl_panel.Left = Pan_MenuLnk.Left + Pan_MenuLnk.Width
            Case Else
                ctl_panel.Top = sender.top + 52
                ctl_panel.Left = sender.left + 5
                'ctl_panel.Left = sender.left + Pan_Menu.Width

        End Select

        grp_marco = ctl_panel.CreateGraphics

        grp_marco = ctl_panel.CreateGraphics
        grp_marco.DrawPolygon(pen_marco, New PointF() {New PointF(0, 0), _
        New PointF(ctl_panel.Width - pen_marco.Width / 2, 0), _
        New PointF(ctl_panel.Width - pen_marco.Width / 2, ctl_panel.Height - 1), _
        New PointF(0, ctl_panel.Height - 1)})

    End Sub
#End Region

#Region "Añade eventos a los controles creados"
    Sub Add_Handler_Menu()
        'Esta funci�n crea eventos para cada unos de los objetos que forman parte del menu
        'como son los paneles, botones y links, estos reciben los efectos, de esta manera al
        'momento de agregar un control solo se lo debe poner el nombre estandar y autom�ticamente
        'se le asgina los eventos.
        Dim ctl As Control
        Dim ctl_lnk As LinkLabel

        For Each ctl In Me.Pan_Menu.Controls
            If ctl.Name Like "Pan_*" Then
                AddHandler ctl.MouseEnter, AddressOf Menu_MouseEnter
                AddHandler ctl.MouseLeave, AddressOf Menu_MouseLeave
            End If
        Next

        For Each ctl In Me.Pan_Menu.Controls
            If ctl.Name Like "btn_menu*" Then
                AddHandler ctl.MouseEnter, AddressOf Menu_MouseEnter
                AddHandler ctl.MouseLeave, AddressOf Menu_MouseLeave
                AddHandler ctl.Enter, AddressOf Menu_MouseEnter
                AddHandler ctl.Leave, AddressOf Menu_MouseLeave
                AddHandler ctl.Click, AddressOf btnMenu_Click
            End If
        Next

        For Each ctl_lnk In Me.Pan_MenuLnk.Controls
            If ctl_lnk.Name Like "lnk_menu*" Then
                AddHandler ctl_lnk.MouseEnter, AddressOf Menu_MouseEnter
                AddHandler ctl_lnk.MouseLeave, AddressOf Menu_MouseLeave
                AddHandler ctl_lnk.Click, AddressOf LnkMenu_Click
                AddHandler ctl_lnk.LinkClicked, AddressOf LnkMenu_Click2
            End If
        Next

        For Each ctl_lnk In Me.Pan_OpcionLnk.Controls
            If ctl_lnk.Name Like "lnk_opc*" Then
                AddHandler ctl_lnk.MouseEnter, AddressOf Menu_MouseEnter
                AddHandler ctl_lnk.MouseLeave, AddressOf Menu_MouseLeave
                AddHandler ctl_lnk.Click, AddressOf LnkMenu_Click
                AddHandler ctl_lnk.LinkClicked, AddressOf LnkMenu_Click2
            End If
        Next

    End Sub

#End Region

#Region "Menu parte del toolbox"
    Public Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'click para el menu del formulario (context menu)
        Dim ctl As Form
        For Each ctl In Me.MdiChildren
            If ctl.Text = sender.text Then
                ctl.Activate()
                If ctl.WindowState = FormWindowState.Minimized Then
                    ctl.WindowState = FormWindowState.Normal
                End If
            End If
        Next
    End Sub
#End Region

#Region "Verica si existe un formulario activo"
    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        'funci�n que retorna true si existe el formulario creado en el MDI, false si no lo encuentra creado
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.MdiChildren
            If UCase(ctl.Name) = UCase(str_frmbusca) Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function

    Public Function ExisteFormConTag(ByVal str_frmbusca As String, ByVal tag As String) As Boolean
        'funci�n que retorna true si existe el formulario creado en el MDI, false si no lo encuentra creado
        Dim ctl As System.Windows.Forms.Form
        ExisteFormConTag = False
        For Each ctl In Me.MdiChildren
            If UCase(ctl.Name) = UCase(str_frmbusca) Then
                If ctl.Tag = tag Then
                    ExisteFormConTag = True
                    Exit Function
                End If
            End If
        Next
    End Function
#End Region

#Region "Crea Estructura del Menu"

    Sub Crea_links()
        Dim str_menu() As String
        Dim str_arreglo() As String
        Dim int_indice, int_numarreglo As Integer
        Dim ctl_lnkmenu() As LinkLabel
        int_numarreglo = 47
        ReDim Preserve str_menu(int_numarreglo)
        ReDim Preserve ctl_lnkmenu(int_numarreglo)
        'Estructura del menu "nombre del control, texto, tag, tabindex"
        '-- menu de hijos --

        str_menu(0) = "lnk_menu01, Codigo de Barras, 1.1., 0"
        str_menu(1) = "lnk_menu02, Facturacion      >, 1.2, 1"
        str_menu(2) = "lnk_menu03, Ordenes, 1.3., 2"
        str_menu(3) = "lnk_menu04, Agenda, 1.4., 3"
        str_menu(4) = "lnk_menu29, Pre Carga, 1.5., 4"
        str_menu(5) = "lnk_menu31, Importar, 1.6., 5"

        str_menu(6) = "lnk_menu05, Lista de Trabajo, 3.1., 1"
        str_menu(7) = "lnk_menu06, Validacion, 3.2., 2"
        str_menu(8) = "lnk_menu08, Consultas, 3.3., 3"
        str_menu(9) = "lnk_menu07, Entrega, 3.4., 4"

        str_menu(10) = "lnk_menu09, Reportes, 4.1., 1"

        str_menu(11) = "lnk_menu10, Laboratorio, 8.1., 1"
        str_menu(12) = "lnk_menu11, Bonificaciones, 8.2., 2"
        str_menu(13) = "lnk_menu12, Convenios, 8.3., 3"
        str_menu(14) = "lnk_menu14, Antibioticos, 8.5., 4"
        str_menu(15) = "lnk_menu15, Est. Cultivos, 8.6., 5"
        str_menu(16) = "lnk_menu28, Autocompletado, 8.7., 6"
        str_menu(17) = "lnk_menu58, Impresoras, 8.8., 7"

        str_menu(18) = "lnk_menu16, Permisos, 6.1., 1"
        str_menu(19) = "lnk_menu17, Usuarios, 6.2., 2"
        str_menu(20) = "lnk_menu20, Cambio Contraseña, 6.3., 3"

        str_menu(21) = "lnk_menu21, Areas, 5.1., 1"
        str_menu(22) = "lnk_menu22, Ciudades, 5.2., 2"
        str_menu(23) = "lnk_menu23, Medicos, 5.3., 3"
        str_menu(24) = "lnk_menu24, Pacientes, 5.4., 4"
        str_menu(25) = "lnk_menu25, Perfiles, 5.5., 5"
        str_menu(26) = "lnk_menu26, Test                           >, 5.6, 6"
        str_menu(27) = "lnk_menu27, Servicios, 5.7., 7"

        str_menu(28) = "lnk_menu32, Inventario                  >, 5.8, 1"


        '-- menu de opciones --
        str_menu(29) = "lnk_opc01, Anular, 1.2.1., 1"
        str_menu(30) = "lnk_opc03, Reportes, 1.2.3., 3"
        str_menu(31) = "lnk_opc05, Agrupar, 1.2.5., 5"

        str_menu(32) = "lnk_opc06, Test, 5.6.1., 1"
        str_menu(33) = "lnk_opc07, Unidad, 5.6.2., 2"
        str_menu(34) = "lnk_opc08, Muestra, 5.6.3., 3"
        str_menu(35) = "lnk_opc09, Recipiente, 5.6.4., 4"
        str_menu(36) = "lnk_opc10, Rangos Normalidad, 5.6.5., 5"

        str_menu(37) = "lnk_opc11, Movimientos, 5.8.1., 1"
        str_menu(38) = "lnk_opc12, Modificar, 5.8.2., 2"
        str_menu(39) = "lnk_opc13, Productos, 5.8.3., 3"
        str_menu(40) = "lnk_opc14, Proveedor, 5.8.4., 4"
        str_menu(41) = "lnk_opc15, Stock, 5.8.5., 5"
        str_menu(42) = "lnk_opc16, Reportes, 5.8.6., 6"
        str_menu(43) = "lnk_opc17, Bodega, 5.8.7., 7"
        str_menu(44) = "lnk_opc18, Kardex, 5.8.8., 8"
        str_menu(45) = "lnk_opc19, Gerencia, 5.8.9., 9"
        str_menu(46) = "lnk_opc20, Preparacion, 5.8.10., 10"

        For int_indice = 0 To int_numarreglo - 1
            ctl_lnkmenu(int_indice) = New LinkLabel()
            ctl_lnkmenu(int_indice).ActiveLinkColor = Color.Black
            ctl_lnkmenu(int_indice).BackColor = Color.Transparent
            ctl_lnkmenu(int_indice).LinkColor = Color.Black
            ctl_lnkmenu(int_indice).Font = New Font("Arial", 8.25!, FontStyle.Regular)
            ctl_lnkmenu(int_indice).Cursor = System.Windows.Forms.Cursors.Hand
            ctl_lnkmenu(int_indice).LinkBehavior = LinkBehavior.NeverUnderline
            ctl_lnkmenu(int_indice).TextAlign = ContentAlignment.MiddleLeft
            ctl_lnkmenu(int_indice).Width = 120
            ctl_lnkmenu(int_indice).Height = 22
            ctl_lnkmenu(int_indice).Top = 4
            ctl_lnkmenu(int_indice).Left = 4
            str_arreglo = Split(str_menu(int_indice), ",")
            ctl_lnkmenu(int_indice).Name = Trim(str_arreglo(0))
            ctl_lnkmenu(int_indice).Text = Trim(str_arreglo(1))
            ctl_lnkmenu(int_indice).Tag = Trim(str_arreglo(2))
            ctl_lnkmenu(int_indice).TabIndex = str_arreglo(3)
            Controls.Add(ctl_lnkmenu(int_indice))
            If int_indice < 30 Then
                Me.Pan_MenuLnk.Controls.AddRange(New System.Windows.Forms.Control() {ctl_lnkmenu(int_indice)})
            Else
                Me.Pan_OpcionLnk.Controls.AddRange(New System.Windows.Forms.Control() {ctl_lnkmenu(int_indice)})
            End If
        Next
    End Sub

#End Region

#End Region

    Public Sub limpiaGrp()
        mdiClient1.CreateGraphics.Clear(Color.Gray)
    End Sub

    Public Sub ubica(ByVal frm_Width As Integer, ByVal frm_Height As Integer, ByVal frm_Top As Integer, ByVal frm_Left As Integer)
        Dim Form_Rect As New Rectangle(frm_Left, frm_Top, frm_Width, frm_Height)
        Dim grp_marco As Graphics
        Dim pen_marco As New Pen(Color.LightGray, 2)
        limpiaGrp()
        grp_marco = mdiClient1.CreateGraphics
        grp_marco.DrawRectangle(pen_marco, Form_Rect)
    End Sub

    Public Sub escribemsj(ByVal str_msj As String)
        'escribe el texto en el panel segundo del frm_main
        'Me.sta_barmain.Panels(3).Text = str_msj
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fechai As Date = Now()
        Dim fechaf As Date = Now()
        Dim res As Integer

        fechaf = DateAdd(DateInterval.Hour, -2, fechai)
    End Sub



    Private Sub Frm_Main_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        Limpia_menu()
    End Sub


    Private Sub pbox_left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Splitter1.Hide()
    End Sub

    Private Sub btn_monitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_monitor.Click
        If sw_semaforo = 0 Then
            Splitter1.Hide()
            Panel1.Hide()
            sw_semaforo = 1
        Else
            Splitter1.Show()
            Panel1.Show()
            sw_semaforo = 0
        End If

    End Sub



    Private Sub cmb_convenio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_convenio.SelectedIndexChanged
        Call actualizaSemaforo(Dtp_ped_fecing.Value)
    End Sub

    Sub actualizaSemaforo(ByVal fecha As DateTime)
        Dim convenio As String()
        convenio = Split(cmb_convenio.Text, "/")
        opr_pedido.LeerInfoGlobal(Format(fecha, "dd/MM/yyyy"), Trim(convenio(0)), total, sin_procesar, validados, sin_validar, impresos, enviados, pacientes, pac_his)
        Num_Total.Text = Format(total, "000")
        Num_SinProcesar.Text = Format(sin_procesar, "000")
        Num_Validados.Text = Format(validados, "000")
        Num_SinValidar.Text = Format(sin_validar, "000")
        Num_Impresos.Text = Format(impresos, "000")
        Num_Enviados.Text = Format(enviados, "000")
        Num_Pacientes.Text = Format(pacientes, "000")
        Num_His.Text = Format(pac_his, "000")
    End Sub


    Sub actualizaCalendario(ByVal dp_value As DateTime)
        lbl_DiaNum.Text = Format(CInt(dp_value.Day), "00")
        lbl_DiaSemana.Text = dp_value.ToString("dddd").ToUpper()
        lbl_Mes.Text = dp_value.ToString("MMMM").ToUpper()
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Call actualizaSemaforo(Dtp_ped_fecing.Value)
        'Dtp_ped_fecing.Value = Now
        Call actualizaCalendario(Dtp_ped_fecing.Value)
    End Sub

    Private Sub btn_dtpUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dtpUp.Click
        Dtp_ped_fecing.Value = DateAdd(DateInterval.Day, +1, Dtp_ped_fecing.Value)
        actualizaCalendario(Dtp_ped_fecing.Value)
        Call actualizaSemaforo(Dtp_ped_fecing.Value)
    End Sub

    Private Sub btn_dtpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dtpDown.Click
        Dtp_ped_fecing.Value = DateAdd(DateInterval.Day, -1, Dtp_ped_fecing.Value)
        actualizaCalendario(Dtp_ped_fecing.Value)
        Call actualizaSemaforo(Dtp_ped_fecing.Value)
    End Sub
End Class