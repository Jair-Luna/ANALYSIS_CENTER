Imports System.Data

Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Data.SqlClient
Imports MessagingToolkit.QRCode.Codec
Imports System.Text.RegularExpressions


Public Class frm_VisResul
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
    Friend WithEvents lbl_Pedido As System.Windows.Forms.Label
    Friend WithEvents lbl_Paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_medico As System.Windows.Forms.Label
    Friend WithEvents grp_valResul As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FechaD As System.Windows.Forms.Label
    Friend WithEvents lbl_PacienteD As System.Windows.Forms.Label
    Friend WithEvents lbl_pedidoD As System.Windows.Forms.Label
    Friend WithEvents lbl_doctorD As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_FecNacD As System.Windows.Forms.Label
    Friend WithEvents txt_notaArea As System.Windows.Forms.TextBox
    Friend WithEvents btn_Histograma As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_despliegapdf As System.Windows.Forms.Button
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lst_pedidos As System.Windows.Forms.ListBox
    Friend WithEvents lst_remitidos As System.Windows.Forms.ListBox
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_LabId As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_ImpSobre As System.Windows.Forms.Button
    Friend WithEvents btn_ImprTodo As System.Windows.Forms.Button
    Friend WithEvents btn_ImpArea As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_ImprBloque As System.Windows.Forms.Button
    Friend WithEvents chk_multiselec As System.Windows.Forms.CheckBox
    Friend WithEvents btn_EnviaMail As System.Windows.Forms.Button
    Friend WithEvents lbl_pac_email As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents btn_EnviaMailMedico As System.Windows.Forms.Button
    Friend WithEvents lbl_100 As System.Windows.Forms.Label
    Friend WithEvents lbl_0 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_whatsapp As System.Windows.Forms.Button
    Friend WithEvents pan_hist As System.Windows.Forms.Panel
    Friend WithEvents btn_hoja As System.Windows.Forms.Button
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents dgtc_noteSecc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgrd_ResPedido As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents dgtc_notaSecc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_archivo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_Conve As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Servicio As System.Windows.Forms.Label
    Friend WithEvents chk_IncluirEnvio As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_emailServicio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_ci As System.Windows.Forms.Label
    Friend WithEvents Pic_QR As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RBCimage As System.Windows.Forms.PictureBox
    Friend WithEvents DiffimageBASO As System.Windows.Forms.PictureBox
    Friend WithEvents DiffimageLSMS As System.Windows.Forms.PictureBox
    Friend WithEvents PLTimage As System.Windows.Forms.PictureBox
    Friend WithEvents DiffimageHSMS As System.Windows.Forms.PictureBox
    Friend WithEvents WBCImage As System.Windows.Forms.PictureBox
    Friend WithEvents DiffimageLSHS As System.Windows.Forms.PictureBox
    Friend WithEvents lkl_track_Correo As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_turno As System.Windows.Forms.Label
    Friend WithEvents btn_whatsMedico As System.Windows.Forms.Button
    Friend WithEvents lbl_NameDoctor As System.Windows.Forms.Label
    ' Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btn_ImpExa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim btn_ImpHoja As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VisResul))
        Dim btn_impEmcabezado As System.Windows.Forms.Button
        Dim btn_Externo As System.Windows.Forms.Button
        Me.lbl_Pedido = New System.Windows.Forms.Label
        Me.lbl_Paciente = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.lbl_medico = New System.Windows.Forms.Label
        Me.grp_valResul = New System.Windows.Forms.GroupBox
        Me.lbl_turno = New System.Windows.Forms.Label
        Me.Pic_QR = New System.Windows.Forms.PictureBox
        Me.chk_IncluirEnvio = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_emailServicio = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_Servicio = New System.Windows.Forms.Label
        Me.lbl_pac_email = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.lbl_FecNacD = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_PacienteD = New System.Windows.Forms.Label
        Me.lbl_doctorD = New System.Windows.Forms.Label
        Me.lbl_FechaD = New System.Windows.Forms.Label
        Me.lbl_pedidoD = New System.Windows.Forms.Label
        Me.lbl_LabId = New System.Windows.Forms.Label
        Me.txt_notaArea = New System.Windows.Forms.TextBox
        Me.btn_Histograma = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btn_despliegapdf = New System.Windows.Forms.Button
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.lst_pedidos = New System.Windows.Forms.ListBox
        Me.lst_remitidos = New System.Windows.Forms.ListBox
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.btn_ImpSobre = New System.Windows.Forms.Button
        Me.btn_ImprTodo = New System.Windows.Forms.Button
        Me.btn_ImpArea = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_ImprBloque = New System.Windows.Forms.Button
        Me.chk_multiselec = New System.Windows.Forms.CheckBox
        Me.btn_EnviaMail = New System.Windows.Forms.Button
        Me.btn_EnviaMailMedico = New System.Windows.Forms.Button
        Me.lbl_100 = New System.Windows.Forms.Label
        Me.lbl_0 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.btn_ImpExa = New System.Windows.Forms.Button
        Me.btn_whatsapp = New System.Windows.Forms.Button
        Me.pan_hist = New System.Windows.Forms.Panel
        Me.DiffimageHSMS = New System.Windows.Forms.PictureBox
        Me.WBCImage = New System.Windows.Forms.PictureBox
        Me.DiffimageLSHS = New System.Windows.Forms.PictureBox
        Me.RBCimage = New System.Windows.Forms.PictureBox
        Me.DiffimageBASO = New System.Windows.Forms.PictureBox
        Me.DiffimageLSMS = New System.Windows.Forms.PictureBox
        Me.PLTimage = New System.Windows.Forms.PictureBox
        Me.btn_hoja = New System.Windows.Forms.Button
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_noteSecc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn
        Me.dgrd_ResPedido = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.dgtc_notaSecc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_archivo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_Conve = New System.Windows.Forms.ComboBox
        Me.lbl_ci = New System.Windows.Forms.Label
        Me.lkl_track_Correo = New System.Windows.Forms.LinkLabel
        Me.btn_whatsMedico = New System.Windows.Forms.Button
        Me.lbl_NameDoctor = New System.Windows.Forms.Label
        btn_ImpHoja = New System.Windows.Forms.Button
        btn_impEmcabezado = New System.Windows.Forms.Button
        btn_Externo = New System.Windows.Forms.Button
        Me.grp_valResul.SuspendLayout()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.pan_hist.SuspendLayout()
        CType(Me.DiffimageHSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WBCImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiffimageLSHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBCimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiffimageBASO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiffimageLSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_ResPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ImpHoja
        '
        btn_ImpHoja.BackColor = System.Drawing.Color.White
        btn_ImpHoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_ImpHoja.Image = CType(resources.GetObject("btn_ImpHoja.Image"), System.Drawing.Image)
        btn_ImpHoja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        btn_ImpHoja.Location = New System.Drawing.Point(329, 35)
        btn_ImpHoja.Name = "btn_ImpHoja"
        btn_ImpHoja.Size = New System.Drawing.Size(85, 24)
        btn_ImpHoja.TabIndex = 186
        btn_ImpHoja.Text = "CARNET"
        btn_ImpHoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        btn_ImpHoja.UseVisualStyleBackColor = False
        AddHandler btn_ImpHoja.Click, AddressOf Me.btn_ImpHoja_Click
        '
        'btn_impEmcabezado
        '
        btn_impEmcabezado.BackColor = System.Drawing.Color.White
        btn_impEmcabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_impEmcabezado.Image = CType(resources.GetObject("btn_impEmcabezado.Image"), System.Drawing.Image)
        btn_impEmcabezado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        btn_impEmcabezado.Location = New System.Drawing.Point(329, 57)
        btn_impEmcabezado.Name = "btn_impEmcabezado"
        btn_impEmcabezado.Size = New System.Drawing.Size(85, 24)
        btn_impEmcabezado.TabIndex = 194
        btn_impEmcabezado.Text = "     HOJA"
        btn_impEmcabezado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        btn_impEmcabezado.UseVisualStyleBackColor = False
        AddHandler btn_impEmcabezado.Click, AddressOf Me.btn_impEmcabezado_Click
        '
        'btn_Externo
        '
        btn_Externo.BackColor = System.Drawing.Color.White
        btn_Externo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_Externo.Image = CType(resources.GetObject("btn_Externo.Image"), System.Drawing.Image)
        btn_Externo.Location = New System.Drawing.Point(918, 35)
        btn_Externo.Name = "btn_Externo"
        btn_Externo.Size = New System.Drawing.Size(68, 46)
        btn_Externo.TabIndex = 195
        btn_Externo.Text = "A5"
        btn_Externo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        btn_Externo.UseVisualStyleBackColor = False
        btn_Externo.Visible = False
        AddHandler btn_Externo.Click, AddressOf Me.btn_Externo_Click
        '
        'lbl_Pedido
        '
        Me.lbl_Pedido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pedido.ForeColor = System.Drawing.Color.Black
        Me.lbl_Pedido.Location = New System.Drawing.Point(650, 129)
        Me.lbl_Pedido.Name = "lbl_Pedido"
        Me.lbl_Pedido.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Pedido.TabIndex = 26
        Me.lbl_Pedido.Text = "Pedido:"
        Me.lbl_Pedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Pedido.Visible = False
        '
        'lbl_Paciente
        '
        Me.lbl_Paciente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Paciente.ForeColor = System.Drawing.Color.Black
        Me.lbl_Paciente.Location = New System.Drawing.Point(227, 16)
        Me.lbl_Paciente.Name = "lbl_Paciente"
        Me.lbl_Paciente.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Paciente.TabIndex = 27
        Me.lbl_Paciente.Text = "Paciente:"
        Me.lbl_Paciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecha.Location = New System.Drawing.Point(661, 152)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(56, 16)
        Me.lbl_fecha.TabIndex = 28
        Me.lbl_fecha.Text = "Fecha:"
        Me.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_medico
        '
        Me.lbl_medico.BackColor = System.Drawing.Color.Transparent
        Me.lbl_medico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_medico.ForeColor = System.Drawing.Color.Black
        Me.lbl_medico.Location = New System.Drawing.Point(626, 91)
        Me.lbl_medico.Name = "lbl_medico"
        Me.lbl_medico.Size = New System.Drawing.Size(56, 16)
        Me.lbl_medico.TabIndex = 29
        Me.lbl_medico.Text = "Medico:"
        Me.lbl_medico.Visible = False
        '
        'grp_valResul
        '
        Me.grp_valResul.BackColor = System.Drawing.Color.Transparent
        Me.grp_valResul.Controls.Add(Me.lbl_turno)
        Me.grp_valResul.Controls.Add(Me.Pic_QR)
        Me.grp_valResul.Controls.Add(Me.chk_IncluirEnvio)
        Me.grp_valResul.Controls.Add(Me.Label1)
        Me.grp_valResul.Controls.Add(Me.lbl_emailServicio)
        Me.grp_valResul.Controls.Add(Me.Label3)
        Me.grp_valResul.Controls.Add(Me.lbl_Servicio)
        Me.grp_valResul.Controls.Add(Me.lbl_pac_email)
        Me.grp_valResul.Controls.Add(Me.lbl_email)
        Me.grp_valResul.Controls.Add(Me.PictureBox6)
        Me.grp_valResul.Controls.Add(Me.lbl_FecNacD)
        Me.grp_valResul.Controls.Add(Me.Label2)
        Me.grp_valResul.Controls.Add(Me.lbl_PacienteD)
        Me.grp_valResul.Controls.Add(Me.lbl_Paciente)
        Me.grp_valResul.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_valResul.ForeColor = System.Drawing.Color.Navy
        Me.grp_valResul.Location = New System.Drawing.Point(9, 81)
        Me.grp_valResul.Name = "grp_valResul"
        Me.grp_valResul.Size = New System.Drawing.Size(610, 130)
        Me.grp_valResul.TabIndex = 0
        Me.grp_valResul.TabStop = False
        '
        'lbl_turno
        '
        Me.lbl_turno.BackColor = System.Drawing.Color.White
        Me.lbl_turno.Font = New System.Drawing.Font("C39HrP24DhTt", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_turno.ForeColor = System.Drawing.Color.Black
        Me.lbl_turno.Location = New System.Drawing.Point(70, 19)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(146, 75)
        Me.lbl_turno.TabIndex = 192
        Me.lbl_turno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_QR
        '
        Me.Pic_QR.BackColor = System.Drawing.Color.Transparent
        Me.Pic_QR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_QR.Location = New System.Drawing.Point(538, 34)
        Me.Pic_QR.Name = "Pic_QR"
        Me.Pic_QR.Size = New System.Drawing.Size(65, 64)
        Me.Pic_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_QR.TabIndex = 191
        Me.Pic_QR.TabStop = False
        Me.Pic_QR.Visible = False
        '
        'chk_IncluirEnvio
        '
        Me.chk_IncluirEnvio.AutoSize = True
        Me.chk_IncluirEnvio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_IncluirEnvio.ForeColor = System.Drawing.Color.White
        Me.chk_IncluirEnvio.Location = New System.Drawing.Point(12, 106)
        Me.chk_IncluirEnvio.Name = "chk_IncluirEnvio"
        Me.chk_IncluirEnvio.Size = New System.Drawing.Size(179, 17)
        Me.chk_IncluirEnvio.TabIndex = 46
        Me.chk_IncluirEnvio.Text = "Incluir direccion para envio"
        Me.chk_IncluirEnvio.UseVisualStyleBackColor = True
        Me.chk_IncluirEnvio.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(188, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Email Servicio:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'lbl_emailServicio
        '
        Me.lbl_emailServicio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emailServicio.ForeColor = System.Drawing.Color.White
        Me.lbl_emailServicio.Location = New System.Drawing.Point(291, 105)
        Me.lbl_emailServicio.Name = "lbl_emailServicio"
        Me.lbl_emailServicio.Size = New System.Drawing.Size(308, 18)
        Me.lbl_emailServicio.TabIndex = 47
        Me.lbl_emailServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(226, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Servicio:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Servicio
        '
        Me.lbl_Servicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Servicio.ForeColor = System.Drawing.Color.White
        Me.lbl_Servicio.Location = New System.Drawing.Point(293, 86)
        Me.lbl_Servicio.Name = "lbl_Servicio"
        Me.lbl_Servicio.Size = New System.Drawing.Size(306, 18)
        Me.lbl_Servicio.TabIndex = 44
        Me.lbl_Servicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pac_email
        '
        Me.lbl_pac_email.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pac_email.ForeColor = System.Drawing.Color.White
        Me.lbl_pac_email.Location = New System.Drawing.Point(292, 64)
        Me.lbl_pac_email.Name = "lbl_pac_email"
        Me.lbl_pac_email.Size = New System.Drawing.Size(312, 17)
        Me.lbl_pac_email.TabIndex = 43
        '
        'lbl_email
        '
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.Black
        Me.lbl_email.Location = New System.Drawing.Point(227, 62)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(56, 16)
        Me.lbl_email.TabIndex = 42
        Me.lbl_email.Text = "Email:"
        Me.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(58, 62)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 40
        Me.PictureBox6.TabStop = False
        '
        'lbl_FecNacD
        '
        Me.lbl_FecNacD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FecNacD.ForeColor = System.Drawing.Color.White
        Me.lbl_FecNacD.Location = New System.Drawing.Point(292, 38)
        Me.lbl_FecNacD.Name = "lbl_FecNacD"
        Me.lbl_FecNacD.Size = New System.Drawing.Size(120, 16)
        Me.lbl_FecNacD.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(227, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Edad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_PacienteD
        '
        Me.lbl_PacienteD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PacienteD.ForeColor = System.Drawing.Color.White
        Me.lbl_PacienteD.Location = New System.Drawing.Point(292, 16)
        Me.lbl_PacienteD.Name = "lbl_PacienteD"
        Me.lbl_PacienteD.Size = New System.Drawing.Size(306, 16)
        Me.lbl_PacienteD.TabIndex = 31
        '
        'lbl_doctorD
        '
        Me.lbl_doctorD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doctorD.ForeColor = System.Drawing.Color.Navy
        Me.lbl_doctorD.Location = New System.Drawing.Point(679, 89)
        Me.lbl_doctorD.Name = "lbl_doctorD"
        Me.lbl_doctorD.Size = New System.Drawing.Size(205, 16)
        Me.lbl_doctorD.TabIndex = 33
        Me.lbl_doctorD.Visible = False
        '
        'lbl_FechaD
        '
        Me.lbl_FechaD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaD.ForeColor = System.Drawing.Color.White
        Me.lbl_FechaD.Location = New System.Drawing.Point(707, 130)
        Me.lbl_FechaD.Name = "lbl_FechaD"
        Me.lbl_FechaD.Size = New System.Drawing.Size(114, 16)
        Me.lbl_FechaD.TabIndex = 32
        '
        'lbl_pedidoD
        '
        Me.lbl_pedidoD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedidoD.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pedidoD.Location = New System.Drawing.Point(726, 151)
        Me.lbl_pedidoD.Name = "lbl_pedidoD"
        Me.lbl_pedidoD.Size = New System.Drawing.Size(64, 16)
        Me.lbl_pedidoD.TabIndex = 30
        Me.lbl_pedidoD.Visible = False
        '
        'lbl_LabId
        '
        Me.lbl_LabId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LabId.ForeColor = System.Drawing.Color.Navy
        Me.lbl_LabId.Location = New System.Drawing.Point(604, 53)
        Me.lbl_LabId.Name = "lbl_LabId"
        Me.lbl_LabId.Size = New System.Drawing.Size(64, 16)
        Me.lbl_LabId.TabIndex = 41
        '
        'txt_notaArea
        '
        Me.txt_notaArea.BackColor = System.Drawing.Color.LightGray
        Me.txt_notaArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_notaArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notaArea.Location = New System.Drawing.Point(625, 87)
        Me.txt_notaArea.MaxLength = 15000
        Me.txt_notaArea.Multiline = True
        Me.txt_notaArea.Name = "txt_notaArea"
        Me.txt_notaArea.ReadOnly = True
        Me.txt_notaArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notaArea.Size = New System.Drawing.Size(302, 126)
        Me.txt_notaArea.TabIndex = 3
        '
        'btn_Histograma
        '
        Me.btn_Histograma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Histograma.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Histograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Histograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Histograma.ForeColor = System.Drawing.Color.Black
        Me.btn_Histograma.Image = CType(resources.GetObject("btn_Histograma.Image"), System.Drawing.Image)
        Me.btn_Histograma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Histograma.Location = New System.Drawing.Point(640, 157)
        Me.btn_Histograma.Name = "btn_Histograma"
        Me.btn_Histograma.Size = New System.Drawing.Size(80, 24)
        Me.btn_Histograma.TabIndex = 4
        Me.btn_Histograma.Text = "Histogr."
        Me.btn_Histograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(1235, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(18, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(209, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "ENTREGA DE RESULTADOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_despliegapdf
        '
        Me.btn_despliegapdf.BackColor = System.Drawing.SystemColors.Control
        Me.btn_despliegapdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_despliegapdf.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_despliegapdf.Enabled = False
        Me.btn_despliegapdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_despliegapdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_despliegapdf.ForeColor = System.Drawing.Color.Black
        Me.btn_despliegapdf.Image = CType(resources.GetObject("btn_despliegapdf.Image"), System.Drawing.Image)
        Me.btn_despliegapdf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_despliegapdf.Location = New System.Drawing.Point(695, 273)
        Me.btn_despliegapdf.Name = "btn_despliegapdf"
        Me.btn_despliegapdf.Size = New System.Drawing.Size(88, 24)
        Me.btn_despliegapdf.TabIndex = 97
        Me.btn_despliegapdf.Text = "Remitidos"
        Me.btn_despliegapdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_despliegapdf.UseVisualStyleBackColor = False
        Me.btn_despliegapdf.Visible = False
        '
        'dtp_ff
        '
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ff.Location = New System.Drawing.Point(1141, 50)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(80, 21)
        Me.dtp_ff.TabIndex = 168
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.White
        Me.lbl_hasta.Location = New System.Drawing.Point(1105, 56)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(46, 16)
        Me.lbl_hasta.TabIndex = 164
        Me.lbl_hasta.Text = "Hasta:"
        '
        'dtp_fi
        '
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fi.Location = New System.Drawing.Point(1023, 50)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(80, 21)
        Me.dtp_fi.TabIndex = 167
        '
        'lst_pedidos
        '
        Me.lst_pedidos.FormattingEnabled = True
        Me.lst_pedidos.Location = New System.Drawing.Point(938, 97)
        Me.lst_pedidos.Name = "lst_pedidos"
        Me.lst_pedidos.Size = New System.Drawing.Size(283, 459)
        Me.lst_pedidos.TabIndex = 162
        '
        'lst_remitidos
        '
        Me.lst_remitidos.FormattingEnabled = True
        Me.lst_remitidos.Location = New System.Drawing.Point(938, 488)
        Me.lst_remitidos.Name = "lst_remitidos"
        Me.lst_remitidos.Size = New System.Drawing.Size(269, 69)
        Me.lst_remitidos.TabIndex = 161
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.White
        Me.lbl_desde.Location = New System.Drawing.Point(983, 57)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(45, 16)
        Me.lbl_desde.TabIndex = 163
        Me.lbl_desde.Text = "Desde:"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.White
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cerrar.Location = New System.Drawing.Point(813, 35)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(87, 46)
        Me.btn_cerrar.TabIndex = 172
        Me.btn_cerrar.Text = "CERRAR"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'btn_ImpSobre
        '
        Me.btn_ImpSobre.BackColor = System.Drawing.Color.White
        Me.btn_ImpSobre.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpSobre.Image = CType(resources.GetObject("btn_ImpSobre.Image"), System.Drawing.Image)
        Me.btn_ImpSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpSobre.Location = New System.Drawing.Point(413, 35)
        Me.btn_ImpSobre.Name = "btn_ImpSobre"
        Me.btn_ImpSobre.Size = New System.Drawing.Size(81, 46)
        Me.btn_ImpSobre.TabIndex = 173
        Me.btn_ImpSobre.Text = "SOBRE"
        Me.btn_ImpSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpSobre.UseVisualStyleBackColor = False
        '
        'btn_ImprTodo
        '
        Me.btn_ImprTodo.BackColor = System.Drawing.Color.White
        Me.btn_ImprTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImprTodo.Image = CType(resources.GetObject("btn_ImprTodo.Image"), System.Drawing.Image)
        Me.btn_ImprTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImprTodo.Location = New System.Drawing.Point(169, 35)
        Me.btn_ImprTodo.Name = "btn_ImprTodo"
        Me.btn_ImprTodo.Size = New System.Drawing.Size(78, 46)
        Me.btn_ImprTodo.TabIndex = 174
        Me.btn_ImprTodo.Text = "CONT"
        Me.btn_ImprTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprTodo.UseVisualStyleBackColor = False
        '
        'btn_ImpArea
        '
        Me.btn_ImpArea.BackColor = System.Drawing.Color.White
        Me.btn_ImpArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpArea.Image = CType(resources.GetObject("btn_ImpArea.Image"), System.Drawing.Image)
        Me.btn_ImpArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpArea.Location = New System.Drawing.Point(93, 35)
        Me.btn_ImpArea.Name = "btn_ImpArea"
        Me.btn_ImpArea.Size = New System.Drawing.Size(78, 46)
        Me.btn_ImpArea.TabIndex = 175
        Me.btn_ImpArea.Text = "AREA"
        Me.btn_ImpArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpArea.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.White
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(7, 35)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(88, 46)
        Me.btn_buscar.TabIndex = 176
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btn_ImprBloque
        '
        Me.btn_ImprBloque.BackColor = System.Drawing.Color.White
        Me.btn_ImprBloque.Enabled = False
        Me.btn_ImprBloque.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImprBloque.Image = CType(resources.GetObject("btn_ImprBloque.Image"), System.Drawing.Image)
        Me.btn_ImprBloque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImprBloque.Location = New System.Drawing.Point(629, 35)
        Me.btn_ImprBloque.Name = "btn_ImprBloque"
        Me.btn_ImprBloque.Size = New System.Drawing.Size(95, 46)
        Me.btn_ImprBloque.TabIndex = 177
        Me.btn_ImprBloque.Text = "PDF"
        Me.btn_ImprBloque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprBloque.UseVisualStyleBackColor = False
        '
        'chk_multiselec
        '
        Me.chk_multiselec.AutoSize = True
        Me.chk_multiselec.Location = New System.Drawing.Point(1110, 30)
        Me.chk_multiselec.Name = "chk_multiselec"
        Me.chk_multiselec.Size = New System.Drawing.Size(115, 17)
        Me.chk_multiselec.TabIndex = 178
        Me.chk_multiselec.Text = "MULTI SELECCION"
        Me.chk_multiselec.UseVisualStyleBackColor = True
        '
        'btn_EnviaMail
        '
        Me.btn_EnviaMail.BackColor = System.Drawing.Color.White
        Me.btn_EnviaMail.Enabled = False
        Me.btn_EnviaMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EnviaMail.Image = CType(resources.GetObject("btn_EnviaMail.Image"), System.Drawing.Image)
        Me.btn_EnviaMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_EnviaMail.Location = New System.Drawing.Point(723, 35)
        Me.btn_EnviaMail.Name = "btn_EnviaMail"
        Me.btn_EnviaMail.Size = New System.Drawing.Size(91, 46)
        Me.btn_EnviaMail.TabIndex = 179
        Me.btn_EnviaMail.Text = "CORREO"
        Me.btn_EnviaMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EnviaMail.UseVisualStyleBackColor = False
        '
        'btn_EnviaMailMedico
        '
        Me.btn_EnviaMailMedico.BackColor = System.Drawing.Color.White
        Me.btn_EnviaMailMedico.Enabled = False
        Me.btn_EnviaMailMedico.Image = CType(resources.GetObject("btn_EnviaMailMedico.Image"), System.Drawing.Image)
        Me.btn_EnviaMailMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_EnviaMailMedico.Location = New System.Drawing.Point(729, 143)
        Me.btn_EnviaMailMedico.Name = "btn_EnviaMailMedico"
        Me.btn_EnviaMailMedico.Size = New System.Drawing.Size(88, 46)
        Me.btn_EnviaMailMedico.TabIndex = 180
        Me.btn_EnviaMailMedico.Text = "MEDICO"
        Me.btn_EnviaMailMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EnviaMailMedico.UseVisualStyleBackColor = False
        Me.btn_EnviaMailMedico.Visible = False
        '
        'lbl_100
        '
        Me.lbl_100.AutoSize = True
        Me.lbl_100.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_100.ForeColor = System.Drawing.Color.White
        Me.lbl_100.Location = New System.Drawing.Point(798, 198)
        Me.lbl_100.Name = "lbl_100"
        Me.lbl_100.Size = New System.Drawing.Size(36, 13)
        Me.lbl_100.TabIndex = 183
        Me.lbl_100.Text = "100%"
        '
        'lbl_0
        '
        Me.lbl_0.AutoSize = True
        Me.lbl_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_0.ForeColor = System.Drawing.Color.White
        Me.lbl_0.Location = New System.Drawing.Point(632, 198)
        Me.lbl_0.Name = "lbl_0"
        Me.lbl_0.Size = New System.Drawing.Size(24, 13)
        Me.lbl_0.TabIndex = 182
        Me.lbl_0.Text = "0%"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ProgressBar1.Location = New System.Drawing.Point(661, 198)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(133, 14)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 181
        '
        'btn_ImpExa
        '
        Me.btn_ImpExa.BackColor = System.Drawing.Color.White
        Me.btn_ImpExa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpExa.Image = CType(resources.GetObject("btn_ImpExa.Image"), System.Drawing.Image)
        Me.btn_ImpExa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpExa.Location = New System.Drawing.Point(245, 35)
        Me.btn_ImpExa.Name = "btn_ImpExa"
        Me.btn_ImpExa.Size = New System.Drawing.Size(85, 46)
        Me.btn_ImpExa.TabIndex = 184
        Me.btn_ImpExa.Text = "EXAMEN"
        Me.btn_ImpExa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpExa.UseVisualStyleBackColor = False
        '
        'btn_whatsapp
        '
        Me.btn_whatsapp.BackColor = System.Drawing.Color.White
        Me.btn_whatsapp.Enabled = False
        Me.btn_whatsapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_whatsapp.Image = CType(resources.GetObject("btn_whatsapp.Image"), System.Drawing.Image)
        Me.btn_whatsapp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_whatsapp.Location = New System.Drawing.Point(493, 35)
        Me.btn_whatsapp.Name = "btn_whatsapp"
        Me.btn_whatsapp.Size = New System.Drawing.Size(69, 46)
        Me.btn_whatsapp.TabIndex = 187
        Me.btn_whatsapp.Text = "PAC"
        Me.btn_whatsapp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_whatsapp.UseVisualStyleBackColor = False
        '
        'pan_hist
        '
        Me.pan_hist.Controls.Add(Me.DiffimageHSMS)
        Me.pan_hist.Controls.Add(Me.WBCImage)
        Me.pan_hist.Controls.Add(Me.DiffimageLSHS)
        Me.pan_hist.Controls.Add(Me.RBCimage)
        Me.pan_hist.Controls.Add(Me.DiffimageBASO)
        Me.pan_hist.Controls.Add(Me.DiffimageLSMS)
        Me.pan_hist.Controls.Add(Me.PLTimage)
        Me.pan_hist.Controls.Add(Me.lbl_LabId)
        Me.pan_hist.Controls.Add(Me.btn_hoja)
        Me.pan_hist.Location = New System.Drawing.Point(65, 228)
        Me.pan_hist.Name = "pan_hist"
        Me.pan_hist.Size = New System.Drawing.Size(743, 251)
        Me.pan_hist.TabIndex = 188
        '
        'DiffimageHSMS
        '
        Me.DiffimageHSMS.BackColor = System.Drawing.Color.White
        Me.DiffimageHSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageHSMS.Location = New System.Drawing.Point(488, 127)
        Me.DiffimageHSMS.Name = "DiffimageHSMS"
        Me.DiffimageHSMS.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageHSMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageHSMS.TabIndex = 197
        Me.DiffimageHSMS.TabStop = False
        Me.DiffimageHSMS.Visible = False
        '
        'WBCImage
        '
        Me.WBCImage.BackColor = System.Drawing.Color.White
        Me.WBCImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WBCImage.Location = New System.Drawing.Point(341, 14)
        Me.WBCImage.Name = "WBCImage"
        Me.WBCImage.Size = New System.Drawing.Size(122, 109)
        Me.WBCImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WBCImage.TabIndex = 195
        Me.WBCImage.TabStop = False
        '
        'DiffimageLSHS
        '
        Me.DiffimageLSHS.BackColor = System.Drawing.Color.White
        Me.DiffimageLSHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageLSHS.Location = New System.Drawing.Point(488, 14)
        Me.DiffimageLSHS.Name = "DiffimageLSHS"
        Me.DiffimageLSHS.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageLSHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageLSHS.TabIndex = 196
        Me.DiffimageLSHS.TabStop = False
        Me.DiffimageLSHS.Visible = False
        '
        'RBCimage
        '
        Me.RBCimage.BackColor = System.Drawing.Color.White
        Me.RBCimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RBCimage.Location = New System.Drawing.Point(56, 127)
        Me.RBCimage.Name = "RBCimage"
        Me.RBCimage.Size = New System.Drawing.Size(122, 109)
        Me.RBCimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RBCimage.TabIndex = 194
        Me.RBCimage.TabStop = False
        '
        'DiffimageBASO
        '
        Me.DiffimageBASO.BackColor = System.Drawing.Color.White
        Me.DiffimageBASO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageBASO.Location = New System.Drawing.Point(203, 127)
        Me.DiffimageBASO.Name = "DiffimageBASO"
        Me.DiffimageBASO.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageBASO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageBASO.TabIndex = 193
        Me.DiffimageBASO.TabStop = False
        Me.DiffimageBASO.Visible = False
        '
        'DiffimageLSMS
        '
        Me.DiffimageLSMS.BackColor = System.Drawing.Color.White
        Me.DiffimageLSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageLSMS.Location = New System.Drawing.Point(203, 14)
        Me.DiffimageLSMS.Name = "DiffimageLSMS"
        Me.DiffimageLSMS.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageLSMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageLSMS.TabIndex = 192
        Me.DiffimageLSMS.TabStop = False
        Me.DiffimageLSMS.Visible = False
        '
        'PLTimage
        '
        Me.PLTimage.BackColor = System.Drawing.Color.White
        Me.PLTimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLTimage.Location = New System.Drawing.Point(56, 14)
        Me.PLTimage.Name = "PLTimage"
        Me.PLTimage.Size = New System.Drawing.Size(122, 109)
        Me.PLTimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PLTimage.TabIndex = 191
        Me.PLTimage.TabStop = False
        '
        'btn_hoja
        '
        Me.btn_hoja.BackColor = System.Drawing.Color.White
        Me.btn_hoja.Image = CType(resources.GetObject("btn_hoja.Image"), System.Drawing.Image)
        Me.btn_hoja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hoja.Location = New System.Drawing.Point(659, 45)
        Me.btn_hoja.Name = "btn_hoja"
        Me.btn_hoja.Size = New System.Drawing.Size(81, 46)
        Me.btn_hoja.TabIndex = 190
        Me.btn_hoja.Text = "HOJA"
        Me.btn_hoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hoja.UseVisualStyleBackColor = False
        Me.btn_hoja.Visible = False
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "PADRE"
        Me.DataGridTextBoxColumn12.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "PDF"
        Me.DataGridTextBoxColumn24.MappingName = "rem_file"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.ReadOnly = True
        Me.DataGridTextBoxColumn24.Width = 75
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn23.MappingName = "ORDEN"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.ReadOnly = True
        Me.DataGridTextBoxColumn23.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "ERROR"
        Me.DataGridTextBoxColumn22.MappingName = "PRC_ERROR"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.ReadOnly = True
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.MappingName = "RANGO_NORMAL"
        Me.DataGridTextBoxColumn21.NullText = "RANGO NORMAL"
        Me.DataGridTextBoxColumn21.ReadOnly = True
        Me.DataGridTextBoxColumn21.Width = 120
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "UNIDAD"
        Me.DataGridTextBoxColumn20.MappingName = "UNI_NOMENCLATURA"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.ReadOnly = True
        Me.DataGridTextBoxColumn20.Width = 75
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "RESULTADO"
        Me.DataGridTextBoxColumn19.MappingName = "PRC_RESULM"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.ReadOnly = True
        Me.DataGridTextBoxColumn19.Width = 120
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "EXAMEN"
        Me.DataGridTextBoxColumn18.MappingName = "TES_NOMBRE"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.ReadOnly = True
        Me.DataGridTextBoxColumn18.Width = 200
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "ABREV"
        Me.DataGridTextBoxColumn17.MappingName = "TEQ_ABRV_FIJA"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.ReadOnly = True
        Me.DataGridTextBoxColumn17.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "HORA P"
        Me.DataGridTextBoxColumn16.MappingName = "PRC_HORA"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "FECHA P"
        Me.DataGridTextBoxColumn15.MappingName = "PRC_FECHA"
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Pedido #"
        Me.DataGridTextBoxColumn14.MappingName = "ped_id"
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'dgtc_noteSecc
        '
        Me.dgtc_noteSecc.Format = ""
        Me.dgtc_noteSecc.FormatInfo = Nothing
        Me.dgtc_noteSecc.HeaderText = "AREA"
        Me.dgtc_noteSecc.MappingName = "SECC"
        Me.dgtc_noteSecc.NullText = ""
        Me.dgtc_noteSecc.ReadOnly = True
        Me.dgtc_noteSecc.Width = 200
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.HeaderText = "Imp"
        Me.DataGridBoolColumn2.MappingName = "Imp"
        Me.DataGridBoolColumn2.TrueValue = "1"
        Me.DataGridBoolColumn2.Width = 45
        '
        'dgrd_ResPedido
        '
        Me.dgrd_ResPedido.AllowSorting = False
        Me.dgrd_ResPedido.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_ResPedido.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_ResPedido.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_ResPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_ResPedido.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_ResPedido.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_ResPedido.CaptionText = "EXAMENES VALIDADOS"
        Me.dgrd_ResPedido.DataMember = ""
        Me.dgrd_ResPedido.FlatMode = True
        Me.dgrd_ResPedido.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_ResPedido.ForeColor = System.Drawing.Color.Black
        Me.dgrd_ResPedido.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_ResPedido.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_ResPedido.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_ResPedido.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_ResPedido.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_ResPedido.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_ResPedido.Location = New System.Drawing.Point(9, 218)
        Me.dgrd_ResPedido.Name = "dgrd_ResPedido"
        Me.dgrd_ResPedido.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_ResPedido.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_ResPedido.RowHeaderWidth = 20
        Me.dgrd_ResPedido.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_ResPedido.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_ResPedido.Size = New System.Drawing.Size(924, 342)
        Me.dgrd_ResPedido.TabIndex = 191
        Me.dgrd_ResPedido.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_ResPedido
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolColumn1, Me.dgtc_notaSecc, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.dgtc_archivo, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.DarkGray
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.SteelBlue
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn1.FalseValue = "0"
        Me.DataGridBoolColumn1.HeaderText = "IMP"
        Me.DataGridBoolColumn1.MappingName = "IMP"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.TrueValue = "1"
        Me.DataGridBoolColumn1.Width = 45
        '
        'dgtc_notaSecc
        '
        Me.dgtc_notaSecc.Format = ""
        Me.dgtc_notaSecc.FormatInfo = Nothing
        Me.dgtc_notaSecc.HeaderText = "AREA"
        Me.dgtc_notaSecc.MappingName = "SECC"
        Me.dgtc_notaSecc.NullText = ""
        Me.dgtc_notaSecc.ReadOnly = True
        Me.dgtc_notaSecc.Width = 200
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn1.MappingName = "ped_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "FECHA P"
        Me.DataGridTextBoxColumn2.MappingName = "PRC_FECHA"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "HORA P"
        Me.DataGridTextBoxColumn3.MappingName = "PRC_HORA"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "ABREV"
        Me.DataGridTextBoxColumn4.MappingName = "TEQ_ABRV_FIJA"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "EXAMEN"
        Me.DataGridTextBoxColumn5.MappingName = "TES_NOMBRE"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "RESULTADO"
        Me.DataGridTextBoxColumn6.MappingName = "PRC_RESULM"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 125
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "UNIDAD"
        Me.DataGridTextBoxColumn7.MappingName = "UNI_NOMENCLATURA"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "RANGO NORMAL"
        Me.DataGridTextBoxColumn8.MappingName = "RANGO_NORMAL"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 150
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "ERROR"
        Me.DataGridTextBoxColumn9.MappingName = "PRC_ERROR"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn10.MappingName = "ORDEN"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'dgtc_archivo
        '
        Me.dgtc_archivo.Format = ""
        Me.dgtc_archivo.FormatInfo = Nothing
        Me.dgtc_archivo.HeaderText = "PDF"
        Me.dgtc_archivo.MappingName = "rem_file"
        Me.dgtc_archivo.NullText = ""
        Me.dgtc_archivo.ReadOnly = True
        Me.dgtc_archivo.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "PADRE"
        Me.DataGridTextBoxColumn11.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "ARE_ID"
        Me.DataGridTextBoxColumn13.MappingName = "ARE_ID"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "TIPR"
        Me.DataGridTextBoxColumn25.MappingName = "RES_ID"
        Me.DataGridTextBoxColumn25.Width = 0
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "REPETICION"
        Me.DataGridTextBoxColumn26.MappingName = "PRC_REPETICION"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.ReadOnly = True
        Me.DataGridTextBoxColumn26.Width = 75
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(995, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "FILTRO CONVENIO"
        '
        'cmb_Conve
        '
        Me.cmb_Conve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Conve.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Conve.ForeColor = System.Drawing.Color.Black
        Me.cmb_Conve.Location = New System.Drawing.Point(1095, 74)
        Me.cmb_Conve.Name = "cmb_Conve"
        Me.cmb_Conve.Size = New System.Drawing.Size(126, 21)
        Me.cmb_Conve.TabIndex = 192
        '
        'lbl_ci
        '
        Me.lbl_ci.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ci.ForeColor = System.Drawing.Color.White
        Me.lbl_ci.Location = New System.Drawing.Point(701, 151)
        Me.lbl_ci.Name = "lbl_ci"
        Me.lbl_ci.Size = New System.Drawing.Size(120, 16)
        Me.lbl_ci.TabIndex = 49
        '
        'lkl_track_Correo
        '
        Me.lkl_track_Correo.AutoSize = True
        Me.lkl_track_Correo.LinkColor = System.Drawing.Color.White
        Me.lkl_track_Correo.Location = New System.Drawing.Point(1055, 30)
        Me.lkl_track_Correo.Name = "lkl_track_Correo"
        Me.lkl_track_Correo.Size = New System.Drawing.Size(47, 13)
        Me.lkl_track_Correo.TabIndex = 196
        Me.lkl_track_Correo.TabStop = True
        Me.lkl_track_Correo.Text = "Tracking"
        '
        'btn_whatsMedico
        '
        Me.btn_whatsMedico.BackColor = System.Drawing.Color.White
        Me.btn_whatsMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_whatsMedico.Image = CType(resources.GetObject("btn_whatsMedico.Image"), System.Drawing.Image)
        Me.btn_whatsMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_whatsMedico.Location = New System.Drawing.Point(561, 35)
        Me.btn_whatsMedico.Name = "btn_whatsMedico"
        Me.btn_whatsMedico.Size = New System.Drawing.Size(69, 46)
        Me.btn_whatsMedico.TabIndex = 197
        Me.btn_whatsMedico.Text = "MED"
        Me.btn_whatsMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_whatsMedico.UseVisualStyleBackColor = False
        '
        'lbl_NameDoctor
        '
        Me.lbl_NameDoctor.AutoSize = True
        Me.lbl_NameDoctor.Location = New System.Drawing.Point(640, 113)
        Me.lbl_NameDoctor.Name = "lbl_NameDoctor"
        Me.lbl_NameDoctor.Size = New System.Drawing.Size(38, 13)
        Me.lbl_NameDoctor.TabIndex = 198
        Me.lbl_NameDoctor.Text = "Label4"
        '
        'frm_VisResul
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1235, 569)
        Me.Controls.Add(Me.txt_notaArea)
        Me.Controls.Add(Me.lbl_NameDoctor)
        Me.Controls.Add(Me.btn_whatsMedico)
        Me.Controls.Add(Me.lkl_track_Correo)
        Me.Controls.Add(btn_Externo)
        Me.Controls.Add(btn_impEmcabezado)
        Me.Controls.Add(Me.lbl_doctorD)
        Me.Controls.Add(Me.lbl_ci)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmb_Conve)
        Me.Controls.Add(Me.dgrd_ResPedido)
        Me.Controls.Add(Me.btn_ImprBloque)
        Me.Controls.Add(Me.pan_hist)
        Me.Controls.Add(Me.btn_whatsapp)
        Me.Controls.Add(Me.btn_EnviaMail)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_ImpExa)
        Me.Controls.Add(Me.lbl_100)
        Me.Controls.Add(Me.lbl_0)
        Me.Controls.Add(Me.lbl_pedidoD)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbl_FechaD)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.btn_EnviaMailMedico)
        Me.Controls.Add(Me.chk_multiselec)
        Me.Controls.Add(Me.grp_valResul)
        Me.Controls.Add(Me.lbl_medico)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_Pedido)
        Me.Controls.Add(Me.btn_ImpArea)
        Me.Controls.Add(Me.btn_ImprTodo)
        Me.Controls.Add(Me.btn_ImpSobre)
        Me.Controls.Add(Me.btn_Histograma)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.lst_pedidos)
        Me.Controls.Add(Me.lst_remitidos)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_despliegapdf)
        Me.Controls.Add(btn_ImpHoja)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_VisResul"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emision de Resultados"
        Me.grp_valResul.ResumeLayout(False)
        Me.grp_valResul.PerformLayout()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.pan_hist.ResumeLayout(False)
        CType(Me.DiffimageHSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WBCImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiffimageLSHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBCimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiffimageBASO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiffimageLSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_ResPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Codigo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image



    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub


    Private Sub Formulario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
    End Sub



    Private Sub Formulario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'elimina la referecnia del formulario del MDI
        ClickMenu_Principal(Me)
        RemoveCtxMenu_Principal(Me, Me.Text)
    End Sub


#End Region

    Dim opr_resul As New Cls_Resultado()
    Dim opr_remitidos As New Cls_Remitidos()
    Dim opr_invitado As New Cls_Invitado()
    Dim opr_pedido As New Cls_Pedido()
    Dim opr_pdf As New Cls_ToPdf()
    Dim str_antecedentes As String = ""
    Dim str_medicamentos As String = ""
    Dim dts_resp As DataSet
    Dim dtt_res As DataTable
    Dim dtv_resp As New DataView(dtt_res)
    Dim opr_hist As New Cls_Hist()
    Dim str As String
    Dim arr_wbc(), arr_rbc(), arr_plt() As String
    Dim pen As New Pen(Color.White)
    Dim str_dir As String = Environment.CurrentDirectory & "\~tempimg"
    Dim dts_datos As New DataSet()
    Dim hist_ok As Boolean = False    'Variable para determinar si los histogramas ya han sido graficados y no hacerlo nuevamente
    Dim str_edad As String = ""
    Dim rem_id As String
    Dim abrirPdf As String
    Dim fechaIni As String = ""
    Dim fechaFin As String = ""
    Dim area As Integer = 0
    Dim dts_lista As New DataSet
    'Dim dts_listaPdf As New DataSet
    Dim opr_res As New Cls_Resultado()
    Dim urlQR As String = Nothing
    Public LabOcup As Byte



    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Tag = ""
        Call LimpiarCampos()
        'If Not ExisteForm("frm_PedFac") Then
        Dim frm_MDIChild As New frm_PedFac()
        frm_MDIChild.frm_refer_main_form = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        frm_MDIChild.txt_filtro.Focus()
        'End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub



    Public Sub llenadatos(ByVal tipo As String)
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        Dim opr_res As New Cls_Resultado()
        Dim edad As Date = Now
        If Me.Tag = "" Then
            LimpiarCampos()
            Exit Sub
        End If
        hist_ok = False
        str_campos = Split(Me.Tag, "/*/")
        lbl_pedidoD.Text = ""
        lbl_PacienteD.Text = ""
        lbl_FechaD.Text = ""
        lbl_FecNacD.Text = ""
        lbl_doctorD.Text = ""
        'lbl_ci.Text = ""
        str_antecedentes = ""
        str_medicamentos = ""
        lbl_LabId.Text = ""
        lbl_pac_email.Text = ""
        lbl_turno.Text = ""
        lbl_emailServicio.Text = ""
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim str_areas As String = Nothing




        For int_indice = 0 To UBound(str_campos)
            int_pos = InStr(str_campos(int_indice), "=")
            str_texto = str_campos(int_indice).Substring(0, int_pos - 1)
            str_valor = str_campos(int_indice).Substring(int_pos)
            Select Case str_texto
                Case "ped_id"
                    lbl_pedidoD.Text = (str_valor)
                Case "ped_fecing"
                    lbl_FechaD.Text = (Format(CDate(str_valor), "dd - MMM - yyyy"))
                Case "pac_nombre"
                    lbl_PacienteD.Text = (str_valor)
                Case "servicio"
                    lbl_Servicio.Text = (str_valor)
                Case "email_svr"
                    lbl_emailServicio.Text = (str_valor)

                Case "pac_doc"
                    lbl_ci.Text = (str_valor)
                Case "pac_fecnac"

                    Dim y, yn As Integer
                    Dim m, mn As Integer
                    Dim d, dn As Integer
                    str_edad = ""
                    y = Year(Now)
                    lbl_ci.Text = (str_valor)
                    yn = Year(CDate(str_valor))
                    m = Month(Now)
                    mn = Month(CDate(str_valor))
                    d = Microsoft.VisualBasic.Day(Now)
                    dn = Microsoft.VisualBasic.Day(CDate(str_valor))
                    If dn <= d Then
                        d = d - dn
                    Else
                        d = d + 30
                        m = m - 1
                        d = d - dn
                    End If
                    If mn <= m Then
                        m = m - mn
                    Else
                        m = m + 12
                        y = y - 1
                        m = m - mn
                    End If
                    y = y - yn
                    If (y < 2) Then
                        If y < 1 Then
                            If m > 0 Then
                                str_edad = m & " meses"
                            Else
                                str_edad = d & " dias"
                            End If
                        Else
                            str_edad = y & " año y " & m & " meses"
                        End If
                    Else
                        str_edad = y & " años "
                    End If

                    'str_edad = lbl_FecNacD.Text
                Case "ped_antecedentes"
                    str_antecedentes = (str_valor)
                Case "ped_medicacion"
                    str_medicamentos = (str_valor)
                Case "med_nombre"
                    lbl_doctorD.Text = opr_pedido.LeerTelefonoMedico(Trim(str_valor))
                    lbl_NameDoctor.Text = opr_pedido.LeerNombreMedico(Trim(str_valor))

                    'Case "ped_nota"
                    '    txt_notas.Text = (str_valor)
                Case "ped_turno"
                    lbl_turno.Text = str_valor
                Case "remitidos"
                    If (str_valor = True) Then
                        btn_despliegapdf.Enabled = True
                    Else
                        btn_despliegapdf.Enabled = False
                    End If
                Case "pac_usafecnac"
                    If str_valor = 0 Then
                        lbl_FecNacD.Text = "--"
                    End If
                Case "LAB"
                    lbl_LabId.Text = (str_valor)

                Case "pac_email"
                    lbl_pac_email.Text = (str_valor)
                Case "ped_tipo"
                    lbl_emailServicio.Text = (str_valor)

            End Select
        Next
        'btn_ObsPac.Enabled = True
        urlQR = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR") & lbl_pedidoD.Text)

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, CStr(LabOcup), str_areas, arr_nombre)

        opr_resul.ResultadosPedido(dtv_resp, dgrd_ResPedido, CInt(lbl_pedidoD.Text), 1, str_areas, 1)

        'opr_resul.ResultadosPedido(dtv_resp, dgrd_ResPedido, CInt(lbl_pedidoD.Text), 0, "00", )



    End Sub


    Private Sub qrcodeGen()
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            'System.Configuration.ConfigurationSettings.AppSettings("PATHQR") 
            'Me.txt_URL.Text = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR"))
            Me.Pic_QR.Image = qrCode.Encode(urlQR, System.Text.Encoding.UTF8)
            Me.Pic_QR.Image.Save(IO.Path.Combine(Environment.CurrentDirectory & "\" & (System.Configuration.ConfigurationSettings.AppSettings("QR")), lbl_pedidoD.Text & ".jpg"))

            'Call ConvierteBase64QR(System.Configuration.ConfigurationSettings.AppSettings("QR"), lbl_ordenMIS.Text, CLng(lbl_pedidoD.Text))
        Catch ex As Exception
            opr_pedido.VisualizaMensaje(ex.Message, 250)
            'MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function


    Function carga_histograma(ByRef dts_registro As DataSet) As Boolean
        Dim int_indice As Integer
        Dim dts_datos As New DataSet()
        dts_datos = opr_hist.LeerDatosHistograma(CStr(lbl_pedidoD.Text))
        Dim dtr_fila As DataRow
        Dim boo_his As Boolean = False
        For Each dtr_fila In dts_datos.Tables("Registros").Rows
            boo_his = True
            If dts_datos.Tables(0).Rows.Count < 3 Then
                'El pedido no tiene HISTOGRAMAS
                carga_histograma = False
                Exit Function
            Else
                carga_histograma = True
                If (dtr_fila(0) = "WBC") Then
                    str = dtr_fila(1)
                    arr_wbc = Split(str, ",")
                Else
                    If (dtr_fila(0) = "RBC") Then
                        str = dtr_fila(1)
                        arr_rbc = Split(str, ",")
                    Else
                        'En caso de ser PLT
                        str = dtr_fila(1)
                        arr_plt = Split(str, ",")
                    End If
                End If
            End If
        Next
        If boo_his = True Then
            'En caso de haber un histograma 
            dts_registro.Tables.Add("Registros")
            Dim STR_CAPTION As String() = {"Punto", "Dato_wbc", "Dato_rbc", "Dato_plt"}
            For int_indice = 0 To 3
                Dim dtc_columna As New DataColumn(STR_CAPTION(int_indice))
                dts_registro.Tables("Registros").Columns.Add(dtc_columna)
            Next

            For int_indice = 0 To UBound(arr_wbc) - 2 '63 'UBound(str_wbc_arr) - 1  *CELLDYN3500
                'For int_indice = 0 To 254 'UBound(str_wbc_arr) - 1 *CELLDYN1700
                dtr_fila = dts_registro.Tables("Registros").NewRow
                dtr_fila(0) = int_indice
                If IsDBNull(arr_wbc(int_indice)) Then
                    dtr_fila(1) = 0
                Else
                    If Not IsNumeric(arr_wbc(int_indice)) Then
                        dtr_fila(1) = 0
                    Else
                        dtr_fila(1) = CShort(arr_wbc(int_indice))
                    End If
                End If
                'If IsDBNull(arr_rbc(int_indice)) Then
                '    dtr_fila(2) = 0
                'Else
                '    If Not IsNumeric(arr_rbc(int_indice)) Then
                '        dtr_fila(2) = 0
                '    Else
                '        dtr_fila(2) = CShort(arr_rbc(int_indice))
                '    End If

                'End If
                ''dtr_fila(2) = CShort(arr_rbc(int_indice))
                'If IsDBNull(arr_plt(int_indice)) Then
                '    dtr_fila(3) = 0
                'Else
                '    If Not IsNumeric(arr_plt(int_indice)) Then
                '        dtr_fila(3) = 0
                '    Else
                '        dtr_fila(3) = CShort(arr_plt(int_indice))
                '    End If
                'End If
                'dtr_fila(3) = CShort(arr_plt(int_indice))
                dts_registro.Tables("Registros").Rows.Add(dtr_fila)
            Next

            '**********
            For int_indice = 0 To UBound(arr_rbc) - 2 '63 'UBound(str_wbc_arr) - 1  *CELLDYN3500
                'For int_indice = 0 To 254 'UBound(str_wbc_arr) - 1 *CELLDYN1700
                dtr_fila = dts_registro.Tables("Registros").NewRow
                dtr_fila(0) = int_indice

                If IsDBNull(arr_rbc(int_indice)) Then
                    dtr_fila(2) = 0
                Else
                    If Not IsNumeric(arr_rbc(int_indice)) Then
                        dtr_fila(2) = 0
                    Else
                        dtr_fila(2) = CShort(arr_rbc(int_indice))
                    End If

                End If
                dts_registro.Tables("Registros").Rows.Add(dtr_fila)
            Next
            '**********
            For int_indice = 0 To UBound(arr_plt) - 2 '63 'UBound(str_wbc_arr) - 1  *CELLDYN3500
                'For int_indice = 0 To 254 'UBound(str_wbc_arr) - 1 *CELLDYN1700
                dtr_fila = dts_registro.Tables("Registros").NewRow
                dtr_fila(0) = int_indice
                If IsDBNull(arr_plt(int_indice)) Then
                    dtr_fila(3) = 0
                Else
                    If Not IsNumeric(arr_plt(int_indice)) Then
                        dtr_fila(3) = 0
                    Else
                        dtr_fila(3) = CShort(arr_plt(int_indice))
                    End If
                End If
                dts_registro.Tables("Registros").Rows.Add(dtr_fila)
            Next

        End If
    End Function

    Public Sub LimpiarCampos()
        lbl_pedidoD.Text = ""
        lbl_PacienteD.Text = ""
        lbl_FechaD.Text = ""
        lbl_FecNacD.Text = ""
        lbl_doctorD.Text = ""
        'lbl_ci.Text = ""
        DiffimageBASO.Image = Nothing
        RBCimage.Image = Nothing
        PLTimage.Image = Nothing
        pan_hist.Visible = False
        'dgrd_ResPedido.DataSource = Nothing
        opr_resul.ResultadosPedido(dtv_resp, dgrd_ResPedido, 0, 1, "")
        txt_notaArea.Visible = True
        lbl_pac_email.Text = ""
        'Label3.Visible = True
    End Sub

    Private Sub btn_Histograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Histograma.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If (btn_Histograma.Text = "Histogr.") Then
            If hist_ok = False Then
                'C�digo para graficar los histogramas
                dts_datos = opr_hist.LeerDatosHistograma(CStr(lbl_pedidoD.Text))
                If dts_datos.Tables(0).Rows.Count < 3 Then
                    Me.Cursor = System.Windows.Forms.Cursors.Arrow
                    MsgBox("El pedido no tiene HISTOGRAMAS", MsgBoxStyle.Information, "ANALISYS")
                Else
                    btn_Histograma.Text = "R. Manual"
                    DiffimageBASO.Image = Nothing
                    RBCimage.Image = Nothing
                    PLTimage.Image = Nothing
                    txt_notaArea.Visible = False
                    'Label3.Visible = False
                    'LBabel1.Visible = False
                    pan_hist.Visible = True
                    Dim dtr_fila As DataRow
                    Dim boo_his As Boolean = False
                    For Each dtr_fila In dts_datos.Tables("Registros").Rows
                        boo_his = True
                        If (dtr_fila(0) = "WBC") Then
                            str = dtr_fila(1)
                            arr_wbc = Split(str, ",")
                        Else
                            If (dtr_fila(0) = "RBC") Then
                                str = dtr_fila(1)
                                arr_rbc = Split(str, ",")
                            Else
                                'En caso de ser PLT
                                str = dtr_fila(1)
                                arr_plt = Split(str, ",")
                            End If
                        End If
                    Next
                    If boo_his = True Then
                        opr_hist.Grafica_Histogramas(arr_wbc, arr_rbc, arr_plt, Me.DiffimageBASO, Me.RBCimage, Me.PLTimage)
                        hist_ok = True
                    Else
                        MsgBox("El pedido no posee Histogramas", MsgBoxStyle.Information, "ANALISYS")
                    End If
                End If
                '*****HISTOGRAMAS FIN
            Else
                btn_Histograma.Text = "R. Manual"
                pan_hist.Visible = True
                pan_hist.BringToFront()
            End If
        Else
            txt_notaArea.Visible = True
            'Label3.Visible = True
            pan_hist.Visible = False
            btn_Histograma.Text = "Histogr."
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub



    Private Sub frm_VisResul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm


        dtp_fi.Value = DateAdd(DateInterval.Day, -0, dtp_fi.Value)

        'var_nota = txt_notas.Text
        lst_remitidos.Items.Clear()
        lst_pedidos.Items.Clear()

        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer
        Dim str_areas As String

        g_orden = ""

        fechaIni = Format(dtp_fi.Value, "dd/MM/yyyy")
        fechaFin = Format(dtp_ff.Value, "dd/MM/yyyy")

        opr_pedido.LlenarComboPrioridad(cmb_Conve, False, True)
        cmb_Conve.SelectedIndex = 0

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, CStr(LabOcup), str_areas, arr_nombre)


        dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, str_areas, 2, "TODOS", g_str_unidad, " (3,5) ")
        'dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, area, 2, "TODOS", g_str_unidad, " (3,5) ")

        'AddHandler DataGridTextBoxColumn6.TextBox.DoubleClick, AddressOf TextoDblClick


    End Sub


    Sub TextoDblClick(ByVal Sender As Object, ByVal e As EventArgs)
        Dim rem_id As String
        Dim abrirPdf As String

        Try
            If (Mid(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 5), 1, 8) = "REMITIDO") Then
                ' IDENTIFICO EL REMITIDO
                rem_id = Mid(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 5), 14, Len(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 9)))
                abrirPdf = g_pathremitidos & "\" & opr_remitidos.LeerRutaPdf(rem_id)
                System.Diagnostics.Process.Start(abrirPdf)
            Else

            End If
        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
        End Try
    End Sub



    Private Sub lst_remitidos_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            abrirPdf = g_pathremitidosLee & Trim(Mid(lst_remitidos.SelectedItem.ToString(), 61, Len(lst_remitidos.SelectedItem.ToString())))
            System.Diagnostics.Process.Start(abrirPdf)

        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
        End Try

    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub dtp_ff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_ff.ValueChanged
        If (dtp_fi.Value > dtp_ff.Value) Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("La fecha inicial no puede ser mayor a la final.", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            actualizaConv()
        End If
    End Sub


    Private Sub filtrar()
        On Error Resume Next
        fechaIni = Format(dtp_fi.Value, "dd/MM/yyyy")
        fechaFin = Format(dtp_ff.Value, "dd/MM/yyyy")
        'area = cmb_area.Text.Substring(50, 2)
        actualizaConv()
        'dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, area, 2, "TODOS", g_str_unidad, 4)
    End Sub



    Private Sub dtp_fi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fi.ValueChanged
        If (dtp_fi.Value > dtp_ff.Value) Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("La fecha inicial no puede ser mayor a la final.", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            filtrar()
        End If

    End Sub

    Private Sub dgrd_ResPedido_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dgc_celda As DataGridCell
        Dim NotaExamen As String = ""
        Dim NotaArea As String = ""
        Dim tim_id As Integer
        Dim opr_pedido As New Cls_Pedido()


        dgc_celda.ColumnNumber = 6
        dgc_celda.RowNumber = dgrd_ResPedido.CurrentCell.RowNumber
        dgrd_ResPedido.CurrentCell = dgc_celda
        dgrd_ResPedido.Select(dgrd_ResPedido.CurrentCell.RowNumber)

        'RFN
        dgrd_ResPedido.CaptionText = "RESULTADOS DISPONIBLES:          " & dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 1).ToString()
        'lbl_nota_exa.Text = dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString()
        'lbl_NotaSecc.Text = dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 0).ToString()


        tim_id = Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 11).ToString())


        'NotaExamen = opr_res.LeerNotaExamen(CInt(lbl_pedidoD.Text), tes_id, 1)

        'If NotaExamen <> "" Then
        '    txt_notas.Text = NotaExamen
        'Else
        '    txt_notas.Text = ""
        'End If

        ' '' ''If (tes_id = 10 Or tes_id = 11 Or tes_id = 12 Or tes_id = 13 Or tes_id = 14 Or tes_id = 15 Or tes_id = 16 Or tes_id = 17 Or tes_id = 18 Or tes_id = 19 Or tes_id = 20 Or tes_id = 21 Or tes_id = 22 Or tes_id = 23 Or tes_id = 24 Or tes_id = 25 Or tes_id = 26 Or tes_id = 27 Or tes_id = 28 Or tes_id = 29 Or tes_id = 30 Or tes_id = 31 Or tes_id = 32 Or tes_id = 33 Or tes_id = 34 Or tes_id = 35 Or tes_id = 36 Or tes_id = 37) Then
        ' '' ''    tes_id = 400101
        ' '' ''End If
        NotaArea = opr_res.LeerNotaArea(CInt(lbl_pedidoD.Text), tim_id, 1)

        If NotaArea <> "" Then
            txt_notaArea.Text = NotaArea
        Else
            txt_notaArea.Text = ""
        End If


    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        If MsgBox("Desea cerrar la ventana Entrega de Resultados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_ImpSobre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpSobre.Click
        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        Else
            'frm_refer_main_form.escribemsj("INICIANDO GENERACI�N DE REPORTE")
            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim opr_pedido As New Cls_Pedido()
            Dim numFactura As Integer

            '0 emitido, 1 abonada, 2 cancelada, 3 anulada
            '(*)Case 0, 1
            '(*)MsgBox("El pedido no tiene cancelado sus valores", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 3
            '(*)MsgBox("El pedido tiene su factura anulada, no puede continuar el proceso", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 2
            'C�digo que actualiza el campo ped_estado a 4 --> Pedido impreso y entregado
            If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                    MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para imprimir", MsgBoxStyle.Information, "ANALISYS")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If

            If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                If MsgBox("La orden ya fue impresa, desea imprimirla nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If

            'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
            If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
            End If
            'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            cls_operacion.sql_conectar()
            'frm_refer_main_form.escribemsj("CONSULTANDO TEST...")
            'Este select sirve para extraer los datos del los test con equipos
            'OJO: el primer select trae el rango como resultado2, esto ocurre, porque los campos son blob, y da un problema de casting
            'con los otros select en la columna resultado2. Los otros dos select que son parte del union, estos otros select si traen el resultado2,
            'en el 1er select resultado1 trae los resultados, en el 2do y 3ero el campo resultado2 trae los resultados
            'En el campo TIPO, trae a donde pertenece el dato:
            '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
            '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
            '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 

            'jva 03-03-2004 aumento "and test_equipo.equ_id <> 2"

            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            Dim tes_id As Integer = 0
            Dim tes_padre As Integer = 0
            Dim NotaArea As String
            Dim g_validador, g_validadorID As String
            g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
            g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            tes_id = opr_pedido.LeerNombreTest(Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 5).ToString()))
            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 4).ToString()), CInt(lbl_pedidoD.Text))

            If (tes_id = 10 Or tes_id = 11 Or tes_id = 12 Or tes_id = 13 Or tes_id = 14 Or tes_id = 15 Or tes_id = 16 Or tes_id = 17 Or tes_id = 18 Or tes_id = 19 Or tes_id = 20 Or tes_id = 21 Or tes_id = 22 Or tes_id = 23 Or tes_id = 24 Or tes_id = 25 Or tes_id = 26 Or tes_id = 27 Or tes_id = 28 Or tes_id = 29 Or tes_id = 30 Or tes_id = 31 Or tes_id = 32 Or tes_id = 33 Or tes_id = 34 Or tes_id = 35 Or tes_id = 36 Or tes_id = 37) Then
                tes_id = 400101
            End If
            Dim g_notaArea As String
            g_notaArea = opr_res.LeerNotaArea(CInt(lbl_pedidoD.Text), tes_id, 1)

            opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
            For int_i = 0 To arr_datos.Count - 1
                str_Areas = str_Areas & arr_datos(int_i) & ","
            Next
            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If
            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA



            Dim str_Sql As String = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                "case when (RES_PROCESADOS.PRC_ALARMA = '*') then ('* '+ RES_PROCESADOS.PRC_RESFINAL) when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, " & _
                "case when (RES_PROCESADOS.PRC_ALARMA = '*') then ('* '+ RES_PROCESADOS.PRC_RESFINAL) else case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end end AS resultado2, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "'" & g_notaArea & "' AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
                "case when (PEDIDO.PED_ESTADO = 4)  then ('COPIA DEL INFORME') else '' end AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
                "'" & g_validador & "' as LIS_USER, PACIENTE.PAC_SEXO, PEDIDO.PED_ORIGEN as LIS_FECVALIDADO, " & _
                "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
            "'" & g_validadorCargo & "' as cargo, '" & g_validadorFolio & "' as folio, test.TES_OBS as metodo, ped_numaux " & _
                "FROM AREA INNER JOIN (UNIDAD " & _
                "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                "ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID " & _
                    "WHERE RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND RES_PROCESADOS.PRC_RESFINAL <> '' AND AREA.ARE_ID = test.ARE_ID  AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre  "
            str_Sql = str_Sql & str_aux

            str_Sql = str_Sql & " order by ORDEN_IMP"

            oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")
            cls_operacion.sql_desconn()


            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


            'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")
            Dim dts_histograma As New DataSet()
            Dim str_his As String = "NOHistograma"
            Dim obj_reporte As New Object

            g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME SOBRE", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")

            '******Dependiendo si existe o no histograma va el campo Histograma
            'If carga_histograma(dts_histograma) Then str_his = "Histograma"

            If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
                If MsgBox("Desea imprimir con formato 1 ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                    obj_reporte = New rpt_entregaresultadosSL()

                Else
                    obj_reporte = New rpt_entregaresultadosSL2()

                End If
            Else
                obj_reporte = New rpt_entregaresultadosSL()
            End If


            Dim frm_MDIChild As New Frm_reportes(str_his, "", obj_reporte, dts_operacion, dts_histograma, dts_histograma, dts_operaAB, True)

            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Emision de Resultados"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)
            '(*)End Select
            'frm_refer_main_form.escribemsj("DISPONIBLE")

            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    Private Sub btn_ImprTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImprTodo.Click
        Dim numFactura As Integer
        'opr_pedido.VisualizaMensaje("Recuerde que el formato IMPRESION AREA es el unico verificable subido en la NUBE", 450)

        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        Else

            'frm_refer_main_form.escribemsj("INICIANDO GENERACI�N DE REPORTE")
            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim opr_pedido As New Cls_Pedido()
            '(*)funci�n no utilizada para el club de leones y PUCE por que ellos no usan facturaci�n
            'chequea que la factura del pedido se encuentre cancelada
            '(*)Select Case opr_pedido.LeerPedEstadoFactura(CInt(lbl_pedidoD.Text))
            '0 emitido, 1 abonada, 2 cancelada, 3 anulada
            '(*)Case 0, 1
            '(*)MsgBox("El pedido no tiene cancelado sus valores", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 3
            '(*)MsgBox("El pedido tiene su factura anulada, no puede continuar el proceso", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 2
            'C�digo que actualiza el campo ped_estado a 4 --> Pedido impreso y entregado
            If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                    MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para imprimir", MsgBoxStyle.Information, "ANALISYS")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If

            If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                If MsgBox("La orden ya fue impresa, desea imprimirla nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If
            'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
            If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
            End If
            'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            cls_operacion.sql_conectar()

            'En el campo TIPO, trae a donde pertenece el dato:
            '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
            '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
            '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 


            Dim opr_resul As New Cls_Resultado()
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            Dim tim_id As Integer = 0
            Dim tes_padre As Integer = 0
            Dim NotaArea As String = Nothing
            Dim g_validadorID As String = Nothing
            Dim g_validador As String = Nothing
            Dim str_Sql As String = Nothing
            Dim archivos As String = Nothing
            Dim archivoQR As String = Nothing

            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            'g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
            'g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
            'Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            'Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            ''tim_id = Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 21).ToString())
            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 4).ToString()), CInt(lbl_pedidoD.Text))



            opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
            For int_i = 0 To arr_datos.Count - 1
                str_Areas = str_Areas & arr_datos(int_i) & ","
            Next
            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If

            Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")

            str_Sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

            Dim dts_histograma As New DataSet()
            Dim str_his As String = "NOHISTOGRAMA"
            Dim str_img As String = "NOIMAGEN"


            'AQUI 09
            archivos = opr_res.ConsultaPathFiles(str_Sql)

            If archivos <> "" Then

                Dim tramaTXT As String
                'Dim NombreArchivo As String

                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "WBCimage")
                Dim byteArrayWBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim imageWBC = convertbytetoimage(byteArrayWBC) 'Using Functions To Make the code tidier
                'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "WBCimage", NombreArchivo)
                tramaTXT = ""


                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "RBCimage")
                Dim byteArrayRBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim imageRBC = convertbytetoimage(byteArrayRBC) 'Using Functions To Make the code tidier
                'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "RBCimage", NombreArchivo)
                tramaTXT = ""


                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "PLTimage")
                Dim byteArrayPLT = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim image = convertbytetoimage(byteArrayPLT) 'Using Functions To Make the code tidier
                'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "PLTimage", NombreArchivo)
                tramaTXT = ""


                str_Sql = "SELECT  pedido.PED_ID, file_WBCimage, file_RBCimage, file_PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                archivos = opr_res.ConsultaPathFilesImg(str_Sql)

                dts_histograma = ReturnDataSet(archivos, byteArrayWBC, byteArrayRBC, byteArrayPLT)

            End If

            If dts_histograma.Tables.Count >= 1 Then
                str_his = "HISTOGRAMA"
            Else
                str_his = "NOHISTOGRAMA"
            End If


            '' '' '' ''******** CONSULTO SI TIENE QR ******
            str_Sql = "SELECT  pedido.PED_ID, img_base64 " & _
               "FROM pedido, ptoImagen " & _
               "where pedido.ped_id = ptoImagen.ped_id  " & _
               "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.img_nombre  = 'QR'"

            Dim dts_imagen As New DataSet()
            ''Dim str_img As String = "NOIMAGEN"

            archivoQR = opr_res.ConsultaPathFilesImagenQR(str_Sql)

            ' archivoQR = Nothing

            If archivoQR <> "" Then
                archivos = Nothing
                Dim tramaTXT As String
                Dim NombreArchivo As String


                tramaTXT = opr_resul.ConsultaImagen(CInt(lbl_pedidoD.Text), "QR")
                Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "", NombreArchivo)
                opr_resul.GuardarImagenOcupacional(CInt(lbl_pedidoD.Text), "QR", NombreArchivo)
                tramaTXT = ""

                str_Sql = "SELECT  pedido.PED_ID,  img_file " & _
                     "FROM pedido, ptoImagen " & _
                     "where pedido.ped_id = ptoImagen.ped_id  " & _
                     "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.Img_NOMBRE = 'QR'"

                archivos = opr_res.ConsultaPathFilesImgOcupacional(str_Sql)
                dts_imagen = ReturnDataSetOcup(archivos)
            End If

            If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                Try
                    If dts_imagen.Tables.Count >= 1 Then
                        str_img = "IMAGEN"
                        ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                    Else
                        str_img = "NOIMAGEN"
                    End If
                Catch
                    If IsDBNull(dts_imagen) = False Then
                        Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                            Case 0
                                If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                    opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                End If
                            Case 1
                                If dts_imagen.Tables.Count >= 1 Then
                                    str_img = "IMAGEN"
                                Else
                                    str_img = "NOIMAGEN"
                                End If
                        End Select
                    Else
                        str_img = "NOIMAGEN"
                    End If
                End Try
            End If


            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA

            str_Sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, " & _
                "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end AS resultado2, RES_PROCESADOS.PRC_ALARMA as Alarma, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
                "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
                "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
                "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
            "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id  " & _
                "FROM AREA INNER JOIN (UNIDAD " & _
                "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO " & _
                    "WHERE TEST_RESULTADO.RES_ID <>1 AND RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID and test.are_id <> 83 "
            str_Sql = str_Sql & str_aux
            str_Sql = str_Sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                    "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2,'' as Alarma, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                    "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                    "RESAB_PROCESADOS.PRC_NOTASECC AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                    "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, pedido.PED_RECIBO AS CONVENIO, " & _
                    "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                    "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' as RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id " & _
            "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
            "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
            "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
            "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
            "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "

            str_Sql = str_Sql & " order by AREA.ARE_OBS, test.TES_ORDENIMP, RES_PROCESADOS.TIM_ID "

            'str_Sql = str_Sql & " order by AREA.ARE_OBS asc, RES_PROCESADOS.TIM_ID, test.TES_ORDENIMP "
            oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")
            cls_operacion.sql_desconn()


            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


            'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")
            'Dim dts_histograma As New DataSet()
            'Dim str_his As String = "NOHistograma"
            Dim obj_reporte As New Object


            ''quemado
            lbl_LabId.Text = "1"

            '******Dependiendo si existe o no histograma va el campo Histograma
            'If carga_histograma(dts_histograma) Then str_his = "Histograma"

            If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
                If MsgBox("Desea imprimir con formato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                    Select Case lbl_emailServicio.Text
                        Case "RENALVIDA", "MEDICGO", "VIDA"
                            obj_reporte = New rpt_entregaContinua2()

                        Case "DRA. SAMI MENDOZA"
                            obj_reporte = New rpt_entregaContinua3()

                        Case "MEDES"
                            obj_reporte = New rpt_entregaContinua4()

                        Case "CEMEDEFA"
                            obj_reporte = New rpt_entregaContinua5()

                        Case "MUNDO"
                            obj_reporte = New rpt_entregaContinua6()

                        Case "SANAMEDIC"
                            obj_reporte = New rpt_entregaContinua7()

                        Case "FLORESMED"
                            obj_reporte = New rpt_entregaContinua8()

                        Case "ESENCIALMEDIC"
                            obj_reporte = New rpt_entregaContinua9()

                        Case "BODYCORP"
                            obj_reporte = New rpt_entregaContinua10()

                        Case "ODMEDIC"
                            obj_reporte = New rpt_entregaContinua11()

                        Case Else
                            obj_reporte = New rpt_entregaContinua()
                    End Select
                Else
                    obj_reporte = New rpt_entregaContinua_v()
                End If
            Else
                Select Case lbl_emailServicio.Text
                    Case "RENALVIDA", "MEDICGO", "VIDA"
                        obj_reporte = New rpt_entregaContinua2()

                    Case "DRA. SAMI MENDOZA"
                        obj_reporte = New rpt_entregaContinua3()

                    Case "MEDES"
                        obj_reporte = New rpt_entregaContinua4()

                    Case "CEMEDEFA"
                        obj_reporte = New rpt_entregaContinua5()

                    Case "MUNDO"
                        obj_reporte = New rpt_entregaContinua6()

                    Case "SANAMEDIC"
                        obj_reporte = New rpt_entregaContinua7()

                    Case "FLORESMED"
                        obj_reporte = New rpt_entregaContinua8()

                    Case "ESENCIALMEDIC"
                        obj_reporte = New rpt_entregaContinua9()

                    Case "BODYCORP"
                        obj_reporte = New rpt_entregaContinua10()

                    Case "ODMEDIC"
                        obj_reporte = New rpt_entregaContinua11()

                    Case Else
                        obj_reporte = New rpt_entregaContinua()
                End Select
            End If

            Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Entrega de Resultados"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)
            '(*)End Select
            'frm_refer_main_form.escribemsj("DISPONIBLE")

            g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME TODO", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")
            'Me.Cursor = System.Windows.For                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ms.Cursors.Default
        End If
    End Sub


    Public Function ConvertBase64ToByteArray(ByVal base64 As String) As Byte()


        'If IsBase64String(base64) = True Then
        Return Convert.FromBase64String(IsBase64String(base64)) 'Convert the base64 back to byte array.

        'Else

        'End If
        'If (base64.Length / 4) > 0 Then
        '    
        'Else
        '    base64 = base64 & "n"
        '    Return Convert.FromBase64String(base64) 'Convert the base64 back to byte array.
        'End If
    End Function

    Public Function IsBase64String(ByVal s As String) As String
        If (Trim(s).Length Mod 4) > 0 Then
            Return Mid(s, 1, s.Length - 1) ' & "="
        Else
            Return s
        End If

        'Return (s.Length Mod 4 = 0) AndAlso Regex.IsMatch(s, "^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None)
    End Function

    'Here's the part of your code (which works)

    Private Function convertbytetoimage(ByVal BA As Byte())
        Dim ms As MemoryStream = New MemoryStream(BA)
        Dim image = System.Drawing.Image.FromStream(ms)
        Return image
    End Function

    Private Sub btn_ImpArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpArea.Click
        Dim numFactura As Integer = Nothing

        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        Else

            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim opr_pedido As New Cls_Pedido()
            'chequea que la factura del pedido se encuentre cancelada
            '(*)Select Case opr_pedido.LeerPedEstadoFactura(CInt(lbl_pedidoD.Text))
            '0 emitido, 1 abonada, 2 cancelada, 3 anulada
            '(*)Case 0, 1
            '(*)MsgBox("El pedido no tiene cancelado sus valores", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 3
            '(*)MsgBox("El pedido tiene su factura anulada, no puede continuar el proceso", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 2

            If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) <> 2 Then
                    MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para imprimir", MsgBoxStyle.Information, "ANALISYS")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If
            If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                If MsgBox("La orden ya fue impresa, desea imprimirla nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If

            'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
            If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
            End If
            'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            cls_operacion.sql_conectar()
            'frm_refer_main_form.escribemsj("CONSULTANDO TEST...")
            'Este select sirve para extraer los datos del los test con equipos
            'OJO: el primer select trae el rango como resultado2, esto ocurre, porque los campos son blob, y da un problema de casting
            'con los otros select en la columna resultado2. Los otros dos select que son parte del union, estos otros select si traen el resultado2,
            'en el 1er select resultado1 trae los resultados, en el 2do y 3ero el campo resultado2 trae los resultados
            'En el campo TIPO, trae a donde pertenece el dato:
            '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
            '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
            '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 


            Dim opr_resul As New Cls_Resultado()
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            Dim tim_id As Integer = 0
            Dim tes_padre As Integer = 0
            Dim NotaArea As String = Nothing
            Dim g_validadorID As String = Nothing
            Dim g_validador As String = Nothing

            Dim Numorden As String
            Dim NumPedido As Integer
            Dim archivos As String = Nothing
            Dim archivoQR As String = Nothing

            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            'g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
            'g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
            'Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            'Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            ''tim_id = Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 21).ToString())
            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 4).ToString()), CInt(lbl_pedidoD.Text))



            opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
            For int_i = 0 To arr_datos.Count - 1
                str_Areas = str_Areas & arr_datos(int_i) & ","
            Next
            Dim str_sql As String = Nothing
            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If

            Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")

            'str_sql = "SELECT  pedido.PED_ID, DiffimageLSMS, DiffimageLSHS, DiffimageHSMS, DiffimageBASO, RBCimage, PLTimage, WBCImage " & _

            str_sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

            Dim dts_histograma As New DataSet()
            Dim str_his As String = "NOHISTOGRAMA"
            Dim str_img As String = "NOIMAGEN"

            'AQUI 09
            archivos = opr_res.ConsultaPathFiles(str_sql)

            If archivos <> "" Then

                Dim tramaTXT As String
                Dim NombreArchivo As String

                Dim byteArrayWBC As Byte()
                Dim byteArrayPLT As Byte()
                Dim byteArrayRBC As Byte()

                archivos = opr_res.ConsultaPathFilesImg(str_sql)

                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "WBCimage")
                byteArrayWBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim imageWBC = convertbytetoimage(byteArrayWBC) 'Using Functions To Make the code tidier
                'NombreArchivo = "WBCimage.gif"
                'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "WBCimage", NombreArchivo)
                tramaTXT = ""


                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "RBCimage")
                byteArrayRBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim imageRBC = convertbytetoimage(byteArrayRBC) 'Using Functions To Make the code tidier
                'NombreArchivo = "RBCimage.gif"
                'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "RBCimage", NombreArchivo)
                tramaTXT = ""

                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "PLTimage")
                byteArrayPLT = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim image = convertbytetoimage(byteArrayPLT) 'Using Functions To Make the code tidier
                'NombreArchivo = "PLTimage.gif"
                opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "PLTimage", NombreArchivo)
                tramaTXT = ""


                str_sql = "SELECT  pedido.PED_ID, file_WBCimage, file_RBCimage, file_PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                archivos = opr_res.ConsultaPathFilesImg(str_sql)

                dts_histograma = ReturnDataSet(archivos, byteArrayWBC, byteArrayPLT, byteArrayRBC)
                'dts_histograma = ReturnDataSet(archivos, byteArrayWBC, byteArrayPLT, byteArrayWBC)
            End If

            If (dts_histograma.Tables.Count >= 1) Then
                str_his = "HISTOGRAMA"
            Else
                str_his = "NOHISTOGRAMA"
            End If

            '' '' '' ''******** CONSULTO SI TIENE QR ******
            Dim dts_imagen As New DataSet()

            str_sql = "SELECT  pedido.PED_ID, img_base64 " & _
               "FROM pedido, ptoImagen " & _
               "where pedido.ped_id = ptoImagen.ped_id  " & _
               "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.img_nombre  = 'QR'"

            archivoQR = opr_res.ConsultaPathFilesImagenQR(str_sql)

            If archivoQR <> "" Then
                archivos = Nothing
                Dim tramaTXT As String
                Dim NombreArchivo As String

                tramaTXT = opr_resul.ConsultaImagen(CInt(lbl_pedidoD.Text), "QR")
                Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "", NombreArchivo)
                opr_resul.GuardarImagenOcupacional(CInt(lbl_pedidoD.Text), "QR", NombreArchivo)
                tramaTXT = ""

                str_sql = "SELECT  pedido.PED_ID,  img_file " & _
                     "FROM pedido, ptoImagen " & _
                     "where pedido.ped_id = ptoImagen.ped_id  " & _
                     "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.Img_NOMBRE = 'QR'"

                archivos = opr_res.ConsultaPathFilesImgOcupacional(str_sql)
                dts_imagen = ReturnDataSetOcup(archivos)
            End If

            If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                Try
                    If dts_imagen.Tables.Count >= 1 Then
                        str_img = "IMAGEN"
                        ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                    Else
                        str_img = "NOIMAGEN"
                    End If
                Catch
                    If IsDBNull(dts_imagen) = False Then
                        Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                            Case 0
                                If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                    opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                End If
                            Case 1
                                If dts_imagen.Tables.Count >= 1 Then
                                    str_img = "IMAGEN"
                                Else
                                    str_img = "NOIMAGEN"
                                End If
                        End Select
                    Else
                        str_img = "NOIMAGEN"
                    End If
                End Try
            End If



            ''" & g_invitado & "'
            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA
            str_sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end AS resultado2, RES_PROCESADOS.PRC_ALARMA as Alarma, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_TIPO AS CONVENIO," & _
                "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
                "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
                "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
            "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, '" & str_img & "' AS IMAGEN, INVITADO.invitado_id " & _
                "FROM AREA INNER JOIN (UNIDAD " & _
                "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO " & _
                    "WHERE TEST_RESULTADO.RES_ID <>1 AND RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID and test.are_id <> 83 "
            str_sql = str_sql & str_aux
            str_sql = str_sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                    "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2, '' as Alarma, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                    "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                    "RESAB_PROCESADOS.PRC_NOTASECC AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                    "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, pedido.PED_RECIBO AS CONVENIO, " & _
                    "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then( convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                    "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' AS RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, '" & str_img & "' AS IMAGEN, INVITADO.invitado_id  " & _
            "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
            "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
            "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
            "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
            "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "

            str_sql = str_sql & " order by AREA.ARE_OBS, test.TES_ORDENIMP, RES_PROCESADOS.TIM_ID "

            oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
            dts_operacion.Merge(dts_operacion, False, System.Data.MissingSchemaAction.Ignore)
            oda_operacion.Fill(dts_operacion, "Registros")
            cls_operacion.sql_desconn()


            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


            'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")


            Dim obj_reporte As New Object
            ''quemado
            lbl_LabId.Text = "1"

            'Dim rpt As New rpt_HistogramaInterfaz

            '******Dependiendo si existe o no histograma va el campo Histograma


            If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
                If MsgBox("Desea imprimir con formato ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                    Select Case lbl_emailServicio.Text
                        Case "RENALVIDA", "MEDICGO", "VIDA"
                            obj_reporte = New rpt_entregaresultados2()

                        Case "DRA. SAMI MENDOZA"
                            obj_reporte = New rpt_entregaresultados3()

                        Case "MEDES"
                            obj_reporte = New rpt_entregaresultados4()

                        Case "CEMEDEFA"
                            obj_reporte = New rpt_entregaresultados5()

                        Case "MUNDO"
                            obj_reporte = New rpt_entregaresultados6()

                        Case "SANAMEDIC"
                            obj_reporte = New rpt_entregaresultados7()

                        Case "FLORESMED"
                            obj_reporte = New rpt_entregaresultados8()

                        Case "ESENCIALMEDIC"
                            obj_reporte = New rpt_entregaresultados9()

                        Case "BODYCORP"
                            obj_reporte = New rpt_entregaresultados10()

                        Case "ODMEDIC"
                            obj_reporte = New rpt_entregaresultados11()

                        Case Else
                            obj_reporte = New rpt_entregaresultados()
                    End Select

                Else
                    obj_reporte = New rpt_entregaresultados_v()
                End If
            Else
                Select Case lbl_emailServicio.Text
                    Case "RENALVIDA", "MEDICGO", "VIDA"
                        obj_reporte = New rpt_entregaresultados2()

                    Case "DRA. SAMI MENDOZA"
                        obj_reporte = New rpt_entregaresultados3()

                    Case "MEDES"
                        obj_reporte = New rpt_entregaresultados4()

                    Case "CEMEDEFA"
                        obj_reporte = New rpt_entregaresultados5()

                    Case "MUNDO"
                        obj_reporte = New rpt_entregaresultados6()

                    Case "SANAMEDIC"
                        obj_reporte = New rpt_entregaresultados7()

                    Case "FLORESMED"
                        obj_reporte = New rpt_entregaresultados8()

                    Case "ESENCIALMEDIC"
                        obj_reporte = New rpt_entregaresultados9()

                    Case "BODYCORP"
                        obj_reporte = New rpt_entregaresultados10()

                    Case "ODMEDIC"
                        obj_reporte = New rpt_entregaresultados11()

                    Case Else
                        obj_reporte = New rpt_entregaresultados()
                End Select
            End If

            Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Entrega de Resultados"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)

            '(*)End Select
            'frm_refer_main_form.escribemsj("DISPONIBLE")

            Me.Cursor = System.Windows.Forms.Cursors.Default
            g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME POR AREA", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")

        End If
    End Sub



    Private Sub ConvierteBase64QR(ByVal path As String, ByVal nombreFILE As String, ByVal ped_id As Long, ByVal tipoQR As String)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        '  Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim param As SqlParameter
        Dim beneficiosVida As Byte()
        Dim archivo As String = Nothing
        Dim img_orden As String = Nothing

        Select Case tipoQR
            Case "FIRMA"
                archivo = path & "\" & ped_id & ".jpg"
            Case "ACCESO"
                archivo = path & "\" & ped_id & "W.jpg"
        End Select

        img_orden = Format(Now, "yy") & Trim(Mid(nombreFILE, 1, 9))
        beneficiosVida = File.ReadAllBytes(Environment.CurrentDirectory & "\" & archivo)
        Dim base64String As String = Convert.ToBase64String(beneficiosVida, 0, beneficiosVida.Length)

        opr_Conexion.sql_conectar()
        STR_SQL = "update ptoimagen set img_base64 = '" & base64String & "', img_orden = '" & img_orden & "' where ped_id = " & ped_id & " and img_nombre = '" & tipoQR & "' "

        opr_Conexion.sql_conectar()

        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar QR", Err)
        Err.Clear()

    End Sub



    Public Function EliminaArchivoTxt(ByVal ruta_archivo As String) As Boolean
        Try
            If File.Exists(ruta_archivo) Then
                ':::Eliminamos el archivo TXT
                File.Delete(ruta_archivo)
                'MsgBox("Archivo eliminado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")

            Else
                'MsgBox("No se encuentra el archivo especificado", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            End If
        Catch ex As Exception
            'MsgBox("Se presento un problema al eliminar el archivo: " & ex.Message, MsgBoxStyle.Critical, "AnalisysLAb")
        End Try
    End Function


    Public Function Base64ToImageOcupacional(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte()
        Try
            imageBytes = Convert.FromBase64String(Base64Code)

            'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            If numorden <> "" Then

                NombreArchivo = nombre_tipo & numorden & ".jpg"

                If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\" & g_pathFolderQR & "\" & NombreArchivo

                'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

                If File.Exists(vFileName) Then
                    File.Delete(vFileName)
                    'EliminaArchivoTxt(vFileName)
                End If
                'diskOpts.DiskFileName = vFileName

                File.WriteAllBytes(vFileName, imageBytes)


                Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
                Dim tmpImage As Image = Image.FromStream(ms, True)
                'NombreArchivo = vFileName

                Return tmpImage
            End If
        Catch

        End Try

    End Function




    Public Function Base64ToImage(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte()
        Try
            imageBytes = Convert.FromBase64String(Base64Code)

            'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            If numorden <> "" Then

                NombreArchivo = nombre_tipo & numorden & ".gif"

                If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo

                'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

                If File.Exists(vFileName) Then
                    'File.Delete(vFileName)
                    EliminaArchivoTxt(vFileName)
                End If
                'diskOpts.DiskFileName = vFileName

                File.WriteAllBytes(vFileName, imageBytes)


                Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
                Dim tmpImage As Image = Image.FromStream(ms, True)
                'NombreArchivo = vFileName

                Return tmpImage
            End If
        Catch

        End Try

    End Function


    Public Function ReturnDataSet(ByVal files As String, ByVal WBC As Byte(), ByVal RBC As Byte(), ByVal PLT As Byte()) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        'Dim files_arreglo As String()
        'Dim pathImg As String = Nothing
        'files_arreglo = Split(files, "\")

        'pathImg = Environment.CurrentDirectory & "\" & g_pathFolderImg

        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen2", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen3", GetType(Byte())))

        dr = dt.NewRow()
        dr("Imagen") = WBC

        dr = dt.NewRow()
        dr("Imagen2") = RBC

        dr = dt.NewRow()
        dr("Imagen3") = PLT


        dt.Rows.Add(dr)
        ds.Tables.Add(dt)
        ds.Tables(0).TableName = "Imagenes"

        Dim iDS As New dsImagenes
        iDS.Merge(ds, False, System.Data.MissingSchemaAction.Ignore)
        Return iDS
    End Function



    Public Function ReturnDataSetOcup(ByVal files As String) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "\")

        pathImg = Environment.CurrentDirectory & "\" & g_pathFolderQR

        dt.Columns.Add(New DataColumn("Codigo", GetType(Short)))
        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))


        dr = dt.NewRow()
        dr("Codigo") = 1
        dr("Descripcion") = "QR"
        dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(0)))
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)
        ds.Tables(0).TableName = "ImagenesQR"

        Dim iDS As New dsImgOcup
        iDS.Merge(ds, False, System.Data.MissingSchemaAction.Ignore)
        Return iDS
    End Function


    Public Function ImageToByte(ByVal pImagen As Image) As Byte()
        Dim mImage() As Byte
        Try
            If Not IsNothing(pImagen) Then
                Dim ms As New System.IO.MemoryStream
                pImagen.Save(ms, pImagen.RawFormat)
                mImage = ms.GetBuffer
                ms.Close()
                Return mImage
            End If
        Catch
        End Try
    End Function


    Private Sub btn_buscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Tag = ""
        Call LimpiarCampos()
        'If Not ExisteForm("frm_PedFac") Then
        Dim frm_MDIChild As New frm_PedFac()
        frm_MDIChild.frm_refer_main_form = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        frm_MDIChild.dtp_fi.Value = Me.dtp_fi.Value
        frm_MDIChild.dtp_ff.Value = Me.dtp_ff.Value
        frm_MDIChild.txt_filtro.Focus()
        orden = frm_MDIChild.orden
        Dim I As Integer = 0
        Dim sw As Boolean = False

        For I = 0 To (lst_pedidos.Items.Count - 1)
            If orden = Trim(Mid(lst_pedidos.Items.Item(I), 4, 9)) Then
                'obtiene_indice = lst_pedidos.SelectedIndex
                lst_pedidos.SetSelected(I, True)
                sw = True
                Exit For
            End If
        Next

        If sw = False Then
            opr_pedido.VisualizaMensaje("No se encontro el registro", 300)
        End If

        'End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub




    Private Sub btn_ImprBloque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImprBloque.Click
        Dim opr_pedido As New Cls_Pedido()
        Dim dts_operacion As New DataSet()
        Dim cls_operacion As New Cls_Conexion()
        Dim opr_pac As New Cls_Paciente()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        Dim opr_resul As New Cls_Resultado()
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0
        Dim tim_id As Integer = 0
        Dim tes_padre As Integer = 0
        Dim g_validador, g_validadorID As String

        Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
        Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)



        Dim numT As Integer = 0
        Dim i As Integer = 0
        Dim DatosPedidos As String = Nothing
        Dim DatosPDFS As String = Nothing
        Dim Pedidos As String()
        Dim OrdenPdf As String()
        Dim Pdfs As String()
        Dim OrdenFecha As String()
        Dim nombrePdf As String = Nothing
        Dim str_sql As String = Nothing
        Dim dts_histograma As New DataSet()
        Dim dts_imagen As New DataSet()
        Dim str_his As String = "NOHISTOGRAMA"
        Dim str_img As String = "NOIMAGEN"
        Dim obj_reporte As New Object
        Dim DatosEdadPdf As String = Nothing
        Dim DatosConvenios As String = Nothing
        Dim EdadPdf As String()
        Dim Convenios As String()

        'Cargo grid con  valores resultadis + AB disponibles 
        Dim dts_operaAB As New DataSet()
        Dim dtt_resAB As New DataTable("RegistrosRESAB")
        Dim dtv_resAB As New DataView(dtt_resAB)

        ProgressBar1.Value = 0
        numT = lst_pedidos.Items.Count

        For i = 0 To numT - 1
            If lst_pedidos.GetSelected(i) = True Then
                DatosPedidos = DatosPedidos & Trim(Mid(lst_pedidos.Items.Item(i), 72, 10)) & "," & Format(Now, "yyyy-") & Mid(lst_pedidos.Items.Item(i), 4, 2) & "-" & Mid(lst_pedidos.Items.Item(i), 6, 2) & "|"
                DatosPDFS = DatosPDFS & Trim(Mid(lst_pedidos.Items.Item(i), 4, 10)) & "-" & Trim(Mid(lst_pedidos.Items.Item(i), 15, 50)) & ".pdf" & "|"
                DatosEdadPdf = DatosEdadPdf & Trim(Mid(lst_pedidos.Items.Item(i), 130, Len(lst_pedidos.Items.Item(i)))) & "|"
                DatosConvenios = DatosConvenios & Trim(Mid(lst_pedidos.Items.Item(i), 200, Len(lst_pedidos.Items.Item(i)))) & "|"
            End If
        Next
        Pedidos = Split(DatosPedidos, "|")
        Pdfs = Split(DatosPDFS, "|")
        EdadPdf = Split(DatosEdadPdf, "|")
        Convenios = Split(DatosConvenios, "|")
        Dim str_pdf As String()
        str_pdf = Split(Pdfs(0), "-")
        cls_operacion.sql_conectar()

        Dim incremento As Integer = 0
        incremento = 100 / UBound(Pedidos) - 1
        'obj_reporte = New rpt_entregaContinua()

        If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
            If MsgBox("Desea imprimir con formato ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                Select Case lbl_emailServicio.Text
                    Case "RENALVIDA", "MEDICGO", "VIDA"
                        obj_reporte = New rpt_entregaresultados2()

                    Case "DRA. SAMI MENDOZA"
                        obj_reporte = New rpt_entregaresultados3()

                    Case "MEDES"
                        obj_reporte = New rpt_entregaresultados4()

                    Case "CEMEDEFA"
                        obj_reporte = New rpt_entregaresultados5()

                    Case "MUNDO"
                        obj_reporte = New rpt_entregaresultados6()

                    Case "SANAMEDIC"
                        obj_reporte = New rpt_entregaresultados7()

                    Case "FLORESMED"
                        obj_reporte = New rpt_entregaresultados8()

                    Case "ESENCIALMEDIC"
                        obj_reporte = New rpt_entregaresultados9()

                    Case "BODYCORP"
                        obj_reporte = New rpt_entregaresultados10()

                    Case "ODMEDIC"
                        obj_reporte = New rpt_entregaresultados11()

                    Case Else
                        obj_reporte = New rpt_entregaresultados()
                End Select

            Else
                obj_reporte = New rpt_entregaresultados()
            End If
        Else
            Select Case lbl_emailServicio.Text
                Case "RENALVIDA", "MEDICGO", "VIDA"
                    obj_reporte = New rpt_entregaresultados2()

                Case "DRA. SAMI MENDOZA"
                    obj_reporte = New rpt_entregaresultados3()

                Case "MEDES"
                    obj_reporte = New rpt_entregaresultados4()

                Case "CEMEDEFA"
                    obj_reporte = New rpt_entregaresultados5()

                Case "MUNDO"
                    obj_reporte = New rpt_entregaresultados6()

                Case "SANAMEDIC"
                    obj_reporte = New rpt_entregaresultados7()

                Case "FLORESMED"
                    obj_reporte = New rpt_entregaresultados8()

                Case "ESENCIALMEDIC"
                    obj_reporte = New rpt_entregaresultados9()

                Case "BODYCORP"
                    obj_reporte = New rpt_entregaresultados10()

                Case "ODMEDIC"
                    obj_reporte = New rpt_entregaresultados11()

                Case Else
                    obj_reporte = New rpt_entregaresultados()
            End Select
        End If





        For i = 0 To UBound(Pedidos) - 1
            dts_operacion.Clear()

            OrdenFecha = Split(Pedidos(i), ",")
            OrdenPdf = Split(Pdfs(i), "-")
            '''''''AQUI GENERO EL QUERY CON LOS DATOS DE CADA PEDIDO
            str_sql = opr_pedido.devuelvePedidosBloque(Me, OrdenPdf(0), OrdenFecha(0), CDate(Mid(EdadPdf(i), 1, 19)), dts_histograma, dts_imagen)

            If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                Try
                    If dts_imagen.Tables.Count >= 1 Then
                        str_img = "IMAGEN"
                        ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                    Else
                        str_img = "NOIMAGEN"
                    End If
                Catch
                    If IsDBNull(dts_imagen) = False Then
                        Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                            Case 0
                                If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                    opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                End If
                            Case 1
                                If dts_imagen.Tables.Count >= 1 Then
                                    str_img = "IMAGEN"
                                Else
                                    str_img = "NOIMAGEN"
                                End If
                        End Select
                    Else
                        str_img = "NOIMAGEN"
                    End If
                End Try
            End If

            dts_operacion.Merge(dts_operacion, False, System.Data.MissingSchemaAction.Ignore)

            oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")

            Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)

            opr_pdf.ExportToPDF(obj_reporte, Pdfs(i), g_pathFolder)
            ProgressBar1.Increment(incremento)

        Next
        ProgressBar1.Increment(incremento)
        opr_pedido.VisualizaMensaje("Generacion de archivos PDF concluida", 250)
        cls_operacion.sql_desconn()
    End Sub


    Private Sub chk_multiselec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_multiselec.CheckedChanged
        If chk_multiselec.Checked Then
            Dim i As Short = 0
            For i = 0 To (lst_pedidos.Items.Count - 1)
                lst_pedidos.SetSelected(i, False)
            Next
            lst_pedidos.SelectionMode = SelectionMode.MultiExtended
        Else
            lst_pedidos.SelectionMode = SelectionMode.One
            btn_ImprBloque.Enabled = False
            btn_ImprTodo.Enabled = True
            btn_ImpArea.Enabled = True
            btn_whatsapp.Enabled = True

            btn_EnviaMail.Enabled = False



        End If
    End Sub

    Private Sub btn_EnviaMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EnviaMail.Click

        Dim opr_pedido As New Cls_Pedido()
        Dim dts_operacion As New DataSet()
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        Dim opr_resul As New Cls_Resultado()
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0
        Dim tim_id As Integer = 0
        Dim tes_padre As Integer = 0
        Dim g_validador, g_validadorID As String

        Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
        Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

        Dim numT As Integer = 0
        Dim i As Integer = 0
        Dim DatosPedidos As String = Nothing
        Dim DatosPDFS As String = Nothing
        Dim DatosEdadPdf As String = Nothing
        Dim Pedidos As String()
        Dim Pdfs As String()
        Dim OrdenFecha As String()
        Dim OrdenPdf As String()
        Dim nombrePdf As String = Nothing
        Dim str_sql As String = Nothing
        Dim dts_histograma As New DataSet()
        Dim dts_imagen As New DataSet()
        Dim str_his As String = "NOHISTOGRAMA"
        Dim str_img As String = "NOIMAGEN"
        Dim obj_reporte As New Object

        'Cargo grid con  valores resultadis + AB disponibles 
        Dim dts_operaAB As New DataSet()
        Dim dtt_resAB As New DataTable("RegistrosRESAB")
        Dim dtv_resAB As New DataView(dtt_resAB)

        'para correo
        Dim opr_mail As New Cls_NetMail()
        Dim opr_encripta As New Cls_Encripta()
        Dim ParamCorreo As String()
        Dim texto As String
        Dim SinCorreo As String = Nothing
        Dim EnviadosOk As Integer = 0
        Dim SinEnviar As Integer = 0
        'Dim SinCorreoArr As String() = Nothing
        Dim EdadPdf As String()


        ProgressBar1.Value = 0

        numT = lst_pedidos.Items.Count

        For i = 0 To numT - 1
            If lst_pedidos.GetSelected(i) = True Then
                DatosPedidos = DatosPedidos & Trim(Mid(lst_pedidos.Items.Item(i), 72, 10)) & "," & Format(Now, "yyyy-") & Mid(lst_pedidos.Items.Item(i), 4, 2) & "-" & Mid(lst_pedidos.Items.Item(i), 6, 2) & "," & Mid(lst_pedidos.Items.Item(i), 87, 100) & "," & Len(lst_pedidos.Items.Item(i)) & "," & Mid(lst_pedidos.Items.Item(i), 17, 50) & "|"
                DatosPDFS = DatosPDFS & Trim(Mid(lst_pedidos.Items.Item(i), 4, 10)) & "-" & Trim(Mid(lst_pedidos.Items.Item(i), 15, 50)) & ".pdf" & "|"
                DatosEdadPdf = DatosEdadPdf & Trim(Mid(lst_pedidos.Items.Item(i), 180, Len(lst_pedidos.Items.Item(i)))) & "|"
            End If
        Next
        Pedidos = Split(DatosPedidos, "|")
        Pdfs = Split(DatosPDFS, "|")
        EdadPdf = Split(DatosEdadPdf, "|")

        Dim str_pdf As String()

        str_pdf = Split(Pdfs(0), "-")
        cls_operacion.sql_conectar()




        If MsgBox("Desea enviar con formato continuo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Select Case lbl_emailServicio.Text
                Case "RENALVIDA", "MEDICGO", "VIDA"
                    obj_reporte = New rpt_entregaresultados2()

                Case "DRA. SAMI MENDOZA"
                    obj_reporte = New rpt_entregaresultados3()

                Case "MEDES"
                    obj_reporte = New rpt_entregaresultados4()

                Case "CEMEDEFA"
                    obj_reporte = New rpt_entregaresultados5()

                Case "MUNDO"
                    obj_reporte = New rpt_entregaresultados6()

                Case Else
                    obj_reporte = New rpt_entregaresultados()
            End Select

        Else
            obj_reporte = New rpt_entregaresultados()
        End If


        Dim incremento As Integer = 0
        Dim cerror As String()
        Dim param_cerror As String()

        incremento = 100 / UBound(Pedidos) - 1
        For i = 0 To UBound(Pedidos) - 1
            dts_operacion.Clear()

            OrdenFecha = Split(Pedidos(i), ",")
            OrdenPdf = Split(Pdfs(i), "-")
            '''''''AQUI GENERO EL QUERY CON LOS DATOS DE CADA PEDIDO
            str_sql = opr_pedido.devuelvePedidosBloque(Me, OrdenPdf(0), OrdenFecha(0), CDate(Mid(EdadPdf(i), 1, 19)), dts_histograma, dts_imagen)


            'dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(OrdenFecha(i)), tes_padre)

            oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")

            'AQUI EXPORTO LOS REPORTES A PDF ....AL MENOS ESO ESPERO jiji)

            ''''If carga_histograma(dts_histograma) Then str_his = "Histograma"

            If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                Try
                    If dts_imagen.Tables.Count >= 1 Then
                        str_img = "IMAGEN"
                        ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                    Else
                        str_img = "NOIMAGEN"
                    End If
                Catch
                    If IsDBNull(dts_imagen) = False Then
                        Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                            Case 0
                                If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                    opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                End If
                            Case 1
                                If dts_imagen.Tables.Count >= 1 Then
                                    str_img = "IMAGEN"
                                Else
                                    str_img = "NOIMAGEN"
                                End If
                        End Select
                    Else
                        str_img = "NOIMAGEN"
                    End If
                End Try
            End If


            Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
            Dim numFactura As String = Nothing
            Dim enviopara As String = Nothing


            opr_pdf.ExportToPDF(obj_reporte, Pdfs(i), g_pathFolder)

            If chk_IncluirEnvio.Checked Then
                If Trim(Mid(OrdenFecha(2), 1, Len(OrdenFecha(2)) - 18)) <> "" Then
                    enviopara = Trim(Mid(OrdenFecha(2), 1, Len(OrdenFecha(2)) - 18)) & "," & Trim(lbl_emailServicio.Text)
                Else
                    enviopara = Trim(lbl_emailServicio.Text)
                End If
            Else
                enviopara = Trim(Mid(OrdenFecha(2), 1, Len(OrdenFecha(2)) - 18))
            End If


            If InStr(enviopara, "@") <> 0 Then
                ' verifico si tiene cancelada la factura
                '

                ' ''If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                ' ''    If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                ' ''        'MsgBox("La orden a�n mantiene saldo por pagar, cancele la orden para enviar", MsgBoxStyle.Information, "ANALISYS")
                ' ''        'Me.Cursor = System.Windows.Forms.Cursors.Default
                ' ''        'Exit Sub
                ' ''    End If
                ' ''End If

                If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                    If opr_pedido.LeerEstadoFactura(CInt(OrdenFecha(0).ToString), numFactura) = 2 Then
                        Dim vFileName As String = Environment.CurrentDirectory & "\" & g_pathFolder & "\" & Pdfs(i)

                        texto = "Agradecemos la confianza depositada en " & g_Titulo & vbCrLf & vbCrLf & "Adjunto encontrara los resultados de los examenes de laboratorio." & vbCrLf & "Correo enviado automaticamente, por favor no responda." & vbCrLf & "Powered by TRUESOLUTIONS 2019"
                        'texto = "Señor(a) Paciente y/o Doctor Md. Tratante" & vbCrLf & vbCrLf & "Reciba un cordial saludo de " & g_Titulo & vbCrLf & "Adjunto se encuentran los resultados del Sr(a) Paciente atendido en nuestro Laboratorio." & vbCrLf & vbCrLf & "Agradecemos su confianza." & vbCrLf & vbCrLf & "Atte." & vbCrLf & "Lcda. Rosa Mercedes Lino García" & vbCrLf & "Lcdo. José Zambrano Murillo" & vbCrLf & "LABORATORISTAS CLÍNICOS"
                        ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
                        If opr_mail.EnviaCorreo(Trim(OrdenFecha(2)), "RESULTADOS EXAMENES", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), vFileName, ParamCorreo(5)) = True Then
                            EnviadosOk = EnviadosOk + 1
                            SinCorreo = SinCorreo & Mid(Pdfs(i), 1, 9) & ":" & "correo enviado satisfactoriamente" & ":" & OrdenFecha(0).ToString & vbCrLf
                            opr_pedido.ActualizarEstadoPedido(CInt(OrdenFecha(0).ToString), 6)
                            g_opr_usuario.CargarTransaccion(g_str_login, "ENVIO CORREO PACIENTE", "PEDIDO=" & OrdenFecha(0).ToString, g_sng_user, OrdenFecha(0).ToString, "", "")
                        Else
                            SinCorreo = SinCorreo & Mid(Pdfs(i), 1, 9) & ":" & "error al enviar correo" & ":" & OrdenFecha(0).ToString & vbCrLf
                            opr_pedido.ActualizarEstadoPedido(CInt(OrdenFecha(0).ToString), 6)
                            g_opr_usuario.CargarTransaccion(g_str_login, "ENVIO CORREO PACIENTE", "PEDIDO=" & OrdenFecha(0).ToString, g_sng_user, OrdenFecha(0).ToString, "", "")
                        End If
                    Else
                        SinCorreo = SinCorreo & Mid(Pdfs(i), 1, 9) & ":" & "orden sin cancelar" & ":" & OrdenFecha(0).ToString & vbCrLf
                        SinEnviar = SinEnviar
                    End If
                Else
                    Dim vFileName As String = Environment.CurrentDirectory & "\" & g_pathFolder & "\" & Pdfs(i)
                    texto = "Agradecemos la confianza depositada en " & g_Titulo & vbCrLf & vbCrLf & "Adjunto encontrara los resultados de los examenes de laboratorio." & vbCrLf & "Correo enviado automaticamente, por favor no responda." & vbCrLf & "Powered by TRUESOLUTIONS 2019"
                    'texto = "Señor(a) Paciente y/o Doctor Md. Tratante" & vbCrLf & vbCrLf & "Reciba un cordial saludo de " & g_Titulo & vbCrLf & "Adjunto se encuentran los resultados del Sr(a) Paciente atendido en nuestro Laboratorio." & vbCrLf & vbCrLf & "Agradecemos su confianza." & vbCrLf & vbCrLf & "Atte." & vbCrLf & "Lcda. Rosa Mercedes Lino García" & vbCrLf & "Lcdo. José Zambrano Murillo" & vbCrLf & "LABORATORISTAS CLÍNICOS"
                    ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")

                    If opr_mail.EnviaCorreo(enviopara, "RESULTADOS EXAMENES", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), vFileName, ParamCorreo(5)) Then
                        EnviadosOk = EnviadosOk + 1
                        SinCorreo = SinCorreo & Mid(Pdfs(i), 1, 9) & ":" & "correo enviado satisfactoriamente" & ":" & OrdenFecha(0).ToString & vbCrLf
                        opr_pedido.ActualizarEstadoPedido(CInt(OrdenFecha(0).ToString), 6)
                        g_opr_usuario.CargarTransaccion(g_str_login, "ENVIO CORREO PACIENTE", "PEDIDO=" & OrdenFecha(0).ToString, g_sng_user, OrdenFecha(0).ToString, "", "")
                    Else
                        SinCorreo = SinCorreo & Mid(Pdfs(i), 1, 9) & ":" & "correo electronico invalido" & ":" & OrdenFecha(0).ToString & vbCrLf
                    End If
                End If
            Else
                SinCorreo = SinCorreo & Mid(Pdfs(i), 1, 9) & ":" & "sin cuenta correo" & ":" & OrdenFecha(0).ToString & vbCrLf
                SinEnviar = SinEnviar + 1
                g_opr_usuario.CargarTransaccion(g_str_login, "ERROR ENVIO CORREO PACIENTE", "PEDIDO=" & OrdenFecha(0).ToString & " EMAIL NO VALIDO", g_sng_user, OrdenFecha(0).ToString, "", "")
            End If
            ProgressBar1.Increment(incremento)
        Next
        'recoleccion de envios de correo
        cerror = Split(SinCorreo, vbCrLf)

        SinCorreo = Nothing
        For i = 0 To UBound(cerror) - 1
            param_cerror = Split(cerror(i), ":")
            If opr_resul.ExisteRegistroErrorCorreo(CInt(param_cerror(2).ToString)) = False Then
                opr_resul.GestionaErrorCorreo(CInt(param_cerror(2).ToString), param_cerror(0), param_cerror(1), True)
            Else
                opr_resul.GestionaErrorCorreo(CInt(param_cerror(2).ToString), param_cerror(0), param_cerror(1), False)
            End If
            SinCorreo = SinCorreo & param_cerror(0).ToString & " " & param_cerror(1).ToString & vbCrLf
        Next

        ProgressBar1.Increment(incremento)
        cls_operacion.sql_desconn()
        ''SinCorreoArr = Split(SinCorreo, ",")
        MsgBox("Total ordenes seleccionadas: " & EnviadosOk + SinEnviar & vbCrLf & "Total Enviadas : " & EnviadosOk & vbCrLf & "Total sin enviar : " & SinEnviar & vbCrLf & vbCrLf & SinCorreo, MsgBoxStyle.Information, "ANALISYS")

    End Sub

    Private Sub lst_pedidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_pedidos.SelectedIndexChanged
        On Error Resume Next
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If lst_pedidos.SelectedItems.Count >= 1 And chk_multiselec.Checked Then
            btn_ImprBloque.Enabled = True
            btn_EnviaMail.Enabled = True
            'btn_EnviaMailMedico.Enabled = True
            btn_ImprTodo.Enabled = False
            btn_ImpArea.Enabled = False
            btn_whatsapp.Enabled = False
            'btn_ImpHoja.Enabled = False
        Else

            ' dts_listaPdf = opr_res.LlenaListPedidoPDF(lst_pedidos, Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 72, 10)))
            btn_ImprBloque.Enabled = False
            'btn_EnviaMail.Enabled = False
            btn_EnviaMailMedico.Enabled = False
            btn_ImprTodo.Enabled = True
            btn_ImpArea.Enabled = True
            btn_whatsapp.Enabled = True
            'btn_ImpHoja.Enabled = True

            Me.Tag = "ped_turno= " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString & "/*/ped_fecing=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(0).ToString & "/*/pac_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString & "/*/pac_fecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(4).ToString & "/*/ped_antecedentes=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(5).ToString & "/*/ped_medicacion=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(6).ToString & "/*/med_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(7).ToString & "/*/ped_nota=" & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(9).ToString) & "/*/ped_id=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & "/*/pac_usafecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(11).ToString & "/*/pac_doc=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(12).ToString & "/*/ped_orden=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(13).ToString & "/*/LAB=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(16).ToString & "/*/pac_email=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(18).ToString & "/*/servicio=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(20).ToString & "/*/email_svr=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(21).ToString & "/*/ped_tipo=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(23).ToString

            Me.llenadatos("Entrega")
            Me.Activate()
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    Private Sub btn_EnviaMailMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EnviaMailMedico.Click
        ProgressBar1.Value = 0
    End Sub

    Private Sub btn_ImpExa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpExa.Click
        Dim k As Integer = 0
        Dim j As Integer = 0
        Dim abreviaturas As String = Nothing
        Dim are_ids As String = Nothing
        Dim arreglo As String()
        Dim examenes As String = Nothing
        Dim opr_pedido As New Cls_Pedido()
        Dim tes_id As Integer
        Dim tes_padre As Integer = 0
        Dim opr_trabajo As New Cls_Trabajo()
        Dim TIENE_AB_CALC() As String
        Dim arregloIDParam As String()
        Dim numFactura As Integer

        'opr_pedido.VisualizaMensaje("Recuerde que el formato IMPRESION AREA es el unico verificable subido en la NUBE", 400)

        For k = 0 To dtv_resp.Table.Rows.Count - 1
            If (dgrd_ResPedido(k, 0) = True) Then
                abreviaturas = abreviaturas & dgrd_ResPedido(k, 5) & ","
            End If
        Next

        For k = 0 To dtv_resp.Table.Rows.Count - 1
            If (dgrd_ResPedido(k, 0) = True) Then
                are_ids = are_ids & "'" & dgrd_ResPedido(k, 14) & "',"
            End If
        Next

        If abreviaturas <> "" Then


            arreglo = Split(abreviaturas, ",")



            For j = 0 To UBound(arreglo) - 1
                tes_id = opr_pedido.LeerIdTestEquipo(Trim(arreglo(j)))
                'examenes = opr_pedido.LeerIdPadreTest(tes_id)

                'TIENE_AB_CALC = Split(opr_trabajo.LeerTieneAB(tes_id), ",")

                'If TIENE_AB_CALC(0) = 1 Or opr_trabajo.TieneParametros(tes_id) > 1 Then
                '    arregloIDParam = Split(opr_trabajo.LeeIdParametros(tes_id, TIENE_AB_CALC(0)), ",")

                'End If
                examenes = examenes & tes_id & ","      '''opr_trabajo.TieneParametros(tes_padre)

            Next
            examenes = Mid(examenes, 1, Len(examenes) - 1)
            If (lbl_pedidoD.Text = "") Then
                MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
            Else
                'frm_refer_main_form.escribemsj("INICIANDO GENERACION DE REPORTE")
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor


                If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                    If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                        MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para imprimir", MsgBoxStyle.Information, "ANALISYS")
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                        Exit Sub
                    End If
                End If

                If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                    If MsgBox("La orden ya fue impresa, desea imprimirla nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                        Exit Sub
                    End If
                End If

                'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
                If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                    opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
                End If
                'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
                Dim dts_operacion As New DataSet()
                Dim cls_operacion As New Cls_Conexion()
                Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
                cls_operacion.sql_conectar()
                'frm_refer_main_form.escribemsj("CONSULTANDO TEST...")
                'Este select sirve para extraer los datos del los test con equipos
                'OJO: el primer select trae el rango como resultado2, esto ocurre, porque los campos son blob, y da un problema de casting
                'con los otros select en la columna resultado2. Los otros dos select que son parte del union, estos otros select si traen el resultado2,
                'en el 1er select resultado1 trae los resultados, en el 2do y 3ero el campo resultado2 trae los resultados
                'En el campo TIPO, trae a donde pertenece el dato:
                '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
                '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
                '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 

                Dim padres As String
                Dim opr_resul As New Cls_Resultado()
                Dim str_Areas As String
                Dim opr_user As New Cls_Usuario()
                Dim arr_datos As New ArrayList()
                Dim arr_nombre As New ArrayList()
                Dim int_i As Integer = 0
                Dim tim_id As Integer = 0

                Dim NotaArea As String = Nothing
                Dim g_validadorID As String = Nothing
                Dim g_validador As String = Nothing

                Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
                Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

                Dim str_Sql As String = Nothing
                Dim archivos As String = Nothing
                Dim archivoQR As String = Nothing

                'g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
                'g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
                'Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
                'Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)





                opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
                For int_i = 0 To arr_datos.Count - 1
                    str_Areas = str_Areas & arr_datos(int_i) & ","
                Next
                Dim x, i As Short
                Dim areas() As String
                Dim str_aux As String = "and ("
                areas = Split(str_Areas, ",")
                x = UBound(areas)
                'en caso de que exista areas a donde consultar
                If x > 0 Then
                    For i = 0 To (x - 1)
                        If i = 0 Then
                            str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                        Else
                            str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                        End If
                    Next
                    str_aux = str_aux & " ) "
                End If

                Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")

                str_Sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
                    "FROM pedido, ptohistograma " & _
                    "where pedido.ped_id = ptohistograma.ped_id  " & _
                    "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                Dim dts_histograma As New DataSet()
                Dim str_his As String = "NOHISTOGRAMA"


                archivos = opr_res.ConsultaPathFiles(str_Sql)

                If archivos <> "" Then

                    Dim tramaTXT As String
                    Dim NombreArchivo As String


                    tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSMS")
                    DiffimageLSMS.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSMS", NombreArchivo)
                    opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSMS", NombreArchivo)
                    tramaTXT = ""

                    ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSHS")
                    ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSHS", NombreArchivo)
                    ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSHS", NombreArchivo)
                    ''tramaTXT = ""

                    ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageHSMS")
                    ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageHSMS", NombreArchivo)
                    ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageHSMS", NombreArchivo)
                    ''tramaTXT = ""


                    'tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageBASO")
                    'DiffimageBASO.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageBASO", NombreArchivo)
                    'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageBASO", NombreArchivo)
                    'tramaTXT = ""

                    'tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "WBCImage")
                    'WBCImage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "WBCImage", NombreArchivo)
                    'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "WBCImage", NombreArchivo)
                    'tramaTXT = ""

                    'tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "RBCimage")
                    'RBCimage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "RBCimage", NombreArchivo)
                    'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "RBCimage", NombreArchivo)
                    'tramaTXT = ""

                    'tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "PLTimage")
                    'PLTimage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "PLTimage", NombreArchivo)
                    'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "PLTimage", NombreArchivo)
                    'tramaTXT = ""

                    tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "WBCimage")

                    'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
                    Dim byteArrayWBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                    Dim imageWBC = convertbytetoimage(byteArrayWBC) 'Using Functions To Make the code tidier
                    NombreArchivo = "WBCimage.gif"
                    opr_resul.GuardarImagen(CInt(orden), "WBCimage", NombreArchivo)
                    tramaTXT = ""


                    tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "WBCimage")

                    'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
                    Dim byteArrayRBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                    Dim imageRBC = convertbytetoimage(byteArrayRBC) 'Using Functions To Make the code tidier
                    NombreArchivo = "RBCimage.gif"
                    opr_resul.GuardarImagen(CInt(orden), "RBCimage", NombreArchivo)
                    tramaTXT = ""


                    tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "PLTimage")

                    'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
                    Dim byteArrayPLT = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                    Dim image = convertbytetoimage(byteArrayPLT) 'Using Functions To Make the code tidier
                    NombreArchivo = "PLTimage.gif"
                    opr_resul.GuardarImagen(CInt(orden), "PLTimage", NombreArchivo)
                    tramaTXT = ""




                    str_Sql = "SELECT  pedido.PED_ID, file_WBCimage, file_RBCimage, file_PLTimage " & _
                    "FROM pedido, ptohistograma " & _
                    "where pedido.ped_id = ptohistograma.ped_id  " & _
                    "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                    archivos = opr_res.ConsultaPathFilesImg(str_Sql)
                    dts_histograma = ReturnDataSet(archivos, byteArrayWBC, byteArrayRBC, byteArrayPLT)
                End If

                If dts_histograma.Tables.Count >= 1 Then
                    str_his = "HISTOGRAMA"
                Else
                    str_his = "NOHISTOGRAMA"
                End If



                archivoQR = Nothing

                '' '' '' ''******** CONSULTO SI TIENE QR ******
                str_Sql = "SELECT  pedido.PED_ID, img_base64 " & _
                   "FROM pedido, ptoImagen " & _
                   "where pedido.ped_id = ptoImagen.ped_id  " & _
                   "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.img_nombre  = 'QR'"

                Dim dts_imagen As New DataSet()
                Dim str_img As String = "NOIMAGEN"

                archivoQR = opr_res.ConsultaPathFilesImagenQR(str_Sql)


                If archivoQR <> "" Then
                    archivos = Nothing
                    Dim tramaTXT As String
                    Dim NombreArchivo As String


                    tramaTXT = opr_resul.ConsultaImagen(CInt(lbl_pedidoD.Text), "QR")
                    Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "", NombreArchivo)
                    opr_resul.GuardarImagenOcupacional(CInt(lbl_pedidoD.Text), "QR", NombreArchivo)
                    tramaTXT = ""

                    str_Sql = "SELECT  pedido.PED_ID,  img_file " & _
                         "FROM pedido, ptoImagen " & _
                         "where pedido.ped_id = ptoImagen.ped_id  " & _
                         "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.Img_NOMBRE = 'QR'"

                    archivos = opr_res.ConsultaPathFilesImgOcupacional(str_Sql)
                    dts_imagen = ReturnDataSetOcup(archivos)
                End If

                If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                    Try
                        If dts_imagen.Tables.Count >= 1 Then
                            str_img = "IMAGEN"
                            ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                        Else
                            str_img = "NOIMAGEN"
                        End If
                    Catch
                        If IsDBNull(dts_imagen) = False Then
                            Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                                Case 0
                                    If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                        opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                    End If
                                Case 1
                                    If dts_imagen.Tables.Count >= 1 Then
                                        str_img = "IMAGEN"
                                    Else
                                        str_img = "NOIMAGEN"
                                    End If
                            End Select
                        Else
                            str_img = "NOIMAGEN"
                        End If
                    End Try
                End If


                'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA

                str_Sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                    "case when (RES_PROCESADOS.PRC_ALARMA = '*') then ('* '+ RES_PROCESADOS.PRC_RESFINAL) when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, " & _
                    "case when (RES_PROCESADOS.PRC_ALARMA = '*') then ('* '+ RES_PROCESADOS.PRC_RESFINAL) else case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end end AS resultado2, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                    "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                    "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                    "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                    "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
                     "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
                    "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
                    "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                             "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                             "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                             "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                             "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id " & _
                    "FROM AREA INNER JOIN (UNIDAD " & _
                    "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                    "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                    "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                    "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                    "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO  " & _
                    "WHERE TEST_RESULTADO.RES_ID <>1 AND RES_PROCESADOS.PED_ID = '" & lbl_pedidoD.Text & "' AND RES_PROCESADOS.TES_PADRE in (" & examenes & ") AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                    "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID and test.are_id <> 83 "
                str_Sql = str_Sql & str_aux
                str_Sql = str_Sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                        "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                        "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                        "RESAB_PROCESADOS.PRC_NOTASECC AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                        "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, pedido.PED_RECIBO AS CONVENIO, " & _
                        "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                        "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' as RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id " & _
                "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
                "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
                "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
                "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
                "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' and ANTIBIOTICO.are_id in (" & Mid(are_ids, 1, Len(are_ids) - 1) & ")"

                str_Sql = str_Sql & " order by AREA.ARE_OBS, RES_PROCESADOS.TIM_ID, test.TES_ORDENIMP "

                oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
                oda_operacion.Fill(dts_operacion, "Registros")
                cls_operacion.sql_desconn()


                'Cargo grid con  valores resultadis + AB disponibles 
                Dim dts_operaAB As New DataSet()
                Dim dtt_resAB As New DataTable("RegistrosRESAB")
                Dim dtv_resAB As New DataView(dtt_resAB)


                dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


                'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")
                'Dim dts_histograma As New DataSet()

                Dim obj_reporte As New Object


                ''quemado
                lbl_LabId.Text = "1"
                '******Dependiendo si existe o no histograma va el campo Histograma
                'If carga_histograma(dts_histograma) Then str_his = "Histograma"



                If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
                    If MsgBox("Desea imprimir con formato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                        Select Case lbl_emailServicio.Text
                            Case "RENALVIDA", "MEDICGO", "VIDA"
                                obj_reporte = New rpt_entregaContinua2()

                            Case "DRA. SAMI MENDOZA"
                                obj_reporte = New rpt_entregaContinua3()

                            Case "MEDES"
                                obj_reporte = New rpt_entregaContinua4()

                            Case "CEMEDEFA"
                                obj_reporte = New rpt_entregaContinua5()

                            Case "MUNDO"
                                obj_reporte = New rpt_entregaContinua6()

                            Case "SANAMEDIC"
                                obj_reporte = New rpt_entregaContinua7()

                            Case "FLORESMED"
                                obj_reporte = New rpt_entregaContinua8()

                            Case "ESENCIALMEDIC"
                                obj_reporte = New rpt_entregaContinua9()

                            Case "BODYCORP"
                                obj_reporte = New rpt_entregaContinua10()

                            Case "ODMEDIC"
                                obj_reporte = New rpt_entregaContinua11()

                            Case Else
                                obj_reporte = New rpt_entregaContinua()
                        End Select
                    Else
                        obj_reporte = New rpt_entregaContinua_v()
                    End If
                Else
                    Select Case lbl_emailServicio.Text
                        Case "RENALVIDA", "MEDICGO", "VIDA"
                            obj_reporte = New rpt_entregaContinua2()

                        Case "DRA. SAMI MENDOZA"
                            obj_reporte = New rpt_entregaContinua3()

                        Case "MEDES"
                            obj_reporte = New rpt_entregaContinua4()

                        Case "CEMEDEFA"
                            obj_reporte = New rpt_entregaContinua5()

                        Case "MUNDO"
                            obj_reporte = New rpt_entregaContinua6()

                        Case "SANAMEDIC"
                            obj_reporte = New rpt_entregaContinua7()

                        Case "FLORESMED"
                            obj_reporte = New rpt_entregaContinua8()

                        Case "ESENCIALMEDIC"
                            obj_reporte = New rpt_entregaContinua9()

                        Case "BODYCORP"
                            obj_reporte = New rpt_entregaContinua10()

                        Case "ODMEDIC"
                            obj_reporte = New rpt_entregaContinua11()

                        Case Else
                            obj_reporte = New rpt_entregaContinua()
                    End Select
                End If

                Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
                frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                frm_MDIChild.Text = "Emision de Resultados"
                frm_refer_main_form.Crea_formulario(frm_MDIChild)
                '(*)End Select
                'frm_refer_main_form.escribemsj("DISPONIBLE")
                Me.Cursor = System.Windows.Forms.Cursors.Default
                g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME POR EMAMEN", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")
            End If
        Else
            MsgBox("No ha seleccionado ningun examen", MsgBoxStyle.Information, "ANALISYS")
        End If
    End Sub

    Private Sub dgrd_ResPedido_CurrentCellChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If System.Configuration.ConfigurationSettings.AppSettings("VerHistograma") = True Then
            'If dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 18) = 6 Or dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 18) = 8 Or dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 18) = 7 Then
            btn_Histograma.Enabled = True
        Else
            btn_Histograma.Enabled = False
        End If
        'Else
        'btn_Histograma.Enabled = False
        'End If



        'If dgrd_ResPedido.CurrentCell.ToString = dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 0) Then

        '' ''Dim dgc_celda As DataGridCell
        '' ''Dim NotaExamen As String = ""
        '' ''Dim NotaArea As String = ""
        '' ''Dim tes_padre As Integer
        '' ''Dim opr_pedido As New Cls_Pedido()


        '' ''dgc_celda.ColumnNumber = 6
        '' ''dgc_celda.RowNumber = dgrd_ResPedido.CurrentCell.RowNumber
        '' ''dgrd_ResPedido.CurrentCell = dgc_celda
        '' ''dgrd_ResPedido.Select(dgrd_ResPedido.CurrentCell.RowNumber)

        ' '' ''RFN
        '' ''dgrd_ResPedido.CaptionText = "RESULTADOS DISPONIBLES:          " & dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 1).ToString()
        ' '' ''lbl_nota_exa.Text = dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString()
        '' ''lbl_NotaSecc.Text = dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 1).ToString()


        '' ''tes_padre = Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 13).ToString())


        ' '' ''NotaExamen = opr_res.LeerNotaExamen(CInt(lbl_pedidoD.Text), tes_id, 1)

        '' ''NotaArea = opr_res.LeerNotaArea(CInt(lbl_pedidoD.Text), tes_padre, 1)

        '' ''If NotaArea <> "" Then
        '' ''    txt_notaArea.Text = Trim(NotaArea)
        '' ''Else
        '' ''    txt_notaArea.Text = ""
        '' ''End If

    End Sub


    Private Sub btn_ImpHoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim k As Integer = 0
        Dim j As Integer = 0
        Dim are_ids As String = Nothing
        Dim arreglo As String()
        Dim examenes As String = Nothing
        Dim opr_pedido As New Cls_Pedido()
        Dim tes_id As Integer
        Dim tes_padre As Integer = 0
        Dim opr_trabajo As New Cls_Trabajo()
        Dim TIENE_AB_CALC() As String
        Dim arregloIDParam As String()
        Dim numFactura As Integer
        Dim sw As Boolean = False
        Dim str_his As String

        For k = 0 To dtv_resp.Table.Rows.Count - 1
            If (dgrd_ResPedido(k, 13) = 400114) Then
                sw = True
            End If
        Next

        For k = 0 To dtv_resp.Table.Rows.Count - 1
            If (dgrd_ResPedido(k, 13) = 400114) Then
                are_ids = are_ids & "'" & dgrd_ResPedido(k, 14) & "',"
            End If
        Next

        If sw Then
            If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                    MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para imprimir", MsgBoxStyle.Information, "ANALISYS")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If


            If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
            End If

            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            cls_operacion.sql_conectar()

            Dim padres As String
            Dim opr_resul As New Cls_Resultado()
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            Dim tim_id As Integer = 0

            Dim NotaArea As String = Nothing
            Dim g_validadorID As String = Nothing
            Dim g_validador As String = Nothing

            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            Dim str_Sql As String = Nothing
            Dim archivos As String = Nothing



            opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
            For int_i = 0 To arr_datos.Count - 1
                str_Areas = str_Areas & arr_datos(int_i) & ","
            Next
            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If



            'If dts_histograma.Tables.Count >= 1 Then
            'str_his = "HISTOGRAMA"
            'Else
            str_his = "NOHISTOGRAMA"
            'End If
            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA
            Dim resGP As String = opr_pedido.LeerParamGrupoSanguineo(400114)

            str_Sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                    "'" & resGP & "' AS resultado1, " & _
                 "'" & resGP & "' AS resultado2, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
                "'" & g_invitado & "' AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
                "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
                "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                         "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                         "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                         "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                         "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
            "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else '' end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono  " & _
                "FROM AREA INNER JOIN (UNIDAD " & _
                "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO  " & _
                "WHERE RES_PROCESADOS.PED_ID = '" & lbl_pedidoD.Text & "' AND RES_PROCESADOS.TES_PADRE in (400114) AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID "
            str_Sql = str_Sql & str_aux
            str_Sql = str_Sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                    "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                    "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                    "'' AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                    "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, pedido.PED_RECIBO AS CONVENIO, " & _
                    "'" & g_invitado & "'AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                    "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' as RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono  " & _
            "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
            "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
            "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
            "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
            "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' and ANTIBIOTICO.are_id in (" & Mid(are_ids, 1, Len(are_ids) - 1) & ")"

            str_Sql = str_Sql & " order by AREA.ARE_OBS, RES_PROCESADOS.TIM_ID, test.TES_ORDENIMP "

            oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")
            cls_operacion.sql_desconn()


            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


            'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")
            Dim dts_histograma As New DataSet()

            Dim obj_reporte As New Object


            ''quemado
            lbl_LabId.Text = "1"
            '******Dependiendo si existe o no histograma va el campo Histograma
            'If carga_histograma(dts_histograma) Then str_his = "Histograma"



            obj_reporte = New rpt_entregaCarnet()


            Dim frm_MDIChild As New Frm_reportes(str_his, "", obj_reporte, dts_operacion, dts_histograma, dts_histograma, dts_operaAB, True, 1)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Emision de Resultados"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)
            '(*)End Select
            'frm_refer_main_form.escribemsj("DISPONIBLE")
            Me.Cursor = System.Windows.Forms.Cursors.Default
            g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME POR EMAMEN", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")
        Else
            opr_pedido.VisualizaMensaje("Esta orden no posee CARNET de grupo sanguineo", g_tiempo)
            Exit Sub
        End If

    End Sub

    Private Sub btn_whatsapp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_whatsapp.Click

        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ninguna orden", MsgBoxStyle.Information, "ANALISYS")
        Else
            Dim numFactura As Integer
            Dim numT As Integer = 0
            Dim i As Integer = 0
            Dim DatosPedidos As String = Nothing
            Dim DatosPDFS As String = Nothing
            Dim Pedidos As String()
            Dim Pdfs As String()
            Dim DatosEdadPdf As String = Nothing
            Dim EdadPdf As String()
            Dim OrdenFecha As String()
            Dim OrdenPdf As String()
            Dim nombrePdf As String = Nothing
            Dim opr_pedido As New Cls_Pedido()
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            Dim str_sql As String = Nothing
            Dim dts_histograma As New DataSet()
            Dim dts_imagen As New DataSet()
            Dim str_his As String = "NOHISTOGRAMA"
            Dim str_img As String = "NOIMAGEN"
            Dim obj_reporte As New Object

            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                    MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para enviar", MsgBoxStyle.Information, "ANALISYS")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If

            If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                If MsgBox("La orden ya fue impresa, desea enviarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    Exit Sub
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                End If
            End If


            ''''
            DatosPedidos = DatosPedidos & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 72, 10)) & "," & Format(Now, "yyyy-") & Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 4, 2) & "-" & Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 6, 2) & "|"
            DatosPDFS = DatosPDFS & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 4, 10)) & "-" & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 15, 50)) & ".pdf" & "|"
            DatosEdadPdf = DatosEdadPdf & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 130, Len(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex))))

            Pedidos = Split(DatosPedidos, "|")
            Pdfs = Split(DatosPDFS, "|")
            EdadPdf = Split(DatosEdadPdf, "|")

            cls_operacion.sql_conectar()

            Dim incremento As Integer = 0
            incremento = 100 / UBound(Pedidos) - 1

            For i = 0 To UBound(Pedidos) - 1
                dts_operacion.Clear()


                OrdenFecha = Split(Pedidos(i), ",")
                OrdenPdf = Split(Pdfs(i), "-")
                '''''''AQUI GENERO EL QUERY CON LOS DATOS DE CADA PEDIDO
                str_sql = opr_pedido.devuelvePedidosBloque(Me, OrdenPdf(0), OrdenFecha(0), CDate(Mid(EdadPdf(i), 1, 19)), dts_histograma, dts_imagen)

                If dts_histograma.Tables.Count >= 1 Then
                    str_his = "HISTOGRAMA"
                Else
                    str_his = "NOHISTOGRAMA"
                End If


                If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                    Try
                        If dts_imagen.Tables.Count >= 1 Then
                            str_img = "IMAGEN"
                            ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                        Else
                            str_img = "NOIMAGEN"
                        End If
                    Catch
                        If IsDBNull(dts_imagen) = False Then
                            Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                                Case 0
                                    If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                        opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                    End If
                                Case 1
                                    If dts_imagen.Tables.Count >= 1 Then
                                        str_img = "IMAGEN"
                                    Else
                                        str_img = "NOIMAGEN"
                                    End If
                            End Select
                        Else
                            str_img = "NOIMAGEN"
                        End If
                    End Try
                End If

                'dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(OrdenFecha(i)), tes_padre)

                oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
                oda_operacion.Fill(dts_operacion, "Registros")

                obj_reporte = New rpt_entregaContinua()


                If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
                    If MsgBox("Desea imprimir con formato ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                        Select Case lbl_emailServicio.Text
                            Case "RENALVIDA", "MEDICGO", "VIDA"
                                obj_reporte = New rpt_entregaresultados2()

                            Case "DRA. SAMI MENDOZA"
                                obj_reporte = New rpt_entregaresultados3()

                            Case "MEDES"
                                obj_reporte = New rpt_entregaresultados4()

                            Case "CEMEDEFA"
                                obj_reporte = New rpt_entregaresultados5()

                            Case "MUNDO"
                                obj_reporte = New rpt_entregaresultados6()

                            Case "SANAMEDIC"
                                obj_reporte = New rpt_entregaresultados7()

                            Case "FLORESMED"
                                obj_reporte = New rpt_entregaresultados8()

                            Case "ESENCIALMEDIC"
                                obj_reporte = New rpt_entregaresultados9()

                            Case "BODYCORP"
                                obj_reporte = New rpt_entregaresultados10()

                            Case "ODMEDIC"
                                obj_reporte = New rpt_entregaresultados11()

                            Case Else
                                obj_reporte = New rpt_entregaresultados()
                        End Select

                    Else
                        obj_reporte = New rpt_entregaresultados_v()
                    End If
                Else
                    Select Case lbl_emailServicio.Text
                        Case "RENALVIDA", "MEDICGO", "VIDA"
                            obj_reporte = New rpt_entregaresultados2()

                        Case "DRA. SAMI MENDOZA"
                            obj_reporte = New rpt_entregaresultados3()

                        Case "MEDES"
                            obj_reporte = New rpt_entregaresultados4()

                        Case "CEMEDEFA"
                            obj_reporte = New rpt_entregaresultados5()

                        Case "MUNDO"
                            obj_reporte = New rpt_entregaresultados6()

                        Case "SANAMEDIC"
                            obj_reporte = New rpt_entregaresultados7()

                        Case "FLORESMED"
                            obj_reporte = New rpt_entregaresultados8()

                        Case "ESENCIALMEDIC"
                            obj_reporte = New rpt_entregaresultados9()

                        Case "BODYCORP"
                            obj_reporte = New rpt_entregaresultados10()

                        Case "ODMEDIC"
                            obj_reporte = New rpt_entregaresultados11()

                        Case Else
                            obj_reporte = New rpt_entregaresultados()
                    End Select
                End If



                Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 0)

                opr_pdf.ExportToPDF(obj_reporte, Pdfs(i), g_pathFolder)
            Next
            ''''

            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim msg As String = Nothing
            Dim telefono As String = Nothing
            Dim vFileName As String = Nothing
            vFileName = Environment.CurrentDirectory & "\" & g_pathFolder



            msg = "Ingrese el numero telefonico del destinatario" & Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 4).ToString())

            'telefono = InputBox(msg, "ANALISYS")

            Dim myValue As String = InputBox(msg, "ANALISYS", opr_pedido.LeerTelefono(Trim(lbl_ci.Text)))

            If String.IsNullOrEmpty(myValue) Then
                'MessageBox.Show("Se cancelo el Inputbox")
                Return
            Else
                Dim Wmsg As String
                Wmsg = "Estimado(a)%20paciente%20" & Replace(lbl_PacienteD.Text, " ", "%20") & "%20se%20adjunta%20los%20resultados%20del%20examen%20solicitado.%0ASaludos.%0A" & _
                    Replace(g_Titulo, " ", "%20") & "%20Agradece%20su%20confianza"
                '&text=''
                System.Diagnostics.Process.Start("https://wa.me/593" & Mid(myValue, 2, 9) & "?text=" & Wmsg)
                'System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(myValue, 2, 9))
                System.Diagnostics.Process.Start("explorer.exe", vFileName)
            End If

        End If

        'https://web.whatsapp.com/send?phone=593958756520
        'https://web.whatsapp.com/send?phone=593968510061
    End Sub

    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function




    ' ''Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    ' ''    Me.Tag = ""
    ' ''    Dim frm_MDIChild As New frm_WebChat()
    ' ''    frm_MDIChild.frm_refer_main_form = Me.ParentForm
    ' ''    frm_MDIChild.ShowDialog(Me.ParentForm)
    ' ''End Sub





    Private Sub cmb_Conve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Conve.SelectedIndexChanged
        actualizaConv()
    End Sub

    Private Sub actualizaConv()
        Dim convenio As String

        convenio = Replace(Replace(cmb_Conve.Text, " ", ""), "/", ",")

        lst_pedidos.Items.Clear()
        'dts_lista.Clear()
        dts_lista = opr_res.LlenaListPedidoConvenio(lst_pedidos, Format(dtp_fi.Value, "dd/MM/yyyy"), Format(dtp_ff.Value, "dd/MM/yyyy"), 0, 2, "TODOS", convenio, 0)

    End Sub






    Private Sub btn_impEmcabezado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim k As Integer = 0
        Dim j As Integer = 0
        Dim abreviaturas As String = Nothing
        Dim are_ids As String = Nothing
        Dim arreglo As String()
        Dim examenes As String = Nothing
        Dim opr_pedido As New Cls_Pedido()
        Dim tes_id As Integer
        Dim tes_padre As Integer = 0
        Dim opr_trabajo As New Cls_Trabajo()
        Dim TIENE_AB_CALC() As String
        Dim arregloIDParam As String()
        Dim numFactura As Integer

        For k = 0 To dtv_resp.Table.Rows.Count - 1
            If (dgrd_ResPedido(k, 0) = True) Then
                are_ids = are_ids & "'" & dgrd_ResPedido(k, 14) & "',"
            End If
        Next



        If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
            If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para imprimir", MsgBoxStyle.Information, "ANALISYS")
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If
        End If

        If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
            If MsgBox("La orden ya fue impresa, desea imprimirla nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If
        End If

        'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
        If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
            opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
        End If
        'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
        Dim dts_operacion As New DataSet()
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        'frm_refer_main_form.escribemsj("CONSULTANDO TEST...")
        'Este select sirve para extraer los datos del los test con equipos
        'OJO: el primer select trae el rango como resultado2, esto ocurre, porque los campos son blob, y da un problema de casting
        'con los otros select en la columna resultado2. Los otros dos select que son parte del union, estos otros select si traen el resultado2,
        'en el 1er select resultado1 trae los resultados, en el 2do y 3ero el campo resultado2 trae los resultados
        'En el campo TIPO, trae a donde pertenece el dato:
        '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
        '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
        '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 

        Dim padres As String
        Dim opr_resul As New Cls_Resultado()
        Dim str_Areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0
        Dim tim_id As Integer = 0

        Dim NotaArea As String = Nothing
        Dim g_validadorID As String = Nothing
        Dim g_validador As String = Nothing

        Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
        Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

        Dim str_Sql As String = Nothing
        Dim archivos As String = Nothing

        opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
        For int_i = 0 To arr_datos.Count - 1
            str_Areas = str_Areas & arr_datos(int_i) & ","
        Next
        Dim x, i As Short
        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_Areas, ",")
        x = UBound(areas)
        'en caso de que exista areas a donde consultar
        If x > 0 Then
            For i = 0 To (x - 1)
                If i = 0 Then
                    str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If


        Dim dts_histograma As New DataSet()
        Dim str_his As String = "NOHISTOGRAMA"


        If dts_histograma.Tables.Count >= 1 Then
            str_his = "HISTOGRAMA"
        Else
            str_his = "NOHISTOGRAMA"
        End If
        'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA

        str_Sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
     "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, " & _
     "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end AS resultado2, RES_PROCESADOS.PRC_ALARMA as Alarma, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
     "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
     "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
     "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
     "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
     "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
     "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
     "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
         "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
         "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
         "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
         "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
         "when len(PEDIDO.PED_TURNO) = 5 then('' + convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
 "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono  " & _
     "FROM AREA INNER JOIN (UNIDAD " & _
     "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
     "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
     "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
     "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
     "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO " & _
         "WHERE RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
     "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID "
        str_Sql = str_Sql & str_aux
        str_Sql = str_Sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2,'' as Alarma, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "'' AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, pedido.PED_RECIBO AS CONVENIO, " & _
                "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' as RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono  " & _
        "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
        "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
        "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
        "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
        "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "

        str_Sql = str_Sql & " order by AREA.ARE_OBS, test.TES_ORDENIMP, RES_PROCESADOS.TIM_ID "

        oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        cls_operacion.sql_desconn()


        'Cargo grid con  valores resultadis + AB disponibles 
        Dim dts_operaAB As New DataSet()
        Dim dtt_resAB As New DataTable("RegistrosRESAB")
        Dim dtv_resAB As New DataView(dtt_resAB)


        dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


        Dim obj_reporte As New Object
        lbl_LabId.Text = "1"


        obj_reporte = New rpt_entregaresultadosHOJA()

        'If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
        '    If MsgBox("Desea imprimir con formato 1?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
        '        obj_reporte = New rpt_entregaresultadosHOJA()
        '    Else
        '        obj_reporte = New rpt_entregaresultadosHOJA2()
        '    End If
        'Else
        '    obj_reporte = New rpt_entregaresultadosHOJA()
        'End If


        Dim frm_MDIChild As New Frm_reportes(str_his, "", obj_reporte, dts_operacion, dts_histograma, dts_histograma, dts_operaAB, True, 1)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Emision de Resultados"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        '(*)End Select
        'frm_refer_main_form.escribemsj("DISPONIBLE")
        Me.Cursor = System.Windows.Forms.Cursors.Default
        g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME EMCABEZADO HOJA", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tramaTXT As String
        Dim NombreArchivo As String


        tramaTXT = opr_resul.ConsultaImagen(CInt(lbl_pedidoD.Text), "Audiometria")
        Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "", NombreArchivo)
        opr_resul.GuardarImagenOcupacional(CInt(lbl_pedidoD.Text), "Audiometria", NombreArchivo)
        tramaTXT = ""
    End Sub


    Private Sub dgrd_ResPedido_CurrentCellChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_ResPedido.CurrentCellChanged
        Dim opr_pdf As New Cls_ToPdf()
        If dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 15) = 1 Then
            If MsgBox(Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 6)) & " desea visualizar el archivo cargado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                opr_pdf.AbreProcesoPDF(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 2), Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 6)))
            End If
        Else
            'btn_Plantilla.Enabled = False
        End If

    End Sub


    Private Sub btn_Externo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim numFactura As Integer = Nothing

        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        Else
            'frm_refer_main_form.escribemsj("INICIANDO GENERACI�N DE REPORTE")
            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim opr_pedido As New Cls_Pedido()
            '(*)funci�n no utilizada para el club de leones y PUCE por que ellos no usan facturaci�n
            'chequea que la factura del pedido se encuentre cancelada
            '(*)Select Case opr_pedido.LeerPedEstadoFactura(CInt(lbl_pedidoD.Text))
            '0 emitido, 1 abonada, 2 cancelada, 3 anulada
            '(*)Case 0, 1
            '(*)MsgBox("El pedido no tiene cancelado sus valores", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 3
            '(*)MsgBox("El pedido tiene su factura anulada, no puede continuar el proceso", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 2
            'C�digo que actualiza el campo ped_estado a 4 --> Pedido impreso y entregado

            If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) <> 2 Then
                    MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para imprimir", MsgBoxStyle.Information, "ANALISYS")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If
            If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                If MsgBox("La orden ya fue impresa, desea imprimirla nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If

            'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
            If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
            End If
            'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            cls_operacion.sql_conectar()
            'frm_refer_main_form.escribemsj("CONSULTANDO TEST...")
            'Este select sirve para extraer los datos del los test con equipos
            'OJO: el primer select trae el rango como resultado2, esto ocurre, porque los campos son blob, y da un problema de casting
            'con los otros select en la columna resultado2. Los otros dos select que son parte del union, estos otros select si traen el resultado2,
            'en el 1er select resultado1 trae los resultados, en el 2do y 3ero el campo resultado2 trae los resultados
            'En el campo TIPO, trae a donde pertenece el dato:
            '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
            '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
            '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 


            Dim opr_resul As New Cls_Resultado()
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            Dim tim_id As Integer = 0
            Dim tes_padre As Integer = 0
            Dim NotaArea As String = Nothing
            Dim g_validadorID As String = Nothing
            Dim g_validador As String = Nothing

            Dim Numorden As String
            Dim NumPedido As Integer
            Dim archivos As String = Nothing
            Dim archivoQR As String = Nothing

            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            'g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
            'g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
            'Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            'Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            ''tim_id = Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 21).ToString())
            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 4).ToString()), CInt(lbl_pedidoD.Text))



            opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
            For int_i = 0 To arr_datos.Count - 1
                str_Areas = str_Areas & arr_datos(int_i) & ","
            Next
            Dim str_sql As String = Nothing
            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If

            Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")

            str_sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

            Dim dts_histograma As New DataSet()
            Dim str_his As String = "NOHISTOGRAMA"


            archivos = opr_res.ConsultaPathFiles(str_sql)

            If archivos <> "" Then

                Dim tramaTXT As String
                Dim NombreArchivo As String


                'tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSMS")
                'DiffimageLSMS.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSMS", NombreArchivo)
                'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSMS", NombreArchivo)
                'tramaTXT = ""

                ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSHS")
                ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSHS", NombreArchivo)
                ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSHS", NombreArchivo)
                ''tramaTXT = ""

                ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageHSMS")
                ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageHSMS", NombreArchivo)
                ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageHSMS", NombreArchivo)
                ''tramaTXT = ""

                'tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageBASO")
                'DiffimageBASO.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageBASO", NombreArchivo)
                'opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageBASO", NombreArchivo)
                'tramaTXT = ""

                ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "WBCImage")
                ''WBCImage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "WBCImage", NombreArchivo)
                ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "WBCImage", NombreArchivo)
                ''tramaTXT = ""

                ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "RBCimage")
                ''RBCimage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "RBCimage", NombreArchivo)
                ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "RBCimage", NombreArchivo)
                ''tramaTXT = ""

                ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "PLTimage")
                ''PLTimage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "PLTimage", NombreArchivo)
                ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "PLTimage", NombreArchivo)
                ''tramaTXT = ""




                ''str_sql = "SELECT  pedido.PED_ID, File_DiffimageLSMS, File_DiffimageLSHS, File_DiffimageHSMS, File_DiffimageBASO, file_RBCimage, file_PLTimage, File_WBCimage " & _
                ''"FROM pedido, ptohistograma " & _
                ''"where pedido.ped_id = ptohistograma.ped_id  " & _
                ''"and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                'str_sql = "SELECT  pedido.PED_ID, File_DiffimageLSMS, File_DiffimageLSHS, File_DiffimageHSMS, File_DiffimageBASO, file_RBCimage, file_PLTimage, File_WBCimage " & _
                '"FROM pedido, ptohistograma " & _
                '"where pedido.ped_id = ptohistograma.ped_id  " & _
                '"and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"


                tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "WBCimage")

                'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
                Dim byteArrayWBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim imageWBC = convertbytetoimage(byteArrayWBC) 'Using Functions To Make the code tidier
                NombreArchivo = "WBCimage.gif"
                opr_resul.GuardarImagen(CInt(orden), "WBCimage", NombreArchivo)
                tramaTXT = ""


                tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "WBCimage")

                'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
                Dim byteArrayRBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim imageRBC = convertbytetoimage(byteArrayRBC) 'Using Functions To Make the code tidier
                NombreArchivo = "RBCimage.gif"
                opr_resul.GuardarImagen(CInt(orden), "RBCimage", NombreArchivo)
                tramaTXT = ""


                tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "PLTimage")

                'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
                Dim byteArrayPLT = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                Dim image = convertbytetoimage(byteArrayPLT) 'Using Functions To Make the code tidier
                NombreArchivo = "PLTimage.gif"
                opr_resul.GuardarImagen(CInt(orden), "PLTimage", NombreArchivo)
                tramaTXT = ""



                str_sql = "SELECT  pedido.PED_ID, file_WBCimage, file_RBCimage, file_PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                archivos = opr_res.ConsultaPathFilesImg(str_sql)
                dts_histograma = ReturnDataSet(archivos, byteArrayWBC, byteArrayRBC, byteArrayPLT)
            End If

            If dts_histograma.Tables.Count >= 1 Then
                str_his = "HISTOGRAMA"
            Else
                str_his = "NOHISTOGRAMA"
            End If

            Dim dts_imagen As New DataSet()
            Dim str_img As String = "NOHISTOGRAMA"

            '' '' '' ''******** CONSULTO SI TIENE QR ******
            str_sql = "SELECT  pedido.PED_ID, img_base64 " & _
               "FROM pedido, ptoImagen " & _
               "where pedido.ped_id = ptoImagen.ped_id  " & _
               "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.img_nombre  = 'QR'"

            'Dim dts_imagen As New DataSet()
            'Dim str_img As String = "NOIMAGEN"

            archivoQR = opr_res.ConsultaPathFilesImagenQR(str_sql)

            ' archivoQR = Nothing

            If archivoQR <> "" Then
                archivos = Nothing
                Dim tramaTXT As String
                Dim NombreArchivo As String


                tramaTXT = opr_resul.ConsultaImagen(CInt(lbl_pedidoD.Text), "QR")
                Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "", NombreArchivo)
                opr_resul.GuardarImagenOcupacional(CInt(lbl_pedidoD.Text), "QR", NombreArchivo)
                tramaTXT = ""

                str_sql = "SELECT  pedido.PED_ID,  img_file " & _
                     "FROM pedido, ptoImagen " & _
                     "where pedido.ped_id = ptoImagen.ped_id  " & _
                     "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.Img_NOMBRE = 'QR'"

                archivos = opr_res.ConsultaPathFilesImgOcupacional(str_sql)
                dts_imagen = ReturnDataSetOcup(archivos)
            End If

            If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                Try
                    If dts_imagen.Tables.Count >= 1 Then
                        str_img = "IMAGEN"
                        ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                    Else
                        str_img = "NOIMAGEN"
                    End If
                Catch
                    If IsDBNull(dts_imagen) = False Then
                        Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                            Case 0
                                If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                    opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                End If
                            Case 1
                                If dts_imagen.Tables.Count >= 1 Then
                                    str_his = "IMAGEN"
                                Else
                                    str_img = "NOIMAGEN"
                                End If
                        End Select
                    Else
                        str_img = "NOIMAGEN"
                    End If
                End Try
            End If



            ''" & g_invitado & "'
            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA
            str_sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end AS resultado2, RES_PROCESADOS.PRC_ALARMA as Alarma, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
                "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
                "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
                "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
            "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, '" & str_img & "' AS IMAGEN, INVITADO.invitado_id " & _
                "FROM AREA INNER JOIN (UNIDAD " & _
                "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO " & _
                    "WHERE TEST_RESULTADO.RES_ID <>1 AND RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID and test.are_id <> 83 "
            str_sql = str_sql & str_aux
            str_sql = str_sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                    "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2, '' as Alarma, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                    "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                    "'' AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                    "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, pedido.PED_RECIBO AS CONVENIO, " & _
                    "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then( convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                    "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' AS RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, '" & str_img & "' AS IMAGEN, INVITADO.invitado_id  " & _
            "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
            "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
            "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
            "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
            "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "

            str_sql = str_sql & " order by AREA.ARE_OBS, test.TES_ORDENIMP, RES_PROCESADOS.TIM_ID "

            oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)


            'oda_operacion.Fill(dts_operacion, "Registros")
            dts_operacion.Merge(dts_operacion, False, System.Data.MissingSchemaAction.Ignore)

            oda_operacion.Fill(dts_operacion, "Registros")
            cls_operacion.sql_desconn()


            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


            'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")


            Dim obj_reporte As New Object
            ''quemado
            lbl_LabId.Text = "1"

            'Dim rpt As New rpt_HistogramaInterfaz

            '******Dependiendo si existe o no histograma va el campo Histograma


            If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
                If MsgBox("Desea imprimir con formato ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                    Select Case lbl_emailServicio.Text
                        Case "RENALVIDA", "MEDICGO", "VIDA"
                            obj_reporte = New rpt_entregaresultados2()

                        Case "DRA. SAMI MENDOZA"
                            obj_reporte = New rpt_entregaresultados3()

                        Case "MEDES"
                            obj_reporte = New rpt_entregaresultados4()

                        Case "CEMEDEFA"
                            obj_reporte = New rpt_entregaresultados5()

                        Case "MUNDO"
                            obj_reporte = New rpt_entregaresultados6()

                        Case Else
                            obj_reporte = New rpt_entregaresultados()
                    End Select

                Else
                    obj_reporte = New rpt_entregaresultados()
                End If
            Else
                Select Case lbl_emailServicio.Text
                    Case "RENALVIDA", "MEDICGO", "VIDA"
                        obj_reporte = New rpt_entregaresultados2()

                    Case "DRA. SAMI MENDOZA"
                        obj_reporte = New rpt_entregaresultados3()

                    Case "MEDES"
                        obj_reporte = New rpt_entregaresultados4()

                    Case "CEMEDEFA"
                        obj_reporte = New rpt_entregaresultados5()

                    Case "MUNDO"
                        obj_reporte = New rpt_entregaresultados6()

                    Case Else
                        obj_reporte = New rpt_entregaresultados()
                End Select
            End If


            Dim frm_MDIChild As New Frm_reportes(str_his, "", obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Entrega de Resultados"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)

            '(*)End Select
            'frm_refer_main_form.escribemsj("DISPONIBLE")

            Me.Cursor = System.Windows.Forms.Cursors.Default
            g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME POR AREA", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")

        End If
    End Sub

    Private Sub lkl_track_Correo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkl_track_Correo.LinkClicked
        Dim str_sql As String
        Dim obj_reporte As New rpt_trackingCorreo()
        Dim fechaIni As Date = Format(dtp_fi.Value, "dd/MM/yyyy")
        Dim fechaFin As Date = Format(dtp_ff.Value, "dd/MM/yyyy")

        '(PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59')

        str_sql = "select correo_error.cer_orden, (paciente.PAC_APELLIDO+ ' ' + paciente.PAC_NOMBRE) as paciente, correo_error.cer_fecha, correo_error.cer_descrip, paciente.PAC_MAIL, '" & fechaIni & "' AS FECHAI, '" & fechaFin & "' AS FECHAF " & _
                  "from correo_error, pedido, paciente " & _
                  "where correo_error.ped_id = pedido.ped_id and pedido.PAC_ID = paciente.PAC_ID and " & _
                  "correo_error.cer_fecha between '" & fechaIni & " 00:00:00' and '" & fechaFin & " 23:59:59' " & _
                  "order by correo_error.cer_fecha, correo_error.cer_orden"

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , True, 0)
        frm_MDIChild.int_alto = Me.Height
        frm_MDIChild.int_ancho = Me.Width
        frm_MDIChild.Text = "TRACKING CORREO"
        frm_MDIChild.Show()

        Me.Cursor = System.Windows.Forms.Cursors.Default

        opr_pedido.VisualizaMensaje("Generando reporte", 300)
    End Sub

    Private Sub btn_whatsMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_whatsMedico.Click
        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ninguna orden", MsgBoxStyle.Information, "ANALISYS")
        Else
            Dim numFactura As Integer
            Dim numT As Integer = 0
            Dim i As Integer = 0
            Dim DatosPedidos As String = Nothing
            Dim DatosPDFS As String = Nothing
            Dim Pedidos As String()
            Dim Pdfs As String()
            Dim DatosEdadPdf As String = Nothing
            Dim EdadPdf As String()
            Dim OrdenFecha As String()
            Dim OrdenPdf As String()
            Dim nombrePdf As String = Nothing
            Dim opr_pedido As New Cls_Pedido()
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            Dim str_sql As String = Nothing
            Dim dts_histograma As New DataSet()
            Dim dts_imagen As New DataSet()
            Dim str_his As String = "NOHISTOGRAMA"
            Dim str_img As String = "NOIMAGEN"
            Dim obj_reporte As New Object

            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            If System.Configuration.ConfigurationSettings.AppSettings("ControlCobro") = True Then
                If opr_pedido.LeerEstadoFactura(CInt(lbl_pedidoD.Text), numFactura) = 0 Then
                    MsgBox("La orden aun mantiene saldo por pagar, cancele la orden para enviar", MsgBoxStyle.Information, "ANALISYS")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If

            If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                If MsgBox("La orden ya fue impresa, desea enviarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    Exit Sub
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                End If
            End If


            ''''
            DatosPedidos = DatosPedidos & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 72, 10)) & "," & Format(Now, "yyyy-") & Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 4, 2) & "-" & Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 6, 2) & "|"
            DatosPDFS = DatosPDFS & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 4, 10)) & "-" & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 15, 50)) & ".pdf" & "|"
            DatosEdadPdf = DatosEdadPdf & Trim(Mid(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex), 130, Len(lst_pedidos.Items.Item(lst_pedidos.SelectedIndex))))

            Pedidos = Split(DatosPedidos, "|")
            Pdfs = Split(DatosPDFS, "|")
            EdadPdf = Split(DatosEdadPdf, "|")

            cls_operacion.sql_conectar()

            Dim incremento As Integer = 0
            incremento = 100 / UBound(Pedidos) - 1

            For i = 0 To UBound(Pedidos) - 1
                dts_operacion.Clear()


                OrdenFecha = Split(Pedidos(i), ",")
                OrdenPdf = Split(Pdfs(i), "-")
                '''''''AQUI GENERO EL QUERY CON LOS DATOS DE CADA PEDIDO
                str_sql = opr_pedido.devuelvePedidosBloque(Me, OrdenPdf(0), OrdenFecha(0), CDate(Mid(EdadPdf(i), 1, 19)), dts_histograma, dts_imagen)

                If dts_histograma.Tables.Count >= 1 Then
                    str_his = "HISTOGRAMA"
                Else
                    str_his = "NOHISTOGRAMA"
                End If


                If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                    Try
                        If dts_imagen.Tables.Count >= 1 Then
                            str_img = "IMAGEN"
                            ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                        Else
                            str_img = "NOIMAGEN"
                        End If
                    Catch
                        If IsDBNull(dts_imagen) = False Then
                            Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                                Case 0
                                    If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                        opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                    End If
                                Case 1
                                    If dts_imagen.Tables.Count >= 1 Then
                                        str_img = "IMAGEN"
                                    Else
                                        str_img = "NOIMAGEN"
                                    End If
                            End Select
                        Else
                            str_img = "NOIMAGEN"
                        End If
                    End Try
                End If

                'dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(OrdenFecha(i)), tes_padre)

                oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
                oda_operacion.Fill(dts_operacion, "Registros")

                obj_reporte = New rpt_entregaContinua()


                If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
                    If MsgBox("Desea imprimir con formato ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                        Select Case lbl_emailServicio.Text
                            Case "RENALVIDA", "MEDICGO", "VIDA"
                                obj_reporte = New rpt_entregaresultados2()

                            Case "DRA. SAMI MENDOZA"
                                obj_reporte = New rpt_entregaresultados3()

                            Case "MEDES"
                                obj_reporte = New rpt_entregaresultados4()

                            Case "CEMEDEFA"
                                obj_reporte = New rpt_entregaresultados5()

                            Case "MUNDO"
                                obj_reporte = New rpt_entregaresultados6()

                            Case "SANAMEDIC"
                                obj_reporte = New rpt_entregaresultados7()

                            Case "FLORESMED"
                                obj_reporte = New rpt_entregaresultados8()

                            Case "ESENCIALMEDIC"
                                obj_reporte = New rpt_entregaresultados9()

                            Case "BODYCORP"
                                obj_reporte = New rpt_entregaresultados10()

                            Case "ODMEDIC"
                                obj_reporte = New rpt_entregaresultados11()

                            Case Else
                                obj_reporte = New rpt_entregaresultados()
                        End Select

                    Else
                        obj_reporte = New rpt_entregaresultados_v()
                    End If
                Else
                    Select Case lbl_emailServicio.Text
                        Case "RENALVIDA", "MEDICGO", "VIDA"
                            obj_reporte = New rpt_entregaresultados2()

                        Case "DRA. SAMI MENDOZA"
                            obj_reporte = New rpt_entregaresultados3()

                        Case "MEDES"
                            obj_reporte = New rpt_entregaresultados4()

                        Case "CEMEDEFA"
                            obj_reporte = New rpt_entregaresultados5()

                        Case "MUNDO"
                            obj_reporte = New rpt_entregaresultados6()

                        Case "SANAMEDIC"
                            obj_reporte = New rpt_entregaresultados7()

                        Case "FLORESMED"
                            obj_reporte = New rpt_entregaresultados8()

                        Case "ESENCIALMEDIC"
                            obj_reporte = New rpt_entregaresultados9()

                        Case "BODYCORP"
                            obj_reporte = New rpt_entregaresultados10()

                        Case "ODMEDIC"
                            obj_reporte = New rpt_entregaresultados11()

                        Case Else
                            obj_reporte = New rpt_entregaresultados()
                    End Select
                End If



                Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 0)

                opr_pdf.ExportToPDF(obj_reporte, Pdfs(i), g_pathFolder)
            Next
            ''''

            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim msg As String = Nothing
            Dim telefono As String = Nothing
            Dim vFileName As String = Nothing
            vFileName = Environment.CurrentDirectory & "\" & g_pathFolder



            msg = "Ingrese el numero telefonico del medico" & Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 4).ToString())

            'telefono = InputBox(msg, "ANALISYS")

            Dim myValue As String = InputBox(msg, "ANALISYS", lbl_doctorD.Text)

            If String.IsNullOrEmpty(myValue) Then
                'MessageBox.Show("Se cancelo el Inputbox")
                Return
            Else
                Dim Wmsg As String
                Wmsg = "Estimado(a)%20Doctor/a " & Replace(lbl_NameDoctor.Text, " ", "%20") & "%20se%20adjunta%20los%20resultados%20del%20examen%20solicitado%20por%20el%20Paciente%20" & Replace(lbl_PacienteD.Text, " ", "%20") & ".%20Saludos.%0A" & _
                        Replace(g_Titulo, " ", "%20") & "%20Agradece%20su%20confianza"
                '&text=''
                System.Diagnostics.Process.Start("https://wa.me/593" & Mid(myValue, 2, 9) & "?text=" & Wmsg)
                'System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(myValue, 2, 9))
                System.Diagnostics.Process.Start("explorer.exe", vFileName)
            End If

        End If

    End Sub

    
End Class