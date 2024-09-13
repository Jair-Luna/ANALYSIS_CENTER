<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Tendencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Tendencia))
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.btn_imprimirA = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Calcular = New System.Windows.Forms.Button
        Me.dgv_TendenciaN = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabExistencia = New System.Windows.Forms.TabPage
        Me.btn_CalcularN = New System.Windows.Forms.Button
        Me.btn_imprimirN = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_ssalir = New System.Windows.Forms.Button
        Me.dgv_Tendencia = New System.Windows.Forms.DataGridView
        Me.TabConsumo = New System.Windows.Forms.TabPage
        Me.dgv_CAnualTODO = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgv_CAnualN = New System.Windows.Forms.DataGridView
        Me.dgv_CAnualA = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgv_ConsumoN = New System.Windows.Forms.DataGridView
        Me.dgv_ConsumoA = New System.Windows.Forms.DataGridView
        Me.TabDatos = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgv_ConsDiarioN = New System.Windows.Forms.DataGridView
        Me.Btn_ImprimirMes = New System.Windows.Forms.Button
        Me.cmb_Mes = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgv_ConsDiarioA = New System.Windows.Forms.DataGridView
        Me.TabMenCliente = New System.Windows.Forms.TabPage
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dgv_ConsumoN_cli = New System.Windows.Forms.DataGridView
        Me.dgv_ConsumoA_cli = New System.Windows.Forms.DataGridView
        Me.TabDiaCliente = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.dgv_ConsDiarioNCli = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.dgv_ConsDiarioACli = New System.Windows.Forms.DataGridView
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cmb_Anio = New System.Windows.Forms.ComboBox
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_TendenciaN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabExistencia.SuspendLayout()
        CType(Me.dgv_Tendencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConsumo.SuspendLayout()
        CType(Me.dgv_CAnualTODO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_CAnualN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_CAnualA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ConsumoN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ConsumoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDatos.SuspendLayout()
        CType(Me.dgv_ConsDiarioN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ConsDiarioA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMenCliente.SuspendLayout()
        CType(Me.dgv_ConsumoN_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ConsumoA_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDiaCliente.SuspendLayout()
        CType(Me.dgv_ConsDiarioNCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ConsDiarioACli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(6, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(213, 19)
        Me.lbl_textform.TabIndex = 218
        Me.lbl_textform.Text = "ANALISIS DE CONSUMOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(1058, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 217
        Me.pic_barra.TabStop = False
        '
        'btn_imprimirA
        '
        Me.btn_imprimirA.BackColor = System.Drawing.Color.White
        Me.btn_imprimirA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirA.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirA.Image = CType(resources.GetObject("btn_imprimirA.Image"), System.Drawing.Image)
        Me.btn_imprimirA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirA.Location = New System.Drawing.Point(951, 75)
        Me.btn_imprimirA.Name = "btn_imprimirA"
        Me.btn_imprimirA.Size = New System.Drawing.Size(73, 40)
        Me.btn_imprimirA.TabIndex = 220
        Me.btn_imprimirA.Text = "Imprimir"
        Me.btn_imprimirA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirA.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(931, 38)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(105, 40)
        Me.btn_Salir.TabIndex = 219
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Calcular
        '
        Me.btn_Calcular.BackColor = System.Drawing.Color.White
        Me.btn_Calcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calcular.ForeColor = System.Drawing.Color.Black
        Me.btn_Calcular.Image = CType(resources.GetObject("btn_Calcular.Image"), System.Drawing.Image)
        Me.btn_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Calcular.Location = New System.Drawing.Point(951, 29)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(73, 40)
        Me.btn_Calcular.TabIndex = 221
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Calcular.UseVisualStyleBackColor = False
        '
        'dgv_TendenciaN
        '
        Me.dgv_TendenciaN.AllowUserToAddRows = False
        Me.dgv_TendenciaN.AllowUserToDeleteRows = False
        Me.dgv_TendenciaN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_TendenciaN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_TendenciaN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_TendenciaN.Location = New System.Drawing.Point(11, 243)
        Me.dgv_TendenciaN.MultiSelect = False
        Me.dgv_TendenciaN.Name = "dgv_TendenciaN"
        Me.dgv_TendenciaN.RowHeadersVisible = False
        Me.dgv_TendenciaN.Size = New System.Drawing.Size(934, 177)
        Me.dgv_TendenciaN.TabIndex = 222
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabExistencia)
        Me.TabControl1.Controls.Add(Me.TabConsumo)
        Me.TabControl1.Controls.Add(Me.TabDatos)
        Me.TabControl1.Controls.Add(Me.TabMenCliente)
        Me.TabControl1.Controls.Add(Me.TabDiaCliente)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1038, 472)
        Me.TabControl1.TabIndex = 223
        '
        'TabExistencia
        '
        Me.TabExistencia.BackColor = System.Drawing.Color.PowderBlue
        Me.TabExistencia.Controls.Add(Me.btn_CalcularN)
        Me.TabExistencia.Controls.Add(Me.btn_imprimirN)
        Me.TabExistencia.Controls.Add(Me.Label1)
        Me.TabExistencia.Controls.Add(Me.btn_Calcular)
        Me.TabExistencia.Controls.Add(Me.Label4)
        Me.TabExistencia.Controls.Add(Me.btn_imprimirA)
        Me.TabExistencia.Controls.Add(Me.btn_ssalir)
        Me.TabExistencia.Controls.Add(Me.dgv_TendenciaN)
        Me.TabExistencia.Controls.Add(Me.dgv_Tendencia)
        Me.TabExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabExistencia.Location = New System.Drawing.Point(4, 25)
        Me.TabExistencia.Name = "TabExistencia"
        Me.TabExistencia.Padding = New System.Windows.Forms.Padding(3)
        Me.TabExistencia.Size = New System.Drawing.Size(1030, 443)
        Me.TabExistencia.TabIndex = 0
        Me.TabExistencia.Text = "     EXISTENCIA     "
        Me.TabExistencia.UseVisualStyleBackColor = True
        '
        'btn_CalcularN
        '
        Me.btn_CalcularN.BackColor = System.Drawing.Color.White
        Me.btn_CalcularN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CalcularN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CalcularN.ForeColor = System.Drawing.Color.Black
        Me.btn_CalcularN.Image = CType(resources.GetObject("btn_CalcularN.Image"), System.Drawing.Image)
        Me.btn_CalcularN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CalcularN.Location = New System.Drawing.Point(951, 241)
        Me.btn_CalcularN.Name = "btn_CalcularN"
        Me.btn_CalcularN.Size = New System.Drawing.Size(73, 40)
        Me.btn_CalcularN.TabIndex = 273
        Me.btn_CalcularN.Text = "Calcular"
        Me.btn_CalcularN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CalcularN.UseVisualStyleBackColor = False
        '
        'btn_imprimirN
        '
        Me.btn_imprimirN.BackColor = System.Drawing.Color.White
        Me.btn_imprimirN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirN.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirN.Image = CType(resources.GetObject("btn_imprimirN.Image"), System.Drawing.Image)
        Me.btn_imprimirN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirN.Location = New System.Drawing.Point(951, 287)
        Me.btn_imprimirN.Name = "btn_imprimirN"
        Me.btn_imprimirN.Size = New System.Drawing.Size(73, 40)
        Me.btn_imprimirN.TabIndex = 272
        Me.btn_imprimirN.Text = "Imprimir"
        Me.btn_imprimirN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(937, 14)
        Me.Label1.TabIndex = 271
        Me.Label1.Text = "NIÑOS"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(937, 14)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "ADULTOS"
        '
        'btn_ssalir
        '
        Me.btn_ssalir.BackColor = System.Drawing.Color.White
        Me.btn_ssalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ssalir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ssalir.Image = CType(resources.GetObject("btn_ssalir.Image"), System.Drawing.Image)
        Me.btn_ssalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ssalir.Location = New System.Drawing.Point(1211, 399)
        Me.btn_ssalir.Name = "btn_ssalir"
        Me.btn_ssalir.Size = New System.Drawing.Size(111, 47)
        Me.btn_ssalir.TabIndex = 179
        Me.btn_ssalir.Text = "SALIR"
        Me.btn_ssalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ssalir.UseVisualStyleBackColor = False
        '
        'dgv_Tendencia
        '
        Me.dgv_Tendencia.AllowUserToAddRows = False
        Me.dgv_Tendencia.AllowUserToDeleteRows = False
        Me.dgv_Tendencia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_Tendencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Tendencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Tendencia.Location = New System.Drawing.Point(11, 29)
        Me.dgv_Tendencia.MultiSelect = False
        Me.dgv_Tendencia.Name = "dgv_Tendencia"
        Me.dgv_Tendencia.RowHeadersVisible = False
        Me.dgv_Tendencia.Size = New System.Drawing.Size(934, 186)
        Me.dgv_Tendencia.TabIndex = 216
        '
        'TabConsumo
        '
        Me.TabConsumo.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TabConsumo.Controls.Add(Me.dgv_CAnualTODO)
        Me.TabConsumo.Controls.Add(Me.Label7)
        Me.TabConsumo.Controls.Add(Me.Label6)
        Me.TabConsumo.Controls.Add(Me.Label5)
        Me.TabConsumo.Controls.Add(Me.dgv_CAnualN)
        Me.TabConsumo.Controls.Add(Me.dgv_CAnualA)
        Me.TabConsumo.Controls.Add(Me.Label3)
        Me.TabConsumo.Controls.Add(Me.Label2)
        Me.TabConsumo.Controls.Add(Me.dgv_ConsumoN)
        Me.TabConsumo.Controls.Add(Me.dgv_ConsumoA)
        Me.TabConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsumo.Location = New System.Drawing.Point(4, 25)
        Me.TabConsumo.Name = "TabConsumo"
        Me.TabConsumo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConsumo.Size = New System.Drawing.Size(1030, 443)
        Me.TabConsumo.TabIndex = 1
        Me.TabConsumo.Text = "     MENSUAL - PACIENTE     "
        Me.TabConsumo.UseVisualStyleBackColor = True
        '
        'dgv_CAnualTODO
        '
        Me.dgv_CAnualTODO.AllowUserToAddRows = False
        Me.dgv_CAnualTODO.AllowUserToDeleteRows = False
        Me.dgv_CAnualTODO.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_CAnualTODO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_CAnualTODO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CAnualTODO.Location = New System.Drawing.Point(777, 25)
        Me.dgv_CAnualTODO.MultiSelect = False
        Me.dgv_CAnualTODO.Name = "dgv_CAnualTODO"
        Me.dgv_CAnualTODO.RowHeadersVisible = False
        Me.dgv_CAnualTODO.Size = New System.Drawing.Size(225, 117)
        Me.dgv_CAnualTODO.TabIndex = 278
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(777, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 14)
        Me.Label7.TabIndex = 277
        Me.Label7.Text = "TOTAL ANUAL ADULTO"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(777, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 14)
        Me.Label6.TabIndex = 276
        Me.Label6.Text = "TOTAL ANUAL NIÑOS"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(777, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 14)
        Me.Label5.TabIndex = 275
        Me.Label5.Text = "TOTAL ANUAL"
        '
        'dgv_CAnualN
        '
        Me.dgv_CAnualN.AllowUserToAddRows = False
        Me.dgv_CAnualN.AllowUserToDeleteRows = False
        Me.dgv_CAnualN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_CAnualN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_CAnualN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CAnualN.Location = New System.Drawing.Point(777, 309)
        Me.dgv_CAnualN.MultiSelect = False
        Me.dgv_CAnualN.Name = "dgv_CAnualN"
        Me.dgv_CAnualN.RowHeadersVisible = False
        Me.dgv_CAnualN.Size = New System.Drawing.Size(225, 107)
        Me.dgv_CAnualN.TabIndex = 274
        '
        'dgv_CAnualA
        '
        Me.dgv_CAnualA.AllowUserToAddRows = False
        Me.dgv_CAnualA.AllowUserToDeleteRows = False
        Me.dgv_CAnualA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_CAnualA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_CAnualA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CAnualA.Location = New System.Drawing.Point(777, 172)
        Me.dgv_CAnualA.MultiSelect = False
        Me.dgv_CAnualA.Name = "dgv_CAnualA"
        Me.dgv_CAnualA.RowHeadersVisible = False
        Me.dgv_CAnualA.Size = New System.Drawing.Size(225, 108)
        Me.dgv_CAnualA.TabIndex = 273
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(732, 14)
        Me.Label3.TabIndex = 272
        Me.Label3.Text = "NIÑOS"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(732, 14)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "ADULTOS"
        '
        'dgv_ConsumoN
        '
        Me.dgv_ConsumoN.AllowUserToAddRows = False
        Me.dgv_ConsumoN.AllowUserToDeleteRows = False
        Me.dgv_ConsumoN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsumoN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsumoN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsumoN.Location = New System.Drawing.Point(12, 242)
        Me.dgv_ConsumoN.MultiSelect = False
        Me.dgv_ConsumoN.Name = "dgv_ConsumoN"
        Me.dgv_ConsumoN.RowHeadersVisible = False
        Me.dgv_ConsumoN.Size = New System.Drawing.Size(732, 177)
        Me.dgv_ConsumoN.TabIndex = 225
        '
        'dgv_ConsumoA
        '
        Me.dgv_ConsumoA.AllowUserToAddRows = False
        Me.dgv_ConsumoA.AllowUserToDeleteRows = False
        Me.dgv_ConsumoA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsumoA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsumoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsumoA.Location = New System.Drawing.Point(12, 28)
        Me.dgv_ConsumoA.MultiSelect = False
        Me.dgv_ConsumoA.Name = "dgv_ConsumoA"
        Me.dgv_ConsumoA.RowHeadersVisible = False
        Me.dgv_ConsumoA.Size = New System.Drawing.Size(732, 186)
        Me.dgv_ConsumoA.TabIndex = 224
        '
        'TabDatos
        '
        Me.TabDatos.Controls.Add(Me.Label9)
        Me.TabDatos.Controls.Add(Me.dgv_ConsDiarioN)
        Me.TabDatos.Controls.Add(Me.Btn_ImprimirMes)
        Me.TabDatos.Controls.Add(Me.cmb_Mes)
        Me.TabDatos.Controls.Add(Me.Label8)
        Me.TabDatos.Controls.Add(Me.dgv_ConsDiarioA)
        Me.TabDatos.Location = New System.Drawing.Point(4, 25)
        Me.TabDatos.Name = "TabDatos"
        Me.TabDatos.Size = New System.Drawing.Size(1030, 443)
        Me.TabDatos.TabIndex = 2
        Me.TabDatos.Text = "     DIARIO - PACIENTE     "
        Me.TabDatos.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(901, 14)
        Me.Label9.TabIndex = 275
        Me.Label9.Text = "NIÑOS"
        '
        'dgv_ConsDiarioN
        '
        Me.dgv_ConsDiarioN.AllowUserToAddRows = False
        Me.dgv_ConsDiarioN.AllowUserToDeleteRows = False
        Me.dgv_ConsDiarioN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsDiarioN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsDiarioN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsDiarioN.Location = New System.Drawing.Point(12, 245)
        Me.dgv_ConsDiarioN.MultiSelect = False
        Me.dgv_ConsDiarioN.Name = "dgv_ConsDiarioN"
        Me.dgv_ConsDiarioN.RowHeadersVisible = False
        Me.dgv_ConsDiarioN.Size = New System.Drawing.Size(901, 183)
        Me.dgv_ConsDiarioN.TabIndex = 274
        '
        'Btn_ImprimirMes
        '
        Me.Btn_ImprimirMes.BackColor = System.Drawing.Color.White
        Me.Btn_ImprimirMes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ImprimirMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ImprimirMes.ForeColor = System.Drawing.Color.Black
        Me.Btn_ImprimirMes.Image = CType(resources.GetObject("Btn_ImprimirMes.Image"), System.Drawing.Image)
        Me.Btn_ImprimirMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ImprimirMes.Location = New System.Drawing.Point(936, 54)
        Me.Btn_ImprimirMes.Name = "Btn_ImprimirMes"
        Me.Btn_ImprimirMes.Size = New System.Drawing.Size(73, 40)
        Me.Btn_ImprimirMes.TabIndex = 226
        Me.Btn_ImprimirMes.Text = "Imprimir"
        Me.Btn_ImprimirMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ImprimirMes.UseVisualStyleBackColor = False
        '
        'cmb_Mes
        '
        Me.cmb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Mes.FormattingEnabled = True
        Me.cmb_Mes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmb_Mes.Location = New System.Drawing.Point(919, 15)
        Me.cmb_Mes.Name = "cmb_Mes"
        Me.cmb_Mes.Size = New System.Drawing.Size(105, 24)
        Me.cmb_Mes.TabIndex = 273
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(901, 14)
        Me.Label8.TabIndex = 272
        Me.Label8.Text = "ADULTOS"
        '
        'dgv_ConsDiarioA
        '
        Me.dgv_ConsDiarioA.AllowUserToAddRows = False
        Me.dgv_ConsDiarioA.AllowUserToDeleteRows = False
        Me.dgv_ConsDiarioA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsDiarioA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsDiarioA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsDiarioA.Location = New System.Drawing.Point(12, 32)
        Me.dgv_ConsDiarioA.MultiSelect = False
        Me.dgv_ConsDiarioA.Name = "dgv_ConsDiarioA"
        Me.dgv_ConsDiarioA.RowHeadersVisible = False
        Me.dgv_ConsDiarioA.Size = New System.Drawing.Size(901, 179)
        Me.dgv_ConsDiarioA.TabIndex = 225
        '
        'TabMenCliente
        '
        Me.TabMenCliente.Controls.Add(Me.Label10)
        Me.TabMenCliente.Controls.Add(Me.Label11)
        Me.TabMenCliente.Controls.Add(Me.dgv_ConsumoN_cli)
        Me.TabMenCliente.Controls.Add(Me.dgv_ConsumoA_cli)
        Me.TabMenCliente.Location = New System.Drawing.Point(4, 25)
        Me.TabMenCliente.Name = "TabMenCliente"
        Me.TabMenCliente.Size = New System.Drawing.Size(1030, 443)
        Me.TabMenCliente.TabIndex = 3
        Me.TabMenCliente.Text = "     MENSUAL - CLIENTE    "
        Me.TabMenCliente.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(836, 14)
        Me.Label10.TabIndex = 276
        Me.Label10.Text = "NIÑOS"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(836, 14)
        Me.Label11.TabIndex = 275
        Me.Label11.Text = "ADULTOS"
        '
        'dgv_ConsumoN_cli
        '
        Me.dgv_ConsumoN_cli.AllowUserToAddRows = False
        Me.dgv_ConsumoN_cli.AllowUserToDeleteRows = False
        Me.dgv_ConsumoN_cli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsumoN_cli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsumoN_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsumoN_cli.Location = New System.Drawing.Point(12, 242)
        Me.dgv_ConsumoN_cli.MultiSelect = False
        Me.dgv_ConsumoN_cli.Name = "dgv_ConsumoN_cli"
        Me.dgv_ConsumoN_cli.RowHeadersVisible = False
        Me.dgv_ConsumoN_cli.Size = New System.Drawing.Size(836, 177)
        Me.dgv_ConsumoN_cli.TabIndex = 274
        '
        'dgv_ConsumoA_cli
        '
        Me.dgv_ConsumoA_cli.AllowUserToAddRows = False
        Me.dgv_ConsumoA_cli.AllowUserToDeleteRows = False
        Me.dgv_ConsumoA_cli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsumoA_cli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsumoA_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsumoA_cli.Location = New System.Drawing.Point(12, 28)
        Me.dgv_ConsumoA_cli.MultiSelect = False
        Me.dgv_ConsumoA_cli.Name = "dgv_ConsumoA_cli"
        Me.dgv_ConsumoA_cli.RowHeadersVisible = False
        Me.dgv_ConsumoA_cli.Size = New System.Drawing.Size(836, 186)
        Me.dgv_ConsumoA_cli.TabIndex = 273
        '
        'TabDiaCliente
        '
        Me.TabDiaCliente.Controls.Add(Me.Label12)
        Me.TabDiaCliente.Controls.Add(Me.dgv_ConsDiarioNCli)
        Me.TabDiaCliente.Controls.Add(Me.Label13)
        Me.TabDiaCliente.Controls.Add(Me.dgv_ConsDiarioACli)
        Me.TabDiaCliente.Location = New System.Drawing.Point(4, 25)
        Me.TabDiaCliente.Name = "TabDiaCliente"
        Me.TabDiaCliente.Size = New System.Drawing.Size(1030, 443)
        Me.TabDiaCliente.TabIndex = 4
        Me.TabDiaCliente.Text = "     DIARIO - CLIENTE     "
        Me.TabDiaCliente.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(997, 14)
        Me.Label12.TabIndex = 279
        Me.Label12.Text = "NIÑOS"
        '
        'dgv_ConsDiarioNCli
        '
        Me.dgv_ConsDiarioNCli.AllowUserToAddRows = False
        Me.dgv_ConsDiarioNCli.AllowUserToDeleteRows = False
        Me.dgv_ConsDiarioNCli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsDiarioNCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsDiarioNCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsDiarioNCli.Location = New System.Drawing.Point(11, 240)
        Me.dgv_ConsDiarioNCli.MultiSelect = False
        Me.dgv_ConsDiarioNCli.Name = "dgv_ConsDiarioNCli"
        Me.dgv_ConsDiarioNCli.RowHeadersVisible = False
        Me.dgv_ConsDiarioNCli.Size = New System.Drawing.Size(997, 183)
        Me.dgv_ConsDiarioNCli.TabIndex = 278
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(997, 14)
        Me.Label13.TabIndex = 277
        Me.Label13.Text = "ADULTOS"
        '
        'dgv_ConsDiarioACli
        '
        Me.dgv_ConsDiarioACli.AllowUserToAddRows = False
        Me.dgv_ConsDiarioACli.AllowUserToDeleteRows = False
        Me.dgv_ConsDiarioACli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv_ConsDiarioACli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsDiarioACli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ConsDiarioACli.Location = New System.Drawing.Point(11, 27)
        Me.dgv_ConsDiarioACli.MultiSelect = False
        Me.dgv_ConsDiarioACli.Name = "dgv_ConsDiarioACli"
        Me.dgv_ConsDiarioACli.RowHeadersVisible = False
        Me.dgv_ConsDiarioACli.Size = New System.Drawing.Size(997, 179)
        Me.dgv_ConsDiarioACli.TabIndex = 276
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
        Me.btn_Guardar.Location = New System.Drawing.Point(820, 38)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(105, 40)
        Me.btn_Guardar.TabIndex = 224
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'cmb_Anio
        '
        Me.cmb_Anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Anio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Anio.FormattingEnabled = True
        Me.cmb_Anio.Items.AddRange(New Object() {"2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmb_Anio.Location = New System.Drawing.Point(12, 57)
        Me.cmb_Anio.Name = "cmb_Anio"
        Me.cmb_Anio.Size = New System.Drawing.Size(90, 24)
        Me.cmb_Anio.TabIndex = 225
        '
        'frm_Tendencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1058, 564)
        Me.Controls.Add(Me.cmb_Anio)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.pic_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Tendencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Tendencia"
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_TendenciaN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabExistencia.ResumeLayout(False)
        CType(Me.dgv_Tendencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConsumo.ResumeLayout(False)
        CType(Me.dgv_CAnualTODO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_CAnualN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_CAnualA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ConsumoN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ConsumoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDatos.ResumeLayout(False)
        CType(Me.dgv_ConsDiarioN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ConsDiarioA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMenCliente.ResumeLayout(False)
        CType(Me.dgv_ConsumoN_cli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ConsumoA_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDiaCliente.ResumeLayout(False)
        CType(Me.dgv_ConsDiarioNCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ConsDiarioACli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents btn_imprimirA As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Calcular As System.Windows.Forms.Button
    Friend WithEvents dgv_TendenciaN As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabExistencia As System.Windows.Forms.TabPage
    Friend WithEvents btn_ssalir As System.Windows.Forms.Button
    Friend WithEvents TabConsumo As System.Windows.Forms.TabPage
    Friend WithEvents TabDatos As System.Windows.Forms.TabPage
    Friend WithEvents dgv_Tendencia As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_ConsumoN As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_ConsumoA As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_ConsDiarioA As System.Windows.Forms.DataGridView
    Friend WithEvents btn_CalcularN As System.Windows.Forms.Button
    Friend WithEvents btn_imprimirN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Anio As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_CAnualA As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_CAnualN As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv_CAnualTODO As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_ImprimirMes As System.Windows.Forms.Button
    Friend WithEvents cmb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgv_ConsDiarioN As System.Windows.Forms.DataGridView
    Friend WithEvents TabMenCliente As System.Windows.Forms.TabPage
    Friend WithEvents TabDiaCliente As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgv_ConsumoN_cli As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_ConsumoA_cli As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgv_ConsDiarioNCli As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgv_ConsDiarioACli As System.Windows.Forms.DataGridView
End Class
