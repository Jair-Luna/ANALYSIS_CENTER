<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_imprimiendo
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_imprimiendo))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Dts_proforma1 = New AnalisysLAB.dts_proforma
        Me.Grup_paciente = New System.Windows.Forms.GroupBox
        Me.lbl_histC = New System.Windows.Forms.Label
        Me.chk_TipoCod = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_impBC = New System.Windows.Forms.ComboBox
        Me.lbl_turno = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_muestra = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgrd_muestra = New System.Windows.Forms.DataGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_tipo = New System.Windows.Forms.Label
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.lbl_nombres = New System.Windows.Forms.Label
        Me.lbl_encabezado = New System.Windows.Forms.Label
        Me.lbl_codigo_barras = New System.Windows.Forms.Label
        Me.lbl_pedido = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbl_total = New System.Windows.Forms.Label
        Me.btn_cancelar2 = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.lbl_sexo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblServicio = New System.Windows.Forms.Label
        CType(Me.Dts_proforma1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grup_paciente.SuspendLayout()
        CType(Me.dgrd_muestra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(65, 30)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(335, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(621, 23)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(243, 178)
        Me.CrystalReportViewer1.TabIndex = 146
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Dts_proforma1
        '
        Me.Dts_proforma1.DataSetName = "dts_proforma"
        Me.Dts_proforma1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Grup_paciente
        '
        Me.Grup_paciente.BackColor = System.Drawing.Color.Transparent
        Me.Grup_paciente.Controls.Add(Me.lblServicio)
        Me.Grup_paciente.Controls.Add(Me.lbl_histC)
        Me.Grup_paciente.Controls.Add(Me.chk_TipoCod)
        Me.Grup_paciente.Controls.Add(Me.Label4)
        Me.Grup_paciente.Controls.Add(Me.cmb_impBC)
        Me.Grup_paciente.Controls.Add(Me.lbl_turno)
        Me.Grup_paciente.Controls.Add(Me.Label2)
        Me.Grup_paciente.Controls.Add(Me.cmb_muestra)
        Me.Grup_paciente.Controls.Add(Me.Label5)
        Me.Grup_paciente.Controls.Add(Me.dgrd_muestra)
        Me.Grup_paciente.Controls.Add(Me.Panel1)
        Me.Grup_paciente.Controls.Add(Me.lbl_pedido)
        Me.Grup_paciente.Controls.Add(Me.Label3)
        Me.Grup_paciente.Controls.Add(Me.Label13)
        Me.Grup_paciente.Controls.Add(Me.lbl_total)
        Me.Grup_paciente.Controls.Add(Me.btn_cancelar2)
        Me.Grup_paciente.Controls.Add(Me.btn_aceptar)
        Me.Grup_paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grup_paciente.ForeColor = System.Drawing.Color.Navy
        Me.Grup_paciente.Location = New System.Drawing.Point(2, 106)
        Me.Grup_paciente.Name = "Grup_paciente"
        Me.Grup_paciente.Size = New System.Drawing.Size(574, 224)
        Me.Grup_paciente.TabIndex = 147
        Me.Grup_paciente.TabStop = False
        Me.Grup_paciente.Text = "Impresión de Etiquetas"
        '
        'lbl_histC
        '
        Me.lbl_histC.AutoSize = True
        Me.lbl_histC.BackColor = System.Drawing.Color.Transparent
        Me.lbl_histC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_histC.ForeColor = System.Drawing.Color.Black
        Me.lbl_histC.Location = New System.Drawing.Point(329, 17)
        Me.lbl_histC.Name = "lbl_histC"
        Me.lbl_histC.Size = New System.Drawing.Size(0, 13)
        Me.lbl_histC.TabIndex = 110
        Me.lbl_histC.Visible = False
        '
        'chk_TipoCod
        '
        Me.chk_TipoCod.Location = New System.Drawing.Point(12, 204)
        Me.chk_TipoCod.Name = "chk_TipoCod"
        Me.chk_TipoCod.Size = New System.Drawing.Size(104, 16)
        Me.chk_TipoCod.TabIndex = 109
        Me.chk_TipoCod.Text = "Cod 39"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(340, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Impresora:"
        '
        'cmb_impBC
        '
        Me.cmb_impBC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_impBC.Location = New System.Drawing.Point(416, 184)
        Me.cmb_impBC.Name = "cmb_impBC"
        Me.cmb_impBC.Size = New System.Drawing.Size(121, 21)
        Me.cmb_impBC.TabIndex = 107
        '
        'lbl_turno
        '
        Me.lbl_turno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_turno.ForeColor = System.Drawing.Color.Black
        Me.lbl_turno.Location = New System.Drawing.Point(68, 32)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(90, 13)
        Me.lbl_turno.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Turno :"
        '
        'cmb_muestra
        '
        Me.cmb_muestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_muestra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_muestra.Location = New System.Drawing.Point(199, 74)
        Me.cmb_muestra.Name = "cmb_muestra"
        Me.cmb_muestra.Size = New System.Drawing.Size(124, 21)
        Me.cmb_muestra.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(199, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Muestra"
        '
        'dgrd_muestra
        '
        Me.dgrd_muestra.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_muestra.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_muestra.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_muestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_muestra.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_muestra.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_muestra.CaptionText = "ETIQUETAS"
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
        Me.dgrd_muestra.Location = New System.Drawing.Point(9, 52)
        Me.dgrd_muestra.Name = "dgrd_muestra"
        Me.dgrd_muestra.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_muestra.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_muestra.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_muestra.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_muestra.Size = New System.Drawing.Size(181, 120)
        Me.dgrd_muestra.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_tipo)
        Me.Panel1.Controls.Add(Me.lbl_doc)
        Me.Panel1.Controls.Add(Me.lbl_edad)
        Me.Panel1.Controls.Add(Me.lbl_fecha)
        Me.Panel1.Controls.Add(Me.lbl_nombres)
        Me.Panel1.Controls.Add(Me.lbl_encabezado)
        Me.Panel1.Controls.Add(Me.lbl_codigo_barras)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(327, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 120)
        Me.Panel1.TabIndex = 15
        '
        'lbl_tipo
        '
        Me.lbl_tipo.BackColor = System.Drawing.Color.White
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.Location = New System.Drawing.Point(191, 52)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(45, 18)
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
        Me.lbl_edad.Location = New System.Drawing.Point(168, 102)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(68, 14)
        Me.lbl_edad.TabIndex = 19
        Me.lbl_edad.Text = "EDAD"
        Me.lbl_edad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.Color.White
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(13, 91)
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
        Me.lbl_encabezado.Size = New System.Drawing.Size(239, 17)
        Me.lbl_encabezado.TabIndex = 16
        Me.lbl_encabezado.Text = "   C.M.R. LABORATORIO"
        Me.lbl_encabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_codigo_barras
        '
        Me.lbl_codigo_barras.BackColor = System.Drawing.Color.White
        Me.lbl_codigo_barras.Font = New System.Drawing.Font("C39HrP24DhTt", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo_barras.Location = New System.Drawing.Point(3, 28)
        Me.lbl_codigo_barras.Name = "lbl_codigo_barras"
        Me.lbl_codigo_barras.Size = New System.Drawing.Size(218, 69)
        Me.lbl_codigo_barras.TabIndex = 15
        Me.lbl_codigo_barras.Text = "codigo"
        Me.lbl_codigo_barras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pedido
        '
        Me.lbl_pedido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.ForeColor = System.Drawing.Color.Black
        Me.lbl_pedido.Location = New System.Drawing.Point(380, 32)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(105, 13)
        Me.lbl_pedido.TabIndex = 10
        Me.lbl_pedido.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(328, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pedido :"
        Me.Label3.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Total : "
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Red
        Me.lbl_total.Location = New System.Drawing.Point(75, 182)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 13)
        Me.lbl_total.TabIndex = 103
        Me.lbl_total.Text = "0"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_cancelar2
        '
        Me.btn_cancelar2.BackgroundImage = CType(resources.GetObject("btn_cancelar2.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancelar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar2.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar2.Location = New System.Drawing.Point(199, 138)
        Me.btn_cancelar2.Name = "btn_cancelar2"
        Me.btn_cancelar2.Size = New System.Drawing.Size(58, 24)
        Me.btn_cancelar2.TabIndex = 3
        Me.btn_cancelar2.TabStop = False
        Me.btn_cancelar2.Text = "Eliminar"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.BackgroundImage = CType(resources.GetObject("btn_aceptar.BackgroundImage"), System.Drawing.Image)
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(199, 104)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(58, 24)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.TabStop = False
        Me.btn_aceptar.Text = "Añadir"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'lbl_sexo
        '
        Me.lbl_sexo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.Location = New System.Drawing.Point(405, 90)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(23, 14)
        Me.lbl_sexo.TabIndex = 148
        Me.lbl_sexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 149
        Me.PictureBox1.TabStop = False
        '
        'lblServicio
        '
        Me.lblServicio.BackColor = System.Drawing.Color.White
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(325, 45)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(135, 15)
        Me.lblServicio.TabIndex = 150
        Me.lblServicio.Text = "SERVICIO"
        Me.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_imprimiendo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(419, 76)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Grup_paciente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_imprimiendo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_imprimiendo"
        CType(Me.Dts_proforma1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grup_paciente.ResumeLayout(False)
        Me.Grup_paciente.PerformLayout()
        CType(Me.dgrd_muestra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Dts_proforma1 As AnalisysLAB.dts_proforma
    Friend WithEvents Grup_paciente As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_histC As System.Windows.Forms.Label
    Friend WithEvents chk_TipoCod As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_impBC As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_turno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_muestra As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgrd_muestra As System.Windows.Forms.DataGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_encabezado As System.Windows.Forms.Label
    Friend WithEvents lbl_codigo_barras As System.Windows.Forms.Label
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar2 As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblServicio As System.Windows.Forms.Label
End Class
