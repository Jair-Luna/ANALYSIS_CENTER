<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Preparacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Preparacion))
        Me.lbx_Proceso = New System.Windows.Forms.ListBox
        Me.txt_CantML = New System.Windows.Forms.TextBox
        Me.lbl_Unidad = New System.Windows.Forms.Label
        Me.cmb_Frscos = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_AgregarTTo = New System.Windows.Forms.Button
        Me.cmb_BodegaAlmacen = New System.Windows.Forms.ComboBox
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.Dgrd_Sustancias = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgv_Preparacion = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_AgregarMaterial = New System.Windows.Forms.Button
        Me.Dgrd_Materiales = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgv_MATPaciente = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Sustancia = New System.Windows.Forms.TextBox
        Me.txt_Proceso = New System.Windows.Forms.TextBox
        Me.pan_barra.SuspendLayout()
        CType(Me.Dgrd_Sustancias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Preparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgrd_Materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_MATPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbx_Proceso
        '
        Me.lbx_Proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_Proceso.FormattingEnabled = True
        Me.lbx_Proceso.ItemHeight = 16
        Me.lbx_Proceso.Items.AddRange(New Object() {"Control de calidad", "PDU", "Siembra", "Quimica", "Produccion", "Gotero Interno"})
        Me.lbx_Proceso.Location = New System.Drawing.Point(325, 101)
        Me.lbx_Proceso.Name = "lbx_Proceso"
        Me.lbx_Proceso.Size = New System.Drawing.Size(147, 196)
        Me.lbx_Proceso.TabIndex = 1
        '
        'txt_CantML
        '
        Me.txt_CantML.Location = New System.Drawing.Point(6, 19)
        Me.txt_CantML.Name = "txt_CantML"
        Me.txt_CantML.Size = New System.Drawing.Size(52, 20)
        Me.txt_CantML.TabIndex = 2
        '
        'lbl_Unidad
        '
        Me.lbl_Unidad.AutoSize = True
        Me.lbl_Unidad.Location = New System.Drawing.Point(64, 23)
        Me.lbl_Unidad.Name = "lbl_Unidad"
        Me.lbl_Unidad.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Unidad.TabIndex = 4
        Me.lbl_Unidad.Text = "lbl_Unidad"
        '
        'cmb_Frscos
        '
        Me.cmb_Frscos.FormattingEnabled = True
        Me.cmb_Frscos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmb_Frscos.Location = New System.Drawing.Point(6, 19)
        Me.cmb_Frscos.Name = "cmb_Frscos"
        Me.cmb_Frscos.Size = New System.Drawing.Size(52, 21)
        Me.cmb_Frscos.TabIndex = 12
        Me.cmb_Frscos.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "# Fscos"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Guardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_Guardar.Image = CType(resources.GetObject("btn_Guardar.Image"), System.Drawing.Image)
        Me.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.Location = New System.Drawing.Point(879, 37)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(81, 40)
        Me.btn_Guardar.TabIndex = 225
        Me.btn_Guardar.Text = "Limpiar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'btn_AgregarTTo
        '
        Me.btn_AgregarTTo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_AgregarTTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AgregarTTo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_AgregarTTo.Enabled = False
        Me.btn_AgregarTTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarTTo.ForeColor = System.Drawing.Color.Black
        Me.btn_AgregarTTo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarTTo.Location = New System.Drawing.Point(34, 47)
        Me.btn_AgregarTTo.Name = "btn_AgregarTTo"
        Me.btn_AgregarTTo.Size = New System.Drawing.Size(81, 31)
        Me.btn_AgregarTTo.TabIndex = 227
        Me.btn_AgregarTTo.Text = "Ingresar >>"
        Me.btn_AgregarTTo.UseVisualStyleBackColor = False
        '
        'cmb_BodegaAlmacen
        '
        Me.cmb_BodegaAlmacen.DisplayMember = "1"
        Me.cmb_BodegaAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BodegaAlmacen.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_BodegaAlmacen.ItemHeight = 14
        Me.cmb_BodegaAlmacen.Location = New System.Drawing.Point(21, 55)
        Me.cmb_BodegaAlmacen.Name = "cmb_BodegaAlmacen"
        Me.cmb_BodegaAlmacen.Size = New System.Drawing.Size(219, 22)
        Me.cmb_BodegaAlmacen.TabIndex = 295
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(1059, 25)
        Me.pan_barra.TabIndex = 297
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
        Me.lbl_textform.Size = New System.Drawing.Size(120, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "PREPARACION"
        '
        'Dgrd_Sustancias
        '
        Me.Dgrd_Sustancias.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_Sustancias.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_Sustancias.BackgroundColor = System.Drawing.Color.Gray
        Me.Dgrd_Sustancias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgrd_Sustancias.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_Sustancias.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Sustancias.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Sustancias.CaptionText = "SUSTANCIAS DISPONIBLES"
        Me.Dgrd_Sustancias.DataMember = ""
        Me.Dgrd_Sustancias.FlatMode = True
        Me.Dgrd_Sustancias.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Sustancias.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_Sustancias.GridLineColor = System.Drawing.Color.LightGray
        Me.Dgrd_Sustancias.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_Sustancias.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Sustancias.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Sustancias.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_Sustancias.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Sustancias.Location = New System.Drawing.Point(19, 81)
        Me.Dgrd_Sustancias.Name = "Dgrd_Sustancias"
        Me.Dgrd_Sustancias.ParentRowsBackColor = System.Drawing.Color.Gray
        Me.Dgrd_Sustancias.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_Sustancias.ParentRowsVisible = False
        Me.Dgrd_Sustancias.PreferredColumnWidth = 100
        Me.Dgrd_Sustancias.ReadOnly = True
        Me.Dgrd_Sustancias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_Sustancias.RowHeadersVisible = False
        Me.Dgrd_Sustancias.RowHeaderWidth = 0
        Me.Dgrd_Sustancias.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_Sustancias.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_Sustancias.Size = New System.Drawing.Size(300, 219)
        Me.Dgrd_Sustancias.TabIndex = 298
        Me.Dgrd_Sustancias.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_Sustancias.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_Sustancias
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.MappingName = "I_PRD_ABREV"
        Me.DataGridTextBoxColumn27.Width = 40
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "I_PRD_ID"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "I_PRD_DESCRIPCION"
        Me.DataGridTextBoxColumn2.Width = 140
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "INV_CANTIDAD"
        Me.DataGridTextBoxColumn3.Width = 40
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "I_BOD_DESCRIPCION"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "I_MOD_LOTE"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "I_PRD_FRASCOS"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "EDAD"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "VIA"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "ORIGEN"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "I_MOD_COSTO"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "SER_ID"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "I_UNI_DESCRIPCION"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "PRES_DESCRIPCION"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(606, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(441, 18)
        Me.Label4.TabIndex = 300
        Me.Label4.Text = "HISTORIAL DE PREPARACIONES"
        '
        'dgv_Preparacion
        '
        Me.dgv_Preparacion.AllowUserToAddRows = False
        Me.dgv_Preparacion.AllowUserToDeleteRows = False
        Me.dgv_Preparacion.BackgroundColor = System.Drawing.Color.Gray
        Me.dgv_Preparacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Preparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Preparacion.Location = New System.Drawing.Point(605, 101)
        Me.dgv_Preparacion.Name = "dgv_Preparacion"
        Me.dgv_Preparacion.ReadOnly = True
        Me.dgv_Preparacion.Size = New System.Drawing.Size(442, 198)
        Me.dgv_Preparacion.TabIndex = 299
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 301
        Me.Label1.Text = "PROCESO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Unidad)
        Me.GroupBox1.Controls.Add(Me.txt_CantML)
        Me.GroupBox1.Controls.Add(Me.btn_AgregarTTo)
        Me.GroupBox1.Location = New System.Drawing.Point(478, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 84)
        Me.GroupBox1.TabIndex = 302
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_AgregarMaterial)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmb_Frscos)
        Me.GroupBox2.Location = New System.Drawing.Point(478, 316)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(121, 83)
        Me.GroupBox2.TabIndex = 303
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'btn_AgregarMaterial
        '
        Me.btn_AgregarMaterial.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_AgregarMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AgregarMaterial.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_AgregarMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarMaterial.ForeColor = System.Drawing.Color.Black
        Me.btn_AgregarMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarMaterial.Location = New System.Drawing.Point(34, 46)
        Me.btn_AgregarMaterial.Name = "btn_AgregarMaterial"
        Me.btn_AgregarMaterial.Size = New System.Drawing.Size(81, 31)
        Me.btn_AgregarMaterial.TabIndex = 228
        Me.btn_AgregarMaterial.Text = "Ingresar >>"
        Me.btn_AgregarMaterial.UseVisualStyleBackColor = False
        '
        'Dgrd_Materiales
        '
        Me.Dgrd_Materiales.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_Materiales.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_Materiales.BackgroundColor = System.Drawing.Color.Gray
        Me.Dgrd_Materiales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgrd_Materiales.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_Materiales.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Materiales.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Materiales.CaptionText = "MATERIALES DISPONIBLES"
        Me.Dgrd_Materiales.DataMember = ""
        Me.Dgrd_Materiales.FlatMode = True
        Me.Dgrd_Materiales.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Materiales.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_Materiales.GridLineColor = System.Drawing.Color.LightGray
        Me.Dgrd_Materiales.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_Materiales.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Materiales.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Materiales.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_Materiales.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Materiales.Location = New System.Drawing.Point(19, 302)
        Me.Dgrd_Materiales.Name = "Dgrd_Materiales"
        Me.Dgrd_Materiales.ParentRowsBackColor = System.Drawing.Color.Gray
        Me.Dgrd_Materiales.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_Materiales.ParentRowsVisible = False
        Me.Dgrd_Materiales.PreferredColumnWidth = 100
        Me.Dgrd_Materiales.ReadOnly = True
        Me.Dgrd_Materiales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_Materiales.RowHeadersVisible = False
        Me.Dgrd_Materiales.RowHeaderWidth = 0
        Me.Dgrd_Materiales.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_Materiales.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_Materiales.Size = New System.Drawing.Size(300, 220)
        Me.Dgrd_Materiales.TabIndex = 304
        Me.Dgrd_Materiales.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.Dgrd_Materiales.TabStop = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.Dgrd_Materiales
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Registros"
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.MappingName = "I_PRD_ABREV"
        Me.DataGridTextBoxColumn28.Width = 40
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "I_PRD_ID"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.MappingName = "I_PRD_DESCRIPCION"
        Me.DataGridTextBoxColumn15.Width = 140
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.MappingName = "INV_CANTIDAD"
        Me.DataGridTextBoxColumn16.Width = 40
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.MappingName = "I_BOD_DESCRIPCION"
        Me.DataGridTextBoxColumn17.Width = 0
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.MappingName = "I_MOD_LOTE"
        Me.DataGridTextBoxColumn18.Width = 0
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.MappingName = "I_PRD_FRASCOS"
        Me.DataGridTextBoxColumn19.Width = 0
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.MappingName = "EDAD"
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.MappingName = "VIA"
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.MappingName = "ORIGEN"
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.MappingName = "I_MOD_COSTO"
        Me.DataGridTextBoxColumn23.Width = 0
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.MappingName = "SER_ID"
        Me.DataGridTextBoxColumn24.Width = 0
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.MappingName = "I_UNI_DESCRIPCION"
        Me.DataGridTextBoxColumn25.Width = 0
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.MappingName = "PRES_DESCRIPCION"
        Me.DataGridTextBoxColumn26.Width = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(606, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(441, 18)
        Me.Label3.TabIndex = 306
        Me.Label3.Text = "HISTORIAL MATERIALES PREPARACION"
        '
        'dgv_MATPaciente
        '
        Me.dgv_MATPaciente.AllowUserToAddRows = False
        Me.dgv_MATPaciente.AllowUserToDeleteRows = False
        Me.dgv_MATPaciente.BackgroundColor = System.Drawing.Color.Gray
        Me.dgv_MATPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_MATPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_MATPaciente.Location = New System.Drawing.Point(605, 324)
        Me.dgv_MATPaciente.Name = "dgv_MATPaciente"
        Me.dgv_MATPaciente.ReadOnly = True
        Me.dgv_MATPaciente.Size = New System.Drawing.Size(442, 198)
        Me.dgv_MATPaciente.TabIndex = 305
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(966, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 40)
        Me.Button1.TabIndex = 307
        Me.Button1.Text = "Cerrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 308
        Me.Label2.Text = "SUSTANCIA SELECCIONADA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 309
        Me.Label5.Text = "PROCESO:"
        '
        'txt_Sustancia
        '
        Me.txt_Sustancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Sustancia.Enabled = False
        Me.txt_Sustancia.Location = New System.Drawing.Point(604, 31)
        Me.txt_Sustancia.Name = "txt_Sustancia"
        Me.txt_Sustancia.Size = New System.Drawing.Size(200, 20)
        Me.txt_Sustancia.TabIndex = 310
        '
        'txt_Proceso
        '
        Me.txt_Proceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Proceso.Enabled = False
        Me.txt_Proceso.Location = New System.Drawing.Point(604, 52)
        Me.txt_Proceso.Name = "txt_Proceso"
        Me.txt_Proceso.Size = New System.Drawing.Size(200, 20)
        Me.txt_Proceso.TabIndex = 311
        '
        'frm_Preparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1059, 564)
        Me.Controls.Add(Me.txt_Proceso)
        Me.Controls.Add(Me.txt_Sustancia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_MATPaciente)
        Me.Controls.Add(Me.Dgrd_Materiales)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_Preparacion)
        Me.Controls.Add(Me.Dgrd_Sustancias)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.cmb_BodegaAlmacen)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbx_Proceso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Preparacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Preparacion"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.Dgrd_Sustancias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Preparacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dgrd_Materiales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_MATPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbx_Proceso As System.Windows.Forms.ListBox
    Friend WithEvents txt_CantML As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Unidad As System.Windows.Forms.Label
    Friend WithEvents cmb_Frscos As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_AgregarTTo As System.Windows.Forms.Button
    Friend WithEvents cmb_BodegaAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Dgrd_Sustancias As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_Preparacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_AgregarMaterial As System.Windows.Forms.Button
    Friend WithEvents Dgrd_Materiales As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_MATPaciente As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Sustancia As System.Windows.Forms.TextBox
    Friend WithEvents txt_Proceso As System.Windows.Forms.TextBox
End Class
