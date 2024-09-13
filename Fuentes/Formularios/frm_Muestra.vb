'*************************************************************************
' Nombre:   frm_Muestra
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite manipular la impresion
'               de etiquetas de un determinado pedido
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Windows.Forms
Imports System.IO

Public Class frm_Muestra
    Inherits System.Windows.Forms.Form

#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents lst_pedidos As System.Windows.Forms.ListBox
    Friend WithEvents btn_dtpUp As System.Windows.Forms.Button
    Friend WithEvents btn_dtpDown As System.Windows.Forms.Button
    Friend WithEvents Dtp_ped_fecing As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgd_btn_Imp As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Conve As System.Windows.Forms.ComboBox
    Friend WithEvents chk_multiselec As System.Windows.Forms.CheckBox
    Friend WithEvents btn_imprimirBloque As System.Windows.Forms.Button
    Friend WithEvents lbl_Servicio As System.Windows.Forms.Label
    Dim imageToDraw As Image

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseMove
        ClickMenu_Principal(Me)
        'Funci�n para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
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

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseDown
        'Funci�n para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub



#End Region

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
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_muestra As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_barras As System.Windows.Forms.Label
    Friend WithEvents dgrd_muestra As System.Windows.Forms.DataGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_encabezado As System.Windows.Forms.Label
    Friend WithEvents cmb_muestra As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_turno As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmb_impBC As System.Windows.Forms.ComboBox
    Friend WithEvents chk_TipoCod As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Muestra))
        Me.dgrd_muestra = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dtgd_btn_Imp = New System.Windows.Forms.DataGridTextBoxColumn
        Me.chk_TipoCod = New System.Windows.Forms.CheckBox
        Me.lbl_turno = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_muestra = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_Servicio = New System.Windows.Forms.Label
        Me.lbl_tipo = New System.Windows.Forms.Label
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.lbl_nombres = New System.Windows.Forms.Label
        Me.lbl_encabezado = New System.Windows.Forms.Label
        Me.lbl_codigo_barras = New System.Windows.Forms.Label
        Me.lbl_pedido = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_impBC = New System.Windows.Forms.ComboBox
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.lbl_sexo = New System.Windows.Forms.Label
        Me.lst_pedidos = New System.Windows.Forms.ListBox
        Me.btn_dtpUp = New System.Windows.Forms.Button
        Me.btn_dtpDown = New System.Windows.Forms.Button
        Me.Dtp_ped_fecing = New System.Windows.Forms.DateTimePicker
        Me.pnl = New System.Windows.Forms.Panel
        Me.lbl_total = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_Conve = New System.Windows.Forms.ComboBox
        Me.chk_multiselec = New System.Windows.Forms.CheckBox
        Me.btn_imprimirBloque = New System.Windows.Forms.Button
        CType(Me.dgrd_muestra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrd_muestra
        '
        Me.dgrd_muestra.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_muestra.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_muestra.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_muestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_muestra.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_muestra.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_muestra.CaptionText = "MUESTRAS"
        Me.dgrd_muestra.DataMember = ""
        Me.dgrd_muestra.FlatMode = True
        Me.dgrd_muestra.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_muestra.ForeColor = System.Drawing.Color.Black
        Me.dgrd_muestra.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_muestra.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_muestra.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_muestra.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_muestra.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_muestra.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_muestra.Location = New System.Drawing.Point(334, 113)
        Me.dgrd_muestra.Name = "dgrd_muestra"
        Me.dgrd_muestra.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_muestra.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_muestra.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_muestra.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_muestra.Size = New System.Drawing.Size(269, 152)
        Me.dgrd_muestra.TabIndex = 0
        Me.dgrd_muestra.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_muestra
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.dtgd_btn_Imp})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "T. Muestra"
        Me.DataGridTextBoxColumn1.MappingName = "tit_nombre"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "###,##0;###,##0"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Cant."
        Me.DataGridTextBoxColumn2.MappingName = "pee_cantidad"
        Me.DataGridTextBoxColumn2.Width = 50
        '
        'dtgd_btn_Imp
        '
        Me.dtgd_btn_Imp.Format = ""
        Me.dtgd_btn_Imp.FormatInfo = Nothing
        Me.dtgd_btn_Imp.HeaderText = "IMPRIMIR"
        Me.dtgd_btn_Imp.MappingName = "IMPRIMIR"
        Me.dtgd_btn_Imp.NullText = "Imprimir"
        Me.dtgd_btn_Imp.ReadOnly = True
        Me.dtgd_btn_Imp.Width = 70
        '
        'chk_TipoCod
        '
        Me.chk_TipoCod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_TipoCod.ForeColor = System.Drawing.Color.Black
        Me.chk_TipoCod.Location = New System.Drawing.Point(504, 239)
        Me.chk_TipoCod.Name = "chk_TipoCod"
        Me.chk_TipoCod.Size = New System.Drawing.Size(77, 16)
        Me.chk_TipoCod.TabIndex = 109
        Me.chk_TipoCod.Text = "Cod 39"
        '
        'lbl_turno
        '
        Me.lbl_turno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_turno.ForeColor = System.Drawing.Color.Black
        Me.lbl_turno.Location = New System.Drawing.Point(94, 38)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(105, 19)
        Me.lbl_turno.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "TURNO:"
        '
        'cmb_muestra
        '
        Me.cmb_muestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_muestra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_muestra.Location = New System.Drawing.Point(343, 83)
        Me.cmb_muestra.Name = "cmb_muestra"
        Me.cmb_muestra.Size = New System.Drawing.Size(174, 21)
        Me.cmb_muestra.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_Servicio)
        Me.Panel1.Controls.Add(Me.lbl_tipo)
        Me.Panel1.Controls.Add(Me.lbl_doc)
        Me.Panel1.Controls.Add(Me.lbl_edad)
        Me.Panel1.Controls.Add(Me.lbl_fecha)
        Me.Panel1.Controls.Add(Me.lbl_nombres)
        Me.Panel1.Controls.Add(Me.lbl_encabezado)
        Me.Panel1.Controls.Add(Me.lbl_codigo_barras)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(338, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 138)
        Me.Panel1.TabIndex = 15
        '
        'lbl_Servicio
        '
        Me.lbl_Servicio.BackColor = System.Drawing.Color.White
        Me.lbl_Servicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Servicio.Location = New System.Drawing.Point(13, 118)
        Me.lbl_Servicio.Name = "lbl_Servicio"
        Me.lbl_Servicio.Size = New System.Drawing.Size(239, 16)
        Me.lbl_Servicio.TabIndex = 22
        Me.lbl_Servicio.Text = "SERVICIO"
        Me.lbl_Servicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tipo
        '
        Me.lbl_tipo.BackColor = System.Drawing.Color.White
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.Location = New System.Drawing.Point(190, 52)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(63, 18)
        Me.lbl_tipo.TabIndex = 21
        Me.lbl_tipo.Text = "TIPO"
        Me.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_doc
        '
        Me.lbl_doc.BackColor = System.Drawing.Color.White
        Me.lbl_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doc.Location = New System.Drawing.Point(12, 102)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(124, 16)
        Me.lbl_doc.TabIndex = 20
        Me.lbl_doc.Text = "CI"
        Me.lbl_doc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_edad
        '
        Me.lbl_edad.BackColor = System.Drawing.Color.White
        Me.lbl_edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.Location = New System.Drawing.Point(142, 102)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(110, 16)
        Me.lbl_edad.TabIndex = 19
        Me.lbl_edad.Text = "EDAD"
        Me.lbl_edad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.Color.White
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(13, 90)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(135, 15)
        Me.lbl_fecha.TabIndex = 18
        Me.lbl_fecha.Text = "FECHA"
        Me.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nombres
        '
        Me.lbl_nombres.BackColor = System.Drawing.Color.White
        Me.lbl_nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres.Location = New System.Drawing.Point(12, 20)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(224, 17)
        Me.lbl_nombres.TabIndex = 17
        Me.lbl_nombres.Text = "nombre"
        Me.lbl_nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_encabezado
        '
        Me.lbl_encabezado.BackColor = System.Drawing.Color.White
        Me.lbl_encabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_encabezado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_encabezado.Location = New System.Drawing.Point(0, 2)
        Me.lbl_encabezado.Name = "lbl_encabezado"
        Me.lbl_encabezado.Size = New System.Drawing.Size(254, 18)
        Me.lbl_encabezado.TabIndex = 16
        Me.lbl_encabezado.Text = "                   "
        Me.lbl_encabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_codigo_barras
        '
        Me.lbl_codigo_barras.BackColor = System.Drawing.Color.White
        Me.lbl_codigo_barras.Font = New System.Drawing.Font("C39HrP24DhTt", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_barras.Location = New System.Drawing.Point(16, 28)
        Me.lbl_codigo_barras.Name = "lbl_codigo_barras"
        Me.lbl_codigo_barras.Size = New System.Drawing.Size(185, 69)
        Me.lbl_codigo_barras.TabIndex = 15
        Me.lbl_codigo_barras.Text = "codigo"
        Me.lbl_codigo_barras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pedido
        '
        Me.lbl_pedido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.ForeColor = System.Drawing.Color.Black
        Me.lbl_pedido.Location = New System.Drawing.Point(94, 55)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(105, 20)
        Me.lbl_pedido.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PEDIDO:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(523, 81)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(69, 24)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.TabStop = False
        Me.btn_aceptar.Text = "Añadir"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(658, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Total : "
        Me.Label13.Visible = False
        '
        'cmb_impBC
        '
        Me.cmb_impBC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_impBC.Enabled = False
        Me.cmb_impBC.Location = New System.Drawing.Point(729, 332)
        Me.cmb_impBC.Name = "cmb_impBC"
        Me.cmb_impBC.Size = New System.Drawing.Size(121, 21)
        Me.cmb_impBC.TabIndex = 107
        Me.cmb_impBC.Visible = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(338, 428)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(120, 36)
        Me.btn_imprimir.TabIndex = 1
        Me.btn_imprimir.Text = "Imprimir ORDEN"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(464, 428)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(71, 36)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(940, 25)
        Me.pan_barra.TabIndex = 94
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(8, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(213, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "IMPRESION DE ETIQUETAS"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.Location = New System.Drawing.Point(777, 287)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(23, 14)
        Me.lbl_sexo.TabIndex = 21
        Me.lbl_sexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lst_pedidos
        '
        Me.lst_pedidos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lst_pedidos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_pedidos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lst_pedidos.FormattingEnabled = True
        Me.lst_pedidos.ItemHeight = 14
        Me.lst_pedidos.Location = New System.Drawing.Point(623, 121)
        Me.lst_pedidos.Name = "lst_pedidos"
        Me.lst_pedidos.Size = New System.Drawing.Size(296, 396)
        Me.lst_pedidos.TabIndex = 141
        '
        'btn_dtpUp
        '
        Me.btn_dtpUp.Location = New System.Drawing.Point(839, 71)
        Me.btn_dtpUp.Name = "btn_dtpUp"
        Me.btn_dtpUp.Size = New System.Drawing.Size(33, 23)
        Me.btn_dtpUp.TabIndex = 158
        Me.btn_dtpUp.Text = ">>"
        Me.btn_dtpUp.UseVisualStyleBackColor = True
        '
        'btn_dtpDown
        '
        Me.btn_dtpDown.Location = New System.Drawing.Point(683, 70)
        Me.btn_dtpDown.Name = "btn_dtpDown"
        Me.btn_dtpDown.Size = New System.Drawing.Size(33, 23)
        Me.btn_dtpDown.TabIndex = 157
        Me.btn_dtpDown.Text = "<<"
        Me.btn_dtpDown.UseVisualStyleBackColor = True
        '
        'Dtp_ped_fecing
        '
        Me.Dtp_ped_fecing.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ped_fecing.Location = New System.Drawing.Point(729, 71)
        Me.Dtp_ped_fecing.Name = "Dtp_ped_fecing"
        Me.Dtp_ped_fecing.Size = New System.Drawing.Size(97, 21)
        Me.Dtp_ped_fecing.TabIndex = 159
        '
        'pnl
        '
        Me.pnl.AutoScroll = True
        Me.pnl.BackColor = System.Drawing.Color.Transparent
        Me.pnl.Location = New System.Drawing.Point(29, 83)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(280, 428)
        Me.pnl.TabIndex = 161
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(550, 428)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(45, 13)
        Me.lbl_total.TabIndex = 162
        Me.lbl_total.Text = "lbl_total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(694, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "FILTRO CONVENIO"
        '
        'cmb_Conve
        '
        Me.cmb_Conve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Conve.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Conve.ForeColor = System.Drawing.Color.Black
        Me.cmb_Conve.Location = New System.Drawing.Point(794, 95)
        Me.cmb_Conve.Name = "cmb_Conve"
        Me.cmb_Conve.Size = New System.Drawing.Size(126, 21)
        Me.cmb_Conve.TabIndex = 194
        '
        'chk_multiselec
        '
        Me.chk_multiselec.AutoSize = True
        Me.chk_multiselec.Location = New System.Drawing.Point(679, 41)
        Me.chk_multiselec.Name = "chk_multiselec"
        Me.chk_multiselec.Size = New System.Drawing.Size(115, 17)
        Me.chk_multiselec.TabIndex = 196
        Me.chk_multiselec.Text = "MULTI SELECCION"
        Me.chk_multiselec.UseVisualStyleBackColor = True
        '
        'btn_imprimirBloque
        '
        Me.btn_imprimirBloque.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimirBloque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirBloque.Enabled = False
        Me.btn_imprimirBloque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirBloque.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirBloque.Image = CType(resources.GetObject("btn_imprimirBloque.Image"), System.Drawing.Image)
        Me.btn_imprimirBloque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirBloque.Location = New System.Drawing.Point(800, 32)
        Me.btn_imprimirBloque.Name = "btn_imprimirBloque"
        Me.btn_imprimirBloque.Size = New System.Drawing.Size(120, 33)
        Me.btn_imprimirBloque.TabIndex = 197
        Me.btn_imprimirBloque.Text = "Imprimir BLOQUE"
        Me.btn_imprimirBloque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirBloque.UseVisualStyleBackColor = False
        '
        'frm_Muestra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(940, 529)
        Me.Controls.Add(Me.btn_imprimirBloque)
        Me.Controls.Add(Me.chk_multiselec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_Conve)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgrd_muestra)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.chk_TipoCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dtp_ped_fecing)
        Me.Controls.Add(Me.lbl_pedido)
        Me.Controls.Add(Me.btn_dtpUp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_dtpDown)
        Me.Controls.Add(Me.lst_pedidos)
        Me.Controls.Add(Me.cmb_impBC)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.cmb_muestra)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Muestra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPRESION DE ETIQUETAS"
        CType(Me.dgrd_muestra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'declaracion de variables
    Dim str_nombre, str_apellido As String
    Private WithEvents dtt_muestras As New DataTable("Registros")
    Dim str_imprimir, str_codigo_barras As String
    Dim cont As Integer = 1
    Dim opr_muestra As New Cls_Muestra()
    Dim dts_lista As New DataSet
    Dim opr_res As New Cls_Resultado()
    Dim opr_pedido As New Cls_Pedido()
    Dim str_numAux As String = Nothing
    Dim str_Servicio As String = Nothing
    Dim recorrer As Integer = 0
    Dim presiona As String
    Dim i As Integer



    Sub CalcularCantidad()
        'recorro el grid y sumo la columna numera 2 del datagrid
        Dim int_indice As Integer = 0
        Dim int_cantidad As Integer = 0
        For int_indice = 0 To dtt_muestras.Rows.Count - 1
            If dtt_muestras.Rows(int_indice).Item(1).ToString = "" Then dtt_muestras.Rows(int_indice).Item(1) = 0
            int_cantidad = CInt(dtt_muestras.Rows(int_indice).Item(1)) + int_cantidad
        Next
        'despliego en le label el total
        lbl_total.Text = int_cantidad
    End Sub

    Public Sub llenar_cmb_impBC(ByRef cmb_impBC As ComboBox)
        Dim str_var As String
        cmb_impBC.Items.Clear()
        str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP")
        cmb_impBC.Items.Add(str_var)
        str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1")
        cmb_impBC.Items.Add(str_var)
        str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2")
        cmb_impBC.Items.Add(str_var)
        cmb_impBC.SelectedIndex = 0
    End Sub

    Sub inicia()
        On Error Resume Next

        AddHandler dtgd_btn_Imp.TextBox.Click, AddressOf VerClick

    End Sub


    Sub VerClick(ByVal Sender As Object, ByVal e As EventArgs)
        Try
            ''MsgBox("Imprimir " & dgrd_muestra.Item(dgrd_muestra.CurrentCell.RowNumber, 0))
            imprimeMuestra()

        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
        End Try

    End Sub

    Private Sub imprimeMuestra()
        On Error GoTo errores
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'pregunto si el total de equiquetas son mayores a 0
        If Val(dgrd_muestra.Item(dgrd_muestra.CurrentCell.RowNumber, 1)) > 0 Then
            'verifico en el app.config que modelo d codigo de barras
            'existe 2 opciones :
            'code 39
            'code 128
            str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
            str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
            If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
                Dim imp_archivo As FileStream = File.Create(str_imprimir)
                imp_archivo.Close()
            End If
            'abro un archivo para generar as lineas que me permitira imprimir un c�digo de barras
            FileOpen(1, str_imprimir, OpenMode.Output)
            Dim int_aux, i As Integer
            Dim str_cadena As String
            Dim str_servicio As String
            Dim TIPO_MUESTRA As Int64 'Variable para determinar el tipo de muestra a utilizar.
            For int_aux = 1 To Val(dgrd_muestra.Item(dgrd_muestra.CurrentCell.RowNumber, 1))
                'linea obligatoria
                PrintLine(1, "")
                PrintLine(1, "N")
                'reseteo la impresora
                PrintLine(1, "OD")
                'tama�o horizontal
                PrintLine(1, "q456")
                'tama�o vertical

                PrintLine(1, "Q199,40+0")
                'PrintLine(1, "Q50,0+0") 'GCT

                'estas tres lineas son obligatorias son seteos de la impresora
                PrintLine(1, "S2") 'S= velocidad
                PrintLine(1, "D8")  'D = Densidad
                PrintLine(1, "ZT")  'Z = Orientaci�n de la impresi�n, T = desde el tope.

                'mando a escrribir en letras normales el primer 1 en la cadena de par�metros de el tama�o del encabezado
                PrintLine(1, "A100,5,0,1,2,1,N," & """'" & g_Titulo & "'""")

                str_cadena = CInt(lbl_turno.Text)
                'PrintLine(1, "A15,122,3,3,1,2,R," & """" & str_cadena.ToString & """")


                'PrintLine(1, "A250,171,0,1,1,1,N," & """" & dtt_muestras.Rows(i).Item(0).ToString & """")
                str_cadena = Trim(dgrd_muestra.Item(dgrd_muestra.CurrentCell.RowNumber, 0).ToString)
                If Len(str_cadena) > 16 Then
                    str_cadena = str_cadena.Substring(0, 16)
                End If
                'ESCRIBE EL TIPO DE MUESTRA EN VERTICAL IZQUIERDA
                PrintLine(1, "A50,145,3,1,1,1,N," & """" & str_cadena & """")

                PrintLine(1, "A80,170,3,1,1,1,N," & """" & lbl_Servicio.Text & """")

                'FECHA DEL PDIDO
                PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")

                'CI + EDAD
                PrintLine(1, "A100,174,0,1,1,1,N," & """" & lbl_doc.Text & """")
                PrintLine(1, "A250,174,0,1,1,1,N," & """" & "EDAD: " & lbl_edad.Text & """")

                TIPO_MUESTRA = opr_muestra.selec_muestra(g_lng_ped_id, dgrd_muestra.Item(dgrd_muestra.CurrentCell.RowNumber, 0).ToString)
                If dtt_muestras.Rows(i).Item(1) <> 1 Then
                    If cont = dtt_muestras.Rows(i).Item(1) Then
                        i += 1
                        cont = 1
                    Else
                        cont += 1
                    End If
                Else
                    i += 1
                End If

                'str_cadena = Format(CInt(lbl_turno.Text), "0000") & "-" & TIPO_MUESTRA
                str_cadena = lbl_codigo_barras.Text & "-" & TIPO_MUESTRA

                'PrintLine(1, "B100,52,0,1,2,5,75,N," & """" & str_cadena & """")
                PrintLine(1, "B100,50,0,1,2,5,72,B," & """" & str_cadena & """")

                If Trim(lbl_tipo.Text) = "NORMAL" Then
                    PrintLine(1, "A380,150,3,1,1,1,N," & """" & Trim(lbl_tipo.Text) & """")
                    PrintLine(1, "A395,150,3,1,1,1,N," & """" & str_numAux & """")
                Else
                    PrintLine(1, "A380,150,3,1,1,1,N," & """" & Trim(lbl_tipo.Text) & """")
                    PrintLine(1, "A395,150,3,1,1,1,N," & """" & str_numAux & """")
                End If

                'finalmente mando a imprimir los datos del paciente
                str_cadena = str_apellido & " " & str_nombre '.Substring(0, 3)
                If Len(str_cadena) > 30 Then
                    str_cadena = str_cadena.Substring(0, 30)
                End If
                PrintLine(1, "A100,26,0,1,1,1,N," & """" & "(" & lbl_sexo.Text & ")-" & str_cadena.ToString & """")
                'PrintLine(1, "A15,171,0,1,1,1,N," & """" & str_cadena.ToString & """")



                'PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")
                'str_cadena = "HC: " & Format(CInt(lbl_histC.Text), "0000")
                'PrintLine(1, "A100,174,0,1,1,1,N," & """" & str_cadena.ToString & """")


                PrintLine(1, "P1")
            Next

            'estas lineas son necesario para que la imrpesora regrese a su estado natura
            PrintLine(1, "")
            PrintLine(1, "OD")
            PrintLine(1, "q456")
            PrintLine(1, "Q199,40+0")
            PrintLine(1, "S2")
            PrintLine(1, "D8")
            PrintLine(1, "ZT")
            FileClose(1)
            'mando a copiar el archivo generado en el puerto designado
            On Error Resume Next
            Dim str_var As String = cmb_impBC.Text
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
            End If
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
            End If
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
            End If
            FileCopy(str_imprimir, str_var)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("La etiqueta: " & Trim(dgrd_muestra.Item(dgrd_muestra.CurrentCell.RowNumber, 0)) & " fue impresa.", MsgBoxStyle.Information, "ANALISYS")
        Else
            'si existiese errores
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Seleccione al menos una muestra para imprimir.", MsgBoxStyle.Exclamation, "ANALISYS")
        End If
errores:

    End Sub

    Private Sub frm_Muestra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm

        inicia()
        lbl_encabezado.Text = g_Titulo
        dtt_muestras.DefaultView.AllowNew = False
        dtt_muestras.DefaultView.AllowDelete = False
        Dim dtc_columna1 As New DataColumn("tit_nombre", GetType(System.String))
        Dim dtc_columna2 As New DataColumn("pee_cantidad", GetType(System.Single))
        Dim dtc_columna3 As New DataColumn("IMPRIMIR", GetType(System.Single))
        dtt_muestras.Columns.Add(dtc_columna1)
        dtt_muestras.Columns.Add(dtc_columna2)
        dtt_muestras.Columns.Add(dtc_columna3)

        opr_muestra.LlenarComboMuestra(cmb_muestra)
        Call llenar_cmb_impBC(Me.cmb_impBC)

        opr_pedido.LlenarComboPrioridad(cmb_Conve, False, True)
        
        'lst_pedidos.SetSelected(0, True)

    End Sub

    Function LlenaDatosCB()
        Dim dtr_fila As DataRow
        Dim dts_muestra As DataSet
        Dim opr_paciente As New Cls_Paciente()
        Dim usafecnac As Integer
        Dim fechanac As Date
        Dim str_fecing As String
        Dim str_servicio As String

        Dim prefijo As String = ""

        dtt_muestras.Clear()

        lbl_pedido.Text = g_lng_ped_id
        lbl_turno.Text = g_numOrden

        prefijo = opr_muestra.LeerFechaPedido(g_lng_ped_id)

        If Month(prefijo) < 10 Then
            If Microsoft.VisualBasic.Day(prefijo) < 10 Then
                prefijo = "0" & Month(prefijo) & "0" & Microsoft.VisualBasic.Day(prefijo)

            Else
                prefijo = "0" & Month(prefijo) & Microsoft.VisualBasic.Day(prefijo)
            End If
        Else
            If Microsoft.VisualBasic.Day(prefijo) < 10 Then
                prefijo = Month(prefijo) & "0" & Microsoft.VisualBasic.Day(prefijo)
            Else
                prefijo = Month(prefijo) & Microsoft.VisualBasic.Day(prefijo)
            End If
        End If


        lbl_codigo_barras.Text = prefijo & Format(CInt(Mid(lbl_turno.Text, 5, 5)), "00000")
        prefijo = lbl_codigo_barras.Text


        'recupero en un dataset los datos del paciente d un determinado pedido
        dts_muestra = opr_paciente.LeerUnPaciente(g_lng_ped_id)

        recorrer = dts_muestra.Tables.Count

        For Each dtr_fila In dts_muestra.Tables("Registros").Rows
            str_apellido = dtr_fila(0).ToString
            str_nombre = dtr_fila(1).ToString
            lbl_fecha.Text = CDate(dtr_fila(2).ToString)
            lbl_sexo.Text = dtr_fila(3).ToString
            lbl_doc.Text = dtr_fila(4).ToString
            usafecnac = dtr_fila(6)
            fechanac = dtr_fila(7).ToString
            lbl_tipo.Text = dtr_fila(8).ToString
            str_fecing = Format(CDate(dtr_fila(2).ToString), "dd/MM/yyyy HH:mm:ss")
            str_numAux = dtr_fila(9).ToString
            lbl_Servicio.Text = dtr_fila(10).ToString
        Next

        If usafecnac = 1 Then
            lbl_edad.Text = opr_paciente.calcula_edad(CDate(fechanac))
        Else
            lbl_edad.Text = "ND"
        End If

        lbl_nombres.Text = "(" & lbl_sexo.Text & ") - " & str_apellido & " " & str_nombre
        'lleno el grid con las meustras de dicho pedido
        opr_muestra.LlenarGridMuestra(dgrd_muestra, dtt_muestras, g_lng_ped_id)
        'llena combo de las muestras para escojer otro tipode muestra

        'enveto par para el dataview
        'llamo al funcion para desplegar la cantidad de muestras
        Call CalcularCantidad()


    End Function

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro el formulario
        On Error Resume Next
        '' ''If Me.Tag = "pedido" Then
        '' ''    Dim frm_MDIChild As New frm_Pedido()
        '' ''    frm_MDIChild.MdiParent = Me.ParentForm
        '' ''    frm_MDIChild.Show()
        '' ''    Me.Close()
        '' ''ElseIf Me.Tag = "pedido1" Then
        '' ''    Me.Close()
        '' ''ElseIf Me.Tag = "pedido_modif" Then
        '' ''    Dim FrM_MDIChild As New frm_Pedido2()
        '' ''    FrM_MDIChild.frm_refer_main = Me.ParentForm
        '' ''    Me.Close()
        '' ''    FrM_MDIChild.ShowDialog(Me.ParentForm)
        '' ''Else
        '' ''    Dim frm_MDIChild As New frm_EtiquetaPedido()
        '' ''    frm_MDIChild.MdiParent = Me.ParentForm
        '' ''    frm_MDIChild.Show()
        '' ''    Me.Close()
        '' ''End If
        Me.Close()
        g_lng_ped_id = Nothing
        g_numOrden = Nothing
    End Sub

#Region "Imprime Codigo de barras"

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        'funcion para imprimir el la impresora de c�digo de barras
        'marca: ELTRON-ZEBRA
        'modelo: TLP 2742 - 2844
        'para la impresi�n se genera un modelo en el programa Create-A-label 3, donde luego de hacer el archivo
        'se escoje la opcion generar EPL,  genera un archivo con extension .ejf, donde encontraremos una serie
        'de lineas que son similares a las que encontramos en la parte de abajo



        On Error GoTo errores
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'pregunto si el total de equiquetas son mayores a 0
        If Val(lbl_total.Text) > 0 Then

            
            'verifico en el app.config que modelo d codigo de barras
            'existe 2 opciones :
            'code 39
            'code 128
            str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
            str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
            If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
                Dim imp_archivo As FileStream = File.Create(str_imprimir)
                imp_archivo.Close()
            End If
            'abro un archivo para generar as lineas que me permitira imprimir un c�digo de barras
            FileOpen(1, str_imprimir, OpenMode.Output)
            Dim int_aux, i As Integer
            Dim str_cadena As String
            Dim str_servicio As String
            Dim TIPO_MUESTRA As Int64 'Variable para determinar el tipo de muestra a utilizar.
            For int_aux = 0 To dtt_muestras.Rows.Count - 1

                If (dtt_muestras.Rows(int_aux).Item(1) > 0) Then
                    'linea obligatoria
                    PrintLine(1, "")
                    PrintLine(1, "N")
                    'reseteo la impresora
                    PrintLine(1, "OD")
                    'tamaño horizontal

                    PrintLine(1, "q456") ' 
                    'tamaño vertical
                    PrintLine(1, "Q199,30+0")
                    ' ''PrintLine(1, "Q176,32+0")'GCT


                    'estas tres lineas son obligatorias son seteos de la impresora
                    PrintLine(1, "S2") 'S= velocidad
                    PrintLine(1, "D8")  'D = Densidad
                    PrintLine(1, "ZT")  'Z = OrientaciOn de la impresiOn, T = desde el tope.

                    'mando a escrribir en letras normales el primer 1 en la cadena de parametros de el tamaño del encabezado
                    PrintLine(1, "A100,10,0,1,2,1,N," & """'" & g_Titulo & "'""")

                    str_cadena = CInt(lbl_turno.Text)
                    'PrintLine(1, "A15,122,3,3,1,2,R," & """" & str_cadena.ToString & """")


                    'PrintLine(1, "A250,171,0,1,1,1,N," & """" & dtt_muestras.Rows(i).Item(0).ToString & """")
                    str_cadena = Trim(dtt_muestras.Rows(int_aux).Item(0).ToString)
                    If Len(str_cadena) > 16 Then
                        str_cadena = str_cadena.Substring(0, 16)
                    End If
                    'ESCRIBE EL TIPO DE MUESTRA EN VERTICAL IZQUIERDA
                    PrintLine(1, "A50,145,3,1,1,1,N," & """" & str_cadena & """")

                    'ESCRIBE SERVICIO EN VERTICAL IZQUIERDA
                    PrintLine(1, "A80,170,3,1,1,1,N," & """" & lbl_Servicio.Text & """")

                    'PARA ETIQUETAS CLINICA MODERNA RIOBAMBA
                    'PrintLine(1, "A100,145,0,1,1,1,N," & """" & str_cadena & """")

                    'FECHA DEL PEDIDO
                    PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")

                    'CI + EDAD
                    PrintLine(1, "A100,174,0,1,1,1,N," & """" & Trim(lbl_doc.Text) & """")
                    PrintLine(1, "A240,174,0,1,1,1,N," & """" & "EDAD: " & lbl_edad.Text & """")



                    TIPO_MUESTRA = opr_muestra.selec_muestra(g_lng_ped_id, Trim(dtt_muestras.Rows(int_aux).Item(0).ToString))
                    If dtt_muestras.Rows(int_aux).Item(1) <> 1 Then
                        If cont = dtt_muestras.Rows(int_aux).Item(1) Then
                            i += 1
                            cont = 1
                        Else
                            cont += 1
                        End If
                    Else
                        i += 1
                    End If

                    'str_cadena = Format(CInt(lbl_turno.Text), "0000") & "-" & TIPO_MUESTRA
                    str_cadena = lbl_codigo_barras.Text & "-" & TIPO_MUESTRA

                    'PrintLine(1, "B100,52,0,1,2,5,75,N," & """" & str_cadena & """")
                    PrintLine(1, "B100,50,0,1,2,5,72,B," & """" & str_cadena & """")

                    If Trim(lbl_tipo.Text) = "NORMAL" Then
                        PrintLine(1, "A380,150,3,1,1,1,N," & """" & Trim(lbl_tipo.Text) & """")
                        PrintLine(1, "A395,150,3,1,1,1,N," & """" & str_numAux & """")
                    Else
                        PrintLine(1, "A380,150,3,1,1,1,N," & """" & Trim(lbl_tipo.Text) & """")
                        PrintLine(1, "A395,150,3,1,1,1,N," & """" & str_numAux & """")
                    End If

                    'finalmente mando a imprimir los datos del paciente
                    str_cadena = str_apellido & " " & str_nombre '.Substring(0, 3)
                    If Len(str_cadena) > 28 Then
                        str_cadena = str_cadena.Substring(0, 28)
                    End If
                    PrintLine(1, "A100,30,0,1,1,1,N," & """" & "(" & lbl_sexo.Text & ")-" & str_cadena.ToString & """")
                    'PrintLine(1, "A15,171,0,1,1,1,N," & """" & str_cadena.ToString & """")



                    'PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")
                    'str_cadena = "HC: " & Format(CInt(lbl_histC.Text), "0000")
                    'PrintLine(1, "A100,174,0,1,1,1,N," & """" & str_cadena.ToString & """")


                    PrintLine(1, "P1")
                End If
            Next

            'estas lineas son necesario para que la imrpesora regrese a su estado natura
            'GTC 420
            ' ''PrintLine(1, "")
            ' ''PrintLine(1, "OD")
            ' ''PrintLine(1, "q456")
            ' ''PrintLine(1, "Q176,32+0")
            ' ''PrintLine(1, "S2")
            ' ''PrintLine(1, "D8")
            ' ''PrintLine(1, "ZT")
            ' ''FileClose(1)

            PrintLine(1, "")
            PrintLine(1, "OD")
            PrintLine(1, "q456")
            PrintLine(1, "Q199,30+0")
            PrintLine(1, "S2")
            PrintLine(1, "D8")
            PrintLine(1, "ZT")
            FileClose(1)

            'mando a copiar el archivo generado en el puerto designado
            On Error Resume Next
            Dim str_var As String = cmb_impBC.Text
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
            End If
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
            End If
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
            End If
            FileCopy(str_imprimir, str_var)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Las Etiquetas fueron impresas", MsgBoxStyle.Information, "ANALISYS")
        Else
            'si existiese errores
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Debe seleccionar por lo menos una muestra", MsgBoxStyle.Exclamation, "ANALISYS")
        End If
        Exit Sub
errores:
        MsgBox("Error al imprimir, revise la impresora " & Err.Description & Err.Number, MsgBoxStyle.Exclamation, "ANALISYS")
    End Sub

#End Region

    Sub Selecciona_Celda()
        Dim dgc_celda As DataGridCell
        If dgrd_muestra.CurrentCell.ColumnNumber <> 1 Then
            dgc_celda.ColumnNumber = 3
            dgc_celda.RowNumber = dgrd_muestra.CurrentCell.RowNumber
            dgrd_muestra.CurrentCell = dgc_celda
        End If
        dgrd_muestra.Select(dgrd_muestra.CurrentCell.RowNumber)
    End Sub

    Private Sub dgrd_muestra_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_muestra.CurrentCellChanged
        'selecciono toda la fila del datagrid
        Selecciona_Celda()
    End Sub

    Private Sub dgrd_muestra_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_muestra.Enter
        'selecciono toda la fila del datagrid
        If dtt_muestras.Rows.Count > 0 Then
            Selecciona_Celda()
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        'si escogi otro tipo de muestra a sr imresa
        Dim int_indice As Integer = 0
        Dim sng_flag As Single = 0
        For int_indice = 0 To dtt_muestras.Rows.Count - 1
            If dtt_muestras.Rows(int_indice).Item(0).ToString = cmb_muestra.Text Then sng_flag = 1
        Next
        If sng_flag = 0 Then
            Dim dtr_fila As DataRow
            dtr_fila = dtt_muestras.NewRow
            dtr_fila(0) = cmb_muestra.Text
            dtr_fila(1) = 1
            dtt_muestras.Rows.Add(dtr_fila)
            Call CalcularCantidad()
        Else
            MsgBox("La muestra seleccionada no se pudo insertar, ya se encuentra en su lista reviselo", MsgBoxStyle.Information, "ANALISYS")
        End If
    End Sub



    Private Sub btn_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'si presiono click en boton facturar verifoc que no este abierta dicha pantalla
        If Not ExisteForm("Frm_Facura") Then
            Dim FrM_MDIChild As New Frm_Factura()
            FrM_MDIChild.MdiParent = frm_refer_main_form
            Me.Close()
            FrM_MDIChild.Tag = 1
            FrM_MDIChild.Show()
        End If
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

    Private Sub btn_imprimir_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'Dim str_sql As String
        'Dim obj_reporte As New rpt_pedido()
        'Dim frm_ref_main As Frm_Main = Me.ParentForm
        ''INSTRUCCION SQL QUE PERMITE OBTENER UN PEDIDO ESPECIFICO
        'str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba  from paciente, pedido, medico, laboratorio, pedido_detalle, perfil where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id  UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba  from paciente, pedido, medico, laboratorio, pedido_detalle,  test where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"
        'Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte)
        'frm_MDIChild.int_alto = frm_ref_main.mdiClient1.Height
        'frm_MDIChild.int_ancho = frm_ref_main.mdiClient1.Width
        'frm_MDIChild.Text = "Consulta de Pedido"
        'frm_ref_main.Crea_formulario(frm_MDIChild)
        'Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub RealizaCambios()
        dtt_muestras.AcceptChanges()
        Call CalcularCantidad()
    End Sub

    Private Sub btn_cancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If dtt_muestras.Rows.Count > 0 Then
            dtt_muestras.Rows(dgrd_muestra.CurrentCell.RowNumber).Delete()
            Call RealizaCambios()
        End If
    End Sub

    Private Sub CambiaCelda(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles dtt_muestras.ColumnChanged
        On Error Resume Next
        If dtt_muestras.Rows.Count > 0 Then
            Call RealizaCambios()
        End If
    End Sub



    Private Sub chk_TipoCod_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_TipoCod.CheckedChanged
        If chk_TipoCod.Checked = True Then
            MsgBox("Al cambiar la codificacion puede que los equipos de diagnostico no lean la etiqueta, esta seguro de realizar este cambio?", MsgBoxStyle.OkCancel, "ANALISYS")

        Else
            MsgBox("Al cambiar la codificacion puede que los equipos de diagnostico no lean la etiqueta, esta seguro de realizar este cambio?", MsgBoxStyle.OkCancel, "ANALISYS")
        End If
    End Sub




    Private Sub btn_dtpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dtpDown.Click
        If (Dtp_ped_fecing.Text <> "") Then
            Dtp_ped_fecing.Value = DateAdd(DateInterval.Day, -1, Dtp_ped_fecing.Value)
        End If
    End Sub

    Private Sub btn_dtpUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dtpUp.Click
        If (Dtp_ped_fecing.Text <> "") Then

            Dtp_ped_fecing.Value = DateAdd(DateInterval.Day, +1, Dtp_ped_fecing.Value)
        End If
    End Sub




    Private Sub lst_pedidos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_pedidos.KeyDown
        Dim pos As Integer = 0
        pos = lst_pedidos.SelectedIndex
        lst_pedidos.SelectedIndex = pos
        If pos >= 0 Then
            g_lng_ped_id = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_numOrden = dts_lista.Tables(0).Rows(pos).Item(1).ToString
            Call LlenaDatosCB()


        End If
        lst_pedidos.SelectedIndex = (pos)
    End Sub

    Private Sub lst_pedidos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_pedidos.KeyUp
        Dim pos As Integer = 0
        pos = lst_pedidos.SelectedIndex
        lst_pedidos.SelectedIndex = pos
        If pos >= 0 Then
            g_lng_ped_id = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_numOrden = dts_lista.Tables(0).Rows(pos).Item(1).ToString
            Call LlenaDatosCB()

        End If
        lst_pedidos.SelectedIndex = (pos)
    End Sub

    Private Sub Dtp_ped_fecing_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_ped_fecing.ValueChanged
        'If (Dtp_ped_fecing.Text <> "") Then
        '    lst_pedidos.Items.Clear()
        '    dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), 0, 0, "TODOS", g_str_unidad, 0)
        'End If
        If (Dtp_ped_fecing.Text <> "") Then
            'lst_pedidos.Items.Clear()
            'dts_lista.Clear()
            actualizaConv()
        End If
    End Sub

    Private Sub lst_pedidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_pedidos.SelectedIndexChanged
        Dim pos As Integer = 0
        pos = lst_pedidos.SelectedIndex
        lst_pedidos.SelectedIndex = pos
        If pos >= 0 Then
            g_lng_ped_id = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_numOrden = dts_lista.Tables(0).Rows(pos).Item(1).ToString
            Call LlenaDatosCB()
            Call EtiquetasPanel()
        End If
        lst_pedidos.SelectedIndex = (pos)
    End Sub


    Sub EtiquetasPanel()
        Dim i As Integer
        Dim topPnl As Integer = 10
        pnl.Controls.Clear()
        'dgrd_muestra.Item(i, 22)

        For i = 1 To dtt_muestras.Rows.Count
            Dim pnl_cb As New Panel()
            Dim lbl_lab As New Label()
            Dim lbl_paciente As New Label()
            Dim lbl_codigo As New Label()
            Dim lbl_fec As New Label()
            Dim lbl_ced As New Label()
            Dim lbl_eda As New Label()
            Dim lbl_recip As New Label()

            pnl_cb.Height = 110
            pnl_cb.Width = 210
            pnl_cb.Left = 40
            pnl_cb.Top = topPnl
            pnl_cb.BackColor = Color.White
            topPnl = topPnl + pnl_cb.Height + 10

            Dim MyFont As New Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Pixel)

            lbl_lab.BorderStyle = BorderStyle.FixedSingle
            lbl_lab.TextAlign = ContentAlignment.MiddleCenter
            lbl_lab.Text = lbl_encabezado.Text   'dtt_muestras.Rows(i).Item(1).ToString
            lbl_lab.Height = 12
            lbl_lab.Width = 210
            lbl_lab.Left = 0
            lbl_lab.Top = 0
            lbl_lab.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            'lbl_paciente.BorderStyle = BorderStyle.FixedSingle
            lbl_paciente.TextAlign = ContentAlignment.MiddleLeft
            lbl_paciente.Text = lbl_nombres.Text
            lbl_paciente.Height = 12
            lbl_paciente.Width = 210
            lbl_paciente.Left = 5
            lbl_paciente.Top = 13
            lbl_paciente.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            Dim MyFontCB As New Font("C39HrP24DhTt", 40, FontStyle.Regular, GraphicsUnit.Pixel)
            'lbl_codigo.BorderStyle = BorderStyle.FixedSingle
            lbl_encabezado.TextAlign = ContentAlignment.MiddleCenter
            lbl_codigo.Text = lbl_codigo_barras.Text
            lbl_codigo.Height = 40
            lbl_codigo.Width = 210
            lbl_codigo.Left = 20
            lbl_codigo.Top = 20
            lbl_codigo.Font = MyFontCB
            pnl.Controls.Add(pnl_cb)


            'lbl_fecha.BorderStyle = BorderStyle.FixedSingle
            lbl_fec.TextAlign = ContentAlignment.MiddleLeft
            lbl_fec.Text = lbl_fecha.Text
            lbl_fec.Height = 12
            lbl_fec.Width = 210
            lbl_fec.Left = 5
            lbl_fec.Top = 65
            lbl_fec.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            'lbl_cedula.BorderStyle = BorderStyle.FixedSingle
            lbl_ced.TextAlign = ContentAlignment.MiddleLeft
            lbl_ced.Text = lbl_doc.Text & "                                   " & lbl_edad.Text  'dgrd_muestra.Item(i, 0)
            lbl_ced.Height = 12
            lbl_ced.Width = 210
            lbl_ced.Left = 5
            lbl_ced.Top = 77
            lbl_ced.Font = MyFont
            pnl.Controls.Add(pnl_cb)


            lbl_eda.TextAlign = ContentAlignment.MiddleLeft
            lbl_eda.Text = lbl_Servicio.Text
            lbl_eda.Height = 12
            lbl_eda.Width = 210
            lbl_eda.Left = 5
            lbl_eda.Top = 89
            lbl_eda.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            lbl_recip.TextAlign = ContentAlignment.MiddleRight
            lbl_recip.Text = Trim(dtt_muestras.Rows(i - 1).Item(0).ToString)
            lbl_recip.Height = 12
            lbl_recip.Width = 205
            lbl_recip.Left = 5
            lbl_recip.Top = 101
            lbl_recip.Font = MyFont
            lbl_recip.ForeColor = System.Drawing.Color.Red
            pnl.Controls.Add(pnl_cb)

            
            'PANEL MAESTRO
            pnl_cb.Controls.Add(lbl_lab)
            pnl_cb.Controls.Add(lbl_paciente)
            pnl_cb.Controls.Add(lbl_codigo)
            pnl_cb.Controls.Add(lbl_fec)
            pnl_cb.Controls.Add(lbl_ced)
            pnl_cb.Controls.Add(lbl_eda)
            pnl_cb.Controls.Add(lbl_recip)


        Next

        'For i = 1 To dtt_muestras.Rows.Count
        '    'Creas el nuevo control (etiqueta en este ejemplo)
        '    Dim lbl_encabezado As New Label()

        '    Dim MyFont As New Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Pixel)
        '    'Defines sus propiedades
        '    lbl_encabezado.BorderStyle = BorderStyle.FixedSingle
        '    lbl_encabezado.Text = g_Titulo
        '    lbl_encabezado.Height = 90
        '    lbl_encabezado.Width = 12
        '    lbl_encabezado.Left = 10
        '    lbl_encabezado.Top = 1
        '    lbl_encabezado.Font = MyFont
        '    '& (i + 1) 
        '    pnl_cb & (i).Controls.Add(lbl_encabezado))

        'Next

        'New Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel)
        'Dim MyFontCB As New Font("C39HrP24DhTt", 36, FontStyle.Regular, GraphicsUnit.Pixel)

        ''Defines sus propiedades
        'lbl_codigo.BorderStyle = BorderStyle.FixedSingle
        'lbl_codigo.Text = lbl_codigo_barras.Text & " - " & i
        'lbl_codigo.Height = 70
        'lbl_codigo.Width = 200
        'lbl_codigo.Left = 20
        'lbl_codigo.Top = topCB
        'lbl_codigo.Font = MyFontCB

        'pnl.Controls.Add(lbl_nombre)


        'topCB = (lbl_codigo.Height * i) + (i * 10)
        'Next
    End Sub


  
    Private Sub cmb_Conve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Conve.SelectedIndexChanged
        actualizaConv()
    End Sub


    Private Sub actualizaConv()
        Dim convenio As String

        convenio = Replace(cmb_Conve.Text, "/", ",")
        
        lst_pedidos.Items.Clear()
        'dts_lista.Clear()
        dts_lista = opr_res.LlenaListPedidoConvenio(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), 0, 0, "TODOS", convenio, 0)

    End Sub

    Private Sub chk_multiselec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_multiselec.CheckedChanged
        If chk_multiselec.Checked Then
            Dim i As Short = 0
            For i = 0 To (lst_pedidos.Items.Count - 1)
                lst_pedidos.SetSelected(i, False)
            Next
            lst_pedidos.SelectionMode = SelectionMode.MultiExtended
            btn_imprimirBloque.Enabled = True
        Else
            lst_pedidos.SelectionMode = SelectionMode.One
            btn_imprimirBloque.Enabled = False
        End If
    End Sub

    Private Sub btn_imprimirBloque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirBloque.Click
        'ProgressBar1.Value = 0

        Dim opr_cod As New Cls_Pedido()
        Dim numT As Integer = lst_pedidos.Items.Count
        Dim i As Integer
        Dim incremento As Integer = 0
        Dim ped_id As String = Nothing
        Dim pedidos As String()

        For i = 0 To numT - 1
            If lst_pedidos.GetSelected(i) = True Then
                ped_id = ped_id & Trim(Mid(lst_pedidos.Items.Item(i), 71, 5)) & ","
            End If
        Next

        pedidos = Split(ped_id, ",")

        If UBound(pedidos) > 0 Then
            For i = 0 To UBound(pedidos) - 1
                opr_cod.imprimir_codigo(pedidos(i), Dtp_ped_fecing.Value)
                'ProgressBar1.Increment(incremento)
            Next
            MsgBox("La impresión de las etiquetas se ha realizado de forma satisfactoria.", MsgBoxStyle.Information, "ANALISYS")
            'Data.DataSource = Nothing
        End If

        incremento = 100 / UBound(Pedidos) - 1
        'ProgressBar1.Increment(incremento)

    End Sub


    
    
End Class