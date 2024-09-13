'*************************************************************************
' Nombre:   frm_Paciente3
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite seleccionar un paciente
'               para un nuevo pedido
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_Paciente3
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
    Friend WithEvents Dgrd_paciente As System.Windows.Forms.DataGrid
    Friend WithEvents txt_filtro_apellido As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
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
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_seleccionar As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents grp_buscar As System.Windows.Forms.GroupBox
    Friend WithEvents rbtn_apellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_cedula As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_hisclin As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_buscarr As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Paciente3))
        Me.Dgrd_paciente = New System.Windows.Forms.DataGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.Menu_seleccionar = New System.Windows.Forms.MenuItem
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
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
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_filtro_apellido = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.grp_buscar = New System.Windows.Forms.GroupBox
        Me.rbtn_hisclin = New System.Windows.Forms.RadioButton
        Me.rbtn_cedula = New System.Windows.Forms.RadioButton
        Me.rbtn_apellido = New System.Windows.Forms.RadioButton
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_buscarr = New System.Windows.Forms.Button
        CType(Me.Dgrd_paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.grp_buscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgrd_paciente
        '
        Me.Dgrd_paciente.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_paciente.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_paciente.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_paciente.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_paciente.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_paciente.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_paciente.CaptionText = "PACIENTES"
        Me.Dgrd_paciente.ContextMenu = Me.ContextMenu1
        Me.Dgrd_paciente.DataMember = ""
        Me.Dgrd_paciente.FlatMode = True
        Me.Dgrd_paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_paciente.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_paciente.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_paciente.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_paciente.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_paciente.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_paciente.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_paciente.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_paciente.Location = New System.Drawing.Point(12, 97)
        Me.Dgrd_paciente.Name = "Dgrd_paciente"
        Me.Dgrd_paciente.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_paciente.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_paciente.ParentRowsVisible = False
        Me.Dgrd_paciente.PreferredColumnWidth = 100
        Me.Dgrd_paciente.ReadOnly = True
        Me.Dgrd_paciente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_paciente.RowHeaderWidth = 0
        Me.Dgrd_paciente.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_paciente.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_paciente.Size = New System.Drawing.Size(740, 250)
        Me.Dgrd_paciente.TabIndex = 2
        Me.Dgrd_paciente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_paciente.TabStop = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_seleccionar})
        '
        'Menu_seleccionar
        '
        Me.Menu_seleccionar.Index = 0
        Me.Menu_seleccionar.Text = "Seleccionar"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_paciente
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16})
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
        Me.DataGridTextBoxColumn1.MappingName = "pac_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Doc. Identif."
        Me.DataGridTextBoxColumn2.MappingName = "pac_doc"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "pac_tipodoc"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Apellidos"
        Me.DataGridTextBoxColumn4.MappingName = "pac_apellido"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 170
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Nombres"
        Me.DataGridTextBoxColumn5.MappingName = "pac_nombre"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 170
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "pac_direccion"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "ciu_nombre"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Tel�fono"
        Me.DataGridTextBoxColumn8.MappingName = "pac_fono"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "pac_fecnac"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Sexo"
        Me.DataGridTextBoxColumn10.MappingName = "pac_sexo"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 40
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "pac_obs"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "EMAIL"
        Me.DataGridTextBoxColumn12.MappingName = "pac_mail"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 200
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Hist Cl�nica"
        Me.DataGridTextBoxColumn13.MappingName = "PAC_HIST_CLINICA"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Afiliaci�n"
        Me.DataGridTextBoxColumn14.MappingName = "pac_grado"
        Me.DataGridTextBoxColumn14.NullText = "--"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Afiliado desde"
        Me.DataGridTextBoxColumn15.MappingName = "pac_parentesco"
        Me.DataGridTextBoxColumn15.NullText = "--"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "pac_usafecnac"
        Me.DataGridTextBoxColumn16.MappingName = "pac_usafecnac"
        Me.DataGridTextBoxColumn16.NullText = "--"
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'txt_filtro_apellido
        '
        Me.txt_filtro_apellido.BackColor = System.Drawing.Color.LightGreen
        Me.txt_filtro_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro_apellido.Location = New System.Drawing.Point(15, 32)
        Me.txt_filtro_apellido.MaxLength = 50
        Me.txt_filtro_apellido.Name = "txt_filtro_apellido"
        Me.txt_filtro_apellido.Size = New System.Drawing.Size(208, 21)
        Me.txt_filtro_apellido.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_filtro_apellido, "Ingrese el apellido del paciente")
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(300, 16)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 24)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_buscar, "Ingresar un nuevo paciente")
        Me.btn_buscar.UseVisualStyleBackColor = False
        Me.btn_buscar.Visible = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(663, 38)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 40)
        Me.btn_cancelar.TabIndex = 155
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Salir de esta ventana")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(764, 25)
        Me.pan_barra.TabIndex = 101
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(5, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(150, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "BUSCAR PACIENTE"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_buscar
        '
        Me.grp_buscar.BackColor = System.Drawing.Color.Transparent
        Me.grp_buscar.Controls.Add(Me.rbtn_hisclin)
        Me.grp_buscar.Controls.Add(Me.rbtn_cedula)
        Me.grp_buscar.Controls.Add(Me.rbtn_apellido)
        Me.grp_buscar.Controls.Add(Me.btn_buscar)
        Me.grp_buscar.Controls.Add(Me.txt_filtro_apellido)
        Me.grp_buscar.Location = New System.Drawing.Point(197, 26)
        Me.grp_buscar.Name = "grp_buscar"
        Me.grp_buscar.Size = New System.Drawing.Size(247, 58)
        Me.grp_buscar.TabIndex = 0
        Me.grp_buscar.TabStop = False
        '
        'rbtn_hisclin
        '
        Me.rbtn_hisclin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_hisclin.Location = New System.Drawing.Point(167, 14)
        Me.rbtn_hisclin.Name = "rbtn_hisclin"
        Me.rbtn_hisclin.Size = New System.Drawing.Size(57, 16)
        Me.rbtn_hisclin.TabIndex = 6
        Me.rbtn_hisclin.Text = "HC"
        '
        'rbtn_cedula
        '
        Me.rbtn_cedula.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_cedula.Location = New System.Drawing.Point(15, 14)
        Me.rbtn_cedula.Name = "rbtn_cedula"
        Me.rbtn_cedula.Size = New System.Drawing.Size(64, 16)
        Me.rbtn_cedula.TabIndex = 8
        Me.rbtn_cedula.Text = "Cedula"
        '
        'rbtn_apellido
        '
        Me.rbtn_apellido.Checked = True
        Me.rbtn_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_apellido.Location = New System.Drawing.Point(85, 14)
        Me.rbtn_apellido.Name = "rbtn_apellido"
        Me.rbtn_apellido.Size = New System.Drawing.Size(76, 16)
        Me.rbtn_apellido.TabIndex = 7
        Me.rbtn_apellido.TabStop = True
        Me.rbtn_apellido.Text = "Apellido"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(18, 39)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 41)
        Me.btn_nuevo.TabIndex = 151
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.Location = New System.Drawing.Point(100, 39)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(80, 41)
        Me.btn_salir.TabIndex = 153
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_buscarr
        '
        Me.btn_buscarr.BackColor = System.Drawing.SystemColors.Control
        Me.btn_buscarr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscarr.ForeColor = System.Drawing.Color.Black
        Me.btn_buscarr.Image = CType(resources.GetObject("btn_buscarr.Image"), System.Drawing.Image)
        Me.btn_buscarr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscarr.Location = New System.Drawing.Point(559, 38)
        Me.btn_buscarr.Name = "btn_buscarr"
        Me.btn_buscarr.Size = New System.Drawing.Size(102, 41)
        Me.btn_buscarr.TabIndex = 154
        Me.btn_buscarr.Text = "Buscar"
        Me.btn_buscarr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscarr.UseVisualStyleBackColor = False
        '
        'frm_Paciente3
        '
        Me.AcceptButton = Me.btn_buscarr
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(764, 359)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscarr)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.grp_buscar)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.Dgrd_paciente)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Paciente3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar PACIENTE"
        CType(Me.Dgrd_paciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_buscar.ResumeLayout(False)
        Me.grp_buscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'declaracion de variables
    Dim opr_paciente As New Cls_Paciente()
    Public frm_refer_main As Frm_Main
    Dim dtv_paciente As New DataView()
#Region "C�digo de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.MouseLeave
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

    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        'funcion que retorna true si existe el formulario creado en el MDI, false si no 
        'lo encuentra creado, pero este es un caso personalizado para este formulario
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In frm_refer_main.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                ctl.Activate()
                Exit Function
            End If
        Next
    End Function

    Private Sub frm_Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        
        txt_filtro_apellido.Focus()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cierro le formulario
        Me.Close()
    End Sub

    Private Sub Dgrd_paciente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrd_paciente.CurrentCellChanged
        'selecciono toda la fila 
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = Dgrd_paciente.CurrentCell.RowNumber
        Dgrd_paciente.CurrentCell = dgc_celda
        Dgrd_paciente.Select(Dgrd_paciente.CurrentCell.RowNumber)
    End Sub

    'Private Sub txt_filtro_apellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro_apellido.TextChanged
    '    'cuando presiono una tecla mando hacer un filtro del apellido del paciete 
    '    opr_paciente.ordena_apellido(txt_filtro_apellido.Text, dtv_paciente)

    '    'opr_paciente.LlenarGridPaciente(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
    'End Sub

    Private Sub Dgrd_paciente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrd_paciente.DoubleClick, Menu_seleccionar.Click
        inserta_paciente()
    End Sub

    Private Sub inserta_paciente()
        On Error Resume Next
        Dim ctl As Form
        Dim ctl2 As frm_Pedido
        Dim ctl3 As frm_Ing_Remitidos
        Dim ctl4 As Ingreso_Aspirantes
        Dim ctl5 As frm_AgendaCitaMedica
        Dim opr_pedido As New Cls_Pedido()

        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        For Each ctl In frm_refer_main.MdiChildren
            If ctl.Name = "frm_Pedido" Or "frm_Ing_Remitidos" Or "Ingreso_Aspirantes" Then
                ctl2 = ctl
                ctl2.Tag = "pac_doc=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 1).ToString & "/*/pac_apellido=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 3).ToString & "/*/pac_nombre=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 4).ToString & "/*/pac_direccion=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 5).ToString & "/*/pac_fono=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 7).ToString & "/*/pac_id=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 0).ToString & "/*/pac_hist_clinica=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 12).ToString & "/*/pac_grado=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 13).ToString & "/*/pac_parentesco=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 14).ToString & "/*/pac_usafecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 15).ToString & "/*/pac_fecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 8).ToString & "/*/pac_genero=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 9).ToString
                ctl2.LLena_datos_paciente_doc()

                'Formulario PDF
                ctl3 = ctl
                ctl3.Tag = "pac_doc=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 1).ToString & "/*/pac_apellido=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 3).ToString & "/*/pac_nombre=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 4).ToString & "/*/pac_direccion=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 5).ToString & "/*/pac_fono=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 7).ToString & "/*/pac_id=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 0).ToString & "/*/pac_hist_clinica=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 12).ToString & "/*/pac_grado=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 13).ToString & "/*/pac_parentesco=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 14).ToString & "/*/pac_usafecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 15).ToString & "/*/pac_fecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 8).ToString & "/*/pac_genero=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 9).ToString
                ctl3.LLena_datos_paciente_doc()

                ctl4 = ctl
                ctl4.Tag = "pac_doc=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 1).ToString & "/*/pac_apellido=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 3).ToString & "/*/pac_nombre=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 4).ToString & "/*/pac_direccion=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 5).ToString & "/*/pac_fono=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 7).ToString & "/*/pac_id=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 0).ToString & "/*/pac_hist_clinica=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 12).ToString & "/*/pac_grado=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 13).ToString & "/*/pac_parentesco=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 14).ToString & "/*/pac_usafecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 15).ToString & "/*/pac_fecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 8).ToString & "/*/pac_genero=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 9).ToString
                ctl4.LLena_datos_paciente_doc()

                ctl5 = ctl
                ctl5.Tag = "pac_doc=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 1).ToString & "/*/pac_apellido=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 3).ToString & "/*/pac_nombre=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 4).ToString & "/*/pac_direccion=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 5).ToString & "/*/pac_fono=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 7).ToString & "/*/pac_id=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 0).ToString & "/*/pac_hist_clinica=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 12).ToString & "/*/pac_grado=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 13).ToString & "/*/pac_parentesco=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 14).ToString & "/*/pac_usafecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 15).ToString & "/*/pac_fecnac=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 8).ToString & "/*/pac_genero=" & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 9).ToString
                ctl5.LLena_datos_paciente_doc()

                'formulario PRE ORDEN
                ctl.Activate()
            End If
        Next
        Me.Close()
    End Sub



    'Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgrd_paciente.KeyDown
    '    Grid_Seleccionar_Celda_Test()
    '    If e.KeyCode = Keys.Enter Then
    '        'Operaciones al precionar ENTER sobre el grid
    '        inserta_paciente()
    '    ElseIf e.KeyCode = Keys.Delete Then
    '        'Operaciones al precionar DELETE sobre el grid
    '    End If
    'End Sub

    Private celdaanterior As Short
    Private Sub Grid_Seleccionar_Celda_Test()
        On Error Resume Next
        'funci�n que no permite que exista selecci�n multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        Dgrd_paciente.UnSelect(celdaanterior)
        Dgrd_paciente.Select(Dgrd_paciente.CurrentCell.RowNumber)
        celdaanterior = Dgrd_paciente.CurrentCell.RowNumber
    End Sub


    'Private Sub txt_filtrocedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'opr_paciente.LlenarGridPaciente_cedu(Dgrd_paciente, Trim(txt_filtrocedula.Text))
    '    'opr_paciente.ordena_cedula(txt_filtrocedula.Text, dtv_paciente)
    'End Sub


    Private Sub Dgrd_paciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dgrd_paciente.KeyPress
        Grid_Seleccionar_Celda_Test()
        If e.Handled = Keys.Enter Then
            inserta_paciente()
        End If
    End Sub

    ' '' ''Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
    ' '' ''    Me.Cursor = Cursors.WaitCursor
    ' '' ''    If txt_filtro_apellido.Text = "" Then
    ' '' ''        MsgBox("Ingrese al menos un caracter para iniciar la busqueda.", MsgBoxStyle.Information, "ANALISYS")
    ' '' ''        txt_filtro_apellido.Focus()
    ' '' ''    Else

    ' '' ''        If rbtn_apellido.Checked = True Then
    ' '' ''            opr_paciente.LlenarGridPaciente2(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
    ' '' ''        ElseIf rbtn_cedula.Checked = True Then
    ' '' ''            opr_paciente.LlenarGridPaciente_cedu(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
    ' '' ''        Else
    ' '' ''            opr_paciente.LlenarGridPaciente_hisclin(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
    ' '' ''        End If
    ' '' ''    End If

    ' '' ''    Me.Cursor = Cursors.Arrow
    ' '' ''End Sub

    Private Sub rbtn_apellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_apellido.CheckedChanged
        If rbtn_apellido.Checked = True Then
            txt_filtro_apellido.MaxLength = 50
            txt_filtro_apellido.Text = ""
        Else
            txt_filtro_apellido.MaxLength = 10
            txt_filtro_apellido.Text = ""
        End If
        txt_filtro_apellido.Focus()
    End Sub




    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        If txt_filtro_apellido.Text = "" Then
            MsgBox("Ingrese al menos un caracter para iniciar la busqueda.", MsgBoxStyle.Information, "ANALISYS")
            txt_filtro_apellido.Focus()
        Else

            If rbtn_apellido.Checked = True Then
                opr_paciente.LlenarGridPaciente2(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
            ElseIf rbtn_cedula.Checked = True Then
                opr_paciente.LlenarGridPaciente_cedu(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
            Else
                opr_paciente.LlenarGridPaciente_hisclin(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
            End If
        End If

        Me.Cursor = Cursors.Arrow
    End Sub



    Private Sub txt_filtro_apellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_filtro_apellido.KeyPress
        If e.KeyChar = (Convert.ToChar(Keys.Enter)) Then
            btn_buscar.PerformClick()
        End If
    End Sub




    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        'escojo esta opcion si deseo crear un nuevo paciente
        Me.Close()
        If Not ExisteForm("frm_Paciente2") Then
            Dim frm_MDIChild As New frm_Paciente2()
            frm_MDIChild.frm_refer_main_form = frm_refer_main
            frm_MDIChild.MdiParent = frm_refer_main.ParentForm
            frm_MDIChild.ShowDialog(frm_refer_main.ParentForm)
        End If
    End Sub


    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'cierro le formulario
        Me.Close()
    End Sub

    Private Sub btn_buscarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarr.Click
        Me.Cursor = Cursors.WaitCursor
        If txt_filtro_apellido.Text = "" Then
            MsgBox("Ingrese al menos un caracter para iniciar la busqueda.", MsgBoxStyle.Information, "ANALISYS")
            txt_filtro_apellido.Focus()
        Else

            If rbtn_apellido.Checked = True Then
                opr_paciente.LlenarGridPaciente2(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
            ElseIf rbtn_cedula.Checked = True Then
                opr_paciente.LlenarGridPaciente_cedu(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
            Else
                opr_paciente.LlenarGridPaciente_hisclin(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
            End If
        End If

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btn_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

  
End Class