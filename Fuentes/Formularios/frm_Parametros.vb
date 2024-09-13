'*************************************************************************
' Nombre:   frm_Parametros
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para la administracion (Crear, actualizar, mod)
'               Unidades, Tipos de tubos y tipos de muestras 
' Autores:  RFN
' Fecha de Creaci�n: Julio del 2002
' Autores:  RFN
' Ultima Modificaci�n: 30/07/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System.Data


Public Class frm_Parametros
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
    Friend WithEvents dgrd_Unidades As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txt_tubCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Tab_Parametros As System.Windows.Forms.TabControl
    Friend WithEvents dgrdTipTubos As System.Windows.Forms.DataGrid
    Friend WithEvents txt_TubNom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NomMue As System.Windows.Forms.Label
    Friend WithEvents txt_CodMue As System.Windows.Forms.TextBox
    Friend WithEvents Ctl_txt_nomMue As Ctl_txt.ctl_txt_letras
    Friend WithEvents dgrdTipMuestra As System.Windows.Forms.DataGrid
    Friend WithEvents Ctl_txt_nomUni As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_aditivo As System.Windows.Forms.Label
    Friend WithEvents btn_AceptarUni As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_NuevoUni As System.Windows.Forms.Button
    Friend WithEvents lbl_Sistema As System.Windows.Forms.Label
    Friend WithEvents lbl_nomenclatura As System.Windows.Forms.Label
    Friend WithEvents cmb_sistema_uni As System.Windows.Forms.ComboBox
    Friend WithEvents txt_CodUni As System.Windows.Forms.TextBox
    Friend WithEvents btn_CancelarUni As System.Windows.Forms.Button
    Friend WithEvents btn_NuevoMue As System.Windows.Forms.Button
    Friend WithEvents btn_AceptarMue As System.Windows.Forms.Button
    Friend WithEvents btn_eliminarMue As System.Windows.Forms.Button
    Friend WithEvents btn_CancelarMue As System.Windows.Forms.Button
    Friend WithEvents lbl_ObsTipMue As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_desMue As System.Windows.Forms.TextBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminarTub As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_Obs As System.Windows.Forms.Label
    Friend WithEvents grp_TipTubo As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_TipTubo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_ObsTipTubo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grp_Uni As System.Windows.Forms.GroupBox
    Friend WithEvents grp_TipMue As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    '<System.Diagnostics.DebuggerStepThrough()> 
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_tiptuboM As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Ctl_txt_letras1 As Ctl_txt.ctl_txt_letras
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_letras2 As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Parametros))
        Me.dgrd_Unidades = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tab_Parametros = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.grp_Uni = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Ctl_txt_nomUni = New Ctl_txt.ctl_txt_letras
        Me.cmb_sistema_uni = New System.Windows.Forms.ComboBox
        Me.lbl_Sistema = New System.Windows.Forms.Label
        Me.lbl_nomenclatura = New System.Windows.Forms.Label
        Me.btn_NuevoUni = New System.Windows.Forms.Button
        Me.btn_CancelarUni = New System.Windows.Forms.Button
        Me.txt_CodUni = New System.Windows.Forms.TextBox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_AceptarUni = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grp_TipMue = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.cmb_tiptuboM = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ctl_txt_desMue = New System.Windows.Forms.TextBox
        Me.lbl_ObsTipMue = New System.Windows.Forms.Label
        Me.Ctl_txt_nomMue = New Ctl_txt.ctl_txt_letras
        Me.lbl_NomMue = New System.Windows.Forms.Label
        Me.txt_CodMue = New System.Windows.Forms.TextBox
        Me.btn_CancelarMue = New System.Windows.Forms.Button
        Me.btn_eliminarMue = New System.Windows.Forms.Button
        Me.btn_AceptarMue = New System.Windows.Forms.Button
        Me.btn_NuevoMue = New System.Windows.Forms.Button
        Me.dgrdTipMuestra = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.grp_TipTubo = New System.Windows.Forms.GroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.txt_ObsTipTubo = New System.Windows.Forms.TextBox
        Me.cmb_TipTubo = New System.Windows.Forms.ComboBox
        Me.txt_TubNom = New System.Windows.Forms.TextBox
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.lbl_aditivo = New System.Windows.Forms.Label
        Me.lbl_Obs = New System.Windows.Forms.Label
        Me.txt_tubCodigo = New System.Windows.Forms.TextBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_eliminarTub = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.dgrdTipTubos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Ctl_txt_letras1 = New Ctl_txt.ctl_txt_letras
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Ctl_txt_letras2 = New Ctl_txt.ctl_txt_letras
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        CType(Me.dgrd_Unidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Parametros.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grp_Uni.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.grp_TipMue.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrdTipMuestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.grp_TipTubo.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrdTipTubos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrd_Unidades
        '
        Me.dgrd_Unidades.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Unidades.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Unidades.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Unidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Unidades.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Unidades.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Unidades.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Unidades.CaptionText = "UNIDADES"
        Me.dgrd_Unidades.DataMember = ""
        Me.dgrd_Unidades.FlatMode = True
        Me.dgrd_Unidades.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Unidades.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Unidades.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Unidades.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Unidades.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Unidades.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Unidades.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Unidades.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Unidades.Location = New System.Drawing.Point(22, 111)
        Me.dgrd_Unidades.Name = "dgrd_Unidades"
        Me.dgrd_Unidades.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Unidades.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Unidades.ParentRowsVisible = False
        Me.dgrd_Unidades.PreferredColumnWidth = 95
        Me.dgrd_Unidades.ReadOnly = True
        Me.dgrd_Unidades.RowHeaderWidth = 20
        Me.dgrd_Unidades.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Unidades.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Unidades.Size = New System.Drawing.Size(449, 215)
        Me.dgrd_Unidades.TabIndex = 1
        Me.dgrd_Unidades.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Unidades
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.CaptionText = "UNIDADES"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.ForeColor = System.Drawing.Color.Black
        Me.DataGrid1.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.Location = New System.Drawing.Point(22, 111)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.ParentRowsVisible = False
        Me.DataGrid1.PreferredColumnWidth = 95
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.RowHeaderWidth = 20
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid1.Size = New System.Drawing.Size(449, 215)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nomenclatura"
        Me.DataGridTextBoxColumn2.MappingName = "NOMENCLATURA"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "SISTEMA"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'Tab_Parametros
        '
        Me.Tab_Parametros.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Tab_Parametros.Controls.Add(Me.TabPage1)
        Me.Tab_Parametros.Controls.Add(Me.TabPage2)
        Me.Tab_Parametros.Controls.Add(Me.TabPage3)
        Me.Tab_Parametros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Parametros.Location = New System.Drawing.Point(12, 36)
        Me.Tab_Parametros.Name = "Tab_Parametros"
        Me.Tab_Parametros.SelectedIndex = 0
        Me.Tab_Parametros.Size = New System.Drawing.Size(507, 432)
        Me.Tab_Parametros.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.dgrd_Unidades)
        Me.TabPage1.Controls.Add(Me.grp_Uni)
        Me.TabPage1.Controls.Add(Me.btn_NuevoUni)
        Me.TabPage1.Controls.Add(Me.btn_CancelarUni)
        Me.TabPage1.Controls.Add(Me.txt_CodUni)
        Me.TabPage1.Controls.Add(Me.btn_Eliminar)
        Me.TabPage1.Controls.Add(Me.btn_AceptarUni)
        Me.TabPage1.ImageIndex = 2
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(499, 403)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "     UNIDAD     "
        '
        'grp_Uni
        '
        Me.grp_Uni.BackColor = System.Drawing.Color.Transparent
        Me.grp_Uni.Controls.Add(Me.PictureBox1)
        Me.grp_Uni.Controls.Add(Me.Ctl_txt_nomUni)
        Me.grp_Uni.Controls.Add(Me.cmb_sistema_uni)
        Me.grp_Uni.Controls.Add(Me.lbl_Sistema)
        Me.grp_Uni.Controls.Add(Me.lbl_nomenclatura)
        Me.grp_Uni.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Uni.ForeColor = System.Drawing.Color.Navy
        Me.grp_Uni.Location = New System.Drawing.Point(22, 15)
        Me.grp_Uni.Name = "grp_Uni"
        Me.grp_Uni.Size = New System.Drawing.Size(449, 90)
        Me.grp_Uni.TabIndex = 0
        Me.grp_Uni.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Ctl_txt_nomUni
        '
        Me.Ctl_txt_nomUni.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nomUni.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nomUni.Location = New System.Drawing.Point(148, 28)
        Me.Ctl_txt_nomUni.Name = "Ctl_txt_nomUni"
        Me.Ctl_txt_nomUni.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nomUni.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nomUni.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_nomUni.Size = New System.Drawing.Size(156, 20)
        Me.Ctl_txt_nomUni.TabIndex = 0
        '
        'cmb_sistema_uni
        '
        Me.cmb_sistema_uni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sistema_uni.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sistema_uni.Items.AddRange(New Object() {"Internacional", "Convencional"})
        Me.cmb_sistema_uni.Location = New System.Drawing.Point(148, 54)
        Me.cmb_sistema_uni.Name = "cmb_sistema_uni"
        Me.cmb_sistema_uni.Size = New System.Drawing.Size(154, 21)
        Me.cmb_sistema_uni.TabIndex = 1
        '
        'lbl_Sistema
        '
        Me.lbl_Sistema.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sistema.ForeColor = System.Drawing.Color.Black
        Me.lbl_Sistema.Location = New System.Drawing.Point(88, 55)
        Me.lbl_Sistema.Name = "lbl_Sistema"
        Me.lbl_Sistema.Size = New System.Drawing.Size(54, 20)
        Me.lbl_Sistema.TabIndex = 9
        Me.lbl_Sistema.Text = "Sistema:"
        '
        'lbl_nomenclatura
        '
        Me.lbl_nomenclatura.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomenclatura.ForeColor = System.Drawing.Color.Black
        Me.lbl_nomenclatura.Location = New System.Drawing.Point(88, 30)
        Me.lbl_nomenclatura.Name = "lbl_nomenclatura"
        Me.lbl_nomenclatura.Size = New System.Drawing.Size(54, 20)
        Me.lbl_nomenclatura.TabIndex = 7
        Me.lbl_nomenclatura.Text = "Nombre:"
        '
        'btn_NuevoUni
        '
        Me.btn_NuevoUni.BackColor = System.Drawing.SystemColors.Control
        Me.btn_NuevoUni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NuevoUni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NuevoUni.ForeColor = System.Drawing.Color.Black
        Me.btn_NuevoUni.Image = CType(resources.GetObject("btn_NuevoUni.Image"), System.Drawing.Image)
        Me.btn_NuevoUni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NuevoUni.Location = New System.Drawing.Point(147, 344)
        Me.btn_NuevoUni.Name = "btn_NuevoUni"
        Me.btn_NuevoUni.Size = New System.Drawing.Size(80, 35)
        Me.btn_NuevoUni.TabIndex = 2
        Me.btn_NuevoUni.Text = "Nuevo"
        Me.btn_NuevoUni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NuevoUni.UseVisualStyleBackColor = False
        '
        'btn_CancelarUni
        '
        Me.btn_CancelarUni.BackColor = System.Drawing.SystemColors.Control
        Me.btn_CancelarUni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelarUni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelarUni.ForeColor = System.Drawing.Color.Black
        Me.btn_CancelarUni.Image = CType(resources.GetObject("btn_CancelarUni.Image"), System.Drawing.Image)
        Me.btn_CancelarUni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarUni.Location = New System.Drawing.Point(392, 344)
        Me.btn_CancelarUni.Name = "btn_CancelarUni"
        Me.btn_CancelarUni.Size = New System.Drawing.Size(80, 35)
        Me.btn_CancelarUni.TabIndex = 5
        Me.btn_CancelarUni.Text = "Salir"
        Me.btn_CancelarUni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CancelarUni.UseVisualStyleBackColor = False
        '
        'txt_CodUni
        '
        Me.txt_CodUni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CodUni.Enabled = False
        Me.txt_CodUni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodUni.Location = New System.Drawing.Point(32, 141)
        Me.txt_CodUni.Name = "txt_CodUni"
        Me.txt_CodUni.Size = New System.Drawing.Size(74, 20)
        Me.txt_CodUni.TabIndex = 10
        Me.txt_CodUni.Visible = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(311, 344)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 35)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_AceptarUni
        '
        Me.btn_AceptarUni.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AceptarUni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AceptarUni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AceptarUni.ForeColor = System.Drawing.Color.Black
        Me.btn_AceptarUni.Image = CType(resources.GetObject("btn_AceptarUni.Image"), System.Drawing.Image)
        Me.btn_AceptarUni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AceptarUni.Location = New System.Drawing.Point(229, 344)
        Me.btn_AceptarUni.Name = "btn_AceptarUni"
        Me.btn_AceptarUni.Size = New System.Drawing.Size(80, 35)
        Me.btn_AceptarUni.TabIndex = 3
        Me.btn_AceptarUni.Text = "Aceptar"
        Me.btn_AceptarUni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AceptarUni.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.grp_TipMue)
        Me.TabPage2.Controls.Add(Me.btn_CancelarMue)
        Me.TabPage2.Controls.Add(Me.btn_eliminarMue)
        Me.TabPage2.Controls.Add(Me.btn_AceptarMue)
        Me.TabPage2.Controls.Add(Me.btn_NuevoMue)
        Me.TabPage2.Controls.Add(Me.dgrdTipMuestra)
        Me.TabPage2.ImageIndex = 3
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(499, 403)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "     MUESTRA     "
        '
        'grp_TipMue
        '
        Me.grp_TipMue.BackColor = System.Drawing.Color.Transparent
        Me.grp_TipMue.Controls.Add(Me.PictureBox3)
        Me.grp_TipMue.Controls.Add(Me.cmb_tiptuboM)
        Me.grp_TipMue.Controls.Add(Me.Label1)
        Me.grp_TipMue.Controls.Add(Me.Ctl_txt_desMue)
        Me.grp_TipMue.Controls.Add(Me.lbl_ObsTipMue)
        Me.grp_TipMue.Controls.Add(Me.Ctl_txt_nomMue)
        Me.grp_TipMue.Controls.Add(Me.lbl_NomMue)
        Me.grp_TipMue.Controls.Add(Me.txt_CodMue)
        Me.grp_TipMue.ForeColor = System.Drawing.Color.Navy
        Me.grp_TipMue.Location = New System.Drawing.Point(22, 14)
        Me.grp_TipMue.Name = "grp_TipMue"
        Me.grp_TipMue.Size = New System.Drawing.Size(448, 90)
        Me.grp_TipMue.TabIndex = 0
        Me.grp_TipMue.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'cmb_tiptuboM
        '
        Me.cmb_tiptuboM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tiptuboM.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tiptuboM.Location = New System.Drawing.Point(156, 48)
        Me.cmb_tiptuboM.Name = "cmb_tiptuboM"
        Me.cmb_tiptuboM.Size = New System.Drawing.Size(168, 21)
        Me.cmb_tiptuboM.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo tubo:"
        '
        'Ctl_txt_desMue
        '
        Me.Ctl_txt_desMue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ctl_txt_desMue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_desMue.Location = New System.Drawing.Point(257, 46)
        Me.Ctl_txt_desMue.MaxLength = 150
        Me.Ctl_txt_desMue.Multiline = True
        Me.Ctl_txt_desMue.Name = "Ctl_txt_desMue"
        Me.Ctl_txt_desMue.Size = New System.Drawing.Size(179, 38)
        Me.Ctl_txt_desMue.TabIndex = 1
        Me.Ctl_txt_desMue.Visible = False
        '
        'lbl_ObsTipMue
        '
        Me.lbl_ObsTipMue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ObsTipMue.ForeColor = System.Drawing.Color.Black
        Me.lbl_ObsTipMue.Location = New System.Drawing.Point(314, 68)
        Me.lbl_ObsTipMue.Name = "lbl_ObsTipMue"
        Me.lbl_ObsTipMue.Size = New System.Drawing.Size(84, 16)
        Me.lbl_ObsTipMue.TabIndex = 2
        Me.lbl_ObsTipMue.Text = "Observaci�n:"
        Me.lbl_ObsTipMue.Visible = False
        '
        'Ctl_txt_nomMue
        '
        Me.Ctl_txt_nomMue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nomMue.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nomMue.Location = New System.Drawing.Point(156, 25)
        Me.Ctl_txt_nomMue.Name = "Ctl_txt_nomMue"
        Me.Ctl_txt_nomMue.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nomMue.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nomMue.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_nomMue.Size = New System.Drawing.Size(280, 20)
        Me.Ctl_txt_nomMue.TabIndex = 0
        '
        'lbl_NomMue
        '
        Me.lbl_NomMue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomMue.ForeColor = System.Drawing.Color.Black
        Me.lbl_NomMue.Location = New System.Drawing.Point(88, 27)
        Me.lbl_NomMue.Name = "lbl_NomMue"
        Me.lbl_NomMue.Size = New System.Drawing.Size(56, 16)
        Me.lbl_NomMue.TabIndex = 1
        Me.lbl_NomMue.Text = "Nombre:"
        '
        'txt_CodMue
        '
        Me.txt_CodMue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CodMue.Location = New System.Drawing.Point(223, 25)
        Me.txt_CodMue.Name = "txt_CodMue"
        Me.txt_CodMue.Size = New System.Drawing.Size(88, 21)
        Me.txt_CodMue.TabIndex = 0
        Me.txt_CodMue.Visible = False
        '
        'btn_CancelarMue
        '
        Me.btn_CancelarMue.AccessibleDescription = ""
        Me.btn_CancelarMue.BackColor = System.Drawing.SystemColors.Control
        Me.btn_CancelarMue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelarMue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CancelarMue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelarMue.ForeColor = System.Drawing.Color.Black
        Me.btn_CancelarMue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarMue.Location = New System.Drawing.Point(389, 330)
        Me.btn_CancelarMue.Name = "btn_CancelarMue"
        Me.btn_CancelarMue.Size = New System.Drawing.Size(81, 44)
        Me.btn_CancelarMue.TabIndex = 4
        Me.btn_CancelarMue.Text = "Salir"
        Me.btn_CancelarMue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CancelarMue.UseVisualStyleBackColor = False
        '
        'btn_eliminarMue
        '
        Me.btn_eliminarMue.AccessibleDescription = ""
        Me.btn_eliminarMue.BackColor = System.Drawing.SystemColors.Control
        Me.btn_eliminarMue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminarMue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminarMue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarMue.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminarMue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarMue.Location = New System.Drawing.Point(300, 330)
        Me.btn_eliminarMue.Name = "btn_eliminarMue"
        Me.btn_eliminarMue.Size = New System.Drawing.Size(81, 44)
        Me.btn_eliminarMue.TabIndex = 5
        Me.btn_eliminarMue.Text = "Eliminar"
        Me.btn_eliminarMue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminarMue.UseVisualStyleBackColor = False
        '
        'btn_AceptarMue
        '
        Me.btn_AceptarMue.AccessibleDescription = ""
        Me.btn_AceptarMue.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AceptarMue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AceptarMue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AceptarMue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AceptarMue.ForeColor = System.Drawing.Color.Black
        Me.btn_AceptarMue.Image = CType(resources.GetObject("btn_AceptarMue.Image"), System.Drawing.Image)
        Me.btn_AceptarMue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AceptarMue.Location = New System.Drawing.Point(214, 330)
        Me.btn_AceptarMue.Name = "btn_AceptarMue"
        Me.btn_AceptarMue.Size = New System.Drawing.Size(79, 44)
        Me.btn_AceptarMue.TabIndex = 3
        Me.btn_AceptarMue.Text = "Aceptar"
        Me.btn_AceptarMue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AceptarMue.UseVisualStyleBackColor = False
        '
        'btn_NuevoMue
        '
        Me.btn_NuevoMue.AccessibleName = ""
        Me.btn_NuevoMue.BackColor = System.Drawing.SystemColors.Control
        Me.btn_NuevoMue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NuevoMue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NuevoMue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NuevoMue.ForeColor = System.Drawing.Color.Black
        Me.btn_NuevoMue.Image = CType(resources.GetObject("btn_NuevoMue.Image"), System.Drawing.Image)
        Me.btn_NuevoMue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NuevoMue.Location = New System.Drawing.Point(129, 330)
        Me.btn_NuevoMue.Name = "btn_NuevoMue"
        Me.btn_NuevoMue.Size = New System.Drawing.Size(79, 44)
        Me.btn_NuevoMue.TabIndex = 2
        Me.btn_NuevoMue.Text = "Nuevo"
        Me.btn_NuevoMue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NuevoMue.UseVisualStyleBackColor = False
        '
        'dgrdTipMuestra
        '
        Me.dgrdTipMuestra.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrdTipMuestra.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrdTipMuestra.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrdTipMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrdTipMuestra.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrdTipMuestra.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrdTipMuestra.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrdTipMuestra.CaptionText = "MUESTRAS"
        Me.dgrdTipMuestra.DataMember = ""
        Me.dgrdTipMuestra.FlatMode = True
        Me.dgrdTipMuestra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrdTipMuestra.ForeColor = System.Drawing.Color.Black
        Me.dgrdTipMuestra.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrdTipMuestra.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrdTipMuestra.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrdTipMuestra.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrdTipMuestra.HeaderForeColor = System.Drawing.Color.White
        Me.dgrdTipMuestra.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrdTipMuestra.Location = New System.Drawing.Point(23, 110)
        Me.dgrdTipMuestra.Name = "dgrdTipMuestra"
        Me.dgrdTipMuestra.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrdTipMuestra.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrdTipMuestra.ParentRowsVisible = False
        Me.dgrdTipMuestra.PreferredColumnWidth = 120
        Me.dgrdTipMuestra.ReadOnly = True
        Me.dgrdTipMuestra.RowHeaderWidth = 20
        Me.dgrdTipMuestra.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrdTipMuestra.SelectionForeColor = System.Drawing.Color.White
        Me.dgrdTipMuestra.Size = New System.Drawing.Size(448, 214)
        Me.dgrdTipMuestra.TabIndex = 1
        Me.dgrdTipMuestra.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle3.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle3.DataGrid = Me.dgrdTipMuestra
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn15})
        Me.DataGridTableStyle3.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle3.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle3.MappingName = "Registros"
        Me.DataGridTableStyle3.ReadOnly = True
        Me.DataGridTableStyle3.SelectionBackColor = System.Drawing.Color.Khaki
        '
        'DataGrid2
        '
        Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGrid2.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid2.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid2.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.CaptionText = "MUESTRAS"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.FlatMode = True
        Me.DataGrid2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.ForeColor = System.Drawing.Color.Black
        Me.DataGrid2.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid2.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid2.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid2.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.Location = New System.Drawing.Point(22, 136)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.DataGrid2.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid2.ParentRowsVisible = False
        Me.DataGrid2.PreferredColumnWidth = 120
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.RowHeaderWidth = 20
        Me.DataGrid2.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid2.Size = New System.Drawing.Size(448, 192)
        Me.DataGrid2.TabIndex = 1
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "C�digo"
        Me.DataGridTextBoxColumn8.MappingName = "TIM_ID"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn9.MappingName = "TIM_NOMBRE"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 200
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Observacion"
        Me.DataGridTextBoxColumn10.MappingName = "TIM_OBS"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 160
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Tubo"
        Me.DataGridTextBoxColumn15.MappingName = "tit_id"
        Me.DataGridTextBoxColumn15.NullText = "--"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.Controls.Add(Me.grp_TipTubo)
        Me.TabPage3.Controls.Add(Me.btn_Cancelar)
        Me.TabPage3.Controls.Add(Me.btn_eliminarTub)
        Me.TabPage3.Controls.Add(Me.btn_Aceptar)
        Me.TabPage3.Controls.Add(Me.btn_Nuevo)
        Me.TabPage3.Controls.Add(Me.dgrdTipTubos)
        Me.TabPage3.ImageIndex = 1
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(499, 403)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "   RECIPIENTE   "
        '
        'grp_TipTubo
        '
        Me.grp_TipTubo.BackColor = System.Drawing.Color.Transparent
        Me.grp_TipTubo.Controls.Add(Me.PictureBox4)
        Me.grp_TipTubo.Controls.Add(Me.txt_ObsTipTubo)
        Me.grp_TipTubo.Controls.Add(Me.cmb_TipTubo)
        Me.grp_TipTubo.Controls.Add(Me.txt_TubNom)
        Me.grp_TipTubo.Controls.Add(Me.lbl_Nombre)
        Me.grp_TipTubo.Controls.Add(Me.lbl_aditivo)
        Me.grp_TipTubo.Controls.Add(Me.lbl_Obs)
        Me.grp_TipTubo.Controls.Add(Me.txt_tubCodigo)
        Me.grp_TipTubo.ForeColor = System.Drawing.Color.Navy
        Me.grp_TipTubo.Location = New System.Drawing.Point(23, 16)
        Me.grp_TipTubo.Name = "grp_TipTubo"
        Me.grp_TipTubo.Size = New System.Drawing.Size(446, 94)
        Me.grp_TipTubo.TabIndex = 0
        Me.grp_TipTubo.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(19, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'txt_ObsTipTubo
        '
        Me.txt_ObsTipTubo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ObsTipTubo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ObsTipTubo.Location = New System.Drawing.Point(252, 79)
        Me.txt_ObsTipTubo.MaxLength = 150
        Me.txt_ObsTipTubo.Multiline = True
        Me.txt_ObsTipTubo.Name = "txt_ObsTipTubo"
        Me.txt_ObsTipTubo.Size = New System.Drawing.Size(156, 29)
        Me.txt_ObsTipTubo.TabIndex = 2
        Me.txt_ObsTipTubo.Visible = False
        '
        'cmb_TipTubo
        '
        Me.cmb_TipTubo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipTubo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipTubo.Items.AddRange(New Object() {"Normal ", "Pedi�trico"})
        Me.cmb_TipTubo.Location = New System.Drawing.Point(154, 44)
        Me.cmb_TipTubo.Name = "cmb_TipTubo"
        Me.cmb_TipTubo.Size = New System.Drawing.Size(168, 21)
        Me.cmb_TipTubo.TabIndex = 3
        '
        'txt_TubNom
        '
        Me.txt_TubNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TubNom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TubNom.Location = New System.Drawing.Point(154, 22)
        Me.txt_TubNom.MaxLength = 50
        Me.txt_TubNom.Name = "txt_TubNom"
        Me.txt_TubNom.Size = New System.Drawing.Size(168, 21)
        Me.txt_TubNom.TabIndex = 1
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(78, 26)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(58, 16)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_aditivo
        '
        Me.lbl_aditivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aditivo.ForeColor = System.Drawing.Color.Black
        Me.lbl_aditivo.Location = New System.Drawing.Point(80, 48)
        Me.lbl_aditivo.Name = "lbl_aditivo"
        Me.lbl_aditivo.Size = New System.Drawing.Size(56, 16)
        Me.lbl_aditivo.TabIndex = 27
        Me.lbl_aditivo.Text = "Tipo:"
        '
        'lbl_Obs
        '
        Me.lbl_Obs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Obs.ForeColor = System.Drawing.Color.Black
        Me.lbl_Obs.Location = New System.Drawing.Point(78, 48)
        Me.lbl_Obs.Name = "lbl_Obs"
        Me.lbl_Obs.Size = New System.Drawing.Size(80, 16)
        Me.lbl_Obs.TabIndex = 4
        Me.lbl_Obs.Text = "Observaci�n:"
        Me.lbl_Obs.Visible = False
        '
        'txt_tubCodigo
        '
        Me.txt_tubCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tubCodigo.Location = New System.Drawing.Point(328, 48)
        Me.txt_tubCodigo.Name = "txt_tubCodigo"
        Me.txt_tubCodigo.Size = New System.Drawing.Size(95, 21)
        Me.txt_tubCodigo.TabIndex = 1
        Me.txt_tubCodigo.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.AccessibleDescription = ""
        Me.btn_Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.Location = New System.Drawing.Point(389, 337)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(80, 42)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "Salir"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'btn_eliminarTub
        '
        Me.btn_eliminarTub.AccessibleDescription = ""
        Me.btn_eliminarTub.BackColor = System.Drawing.SystemColors.Control
        Me.btn_eliminarTub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminarTub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminarTub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarTub.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminarTub.Image = CType(resources.GetObject("btn_eliminarTub.Image"), System.Drawing.Image)
        Me.btn_eliminarTub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminarTub.Location = New System.Drawing.Point(303, 337)
        Me.btn_eliminarTub.Name = "btn_eliminarTub"
        Me.btn_eliminarTub.Size = New System.Drawing.Size(80, 42)
        Me.btn_eliminarTub.TabIndex = 4
        Me.btn_eliminarTub.Text = "Eliminar"
        Me.btn_eliminarTub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminarTub.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.AccessibleDescription = ""
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(215, 337)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 42)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.AccessibleName = ""
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(129, 337)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 42)
        Me.btn_Nuevo.TabIndex = 2
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'dgrdTipTubos
        '
        Me.dgrdTipTubos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrdTipTubos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrdTipTubos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrdTipTubos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrdTipTubos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrdTipTubos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrdTipTubos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrdTipTubos.CaptionText = "RECIPIENTES"
        Me.dgrdTipTubos.DataMember = ""
        Me.dgrdTipTubos.FlatMode = True
        Me.dgrdTipTubos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrdTipTubos.ForeColor = System.Drawing.Color.Black
        Me.dgrdTipTubos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrdTipTubos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrdTipTubos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrdTipTubos.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrdTipTubos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrdTipTubos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrdTipTubos.Location = New System.Drawing.Point(23, 116)
        Me.dgrdTipTubos.Name = "dgrdTipTubos"
        Me.dgrdTipTubos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrdTipTubos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrdTipTubos.ParentRowsVisible = False
        Me.dgrdTipTubos.PreferredColumnWidth = 90
        Me.dgrdTipTubos.ReadOnly = True
        Me.dgrdTipTubos.RowHeaderWidth = 20
        Me.dgrdTipTubos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrdTipTubos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrdTipTubos.Size = New System.Drawing.Size(446, 215)
        Me.dgrdTipTubos.TabIndex = 1
        Me.dgrdTipTubos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle4.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle4.DataGrid = Me.dgrdTipTubos
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle4.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle4.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle4.MappingName = "Registros"
        Me.DataGridTableStyle4.ReadOnly = True
        Me.DataGridTableStyle4.SelectionBackColor = System.Drawing.Color.Khaki
        '
        'DataGrid3
        '
        Me.DataGrid3.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGrid3.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid3.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid3.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid3.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid3.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid3.CaptionText = "TUBOS"
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.FlatMode = True
        Me.DataGrid3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid3.ForeColor = System.Drawing.Color.Black
        Me.DataGrid3.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGrid3.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid3.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid3.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid3.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid3.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid3.Location = New System.Drawing.Point(62, 142)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.DataGrid3.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid3.ParentRowsVisible = False
        Me.DataGrid3.PreferredColumnWidth = 90
        Me.DataGrid3.ReadOnly = True
        Me.DataGrid3.RowHeaderWidth = 20
        Me.DataGrid3.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid3.Size = New System.Drawing.Size(376, 189)
        Me.DataGrid3.TabIndex = 1
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn11.MappingName = "tit_id"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn12.MappingName = "tit_nombre"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 200
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn13.MappingName = "tit_tipo"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 107
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "OBSERVACION"
        Me.DataGridTextBoxColumn14.MappingName = "tit_obs"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(530, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(4, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(207, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "PARAMETROS GENERALES"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DarkKhaki
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.DataGrid1)
        Me.TabPage4.ImageIndex = 2
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(499, 403)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "     UNIDAD     "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Ctl_txt_letras1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(22, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Ctl_txt_letras1
        '
        Me.Ctl_txt_letras1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_letras1.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_letras1.Location = New System.Drawing.Point(146, 29)
        Me.Ctl_txt_letras1.Name = "Ctl_txt_letras1"
        Me.Ctl_txt_letras1.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_letras1.Prp_CaracterPasswd = ""
        Me.Ctl_txt_letras1.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_letras1.Size = New System.Drawing.Size(156, 20)
        Me.Ctl_txt_letras1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"Internacional", "Convencional"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(178, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(88, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sistema:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(88, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(84, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(344, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 46)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(258, 345)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 46)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Eliminar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(170, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 46)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Aceptar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.DarkKhaki
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.Controls.Add(Me.Button6)
        Me.TabPage5.Controls.Add(Me.Button7)
        Me.TabPage5.Controls.Add(Me.Button8)
        Me.TabPage5.Controls.Add(Me.DataGrid2)
        Me.TabPage5.ImageIndex = 3
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(499, 403)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "     MUESTRA     "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Ctl_txt_letras2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(22, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 116)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(156, 48)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(62, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo tubo:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 74)
        Me.TextBox2.MaxLength = 150
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 38)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(61, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Observaci�n:"
        Me.Label5.Visible = False
        '
        'Ctl_txt_letras2
        '
        Me.Ctl_txt_letras2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_letras2.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_letras2.Location = New System.Drawing.Point(156, 25)
        Me.Ctl_txt_letras2.Name = "Ctl_txt_letras2"
        Me.Ctl_txt_letras2.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_letras2.Prp_CaracterPasswd = ""
        Me.Ctl_txt_letras2.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_letras2.Size = New System.Drawing.Size(280, 20)
        Me.Ctl_txt_letras2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(63, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre:"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(223, 25)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 20)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Visible = False
        '
        'Button5
        '
        Me.Button5.AccessibleDescription = ""
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(339, 346)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Salir"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button6
        '
        Me.Button6.AccessibleDescription = ""
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(250, 346)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(81, 44)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Eliminar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button7
        '
        Me.Button7.AccessibleDescription = ""
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.Location = New System.Drawing.Point(164, 346)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(79, 44)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Aceptar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.AccessibleName = ""
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.Location = New System.Drawing.Point(79, 346)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 44)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Nuevo"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.DarkKhaki
        Me.TabPage6.Controls.Add(Me.GroupBox3)
        Me.TabPage6.Controls.Add(Me.Button9)
        Me.TabPage6.Controls.Add(Me.Button10)
        Me.TabPage6.Controls.Add(Me.Button11)
        Me.TabPage6.Controls.Add(Me.Button12)
        Me.TabPage6.Controls.Add(Me.DataGrid3)
        Me.TabPage6.ImageIndex = 1
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(499, 403)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "   RECIPIENTE   "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(60, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(378, 120)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo Tubo:"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(86, 42)
        Me.TextBox4.MaxLength = 150
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(280, 38)
        Me.TextBox4.TabIndex = 2
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Items.AddRange(New Object() {"Normal ", "Pedi�trico"})
        Me.ComboBox3.Location = New System.Drawing.Point(86, 82)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox3.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(86, 20)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(168, 21)
        Me.TextBox5.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Tipo:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Observaci�n:"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Location = New System.Drawing.Point(256, 50)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(95, 20)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.Visible = False
        '
        'Button9
        '
        Me.Button9.AccessibleDescription = ""
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.Location = New System.Drawing.Point(339, 348)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 42)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Salir"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.AccessibleDescription = ""
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(253, 348)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 42)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "Eliminar"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.AccessibleDescription = ""
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.Location = New System.Drawing.Point(165, 348)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 42)
        Me.Button11.TabIndex = 3
        Me.Button11.Text = "Aceptar"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.AccessibleName = ""
        Me.Button12.BackColor = System.Drawing.SystemColors.Control
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.Location = New System.Drawing.Point(79, 348)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(80, 42)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "Nuevo"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = False
        '
        'frm_Parametros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(530, 480)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.Tab_Parametros)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Parametros"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Par�metros Generales"
        CType(Me.dgrd_Unidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Parametros.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grp_Uni.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.grp_TipMue.ResumeLayout(False)
        Me.grp_TipMue.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrdTipMuestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.grp_TipTubo.ResumeLayout(False)
        Me.grp_TipTubo.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrdTipTubos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim opr_Unidad As New Cls_Parametros()
    Private sng_numTubo As Single
    Dim dts_grid As DataSet
    'Banderas para saber si se realiza un insert o un update 
    Private boo_flag As Boolean
    Private boo_flagM As Boolean
    Private boo_flagU As Boolean
    Private boo_flagUE As Boolean
    Private int_codId As Integer

#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
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

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AceptarUni.MouseEnter, btn_Eliminar.MouseEnter, btn_NuevoUni.MouseEnter, btn_CancelarUni.MouseEnter, btn_NuevoMue.MouseEnter, btn_Aceptar.MouseEnter, btn_eliminarMue.MouseEnter, btn_CancelarMue.MouseEnter, btn_Nuevo.MouseEnter, btn_Aceptar.MouseEnter, btn_eliminarTub.MouseEnter, btn_Cancelar.MouseEnter, btn_AceptarMue.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AceptarUni.MouseLeave, btn_NuevoUni.MouseLeave, btn_Eliminar.MouseLeave, btn_CancelarUni.MouseLeave, btn_Cancelar.MouseLeave, btn_NuevoMue.MouseLeave, btn_AceptarMue.MouseLeave, btn_eliminarMue.MouseLeave, btn_CancelarMue.MouseLeave, btn_Nuevo.MouseLeave, btn_Aceptar.MouseLeave, btn_eliminarTub.MouseLeave, btn_Cancelar.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, lbl_textform.Click
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Tab_Parametros_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab_Parametros.Click
        If (TabPage3.Visible = True) Then   'TIPOS DE TUBOS
            btn_Aceptar.Enabled = False
            btn_eliminarTub.Enabled = False
            grp_TipTubo.Enabled = False
            txt_tubCodigo.Enabled = False
            grp_TipMue.Enabled = False
            dgrdTipTubos.SetDataBinding(opr_Unidad.LeerTiposTubos, "Registros")
            boo_flag = False
        End If

        If (TabPage2.Visible = True) Then   'Tab TIPOS DE MUESTRAS
            Dim opr_param As New Cls_Parametros()
            btn_AceptarMue.Enabled = False
            btn_eliminarMue.Enabled = False
            grp_TipMue.Enabled = False
            txt_CodMue.Enabled = False
            opr_param.LlenarCmb_TipTub(cmb_tiptuboM)
            dgrdTipMuestra.SetDataBinding(opr_Unidad.LeerTiposMuestras, "Registros")
            boo_flagM = False
        End If

        If (TabPage1.Visible = True) Then   'Tab UNIDADES
            btn_AceptarUni.Enabled = False
            btn_Eliminar.Enabled = False
            txt_CodUni.Enabled = False
            grp_Uni.Enabled = False
            dgrd_Unidades.SetDataBinding(opr_Unidad.LeerUnidades, "Registros")
            boo_flagU = False
        End If
        'If (TabPage4.Visible = True) Then   'Tab UNIDADES EQUIVALENTES
        '    btn_AceptarEqui.Enabled = False
        '    btn_EliminarEqui.Enabled = False
        '    dgrd_UniEqui.SetDataBinding(opr_Unidad.LeerUniEqui, "Registros")
        '    opr_Unidad.LLenarCmbUnidad(cmb_Unidad1)
        '    opr_Unidad.LLenarCmbUnidad(cmb_Unidad2)
        '    grp_UniEqui.Enabled = False
        '    boo_flagUE = False
        'End If
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call limpiarCampos()
        sng_numTubo = opr_Unidad.LeerMaxCodTipTubo() + 1
        txt_tubCodigo.Text = (sng_numTubo)
        btn_Aceptar.Enabled = True
        txt_TubNom.Focus()
        boo_flag = True
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_tubCodigo.Text = "") Then
            MsgBox("Ingrese el c�digo del tipo de tubo", MsgBoxStyle.Exclamation, "ANALISYS")
            txt_tubCodigo.Focus()
            Exit Sub
        End If
        If (txt_TubNom.Text = "") Then
            MsgBox("Ingrese el nombre del tipo de tubo", MsgBoxStyle.Exclamation, "ANALISYS")
            txt_TubNom.Focus()
            Exit Sub
        End If

        If boo_flag = True Then    '*** Si se trata de un nuevo tubo
            opr_Unidad.GuardarTipoTubo(txt_tubCodigo.Text, txt_TubNom.Text, txt_ObsTipTubo.Text, cmb_TipTubo.Text)
        Else
            opr_Unidad.ActualizarTipoTubos(Val(txt_tubCodigo.Text), txt_TubNom.Text, txt_ObsTipTubo.Text, cmb_TipTubo.Text)
        End If
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        Call limpiarCampos()
        btn_Aceptar.Enabled = False
        dgrdTipTubos.SetDataBinding(opr_Unidad.LeerTiposTubos(), "Registros")
    End Sub

    Private Sub dgrdTipTubos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrdTipTubos.CurrentCellChanged
        dgrdTipTubos.Select(dgrdTipTubos.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        btn_eliminarTub.Enabled = True
        grp_TipTubo.Enabled = True
        txt_tubCodigo.Text = dgrdTipTubos.Item(dgrdTipTubos.CurrentCell.RowNumber, 0)
        txt_TubNom.Text = dgrdTipTubos.Item(dgrdTipTubos.CurrentCell.RowNumber, 1)
        cmb_TipTubo.Text = dgrdTipTubos.Item(dgrdTipTubos.CurrentCell.RowNumber, 2)
        txt_ObsTipTubo.Text = dgrdTipTubos.Item(dgrdTipTubos.CurrentCell.RowNumber, 3).ToString
        boo_flag = False
        Dim dgc_Celda As DataGridCell

        dgc_Celda.ColumnNumber = 0
        dgc_Celda.RowNumber = dgrdTipTubos.CurrentCell.RowNumber
        dgrdTipTubos.CurrentCell = dgc_Celda
        dgrdTipTubos.Select(dgrdTipTubos.CurrentCell.RowNumber)
    End Sub
    Private Sub limpiarCampos()
        txt_tubCodigo.Text = ""
        txt_TubNom.Text = ""
        txt_ObsTipTubo.Text = ""
        'Por defecto deja la primera opci�n del combo
        cmb_TipTubo.SelectedIndex = 0
    End Sub

    Private Sub btn_NuevoMue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sng_numTubo = opr_Unidad.LeerMaxCodTipMuestra() + 1
        Call limpiarCamposM()
        txt_CodMue.Text = (sng_numTubo)
        btn_AceptarMue.Enabled = True
        Ctl_txt_nomMue.Focus()
        boo_flagM = True
    End Sub

    Private Sub btn_AceptarMue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_CodMue.Text = "") Then
            MsgBox("Ingrese el c�digo del tipo de tipo de muestra", MsgBoxStyle.Exclamation, "ANALISYS")
            txt_CodMue.Focus()
            Exit Sub
        End If
        If (Ctl_txt_nomMue.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre del tipo de muestra", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nomMue.Focus()
            Exit Sub
        End If
        If boo_flagM = True Then    '*** Si se trata de un nuevo tipo de muestra
            opr_Unidad.GuardarTipoMuestra(Val(txt_CodMue.Text), Ctl_txt_nomMue.texto_Recupera, Ctl_txt_desMue.Text, Trim(cmb_tiptuboM.Text.Substring(50, 3)))
        Else        '*** Si se trata de una actualizaci�n del tipo de muestra
            opr_Unidad.ActualizarTipoMuestra(Val(txt_CodMue.Text), Ctl_txt_nomMue.texto_Recupera, Ctl_txt_desMue.Text, Trim(cmb_tiptuboM.Text.Substring(50, 3)))
        End If

        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        Call limpiarCamposM()
        btn_AceptarMue.Enabled = False
        dgrdTipMuestra.SetDataBinding(opr_Unidad.LeerTiposMuestras(), "Registros")
    End Sub

    Private Sub limpiarCamposM()
        txt_CodMue.Text = ""
        Ctl_txt_nomMue.txt_padre.MaxLength = 100
        Ctl_txt_nomMue.texto_Asigna("")
        Ctl_txt_desMue.Text = ""
        cmb_tiptuboM.SelectedIndex = 0
    End Sub


    Private Sub dgrdTipMuestra_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrdTipMuestra.CurrentCellChanged
        dgrdTipMuestra.Select(dgrdTipMuestra.CurrentCell.RowNumber)
        btn_AceptarMue.Enabled = True
        btn_eliminarMue.Enabled = True
        grp_TipMue.Enabled = True
        Ctl_txt_nomMue.Enabled = False
        txt_CodMue.Text = dgrdTipMuestra.Item(dgrdTipMuestra.CurrentCell.RowNumber, 0)
        Ctl_txt_nomMue.texto_Asigna(dgrdTipMuestra.Item(dgrdTipMuestra.CurrentCell.RowNumber, 1))
        If (IsDBNull(dgrdTipMuestra.Item(dgrdTipMuestra.CurrentCell.RowNumber, 2))) Then
            Ctl_txt_desMue.Text = ""
        Else
            Ctl_txt_desMue.Text = (dgrdTipMuestra.Item(dgrdTipMuestra.CurrentCell.RowNumber, 2))
        End If
        boo_flagM = False
        Dim int_i As Short
        For int_i = 0 To (cmb_tiptuboM.Items.Count - 1)
            If (Val(cmb_tiptuboM.Items.Item(int_i).substring(50, 5)) = Val(dgrdTipMuestra.Item(dgrdTipMuestra.CurrentCell.RowNumber, 3).ToString())) Then
                cmb_tiptuboM.SelectedIndex = int_i
                Exit For
            End If
        Next
        Dim dgc_Celda As DataGridCell
        dgc_Celda.ColumnNumber = 0
        dgc_Celda.RowNumber = dgrdTipMuestra.CurrentCell.RowNumber
        dgrdTipMuestra.CurrentCell = dgc_Celda
        dgrdTipMuestra.Select(dgrdTipMuestra.CurrentCell.RowNumber)
    End Sub

    Private Sub frm_Parametros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        btn_AceptarUni.Enabled = False
        btn_Eliminar.Enabled = False
        txt_CodUni.Enabled = False
        Dim dt_uni As DataSet
        dgrd_Unidades.SetDataBinding(opr_Unidad.LeerUnidades, "Registros")
        grp_Uni.Enabled = False
        cmb_TipTubo.SelectedIndex = 0
    End Sub

    Private Sub btn_NuevoUni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call limpiarCamposU()
        sng_numTubo = opr_Unidad.LeerMaxCodUnidad() + 1
        txt_CodUni.Text = (sng_numTubo)
        btn_AceptarUni.Enabled = True
        Ctl_txt_nomUni.Focus()
        boo_flagU = True
    End Sub

    Private Sub dgrd_Unidades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Unidades.CurrentCellChanged
        dgrd_Unidades.Select(dgrd_Unidades.CurrentCell.RowNumber)
        btn_AceptarUni.Enabled = True
        btn_Eliminar.Enabled = True
        grp_Uni.Enabled = True
        txt_CodUni.Text = dgrd_Unidades.Item(dgrd_Unidades.CurrentCell.RowNumber, 0)
        Ctl_txt_nomUni.texto_Asigna(dgrd_Unidades.Item(dgrd_Unidades.CurrentCell.RowNumber, 1))
        If (dgrd_Unidades.Item(dgrd_Unidades.CurrentCell.RowNumber, 2) = "I") Then
            cmb_sistema_uni.Text = "Internacional"
        Else
            cmb_sistema_uni.Text = "Convencional"
        End If
        boo_flagU = False
        Dim dgc_Celda As DataGridCell
        dgc_Celda.ColumnNumber = 0
        dgc_Celda.RowNumber = dgrd_Unidades.CurrentCell.RowNumber
        dgrd_Unidades.CurrentCell = dgc_Celda
        dgrd_Unidades.Select(dgrd_Unidades.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_AceptarUni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_CodUni.Text = "") Then
            MsgBox("Ingrese el c�digo la unidad", MsgBoxStyle.Exclamation, "ANALISYS")
            txt_CodUni.Focus()
            Exit Sub
        End If
        If (Ctl_txt_nomUni.texto_Recupera = "") Then
            MsgBox("Ingrese la nomenclatura de la unidad", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nomUni.Focus()
            Exit Sub
        End If
        Dim uniTipo As String
        If (cmb_sistema_uni.Text = "Internacional") Then
            uniTipo = "S"
        Else
            uniTipo = "G"
        End If

        If boo_flagU = True Then    '*** Si se trata de una nueva unidad 
            opr_Unidad.GuardarUnidad(Val(txt_CodUni.Text), Ctl_txt_nomUni.texto_Recupera, uniTipo)
        Else    '*** Si se trata de una actualizaci�n a una unidad 
            opr_Unidad.Actualizarunidad(Val(txt_CodUni.Text), Ctl_txt_nomUni.texto_Recupera, uniTipo)
        End If
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        Call limpiarCamposU()
        btn_AceptarUni.Enabled = False
        dts_grid = opr_Unidad.LeerUnidades()
        dgrd_Unidades.DataSource = dts_grid
        dgrd_Unidades.Expand(-1)
        dgrd_Unidades.NavigateTo(0, "Registro")
    End Sub

    Private Sub limpiarCamposU()
        txt_CodUni.Text = ""
        Ctl_txt_nomUni.texto_Asigna("")
        Ctl_txt_nomUni.txt_padre.MaxLength = 20
        cmb_sistema_uni.Text = ""
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_CodUni.Text = "") Then
            MsgBox("Seleccione una unidad antes de eliminar", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        Else
            Dim obj_r As Object
            obj_r = MsgBox("Desea eliminar la unidad?", MsgBoxStyle.YesNo, "ANALISYS")
            If obj_r = vbYes Then
                opr_Unidad.EliminarUnidad(Val(txt_CodUni.Text))
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
                dgrd_Unidades.SetDataBinding(opr_Unidad.LeerUnidades(), "Registros")
            End If
            Call limpiarCamposU()
            btn_AceptarUni.Enabled = False
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub btn_eliminarMue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_CodMue.Text = "") Then
            MsgBox("Seleccione un tipo de muestra antes de eliminar", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        Else
            Dim obj_r As Object
            obj_r = MsgBox("Desea eliminar el tipo de muestra?", MsgBoxStyle.YesNo, "ANALISYS")
            If obj_r = vbYes Then
                opr_Unidad.EliminarTipoMuestra(Val(txt_CodMue.Text))
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
                dgrdTipMuestra.SetDataBinding(opr_Unidad.LeerTiposMuestras(), "Registros")
            End If
            Call limpiarCamposM()
            btn_AceptarMue.Enabled = False
            btn_eliminarMue.Enabled = False
        End If
    End Sub

    Private Sub btn_eliminarTub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_tubCodigo.Text = "") Then
            MsgBox("Seleccione un tipo de tubo antes de eliminar", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        Else
            Dim obj_r As Object
            obj_r = MsgBox("Desea eliminar el tipo de tubo?", MsgBoxStyle.YesNo, "ANALISYS")
            If obj_r = vbYes Then
                opr_Unidad.EliminarTipoTubo(Val(txt_tubCodigo.Text))
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
                dgrdTipTubos.SetDataBinding(opr_Unidad.LeerTiposTubos(), "Registros")
            End If
            Call limpiarCampos()
            btn_Aceptar.Enabled = False
            btn_eliminarTub.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AceptarUni.Click

        If (Ctl_txt_nomUni.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre de la unidad", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nomUni.Focus()
            Exit Sub
        End If
        'Verifico que no exista otra unidad con el mismo nombre
        If (opr_Unidad.BuscarUnidad(Ctl_txt_nomUni.texto_Recupera) = True And boo_flagU = True) Then
            MsgBox("La unidad ingresada ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nomUni.Focus()
            Exit Sub
        End If
        Dim uniTipo As String
        If (cmb_sistema_uni.Text = "Internacional") Then
            uniTipo = "I"
        Else
            uniTipo = "C"
        End If
        If boo_flagU = True Then    '*** Si se trata de una nueva unidad 
            opr_Unidad.GuardarUnidad(Val(txt_CodUni.Text), Ctl_txt_nomUni.texto_Recupera, uniTipo)
        Else    '*** Si se trata de una actualizaci�n a una unidad 
            Dim obj_r As Object
            obj_r = MsgBox("Desea actualizar los datos?", MsgBoxStyle.YesNo, "ANALISYS")
            If (obj_r = vbYes) Then
                opr_Unidad.Actualizarunidad(Val(txt_CodUni.Text), Ctl_txt_nomUni.texto_Recupera, uniTipo)
            Else
                Call limpiarCamposU()
                Exit Sub
            End If

        End If
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        Call limpiarCamposU()
        btn_AceptarUni.Enabled = False
        btn_Eliminar.Enabled = False
        dgrd_Unidades.SetDataBinding(opr_Unidad.LeerUnidades(), "Registros")
        grp_Uni.Enabled = False
    End Sub

    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If (txt_CodUni.Text = "") Then
            MsgBox("Seleccione una unidad antes de eliminar", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        Else
            Dim obj_r As Object
            obj_r = MsgBox("Desea eliminar la unidad?", MsgBoxStyle.YesNo, "ANALISYS")
            If obj_r = vbYes Then
                opr_Unidad.EliminarUnidad(Val(txt_CodUni.Text))
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
                dgrd_Unidades.SetDataBinding(opr_Unidad.LeerUnidades(), "Registros")
            End If
            Call limpiarCamposU()
            btn_AceptarUni.Enabled = False
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarUni.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevoUni.Click
        grp_Uni.Enabled = True
        Call limpiarCamposU()
        sng_numTubo = opr_Unidad.LeerMaxCodUnidad() + 1
        txt_CodUni.Text = (sng_numTubo)
        btn_AceptarUni.Enabled = True
        Ctl_txt_nomUni.Focus()
        boo_flagU = True
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevoMue.Click
        grp_TipMue.Enabled = True
        sng_numTubo = opr_Unidad.LeerMaxCodTipMuestra() + 1
        Call limpiarCamposM()
        txt_CodMue.Text = (sng_numTubo)
        btn_AceptarMue.Enabled = True
        Ctl_txt_nomMue.Focus()
        boo_flagM = True
    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AceptarMue.Click

        If (Ctl_txt_nomMue.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre del tipo de muestra", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nomMue.Focus()
            Exit Sub
        End If
        'Verifico que no exista otro tipo de muestra con el mismo nombre
        If (opr_Unidad.BuscarTipMuestra(Ctl_txt_nomMue.texto_Recupera) = True And boo_flagM = True) Then
            MsgBox("El Tipo de muestra ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nomMue.Focus()
            Exit Sub
        End If
        If boo_flagM = True Then    '*** Si se trata de un nuevo tipo de muestra
            opr_Unidad.GuardarTipoMuestra(Val(txt_CodMue.Text), Ctl_txt_nomMue.texto_Recupera, Ctl_txt_desMue.Text.ToString, Trim(cmb_tiptuboM.Text.Substring(50, 3)))
        Else        '*** Si se trata de una actualizaci�n del tipo de muestra
            opr_Unidad.ActualizarTipoMuestra(Val(txt_CodMue.Text), Ctl_txt_nomMue.texto_Recupera, Ctl_txt_desMue.Text.ToString, Trim(cmb_tiptuboM.Text.Substring(50, 3)))
        End If

        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        Call limpiarCamposM()
        btn_AceptarMue.Enabled = False
        dgrdTipMuestra.SetDataBinding(opr_Unidad.LeerTiposMuestras(), "Registros")
        grp_TipMue.Enabled = False
    End Sub

    Private Sub Button1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminarMue.Click
        If (txt_CodMue.Text = "") Then
            MsgBox("Seleccione un tipo de muestra antes de eliminar", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        Else
            Dim obj_r As Object
            obj_r = MsgBox("Desea eliminar el tipo de muestra?", MsgBoxStyle.YesNo, "ANALISYS")

            If obj_r = vbYes Then
                opr_Unidad.EliminarTipoMuestra(Val(txt_CodMue.Text))
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
                dts_grid = opr_Unidad.LeerTiposMuestras()
                dgrdTipMuestra.DataSource = dts_grid
                dgrdTipMuestra.Expand(-1)
                dgrdTipMuestra.NavigateTo(0, "Registro")

            End If
            Call limpiarCamposM()
            btn_AceptarMue.Enabled = False
            btn_eliminarMue.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarMue.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_6(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Call limpiarCampos()
        grp_TipTubo.Enabled = True
        sng_numTubo = opr_Unidad.LeerMaxCodTipTubo() + 1
        txt_tubCodigo.Text = (sng_numTubo)
        btn_Aceptar.Enabled = True
        txt_TubNom.Focus()
        boo_flag = True
    End Sub

    Private Sub Button1_Click_7(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If (txt_TubNom.Text = "") Then
            MsgBox("Ingrese el nombre del tipo de tubo", MsgBoxStyle.Exclamation, "ANALISYS")
            txt_TubNom.Focus()
            Exit Sub
        End If
        If boo_flag = True Then    '*** Si se trata de un nuevo tubo
            opr_Unidad.GuardarTipoTubo(Val(txt_tubCodigo.Text), txt_TubNom.Text, txt_ObsTipTubo.Text, cmb_TipTubo.Text)
        Else
            opr_Unidad.ActualizarTipoTubos(Val(txt_tubCodigo.Text), txt_TubNom.Text, txt_ObsTipTubo.Text, cmb_TipTubo.Text)
        End If
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        Call limpiarCampos()
        btn_Aceptar.Enabled = False
        dgrdTipTubos.SetDataBinding(opr_Unidad.LeerTiposTubos(), "Registros")
        grp_TipTubo.Enabled = False
    End Sub

    Private Sub btn_eliminarTub_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminarTub.Click
        If (txt_tubCodigo.Text = "") Then
            MsgBox("Seleccione un tipo de tubo antes de eliminar", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        Else
            If MsgBox("Desea eliminar el tipo de tubo?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
                opr_Unidad.EliminarTipoTubo(Val(txt_tubCodigo.Text))
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
                dgrdTipTubos.SetDataBinding(opr_Unidad.LeerTiposTubos(), "Registros")
            End If
            Call limpiarCampos()
            grp_TipTubo.Enabled = False
            btn_Aceptar.Enabled = False
            btn_eliminarTub.Enabled = False
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_CancelarEqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_NuevaEqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''LLena los combos de unidades 
        'boo_flagUE = True
        'btn_AceptarEqui.Enabled = True
        'grp_UniEqui.Enabled = True
        ''opr_Unidad.LLenarCmbUnidad(cmb_Unidad1)
        ''opr_Unidad.LLenarCmbUnidad(cmb_Unidad2)
        'Ctl_txt_factor.texto_Asigna("")
        'boo_flagUE = True
    End Sub

    Private Sub btn_AceptarEqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (cmb_Unidad1.Text = "" Or cmb_Unidad2.Text = "") Then
        '    MsgBox("Seleccione dos unidades equivalentes", MsgBoxStyle.Exclamation, "ANALISYS")
        '    cmb_Unidad1.Focus()
        '    Exit Sub
        'End If
        'If (cmb_Unidad1.Text = cmb_Unidad2.Text) Then
        '    MsgBox("La misma unidad no puede ser equivalente", MsgBoxStyle.Exclamation, "ANALISYS")
        '    cmb_Unidad1.Focus()
        '    Exit Sub
        'End If
        'If (Ctl_txt_factor.texto_Recupera = "") Then
        '    MsgBox("Ingrese el factor de conversi�n entre las unidades", MsgBoxStyle.Exclamation, "ANALISYS")
        '    Ctl_txt_factor.Focus()
        '    Exit Sub
        'End If
        'Dim int_unidad1 As Integer
        'Dim int_unidad2 As Integer
        'Dim dts_uni As DataSet
        'Dim dtr_fila As DataRow

        'Recupero el uni_id, c�digo, de cada unidad en los dos combos 
        'dts_uni = opr_Unidad.codUnidad(cmb_Unidad1.Text)
        'For Each dtr_fila In dts_uni.Tables("Registros").Rows
        '    int_unidad1 = dtr_fila(0)
        'Next

        'dts_uni = opr_Unidad.codUnidad(cmb_Unidad2.Text)
        'For Each dtr_fila In dts_uni.Tables("Registros").Rows
        '    int_unidad2 = dtr_fila(0)
        'Next

        ''Verificamos que no exista la equivalencia entre las dos unidades 
        'dts_uni = opr_Unidad.VerificarEqui(int_unidad1, int_unidad2)
        'For Each dtr_fila In dts_uni.Tables("Registros").Rows
        '    If (Not IsDBNull(dtr_fila(0)) And boo_flagUE = True) Then
        '        MsgBox("La equivalencia entre las dos unidades ya existe, no es posible guardar.", MsgBoxStyle.Exclamation, "ANALISYS")
        '        Exit Sub
        '    End If
        'Next
        'If boo_flagUE = True Then    '*** Si se trata de una nueva equivalencia
        '    int_codId = opr_Unidad.LeerMaxCodUniEqui() + 1
        '    opr_Unidad.GuardarUniEqui(int_unidad1, int_unidad2, int_codId, Ctl_txt_factor.texto_Recupera)
        'Else    '*** Si se trata de una actualizaci�n a una Equivalencia Unidad 
        '    If MsgBox("Desea actualizar los datos?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
        '        opr_Unidad.ActualizarUniEqui(int_codId, int_unidad1, int_unidad2, Ctl_txt_factor.texto_Recupera)
        '    Else
        '        Exit Sub
        '    End If
        'End If
        'MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'btn_AceptarEqui.Enabled = False
        'btn_EliminarEqui.Enabled = False
        'dgrd_UniEqui.SetDataBinding(opr_Unidad.LeerUniEqui(), "Registros")
        'Call LimpiarCamposUE()
        'grp_UniEqui.Enabled = False
    End Sub

    Private Sub dgrd_UniEqui_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'dgrd_UniEqui.Select(dgrd_UniEqui.CurrentCell.RowNumber)
        'btn_AceptarEqui.Enabled = True
        'btn_EliminarEqui.Enabled = True
        'boo_flagUE = False
        'grp_UniEqui.Enabled = True
        'int_codId = dgrd_UniEqui.Item(dgrd_UniEqui.CurrentCell.RowNumber, 0)
        'cmb_Unidad1.Text = dgrd_UniEqui.Item(dgrd_UniEqui.CurrentCell.RowNumber, 1)
        'cmb_Unidad2.Text = dgrd_UniEqui.Item(dgrd_UniEqui.CurrentCell.RowNumber, 3)
        'Ctl_txt_factor.texto_Asigna(dgrd_UniEqui.Item(dgrd_UniEqui.CurrentCell.RowNumber, 2))
        'Dim dgc_Celda As DataGridCell
        'dgc_Celda.ColumnNumber = 0
        'dgc_Celda.RowNumber = dgrd_UniEqui.CurrentCell.RowNumber
        'dgrd_UniEqui.CurrentCell = dgc_Celda
        'dgrd_UniEqui.Select(dgrd_UniEqui.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_EliminarEqui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If MsgBox("Desea eliminar la equivalencia seleccionada?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
        '    opr_Unidad.EliminarUniEqui(int_codId)
        '    dgrd_UniEqui.SetDataBinding(opr_Unidad.LeerUniEqui(), "Registros")
        '    MsgBox(" Datos Eliminados ", MsgBoxStyle.Information, "ANALISYS")
        'End If
        'Call LimpiarCamposUE()
        'btn_AceptarEqui.Enabled = False
        'btn_EliminarEqui.Enabled = False
        'grp_UniEqui.Enabled = False
    End Sub

    Private Sub LimpiarCamposUE()
        'cmb_Unidad1.SelectedIndex = 0
        'cmb_Unidad2.SelectedIndex = 0
        'Ctl_txt_factor.txt_padre.MaxLength = 10
        'Ctl_txt_factor.texto_Asigna("")
    End Sub


    
    
End Class