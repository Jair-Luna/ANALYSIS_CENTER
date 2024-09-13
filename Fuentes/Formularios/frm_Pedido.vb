'*************************************************************************
' Nombre:   frm_Pedido
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite crear pedidos
' Autores:  rfn
' Fecha de Creaci�n: 
' Ultima Modificaci�n: 15-ENE-2014
'*************************************************************************


Imports System.Math
Imports System.Data.SqlClient


Public Class frm_Pedido



    Inherits System.Windows.Forms.Form

    'funcion que verifica si una formulario esta abierto o no
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
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dtp_ped_fecing As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_medicacion As Ctl_txt.ctl_txt_letras
    Friend WithEvents cmb_medico As System.Windows.Forms.ComboBox
    Friend WithEvents txt_filtro_nombre As System.Windows.Forms.TextBox
    Friend WithEvents men_pedido As System.Windows.Forms.ContextMenu
    Friend WithEvents men_eliminar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents men_eliminar_todo As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_doc As Ctl_txt.ctl_txt_ci_ruc
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_convenio As System.Windows.Forms.ComboBox
    Friend WithEvents Grp_pedido As System.Windows.Forms.GroupBox
    Friend WithEvents btn_duplicado As System.Windows.Forms.Button
    Friend WithEvents ToolTipPedido As System.Windows.Forms.ToolTip
    Friend WithEvents rbtn_nombre As System.Windows.Forms.RadioButton
    Friend WithEvents btn_recibo As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents cmb_servicios As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_importar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbtn_codigo As System.Windows.Forms.RadioButton
    Friend WithEvents dgrd_pedido As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents grp_test As System.Windows.Forms.GroupBox
    Friend WithEvents Grp_paciente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_grado As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbl_fecing As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_his_clinica As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbl_grado1 As System.Windows.Forms.Label
    Friend WithEvents cmb_turno As System.Windows.Forms.Label
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents btn_nnuevo As System.Windows.Forms.Button
    Friend WithEvents btn_eeditar As System.Windows.Forms.Button
    Friend WithEvents btn_aanular As System.Windows.Forms.Button
    Friend WithEvents btn_cconvenio As System.Windows.Forms.Button
    Friend WithEvents btn_gguardar As System.Windows.Forms.Button
    Friend WithEvents btn_pproforma As System.Windows.Forms.Button
    Friend WithEvents btn_convertir As System.Windows.Forms.Button
    Friend WithEvents btn_ssalir As System.Windows.Forms.Button
    Friend WithEvents btn_ffactura As System.Windows.Forms.Button
    Friend WithEvents btn_eetiqueta As System.Windows.Forms.Button
    Friend WithEvents btn_dtpDown As System.Windows.Forms.Button
    Friend WithEvents btn_dtpUp As System.Windows.Forms.Button
    Friend WithEvents lbl_alertas As System.Windows.Forms.Label
    Friend WithEvents lbl_saldo As System.Windows.Forms.Label
    Friend WithEvents lbl_abono As System.Windows.Forms.Label
    Friend WithEvents lbl_fecnac As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_GLab As System.Windows.Forms.Button
    Friend WithEvents btn_GOdon As System.Windows.Forms.Button
    Friend WithEvents btn_SVitales As System.Windows.Forms.Button
    Friend WithEvents btn_GFarm As System.Windows.Forms.Button
    Friend WithEvents lbl_categoria As System.Windows.Forms.Label
    Friend WithEvents btn_GFisio As System.Windows.Forms.Button
    Friend WithEvents cmb_tratante As System.Windows.Forms.ComboBox
    Friend WithEvents btn_AAgendar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgrd_test As System.Windows.Forms.DataGrid
    Friend WithEvents lkl_pac_buscar As System.Windows.Forms.LinkLabel
    Friend WithEvents lkl_Dr_nuevo As System.Windows.Forms.LinkLabel
    Friend WithEvents cmb_laboratorio As System.Windows.Forms.ComboBox
    Friend WithEvents txt_recibo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbtn_pedido As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_InterfaceNombre As System.Windows.Forms.Label
    Friend WithEvents pic_interface As System.Windows.Forms.PictureBox
    Friend WithEvents txt_NumAux As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NumAux As System.Windows.Forms.Label
    Friend WithEvents lnk_Codigo As System.Windows.Forms.LinkLabel
    Friend WithEvents pic_historico As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrePost As System.Windows.Forms.ComboBox
    Friend WithEvents txt_obs_pac As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Conve As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lst_pedidos As System.Windows.Forms.ListBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_buscaOrden As System.Windows.Forms.Button
    Friend WithEvents btn_AccesoWeb As System.Windows.Forms.Button
    Friend WithEvents txt_filtro_medico As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmb_afiliacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion_fono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombres As System.Windows.Forms.TextBox
    Friend WithEvents lbl_genero As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fono As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btn_AccImpreso As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_ped_antecedente As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Cantidad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pedido))
        Me.Grp_pedido = New System.Windows.Forms.GroupBox
        Me.txt_filtro_medico = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_PrePost = New System.Windows.Forms.ComboBox
        Me.lbl_NumAux = New System.Windows.Forms.Label
        Me.lnk_Codigo = New System.Windows.Forms.LinkLabel
        Me.txt_NumAux = New System.Windows.Forms.TextBox
        Me.lkl_Dr_nuevo = New System.Windows.Forms.LinkLabel
        Me.cmb_servicios = New System.Windows.Forms.ComboBox
        Me.cmb_medico = New System.Windows.Forms.ComboBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txt_recibo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_convenio = New System.Windows.Forms.ComboBox
        Me.rbtn_pedido = New System.Windows.Forms.RadioButton
        Me.Ctl_txt_medicacion = New Ctl_txt.ctl_txt_letras
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmb_laboratorio = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Dtp_ped_fecing = New System.Windows.Forms.DateTimePicker
        Me.txt_filtro_nombre = New System.Windows.Forms.TextBox
        Me.men_pedido = New System.Windows.Forms.ContextMenu
        Me.men_eliminar = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.men_eliminar_todo = New System.Windows.Forms.MenuItem
        Me.lbl_total = New System.Windows.Forms.Label
        Me.Ctl_txt_doc = New Ctl_txt.ctl_txt_ci_ruc
        Me.ToolTipPedido = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_importar = New System.Windows.Forms.Button
        Me.btn_duplicado = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_recibo = New System.Windows.Forms.Button
        Me.rbtn_nombre = New System.Windows.Forms.RadioButton
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Label12 = New System.Windows.Forms.Label
        Me.rbtn_codigo = New System.Windows.Forms.RadioButton
        Me.dgrd_pedido = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.grp_test = New System.Windows.Forms.GroupBox
        Me.cmb_Cantidad = New System.Windows.Forms.ComboBox
        Me.lbl_categoria = New System.Windows.Forms.Label
        Me.lbl_InterfaceNombre = New System.Windows.Forms.Label
        Me.pic_interface = New System.Windows.Forms.PictureBox
        Me.cmb_tratante = New System.Windows.Forms.ComboBox
        Me.lbl_fecing = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_GFarm = New System.Windows.Forms.Button
        Me.btn_GOdon = New System.Windows.Forms.Button
        Me.btn_GLab = New System.Windows.Forms.Button
        Me.lbl_alertas = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.dgrd_test = New System.Windows.Forms.DataGrid
        Me.btn_GFisio = New System.Windows.Forms.Button
        Me.btn_SVitales = New System.Windows.Forms.Button
        Me.pic_historico = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_abono = New System.Windows.Forms.Label
        Me.lbl_saldo = New System.Windows.Forms.Label
        Me.btn_ffactura = New System.Windows.Forms.Button
        Me.Grp_paciente = New System.Windows.Forms.GroupBox
        Me.Ctl_txt_ped_antecedente = New System.Windows.Forms.TextBox
        Me.cmb_afiliacion = New System.Windows.Forms.ComboBox
        Me.txt_obs_pac = New System.Windows.Forms.TextBox
        Me.lbl_fono = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.lbl_nombres = New System.Windows.Forms.TextBox
        Me.lbl_genero = New System.Windows.Forms.TextBox
        Me.lbl_direccion_fono = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.lkl_pac_buscar = New System.Windows.Forms.LinkLabel
        Me.lbl_fecnac = New System.Windows.Forms.Label
        Me.txt_doc = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_his_clinica = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lbl_grado1 = New System.Windows.Forms.Label
        Me.cmb_turno = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.lbl_grado = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lst_pedidos = New System.Windows.Forms.ListBox
        Me.btn_nnuevo = New System.Windows.Forms.Button
        Me.btn_eeditar = New System.Windows.Forms.Button
        Me.btn_aanular = New System.Windows.Forms.Button
        Me.btn_cconvenio = New System.Windows.Forms.Button
        Me.btn_gguardar = New System.Windows.Forms.Button
        Me.btn_pproforma = New System.Windows.Forms.Button
        Me.btn_convertir = New System.Windows.Forms.Button
        Me.btn_ssalir = New System.Windows.Forms.Button
        Me.btn_eetiqueta = New System.Windows.Forms.Button
        Me.btn_dtpDown = New System.Windows.Forms.Button
        Me.btn_dtpUp = New System.Windows.Forms.Button
        Me.btn_AAgendar = New System.Windows.Forms.Button
        Me.cmb_Conve = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btn_buscaOrden = New System.Windows.Forms.Button
        Me.btn_AccesoWeb = New System.Windows.Forms.Button
        Me.btn_AccImpreso = New System.Windows.Forms.Button
        Me.Grp_pedido.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_test.SuspendLayout()
        CType(Me.pic_interface, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_test, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_historico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_paciente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grp_pedido
        '
        Me.Grp_pedido.BackColor = System.Drawing.Color.Transparent
        Me.Grp_pedido.Controls.Add(Me.txt_filtro_medico)
        Me.Grp_pedido.Controls.Add(Me.Label10)
        Me.Grp_pedido.Controls.Add(Me.cmb_PrePost)
        Me.Grp_pedido.Controls.Add(Me.lbl_NumAux)
        Me.Grp_pedido.Controls.Add(Me.lnk_Codigo)
        Me.Grp_pedido.Controls.Add(Me.txt_NumAux)
        Me.Grp_pedido.Controls.Add(Me.lkl_Dr_nuevo)
        Me.Grp_pedido.Controls.Add(Me.cmb_servicios)
        Me.Grp_pedido.Controls.Add(Me.cmb_medico)
        Me.Grp_pedido.Controls.Add(Me.PictureBox2)
        Me.Grp_pedido.Controls.Add(Me.txt_recibo)
        Me.Grp_pedido.Controls.Add(Me.Label22)
        Me.Grp_pedido.Controls.Add(Me.Label16)
        Me.Grp_pedido.Controls.Add(Me.Label9)
        Me.Grp_pedido.Controls.Add(Me.Label8)
        Me.Grp_pedido.Controls.Add(Me.Label2)
        Me.Grp_pedido.Controls.Add(Me.Label6)
        Me.Grp_pedido.Controls.Add(Me.cmb_convenio)
        Me.Grp_pedido.Controls.Add(Me.rbtn_pedido)
        Me.Grp_pedido.Controls.Add(Me.Ctl_txt_medicacion)
        Me.Grp_pedido.Enabled = False
        Me.Grp_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_pedido.ForeColor = System.Drawing.Color.Navy
        Me.Grp_pedido.Location = New System.Drawing.Point(8, 165)
        Me.Grp_pedido.Name = "Grp_pedido"
        Me.Grp_pedido.Size = New System.Drawing.Size(879, 74)
        Me.Grp_pedido.TabIndex = 1
        Me.Grp_pedido.TabStop = False
        '
        'txt_filtro_medico
        '
        Me.txt_filtro_medico.BackColor = System.Drawing.Color.PaleGreen
        Me.txt_filtro_medico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro_medico.Location = New System.Drawing.Point(696, 11)
        Me.txt_filtro_medico.Name = "txt_filtro_medico"
        Me.txt_filtro_medico.Size = New System.Drawing.Size(124, 21)
        Me.txt_filtro_medico.TabIndex = 165
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(62, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "DIALISIS"
        '
        'cmb_PrePost
        '
        Me.cmb_PrePost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PrePost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PrePost.Items.AddRange(New Object() {"NO APLICA", "PRE/POST", "PRE", "POST"})
        Me.cmb_PrePost.Location = New System.Drawing.Point(115, 36)
        Me.cmb_PrePost.Name = "cmb_PrePost"
        Me.cmb_PrePost.Size = New System.Drawing.Size(148, 21)
        Me.cmb_PrePost.TabIndex = 130
        '
        'lbl_NumAux
        '
        Me.lbl_NumAux.AutoSize = True
        Me.lbl_NumAux.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NumAux.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumAux.ForeColor = System.Drawing.Color.White
        Me.lbl_NumAux.Location = New System.Drawing.Point(510, 38)
        Me.lbl_NumAux.Name = "lbl_NumAux"
        Me.lbl_NumAux.Size = New System.Drawing.Size(47, 13)
        Me.lbl_NumAux.TabIndex = 130
        Me.lbl_NumAux.Text = "CUENTA"
        '
        'lnk_Codigo
        '
        Me.lnk_Codigo.AutoSize = True
        Me.lnk_Codigo.Enabled = False
        Me.lnk_Codigo.LinkColor = System.Drawing.Color.White
        Me.lnk_Codigo.Location = New System.Drawing.Point(822, 39)
        Me.lnk_Codigo.Name = "lnk_Codigo"
        Me.lnk_Codigo.Size = New System.Drawing.Size(45, 13)
        Me.lnk_Codigo.TabIndex = 131
        Me.lnk_Codigo.TabStop = True
        Me.lnk_Codigo.Text = "Codigo"
        '
        'txt_NumAux
        '
        Me.txt_NumAux.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_NumAux.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumAux.Location = New System.Drawing.Point(561, 38)
        Me.txt_NumAux.Name = "txt_NumAux"
        Me.txt_NumAux.ReadOnly = True
        Me.txt_NumAux.Size = New System.Drawing.Size(135, 15)
        Me.txt_NumAux.TabIndex = 129
        Me.txt_NumAux.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lkl_Dr_nuevo
        '
        Me.lkl_Dr_nuevo.AutoSize = True
        Me.lkl_Dr_nuevo.LinkColor = System.Drawing.Color.White
        Me.lkl_Dr_nuevo.Location = New System.Drawing.Point(824, 16)
        Me.lkl_Dr_nuevo.Name = "lkl_Dr_nuevo"
        Me.lkl_Dr_nuevo.Size = New System.Drawing.Size(42, 13)
        Me.lkl_Dr_nuevo.TabIndex = 129
        Me.lkl_Dr_nuevo.TabStop = True
        Me.lkl_Dr_nuevo.Text = "Nuevo"
        '
        'cmb_servicios
        '
        Me.cmb_servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_servicios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_servicios.ItemHeight = 13
        Me.cmb_servicios.Location = New System.Drawing.Point(318, 12)
        Me.cmb_servicios.Name = "cmb_servicios"
        Me.cmb_servicios.Size = New System.Drawing.Size(192, 21)
        Me.cmb_servicios.TabIndex = 3
        '
        'cmb_medico
        '
        Me.cmb_medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_medico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_medico.Location = New System.Drawing.Point(561, 11)
        Me.cmb_medico.Name = "cmb_medico"
        Me.cmb_medico.Size = New System.Drawing.Size(135, 21)
        Me.cmb_medico.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 117
        Me.PictureBox2.TabStop = False
        '
        'txt_recibo
        '
        Me.txt_recibo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_recibo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recibo.Items.AddRange(New Object() {"Matriz", "Sucursal"})
        Me.txt_recibo.Location = New System.Drawing.Point(318, 35)
        Me.txt_recibo.Name = "txt_recibo"
        Me.txt_recibo.Size = New System.Drawing.Size(192, 21)
        Me.txt_recibo.TabIndex = 116
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(270, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "ORIGEN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(263, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "SERVICIO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(54, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Diagnostico:"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(382, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Comentario:"
        Me.Label8.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(510, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "SOLICITA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(55, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "CONVENIO"
        '
        'cmb_convenio
        '
        Me.cmb_convenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_convenio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_convenio.Location = New System.Drawing.Point(115, 13)
        Me.cmb_convenio.Name = "cmb_convenio"
        Me.cmb_convenio.Size = New System.Drawing.Size(148, 21)
        Me.cmb_convenio.TabIndex = 7
        '
        'rbtn_pedido
        '
        Me.rbtn_pedido.Checked = True
        Me.rbtn_pedido.ForeColor = System.Drawing.Color.Black
        Me.rbtn_pedido.Location = New System.Drawing.Point(406, 39)
        Me.rbtn_pedido.Name = "rbtn_pedido"
        Me.rbtn_pedido.Size = New System.Drawing.Size(104, 18)
        Me.rbtn_pedido.TabIndex = 114
        Me.rbtn_pedido.TabStop = True
        Me.rbtn_pedido.Text = "Pedido"
        Me.rbtn_pedido.Visible = False
        '
        'Ctl_txt_medicacion
        '
        Me.Ctl_txt_medicacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_medicacion.Location = New System.Drawing.Point(382, 35)
        Me.Ctl_txt_medicacion.Name = "Ctl_txt_medicacion"
        Me.Ctl_txt_medicacion.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_medicacion.Prp_CaracterPasswd = ""
        Me.Ctl_txt_medicacion.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_medicacion.Size = New System.Drawing.Size(76, 21)
        Me.Ctl_txt_medicacion.TabIndex = 8
        Me.Ctl_txt_medicacion.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(270, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 13)
        Me.Label24.TabIndex = 166
        Me.Label24.Text = "OBSERVACION"
        '
        'cmb_laboratorio
        '
        Me.cmb_laboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_laboratorio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_laboratorio.Location = New System.Drawing.Point(628, 53)
        Me.cmb_laboratorio.Name = "cmb_laboratorio"
        Me.cmb_laboratorio.Size = New System.Drawing.Size(192, 21)
        Me.cmb_laboratorio.TabIndex = 6
        Me.cmb_laboratorio.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(542, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "LABORATORIO"
        Me.Label14.Visible = False
        '
        'Dtp_ped_fecing
        '
        Me.Dtp_ped_fecing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_ped_fecing.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ped_fecing.Location = New System.Drawing.Point(1020, 76)
        Me.Dtp_ped_fecing.Name = "Dtp_ped_fecing"
        Me.Dtp_ped_fecing.Size = New System.Drawing.Size(96, 20)
        Me.Dtp_ped_fecing.TabIndex = 0
        Me.Dtp_ped_fecing.Value = New Date(2020, 7, 1, 0, 0, 0, 0)
        '
        'txt_filtro_nombre
        '
        Me.txt_filtro_nombre.BackColor = System.Drawing.Color.PaleGreen
        Me.txt_filtro_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro_nombre.Location = New System.Drawing.Point(7, 15)
        Me.txt_filtro_nombre.Name = "txt_filtro_nombre"
        Me.txt_filtro_nombre.Size = New System.Drawing.Size(453, 21)
        Me.txt_filtro_nombre.TabIndex = 12
        '
        'men_pedido
        '
        Me.men_pedido.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.men_eliminar, Me.MenuItem2, Me.men_eliminar_todo})
        '
        'men_eliminar
        '
        Me.men_eliminar.Index = 0
        Me.men_eliminar.Text = "Eliminar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'men_eliminar_todo
        '
        Me.men_eliminar_todo.Index = 2
        Me.men_eliminar_todo.Text = "Eliminar todo"
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Black
        Me.lbl_total.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_total.Location = New System.Drawing.Point(124, 12)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(189, 50)
        Me.lbl_total.TabIndex = 101
        Me.lbl_total.Text = "0"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Ctl_txt_doc
        '
        Me.Ctl_txt_doc.Enabled = False
        Me.Ctl_txt_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_doc.Location = New System.Drawing.Point(101, 28)
        Me.Ctl_txt_doc.Name = "Ctl_txt_doc"
        Me.Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
        Me.Ctl_txt_doc.Size = New System.Drawing.Size(132, 20)
        Me.Ctl_txt_doc.TabIndex = 1
        '
        'btn_importar
        '
        Me.btn_importar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_importar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_importar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_importar.ForeColor = System.Drawing.Color.Black
        Me.btn_importar.Image = CType(resources.GetObject("btn_importar.Image"), System.Drawing.Image)
        Me.btn_importar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_importar.Location = New System.Drawing.Point(306, 491)
        Me.btn_importar.Name = "btn_importar"
        Me.btn_importar.Size = New System.Drawing.Size(80, 24)
        Me.btn_importar.TabIndex = 111
        Me.btn_importar.Text = "Importar"
        Me.btn_importar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipPedido.SetToolTip(Me.btn_importar, "Duplicar un pedido")
        Me.btn_importar.UseVisualStyleBackColor = False
        Me.btn_importar.Visible = False
        '
        'btn_duplicado
        '
        Me.btn_duplicado.BackColor = System.Drawing.SystemColors.Control
        Me.btn_duplicado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_duplicado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_duplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_duplicado.ForeColor = System.Drawing.Color.Black
        Me.btn_duplicado.Image = CType(resources.GetObject("btn_duplicado.Image"), System.Drawing.Image)
        Me.btn_duplicado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_duplicado.Location = New System.Drawing.Point(210, 491)
        Me.btn_duplicado.Name = "btn_duplicado"
        Me.btn_duplicado.Size = New System.Drawing.Size(80, 24)
        Me.btn_duplicado.TabIndex = 8
        Me.btn_duplicado.Text = "Duplicar"
        Me.btn_duplicado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipPedido.SetToolTip(Me.btn_duplicado, "Duplicar un pedido")
        Me.btn_duplicado.UseVisualStyleBackColor = False
        Me.btn_duplicado.Visible = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(229, 491)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 24)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipPedido.SetToolTip(Me.btn_nuevo, "Ingresar un nuevo pedido")
        Me.btn_nuevo.UseVisualStyleBackColor = False
        Me.btn_nuevo.Visible = False
        '
        'btn_recibo
        '
        Me.btn_recibo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_recibo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_recibo.Enabled = False
        Me.btn_recibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_recibo.ForeColor = System.Drawing.Color.Black
        Me.btn_recibo.Image = CType(resources.GetObject("btn_recibo.Image"), System.Drawing.Image)
        Me.btn_recibo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_recibo.Location = New System.Drawing.Point(198, 514)
        Me.btn_recibo.Name = "btn_recibo"
        Me.btn_recibo.Size = New System.Drawing.Size(80, 24)
        Me.btn_recibo.TabIndex = 109
        Me.btn_recibo.Text = "Recibo"
        Me.btn_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipPedido.SetToolTip(Me.btn_recibo, "Ingresar un nuevo pedido")
        Me.btn_recibo.UseVisualStyleBackColor = False
        Me.btn_recibo.Visible = False
        '
        'rbtn_nombre
        '
        Me.rbtn_nombre.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_nombre.Checked = True
        Me.rbtn_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_nombre.Location = New System.Drawing.Point(704, 138)
        Me.rbtn_nombre.Name = "rbtn_nombre"
        Me.rbtn_nombre.Size = New System.Drawing.Size(105, 18)
        Me.rbtn_nombre.TabIndex = 10
        Me.rbtn_nombre.TabStop = True
        Me.rbtn_nombre.Text = "Nombre Test"
        Me.rbtn_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_nombre.UseVisualStyleBackColor = False
        Me.rbtn_nombre.Visible = False
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
        Me.PrintDocument1.DocumentName = "RECIBO"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(899, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "  "
        '
        'rbtn_codigo
        '
        Me.rbtn_codigo.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_codigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_codigo.Location = New System.Drawing.Point(616, 138)
        Me.rbtn_codigo.Name = "rbtn_codigo"
        Me.rbtn_codigo.Size = New System.Drawing.Size(82, 18)
        Me.rbtn_codigo.TabIndex = 11
        Me.rbtn_codigo.Text = "C�digo Test"
        Me.rbtn_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_codigo.UseVisualStyleBackColor = False
        Me.rbtn_codigo.Visible = False
        '
        'dgrd_pedido
        '
        Me.dgrd_pedido.AllowDrop = True
        Me.dgrd_pedido.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_pedido.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_pedido.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgrd_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_pedido.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_pedido.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgrd_pedido.CaptionText = "ORDEN"
        Me.dgrd_pedido.CaptionVisible = False
        Me.dgrd_pedido.CausesValidation = False
        Me.dgrd_pedido.ContextMenu = Me.men_pedido
        Me.dgrd_pedido.DataMember = ""
        Me.dgrd_pedido.FlatMode = True
        Me.dgrd_pedido.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.dgrd_pedido.ForeColor = System.Drawing.Color.Black
        Me.dgrd_pedido.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_pedido.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_pedido.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedido.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_pedido.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_pedido.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedido.Location = New System.Drawing.Point(13, 284)
        Me.dgrd_pedido.Name = "dgrd_pedido"
        Me.dgrd_pedido.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_pedido.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_pedido.ReadOnly = True
        Me.dgrd_pedido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgrd_pedido.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_pedido.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_pedido.Size = New System.Drawing.Size(864, 332)
        Me.dgrd_pedido.TabIndex = 124
        Me.dgrd_pedido.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle2.DataGrid = Me.dgrd_pedido
        Me.DataGridTableStyle2.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGridTableStyle2.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle2.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle2.MappingName = "Registros"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.Yellow
        Me.DataGridTableStyle2.SelectionForeColor = System.Drawing.Color.Black
        '
        'grp_test
        '
        Me.grp_test.BackColor = System.Drawing.Color.Transparent
        Me.grp_test.Controls.Add(Me.cmb_Cantidad)
        Me.grp_test.Controls.Add(Me.lbl_categoria)
        Me.grp_test.Controls.Add(Me.lbl_InterfaceNombre)
        Me.grp_test.Controls.Add(Me.pic_interface)
        Me.grp_test.Controls.Add(Me.cmb_tratante)
        Me.grp_test.Controls.Add(Me.lbl_fecing)
        Me.grp_test.Controls.Add(Me.Label7)
        Me.grp_test.Controls.Add(Me.btn_GFarm)
        Me.grp_test.Controls.Add(Me.btn_GOdon)
        Me.grp_test.Controls.Add(Me.btn_GLab)
        Me.grp_test.Controls.Add(Me.lbl_alertas)
        Me.grp_test.Controls.Add(Me.Label20)
        Me.grp_test.Controls.Add(Me.txt_filtro_nombre)
        Me.grp_test.Controls.Add(Me.rbtn_codigo)
        Me.grp_test.Controls.Add(Me.rbtn_nombre)
        Me.grp_test.Controls.Add(Me.dgrd_test)
        Me.grp_test.Controls.Add(Me.btn_GFisio)
        Me.grp_test.Controls.Add(Me.Label14)
        Me.grp_test.Controls.Add(Me.cmb_laboratorio)
        Me.grp_test.Location = New System.Drawing.Point(7, 245)
        Me.grp_test.Name = "grp_test"
        Me.grp_test.Size = New System.Drawing.Size(880, 377)
        Me.grp_test.TabIndex = 126
        Me.grp_test.TabStop = False
        '
        'cmb_Cantidad
        '
        Me.cmb_Cantidad.BackColor = System.Drawing.Color.Silver
        Me.cmb_Cantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmb_Cantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_Cantidad.FormattingEnabled = True
        Me.cmb_Cantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmb_Cantidad.Location = New System.Drawing.Point(465, 15)
        Me.cmb_Cantidad.Name = "cmb_Cantidad"
        Me.cmb_Cantidad.Size = New System.Drawing.Size(19, 21)
        Me.cmb_Cantidad.TabIndex = 165
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.ForeColor = System.Drawing.Color.White
        Me.lbl_categoria.Location = New System.Drawing.Point(694, 11)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(139, 24)
        Me.lbl_categoria.TabIndex = 160
        Me.lbl_categoria.Text = "CATEGORIA"
        Me.lbl_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_InterfaceNombre
        '
        Me.lbl_InterfaceNombre.AutoSize = True
        Me.lbl_InterfaceNombre.Location = New System.Drawing.Point(807, 19)
        Me.lbl_InterfaceNombre.Name = "lbl_InterfaceNombre"
        Me.lbl_InterfaceNombre.Size = New System.Drawing.Size(0, 13)
        Me.lbl_InterfaceNombre.TabIndex = 164
        '
        'pic_interface
        '
        Me.pic_interface.Image = CType(resources.GetObject("pic_interface.Image"), System.Drawing.Image)
        Me.pic_interface.Location = New System.Drawing.Point(853, 19)
        Me.pic_interface.Name = "pic_interface"
        Me.pic_interface.Size = New System.Drawing.Size(18, 18)
        Me.pic_interface.TabIndex = 163
        Me.pic_interface.TabStop = False
        Me.pic_interface.Visible = False
        '
        'cmb_tratante
        '
        Me.cmb_tratante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tratante.Enabled = False
        Me.cmb_tratante.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tratante.Location = New System.Drawing.Point(650, 68)
        Me.cmb_tratante.Name = "cmb_tratante"
        Me.cmb_tratante.Size = New System.Drawing.Size(176, 21)
        Me.cmb_tratante.TabIndex = 118
        '
        'lbl_fecing
        '
        Me.lbl_fecing.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_fecing.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecing.Location = New System.Drawing.Point(725, 159)
        Me.lbl_fecing.Name = "lbl_fecing"
        Me.lbl_fecing.Size = New System.Drawing.Size(74, 16)
        Me.lbl_fecing.TabIndex = 117
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(546, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "MEDICO TRATANTE"
        '
        'btn_GFarm
        '
        Me.btn_GFarm.BackColor = System.Drawing.Color.White
        Me.btn_GFarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_GFarm.Enabled = False
        Me.btn_GFarm.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GFarm.Image = CType(resources.GetObject("btn_GFarm.Image"), System.Drawing.Image)
        Me.btn_GFarm.Location = New System.Drawing.Point(238, 53)
        Me.btn_GFarm.Name = "btn_GFarm"
        Me.btn_GFarm.Size = New System.Drawing.Size(56, 50)
        Me.btn_GFarm.TabIndex = 159
        Me.btn_GFarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GFarm.UseVisualStyleBackColor = False
        Me.btn_GFarm.Visible = False
        '
        'btn_GOdon
        '
        Me.btn_GOdon.BackColor = System.Drawing.Color.White
        Me.btn_GOdon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_GOdon.Enabled = False
        Me.btn_GOdon.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GOdon.Image = CType(resources.GetObject("btn_GOdon.Image"), System.Drawing.Image)
        Me.btn_GOdon.Location = New System.Drawing.Point(114, 53)
        Me.btn_GOdon.Name = "btn_GOdon"
        Me.btn_GOdon.Size = New System.Drawing.Size(56, 50)
        Me.btn_GOdon.TabIndex = 158
        Me.btn_GOdon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GOdon.UseVisualStyleBackColor = False
        Me.btn_GOdon.Visible = False
        '
        'btn_GLab
        '
        Me.btn_GLab.BackColor = System.Drawing.Color.White
        Me.btn_GLab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_GLab.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GLab.Image = CType(resources.GetObject("btn_GLab.Image"), System.Drawing.Image)
        Me.btn_GLab.Location = New System.Drawing.Point(7, 53)
        Me.btn_GLab.Name = "btn_GLab"
        Me.btn_GLab.Size = New System.Drawing.Size(56, 50)
        Me.btn_GLab.TabIndex = 156
        Me.btn_GLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GLab.UseVisualStyleBackColor = False
        '
        'lbl_alertas
        '
        Me.lbl_alertas.AutoSize = True
        Me.lbl_alertas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alertas.ForeColor = System.Drawing.Color.Red
        Me.lbl_alertas.Location = New System.Drawing.Point(477, 20)
        Me.lbl_alertas.Name = "lbl_alertas"
        Me.lbl_alertas.Size = New System.Drawing.Size(0, 13)
        Me.lbl_alertas.TabIndex = 126
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(655, 161)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 116
        Me.Label20.Text = "AFILIACION"
        '
        'dgrd_test
        '
        Me.dgrd_test.AllowDrop = True
        Me.dgrd_test.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_test.BackColor = System.Drawing.Color.White
        Me.dgrd_test.BackgroundColor = System.Drawing.Color.White
        Me.dgrd_test.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_test.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_test.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_test.CaptionText = "EXAMENES DISPONIBLES"
        Me.dgrd_test.CaptionVisible = False
        Me.dgrd_test.DataMember = ""
        Me.dgrd_test.FlatMode = True
        Me.dgrd_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_test.ForeColor = System.Drawing.Color.Black
        Me.dgrd_test.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_test.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_test.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_test.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_test.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_test.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.dgrd_test.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_test.Location = New System.Drawing.Point(357, 117)
        Me.dgrd_test.Name = "dgrd_test"
        Me.dgrd_test.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_test.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_test.PreferredColumnWidth = 250
        Me.dgrd_test.ReadOnly = True
        Me.dgrd_test.RowHeadersVisible = False
        Me.dgrd_test.RowHeaderWidth = 20
        Me.dgrd_test.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_test.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_test.Size = New System.Drawing.Size(463, 39)
        Me.dgrd_test.TabIndex = 162
        '
        'btn_GFisio
        '
        Me.btn_GFisio.BackColor = System.Drawing.Color.White
        Me.btn_GFisio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_GFisio.Enabled = False
        Me.btn_GFisio.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GFisio.Image = CType(resources.GetObject("btn_GFisio.Image"), System.Drawing.Image)
        Me.btn_GFisio.Location = New System.Drawing.Point(176, 53)
        Me.btn_GFisio.Name = "btn_GFisio"
        Me.btn_GFisio.Size = New System.Drawing.Size(56, 50)
        Me.btn_GFisio.TabIndex = 161
        Me.btn_GFisio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GFisio.UseVisualStyleBackColor = False
        Me.btn_GFisio.Visible = False
        '
        'btn_SVitales
        '
        Me.btn_SVitales.BackColor = System.Drawing.Color.White
        Me.btn_SVitales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SVitales.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SVitales.Image = CType(resources.GetObject("btn_SVitales.Image"), System.Drawing.Image)
        Me.btn_SVitales.Location = New System.Drawing.Point(815, 38)
        Me.btn_SVitales.Name = "btn_SVitales"
        Me.btn_SVitales.Size = New System.Drawing.Size(56, 50)
        Me.btn_SVitales.TabIndex = 157
        Me.btn_SVitales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_SVitales.UseVisualStyleBackColor = False
        Me.btn_SVitales.Visible = False
        '
        'pic_historico
        '
        Me.pic_historico.Image = CType(resources.GetObject("pic_historico.Image"), System.Drawing.Image)
        Me.pic_historico.Location = New System.Drawing.Point(264, 11)
        Me.pic_historico.Name = "pic_historico"
        Me.pic_historico.Size = New System.Drawing.Size(23, 26)
        Me.pic_historico.TabIndex = 166
        Me.pic_historico.TabStop = False
        Me.pic_historico.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_abono)
        Me.GroupBox1.Controls.Add(Me.lbl_saldo)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Location = New System.Drawing.Point(950, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 68)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        '
        'lbl_abono
        '
        Me.lbl_abono.BackColor = System.Drawing.Color.Black
        Me.lbl_abono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_abono.ForeColor = System.Drawing.Color.Red
        Me.lbl_abono.Location = New System.Drawing.Point(5, 12)
        Me.lbl_abono.Name = "lbl_abono"
        Me.lbl_abono.Size = New System.Drawing.Size(130, 25)
        Me.lbl_abono.TabIndex = 155
        Me.lbl_abono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_saldo
        '
        Me.lbl_saldo.BackColor = System.Drawing.Color.Black
        Me.lbl_saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_saldo.ForeColor = System.Drawing.Color.Red
        Me.lbl_saldo.Location = New System.Drawing.Point(5, 37)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(130, 25)
        Me.lbl_saldo.TabIndex = 154
        Me.lbl_saldo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_ffactura
        '
        Me.btn_ffactura.BackColor = System.Drawing.Color.White
        Me.btn_ffactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ffactura.Enabled = False
        Me.btn_ffactura.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ffactura.Image = CType(resources.GetObject("btn_ffactura.Image"), System.Drawing.Image)
        Me.btn_ffactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ffactura.Location = New System.Drawing.Point(777, 9)
        Me.btn_ffactura.Name = "btn_ffactura"
        Me.btn_ffactura.Size = New System.Drawing.Size(83, 45)
        Me.btn_ffactura.TabIndex = 153
        Me.btn_ffactura.Text = "COBRO"
        Me.btn_ffactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ffactura.UseVisualStyleBackColor = False
        '
        'Grp_paciente
        '
        Me.Grp_paciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grp_paciente.BackColor = System.Drawing.Color.Transparent
        Me.Grp_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_ped_antecedente)
        Me.Grp_paciente.Controls.Add(Me.Label24)
        Me.Grp_paciente.Controls.Add(Me.cmb_afiliacion)
        Me.Grp_paciente.Controls.Add(Me.txt_obs_pac)
        Me.Grp_paciente.Controls.Add(Me.lbl_fono)
        Me.Grp_paciente.Controls.Add(Me.Label25)
        Me.Grp_paciente.Controls.Add(Me.lbl_nombres)
        Me.Grp_paciente.Controls.Add(Me.lbl_genero)
        Me.Grp_paciente.Controls.Add(Me.lbl_direccion_fono)
        Me.Grp_paciente.Controls.Add(Me.Label23)
        Me.Grp_paciente.Controls.Add(Me.pic_historico)
        Me.Grp_paciente.Controls.Add(Me.lkl_pac_buscar)
        Me.Grp_paciente.Controls.Add(Me.lbl_fecnac)
        Me.Grp_paciente.Controls.Add(Me.txt_doc)
        Me.Grp_paciente.Controls.Add(Me.btn_SVitales)
        Me.Grp_paciente.Controls.Add(Me.Label15)
        Me.Grp_paciente.Controls.Add(Me.PictureBox1)
        Me.Grp_paciente.Controls.Add(Me.lbl_edad)
        Me.Grp_paciente.Controls.Add(Me.Label21)
        Me.Grp_paciente.Controls.Add(Me.Label4)
        Me.Grp_paciente.Controls.Add(Me.Label1)
        Me.Grp_paciente.Controls.Add(Me.Label3)
        Me.Grp_paciente.Controls.Add(Me.Label5)
        Me.Grp_paciente.Controls.Add(Me.lbl_his_clinica)
        Me.Grp_paciente.Controls.Add(Me.Label17)
        Me.Grp_paciente.Controls.Add(Me.lbl_grado1)
        Me.Grp_paciente.Controls.Add(Me.cmb_turno)
        Me.Grp_paciente.Controls.Add(Me.Label18)
        Me.Grp_paciente.Controls.Add(Me.lbl_doc)
        Me.Grp_paciente.Controls.Add(Me.lbl_grado)
        Me.Grp_paciente.Controls.Add(Me.Label19)
        Me.Grp_paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_paciente.ForeColor = System.Drawing.Color.Navy
        Me.Grp_paciente.Location = New System.Drawing.Point(8, 69)
        Me.Grp_paciente.Margin = New System.Windows.Forms.Padding(0)
        Me.Grp_paciente.Name = "Grp_paciente"
        Me.Grp_paciente.Size = New System.Drawing.Size(879, 100)
        Me.Grp_paciente.TabIndex = 138
        Me.Grp_paciente.TabStop = False
        '
        'Ctl_txt_ped_antecedente
        '
        Me.Ctl_txt_ped_antecedente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_ped_antecedente.Location = New System.Drawing.Point(348, 72)
        Me.Ctl_txt_ped_antecedente.Multiline = True
        Me.Ctl_txt_ped_antecedente.Name = "Ctl_txt_ped_antecedente"
        Me.Ctl_txt_ped_antecedente.Size = New System.Drawing.Size(463, 28)
        Me.Ctl_txt_ped_antecedente.TabIndex = 175
        '
        'cmb_afiliacion
        '
        Me.cmb_afiliacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_afiliacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_afiliacion.Items.AddRange(New Object() {"NINGUNA", "AFILIADO", "FAMILIAR"})
        Me.cmb_afiliacion.Location = New System.Drawing.Point(114, 74)
        Me.cmb_afiliacion.Name = "cmb_afiliacion"
        Me.cmb_afiliacion.Size = New System.Drawing.Size(150, 21)
        Me.cmb_afiliacion.TabIndex = 165
        '
        'txt_obs_pac
        '
        Me.txt_obs_pac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_obs_pac.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs_pac.Location = New System.Drawing.Point(355, 72)
        Me.txt_obs_pac.Name = "txt_obs_pac"
        Me.txt_obs_pac.Size = New System.Drawing.Size(10, 15)
        Me.txt_obs_pac.TabIndex = 167
        Me.txt_obs_pac.Visible = False
        '
        'lbl_fono
        '
        Me.lbl_fono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_fono.Enabled = False
        Me.lbl_fono.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono.Location = New System.Drawing.Point(349, 54)
        Me.lbl_fono.Name = "lbl_fono"
        Me.lbl_fono.Size = New System.Drawing.Size(106, 15)
        Me.lbl_fono.TabIndex = 174
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(283, 55)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 13)
        Me.Label25.TabIndex = 173
        Me.Label25.Text = "TELEFONO"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_nombres.Enabled = False
        Me.lbl_nombres.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres.Location = New System.Drawing.Point(350, 14)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(463, 15)
        Me.lbl_nombres.TabIndex = 170
        '
        'lbl_genero
        '
        Me.lbl_genero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_genero.Enabled = False
        Me.lbl_genero.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genero.Location = New System.Drawing.Point(513, 54)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(45, 15)
        Me.lbl_genero.TabIndex = 172
        '
        'lbl_direccion_fono
        '
        Me.lbl_direccion_fono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_direccion_fono.Enabled = False
        Me.lbl_direccion_fono.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_fono.Location = New System.Drawing.Point(349, 34)
        Me.lbl_direccion_fono.Name = "lbl_direccion_fono"
        Me.lbl_direccion_fono.Size = New System.Drawing.Size(463, 15)
        Me.lbl_direccion_fono.TabIndex = 171
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(45, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 169
        Me.Label23.Text = "AFILIACION"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lkl_pac_buscar
        '
        Me.lkl_pac_buscar.AutoSize = True
        Me.lkl_pac_buscar.LinkColor = System.Drawing.Color.White
        Me.lkl_pac_buscar.Location = New System.Drawing.Point(824, 14)
        Me.lkl_pac_buscar.Name = "lkl_pac_buscar"
        Me.lkl_pac_buscar.Size = New System.Drawing.Size(45, 13)
        Me.lkl_pac_buscar.TabIndex = 128
        Me.lkl_pac_buscar.TabStop = True
        Me.lkl_pac_buscar.Text = "Buscar"
        '
        'lbl_fecnac
        '
        Me.lbl_fecnac.AutoSize = True
        Me.lbl_fecnac.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecnac.Location = New System.Drawing.Point(297, 83)
        Me.lbl_fecnac.Name = "lbl_fecnac"
        Me.lbl_fecnac.Size = New System.Drawing.Size(7, 10)
        Me.lbl_fecnac.TabIndex = 127
        Me.lbl_fecnac.Text = "."
        '
        'txt_doc
        '
        Me.txt_doc.BackColor = System.Drawing.Color.PaleGreen
        Me.txt_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_doc.Location = New System.Drawing.Point(115, 12)
        Me.txt_doc.Name = "txt_doc"
        Me.txt_doc.Size = New System.Drawing.Size(147, 21)
        Me.txt_doc.TabIndex = 122
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(67, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "CEDULA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'lbl_edad
        '
        Me.lbl_edad.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_edad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.Location = New System.Drawing.Point(115, 35)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(148, 16)
        Me.lbl_edad.TabIndex = 119
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(78, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 118
        Me.Label21.Text = "EDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(463, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "GENERO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(287, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PACIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(278, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DIRECCION"
        '
        'lbl_his_clinica
        '
        Me.lbl_his_clinica.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_his_clinica.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_his_clinica.Location = New System.Drawing.Point(115, 55)
        Me.lbl_his_clinica.Name = "lbl_his_clinica"
        Me.lbl_his_clinica.Size = New System.Drawing.Size(149, 16)
        Me.lbl_his_clinica.TabIndex = 111
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(90, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "HC"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_grado1
        '
        Me.lbl_grado1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grado1.Location = New System.Drawing.Point(238, 77)
        Me.lbl_grado1.Name = "lbl_grado1"
        Me.lbl_grado1.Size = New System.Drawing.Size(8, 16)
        Me.lbl_grado1.TabIndex = 115
        '
        'cmb_turno
        '
        Me.cmb_turno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_turno.ForeColor = System.Drawing.Color.Yellow
        Me.cmb_turno.Location = New System.Drawing.Point(550, 33)
        Me.cmb_turno.Name = "cmb_turno"
        Me.cmb_turno.Size = New System.Drawing.Size(68, 16)
        Me.cmb_turno.TabIndex = 121
        Me.cmb_turno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(674, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "DOCUMENTO:"
        Me.Label18.Visible = False
        '
        'lbl_doc
        '
        Me.lbl_doc.BackColor = System.Drawing.Color.Silver
        Me.lbl_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_doc.Location = New System.Drawing.Point(728, 32)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(71, 16)
        Me.lbl_doc.TabIndex = 95
        Me.lbl_doc.Visible = False
        '
        'lbl_grado
        '
        Me.lbl_grado.BackColor = System.Drawing.Color.DarkGray
        Me.lbl_grado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grado.Location = New System.Drawing.Point(686, 33)
        Me.lbl_grado.Name = "lbl_grado"
        Me.lbl_grado.Size = New System.Drawing.Size(108, 16)
        Me.lbl_grado.TabIndex = 122
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(628, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 114
        Me.Label19.Text = "FACTURA"
        '
        'lst_pedidos
        '
        Me.lst_pedidos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lst_pedidos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_pedidos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lst_pedidos.FormattingEnabled = True
        Me.lst_pedidos.ItemHeight = 14
        Me.lst_pedidos.Location = New System.Drawing.Point(941, 129)
        Me.lst_pedidos.Name = "lst_pedidos"
        Me.lst_pedidos.Size = New System.Drawing.Size(324, 494)
        Me.lst_pedidos.TabIndex = 140
        Me.lst_pedidos.TabStop = False
        '
        'btn_nnuevo
        '
        Me.btn_nnuevo.BackColor = System.Drawing.Color.White
        Me.btn_nnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nnuevo.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nnuevo.Image = CType(resources.GetObject("btn_nnuevo.Image"), System.Drawing.Image)
        Me.btn_nnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nnuevo.Location = New System.Drawing.Point(6, 9)
        Me.btn_nnuevo.Name = "btn_nnuevo"
        Me.btn_nnuevo.Size = New System.Drawing.Size(78, 45)
        Me.btn_nnuevo.TabIndex = 145
        Me.btn_nnuevo.Text = "NUEVO"
        Me.btn_nnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nnuevo.UseVisualStyleBackColor = False
        '
        'btn_eeditar
        '
        Me.btn_eeditar.BackColor = System.Drawing.Color.White
        Me.btn_eeditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eeditar.Enabled = False
        Me.btn_eeditar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eeditar.Image = CType(resources.GetObject("btn_eeditar.Image"), System.Drawing.Image)
        Me.btn_eeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eeditar.Location = New System.Drawing.Point(83, 9)
        Me.btn_eeditar.Name = "btn_eeditar"
        Me.btn_eeditar.Size = New System.Drawing.Size(78, 45)
        Me.btn_eeditar.TabIndex = 146
        Me.btn_eeditar.Text = "EDITAR"
        Me.btn_eeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eeditar.UseVisualStyleBackColor = False
        '
        'btn_aanular
        '
        Me.btn_aanular.BackColor = System.Drawing.Color.White
        Me.btn_aanular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aanular.Enabled = False
        Me.btn_aanular.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aanular.Image = CType(resources.GetObject("btn_aanular.Image"), System.Drawing.Image)
        Me.btn_aanular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aanular.Location = New System.Drawing.Point(160, 9)
        Me.btn_aanular.Name = "btn_aanular"
        Me.btn_aanular.Size = New System.Drawing.Size(80, 45)
        Me.btn_aanular.TabIndex = 147
        Me.btn_aanular.Text = "ANULAR"
        Me.btn_aanular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aanular.UseVisualStyleBackColor = False
        '
        'btn_cconvenio
        '
        Me.btn_cconvenio.BackColor = System.Drawing.Color.White
        Me.btn_cconvenio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cconvenio.Enabled = False
        Me.btn_cconvenio.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cconvenio.Image = CType(resources.GetObject("btn_cconvenio.Image"), System.Drawing.Image)
        Me.btn_cconvenio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cconvenio.Location = New System.Drawing.Point(598, 9)
        Me.btn_cconvenio.Name = "btn_cconvenio"
        Me.btn_cconvenio.Size = New System.Drawing.Size(83, 45)
        Me.btn_cconvenio.TabIndex = 148
        Me.btn_cconvenio.Text = "ORDEN"
        Me.btn_cconvenio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cconvenio.UseVisualStyleBackColor = False
        '
        'btn_gguardar
        '
        Me.btn_gguardar.BackColor = System.Drawing.Color.White
        Me.btn_gguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gguardar.Enabled = False
        Me.btn_gguardar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gguardar.Image = CType(resources.GetObject("btn_gguardar.Image"), System.Drawing.Image)
        Me.btn_gguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gguardar.Location = New System.Drawing.Point(239, 9)
        Me.btn_gguardar.Name = "btn_gguardar"
        Me.btn_gguardar.Size = New System.Drawing.Size(89, 45)
        Me.btn_gguardar.TabIndex = 149
        Me.btn_gguardar.Text = "GUARDAR"
        Me.btn_gguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gguardar.UseVisualStyleBackColor = False
        '
        'btn_pproforma
        '
        Me.btn_pproforma.BackColor = System.Drawing.Color.White
        Me.btn_pproforma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pproforma.Enabled = False
        Me.btn_pproforma.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pproforma.Image = CType(resources.GetObject("btn_pproforma.Image"), System.Drawing.Image)
        Me.btn_pproforma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pproforma.Location = New System.Drawing.Point(327, 9)
        Me.btn_pproforma.Name = "btn_pproforma"
        Me.btn_pproforma.Size = New System.Drawing.Size(95, 45)
        Me.btn_pproforma.TabIndex = 150
        Me.btn_pproforma.Text = "PROFORMA"
        Me.btn_pproforma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pproforma.UseVisualStyleBackColor = False
        '
        'btn_convertir
        '
        Me.btn_convertir.BackColor = System.Drawing.Color.White
        Me.btn_convertir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_convertir.Enabled = False
        Me.btn_convertir.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_convertir.Image = CType(resources.GetObject("btn_convertir.Image"), System.Drawing.Image)
        Me.btn_convertir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_convertir.Location = New System.Drawing.Point(680, 9)
        Me.btn_convertir.Name = "btn_convertir"
        Me.btn_convertir.Size = New System.Drawing.Size(98, 45)
        Me.btn_convertir.TabIndex = 151
        Me.btn_convertir.Text = "CONVERTIR"
        Me.btn_convertir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_convertir.UseVisualStyleBackColor = False
        '
        'btn_ssalir
        '
        Me.btn_ssalir.BackColor = System.Drawing.Color.White
        Me.btn_ssalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ssalir.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ssalir.Image = CType(resources.GetObject("btn_ssalir.Image"), System.Drawing.Image)
        Me.btn_ssalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ssalir.Location = New System.Drawing.Point(859, 9)
        Me.btn_ssalir.Name = "btn_ssalir"
        Me.btn_ssalir.Size = New System.Drawing.Size(78, 45)
        Me.btn_ssalir.TabIndex = 152
        Me.btn_ssalir.Text = "SALIR"
        Me.btn_ssalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ssalir.UseVisualStyleBackColor = False
        '
        'btn_eetiqueta
        '
        Me.btn_eetiqueta.BackColor = System.Drawing.Color.White
        Me.btn_eetiqueta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eetiqueta.Enabled = False
        Me.btn_eetiqueta.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eetiqueta.Image = CType(resources.GetObject("btn_eetiqueta.Image"), System.Drawing.Image)
        Me.btn_eetiqueta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eetiqueta.Location = New System.Drawing.Point(510, 29)
        Me.btn_eetiqueta.Name = "btn_eetiqueta"
        Me.btn_eetiqueta.Size = New System.Drawing.Size(89, 25)
        Me.btn_eetiqueta.TabIndex = 153
        Me.btn_eetiqueta.Text = "ETIQUETAS"
        Me.btn_eetiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eetiqueta.UseVisualStyleBackColor = False
        '
        'btn_dtpDown
        '
        Me.btn_dtpDown.Location = New System.Drawing.Point(975, 75)
        Me.btn_dtpDown.Name = "btn_dtpDown"
        Me.btn_dtpDown.Size = New System.Drawing.Size(33, 23)
        Me.btn_dtpDown.TabIndex = 154
        Me.btn_dtpDown.Text = "<<"
        Me.btn_dtpDown.UseVisualStyleBackColor = True
        '
        'btn_dtpUp
        '
        Me.btn_dtpUp.Location = New System.Drawing.Point(1130, 75)
        Me.btn_dtpUp.Name = "btn_dtpUp"
        Me.btn_dtpUp.Size = New System.Drawing.Size(33, 23)
        Me.btn_dtpUp.TabIndex = 155
        Me.btn_dtpUp.Text = ">>"
        Me.btn_dtpUp.UseVisualStyleBackColor = True
        '
        'btn_AAgendar
        '
        Me.btn_AAgendar.BackColor = System.Drawing.Color.White
        Me.btn_AAgendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AAgendar.Enabled = False
        Me.btn_AAgendar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AAgendar.Image = CType(resources.GetObject("btn_AAgendar.Image"), System.Drawing.Image)
        Me.btn_AAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AAgendar.Location = New System.Drawing.Point(421, 9)
        Me.btn_AAgendar.Name = "btn_AAgendar"
        Me.btn_AAgendar.Size = New System.Drawing.Size(90, 45)
        Me.btn_AAgendar.TabIndex = 156
        Me.btn_AAgendar.Text = "AGENDAR"
        Me.btn_AAgendar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AAgendar.UseVisualStyleBackColor = False
        '
        'cmb_Conve
        '
        Me.cmb_Conve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Conve.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Conve.ForeColor = System.Drawing.Color.Black
        Me.cmb_Conve.Location = New System.Drawing.Point(1139, 105)
        Me.cmb_Conve.Name = "cmb_Conve"
        Me.cmb_Conve.Size = New System.Drawing.Size(126, 21)
        Me.cmb_Conve.TabIndex = 171
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1039, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "FILTRO CONVENIO"
        '
        'btn_buscaOrden
        '
        Me.btn_buscaOrden.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_buscaOrden.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscaOrden.Location = New System.Drawing.Point(941, 103)
        Me.btn_buscaOrden.Name = "btn_buscaOrden"
        Me.btn_buscaOrden.Size = New System.Drawing.Size(92, 23)
        Me.btn_buscaOrden.TabIndex = 173
        Me.btn_buscaOrden.Text = "BUSCA ORDEN"
        Me.btn_buscaOrden.UseVisualStyleBackColor = False
        '
        'btn_AccesoWeb
        '
        Me.btn_AccesoWeb.BackColor = System.Drawing.Color.White
        Me.btn_AccesoWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AccesoWeb.Enabled = False
        Me.btn_AccesoWeb.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AccesoWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AccesoWeb.Location = New System.Drawing.Point(510, 8)
        Me.btn_AccesoWeb.Name = "btn_AccesoWeb"
        Me.btn_AccesoWeb.Size = New System.Drawing.Size(44, 25)
        Me.btn_AccesoWeb.TabIndex = 174
        Me.btn_AccesoWeb.Text = "ACC WEB"
        Me.btn_AccesoWeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AccesoWeb.UseVisualStyleBackColor = False
        '
        'btn_AccImpreso
        '
        Me.btn_AccImpreso.BackColor = System.Drawing.Color.White
        Me.btn_AccImpreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AccImpreso.Enabled = False
        Me.btn_AccImpreso.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AccImpreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AccImpreso.Location = New System.Drawing.Point(554, 8)
        Me.btn_AccImpreso.Name = "btn_AccImpreso"
        Me.btn_AccImpreso.Size = New System.Drawing.Size(44, 25)
        Me.btn_AccImpreso.TabIndex = 175
        Me.btn_AccImpreso.Text = "IMP"
        Me.btn_AccImpreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AccImpreso.UseVisualStyleBackColor = False
        '
        'frm_Pedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1275, 640)
        Me.Controls.Add(Me.btn_AccImpreso)
        Me.Controls.Add(Me.btn_AccesoWeb)
        Me.Controls.Add(Me.btn_buscaOrden)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgrd_pedido)
        Me.Controls.Add(Me.cmb_Conve)
        Me.Controls.Add(Me.grp_test)
        Me.Controls.Add(Me.Grp_pedido)
        Me.Controls.Add(Me.btn_AAgendar)
        Me.Controls.Add(Me.btn_dtpUp)
        Me.Controls.Add(Me.btn_dtpDown)
        Me.Controls.Add(Me.btn_ffactura)
        Me.Controls.Add(Me.btn_eetiqueta)
        Me.Controls.Add(Me.btn_ssalir)
        Me.Controls.Add(Me.btn_convertir)
        Me.Controls.Add(Me.btn_pproforma)
        Me.Controls.Add(Me.btn_gguardar)
        Me.Controls.Add(Me.btn_cconvenio)
        Me.Controls.Add(Me.btn_aanular)
        Me.Controls.Add(Me.btn_eeditar)
        Me.Controls.Add(Me.btn_nnuevo)
        Me.Controls.Add(Me.lst_pedidos)
        Me.Controls.Add(Me.Dtp_ped_fecing)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_importar)
        Me.Controls.Add(Me.btn_duplicado)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_recibo)
        Me.Controls.Add(Me.Grp_paciente)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Pedido"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listo"
        Me.Grp_pedido.ResumeLayout(False)
        Me.Grp_pedido.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_test.ResumeLayout(False)
        Me.grp_test.PerformLayout()
        CType(Me.pic_interface, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_test, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_historico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_paciente.ResumeLayout(False)
        Me.Grp_paciente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Codigo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Public frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Public frm_refer_main As Frm_Main
    Public prioridad As String()
    Public fecha_orden As String
    Dim areas As String = Nothing







    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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



    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.MouseEnter, btn_duplicado.MouseEnter, btn_recibo.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.MouseLeave, btn_duplicado.MouseLeave, btn_recibo.MouseLeave
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


    Private Sub Formulario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'elimina la referecnia del formulario del MDI
        ClickMenu_Principal(Me)
        RemoveCtxMenu_Principal(Me, Me.Text)
    End Sub


#End Region
    Private m_cls_dgimpresion As cls_dgimpresion = Nothing
    'declaracion de variables
    Private opr_perfil As New Cls_Perfil()
    Private opr_medico As New Cls_Medico()
    Private opr_negocio As New Cls_Pedido
    Private opr_test As New Cls_Test()
    Private opr_convenio As New Cls_Convenio()
    Private opr_laboratorio As New Cls_Laboratorio()
    Private opr_trabajo As New Cls_Trabajo()
    Private dbl_pedido_total As Double
    Private lng_pac_id As Long
    Private sht_ped_turno As Long
    Private str_fecha_ori As String
    Public dtt_pedido As New DataTable("Registros")
    Private dtv_pedido As New DataView(dtt_pedido)
    Private dtv_test As New DataView()
    Dim boo_cerrar As Boolean = False
    Public pedidoborra() As String
    Dim ban As Integer
    Dim recib As String
    Public Lista_Areas As String = Nothing
    Public tipo As String = Nothing

    '***************
    Dim STR_SQL, str_crea As String
    Dim obj_reporte As Object
    Dim dts_registro As DataSet = Nothing

    '****************
    Public g_usu_login, g_usu_pass As String
    Public pacienteA As String = Nothing
    Public pacienteN As String = Nothing

    Private opr_paciente As New Cls_Paciente()
    Dim area As Integer = 0
    Dim dts_lista As New DataSet
    Dim opr_res As New Cls_Resultado()
    Dim boo_recibo As Boolean = False
    Dim boo_existeturno As Boolean = False
    Dim opr_pedido As New Cls_Pedido()

    Dim pac_id As Integer

    'pedidoborra, esta variable va almacenando los valores de los test o perfiles que fueron borrados de alg�n 
    'pedido ya almacenado y que se encuentra modificando



    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cierro el formulario
        boo_cerrar = True
        Me.Close()
    End Sub

    Private Sub frm_Pedido_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If boo_cerrar Then
            If MsgBox("Desea cerrar el formulario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar el formulario") = MsgBoxResult.No Then
                e.Cancel = True
                boo_cerrar = False
            End If
        End If
    End Sub

    Sub CalcularTotal()
        'recorro el grid de los test y perfiles seleccionados y calculo el total a pagar
        Dim int_indice As Integer = 0
        Dim int_precio As Double = 0
        For int_indice = 0 To dtt_pedido.Rows.Count - 1
            If dtt_pedido.Rows(int_indice).Item(2).ToString = "" Then dtt_pedido.Rows(int_indice).Item(2) = 1
            int_precio = CInt(dtt_pedido.Rows(int_indice).Item(1)) * CDbl(dtt_pedido.Rows(int_indice).Item(4)) + int_precio
            'btn_gguardar.Visible = True
            'btn_pproforma.Visible = True
            lbl_alertas.Text = ""
        Next
        lbl_total.Text = Format(CDbl(int_precio), "$ ###,##0.00")
    End Sub

    Private Sub frm_Pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        Me.Cursor = Cursors.WaitCursor
        cmb_Cantidad.Text = 2
        'Se añade el codigo para los estilos de las columnas en el grid de test pedidos
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "AREA", "ARE_NOMBRE", 210))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "#", "cantidad", 20))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "EXAMEN", "test", 380))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "", "id", 0))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable("$ #,##0.00", "PRECIO U", "precio", 100))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "tipo", "tipo", 0))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable("#", "estado", "estado", 0, , "0"))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "listatest", "listatest", 0))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable("#", "nuevo", "nuevo", 0, , "0"))
        DataGridTableStyle2.GridColumnStyles.Add(New Cls_Celda_NoEditable("$ #,##0.00", "PRECIO T", "precioT", 100))
        DataGridTableStyle2.GridColumnStyles.Item(3).Alignment = HorizontalAlignment.Right
        'defino las columnasde grid
        Dim dtc_columna1 As New DataColumn("ARE_NOMBRE", GetType(System.String))
        Dim dtc_columna2 As New DataColumn("cantidad", GetType(System.Single))
        Dim dtc_columna3 As New DataColumn("test", GetType(System.String))
        Dim dtc_columna4 As New DataColumn("id", GetType(System.Int64))
        Dim dtc_columna5 As New DataColumn("precio", GetType(System.Double))
        Dim dtc_columna6 As New DataColumn("tipo", GetType(System.String))
        Dim dtc_columna7 As New DataColumn("estado", GetType(System.String))
        Dim dtc_columna8 As New DataColumn("listatest", GetType(System.String))
        Dim dtc_columna9 As New DataColumn("nuevo", GetType(System.String))
        Dim dtc_columna10 As New DataColumn("precioT", GetType(System.Double))
        dtt_pedido.Columns.Add(dtc_columna1)
        dtt_pedido.Columns.Add(dtc_columna2)
        dtt_pedido.Columns.Add(dtc_columna3)
        dtt_pedido.Columns.Add(dtc_columna4)
        dtt_pedido.Columns.Add(dtc_columna5)
        dtt_pedido.Columns.Add(dtc_columna6)
        dtt_pedido.Columns.Add(dtc_columna7)
        dtt_pedido.Columns.Add(dtc_columna8)
        dtt_pedido.Columns.Add(dtc_columna9)
        dtt_pedido.Columns.Add(dtc_columna10)

        dtv_pedido.AllowNew = False
        dtv_pedido.AllowDelete = False
        dgrd_pedido.DataSource = dtv_pedido
        'dgrd_test.AllowSorting = True
        'Se carga todos los datos

        If System.Configuration.ConfigurationSettings.AppSettings("INTERFACE") = True Then
            lbl_InterfaceNombre.Text = System.Configuration.ConfigurationSettings.AppSettings("NOMBRE")
            pic_interface.Visible = True
        Else
            lbl_InterfaceNombre.Text = ""
            pic_interface.Visible = False
        End If



        Lista_Areas = " area.ARE_ID <= 120"
        tipo = "Examen"
        If g_EsOcupacional = 1 Then
            'btn_SVitales.Visible = True
            lbl_categoria.Text = "OCUPACIONAL"
        Else
            'btn_SVitales.Visible = False
            lbl_categoria.Text = "LABORATORIO"
        End If


        'lleno el combo de medicos
        opr_medico.LlenarComboMedico(cmb_medico, "Referencia")

        Dim ColeccionMed As New AutoCompleteStringCollection
        'opr_test.LlenarGridTest_CodNom(dtv_test, Trim(prioridad(0)), Lista_Areas, tipo)

        CargarColeccionMedico(ColeccionMed, "Referencia")
        txt_filtro_medico.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt_filtro_medico.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_filtro_medico.AutoCompleteCustomSource = ColeccionMed

        opr_medico.LlenarComboMedico(cmb_tratante, "Tratante")




        'lleno el combo de convenios, el momento que se llena los convenios se relaciona y llena el grid con los test y la lista de perfiles
        'opr_convenio.LlenarComboConvenio(cmb_convenio)

        'lleno combo prioridad con secuencias
        opr_pedido.LlenarComboPrioridad(cmb_convenio, False, True)
        opr_pedido.LlenarComboPrioridadTODOS(cmb_Conve, False)
        cmb_afiliacion.SelectedIndex = 0


        prioridad = Split(cmb_convenio.Text, "/")

        'g_CadenaFiltro = Format(Dtp_ped_fecing.Value, "") & "," & Format(Dtp_ped_fecing.Value, "") & "," & prioridad(0) & "," & prioridad(1) & "," & prioridad(2) & ",00,"

        opr_trabajo.LlenarComboServicio(cmb_servicios)

        'lleno el combo de laboratorios
        opr_laboratorio.LlenarComboLab(cmb_laboratorio)
        Dtp_ped_fecing.Value = Now

        dgrd_test.DataSource = dtv_test
        If dgrd_test.VisibleRowCount <> 0 Then
            dgrd_test.NavigateTo(0, "Registros")
        End If

        txt_doc.Focus()

        pedidoborra = Nothing

        If System.Configuration.ConfigurationSettings.AppSettings("MATRIZ") Then
            txt_recibo.Text = "Matriz"

        Else
            txt_recibo.Text = "Sucursal"
        End If

        If Trim(Me.Tag) <> "" Then
            Call lee_pedido(Me.Tag)
        Else
            dgrd_pedido.Enabled = False
            Limpia()
        End If

        Grp_paciente.Enabled = False
        Grp_pedido.Enabled = False
        grp_test.Enabled = False


        If System.Configuration.ConfigurationSettings.AppSettings("Dialisis") = True Then
            cmb_PrePost.Enabled = True
            cmb_PrePost.SelectedIndex = 0
        Else
            cmb_PrePost.Enabled = False
            cmb_PrePost.SelectedIndex = 0
        End If


        Me.Cursor = Cursors.Default
        txt_doc.Focus()
    End Sub

    Sub CargarColeccion(ByVal Coleccion As AutoCompleteStringCollection, ByVal Lista_areas As String, ByVal convenio As String, ByVal Tipo As String, ByRef dtv_test As DataView)
        On Error Resume Next
        opr_test.LeerTestColeccion(Coleccion, Lista_areas, convenio, Tipo)
        'dtv_test.Table = opr_test.LeerTest(convenio, Lista_areas, Tipo).Tables("Registros")
    End Sub

    Sub CargarColeccionMedico(ByVal ColeccionMed As AutoCompleteStringCollection, ByVal tipo As String)
        On Error Resume Next
        opr_test.LeerColeccionMedico(ColeccionMed, tipo)
    End Sub


    Sub CargarColeccionConvenios(ByVal Coleccion As AutoCompleteStringCollection, ByVal Lista_areas As String, ByVal convenio As String, ByVal Tipo As String, ByRef dtv_test As DataView)
        On Error Resume Next
        opr_test.LeerConvenioColeccion(Coleccion, Lista_areas, convenio, Tipo)
        'dtv_test.Table = opr_test.LeerTest(convenio, Lista_areas, Tipo).Tables("Registros")
    End Sub




    Public Sub LLena_datos_paciente_doc()
        'toma los datos del paciete que son dvueltos entagdel formulario
        'luego d haber seleccioando del otro formulario
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        Dim boo_edad As Boolean = True
        'separo los campos en un arreglo
        str_campos = Split(Me.Tag, "/*/")
        'Cuando creo doctor y regreso al formulario de pedido impide que se borre datos del paciente ya ingresados
        If UBound(str_campos) = 0 Then
            opr_medico.LlenarComboMedico(cmb_medico, "Referencia")
            Dim i As Integer
            Dim MaxMedico As Integer
            MaxMedico = opr_medico.LeerMaxMedico
            If ban = 1 Then
                For i = 1 To CInt(cmb_medico.Items.Count)
                    cmb_medico.SelectedIndex = i - 1
                    If Trim(cmb_medico.Text.Substring(100, 5)) = MaxMedico Then
                        Exit For
                    End If
                Next
            End If
            Exit Sub
        End If
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
                    txt_doc.Text = (str_valor)
                Case "pac_apellido"
                    lbl_nombres.Text = (str_valor)
                Case "pac_nombre"
                    lbl_nombres.Text = lbl_nombres.Text + " " & (str_valor)
                Case "pac_direccion"
                    lbl_direccion_fono.Text = (str_valor)
                Case "pac_genero"
                    lbl_genero.Text = (str_valor)
                Case "pac_fono"
                    lbl_fono.Text = (str_valor)
                Case "pac_id"
                    lng_pac_id = (str_valor)
                Case "pac_hist_clinica"
                    lbl_his_clinica.Text = (str_valor)

                Case "pac_grado"
                    lbl_grado.Text = (str_valor)
                Case "pac_parentesco"
                    lbl_fecing.Text = (str_valor)
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



    Sub Limpia()
        'Ctl_txt_num_Pedido.Enabled = True
        'Ctl_txt_num_Pedido.Text = ""
        lbl_alertas.Text = ""
        lbl_abono.Text = ""
        lbl_saldo.Text = ""
        cmb_servicios.SelectedIndex = CInt(System.Configuration.ConfigurationSettings.AppSettings("Servicio"))
        lkl_pac_buscar.Enabled = True
        Grp_pedido.Enabled = True
        'Me.txt_recibo.SelectedIndex = 0
        dgrd_pedido.Enabled = True
        lbl_nombres.Text = ""
        lbl_doc.Text = ""
        lbl_grado.Text = ""
        lbl_edad.Text = ""
        lbl_fecing.Text = ""
        rbtn_pedido.Checked = True
        lbl_direccion_fono.Text = ""
        lbl_fono.Text = ""
        ''''Dtp_ped_fecing.Value = Now
        txt_obs_pac.Text = ""
        cmb_PrePost.SelectedIndex = 0

        cmb_convenio.SelectedIndex = CInt(System.Configuration.ConfigurationSettings.AppSettings("Convenio"))

        cmb_afiliacion.SelectedIndex = 0

        cmb_medico.SelectedIndex = 0
        cmb_laboratorio.SelectedIndex = 0
        txt_doc.Text = ""
        txt_filtro_nombre.Text = ""
        Ctl_txt_ped_antecedente.Text = ""
        'Ctl_txt_ped_antecedente.MaxLength = 150
        Ctl_txt_medicacion.texto_Asigna("")
        Ctl_txt_medicacion.txt_padre.MaxLength = 150
        lbl_total.Text = ""
        dtt_pedido.Clear()
        lbl_his_clinica.Text = ""
        btn_nuevo.Enabled = False
        pic_historico.Visible = False
        'lnk_historico.Visible = False
        txt_doc.Focus()
    End Sub

    Sub Abrir_frmMuestras(Optional ByVal fl = 0)
        If Not ExisteForm("frm_Muestra") Then
            Dim FrM_MDIChild As New frm_Muestra()
            FrM_MDIChild.MdiParent = frm_refer_main_form
            If fl = 0 Then
                FrM_MDIChild.Tag = "pedido"
            ElseIf fl = 1 Then
                FrM_MDIChild.Tag = "pedido1"
            Else
                FrM_MDIChild.Tag = "pedido_modif"
            End If
            Me.Close()
            FrM_MDIChild.Show()
        End If
    End Sub

    Sub Abrir_frmImprimiendo(Optional ByVal fl = 0)

        Dim opr_pedido As New Cls_Pedido()

        If Not ExisteForm("frm_imprimiendo") Then
            Dim frm_MDIChild As New frm_imprimiendo()

            Select Case fl
                Case 3
                    frm_MDIChild.Label1.Text = "Enviando proforma"
                    'dgrd_proforma.DataSource = opr_pedido.llenaProforma(g_lng_ped_id)
                    Dim ds As DataSet
                    ds = opr_pedido.LeerProforma(g_lng_ped_id)
                    frm_MDIChild.dts_proforma = ds

                Case 0
                    frm_MDIChild.Label1.Text = "Enviando etiquetas muestras"

                Case 4

                    frm_MDIChild.Label1.Text = "Enviando etiquetas acceso"
                    frm_MDIChild.usuario = "USUARIO: " & g_usu_login
                    frm_MDIChild.contrasena = "CONTRASENA: " & Trim(txt_doc.Text)
                    frm_MDIChild.sitio = "LINK: " & System.Configuration.ConfigurationSettings.AppSettings("SITIO")

            End Select

            frm_MDIChild.Ped_id = g_lng_ped_id
            frm_MDIChild.ShowDialog(Me.ParentForm)

        End If
    End Sub

    Sub Abrir_frmPedido()
        'On Error Resume Next
        If Not ExisteForm("frm_Pedido") Then
            Dim FrM_MDIChild As New frm_Pedido()
            FrM_MDIChild.frm_refer_main = Me.ParentForm
            Me.Close()
            FrM_MDIChild.ShowDialog(Me.ParentForm)
        End If
    End Sub



    Sub Abrir_frmPedidos()
        'On Error Resume Next
        If Not ExisteForm("frm_Pedido2") Then
            Dim FrM_MDIChild As New frm_Pedido2()
            FrM_MDIChild.frm_refer_main = Me.ParentForm
            Me.Close()
            FrM_MDIChild.ShowDialog(Me.ParentForm)
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'If cmb_turno.Text = "" Then cmb_turno.Text = "0"
        'If Ctl_txt_turno.texto_Recupera = "" Then Ctl_txt_turno.texto_Asigna(0)
        If lbl_nombres.Text = "" Then
            MsgBox("Los nombres del paciente son obligatorios", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If dtt_pedido.Rows.Count = 0 Then
                MsgBox("Debe seleccionar por lo menos un test", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                'controla que el tu rno no sea 0 y que sea ingreso de registro me.tag=""
                'If cmb_turno.Text = "0" And Me.Tag = "" Then
                '    If MsgBox("El pedido no posee turno, Desea almacenarlo Sin Turno? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                '        cmb_turno.Focus()
                '        'Ctl_txt_turno.txt_padre.Focus()
                '        Exit Sub
                '    End If
                'End If
                Dim opr_pedido As New Cls_Pedido()
                Dim boo_existeturno As Boolean = False
                If Me.Tag <> "" Then
                    'Actualiza los datos del pedido
                    If MsgBox("Desea modificar el pedido # " & CShort(cmb_turno.Text), MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.Yes Then
                        'controla si el valor de turno ingresado es diferente al almacenado
                        If sht_ped_turno <> CShort(cmb_turno.Text) Then
                            boo_existeturno = opr_pedido.Existeturno(Dtp_ped_fecing.Value, CShort(cmb_turno.Text), , , Me.cmb_convenio.Text)
                            sht_ped_turno = CShort(cmb_turno.Text)
                        End If
                        'codigo para evitar un mismo turno el mismo dia.
                        If str_fecha_ori <> CStr(Format(Dtp_ped_fecing.Value, "dd/MM/yyyy")) Then
                            boo_existeturno = opr_pedido.Existeturno(Dtp_ped_fecing.Value, CShort(cmb_turno.Text), , , Me.cmb_convenio.Text)
                            str_fecha_ori = ""
                        End If
                        If boo_existeturno Then
                            MsgBox("El TURNO ya existe, ingrese uno diferente", MsgBoxStyle.Exclamation, "ANALISYS")
                        Else
                            If opr_pedido.ActualizarPedido(Me) <> 0 Then
                                If MsgBox("Desea imprimir etiquetas para este pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                                    Abrir_frmMuestras(2)
                                    GC.Collect()
                                    Me.Close()
                                Else
                                    Abrir_frmPedidos()
                                    GC.Collect()
                                End If

                            End If
                        End If
                    End If
                Else

                    boo_existeturno = False 'opr_pedido.Existeturno(Dtp_ped_fecing.Value, CShort(cmb_turno.Text), , , Me.cmb_ped_tipo.Text)
                    If boo_existeturno Then
                        MsgBox("El TURNO ya existe, ingrese uno diferente", MsgBoxStyle.Exclamation, "ANALISYS")
                    Else
                        'JPO Cambio exclusivo para el Club de Leones
                        'Pregunto si el pedido existe, en caso de no existir lo almaceno
                        'If opr_pedido.PedidoNuevo(Ctl_txt_num_Pedido.texto_Recupera) = 0 Then
                        'guardar los NUEVOS datos, se envia el formulario por valor
                        ''frm_refer_main_form.escribemsj("GUARDANDO DATOS")
                        Dim x As Long = opr_pedido.LeerMaxPedido()
                        x = x + 1
                        'If opr_pedido.GuardarPedido(Me, lng_pac_id, CInt(Ctl_txt_num_Pedido.texto_Recupera)) <> 0 Then

                        'CUANDO SE TRATA DE PEDIDO
                        If opr_pedido.GuardarPedido(Me, lng_pac_id, x, 1, 0, CInt(Mid(cmb_medico.Text, 100, 10))) <> 0 Then
                            'Si el formulario no se cierra entonces se llamar�a a la funci�n limpia
                            'una vez almacenado los datos mando a abrir el formulario que
                            'permitira la impresion de etiquetas de dicho pedido
                            ''frm_refer_main_form.escribemsj("DISPONIBLE")
                            If MsgBox("Desea seguir ingresando pedidos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                                'Limpia()
                                Abrir_frmMuestras()
                                Me.Close()
                            Else
                                Abrir_frmMuestras(1)
                                Me.Close()
                            End If
                        Else
                            ''frm_refer_main_form.escribemsj("ERRORES AL GUARDAR PEDIDO")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmb_convenio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_convenio.SelectedIndexChanged

        'cmb_servicios.Focus()

        'cuando escojo otra opcion del combo de convenio debe actualizarce los siguientes elementos
        If Trim(cmb_convenio.Text) <> "" Then
            prioridad = Split(cmb_convenio.Text, "/")

            txt_filtro_nombre.Text = ""
            'llena la lista de perfiles


            Dim Coleccion As New AutoCompleteStringCollection
            opr_test.LlenarGridTest_CodNom(dtv_test, Trim(prioridad(0)), Lista_Areas, tipo)

            CargarColeccion(Coleccion, Lista_Areas, prioridad(0), tipo, dtv_test)
            txt_filtro_nombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txt_filtro_nombre.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_filtro_nombre.AutoCompleteCustomSource = Coleccion


            ''txt_filtro_nombre.Font = New Font("Courier New", 8.2!, FontStyle.Regular)


            Dim int_indice, int_total, int_indice2 As Integer
            For int_indice = 0 To dtt_pedido.Rows.Count - 1
                If dtt_pedido.Rows(int_indice).Item(5) = "T" Then
                    For int_indice2 = 0 To dtv_test.Count - 1
                        If dtt_pedido.Rows(int_indice).Item(3) = dgrd_test(int_indice2, 2) Then
                            dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * dgrd_test(int_indice2, 3)
                            dtt_pedido.Rows(int_indice).Item(9) = dtt_pedido.Rows(int_indice).Item(1) * dgrd_test(int_indice2, 3)
                            Exit For
                        End If
                    Next
                Else
                    'For int_indice2 = 0 To lst_perfil.Items.Count
                    '    If dtt_pedido.Rows(int_indice).Item(3) = Trim(lst_perfil.Items.Item(int_indice2).substring(100, 10)) Then
                    '        dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * Val(Trim(lst_perfil.Items.Item(int_indice2).substring(110, 10)))
                    '        Exit For
                    '    End If
                    'Next
                End If
            Next
            Call CalcularTotal()
        End If
    End Sub



    Private Sub btn_duplicado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_duplicado.Click
        'funcion queme permite duplicar un pedido que ya exista ne la base datos
        Dim str_ped_id As String
        'me pide que ingrese el codigo de un pedido creado anteriormente
        ''frm_refer_main_form.escribemsj("DUPLICANDO PEDIDO")
        str_ped_id = InputBox("Ingrese el Codigo del Pedido a Duplicar", "ANALISYS")
        If Trim(str_ped_id) <> "" And IsNumeric(str_ped_id) Then
            Dim opr_pedido As New Cls_Pedido()
            Dim dts_pedido As DataSet
            Dim dtr_fila As DataRow
            'mando a verificar si ese pedido existe
            dts_pedido = opr_pedido.LeerUnPedido(str_ped_id)
            If dts_pedido.Tables("Registros").Rows.Count = 0 Then
                'si no encontro ese pedido
                MsgBox("No se encontro el pedido # " & str_ped_id, MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                lkl_pac_buscar.Enabled = True
                Grp_pedido.Enabled = True
                dgrd_pedido.Enabled = True
                'cargo en los cuadros de texto los datos del pedido a duplicar
                For Each dtr_fila In dts_pedido.Tables("Registros").Rows
                    Dtp_ped_fecing.Value = Now
                    Ctl_txt_ped_antecedente.Text = ""
                    Ctl_txt_medicacion.texto_Asigna("")
                    cmb_convenio.Text = dtr_fila("ped_tipo").ToString
                    cmb_convenio.Text = dtr_fila("con_nombre").ToString
                    cmb_medico.Text = dtr_fila("med_nombre").ToString.PadRight(100) & dtr_fila("med_id").ToString.PadRight(10)
                    cmb_laboratorio.Text = dtr_fila("lab_nombre").ToString.PadRight(100) & dtr_fila("lab_id").ToString.PadRight(10)
                Next
                dtt_pedido.Clear()
                'cargo en la lista de pedidos los datos del detalle del pediso
                ''frm_refer_main_form.escribemsj("CONSULTANDO DATOS DEL PEDIDO")
                opr_pedido.LlenarGridUnPedido(dtt_pedido, Trim(cmb_convenio.Text), str_ped_id, 1)
            End If
            CalcularTotal()
        Else
            'verifica que el codigo ingresado en msgbox sea numerico
            If Trim(str_ped_id) <> "" Then
                MsgBox("El codigo del pedido debe ser numerico", MsgBoxStyle.Exclamation, "ANALISYS")
            End If
        End If
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
    End Sub

    Private Sub rbtn_codigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_codigo.CheckedChanged
        txt_filtro_nombre.Text = ""
        txt_filtro_nombre.Focus()
    End Sub

    Private Sub rbtn__CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_nombre.CheckedChanged
        txt_filtro_nombre.Text = ""
        txt_filtro_nombre.Focus()
    End Sub

#Region "Manejo Grid"

#Region "Manejo Grid  TEST"



    Private Sub Insertar_test_en_pedido_txt(ByVal nombre_test As String, ByVal convenio As String)
        Dim int_i As Short
        Dim boo_flag As Boolean = False
        Dim datos_test As String()

        prioridad = Split(convenio, "/")
        '1. BUSCO LOS DATOS DEL TEST CON SU NOMBRE
        datos_test = Split(opr_test.BuscaDatosTest(Trim(nombre_test), Trim(prioridad(0))), ",")
        If UBound(datos_test) > 0 Then
            'el flag es 1 cuando los datos son test, y verificoque ese test ya este no lista 
            If dgrd_pedido.Enabled = True Then
                'se controla que el test no se encuentre ya ingresado en el grid, se hace la comprobacion con los perfiles
                If (dtt_pedido.Rows.Count > 0) Then
                    For int_i = 1 To dtt_pedido.Rows.Count
                        Select Case dtt_pedido.Rows(int_i - 1).Item(5).ToString

                            Case "T"
                                'se busca en los test
                                'If dgrd_test.CurrentRowIndex <> -1 Then
                                If txt_filtro_nombre.Text.ToUpper() = dtt_pedido.Rows(int_i - 1).Item(2).ToString Then
                                    lbl_alertas.Text = "EXAMEN REPETIDO"
                                    boo_flag = True
                                    Exit For
                                End If
                                'End If
                        End Select
                    Next
                End If

                If boo_flag = False Then

                    If datos_test(4).ToString = "E" Then
                        Dim dtr_fila As DataRow = dtt_pedido.NewRow
                        'dtr_fila(0) = 1
                        If txt_filtro_nombre.Text <> "" Then
                            dtr_fila(0) = Trim(datos_test(0).PadRight(100))
                            dtr_fila(1) = 1
                            dtr_fila(2) = Trim(datos_test(1).ToString.PadRight(100))
                            dtr_fila(3) = Val(datos_test(2).ToString.PadRight(10))
                            dtr_fila(4) = Val(datos_test(3).ToString.PadRight(10))
                            dtr_fila(5) = Trim("T".PadRight(5))
                            dtr_fila(6) = 0
                            dtr_fila(7) = dtr_fila(2)
                            dtr_fila(8) = 1   ' nuevo
                            dtr_fila(9) = Val(datos_test(3).ToString.PadRight(10)) * 1
                            dtt_pedido.Rows.Add(dtr_fila)
                            txt_filtro_nombre.Text = ""
                            txt_filtro_nombre.Focus()
                            btn_gguardar.Enabled = True
                            btn_pproforma.Enabled = True
                            btn_AAgendar.Enabled = True
                            Call CalcularTotal()
                        Else
                            MsgBox("Ausencia de tests, Consulte con Soporte Tecnico", MsgBoxStyle.Exclamation, "ANALISYS")
                        End If

                    Else
                        'MsgBox("Aqui PERFIL", MsgBoxStyle.Exclamation, "ANALISYS")
                        Insertar_perfil_en_pedido(Val(datos_test(2)))
                    End If
                End If
            End If
        Else

        End If
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
    End Sub




#End Region

#Region "Manejo Grid  PEDIDO"

    Private Sub dgrd_pedido_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'selecciono toda la fila del grid
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub Grid_KeyUp_Ped(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Operaciones al precionar CURSOR DE ARRIBA O ABAJO, sobre el grid y controla que siempre exista una celda seleccionada
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub Grid_KeyDown_Ped(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            'Operaciones al precionar DELETE sobre el grid
            Eliminar(1)
        End If
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub Grid_DoubleClick_Ped(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Operaciones al precionar DOBLE CLICK sobre el grid
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub Grid_Click_Ped(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Operaciones al precionar CLICK sobre el grid
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private celdaanteriorped As Short
    Private Sub Grid_Seleccionar_Celda_Ped()
        On Error Resume Next
        'funci�n que no permite que exista selecci�n multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        dgrd_pedido.UnSelect(celdaanteriorped)
        dgrd_pedido.Select(dgrd_pedido.CurrentCell.RowNumber)
        celdaanteriorped = dgrd_pedido.CurrentCell.RowNumber
    End Sub

    Sub AdicionaPedidoBorra()
        If Me.Tag <> "" Then
            If pedidoborra Is Nothing Then
                ReDim Preserve pedidoborra(0)
                pedidoborra(0) = dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(5) & "," & dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(3)
            Else
                ReDim Preserve pedidoborra(UBound(pedidoborra) + 1)
                pedidoborra(UBound(pedidoborra)) = dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(5) & "," & dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(3)
            End If
        End If
    End Sub

    Private Sub Eliminar(ByVal flag As Byte)
        On Error Resume Next

        If dtt_pedido.Rows.Count = 1 Then
            btn_gguardar.Enabled = False
            btn_pproforma.Enabled = False
        End If
        If dtt_pedido.Rows.Count > 0 Then
            If flag = 1 Then
                'elimina uno a uno
                Select Case dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(6)
                    Case 0  'elimina sin restricci�n
                        AdicionaPedidoBorra()
                        dtt_pedido.Rows.Item(dgrd_pedido.CurrentCell.RowNumber).Delete()
                    Case 1  'no puede eliminar porque esta procesado, enviado al equipo o validado
                        AdicionaPedidoBorra()
                        dtt_pedido.Rows.Item(dgrd_pedido.CurrentCell.RowNumber).Delete()
                        'MsgBox("No puede eliminar el test seleccionado, debido a que se encuentra:" & Chr(13) & "procesado o enviado a alg�n equipo del laboratorio", MsgBoxStyle.Exclamation, "ANALISYS")
                    Case 2  'elimina pero despliega mensaje de advertencia
                        If MsgBox("EL EXAMEN SELECCIONADO ESTA EN PROCESO, DESEA ELIMINARLO ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                            AdicionaPedidoBorra()
                            dtt_pedido.Rows.Item(dgrd_pedido.CurrentCell.RowNumber).Delete()
                        End If
                End Select
            Else
                'elimina todos
                Dim sht_cont As Short
                Dim boo_elimina As Boolean = True
                For sht_cont = 0 To dtt_pedido.Rows.Count - 1
                    If dtt_pedido.Rows(sht_cont).Item(6) <> 0 Then
                        boo_elimina = False
                        Exit For
                    Else
                        If pedidoborra Is Nothing Then
                            ReDim Preserve pedidoborra(0)
                            pedidoborra(0) = dtt_pedido.Rows(sht_cont).Item(5) & "," & dtt_pedido.Rows(sht_cont).Item(3)
                        Else
                            ReDim Preserve pedidoborra(UBound(pedidoborra) + 1)
                            pedidoborra(UBound(pedidoborra)) = dtt_pedido.Rows(sht_cont).Item(5) & "," & dtt_pedido.Rows(sht_cont).Item(3)
                        End If
                    End If
                Next
                If boo_elimina Then
                    dtt_pedido.Rows.Clear()
                Else
                    MsgBox("IMPOSIBLE ELIMINAR LOS EXAMENES, UNO O VARIOS EXAMENES SE ENCUENTRAN " & Chr(13) & "PROCESADOS O VALDADOS", MsgBoxStyle.Exclamation, "ANALISYS")
                End If
            End If
            Call CalcularTotal()
        End If
    End Sub

    Private Sub men_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_eliminar.Click
        'permite eliminar un elento del grid 
        Eliminar(1)
    End Sub

    Private Sub men_eliminar_todo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles men_eliminar_todo.Click
        'elimina todos los elementos del grid
        Eliminar(0)
    End Sub

#End Region

#Region "Lista Perfiles"

    Private Sub Insertar_perfil_en_pedido(ByVal per_id As Short)
        Dim int_i, i As Short
        Dim boo_flag As Boolean
        'cuando presino el mouse sobre lista de perfil
        On Error Resume Next
        If dgrd_pedido.Enabled = True Then
            If per_id >= 0 Then
                Dim LISTATEST, aux As String
                Dim ESTADOTEST As Short
                Dim opr_pedido As New Cls_Pedido()
                opr_pedido.ActualizaPerfilGrid(Val(per_id), 1, LISTATEST, ESTADOTEST)
                Dim arr_listatest() As String = Split(LISTATEST, ",")
                If (dtt_pedido.Rows.Count > 0) Then
                    arr_listatest.Sort(arr_listatest)
                    For int_i = 1 To dtt_pedido.Rows.Count
                        'se busca en los perfiles y en los test
                        Select Case dtt_pedido.Rows(int_i - 1).Item(5).ToString
                            Case "P"
                                If txt_filtro_nombre.Text.ToUpper() = dtt_pedido.Rows(int_i - 1).Item(3).ToString Then
                                    '''frm_refer_main_form.escribemsj("PERFIL REPETIDO")
                                    'MsgBox("PERFIL REPETIDO", MsgBoxStyle.Exclamation, "ANALISYS")
                                    lbl_alertas.Text = "PERFIL REPETIDO"
                                    boo_flag = True
                                    Exit For
                                End If
                            Case "T"
                                If arr_listatest.BinarySearch(arr_listatest, dtt_pedido.Rows(int_i - 1).Item(3).ToString) >= 0 Then
                                    'MsgBox("EXAMEN REPETIDO EN PERFIL:  " & Chr(13) & "ALGUN EXAMEN SE ENCUENTRA EN LA LISTA", MsgBoxStyle.Exclamation, "ANALISYS")
                                    lbl_alertas.Text = "EXAMEN REPETIDO EN PERFIL:  ALGUN EXAMEN SE ENCUENTRA EN LA ORDEN"
                                    boo_flag = True
                                    Exit For
                                End If
                        End Select
                    Next
                End If


                If boo_flag = False Then
                    Dim dts_listatest As DataSet
                    dts_listatest = opr_test.testperfil(LISTATEST, Trim(Trim(prioridad(0))))
                    Dim int_indice, int_total, int_indice2 As Integer
                    Dim dtr_filaaux As DataRow
                    For Each dtr_filaaux In dts_listatest.Tables("RegistrosC").Rows
                        Dim dtr_fila As DataRow = dtt_pedido.NewRow
                        dtr_fila(0) = dtr_filaaux(0)
                        dtr_fila(1) = 1
                        dtr_fila(2) = dtr_filaaux(1)
                        dtr_fila(3) = dtr_filaaux(2)
                        dtr_fila(4) = dtr_filaaux(3)
                        dtr_fila(5) = Trim("T".PadRight(5))
                        dtr_fila(6) = 0
                        dtr_fila(7) = dtr_fila(2)
                        dtr_fila(8) = 1     'nuevo
                        dtr_fila(9) = dtr_filaaux(3)
                        dtt_pedido.Rows.Add(dtr_fila)
                        btn_gguardar.Enabled = True
                        btn_pproforma.Enabled = True
                        btn_AAgendar.Enabled = True

                    Next
                    Call CalcularTotal()
                End If
            End If
        End If
        'Quita la selecci�n de item que se escogio en perfiles
        '''lst_perfil.SetSelected(lst_perfil.SelectedIndex, False)
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
    End Sub
    Private Sub lst_perfil_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Insertar_perfil_en_pedido()
    End Sub

    Private Sub lst_perfil_DblClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''frm_refer_main_form.escribemsj("Cargando Perfil...")
        'Insertar_perfil_en_pedido()
        ''frm_refer_main_form.escribemsj("DISPONIBLE")
    End Sub

#End Region

#End Region

    Private Sub cmb_medico_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_medico.MouseEnter
        Me.ToolTipPedido.SetToolTip(cmb_medico, Trim(Mid(cmb_medico.Text, 1, 50)))
    End Sub

    Private Sub cmb_ped_tipo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.ToolTipPedido.SetToolTip(cmb_convenio, "Tipo de pedido")
    End Sub

    Private Sub txt_filtro_nombre_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_filtro_nombre.MouseEnter
        If (rbtn_nombre.Checked = True) Then
            Me.ToolTipPedido.SetToolTip(txt_filtro_nombre, "Ingrese el nombre del Test")
        Else
            Me.ToolTipPedido.SetToolTip(txt_filtro_nombre, "Ingrese el codigo del Test")
        End If
    End Sub

    'Private Sub dgrd_test_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_test.Enter
    '    dgrd_test.UnSelect(dgrd_test.CurrentCell.RowNumber)
    '    dgrd_test.Select(0)
    '    celdaanteriorped = 0
    'End Sub

    'Private Sub dgrd_test_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_test.Leave
    '    dgrd_test.UnSelect(dgrd_test.CurrentCell.RowNumber)
    '    celdaanteriorped = 0
    'End Sub

    'Private Sub btn_LeerCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LeerCaja.Click
    '    abro el formulario para Leer un Pedido desde las Cajas
    '    Dim str_tagaux As String
    '    str_tagaux = Me.Tag
    '    Dim frm_MDIChild As New frm_LeerCaja()
    '    frm_MDIChild.frm_refer_main = Me.ParentForm
    '    frm_MDIChild.ShowDialog(Me.ParentForm)
    '    Me.Tag = str_tagaux
    'End Sub


    Private Sub Dtp_ped_fecing_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_ped_fecing.ValueChanged
        If (Dtp_ped_fecing.Text <> "") Then
            lst_pedidos.Items.Clear()
            dts_lista.Clear()
            actualizaConv()
        End If
    End Sub

    Private Sub btn_recibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_recibo.Click
        impresionrecibo()
    End Sub

    Function impresionrecibo()
        Dim titulo As String = "RECIBO"
        If dtt_pedido.Rows.Count > 0 Then
            Try
                m_cls_dgimpresion = New cls_dgimpresion(dgrd_pedido, PrintDocument1, dtv_pedido, lbl_nombres.Text, lbl_total.Text, lbl_doc.Text, lbl_his_clinica.Text, Dtp_ped_fecing.Text, titulo, cmb_convenio.Text, cmb_servicios.Text, recib, lbl_grado.Text, lbl_fecing.Text, Trim(Ctl_txt_ped_antecedente.Text), cmb_turno.Text)
                PrintPreviewDialog1.ShowDialog()
                Me.Refresh()
            Catch iex As System.Drawing.Printing.InvalidPrinterException
                MsgBox("Error En la Impresora", MsgBoxStyle.Exclamation, "ANALISYS")
            End Try
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Function

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.Text = "RECIBO"
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

    Private Sub cmb_ped_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prioridad = Split(cmb_convenio.Text, "/")
        cmb_servicios.Focus()
    End Sub


    Private Sub btn_asp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm_MDIChild As New Ingreso_Aspirantes()
        frm_MDIChild.frm_refer_main_form = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
    End Sub

    'Private Sub btn_importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_importar.Click
    '    Dim frm_MDIChild As New frm_conexionAS400()
    '    frm_MDIChild.frm_refer_main = Me.ParentForm
    '    frm_MDIChild.ShowDialog(Me.ParentForm)
    'End Sub



    Private Sub txt_HistCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = (Convert.ToChar(Keys.Enter)) Then
            If txt_doc.Text = "" Then
                MsgBox("Ingrese al menos un caracter para iniciar la busqueda.", MsgBoxStyle.Information, "ANALISYS")
                txt_doc.Focus()
            Else
                Dim pacid As String = Nothing
                Dim pacienteA As String = Nothing
                Dim pacienteN As String = Nothing
                Dim edad As String = Nothing
                Dim usafec As Integer = 0
                Dim direccion As String = Nothing
                Dim genero As String = Nothing
                Dim afiliacion As String = Nothing
                Dim fec_nac As Date = Nothing
                Dim fecing As String = Nothing
                Dim pachc As String = Nothing
                Dim grado As String = Nothing
                Dim pac_fono As String = Nothing

                opr_paciente.buscapacienteHC(txt_doc.Text, pachc, pacienteA, pacienteN, edad, direccion, genero, usafec, afiliacion, fec_nac, fecing, pacid, grado, pac_fono)
                If pacienteA <> Nothing Then
                    lbl_nombres.Text = pacienteA & " " & pacienteN
                    lbl_edad.Text = edad
                    lbl_his_clinica.Text = pacid
                    lng_pac_id = pacid
                    lbl_direccion_fono.Text = direccion
                    lbl_doc.Text = txt_doc.Text
                    lbl_genero.Text = genero
                    lbl_grado.Text = afiliacion
                    lbl_fecing.Text = fecing
                    lbl_fono.Text = pac_fono

                Else
                    lbl_nombres.Text = ""
                    lbl_edad.Text = ""
                    lbl_his_clinica.Text = ""
                    lbl_direccion_fono.Text = ""
                    lbl_doc.Text = ""
                    lbl_genero.Text = ""

                    'MsgBox("No existe un paciente con ese No. de Historia Clinica", MsgBoxStyle.Exclamation, "ANALISYS")
                    If Not ExisteForm("frm_Paciente2") Then
                        Dim frm_MDIChild As New frm_Paciente2()
                        frm_MDIChild.frm_refer_main_form = frm_refer_main_form
                        frm_MDIChild.MdiParent = frm_refer_main_form.ParentForm
                        frm_MDIChild.par_hc = txt_doc.Text
                        frm_MDIChild.ShowDialog(frm_refer_main_form.ParentForm)
                    End If

                End If
                txt_doc.Text = ""
                cmb_servicios.Focus()
                Me.Tag = Nothing
            End If
        End If
    End Sub

    Private Sub dgrd_pedido_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_pedido.KeyUp
        'Operaciones al precionar CURSOR DE ARRIBA O ABAJO, sobre el grid y controla que siempre exista una celda seleccionada
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub dgrd_pedido_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_pedido.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            'Operaciones al precionar DELETE sobre el grid
            Eliminar(1)
        End If
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub dgrd_pedido_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_pedido.DoubleClick
        'Operaciones al precionar DOBLE CLICK sobre el grid
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub dgrd_pedido_CurrentCellChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_pedido.CurrentCellChanged
        'selecciono toda la fila del grid
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub dgrd_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_pedido.Click
        'Operaciones al precionar CLICK sobre el grid
        Grid_Seleccionar_Celda_Ped()
    End Sub





    Private Sub pic_min_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Pic_close_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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




    Function modifica_pedido(ByVal turno As String)

        If turno <> "" Then

            If sht_ped_turno <> CShort(cmb_turno.Text) Then
                boo_existeturno = opr_pedido.Existeturno(Dtp_ped_fecing.Value, CShort(cmb_turno.Text), , , Me.cmb_convenio.Text)
                sht_ped_turno = CShort(cmb_turno.Text)
            End If
            'codigo para evitar un mismo turno el mismo dia.
            If str_fecha_ori <> CStr(Format(Dtp_ped_fecing.Value, "dd/MM/yyyy")) Then
                boo_existeturno = opr_pedido.Existeturno(Dtp_ped_fecing.Value, CShort(cmb_turno.Text), , , Me.cmb_convenio.Text)
                str_fecha_ori = ""
            End If
            If boo_existeturno Then
                MsgBox("El TURNO ya existe, ingrese uno diferente", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                If opr_pedido.ActualizarPedido(Me) <> 0 Then
                    If MsgBox("Desea imprimir etiquetas para este pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                        'Abrir_frmMuestras(2)
                        Abrir_frmImprimiendo()
                        GC.Collect()
                        Me.Close()
                    Else
                        Abrir_frmPedidos()
                        GC.Collect()
                    End If

                End If
            End If
        End If
    End Function




    Private Sub txt_doc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_doc.KeyPress
        If e.KeyChar = (Convert.ToChar(Keys.Enter)) Then
            If txt_doc.Text = "" Then
                MsgBox("Ingrese al menos un caracter para iniciar la busqueda.", MsgBoxStyle.Information, "ANALISYS")
                txt_doc.Focus()
            Else
                Dim pacid As String = Nothing

                Dim edad As String = Nothing
                Dim usafec As Integer = 0
                Dim direccion As String = Nothing
                Dim genero As String = Nothing
                Dim afiliacion As String = Nothing
                Dim fecing As String = Nothing
                Dim fec_nac As Date = Nothing
                Dim pachc As String = Nothing
                Dim grado As String = Nothing
                Dim pac_fono As String = Nothing
                opr_paciente.buscapacienteHC(txt_doc.Text, pachc, pacienteA, pacienteN, edad, direccion, genero, usafec, afiliacion, fec_nac, fecing, pacid, grado, pac_fono)
                If pachc <> Nothing Then
                    lbl_nombres.Text = pacienteA & " " & pacienteN
                    lbl_edad.Text = edad
                    lbl_his_clinica.Text = pacid
                    lng_pac_id = pacid
                    lbl_direccion_fono.Text = direccion
                    lbl_fono.Text = pac_fono
                    lbl_doc.Text = txt_doc.Text
                    lbl_genero.Text = genero
                    txt_obs_pac.Text = afiliacion
                    lbl_fecnac.Text = fec_nac
                    lbl_fecing.Text = fecing
                    cmb_afiliacion.Text = Trim(grado)
                    If opr_paciente.CuentaHistorico(Trim(txt_doc.Text)) >= 1 Then
                        pic_historico.Visible = True
                        'lnk_historico.Visible = True
                    Else
                        pic_historico.Visible = False
                        'lnk_historico.Visible = False
                    End If

                Else
                    lbl_nombres.Text = ""
                    lbl_edad.Text = ""
                    lbl_his_clinica.Text = ""
                    lbl_direccion_fono.Text = ""
                    lbl_doc.Text = ""
                    lbl_genero.Text = ""
                    txt_obs_pac.Text = ""
                    pic_historico.Visible = False
                    'lnk_historico.Visible = False

                    If Not ExisteForm("frm_Paciente2") Then

                        Dim frm_MDIChild As New frm_Paciente2()
                        frm_MDIChild.frm_refer_main_form = frm_refer_main_form
                        frm_MDIChild.MdiParent = frm_refer_main_form.ParentForm
                        frm_MDIChild.par_hc = txt_doc.Text
                        frm_MDIChild.txt_hisClinica.Text = txt_doc.Text
                        frm_MDIChild.ShowDialog(frm_refer_main_form.ParentForm)

                    End If

                End If
                'txt_doc.Text = ""
                cmb_convenio.Focus()
                Me.Tag = Nothing
            End If
        End If
    End Sub


    Private Sub PictureBox6_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "CONVENIOS"
    End Sub

    Private Sub btn_gguardar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "GUARDAR PEDIDO"
    End Sub

    Private Sub PictureBox5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "SALIR"
    End Sub

    Private Sub btn_eetiquetas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "ETIQUETAS"
    End Sub

    Private Sub btn_pproforma_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "PROFORMA"
    End Sub

    Private Sub btn_ssalir_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "GENERAR FACTURA"
    End Sub

    Private Sub btn_buscar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "BUSCAR PACIENTE"
    End Sub

    Private Sub btn_nuevo_doctor_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "BUSCAR MEDICO"
    End Sub



    Function lee_pedido(ByVal ped_id As String)

        On Error Resume Next

        Dim dts_pedido As DataSet
        Dim dtr_fila As DataRow
        Dim opr_pedido As New Cls_Pedido()

        dtt_pedido.Clear()
        dts_pedido.Clear()

        If Trim(ped_id) <> "" Then
            dts_pedido = opr_pedido.LeerUnPedido(ped_id)
            sht_ped_turno = 0
            str_fecha_ori = ""

            recib = ped_id
            'Cambio para visualizar el n�mero de pedido que se ingreso manualmente
            'para modificar el pedido, menos el n�mero de pedido
            'Ctl_txt_num_Pedido.Text = Me.Tag
            'Ctl_txt_num_Pedido.Enabled = False

            For Each dtr_fila In dts_pedido.Tables("Registros").Rows
                lbl_doc.Text = dtr_fila("pac_doc").ToString
                txt_doc.Text = dtr_fila("pac_doc").ToString
                lbl_nombres.Text = dtr_fila("pac_apellido") & " " & dtr_fila("pac_nombre")
                pac_id = dtr_fila("pac_id")
                'pacienteN = dtr_fila("pac_nombre")
                lbl_his_clinica.Text = dtr_fila("pac_hist_clinica")
                lbl_direccion_fono.Text = dtr_fila("pac_direccion")
                lbl_fono.Text = dtr_fila("pac_fono")
                Dtp_ped_fecing.Value = Format(CDate(dtr_fila("ped_fecing").ToString), "dd/MM/yyyy")
                'Ctl_txt_ped_antecedente.texto_Asigna(dtr_fila("ped_antecedente").ToString)
                Ctl_txt_medicacion.texto_Asigna(dtr_fila("ped_medicacion").ToString)
                cmb_convenio.Text = dtr_fila("ped_tipo").ToString.PadRight(50) & "/" & dtr_fila("sec_desde").ToString.PadRight(4) & "/" & dtr_fila("sec_hasta").ToString.PadRight(4)
                cmb_convenio.Text = dtr_fila("con_nombre").ToString
                'cmb_medico.Text = dtr_fila("med_nombre").ToString.PadRight(100) & dtr_fila("med_id").ToString.PadRight(5) & dtr_fila("med_mail").ToString().PadRight(100)
                cmb_medico.Text = dtr_fila("med_nombre").ToString.PadRight(100) & dtr_fila("med_id").ToString.PadRight(5)
                cmb_laboratorio.Text = dtr_fila("lab_nombre").ToString.PadRight(100) & dtr_fila("lab_id").ToString.PadRight(10)
                cmb_turno.Text = dtr_fila("ped_turno").ToString
                lbl_fecing.Text = dtr_fila("pac_parentesco").ToString
                cmb_afiliacion.Text = dtr_fila("pac_grado").ToString
                txt_recibo.Text = dtr_fila("ped_antecedente").ToString
                lbl_genero.Text = dtr_fila("pac_sexo").ToString
                Dim fecha As Date = dtr_fila("pac_fecnac")
                lbl_fecnac.Text = dtr_fila("pac_fecnac")
                If dtr_fila("pac_usafecnac").ToString = "1" Then
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


                If dtr_fila("ped_servicio").ToString = "" Then
                    cmb_servicios.SelectedIndex = 0
                Else
                    cmb_servicios.Text = dtr_fila("ped_servicio").ToString
                End If
                txt_obs_pac.Text = dtr_fila("pac_obs").ToString

                lbl_his_clinica.Text = dtr_fila("pac_hist_clinica").ToString
                'Ctl_txt_turno.texto_Asigna(dtr_fila("ped_turno").ToString)
                sht_ped_turno = CInt(cmb_turno.Text)
                str_fecha_ori = Format(Me.Dtp_ped_fecing.Value, "dd/MM/yyyy")

                txt_NumAux.Text = dtr_fila("PED_NUMAUX").ToString


                cmb_PrePost.Text = Trim(dtr_fila("PED_NOTA").ToString)
                'sht_ped_turno = Ctl_txt_turno.texto_Recupera
                btn_recibo.Enabled = True
                If dtr_fila("ped_estado") = 9 Then
                    'rbtn_recibo.Checked = True
                    rbtn_pedido.Checked = False

                Else
                    'rbtn_recibo.Checked = False
                    rbtn_pedido.Checked = True
                End If

                Ctl_txt_ped_antecedente.Text = dtr_fila("PED_OBS").ToString
            Next
            Dim convenio As String()
            convenio = Split(Trim(cmb_convenio.Text), "/")
            opr_pedido.LlenarGridUnPedido(dtt_pedido, Trim(convenio(0)), CLng(ped_id))
            CalcularTotal()
            Grp_pedido.Enabled = True
            dgrd_pedido.Enabled = True
            btn_nuevo.Enabled = False
            lkl_pac_buscar.Enabled = True
            lkl_Dr_nuevo.Enabled = True
            btn_duplicado.Enabled = False
            dts_pedido.Dispose()

            Grp_paciente.Enabled = False
            Grp_pedido.Enabled = False
            grp_test.Enabled = False
        End If

    End Function



    Function lee_pedido_His(ByVal ped_id As String)

        On Error Resume Next

        Dim dts_pedido As DataSet
        Dim dtr_fila As DataRow
        Dim opr_pedido As New Cls_Pedido()

        dtt_pedido.Clear()
        dts_pedido.Clear()

        If Trim(ped_id) <> "" Then
            dts_pedido = opr_pedido.LeerUnPedido(ped_id)
            sht_ped_turno = 0
            str_fecha_ori = ""

            recib = ped_id
            'Cambio para visualizar el n�mero de pedido que se ingreso manualmente
            'para modificar el pedido, menos el n�mero de pedido
            'Ctl_txt_num_Pedido.Text = Me.Tag
            'Ctl_txt_num_Pedido.Enabled = False

            For Each dtr_fila In dts_pedido.Tables("Registros").Rows
                lbl_doc.Text = dtr_fila("pac_doc").ToString
                txt_doc.Text = dtr_fila("pac_doc").ToString
                lbl_nombres.Text = dtr_fila("pac_apellido") & "  " & dtr_fila("pac_nombre")
                lbl_his_clinica.Text = dtr_fila("pac_hist_clinica")
                lbl_direccion_fono.Text = dtr_fila("pac_direccion") & "  /  " & dtr_fila("pac_fono")
                'Dtp_ped_fecing.Value = Format(CDate(dtr_fila("ped_fecing").ToString), "dd/MM/yyyy")
                'Ctl_txt_ped_antecedente.texto_Asigna(dtr_fila("ped_antecedente").ToString)
                Ctl_txt_medicacion.texto_Asigna(dtr_fila("ped_medicacion").ToString)
                'cmb_convenio.Text = dtr_fila("ped_tipo").ToString.PadRight(50) & "/" & dtr_fila("sec_desde").ToString.PadRight(4) & "/" & dtr_fila("sec_hasta").ToString.PadRight(4)
                'cmb_convenio.Text = dtr_fila("con_nombre").ToString
                'cmb_medico.Text = dtr_fila("med_nombre").ToString.PadRight(100) & dtr_fila("med_id").ToString.PadRight(10) & dtr_fila("med_mail").ToString().PadRight(100)
                'cmb_laboratorio.Text = dtr_fila("lab_nombre").ToString.PadRight(100) & dtr_fila("lab_id").ToString.PadRight(10)
                cmb_turno.Text = dtr_fila("ped_turno").ToString
                'lbl_fecing.Text = dtr_fila("pac_parentesco").ToString
                'txt_recibo.Text = dtr_fila("ped_antecedente").ToString
                'lbl_genero.Text = dtr_fila("pac_sexo").ToString
                'Dim fecha As Date = dtr_fila("pac_fecnac")
                'lbl_fecnac.Text = dtr_fila("pac_fecnac")
                'If dtr_fila("pac_usafecnac").ToString = "1" Then
                '    'funcion para calcular la edad del paciente
                '    Dim y, yn As Integer
                '    Dim m, mn As Integer
                '    Dim d, dn As Integer
                '    lbl_edad.Text = ""
                '    y = Year(Now)
                '    yn = Year(fecha)
                '    m = Month(Now)
                '    mn = Month(fecha)
                '    d = Microsoft.VisualBasic.Day(Now)
                '    dn = Microsoft.VisualBasic.Day(fecha)
                '    If dn <= d Then
                '        d = d - dn
                '    Else
                '        d = d + 30
                '        m = m - 1
                '        d = d - dn
                '    End If
                '    If mn <= m Then
                '        m = m - mn
                '    Else
                '        m = m + 12
                '        y = y - 1
                '        m = m - mn
                '    End If
                '    y = y - yn
                '    If (y < 2) Then
                '        If y < 1 Then
                '            If m > 0 Then
                '                lbl_edad.Text = m & " meses"
                '            Else
                '                lbl_edad.Text = d & " d�as"
                '            End If
                '        Else
                '            lbl_edad.Text = y & " a�o y " & m & " meses"
                '        End If
                '    Else
                '        lbl_edad.Text = y & " a�os "
                '    End If
                '    '**********
                'Else
                '    lbl_edad.Text = "--"
                'End If


                'If dtr_fila("ped_servicio").ToString = "" Then
                '    cmb_servicios.SelectedIndex = 0
                'Else
                '    cmb_servicios.Text = dtr_fila("ped_servicio").ToString
                'End If
                'lbl_his_clinica.Text = dtr_fila("pac_hist_clinica").ToString
                'Ctl_txt_turno.texto_Asigna(dtr_fila("ped_turno").ToString)
                sht_ped_turno = CInt(cmb_turno.Text)
                'str_fecha_ori = Format(Me.Dtp_ped_fecing.Value, "dd/MM/yyyy")

                'txt_NumAux.Text = dtr_fila("PED_NUMAUX").ToString
                'sht_ped_turno = Ctl_txt_turno.texto_Recupera
                'btn_recibo.Enabled = True
                'If dtr_fila("ped_estado") = 9 Then
                '    'rbtn_recibo.Checked = True
                '    rbtn_pedido.Checked = False

                'Else
                '    'rbtn_recibo.Checked = False
                '    rbtn_pedido.Checked = True
                'End If
            Next
            Dim convenio As String()
            convenio = Split(Trim(cmb_convenio.Text), "/")
            opr_pedido.LlenarGridUnPedido(dtt_pedido, Trim(convenio(0)), CLng(ped_id))
            CalcularTotal()
            Grp_pedido.Enabled = True
            dgrd_pedido.Enabled = True
            btn_nuevo.Enabled = True
            btn_pproforma.Enabled = True
            btn_AAgendar.Enabled = True
            btn_gguardar.Enabled = True
            lkl_pac_buscar.Enabled = True
            lkl_Dr_nuevo.Enabled = True

            'btn_duplicado.Enabled = False
            dts_pedido.Dispose()

            'Grp_paciente.Enabled = False
            'Grp_pedido.Enabled = False
            'grp_test.Enabled = False
        End If

    End Function



    Private Sub btn_eeditar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "EDITAR"
    End Sub

    Private Sub btn_nnuevo_Click_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "AÑADIR"
    End Sub




    Private Sub btn_cconvertir_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "CONVERTIR A ORDEN"
    End Sub

    Private Sub btn_cconvertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btn_aanular_click_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Text = "ANULAR ORDEN"
    End Sub

    Private Sub btn_aanular_click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_nnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nnuevo.Click
        Dim opr_pedido As New Cls_Pedido()
        'If (opr_pedido.ContarPedidoTotal) = 1 Then
        If System.Configuration.ConfigurationSettings.AppSettings("INTERFACE") = True Then
            lbl_InterfaceNombre.Text = System.Configuration.ConfigurationSettings.AppSettings("NOMBRE")
            pic_interface.Visible = True
        Else
            lbl_InterfaceNombre.Text = ""
            pic_interface.Visible = False
        End If

        txt_NumAux.Text = CStr(opr_pedido.LeerMaxNumAux(Dtp_ped_fecing.Value))

        If System.Configuration.ConfigurationSettings.AppSettings("TCodigo") = True Then
            txt_NumAux.ReadOnly = False
        Else
            txt_NumAux.ReadOnly = True
        End If

        ' btn_GLab.PerformClick()
        If (opr_pedido.ContarPedido()) = 1 Then
            Limpia()
            Grp_paciente.Enabled = True
            Grp_pedido.Enabled = True
            grp_test.Enabled = True
            txt_doc.Enabled = True
            btn_eetiqueta.Enabled = False 'ETIQUETAS
            btn_eeditar.Enabled = False 'EDITAR
            btn_convertir.Enabled = False 'CONVERTIR A ORDEN
            btn_gguardar.Enabled = False ' GUARDAR
            btn_pproforma.Enabled = False ' PROFORMA
            btn_ssalir.Enabled = True ' SALIR
            btn_ffactura.Enabled = False ' FACTURA
            btn_cconvenio.Enabled = False 'IMPRESION DEL PEDIDO 
            btn_AAgendar.Enabled = False ' AGENDAR
            txt_doc.Focus()
            Me.Tag = ""

        Else
            Limpia()
            Grp_paciente.Enabled = False
            Grp_pedido.Enabled = False
            grp_test.Enabled = False
            txt_doc.Enabled = True
            btn_eetiqueta.Enabled = False 'ETIQUETAS
            btn_eeditar.Enabled = False 'EDITAR
            btn_convertir.Enabled = False 'CONVERTIR A ORDEN
            btn_gguardar.Enabled = False ' GUARDAR
            btn_pproforma.Enabled = False ' PROFORMA
            btn_ssalir.Enabled = True ' SALIR
            btn_ffactura.Enabled = False ' FACTURA
            btn_AAgendar.Enabled = False ' AGENDAR
            Me.Tag = ""
        End If
        'End If
    End Sub

    Private Sub btn_eeditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eeditar.Click
        If System.Configuration.ConfigurationSettings.AppSettings("ControlCancelado") = True Then
            If lbl_saldo.Text <> "CANCELADO" Then

                Dim msg As String = "Desea modificar la ORDEN: " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString()
                If MsgBox(msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "ANALISYS") = MsgBoxResult.Yes Then
                    btn_pproforma.Enabled = False
                    btn_ssalir.Enabled = True
                    btn_eetiqueta.Enabled = False
                    btn_gguardar.Enabled = True

                    Grp_paciente.Enabled = True
                    Grp_pedido.Enabled = True
                    grp_test.Enabled = True
                    txt_doc.Enabled = False

                    Me.Tag = dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString
                Else
                    Me.Tag = Nothing
                End If
            Else
                opr_pedido.VisualizaMensaje("LA ORDEN SE ENCUENTRA CANCELADA, POR FAVOR GENERE UNA NUEVA ORDEN", 300)
            End If
        Else
            'If lbl_saldo.Text <> "CANCELADO" Then
            Dim msg As String = "Desea modificar la ORDEN: " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString()
            If MsgBox(msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "ANALISYS") = MsgBoxResult.Yes Then
                'If lbl_saldo.Text <> "CANCELADO" Then
                btn_pproforma.Enabled = False
                btn_ssalir.Enabled = True
                btn_eetiqueta.Enabled = False
                btn_gguardar.Enabled = True

                Grp_paciente.Enabled = True
                Grp_pedido.Enabled = True
                grp_test.Enabled = True
                txt_doc.Enabled = False

                Me.Tag = dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString
            Else
                Me.Tag = Nothing
            End If
        End If
        'Else
        'opr_pedido.VisualizaMensaje("LA ORDEN SE ENCUENTRA CANCELADA, POR FAVOR GENERE UNA NUEVA ORDEN", 300)
        'End If
        'End If
    End Sub

    Private Sub btn_aanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aanular.Click
        On Error Resume Next
        Dim FecAnula As String = Mid(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString, 3, 2) & "-" & Mid(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString, 1, 2) & "-" & Format(Now, "yyyy")
        If MsgBox("Desea anular la orden No. " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString & " con fecha: " & FecAnula, MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Dim msg As String = Nothing
            Dim comentario As String = Nothing
            Dim j As Integer
            Dim exas As String = Nothing

            msg = "Ingrese el motivo de la anulacion: "
            comentario = InputBox(msg, "ANALISYS")

            If comentario <> "" Then

                opr_pedido.AnularPedido(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString)

                opr_pedido.EliminaFactura(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(15).ToString)

                Dim str_sql As String = "update PEDIDO set PED_ESTADO = 2 where PED_ID = " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & ""
                For j = 0 To dtt_pedido.Rows.Count
                    'dgrd_pedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 6)
                    exas = exas & dgrd_pedido.Item(j, 2) & "º"
                Next

                g_opr_usuario.CargarTransaccion(g_str_login, "1 ANULA ORDEN", "PEDIDO=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & exas & " MOTIVO: " & comentario, g_sng_user, dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString, "", "")

                opr_pedido.anularReg(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString)
                lst_pedidos.Items.Clear()
                actualizaConv()
                ' dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, Trim(prioridad(0)), g_str_unidad, 0)
            End If
        End If

    End Sub

    Private Sub btn_cconvenio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cconvenio.Click
        ' '' ''ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_pedido()
        Dim frm_ref_main As Frm_Main = Me.ParentForm
        Dim str_edad As String = Nothing
        Dim unidad As String = Nothing
        Dim fecha_nac As String = Nothing
        Dim pos As Integer = 0

        pos = lst_pedidos.SelectedIndex
        lst_pedidos.SelectedIndex = pos
        If pos >= 0 Then
            fecha_nac = Trim(Mid(lst_pedidos.Items.Item(pos), 130, 85))
        End If



        str_edad = opr_pedido.CalculaEdad(fecha_nac, unidad)
        str_edad = str_edad & " " & unidad


        str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_obs as ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, " & _
            "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
            "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, '" & str_edad & "' as edad  " & _
            "from paciente, pedido, medico, laboratorio, pedido_detalle, perfil where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id " & _
            "UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_obs as ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad,  tes_nombre as prueba, " & _
            "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
            "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, '" & str_edad & "' as edad  " & _
            "from paciente, pedido, medico, laboratorio, pedido_detalle,  test where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_ref_main.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_ref_main.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Pedido"
        frm_ref_main.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Default

        g_opr_usuario.CargarTransaccion(g_str_login, "03 IMPRIMIR PEDIDO", "PEDIDO=" & g_lng_ped_id, g_sng_user, g_lng_ped_id, "", "")
        'Dim frm_MDIChild As New Ingreso_Aspirantes()
        'frm_MDIChild.frm_refer_main_form = Me.ParentForm
        'frm_MDIChild.ShowDialog(Me.ParentForm)

    End Sub

    Private Sub btn_gguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gguardar.Click
        Dim boo_recibo As Boolean = False
        lbl_alertas.Text = ""
        If txt_doc.Text <> "" Then
            If lbl_nombres.Text = "" Then
                '' MsgBox("Los nombres del paciente son obligatorios", MsgBoxStyle.Exclamation, "ANALISYS")
                opr_negocio.VisualizaMensaje("Los nombres del paciente son obligatorios", g_tiempo)
            Else
                If dtt_pedido.Rows.Count = 0 Then
                    ''MsgBox("Debe seleccionar por lo menos un test", MsgBoxStyle.Exclamation, "ANALISYS")
                    opr_negocio.VisualizaMensaje("Debe seleccionar por lo menos un examen", g_tiempo)
                Else

                    Dim opr_pedido As New Cls_Pedido()
                    Dim boo_existeturno As Boolean = False
                    'Dim opr_as400 As New Cls_AS400()
                    If Me.Tag <> "" Then
                        If opr_pedido.ActualizarPedido(Me) <> 0 Then
                            If MsgBox("Desea imprimir etiquetas para esta ORDEN?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                                Abrir_frmImprimiendo()
                                '***
                                Grp_paciente.Enabled = False
                                Grp_pedido.Enabled = False
                                grp_test.Enabled = False
                                txt_doc.Enabled = True
                                btn_eetiqueta.Enabled = False 'ETIQUETAS
                                btn_eeditar.Enabled = False 'EDITAR
                                btn_AAgendar.Enabled = False 'AGENDA
                                btn_convertir.Enabled = False 'CONVERTIR A ORDEN
                                btn_gguardar.Enabled = False ' GUARDAR
                                btn_pproforma.Enabled = False ' PROFORMA
                                btn_ssalir.Enabled = True ' SALIR
                                btn_ffactura.Enabled = False ' FACTURA
                                'txt_doc.Text = Format(opr_pedido.LeerMaxCodigo(), "0000000000")
                                Me.Tag = ""
                                Limpia()
                            Else
                                btn_ssalir.Enabled = True 'salir 
                                Grp_paciente.Enabled = False
                                Grp_pedido.Enabled = False
                                grp_test.Enabled = False
                                txt_doc.Enabled = True
                                btn_eetiqueta.Enabled = False 'ETIQUETAS
                                btn_eeditar.Enabled = False 'EDITAR
                                btn_AAgendar.Enabled = False 'AGENDA
                                btn_convertir.Enabled = False 'CONVERTIR A ORDEN
                                btn_gguardar.Enabled = False ' GUARDAR
                                btn_pproforma.Enabled = False ' PROFORMA
                                btn_ssalir.Enabled = True ' SALIR
                                btn_ffactura.Enabled = False ' FACTURA

                                lst_pedidos.Items.Clear()
                                dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)

                                'txt_doc.Text = Format(opr_pedido.LeerMaxCodigo(), "0000000000")
                                Me.Tag = ""
                                Limpia()
                            End If
                        Else
                            opr_negocio.VisualizaMensaje("No se pudo actualizar la ORDEN, contactese con el Administrador", g_tiempo)
                            ''MsgBox("No se pudo actualizar la ORDEN, contactese con el Administrador", MsgBoxStyle.Exclamation, "ANALISYS")
                        End If
                    Else

                        boo_existeturno = False 'opr_pedido.Existeturno(Dtp_ped_fecing.Value, CShort(cmb_turno.Text), , , Me.cmb_ped_tipo.Text)
                        If boo_existeturno Then
                            'MsgBox("El TURNO ya existe, ingrese uno diferente", MsgBoxStyle.Exclamation, "ANALISYS")
                            opr_negocio.VisualizaMensaje("No se pudo actualizar la ORDEN, contactese con el Administrador", g_tiempo)
                        Else
                            ' Cambio exclusivo para el Club de Leones
                            'Pregunto si el pedido existe, en caso de no existir lo almaceno
                            'If opr_pedido.PedidoNuevo(Ctl_txt_num_Pedido.texto_Recupera) = 0 Then
                            'guardar los NUEVOS datos, se envia el formulario por valor
                            ''frm_refer_main_form.escribemsj("GUARDANDO DATOS")
                            Dim x As Long = opr_pedido.LeerMaxPedido()
                            x = x + 1


                            'CUANDO SE TRATA DE PEDIDO
                            If txt_NumAux.Text <> "" Then
                                If opr_pedido.GuardarPedido(Me, lng_pac_id, x, 1, 0, CInt(Mid(cmb_medico.Text, 100, 10))) <> 0 Then
                                    'Si el formulario no se cierra entonces se llamara a la funcion limpia
                                    'una vez almacenado los datos mando a abrir el formulario que
                                    'permitira la impresion de etiquetas de dicho pedido
                                    ''frm_refer_main_form.escribemsj("DISPONIBLE")


                                    Dim auditoria_ex As String = Nothing
                                    Dim aud_detalle As String = Nothing
                                    Dim ii As Integer

                                    For ii = 0 To dtt_pedido.Rows.Count - 1
                                        auditoria_ex = auditoria_ex & Trim(dtt_pedido.Rows(ii).Item(3)) & ","
                                    Next


                                    If auditoria_ex <> "" Then
                                        aud_detalle = " " & Trim(Mid(cmb_convenio.Text, 1, 50)) & " EXAMENES: " & auditoria_ex
                                    Else
                                        aud_detalle = Trim(Mid(cmb_convenio.Text, 1, 50))
                                    End If

                                    g_opr_usuario.CargarTransaccion(g_str_login, "01 GENERAR ORDEN " & aud_detalle, "PEDIDO=" & x, g_sng_user, x, "", "")



                                    'g_opr_usuario.CargarTransaccion(g_str_login, "01 GENERAR ORDEN", "PEDIDO=" & x, g_sng_user, x, "", "")


                                    'opr_pedido.ActualizaCodigo(txt_doc.Text)
                                    'opr_pedido.ActualizarEstadoPedido(


                                    '''If MsgBox("Continuar en ORDENES?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                                    '    'Limpia()
                                    If g_CBautomatico Then
                                        Abrir_frmImprimiendo()

                                        '***
                                        Grp_paciente.Enabled = False
                                        Grp_pedido.Enabled = False
                                        grp_test.Enabled = False
                                        txt_doc.Enabled = True
                                        btn_eetiqueta.Enabled = False 'ETIQUETAS
                                        btn_eeditar.Enabled = False 'EDITAR
                                        btn_convertir.Enabled = False 'CONVERTIR A ORDEN
                                        btn_gguardar.Enabled = False ' GUARDAR
                                        btn_pproforma.Enabled = False ' PROFORMA
                                        btn_ssalir.Enabled = True ' SALIR
                                        btn_ffactura.Enabled = False ' FACTURA
                                        'txt_doc.Text = Format(opr_pedido.LeerMaxCodigo(), "0000000000")
                                        Me.Tag = ""
                                        Limpia()
                                        actualizaConv()
                                        btn_gguardar.Enabled = False
                                        opr_pedido.VisualizaMensaje("Orden registrada correctamente", 240)
                                        '*****
                                        'Else
                                        '    If g_CBautomatico Then
                                        '        Abrir_frmImprimiendo()
                                        '    End If
                                        '    Me.Close()
                                        'End If
                                    Else

                                        btn_pproforma.Enabled = False 'PROFORMA
                                        btn_nnuevo.Enabled = True 'NUEVO
                                        btn_eetiqueta.Enabled = True 'ETIQUETA 
                                        btn_ssalir.Enabled = True 'salir 
                                        cmb_Conve.Text = cmb_Conve.SelectedText

                                        actualizaConv()

                                        pic_historico.Visible = False
                                        btn_gguardar.Enabled = False


                                        opr_pedido.VisualizaMensaje("Orden registrada correctamente", 240)
                                    End If

                                Else
                                    ''frm_refer_main_form.escribemsj("ERRORES AL GUARDAR PEDIDO")
                                End If
                            Else
                                opr_negocio.VisualizaMensaje("Debe ingresar un numero de Codigo Interno", g_tiempo)
                                ''MsgBox("Debe ingresar un numero de Codigo Interno", MsgBoxStyle.Exclamation, "ANALISYS")
                            End If
                        End If
                    End If
                End If
            End If
            If System.Configuration.ConfigurationSettings.AppSettings("ControlFactura") = True Then
                'btn_ffactura.PerformClick()
                'btn_ffactura_Click(sender, e)
                Dim opr_factura As New Cls_Factura
                Dim saldo As Double
                Dim numfact As String = g_lng_ped_nunfact
                str_crea = ""



                Dim fac_Datos As String
                Dim Datosfac_arre As String()
                Dim i As Integer = 0
                Dim DatosFac As String()
                Dim total_Abonos As Double
                Dim opr_fac As New Cls_Factura()

                Datosfac_arre = Split(Recupera_DatosFacFacId(numfact), "º")
                For i = 0 To UBound(Datosfac_arre) - 1
                    DatosFac = Split(Datosfac_arre(i), ",")
                    total_Abonos = TotalAbonos(CDbl(DatosFac(0)))
                    saldo = DatosFac(2) - total_Abonos

                    STR_SQL = "Insert into abono_temp values('" & DatosFac(0) & "', " & total_Abonos & ", " & saldo & ")"
                    opr_fac.GuardaAbonoTemporal(STR_SQL)
                Next


                STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
                     "CASE when PEDIDO.CON_NOMBRE = '" & Trim(cmb_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
                 "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Detalle' as IMP, FAC_LETRAS " & _
                 "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
                 "WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
                 "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"

                dts_registro = New DataSet()
                opr_factura.Obtiene_dato_abono_factura(STR_SQL, numfact, dts_registro)
                saldo = CStr(CDbl(opr_factura.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_factura.LeerSumAbonos(g_lng_ped_nunfact)), 2))


                'AQUI PARA NUEVA FACTURA 
                'CONFIRMO SI LA FACTURA CORRESPONDE A LA FECHA ACTUAL O ES AGENDADA
                If Not ExisteForm("Frm_Factura") Then
                    Dim FrM_MDIChild As New Frm_Factura()
                    'FrM_MDIChild.Show()
                    FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                    FrM_MDIChild.Tag = "1"
                    FrM_MDIChild.fecha_ord = fecha_orden
                    FrM_MDIChild.ShowDialog(Me.ParentForm)

                    Me.lst_pedidos.Items.Clear()
                    actualizaConv()
                    'dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)

                End If


                If str_crea <> "" Then
                    Dim frm_MDIChild As New Frm_reportes(STR_SQL, obj_reporte, dts_registro)
                    frm_MDIChild.int_alto = Me.Height
                    frm_MDIChild.int_ancho = Me.Width
                    frm_MDIChild.Text = str_crea
                    frm_MDIChild.Show()

                End If
                g_lng_ped_id = Nothing

            End If


        Else
            opr_negocio.VisualizaMensaje("Debe ingresar un numero de cedula o en su defecto un numero identificador", g_tiempo)
        End If
    End Sub

    Private Sub btn_pproforma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pproforma.Click
        Dim boo_recibo As Boolean = False

        If lbl_nombres.Text = "" Then
            opr_negocio.VisualizaMensaje("Los nombres del paciente son obligatorios", g_tiempo)
            ''MsgBox("Los nombres del paciente son obligatorios", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If dtt_pedido.Rows.Count = 0 Then
                opr_negocio.VisualizaMensaje("Debe seleccionar por lo menos un examen", g_tiempo)
                ''MsgBox("Debe seleccionar por lo menos un test", MsgBoxStyle.Exclamation, "ANALISYS")
            Else

                Dim opr_pedido As New Cls_Pedido()
                Dim boo_existeturno As Boolean = False
                'Dim opr_as400 As New Cls_AS400()



                If Me.Tag <> "" Then
                    If dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(14).ToString = "P" Then

                        If MsgBox("Desea imrpimir la proforma?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                            Abrir_frmImprimiendo(3)
                        End If

                    Else
                        opr_negocio.VisualizaMensaje("Este pedido no es proforma. No se puede imrprimi", g_tiempo)
                        ''MsgBox("Este pedido no es proforma. No se puede imrprimi", MsgBoxStyle.Exclamation, "ANALISYS")
                        Exit Sub
                    End If
                Else
                    'If dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(14).ToString = "P" Then
                    boo_existeturno = False 'opr_pedido.Existeturno(Dtp_ped_fecing.Value, CShort(cmb_turno.Text), , , Me.cmb_ped_tipo.Text)
                    If boo_existeturno Then
                        MsgBox("El TURNO ya existe, ingrese uno diferente", MsgBoxStyle.Exclamation, "ANALISYS")
                    Else
                        ''frm_refer_main_form.escribemsj("GUARDANDO DATOS")
                        Dim x As Long = opr_pedido.LeerMaxPedido()
                        x = x + 1
                        'If opr_pedido.GuardarPedido(Me, lng_pac_id, CInt(Ctl_txt_num_Pedido.texto_Recupera)) <> 0 Then


                        'CUANDO SE TRATA DE PROFORMA GUARDO CON 1
                        If opr_pedido.GuardarPedido(Me, lng_pac_id, x, 1, 1, CInt(Mid(cmb_medico.Text, 100, 10))) <> 0 Then
                            g_opr_usuario.CargarTransaccion(g_str_login, "PROFORMAR", "PEDIDO=" & x, g_sng_user, x, "", "")
                            'Si el formulario no se cierra entonces se llamar�a a la funci�n limpia
                            'una vez almacenado los datos mando a abrir el formulario que
                            'permitira la impresion de etiquetas de dicho pedido
                            ''frm_refer_main_form.escribemsj("DISPONIBLE")
                            If MsgBox("Continuar ingresando ORDENES?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                                '    'Limpia()
                                Abrir_frmImprimiendo(3)

                                'rfn nuevo
                                lst_pedidos.Items.Clear()
                                dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)
                                btn_pproforma.Enabled = False 'PROFORMA
                            Else

                                Abrir_frmImprimiendo(3)
                                ''Me.Close()
                            End If

                            btn_pproforma.Enabled = True 'PROFORMA
                            btn_nnuevo.Enabled = True 'NUEVO
                            'btn_eetiquetas.Visible = True 'ETIQUETA
                            'rfn nuevo
                            lst_pedidos.Items.Clear()
                            dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)

                        Else
                            ''frm_refer_main_form.escribemsj("ERRORES AL GUARDAR PEDIDO")
                        End If

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_convertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_convertir.Click
        ' boton CONVERTIR A ORDEN
        Dim boo_recibo As Boolean = False

        If lbl_nombres.Text = "" Then
            opr_negocio.VisualizaMensaje("Los nombres del paciente son obligatorios", g_tiempo)
            ''MsgBox("Los nombres del paciente son obligatorios", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If dtt_pedido.Rows.Count = 0 Then
                opr_negocio.VisualizaMensaje("Debe seleccionar por lo menos un examen", g_tiempo)
                ''MsgBox("Debe seleccionar por lo menos un test", MsgBoxStyle.Exclamation, "ANALISYS")
            Else

                Dim opr_pedido As New Cls_Pedido()
                Dim boo_existeturno As Boolean = False
                'Dim opr_as400 As New Cls_AS400()
                If Me.Tag <> "" Then
                    If opr_pedido.ActualizarPedido(Me) <> 0 Then
                        g_opr_usuario.CargarTransaccion(g_str_login, "CONVIERTE PROFORMA", "PEDIDO=" & Me.Tag, g_sng_user, Me.Tag, "", "")
                        If MsgBox("Desea imprimir etiquetas para este pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                            Abrir_frmImprimiendo()
                        End If
                    Else
                        opr_negocio.VisualizaMensaje("No se pudo actualizar la ORDEN, contactese con el Administrador", g_tiempo)
                        ''MsgBox("No se pudo actualizar la ORDEN, contactese con el Administrador", MsgBoxStyle.Exclamation, "ANALISYS")
                    End If
                Else



                End If
            End If
            lst_pedidos.Items.Clear()
            dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)
            btn_ffactura.Enabled = True
        End If
    End Sub

    Private Sub btn_ssalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ssalir.Click
        'cierro el formulario
        boo_cerrar = True
        g_numOrden = Nothing
        g_lng_ped_id = Nothing
        Me.Close()
    End Sub

    Public Function Recupera_DatosFacFacId(ByVal Fac_id As Long) As String
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim str_sql As String = Nothing
        str_sql = "SELECT a.FAC_ID, b.PED_ID, case WHEN a.FAC_DESCUENTO > 0 THEN round((a.FAC_TOTAL - (a.FAC_TOTAL * a.FAC_DESCUENTO)/100 ),2) else a.FAC_TOTAL end AS TOTAL " & _
                  "FROM FACTURA as a, pedido as b, abono as c, invitado as i " & _
                  "WHERE(a.FAC_ESTATUS = 0 Or a.FAC_ESTATUS = 1 Or a.FAC_ESTATUS = 2) " & _
                  "and  a.fac_id = " & Fac_id & _
                  "and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id " & _
                 "and ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO " & _
                  "group by a.FAC_ID, b.PED_ID, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_turno, i.invitado_apellido, i.invitado_nombre "

        Dim dtr_fila As DataRow
        Dim dts_abonos As New DataSet()

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_abonos, "Registros")
        opr_Conexion.sql_desconn()
        For Each dtr_fila In dts_abonos.Tables("Registros").Rows
            Recupera_DatosFacFacId = Recupera_DatosFacFacId & dtr_fila(0).ToString() & "," & dtr_fila(1).ToString() & "," & dtr_fila(2).ToString() & "º"
        Next
        Exit Function

    End Function


    Public Function TotalAbonos(ByVal fac_id As Integer) As Double
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim str_sql As String = "select SUM(round(abo_monto,2)) AS abo_total from ABONO where fac_id = " & fac_id & ""
        Dim dtr_fila As DataRow
        Dim dts_abonos As New DataSet()

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_abonos, "Registros")
        opr_Conexion.sql_desconn()
        For Each dtr_fila In dts_abonos.Tables("Registros").Rows
            TotalAbonos = dtr_fila(0)
        Next
        Exit Function

    End Function

    Private Sub btn_ffactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ffactura.Click

        'boton GENERAR FACTURA

        Dim opr_factura As New Cls_Factura
        Dim saldo As Double
        Dim numfact As String = g_lng_ped_nunfact
        str_crea = ""

        If numfact <> "0" Then

            Dim fac_Datos As String
            Dim Datosfac_arre As String()
            Dim i As Integer = 0
            Dim DatosFac As String()
            Dim total_Abonos As Double
            Dim opr_fac As New Cls_Factura()

            Datosfac_arre = Split(Recupera_DatosFacFacId(numfact), "º")
            For i = 0 To UBound(Datosfac_arre) - 1
                DatosFac = Split(Datosfac_arre(i), ",")
                total_Abonos = TotalAbonos(CDbl(DatosFac(0)))
                saldo = DatosFac(2) - total_Abonos
                If saldo <> 0 Then
                    STR_SQL = "Insert into abono_temp values('" & DatosFac(0) & "', " & total_Abonos & ", " & saldo & ")"
                    opr_fac.GuardaAbonoTemporal(STR_SQL)
                End If
            Next


            STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
                 "CASE when PEDIDO.CON_NOMBRE = '" & Trim(cmb_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
             "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Detalle' as IMP, FAC_LETRAS " & _
             "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
             "WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
             "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"

            dts_registro = New DataSet()
            opr_factura.Obtiene_dato_abono_factura(STR_SQL, numfact, dts_registro)
            saldo = CStr(CDbl(opr_factura.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_factura.LeerSumAbonos(g_lng_ped_nunfact)), 2))

            If saldo > 0 Then

                ' INGRESAR(ABONO)
                If Not ExisteForm("Frm_Factura") Then
                    Dim FrM_MDIChild As New Frm_Factura()

                    FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                    FrM_MDIChild.Tag = "4"
                    FrM_MDIChild.pac_id = pac_id
                    FrM_MDIChild.pac_nombre = Trim(lbl_nombres.Text)
                    FrM_MDIChild.pac_doc = Trim(txt_doc.Text)
                    FrM_MDIChild.ShowDialog(Me.ParentForm)

                    Me.lst_pedidos.Items.Clear()
                    dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)

                End If
            Else
                If Not ExisteForm("Frm_Factura") Then
                    Dim FrM_MDIChild As New Frm_Factura()

                    FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                    FrM_MDIChild.Tag = opr_factura.LeerTransaccion(numfact)
                    FrM_MDIChild.pac_id = pac_id
                    FrM_MDIChild.pac_nombre = Trim(lbl_nombres.Text)
                    FrM_MDIChild.pac_doc = Trim(txt_doc.Text)
                    FrM_MDIChild.ShowDialog(Me.ParentForm)

                    Me.lst_pedidos.Items.Clear()
                    dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)

                End If
            End If

        Else
            'AQUI PARA NUEVA FACTURA 
            'CONFIRMO SI LA FACTURA CORRESPONDE A LA FECHA ACTUAL O ES AGENDADA
            If Not ExisteForm("Frm_Factura") Then
                Dim FrM_MDIChild As New Frm_Factura()
                'FrM_MDIChild.Show()
                FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                FrM_MDIChild.Tag = "1"
                FrM_MDIChild.fecha_ord = fecha_orden
                FrM_MDIChild.pac_id = pac_id
                FrM_MDIChild.ShowDialog(Me.ParentForm)

                Me.lst_pedidos.Items.Clear()
                dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)

            End If

        End If

        If str_crea <> "" Then
            Dim frm_MDIChild As New Frm_reportes(STR_SQL, obj_reporte, dts_registro)
            frm_MDIChild.int_alto = Me.Height
            frm_MDIChild.int_ancho = Me.Width
            frm_MDIChild.Text = str_crea
            frm_MDIChild.Show()

        End If
        g_lng_ped_id = Nothing
    End Sub

    Private Sub btn_eetiqueta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eetiqueta.Click
        'boton IMPRIMIR ETIQUETA
        Abrir_frmImprimiendo()
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
        Dim saldo As String = ""
        pos = lst_pedidos.SelectedIndex
        lst_pedidos.SelectedIndex = pos
        If pos >= 0 Then


            Call lee_pedido(dts_lista.Tables(0).Rows(pos).Item(10).ToString)
            Me.Tag = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_lng_ped_id = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_numOrden = dts_lista.Tables(0).Rows(pos).Item(1).ToString
            g_lng_ped_nunfact = dts_lista.Tables(0).Rows(pos).Item(15).ToString
            Dim opr_fac As New Cls_Factura()


            saldo = CStr(CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), 2))
            If saldo > 0 Then
                lbl_abono.Text = "ABONO " & CStr(Format(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), "$ ###,##0.00"))
                lbl_saldo.Text = "SALDO " & CStr(Format(CDbl(saldo), "$ ###,##0.00"))
                'Format(CDbl(int_precio), "$ ###,##0.00")
            Else

                Select Case saldo

                    Case Is = 0
                        lbl_abono.Text = " PAGO "
                        lbl_saldo.Text = "SIN GENERAR"
                    Case Is < 0
                        lbl_abono.Text = " CREDITO "
                        lbl_saldo.Text = "$ " & saldo * -1
                End Select


                'If CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) > 0 Then
                '    lbl_abono.Text = " PAGO "
                '    lbl_saldo.Text = "CANCELADO"
                'Else
                '    lbl_abono.Text = " PAGO "
                '    lbl_saldo.Text = "SIN GENERAR"
                'End If

            End If
            g_numOrden = Mid(dts_lista.Tables(0).Rows(pos).Item(1).ToString, 5, 4)
            btn_aanular.Enabled = True 'ETIQUETAS
            btn_eeditar.Enabled = True ' EDITAR
            btn_nnuevo.Enabled = True ' NUEVO
            btn_aanular.Enabled = True ' ANULAR
            btn_eetiqueta.Enabled = True ' ETIQUETAS
            'If 
            If g_lng_ped_nunfact <> "ND" Then
                lbl_grado.Text = g_lng_ped_nunfact
            Else
                lbl_grado.Text = "SIN GENERAR"
            End If


            If dts_lista.Tables(0).Rows(pos).Item(14).ToString = "P" Then
                btn_pproforma.Enabled = True ' PROFORMA
                btn_convertir.Enabled = True  ' CONVERTIR A ORDEN
            Else
                'btn_pproforma.Visible = False ' PROFORMA
                btn_convertir.Enabled = False ' CONVERTIR A ORDEN
            End If

            If btn_pproforma.Enabled = True Then 'PROFORMA
                btn_ffactura.Enabled = False 'FACTURA

            Else
                btn_ffactura.Enabled = True 'FACTURA
            End If

        Else

        End If
        lst_pedidos.SelectedIndex = (pos)
    End Sub

    Private Sub lst_pedidos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_pedidos.KeyUp
        Dim pos As Integer = 0
        Dim saldo As String = ""
        pos = lst_pedidos.SelectedIndex
        lst_pedidos.SelectedIndex = pos
        If pos >= 0 Then


            Call lee_pedido(dts_lista.Tables(0).Rows(pos).Item(10).ToString)
            Me.Tag = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_lng_ped_id = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_numOrden = dts_lista.Tables(0).Rows(pos).Item(1).ToString
            g_lng_ped_nunfact = dts_lista.Tables(0).Rows(pos).Item(15).ToString
            Dim opr_fac As New Cls_Factura()


            saldo = CStr(CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), 2))
            If saldo > 0 Then
                lbl_abono.Text = "ABONO " & CStr(Format(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), "$ ###,##0.00"))
                lbl_saldo.Text = "SALDO " & CStr(Format(CDbl(saldo), "$ ###,##0.00"))
                'Format(CDbl(int_precio), "$ ###,##0.00")
            Else


                If CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) > 0 Then
                    lbl_abono.Text = " FACTURA "
                    lbl_saldo.Text = "CANCELADA"
                Else
                    lbl_abono.Text = "  FACTURA "
                    lbl_saldo.Text = "SIN GENERAR"
                End If

            End If
            g_numOrden = Mid(dts_lista.Tables(0).Rows(pos).Item(1).ToString, 5, 4)
            btn_aanular.Enabled = True 'ETIQUETAS
            btn_eeditar.Enabled = True ' EDITAR
            btn_nnuevo.Enabled = True ' NUEVO
            btn_aanular.Enabled = True ' ANULAR
            btn_eetiqueta.Enabled = True ' ETIQUETAS
            'If 
            If g_lng_ped_nunfact <> "ND" Then
                lbl_grado.Text = g_lng_ped_nunfact
            Else
                lbl_grado.Text = "SIN GENERAR"
            End If


            If dts_lista.Tables(0).Rows(pos).Item(14).ToString = "P" Then
                btn_pproforma.Enabled = True ' PROFORMA
                btn_convertir.Enabled = True  ' CONVERTIR A ORDEN
            Else
                'btn_pproforma.Visible = False ' PROFORMA
                btn_convertir.Enabled = False ' CONVERTIR A ORDEN
            End If

            If btn_pproforma.Enabled = True Then 'PROFORMA
                btn_ffactura.Enabled = False 'FACTURA

            Else
                btn_ffactura.Enabled = True 'FACTURA
            End If

        Else

        End If
        lst_pedidos.SelectedIndex = (pos)
    End Sub

    Private Sub btn_GLab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GLab.Click
        'lbl_categoria.Text = "LABORATORIO"
        'Lista_Areas = " area.ARE_ID < 80"
        'tipo = "Examen"
        'cmb_tratante.Enabled = False
        'cmb_tratante.SelectedIndex = 0

        'If Trim(cmb_convenio.Text) <> "" Then
        '    txt_filtro_nombre.Text = ""

        '    Dim Coleccion As New AutoCompleteStringCollection

        '    CargarColeccion(Coleccion, Lista_Areas, cmb_convenio.Text, tipo, dtv_test)
        '    txt_filtro_nombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    txt_filtro_nombre.AutoCompleteSource = AutoCompleteSource.CustomSource
        '    txt_filtro_nombre.AutoCompleteCustomSource = Coleccion


        '    ''txt_filtro_nombre.Font = New Font("Courier New", 8.2!, FontStyle.Regular)


        '    Dim int_indice, int_total, int_indice2 As Integer
        '    For int_indice = 0 To dtt_pedido.Rows.Count - 1
        '        If dtt_pedido.Rows(int_indice).Item(5) = "T" Then
        '            For int_indice2 = 0 To dtv_test.Count - 1
        '                ' ''If dtt_pedido.Rows(int_indice).Item(3) = dgrd_test(int_indice2, 3) Then
        '                ' ''    dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * dgrd_test(int_indice2, 2)
        '                ' ''    Exit For
        '                ' ''End If
        '            Next
        '        Else
        '            ' ''For int_indice2 = 0 To lst_perfil.Items.Count
        '            ' ''    If dtt_pedido.Rows(int_indice).Item(3) = Trim(lst_perfil.Items.Item(int_indice2).substring(100, 10)) Then
        '            ' ''        dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * Val(Trim(lst_perfil.Items.Item(int_indice2).substring(110, 10)))
        '            ' ''        Exit For
        '            ' ''    End If
        '            ' ''Next
        '        End If
        '    Next
        '    Call CalcularTotal()


    End Sub

    Private Sub btn_GMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SVitales.Click

        If g_EsOcupacional <> 0 Then

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim str_ped_id As String
            Dim frm_MDIChild As New frm_HistoriaClinica()
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.pac_id = CInt(lbl_his_clinica.Text)
            frm_MDIChild.lbl_paciente.Text = Trim(lbl_nombres.Text)
            frm_MDIChild.lbl_edad.Text = Trim(lbl_edad.Text)
            frm_MDIChild.var_Convenio = Trim(cmb_convenio.Text)
            frm_MDIChild.var_Fecha = Dtp_ped_fecing.Value
            frm_MDIChild.var_Lab = Trim(cmb_laboratorio.Text)
            frm_MDIChild.var_Servicio = Trim(cmb_servicios.Text)
            frm_MDIChild.var_PrePost = Trim(cmb_PrePost.Text)
            frm_MDIChild.Var_NumAux = Trim(txt_NumAux.Text)
            frm_MDIChild.Var_Ped_id = g_lng_ped_id

            frm_MDIChild.ShowDialog(Me.ParentForm)
            Me.Tag = str_ped_id
            Me.Cursor = System.Windows.Forms.Cursors.Arrow

        Else
            opr_pedido.VisualizaMensaje("Modulo no autorizado, favor consulte con el administrador del sistema", 400)
        End If




    End Sub

    Private Sub btn_GOdon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GOdon.Click
        lbl_categoria.Text = "ODONTOLOGIA"
        Lista_Areas = " area.ARE_ID = 81"
        tipo = "Procedimiento"
        cmb_tratante.Enabled = True
        cmb_tratante.SelectedIndex = 1

        If Trim(cmb_convenio.Text) <> "" Then
            txt_filtro_nombre.Text = ""

            Dim Coleccion As New AutoCompleteStringCollection
            prioridad = Split(cmb_convenio.Text, "/")

            CargarColeccion(Coleccion, Lista_Areas, prioridad(0), tipo, dtv_test)
            txt_filtro_nombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txt_filtro_nombre.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_filtro_nombre.AutoCompleteCustomSource = Coleccion


            ''txt_filtro_nombre.Font = New Font("Courier New", 8.2!, FontStyle.Regular)


            Dim int_indice, int_total, int_indice2 As Integer
            For int_indice = 0 To dtt_pedido.Rows.Count - 1
                If dtt_pedido.Rows(int_indice).Item(5) = "T" Then
                    For int_indice2 = 0 To dtv_test.Count - 1
                        ' ''If dtt_pedido.Rows(int_indice).Item(3) = dgrd_test(int_indice2, 3) Then
                        ' ''    dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * dgrd_test(int_indice2, 2)
                        ' ''    Exit For
                        ' ''End If
                    Next
                Else
                    ' ''For int_indice2 = 0 To lst_perfil.Items.Count
                    ' ''    If dtt_pedido.Rows(int_indice).Item(3) = Trim(lst_perfil.Items.Item(int_indice2).substring(100, 10)) Then
                    ' ''        dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * Val(Trim(lst_perfil.Items.Item(int_indice2).substring(110, 10)))
                    ' ''        Exit For
                    ' ''    End If
                    ' ''Next
                End If
            Next
            Call CalcularTotal()

        End If


    End Sub

    Private Sub btn_GFarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GFarm.Click
        lbl_categoria.Text = "FARMACIA"
        Lista_Areas = " area.ARE_ID = 82"
        tipo = "Farmaco"
        cmb_tratante.Enabled = False
        cmb_tratante.SelectedIndex = 0

        If Trim(cmb_convenio.Text) <> "" Then
            txt_filtro_nombre.Text = ""
            prioridad = Split(cmb_convenio.Text, "/")

            Dim Coleccion As New AutoCompleteStringCollection

            CargarColeccion(Coleccion, Lista_Areas, prioridad(0), tipo, dtv_test)
            txt_filtro_nombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txt_filtro_nombre.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_filtro_nombre.AutoCompleteCustomSource = Coleccion


            ''txt_filtro_nombre.Font = New Font("Courier New", 8.2!, FontStyle.Regular)


            Dim int_indice, int_total, int_indice2 As Integer
            For int_indice = 0 To dtt_pedido.Rows.Count - 1
                If dtt_pedido.Rows(int_indice).Item(5) = "T" Then
                    For int_indice2 = 0 To dtv_test.Count - 1
                        ' ''If dtt_pedido.Rows(int_indice).Item(3) = dgrd_test(int_indice2, 3) Then
                        ' ''    dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * dgrd_test(int_indice2, 2)
                        ' ''    Exit For
                        ' ''End If
                    Next
                Else
                    ' ''For int_indice2 = 0 To lst_perfil.Items.Count
                    ' ''    If dtt_pedido.Rows(int_indice).Item(3) = Trim(lst_perfil.Items.Item(int_indice2).substring(100, 10)) Then
                    ' ''        dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * Val(Trim(lst_perfil.Items.Item(int_indice2).substring(110, 10)))
                    ' ''        Exit For
                    ' ''    End If
                    ' ''Next
                End If
            Next
            Call CalcularTotal()

        End If



    End Sub


    Private Sub btn_GFisio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GFisio.Click
        lbl_categoria.Text = "FISIOTERAPIA"
        Lista_Areas = " area.ARE_ID = 84"
        tipo = "Procedimiento"
        cmb_tratante.Enabled = True
        cmb_tratante.SelectedIndex = 1


        If Trim(cmb_convenio.Text) <> "" Then
            txt_filtro_nombre.Text = ""
            prioridad = Split(cmb_convenio.Text, "/")

            Dim Coleccion As New AutoCompleteStringCollection

            CargarColeccion(Coleccion, Lista_Areas, prioridad(0), tipo, dtv_test)
            txt_filtro_nombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txt_filtro_nombre.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_filtro_nombre.AutoCompleteCustomSource = Coleccion


            ''txt_filtro_nombre.Font = New Font("Courier New", 8.2!, FontStyle.Regular)


            Dim int_indice, int_total, int_indice2 As Integer
            For int_indice = 0 To dtt_pedido.Rows.Count - 1
                If dtt_pedido.Rows(int_indice).Item(5) = "T" Then
                    For int_indice2 = 0 To dtv_test.Count - 1
                        ' ''If dtt_pedido.Rows(int_indice).Item(3) = dgrd_test(int_indice2, 3) Then
                        ' ''    dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * dgrd_test(int_indice2, 2)
                        ' ''    Exit For
                        ' ''End If
                    Next
                Else
                    ' ''For int_indice2 = 0 To lst_perfil.Items.Count
                    ' ''    If dtt_pedido.Rows(int_indice).Item(3) = Trim(lst_perfil.Items.Item(int_indice2).substring(100, 10)) Then
                    ' ''        dtt_pedido.Rows(int_indice).Item(4) = dtt_pedido.Rows(int_indice).Item(1) * Val(Trim(lst_perfil.Items.Item(int_indice2).substring(110, 10)))
                    ' ''        Exit For
                    ' ''    End If
                    ' ''Next
                End If
            Next
            Call CalcularTotal()

        End If

    End Sub

    Private Sub btn_AAgendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AAgendar.Click
        Dim x As Long = opr_pedido.LeerMaxPedido()
        Dim fechaGuardaAgenda As String = Nothing
        Dim SiNoGuardo As Boolean = False
        Dim Varmed As Integer = 0
        x = x + 1

        If Not ExisteForm("Frm_Agenda") Then
            Dim FrM_MDIChild As New Frm_Agenda()

            FrM_MDIChild.frm_refer_main_form = Me.ParentForm
            FrM_MDIChild.Tag = 1
            FrM_MDIChild.VarPac = lng_pac_id
            FrM_MDIChild.NomPac = Trim(lbl_nombres.Text)

            'FrM_MDIChild.NomMed = ''
            FrM_MDIChild.VarPed = x

            FrM_MDIChild.ShowDialog(Me.ParentForm)
            fechaGuardaAgenda = Format(FrM_MDIChild.cal1.SelectionRange.Start, "dd/MM/yyyy") & " " & Format(Now(), "HH:mm:ss")
            SiNoGuardo = FrM_MDIChild.SiNoGuardo
            If FrM_MDIChild.Tag = 1 Then
                If SiNoGuardo Then
                    opr_pedido.GuardarPedido(Me, lng_pac_id, x, 1, 9, fechaGuardaAgenda, CInt(FrM_MDIChild.VarMed))
                    g_opr_usuario.CargarTransaccion(g_str_login, "AGENDAMIENTO", "PEDIDO=" & x, g_sng_user, x, "", "")
                    opr_pedido.ActualizaCodigo(txt_doc.Text)

                    If MsgBox("El pedido ha sido agendado satisfactoriamente, desea seguir ingresando pedidos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                        '    'Limpia()
                        'Abrir_frmImprimiendo()

                        'rfn nuevo
                        'lst_pedidos.Items.Clear()
                        'dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)
                        '***
                        Grp_paciente.Enabled = False
                        Grp_pedido.Enabled = False
                        grp_test.Enabled = False
                        txt_doc.Enabled = True
                        btn_eetiqueta.Enabled = False 'ETIQUETAS
                        btn_eeditar.Enabled = False 'EDITAR
                        btn_convertir.Enabled = False 'CONVERTIR A ORDEN
                        btn_gguardar.Enabled = False ' GUARDAR
                        btn_pproforma.Enabled = False ' PROFORMA
                        btn_ssalir.Enabled = True ' SALIR
                        btn_ffactura.Enabled = False ' FACTURA
                        'txt_doc.Text = Format(opr_pedido.LeerMaxCodigo(), "0000000000")
                        Me.Tag = ""
                        Limpia()
                        '*****
                    Else

                        'Abrir_frmImprimiendo()
                        Me.Close()
                    End If
                    btn_pproforma.Enabled = False 'PROFORMA
                    btn_nnuevo.Enabled = True 'NUEVO
                    btn_eetiqueta.Enabled = True 'ETIQUETA 
                    btn_ssalir.Enabled = True 'salir 
                    'rfn nuevo
                    lst_pedidos.Items.Clear()
                    dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)

                Else
                    ''frm_refer_main_form.escribemsj("ERRORES AL GUARDAR PEDIDO")
                End If

            Else
                'Me.lst_pedidos.Items.Clear()
                'dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)

            End If

            Me.lst_pedidos.Items.Clear()
            dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", g_str_unidad, 0)
        Else

        End If
    End Sub


    Private Sub txt_filtro_nombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_filtro_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
            Insertar_test_en_pedido_txt(Trim(txt_filtro_nombre.Text), Trim(cmb_convenio.Text))
        ElseIf e.KeyCode = Keys.Delete Then

        End If
    End Sub




    Private Sub lkl_pac_buscar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkl_pac_buscar.LinkClicked
        'abro el formulario para seleccioanar un paciente
        Dim str_tagaux As String
        str_tagaux = Me.Tag
        Dim frm_MDIChild As New frm_Paciente3()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        Me.Tag = str_tagaux
    End Sub

    Private Sub lkl_Dr_nuevo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkl_Dr_nuevo.LinkClicked
        'cuando el medico no se encuentra en el combo procedo a crear uno nuevo 
        If Not ExisteForm("Frm_Medico2") Then
            ban = 1
            Dim str_tagaux As String
            str_tagaux = Me.Tag
            Dim FrM_MDIChild As New Frm_medico2()
            FrM_MDIChild.frm_refer_main_form = Me.ParentForm
            FrM_MDIChild.ShowDialog(Me.ParentForm)
            Me.Tag = str_tagaux
        End If
    End Sub



    Private Sub lnk_Codigo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_Codigo.LinkClicked
        txt_NumAux.Text = CStr(opr_pedido.LeerMaxNumAux(Dtp_ped_fecing.Value))

    End Sub



    Public Sub LLena_datos_paciente_His()
        Dim arre_tag As String()
        Dim saldo As String = Nothing

        arre_tag = Split(Me.Tag, "/")

        If CInt(arre_tag(0)) > 0 Then


            Call lee_pedido_His(arre_tag(0))
            Me.Tag = arre_tag(0)
            g_lng_ped_id = arre_tag(0)
            g_numOrden = arre_tag(1)
            g_lng_ped_nunfact = 0
            'txt_NumAux.Text = dts_lista.Tables(0).Rows(pos).Item(16).ToString

            ' Dim opr_fac As New Cls_Factura()


            'fecha_orden = Trim(Format(Now, "yyyy") & "/" & Mid(g_numOrden, 1, 2) & "/" & Mid(g_numOrden, 3, 2))

            'saldo = CStr(CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), 2))
            'If saldo > 0 Then
            '    lbl_abono.Text = "ABONO " & CStr(Format(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), "$ ###,##0.00"))
            '    lbl_saldo.Text = "SALDO " & CStr(Format(CDbl(saldo), "$ ###,##0.00"))
            '    'Format(CDbl(int_precio), "$ ###,##0.00")
            'Else


            '    If CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) > 0 Then
            '        lbl_abono.Text = " PAGO "
            '        lbl_saldo.Text = "CANCELADO"
            '    Else
            '        lbl_abono.Text = " PAGO "
            '        lbl_saldo.Text = "SIN GENERAR"
            '    End If

            'End If
            'g_numOrden = Mid(dts_lista.Tables(0).Rows(pos).Item(1).ToString, 5, 4)
            ' btn_aanular.Enabled = True 'ETIQUETAS
            ' btn_eeditar.Enabled = True ' EDITAR
            ' btn_nnuevo.Enabled = True ' NUEVO
            ' btn_aanular.Enabled = True ' ANULAR
            ' btn_eetiqueta.Enabled = True ' ETIQUETAS
            ' btn_cconvenio.Enabled = True  'IMPRESION DEL PEDIDO 

            'If 
            ''If g_lng_ped_nunfact <> 0 Then
            ''    lbl_grado.Text = g_lng_ped_nunfact
            ''    'btn_ffactura.Visible = True
            ''Else
            ''    lbl_grado.Text = "SIN GENERAR"
            ''    'btn_ffactura.Visible = True
            ''End If


            'If dts_lista.Tables(0).Rows(pos).Item(14).ToString = "P" Then
            '    btn_eetiqueta.Enabled = False
            '    btn_pproforma.Enabled = True ' PROFORMA
            '    btn_convertir.Enabled = True  ' CONVERTIR A ORDEN
            'Else
            '    btn_eetiqueta.Enabled = True
            '    btn_pproforma.Enabled = False ' PROFORMA
            '    btn_convertir.Enabled = False ' CONVERTIR A ORDEN
            'End If

            'If btn_convertir.Enabled = False Then 'CONVERTIR
            '    btn_ffactura.Enabled = True 'FACTURA
            '    btn_cconvenio.Enabled = True  'IMPRESION DEL PEDIDO 

            'Else
            '    btn_ffactura.Enabled = False 'FACTURA
            '    btn_cconvenio.Enabled = False 'IMPRESION DEL PEDIDO 
            'End If

        Else

        End If
    End Sub

    Private Sub pic_historico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_historico.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_ped_id As String
        Dim frm_MDIChild As New frm_BuscaHistorico()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.pac_id = CInt(lbl_his_clinica.Text)
        frm_MDIChild.lbl_paciente.Text = Trim(lbl_nombres.Text)
        frm_MDIChild.ShowDialog(Me.ParentForm)
        Me.Tag = str_ped_id
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub actualizaConv()
        Dim convenio As String

        convenio = Replace(cmb_Conve.Text, "/", ",")
        If convenio = "TODOS" Then
            convenio = "TODOS,0,0"
        End If

        lst_pedidos.Items.Clear()
        'dts_lista.Clear()

        dts_lista = opr_res.LlenaListPedidoConvenio(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0, "TODOS", convenio, 0)

    End Sub


    Private Sub cmb_Conve_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Conve.SelectedIndexChanged

        actualizaConv()
    End Sub



    Private Sub btn_buscaOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaOrden.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'LimpiarCamposVR()
        Dim ped_id As Integer = 0
        Dim i As Integer

        prioridad = Split(cmb_Conve.Text, "/")
        g_CadenaFiltro = Format(Dtp_ped_fecing.Value, "") & "," & Format(Dtp_ped_fecing.Value, "") & "," & Trim(prioridad(0)) & "," & Trim(prioridad(1)) & "," & Trim(prioridad(2)) & ",00,"


        Dim frm_MDIChild As New frm_Busq_Pedidos()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        'areas = ""
        orden = frm_MDIChild.orden

        Dim sw As Boolean = False

        For i = 0 To (lst_pedidos.Items.Count - 1)
            If orden = Trim(Mid(lst_pedidos.Items.Item(i), 4, 8)) Then
                lst_pedidos.SetSelected(i, True)
                sw = True
                Exit For

            End If
        Next

        If sw = False Then
            opr_pedido.VisualizaMensaje("No se encontro el registro", 280)
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    Private Sub lst_pedidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_pedidos.SelectedIndexChanged
        Dim pos As Integer = 0
        Dim saldo As String = ""
        pos = lst_pedidos.SelectedIndex
        lst_pedidos.SelectedIndex = pos
        If pos >= 0 Then


            Call lee_pedido(dts_lista.Tables(0).Rows(pos).Item(10).ToString)
            Me.Tag = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_lng_ped_id = dts_lista.Tables(0).Rows(pos).Item(10).ToString
            g_numOrden = dts_lista.Tables(0).Rows(pos).Item(1).ToString
            g_lng_ped_nunfact = dts_lista.Tables(0).Rows(pos).Item(15).ToString
            'txt_NumAux.Text = dts_lista.Tables(0).Rows(pos).Item(16).ToString

            Dim opr_fac As New Cls_Factura()


            fecha_orden = Trim(Format(Now, "yyyy") & "/" & Mid(dts_lista.Tables(0).Rows(pos).Item(1).ToString, 1, 2) & "/" & Mid(dts_lista.Tables(0).Rows(pos).Item(1).ToString, 3, 2))

            saldo = CStr(CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), 2))
            If saldo > 0 Then
                lbl_abono.Text = "ABONO " & CStr(Format(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), "$ ###,##0.00"))
                lbl_saldo.Text = "SALDO " & CStr(Format(CDbl(saldo), "$ ###,##0.00"))
                'Format(CDbl(int_precio), "$ ###,##0.00")
            Else


                If CDbl(opr_fac.LeerEstadoFac(g_lng_ped_nunfact)) = 2 Then
                    lbl_abono.Text = " PAGO "
                    lbl_saldo.Text = "CANCELADO"
                Else
                    lbl_abono.Text = " PAGO "
                    lbl_saldo.Text = "SIN GENERAR"
                End If

            End If
            g_numOrden = Mid(dts_lista.Tables(0).Rows(pos).Item(1).ToString, 5, 4)
            btn_aanular.Enabled = True 'ETIQUETAS
            btn_eeditar.Enabled = True ' EDITAR
            btn_nnuevo.Enabled = True ' NUEVO
            btn_aanular.Enabled = True ' ANULAR
            btn_eetiqueta.Enabled = True ' ETIQUETAS
            btn_AccesoWeb.Enabled = True ' ETIQUETAS ACCESO WEB
            btn_AccImpreso.Enabled = True ' ETIQUETAS ACCESO WEB
            btn_cconvenio.Enabled = True  'IMPRESION DEL PEDIDO 

            dgrd_pedido.ReadOnly = True
            'dgrd_pedido.Enabled = False
            'If 
            If g_lng_ped_nunfact <> 0 Then
                lbl_grado.Text = g_lng_ped_nunfact
                'btn_ffactura.Visible = True
            Else
                lbl_grado.Text = "SIN GENERAR"
                'btn_ffactura.Visible = True
            End If


            If dts_lista.Tables(0).Rows(pos).Item(14).ToString = "P" Then
                btn_AccesoWeb.Enabled = False ' ETIQUETAS ACCESO WEB
                btn_eetiqueta.Enabled = False
                btn_pproforma.Enabled = True ' PROFORMA
                btn_convertir.Enabled = True  ' CONVERTIR A ORDEN
            Else
                btn_eetiqueta.Enabled = True
                btn_pproforma.Enabled = False ' PROFORMA
                btn_convertir.Enabled = False ' CONVERTIR A ORDEN
            End If

            If btn_convertir.Enabled = False Then 'CONVERTIR
                btn_ffactura.Enabled = True 'FACTURA
                btn_cconvenio.Enabled = True  'IMPRESION DEL PEDIDO 

            Else
                btn_ffactura.Enabled = False 'FACTURA
                btn_cconvenio.Enabled = False 'IMPRESION DEL PEDIDO 
            End If

            ''Else

        End If
        lst_pedidos.SelectedIndex = (pos)
    End Sub

    Private Sub btn_AccesoWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AccesoWeb.Click
        Dim nombre As String()
        Dim wtexto, texto As String
        Dim ParamCorreo As String()
        Dim var_correo As String = Nothing
        Dim i As Integer
        Dim opr_mail As New Cls_NetMail()
        Dim opr_encripta As New Cls_Encripta()
        Dim opr_pac As New Cls_Paciente
        Dim pos As Integer = 0
        Dim msg As String = "Ingrese el numero telefonico del destinatario de whatsapp "
        Dim myValue As String = InputBox(msg, "ANALISYS", opr_pedido.LeerTelefono(Trim(lbl_doc.Text)))
        Dim vFileName As String = Nothing
        vFileName = Environment.CurrentDirectory & "\" & g_pathFolder
        Dim credenciales As String()

        If opr_pac.verifica_usrWeb(CInt(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(2).ToString)) = "" Then
            nombre = Split(Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString), " ")
            g_usu_pass = Trim(lbl_doc.Text)

            If UBound(nombre) = 1 Then
                texto = opr_encripta.Genera_usr(nombre(2), nombre(0), g_usu_login, g_usu_pass)
            Else
                texto = opr_encripta.Genera_usr(nombre(2), nombre(0), g_usu_login, g_usu_pass)

            End If


            opr_pac.Ingresa_UsrWeb(CInt(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(2).ToString), g_usu_login, Trim(txt_doc.Text))
            'wtexto = wtexto & "*USUARIO:*%20" & g_usu_login & "%0A" & "*CONTRASEÑA:*%20" & g_usu_pass & "%0A" & "*LINK:*%20" & System.Configuration.ConfigurationSettings.AppSettings("SITIO") & "%0A%0A" & g_Titulo & "%20_Simpre%20un%20buen%20análisis_"
            wtexto = wtexto & "*USUARIO:*%20" & g_usu_login & "%0A" & "*CONTRASEÑA:*%20" & g_usu_pass & "%0A" & "*LINK:*%20" & System.Configuration.ConfigurationSettings.AppSettings("SITIO") & "%0A%0A" & g_Titulo
            'GENERA ETIQUETAS
            'Abrir_frmImprimiendo(4)

            'opr_mail.EnviaCorreo(Trim(var_correo), "CREDENCIALES ACCESO", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "")
        Else

            credenciales = Split(opr_pac.Busca_usrWeb(CInt(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(2).ToString)), ",")
            wtexto = wtexto & "*USUARIO:*%20" & credenciales(0) & "%0A" & "*CONTRASEÑA:*%20" & credenciales(1) & "%0A" & "*LINK:*%20" & System.Configuration.ConfigurationSettings.AppSettings("SITIO") & "%0A%0A" & g_Titulo
            'wtexto = wtexto & "*USUARIO:*%20" & credenciales(0) & "%0A" & "*CONTRASEÑA:*%20" & credenciales(1) & "%0A" & "*LINK:*%20" & System.Configuration.ConfigurationSettings.AppSettings("SITIO") & "%0A%0A" & g_Titulo & "%20_Simpre%20un%20buen%20análisis_"
            'Abrir_frmImprimiendo(4)
        End If



        If String.IsNullOrEmpty(myValue) Then
            'MessageBox.Show("Se cancelo el Inputbox")
            Return
        Else



            wtexto = "*UTILICE EL BOTON RESULTADOS ONLINE*%0A%0A" & wtexto

            '&text=''
            System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(myValue, 2, 9) & "&text=" & wtexto)
            'System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(myValue, 2, 9))
            '  System.Diagnostics.Process.Start("explorer.exe", vFileName)
        End If




    End Sub

    Private Sub txt_filtro_medico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_filtro_medico.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER 
            cmb_medico.Text = txt_filtro_medico.Text
            txt_filtro_medico.Text = ""

        ElseIf e.KeyCode = Keys.Delete Then

        End If
    End Sub



    Private Sub btn_AccImpreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AccImpreso.Click
        Dim nombre As String()
        Dim wtexto, texto As String
        Dim credenciales As String()
        'Dim ParamCorreo As String()
        'Dim var_correo As String = Nothing
        'Dim i As Integer
        'Dim opr_mail As New Cls_NetMail()
        Dim opr_encripta As New Cls_Encripta()
        Dim opr_pac As New Cls_Paciente

        'pos = lst_pedidos.SelectedIndex
        'lst_pedidos.SelectedIndex = pos

        'If pos >= 0 Then
        If opr_pac.verifica_usrWeb(CInt(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(2).ToString)) = "" Then
            nombre = Split(Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString), " ")

            If UBound(nombre) = 1 Then
                texto = opr_encripta.Genera_usr(nombre(2), nombre(0), g_usu_login, g_usu_pass)
            Else
                texto = opr_encripta.Genera_usr(nombre(2), nombre(0), g_usu_login, g_usu_pass)

            End If


            opr_pac.Ingresa_UsrWeb(CInt(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(2).ToString), g_usu_login, Trim(txt_doc.Text))
            ''''ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
            'GENERA ETIQUETAS
            Abrir_frmImprimiendo(4)

            'opr_mail.EnviaCorreo(Trim(var_correo), "CREDENCIALES ACCESO", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "")
        Else
            credenciales = Split(opr_pac.Busca_usrWeb(CInt(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(2).ToString)), ",")
            credenciales(0) = g_usu_login
            credenciales(1) = Trim(txt_doc.Text)
            Abrir_frmImprimiendo(4)
        End If

        'End If
        'lst_pedidos.SelectedIndex = (pos)




    End Sub


    
    Private Sub cmb_Cantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Cantidad.KeyPress
        If cmb_Cantidad.Text <> "" Then
            If CInt(cmb_Cantidad.Text) <> 0 Then
                dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(1) = CInt(cmb_Cantidad.Text)
                dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(9) = dtt_pedido.Rows(dgrd_pedido.CurrentCell.RowNumber).Item(4) * CInt(cmb_Cantidad.Text)
                Call CalcularTotal()
            Else
                opr_pedido.VisualizaMensaje("no puede poner una cantidad 0", 200)
            End If
        Else
            opr_pedido.VisualizaMensaje("no puede poner una cantidad vacia", 200)
        End If
    End Sub

    
End Class