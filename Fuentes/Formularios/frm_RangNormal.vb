'*************************************************************************
' Nombre:   frm_RangNormal
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para la asignar los rangos de normalidad de un test de un equipo
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2002
' Autores:  RFN
' Ultima Modificaci�n: 13/08/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Public Class frm_RangNormal
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
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Rango As System.Windows.Forms.Label
    Friend WithEvents lbl_Min As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_rango As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_TRango As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_Equipo As System.Windows.Forms.Label
    Friend WithEvents lbl_equipoD As System.Windows.Forms.Label
    Friend WithEvents lbl_Unidad As System.Windows.Forms.Label
    Friend WithEvents lbl_UniD As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_RangoInf As Ctl_txt.ctl_txt_numeros
    Friend WithEvents lbl_max As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_RangoSup As Ctl_txt.ctl_txt_numeros
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents lbl_esequipo As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_grupos As System.Windows.Forms.ComboBox
    Friend WithEvents txt_abrev As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_letra As System.Windows.Forms.TextBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents lbl_teq_id As System.Windows.Forms.Label
    Friend WithEvents txt_test As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgrd_Test As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grp_Test As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_rangosEdad As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgrd_testHijos As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RangNormal))
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.cmb_Tipo = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_RangoSup = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_RangoInf = New Ctl_txt.ctl_txt_numeros
        Me.lbl_Rango = New System.Windows.Forms.Label
        Me.lbl_Min = New System.Windows.Forms.Label
        Me.lbl_max = New System.Windows.Forms.Label
        Me.dgrd_testHijos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.grp_rango = New System.Windows.Forms.GroupBox
        Me.btn_rangosEdad = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_consultar = New System.Windows.Forms.Button
        Me.txt_letra = New System.Windows.Forms.TextBox
        Me.txt_abrev = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_grupos = New System.Windows.Forms.ComboBox
        Me.lbl_esequipo = New System.Windows.Forms.Label
        Me.lbl_UniD = New System.Windows.Forms.Label
        Me.lbl_Unidad = New System.Windows.Forms.Label
        Me.lbl_test = New System.Windows.Forms.Label
        Me.lbl_equipoD = New System.Windows.Forms.Label
        Me.rtb_TRango = New System.Windows.Forms.RichTextBox
        Me.lbl_Equipo = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.lbl_teq_id = New System.Windows.Forms.Label
        Me.txt_test = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgrd_Test = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.grp_Test = New System.Windows.Forms.GroupBox
        CType(Me.dgrd_testHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_rango.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Test.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tipo.ForeColor = System.Drawing.Color.Black
        Me.lbl_Tipo.Location = New System.Drawing.Point(26, 71)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Tipo.TabIndex = 27
        Me.lbl_Tipo.Text = "TIPO:"
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Tipo.Items.AddRange(New Object() {"No posee", "Unico", "Múltiple"})
        Me.cmb_Tipo.Location = New System.Drawing.Point(85, 67)
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(137, 21)
        Me.cmb_Tipo.TabIndex = 0
        '
        'Ctl_txt_RangoSup
        '
        Me.Ctl_txt_RangoSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_RangoSup.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_RangoSup.Location = New System.Drawing.Point(253, 166)
        Me.Ctl_txt_RangoSup.Name = "Ctl_txt_RangoSup"
        Me.Ctl_txt_RangoSup.Prp_Formato = True
        Me.Ctl_txt_RangoSup.Prp_NumDecimales = CType(3, Short)
        Me.Ctl_txt_RangoSup.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_RangoSup.Prp_ValDefault = "0"
        Me.Ctl_txt_RangoSup.Size = New System.Drawing.Size(66, 20)
        Me.Ctl_txt_RangoSup.TabIndex = 3
        '
        'Ctl_txt_RangoInf
        '
        Me.Ctl_txt_RangoInf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_RangoInf.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_RangoInf.Location = New System.Drawing.Point(131, 166)
        Me.Ctl_txt_RangoInf.Name = "Ctl_txt_RangoInf"
        Me.Ctl_txt_RangoInf.Prp_Formato = True
        Me.Ctl_txt_RangoInf.Prp_NumDecimales = CType(3, Short)
        Me.Ctl_txt_RangoInf.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_RangoInf.Prp_ValDefault = "0"
        Me.Ctl_txt_RangoInf.Size = New System.Drawing.Size(66, 20)
        Me.Ctl_txt_RangoInf.TabIndex = 2
        '
        'lbl_Rango
        '
        Me.lbl_Rango.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Rango.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Rango.ForeColor = System.Drawing.Color.Black
        Me.lbl_Rango.Location = New System.Drawing.Point(25, 170)
        Me.lbl_Rango.Name = "lbl_Rango"
        Me.lbl_Rango.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Rango.TabIndex = 33
        Me.lbl_Rango.Text = "RANGO:"
        '
        'lbl_Min
        '
        Me.lbl_Min.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Min.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Min.ForeColor = System.Drawing.Color.Black
        Me.lbl_Min.Location = New System.Drawing.Point(85, 170)
        Me.lbl_Min.Name = "lbl_Min"
        Me.lbl_Min.Size = New System.Drawing.Size(52, 16)
        Me.lbl_Min.TabIndex = 34
        Me.lbl_Min.Text = "Minimo:"
        '
        'lbl_max
        '
        Me.lbl_max.BackColor = System.Drawing.Color.Transparent
        Me.lbl_max.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_max.ForeColor = System.Drawing.Color.Black
        Me.lbl_max.Location = New System.Drawing.Point(204, 171)
        Me.lbl_max.Name = "lbl_max"
        Me.lbl_max.Size = New System.Drawing.Size(52, 16)
        Me.lbl_max.TabIndex = 35
        Me.lbl_max.Text = "Maximo:"
        '
        'dgrd_testHijos
        '
        Me.dgrd_testHijos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_testHijos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_testHijos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_testHijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_testHijos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_testHijos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testHijos.CaptionText = "PARAMETROS"
        Me.dgrd_testHijos.DataMember = ""
        Me.dgrd_testHijos.FlatMode = True
        Me.dgrd_testHijos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_testHijos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_testHijos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_testHijos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_testHijos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testHijos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_testHijos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_testHijos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testHijos.Location = New System.Drawing.Point(11, 310)
        Me.dgrd_testHijos.Name = "dgrd_testHijos"
        Me.dgrd_testHijos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_testHijos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_testHijos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_testHijos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_testHijos.Size = New System.Drawing.Size(893, 250)
        Me.dgrd_testHijos.TabIndex = 116
        Me.dgrd_testHijos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle2.DataGrid = Me.dgrd_testHijos
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16})
        Me.DataGridTableStyle2.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle2.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle2.MappingName = "Registros2"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.Yellow
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn3.MappingName = "tes_id"
        Me.DataGridTextBoxColumn3.Width = 60
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "NOMBRE"
        Me.DataGridTextBoxColumn4.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "ABREV"
        Me.DataGridTextBoxColumn5.MappingName = "teq_abrv_fija"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "EDAD"
        Me.DataGridTextBoxColumn6.MappingName = "teq_abreviatura"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 110
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "MINIMO"
        Me.DataGridTextBoxColumn7.MappingName = "teq_ranmin"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "MAXIMO"
        Me.DataGridTextBoxColumn8.MappingName = "teq_ranmax"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "MULTIPLE"
        Me.DataGridTextBoxColumn9.MappingName = "teq_ranmul"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 120
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "UNIDAD"
        Me.DataGridTextBoxColumn11.MappingName = "UNI_NOMENCLATURA"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 70
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "TEQID"
        Me.DataGridTextBoxColumn12.MappingName = "teq_id"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "TIPO"
        Me.DataGridTextBoxColumn13.MappingName = "TEQ_TRANGO"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn10.MappingName = "tes_ordenimp"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "EQUID"
        Me.DataGridTextBoxColumn14.MappingName = "equ_id"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "UNI_ID"
        Me.DataGridTextBoxColumn15.MappingName = "UNI_ID"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "LIS"
        Me.DataGridTextBoxColumn16.MappingName = "TES_LIS"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 0
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
        Me.btn_Salir.Location = New System.Drawing.Point(424, 19)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(81, 33)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(184, 19)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(81, 33)
        Me.btn_Aceptar.TabIndex = 2
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'grp_rango
        '
        Me.grp_rango.BackColor = System.Drawing.Color.Transparent
        Me.grp_rango.Controls.Add(Me.btn_rangosEdad)
        Me.grp_rango.Controls.Add(Me.btn_eliminar)
        Me.grp_rango.Controls.Add(Me.btn_nuevo)
        Me.grp_rango.Controls.Add(Me.btn_consultar)
        Me.grp_rango.Controls.Add(Me.btn_Salir)
        Me.grp_rango.Controls.Add(Me.btn_Aceptar)
        Me.grp_rango.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_rango.ForeColor = System.Drawing.Color.Navy
        Me.grp_rango.Location = New System.Drawing.Point(14, 31)
        Me.grp_rango.Name = "grp_rango"
        Me.grp_rango.Size = New System.Drawing.Size(522, 64)
        Me.grp_rango.TabIndex = 0
        Me.grp_rango.TabStop = False
        '
        'btn_rangosEdad
        '
        Me.btn_rangosEdad.BackColor = System.Drawing.SystemColors.Control
        Me.btn_rangosEdad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_rangosEdad.Enabled = False
        Me.btn_rangosEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rangosEdad.ForeColor = System.Drawing.Color.Black
        Me.btn_rangosEdad.Image = CType(resources.GetObject("btn_rangosEdad.Image"), System.Drawing.Image)
        Me.btn_rangosEdad.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_rangosEdad.Location = New System.Drawing.Point(343, 19)
        Me.btn_rangosEdad.Name = "btn_rangosEdad"
        Me.btn_rangosEdad.Size = New System.Drawing.Size(81, 33)
        Me.btn_rangosEdad.TabIndex = 112
        Me.btn_rangosEdad.Text = "Grupos"
        Me.btn_rangosEdad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rangosEdad.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(102, 19)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(81, 33)
        Me.btn_eliminar.TabIndex = 111
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(21, 19)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 33)
        Me.btn_nuevo.TabIndex = 104
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_consultar
        '
        Me.btn_consultar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar.ForeColor = System.Drawing.Color.Black
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_consultar.Location = New System.Drawing.Point(263, 19)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(81, 33)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Imprimir"
        Me.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_consultar.UseVisualStyleBackColor = False
        '
        'txt_letra
        '
        Me.txt_letra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_letra.Enabled = False
        Me.txt_letra.Location = New System.Drawing.Point(158, 118)
        Me.txt_letra.MaxLength = 8
        Me.txt_letra.Name = "txt_letra"
        Me.txt_letra.Size = New System.Drawing.Size(38, 21)
        Me.txt_letra.TabIndex = 109
        '
        'txt_abrev
        '
        Me.txt_abrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_abrev.Location = New System.Drawing.Point(86, 118)
        Me.txt_abrev.MaxLength = 8
        Me.txt_abrev.Name = "txt_abrev"
        Me.txt_abrev.Size = New System.Drawing.Size(69, 21)
        Me.txt_abrev.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "ABREV"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "GRUPO:"
        '
        'cmb_grupos
        '
        Me.cmb_grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_grupos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_grupos.Items.AddRange(New Object() {"MUJER", "MUJER 12-18 AÑOS", "MUJER 18-49 AÑOS", "HOMBRE", "HOMBRE 12-18 AÑOS", "HOMBRE 18-49 AÑOS", "NIÑO", "RN", "RN PARTO", "RN 1-3 DIAS", "RN 1 SEMANA", "RN 2 SEMANAS", "RN 1 MES", "RN 2 MESES", "RN 3-6 MESES", "RN 0.5-2 AÑOS", "RN 2-6 AÑOS"})
        Me.cmb_grupos.Location = New System.Drawing.Point(85, 42)
        Me.cmb_grupos.Name = "cmb_grupos"
        Me.cmb_grupos.Size = New System.Drawing.Size(137, 21)
        Me.cmb_grupos.TabIndex = 105
        '
        'lbl_esequipo
        '
        Me.lbl_esequipo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_esequipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_esequipo.ForeColor = System.Drawing.Color.White
        Me.lbl_esequipo.Location = New System.Drawing.Point(256, 98)
        Me.lbl_esequipo.Name = "lbl_esequipo"
        Me.lbl_esequipo.Size = New System.Drawing.Size(86, 16)
        Me.lbl_esequipo.TabIndex = 103
        Me.lbl_esequipo.Text = "TPROCES"
        Me.lbl_esequipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_UniD
        '
        Me.lbl_UniD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UniD.ForeColor = System.Drawing.Color.Black
        Me.lbl_UniD.Location = New System.Drawing.Point(86, 147)
        Me.lbl_UniD.Name = "lbl_UniD"
        Me.lbl_UniD.Size = New System.Drawing.Size(126, 14)
        Me.lbl_UniD.TabIndex = 44
        '
        'lbl_Unidad
        '
        Me.lbl_Unidad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Unidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Unidad.ForeColor = System.Drawing.Color.Black
        Me.lbl_Unidad.Location = New System.Drawing.Point(25, 148)
        Me.lbl_Unidad.Name = "lbl_Unidad"
        Me.lbl_Unidad.Size = New System.Drawing.Size(62, 14)
        Me.lbl_Unidad.TabIndex = 43
        Me.lbl_Unidad.Text = "UNIDAD:"
        '
        'lbl_test
        '
        Me.lbl_test.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test.ForeColor = System.Drawing.Color.Navy
        Me.lbl_test.Location = New System.Drawing.Point(24, 17)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(295, 19)
        Me.lbl_test.TabIndex = 42
        '
        'lbl_equipoD
        '
        Me.lbl_equipoD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_equipoD.ForeColor = System.Drawing.Color.Black
        Me.lbl_equipoD.Location = New System.Drawing.Point(88, 96)
        Me.lbl_equipoD.Name = "lbl_equipoD"
        Me.lbl_equipoD.Size = New System.Drawing.Size(162, 19)
        Me.lbl_equipoD.TabIndex = 41
        Me.lbl_equipoD.Visible = False
        '
        'rtb_TRango
        '
        Me.rtb_TRango.AutoWordSelection = True
        Me.rtb_TRango.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_TRango.Location = New System.Drawing.Point(85, 189)
        Me.rtb_TRango.MaxLength = 1024
        Me.rtb_TRango.Name = "rtb_TRango"
        Me.rtb_TRango.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtb_TRango.Size = New System.Drawing.Size(257, 77)
        Me.rtb_TRango.TabIndex = 1
        Me.rtb_TRango.Text = ""
        '
        'lbl_Equipo
        '
        Me.lbl_Equipo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Equipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Equipo.ForeColor = System.Drawing.Color.Black
        Me.lbl_Equipo.Location = New System.Drawing.Point(26, 98)
        Me.lbl_Equipo.Name = "lbl_Equipo"
        Me.lbl_Equipo.Size = New System.Drawing.Size(60, 14)
        Me.lbl_Equipo.TabIndex = 39
        Me.lbl_Equipo.Text = "EQUIPO:"
        Me.lbl_Equipo.Visible = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Controls.Add(Me.pic_barra)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(923, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(5, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(225, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "RANGOS DE NORMALIDAD"
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(923, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 91
        Me.pic_barra.TabStop = False
        '
        'lbl_teq_id
        '
        Me.lbl_teq_id.AutoSize = True
        Me.lbl_teq_id.Location = New System.Drawing.Point(506, 377)
        Me.lbl_teq_id.Name = "lbl_teq_id"
        Me.lbl_teq_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_teq_id.TabIndex = 112
        '
        'txt_test
        '
        Me.txt_test.BackColor = System.Drawing.Color.LightGreen
        Me.txt_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_test.Location = New System.Drawing.Point(134, 104)
        Me.txt_test.Name = "txt_test"
        Me.txt_test.Size = New System.Drawing.Size(381, 21)
        Me.txt_test.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "BUSCAR TEST:"
        '
        'dgrd_Test
        '
        Me.dgrd_Test.AllowNavigation = False
        Me.dgrd_Test.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Test.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Test.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Test.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Test.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Test.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.CaptionText = "TEST DISPONIBLES"
        Me.dgrd_Test.DataMember = ""
        Me.dgrd_Test.FlatMode = True
        Me.dgrd_Test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Test.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Test.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Test.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.Location = New System.Drawing.Point(11, 131)
        Me.dgrd_Test.Name = "dgrd_Test"
        Me.dgrd_Test.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Test.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.PreferredColumnWidth = 95
        Me.dgrd_Test.ReadOnly = True
        Me.dgrd_Test.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Test.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Test.Size = New System.Drawing.Size(526, 173)
        Me.dgrd_Test.TabIndex = 118
        Me.dgrd_Test.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Test.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Test
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "tes_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridTextBoxColumn2.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 300
        '
        'grp_Test
        '
        Me.grp_Test.Controls.Add(Me.cmb_grupos)
        Me.grp_Test.Controls.Add(Me.cmb_Tipo)
        Me.grp_Test.Controls.Add(Me.txt_abrev)
        Me.grp_Test.Controls.Add(Me.lbl_Equipo)
        Me.grp_Test.Controls.Add(Me.lbl_Tipo)
        Me.grp_Test.Controls.Add(Me.lbl_esequipo)
        Me.grp_Test.Controls.Add(Me.Ctl_txt_RangoSup)
        Me.grp_Test.Controls.Add(Me.lbl_equipoD)
        Me.grp_Test.Controls.Add(Me.Ctl_txt_RangoInf)
        Me.grp_Test.Controls.Add(Me.lbl_test)
        Me.grp_Test.Controls.Add(Me.Label2)
        Me.grp_Test.Controls.Add(Me.txt_letra)
        Me.grp_Test.Controls.Add(Me.lbl_max)
        Me.grp_Test.Controls.Add(Me.lbl_UniD)
        Me.grp_Test.Controls.Add(Me.Label3)
        Me.grp_Test.Controls.Add(Me.rtb_TRango)
        Me.grp_Test.Controls.Add(Me.lbl_Rango)
        Me.grp_Test.Controls.Add(Me.lbl_Min)
        Me.grp_Test.Controls.Add(Me.lbl_Unidad)
        Me.grp_Test.Location = New System.Drawing.Point(543, 32)
        Me.grp_Test.Name = "grp_Test"
        Me.grp_Test.Size = New System.Drawing.Size(361, 272)
        Me.grp_Test.TabIndex = 120
        Me.grp_Test.TabStop = False
        '
        'frm_RangNormal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(923, 572)
        Me.Controls.Add(Me.grp_Test)
        Me.Controls.Add(Me.txt_test)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgrd_Test)
        Me.Controls.Add(Me.dgrd_testHijos)
        Me.Controls.Add(Me.lbl_teq_id)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.grp_rango)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_RangNormal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rangos de Normalidad"
        CType(Me.dgrd_testHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_rango.ResumeLayout(False)
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Test.ResumeLayout(False)
        Me.grp_Test.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Dim sw As String = Nothing

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp, pic_barra.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseMove, pic_barra.MouseMove
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

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseDown, pic_barra.MouseDown
        'Funci�n para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub


    Private Sub Formulario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'elimina la referecnia del formulario del MDI
        ClickMenu_Principal(Me)
        RemoveCtxMenu_Principal(Me, Me.Text)
    End Sub


#End Region

    Dim opr_equipos As New Cls_equipos()
    Dim opr_areas As New Cls_Areas()
    Dim opr_pedido As New Cls_Pedido()
    'Dim dtv_test As New DataView()
    Dim letra As String = Nothing

    Dim dtt_test As New DataTable("Registros")
    Dim opr_convenio As New Cls_Convenio()
    Dim dtv_test As New DataView(dtt_test)
    Dim opr_Test As New Cls_TipoTest()
    Public frm_refer_main As Frm_Main
    Dim int_codigo As Integer
    Dim dtv_testHijos As New DataView()



    Private Sub frm_RangNormal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '''LO SIGUIENTE PARA PROD
        '''opr_pedido.LlenarcomboGrupos(cmb_grupos, 1)
        '''LO SIGUIENTE PARA PROD


        dgrd_Test.DataSource = dtv_test
        opr_Test.LlenarGridtest(dtv_test, True)

        'dgrd_RangNormal.SetDataBinding(opr_equipos.LeerTestEquipos(), "Registros")
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub cmb_Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipo.SelectedIndexChanged
        If (cmb_Tipo.SelectedIndex = 1) Then   ' Unico
            rtb_TRango.Visible = False
            Ctl_txt_RangoInf.Visible = True
            Ctl_txt_RangoSup.Visible = True
            lbl_max.Visible = True
            lbl_Min.Visible = True
            Ctl_txt_RangoInf.Focus()
        End If
        If (cmb_Tipo.SelectedIndex = 2) Then   '  Multiple
            rtb_TRango.Visible = True
            Ctl_txt_RangoInf.Visible = False
            Ctl_txt_RangoSup.Visible = False
            lbl_max.Visible = False
            lbl_Min.Visible = False
            rtb_TRango.Focus()
        End If
        If (cmb_Tipo.SelectedIndex = 0) Then   '  No posee
            rtb_TRango.Visible = False
            Ctl_txt_RangoInf.Visible = False
            Ctl_txt_RangoSup.Visible = False
            lbl_max.Visible = False
            lbl_Min.Visible = False
            rtb_TRango.Focus()
        End If
    End Sub

    Private Sub dgrd_RangNormal_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' ''dgrd_RangNormal.Select(dgrd_RangNormal.CurrentCell.RowNumber)
        ' ''btn_Aceptar.Enabled = True
        ' ''grp_rango.Enabled = True
        ' ''Dim espacio As Integer = 1

        ' ''Call LimpiarCamposRangos(CInt(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 5)))
        '' ''Almaceno el c�digo del test (tag) y presento el nombre del test
        ' ''lbl_TestD.Tag = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 1)
        ' ''lbl_TestD.Text = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 2)
        '' ''Almaceno el c�digo del equipo (tag) y presento el nombre del mismo
        ' ''lbl_equipoD.Tag = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 3)
        ' ''lbl_equipoD.Text = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 4)
        ' ''If dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 3) <> 6 Then
        ' ''    lbl_esequipo.Text = "equipo"
        ' ''Else
        ' ''    lbl_esequipo.Text = "MANUAL"
        ' ''End If

        ' ''cmb_generos.Text = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 12)
        ' ''cmb_generos.Enabled = True

        '' ''Almaceno el c�digo de la �nidad por defecto del test en el equipo y presento su nomenclatura
        ' ''lbl_UniD.Tag = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 5)
        ' ''lbl_UniD.Text = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 6)
        ' ''lbl_test.Tag = dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 12)


        ' ''If cmb_generos.Text = "MUJER" Then
        ' ''    espacio = 0
        ' ''    txt_letra.Text = ""

        ' ''Else

        ' ''    If cmb_generos.Text = "RN" Then
        ' ''        espacio = 2
        ' ''        txt_letra.Text = cmb_generos.Text

        ' ''    Else
        ' ''        espacio = 1
        ' ''        txt_letra.Text = Mid(cmb_generos.Text, 1, 1)

        ' ''    End If
        ' ''End If
        '' ''txt_abrev.Text = Mid(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 12), 1, Len(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 12)) - espacio)
        ' ''txt_abrev.Text = Trim(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 15))
        ' ''txt_abrev.Enabled = False

        ' ''lbl_teq_id.Text = (dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 14))
        '' ''El tipo de rango de normalidad que posee
        ' ''cmb_Tipo.SelectedIndex = CInt(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 8))
        ' ''If (cmb_Tipo.SelectedIndex = 1) Then  'Unico 
        ' ''    Ctl_txt_RangoInf.texto_Asigna(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 9).ToString())
        ' ''    Ctl_txt_RangoSup.texto_Asigna(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 10).ToString())
        ' ''End If
        ' ''If (cmb_Tipo.SelectedIndex = 2) Then  'Multiple
        ' ''    rtb_TRango.Text = (dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 11).ToString())
        ' ''End If
        ' ''If (cmb_Tipo.SelectedIndex = 0) Then    'No posee
        ' ''    rtb_TRango.Text = ""
        ' ''    Ctl_txt_RangoInf.texto_Asigna("")
        ' ''    Ctl_txt_RangoSup.texto_Asigna("")
        ' ''End If
        ' ''btn_Aceptar.Enabled = True
        ' ''Dim dgc_celda As DataGridCell
        ' ''dgc_celda.ColumnNumber = 0
        ' ''dgc_celda.RowNumber = dgrd_RangNormal.CurrentCell.RowNumber
        ' ''dgrd_RangNormal.CurrentCell = dgc_celda
        ' ''dgrd_RangNormal.Select(dgrd_RangNormal.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click

        If txt_letra.Text = "RN" Then
            letra = "R"
        Else
            letra = Trim(txt_letra.Text)
        End If

        If sw <> "nuevo" Then
            'ACTUALIZO RANGO unico
            If (cmb_Tipo.SelectedIndex = 1 And cmb_Tipo.Text = "Unico") Then
                'En caso de haber seleccionado rango Unico
                If (Ctl_txt_RangoInf.texto_Recupera = "" Or Ctl_txt_RangoSup.texto_Recupera = "") Then
                    MsgBox("Los dos limites del Rango de Normalidad son requeridos", MsgBoxStyle.Exclamation, "ANALISYS")
                    Ctl_txt_RangoInf.Focus()
                    Exit Sub
                End If
                If (CDbl(Ctl_txt_RangoInf.texto_Recupera) >= CDbl(Ctl_txt_RangoSup.texto_Recupera)) Then
                    MsgBox("El limite inferior del Rango de Normalidad" & ControlChars.CrLf & "no puede ser mayor al Rango Superior", MsgBoxStyle.Exclamation, "ANALISYS")
                    Ctl_txt_RangoInf.Focus()
                    Exit Sub
                End If

                opr_equipos.ActualizaRangoU_TestEquipos(CInt(lbl_equipoD.Tag), CInt(lbl_test.Tag), cmb_Tipo.SelectedIndex, CDbl(Ctl_txt_RangoInf.texto_Recupera), CDbl(Ctl_txt_RangoSup.texto_Recupera), Trim(txt_abrev.Text) & letra, Trim(cmb_grupos.Text))
                'dgrd_testHijos.DataSource = dtv_testHijos
                opr_Test.LlenarGridtestRangos(CInt(lbl_test.Tag), dtv_testHijos)

                Call LimpiarCamposRangos(1)
                btn_Salir.Enabled = True
            Else
                'ACTUALIZO RANGO MULTIPLE
                'If (rtb_TRango.Text = "") Then
                '    MsgBox("La tabla de Rangos de Normalidad debe ser ingresada", MsgBoxStyle.Exclamation, "ANALISYS")
                '    rtb_TRango.Focus()
                '    Exit Sub
                'End If
                opr_equipos.ActualizaRangoM_TestEquipos(CInt(lbl_equipoD.Text), CInt(lbl_test.Tag), cmb_Tipo.SelectedIndex, rtb_TRango.Text, Trim(cmb_grupos.Text), CInt(lbl_teq_id.Text))
                'dgrd_testHijos.DataSource = dtv_testHijos
                opr_Test.LlenarGridtestRangos(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)

                Call LimpiarCamposRangos(2)
                btn_Salir.Enabled = True
            End If
            'MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
            'Call LimpiarCamposRangos()

            'grp_rango.Enabled = False
            'btn_Aceptar.Enabled = False
            '''''''dgrd_RangNormal.SetDataBinding(opr_equipos.LeerTestEquipos(), "Registros")
            'opr_equipos.LeerTestEquipos(dtv_test)

        Else
            If sw = "nuevo" Then
                If (cmb_Tipo.SelectedIndex = 1 And cmb_Tipo.Text = "Unico") Then
                    If (Ctl_txt_RangoInf.texto_Recupera = "" Or Ctl_txt_RangoSup.texto_Recupera = "") Then
                        MsgBox("Los dos limites del Rango de Normalidad son requeridos", MsgBoxStyle.Exclamation, "ANALISYS")
                        Ctl_txt_RangoInf.Focus()
                        Exit Sub
                    End If
                    If (CDbl(Ctl_txt_RangoInf.texto_Recupera) >= CDbl(Ctl_txt_RangoSup.texto_Recupera)) Then
                        MsgBox("El limite inferior del Rango de Normalidad" & ControlChars.CrLf & "no puede ser mayor al Rango Superior", MsgBoxStyle.Exclamation, "ANALISYS")
                        Ctl_txt_RangoInf.Focus()
                        Exit Sub
                    End If

                    If (txt_abrev.Text = "") Then
                        MsgBox("La abreviatura es obligatorio", MsgBoxStyle.Exclamation, "ANALISYS")
                        txt_abrev.Focus()
                        Exit Sub
                    End If

                    'opr_equipos.InsertaRangoU_TestEquipos(CInt(lbl_equipoD.Tag), CInt(lbl_TestD.Tag), cmb_Tipo.SelectedIndex, rtb_TRango.Text, lbl_test.Tag)
                    opr_equipos.GuardarRangoU_TestEquipos(CInt(lbl_equipoD.Text), CInt(lbl_test.Tag), cmb_Tipo.SelectedIndex, CDbl(Ctl_txt_RangoInf.texto_Recupera), CDbl(Ctl_txt_RangoSup.texto_Recupera), Trim(txt_abrev.Text) & letra, letra, lbl_UniD.Tag, opr_equipos.LeerMaxCodEquiTest() + 1)
                    If opr_equipos.VerificaTestResultado(CInt(lbl_test.Tag)) = False Then
                        opr_equipos.GuardarTestResultado(CInt(lbl_test.Tag), 1, cmb_Tipo.SelectedIndex)

                    End If
                    'dgrd_testHijos.DataSource = dtv_testHijos
                    opr_Test.LlenarGridtestRangos(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)

                    Call LimpiarCamposRangos(1)
                Else
                    'INGRESO RANGO MULTIPLE
                    'ACTUALIZO RANGO MULTIPLE
                    If (rtb_TRango.Text = "") Then
                        MsgBox("La tabla de Rangos de Normalidad debe ser ingresada", MsgBoxStyle.Exclamation, "ANALISYS")
                        rtb_TRango.Focus()
                        Exit Sub
                    End If
                    opr_equipos.GuardarRangoM_TestEquipos(CInt(lbl_equipoD.Text), CInt(lbl_test.Tag), cmb_Tipo.SelectedIndex, rtb_TRango.Text, Trim(cmb_grupos.Text), lbl_UniD.Tag, Trim(txt_abrev.Text) & letra, opr_equipos.LeerMaxCodEquiTest() + 1)
                    'dgrd_testHijos.DataSource = dtv_testHijos
                    opr_Test.LlenarGridtestRangos(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)

                    Call LimpiarCamposRangos(2)
                End If

            End If
        End If
        'opr_Test.ActualizarTest(int_codigo, str_area, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_Tipo.Text, CInt(Mid(cmb_Padre.Text, 100, 10)), AB, calc, Trim(txt_ValDefecto.Text), Val(cmb_equip.Text.Substring(50, 5)), Trim(txt_abrev.Text), lbl_abrev.Tag)
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Call LimpiarCamposRangos()



        btn_Aceptar.Enabled = False

        '''''''dgrd_RangNormal.SetDataBinding(opr_equipos.LeerTestEquipos(), "Registros")
        '''''''opr_equipos.LeerTestEquipos(dtv_test)
        'opr_Test.LlenarGridtest(dtv_test, True)
        btn_Salir.Enabled = True
        grp_rango.Enabled = False

    End Sub

    Public Sub LimpiarCamposRangos(ByRef para As Short)
        txt_test.Text = ""
        lbl_test.Text = ""
        lbl_equipoD.Text = ""
        'cmb_Tipo.Text = "Unico"
        lbl_UniD.Text = ""
        lbl_test.Tag = ""
        lbl_teq_id.Text = ""
        If para = 0 Then   'No posee
            'rtb_TRango.Visible = False
            rtb_TRango.Text = ""
            Ctl_txt_RangoInf.texto_Asigna("")
            Ctl_txt_RangoSup.texto_Asigna("")
        End If
        If para = 2 Then   'Multiple
            rtb_TRango.Text = ""
            rtb_TRango.Visible = True
            Ctl_txt_RangoInf.Visible = False
            Ctl_txt_RangoSup.Visible = False
        End If
        If para = 1 Then     'Unico
            'rtb_TRango.Visible = False
            Ctl_txt_RangoInf.texto_Asigna("")
            rtb_TRango.Text = ""
            Ctl_txt_RangoSup.texto_Asigna("")
            Ctl_txt_RangoInf.Visible = True
            Ctl_txt_RangoSup.Visible = True
            rtb_TRango.Visible = False
            txt_abrev.Text = ""
            txt_abrev.Enabled = False
        End If
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_RangosNormalidad()
        str_sql = "SELECT TEST_EQUIPO.TES_ID as testId, TEST.TES_NOMBRE as testNombre, TEST_EQUIPO.EQU_ID as equiId, EQUIPO.EQU_MODELO as equiMod, TEST_EQUIPO.UNI_ID as uniId, UNIDAD.UNI_NOMENCLATURA as uniNom, TEST_EQUIPO.TEQ_ESTADO as testEst, TEST_EQUIPO.TEQ_TRANGO as testTRango, TEST_EQUIPO.TEQ_RANMIN as testRanMin, TEST_EQUIPO.TEQ_RANMAX as testRanMax, TEST_EQUIPO.TEQ_RANMUL as testRanMul FROM UNIDAD INNER JOIN (TEST INNER JOIN (EQUIPO INNER JOIN TEST_EQUIPO ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) ON TEST.TES_ID = TEST_EQUIPO.TES_ID) ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID order by TEST.TES_NOMBRE"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Rangos de Normalidad"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub




    Private Sub txt_test_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        opr_equipos.ordena_RangNormal(txt_test.Text, dtv_test)
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        sw = "nuevo"
        'txt_abrev.Enabled = True
        cmb_grupos.Enabled = True
        'txt_abrev.Enabled = True
        'txt_abrev.Text = ""
        Ctl_txt_RangoInf.texto_Asigna("")
        Ctl_txt_RangoSup.texto_Asigna("")
        rtb_TRango.Text = ""
        cmb_Tipo.Focus()

    End Sub


    Private Sub cmb_generos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_grupos.SelectedIndexChanged

        Select Case cmb_grupos.Text
            Case "HOMBRE" : letra = "H"
            Case "HOMBRE 12-18 AÑOS" : letra = "H1"
            Case "HOMBRE 18-49 AÑOS" : letra = "H2"


            Case "NIÑO" : letra = "N"
            Case "RN" : letra = "RN"

            Case "RN PARTO" : letra = "R1"
            Case "RN 1-3 DIAS" : letra = "R2"
            Case "RN 1 SEMANA" : letra = "R3"
            Case "RN 2 SEMANAS" : letra = "R4"
            Case "RN 1 MES" : letra = "R5"
            Case "RN 2 MESES" : letra = "R6"
            Case "RN 3-6 MESES" : letra = "R7"
            Case "RN 0.5-2 AÑOS" : letra = "R8"
            Case "RN 2-6 AÑOS" : letra = "R9"

            Case "MUJER" : letra = ""
            Case "MUJER 12-18 AÑOS" : letra = "M1"
            Case "MUJER 18-49 AÑOS" : letra = "M2"


        End Select
        txt_letra.Text = letra
    End Sub





    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        If MsgBox("Desea eliminar el rango de normalidad ? ", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then


            opr_equipos.Elimina_TestEquipos(CInt(lbl_teq_id.Text))
            'opr_equipos.LeerTestEquipos(dtv_test)
            opr_Test.LlenarGridtest(dtv_test, True)
        End If

    End Sub



    Private Sub cmb_area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim filtro_rbt As Boolean
        filtro_rbt = True
        opr_Test.LlenarGridtest(dtv_test, filtro_rbt)

    End Sub


    Private Sub dgrd_Test_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Test.CurrentCellChanged
        dgrd_testHijos.DataSource = dtv_testHijos
        opr_Test.LlenarGridtestRangos(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)
    End Sub

    Private Sub txt_test_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_test.TextChanged
        opr_Test.ordena_test(txt_test.Text, dtv_test)
    End Sub

    Private Sub dgrd_testHijos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_testHijos.CurrentCellChanged
        dgrd_testHijos.Select(dgrd_testHijos.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        grp_rango.Enabled = True
        Dim espacio As Integer = 1

        'Call LimpiarCamposRangos(CInt(dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 9)))
        'Almaceno el codigo del test (tag) y presento el nombre del test
        lbl_test.Tag = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 0)
        lbl_test.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 2)
        'Almaceno el codigo del equipo (tag) y presento el nombre del mismo
        lbl_equipoD.Tag = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 8)
        lbl_equipoD.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 11)


        'MUJER
        'MUJER 12-18 AÑOS
        'MUJER 18-49 AÑOS
        'HOMBRE
        'HOMBRE 12-18 AÑOS
        'HOMBRE 18-49 AÑOS
        'NIÑO
        'RN
        'RN PARTO
        'RN 1-3 DIAS
        'RN 1 SEMANA
        'RN 2 SEMANAS
        'RN 1 MES
        'RN 2 MESES
        'RN 3-6 MESES
        'RN 0.5-2 AÑOS
        'RN 2-6 AÑOS

        cmb_grupos.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 3)
        Select Case dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 3)

            Case "H1" : cmb_grupos.Text = "HOMBRE 12-18 AÑOS"
            Case "H2" : cmb_grupos.Text = "HOMBRE 18-49 AÑOS"

            Case "M1" : cmb_grupos.Text = "MUJER 12-18 AÑOS"
            Case "M2" : cmb_grupos.Text = "MUJER 18-49 AÑOS"

            Case "R1" : cmb_grupos.Text = "RN PARTO"
            Case "R2" : cmb_grupos.Text = "RN 1-3 DIAS"
            Case "R3" : cmb_grupos.Text = "RN 1 SEMANA"
            Case "R4" : cmb_grupos.Text = "RN 2 SEMANAS"
            Case "R5" : cmb_grupos.Text = "RN 1 MES"
            Case "R6" : cmb_grupos.Text = "RN 2 MESES"
            Case "R7" : cmb_grupos.Text = "RN 3-6 MESES"
            Case "R8" : cmb_grupos.Text = "RN 0.5-2 AÑOS"
            Case "R9" : cmb_grupos.Text = "RN 2-6 AÑOS"

        End Select

        cmb_grupos.Enabled = True

        'Almaceno el codigo de la unidad por defecto del test en el equipo y presento su nomenclatura
        lbl_UniD.Tag = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 12)
        lbl_UniD.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 7)


        ''If cmb_grupos.Text = "MUJER" Then
        ''    espacio = 0
        ''    txt_letra.Text = ""

        ''Else

        ''    If cmb_grupos.Text = "RN" Then
        ''        espacio = 2
        ''        txt_letra.Text = cmb_grupos.Text

        ''    Else
        ''        espacio = 1
        ''        txt_letra.Text = Mid(cmb_grupos.Text, 1, 1)

        ''    End If
        ''End If
        'txt_abrev.Text = Mid(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 11), 1, Len(dgrd_RangNormal.Item(dgrd_RangNormal.CurrentCell.RowNumber, 12)) - espacio)
        txt_abrev.Text = Trim(dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 13))
        txt_abrev.Enabled = False

        lbl_teq_id.Text = (dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 8))
        'El tipo de rango de normalidad que posee
        cmb_Tipo.SelectedIndex = CInt(dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 9))
        If (cmb_Tipo.SelectedIndex = 1) Then  'Unico 
            Ctl_txt_RangoInf.texto_Asigna(dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 4).ToString())
            Ctl_txt_RangoSup.texto_Asigna(dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 5).ToString())
        End If
        If (cmb_Tipo.SelectedIndex = 2) Then  'Multiple
            rtb_TRango.Text = (dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 6).ToString())
        End If
        If (cmb_Tipo.SelectedIndex = 0) Then    'No posee
            rtb_TRango.Text = ""
            Ctl_txt_RangoInf.texto_Asigna("")
            Ctl_txt_RangoSup.texto_Asigna("")
        End If
        btn_Aceptar.Enabled = True
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = dgrd_testHijos.CurrentCell.RowNumber
        dgrd_testHijos.CurrentCell = dgc_celda
        dgrd_testHijos.Select(dgrd_testHijos.CurrentCell.RowNumber)
    End Sub

    
End Class
