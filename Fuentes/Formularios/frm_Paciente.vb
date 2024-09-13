'*************************************************************************
' Nombre:   frm_Paciente
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite manipular los pacientes
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_Paciente
    Inherits System.Windows.Forms.Form

    Public frm_refer_main As Frm_Main


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_apellido As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_direccion As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_mail As Ctl_txt.ctl_txt_mail
    Friend WithEvents Cmb_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Ctl_txt_doc As Ctl_txt.ctl_txt_ci_ruc
    Friend WithEvents Cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fecnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dgrd_paciente As System.Windows.Forms.DataGrid
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_fono As Ctl_txt.ctl_txt_letras
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro_apellido As System.Windows.Forms.TextBox
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
    Friend WithEvents Grp_paciente As System.Windows.Forms.GroupBox
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_hisClinica As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents grp_buscar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents rbtn_si As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_no As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmb_grado As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_edad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Ctl_txt_Pais As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_Profesion As Ctl_txt.ctl_txt_letras
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grp_Supo As System.Windows.Forms.GroupBox
    Friend WithEvents txt_SupoOtro As System.Windows.Forms.TextBox
    Friend WithEvents rbt_SupoOtro As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_SupoFam As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_SupoInternet As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_SupoFace As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_SupoInstagram As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_ComoSupo As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_LugarVive As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmb_ProvinciaVive As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_ciudadVive As System.Windows.Forms.ComboBox
    Friend WithEvents chk_LIFE As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grp_Nac As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_cliente As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Paciente))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Ctl_txt_apellido = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_direccion = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_fono = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_mail = New Ctl_txt.ctl_txt_mail
        Me.Cmb_tipodoc = New System.Windows.Forms.ComboBox
        Me.Cmb_sexo = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_doc = New Ctl_txt.ctl_txt_ci_ruc
        Me.Cmb_ciudad = New System.Windows.Forms.ComboBox
        Me.Grp_paciente = New System.Windows.Forms.GroupBox
        Me.grp_Nac = New System.Windows.Forms.GroupBox
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Ctl_txt_Pais = New Ctl_txt.ctl_txt_letras
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmb_ProvinciaVive = New System.Windows.Forms.ComboBox
        Me.Cmb_ciudadVive = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Txt_obs = New System.Windows.Forms.TextBox
        Me.Ctl_txt_LugarVive = New Ctl_txt.ctl_txt_letras
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Ctl_txt_Profesion = New Ctl_txt.ctl_txt_letras
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_edad = New System.Windows.Forms.TextBox
        Me.Dtp_fecnac = New System.Windows.Forms.DateTimePicker
        Me.rbtn_no = New System.Windows.Forms.RadioButton
        Me.rbtn_si = New System.Windows.Forms.RadioButton
        Me.txt_hisClinica = New System.Windows.Forms.TextBox
        Me.cmb_grado = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Dgrd_paciente = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_filtro_apellido = New System.Windows.Forms.TextBox
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.grp_buscar = New System.Windows.Forms.GroupBox
        Me.grp_Supo = New System.Windows.Forms.GroupBox
        Me.txt_SupoOtro = New System.Windows.Forms.TextBox
        Me.rbt_SupoOtro = New System.Windows.Forms.RadioButton
        Me.rbt_SupoFam = New System.Windows.Forms.RadioButton
        Me.rbt_SupoInternet = New System.Windows.Forms.RadioButton
        Me.rbt_SupoFace = New System.Windows.Forms.RadioButton
        Me.rbt_SupoInstagram = New System.Windows.Forms.RadioButton
        Me.lbl_ComoSupo = New System.Windows.Forms.Label
        Me.chk_LIFE = New System.Windows.Forms.CheckBox
        Me.chk_cliente = New System.Windows.Forms.CheckBox
        Me.Grp_paciente.SuspendLayout()
        Me.grp_Nac.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrd_paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.grp_buscar.SuspendLayout()
        Me.grp_Supo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DOCUMENTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(43, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "APELLIDOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(43, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "NOMBRES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(42, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DIRECCION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(433, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TELF:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(398, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "GENERO:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(346, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "FECHA NAC.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(42, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "EMAIL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "CIUDAD"
        '
        'Ctl_txt_apellido
        '
        Me.Ctl_txt_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_apellido.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_apellido.Location = New System.Drawing.Point(127, 39)
        Me.Ctl_txt_apellido.Name = "Ctl_txt_apellido"
        Me.Ctl_txt_apellido.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_apellido.Prp_CaracterPasswd = ""
        Me.Ctl_txt_apellido.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_apellido.Size = New System.Drawing.Size(482, 20)
        Me.Ctl_txt_apellido.TabIndex = 3
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(127, 62)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(482, 20)
        Me.Ctl_txt_nombre.TabIndex = 4
        '
        'Ctl_txt_direccion
        '
        Me.Ctl_txt_direccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_direccion.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_direccion.Location = New System.Drawing.Point(126, 225)
        Me.Ctl_txt_direccion.Name = "Ctl_txt_direccion"
        Me.Ctl_txt_direccion.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_direccion.Prp_CaracterPasswd = ""
        Me.Ctl_txt_direccion.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_direccion.Size = New System.Drawing.Size(481, 20)
        Me.Ctl_txt_direccion.TabIndex = 14
        '
        'Ctl_txt_fono
        '
        Me.Ctl_txt_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_fono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_fono.Location = New System.Drawing.Point(475, 248)
        Me.Ctl_txt_fono.Name = "Ctl_txt_fono"
        Me.Ctl_txt_fono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_fono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_fono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_fono.Size = New System.Drawing.Size(132, 20)
        Me.Ctl_txt_fono.TabIndex = 16
        '
        'Ctl_txt_mail
        '
        Me.Ctl_txt_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_mail.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_mail.Location = New System.Drawing.Point(126, 248)
        Me.Ctl_txt_mail.Name = "Ctl_txt_mail"
        Me.Ctl_txt_mail.Size = New System.Drawing.Size(310, 20)
        Me.Ctl_txt_mail.TabIndex = 15
        '
        'Cmb_tipodoc
        '
        Me.Cmb_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_tipodoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_tipodoc.Items.AddRange(New Object() {"CEDULA", "RUC", "PASAPORTE", "NINGUNO"})
        Me.Cmb_tipodoc.Location = New System.Drawing.Point(127, 13)
        Me.Cmb_tipodoc.Name = "Cmb_tipodoc"
        Me.Cmb_tipodoc.Size = New System.Drawing.Size(118, 21)
        Me.Cmb_tipodoc.TabIndex = 0
        '
        'Cmb_sexo
        '
        Me.Cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_sexo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sexo.Items.AddRange(New Object() {"F", "M", "I"})
        Me.Cmb_sexo.Location = New System.Drawing.Point(458, 14)
        Me.Cmb_sexo.Name = "Cmb_sexo"
        Me.Cmb_sexo.Size = New System.Drawing.Size(56, 21)
        Me.Cmb_sexo.TabIndex = 2
        '
        'Ctl_txt_doc
        '
        Me.Ctl_txt_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_doc.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_doc.Location = New System.Drawing.Point(252, 13)
        Me.Ctl_txt_doc.Name = "Ctl_txt_doc"
        Me.Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
        Me.Ctl_txt_doc.Size = New System.Drawing.Size(132, 20)
        Me.Ctl_txt_doc.TabIndex = 1
        '
        'Cmb_ciudad
        '
        Me.Cmb_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ciudad.Location = New System.Drawing.Point(100, 63)
        Me.Cmb_ciudad.Name = "Cmb_ciudad"
        Me.Cmb_ciudad.Size = New System.Drawing.Size(179, 21)
        Me.Cmb_ciudad.TabIndex = 20
        '
        'Grp_paciente
        '
        Me.Grp_paciente.BackColor = System.Drawing.Color.Transparent
        Me.Grp_paciente.Controls.Add(Me.grp_Nac)
        Me.Grp_paciente.Controls.Add(Me.Label12)
        Me.Grp_paciente.Controls.Add(Me.Label24)
        Me.Grp_paciente.Controls.Add(Me.cmb_ProvinciaVive)
        Me.Grp_paciente.Controls.Add(Me.Cmb_ciudadVive)
        Me.Grp_paciente.Controls.Add(Me.Label23)
        Me.Grp_paciente.Controls.Add(Me.Txt_obs)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_LugarVive)
        Me.Grp_paciente.Controls.Add(Me.Label22)
        Me.Grp_paciente.Controls.Add(Me.Label21)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_Profesion)
        Me.Grp_paciente.Controls.Add(Me.Label20)
        Me.Grp_paciente.Controls.Add(Me.Label17)
        Me.Grp_paciente.Controls.Add(Me.Label13)
        Me.Grp_paciente.Controls.Add(Me.txt_edad)
        Me.Grp_paciente.Controls.Add(Me.Dtp_fecnac)
        Me.Grp_paciente.Controls.Add(Me.rbtn_no)
        Me.Grp_paciente.Controls.Add(Me.rbtn_si)
        Me.Grp_paciente.Controls.Add(Me.txt_hisClinica)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_mail)
        Me.Grp_paciente.Controls.Add(Me.Label10)
        Me.Grp_paciente.Controls.Add(Me.Cmb_tipodoc)
        Me.Grp_paciente.Controls.Add(Me.Label1)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_doc)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_apellido)
        Me.Grp_paciente.Controls.Add(Me.Label3)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_nombre)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_direccion)
        Me.Grp_paciente.Controls.Add(Me.Cmb_sexo)
        Me.Grp_paciente.Controls.Add(Me.Label4)
        Me.Grp_paciente.Controls.Add(Me.Label5)
        Me.Grp_paciente.Controls.Add(Me.Ctl_txt_fono)
        Me.Grp_paciente.Controls.Add(Me.Label7)
        Me.Grp_paciente.Controls.Add(Me.Label6)
        Me.Grp_paciente.Controls.Add(Me.Label8)
        Me.Grp_paciente.Controls.Add(Me.Label9)
        Me.Grp_paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_paciente.ForeColor = System.Drawing.Color.Navy
        Me.Grp_paciente.Location = New System.Drawing.Point(12, 124)
        Me.Grp_paciente.Name = "Grp_paciente"
        Me.Grp_paciente.Size = New System.Drawing.Size(631, 304)
        Me.Grp_paciente.TabIndex = 0
        Me.Grp_paciente.TabStop = False
        '
        'grp_Nac
        '
        Me.grp_Nac.Controls.Add(Me.Label11)
        Me.grp_Nac.Controls.Add(Me.Cmb_ciudad)
        Me.grp_Nac.Controls.Add(Me.cmb_Provincia)
        Me.grp_Nac.Controls.Add(Me.Label18)
        Me.grp_Nac.Controls.Add(Me.Label19)
        Me.grp_Nac.Controls.Add(Me.Ctl_txt_Pais)
        Me.grp_Nac.Location = New System.Drawing.Point(317, 127)
        Me.grp_Nac.Name = "grp_Nac"
        Me.grp_Nac.Size = New System.Drawing.Size(308, 92)
        Me.grp_Nac.TabIndex = 220
        Me.grp_Nac.TabStop = False
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Provincia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Provincia.Location = New System.Drawing.Point(100, 39)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(179, 21)
        Me.cmb_Provincia.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "PROVINCIA"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(15, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 233
        Me.Label19.Text = "PAIS"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctl_txt_Pais
        '
        Me.Ctl_txt_Pais.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Pais.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_Pais.Location = New System.Drawing.Point(99, 15)
        Me.Ctl_txt_Pais.Name = "Ctl_txt_Pais"
        Me.Ctl_txt_Pais.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Pais.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Pais.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_Pais.Size = New System.Drawing.Size(180, 20)
        Me.Ctl_txt_Pais.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(43, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 243
        Me.Label12.Text = "PROVINCIA"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(43, 166)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 13)
        Me.Label24.TabIndex = 242
        Me.Label24.Text = "CIUDAD"
        '
        'cmb_ProvinciaVive
        '
        Me.cmb_ProvinciaVive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ProvinciaVive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ProvinciaVive.Location = New System.Drawing.Point(126, 138)
        Me.cmb_ProvinciaVive.Name = "cmb_ProvinciaVive"
        Me.cmb_ProvinciaVive.Size = New System.Drawing.Size(179, 21)
        Me.cmb_ProvinciaVive.TabIndex = 11
        '
        'Cmb_ciudadVive
        '
        Me.Cmb_ciudadVive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_ciudadVive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ciudadVive.Location = New System.Drawing.Point(126, 162)
        Me.Cmb_ciudadVive.Name = "Cmb_ciudadVive"
        Me.Cmb_ciudadVive.Size = New System.Drawing.Size(179, 21)
        Me.Cmb_ciudadVive.TabIndex = 12
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(42, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 13)
        Me.Label23.TabIndex = 239
        Me.Label23.Text = "LUGAR VIVE"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_obs
        '
        Me.Txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_obs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_obs.Location = New System.Drawing.Point(126, 274)
        Me.Txt_obs.MaxLength = 150
        Me.Txt_obs.Multiline = True
        Me.Txt_obs.Name = "Txt_obs"
        Me.Txt_obs.Size = New System.Drawing.Size(481, 22)
        Me.Txt_obs.TabIndex = 17
        '
        'Ctl_txt_LugarVive
        '
        Me.Ctl_txt_LugarVive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_LugarVive.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_LugarVive.Location = New System.Drawing.Point(127, 187)
        Me.Ctl_txt_LugarVive.Name = "Ctl_txt_LugarVive"
        Me.Ctl_txt_LugarVive.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_LugarVive.Prp_CaracterPasswd = ""
        Me.Ctl_txt_LugarVive.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_LugarVive.Size = New System.Drawing.Size(179, 20)
        Me.Ctl_txt_LugarVive.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(43, 186)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(81, 23)
        Me.Label22.TabIndex = 238
        Me.Label22.Text = "ACT. VIVE EN"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(314, 111)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(135, 13)
        Me.Label21.TabIndex = 236
        Me.Label21.Text = "LUGAR DE NACIMIENTO"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctl_txt_Profesion
        '
        Me.Ctl_txt_Profesion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Profesion.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_Profesion.Location = New System.Drawing.Point(127, 86)
        Me.Ctl_txt_Profesion.Name = "Ctl_txt_Profesion"
        Me.Ctl_txt_Profesion.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Profesion.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Profesion.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_Profesion.Size = New System.Drawing.Size(179, 20)
        Me.Ctl_txt_Profesion.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(43, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 232
        Me.Label20.Text = "PROFESION"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(525, 276)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "AFILIACION"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(42, 276)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "OBS."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_edad
        '
        Me.txt_edad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_edad.Location = New System.Drawing.Point(530, 86)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(79, 21)
        Me.txt_edad.TabIndex = 33
        '
        'Dtp_fecnac
        '
        Me.Dtp_fecnac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_fecnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_fecnac.Location = New System.Drawing.Point(430, 86)
        Me.Dtp_fecnac.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.Dtp_fecnac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Dtp_fecnac.Name = "Dtp_fecnac"
        Me.Dtp_fecnac.Size = New System.Drawing.Size(94, 21)
        Me.Dtp_fecnac.TabIndex = 10
        Me.Dtp_fecnac.Value = New Date(2003, 7, 23, 0, 0, 0, 0)
        '
        'rbtn_no
        '
        Me.rbtn_no.ForeColor = System.Drawing.Color.Black
        Me.rbtn_no.Location = New System.Drawing.Point(491, 206)
        Me.rbtn_no.Name = "rbtn_no"
        Me.rbtn_no.Size = New System.Drawing.Size(38, 14)
        Me.rbtn_no.TabIndex = 7
        Me.rbtn_no.Text = "No"
        Me.rbtn_no.Visible = False
        '
        'rbtn_si
        '
        Me.rbtn_si.Checked = True
        Me.rbtn_si.ForeColor = System.Drawing.Color.Black
        Me.rbtn_si.Location = New System.Drawing.Point(157, 190)
        Me.rbtn_si.Name = "rbtn_si"
        Me.rbtn_si.Size = New System.Drawing.Size(50, 12)
        Me.rbtn_si.TabIndex = 6
        Me.rbtn_si.TabStop = True
        Me.rbtn_si.Text = "Si"
        Me.rbtn_si.Visible = False
        '
        'txt_hisClinica
        '
        Me.txt_hisClinica.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_hisClinica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_hisClinica.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hisClinica.ForeColor = System.Drawing.Color.Gray
        Me.txt_hisClinica.Location = New System.Drawing.Point(533, 18)
        Me.txt_hisClinica.MaxLength = 10
        Me.txt_hisClinica.Name = "txt_hisClinica"
        Me.txt_hisClinica.ReadOnly = True
        Me.txt_hisClinica.Size = New System.Drawing.Size(73, 14)
        Me.txt_hisClinica.TabIndex = 3
        Me.txt_hisClinica.TabStop = False
        Me.txt_hisClinica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_grado
        '
        Me.cmb_grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_grado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_grado.Items.AddRange(New Object() {"Corporativo", "Familiar", "Individual"})
        Me.cmb_grado.Location = New System.Drawing.Point(664, 395)
        Me.cmb_grado.Name = "cmb_grado"
        Me.cmb_grado.Size = New System.Drawing.Size(133, 21)
        Me.cmb_grado.TabIndex = 16
        Me.cmb_grado.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(266, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Observaci�n"
        Me.Label9.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(215, 31)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 39)
        Me.btn_nuevo.TabIndex = 20
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_nuevo, "Ingresar un nuevo paciente")
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(379, 31)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(80, 39)
        Me.btn_eliminar.TabIndex = 21
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_eliminar, "Eliminar un paciente")
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(297, 31)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 39)
        Me.btn_aceptar.TabIndex = 18
        Me.btn_aceptar.Text = "Guardar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_aceptar, "Guardar los datos ingresados")
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(542, 31)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 39)
        Me.btn_cancelar.TabIndex = 19
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Salir de esta ventana")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Dgrd_paciente
        '
        Me.Dgrd_paciente.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_paciente.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_paciente.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_paciente.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_paciente.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_paciente.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_paciente.CaptionText = "PACIENTES"
        Me.Dgrd_paciente.DataMember = ""
        Me.Dgrd_paciente.FlatMode = True
        Me.Dgrd_paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_paciente.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_paciente.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_paciente.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_paciente.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_paciente.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_paciente.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_paciente.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_paciente.Location = New System.Drawing.Point(12, 434)
        Me.Dgrd_paciente.Name = "Dgrd_paciente"
        Me.Dgrd_paciente.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_paciente.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_paciente.ParentRowsVisible = False
        Me.Dgrd_paciente.PreferredColumnWidth = 100
        Me.Dgrd_paciente.ReadOnly = True
        Me.Dgrd_paciente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_paciente.RowHeaderWidth = 0
        Me.Dgrd_paciente.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_paciente.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_paciente.Size = New System.Drawing.Size(824, 159)
        Me.Dgrd_paciente.TabIndex = 2
        Me.Dgrd_paciente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_paciente.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_paciente
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn24})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DataGridTextBoxColumn1.MappingName = "pac_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Doc. Identif."
        Me.DataGridTextBoxColumn2.MappingName = "pac_doc"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "pac_tipodoc"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Apellidos"
        Me.DataGridTextBoxColumn4.MappingName = "pac_apellido"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 155
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Nombres"
        Me.DataGridTextBoxColumn5.MappingName = "pac_nombre"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 155
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Direccion"
        Me.DataGridTextBoxColumn6.MappingName = "pac_direccion"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Telefono"
        Me.DataGridTextBoxColumn8.MappingName = "pac_fono"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "FEC NAC"
        Me.DataGridTextBoxColumn9.MappingName = "pac_fecnac"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 90
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Sexo"
        Me.DataGridTextBoxColumn10.MappingName = "pac_sexo"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 60
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "pac_obs"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "pac_mail"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Hist Clinica"
        Me.DataGridTextBoxColumn13.MappingName = "PAC_HIST_CLINICA"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "UsaFecNac"
        Me.DataGridTextBoxColumn14.MappingName = "PAC_USAFECNAC"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "grado"
        Me.DataGridTextBoxColumn15.MappingName = "pac_grado"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "parentesco"
        Me.DataGridTextBoxColumn16.MappingName = "pac_parentesco"
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "LIFE"
        Me.DataGridTextBoxColumn17.MappingName = "pac_poliza"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 0
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "PAIS"
        Me.DataGridTextBoxColumn19.MappingName = "PAC_PAIS"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 0
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "PROFESION"
        Me.DataGridTextBoxColumn20.MappingName = "PAC_PROFESION"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 200
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "REDES"
        Me.DataGridTextBoxColumn26.MappingName = "PAC_CONOCIO_FUENTE"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 0
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "OTRO"
        Me.DataGridTextBoxColumn27.MappingName = "PAC_CONOCIO_OTRO"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 0
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "FAMILIA"
        Me.DataGridTextBoxColumn25.MappingName = "PAC_CONOCIO_FAMILIA"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 0
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "PROV_ID"
        Me.DataGridTextBoxColumn18.MappingName = "PROV_ID"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "CIU_ID"
        Me.DataGridTextBoxColumn22.MappingName = "CIU_ID"
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "PROVINCIA"
        Me.DataGridTextBoxColumn21.MappingName = "PROV_NOMBRE"
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "ciu_nombre"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "PROV_VIVE"
        Me.DataGridTextBoxColumn28.MappingName = "PROV_ID_VIVE"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 0
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "CIU_ID_VIVE"
        Me.DataGridTextBoxColumn30.MappingName = "CIU_ID_VIVE"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 0
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "PROV_NOM_VIVE"
        Me.DataGridTextBoxColumn29.MappingName = "PROV_NOMBRE_VIVE"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 0
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "CIU_NOM_VIVE"
        Me.DataGridTextBoxColumn31.MappingName = "CIU_NOMBRE_VIVE"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 0
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "LUGAR VIVE"
        Me.DataGridTextBoxColumn24.MappingName = "PAC_LUGARVIVE"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "APELLIDO"
        '
        'txt_filtro_apellido
        '
        Me.txt_filtro_apellido.BackColor = System.Drawing.Color.LightGreen
        Me.txt_filtro_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro_apellido.Location = New System.Drawing.Point(94, 21)
        Me.txt_filtro_apellido.Name = "txt_filtro_apellido"
        Me.txt_filtro_apellido.Size = New System.Drawing.Size(331, 21)
        Me.txt_filtro_apellido.TabIndex = 1
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(461, 31)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 39)
        Me.btn_imprimir.TabIndex = 22
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_imprimir, "Imprimir reporte de paciente")
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(444, 16)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(143, 30)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "INICIAR BUSQUEDA"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(848, 25)
        Me.pan_barra.TabIndex = 99
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(4, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(192, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GESTION DE PACIENTES"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_buscar
        '
        Me.grp_buscar.BackColor = System.Drawing.Color.Transparent
        Me.grp_buscar.Controls.Add(Me.txt_filtro_apellido)
        Me.grp_buscar.Controls.Add(Me.Label2)
        Me.grp_buscar.Controls.Add(Me.btn_buscar)
        Me.grp_buscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_buscar.ForeColor = System.Drawing.Color.Navy
        Me.grp_buscar.Location = New System.Drawing.Point(12, 72)
        Me.grp_buscar.Name = "grp_buscar"
        Me.grp_buscar.Size = New System.Drawing.Size(610, 53)
        Me.grp_buscar.TabIndex = 101
        Me.grp_buscar.TabStop = False
        Me.grp_buscar.Text = "BUSCAR"
        '
        'grp_Supo
        '
        Me.grp_Supo.Controls.Add(Me.txt_SupoOtro)
        Me.grp_Supo.Controls.Add(Me.rbt_SupoOtro)
        Me.grp_Supo.Controls.Add(Me.rbt_SupoFam)
        Me.grp_Supo.Controls.Add(Me.rbt_SupoInternet)
        Me.grp_Supo.Controls.Add(Me.rbt_SupoFace)
        Me.grp_Supo.Controls.Add(Me.rbt_SupoInstagram)
        Me.grp_Supo.Location = New System.Drawing.Point(658, 124)
        Me.grp_Supo.Name = "grp_Supo"
        Me.grp_Supo.Size = New System.Drawing.Size(176, 245)
        Me.grp_Supo.TabIndex = 210
        Me.grp_Supo.TabStop = False
        '
        'txt_SupoOtro
        '
        Me.txt_SupoOtro.BackColor = System.Drawing.SystemColors.Control
        Me.txt_SupoOtro.Enabled = False
        Me.txt_SupoOtro.Location = New System.Drawing.Point(6, 209)
        Me.txt_SupoOtro.Name = "txt_SupoOtro"
        Me.txt_SupoOtro.Size = New System.Drawing.Size(159, 21)
        Me.txt_SupoOtro.TabIndex = 26
        '
        'rbt_SupoOtro
        '
        Me.rbt_SupoOtro.AutoSize = True
        Me.rbt_SupoOtro.ForeColor = System.Drawing.Color.Black
        Me.rbt_SupoOtro.Location = New System.Drawing.Point(17, 167)
        Me.rbt_SupoOtro.Name = "rbt_SupoOtro"
        Me.rbt_SupoOtro.Size = New System.Drawing.Size(47, 17)
        Me.rbt_SupoOtro.TabIndex = 25
        Me.rbt_SupoOtro.Text = "Otro"
        Me.rbt_SupoOtro.UseVisualStyleBackColor = True
        '
        'rbt_SupoFam
        '
        Me.rbt_SupoFam.AutoSize = True
        Me.rbt_SupoFam.Checked = True
        Me.rbt_SupoFam.ForeColor = System.Drawing.Color.Black
        Me.rbt_SupoFam.Location = New System.Drawing.Point(17, 29)
        Me.rbt_SupoFam.Name = "rbt_SupoFam"
        Me.rbt_SupoFam.Size = New System.Drawing.Size(109, 17)
        Me.rbt_SupoFam.TabIndex = 21
        Me.rbt_SupoFam.TabStop = True
        Me.rbt_SupoFam.Text = "Familiar/Conocido"
        Me.rbt_SupoFam.UseVisualStyleBackColor = True
        '
        'rbt_SupoInternet
        '
        Me.rbt_SupoInternet.AutoSize = True
        Me.rbt_SupoInternet.ForeColor = System.Drawing.Color.Black
        Me.rbt_SupoInternet.Location = New System.Drawing.Point(17, 131)
        Me.rbt_SupoInternet.Name = "rbt_SupoInternet"
        Me.rbt_SupoInternet.Size = New System.Drawing.Size(65, 17)
        Me.rbt_SupoInternet.TabIndex = 24
        Me.rbt_SupoInternet.Text = "Internet"
        Me.rbt_SupoInternet.UseVisualStyleBackColor = True
        '
        'rbt_SupoFace
        '
        Me.rbt_SupoFace.AutoSize = True
        Me.rbt_SupoFace.ForeColor = System.Drawing.Color.Black
        Me.rbt_SupoFace.Location = New System.Drawing.Point(17, 60)
        Me.rbt_SupoFace.Name = "rbt_SupoFace"
        Me.rbt_SupoFace.Size = New System.Drawing.Size(71, 17)
        Me.rbt_SupoFace.TabIndex = 22
        Me.rbt_SupoFace.Text = "Facebook"
        Me.rbt_SupoFace.UseVisualStyleBackColor = True
        '
        'rbt_SupoInstagram
        '
        Me.rbt_SupoInstagram.AutoSize = True
        Me.rbt_SupoInstagram.ForeColor = System.Drawing.Color.Black
        Me.rbt_SupoInstagram.Location = New System.Drawing.Point(17, 94)
        Me.rbt_SupoInstagram.Name = "rbt_SupoInstagram"
        Me.rbt_SupoInstagram.Size = New System.Drawing.Size(74, 17)
        Me.rbt_SupoInstagram.TabIndex = 23
        Me.rbt_SupoInstagram.Text = "Instagram"
        Me.rbt_SupoInstagram.UseVisualStyleBackColor = True
        '
        'lbl_ComoSupo
        '
        Me.lbl_ComoSupo.AutoSize = True
        Me.lbl_ComoSupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ComoSupo.ForeColor = System.Drawing.Color.Black
        Me.lbl_ComoSupo.Location = New System.Drawing.Point(672, 112)
        Me.lbl_ComoSupo.Name = "lbl_ComoSupo"
        Me.lbl_ComoSupo.Size = New System.Drawing.Size(117, 13)
        Me.lbl_ComoSupo.TabIndex = 209
        Me.lbl_ComoSupo.Text = "COMO NOS CONOCIO"
        '
        'chk_LIFE
        '
        Me.chk_LIFE.AutoSize = True
        Me.chk_LIFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_LIFE.ForeColor = System.Drawing.Color.Black
        Me.chk_LIFE.Location = New System.Drawing.Point(51, 30)
        Me.chk_LIFE.Name = "chk_LIFE"
        Me.chk_LIFE.Size = New System.Drawing.Size(57, 22)
        Me.chk_LIFE.TabIndex = 219
        Me.chk_LIFE.Text = "LIFE"
        Me.chk_LIFE.UseVisualStyleBackColor = True
        '
        'chk_cliente
        '
        Me.chk_cliente.AutoSize = True
        Me.chk_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_cliente.ForeColor = System.Drawing.Color.Black
        Me.chk_cliente.Location = New System.Drawing.Point(51, 49)
        Me.chk_cliente.Name = "chk_cliente"
        Me.chk_cliente.Size = New System.Drawing.Size(89, 22)
        Me.chk_cliente.TabIndex = 220
        Me.chk_cliente.Text = "CLIENTE"
        Me.chk_cliente.UseVisualStyleBackColor = True
        '
        'frm_Paciente
        '
        Me.AcceptButton = Me.btn_buscar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(848, 626)
        Me.Controls.Add(Me.chk_cliente)
        Me.Controls.Add(Me.chk_LIFE)
        Me.Controls.Add(Me.grp_Supo)
        Me.Controls.Add(Me.lbl_ComoSupo)
        Me.Controls.Add(Me.grp_buscar)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Dgrd_paciente)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Grp_paciente)
        Me.Controls.Add(Me.cmb_grado)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Paciente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        Me.Grp_paciente.ResumeLayout(False)
        Me.Grp_paciente.PerformLayout()
        Me.grp_Nac.ResumeLayout(False)
        Me.grp_Nac.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrd_paciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_buscar.ResumeLayout(False)
        Me.grp_buscar.PerformLayout()
        Me.grp_Supo.ResumeLayout(False)
        Me.grp_Supo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    'declaracion de variables
    Dim opr_ciudad As New Cls_Ciudad()
    Dim opr_paciente As New Cls_Paciente()
    Dim lng_pac_id As Long
    Dim sng_flag, sng_aux As Single
    Dim dtv_paciente As New DataView()
    Dim indice, var_grado As String
    Public sw_viene As Boolean
    Dim var_life As Integer
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



    Private Sub Cmb_tipodoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_tipodoc.SelectedIndexChanged
        'verifico que opcion escogi del combo de tipo de documentos
        'en base a eso muestro o oculto los diferentes cuadros de texto
        If Cmb_tipodoc.Text = "CEDULA" Then
            Ctl_txt_doc.Visible = True
            Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
            Ctl_txt_doc.texto_Asigna("")
        Else
            If Cmb_tipodoc.Text = "RUC" Then
                Ctl_txt_doc.Visible = True
                Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.RUC
                Ctl_txt_doc.texto_Asigna("")
            Else
                If Cmb_tipodoc.Text = "PASAPORTE" Then
                    Ctl_txt_doc.Visible = True
                    Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Pasaporte
                    Ctl_txt_doc.texto_Asigna("")
                Else
                    If Cmb_tipodoc.Text = "NINGUNO" Then
                        Ctl_txt_doc.texto_Asigna("")
                        Ctl_txt_doc.Visible = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub frm_Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txt_filtro_apellido.Focus()
        txt_filtro_apellido.Select()
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'lleno el combo de la ciudad

        'System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)
        opr_ciudad.LlenarComboProvincia(cmb_Provincia)
        opr_ciudad.LlenarComboCiudad(Cmb_ciudad, CInt(System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)))

        opr_ciudad.LlenarComboProvincia(cmb_ProvinciaVive)
        opr_ciudad.LlenarComboCiudad(Cmb_ciudadVive, CInt(System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)))

        cmb_Provincia.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)
        Cmb_ciudad.Text = System.Configuration.ConfigurationSettings.AppSettings("CIU_NOM").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("CIU_ID").PadRight(10)

        cmb_ProvinciaVive.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)
        Cmb_ciudadVive.Text = System.Configuration.ConfigurationSettings.AppSettings("CIU_NOM").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("CIU_ID").PadRight(10)

        Ctl_txt_Pais.texto_Asigna("ECUADOR")

        'Cmb_ciudad.Text = g_ciu_nom.ToString().PadRight(100) & g_ciu_id.ToString().PadRight(10)

        Ctl_txt_apellido.txt_padre.MaxLength = 50
        Ctl_txt_nombre.txt_padre.MaxLength = 50
        Ctl_txt_direccion.txt_padre.MaxLength = 150
        Ctl_txt_fono.txt_padre.MaxLength = 30
        Ctl_txt_mail.txt_padre.MaxLength = 50
        Cmb_tipodoc.SelectedIndex = 0
        Cmb_sexo.SelectedIndex = 0
        cmb_grado.SelectedIndex = 0
        chk_LIFE.Checked = False
        txt_edad.Text = ""
        'lleno el grid con los datos de los pacientes
        'Dgrd_paciente.DataSource = dtv_paciente
        'opr_paciente.LlenarGridPaciente(dtv_paciente)
        txt_hisClinica.Text = opr_paciente.buscamaxHC() + 1
        'txt_hisClinica.Text = txt_hisClinica.Text
        btn_eliminar.Enabled = False
        btn_aceptar.Enabled = False
        Grp_paciente.Enabled = False
        Dtp_fecnac.Value = Format(Now, "yyyy/MM/dd")

        txt_filtro_apellido.Focus()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub Dgrd_paciente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrd_paciente.CurrentCellChanged
        Grp_paciente.Enabled = True
        txt_hisClinica.Text = ""
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = Dgrd_paciente.CurrentCell.RowNumber
        Dgrd_paciente.CurrentCell = dgc_celda
        Dgrd_paciente.Select(Dgrd_paciente.CurrentCell.RowNumber)
        'Obtiene los datos de del grid y los pasa a los cuadros de texto
        Cmb_tipodoc.SelectedIndex = (Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 2) - 1)
        'valido el tipo de documento 
        If (Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 2).ToString) = 1 Then
            Ctl_txt_doc.Visible = True
            Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
            Ctl_txt_doc.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 1).ToString)
        Else
            If (Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 2).ToString) = 2 Then
                Ctl_txt_doc.Visible = True
                Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.RUC
                Ctl_txt_doc.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 1).ToString)
            Else
                If (Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 2).ToString) = 3 Then
                    Ctl_txt_doc.Visible = True
                    Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Pasaporte
                    Ctl_txt_doc.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 1).ToString)
                Else
                    If Cmb_tipodoc.Text = "NINGUNO" Then
                        Ctl_txt_doc.Visible = False
                    End If
                End If
            End If
        End If
        'subo los datos del grid a los cuadros de texto de la parta superior
        Ctl_txt_apellido.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 3).ToString)
        Ctl_txt_nombre.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 4).ToString)
        Ctl_txt_direccion.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 5).ToString)
        Ctl_txt_fono.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 6).ToString)
        Ctl_txt_mail.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 10).ToString)
        Dtp_fecnac.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 7).ToString

        Txt_obs.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 9).ToString
        txt_hisClinica.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 11).ToString
        Cmb_sexo.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 8).ToString

        If Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 13).ToString = "CLIENTE" Then
            chk_cliente.Checked = True
        Else
            chk_cliente.Checked = False
        End If
        'Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 13).ToString

        If Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 15).ToString = 1 Then
            chk_LIFE.Checked = True
        Else
            chk_LIFE.Checked = False
        End If

        Ctl_txt_Pais.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 16).ToString)
        Ctl_txt_Profesion.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 17).ToString)

        If Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 18).ToString <> "" Then
            Dim arre_Supo As String() = Split(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 18).ToString, "|")
            Dim param As String()
            Dim i As Integer
            For i = 0 To UBound(arre_Supo) - 1
                param = Split(arre_Supo(i), ",")
                Select Case param(0)
                    Case "Instagram"
                        If param(1) = 1 Then
                            rbt_SupoInstagram.Checked = True
                        Else
                            rbt_SupoInstagram.Checked = False
                        End If
                    Case "Facebook"
                        If param(1) = 1 Then
                            rbt_SupoFace.Checked = True
                        Else
                            rbt_SupoFace.Checked = False
                        End If
                    Case "Internet"
                        If param(1) = 1 Then
                            rbt_SupoInternet.Checked = True
                        Else
                            rbt_SupoInternet.Checked = False
                        End If
                    Case "Familiar/Conocido"
                        If param(1) = 1 Then
                            rbt_SupoFam.Checked = True
                        Else
                            rbt_SupoFam.Checked = False
                        End If
                    Case "Otro"
                        If param(1) = 1 Then
                            rbt_SupoOtro.Checked = True
                        Else
                            rbt_SupoOtro.Checked = False
                        End If
                End Select
            Next
        Else

        End If

        If Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 19).ToString <> "" Then
            txt_SupoOtro.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 19).ToString
        End If
        If Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 20).ToString <> "" Then
            txt_SupoOtro.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 20).ToString
        End If


        cmb_Provincia.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 23).ToString.PadRight(100) & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 21).ToString.PadRight(10)
        Cmb_ciudad.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 24).ToString.PadRight(100) & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 22).ToString.PadRight(10)

        If Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 12).ToString = "0" Then
            rbtn_no.Checked = True
        Else
            rbtn_si.Checked = True
        End If

        'segun el codigo de la ciudad ubico en el combo dicha ciudad
        '' '' ''For sng_aux = 0 To Cmb_ciudad.Items.Count - 1
        '' '' ''    cmb_Provincia.SelectedIndex = sng_aux
        '' '' ''    If Trim(Mid(cmb_Provincia.Text, 101, 110)) = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 17).ToString Then
        '' '' ''        Exit For
        '' '' ''    End If
        '' '' ''Next


        'For sng_aux = 0 To Cmb_ciudad.Items.Count - 1
        '    Cmb_ciudad.SelectedIndex = sng_aux
        '    If Trim(Cmb_ciudad.Text.Substring(0, 50)) = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 6).ToString Then
        '        Exit For
        '    End If
        'Next

        'Ctl_txt_LugarNac.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 22).ToString)


        cmb_ProvinciaVive.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 27).ToString.PadRight(100) & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 25).ToString.PadRight(10)
        Cmb_ciudadVive.Text = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 28).ToString.PadRight(100) & Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 26).ToString.PadRight(10)

        Ctl_txt_LugarVive.texto_Asigna(Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 29).ToString)

        lng_pac_id = Dgrd_paciente.Item(Dgrd_paciente.CurrentCell.RowNumber, 0).ToString


        'oculto los botones
        btn_eliminar.Enabled = True
        btn_aceptar.Enabled = True
        'pongo el flag en uno para saber si modifico algo y presiono aceptar se quees una modificacion
        sng_flag = 1

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        'activo los grupos
        Grp_paciente.Enabled = True
        Cmb_tipodoc.SelectedIndex = 0
        Ctl_txt_doc.Visible = True
        'limpio los campos
        Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
        Ctl_txt_doc.texto_Asigna("")
        Ctl_txt_apellido.texto_Asigna("")
        Ctl_txt_nombre.texto_Asigna("")
        Ctl_txt_direccion.texto_Asigna("")
        Ctl_txt_fono.texto_Asigna("")
        Ctl_txt_mail.texto_Asigna("")
        Ctl_txt_Pais.texto_Asigna("")
        Ctl_txt_Profesion.texto_Asigna("NA")
        Ctl_txt_LugarVive.texto_Asigna("NA")
        Txt_obs.Text = ""
        txt_hisClinica.Text = ""
        rbt_SupoFam.Checked = True
        Cmb_sexo.SelectedIndex = 0
        cmb_Provincia.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)
        Cmb_ciudad.Text = System.Configuration.ConfigurationSettings.AppSettings("CIU_NOM").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("CIU_ID").PadRight(10)

        cmb_ProvinciaVive.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)
        Cmb_ciudadVive.Text = System.Configuration.ConfigurationSettings.AppSettings("CIU_NOM").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("CIU_ID").PadRight(10)
        Ctl_txt_Pais.texto_Asigna("ECUADOR")
        Dtp_fecnac.Text = Format(Now, "yyyy/MM/dd")
        txt_edad.Text = ""
        txt_filtro_apellido.Text = ""
        btn_nuevo.Enabled = False
        btn_aceptar.Enabled = True
        btn_eliminar.Enabled = False
        txt_hisClinica.Text = opr_paciente.buscamaxHC() + 1

        Ctl_txt_doc.Focus()
        'doy el valor de 0 al flag par saber que cuando presiono aceptar se que es para ingresar un nuevo registro
        sng_flag = 0
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        'mando a guardar el nuevo registro o actualizar segun el flag
        'sng_flag-->0 nuevo registro
        'sng_flag-->1 actualizar registro
        Dim dtr_fila As DataRow
        Dim supo As String

        'verifico lso datos del pacietnes
        If Ctl_txt_apellido.texto_Recupera = "" Then
            MsgBox("Los apellidos del paciente son obligatorios", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            For Each ctlSupo As Control In grp_Supo.Controls
                If TypeOf ctlSupo Is RadioButton Then

                    If DirectCast(ctlSupo, RadioButton).Checked = True Then
                        supo = supo & ctlSupo.Text & ",1|"
                    Else
                        supo = supo & ctlSupo.Text & ",0|"
                    End If
                End If
            Next

            If sng_flag = 0 Then
                Dim bandera As Integer
                bandera = 0
                'verifico que el documento cedula/ruc/pasaporte no se repita    
                If Trim(Ctl_txt_doc.texto_Recupera) <> "" Then
                    If opr_paciente.ComprobarDocPaciente(Trim(Ctl_txt_doc.texto_Recupera)) <> 0 Then
                        bandera = 1
                    End If
                End If


                'si la nadera es 0 es que el documento del paciente no se repite en la base de datos
                If bandera = 0 Then


                    'busco el codigo maximo de los pacientes
                    lng_pac_id = opr_paciente.LeerMaxPaciente() + 1
                    Dim i As Short = 0
                    If rbtn_si.Checked = True Then
                        i = 1
                    Else
                        i = 0
                    End If

                    '                           ByVal pac_id As Long, ByVal pac_doc As String, ByVal pac_tipodoc As Single, ByVal pac_apellido As String,        ByVal pac_nombre As String,          ByVal pac_direccion As String,          ByVal pac_fono As String,          ByVal pac_sexo As ,  ByVal pac_fecnac As Date,   ByVal pac_obs As    ByVal ciu_id As Integer,                  ByVal pac_mail As String,          ByVal his_clinica, usa_fecnac , ByVal pac_grado, '',ByVal var_life, ByVal pac_pais As String,     ByVal pac_profesion As String,           ByVal PAC_CONOCIO_FUENTE As String, '','',              ByVal PROV_ID As Integer,                           ByVal PROV_NOMBRE As String,                ByVal CIU_NOMBRE As String,             ByVal PROV_ID_VIVE As Integer,                         ByVal CI_ID_VIVE As Integer,                 ByVal PROV_NOMBRE_VIVE As String,               ByVal CIU_NOMBRE_VIVE As String,            ByVal PAC_LUGARVIVE As String
                    opr_paciente.GuardarPaciente(lng_pac_id, Trim(Ctl_txt_doc.texto_Recupera), Cmb_tipodoc.SelectedIndex, Trim(Ctl_txt_apellido.texto_Recupera), Trim(Ctl_txt_nombre.texto_Recupera), Trim(Ctl_txt_direccion.texto_Recupera), Trim(Ctl_txt_fono.texto_Recupera), Trim(Cmb_sexo.Text), Trim(Dtp_fecnac.Text), Now, Trim(Txt_obs.Text), CInt(Trim(Mid(Cmb_ciudad.Text, 100, 10))), Trim(Ctl_txt_mail.texto_Recupera), Trim(txt_hisClinica.Text), i, var_grado, "", var_life, Trim(Ctl_txt_Pais.texto_Recupera()), Trim(Ctl_txt_Profesion.texto_Recupera()), supo, Trim(txt_SupoOtro.Text), Trim(txt_SupoOtro.Text), CInt(Trim(cmb_Provincia.Text.Substring(100, 10))), Trim(cmb_Provincia.Text.Substring(0, 100)), Trim(Cmb_ciudad.Text.Substring(0, 100)), CInt(Trim(cmb_ProvinciaVive.Text.Substring(100, 10))), CInt(Trim(Cmb_ciudadVive.Text.Substring(100, 10))), Trim(cmb_ProvinciaVive.Text.Substring(0, 100)), Trim(Cmb_ciudadVive.Text.Substring(0, 100)), Trim(Ctl_txt_LugarVive.texto_Recupera()))
                    'actualiza nuevamente el combo  
                    If sw_viene = True Then
                        inserta_paciente()
                        'inserta_paciente(lng_pac_id, Trim(Ctl_txt_apellido.texto_Recupera), Trim(Ctl_txt_nombre.texto_Recupera), Trim(Dtp_fecnac.Text))
                    End If

                    MsgBox("El nuevo paciente fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
                    'opr_paciente.LlenarGridPaciente(dtv_paciente)
                    'regreso a su estando natural e formulario
                    btn_nuevo.Enabled = True
                    btn_eliminar.Enabled = False
                    btn_aceptar.Enabled = False
                    Cmb_tipodoc.SelectedIndex = 0
                    Ctl_txt_doc.Visible = True
                    Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
                    Ctl_txt_doc.texto_Asigna("")
                    Ctl_txt_apellido.texto_Asigna("")
                    Ctl_txt_nombre.texto_Asigna("")
                    Ctl_txt_direccion.texto_Asigna("")
                    Ctl_txt_fono.texto_Asigna("")
                    Ctl_txt_mail.texto_Asigna("")
                    Ctl_txt_Pais.texto_Asigna("")
                    Ctl_txt_Profesion.texto_Asigna("")
                    cmb_grado.SelectedIndex = 0
                    'cmb_parentesco.SelectedIndex = 0
                    txt_hisClinica.Text = ""
                    Txt_obs.Text = ""
                    Cmb_sexo.SelectedIndex = 0
                    Cmb_ciudad.SelectedIndex = 0
                    'Cmb_ciudad.Text = "SANTO DOMINGO".PadRight(50) & "143".PadRight(10)
                    Dtp_fecnac.Text = Format(Now, "yyyy/MM/dd")
                    Grp_paciente.Enabled = False

                   

                Else
                    'si ya existe un paciente con ese documento
                    MsgBox("El Paciente con esa identificacion ya existe.", MsgBoxStyle.Exclamation, "ANALISYS")
                End If
            Else
                'si el flag es 1 es actualizacionde los datos del paciente
                If sng_flag = 1 Then
                    Dim i As Short
                    If rbtn_si.Checked = True Then
                        i = 1
                    Else
                        i = 0
                    End If
                    opr_paciente.ActualizarPaciente(lng_pac_id, Trim(Ctl_txt_doc.texto_Recupera), Cmb_tipodoc.SelectedIndex, Trim(Ctl_txt_apellido.texto_Recupera), Trim(Ctl_txt_nombre.texto_Recupera), Trim(Ctl_txt_direccion.texto_Recupera), Trim(Ctl_txt_fono.texto_Recupera), Trim(Dtp_fecnac.Text), Trim(Cmb_sexo.Text), Trim(Txt_obs.Text), Trim(Ctl_txt_mail.texto_Recupera), Trim(txt_hisClinica.Text), i, "", "", var_life, Trim(Ctl_txt_Pais.texto_Recupera()), Trim(Ctl_txt_Profesion.texto_Recupera()), supo, Trim(txt_SupoOtro.Text), Trim(txt_SupoOtro.Text), CInt(cmb_Provincia.Text.Substring(100, 10)), CInt(Cmb_ciudad.Text.Substring(100, 10)), Trim(cmb_Provincia.Text.Substring(0, 100)), Trim(Cmb_ciudad.Text.Substring(0, 100)), CInt(cmb_ProvinciaVive.Text.Substring(100, 10)), CInt(Cmb_ciudadVive.Text.Substring(100, 10)), Trim(cmb_ProvinciaVive.Text.Substring(0, 100)), Trim(Cmb_ciudadVive.Text.Substring(0, 100)), Ctl_txt_LugarVive.texto_Recupera())
                    MsgBox("Los datos del paciente fueron actualizados correctamente", MsgBoxStyle.Information, "ANALISYS")
                    'actualizo el datagrid
                    Dgrd_paciente.DataSource = Nothing
                    'opr_paciente.LlenarGridPaciente(dtv_paciente)
                    'regreso el formulario a su estado natural
                    btn_nuevo.Enabled = True
                    btn_aceptar.Enabled = False
                    btn_eliminar.Enabled = False
                    Cmb_tipodoc.SelectedIndex = 0
                    Ctl_txt_doc.Visible = True
                    Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
                    Ctl_txt_doc.texto_Asigna("")
                    Ctl_txt_apellido.texto_Asigna("")
                    Ctl_txt_nombre.texto_Asigna("")
                    Ctl_txt_direccion.texto_Asigna("")
                    Ctl_txt_fono.texto_Asigna("")
                    Ctl_txt_mail.texto_Asigna("")
                    Txt_obs.Text = ""
                    Ctl_txt_Pais.texto_Asigna("")
                    Ctl_txt_Profesion.texto_Asigna("")
                    Cmb_sexo.SelectedIndex = 0
                    Cmb_ciudad.SelectedIndex = 0
                    'Cmb_ciudad.Text = "SANTO DOMINGO".PadRight(50) & "143".PadRight(10)
                    cmb_grado.SelectedIndex = 0
                    'cmb_parentesco.SelectedIndex = 0
                    Dtp_fecnac.Text = Format(Now, "yyyy/MM/dd")
                    Grp_paciente.Enabled = False
                End If
            End If
        End If
        txt_filtro_apellido.Text = ""
    End Sub
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        'elimno un pacientes
        Dim exispac As String
        If MsgBox("Esta seguro de eliminar el paciente?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            exispac = opr_paciente.buscapaciente(lng_pac_id)

            If exispac = 2 Then
                MsgBox("El paciente esta asignado a un pedido. No se puede borrar el paciente", MsgBoxStyle.Information, "ANALISYS")
            Else
                'llamo a la funcion que elimina el paciente envio el id del pacientes
                opr_paciente.EliminarPaciente(lng_pac_id)
                'MsgBox("El paciente fue eliminado", MsgBoxStyle.Information, "ANALISYS")
                'acutalizo el grid
                opr_paciente.LlenarGridPaciente(dtv_paciente)
            End If
        End If
        'regreso el formulario a su estato natural
        btn_eliminar.Enabled = False
        btn_aceptar.Enabled = False
        Cmb_tipodoc.SelectedIndex = 0
        Ctl_txt_doc.Visible = True
        Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
        Ctl_txt_doc.texto_Asigna("")
        Ctl_txt_apellido.texto_Asigna("")
        Ctl_txt_nombre.texto_Asigna("")
        Ctl_txt_direccion.texto_Asigna("")
        cmb_grado.SelectedIndex = 0
        'cmb_parentesco.SelectedIndex = 0
        Ctl_txt_fono.texto_Asigna("")
        Ctl_txt_mail.texto_Asigna("")
        Txt_obs.Text = ""
        Cmb_sexo.SelectedIndex = 0
        Cmb_ciudad.SelectedIndex = 0
        Dtp_fecnac.Text = Now
        Grp_paciente.Enabled = False
    End Sub
    Private Sub txt_filtro_apellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro_apellido.TextChanged
        'cada que presiono unatecla hace un filtro buscnado los coincidenes con esa cadena
        'opr_paciente.LlenarGridPaciente(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
        'opr_paciente.ordena_apellido(txt_filtro_apellido.Text, dtv_paciente)
    End Sub

    Private Sub Dtp_fecnac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_fecnac.ValueChanged
        'funcion para calcular la edad del paciente
        Dim y, yn As Integer
        Dim m, mn As Integer
        Dim d, dn As Integer
        txt_edad.Text = ""
        y = Year(Now)
        yn = Year(Dtp_fecnac.Value)
        m = Month(Now)
        mn = Month(Dtp_fecnac.Value)
        d = Microsoft.VisualBasic.Day(Now)
        dn = Microsoft.VisualBasic.Day(Dtp_fecnac.Value)
        If dn <= d Then
            d = d - dn
        Else
            d = d + 30
            m = m - 1
            d = d - dn
        End If
        If mn <= m Then
            m = m - mn
        Else
            m = m + 12
            y = y - 1
            m = m - mn
        End If
        y = y - yn
        If (y < 2) Then
            If y < 1 Then
                If m > 0 Then
                    txt_edad.Text = (m & " meses")
                Else
                    txt_edad.Text = (d & " dias")
                End If
            Else
                txt_edad.Text = (y & " año y " & m & " meses")
            End If
        Else
            txt_edad.Text = (y & " años ")
        End If

    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_paciente()
        'str_sql = "SELECT pac_id ,if( pac_tipodoc=1,'CEDULA',if(pac_tipodoc=2,'RUC',if(pac_tipodoc=3,'PASAPORTE',if(pac_tipodoc=4,'NINGUNO','')))) as documento, pac_doc, pac_nombre, pac_apellido, pac_direccion, pac_fono, pac_mail, if(pac_sexo='M','MASCULINO',if(pac_sexo='F','FEMENINO','')) as sexo, pac_fecnac, pac_obs, ciu_nombre from paciente, ciudad where paciente.ciu_id=ciudad.ciu_id ORDER BY pac_apellido"
        str_sql = " SELECT pac_id ,pac_doc, pac_nombre, pac_apellido, pac_direccion, pac_fono, pac_mail, pac_sexo, pac_fecnac, pac_obs, ciu_nombre " & _
                "from paciente, ciudad " & _
                "where paciente.ciu_id=ciudad.ciu_id ORDER BY pac_apellido"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Pacientes"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Me.Cursor = Cursors.WaitCursor
        opr_paciente.LlenarGridPaciente2(Dgrd_paciente, Trim(txt_filtro_apellido.Text))
        'opr_paciente.LeerUnPaciente_PARAMETRO(Trim(txt_filtro_apellido.Text), 0)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub rbtn_si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_si.CheckedChanged
        If rbtn_si.Checked = True Then
            Dtp_fecnac.Enabled = True
            Dtp_fecnac.Value = Format(Now, "yyyy/MM/dd")
        Else
            Dtp_fecnac.Value = Format(Now, "yyyy/MM/dd")
            Dtp_fecnac.Enabled = False
        End If
    End Sub




    Private Sub txt_edad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_edad.Leave
        Dim anio As Integer
        Dim palabra As String

        palabra = Trim(txt_edad.Text.Replace("años", ""))

        If IsNumeric(palabra) Then

        Else
            palabra = Trim(txt_edad.Text.Replace("dias", ""))
        End If

        If palabra <> "" Then
            anio = CInt(Format(Now(), "yyyy")) - CInt(palabra)
            Dtp_fecnac.Value = CDate(Format(Now, "dd-MM-") & anio)
        Else

        End If
    End Sub



    Private Sub cmb_Provincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Provincia.SelectedIndexChanged

        opr_ciudad.LlenarComboCiudad(Cmb_ciudad, CInt(Mid(cmb_Provincia.Text, 101, 110)))

    End Sub

    Private Sub rbt_SupoOtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_SupoOtro.CheckedChanged
        If rbt_SupoOtro.Checked = True Then
            txt_SupoOtro.Focus()
            txt_SupoOtro.Enabled = True
        Else
            txt_SupoOtro.Enabled = False
        End If
    End Sub


    Private Sub rbt_SupoInternet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_SupoInternet.CheckedChanged
        If rbt_SupoInternet.Checked = True Then
            txt_SupoOtro.Text = ""
        End If
    End Sub

    Private Sub rbt_SupoInstagram_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_SupoInstagram.CheckedChanged
        If rbt_SupoInstagram.Checked = True Then
            txt_SupoOtro.Text = ""
        End If
    End Sub

    Private Sub rbt_SupoFace_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_SupoFace.CheckedChanged
        If rbt_SupoFace.Checked = True Then
            txt_SupoOtro.Text = ""
        End If
    End Sub

    Private Sub rbt_SupoFam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_SupoFam.CheckedChanged
        'If rbt_SupoFam.Checked = True Then
        '    txt_SupoOtro.Text = ""
        'End If

        If rbt_SupoFam.Checked = True Then
            txt_SupoOtro.Focus()
            txt_SupoOtro.Enabled = True
        Else
            txt_SupoOtro.Enabled = False
        End If
    End Sub

    Private Sub Dgrd_paciente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_paciente.DoubleClick
        If sw_viene = True Then
            inserta_paciente()
        End If
    End Sub

    Private Sub inserta_paciente()
        On Error Resume Next
        Dim ctl As Form
        'Dim ctl2 As frm_Pedido
        'Dim ctl3 As frm_Ing_Remitidos
        'Dim ctl4 As Ingreso_Aspirantes
        Dim ctl5 As frm_AgendaCitaMedica
        Dim opr_pedido As New Cls_Pedido()

        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        For Each ctl In frm_refer_main.MdiChildren

            ctl5 = ctl
            'lng_pac_id, , Trim(Dtp_fecnac.Text)
            ctl5.Tag = "pac_doc=" & Trim(Ctl_txt_doc.texto_Recupera) & "/*/pac_apellido=" & Trim(Ctl_txt_apellido.texto_Recupera) & "/*/pac_nombre=" & Trim(Ctl_txt_nombre.texto_Recupera) & "/*/pac_direccion=" & Trim(Ctl_txt_direccion.texto_Recupera) & "/*/pac_fono=" & Trim(Ctl_txt_fono.texto_Recupera) & "/*/pac_id=" & lng_pac_id & "/*/pac_hist_clinica=" & lng_pac_id & "/*/pac_grado=" & var_grado & "/*/pac_parentesco=''/*/pac_usafecnac=1/*/pac_fecnac=" & Trim(Dtp_fecnac.Text) & "/*/pac_genero=" & Trim(Cmb_sexo.Text)
            ctl5.LLena_datos_paciente_doc()
            'formulario PRE ORDEN
            ctl.Activate()

        Next
        Me.Close()
    End Sub


    Private Sub chk_LIFE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_LIFE.CheckedChanged
        If chk_LIFE.Checked = True Then
            var_life = 1
        Else
            var_life = 0
        End If
    End Sub

    
    Private Sub Ctl_txt_Pais_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_Pais.Leave
        If Ctl_txt_Pais.texto_Recupera() <> "Ecuador" Or Ctl_txt_Pais.texto_Recupera() <> "ECUADOR" Or Ctl_txt_Pais.texto_Recupera() <> "ecuador" Or Ctl_txt_Pais.texto_Recupera() <> "eCUADOR" Then
            cmb_Provincia.Text = "NO APLICA".PadRight(100) & "0".PadRight(10)
        End If
    End Sub

    Private Sub cmb_ProvinciaVive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ProvinciaVive.SelectedIndexChanged
        opr_ciudad.LlenarComboCiudad(Cmb_ciudadVive, CInt(Mid(cmb_ProvinciaVive.Text, 101, 110)))
    End Sub

    Private Sub chk_cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cliente.CheckedChanged

        If chk_cliente.Checked = True Then
            var_grado = "CLIENTE"
        Else
            var_grado = "NINGUNA"
        End If

    End Sub
End Class
