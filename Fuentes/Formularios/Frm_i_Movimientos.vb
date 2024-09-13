'**********************************************************************************
' Nombre:   Frm_Movimientos
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para el registro y manipulacion de los movimientos
' de inventario
' Autores:  RFN
' Fecha de Creacion: 6 de Septiembre del 2002
' Autores Modificaciones: 
' Ultima Modificacion: 22 de Septiembre del 2003
' Proyecto TRUESOLUTIONS
'**********************************************************************************
Imports System.Drawing.Printing
Imports System.Drawing.Text

Public Class Frm_i_Movimientos

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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents dgts_registro As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgcs_Cantidad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_id As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgrd_movimiento As System.Windows.Forms.DataGrid
    Friend WithEvents ctl_txt_doc As Ctl_txt.ctl_txt_letras
    Friend WithEvents dtp_fecha_mov As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_nummov As System.Windows.Forms.Label
    Friend WithEvents cmb_tipomov As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipomov As System.Windows.Forms.Label
    Friend WithEvents lbl_provedor As System.Windows.Forms.Label
    Friend WithEvents cmb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_fec1 As System.Windows.Forms.Label
    Friend WithEvents lbl_fec2 As System.Windows.Forms.Label
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_autoriza As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_autoriza As Ctl_txt.ctl_txt_letras
    Friend WithEvents dgcs_producto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_descrip As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_costo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_bodega As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_fechavcto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_movpost As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_notcrd As System.Windows.Forms.Label
    Friend WithEvents pan_devmov As System.Windows.Forms.Panel
    Friend WithEvents Ctl_txt_nummov As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_nummov2 As Ctl_txt.ctl_txt_numeros
    Friend WithEvents dgcs_cantaux As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_unidad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_lote As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents dgcs_stock As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_aut As System.Windows.Forms.Label
    Friend WithEvents chk_npedido As System.Windows.Forms.CheckBox
    Friend WithEvents btn_impComp As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Entregado As Ctl_txt.ctl_txt_letras
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_BodegaAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgcs_fsco1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_fsco2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_fsco3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_pres As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_abrev As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_npedido As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_i_Movimientos))
        Me.grp_datos = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Entregado = New Ctl_txt.ctl_txt_letras
        Me.lbl_aut = New System.Windows.Forms.Label
        Me.lbl_autoriza = New System.Windows.Forms.Label
        Me.Ctl_txt_autoriza = New Ctl_txt.ctl_txt_letras
        Me.dtp_fecha_mov = New System.Windows.Forms.DateTimePicker
        Me.lbl_fec1 = New System.Windows.Forms.Label
        Me.Ctl_txt_nummov = New Ctl_txt.ctl_txt_numeros
        Me.lbl_nummov = New System.Windows.Forms.Label
        Me.cmb_tipomov = New System.Windows.Forms.ComboBox
        Me.lbl_tipomov = New System.Windows.Forms.Label
        Me.lbl_provedor = New System.Windows.Forms.Label
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.lbl_fec2 = New System.Windows.Forms.Label
        Me.dtp_fecha_doc = New System.Windows.Forms.DateTimePicker
        Me.ctl_txt_doc = New Ctl_txt.ctl_txt_letras
        Me.pan_devmov = New System.Windows.Forms.Panel
        Me.lbl_notcrd = New System.Windows.Forms.Label
        Me.Ctl_txt_nummov2 = New Ctl_txt.ctl_txt_numeros
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.chk_npedido = New System.Windows.Forms.CheckBox
        Me.dgrd_movimiento = New System.Windows.Forms.DataGrid
        Me.dgts_registro = New System.Windows.Forms.DataGridTableStyle
        Me.dgcs_id = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_producto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_bodega = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_lote = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_descrip = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Cantidad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_costo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_fechavcto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_movpost = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_cantaux = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_unidad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_stock = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_fsco1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_fsco2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_fsco3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_pres = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_abrev = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_impComp = New System.Windows.Forms.Button
        Me.btn_npedido = New System.Windows.Forms.Button
        Me.btn_anular = New System.Windows.Forms.Button
        Me.btn_reporte = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.cmb_BodegaAlmacen = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grp_datos.SuspendLayout()
        Me.pan_devmov.SuspendLayout()
        CType(Me.dgrd_movimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_datos
        '
        Me.grp_datos.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos.Controls.Add(Me.Label1)
        Me.grp_datos.Controls.Add(Me.txt_Entregado)
        Me.grp_datos.Controls.Add(Me.lbl_aut)
        Me.grp_datos.Controls.Add(Me.lbl_autoriza)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_autoriza)
        Me.grp_datos.Controls.Add(Me.dtp_fecha_mov)
        Me.grp_datos.Controls.Add(Me.lbl_fec1)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_nummov)
        Me.grp_datos.Controls.Add(Me.lbl_nummov)
        Me.grp_datos.Controls.Add(Me.cmb_tipomov)
        Me.grp_datos.Controls.Add(Me.lbl_tipomov)
        Me.grp_datos.Controls.Add(Me.lbl_provedor)
        Me.grp_datos.Controls.Add(Me.cmb_proveedor)
        Me.grp_datos.Controls.Add(Me.lbl_doc)
        Me.grp_datos.Controls.Add(Me.lbl_fec2)
        Me.grp_datos.Controls.Add(Me.dtp_fecha_doc)
        Me.grp_datos.Controls.Add(Me.ctl_txt_doc)
        Me.grp_datos.Controls.Add(Me.pan_devmov)
        Me.grp_datos.Controls.Add(Me.txt_descripcion)
        Me.grp_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_datos.ForeColor = System.Drawing.Color.Navy
        Me.grp_datos.Location = New System.Drawing.Point(6, 87)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(1099, 162)
        Me.grp_datos.TabIndex = 1
        Me.grp_datos.TabStop = False
        Me.grp_datos.Text = "Datos "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(454, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Entregado a:"
        '
        'txt_Entregado
        '
        Me.txt_Entregado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Entregado.ForeColor = System.Drawing.Color.Black
        Me.txt_Entregado.Location = New System.Drawing.Point(536, 115)
        Me.txt_Entregado.Name = "txt_Entregado"
        Me.txt_Entregado.Prp_CaracterEspecial = New String() {"'"}
        Me.txt_Entregado.Prp_CaracterPasswd = ""
        Me.txt_Entregado.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.txt_Entregado.Size = New System.Drawing.Size(273, 20)
        Me.txt_Entregado.TabIndex = 103
        '
        'lbl_aut
        '
        Me.lbl_aut.AutoSize = True
        Me.lbl_aut.BackColor = System.Drawing.Color.Transparent
        Me.lbl_aut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aut.ForeColor = System.Drawing.Color.Black
        Me.lbl_aut.Location = New System.Drawing.Point(8, 138)
        Me.lbl_aut.Name = "lbl_aut"
        Me.lbl_aut.Size = New System.Drawing.Size(75, 13)
        Me.lbl_aut.TabIndex = 100
        Me.lbl_aut.Text = "Descripcion:"
        '
        'lbl_autoriza
        '
        Me.lbl_autoriza.AutoSize = True
        Me.lbl_autoriza.BackColor = System.Drawing.Color.Transparent
        Me.lbl_autoriza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_autoriza.ForeColor = System.Drawing.Color.Black
        Me.lbl_autoriza.Location = New System.Drawing.Point(6, 110)
        Me.lbl_autoriza.Name = "lbl_autoriza"
        Me.lbl_autoriza.Size = New System.Drawing.Size(78, 13)
        Me.lbl_autoriza.TabIndex = 99
        Me.lbl_autoriza.Text = "Autorizacion"
        '
        'Ctl_txt_autoriza
        '
        Me.Ctl_txt_autoriza.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_autoriza.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_autoriza.Location = New System.Drawing.Point(92, 108)
        Me.Ctl_txt_autoriza.Name = "Ctl_txt_autoriza"
        Me.Ctl_txt_autoriza.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_autoriza.Prp_CaracterPasswd = ""
        Me.Ctl_txt_autoriza.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_autoriza.Size = New System.Drawing.Size(284, 20)
        Me.Ctl_txt_autoriza.TabIndex = 6
        '
        'dtp_fecha_mov
        '
        Me.dtp_fecha_mov.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_mov.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_fecha_mov.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_mov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_mov.Location = New System.Drawing.Point(536, 60)
        Me.dtp_fecha_mov.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha_mov.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha_mov.Name = "dtp_fecha_mov"
        Me.dtp_fecha_mov.Size = New System.Drawing.Size(116, 21)
        Me.dtp_fecha_mov.TabIndex = 3
        '
        'lbl_fec1
        '
        Me.lbl_fec1.AutoSize = True
        Me.lbl_fec1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fec1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec1.ForeColor = System.Drawing.Color.Black
        Me.lbl_fec1.Location = New System.Drawing.Point(454, 64)
        Me.lbl_fec1.Name = "lbl_fec1"
        Me.lbl_fec1.Size = New System.Drawing.Size(70, 13)
        Me.lbl_fec1.TabIndex = 81
        Me.lbl_fec1.Text = "Fecha Mov."
        '
        'Ctl_txt_nummov
        '
        Me.Ctl_txt_nummov.BackColor = System.Drawing.Color.Silver
        Me.Ctl_txt_nummov.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nummov.Location = New System.Drawing.Point(768, 29)
        Me.Ctl_txt_nummov.Name = "Ctl_txt_nummov"
        Me.Ctl_txt_nummov.Prp_Formato = False
        Me.Ctl_txt_nummov.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_nummov.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.Ctl_txt_nummov.Prp_ValDefault = ""
        Me.Ctl_txt_nummov.Size = New System.Drawing.Size(41, 20)
        Me.Ctl_txt_nummov.TabIndex = 0
        '
        'lbl_nummov
        '
        Me.lbl_nummov.AutoSize = True
        Me.lbl_nummov.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nummov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_nummov.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nummov.ForeColor = System.Drawing.Color.Black
        Me.lbl_nummov.Location = New System.Drawing.Point(681, 32)
        Me.lbl_nummov.Name = "lbl_nummov"
        Me.lbl_nummov.Size = New System.Drawing.Size(89, 13)
        Me.lbl_nummov.TabIndex = 79
        Me.lbl_nummov.Text = "#  Movimiento"
        '
        'cmb_tipomov
        '
        Me.cmb_tipomov.DisplayMember = "1"
        Me.cmb_tipomov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipomov.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipomov.ItemHeight = 14
        Me.cmb_tipomov.Location = New System.Drawing.Point(92, 18)
        Me.cmb_tipomov.Name = "cmb_tipomov"
        Me.cmb_tipomov.Size = New System.Drawing.Size(284, 22)
        Me.cmb_tipomov.TabIndex = 0
        '
        'lbl_tipomov
        '
        Me.lbl_tipomov.AutoSize = True
        Me.lbl_tipomov.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipomov.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipomov.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipomov.Location = New System.Drawing.Point(16, 26)
        Me.lbl_tipomov.Name = "lbl_tipomov"
        Me.lbl_tipomov.Size = New System.Drawing.Size(61, 13)
        Me.lbl_tipomov.TabIndex = 95
        Me.lbl_tipomov.Text = "Tipo Mov."
        '
        'lbl_provedor
        '
        Me.lbl_provedor.AutoSize = True
        Me.lbl_provedor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_provedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_provedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_provedor.Location = New System.Drawing.Point(16, 54)
        Me.lbl_provedor.Name = "lbl_provedor"
        Me.lbl_provedor.Size = New System.Drawing.Size(66, 13)
        Me.lbl_provedor.TabIndex = 94
        Me.lbl_provedor.Text = "Proveedor"
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.DisplayMember = "1"
        Me.cmb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_proveedor.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_proveedor.ItemHeight = 14
        Me.cmb_proveedor.Location = New System.Drawing.Point(92, 48)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(284, 22)
        Me.cmb_proveedor.TabIndex = 2
        '
        'lbl_doc
        '
        Me.lbl_doc.AutoSize = True
        Me.lbl_doc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doc.ForeColor = System.Drawing.Color.Black
        Me.lbl_doc.Location = New System.Drawing.Point(14, 80)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(72, 13)
        Me.lbl_doc.TabIndex = 74
        Me.lbl_doc.Text = "Documento"
        '
        'lbl_fec2
        '
        Me.lbl_fec2.AutoSize = True
        Me.lbl_fec2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fec2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec2.ForeColor = System.Drawing.Color.Black
        Me.lbl_fec2.Location = New System.Drawing.Point(454, 94)
        Me.lbl_fec2.Name = "lbl_fec2"
        Me.lbl_fec2.Size = New System.Drawing.Size(67, 13)
        Me.lbl_fec2.TabIndex = 81
        Me.lbl_fec2.Text = "Fecha Doc."
        '
        'dtp_fecha_doc
        '
        Me.dtp_fecha_doc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_doc.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_fecha_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_doc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_doc.Location = New System.Drawing.Point(536, 88)
        Me.dtp_fecha_doc.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha_doc.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha_doc.Name = "dtp_fecha_doc"
        Me.dtp_fecha_doc.Size = New System.Drawing.Size(116, 21)
        Me.dtp_fecha_doc.TabIndex = 5
        '
        'ctl_txt_doc
        '
        Me.ctl_txt_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_doc.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_doc.Location = New System.Drawing.Point(92, 78)
        Me.ctl_txt_doc.Name = "ctl_txt_doc"
        Me.ctl_txt_doc.Prp_CaracterEspecial = New String() {"'"}
        Me.ctl_txt_doc.Prp_CaracterPasswd = ""
        Me.ctl_txt_doc.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.ctl_txt_doc.Size = New System.Drawing.Size(284, 20)
        Me.ctl_txt_doc.TabIndex = 4
        '
        'pan_devmov
        '
        Me.pan_devmov.BackColor = System.Drawing.Color.Transparent
        Me.pan_devmov.Controls.Add(Me.lbl_notcrd)
        Me.pan_devmov.Controls.Add(Me.Ctl_txt_nummov2)
        Me.pan_devmov.Enabled = False
        Me.pan_devmov.Location = New System.Drawing.Point(430, 26)
        Me.pan_devmov.Name = "pan_devmov"
        Me.pan_devmov.Size = New System.Drawing.Size(222, 26)
        Me.pan_devmov.TabIndex = 1
        '
        'lbl_notcrd
        '
        Me.lbl_notcrd.BackColor = System.Drawing.Color.Transparent
        Me.lbl_notcrd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notcrd.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_notcrd.Location = New System.Drawing.Point(8, 6)
        Me.lbl_notcrd.Name = "lbl_notcrd"
        Me.lbl_notcrd.Size = New System.Drawing.Size(98, 13)
        Me.lbl_notcrd.TabIndex = 99
        Me.lbl_notcrd.Text = "Dev. # movimiento"
        Me.lbl_notcrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctl_txt_nummov2
        '
        Me.Ctl_txt_nummov2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nummov2.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nummov2.Location = New System.Drawing.Point(108, 2)
        Me.Ctl_txt_nummov2.Name = "Ctl_txt_nummov2"
        Me.Ctl_txt_nummov2.Prp_Formato = False
        Me.Ctl_txt_nummov2.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_nummov2.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.Ctl_txt_nummov2.Prp_ValDefault = ""
        Me.Ctl_txt_nummov2.Size = New System.Drawing.Size(112, 20)
        Me.Ctl_txt_nummov2.TabIndex = 0
        '
        'txt_descripcion
        '
        Me.txt_descripcion.BackColor = System.Drawing.Color.White
        Me.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_descripcion.Location = New System.Drawing.Point(92, 134)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(284, 20)
        Me.txt_descripcion.TabIndex = 95
        '
        'chk_npedido
        '
        Me.chk_npedido.Location = New System.Drawing.Point(453, 261)
        Me.chk_npedido.Name = "chk_npedido"
        Me.chk_npedido.Size = New System.Drawing.Size(18, 22)
        Me.chk_npedido.TabIndex = 101
        '
        'dgrd_movimiento
        '
        Me.dgrd_movimiento.AllowNavigation = False
        Me.dgrd_movimiento.AllowSorting = False
        Me.dgrd_movimiento.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_movimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_movimiento.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_movimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_movimiento.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_movimiento.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_movimiento.CaptionText = "Detalle Movimientos"
        Me.dgrd_movimiento.DataMember = ""
        Me.dgrd_movimiento.FlatMode = True
        Me.dgrd_movimiento.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_movimiento.ForeColor = System.Drawing.Color.Black
        Me.dgrd_movimiento.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_movimiento.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_movimiento.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_movimiento.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_movimiento.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_movimiento.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_movimiento.Location = New System.Drawing.Point(6, 255)
        Me.dgrd_movimiento.Name = "dgrd_movimiento"
        Me.dgrd_movimiento.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_movimiento.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_movimiento.ParentRowsVisible = False
        Me.dgrd_movimiento.PreferredRowHeight = 21
        Me.dgrd_movimiento.RowHeaderWidth = 10
        Me.dgrd_movimiento.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_movimiento.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_movimiento.Size = New System.Drawing.Size(1099, 307)
        Me.dgrd_movimiento.TabIndex = 2
        Me.dgrd_movimiento.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgts_registro})
        Me.dgrd_movimiento.TabStop = False
        '
        'dgts_registro
        '
        Me.dgts_registro.AllowSorting = False
        Me.dgts_registro.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgts_registro.BackColor = System.Drawing.Color.Gainsboro
        Me.dgts_registro.DataGrid = Me.dgrd_movimiento
        Me.dgts_registro.ForeColor = System.Drawing.Color.Black
        Me.dgts_registro.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgcs_id, Me.dgcs_producto, Me.dgcs_bodega, Me.dgcs_lote, Me.dgcs_descrip, Me.dgcs_Cantidad, Me.dgcs_costo, Me.dgcs_fechavcto, Me.dgcs_movpost, Me.dgcs_cantaux, Me.dgcs_unidad, Me.dgcs_stock, Me.dgcs_fsco1, Me.dgcs_fsco2, Me.dgcs_fsco3, Me.dgcs_pres, Me.dgcs_abrev})
        Me.dgts_registro.GridLineColor = System.Drawing.Color.Silver
        Me.dgts_registro.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgts_registro.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dgts_registro.HeaderForeColor = System.Drawing.Color.White
        Me.dgts_registro.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgts_registro.MappingName = "Registros"
        Me.dgts_registro.PreferredColumnWidth = 80
        Me.dgts_registro.PreferredRowHeight = 21
        Me.dgts_registro.RowHeaderWidth = 10
        Me.dgts_registro.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgts_registro.SelectionForeColor = System.Drawing.Color.White
        '
        'dgcs_id
        '
        Me.dgcs_id.Format = ""
        Me.dgcs_id.FormatInfo = Nothing
        Me.dgcs_id.MappingName = "MOV_ID"
        Me.dgcs_id.NullText = ""
        Me.dgcs_id.Width = 0
        '
        'dgcs_producto
        '
        Me.dgcs_producto.Format = ""
        Me.dgcs_producto.FormatInfo = Nothing
        Me.dgcs_producto.HeaderText = "Producto"
        Me.dgcs_producto.MappingName = "MOV_PROD"
        Me.dgcs_producto.NullText = ""
        Me.dgcs_producto.ReadOnly = True
        Me.dgcs_producto.Width = 180
        '
        'dgcs_bodega
        '
        Me.dgcs_bodega.Format = ""
        Me.dgcs_bodega.FormatInfo = Nothing
        Me.dgcs_bodega.HeaderText = "Bodega"
        Me.dgcs_bodega.MappingName = "MOV_BODEGA"
        Me.dgcs_bodega.NullText = ""
        Me.dgcs_bodega.ReadOnly = True
        Me.dgcs_bodega.Width = 180
        '
        'dgcs_lote
        '
        Me.dgcs_lote.Format = ""
        Me.dgcs_lote.FormatInfo = Nothing
        Me.dgcs_lote.HeaderText = "Lote"
        Me.dgcs_lote.MappingName = "mov_lote"
        Me.dgcs_lote.NullText = ""
        Me.dgcs_lote.Width = 70
        '
        'dgcs_descrip
        '
        Me.dgcs_descrip.Format = ""
        Me.dgcs_descrip.FormatInfo = Nothing
        Me.dgcs_descrip.HeaderText = "Descripcion"
        Me.dgcs_descrip.MappingName = "MOV_OBS"
        Me.dgcs_descrip.NullText = ""
        Me.dgcs_descrip.Width = 180
        '
        'dgcs_Cantidad
        '
        Me.dgcs_Cantidad.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgcs_Cantidad.Format = "###,##0;###,##0"
        Me.dgcs_Cantidad.FormatInfo = Nothing
        Me.dgcs_Cantidad.HeaderText = "Cant"
        Me.dgcs_Cantidad.MappingName = "MOV_CANTIDAD"
        Me.dgcs_Cantidad.NullText = ""
        Me.dgcs_Cantidad.Width = 70
        '
        'dgcs_costo
        '
        Me.dgcs_costo.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgcs_costo.Format = "###,##0.00;###,##0.00"
        Me.dgcs_costo.FormatInfo = Nothing
        Me.dgcs_costo.MappingName = "MOV_COSTO"
        Me.dgcs_costo.NullText = ""
        Me.dgcs_costo.Width = 0
        '
        'dgcs_fechavcto
        '
        Me.dgcs_fechavcto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgcs_fechavcto.Format = ""
        Me.dgcs_fechavcto.FormatInfo = Nothing
        Me.dgcs_fechavcto.HeaderText = "Fecha Vcto."
        Me.dgcs_fechavcto.MappingName = "MOV_FECVCTO"
        Me.dgcs_fechavcto.NullText = ""
        Me.dgcs_fechavcto.ReadOnly = True
        Me.dgcs_fechavcto.Width = 90
        '
        'dgcs_movpost
        '
        Me.dgcs_movpost.Format = ""
        Me.dgcs_movpost.FormatInfo = Nothing
        Me.dgcs_movpost.MappingName = "MOV_POST"
        Me.dgcs_movpost.NullText = ""
        Me.dgcs_movpost.Width = 0
        '
        'dgcs_cantaux
        '
        Me.dgcs_cantaux.Format = "###,##0.00;###,##0.00"
        Me.dgcs_cantaux.FormatInfo = Nothing
        Me.dgcs_cantaux.MappingName = "MOV_CANTAUX"
        Me.dgcs_cantaux.NullText = "0"
        Me.dgcs_cantaux.ReadOnly = True
        Me.dgcs_cantaux.Width = 0
        '
        'dgcs_unidad
        '
        Me.dgcs_unidad.Format = ""
        Me.dgcs_unidad.FormatInfo = Nothing
        Me.dgcs_unidad.HeaderText = "Unidad"
        Me.dgcs_unidad.MappingName = "MOV_UNIDAD"
        Me.dgcs_unidad.NullText = ""
        Me.dgcs_unidad.ReadOnly = True
        Me.dgcs_unidad.Width = 70
        '
        'dgcs_stock
        '
        Me.dgcs_stock.Format = ""
        Me.dgcs_stock.FormatInfo = Nothing
        Me.dgcs_stock.HeaderText = "Stock"
        Me.dgcs_stock.MappingName = "sum_cantidad"
        Me.dgcs_stock.NullText = ""
        Me.dgcs_stock.ReadOnly = True
        Me.dgcs_stock.Width = 70
        '
        'dgcs_fsco1
        '
        Me.dgcs_fsco1.Format = ""
        Me.dgcs_fsco1.FormatInfo = Nothing
        Me.dgcs_fsco1.HeaderText = "FSCO 1"
        Me.dgcs_fsco1.MappingName = "I_MOV_FSCO1"
        Me.dgcs_fsco1.NullText = "No"
        Me.dgcs_fsco1.Width = 0
        '
        'dgcs_fsco2
        '
        Me.dgcs_fsco2.Format = ""
        Me.dgcs_fsco2.FormatInfo = Nothing
        Me.dgcs_fsco2.HeaderText = "FSCO 2"
        Me.dgcs_fsco2.MappingName = "I_MOV_FSCO2"
        Me.dgcs_fsco2.NullText = "No"
        Me.dgcs_fsco2.Width = 0
        '
        'dgcs_fsco3
        '
        Me.dgcs_fsco3.Format = ""
        Me.dgcs_fsco3.FormatInfo = Nothing
        Me.dgcs_fsco3.HeaderText = "FSCO 3"
        Me.dgcs_fsco3.MappingName = "I_MOV_FSCO3"
        Me.dgcs_fsco3.NullText = "No"
        Me.dgcs_fsco3.Width = 0
        '
        'dgcs_pres
        '
        Me.dgcs_pres.Format = ""
        Me.dgcs_pres.FormatInfo = Nothing
        Me.dgcs_pres.HeaderText = "Presentacion"
        Me.dgcs_pres.MappingName = "PRES_ID"
        Me.dgcs_pres.NullText = "NA"
        Me.dgcs_pres.ReadOnly = True
        Me.dgcs_pres.Width = 90
        '
        'dgcs_abrev
        '
        Me.dgcs_abrev.Format = ""
        Me.dgcs_abrev.FormatInfo = Nothing
        Me.dgcs_abrev.HeaderText = "Codigo"
        Me.dgcs_abrev.MappingName = "I_PRD_ABREV"
        Me.dgcs_abrev.NullText = ""
        Me.dgcs_abrev.ReadOnly = True
        Me.dgcs_abrev.Width = 60
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Reporte De Movimientos"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1117, 25)
        Me.Panel1.TabIndex = 170
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(8, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "INVENTARIO DE INSUMOS"
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
        Me.btn_cancelar.Location = New System.Drawing.Point(774, 43)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 36)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_impComp
        '
        Me.btn_impComp.BackColor = System.Drawing.SystemColors.Control
        Me.btn_impComp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_impComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_impComp.ForeColor = System.Drawing.Color.Black
        Me.btn_impComp.Image = CType(resources.GetObject("btn_impComp.Image"), System.Drawing.Image)
        Me.btn_impComp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_impComp.Location = New System.Drawing.Point(675, 43)
        Me.btn_impComp.Name = "btn_impComp"
        Me.btn_impComp.Size = New System.Drawing.Size(97, 36)
        Me.btn_impComp.TabIndex = 95
        Me.btn_impComp.Text = "Comprobante"
        Me.btn_impComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_impComp.UseVisualStyleBackColor = False
        '
        'btn_npedido
        '
        Me.btn_npedido.BackColor = System.Drawing.SystemColors.Control
        Me.btn_npedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_npedido.Enabled = False
        Me.btn_npedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_npedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_npedido.ForeColor = System.Drawing.Color.Black
        Me.btn_npedido.Image = CType(resources.GetObject("btn_npedido.Image"), System.Drawing.Image)
        Me.btn_npedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_npedido.Location = New System.Drawing.Point(483, 261)
        Me.btn_npedido.Name = "btn_npedido"
        Me.btn_npedido.Size = New System.Drawing.Size(108, 24)
        Me.btn_npedido.TabIndex = 102
        Me.btn_npedido.Text = "Nota de Pedido"
        Me.btn_npedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_npedido.UseVisualStyleBackColor = False
        '
        'btn_anular
        '
        Me.btn_anular.BackColor = System.Drawing.SystemColors.Control
        Me.btn_anular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anular.ForeColor = System.Drawing.Color.Black
        Me.btn_anular.Image = CType(resources.GetObject("btn_anular.Image"), System.Drawing.Image)
        Me.btn_anular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_anular.Location = New System.Drawing.Point(856, 43)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(80, 36)
        Me.btn_anular.TabIndex = 94
        Me.btn_anular.Text = "Anular"
        Me.btn_anular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_anular.UseVisualStyleBackColor = False
        Me.btn_anular.Visible = False
        '
        'btn_reporte
        '
        Me.btn_reporte.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reporte.ForeColor = System.Drawing.Color.Black
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reporte.Location = New System.Drawing.Point(593, 43)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(80, 36)
        Me.btn_reporte.TabIndex = 93
        Me.btn_reporte.Text = "Reporte"
        Me.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reporte.UseVisualStyleBackColor = False
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
        Me.btn_aceptar.Location = New System.Drawing.Point(511, 43)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 36)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'cmb_BodegaAlmacen
        '
        Me.cmb_BodegaAlmacen.DisplayMember = "1"
        Me.cmb_BodegaAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BodegaAlmacen.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_BodegaAlmacen.ItemHeight = 16
        Me.cmb_BodegaAlmacen.Location = New System.Drawing.Point(107, 48)
        Me.cmb_BodegaAlmacen.Name = "cmb_BodegaAlmacen"
        Me.cmb_BodegaAlmacen.Size = New System.Drawing.Size(284, 24)
        Me.cmb_BodegaAlmacen.TabIndex = 171
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "BODEGA"
        '
        'Frm_i_Movimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(1117, 574)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_BodegaAlmacen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgrd_movimiento)
        Me.Controls.Add(Me.btn_impComp)
        Me.Controls.Add(Me.btn_npedido)
        Me.Controls.Add(Me.chk_npedido)
        Me.Controls.Add(Me.btn_anular)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_i_Movimientos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "1"
        Me.Text = "Movimientos de Inventario"
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        Me.pan_devmov.ResumeLayout(False)
        CType(Me.dgrd_movimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Codigo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Private opr_negocio As New Cls_Pedido()
    Dim opr_res As New Cls_Resultado()
    Private WithEvents dtt_inventario As New DataTable("Registros")
    Dim dt As DataTable = New DataTable()




    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ClickMenu_Principal(Me)
        'Funcion para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
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
        'Funcion para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.MouseEnter, btn_cancelar.MouseEnter, btn_reporte.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.MouseLeave, btn_cancelar.MouseLeave, btn_reporte.MouseLeave
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
        Dim int_posX As Integer
        int_posX = (Me.MdiParent.Size.Width - Me.MdiParent.Size.Width) / 2
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
        'elimina la referencia del formulario del MDI
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


    Private WithEvents dtt_tabla As New DataTable("Registros")
    Private WithEvents dtv_tabla As New DataView(dtt_tabla)

    Private opr_movimiento As New Cls_i_Movimiento()

    Private WithEvents chk_fsco1 As New CheckBox()
    Private WithEvents chk_fsco2 As New CheckBox()
    Private WithEvents chk_fsco3 As New CheckBox()

    Private WithEvents cmb_bodega As New ComboBox()
    Private WithEvents cmb_unidad As New ComboBox()
    Private WithEvents cmb_fecha_vcto As New DateTimePicker()

    Dim numpedido As String = ""
    Dim docpedido As String = ""
    Dim selec_ped As Byte = 0

    Private boo_cambiaTam As Boolean = False
    Private boo_modDetalle As Boolean = True  'indica si se modifica el detalle

    Private WithEvents pdoc As New PrintDocument()
    Public comprobante, detalle As String
    Dim dts_movimiento As New DataSet()
    Dim dtr_operacion As DataRow


#Region "Funcionalidad del formulario"

#Region "Otras funciones"

    Public Sub carga_datos_producto(ByVal dato As String)
        On Error Resume Next
        
        'ESCRIBE EN EL GRID PRINCIPAL EL TEXTO SELECCIONADO EN EL GRID
        Inserta_campo(1, dato)
        If Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 68, 1)) = 1 Then
            If Trim(dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7).ToString) = "NP" Or Trim(dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7).ToString) = "" Then
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7) = Format(Now, "dd/MM/yyyy")
            End If
        Else
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7) = "NP"
        End If

        dts_movimiento = opr_movimiento.leerbodega(Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 1, 15)), Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)))

        dtr_operacion = dts_movimiento.Tables(0).Rows(0)


        If dtr_operacion.HasErrors = True And Trim(Mid(cmb_tipomov.Text, 1, 15)) = "EGR" Then
            MsgBox("El producto no posee Movimientos", MsgBoxStyle.Information, "ANALISYS")
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(2) = ""
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(11) = ""
        End If

        If Trim(Mid(cmb_tipomov.Text, 1, 15)) = "EGR" Or Trim(Mid(cmb_tipomov.Text, 1, 15)) = "ING" Or Trim(Mid(cmb_tipomov.Text, 1, 15)) = "NPD" Then
            'dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7) = ""
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(2) = cmb_bodega.GetItemText(cmb_bodega.Items.Item(UbicaCombo(dtr_operacion(0).ToString().PadRight(15), cmb_bodega)))
        End If

        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(10) = Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 89))
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(11) = dtr_operacion(1).ToString().PadRight(15)
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(3) = dtr_operacion(2).ToString()
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(4) = txt_descripcion.Text

        'seteo combo igual al BODEHA PRIMCIPAL
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(2) = Trim(cmb_BodegaAlmacen.Text)

        Select Case CInt(Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 140, 10)))

            Case 0 : dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(12) = "Si"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(13) = "No"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(14) = "No"

            Case 1 : dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(12) = "Si"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(13) = "No"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(14) = "No"

            Case 2 : dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(12) = "Si"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(13) = "Si"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(14) = "No"

            Case 3 : dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(12) = "Si"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(13) = "Si"
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(14) = "Si"
        End Select

        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(15) = Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 160, 20))

        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(16) = Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 180, 30))

    End Sub





    Public Sub carga_datos_bodega(ByVal bodega As String)
        On Error Resume Next
        Dim dts_movimiento As New DataSet()
        Dim dtr_operacion As DataRow
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(3) = Trim(Mid(bodega, 1, 15))
        If Trim(bodega) = "" Then
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(2) = "NP"
        Else
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(2) = Trim(bodega)
        End If
        'dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(11) = Trim(bodega)
        ''cmb_bodega.SelectedText = bodega
        cmb_bodega.SelectedText = cmb_BodegaAlmacen.Text
    End Sub


    Sub CargaChecks(ByVal i_prd_id As String, ByVal chk As CheckBox)

    End Sub


    Public Sub carga_datos_lote(ByVal dato As String)
        On Error Resume Next
        Dim dts_movimiento As New DataSet()
        Dim dtr_operacion As DataRow
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(3) = Trim(Mid(dato, 1, 15))
        If Trim(Mid(dato, 16, 11)) = "" Then
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7) = "NP"
            cmb_fecha_vcto.Enabled = False
        Else
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7) = Trim(Mid(dato, 16, 11))
            cmb_fecha_vcto.Enabled = True
        End If
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(11) = Trim(Mid(dato, 27, 20))
    End Sub

    Public Sub carga_datos_npedido(ByVal dato As String, ByVal nped As Int32, ByVal docped As String)
        On Error Resume Next
        Dim int_estado, estado As Single
        Dim int_indice, int_cont As Short
        Dim dts_movimiento As New DataSet()
        Dim dtr_operacion As DataRow
        Dim str_tipomov As String

        grp_datos.Enabled = True
        dgrd_movimiento.ReadOnly = False
        dgrd_movimiento.Enabled = True
        dts_movimiento = opr_movimiento.leernpedido(dato, nped)
        If numpedido = "" Then
            numpedido = nped & "," & dato
            docpedido = docped
        Else
            numpedido = numpedido & "*," & nped & "," & dato
            docpedido = docpedido & "," & docped
        End If

        If dts_movimiento.Tables(0).Rows.Count > 0 Then
            dtr_operacion = dts_movimiento.Tables(0).Rows(0)
            If Not IsDBNull(dtr_operacion(9)) Then
                Dim opr_producto As New Cls_i_Producto()
                Dim arr_fila(11) As String

                For int_indice = 0 To dts_movimiento.Tables(0).Rows.Count - 1
                    dtr_operacion = dts_movimiento.Tables(0).Rows(int_indice)
                    '0 --> id de detalle movimiento
                    arr_fila(0) = dtr_operacion(8).ToString()
                    '1 --> producto
                    arr_fila(1) = opr_producto.ConsultaProductoEspecificoGrid(dtr_operacion(9).ToString().PadRight(15))
                    '2 --> bodega
                    arr_fila(2) = cmb_bodega.GetItemText(cmb_bodega.Items.Item(UbicaCombo(dtr_operacion(12).ToString().PadRight(15), cmb_bodega)))
                    '3 --> lote
                    arr_fila(3) = dtr_operacion(18).ToString()
                    '4 --> descripcion del movimiento
                    If txt_descripcion.Text = "" Then
                        arr_fila(4) = dtr_operacion(14).ToString()
                    Else
                        arr_fila(4) = txt_descripcion.Text
                    End If

                    '5 --> cantidad
                    arr_fila(5) = Math.Abs(CDbl(dtr_operacion(10).ToString()))
                    '6 --> costo
                    arr_fila(6) = 0
                    '7 --> fecha de vcto. del producto ingresado
                    If Trim(dtr_operacion(13).ToString()) = "" Then
                        arr_fila(7) = "NP"
                    Else
                        arr_fila(7) = Format(CDate(dtr_operacion(13).ToString()), "dd/MM/yyyy")
                    End If

                    Dim dts_movimiento1 As New DataSet()
                    Dim dtr_operacion1 As DataRow
                    dts_movimiento1 = opr_movimiento.leerbodega(Trim(dtr_operacion(9).ToString().PadRight(15)), Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)))
                    dtr_operacion1 = dts_movimiento1.Tables(0).Rows(0)
                    arr_fila(11) = dtr_operacion1(1).ToString().PadRight(15)
                    arr_fila(9) = arr_fila(5)
                    arr_fila(10) = Trim(Mid(arr_fila(1), 89))
                    dtt_tabla.Rows.Add(arr_fila)
                Next
                'Si se escogio una nota de pedido
                selec_ped = 1
            End If
        End If
    End Sub

    Private Sub cmb_tipomov_cambia(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_tipomov.SelectedIndexChanged
        costo_egreso(sender, e)
        txt_Entregado.texto_Asigna("")
        'se verifica si son Devoluciones        
        If Trim(Mid(cmb_tipomov.Text, 1, 15)) = "DEGR" Or Trim(Mid(cmb_tipomov.Text, 1, 15)) = "DING" Then
            'realizamos un doble cambio de estado para activar y limpiar los datos del formulario
            If Me.Tag = 1 Then
                pan_devmov.Enabled = False
                pan_devmov.Enabled = Not pan_devmov.Enabled
            Else
                dtv_tabla.AllowNew = False
                cmb_bodega.Enabled = False
            End If
        Else
            If pan_devmov.Enabled Then pan_devmov.Enabled = False
            'En el caso de que sea un egreso, la fecha de vencimiento no es modificada.
            If Trim(Mid(cmb_tipomov.Text, 1, 15)) = "EGR" Then
                dgcs_fechavcto.ReadOnly = True
                cmb_bodega.Visible = False
                dgcs_lote.ReadOnly = True
                chk_npedido.Enabled = True
                'txt_Entregado.texto_Asigna("")
                txt_Entregado.Enabled = True
            Else
                dgcs_fechavcto.ReadOnly = False
                cmb_fecha_vcto.Enabled = True
                cmb_bodega.Visible = True
                dgcs_lote.ReadOnly = False
                chk_npedido.Enabled = False
                chk_npedido.Checked = False
                txt_Entregado.Enabled = False
            End If
            dgcs_fechavcto.Width = 90

            If Me.Tag = 2 Then
                dtv_tabla.AllowNew = True
                cmb_bodega.Enabled = True
                chk_npedido.Enabled = False

            End If
        End If
    End Sub

    Function UbicaCombo(ByVal str_clave As String, ByVal cmb_combo As ComboBox) As Short
        UbicaCombo = 0
        Dim int_pos_rownum As Short
        For int_pos_rownum = 0 To cmb_combo.Items.Count - 1
            If cmb_combo.Items.Item(int_pos_rownum).substring(0, 15) = str_clave Then
                UbicaCombo = int_pos_rownum
                Exit For
            End If
        Next
    End Function

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        If MsgBox("Desea cerrar el formulario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub NumMov_pierdenfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_nummov.Leave
        If Ctl_txt_nummov.texto_Recupera = "" Or Me.Tag = 1 Then Exit Sub
        Recupera_movimiento(Ctl_txt_nummov.texto_Recupera)
    End Sub

    Private Sub Ctl_txt_nummov2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_nummov2.Leave
        If Ctl_txt_nummov2.texto_Recupera = "" Then Exit Sub
        Recupera_movimiento(Ctl_txt_nummov2.texto_Recupera)
    End Sub

#End Region

#Region "Funcionalidad Grid"

    Private Sub ColumnaValorCambia(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles dtt_tabla.ColumnChanging
        On Error Resume Next
        If Trim(Mid(cmb_tipomov.Text, 1, 15)) = "DEGR" Or Trim(Mid(cmb_tipomov.Text, 1, 15)) = "DING" Then
            'controla que el valor ingresado en la columna de cantidad
            If dgrd_movimiento.CurrentCell.ColumnNumber = 4 Then
                'controla que no sea superior a la cantidad cuando se trata de devoluciones
                If e.ProposedValue > dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(8) Then
                    e.ProposedValue = dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(4)
                End If
            End If
        End If
    End Sub

    Private Sub dgrd_movimiento_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_movimiento.CurrentCellChanged, dgrd_movimiento.Enter, dgrd_movimiento.Click
        On Error Resume Next
        dgrd_movimiento.Select(dgrd_movimiento.CurrentCell.RowNumber)
    End Sub

    Private Sub dgrd_movimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_movimiento.KeyDown
        On Error Resume Next
        'If e.KeyData.Delete Then
        If e.KeyData.ToString = "Delete" Then
            If dtt_tabla.Rows.Count <= 0 Then Exit Sub
            dgrd_movimiento.Select(dgrd_movimiento.CurrentCell.RowNumber)
            If MsgBox("Desea eliminar el producto seleccionado?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.Yes Then
                dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Delete()
            End If
        End If
    End Sub

    Private Sub ColumnasWidth(ByVal sender As Object, ByVal e As System.EventArgs)
        cmb_bodega.Width = dgcs_bodega.Width
        cmb_fecha_vcto.Width = dgcs_fechavcto.Width
        If Not boo_cambiaTam Then
            dgcs_id.Width = 0
            dgcs_producto.Width = 90
            dgcs_bodega.Width = 80
            dgcs_descrip.Width = 220
            dgcs_Cantidad.Width = 70
            dgcs_fechavcto.Width = 90
            dgcs_costo.Width = 0
            dgcs_unidad.Width = 75
            dgcs_lote.Width = 55
            dgcs_stock.Width = 70

        End If
    End Sub

    Sub Inserta_campo(ByVal columna As Short, ByVal texto As String)
        On Error GoTo msgerrcol
        If Trim(texto) = "" Then Exit Sub
        dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(columna) = texto
        Exit Sub
msgerrcol:
        If Err.Number = 9 Then
            Dim dtr_fila As DataRow
            dtr_fila = dtt_tabla.NewRow
            dtt_tabla.Rows.Add(dtr_fila)
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(columna) = texto
        End If
    End Sub

    Private Sub select_bodega(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_bodega.SelectedValueChanged
        On Error Resume Next
        'escribe en el grid el texto seleccionado en el grid
        Inserta_campo(2, sender.text)

        dts_movimiento = opr_movimiento.leerbodega(Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 1, 15)), Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 2), 1, 10)))

        dtr_operacion = dts_movimiento.Tables(0).Rows(0)

        TamColumna(sender, e)
    End Sub

    Private Sub select_fechavcto(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_fecha_vcto.TextChanged
        'escribe en el grid el texto seleccionado en el grid
        On Error Resume Next
        If Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 68, 1)) = 1 Then
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7) = sender.text
        Else
            dtt_tabla.Rows(dgrd_movimiento.CurrentCell.RowNumber).Item(7) = "NP"
        End If
        If Trim(Mid(cmb_tipomov.Text, 1, 15)) = "EGR" Then
            cmb_fecha_vcto.Enabled = False
        Else
            cmb_fecha_vcto.Enabled = True
        End If

    End Sub

    Sub TamColumna(ByVal sender As Object, ByVal e As System.EventArgs)
        'dgcs_producto.TextBox.Text = Mid(dgcs_producto.TextBox.Text, 15)
        dgcs_bodega.Width = 80
    End Sub

    Private Sub cmb_bodega_Enfoque(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_bodega.Enter
        boo_cambiaTam = True
        dgcs_bodega.Width = 300
        dgcs_bodega.TextBox.Width = 300
        boo_cambiaTam = False
    End Sub

    Sub TextoDblClick(ByVal Sender As Object, ByVal e As EventArgs)
        'llama a la pantalla de productos
        Me.Cursor = Cursors.WaitCursor
        If pan_devmov.Enabled = False Then
            Dim FrM_MDIChild As New frm_BusqProducto()
            FrM_MDIChild.frm_refer_main = frm_refer_main_form
            FrM_MDIChild.Tag = Me.Name
            FrM_MDIChild.ShowDialog(frm_refer_main_form)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Sub TextoDblClicklote(ByVal Sender As Object, ByVal e As EventArgs)
        'llama a la pantalla de lote

        Me.Cursor = Cursors.WaitCursor
        If pan_devmov.Enabled = False And Not IsDBNull(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1)) Then
            Dim FrM_MDIChild As New frm_i_lote()
            FrM_MDIChild.frm_refer_main = frm_refer_main_form
            FrM_MDIChild.Tag = Me.Name
            FrM_MDIChild.producto = (Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 1, 15)))
            FrM_MDIChild.ShowDialog(frm_refer_main_form)
        Else
            MsgBox("Primero debe escojer un producto", MsgBoxStyle.Critical, "ANALISYS")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Despliega_bodega(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        cmb_bodega.SelectedIndex = UbicaCombo(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 2).substring(0, 15), cmb_bodega)
        cmb_bodega.Text = cmb_BodegaAlmacen.Text
        cmb_bodega_Enfoque(Sender, e)
    End Sub

    Private Sub Despliega_fechavcto(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        If Trim(Mid(dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 1), 68, 1)) <> "NP" Then
            cmb_fecha_vcto.Visible = True
            cmb_fecha_vcto.Value = dgrd_movimiento(dgrd_movimiento.CurrentCell.RowNumber, 7).ToString
        Else
            cmb_fecha_vcto.Visible = False
        End If
    End Sub

#End Region

#Region "Inicia Formulario"


    Sub CargarCombo()
        On Error Resume Next
        Dim dtr_fila As DataRow
        Dim opr_bodega As New Cls_i_Bodega()
        Dim opr_producto As New Cls_i_Producto()
        Dim opr_proveedor As New Cls_i_Proveedor()
        Dim opr_tipomov As New Cls_i_TipoMovimiento()


        cmb_bodega.Items.Clear()
        cmb_proveedor.Items.Clear()
        cmb_tipomov.Items.Clear()

        For Each dtr_fila In opr_bodega.LeerBodega(g_division).Tables(0).Rows
            cmb_bodega.Items.Add(dtr_fila("I_BOD_ID").ToString().PadRight(15) & " " & Mid(dtr_fila("I_BOD_DESCRIPCION").ToString(), 1, 25).PadRight(20))
        Next

        cmb_proveedor.Items.Add("".PadRight(36))
        For Each dtr_fila In opr_proveedor.LeerProveedor.Tables(0).Rows
            cmb_proveedor.Items.Add(dtr_fila("I_PRO_ID").ToString().PadRight(15) & " " & Mid(dtr_fila("I_PRO_NOMBRE").ToString(), 1, 20).PadRight(20))
        Next

        For Each dtr_fila In opr_tipomov.LeerTipoMovimiento.Tables(0).Rows
            cmb_tipomov.Items.Add(dtr_fila("I_TIM_ID").ToString().PadRight(15) & " " & Mid(dtr_fila("I_TIM_DESCRIPCION").ToString().PadRight(25), 1, 25) & " " & dtr_fila("I_TIM_TIPO").ToString().PadRight(10))
        Next

        'cmb_bodega.SelectedIndex = 0
        cmb_proveedor.SelectedIndex = 0
        cmb_tipomov.SelectedIndex = 0
    End Sub

    Sub Inicia_Combo()
        On Error Resume Next
        Dim int_tam As Short
        int_tam = 300
        CargarCombo()
        'celda productos
        AddHandler dgcs_producto.TextBox.DoubleClick, AddressOf TextoDblClick
        'celda lote
        AddHandler dgcs_lote.TextBox.DoubleClick, AddressOf TextoDblClicklote
        'combo de bodega
        cmb_bodega.Font = New Font("Courier New", 8.2!, FontStyle.Regular)
        cmb_bodega.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_bodega.Width = int_tam
        dgcs_bodega.TextBox.Width = int_tam
        cmb_bodega.Text = dgcs_bodega.TextBox.Text
        dgcs_bodega.TextBox.Controls.Add(cmb_bodega)
        cmb_bodega.BringToFront()
        AddHandler dgcs_bodega.TextBox.Enter, AddressOf Despliega_bodega
        AddHandler dgcs_bodega.TextBox.MouseEnter, AddressOf Despliega_bodega
        AddHandler dgcs_bodega.TextBox.Leave, AddressOf TamColumna
        'combo de fecha de caducidad producto
        cmb_fecha_vcto.Font = New Font("Courier New", 8.2!, FontStyle.Regular)
        cmb_fecha_vcto.Format = DateTimePickerFormat.Short
        cmb_fecha_vcto.Width = dgcs_fechavcto.Width
        cmb_fecha_vcto.Text = dgcs_fechavcto.TextBox.Text
        dgcs_fechavcto.TextBox.Controls.Add(cmb_fecha_vcto)
        AddHandler dgcs_fechavcto.TextBox.Enter, AddressOf Despliega_fechavcto
    End Sub

    Sub Inicia_grid()
        Dim int_indice As Short
        dtv_tabla.AllowDelete = False
        dgrd_movimiento.DataSource = dtv_tabla
        'colummas de
        '0 --> id de detalle movimiento     '1 --> producto
        '2 --> bodega                       '3 --> Lote
        '4 --> descripcion del movimiento
        '5 --> cantidad                     '6 --> costo
        '7 --> fecha de vcto del producto ingresado
        '8 --> Indica si el producto tiene movimientos posterioes, que eviten hacer egresos
        '10 --> Unidad                      11 --> stock
        Dim STR_CAPTION As String() = {"MOV_ID", "MOV_PROD", "MOV_BODEGA", "MOV_LOTE", "MOV_OBS", "MOV_CANTIDAD", "MOV_COSTO", "MOV_FECVCTO", "MOV_POST", "MOV_CANTAUX", "MOV_UNIDAD", "sum_cantidad", "I_MOV_FSCO1", "I_MOV_FSCO2", "I_MOV_FSCO3", "PRES_ID", "I_PRD_ABREV"}
        For int_indice = 0 To 16
            Dim dtc_columna As New DataColumn(STR_CAPTION(int_indice))
            Select Case int_indice
                Case 0, 1, 2, 3, 4, 7, 8, 10, 11, 12, 13, 14, 15, 16
                    dtc_columna.DataType = Type.GetType("System.String")
                Case 5, 9, 6, 11
                    dtc_columna.DataType = Type.GetType("System.Double")
            End Select
            dtt_tabla.Columns.Add(dtc_columna)
        Next
    End Sub


    Private Sub frm_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        AddHandler dgcs_id.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_bodega.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_lote.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_descrip.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_Cantidad.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_unidad.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_fechavcto.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_stock.WidthChanged, AddressOf ColumnasWidth
        AddHandler dgcs_fsco1.WidthChanged, AddressOf ColumnasWidth

        Me.Cursor = Cursors.WaitCursor

        opr_negocio.LlenarComboBodegas(cmb_BodegaAlmacen)

        Inicia_grid()
        Inicia_Combo()
        dtp_fecha_mov.CustomFormat = "dd-MMM-yyyy"
        dtp_fecha_doc.CustomFormat = "dd-MMM-yyyy"
        Select Case Me.Tag
            Case 1 'NUEVAS
                Ctl_txt_nummov.texto_Asigna(opr_movimiento.LeerMaxMovimiento() + 1)
                Ctl_txt_nummov.txt_padre.ReadOnly = True
                'lbl_textform.Text = "  Ingreso Movimientos de Inventario"
            Case 2 'MODIFICACIONES
                btn_anular.Visible = True
                btn_anular.Enabled = False
                grp_datos.Enabled = False
                cmb_tipomov.Enabled = True
                'lbl_textform.Text = "  Modificacion Movimientos de Inventario"
        End Select
        Ctl_txt_nummov.txt_padre.MaxLength = 8
        Ctl_txt_nummov2.txt_padre.MaxLength = 8
        ctl_txt_doc.txt_padre.MaxLength = 30
        Ctl_txt_autoriza.txt_padre.MaxLength = 100

        cmb_proveedor.SelectedIndex = 1
        cmb_tipomov.SelectedIndex = 4
        Me.Cursor = Cursors.Default
    End Sub



    'Private Sub cargaGridInventario(ByVal datos As String)


    '    dgv_InvDetalle.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    '    dgv_InvDetalle.DefaultCellStyle.SelectionForeColor = Color.White
    '    dgv_InvDetalle.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
    '    dgv_InvDetalle.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

    '    Dim row As DataRow = dt.NewRow()
    '    row("MOV_ID") = datos
    '    row("MOV_PROD") = datos
    '    row("MOV_BODEGA") = "B01"
    '    dt.Rows.Add(row)


    '    dt.AcceptChanges()
    '    dgv_InvDetalle.DataSource = dt

    'End Sub

    'Private Function actualizaDtsInventario(ByVal i_mov_id As Integer) As Integer
    '    dtt_inventario.Clear()
    '    If opr_res.LlenarInventario(dgv_InvDetalle, dtt_inventario, i_mov_id) > 0 Then
    '        actualizaDtsInventario = 1
    '    Else
    '        actualizaDtsInventario = 0
    '    End If
    'End Function



#End Region

    Sub costo_egreso(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If Trim(cmb_tipomov.Text.Substring(42, 10)) = "EGRESO" And Trim(Mid(cmb_tipomov.Text, 1, 15)) <> "DEGR" And Trim(Mid(cmb_tipomov.Text, 1, 15)) <> "DING" Then
            cmb_proveedor.Enabled = False
        Else
            cmb_proveedor.Enabled = True
        End If
        If Trim(cmb_tipomov.Text.Substring(42, 10)) = "INGRESO" And Trim(Mid(cmb_tipomov.Text, 1, 15)) = "ITF" Then
            cmb_proveedor.Enabled = True
            Dim i As Integer = 1
            For i = 1 To CInt(CStr(cmb_proveedor.Items.Count))
                If Trim(Mid(cmb_proveedor.Items.Item(i), 1, 15)) = "SIM" Then
                    cmb_proveedor.SelectedIndex = i
                End If
            Next
        End If
    End Sub

    Sub limpia_grid()
        Dim int_indice As Short
        For int_indice = dtt_tabla.Rows.Count - 1 To 0 Step -1
            dtt_tabla.Rows(int_indice).Delete()
        Next
        dtt_tabla.Clear()
    End Sub

    Private Sub pan_devmov_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pan_devmov.EnabledChanged
        Ctl_txt_nummov2.texto_Asigna("")
        If pan_devmov.Enabled Then limpia_grid()
        dtv_tabla.AllowNew = Not pan_devmov.Enabled
        cmb_bodega.Enabled = Not pan_devmov.Enabled
    End Sub

    Sub limpia()
        limpia_grid()
        Ctl_txt_autoriza.texto_Asigna("")
        ctl_txt_doc.texto_Asigna("")
        If Ctl_txt_nummov2.texto_Recupera = "" Then
            pan_devmov.Enabled = False
            cmb_tipomov.SelectedIndex = 0
        End If
        cmb_proveedor.SelectedIndex = 0
    End Sub

    Private Sub dtp_fecha_mov_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_fecha_mov.Leave
        If dtp_fecha_mov.Value > Now Then
            MsgBox("Fecha de movimiento no puede ser mayor a la actual", MsgBoxStyle.Exclamation, "ANALISYS")
            dtp_fecha_mov.Focus()
        End If
    End Sub

#End Region

#Region "Aceptar"

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        Dim boo_opera As Boolean = False
        Dim int_indice As Short
        Dim STR_PRD_CAD, STR_PRD_STOCK, STR_MSG As String

        If dtt_tabla.Rows.Count <= 0 Then
            'VALIDAMOS LA TABLA DE DATOS
            '''MsgBox("Ingrese detalle de Productos", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese detalle de Productos", g_tiempo)
            Exit Sub
        End If

        If dgrd_movimiento.ReadOnly Or Not dgrd_movimiento.Enabled Then
            '''MsgBox("No puede realizar los cambios solicitados", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("No puede realizar los cambios solicitados", g_tiempo)
            Exit Sub
        End If

        If Trim(Ctl_txt_nummov.texto_Recupera) = "" Then
            '''MsgBox("Ingrese el numero de movimiento", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese el numero de movimiento", g_tiempo)
            Exit Sub
        End If

        If MsgBox("Desea almacenar los cambios realizados?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.No Then Exit Sub

        For int_indice = 0 To dtt_tabla.Rows.Count - 1
            ' Consulta si los lotes van vacios
            'If Trim(dtt_tabla.Rows(int_indice).Item(3).ToString) = "" Then
            '    If MsgBox("Hay Productos sin Lote, esta seguro que desea continuar?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
            '        Exit Sub
            '    End If
            'End If


            If Trim(dtt_tabla.Rows(int_indice).Item(1).ToString) = "" Or Trim(dtt_tabla.Rows(int_indice).Item(2).ToString) = "" Or Trim(dtt_tabla.Rows(int_indice).Item(5).ToString) = "" Then
                If Trim(dtt_tabla.Rows(int_indice).Item(7).ToString) = "" And Mid(dtt_tabla.Rows(int_indice).Item(1), 68, 1) = 1 Then
                    '''MsgBox("El producto " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15)) & " necesita de fecha de caducidad", MsgBoxStyle.Exclamation, "ANALISYS")
                    opr_negocio.VisualizaMensaje("El producto " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15)) & " necesita de fecha de caducidad", g_tiempo)
                Else
                    '''MsgBox("Debe ingresar los datos del Detalle del Movimiento: " & Chr(13) & "Producto, Bodega", MsgBoxStyle.Exclamation, "ANALISYS")
                    opr_negocio.VisualizaMensaje("Debe ingresar los datos del Detalle del Movimiento: " & Chr(13) & "Producto, Bodega", g_tiempo)
                End If
                Exit Sub
            Else
                dtt_tabla.Rows(int_indice).Item(5) = dtt_tabla.Rows(int_indice).Item(5)
                If Trim(cmb_tipomov.Text.Substring(42, 10)) = "EGRESO" Then
                    'el stock de los productos es negativo
                    Dim dbl_cantidad As Double


                    If IsDBNull(dtt_tabla.Rows(int_indice).Item(3)) Then
                        dtt_tabla.Rows(int_indice).Item(3) = ""
                    End If
                    'dbl_cantidad = opr_movimiento.ProductoBodega(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(3), 1, 15)) - dtt_tabla.Rows(int_indice).Item(5)
                    If selec_ped = 1 Then ' si es uno indica que se tomo una nota de pedido
                        dbl_cantidad = opr_movimiento.ProductoBodega(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(3), 1, 15), dtt_tabla.Rows(int_indice).Item(5), 1)
                    Else
                        If Trim(Mid(cmb_tipomov.Text, 1, 10)) <> "TRF" Then
                            dbl_cantidad = opr_movimiento.ProductoBodega(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(3), 1, 15), dtt_tabla.Rows(int_indice).Item(5), 0)
                        Else
                            dbl_cantidad = opr_movimiento.ProductoBodega(Mid(cmb_BodegaAlmacen.Text, 1, 10), Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(3), 1, 15), dtt_tabla.Rows(int_indice).Item(5), 0)
                        End If

                        If dbl_cantidad < 0 Then
                            STR_PRD_STOCK = Chr(13) & Space(10) & " * " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15)) & " " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 16, 50)) & STR_PRD_STOCK
                        End If
                    End If
                End If
            End If

            'Validacion de Productos caducados
            If Trim(cmb_tipomov.Text.Substring(42, 10)) = "EGRESO" Then
                If Trim(Mid(cmb_tipomov.Text, 1, 10)) <> "TRF" Then
                    If opr_movimiento.ProductoCaducado(Trim(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15)), Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15))) Then
                        STR_PRD_CAD = Chr(13) & Space(10) & " * " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15)) & "  " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 16, 50)) & STR_PRD_CAD
                        '& " Bodega: " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15)) &
                    End If
                Else
                    If opr_movimiento.ProductoCaducado(Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15))) Then
                        STR_PRD_CAD = Chr(13) & Space(10) & " * " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15)) & "  " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 16, 50)) & STR_PRD_CAD
                        '& " Bodega: " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15)) &
                    End If
                End If
                
            Else
                If IsDBNull(dtt_tabla.Rows(int_indice).Item(7)) Then
                    'dtt_tabla.Rows(int_indice).Item(7) = ""
                    ''MsgBox("Este producto es perecible; ingrese la fecha de Caducidad.", MsgBoxStyle.Exclamation, "ANALISYS")
                    opr_negocio.VisualizaMensaje("Este producto es perecible; ingrese la fecha de Caducidad", g_tiempo)
                    Exit Sub
                ElseIf IsDate(Trim(dtt_tabla.Rows(int_indice).Item(7))) Then
                    If dtp_fecha_mov.Value >= Trim(dtt_tabla.Rows(int_indice).Item(7)) Then
                        STR_PRD_CAD = Chr(13) & Space(10) & " * " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15)) & "  " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 16, 50)) & STR_PRD_CAD
                    End If
                End If
            End If
        Next

        If STR_PRD_STOCK <> "" And Me.Tag = 1 Then

            '''MsgBox("La cantidad solicitada es mayor al stock disponible," & Chr(13) & "favor revice la cantidad del PRODUCTO: " & STR_PRD_STOCK & "Operaci�n Interrumpida", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("La cantidad solicitada es mayor al stock disponible," & Chr(13) & "favor revice la cantidad del PRODUCTO: " & STR_PRD_STOCK & "Operaci�n Interrumpida", g_tiempo)
            Exit Sub
        End If

        'If STR_PRD_CAD <> "" Then
        '    STR_MSG = "Los siguientes productos del detalle se encuentran CADUCADOS: " & STR_PRD_CAD
        '    If MsgBox(STR_MSG & Chr(13) & Chr(13) & "Desea Continuar con la operacion?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.No Then Exit Sub
        'End If

        If Me.Tag = 1 Then
            boo_opera = True
            'se advierte que el ingreso o egreso de productos con fecha del anterior mes
            If DatePart(DateInterval.Month, dtp_fecha_mov.Value) <> DatePart(DateInterval.Month, Now) Then
                If MsgBox("Advertencia!!, La fecha del movimiento es referente a un mes diferente al actual, " & Chr(13) & "󡡿Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "ANALISYS") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If

        '
        Dim mov_estado As Short = 1
        If Trim(Mid(cmb_tipomov.Text, 1, 15)) = "NPD" Then
            mov_estado = 2
        End If

        If opr_movimiento.OperaMovimiento(boo_opera, dtp_fecha_mov.Value, dtp_fecha_doc.Value, ctl_txt_doc.texto_Recupera, Mid(cmb_proveedor.Text, 1, 15), _
        cmb_tipomov.Text, Ctl_txt_autoriza.texto_Recupera, dtt_tabla, Trim(txt_Entregado.texto_Recupera), Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), Ctl_txt_nummov.texto_Recupera, boo_modDetalle, Ctl_txt_nummov2.texto_Recupera, mov_estado) = 1 Then
            If (Mid(cmb_tipomov.Text, 1, 3) = "EGR") Then
                If MsgBox("Desea imprimir el comprobante de movimiento?", MsgBoxStyle.YesNo, "ANALISYSLAB") = MsgBoxResult.Yes Then
                    btn_impComp.PerformClick()
                End If

            End If

            If numpedido <> "" Then
                opr_movimiento.cambionumpedido(docpedido, ctl_txt_doc.texto_Recupera, numpedido)
                numpedido = ""
            End If
            limpia()
            txt_descripcion.Text = ""
            If Me.Tag = 1 Then
                Ctl_txt_nummov.texto_Asigna(opr_movimiento.LeerMaxMovimiento() + 1)
            Else
                Ctl_txt_nummov.texto_Asigna("")
            End If
            Ctl_txt_nummov.txt_padre.Focus()
        End If
    End Sub
#End Region

#Region "Recupera Movimiento"

    Sub Recupera_movimiento(ByVal NumMov As Long)
        Dim int_estado, estado As Single
        Dim int_indice, int_cont As Short
        Dim dts_movimiento As New DataSet()
        Dim dtr_operacion As DataRow
        Dim str_tipomov As String

        limpia()
        txt_descripcion.Text = ""
        int_cont = 0
        estado = opr_movimiento.ExisteMovimiento(NumMov, int_estado)
        If estado = 1 Or estado = 0 Or estado = 2 Then
            grp_datos.Enabled = True
            btn_anular.Enabled = True
            dgrd_movimiento.ReadOnly = False
            dgrd_movimiento.Enabled = True
            dts_movimiento = opr_movimiento.leerMovimiento(NumMov)

            If Me.Tag = 1 Then
                If opr_movimiento.leerMovimientoDev(NumMov) Then
                    'Si el movimiento ya posee una devolucin no se puede volver a realizar otra devoluci�n
                    '''MsgBox("Devoluci�n Existente para este movimiento, Operaci�n cancelada", MsgBoxStyle.Exclamation, "ANALISYS")
                    opr_negocio.VisualizaMensaje("Devoluci�n Existente para este movimiento, Operaci�n cancelada", g_tiempo)
                    Exit Sub
                End If
            End If

            If dts_movimiento.Tables(0).Rows.Count > 0 Then
                dtr_operacion = dts_movimiento.Tables(0).Rows(0)
                If Not IsDBNull(dtr_operacion(9)) Then
                    If Me.Tag = 1 Then
                        If Ctl_txt_nummov2.texto_Recupera = "" Then
                            pan_devmov.Enabled = False
                            cmb_tipomov.SelectedIndex = 0
                        Else
                            'Validamos que el movimiento este de acuerdo con el tipo seleccionado
                            str_tipomov = Trim(cmb_tipomov.Items.Item(UbicaCombo(dtr_operacion(5).ToString().PadRight(15), cmb_tipomov)).Substring(42, 10))
                            If str_tipomov = Trim(cmb_tipomov.Text.Substring(42, 10)) Then
                                If str_tipomov = "EGRESO" Then
                                    ''MsgBox("El movimiento " & Ctl_txt_nummov2.texto_Recupera & " es EGRESO, debe seleccionar Devoluci�n de Egresos(tipo de movimiento)" & Chr(13) & "Operaci�n Cancelada", MsgBoxStyle.Exclamation, "ANALISYS")
                                    opr_negocio.VisualizaMensaje("El movimiento " & Ctl_txt_nummov2.texto_Recupera & " es EGRESO, debe seleccionar Devoluci�n de Egresos(tipo de movimiento)" & Chr(13) & "Operaci�n Cancelada", g_tiempo)
                                Else
                                    '''MsgBox("El movimiento " & Ctl_txt_nummov2.texto_Recupera & " es INGRESO, debe seleccionar Devoluci�n de Ingresos(tipo de movimiento)" & Chr(13) & "Operaci�n Cancelada", MsgBoxStyle.Exclamation, "ANALISYS")
                                    opr_negocio.VisualizaMensaje("El movimiento " & Ctl_txt_nummov2.texto_Recupera & " es INGRESO, debe seleccionar Devoluci�n de Ingresos(tipo de movimiento)" & Chr(13) & "Operaci�n Cancelada", g_tiempo)
                                End If
                                Ctl_txt_nummov2.texto_Asigna("")
                                limpia()
                                txt_descripcion.Text = ""
                                Exit Sub
                            End If
                        End If
                    Else
                        dtp_fecha_mov.Value = dtr_operacion(1).ToString
                        dtp_fecha_doc.Value = dtr_operacion(2).ToString
                        ctl_txt_doc.texto_Asigna(dtr_operacion(3).ToString)
                        Ctl_txt_nummov2.texto_Asigna(dtr_operacion(17).ToString)
                        Ctl_txt_autoriza.texto_Asigna(dtr_operacion(7).ToString)
                        cmb_tipomov.SelectedIndex = UbicaCombo(dtr_operacion(5).ToString().PadRight(15), cmb_tipomov)

                        txt_Entregado.texto_Asigna(dtr_operacion(20).ToString)
                    End If
                    cmb_proveedor.SelectedIndex = UbicaCombo(dtr_operacion(4).ToString().PadRight(15), cmb_proveedor)
                    Dim opr_producto As New Cls_i_Producto()
                    Dim arr_fila(11) As String
                    For int_indice = 0 To dts_movimiento.Tables(0).Rows.Count - 1
                        dtr_operacion = dts_movimiento.Tables(0).Rows(int_indice)
                        '0 --> id de detalle movimiento
                        arr_fila(0) = dtr_operacion(8).ToString()
                        '1 --> producto
                        arr_fila(1) = opr_producto.ConsultaProductoEspecificoGrid(dtr_operacion(9).ToString().PadRight(15))
                        '2 --> bodega
                        arr_fila(2) = cmb_bodega.GetItemText(cmb_bodega.Items.Item(UbicaCombo(dtr_operacion(12).ToString().PadRight(15), cmb_bodega)))
                        '3 --> lote
                        arr_fila(3) = dtr_operacion(18).ToString()
                        '4 --> descripci�n del movimiento
                        arr_fila(4) = dtr_operacion(14).ToString()
                        '5 --> cantidad
                        arr_fila(5) = Math.Abs(CDbl(dtr_operacion(10).ToString()))
                        '6 --> costo
                        arr_fila(6) = 0
                        '7 --> fecha de vcto. del producto ingresado
                        If Trim(dtr_operacion(13).ToString()) = "" Then
                            arr_fila(7) = "NP"
                        Else
                            arr_fila(7) = Format(CDate(dtr_operacion(13).ToString()), "dd/MM/yyyy")
                        End If
                        If Me.Tag = 2 Then
                            'verifica si existen movimientos posteriores a este producto
                            arr_fila(8) = False
                            If opr_movimiento.MovimientoPosterior(NumMov, dtr_operacion(12), dtr_operacion(9)) Then
                                int_cont = int_cont + 1
                                arr_fila(8) = True
                            End If
                        End If

                        Dim dts_movimiento1 As New DataSet()
                        Dim dtr_operacion1 As DataRow
                        dts_movimiento1 = opr_movimiento.leerbodega(Trim(dtr_operacion(9).ToString().PadRight(15)), arr_fila(3))
                        dtr_operacion1 = dts_movimiento1.Tables(0).Rows(0)
                        arr_fila(11) = dtr_operacion1(1).ToString().PadRight(15)
                        arr_fila(9) = arr_fila(5)
                        arr_fila(10) = Trim(Mid(arr_fila(1), 89))
                        dtt_tabla.Rows.Add(arr_fila)
                    Next

                    If Me.Tag = 1 Then
                        cmb_tipomov.Enabled = True
                    Else
                        If estado = 0 Then
                            '''MsgBox("El movimiento se encuentra Anulado", MsgBoxStyle.Exclamation, "ANALISYS")
                            opr_negocio.VisualizaMensaje("El movimiento se encuentra Anulado", g_tiempo)
                            dgrd_movimiento.ReadOnly = True
                            dgrd_movimiento.Enabled = False
                            grp_datos.Enabled = False
                            boo_modDetalle = False
                            btn_anular.Enabled = False
                        ElseIf estado = 2 Then
                            '''MsgBox("El movimiento fue una nota de pedido ya Facturada.", MsgBoxStyle.Exclamation, "ANALISYS")
                            opr_negocio.VisualizaMensaje("El movimiento fue una nota de pedido ya Facturada", g_tiempo)
                            dgrd_movimiento.ReadOnly = True
                            dgrd_movimiento.Enabled = False
                            grp_datos.Enabled = False
                            boo_modDetalle = False
                            btn_anular.Enabled = False
                        ElseIf int_cont >= 1 Then
                            'Significa que el producto posee movimientos posteriores
                            '''MsgBox("Este producto posee movimientos posteriores." & Chr(13) & "Debe realizar operaci�n que deshaga los cambios realizados.", MsgBoxStyle.Exclamation, "ANALISYS")
                            opr_negocio.VisualizaMensaje("Este producto posee movimientos posteriores." & Chr(13) & "Debe realizar operaci�n que deshaga los cambios realizados", g_tiempo)
                            'MsgBox("Los productos de este movimiento, poseen registros posteriores." & Chr(13) & "Debe realizar operaci�n que deshaga los cambios realizados.", MsgBoxStyle.Exclamation, "ANALISYS")
                            'dgrd_movimiento.ReadOnly = True
                            'dgrd_movimiento.Enabled = False
                            'grp_datos.Enabled = False
                            'boo_modDetalle = False
                        End If
                    End If
                End If
                If Trim(Mid(cmb_tipomov.Text, 1, 15)) = "EGR" Then
                    chk_npedido.Enabled = True
                Else
                    chk_npedido.Enabled = False
                    chk_npedido.Checked = False
                End If
                ' ESTA PARTE ES PARA QUE NO SE MODIFIQUEN FACTURAS DE MESES ANTERIORES:
                'If DatePart(DateInterval.Month, dtp_fecha_mov.Value) <> DatePart(DateInterval.Month, Now) Then
                '    MsgBox("Advertencia!!, La fecha del movimiento es referente a un mes diferente al actual. ", MsgBoxStyle.Exclamation, "ANALISYS")
                '    dgrd_movimiento.ReadOnly = True
                '    dgrd_movimiento.Enabled = False
                '    grp_datos.Enabled = False
                '    boo_modDetalle = False
                '    'Exit Sub
                'End If
            Else
                '''MsgBox("El movimiento se�alado no posee registros", MsgBoxStyle.Exclamation, "ANALISYS")
                opr_negocio.VisualizaMensaje("El movimiento se�alado no posee registros", g_tiempo)
                Ctl_txt_nummov.Focus()
            End If

        Else
            dgrd_movimiento.ReadOnly = True
            dgrd_movimiento.Enabled = False
            btn_anular.Enabled = False
            If estado = 3 Then
                opr_negocio.VisualizaMensaje("Este movimiento pertenece a otra division", g_tiempo)
            Else
                opr_negocio.VisualizaMensaje("El Numero de movimiento NO EXISTE", g_tiempo)
            End If

            Ctl_txt_nummov.Focus()
            Ctl_txt_nummov.texto_Asigna("")
            Ctl_txt_nummov2.texto_Asigna("")
        End If

    End Sub

#End Region

    Private Sub print_PrintPage(ByVal sender As Object, _
                            ByVal e As PrintPageEventArgs)

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 10, FontStyle.Regular)
        ' la posicion superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        ' imprimimos la cadena
        e.Graphics.DrawString(comprobante, prFont, Brushes.Black, xPos, yPos)
        ' indicamos que ya no hay nada mas que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Not ExisteForm("frm_Busq_Pedidos") Then
            Dim frm_MDIChild As New frm_i_movReporte()
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.ShowDialog(Me.ParentForm)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.ParentForm.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function

#Region "Anular"
    'JVA 01/10/2003
    Private Sub btn_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_anular.Click
        Dim str_prd_stock As String
        Dim dbl_cantidad As Double
        Dim int_indice As Short
        Me.Cursor = Cursors.WaitCursor

        If Trim(cmb_tipomov.Text.Substring(42, 10)) <> "EGRESO" Then
            For int_indice = 0 To dtt_tabla.Rows.Count - 1
                'dbl_cantidad = opr_movimiento.ProductoBodega(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(3), 1, 15)) - dtt_tabla.Rows(int_indice).Item(5)
                dbl_cantidad = opr_movimiento.ProductoBodega(Mid(dtt_tabla.Rows(int_indice).Item(2), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15), Mid(dtt_tabla.Rows(int_indice).Item(3), 1, 15), dtt_tabla.Rows(int_indice).Item(5), 0)
                If dbl_cantidad < 0 Then
                    str_prd_stock = Chr(13) & Space(10) & " * " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 1, 15)) & " " & Trim(Mid(dtt_tabla.Rows(int_indice).Item(1), 16, 50)) & str_prd_stock
                End If
            Next
        End If

        If str_prd_stock <> "" Then
            MsgBox("Si Anula este movimiento, los Productos: " & str_prd_stock & Chr(13) & Chr(13) & "quedar�an con stock negativo, revisar existencia de productos." & Chr(13) & "Operaci�n Interrumpida", MsgBoxStyle.Exclamation, "ANALISYS")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If MsgBox("Esta seguro de anular el movimiento " & Ctl_txt_nummov.texto_Recupera & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            If Ctl_txt_nummov.texto_Recupera <> "" Then
                opr_movimiento.Anularmovimiento(Ctl_txt_nummov.texto_Recupera)
            Else
                MsgBox("No existe movimiento para anular", MsgBoxStyle.Information, "ANALISYS")
            End If
            Ctl_txt_nummov.texto_Asigna("")
            limpia()
            txt_descripcion.Text = ""
            Ctl_txt_nummov.txt_padre.Focus()
        End If
        Me.Cursor = Cursors.Default
    End Sub
#End Region

    Private Sub txt_descripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_descripcion.TextChanged
        On Error Resume Next
        Dim sht_posicion As Short = txt_descripcion.SelectionStart()
        txt_descripcion.SelectionStart() = Len(txt_descripcion.Text)
        txt_descripcion.Text = UCase(txt_descripcion.Text)
        txt_descripcion.SelectionStart = sht_posicion
    End Sub

    Private Sub btn_npedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_npedido.Click
        Me.Cursor = Cursors.WaitCursor
        'Dim FrM_MDIChild As New frm_busqnotapedido()
        ''Dim FrM_MDIChild As New frm_i_notapedido()
        'FrM_MDIChild.frm_refer_main = frm_refer_main_form
        'FrM_MDIChild.Tag = Me.Name
        'FrM_MDIChild.Show()
        ''FrM_MDIChild.ShowDialog(frm_refer_main_form)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub chk_npedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_npedido.CheckedChanged
        If chk_npedido.Checked = True Then
            btn_npedido.Enabled = True
        Else
            btn_npedido.Enabled = False
        End If
    End Sub


    Private Sub btn_impComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_impComp.Click
        If MsgBox("Desea imprimir el comprobante ?", MsgBoxStyle.YesNo, "LUMINO") <> MsgBoxResult.No Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim str_sql As String
            Dim obj_reporte As New rpt_I_Comprobate()
            str_sql = "select i_movimiento.I_MOV_ID,  i_movimiento.I_MOV_FECING, i_movimiento.I_MOV_FECMOV, i_movimiento.I_MOV_FECDOC, i_movimiento.I_MOV_RESPONSABLE, (invitado.invitado_nombre + ' ' + invitado.invitado_apellido ) as usuario,  i_movimiento.I_MOV_ENTREGADO, i_movimiento_detalle.I_PRD_ID, i_producto.I_PRD_DESCRIPCION,    i_movimiento_detalle.I_MOD_CANTIDAD " & _
            "from i_movimiento, invitado, i_movimiento_detalle, i_producto " & _
            "where i_movimiento.I_MOV_ID = " & CInt(Ctl_txt_nummov.texto_Recupera()) & " And i_movimiento.I_MOV_ESTADO = 1 And i_movimiento_detalle.I_MOV_ID = i_movimiento.I_MOV_ID And i_producto.I_PRD_ID = i_movimiento_detalle.I_PRD_ID And i_movimiento.invitado_id = invitado.invitado_id"

            'Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , True, 0)
            Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , True, 0)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Comprobante"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    '    Private Sub dgv_InvDetalle_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '        Dim dtr_fila As DataRow
    '        Dim opr_bodega As New Cls_i_Bodega()
    '        If e.ColumnIndex = 2 Then
    '            ' Aquí puedes cargar los datos en el ComboBox
    '            ' Por ejemplo, si los datos están en un DataTable llamado "tablaDatos" y la columna se llama "Nombre", puedes hacer lo siguiente:

    '            Dim comboBoxColumn As DataGridViewComboBoxColumn = CType(dgv_InvDetalle.Columns(e.ColumnIndex), DataGridViewComboBoxColumn)

    '            ' Limpia el ComboBox antes de cargar los nuevos datos
    '            comboBoxColumn.Items.Clear()

    '            ' Llena el ComboBox con los datos del DataTable

    '            For Each dtr_fila In opr_bodega.LeerBodega(g_division).Tables(0).Rows
    '                comboBoxColumn.Items.Add(dtr_fila("I_BOD_ID").ToString().PadRight(15) & " " & Mid(dtr_fila("I_BOD_DESCRIPCION").ToString(), 1, 25).PadRight(20))
    '            Next

    '            'For Each row As DataRow In tablaDatos.Rows
    '            '    comboBoxColumn.Items.Add(row("Nombre").ToString())
    '            'Next
    '        End If
    '    End Sub
End Class



