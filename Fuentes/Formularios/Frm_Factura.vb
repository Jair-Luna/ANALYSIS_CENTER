'*************************************************************************
' Nombre:   Frm_Factura
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para la emisi�n y pago de facturas
' Autores:  RFN
' Fecha de Creaci�n: 7 Agosto del 2012
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System.Math
Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient



Public Class Frm_Factura
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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_fono As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_tipdoc As System.Windows.Forms.Label
    Friend WithEvents cmb_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents ctl_txt_dir As Ctl_txt.ctl_txt_letras
    Friend WithEvents ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents ctl_txt_doc As Ctl_txt.ctl_txt_ci_ruc
    Friend WithEvents lbl_fono As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_dir As System.Windows.Forms.Label
    Friend WithEvents lbl_numfact As System.Windows.Forms.Label
    Friend WithEvents lbl_FACFECHA As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_apellido As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_iva As Ctl_txt.ctl_txt_numeros
    Friend WithEvents lbl_subtotal As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_saldo As System.Windows.Forms.Label
    Friend WithEvents lbl_formapago As System.Windows.Forms.Label
    Friend WithEvents lbl_abonos As System.Windows.Forms.Label
    Friend WithEvents cmb_fpago As System.Windows.Forms.ComboBox
    Friend WithEvents chk_abono As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_abono_fact As System.Windows.Forms.Label
    Friend WithEvents lbl_saldo_fact As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_fact As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_abo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ctl_txt_monto As Ctl_txt.ctl_txt_numeros
    Friend WithEvents dgrd_factura As System.Windows.Forms.DataGrid
    Friend WithEvents dgts_registro As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgcs_Test As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_Cantidad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_Precio As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_dscto As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_dsct As Ctl_txt.ctl_txt_numeros
    Friend WithEvents dgcs_id As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_tipo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_dsct As System.Windows.Forms.Label
    Friend WithEvents lbl_dsct_fact As System.Windows.Forms.Label
    Friend WithEvents lbl_iva1 As System.Windows.Forms.Label
    Friend WithEvents lbl_iva2 As System.Windows.Forms.Label
    Friend WithEvents lbl_IVA As System.Windows.Forms.Label
    Friend WithEvents txt_textofact As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents lbl_numped As System.Windows.Forms.Label
    Friend WithEvents lbl_convenio As System.Windows.Forms.Label
    Friend WithEvents lbl_conve As System.Windows.Forms.Label
    Friend WithEvents dgcs_total As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmb_fimp As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_imp As System.Windows.Forms.Label
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_rec As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_rec_fact As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_referfact As Ctl_txt.ctl_txt_letras
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_reten As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grp_abono As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_orden As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents btn_ImpFactura As System.Windows.Forms.Button
    Friend WithEvents btn_ImpAbono As System.Windows.Forms.Button
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_recibo As System.Windows.Forms.Button
    Friend WithEvents lbl_letrasNum As System.Windows.Forms.Label
    Friend WithEvents cons_total As System.Windows.Forms.Label
    Friend WithEvents lbl_subtot_fact As System.Windows.Forms.Label
    Friend WithEvents lbl_tot_fact As Ctl_txt.ctl_txt_numeros
    Friend WithEvents btn_enviaFac As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_Email As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_numfact As Ctl_txt.ctl_txt_letras
    Friend WithEvents btn_pendiente As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Factura))
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.Ctl_txt_fono = New Ctl_txt.ctl_txt_letras
        Me.lbl_fono = New System.Windows.Forms.Label
        Me.Ctl_txt_referfact = New Ctl_txt.ctl_txt_letras
        Me.Label2 = New System.Windows.Forms.Label
        Me.Ctl_txt_apellido = New Ctl_txt.ctl_txt_letras
        Me.lbl_apellidos = New System.Windows.Forms.Label
        Me.dtp_fecha_fact = New System.Windows.Forms.DateTimePicker
        Me.lbl_FACFECHA = New System.Windows.Forms.Label
        Me.lbl_tipdoc = New System.Windows.Forms.Label
        Me.cmb_tipodoc = New System.Windows.Forms.ComboBox
        Me.ctl_txt_dir = New Ctl_txt.ctl_txt_letras
        Me.ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.ctl_txt_doc = New Ctl_txt.ctl_txt_ci_ruc
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_conve = New System.Windows.Forms.Label
        Me.lbl_dir = New System.Windows.Forms.Label
        Me.cmb_fimp = New System.Windows.Forms.ComboBox
        Me.lbl_imp = New System.Windows.Forms.Label
        Me.lbl_formapago = New System.Windows.Forms.Label
        Me.cmb_fpago = New System.Windows.Forms.ComboBox
        Me.lbl_convenio = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ctl_txt_dsct = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_rec = New Ctl_txt.ctl_txt_numeros
        Me.lbl_dscto = New System.Windows.Forms.Label
        Me.lbl_numped = New System.Windows.Forms.Label
        Me.lbl_pedido = New System.Windows.Forms.Label
        Me.lbl_numfact = New System.Windows.Forms.Label
        Me.Ctl_txt_iva = New Ctl_txt.ctl_txt_numeros
        Me.lbl_iva1 = New System.Windows.Forms.Label
        Me.lbl_subtotal = New System.Windows.Forms.Label
        Me.lbl_total = New System.Windows.Forms.Label
        Me.Ctl_txt_monto = New Ctl_txt.ctl_txt_numeros
        Me.dtp_fecha_abo = New System.Windows.Forms.DateTimePicker
        Me.chk_abono = New System.Windows.Forms.CheckBox
        Me.lbl_saldo_fact = New System.Windows.Forms.Label
        Me.lbl_abono_fact = New System.Windows.Forms.Label
        Me.lbl_saldo = New System.Windows.Forms.Label
        Me.lbl_abonos = New System.Windows.Forms.Label
        Me.dgrd_factura = New System.Windows.Forms.DataGrid
        Me.dgts_registro = New System.Windows.Forms.DataGridTableStyle
        Me.dgcs_id = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_tipo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Cantidad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Test = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Precio = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_total = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbl_dsct = New System.Windows.Forms.Label
        Me.lbl_dsct_fact = New System.Windows.Forms.Label
        Me.lbl_iva2 = New System.Windows.Forms.Label
        Me.lbl_IVA = New System.Windows.Forms.Label
        Me.txt_textofact = New System.Windows.Forms.TextBox
        Me.btn_anular = New System.Windows.Forms.Button
        Me.lbl_rec_fact = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.Ctl_txt_reten = New Ctl_txt.ctl_txt_numeros
        Me.Label3 = New System.Windows.Forms.Label
        Me.grp_abono = New System.Windows.Forms.GroupBox
        Me.btn_pendiente = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_orden = New System.Windows.Forms.ComboBox
        Me.lbl_msg = New System.Windows.Forms.Label
        Me.btn_ImpFactura = New System.Windows.Forms.Button
        Me.btn_ImpAbono = New System.Windows.Forms.Button
        Me.grp_datos = New System.Windows.Forms.GroupBox
        Me.Ctl_txt_numfact = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_Email = New Ctl_txt.ctl_txt_letras
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_letrasNum = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_recibo = New System.Windows.Forms.Button
        Me.cons_total = New System.Windows.Forms.Label
        Me.lbl_subtot_fact = New System.Windows.Forms.Label
        Me.lbl_tot_fact = New Ctl_txt.ctl_txt_numeros
        Me.btn_enviaFac = New System.Windows.Forms.Button
        CType(Me.dgrd_factura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.grp_abono.SuspendLayout()
        Me.grp_datos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(760, 39)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 40)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Enabled = False
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(156, 19)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 40)
        Me.btn_aceptar.TabIndex = 8
        Me.btn_aceptar.Text = "Cobrar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'Ctl_txt_fono
        '
        Me.Ctl_txt_fono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_fono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_fono.Location = New System.Drawing.Point(102, 177)
        Me.Ctl_txt_fono.Name = "Ctl_txt_fono"
        Me.Ctl_txt_fono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_fono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_fono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_fono.Size = New System.Drawing.Size(88, 20)
        Me.Ctl_txt_fono.TabIndex = 7
        '
        'lbl_fono
        '
        Me.lbl_fono.AutoSize = True
        Me.lbl_fono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fono.Location = New System.Drawing.Point(13, 181)
        Me.lbl_fono.Name = "lbl_fono"
        Me.lbl_fono.Size = New System.Drawing.Size(77, 16)
        Me.lbl_fono.TabIndex = 62
        Me.lbl_fono.Text = "TELEFONO"
        '
        'Ctl_txt_referfact
        '
        Me.Ctl_txt_referfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_referfact.Location = New System.Drawing.Point(192, 177)
        Me.Ctl_txt_referfact.Name = "Ctl_txt_referfact"
        Me.Ctl_txt_referfact.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_referfact.Prp_CaracterPasswd = ""
        Me.Ctl_txt_referfact.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_referfact.Size = New System.Drawing.Size(88, 20)
        Me.Ctl_txt_referfact.TabIndex = 9
        Me.Ctl_txt_referfact.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(14, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "REFER."
        Me.Label2.Visible = False
        '
        'Ctl_txt_apellido
        '
        Me.Ctl_txt_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_apellido.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_apellido.Location = New System.Drawing.Point(102, 85)
        Me.Ctl_txt_apellido.Name = "Ctl_txt_apellido"
        Me.Ctl_txt_apellido.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_apellido.Prp_CaracterPasswd = ""
        Me.Ctl_txt_apellido.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_apellido.Size = New System.Drawing.Size(317, 20)
        Me.Ctl_txt_apellido.TabIndex = 4
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_apellidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_apellidos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidos.ForeColor = System.Drawing.Color.Navy
        Me.lbl_apellidos.Location = New System.Drawing.Point(14, 90)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(73, 16)
        Me.lbl_apellidos.TabIndex = 83
        Me.lbl_apellidos.Text = "APELLIDO"
        Me.lbl_apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_fecha_fact
        '
        Me.dtp_fecha_fact.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_fact.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_fact.Location = New System.Drawing.Point(318, 17)
        Me.dtp_fecha_fact.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha_fact.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha_fact.Name = "dtp_fecha_fact"
        Me.dtp_fecha_fact.Size = New System.Drawing.Size(103, 20)
        Me.dtp_fecha_fact.TabIndex = 1
        '
        'lbl_FACFECHA
        '
        Me.lbl_FACFECHA.AutoSize = True
        Me.lbl_FACFECHA.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FACFECHA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FACFECHA.ForeColor = System.Drawing.Color.Navy
        Me.lbl_FACFECHA.Location = New System.Drawing.Point(267, 18)
        Me.lbl_FACFECHA.Name = "lbl_FACFECHA"
        Me.lbl_FACFECHA.Size = New System.Drawing.Size(47, 16)
        Me.lbl_FACFECHA.TabIndex = 81
        Me.lbl_FACFECHA.Text = "Fecha"
        '
        'lbl_tipdoc
        '
        Me.lbl_tipdoc.AutoSize = True
        Me.lbl_tipdoc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipdoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipdoc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_tipdoc.Location = New System.Drawing.Point(14, 136)
        Me.lbl_tipdoc.Name = "lbl_tipdoc"
        Me.lbl_tipdoc.Size = New System.Drawing.Size(60, 16)
        Me.lbl_tipdoc.TabIndex = 74
        Me.lbl_tipdoc.Text = "CI / RUC"
        '
        'cmb_tipodoc
        '
        Me.cmb_tipodoc.DisplayMember = "1"
        Me.cmb_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipodoc.Items.AddRange(New Object() {"CEDULA", "RUC", "PASAPORTE", "NINGUNO"})
        Me.cmb_tipodoc.Location = New System.Drawing.Point(102, 131)
        Me.cmb_tipodoc.Name = "cmb_tipodoc"
        Me.cmb_tipodoc.Size = New System.Drawing.Size(88, 21)
        Me.cmb_tipodoc.TabIndex = 2
        '
        'ctl_txt_dir
        '
        Me.ctl_txt_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_dir.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_dir.Location = New System.Drawing.Point(102, 155)
        Me.ctl_txt_dir.Name = "ctl_txt_dir"
        Me.ctl_txt_dir.Prp_CaracterEspecial = New String() {"'"}
        Me.ctl_txt_dir.Prp_CaracterPasswd = ""
        Me.ctl_txt_dir.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.ctl_txt_dir.Size = New System.Drawing.Size(318, 20)
        Me.ctl_txt_dir.TabIndex = 6
        '
        'ctl_txt_nombre
        '
        Me.ctl_txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_nombre.Location = New System.Drawing.Point(102, 108)
        Me.ctl_txt_nombre.Name = "ctl_txt_nombre"
        Me.ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.ctl_txt_nombre.Size = New System.Drawing.Size(318, 20)
        Me.ctl_txt_nombre.TabIndex = 5
        '
        'ctl_txt_doc
        '
        Me.ctl_txt_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_doc.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_doc.Location = New System.Drawing.Point(192, 131)
        Me.ctl_txt_doc.Name = "ctl_txt_doc"
        Me.ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
        Me.ctl_txt_doc.Size = New System.Drawing.Size(103, 20)
        Me.ctl_txt_doc.TabIndex = 3
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nombre.Location = New System.Drawing.Point(14, 112)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(64, 16)
        Me.lbl_nombre.TabIndex = 26
        Me.lbl_nombre.Text = "NOMBRE"
        Me.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_conve
        '
        Me.lbl_conve.AutoSize = True
        Me.lbl_conve.BackColor = System.Drawing.Color.Transparent
        Me.lbl_conve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_conve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conve.ForeColor = System.Drawing.Color.Blue
        Me.lbl_conve.Location = New System.Drawing.Point(23, 20)
        Me.lbl_conve.Name = "lbl_conve"
        Me.lbl_conve.Size = New System.Drawing.Size(47, 15)
        Me.lbl_conve.TabIndex = 100
        Me.lbl_conve.Text = "TARIFA"
        '
        'lbl_dir
        '
        Me.lbl_dir.AutoSize = True
        Me.lbl_dir.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dir.ForeColor = System.Drawing.Color.Navy
        Me.lbl_dir.Location = New System.Drawing.Point(14, 159)
        Me.lbl_dir.Name = "lbl_dir"
        Me.lbl_dir.Size = New System.Drawing.Size(79, 16)
        Me.lbl_dir.TabIndex = 20
        Me.lbl_dir.Text = "DIRECCION"
        '
        'cmb_fimp
        '
        Me.cmb_fimp.DisplayMember = "1"
        Me.cmb_fimp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fimp.ItemHeight = 13
        Me.cmb_fimp.Items.AddRange(New Object() {"Detalle", "Total"})
        Me.cmb_fimp.Location = New System.Drawing.Point(609, 90)
        Me.cmb_fimp.Name = "cmb_fimp"
        Me.cmb_fimp.Size = New System.Drawing.Size(96, 21)
        Me.cmb_fimp.TabIndex = 0
        '
        'lbl_imp
        '
        Me.lbl_imp.AutoSize = True
        Me.lbl_imp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_imp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp.ForeColor = System.Drawing.Color.Blue
        Me.lbl_imp.Location = New System.Drawing.Point(539, 94)
        Me.lbl_imp.Name = "lbl_imp"
        Me.lbl_imp.Size = New System.Drawing.Size(64, 15)
        Me.lbl_imp.TabIndex = 95
        Me.lbl_imp.Text = "IMPRIMIR"
        '
        'lbl_formapago
        '
        Me.lbl_formapago.AutoSize = True
        Me.lbl_formapago.BackColor = System.Drawing.Color.Transparent
        Me.lbl_formapago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_formapago.ForeColor = System.Drawing.Color.Navy
        Me.lbl_formapago.Location = New System.Drawing.Point(215, 43)
        Me.lbl_formapago.Name = "lbl_formapago"
        Me.lbl_formapago.Size = New System.Drawing.Size(96, 16)
        Me.lbl_formapago.TabIndex = 94
        Me.lbl_formapago.Text = "FORMA PAGO"
        '
        'cmb_fpago
        '
        Me.cmb_fpago.DisplayMember = "1"
        Me.cmb_fpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fpago.ItemHeight = 13
        Me.cmb_fpago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Tarj. Debtio", "Tarj. Credito", "Transferencia"})
        Me.cmb_fpago.Location = New System.Drawing.Point(317, 40)
        Me.cmb_fpago.Name = "cmb_fpago"
        Me.cmb_fpago.Size = New System.Drawing.Size(103, 21)
        Me.cmb_fpago.TabIndex = 8
        '
        'lbl_convenio
        '
        Me.lbl_convenio.BackColor = System.Drawing.Color.White
        Me.lbl_convenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_convenio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_convenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_convenio.ForeColor = System.Drawing.Color.Navy
        Me.lbl_convenio.Location = New System.Drawing.Point(94, 16)
        Me.lbl_convenio.Name = "lbl_convenio"
        Me.lbl_convenio.Size = New System.Drawing.Size(217, 20)
        Me.lbl_convenio.TabIndex = 101
        Me.lbl_convenio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(602, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Recargo(%)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Ctl_txt_dsct
        '
        Me.Ctl_txt_dsct.BackColor = System.Drawing.Color.White
        Me.Ctl_txt_dsct.Location = New System.Drawing.Point(743, 212)
        Me.Ctl_txt_dsct.Name = "Ctl_txt_dsct"
        Me.Ctl_txt_dsct.Prp_Formato = True
        Me.Ctl_txt_dsct.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_dsct.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_dsct.Prp_ValDefault = "0"
        Me.Ctl_txt_dsct.Size = New System.Drawing.Size(62, 20)
        Me.Ctl_txt_dsct.TabIndex = 3
        '
        'Ctl_txt_rec
        '
        Me.Ctl_txt_rec.Location = New System.Drawing.Point(743, 233)
        Me.Ctl_txt_rec.Name = "Ctl_txt_rec"
        Me.Ctl_txt_rec.Prp_Formato = True
        Me.Ctl_txt_rec.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_rec.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_rec.Prp_ValDefault = "0"
        Me.Ctl_txt_rec.Size = New System.Drawing.Size(62, 20)
        Me.Ctl_txt_rec.TabIndex = 4
        Me.Ctl_txt_rec.Visible = False
        '
        'lbl_dscto
        '
        Me.lbl_dscto.BackColor = System.Drawing.Color.PaleGreen
        Me.lbl_dscto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dscto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dscto.ForeColor = System.Drawing.Color.Black
        Me.lbl_dscto.Location = New System.Drawing.Point(602, 214)
        Me.lbl_dscto.Name = "lbl_dscto"
        Me.lbl_dscto.Size = New System.Drawing.Size(132, 20)
        Me.lbl_dscto.TabIndex = 102
        Me.lbl_dscto.Text = "Descuento(%)"
        Me.lbl_dscto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_numped
        '
        Me.lbl_numped.BackColor = System.Drawing.Color.White
        Me.lbl_numped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_numped.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numped.ForeColor = System.Drawing.Color.Navy
        Me.lbl_numped.Location = New System.Drawing.Point(102, 64)
        Me.lbl_numped.Name = "lbl_numped"
        Me.lbl_numped.Size = New System.Drawing.Size(88, 20)
        Me.lbl_numped.TabIndex = 99
        Me.lbl_numped.Text = "-"
        Me.lbl_numped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pedido
        '
        Me.lbl_pedido.AutoSize = True
        Me.lbl_pedido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_pedido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pedido.Location = New System.Drawing.Point(14, 66)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(61, 16)
        Me.lbl_pedido.TabIndex = 84
        Me.lbl_pedido.Text = "PEDIDO:"
        Me.lbl_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_numfact
        '
        Me.lbl_numfact.AutoSize = True
        Me.lbl_numfact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numfact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_numfact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numfact.ForeColor = System.Drawing.Color.Navy
        Me.lbl_numfact.Location = New System.Drawing.Point(13, 18)
        Me.lbl_numfact.Name = "lbl_numfact"
        Me.lbl_numfact.Size = New System.Drawing.Size(72, 16)
        Me.lbl_numfact.TabIndex = 79
        Me.lbl_numfact.Text = "FACTURA:"
        '
        'Ctl_txt_iva
        '
        Me.Ctl_txt_iva.Location = New System.Drawing.Point(743, 255)
        Me.Ctl_txt_iva.Name = "Ctl_txt_iva"
        Me.Ctl_txt_iva.Prp_Formato = False
        Me.Ctl_txt_iva.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_iva.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.Ctl_txt_iva.Prp_ValDefault = "0"
        Me.Ctl_txt_iva.Size = New System.Drawing.Size(62, 20)
        Me.Ctl_txt_iva.TabIndex = 5
        '
        'lbl_iva1
        '
        Me.lbl_iva1.BackColor = System.Drawing.Color.White
        Me.lbl_iva1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_iva1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iva1.ForeColor = System.Drawing.Color.Black
        Me.lbl_iva1.Location = New System.Drawing.Point(602, 256)
        Me.lbl_iva1.Name = "lbl_iva1"
        Me.lbl_iva1.Size = New System.Drawing.Size(132, 20)
        Me.lbl_iva1.TabIndex = 85
        Me.lbl_iva1.Text = "IVA(%)"
        Me.lbl_iva1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.BackColor = System.Drawing.Color.White
        Me.lbl_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_subtotal.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_subtotal.Location = New System.Drawing.Point(602, 277)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(132, 20)
        Me.lbl_subtotal.TabIndex = 87
        Me.lbl_subtotal.Text = "Subtotal"
        Me.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Khaki
        Me.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_total.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(602, 422)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(132, 26)
        Me.lbl_total.TabIndex = 90
        Me.lbl_total.Text = "Total"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ctl_txt_monto
        '
        Me.Ctl_txt_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_monto.Location = New System.Drawing.Point(71, 29)
        Me.Ctl_txt_monto.Name = "Ctl_txt_monto"
        Me.Ctl_txt_monto.Prp_Formato = True
        Me.Ctl_txt_monto.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_monto.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_monto.Prp_ValDefault = "0"
        Me.Ctl_txt_monto.Size = New System.Drawing.Size(83, 20)
        Me.Ctl_txt_monto.TabIndex = 1
        '
        'dtp_fecha_abo
        '
        Me.dtp_fecha_abo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_abo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_abo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_abo.Location = New System.Drawing.Point(94, 41)
        Me.dtp_fecha_abo.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha_abo.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha_abo.Name = "dtp_fecha_abo"
        Me.dtp_fecha_abo.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha_abo.TabIndex = 2
        '
        'chk_abono
        '
        Me.chk_abono.BackColor = System.Drawing.Color.Transparent
        Me.chk_abono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_abono.Location = New System.Drawing.Point(6, 32)
        Me.chk_abono.Name = "chk_abono"
        Me.chk_abono.Size = New System.Drawing.Size(65, 18)
        Me.chk_abono.TabIndex = 0
        Me.chk_abono.Text = "Abono"
        Me.chk_abono.UseVisualStyleBackColor = False
        '
        'lbl_saldo_fact
        '
        Me.lbl_saldo_fact.BackColor = System.Drawing.Color.White
        Me.lbl_saldo_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_saldo_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_saldo_fact.Location = New System.Drawing.Point(743, 393)
        Me.lbl_saldo_fact.Name = "lbl_saldo_fact"
        Me.lbl_saldo_fact.Size = New System.Drawing.Size(62, 20)
        Me.lbl_saldo_fact.TabIndex = 97
        Me.lbl_saldo_fact.Text = "0.00"
        Me.lbl_saldo_fact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_abono_fact
        '
        Me.lbl_abono_fact.BackColor = System.Drawing.Color.White
        Me.lbl_abono_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_abono_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_abono_fact.Location = New System.Drawing.Point(743, 372)
        Me.lbl_abono_fact.Name = "lbl_abono_fact"
        Me.lbl_abono_fact.Size = New System.Drawing.Size(62, 20)
        Me.lbl_abono_fact.TabIndex = 96
        Me.lbl_abono_fact.Text = "0.00"
        Me.lbl_abono_fact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_saldo
        '
        Me.lbl_saldo.BackColor = System.Drawing.Color.Pink
        Me.lbl_saldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_saldo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_saldo.ForeColor = System.Drawing.Color.Black
        Me.lbl_saldo.Location = New System.Drawing.Point(602, 393)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(132, 20)
        Me.lbl_saldo.TabIndex = 20
        Me.lbl_saldo.Text = "Saldo"
        Me.lbl_saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_abonos
        '
        Me.lbl_abonos.BackColor = System.Drawing.Color.White
        Me.lbl_abonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_abonos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_abonos.ForeColor = System.Drawing.Color.Black
        Me.lbl_abonos.Location = New System.Drawing.Point(602, 371)
        Me.lbl_abonos.Name = "lbl_abonos"
        Me.lbl_abonos.Size = New System.Drawing.Size(132, 20)
        Me.lbl_abonos.TabIndex = 95
        Me.lbl_abonos.Text = "Abonos"
        Me.lbl_abonos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgrd_factura
        '
        Me.dgrd_factura.AllowNavigation = False
        Me.dgrd_factura.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_factura.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_factura.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_factura.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_factura.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_factura.CaptionText = "DETALLE FACTURA"
        Me.dgrd_factura.DataMember = ""
        Me.dgrd_factura.FlatMode = True
        Me.dgrd_factura.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_factura.ForeColor = System.Drawing.Color.Black
        Me.dgrd_factura.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_factura.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_factura.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_factura.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_factura.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_factura.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_factura.Location = New System.Drawing.Point(18, 317)
        Me.dgrd_factura.Name = "dgrd_factura"
        Me.dgrd_factura.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_factura.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_factura.ParentRowsVisible = False
        Me.dgrd_factura.RowHeaderWidth = 0
        Me.dgrd_factura.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_factura.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_factura.Size = New System.Drawing.Size(491, 225)
        Me.dgrd_factura.TabIndex = 2
        Me.dgrd_factura.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgts_registro})
        '
        'dgts_registro
        '
        Me.dgts_registro.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgts_registro.BackColor = System.Drawing.Color.Silver
        Me.dgts_registro.DataGrid = Me.dgrd_factura
        Me.dgts_registro.ForeColor = System.Drawing.Color.Black
        Me.dgts_registro.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgcs_id, Me.dgcs_tipo, Me.dgcs_Cantidad, Me.dgcs_Test, Me.dgcs_Precio, Me.dgcs_total})
        Me.dgts_registro.GridLineColor = System.Drawing.Color.DimGray
        Me.dgts_registro.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgts_registro.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgts_registro.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dgts_registro.HeaderForeColor = System.Drawing.Color.White
        Me.dgts_registro.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgts_registro.MappingName = "Registros"
        Me.dgts_registro.RowHeadersVisible = False
        Me.dgts_registro.RowHeaderWidth = 0
        Me.dgts_registro.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgts_registro.SelectionForeColor = System.Drawing.Color.White
        '
        'dgcs_id
        '
        Me.dgcs_id.Format = ""
        Me.dgcs_id.FormatInfo = Nothing
        Me.dgcs_id.MappingName = "TES_ID"
        Me.dgcs_id.NullText = ""
        Me.dgcs_id.ReadOnly = True
        Me.dgcs_id.Width = 0
        '
        'dgcs_tipo
        '
        Me.dgcs_tipo.Format = ""
        Me.dgcs_tipo.FormatInfo = Nothing
        Me.dgcs_tipo.HeaderText = "Tipo"
        Me.dgcs_tipo.MappingName = "TEST_TIPO"
        Me.dgcs_tipo.NullText = ""
        Me.dgcs_tipo.ReadOnly = True
        Me.dgcs_tipo.Width = 0
        '
        'dgcs_Cantidad
        '
        Me.dgcs_Cantidad.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgcs_Cantidad.Format = "###,##0;###,##0"
        Me.dgcs_Cantidad.FormatInfo = Nothing
        Me.dgcs_Cantidad.HeaderText = "Cant"
        Me.dgcs_Cantidad.MappingName = "FAC_CANTIDAD"
        Me.dgcs_Cantidad.NullText = ""
        Me.dgcs_Cantidad.ReadOnly = True
        Me.dgcs_Cantidad.Width = 50
        '
        'dgcs_Test
        '
        Me.dgcs_Test.Format = ""
        Me.dgcs_Test.FormatInfo = Nothing
        Me.dgcs_Test.HeaderText = "Descripci�n"
        Me.dgcs_Test.MappingName = "TEST_NOMBRE"
        Me.dgcs_Test.NullText = ""
        Me.dgcs_Test.ReadOnly = True
        Me.dgcs_Test.Width = 270
        '
        'dgcs_Precio
        '
        Me.dgcs_Precio.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgcs_Precio.Format = "###,##0.00;###,##0.00"
        Me.dgcs_Precio.FormatInfo = Nothing
        Me.dgcs_Precio.HeaderText = "Val. Unit"
        Me.dgcs_Precio.MappingName = "FAC_PRECIO"
        Me.dgcs_Precio.NullText = ""
        Me.dgcs_Precio.ReadOnly = True
        Me.dgcs_Precio.Width = 80
        '
        'dgcs_total
        '
        Me.dgcs_total.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgcs_total.Format = "###,##0.00;###,##0.00"
        Me.dgcs_total.FormatInfo = Nothing
        Me.dgcs_total.HeaderText = "Val. Total"
        Me.dgcs_total.MappingName = "FAC_TOTAL"
        Me.dgcs_total.NullText = ""
        Me.dgcs_total.ReadOnly = True
        Me.dgcs_total.Width = 80
        '
        'lbl_dsct
        '
        Me.lbl_dsct.BackColor = System.Drawing.Color.White
        Me.lbl_dsct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dsct.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dsct.ForeColor = System.Drawing.Color.Black
        Me.lbl_dsct.Location = New System.Drawing.Point(602, 298)
        Me.lbl_dsct.Name = "lbl_dsct"
        Me.lbl_dsct.Size = New System.Drawing.Size(132, 20)
        Me.lbl_dsct.TabIndex = 104
        Me.lbl_dsct.Text = "Dscto."
        Me.lbl_dsct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dsct_fact
        '
        Me.lbl_dsct_fact.BackColor = System.Drawing.Color.White
        Me.lbl_dsct_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dsct_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_dsct_fact.Location = New System.Drawing.Point(743, 299)
        Me.lbl_dsct_fact.Name = "lbl_dsct_fact"
        Me.lbl_dsct_fact.Size = New System.Drawing.Size(62, 20)
        Me.lbl_dsct_fact.TabIndex = 105
        Me.lbl_dsct_fact.Text = "0.00"
        Me.lbl_dsct_fact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_iva2
        '
        Me.lbl_iva2.BackColor = System.Drawing.Color.White
        Me.lbl_iva2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_iva2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_iva2.ForeColor = System.Drawing.Color.Black
        Me.lbl_iva2.Location = New System.Drawing.Point(602, 340)
        Me.lbl_iva2.Name = "lbl_iva2"
        Me.lbl_iva2.Size = New System.Drawing.Size(132, 20)
        Me.lbl_iva2.TabIndex = 106
        Me.lbl_iva2.Text = "IVA"
        Me.lbl_iva2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_IVA
        '
        Me.lbl_IVA.BackColor = System.Drawing.Color.White
        Me.lbl_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IVA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_IVA.Location = New System.Drawing.Point(743, 341)
        Me.lbl_IVA.Name = "lbl_IVA"
        Me.lbl_IVA.Size = New System.Drawing.Size(62, 20)
        Me.lbl_IVA.TabIndex = 107
        Me.lbl_IVA.Text = "0.00"
        Me.lbl_IVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_textofact
        '
        Me.txt_textofact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_textofact.Location = New System.Drawing.Point(36, 386)
        Me.txt_textofact.MaxLength = 255
        Me.txt_textofact.Multiline = True
        Me.txt_textofact.Name = "txt_textofact"
        Me.txt_textofact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_textofact.Size = New System.Drawing.Size(324, 97)
        Me.txt_textofact.TabIndex = 9
        '
        'btn_anular
        '
        Me.btn_anular.BackColor = System.Drawing.SystemColors.Control
        Me.btn_anular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_anular.Enabled = False
        Me.btn_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anular.ForeColor = System.Drawing.Color.Black
        Me.btn_anular.Image = CType(resources.GetObject("btn_anular.Image"), System.Drawing.Image)
        Me.btn_anular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_anular.Location = New System.Drawing.Point(679, 39)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(80, 40)
        Me.btn_anular.TabIndex = 7
        Me.btn_anular.Text = "Anular"
        Me.btn_anular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_anular.UseVisualStyleBackColor = False
        '
        'lbl_rec_fact
        '
        Me.lbl_rec_fact.BackColor = System.Drawing.Color.White
        Me.lbl_rec_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rec_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_rec_fact.Location = New System.Drawing.Point(743, 320)
        Me.lbl_rec_fact.Name = "lbl_rec_fact"
        Me.lbl_rec_fact.Size = New System.Drawing.Size(62, 20)
        Me.lbl_rec_fact.TabIndex = 111
        Me.lbl_rec_fact.Text = "0.00"
        Me.lbl_rec_fact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(602, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Recargo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(855, 25)
        Me.pan_barra.TabIndex = 112
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(9, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(88, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "FACTURAS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ctl_txt_reten
        '
        Me.Ctl_txt_reten.Location = New System.Drawing.Point(390, 418)
        Me.Ctl_txt_reten.Name = "Ctl_txt_reten"
        Me.Ctl_txt_reten.Prp_Formato = True
        Me.Ctl_txt_reten.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_reten.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_reten.Prp_ValDefault = "0"
        Me.Ctl_txt_reten.Size = New System.Drawing.Size(32, 20)
        Me.Ctl_txt_reten.TabIndex = 113
        Me.Ctl_txt_reten.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(309, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Retencion(%)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'grp_abono
        '
        Me.grp_abono.Controls.Add(Me.btn_pendiente)
        Me.grp_abono.Controls.Add(Me.chk_abono)
        Me.grp_abono.Controls.Add(Me.Ctl_txt_monto)
        Me.grp_abono.Controls.Add(Me.btn_aceptar)
        Me.grp_abono.Location = New System.Drawing.Point(515, 451)
        Me.grp_abono.Name = "grp_abono"
        Me.grp_abono.Size = New System.Drawing.Size(317, 70)
        Me.grp_abono.TabIndex = 116
        Me.grp_abono.TabStop = False
        '
        'btn_pendiente
        '
        Me.btn_pendiente.BackColor = System.Drawing.SystemColors.Control
        Me.btn_pendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pendiente.ForeColor = System.Drawing.Color.Black
        Me.btn_pendiente.Image = CType(resources.GetObject("btn_pendiente.Image"), System.Drawing.Image)
        Me.btn_pendiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pendiente.Location = New System.Drawing.Point(231, 19)
        Me.btn_pendiente.Name = "btn_pendiente"
        Me.btn_pendiente.Size = New System.Drawing.Size(82, 40)
        Me.btn_pendiente.TabIndex = 10
        Me.btn_pendiente.Text = "Pendiente"
        Me.btn_pendiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pendiente.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(14, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "ORDEN:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_orden
        '
        Me.cmb_orden.DisplayMember = "1"
        Me.cmb_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_orden.ItemHeight = 13
        Me.cmb_orden.Items.AddRange(New Object() {"Detalle", "Texto", "Solo Cabecera"})
        Me.cmb_orden.Location = New System.Drawing.Point(102, 40)
        Me.cmb_orden.Name = "cmb_orden"
        Me.cmb_orden.Size = New System.Drawing.Size(88, 21)
        Me.cmb_orden.TabIndex = 98
        '
        'lbl_msg
        '
        Me.lbl_msg.AutoSize = True
        Me.lbl_msg.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_msg.Location = New System.Drawing.Point(406, 49)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(0, 19)
        Me.lbl_msg.TabIndex = 118
        '
        'btn_ImpFactura
        '
        Me.btn_ImpFactura.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ImpFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImpFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpFactura.ForeColor = System.Drawing.Color.Black
        Me.btn_ImpFactura.Image = CType(resources.GetObject("btn_ImpFactura.Image"), System.Drawing.Image)
        Me.btn_ImpFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpFactura.Location = New System.Drawing.Point(205, 39)
        Me.btn_ImpFactura.Name = "btn_ImpFactura"
        Me.btn_ImpFactura.Size = New System.Drawing.Size(85, 40)
        Me.btn_ImpFactura.TabIndex = 119
        Me.btn_ImpFactura.Text = "FACTURA"
        Me.btn_ImpFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpFactura.UseVisualStyleBackColor = False
        '
        'btn_ImpAbono
        '
        Me.btn_ImpAbono.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ImpAbono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImpAbono.Enabled = False
        Me.btn_ImpAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpAbono.ForeColor = System.Drawing.Color.Black
        Me.btn_ImpAbono.Image = CType(resources.GetObject("btn_ImpAbono.Image"), System.Drawing.Image)
        Me.btn_ImpAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpAbono.Location = New System.Drawing.Point(102, 39)
        Me.btn_ImpAbono.Name = "btn_ImpAbono"
        Me.btn_ImpAbono.Size = New System.Drawing.Size(103, 40)
        Me.btn_ImpAbono.TabIndex = 120
        Me.btn_ImpAbono.Text = "NOTA VENTA"
        Me.btn_ImpAbono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpAbono.UseVisualStyleBackColor = False
        '
        'grp_datos
        '
        Me.grp_datos.BackColor = System.Drawing.Color.Silver
        Me.grp_datos.Controls.Add(Me.Ctl_txt_numfact)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_Email)
        Me.grp_datos.Controls.Add(Me.Label5)
        Me.grp_datos.Controls.Add(Me.dtp_fecha_fact)
        Me.grp_datos.Controls.Add(Me.lbl_letrasNum)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_fono)
        Me.grp_datos.Controls.Add(Me.lbl_FACFECHA)
        Me.grp_datos.Controls.Add(Me.lbl_formapago)
        Me.grp_datos.Controls.Add(Me.lbl_fono)
        Me.grp_datos.Controls.Add(Me.cmb_fpago)
        Me.grp_datos.Controls.Add(Me.lbl_numped)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_referfact)
        Me.grp_datos.Controls.Add(Me.lbl_numfact)
        Me.grp_datos.Controls.Add(Me.Label2)
        Me.grp_datos.Controls.Add(Me.lbl_pedido)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_apellido)
        Me.grp_datos.Controls.Add(Me.Label4)
        Me.grp_datos.Controls.Add(Me.lbl_tipdoc)
        Me.grp_datos.Controls.Add(Me.lbl_apellidos)
        Me.grp_datos.Controls.Add(Me.cmb_tipodoc)
        Me.grp_datos.Controls.Add(Me.cmb_orden)
        Me.grp_datos.Controls.Add(Me.ctl_txt_doc)
        Me.grp_datos.Controls.Add(Me.ctl_txt_dir)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Controls.Add(Me.ctl_txt_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_dir)
        Me.grp_datos.Location = New System.Drawing.Point(18, 85)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(491, 226)
        Me.grp_datos.TabIndex = 121
        Me.grp_datos.TabStop = False
        '
        'Ctl_txt_numfact
        '
        Me.Ctl_txt_numfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_numfact.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_numfact.Location = New System.Drawing.Point(102, 15)
        Me.Ctl_txt_numfact.Name = "Ctl_txt_numfact"
        Me.Ctl_txt_numfact.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_numfact.Prp_CaracterPasswd = ""
        Me.Ctl_txt_numfact.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_numfact.Size = New System.Drawing.Size(88, 20)
        Me.Ctl_txt_numfact.TabIndex = 127
        '
        'Ctl_txt_Email
        '
        Me.Ctl_txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Email.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_Email.Location = New System.Drawing.Point(102, 201)
        Me.Ctl_txt_Email.Name = "Ctl_txt_Email"
        Me.Ctl_txt_Email.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Email.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Email.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_Email.Size = New System.Drawing.Size(318, 20)
        Me.Ctl_txt_Email.TabIndex = 126
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(13, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "EMAIL"
        '
        'lbl_letrasNum
        '
        Me.lbl_letrasNum.AutoSize = True
        Me.lbl_letrasNum.Location = New System.Drawing.Point(299, 132)
        Me.lbl_letrasNum.Name = "lbl_letrasNum"
        Me.lbl_letrasNum.Size = New System.Drawing.Size(18, 16)
        Me.lbl_letrasNum.TabIndex = 124
        Me.lbl_letrasNum.Text = "()"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_convenio)
        Me.GroupBox1.Controls.Add(Me.lbl_conve)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_abo)
        Me.GroupBox1.Location = New System.Drawing.Point(515, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 71)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(24, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "FECHA DOC"
        '
        'btn_recibo
        '
        Me.btn_recibo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_recibo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_recibo.ForeColor = System.Drawing.Color.Black
        Me.btn_recibo.Image = CType(resources.GetObject("btn_recibo.Image"), System.Drawing.Image)
        Me.btn_recibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_recibo.Location = New System.Drawing.Point(18, 39)
        Me.btn_recibo.Name = "btn_recibo"
        Me.btn_recibo.Size = New System.Drawing.Size(84, 40)
        Me.btn_recibo.TabIndex = 123
        Me.btn_recibo.Text = "RECIBO"
        Me.btn_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_recibo.UseVisualStyleBackColor = False
        '
        'cons_total
        '
        Me.cons_total.AutoSize = True
        Me.cons_total.Location = New System.Drawing.Point(757, 430)
        Me.cons_total.Name = "cons_total"
        Me.cons_total.Size = New System.Drawing.Size(47, 16)
        Me.cons_total.TabIndex = 126
        Me.cons_total.Text = "(Total)"
        '
        'lbl_subtot_fact
        '
        Me.lbl_subtot_fact.BackColor = System.Drawing.Color.White
        Me.lbl_subtot_fact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtot_fact.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_subtot_fact.Location = New System.Drawing.Point(743, 278)
        Me.lbl_subtot_fact.Name = "lbl_subtot_fact"
        Me.lbl_subtot_fact.Size = New System.Drawing.Size(62, 20)
        Me.lbl_subtot_fact.TabIndex = 98
        Me.lbl_subtot_fact.Text = "0.00"
        Me.lbl_subtot_fact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_tot_fact
        '
        Me.lbl_tot_fact.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot_fact.Location = New System.Drawing.Point(742, 421)
        Me.lbl_tot_fact.Name = "lbl_tot_fact"
        Me.lbl_tot_fact.Prp_Formato = True
        Me.lbl_tot_fact.Prp_NumDecimales = CType(2, Short)
        Me.lbl_tot_fact.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.lbl_tot_fact.Prp_ValDefault = "0"
        Me.lbl_tot_fact.Size = New System.Drawing.Size(64, 27)
        Me.lbl_tot_fact.TabIndex = 128
        '
        'btn_enviaFac
        '
        Me.btn_enviaFac.BackColor = System.Drawing.SystemColors.Control
        Me.btn_enviaFac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enviaFac.Enabled = False
        Me.btn_enviaFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviaFac.ForeColor = System.Drawing.Color.Black
        Me.btn_enviaFac.Image = CType(resources.GetObject("btn_enviaFac.Image"), System.Drawing.Image)
        Me.btn_enviaFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enviaFac.Location = New System.Drawing.Point(290, 39)
        Me.btn_enviaFac.Name = "btn_enviaFac"
        Me.btn_enviaFac.Size = New System.Drawing.Size(89, 40)
        Me.btn_enviaFac.TabIndex = 130
        Me.btn_enviaFac.Text = "FACTURA"
        Me.btn_enviaFac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enviaFac.UseVisualStyleBackColor = False
        Me.btn_enviaFac.Visible = False
        '
        'Frm_Factura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(855, 554)
        Me.Controls.Add(Me.Ctl_txt_dsct)
        Me.Controls.Add(Me.lbl_dscto)
        Me.Controls.Add(Me.btn_enviaFac)
        Me.Controls.Add(Me.lbl_tot_fact)
        Me.Controls.Add(Me.cons_total)
        Me.Controls.Add(Me.btn_recibo)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.cmb_fimp)
        Me.Controls.Add(Me.lbl_msg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_imp)
        Me.Controls.Add(Me.btn_ImpAbono)
        Me.Controls.Add(Me.btn_ImpFactura)
        Me.Controls.Add(Me.grp_abono)
        Me.Controls.Add(Me.dgrd_factura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Ctl_txt_reten)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.lbl_rec_fact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_anular)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_dsct_fact)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.lbl_abonos)
        Me.Controls.Add(Me.lbl_saldo_fact)
        Me.Controls.Add(Me.lbl_abono_fact)
        Me.Controls.Add(Me.lbl_iva2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_IVA)
        Me.Controls.Add(Me.lbl_subtot_fact)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.lbl_dsct)
        Me.Controls.Add(Me.Ctl_txt_iva)
        Me.Controls.Add(Me.lbl_iva1)
        Me.Controls.Add(Me.Ctl_txt_rec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_textofact)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Factura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "1"
        Me.Text = "FACTURACION"
        CType(Me.dgrd_factura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_abono.ResumeLayout(False)
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public frm_refer_main_form As Frm_Main
    Public str_arr_pedidos() As Long
    Public dtt_tabla As New DataTable("Registros")
    Private opr_pedido As New Cls_Pedido()
    Private opr_factura As New Cls_Factura()
    Private dtv_tabla As New DataView(dtt_tabla)
    Public opr_negocio As New Cls_Pedido()
    Private int_AbonoEstado As Integer

#Region "Codigo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    'Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Public fecha_ord As String
    Public pac_id As Integer
    Public pac_nombre As String = Nothing
    Public pac_doc As String = Nothing
    Dim Flag_Pendiente As Boolean = False




    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp
        If e.Button = MouseButtons.Left Then
            'Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            'frm_refer_main_form.limpiaGrp()
            'Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseMove
        'ClickMenu_Principal(Me)
        ''Funci�n para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
        'If e.Button = MouseButtons.Left Then
        '    Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
        '    mousePos.Offset(mouse_offset.X, mouse_offset.Y)
        '    dbl_x = mousePos.X
        '    frm_refer_main_form.ubica(Me.Width, Me.Height, mousePos.Y, mousePos.X - frm_refer_main_form.Splitter.Width)
        'End If
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


    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, lbl_textform.Click
        'elimina las funciones activas (ej menu) del formulario MDI.
        Dim int_posX As Integer
        'int_posX = (Me.MdiParent.Size.Width - Me.MdiParent.Size.Width)
        ClickMenu_Principal(Me)
        Select Case sender.name
            Case "Pic_close"
                g_numOrden = Nothing
                g_lng_ped_id = Nothing
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

#Region "Funcionalidad del formulario"

    Sub Calcula_porcentaje()

        Dim dbl_porcentaje As Double = 0
        'lbl_subtot_fact.Text = CStr((CDbl(lbl_tot_fact.texto_Recupera) * 100) / CDbl(cons_total.Text))
        Ctl_txt_dsct.texto_Asigna(CStr(Round(100 - (CDbl(lbl_tot_fact.texto_Recupera) * 100) / CDbl(cons_total.Text), 2)))
        lbl_dsct_fact.Text = Format(CDbl(lbl_subtot_fact.Text) - CDbl(lbl_tot_fact.texto_Recupera), "###,##0.00")
        lbl_saldo_fact.Text = lbl_tot_fact.texto_Recupera()
    End Sub


    Sub Calcula_total()

        Dim dbl_precio As Double = 0
        Dim int_indice As Integer = 0
        If Trim(Ctl_txt_iva.texto_Recupera) = "" Then Ctl_txt_iva.texto_Asigna(0)
        If Trim(Ctl_txt_dsct.texto_Recupera) = "" Then Ctl_txt_dsct.texto_Asigna(0)
        If Trim(Ctl_txt_rec.texto_Recupera) = "" Then Ctl_txt_rec.texto_Asigna(0)
        If dtt_tabla.Rows.Count > 0 Then
            For int_indice = 0 To dtt_tabla.Rows.Count - 1
                If dgrd_factura(int_indice, 2).ToString = "" Then dtt_tabla.Rows(int_indice).Item(2) = 1
                If dgrd_factura(int_indice, 4).ToString = "" Then dtt_tabla.Rows(int_indice).Item(4) = 0
                dtt_tabla.Rows(int_indice).Item(5) = CInt(dgrd_factura(int_indice, 2)) * CDbl(dgrd_factura(int_indice, 4))
                dbl_precio = CDbl(dgrd_factura(int_indice, 5)) + dbl_precio
            Next
        End If
        lbl_subtot_fact.Text = Format(dbl_precio, "###,##0.00")
        lbl_dsct_fact.Text = Format(CDbl(dbl_precio) * CDbl(Ctl_txt_dsct.texto_Recupera) / 100, "###,##0.00")
        lbl_rec_fact.Text = Format(CDbl(dbl_precio) * CDbl(Ctl_txt_rec.texto_Recupera) / 100, "###,##0.00")
        dbl_precio = Format(CDbl(lbl_subtot_fact.Text) - CDbl(lbl_dsct_fact.Text) + CDbl(lbl_rec_fact.Text), "###,##0.00")
        lbl_IVA.Text = Format(dbl_precio * CInt(Ctl_txt_iva.texto_Recupera) / 100, "###,##0.00")
        'lbl_tot_fact.Text = Format(dbl_precio + CDbl(lbl_IVA.Text), "###,##0.00")
        lbl_tot_fact.Text = Format(dbl_precio + CDbl(lbl_IVA.Text), "###,##0.00")
        lbl_tot_fact.texto_Asigna(Format(dbl_precio + CDbl(lbl_IVA.Text), "###,##0.00"))
        cons_total.Text = Format(dbl_precio + CDbl(lbl_IVA.Text), "###,##0.00")
        lbl_saldo_fact.Text = Format(CDbl(lbl_tot_fact.Text) - CDbl(lbl_abono_fact.Text), "###,##0.00")

    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        g_numOrden = Nothing
        g_lng_ped_id = Nothing
        Me.Close()
    End Sub

    Sub Efecto_grid()
        On Error Resume Next
        Dim pos_colnum, pos_rownum As Integer
        Dim cell_index As DataGridCell
        pos_colnum = dgrd_factura.CurrentCell.ColumnNumber
        pos_rownum = dgrd_factura.CurrentCell.RowNumber
        cell_index.ColumnNumber = 0
        cell_index.RowNumber = pos_rownum
        dgrd_factura.CurrentCell = cell_index
        dgrd_factura.Select(pos_rownum)
        Calcula_total()
    End Sub

    Private Sub Maneja_Grid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_factura.CurrentCellChanged, dgrd_factura.Click
        Call Efecto_grid()
    End Sub

    Private Sub dgrd_factura_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_factura.Enter
        Call Efecto_grid()
    End Sub

    ''Calcula_total()
    ''    If Ctl_txt_dsct.texto_Recupera() <> "" Then
    ''        Ctl_txt_refer.texto_Asigna("Descuento del " & Ctl_txt_dsct.texto_Recupera() & " %")
    ''    End If

    ''    If Ctl_txt_rec.texto_Recupera() <> "" Then
    ''        Ctl_txt_refer.texto_Asigna("Recargo del " & Ctl_txt_rec.texto_Recupera() & " %")
    ''    End If

    Sub habilita_ChechedAbono()
        'lbl_monto.Enabled = chk_abono.Checked

        'Ctl_txt_monto.Enabled = chk_abono.Checked
        'dtp_fecha_abo.Enabled = chk_abono.Checked
        'btn_aceptar.Enabled = True
        'Ctl_txt_refer.Enabled = chk_abono.Checked
    End Sub

    Private Sub chk_abono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_abono.CheckedChanged
        If chk_abono.Checked = True Then
            Ctl_txt_monto.texto_Asigna(lbl_saldo_fact.Text)
            btn_aceptar.Enabled = True
            btn_pendiente.Enabled = False
        Else
            Ctl_txt_monto.texto_Asigna("0.00")
            btn_aceptar.Enabled = False
            btn_pendiente.Enabled = True
        End If
    End Sub

    Sub cambia_tipo_doc()
        Select Case cmb_tipodoc.Text
            Case "CEDULA"
                ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
            Case "RUC"
                ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.RUC
            Case "PASAPORTE"
                ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Pasaporte
            Case "NINGUNO"
                ctl_txt_doc.Visible = False
        End Select
    End Sub

    Private Sub cmb_tipdoc_cambiaIndex(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipodoc.SelectedIndexChanged
        ctl_txt_doc.Visible = True
        ctl_txt_doc.texto_Asigna("")
        cambia_tipo_doc()
    End Sub

    Sub limpia()
        cmb_fpago.SelectedIndex = 0
        cmb_tipodoc.SelectedIndex = 0
        cmb_fimp.SelectedIndex = 0
        Ctl_txt_numfact.texto_Asigna("")
        Ctl_txt_apellido.texto_Asigna("")
        ctl_txt_nombre.texto_Asigna("")
        ctl_txt_doc.texto_Asigna("")
        Ctl_txt_fono.texto_Asigna("")
        Ctl_txt_referfact.texto_Asigna("")
        '''dtt_tabla.Clear()
        txt_textofact.Text = ""
        chk_abono.Checked = False
        habilita_ChechedAbono()
        Ctl_txt_monto.texto_Asigna("")
        Ctl_txt_dsct.texto_Asigna(0)
        Ctl_txt_iva.texto_Asigna(0)
        Ctl_txt_rec.texto_Asigna(0)
        lbl_subtot_fact.Text = 0
        lbl_dsct_fact.Text = 0
        lbl_rec_fact.Text = 0
        lbl_IVA.Text = 0
        lbl_tot_fact.Text = 0
        lbl_abono_fact.Text = 0
        lbl_saldo_fact.Text = 0
        lbl_numped.Text = "-"
        lbl_convenio.Text = "-"
    End Sub

    Public Sub IniciaForm()
        Call limpia()
        Ctl_txt_iva.txt_padre.MaxLength = 2
        Ctl_txt_iva.txt_padre.TextAlign = HorizontalAlignment.Right
        Ctl_txt_dsct.txt_padre.MaxLength = 4
        Ctl_txt_dsct.txt_padre.TextAlign = HorizontalAlignment.Right
        Ctl_txt_rec.txt_padre.MaxLength = 4
        Ctl_txt_rec.txt_padre.TextAlign = HorizontalAlignment.Right
        lbl_tot_fact.txt_padre.TextAlign = HorizontalAlignment.Right
        Ctl_txt_monto.texto_Asigna("0.00")
        llena_datos()
        Calcula_total()
    End Sub

    Private Sub Frm_Factura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        dtp_fecha_fact.CustomFormat = "dd-MMM-yyyy"
        dtp_fecha_abo.CustomFormat = "dd-MMM-yyyy"
        IniciaForm()
    End Sub


    Private Sub cmb_fimp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_fimp.SelectedIndexChanged
        Select Case cmb_fimp.Text
            Case "Detalle"
                dgrd_factura.BringToFront()
            Case "Texto"
                txt_textofact.BringToFront()
                txt_textofact.SelectionStart = Len(txt_textofact.Text)
            Case Else
        End Select
    End Sub

#End Region

    Function ValidaAbono(ByRef int_AbonoEstado As Integer) As Boolean

        ValidaAbono = False
        int_AbonoEstado = 1
        If chk_abono.Checked Then
            If Trim(Ctl_txt_monto.texto_Recupera) = "" Then
                MsgBox("Ingrese el monto del abono", MsgBoxStyle.Information, "ANALISYS")
                Exit Function
            End If
            If Trim(lbl_saldo_fact.Text) = "" Then lbl_saldo_fact.Text = 0
            If CDbl(Ctl_txt_monto.texto_Recupera) = CDbl(lbl_saldo_fact.Text) Then
                MsgBox("El monto abonado cancelara el pago", MsgBoxStyle.Information, "ANALISYS")
                int_AbonoEstado = 2
            ElseIf CDbl(Ctl_txt_monto.texto_Recupera) > CDbl(lbl_saldo_fact.Text) Then
                MsgBox("El monto abonado NO puede ser superior al saldo existente", MsgBoxStyle.Information, "ANALISYS")
                Exit Function
            End If
            ValidaAbono = True
        End If

    End Function

#Region "Recuperar y llenar datos de pedido"


    Sub Llena_detalle_pedido(ByVal cod_pedido As Long)
        'para el ingreso de factura
        Dim int_indice, int_indice2 As Integer
        Dim str_facid As String
        Dim dtr_operacion, dtr_fila, dtr_filareg As DataRow
        Dim dts_pedidos As New DataSet()
        Dim dts_facturas As New DataSet()
        Dim dts_EstadoFact As New DataSet()
        Dim numfac As String = Nothing
        Dim dbl_convenio, dbl_valor As Double
        limpia()
        Ctl_txt_numfact.Enabled = True
        If g_lng_ped_nunfact <> 0 Then
            str_facid = g_lng_ped_nunfact
        Else
            str_facid = opr_factura.LeerMaxFactura()
        End If
        Ctl_txt_numfact.texto_Asigna(str_facid)
        dts_pedidos.Clear()
        'PRIMERO LEO EL ESTADO DE LA FACTURA 
        If opr_pedido.LeerEstadoFactura(cod_pedido, numfac) = 0 Then
            dts_pedidos = opr_pedido.LeerPedidoFactura(cod_pedido)
            If dts_pedidos.Tables(0).Rows.Count > 0 Then
                dtr_operacion = dts_pedidos.Tables(0).Rows(0)
                If Not IsDBNull(dtr_operacion(0)) Then
                    dtp_fecha_fact.Value = dtr_operacion(0)
                    Ctl_txt_apellido.texto_Asigna(dtr_operacion(3))
                    ctl_txt_nombre.texto_Asigna(dtr_operacion(4))
                    ctl_txt_dir.texto_Asigna(dtr_operacion(5))
                    cmb_tipodoc.SelectedIndex = dtr_operacion(1) - 1
                    ctl_txt_doc.texto_Asigna(dtr_operacion(2))
                    Ctl_txt_fono.texto_Asigna(dtr_operacion(6))
                    lbl_convenio.Text = dtr_operacion(7)
                    lbl_numped.Text = cod_pedido
                    lbl_msg.Text = numfac
                    'Ctl_txt_numfact.texto_Asigna(numfac)
                    ''''dts_facturas.Clear()
                    dts_facturas = opr_pedido.LeerDetPedidoFactura(cod_pedido)
                    '''dtt_tabla.Clear()


                    If dts_facturas.Tables(0).Rows.Count > 0 Then
                        For int_indice = 0 To dts_facturas.Tables(0).Rows.Count - 1
                            dtr_filareg = dts_facturas.Tables(0).Rows(int_indice)
                            dtr_fila = dtt_tabla.NewRow()
                            If Not IsDBNull(dtr_filareg(1)) Then
                                Dim opr_perfil As New Cls_Perfil()
                                dbl_valor = opr_perfil.LeerPrecioPerfil(dtr_filareg(0), dtr_operacion(7))
                                dtr_fila(0) = dtr_filareg(1)
                                dtr_fila(1) = "Perfil"
                                dtr_fila(3) = dtr_filareg(0)
                                dtr_fila(4) = dbl_valor
                                dtr_fila(5) = CDbl(dtr_filareg(5).ToString) * CDbl(dtr_fila(4))
                            Else
                                Dim opr_test As New Cls_Test()
                                dbl_valor = opr_test.LeerPrecioTest(dtr_filareg(3), dtr_operacion(7))
                                dtr_fila(0) = dtr_filareg(3)
                                dtr_fila(1) = "Test"
                                dtr_fila(3) = dtr_filareg(2)
                                dtr_fila(4) = dbl_valor
                                dtr_fila(5) = CDbl(dtr_filareg(5).ToString) * CDbl(dtr_fila(4))
                            End If
                            dtr_fila(2) = dtr_filareg(5)
                            dtt_tabla.Rows.Add(dtr_fila)
                            Calcula_total()

                        Next
                    Else
                        MsgBox("No existe detalle de Pedido No. " & cod_pedido & " para completar la factura. operacion Interumpida", MsgBoxStyle.Information, "ANALISYS")
                        Me.Close()
                    End If
                Else
                    MsgBox("No existe detalle de Pedido No. " & cod_pedido & " para completar la factura. operacion Interumpida", MsgBoxStyle.Information, "ANALISYS")
                    Me.Close()
                End If
            Else
                MsgBox("No existe detalle de Pedido No. " & cod_pedido & " para completar la factura. operacion Interumpida", MsgBoxStyle.Information, "ANALISYS")
                Me.Close()
            End If
        Else
            If cod_pedido > 0 Then
                'dts_pedidos = opr_factura.LeerFactura(numfac)
                lbl_msg.Text = "FACTURA GENERADA"

                ''Llena_detalle_factura(Ctl_txt_numfact.texto_Recupera)
                Llena_detalle_factura(numfac)
                Ctl_txt_numfact.Enabled = False
                If cod_pedido = "4" Then
                    lbl_msg.Text = "FACTURA A MODIFICAR"
                    chk_abono.Checked = True
                    habilita_ChechedAbono()
                    chk_abono.Enabled = False
                End If

            End If
        End If
    End Sub


    Sub Llena_detalle_pedido(ByVal cod_pedido As Long, ByVal numfac As String)
        'para el ingreso de factura
        Dim int_indice, int_indice2 As Integer
        Dim str_facid As String
        Dim dtr_operacion, dtr_fila, dtr_filareg As DataRow
        Dim dts_pedidos As New DataSet()
        Dim dts_facturas As New DataSet()
        Dim dts_EstadoFact As New DataSet()
        Dim dbl_convenio, dbl_valor As Double
        limpia()
        Ctl_txt_numfact.Enabled = True
        If numfac > 0 Then
            str_facid = opr_factura.LeerMaxFactura()
        Else
            str_facid = numfac
        End If

        Ctl_txt_numfact.texto_Asigna(str_facid)
        dts_pedidos.Clear()
        'PRIMERO LEO EL ESTADO DE LA FACTURA 
        If opr_pedido.LeerEstadoFactura(cod_pedido, numfac) = 0 Then
            dts_pedidos = opr_pedido.LeerPedidoFactura(cod_pedido)
            If dts_pedidos.Tables(0).Rows.Count > 0 Then
                dtr_operacion = dts_pedidos.Tables(0).Rows(0)
                If Not IsDBNull(dtr_operacion(0)) Then
                    dtp_fecha_fact.Value = dtr_operacion(0)
                    Ctl_txt_apellido.texto_Asigna(dtr_operacion(3))
                    ctl_txt_nombre.texto_Asigna(dtr_operacion(4))
                    ctl_txt_dir.texto_Asigna(dtr_operacion(5))
                    cmb_tipodoc.SelectedIndex = dtr_operacion(1) - 1
                    ctl_txt_doc.texto_Asigna(dtr_operacion(2))
                    Ctl_txt_fono.texto_Asigna(dtr_operacion(6))
                    lbl_convenio.Text = dtr_operacion(7)
                    lbl_numped.Text = cod_pedido
                    lbl_msg.Text = numfac

                    ''''dts_facturas.Clear()
                    dts_facturas = opr_pedido.LeerDetPedidoFactura(cod_pedido)
                    '''dtt_tabla.Clear()

                    If dts_facturas.Tables(0).Rows.Count > 0 Then
                        For int_indice = 0 To dts_facturas.Tables(0).Rows.Count - 1
                            dtr_filareg = dts_facturas.Tables(0).Rows(int_indice)
                            dtr_fila = dtt_tabla.NewRow()
                            If Not IsDBNull(dtr_filareg(1)) Then
                                Dim opr_perfil As New Cls_Perfil()
                                dbl_valor = opr_perfil.LeerPrecioPerfil(dtr_filareg(0), dtr_operacion(7))
                                dtr_fila(0) = dtr_filareg(1)
                                dtr_fila(1) = "Perfil"
                                dtr_fila(3) = dtr_filareg(0)
                                dtr_fila(4) = dbl_valor
                                dtr_fila(5) = CDbl(dtr_filareg(5).ToString) * CDbl(dtr_fila(4))
                            Else
                                Dim opr_test As New Cls_Test()
                                dbl_valor = opr_test.LeerPrecioTest(dtr_filareg(3), dtr_operacion(7))
                                dtr_fila(0) = dtr_filareg(3)
                                dtr_fila(1) = "Test"
                                dtr_fila(3) = dtr_filareg(2)
                                dtr_fila(4) = dbl_valor
                                dtr_fila(5) = CDbl(dtr_filareg(5).ToString) * CDbl(dtr_fila(4))
                            End If
                            dtr_fila(2) = dtr_filareg(5)
                            dtt_tabla.Rows.Add(dtr_fila)
                            Calcula_total()

                        Next
                    Else
                        MsgBox("No existe detalle de Pedido No. " & cod_pedido & " para completar la factura. operacion Interumpida", MsgBoxStyle.Information, "ANALISYS")
                        Me.Close()
                    End If
                Else
                    MsgBox("No existe detalle de Pedido No. " & cod_pedido & " para completar la factura. operacion Interumpida", MsgBoxStyle.Information, "ANALISYS")
                    Me.Close()
                End If
            Else
                MsgBox("No existe detalle de Pedido No. " & cod_pedido & " para completar la factura. operacion Interumpida", MsgBoxStyle.Information, "ANALISYS")
                Me.Close()
            End If
        Else
            If cod_pedido > 0 Then
                'dts_pedidos = opr_factura.LeerFactura(numfac)
                lbl_msg.Text = "FACTURA GENERADA"

                ''Llena_detalle_factura(Ctl_txt_numfact.texto_Recupera)
                Llena_detalle_factura(numfac)
                Ctl_txt_numfact.Enabled = False
                If cod_pedido = "4" Then
                    lbl_msg.Text = "FACTURA A MODIFICAR"
                    chk_abono.Checked = True
                    habilita_ChechedAbono()
                    chk_abono.Enabled = False
                End If

            End If
        End If




    End Sub

#End Region


#Region "Recuperar y Llenar datos de factura"
    Sub Llena_detalle_factura(ByVal cod_factura As String)
        'para el ingreso de factura
        Dim int_indice, int_indice2 As Integer
        Dim dbl_sumabono As Double = 0
        Dim str_facid As String
        Dim dtr_operacion, dtr_fila, dtr_filareg As DataRow
        Dim dts_facturas As New DataSet()
        Dim dbl_convenio As Double = 0
        Dim sht_indice As Short = 0

        Dim dts_aux As New DataSet()
        Dim dtr_aux As DataRow

        str_facid = cod_factura
        limpia()
        Ctl_txt_numfact.texto_Asigna(str_facid)

        dts_facturas = opr_factura.LeerFactura(cod_factura)
        dtr_operacion = dts_facturas.Tables(0).Rows(0)
        If dts_facturas.Tables(0).Rows.Count > 0 Then
            If Not IsDBNull(dtr_operacion(0)) Then
                dtp_fecha_fact.Value = dtr_operacion(2)
                Ctl_txt_apellido.texto_Asigna(dtr_operacion(7))
                ctl_txt_nombre.texto_Asigna(dtr_operacion(6))
                ctl_txt_dir.texto_Asigna(dtr_operacion(9))
                cmb_tipodoc.SelectedIndex = dtr_operacion(1) - 1
                ctl_txt_doc.texto_Asigna(dtr_operacion(0))
                Ctl_txt_fono.texto_Asigna(dtr_operacion(8))
                txt_textofact.Text = dtr_operacion(15).ToString
                Ctl_txt_dsct.texto_Asigna(dtr_operacion(5))
                Ctl_txt_rec.texto_Asigna(dtr_operacion(16).ToString)
                Ctl_txt_iva.texto_Asigna(dtr_operacion(4))
                Ctl_txt_referfact.texto_Asigna(dtr_operacion(17).ToString)

                If Not IsDBNull(dtr_operacion(18)) Then
                    If Trim(dtr_operacion(18)) <> "" Then
                        sht_indice = dtr_operacion(18)
                    End If
                End If
                cmb_fpago.SelectedIndex = sht_indice - 1

                'significa que visualiza existe detalle
                If txt_textofact.Text = "" Then
                    cmb_fimp.SelectedIndex = 0
                Else
                    cmb_fimp.SelectedIndex = 1
                End If

                'suma de abonos
                lbl_abono_fact.Text = Format(opr_factura.LeerSumAbonos(cod_factura), "###,##0.00")
                lbl_convenio.Text = "-"
                lbl_numped.Text = "-"
                Dim opr_pedido As New Cls_Pedido()
                dts_aux = opr_pedido.LeerPedidoDeFactura(cod_factura)
                If dts_aux.Tables(0).Rows.Count = 1 Then
                    dtr_aux = dts_aux.Tables(0).Rows(0)
                    If Not IsDBNull(dtr_aux(0)) Then
                        lbl_numped.Text = dtr_aux(0)
                        lbl_convenio.Text = dtr_aux(2)
                    End If
                End If

                For int_indice = 0 To dts_facturas.Tables(0).Rows.Count - 1
                    dtr_filareg = dts_facturas.Tables(0).Rows(int_indice)
                    dtr_fila = dtt_tabla.NewRow()
                    If Not IsDBNull(dtr_filareg(0)) Then
                        dtr_fila(0) = dtr_filareg(13)

                        If UCase(dtr_filareg(14)) = "P" Then
                            dtr_fila(1) = "Perfil"
                            Dim opr_perfil As New Cls_Perfil()
                            dts_aux = opr_perfil.BuscarPerfilID(dtr_fila(0))
                        Else
                            dtr_fila(1) = "Test"
                            Dim opr_tipotest As New Cls_TipoTest()
                            dts_aux = opr_tipotest.ConsultarTest(dtr_fila(0))
                        End If
                        If dts_aux.Tables(0).Rows.Count > 0 Then
                            dtr_aux = dts_aux.Tables(0).Rows(0)
                            If Not IsDBNull(dtr_aux(0)) Then
                                dtr_fila(3) = dtr_aux(0)   'nombre test o perfil
                            End If
                        End If
                        dtr_fila(2) = dtr_filareg(11).ToString()
                        dtr_fila(4) = dtr_filareg(12).ToString()
                        dtr_fila(5) = CDbl(dtr_fila(2)) * CDbl(dtr_fila(4))
                        dtt_tabla.Rows.Add(dtr_fila)
                    End If
                Next

                Calcula_total()
            Else
                MsgBox("No existe detalle de la Factura No. " & cod_factura & " para completar la factura. operacion Interumpida", MsgBoxStyle.Information, "ANALISYS")
                Me.Close()
            End If
        End If
    End Sub
#End Region

    Sub llena_datos()
        Dim opr_fac As New Cls_Factura()
        Dim saldo As String = ""
        Dim int_indice As Integer
        Dim num_fac As String = Nothing

        dtv_tabla.AllowNew = False
        dtv_tabla.AllowDelete = False
        dgrd_factura.DataSource = dtv_tabla

        Dim STR_CAPTION As String() = {"TES_ID", "TEST_TIPO", "FAC_CANTIDAD", "TEST_NOMBRE", "FAC_PRECIO", "FAC_TOTAL"}
        For int_indice = 0 To 5
            Dim dtc_columna As New DataColumn(STR_CAPTION(int_indice))
            Select Case int_indice
                Case 2
                    dtc_columna.DataType = Type.GetType("System.Int32")
                Case 3
                    dtc_columna.DataType = Type.GetType("System.String")
                Case 4
                    dtc_columna.DataType = Type.GetType("System.Double")
                Case 5
                    dtc_columna.DataType = Type.GetType("System.Double")

            End Select
            dtt_tabla.Columns.Add(dtc_columna)
        Next

        'colummas de 
        '0 --> Id del test      '1 --> tipo de test (P=perfil o T=test)
        '2 --> cantidad         '3 --> nombre del test o perfil
        '4 --> precio           '5 --> total

        'Me.tag
        '1 --> Genera nueva factura por un pedido y puede abonar
        '2 --> Modifica factura
        '3 --> Inserta nueva factura por un grupo de pedidos y puede abonar
        '4 --> Abona
        '5 --> Anular

        saldo = CStr(CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), 2))
        fecha_ord = opr_fac.ConsultaFechaOrden(g_lng_ped_id)

        If saldo > 0 Then
            Me.Tag = "4"
        End If
        cmb_orden.Enabled = False

        lbl_msg.Text = ""
        Select Case Me.Tag

            'AQUI CAMBIAR FECHA DE ACUERDO AL NUM DE ORDEN'
            Case "Registrada", "FACTURA", "Nota de Venta", "NOTAVENTA", "Cancelada"
                If fecha_ord = Nothing Then
                    fecha_ord = Convert.ToDateTime(Now)
                End If
                opr_factura.ConsultaOrdenFactura(Convert.ToDateTime(fecha_ord), cmb_orden, g_lng_ped_id)
                cmb_orden.Enabled = True
                lbl_textform.Text = "  Re impresion de Facturas/Notas de Venta"
                lbl_msg.Text = "  Re impresion"
                dgrd_factura.Enabled = False
                btn_anular.Enabled = False
                btn_aceptar.Enabled = False
                Ctl_txt_dsct.Enabled = False
                Ctl_txt_rec.Enabled = False
                Ctl_txt_iva.Enabled = False
                'grp_datos.Enabled = False
                grp_abono.Enabled = False
                btn_ImpAbono.Enabled = True
                btn_ImpFactura.Enabled = True
                GroupBox1.Enabled = False
                grp_datos.Enabled = False


            Case "1"

                lbl_textform.Text = "Generar Facturas"
                opr_factura.ConsultaOrdenFactura(Convert.ToDateTime(fecha_ord), cmb_orden, g_lng_ped_id)
                'num_fac = opr_factura.ObtieneNumFactura(g_lng_ped_id)

                'Ctl_txt_numfact.texto_Asigna(num_fac)
                lbl_msg.Text = "  Generar Facturas"
                'txt_textofact.Text = "Factura del Pedido : " & g_lng_ped_id
            Case "2"
                If fecha_ord = Nothing Then
                    fecha_ord = Convert.ToDateTime(Now)
                End If
                opr_factura.ConsultaOrdenFactura(Convert.ToDateTime(fecha_ord), cmb_orden, g_lng_ped_id)
                lbl_textform.Text = "Modificar Facturas / Abonos"
                lbl_msg.Text = "  Modificar Facturas"
                grp_abono.Enabled = False
            Case "3"
                lbl_textform.Text = "Insertar Facturas Agrupadas / Abonos"
                Dim str_pedidos As String

                str_pedidos = "Factura del detalle de los Pedidos: "
                For int_indice = 0 To UBound(str_arr_pedidos) - 1
                    Llena_detalle_pedido(str_arr_pedidos(int_indice))
                    str_pedidos = str_pedidos & Trim(str_arr_pedidos(int_indice)) & ", "
                Next
                txt_textofact.Text = Mid(str_pedidos, 1, Len(str_pedidos) - 2)
                If UBound(str_arr_pedidos) <> 1 Then
                    lbl_convenio.Text = "-"
                    lbl_numped.Text = "-"
                End If
            Case "4"
                opr_factura.ConsultaOrdenFactura(Convert.ToDateTime(fecha_ord), cmb_orden, g_lng_ped_id)

                'g_lng_ped_id = Trim(Mid(cmb_orden.Text, 21, 40))
                'Llena_detalle_pedido(g_lng_ped_id)

                lbl_textform.Text = "  Insertar Abonos"
                dgrd_factura.Enabled = False
                Ctl_txt_dsct.Enabled = False
                Ctl_txt_rec.Enabled = False
                Ctl_txt_iva.Enabled = False
                grp_datos.Enabled = False
                chk_abono.Checked = True
                habilita_ChechedAbono()
                chk_abono.Enabled = False
                If lbl_abono_fact.Text <> "0.00" Then
                    btn_ImpAbono.Enabled = True
                Else
                    btn_ImpAbono.Enabled = False
                End If
                grp_datos.Enabled = True
                Ctl_txt_numfact.Enabled = False
                cmb_orden.Enabled = True
                Ctl_txt_apellido.Enabled = False
                ctl_txt_nombre.Enabled = False
                ctl_txt_doc.Enabled = False
                ctl_txt_dir.Enabled = False
                Ctl_txt_fono.Enabled = False
                cmb_tipodoc.Enabled = False
                lbl_msg.Text = "  Ingresar Abono"
                Ctl_txt_monto.Focus()
            Case "5"
                If fecha_ord = Nothing Then
                    fecha_ord = Convert.ToDateTime(Now)
                End If
                opr_factura.ConsultaOrdenFactura(Convert.ToDateTime(fecha_ord), cmb_orden, g_lng_ped_id)
                cmb_orden.Enabled = True
                lbl_textform.Text = "  Anulacion de Facturas"
                lbl_msg.Text = "  Anular Facturas"
                dgrd_factura.Enabled = False
                btn_anular.Enabled = True
                btn_aceptar.Enabled = False
                Ctl_txt_dsct.Enabled = False
                Ctl_txt_rec.Enabled = False
                Ctl_txt_iva.Enabled = False
                'grp_datos.Enabled = False
                grp_abono.Enabled = False
        End Select

    End Sub

    Function inserta_abono() As Short
        'inserta o actualiza abono
        'If Ctl_txt_refer.texto_Recupera = "" Then Ctl_txt_refer.texto_Asigna("")
        inserta_abono = opr_factura.OperaAbono(Ctl_txt_numfact.texto_Recupera, dtp_fecha_abo.Value, Ctl_txt_monto.texto_Recupera, "", int_AbonoEstado)
    End Function

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim int_flagopero As Byte
        Dim int_abono As Integer

        If Ctl_txt_dsct.texto_Recupera <> "100.00" Then

            If InStr(Ctl_txt_numfact.texto_Recupera(), ".") > 0 Then
                opr_pedido.VisualizaMensaje("Ingrese solo numeros en el campo factura", 300)
                Exit Sub
            End If


            If Ctl_txt_monto.texto_Recupera().ToString = "" Then
                opr_negocio.VisualizaMensaje("Ingrese un abono mayor a $ 0.00", g_tiempo)
                Exit Sub
            End If

            If CDbl(Ctl_txt_monto.texto_Recupera()) <= 0 Then
                opr_negocio.VisualizaMensaje("Ingrese un abono mayor a $ 0.00", g_tiempo)
                Exit Sub
            End If

            If Ctl_txt_numfact.texto_Recupera.ToString = "" Then
                opr_negocio.VisualizaMensaje("Ingrese el numero de factura", g_tiempo)
                Exit Sub
            End If

            'En este procedimiento validamos y enviamos a todas las funciones que deberia realizar
            'el formulario como insertar o actualizar

            If cmb_fimp.Text <> "Texto" Then txt_textofact.Text = ""

            If Ctl_txt_numfact.texto_Recupera = "" Then
                opr_negocio.VisualizaMensaje("Ingrese el numero de factura", g_tiempo)
                'MsgBox("Ingrese el numero de factura", MsgBoxStyle.Exclamation, "ANALISYS")
                Exit Sub
            End If


            Select Case Me.Tag

                Case "1", "3"
                    If Me.Tag = "1" Then
                        ReDim str_arr_pedidos(1)
                        str_arr_pedidos(0) = g_lng_ped_id
                    End If
                    btn_aceptar.Enabled = False
                    Dim ref_fac As String
                    int_flagopero = opr_factura.OperaFactura(pac_id, True, str_arr_pedidos, ctl_txt_doc.texto_Recupera, cmb_tipodoc.SelectedIndex + 1, dtp_fecha_fact.Value, _
                        CDbl(lbl_subtot_fact.Text), CDbl(Ctl_txt_dsct.texto_Recupera), CSng(Ctl_txt_iva.texto_Recupera), ctl_txt_nombre.texto_Recupera.ToString, _
                        Ctl_txt_apellido.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, ctl_txt_dir.texto_Recupera.ToString, dtt_tabla, Ctl_txt_Email.texto_Recupera(), "", _
                        Ctl_txt_numfact.texto_Recupera, ref_fac, chk_abono.Checked, Ctl_txt_rec.texto_Recupera, Trim(lbl_convenio.Text), cmb_fpago.SelectedIndex + 1, "Registrada")
                    If int_flagopero = 1 Then  'registro correctamente la factura
                        If chk_abono.Checked Then   'existe abono
                            If ValidaAbono(int_abono) Then
                                If inserta_abono() Then     '1--> si se ejecuto bien la operacion
                                    btn_ImpAbono.Enabled = True
                                    btn_ImpFactura.Enabled = True
                                    btn_recibo.Enabled = True
                                    btn_enviaFac.Enabled = True
                                    If int_abono = 2 Then
                                        opr_factura.CambiaTransaccionFactura(Ctl_txt_numfact.texto_Recupera, "Cancelada")
                                    End If

                                End If
                            End If
                        Else
                            btn_ImpFactura.Enabled = True
                            btn_recibo.Enabled = True
                            btn_ImpAbono.Enabled = True
                            btn_aceptar.Enabled = False
                            btn_enviaFac.Enabled = True
                            ''If MsgBox("Desea Imprimir la factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                            ''Imprimir(0)
                            ''End If
                        End If
                        'Me.Close()
                    End If

                Case "2"
                    btn_aceptar.Enabled = False
                    ReDim str_arr_pedidos(1)
                    str_arr_pedidos(0) = CStr(g_lng_ped_id)
                    int_flagopero = opr_factura.OperaFactura(pac_id, False, str_arr_pedidos, ctl_txt_doc.texto_Recupera, cmb_tipodoc.SelectedIndex + 1, dtp_fecha_fact.Value, _
                        CDbl(lbl_subtot_fact.Text), CDbl(Ctl_txt_dsct.texto_Recupera), CSng(Ctl_txt_iva.texto_Recupera), ctl_txt_nombre.texto_Recupera.ToString, _
                        Ctl_txt_apellido.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, ctl_txt_dir.texto_Recupera.ToString, dtt_tabla, txt_textofact.Text, _
                        Ctl_txt_numfact.texto_Recupera, chk_abono.Checked, Ctl_txt_rec.texto_Recupera, Ctl_txt_referfact.texto_Recupera, cmb_fpago.SelectedIndex + 1, "")
                    If int_flagopero = 1 Then
                        btn_ImpFactura.Enabled = True
                        btn_ImpAbono.Enabled = True
                        btn_recibo.Enabled = True
                        btn_ImpAbono.Enabled = True
                        btn_enviaFac.Enabled = True
                        
                    End If
                    'limpia()

                Case "4"
                    btn_aceptar.Enabled = False
                    If ValidaAbono(int_abono) Then
                        If inserta_abono() Then    '1--> si se ejecuto bien la operacin
                            btn_ImpAbono.Enabled = True
                            btn_ImpFactura.Enabled = True
                            btn_recibo.Enabled = True
                            btn_ImpAbono.Enabled = True
                            If int_abono = 2 Then
                                opr_factura.CambiaTransaccionFactura(Ctl_txt_numfact.texto_Recupera, "Cancelada")
                            End If
                        End If
                    End If
  
            End Select
        Else

            If InStr(Ctl_txt_numfact.texto_Recupera(), ".") > 0 Then
                opr_pedido.VisualizaMensaje("Ingrese solo numeros en el campo factura", 300)
                Exit Sub
            End If


            If Ctl_txt_monto.texto_Recupera().ToString = "" Then
                opr_negocio.VisualizaMensaje("Ingrese un abono mayor a $ 0.00", g_tiempo)
                Exit Sub
            End If



            If Ctl_txt_numfact.texto_Recupera.ToString = "" Then
                opr_negocio.VisualizaMensaje("Ingrese el numero de factura", g_tiempo)
                Exit Sub
            End If

            'En este procedimiento validamos y enviamos a todas las funciones que deberia realizar
            'el formulario como insertar o actualizar

            If cmb_fimp.Text <> "Texto" Then txt_textofact.Text = ""

            If Ctl_txt_numfact.texto_Recupera = "" Then
                opr_negocio.VisualizaMensaje("Ingrese el numero de factura", g_tiempo)
                'MsgBox("Ingrese el numero de factura", MsgBoxStyle.Exclamation, "ANALISYS")
                Exit Sub
            End If

            Select Case Me.Tag
                Case "1", "3"
                    If Me.Tag = "1" Then
                        ReDim str_arr_pedidos(1)
                        str_arr_pedidos(0) = g_lng_ped_id
                    End If
                    btn_aceptar.Enabled = False
                    int_flagopero = opr_factura.OperaFactura(pac_id, True, str_arr_pedidos, ctl_txt_doc.texto_Recupera, cmb_tipodoc.SelectedIndex + 1, dtp_fecha_fact.Value, _
                        CDbl(lbl_subtot_fact.Text), CDbl(Ctl_txt_dsct.texto_Recupera), CSng(Ctl_txt_iva.texto_Recupera), ctl_txt_nombre.texto_Recupera.ToString, _
                        Ctl_txt_apellido.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, ctl_txt_dir.texto_Recupera.ToString, dtt_tabla, txt_textofact.Text, _
                        Ctl_txt_numfact.texto_Recupera, chk_abono.Checked, Ctl_txt_rec.texto_Recupera, Ctl_txt_referfact.texto_Recupera, cmb_fpago.SelectedIndex + 1, "Registrada")
                    If int_flagopero = 1 Then  'registro correctamente la factura
                        If chk_abono.Checked Then   'existe abono
                            If ValidaAbono(int_abono) Then
                                If inserta_abono() Then     '1--> si se ejecuto bien la operacion
                                    btn_ImpAbono.Enabled = True
                                    btn_ImpFactura.Enabled = True
                                    btn_recibo.Enabled = True
                                    btn_enviaFac.Enabled = True
                                    ''If MsgBox("Desea Imprimir el abono?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                                    ''Imprimir(1)
                                    ''End If
                                End If
                            End If
                        Else
                            btn_ImpFactura.Enabled = True
                            btn_recibo.Enabled = True
                            btn_ImpAbono.Enabled = True
                            btn_aceptar.Enabled = False
                            btn_enviaFac.Enabled = True
                            ''If MsgBox("Desea Imprimir la factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                            ''Imprimir(0)
                            ''End If
                        End If
                        'Me.Close()
                    End If

                Case "2"
                    btn_aceptar.Enabled = False
                    ReDim str_arr_pedidos(1)
                    str_arr_pedidos(0) = CStr(g_lng_ped_id)
                    int_flagopero = opr_factura.OperaFactura(pac_id, False, str_arr_pedidos, ctl_txt_doc.texto_Recupera, cmb_tipodoc.SelectedIndex + 1, dtp_fecha_fact.Value, _
                        CDbl(lbl_subtot_fact.Text), CDbl(Ctl_txt_dsct.texto_Recupera), CSng(Ctl_txt_iva.texto_Recupera), ctl_txt_nombre.texto_Recupera.ToString, _
                        Ctl_txt_apellido.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, ctl_txt_dir.texto_Recupera.ToString, dtt_tabla, txt_textofact.Text, _
                        Ctl_txt_numfact.texto_Recupera, chk_abono.Checked, Ctl_txt_rec.texto_Recupera, Ctl_txt_referfact.texto_Recupera, cmb_fpago.SelectedIndex + 1, "")
                    If int_flagopero = 1 Then
                        btn_ImpFactura.Enabled = True
                        btn_ImpAbono.Enabled = True
                        btn_recibo.Enabled = True
                        btn_ImpAbono.Enabled = True
                        btn_enviaFac.Enabled = True
                        ''If MsgBox("󿿿Desea Imprimir la factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                        ''    Imprimir(0)
                        ''End If
                    End If
                    'limpia()

                Case "4"
                    btn_aceptar.Enabled = False
                    If ValidaAbono(int_abono) Then
                        If inserta_abono() Then    '1--> si se ejecuto bien la operacin
                            btn_ImpAbono.Enabled = True
                            btn_ImpFactura.Enabled = True
                            btn_recibo.Enabled = True
                            btn_ImpAbono.Enabled = True
                            ''If MsgBox("Desea Imprimir el abono?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                            ''    Imprimir(1)
                            ''End If
                        End If
                        'limpia()
                    End If
            End Select

            'opr_negocio.VisualizaMensaje("Ingrese un abono mayor a $ 0.00", g_tiempo)

        End If
        g_numOrden = Nothing
        'g_lng_ped_id = Nothing
    End Sub

    Private Sub NumFactura_PierdeEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fac_estado As Single
        Dim boo_existe As Boolean
        If Ctl_txt_numfact.texto_Recupera = "" Then Exit Sub
        boo_existe = opr_factura.ExisteFactura(Ctl_txt_numfact.texto_Recupera, fac_estado)
        'fac_estado --> 0 emitido, 1 abonada, 2 cancelada, 3 anulada

        If Me.Tag <> "5" Then btn_aceptar.Enabled = True
        Select Case fac_estado
            Case 0
                'No existe la factura o solo se encuentra emitida
            Case 1
                dgrd_factura.Enabled = False
                Ctl_txt_dsct.Enabled = False
                Ctl_txt_rec.Enabled = False
                Ctl_txt_iva.Enabled = False
                grp_datos.Enabled = False
                If Me.Tag = "2" Then
                    btn_aceptar.Enabled = False
                    MsgBox("La factura se encuentra abonada, no puede realizar cambios", MsgBoxStyle.Information, "ANALISYS")
                End If
            Case 2
                MsgBox("La factura se encuentra Cancelada, No se puede realizar cambios", MsgBoxStyle.Information, "ANALISYS")
                btn_aceptar.Enabled = False
                Exit Sub
            Case 3
                MsgBox("La factura se encuentra Anulada, No se puede realizar cambios", MsgBoxStyle.Exclamation, "ANALISYS")
                btn_aceptar.Enabled = False
                Exit Sub
        End Select

        Select Case Me.Tag
            Case "1", "3"
                If boo_existe Then
                    MsgBox("La Factura ya existe, seleccione otro numero de factura", MsgBoxStyle.Information, "ANALISYS")
                    Ctl_txt_numfact.Focus()
                End If

            Case "2", "4", "5"
                If boo_existe Then
                    Llena_detalle_factura(Ctl_txt_numfact.texto_Recupera)
                    If Me.Tag = "4" Then
                        chk_abono.Checked = True
                        habilita_ChechedAbono()
                        chk_abono.Enabled = False
                    End If
                Else
                    MsgBox("La Factura NO existe, verifique datos", MsgBoxStyle.Information, "ANALISYS")
                    Ctl_txt_numfact.Focus()
                End If
        End Select

    End Sub

    Private Sub Anular(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anular.Click
        If Ctl_txt_numfact.texto_Recupera <> "" Then
            opr_factura.AnularFactura(Ctl_txt_numfact.texto_Recupera)
            If fecha_ord = Nothing Then
                fecha_ord = Convert.ToDateTime(Now)
            End If
            'opr_factura.ConsultaOrdenFactura(Convert.ToDateTime(fecha_ord), cmb_orden, g_lng_ped_id)
        Else
            MsgBox("No existe factura para anular", MsgBoxStyle.Information, "ANALISYS")
        End If
        limpia()
    End Sub

    Private Sub Imprimir(ByVal sht_opera As Short)
        If Trim(Ctl_txt_numfact.texto_Recupera) = "" Then
            MsgBox("Ingrese el numero de factura", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            Dim frm_imp As New frm_Rpt_Factura()
            frm_imp.lng_factura = Ctl_txt_numfact.texto_Recupera
            frm_imp.sht_opera = sht_opera  '1--> abono,   0--> otros
            frm_imp.frm_refer_main = Me.ParentForm
            frm_imp.ShowDialog(Me.ParentForm)
        End If

    End Sub

    Private Sub cmb_fpago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_fpago.SelectedIndexChanged
        'If cmb_fpago.Text = "Convenio Inter Institucional" Then
        '    MsgBox("Esta forma de pago cancelar� virtualmente, pero el cobr� se realizar� a fin de mes")
        'End If
    End Sub


    Private Sub cmb_orden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_orden.SelectedIndexChanged
        g_lng_ped_id = Trim(Mid(cmb_orden.Text, 21, 40))

        Dim opr_fac As New Cls_Factura()

        If CStr(CDbl(opr_fac.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_fac.LeerSumAbonos(g_lng_ped_nunfact)), 2)) > 0 Then
            Llena_detalle_factura(g_lng_ped_nunfact)
        Else
            Llena_detalle_pedido(g_lng_ped_id)

        End If

        'Llena_detalle_pedido(g_lng_ped_id)
        'Llena_detalle_pedido(g_lng_ped_id, g_lng_ped_nunfact)

        Ctl_txt_apellido.Focus()
        'opr_factura.Obtiene_dato_abono_factura(str_sql, g_lng_ped_id, dts_registro)
        'If dts_registro.Tables(0).Rows.Count = 0 Then
        '    MsgBox("No existe datos de la factura solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
        'Else
        '    str_crea = "Factura"
        '    obj_reporte = New rpt_factura()
        'End If
    End Sub

    Private Sub Ctl_txt_dsct_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_dsct.Leave
        Calcula_total()
        If Ctl_txt_dsct.texto_Recupera() = "" Or Ctl_txt_dsct.texto_Recupera() = "0" Or Ctl_txt_dsct.texto_Recupera() = "0.00" Then
            Ctl_txt_rec.Enabled = True
        Else
            'Ctl_txt_refer.texto_Asigna("Descuento del " & Ctl_txt_dsct.texto_Recupera() & " %")
            Ctl_txt_rec.Enabled = False
        End If


    End Sub

    Private Sub Ctl_txt_rec_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_rec.Leave
        Calcula_total()
        If Ctl_txt_rec.texto_Recupera() = "" Or Ctl_txt_rec.texto_Recupera() = "0" Or Ctl_txt_rec.texto_Recupera() = "0.00" Then
            'Ctl_txt_refer.texto_Asigna("")
            Ctl_txt_rec.Enabled = True
        Else
            'Ctl_txt_refer.texto_Asigna("Recargo del " & Ctl_txt_rec.texto_Recupera() & " %")
            Ctl_txt_rec.Enabled = False
        End If
    End Sub





    Private Sub btn_ImpAbono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpAbono.Click

        Dim opr_factura As New Cls_Factura
        Dim saldo As String = ""
        Dim numfact As String = Ctl_txt_numfact.texto_Recupera
        Dim STR_SQL, str_crea As String
        Dim obj_reporte As Object
        Dim dts_registro As DataSet = Nothing
        str_crea = ""


        opr_factura.OperaFacturaTransaccion(CLng(Ctl_txt_numfact.texto_Recupera()), "NOTAVENTA", Format(Now(), "yyyy-MM-dd"))

        If numfact <> "0" Then
            If cmb_fimp.Text = "Detalle" Then
                STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
            "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Detalle' as IMP, PEDIDO.PED_NUMAUX, " & _
        "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
        "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno " & _
        "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
        "WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
            End If

            If cmb_fimp.Text = "Total" Then
                STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
            "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Total' as IMP, PEDIDO.PED_NUMAUX, " & _
       "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
        "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno " & _
        "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
        "WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
            End If

            'STR_SQL = "Select ped_fecing, pac_tipodoc, pac_doc, pac_apellido, pac_nombre, pac_direccion, case when pac_fono is null then'ND' else pac_fono end as pac_fono, convenio.con_nombre as con_nombre, con_valor from paciente, pedido, convenio where convenio.con_nombre=pedido.con_nombre and pedido.pac_id=paciente.pac_id and ped_id = " & ped_id


            dts_registro = New DataSet()
            opr_factura.Obtiene_dato_abono_factura(STR_SQL, numfact, dts_registro)
            saldo = CStr(CDbl(opr_factura.LeerTotalFac(numfact)) - Round(CDbl(opr_factura.LeerSumAbonos(numfact)), 2))

            If dts_registro.Tables(0).Rows.Count = 0 Then
                MsgBox("No existe datos de la factura solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                'If CLng(saldo) > 0 Then
                '    ' INGRESAR(ABONO)
                '    If Not ExisteForm("Frm_Factura") Then
                '        Dim FrM_MDIChild As New Frm_Factura()

                '        FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                '        FrM_MDIChild.Tag = "4"
                '        FrM_MDIChild.ShowDialog(Me.ParentForm)

                '        ''Me.lst_pedidos.Items.Clear()
                '        ''dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)

                '    End If
                'Else
                str_crea = "Factura"
                obj_reporte = New rpt_facturaAbono()
                'End If
            End If
        STR_SQL = ""

        Else
        'AQUI PARA NUEVA FACTURA 
        If Not ExisteForm("Frm_Factura") Then
            Dim FrM_MDIChild As New Frm_Factura()
            'FrM_MDIChild.Show()
            FrM_MDIChild.frm_refer_main_form = Me.ParentForm
            FrM_MDIChild.Tag = "1"
            FrM_MDIChild.ShowDialog(Me.ParentForm)

            ''Me.lst_pedidos.Items.Clear()
            ''dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)

        End If

        End If


        If str_crea <> "" Then
            Dim frm_MDIChild As New Frm_reportes(STR_SQL, "", obj_reporte, dts_registro)
            frm_MDIChild.int_alto = Me.Height
            frm_MDIChild.int_ancho = Me.Width
            frm_MDIChild.Text = str_crea
            frm_MDIChild.Show()
            'frm_refer_main.Crea_formulario(Me)
            'Me.Close()
        End If
        g_lng_ped_id = Nothing

    End Sub


    Sub Obtiene_dato_abono_factura(ByVal str_sql As String, ByRef dts_registro As DataSet)
        'funci�n que une dos dataset para el caso de una o varias facturas, donde se obtiene
        'el total de abonado
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dbl_sumabono As Double = 0
        Dim int_indice, int_indice2 As Integer

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_registro, "Registros")
        dts_registro.Tables(0).Columns.Add("SUM_ABO")


        If dts_registro.Tables(0).Rows.Count > 0 Then
            For int_indice = 0 To dts_registro.Tables(0).Rows.Count - 1
                str_sql = "select FAC_ID, sum(ABO_MONTO) FROM ABONO where FAC_ID = '" & dts_registro.Tables(0).Rows(int_indice).Item(0) & "' group by FAC_ID"
                oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
                oda_operacion.Fill(dts_registro, "Registros2")
                dbl_sumabono = 0
                If dts_registro.Tables("Registros2").Rows.Count > 0 Then
                    dtr_fila = dts_registro.Tables("Registros2").Rows(int_indice)
                    'se llena toda la columna con el dato de la suma de abonos
                    If Not IsDBNull(dtr_fila(1)) Then dbl_sumabono = dtr_fila(1)
                End If
                For int_indice2 = 0 To dts_registro.Tables(0).Rows.Count - 1
                    If dts_registro.Tables(0).Rows(int_indice).Item(0) = dts_registro.Tables(0).Rows(int_indice2).Item(0) Then
                        dts_registro.Tables(0).Rows(int_indice).Item("SUM_ABO") = dbl_sumabono
                    End If
                Next
            Next

        End If
        opr_Conexion.sql_desconn()

    End Sub

    Private Sub btn_ImpFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpFactura.Click
        'boton GENERAR FACTURA

        Dim opr_factura As New Cls_Factura
        Dim saldo As String = ""
        Dim numfact As String = Ctl_txt_numfact.texto_Recupera
        Dim STR_SQL, STR_SQL2, str_crea As String
        Dim obj_reporte As Object
        Dim dts_registro As DataSet = Nothing
        Dim str_letras As String = Nothing
        Dim monto As Double

        str_crea = ""

        opr_factura.OperaFacturaTransaccion(CLng(Ctl_txt_numfact.texto_Recupera()), "FACTURA", Format(Now(), "yyyy-MM-dd"))

        If numfact <> "0" Then

            If cmb_fimp.Text = "Detalle" Then
                STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
            "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Detalle' as IMP, FAC_LETRAS  "
                STR_SQL2 = "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
        "WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
            End If

            If cmb_fimp.Text = "Total" Then
                STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
            "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Total' as IMP, FAC_LETRAS  "
                STR_SQL2 = "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
        "WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
            End If


            'STR_SQL = "Select ped_fecing, pac_tipodoc, pac_doc, pac_apellido, pac_nombre, pac_direccion, case when pac_fono is null then'ND' else pac_fono end as pac_fono, convenio.con_nombre as con_nombre, con_valor from paciente, pedido, convenio where convenio.con_nombre=pedido.con_nombre and pedido.pac_id=paciente.pac_id and ped_id = " & ped_id


            dts_registro = New DataSet()
            opr_factura.Obtiene_dato_abono_factura(STR_SQL & STR_SQL2, numfact, dts_registro)
            saldo = CStr(CDbl(opr_factura.LeerTotalFac(numfact)) - Round(CDbl(opr_factura.LeerSumAbonos(numfact)), 2))
            If saldo = 0 Then
                monto = Round(CDbl(opr_factura.LeerSumAbonos(g_lng_ped_nunfact)), 2)
            End If

            If dts_registro.Tables(0).Rows.Count = 0 Then
                MsgBox("No existe datos de la factura solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                'If CLng(saldo) > 0 Then
                '    ' INGRESAR(ABONO)
                '    If Not ExisteForm("Frm_Factura") Then
                '        Dim FrM_MDIChild As New Frm_Factura()

                '        FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                '        FrM_MDIChild.Tag = "4"
                '        FrM_MDIChild.ShowDialog(Me.ParentForm)

                '        ''Me.lst_pedidos.Items.Clear()
                '        ''dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)

                '    End If
                'Else
                str_crea = "Factura"
                obj_reporte = New rpt_factura()
                'str_letras = " AND '" & opr_factura.Letras(monto) & "' as LETRAS "
                'End If
            End If
        STR_SQL = ""

        Else
        'AQUI PARA NUEVA FACTURA 
        If Not ExisteForm("Frm_Factura") Then
            Dim FrM_MDIChild As New Frm_Factura()
            'FrM_MDIChild.Show()
            FrM_MDIChild.frm_refer_main_form = Me.ParentForm
            FrM_MDIChild.Tag = "1"
            FrM_MDIChild.ShowDialog(Me.ParentForm)

            ''Me.lst_pedidos.Items.Clear()
            ''dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)

        End If

        End If


        If str_crea <> "" Then
            Dim frm_MDIChild As New Frm_reportes(STR_SQL & STR_SQL2, "", obj_reporte, dts_registro)
            frm_MDIChild.int_alto = Me.Height
            frm_MDIChild.int_ancho = Me.Width
            frm_MDIChild.Text = str_crea
            frm_MDIChild.Show()
            'frm_refer_main.Crea_formulario(Me)
            'Me.Close()
        End If
        g_lng_ped_id = Nothing
    End Sub

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

    Private Sub btn_recibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_recibo.Click
        ' ''boton GENERAR FACTURA
        Dim datos As String()
        Dim credenciales As String()
        Dim opr_factura As New Cls_Factura
        Dim opr_pac As New Cls_Paciente
        Dim opr_encripta As New Cls_Encripta
        Dim saldo As String = ""
        Dim numfact As String = Ctl_txt_numfact.texto_Recupera
        Dim STR_SQL, str_crea As String
        Dim obj_reporte As Object
        Dim dts_registro As DataSet = Nothing
        Dim nombre As String()
        Dim texto As String = Nothing
        Dim g_usu_login As String = Nothing
        Dim g_usu_pass As String = Nothing
        str_crea = ""

        '''''
        If opr_pac.verifica_usrWeb(pac_id) = "" Then

            datos = Split(opr_pac.Devuelvepaciente(pac_id), "º")
            nombre = Split(datos(1), " ")

            If UBound(nombre) = 3 Then
                texto = opr_encripta.Genera_usr(nombre(0), nombre(2), g_usu_login, g_usu_pass)
            Else
                texto = opr_encripta.Genera_usr(nombre(0), nombre(1), g_usu_login, g_usu_pass)

            End If
            'g_usu_login = mid(nombre(1)
            g_usu_pass = datos(0)

            opr_pac.Ingresa_UsrWeb(pac_id, Trim(g_usu_login), Trim(g_usu_pass))

            ''''ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
            'opr_mail.EnviaCorreo(Trim(var_correo), "CREDENCIALES ACCESO", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "")
        Else
            credenciales = Split(opr_pac.Busca_usrWeb(pac_id), ",")

            'wtexto = wtexto & "*USUARIO:*%20" & credenciales(0) & "%0A" & "*CONTRASEÑA:*%20" & credenciales(1) & "%0A" & "*LINK:*%20" & System.Configuration.ConfigurationSettings.AppSettings("SITIO") & "%0A%0A" & g_Titulo
            credenciales = Split(opr_pac.Busca_usrWeb(pac_id), ",")
            g_usu_login = credenciales(0)
            g_usu_pass = credenciales(1)
        End If

        ''''
        opr_factura.OperaFacturaTransaccion(CLng(Ctl_txt_numfact.texto_Recupera()), "NOTAVENTA", Format(Now(), "yyyy-MM-dd"))

        Dim sitioweb As String = System.Configuration.ConfigurationSettings.AppSettings("Sitio")

        If numfact <> "0" Then
            If cmb_fimp.Text = "Detalle" Then
                STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
            "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Detalle' as IMP, PEDIDO.PED_NUMAUX, " & _
        "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, '" & g_usu_login & "'  as usu_login, '" & g_usu_pass & "' usu_pass, '" & sitioweb & "' as sitioweb " & _
        "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO, usuario_web " & _
        "WHERE usuario_web .pac_id = pedido.PAC_ID AND FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
            End If

            If cmb_fimp.Text = "Total" Then
                STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
            "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        "TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Total' as IMP, PEDIDO.PED_NUMAUX, " & _
       "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, '" & g_usu_login & "'  as usu_login, '" & g_usu_pass & "' usu_pass, '" & sitioweb & "' as sitioweb " & _
        "FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO, usuario_web " & _
        "WHERE usuario_web .pac_id = pedido.PAC_ID AND FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        "ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
            End If

            'STR_SQL = "Select ped_fecing, pac_tipodoc, pac_doc, pac_apellido, pac_nombre, pac_direccion, case when pac_fono is null then'ND' else pac_fono end as pac_fono, convenio.con_nombre as con_nombre, con_valor from paciente, pedido, convenio where convenio.con_nombre=pedido.con_nombre and pedido.pac_id=paciente.pac_id and ped_id = " & ped_id


            dts_registro = New DataSet()
            opr_factura.Obtiene_dato_abono_factura(STR_SQL, numfact, dts_registro)
            saldo = CStr(CDbl(opr_factura.LeerTotalFac(numfact)) - Round(CDbl(opr_factura.LeerSumAbonos(numfact)), 2))

            If dts_registro.Tables(0).Rows.Count = 0 Then
                MsgBox("No existe datos de la factura solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
            
                str_crea = "Factura"
                obj_reporte = New rpt_facturaRecibo()
                'End If
            End If
            STR_SQL = ""

        Else
            'AQUI PARA NUEVA FACTURA 
            If Not ExisteForm("Frm_Factura") Then
                Dim FrM_MDIChild As New Frm_Factura()
                'FrM_MDIChild.Show()
                FrM_MDIChild.frm_refer_main_form = Me.ParentForm
                FrM_MDIChild.Tag = "1"
                FrM_MDIChild.ShowDialog(Me.ParentForm)

                ''Me.lst_pedidos.Items.Clear()
                ''dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)

            End If

        End If


        If str_crea <> "" Then
            Dim frm_MDIChild As New Frm_reportes(STR_SQL, "", obj_reporte, dts_registro)
            frm_MDIChild.int_alto = Me.Height
            frm_MDIChild.int_ancho = Me.Width
            frm_MDIChild.Text = str_crea
            frm_MDIChild.Show()
            'frm_refer_main.Crea_formulario(Me)
            'Me.Close()
        End If
        g_lng_ped_id = Nothing

        ''Dim opr_factura As New Cls_Factura
        ''Dim saldo As String = ""
        ''Dim numfact As String = Ctl_txt_numfact.texto_Recupera
        ''Dim STR_SQL, str_crea As String
        ''Dim obj_reporte As Object
        ''Dim dts_registro As DataSet = Nothing
        ''str_crea = ""

        ''opr_factura.EliminaAbonoTemporal()
        ''opr_factura.OperaFacturaTransaccion(CLng(Ctl_txt_numfact.texto_Recupera()), "NOTAVENTA", Format(Now(), "yyyy-MM-dd"))

        ''If numfact <> "0" Then
        ''    ' ''    If cmb_fimp.Text = "Detalle" Then
        ''    ' ''        STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
        ''    ' ''    "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        ''    ' ''"TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Detalle' as IMP, PEDIDO.PED_NUMAUX " & _
        ''    ' ''"FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
        ''    ' ''"WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        ''    ' ''"ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
        ''    ' ''    End If

        ''    ' ''    If cmb_fimp.Text = "Total" Then
        ''    ' ''        STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
        ''    ' ''    "CASE when PEDIDO.CON_NOMBRE = '" & Trim(lbl_convenio.Text) & "' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
        ''    ' ''"TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA, 'Total' as IMP, PEDIDO.PED_NUMAUX " & _
        ''    ' ''"FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
        ''    ' ''"WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & numfact & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
        ''    ' ''"ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"
        ''    ' ''    End If

        ''    'STR_SQL = "Select ped_fecing, pac_tipodoc, pac_doc, pac_apellido, pac_nombre, pac_direccion, case when pac_fono is null then'ND' else pac_fono end as pac_fono, convenio.con_nombre as con_nombre, con_valor from paciente, pedido, convenio where convenio.con_nombre=pedido.con_nombre and pedido.pac_id=paciente.pac_id and ped_id = " & ped_id


        ''    'dts_registro = New DataSet()
        ''    ' opr_factura.Obtiene_dato_abono_factura(STR_SQL, numfact, dts_registro)
        ''    'saldo = CStr(CDbl(opr_factura.LeerTotalFac(g_lng_ped_nunfact)) - Round(CDbl(opr_factura.LeerSumAbonos(g_lng_ped_nunfact)), 2))


        ''    Dim fac_Datos As String
        ''    Dim Datosfac_arre As String()
        ''    Dim i As Integer = 0
        ''    Dim DatosFac As String()
        ''    Dim total_Abonos As Double
        ''    Dim opr_fac As New Cls_Factura()

        ''    Datosfac_arre = Split(Recupera_DatosFacFacId(numfact), "º")
        ''    For i = 0 To UBound(Datosfac_arre) - 1
        ''        DatosFac = Split(Datosfac_arre(i), ",")
        ''        total_Abonos = TotalAbonos(CDbl(DatosFac(0)))
        ''        ' Abonos_Fecha = AbonosFecha(CDbl(DatosFac(0)), dtp_fec1.Value, dtp_fec2.Value)
        ''        'If total_Abonos = Abonos_Fecha Then
        ''        '    saldo = DatosFac(3) - total_Abonos
        ''        'Else
        ''        '    saldo = DatosFac(3) - total_Abonos
        ''        '    'saldo = total_Abonos - Abonos_Fecha
        ''        'End If
        ''        STR_SQL = "Insert into abono_temp values('" & DatosFac(0) & "', " & total_Abonos & ", 0)"
        ''        opr_fac.GuardaAbonoTemporal(STR_SQL)
        ''    Next


        ''    ' cosulto total de abonos

        ''    'If lbl_desde.Checked Then
        ''    'If txt_desde.Text = "" Or txt_hasta.Text = "" Then
        ''    '    MsgBox("Debe ingresar el rango de turnos a consultar.", MsgBoxStyle.Exclamation, "ANALISYS")
        ''    'Else
        ''    '/*FACTURADO Y CANCELADO o ABONADO */
        ''    '                                                                                                                                                                                                            DateAdd(DateInterval.Day, -28, Now)
        ''    STR_SQL = "SELECT a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
        ''    "a.FAC_ESTATUS, a.FAC_FORMAPAGO, (SUBSTRING(convert(char(10),b.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),b.PED_FECING,103),1,2) )+ " & _
        ''            "case when len(b.PED_TURNO) = 1 then('000' + convert(varchar(100),b.PED_TURNO)) " & _
        ''            "when len(b.PED_TURNO) = 2 then('00' + convert(varchar(100),b.PED_TURNO)) " & _
        ''            "when len(b.PED_TURNO) = 3 then('0' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 4 then(convert(varchar(100),b.PED_TURNO)) end) as ped_turno, round(abt.abo_total,2) as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, a.fac_doc as fac_ruc, a.FAC_FONO, a.FAC_DIRECCION " & _
        ''    "FROM FACTURA as a, pedido as b, abono as c, invitado as i, abono_temp as abt " & _
        ''    "WHERE abt.Fac_id = a.fac_id and (a.FAC_ESTATUS = 0 or a.FAC_ESTATUS = 1 or a.FAC_ESTATUS = 2) and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id " & _
        ''    "And ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO " & _
        ''    "and a.fac_id = " & numfact & _
        ''    " group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, b.PED_FECING, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, abt.abo_total, b.ped_turno, i.invitado_apellido, i.invitado_nombre, a.fac_doc, a.FAC_FONO, a.FAC_DIRECCION "
        ''    '/*NO FACTURADO*/
        ''    STR_SQL = STR_SQL + "UNION select 'S/F' as fac_id, p.ped_fecing as fac_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
        ''    "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
        ''    "(SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ " & _
        ''            "case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) " & _
        ''            "when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) " & _
        ''            "when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end) as TURNO, '0' AS abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, '' as fac_ruc, '' as FAC_FONO, '' as FAC_DIRECCION " & _
        ''    "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, invitado as i " & _
        ''    "where p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id And ped_prof <> 1 " & _
        ''    "and p.fac_id = " & numfact & _
        ''    " and p.ped_fac_estado = 0 and p.ped_estado <> 2 and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO group by pdd.ped_id, p.ped_fecing, pac.PAC_APELLIDO, pac.PAC_NOMBRE, p.ped_turno, i.invitado_apellido, i.invitado_nombre "
        ''    'FACTURADO Y NO CANCELADO
        ''    STR_SQL = STR_SQL + "UNION select f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
        ''    "f.FAC_ESTATUS, f.FAC_FORMAPAGO, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ " & _
        ''            "case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) " & _
        ''            "when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) " & _
        ''            "when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end) as TURNO, 0 as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, f.fac_doc as fac_ruc, f.FAC_FONO, f.FAC_DIRECCION " & _
        ''    "FROM pedido as p, factura as f, invitado as i, abono_temp as abt where  ped_fac_estado = 1  " & _
        ''    "and ped_prof <> 1 and fac_estatus = 0 and p.fac_id = f.fac_id " & _
        ''    "and f.fac_id = " & numfact & _
        ''    " and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO  group by f.fac_id , p.ped_fecing , f.fac_total, f.fac_iva,f.fac_descuento, fac_recargo, f.FAC_APELLIDO, f.FAC_NOMBRE, f.FAC_ESTATUS, f.FAC_FORMAPAGO, abt.abo_total, p.ped_turno, i.invitado_apellido, i.invitado_nombre, f.fac_doc, f.FAC_FONO, f.FAC_DIRECCION ; "
        ''    str_crea = "recibo"
        ''    obj_reporte = New rpt_facturaRecibo()

        ''End If


        ''If str_crea <> "" Then
        ''    Dim frm_MDIChild As New Frm_reportes(STR_SQL, obj_reporte, dts_registro)
        ''    frm_MDIChild.int_alto = Me.Height
        ''    frm_MDIChild.int_ancho = Me.Width
        ''    frm_MDIChild.Text = str_crea
        ''    frm_MDIChild.Show()
        ''    'frm_refer_main.Crea_formulario(Me)
        ''    'Me.Close()
        ''End If
        ''g_lng_ped_id = Nothing
    End Sub


    Private Sub Ctl_txt_dsct_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ctl_txt_dsct.KeyPress
        If e.KeyChar = (Convert.ToChar(Keys.Enter)) Then
            Calcula_total()
            If Ctl_txt_dsct.texto_Recupera() = "" Or Ctl_txt_dsct.texto_Recupera() = "0" Or Ctl_txt_dsct.texto_Recupera() = "0.00" Then
                Ctl_txt_rec.Enabled = True
            Else
                'Ctl_txt_refer.texto_Asigna("Descuento del " & Ctl_txt_dsct.texto_Recupera() & " %")
                Ctl_txt_rec.Enabled = False
            End If
        End If
    End Sub

    Private Sub lbl_tot_fact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = (Convert.ToChar(Keys.Enter)) Then
            Calcula_porcentaje()
        End If
    End Sub



    Private Sub lbl_tot_fact_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_tot_fact.Leave
        Calcula_porcentaje()
    End Sub

    
    Private Sub btn_pendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pendiente.Click
        Dim num_fac = opr_factura.LeerMaxFactura()
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_flagopero As Byte

            Select Me.Tag
            Case "1", "3"
                If Me.Tag = "1" Then
                    ReDim str_arr_pedidos(1)
                    str_arr_pedidos(0) = g_lng_ped_id
                End If
                btn_aceptar.Enabled = False
                Dim ref_fac As String
                int_flagopero = opr_factura.OperaFactura(pac_id, True, str_arr_pedidos, ctl_txt_doc.texto_Recupera, cmb_tipodoc.SelectedIndex + 1, dtp_fecha_fact.Value, _
                    CDbl(lbl_subtot_fact.Text), CDbl(Ctl_txt_dsct.texto_Recupera), CSng(Ctl_txt_iva.texto_Recupera), ctl_txt_nombre.texto_Recupera.ToString, _
                    Ctl_txt_apellido.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, ctl_txt_dir.texto_Recupera.ToString, dtt_tabla, Ctl_txt_Email.texto_Recupera(), "", _
                    Ctl_txt_numfact.texto_Recupera, ref_fac, chk_abono.Checked, Ctl_txt_rec.texto_Recupera, Trim(lbl_convenio.Text), cmb_fpago.SelectedIndex + 1, "Pendiente")
                'If int_flagopero = 1 Then  'registro correctamente la factura
                '    'If chk_abono.Checked Then   'existe abono
                '    If ValidaAbono() Then
                '        If inserta_abono() Then     '1--> si se ejecuto bien la operacion
                '            btn_ImpAbono.Enabled = True
                '            btn_ImpFactura.Enabled = True
                '            btn_recibo.Enabled = True
                '            btn_enviaFac.Enabled = True
                '            ''If MsgBox("Desea Imprimir el abono?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                '            ''Imprimir(1)
                '            ''End If
                '        End If
                '    End If
                '    'Else
                '    '    btn_ImpFactura.Enabled = True
                '    '    btn_recibo.Enabled = True
                '    '    btn_ImpAbono.Enabled = True
                '    '    btn_aceptar.Enabled = False
                '    '    btn_enviaFac.Enabled = True
                '    '    ''If MsgBox("Desea Imprimir la factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                '    '    ''Imprimir(0)
                '    '    ''End If
                '    'End If
                '    'Me.Close()
                'End If

        End Select



        ''opr_conexion.sql_conectar()

        ''Dim str_sql As String = "Update PEDIDO set FAC_ID = '" & num_fac & "', PED_FAC_ESTADO = 1 where PED_ID = " & g_lng_ped_id & ""
        ''odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)

        ''odbc_strsql.ExecuteNonQuery()

        ''opr_conexion.sql_desconn()

        ''ReDim str_arr_pedidos(1)
        ''str_arr_pedidos(0) = g_lng_ped_id

        ''If opr_factura.OperaFactura(True, str_arr_pedidos, ctl_txt_doc.texto_Recupera, cmb_tipodoc.SelectedIndex + 1, Format(dtp_fecha_fact.Value, "yyyy/MM/dd"), _
        ''            CDbl(lbl_subtot_fact.Text), CDbl(Ctl_txt_dsct.texto_Recupera), CSng(Ctl_txt_iva.texto_Recupera), ctl_txt_nombre.texto_Recupera.ToString, _
        ''            Ctl_txt_apellido.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, ctl_txt_dir.texto_Recupera.ToString, dtt_tabla, txt_textofact.Text, Ctl_txt_Email.texto_Recupera(), _
        ''            num_fac, num_fac, chk_abono.Checked, Ctl_txt_rec.texto_Recupera, Ctl_txt_referfact.texto_Recupera, cmb_fpago.SelectedIndex + 1, "Pendiente") = 1 Then
        ''    g_lng_ped_nunfact = num_fac

        ''End If
        ''If opr_factura.OperaAbonoPendiente(num_fac, Format(dtp_fecha_abo.Value, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss"), 0.0, "", 0) = 1 Then
        ''    g_lng_ped_nunfact = num_fac
        ''End If
        ''Flag_Pendiente = True

    End Sub
End Class
