'*************************************************************************
' Nombre:   frm_conecionAS400
' Tipo de Archivo: Formulario
' Descripción:  Formulario para la importar Ordenes desde el Sistema MIS
' Autores:  RFN
' Fecha de Creación: Diciembre del 2005
' Autores:  RFN
' Ultima Modificación: 21/12/2005
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data
'Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb

Public Class frm_conexionAS400
    Inherits System.Windows.Forms.Form


    Public frm_refer_main As Frm_Main
    Dim tipo As String = ""
    Dim recibo As String = ""
    Dim opr_as400 As New Cls_AS400()
    Dim OPR_TRABAJO As New Cls_Trabajo()
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txt_parametro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_testFactura As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_ninguno As System.Windows.Forms.Button
    Friend WithEvents btn_todos As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents pic_min As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_orden As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_operador As System.Windows.Forms.ComboBox
    Friend WithEvents btn_envMIS As System.Windows.Forms.Button
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents C2tl_txt_num_turno As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_num_turno As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_hc As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dts_as400 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_conexionAS400))
        Me.txt_parametro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_testFactura = New System.Windows.Forms.CheckedListBox
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_cargar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_ninguno = New System.Windows.Forms.Button
        Me.btn_todos = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.pan_btn = New System.Windows.Forms.Panel
        Me.pic_min = New System.Windows.Forms.PictureBox
        Me.Pic_close = New System.Windows.Forms.PictureBox
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.lbl_orden = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_operador = New System.Windows.Forms.ComboBox
        Me.btn_envMIS = New System.Windows.Forms.Button
        Me.cmb_tipo = New System.Windows.Forms.ComboBox
        Me.C2tl_txt_num_turno = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_num_turno = New System.Windows.Forms.ComboBox
        Me.lbl_hc = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dts_as400 = New System.Windows.Forms.DataGrid
        Me.pan_barra.SuspendLayout()
        Me.pan_btn.SuspendLayout()
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dts_as400, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_parametro
        '
        Me.txt_parametro.Location = New System.Drawing.Point(120, 6)
        Me.txt_parametro.Name = "txt_parametro"
        Me.txt_parametro.Size = New System.Drawing.Size(273, 21)
        Me.txt_parametro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar en HIS:"
        '
        'chk_testFactura
        '
        Me.chk_testFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chk_testFactura.CheckOnClick = True
        Me.chk_testFactura.Location = New System.Drawing.Point(24, 129)
        Me.chk_testFactura.Name = "chk_testFactura"
        Me.chk_testFactura.Size = New System.Drawing.Size(384, 130)
        Me.chk_testFactura.TabIndex = 112
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.Location = New System.Drawing.Point(222, 264)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_salir.TabIndex = 115
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_cargar
        '
        Me.btn_cargar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar.ForeColor = System.Drawing.Color.Black
        Me.btn_cargar.Image = CType(resources.GetObject("btn_cargar.Image"), System.Drawing.Image)
        Me.btn_cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cargar.Location = New System.Drawing.Point(135, 264)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cargar.TabIndex = 114
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(420, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Seleccionar:"
        '
        'btn_ninguno
        '
        Me.btn_ninguno.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ninguno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ninguno.Enabled = False
        Me.btn_ninguno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ninguno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ninguno.ForeColor = System.Drawing.Color.Black
        Me.btn_ninguno.Image = CType(resources.GetObject("btn_ninguno.Image"), System.Drawing.Image)
        Me.btn_ninguno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ninguno.Location = New System.Drawing.Point(429, 261)
        Me.btn_ninguno.Name = "btn_ninguno"
        Me.btn_ninguno.Size = New System.Drawing.Size(80, 24)
        Me.btn_ninguno.TabIndex = 120
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
        Me.btn_todos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_todos.ForeColor = System.Drawing.Color.Black
        Me.btn_todos.Image = CType(resources.GetObject("btn_todos.Image"), System.Drawing.Image)
        Me.btn_todos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_todos.Location = New System.Drawing.Point(429, 234)
        Me.btn_todos.Name = "btn_todos"
        Me.btn_todos.Size = New System.Drawing.Size(80, 24)
        Me.btn_todos.TabIndex = 119
        Me.btn_todos.Text = "Todos"
        Me.btn_todos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_todos.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.pan_btn)
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Controls.Add(Me.pic_barra)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(531, 25)
        Me.pan_barra.TabIndex = 122
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.Add(Me.pic_min)
        Me.pan_btn.Controls.Add(Me.Pic_close)
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(480, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(24, 12)
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
        Me.Pic_close.Location = New System.Drawing.Point(16, 0)
        Me.Pic_close.Name = "Pic_close"
        Me.Pic_close.Size = New System.Drawing.Size(8, 12)
        Me.Pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_close.TabIndex = 1
        Me.Pic_close.TabStop = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(19, 6)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(119, 13)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "Importar Orden HIS"
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Image = CType(resources.GetObject("pic_barra.Image"), System.Drawing.Image)
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(531, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 91
        Me.pic_barra.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(420, 6)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 24)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txt_parametro)
        Me.Panel1.Controls.Add(Me.btn_buscar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 36)
        Me.Panel1.TabIndex = 124
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Paciente:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Orden:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(384, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Items disp.:"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_paciente.Location = New System.Drawing.Point(84, 81)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(177, 15)
        Me.lbl_paciente.TabIndex = 128
        '
        'lbl_orden
        '
        Me.lbl_orden.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orden.Location = New System.Drawing.Point(315, 81)
        Me.lbl_orden.Name = "lbl_orden"
        Me.lbl_orden.Size = New System.Drawing.Size(60, 15)
        Me.lbl_orden.TabIndex = 129
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha.Location = New System.Drawing.Point(477, 81)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(36, 15)
        Me.lbl_fecha.TabIndex = 130
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(420, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Turno:"
        '
        'cmb_operador
        '
        Me.cmb_operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_operador.Items.AddRange(New Object() {"IMPORTAR", "EXPORTAR"})
        Me.cmb_operador.Location = New System.Drawing.Point(30, 207)
        Me.cmb_operador.Name = "cmb_operador"
        Me.cmb_operador.Size = New System.Drawing.Size(111, 21)
        Me.cmb_operador.TabIndex = 134
        Me.cmb_operador.Visible = False
        '
        'btn_envMIS
        '
        Me.btn_envMIS.BackgroundImage = CType(resources.GetObject("btn_envMIS.BackgroundImage"), System.Drawing.Image)
        Me.btn_envMIS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_envMIS.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_envMIS.Enabled = False
        Me.btn_envMIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_envMIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_envMIS.ForeColor = System.Drawing.Color.Black
        Me.btn_envMIS.Image = CType(resources.GetObject("btn_envMIS.Image"), System.Drawing.Image)
        Me.btn_envMIS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_envMIS.Location = New System.Drawing.Point(267, 141)
        Me.btn_envMIS.Name = "btn_envMIS"
        Me.btn_envMIS.Size = New System.Drawing.Size(80, 24)
        Me.btn_envMIS.TabIndex = 135
        Me.btn_envMIS.Text = "Env. HIS"
        Me.btn_envMIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_envMIS.Visible = False
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Items.AddRange(New Object() {"NORMAL", "URGENCIA"})
        Me.cmb_tipo.Location = New System.Drawing.Point(417, 117)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(99, 21)
        Me.cmb_tipo.TabIndex = 136
        '
        'C2tl_txt_num_turno
        '
        Me.C2tl_txt_num_turno.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2tl_txt_num_turno.Location = New System.Drawing.Point(261, 132)
        Me.C2tl_txt_num_turno.Name = "C2tl_txt_num_turno"
        Me.C2tl_txt_num_turno.Prp_Formato = True
        Me.C2tl_txt_num_turno.Prp_NumDecimales = CType(0, Short)
        Me.C2tl_txt_num_turno.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.C2tl_txt_num_turno.Prp_ValDefault = "0"
        Me.C2tl_txt_num_turno.Size = New System.Drawing.Size(102, 33)
        Me.C2tl_txt_num_turno.TabIndex = 133
        Me.C2tl_txt_num_turno.Visible = False
        '
        'Ctl_txt_num_turno
        '
        Me.Ctl_txt_num_turno.Location = New System.Drawing.Point(417, 180)
        Me.Ctl_txt_num_turno.Name = "Ctl_txt_num_turno"
        Me.Ctl_txt_num_turno.Size = New System.Drawing.Size(96, 21)
        Me.Ctl_txt_num_turno.TabIndex = 137
        '
        'lbl_hc
        '
        Me.lbl_hc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hc.Location = New System.Drawing.Point(315, 102)
        Me.lbl_hc.Name = "lbl_hc"
        Me.lbl_hc.Size = New System.Drawing.Size(60, 15)
        Me.lbl_hc.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "HC:"
        '
        'dts_as400
        '
        Me.dts_as400.DataMember = ""
        Me.dts_as400.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dts_as400.Location = New System.Drawing.Point(21, 309)
        Me.dts_as400.Name = "dts_as400"
        Me.dts_as400.Size = New System.Drawing.Size(495, 165)
        Me.dts_as400.TabIndex = 140
        '
        'frm_conexionAS400
        '
        Me.AcceptButton = Me.btn_cargar
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_salir
        Me.ClientSize = New System.Drawing.Size(531, 492)
        Me.Controls.Add(Me.dts_as400)
        Me.Controls.Add(Me.lbl_hc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Ctl_txt_num_turno)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_orden)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_ninguno)
        Me.Controls.Add(Me.btn_todos)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.chk_testFactura)
        Me.Controls.Add(Me.btn_envMIS)
        Me.Controls.Add(Me.cmb_operador)
        Me.Controls.Add(Me.C2tl_txt_num_turno)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_conexionAS400"
        Me.Text = "Importar pedido desde MIS"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.pan_btn.ResumeLayout(False)
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dts_as400, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Código de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_min.MouseEnter, Pic_close.MouseEnter, btn_salir.MouseEnter, btn_buscar.MouseEnter, btn_cargar.MouseEnter, btn_ninguno.MouseEnter, btn_todos.MouseEnter, btn_envMIS.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_min.MouseLeave, Pic_close.MouseLeave, btn_salir.MouseLeave, btn_buscar.MouseLeave, btn_cargar.MouseLeave, btn_ninguno.MouseLeave, btn_todos.MouseLeave, btn_envMIS.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.Click
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub

#End Region
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim items As Integer = 0
        If txt_parametro.Text <> "" And IsNumeric(txt_parametro.Text) = True Then
            items = opr_as400.countregistrosSQL(txt_parametro.Text)
            MsgBox(items)
            dts_as400.SetDataBinding(opr_as400.datosAS, "Registros")

            lbl_fecha.Text = items
            recibo = ""
            If items > 0 Then
                'CARGA LOS DATOS
                Dim dts_datos As New DataSet()
                btn_buscar.Tag = txt_parametro.Text
                dts_datos = opr_as400.LeerOrdenMISSQL(txt_parametro.Text)
                Dim dtr_fila As DataRow
                Dim contador As Short = 0
                Dim test As String = ""
                Dim BOO_PENDIENTES As Boolean = False
                Dim datos() As String
                Dim str_prueba As String = ""
                Dim tmp As String
                'función de limpieza de campos
                chk_testFactura.Items.Clear()
                If dts_datos.Tables(0).Rows.Count <> 0 Then
                    For Each dtr_fila In dts_datos.Tables("Registros").Rows
                        If contador = 0 Then
                            lbl_orden.Text = dtr_fila("DLNUOR")
                            lbl_paciente.Text = (Trim(dtr_fila("DLAPEL")) & " " & Trim(dtr_fila("DLNOMB")))
                            lbl_paciente.Tag = dtr_fila("DLCEDU")
                            lbl_hc.Text = dtr_fila("DLCEDU").ToString()
                            lbl_fecha.Text = Mid(dtr_fila("DLFECI"), 1, 4) & "-" & Mid(dtr_fila("DLFECI"), 5, 2) & "-" & Mid(dtr_fila("DLFECI"), 7, 2)
                            lbl_fecha.Tag = dtr_fila("DLCMED").ToString()

                            'verificacion de existencia de prueba
                            tmp = opr_as400.NombrePruebaSQL(dtr_fila("dlcexa").ToString())
                            If tmp <> "0" Then
                                chk_testFactura.Items.Insert(contador, tmp)
                                chk_testFactura.SetItemChecked(contador, True)
                                contador += 1
                            End If
                            btn_todos.Enabled = True
                            btn_ninguno.Enabled = True
                            BOO_PENDIENTES = True
                        Else
                            tmp = opr_as400.NombrePruebaSQL(dtr_fila("dlcexa").ToString())
                            If tmp <> "0" Then
                                chk_testFactura.Items.Insert(contador, tmp)
                                chk_testFactura.SetItemChecked(contador, True)
                                contador += 1
                            End If
                        End If
                        'ConAcciones(1)
                    Next
                End If
                If BOO_PENDIENTES = False Then
                    MsgBox("Esta orden no tiene pruebas pendientes.", MsgBoxStyle.Information, "ANALISYS")
                    dts_datos.Reset()
                    limpia_formulario()
                    Exit Sub
                    'Else
                    '    MsgBox("En esta operación quedaron pruebas pendientes de importación", MsgBoxStyle.Exclamation, "ANALISYS")
                End If
                dts_datos.Reset()
                OPR_TRABAJO.LlenarComboturno(Ctl_txt_num_turno, Now, cmb_tipo.Text)

            Else
                MsgBox("No se ha encontrado registros para la búsqueda realizada", MsgBoxStyle.Information, "ANALISYS")
                Call Me.limpia_formulario()
            End If
        Else
            MsgBox("Ingrese un valor válido para la búsqueda de la orden en el SIH.", MsgBoxStyle.Information, "ANALISYS")
        End If
    End Sub


    Private Sub btn_todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_todos.Click
        Dim i As Integer = 0
        For i = 0 To chk_testFactura.Items.Count - 1
            chk_testFactura.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btn_ninguno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ninguno.Click
        Dim i As Integer = 0
        For i = 0 To chk_testFactura.Items.Count - 1
            chk_testFactura.SetItemChecked(i, False)
        Next
    End Sub

    '    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
    '        'este proceso permite almacenar un pedido originado en el MIS 
    '        On Error GoTo msgerror
    '        'VERIFICO QUE AL MENOS UNA PRUEBA ESTE SELECCIONADA
    '        Dim i As Integer = 0
    '        Dim boo_items = False
    '        For i = 0 To chk_testFactura.Items.Count - 1
    '            If chk_testFactura.GetItemChecked(i) = True Then
    '                boo_items = True
    '                Exit For
    '            End If
    '        Next
    '        If boo_items = False Then
    '            MsgBox("Debe seleccionar al menos una prueba para crear el Pedido en ANALISYS", MsgBoxStyle.Exclamation, "ANALISYS")
    '            Exit Sub
    '        End If
    '        'Verifico que existan todos los datos necesarios 
    '        'VERIFICO EL TURNO
    '        Dim OPR_PEDIDO As New Cls_Pedido()
    '        'Dim OPR_SIS As New Cls_sistema()
    '        If OPR_PEDIDO.Existeturno(Now, Ctl_txt_num_turno.Text, 0, True, cmb_tipo.Text) = True Then
    '            MsgBox("El turno ingresado ya fue asignado, verifíquelo.", MsgBoxStyle.Exclamation, "ANALISYS")
    '            Exit Sub
    '        End If
    '        'DATOS DEL PACIENTE
    '        'VERIFICAR SI EL PACIENTE EXISTE EN CASO DE EXISTIR DEVOLVER EL PAC_ID CASO CONTRARIO CREAR EL PACIENTE.
    '        'Dim opr_as400 As New Cls_AS400()
    '        Dim pac_id As Integer
    '        Dim dts_datos As New DataSet()
    '        Dim dtr_fila As DataRow
    '        'no verifico la existencia del paciente, lo grabo con los datos del SIH, ya que los que existen pueden contener errores. 

    '        pac_id = opr_as400.existePacienteHC(lbl_paciente.Tag)

    '        If pac_id = 0 Then  'SI NO SE ENCONTRO EL PACIENTE
    '            'Creo el paciente
    '            dts_datos = opr_as400.LeerOrdenMISSQL(txt_parametro.Text, cmb_parametro.Text)
    '            For Each dtr_fila In dts_datos.Tables("Registros").Rows
    '                'DLNUOR,DLFECI,DLHIST,DLAPEL,DLNOMB,DLSEXO,DLFECN,DLCODM,DLCODS,DLCEDU,DLPROV,DLSALA,DLCAMA,DLCEXA FROM MISDTL WHERE DLNUOR =  " & orden & " ORDER BY DLCEXA;
    '                'pac_id = opr_as400.InsertPacienteSQL(dtr_fila("SIH_PCN_CEDULA").ToString, dtr_fila("SIH_PCN_APELLIDOS").ToString, dtr_fila("SIH_PCN_NOMBRES").ToString, dtr_fila("SIH_PCN_SEXO").ToString, dtr_fila("DLFECN"), dtr_fila("DLHIST").ToString, dtr_fila("DLTIPA").ToString)
    '                '************************
    '                'VERIFIAR POR QUE NO TRAE LA FECHA DE NACIEMINTO.
    '                '*************************                
    '                Dim fecnac As String = ""
    '                fecnac = dtr_fila("SIH_PCN_FECHA_NACIMIENTO").ToString
    '                pac_id = opr_as400.InsertPacienteSQL(dtr_fila("SIH_PCN_CEDULA").ToString, dtr_fila("SIH_PCN_APELLIDOS").ToString, dtr_fila("SIH_PCN_NOMBRES").ToString, dtr_fila("SIH_PCN_SEXO").ToString, fecnac, dtr_fila("SIH_PCN_NUMERO_HC").ToString, "NORMAL", dtr_fila("SIH_PCN_GRADO").ToString, dtr_fila("SIH_PCN_SITUACION").ToString)
    '                dts_datos.Reset()
    '                Exit For
    '            Next
    '            'dts_datos.Reset()
    '        End If
    '        'VERIFICAR LOS DATOS DEL MEDICO
    '        'VERIFICAR SI EL MEDICO EXISTE EN CASO DE EXISTIR DEVOLVER EL MED_ID CASO CONTRARIO CREARLO.
    '        Dim MED_ID As String = lbl_fecha.Tag  'NO EXISTEN REGISTROS CON ESE CODIGO DE MEDICO
    '        MED_ID = opr_as400.existeMEDICO(MED_ID)

    '        'PRIMERO SE PROCEDE A ALMACENAR EL PEDIDO (TABLA PEDIDO)
    '        'PROCEDO A ALMACENAR EL PEDIDO 
    '        Dim ped_id, tes_id As Integer
    '        dts_datos = opr_as400.LeerOrdenMISSQL(txt_parametro.Text, cmb_parametro.Text)
    '        For Each dtr_fila In dts_datos.Tables("Registros").Rows
    '            'Me.Ctl_txt_num_turno.texto_Asigna(CStr(opr_as400.MaxTurno(Now)))
    '            'ped_id = opr_as400.InsertPedido(pac_id, MED_ID, cmb_tipo.Text, Me.Ctl_txt_num_turno.texto_Recupera)
    '            ped_id = opr_as400.InsertPedido(pac_id, MED_ID, cmb_tipo.Text, Me.Ctl_txt_num_turno.Text, btn_buscar.Tag, recibo, "CE")
    '            Exit For
    '        Next
    '        'RECORRO LAS PRUEBAS QUE TIENE EL PEDIDO Y VOY ALMACENANDO LAS QUE ESTAN CHEQUEADAS...
    '        Dim precio As Double
    '        Dim tes_sih As String = ""
    '        Dim opr_trabajo As New Cls_Trabajo()
    '        'precio = 0
    '        For i = 0 To chk_testFactura.Items.Count - 1
    '            If chk_testFactura.GetItemChecked(i) = True Then
    '                tes_id = opr_as400.codigoTest(chk_testFactura.Items.Item(i))
    '                If tes_id <> 0 Then
    '                    'PEDIDO_DETALLE
    '                    opr_as400.InsertPedidoDetalle(i + 1, ped_id, tes_id)

    '                    'PEDIDO_DETALLE_DESGLOSADO
    '                    precio = opr_as400.consultaPrecio(tes_id, btn_buscar.Tag)
    '                    opr_as400.InsertPedidoDetalleDesglosado(ped_id, tes_id, precio)
    '                    'LISTA_TRABAJO Y RES_PROCESADOS
    '                    opr_as400.InsertLista_trabajo(ped_id, tes_id)
    '                    '*********************
    '                    'PRIMERO CONSULTO EL CODIGO DE LA PRUEBA EN EL SIH Y CON ESO ACTUALIZO EL CODIGO.
    '                    tes_sih = opr_as400.BuscaCodigoSIH(tes_id)
    '                    opr_as400.ActualizoRegistroLeido(CInt(Trim(txt_parametro.Text)), tes_sih, ped_id, cmb_parametro.Text)
    '                    '*********************
    '                Else
    '                    MsgBox("En este pedido existe la prueba " & chk_testFactura.Items.Item(i) & " que no es reconocida .", MsgBoxStyle.Exclamation, "ANALISYS")
    '                End If
    '            End If
    '        Next


    '        'PREGUNTO SI DESEA IMPRIMIR ETIQUETAS Y LAS IMPRIMO

    '        opr_as400.imprimir_codigo(ped_id, Ctl_txt_num_turno.Text, lbl_paciente.Text, "NORMAL")
    '        MsgBox("Orden creada.", MsgBoxStyle.Information, "ANALISYS")
    '        Call limpia_formulario()
    '        opr_trabajo.LlenarComboturno(Ctl_txt_num_turno, Now, cmb_tipo.Text)
    '        Exit Sub
    'msgerror:
    '        MsgBox("No se ha podido realizar la operación solicitada.", MsgBoxStyle.Exclamation, "ANALISYS")
    '    End Sub


    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        'este proceso permite almacenar un pedido originado en el MIS 
        'VERIFICO QUE AL MENOS UNA PRUEBA ESTE SELECCIONADA
        Dim Fecha_ped As Date = Format(Now, "yyyy-MM-dd")
        Dim i As Integer = 0
        Dim boo_items = False
        Dim OPR_AS400 As New Cls_AS400()

        Try
            'PASO 1
            'VERIFICO PRUEBAS MARCADAS A IMPORTAR
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            For i = 0 To chk_testFactura.Items.Count - 1
                If chk_testFactura.GetItemChecked(i) = True Then
                    boo_items = True
                    Exit For
                End If
            Next
            If boo_items = False Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("Debe escoger al menos una prueba para proceder a la importación de la Orden", MsgBoxStyle.Exclamation, "ANALISYS")
                Exit Sub
            End If

            'PASO 2
            'Verifico que existan todos los datos necesarios 
            Dim OPR_PEDIDO As New Cls_Pedido()
            Dim OPR_SIS As New Cls_sistema()
            Dim pac_id As Integer
            Dim dts_datos As New DataSet()
            Dim dtr_fila As DataRow
            pac_id = OPR_AS400.existePacienteHC(Trim(lbl_hc.Text))
            dts_datos = OPR_AS400.LeerOrdenMISSQL(txt_parametro.Text)
            For Each dtr_fila In dts_datos.Tables("Registros").Rows
                If pac_id = 0 Then
                    'Crea el paciente
                    'verifica la cedula
                    Dim cedula As String = ""
                    If dtr_fila("DLCEDU").ToString = "" Then
                        cedula = "0000000000"
                    Else
                        cedula = dtr_fila("DLCEDU")
                    End If
                    'verifica el sexo del paciente
                    Dim sexo As String = ""
                    If dtr_fila("DLSEXO").ToString = "" Then
                        sexo = ""
                    Else
                        sexo = dtr_fila("DLSEXO")
                    End If
                    'verifica el tipo paciente
                    Dim tipo_pac As String = ""
                    If dtr_fila("DLTIPA").ToString = "" Then
                        tipo_pac = "G"
                    Else
                        tipo_pac = dtr_fila("DLTIPA")
                    End If
                    'verifica fecha de nacimiento del paciente
                    Dim fecnac As String = ""
                    If dtr_fila("DLFECN").ToString = "" Then
                        fecnac = ""
                    Else
                        'fecnac = Mid(dtr_fila("DLFECN"), 1, 4) & "-" & Mid(dtr_fila("DLFECN"), 5, 2) & "-" & Mid(dtr_fila("DLFECN"), 7, 2)
                        fecnac = dtr_fila("DLFECN").ToString
                    End If
                    pac_id = OPR_AS400.InsertPacienteSQL(cedula, dtr_fila("DLAPEL").ToString, dtr_fila("DLNOMB").ToString, sexo, fecnac, dtr_fila("DLHIST").ToString, tipo_pac)
                    Exit For
                Else
                    OPR_AS400.ActualizaDatosPacienteHC(lbl_paciente.Tag, dtr_fila("DLAPEL").ToString, dtr_fila("DLNOMB").ToString)
                    Exit For
                End If
            Next

            'PASO 3
            'VERIFICAR LOS DATOS DEL MEDICO
            Dim MED_ID As Integer = lbl_fecha.Tag  'NO EXISTEN REGISTROS CON ESE CODIGO DE MEDICO
            If IsNumeric(lbl_fecha.Tag) Then
                If OPR_AS400.existeMEDICO(MED_ID) = 0 Then
                    MED_ID = 0
                End If
            Else
                MED_ID = 0
            End If

            'PASO 4
            'PRIMERO SE PROCEDE A ALMACENAR EL PEDIDO (TABLA PEDIDO)
            'PROCEDO A ALMACENAR EL PEDIDO 
            Dim ped_id, tes_id As Integer
            If dts_datos.Tables(0).Rows.Count <> 0 Then
                For Each dtr_fila In dts_datos.Tables("Registros").Rows
                    'DLNUOR,DLFECI,DLHIST,DLAPEL,DLNOMB,DLSEXO,DLFECN,DLCODM,DLCODS,DLCEDU,DLPROV,DLSALA,DLCAMA,DLCEXA FROM MISDTL WHERE DLNUOR =  " & orden & " ORDER BY DLCEXA;
                    'Dim sala As Integer = OPR_AS400.consultaExisteSALA(dtr_fila("DLSALA"))
                    Dim sala As Integer = 0
                    If sala = 0 Then
                        '*** 20-11-2006 comentario para evitar la colision de turnos
                        Ctl_txt_num_turno.Text = (CStr(OPR_AS400.MaxTurno(Fecha_ped) + 1))
                        If OPR_PEDIDO.Existeturno(Today, Ctl_txt_num_turno.Text) = True Then
                            Me.Cursor = System.Windows.Forms.Cursors.Arrow
                            MsgBox("El turno ingresado ya existe, verifíquelo.", MsgBoxStyle.Exclamation, "ANALISYS")
                            Exit Sub
                        End If
                        ped_id = OPR_AS400.InsertPedido(pac_id, MED_ID, Ctl_txt_num_turno.Text, 0, dtr_fila("DLNUOR"))
                        'ConAcciones(2)
                    Else
                        '*** 20-11-2006 comentario para evitar la colision de turnos
                        Ctl_txt_num_turno.Text = (CStr(OPR_AS400.MaxTurno(Fecha_ped) + 1))
                        If OPR_PEDIDO.Existeturno(Today, Ctl_txt_num_turno.Text) = True Then
                            Me.Cursor = System.Windows.Forms.Cursors.Arrow
                            MsgBox("El turno ingresado ya existe, verifíquelo.", MsgBoxStyle.Exclamation, "ANALISYS")
                            Exit Sub
                        End If
                        ped_id = OPR_AS400.InsertPedido(pac_id, MED_ID, Ctl_txt_num_turno.Text, dtr_fila("DLSALA"), dtr_fila("DLNUOR"))
                        'ConAcciones(2)
                    End If
                    dts_datos.Dispose()
                    dts_datos.Reset()
                    Exit For
                Next
            End If

            'verifica de que halla grabado la cabecera del pedido con un ped_id
            If ped_id = 0 Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("No se grabó el pedido, por favor intente de nuevo.", MsgBoxStyle.Exclamation, "ANALISYS")
                Call limpia_formulario()
                Exit Sub
            End If

            'PASO 5
            'si grabo cabecera del pedido y todo esta ok hasta este punto.
            'RECORRO LAS PRUEBAS QUE TIENE EL PEDIDO Y VOY ALMACENANDO LAS QUE ESTAN CHEQUEADAS...
            Dim bandera As Boolean = False
            Dim oConexion As OleDbConnection
            oConexion = New OleDbConnection(g_str_conexion)
            Dim sql_trans As OleDbTransaction
            Try
                oConexion.Open()
                'sql_trans = oConexion.BeginTransaction
                For i = 0 To chk_testFactura.Items.Count - 1
                    If chk_testFactura.GetItemChecked(i) = True Then
                        tes_id = OPR_AS400.codigoTest(chk_testFactura.Items.Item(i))
                        If tes_id <> 0 Then
                            OPR_AS400.InsertPedidoDetalle(i + 1, ped_id, tes_id, oConexion) 'PEDIDO DETALLE
                            'ConAcciones(3)
                            OPR_AS400.InsertPedidoDetalleDesglosado(ped_id, tes_id, oConexion) 'PEDIDO DETALLE DESGLOSADO
                            'ConAcciones(4)
                            If OPR_AS400.InsertLista_trabajo(ped_id, tes_id) = False Then 'LISTA TRABAJO
                                'sql_trans.Rollback()
                                'CREAR UNA RUTINA PARA REVERSAR EL INGRESO.....

                                MsgBox("Se ha producido el siguiente error: ", Err.Description)
                                Exit Sub
                            End If

                            'COMENTADO HASTA VERIFICAR PROBLEMA.

                            OPR_AS400.ActualizoRegistroLeido(CInt(Trim(txt_parametro.Text)), tes_id) 'ACTUALIZAO DATO TEST MIS


                        Else
                            Me.Cursor = System.Windows.Forms.Cursors.Arrow
                            MsgBox("En este pedido existe la prueba " & chk_testFactura.Items.Item(i) & " que no es reconocida por ANALISYS", MsgBoxStyle.Exclamation, "ANALISYS")
                        End If
                    End If
                Next
                'sql_trans.Commit()
                If bandera = True Then
                    'Guarda_Tiempos(ped_id, Ctl_txt_num_turno.texto_Recupera)
                End If
            Catch
                MsgBox(Err.Description)
                sql_trans.Rollback()
                RutinaError(Err.Number, Err.Description)
                Err.Clear()
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                Exit Sub
            Finally
                oConexion.Close()
                oConexion = Nothing
            End Try

            'PASO 6
            'IMPRIME LA ETIQUETA DE CÓDIGO DE BARRAS
            Dim hc As String = OPR_AS400.ConsultaHCxpedido(ped_id)
            OPR_AS400.imprimir_codigo(ped_id, Ctl_txt_num_turno.Text, lbl_paciente.Text, hc, Trim(txt_parametro.Text))
            'ConAcciones(7)
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("Orden Importada satisfactoriamente." & Chr(13) & "TURNO: " & Ctl_txt_num_turno.Text, MsgBoxStyle.Information, "ANALISYS")
            'SinAcciones()
            bandera = False

            'PASO 7
            'verifico las pruebas desmarcadas
            Dim j As Integer
            Dim flag As Boolean
            For j = 0 To chk_testFactura.Items.Count - 1
                If chk_testFactura.GetItemChecked(j) = False Then
                    flag = True
                    Exit For
                End If
            Next
            'invoco al formulario de test_pendientes de importar
            If flag = True Then
                orden = Trim(txt_parametro.Text)
                'If Not ExisteForm("Frm_TestPendientes") Then
                '    Dim frm_MDIChild As New Frm_TestPendientes()
                '    frm_MDIChild.frm_refer_main_form = frm_refer_main
                '    frm_MDIChild.MdiParent = frm_refer_main.ParentForm
                '    frm_MDIChild.ShowDialog(frm_refer_main.ParentForm)
                'End If
            End If
            orden = ""

            'PASO 8
            'termina la orden
            Call limpia_formulario()
            txt_parametro.Focus()
            Exit Sub
        Catch
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("No se hapodido realizar la operación solicitada.", MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Sub


    Public Sub limpia_formulario()
        txt_parametro.Text = ""
        'Ctl_txt_num_turno.texto_Asigna("")
        chk_testFactura.Items.Clear()
        btn_todos.Enabled = False
        btn_ninguno.Enabled = False
        cmb_tipo.Text = "URGENCIA"
        cmb_tipo.Text = "NORMAL"
        lbl_paciente.Text = ""
        lbl_orden.Text = ""
        lbl_fecha.Text = ""
        lbl_hc.Text = ""
        lbl_orden.Tag = ""
        tipo = ""
        btn_buscar.Tag = ""
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_conexionAS400_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        'Dim opr_sys As New Cls_sistema()
        'cmb_operador.SelectedIndex = 0
        'cmb_parametro.SelectedIndex = 0
        cmb_tipo.SelectedIndex = 0
        txt_parametro.Focus()
        Me.cmb_tipo.Text = "NORMAL"

        'dtp_fecha.Value = opr_sys.ahora
    End Sub

    Private Sub cmb_operador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_operador.SelectedIndexChanged
        Call limpia_formulario()
        If cmb_operador.Text = "EXPORTAR" Then
            Label1.Text = "Número de turno ANALISYS:"
            Label6.Text = "Orden MIS:"
            btn_cargar.Enabled = False
            btn_envMIS.Enabled = True
            'Ctl_txt_num_turno.ReadOnly = False
            'dtp_fecha.Visible = True
        Else
            Label1.Text = "Número de Orden MIS:"
            Label6.Text = "Turno:"
            btn_cargar.Enabled = True
            btn_envMIS.Enabled = False
            'Ctl_txt_num_turno.txt_padre.ReadOnly = True
            'dtp_fecha.Visible = False
        End If

    End Sub

    Private Sub btn_envMIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_envMIS.Click
        On Error GoTo MSGERROR
        If Me.chk_testFactura.Items.Count = 0 Then
            MsgBox("El pedido seleccionado no tiene items pendientes de envio al MIS.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        End If
        If Ctl_txt_num_turno.Text = "" Or Ctl_txt_num_turno.Text = "0" Then
            MsgBox("El pedido seleccionado no posee número de Orden MIS asociado.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        End If
        Dim boo_orden As Boolean
        Dim opr_pedido As New Cls_Pedido()
        'boo_orden = opr_pedido.ExisteOrden(Ctl_txt_num_turno.Text)
        'Dim opr_as400 As New Cls_AS400()
        If boo_orden = True Then
            MsgBox("El número de orden ingresado ya existe, verifíquelo.", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        Else
            opr_as400.ActualizaOrdenMIS(lbl_orden.Tag, CStr(Ctl_txt_num_turno.Text))
        End If

        Dim opr_trabajo As New Cls_Trabajo()
        Dim dts_datos As DataSet = opr_as400.Cons_ResManSinVal(lbl_orden.Tag, 1)
        Dim dtr_reg As DataRow
        For Each dtr_reg In dts_datos.Tables("Registros").Rows
            'VOY GRABANDO EN LA TABLA DTLMIS
            If opr_as400.INSERTRESMANUALVALIDADO(dtr_reg("ped_id"), dtr_reg("tes_id"), dtr_reg("LIS_RESMANUAL")) = True Then
                'VOY ACTUALIZANDO LOS ESTADOS DE LOS ITEMS EN LA LISTA DE TRABAJO CON LIS_RESESTADO = 7
                opr_trabajo.CambioEstadoItemLista(dtr_reg("LIS_id"), 7)
            End If
        Next
        dts_datos.Reset()
        'CONSULTO TODO LAS PRUEBAS AUTOMATICAS QUE NO REQUIEREN VALIDACION QUE ESTAN PENDIENTES DE TRANSMISION
        '''frm_refer_main_form.escribemsj("ENVIANDO RESULTADOS EQP. AL MIS, ESPERE POR FAVOR")
        Dim int_lis_id As Integer
        dts_datos = opr_as400.Cons_ResEQPSinVal(lbl_orden.Tag, 1)
        For Each dtr_reg In dts_datos.Tables("Registros").Rows
            int_lis_id = opr_trabajo.Leer_Lis_ID(CInt(dtr_reg("PED_ID")), dtr_reg("TES_ABREV"), dtr_reg("tim_id"))
            If opr_as400.consultaestadoLT(int_lis_id) = 2 Then  'LA PRUEBA SE ENCUENTRA CONFIRMADA Y LISTA PARA ENVIO
                'ENVIO AL MIS 
                If opr_as400.INSERTRESMANUALVALIDADO(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("RESULTADO")) = True Then
                    'ACTUALIZO EL ESTADO DE LA LISTA DE TRABAJO A ESTADO 7 (ENVIADO A MIS)
                    opr_trabajo.CambioEstadoItemLista(int_lis_id, 7)
                End If
            End If
        Next
        dts_datos.Reset()
        'ENVIO INFORMACION DE CULTIVOS
        dts_datos = opr_as400.Cons_ResCultSinVal(lbl_orden.Tag, 1)
        Dim DTR_ANTIBIOTICO As DataRow
        Dim dts_antibiograma As DataSet
        Dim boo_cultivo As Boolean = False
        For Each dtr_reg In dts_datos.Tables("Registros").Rows
            'consulto los resultados generales del cultivo y luego si tiene antibiograma 
            dts_antibiograma = opr_as400.LeerAntibiograma(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("gre_id"))
            For Each DTR_ANTIBIOTICO In dts_antibiograma.Tables("Registros").Rows
                'si el cultivo tiene antibiograma grabo el mismo
                boo_cultivo = True
                If opr_as400.INSERTCULTIVO_MIS(dtr_reg("PED_ID"), dtr_reg("TES_ID"), DTR_ANTIBIOTICO("ger_nombre"), DTR_ANTIBIOTICO("ANT_NOMBRE"), DTR_ANTIBIOTICO("atb_interpretacion"), DTR_ANTIBIOTICO("mre_obs")) = True Then
                    opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 7)
                End If
            Next
            If boo_cultivo = False Then   ''CULTIVO NO TIENE ANTIBIOGRAMA GRABO LOS RESULTADOS DE COMENTARIOS 
                If opr_as400.INSERTCULTIVO_MIS(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("ger_nombre"), " ", " ", dtr_reg("mre_obs")) = True Then
                    opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 7)
                End If
            End If
            dts_antibiograma.Reset()
        Next
        dts_datos.Reset()
        limpia_formulario()
        MsgBox("Exportación Exitosa.", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MSGERROR:
        Err.Clear()
        MsgBox("No se ha podido realizar la operación solicitada. " & Err.Description, MsgBoxStyle.Information, "ANALISYS")
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo.SelectedIndexChanged
        Dim OPR_TRABAJO As New Cls_Trabajo()
        'Ctl_txt_num_turno.texto_Asigna(CStr(opr_as400.MaxTurno(Now, cmb_tipo.Text)))
        OPR_TRABAJO.LlenarComboturno(Ctl_txt_num_turno, Now, cmb_tipo.Text)

    End Sub

    Private Sub Ctl_txt_num_turno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2tl_txt_num_turno.Load

    End Sub


    Private Sub Ctl_txt_num_turno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2tl_txt_num_turno.TextChanged
        'btn_buscar.Tag = Ctl_txt_num_turno.Text
    End Sub

    Private Sub Ctl_txt_num_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_num_turno.SelectedIndexChanged
        If IsNumeric(Ctl_txt_num_turno.Text) Then
            If CInt(Ctl_txt_num_turno.Text) > 200 And Me.cmb_tipo.Text = "NORMAL" Then
                MsgBox("POR FAVOR VERIFIQUE EL TIPO DE PEDIDO Y EL TURNO, EL PEDIDO ES DE RUTINA?", MsgBoxStyle.Exclamation, "ANALISYS")
            End If
        End If
    End Sub
End Class
