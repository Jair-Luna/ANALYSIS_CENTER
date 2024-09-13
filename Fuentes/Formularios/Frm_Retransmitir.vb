

Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Data.Odbc
Imports IBM.Data.DB2.iSeries
Public Class Frm_Retransmitir
    Inherits System.Windows.Forms.Form
    Public frm_refer_main As Frm_Main
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
    Friend WithEvents grp_busqueda As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents grp_pruebas As System.Windows.Forms.GroupBox
    Friend WithEvents lista_pruebas As System.Windows.Forms.CheckedListBox
    Friend WithEvents grp_paciente As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grp_opciones As System.Windows.Forms.GroupBox
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents pic_min As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_hc As System.Windows.Forms.Label
    Friend WithEvents lbl_fecing As System.Windows.Forms.Label
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_todos As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_ninguno As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Retransmitir))
        Me.grp_busqueda = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.txt_buscar = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grp_pruebas = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btn_ninguno = New System.Windows.Forms.Button
        Me.btn_todos = New System.Windows.Forms.Button
        Me.lista_pruebas = New System.Windows.Forms.CheckedListBox
        Me.cmb_mes = New System.Windows.Forms.ComboBox
        Me.grp_paciente = New System.Windows.Forms.GroupBox
        Me.lbl_fecing = New System.Windows.Forms.Label
        Me.lbl_apellidos = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_hc = New System.Windows.Forms.Label
        Me.lbl_nombres = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grp_opciones = New System.Windows.Forms.GroupBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_limpiar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_icono = New System.Windows.Forms.PictureBox
        Me.pan_btn = New System.Windows.Forms.Panel
        Me.pic_min = New System.Windows.Forms.PictureBox
        Me.Pic_close = New System.Windows.Forms.PictureBox
        Me.grp_busqueda.SuspendLayout()
        Me.grp_pruebas.SuspendLayout()
        Me.grp_paciente.SuspendLayout()
        Me.grp_opciones.SuspendLayout()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_btn.SuspendLayout()
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_busqueda
        '
        Me.grp_busqueda.BackColor = System.Drawing.Color.Transparent
        Me.grp_busqueda.Controls.Add(Me.Label6)
        Me.grp_busqueda.Controls.Add(Me.Label5)
        Me.grp_busqueda.Controls.Add(Me.txt_orden)
        Me.grp_busqueda.Controls.Add(Me.btn_buscar)
        Me.grp_busqueda.Controls.Add(Me.txt_buscar)
        Me.grp_busqueda.Controls.Add(Me.Label1)
        Me.grp_busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_busqueda.Location = New System.Drawing.Point(10, 32)
        Me.grp_busqueda.Name = "grp_busqueda"
        Me.grp_busqueda.Size = New System.Drawing.Size(496, 68)
        Me.grp_busqueda.TabIndex = 0
        Me.grp_busqueda.TabStop = False
        Me.grp_busqueda.Text = " Busqueda "
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(270, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 14)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "# Orden MIS y Turno son Obligatorios"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Orden : "
        '
        'txt_orden
        '
        Me.txt_orden.Location = New System.Drawing.Point(74, 22)
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.Size = New System.Drawing.Size(120, 20)
        Me.txt_orden.TabIndex = 1
        Me.txt_orden.Tag = "1"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(342, 20)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 24)
        Me.btn_buscar.TabIndex = 126
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(250, 24)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(88, 20)
        Me.txt_buscar.TabIndex = 2
        Me.txt_buscar.Tag = "2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(204, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Turno:"
        '
        'grp_pruebas
        '
        Me.grp_pruebas.BackColor = System.Drawing.Color.Transparent
        Me.grp_pruebas.Controls.Add(Me.Label10)
        Me.grp_pruebas.Controls.Add(Me.btn_ninguno)
        Me.grp_pruebas.Controls.Add(Me.btn_todos)
        Me.grp_pruebas.Controls.Add(Me.lista_pruebas)
        Me.grp_pruebas.Controls.Add(Me.cmb_mes)
        Me.grp_pruebas.Location = New System.Drawing.Point(10, 174)
        Me.grp_pruebas.Name = "grp_pruebas"
        Me.grp_pruebas.Size = New System.Drawing.Size(494, 198)
        Me.grp_pruebas.TabIndex = 1
        Me.grp_pruebas.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(302, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Seleccionar:"
        '
        'btn_ninguno
        '
        Me.btn_ninguno.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ninguno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ninguno.Enabled = False
        Me.btn_ninguno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ninguno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ninguno.ForeColor = System.Drawing.Color.Black
        Me.btn_ninguno.Image = CType(resources.GetObject("btn_ninguno.Image"), System.Drawing.Image)
        Me.btn_ninguno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ninguno.Location = New System.Drawing.Point(302, 150)
        Me.btn_ninguno.Name = "btn_ninguno"
        Me.btn_ninguno.Size = New System.Drawing.Size(80, 24)
        Me.btn_ninguno.TabIndex = 122
        Me.btn_ninguno.Text = "Ninguno"
        Me.btn_ninguno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ninguno.UseVisualStyleBackColor = False
        '
        'btn_todos
        '
        Me.btn_todos.BackColor = System.Drawing.SystemColors.Control
        Me.btn_todos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_todos.Enabled = False
        Me.btn_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_todos.ForeColor = System.Drawing.Color.Black
        Me.btn_todos.Image = CType(resources.GetObject("btn_todos.Image"), System.Drawing.Image)
        Me.btn_todos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_todos.Location = New System.Drawing.Point(302, 124)
        Me.btn_todos.Name = "btn_todos"
        Me.btn_todos.Size = New System.Drawing.Size(80, 24)
        Me.btn_todos.TabIndex = 121
        Me.btn_todos.Text = "Todos"
        Me.btn_todos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_todos.UseVisualStyleBackColor = False
        '
        'lista_pruebas
        '
        Me.lista_pruebas.CheckOnClick = True
        Me.lista_pruebas.Location = New System.Drawing.Point(10, 32)
        Me.lista_pruebas.Name = "lista_pruebas"
        Me.lista_pruebas.Size = New System.Drawing.Size(282, 154)
        Me.lista_pruebas.TabIndex = 0
        '
        'cmb_mes
        '
        Me.cmb_mes.ItemHeight = 13
        Me.cmb_mes.Items.AddRange(New Object() {"ENERO", "FEBREO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmb_mes.Location = New System.Drawing.Point(300, 42)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(86, 21)
        Me.cmb_mes.TabIndex = 127
        Me.cmb_mes.Visible = False
        '
        'grp_paciente
        '
        Me.grp_paciente.BackColor = System.Drawing.Color.Transparent
        Me.grp_paciente.Controls.Add(Me.lbl_fecing)
        Me.grp_paciente.Controls.Add(Me.lbl_apellidos)
        Me.grp_paciente.Controls.Add(Me.Label8)
        Me.grp_paciente.Controls.Add(Me.Label9)
        Me.grp_paciente.Controls.Add(Me.lbl_hc)
        Me.grp_paciente.Controls.Add(Me.lbl_nombres)
        Me.grp_paciente.Controls.Add(Me.Label3)
        Me.grp_paciente.Controls.Add(Me.Label2)
        Me.grp_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_paciente.Location = New System.Drawing.Point(10, 106)
        Me.grp_paciente.Name = "grp_paciente"
        Me.grp_paciente.Size = New System.Drawing.Size(496, 64)
        Me.grp_paciente.TabIndex = 2
        Me.grp_paciente.TabStop = False
        Me.grp_paciente.Text = "Paciente"
        '
        'lbl_fecing
        '
        Me.lbl_fecing.Location = New System.Drawing.Point(262, 40)
        Me.lbl_fecing.Name = "lbl_fecing"
        Me.lbl_fecing.Size = New System.Drawing.Size(178, 16)
        Me.lbl_fecing.TabIndex = 7
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.Location = New System.Drawing.Point(262, 18)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(178, 16)
        Me.lbl_apellidos.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(214, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Fecha:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(198, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Apellidos:"
        '
        'lbl_hc
        '
        Me.lbl_hc.Location = New System.Drawing.Point(68, 42)
        Me.lbl_hc.Name = "lbl_hc"
        Me.lbl_hc.Size = New System.Drawing.Size(104, 16)
        Me.lbl_hc.TabIndex = 3
        '
        'lbl_nombres
        '
        Me.lbl_nombres.Location = New System.Drawing.Point(68, 20)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(116, 16)
        Me.lbl_nombres.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "HC:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombres:"
        '
        'grp_opciones
        '
        Me.grp_opciones.BackColor = System.Drawing.Color.Transparent
        Me.grp_opciones.Controls.Add(Me.btn_aceptar)
        Me.grp_opciones.Controls.Add(Me.btn_limpiar)
        Me.grp_opciones.Controls.Add(Me.btn_cancelar)
        Me.grp_opciones.Location = New System.Drawing.Point(12, 384)
        Me.grp_opciones.Name = "grp_opciones"
        Me.grp_opciones.Size = New System.Drawing.Size(492, 56)
        Me.grp_opciones.TabIndex = 3
        Me.grp_opciones.TabStop = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Enabled = False
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(136, 20)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(104, 24)
        Me.btn_aceptar.TabIndex = 128
        Me.btn_aceptar.Text = "Envio MIS"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_limpiar.Enabled = False
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.Color.Black
        Me.btn_limpiar.Image = CType(resources.GetObject("btn_limpiar.Image"), System.Drawing.Image)
        Me.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.Location = New System.Drawing.Point(32, 20)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(80, 24)
        Me.btn_limpiar.TabIndex = 127
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(272, 20)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancelar.TabIndex = 126
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.BackgroundImage = CType(resources.GetObject("pic_barra.BackgroundImage"), System.Drawing.Image)
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Image = CType(resources.GetObject("pic_barra.Image"), System.Drawing.Image)
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(532, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 124
        Me.pic_barra.TabStop = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.White
        Me.lbl_textform.Image = CType(resources.GetObject("lbl_textform.Image"), System.Drawing.Image)
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(32, 6)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(159, 13)
        Me.lbl_textform.TabIndex = 125
        Me.lbl_textform.Text = "Transmicion de Resultados"
        '
        'pic_icono
        '
        Me.pic_icono.BackColor = System.Drawing.Color.SteelBlue
        Me.pic_icono.Image = CType(resources.GetObject("pic_icono.Image"), System.Drawing.Image)
        Me.pic_icono.Location = New System.Drawing.Point(16, 6)
        Me.pic_icono.Name = "pic_icono"
        Me.pic_icono.Size = New System.Drawing.Size(16, 16)
        Me.pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_icono.TabIndex = 126
        Me.pic_icono.TabStop = False
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.Add(Me.pic_min)
        Me.pan_btn.Controls.Add(Me.Pic_close)
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(472, 6)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(27, 12)
        Me.pan_btn.TabIndex = 127
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
        'Frm_Retransmitir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(532, 457)
        Me.Controls.Add(Me.pan_btn)
        Me.Controls.Add(Me.pic_icono)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.pic_barra)
        Me.Controls.Add(Me.grp_opciones)
        Me.Controls.Add(Me.grp_paciente)
        Me.Controls.Add(Me.grp_pruebas)
        Me.Controls.Add(Me.grp_busqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Retransmitir"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retransmision de Resultados"
        Me.grp_busqueda.ResumeLayout(False)
        Me.grp_busqueda.PerformLayout()
        Me.grp_pruebas.ResumeLayout(False)
        Me.grp_paciente.ResumeLayout(False)
        Me.grp_opciones.ResumeLayout(False)
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_btn.ResumeLayout(False)
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_AS400 As New Cls_AS400()
    Dim dts_datos As New DataSet()
    Dim dtr_fila As DataRow
    Dim arr_lis_id(100) As String
    Dim arr_tes_id(100) As String

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub pic_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_min.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ControlBox = True
        Me.MaximizeBox = False
    End Sub

    Private Sub Pic_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If txt_buscar.Text = "" Or txt_orden.Text = "" Then
            MsgBox(" Ingrese numero de orden del MIS... ", MsgBoxStyle.Information, "ANALISYS")
            txt_buscar.Text = ""
            txt_orden.Focus()
            Exit Sub
            'Else
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim verifica As Long
        Dim procesados As Long
        verifica = contador_pruebas(txt_orden.Text, Trim(txt_buscar.Text))
        'procesados = pruebas_procesadas()
        If verifica > 0 Then
            'If procesados <> 0 Then
            dts_datos = llena_datos(txt_orden.Text, Trim(txt_buscar.Text))
            'dts_datos = llena_datos(Trim(txt_buscar.Text))
            arr_lis_id.Clear(arr_lis_id, 0, 100)
            arr_tes_id.Clear(arr_lis_id, 0, 100)

            'Dim dtr_fila As DataRow
            Dim contador As Short = 0
            lista_pruebas.Items.Clear()
            For Each dtr_fila In dts_datos.Tables("Registros").Rows
                If contador = 0 Then
                    lbl_nombres.Text = dtr_fila("pac_nombre")
                    lbl_apellidos.Text = dtr_fila("pac_apellido")
                    lbl_hc.Text = dtr_fila("pac_hist_clinica")
                    lbl_fecing.Text = dtr_fila("ped_fecing")
                    Dim veri As String = nombre_prueba_SQL(dtr_fila("tes_id"))
                    If veri <> "0" Then
                        lista_pruebas.Items.Insert(contador, nombre_prueba_SQL(dtr_fila("tes_id")))
                        lista_pruebas.SetItemChecked(contador, True)
                        arr_lis_id(contador) = dtr_fila("lis_id")
                        arr_tes_id(contador) = dtr_fila("tes_id")
                        contador += 1
                    End If
                    btn_limpiar.Enabled = True
                    btn_aceptar.Enabled = True
                    btn_todos.Enabled = True
                    btn_ninguno.Enabled = True
                Else
                    Dim veri1 As String = nombre_prueba_SQL(dtr_fila("tes_id"))
                    If veri1 <> "0" Then
                        lista_pruebas.Items.Insert(contador, nombre_prueba_SQL(dtr_fila("tes_id")))
                        lista_pruebas.SetItemChecked(contador, True)
                        arr_lis_id(contador) = dtr_fila("lis_id")
                        arr_tes_id(contador) = dtr_fila("tes_id")
                        contador += 1
                    End If
                    btn_limpiar.Enabled = True
                    btn_aceptar.Enabled = True
                    btn_todos.Enabled = True
                    btn_ninguno.Enabled = True
                End If
            Next
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'Else
            'Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'MsgBox(" La orden todavia no tiene pruebas en MIS. ", MsgBoxStyle.Information, "ANALISYS")
            'Call limpia_pantalla()
            'End If
        Else
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox(" No se ha encontrado registros con ese orden. ", MsgBoxStyle.Information, "ANALISYS")
            Call limpia_pantalla()
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Public Function llena_datos(ByVal orden As Long, ByVal turno As String) As DataSet
        On Error GoTo mensaje
        Dim str_sql As String = ""
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_menu As New OleDbDataAdapter()
        Dim fecha As Date
        Dim fi, ff As String
        Dim SHR_DIAS As Short
        Dim mes As Integer
        Dim str_aux As String
        'Para pruebas aumente la fecha aumente  lista_trabajo.lis_resestado  =  2 -5 -7-6 -8 debido que aquellas pruebas q no tienen resultados no van hacer consideradas   or lista_trabajo.lis_resestado = 7 
        str_sql = "select paciente.pac_nombre, paciente.pac_apellido, paciente.pac_hist_clinica, pedido.ped_fecing, lista_trabajo.tes_id, lista_trabajo.ped_id, test.tes_nombre  ,lista_trabajo.lis_resestado ,lista_trabajo.lis_id,pedido.ped_turno,pedido.ped_orden " & _
                  " from pedido, lista_trabajo, paciente, test where ped_orden = '" & Trim(orden) & "' and lista_trabajo.ped_id=pedido.ped_id and paciente.pac_id = pedido.pac_id and (lista_trabajo.lis_resestado = 2  or lista_trabajo.lis_resestado = 7 or lista_trabajo.lis_resestado = 6  or lista_trabajo.lis_resestado = 8 or  lista_trabajo.lis_resestado = 5) and test.tes_id = lista_trabajo.tes_id and pedido.ped_turno = '" & Trim(turno) & "';"

        opr_conexion.conectar()
        oda_menu.SelectCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)

        llena_datos = New DataSet()
        oda_menu.Fill(llena_datos, "Registros")
        opr_conexion.desconectar()
        Exit Function
mensaje:
        MsgBox(" Error en la operacion llena datos de Reestablecer Orden ", MsgBoxStyle.Exclamation, "ANALISYS")
    End Function

    Public Function llena_datos2(ByVal turno As Long) As DataSet
        On Error GoTo mensaje
        Dim str_sql As String = ""
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_menu As New OleDbDataAdapter()
        Dim fecha As Date
        Dim fi, ff As String
        Dim SHR_DIAS As Short
        Dim mes As String
        mes = cmb_mes.SelectedItem
        Select Case mes
            Case "ENERO"
                fecha = Year(Now) & "-01" & "-01"
            Case "FEBRERO"
                fecha = Year(Now) & "-02" & "-01"
            Case "MARZO"
                fecha = Year(Now) & "-03" & "-01"
            Case "ABRIL"
                fecha = Year(Now) & "-04" & "-01"
            Case "MAYO"
                fecha = Year(Now) & "-05" & "-01"
            Case "JUNIO"
                fecha = Year(Now) & "-06" & "-01"
            Case "JULIO"
                fecha = Year(Now) & "-07" & "-01"
            Case "AGOSTO"
                fecha = Year(Now) & "-08" & "-01"
            Case "SEPTIEMBRE"
                fecha = Year(Now) & "-09" & "-01"
            Case "OCTUBRE"
                fecha = Year(Now) & "-10" & "-01"
            Case "NOVIEMBRE"
                fecha = Year(Now) & "-11" & "-01"
            Case "DICIEMBRE"
                fecha = Year(Now) & "-12" & "-01"
        End Select

        SHR_DIAS = Date.DaysInMonth(Year(fecha), Month(fecha))
        fi = CStr(Year(fecha)) & "-" & CStr(Month(fecha)) & "-01"
        ff = CStr(Year(fecha) & "-" & CStr(Month(fecha)) & "-" & CStr(SHR_DIAS))

        str_sql = "select paciente.pac_nombre, paciente.pac_apellido, paciente.pac_hist_clinica, pedido.ped_fecing, lista_trabajo.tes_id, lista_trabajo.ped_id, test.tes_nombre ,  pedido.ped_orden,  pedido.ped_turno, lis_id " & _
                  " from pedido, lista_trabajo, paciente, test where ped_turno = '" & Trim(turno) & "' and lista_trabajo.ped_id=pedido.ped_id and paciente.pac_id = pedido.pac_id and test.tes_id = lista_trabajo.tes_id and (lista_trabajo.lis_resestado=7 or lista_trabajo.lis_resestado=2 or lista_trabajo.lis_resestado=8 or lista_trabajo.lis_resestado=6 ) and pedido.ped_fecing between '" & fi & " 00:00:00' and '" & ff & " 23:59:59' "

        opr_conexion.conectar()
        oda_menu.SelectCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
        llena_datos2 = New DataSet()
        oda_menu.Fill(llena_datos2, "Registros")
        opr_conexion.desconectar()
        Exit Function
mensaje:
        MsgBox(" Error en la operacion llena datos de Reestablecer Orden ", MsgBoxStyle.Exclamation, "ANALISYS")
    End Function

    Public Function contador_pruebas(ByVal orden As Long, ByVal turno As String) As Long
        On Error GoTo mensaje
        Dim str_sql As String = ""
        Dim opr_conexion As New Cls_Conexion()
        Dim fecha As Date
        Dim fi, ff As String
        Dim SHR_DIAS As Short
        Dim mes As String
        mes = cmb_mes.SelectedItem
        Select Case mes
            Case "ENERO"
                fecha = Year(Now) & "-01" & "-01"
            Case "FEBRERO"
                fecha = Year(Now) & "-02" & "-01"
            Case "MARZO"
                fecha = Year(Now) & "-03" & "-01"
            Case "ABRIL"
                fecha = Year(Now) & "-04" & "-01"
            Case "MAYO"
                fecha = Year(Now) & "-05" & "-01"
            Case "JUNIO"
                fecha = Year(Now) & "-06" & "-01"
            Case "JULIO"
                fecha = Year(Now) & "-07" & "-01"
            Case "AGOSTO"
                fecha = Year(Now) & "-08" & "-01"
            Case "SEPTIEMBRE"
                fecha = Year(Now) & "-09" & "-01"
            Case "OCTUBRE"
                fecha = Year(Now) & "-10" & "-01"
            Case "NOVIEMBRE"
                fecha = Year(Now) & "-11" & "-01"
            Case "DICIEMBRE"
                fecha = Year(Now) & "-12" & "-01"
        End Select
        SHR_DIAS = Date.DaysInMonth(Year(fecha), Month(fecha))
        fi = CStr(Year(fecha)) & "-" & CStr(Month(fecha)) & "-01"
        ff = CStr(Year(fecha) & "-" & CStr(Month(fecha)) & "-" & CStr(SHR_DIAS))
        ' str_sql = "select count(*) from pedido, lista_trabajo where pedido.ped_turno='" & Trim(txt_buscar.Text) & "' and lista_trabajo.ped_id = pedido.ped_id and ped_fecing between '" & fi & "' and '" & ff & "'"
        'str_sql = "select count(*) from pedido, lista_trabajo where pedido.ped_turno='" & Trim(txt_buscar.Text) & "' and lista_trabajo.ped_id = pedido.ped_id and ped_fecing between '" & fi & " 00:00:00' and '" & ff & " 23:59:59' "
        'Para pruebas aumente la fecha aumente  lista_trabajo.lis_resestado  =  2 -5 -7-6 -8 debido que aquellas pruebas q no tienen resultados no van hacer consideradas   or lista_trabajo.lis_resestado = 7 
        str_sql = "select count(*) from pedido, lista_trabajo, paciente, test where ped_orden = '" & Trim(orden) & "' and lista_trabajo.ped_id=pedido.ped_id and paciente.pac_id = pedido.pac_id and (lista_trabajo.lis_resestado = 2  or lista_trabajo.lis_resestado = 7 or lista_trabajo.lis_resestado = 6  or lista_trabajo.lis_resestado = 8 or  lista_trabajo.lis_resestado = 5) and test.tes_id = lista_trabajo.tes_id and pedido.ped_turno = '" & Trim(turno) & "';"
        opr_conexion.conectar()
        Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
        While odr_operacion.Read
            contador_pruebas = odr_operacion.GetValue(0).ToString()
        End While
        opr_conexion.desconectar()
        Exit Function
mensaje:
        MsgBox(" No se pudo realizar la operacion solicitada, Contador_Pruebas", MsgBoxStyle.Exclamation, "ANALISYS")
    End Function

    Public Function pruebas_procesadas() As Long
        On Error GoTo mensaje
        Dim str_sql As String = ""
        Dim opr_conexion As New Cls_Conexion()
        Dim fecha As Date
        Dim fi, ff As String
        Dim SHR_DIAS As Short
        Dim mes As String
        mes = cmb_mes.SelectedItem
        Select Case mes
            Case "ENERO"
                fecha = Year(Now) & "-01" & "-01"
            Case "FEBRERO"
                fecha = Year(Now) & "-02" & "-01"
            Case "MARZO"
                fecha = Year(Now) & "-03" & "-01"
            Case "ABRIL"
                fecha = Year(Now) & "-04" & "-01"
            Case "MAYO"
                fecha = Year(Now) & "-05" & "-01"
            Case "JUNIO"
                fecha = Year(Now) & "-06" & "-01"
            Case "JULIO"
                fecha = Year(Now) & "-07" & "-01"
            Case "AGOSTO"
                fecha = Year(Now) & "-08" & "-01"
            Case "SEPTIEMBRE"
                fecha = Year(Now) & "-09" & "-01"
            Case "OCTUBRE"
                fecha = Year(Now) & "-10" & "-01"
            Case "NOVIEMBRE"
                fecha = Year(Now) & "-11" & "-01"
            Case "DICIEMBRE"
                fecha = Year(Now) & "-12" & "-01"
        End Select
        SHR_DIAS = Date.DaysInMonth(Year(fecha), Month(fecha))
        fi = CStr(Year(fecha)) & "-" & CStr(Month(fecha)) & "-01 "
        ff = CStr(Year(fecha) & "-" & CStr(Month(fecha)) & "-" & CStr(SHR_DIAS))
        str_sql = "select count(*) from pedido, lista_trabajo where pedido.ped_turno='" & Trim(txt_buscar.Text) & "' and lista_trabajo.ped_id = pedido.ped_id and ( lista_trabajo.lis_resestado=2 or lista_trabajo.lis_resestado=5 or lista_trabajo.lis_resestado=7  or lista_trabajo.lis_resestado=8) and ped_fecing between '" & fi & " 00:00:00' and '" & ff & " 23:59:59' "
        'str_aux = " and lista_trabajo.LIS_FECING  "
        'str_sql = "select count(*) from pedido, lista_trabajo where pedido.ped_turno='" & Trim(txt_buscar.Text) & "' and lista_trabajo.ped_id = pedido.ped_id and lista_trabajo.lis_resestado=7 and ped_fecing  between '" & Format(fi, "yyyy-MM-dd") & " 00:00:00' and '" & Format(ff, "yyyy-MM-dd") & " 23:59:59' "
        opr_conexion.conectar()
        Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
        While odr_operacion.Read
            pruebas_procesadas = odr_operacion.GetValue(0).ToString()
        End While
        opr_conexion.desconectar()
        Exit Function
mensaje:
        MsgBox(" No se pudo realizar la operacion solicitada, Contador_Pruebas", MsgBoxStyle.Exclamation, "ANALISYS")
    End Function

    Public Function nombre_prueba_SQL(ByVal codigo As String) As String
        'Devuelve el nombre de la prueba solicitada por el código
        'Funcion para la consultar los datos de la tabla EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        nombre_prueba_SQL = "0"
        Select Case codigo
            Case "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2015", "2018", "2021", "2024", "2027", "2029", "2030", "2033", "2036"
                Exit Function
            Case "2012"
                codigo = "200"
                'orina examen general
            Case "5015", "5020", "5025", "5030", "5035", "5040", "5045", "5050", "5055", "5060", "5065", "5070", "5075", "5080", "5085", "5090", "5095", "5100", "5105"
                Exit Function
            Case "5010"
                codigo = "500"
                'reaccion widal
            Case "4045", "4050", "4055", "4060", "4065"
                Exit Function
            Case "4040"
                codigo = "400"
                'para la prueba especial de gases arteriales
            Case "8202", "8204", "8206", "8208", "8210", "8212"
                Exit Function
            Case "8200"
                codigo = "700"
                'para la prueba especial de gases venosos
            Case "8302", "8304", "8306", "8308", "8310", "8312"
                Exit Function
            Case "8300"
                codigo = "710"
                'para la prueba especial de electrolitos(sodio, potasio, cloro)
            Case "1172", "1181"
                Exit Function
            Case "1188"
                codigo = "140"
                'para la prueba especial de aclaramiento de creatinina
            Case "1045", "1239"
                Exit Function
            Case "1054"
                codigo = "180"
        End Select

        STR_SQL = "SELECT TES_NOMBRE FROM TEST WHERE TES_ID = " & codigo & ";"
        opr_Conexion.conectar()
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            nombre_prueba_SQL = oda_operacion.GetValue(0).ToString
        End While
        oda_operacion.Close()
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Nombre_prueba_SQL ", Err)
        Err.Clear()
    End Function

    Public Sub limpia_pantalla()
        txt_orden.Text = ""
        txt_buscar.Text = ""
        lbl_nombres.Text = ""
        lbl_apellidos.Text = ""
        lbl_hc.Text = ""
        lbl_fecing.Text = ""
        lista_pruebas.Items.Clear()
        btn_todos.Enabled = False
        btn_ninguno.Enabled = False
        btn_aceptar.Enabled = False
        btn_limpiar.Enabled = False
        txt_buscar.Text = ""
        txt_orden.Focus()
    End Sub

    Private Sub Frm_Retransmitir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txt_orden.Focus()
    End Sub

    Private Sub btn_todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_todos.Click
        Dim i As Integer = 0
        For i = 0 To lista_pruebas.Items.Count - 1
            lista_pruebas.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btn_ninguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ninguno.Click
        Dim i As Integer = 0
        For i = 0 To lista_pruebas.Items.Count - 1
            lista_pruebas.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Call limpia_pantalla()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click


        Dim opr_sistema As New Cls_sistema()
        Dim hcli, orden As Long
        Dim hclinica, numOrden As String
        Dim i As Integer = 0
        Dim tes_id As Integer
        Dim res_man As String
        Dim boo_items = False
        Dim valida_exp As Integer = 0
        Dim status As Integer
        Dim v_error As Integer = 0
        Dim v_status As Integer = 0
        Dim v_dtinco As Integer = 0

        'verifica que al menos este marcado un test
        For i = 0 To lista_pruebas.Items.Count - 1
            If lista_pruebas.GetItemChecked(i) = True Then
                boo_items = True
                Exit For
            End If

        Next
        'caso contarrio inidca que seleccione uno
        If boo_items = False Then
            MsgBox("Debe escoger al menos una prueba para " & Chr(13) & "Transmitir Resultados a MIS", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        End If

        'recorro los test seleccionados
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim oConexion As iDB2Connection
        Dim otrans As iDB2Transaction
        oConexion = New iDB2Connection(g_str_idb2)
        Try
            'abre conexion a MIS, con transaccion
            oConexion.Open()
            otrans = oConexion.BeginTransaction
            'Almacena el Turno para validaciòn
            Dim ped_turno As Integer = dtr_fila("ped_turno")
            For i = 0 To lista_pruebas.Items.Count - 1
                If lista_pruebas.GetItemChecked(i) = True Then
                    tes_id = codigoTest(lista_pruebas.Items.Item(i))
                    'Borra transmisiòn para volver a insertar
                    frm_refer_main.escribemsj("ENVIANDO A MIS (E)... Espere un momento!")
                    opr_AS400.BorraResultadoMIS(CStr(dtr_fila("ped_orden")), tes_id)
                    'Valida si el Status es lis_resestado = 6 entoces otro usuario està procesando la orden
                    'Asigna status y que tipo e Ingreso al MIS
                    frm_refer_main.escribemsj("CONSULTANDO ESTATUS PARA ENVIO... Espere un momento!")
                    status = CInt(opr_AS400.asignar_status(tes_id, dtr_fila("ped_id")))
                    If status = 1 Or status = 2 Then
                        If tes_id <> 0 And tes_id <> 200 Then
                            frm_refer_main.escribemsj("CONSULTANDO RESULTADO A TRANSMITIR... Espere un momento!")
                            res_man = consulta_resman(dtr_fila("ped_id"), tes_id)
                            If res_man <> "" And CStr(tes_id) <> "" Then
                                'Cambio a estado 6 que significa en proceso de envio 
                                frm_refer_main.escribemsj("GRABA RESULTADO EN MIS... Espere un momento!")
                                If opr_AS400.InsertResultadoMIS(dtr_fila("ped_id"), tes_id, res_man, oConexion, otrans) = True Then
                                    opr_sistema.auditoria(dtr_fila("ped_id"), tes_id, 11)
                                Else
                                    opr_sistema.auditoria(dtr_fila("ped_id"), tes_id, 5)
                                End If
                            Else
                                v_error = 1
                            End If
                        ElseIf tes_id = 200 Then
                            Dim j As Short
                            For j = 1 To 22
                                Select Case j
                                    Case 1
                                        tes_id = "2002001"
                                    Case 2
                                        tes_id = "2002002"
                                    Case 3
                                        tes_id = "2002003"
                                    Case 4
                                        tes_id = "2002004"
                                    Case 5
                                        tes_id = "2002005"
                                    Case 6
                                        tes_id = "2002006"
                                    Case 7
                                        tes_id = "2002007"
                                    Case 8
                                        tes_id = "2002008"
                                    Case 9
                                        tes_id = "2002009"
                                    Case 10
                                        tes_id = "2002010"
                                    Case 11
                                        tes_id = "2002011"
                                    Case 12
                                        tes_id = "2002012"
                                    Case 13
                                        tes_id = "2002015"
                                    Case 14
                                        tes_id = "2002018"
                                    Case 15
                                        tes_id = "2002021"
                                    Case 16
                                        tes_id = "2002024"
                                    Case 17
                                        tes_id = "2002027"
                                    Case 18
                                        tes_id = "2002029"
                                    Case 19
                                        tes_id = "2002030"
                                    Case 20
                                        tes_id = "2002033"
                                    Case 21
                                        tes_id = "2002036"
                                    Case 22
                                        tes_id = "35" 'And tes_id <> "35" 
                                End Select
                                frm_refer_main.escribemsj("CONSULTANDO RESULTADO A TRANSMITIR... Espere un momento!")
                                res_man = consulta_resman(dtr_fila("ped_id"), tes_id)
                                If res_man <> "" And CStr(tes_id) <> "" Then
                                    frm_refer_main.escribemsj("GRABA RESULTADO EN MIS... Espere un momento!")
                                    If opr_AS400.InsertResultadoMIS(dtr_fila("ped_id"), tes_id, res_man, oConexion, otrans) = True Then
                                        opr_sistema.auditoria(dtr_fila("ped_id"), tes_id, 11)
                                    Else
                                        opr_sistema.auditoria(dtr_fila("ped_id"), tes_id, 5)

                                    End If
                                Else
                                    If tes_id <> "35" Then
                                        v_error = 1
                                    End If
                                End If
                            Next
                        End If
                    Else
                        'Envio de Test Antibiograma
                        If opr_AS400.validacion_antibiograma(ped_turno, CStr(Month(dtr_fila("ped_fecing")))) = False Then
                            opr_sistema.auditoria(dtr_fila("ped_id"), tes_id, 11)
                        Else
                            opr_sistema.auditoria(dtr_fila("ped_id"), tes_id, 5)
                        End If
                    End If
                    'End If
                End If
            Next
            otrans.Commit()
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("No se retransmitieron los resultados seleccionados.", MsgBoxStyle.Critical, "ANALISYS")
            v_error = 1
            Err.Clear()
            otrans.Rollback()
        Finally

            oConexion.Close()
            oConexion = Nothing
            'preparo para enviar los resultados al MIS
            hcli = opr_AS400.ConsultaHC(dtr_fila("ped_id"))
            hclinica = opr_AS400.meteCeroHC(hcli)
            numOrden = opr_AS400.meteCeroNOMIS(dtr_fila("ped_orden"))
            'Function para actualizar el Turno 
            Call opr_AS400.actualiza_dlfecm(numOrden, hclinica, dtr_fila("ped_turno"))
            'Envia resultados a la funciòn DTLC05
            opr_AS400.RutinaDTLC05(hclinica, numOrden)
            frm_refer_main.escribemsj("Visualizaciòn en MIS..................")
            For i = 0 To lista_pruebas.Items.Count - 1
                If lista_pruebas.GetItemChecked(i) = True Then
                    'Verifica errores en el archivo DTINCO segùn DTLMIS
                    If opr_AS400.countregistrosDTINCOMISDTL(numOrden, hclinica, arr_tes_id(i)) = 0 Then
                        opr_trabajo.CambioEstadoItemLista(arr_lis_id(i), 7) 'CAMBIO A ESTADO 7 QUE SIGNIFICA EN  ENVIADO AL MIS  y 1 si es enviado /no enviado 
                    Else
                        opr_trabajo.CambioEstadoItemLista(arr_lis_id(i), 8) 'CAMBIO A ESTADO 8 QUE SIGNIFICA EN NO ENVIADO AL MIS   y 1 si es enviado /no enviado 
                        v_dtinco = 1
                    End If
                End If
            Next
            frm_refer_main.escribemsj("DISPONIBLE")
            If v_dtinco = 1 Then
                Dim dts_resm As DataSet
                'Dim dtr_fila As DataRow
                dts_resm = opr_AS400.selectregistrosDTINCO(numOrden)
                Dim x As String = ""
                frm_refer_main.escribemsj("Actualizando Estado (E)")
                For Each dtr_fila In dts_resm.Tables("Registros").Rows
                    'opr_trabajo.GuardaDTINCO(dtr_fila(0), dtr_fila(1), dtr_fila(2), dtr_fila(3), CStr(txt_orden.Text), CStr(txt_buscar.Text))

                Next
                MsgBox("Error al Transmitir Datos, Consulte En la Lista Trabajo . ", MsgBoxStyle.Information, "ANALISYS")
            Else
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox(" Operacion realizada satisfactoriamente, Resultados Enviados a MIS. ", MsgBoxStyle.Information, "ANALISYS")
            End If
            frm_refer_main.escribemsj("DISPONIBLE..................")
            arr_lis_id.Clear(arr_lis_id, 0, 100)
            arr_tes_id.Clear(arr_lis_id, 0, 100)
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            Call limpia_pantalla()
        End Try
    End Sub

    Public Function BorraResultadoMIS(ByVal ped_id As String, ByVal TesId As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim orden As String
        Dim oConexion As iDB2Connection
        Dim otrans As iDB2Transaction
        Dim cmd As iDB2Command
        Dim tmp As String
        orden = ConsultaOrden(ped_id)
        oConexion = New iDB2Connection(g_str_idb2)

        tmp = Len(TesId)
        Select Case tmp
            Case 8
                TesId = Mid(TesId, 5, 8)
            Case 7
                TesId = Mid(TesId, 4, 7)
            Case Else
                TesId = TesId
        End Select

        Try
            'abre conexion a MIS, con transaccion
            oConexion.Open()
            otrans = oConexion.BeginTransaction
            If TesId <> 200 Then
                str_sql = "Delete from " & g_ASLibreria & ".DTLMIS where DLNUOR=" & orden & " and DLCEXA=" & TesId & " "
                cmd = New iDB2Command(str_sql, oConexion, otrans)
                cmd.ExecuteNonQuery()
            ElseIf TesId = 200 Then
                Dim i As Integer
                For i = 1 To 22
                    Select Case i
                        Case 1
                            TesId = "2001"
                        Case 2
                            TesId = "2002"
                        Case 3
                            TesId = "2003"
                        Case 4
                            TesId = "2004"
                        Case 5
                            TesId = "2005"
                        Case 6
                            TesId = "2006"
                        Case 7
                            TesId = "2007"
                        Case 8
                            TesId = "2008"
                        Case 9
                            TesId = "2009"
                        Case 10
                            TesId = "2010"
                        Case 11
                            TesId = "2011"
                        Case 12
                            TesId = "2012"
                        Case 13
                            TesId = "2015"
                        Case 14
                            TesId = "2018"
                        Case 15
                            TesId = "2021"
                        Case 16
                            TesId = "2024"
                        Case 17
                            TesId = "2027"
                        Case 18
                            TesId = "2029"
                        Case 19
                            TesId = "2030"
                        Case 20
                            TesId = "2033"
                        Case 21
                            TesId = "2036"
                        Case 22
                            TesId = "35"
                    End Select
                    str_sql = "Delete from " & g_ASLibreria & ".DTLMIS where DLNUOR=" & orden & " and DLCEXA=" & TesId & " "
                    cmd = New iDB2Command(str_sql, oConexion, otrans)
                    cmd.ExecuteNonQuery()
                Next
            End If
            otrans.Commit()
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
            otrans.Rollback()
        Finally
            oConexion.Close()
            oConexion = Nothing
        End Try
    End Function

    Public Function ConsultaOrden(ByVal pedido As String) As String
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String
        Try
            opr_Conexion.conectar()
            str_sql = "select ped_orden from pedido where ped_id='" & pedido & "' "
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteReader
            While odr.Read
                ConsultaOrden = odr.GetValue(0).ToString()
            End While
            odr.Close()
        Catch
            RutinaError(Err.Number, Err.Description)
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, CódigoTest", Err)
            Err.Clear()
        Finally
            opr_Conexion.desconectar()
        End Try
    End Function

    Public Function codigoTest(ByVal test As String) As Integer
        'Devuelve el numero de registros del archivo MISDTL
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.conectar()
        codigoTest = CInt(New OleDbCommand("select count(tes_id) from test where tes_nombre = '" & test & "';", opr_Conexion.Conn_BD).ExecuteScalar)
        If codigoTest > 0 Then
            codigoTest = CInt(New OleDbCommand("select tes_id from test where tes_nombre = '" & test & "';", opr_Conexion.Conn_BD).ExecuteScalar)
        End If
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, CódigoTest", Err)
        Err.Clear()
    End Function

    Public Function consulta_resman(ByVal ped_id As String, ByVal tes_id As String) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim tipo_proc As Integer = verifica(tes_id)
            Select Case tipo_proc
                Case 0
                    Dim str_sql As String = "select lista_trabajo.lis_resmanual from lista_trabajo where lista_trabajo.ped_id='" & ped_id & "' and lista_trabajo.tes_id='" & tes_id & "' "
                    opr_conexion.conectar()
                    Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
                    While odr_operacion.Read
                        consulta_resman = odr_operacion.GetValue(0).ToString()
                    End While
                    opr_conexion.desconectar()
                Case 1
                    Dim abreviatura As String = cons_abreviatura(tes_id)
                    Dim str_sql1 As String = "select prc_resul from res_procesados where ped_id='" & ped_id & "' and tes_abrev='" & abreviatura & "'"
                    opr_conexion.conectar()
                    Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql1, opr_conexion.Conn_BD).ExecuteReader
                    While odr_operacion.Read
                        consulta_resman = odr_operacion.GetValue(0).ToString()
                    End While
                    opr_conexion.desconectar()
            End Select
            Exit Function
        Catch
            MsgBox("No se pudo realizar la operacion solicitada. Consulta_resman", MsgBoxStyle.Critical, "ANALISYS")
        End Try
    End Function

    Public Function verifica(ByVal tes_id As String) As Integer
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select tes_tproces from test where tes_id='" & tes_id & "'"
            opr_conexion.conectar()
            Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr_operacion.Read
                verifica = odr_operacion.GetValue(0).ToString()
            End While
            opr_conexion.desconectar()
        Catch
            MsgBox("No se pudo realizar la operacion solicitada, Verifica Tipo_Proc", MsgBoxStyle.Information, "ANALISYS")
        End Try
    End Function

    Public Function cons_abreviatura(ByVal tes_id As String) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select teq_abrv_fija from test_equipo where tes_id='" & tes_id & "' order by teq_abrv_fija "
            opr_conexion.conectar()
            'Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.Conn_BD).ExecuteScalar
            'While odr_operacion.Read
            'cons_abreviatura = odr_operacion.GetValue(0).ToString()
            'End While
            cons_abreviatura = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteScalar
            opr_conexion.desconectar()
        Catch
            MsgBox("No se pudo realizar la operacion solicitada, Consulta_Abreviatura. ", MsgBoxStyle.Information, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function envia_biometria(ByVal ped_id As Integer) As Boolean
        Try
            Dim i As Integer
            Dim tes_id As String
            Dim abreviatura As String
            Dim res_man As String
            Dim clase_as400 As New Cls_AS400()
            Dim opr_conexion As New Cls_Conexion()

            For i = 1 To 22
                Select Case i
                    Case 1
                        tes_id = "2001"
                    Case 2
                        tes_id = "2002"
                    Case 3
                        tes_id = "2003"
                    Case 4
                        tes_id = "2004"
                    Case 5
                        tes_id = "2005"
                    Case 6
                        tes_id = "2006"
                    Case 7
                        tes_id = "2007"
                    Case 8
                        tes_id = "2008"
                    Case 9
                        tes_id = "2009"
                    Case 10
                        tes_id = "2010"
                    Case 11
                        tes_id = "2011"
                    Case 12
                        tes_id = "2012"
                    Case 13
                        tes_id = "2015"
                    Case 14
                        tes_id = "2018"
                    Case 15
                        tes_id = "2021"
                    Case 16
                        tes_id = "2024"
                    Case 17
                        tes_id = "2027"
                    Case 18
                        tes_id = "2029"
                    Case 19
                        tes_id = "2030"
                    Case 20
                        tes_id = "2033"
                    Case 21
                        tes_id = "2036"
                    Case 22
                        tes_id = "35"
                End Select
                res_man = consulta_resman(ped_id, tes_id)
                If clase_as400.INSERTRESMANUALVALIDADO(ped_id, tes_id, res_man) = True Then
                Else
                    MsgBox("No se pudo transmitir resultados de la Biometria Hematica. ", MsgBoxStyle.Exclamation, "ANALISYS")
                End If
            Next
            Exit Function
        Catch
            MsgBox("No se pudo enviar el resultado de la Biometria Hematica", MsgBoxStyle.Information, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Private Sub Frm_Retransmitir_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_mes.SelectedIndex = (Date.Now.Month - 1)
        txt_orden.Text = ""
        txt_orden.Focus()
    End Sub

    Private Sub grp_pruebas_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_pruebas.Enter

    End Sub

    Private Sub grp_opciones_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_opciones.Enter

    End Sub
End Class
