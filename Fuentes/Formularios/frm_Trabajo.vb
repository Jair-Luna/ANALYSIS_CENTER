Imports System.IO

Public Class frm_Trabajo
    Inherits System.Windows.Forms.Form
    Private m_cls_dgimpresion As cls_dgimpresion = Nothing

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
    Friend WithEvents lst_trabajo As System.Windows.Forms.ListBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgrd_trabajo As System.Windows.Forms.DataGrid
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents dtp_fecing As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_enviar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGTBC_EQUIPO As DataGridTextBoxColumn = New DataGridTextBoxColumn()
    Friend WithEvents DGTBC_TUBO As DataGridTextBoxColumn = New DataGridTextBoxColumn()
    Friend WithEvents DGTBC_POS As DataGridTextBoxColumn = New DataGridTextBoxColumn()
    Friend WithEvents DGTBC_MUESTRA As DataGridTextBoxColumn = New DataGridTextBoxColumn()
    Friend WithEvents DGTBC_RACK As DataGridTextBoxColumn = New DataGridTextBoxColumn()
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents panestado As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_vistas As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents pic_exp As System.Windows.Forms.PictureBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btn_lista As System.Windows.Forms.Button
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_num As System.Windows.Forms.Label
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents btn_estado As System.Windows.Forms.Button
    Friend WithEvents btn_envioMIS As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_corden As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_prioridad As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents cmb_eqp As System.Windows.Forms.ComboBox
    Friend WithEvents btn_HojaRes As System.Windows.Forms.Button
    Friend WithEvents btn_Cuadricula As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Trabajo))
        Me.lst_trabajo = New System.Windows.Forms.ListBox
        Me.dgrd_trabajo = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.dtp_fecing = New System.Windows.Forms.DateTimePicker
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_enviar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.panestado = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_vistas = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmb_area = New System.Windows.Forms.ComboBox
        Me.pic_exp = New System.Windows.Forms.PictureBox
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.btn_lista = New System.Windows.Forms.Button
        Me.btn_cargar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_num = New System.Windows.Forms.Label
        Me.btn_actualizar = New System.Windows.Forms.Button
        Me.btn_estado = New System.Windows.Forms.Button
        Me.btn_envioMIS = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_corden = New System.Windows.Forms.Button
        Me.cmb_prioridad = New System.Windows.Forms.ComboBox
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.cmb_eqp = New System.Windows.Forms.ComboBox
        Me.btn_HojaRes = New System.Windows.Forms.Button
        Me.btn_Cuadricula = New System.Windows.Forms.Button
        CType(Me.dgrd_trabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panestado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_exp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_trabajo
        '
        Me.lst_trabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_trabajo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_trabajo.ItemHeight = 14
        Me.lst_trabajo.Location = New System.Drawing.Point(160, 262)
        Me.lst_trabajo.Name = "lst_trabajo"
        Me.lst_trabajo.ScrollAlwaysVisible = True
        Me.lst_trabajo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lst_trabajo.Size = New System.Drawing.Size(358, 72)
        Me.lst_trabajo.TabIndex = 2
        Me.lst_trabajo.Visible = False
        '
        'dgrd_trabajo
        '
        Me.dgrd_trabajo.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_trabajo.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_trabajo.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_trabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_trabajo.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_trabajo.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_trabajo.CaptionText = "LISTA DE TRABAJO"
        Me.dgrd_trabajo.DataMember = ""
        Me.dgrd_trabajo.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_trabajo.ForeColor = System.Drawing.Color.Black
        Me.dgrd_trabajo.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_trabajo.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_trabajo.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_trabajo.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_trabajo.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_trabajo.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_trabajo.Location = New System.Drawing.Point(18, 134)
        Me.dgrd_trabajo.Name = "dgrd_trabajo"
        Me.dgrd_trabajo.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_trabajo.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_trabajo.RowHeaderWidth = 5
        Me.dgrd_trabajo.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_trabajo.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_trabajo.Size = New System.Drawing.Size(773, 424)
        Me.dgrd_trabajo.TabIndex = 3
        Me.dgrd_trabajo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_trabajo
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.RowHeaderWidth = 10
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(290, 422)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 24)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "Guardar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        Me.btn_aceptar.Visible = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(551, 77)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(87, 40)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'dtp_fecing
        '
        Me.dtp_fecing.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_fecing.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecing.Location = New System.Drawing.Point(18, 40)
        Me.dtp_fecing.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecing.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecing.Name = "dtp_fecing"
        Me.dtp_fecing.Size = New System.Drawing.Size(81, 21)
        Me.dtp_fecing.TabIndex = 0
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.Location = New System.Drawing.Point(121, 76)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(102, 40)
        Me.btn_imprimir.TabIndex = 6
        Me.btn_imprimir.Text = "Lista Trabajo"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_enviar
        '
        Me.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enviar.ForeColor = System.Drawing.Color.Black
        Me.btn_enviar.Image = CType(resources.GetObject("btn_enviar.Image"), System.Drawing.Image)
        Me.btn_enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enviar.Location = New System.Drawing.Point(248, 386)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(80, 24)
        Me.btn_enviar.TabIndex = 5
        Me.btn_enviar.Text = "Enviar"
        Me.btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enviar.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(160, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 15)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "PEDIDOS PENDIENTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'panestado
        '
        Me.panestado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.panestado.Controls.Add(Me.PictureBox1)
        Me.panestado.Controls.Add(Me.Label10)
        Me.panestado.Controls.Add(Me.Label5)
        Me.panestado.Controls.Add(Me.PictureBox2)
        Me.panestado.Controls.Add(Me.PictureBox4)
        Me.panestado.Controls.Add(Me.PictureBox5)
        Me.panestado.Controls.Add(Me.Label4)
        Me.panestado.Controls.Add(Me.Label3)
        Me.panestado.Controls.Add(Me.Label2)
        Me.panestado.Controls.Add(Me.PictureBox3)
        Me.panestado.Location = New System.Drawing.Point(345, 216)
        Me.panestado.Name = "panestado"
        Me.panestado.Size = New System.Drawing.Size(420, 16)
        Me.panestado.TabIndex = 98
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(352, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(368, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Remitido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Rechazado"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 12)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(195, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 12)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(264, -1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 12)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Validado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Procesado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enviado al equipo"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(114, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 12)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
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
        'cmb_vistas
        '
        Me.cmb_vistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_vistas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_vistas.Items.AddRange(New Object() {"<Todos>", "Pendientes", "Validados", "Impresos"})
        Me.cmb_vistas.Location = New System.Drawing.Point(264, 11)
        Me.cmb_vistas.Name = "cmb_vistas"
        Me.cmb_vistas.Size = New System.Drawing.Size(110, 21)
        Me.cmb_vistas.TabIndex = 1
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
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_area.Location = New System.Drawing.Point(40, 11)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(161, 21)
        Me.cmb_area.TabIndex = 106
        '
        'pic_exp
        '
        Me.pic_exp.Image = CType(resources.GetObject("pic_exp.Image"), System.Drawing.Image)
        Me.pic_exp.Location = New System.Drawing.Point(516, 250)
        Me.pic_exp.Name = "pic_exp"
        Me.pic_exp.Size = New System.Drawing.Size(20, 13)
        Me.pic_exp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_exp.TabIndex = 108
        Me.pic_exp.TabStop = False
        Me.pic_exp.Tag = "exp"
        Me.pic_exp.Visible = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Lista De Trabajo"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'btn_lista
        '
        Me.btn_lista.BackColor = System.Drawing.SystemColors.Control
        Me.btn_lista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lista.ForeColor = System.Drawing.Color.Black
        Me.btn_lista.Image = CType(resources.GetObject("btn_lista.Image"), System.Drawing.Image)
        Me.btn_lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lista.Location = New System.Drawing.Point(224, 76)
        Me.btn_lista.Name = "btn_lista"
        Me.btn_lista.Size = New System.Drawing.Size(99, 40)
        Me.btn_lista.TabIndex = 109
        Me.btn_lista.Text = "Hoja Trabajo"
        Me.btn_lista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_lista.UseVisualStyleBackColor = False
        '
        'btn_cargar
        '
        Me.btn_cargar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar.ForeColor = System.Drawing.Color.Black
        Me.btn_cargar.Image = CType(resources.GetObject("btn_cargar.Image"), System.Drawing.Image)
        Me.btn_cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cargar.Location = New System.Drawing.Point(302, 208)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cargar.TabIndex = 110
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar.UseVisualStyleBackColor = False
        Me.btn_cargar.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(674, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 18)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "TOTAL:"
        '
        'lbl_num
        '
        Me.lbl_num.BackColor = System.Drawing.Color.Transparent
        Me.lbl_num.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl_num.Location = New System.Drawing.Point(722, 97)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(64, 20)
        Me.lbl_num.TabIndex = 112
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.ForeColor = System.Drawing.Color.Black
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.Location = New System.Drawing.Point(447, 39)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(80, 24)
        Me.btn_actualizar.TabIndex = 113
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.UseVisualStyleBackColor = False
        Me.btn_actualizar.Visible = False
        '
        'btn_estado
        '
        Me.btn_estado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estado.ForeColor = System.Drawing.Color.Black
        Me.btn_estado.Image = CType(resources.GetObject("btn_estado.Image"), System.Drawing.Image)
        Me.btn_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_estado.Location = New System.Drawing.Point(432, 446)
        Me.btn_estado.Name = "btn_estado"
        Me.btn_estado.Size = New System.Drawing.Size(80, 24)
        Me.btn_estado.TabIndex = 114
        Me.btn_estado.Text = "C. Estado"
        Me.btn_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estado.Visible = False
        '
        'btn_envioMIS
        '
        Me.btn_envioMIS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_envioMIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_envioMIS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_envioMIS.ForeColor = System.Drawing.Color.Black
        Me.btn_envioMIS.Image = CType(resources.GetObject("btn_envioMIS.Image"), System.Drawing.Image)
        Me.btn_envioMIS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_envioMIS.Location = New System.Drawing.Point(338, 386)
        Me.btn_envioMIS.Name = "btn_envioMIS"
        Me.btn_envioMIS.Size = New System.Drawing.Size(80, 24)
        Me.btn_envioMIS.TabIndex = 119
        Me.btn_envioMIS.Text = "Enva  MIS"
        Me.btn_envioMIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_envioMIS.Visible = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(248, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 37)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        '
        'btn_corden
        '
        Me.btn_corden.BackColor = System.Drawing.SystemColors.Control
        Me.btn_corden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_corden.ForeColor = System.Drawing.Color.Black
        Me.btn_corden.Image = CType(resources.GetObject("btn_corden.Image"), System.Drawing.Image)
        Me.btn_corden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_corden.Location = New System.Drawing.Point(18, 76)
        Me.btn_corden.Name = "btn_corden"
        Me.btn_corden.Size = New System.Drawing.Size(102, 40)
        Me.btn_corden.TabIndex = 121
        Me.btn_corden.Text = "Horizontal"
        Me.btn_corden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_corden.UseVisualStyleBackColor = False
        '
        'cmb_prioridad
        '
        Me.cmb_prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prioridad.Location = New System.Drawing.Point(105, 40)
        Me.cmb_prioridad.Name = "cmb_prioridad"
        Me.cmb_prioridad.Size = New System.Drawing.Size(115, 21)
        Me.cmb_prioridad.TabIndex = 122
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(9, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(132, 14)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "LISTAS DE TRABAJO"
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(813, 25)
        Me.pan_barra.TabIndex = 101
        '
        'cmb_eqp
        '
        Me.cmb_eqp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_eqp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_eqp.Location = New System.Drawing.Point(540, 191)
        Me.cmb_eqp.Name = "cmb_eqp"
        Me.cmb_eqp.Size = New System.Drawing.Size(110, 21)
        Me.cmb_eqp.TabIndex = 104
        '
        'btn_HojaRes
        '
        Me.btn_HojaRes.BackColor = System.Drawing.SystemColors.Control
        Me.btn_HojaRes.Image = CType(resources.GetObject("btn_HojaRes.Image"), System.Drawing.Image)
        Me.btn_HojaRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_HojaRes.Location = New System.Drawing.Point(464, 77)
        Me.btn_HojaRes.Name = "btn_HojaRes"
        Me.btn_HojaRes.Size = New System.Drawing.Size(87, 40)
        Me.btn_HojaRes.TabIndex = 123
        Me.btn_HojaRes.Text = "Buscar"
        Me.btn_HojaRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_HojaRes.UseVisualStyleBackColor = False
        '
        'btn_Cuadricula
        '
        Me.btn_Cuadricula.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cuadricula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cuadricula.ForeColor = System.Drawing.Color.Black
        Me.btn_Cuadricula.Image = CType(resources.GetObject("btn_Cuadricula.Image"), System.Drawing.Image)
        Me.btn_Cuadricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cuadricula.Location = New System.Drawing.Point(325, 76)
        Me.btn_Cuadricula.Name = "btn_Cuadricula"
        Me.btn_Cuadricula.Size = New System.Drawing.Size(93, 40)
        Me.btn_Cuadricula.TabIndex = 124
        Me.btn_Cuadricula.Text = "Cuadricula"
        Me.btn_Cuadricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cuadricula.UseVisualStyleBackColor = False
        '
        'frm_Trabajo
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(813, 570)
        Me.Controls.Add(Me.btn_Cuadricula)
        Me.Controls.Add(Me.btn_HojaRes)
        Me.Controls.Add(Me.dgrd_trabajo)
        Me.Controls.Add(Me.cmb_prioridad)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_corden)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.lbl_num)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_lista)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.panestado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dtp_fecing)
        Me.Controls.Add(Me.btn_estado)
        Me.Controls.Add(Me.btn_envioMIS)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.lst_trabajo)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.pic_exp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_eqp)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Trabajo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Trabajo"
        CType(Me.dgrd_trabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panestado.ResumeLayout(False)
        Me.panestado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_exp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim opr_user As New Cls_Usuario()
    Dim int_i As Short
    Dim arr_datos As New ArrayList()
    Dim arr_nombre As New ArrayList()
    Dim opr_pedido As New Cls_Pedido()

    Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_parametro As New Cls_Parametros()
    Private WithEvents dtt_trabajo As New DataTable("Registros")
    Dim dtv_trabajo As New DataView(dtt_trabajo)
    Private WithEvents cmb_equipo As New ComboBox()
    Private WithEvents cmb_tubo As New ComboBox()
    Private WithEvents cmb_muestra As New ComboBox()
    Private WithEvents cmb_rack As New ComboBox()
    Private Arr_str_Muestra() As String
    Private boo_cambia As Boolean = True
    Private PRIORIDAD As String = "NORMAL"


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

    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

#Region "Inicia Formulario"

    Dim str_areas As String = ""

    Private Sub frm_Lista_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'On Error Resume Next
        Me.Cursor = Cursors.WaitCursor
        'frm_refer_main.sta_barmain.Panels(2).Text = "DESGLOSANDO PEDIDOS, ESPERE POR FAVOR"
        ''carga los datos especificados para el Club de Leones
        '''frm_refer_main_form.escribemsj("CARGANDO PEDIDOS PENDIENTES")
        'Dim opr_clubleones As New Cls_ClubLeones()
        'If opr_clubleones.CDL_InsertaPedido() = 1 Then
        '    ''frm_refer_main_form.escribemsj("DISPONIBLE")
        'Else
        '    ''frm_refer_main_form.escribemsj("ERROR AL CARGAR DATOS PENDIENTES")
        'End If
        'dtp_fecing.CustomFormat = "dd-MMM-yyyy"
        DGTBC_EQUIPO.Format = String.Empty
        DGTBC_EQUIPO.HeaderText = "Equipo"
        DGTBC_EQUIPO.MappingName = "equipo"
        DGTBC_EQUIPO.Width = 82
        DGTBC_EQUIPO.NullText = ""
        DGTBC_MUESTRA.Format = String.Empty
        DGTBC_MUESTRA.HeaderText = "Muestra"
        DGTBC_MUESTRA.MappingName = "muestra"
        DGTBC_MUESTRA.Width = 65
        DGTBC_MUESTRA.NullText = ""
        DGTBC_TUBO.Format = String.Empty
        DGTBC_TUBO.HeaderText = "Tubo"
        DGTBC_TUBO.MappingName = "tubo"
        DGTBC_TUBO.Width = 75
        DGTBC_TUBO.NullText = ""
        DGTBC_RACK.Format = String.Empty
        DGTBC_RACK.HeaderText = "Rack"
        DGTBC_RACK.MappingName = "rack"
        DGTBC_RACK.Width = 38
        DGTBC_RACK.NullText = ""
        DGTBC_POS.Format = "###"
        DGTBC_POS.HeaderText = "Pos"
        DGTBC_POS.MappingName = "pos"
        DGTBC_POS.Width = 28
        DGTBC_POS.NullText = "--"

        ''frm_refer_main_form.escribemsj("CARGANDO CONFIGURACIONES")

        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "# Ped", "ped_id", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Turno", "turno", 70, True, ""))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Paciente", "paciente", 250))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Test", "tes_nombre", 140))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "", "tes_id", 0))
        DataGridTableStyle1.GridColumnStyles.Add(DGTBC_EQUIPO)
        DataGridTableStyle1.GridColumnStyles.Add(DGTBC_MUESTRA)
        DataGridTableStyle1.GridColumnStyles.Add(DGTBC_TUBO)
        DataGridTableStyle1.GridColumnStyles.Add(DGTBC_RACK)
        DataGridTableStyle1.GridColumnStyles.Add(DGTBC_POS)
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_Grafica("Est", "graf_estado", 16, False))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "tuboid", "tuboid", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "mdideqp", "mdideqp", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "mdidtest", "mdidtest", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable("#", "per_id", "per_id", 0, , 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable("#", "nuevo", "nuevo", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "tipmuestra", "tipmuestra", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "tipracks", "tipracks", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "equerror", "equerror", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "areaid", "areaid", 0))

        AddHandler DGTBC_EQUIPO.TextBox.Enter, AddressOf CargarCombo_Eqp
        AddHandler DGTBC_TUBO.TextBox.Enter, AddressOf CargarCombo_Tub
        AddHandler DGTBC_MUESTRA.TextBox.Enter, AddressOf CargarCombo_Mue
        AddHandler DGTBC_RACK.TextBox.Enter, AddressOf CargarCombo_Rack
        AddHandler DGTBC_EQUIPO.TextBox.KeyDown, AddressOf DetectaTecla
        AddHandler DGTBC_TUBO.TextBox.KeyDown, AddressOf DetectaTecla
        AddHandler DGTBC_MUESTRA.TextBox.KeyDown, AddressOf DetectaTecla
        AddHandler DGTBC_RACK.TextBox.KeyDown, AddressOf DetectaTecla
        Dim i As Short
        'se crea evento width changed para cada uno de los elementos que tienen su ancho = 0
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(4).WidthChanged, AddressOf CambiaTamanoCelda
        For i = 10 To 19
            AddHandler DataGridTableStyle1.GridColumnStyles.Item(i).WidthChanged, AddressOf CambiaTamanoCelda
        Next
        '''
        '''
        Dim opr_eqp As New Cls_equipos()
        ''frm_refer_main_form.escribemsj("CARGANDO EQUIPOS AREAS")
        cmb_area.Items.Add("<Disponibles>")
        opr_user.LeerAreasUsuarioLT(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
        For int_i = 0 To arr_datos.Count - 1
            str_areas = str_areas & arr_datos(int_i) & ","
            cmb_area.Items.Add(arr_nombre(int_i).ToString.PadRight(50) & arr_datos(int_i).ToString.PadRight(10))
        Next
        'cmb_prioridad.SelectedIndex = 0


        opr_trabajo.LlenarListaTrabajo(lst_trabajo, cmb_prioridad.Text, str_areas, "")
        Dim dtc_columna0 As New DataColumn("ped_id", GetType(System.Int32))
        Dim dtc_columna1 As New DataColumn("turno", GetType(System.Int32))
        Dim dtc_columna2 As New DataColumn("paciente", GetType(System.String))
        Dim dtc_columna3 As New DataColumn("tes_nombre", GetType(System.String))
        Dim dtc_columna4 As New DataColumn("tes_id", GetType(System.Int32))
        Dim dtc_columna5 As New DataColumn("equipo", GetType(System.String))
        Dim dtc_columna6 As New DataColumn("muestra", GetType(System.String))
        Dim dtc_columna7 As New DataColumn("tubo", GetType(System.String))
        Dim dtc_columna8 As New DataColumn("rack", GetType(System.String))
        Dim dtc_columna9 As New DataColumn("pos", GetType(System.String))
        Dim dtc_columna10 As New DataColumn("graf_estado", GetType(System.Object))
        Dim dtc_columna11 As New DataColumn("tuboid", GetType(System.String))
        Dim dtc_columna12 As New DataColumn("mdideqp", GetType(System.String))
        Dim dtc_columna13 As New DataColumn("mdidtest", GetType(System.String))
        Dim dtc_columna14 As New DataColumn("per_id", GetType(System.Int32))    'puede ser nulo
        Dim dtc_columna15 As New DataColumn("nuevo", GetType(System.Int32))     'nuevo(1), registrado(0)
        Dim dtc_columna16 As New DataColumn("tipmuestra", GetType(System.String))
        Dim dtc_columna17 As New DataColumn("tipracks", GetType(System.String))
        Dim dtc_columna18 As New DataColumn("equerror", GetType(System.String))
        Dim dtc_columna19 As New DataColumn("areaid", GetType(System.String))
        dtt_trabajo.Columns.Add(dtc_columna0)
        dtt_trabajo.Columns.Add(dtc_columna1)
        dtt_trabajo.Columns.Add(dtc_columna2)
        dtt_trabajo.Columns.Add(dtc_columna3)
        dtt_trabajo.Columns.Add(dtc_columna4)
        dtt_trabajo.Columns.Add(dtc_columna5)
        dtt_trabajo.Columns.Add(dtc_columna6)
        dtt_trabajo.Columns.Add(dtc_columna7)
        dtt_trabajo.Columns.Add(dtc_columna8)
        dtt_trabajo.Columns.Add(dtc_columna9)
        dtt_trabajo.Columns.Add(dtc_columna10)
        dtt_trabajo.Columns.Add(dtc_columna11)
        dtt_trabajo.Columns.Add(dtc_columna12)
        dtt_trabajo.Columns.Add(dtc_columna13)
        dtt_trabajo.Columns.Add(dtc_columna14)
        dtt_trabajo.Columns.Add(dtc_columna15)
        dtt_trabajo.Columns.Add(dtc_columna16)
        dtt_trabajo.Columns.Add(dtc_columna17)
        dtt_trabajo.Columns.Add(dtc_columna18)
        dtt_trabajo.Columns.Add(dtc_columna19)
        dtv_trabajo.AllowNew = False
        dtv_trabajo.AllowDelete = False
        DataGridTableStyle1.PreferredRowHeight = 22
        dgrd_trabajo.DataSource = dtv_trabajo
        dgrd_trabajo.ReadOnly = False
        ''frm_refer_main_form.escribemsj("CARGANDO EQUIPOS TUBOS")
        CargarCombo_Tubo()
        ''frm_refer_main_form.escribemsj("CARGANDO LISTA DE MUESTRAS...")
        CargarCombo_Muestra()
        CargarCombo_Rack()
        Inicia_Arreglo_Muestra()
        ''frm_refer_main_form.escribemsj("CARGANDO LISTA DE TRABAJO DIARIA")

        'lleno combo prioridad con secuencias
        opr_pedido.LlenarComboPrioridad(cmb_prioridad, True, False)



        LLENA_DATOS_LISTA()
        ''frm_refer_main_form.escribemsj("CARGANDO EQUIPOS DISPONIBLES")
        cmb_eqp.Items.Add("<Disponibles>")
        cmb_eqp.Items.Add("<MANUAL>")
        opr_eqp.LlenarCmbEquipos(cmb_eqp)
        cmb_vistas.SelectedIndex = 0
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
        cmb_area.SelectedIndex = 0
        lbl_num.Text = dtv_trabajo.Count
        Me.Cursor = Cursors.Arrow
    End Sub

#End Region

#Region "Combos"

    Private Sub CargarCombo_Tubo()
        cmb_tubo.Items.Clear()
        cmb_tubo.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_tubo.Cursor = System.Windows.Forms.Cursors.Default
        cmb_tubo.Width = DGTBC_TUBO.Width
        cmb_tubo.Text = DGTBC_TUBO.TextBox.Text
        DGTBC_TUBO.TextBox.Controls.Add(cmb_tubo)
        cmb_tubo.BringToFront()
    End Sub

    Private Sub CargarCombo_Muestra()
        cmb_muestra.Items.Clear()
        cmb_muestra.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_muestra.Cursor = System.Windows.Forms.Cursors.Default
        cmb_muestra.Width = DGTBC_MUESTRA.Width
        cmb_muestra.Text = DGTBC_MUESTRA.TextBox.Text
        DGTBC_MUESTRA.TextBox.Controls.Add(cmb_muestra)
        cmb_muestra.BringToFront()
    End Sub

    Private Sub CargarCombo_Rack()
        cmb_rack.Items.Clear()
        cmb_rack.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_rack.Cursor = System.Windows.Forms.Cursors.Default
        cmb_rack.Width = DGTBC_RACK.Width
        cmb_rack.Text = DGTBC_RACK.TextBox.Text
        DGTBC_RACK.TextBox.Controls.Add(cmb_rack)
        cmb_rack.BringToFront()
    End Sub

    Sub Inicia_Arreglo_Muestra()
        Dim dts_trabajo As DataSet
        Dim dtr_fila As DataRow
        Dim int_cont, int_cont2 As Short
        'Test
        int_cont = 0
        ReDim Arr_str_Muestra(int_cont)
        Arr_str_Muestra(int_cont) = ""
        dts_trabajo = opr_parametro.LeerTiposMuestras
        For Each dtr_fila In dts_trabajo.Tables("Registros").Rows
            If IsDBNull(dtr_fila(0)) Then
                Exit For
            Else
                ReDim Preserve Arr_str_Muestra(int_cont)
                Arr_str_Muestra(int_cont) = dtr_fila("TIM_NOMBRE").ToString().PadRight(150).ToLower & dtr_fila("TIM_ID").ToString().PadRight(10)
                int_cont = int_cont + 1
            End If
        Next
    End Sub

    Private Sub CargarCombo_Mue(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        'lee estado para ver si puede o no mostrar y modificar datos
        If NULOS(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 10), 0) = 0 Then
            Dim str_dato As String
            str_dato = dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 6)
            Carga_Muestra()
            cmb_muestra.SelectedIndex = cmb_muestra.FindString(str_dato)
        End If
    End Sub

    Private Sub CargarCombo_Tub(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        'lee estado para ver si puede o no mostrar y modificar datos
        If NULOS(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 10), 0) = 0 Then
            Dim str_dato As String
            str_dato = dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 7)
            Carga_Tubo()
            cmb_tubo.SelectedIndex = cmb_tubo.FindString(str_dato)
        End If
    End Sub

    Private Sub CargarCombo_Rack(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        'lee estado para ver si puede o no mostrar y modificar datos
        If NULOS(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 10), 0) = 0 Then
            Dim str_dato As String
            str_dato = dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 8)
            Cargar_Rack()
            cmb_rack.SelectedIndex = cmb_rack.FindString(str_dato)
        End If
    End Sub

    Private Sub CargarCombo_Eqp(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        'lee estado para ver si puede o no mostrar y modificar datos
        If NULOS(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 10), 0) = 0 Then
            Dim dts_trabajo As DataSet
            Dim dtr_fila As DataRow
            cmb_equipo.Items.Clear()
            cmb_equipo.DropDownStyle = ComboBoxStyle.DropDownList
            cmb_equipo.Cursor = System.Windows.Forms.Cursors.Default
            dts_trabajo = opr_trabajo.LeerEquipoTest(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 4), 0)
            cmb_equipo.Items.Add("<MANUAL>")
            For Each dtr_fila In dts_trabajo.Tables("Registros").Rows
                If IsDBNull(dtr_fila(0)) Then
                    Exit For
                Else
                    If dtr_fila(2) <> 0 Then
                        'segrega a los equipos que se encuentran inactivos
                        cmb_equipo.Items.Add(dtr_fila(0).ToString().PadRight(150) & dtr_fila(1).ToString().PadRight(10))
                    End If
                End If
            Next
            cmb_equipo.Width = DGTBC_EQUIPO.Width
            cmb_equipo.Text = DGTBC_EQUIPO.TextBox.Text
            DGTBC_EQUIPO.TextBox.Controls.Add(cmb_equipo)
            cmb_equipo.BringToFront()
        End If
    End Sub

    Sub Carga_Muestra()
        'On Error Resume Next
        Dim int_cont, int_cont2, int_indice As Short
        Dim arr_tmp(), Arr_str_Muestra_AUX() As String

        cmb_muestra.Items.Clear()
        If dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 5) = "<MANUAL>" Then Exit Sub

        arr_tmp = Split(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 13), ",")
        If UBound(arr_tmp) = 0 Then
            If IsNumeric(Trim(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 13))) Then
                ReDim arr_tmp(1)
                arr_tmp(0) = Trim(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 13))
            Else
                arr_tmp = Split(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 12), ",")
                If UBound(arr_tmp) = 0 Then
                    If IsNumeric(Trim(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 12))) Then
                        ReDim arr_tmp(1)
                        arr_tmp(0) = Trim(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 12))
                    Else
                        MsgBox("Error Cr�tico, los equipos y test no tienen configurado tipos de muestras. Consulte con su proveedor", MsgBoxStyle.Critical, "ANALISYS")
                        Exit Sub
                    End If
                End If
            End If
        End If

        'A�ADE LAS MUESTRAS HABILES PARA LA PRUEBA Y EQUIPO SE�ALADOS
        arr_tmp.Sort(arr_tmp)
        int_indice = 0
        ReDim Arr_str_Muestra_AUX(int_indice)
        Arr_str_Muestra_AUX(int_indice) = ""
        For int_cont = 0 To UBound(arr_tmp)
            For int_cont2 = 0 To UBound(Arr_str_Muestra)
                If arr_tmp(int_cont) = Trim(Mid(Arr_str_Muestra(int_cont2), 151, 10)) Then
                    ReDim Preserve Arr_str_Muestra_AUX(int_indice)
                    Arr_str_Muestra_AUX(int_indice) = Arr_str_Muestra(int_cont2)
                    int_indice = int_indice + 1
                End If
            Next
        Next
        cmb_muestra.Items.AddRange(Arr_str_Muestra_AUX)
    End Sub

    Sub Carga_Tubo()
        cmb_tubo.Items.Clear()
        Select Case dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 11)
            Case 1
                cmb_tubo.Items.Add("Tubo Primario")
            Case 2
                cmb_tubo.Items.Add("Copa")
            Case 3
                cmb_tubo.Items.Add("Tubo Primario")
                cmb_tubo.Items.Add("Copa")
        End Select
    End Sub

    Sub Cargar_Rack()
        'esta funci�n llena el combo de tipos de rack que posee el instrumento y determina que determina el n�mero
        'm�ximo de posiciones que tiene por rack
        cmb_rack.Items.Clear()
        Dim s() As String = Split(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 17), ",")
        If UBound(s) = 0 Then
            Dim aux() As String = Split(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 17), "-")
            If aux.Length = 2 Then cmb_rack.Items.Add(aux(0).PadRight(10) & aux(1).PadRight(3))
        Else
            Dim i As Short
            For i = 0 To UBound(s)
                Dim aux() As String = Split(s(i), "-")
                If aux.Length = 2 Then cmb_rack.Items.Add(aux(0).PadRight(10) & aux(1).PadRight(3))
            Next
        End If
    End Sub

    Sub Cargar_RackDefault()
        'esta funci�n carga el primer rack ingresado por default en la base de datos
        Dim s() As String = Split(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 17), ",")
        If UBound(s) = 0 Then
            Dim aux() As String = Split(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 17), "-")
            If aux.Length = 2 Then dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 8) = aux(0).PadRight(10) & aux(1).PadRight(3)
        Else
            Dim aux() As String = Split(s(0), "-")
            If aux.Length = 2 Then dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 8) = aux(0).PadRight(10) & aux(1).PadRight(3)
        End If
    End Sub

    Sub Cargar_RackDefault(ByRef dtr_fila As DataRow)
        'esta funci�n carga el primer rack ingresado por default en la base de datos
        Dim s() As String = Split(dtr_fila(17), ",")
        If UBound(s) = 0 Then
            Dim aux() As String = Split(dtr_fila(17), "-")
            If aux.Length = 2 Then dtr_fila(8) = aux(0).PadRight(10) & aux(1).PadRight(3)
        Else
            Dim aux() As String = Split(s(0), "-")
            If aux.Length = 2 Then dtr_fila(8) = aux(0).PadRight(10) & aux(1).PadRight(3)
        End If
    End Sub

    Function Cargar_RackDefault(ByVal str_rack As String, ByVal str_rackslis As String) As String
        'esta funci�n retorna toda la referencia a un rack y su n�mero m�ximo de posiciones admitidas
        Dim s() As String = Split(str_rackslis, ",")
        If UBound(s) = 0 Then
            Dim aux() As String = Split(str_rackslis, "-")
            If aux.Length = 2 Then Cargar_RackDefault = aux(0).PadRight(10) & aux(1).PadRight(3)
        Else
            Dim i As Short
            For i = 0 To UBound(s)
                Dim aux() As String = Split(s(i), "-")
                If aux.Length = 2 Then
                    If str_rack = Trim(aux(0)) Then
                        Cargar_RackDefault = aux(0).PadRight(10) & aux(1).PadRight(3)
                        Exit For
                    End If
                End If
            Next
        End If
    End Function

    Function Busca_elemento(ByVal codigo_id As String, ByVal busca_id As String) As Boolean
        'funci�n que busca el elemento dentro de las celdas 9,10,11
        'ej: busca 2 en la cadena "1,2,4,5,6" --> devuelve true por que si encontro el 2
        'on error resume next
        Dim int_cont As Short
        Dim arr_tmp() As String

        Busca_elemento = False
        If Trim(codigo_id) <> "" Then
            arr_tmp = Split(busca_id, ",")
            If UBound(arr_tmp) = 0 Then
                If IsNumeric(busca_id) Then
                    ReDim arr_tmp(1)
                    arr_tmp(0) = busca_id
                Else
                    Exit Function
                End If
            End If

            arr_tmp.Sort(arr_tmp)
            For int_cont = 0 To UBound(arr_tmp)
                If arr_tmp(int_cont) = codigo_id Then
                    Busca_elemento = Not Busca_elemento
                    Exit For
                End If
            Next
        End If
    End Function

    Private Sub cmb_combo_select(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_equipo.SelectedValueChanged
        dgrd_trabajo(dgrd_trabajo.CurrentCell) = cmb_equipo.Text
        If dgrd_trabajo(dgrd_trabajo.CurrentCell) <> "<MANUAL>" And dgrd_trabajo(dgrd_trabajo.CurrentCell) <> "" Then
            Dim arr_str_datos() As String
            opr_trabajo.LeerDatosTest_LIS(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 4), Trim(Mid(dgrd_trabajo(dgrd_trabajo.CurrentCell), 151, 10)), arr_str_datos)
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 11) = arr_str_datos(0)  'Tubos por eqp: 1: tubo con c�digo de barra, 2: copa o tubo sin c�digo de barra, 3: ambos
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 12) = arr_str_datos(1)  'Muestras ID por eqp
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 13) = arr_str_datos(2) 'Muestras ID por test
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 16) = arr_str_datos(3) 'muestras que el equipo recibe
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 8) = ""
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 17) = NULOS(arr_str_datos(6), "")

            'busca si el nuevo equipo cargado tiene el tubo que el anterior tenia (con esto valida la pos), y la muestra
            'muestra predeterminada
            If arr_str_datos(4) <> "" Then
                Dim I As Short
                For I = 0 To UBound(Arr_str_Muestra)
                    If arr_str_datos(4) = Trim(Mid(Arr_str_Muestra(I), 151, 10)) Then
                        dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 6) = Arr_str_Muestra(I)
                        Exit For
                    End If
                Next
            End If

            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 9) = "--"  'pos
            'tubo predeterminado
            Select Case arr_str_datos(5)
                Case "1"
                    dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 7) = "Tubo Primario"
                Case "2"
                    dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 7) = "Copa"
            End Select
            'rack predeterminado
            Cargar_RackDefault()
        Else
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 11) = 0
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 12) = ""
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 13) = ""
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 7) = ""
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 9) = "--"
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 6) = ""
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 8) = ""
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 17) = ""
        End If
    End Sub

    Private Sub cmb_muestra_select(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_muestra.SelectedValueChanged
        dgrd_trabajo(dgrd_trabajo.CurrentCell) = cmb_muestra.Text
    End Sub

    Private Sub cmb_tubo_select(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_tubo.SelectedValueChanged
        dgrd_trabajo(dgrd_trabajo.CurrentCell) = cmb_tubo.Text
        If dgrd_trabajo(dgrd_trabajo.CurrentCell) <> "Copa" Then
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 9) = "--"
        End If
    End Sub

    Private Sub cmb_rack_select(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_rack.SelectedValueChanged
        dgrd_trabajo(dgrd_trabajo.CurrentCell) = cmb_rack.Text
        'si la posicion del tubo es mayor al permitido entonces la pos se hace --
        Try
            If CShort(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 9)) > CShort(Trim(Mid(cmb_rack.Text, 11, 3))) Then
                dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 9) = "--"
            End If
        Catch ex As Exception
            dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 9) = "--"
        End Try
    End Sub

#End Region

#Region "Grid"

    Sub limpia_grid(Optional ByVal int_cambia As Byte = 0)
        Dim int_cont As Short
        For int_cont = dtt_trabajo.Rows.Count - 1 To 0 Step -1
            Select Case int_cambia
                Case 0
                    If dtt_trabajo.Rows(int_cont).Item(15) <> 0 Then    'nuevo
                        dtt_trabajo.Rows(int_cont).Delete()
                    End If
                Case 1  'Aceptar
                    dtt_trabajo.Rows(int_cont).Delete()
            End Select
        Next
    End Sub

    Private Sub dtt_trabajo_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles dtt_trabajo.ColumnChanging
        On Error GoTo msgerr
        If Not boo_cambia Then Exit Sub
        Select Case e.Column.ToString
            Case "pos"
                'la posici�n y el rack se define en el equ_rack, ej: #rack-#maxposiciones, si el equipo: 
                'no tiene rack pero tiene posiciones se usar�: 0-#maxposiciones, 
                'no tiene rack y tampoco posiciones no se usa ning�n identificador
                If dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 7) = "Tubo Primario" OrElse _
                   dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 5) = "<MANUAL>" OrElse _
                   Not IsNumeric(e.ProposedValue) OrElse _
                   Trim(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 7)) = "" Then
                    e.ProposedValue = "--"
                Else
                    If IsNumeric(Mid(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 8), 11, 3)) Then
                        If CShort(e.ProposedValue) > CShort(Trim(Mid(dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 8), 11, 3))) Then
                            e.ProposedValue = "--"
                        End If
                    Else
                        'si el equipo no posee rack, entonces acepta el valor entrante
                        e.ProposedValue = "--"
                    End If
                End If
            Case "tubo", "muestra"
                If dgrd_trabajo(dgrd_trabajo.CurrentCell.RowNumber, 5) = "<MANUAL>" Then
                    e.ProposedValue = ""
                End If
        End Select
        Exit Sub
msgerr: e.ProposedValue = "--"
        Err.Clear()
    End Sub

    Private Sub dtp_fecing_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_fecing.TextChanged
        LLENA_DATOS_LISTA()
        lbl_num.Text = dtv_trabajo.Count
    End Sub

#End Region

#Region "Funcionalidad formulario"

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_Trabajo_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MsgBox("Desea cerrar la lista de trabajo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar el formulario") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Function Guarda_lista(Optional ByVal opc As Short = 0) As Boolean
        Me.Cursor = Cursors.WaitCursor
        Dim boo_err As Boolean = False
        Dim str_tipo As String = "NORMAL"

        'opc para los efectos de los botones 
        '0--> guardar, 1--> enviar, 2--> imprimir
        'SE COMPRUEBA QUE LOS DATOS DE POSICIONES, TUBOS Y RACK SEAN CONGRUENTES, Y SE VA DEPURANDO
        'If Not CompruebaDatosGrid() Then
        '    ''frm_refer_main_form.escribemsj("EXISTEN ELEMENTOS DE LA LISTA DE TRABAJO, QUE PUEDEN NO ESTAR BIEN INGRESADOS SUS DATOS")
        '    boo_err = True
        'End If
        If cmb_prioridad.Text = "URGENCIA" Then
            str_tipo = "URGENCIA"
        End If
        'SE COMPRUEBA QUE LOS DATOS DE POSICIONES, TUBOS Y RACK NO SEAN REPETIDOS
        'If Not CompruebaDatosGridPos() Then Return False
        'If boo_err Then
        '    If MsgBox("Algunos datos de la lista de trabajo no poseen tubo, posici�n o muestra." & Chr(13) & "Pueden existir problemas al transmitir estos datos a los equipos." & Chr(13) & "Desea Continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
        '        Return False
        '    End If
        'End If
        ''frm_refer_main_form.escribemsj("GUARDANDO LISTA DE TRABAJO ...")
        If opr_trabajo.GuardarTrabajo(dtt_trabajo, Trim(dtp_fecing.Value), str_tipo) Then
            'presenta el mensaje de guardado si se cumplen las condiciones de los parametros
            If opc = 0 Then MsgBox("La orden de trabajo fue almacenada correctamente", MsgBoxStyle.Information, "ANALISYS")
            ''frm_refer_main_form.escribemsj("LISTA GUARDADA")
        End If
        ''frm_refer_main_form.escribemsj("CONSULTANDO PEDIDOS NUEVOS")
        opr_trabajo.LlenarListaTrabajo(lst_trabajo, PRIORIDAD, str_areas, "")
        ''frm_refer_main_form.escribemsj("CARGANDO LISTA DE TRABAJO DIARIA")
        If opc <> 1 Then LLENA_DATOS_LISTA(1)
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
        Me.Cursor = Cursors.Default
        Return True
    End Function

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        If dtv_trabajo.Count = 0 Then
            MsgBox("Debe seleccionar por lo menos un pedido", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If MsgBox("Desea guardar la lista de trabajo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.Yes Then
                ''frm_refer_main_form.escribemsj("GUARDANDO LISTA DE TRABAJO ...")
                Guarda_lista()
            End If
        End If
    End Sub


    Public Sub ActualizaEstado()
        LLENA_DATOS_LISTA(1)
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Dim titulo As String = "LISTA DE TRABAJO"
        If dtt_trabajo.Rows.Count > 0 Then
            'If MsgBox("Para imprimir, debe guardar la lista de trabajo. 󿿿Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.Yes Then
            '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'Guarda_lista(2)
            Try
                m_cls_dgimpresion = New cls_dgimpresion(dgrd_trabajo, PrintDocument1, dtv_trabajo, dtp_fecing.Text, cmb_eqp.Text, cmb_area.Text, cmb_vistas.Text, Me.Tag, titulo)
                PrintPreviewDialog1.ShowDialog()
                Me.Refresh()
            Catch iex As System.Drawing.Printing.InvalidPrinterException
                MsgBox("Error En la Impresora", MsgBoxStyle.Exclamation, "ANALISYS")
            End Try
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'End If
        End If
        g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIMIR LISTA TRABAJO", "", g_sng_user, "", "", "")
    End Sub

#End Region

#Region "Datos Lista por da"

    Sub LLENA_DATOS_LISTA(Optional ByVal int_cambia As Byte = 0)
        Dim int_pedant As Short = 0
        On Error GoTo msgErr

        boo_cambia = False
        limpia_grid(int_cambia)
        Dim arr_datos As New ArrayList()
        '''frm_refer_main_form.escribemsj("LEYENDO PEDIDOS DIARIOS, ESPERE ...")
        opr_trabajo.LeerDetallePedido_dia(dtp_fecing.Value, cmb_prioridad.Text, str_areas, arr_datos)
        Dim int_cont As Integer
        Dim arr_tmp() As String

        For int_cont = 0 To arr_datos.Count - 1
            ''frm_refer_main_form.escribemsj("Cargando: " & int_cont)
            arr_tmp = Split(arr_datos(int_cont), "�")
            If arr_tmp(0) <> "" Then

                Dim dtr_fila As DataRow
                dtr_fila = dtt_trabajo.NewRow

                dtr_fila(0) = Trim(arr_tmp(0))
                dtr_fila(1) = Trim(arr_tmp(19))   'turno
                'dtr_fila(2) = Trim(arr_tmp(2)) & " " & Trim(arr_tmp(3))
                dtr_fila(2) = Trim(arr_tmp(3)) & " " & Trim(arr_tmp(2))
                dtr_fila(3) = arr_tmp(11)
                dtr_fila(4) = arr_tmp(10)
                dtr_fila(7) = ""
                'NO PRESENTO EL TIPO DE TUBO
                'If Not IsDBNull(arr_tmp(6)) Then    'tubo
                '    Select Case arr_tmp(6)
                '        Case "1"
                '            dtr_fila(7) = "Tubo Primario"
                '        Case "2"
                '            dtr_fila(7) = "Copa"
                '    End Select
                'End If
                dtr_fila(7) = "Tubo Primario"
                'dtr_fila(6) = arr_tmp(8).ToString().PadRight(150).ToLower & arr_tmp(4).ToString().PadRight(10)


                If Not IsDBNull(arr_tmp(4)) Then    'muestra
                    If arr_tmp(4) <> "0" And Trim(arr_tmp(4)) <> "" Then
                        dtr_fila(6) = arr_tmp(8).ToString().PadRight(150).ToLower & arr_tmp(4).ToString().PadRight(10)
                    End If
                End If

                dtr_fila(5) = "<MANUAL>"
                If Not IsDBNull(arr_tmp(7)) Then    'equipo     'And Not IsDBNull(dtr_filapedidos(14))
                    If arr_tmp(7) <> "0" And Trim(arr_tmp(7)) <> "" And arr_tmp(14) <> "0" Then
                        'segregamos a los equipos inactivos (14)
                        'si es el estado del registro de la lista (15) es 0 --> se segrega a los equipos
                        dtr_fila(5) = arr_tmp(9).ToString().PadRight(150) & arr_tmp(7).ToString().PadRight(10)
                    End If
                End If
                dtr_fila(8) = ""
                dtr_fila(17) = ""
                'carga la referencia si alg�n dato tiene error al enviar al equipo
                dtr_fila(18) = NULOS(arr_tmp(18), "")
                'If dtr_fila(5) <> "<MANUAL>" And dtr_fila(5) <> "" Then
                'Dim arr_str_datos() As String
                'opr_trabajo.LeerDatosTest_LIS(dtr_fila(4), Trim(Mid(dtr_fila(5), 151, 10)), arr_str_datos)
                'dtr_fila(11) = arr_str_datos(0) 'Tubos por eqp: 1: tubo con c�digo de barra, 2: copa o tubo sin c�digo de barra, 3: ambos
                'dtr_fila(12) = arr_str_datos(1) 'Muestras ID por eqp
                'dtr_fila(13) = arr_str_datos(2) 'Muestras ID por test
                'dtr_fila(16) = arr_str_datos(3) 'muestras que acepta el equipo
                'dtr_fila(17) = NULOS(arr_str_datos(6), "")
                'dtr_fila(8) = Cargar_RackDefault(Trim(arr_tmp(17)), dtr_fila(17))  'rack guardado en la lista de trabajo
                'Else
                dtr_fila(11) = 0
                dtr_fila(12) = ""
                dtr_fila(13) = ""
                dtr_fila(16) = ""
                'End If

                dtr_fila(9) = "--"
                If Not IsDBNull(arr_tmp(5)) Then    'pos
                    If arr_tmp(5) <> "0" And Trim(arr_tmp(5)) <> "" Then
                        dtr_fila(9) = CShort(arr_tmp(5))
                    End If
                End If

                dtr_fila(14) = NULOS(arr_tmp(13).ToString, 0)  'perfil id
                dtr_fila(15) = arr_tmp(12).ToString '<>0 indica que el registro ya existe en la lista de trabajo
                dtr_fila(19) = Trim(arr_tmp(20))   'areid
                'inserta gr�fico de estado
                dtr_fila(10) = arr_tmp(16).ToString
                dtt_trabajo.Rows.Add(dtr_fila)
            End If
        Next
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
        boo_cambia = True
        Exit Sub
msgErr:
        g_opr_usuario.MensajeBoxError("No se puede cargar los datos solicitados. Consultar con soporte tecnico")
        Err.Clear()
        boo_cambia = True
    End Sub

#End Region

#Region "Datos Lista de pendientes"

    Private Sub lista_trabajo_Seleciona(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_trabajo.SelectedIndexChanged
        'Dim int_i, int_cont, int_id As Short
        'Dim boo_existe As Boolean

        'boo_cambia = False
        'On Error GoTo msgerr

        'For int_i = 0 To lst_trabajo.Items.Count - 1

        '    If lst_trabajo.GetSelected(int_i) = True Then
        '        Dim dts_trabajo2 As DataSet
        '        Dim dtr_fila3 As DataRow
        '        Dim arr_tmp() As String
        '        Dim arr_datos As New ArrayList()
        '        opr_trabajo.LeerDetallePedidoArea(Val(lst_trabajo.Items.Item(int_i).substring(0, 7)), str_areas, arr_datos)

        '        For int_id = 0 To arr_datos.Count - 1
        '            arr_tmp = Split(arr_datos(int_id), "�")
        '            boo_existe = False

        '            For int_cont = 0 To dtt_trabajo.Rows.Count - 1
        '                If Trim(lst_trabajo.Items.Item(int_i).substring(0, 7)) = Trim(dtt_trabajo.Rows(int_cont).Item(0)) _
        '                And dtt_trabajo.Rows(int_cont).Item(4) = CInt(arr_tmp(1)) And dtt_trabajo.Rows(int_cont).Item(14) = CInt(arr_tmp(5)) Then
        '                    boo_existe = True
        '                    Exit For
        '                End If
        '            Next

        '            If Not boo_existe Then
        '                Dim dtr_fila2 As DataRow = dtt_trabajo.NewRow
        '                'JVA 13-ene-04 CAMBIO EN LST. PARA VER EL TURNO.
        '                dtr_fila2(0) = Trim(lst_trabajo.Items.Item(int_i).substring(0, 7))  'pedido id
        '                dtr_fila2(1) = Trim(lst_trabajo.Items.Item(int_i).substring(7, 5)) 'turno
        '                dtr_fila2(2) = Trim(lst_trabajo.Items.Item(int_i).substring(12, 25))
        '                dtr_fila2(3) = arr_tmp(0)  'tes_nombre
        '                dtr_fila2(4) = CInt(arr_tmp(1))  'tes_id
        '                dtr_fila2(14) = CInt(arr_tmp(5)) 'perfil (Nulo o 0, indica que no tiene perfil)
        '                dtr_fila2(15) = 0           'nuevo
        '                dtr_fila2(19) = arr_tmp(6)  'area

        '                dts_trabajo2 = opr_trabajo.LeerEquipoTest(CInt(arr_tmp(1)), 1)
        '                If dts_trabajo2.Tables("Registros").Rows.Count > 0 Then
        '                    For Each dtr_fila3 In dts_trabajo2.Tables("Registros").Rows
        '                        If IsDBNull(dtr_fila3(0)) Then
        '                            dtr_fila2(5) = "<MANUAL>"
        '                        Else
        '                            If dtr_fila3(2) <> 0 Then
        '                                dtr_fila2(5) = dtr_fila3(0).ToString().PadRight(150) & dtr_fila3(1).ToString().PadRight(10)
        '                            Else
        '                                dtr_fila2(5) = "<MANUAL>"
        '                            End If
        '                        End If
        '                    Next
        '                Else
        '                    dtr_fila2(5) = "<MANUAL>"
        '                End If

        '                dtr_fila2(6) = ""
        '                dtr_fila2(7) = ""
        '                dtr_fila2(8) = ""
        '                dtr_fila2(9) = "--"
        '                dtr_fila2(10) = 0        'inserta gr�fico de estado
        '                dtr_fila2(17) = ""

        '                If dtr_fila2(5) <> "<MANUAL>" And dtr_fila2(5) <> "" Then
        '                    Dim arr_str_datos() As String
        '                    opr_trabajo.LeerDatosTest_LIS(dtr_fila2(4), Trim(Mid(dtr_fila2(5), 151, 10)), arr_str_datos)
        '                    dtr_fila2(11) = arr_str_datos(0)  'Tubos por eqp: 1: tubo con c�digo de barra, 2: copa o tubo sin c�digo de barra, 3: ambos
        '                    dtr_fila2(12) = arr_str_datos(1)  'Muestras ID por eqp
        '                    dtr_fila2(13) = arr_str_datos(2) 'Muestras ID por test
        '                    dtr_fila2(16) = arr_str_datos(3) 'muestras que acepta el equipo
        '                    dtr_fila2(17) = NULOS(arr_str_datos(6), "")
        '                    'tubo predeterminado
        '                    Select Case arr_str_datos(5)
        '                        Case "1"
        '                            dtr_fila2(7) = "Tubo Primario"
        '                        Case "2"
        '                            dtr_fila2(7) = "Copa"
        '                    End Select
        '                    'muestra predeterminada
        '                    If arr_str_datos(4) <> "" Then
        '                        Dim I As Short
        '                        For I = 0 To UBound(Arr_str_Muestra)
        '                            If arr_str_datos(4) = Trim(Mid(Arr_str_Muestra(I), 151, 10)) Then
        '                                dtr_fila2(6) = Arr_str_Muestra(I)
        '                                Exit For
        '                            End If
        '                        Next
        '                    End If
        '                    'rack predeterminado
        '                    Cargar_RackDefault(dtr_fila2)
        '                Else
        '                    dtr_fila2(11) = 0
        '                    dtr_fila2(12) = ""
        '                    dtr_fila2(13) = ""
        '                    dtr_fila2(16) = ""
        '                End If
        '                dtt_trabajo.Rows.Add(dtr_fila2)
        '            End If
        '        Next
        '    Else
        '        If Not lst_trabajo.GetSelected(int_i) Then
        '            For int_cont = dtt_trabajo.Rows.Count - 1 To 0 Step -1
        '                If Trim(lst_trabajo.Items.Item(int_i).substring(0, 7)) = Trim(dtt_trabajo.Rows(int_cont).Item(0)) Then
        '                    If dtt_trabajo.Rows(int_cont).Item(15) = 0 Then
        '                        dtt_trabajo.Rows(int_cont).Delete()
        '                    End If
        '                End If
        '            Next
        '        End If
        '    End If
        'Next
        '        boo_cambia = True
        '        Exit Sub
        'msgerr:
        '        g_opr_usuario.MensajeBoxError("No se puede cargar los datos solicitados. Consultar con soporte t�cnico")
        '        Err.Clear()
        '        boo_cambia = True
    End Sub

#End Region

#Region "Manejo Grid Trabajo"

    Function NULOS(ByVal campoin, ByVal campoout) As Object
        If IsDBNull(campoin) OrElse Len(campoin) = 0 Then
            NULOS = campoout
        Else
            NULOS = campoin
        End If
    End Function

    Function CompruebaDatosGridPos() As Boolean
        'SE COMPRUEBA QUE LOS DATOS DE POSICIONES, TUBOS Y RACK NO SEAN REPETIDOS
        Dim i, j As Short
        ''frm_refer_main_form.escribemsj("COMPROBANDO VALIDEZ DE LOS DATOS")
        For i = 0 To dtt_trabajo.Rows.Count - 1
            'se valida el estado este en 0 (guardado o nuevo)
            If NULOS(dtt_trabajo.Rows(i).Item(10), 0) = 0 OrElse NULOS(dtt_trabajo.Rows(i).Item(10), 0) = 3 Then
                'valida que la prueba a realizarce no sea MANUAL
                If NULOS(dtt_trabajo.Rows(i).Item(5), "") <> "<MANUAL>" Then
                    'se valida que el tipo de tubo es copa (para que ingrese posici�n)
                    If NULOS(dtt_trabajo.Rows(i).Item(7), "") = "Copa" Then
                        'SEGUNDO FOR DE RECORRIDO
                        For j = 0 To dtt_trabajo.Rows.Count - 1
                            'se valida el estado este en 0 (guardado o nuevo)
                            If NULOS(dtt_trabajo.Rows(j).Item(10), 0) = 0 OrElse NULOS(dtt_trabajo.Rows(j).Item(10), 0) = 3 Then
                                'se valida que no sea el mismo registro
                                If dtt_trabajo.Rows(i).Item(0) <> dtt_trabajo.Rows(j).Item(0) Then
                                    If NULOS(dtt_trabajo.Rows(i).Item(5), "") <> "<MANUAL>" Then
                                        If NULOS(dtt_trabajo.Rows(j).Item(7), "") = "Copa" Then
                                            'se valida si son iguales los equipos evaluados
                                            If NULOS(dtt_trabajo.Rows(i).Item(5), "") = NULOS(dtt_trabajo.Rows(j).Item(5), "") Then
                                                'se valida que si usan el mismo rack
                                                If NULOS(dtt_trabajo.Rows(i).Item(8), "") = NULOS(dtt_trabajo.Rows(j).Item(8), "") Then
                                                    If NULOS(dtt_trabajo.Rows(j).Item(9), "") <> "--" Then
                                                        'se valida si tienen la misma posici�n
                                                        If NULOS(dtt_trabajo.Rows(i).Item(9), "") = NULOS(dtt_trabajo.Rows(j).Item(9), "") Then
                                                            MsgBox("La posici�n " & dtt_trabajo.Rows(j).Item(9) & ", del pedido " & dtt_trabajo.Rows(j).Item(0) & ", ya existe. No se puede ingresar posiciones repetidas, " & Chr(13) & "cuando el test aun no ha sido procesado. operacion Interrumpida", MsgBoxStyle.Critical, "ANALISYS")
                                                            ''frm_refer_main_form.escribemsj("LISTA DE TRABAJO CON POSICIONES REPETIDAS")
                                                            Return False
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Function CompruebaDatosGrid() As Boolean
        'SE COMPRUEBA QUE LOS DATOS DE POSICIONES, TUBOS Y RACK SEAN CONGRUENTES, Y SE VA DEPURANDO
        Dim i As Short = 0
        CompruebaDatosGrid = True
        ''frm_refer_main_form.escribemsj("DEPURANDO LISTA DE TRABAJO")
        For i = 0 To dtt_trabajo.Rows.Count - 1
            'MANEJO DE LOS ITEMS QUE AUN NO HAN SIDO PROCESADOS O ENVIADOS A LOS EQUIPOS
            If dtt_trabajo.Rows(i).Item(10) = 0 Then
                If dtt_trabajo.Rows(i).Item(5) <> "<MANUAL>" Then
                    'tipo tubo
                    If dtt_trabajo.Rows(i).Item(7) = "Copa" Then
                        If dtt_trabajo.Rows(i).Item(9) = "--" Then CompruebaDatosGrid = False
                    Else
                        'Tubo Primario
                        dtt_trabajo.Rows(i).Item(9) = ""
                    End If
                    'muestra
                    If dtt_trabajo.Rows(i).Item(6) = "" Then CompruebaDatosGrid = False
                Else
                    dtt_trabajo.Rows(i).Item(6) = ""
                    dtt_trabajo.Rows(i).Item(7) = ""
                    dtt_trabajo.Rows(i).Item(9) = ""
                End If
            End If
        Next
    End Function

    Private Sub DetectaTecla(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim d As String
        d = dgrd_trabajo.Item(dgrd_trabajo.CurrentCell).ToString()
        If e.KeyCode = Keys.Delete Then
            Eliminar_Fila()
        End If
    End Sub

    Private Sub Grid_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_trabajo.KeyUp
        'Operaciones al precionar CURSOR DE ARRIBA O ABAJO, sobre el grid y controla que siempre exista una celda seleccionada
        Grid_Seleccionar_Celda()
    End Sub

    Sub Eliminar_Fila()
        On Error Resume Next
        If dtt_trabajo.Rows.Count <= 0 Then Exit Sub
        dgrd_trabajo.Select(dgrd_trabajo.CurrentCell.RowNumber)
        If dtt_trabajo.Rows(dgrd_trabajo.CurrentCell.RowNumber).Item(15) <> 0 Then   'no es nuevo
            MsgBox("No se puede excluir elementos ya ingresados", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If MsgBox("Desea excluir el test seleccionado de la lista de trabajo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "ANALISYS") = MsgBoxResult.Yes Then
                dtt_trabajo.Rows(dgrd_trabajo.CurrentCell.RowNumber).Delete()
            End If
        End If
    End Sub

    Private Sub Grid_CellChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_trabajo.CurrentCellChanged
        'lee estado para ver si puede o no mostrar y modificar datos (1 procesado, 2 validado, 3 enviado)
        If NULOS(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 10), 0) <> 0 Then
            Dim celda As DataGridCell
            celda.RowNumber = dgrd_trabajo.CurrentRowIndex
            celda.ColumnNumber = 0
            dgrd_trabajo.CurrentCell = celda
        End If
    End Sub

    Private Sub Grid_dblclick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_trabajo.DoubleClick
        'para habilitar los test que tuvieron errores al momento de enviar sus datos a los equipos
        'cambia de estado 4 a estado 0
        If dtt_trabajo.Rows.Count > 0 Then
            If dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 10) = 4 Then
                If MsgBox("Descripci�n del error: " & NULOS(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 18), "Desconocido") & Chr(13) & "Desea habilitar el test seleccionado para su envio nuevamente al analizador?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                    opr_trabajo.CambioEstadoItemLista(dgrd_trabajo.Item(dgrd_trabajo.CurrentRowIndex, 15), 0)
                    'REM
                    LLENA_DATOS_LISTA(1)
                End If
            End If
        End If
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_trabajo.KeyDown
        Grid_Seleccionar_Celda()
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            'Operaciones al precionar DELETE sobre el grid
            If e.KeyData.ToString = "Delete" Then
                Eliminar_Fila()
            End If
        End If
    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_trabajo.Click
        'Operaciones al precionar CLICK sobre el grid
        Grid_Seleccionar_Celda()
    End Sub

    Sub CambiaTamanoCelda(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.GetType.Name = "Cls_Celda_Grafica" Then
            sender.Width = 16
        Else
            sender.Width = 50
        End If
    End Sub

    Private Sub Columna_width(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGTBC_EQUIPO.WidthChanged, DGTBC_TUBO.WidthChanged, DGTBC_MUESTRA.WidthChanged, DGTBC_RACK.WidthChanged, DGTBC_POS.WidthChanged
        DGTBC_EQUIPO.Width = 81     'eqp
        DGTBC_TUBO.Width = 75       'tubo
        DGTBC_MUESTRA.Width = 65    'mues
        DGTBC_RACK.Width = 38       'rack
        DGTBC_POS.Width = 28        'pos
    End Sub

    Private celdaanterior As Short

    Private Sub Grid_Seleccionar_Celda()
        On Error Resume Next
        'funci�n que no permite que exista selecci�n multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        dgrd_trabajo.UnSelect(celdaanterior)
        dgrd_trabajo.Select(dgrd_trabajo.CurrentCell.RowNumber)
        celdaanterior = dgrd_trabajo.CurrentCell.RowNumber
    End Sub

#End Region

#Region "Manejo Vistas"

    Private Sub cmb_vistas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_vistas.SelectedIndexChanged
        Cambio_vistas()

    End Sub

    Private Sub cmb_eqp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_eqp.SelectedIndexChanged
        Cambio_vistas()

    End Sub

    Private Sub cmb_area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_area.SelectedIndexChanged
        Cambio_vistas()

    End Sub

    Sub Cambio_vistas()
        Dim str_vista, str_eqp, str_area, str_and As String
        Select Case cmb_vistas.Text
            Case "Pendientes"
                str_vista = "graf_estado=0 "
            Case "Procesados"
                str_vista = "graf_estado=1 "
            Case "Validados"
                str_vista = "graf_estado=2 "
            Case "Enviados"
                str_vista = "graf_estado=3 "
            Case "Rechazados"
                str_vista = "graf_estado=4 "
            Case "en MIS"
                str_vista = "graf_estado=6 "
            Case "error MIS"
                str_vista = "graf_estado=8 "
            Case "Remitidos"
                str_vista = "graf_estado=9 "
            Case Else
                str_vista = ""
        End Select
        str_and = ""
        Select Case cmb_eqp.Text
            Case "<Disponibles>"
                str_eqp = ""
            Case Else
                If str_vista <> "" Then str_and = " and "
                str_eqp = str_and & " equipo='" & Mid(cmb_eqp.Text, 1, 50).PadRight(50) & "".PadRight(100) & Mid(cmb_eqp.Text, 51, 5).PadRight(10) & "' "
        End Select
        str_and = ""
        Select Case Trim(Mid(cmb_area.Text, 1, 50))
            Case "<Disponibles>"
                str_area = ""
            Case Else
                If str_vista <> "" Or str_eqp <> "" Then str_and = " and "
                str_area = str_and & " areaid='" & Trim(Mid(cmb_area.Text, 51, 5)) & "'"
        End Select
        dtv_trabajo.RowFilter = str_vista & str_eqp & str_area
        dtv_trabajo.RowStateFilter = DataViewRowState.CurrentRows
        lbl_num.Text = dtv_trabajo.Count
    End Sub

#End Region

#Region "Expande Lista pendientes"

    Private Sub ExpandeList(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_exp.Click
        If lst_trabajo.Height = 72 Then
            lst_trabajo.Height = 296
            sender.tag = "con"
        Else
            lst_trabajo.Height = 72
            sender.tag = "exp"
        End If
        ExpandeImgEnfoque(sender, e)
    End Sub

    Private Sub ExpandeImgEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_exp.MouseEnter
        'cuando el mouse se mueve por encima del picture expandir
        If sender.tag = "exp" Then
            If m_HtImages.ContainsKey("img_exp") Then
                imageToDraw = CType(m_HtImages("img_exp"), System.Drawing.Image)
            Else
                Try
                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Expand_h.jpg")
                    m_HtImages.Add("img_exp", imageToDraw)
                Catch
                    Return
                End Try
            End If
        Else
            If m_HtImages.ContainsKey("img_con") Then
                imageToDraw = CType(m_HtImages("img_con"), System.Drawing.Image)
            Else
                Try
                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Collapse_h.jpg")
                    m_HtImages.Add("img_con", imageToDraw)
                Catch
                    Return
                End Try
            End If
        End If
        sender.Image = imageToDraw
    End Sub

    Private Sub ExpandeImgSinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_exp.MouseLeave
        'cuando el mouse se mueve por encima del picture expandir
        If sender.tag = "exp" Then
            If m_HtImages.ContainsKey("img_exph") Then
                imageToDraw = CType(m_HtImages("img_exph"), System.Drawing.Image)
            Else
                Try
                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Expand.jpg")
                    m_HtImages.Add("img_exph", imageToDraw)
                Catch
                    Return
                End Try
            End If
        Else
            If m_HtImages.ContainsKey("img_conh") Then
                imageToDraw = CType(m_HtImages("img_conh"), System.Drawing.Image)
            Else
                Try
                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\Collapse.jpg")
                    m_HtImages.Add("img_conh", imageToDraw)
                Catch
                    Return
                End Try
            End If
        End If
        sender.Image = imageToDraw
    End Sub

#End Region

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Control de paginas. en el caso que exista mas de una hoja
        e.HasMorePages = m_cls_dgimpresion.DrawDataGrid(e.Graphics)
        If e.HasMorePages Then
            m_cls_dgimpresion.PageNumber += 1
        Else
            m_cls_dgimpresion.PageNumber = 1
            m_cls_dgimpresion.RowCount = 0
        End If
    End Sub

    Private Sub btn_lista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lista.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_desde_hasta As String
        ' Dim frm_MDIChild As New frm_TrabajoFiltro()
        Dim str_sql As String
        Dim aux As String = Nothing

        '<Todos>
        '--0 sin pocesar pendiente
        '--2 anulado 
        '--3 validado
        '--4 impreso

        Select Case Trim(cmb_vistas.Text)

            Case "Pendientes"
                aux = " pedido.ped_estado = 0 and lista_trabajo = 2 "

            Case "Validados"
                aux = " pedido.ped_estado = 3 "

            Case "Impresos"
                aux = " pedido.ped_estado = 4 "

            Case "<Todos>"
                aux = " pedido.ped_estado <> 2 "
        End Select


        ' ''If Me.cmb_area.Text = "<Disponibles>" Then
        ' ''    'TODOS LOS REGISTROS
        ' ''    str_sql = "SELECT '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as FECHA, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_FECING, (PAC_APELLIDO+ ' '+ PAC_NOMBRE) AS PACIENTE, PAC_DOC, PAC_FONO, " & _
        ' ''        "(cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int))  AS EDAD, " & _
        ' ''        "tpa_desc, LISTA_TRABAJO.tes_id, 'TODAS' as area FROM PEDIDO, LISTA_TRABAJO, PACIENTE, TEST, TEST_PARAMETRO, AREA " & _
        ' ''        "WHERE LISTA_TRABAJO.LIS_FECING between '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 23:59:59' and PEDIDO.PED_PROF <> 1 AND " & _
        ' ''        "TEST.ARE_ID = AREA.ARE_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND PEDIDO.PAC_ID = PACIENTE.PAC_ID AND " & _
        ' ''        "LISTA_TRABAJO.TES_ID = TEST.TES_ID And TEST.TES_ID = TEST_PARAMETRO.TES_ID And TEST_PARAMETRO.tpa_orden = 0 and LISTA_TRABAJO.TES_ID = TEST_PARAMETRO.TES_ID;"
        ' ''Else
        ' ''    'POR UN AREA ESPECIFICA 
        ' ''    str_sql = "SELECT '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as FECHA, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_FECING, (PAC_APELLIDO+ ' '+ PAC_NOMBRE) AS PACIENTE, PAC_DOC, PAC_FONO, " & _
        ' ''        "(cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int))  AS EDAD, " & _
        ' ''        "tpa_desc, LISTA_TRABAJO.tes_id, ARE_NOMBRE AS AREA FROM PEDIDO, LISTA_TRABAJO, PACIENTE, TEST, TEST_PARAMETRO, AREA " & _
        ' ''        "WHERE LISTA_TRABAJO.LIS_FECING between '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 23:59:59' and PEDIDO.PED_PROF <> 1 AND " & _
        ' ''        "TEST.ARE_ID = AREA.ARE_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and PEDIDO.PAC_ID = PACIENTE.PAC_ID AND " & _
        ' ''        "LISTA_TRABAJO.TES_ID = TEST.TES_ID And TEST.TES_ID = TEST_PARAMETRO.TES_ID And LISTA_TRABAJO.TES_ID = TEST_PARAMETRO.TES_ID and AREA.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & ";"
        ' ''End If
        If str_desde_hasta = "" Then
            If Me.cmb_area.Text = "<Disponibles>" Then
                str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, " & _
               "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
               "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, (cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int)) as edad, PED_NUMAUX " & _
               "from paciente, pedido, medico, laboratorio, pedido_detalle, perfil " & _
               "where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and  laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id " & _
               "UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba, " & _
               "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
               "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
               "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, (cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int)) as edad, PED_NUMAUX " & _
               "from paciente, pedido, medico, laboratorio, pedido_detalle, test WHERE pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"
            Else
                str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, " & _
              "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
              "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_NUMAUX " & _
              "from paciente, pedido, medico, laboratorio, pedido_detalle, perfil " & _
              "where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and  laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id " & _
              "UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba, " & _
              "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
              "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
              "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_NUMAUX " & _
              "from paciente, pedido, medico, laboratorio, pedido_detalle, test, area WHERE pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and AREA.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & " and area.are_id = test.are_id and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"
            End If
        Else
            Dim sec_desdeHasta As String()
            sec_desdeHasta = Split(str_desde_hasta, "/")
            If Me.cmb_area.Text = "<Disponibles>" Then

                str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, " & _
                "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_NUMAUX " & _
                "from paciente, pedido, medico, laboratorio, pedido_detalle, perfil where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and pedido.ped_turno between " & sec_desdeHasta(0) & " and " & sec_desdeHasta(1) & " and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id " & _
                "UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba, " & _
                "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_NUMAUX " & _
                "from paciente, pedido, medico, laboratorio, pedido_detalle, test, area where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and AREA.are_id = '" & Trim(Mid(cmb_area.Text, 50, 10)) & "' and test.ARE_ID = area.ARE_ID and pedido.ped_turno between " & sec_desdeHasta(0) & " and " & sec_desdeHasta(1) & " And AREA.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & " and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"
            Else
                str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, " & _
                "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_NUMAUX " & _
                "from paciente, pedido, medico, laboratorio, pedido_detalle, perfil where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and pedido.ped_turno between " & sec_desdeHasta(0) & " and " & sec_desdeHasta(1) & " and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id " & _
                "UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pedido.ped_obs as pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba, " & _
                "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_NUMAUX " & _
                "from paciente, pedido, medico, laboratorio, pedido_detalle, test where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and pedido.ped_turno between " & sec_desdeHasta(0) & " and " & sec_desdeHasta(1) & " And AREA.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & " and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"
            End If
        End If
        '''Dim obj_reporte As New rpt_contraorden()
        Dim obj_reporte As New rpt_ContraOrden2()
        Dim frm_MDIChild2 As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
        frm_MDIChild2.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild2.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild2.Text = "Reporte Contraorden"
        frm_refer_main_form.Crea_formulario(frm_MDIChild2)


        '' '' ''On Error GoTo msgerror
        '' '' ''Me.Cursor = Cursors.WaitCursor
        '' '' ''opr_trabajo.LlenarListaTrabajo(lst_trabajo, Trim(Mid(cmb_prioridad.Text, 1, 50)), str_areas, str_desde_hasta)
        '' '' ''LLENA_DATOS_LISTA()
        '' '' ''lbl_num.Text = dtv_trabajo.Count
        '' '' ''Me.Cursor = Cursors.Arrow
        Exit Sub
msgerror:
        Me.Cursor = Cursors.Arrow
        MsgBox("Se han producido errores en la carga Informacion, cierre esta ventana e intentelo nuevamente.", MsgBoxStyle.Information, "ANALISYS")
        Err.Clear()
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIMIR HOJA TRABAJO POR SECUENCIA", "", g_sng_user, "", "", "")

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

        '' '' '' ''REPORTE SOBRE EL NUMERO DE PRUEBAS QUE SE REALIZARON EN UN PERIODO DE TIEMPO   
        ' '' '' ''If Me.cmb_area.Text = "<Disponibles>" Then
        ' '' '' ''    MsgBox("Reporte de Hoja de Trabajo no disponible cuando no se ha especificado una �rea en paticular.", MsgBoxStyle.Information, "ANALISYS")
        ' '' '' ''Else

        ' '' '' ''    Dim str_sql As String
        ' '' '' ''    If Trim(Mid(cmb_area.Text, 1, 49)) = "MICROBIOLOG�A" Then
        ' '' '' ''        Dim obj_reporte As New rpt_hoja_trabajo_micro()
        ' '' '' ''        str_sql = "select ped_turno, (pac_apellido+ ' '+ pac_nombre) as paciente, tpa_desc, are_nombre, '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as fecha, tes_ordenimp, tpa_orden  " & _
        ' '' '' ''            "from lista_trabajo as lt, pedido as p, paciente as pac, test_parametro as tp, test as t, area as a " & _
        ' '' '' ''            "where lt.ped_id = p.ped_id And p.pac_id = pac.pac_id And lt.tes_id = tp.tes_id " & _
        ' '' '' ''            "and lt.tes_id = t.tes_id and tp.tes_id = t.tes_id and a.are_id = t.are_id " & _
        ' '' '' ''            "and lis_fecing = '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' and t.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & " and p.PED_PROF <> 1 order by ped_turno, tes_ordenimp, tpa_orden"
        ' '' '' ''        Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte, , , , ,1)
        ' '' '' ''        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        ' '' '' ''        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        ' '' '' ''        frm_MDIChild.Text = "Hoja de Trabajo Microbiolog�a"
        ' '' '' ''        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        ' '' '' ''    Else
        ' '' '' ''        'otras areas
        ' '' '' ''        Dim obj_reporte As New rpt_hoja_trabajo()
        ' '' '' ''        str_sql = "select (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+  case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO))  when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, ('('+ pac_sexo + ')-' + 'EDAD: ' + cast(DATEDIFF(YEAR,PAC_FECNAC ,GETDATE()) as varchar) +  CHAR(13) + substring(pac_apellido + ' '+ pac_nombre,1,50))  as paciente, tpa_desc, are_nombre, getdate() as fecha, tes_ordenimp, tpa_orden, p.PED_TIPO " & _
        ' '' '' ''            "from lista_trabajo as lt, pedido as p, paciente as pac, test_parametro as tp, test as t, area as a " & _
        ' '' '' ''            "where lt.ped_id = p.ped_id And p.pac_id = pac.pac_id And lt.tes_id = tp.tes_id " & _
        ' '' '' ''            "and lt.tes_id = t.tes_id and tp.tes_id = t.tes_id and a.are_id = t.are_id " & _
        ' '' '' ''            "and lis_fecing between '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and p.PED_PROF <> 1 and t.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & " and p.PED_TIPO = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' order by ped_turno, tpa_orden, tes_ordenimp desc"
        ' '' '' ''        Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte, , , , ,1)
        ' '' '' ''        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        ' '' '' ''        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        ' '' '' ''        frm_MDIChild.Text = "Hoja de Trabajo"
        ' '' '' ''        frm_refer_main_form.Crea_formulario(frm_MDIChild)

        ' '' '' ''        g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIMIR HOJA TRABAJO", "", g_sng_user, "", "", "")
        ' '' '' ''    End If

        ' '' '' ''End If
        '' '' '' ''Dim titulo As String = "LISTA DE RESULTADOS"
        '' '' '' ''If dtt_trabajo.Rows.Count > 0 Then
        '' '' '' ''    Try
        '' '' '' ''        m_cls_dgimpresion = New cls_dgimpresion(dgrd_trabajo, PrintDocument1, dtv_trabajo, dtp_fecing.Text, cmb_eqp.Text, cmb_area.Text, cmb_vistas.Text, Me.Tag, titulo)
        '' '' '' ''        PrintPreviewDialog1.ShowDialog()
        '' '' '' ''        Me.Refresh()
        '' '' '' ''    Catch iex As System.Drawing.Printing.InvalidPrinterException
        '' '' '' ''        MsgBox("Error En la Impresora", MsgBoxStyle.Exclamation, "ANALISYS")
        '' '' '' ''    End Try
        '' '' '' ''    Me.Cursor = System.Windows.Forms.Cursors.Arrow
        '' '' '' ''End If
    End Sub

    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        Dim boo_existe As Boolean
        Dim int_i, int_cont, int_id As Short
        boo_cambia = False
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        On Error GoTo msgerr
        'Dim i As Byte = 0
        'For int_i = 0 To lst_trabajo.Items.Count - 1
        '    If lst_trabajo.GetSelected(int_i) = True Then
        '        i = i + 1
        '    End If
        'Next

        For int_i = 0 To lst_trabajo.Items.Count - 1

            If lst_trabajo.GetSelected(int_i) = True Then
                Dim dts_trabajo2 As DataSet
                Dim dtr_fila3 As DataRow
                Dim arr_tmp() As String
                Dim arr_datos As New ArrayList()
                opr_trabajo.LeerDetallePedidoArea(Val(lst_trabajo.Items.Item(int_i).substring(53, 7)), str_areas, arr_datos)

                For int_id = 0 To arr_datos.Count - 1
                    arr_tmp = Split(arr_datos(int_id), "°")
                    boo_existe = False

                    For int_cont = 0 To dtt_trabajo.Rows.Count - 1
                        If Trim(lst_trabajo.Items.Item(int_i).substring(53, 7)) = Trim(dtt_trabajo.Rows(int_cont).Item(0)) _
                        And dtt_trabajo.Rows(int_cont).Item(4) = CInt(arr_tmp(1)) And dtt_trabajo.Rows(int_cont).Item(14) = CInt(arr_tmp(5)) Then
                            boo_existe = True
                            Exit For
                        End If
                    Next

                    If Not boo_existe Then
                        Dim dtr_fila2 As DataRow = dtt_trabajo.NewRow
                        'JVA 13-ene-04 CAMBIO EN LST. PARA VER EL TURNO.
                        dtr_fila2(0) = Trim(lst_trabajo.Items.Item(int_i).substring(53, 7))  'pedido id
                        dtr_fila2(1) = Trim(lst_trabajo.Items.Item(int_i).substring(0, 10)) 'turno
                        dtr_fila2(2) = Trim(lst_trabajo.Items.Item(int_i).substring(10, 25))
                        dtr_fila2(3) = arr_tmp(0)  'tes_nombre
                        dtr_fila2(4) = CInt(arr_tmp(1))  'tes_id
                        dtr_fila2(14) = CInt(arr_tmp(5)) 'perfil (Nulo o 0, indica que no tiene perfil)
                        dtr_fila2(15) = 0           'nuevo
                        dtr_fila2(19) = arr_tmp(6)  'area

                        dts_trabajo2 = opr_trabajo.LeerEquipoTest(CInt(arr_tmp(1)), 1)
                        If dts_trabajo2.Tables("Registros").Rows.Count > 0 Then
                            For Each dtr_fila3 In dts_trabajo2.Tables("Registros").Rows
                                If IsDBNull(dtr_fila3(0)) Then
                                    dtr_fila2(5) = "<MANUAL>"
                                Else
                                    If dtr_fila3(2) <> 0 Then
                                        dtr_fila2(5) = dtr_fila3(0).ToString().PadRight(150) & dtr_fila3(1).ToString().PadRight(10)
                                    Else
                                        dtr_fila2(5) = "<MANUAL>"
                                    End If
                                End If
                            Next
                        Else
                            dtr_fila2(5) = "<MANUAL>"
                        End If

                        dtr_fila2(6) = ""
                        dtr_fila2(7) = ""
                        dtr_fila2(8) = ""
                        dtr_fila2(9) = "--"
                        dtr_fila2(10) = 0        'inserta gr�fico de estado
                        dtr_fila2(17) = ""

                        If dtr_fila2(5) <> "<MANUAL>" And dtr_fila2(5) <> "" Then
                            Dim arr_str_datos() As String
                            opr_trabajo.LeerDatosTest_LIS(dtr_fila2(4), Trim(Mid(dtr_fila2(5), 151, 10)), arr_str_datos)
                            dtr_fila2(11) = arr_str_datos(0)  'Tubos por eqp: 1: tubo con c�digo de barra, 2: copa o tubo sin c�digo de barra, 3: ambos
                            dtr_fila2(12) = arr_str_datos(1)  'Muestras ID por eqp
                            dtr_fila2(13) = arr_str_datos(2) 'Muestras ID por test
                            dtr_fila2(16) = arr_str_datos(3) 'muestras que acepta el equipo
                            dtr_fila2(17) = NULOS(arr_str_datos(6), "")
                            'tubo predeterminado
                            Select Case arr_str_datos(5)
                                Case "1"
                                    dtr_fila2(7) = "Tubo Primario"
                                Case "2"
                                    dtr_fila2(7) = "Copa"
                            End Select
                            'muestra predeterminada
                            If arr_str_datos(4) <> "" Then
                                Dim I As Short
                                For I = 0 To UBound(Arr_str_Muestra)
                                    If arr_str_datos(4) = Trim(Mid(Arr_str_Muestra(I), 151, 10)) Then
                                        dtr_fila2(6) = Arr_str_Muestra(I)
                                        Exit For
                                    End If
                                Next
                            End If
                            'rack predeterminado
                            Cargar_RackDefault(dtr_fila2)
                        Else
                            dtr_fila2(11) = 0
                            dtr_fila2(12) = ""
                            dtr_fila2(13) = ""
                            dtr_fila2(16) = ""
                        End If
                        dtt_trabajo.Rows.Add(dtr_fila2)
                    End If
                Next
            Else
                If Not lst_trabajo.GetSelected(int_i) Then
                    For int_cont = dtt_trabajo.Rows.Count - 1 To 0 Step -1
                        If Trim(lst_trabajo.Items.Item(int_i).substring(53, 7)) = Trim(dtt_trabajo.Rows(int_cont).Item(0)) Then
                            If dtt_trabajo.Rows(int_cont).Item(15) = 0 Then
                                dtt_trabajo.Rows(int_cont).Delete()
                            End If
                        End If
                    Next
                End If
            End If
        Next
        boo_cambia = True
        Me.Cursor = System.Windows.Forms.Cursors.Default
        lbl_num.Text = dtv_trabajo.Count
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se puede cargar los datos solicitados. Consultar con soporte t�cnico")
        Err.Clear()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        boo_cambia = True
    End Sub

    Private Sub dtp_fecing_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecing.ValueChanged
        lbl_num.Text = dtv_trabajo.Count
    End Sub

    Private Sub btn_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualizar.Click
        On Error GoTo msgerror
        ''frm_refer_main_form.escribemsj("ACTUALIZANDO LISTA DE TRABAJO, ESPERE POR FAVOR")
        Me.Cursor = Cursors.WaitCursor
        opr_trabajo.LlenarListaTrabajo(lst_trabajo, cmb_prioridad.Text, str_areas, "")
        LLENA_DATOS_LISTA()
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
        Me.Cursor = Cursors.Arrow
        Exit Sub
msgerror:
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
        Me.Cursor = Cursors.Arrow
        MsgBox("Se han producido errores en la carga Informacion, cierre esta ventana e int�ntelo nuevamente.", MsgBoxStyle.Information, "ANALISYS")
        Err.Clear()
    End Sub

    'Evento bot�n estado creado por XBR (Paso 1)
    Private Sub btn_estado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estado.Click
        Dim opr_SNI As New Cls_SNI()
        Dim str_resultado As String
        opr_SNI.Cambia_Estado("Cell Dyn 3700", dtp_fecing.Value)
    End Sub



    'Private Sub btn_envioMIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_envioMIS.Click
    '    Dim frm_MDIChild As New Frm_Retransmitir()
    '    frm_MDIChild.frm_refer_main = Me.ParentForm
    '    frm_MDIChild.ShowDialog(Me.ParentForm)
    'End Sub

    Private Sub btn_corden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_corden.Click
        Dim str_sql As String
        Dim str_vistas As String = Nothing
        Dim str_auxtipo As String = Nothing
        Select Case cmb_vistas.Text

            Case "Pendientes"
                str_vistas = " and LISTA_TRABAJO.LIS_RESESTADO =0 "
            Case "Validados"
                str_vistas = " and LISTA_TRABAJO.LIS_RESESTADO =2 "
            Case "Impresos"
                str_vistas = " PEDIDO.PED_ESTADO = 5 and LISTA_TRABAJO.LIS_RESESTADO =2 "
        End Select
        If Me.cmb_area.Text = "<Disponibles>" Then
            'TODOS LOS REGISTROS
            str_sql = "SELECT '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as FECHA, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_FECING, (PAC_APELLIDO+ ' '+ PAC_NOMBRE) AS PACIENTE, PAC_DOC, PEDIDO.PED_OBS as PAC_FONO, " & _
                "(cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int))  AS EDAD, " & _
                "test.TES_LIS as tpa_desc, LISTA_TRABAJO.tes_id, 'TODAS' as area, PED_NUMAUX " & _
                "FROM PEDIDO, LISTA_TRABAJO, PACIENTE, TEST, AREA " & _
                "WHERE LISTA_TRABAJO.LIS_FECING between '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 23:59:59' and PEDIDO.PED_PROF <> 1 AND " & _
                "TEST.ARE_ID = AREA.ARE_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND PEDIDO.PAC_ID = PACIENTE.PAC_ID AND " & _
                "LISTA_TRABAJO.TES_ID = TEST.TES_ID "
            str_sql = str_sql & str_vistas
        Else
            'POR UN AREA ESPECIFICA 
            str_sql = "SELECT '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as FECHA, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_FECING, (PAC_APELLIDO+ ' '+ PAC_NOMBRE) AS PACIENTE, PAC_DOC, PEDIDO.PED_OBS as PAC_FONO, " & _
                "(cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int))  AS EDAD, " & _
                "test.TES_LIS as tpa_desc, LISTA_TRABAJO.tes_id, ARE_NOMBRE AS AREA,PED_NUMAUX " & _
                "FROM PEDIDO, LISTA_TRABAJO, PACIENTE, TEST, AREA " & _
                "WHERE LISTA_TRABAJO.LIS_FECING between '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 23:59:59' and PEDIDO.PED_PROF <> 1 AND " & _
                "TEST.ARE_ID = AREA.ARE_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and PEDIDO.PAC_ID = PACIENTE.PAC_ID AND " & _
                "LISTA_TRABAJO.TES_ID = TEST.TES_ID And AREA.are_id = " & Trim(Mid(cmb_area.Text, 50, 10))
            str_sql = str_sql & str_vistas
        End If

        str_auxtipo = " and pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "'"

        If Trim(Mid(cmb_prioridad.Text, 1, 50)) = "TODOS" Then
            str_sql = str_sql

        Else
            str_sql = str_sql & str_auxtipo

        End If



        Dim obj_reporte As New rpt_contraorden()
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Reporte Contraorden"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)

        g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIMIR CONTRAORDEN", "", g_sng_user, "", "", "")
    End Sub







    ''Private Sub cmb_prioridad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_prioridad.SelectedIndexChanged
    ''    str_areas = ""
    ''    arr_datos.Clear()
    ''    cmb_area.Items.Add("<Disponibles>")
    ''    opr_user.LeerAreasUsuario(g_sng_user, arr_datos, arr_nombre)
    ''    For int_i = 0 To arr_datos.Count - 1
    ''        str_areas = str_areas & arr_datos(int_i) & ","
    ''        cmb_area.Items.Add(arr_nombre(int_i).ToString.PadRight(50) & arr_datos(int_i).ToString.PadRight(10))
    ''    Next
    ''    opr_trabajo.LlenarListaTrabajo(lst_trabajo, cmb_prioridad.Text, str_areas)
    ''    LLENA_DATOS_LISTA()
    ''End Sub



    Private Sub btn_consultar_LT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo msgerror
        Me.Cursor = Cursors.WaitCursor
        opr_trabajo.LlenarListaTrabajo(lst_trabajo, Trim(Mid(cmb_prioridad.Text, 1, 50)), str_areas, "")
        LLENA_DATOS_LISTA()
        lbl_num.Text = dtv_trabajo.Count
        Me.Cursor = Cursors.Arrow
        Exit Sub
msgerror:
        Me.Cursor = Cursors.Arrow
        MsgBox("Se han producido errores en la carga Informacion, cierre esta ventana e intentelo nuevamente.", MsgBoxStyle.Information, "ANALISYS")
        Err.Clear()
    End Sub


    Private Sub cmb_prioridad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_prioridad.SelectedIndexChanged
        On Error GoTo msgerror
        Me.Cursor = Cursors.WaitCursor
        opr_trabajo.LlenarListaTrabajo(lst_trabajo, Trim(Mid(cmb_prioridad.Text, 1, 50)), str_areas, "")
        LLENA_DATOS_LISTA()
        lbl_num.Text = dtv_trabajo.Count
        Me.Cursor = Cursors.Arrow
        Exit Sub
msgerror:
        Me.Cursor = Cursors.Arrow
        MsgBox("Se han producido errores en la carga Informacion, cierre esta ventana e intentelo nuevamente.", MsgBoxStyle.Information, "ANALISYS")
        Err.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HojaRes.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_desde_hasta As String
        Dim frm_MDIChild As New frm_TrabajoFiltro()
        Dim str_sql As String

        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        str_desde_hasta = frm_MDIChild.Tag

        If str_desde_hasta = "" Then

            ' ''If Me.cmb_area.Text = "<Disponibles>" Then
            ' ''    'TODOS LOS REGISTROS
            ' ''    str_sql = "SELECT '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as FECHA, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_FECING, (PAC_APELLIDO+ ' '+ PAC_NOMBRE) AS PACIENTE, PAC_DOC, PAC_FONO, " & _
            ' ''        "(cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int))  AS EDAD, " & _
            ' ''        "tpa_desc, LISTA_TRABAJO.tes_id, 'TODAS' as area FROM PEDIDO, LISTA_TRABAJO, PACIENTE, TEST, TEST_PARAMETRO, AREA " & _
            ' ''        "WHERE LISTA_TRABAJO.LIS_FECING between '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 23:59:59' and PEDIDO.PED_PROF <> 1 AND " & _
            ' ''        "TEST.ARE_ID = AREA.ARE_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND PEDIDO.PAC_ID = PACIENTE.PAC_ID AND " & _
            ' ''        "LISTA_TRABAJO.TES_ID = TEST.TES_ID And TEST.TES_ID = TEST_PARAMETRO.TES_ID And TEST_PARAMETRO.tpa_orden = 0 and LISTA_TRABAJO.TES_ID = TEST_PARAMETRO.TES_ID;"
            ' ''Else
            ' ''    'POR UN AREA ESPECIFICA 
            ' ''    str_sql = "SELECT '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as FECHA, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PED_FECING, (PAC_APELLIDO+ ' '+ PAC_NOMBRE) AS PACIENTE, PAC_DOC, PAC_FONO, " & _
            ' ''        "(cast(datediff(dd,PAC_FECNAC,GETDATE()) / 365.25 as int))  AS EDAD, " & _
            ' ''        "tpa_desc, LISTA_TRABAJO.tes_id, ARE_NOMBRE AS AREA FROM PEDIDO, LISTA_TRABAJO, PACIENTE, TEST, TEST_PARAMETRO, AREA " & _
            ' ''        "WHERE LISTA_TRABAJO.LIS_FECING between '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & " 23:59:59' and PEDIDO.PED_PROF <> 1 AND " & _
            ' ''        "TEST.ARE_ID = AREA.ARE_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and PEDIDO.PAC_ID = PACIENTE.PAC_ID AND " & _
            ' ''        "LISTA_TRABAJO.TES_ID = TEST.TES_ID And TEST.TES_ID = TEST_PARAMETRO.TES_ID And LISTA_TRABAJO.TES_ID = TEST_PARAMETRO.TES_ID and AREA.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & ";"
            ' ''End If
            str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, " & _
           "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
           "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
           "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
           "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno " & _
           "from paciente, pedido, medico, laboratorio, pedido_detalle, perfil where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id " & _
           "UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba, " & _
           "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
           "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
           "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
           "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno " & _
           "from paciente, pedido, medico, laboratorio, pedido_detalle, test WHERE pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"

        Else
            Dim sec_desdeHasta As String()
            sec_desdeHasta = Split(str_desde_hasta, "/")
            str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, " & _
            "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
            "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno " & _
            "from paciente, pedido, medico, laboratorio, pedido_detalle, perfil where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and pedido.ped_turno between " & CInt(sec_desdeHasta(0)) & " and " & CInt(sec_desdeHasta(1)) & " and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id " & _
            "UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido + ' ' + pac_nombre) as pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba, " & _
            "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
            "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno " & _
            "from paciente, pedido, medico, laboratorio, pedido_detalle, test where pedido.CON_NOMBRE = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' and pedido.PED_ESTADO <> 2 and pedido.ped_fecing BETWEEN '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and pedido.ped_turno between " & CInt(sec_desdeHasta(0)) & " and " & CInt(sec_desdeHasta(1)) & " and laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"

        End If
        '''Dim obj_reporte As New rpt_contraorden()
        Dim obj_reporte As New rpt_ContraOrden2()
        Dim frm_MDIChild2 As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
        frm_MDIChild2.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild2.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild2.Text = "Reporte Contraorden"
        frm_refer_main_form.Crea_formulario(frm_MDIChild2)


        '' '' ''On Error GoTo msgerror
        '' '' ''Me.Cursor = Cursors.WaitCursor
        '' '' ''opr_trabajo.LlenarListaTrabajo(lst_trabajo, Trim(Mid(cmb_prioridad.Text, 1, 50)), str_areas, str_desde_hasta)
        '' '' ''LLENA_DATOS_LISTA()
        '' '' ''lbl_num.Text = dtv_trabajo.Count
        '' '' ''Me.Cursor = Cursors.Arrow
        Exit Sub
msgerror:
        Me.Cursor = Cursors.Arrow
        MsgBox("Se han producido errores en la carga Informacion, cierre esta ventana e intentelo nuevamente.", MsgBoxStyle.Information, "ANALISYS")
        Err.Clear()
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIMIR HOJA TRABAJO POR SECUENCIA", "", g_sng_user, "", "", "")

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    
    
    
    
    Private Sub btn_Cuadricula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cuadricula.Click
        If Me.cmb_area.Text = "<Disponibles>" Then
            MsgBox("Reporte de Hoja de Trabajo no disponible cuando no se ha especificado una area ", MsgBoxStyle.Information, "ANALISYS")
        Else

            Dim str_sql As String
            If Trim(Mid(cmb_area.Text, 1, 49)) = "MICROBIOLOGIA" Then
                Dim obj_reporte As New rpt_hoja_trabajo_micro()
                str_sql = "select ped_turno, (pac_apellido+ ' '+ pac_nombre) as paciente, tpa_desc, are_nombre, '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' as fecha, tes_ordenimp, tpa_orden  " & _
                    "from lista_trabajo as lt, pedido as p, paciente as pac, test_parametro as tp, test as t, area as a " & _
                    "where lt.ped_id = p.ped_id And p.pac_id = pac.pac_id And lt.tes_id = tp.tes_id " & _
                    "and lt.tes_id = t.tes_id and tp.tes_id = t.tes_id and a.are_id = t.are_id " & _
                    "and lis_fecing = '" & Format(dtp_fecing.Value, "dd/MM/yyyy") & "' and t.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & " and p.PED_PROF <> 1 order by ped_turno, tes_ordenimp, tpa_orden"
                Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                frm_MDIChild.Text = "Hoja de Trabajo Microbiologia"
                frm_refer_main_form.Crea_formulario(frm_MDIChild)
            Else
                'otras areas
                Dim obj_reporte As New rpt_hoja_trabajo()
                str_sql = "select (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+  " & _
                    "case when len(p.PED_TURNO) = 1 then('0000' + convert(varchar(100),p.PED_TURNO)) " & _
                    "when len(p.PED_TURNO) = 2 then('000' + convert(varchar(100),p.PED_TURNO)) " & _
                    "when len(p.PED_TURNO) = 3 then('00' + convert(varchar(100),p.PED_TURNO))  " & _
                    "when len(p.PED_TURNO) = 4 then('0' + convert(varchar(100),p.PED_TURNO))  " & _
                    "when len(p.PED_TURNO) = 5 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, ('('+ pac_sexo + ')-' + 'EDAD: ' + cast(DATEDIFF(YEAR,PAC_FECNAC ,GETDATE()) as varchar) +  CHAR(13) + substring(pac_apellido + ' '+ pac_nombre,1,50))  as paciente, tpa_desc, are_nombre, getdate() as fecha, tes_ordenimp, tpa_orden, p.PED_TIPO " & _
                    "from lista_trabajo as lt, pedido as p, paciente as pac, test_parametro as tp, test as t, area as a " & _
                    "where lt.ped_id = p.ped_id And p.pac_id = pac.pac_id And lt.tes_id = tp.tes_id " & _
                    "and lt.tes_id = t.tes_id and tp.tes_id = t.tes_id and a.are_id = t.are_id " & _
                    "and lis_fecing between '" & Format(dtp_fecing.Value, "dd/MM/yyyy 00:00:00") & "' and '" & Format(dtp_fecing.Value, "dd/MM/yyyy 23:59:59") & "' and p.PED_PROF <> 1 and t.are_id = " & Trim(Mid(cmb_area.Text, 50, 10)) & " and p.PED_TIPO = '" & Trim(Mid(cmb_prioridad.Text, 1, 50)) & "' order by ped_turno, tpa_orden, tes_ordenimp desc"
                Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                frm_MDIChild.Text = "Hoja de Trabajo"
                frm_refer_main_form.Crea_formulario(frm_MDIChild)

                g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIMIR HOJA TRABAJO", "", g_sng_user, "", "", "")
            End If

        End If
    End Sub

    
End Class