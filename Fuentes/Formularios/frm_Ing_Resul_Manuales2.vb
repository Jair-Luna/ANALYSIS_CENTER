Public Class frm_Ing_Resul_Manuales
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
    Friend WithEvents grp_uroanalisis As System.Windows.Forms.GroupBox
    Friend WithEvents txt_aspecto As System.Windows.Forms.TextBox
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PH As System.Windows.Forms.Label
    Friend WithEvents lbl_densidad As System.Windows.Forms.Label
    Friend WithEvents lbl_aspecto As System.Windows.Forms.Label
    Friend WithEvents lbl_color As System.Windows.Forms.Label
    Friend WithEvents lbl_Macro As System.Windows.Forms.Label
    Friend WithEvents chk_Obs2 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_obs2 As System.Windows.Forms.TextBox
    Friend WithEvents chk_piocitos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_moco As System.Windows.Forms.CheckBox
    Friend WithEvents chk_proteinas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_nitritos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_urobilinog As System.Windows.Forms.CheckBox
    Friend WithEvents chk_bilirrubinas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_glucosas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cetonas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_bacterias As System.Windows.Forms.CheckBox
    Friend WithEvents txt_moco As System.Windows.Forms.TextBox
    Friend WithEvents txt_piocitos As System.Windows.Forms.TextBox
    Friend WithEvents txt_cetonas As System.Windows.Forms.TextBox
    Friend WithEvents txt_bacterias As System.Windows.Forms.TextBox
    Friend WithEvents txt_bilirrubinas As System.Windows.Forms.TextBox
    Friend WithEvents txt_nitritos As System.Windows.Forms.TextBox
    Friend WithEvents txt_glucosa As System.Windows.Forms.TextBox
    Friend WithEvents txt_proteinas As System.Windows.Forms.TextBox
    Friend WithEvents txt_urobilinog As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_pac As System.Windows.Forms.Label
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents lbl_test_nombre As System.Windows.Forms.Label
    Friend WithEvents btn_busqueda As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_resultado As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_numerico As Ctl_txt.ctl_txt_numeros
    Friend WithEvents cmb_cualitativo As System.Windows.Forms.ComboBox
    Friend WithEvents grp_general As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_unidades As System.Windows.Forms.ComboBox
    Friend WithEvents chk_unidades As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ObsG As System.Windows.Forms.TextBox
    Friend WithEvents txt_formula As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PedFec As System.Windows.Forms.Label
    Friend WithEvents lbl_pedidoD As System.Windows.Forms.Label
    Friend WithEvents lbl_pacD As System.Windows.Forms.Label
    Friend WithEvents chk_cilindros As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cilindros As System.Windows.Forms.TextBox
    Friend WithEvents chk_leucocitos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_leucocitos As System.Windows.Forms.TextBox
    Friend WithEvents chk_hemoglobina As System.Windows.Forms.CheckBox
    Friend WithEvents txt_hemoglobina As System.Windows.Forms.TextBox
    Friend WithEvents txt_hematies As System.Windows.Forms.TextBox
    Friend WithEvents chk_hematies As System.Windows.Forms.CheckBox
    Friend WithEvents txt_levadurasU As System.Windows.Forms.TextBox
    Friend WithEvents chk_levadurasU As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_rango As System.Windows.Forms.Label
    Friend WithEvents lbl_rangod As System.Windows.Forms.Label
    Friend WithEvents btn_ObsPac As System.Windows.Forms.Button
    Friend WithEvents lbl_fecnacd As System.Windows.Forms.Label
    Friend WithEvents lbl_fecnac As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents lbl_edadl As System.Windows.Forms.Label
    Friend WithEvents chk_celulas As System.Windows.Forms.CheckBox
    Friend WithEvents txt_leucocitosc As System.Windows.Forms.TextBox
    Friend WithEvents chk_leucocitosc As System.Windows.Forms.CheckBox
    Friend WithEvents txt_chialinos As System.Windows.Forms.TextBox
    Friend WithEvents chk_cHialinos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_chemeticos As System.Windows.Forms.TextBox
    Friend WithEvents chk_chemeticos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cgranulosos As System.Windows.Forms.TextBox
    Friend WithEvents chk_cgranulosos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cleucocitarios As System.Windows.Forms.TextBox
    Friend WithEvents chk_cleucocitarios As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cristalesAmo As System.Windows.Forms.CheckBox
    Friend WithEvents txt_ccereos As System.Windows.Forms.TextBox
    Friend WithEvents chk_ccereos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_espermatozoides As System.Windows.Forms.TextBox
    Friend WithEvents chk_espermatozoides As System.Windows.Forms.CheckBox
    Friend WithEvents txt_uratosA As System.Windows.Forms.TextBox
    Friend WithEvents chk_uratosA As System.Windows.Forms.CheckBox
    Friend WithEvents txt_fosfatosA As System.Windows.Forms.TextBox
    Friend WithEvents chk_fosfatosA As System.Windows.Forms.CheckBox
    Friend WithEvents chk_oxalatoAmo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_oxalatoCal As System.Windows.Forms.CheckBox
    Friend WithEvents txt_oxalatoCal As System.Windows.Forms.TextBox
    Friend WithEvents txt_fosfatoTri As System.Windows.Forms.TextBox
    Friend WithEvents chk_fosfatoTri As System.Windows.Forms.CheckBox
    Friend WithEvents chk_uratoAmo As System.Windows.Forms.CheckBox
    Friend WithEvents txt_crisAciUri As System.Windows.Forms.TextBox
    Friend WithEvents chk_crisAciUri As System.Windows.Forms.CheckBox
    Friend WithEvents txt_celulasRed As System.Windows.Forms.TextBox
    Friend WithEvents chk_celulasRed As System.Windows.Forms.CheckBox
    Friend WithEvents txt_celulas As System.Windows.Forms.TextBox
    Friend WithEvents txt_oxalatoamo As System.Windows.Forms.TextBox
    Friend WithEvents txt_cristalesAmo As System.Windows.Forms.TextBox
    Friend WithEvents txt_uratoamo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_densidad As Ctl_txt.ctl_txt_numeros
    Friend WithEvents txt_PH As Ctl_txt.ctl_txt_numeros
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_moco As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_HimDimL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_HimDimH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_HimNanL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_HimNanH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tenSolL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tenSolH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_estrongiloidesL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_estrongiloidesH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_oxiurosL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_OxiurosH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_uncinariasL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_uncinariasH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ascLumL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ascLumH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tricocefaloL As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tricocefaloH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_BalColT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_BalColQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_TriHomT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_TriHomQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_GiaLamT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_GiaLamQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_chilomastixT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_chilomastixQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_embadomaT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_embadomaQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_enteromaT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_enteromaQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_endNanT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_endNanQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_yodamebaT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_yodamebaQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ameColT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ameColQ As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ameHisT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_AmeHisQ As System.Windows.Forms.ComboBox
    Friend WithEvents txt_obsc As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chk_obsC As System.Windows.Forms.CheckBox
    Friend WithEvents txt_piocitosC As System.Windows.Forms.TextBox
    Friend WithEvents txt_celulasC As System.Windows.Forms.TextBox
    Friend WithEvents lbl_consistencia As System.Windows.Forms.Label
    Friend WithEvents txt_consistencia As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_colorC As System.Windows.Forms.TextBox
    Friend WithEvents lbl_anaEle As System.Windows.Forms.Label
    Friend WithEvents pnl_coproanalisis As System.Windows.Forms.Panel
    Friend WithEvents txt_PMN As Ctl_txt.ctl_txt_numeros
    Friend WithEvents cmb_SanOcu As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_resVeg As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_almidones As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_grasas As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_levaduras As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_blaHom As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Hongos As System.Windows.Forms.ComboBox
    Friend WithEvents chk_ameHis As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AmeCol As System.Windows.Forms.CheckBox
    Friend WithEvents chk_EndNan As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Yodameba As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Enteromona As System.Windows.Forms.CheckBox
    Friend WithEvents chk_balCol As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TriHom As System.Windows.Forms.CheckBox
    Friend WithEvents chk_GiaLam As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Chilomastix As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Embadomona As System.Windows.Forms.CheckBox
    Friend WithEvents chk_oxiuros As System.Windows.Forms.CheckBox
    Friend WithEvents chk_uncinarias As System.Windows.Forms.CheckBox
    Friend WithEvents chk_AscLum As System.Windows.Forms.CheckBox
    Friend WithEvents chk_tricocefalo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_HimDim As System.Windows.Forms.CheckBox
    Friend WithEvents chk_HimNana As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TenSol As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Estrongiloides As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PMN As System.Windows.Forms.CheckBox
    Friend WithEvents chk_MocoC As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CelulasC As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PiocitosC As System.Windows.Forms.CheckBox
    Friend WithEvents chk_hematiesC As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Hongos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Grasas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Almidones As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ResVeg As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SanOcu As System.Windows.Forms.CheckBox
    Friend WithEvents chk_BlaHom As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Levaduras As System.Windows.Forms.CheckBox
    Friend WithEvents txt_hematiesC As System.Windows.Forms.TextBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents pic_min As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_Ing_Resul_Manuales))
        Me.btn_busqueda = New System.Windows.Forms.Button()
        Me.grp_uroanalisis = New System.Windows.Forms.GroupBox()
        Me.txt_PH = New Ctl_txt.ctl_txt_numeros()
        Me.txt_densidad = New Ctl_txt.ctl_txt_numeros()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_celulasRed = New System.Windows.Forms.TextBox()
        Me.chk_celulasRed = New System.Windows.Forms.CheckBox()
        Me.txt_crisAciUri = New System.Windows.Forms.TextBox()
        Me.chk_crisAciUri = New System.Windows.Forms.CheckBox()
        Me.txt_uratoamo = New System.Windows.Forms.TextBox()
        Me.chk_uratoAmo = New System.Windows.Forms.CheckBox()
        Me.txt_fosfatoTri = New System.Windows.Forms.TextBox()
        Me.chk_fosfatoTri = New System.Windows.Forms.CheckBox()
        Me.chk_oxalatoCal = New System.Windows.Forms.CheckBox()
        Me.txt_oxalatoCal = New System.Windows.Forms.TextBox()
        Me.chk_oxalatoAmo = New System.Windows.Forms.CheckBox()
        Me.txt_oxalatoamo = New System.Windows.Forms.TextBox()
        Me.txt_fosfatosA = New System.Windows.Forms.TextBox()
        Me.chk_fosfatosA = New System.Windows.Forms.CheckBox()
        Me.txt_uratosA = New System.Windows.Forms.TextBox()
        Me.chk_uratosA = New System.Windows.Forms.CheckBox()
        Me.txt_espermatozoides = New System.Windows.Forms.TextBox()
        Me.chk_espermatozoides = New System.Windows.Forms.CheckBox()
        Me.txt_ccereos = New System.Windows.Forms.TextBox()
        Me.chk_ccereos = New System.Windows.Forms.CheckBox()
        Me.txt_cleucocitarios = New System.Windows.Forms.TextBox()
        Me.chk_cleucocitarios = New System.Windows.Forms.CheckBox()
        Me.txt_cgranulosos = New System.Windows.Forms.TextBox()
        Me.chk_cgranulosos = New System.Windows.Forms.CheckBox()
        Me.txt_chemeticos = New System.Windows.Forms.TextBox()
        Me.chk_chemeticos = New System.Windows.Forms.CheckBox()
        Me.txt_chialinos = New System.Windows.Forms.TextBox()
        Me.chk_cHialinos = New System.Windows.Forms.CheckBox()
        Me.txt_leucocitosc = New System.Windows.Forms.TextBox()
        Me.chk_leucocitosc = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_levadurasU = New System.Windows.Forms.TextBox()
        Me.chk_levadurasU = New System.Windows.Forms.CheckBox()
        Me.txt_hematies = New System.Windows.Forms.TextBox()
        Me.chk_hematies = New System.Windows.Forms.CheckBox()
        Me.chk_hemoglobina = New System.Windows.Forms.CheckBox()
        Me.txt_hemoglobina = New System.Windows.Forms.TextBox()
        Me.chk_leucocitos = New System.Windows.Forms.CheckBox()
        Me.txt_leucocitos = New System.Windows.Forms.TextBox()
        Me.chk_nitritos = New System.Windows.Forms.CheckBox()
        Me.txt_nitritos = New System.Windows.Forms.TextBox()
        Me.txt_aspecto = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.lbl_PH = New System.Windows.Forms.Label()
        Me.lbl_densidad = New System.Windows.Forms.Label()
        Me.lbl_aspecto = New System.Windows.Forms.Label()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_Macro = New System.Windows.Forms.Label()
        Me.chk_proteinas = New System.Windows.Forms.CheckBox()
        Me.txt_proteinas = New System.Windows.Forms.TextBox()
        Me.chk_glucosas = New System.Windows.Forms.CheckBox()
        Me.txt_glucosa = New System.Windows.Forms.TextBox()
        Me.chk_cetonas = New System.Windows.Forms.CheckBox()
        Me.txt_cetonas = New System.Windows.Forms.TextBox()
        Me.txt_urobilinog = New System.Windows.Forms.TextBox()
        Me.chk_urobilinog = New System.Windows.Forms.CheckBox()
        Me.chk_bilirrubinas = New System.Windows.Forms.CheckBox()
        Me.txt_bilirrubinas = New System.Windows.Forms.TextBox()
        Me.txt_moco = New System.Windows.Forms.TextBox()
        Me.chk_moco = New System.Windows.Forms.CheckBox()
        Me.chk_bacterias = New System.Windows.Forms.CheckBox()
        Me.txt_bacterias = New System.Windows.Forms.TextBox()
        Me.txt_piocitos = New System.Windows.Forms.TextBox()
        Me.chk_piocitos = New System.Windows.Forms.CheckBox()
        Me.txt_celulas = New System.Windows.Forms.TextBox()
        Me.chk_celulas = New System.Windows.Forms.CheckBox()
        Me.chk_cristalesAmo = New System.Windows.Forms.CheckBox()
        Me.txt_cristalesAmo = New System.Windows.Forms.TextBox()
        Me.txt_cilindros = New System.Windows.Forms.TextBox()
        Me.chk_cilindros = New System.Windows.Forms.CheckBox()
        Me.txt_obs2 = New System.Windows.Forms.TextBox()
        Me.chk_Obs2 = New System.Windows.Forms.CheckBox()
        Me.grp_datos = New System.Windows.Forms.GroupBox()
        Me.lbl_fecnacd = New System.Windows.Forms.Label()
        Me.lbl_fecnac = New System.Windows.Forms.Label()
        Me.btn_ObsPac = New System.Windows.Forms.Button()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.lbl_edadl = New System.Windows.Forms.Label()
        Me.lbl_pacD = New System.Windows.Forms.Label()
        Me.lbl_pedidoD = New System.Windows.Forms.Label()
        Me.lbl_PedFec = New System.Windows.Forms.Label()
        Me.lbl_test_nombre = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_pac = New System.Windows.Forms.Label()
        Me.lbl_pedido = New System.Windows.Forms.Label()
        Me.lbl_test = New System.Windows.Forms.Label()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.grp_general = New System.Windows.Forms.GroupBox()
        Me.lbl_rangod = New System.Windows.Forms.Label()
        Me.lbl_rango = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_unidades = New System.Windows.Forms.ComboBox()
        Me.cmb_cualitativo = New System.Windows.Forms.ComboBox()
        Me.Ctl_txt_numerico = New Ctl_txt.ctl_txt_numeros()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.chk_unidades = New System.Windows.Forms.CheckBox()
        Me.txt_formula = New System.Windows.Forms.TextBox()
        Me.txt_ObsG = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmb_moco = New System.Windows.Forms.ComboBox()
        Me.cmb_HimDimL = New System.Windows.Forms.ComboBox()
        Me.cmb_HimDimH = New System.Windows.Forms.ComboBox()
        Me.cmb_HimNanL = New System.Windows.Forms.ComboBox()
        Me.cmb_HimNanH = New System.Windows.Forms.ComboBox()
        Me.cmb_tenSolL = New System.Windows.Forms.ComboBox()
        Me.cmb_tenSolH = New System.Windows.Forms.ComboBox()
        Me.cmb_estrongiloidesL = New System.Windows.Forms.ComboBox()
        Me.cmb_estrongiloidesH = New System.Windows.Forms.ComboBox()
        Me.cmb_oxiurosL = New System.Windows.Forms.ComboBox()
        Me.cmb_OxiurosH = New System.Windows.Forms.ComboBox()
        Me.cmb_uncinariasL = New System.Windows.Forms.ComboBox()
        Me.cmb_uncinariasH = New System.Windows.Forms.ComboBox()
        Me.cmb_ascLumL = New System.Windows.Forms.ComboBox()
        Me.cmb_ascLumH = New System.Windows.Forms.ComboBox()
        Me.cmb_tricocefaloL = New System.Windows.Forms.ComboBox()
        Me.cmb_tricocefaloH = New System.Windows.Forms.ComboBox()
        Me.cmb_BalColT = New System.Windows.Forms.ComboBox()
        Me.cmb_BalColQ = New System.Windows.Forms.ComboBox()
        Me.cmb_TriHomT = New System.Windows.Forms.ComboBox()
        Me.cmb_TriHomQ = New System.Windows.Forms.ComboBox()
        Me.cmb_GiaLamT = New System.Windows.Forms.ComboBox()
        Me.cmb_GiaLamQ = New System.Windows.Forms.ComboBox()
        Me.cmb_chilomastixT = New System.Windows.Forms.ComboBox()
        Me.cmb_chilomastixQ = New System.Windows.Forms.ComboBox()
        Me.cmb_embadomaT = New System.Windows.Forms.ComboBox()
        Me.cmb_embadomaQ = New System.Windows.Forms.ComboBox()
        Me.cmb_enteromaT = New System.Windows.Forms.ComboBox()
        Me.cmb_enteromaQ = New System.Windows.Forms.ComboBox()
        Me.cmb_endNanT = New System.Windows.Forms.ComboBox()
        Me.cmb_endNanQ = New System.Windows.Forms.ComboBox()
        Me.cmb_yodamebaT = New System.Windows.Forms.ComboBox()
        Me.cmb_yodamebaQ = New System.Windows.Forms.ComboBox()
        Me.cmb_ameColT = New System.Windows.Forms.ComboBox()
        Me.cmb_ameColQ = New System.Windows.Forms.ComboBox()
        Me.cmb_ameHisT = New System.Windows.Forms.ComboBox()
        Me.cmb_AmeHisQ = New System.Windows.Forms.ComboBox()
        Me.txt_obsc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chk_obsC = New System.Windows.Forms.CheckBox()
        Me.txt_piocitosC = New System.Windows.Forms.TextBox()
        Me.txt_celulasC = New System.Windows.Forms.TextBox()
        Me.lbl_consistencia = New System.Windows.Forms.Label()
        Me.txt_consistencia = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_colorC = New System.Windows.Forms.TextBox()
        Me.lbl_anaEle = New System.Windows.Forms.Label()
        Me.pnl_coproanalisis = New System.Windows.Forms.Panel()
        Me.cmb_almidones = New System.Windows.Forms.ComboBox()
        Me.cmb_resVeg = New System.Windows.Forms.ComboBox()
        Me.cmb_SanOcu = New System.Windows.Forms.ComboBox()
        Me.txt_PMN = New Ctl_txt.ctl_txt_numeros()
        Me.chk_SanOcu = New System.Windows.Forms.CheckBox()
        Me.chk_PMN = New System.Windows.Forms.CheckBox()
        Me.chk_MocoC = New System.Windows.Forms.CheckBox()
        Me.chk_CelulasC = New System.Windows.Forms.CheckBox()
        Me.chk_PiocitosC = New System.Windows.Forms.CheckBox()
        Me.chk_hematiesC = New System.Windows.Forms.CheckBox()
        Me.chk_oxiuros = New System.Windows.Forms.CheckBox()
        Me.chk_uncinarias = New System.Windows.Forms.CheckBox()
        Me.chk_AscLum = New System.Windows.Forms.CheckBox()
        Me.chk_tricocefalo = New System.Windows.Forms.CheckBox()
        Me.chk_Enteromona = New System.Windows.Forms.CheckBox()
        Me.chk_EndNan = New System.Windows.Forms.CheckBox()
        Me.chk_Yodameba = New System.Windows.Forms.CheckBox()
        Me.chk_AmeCol = New System.Windows.Forms.CheckBox()
        Me.chk_ameHis = New System.Windows.Forms.CheckBox()
        Me.cmb_Hongos = New System.Windows.Forms.ComboBox()
        Me.txt_hematiesC = New System.Windows.Forms.TextBox()
        Me.cmb_blaHom = New System.Windows.Forms.ComboBox()
        Me.cmb_levaduras = New System.Windows.Forms.ComboBox()
        Me.cmb_grasas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chk_balCol = New System.Windows.Forms.CheckBox()
        Me.chk_TriHom = New System.Windows.Forms.CheckBox()
        Me.chk_GiaLam = New System.Windows.Forms.CheckBox()
        Me.chk_Chilomastix = New System.Windows.Forms.CheckBox()
        Me.chk_Embadomona = New System.Windows.Forms.CheckBox()
        Me.chk_HimDim = New System.Windows.Forms.CheckBox()
        Me.chk_HimNana = New System.Windows.Forms.CheckBox()
        Me.chk_TenSol = New System.Windows.Forms.CheckBox()
        Me.chk_Estrongiloides = New System.Windows.Forms.CheckBox()
        Me.chk_Hongos = New System.Windows.Forms.CheckBox()
        Me.chk_Levaduras = New System.Windows.Forms.CheckBox()
        Me.chk_Grasas = New System.Windows.Forms.CheckBox()
        Me.chk_Almidones = New System.Windows.Forms.CheckBox()
        Me.chk_ResVeg = New System.Windows.Forms.CheckBox()
        Me.chk_BlaHom = New System.Windows.Forms.CheckBox()
        Me.pan_barra = New System.Windows.Forms.Panel()
        Me.pic_icono = New System.Windows.Forms.PictureBox()
        Me.pan_btn = New System.Windows.Forms.Panel()
        Me.pic_min = New System.Windows.Forms.PictureBox()
        Me.Pic_close = New System.Windows.Forms.PictureBox()
        Me.lbl_textform = New System.Windows.Forms.Label()
        Me.pic_barra = New System.Windows.Forms.PictureBox()
        Me.grp_uroanalisis.SuspendLayout()
        Me.grp_datos.SuspendLayout()
        Me.grp_general.SuspendLayout()
        Me.pnl_coproanalisis.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        Me.pan_btn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_busqueda
        '
        Me.btn_busqueda.BackgroundImage = CType(resources.GetObject("btn_busqueda.BackgroundImage"), System.Drawing.Bitmap)
        Me.btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_busqueda.ForeColor = System.Drawing.Color.Black
        Me.btn_busqueda.Image = CType(resources.GetObject("btn_busqueda.Image"), System.Drawing.Bitmap)
        Me.btn_busqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_busqueda.Location = New System.Drawing.Point(468, 20)
        Me.btn_busqueda.Name = "btn_busqueda"
        Me.btn_busqueda.Size = New System.Drawing.Size(80, 24)
        Me.btn_busqueda.TabIndex = 0
        Me.btn_busqueda.Text = "Búsqueda"
        Me.btn_busqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grp_uroanalisis
        '
        Me.grp_uroanalisis.BackColor = System.Drawing.Color.Transparent
        Me.grp_uroanalisis.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_PH, Me.txt_densidad, Me.Label6, Me.txt_celulasRed, Me.chk_celulasRed, Me.txt_crisAciUri, Me.chk_crisAciUri, Me.txt_uratoamo, Me.chk_uratoAmo, Me.txt_fosfatoTri, Me.chk_fosfatoTri, Me.chk_oxalatoCal, Me.txt_oxalatoCal, Me.chk_oxalatoAmo, Me.txt_oxalatoamo, Me.txt_fosfatosA, Me.chk_fosfatosA, Me.txt_uratosA, Me.chk_uratosA, Me.txt_espermatozoides, Me.chk_espermatozoides, Me.txt_ccereos, Me.chk_ccereos, Me.txt_cleucocitarios, Me.chk_cleucocitarios, Me.txt_cgranulosos, Me.chk_cgranulosos, Me.txt_chemeticos, Me.chk_chemeticos, Me.txt_chialinos, Me.chk_cHialinos, Me.txt_leucocitosc, Me.chk_leucocitosc, Me.Label7, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.txt_levadurasU, Me.chk_levadurasU, Me.txt_hematies, Me.chk_hematies, Me.chk_hemoglobina, Me.txt_hemoglobina, Me.chk_leucocitos, Me.txt_leucocitos, Me.chk_nitritos, Me.txt_nitritos, Me.txt_aspecto, Me.txt_color, Me.lbl_PH, Me.lbl_densidad, Me.lbl_aspecto, Me.lbl_color, Me.lbl_Macro, Me.chk_proteinas, Me.txt_proteinas, Me.chk_glucosas, Me.txt_glucosa, Me.chk_cetonas, Me.txt_cetonas, Me.txt_urobilinog, Me.chk_urobilinog, Me.chk_bilirrubinas, Me.txt_bilirrubinas, Me.txt_moco, Me.chk_moco, Me.chk_bacterias, Me.txt_bacterias, Me.txt_piocitos, Me.chk_piocitos, Me.txt_celulas, Me.chk_celulas, Me.chk_cristalesAmo, Me.txt_cristalesAmo, Me.txt_cilindros, Me.chk_cilindros, Me.txt_obs2, Me.chk_Obs2})
        Me.grp_uroanalisis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_uroanalisis.ForeColor = System.Drawing.Color.Navy
        Me.grp_uroanalisis.Location = New System.Drawing.Point(17, 128)
        Me.grp_uroanalisis.Name = "grp_uroanalisis"
        Me.grp_uroanalisis.Size = New System.Drawing.Size(558, 448)
        Me.grp_uroanalisis.TabIndex = 53
        Me.grp_uroanalisis.TabStop = False
        Me.grp_uroanalisis.Text = "ELEMENTAL Y MICROSCOPICO DE ORINA"
        Me.grp_uroanalisis.Visible = False
        '
        'txt_PH
        '
        Me.txt_PH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PH.Location = New System.Drawing.Point(404, 48)
        Me.txt_PH.Name = "txt_PH"
        Me.txt_PH.Prp_Formato = True
        Me.txt_PH.Prp_NumDecimales = 1
        Me.txt_PH.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.txt_PH.Prp_ValDefault = ""
        Me.txt_PH.Size = New System.Drawing.Size(146, 20)
        Me.txt_PH.TabIndex = 4
        '
        'txt_densidad
        '
        Me.txt_densidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_densidad.Location = New System.Drawing.Point(126, 46)
        Me.txt_densidad.Name = "txt_densidad"
        Me.txt_densidad.Prp_Formato = True
        Me.txt_densidad.Prp_NumDecimales = 2
        Me.txt_densidad.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.txt_densidad.Prp_ValDefault = "0"
        Me.txt_densidad.Size = New System.Drawing.Size(138, 20)
        Me.txt_densidad.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(510, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 14)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "mg/dL"
        '
        'txt_celulasRed
        '
        Me.txt_celulasRed.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_celulasRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_celulasRed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celulasRed.Location = New System.Drawing.Point(404, 370)
        Me.txt_celulasRed.MaxLength = 150
        Me.txt_celulasRed.Name = "txt_celulasRed"
        Me.txt_celulasRed.ReadOnly = True
        Me.txt_celulasRed.Size = New System.Drawing.Size(142, 21)
        Me.txt_celulasRed.TabIndex = 64
        Me.txt_celulasRed.Text = "NEGATIVO"
        '
        'chk_celulasRed
        '
        Me.chk_celulasRed.Location = New System.Drawing.Point(284, 374)
        Me.chk_celulasRed.Name = "chk_celulasRed"
        Me.chk_celulasRed.Size = New System.Drawing.Size(120, 16)
        Me.chk_celulasRed.TabIndex = 63
        Me.chk_celulasRed.Tag = "Células Redondas:"
        Me.chk_celulasRed.Text = "Célul. Redondas:"
        '
        'txt_crisAciUri
        '
        Me.txt_crisAciUri.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_crisAciUri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_crisAciUri.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_crisAciUri.Location = New System.Drawing.Point(404, 350)
        Me.txt_crisAciUri.MaxLength = 150
        Me.txt_crisAciUri.Name = "txt_crisAciUri"
        Me.txt_crisAciUri.ReadOnly = True
        Me.txt_crisAciUri.Size = New System.Drawing.Size(142, 21)
        Me.txt_crisAciUri.TabIndex = 62
        Me.txt_crisAciUri.Text = "NEGATIVO"
        '
        'chk_crisAciUri
        '
        Me.chk_crisAciUri.Location = New System.Drawing.Point(284, 354)
        Me.chk_crisAciUri.Name = "chk_crisAciUri"
        Me.chk_crisAciUri.Size = New System.Drawing.Size(116, 16)
        Me.chk_crisAciUri.TabIndex = 61
        Me.chk_crisAciUri.Tag = "Cristales Acido Urico:"
        Me.chk_crisAciUri.Text = "Crist. Acid. Urico:"
        '
        'txt_uratoamo
        '
        Me.txt_uratoamo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_uratoamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uratoamo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uratoamo.Location = New System.Drawing.Point(404, 330)
        Me.txt_uratoamo.MaxLength = 150
        Me.txt_uratoamo.Name = "txt_uratoamo"
        Me.txt_uratoamo.ReadOnly = True
        Me.txt_uratoamo.Size = New System.Drawing.Size(142, 21)
        Me.txt_uratoamo.TabIndex = 60
        Me.txt_uratoamo.Text = "NEGATIVO"
        '
        'chk_uratoAmo
        '
        Me.chk_uratoAmo.Location = New System.Drawing.Point(284, 334)
        Me.chk_uratoAmo.Name = "chk_uratoAmo"
        Me.chk_uratoAmo.Size = New System.Drawing.Size(116, 16)
        Me.chk_uratoAmo.TabIndex = 59
        Me.chk_uratoAmo.Text = "Urato Amónico:"
        '
        'txt_fosfatoTri
        '
        Me.txt_fosfatoTri.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_fosfatoTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fosfatoTri.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fosfatoTri.Location = New System.Drawing.Point(404, 310)
        Me.txt_fosfatoTri.MaxLength = 150
        Me.txt_fosfatoTri.Name = "txt_fosfatoTri"
        Me.txt_fosfatoTri.ReadOnly = True
        Me.txt_fosfatoTri.Size = New System.Drawing.Size(142, 21)
        Me.txt_fosfatoTri.TabIndex = 58
        Me.txt_fosfatoTri.Text = "NEGATIVO"
        '
        'chk_fosfatoTri
        '
        Me.chk_fosfatoTri.Location = New System.Drawing.Point(284, 316)
        Me.chk_fosfatoTri.Name = "chk_fosfatoTri"
        Me.chk_fosfatoTri.Size = New System.Drawing.Size(118, 16)
        Me.chk_fosfatoTri.TabIndex = 57
        Me.chk_fosfatoTri.Tag = "Fosfato Triple:"
        Me.chk_fosfatoTri.Text = "Fosfat. Triple:"
        '
        'chk_oxalatoCal
        '
        Me.chk_oxalatoCal.Location = New System.Drawing.Point(284, 296)
        Me.chk_oxalatoCal.Name = "chk_oxalatoCal"
        Me.chk_oxalatoCal.Size = New System.Drawing.Size(118, 16)
        Me.chk_oxalatoCal.TabIndex = 55
        Me.chk_oxalatoCal.Text = "Oxalato Calcio:"
        '
        'txt_oxalatoCal
        '
        Me.txt_oxalatoCal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_oxalatoCal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_oxalatoCal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oxalatoCal.Location = New System.Drawing.Point(404, 290)
        Me.txt_oxalatoCal.MaxLength = 150
        Me.txt_oxalatoCal.Name = "txt_oxalatoCal"
        Me.txt_oxalatoCal.ReadOnly = True
        Me.txt_oxalatoCal.Size = New System.Drawing.Size(142, 21)
        Me.txt_oxalatoCal.TabIndex = 56
        Me.txt_oxalatoCal.Text = "NEGATIVO"
        '
        'chk_oxalatoAmo
        '
        Me.chk_oxalatoAmo.Location = New System.Drawing.Point(284, 256)
        Me.chk_oxalatoAmo.Name = "chk_oxalatoAmo"
        Me.chk_oxalatoAmo.Size = New System.Drawing.Size(118, 16)
        Me.chk_oxalatoAmo.TabIndex = 51
        Me.chk_oxalatoAmo.Text = "Oxalato Amonio:"
        '
        'txt_oxalatoamo
        '
        Me.txt_oxalatoamo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_oxalatoamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_oxalatoamo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oxalatoamo.Location = New System.Drawing.Point(404, 250)
        Me.txt_oxalatoamo.MaxLength = 150
        Me.txt_oxalatoamo.Name = "txt_oxalatoamo"
        Me.txt_oxalatoamo.ReadOnly = True
        Me.txt_oxalatoamo.Size = New System.Drawing.Size(142, 21)
        Me.txt_oxalatoamo.TabIndex = 52
        Me.txt_oxalatoamo.Text = "NEGATIVO"
        '
        'txt_fosfatosA
        '
        Me.txt_fosfatosA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_fosfatosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fosfatosA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fosfatosA.Location = New System.Drawing.Point(404, 230)
        Me.txt_fosfatosA.MaxLength = 150
        Me.txt_fosfatosA.Name = "txt_fosfatosA"
        Me.txt_fosfatosA.ReadOnly = True
        Me.txt_fosfatosA.Size = New System.Drawing.Size(142, 21)
        Me.txt_fosfatosA.TabIndex = 50
        Me.txt_fosfatosA.Text = "NEGATIVO"
        '
        'chk_fosfatosA
        '
        Me.chk_fosfatosA.Location = New System.Drawing.Point(284, 236)
        Me.chk_fosfatosA.Name = "chk_fosfatosA"
        Me.chk_fosfatosA.Size = New System.Drawing.Size(118, 16)
        Me.chk_fosfatosA.TabIndex = 49
        Me.chk_fosfatosA.Text = "Fosfat. Amorfos:"
        '
        'txt_uratosA
        '
        Me.txt_uratosA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_uratosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uratosA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uratosA.Location = New System.Drawing.Point(404, 210)
        Me.txt_uratosA.MaxLength = 150
        Me.txt_uratosA.Name = "txt_uratosA"
        Me.txt_uratosA.ReadOnly = True
        Me.txt_uratosA.Size = New System.Drawing.Size(142, 21)
        Me.txt_uratosA.TabIndex = 48
        Me.txt_uratosA.Text = "NEGATIVO"
        '
        'chk_uratosA
        '
        Me.chk_uratosA.Location = New System.Drawing.Point(284, 214)
        Me.chk_uratosA.Name = "chk_uratosA"
        Me.chk_uratosA.Size = New System.Drawing.Size(116, 16)
        Me.chk_uratosA.TabIndex = 47
        Me.chk_uratosA.Text = "Uratos Amorfos:"
        '
        'txt_espermatozoides
        '
        Me.txt_espermatozoides.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_espermatozoides.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_espermatozoides.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_espermatozoides.Location = New System.Drawing.Point(126, 370)
        Me.txt_espermatozoides.MaxLength = 150
        Me.txt_espermatozoides.Name = "txt_espermatozoides"
        Me.txt_espermatozoides.ReadOnly = True
        Me.txt_espermatozoides.Size = New System.Drawing.Size(142, 21)
        Me.txt_espermatozoides.TabIndex = 42
        Me.txt_espermatozoides.Text = "NEGATIVO"
        '
        'chk_espermatozoides
        '
        Me.chk_espermatozoides.Location = New System.Drawing.Point(8, 374)
        Me.chk_espermatozoides.Name = "chk_espermatozoides"
        Me.chk_espermatozoides.Size = New System.Drawing.Size(124, 14)
        Me.chk_espermatozoides.TabIndex = 41
        Me.chk_espermatozoides.Text = "Espermatozoides:"
        '
        'txt_ccereos
        '
        Me.txt_ccereos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_ccereos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ccereos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ccereos.Location = New System.Drawing.Point(126, 330)
        Me.txt_ccereos.MaxLength = 150
        Me.txt_ccereos.Name = "txt_ccereos"
        Me.txt_ccereos.ReadOnly = True
        Me.txt_ccereos.Size = New System.Drawing.Size(142, 21)
        Me.txt_ccereos.TabIndex = 38
        Me.txt_ccereos.Text = "NEGATIVO"
        '
        'chk_ccereos
        '
        Me.chk_ccereos.Location = New System.Drawing.Point(8, 332)
        Me.chk_ccereos.Name = "chk_ccereos"
        Me.chk_ccereos.Size = New System.Drawing.Size(116, 16)
        Me.chk_ccereos.TabIndex = 37
        Me.chk_ccereos.Text = "Cilin.Céreos:"
        '
        'txt_cleucocitarios
        '
        Me.txt_cleucocitarios.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_cleucocitarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cleucocitarios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cleucocitarios.Location = New System.Drawing.Point(126, 310)
        Me.txt_cleucocitarios.MaxLength = 150
        Me.txt_cleucocitarios.Name = "txt_cleucocitarios"
        Me.txt_cleucocitarios.ReadOnly = True
        Me.txt_cleucocitarios.Size = New System.Drawing.Size(142, 21)
        Me.txt_cleucocitarios.TabIndex = 36
        Me.txt_cleucocitarios.Text = "NEGATIVO"
        '
        'chk_cleucocitarios
        '
        Me.chk_cleucocitarios.Location = New System.Drawing.Point(8, 312)
        Me.chk_cleucocitarios.Name = "chk_cleucocitarios"
        Me.chk_cleucocitarios.Size = New System.Drawing.Size(116, 16)
        Me.chk_cleucocitarios.TabIndex = 35
        Me.chk_cleucocitarios.Text = "Cilin.Leucocita.:"
        '
        'txt_cgranulosos
        '
        Me.txt_cgranulosos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_cgranulosos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgranulosos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgranulosos.Location = New System.Drawing.Point(126, 290)
        Me.txt_cgranulosos.MaxLength = 150
        Me.txt_cgranulosos.Name = "txt_cgranulosos"
        Me.txt_cgranulosos.ReadOnly = True
        Me.txt_cgranulosos.Size = New System.Drawing.Size(142, 21)
        Me.txt_cgranulosos.TabIndex = 34
        Me.txt_cgranulosos.Text = "NEGATIVO"
        '
        'chk_cgranulosos
        '
        Me.chk_cgranulosos.Location = New System.Drawing.Point(8, 292)
        Me.chk_cgranulosos.Name = "chk_cgranulosos"
        Me.chk_cgranulosos.Size = New System.Drawing.Size(122, 16)
        Me.chk_cgranulosos.TabIndex = 33
        Me.chk_cgranulosos.Text = "Cilin.Granulosos:"
        '
        'txt_chemeticos
        '
        Me.txt_chemeticos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_chemeticos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chemeticos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chemeticos.Location = New System.Drawing.Point(126, 270)
        Me.txt_chemeticos.MaxLength = 150
        Me.txt_chemeticos.Name = "txt_chemeticos"
        Me.txt_chemeticos.ReadOnly = True
        Me.txt_chemeticos.Size = New System.Drawing.Size(142, 21)
        Me.txt_chemeticos.TabIndex = 32
        Me.txt_chemeticos.Text = "NEGATIVO"
        '
        'chk_chemeticos
        '
        Me.chk_chemeticos.Location = New System.Drawing.Point(8, 272)
        Me.chk_chemeticos.Name = "chk_chemeticos"
        Me.chk_chemeticos.Size = New System.Drawing.Size(116, 16)
        Me.chk_chemeticos.TabIndex = 31
        Me.chk_chemeticos.Text = "Cilin.Heméticos:"
        '
        'txt_chialinos
        '
        Me.txt_chialinos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_chialinos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_chialinos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chialinos.Location = New System.Drawing.Point(126, 250)
        Me.txt_chialinos.MaxLength = 150
        Me.txt_chialinos.Name = "txt_chialinos"
        Me.txt_chialinos.ReadOnly = True
        Me.txt_chialinos.Size = New System.Drawing.Size(142, 21)
        Me.txt_chialinos.TabIndex = 30
        Me.txt_chialinos.Text = "NEGATIVO"
        '
        'chk_cHialinos
        '
        Me.chk_cHialinos.Location = New System.Drawing.Point(8, 252)
        Me.chk_cHialinos.Name = "chk_cHialinos"
        Me.chk_cHialinos.Size = New System.Drawing.Size(104, 16)
        Me.chk_cHialinos.TabIndex = 29
        Me.chk_cHialinos.Text = "Cilin.Hialinos:"
        '
        'txt_leucocitosc
        '
        Me.txt_leucocitosc.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_leucocitosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_leucocitosc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_leucocitosc.Location = New System.Drawing.Point(126, 190)
        Me.txt_leucocitosc.MaxLength = 150
        Me.txt_leucocitosc.Name = "txt_leucocitosc"
        Me.txt_leucocitosc.ReadOnly = True
        Me.txt_leucocitosc.Size = New System.Drawing.Size(142, 21)
        Me.txt_leucocitosc.TabIndex = 24
        Me.txt_leucocitosc.Text = "NEGATIVO"
        '
        'chk_leucocitosc
        '
        Me.chk_leucocitosc.Location = New System.Drawing.Point(8, 192)
        Me.chk_leucocitosc.Name = "chk_leucocitosc"
        Me.chk_leucocitosc.Size = New System.Drawing.Size(100, 16)
        Me.chk_leucocitosc.TabIndex = 23
        Me.chk_leucocitosc.Text = "Leucocitos:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(230, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 14)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "MICROSCOPICO"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(510, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 14)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "eri/uL"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(238, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 14)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "mg/dL"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(238, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 14)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "mg/dL"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(238, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 12)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "leu/uL"
        '
        'txt_levadurasU
        '
        Me.txt_levadurasU.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_levadurasU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_levadurasU.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_levadurasU.Location = New System.Drawing.Point(404, 390)
        Me.txt_levadurasU.MaxLength = 150
        Me.txt_levadurasU.Name = "txt_levadurasU"
        Me.txt_levadurasU.ReadOnly = True
        Me.txt_levadurasU.Size = New System.Drawing.Size(142, 21)
        Me.txt_levadurasU.TabIndex = 66
        Me.txt_levadurasU.Text = "NEGATIVO"
        '
        'chk_levadurasU
        '
        Me.chk_levadurasU.Location = New System.Drawing.Point(284, 392)
        Me.chk_levadurasU.Name = "chk_levadurasU"
        Me.chk_levadurasU.Size = New System.Drawing.Size(94, 16)
        Me.chk_levadurasU.TabIndex = 65
        Me.chk_levadurasU.Text = "Levaduras:"
        '
        'txt_hematies
        '
        Me.txt_hematies.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_hematies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hematies.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hematies.Location = New System.Drawing.Point(126, 170)
        Me.txt_hematies.MaxLength = 150
        Me.txt_hematies.Name = "txt_hematies"
        Me.txt_hematies.ReadOnly = True
        Me.txt_hematies.Size = New System.Drawing.Size(142, 21)
        Me.txt_hematies.TabIndex = 22
        Me.txt_hematies.Text = "NEGATIVO"
        '
        'chk_hematies
        '
        Me.chk_hematies.Location = New System.Drawing.Point(8, 172)
        Me.chk_hematies.Name = "chk_hematies"
        Me.chk_hematies.Size = New System.Drawing.Size(96, 16)
        Me.chk_hematies.TabIndex = 21
        Me.chk_hematies.Text = "Hematíes:"
        '
        'chk_hemoglobina
        '
        Me.chk_hemoglobina.Location = New System.Drawing.Point(284, 72)
        Me.chk_hemoglobina.Name = "chk_hemoglobina"
        Me.chk_hemoglobina.Size = New System.Drawing.Size(104, 14)
        Me.chk_hemoglobina.TabIndex = 13
        Me.chk_hemoglobina.Text = "Hemoglobina:"
        '
        'txt_hemoglobina
        '
        Me.txt_hemoglobina.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_hemoglobina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hemoglobina.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hemoglobina.Location = New System.Drawing.Point(404, 68)
        Me.txt_hemoglobina.MaxLength = 150
        Me.txt_hemoglobina.Name = "txt_hemoglobina"
        Me.txt_hemoglobina.ReadOnly = True
        Me.txt_hemoglobina.Size = New System.Drawing.Size(104, 21)
        Me.txt_hemoglobina.TabIndex = 14
        Me.txt_hemoglobina.Text = "NEGATIVO"
        '
        'chk_leucocitos
        '
        Me.chk_leucocitos.Location = New System.Drawing.Point(8, 72)
        Me.chk_leucocitos.Name = "chk_leucocitos"
        Me.chk_leucocitos.Size = New System.Drawing.Size(88, 14)
        Me.chk_leucocitos.TabIndex = 5
        Me.chk_leucocitos.Text = "Leucocitos:"
        '
        'txt_leucocitos
        '
        Me.txt_leucocitos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_leucocitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_leucocitos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_leucocitos.Location = New System.Drawing.Point(126, 66)
        Me.txt_leucocitos.MaxLength = 150
        Me.txt_leucocitos.Name = "txt_leucocitos"
        Me.txt_leucocitos.ReadOnly = True
        Me.txt_leucocitos.Size = New System.Drawing.Size(106, 21)
        Me.txt_leucocitos.TabIndex = 6
        Me.txt_leucocitos.Text = "NEGATIVO"
        '
        'chk_nitritos
        '
        Me.chk_nitritos.Location = New System.Drawing.Point(284, 128)
        Me.chk_nitritos.Name = "chk_nitritos"
        Me.chk_nitritos.Size = New System.Drawing.Size(96, 14)
        Me.chk_nitritos.TabIndex = 19
        Me.chk_nitritos.Text = "Nitritos:"
        '
        'txt_nitritos
        '
        Me.txt_nitritos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_nitritos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nitritos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nitritos.Location = New System.Drawing.Point(404, 126)
        Me.txt_nitritos.MaxLength = 150
        Me.txt_nitritos.Name = "txt_nitritos"
        Me.txt_nitritos.ReadOnly = True
        Me.txt_nitritos.Size = New System.Drawing.Size(104, 21)
        Me.txt_nitritos.TabIndex = 20
        Me.txt_nitritos.Text = "NEGATIVO"
        '
        'txt_aspecto
        '
        Me.txt_aspecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_aspecto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aspecto.Location = New System.Drawing.Point(404, 28)
        Me.txt_aspecto.MaxLength = 150
        Me.txt_aspecto.Name = "txt_aspecto"
        Me.txt_aspecto.Size = New System.Drawing.Size(146, 21)
        Me.txt_aspecto.TabIndex = 2
        Me.txt_aspecto.Text = ""
        '
        'txt_color
        '
        Me.txt_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_color.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(126, 26)
        Me.txt_color.MaxLength = 50
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(138, 21)
        Me.txt_color.TabIndex = 1
        Me.txt_color.Text = ""
        '
        'lbl_PH
        '
        Me.lbl_PH.Location = New System.Drawing.Point(300, 50)
        Me.lbl_PH.Name = "lbl_PH"
        Me.lbl_PH.Size = New System.Drawing.Size(24, 18)
        Me.lbl_PH.TabIndex = 110
        Me.lbl_PH.Text = "PH:"
        '
        'lbl_densidad
        '
        Me.lbl_densidad.Location = New System.Drawing.Point(24, 50)
        Me.lbl_densidad.Name = "lbl_densidad"
        Me.lbl_densidad.Size = New System.Drawing.Size(68, 14)
        Me.lbl_densidad.TabIndex = 108
        Me.lbl_densidad.Text = "Densidad:"
        '
        'lbl_aspecto
        '
        Me.lbl_aspecto.Location = New System.Drawing.Point(300, 28)
        Me.lbl_aspecto.Name = "lbl_aspecto"
        Me.lbl_aspecto.Size = New System.Drawing.Size(54, 18)
        Me.lbl_aspecto.TabIndex = 106
        Me.lbl_aspecto.Text = "Aspecto:"
        '
        'lbl_color
        '
        Me.lbl_color.Location = New System.Drawing.Point(26, 30)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(68, 14)
        Me.lbl_color.TabIndex = 104
        Me.lbl_color.Text = "Color:"
        '
        'lbl_Macro
        '
        Me.lbl_Macro.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Macro.ForeColor = System.Drawing.Color.Green
        Me.lbl_Macro.Location = New System.Drawing.Point(243, 10)
        Me.lbl_Macro.Name = "lbl_Macro"
        Me.lbl_Macro.Size = New System.Drawing.Size(72, 14)
        Me.lbl_Macro.TabIndex = 111
        Me.lbl_Macro.Text = "ELEMENTAL"
        '
        'chk_proteinas
        '
        Me.chk_proteinas.Location = New System.Drawing.Point(8, 92)
        Me.chk_proteinas.Name = "chk_proteinas"
        Me.chk_proteinas.Size = New System.Drawing.Size(88, 14)
        Me.chk_proteinas.TabIndex = 7
        Me.chk_proteinas.Text = "Proteínas:"
        '
        'txt_proteinas
        '
        Me.txt_proteinas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_proteinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_proteinas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_proteinas.Location = New System.Drawing.Point(126, 86)
        Me.txt_proteinas.MaxLength = 150
        Me.txt_proteinas.Name = "txt_proteinas"
        Me.txt_proteinas.ReadOnly = True
        Me.txt_proteinas.Size = New System.Drawing.Size(106, 21)
        Me.txt_proteinas.TabIndex = 8
        Me.txt_proteinas.Text = "NEGATIVO"
        '
        'chk_glucosas
        '
        Me.chk_glucosas.Location = New System.Drawing.Point(8, 112)
        Me.chk_glucosas.Name = "chk_glucosas"
        Me.chk_glucosas.Size = New System.Drawing.Size(88, 14)
        Me.chk_glucosas.TabIndex = 9
        Me.chk_glucosas.Text = "Glucosa:"
        '
        'txt_glucosa
        '
        Me.txt_glucosa.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_glucosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_glucosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_glucosa.Location = New System.Drawing.Point(126, 106)
        Me.txt_glucosa.MaxLength = 150
        Me.txt_glucosa.Name = "txt_glucosa"
        Me.txt_glucosa.ReadOnly = True
        Me.txt_glucosa.Size = New System.Drawing.Size(106, 21)
        Me.txt_glucosa.TabIndex = 10
        Me.txt_glucosa.Text = "NEGATIVO"
        '
        'chk_cetonas
        '
        Me.chk_cetonas.Location = New System.Drawing.Point(8, 130)
        Me.chk_cetonas.Name = "chk_cetonas"
        Me.chk_cetonas.Size = New System.Drawing.Size(90, 14)
        Me.chk_cetonas.TabIndex = 11
        Me.chk_cetonas.Text = "Cetonas:"
        '
        'txt_cetonas
        '
        Me.txt_cetonas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_cetonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cetonas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cetonas.Location = New System.Drawing.Point(126, 126)
        Me.txt_cetonas.MaxLength = 150
        Me.txt_cetonas.Name = "txt_cetonas"
        Me.txt_cetonas.ReadOnly = True
        Me.txt_cetonas.Size = New System.Drawing.Size(106, 21)
        Me.txt_cetonas.TabIndex = 12
        Me.txt_cetonas.Text = "NEGATIVO"
        '
        'txt_urobilinog
        '
        Me.txt_urobilinog.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_urobilinog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_urobilinog.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_urobilinog.Location = New System.Drawing.Point(404, 106)
        Me.txt_urobilinog.MaxLength = 150
        Me.txt_urobilinog.Name = "txt_urobilinog"
        Me.txt_urobilinog.ReadOnly = True
        Me.txt_urobilinog.Size = New System.Drawing.Size(104, 21)
        Me.txt_urobilinog.TabIndex = 18
        Me.txt_urobilinog.Text = "NEGATIVO"
        '
        'chk_urobilinog
        '
        Me.chk_urobilinog.Location = New System.Drawing.Point(284, 110)
        Me.chk_urobilinog.Name = "chk_urobilinog"
        Me.chk_urobilinog.Size = New System.Drawing.Size(108, 14)
        Me.chk_urobilinog.TabIndex = 17
        Me.chk_urobilinog.Text = "Urobilinógeno:"
        '
        'chk_bilirrubinas
        '
        Me.chk_bilirrubinas.Location = New System.Drawing.Point(284, 90)
        Me.chk_bilirrubinas.Name = "chk_bilirrubinas"
        Me.chk_bilirrubinas.Size = New System.Drawing.Size(102, 14)
        Me.chk_bilirrubinas.TabIndex = 15
        Me.chk_bilirrubinas.Text = "Bilirrubina:"
        '
        'txt_bilirrubinas
        '
        Me.txt_bilirrubinas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_bilirrubinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bilirrubinas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bilirrubinas.Location = New System.Drawing.Point(404, 88)
        Me.txt_bilirrubinas.MaxLength = 150
        Me.txt_bilirrubinas.Name = "txt_bilirrubinas"
        Me.txt_bilirrubinas.ReadOnly = True
        Me.txt_bilirrubinas.Size = New System.Drawing.Size(104, 21)
        Me.txt_bilirrubinas.TabIndex = 16
        Me.txt_bilirrubinas.Text = "NEGATIVO"
        '
        'txt_moco
        '
        Me.txt_moco.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_moco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_moco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_moco.Location = New System.Drawing.Point(126, 350)
        Me.txt_moco.MaxLength = 150
        Me.txt_moco.Name = "txt_moco"
        Me.txt_moco.ReadOnly = True
        Me.txt_moco.Size = New System.Drawing.Size(142, 21)
        Me.txt_moco.TabIndex = 40
        Me.txt_moco.Text = "NEGATIVO"
        '
        'chk_moco
        '
        Me.chk_moco.Location = New System.Drawing.Point(8, 354)
        Me.chk_moco.Name = "chk_moco"
        Me.chk_moco.Size = New System.Drawing.Size(84, 14)
        Me.chk_moco.TabIndex = 39
        Me.chk_moco.Text = "Moco:"
        '
        'chk_bacterias
        '
        Me.chk_bacterias.Location = New System.Drawing.Point(284, 174)
        Me.chk_bacterias.Name = "chk_bacterias"
        Me.chk_bacterias.Size = New System.Drawing.Size(84, 16)
        Me.chk_bacterias.TabIndex = 43
        Me.chk_bacterias.Text = "Bacterias:"
        '
        'txt_bacterias
        '
        Me.txt_bacterias.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_bacterias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bacterias.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bacterias.Location = New System.Drawing.Point(404, 170)
        Me.txt_bacterias.MaxLength = 150
        Me.txt_bacterias.Name = "txt_bacterias"
        Me.txt_bacterias.ReadOnly = True
        Me.txt_bacterias.Size = New System.Drawing.Size(142, 21)
        Me.txt_bacterias.TabIndex = 44
        Me.txt_bacterias.Text = "NEGATIVO"
        '
        'txt_piocitos
        '
        Me.txt_piocitos.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_piocitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_piocitos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_piocitos.Location = New System.Drawing.Point(404, 190)
        Me.txt_piocitos.MaxLength = 150
        Me.txt_piocitos.Name = "txt_piocitos"
        Me.txt_piocitos.ReadOnly = True
        Me.txt_piocitos.Size = New System.Drawing.Size(142, 21)
        Me.txt_piocitos.TabIndex = 46
        Me.txt_piocitos.Text = "NEGATIVO"
        '
        'chk_piocitos
        '
        Me.chk_piocitos.Location = New System.Drawing.Point(284, 194)
        Me.chk_piocitos.Name = "chk_piocitos"
        Me.chk_piocitos.Size = New System.Drawing.Size(84, 16)
        Me.chk_piocitos.TabIndex = 45
        Me.chk_piocitos.Text = "Piocitos:"
        '
        'txt_celulas
        '
        Me.txt_celulas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_celulas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_celulas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celulas.Location = New System.Drawing.Point(126, 210)
        Me.txt_celulas.MaxLength = 150
        Me.txt_celulas.Name = "txt_celulas"
        Me.txt_celulas.ReadOnly = True
        Me.txt_celulas.Size = New System.Drawing.Size(142, 21)
        Me.txt_celulas.TabIndex = 26
        Me.txt_celulas.Text = "NEGATIVO"
        '
        'chk_celulas
        '
        Me.chk_celulas.Location = New System.Drawing.Point(8, 212)
        Me.chk_celulas.Name = "chk_celulas"
        Me.chk_celulas.Size = New System.Drawing.Size(96, 18)
        Me.chk_celulas.TabIndex = 25
        Me.chk_celulas.Text = "Células:"
        '
        'chk_cristalesAmo
        '
        Me.chk_cristalesAmo.Location = New System.Drawing.Point(284, 276)
        Me.chk_cristalesAmo.Name = "chk_cristalesAmo"
        Me.chk_cristalesAmo.Size = New System.Drawing.Size(118, 16)
        Me.chk_cristalesAmo.TabIndex = 53
        Me.chk_cristalesAmo.Text = "Cristal. Amonio:"
        '
        'txt_cristalesAmo
        '
        Me.txt_cristalesAmo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_cristalesAmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cristalesAmo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cristalesAmo.Location = New System.Drawing.Point(404, 270)
        Me.txt_cristalesAmo.MaxLength = 150
        Me.txt_cristalesAmo.Name = "txt_cristalesAmo"
        Me.txt_cristalesAmo.ReadOnly = True
        Me.txt_cristalesAmo.Size = New System.Drawing.Size(142, 21)
        Me.txt_cristalesAmo.TabIndex = 54
        Me.txt_cristalesAmo.Text = "NEGATIVO"
        '
        'txt_cilindros
        '
        Me.txt_cilindros.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_cilindros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cilindros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cilindros.Location = New System.Drawing.Point(126, 230)
        Me.txt_cilindros.MaxLength = 150
        Me.txt_cilindros.Name = "txt_cilindros"
        Me.txt_cilindros.ReadOnly = True
        Me.txt_cilindros.Size = New System.Drawing.Size(142, 21)
        Me.txt_cilindros.TabIndex = 28
        Me.txt_cilindros.Text = "NEGATIVO"
        '
        'chk_cilindros
        '
        Me.chk_cilindros.Location = New System.Drawing.Point(8, 234)
        Me.chk_cilindros.Name = "chk_cilindros"
        Me.chk_cilindros.Size = New System.Drawing.Size(96, 16)
        Me.chk_cilindros.TabIndex = 27
        Me.chk_cilindros.Text = "Cilindros"
        '
        'txt_obs2
        '
        Me.txt_obs2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs2.Enabled = False
        Me.txt_obs2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs2.Location = New System.Drawing.Point(126, 412)
        Me.txt_obs2.MaxLength = 500
        Me.txt_obs2.Multiline = True
        Me.txt_obs2.Name = "txt_obs2"
        Me.txt_obs2.Size = New System.Drawing.Size(420, 32)
        Me.txt_obs2.TabIndex = 68
        Me.txt_obs2.Text = ""
        '
        'chk_Obs2
        '
        Me.chk_Obs2.Location = New System.Drawing.Point(8, 416)
        Me.chk_Obs2.Name = "chk_Obs2"
        Me.chk_Obs2.Size = New System.Drawing.Size(110, 16)
        Me.chk_Obs2.TabIndex = 67
        Me.chk_Obs2.Text = "Observaciones:"
        '
        'grp_datos
        '
        Me.grp_datos.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbl_fecnacd, Me.lbl_fecnac, Me.btn_ObsPac, Me.lbl_edad, Me.lbl_edadl, Me.lbl_pacD, Me.lbl_pedidoD, Me.lbl_PedFec, Me.lbl_test_nombre, Me.lbl_fecha, Me.lbl_pac, Me.lbl_pedido, Me.btn_busqueda, Me.lbl_test})
        Me.grp_datos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_datos.ForeColor = System.Drawing.Color.Navy
        Me.grp_datos.Location = New System.Drawing.Point(16, 30)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(560, 90)
        Me.grp_datos.TabIndex = 0
        Me.grp_datos.TabStop = False
        Me.grp_datos.Text = "Datos:"
        '
        'lbl_fecnacd
        '
        Me.lbl_fecnacd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecnacd.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecnacd.Location = New System.Drawing.Point(96, 70)
        Me.lbl_fecnacd.Name = "lbl_fecnacd"
        Me.lbl_fecnacd.Size = New System.Drawing.Size(136, 15)
        Me.lbl_fecnacd.TabIndex = 17
        '
        'lbl_fecnac
        '
        Me.lbl_fecnac.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecnac.Location = New System.Drawing.Point(16, 70)
        Me.lbl_fecnac.Name = "lbl_fecnac"
        Me.lbl_fecnac.Size = New System.Drawing.Size(74, 15)
        Me.lbl_fecnac.TabIndex = 16
        Me.lbl_fecnac.Text = "Fec. Nacim.:"
        '
        'btn_ObsPac
        '
        Me.btn_ObsPac.BackgroundImage = CType(resources.GetObject("btn_ObsPac.BackgroundImage"), System.Drawing.Bitmap)
        Me.btn_ObsPac.Enabled = False
        Me.btn_ObsPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ObsPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ObsPac.ForeColor = System.Drawing.Color.Black
        Me.btn_ObsPac.Image = CType(resources.GetObject("btn_ObsPac.Image"), System.Drawing.Bitmap)
        Me.btn_ObsPac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ObsPac.Location = New System.Drawing.Point(468, 52)
        Me.btn_ObsPac.Name = "btn_ObsPac"
        Me.btn_ObsPac.Size = New System.Drawing.Size(80, 24)
        Me.btn_ObsPac.TabIndex = 1
        Me.btn_ObsPac.Text = "Observac."
        Me.btn_ObsPac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_edad
        '
        Me.lbl_edad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.ForeColor = System.Drawing.Color.Black
        Me.lbl_edad.Location = New System.Drawing.Point(320, 72)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(136, 15)
        Me.lbl_edad.TabIndex = 13
        '
        'lbl_edadl
        '
        Me.lbl_edadl.ForeColor = System.Drawing.Color.Black
        Me.lbl_edadl.Location = New System.Drawing.Point(276, 70)
        Me.lbl_edadl.Name = "lbl_edadl"
        Me.lbl_edadl.Size = New System.Drawing.Size(36, 15)
        Me.lbl_edadl.TabIndex = 12
        Me.lbl_edadl.Text = "Edad:"
        '
        'lbl_pacD
        '
        Me.lbl_pacD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pacD.ForeColor = System.Drawing.Color.Black
        Me.lbl_pacD.Location = New System.Drawing.Point(96, 52)
        Me.lbl_pacD.Name = "lbl_pacD"
        Me.lbl_pacD.Size = New System.Drawing.Size(360, 15)
        Me.lbl_pacD.TabIndex = 9
        '
        'lbl_pedidoD
        '
        Me.lbl_pedidoD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedidoD.ForeColor = System.Drawing.Color.Black
        Me.lbl_pedidoD.Location = New System.Drawing.Point(96, 18)
        Me.lbl_pedidoD.Name = "lbl_pedidoD"
        Me.lbl_pedidoD.Size = New System.Drawing.Size(120, 13)
        Me.lbl_pedidoD.TabIndex = 8
        '
        'lbl_PedFec
        '
        Me.lbl_PedFec.ForeColor = System.Drawing.Color.Black
        Me.lbl_PedFec.Location = New System.Drawing.Point(16, 34)
        Me.lbl_PedFec.Name = "lbl_PedFec"
        Me.lbl_PedFec.Size = New System.Drawing.Size(72, 15)
        Me.lbl_PedFec.TabIndex = 7
        Me.lbl_PedFec.Text = "Fecha Ped.:"
        '
        'lbl_test_nombre
        '
        Me.lbl_test_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_test_nombre.Location = New System.Drawing.Point(230, 18)
        Me.lbl_test_nombre.Name = "lbl_test_nombre"
        Me.lbl_test_nombre.Size = New System.Drawing.Size(224, 15)
        Me.lbl_test_nombre.TabIndex = 6
        '
        'lbl_fecha
        '
        Me.lbl_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecha.Location = New System.Drawing.Point(96, 34)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(120, 16)
        Me.lbl_fecha.TabIndex = 4
        '
        'lbl_pac
        '
        Me.lbl_pac.ForeColor = System.Drawing.Color.Black
        Me.lbl_pac.Location = New System.Drawing.Point(16, 52)
        Me.lbl_pac.Name = "lbl_pac"
        Me.lbl_pac.Size = New System.Drawing.Size(58, 15)
        Me.lbl_pac.TabIndex = 2
        Me.lbl_pac.Text = "Paciente:"
        '
        'lbl_pedido
        '
        Me.lbl_pedido.ForeColor = System.Drawing.Color.Black
        Me.lbl_pedido.Location = New System.Drawing.Point(16, 18)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_pedido.TabIndex = 0
        Me.lbl_pedido.Text = "Pedido:"
        '
        'lbl_test
        '
        Me.lbl_test.Location = New System.Drawing.Point(480, 22)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(60, 15)
        Me.lbl_test.TabIndex = 5
        Me.lbl_test.Text = "Test id"
        Me.lbl_test.Visible = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackgroundImage = CType(resources.GetObject("btn_Salir.BackgroundImage"), System.Drawing.Bitmap)
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Bitmap)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(299, 580)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 57
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.BackgroundImage = CType(resources.GetObject("btn_Aceptar.BackgroundImage"), System.Drawing.Bitmap)
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Bitmap)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(213, 580)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Aceptar.TabIndex = 56
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grp_general
        '
        Me.grp_general.BackColor = System.Drawing.Color.Transparent
        Me.grp_general.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbl_rangod, Me.lbl_rango, Me.Label13, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.cmb_unidades, Me.cmb_cualitativo, Me.Ctl_txt_numerico, Me.lbl_resultado, Me.chk_unidades, Me.txt_formula, Me.txt_ObsG})
        Me.grp_general.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_general.ForeColor = System.Drawing.Color.Navy
        Me.grp_general.Location = New System.Drawing.Point(34, 148)
        Me.grp_general.Name = "grp_general"
        Me.grp_general.Size = New System.Drawing.Size(524, 302)
        Me.grp_general.TabIndex = 58
        Me.grp_general.TabStop = False
        Me.grp_general.Text = "INGRESO DE RESULTADOS MANUALES:"
        Me.grp_general.Visible = False
        '
        'lbl_rangod
        '
        Me.lbl_rangod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rangod.ForeColor = System.Drawing.Color.Black
        Me.lbl_rangod.Location = New System.Drawing.Point(112, 192)
        Me.lbl_rangod.Name = "lbl_rangod"
        Me.lbl_rangod.Size = New System.Drawing.Size(390, 100)
        Me.lbl_rangod.TabIndex = 64
        '
        'lbl_rango
        '
        Me.lbl_rango.Location = New System.Drawing.Point(32, 192)
        Me.lbl_rango.Name = "lbl_rango"
        Me.lbl_rango.Size = New System.Drawing.Size(68, 28)
        Me.lbl_rango.TabIndex = 63
        Me.lbl_rango.Text = "Rango Normal:"
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(278, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Texto:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Fórmula:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Cualitativo:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Numérico:"
        '
        'cmb_unidades
        '
        Me.cmb_unidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidades.Enabled = False
        Me.cmb_unidades.Location = New System.Drawing.Point(344, 64)
        Me.cmb_unidades.Name = "cmb_unidades"
        Me.cmb_unidades.Size = New System.Drawing.Size(158, 21)
        Me.cmb_unidades.TabIndex = 57
        Me.cmb_unidades.Visible = False
        '
        'cmb_cualitativo
        '
        Me.cmb_cualitativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cualitativo.Enabled = False
        Me.cmb_cualitativo.Items.AddRange(New Object() {"POSITIVO", "NEGATIVO"})
        Me.cmb_cualitativo.Location = New System.Drawing.Point(112, 64)
        Me.cmb_cualitativo.Name = "cmb_cualitativo"
        Me.cmb_cualitativo.Size = New System.Drawing.Size(162, 21)
        Me.cmb_cualitativo.TabIndex = 56
        '
        'Ctl_txt_numerico
        '
        Me.Ctl_txt_numerico.Enabled = False
        Me.Ctl_txt_numerico.Location = New System.Drawing.Point(112, 46)
        Me.Ctl_txt_numerico.Name = "Ctl_txt_numerico"
        Me.Ctl_txt_numerico.Prp_Formato = True
        Me.Ctl_txt_numerico.Prp_NumDecimales = 2
        Me.Ctl_txt_numerico.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_numerico.Prp_ValDefault = "0"
        Me.Ctl_txt_numerico.Size = New System.Drawing.Size(160, 16)
        Me.Ctl_txt_numerico.TabIndex = 55
        '
        'lbl_resultado
        '
        Me.lbl_resultado.BackColor = System.Drawing.Color.Transparent
        Me.lbl_resultado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultado.ForeColor = System.Drawing.Color.Green
        Me.lbl_resultado.Location = New System.Drawing.Point(14, 26)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(166, 12)
        Me.lbl_resultado.TabIndex = 54
        Me.lbl_resultado.Text = "RESULTADO DEL TEST:"
        '
        'chk_unidades
        '
        Me.chk_unidades.Enabled = False
        Me.chk_unidades.Location = New System.Drawing.Point(352, 70)
        Me.chk_unidades.Name = "chk_unidades"
        Me.chk_unidades.Size = New System.Drawing.Size(64, 14)
        Me.chk_unidades.TabIndex = 56
        Me.chk_unidades.Text = "Unidad"
        Me.chk_unidades.Visible = False
        '
        'txt_formula
        '
        Me.txt_formula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_formula.Enabled = False
        Me.txt_formula.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_formula.Location = New System.Drawing.Point(112, 88)
        Me.txt_formula.MaxLength = 150
        Me.txt_formula.Name = "txt_formula"
        Me.txt_formula.Size = New System.Drawing.Size(390, 21)
        Me.txt_formula.TabIndex = 23
        Me.txt_formula.Text = ""
        '
        'txt_ObsG
        '
        Me.txt_ObsG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ObsG.Enabled = False
        Me.txt_ObsG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ObsG.Location = New System.Drawing.Point(112, 110)
        Me.txt_ObsG.MaxLength = 500
        Me.txt_ObsG.Multiline = True
        Me.txt_ObsG.Name = "txt_ObsG"
        Me.txt_ObsG.Size = New System.Drawing.Size(390, 74)
        Me.txt_ObsG.TabIndex = 20
        Me.txt_ObsG.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(114, 358)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(76, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'cmb_moco
        '
        Me.cmb_moco.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_moco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moco.Enabled = False
        Me.cmb_moco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_moco.ItemHeight = 13
        Me.cmb_moco.Items.AddRange(New Object() {"escaso", "(+)", "(++)", "(+++)"})
        Me.cmb_moco.Location = New System.Drawing.Point(324, 338)
        Me.cmb_moco.Name = "cmb_moco"
        Me.cmb_moco.Size = New System.Drawing.Size(70, 21)
        Me.cmb_moco.TabIndex = 42
        '
        'cmb_HimDimL
        '
        Me.cmb_HimDimL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_HimDimL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HimDimL.Enabled = False
        Me.cmb_HimDimL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HimDimL.ItemHeight = 13
        Me.cmb_HimDimL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_HimDimL.Location = New System.Drawing.Point(480, 232)
        Me.cmb_HimDimL.Name = "cmb_HimDimL"
        Me.cmb_HimDimL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_HimDimL.TabIndex = 38
        '
        'cmb_HimDimH
        '
        Me.cmb_HimDimH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_HimDimH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HimDimH.Enabled = False
        Me.cmb_HimDimH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HimDimH.ItemHeight = 13
        Me.cmb_HimDimH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_HimDimH.Location = New System.Drawing.Point(408, 232)
        Me.cmb_HimDimH.Name = "cmb_HimDimH"
        Me.cmb_HimDimH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_HimDimH.TabIndex = 37
        '
        'cmb_HimNanL
        '
        Me.cmb_HimNanL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_HimNanL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HimNanL.Enabled = False
        Me.cmb_HimNanL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HimNanL.ItemHeight = 13
        Me.cmb_HimNanL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_HimNanL.Location = New System.Drawing.Point(480, 210)
        Me.cmb_HimNanL.Name = "cmb_HimNanL"
        Me.cmb_HimNanL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_HimNanL.TabIndex = 36
        '
        'cmb_HimNanH
        '
        Me.cmb_HimNanH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_HimNanH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HimNanH.Enabled = False
        Me.cmb_HimNanH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HimNanH.ItemHeight = 13
        Me.cmb_HimNanH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_HimNanH.Location = New System.Drawing.Point(408, 210)
        Me.cmb_HimNanH.Name = "cmb_HimNanH"
        Me.cmb_HimNanH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_HimNanH.TabIndex = 35
        '
        'cmb_tenSolL
        '
        Me.cmb_tenSolL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_tenSolL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tenSolL.Enabled = False
        Me.cmb_tenSolL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tenSolL.ItemHeight = 13
        Me.cmb_tenSolL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_tenSolL.Location = New System.Drawing.Point(480, 188)
        Me.cmb_tenSolL.Name = "cmb_tenSolL"
        Me.cmb_tenSolL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_tenSolL.TabIndex = 34
        '
        'cmb_tenSolH
        '
        Me.cmb_tenSolH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_tenSolH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tenSolH.Enabled = False
        Me.cmb_tenSolH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tenSolH.ItemHeight = 13
        Me.cmb_tenSolH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_tenSolH.Location = New System.Drawing.Point(408, 188)
        Me.cmb_tenSolH.Name = "cmb_tenSolH"
        Me.cmb_tenSolH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_tenSolH.TabIndex = 33
        '
        'cmb_estrongiloidesL
        '
        Me.cmb_estrongiloidesL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_estrongiloidesL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estrongiloidesL.Enabled = False
        Me.cmb_estrongiloidesL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_estrongiloidesL.ItemHeight = 13
        Me.cmb_estrongiloidesL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_estrongiloidesL.Location = New System.Drawing.Point(480, 166)
        Me.cmb_estrongiloidesL.Name = "cmb_estrongiloidesL"
        Me.cmb_estrongiloidesL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_estrongiloidesL.TabIndex = 32
        '
        'cmb_estrongiloidesH
        '
        Me.cmb_estrongiloidesH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_estrongiloidesH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estrongiloidesH.Enabled = False
        Me.cmb_estrongiloidesH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_estrongiloidesH.ItemHeight = 13
        Me.cmb_estrongiloidesH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_estrongiloidesH.Location = New System.Drawing.Point(408, 166)
        Me.cmb_estrongiloidesH.Name = "cmb_estrongiloidesH"
        Me.cmb_estrongiloidesH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_estrongiloidesH.TabIndex = 31
        '
        'cmb_oxiurosL
        '
        Me.cmb_oxiurosL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_oxiurosL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_oxiurosL.Enabled = False
        Me.cmb_oxiurosL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_oxiurosL.ItemHeight = 13
        Me.cmb_oxiurosL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_oxiurosL.Location = New System.Drawing.Point(480, 144)
        Me.cmb_oxiurosL.Name = "cmb_oxiurosL"
        Me.cmb_oxiurosL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_oxiurosL.TabIndex = 30
        '
        'cmb_OxiurosH
        '
        Me.cmb_OxiurosH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_OxiurosH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_OxiurosH.Enabled = False
        Me.cmb_OxiurosH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_OxiurosH.ItemHeight = 13
        Me.cmb_OxiurosH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_OxiurosH.Location = New System.Drawing.Point(408, 144)
        Me.cmb_OxiurosH.Name = "cmb_OxiurosH"
        Me.cmb_OxiurosH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_OxiurosH.TabIndex = 29
        '
        'cmb_uncinariasL
        '
        Me.cmb_uncinariasL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_uncinariasL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_uncinariasL.Enabled = False
        Me.cmb_uncinariasL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_uncinariasL.ItemHeight = 13
        Me.cmb_uncinariasL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_uncinariasL.Location = New System.Drawing.Point(480, 122)
        Me.cmb_uncinariasL.Name = "cmb_uncinariasL"
        Me.cmb_uncinariasL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_uncinariasL.TabIndex = 28
        '
        'cmb_uncinariasH
        '
        Me.cmb_uncinariasH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_uncinariasH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_uncinariasH.Enabled = False
        Me.cmb_uncinariasH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_uncinariasH.ItemHeight = 13
        Me.cmb_uncinariasH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_uncinariasH.Location = New System.Drawing.Point(408, 122)
        Me.cmb_uncinariasH.Name = "cmb_uncinariasH"
        Me.cmb_uncinariasH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_uncinariasH.TabIndex = 27
        '
        'cmb_ascLumL
        '
        Me.cmb_ascLumL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_ascLumL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ascLumL.Enabled = False
        Me.cmb_ascLumL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ascLumL.ItemHeight = 13
        Me.cmb_ascLumL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_ascLumL.Location = New System.Drawing.Point(480, 100)
        Me.cmb_ascLumL.Name = "cmb_ascLumL"
        Me.cmb_ascLumL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_ascLumL.TabIndex = 26
        '
        'cmb_ascLumH
        '
        Me.cmb_ascLumH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_ascLumH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ascLumH.Enabled = False
        Me.cmb_ascLumH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ascLumH.ItemHeight = 13
        Me.cmb_ascLumH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_ascLumH.Location = New System.Drawing.Point(408, 100)
        Me.cmb_ascLumH.Name = "cmb_ascLumH"
        Me.cmb_ascLumH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_ascLumH.TabIndex = 25
        '
        'cmb_tricocefaloL
        '
        Me.cmb_tricocefaloL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_tricocefaloL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tricocefaloL.Enabled = False
        Me.cmb_tricocefaloL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tricocefaloL.ItemHeight = 13
        Me.cmb_tricocefaloL.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_tricocefaloL.Location = New System.Drawing.Point(480, 78)
        Me.cmb_tricocefaloL.Name = "cmb_tricocefaloL"
        Me.cmb_tricocefaloL.Size = New System.Drawing.Size(70, 21)
        Me.cmb_tricocefaloL.TabIndex = 24
        '
        'cmb_tricocefaloH
        '
        Me.cmb_tricocefaloH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_tricocefaloH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tricocefaloH.Enabled = False
        Me.cmb_tricocefaloH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tricocefaloH.ItemHeight = 13
        Me.cmb_tricocefaloH.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_tricocefaloH.Location = New System.Drawing.Point(408, 78)
        Me.cmb_tricocefaloH.Name = "cmb_tricocefaloH"
        Me.cmb_tricocefaloH.Size = New System.Drawing.Size(70, 21)
        Me.cmb_tricocefaloH.TabIndex = 23
        '
        'cmb_BalColT
        '
        Me.cmb_BalColT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_BalColT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BalColT.Enabled = False
        Me.cmb_BalColT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_BalColT.ItemHeight = 13
        Me.cmb_BalColT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_BalColT.Location = New System.Drawing.Point(186, 272)
        Me.cmb_BalColT.Name = "cmb_BalColT"
        Me.cmb_BalColT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_BalColT.TabIndex = 22
        '
        'cmb_BalColQ
        '
        Me.cmb_BalColQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_BalColQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BalColQ.Enabled = False
        Me.cmb_BalColQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_BalColQ.ItemHeight = 13
        Me.cmb_BalColQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_BalColQ.Location = New System.Drawing.Point(114, 272)
        Me.cmb_BalColQ.Name = "cmb_BalColQ"
        Me.cmb_BalColQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_BalColQ.TabIndex = 21
        '
        'cmb_TriHomT
        '
        Me.cmb_TriHomT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_TriHomT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TriHomT.Enabled = False
        Me.cmb_TriHomT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TriHomT.ItemHeight = 13
        Me.cmb_TriHomT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_TriHomT.Location = New System.Drawing.Point(186, 250)
        Me.cmb_TriHomT.Name = "cmb_TriHomT"
        Me.cmb_TriHomT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_TriHomT.TabIndex = 20
        '
        'cmb_TriHomQ
        '
        Me.cmb_TriHomQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_TriHomQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TriHomQ.Enabled = False
        Me.cmb_TriHomQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TriHomQ.ItemHeight = 13
        Me.cmb_TriHomQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_TriHomQ.Location = New System.Drawing.Point(114, 250)
        Me.cmb_TriHomQ.Name = "cmb_TriHomQ"
        Me.cmb_TriHomQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_TriHomQ.TabIndex = 19
        '
        'cmb_GiaLamT
        '
        Me.cmb_GiaLamT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_GiaLamT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GiaLamT.Enabled = False
        Me.cmb_GiaLamT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_GiaLamT.ItemHeight = 13
        Me.cmb_GiaLamT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_GiaLamT.Location = New System.Drawing.Point(186, 228)
        Me.cmb_GiaLamT.Name = "cmb_GiaLamT"
        Me.cmb_GiaLamT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_GiaLamT.TabIndex = 18
        '
        'cmb_GiaLamQ
        '
        Me.cmb_GiaLamQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_GiaLamQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GiaLamQ.Enabled = False
        Me.cmb_GiaLamQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_GiaLamQ.ItemHeight = 13
        Me.cmb_GiaLamQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_GiaLamQ.Location = New System.Drawing.Point(114, 228)
        Me.cmb_GiaLamQ.Name = "cmb_GiaLamQ"
        Me.cmb_GiaLamQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_GiaLamQ.TabIndex = 17
        '
        'cmb_chilomastixT
        '
        Me.cmb_chilomastixT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_chilomastixT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_chilomastixT.Enabled = False
        Me.cmb_chilomastixT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_chilomastixT.ItemHeight = 13
        Me.cmb_chilomastixT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_chilomastixT.Location = New System.Drawing.Point(186, 206)
        Me.cmb_chilomastixT.Name = "cmb_chilomastixT"
        Me.cmb_chilomastixT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_chilomastixT.TabIndex = 16
        '
        'cmb_chilomastixQ
        '
        Me.cmb_chilomastixQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_chilomastixQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_chilomastixQ.Enabled = False
        Me.cmb_chilomastixQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_chilomastixQ.ItemHeight = 13
        Me.cmb_chilomastixQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_chilomastixQ.Location = New System.Drawing.Point(114, 206)
        Me.cmb_chilomastixQ.Name = "cmb_chilomastixQ"
        Me.cmb_chilomastixQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_chilomastixQ.TabIndex = 15
        '
        'cmb_embadomaT
        '
        Me.cmb_embadomaT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_embadomaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_embadomaT.Enabled = False
        Me.cmb_embadomaT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_embadomaT.ItemHeight = 13
        Me.cmb_embadomaT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_embadomaT.Location = New System.Drawing.Point(186, 184)
        Me.cmb_embadomaT.Name = "cmb_embadomaT"
        Me.cmb_embadomaT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_embadomaT.TabIndex = 14
        '
        'cmb_embadomaQ
        '
        Me.cmb_embadomaQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_embadomaQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_embadomaQ.Enabled = False
        Me.cmb_embadomaQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_embadomaQ.ItemHeight = 13
        Me.cmb_embadomaQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_embadomaQ.Location = New System.Drawing.Point(114, 184)
        Me.cmb_embadomaQ.Name = "cmb_embadomaQ"
        Me.cmb_embadomaQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_embadomaQ.TabIndex = 13
        '
        'cmb_enteromaT
        '
        Me.cmb_enteromaT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_enteromaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_enteromaT.Enabled = False
        Me.cmb_enteromaT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_enteromaT.ItemHeight = 13
        Me.cmb_enteromaT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_enteromaT.Location = New System.Drawing.Point(186, 162)
        Me.cmb_enteromaT.Name = "cmb_enteromaT"
        Me.cmb_enteromaT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_enteromaT.TabIndex = 12
        '
        'cmb_enteromaQ
        '
        Me.cmb_enteromaQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_enteromaQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_enteromaQ.Enabled = False
        Me.cmb_enteromaQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_enteromaQ.ItemHeight = 13
        Me.cmb_enteromaQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_enteromaQ.Location = New System.Drawing.Point(114, 162)
        Me.cmb_enteromaQ.Name = "cmb_enteromaQ"
        Me.cmb_enteromaQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_enteromaQ.TabIndex = 11
        '
        'cmb_endNanT
        '
        Me.cmb_endNanT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_endNanT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_endNanT.Enabled = False
        Me.cmb_endNanT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_endNanT.ItemHeight = 13
        Me.cmb_endNanT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_endNanT.Location = New System.Drawing.Point(186, 140)
        Me.cmb_endNanT.Name = "cmb_endNanT"
        Me.cmb_endNanT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_endNanT.TabIndex = 10
        '
        'cmb_endNanQ
        '
        Me.cmb_endNanQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_endNanQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_endNanQ.Enabled = False
        Me.cmb_endNanQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_endNanQ.ItemHeight = 13
        Me.cmb_endNanQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_endNanQ.Location = New System.Drawing.Point(114, 140)
        Me.cmb_endNanQ.Name = "cmb_endNanQ"
        Me.cmb_endNanQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_endNanQ.TabIndex = 9
        '
        'cmb_yodamebaT
        '
        Me.cmb_yodamebaT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_yodamebaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_yodamebaT.Enabled = False
        Me.cmb_yodamebaT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_yodamebaT.ItemHeight = 13
        Me.cmb_yodamebaT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_yodamebaT.Location = New System.Drawing.Point(186, 118)
        Me.cmb_yodamebaT.Name = "cmb_yodamebaT"
        Me.cmb_yodamebaT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_yodamebaT.TabIndex = 8
        '
        'cmb_yodamebaQ
        '
        Me.cmb_yodamebaQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_yodamebaQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_yodamebaQ.Enabled = False
        Me.cmb_yodamebaQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_yodamebaQ.ItemHeight = 13
        Me.cmb_yodamebaQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_yodamebaQ.Location = New System.Drawing.Point(114, 118)
        Me.cmb_yodamebaQ.Name = "cmb_yodamebaQ"
        Me.cmb_yodamebaQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_yodamebaQ.TabIndex = 7
        '
        'cmb_ameColT
        '
        Me.cmb_ameColT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_ameColT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ameColT.Enabled = False
        Me.cmb_ameColT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ameColT.ItemHeight = 13
        Me.cmb_ameColT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_ameColT.Location = New System.Drawing.Point(186, 96)
        Me.cmb_ameColT.Name = "cmb_ameColT"
        Me.cmb_ameColT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_ameColT.TabIndex = 6
        '
        'cmb_ameColQ
        '
        Me.cmb_ameColQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_ameColQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ameColQ.Enabled = False
        Me.cmb_ameColQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ameColQ.ItemHeight = 13
        Me.cmb_ameColQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_ameColQ.Location = New System.Drawing.Point(114, 96)
        Me.cmb_ameColQ.Name = "cmb_ameColQ"
        Me.cmb_ameColQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_ameColQ.TabIndex = 5
        '
        'cmb_ameHisT
        '
        Me.cmb_ameHisT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_ameHisT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ameHisT.Enabled = False
        Me.cmb_ameHisT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ameHisT.ItemHeight = 13
        Me.cmb_ameHisT.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_ameHisT.Location = New System.Drawing.Point(186, 74)
        Me.cmb_ameHisT.Name = "cmb_ameHisT"
        Me.cmb_ameHisT.Size = New System.Drawing.Size(70, 21)
        Me.cmb_ameHisT.TabIndex = 4
        '
        'cmb_AmeHisQ
        '
        Me.cmb_AmeHisQ.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_AmeHisQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AmeHisQ.Enabled = False
        Me.cmb_AmeHisQ.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_AmeHisQ.ItemHeight = 13
        Me.cmb_AmeHisQ.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_AmeHisQ.Location = New System.Drawing.Point(114, 74)
        Me.cmb_AmeHisQ.Name = "cmb_AmeHisQ"
        Me.cmb_AmeHisQ.Size = New System.Drawing.Size(70, 21)
        Me.cmb_AmeHisQ.TabIndex = 3
        '
        'txt_obsc
        '
        Me.txt_obsc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_obsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obsc.Enabled = False
        Me.txt_obsc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obsc.Location = New System.Drawing.Point(114, 408)
        Me.txt_obsc.MaxLength = 250
        Me.txt_obsc.Multiline = True
        Me.txt_obsc.Name = "txt_obsc"
        Me.txt_obsc.Size = New System.Drawing.Size(436, 34)
        Me.txt_obsc.TabIndex = 52
        Me.txt_obsc.Text = ""
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Green
        Me.Label24.Location = New System.Drawing.Point(4, 302)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 14)
        Me.Label24.TabIndex = 140
        Me.Label24.Text = "COPROLOGICO"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Green
        Me.Label20.Location = New System.Drawing.Point(488, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 14)
        Me.Label20.TabIndex = 139
        Me.Label20.Text = "Larvas"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(426, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 14)
        Me.Label21.TabIndex = 138
        Me.Label21.Text = "Huevos"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Green
        Me.Label18.Location = New System.Drawing.Point(302, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 14)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "HELMINTOS"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(196, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 14)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Trofozoitos"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(132, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 14)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Quistes"
        '
        'chk_obsC
        '
        Me.chk_obsC.BackColor = System.Drawing.Color.Transparent
        Me.chk_obsC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_obsC.Location = New System.Drawing.Point(4, 408)
        Me.chk_obsC.Name = "chk_obsC"
        Me.chk_obsC.Size = New System.Drawing.Size(108, 18)
        Me.chk_obsC.TabIndex = 51
        Me.chk_obsC.Text = "Observaciones"
        '
        'txt_piocitosC
        '
        Me.txt_piocitosC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_piocitosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_piocitosC.Enabled = False
        Me.txt_piocitosC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_piocitosC.Location = New System.Drawing.Point(114, 340)
        Me.txt_piocitosC.MaxLength = 100
        Me.txt_piocitosC.Name = "txt_piocitosC"
        Me.txt_piocitosC.Size = New System.Drawing.Size(118, 21)
        Me.txt_piocitosC.TabIndex = 40
        Me.txt_piocitosC.Text = "escasos"
        '
        'txt_celulasC
        '
        Me.txt_celulasC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_celulasC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_celulasC.Enabled = False
        Me.txt_celulasC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celulasC.Location = New System.Drawing.Point(114, 360)
        Me.txt_celulasC.MaxLength = 50
        Me.txt_celulasC.Name = "txt_celulasC"
        Me.txt_celulasC.Size = New System.Drawing.Size(118, 21)
        Me.txt_celulasC.TabIndex = 41
        Me.txt_celulasC.Text = "escasas"
        '
        'lbl_consistencia
        '
        Me.lbl_consistencia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_consistencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consistencia.Location = New System.Drawing.Point(302, 22)
        Me.lbl_consistencia.Name = "lbl_consistencia"
        Me.lbl_consistencia.Size = New System.Drawing.Size(70, 16)
        Me.lbl_consistencia.TabIndex = 56
        Me.lbl_consistencia.Text = "Consistencia:"
        '
        'txt_consistencia
        '
        Me.txt_consistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_consistencia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_consistencia.Location = New System.Drawing.Point(382, 22)
        Me.txt_consistencia.MaxLength = 100
        Me.txt_consistencia.Name = "txt_consistencia"
        Me.txt_consistencia.Size = New System.Drawing.Size(168, 21)
        Me.txt_consistencia.TabIndex = 2
        Me.txt_consistencia.Text = ""
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(62, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 18)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Color:"
        '
        'txt_colorC
        '
        Me.txt_colorC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_colorC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_colorC.Location = New System.Drawing.Point(112, 20)
        Me.txt_colorC.MaxLength = 100
        Me.txt_colorC.Name = "txt_colorC"
        Me.txt_colorC.Size = New System.Drawing.Size(146, 21)
        Me.txt_colorC.TabIndex = 1
        Me.txt_colorC.Text = ""
        '
        'lbl_anaEle
        '
        Me.lbl_anaEle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_anaEle.Font = New System.Drawing.Font("Tahoma", 8.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_anaEle.ForeColor = System.Drawing.Color.Green
        Me.lbl_anaEle.Location = New System.Drawing.Point(4, 58)
        Me.lbl_anaEle.Name = "lbl_anaEle"
        Me.lbl_anaEle.Size = New System.Drawing.Size(76, 14)
        Me.lbl_anaEle.TabIndex = 53
        Me.lbl_anaEle.Text = "PROTOZOOS"
        '
        'pnl_coproanalisis
        '
        Me.pnl_coproanalisis.BackColor = System.Drawing.Color.Transparent
        Me.pnl_coproanalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_coproanalisis.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmb_almidones, Me.cmb_resVeg, Me.cmb_moco, Me.cmb_SanOcu, Me.txt_PMN, Me.chk_SanOcu, Me.chk_PMN, Me.chk_MocoC, Me.chk_CelulasC, Me.chk_PiocitosC, Me.chk_hematiesC, Me.chk_oxiuros, Me.chk_uncinarias, Me.chk_AscLum, Me.chk_tricocefalo, Me.chk_Enteromona, Me.chk_EndNan, Me.chk_Yodameba, Me.chk_AmeCol, Me.chk_ameHis, Me.cmb_Hongos, Me.txt_hematiesC, Me.cmb_blaHom, Me.cmb_levaduras, Me.cmb_grasas, Me.cmb_HimDimL, Me.cmb_HimDimH, Me.cmb_HimNanL, Me.cmb_HimNanH, Me.cmb_tenSolL, Me.cmb_tenSolH, Me.cmb_estrongiloidesL, Me.cmb_estrongiloidesH, Me.cmb_oxiurosL, Me.cmb_OxiurosH, Me.cmb_uncinariasL, Me.cmb_uncinariasH, Me.cmb_ascLumL, Me.cmb_ascLumH, Me.cmb_tricocefaloL, Me.cmb_tricocefaloH, Me.cmb_BalColT, Me.cmb_BalColQ, Me.cmb_TriHomT, Me.cmb_TriHomQ, Me.cmb_GiaLamT, Me.cmb_GiaLamQ, Me.cmb_chilomastixT, Me.cmb_chilomastixQ, Me.cmb_embadomaT, Me.cmb_embadomaQ, Me.cmb_enteromaT, Me.cmb_enteromaQ, Me.cmb_endNanT, Me.cmb_endNanQ, Me.cmb_yodamebaT, Me.cmb_yodamebaQ, Me.cmb_ameColT, Me.cmb_ameColQ, Me.cmb_ameHisT, Me.cmb_AmeHisQ, Me.txt_obsc, Me.Label24, Me.Label20, Me.Label21, Me.Label18, Me.Label15, Me.Label14, Me.Label12, Me.chk_obsC, Me.txt_piocitosC, Me.txt_celulasC, Me.lbl_consistencia, Me.txt_consistencia, Me.Label19, Me.txt_colorC, Me.lbl_anaEle, Me.chk_balCol, Me.chk_TriHom, Me.chk_GiaLam, Me.chk_Chilomastix, Me.chk_Embadomona, Me.chk_HimDim, Me.chk_HimNana, Me.chk_TenSol, Me.chk_Estrongiloides, Me.chk_Hongos, Me.chk_Levaduras, Me.chk_Grasas, Me.chk_Almidones, Me.chk_ResVeg, Me.chk_BlaHom})
        Me.pnl_coproanalisis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_coproanalisis.Location = New System.Drawing.Point(14, 132)
        Me.pnl_coproanalisis.Name = "pnl_coproanalisis"
        Me.pnl_coproanalisis.Size = New System.Drawing.Size(565, 446)
        Me.pnl_coproanalisis.TabIndex = 59
        Me.pnl_coproanalisis.Visible = False
        '
        'cmb_almidones
        '
        Me.cmb_almidones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_almidones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_almidones.Enabled = False
        Me.cmb_almidones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_almidones.ItemHeight = 13
        Me.cmb_almidones.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_almidones.Location = New System.Drawing.Point(324, 382)
        Me.cmb_almidones.Name = "cmb_almidones"
        Me.cmb_almidones.Size = New System.Drawing.Size(70, 21)
        Me.cmb_almidones.TabIndex = 46
        '
        'cmb_resVeg
        '
        Me.cmb_resVeg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_resVeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_resVeg.Enabled = False
        Me.cmb_resVeg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_resVeg.ItemHeight = 13
        Me.cmb_resVeg.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_resVeg.Location = New System.Drawing.Point(324, 360)
        Me.cmb_resVeg.Name = "cmb_resVeg"
        Me.cmb_resVeg.Size = New System.Drawing.Size(70, 21)
        Me.cmb_resVeg.TabIndex = 45
        '
        'cmb_SanOcu
        '
        Me.cmb_SanOcu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_SanOcu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SanOcu.Enabled = False
        Me.cmb_SanOcu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_SanOcu.ItemHeight = 13
        Me.cmb_SanOcu.Items.AddRange(New Object() {"Negativo", "Positivo (+)", "Positivo (++)", "Positivo (+++)"})
        Me.cmb_SanOcu.Location = New System.Drawing.Point(324, 316)
        Me.cmb_SanOcu.Name = "cmb_SanOcu"
        Me.cmb_SanOcu.Size = New System.Drawing.Size(70, 21)
        Me.cmb_SanOcu.TabIndex = 44
        '
        'txt_PMN
        '
        Me.txt_PMN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_PMN.Location = New System.Drawing.Point(114, 380)
        Me.txt_PMN.Name = "txt_PMN"
        Me.txt_PMN.Prp_Formato = True
        Me.txt_PMN.Prp_NumDecimales = 2
        Me.txt_PMN.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.txt_PMN.Prp_ValDefault = "0"
        Me.txt_PMN.Size = New System.Drawing.Size(118, 21)
        Me.txt_PMN.TabIndex = 43
        '
        'chk_SanOcu
        '
        Me.chk_SanOcu.BackColor = System.Drawing.Color.Transparent
        Me.chk_SanOcu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_SanOcu.Location = New System.Drawing.Point(240, 318)
        Me.chk_SanOcu.Name = "chk_SanOcu"
        Me.chk_SanOcu.Size = New System.Drawing.Size(93, 18)
        Me.chk_SanOcu.TabIndex = 250
        Me.chk_SanOcu.Text = "Sangre Oculta"
        '
        'chk_PMN
        '
        Me.chk_PMN.BackColor = System.Drawing.Color.Transparent
        Me.chk_PMN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PMN.Location = New System.Drawing.Point(4, 380)
        Me.chk_PMN.Name = "chk_PMN"
        Me.chk_PMN.Size = New System.Drawing.Size(112, 18)
        Me.chk_PMN.TabIndex = 244
        Me.chk_PMN.Text = "Polimorfo-nuclear"
        '
        'chk_MocoC
        '
        Me.chk_MocoC.BackColor = System.Drawing.Color.Transparent
        Me.chk_MocoC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_MocoC.Location = New System.Drawing.Point(240, 338)
        Me.chk_MocoC.Name = "chk_MocoC"
        Me.chk_MocoC.Size = New System.Drawing.Size(93, 18)
        Me.chk_MocoC.TabIndex = 243
        Me.chk_MocoC.Text = "Moco"
        '
        'chk_CelulasC
        '
        Me.chk_CelulasC.BackColor = System.Drawing.Color.Transparent
        Me.chk_CelulasC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_CelulasC.Location = New System.Drawing.Point(4, 360)
        Me.chk_CelulasC.Name = "chk_CelulasC"
        Me.chk_CelulasC.Size = New System.Drawing.Size(108, 18)
        Me.chk_CelulasC.TabIndex = 242
        Me.chk_CelulasC.Text = "Células"
        '
        'chk_PiocitosC
        '
        Me.chk_PiocitosC.BackColor = System.Drawing.Color.Transparent
        Me.chk_PiocitosC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PiocitosC.Location = New System.Drawing.Point(4, 340)
        Me.chk_PiocitosC.Name = "chk_PiocitosC"
        Me.chk_PiocitosC.Size = New System.Drawing.Size(108, 18)
        Me.chk_PiocitosC.TabIndex = 241
        Me.chk_PiocitosC.Text = "Piocitos"
        '
        'chk_hematiesC
        '
        Me.chk_hematiesC.BackColor = System.Drawing.Color.Transparent
        Me.chk_hematiesC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_hematiesC.Location = New System.Drawing.Point(4, 320)
        Me.chk_hematiesC.Name = "chk_hematiesC"
        Me.chk_hematiesC.Size = New System.Drawing.Size(108, 18)
        Me.chk_hematiesC.TabIndex = 240
        Me.chk_hematiesC.Text = "Hematíes"
        '
        'chk_oxiuros
        '
        Me.chk_oxiuros.BackColor = System.Drawing.Color.Transparent
        Me.chk_oxiuros.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_oxiuros.Location = New System.Drawing.Point(302, 146)
        Me.chk_oxiuros.Name = "chk_oxiuros"
        Me.chk_oxiuros.Size = New System.Drawing.Size(105, 18)
        Me.chk_oxiuros.TabIndex = 235
        Me.chk_oxiuros.Text = "Oxiuros"
        '
        'chk_uncinarias
        '
        Me.chk_uncinarias.BackColor = System.Drawing.Color.Transparent
        Me.chk_uncinarias.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_uncinarias.Location = New System.Drawing.Point(302, 126)
        Me.chk_uncinarias.Name = "chk_uncinarias"
        Me.chk_uncinarias.Size = New System.Drawing.Size(105, 18)
        Me.chk_uncinarias.TabIndex = 234
        Me.chk_uncinarias.Text = "Uncinarias"
        '
        'chk_AscLum
        '
        Me.chk_AscLum.BackColor = System.Drawing.Color.Transparent
        Me.chk_AscLum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AscLum.Location = New System.Drawing.Point(302, 100)
        Me.chk_AscLum.Name = "chk_AscLum"
        Me.chk_AscLum.Size = New System.Drawing.Size(105, 24)
        Me.chk_AscLum.TabIndex = 233
        Me.chk_AscLum.Text = "Ascaris Lumbricoides"
        '
        'chk_tricocefalo
        '
        Me.chk_tricocefalo.BackColor = System.Drawing.Color.Transparent
        Me.chk_tricocefalo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tricocefalo.Location = New System.Drawing.Point(302, 80)
        Me.chk_tricocefalo.Name = "chk_tricocefalo"
        Me.chk_tricocefalo.Size = New System.Drawing.Size(105, 18)
        Me.chk_tricocefalo.TabIndex = 232
        Me.chk_tricocefalo.Text = "Tricocéfalo"
        '
        'chk_Enteromona
        '
        Me.chk_Enteromona.BackColor = System.Drawing.Color.Transparent
        Me.chk_Enteromona.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Enteromona.Location = New System.Drawing.Point(4, 164)
        Me.chk_Enteromona.Name = "chk_Enteromona"
        Me.chk_Enteromona.Size = New System.Drawing.Size(110, 18)
        Me.chk_Enteromona.TabIndex = 226
        Me.chk_Enteromona.Text = "Enteromona"
        '
        'chk_EndNan
        '
        Me.chk_EndNan.BackColor = System.Drawing.Color.Transparent
        Me.chk_EndNan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_EndNan.Location = New System.Drawing.Point(4, 140)
        Me.chk_EndNan.Name = "chk_EndNan"
        Me.chk_EndNan.Size = New System.Drawing.Size(110, 18)
        Me.chk_EndNan.TabIndex = 225
        Me.chk_EndNan.Text = "Endolimax Nana"
        '
        'chk_Yodameba
        '
        Me.chk_Yodameba.BackColor = System.Drawing.Color.Transparent
        Me.chk_Yodameba.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Yodameba.Location = New System.Drawing.Point(4, 118)
        Me.chk_Yodameba.Name = "chk_Yodameba"
        Me.chk_Yodameba.Size = New System.Drawing.Size(110, 18)
        Me.chk_Yodameba.TabIndex = 224
        Me.chk_Yodameba.Text = "Yodameba"
        '
        'chk_AmeCol
        '
        Me.chk_AmeCol.BackColor = System.Drawing.Color.Transparent
        Me.chk_AmeCol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AmeCol.Location = New System.Drawing.Point(4, 96)
        Me.chk_AmeCol.Name = "chk_AmeCol"
        Me.chk_AmeCol.Size = New System.Drawing.Size(110, 18)
        Me.chk_AmeCol.TabIndex = 223
        Me.chk_AmeCol.Text = "Ameba Coli"
        '
        'chk_ameHis
        '
        Me.chk_ameHis.BackColor = System.Drawing.Color.Transparent
        Me.chk_ameHis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ameHis.Location = New System.Drawing.Point(4, 76)
        Me.chk_ameHis.Name = "chk_ameHis"
        Me.chk_ameHis.Size = New System.Drawing.Size(110, 18)
        Me.chk_ameHis.TabIndex = 222
        Me.chk_ameHis.Text = "Ameba Histolitica"
        '
        'cmb_Hongos
        '
        Me.cmb_Hongos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_Hongos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hongos.Enabled = False
        Me.cmb_Hongos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Hongos.ItemHeight = 13
        Me.cmb_Hongos.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_Hongos.Location = New System.Drawing.Point(480, 360)
        Me.cmb_Hongos.Name = "cmb_Hongos"
        Me.cmb_Hongos.Size = New System.Drawing.Size(70, 21)
        Me.cmb_Hongos.TabIndex = 221
        '
        'txt_hematiesC
        '
        Me.txt_hematiesC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hematiesC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hematiesC.Enabled = False
        Me.txt_hematiesC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hematiesC.Location = New System.Drawing.Point(114, 320)
        Me.txt_hematiesC.MaxLength = 100
        Me.txt_hematiesC.Name = "txt_hematiesC"
        Me.txt_hematiesC.Size = New System.Drawing.Size(118, 21)
        Me.txt_hematiesC.TabIndex = 220
        Me.txt_hematiesC.Text = "escasos"
        '
        'cmb_blaHom
        '
        Me.cmb_blaHom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_blaHom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_blaHom.Enabled = False
        Me.cmb_blaHom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_blaHom.ItemHeight = 13
        Me.cmb_blaHom.Items.AddRange(New Object() {"escasos", "(+)", "(++)", "(+++)"})
        Me.cmb_blaHom.Location = New System.Drawing.Point(480, 382)
        Me.cmb_blaHom.Name = "cmb_blaHom"
        Me.cmb_blaHom.Size = New System.Drawing.Size(70, 21)
        Me.cmb_blaHom.TabIndex = 50
        '
        'cmb_levaduras
        '
        Me.cmb_levaduras.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_levaduras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_levaduras.Enabled = False
        Me.cmb_levaduras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_levaduras.ItemHeight = 13
        Me.cmb_levaduras.Items.AddRange(New Object() {"escasas", "(+)", "(++)", "(+++)"})
        Me.cmb_levaduras.Location = New System.Drawing.Point(480, 338)
        Me.cmb_levaduras.Name = "cmb_levaduras"
        Me.cmb_levaduras.Size = New System.Drawing.Size(70, 21)
        Me.cmb_levaduras.TabIndex = 48
        '
        'cmb_grasas
        '
        Me.cmb_grasas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_grasas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_grasas.Enabled = False
        Me.cmb_grasas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_grasas.ItemHeight = 13
        Me.cmb_grasas.Items.AddRange(New Object() {"escasas", "(+)", "(++)", "(+++)"})
        Me.cmb_grasas.Location = New System.Drawing.Point(480, 316)
        Me.cmb_grasas.Name = "cmb_grasas"
        Me.cmb_grasas.Size = New System.Drawing.Size(70, 21)
        Me.cmb_grasas.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(14, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 14)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "COPROANALISIS"
        '
        'chk_balCol
        '
        Me.chk_balCol.BackColor = System.Drawing.Color.Transparent
        Me.chk_balCol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_balCol.Location = New System.Drawing.Point(4, 274)
        Me.chk_balCol.Name = "chk_balCol"
        Me.chk_balCol.Size = New System.Drawing.Size(110, 18)
        Me.chk_balCol.TabIndex = 231
        Me.chk_balCol.Text = "Balantidium Coli"
        '
        'chk_TriHom
        '
        Me.chk_TriHom.BackColor = System.Drawing.Color.Transparent
        Me.chk_TriHom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_TriHom.Location = New System.Drawing.Point(4, 252)
        Me.chk_TriHom.Name = "chk_TriHom"
        Me.chk_TriHom.Size = New System.Drawing.Size(128, 18)
        Me.chk_TriHom.TabIndex = 230
        Me.chk_TriHom.Text = "Trichomona Hominis"
        '
        'chk_GiaLam
        '
        Me.chk_GiaLam.BackColor = System.Drawing.Color.Transparent
        Me.chk_GiaLam.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_GiaLam.Location = New System.Drawing.Point(4, 230)
        Me.chk_GiaLam.Name = "chk_GiaLam"
        Me.chk_GiaLam.Size = New System.Drawing.Size(110, 18)
        Me.chk_GiaLam.TabIndex = 229
        Me.chk_GiaLam.Text = "Giardia Lamblia"
        '
        'chk_Chilomastix
        '
        Me.chk_Chilomastix.BackColor = System.Drawing.Color.Transparent
        Me.chk_Chilomastix.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Chilomastix.Location = New System.Drawing.Point(4, 208)
        Me.chk_Chilomastix.Name = "chk_Chilomastix"
        Me.chk_Chilomastix.Size = New System.Drawing.Size(110, 18)
        Me.chk_Chilomastix.TabIndex = 228
        Me.chk_Chilomastix.Text = "Chilomastix"
        '
        'chk_Embadomona
        '
        Me.chk_Embadomona.BackColor = System.Drawing.Color.Transparent
        Me.chk_Embadomona.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Embadomona.Location = New System.Drawing.Point(4, 186)
        Me.chk_Embadomona.Name = "chk_Embadomona"
        Me.chk_Embadomona.Size = New System.Drawing.Size(110, 18)
        Me.chk_Embadomona.TabIndex = 227
        Me.chk_Embadomona.Text = "Embadomona"
        '
        'chk_HimDim
        '
        Me.chk_HimDim.BackColor = System.Drawing.Color.Transparent
        Me.chk_HimDim.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_HimDim.Location = New System.Drawing.Point(302, 234)
        Me.chk_HimDim.Name = "chk_HimDim"
        Me.chk_HimDim.Size = New System.Drawing.Size(105, 18)
        Me.chk_HimDim.TabIndex = 239
        Me.chk_HimDim.Text = "Him. Diminuta"
        '
        'chk_HimNana
        '
        Me.chk_HimNana.BackColor = System.Drawing.Color.Transparent
        Me.chk_HimNana.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_HimNana.Location = New System.Drawing.Point(302, 212)
        Me.chk_HimNana.Name = "chk_HimNana"
        Me.chk_HimNana.Size = New System.Drawing.Size(105, 18)
        Me.chk_HimNana.TabIndex = 238
        Me.chk_HimNana.Text = "Him. Nana"
        '
        'chk_TenSol
        '
        Me.chk_TenSol.BackColor = System.Drawing.Color.Transparent
        Me.chk_TenSol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_TenSol.Location = New System.Drawing.Point(302, 190)
        Me.chk_TenSol.Name = "chk_TenSol"
        Me.chk_TenSol.Size = New System.Drawing.Size(105, 18)
        Me.chk_TenSol.TabIndex = 237
        Me.chk_TenSol.Text = "Tenia Solium"
        '
        'chk_Estrongiloides
        '
        Me.chk_Estrongiloides.BackColor = System.Drawing.Color.Transparent
        Me.chk_Estrongiloides.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Estrongiloides.Location = New System.Drawing.Point(302, 168)
        Me.chk_Estrongiloides.Name = "chk_Estrongiloides"
        Me.chk_Estrongiloides.Size = New System.Drawing.Size(105, 18)
        Me.chk_Estrongiloides.TabIndex = 236
        Me.chk_Estrongiloides.Text = "Estrongiloides"
        '
        'chk_Hongos
        '
        Me.chk_Hongos.BackColor = System.Drawing.Color.Transparent
        Me.chk_Hongos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Hongos.Location = New System.Drawing.Point(402, 360)
        Me.chk_Hongos.Name = "chk_Hongos"
        Me.chk_Hongos.Size = New System.Drawing.Size(75, 18)
        Me.chk_Hongos.TabIndex = 249
        Me.chk_Hongos.Text = "Hongos"
        '
        'chk_Levaduras
        '
        Me.chk_Levaduras.BackColor = System.Drawing.Color.Transparent
        Me.chk_Levaduras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Levaduras.Location = New System.Drawing.Point(402, 340)
        Me.chk_Levaduras.Name = "chk_Levaduras"
        Me.chk_Levaduras.Size = New System.Drawing.Size(75, 18)
        Me.chk_Levaduras.TabIndex = 248
        Me.chk_Levaduras.Text = "Levaduras"
        '
        'chk_Grasas
        '
        Me.chk_Grasas.BackColor = System.Drawing.Color.Transparent
        Me.chk_Grasas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Grasas.Location = New System.Drawing.Point(402, 320)
        Me.chk_Grasas.Name = "chk_Grasas"
        Me.chk_Grasas.Size = New System.Drawing.Size(75, 18)
        Me.chk_Grasas.TabIndex = 247
        Me.chk_Grasas.Text = "Grasas"
        '
        'chk_Almidones
        '
        Me.chk_Almidones.BackColor = System.Drawing.Color.Transparent
        Me.chk_Almidones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Almidones.Location = New System.Drawing.Point(240, 384)
        Me.chk_Almidones.Name = "chk_Almidones"
        Me.chk_Almidones.Size = New System.Drawing.Size(93, 18)
        Me.chk_Almidones.TabIndex = 246
        Me.chk_Almidones.Text = "Almidones"
        '
        'chk_ResVeg
        '
        Me.chk_ResVeg.BackColor = System.Drawing.Color.Transparent
        Me.chk_ResVeg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ResVeg.Location = New System.Drawing.Point(240, 356)
        Me.chk_ResVeg.Name = "chk_ResVeg"
        Me.chk_ResVeg.Size = New System.Drawing.Size(93, 26)
        Me.chk_ResVeg.TabIndex = 245
        Me.chk_ResVeg.Text = "Restos Vegetales"
        '
        'chk_BlaHom
        '
        Me.chk_BlaHom.BackColor = System.Drawing.Color.Transparent
        Me.chk_BlaHom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BlaHom.Location = New System.Drawing.Point(402, 378)
        Me.chk_BlaHom.Name = "chk_BlaHom"
        Me.chk_BlaHom.Size = New System.Drawing.Size(78, 26)
        Me.chk_BlaHom.TabIndex = 251
        Me.chk_BlaHom.Text = "Blastocistis Hominis"
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.AddRange(New System.Windows.Forms.Control() {Me.pic_icono, Me.pan_btn, Me.lbl_textform, Me.pic_barra})
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(592, 25)
        Me.pan_barra.TabIndex = 92
        '
        'pic_icono
        '
        Me.pic_icono.BackColor = System.Drawing.Color.SteelBlue
        Me.pic_icono.Image = CType(resources.GetObject("pic_icono.Image"), System.Drawing.Bitmap)
        Me.pic_icono.Location = New System.Drawing.Point(22, 5)
        Me.pic_icono.Name = "pic_icono"
        Me.pic_icono.Size = New System.Drawing.Size(16, 16)
        Me.pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_icono.TabIndex = 63
        Me.pic_icono.TabStop = False
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.AddRange(New System.Windows.Forms.Control() {Me.pic_min, Me.Pic_close})
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(542, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(27, 12)
        Me.pan_btn.TabIndex = 3
        '
        'pic_min
        '
        Me.pic_min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pic_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_min.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_min.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pic_min.Image = CType(resources.GetObject("pic_min.Image"), System.Drawing.Bitmap)
        Me.pic_min.Name = "pic_min"
        Me.pic_min.Size = New System.Drawing.Size(12, 12)
        Me.pic_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_min.TabIndex = 2
        Me.pic_min.TabStop = False
        '
        'Pic_close
        '
        Me.Pic_close.BackColor = System.Drawing.SystemColors.Control
        Me.Pic_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pic_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pic_close.Image = CType(resources.GetObject("Pic_close.Image"), System.Drawing.Bitmap)
        Me.Pic_close.Location = New System.Drawing.Point(15, 0)
        Me.Pic_close.Name = "Pic_close"
        Me.Pic_close.Size = New System.Drawing.Size(12, 12)
        Me.Pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_close.TabIndex = 1
        Me.Pic_close.TabStop = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.White
        Me.lbl_textform.Image = CType(resources.GetObject("lbl_textform.Image"), System.Drawing.Bitmap)
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(35, 7)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(180, 14)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = " Ingreso Manual de Resultados"
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Image = CType(resources.GetObject("pic_barra.Image"), System.Drawing.Bitmap)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(592, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 91
        Me.pic_barra.TabStop = False
        '
        'frm_Ing_Resul_Manuales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(592, 610)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pan_barra, Me.btn_Salir, Me.btn_Aceptar, Me.grp_datos, Me.grp_uroanalisis, Me.grp_general, Me.pnl_coproanalisis})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Ing_Resul_Manuales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Manual de Resultados"
        Me.grp_uroanalisis.ResumeLayout(False)
        Me.grp_datos.ResumeLayout(False)
        Me.grp_general.ResumeLayout(False)
        Me.pnl_coproanalisis.ResumeLayout(False)
        Me.pan_barra.ResumeLayout(False)
        Me.pan_btn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Código de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp, pic_barra.MouseUp, pic_icono.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y - frm_refer_main_form.Pan_toolbox.Height)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseMove, pic_barra.MouseMove, pic_icono.MouseMove
        ClickMenu_Principal(Me)
        'Función para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            dbl_x = mousePos.X
            frm_refer_main_form.ubica(Me.Width, Me.Height, mousePos.Y - frm_refer_main_form.Pan_toolbox.Height, mousePos.X - frm_refer_main_form.Splitter.Width)
        End If
    End Sub

    Private Sub Formulario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
    End Sub

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseDown, pic_barra.MouseDown, pic_icono.MouseDown
        'Función para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub


    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_min.MouseEnter, Pic_close.MouseEnter, btn_Aceptar.MouseEnter, btn_Salir.MouseEnter, btn_busqueda.MouseEnter, btn_ObsPac.MouseEnter
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


    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_min.MouseLeave, Pic_close.MouseLeave, btn_Aceptar.MouseLeave, btn_Salir.MouseLeave, btn_busqueda.MouseLeave, btn_ObsPac.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, lbl_textform.Click, pic_barra.Click, pic_min.Click, Pic_close.Click
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

    Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_pedido As New Cls_Pedido()
    Dim str_antecedentes, str_medicamentos, str_obs As String

    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        'Comprueba que no exista un formulario abierto ya en la aplicacion
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function

    Private Sub chk_proteinas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_proteinas.CheckedChanged
        If (chk_proteinas.Checked = True) Then
            txt_proteinas.Text = ""
            txt_proteinas.ReadOnly = False
            txt_proteinas.Focus()
        Else
            txt_proteinas.Text = "NEGATIVO"
            txt_proteinas.ReadOnly = True
        End If
    End Sub

    Private Sub chk_glucosas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_glucosas.CheckedChanged
        If (chk_glucosas.Checked = True) Then
            txt_glucosa.Text = ""
            txt_glucosa.ReadOnly = False
            txt_glucosa.Focus()
        Else
            txt_glucosa.Text = "NEGATIVO"
            txt_glucosa.ReadOnly = True
        End If
    End Sub

    Private Sub chk_cetonas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cetonas.CheckedChanged
        If (chk_cetonas.Checked = True) Then
            txt_cetonas.Text = ""
            txt_cetonas.ReadOnly = False
            txt_cetonas.Focus()
        Else
            txt_cetonas.Text = "NEGATIVO"
            txt_cetonas.ReadOnly = True
        End If
    End Sub

    Private Sub chk_bilirrubinas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bilirrubinas.CheckedChanged
        If (chk_bilirrubinas.Checked = True) Then
            txt_bilirrubinas.Text = ""
            txt_bilirrubinas.ReadOnly = False
            txt_bilirrubinas.Focus()
        Else
            txt_bilirrubinas.Text = "NEGATIVO"
            txt_bilirrubinas.ReadOnly = True
        End If
    End Sub

    Private Sub chk_urobilinog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_urobilinog.CheckedChanged
        If (chk_urobilinog.Checked = True) Then
            txt_urobilinog.Text = ""
            txt_urobilinog.ReadOnly = False
            txt_urobilinog.Focus()
        Else
            txt_urobilinog.Text = "NORMAL"
            txt_urobilinog.ReadOnly = True
        End If
    End Sub

    Private Sub chk_nitritos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_nitritos.CheckedChanged
        If (chk_nitritos.Checked = True) Then
            txt_nitritos.Text = "POSITIVO"
        Else
            txt_nitritos.Text = "NEGATIVO"
        End If
    End Sub

    Private Sub chk_bacterias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bacterias.CheckedChanged
        If (chk_bacterias.Checked = True) Then
            txt_bacterias.ReadOnly = False
            txt_bacterias.Text = ""
            txt_bacterias.Focus()
        Else
            txt_bacterias.Text = "NEGATIVO"
            txt_bacterias.ReadOnly = True
        End If
    End Sub

    Private Sub chk_moco_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_moco.CheckedChanged
        If (chk_moco.Checked = True) Then
            txt_moco.Text = ""
            txt_moco.ReadOnly = False
            txt_moco.Focus()
        Else
            txt_moco.Text = "NEGATIVO"
            txt_moco.ReadOnly = True
        End If
    End Sub

    Private Sub chk_cel_epitel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_celulas.CheckedChanged
        If (chk_celulas.Checked = True) Then
            txt_celulas.ReadOnly = False
            txt_celulas.Text = ""
            txt_celulas.Focus()
        Else
            txt_celulas.Text = "NEGATIVO"
            txt_celulas.ReadOnly = True
        End If
    End Sub

    Private Sub chk_piocitos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_piocitos.CheckedChanged
        If (chk_piocitos.Checked = True) Then
            txt_piocitos.ReadOnly = False
            txt_piocitos.Text = ""
            txt_piocitos.Focus()
        Else
            txt_piocitos.Text = "NEGATIVO"
            txt_piocitos.ReadOnly = True
        End If
    End Sub

    Private Sub chk_Obs2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Obs2.CheckedChanged
        If (chk_Obs2.Checked = True) Then
            txt_obs2.Text = ""
            txt_obs2.Enabled = True
        Else
            txt_obs2.Text = ""
            txt_obs2.Enabled = False
        End If
    End Sub

    Private Sub btn_busqeda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_busqueda.Click

        Me.Tag = ""
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Not ExisteForm("frm_Test_Manuales") Then
            Dim frm_MDIChild As New frm_Test_Manuales()
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.ShowDialog(Me.ParentForm)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Public Sub llena_datos_paciente()
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        Call Limpiar_Grp_G()
        If Me.Tag = "" Then  'SI NO HAY NADA EN EL TAG DEL FORMULARIO SALGA 
            Exit Sub
        End If
        'RECUPERO LOS DATOS DEL PEDIDO DEL TAG DEL FORMULARIO
        str_campos = Split(Me.Tag, "/*/")
        lbl_pedidoD.Text = ""
        lbl_pacD.Text = ""
        lbl_fecha.Text = ""
        lbl_test.Text = ""
        lbl_fecnacd.Text = ""
        lbl_edad.Text = ""
        str_antecedentes = ""
        str_medicamentos = ""
        str_obs = ""
        For int_indice = 0 To UBound(str_campos)
            int_pos = InStr(str_campos(int_indice), "=")
            str_texto = str_campos(int_indice).Substring(0, int_pos - 1)
            str_valor = str_campos(int_indice).Substring(int_pos)
            Select Case str_texto
                Case "ped_id"
                    lbl_pedidoD.Text = (str_valor)
                Case "pac_nombre"
                    lbl_pacD.Text = (str_valor)
                Case "ped_fecing"
                    lbl_fecha.Text = (str_valor)
                Case "tes_id"
                    lbl_test.Text = (str_valor)
                Case "tes_nombre"
                    lbl_test_nombre.Text = (str_valor)
                Case "pac_fecnac"
                    lbl_fecnacd.Text = Format(CDate(str_valor), "dd-MMM-yyyy")
                Case "ped_antecedente"
                    str_antecedentes = (str_valor)
                Case "ped_medicacion"
                    str_medicamentos = (str_valor)
                Case "pac_obs"
                    str_obs = (str_valor)
            End Select
        Next
        'EN FUNCION DEL NOMBRE DEL TEST RECUPERADO, ACTIVO EL GROUP 
        'CORRESPONDIENTE PARA EL INGRESO DE LOS RESULTADOS 
        If (lbl_test_nombre.Text = "COPROPARASITARIO") Then
            pnl_coproanalisis.Visible = True
            grp_uroanalisis.Visible = False
            grp_general.Visible = False
        Else
            If (lbl_test_nombre.Text = "EMO") Then
                pnl_coproanalisis.Visible = False
                grp_uroanalisis.Visible = True
                grp_general.Visible = False
            Else
                pnl_coproanalisis.Visible = False
                grp_uroanalisis.Visible = False
                grp_general.Visible = True
                cmb_cualitativo.SelectedIndex = 1
                Dim opr_test As New Cls_TipoTest()
                Dim dts_res As DataSet
                Dim dtr_fila As DataRow
                dts_res = opr_test.ConsultarTest_resultado(Trim(lbl_test.Text))
                Ctl_txt_numerico.texto_Asigna("")
                Ctl_txt_numerico.Enabled = False
                For Each dtr_fila In dts_res.Tables("Registros").Rows
                    If (dtr_fila(0) = 1) Then ' RESULT NUMERICO
                        Ctl_txt_numerico.Enabled = True
                        chk_unidades.Enabled = True
                        Dim opr_parametros As New Cls_Parametros()
                        opr_parametros.LLenarCmbUnidad(cmb_unidades)
                        Label13.Text = dtr_fila(1)
                    End If
                    If (dtr_fila(0) = 2) Then   'RESULT TEXTO
                        txt_ObsG.Enabled = True
                    End If
                    If (dtr_fila(0) = 3) Then   'RESULT CUALITATIVA
                        cmb_cualitativo.Enabled = True
                    End If
                    If (dtr_fila(0) = 4) Then   'RESULT FORMULA
                        txt_formula.Enabled = True
                    End If
                    'Código para insertar el rango de normalidad en pantalla
                    If (dtr_fila(2) < 1) Then   'Consulto el tipo de rango normal
                        '0-> No posee, 1-> Rango único, 2 -> Rango Multipl
                        lbl_rangod.Text = ""
                    Else
                        If (dtr_fila(2) = 1) Then   'Si es rango único
                            lbl_rangod.Text = dtr_fila(3) & " -- " & dtr_fila(4)
                        Else    'Si es rango multiple
                            lbl_rangod.Text = dtr_fila(5)
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub chk_obsC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_obsC.CheckedChanged
        If (chk_obsC.Checked = True) Then
            txt_obsc.Text = ""
            txt_obsc.Enabled = True
        Else
            txt_obsc.Text = ""
            txt_obsc.Enabled = False
        End If
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        If MsgBox("Desea cerrar la ventana Ingreso Manual de Resultados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "LUMINO") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub chk_unidades_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_unidades.CheckedChanged
        If (chk_unidades.Checked = True) Then
            cmb_unidades.Enabled = True
        Else
            cmb_unidades.Enabled = False
        End If
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'COMPRUEBO QUE EXISTA ALGUN TEST ESCOGIDO PARA GUARDAR LOS RESULTADOS
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If Trim(lbl_pedidoD.Text = "" Or lbl_test.Text = "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("No ha ningún Test seleccionado", MsgBoxStyle.Exclamation, "LUMINO")
            Exit Sub
        End If
        Dim str_resultado As String
        Dim boo_res As Boolean = False
        str_resultado = ""
        'ARMO EN UN STRING LOS RESULTADOS 
        'str_resultado = ControlChars.CrLf & Trim(lbl_test_nombre.Text) & ControlChars.CrLf
        If (grp_general.Visible = True) Then
            If (Ctl_txt_numerico.Enabled = False And cmb_unidades.Enabled = False And txt_formula.Enabled = False And txt_ObsG.Enabled = False And cmb_cualitativo.Enabled = False) Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("No se puede procesar el resultado", MsgBoxStyle.Exclamation, "LUMINO")
                Exit Sub
            Else
                'GUARDO EN UN STRING LOS RESULTADOS
                'EMPIEZO CON EL RESULTADO NUMERICO Y SI TIENE, SUS UNIDADES

                If (Ctl_txt_numerico.Enabled = True And Ctl_txt_numerico.texto_Recupera <> "") Then
                    str_resultado = str_resultado & Ctl_txt_numerico.texto_Recupera & " "
                    'If cmb_unidades.Enabled = True Then
                    '   str_resultado = str_resultado & " " & cmb_unidades.Text & ControlChars.CrLf
                    'Else
                    'str_resultado = str_resultado & ControlChars.CrLf
                    'End If
                    boo_res = True
                End If
                'AGREGO AL STRING EL RESULTADO CUALITATIVO, EN CASO DE EXISTIR 
                If (cmb_cualitativo.Enabled = True) Then
                    str_resultado = str_resultado & cmb_cualitativo.Text & " "
                    boo_res = True
                End If
                'AGREGO AL STRING EL RESULTADO FORMULA, EN CASO DE EXISTIR 
                If (txt_formula.Enabled = True And txt_formula.Text <> "") Then
                    str_resultado = str_resultado & "Fórmula: " & txt_formula.Text & " "
                    boo_res = True
                End If
                'AGREGO AL STRING EL RESULTADO TIPO TEXTO, EN CASO DE EXISTIR 
                If (txt_ObsG.Enabled = True And txt_ObsG.Text <> "") Then
                    str_resultado = str_resultado & txt_ObsG.Text & " "
                    boo_res = True
                End If
            End If
            If (boo_res = False) Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("No ha ingresado ningún resultado," & ControlChars.CrLf & "no es posible Guardar", MsgBoxStyle.Exclamation, "LUMINO")
                Exit Sub
            End If
        End If  ' FIN CASO DE RESUL MANUALES EN GENERALES


        '*** EN CASO DE SER UN COPROPARASITARIO
        'Mod 10 Junio JPO

        If (pnl_coproanalisis.Visible = True) Then
            If (txt_colorC.Text = "" Or txt_consistencia.Text = "") Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("Debe ingresar el color y " & ControlChars.CrLf & "la consistencia de la muestra ", MsgBoxStyle.Exclamation, "LIS")
                Exit Sub
            Else
                'GUARDO EN UN STRING LOS RESULTADOS
                str_resultado = str_resultado & "COPROPARASITARIO: " & ControlChars.CrLf
                'EMPIEZO CON LOS RESULTADOS DEL COPROPARASITARIO
                str_resultado = str_resultado & "COLOR: " & txt_colorC.Text & ControlChars.CrLf & "CONSISTENCIA: " & txt_consistencia.Text & ControlChars.CrLf
                'CONSULTO SI EXISTEN DATOS EN PROTOZOOS
                If (chk_ameHis.Checked = True Or chk_AmeCol.Checked = True Or chk_Yodameba.Checked = True Or chk_EndNan.Checked = True Or chk_Enteromona.Checked = True Or chk_Embadomona.Checked = True Or chk_Chilomastix.Checked = True Or chk_GiaLam.Checked = True Or chk_TriHom.Checked = True Or chk_balCol.Checked = True) Then
                    boo_res = True 'Bandera en la que señalo que existen datos
                    str_resultado = str_resultado & "PROTOZOOS: " & ControlChars.CrLf
                    'AGREGO AL STRING EL RESULTADO ameba histolicitica, EN CASO DE EXISTIR 
                    If (chk_ameHis.Checked = True And (cmb_AmeHisQ.Text <> "" Or cmb_ameHisT.Text <> "")) Then
                        If cmb_AmeHisQ.Text <> "" Then
                            str_resultado = str_resultado & "AMEBA HISTOLITICA (Quistes):" & cmb_AmeHisQ.Text & ControlChars.CrLf
                        End If
                        If cmb_ameHisT.Text <> "" Then
                            str_resultado = str_resultado & "AMEBA HISTOLITICA (Trofozoitos):" & cmb_ameHisT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO AMEBA COLI, EN CASO DE EXISTIR 
                    If (chk_AmeCol.Checked = True And (cmb_ameColQ.Text <> "" Or cmb_ameColT.Text <> "")) Then
                        If cmb_ameColQ.Text <> "" Then
                            str_resultado = str_resultado & "AMEBA COLI (Quistes):" & cmb_ameColQ.Text & ControlChars.CrLf
                        End If
                        If cmb_ameColT.Text <> "" Then
                            str_resultado = str_resultado & "AMEBA COLI (Trofozoitos):" & cmb_ameColT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO YODAMEBA, EN CASO DE EXISTIR 
                    If (chk_Yodameba.Checked = True And (cmb_yodamebaQ.Text <> "" Or cmb_yodamebaT.Text <> "")) Then
                        If cmb_yodamebaQ.Text <> "" Then
                            str_resultado = str_resultado & "YODAMEBA (Quistes):" & cmb_yodamebaQ.Text & ControlChars.CrLf
                        End If
                        If cmb_yodamebaT.Text <> "" Then
                            str_resultado = str_resultado & "YODAMEBA (Trofozoitos):" & cmb_yodamebaT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO ENDOLIMAX NANA, EN CASO DE EXISTIR 
                    If (chk_EndNan.Checked = True And (cmb_endNanQ.Text <> "" Or cmb_endNanT.Text <> "")) Then
                        If cmb_endNanQ.Text <> "" Then
                            str_resultado = str_resultado & "ENDOLIMAX NANA (Quistes):" & cmb_endNanQ.Text & ControlChars.CrLf
                        End If
                        If cmb_endNanT.Text <> "" Then
                            str_resultado = str_resultado & "YODAMEBA (Trofozoitos):" & cmb_endNanT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO ENTEROMONA, EN CASO DE EXISTIR 
                    If (chk_Enteromona.Checked = True And (cmb_enteromaQ.Text <> "" Or cmb_enteromaT.Text <> "")) Then
                        If cmb_enteromaQ.Text <> "" Then
                            str_resultado = str_resultado & "ENTEROMONA (Quistes):" & cmb_enteromaQ.Text & ControlChars.CrLf
                        End If
                        If cmb_enteromaT.Text <> "" Then
                            str_resultado = str_resultado & "ENTEROMONA (Trofozoitos):" & cmb_enteromaT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO EMBADOMONA, EN CASO DE EXISTIR 
                    If (chk_Embadomona.Checked = True And (cmb_embadomaQ.Text <> "" Or cmb_embadomaT.Text <> "")) Then
                        If cmb_embadomaQ.Text <> "" Then
                            str_resultado = str_resultado & "EMBADOMONA (Quistes):" & cmb_embadomaQ.Text & ControlChars.CrLf
                        End If
                        If cmb_embadomaT.Text <> "" Then
                            str_resultado = str_resultado & "EMBADOMONA (Trofozoitos):" & cmb_embadomaT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO CHILOMASTIX, EN CASO DE EXISTIR 
                    If (chk_Chilomastix.Checked = True And (cmb_chilomastixQ.Text <> "" Or cmb_chilomastixT.Text <> "")) Then
                        If cmb_chilomastixQ.Text <> "" Then
                            str_resultado = str_resultado & "CHILOMASTIX (Quistes):" & cmb_chilomastixQ.Text & ControlChars.CrLf
                        End If
                        If cmb_chilomastixT.Text <> "" Then
                            str_resultado = str_resultado & "CHILOMASTIX (Trofozoitos):" & cmb_chilomastixT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO GIARDIA LAMBLIA, EN CASO DE EXISTIR 
                    If (chk_GiaLam.Checked = True And (cmb_GiaLamQ.Text <> "" Or cmb_GiaLamT.Text <> "")) Then
                        If cmb_GiaLamQ.Text <> "" Then
                            str_resultado = str_resultado & "GIARDIA LAMBLIA (Quistes):" & cmb_GiaLamQ.Text & ControlChars.CrLf
                        End If
                        If cmb_GiaLamT.Text <> "" Then
                            str_resultado = str_resultado & "GIARDIA LAMBLIA (Trofozoitos):" & cmb_GiaLamT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO TRICHOMONA HOMINIS, EN CASO DE EXISTIR 
                    If (chk_TriHom.Checked = True And (cmb_TriHomQ.Text <> "" Or cmb_TriHomT.Text <> "")) Then
                        If cmb_TriHomQ.Text <> "" Then
                            str_resultado = str_resultado & "TRICHOMONA HOMINIS (Quistes):" & cmb_TriHomQ.Text & ControlChars.CrLf
                        End If
                        If cmb_TriHomT.Text <> "" Then
                            str_resultado = str_resultado & "TRICHOMONA HOMINIS (Trofozoitos):" & cmb_TriHomT.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO BALANTIDIUM COLI, EN CASO DE EXISTIR 
                    If (chk_balCol.Checked = True And (cmb_BalColQ.Text <> "" Or cmb_BalColT.Text <> "")) Then
                        If cmb_BalColQ.Text <> "" Then
                            str_resultado = str_resultado & "BALANTIDIUM COLI (Quistes):" & cmb_BalColQ.Text & ControlChars.CrLf
                        End If
                        If cmb_BalColT.Text <> "" Then
                            str_resultado = str_resultado & "BALANTIDIUM COLI (Trofozoitos):" & cmb_BalColT.Text & ControlChars.CrLf
                        End If
                    End If
                End If
                'CONSULTO SI EXISTEN DATOS EN HELMINTOS
                If (chk_tricocefalo.Checked = True Or chk_AscLum.Checked = True Or chk_uncinarias.Checked = True Or chk_oxiuros.Checked = True Or chk_Estrongiloides.Checked = True Or chk_TenSol.Checked = True Or chk_HimNana.Checked = True Or chk_HimDim.Checked = True) Then
                    boo_res = True 'Bandera en la que señalo que existen datos
                    str_resultado = str_resultado & "HELMINTOS: " & ControlChars.CrLf
                    'AGREGO AL STRING EL RESULTADO TRICOCEFALO, EN CASO DE EXISTIR 
                    If (chk_tricocefalo.Checked = True And (cmb_tricocefaloH.Text <> "" Or cmb_tricocefaloL.Text <> "")) Then
                        If cmb_tricocefaloH.Text <> "" Then
                            str_resultado = str_resultado & "TRICOCEFALO (Huevos):" & cmb_tricocefaloH.Text & ControlChars.CrLf
                        End If
                        If cmb_tricocefaloL.Text <> "" Then
                            str_resultado = str_resultado & "TRICOCEFALO (Larvas):" & cmb_tricocefaloL.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO ASCARIS LUMBRICOIDES, EN CASO DE EXISTIR 
                    If (chk_AscLum.Checked = True And (cmb_ascLumH.Text <> "" Or cmb_ascLumL.Text <> "")) Then
                        If cmb_ascLumH.Text <> "" Then
                            str_resultado = str_resultado & "ASCARIS LUMBRICOIDES (Huevos):" & cmb_ascLumH.Text & ControlChars.CrLf
                        End If
                        If cmb_ascLumL.Text <> "" Then
                            str_resultado = str_resultado & "ASCARIS LUMBRICOIDES (Larvas):" & cmb_ascLumL.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO UNCINARIAS, EN CASO DE EXISTIR 
                    If (chk_uncinarias.Checked = True And (cmb_uncinariasH.Text <> "" Or cmb_uncinariasL.Text <> "")) Then
                        If cmb_uncinariasH.Text <> "" Then
                            str_resultado = str_resultado & "UNCINARIAS (Huevos):" & cmb_uncinariasH.Text & ControlChars.CrLf
                        End If
                        If cmb_uncinariasL.Text <> "" Then
                            str_resultado = str_resultado & "UNCINARIAS (Larvas):" & cmb_uncinariasL.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO OXIUROS, EN CASO DE EXISTIR 
                    If (chk_oxiuros.Checked = True And (cmb_OxiurosH.Text <> "" Or cmb_oxiurosL.Text <> "")) Then
                        If cmb_OxiurosH.Text <> "" Then
                            str_resultado = str_resultado & "OXIUROS (Huevos):" & cmb_OxiurosH.Text & ControlChars.CrLf
                        End If
                        If cmb_oxiurosL.Text <> "" Then
                            str_resultado = str_resultado & "OXIUROS (Larvas):" & cmb_oxiurosL.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO ESTRONGILOIDES, EN CASO DE EXISTIR 
                    If (chk_oxiuros.Checked = True And (cmb_OxiurosH.Text <> "" Or cmb_oxiurosL.Text <> "")) Then
                        If cmb_estrongiloidesH.Text <> "" Then
                            str_resultado = str_resultado & "ESTRONGILOIDES (Huevos):" & cmb_estrongiloidesH.Text & ControlChars.CrLf
                        End If
                        If cmb_estrongiloidesL.Text <> "" Then
                            str_resultado = str_resultado & "ESTRONGILOIDES (Larvas):" & cmb_estrongiloidesL.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO TENIA SOLIUM, EN CASO DE EXISTIR 
                    If (chk_TenSol.Checked = True And (cmb_tenSolH.Text <> "" Or cmb_tenSolL.Text <> "")) Then
                        If cmb_tenSolH.Text <> "" Then
                            str_resultado = str_resultado & "TENIA SOLIUM (Huevos):" & cmb_tenSolH.Text & ControlChars.CrLf
                        End If
                        If cmb_tenSolL.Text <> "" Then
                            str_resultado = str_resultado & "TENIA SOLIUM (Larvas):" & cmb_tenSolL.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO HIM. NANA, EN CASO DE EXISTIR 
                    If (chk_HimNana.Checked = True And (cmb_HimNanH.Text <> "" Or cmb_HimNanL.Text <> "")) Then
                        If cmb_HimNanH.Text <> "" Then
                            str_resultado = str_resultado & "HIM. NANA (Huevos):" & cmb_HimNanH.Text & ControlChars.CrLf
                        End If
                        If cmb_HimNanL.Text <> "" Then
                            str_resultado = str_resultado & "HIM. NANA (Larvas):" & cmb_HimNanL.Text & ControlChars.CrLf
                        End If
                    End If
                    'AGREGO AL STRING EL RESULTADO HIM. DIMINUTA, EN CASO DE EXISTIR 
                    If (chk_HimDim.Checked = True And (cmb_HimDimH.Text <> "" Or cmb_HimDimL.Text <> "")) Then
                        If cmb_HimDimH.Text <> "" Then
                            str_resultado = str_resultado & "HIM. DIMINUTA (Huevos):" & cmb_HimDimH.Text & ControlChars.CrLf
                        End If
                        If cmb_HimDimL.Text <> "" Then
                            str_resultado = str_resultado & "HIM. DIMINUTA (Larvas):" & cmb_HimDimL.Text & ControlChars.CrLf
                        End If
                    End If
                End If

                'CONSULTO SI EXISTEN DATOS EN COPROLOGICO
                If (chk_hematiesC.Checked = True Or chk_PiocitosC.Checked = True Or chk_CelulasC.Checked = True Or chk_MocoC.Checked = True Or chk_PMN.Checked = True Or chk_SanOcu.Checked = True Or chk_ResVeg.Checked = True Or chk_Almidones.Checked = True Or chk_Grasas.Checked = True Or chk_Levaduras.Checked = True Or chk_Hongos.Checked = True Or chk_BlaHom.Checked = True) Then
                    boo_res = True 'Bandera en la que señalo que existen datos
                    str_resultado = str_resultado & "COPROLOGICO: " & ControlChars.CrLf
                    'AGREGO AL STRING EL RESULTADO HEMATIES, EN CASO DE EXISTIR 
                    If (chk_hematiesC.Checked = True And (txt_hematiesC.Text <> "")) Then
                        str_resultado = str_resultado & "HEMATIES :" & txt_hematiesC.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO PIOCITOS, EN CASO DE EXISTIR 
                    If (chk_PiocitosC.Checked = True And (txt_piocitosC.Text <> "")) Then
                        str_resultado = str_resultado & "PIOCITOS :" & txt_piocitosC.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO CELULAS, EN CASO DE EXISTIR 
                    If (chk_CelulasC.Checked = True And (txt_celulasC.Text <> "")) Then
                        str_resultado = str_resultado & "CELULAS :" & txt_celulasC.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO MOCO, EN CASO DE EXISTIR 
                    If (chk_MocoC.Checked = True And (cmb_moco.Text <> "")) Then
                        str_resultado = str_resultado & "MOCO :" & cmb_moco.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO POLIMORFONUCLEARES, EN CASO DE EXISTIR 
                    If (chk_PMN.Checked = True And (txt_PMN.Text <> "")) Then
                        str_resultado = str_resultado & "POLIMORFONUCLEARES :" & txt_PMN.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO SANGRE OCULTA, EN CASO DE EXISTIR 
                    If (chk_SanOcu.Checked = True And (cmb_SanOcu.Text <> "")) Then
                        str_resultado = str_resultado & "SANGRE OCULTA :" & cmb_SanOcu.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO RESTOS VEGETALES, EN CASO DE EXISTIR 
                    If (chk_ResVeg.Checked = True And (cmb_resVeg.Text <> "")) Then
                        str_resultado = str_resultado & "RESTOS VEGETALES :" & cmb_resVeg.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO ALMIDONES, EN CASO DE EXISTIR 
                    If (chk_Almidones.Checked = True And (cmb_almidones.Text <> "")) Then
                        str_resultado = str_resultado & "ALMIDONES :" & cmb_almidones.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO GRASAS, EN CASO DE EXISTIR 
                    If (chk_Grasas.Checked = True And (cmb_grasas.Text <> "")) Then
                        str_resultado = str_resultado & "GRASAS :" & cmb_grasas.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO LEVADURAS, EN CASO DE EXISTIR 
                    If (chk_Levaduras.Checked = True And (cmb_levaduras.Text <> "")) Then
                        str_resultado = str_resultado & "LEVADURAS :" & cmb_levaduras.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO HONGOS, EN CASO DE EXISTIR 
                    If (chk_Hongos.Checked = True And (cmb_Hongos.Text <> "")) Then
                        str_resultado = str_resultado & "HONGOS :" & cmb_Hongos.Text & ControlChars.CrLf
                    End If
                    'AGREGO AL STRING EL RESULTADO BLASTOCISTIS HOMINIS, EN CASO DE EXISTIR 
                    If (chk_BlaHom.Checked = True And (cmb_blaHom.Text <> "")) Then
                        str_resultado = str_resultado & "BLASTOCISTIS HOMINIS :" & cmb_blaHom.Text & ControlChars.CrLf
                    End If
                End If
                'AGREGO AL STRING OTRAS OBSERVACIONES, EN CASO DE EXISTIR 
                If (chk_obsC.Checked = True And txt_obsc.Text <> "") Then
                    str_resultado = str_resultado & "OBSERVACIONES: " & txt_obsc.Text & ControlChars.CrLf
                End If
            End If
            If (boo_res = False) Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("No ha ingresado ningún resultado," & ControlChars.CrLf & "no es posible Guardar", MsgBoxStyle.Exclamation, "LUMINO")
                Exit Sub
            End If
        End If ' FIN CASO DE COPRO

        '*** EN CASO DE SER UN EMO
        If (grp_uroanalisis.Visible = True) Then
            If (txt_color.Text = "" Or txt_aspecto.Text = "" And txt_densidad.Text = "" And txt_PH.Text = "") Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("Se requiere ingresar los resultados del" & ControlChars.CrLf & "análisis elemental(Color, Aspecto, Densidad o PH).", MsgBoxStyle.Exclamation, "LUMINO")
                Exit Sub
            Else
                'GUARDO EN UN STRING LOS RESULTADOS

                'EMPIEZO CON LOS RESULTADOS DEL ANALISIS ELEMENTAL 
                str_resultado = str_resultado & "ANALISIS ELEMENTAL: " & ControlChars.CrLf
                'str_resultado = str_resultado & "Examen Fisico: " & ControlChars.CrLf
                str_resultado = str_resultado & "COLOR: " & txt_color.Text & ControlChars.CrLf & "ASPECTO: " & txt_aspecto.Text & ControlChars.CrLf & "DENSIDAD: " & txt_densidad.texto_Recupera & ControlChars.CrLf & "PH: " & txt_PH.texto_Recupera & ControlChars.CrLf
                boo_res = True
                '***AGREGO OTROS RESULTADOS DEL ANALISIS ELEMENTAL

                'AGREGO AL STRING EL RESULTADO LEUCOCITOS.
                If (chk_leucocitos.Checked = True And txt_leucocitos.Text <> "") Then
                    str_resultado = str_resultado & "LEUCOCITOS: " & txt_leucocitos.Text & "  leuc./uL" & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "LEUCOCITOS: NEGATIVO" & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO PROTEINAS
                If (chk_proteinas.Checked = True And txt_proteinas.Text <> "") Then
                    str_resultado = str_resultado & "PROTEINAS: " & txt_proteinas.Text & "  mg/dL" & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "PROTEINAS: NEGATIVO" & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO DE GLUCOSA
                If (chk_glucosas.Checked = True And txt_glucosa.Text <> "") Then
                    str_resultado = str_resultado & "GLUCOSA: " & txt_glucosa.Text & "  mg/dL" & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "GLUCOSA: NEGATIVO" & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO DE CETONAS
                If (chk_cetonas.Checked = True And txt_cetonas.Text <> "") Then
                    str_resultado = str_resultado & "CETONAS: " & txt_cetonas.Text & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "CETONAS: NEGATIVO" & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO DE HEMOGLOBINA 
                If (chk_hemoglobina.Checked = True And txt_hemoglobina.Text <> "") Then
                    str_resultado = str_resultado & "HEMOGLOBINA: " & txt_hemoglobina.Text & " erit./uL" & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "HEMOGLOBINA: NEGATIVO" & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO DE BILIRRUBINAS
                If (chk_bilirrubinas.Checked = True And txt_bilirrubinas.Text <> "") Then
                    str_resultado = str_resultado & "BILIRRUBINA: " & txt_bilirrubinas.Text & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "BILIRRUBINA: NEGATIVO" & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO DE UROBILINOGENO
                If (chk_urobilinog.Checked = True And txt_urobilinog.Text <> "") Then
                    str_resultado = str_resultado & "UROBILINOGENO: " & txt_urobilinog.Text & " mg/dL" & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "UROBILINOGENO: NORMAL" & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO NITRITOS.
                If (chk_nitritos.Checked = True And txt_nitritos.Text <> "") Then
                    str_resultado = str_resultado & "NITRITOS: POSITIVO" & ControlChars.CrLf
                Else
                    str_resultado = str_resultado & "NITRITOS: NEGATIVO" & ControlChars.CrLf
                End If
                'GUARDO LOS RESULTADOS DEL ANALISIS MICROSCOPICO
                str_resultado = str_resultado & "ANALISIS MICROSCOPICO: " & ControlChars.CrLf
                'AGREGO AL STRING RESULTADOS DE HEMATIES
                If (chk_hematies.Checked = True And txt_hematies.Text <> "") Then
                    str_resultado = str_resultado & "HEMATIES: " & txt_hematies.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE LEUCOCITOS/CAMPO
                If (chk_leucocitosc.Checked = True And txt_leucocitosc.Text <> "") Then
                    str_resultado = str_resultado & "LEUCOCITOS/CAMPO: " & txt_leucocitosc.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CELULAS/CAMPO
                If (chk_celulas.Checked = True And txt_celulas.Text <> "") Then
                    str_resultado = str_resultado & "CELULAS/CAMPO: " & txt_celulas.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CILINDROS
                If (chk_cilindros.Checked = True And txt_cilindros.Text <> "") Then
                    str_resultado = str_resultado & "CILINDROS: " & txt_cilindros.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CILINDROS HIALINOS
                If (chk_cHialinos.Checked = True And txt_chialinos.Text <> "") Then
                    str_resultado = str_resultado & "CILINDROS HIALINOS: " & txt_chialinos.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CILINDROS HEMETICOS
                If (chk_chemeticos.Checked = True And txt_chemeticos.Text <> "") Then
                    str_resultado = str_resultado & "CILINDROS HEMETICOS: " & txt_chemeticos.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CILINDROS GRANULOSOS
                If (chk_cgranulosos.Checked = True And txt_cgranulosos.Text <> "") Then
                    str_resultado = str_resultado & "CILINDROS GRANULOSOS: " & txt_cgranulosos.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CILINDROS LEUCOCITARIOS
                If (chk_cleucocitarios.Checked = True And txt_cleucocitarios.Text <> "") Then
                    str_resultado = str_resultado & "CILINDROS LEUCOCITARIOS: " & txt_cleucocitarios.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CILINDROS CEREOS
                If (chk_ccereos.Checked = True And txt_ccereos.Text <> "") Then
                    str_resultado = str_resultado & "CILINDROS CEREOS: " & txt_ccereos.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE MOCO
                If (chk_moco.Checked = True And txt_moco.Text <> "") Then
                    str_resultado = str_resultado & "MOCO: " & txt_moco.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE ESPERMATOZOIDES
                If (chk_espermatozoides.Checked = True And txt_espermatozoides.Text <> "") Then
                    str_resultado = str_resultado & "ESPERMATOZOIDES: " & txt_espermatozoides.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO DE BACTERIAS
                If (chk_bacterias.Checked = True And txt_bacterias.Text <> "") Then
                    str_resultado = str_resultado & "BACTERIAS: " & txt_bacterias.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE PIOCITOS
                If (chk_piocitos.Checked = True And txt_piocitos.Text <> "") Then
                    str_resultado = str_resultado & "PIOCITOS: " & txt_piocitos.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE URATOS AMORFOS
                If (chk_uratosA.Checked = True And txt_uratosA.Text <> "") Then
                    str_resultado = str_resultado & "URATOS AMORFOS: " & txt_uratosA.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE FOSFATOS AMORFOS
                If (chk_fosfatosA.Checked = True And txt_fosfatosA.Text <> "") Then
                    str_resultado = str_resultado & "FOSFATOS AMORFOS: " & txt_fosfatosA.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE OXALATO DE AMONIO
                If (chk_oxalatoAmo.Checked = True And txt_oxalatoamo.Text <> "") Then
                    str_resultado = str_resultado & "OXALATO DE AMONIO: " & txt_oxalatoamo.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING EL RESULTADO DE CRISTALES DE AMONIO
                If (chk_cristalesAmo.Checked = True And txt_cristalesAmo.Text <> "") Then
                    str_resultado = str_resultado & "CRISTALES DE AMONIO: " & txt_cristalesAmo.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE OXALATO DE CALCIO
                If (chk_oxalatoCal.Checked = True And txt_oxalatoCal.Text <> "") Then
                    str_resultado = str_resultado & "OXALATO DE CALCIO: " & txt_oxalatoCal.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE FOSFATO TRIPLE
                If (chk_fosfatoTri.Checked = True And txt_fosfatoTri.Text <> "") Then
                    str_resultado = str_resultado & "FOSFATO TRIPLE: " & txt_fosfatoTri.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE URATO AMONICO
                If (chk_uratoAmo.Checked = True And txt_uratoamo.Text <> "") Then
                    str_resultado = str_resultado & "URATO AMONICO: " & txt_uratoamo.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CRISTALES ACIDO URICO
                If (chk_crisAciUri.Checked = True And txt_crisAciUri.Text <> "") Then
                    str_resultado = str_resultado & "CRISTALES ACIDO URICO: " & txt_crisAciUri.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING RESULTADOS DE CELULAS REDONDAS
                If (chk_celulasRed.Checked = True And txt_celulasRed.Text <> "") Then
                    str_resultado = str_resultado & "CELULAS REDONDAS: " & txt_celulasRed.Text & ControlChars.CrLf
                End If
                'AGREGO AL STRING DE OBSERV. DE LA PRUEBA , EN CASO DE EXISTIR 
                If (chk_Obs2.Checked = True And txt_obs2.Text <> "") Then
                    str_resultado = str_resultado & "OBSERVACIONES:" & txt_obs2.Text & ControlChars.CrLf
                End If
            End If
            If (boo_res = False) Then
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox("No ha ingresado ningún resultado," & ControlChars.CrLf & "no es posible Guardar", MsgBoxStyle.Exclamation, "LUMINO")
                Exit Sub
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        End If

        'Guardar los resultados en la tabla lista_trabajo y actualizar el estado a PROCESADO
        opr_trabajo.Actu_Test_Trabajo(CInt(lbl_pedidoD.Text), CInt(lbl_test.Text), str_resultado)
        MsgBox("Resultados manuales almacenados", MsgBoxStyle.Information, "LUMINO")
        opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), CInt(lbl_test.Text), 1)
        If (grp_general.Visible = True) Then
            Call Limpiar_Grp_G()
            grp_general.Visible = False
        End If
        If (pnl_coproanalisis.Visible = True) Then
            Call Limpiar_grp_Copro()
            pnl_coproanalisis.Visible = False
        End If
        If (grp_uroanalisis.Visible = True) Then
            Call Limpiar_grp_Uro()
            grp_uroanalisis.Visible = False
        End If
        lbl_pedidoD.Text = ""
        lbl_pacD.Text = ""
        lbl_test_nombre.Text = ""
        lbl_fecha.Text = ""
        lbl_test.Text = ""
        lbl_fecnacd.Text = ""
        lbl_edad.Text = ""
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub Limpiar_Grp_G()
        Ctl_txt_numerico.Enabled = True
        Ctl_txt_numerico.txt_padre.MaxLength = 10
        Ctl_txt_numerico.texto_Asigna("")
        Ctl_txt_numerico.Enabled = False
        cmb_unidades.Enabled = True
        ' cmb_unidades.SelectedIndex = 0
        cmb_unidades.Enabled = False
        chk_unidades.Checked = False
        cmb_cualitativo.SelectedIndex = 1
        txt_formula.Text = ""
        txt_formula.Enabled = False
        txt_ObsG.Text = ""
        txt_ObsG.Enabled = False
    End Sub
    Private Sub Limpiar_grp_Copro()
        txt_colorC.Text = ""
        txt_consistencia.Text = ""
        cmb_AmeHisQ.Text = ""
        cmb_ameHisT.Text = ""
        chk_ameHis.Checked = False
        cmb_AmeHisQ.Enabled = False
        cmb_ameHisT.Enabled = False
        cmb_ameColQ.Text = ""
        cmb_ameColT.Text = ""
        chk_AmeCol.Checked = False
        cmb_ameColQ.Enabled = False
        cmb_ameColT.Enabled = False
        cmb_yodamebaQ.Text = ""
        cmb_yodamebaT.Text = ""
        chk_Yodameba.Checked = False
        cmb_yodamebaQ.Enabled = False
        cmb_yodamebaT.Enabled = False
        cmb_endNanQ.Text = ""
        cmb_endNanT.Text = ""
        chk_EndNan.Checked = False
        cmb_endNanQ.Enabled = False
        cmb_endNanT.Enabled = False
        cmb_enteromaQ.Text = ""
        cmb_enteromaT.Text = ""
        chk_Enteromona.Checked = False
        cmb_enteromaQ.Enabled = False
        cmb_enteromaT.Enabled = False
        cmb_embadomaQ.Text = ""
        cmb_embadomaT.Text = ""
        chk_Embadomona.Checked = False
        cmb_embadomaQ.Enabled = False
        cmb_embadomaT.Enabled = False
        cmb_chilomastixQ.Text = ""
        cmb_chilomastixT.Text = ""
        chk_Chilomastix.Checked = False
        cmb_chilomastixQ.Enabled = False
        cmb_chilomastixT.Enabled = False
        cmb_GiaLamQ.Text = ""
        cmb_GiaLamT.Text = ""
        chk_GiaLam.Checked = False
        cmb_GiaLamQ.Enabled = False
        cmb_GiaLamT.Enabled = False
        cmb_TriHomQ.Text = ""
        cmb_TriHomT.Text = ""
        chk_TriHom.Checked = False
        cmb_TriHomQ.Enabled = False
        cmb_TriHomT.Enabled = False
        cmb_BalColQ.Text = ""
        cmb_BalColT.Text = ""
        chk_balCol.Checked = False
        cmb_BalColQ.Enabled = False
        cmb_BalColT.Enabled = False
        cmb_tricocefaloH.Text = ""
        cmb_tricocefaloL.Text = ""
        chk_tricocefalo.Checked = False
        cmb_tricocefaloH.Enabled = False
        cmb_tricocefaloL.Enabled = False
        cmb_ascLumH.Text = ""
        cmb_ascLumL.Text = ""
        chk_AscLum.Checked = False
        cmb_ascLumH.Enabled = False
        cmb_ascLumL.Enabled = False
        cmb_uncinariasH.Text = ""
        cmb_uncinariasL.Text = ""
        chk_uncinarias.Checked = False
        cmb_uncinariasH.Enabled = False
        cmb_uncinariasL.Enabled = False

        cmb_OxiurosH.Text = ""
        cmb_oxiurosL.Text = ""
        chk_oxiuros.Checked = False
        cmb_OxiurosH.Enabled = False
        cmb_oxiurosL.Enabled = False

        cmb_estrongiloidesH.Text = ""
        cmb_estrongiloidesL.Text = ""
        chk_Estrongiloides.Checked = False
        cmb_estrongiloidesH.Enabled = False
        cmb_estrongiloidesL.Enabled = False

        cmb_tenSolH.Text = ""
        cmb_tenSolL.Text = ""
        chk_TenSol.Checked = False
        cmb_tenSolH.Enabled = False
        cmb_tenSolL.Enabled = False

        cmb_HimNanH.Text = ""
        cmb_HimNanL.Text = ""
        chk_HimNana.Checked = False
        cmb_HimNanH.Enabled = False
        cmb_HimNanL.Enabled = False

        cmb_HimDimH.Text = ""
        cmb_HimDimL.Text = ""
        chk_HimDim.Checked = False
        cmb_HimDimH.Enabled = False
        cmb_HimDimL.Enabled = False

        txt_hematiesC.Text = "escasos"
        chk_hematiesC.Checked = False

        txt_piocitosC.Text = "escasos"
        chk_PiocitosC.Checked = False

        txt_celulasC.Text = "escasas"
        chk_CelulasC.Checked = False

        cmb_moco.Text = "escaso"
        chk_MocoC.Checked = False

        txt_PMN.texto_Asigna("")
        chk_PMN.Checked = False

        cmb_SanOcu.Text = "negativo"
        chk_SanOcu.Checked = False

        cmb_resVeg.Text = "escasos"
        chk_ResVeg.Checked = False

        cmb_almidones.Text = "escasos"
        chk_Almidones.Checked = False

        cmb_grasas.Text = "escasas"
        chk_Grasas.Checked = False

        cmb_levaduras.Text = "escasas"
        chk_Levaduras.Checked = False

        cmb_Hongos.Text = "escasos"
        chk_Hongos.Checked = False

        cmb_blaHom.Text = "escasas"
        chk_BlaHom.Checked = False

        chk_obsC.Checked = False
        txt_obsc.Text = ""
    End Sub
    Private Sub Limpiar_grp_Uro()
        txt_densidad.txt_padre.MaxLength = 8
        txt_PH.txt_padre.MaxLength = 8
        txt_color.Text = ""
        txt_aspecto.Text = ""
        txt_densidad.texto_Asigna("")
        txt_PH.texto_Asigna("")
        chk_leucocitos.Checked = False
        txt_leucocitos.Text = ""
        chk_proteinas.Checked = False
        txt_proteinas.Text = ""
        chk_glucosas.Checked = False
        txt_glucosa.Text = ""
        chk_cetonas.Checked = False
        txt_cetonas.Text = ""
        chk_hemoglobina.Checked = False
        txt_hemoglobina.Text = ""
        chk_bilirrubinas.Checked = False
        txt_bilirrubinas.Text = ""
        chk_urobilinog.Checked = False
        txt_urobilinog.Text = ""
        chk_nitritos.Checked = False
        txt_nitritos.Text = ""
        chk_hematies.Checked = False
        txt_hematies.Text = ""
        chk_leucocitosc.Checked = False
        txt_leucocitosc.Text = ""
        chk_celulas.Checked = False
        txt_celulas.Text = ""
        chk_cilindros.Checked = False
        txt_cilindros.Text = ""
        chk_cHialinos.Checked = False
        txt_chialinos.Text = ""
        chk_chemeticos.Checked = False
        txt_chemeticos.Text = ""
        chk_cgranulosos.Checked = False
        txt_cgranulosos.Text = ""
        chk_cleucocitarios.Checked = False
        txt_cleucocitarios.Text = ""
        chk_ccereos.Checked = False
        txt_ccereos.Text = ""
        chk_moco.Checked = False
        txt_moco.Text = ""
        chk_espermatozoides.Checked = False
        txt_espermatozoides.Text = ""
        chk_bacterias.Checked = False
        txt_bacterias.Text = ""
        chk_piocitos.Checked = False
        txt_piocitos.Text = ""
        chk_uratosA.Checked = False
        txt_uratosA.Text = ""
        chk_fosfatosA.Checked = False
        txt_fosfatosA.Text = ""
        chk_oxalatoAmo.Checked = False
        txt_oxalatoamo.Text = ""
        chk_cristalesAmo.Checked = False
        txt_cristalesAmo.Text = ""
        chk_oxalatoCal.Checked = False
        txt_oxalatoCal.Text = ""
        chk_fosfatoTri.Checked = False
        txt_fosfatoTri.Text = ""
        chk_uratoAmo.Checked = False
        txt_uratoamo.Text = ""
        chk_crisAciUri.Checked = False
        txt_crisAciUri.Text = ""
        chk_celulasRed.Checked = False
        txt_celulasRed.Text = ""
        'txt_levaduras.Text = ""
        chk_Obs2.Checked = False
        txt_obs2.Text = ""
    End Sub

    Private Sub chk_leucocitos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_leucocitos.CheckedChanged
        If (chk_leucocitos.Checked = True) Then
            txt_leucocitos.Text = ""
            txt_leucocitos.ReadOnly = False
            txt_leucocitos.Focus()
        Else
            txt_leucocitos.Text = "NEGATIVO"
            txt_leucocitos.ReadOnly = True
        End If
    End Sub

    Private Sub chk_hemoglobina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_hemoglobina.CheckedChanged
        If (chk_hemoglobina.Checked = True) Then
            txt_hemoglobina.Text = ""
            txt_hemoglobina.ReadOnly = False
            txt_hemoglobina.Focus()
        Else
            txt_hemoglobina.Text = "NEGATIVO"
            txt_hemoglobina.ReadOnly = True
        End If
    End Sub

    Private Sub chk_hematies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_hematies.CheckedChanged
        If (chk_hematies.Checked = True) Then
            txt_hematies.Text = ""
            txt_hematies.ReadOnly = False
            txt_hematies.Focus()
        Else
            txt_hematies.Text = "NEGATIVO"
            txt_hematies.ReadOnly = True
        End If
    End Sub

    Private Sub chk_cristalesAmo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cristalesAmo.CheckedChanged
        If (chk_cristalesAmo.Checked = True) Then
            txt_cristalesAmo.ReadOnly = False
            txt_cristalesAmo.Text = ""
            txt_cristalesAmo.Focus()
        Else
            txt_cristalesAmo.Text = "NEGATIVO"
            txt_cristalesAmo.ReadOnly = True
        End If
    End Sub

    Private Sub chk_cilindros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cilindros.CheckedChanged
        If (chk_cilindros.Checked = True) Then
            txt_cilindros.ReadOnly = False
            txt_cilindros.Text = ""
            txt_cilindros.Focus()
        Else
            txt_cilindros.Text = "NEGATIVO"
            txt_cilindros.ReadOnly = True
        End If
    End Sub

    Private Sub chk_levadurasU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_levadurasU.CheckedChanged
        If (chk_levadurasU.Checked = True) Then
            cmb_levaduras.Enabled = True
            cmb_levaduras.Text = "escasas"
            cmb_levaduras.Focus()
        Else
            cmb_levaduras.Text = "escasas"
            cmb_levaduras.Enabled = False
        End If
    End Sub

    Private Sub chk_coproparasitario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (chk_coproparasitario.Checked = True) Then
        '    txt_coproparasitario.Text = ""
        '    txt_coproparasitario.ReadOnly = False
        '    txt_coproparasitario.Focus()
        'Else
        '    txt_coproparasitario.Text = "NEGATIVO"
        '    txt_coproparasitario.ReadOnly = True
        'End If
    End Sub

    Private Sub chk_coprodigestivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (chk_coprodigestivo.Checked = True) Then
        '    txt_coprodigestivo.Text = ""
        '    txt_coprodigestivo.ReadOnly = False
        '    txt_coprodigestivo.Focus()
        'Else
        '    txt_coprodigestivo.Text = "NORMAL"
        '    txt_coprodigestivo.ReadOnly = True
        'End If
    End Sub

    Private Sub chk_coprologico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (chk_coprologico.Checked = True) Then
        '    txt_coprologico.Text = ""
        '    txt_coprologico.ReadOnly = False
        '    txt_coprologico.Focus()
        'Else
        '    txt_coprologico.Text = "NORMAL"
        '    txt_coprologico.ReadOnly = True
        'End If
    End Sub

    Private Sub chk_coprobacteriano_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (chk_coprobacteriano.Checked = True) Then
        '    txt_coprobacteriano.Text = ""
        '    txt_coprobacteriano.ReadOnly = False
        '    txt_coprobacteriano.Focus()
        'Else
        '    txt_coprobacteriano.Text = "NORMAL"
        '    txt_coprobacteriano.ReadOnly = True
        'End If
    End Sub



    Private Sub lbl_fecnacd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_fecnacd.TextChanged
        If (IsDate(lbl_fecnacd.Text)) Then
            Dim fn As Date = CDate(lbl_fecnacd.Text)
            Dim diaP As Short = fn.Day
            Dim mesP As Short = fn.Month
            Dim añoP As Short = fn.Year

            Dim diaH As Short = Today.Day
            Dim mesH As Short = Today.Month
            Dim añoH As Short = Today.Year

            Dim diae As Short = 0
            Dim mese As Short = 0
            Dim añoe As Short = 0
            'DIAS
            If (diaH - diaP) > 0 Then
                diae = diaH - diaP
            Else
                diaH = diaH + 30
                mesH = (mesH - 1)
                diae = diaH - diaP
            End If
            'MESES
            If (mesH - mesP) > 0 Then
                mese = mesH - mesP
            Else
                mesH = mesH + 12
                añoH = (añoH - 1)
                mese = mesH - mesP
            End If
            'AÑOS
            If (añoH - añoP) > 0 Then
                añoe = añoH - añoP
            End If
            lbl_edad.Text = añoe & " años y " & mese & " meses"
        Else
            lbl_edad.Text = ""
        End If
    End Sub

    Private Sub lbl_pedidoD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_pedidoD.TextChanged
        If (lbl_pedidoD.Text <> "") Then
            btn_ObsPac.Enabled = True
        Else
            btn_ObsPac.Enabled = False
        End If
    End Sub

    Private Sub btn_ObsPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ObsPac.Click
        If (str_antecedentes = "" And str_medicamentos = "" And str_obs = "") Then
            MsgBox("No hay datos ingresados", MsgBoxStyle.Information, "LUMINO - Observaciones sobre el paciente")
        Else
            MsgBox("Observaciones:" & Chr(13) & str_obs & Chr(13) & Chr(13) & "Antecedentes:" & Chr(13) & str_antecedentes & Chr(13) & Chr(13) & "Medicación: " & Chr(13) & str_medicamentos, MsgBoxStyle.Information, "LUMINO - Información del paciente")
        End If
    End Sub

    Private Sub chk_leucocitosc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_leucocitosc.CheckedChanged
        If chk_leucocitosc.Checked = True Then
            txt_leucocitosc.ReadOnly = False
            txt_leucocitosc.Text = ""
            txt_leucocitosc.Focus()
        Else
            txt_leucocitosc.Text = "NEGATIVO"
            txt_leucocitosc.ReadOnly = True
        End If
    End Sub

    Private Sub chk_cHialinos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cHialinos.CheckedChanged
        If chk_cHialinos.Checked = True Then
            txt_chialinos.ReadOnly = False
            txt_chialinos.Text = ""
            txt_chialinos.Focus()
        Else
            txt_chialinos.Text = "NEGATIVO"
            txt_chialinos.ReadOnly = True
        End If
    End Sub

    Private Sub chk_chemeticos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_chemeticos.CheckedChanged
        If chk_chemeticos.Checked = True Then
            txt_chemeticos.ReadOnly = False
            txt_chemeticos.Text = ""
            txt_chemeticos.Focus()
        Else
            txt_chemeticos.Text = "NEGATIVO"
            txt_chemeticos.ReadOnly = True
        End If
    End Sub



    Private Sub chk_cgranulosos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cgranulosos.CheckedChanged
        If chk_cgranulosos.Checked = True Then
            txt_cgranulosos.ReadOnly = False
            txt_cgranulosos.Text = ""
            txt_cgranulosos.Focus()
        Else
            txt_cgranulosos.Text = "NEGATIVO"
            txt_cgranulosos.ReadOnly = True
        End If
    End Sub


    Private Sub chk_cleucocitarios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cleucocitarios.CheckedChanged
        If chk_cleucocitarios.Checked = True Then
            txt_cleucocitarios.ReadOnly = False
            txt_cleucocitarios.Text = ""
            txt_cleucocitarios.Focus()
        Else
            txt_cleucocitarios.Text = "NEGATIVO"
            txt_cleucocitarios.ReadOnly = True
        End If
    End Sub


    Private Sub chk_ccereos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ccereos.CheckedChanged
        If chk_ccereos.Checked = True Then
            txt_ccereos.ReadOnly = False
            txt_ccereos.Text = ""
            txt_ccereos.Focus()
        Else
            txt_ccereos.Text = "NEGATIVO"
            txt_ccereos.ReadOnly = True
        End If
    End Sub

    Private Sub chk_espermatozoides_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_espermatozoides.CheckedChanged
        If chk_espermatozoides.Checked = True Then
            txt_espermatozoides.ReadOnly = False
            txt_espermatozoides.Text = ""
            txt_espermatozoides.Focus()
        Else
            txt_espermatozoides.Text = "NEGATIVO"
            txt_espermatozoides.ReadOnly = True
        End If
    End Sub

    Private Sub chk_uratosA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_uratosA.CheckedChanged
        If chk_uratosA.Checked = True Then
            txt_uratosA.ReadOnly = False
            txt_uratosA.Text = ""
            txt_uratosA.Focus()
        Else
            txt_uratosA.Text = "NEGATIVO"
            txt_uratosA.ReadOnly = True
        End If
    End Sub

    Private Sub chk_fosfatosA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_fosfatosA.CheckedChanged
        If chk_fosfatosA.Checked = True Then
            txt_fosfatosA.ReadOnly = False
            txt_fosfatosA.Text = ""
            txt_fosfatosA.Focus()
        Else
            txt_fosfatosA.Text = "NEGATIVO"
            txt_fosfatosA.ReadOnly = True
        End If
    End Sub

    Private Sub chk_oxalatoAmo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_oxalatoAmo.CheckedChanged
        If chk_oxalatoAmo.Checked = True Then
            txt_oxalatoamo.ReadOnly = False
            txt_oxalatoamo.Text = ""
            txt_oxalatoamo.Focus()
        Else
            txt_oxalatoamo.Text = "NEGATIVO"
            txt_oxalatoamo.ReadOnly = True
        End If
    End Sub


    Private Sub chk_oxalatoCal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_oxalatoCal.CheckedChanged
        If chk_oxalatoCal.Checked = True Then
            txt_oxalatoCal.ReadOnly = False
            txt_oxalatoCal.Text = ""
            txt_oxalatoCal.Focus()
        Else
            txt_oxalatoCal.Text = "NEGATIVO"
            txt_oxalatoCal.ReadOnly = True
        End If
    End Sub

    Private Sub chk_fosfatoTri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_fosfatoTri.CheckedChanged
        If chk_fosfatoTri.Checked = True Then
            txt_fosfatoTri.ReadOnly = False
            txt_fosfatoTri.Text = ""
            txt_fosfatoTri.Focus()
        Else
            txt_fosfatoTri.Text = "NEGATIVO"
            txt_fosfatoTri.ReadOnly = True
        End If
    End Sub


    Private Sub chk_uratoAmo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_uratoAmo.CheckedChanged
        If chk_uratoAmo.Checked = True Then
            txt_uratoamo.ReadOnly = False
            txt_uratoamo.Text = ""
            txt_uratoamo.Focus()
        Else
            txt_uratoamo.Text = ""
            txt_uratoamo.ReadOnly = False
        End If
    End Sub

    Private Sub chk_crisAciUri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_crisAciUri.CheckedChanged
        If chk_crisAciUri.Checked = True Then
            txt_crisAciUri.ReadOnly = False
            txt_crisAciUri.Text = ""
            txt_crisAciUri.Focus()
        Else
            txt_crisAciUri.Text = "NEGATIVO"
            txt_crisAciUri.ReadOnly = True
        End If
    End Sub

    Private Sub chk_celulasRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_celulasRed.CheckedChanged
        If chk_celulasRed.Checked = True Then
            txt_celulasRed.ReadOnly = False
            txt_celulasRed.Text = ""
            txt_celulasRed.Focus()
        Else
            txt_celulasRed.Text = "NEGATIVO"
            txt_celulasRed.ReadOnly = True
        End If
    End Sub


    Private Sub chk_ameHis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ameHis.CheckedChanged
        If chk_ameHis.Checked = True Then
            cmb_AmeHisQ.Enabled = True
            cmb_AmeHisQ.Text = "escasos"
            cmb_ameHisT.Enabled = True
            cmb_ameHisT.Text = "escasos"
        Else
            cmb_AmeHisQ.Enabled = False
            cmb_AmeHisQ.Text = ""
            cmb_ameHisT.Enabled = False
            cmb_ameHisT.Text = ""
        End If
    End Sub

    Private Sub chk_AmeCol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AmeCol.CheckedChanged
        If chk_AmeCol.Checked = True Then
            cmb_ameColQ.Enabled = True
            cmb_ameColQ.Text = "escasos"
            cmb_ameColT.Enabled = True
            cmb_ameColT.Text = "escasos"
        Else
            cmb_ameColQ.Enabled = False
            cmb_ameColQ.Text = ""
            cmb_ameColT.Enabled = False
            cmb_ameColT.Text = ""
        End If
    End Sub

    Private Sub chk_Yodameba_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Yodameba.CheckedChanged
        If chk_Yodameba.Checked = True Then
            cmb_yodamebaQ.Enabled = True
            cmb_yodamebaQ.Text = "escasos"
            cmb_yodamebaT.Enabled = True
            cmb_yodamebaT.Text = "escasos"
        Else
            cmb_yodamebaQ.Enabled = False
            cmb_yodamebaQ.Text = ""
            cmb_yodamebaT.Enabled = False
            cmb_yodamebaT.Text = ""
        End If
    End Sub

    Private Sub chk_EndNan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_EndNan.CheckedChanged
        If chk_EndNan.Checked = True Then
            cmb_endNanQ.Enabled = True
            cmb_endNanQ.Text = "escasos"
            cmb_endNanT.Enabled = True
            cmb_endNanT.Text = "escasos"
        Else
            cmb_endNanQ.Enabled = False
            cmb_endNanQ.Text = ""
            cmb_endNanT.Enabled = False
            cmb_endNanT.Text = ""
        End If
    End Sub

    Private Sub chk_Enteromona_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Enteromona.CheckedChanged
        If chk_Enteromona.Checked = True Then
            cmb_enteromaQ.Enabled = True
            cmb_enteromaQ.Text = "escasos"
            cmb_enteromaT.Enabled = True
            cmb_enteromaT.Text = "escasos"
        Else
            cmb_enteromaQ.Enabled = False
            cmb_enteromaQ.Text = ""
            cmb_enteromaT.Enabled = False
            cmb_enteromaT.Text = ""
        End If
    End Sub

    Private Sub chk_Embadomona_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Embadomona.CheckedChanged
        If chk_Embadomona.Checked = True Then
            cmb_embadomaQ.Enabled = True
            cmb_embadomaQ.Text = "escasos"
            cmb_embadomaT.Enabled = True
            cmb_embadomaT.Text = "escasos"
        Else
            cmb_embadomaQ.Enabled = False
            cmb_embadomaQ.Text = ""
            cmb_embadomaT.Enabled = False
            cmb_embadomaT.Text = ""
        End If
    End Sub

    Private Sub chk_Chilomastix_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Chilomastix.CheckedChanged
        If chk_Chilomastix.Checked = True Then
            cmb_chilomastixQ.Enabled = True
            cmb_chilomastixQ.Text = "escasos"
            cmb_chilomastixT.Enabled = True
            cmb_chilomastixT.Text = "escasos"
        Else
            cmb_chilomastixQ.Enabled = False
            cmb_chilomastixQ.Text = ""
            cmb_chilomastixT.Enabled = False
            cmb_chilomastixT.Text = ""
        End If
    End Sub

    Private Sub chk_GiaLam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_GiaLam.CheckedChanged
        If chk_GiaLam.Checked = True Then
            cmb_GiaLamQ.Enabled = True
            cmb_GiaLamQ.Text = "escasos"
            cmb_GiaLamT.Enabled = True
            cmb_GiaLamT.Text = "escasos"
        Else
            cmb_GiaLamQ.Enabled = False
            cmb_GiaLamQ.Text = ""
            cmb_GiaLamT.Enabled = False
            cmb_GiaLamT.Text = ""
        End If
    End Sub


    Private Sub chk_TriHom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TriHom.CheckedChanged
        If chk_TriHom.Checked = True Then
            cmb_TriHomQ.Enabled = True
            cmb_TriHomQ.Text = "escasos"
            cmb_TriHomT.Enabled = True
            cmb_TriHomT.Text = "escasos"
        Else
            cmb_TriHomQ.Enabled = False
            cmb_TriHomQ.Text = ""
            cmb_TriHomT.Enabled = False
            cmb_TriHomT.Text = ""
        End If
    End Sub

    Private Sub chk_balCol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_balCol.CheckedChanged
        If chk_balCol.Checked = True Then
            cmb_BalColQ.Enabled = True
            cmb_BalColQ.Text = "escasos"
            cmb_BalColT.Enabled = True
            cmb_BalColT.Text = "escasos"
        Else
            cmb_BalColQ.Enabled = False
            cmb_BalColQ.Text = ""
            cmb_BalColT.Enabled = False
            cmb_BalColT.Text = ""
        End If
    End Sub

    Private Sub chk_tricocefalo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tricocefalo.CheckedChanged
        If chk_tricocefalo.Checked = True Then
            cmb_tricocefaloH.Enabled = True
            cmb_tricocefaloH.Text = "escasos"
            cmb_tricocefaloL.Enabled = True
            cmb_tricocefaloL.Text = "escasos"
        Else
            cmb_tricocefaloH.Enabled = False
            cmb_tricocefaloH.Text = ""
            cmb_tricocefaloL.Enabled = False
            cmb_tricocefaloL.Text = ""
        End If
    End Sub

    Private Sub chk_AscLum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AscLum.CheckedChanged
        If chk_AscLum.Checked = True Then
            cmb_ascLumH.Enabled = True
            cmb_ascLumH.Text = "escasos"
            cmb_ascLumL.Enabled = True
            cmb_ascLumL.Text = "escasos"
        Else
            cmb_ascLumH.Enabled = False
            cmb_ascLumH.Text = ""
            cmb_ascLumL.Enabled = False
            cmb_ascLumL.Text = ""
        End If
    End Sub

    Private Sub chk_uncinarias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_uncinarias.CheckedChanged
        If chk_uncinarias.Checked = True Then
            cmb_uncinariasH.Enabled = True
            cmb_uncinariasH.Text = "escasos"
            cmb_uncinariasL.Enabled = True
            cmb_uncinariasL.Text = "escasos"
        Else
            cmb_uncinariasH.Enabled = False
            cmb_uncinariasH.Text = ""
            cmb_uncinariasL.Enabled = False
            cmb_uncinariasL.Text = ""
        End If
    End Sub

    Private Sub chk_oxiuros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_oxiuros.CheckedChanged
        If chk_oxiuros.Checked = True Then
            cmb_OxiurosH.Enabled = True
            cmb_OxiurosH.Text = "escasos"
            cmb_oxiurosL.Enabled = True
            cmb_oxiurosL.Text = "escasos"
        Else
            cmb_OxiurosH.Enabled = False
            cmb_OxiurosH.Text = ""
            cmb_oxiurosL.Enabled = False
            cmb_oxiurosL.Text = ""
        End If
    End Sub

    Private Sub chk_Estrongiloides_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Estrongiloides.CheckedChanged
        If chk_Estrongiloides.Checked = True Then
            cmb_estrongiloidesH.Enabled = True
            cmb_estrongiloidesH.Text = "escasos"
            cmb_estrongiloidesL.Enabled = True
            cmb_estrongiloidesL.Text = "escasos"
        Else
            cmb_estrongiloidesH.Enabled = False
            cmb_estrongiloidesH.Text = ""
            cmb_estrongiloidesL.Enabled = False
            cmb_estrongiloidesL.Text = ""
        End If
    End Sub

    Private Sub chk_TenSol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TenSol.CheckedChanged
        If chk_TenSol.Checked = True Then
            cmb_tenSolH.Enabled = True
            cmb_tenSolH.Text = "escasos"
            cmb_tenSolL.Enabled = True
            cmb_tenSolL.Text = "escasos"
        Else
            cmb_tenSolH.Enabled = False
            cmb_tenSolH.Text = ""
            cmb_tenSolL.Enabled = False
            cmb_tenSolL.Text = ""
        End If
    End Sub


    Private Sub chk_HimNana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_HimNana.CheckedChanged
        If chk_HimNana.Checked = True Then
            cmb_HimNanH.Enabled = True
            cmb_HimNanH.Text = "escasos"
            cmb_HimNanL.Enabled = True
            cmb_HimNanL.Text = "escasos"
        Else
            cmb_HimNanH.Enabled = False
            cmb_HimNanH.Text = ""
            cmb_HimNanL.Enabled = False
            cmb_HimNanL.Text = ""
        End If
    End Sub

    Private Sub chk_HimDim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_HimDim.CheckedChanged
        If chk_HimDim.Checked = True Then
            cmb_HimDimH.Enabled = True
            cmb_HimDimH.Text = "escasos"
            cmb_HimDimL.Enabled = True
            cmb_HimDimL.Text = "escasos"
        Else
            cmb_HimDimH.Enabled = False
            cmb_HimDimH.Text = ""
            cmb_HimDimL.Enabled = False
            cmb_HimDimL.Text = ""
        End If
    End Sub

    Private Sub chk_hematiesC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_hematiesC.CheckedChanged
        If chk_hematiesC.Checked = True Then
            txt_hematiesC.ReadOnly = True
            txt_hematiesC.Text = ""
            txt_hematiesC.Focus()
        Else
            txt_hematiesC.Text = "escasos"
            txt_hematiesC.ReadOnly = False
        End If
    End Sub

    Private Sub chk_PiocitosC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PiocitosC.CheckedChanged
        If chk_PiocitosC.Checked = True Then
            txt_piocitosC.ReadOnly = True
            txt_piocitosC.Text = ""
            txt_piocitosC.Focus()
        Else
            txt_piocitosC.Text = "escasos"
            txt_piocitosC.ReadOnly = False
        End If
    End Sub

    Private Sub chk_CelulasC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_CelulasC.CheckedChanged
        If chk_CelulasC.Checked = True Then
            txt_celulasC.ReadOnly = True
            txt_celulasC.Text = ""
            txt_celulasC.Focus()
        Else
            txt_celulasC.Text = "escasos"
            txt_celulasC.ReadOnly = False
        End If
    End Sub

    Private Sub chk_MocoC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_MocoC.CheckedChanged
        If chk_MocoC.Checked = True Then
            cmb_moco.Enabled = True
            cmb_moco.Text = "escasos"
        Else
            cmb_moco.Text = ""
            cmb_moco.Enabled = False
        End If
    End Sub

    Private Sub chk_PMN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PMN.CheckedChanged
        If chk_PMN.Checked = True Then
            txt_PMN.Enabled = True
            txt_PMN.texto_Asigna("")
            txt_PMN.Focus()
        Else
            txt_PMN.texto_Asigna("")
            txt_PMN.Enabled = False
        End If
    End Sub


    Private Sub chk_SanOcu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SanOcu.CheckedChanged
        If chk_SanOcu.Checked = True Then
            cmb_SanOcu.Enabled = True
            cmb_SanOcu.Text = "negativo"
            cmb_SanOcu.Focus()
        Else
            cmb_SanOcu.Text = ""
            cmb_SanOcu.Enabled = False
        End If
    End Sub

    Private Sub chk_ResVeg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ResVeg.CheckedChanged
        If chk_ResVeg.Checked = True Then
            cmb_resVeg.Enabled = True
            cmb_resVeg.Text = "escasos"
            cmb_resVeg.Focus()
        Else
            cmb_resVeg.Text = ""
            cmb_resVeg.Enabled = False
        End If
    End Sub

    Private Sub chk_Almidones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Almidones.CheckedChanged
        If chk_Almidones.Checked = True Then
            cmb_almidones.Enabled = True
            cmb_almidones.Text = "escasos"
            cmb_almidones.Focus()
        Else
            cmb_almidones.Text = ""
            cmb_almidones.Enabled = False
        End If
    End Sub

    Private Sub chk_Grasas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Grasas.CheckedChanged
        If chk_Grasas.Checked = True Then
            cmb_grasas.Enabled = True
            cmb_grasas.Text = "escasas"
            cmb_grasas.Focus()
        Else
            cmb_grasas.Text = ""
            cmb_grasas.Enabled = False
        End If
    End Sub

    Private Sub chk_Levaduras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Levaduras.CheckedChanged
        If chk_Levaduras.Checked = True Then
            cmb_levaduras.Enabled = True
            cmb_levaduras.Text = "escasas"
            cmb_levaduras.Focus()
        Else
            cmb_levaduras.Text = ""
            cmb_levaduras.Enabled = False
        End If
    End Sub

    Private Sub chk_Hongos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Hongos.CheckedChanged
        If chk_Hongos.Checked = True Then
            cmb_Hongos.Enabled = True
            cmb_Hongos.Text = "escasos"
            cmb_Hongos.Focus()
        Else
            cmb_Hongos.Text = ""
            cmb_Hongos.Enabled = False
        End If
    End Sub

    Private Sub chk_BlaHom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_BlaHom.CheckedChanged
        If chk_BlaHom.Checked = True Then
            cmb_blaHom.Enabled = True
            cmb_blaHom.Text = "escasos"
            cmb_blaHom.Focus()
        Else
            cmb_blaHom.Text = ""
            cmb_blaHom.Enabled = False
        End If
    End Sub

End Class
