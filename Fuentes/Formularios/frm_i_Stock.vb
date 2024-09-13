'*************************************************************************
' Nombre:   frm_i_Stock
' Tipo de Archivo: formulario
' Descripción:  formulario que me permite visualizar el stock de productos
' Autores:  rfn
' Fecha de Creación: 

' Ultima Modificación: 22 agosto 2003
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO

Public Class frm_i_Stock
    Inherits System.Windows.Forms.Form
    Private m_cls_dgimpresion As cls_dgimpresion = Nothing
    Private printFont As Font

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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_stock As System.Windows.Forms.DateTimePicker
    Friend WithEvents imgl_stock As System.Windows.Forms.ImageList
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_bodega As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents cmb_divisiones As System.Windows.Forms.ComboBox
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents dgrd_Stock As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents rbtn_tot As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_lot As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtn_local As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_nped As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_safi As System.Windows.Forms.RadioButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_Stock))
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_stock = New System.Windows.Forms.DateTimePicker
        Me.imgl_stock = New System.Windows.Forms.ImageList(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_bodega = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.cmb_divisiones = New System.Windows.Forms.ComboBox
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.dgrd_Stock = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.rbtn_tot = New System.Windows.Forms.RadioButton
        Me.rbtn_lot = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtn_safi = New System.Windows.Forms.RadioButton
        Me.rbtn_local = New System.Windows.Forms.RadioButton
        Me.rbtn_nped = New System.Windows.Forms.RadioButton
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(502, 31)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Hasta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_stock
        '
        Me.dtp_stock.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_stock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_stock.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_stock.Location = New System.Drawing.Point(114, 56)
        Me.dtp_stock.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_stock.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_stock.Name = "dtp_stock"
        Me.dtp_stock.Size = New System.Drawing.Size(112, 21)
        Me.dtp_stock.TabIndex = 0
        '
        'imgl_stock
        '
        Me.imgl_stock.ImageStream = CType(resources.GetObject("imgl_stock.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgl_stock.TransparentColor = System.Drawing.Color.Transparent
        Me.imgl_stock.Images.SetKeyName(0, "")
        Me.imgl_stock.Images.SetKeyName(1, "")
        Me.imgl_stock.Images.SetKeyName(2, "")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Bodega:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_bodega
        '
        Me.cmb_bodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bodega.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bodega.Location = New System.Drawing.Point(114, 30)
        Me.cmb_bodega.Name = "cmb_bodega"
        Me.cmb_bodega.Size = New System.Drawing.Size(166, 21)
        Me.cmb_bodega.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(18, 498)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 60)
        Me.Panel1.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "El producto está por llegar al stock mínimo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "El producto excede el stock máximo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "El producto está por debajo del stock mínimo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 14)
        Me.PictureBox3.TabIndex = 122
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 14)
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 14)
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(416, 31)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 24)
        Me.btn_imprimir.TabIndex = 3
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'cmb_divisiones
        '
        Me.cmb_divisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_divisiones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_divisiones.Location = New System.Drawing.Point(316, 295)
        Me.cmb_divisiones.Name = "cmb_divisiones"
        Me.cmb_divisiones.Size = New System.Drawing.Size(166, 21)
        Me.cmb_divisiones.TabIndex = 131
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Location = New System.Drawing.Point(114, 85)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(168, 21)
        Me.txt_filtro.TabIndex = 132
        '
        'dgrd_Stock
        '
        Me.dgrd_Stock.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Stock.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Stock.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Stock.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Stock.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Stock.CaptionText = "STOCK DE PRODUCTOS"
        Me.dgrd_Stock.DataMember = ""
        Me.dgrd_Stock.FlatMode = True
        Me.dgrd_Stock.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_Stock.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Stock.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Stock.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Stock.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Stock.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Stock.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Stock.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Stock.Location = New System.Drawing.Point(18, 194)
        Me.dgrd_Stock.Name = "dgrd_Stock"
        Me.dgrd_Stock.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Stock.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Stock.ReadOnly = True
        Me.dgrd_Stock.RowHeaderWidth = 10
        Me.dgrd_Stock.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Stock.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Stock.Size = New System.Drawing.Size(562, 286)
        Me.dgrd_Stock.TabIndex = 135
        Me.dgrd_Stock.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Stock.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Stock
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "I_PRD_ID"
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Producto"
        Me.DataGridTextBoxColumn2.MappingName = "I_PRD_DESCRIPCION"
        Me.DataGridTextBoxColumn2.Width = 167
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Lote"
        Me.DataGridTextBoxColumn5.MappingName = "LOTE"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Stock"
        Me.DataGridTextBoxColumn3.MappingName = "SumaDeI_MOD_CANTIDAD"
        Me.DataGridTextBoxColumn3.Width = 55
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn4.MappingName = "I_UNI_DESCRIPCION"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "F.Caducidad"
        Me.DataGridTextBoxColumn6.MappingName = "VENCIMIENTO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Stock De Productos"
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
        'rbtn_tot
        '
        Me.rbtn_tot.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_tot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_tot.Location = New System.Drawing.Point(68, 22)
        Me.rbtn_tot.Name = "rbtn_tot"
        Me.rbtn_tot.Size = New System.Drawing.Size(62, 18)
        Me.rbtn_tot.TabIndex = 139
        Me.rbtn_tot.TabStop = True
        Me.rbtn_tot.Text = "Total"
        Me.rbtn_tot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_tot.UseVisualStyleBackColor = False
        '
        'rbtn_lot
        '
        Me.rbtn_lot.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_lot.Checked = True
        Me.rbtn_lot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_lot.Location = New System.Drawing.Point(6, 22)
        Me.rbtn_lot.Name = "rbtn_lot"
        Me.rbtn_lot.Size = New System.Drawing.Size(60, 18)
        Me.rbtn_lot.TabIndex = 140
        Me.rbtn_lot.TabStop = True
        Me.rbtn_lot.Text = "Lotes"
        Me.rbtn_lot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_lot.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 21)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Descripcion:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtn_lot)
        Me.GroupBox1.Controls.Add(Me.rbtn_tot)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 50)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbtn_safi)
        Me.GroupBox2.Controls.Add(Me.rbtn_local)
        Me.GroupBox2.Controls.Add(Me.rbtn_nped)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(313, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 48)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado"
        Me.GroupBox2.Visible = False
        '
        'rbtn_safi
        '
        Me.rbtn_safi.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_safi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_safi.Location = New System.Drawing.Point(192, 20)
        Me.rbtn_safi.Name = "rbtn_safi"
        Me.rbtn_safi.Size = New System.Drawing.Size(72, 18)
        Me.rbtn_safi.TabIndex = 143
        Me.rbtn_safi.Text = "General"
        Me.rbtn_safi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_safi.UseVisualStyleBackColor = False
        '
        'rbtn_local
        '
        Me.rbtn_local.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_local.Checked = True
        Me.rbtn_local.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_local.Location = New System.Drawing.Point(12, 20)
        Me.rbtn_local.Name = "rbtn_local"
        Me.rbtn_local.Size = New System.Drawing.Size(72, 18)
        Me.rbtn_local.TabIndex = 142
        Me.rbtn_local.TabStop = True
        Me.rbtn_local.Text = "Existen."
        Me.rbtn_local.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_local.UseVisualStyleBackColor = False
        '
        'rbtn_nped
        '
        Me.rbtn_nped.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_nped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_nped.Location = New System.Drawing.Point(94, 20)
        Me.rbtn_nped.Name = "rbtn_nped"
        Me.rbtn_nped.Size = New System.Drawing.Size(80, 18)
        Me.rbtn_nped.TabIndex = 141
        Me.rbtn_nped.Text = "N. Pedido"
        Me.rbtn_nped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_nped.UseVisualStyleBackColor = False
        '
        'frm_i_Stock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(597, 573)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgrd_Stock)
        Me.Controls.Add(Me.cmb_divisiones)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_bodega)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_stock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_i_Stock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock de Prductos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Código de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Public TIPO As String = Nothing


    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ClickMenu_Principal(Me)
        'Función para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            dbl_x = mousePos.X
            frm_refer_main_form.ubica(Me.Width, Me.Height, mousePos.Y, mousePos.X - frm_refer_main_form.Splitter.Width)
        End If
    End Sub

    Private Sub Formulario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
    End Sub

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Función para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseEnter, btn_imprimir.MouseEnter
        'cuando el mouse se mueve por encima del los botones del formulario
        Select Case sender.name
            Case "pic_min"
                If m_HtImages.ContainsKey("btn_minp") Then
                    imageToDraw = CType(m_HtImages("btn_minp"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_minp.jpg")
                        m_HtImages.Add("btn_minp", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseLeave, btn_imprimir.MouseLeave
        'cuando el mouse se pierde el enfoque del los botones del formulario
        Select Case sender.name
            Case "pic_min"
                If m_HtImages.ContainsKey("btn_min") Then
                    imageToDraw = CType(m_HtImages("btn_min"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_min.jpg")
                        m_HtImages.Add("btn_min", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        'elimina las funciones activas (ej menu) del formulario MDI.
        ClickMenu_Principal(Me)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
            Case "pic_min"
                Me.WindowState = FormWindowState.Minimized
                Me.ControlBox = True
                Me.MaximizeBox = False
        End Select
    End Sub

    Private Sub Formulario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'elimina la referecnia del formulario del MDI
        ClickMenu_Principal(Me)
        RemoveCtxMenu_Principal(Me, Me.Text)
    End Sub

    Private Sub Formulario_Borde(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
        'controla que el formulario cuando se encuentra minimizado tenga borde, y cuando se encuentra normal no tenga borde
        Dim lng_height, lng_width As Long
        lng_height = Me.Height
        lng_width = Me.Width
        Select Case Me.WindowState
            Case 0
                Me.FormBorderStyle = FormBorderStyle.None
            Case 1
                Me.FormBorderStyle = FormBorderStyle.FixedSingle
        End Select
        Me.Height = lng_height
        Me.Width = lng_width
    End Sub

#End Region

    Dim opr_movimiento As New Cls_i_Movimiento()
    Dim opr_bodega As New Cls_i_Bodega()
    Dim dtv_stock As New DataView()
    Dim dbl_porcentaje As Double

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Sub cargar_datos()
        'se carga el listview con el stock de productos
        Dim estado As Int32 = 0
        If rbtn_nped.Checked = True Then
            estado = 1
        ElseIf rbtn_safi.Checked = True Then
            estado = 2
        End If

        If cmb_bodega.Text = "<Todos>" Then
            opr_movimiento.LlenarListaStock(g_division, dtv_stock, dtp_stock.Value, Trim(cmb_bodega.Text.Substring(100, 15)), dbl_porcentaje, rbtn_lot.Checked, estado, cmb_divisiones.Text.Substring(50, 1))
        Else
            If Len(cmb_bodega.Text) > 0 Then
                opr_movimiento.LlenarListaStock(g_division, dtv_stock, dtp_stock.Value, Trim(cmb_bodega.Text.Substring(100, 15)), dbl_porcentaje, rbtn_lot.Checked, estado)
            Else
                ''frm_refer_main_form.escribemsj("NO EXISTE BODEGA A CONSULTAR")
            End If
        End If
        dtv_stock.RowFilter = " SumaDeI_MOD_CANTIDAD >= 0 "
    End Sub

    Private Sub frm_i_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'obtengo del app.config el procentaje de stock minimo de producto que dede existir ne bodega
        dbl_porcentaje = System.Configuration.ConfigurationSettings.AppSettings("porcentaje")
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_Grafica("st", "CANTIDAD", 20, False))
        g_division = 1
        If g_division = 1 Then
            ''llena el combo de divisiones
            'opr_bodega.LlenarCombodivision(cmb_divisiones)
            'Else
            '   opr_bodega.LlenarCombodivision(cmb_divisiones)
            '  cmb_divisiones.Enabled = False
            '  cmb_divisiones.SelectedIndex = g_division - 1
            opr_bodega.LlenarComboBodega(cmb_bodega, g_division)
            cmb_bodega.Items.Add("<Todos>")
        End If
        dgrd_Stock.DataSource = dtv_stock
        'cmb_filtro.SelectedIndex = 0
        txt_filtro.Focus()

        cmb_bodega.Text = "CIRCULACION".PadRight(100) & "B01".PadRight(15)
        'cargar_datos()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_stock.ValueChanged
        cargar_datos()
    End Sub

    Private Sub cmb_bodega_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_bodega.SelectedIndexChanged
        txt_filtro.Text = ""
        cargar_datos()
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click

        'Dim titulo As String = "STOCK DE PRODUCTOS"
        'Try
        '    m_cls_dgimpresion = New cls_dgimpresion(dgrd_Stock, PrintDocument1, dtv_stock, , cmb_bodega.Text, , dtp_stock.Text, cmb_divisiones.Text, titulo)
        '    PrintPreviewDialog1.ShowDialog()
        '    Me.Refresh()
        'Catch iex As System.Drawing.Printing.InvalidPrinterException
        '    MsgBox("Error En la Impresora", MsgBoxStyle.Exclamation, "ANALISYS")
        'End Try


        '****CRISTAL REPORTS****
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_i_stock()
        'INSTRUCCION SQL QUE ME PERMITE OBTENER EL STOCK DE PRODUCTOS DE UNA DETERMINADA BODEGA HASTA UNA FECHA ESPECIFICA
        'str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text.Substring(0, 10)) & "' AS BODEGA, Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD) AS total,  I_PRODUCTO.I_PRD_ID,I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_ID, I_PRD_EXIST_MIN, I_PRD_EXIST_MAX FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECMOV) <= '" & Format(dtp_stock.Value, "yyyy-MM-dd") & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & Trim(cmb_bodega.Text.Substring(0, 10)) & "')) GROUP BY I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX ORDER BY I_PRODUCTO.I_PRD_ID;"
        Dim estado As Int32 = 0
        If rbtn_nped.Checked = True Then
            estado = 1
        ElseIf rbtn_safi.Checked = True Then
            estado = 2
        End If

        Dim aux As String = "(I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 or I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3)"
        Dim aux1 As String = " (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)) "
        If estado = 1 Then
            aux = "(I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 1 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3)"
            'aux = "I_MOVIMIENTO.I_MOV_ESTADO = 2"
            aux1 = " (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)*-1) "
        ElseIf estado = 2 Then
            aux = "(I_MOVIMIENTO_DETALLE.I_MOD_ESTADO = 0 ) and (I_MOVIMIENTO.I_MOV_ESTADO <> 0 and I_MOVIMIENTO.I_MOV_ESTADO <> 3)"
            'aux = "I_MOVIMIENTO.I_MOV_ESTADO = 1"
            aux1 = " (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)) "
        End If

        If rbtn_lot.Checked = True Then ' SI LA SELECCION ES POR LOTES
            If cmb_bodega.Text = "<Todos>" Then
                If g_division = 0 Then
                    str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text) & "' as BODEGA, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE, " & aux1 & " AS CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD_stock, I_MOD_FECVEN AS VENCIMIENTO  FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(dtp_stock.Value, "yyyy-MM-dd") & "')) and I_PRODUCTO.DIV_ID= '" & cmb_divisiones.Text.Substring(50, 1) & "' and (" & aux & " ) GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID ORDER BY I_PRODUCTO.I_PRD_ID;"
                Else
                    str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text) & "' as BODEGA, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE, " & aux1 & " AS CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD_stock, I_MOD_FECVEN AS VENCIMIENTO  FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(dtp_stock.Value, "yyyy-MM-dd") & "')) and I_PRODUCTO.DIV_ID= '" & g_division & "'  and (" & aux & ") GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID ORDER BY I_PRODUCTO.I_PRD_ID;"
                End If
            Else
                'str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text.Substring(0, 10)) & "' as BODEGA, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, IF(isnull(I_MOVIMIENTO_DETALLE.I_MOD_LOTE) or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = ''  ,'Sin Lote',I_MOVIMIENTO_DETALLE.I_MOD_LOTE) AS LOTE,  " & aux1 & " AS CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX,  if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1,1,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000,2,(if(Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD_stock, I_MOD_FECVEN AS VENCIMIENTO FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(dtp_stock.Value, "yyyy-MM-dd") & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & cmb_bodega.Text.Substring(0, 15) & "')) and (" & aux & " ) GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID ORDER BY I_PRODUCTO.I_PRD_ID;"
                str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text.Substring(0, 100)) & "' as BODEGA, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, " & _
                   "case when I_MOVIMIENTO_DETALLE.I_MOD_LOTE = NULL or I_MOVIMIENTO_DETALLE.I_MOD_LOTE = '' then 'Sin Lote' else I_MOVIMIENTO_DETALLE.I_MOD_LOTE end AS LOTE, (Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD))  AS CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, " & _
                   "case when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1 then 1 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000 then 2 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(0 /100))) then 3 else 0 end AS CANTIDAD2, I_MOD_FECVEN AS VENCIMIENTO " & _
                   "FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID " & _
                   "WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & Trim(cmb_bodega.Text.Substring(100, 15)) & "')) and (" & aux & " ) " & _
                   "GROUP BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN " & _
                   "ORDER BY I_MOVIMIENTO_DETALLE.I_MOD_LOTE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, I_MOVIMIENTO_DETALLE.I_MOD_FECVEN"
            End If

        Else ' SI LA SELECCION ES DE TODOS LOS PRODUCTOS
            If cmb_bodega.Text = "<Todos>" Then
                If g_division = 0 Then
                    str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text) & "' as BODEGA, 'TODOS' AS LOTE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, " & aux1 & " AS CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, case when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1 then 1 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000 then 2 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD_stock  FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(dtp_stock.Value, "yyyy-MM-dd") & "')) and I_PRODUCTO.DIV_ID= '" & cmb_divisiones.Text.Substring(50, 1) & "' and (" & aux & ") GROUP BY I_PRODUCTO.I_PRD_ID, I_UNIDAD.I_UNI_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX ORDER BY I_PRODUCTO.I_PRD_ID;"
                Else
                    str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text) & "' as BODEGA,'TODOS' AS LOTE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, " & aux1 & " AS CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, case when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1 then 1 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000 then 2 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))),3,0))))) AS CANTIDAD_stock FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(dtp_stock.Value, "yyyy-MM-dd") & "')) and I_PRODUCTO.DIV_ID= '" & g_division & "'  and (" & aux & ") GROUP BY I_PRODUCTO.I_PRD_ID, I_UNIDAD.I_UNI_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX ORDER BY I_PRODUCTO.I_PRD_ID;"
                End If
            Else
                str_sql = "SELECT '" & Format(dtp_stock.Value, "dd/MM/yyyy") & "' as FECHA, '" & Trim(cmb_bodega.Text.Substring(0, 10)) & "' as BODEGA,'TODOS' AS LOTE, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_DESCRIPCION, " & aux1 & " AS CANTIDAD, I_UNIDAD.I_UNI_DESCRIPCION, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, case when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<1 then 1 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)>1000 then 2 when Sum(I_MOVIMIENTO_DETALLE.I_MOD_CANTIDAD)<(I_PRODUCTO.I_PRD_EXIST_MIN+(I_PRODUCTO.I_PRD_EXIST_MIN*(" & dbl_porcentaje & " /100))) then 3 else 0 end AS CANTIDAD_stock FROM I_UNIDAD INNER JOIN (I_PRODUCTO INNER JOIN (I_MOVIMIENTO INNER JOIN I_MOVIMIENTO_DETALLE ON I_MOVIMIENTO.I_MOV_ID = I_MOVIMIENTO_DETALLE.I_MOV_ID) ON I_PRODUCTO.I_PRD_ID = I_MOVIMIENTO_DETALLE.I_PRD_ID) ON I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID WHERE(((I_MOVIMIENTO.I_MOV_FECDOC) <= '" & Format(dtp_stock.Value, "yyyy-MM-dd") & "') And ((I_MOVIMIENTO_DETALLE.I_BOD_ID) = '" & Trim(cmb_bodega.Text.Substring(100, 15)) & "')) and (" & aux & ") GROUP BY I_PRODUCTO.I_PRD_ID, I_UNIDAD.I_UNI_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, I_PRODUCTO.I_PRD_DESCRIPCION, I_UNIDAD.I_UNI_DESCRIPCION  ORDER BY I_PRODUCTO.I_PRD_ID;"
            End If
        End If
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Stock de Productos"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub cmb_divisiones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_divisiones.SelectedValueChanged
        opr_bodega.LlenarComboBodega(cmb_bodega, CInt(Trim(Mid(cmb_divisiones.SelectedItem, 20))))
        cmb_bodega.Items.Add("<Todos>")
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        'cada que presiono una tecla aplica un filtro por nombre de test o por su código según la selección
        'If cmb_filtro.Text = "Código del Producto" Then
        '    If Trim(txt_filtro.Text) <> "" Then
        '        dtv_stock.RowFilter = "i_prd_id like '" & Trim(txt_filtro.Text) & "*' and SumaDeI_MOD_CANTIDAD > 0"
        '        'dtv_stock.RowFilter = "i_prd_id = " & CInt(Trim(txt_filtro.Text))
        '    Else
        '        dtv_stock.RowFilter = "SumaDeI_MOD_CANTIDAD > 0"
        '    End If
        '    dtv_stock.Sort = "i_prd_id"
        'Else
        If Trim(txt_filtro.Text) <> "" Then
            dtv_stock.RowFilter = "i_prd_descripcion like '" & Trim(txt_filtro.Text) & "*' and SumaDeI_MOD_CANTIDAD > 0"
        Else
            dtv_stock.RowFilter = "SumaDeI_MOD_CANTIDAD > 0"
        End If
        dtv_stock.Sort = "i_prd_descripcion"
        ' End If
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.Text = " STOCK DE PRODUCTOS"
        PrintPreviewDialog1.Icon = CType(Me.Icon, System.Drawing.Icon)
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

    Private Sub rbtn_lot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_lot.CheckedChanged
        If rbtn_lot.Checked = False Then
            If txt_filtro.Text <> "" Then
                txt_filtro.Text = ""
            End If
            Me.DataGridTextBoxColumn2.Width = 313
            Me.DataGridTextBoxColumn5.Width = 0
            Me.DataGridTextBoxColumn6.Width = 0
            cargar_datos()
        End If
    End Sub

    Private Sub rbtn_tot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_tot.CheckedChanged
        If rbtn_tot.Checked = False Then
            If txt_filtro.Text <> "" Then
                txt_filtro.Text = ""
            End If
            Me.DataGridTextBoxColumn2.Width = 170
            Me.DataGridTextBoxColumn5.Width = 75
            Me.DataGridTextBoxColumn6.Width = 75
            cargar_datos()
        End If
    End Sub

    Private Sub rbtn_local_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_local.CheckedChanged
        If rbtn_local.Checked = False Then
            txt_filtro.Text = ""
            cargar_datos()
        End If
    End Sub

    Private Sub rbtn_nped_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_nped.CheckedChanged
        If rbtn_nped.Checked = False Then
            txt_filtro.Text = ""
            cargar_datos()
        End If
    End Sub

    Private Sub rbtn_safi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_safi.CheckedChanged
        If rbtn_safi.Checked = False Then
            txt_filtro.Text = ""
            cargar_datos()
        End If
    End Sub

    
End Class