Imports System
Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_i_Productos
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
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_productos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_desc As System.Windows.Forms.Label
    Friend WithEvents lbl_exist_max As System.Windows.Forms.Label
    Friend WithEvents lbl_moc_id As System.Windows.Forms.Label
    Friend WithEvents lbl_existencia As System.Windows.Forms.Label
    Friend WithEvents cmb_unidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_MConservacion As System.Windows.Forms.ComboBox
    Friend WithEvents Ctl_txt_ex_max As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_ex_min As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_id As Ctl_txt.ctl_txt_letras
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents dgrd_Productos As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_perecible As System.Windows.Forms.Label
    Friend WithEvents cmb_perecible As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_reportes As System.Windows.Forms.Button
    Friend WithEvents rbtn_nombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_codigo As System.Windows.Forms.RadioButton
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents cmb_div As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_cplazo As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_lplazo As Ctl_txt.ctl_txt_numeros
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Area As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Frascos As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmb_serie As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_Presentacion As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txt_Abrev As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_Productos))
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.grp_productos = New System.Windows.Forms.GroupBox
        Me.cmb_Presentacion = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_serie = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_Frascos = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_Area = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_lplazo = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_cplazo = New Ctl_txt.ctl_txt_numeros
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_perecible = New System.Windows.Forms.ComboBox
        Me.lbl_perecible = New System.Windows.Forms.Label
        Me.txt_desc = New System.Windows.Forms.TextBox
        Me.lbl_existencia = New System.Windows.Forms.Label
        Me.Ctl_txt_ex_max = New Ctl_txt.ctl_txt_numeros
        Me.cmb_MConservacion = New System.Windows.Forms.ComboBox
        Me.cmb_unidad = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_ex_min = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_id = New Ctl_txt.ctl_txt_letras
        Me.lbl_id = New System.Windows.Forms.Label
        Me.lbl_desc = New System.Windows.Forms.Label
        Me.lbl_exist_max = New System.Windows.Forms.Label
        Me.lbl_moc_id = New System.Windows.Forms.Label
        Me.cmb_div = New System.Windows.Forms.ComboBox
        Me.dgrd_Productos = New System.Windows.Forms.DataGrid
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
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_reportes = New System.Windows.Forms.Button
        Me.rbtn_nombre = New System.Windows.Forms.RadioButton
        Me.rbtn_codigo = New System.Windows.Forms.RadioButton
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Abrev = New System.Windows.Forms.TextBox
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.grp_productos.SuspendLayout()
        CType(Me.dgrd_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(12, 21)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(68, 33)
        Me.btn_Nuevo.TabIndex = 2
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(248, 21)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(70, 33)
        Me.btn_Salir.TabIndex = 6
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(164, 21)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(78, 33)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(86, 21)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(72, 33)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'grp_productos
        '
        Me.grp_productos.BackColor = System.Drawing.Color.Transparent
        Me.grp_productos.Controls.Add(Me.Ctl_txt_id)
        Me.grp_productos.Controls.Add(Me.txt_Abrev)
        Me.grp_productos.Controls.Add(Me.Label7)
        Me.grp_productos.Controls.Add(Me.cmb_Presentacion)
        Me.grp_productos.Controls.Add(Me.Label6)
        Me.grp_productos.Controls.Add(Me.cmb_serie)
        Me.grp_productos.Controls.Add(Me.Label5)
        Me.grp_productos.Controls.Add(Me.cmb_Frascos)
        Me.grp_productos.Controls.Add(Me.Label1)
        Me.grp_productos.Controls.Add(Me.Label4)
        Me.grp_productos.Controls.Add(Me.cmb_Area)
        Me.grp_productos.Controls.Add(Me.Ctl_txt_lplazo)
        Me.grp_productos.Controls.Add(Me.Ctl_txt_cplazo)
        Me.grp_productos.Controls.Add(Me.Label3)
        Me.grp_productos.Controls.Add(Me.Label2)
        Me.grp_productos.Controls.Add(Me.cmb_perecible)
        Me.grp_productos.Controls.Add(Me.lbl_perecible)
        Me.grp_productos.Controls.Add(Me.txt_desc)
        Me.grp_productos.Controls.Add(Me.lbl_existencia)
        Me.grp_productos.Controls.Add(Me.Ctl_txt_ex_max)
        Me.grp_productos.Controls.Add(Me.cmb_MConservacion)
        Me.grp_productos.Controls.Add(Me.cmb_unidad)
        Me.grp_productos.Controls.Add(Me.Ctl_txt_ex_min)
        Me.grp_productos.Controls.Add(Me.lbl_id)
        Me.grp_productos.Controls.Add(Me.lbl_desc)
        Me.grp_productos.Controls.Add(Me.lbl_exist_max)
        Me.grp_productos.Controls.Add(Me.lbl_moc_id)
        Me.grp_productos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_productos.ForeColor = System.Drawing.Color.Navy
        Me.grp_productos.Location = New System.Drawing.Point(12, 60)
        Me.grp_productos.Name = "grp_productos"
        Me.grp_productos.Size = New System.Drawing.Size(602, 209)
        Me.grp_productos.TabIndex = 0
        Me.grp_productos.TabStop = False
        '
        'cmb_Presentacion
        '
        Me.cmb_Presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Presentacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Presentacion.Location = New System.Drawing.Point(381, 98)
        Me.cmb_Presentacion.Name = "cmb_Presentacion"
        Me.cmb_Presentacion.Size = New System.Drawing.Size(116, 21)
        Me.cmb_Presentacion.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(279, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "PRESENTACION"
        '
        'cmb_serie
        '
        Me.cmb_serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_serie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_serie.Location = New System.Drawing.Point(140, 70)
        Me.cmb_serie.Name = "cmb_serie"
        Me.cmb_serie.Size = New System.Drawing.Size(313, 21)
        Me.cmb_serie.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "SERIE"
        '
        'cmb_Frascos
        '
        Me.cmb_Frascos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Frascos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Frascos.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmb_Frascos.Location = New System.Drawing.Point(503, 124)
        Me.cmb_Frascos.Name = "cmb_Frascos"
        Me.cmb_Frascos.Size = New System.Drawing.Size(93, 21)
        Me.cmb_Frascos.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(421, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "# FRASCOS"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "AREA"
        '
        'cmb_Area
        '
        Me.cmb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Area.Location = New System.Drawing.Point(140, 17)
        Me.cmb_Area.Name = "cmb_Area"
        Me.cmb_Area.Size = New System.Drawing.Size(166, 21)
        Me.cmb_Area.TabIndex = 1
        '
        'Ctl_txt_lplazo
        '
        Me.Ctl_txt_lplazo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_lplazo.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_lplazo.Location = New System.Drawing.Point(278, 176)
        Me.Ctl_txt_lplazo.Name = "Ctl_txt_lplazo"
        Me.Ctl_txt_lplazo.Prp_Formato = True
        Me.Ctl_txt_lplazo.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_lplazo.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.Ctl_txt_lplazo.Prp_ValDefault = "180"
        Me.Ctl_txt_lplazo.Size = New System.Drawing.Size(50, 21)
        Me.Ctl_txt_lplazo.TabIndex = 12
        '
        'Ctl_txt_cplazo
        '
        Me.Ctl_txt_cplazo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_cplazo.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_cplazo.Location = New System.Drawing.Point(141, 174)
        Me.Ctl_txt_cplazo.Name = "Ctl_txt_cplazo"
        Me.Ctl_txt_cplazo.Prp_Formato = True
        Me.Ctl_txt_cplazo.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_cplazo.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.Ctl_txt_cplazo.Prp_ValDefault = "90"
        Me.Ctl_txt_cplazo.Size = New System.Drawing.Size(50, 21)
        Me.Ctl_txt_cplazo.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(197, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Largo Plazo:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Caducidad en días"
        '
        'cmb_perecible
        '
        Me.cmb_perecible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_perecible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_perecible.Items.AddRange(New Object() {"No", "Si"})
        Me.cmb_perecible.Location = New System.Drawing.Point(141, 98)
        Me.cmb_perecible.Name = "cmb_perecible"
        Me.cmb_perecible.Size = New System.Drawing.Size(130, 21)
        Me.cmb_perecible.TabIndex = 5
        '
        'lbl_perecible
        '
        Me.lbl_perecible.BackColor = System.Drawing.Color.Transparent
        Me.lbl_perecible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_perecible.ForeColor = System.Drawing.Color.Black
        Me.lbl_perecible.Location = New System.Drawing.Point(23, 103)
        Me.lbl_perecible.Name = "lbl_perecible"
        Me.lbl_perecible.Size = New System.Drawing.Size(72, 16)
        Me.lbl_perecible.TabIndex = 48
        Me.lbl_perecible.Text = "PERECIBLE"
        '
        'txt_desc
        '
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(140, 44)
        Me.txt_desc.MaxLength = 150
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(313, 20)
        Me.txt_desc.TabIndex = 3
        '
        'lbl_existencia
        '
        Me.lbl_existencia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_existencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_existencia.ForeColor = System.Drawing.Color.Black
        Me.lbl_existencia.Location = New System.Drawing.Point(23, 154)
        Me.lbl_existencia.Name = "lbl_existencia"
        Me.lbl_existencia.Size = New System.Drawing.Size(116, 17)
        Me.lbl_existencia.TabIndex = 47
        Me.lbl_existencia.Text = "Existencia Mínima"
        '
        'Ctl_txt_ex_max
        '
        Me.Ctl_txt_ex_max.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_ex_max.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_ex_max.Location = New System.Drawing.Point(278, 150)
        Me.Ctl_txt_ex_max.Name = "Ctl_txt_ex_max"
        Me.Ctl_txt_ex_max.Prp_Formato = True
        Me.Ctl_txt_ex_max.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_ex_max.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_ex_max.Prp_ValDefault = "0"
        Me.Ctl_txt_ex_max.Size = New System.Drawing.Size(50, 21)
        Me.Ctl_txt_ex_max.TabIndex = 10
        '
        'cmb_MConservacion
        '
        Me.cmb_MConservacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MConservacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_MConservacion.Location = New System.Drawing.Point(141, 125)
        Me.cmb_MConservacion.Name = "cmb_MConservacion"
        Me.cmb_MConservacion.Size = New System.Drawing.Size(130, 21)
        Me.cmb_MConservacion.TabIndex = 7
        '
        'cmb_unidad
        '
        Me.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_unidad.Location = New System.Drawing.Point(503, 98)
        Me.cmb_unidad.Name = "cmb_unidad"
        Me.cmb_unidad.Size = New System.Drawing.Size(93, 21)
        Me.cmb_unidad.TabIndex = 6
        '
        'Ctl_txt_ex_min
        '
        Me.Ctl_txt_ex_min.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_ex_min.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_ex_min.Location = New System.Drawing.Point(141, 150)
        Me.Ctl_txt_ex_min.Name = "Ctl_txt_ex_min"
        Me.Ctl_txt_ex_min.Prp_Formato = True
        Me.Ctl_txt_ex_min.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_ex_min.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_ex_min.Prp_ValDefault = "0"
        Me.Ctl_txt_ex_min.Size = New System.Drawing.Size(50, 21)
        Me.Ctl_txt_ex_min.TabIndex = 9
        '
        'Ctl_txt_id
        '
        Me.Ctl_txt_id.Enabled = False
        Me.Ctl_txt_id.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_id.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_id.Location = New System.Drawing.Point(551, 16)
        Me.Ctl_txt_id.Name = "Ctl_txt_id"
        Me.Ctl_txt_id.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_id.Prp_CaracterPasswd = ""
        Me.Ctl_txt_id.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_id.Size = New System.Drawing.Size(45, 21)
        Me.Ctl_txt_id.TabIndex = 2
        '
        'lbl_id
        '
        Me.lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_id.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_id.Location = New System.Drawing.Point(527, 20)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(30, 16)
        Me.lbl_id.TabIndex = 34
        Me.lbl_id.Text = "ID"
        '
        'lbl_desc
        '
        Me.lbl_desc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.ForeColor = System.Drawing.Color.Black
        Me.lbl_desc.Location = New System.Drawing.Point(22, 48)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(96, 16)
        Me.lbl_desc.TabIndex = 35
        Me.lbl_desc.Text = "DESCRIPCION"
        '
        'lbl_exist_max
        '
        Me.lbl_exist_max.BackColor = System.Drawing.Color.Transparent
        Me.lbl_exist_max.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_exist_max.ForeColor = System.Drawing.Color.Black
        Me.lbl_exist_max.Location = New System.Drawing.Point(215, 155)
        Me.lbl_exist_max.Name = "lbl_exist_max"
        Me.lbl_exist_max.Size = New System.Drawing.Size(52, 16)
        Me.lbl_exist_max.TabIndex = 37
        Me.lbl_exist_max.Text = "Máxima:"
        '
        'lbl_moc_id
        '
        Me.lbl_moc_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_moc_id.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_moc_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_moc_id.Location = New System.Drawing.Point(23, 129)
        Me.lbl_moc_id.Name = "lbl_moc_id"
        Me.lbl_moc_id.Size = New System.Drawing.Size(114, 16)
        Me.lbl_moc_id.TabIndex = 39
        Me.lbl_moc_id.Text = "CONSERVACION"
        '
        'cmb_div
        '
        Me.cmb_div.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_div.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_div.Location = New System.Drawing.Point(321, 373)
        Me.cmb_div.Name = "cmb_div"
        Me.cmb_div.Size = New System.Drawing.Size(124, 21)
        Me.cmb_div.TabIndex = 1
        '
        'dgrd_Productos
        '
        Me.dgrd_Productos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Productos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Productos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Productos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Productos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Productos.CaptionText = "PRODUCTOS"
        Me.dgrd_Productos.DataMember = ""
        Me.dgrd_Productos.FlatMode = True
        Me.dgrd_Productos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_Productos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Productos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Productos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Productos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Productos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Productos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Productos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Productos.Location = New System.Drawing.Point(12, 315)
        Me.dgrd_Productos.Name = "dgrd_Productos"
        Me.dgrd_Productos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Productos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Productos.ReadOnly = True
        Me.dgrd_Productos.RowHeaderWidth = 10
        Me.dgrd_Productos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Productos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Productos.Size = New System.Drawing.Size(602, 204)
        Me.dgrd_Productos.TabIndex = 1
        Me.dgrd_Productos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Productos.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Productos
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridBoolColumn1, Me.DataGridBoolColumn2, Me.DataGridBoolColumn3, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.RowHeaderWidth = 10
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "i_prd_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.MappingName = "i_prd_descripcion"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 350
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "STOCK MIN."
        Me.DataGridTextBoxColumn3.MappingName = "i_prd_exist_min"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "STOCK MAX."
        Me.DataGridTextBoxColumn4.MappingName = "i_prd_exist_max"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "UNIDAD"
        Me.DataGridTextBoxColumn5.MappingName = "I_UNI_ID"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "MOD. CONSERV"
        Me.DataGridTextBoxColumn6.MappingName = "i_moc_id"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "PERECIBLE"
        Me.DataGridTextBoxColumn7.MappingName = "i_prd_perecible"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "caduc"
        Me.DataGridTextBoxColumn8.MappingName = "i_prd_caduc"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "porcaduc"
        Me.DataGridTextBoxColumn9.MappingName = "i_prd_porcaduc"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "AREA"
        Me.DataGridTextBoxColumn10.MappingName = "I_AID"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.HeaderText = "FSCO 1"
        Me.DataGridBoolColumn1.MappingName = "FSCO_1"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.Width = 0
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.HeaderText = "FSCO 2"
        Me.DataGridBoolColumn2.MappingName = "FSCO_2"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.Width = 0
        '
        'DataGridBoolColumn3
        '
        Me.DataGridBoolColumn3.HeaderText = "FSCO 3"
        Me.DataGridBoolColumn3.MappingName = "FSCO_3"
        Me.DataGridBoolColumn3.NullText = ""
        Me.DataGridBoolColumn3.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "FRASCOS"
        Me.DataGridTextBoxColumn11.MappingName = "I_PRD_FRASCOS"
        Me.DataGridTextBoxColumn11.Width = 60
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "SERIE"
        Me.DataGridTextBoxColumn12.MappingName = "SER_ID"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "PRESENTACION"
        Me.DataGridTextBoxColumn13.MappingName = "PRES_ID"
        Me.DataGridTextBoxColumn13.NullText = "0"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reportes.ForeColor = System.Drawing.Color.Black
        Me.btn_reportes.Image = CType(resources.GetObject("btn_reportes.Image"), System.Drawing.Image)
        Me.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reportes.Location = New System.Drawing.Point(538, 21)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(70, 33)
        Me.btn_reportes.TabIndex = 5
        Me.btn_reportes.Text = "Imprimir"
        Me.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reportes.UseVisualStyleBackColor = False
        Me.btn_reportes.Visible = False
        '
        'rbtn_nombre
        '
        Me.rbtn_nombre.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_nombre.Checked = True
        Me.rbtn_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_nombre.Location = New System.Drawing.Point(17, 289)
        Me.rbtn_nombre.Name = "rbtn_nombre"
        Me.rbtn_nombre.Size = New System.Drawing.Size(69, 18)
        Me.rbtn_nombre.TabIndex = 93
        Me.rbtn_nombre.TabStop = True
        Me.rbtn_nombre.Text = "Nombre"
        Me.rbtn_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_nombre.UseVisualStyleBackColor = False
        '
        'rbtn_codigo
        '
        Me.rbtn_codigo.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_codigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_codigo.Location = New System.Drawing.Point(86, 289)
        Me.rbtn_codigo.Name = "rbtn_codigo"
        Me.rbtn_codigo.Size = New System.Drawing.Size(65, 18)
        Me.rbtn_codigo.TabIndex = 94
        Me.rbtn_codigo.Text = "Código"
        Me.rbtn_codigo.UseVisualStyleBackColor = False
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Location = New System.Drawing.Point(153, 288)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(461, 21)
        Me.txt_filtro.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(317, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "CODIGO"
        '
        'txt_Abrev
        '
        Me.txt_Abrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Abrev.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Abrev.Location = New System.Drawing.Point(372, 17)
        Me.txt_Abrev.MaxLength = 150
        Me.txt_Abrev.Multiline = True
        Me.txt_Abrev.Name = "txt_Abrev"
        Me.txt_Abrev.Size = New System.Drawing.Size(81, 20)
        Me.txt_Abrev.TabIndex = 64
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn14.MappingName = "I_PRD_ABREV"
        Me.DataGridTextBoxColumn14.Width = 80
        '
        'frm_i_Productos
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(626, 540)
        Me.Controls.Add(Me.btn_reportes)
        Me.Controls.Add(Me.dgrd_Productos)
        Me.Controls.Add(Me.grp_productos)
        Me.Controls.Add(Me.cmb_div)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.rbtn_nombre)
        Me.Controls.Add(Me.rbtn_codigo)
        Me.Controls.Add(Me.txt_filtro)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_i_Productos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.grp_productos.ResumeLayout(False)
        Me.grp_productos.PerformLayout()
        CType(Me.dgrd_Productos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim opr_negocio As New Cls_Pedido()


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

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Salir.MouseEnter, btn_Eliminar.MouseEnter, btn_Nuevo.MouseEnter, btn_reportes.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Salir.MouseLeave, btn_Eliminar.MouseLeave, btn_Nuevo.MouseLeave, btn_reportes.MouseLeave
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

    Dim opr_i_producto As New Cls_i_Producto()
    Dim opr_i_modConserv As New Cls_i_ModConservacion()
    Dim dtv_producto As New DataView()
    Dim opr_Area As New Cls_Areas()
    Dim boo_flag As Boolean
    Dim str_imprimir, str_codigo_barras, Puerto As String

    Sub InaHabilitabtn()
        'btn_etiq.Enabled = True
        grp_productos.Enabled = True
        btn_Aceptar.Enabled = True
        Ctl_txt_id.Focus()
    End Sub

    Sub Habilitabtn()
        'btn_etiq.Enabled = False
        grp_productos.Enabled = False
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        btn_Nuevo.Enabled = True
        btn_Nuevo.Focus()
    End Sub



    Private Sub frm_Productos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        Ctl_txt_id.txt_padre.MaxLength = 15
        Ctl_txt_ex_min.txt_padre.MaxLength = 8
        Ctl_txt_ex_max.txt_padre.MaxLength = 8
        dgrd_Productos.DataSource = dtv_producto
        opr_i_producto.LeerProductos(g_division, dtv_producto)
        opr_Area.LlenarCmb_Area_Id(cmb_Area)
        cmb_Area.SelectedIndex = 0


        'opr_i_producto.ordena_producto(campofiltro, txt_filtro.Text, dtv_producto)
        'dgrd_Productos.SetDataBinding(opr_i_producto.LeerProductos(g_division), "Registros")
        opr_i_producto.LlenarCmbUnidades(cmb_unidad)
        opr_i_producto.LlenarCmbdivision(cmb_div)
        opr_i_modConserv.LlenarCmbModCon(cmb_MConservacion)
        opr_i_modConserv.LlenarCmbSerie(cmb_serie)
        opr_i_modConserv.LlenarCmbPresentacion(cmb_Presentacion)

        Call limpiarCampos()
        cmb_perecible.SelectedIndex = 0
        Habilitabtn()
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        InaHabilitabtn()
        'btn_etiq.Enabled = False
        btn_Eliminar.Enabled = False
        btn_Nuevo.Enabled = False
        Call limpiarCampos()
        txt_filtro.Text = ""

        Ctl_txt_id.Focus()
        boo_flag = True

        Ctl_txt_id.texto_Asigna(CStr(opr_i_producto.LeerMaxIdPrd()))

    End Sub

    Public Sub limpiarCampos()
        On Error Resume Next
        Ctl_txt_id.texto_Asigna("")
        txt_desc.Text = ""
        Ctl_txt_cplazo.texto_Asigna("0")
        Ctl_txt_lplazo.texto_Asigna("0")
        Ctl_txt_ex_min.texto_Asigna("")
        Ctl_txt_ex_max.texto_Asigna("")

        cmb_unidad.SelectedIndex = 19
        cmb_MConservacion.SelectedIndex = 0
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If (Ctl_txt_id.texto_Recupera = "") Then
            MsgBox("Ingrese el código del producto", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_id.Focus()
            Exit Sub
        End If
        If (txt_desc.Text = "") Then
            '''MsgBox("Ingrese la descripción del producto", MsgBoxStyle.Information, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese la descripción del producto", g_tiempo)
            txt_desc.Focus()
            Exit Sub
        End If
        If (Ctl_txt_ex_min.texto_Recupera = "" Or Ctl_txt_ex_max.texto_Recupera = "") Then
            '''MsgBox("Ingrese los limites de existencias del producto (Mínimo y Máximo)", MsgBoxStyle.Information, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese los limites de existencias del producto (Mínimo y Máximo)", g_tiempo)
            If Ctl_txt_ex_max.texto_Recupera = "" Then Ctl_txt_ex_max.Focus()
            If Ctl_txt_ex_min.texto_Recupera = "" Then Ctl_txt_ex_min.Focus()
            Exit Sub
        End If
        If cmb_perecible.Text = "" Or cmb_unidad.Text = "" Or cmb_MConservacion.Text = "" Then
            '''MsgBox("Debe llenar los datos de unidad, perecible, modo de conservación", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("Debe llenar los datos de unidad, perecible, modo de conservación", g_tiempo)
            Exit Sub
        End If
        'Verifico que no exista otra producto con el mismo código
        If (opr_i_producto.BuscarProducto(Ctl_txt_id.texto_Recupera) = True And boo_flag = True) Then
            '''MsgBox("El código ingresado ya existe, ingrese otro", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("El código ingresado ya existe, ingrese otro", g_tiempo)
            Ctl_txt_id.Focus()
            Exit Sub
        End If
        If boo_flag = True Then
            '*** Si se trata de un nuevo PRODUCTO
            Ctl_txt_id.texto_Asigna(CStr(opr_i_producto.LeerMaxIdPrd()))
            opr_i_producto.GuardarProducto(Ctl_txt_id.texto_Recupera(), Trim(txt_desc.Text), CDbl(Ctl_txt_ex_min.texto_Recupera), CDbl(Ctl_txt_ex_max.texto_Recupera), cmb_unidad.Text.Substring(100, 10).ToString(), cmb_MConservacion.Text.Substring(100, 10).ToString, cmb_perecible.SelectedIndex, Ctl_txt_cplazo.texto_Recupera, Ctl_txt_lplazo.texto_Recupera, Mid(cmb_Area.Text, 50, 10), CInt(Mid(cmb_Presentacion.Text, 100, 10)), CInt(cmb_Frascos.Text), CInt(Mid(cmb_serie.Text, 100, 10)), Trim(txt_Abrev.Text))
        Else
            '*** Si se trata de una actualización a una AREA
            Dim obj_res As Object
            obj_res = MsgBox("¿Desea actualizar los datos?", MsgBoxStyle.YesNo, "ANALISYS")
            If (obj_res = vbYes) Then
                opr_i_producto.ActualizarProducto(Ctl_txt_id.texto_Recupera, txt_desc.Text, Ctl_txt_ex_min.texto_Recupera, Ctl_txt_ex_max.texto_Recupera, cmb_unidad.Text.Substring(100, 10).ToString(), cmb_MConservacion.Text.Substring(100, 10).ToString, cmb_perecible.SelectedIndex, Ctl_txt_id.Tag, cmb_div.Text.Substring(50, 1), Ctl_txt_cplazo.texto_Recupera, Ctl_txt_lplazo.texto_Recupera, Mid(cmb_Area.Text, 50, 10), CInt(Mid(cmb_Presentacion.Text, 100, 10)), CInt(cmb_Frascos.Text), CInt(Mid(cmb_serie.Text, 100, 10)), Trim(txt_Abrev.Text))
            Else
                Call limpiarCampos()
                Habilitabtn()
                Exit Sub
            End If
        End If
        opr_i_producto.LeerProductos(g_division, dtv_producto)
        'dgrd_Productos.SetDataBinding(opr_i_producto.LeerProductos1(g_division), "Registros")
        Call limpiarCampos()
        Habilitabtn()
        txt_filtro.Text = ""
    End Sub

    Private Sub dgrd_Productos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Productos.CurrentCellChanged
        Call limpiarCampos()
        dgrd_Productos.Select(dgrd_Productos.CurrentCell.RowNumber)
        InaHabilitabtn()
        btn_Eliminar.Enabled = True
        btn_Nuevo.Enabled = True
        Ctl_txt_id.Focus()
        Ctl_txt_id.texto_Asigna(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 0))
        Ctl_txt_id.Tag = dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 0)
        txt_desc.Text = dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 1)
        Ctl_txt_ex_min.texto_Asigna(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 2))
        Ctl_txt_ex_max.texto_Asigna(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 3))
        cmb_perecible.SelectedIndex = dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 6)
        If IsDBNull(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 7)) Then
            Ctl_txt_cplazo.texto_Asigna("")
        Else
            Ctl_txt_cplazo.texto_Asigna(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 7))
        End If
        If IsDBNull(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 8)) Then
            Ctl_txt_lplazo.texto_Asigna("")
        Else
            Ctl_txt_lplazo.texto_Asigna(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 8))
        End If

        Dim int_i As Integer
        For int_i = 0 To (cmb_unidad.Items.Count - 1)
            cmb_unidad.SelectedIndex = int_i
            If (Trim(cmb_unidad.Text.Substring(100, 10)) = dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 4)) Then
                Exit For
            End If
        Next
        For int_i = 0 To (cmb_MConservacion.Items.Count - 1)
            cmb_MConservacion.SelectedIndex = int_i
            If (Trim(cmb_MConservacion.Text.Substring(100, 10)) = dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 5)) Then
                Exit For
            End If
        Next
        'SELECCIONA EN EL COMBO DE DIVISION LA DIVISION A LA QUE PERTENECE EL PRODUCTO.
        For int_i = 0 To (cmb_div.Items.Count - 1)
            cmb_div.SelectedIndex = int_i
            If (Trim(cmb_div.Text.Substring(50, 1)) = g_division) Then
                Exit For
            End If
        Next
        Dim area_nombre As String = Nothing
        Dim serie_nombre As String = Nothing
        Dim PRES_DESCRIPCION As String = Nothing


        area_nombre = opr_Area.I_AreaNombre(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 9))
        cmb_Area.Text = Mid(area_nombre, 1, 50) & Trim(Mid(area_nombre, 51, 5))

        cmb_Frascos.Text = dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 13)

        serie_nombre = opr_Area.I_SerieNombre(CInt(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 14)))

        cmb_serie.Text = Mid(serie_nombre, 1, 100) & Mid(serie_nombre, 101, 10)

        PRES_DESCRIPCION = opr_Area.PRES_ID_Nombre(dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 15))


        cmb_Presentacion.Text = Mid(PRES_DESCRIPCION, 1, 100) & Mid(PRES_DESCRIPCION, 101, 10)

        txt_Abrev.Text = dgrd_Productos.Item(dgrd_Productos.CurrentCell.RowNumber, 16)


        boo_flag = False  'Para saber que se puede actualizar 
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 4
        dgc_celda.RowNumber = dgrd_Productos.CurrentCell.RowNumber
        dgrd_Productos.CurrentCell = dgc_celda
        dgrd_Productos.Select(dgrd_Productos.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim obj_r As Object
        obj_r = MsgBox("¿Desea eliminar el producto seleccionado?", MsgBoxStyle.YesNo, "ANALISYS")
        If (obj_r = vbYes) Then
            opr_i_producto.EliminarProducto(Ctl_txt_id.texto_Recupera)
            opr_i_producto.LeerProductos(g_division, dtv_producto)
            'dgrd_Productos.SetDataBinding(opr_i_producto.LeerProductos1(g_division), "Registros")
        End If
        Call limpiarCampos()
        Habilitabtn()
    End Sub

    Private Sub btn_reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reportes.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_I_Productos()
        str_sql = "SELECT I_PRODUCTO.I_PRD_DESCRIPCION, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, I_UNIDAD.I_UNI_DESCRIPCION AS UNIDAD, I_PRODUCTO.I_PRD_CADUC AS PRD_CADUC1, I_PRODUCTO.I_PRD_PORCADUC AS PRD_CADUC2 FROM I_PRODUCTO, I_UNIDAD WHERE I_UNIDAD.I_UNI_ID = I_PRODUCTO.I_UNI_ID AND DIV_ID = 1 order by I_PRODUCTO.I_PRD_DESCRIPCION"
        'str_sql = "SELECT I_PRODUCTO.I_PRD_DESCRIPCION, I_PRODUCTO.I_PRD_ID, I_PRODUCTO.I_PRD_EXIST_MIN, I_PRODUCTO.I_PRD_EXIST_MAX, I_PRODUCTO.I_UNI_ID FROM I_PRODUCTO WHERE DIV_ID =" & g_division
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Productos"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub


    Private Sub txt_filtro_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        'cada que presiono una tecla aplica un filtro por nombre de test o por su código según la selecció
        If Trim(txt_filtro.Text) <> "" Then
            If rbtn_nombre.Checked = True Then
                dtv_producto.RowFilter = "i_prd_descripcion like '" & Trim(txt_filtro.Text) & "*'"
            Else
                dtv_producto.RowFilter = "i_prd_ABREV like '" & Trim(txt_filtro.Text) & "*'"
            End If
        Else
            dtv_producto.RowFilter = ""
        End If

        If rbtn_nombre.Checked = True Then
            dtv_producto.Sort = "i_prd_descripcion"
        Else
            dtv_producto.Sort = "i_prd_ABREV"
        End If
    End Sub

    Private Sub cmb_perecible_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_perecible.SelectedIndexChanged
        If cmb_perecible.Text = "Si" Then
            Label2.Visible = True
            Label3.Visible = True
            Ctl_txt_cplazo.Visible = True
            Ctl_txt_lplazo.Visible = True
        Else
            Label2.Visible = False
            Label3.Visible = False
            Ctl_txt_cplazo.Visible = False
            Ctl_txt_lplazo.Visible = False
        End If


    End Sub



    Private Sub cmb_unidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_unidad.SelectedIndexChanged
        If cmb_unidad.SelectedIndex = 19 Then
            cmb_Frascos.Text = 3
        Else
            cmb_Frascos.Text = 1
        End If
    End Sub

    
End Class

