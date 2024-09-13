<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HistoriaClinica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HistoriaClinica))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_hc_MotConsulta = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grp_SigEsp1 = New System.Windows.Forms.GroupBox
        Me.chkSig_7 = New System.Windows.Forms.CheckBox
        Me.chkSig_8 = New System.Windows.Forms.CheckBox
        Me.chkSig_9 = New System.Windows.Forms.CheckBox
        Me.chkSig_1 = New System.Windows.Forms.CheckBox
        Me.chkSig_2 = New System.Windows.Forms.CheckBox
        Me.chkSig_3 = New System.Windows.Forms.CheckBox
        Me.chkSig_4 = New System.Windows.Forms.CheckBox
        Me.chkSig_5 = New System.Windows.Forms.CheckBox
        Me.chkSig_6 = New System.Windows.Forms.CheckBox
        Me.txt_AntFamOtro = New System.Windows.Forms.TextBox
        Me.txt_hcEvolInicio = New System.Windows.Forms.TextBox
        Me.txt_NarizMucosa = New System.Windows.Forms.TextBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.grpNarizPolipos = New System.Windows.Forms.GroupBox
        Me.chk_Pol_D = New System.Windows.Forms.CheckBox
        Me.chk_Pol_I = New System.Windows.Forms.CheckBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.txt_LabOtros = New System.Windows.Forms.TextBox
        Me.txt_HOcupacion = New System.Windows.Forms.TextBox
        Me.txt_LabImagen = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.grp_SinDigestivos = New System.Windows.Forms.GroupBox
        Me.txt_DigIntolerAlim = New System.Windows.Forms.TextBox
        Me.chkDig_IntolAlim = New System.Windows.Forms.CheckBox
        Me.chkDig_Regurgit = New System.Windows.Forms.CheckBox
        Me.chkDig_Pirosis = New System.Windows.Forms.CheckBox
        Me.chkDig_Acidez = New System.Windows.Forms.CheckBox
        Me.chkDig_Flatos = New System.Windows.Forms.CheckBox
        Me.chkDig_DolAbdo = New System.Windows.Forms.CheckBox
        Me.chkDig_Vomito = New System.Windows.Forms.CheckBox
        Me.chkDig_Diarrea = New System.Windows.Forms.CheckBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.grpNarizCorn = New System.Windows.Forms.GroupBox
        Me.chkHCorn_Grave = New System.Windows.Forms.CheckBox
        Me.chkHCorn_Moderado = New System.Windows.Forms.CheckBox
        Me.chkHCorn_Leve = New System.Windows.Forms.CheckBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.grp_AccAsmaticos = New System.Windows.Forms.GroupBox
        Me.chk4_Disnea = New System.Windows.Forms.CheckBox
        Me.chk4_Diurnos = New System.Windows.Forms.CheckBox
        Me.chk4_Nocturnos = New System.Windows.Forms.CheckBox
        Me.chk4_Roncus = New System.Windows.Forms.CheckBox
        Me.chk4_Sibilanc = New System.Windows.Forms.CheckBox
        Me.grp_SinBoca = New System.Windows.Forms.GroupBox
        Me.chkB_Ronca = New System.Windows.Forms.CheckBox
        Me.chkB_RespOral = New System.Windows.Forms.CheckBox
        Me.chkB_DurmeBAbierta = New System.Windows.Forms.CheckBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.grp_SinEstornuodos = New System.Windows.Forms.GroupBox
        Me.chkCE_No = New System.Windows.Forms.CheckBox
        Me.chkCE_Raro = New System.Windows.Forms.CheckBox
        Me.chkCE_Frecuente = New System.Windows.Forms.CheckBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.grp_SinNariz = New System.Windows.Forms.GroupBox
        Me.chkSN_ObtNasal = New System.Windows.Forms.CheckBox
        Me.chkSN_Rinorrea = New System.Windows.Forms.CheckBox
        Me.chkSN_Acuosa = New System.Windows.Forms.CheckBox
        Me.chkSN_Densa = New System.Windows.Forms.CheckBox
        Me.chkSN_Resequedad = New System.Windows.Forms.CheckBox
        Me.chkSN_Purulenta = New System.Windows.Forms.CheckBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.grp_Menstruacion = New System.Windows.Forms.GroupBox
        Me.chkM_Toma = New System.Windows.Forms.CheckBox
        Me.txt_MenstruToma = New System.Windows.Forms.TextBox
        Me.chkM_Colico = New System.Windows.Forms.CheckBox
        Me.chkM_Cefalea = New System.Windows.Forms.CheckBox
        Me.chkM_Migrana = New System.Windows.Forms.CheckBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.txt_Cirugias = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.txt_TTo_Antec = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.txt_OtrasEnfer = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.txt_EnferInfecc = New System.Windows.Forms.TextBox
        Me.txt_Cancer = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.cmb_EnfToroideas = New System.Windows.Forms.ComboBox
        Me.cmb_APP = New System.Windows.Forms.ComboBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.txt_TiemHab = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.grp_SigEsp2 = New System.Windows.Forms.GroupBox
        Me.chkSig2_1 = New System.Windows.Forms.CheckBox
        Me.chkSig2_2 = New System.Windows.Forms.CheckBox
        Me.chkSig2_3 = New System.Windows.Forms.CheckBox
        Me.chkSig2_4 = New System.Windows.Forms.CheckBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.grp_Edema = New System.Windows.Forms.GroupBox
        Me.chk_Ede7 = New System.Windows.Forms.CheckBox
        Me.chk_Ede6 = New System.Windows.Forms.CheckBox
        Me.chk_Ede1 = New System.Windows.Forms.CheckBox
        Me.chk_Ede5 = New System.Windows.Forms.CheckBox
        Me.chk_Ede2 = New System.Windows.Forms.CheckBox
        Me.chk_Ede4 = New System.Windows.Forms.CheckBox
        Me.chk_Ede3 = New System.Windows.Forms.CheckBox
        Me.grp_Migra = New System.Windows.Forms.GroupBox
        Me.chk_Mig7 = New System.Windows.Forms.CheckBox
        Me.chk_Mig6 = New System.Windows.Forms.CheckBox
        Me.chk_Mig1 = New System.Windows.Forms.CheckBox
        Me.chk_Mig5 = New System.Windows.Forms.CheckBox
        Me.chk_Mig2 = New System.Windows.Forms.CheckBox
        Me.chk_Mig4 = New System.Windows.Forms.CheckBox
        Me.chk_Mig3 = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grp_Drog = New System.Windows.Forms.GroupBox
        Me.chk_Dro7 = New System.Windows.Forms.CheckBox
        Me.chk_Dro1 = New System.Windows.Forms.CheckBox
        Me.chk_Dro2 = New System.Windows.Forms.CheckBox
        Me.chk_Dro3 = New System.Windows.Forms.CheckBox
        Me.chk_Dro4 = New System.Windows.Forms.CheckBox
        Me.chk_Dro5 = New System.Windows.Forms.CheckBox
        Me.chk_Dro6 = New System.Windows.Forms.CheckBox
        Me.grp_Conj = New System.Windows.Forms.GroupBox
        Me.chk_Con7 = New System.Windows.Forms.CheckBox
        Me.chk_Con1 = New System.Windows.Forms.CheckBox
        Me.chk_Con2 = New System.Windows.Forms.CheckBox
        Me.chk_Con3 = New System.Windows.Forms.CheckBox
        Me.chk_Con4 = New System.Windows.Forms.CheckBox
        Me.chk_Con5 = New System.Windows.Forms.CheckBox
        Me.chk_Con6 = New System.Windows.Forms.CheckBox
        Me.grp_Urt = New System.Windows.Forms.GroupBox
        Me.chk_Urt7 = New System.Windows.Forms.CheckBox
        Me.chk_Urt1 = New System.Windows.Forms.CheckBox
        Me.chk_Urt2 = New System.Windows.Forms.CheckBox
        Me.chk_Urt6 = New System.Windows.Forms.CheckBox
        Me.chk_Urt3 = New System.Windows.Forms.CheckBox
        Me.chk_Urt5 = New System.Windows.Forms.CheckBox
        Me.chk_Urt4 = New System.Windows.Forms.CheckBox
        Me.grp_Eccen = New System.Windows.Forms.GroupBox
        Me.chk_Ecc7 = New System.Windows.Forms.CheckBox
        Me.chk_Ecc1 = New System.Windows.Forms.CheckBox
        Me.chk_Ecc2 = New System.Windows.Forms.CheckBox
        Me.chk_Ecc3 = New System.Windows.Forms.CheckBox
        Me.chk_Ecc4 = New System.Windows.Forms.CheckBox
        Me.chk_Ecc5 = New System.Windows.Forms.CheckBox
        Me.chk_Ecc6 = New System.Windows.Forms.CheckBox
        Me.grp_Rini = New System.Windows.Forms.GroupBox
        Me.chk_Rin7 = New System.Windows.Forms.CheckBox
        Me.chk_Rin1 = New System.Windows.Forms.CheckBox
        Me.chk_Rin2 = New System.Windows.Forms.CheckBox
        Me.chk_Rin3 = New System.Windows.Forms.CheckBox
        Me.chk_Rin4 = New System.Windows.Forms.CheckBox
        Me.chk_Rin5 = New System.Windows.Forms.CheckBox
        Me.chk_Rin6 = New System.Windows.Forms.CheckBox
        Me.grp_Asma = New System.Windows.Forms.GroupBox
        Me.chk_Asm7 = New System.Windows.Forms.CheckBox
        Me.chk_Asm1 = New System.Windows.Forms.CheckBox
        Me.chk_Asm2 = New System.Windows.Forms.CheckBox
        Me.chk_Asm3 = New System.Windows.Forms.CheckBox
        Me.chk_Asm4 = New System.Windows.Forms.CheckBox
        Me.chk_Asm5 = New System.Windows.Forms.CheckBox
        Me.chk_Asm6 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_HPsicoS = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txt_HSeg = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txt_HTToAnam = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_HisEnfeAct = New System.Windows.Forms.TextBox
        Me.txt_HabiTox_Otro = New System.Windows.Forms.TextBox
        Me.cmb_HabTox = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txt_hcInmun = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txt_hcHobbies = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cmb_zona = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_LabBiopsia = New System.Windows.Forms.TextBox
        Me.txt_CampoPiel = New System.Windows.Forms.TextBox
        Me.grp_Garganta = New System.Windows.Forms.GroupBox
        Me.chk10_Exudado = New System.Windows.Forms.CheckBox
        Me.chk10_Goteo = New System.Windows.Forms.CheckBox
        Me.chk10_Inflamada = New System.Windows.Forms.CheckBox
        Me.chk10_Granulosa = New System.Windows.Forms.CheckBox
        Me.chk10_SReflujo = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.grp_Nariz = New System.Windows.Forms.GroupBox
        Me.txt_Obstr = New System.Windows.Forms.TextBox
        Me.chk9_Edema = New System.Windows.Forms.CheckBox
        Me.chk9_Moco = New System.Windows.Forms.CheckBox
        Me.chk9_Obs = New System.Windows.Forms.CheckBox
        Me.chk9_Desv = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.grp_ResForzada = New System.Windows.Forms.GroupBox
        Me.chk8_Roncus = New System.Windows.Forms.CheckBox
        Me.chk8_Sibilian = New System.Windows.Forms.CheckBox
        Me.chk8_Tiraje = New System.Windows.Forms.CheckBox
        Me.chk8_Tos = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.grp_ResNormal = New System.Windows.Forms.GroupBox
        Me.chk7_Roncus = New System.Windows.Forms.CheckBox
        Me.chk7_Sibilian = New System.Windows.Forms.CheckBox
        Me.chk7_Tiraje = New System.Windows.Forms.CheckBox
        Me.chk7_Tos = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.grp_SinPiel = New System.Windows.Forms.GroupBox
        Me.txt_PielOtros = New System.Windows.Forms.TextBox
        Me.chk6_Otros = New System.Windows.Forms.CheckBox
        Me.chk6_Placas = New System.Windows.Forms.CheckBox
        Me.chk6_Salpullidos = New System.Windows.Forms.CheckBox
        Me.chk6_Rash = New System.Windows.Forms.CheckBox
        Me.chk6_Despig = New System.Windows.Forms.CheckBox
        Me.chk6_Manchas = New System.Windows.Forms.CheckBox
        Me.chk6_Papulas = New System.Windows.Forms.CheckBox
        Me.chk6_Xerosis = New System.Windows.Forms.CheckBox
        Me.chk6_Liqunif = New System.Windows.Forms.CheckBox
        Me.chk6_Contacto = New System.Windows.Forms.CheckBox
        Me.chk6_Edema = New System.Windows.Forms.CheckBox
        Me.chk6_Habones = New System.Windows.Forms.CheckBox
        Me.chk6_Demografismo = New System.Windows.Forms.CheckBox
        Me.chk6_EccPliegues = New System.Windows.Forms.CheckBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.dgv_Lab4 = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgv_Lab3 = New System.Windows.Forms.DataGridView
        Me.Label15 = New System.Windows.Forms.Label
        Me.dgv_Lab2 = New System.Windows.Forms.DataGridView
        Me.dgv_Lab1 = New System.Windows.Forms.DataGridView
        Me.grp_Tos = New System.Windows.Forms.GroupBox
        Me.chk5_Ejercicio = New System.Windows.Forms.CheckBox
        Me.chk5_OpToraxica = New System.Windows.Forms.CheckBox
        Me.chk5_Dia = New System.Windows.Forms.CheckBox
        Me.chk5_Noche = New System.Windows.Forms.CheckBox
        Me.chk5_Seca = New System.Windows.Forms.CheckBox
        Me.chk5_Flema = New System.Windows.Forms.CheckBox
        Me.grp_Pruirito = New System.Windows.Forms.GroupBox
        Me.chk3_DescaPal = New System.Windows.Forms.CheckBox
        Me.chk3_Ojos = New System.Windows.Forms.CheckBox
        Me.chk3_Nariz = New System.Windows.Forms.CheckBox
        Me.chk3_Garganta = New System.Windows.Forms.CheckBox
        Me.chk3_Oidos = New System.Windows.Forms.CheckBox
        Me.chk3_Palatinos = New System.Windows.Forms.CheckBox
        Me.chk3_EdemPalpe = New System.Windows.Forms.CheckBox
        Me.grp_SinOjos = New System.Windows.Forms.GroupBox
        Me.chkO_Lagrimeo = New System.Windows.Forms.CheckBox
        Me.chkO_Conjuntivitis = New System.Windows.Forms.CheckBox
        Me.chkO_Enrojecimiento = New System.Windows.Forms.CheckBox
        Me.grp_Desencadena = New System.Windows.Forms.GroupBox
        Me.txt_DesOtro = New System.Windows.Forms.TextBox
        Me.chk1_OTROS = New System.Windows.Forms.CheckBox
        Me.chk1_Polvo = New System.Windows.Forms.CheckBox
        Me.chk1_Humo = New System.Windows.Forms.CheckBox
        Me.chk1_Frio = New System.Windows.Forms.CheckBox
        Me.chk1_Humedad = New System.Windows.Forms.CheckBox
        Me.chk1_Calor = New System.Windows.Forms.CheckBox
        Me.chk1_Alimentos = New System.Windows.Forms.CheckBox
        Me.chk1_Olores = New System.Windows.Forms.CheckBox
        Me.txt_Ram = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.labelTos = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.btn_ssalir = New System.Windows.Forms.Button
        Me.btn_gguardar = New System.Windows.Forms.Button
        Me.btn_ImpHistoria = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.lbl_DProfesion = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.lbl_DProvincia = New System.Windows.Forms.Label
        Me.lbl_DFono = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.lbl_DGenero = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.lbl_DMail = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.lbl_DPoliza = New System.Windows.Forms.Label
        Me.lbl_DObs = New System.Windows.Forms.Label
        Me.lbl_DFecNac = New System.Windows.Forms.Label
        Me.lbl_DDoc = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.lbl_DApellidos = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.lbl_DCiudad = New System.Windows.Forms.Label
        Me.lbl_DPais = New System.Windows.Forms.Label
        Me.lbl_DDirec = New System.Windows.Forms.Label
        Me.lbl_DNombres = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label89 = New System.Windows.Forms.Label
        Me.dgv_Cambios = New System.Windows.Forms.DataGridView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.lbl_TotExas = New System.Windows.Forms.Label
        Me.Label160 = New System.Windows.Forms.Label
        Me.lbl_ToTConsultas = New System.Windows.Forms.Label
        Me.Label161 = New System.Windows.Forms.Label
        Me.lbl_TotCie = New System.Windows.Forms.Label
        Me.Label162 = New System.Windows.Forms.Label
        Me.Label159 = New System.Windows.Forms.Label
        Me.dgv_ConsultaHistorico = New System.Windows.Forms.DataGridView
        Me.lbl_pais = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmb_Campo = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.grp_SigEsp1.SuspendLayout()
        Me.grpNarizPolipos.SuspendLayout()
        Me.grp_SinDigestivos.SuspendLayout()
        Me.grpNarizCorn.SuspendLayout()
        Me.grp_AccAsmaticos.SuspendLayout()
        Me.grp_SinBoca.SuspendLayout()
        Me.grp_SinEstornuodos.SuspendLayout()
        Me.grp_SinNariz.SuspendLayout()
        Me.grp_Menstruacion.SuspendLayout()
        Me.grp_SigEsp2.SuspendLayout()
        Me.grp_Edema.SuspendLayout()
        Me.grp_Migra.SuspendLayout()
        Me.grp_Drog.SuspendLayout()
        Me.grp_Conj.SuspendLayout()
        Me.grp_Urt.SuspendLayout()
        Me.grp_Eccen.SuspendLayout()
        Me.grp_Rini.SuspendLayout()
        Me.grp_Asma.SuspendLayout()
        Me.grp_Garganta.SuspendLayout()
        Me.grp_Nariz.SuspendLayout()
        Me.grp_ResForzada.SuspendLayout()
        Me.grp_ResNormal.SuspendLayout()
        Me.grp_SinPiel.SuspendLayout()
        CType(Me.dgv_Lab4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Lab3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Lab2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Lab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Tos.SuspendLayout()
        Me.grp_Pruirito.SuspendLayout()
        Me.grp_SinOjos.SuspendLayout()
        Me.grp_Desencadena.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_Cambios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgv_ConsultaHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.Location = New System.Drawing.Point(228, 9)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(75, 16)
        Me.lbl_paciente.TabIndex = 157
        Me.lbl_paciente.Text = "PACIENTE"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(19, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 16)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "ANTECEDENTES PERSONALES"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 31)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "MOTIVO DE CONSULTA"
        '
        'txt_hc_MotConsulta
        '
        Me.txt_hc_MotConsulta.BackColor = System.Drawing.Color.White
        Me.txt_hc_MotConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hc_MotConsulta.Location = New System.Drawing.Point(118, 77)
        Me.txt_hc_MotConsulta.Multiline = True
        Me.txt_hc_MotConsulta.Name = "txt_hc_MotConsulta"
        Me.txt_hc_MotConsulta.Size = New System.Drawing.Size(809, 29)
        Me.txt_hc_MotConsulta.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 28)
        Me.Label9.TabIndex = 176
        Me.Label9.Text = "HIST. ENFER. ACTUAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(143, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 18)
        Me.Label13.TabIndex = 186
        Me.Label13.Text = "EDAD:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(143, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 18)
        Me.Label14.TabIndex = 187
        Me.Label14.Text = "PACIENTE:"
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.Location = New System.Drawing.Point(197, 32)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(46, 16)
        Me.lbl_edad.TabIndex = 188
        Me.lbl_edad.Text = "EDAD"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(5, 5)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.grp_SigEsp1)
        Me.Panel1.Controls.Add(Me.txt_AntFamOtro)
        Me.Panel1.Controls.Add(Me.txt_hcEvolInicio)
        Me.Panel1.Controls.Add(Me.txt_NarizMucosa)
        Me.Panel1.Controls.Add(Me.Label81)
        Me.Panel1.Controls.Add(Me.Label80)
        Me.Panel1.Controls.Add(Me.grpNarizPolipos)
        Me.Panel1.Controls.Add(Me.Label72)
        Me.Panel1.Controls.Add(Me.txt_LabOtros)
        Me.Panel1.Controls.Add(Me.txt_HOcupacion)
        Me.Panel1.Controls.Add(Me.txt_LabImagen)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.grp_SinDigestivos)
        Me.Panel1.Controls.Add(Me.Label71)
        Me.Panel1.Controls.Add(Me.grpNarizCorn)
        Me.Panel1.Controls.Add(Me.Label70)
        Me.Panel1.Controls.Add(Me.Label69)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.Label68)
        Me.Panel1.Controls.Add(Me.Label67)
        Me.Panel1.Controls.Add(Me.grp_AccAsmaticos)
        Me.Panel1.Controls.Add(Me.grp_SinBoca)
        Me.Panel1.Controls.Add(Me.Label66)
        Me.Panel1.Controls.Add(Me.grp_SinEstornuodos)
        Me.Panel1.Controls.Add(Me.Label65)
        Me.Panel1.Controls.Add(Me.grp_SinNariz)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.Label64)
        Me.Panel1.Controls.Add(Me.grp_Menstruacion)
        Me.Panel1.Controls.Add(Me.Label63)
        Me.Panel1.Controls.Add(Me.txt_Cirugias)
        Me.Panel1.Controls.Add(Me.Label62)
        Me.Panel1.Controls.Add(Me.txt_TTo_Antec)
        Me.Panel1.Controls.Add(Me.Label61)
        Me.Panel1.Controls.Add(Me.txt_OtrasEnfer)
        Me.Panel1.Controls.Add(Me.Label60)
        Me.Panel1.Controls.Add(Me.txt_EnferInfecc)
        Me.Panel1.Controls.Add(Me.txt_Cancer)
        Me.Panel1.Controls.Add(Me.Label58)
        Me.Panel1.Controls.Add(Me.Label57)
        Me.Panel1.Controls.Add(Me.cmb_EnfToroideas)
        Me.Panel1.Controls.Add(Me.cmb_APP)
        Me.Panel1.Controls.Add(Me.Label55)
        Me.Panel1.Controls.Add(Me.txt_TiemHab)
        Me.Panel1.Controls.Add(Me.Label54)
        Me.Panel1.Controls.Add(Me.Label50)
        Me.Panel1.Controls.Add(Me.Label51)
        Me.Panel1.Controls.Add(Me.Label52)
        Me.Panel1.Controls.Add(Me.Label53)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Controls.Add(Me.Label48)
        Me.Panel1.Controls.Add(Me.Label49)
        Me.Panel1.Controls.Add(Me.grp_SigEsp2)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.Label44)
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Controls.Add(Me.Label46)
        Me.Panel1.Controls.Add(Me.grp_Edema)
        Me.Panel1.Controls.Add(Me.grp_Migra)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.grp_Drog)
        Me.Panel1.Controls.Add(Me.grp_Conj)
        Me.Panel1.Controls.Add(Me.grp_Urt)
        Me.Panel1.Controls.Add(Me.grp_Eccen)
        Me.Panel1.Controls.Add(Me.grp_Rini)
        Me.Panel1.Controls.Add(Me.grp_Asma)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_HPsicoS)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.txt_HSeg)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txt_HTToAnam)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.txt_HisEnfeAct)
        Me.Panel1.Controls.Add(Me.txt_HabiTox_Otro)
        Me.Panel1.Controls.Add(Me.cmb_HabTox)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txt_hcInmun)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.txt_hcHobbies)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.cmb_zona)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txt_LabBiopsia)
        Me.Panel1.Controls.Add(Me.txt_CampoPiel)
        Me.Panel1.Controls.Add(Me.grp_Garganta)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.grp_Nariz)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.grp_ResForzada)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.grp_ResNormal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.grp_SinPiel)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.dgv_Lab4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dgv_Lab3)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.dgv_Lab2)
        Me.Panel1.Controls.Add(Me.txt_hc_MotConsulta)
        Me.Panel1.Controls.Add(Me.dgv_Lab1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.grp_Tos)
        Me.Panel1.Controls.Add(Me.grp_Pruirito)
        Me.Panel1.Controls.Add(Me.grp_SinOjos)
        Me.Panel1.Controls.Add(Me.grp_Desencadena)
        Me.Panel1.Controls.Add(Me.txt_Ram)
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.labelTos)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label59)
        Me.Panel1.Controls.Add(Me.Label56)
        Me.Panel1.Location = New System.Drawing.Point(13, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 608)
        Me.Panel1.TabIndex = 200
        '
        'grp_SigEsp1
        '
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_7)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_8)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_9)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_1)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_2)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_3)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_4)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_5)
        Me.grp_SigEsp1.Controls.Add(Me.chkSig_6)
        Me.grp_SigEsp1.Location = New System.Drawing.Point(746, 642)
        Me.grp_SigEsp1.Name = "grp_SigEsp1"
        Me.grp_SigEsp1.Size = New System.Drawing.Size(27, 186)
        Me.grp_SigEsp1.TabIndex = 41
        Me.grp_SigEsp1.TabStop = False
        '
        'chkSig_7
        '
        Me.chkSig_7.AutoSize = True
        Me.chkSig_7.Location = New System.Drawing.Point(6, 9)
        Me.chkSig_7.Name = "chkSig_7"
        Me.chkSig_7.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_7.TabIndex = 249
        Me.chkSig_7.Tag = "LENG. GEOGRAFICA"
        Me.chkSig_7.UseVisualStyleBackColor = True
        '
        'chkSig_8
        '
        Me.chkSig_8.AutoSize = True
        Me.chkSig_8.Location = New System.Drawing.Point(6, 29)
        Me.chkSig_8.Name = "chkSig_8"
        Me.chkSig_8.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_8.TabIndex = 250
        Me.chkSig_8.Tag = "AMID. HIPER DERECHA"
        Me.chkSig_8.UseVisualStyleBackColor = True
        '
        'chkSig_9
        '
        Me.chkSig_9.AutoSize = True
        Me.chkSig_9.Location = New System.Drawing.Point(6, 49)
        Me.chkSig_9.Name = "chkSig_9"
        Me.chkSig_9.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_9.TabIndex = 251
        Me.chkSig_9.Tag = "CRIPTIC."
        Me.chkSig_9.UseVisualStyleBackColor = True
        '
        'chkSig_1
        '
        Me.chkSig_1.AutoSize = True
        Me.chkSig_1.Location = New System.Drawing.Point(6, 69)
        Me.chkSig_1.Name = "chkSig_1"
        Me.chkSig_1.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_1.TabIndex = 236
        Me.chkSig_1.Tag = "CON PUS"
        Me.chkSig_1.UseVisualStyleBackColor = True
        '
        'chkSig_2
        '
        Me.chkSig_2.AutoSize = True
        Me.chkSig_2.Location = New System.Drawing.Point(6, 89)
        Me.chkSig_2.Name = "chkSig_2"
        Me.chkSig_2.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_2.TabIndex = 244
        Me.chkSig_2.Tag = "GANGLIOS"
        Me.chkSig_2.UseVisualStyleBackColor = True
        '
        'chkSig_3
        '
        Me.chkSig_3.AutoSize = True
        Me.chkSig_3.Location = New System.Drawing.Point(6, 109)
        Me.chkSig_3.Name = "chkSig_3"
        Me.chkSig_3.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_3.TabIndex = 245
        Me.chkSig_3.Tag = "CONJUNTIVAS"
        Me.chkSig_3.UseVisualStyleBackColor = True
        '
        'chkSig_4
        '
        Me.chkSig_4.AutoSize = True
        Me.chkSig_4.Location = New System.Drawing.Point(6, 129)
        Me.chkSig_4.Name = "chkSig_4"
        Me.chkSig_4.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_4.TabIndex = 246
        Me.chkSig_4.Tag = "S DE D MORGAN"
        Me.chkSig_4.UseVisualStyleBackColor = True
        '
        'chkSig_5
        '
        Me.chkSig_5.AutoSize = True
        Me.chkSig_5.Location = New System.Drawing.Point(6, 149)
        Me.chkSig_5.Name = "chkSig_5"
        Me.chkSig_5.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_5.TabIndex = 247
        Me.chkSig_5.Tag = "S DARIER"
        Me.chkSig_5.UseVisualStyleBackColor = True
        '
        'chkSig_6
        '
        Me.chkSig_6.AutoSize = True
        Me.chkSig_6.Location = New System.Drawing.Point(6, 169)
        Me.chkSig_6.Name = "chkSig_6"
        Me.chkSig_6.Size = New System.Drawing.Size(15, 14)
        Me.chkSig_6.TabIndex = 248
        Me.chkSig_6.Tag = "SALUDO ALERGICO"
        Me.chkSig_6.UseVisualStyleBackColor = True
        '
        'txt_AntFamOtro
        '
        Me.txt_AntFamOtro.BackColor = System.Drawing.Color.White
        Me.txt_AntFamOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_AntFamOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AntFamOtro.Location = New System.Drawing.Point(52, 805)
        Me.txt_AntFamOtro.Name = "txt_AntFamOtro"
        Me.txt_AntFamOtro.Size = New System.Drawing.Size(65, 18)
        Me.txt_AntFamOtro.TabIndex = 336
        '
        'txt_hcEvolInicio
        '
        Me.txt_hcEvolInicio.BackColor = System.Drawing.Color.White
        Me.txt_hcEvolInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hcEvolInicio.Location = New System.Drawing.Point(118, 173)
        Me.txt_hcEvolInicio.Multiline = True
        Me.txt_hcEvolInicio.Name = "txt_hcEvolInicio"
        Me.txt_hcEvolInicio.Size = New System.Drawing.Size(809, 21)
        Me.txt_hcEvolInicio.TabIndex = 13
        '
        'txt_NarizMucosa
        '
        Me.txt_NarizMucosa.BackColor = System.Drawing.Color.White
        Me.txt_NarizMucosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NarizMucosa.Location = New System.Drawing.Point(695, 931)
        Me.txt_NarizMucosa.Name = "txt_NarizMucosa"
        Me.txt_NarizMucosa.Size = New System.Drawing.Size(223, 20)
        Me.txt_NarizMucosa.TabIndex = 48
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Black
        Me.Label81.Location = New System.Drawing.Point(643, 936)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(61, 19)
        Me.Label81.TabIndex = 407
        Me.Label81.Text = "Mucosa:"
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Black
        Me.Label80.Location = New System.Drawing.Point(428, 935)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(61, 19)
        Me.Label80.TabIndex = 406
        Me.Label80.Text = "Pólipos"
        '
        'grpNarizPolipos
        '
        Me.grpNarizPolipos.Controls.Add(Me.chk_Pol_D)
        Me.grpNarizPolipos.Controls.Add(Me.chk_Pol_I)
        Me.grpNarizPolipos.Location = New System.Drawing.Point(506, 924)
        Me.grpNarizPolipos.Name = "grpNarizPolipos"
        Me.grpNarizPolipos.Size = New System.Drawing.Size(123, 32)
        Me.grpNarizPolipos.TabIndex = 47
        Me.grpNarizPolipos.TabStop = False
        '
        'chk_Pol_D
        '
        Me.chk_Pol_D.AutoSize = True
        Me.chk_Pol_D.Location = New System.Drawing.Point(13, 11)
        Me.chk_Pol_D.Name = "chk_Pol_D"
        Me.chk_Pol_D.Size = New System.Drawing.Size(46, 17)
        Me.chk_Pol_D.TabIndex = 205
        Me.chk_Pol_D.Text = "Der."
        Me.chk_Pol_D.UseVisualStyleBackColor = True
        '
        'chk_Pol_I
        '
        Me.chk_Pol_I.AutoSize = True
        Me.chk_Pol_I.Location = New System.Drawing.Point(77, 11)
        Me.chk_Pol_I.Name = "chk_Pol_I"
        Me.chk_Pol_I.Size = New System.Drawing.Size(43, 17)
        Me.chk_Pol_I.TabIndex = 207
        Me.chk_Pol_I.Text = "Izq."
        Me.chk_Pol_I.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(792, 1110)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(52, 16)
        Me.Label72.TabIndex = 405
        Me.Label72.Text = "OTROS"
        '
        'txt_LabOtros
        '
        Me.txt_LabOtros.BackColor = System.Drawing.Color.White
        Me.txt_LabOtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_LabOtros.Location = New System.Drawing.Point(791, 1131)
        Me.txt_LabOtros.Multiline = True
        Me.txt_LabOtros.Name = "txt_LabOtros"
        Me.txt_LabOtros.Size = New System.Drawing.Size(176, 158)
        Me.txt_LabOtros.TabIndex = 57
        '
        'txt_HOcupacion
        '
        Me.txt_HOcupacion.BackColor = System.Drawing.Color.White
        Me.txt_HOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_HOcupacion.Location = New System.Drawing.Point(343, 26)
        Me.txt_HOcupacion.Multiline = True
        Me.txt_HOcupacion.Name = "txt_HOcupacion"
        Me.txt_HOcupacion.Size = New System.Drawing.Size(161, 21)
        Me.txt_HOcupacion.TabIndex = 2
        '
        'txt_LabImagen
        '
        Me.txt_LabImagen.BackColor = System.Drawing.Color.White
        Me.txt_LabImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_LabImagen.Location = New System.Drawing.Point(74, 1076)
        Me.txt_LabImagen.Multiline = True
        Me.txt_LabImagen.Name = "txt_LabImagen"
        Me.txt_LabImagen.Size = New System.Drawing.Size(297, 49)
        Me.txt_LabImagen.TabIndex = 51
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(817, 1350)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 402
        Me.Label31.Text = "Label31"
        '
        'grp_SinDigestivos
        '
        Me.grp_SinDigestivos.Controls.Add(Me.txt_DigIntolerAlim)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_IntolAlim)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_Regurgit)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_Pirosis)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_Acidez)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_Flatos)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_DolAbdo)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_Vomito)
        Me.grp_SinDigestivos.Controls.Add(Me.chkDig_Diarrea)
        Me.grp_SinDigestivos.Location = New System.Drawing.Point(118, 551)
        Me.grp_SinDigestivos.Name = "grp_SinDigestivos"
        Me.grp_SinDigestivos.Size = New System.Drawing.Size(808, 31)
        Me.grp_SinDigestivos.TabIndex = 31
        Me.grp_SinDigestivos.TabStop = False
        '
        'txt_DigIntolerAlim
        '
        Me.txt_DigIntolerAlim.BackColor = System.Drawing.Color.White
        Me.txt_DigIntolerAlim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_DigIntolerAlim.Location = New System.Drawing.Point(664, 7)
        Me.txt_DigIntolerAlim.Name = "txt_DigIntolerAlim"
        Me.txt_DigIntolerAlim.Size = New System.Drawing.Size(138, 20)
        Me.txt_DigIntolerAlim.TabIndex = 338
        '
        'chkDig_IntolAlim
        '
        Me.chkDig_IntolAlim.AutoSize = True
        Me.chkDig_IntolAlim.Location = New System.Drawing.Point(528, 10)
        Me.chkDig_IntolAlim.Name = "chkDig_IntolAlim"
        Me.chkDig_IntolAlim.Size = New System.Drawing.Size(134, 17)
        Me.chkDig_IntolAlim.TabIndex = 235
        Me.chkDig_IntolAlim.Text = "Intolerancia alimentaria"
        Me.chkDig_IntolAlim.UseVisualStyleBackColor = True
        '
        'chkDig_Regurgit
        '
        Me.chkDig_Regurgit.AutoSize = True
        Me.chkDig_Regurgit.Location = New System.Drawing.Point(430, 10)
        Me.chkDig_Regurgit.Name = "chkDig_Regurgit"
        Me.chkDig_Regurgit.Size = New System.Drawing.Size(92, 17)
        Me.chkDig_Regurgit.TabIndex = 234
        Me.chkDig_Regurgit.Text = "Regurgitacion"
        Me.chkDig_Regurgit.UseVisualStyleBackColor = True
        '
        'chkDig_Pirosis
        '
        Me.chkDig_Pirosis.AutoSize = True
        Me.chkDig_Pirosis.Location = New System.Drawing.Point(80, 10)
        Me.chkDig_Pirosis.Name = "chkDig_Pirosis"
        Me.chkDig_Pirosis.Size = New System.Drawing.Size(56, 17)
        Me.chkDig_Pirosis.TabIndex = 229
        Me.chkDig_Pirosis.Text = "Pirosis"
        Me.chkDig_Pirosis.UseVisualStyleBackColor = True
        '
        'chkDig_Acidez
        '
        Me.chkDig_Acidez.AutoSize = True
        Me.chkDig_Acidez.Location = New System.Drawing.Point(8, 10)
        Me.chkDig_Acidez.Name = "chkDig_Acidez"
        Me.chkDig_Acidez.Size = New System.Drawing.Size(58, 17)
        Me.chkDig_Acidez.TabIndex = 228
        Me.chkDig_Acidez.Text = "Acidez"
        Me.chkDig_Acidez.UseVisualStyleBackColor = True
        '
        'chkDig_Flatos
        '
        Me.chkDig_Flatos.AutoSize = True
        Me.chkDig_Flatos.Location = New System.Drawing.Point(142, 10)
        Me.chkDig_Flatos.Name = "chkDig_Flatos"
        Me.chkDig_Flatos.Size = New System.Drawing.Size(54, 17)
        Me.chkDig_Flatos.TabIndex = 230
        Me.chkDig_Flatos.Text = "Flatos"
        Me.chkDig_Flatos.UseVisualStyleBackColor = True
        '
        'chkDig_DolAbdo
        '
        Me.chkDig_DolAbdo.AutoSize = True
        Me.chkDig_DolAbdo.Location = New System.Drawing.Point(199, 10)
        Me.chkDig_DolAbdo.Name = "chkDig_DolAbdo"
        Me.chkDig_DolAbdo.Size = New System.Drawing.Size(103, 17)
        Me.chkDig_DolAbdo.TabIndex = 231
        Me.chkDig_DolAbdo.Text = "Dolor Adbominal"
        Me.chkDig_DolAbdo.UseVisualStyleBackColor = True
        '
        'chkDig_Vomito
        '
        Me.chkDig_Vomito.AutoSize = True
        Me.chkDig_Vomito.Location = New System.Drawing.Point(304, 10)
        Me.chkDig_Vomito.Name = "chkDig_Vomito"
        Me.chkDig_Vomito.Size = New System.Drawing.Size(58, 17)
        Me.chkDig_Vomito.TabIndex = 232
        Me.chkDig_Vomito.Text = "Vomito"
        Me.chkDig_Vomito.UseVisualStyleBackColor = True
        '
        'chkDig_Diarrea
        '
        Me.chkDig_Diarrea.AutoSize = True
        Me.chkDig_Diarrea.Location = New System.Drawing.Point(367, 10)
        Me.chkDig_Diarrea.Name = "chkDig_Diarrea"
        Me.chkDig_Diarrea.Size = New System.Drawing.Size(60, 17)
        Me.chkDig_Diarrea.TabIndex = 233
        Me.chkDig_Diarrea.Text = "Diarrea"
        Me.chkDig_Diarrea.UseVisualStyleBackColor = True
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Black
        Me.Label71.Location = New System.Drawing.Point(22, 564)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(78, 18)
        Me.Label71.TabIndex = 400
        Me.Label71.Text = "DIGESTIVOS"
        '
        'grpNarizCorn
        '
        Me.grpNarizCorn.Controls.Add(Me.chkHCorn_Grave)
        Me.grpNarizCorn.Controls.Add(Me.chkHCorn_Moderado)
        Me.grpNarizCorn.Controls.Add(Me.chkHCorn_Leve)
        Me.grpNarizCorn.Location = New System.Drawing.Point(118, 924)
        Me.grpNarizCorn.Name = "grpNarizCorn"
        Me.grpNarizCorn.Size = New System.Drawing.Size(220, 32)
        Me.grpNarizCorn.TabIndex = 46
        Me.grpNarizCorn.TabStop = False
        '
        'chkHCorn_Grave
        '
        Me.chkHCorn_Grave.AutoSize = True
        Me.chkHCorn_Grave.Location = New System.Drawing.Point(13, 11)
        Me.chkHCorn_Grave.Name = "chkHCorn_Grave"
        Me.chkHCorn_Grave.Size = New System.Drawing.Size(55, 17)
        Me.chkHCorn_Grave.TabIndex = 205
        Me.chkHCorn_Grave.Text = "Grave"
        Me.chkHCorn_Grave.UseVisualStyleBackColor = True
        '
        'chkHCorn_Moderado
        '
        Me.chkHCorn_Moderado.AutoSize = True
        Me.chkHCorn_Moderado.Location = New System.Drawing.Point(77, 11)
        Me.chkHCorn_Moderado.Name = "chkHCorn_Moderado"
        Me.chkHCorn_Moderado.Size = New System.Drawing.Size(74, 17)
        Me.chkHCorn_Moderado.TabIndex = 207
        Me.chkHCorn_Moderado.Text = "Moderado"
        Me.chkHCorn_Moderado.UseVisualStyleBackColor = True
        '
        'chkHCorn_Leve
        '
        Me.chkHCorn_Leve.AutoSize = True
        Me.chkHCorn_Leve.Location = New System.Drawing.Point(156, 11)
        Me.chkHCorn_Leve.Name = "chkHCorn_Leve"
        Me.chkHCorn_Leve.Size = New System.Drawing.Size(50, 17)
        Me.chkHCorn_Leve.TabIndex = 208
        Me.chkHCorn_Leve.Text = "Leve"
        Me.chkHCorn_Leve.UseVisualStyleBackColor = True
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Black
        Me.Label70.Location = New System.Drawing.Point(35, 932)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(78, 19)
        Me.Label70.TabIndex = 398
        Me.Label70.Text = "Hiper. Corn."
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Red
        Me.Label69.Location = New System.Drawing.Point(24, 1049)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(177, 19)
        Me.Label69.TabIndex = 397
        Me.Label69.Text = "DATOS LABORATORIO"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(39, 857)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(76, 35)
        Me.Label40.TabIndex = 396
        Me.Label40.Text = "En respiracion normal"
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Red
        Me.Label68.Location = New System.Drawing.Point(648, 629)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(177, 19)
        Me.Label68.TabIndex = 395
        Me.Label68.Text = "SIGNOS ESPECIALES"
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Red
        Me.Label67.Location = New System.Drawing.Point(22, 629)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(177, 19)
        Me.Label67.TabIndex = 394
        Me.Label67.Text = "ANTECEDENTES FAMILIARES"
        '
        'grp_AccAsmaticos
        '
        Me.grp_AccAsmaticos.Controls.Add(Me.chk4_Disnea)
        Me.grp_AccAsmaticos.Controls.Add(Me.chk4_Diurnos)
        Me.grp_AccAsmaticos.Controls.Add(Me.chk4_Nocturnos)
        Me.grp_AccAsmaticos.Controls.Add(Me.chk4_Roncus)
        Me.grp_AccAsmaticos.Controls.Add(Me.chk4_Sibilanc)
        Me.grp_AccAsmaticos.Location = New System.Drawing.Point(589, 455)
        Me.grp_AccAsmaticos.Name = "grp_AccAsmaticos"
        Me.grp_AccAsmaticos.Size = New System.Drawing.Size(337, 34)
        Me.grp_AccAsmaticos.TabIndex = 29
        Me.grp_AccAsmaticos.TabStop = False
        '
        'chk4_Disnea
        '
        Me.chk4_Disnea.AutoSize = True
        Me.chk4_Disnea.Location = New System.Drawing.Point(276, 10)
        Me.chk4_Disnea.Name = "chk4_Disnea"
        Me.chk4_Disnea.Size = New System.Drawing.Size(59, 17)
        Me.chk4_Disnea.TabIndex = 239
        Me.chk4_Disnea.Text = "Disnea"
        Me.chk4_Disnea.UseVisualStyleBackColor = True
        '
        'chk4_Diurnos
        '
        Me.chk4_Diurnos.AutoSize = True
        Me.chk4_Diurnos.Location = New System.Drawing.Point(6, 10)
        Me.chk4_Diurnos.Name = "chk4_Diurnos"
        Me.chk4_Diurnos.Size = New System.Drawing.Size(62, 17)
        Me.chk4_Diurnos.TabIndex = 235
        Me.chk4_Diurnos.Text = "Diurnos"
        Me.chk4_Diurnos.UseVisualStyleBackColor = True
        '
        'chk4_Nocturnos
        '
        Me.chk4_Nocturnos.AutoSize = True
        Me.chk4_Nocturnos.Location = New System.Drawing.Point(70, 10)
        Me.chk4_Nocturnos.Name = "chk4_Nocturnos"
        Me.chk4_Nocturnos.Size = New System.Drawing.Size(75, 17)
        Me.chk4_Nocturnos.TabIndex = 236
        Me.chk4_Nocturnos.Text = "Nocturnos"
        Me.chk4_Nocturnos.UseVisualStyleBackColor = True
        '
        'chk4_Roncus
        '
        Me.chk4_Roncus.AutoSize = True
        Me.chk4_Roncus.Location = New System.Drawing.Point(146, 10)
        Me.chk4_Roncus.Name = "chk4_Roncus"
        Me.chk4_Roncus.Size = New System.Drawing.Size(63, 17)
        Me.chk4_Roncus.TabIndex = 237
        Me.chk4_Roncus.Text = "Roncus"
        Me.chk4_Roncus.UseVisualStyleBackColor = True
        '
        'chk4_Sibilanc
        '
        Me.chk4_Sibilanc.AutoSize = True
        Me.chk4_Sibilanc.Location = New System.Drawing.Point(212, 10)
        Me.chk4_Sibilanc.Name = "chk4_Sibilanc"
        Me.chk4_Sibilanc.Size = New System.Drawing.Size(63, 17)
        Me.chk4_Sibilanc.TabIndex = 238
        Me.chk4_Sibilanc.Text = "Sibilanc"
        Me.chk4_Sibilanc.UseVisualStyleBackColor = True
        '
        'grp_SinBoca
        '
        Me.grp_SinBoca.Controls.Add(Me.chkB_Ronca)
        Me.grp_SinBoca.Controls.Add(Me.chkB_RespOral)
        Me.grp_SinBoca.Controls.Add(Me.chkB_DurmeBAbierta)
        Me.grp_SinBoca.Location = New System.Drawing.Point(443, 383)
        Me.grp_SinBoca.Name = "grp_SinBoca"
        Me.grp_SinBoca.Size = New System.Drawing.Size(281, 31)
        Me.grp_SinBoca.TabIndex = 26
        Me.grp_SinBoca.TabStop = False
        '
        'chkB_Ronca
        '
        Me.chkB_Ronca.AutoSize = True
        Me.chkB_Ronca.Location = New System.Drawing.Point(82, 11)
        Me.chkB_Ronca.Name = "chkB_Ronca"
        Me.chkB_Ronca.Size = New System.Drawing.Size(58, 17)
        Me.chkB_Ronca.TabIndex = 223
        Me.chkB_Ronca.Text = "Ronca"
        Me.chkB_Ronca.UseVisualStyleBackColor = True
        '
        'chkB_RespOral
        '
        Me.chkB_RespOral.AutoSize = True
        Me.chkB_RespOral.Location = New System.Drawing.Point(8, 11)
        Me.chkB_RespOral.Name = "chkB_RespOral"
        Me.chkB_RespOral.Size = New System.Drawing.Size(76, 17)
        Me.chkB_RespOral.TabIndex = 221
        Me.chkB_RespOral.Text = "Resp. Oral"
        Me.chkB_RespOral.UseVisualStyleBackColor = True
        '
        'chkB_DurmeBAbierta
        '
        Me.chkB_DurmeBAbierta.AutoSize = True
        Me.chkB_DurmeBAbierta.Location = New System.Drawing.Point(148, 11)
        Me.chkB_DurmeBAbierta.Name = "chkB_DurmeBAbierta"
        Me.chkB_DurmeBAbierta.Size = New System.Drawing.Size(125, 17)
        Me.chkB_DurmeBAbierta.TabIndex = 224
        Me.chkB_DurmeBAbierta.Text = "Duerme boca abierta"
        Me.chkB_DurmeBAbierta.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(397, 393)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(40, 20)
        Me.Label66.TabIndex = 392
        Me.Label66.Text = "BOCA"
        '
        'grp_SinEstornuodos
        '
        Me.grp_SinEstornuodos.Controls.Add(Me.chkCE_No)
        Me.grp_SinEstornuodos.Controls.Add(Me.chkCE_Raro)
        Me.grp_SinEstornuodos.Controls.Add(Me.chkCE_Frecuente)
        Me.grp_SinEstornuodos.Location = New System.Drawing.Point(119, 383)
        Me.grp_SinEstornuodos.Name = "grp_SinEstornuodos"
        Me.grp_SinEstornuodos.Size = New System.Drawing.Size(271, 31)
        Me.grp_SinEstornuodos.TabIndex = 25
        Me.grp_SinEstornuodos.TabStop = False
        '
        'chkCE_No
        '
        Me.chkCE_No.AutoSize = True
        Me.chkCE_No.Location = New System.Drawing.Point(8, 11)
        Me.chkCE_No.Name = "chkCE_No"
        Me.chkCE_No.Size = New System.Drawing.Size(40, 17)
        Me.chkCE_No.TabIndex = 221
        Me.chkCE_No.Text = "No"
        Me.chkCE_No.UseVisualStyleBackColor = True
        '
        'chkCE_Raro
        '
        Me.chkCE_Raro.AutoSize = True
        Me.chkCE_Raro.Location = New System.Drawing.Point(82, 11)
        Me.chkCE_Raro.Name = "chkCE_Raro"
        Me.chkCE_Raro.Size = New System.Drawing.Size(49, 17)
        Me.chkCE_Raro.TabIndex = 223
        Me.chkCE_Raro.Text = "Raro"
        Me.chkCE_Raro.UseVisualStyleBackColor = True
        '
        'chkCE_Frecuente
        '
        Me.chkCE_Frecuente.AutoSize = True
        Me.chkCE_Frecuente.Location = New System.Drawing.Point(166, 11)
        Me.chkCE_Frecuente.Name = "chkCE_Frecuente"
        Me.chkCE_Frecuente.Size = New System.Drawing.Size(74, 17)
        Me.chkCE_Frecuente.TabIndex = 224
        Me.chkCE_Frecuente.Text = "Frecuente"
        Me.chkCE_Frecuente.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(25, 389)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(80, 28)
        Me.Label65.TabIndex = 390
        Me.Label65.Text = "CRISIS DE ESTORNUDOS"
        '
        'grp_SinNariz
        '
        Me.grp_SinNariz.Controls.Add(Me.chkSN_ObtNasal)
        Me.grp_SinNariz.Controls.Add(Me.chkSN_Rinorrea)
        Me.grp_SinNariz.Controls.Add(Me.chkSN_Acuosa)
        Me.grp_SinNariz.Controls.Add(Me.chkSN_Densa)
        Me.grp_SinNariz.Controls.Add(Me.chkSN_Resequedad)
        Me.grp_SinNariz.Controls.Add(Me.chkSN_Purulenta)
        Me.grp_SinNariz.Location = New System.Drawing.Point(443, 349)
        Me.grp_SinNariz.Name = "grp_SinNariz"
        Me.grp_SinNariz.Size = New System.Drawing.Size(484, 31)
        Me.grp_SinNariz.TabIndex = 24
        Me.grp_SinNariz.TabStop = False
        '
        'chkSN_ObtNasal
        '
        Me.chkSN_ObtNasal.AutoSize = True
        Me.chkSN_ObtNasal.Location = New System.Drawing.Point(378, 10)
        Me.chkSN_ObtNasal.Name = "chkSN_ObtNasal"
        Me.chkSN_ObtNasal.Size = New System.Drawing.Size(97, 17)
        Me.chkSN_ObtNasal.TabIndex = 227
        Me.chkSN_ObtNasal.Text = "Obtrucc. Nasal"
        Me.chkSN_ObtNasal.UseVisualStyleBackColor = True
        '
        'chkSN_Rinorrea
        '
        Me.chkSN_Rinorrea.AutoSize = True
        Me.chkSN_Rinorrea.Location = New System.Drawing.Point(7, 11)
        Me.chkSN_Rinorrea.Name = "chkSN_Rinorrea"
        Me.chkSN_Rinorrea.Size = New System.Drawing.Size(66, 17)
        Me.chkSN_Rinorrea.TabIndex = 221
        Me.chkSN_Rinorrea.Text = "Rinorrea"
        Me.chkSN_Rinorrea.UseVisualStyleBackColor = True
        '
        'chkSN_Acuosa
        '
        Me.chkSN_Acuosa.AutoSize = True
        Me.chkSN_Acuosa.Location = New System.Drawing.Point(81, 11)
        Me.chkSN_Acuosa.Name = "chkSN_Acuosa"
        Me.chkSN_Acuosa.Size = New System.Drawing.Size(62, 17)
        Me.chkSN_Acuosa.TabIndex = 223
        Me.chkSN_Acuosa.Text = "Acuosa"
        Me.chkSN_Acuosa.UseVisualStyleBackColor = True
        '
        'chkSN_Densa
        '
        Me.chkSN_Densa.AutoSize = True
        Me.chkSN_Densa.Location = New System.Drawing.Point(148, 11)
        Me.chkSN_Densa.Name = "chkSN_Densa"
        Me.chkSN_Densa.Size = New System.Drawing.Size(57, 17)
        Me.chkSN_Densa.TabIndex = 224
        Me.chkSN_Densa.Text = "Densa"
        Me.chkSN_Densa.UseVisualStyleBackColor = True
        '
        'chkSN_Resequedad
        '
        Me.chkSN_Resequedad.AutoSize = True
        Me.chkSN_Resequedad.Location = New System.Drawing.Point(287, 11)
        Me.chkSN_Resequedad.Name = "chkSN_Resequedad"
        Me.chkSN_Resequedad.Size = New System.Drawing.Size(87, 17)
        Me.chkSN_Resequedad.TabIndex = 226
        Me.chkSN_Resequedad.Text = "Resequedad"
        Me.chkSN_Resequedad.UseVisualStyleBackColor = True
        '
        'chkSN_Purulenta
        '
        Me.chkSN_Purulenta.AutoSize = True
        Me.chkSN_Purulenta.Location = New System.Drawing.Point(211, 11)
        Me.chkSN_Purulenta.Name = "chkSN_Purulenta"
        Me.chkSN_Purulenta.Size = New System.Drawing.Size(71, 17)
        Me.chkSN_Purulenta.TabIndex = 225
        Me.chkSN_Purulenta.Text = "Purulenta"
        Me.chkSN_Purulenta.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(397, 359)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 17)
        Me.Label32.TabIndex = 388
        Me.Label32.Text = "NARIZ"
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Red
        Me.Label64.Location = New System.Drawing.Point(19, 335)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(177, 19)
        Me.Label64.TabIndex = 387
        Me.Label64.Text = "SINTOMAS SOBRESALIENTES"
        '
        'grp_Menstruacion
        '
        Me.grp_Menstruacion.Controls.Add(Me.chkM_Toma)
        Me.grp_Menstruacion.Controls.Add(Me.txt_MenstruToma)
        Me.grp_Menstruacion.Controls.Add(Me.chkM_Colico)
        Me.grp_Menstruacion.Controls.Add(Me.chkM_Cefalea)
        Me.grp_Menstruacion.Controls.Add(Me.chkM_Migrana)
        Me.grp_Menstruacion.Location = New System.Drawing.Point(119, 300)
        Me.grp_Menstruacion.Name = "grp_Menstruacion"
        Me.grp_Menstruacion.Size = New System.Drawing.Size(807, 32)
        Me.grp_Menstruacion.TabIndex = 22
        Me.grp_Menstruacion.TabStop = False
        '
        'chkM_Toma
        '
        Me.chkM_Toma.AutoSize = True
        Me.chkM_Toma.Location = New System.Drawing.Point(198, 10)
        Me.chkM_Toma.Name = "chkM_Toma"
        Me.chkM_Toma.Size = New System.Drawing.Size(57, 17)
        Me.chkM_Toma.TabIndex = 389
        Me.chkM_Toma.Text = "TOMA"
        Me.chkM_Toma.UseVisualStyleBackColor = True
        '
        'txt_MenstruToma
        '
        Me.txt_MenstruToma.BackColor = System.Drawing.Color.White
        Me.txt_MenstruToma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MenstruToma.Location = New System.Drawing.Point(258, 7)
        Me.txt_MenstruToma.Multiline = True
        Me.txt_MenstruToma.Name = "txt_MenstruToma"
        Me.txt_MenstruToma.Size = New System.Drawing.Size(278, 21)
        Me.txt_MenstruToma.TabIndex = 388
        '
        'chkM_Colico
        '
        Me.chkM_Colico.AutoSize = True
        Me.chkM_Colico.Location = New System.Drawing.Point(8, 10)
        Me.chkM_Colico.Name = "chkM_Colico"
        Me.chkM_Colico.Size = New System.Drawing.Size(55, 17)
        Me.chkM_Colico.TabIndex = 213
        Me.chkM_Colico.Text = "Cólico"
        Me.chkM_Colico.UseVisualStyleBackColor = True
        '
        'chkM_Cefalea
        '
        Me.chkM_Cefalea.AutoSize = True
        Me.chkM_Cefalea.Location = New System.Drawing.Point(67, 10)
        Me.chkM_Cefalea.Name = "chkM_Cefalea"
        Me.chkM_Cefalea.Size = New System.Drawing.Size(62, 17)
        Me.chkM_Cefalea.TabIndex = 215
        Me.chkM_Cefalea.Text = "Cefalea"
        Me.chkM_Cefalea.UseVisualStyleBackColor = True
        '
        'chkM_Migrana
        '
        Me.chkM_Migrana.AutoSize = True
        Me.chkM_Migrana.Location = New System.Drawing.Point(133, 10)
        Me.chkM_Migrana.Name = "chkM_Migrana"
        Me.chkM_Migrana.Size = New System.Drawing.Size(64, 17)
        Me.chkM_Migrana.TabIndex = 217
        Me.chkM_Migrana.Text = "Migraña"
        Me.chkM_Migrana.UseVisualStyleBackColor = True
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(23, 313)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(99, 16)
        Me.Label63.TabIndex = 385
        Me.Label63.Text = "MENSTRUACION"
        '
        'txt_Cirugias
        '
        Me.txt_Cirugias.BackColor = System.Drawing.Color.White
        Me.txt_Cirugias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cirugias.Location = New System.Drawing.Point(764, 245)
        Me.txt_Cirugias.Multiline = True
        Me.txt_Cirugias.Name = "txt_Cirugias"
        Me.txt_Cirugias.Size = New System.Drawing.Size(164, 21)
        Me.txt_Cirugias.TabIndex = 20
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(709, 249)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(59, 19)
        Me.Label62.TabIndex = 383
        Me.Label62.Text = "CIRUGIAS"
        '
        'txt_TTo_Antec
        '
        Me.txt_TTo_Antec.BackColor = System.Drawing.Color.White
        Me.txt_TTo_Antec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TTo_Antec.Location = New System.Drawing.Point(553, 246)
        Me.txt_TTo_Antec.Multiline = True
        Me.txt_TTo_Antec.Name = "txt_TTo_Antec"
        Me.txt_TTo_Antec.Size = New System.Drawing.Size(152, 21)
        Me.txt_TTo_Antec.TabIndex = 19
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(504, 248)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(38, 19)
        Me.Label61.TabIndex = 381
        Me.Label61.Text = "TTo"
        '
        'txt_OtrasEnfer
        '
        Me.txt_OtrasEnfer.BackColor = System.Drawing.Color.White
        Me.txt_OtrasEnfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_OtrasEnfer.Location = New System.Drawing.Point(118, 245)
        Me.txt_OtrasEnfer.Multiline = True
        Me.txt_OtrasEnfer.Name = "txt_OtrasEnfer"
        Me.txt_OtrasEnfer.Size = New System.Drawing.Size(383, 21)
        Me.txt_OtrasEnfer.TabIndex = 18
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(23, 247)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(54, 19)
        Me.Label60.TabIndex = 379
        Me.Label60.Text = "OTRAS"
        '
        'txt_EnferInfecc
        '
        Me.txt_EnferInfecc.BackColor = System.Drawing.Color.White
        Me.txt_EnferInfecc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_EnferInfecc.Location = New System.Drawing.Point(798, 219)
        Me.txt_EnferInfecc.Multiline = True
        Me.txt_EnferInfecc.Name = "txt_EnferInfecc"
        Me.txt_EnferInfecc.Size = New System.Drawing.Size(130, 21)
        Me.txt_EnferInfecc.TabIndex = 17
        '
        'txt_Cancer
        '
        Me.txt_Cancer.BackColor = System.Drawing.Color.White
        Me.txt_Cancer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cancer.Location = New System.Drawing.Point(554, 219)
        Me.txt_Cancer.Multiline = True
        Me.txt_Cancer.Name = "txt_Cancer"
        Me.txt_Cancer.Size = New System.Drawing.Size(152, 21)
        Me.txt_Cancer.TabIndex = 16
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Red
        Me.Label58.Location = New System.Drawing.Point(19, 4)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(97, 17)
        Me.Label58.TabIndex = 375
        Me.Label58.Text = "ANAMNESIS"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(505, 221)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(54, 19)
        Me.Label57.TabIndex = 373
        Me.Label57.Text = "CANCER"
        '
        'cmb_EnfToroideas
        '
        Me.cmb_EnfToroideas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EnfToroideas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_EnfToroideas.Items.AddRange(New Object() {"Ninguna", "Hipotiroidismo", "Hipertiroidismo", "Otras"})
        Me.cmb_EnfToroideas.Location = New System.Drawing.Point(357, 218)
        Me.cmb_EnfToroideas.Name = "cmb_EnfToroideas"
        Me.cmb_EnfToroideas.Size = New System.Drawing.Size(144, 21)
        Me.cmb_EnfToroideas.TabIndex = 15
        '
        'cmb_APP
        '
        Me.cmb_APP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_APP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_APP.Items.AddRange(New Object() {"Ninguno", "Hipertensión HTA", "Diabetes Melitus DM", "Cardiopatias", "Otros"})
        Me.cmb_APP.Location = New System.Drawing.Point(118, 218)
        Me.cmb_APP.Name = "cmb_APP"
        Me.cmb_APP.Size = New System.Drawing.Size(148, 21)
        Me.cmb_APP.TabIndex = 14
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(22, 221)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(51, 19)
        Me.Label55.TabIndex = 369
        Me.Label55.Text = "APP"
        '
        'txt_TiemHab
        '
        Me.txt_TiemHab.BackColor = System.Drawing.Color.White
        Me.txt_TiemHab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TiemHab.Location = New System.Drawing.Point(842, 51)
        Me.txt_TiemHab.Multiline = True
        Me.txt_TiemHab.Name = "txt_TiemHab"
        Me.txt_TiemHab.Size = New System.Drawing.Size(86, 21)
        Me.txt_TiemHab.TabIndex = 7
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(797, 54)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(51, 19)
        Me.Label54.TabIndex = 367
        Me.Label54.Text = "TIEMPO:"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(779, 749)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(55, 20)
        Me.Label50.TabIndex = 366
        Me.Label50.Text = "Lagrimeo"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label51.Location = New System.Drawing.Point(779, 690)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(55, 18)
        Me.Label51.TabIndex = 365
        Me.Label51.Text = "Irreg."
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(779, 671)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(55, 20)
        Me.Label52.TabIndex = 364
        Me.Label52.Text = "Izq."
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(779, 651)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(55, 18)
        Me.Label53.TabIndex = 363
        Me.Label53.Text = "Escrotal"
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(648, 810)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 18)
        Me.Label47.TabIndex = 362
        Me.Label47.Text = "Saludo alergico"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(648, 790)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(67, 20)
        Me.Label48.TabIndex = 361
        Me.Label48.Text = "S Darier"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(648, 770)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(85, 18)
        Me.Label49.TabIndex = 360
        Me.Label49.Text = "S de D Morgan"
        '
        'grp_SigEsp2
        '
        Me.grp_SigEsp2.Controls.Add(Me.chkSig2_1)
        Me.grp_SigEsp2.Controls.Add(Me.chkSig2_2)
        Me.grp_SigEsp2.Controls.Add(Me.chkSig2_3)
        Me.grp_SigEsp2.Controls.Add(Me.chkSig2_4)
        Me.grp_SigEsp2.Location = New System.Drawing.Point(840, 642)
        Me.grp_SigEsp2.Name = "grp_SigEsp2"
        Me.grp_SigEsp2.Size = New System.Drawing.Size(27, 186)
        Me.grp_SigEsp2.TabIndex = 42
        Me.grp_SigEsp2.TabStop = False
        '
        'chkSig2_1
        '
        Me.chkSig2_1.AutoSize = True
        Me.chkSig2_1.Location = New System.Drawing.Point(7, 10)
        Me.chkSig2_1.Name = "chkSig2_1"
        Me.chkSig2_1.Size = New System.Drawing.Size(15, 14)
        Me.chkSig2_1.TabIndex = 236
        Me.chkSig2_1.Tag = "ESCROTAL"
        Me.chkSig2_1.UseVisualStyleBackColor = True
        '
        'chkSig2_2
        '
        Me.chkSig2_2.AutoSize = True
        Me.chkSig2_2.Location = New System.Drawing.Point(7, 30)
        Me.chkSig2_2.Name = "chkSig2_2"
        Me.chkSig2_2.Size = New System.Drawing.Size(15, 14)
        Me.chkSig2_2.TabIndex = 244
        Me.chkSig2_2.Tag = "AMID. HIPER IZQUIERDA"
        Me.chkSig2_2.UseVisualStyleBackColor = True
        '
        'chkSig2_3
        '
        Me.chkSig2_3.AutoSize = True
        Me.chkSig2_3.Location = New System.Drawing.Point(7, 50)
        Me.chkSig2_3.Name = "chkSig2_3"
        Me.chkSig2_3.Size = New System.Drawing.Size(15, 14)
        Me.chkSig2_3.TabIndex = 245
        Me.chkSig2_3.Tag = "IRREGULAR"
        Me.chkSig2_3.UseVisualStyleBackColor = True
        '
        'chkSig2_4
        '
        Me.chkSig2_4.AutoSize = True
        Me.chkSig2_4.Location = New System.Drawing.Point(7, 110)
        Me.chkSig2_4.Name = "chkSig2_4"
        Me.chkSig2_4.Size = New System.Drawing.Size(15, 14)
        Me.chkSig2_4.TabIndex = 248
        Me.chkSig2_4.Tag = "LAGRIMEO"
        Me.chkSig2_4.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(648, 750)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(67, 20)
        Me.Label41.TabIndex = 357
        Me.Label41.Text = "Conjuntivas"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(648, 732)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(67, 18)
        Me.Label42.TabIndex = 356
        Me.Label42.Text = "Ganglios"
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(648, 711)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(67, 20)
        Me.Label43.TabIndex = 355
        Me.Label43.Text = "Con pus"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(648, 691)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(67, 18)
        Me.Label44.TabIndex = 354
        Me.Label44.Text = "Criptic"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(648, 672)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(92, 20)
        Me.Label45.TabIndex = 353
        Me.Label45.Text = "Amid Hiper Der."
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(648, 652)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(78, 18)
        Me.Label46.TabIndex = 352
        Me.Label46.Text = "Leng. Geogr"
        '
        'grp_Edema
        '
        Me.grp_Edema.Controls.Add(Me.chk_Ede7)
        Me.grp_Edema.Controls.Add(Me.chk_Ede6)
        Me.grp_Edema.Controls.Add(Me.chk_Ede1)
        Me.grp_Edema.Controls.Add(Me.chk_Ede5)
        Me.grp_Edema.Controls.Add(Me.chk_Ede2)
        Me.grp_Edema.Controls.Add(Me.chk_Ede4)
        Me.grp_Edema.Controls.Add(Me.chk_Ede3)
        Me.grp_Edema.Location = New System.Drawing.Point(428, 674)
        Me.grp_Edema.Name = "grp_Edema"
        Me.grp_Edema.Size = New System.Drawing.Size(27, 156)
        Me.grp_Edema.TabIndex = 40
        Me.grp_Edema.TabStop = False
        '
        'chk_Ede7
        '
        Me.chk_Ede7.AutoSize = True
        Me.chk_Ede7.Location = New System.Drawing.Point(6, 133)
        Me.chk_Ede7.Name = "chk_Ede7"
        Me.chk_Ede7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ede7.TabIndex = 285
        Me.chk_Ede7.Tag = "OTRO"
        Me.chk_Ede7.UseVisualStyleBackColor = True
        '
        'chk_Ede6
        '
        Me.chk_Ede6.AutoSize = True
        Me.chk_Ede6.Location = New System.Drawing.Point(6, 11)
        Me.chk_Ede6.Name = "chk_Ede6"
        Me.chk_Ede6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ede6.TabIndex = 284
        Me.chk_Ede6.Tag = "MADRE"
        Me.chk_Ede6.UseVisualStyleBackColor = True
        '
        'chk_Ede1
        '
        Me.chk_Ede1.AutoSize = True
        Me.chk_Ede1.Location = New System.Drawing.Point(6, 30)
        Me.chk_Ede1.Name = "chk_Ede1"
        Me.chk_Ede1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ede1.TabIndex = 279
        Me.chk_Ede1.Tag = "FAM. MATERNA"
        Me.chk_Ede1.UseVisualStyleBackColor = True
        '
        'chk_Ede5
        '
        Me.chk_Ede5.AutoSize = True
        Me.chk_Ede5.Location = New System.Drawing.Point(6, 52)
        Me.chk_Ede5.Name = "chk_Ede5"
        Me.chk_Ede5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ede5.TabIndex = 283
        Me.chk_Ede5.Tag = "PADRE"
        Me.chk_Ede5.UseVisualStyleBackColor = True
        '
        'chk_Ede2
        '
        Me.chk_Ede2.AutoSize = True
        Me.chk_Ede2.Location = New System.Drawing.Point(6, 71)
        Me.chk_Ede2.Name = "chk_Ede2"
        Me.chk_Ede2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ede2.TabIndex = 280
        Me.chk_Ede2.Tag = "FAM. PATERNA"
        Me.chk_Ede2.UseVisualStyleBackColor = True
        '
        'chk_Ede4
        '
        Me.chk_Ede4.AutoSize = True
        Me.chk_Ede4.Location = New System.Drawing.Point(6, 92)
        Me.chk_Ede4.Name = "chk_Ede4"
        Me.chk_Ede4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ede4.TabIndex = 282
        Me.chk_Ede4.Tag = "HERMANOS"
        Me.chk_Ede4.UseVisualStyleBackColor = True
        '
        'chk_Ede3
        '
        Me.chk_Ede3.AutoSize = True
        Me.chk_Ede3.Location = New System.Drawing.Point(6, 112)
        Me.chk_Ede3.Name = "chk_Ede3"
        Me.chk_Ede3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ede3.TabIndex = 281
        Me.chk_Ede3.Tag = "HIJOS"
        Me.chk_Ede3.UseVisualStyleBackColor = True
        '
        'grp_Migra
        '
        Me.grp_Migra.Controls.Add(Me.chk_Mig7)
        Me.grp_Migra.Controls.Add(Me.chk_Mig6)
        Me.grp_Migra.Controls.Add(Me.chk_Mig1)
        Me.grp_Migra.Controls.Add(Me.chk_Mig5)
        Me.grp_Migra.Controls.Add(Me.chk_Mig2)
        Me.grp_Migra.Controls.Add(Me.chk_Mig4)
        Me.grp_Migra.Controls.Add(Me.chk_Mig3)
        Me.grp_Migra.Location = New System.Drawing.Point(382, 673)
        Me.grp_Migra.Name = "grp_Migra"
        Me.grp_Migra.Size = New System.Drawing.Size(32, 156)
        Me.grp_Migra.TabIndex = 39
        Me.grp_Migra.TabStop = False
        '
        'chk_Mig7
        '
        Me.chk_Mig7.AutoSize = True
        Me.chk_Mig7.Location = New System.Drawing.Point(6, 134)
        Me.chk_Mig7.Name = "chk_Mig7"
        Me.chk_Mig7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Mig7.TabIndex = 285
        Me.chk_Mig7.Tag = "OTRO"
        Me.chk_Mig7.UseVisualStyleBackColor = True
        '
        'chk_Mig6
        '
        Me.chk_Mig6.AutoSize = True
        Me.chk_Mig6.Location = New System.Drawing.Point(6, 13)
        Me.chk_Mig6.Name = "chk_Mig6"
        Me.chk_Mig6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Mig6.TabIndex = 284
        Me.chk_Mig6.Tag = "MADRE"
        Me.chk_Mig6.UseVisualStyleBackColor = True
        '
        'chk_Mig1
        '
        Me.chk_Mig1.AutoSize = True
        Me.chk_Mig1.Location = New System.Drawing.Point(6, 32)
        Me.chk_Mig1.Name = "chk_Mig1"
        Me.chk_Mig1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Mig1.TabIndex = 279
        Me.chk_Mig1.Tag = "FAM. MATERNA"
        Me.chk_Mig1.UseVisualStyleBackColor = True
        '
        'chk_Mig5
        '
        Me.chk_Mig5.AutoSize = True
        Me.chk_Mig5.Location = New System.Drawing.Point(6, 53)
        Me.chk_Mig5.Name = "chk_Mig5"
        Me.chk_Mig5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Mig5.TabIndex = 283
        Me.chk_Mig5.Tag = "PADRE"
        Me.chk_Mig5.UseVisualStyleBackColor = True
        '
        'chk_Mig2
        '
        Me.chk_Mig2.AutoSize = True
        Me.chk_Mig2.Location = New System.Drawing.Point(6, 74)
        Me.chk_Mig2.Name = "chk_Mig2"
        Me.chk_Mig2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Mig2.TabIndex = 280
        Me.chk_Mig2.Tag = "FAM. PATERNA"
        Me.chk_Mig2.UseVisualStyleBackColor = True
        '
        'chk_Mig4
        '
        Me.chk_Mig4.AutoSize = True
        Me.chk_Mig4.Location = New System.Drawing.Point(6, 94)
        Me.chk_Mig4.Name = "chk_Mig4"
        Me.chk_Mig4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Mig4.TabIndex = 282
        Me.chk_Mig4.Tag = "HERMANOS"
        Me.chk_Mig4.UseVisualStyleBackColor = True
        '
        'chk_Mig3
        '
        Me.chk_Mig3.AutoSize = True
        Me.chk_Mig3.Location = New System.Drawing.Point(6, 114)
        Me.chk_Mig3.Name = "chk_Mig3"
        Me.chk_Mig3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Mig3.TabIndex = 281
        Me.chk_Mig3.Tag = "HIJOS"
        Me.chk_Mig3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(56, 786)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 20)
        Me.Label18.TabIndex = 349
        Me.Label18.Text = "Hijos"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(56, 768)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 18)
        Me.Label19.TabIndex = 348
        Me.Label19.Text = "Hermanos"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(56, 747)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 20)
        Me.Label11.TabIndex = 347
        Me.Label11.Text = "F. Pat."
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(56, 727)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 18)
        Me.Label17.TabIndex = 346
        Me.Label17.Text = "Padre"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(56, 708)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 345
        Me.Label4.Text = "F. Mat."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(56, 688)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 344
        Me.Label3.Text = "Madre"
        '
        'grp_Drog
        '
        Me.grp_Drog.Controls.Add(Me.chk_Dro7)
        Me.grp_Drog.Controls.Add(Me.chk_Dro1)
        Me.grp_Drog.Controls.Add(Me.chk_Dro2)
        Me.grp_Drog.Controls.Add(Me.chk_Dro3)
        Me.grp_Drog.Controls.Add(Me.chk_Dro4)
        Me.grp_Drog.Controls.Add(Me.chk_Dro5)
        Me.grp_Drog.Controls.Add(Me.chk_Dro6)
        Me.grp_Drog.Location = New System.Drawing.Point(339, 673)
        Me.grp_Drog.Name = "grp_Drog"
        Me.grp_Drog.Size = New System.Drawing.Size(28, 156)
        Me.grp_Drog.TabIndex = 38
        Me.grp_Drog.TabStop = False
        '
        'chk_Dro7
        '
        Me.chk_Dro7.AutoSize = True
        Me.chk_Dro7.Location = New System.Drawing.Point(6, 133)
        Me.chk_Dro7.Name = "chk_Dro7"
        Me.chk_Dro7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Dro7.TabIndex = 279
        Me.chk_Dro7.Tag = "OTRO"
        Me.chk_Dro7.UseVisualStyleBackColor = True
        '
        'chk_Dro1
        '
        Me.chk_Dro1.AutoSize = True
        Me.chk_Dro1.Location = New System.Drawing.Point(6, 13)
        Me.chk_Dro1.Name = "chk_Dro1"
        Me.chk_Dro1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Dro1.TabIndex = 273
        Me.chk_Dro1.Tag = "MADRE"
        Me.chk_Dro1.UseVisualStyleBackColor = True
        '
        'chk_Dro2
        '
        Me.chk_Dro2.AutoSize = True
        Me.chk_Dro2.Location = New System.Drawing.Point(6, 33)
        Me.chk_Dro2.Name = "chk_Dro2"
        Me.chk_Dro2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Dro2.TabIndex = 274
        Me.chk_Dro2.Tag = "FAM. MATERNA"
        Me.chk_Dro2.UseVisualStyleBackColor = True
        '
        'chk_Dro3
        '
        Me.chk_Dro3.AutoSize = True
        Me.chk_Dro3.Location = New System.Drawing.Point(6, 53)
        Me.chk_Dro3.Name = "chk_Dro3"
        Me.chk_Dro3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Dro3.TabIndex = 275
        Me.chk_Dro3.Tag = "PADRE"
        Me.chk_Dro3.UseVisualStyleBackColor = True
        '
        'chk_Dro4
        '
        Me.chk_Dro4.AutoSize = True
        Me.chk_Dro4.Location = New System.Drawing.Point(6, 73)
        Me.chk_Dro4.Name = "chk_Dro4"
        Me.chk_Dro4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Dro4.TabIndex = 276
        Me.chk_Dro4.Tag = "FAM. PATERNA"
        Me.chk_Dro4.UseVisualStyleBackColor = True
        '
        'chk_Dro5
        '
        Me.chk_Dro5.AutoSize = True
        Me.chk_Dro5.Location = New System.Drawing.Point(6, 93)
        Me.chk_Dro5.Name = "chk_Dro5"
        Me.chk_Dro5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Dro5.TabIndex = 277
        Me.chk_Dro5.Tag = "HERMANOS"
        Me.chk_Dro5.UseVisualStyleBackColor = True
        '
        'chk_Dro6
        '
        Me.chk_Dro6.AutoSize = True
        Me.chk_Dro6.Location = New System.Drawing.Point(6, 113)
        Me.chk_Dro6.Name = "chk_Dro6"
        Me.chk_Dro6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Dro6.TabIndex = 278
        Me.chk_Dro6.Tag = "HIJOS"
        Me.chk_Dro6.UseVisualStyleBackColor = True
        '
        'grp_Conj
        '
        Me.grp_Conj.Controls.Add(Me.chk_Con7)
        Me.grp_Conj.Controls.Add(Me.chk_Con1)
        Me.grp_Conj.Controls.Add(Me.chk_Con2)
        Me.grp_Conj.Controls.Add(Me.chk_Con3)
        Me.grp_Conj.Controls.Add(Me.chk_Con4)
        Me.grp_Conj.Controls.Add(Me.chk_Con5)
        Me.grp_Conj.Controls.Add(Me.chk_Con6)
        Me.grp_Conj.Location = New System.Drawing.Point(291, 673)
        Me.grp_Conj.Name = "grp_Conj"
        Me.grp_Conj.Size = New System.Drawing.Size(28, 156)
        Me.grp_Conj.TabIndex = 37
        Me.grp_Conj.TabStop = False
        '
        'chk_Con7
        '
        Me.chk_Con7.AutoSize = True
        Me.chk_Con7.Location = New System.Drawing.Point(6, 134)
        Me.chk_Con7.Name = "chk_Con7"
        Me.chk_Con7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Con7.TabIndex = 273
        Me.chk_Con7.Tag = "OTRO"
        Me.chk_Con7.UseVisualStyleBackColor = True
        '
        'chk_Con1
        '
        Me.chk_Con1.AutoSize = True
        Me.chk_Con1.Location = New System.Drawing.Point(6, 13)
        Me.chk_Con1.Name = "chk_Con1"
        Me.chk_Con1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Con1.TabIndex = 267
        Me.chk_Con1.Tag = "MADRE"
        Me.chk_Con1.UseVisualStyleBackColor = True
        '
        'chk_Con2
        '
        Me.chk_Con2.AutoSize = True
        Me.chk_Con2.Location = New System.Drawing.Point(6, 33)
        Me.chk_Con2.Name = "chk_Con2"
        Me.chk_Con2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Con2.TabIndex = 268
        Me.chk_Con2.Tag = "FAM. MATERNA"
        Me.chk_Con2.UseVisualStyleBackColor = True
        '
        'chk_Con3
        '
        Me.chk_Con3.AutoSize = True
        Me.chk_Con3.Location = New System.Drawing.Point(6, 53)
        Me.chk_Con3.Name = "chk_Con3"
        Me.chk_Con3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Con3.TabIndex = 269
        Me.chk_Con3.Tag = "PADRE"
        Me.chk_Con3.UseVisualStyleBackColor = True
        '
        'chk_Con4
        '
        Me.chk_Con4.AutoSize = True
        Me.chk_Con4.Location = New System.Drawing.Point(6, 73)
        Me.chk_Con4.Name = "chk_Con4"
        Me.chk_Con4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Con4.TabIndex = 270
        Me.chk_Con4.Tag = "FAM. PATERNA"
        Me.chk_Con4.UseVisualStyleBackColor = True
        '
        'chk_Con5
        '
        Me.chk_Con5.AutoSize = True
        Me.chk_Con5.Location = New System.Drawing.Point(6, 93)
        Me.chk_Con5.Name = "chk_Con5"
        Me.chk_Con5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Con5.TabIndex = 271
        Me.chk_Con5.Tag = "HERMANOS"
        Me.chk_Con5.UseVisualStyleBackColor = True
        '
        'chk_Con6
        '
        Me.chk_Con6.AutoSize = True
        Me.chk_Con6.Location = New System.Drawing.Point(6, 113)
        Me.chk_Con6.Name = "chk_Con6"
        Me.chk_Con6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Con6.TabIndex = 272
        Me.chk_Con6.Tag = "HIJOS"
        Me.chk_Con6.UseVisualStyleBackColor = True
        '
        'grp_Urt
        '
        Me.grp_Urt.Controls.Add(Me.chk_Urt7)
        Me.grp_Urt.Controls.Add(Me.chk_Urt1)
        Me.grp_Urt.Controls.Add(Me.chk_Urt2)
        Me.grp_Urt.Controls.Add(Me.chk_Urt6)
        Me.grp_Urt.Controls.Add(Me.chk_Urt3)
        Me.grp_Urt.Controls.Add(Me.chk_Urt5)
        Me.grp_Urt.Controls.Add(Me.chk_Urt4)
        Me.grp_Urt.Location = New System.Drawing.Point(207, 674)
        Me.grp_Urt.Name = "grp_Urt"
        Me.grp_Urt.Size = New System.Drawing.Size(28, 155)
        Me.grp_Urt.TabIndex = 35
        Me.grp_Urt.TabStop = False
        '
        'chk_Urt7
        '
        Me.chk_Urt7.AutoSize = True
        Me.chk_Urt7.Location = New System.Drawing.Point(5, 133)
        Me.chk_Urt7.Name = "chk_Urt7"
        Me.chk_Urt7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Urt7.TabIndex = 7
        Me.chk_Urt7.Tag = "OTRO"
        Me.chk_Urt7.UseVisualStyleBackColor = True
        '
        'chk_Urt1
        '
        Me.chk_Urt1.AutoSize = True
        Me.chk_Urt1.Location = New System.Drawing.Point(5, 12)
        Me.chk_Urt1.Name = "chk_Urt1"
        Me.chk_Urt1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Urt1.TabIndex = 1
        Me.chk_Urt1.Tag = "MADRE"
        Me.chk_Urt1.UseVisualStyleBackColor = True
        '
        'chk_Urt2
        '
        Me.chk_Urt2.AutoSize = True
        Me.chk_Urt2.Location = New System.Drawing.Point(5, 32)
        Me.chk_Urt2.Name = "chk_Urt2"
        Me.chk_Urt2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Urt2.TabIndex = 2
        Me.chk_Urt2.Tag = "FAM. MATERNA"
        Me.chk_Urt2.UseVisualStyleBackColor = True
        '
        'chk_Urt6
        '
        Me.chk_Urt6.AutoSize = True
        Me.chk_Urt6.Location = New System.Drawing.Point(5, 53)
        Me.chk_Urt6.Name = "chk_Urt6"
        Me.chk_Urt6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Urt6.TabIndex = 6
        Me.chk_Urt6.Tag = "PADRE"
        Me.chk_Urt6.UseVisualStyleBackColor = True
        '
        'chk_Urt3
        '
        Me.chk_Urt3.AutoSize = True
        Me.chk_Urt3.Location = New System.Drawing.Point(5, 73)
        Me.chk_Urt3.Name = "chk_Urt3"
        Me.chk_Urt3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Urt3.TabIndex = 3
        Me.chk_Urt3.Tag = "FAM. PATERNA"
        Me.chk_Urt3.UseVisualStyleBackColor = True
        '
        'chk_Urt5
        '
        Me.chk_Urt5.AutoSize = True
        Me.chk_Urt5.Location = New System.Drawing.Point(5, 93)
        Me.chk_Urt5.Name = "chk_Urt5"
        Me.chk_Urt5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Urt5.TabIndex = 5
        Me.chk_Urt5.Tag = "HERMANOS"
        Me.chk_Urt5.UseVisualStyleBackColor = True
        '
        'chk_Urt4
        '
        Me.chk_Urt4.AutoSize = True
        Me.chk_Urt4.Location = New System.Drawing.Point(5, 112)
        Me.chk_Urt4.Name = "chk_Urt4"
        Me.chk_Urt4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Urt4.TabIndex = 4
        Me.chk_Urt4.Tag = "HIJOS"
        Me.chk_Urt4.UseVisualStyleBackColor = True
        '
        'grp_Eccen
        '
        Me.grp_Eccen.Controls.Add(Me.chk_Ecc7)
        Me.grp_Eccen.Controls.Add(Me.chk_Ecc1)
        Me.grp_Eccen.Controls.Add(Me.chk_Ecc2)
        Me.grp_Eccen.Controls.Add(Me.chk_Ecc3)
        Me.grp_Eccen.Controls.Add(Me.chk_Ecc4)
        Me.grp_Eccen.Controls.Add(Me.chk_Ecc5)
        Me.grp_Eccen.Controls.Add(Me.chk_Ecc6)
        Me.grp_Eccen.Location = New System.Drawing.Point(249, 674)
        Me.grp_Eccen.Name = "grp_Eccen"
        Me.grp_Eccen.Size = New System.Drawing.Size(25, 155)
        Me.grp_Eccen.TabIndex = 36
        Me.grp_Eccen.TabStop = False
        '
        'chk_Ecc7
        '
        Me.chk_Ecc7.AutoSize = True
        Me.chk_Ecc7.Location = New System.Drawing.Point(7, 133)
        Me.chk_Ecc7.Name = "chk_Ecc7"
        Me.chk_Ecc7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ecc7.TabIndex = 267
        Me.chk_Ecc7.Tag = "OTRO"
        Me.chk_Ecc7.UseVisualStyleBackColor = True
        '
        'chk_Ecc1
        '
        Me.chk_Ecc1.AutoSize = True
        Me.chk_Ecc1.Location = New System.Drawing.Point(7, 12)
        Me.chk_Ecc1.Name = "chk_Ecc1"
        Me.chk_Ecc1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ecc1.TabIndex = 261
        Me.chk_Ecc1.Tag = "MADRE"
        Me.chk_Ecc1.UseVisualStyleBackColor = True
        '
        'chk_Ecc2
        '
        Me.chk_Ecc2.AutoSize = True
        Me.chk_Ecc2.Location = New System.Drawing.Point(7, 32)
        Me.chk_Ecc2.Name = "chk_Ecc2"
        Me.chk_Ecc2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ecc2.TabIndex = 262
        Me.chk_Ecc2.Tag = "FAM. MATERNA"
        Me.chk_Ecc2.UseVisualStyleBackColor = True
        '
        'chk_Ecc3
        '
        Me.chk_Ecc3.AutoSize = True
        Me.chk_Ecc3.Location = New System.Drawing.Point(7, 52)
        Me.chk_Ecc3.Name = "chk_Ecc3"
        Me.chk_Ecc3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ecc3.TabIndex = 263
        Me.chk_Ecc3.Tag = "PADRE"
        Me.chk_Ecc3.UseVisualStyleBackColor = True
        '
        'chk_Ecc4
        '
        Me.chk_Ecc4.AutoSize = True
        Me.chk_Ecc4.Location = New System.Drawing.Point(7, 72)
        Me.chk_Ecc4.Name = "chk_Ecc4"
        Me.chk_Ecc4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ecc4.TabIndex = 264
        Me.chk_Ecc4.Tag = "FAM. PATERNA"
        Me.chk_Ecc4.UseVisualStyleBackColor = True
        '
        'chk_Ecc5
        '
        Me.chk_Ecc5.AutoSize = True
        Me.chk_Ecc5.Location = New System.Drawing.Point(7, 92)
        Me.chk_Ecc5.Name = "chk_Ecc5"
        Me.chk_Ecc5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ecc5.TabIndex = 265
        Me.chk_Ecc5.Tag = "HERMANOS"
        Me.chk_Ecc5.UseVisualStyleBackColor = True
        '
        'chk_Ecc6
        '
        Me.chk_Ecc6.AutoSize = True
        Me.chk_Ecc6.Location = New System.Drawing.Point(7, 112)
        Me.chk_Ecc6.Name = "chk_Ecc6"
        Me.chk_Ecc6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Ecc6.TabIndex = 266
        Me.chk_Ecc6.Tag = "HIJOS"
        Me.chk_Ecc6.UseVisualStyleBackColor = True
        '
        'grp_Rini
        '
        Me.grp_Rini.Controls.Add(Me.chk_Rin7)
        Me.grp_Rini.Controls.Add(Me.chk_Rin1)
        Me.grp_Rini.Controls.Add(Me.chk_Rin2)
        Me.grp_Rini.Controls.Add(Me.chk_Rin3)
        Me.grp_Rini.Controls.Add(Me.chk_Rin4)
        Me.grp_Rini.Controls.Add(Me.chk_Rin5)
        Me.grp_Rini.Controls.Add(Me.chk_Rin6)
        Me.grp_Rini.Location = New System.Drawing.Point(165, 675)
        Me.grp_Rini.Name = "grp_Rini"
        Me.grp_Rini.Size = New System.Drawing.Size(25, 153)
        Me.grp_Rini.TabIndex = 34
        Me.grp_Rini.TabStop = False
        '
        'chk_Rin7
        '
        Me.chk_Rin7.AutoSize = True
        Me.chk_Rin7.Location = New System.Drawing.Point(8, 132)
        Me.chk_Rin7.Name = "chk_Rin7"
        Me.chk_Rin7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rin7.TabIndex = 7
        Me.chk_Rin7.Tag = "OTRO"
        Me.chk_Rin7.UseVisualStyleBackColor = True
        '
        'chk_Rin1
        '
        Me.chk_Rin1.AutoSize = True
        Me.chk_Rin1.Location = New System.Drawing.Point(8, 11)
        Me.chk_Rin1.Name = "chk_Rin1"
        Me.chk_Rin1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rin1.TabIndex = 1
        Me.chk_Rin1.Tag = "MADRE"
        Me.chk_Rin1.UseVisualStyleBackColor = True
        '
        'chk_Rin2
        '
        Me.chk_Rin2.AutoSize = True
        Me.chk_Rin2.Location = New System.Drawing.Point(8, 31)
        Me.chk_Rin2.Name = "chk_Rin2"
        Me.chk_Rin2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rin2.TabIndex = 2
        Me.chk_Rin2.Tag = "FAM. MATERNA"
        Me.chk_Rin2.UseVisualStyleBackColor = True
        '
        'chk_Rin3
        '
        Me.chk_Rin3.AutoSize = True
        Me.chk_Rin3.Location = New System.Drawing.Point(8, 51)
        Me.chk_Rin3.Name = "chk_Rin3"
        Me.chk_Rin3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rin3.TabIndex = 3
        Me.chk_Rin3.Tag = "PADRE"
        Me.chk_Rin3.UseVisualStyleBackColor = True
        '
        'chk_Rin4
        '
        Me.chk_Rin4.AutoSize = True
        Me.chk_Rin4.Location = New System.Drawing.Point(8, 71)
        Me.chk_Rin4.Name = "chk_Rin4"
        Me.chk_Rin4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rin4.TabIndex = 4
        Me.chk_Rin4.Tag = "FAM. PATERNA"
        Me.chk_Rin4.UseVisualStyleBackColor = True
        '
        'chk_Rin5
        '
        Me.chk_Rin5.AutoSize = True
        Me.chk_Rin5.Location = New System.Drawing.Point(8, 91)
        Me.chk_Rin5.Name = "chk_Rin5"
        Me.chk_Rin5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rin5.TabIndex = 5
        Me.chk_Rin5.Tag = "HERMANOS"
        Me.chk_Rin5.UseVisualStyleBackColor = True
        '
        'chk_Rin6
        '
        Me.chk_Rin6.AutoSize = True
        Me.chk_Rin6.Location = New System.Drawing.Point(8, 111)
        Me.chk_Rin6.Name = "chk_Rin6"
        Me.chk_Rin6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Rin6.TabIndex = 6
        Me.chk_Rin6.Tag = "HIJOS"
        Me.chk_Rin6.UseVisualStyleBackColor = True
        '
        'grp_Asma
        '
        Me.grp_Asma.Controls.Add(Me.chk_Asm7)
        Me.grp_Asma.Controls.Add(Me.chk_Asm1)
        Me.grp_Asma.Controls.Add(Me.chk_Asm2)
        Me.grp_Asma.Controls.Add(Me.chk_Asm3)
        Me.grp_Asma.Controls.Add(Me.chk_Asm4)
        Me.grp_Asma.Controls.Add(Me.chk_Asm5)
        Me.grp_Asma.Controls.Add(Me.chk_Asm6)
        Me.grp_Asma.Location = New System.Drawing.Point(122, 676)
        Me.grp_Asma.Name = "grp_Asma"
        Me.grp_Asma.Size = New System.Drawing.Size(27, 152)
        Me.grp_Asma.TabIndex = 33
        Me.grp_Asma.TabStop = False
        '
        'chk_Asm7
        '
        Me.chk_Asm7.AutoSize = True
        Me.chk_Asm7.Location = New System.Drawing.Point(7, 131)
        Me.chk_Asm7.Name = "chk_Asm7"
        Me.chk_Asm7.Size = New System.Drawing.Size(15, 14)
        Me.chk_Asm7.TabIndex = 7
        Me.chk_Asm7.Tag = "OTRO"
        Me.chk_Asm7.UseVisualStyleBackColor = True
        '
        'chk_Asm1
        '
        Me.chk_Asm1.AutoSize = True
        Me.chk_Asm1.Location = New System.Drawing.Point(7, 10)
        Me.chk_Asm1.Name = "chk_Asm1"
        Me.chk_Asm1.Size = New System.Drawing.Size(15, 14)
        Me.chk_Asm1.TabIndex = 1
        Me.chk_Asm1.Tag = "MADRE"
        Me.chk_Asm1.UseVisualStyleBackColor = True
        '
        'chk_Asm2
        '
        Me.chk_Asm2.AutoSize = True
        Me.chk_Asm2.Location = New System.Drawing.Point(7, 30)
        Me.chk_Asm2.Name = "chk_Asm2"
        Me.chk_Asm2.Size = New System.Drawing.Size(15, 14)
        Me.chk_Asm2.TabIndex = 2
        Me.chk_Asm2.Tag = "FAM. MATERNA"
        Me.chk_Asm2.UseVisualStyleBackColor = True
        '
        'chk_Asm3
        '
        Me.chk_Asm3.AutoSize = True
        Me.chk_Asm3.Location = New System.Drawing.Point(7, 50)
        Me.chk_Asm3.Name = "chk_Asm3"
        Me.chk_Asm3.Size = New System.Drawing.Size(15, 14)
        Me.chk_Asm3.TabIndex = 3
        Me.chk_Asm3.Tag = "PADRE"
        Me.chk_Asm3.UseVisualStyleBackColor = True
        '
        'chk_Asm4
        '
        Me.chk_Asm4.AutoSize = True
        Me.chk_Asm4.Location = New System.Drawing.Point(7, 70)
        Me.chk_Asm4.Name = "chk_Asm4"
        Me.chk_Asm4.Size = New System.Drawing.Size(15, 14)
        Me.chk_Asm4.TabIndex = 4
        Me.chk_Asm4.Tag = "FAM. PATERNA"
        Me.chk_Asm4.UseVisualStyleBackColor = True
        '
        'chk_Asm5
        '
        Me.chk_Asm5.AutoSize = True
        Me.chk_Asm5.Location = New System.Drawing.Point(7, 90)
        Me.chk_Asm5.Name = "chk_Asm5"
        Me.chk_Asm5.Size = New System.Drawing.Size(15, 14)
        Me.chk_Asm5.TabIndex = 5
        Me.chk_Asm5.Tag = "HERMANOS"
        Me.chk_Asm5.UseVisualStyleBackColor = True
        '
        'chk_Asm6
        '
        Me.chk_Asm6.AutoSize = True
        Me.chk_Asm6.Location = New System.Drawing.Point(7, 110)
        Me.chk_Asm6.Name = "chk_Asm6"
        Me.chk_Asm6.Size = New System.Drawing.Size(15, 14)
        Me.chk_Asm6.TabIndex = 6
        Me.chk_Asm6.Tag = "HIJOS"
        Me.chk_Asm6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(119, 661)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 18)
        Me.Label2.TabIndex = 335
        Me.Label2.Text = "Asma    Riñitis   Urticaria  Eccem.   Conjunt.   Drogas  Migraña    Edema  "
        '
        'txt_HPsicoS
        '
        Me.txt_HPsicoS.BackColor = System.Drawing.Color.White
        Me.txt_HPsicoS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_HPsicoS.Location = New System.Drawing.Point(118, 137)
        Me.txt_HPsicoS.Multiline = True
        Me.txt_HPsicoS.Name = "txt_HPsicoS"
        Me.txt_HPsicoS.Size = New System.Drawing.Size(809, 33)
        Me.txt_HPsicoS.TabIndex = 12
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(21, 147)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(90, 16)
        Me.Label39.TabIndex = 317
        Me.Label39.Text = "HIST. PSICO S.:"
        '
        'txt_HSeg
        '
        Me.txt_HSeg.BackColor = System.Drawing.Color.White
        Me.txt_HSeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_HSeg.Location = New System.Drawing.Point(741, 111)
        Me.txt_HSeg.Multiline = True
        Me.txt_HSeg.Name = "txt_HSeg"
        Me.txt_HSeg.Size = New System.Drawing.Size(187, 21)
        Me.txt_HSeg.TabIndex = 11
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(676, 116)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(69, 13)
        Me.Label36.TabIndex = 315
        Me.Label36.Text = "Seguimiento"
        '
        'txt_HTToAnam
        '
        Me.txt_HTToAnam.BackColor = System.Drawing.Color.White
        Me.txt_HTToAnam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_HTToAnam.Location = New System.Drawing.Point(486, 111)
        Me.txt_HTToAnam.Multiline = True
        Me.txt_HTToAnam.Name = "txt_HTToAnam"
        Me.txt_HTToAnam.Size = New System.Drawing.Size(187, 21)
        Me.txt_HTToAnam.TabIndex = 10
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(454, 116)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(37, 13)
        Me.Label28.TabIndex = 313
        Me.Label28.Text = "TTo"
        '
        'txt_HisEnfeAct
        '
        Me.txt_HisEnfeAct.BackColor = System.Drawing.Color.White
        Me.txt_HisEnfeAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_HisEnfeAct.Location = New System.Drawing.Point(118, 111)
        Me.txt_HisEnfeAct.Multiline = True
        Me.txt_HisEnfeAct.Name = "txt_HisEnfeAct"
        Me.txt_HisEnfeAct.Size = New System.Drawing.Size(327, 21)
        Me.txt_HisEnfeAct.TabIndex = 9
        '
        'txt_HabiTox_Otro
        '
        Me.txt_HabiTox_Otro.BackColor = System.Drawing.Color.White
        Me.txt_HabiTox_Otro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_HabiTox_Otro.Location = New System.Drawing.Point(632, 52)
        Me.txt_HabiTox_Otro.Multiline = True
        Me.txt_HabiTox_Otro.Name = "txt_HabiTox_Otro"
        Me.txt_HabiTox_Otro.Size = New System.Drawing.Size(161, 21)
        Me.txt_HabiTox_Otro.TabIndex = 6
        '
        'cmb_HabTox
        '
        Me.cmb_HabTox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HabTox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HabTox.Items.AddRange(New Object() {"Ninguno", "Tabaquismo", "Alcoholismo", "Dependencia drogas", "Otros"})
        Me.cmb_HabTox.Location = New System.Drawing.Point(481, 51)
        Me.cmb_HabTox.Name = "cmb_HabTox"
        Me.cmb_HabTox.Size = New System.Drawing.Size(145, 21)
        Me.cmb_HabTox.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(372, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(118, 15)
        Me.Label27.TabIndex = 309
        Me.Label27.Text = "HABITOS TOXICOS:"
        '
        'txt_hcInmun
        '
        Me.txt_hcInmun.BackColor = System.Drawing.Color.White
        Me.txt_hcInmun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hcInmun.Location = New System.Drawing.Point(119, 52)
        Me.txt_hcInmun.Multiline = True
        Me.txt_hcInmun.Name = "txt_hcInmun"
        Me.txt_hcInmun.Size = New System.Drawing.Size(248, 21)
        Me.txt_hcInmun.TabIndex = 4
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(21, 54)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 19)
        Me.Label26.TabIndex = 307
        Me.Label26.Text = "INMUNIZACIONES"
        '
        'txt_hcHobbies
        '
        Me.txt_hcHobbies.BackColor = System.Drawing.Color.White
        Me.txt_hcHobbies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hcHobbies.Location = New System.Drawing.Point(573, 27)
        Me.txt_hcHobbies.Multiline = True
        Me.txt_hcHobbies.Name = "txt_hcHobbies"
        Me.txt_hcHobbies.Size = New System.Drawing.Size(357, 21)
        Me.txt_hcHobbies.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(515, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 13)
        Me.Label25.TabIndex = 305
        Me.Label25.Text = "HOBBIES:"
        '
        'cmb_zona
        '
        Me.cmb_zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_zona.FormattingEnabled = True
        Me.cmb_zona.Items.AddRange(New Object() {"Urbana", "Rural", "Suburbana", "Otra"})
        Me.cmb_zona.Location = New System.Drawing.Point(118, 26)
        Me.cmb_zona.Name = "cmb_zona"
        Me.cmb_zona.Size = New System.Drawing.Size(148, 21)
        Me.cmb_zona.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(21, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 19)
        Me.Label16.TabIndex = 303
        Me.Label16.Text = "ZONA"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(438, 1080)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 19)
        Me.Label22.TabIndex = 300
        Me.Label22.Text = "BIOPSIA"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(24, 1078)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 19)
        Me.Label21.TabIndex = 299
        Me.Label21.Text = "IMAGEN"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(26, 1013)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 19)
        Me.Label20.TabIndex = 298
        Me.Label20.Text = "PIEL"
        '
        'txt_LabBiopsia
        '
        Me.txt_LabBiopsia.BackColor = System.Drawing.Color.White
        Me.txt_LabBiopsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_LabBiopsia.Location = New System.Drawing.Point(491, 1078)
        Me.txt_LabBiopsia.Multiline = True
        Me.txt_LabBiopsia.Name = "txt_LabBiopsia"
        Me.txt_LabBiopsia.Size = New System.Drawing.Size(297, 49)
        Me.txt_LabBiopsia.TabIndex = 52
        '
        'txt_CampoPiel
        '
        Me.txt_CampoPiel.BackColor = System.Drawing.Color.White
        Me.txt_CampoPiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CampoPiel.Location = New System.Drawing.Point(75, 1011)
        Me.txt_CampoPiel.Multiline = True
        Me.txt_CampoPiel.Name = "txt_CampoPiel"
        Me.txt_CampoPiel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_CampoPiel.Size = New System.Drawing.Size(843, 35)
        Me.txt_CampoPiel.TabIndex = 50
        '
        'grp_Garganta
        '
        Me.grp_Garganta.Controls.Add(Me.chk10_Exudado)
        Me.grp_Garganta.Controls.Add(Me.chk10_Goteo)
        Me.grp_Garganta.Controls.Add(Me.chk10_Inflamada)
        Me.grp_Garganta.Controls.Add(Me.chk10_Granulosa)
        Me.grp_Garganta.Controls.Add(Me.chk10_SReflujo)
        Me.grp_Garganta.Location = New System.Drawing.Point(118, 970)
        Me.grp_Garganta.Name = "grp_Garganta"
        Me.grp_Garganta.Size = New System.Drawing.Size(403, 32)
        Me.grp_Garganta.TabIndex = 49
        Me.grp_Garganta.TabStop = False
        '
        'chk10_Exudado
        '
        Me.chk10_Exudado.AutoSize = True
        Me.chk10_Exudado.Location = New System.Drawing.Point(302, 11)
        Me.chk10_Exudado.Name = "chk10_Exudado"
        Me.chk10_Exudado.Size = New System.Drawing.Size(68, 17)
        Me.chk10_Exudado.TabIndex = 211
        Me.chk10_Exudado.Text = "Exudado"
        Me.chk10_Exudado.UseVisualStyleBackColor = True
        '
        'chk10_Goteo
        '
        Me.chk10_Goteo.AutoSize = True
        Me.chk10_Goteo.Location = New System.Drawing.Point(241, 11)
        Me.chk10_Goteo.Name = "chk10_Goteo"
        Me.chk10_Goteo.Size = New System.Drawing.Size(55, 17)
        Me.chk10_Goteo.TabIndex = 210
        Me.chk10_Goteo.Text = "Goteo"
        Me.chk10_Goteo.UseVisualStyleBackColor = True
        '
        'chk10_Inflamada
        '
        Me.chk10_Inflamada.AutoSize = True
        Me.chk10_Inflamada.Location = New System.Drawing.Point(13, 11)
        Me.chk10_Inflamada.Name = "chk10_Inflamada"
        Me.chk10_Inflamada.Size = New System.Drawing.Size(72, 17)
        Me.chk10_Inflamada.TabIndex = 205
        Me.chk10_Inflamada.Text = "Inflamada"
        Me.chk10_Inflamada.UseVisualStyleBackColor = True
        '
        'chk10_Granulosa
        '
        Me.chk10_Granulosa.AutoSize = True
        Me.chk10_Granulosa.Location = New System.Drawing.Point(86, 11)
        Me.chk10_Granulosa.Name = "chk10_Granulosa"
        Me.chk10_Granulosa.Size = New System.Drawing.Size(74, 17)
        Me.chk10_Granulosa.TabIndex = 207
        Me.chk10_Granulosa.Text = "Granulosa"
        Me.chk10_Granulosa.UseVisualStyleBackColor = True
        '
        'chk10_SReflujo
        '
        Me.chk10_SReflujo.AutoSize = True
        Me.chk10_SReflujo.Location = New System.Drawing.Point(163, 11)
        Me.chk10_SReflujo.Name = "chk10_SReflujo"
        Me.chk10_SReflujo.Size = New System.Drawing.Size(69, 17)
        Me.chk10_SReflujo.TabIndex = 209
        Me.chk10_SReflujo.Text = "S Reflujo"
        Me.chk10_SReflujo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(25, 977)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 19)
        Me.Label12.TabIndex = 292
        Me.Label12.Text = "GARGANTA"
        '
        'grp_Nariz
        '
        Me.grp_Nariz.Controls.Add(Me.txt_Obstr)
        Me.grp_Nariz.Controls.Add(Me.chk9_Edema)
        Me.grp_Nariz.Controls.Add(Me.chk9_Moco)
        Me.grp_Nariz.Controls.Add(Me.chk9_Obs)
        Me.grp_Nariz.Controls.Add(Me.chk9_Desv)
        Me.grp_Nariz.Location = New System.Drawing.Point(117, 892)
        Me.grp_Nariz.Name = "grp_Nariz"
        Me.grp_Nariz.Size = New System.Drawing.Size(327, 32)
        Me.grp_Nariz.TabIndex = 45
        Me.grp_Nariz.TabStop = False
        '
        'txt_Obstr
        '
        Me.txt_Obstr.BackColor = System.Drawing.Color.White
        Me.txt_Obstr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Obstr.Location = New System.Drawing.Point(211, 8)
        Me.txt_Obstr.Name = "txt_Obstr"
        Me.txt_Obstr.Size = New System.Drawing.Size(26, 20)
        Me.txt_Obstr.TabIndex = 337
        '
        'chk9_Edema
        '
        Me.chk9_Edema.AutoSize = True
        Me.chk9_Edema.Location = New System.Drawing.Point(13, 11)
        Me.chk9_Edema.Name = "chk9_Edema"
        Me.chk9_Edema.Size = New System.Drawing.Size(59, 17)
        Me.chk9_Edema.TabIndex = 205
        Me.chk9_Edema.Text = "Edema"
        Me.chk9_Edema.UseVisualStyleBackColor = True
        '
        'chk9_Moco
        '
        Me.chk9_Moco.AutoSize = True
        Me.chk9_Moco.Location = New System.Drawing.Point(77, 11)
        Me.chk9_Moco.Name = "chk9_Moco"
        Me.chk9_Moco.Size = New System.Drawing.Size(53, 17)
        Me.chk9_Moco.TabIndex = 207
        Me.chk9_Moco.Text = "Moco"
        Me.chk9_Moco.UseVisualStyleBackColor = True
        '
        'chk9_Obs
        '
        Me.chk9_Obs.AutoSize = True
        Me.chk9_Obs.Location = New System.Drawing.Point(137, 11)
        Me.chk9_Obs.Name = "chk9_Obs"
        Me.chk9_Obs.Size = New System.Drawing.Size(77, 17)
        Me.chk9_Obs.TabIndex = 208
        Me.chk9_Obs.Text = "% Obstruc."
        Me.chk9_Obs.UseVisualStyleBackColor = True
        '
        'chk9_Desv
        '
        Me.chk9_Desv.AutoSize = True
        Me.chk9_Desv.Location = New System.Drawing.Point(246, 11)
        Me.chk9_Desv.Name = "chk9_Desv"
        Me.chk9_Desv.Size = New System.Drawing.Size(76, 17)
        Me.chk9_Desv.TabIndex = 209
        Me.chk9_Desv.Text = "Desv. Tab"
        Me.chk9_Desv.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(26, 905)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 19)
        Me.Label10.TabIndex = 290
        Me.Label10.Text = "NARIZ"
        '
        'grp_ResForzada
        '
        Me.grp_ResForzada.Controls.Add(Me.chk8_Roncus)
        Me.grp_ResForzada.Controls.Add(Me.chk8_Sibilian)
        Me.grp_ResForzada.Controls.Add(Me.chk8_Tiraje)
        Me.grp_ResForzada.Controls.Add(Me.chk8_Tos)
        Me.grp_ResForzada.Location = New System.Drawing.Point(508, 852)
        Me.grp_ResForzada.Name = "grp_ResForzada"
        Me.grp_ResForzada.Size = New System.Drawing.Size(293, 32)
        Me.grp_ResForzada.TabIndex = 44
        Me.grp_ResForzada.TabStop = False
        '
        'chk8_Roncus
        '
        Me.chk8_Roncus.AutoSize = True
        Me.chk8_Roncus.Location = New System.Drawing.Point(13, 11)
        Me.chk8_Roncus.Name = "chk8_Roncus"
        Me.chk8_Roncus.Size = New System.Drawing.Size(63, 17)
        Me.chk8_Roncus.TabIndex = 205
        Me.chk8_Roncus.Text = "Roncus"
        Me.chk8_Roncus.UseVisualStyleBackColor = True
        '
        'chk8_Sibilian
        '
        Me.chk8_Sibilian.AutoSize = True
        Me.chk8_Sibilian.Location = New System.Drawing.Point(77, 11)
        Me.chk8_Sibilian.Name = "chk8_Sibilian"
        Me.chk8_Sibilian.Size = New System.Drawing.Size(59, 17)
        Me.chk8_Sibilian.TabIndex = 207
        Me.chk8_Sibilian.Text = "Sibilian"
        Me.chk8_Sibilian.UseVisualStyleBackColor = True
        '
        'chk8_Tiraje
        '
        Me.chk8_Tiraje.AutoSize = True
        Me.chk8_Tiraje.Location = New System.Drawing.Point(136, 11)
        Me.chk8_Tiraje.Name = "chk8_Tiraje"
        Me.chk8_Tiraje.Size = New System.Drawing.Size(52, 17)
        Me.chk8_Tiraje.TabIndex = 208
        Me.chk8_Tiraje.Text = "Tiraje"
        Me.chk8_Tiraje.UseVisualStyleBackColor = True
        '
        'chk8_Tos
        '
        Me.chk8_Tos.AutoSize = True
        Me.chk8_Tos.Location = New System.Drawing.Point(189, 11)
        Me.chk8_Tos.Name = "chk8_Tos"
        Me.chk8_Tos.Size = New System.Drawing.Size(44, 17)
        Me.chk8_Tos.TabIndex = 209
        Me.chk8_Tos.Text = "Tos"
        Me.chk8_Tos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(425, 857)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 31)
        Me.Label7.TabIndex = 289
        Me.Label7.Text = "En respiracion forzada"
        '
        'grp_ResNormal
        '
        Me.grp_ResNormal.Controls.Add(Me.chk7_Roncus)
        Me.grp_ResNormal.Controls.Add(Me.chk7_Sibilian)
        Me.grp_ResNormal.Controls.Add(Me.chk7_Tiraje)
        Me.grp_ResNormal.Controls.Add(Me.chk7_Tos)
        Me.grp_ResNormal.Location = New System.Drawing.Point(118, 850)
        Me.grp_ResNormal.Name = "grp_ResNormal"
        Me.grp_ResNormal.Size = New System.Drawing.Size(263, 32)
        Me.grp_ResNormal.TabIndex = 43
        Me.grp_ResNormal.TabStop = False
        '
        'chk7_Roncus
        '
        Me.chk7_Roncus.AutoSize = True
        Me.chk7_Roncus.Location = New System.Drawing.Point(13, 11)
        Me.chk7_Roncus.Name = "chk7_Roncus"
        Me.chk7_Roncus.Size = New System.Drawing.Size(63, 17)
        Me.chk7_Roncus.TabIndex = 205
        Me.chk7_Roncus.Text = "Roncus"
        Me.chk7_Roncus.UseVisualStyleBackColor = True
        '
        'chk7_Sibilian
        '
        Me.chk7_Sibilian.AutoSize = True
        Me.chk7_Sibilian.Location = New System.Drawing.Point(77, 11)
        Me.chk7_Sibilian.Name = "chk7_Sibilian"
        Me.chk7_Sibilian.Size = New System.Drawing.Size(59, 17)
        Me.chk7_Sibilian.TabIndex = 207
        Me.chk7_Sibilian.Text = "Sibilian"
        Me.chk7_Sibilian.UseVisualStyleBackColor = True
        '
        'chk7_Tiraje
        '
        Me.chk7_Tiraje.AutoSize = True
        Me.chk7_Tiraje.Location = New System.Drawing.Point(136, 11)
        Me.chk7_Tiraje.Name = "chk7_Tiraje"
        Me.chk7_Tiraje.Size = New System.Drawing.Size(52, 17)
        Me.chk7_Tiraje.TabIndex = 208
        Me.chk7_Tiraje.Text = "Tiraje"
        Me.chk7_Tiraje.UseVisualStyleBackColor = True
        '
        'chk7_Tos
        '
        Me.chk7_Tos.AutoSize = True
        Me.chk7_Tos.Location = New System.Drawing.Point(189, 11)
        Me.chk7_Tos.Name = "chk7_Tos"
        Me.chk7_Tos.Size = New System.Drawing.Size(44, 17)
        Me.chk7_Tos.TabIndex = 209
        Me.chk7_Tos.Text = "Tos"
        Me.chk7_Tos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(26, 843)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 287
        Me.Label6.Text = "TORAX:"
        '
        'grp_SinPiel
        '
        Me.grp_SinPiel.Controls.Add(Me.txt_PielOtros)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Otros)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Placas)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Salpullidos)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Rash)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Despig)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Manchas)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Papulas)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Xerosis)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Liqunif)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Contacto)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Edema)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Habones)
        Me.grp_SinPiel.Controls.Add(Me.chk6_Demografismo)
        Me.grp_SinPiel.Controls.Add(Me.chk6_EccPliegues)
        Me.grp_SinPiel.Location = New System.Drawing.Point(119, 489)
        Me.grp_SinPiel.Name = "grp_SinPiel"
        Me.grp_SinPiel.Size = New System.Drawing.Size(808, 59)
        Me.grp_SinPiel.TabIndex = 30
        Me.grp_SinPiel.TabStop = False
        '
        'txt_PielOtros
        '
        Me.txt_PielOtros.BackColor = System.Drawing.Color.White
        Me.txt_PielOtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PielOtros.Location = New System.Drawing.Point(390, 31)
        Me.txt_PielOtros.Name = "txt_PielOtros"
        Me.txt_PielOtros.Size = New System.Drawing.Size(120, 20)
        Me.txt_PielOtros.TabIndex = 337
        '
        'chk6_Otros
        '
        Me.chk6_Otros.AutoSize = True
        Me.chk6_Otros.Location = New System.Drawing.Point(332, 33)
        Me.chk6_Otros.Name = "chk6_Otros"
        Me.chk6_Otros.Size = New System.Drawing.Size(51, 17)
        Me.chk6_Otros.TabIndex = 260
        Me.chk6_Otros.Text = "Otros"
        Me.chk6_Otros.UseVisualStyleBackColor = True
        '
        'chk6_Placas
        '
        Me.chk6_Placas.AutoSize = True
        Me.chk6_Placas.Location = New System.Drawing.Point(262, 33)
        Me.chk6_Placas.Name = "chk6_Placas"
        Me.chk6_Placas.Size = New System.Drawing.Size(58, 17)
        Me.chk6_Placas.TabIndex = 259
        Me.chk6_Placas.Text = "Placas"
        Me.chk6_Placas.UseVisualStyleBackColor = True
        '
        'chk6_Salpullidos
        '
        Me.chk6_Salpullidos.AutoSize = True
        Me.chk6_Salpullidos.Location = New System.Drawing.Point(180, 33)
        Me.chk6_Salpullidos.Name = "chk6_Salpullidos"
        Me.chk6_Salpullidos.Size = New System.Drawing.Size(76, 17)
        Me.chk6_Salpullidos.TabIndex = 258
        Me.chk6_Salpullidos.Text = "Salpullidos"
        Me.chk6_Salpullidos.UseVisualStyleBackColor = True
        '
        'chk6_Rash
        '
        Me.chk6_Rash.AutoSize = True
        Me.chk6_Rash.Location = New System.Drawing.Point(123, 33)
        Me.chk6_Rash.Name = "chk6_Rash"
        Me.chk6_Rash.Size = New System.Drawing.Size(51, 17)
        Me.chk6_Rash.TabIndex = 257
        Me.chk6_Rash.Text = "Rash"
        Me.chk6_Rash.UseVisualStyleBackColor = True
        '
        'chk6_Despig
        '
        Me.chk6_Despig.AutoSize = True
        Me.chk6_Despig.Location = New System.Drawing.Point(8, 33)
        Me.chk6_Despig.Name = "chk6_Despig"
        Me.chk6_Despig.Size = New System.Drawing.Size(108, 17)
        Me.chk6_Despig.TabIndex = 256
        Me.chk6_Despig.Text = "Despigmentacion"
        Me.chk6_Despig.UseVisualStyleBackColor = True
        '
        'chk6_Manchas
        '
        Me.chk6_Manchas.AutoSize = True
        Me.chk6_Manchas.Location = New System.Drawing.Point(672, 10)
        Me.chk6_Manchas.Name = "chk6_Manchas"
        Me.chk6_Manchas.Size = New System.Drawing.Size(70, 17)
        Me.chk6_Manchas.TabIndex = 255
        Me.chk6_Manchas.Text = "Manchas"
        Me.chk6_Manchas.UseVisualStyleBackColor = True
        '
        'chk6_Papulas
        '
        Me.chk6_Papulas.AutoSize = True
        Me.chk6_Papulas.Location = New System.Drawing.Point(600, 10)
        Me.chk6_Papulas.Name = "chk6_Papulas"
        Me.chk6_Papulas.Size = New System.Drawing.Size(64, 17)
        Me.chk6_Papulas.TabIndex = 254
        Me.chk6_Papulas.Text = "Papulas"
        Me.chk6_Papulas.UseVisualStyleBackColor = True
        '
        'chk6_Xerosis
        '
        Me.chk6_Xerosis.AutoSize = True
        Me.chk6_Xerosis.Location = New System.Drawing.Point(428, 10)
        Me.chk6_Xerosis.Name = "chk6_Xerosis"
        Me.chk6_Xerosis.Size = New System.Drawing.Size(60, 17)
        Me.chk6_Xerosis.TabIndex = 252
        Me.chk6_Xerosis.Text = "Xerosis"
        Me.chk6_Xerosis.UseVisualStyleBackColor = True
        '
        'chk6_Liqunif
        '
        Me.chk6_Liqunif.AutoSize = True
        Me.chk6_Liqunif.Location = New System.Drawing.Point(496, 10)
        Me.chk6_Liqunif.Name = "chk6_Liqunif"
        Me.chk6_Liqunif.Size = New System.Drawing.Size(97, 17)
        Me.chk6_Liqunif.TabIndex = 253
        Me.chk6_Liqunif.Text = "Liquenificacion"
        Me.chk6_Liqunif.UseVisualStyleBackColor = True
        '
        'chk6_Contacto
        '
        Me.chk6_Contacto.AutoSize = True
        Me.chk6_Contacto.Location = New System.Drawing.Point(355, 10)
        Me.chk6_Contacto.Name = "chk6_Contacto"
        Me.chk6_Contacto.Size = New System.Drawing.Size(69, 17)
        Me.chk6_Contacto.TabIndex = 251
        Me.chk6_Contacto.Text = "Contacto"
        Me.chk6_Contacto.UseVisualStyleBackColor = True
        '
        'chk6_Edema
        '
        Me.chk6_Edema.AutoSize = True
        Me.chk6_Edema.Location = New System.Drawing.Point(290, 10)
        Me.chk6_Edema.Name = "chk6_Edema"
        Me.chk6_Edema.Size = New System.Drawing.Size(59, 17)
        Me.chk6_Edema.TabIndex = 250
        Me.chk6_Edema.Text = "Edema"
        Me.chk6_Edema.UseVisualStyleBackColor = True
        '
        'chk6_Habones
        '
        Me.chk6_Habones.AutoSize = True
        Me.chk6_Habones.Location = New System.Drawing.Point(8, 10)
        Me.chk6_Habones.Name = "chk6_Habones"
        Me.chk6_Habones.Size = New System.Drawing.Size(69, 17)
        Me.chk6_Habones.TabIndex = 247
        Me.chk6_Habones.Text = "Habones"
        Me.chk6_Habones.UseVisualStyleBackColor = True
        '
        'chk6_Demografismo
        '
        Me.chk6_Demografismo.AutoSize = True
        Me.chk6_Demografismo.Location = New System.Drawing.Point(79, 10)
        Me.chk6_Demografismo.Name = "chk6_Demografismo"
        Me.chk6_Demografismo.Size = New System.Drawing.Size(96, 17)
        Me.chk6_Demografismo.TabIndex = 248
        Me.chk6_Demografismo.Text = "Dermografismo"
        Me.chk6_Demografismo.UseVisualStyleBackColor = True
        '
        'chk6_EccPliegues
        '
        Me.chk6_EccPliegues.AutoSize = True
        Me.chk6_EccPliegues.Location = New System.Drawing.Point(180, 10)
        Me.chk6_EccPliegues.Name = "chk6_EccPliegues"
        Me.chk6_EccPliegues.Size = New System.Drawing.Size(107, 17)
        Me.chk6_EccPliegues.TabIndex = 249
        Me.chk6_EccPliegues.Text = "Eccema pliegues"
        Me.chk6_EccPliegues.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(24, 500)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(73, 17)
        Me.Label38.TabIndex = 246
        Me.Label38.Text = "PIEL"
        '
        'dgv_Lab4
        '
        Me.dgv_Lab4.AllowUserToAddRows = False
        Me.dgv_Lab4.AllowUserToDeleteRows = False
        Me.dgv_Lab4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Lab4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Lab4.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Lab4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Lab4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lab4.ColumnHeadersVisible = False
        Me.dgv_Lab4.Location = New System.Drawing.Point(614, 1131)
        Me.dgv_Lab4.Name = "dgv_Lab4"
        Me.dgv_Lab4.RowHeadersVisible = False
        Me.dgv_Lab4.Size = New System.Drawing.Size(174, 158)
        Me.dgv_Lab4.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 275
        Me.Label5.Text = "EVOLUCION INICIO"
        '
        'dgv_Lab3
        '
        Me.dgv_Lab3.AllowUserToAddRows = False
        Me.dgv_Lab3.AllowUserToDeleteRows = False
        Me.dgv_Lab3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Lab3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Lab3.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Lab3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Lab3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lab3.ColumnHeadersVisible = False
        Me.dgv_Lab3.Location = New System.Drawing.Point(434, 1131)
        Me.dgv_Lab3.Name = "dgv_Lab3"
        Me.dgv_Lab3.RowHeadersVisible = False
        Me.dgv_Lab3.Size = New System.Drawing.Size(174, 158)
        Me.dgv_Lab3.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(271, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 158
        Me.Label15.Text = "OCUPACION:"
        '
        'dgv_Lab2
        '
        Me.dgv_Lab2.AllowUserToAddRows = False
        Me.dgv_Lab2.AllowUserToDeleteRows = False
        Me.dgv_Lab2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Lab2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Lab2.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Lab2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Lab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lab2.ColumnHeadersVisible = False
        Me.dgv_Lab2.Location = New System.Drawing.Point(254, 1131)
        Me.dgv_Lab2.Name = "dgv_Lab2"
        Me.dgv_Lab2.RowHeadersVisible = False
        Me.dgv_Lab2.Size = New System.Drawing.Size(174, 158)
        Me.dgv_Lab2.TabIndex = 54
        '
        'dgv_Lab1
        '
        Me.dgv_Lab1.AllowUserToAddRows = False
        Me.dgv_Lab1.AllowUserToDeleteRows = False
        Me.dgv_Lab1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Lab1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Lab1.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Lab1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Lab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lab1.ColumnHeadersVisible = False
        Me.dgv_Lab1.Location = New System.Drawing.Point(74, 1131)
        Me.dgv_Lab1.Name = "dgv_Lab1"
        Me.dgv_Lab1.RowHeadersVisible = False
        Me.dgv_Lab1.Size = New System.Drawing.Size(174, 158)
        Me.dgv_Lab1.TabIndex = 53
        '
        'grp_Tos
        '
        Me.grp_Tos.Controls.Add(Me.chk5_Ejercicio)
        Me.grp_Tos.Controls.Add(Me.chk5_OpToraxica)
        Me.grp_Tos.Controls.Add(Me.chk5_Dia)
        Me.grp_Tos.Controls.Add(Me.chk5_Noche)
        Me.grp_Tos.Controls.Add(Me.chk5_Seca)
        Me.grp_Tos.Controls.Add(Me.chk5_Flema)
        Me.grp_Tos.Location = New System.Drawing.Point(118, 455)
        Me.grp_Tos.Name = "grp_Tos"
        Me.grp_Tos.Size = New System.Drawing.Size(398, 32)
        Me.grp_Tos.TabIndex = 28
        Me.grp_Tos.TabStop = False
        '
        'chk5_Ejercicio
        '
        Me.chk5_Ejercicio.AutoSize = True
        Me.chk5_Ejercicio.Location = New System.Drawing.Point(325, 9)
        Me.chk5_Ejercicio.Name = "chk5_Ejercicio"
        Me.chk5_Ejercicio.Size = New System.Drawing.Size(66, 17)
        Me.chk5_Ejercicio.TabIndex = 245
        Me.chk5_Ejercicio.Text = "Ejercicio"
        Me.chk5_Ejercicio.UseVisualStyleBackColor = True
        '
        'chk5_OpToraxica
        '
        Me.chk5_OpToraxica.AutoSize = True
        Me.chk5_OpToraxica.Location = New System.Drawing.Point(235, 10)
        Me.chk5_OpToraxica.Name = "chk5_OpToraxica"
        Me.chk5_OpToraxica.Size = New System.Drawing.Size(90, 17)
        Me.chk5_OpToraxica.TabIndex = 244
        Me.chk5_OpToraxica.Text = "Opr. Toraxica"
        Me.chk5_OpToraxica.UseVisualStyleBackColor = True
        '
        'chk5_Dia
        '
        Me.chk5_Dia.AutoSize = True
        Me.chk5_Dia.Location = New System.Drawing.Point(9, 11)
        Me.chk5_Dia.Name = "chk5_Dia"
        Me.chk5_Dia.Size = New System.Drawing.Size(42, 17)
        Me.chk5_Dia.TabIndex = 239
        Me.chk5_Dia.Text = "Dia"
        Me.chk5_Dia.UseVisualStyleBackColor = True
        '
        'chk5_Noche
        '
        Me.chk5_Noche.AutoSize = True
        Me.chk5_Noche.Location = New System.Drawing.Point(57, 11)
        Me.chk5_Noche.Name = "chk5_Noche"
        Me.chk5_Noche.Size = New System.Drawing.Size(58, 17)
        Me.chk5_Noche.TabIndex = 240
        Me.chk5_Noche.Text = "Noche"
        Me.chk5_Noche.UseVisualStyleBackColor = True
        '
        'chk5_Seca
        '
        Me.chk5_Seca.AutoSize = True
        Me.chk5_Seca.Location = New System.Drawing.Point(121, 11)
        Me.chk5_Seca.Name = "chk5_Seca"
        Me.chk5_Seca.Size = New System.Drawing.Size(51, 17)
        Me.chk5_Seca.TabIndex = 241
        Me.chk5_Seca.Text = "Seca"
        Me.chk5_Seca.UseVisualStyleBackColor = True
        '
        'chk5_Flema
        '
        Me.chk5_Flema.AutoSize = True
        Me.chk5_Flema.Location = New System.Drawing.Point(177, 11)
        Me.chk5_Flema.Name = "chk5_Flema"
        Me.chk5_Flema.Size = New System.Drawing.Size(54, 17)
        Me.chk5_Flema.TabIndex = 243
        Me.chk5_Flema.Text = "Flema"
        Me.chk5_Flema.UseVisualStyleBackColor = True
        '
        'grp_Pruirito
        '
        Me.grp_Pruirito.Controls.Add(Me.chk3_DescaPal)
        Me.grp_Pruirito.Controls.Add(Me.chk3_Ojos)
        Me.grp_Pruirito.Controls.Add(Me.chk3_Nariz)
        Me.grp_Pruirito.Controls.Add(Me.chk3_Garganta)
        Me.grp_Pruirito.Controls.Add(Me.chk3_Oidos)
        Me.grp_Pruirito.Controls.Add(Me.chk3_Palatinos)
        Me.grp_Pruirito.Controls.Add(Me.chk3_EdemPalpe)
        Me.grp_Pruirito.Location = New System.Drawing.Point(119, 422)
        Me.grp_Pruirito.Name = "grp_Pruirito"
        Me.grp_Pruirito.Size = New System.Drawing.Size(808, 31)
        Me.grp_Pruirito.TabIndex = 27
        Me.grp_Pruirito.TabStop = False
        '
        'chk3_DescaPal
        '
        Me.chk3_DescaPal.AutoSize = True
        Me.chk3_DescaPal.Location = New System.Drawing.Point(443, 10)
        Me.chk3_DescaPal.Name = "chk3_DescaPal"
        Me.chk3_DescaPal.Size = New System.Drawing.Size(167, 17)
        Me.chk3_DescaPal.TabIndex = 234
        Me.chk3_DescaPal.Text = "Descamacion borde palpebral"
        Me.chk3_DescaPal.UseVisualStyleBackColor = True
        '
        'chk3_Ojos
        '
        Me.chk3_Ojos.AutoSize = True
        Me.chk3_Ojos.Location = New System.Drawing.Point(59, 10)
        Me.chk3_Ojos.Name = "chk3_Ojos"
        Me.chk3_Ojos.Size = New System.Drawing.Size(47, 17)
        Me.chk3_Ojos.TabIndex = 229
        Me.chk3_Ojos.Text = "Ojos"
        Me.chk3_Ojos.UseVisualStyleBackColor = True
        '
        'chk3_Nariz
        '
        Me.chk3_Nariz.AutoSize = True
        Me.chk3_Nariz.Location = New System.Drawing.Point(8, 10)
        Me.chk3_Nariz.Name = "chk3_Nariz"
        Me.chk3_Nariz.Size = New System.Drawing.Size(50, 17)
        Me.chk3_Nariz.TabIndex = 228
        Me.chk3_Nariz.Text = "Nariz"
        Me.chk3_Nariz.UseVisualStyleBackColor = True
        '
        'chk3_Garganta
        '
        Me.chk3_Garganta.AutoSize = True
        Me.chk3_Garganta.Location = New System.Drawing.Point(111, 10)
        Me.chk3_Garganta.Name = "chk3_Garganta"
        Me.chk3_Garganta.Size = New System.Drawing.Size(70, 17)
        Me.chk3_Garganta.TabIndex = 230
        Me.chk3_Garganta.Text = "Garganta"
        Me.chk3_Garganta.UseVisualStyleBackColor = True
        '
        'chk3_Oidos
        '
        Me.chk3_Oidos.AutoSize = True
        Me.chk3_Oidos.Location = New System.Drawing.Point(186, 10)
        Me.chk3_Oidos.Name = "chk3_Oidos"
        Me.chk3_Oidos.Size = New System.Drawing.Size(53, 17)
        Me.chk3_Oidos.TabIndex = 231
        Me.chk3_Oidos.Text = "Oidos"
        Me.chk3_Oidos.UseVisualStyleBackColor = True
        '
        'chk3_Palatinos
        '
        Me.chk3_Palatinos.AutoSize = True
        Me.chk3_Palatinos.Location = New System.Drawing.Point(249, 10)
        Me.chk3_Palatinos.Name = "chk3_Palatinos"
        Me.chk3_Palatinos.Size = New System.Drawing.Size(69, 17)
        Me.chk3_Palatinos.TabIndex = 232
        Me.chk3_Palatinos.Text = "Palatinos"
        Me.chk3_Palatinos.UseVisualStyleBackColor = True
        '
        'chk3_EdemPalpe
        '
        Me.chk3_EdemPalpe.AutoSize = True
        Me.chk3_EdemPalpe.Location = New System.Drawing.Point(330, 10)
        Me.chk3_EdemPalpe.Name = "chk3_EdemPalpe"
        Me.chk3_EdemPalpe.Size = New System.Drawing.Size(105, 17)
        Me.chk3_EdemPalpe.TabIndex = 233
        Me.chk3_EdemPalpe.Text = "Edema palpebral"
        Me.chk3_EdemPalpe.UseVisualStyleBackColor = True
        '
        'grp_SinOjos
        '
        Me.grp_SinOjos.Controls.Add(Me.chkO_Lagrimeo)
        Me.grp_SinOjos.Controls.Add(Me.chkO_Conjuntivitis)
        Me.grp_SinOjos.Controls.Add(Me.chkO_Enrojecimiento)
        Me.grp_SinOjos.Location = New System.Drawing.Point(119, 349)
        Me.grp_SinOjos.Name = "grp_SinOjos"
        Me.grp_SinOjos.Size = New System.Drawing.Size(271, 31)
        Me.grp_SinOjos.TabIndex = 23
        Me.grp_SinOjos.TabStop = False
        '
        'chkO_Lagrimeo
        '
        Me.chkO_Lagrimeo.AutoSize = True
        Me.chkO_Lagrimeo.Location = New System.Drawing.Point(8, 11)
        Me.chkO_Lagrimeo.Name = "chkO_Lagrimeo"
        Me.chkO_Lagrimeo.Size = New System.Drawing.Size(69, 17)
        Me.chkO_Lagrimeo.TabIndex = 221
        Me.chkO_Lagrimeo.Text = "Lagrimeo"
        Me.chkO_Lagrimeo.UseVisualStyleBackColor = True
        '
        'chkO_Conjuntivitis
        '
        Me.chkO_Conjuntivitis.AutoSize = True
        Me.chkO_Conjuntivitis.Location = New System.Drawing.Point(82, 11)
        Me.chkO_Conjuntivitis.Name = "chkO_Conjuntivitis"
        Me.chkO_Conjuntivitis.Size = New System.Drawing.Size(82, 17)
        Me.chkO_Conjuntivitis.TabIndex = 223
        Me.chkO_Conjuntivitis.Text = "Conjuntivitis"
        Me.chkO_Conjuntivitis.UseVisualStyleBackColor = True
        '
        'chkO_Enrojecimiento
        '
        Me.chkO_Enrojecimiento.AutoSize = True
        Me.chkO_Enrojecimiento.Location = New System.Drawing.Point(166, 11)
        Me.chkO_Enrojecimiento.Name = "chkO_Enrojecimiento"
        Me.chkO_Enrojecimiento.Size = New System.Drawing.Size(95, 17)
        Me.chkO_Enrojecimiento.TabIndex = 224
        Me.chkO_Enrojecimiento.Text = "Enrojecimiento"
        Me.chkO_Enrojecimiento.UseVisualStyleBackColor = True
        '
        'grp_Desencadena
        '
        Me.grp_Desencadena.Controls.Add(Me.txt_DesOtro)
        Me.grp_Desencadena.Controls.Add(Me.chk1_OTROS)
        Me.grp_Desencadena.Controls.Add(Me.chk1_Polvo)
        Me.grp_Desencadena.Controls.Add(Me.chk1_Humo)
        Me.grp_Desencadena.Controls.Add(Me.chk1_Frio)
        Me.grp_Desencadena.Controls.Add(Me.chk1_Humedad)
        Me.grp_Desencadena.Controls.Add(Me.chk1_Calor)
        Me.grp_Desencadena.Controls.Add(Me.chk1_Alimentos)
        Me.grp_Desencadena.Controls.Add(Me.chk1_Olores)
        Me.grp_Desencadena.Location = New System.Drawing.Point(120, 270)
        Me.grp_Desencadena.Name = "grp_Desencadena"
        Me.grp_Desencadena.Size = New System.Drawing.Size(807, 32)
        Me.grp_Desencadena.TabIndex = 21
        Me.grp_Desencadena.TabStop = False
        '
        'txt_DesOtro
        '
        Me.txt_DesOtro.BackColor = System.Drawing.Color.White
        Me.txt_DesOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_DesOtro.Location = New System.Drawing.Point(548, 10)
        Me.txt_DesOtro.Name = "txt_DesOtro"
        Me.txt_DesOtro.Size = New System.Drawing.Size(138, 20)
        Me.txt_DesOtro.TabIndex = 339
        '
        'chk1_OTROS
        '
        Me.chk1_OTROS.AutoSize = True
        Me.chk1_OTROS.Location = New System.Drawing.Point(481, 11)
        Me.chk1_OTROS.Name = "chk1_OTROS"
        Me.chk1_OTROS.Size = New System.Drawing.Size(64, 17)
        Me.chk1_OTROS.TabIndex = 215
        Me.chk1_OTROS.Text = "OTROS"
        Me.chk1_OTROS.UseVisualStyleBackColor = True
        '
        'chk1_Polvo
        '
        Me.chk1_Polvo.AutoSize = True
        Me.chk1_Polvo.Location = New System.Drawing.Point(7, 11)
        Me.chk1_Polvo.Name = "chk1_Polvo"
        Me.chk1_Polvo.Size = New System.Drawing.Size(53, 17)
        Me.chk1_Polvo.TabIndex = 205
        Me.chk1_Polvo.Text = "Polvo"
        Me.chk1_Polvo.UseVisualStyleBackColor = True
        '
        'chk1_Humo
        '
        Me.chk1_Humo.AutoSize = True
        Me.chk1_Humo.Location = New System.Drawing.Point(69, 11)
        Me.chk1_Humo.Name = "chk1_Humo"
        Me.chk1_Humo.Size = New System.Drawing.Size(54, 17)
        Me.chk1_Humo.TabIndex = 207
        Me.chk1_Humo.Text = "Humo"
        Me.chk1_Humo.UseVisualStyleBackColor = True
        '
        'chk1_Frio
        '
        Me.chk1_Frio.AutoSize = True
        Me.chk1_Frio.Location = New System.Drawing.Point(227, 11)
        Me.chk1_Frio.Name = "chk1_Frio"
        Me.chk1_Frio.Size = New System.Drawing.Size(43, 17)
        Me.chk1_Frio.TabIndex = 208
        Me.chk1_Frio.Text = "Frio"
        Me.chk1_Frio.UseVisualStyleBackColor = True
        '
        'chk1_Humedad
        '
        Me.chk1_Humedad.AutoSize = True
        Me.chk1_Humedad.Location = New System.Drawing.Point(276, 11)
        Me.chk1_Humedad.Name = "chk1_Humedad"
        Me.chk1_Humedad.Size = New System.Drawing.Size(72, 17)
        Me.chk1_Humedad.TabIndex = 209
        Me.chk1_Humedad.Text = "Humedad"
        Me.chk1_Humedad.UseVisualStyleBackColor = True
        '
        'chk1_Calor
        '
        Me.chk1_Calor.AutoSize = True
        Me.chk1_Calor.Location = New System.Drawing.Point(354, 11)
        Me.chk1_Calor.Name = "chk1_Calor"
        Me.chk1_Calor.Size = New System.Drawing.Size(50, 17)
        Me.chk1_Calor.TabIndex = 210
        Me.chk1_Calor.Text = "Calor"
        Me.chk1_Calor.UseVisualStyleBackColor = True
        '
        'chk1_Alimentos
        '
        Me.chk1_Alimentos.AutoSize = True
        Me.chk1_Alimentos.Location = New System.Drawing.Point(404, 11)
        Me.chk1_Alimentos.Name = "chk1_Alimentos"
        Me.chk1_Alimentos.Size = New System.Drawing.Size(71, 17)
        Me.chk1_Alimentos.TabIndex = 211
        Me.chk1_Alimentos.Text = "Alimentos"
        Me.chk1_Alimentos.UseVisualStyleBackColor = True
        '
        'chk1_Olores
        '
        Me.chk1_Olores.AutoSize = True
        Me.chk1_Olores.Location = New System.Drawing.Point(127, 11)
        Me.chk1_Olores.Name = "chk1_Olores"
        Me.chk1_Olores.Size = New System.Drawing.Size(91, 17)
        Me.chk1_Olores.TabIndex = 214
        Me.chk1_Olores.Text = "Olores fuertes"
        Me.chk1_Olores.UseVisualStyleBackColor = True
        '
        'txt_Ram
        '
        Me.txt_Ram.BackColor = System.Drawing.Color.White
        Me.txt_Ram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ram.Location = New System.Drawing.Point(119, 593)
        Me.txt_Ram.Name = "txt_Ram"
        Me.txt_Ram.Size = New System.Drawing.Size(802, 20)
        Me.txt_Ram.TabIndex = 32
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(23, 595)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 18)
        Me.Label37.TabIndex = 244
        Me.Label37.Text = "RAM"
        '
        'labelTos
        '
        Me.labelTos.BackColor = System.Drawing.Color.Transparent
        Me.labelTos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTos.ForeColor = System.Drawing.Color.Black
        Me.labelTos.Location = New System.Drawing.Point(24, 464)
        Me.labelTos.Name = "labelTos"
        Me.labelTos.Size = New System.Drawing.Size(39, 18)
        Me.labelTos.TabIndex = 242
        Me.labelTos.Text = "TOS"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(519, 459)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(73, 30)
        Me.Label35.TabIndex = 234
        Me.Label35.Text = "ACCESOS ASMATICOS"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(23, 435)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 18)
        Me.Label34.TabIndex = 227
        Me.Label34.Text = "PRURITO"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(25, 361)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 15)
        Me.Label33.TabIndex = 222
        Me.Label33.Text = "OJOS"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(23, 281)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(99, 16)
        Me.Label29.TabIndex = 202
        Me.Label29.Text = "DESENCADENANTE"
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(709, 217)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(99, 32)
        Me.Label59.TabIndex = 377
        Me.Label59.Text = "ENFERMEDADES INFECCIOSAS"
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(269, 215)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(97, 35)
        Me.Label56.TabIndex = 371
        Me.Label56.Text = "ENFERMEDADES TIROIDEAS"
        '
        'btn_ssalir
        '
        Me.btn_ssalir.BackColor = System.Drawing.Color.White
        Me.btn_ssalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ssalir.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ssalir.Image = CType(resources.GetObject("btn_ssalir.Image"), System.Drawing.Image)
        Me.btn_ssalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ssalir.Location = New System.Drawing.Point(932, 31)
        Me.btn_ssalir.Name = "btn_ssalir"
        Me.btn_ssalir.Size = New System.Drawing.Size(78, 48)
        Me.btn_ssalir.TabIndex = 184
        Me.btn_ssalir.Text = "SALIR"
        Me.btn_ssalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ssalir.UseVisualStyleBackColor = False
        '
        'btn_gguardar
        '
        Me.btn_gguardar.BackColor = System.Drawing.Color.White
        Me.btn_gguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gguardar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gguardar.Image = CType(resources.GetObject("btn_gguardar.Image"), System.Drawing.Image)
        Me.btn_gguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gguardar.Location = New System.Drawing.Point(749, 31)
        Me.btn_gguardar.Name = "btn_gguardar"
        Me.btn_gguardar.Size = New System.Drawing.Size(89, 48)
        Me.btn_gguardar.TabIndex = 183
        Me.btn_gguardar.Text = "GUARDAR"
        Me.btn_gguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gguardar.UseVisualStyleBackColor = False
        '
        'btn_ImpHistoria
        '
        Me.btn_ImpHistoria.BackColor = System.Drawing.Color.White
        Me.btn_ImpHistoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ImpHistoria.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImpHistoria.Image = CType(resources.GetObject("btn_ImpHistoria.Image"), System.Drawing.Image)
        Me.btn_ImpHistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImpHistoria.Location = New System.Drawing.Point(839, 31)
        Me.btn_ImpHistoria.Name = "btn_ImpHistoria"
        Me.btn_ImpHistoria.Size = New System.Drawing.Size(93, 48)
        Me.btn_ImpHistoria.TabIndex = 182
        Me.btn_ImpHistoria.Text = "HISTORIA"
        Me.btn_ImpHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpHistoria.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(16, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1042, 620)
        Me.TabControl1.TabIndex = 201
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1034, 594)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HISTORIA CLINICA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label88)
        Me.TabPage5.Controls.Add(Me.Label86)
        Me.TabPage5.Controls.Add(Me.lbl_DProfesion)
        Me.TabPage5.Controls.Add(Me.Label73)
        Me.TabPage5.Controls.Add(Me.lbl_DProvincia)
        Me.TabPage5.Controls.Add(Me.lbl_DFono)
        Me.TabPage5.Controls.Add(Me.Label75)
        Me.TabPage5.Controls.Add(Me.lbl_DGenero)
        Me.TabPage5.Controls.Add(Me.Label74)
        Me.TabPage5.Controls.Add(Me.lbl_DMail)
        Me.TabPage5.Controls.Add(Me.Label83)
        Me.TabPage5.Controls.Add(Me.Label84)
        Me.TabPage5.Controls.Add(Me.Label85)
        Me.TabPage5.Controls.Add(Me.Label87)
        Me.TabPage5.Controls.Add(Me.lbl_DPoliza)
        Me.TabPage5.Controls.Add(Me.lbl_DObs)
        Me.TabPage5.Controls.Add(Me.lbl_DFecNac)
        Me.TabPage5.Controls.Add(Me.lbl_DDoc)
        Me.TabPage5.Controls.Add(Me.Label82)
        Me.TabPage5.Controls.Add(Me.lbl_DApellidos)
        Me.TabPage5.Controls.Add(Me.Label30)
        Me.TabPage5.Controls.Add(Me.Label79)
        Me.TabPage5.Controls.Add(Me.Label78)
        Me.TabPage5.Controls.Add(Me.Label77)
        Me.TabPage5.Controls.Add(Me.Label76)
        Me.TabPage5.Controls.Add(Me.lbl_DCiudad)
        Me.TabPage5.Controls.Add(Me.lbl_DPais)
        Me.TabPage5.Controls.Add(Me.lbl_DDirec)
        Me.TabPage5.Controls.Add(Me.lbl_DNombres)
        Me.TabPage5.Controls.Add(Me.PictureBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1034, 594)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "DEMOGRAFICOS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.Red
        Me.Label88.Location = New System.Drawing.Point(122, 50)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(315, 29)
        Me.Label88.TabIndex = 271
        Me.Label88.Text = "DATOS DEMOGRAFICOS"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label86.Location = New System.Drawing.Point(123, 372)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(103, 20)
        Me.Label86.TabIndex = 270
        Me.Label86.Text = "PROFESION"
        '
        'lbl_DProfesion
        '
        Me.lbl_DProfesion.AutoSize = True
        Me.lbl_DProfesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DProfesion.Location = New System.Drawing.Point(231, 372)
        Me.lbl_DProfesion.Name = "lbl_DProfesion"
        Me.lbl_DProfesion.Size = New System.Drawing.Size(113, 20)
        Me.lbl_DProfesion.TabIndex = 269
        Me.lbl_DProfesion.Text = "(PROFESION)"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label73.Location = New System.Drawing.Point(123, 288)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(97, 20)
        Me.Label73.TabIndex = 268
        Me.Label73.Text = "PROVINCIA"
        '
        'lbl_DProvincia
        '
        Me.lbl_DProvincia.AutoSize = True
        Me.lbl_DProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DProvincia.Location = New System.Drawing.Point(231, 288)
        Me.lbl_DProvincia.Name = "lbl_DProvincia"
        Me.lbl_DProvincia.Size = New System.Drawing.Size(107, 20)
        Me.lbl_DProvincia.TabIndex = 267
        Me.lbl_DProvincia.Text = "(PROVINCIA)"
        '
        'lbl_DFono
        '
        Me.lbl_DFono.AutoSize = True
        Me.lbl_DFono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DFono.Location = New System.Drawing.Point(231, 418)
        Me.lbl_DFono.Name = "lbl_DFono"
        Me.lbl_DFono.Size = New System.Drawing.Size(64, 20)
        Me.lbl_DFono.TabIndex = 266
        Me.lbl_DFono.Text = "(FONO)"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label75.Location = New System.Drawing.Point(123, 418)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(54, 20)
        Me.Label75.TabIndex = 265
        Me.Label75.Text = "FONO"
        '
        'lbl_DGenero
        '
        Me.lbl_DGenero.AutoSize = True
        Me.lbl_DGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DGenero.Location = New System.Drawing.Point(232, 195)
        Me.lbl_DGenero.Name = "lbl_DGenero"
        Me.lbl_DGenero.Size = New System.Drawing.Size(64, 20)
        Me.lbl_DGenero.TabIndex = 264
        Me.lbl_DGenero.Text = "(SEXO)"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label74.Location = New System.Drawing.Point(123, 195)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(79, 20)
        Me.Label74.TabIndex = 263
        Me.Label74.Text = "GENERO"
        '
        'lbl_DMail
        '
        Me.lbl_DMail.AutoSize = True
        Me.lbl_DMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DMail.Location = New System.Drawing.Point(231, 395)
        Me.lbl_DMail.Name = "lbl_DMail"
        Me.lbl_DMail.Size = New System.Drawing.Size(57, 20)
        Me.lbl_DMail.TabIndex = 262
        Me.lbl_DMail.Text = "(MAIL)"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label83.Location = New System.Drawing.Point(123, 395)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(58, 20)
        Me.Label83.TabIndex = 261
        Me.Label83.Text = "EMAIL"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label84.Location = New System.Drawing.Point(123, 462)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(66, 20)
        Me.Label84.TabIndex = 260
        Me.Label84.Text = "POLIZA"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label85.Location = New System.Drawing.Point(123, 439)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(47, 20)
        Me.Label85.TabIndex = 259
        Me.Label85.Text = "OBS:"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label87.Location = New System.Drawing.Point(123, 242)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(105, 20)
        Me.Label87.TabIndex = 257
        Me.Label87.Text = "FECHA NAC."
        '
        'lbl_DPoliza
        '
        Me.lbl_DPoliza.AutoSize = True
        Me.lbl_DPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DPoliza.Location = New System.Drawing.Point(231, 462)
        Me.lbl_DPoliza.Name = "lbl_DPoliza"
        Me.lbl_DPoliza.Size = New System.Drawing.Size(76, 20)
        Me.lbl_DPoliza.TabIndex = 256
        Me.lbl_DPoliza.Text = "(POLIZA)"
        '
        'lbl_DObs
        '
        Me.lbl_DObs.AutoSize = True
        Me.lbl_DObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DObs.Location = New System.Drawing.Point(231, 439)
        Me.lbl_DObs.Name = "lbl_DObs"
        Me.lbl_DObs.Size = New System.Drawing.Size(53, 20)
        Me.lbl_DObs.TabIndex = 255
        Me.lbl_DObs.Text = "(OBS)"
        '
        'lbl_DFecNac
        '
        Me.lbl_DFecNac.AutoSize = True
        Me.lbl_DFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DFecNac.Location = New System.Drawing.Point(231, 242)
        Me.lbl_DFecNac.Name = "lbl_DFecNac"
        Me.lbl_DFecNac.Size = New System.Drawing.Size(111, 20)
        Me.lbl_DFecNac.TabIndex = 253
        Me.lbl_DFecNac.Text = "(FECHA NAC)"
        '
        'lbl_DDoc
        '
        Me.lbl_DDoc.AutoSize = True
        Me.lbl_DDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DDoc.Location = New System.Drawing.Point(232, 126)
        Me.lbl_DDoc.Name = "lbl_DDoc"
        Me.lbl_DDoc.Size = New System.Drawing.Size(122, 20)
        Me.lbl_DDoc.TabIndex = 252
        Me.lbl_DDoc.Text = "(DOCUMENTO)"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label82.Location = New System.Drawing.Point(123, 126)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(83, 20)
        Me.Label82.TabIndex = 251
        Me.Label82.Text = "CED/PAS:"
        '
        'lbl_DApellidos
        '
        Me.lbl_DApellidos.AutoSize = True
        Me.lbl_DApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DApellidos.Location = New System.Drawing.Point(231, 172)
        Me.lbl_DApellidos.Name = "lbl_DApellidos"
        Me.lbl_DApellidos.Size = New System.Drawing.Size(109, 20)
        Me.lbl_DApellidos.TabIndex = 250
        Me.lbl_DApellidos.Text = "(APELLIDOS)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(123, 172)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(99, 20)
        Me.Label30.TabIndex = 249
        Me.Label30.Text = "APELLIDOS"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label79.Location = New System.Drawing.Point(123, 312)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(76, 20)
        Me.Label79.TabIndex = 248
        Me.Label79.Text = "CIUDAD:"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label78.Location = New System.Drawing.Point(123, 266)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(50, 20)
        Me.Label78.TabIndex = 247
        Me.Label78.Text = "PAIS:"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label77.Location = New System.Drawing.Point(123, 335)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(99, 20)
        Me.Label77.TabIndex = 246
        Me.Label77.Text = "DIRECCION"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label76.Location = New System.Drawing.Point(123, 149)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(94, 20)
        Me.Label76.TabIndex = 245
        Me.Label76.Text = "NOMBRES:"
        '
        'lbl_DCiudad
        '
        Me.lbl_DCiudad.AutoSize = True
        Me.lbl_DCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DCiudad.Location = New System.Drawing.Point(231, 312)
        Me.lbl_DCiudad.Name = "lbl_DCiudad"
        Me.lbl_DCiudad.Size = New System.Drawing.Size(82, 20)
        Me.lbl_DCiudad.TabIndex = 244
        Me.lbl_DCiudad.Text = "(CIUDAD)"
        '
        'lbl_DPais
        '
        Me.lbl_DPais.AutoSize = True
        Me.lbl_DPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DPais.Location = New System.Drawing.Point(231, 266)
        Me.lbl_DPais.Name = "lbl_DPais"
        Me.lbl_DPais.Size = New System.Drawing.Size(56, 20)
        Me.lbl_DPais.TabIndex = 243
        Me.lbl_DPais.Text = "(PAIS)"
        '
        'lbl_DDirec
        '
        Me.lbl_DDirec.AutoSize = True
        Me.lbl_DDirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DDirec.Location = New System.Drawing.Point(231, 335)
        Me.lbl_DDirec.Name = "lbl_DDirec"
        Me.lbl_DDirec.Size = New System.Drawing.Size(109, 20)
        Me.lbl_DDirec.TabIndex = 242
        Me.lbl_DDirec.Text = "(DIRECCION)"
        '
        'lbl_DNombres
        '
        Me.lbl_DNombres.AutoSize = True
        Me.lbl_DNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DNombres.Location = New System.Drawing.Point(231, 149)
        Me.lbl_DNombres.Name = "lbl_DNombres"
        Me.lbl_DNombres.Size = New System.Drawing.Size(100, 20)
        Me.lbl_DNombres.TabIndex = 241
        Me.lbl_DNombres.Text = "(NOMBRES)"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 240
        Me.PictureBox2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.Controls.Add(Me.cmb_Campo)
        Me.TabPage3.Controls.Add(Me.Label89)
        Me.TabPage3.Controls.Add(Me.dgv_Cambios)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1034, 594)
        Me.TabPage3.TabIndex = 6
        Me.TabPage3.Text = "HISTORIAL DE CAMBIOS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(8, 31)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(1023, 18)
        Me.Label89.TabIndex = 275
        Me.Label89.Text = "CAMBIOS"
        '
        'dgv_Cambios
        '
        Me.dgv_Cambios.AllowUserToAddRows = False
        Me.dgv_Cambios.AllowUserToDeleteRows = False
        Me.dgv_Cambios.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Cambios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Cambios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Cambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Cambios.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Cambios.Location = New System.Drawing.Point(8, 53)
        Me.dgv_Cambios.MultiSelect = False
        Me.dgv_Cambios.Name = "dgv_Cambios"
        Me.dgv_Cambios.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Cambios.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_Cambios.RowHeadersVisible = False
        Me.dgv_Cambios.Size = New System.Drawing.Size(1020, 524)
        Me.dgv_Cambios.TabIndex = 172
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lbl_TotExas)
        Me.TabPage4.Controls.Add(Me.Label160)
        Me.TabPage4.Controls.Add(Me.lbl_ToTConsultas)
        Me.TabPage4.Controls.Add(Me.Label161)
        Me.TabPage4.Controls.Add(Me.lbl_TotCie)
        Me.TabPage4.Controls.Add(Me.Label162)
        Me.TabPage4.Controls.Add(Me.Label159)
        Me.TabPage4.Controls.Add(Me.dgv_ConsultaHistorico)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1034, 594)
        Me.TabPage4.TabIndex = 7
        Me.TabPage4.Text = "HISTORIAL DE CONSULTAS"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lbl_TotExas
        '
        Me.lbl_TotExas.AutoSize = True
        Me.lbl_TotExas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotExas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotExas.Location = New System.Drawing.Point(816, 86)
        Me.lbl_TotExas.Name = "lbl_TotExas"
        Me.lbl_TotExas.Size = New System.Drawing.Size(96, 16)
        Me.lbl_TotExas.TabIndex = 281
        Me.lbl_TotExas.Text = "(TOT_EXAS)"
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.BackColor = System.Drawing.Color.Transparent
        Me.Label160.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label160.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label160.Location = New System.Drawing.Point(594, 86)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(216, 16)
        Me.Label160.TabIndex = 280
        Me.Label160.Text = "TOTAL EXAMENES REALIZADOS"
        '
        'lbl_ToTConsultas
        '
        Me.lbl_ToTConsultas.AutoSize = True
        Me.lbl_ToTConsultas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToTConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToTConsultas.Location = New System.Drawing.Point(737, 46)
        Me.lbl_ToTConsultas.Name = "lbl_ToTConsultas"
        Me.lbl_ToTConsultas.Size = New System.Drawing.Size(89, 16)
        Me.lbl_ToTConsultas.TabIndex = 279
        Me.lbl_ToTConsultas.Text = "(TOT_CON)"
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.BackColor = System.Drawing.Color.Transparent
        Me.Label161.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label161.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label161.Location = New System.Drawing.Point(594, 46)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(137, 16)
        Me.Label161.TabIndex = 278
        Me.Label161.Text = "TOTAL CONSULTAS"
        '
        'lbl_TotCie
        '
        Me.lbl_TotCie.AutoSize = True
        Me.lbl_TotCie.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotCie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotCie.Location = New System.Drawing.Point(798, 64)
        Me.lbl_TotCie.Name = "lbl_TotCie"
        Me.lbl_TotCie.Size = New System.Drawing.Size(97, 16)
        Me.lbl_TotCie.TabIndex = 277
        Me.lbl_TotCie.Text = "(TOT_CIE10)"
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.BackColor = System.Drawing.Color.Transparent
        Me.Label162.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label162.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label162.Location = New System.Drawing.Point(594, 65)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(197, 16)
        Me.Label162.TabIndex = 276
        Me.Label162.Text = "TOTAL DIAGNOSTICOS CIE 10"
        '
        'Label159
        '
        Me.Label159.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label159.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label159.Location = New System.Drawing.Point(20, 18)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(557, 18)
        Me.Label159.TabIndex = 274
        Me.Label159.Text = "CONSULTAS"
        '
        'dgv_ConsultaHistorico
        '
        Me.dgv_ConsultaHistorico.AllowUserToAddRows = False
        Me.dgv_ConsultaHistorico.AllowUserToDeleteRows = False
        Me.dgv_ConsultaHistorico.BackgroundColor = System.Drawing.Color.Gray
        Me.dgv_ConsultaHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_ConsultaHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_ConsultaHistorico.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_ConsultaHistorico.Location = New System.Drawing.Point(19, 37)
        Me.dgv_ConsultaHistorico.Name = "dgv_ConsultaHistorico"
        Me.dgv_ConsultaHistorico.ReadOnly = True
        Me.dgv_ConsultaHistorico.RowHeadersVisible = False
        Me.dgv_ConsultaHistorico.Size = New System.Drawing.Size(558, 379)
        Me.dgv_ConsultaHistorico.TabIndex = 273
        '
        'lbl_pais
        '
        Me.lbl_pais.AutoSize = True
        Me.lbl_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pais.Location = New System.Drawing.Point(585, 7)
        Me.lbl_pais.Name = "lbl_pais"
        Me.lbl_pais.Size = New System.Drawing.Size(38, 16)
        Me.lbl_pais.TabIndex = 203
        Me.lbl_pais.Text = "PAIS"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(518, 5)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 18)
        Me.Label23.TabIndex = 202
        Me.Label23.Text = "PAIS:"
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ciudad.Location = New System.Drawing.Point(585, 30)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(59, 16)
        Me.lbl_ciudad.TabIndex = 205
        Me.lbl_ciudad.Text = "CIUDAD"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(518, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 18)
        Me.Label24.TabIndex = 204
        Me.Label24.Text = "CIUDAD:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lbl_ciudad)
        Me.Panel2.Controls.Add(Me.lbl_paciente)
        Me.Panel2.Controls.Add(Me.lbl_pais)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.lbl_edad)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Location = New System.Drawing.Point(18, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 61)
        Me.Panel2.TabIndex = 206
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 239
        Me.PictureBox1.TabStop = False
        '
        'cmb_Campo
        '
        Me.cmb_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Campo.FormattingEnabled = True
        Me.cmb_Campo.ItemHeight = 13
        Me.cmb_Campo.Items.AddRange(New Object() {"<TODOS>", "ZONA", "OCUPACION", "HOBBIES", "INMUNIZACIONES", "HABITOS TOXICOS", "OTROS HABITOS TOXICOS", "TIEMPO OTRO HABITO", "MOTIVO DE LA CONSULTA", "HIST. ENFERMEDAD ACTUAL", "TTO ANAMESIS", "SEGUIMIENTO", "HIST. PICOSOCIAL", "EVOLUCION INICIO", "ANTECEDENTES PERSONALES", "ENFER. TIRIDEAS", "CANCER", "ENFER. INFECCIOSAS", "OTRAS ENFERMEDADES", "TTO. ANTECEDENTES", "CIRUGIAS", "DESENCADENANTES", "DESENCADENANTE OTRO", "MENSTRUACION", "MENSTRUACION TOMA", "SINT. OJOS", "SINT. NARIZ", "SINT. ESTORNUDOS", "SINT. BOCA", "PRURITO", "TOS", "ACC. ASMATICOS", "PIEL", "PIEL OTROS", "DIGESTIVOS", "DIGESTIVOS OTRO", "ASMA", "RINITIS", "URTICARIA", "ECCEMAS", "CONJUNTIVITIS", "DROGAS", "MIGRAÑA", "EDEMA", "ANT. FAMILIAR OTRO", "SIGNOS ESPECIALES", "TORAX RESP. NORMAL", "TORAX RESP. FORZADA", "NARIZ", "NARIZ CORNETES", "NARIZ POLIPOS", "GARGANTA"})
        Me.cmb_Campo.Location = New System.Drawing.Point(808, 7)
        Me.cmb_Campo.Name = "cmb_Campo"
        Me.cmb_Campo.Size = New System.Drawing.Size(223, 21)
        Me.cmb_Campo.TabIndex = 276
        '
        'frm_HistoriaClinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1070, 720)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_ssalir)
        Me.Controls.Add(Me.btn_gguardar)
        Me.Controls.Add(Me.btn_ImpHistoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_HistoriaClinica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_HistoriaClinica"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grp_SigEsp1.ResumeLayout(False)
        Me.grp_SigEsp1.PerformLayout()
        Me.grpNarizPolipos.ResumeLayout(False)
        Me.grpNarizPolipos.PerformLayout()
        Me.grp_SinDigestivos.ResumeLayout(False)
        Me.grp_SinDigestivos.PerformLayout()
        Me.grpNarizCorn.ResumeLayout(False)
        Me.grpNarizCorn.PerformLayout()
        Me.grp_AccAsmaticos.ResumeLayout(False)
        Me.grp_AccAsmaticos.PerformLayout()
        Me.grp_SinBoca.ResumeLayout(False)
        Me.grp_SinBoca.PerformLayout()
        Me.grp_SinEstornuodos.ResumeLayout(False)
        Me.grp_SinEstornuodos.PerformLayout()
        Me.grp_SinNariz.ResumeLayout(False)
        Me.grp_SinNariz.PerformLayout()
        Me.grp_Menstruacion.ResumeLayout(False)
        Me.grp_Menstruacion.PerformLayout()
        Me.grp_SigEsp2.ResumeLayout(False)
        Me.grp_SigEsp2.PerformLayout()
        Me.grp_Edema.ResumeLayout(False)
        Me.grp_Edema.PerformLayout()
        Me.grp_Migra.ResumeLayout(False)
        Me.grp_Migra.PerformLayout()
        Me.grp_Drog.ResumeLayout(False)
        Me.grp_Drog.PerformLayout()
        Me.grp_Conj.ResumeLayout(False)
        Me.grp_Conj.PerformLayout()
        Me.grp_Urt.ResumeLayout(False)
        Me.grp_Urt.PerformLayout()
        Me.grp_Eccen.ResumeLayout(False)
        Me.grp_Eccen.PerformLayout()
        Me.grp_Rini.ResumeLayout(False)
        Me.grp_Rini.PerformLayout()
        Me.grp_Asma.ResumeLayout(False)
        Me.grp_Asma.PerformLayout()
        Me.grp_Garganta.ResumeLayout(False)
        Me.grp_Garganta.PerformLayout()
        Me.grp_Nariz.ResumeLayout(False)
        Me.grp_Nariz.PerformLayout()
        Me.grp_ResForzada.ResumeLayout(False)
        Me.grp_ResForzada.PerformLayout()
        Me.grp_ResNormal.ResumeLayout(False)
        Me.grp_ResNormal.PerformLayout()
        Me.grp_SinPiel.ResumeLayout(False)
        Me.grp_SinPiel.PerformLayout()
        CType(Me.dgv_Lab4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Lab3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Lab2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Lab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Tos.ResumeLayout(False)
        Me.grp_Tos.PerformLayout()
        Me.grp_Pruirito.ResumeLayout(False)
        Me.grp_Pruirito.PerformLayout()
        Me.grp_SinOjos.ResumeLayout(False)
        Me.grp_SinOjos.PerformLayout()
        Me.grp_Desencadena.ResumeLayout(False)
        Me.grp_Desencadena.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_Cambios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgv_ConsultaHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_hc_MotConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_ssalir As System.Windows.Forms.Button
    Friend WithEvents btn_gguardar As System.Windows.Forms.Button
    Friend WithEvents btn_ImpHistoria As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_hcEvolInicio As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents chk1_Polvo As System.Windows.Forms.CheckBox
    Friend WithEvents chk1_Alimentos As System.Windows.Forms.CheckBox
    Friend WithEvents chk1_Calor As System.Windows.Forms.CheckBox
    Friend WithEvents chk1_Humedad As System.Windows.Forms.CheckBox
    Friend WithEvents chk1_Frio As System.Windows.Forms.CheckBox
    Friend WithEvents chk1_Humo As System.Windows.Forms.CheckBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents chkO_Lagrimeo As System.Windows.Forms.CheckBox
    Friend WithEvents chkO_Enrojecimiento As System.Windows.Forms.CheckBox
    Friend WithEvents chkO_Conjuntivitis As System.Windows.Forms.CheckBox
    Friend WithEvents chkSN_Resequedad As System.Windows.Forms.CheckBox
    Friend WithEvents chkSN_Purulenta As System.Windows.Forms.CheckBox
    Friend WithEvents chk3_EdemPalpe As System.Windows.Forms.CheckBox
    Friend WithEvents chk3_Oidos As System.Windows.Forms.CheckBox
    Friend WithEvents chk3_Garganta As System.Windows.Forms.CheckBox
    Friend WithEvents chk3_Ojos As System.Windows.Forms.CheckBox
    Friend WithEvents chk3_Nariz As System.Windows.Forms.CheckBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents chk5_Seca As System.Windows.Forms.CheckBox
    Friend WithEvents chk5_Noche As System.Windows.Forms.CheckBox
    Friend WithEvents chk5_Dia As System.Windows.Forms.CheckBox
    Friend WithEvents chk4_Sibilanc As System.Windows.Forms.CheckBox
    Friend WithEvents chk4_Roncus As System.Windows.Forms.CheckBox
    Friend WithEvents chk4_Nocturnos As System.Windows.Forms.CheckBox
    Friend WithEvents chk4_Diurnos As System.Windows.Forms.CheckBox
    Friend WithEvents labelTos As System.Windows.Forms.Label
    Friend WithEvents chk5_Flema As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Ram As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents chk6_Edema As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_EccPliegues As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Demografismo As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Habones As System.Windows.Forms.CheckBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents grp_Desencadena As System.Windows.Forms.GroupBox
    Friend WithEvents grp_SinOjos As System.Windows.Forms.GroupBox
    Friend WithEvents grp_Pruirito As System.Windows.Forms.GroupBox
    Friend WithEvents grp_Tos As System.Windows.Forms.GroupBox
    Friend WithEvents grp_AccAsmaticos As System.Windows.Forms.GroupBox
    Friend WithEvents grp_SinPiel As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Lab1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_Lab2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_Lab3 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv_Lab4 As System.Windows.Forms.DataGridView
    Friend WithEvents chk6_Contacto As System.Windows.Forms.CheckBox
    Friend WithEvents grp_ResNormal As System.Windows.Forms.GroupBox
    Friend WithEvents chk7_Roncus As System.Windows.Forms.CheckBox
    Friend WithEvents chk7_Sibilian As System.Windows.Forms.CheckBox
    Friend WithEvents chk7_Tiraje As System.Windows.Forms.CheckBox
    Friend WithEvents chk7_Tos As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grp_ResForzada As System.Windows.Forms.GroupBox
    Friend WithEvents chk8_Roncus As System.Windows.Forms.CheckBox
    Friend WithEvents chk8_Sibilian As System.Windows.Forms.CheckBox
    Friend WithEvents chk8_Tiraje As System.Windows.Forms.CheckBox
    Friend WithEvents chk8_Tos As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grp_Nariz As System.Windows.Forms.GroupBox
    Friend WithEvents chk9_Edema As System.Windows.Forms.CheckBox
    Friend WithEvents chk9_Moco As System.Windows.Forms.CheckBox
    Friend WithEvents chk9_Obs As System.Windows.Forms.CheckBox
    Friend WithEvents chk9_Desv As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Garganta As System.Windows.Forms.GroupBox
    Friend WithEvents chk10_Inflamada As System.Windows.Forms.CheckBox
    Friend WithEvents chk10_Granulosa As System.Windows.Forms.CheckBox
    Friend WithEvents chk10_SReflujo As System.Windows.Forms.CheckBox
    Friend WithEvents chk10_Exudado As System.Windows.Forms.CheckBox
    Friend WithEvents chk10_Goteo As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_LabBiopsia As System.Windows.Forms.TextBox
    Friend WithEvents txt_LabImagen As System.Windows.Forms.TextBox
    Friend WithEvents txt_CampoPiel As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_pais As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lbl_ciudad As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_hcHobbies As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmb_zona As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_HabiTox_Otro As System.Windows.Forms.TextBox
    Friend WithEvents cmb_HabTox As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_hcInmun As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_HisEnfeAct As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_HTToAnam As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_HSeg As System.Windows.Forms.TextBox
    Friend WithEvents txt_HPsicoS As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents grp_SigEsp2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSig2_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig2_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig2_3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig2_4 As System.Windows.Forms.CheckBox
    Friend WithEvents grp_SigEsp1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSig_7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSig_6 As System.Windows.Forms.CheckBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents grp_Edema As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Ede6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ede1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ede5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ede2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ede4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ede3 As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Migra As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Mig6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Mig1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Mig5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Mig2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Mig4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Mig3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grp_Drog As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Dro1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Dro2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Dro3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Dro4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Dro5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Dro6 As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Conj As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Con1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Con2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Con3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Con4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Con5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Con6 As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Urt As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Urt1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Urt2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Urt6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Urt3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Urt5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Urt4 As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Eccen As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Ecc1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ecc2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ecc3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ecc4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ecc5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ecc6 As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Rini As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Rin1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Rin2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Rin3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Rin4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Rin5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Rin6 As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Asma As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Asm1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Asm2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Asm3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Asm4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Asm5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Asm6 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_AntFamOtro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_TiemHab As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents cmb_APP As System.Windows.Forms.ComboBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents cmb_EnfToroideas As System.Windows.Forms.ComboBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txt_EnferInfecc As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cancer As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txt_TTo_Antec As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt_OtrasEnfer As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txt_Cirugias As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents grp_Menstruacion As System.Windows.Forms.GroupBox
    Friend WithEvents chkM_Colico As System.Windows.Forms.CheckBox
    Friend WithEvents chkM_Cefalea As System.Windows.Forms.CheckBox
    Friend WithEvents chkM_Migrana As System.Windows.Forms.CheckBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents chk1_Olores As System.Windows.Forms.CheckBox
    Friend WithEvents txt_MenstruToma As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents grp_SinNariz As System.Windows.Forms.GroupBox
    Friend WithEvents chkSN_Rinorrea As System.Windows.Forms.CheckBox
    Friend WithEvents chkSN_Acuosa As System.Windows.Forms.CheckBox
    Friend WithEvents chkSN_Densa As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents chkSN_ObtNasal As System.Windows.Forms.CheckBox
    Friend WithEvents grp_SinEstornuodos As System.Windows.Forms.GroupBox
    Friend WithEvents chkCE_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkCE_Raro As System.Windows.Forms.CheckBox
    Friend WithEvents chkCE_Frecuente As System.Windows.Forms.CheckBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents grp_SinBoca As System.Windows.Forms.GroupBox
    Friend WithEvents chkB_Ronca As System.Windows.Forms.CheckBox
    Friend WithEvents chkB_RespOral As System.Windows.Forms.CheckBox
    Friend WithEvents chkB_DurmeBAbierta As System.Windows.Forms.CheckBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents chk3_Palatinos As System.Windows.Forms.CheckBox
    Friend WithEvents chk3_DescaPal As System.Windows.Forms.CheckBox
    Friend WithEvents chk5_Ejercicio As System.Windows.Forms.CheckBox
    Friend WithEvents chk5_OpToraxica As System.Windows.Forms.CheckBox
    Friend WithEvents chk4_Disnea As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Despig As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Manchas As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Papulas As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Xerosis As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Liqunif As System.Windows.Forms.CheckBox
    Friend WithEvents txt_PielOtros As System.Windows.Forms.TextBox
    Friend WithEvents chk6_Otros As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Placas As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Salpullidos As System.Windows.Forms.CheckBox
    Friend WithEvents chk6_Rash As System.Windows.Forms.CheckBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents grpNarizCorn As System.Windows.Forms.GroupBox
    Friend WithEvents chkHCorn_Grave As System.Windows.Forms.CheckBox
    Friend WithEvents chkHCorn_Moderado As System.Windows.Forms.CheckBox
    Friend WithEvents chkHCorn_Leve As System.Windows.Forms.CheckBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents grp_SinDigestivos As System.Windows.Forms.GroupBox
    Friend WithEvents chkDig_Regurgit As System.Windows.Forms.CheckBox
    Friend WithEvents chkDig_Pirosis As System.Windows.Forms.CheckBox
    Friend WithEvents chkDig_Acidez As System.Windows.Forms.CheckBox
    Friend WithEvents chkDig_Flatos As System.Windows.Forms.CheckBox
    Friend WithEvents chkDig_DolAbdo As System.Windows.Forms.CheckBox
    Friend WithEvents chkDig_Vomito As System.Windows.Forms.CheckBox
    Friend WithEvents chkDig_Diarrea As System.Windows.Forms.CheckBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txt_DigIntolerAlim As System.Windows.Forms.TextBox
    Friend WithEvents chkDig_IntolAlim As System.Windows.Forms.CheckBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txt_HOcupacion As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txt_LabOtros As System.Windows.Forms.TextBox
    Friend WithEvents chkM_Toma As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents lbl_DCiudad As System.Windows.Forms.Label
    Friend WithEvents lbl_DPais As System.Windows.Forms.Label
    Friend WithEvents lbl_DDirec As System.Windows.Forms.Label
    Friend WithEvents lbl_DNombres As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents grpNarizPolipos As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Pol_D As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Pol_I As System.Windows.Forms.CheckBox
    Friend WithEvents txt_NarizMucosa As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents lbl_DDoc As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents lbl_DApellidos As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents lbl_DGenero As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents lbl_DMail As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents lbl_DObs As System.Windows.Forms.Label
    Friend WithEvents lbl_DFecNac As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents lbl_DPoliza As System.Windows.Forms.Label
    Friend WithEvents lbl_DFono As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents lbl_DProvincia As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents lbl_DProfesion As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents txt_Obstr As System.Windows.Forms.TextBox
    Friend WithEvents txt_DesOtro As System.Windows.Forms.TextBox
    Friend WithEvents chk1_OTROS As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Urt7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ecc7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Rin7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Asm7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ede7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Mig7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Dro7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Con7 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_Cambios As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents dgv_ConsultaHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_TotExas As System.Windows.Forms.Label
    Friend WithEvents Label160 As System.Windows.Forms.Label
    Friend WithEvents lbl_ToTConsultas As System.Windows.Forms.Label
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotCie As System.Windows.Forms.Label
    Friend WithEvents Label162 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents cmb_Campo As System.Windows.Forms.ComboBox
End Class
