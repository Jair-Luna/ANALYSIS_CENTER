Imports System.IO
Imports System.Text
Imports System.Collections
Imports AcroPDFLib


Public Class Ingreso_Aspirantes
    Inherits System.Windows.Forms.Form
    Dim str_aspirante, str_ascenso As String
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_convenio As System.Windows.Forms.ComboBox
    Private opr_pedido As New Cls_Pedido()
    Friend WithEvents lst_perfilConv As System.Windows.Forms.ListBox
    Private opr_convenio As New Cls_Convenio()
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private opr_perfil As New Cls_Perfil()
    Public LISTATEST, aux As String
    Public ESTADOTEST As Short
    Private opr_test = New Cls_Test()
    Public dtt_pedido1 As New DataTable("RegistrosC")
    Public dts_listatest As New DataSet
    Friend WithEvents dgrd_pedidoConv As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Public dtr_fila As DataRow
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_paciente As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscaPaciente As System.Windows.Forms.Button
    Private dtv_pedido As New DataView(dtt_pedido1)
    Friend WithEvents lbl_sec As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_PacId As System.Windows.Forms.Label
    Public prioridad As String()
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_generado As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_100 As System.Windows.Forms.Label
    Friend WithEvents lbl_0 As System.Windows.Forms.Label
    Friend WithEvents btn_printetiquetas As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents grp_precarga As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion_fono As System.Windows.Forms.Label
    Friend WithEvents lbl_genero As System.Windows.Forms.Label
    Friend WithEvents lbl_fecnac As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Public turno As String = Nothing


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
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_fec As System.Windows.Forms.Label
    Friend WithEvents txt_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txt_desde As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Aspirantes))
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_desde = New System.Windows.Forms.TextBox
        Me.txt_hasta = New System.Windows.Forms.TextBox
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_fec = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_convenio = New System.Windows.Forms.ComboBox
        Me.lst_perfilConv = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgrd_pedidoConv = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_paciente = New System.Windows.Forms.TextBox
        Me.btn_buscaPaciente = New System.Windows.Forms.Button
        Me.lbl_sec = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_PacId = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lbl_generado = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_100 = New System.Windows.Forms.Label
        Me.lbl_0 = New System.Windows.Forms.Label
        Me.btn_printetiquetas = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.grp_precarga = New System.Windows.Forms.GroupBox
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.lbl_nombres = New System.Windows.Forms.Label
        Me.lbl_direccion_fono = New System.Windows.Forms.Label
        Me.lbl_genero = New System.Windows.Forms.Label
        Me.lbl_fecnac = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        CType(Me.dgrd_pedidoConv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.grp_precarga.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btn_Salir.Location = New System.Drawing.Point(346, 49)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 35)
        Me.btn_Salir.TabIndex = 9
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Enabled = False
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(267, 49)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 35)
        Me.btn_Aceptar.TabIndex = 8
        Me.btn_Aceptar.Text = "Generar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INICIA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(150, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FIN:"
        '
        'txt_desde
        '
        Me.txt_desde.Location = New System.Drawing.Point(78, 67)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(65, 20)
        Me.txt_desde.TabIndex = 6
        '
        'txt_hasta
        '
        Me.txt_hasta.Location = New System.Drawing.Point(184, 67)
        Me.txt_hasta.Name = "txt_hasta"
        Me.txt_hasta.Size = New System.Drawing.Size(61, 20)
        Me.txt_hasta.TabIndex = 7
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(78, 13)
        Me.dtp_fecha.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(91, 21)
        Me.dtp_fecha.TabIndex = 1
        '
        'lbl_fec
        '
        Me.lbl_fec.AutoSize = True
        Me.lbl_fec.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec.ForeColor = System.Drawing.Color.Black
        Me.lbl_fec.Location = New System.Drawing.Point(20, 19)
        Me.lbl_fec.Name = "lbl_fec"
        Me.lbl_fec.Size = New System.Drawing.Size(42, 13)
        Me.lbl_fec.TabIndex = 103
        Me.lbl_fec.Text = "FECHA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "TARIFA"
        '
        'cmb_convenio
        '
        Me.cmb_convenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_convenio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_convenio.Location = New System.Drawing.Point(78, 41)
        Me.cmb_convenio.Name = "cmb_convenio"
        Me.cmb_convenio.Size = New System.Drawing.Size(167, 21)
        Me.cmb_convenio.TabIndex = 105
        '
        'lst_perfilConv
        '
        Me.lst_perfilConv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_perfilConv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_perfilConv.Location = New System.Drawing.Point(77, 123)
        Me.lst_perfilConv.Name = "lst_perfilConv"
        Me.lst_perfilConv.Size = New System.Drawing.Size(291, 158)
        Me.lst_perfilConv.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "EXAMENES"
        '
        'dgrd_pedidoConv
        '
        Me.dgrd_pedidoConv.AllowDrop = True
        Me.dgrd_pedidoConv.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_pedidoConv.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_pedidoConv.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_pedidoConv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_pedidoConv.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_pedidoConv.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgrd_pedidoConv.CaptionText = "TEST SELECCIONADOS"
        Me.dgrd_pedidoConv.CausesValidation = False
        Me.dgrd_pedidoConv.DataMember = ""
        Me.dgrd_pedidoConv.FlatMode = True
        Me.dgrd_pedidoConv.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.dgrd_pedidoConv.ForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidoConv.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_pedidoConv.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_pedidoConv.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidoConv.HeaderFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_pedidoConv.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_pedidoConv.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidoConv.Location = New System.Drawing.Point(463, 78)
        Me.dgrd_pedidoConv.Name = "dgrd_pedidoConv"
        Me.dgrd_pedidoConv.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_pedidoConv.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidoConv.ReadOnly = True
        Me.dgrd_pedidoConv.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_pedidoConv.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_pedidoConv.Size = New System.Drawing.Size(152, 122)
        Me.dgrd_pedidoConv.TabIndex = 125
        Me.dgrd_pedidoConv.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgrd_pedidoConv
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "RegistrosC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "PACIENTE"
        '
        'txt_paciente
        '
        Me.txt_paciente.Location = New System.Drawing.Point(77, 92)
        Me.txt_paciente.Name = "txt_paciente"
        Me.txt_paciente.Size = New System.Drawing.Size(219, 20)
        Me.txt_paciente.TabIndex = 128
        '
        'btn_buscaPaciente
        '
        Me.btn_buscaPaciente.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_buscaPaciente.Location = New System.Drawing.Point(299, 92)
        Me.btn_buscaPaciente.Name = "btn_buscaPaciente"
        Me.btn_buscaPaciente.Size = New System.Drawing.Size(35, 19)
        Me.btn_buscaPaciente.TabIndex = 129
        Me.btn_buscaPaciente.Text = "..."
        Me.btn_buscaPaciente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_buscaPaciente.UseVisualStyleBackColor = False
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sec.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_sec.Location = New System.Drawing.Point(252, 47)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(85, 13)
        Me.lbl_sec.TabIndex = 134
        Me.lbl_sec.Text = "SECUENCIAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "PRE CARGA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.Label5)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(460, 25)
        Me.pan_barra.TabIndex = 131
        '
        'lbl_PacId
        '
        Me.lbl_PacId.AutoSize = True
        Me.lbl_PacId.Location = New System.Drawing.Point(240, 174)
        Me.lbl_PacId.Name = "lbl_PacId"
        Me.lbl_PacId.Size = New System.Drawing.Size(39, 13)
        Me.lbl_PacId.TabIndex = 135
        Me.lbl_PacId.Text = "PACID"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(99, 298)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(201, 16)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 136
        '
        'lbl_generado
        '
        Me.lbl_generado.AutoSize = True
        Me.lbl_generado.Location = New System.Drawing.Point(27, 312)
        Me.lbl_generado.Name = "lbl_generado"
        Me.lbl_generado.Size = New System.Drawing.Size(0, 13)
        Me.lbl_generado.TabIndex = 137
        '
        'lbl_100
        '
        Me.lbl_100.AutoSize = True
        Me.lbl_100.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_100.ForeColor = System.Drawing.Color.Black
        Me.lbl_100.Location = New System.Drawing.Point(300, 301)
        Me.lbl_100.Name = "lbl_100"
        Me.lbl_100.Size = New System.Drawing.Size(36, 13)
        Me.lbl_100.TabIndex = 139
        Me.lbl_100.Text = "100%"
        '
        'lbl_0
        '
        Me.lbl_0.AutoSize = True
        Me.lbl_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_0.ForeColor = System.Drawing.Color.Black
        Me.lbl_0.Location = New System.Drawing.Point(75, 298)
        Me.lbl_0.Name = "lbl_0"
        Me.lbl_0.Size = New System.Drawing.Size(24, 13)
        Me.lbl_0.TabIndex = 138
        Me.lbl_0.Text = "0%"
        '
        'btn_printetiquetas
        '
        Me.btn_printetiquetas.BackColor = System.Drawing.SystemColors.Control
        Me.btn_printetiquetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_printetiquetas.Enabled = False
        Me.btn_printetiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_printetiquetas.ForeColor = System.Drawing.Color.Black
        Me.btn_printetiquetas.Image = CType(resources.GetObject("btn_printetiquetas.Image"), System.Drawing.Image)
        Me.btn_printetiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_printetiquetas.Location = New System.Drawing.Point(187, 49)
        Me.btn_printetiquetas.Name = "btn_printetiquetas"
        Me.btn_printetiquetas.Size = New System.Drawing.Size(80, 35)
        Me.btn_printetiquetas.TabIndex = 141
        Me.btn_printetiquetas.Text = "Etiquetas"
        Me.btn_printetiquetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_printetiquetas.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.Enabled = False
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(106, 49)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 35)
        Me.btn_nuevo.TabIndex = 142
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'grp_precarga
        '
        Me.grp_precarga.Controls.Add(Me.lbl_fec)
        Me.grp_precarga.Controls.Add(Me.dtp_fecha)
        Me.grp_precarga.Controls.Add(Me.lbl_100)
        Me.grp_precarga.Controls.Add(Me.cmb_convenio)
        Me.grp_precarga.Controls.Add(Me.lbl_0)
        Me.grp_precarga.Controls.Add(Me.Label6)
        Me.grp_precarga.Controls.Add(Me.lst_perfilConv)
        Me.grp_precarga.Controls.Add(Me.ProgressBar1)
        Me.grp_precarga.Controls.Add(Me.Label3)
        Me.grp_precarga.Controls.Add(Me.lbl_sec)
        Me.grp_precarga.Controls.Add(Me.Label4)
        Me.grp_precarga.Controls.Add(Me.txt_hasta)
        Me.grp_precarga.Controls.Add(Me.txt_paciente)
        Me.grp_precarga.Controls.Add(Me.txt_desde)
        Me.grp_precarga.Controls.Add(Me.btn_buscaPaciente)
        Me.grp_precarga.Controls.Add(Me.Label1)
        Me.grp_precarga.Controls.Add(Me.Label2)
        Me.grp_precarga.Controls.Add(Me.lbl_PacId)
        Me.grp_precarga.Location = New System.Drawing.Point(30, 90)
        Me.grp_precarga.Name = "grp_precarga"
        Me.grp_precarga.Size = New System.Drawing.Size(396, 329)
        Me.grp_precarga.TabIndex = 143
        Me.grp_precarga.TabStop = False
        '
        'lbl_doc
        '
        Me.lbl_doc.AutoSize = True
        Me.lbl_doc.Location = New System.Drawing.Point(478, 262)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(41, 13)
        Me.lbl_doc.TabIndex = 144
        Me.lbl_doc.Text = "lbl_doc"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.AutoSize = True
        Me.lbl_nombres.Location = New System.Drawing.Point(481, 279)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(63, 13)
        Me.lbl_nombres.TabIndex = 145
        Me.lbl_nombres.Text = "lbl_nombres"
        '
        'lbl_direccion_fono
        '
        Me.lbl_direccion_fono.AutoSize = True
        Me.lbl_direccion_fono.Location = New System.Drawing.Point(481, 299)
        Me.lbl_direccion_fono.Name = "lbl_direccion_fono"
        Me.lbl_direccion_fono.Size = New System.Drawing.Size(93, 13)
        Me.lbl_direccion_fono.TabIndex = 146
        Me.lbl_direccion_fono.Text = "lbl_direccion_fono"
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Location = New System.Drawing.Point(481, 321)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(56, 13)
        Me.lbl_genero.TabIndex = 147
        Me.lbl_genero.Text = "lbl_genero"
        '
        'lbl_fecnac
        '
        Me.lbl_fecnac.AutoSize = True
        Me.lbl_fecnac.Location = New System.Drawing.Point(484, 338)
        Me.lbl_fecnac.Name = "lbl_fecnac"
        Me.lbl_fecnac.Size = New System.Drawing.Size(56, 13)
        Me.lbl_fecnac.TabIndex = 148
        Me.lbl_fecnac.Text = "lbl_fecnac"
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Location = New System.Drawing.Point(481, 355)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(47, 13)
        Me.lbl_edad.TabIndex = 149
        Me.lbl_edad.Text = "lbl_edad"
        '
        'Ingreso_Aspirantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(460, 458)
        Me.Controls.Add(Me.lbl_edad)
        Me.Controls.Add(Me.lbl_fecnac)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.lbl_direccion_fono)
        Me.Controls.Add(Me.lbl_nombres)
        Me.Controls.Add(Me.lbl_doc)
        Me.Controls.Add(Me.grp_precarga)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_printetiquetas)
        Me.Controls.Add(Me.lbl_generado)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.dgrd_pedidoConv)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ingreso_Aspirantes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgrd_pedidoConv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_precarga.ResumeLayout(False)
        Me.grp_precarga.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Cdigo de Formulario"
    Public frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Public fecha As Date
    Dim imageToDraw As Image
    Public SiNoFlag As Boolean = False
    Public SiNoFlagLst As Boolean = False



    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Salir.MouseEnter
        'cuando el mouse se mueve por encima del los botones del formulario
        Select Case sender.name
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_closep") Then
                    imageToDraw = CType(m_HtImages("btn_closep"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_closep.jpg")
                        m_HtImages.Add("btn_closep", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Bold)
                    sender.forecolor = Color.White
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
                    sender.BackgroundImage = imageToDraw
                End If
        End Select
    End Sub

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Salir.MouseLeave
        'cuando el mouse se pierde el enfoque del los botones del formulario
        Select Case sender.name
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_close") Then
                    imageToDraw = CType(m_HtImages("btn_close"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_close.jpg")
                        m_HtImages.Add("btn_close", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Regular)
                    sender.forecolor = Color.Black
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
                End If
        End Select
    End Sub

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub

#End Region

    Private Sub Ingreso_Aspirantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'Me.Top = (frm_refer_main_form.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main_form.mdiClient1.Width - Me.Width) / 2) + frm_refer_main_form.Pan_Menu.Width

        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "#", "cantidad", 0))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "TEST", "test", 540))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "id", "id", 0))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable("$ #,##0.00", "PRECIO UNITARIO", "precio", 170))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "tipo", "tipo", 0))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable("#", "estado", "estado", 0, , "0"))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "listatest", "listatest", 0))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable("#", "nuevo", "nuevo", 0, , "0"))
        DataGridTableStyle2.GridColumnStyles.Item(3).Alignment = HorizontalAlignment.Right
        'defino las columnasde grid
        Dim dtc_columna1 As New DataColumn("cantidad", GetType(System.Single))
        Dim dtc_columna2 As New DataColumn("test", GetType(System.String))
        Dim dtc_columna3 As New DataColumn("id", GetType(System.Int64))
        Dim dtc_columna4 As New DataColumn("precio", GetType(System.Double))
        Dim dtc_columna5 As New DataColumn("tipo", GetType(System.String))
        Dim dtc_columna6 As New DataColumn("estado", GetType(System.String))
        Dim dtc_columna7 As New DataColumn("listatest", GetType(System.String))
        Dim dtc_columna8 As New DataColumn("nuevo", GetType(System.String))
        dtt_pedido1.Columns.Add(dtc_columna1)
        dtt_pedido1.Columns.Add(dtc_columna2)
        dtt_pedido1.Columns.Add(dtc_columna3)
        dtt_pedido1.Columns.Add(dtc_columna4)
        dtt_pedido1.Columns.Add(dtc_columna5)
        dtt_pedido1.Columns.Add(dtc_columna6)
        dtt_pedido1.Columns.Add(dtc_columna7)
        dtt_pedido1.Columns.Add(dtc_columna8)
        dtv_pedido.AllowNew = False
        dtv_pedido.AllowDelete = False
        dgrd_pedidoConv.DataSource = dtv_pedido

        grp_precarga.Enabled = False

        'lleno combo prioridad con secuencias
        opr_pedido.LlenarComboPrioridad(cmb_convenio, False, True)

        prioridad = Split(cmb_convenio.Text, "/")

        opr_perfil.LlenarListaPerfil(lst_perfilConv, Trim(prioridad(0)))
        btn_nuevo.Enabled = True

    End Sub


    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click


        Dim opr_pedido As New Cls_Pedido()

        'CONDICIONES EXISTENTES EN LOS TURNOS A ELEJIR
        If Not IsNumeric(txt_desde.Text) Or Not IsNumeric(txt_hasta.Text) Then
            MsgBox("Los valores INICIO y FIN deben ser numericos.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        ElseIf txt_desde.Text = "" Or txt_hasta.Text = "" Then
            MsgBox("El campo INICIO y FIN debe tener datos.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        ElseIf CLng(txt_desde.Text) > CLng(txt_hasta.Text) Then
            MsgBox("El campo INICIO debe ser menor al campo FIN.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        ElseIf CLng(txt_hasta.Text) > CLng(prioridad(2)) Then ' valida que no exceda al limite max.
            MsgBox("El campo FIN no puede ser mayor al establecido para la secuencia selccionada.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim PAC_ID As String = lbl_PacId.Text
        Dim edad As Integer = 0
        Dim genero As String = Nothing
        Dim unidad As String = Nothing

        'If turno <> Nothing Then
        '    If turno > prioridad(2) Then
        '        MsgBox("Ud. ha excedido el numero permitido de pedidos para " & prioridad(0) & ".  Pongase en contacto con el Administrador del sistema.", MsgBoxStyle.Information, "ANALISYS")
        '        Exit Sub
        '    End If
        'End If
        If (PAC_ID <> 0) Then
            Timer1.Start()

            If CInt(Trim(txt_desde.Text)) < CInt(Trim(prioridad(1).ToString)) Or CInt(Trim(txt_hasta.Text.ToString)) < CInt(Trim(prioridad(2))) Then
                edad = opr_pedido.CalculaEdad(lbl_fecnac.Text, unidad)
                genero = Trim(lbl_genero.Text)

                opr_pedido.ingreso_convenios(PAC_ID, txt_desde.Text, txt_hasta.Text, Format(dtp_fecha.Value, "dd/MM/yyyy"), cmb_convenio.Text, dtt_pedido1, Trim(prioridad(0).ToString), ProgressBar1, lbl_generado, edad, genero)

            Else
                MsgBox("Las secuencias ingresadas no estan dentro de las secuencias configuradas, favor revise la numeracion.", MsgBoxStyle.Information, "ANALISYS")
            End If
        Else
            MsgBox("No se a seleccionado un paciente valido, consulte con el administrador del sistema.", MsgBoxStyle.Information, "ANALISYS")
        End If

        btn_Aceptar.Enabled = False
        btn_printetiquetas.Enabled = True

        grp_precarga.Enabled = False

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'cierro el formulario
        Me.Close()
    End Sub





    Private Sub lst_perfilConv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_perfilConv.Click

        opr_pedido.ActualizaPerfilGrid(Val(lst_perfilConv.Items.Item(lst_perfilConv.SelectedIndex).Substring(100, 10)), 1, LISTATEST, ESTADOTEST)
        SiNoFlagLst = False

        Dim arr_listatest() As String = Split(LISTATEST, ",")
        Dim ConvenioAux As String()
        Dim dts_listatest As DataSet
        ConvenioAux = Split(Trim(cmb_convenio.Text), "/")

        'dts_listatest = opr_test.testperfil(LISTATEST, Trim(cmb_convenio.Text))
        dts_listatest = opr_test.testperfil(LISTATEST, Trim(ConvenioAux(0)))

        Dim dtr_filaaux As DataRow

        For Each dtr_filaaux In dts_listatest.Tables("RegistrosC").Rows

            Dim dtr_fila1 As DataRow = dtt_pedido1.NewRow

            dtr_fila1(0) = 1
            dtr_fila1(1) = dtr_filaaux(1)
            dtr_fila1(2) = dtr_filaaux(2)
            dtr_fila1(3) = dtr_filaaux(3)
            dtr_fila1(4) = Trim("T".PadRight(5))
            dtr_fila1(5) = 0
            dtr_fila1(6) = dtr_fila1(3)
            dtr_fila1(7) = 1     'nuevo
            dtt_pedido1.Rows.Add(dtr_fila1)
            SiNoFlagLst = True
        Next

        If SiNoFlag And txt_paciente.Text <> "" Then
            btn_Aceptar.Enabled = True
        End If
    End Sub

    Private Sub btn_buscaPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaPaciente.Click
        'abro el formulario para seleccioanar un paciente
        Dim str_tagaux As String
        str_tagaux = Me.Tag
        Dim frm_MDIChild As New frm_Paciente3()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        Me.Tag = str_tagaux
    End Sub

    Public Sub LLena_datos_paciente_doc()
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        Dim boo_edad As Boolean = True
        'separo los campos en un arreglo
        str_campos = Split(Me.Tag, "/*/")
        'Cuando creo doctor y regreso al formulario de pedido impide que se borre datos del paciente ya ingresados
        lbl_doc.Text = ""
        lbl_nombres.Text = ""
        lbl_direccion_fono.Text = ""
        lbl_genero.Text = ""

        'recorro el arreglo
        For int_indice = 0 To UBound(str_campos)
            int_pos = InStr(str_campos(int_indice), "=")
            str_texto = str_campos(int_indice).Substring(0, int_pos - 1)
            str_valor = str_campos(int_indice).Substring(int_pos)
            'segun el nombredevuento el tag, guardo en cada unade las variables
            Select Case str_texto
                Case "pac_doc"
                    lbl_doc.Text = (str_valor)
                    ' txt_doc.Text = (str_valor)
                Case "pac_apellido"
                    lbl_nombres.Text = (str_valor)
                Case "pac_nombre"
                    lbl_nombres.Text = lbl_nombres.Text + "  " & (str_valor)
                    txt_paciente.Text = lbl_nombres.Text + "  " & (str_valor)
                Case "pac_direccion"
                    lbl_direccion_fono.Text = (str_valor)
                Case "pac_genero"
                    lbl_genero.Text = (str_valor)
                Case "pac_fono"
                    'lbl_direccion_fono.Text = lbl_direccion_fono.Text & "  /  " & (str_valor)
                Case "pac_id"
                    lbl_PacId.Text = (str_valor)
                    'lng_pac_id = (str_valor)
                Case "pac_hist_clinica"
                    'lbl_his_clinica.Text = (str_valor)

                Case "pac_grado"
                    'lbl_grado.Text = (str_valor)
                Case "pac_parentesco"
                    'lbl_fecing.Text = (str_valor)
                Case "pac_usafecnac"
                    If (str_valor) = "SI" Or (str_valor) = "1" Then
                        boo_edad = True
                    Else
                        boo_edad = True
                    End If
                Case "pac_fecnac"
                    lbl_fecnac.Text = CDate(str_valor)
                    If boo_edad = True Then
                        Dim edad As String
                        Dim fecha As Date
                        fecha = CDate(str_valor)
                        '**********
                        'funcion para calcular la edad del paciente
                        Dim y, yn As Integer
                        Dim m, mn As Integer
                        Dim d, dn As Integer
                        lbl_edad.Text = ""
                        y = Year(Now)
                        yn = Year(fecha)
                        m = Month(Now)
                        mn = Month(fecha)
                        d = Microsoft.VisualBasic.Day(Now)
                        dn = Microsoft.VisualBasic.Day(fecha)
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
                                    lbl_edad.Text = m & " meses"
                                Else
                                    lbl_edad.Text = d & " dias"
                                End If
                            Else
                                lbl_edad.Text = y & " año y " & m & " meses"
                            End If
                        Else
                            lbl_edad.Text = y & " años "
                        End If
                        '**********
                    Else
                        lbl_edad.Text = "--"
                    End If
            End Select
        Next
    End Sub


    Private Sub cmb_ped_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        prioridad = Split(cmb_convenio.Text, "/")
        lbl_sec.Text = "INICIO: " & prioridad(1) & " FIN: " & prioridad(2)

        turno = Format(opr_pedido.LeerMaxturno(prioridad(0), Format(dtp_fecha.Value, "dd/MM/yyyy"), Val(1), False), "00#")
        If turno = 0 Then
            txt_desde.Text = prioridad(1)
        Else
            ' If turno = prioridad(1) Then
            txt_desde.Text = Trim(turno + 1)
        End If
    End Sub

    Private Sub dtp_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha.ValueChanged

        prioridad = Split(cmb_convenio.Text, "/")
        lbl_sec.Text = "INICIO: " & prioridad(1) & " FIN: " & prioridad(2)

        turno = Format(opr_pedido.LeerMaxturno(prioridad(0), Format(dtp_fecha.Value, "dd/MM/yyyy"), Val(1), False), "00#")

        If turno = 0 Then
            txt_desde.Text = prioridad(1)
        Else
            ' If turno = prioridad(1) Then
            txt_desde.Text = Trim(turno + 1)
        End If
    End Sub

    Private Sub txt_paciente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_paciente.TextChanged
        If txt_paciente.Text <> "" Then
            SiNoFlag = True
            If SiNoFlagLst Then
                btn_Aceptar.Enabled = True
            Else
                btn_Aceptar.Enabled = False
            End If
        Else
            SiNoFlag = False
        End If
    End Sub



    Private Sub btn_printetiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printetiquetas.Click
        Dim pedido_grupo As String
        Dim pedido() As String
        Dim i As Integer
        Dim opr_cod As New Cls_Pedido()

        pedido_grupo = opr_cod.LeerPedidodeturno(txt_desde.Text, txt_hasta.Text, dtp_fecha.Value, Trim(Mid(cmb_convenio.Text, 1, 50)))
        Cursor.Current = Cursors.WaitCursor
        pedido = Split(pedido_grupo, ",")
        If UBound(pedido) > 0 Then
            For i = 0 To UBound(pedido) - 1
                opr_cod.imprimir_codigo(pedido(i), dtp_fecha.Value)
            Next
            MsgBox("La impresi�n de las etiquetas se ha realizado exitosamente.", MsgBoxStyle.Information, "ANALISYS")
        End If
        Cursor.Current = Cursors.Default


    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click

        txt_hasta.Text = ""
        txt_hasta.Text = ""
        cmb_convenio.SelectedIndex = 0
        txt_paciente.Text = ""
        lbl_PacId.Text = Nothing
        lst_perfilConv.ClearSelected()
        ProgressBar1.Refresh()
        lbl_generado.Text = ""

        grp_precarga.Enabled = True

    End Sub

    Private Sub cmb_convenio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_convenio.SelectedIndexChanged
        prioridad = Split(cmb_convenio.Text, "/")
        lbl_sec.Text = "INICIO: " & prioridad(1) & " FIN: " & prioridad(2)

        turno = Format(opr_pedido.LeerMaxturno(Trim(prioridad(0)), Format(dtp_fecha.Value, "dd/MM/yyyy"), Val(1), False), "000#")
        If turno = 0 Then
            txt_desde.Text = prioridad(1)
        Else
            ' If turno = prioridad(1) Then
            txt_desde.Text = Trim(turno + 1)
        End If
    End Sub
End Class
