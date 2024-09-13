Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.Odbc

Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports MessagingToolkit.QRCode.Codec


Public Class frm_ValFinal
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
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents lbl_pedidoD As System.Windows.Forms.Label
    Friend WithEvents dgrd_pedidos As System.Windows.Forms.DataGrid
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents lbl_ordenMIS As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_CWeb As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_valida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic_wait As System.Windows.Forms.PictureBox
    Friend WithEvents pan_hist As System.Windows.Forms.Panel
    Friend WithEvents pic_rbc As System.Windows.Forms.PictureBox
    Friend WithEvents pic_wbc As System.Windows.Forms.PictureBox
    Friend WithEvents pic_plt As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_enviarWeb As System.Windows.Forms.CheckBox
    Friend WithEvents btn_enviarQR As System.Windows.Forms.Button
    Friend WithEvents Pic_QR As System.Windows.Forms.PictureBox
    Friend WithEvents txt_URL As System.Windows.Forms.TextBox
    Friend WithEvents btn_clipUrl As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_ExpandeBloque As System.Windows.Forms.Button
    Friend WithEvents cmb_ConvBloque As System.Windows.Forms.ComboBox
    Friend WithEvents Dtp_ped_fecing As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_ValidaBloque As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lst_pedidos As System.Windows.Forms.ListBox
    Friend WithEvents cmb_FormatoPdf As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_convenio As System.Windows.Forms.Label
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ValFinal))
        Me.lbl_pedido = New System.Windows.Forms.Label
        Me.lbl_pedidoD = New System.Windows.Forms.Label
        Me.dgrd_pedidos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.lbl_ordenMIS = New System.Windows.Forms.Label
        Me.btn_CWeb = New System.Windows.Forms.Button
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtp_fecha_valida = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.pic_wait = New System.Windows.Forms.PictureBox
        Me.pan_hist = New System.Windows.Forms.Panel
        Me.pic_rbc = New System.Windows.Forms.PictureBox
        Me.pic_wbc = New System.Windows.Forms.PictureBox
        Me.pic_plt = New System.Windows.Forms.PictureBox
        Me.chk_enviarWeb = New System.Windows.Forms.CheckBox
        Me.btn_enviarQR = New System.Windows.Forms.Button
        Me.Pic_QR = New System.Windows.Forms.PictureBox
        Me.txt_URL = New System.Windows.Forms.TextBox
        Me.btn_clipUrl = New System.Windows.Forms.Button
        Me.btn_ExpandeBloque = New System.Windows.Forms.Button
        Me.cmb_ConvBloque = New System.Windows.Forms.ComboBox
        Me.Dtp_ped_fecing = New System.Windows.Forms.DateTimePicker
        Me.btn_ValidaBloque = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lst_pedidos = New System.Windows.Forms.ListBox
        Me.cmb_FormatoPdf = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_convenio = New System.Windows.Forms.Label
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        CType(Me.pic_wait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_hist.SuspendLayout()
        CType(Me.pic_rbc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_wbc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_plt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_pedido
        '
        Me.lbl_pedido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.Location = New System.Drawing.Point(24, 54)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(60, 14)
        Me.lbl_pedido.TabIndex = 41
        Me.lbl_pedido.Text = "Pedido:"
        '
        'lbl_pedidoD
        '
        Me.lbl_pedidoD.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pedidoD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedidoD.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pedidoD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_pedidoD.Location = New System.Drawing.Point(83, 56)
        Me.lbl_pedidoD.Name = "lbl_pedidoD"
        Me.lbl_pedidoD.Size = New System.Drawing.Size(102, 14)
        Me.lbl_pedidoD.TabIndex = 42
        '
        'dgrd_pedidos
        '
        Me.dgrd_pedidos.AllowSorting = False
        Me.dgrd_pedidos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_pedidos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_pedidos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_pedidos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_pedidos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.CaptionText = "EXAMENES"
        Me.dgrd_pedidos.DataMember = ""
        Me.dgrd_pedidos.FlatMode = True
        Me.dgrd_pedidos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_pedidos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_pedidos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_pedidos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_pedidos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.Location = New System.Drawing.Point(24, 120)
        Me.dgrd_pedidos.Name = "dgrd_pedidos"
        Me.dgrd_pedidos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_pedidos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.RowHeaderWidth = 20
        Me.dgrd_pedidos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_pedidos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.Size = New System.Drawing.Size(445, 224)
        Me.dgrd_pedidos.TabIndex = 0
        Me.dgrd_pedidos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_pedidos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridBoolColumn2, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn5, Me.DataGridBoolColumn3, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "TES_ID"
        Me.DataGridTextBoxColumn1.MappingName = "tes_id"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Test"
        Me.DataGridTextBoxColumn2.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 210
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PER_ID"
        Me.DataGridTextBoxColumn3.MappingName = "PER_ID"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Perfil"
        Me.DataGridTextBoxColumn4.MappingName = "PER_NOMBRE"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = "False"
        Me.DataGridBoolColumn2.HeaderText = "Proces"
        Me.DataGridBoolColumn2.MappingName = "PROCESADO"
        Me.DataGridBoolColumn2.NullText = "False"
        Me.DataGridBoolColumn2.ReadOnly = True
        Me.DataGridBoolColumn2.TrueValue = "True"
        Me.DataGridBoolColumn2.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = "False"
        Me.DataGridBoolColumn1.HeaderText = "Rep"
        Me.DataGridBoolColumn1.MappingName = "OK"
        Me.DataGridBoolColumn1.TrueValue = "True"
        Me.DataGridBoolColumn1.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn5.MappingName = "ESTADO"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridBoolColumn3
        '
        Me.DataGridBoolColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn3.AllowNull = False
        Me.DataGridBoolColumn3.FalseValue = "False"
        Me.DataGridBoolColumn3.HeaderText = "Remitido"
        Me.DataGridBoolColumn3.MappingName = "Remitido"
        Me.DataGridBoolColumn3.NullText = ""
        Me.DataGridBoolColumn3.ReadOnly = True
        Me.DataGridBoolColumn3.TrueValue = "True"
        Me.DataGridBoolColumn3.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "FECHA"
        Me.DataGridTextBoxColumn6.MappingName = "PED_FECING"
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "PACIENTE"
        Me.DataGridTextBoxColumn7.MappingName = "PACIENTE"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn8.MappingName = "TURNO"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "CORREO"
        Me.DataGridTextBoxColumn9.MappingName = "CORREO"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "PAC_ID"
        Me.DataGridTextBoxColumn10.MappingName = "PAC_ID"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "TIPO"
        Me.DataGridTextBoxColumn11.MappingName = "TIPO"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "CONVENIO"
        Me.DataGridTextBoxColumn12.MappingName = "CONVENIOMAIL"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "FEC NAC"
        Me.DataGridTextBoxColumn13.MappingName = "PAC_FECNAC"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "CARGA"
        Me.DataGridTextBoxColumn14.MappingName = "res_id"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 0
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
        Me.btn_Salir.Location = New System.Drawing.Point(310, 432)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 32)
        Me.btn_Salir.TabIndex = 2
        Me.btn_Salir.Text = "Guardar"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(226, 432)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(84, 32)
        Me.btn_Aceptar.TabIndex = 1
        Me.btn_Aceptar.Text = "Confirmar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(488, 25)
        Me.pan_barra.TabIndex = 93
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(9, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(198, 16)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "VALIDACION DE  RESULTADOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ordenMIS
        '
        Me.lbl_ordenMIS.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ordenMIS.Font = New System.Drawing.Font("C39HrP24DhTt", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ordenMIS.ForeColor = System.Drawing.Color.Black
        Me.lbl_ordenMIS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_ordenMIS.Location = New System.Drawing.Point(21, 65)
        Me.lbl_ordenMIS.Name = "lbl_ordenMIS"
        Me.lbl_ordenMIS.Size = New System.Drawing.Size(149, 59)
        Me.lbl_ordenMIS.TabIndex = 95
        Me.lbl_ordenMIS.Text = "CODIGO"
        Me.lbl_ordenMIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_CWeb
        '
        Me.btn_CWeb.BackColor = System.Drawing.SystemColors.Control
        Me.btn_CWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CWeb.ForeColor = System.Drawing.Color.Black
        Me.btn_CWeb.Image = CType(resources.GetObject("btn_CWeb.Image"), System.Drawing.Image)
        Me.btn_CWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CWeb.Location = New System.Drawing.Point(107, 432)
        Me.btn_CWeb.Name = "btn_CWeb"
        Me.btn_CWeb.Size = New System.Drawing.Size(119, 32)
        Me.btn_CWeb.TabIndex = 96
        Me.btn_CWeb.Text = "Confirmar y Web"
        Me.btn_CWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CWeb.UseVisualStyleBackColor = False
        '
        'lbl_paciente
        '
        Me.lbl_paciente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_paciente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.Location = New System.Drawing.Point(24, 32)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(352, 22)
        Me.lbl_paciente.TabIndex = 97
        Me.lbl_paciente.Text = "[PACIENTE]"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(390, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtp_fecha_valida
        '
        Me.dtp_fecha_valida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_valida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_valida.Location = New System.Drawing.Point(375, 379)
        Me.dtp_fecha_valida.Name = "dtp_fecha_valida"
        Me.dtp_fecha_valida.Size = New System.Drawing.Size(93, 21)
        Me.dtp_fecha_valida.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(150, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Los resultados se validaran con fecha:"
        '
        'pic_wait
        '
        Me.pic_wait.BackColor = System.Drawing.Color.Transparent
        Me.pic_wait.Image = CType(resources.GetObject("pic_wait.Image"), System.Drawing.Image)
        Me.pic_wait.Location = New System.Drawing.Point(400, 25)
        Me.pic_wait.Name = "pic_wait"
        Me.pic_wait.Size = New System.Drawing.Size(70, 65)
        Me.pic_wait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_wait.TabIndex = 101
        Me.pic_wait.TabStop = False
        Me.pic_wait.Visible = False
        '
        'pan_hist
        '
        Me.pan_hist.Controls.Add(Me.pic_rbc)
        Me.pan_hist.Controls.Add(Me.pic_wbc)
        Me.pan_hist.Controls.Add(Me.pic_plt)
        Me.pan_hist.Location = New System.Drawing.Point(29, 178)
        Me.pan_hist.Name = "pan_hist"
        Me.pan_hist.Size = New System.Drawing.Size(404, 86)
        Me.pan_hist.TabIndex = 189
        Me.pan_hist.Visible = False
        '
        'pic_rbc
        '
        Me.pic_rbc.BackColor = System.Drawing.Color.White
        Me.pic_rbc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_rbc.Location = New System.Drawing.Point(107, 3)
        Me.pic_rbc.Name = "pic_rbc"
        Me.pic_rbc.Size = New System.Drawing.Size(92, 77)
        Me.pic_rbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_rbc.TabIndex = 3
        Me.pic_rbc.TabStop = False
        Me.pic_rbc.Visible = False
        '
        'pic_wbc
        '
        Me.pic_wbc.BackColor = System.Drawing.Color.White
        Me.pic_wbc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_wbc.Location = New System.Drawing.Point(13, 3)
        Me.pic_wbc.Name = "pic_wbc"
        Me.pic_wbc.Size = New System.Drawing.Size(88, 77)
        Me.pic_wbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_wbc.TabIndex = 4
        Me.pic_wbc.TabStop = False
        Me.pic_wbc.Visible = False
        '
        'pic_plt
        '
        Me.pic_plt.BackColor = System.Drawing.Color.White
        Me.pic_plt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_plt.Location = New System.Drawing.Point(205, 3)
        Me.pic_plt.Name = "pic_plt"
        Me.pic_plt.Size = New System.Drawing.Size(94, 77)
        Me.pic_plt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_plt.TabIndex = 2
        Me.pic_plt.TabStop = False
        Me.pic_plt.Visible = False
        '
        'chk_enviarWeb
        '
        Me.chk_enviarWeb.AutoSize = True
        Me.chk_enviarWeb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_enviarWeb.Location = New System.Drawing.Point(23, 382)
        Me.chk_enviarWeb.Name = "chk_enviarWeb"
        Me.chk_enviarWeb.Size = New System.Drawing.Size(92, 17)
        Me.chk_enviarWeb.TabIndex = 190
        Me.chk_enviarWeb.Text = "Enviar acceso"
        Me.chk_enviarWeb.UseVisualStyleBackColor = True
        '
        'btn_enviarQR
        '
        Me.btn_enviarQR.BackColor = System.Drawing.SystemColors.Control
        Me.btn_enviarQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enviarQR.Enabled = False
        Me.btn_enviarQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviarQR.ForeColor = System.Drawing.Color.Black
        Me.btn_enviarQR.Image = CType(resources.GetObject("btn_enviarQR.Image"), System.Drawing.Image)
        Me.btn_enviarQR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enviarQR.Location = New System.Drawing.Point(25, 432)
        Me.btn_enviarQR.Name = "btn_enviarQR"
        Me.btn_enviarQR.Size = New System.Drawing.Size(53, 32)
        Me.btn_enviarQR.TabIndex = 191
        Me.btn_enviarQR.Text = "QR"
        Me.btn_enviarQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enviarQR.UseVisualStyleBackColor = False
        Me.btn_enviarQR.Visible = False
        '
        'Pic_QR
        '
        Me.Pic_QR.Location = New System.Drawing.Point(23, 402)
        Me.Pic_QR.Name = "Pic_QR"
        Me.Pic_QR.Size = New System.Drawing.Size(70, 62)
        Me.Pic_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_QR.TabIndex = 192
        Me.Pic_QR.TabStop = False
        '
        'txt_URL
        '
        Me.txt_URL.Enabled = False
        Me.txt_URL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_URL.Location = New System.Drawing.Point(23, 347)
        Me.txt_URL.Name = "txt_URL"
        Me.txt_URL.Size = New System.Drawing.Size(414, 21)
        Me.txt_URL.TabIndex = 193
        '
        'btn_clipUrl
        '
        Me.btn_clipUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clipUrl.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_clipUrl.Location = New System.Drawing.Point(443, 345)
        Me.btn_clipUrl.Name = "btn_clipUrl"
        Me.btn_clipUrl.Size = New System.Drawing.Size(21, 23)
        Me.btn_clipUrl.TabIndex = 194
        Me.btn_clipUrl.UseVisualStyleBackColor = True
        '
        'btn_ExpandeBloque
        '
        Me.btn_ExpandeBloque.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ExpandeBloque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ExpandeBloque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExpandeBloque.ForeColor = System.Drawing.Color.Black
        Me.btn_ExpandeBloque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExpandeBloque.Location = New System.Drawing.Point(363, 91)
        Me.btn_ExpandeBloque.Name = "btn_ExpandeBloque"
        Me.btn_ExpandeBloque.Size = New System.Drawing.Size(108, 28)
        Me.btn_ExpandeBloque.TabIndex = 197
        Me.btn_ExpandeBloque.Text = "Validar bloque >>>"
        Me.btn_ExpandeBloque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ExpandeBloque.UseVisualStyleBackColor = False
        Me.btn_ExpandeBloque.Visible = False
        '
        'cmb_ConvBloque
        '
        Me.cmb_ConvBloque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ConvBloque.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ConvBloque.ForeColor = System.Drawing.Color.Black
        Me.cmb_ConvBloque.Location = New System.Drawing.Point(631, 92)
        Me.cmb_ConvBloque.Name = "cmb_ConvBloque"
        Me.cmb_ConvBloque.Size = New System.Drawing.Size(126, 21)
        Me.cmb_ConvBloque.TabIndex = 198
        '
        'Dtp_ped_fecing
        '
        Me.Dtp_ped_fecing.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_ped_fecing.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ped_fecing.Location = New System.Drawing.Point(664, 65)
        Me.Dtp_ped_fecing.Name = "Dtp_ped_fecing"
        Me.Dtp_ped_fecing.Size = New System.Drawing.Size(93, 21)
        Me.Dtp_ped_fecing.TabIndex = 199
        '
        'btn_ValidaBloque
        '
        Me.btn_ValidaBloque.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ValidaBloque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ValidaBloque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ValidaBloque.ForeColor = System.Drawing.Color.Black
        Me.btn_ValidaBloque.Image = CType(resources.GetObject("btn_ValidaBloque.Image"), System.Drawing.Image)
        Me.btn_ValidaBloque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ValidaBloque.Location = New System.Drawing.Point(638, 380)
        Me.btn_ValidaBloque.Name = "btn_ValidaBloque"
        Me.btn_ValidaBloque.Size = New System.Drawing.Size(119, 32)
        Me.btn_ValidaBloque.TabIndex = 201
        Me.btn_ValidaBloque.Text = "Confirmar y Web"
        Me.btn_ValidaBloque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ValidaBloque.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(618, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(574, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 204
        Me.Label5.Text = "Convenio"
        '
        'lst_pedidos
        '
        Me.lst_pedidos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lst_pedidos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_pedidos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lst_pedidos.FormattingEnabled = True
        Me.lst_pedidos.Location = New System.Drawing.Point(487, 120)
        Me.lst_pedidos.Name = "lst_pedidos"
        Me.lst_pedidos.Size = New System.Drawing.Size(271, 251)
        Me.lst_pedidos.TabIndex = 205
        Me.lst_pedidos.TabStop = False
        '
        'cmb_FormatoPdf
        '
        Me.cmb_FormatoPdf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormatoPdf.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_FormatoPdf.FormattingEnabled = True
        Me.cmb_FormatoPdf.Items.AddRange(New Object() {"Por Area", "Continua"})
        Me.cmb_FormatoPdf.Location = New System.Drawing.Point(349, 405)
        Me.cmb_FormatoPdf.Name = "cmb_FormatoPdf"
        Me.cmb_FormatoPdf.Size = New System.Drawing.Size(121, 22)
        Me.cmb_FormatoPdf.TabIndex = 207
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(267, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Formato PDF"
        '
        'lbl_convenio
        '
        Me.lbl_convenio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_convenio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_convenio.Location = New System.Drawing.Point(202, 97)
        Me.lbl_convenio.Name = "lbl_convenio"
        Me.lbl_convenio.Size = New System.Drawing.Size(155, 18)
        Me.lbl_convenio.TabIndex = 209
        Me.lbl_convenio.Text = "(CONVENIO)"
        Me.lbl_convenio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_ValFinal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(488, 480)
        Me.Controls.Add(Me.lbl_convenio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_FormatoPdf)
        Me.Controls.Add(Me.lst_pedidos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_ConvBloque)
        Me.Controls.Add(Me.btn_ExpandeBloque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Dtp_ped_fecing)
        Me.Controls.Add(Me.btn_clipUrl)
        Me.Controls.Add(Me.btn_ValidaBloque)
        Me.Controls.Add(Me.dgrd_pedidos)
        Me.Controls.Add(Me.Pic_QR)
        Me.Controls.Add(Me.txt_URL)
        Me.Controls.Add(Me.btn_enviarQR)
        Me.Controls.Add(Me.chk_enviarWeb)
        Me.Controls.Add(Me.pan_hist)
        Me.Controls.Add(Me.pic_wait)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_fecha_valida)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.btn_CWeb)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.lbl_pedidoD)
        Me.Controls.Add(Me.lbl_pedido)
        Me.Controls.Add(Me.lbl_ordenMIS)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ValFinal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VALIDAR"
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.pic_wait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_hist.ResumeLayout(False)
        CType(Me.pic_rbc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_wbc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_plt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Codigo de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image



#End Region

    Dim opr_archivo As New Cls_Archivos()
    Dim opr_resul As New Cls_Resultado()
    Dim opr_pedido As New Cls_Pedido()
    Dim opr_usuario As New Cls_Usuario()
    Dim dtt_resPedido As New DataTable("Registros")
    Public res_mis As String = Nothing
    Public aareas As String = Nothing
    Public LabOcup As Byte
    Public Convenio As String
    Public frm_refer_main As Frm_Main
    Dim frm_refer_main_form As Frm_Main


    Private Sub frm_ValFinal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        Dim int_indice As Integer
        Dim repetir As String
        Dim aux(2) As String
        Dim STR_CAPTION As String() = {"tes_id", "tes_nombre", "PROCESADO", "OK", "ESTADO", "REMITIDO", "CARGA"}
        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        'frm_refer_main.Limpia_menu()
        'Me.Width = 492

        cmb_FormatoPdf.SelectedIndex = CInt(System.Configuration.ConfigurationSettings.AppSettings("FORMATO_PDF"))

        If g_SalidaWeb Then
            btn_CWeb.Enabled = True
            btn_Aceptar.Enabled = False
        Else
            btn_CWeb.Enabled = False
            btn_Aceptar.Enabled = True
        End If

        lbl_pedidoD.Text = ""
        lbl_pedidoD.Text = Me.Tag
        '*************************
        aux = Split(Me.Tag, ",")

        lbl_pedidoD.Text = aux(0).ToString()

        'opr_pedido.LlenarComboPrioridad(cmb_Conve, False, True)
        opr_pedido.LlenarComboPrioridad(cmb_ConvBloque, False, True)



        '*************************
        For int_indice = 0 To 3
            Dim dtc_columna As New DataColumn(STR_CAPTION(int_indice))
            dtt_resPedido.Columns.Add(dtc_columna)
        Next

        opr_resul.ValidarResultados(CInt(lbl_pedidoD.Text), dtt_resPedido, aareas, LabOcup)
        Dim dtv_test As New DataView(dtt_resPedido)
        dtv_test.AllowNew = False
        dgrd_pedidos.DataSource = dtv_test

        lbl_paciente.Text = dgrd_pedidos(0, 9).ToString()
        lbl_ordenMIS.Text = Mid(dgrd_pedidos(0, 8).ToString(), 4, 2) & Mid(dgrd_pedidos(0, 8).ToString(), 1, 2) & Format(CInt(dgrd_pedidos(0, 10).ToString()), "00000")
        lbl_convenio.Text = Convenio
        Me.txt_URL.Text = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR") & lbl_pedidoD.Text)

        Call qrcodeGen()


    End Sub


    Private Sub qrcodeGen()
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            'System.Configuration.ConfigurationSettings.AppSettings("PATHQR") 
            'Me.txt_URL.Text = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR"))
            Me.Pic_QR.Image = qrCode.Encode(Me.txt_URL.Text, System.Text.Encoding.UTF8)
            Me.Pic_QR.Image.Save(IO.Path.Combine(Environment.CurrentDirectory & "\" & (System.Configuration.ConfigurationSettings.AppSettings("QR")), lbl_pedidoD.Text & ".jpg"))

            'Call ConvierteBase64QR(System.Configuration.ConfigurationSettings.AppSettings("QR"), lbl_ordenMIS.Text, CLng(lbl_pedidoD.Text))
        Catch ex As Exception
            opr_pedido.VisualizaMensaje(ex.Message, 250)
            'MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub



    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click

        Try
            'MsgBox("LA ORDEN NO SE HA VALIDADO", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_pedido.VisualizaMensaje("Los resultados unicamente serán guardados ", 250)
            Dim ctl As Form
            Dim ctl2 As frm_ValidacionRes
            For Each ctl In frm_refer_main.MdiChildren
                If ctl.Name = "frm_ValidacionRes" Then
                    ctl2 = ctl
                    ctl2.Tag = "False"
                    ctl.Activate()
                End If
            Next
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        On Error GoTo errorMsgBox
        Dim i As Integer
        Dim j As Integer = 0
        'Dim opr_As400 As New Cls_AS400()
        'Dim ordenMIS As String = ""
        'Dim RES_MIS As String = ""

        Dim boo_procesado = True   'Variable para saber si tengo algun test no procesado aun
        Dim boo_repetir = False     'Variable para sasber si tengo algun test que repetir 
        Dim fecha As Date

        fecha = dtp_fecha_valida.Value

        For i = 0 To dtt_resPedido.Rows.Count - 1
            If (dgrd_pedidos(i, 4) = True) Then   'Si el test ha sido procesado
                If ((dgrd_pedidos(i, 6) <> 2) Or (dgrd_pedidos(i, 6) <> 9)) Then
                    If (dgrd_pedidos(i, 5) = False) Then      'Si no hay que repetir el test
                        opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 3)    'LISTO
                        If (dgrd_pedidos(i, 6) = 9) Then
                            opr_pedido.ActualizarLis_resEstado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 9, fecha)   'REMITIDO
                        End If
                        If (dgrd_pedidos(i, 6) = 1 Or dgrd_pedidos(i, 6) = 3) Then
                            opr_pedido.ActualizarLis_resEstado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 2, fecha)   'VALIDADO / EQUIPO
                            g_opr_usuario.CargarTransaccion(g_str_login, "VALIDACION RESULTADO", "PEDIDO=" & lbl_pedidoD.Text & "/" & dgrd_pedidos(i, 0), g_sng_user, lbl_pedidoD.Text, "", dgrd_pedidos(i, 0))
                        End If


                    Else    'Si hay que repetir un test procesado
                        boo_repetir = True
                        opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 0)    'REPETIR
                        opr_pedido.ActualizarLis_resEstado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 0, fecha)    'NO PROCESADO)
                        opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 0)   'En espera de ser asignado a una Lista T.

                        BorrarResultado(CInt(lbl_pedidoD.Text), CInt(dgrd_pedidos(i, 0)))  'Borro los resultados procesados   
                        opr_pedido.EliminarTesLista(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0))  'Elimino el test de la lista de trabajo 
                    End If
                End If
            Else  'Si el test no ha sido procesado 
                boo_procesado = False
            End If
        Next
        If (boo_procesado = True And boo_repetir = False) Then

            'MsgBox("En este pedido todas las pruebas de su(s) �rea(s) se encuentran validadas.", MsgBoxStyle.Information, "ANALISYS")
            If pedido_validado(CInt(lbl_pedidoD.Text)) = True Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 3)   'El pedido esta listo y procesado
            Else
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 5)   'El pedido esta solo con algunas pruebas validadas y se puede imprimir.
                'MsgBox("El pedido no se encuentra totalmente procesado", MsgBoxStyle.Information, "ANALISYS")
            End If
        Else
            opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 5)   'El pedido est� solo con algunas pruebas validadas
            'MsgBox("El pedido no se encuentra totalmente procesado", MsgBoxStyle.Information, "ANALISYS")
        End If
        Limpiarcampos()
        Me.Close()
        Exit Sub
errorMsgBox:
        Dim Frm_ANTES As frm_ValidacionRes
        Frm_ANTES.Tag = "False"
        Err.Clear()
    End Sub

    Public Function pedido_validado(ByVal ped_id As Integer) As Boolean
        'Funci�n para consultar si un pedido se encuentra totalmente validado
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select lis_resestado from lista_trabajo where ped_id = " & ped_id & "", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        pedido_validado = True
        oda_operacion.Fill(dts_area, "Registros")
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                pedido_validado = False
                Exit For
            Else
                If ((dtr_fila(0) <> 2) And (dtr_fila(0) <> 9)) Then
                    pedido_validado = False
                    Exit For
                End If
            End If
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, pedido_validado", Err)
        Err.Clear()
    End Function



    Public Sub BorrarResultado(ByVal ped_id As Integer, ByVal tes_id As Integer)
        On Error Resume Next
        Dim dts_pedido As DataSet
        Dim dts_tes As DataSet
        Dim opr_lista As New Cls_Trabajo()
        Dim dtr_fila As DataRow
        Dim dtr_fila2 As DataRow
        Dim equ_id As Integer
        Dim opr_tes As New Cls_Test()
        dts_pedido = opr_lista.LeerEquipo(ped_id, tes_id)
        For Each dtr_fila In dts_pedido.Tables("Registros").Rows
            equ_id = dtr_fila(0)
        Next
        dts_pedido.Clear()
        dts_tes = opr_pedido.tes_asociados(equ_id, tes_id)
        If (dts_tes.Tables(0).Rows.Count > 0) Then
            For Each dtr_fila2 In dts_tes.Tables("Registros").Rows
                opr_pedido.EliminarResTesPedido(ped_id, dtr_fila2(1))
            Next
        Else
            dts_tes.Clear()
            Dim abrev As String = ""
            dts_tes = opr_tes.LeerAbrevFija(tes_id, equ_id)
            For Each dtr_fila In dts_tes.Tables("Registros").Rows
                abrev = dtr_fila(0)
            Next
            opr_pedido.EliminarResTesPedido(ped_id, abrev)
        End If
    End Sub

    Private Sub Limpiarcampos()
        lbl_pedidoD.Text = ""
        dtt_resPedido.Clear()
    End Sub

    Private Sub btn_CWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CWeb.Click
        On Error GoTo errorMsgBox
        'WEB
        Dim opr_mail As New Cls_NetMail()
        Dim opr_encripta As New Cls_Encripta()
        Dim nombre As String()
        Dim var_correo As String = Nothing
        Dim opr_pac As New Cls_Paciente()
        Dim texto As String = Nothing
        Dim ParamCorreo As String()
        'WEB


        Dim i As Integer
        Dim j As Integer = 0
        'Dim opr_As400 As New Cls_AS400()
        Dim ordenMIS As String = ""
        Dim RES_MIS As String = ""

        Dim boo_procesado = True   'Variable para saber si tengo algun test no procesado aun
        Dim boo_repetir = False     'Variable para sasber si tengo algun test que repetir 
        Dim fecha As Date
        pic_wait.Visible = True
        fecha = dtp_fecha_valida.Value

        For i = 0 To dtt_resPedido.Rows.Count - 1
            If (dgrd_pedidos(i, 4) = True) Then   'Si el test ha sido procesado
                If ((dgrd_pedidos(i, 6) <> 2) Or (dgrd_pedidos(i, 6) <> 9)) Then
                    If (dgrd_pedidos(i, 5) = False) Then      'Si no hay que repetir el test
                        opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 3)    'LISTO
                        If (dgrd_pedidos(i, 6) = 9) Then
                            opr_pedido.ActualizarLis_resEstado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 9, fecha)   'REMITIDO
                        End If
                        If (dgrd_pedidos(i, 6) = 1 Or dgrd_pedidos(i, 6) = 3) Then
                            opr_pedido.ActualizarLis_resEstado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 2, fecha)   'VALIDADO / EQUIPO
                            g_opr_usuario.CargarTransaccion(g_str_login, "VALIDACION RESULTADO", "PEDIDO=" & lbl_pedidoD.Text & "/" & dgrd_pedidos(i, 0), g_sng_user, lbl_pedidoD.Text, "", dgrd_pedidos(i, 0))
                        End If


                    Else    'Si hay que repetir un test procesado
                        boo_repetir = True
                        opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 0)    'REPETIR
                        opr_pedido.ActualizarLis_resEstado(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0), 0, fecha)    'NO PROCESADO)
                        opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 0)   'En espera de ser asignado a una Lista T.

                        BorrarResultado(CInt(lbl_pedidoD.Text), CInt(dgrd_pedidos(i, 0)))  'Borro los resultados procesados   
                        opr_pedido.EliminarTesLista(CInt(lbl_pedidoD.Text), dgrd_pedidos(i, 0))  'Elimino el test de la lista de trabajo 
                    End If
                End If
            Else  'Si el test no ha sido procesado 
                boo_procesado = False

            End If
        Next
        If (boo_procesado = True And boo_repetir = False) Then

            'MsgBox("En este pedido todas las pruebas de su(s) area(s) se encuentran validadas.", MsgBoxStyle.Information, "ANALISYS")
            If pedido_validado(CInt(lbl_pedidoD.Text)) = True Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 3)   'El pedido esta listo y procesado
            Else
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 5)   'El pedido esta solo con algunas pruebas validadas y se puede imprimir.
                'MsgBox("El pedido no se encuentra totalmente procesado", MsgBoxStyle.Information, "ANALISYS")
            End If
        Else
            opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 5)   'El pedido esta solo con algunas pruebas validadas
            'MsgBox("El pedido no se encuentra totalmente procesado", MsgBoxStyle.Information, "ANALISYS")
        End If

        'opr_usuario.GuardarUsuario()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim dts_operacion As New DataSet()
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        Dim opr_resul As New Cls_Resultado()
        Dim opr_user As New Cls_Usuario()
        Dim opr_invitado As New Cls_Invitado()
        Dim opr_pdf As New Cls_ToPdf()
        Dim opr_paciente As New Cls_Paciente()

        Dim g_validador, g_validadorID As String

        Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
        Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)



        Dim numT As Integer = 0
        Dim DatosPedidos As String = Nothing
        Dim DatosPDFS As String = Nothing
        Dim OrdenFecha As String
        Dim nombrePdf As String = Nothing
        Dim Pdfs As String = Nothing
        Dim str_sql As String = Nothing
        Dim dts_histograma As New DataSet()
        Dim str_his As String = "NOHistograma"
        Dim str_img As String = "NOIMAGEN"

        Dim dts_imagen As New DataSet()


        Dim obj_reporte As New Object

        'Cargo grid con  valores resultadis + AB disponibles 
        Dim dts_operaAB As New DataSet()
        Dim dtt_resAB As New DataTable("RegistrosRESAB")
        Dim dtv_resAB As New DataView(dtt_resAB)
        Dim usu_login, usu_pass As String
        Dim pdf_examen As String = Nothing

        cls_operacion.sql_conectar()

        dts_operacion.Clear()

        OrdenFecha = Mid(dgrd_pedidos(0, 8).ToString(), 4, 2) & Mid(dgrd_pedidos(0, 8).ToString(), 1, 2) & Format(CInt(dgrd_pedidos(0, 10).ToString()), "00000")
        Pdfs = OrdenFecha & "-" & dgrd_pedidos(0, 9).ToString() & ".pdf"

        If LabOcup = 0 Then
            pdf_examen = "LABORATORIO"
        Else
            pdf_examen = ""
        End If

        ConvierteBase64QR(System.Configuration.ConfigurationSettings.AppSettings("QR"), lbl_ordenMIS.Text, CLng(lbl_pedidoD.Text))
        opr_pdf.EliminaQR(CLng(lbl_pedidoD.Text), System.Configuration.ConfigurationSettings.AppSettings("QR"))


        'AQUI GENERO EL QUERY CON LOS DATOS DE CADA PEDIDO
        str_sql = opr_pedido.devuelvePedidosBloqueVF(Me, lbl_pedidoD.Text, CDate(dgrd_pedidos(0, 15).ToString()), aareas, dts_histograma, dts_imagen)


        If dts_histograma.Tables.Count >= 1 Then
            str_his = "HISTOGRAMA"
        Else
            str_his = "NOHISTOGRAMA"
        End If

        'str_his = "NOHISTOGRAMA"


        If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
            On Error GoTo Imagen
            If dts_imagen.Tables.Count >= 1 Then
                str_img = "IMAGEN"
            Else
                str_img = "NOIMAGEN"
            End If
Imagen:
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

        End If

        dts_operacion.Merge(dts_operacion, False, System.Data.MissingSchemaAction.Ignore)

        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")


        'dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(OrdenFecha(i)), tes_padre)

        ''GUARDO EN TABLA AUX_HIS cuando tiene CONEXION HIS
        Dim str_sql_aux As String = Nothing
        Dim dtr_filaAux As DataRow

        opr_pedido.EliminarAuxHis(CInt(lbl_pedidoD.Text))
        For Each dtr_filaAux In dts_operacion.Tables("Registros").Rows
            str_sql_aux = "insert into AUX_HIS values('" & dtr_filaAux(23).ToString & "','" & dtr_filaAux(9).ToString & "', '" & dtr_filaAux(26).ToString & "','" & dtr_filaAux(18).ToString & "'," & CInt(dtr_filaAux(0).ToString) & ", '" & Trim(dtr_filaAux(8).ToString) & "','" & Trim(dtr_filaAux(28).ToString) & "','" & Trim(dtr_filaAux(10).ToString) & "','" & Trim(dtr_filaAux(2).ToString) & "','" & Trim(dtr_filaAux(13).ToString) & "','" & Trim(dtr_filaAux(4).ToString) & "','" & Trim(dtr_filaAux(7).ToString) & "','" & Trim(dtr_filaAux(13).ToString) & "','" & Trim(dtr_filaAux(14).ToString) & "','" & Trim(dtr_filaAux(21).ToString) & "','" & Trim(dtr_filaAux(27).ToString) & "',null)"
            '''opr_pedido.InsertaAuxHis(str_sql_aux)
        Next

        Select Case cmb_FormatoPdf.Text
            Case "Por Area"

                Select Case lbl_convenio.Text
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

            Case "Continua"
                Select Case lbl_convenio.Text
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

        End Select



        Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)

        For i = 0 To dtt_resPedido.Rows.Count - 1

            If dgrd_pedidos(i, 16) <> 1 Then
                If LabOcup = 0 Then
                    opr_archivo.IsFileOpen(Environment.CurrentDirectory & "\" & Pdfs & "\" & g_pathFolder)
                    opr_pdf.ExportToPDF(obj_reporte, Pdfs, g_pathFolder)
                    ConvierteBase64PDF(g_pathFolder, Pdfs, CLng(lbl_pedidoD.Text), pdf_examen)
                End If
            End If

        Next

        cls_operacion.sql_desconn()


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''ENVIO POR CORREO LAS CREDENCIALES PARA QUE PUEDA VER EN ANALISYSWEB CUANDO ES PACIENTE
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If chk_enviarWeb.Checked = True Then
            If dgrd_pedidos(0, 13).ToString() = 0 Or dgrd_pedidos(0, 13).ToString() = 1 Then

                If dgrd_pedidos(0, 11).ToString() = "" Then

                    If MsgBox("El paciente no tiene una direccion de correo valida, desea ingresarla este momento?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                        var_correo = InputBox("Ingrese la direccion de correo para: " & dgrd_pedidos(0, 9).ToString(), "ANALISYS")
                        opr_pac.ActualizarPacienteMail(dgrd_pedidos(0, 12).ToString(), Trim(var_correo))

                        nombre = Split(dgrd_pedidos(0, 9).ToString(), " ")
                        If UBound(nombre) = 1 Then
                            texto = opr_encripta.Genera_usr(nombre(1), nombre(0), usu_login, Trim(usu_pass))
                        Else
                            texto = opr_encripta.Genera_usr(nombre(2), nombre(0), usu_login, Trim(usu_pass))
                        End If

                        usu_pass = opr_paciente.Busca_usrWebCI(CInt(dgrd_pedidos(0, 12)))

                        If opr_pac.verifica_usrWeb(dgrd_pedidos(0, 12)) = Nothing Or opr_pac.verifica_usrWeb(dgrd_pedidos(0, 12)) = "" Then
                            opr_pac.Ingresa_UsrWeb(dgrd_pedidos(0, 12).ToString(), usu_login, usu_pass)
                            ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
                            opr_mail.EnviaCorreo(Trim(var_correo), "CREDENCIALES PACIENTE", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "", ParamCorreo(5))
                        Else
                            opr_pedido.VisualizaMensaje("El paciente si tiene credenciales vigentes para el acceso a ANALISYSWEB", 350)
                            'MsgBox("El paciente si tiene credenciales vigentes para el acceso a ANALISYSWEB", MsgBoxStyle.Information, "ANALISYS")
                        End If



                    Else
                        ''' ES EMPRESA, en este caso las credenciales fueron enviadas al momento de
                        ''' crear el CONVENIO, utilizando la direccion de correo ingresada en ese instante.
                    End If

                Else

                    nombre = Split(dgrd_pedidos(0, 9).ToString(), " ")
                    usu_pass = Trim(opr_paciente.Busca_usrWebCI(CInt(dgrd_pedidos(0, 12))))

                    If UBound(nombre) = 1 Then
                        texto = opr_encripta.Genera_usr(nombre(1), nombre(0), usu_login, usu_pass)
                    Else
                        texto = opr_encripta.Genera_usr(nombre(2), nombre(0), usu_login, usu_pass)

                    End If

                    'usu_pass = opr_paciente.Busca_usrWebCI(CInt(dgrd_pedidos(0, 12)))

                    var_correo = dgrd_pedidos(0, 11).ToString()
                    pic_wait.Visible = False
                    If opr_pac.verifica_usrWeb(CLng(dgrd_pedidos(0, 12).ToString())) <> "" Then
                        opr_pedido.VisualizaMensaje("El paciente tiene credenciales validas para el acceso a ANALISYSWEB", 350)
                        'MsgBox("El paciente tiene credenciales validas para el acceso a ANALISYSWEB", MsgBoxStyle.Information, "ANALISYS")
                    Else
                        opr_pac.Ingresa_UsrWeb(CLng(dgrd_pedidos(0, 12).ToString()), usu_login, usu_pass)
                        ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
                        opr_mail.EnviaCorreo(var_correo, "CREDENCIALES PACIENTE", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "", ParamCorreo(5))
                        opr_pedido.VisualizaMensaje("CREDENCIALES ENVIADAS CON EXITO", 350)
                    End If


                End If



            End If
        End If

        ' ''Dim MyValue As String = opr_pedido.LeerTelefono(CLng(dgrd_pedidos(0, 12).ToString()))

        ' ''If MyValue.Length = 10 Then
        ' ''    Dim wtexto As String = "*LABORATORIO CLÍNICO*" & " *" & g_Titulo & "*%0A%0A"
        ' ''    wtexto = wtexto & "*" & lbl_paciente.Text & "*%0A"

        ' ''    wtexto = wtexto & "Haga clic en el URL para descargar los resultados de sus exámenes" & "%0A%0A"
        ' ''    wtexto = wtexto & Trim(txt_URL.Text) & "%0A%0A"

        ' ''    wtexto = wtexto & "_Gracias por confiar en_" & " _" & g_Titulo & "_ " & "_No hay mejor incentivo que la satisfacción de nuestros pacientes" & "_%0A"

        ' ''    System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(MyValue, 2, 9) & "&text=" & wtexto)

        ' ''Else
        ' ''    opr_pedido.VisualizaMensaje("El número celular registrado no es correcto, favor revice en PACIENTES", 400)
        ' ''End If
        Limpiarcampos()
        Me.Close()
        Exit Sub
errorMsgBox:
        Dim Frm_ANTES As frm_ValidacionRes
        Frm_ANTES.Tag = "False"
        Err.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub ImprimeCredencialWeb(ByVal titulo As String, ByVal usu_login As String, ByVal usu_pass As String)
        Dim str_imprimir, str_codigo_barras As String
        Dim str_var As String = Nothing


        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
        If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
            Dim imp_archivo As FileStream = File.Create(str_imprimir)
            imp_archivo.Close()
        End If
        'abro un archivo para generar as lineas que me permitira imprimir un c�digo de barras
        FileOpen(1, str_imprimir, OpenMode.Output)

        'Dim int_aux, i As Integer
        Dim str_login As String = "USUARIO: " & usu_login
        Dim str_pass As String = "CONTRASEÑA: " & usu_pass
        Dim str_link As String = "LINK: " & System.Configuration.ConfigurationSettings.AppSettings("SITIO")
        Dim str_msg As String = vbCrLf & vbCrLf & System.Configuration.ConfigurationSettings.AppSettings("TITULO") & " agradece su visita" & vbCrLf & "Credenciales validas por 30 dias" & vbCrLf & "Powered by TRUESOLUTIONS 2019 - 0992715345"
        'linea obligatoria
        PrintLine(1, "")
        PrintLine(1, "N")
        'reseteo la impresora
        PrintLine(1, "OD")
        'tama�o horizontal
        PrintLine(1, "q456")
        'tama�o vertical

        PrintLine(1, "Q176,32+0")
        'PrintLine(1, "Q50,0+2") 'GCT

        'estas tres lineas son obligatorias son seteos de la impresora
        PrintLine(1, "S2") 'S= velocidad
        PrintLine(1, "D8")  'D = Densidad
        PrintLine(1, "ZT")  'Z = Orientaci�n de la impresi�n, T = desde el tope.

        'mando a escrribir en letras normales el primer 1 en la cadena de par�metros de el tama�o del encabezado
        PrintLine(1, "A100,30,0,1,2,1,N," & """'" & Trim(titulo) & "'""")

        'LOGIN
        PrintLine(1, "A100,60,0,1,1,1,N," & """" & str_login & """")

        'PASS
        PrintLine(1, "A100,75,0,1,1,1,N," & """" & str_pass & """")

        'LINK
        PrintLine(1, "A100,90,0,1,1,1,N," & """" & str_link & """")

        'MSG
        PrintLine(1, "A100,105,0,1,1,1,N," & """" & str_msg & """")



        PrintLine(1, "P1")

        'estas lineas son necesario para que la imrpesora regrese a su estado natura
        PrintLine(1, "")
        PrintLine(1, "OD")
        PrintLine(1, "q456")
        PrintLine(1, "Q176,32+0")
        PrintLine(1, "S2")
        PrintLine(1, "D8")
        PrintLine(1, "ZT")
        FileClose(1)
        'mando a copiar el archivo generado en el puerto designado
        On Error Resume Next

        str_var = System.Configuration.ConfigurationSettings.AppSettings("Puerto")


        FileCopy(str_imprimir, str_var)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Las Credenciales de acceso fueron impresas", MsgBoxStyle.Information, "ANALISYS")
        'opr_negocio.VisualizaMensaje("Etiquetas enviadas para impresi�n", g_tiempo)

    End Sub

    Public Sub ConvierteBase64PDF(ByVal path As String, ByVal nombrePDF As String, ByVal ped_id As Long, ByVal pdf_examen As String)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'Dim odc_pedido As New SqlCommand()
        Dim STR_SQL, STR_SQL2 As String
        Dim param As SqlParameter
        Dim beneficiosVida As Byte()
        Dim archivo As String = path & "\" & nombrePDF
        Dim pdf_orden As String = Trim(Mid(nombrePDF, 1, 9))

        beneficiosVida = File.ReadAllBytes(Environment.CurrentDirectory & "\" & archivo)

        opr_Conexion.sql_conectar()
        STR_SQL = "update ptopdf set pdf_base64 = @Content, pdf_orden = '" & pdf_orden & "'  where ped_id = " & ped_id & " and pdf_examen = '" & pdf_examen & "' "
        STR_SQL2 = "update aux_his set aux_ptopdf = @Content where aux_ped_id = " & ped_id & " "

        Dim cmd As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        cmd.Parameters.Add("@Content", SqlDbType.VarBinary).Value = beneficiosVida
        cmd.ExecuteNonQuery()

        Dim cmd2 As SqlCommand = New SqlCommand(STR_SQL2, opr_Conexion.conn_sql)
        cmd2.Parameters.Add("@Content", SqlDbType.VarBinary).Value = beneficiosVida
        cmd2.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar pdf", Err)
        Err.Clear()
    End Sub


    Public Function Base64ToImagePDF(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(Base64Code)
        'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
        Dim vFileName As String = Nothing

        If numorden <> "" Then

            NombreArchivo = nombre_tipo & numorden & ".pdf"

            If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
            vFileName = Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo

            'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

            If File.Exists(vFileName) Then
                File.Delete(vFileName)
            End If
            'diskOpts.DiskFileName = vFileName

            File.WriteAllBytes(vFileName, imageBytes)


            Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
            Dim tmpImage As Image = Image.FromStream(ms, True)
            'NombreArchivo = vFileName

            Return tmpImage
        End If
    End Function


    Private Sub btn_enviarQR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enviarQR.Click
        Dim pathQR As String = Nothing
        Dim OrdenFecha As String = Nothing
        Dim ImgQR As String = Nothing
        Try

            OrdenFecha = Mid(dgrd_pedidos(0, 8).ToString(), 4, 2) & Mid(dgrd_pedidos(0, 8).ToString(), 1, 2) & Format(CInt(dgrd_pedidos(0, 10).ToString()), "0000")
            ImgQR = OrdenFecha & "-" & dgrd_pedidos(0, 9).ToString() & ".jpg"

            pathQR = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR"))
            Call guardaimagen(pathQR, ImgQR)
        Catch ex As Exception
            opr_pedido.VisualizaMensaje(ex.Message, 250)
            'MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub guardaimagen(ByVal path As String, ByVal nombreImg As String)

        Dim vFileName As String = Nothing
        Try
            If Me.Pic_QR.Image IsNot Nothing Then

                If Dir(Environment.CurrentDirectory & "\" & path, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & path)
                vFileName = Environment.CurrentDirectory & "\" & path & "\" & Format(Now, "yy") & nombreImg

                If File.Exists(vFileName) Then
                    File.Delete(vFileName)
                End If

                Pic_QR.Image.Save(vFileName, ImageFormat.Jpeg)

            End If
        Catch ex As Exception
            opr_pedido.VisualizaMensaje(ex.Message, 250)
            'MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub ConvierteBase64QR(ByVal path As String, ByVal nombreFILE As String, ByVal ped_id As Long)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim param As SqlParameter
        Dim beneficiosVida As Byte()
        Dim archivo As String = path & "\" & ped_id & ".jpg"
        Dim img_orden As String = Format(Now, "yy") & Trim(Mid(nombreFILE, 1, 9))

        beneficiosVida = File.ReadAllBytes(Environment.CurrentDirectory & "\" & archivo)
        Dim base64String As String = Convert.ToBase64String(beneficiosVida, 0, beneficiosVida.Length)

        opr_Conexion.sql_conectar()
        STR_SQL = "update ptoimagen set img_base64 = '" & base64String & "', img_orden = '" & img_orden & "' where ped_id = " & ped_id & " and img_nombre = 'QR' "

        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar QR", Err)
        Err.Clear()

    End Sub




    Private Sub btn_clipUrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clipUrl.Click
        Clipboard.SetText(txt_URL.Text)
    End Sub

    Private Sub btn_ExpandeBloque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExpandeBloque.Click

        If btn_ExpandeBloque.Text = "Validar bloque >>>" Then
            Me.Width = 770
            Me.btn_ExpandeBloque.Text = "<<< Validar bloque"
            'actualizaConv()
        Else
            Me.Width = 487
            Me.btn_ExpandeBloque.Text = "Validar bloque >>>"
        End If

    End Sub


    'Private Sub actualizaConv()
    '    Dim convenio As String
    '    Dim dts_lista As New DataSet
    '    Dim opr_res As New Cls_Resultado()
    '    Dim area As Integer = 0




    '    convenio = Replace(cmb_Conve.Text, "/", ",")
    '    If convenio = "TODOS" Then
    '        convenio = "TODOS,0,0"
    '    End If

    '    lst_pedidos.Items.Clear()
    '    'dts_lista.Clear()

    '    dts_lista = opr_res.LlenaListPedidoConvenio(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", convenio, 0)

    'End Sub

    Private Sub btn_ValidaBloque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ValidaBloque.Click
        Dim numT As Integer = lst_pedidos.Items.Count
        Dim i As Integer
        Dim ped_id As String = Nothing
        Dim pedidos As String()

        For i = 0 To numT - 1
            ped_id = ped_id & Trim(Mid(lst_pedidos.Items.Item(i), 71, 5)) & ","
        Next

        pedidos = Split(ped_id, ",")

        If UBound(pedidos) > 0 Then
            For i = 0 To UBound(pedidos) - 1


            Next
        End If
        MsgBox("La validación se ha realizado de forma satisfactoria.", MsgBoxStyle.Information, "ANALISYS")

    End Sub

    
End Class
