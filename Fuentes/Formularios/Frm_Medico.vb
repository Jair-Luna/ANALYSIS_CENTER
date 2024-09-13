'*************************************************************************
' Nombre:   frm_Medico
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite manipular los Medicos
' Autores:  rfn
' Fecha de Creacion: 
' Autores Modificaciones: 
' Ultima Modificacion: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class Frm_medico
    Inherits System.Windows.Forms.Form
    Dim opr_pedido As New Cls_Pedido()
    Friend WithEvents cmb_Grafico As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Dim grafico As Integer


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
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents S As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_dir As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_fono As System.Windows.Forms.Label
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents ctl_txt_doc As Ctl_txt.ctl_txt_ci_ruc
    Friend WithEvents ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents ctl_txt_dir As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_mail As Ctl_txt.ctl_txt_mail
    Friend WithEvents lbl_tipdoc As System.Windows.Forms.Label
    Friend WithEvents lbl_ciudad As System.Windows.Forms.Label
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_elminar As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_fono As Ctl_txt.ctl_txt_letras
    Friend WithEvents cmb_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents dgrd_medicos As System.Windows.Forms.DataGrid
    Friend WithEvents cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents dgts_medicos As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgcs_nombre As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_fono As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_id As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_doc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_tipodoc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_obs As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_dir As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_mail As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_ciu As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_bonificacion As System.Windows.Forms.ComboBox
    Friend WithEvents dgcs_bon As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_medTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Intervalo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkL As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_HInicio As System.Windows.Forms.ComboBox
    Friend WithEvents chkJ As System.Windows.Forms.CheckBox
    Friend WithEvents chkW As System.Windows.Forms.CheckBox
    Friend WithEvents chkM As System.Windows.Forms.CheckBox
    Friend WithEvents chkD As System.Windows.Forms.CheckBox
    Friend WithEvents chkS As System.Windows.Forms.CheckBox
    Friend WithEvents chkV As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_HFin As System.Windows.Forms.ComboBox
    Friend WithEvents grp_consultas As System.Windows.Forms.GroupBox
    Friend WithEvents dgcs_Hini As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_Hfin As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_Dias As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_Intervalo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_PerfilMedico As System.Windows.Forms.Button
    Friend WithEvents lbl_GrupoNombre As System.Windows.Forms.Label
    Friend WithEvents dgv_MedicosTratantes As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_GeneraReceta As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_AccWeb As System.Windows.Forms.CheckBox
    Friend WithEvents Ctl_txt_WebPass As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_CraeUsrWeb As System.Windows.Forms.Button
    Friend WithEvents grp_UsrWeb As System.Windows.Forms.GroupBox
    Friend WithEvents btn_verPass As System.Windows.Forms.Button
    Friend WithEvents lbl_WebUsr As System.Windows.Forms.Label
    Friend WithEvents LOGIN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PERFILWEB As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcs_espid As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_medico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.S = New System.Windows.Forms.GroupBox
        Me.cmb_Grafico = New System.Windows.Forms.ComboBox
        Me.grp_UsrWeb = New System.Windows.Forms.GroupBox
        Me.lbl_WebUsr = New System.Windows.Forms.Label
        Me.btn_verPass = New System.Windows.Forms.Button
        Me.btn_CraeUsrWeb = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Ctl_txt_WebPass = New Ctl_txt.ctl_txt_letras
        Me.Label9 = New System.Windows.Forms.Label
        Me.chk_GeneraReceta = New System.Windows.Forms.CheckBox
        Me.chk_AccWeb = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox
        Me.lbl_GrupoNombre = New System.Windows.Forms.Label
        Me.dgv_MedicosTratantes = New System.Windows.Forms.DataGridView
        Me.grp_consultas = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_HFin = New System.Windows.Forms.ComboBox
        Me.cmb_Intervalo = New System.Windows.Forms.ComboBox
        Me.chkD = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkS = New System.Windows.Forms.CheckBox
        Me.chkL = New System.Windows.Forms.CheckBox
        Me.chkV = New System.Windows.Forms.CheckBox
        Me.cmb_HInicio = New System.Windows.Forms.ComboBox
        Me.chkJ = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkW = New System.Windows.Forms.CheckBox
        Me.chkM = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_medTipo = New System.Windows.Forms.ComboBox
        Me.cmb_bonificacion = New System.Windows.Forms.ComboBox
        Me.ctl_txt_dir = New Ctl_txt.ctl_txt_letras
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Ctl_txt_fono = New Ctl_txt.ctl_txt_letras
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.cmb_ciudad = New System.Windows.Forms.ComboBox
        Me.lbl_tipdoc = New System.Windows.Forms.Label
        Me.cmb_tipodoc = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_mail = New Ctl_txt.ctl_txt_mail
        Me.ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.ctl_txt_doc = New Ctl_txt.ctl_txt_ci_ruc
        Me.lbl_mail = New System.Windows.Forms.Label
        Me.lbl_fono = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_dir = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txt_obs = New System.Windows.Forms.TextBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.dgrd_medicos = New System.Windows.Forms.DataGrid
        Me.dgts_medicos = New System.Windows.Forms.DataGridTableStyle
        Me.dgcs_obs = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_id = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_nombre = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_fono = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_dir = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_doc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_tipodoc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_mail = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_ciu = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_bon = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_espid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Hini = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Hfin = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Dias = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgcs_Intervalo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LOGIN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PERFILWEB = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_elminar = New System.Windows.Forms.Button
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_PerfilMedico = New System.Windows.Forms.Button
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.S.SuspendLayout()
        Me.grp_UsrWeb.SuspendLayout()
        CType(Me.dgv_MedicosTratantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_consultas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_medicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'S
        '
        Me.S.BackColor = System.Drawing.Color.Transparent
        Me.S.Controls.Add(Me.cmb_Grafico)
        Me.S.Controls.Add(Me.grp_UsrWeb)
        Me.S.Controls.Add(Me.chk_GeneraReceta)
        Me.S.Controls.Add(Me.chk_AccWeb)
        Me.S.Controls.Add(Me.Label7)
        Me.S.Controls.Add(Me.cmb_Provincia)
        Me.S.Controls.Add(Me.lbl_GrupoNombre)
        Me.S.Controls.Add(Me.dgv_MedicosTratantes)
        Me.S.Controls.Add(Me.grp_consultas)
        Me.S.Controls.Add(Me.Label3)
        Me.S.Controls.Add(Me.cmb_medTipo)
        Me.S.Controls.Add(Me.cmb_bonificacion)
        Me.S.Controls.Add(Me.ctl_txt_dir)
        Me.S.Controls.Add(Me.Label1)
        Me.S.Controls.Add(Me.cmb_especialidad)
        Me.S.Controls.Add(Me.Label2)
        Me.S.Controls.Add(Me.Ctl_txt_fono)
        Me.S.Controls.Add(Me.lbl_ciudad)
        Me.S.Controls.Add(Me.cmb_ciudad)
        Me.S.Controls.Add(Me.lbl_tipdoc)
        Me.S.Controls.Add(Me.cmb_tipodoc)
        Me.S.Controls.Add(Me.Ctl_txt_mail)
        Me.S.Controls.Add(Me.ctl_txt_nombre)
        Me.S.Controls.Add(Me.ctl_txt_doc)
        Me.S.Controls.Add(Me.lbl_mail)
        Me.S.Controls.Add(Me.lbl_fono)
        Me.S.Controls.Add(Me.lbl_nombre)
        Me.S.Controls.Add(Me.lbl_dir)
        Me.S.Enabled = False
        Me.S.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S.ForeColor = System.Drawing.Color.Navy
        Me.S.Location = New System.Drawing.Point(15, 80)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(719, 275)
        Me.S.TabIndex = 0
        Me.S.TabStop = False
        '
        'cmb_Grafico
        '
        Me.cmb_Grafico.DisplayMember = "1"
        Me.cmb_Grafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Grafico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Grafico.Items.AddRange(New Object() {"Ninguno", "Fisiograma", "Odontograma"})
        Me.cmb_Grafico.Location = New System.Drawing.Point(614, 191)
        Me.cmb_Grafico.Name = "cmb_Grafico"
        Me.cmb_Grafico.Size = New System.Drawing.Size(99, 21)
        Me.cmb_Grafico.TabIndex = 232
        '
        'grp_UsrWeb
        '
        Me.grp_UsrWeb.Controls.Add(Me.lbl_WebUsr)
        Me.grp_UsrWeb.Controls.Add(Me.btn_verPass)
        Me.grp_UsrWeb.Controls.Add(Me.btn_CraeUsrWeb)
        Me.grp_UsrWeb.Controls.Add(Me.Label8)
        Me.grp_UsrWeb.Controls.Add(Me.Ctl_txt_WebPass)
        Me.grp_UsrWeb.Controls.Add(Me.Label9)
        Me.grp_UsrWeb.Location = New System.Drawing.Point(119, 233)
        Me.grp_UsrWeb.Name = "grp_UsrWeb"
        Me.grp_UsrWeb.Size = New System.Drawing.Size(594, 36)
        Me.grp_UsrWeb.TabIndex = 231
        Me.grp_UsrWeb.TabStop = False
        '
        'lbl_WebUsr
        '
        Me.lbl_WebUsr.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_WebUsr.ForeColor = System.Drawing.Color.Black
        Me.lbl_WebUsr.Location = New System.Drawing.Point(79, 12)
        Me.lbl_WebUsr.Name = "lbl_WebUsr"
        Me.lbl_WebUsr.Size = New System.Drawing.Size(112, 18)
        Me.lbl_WebUsr.TabIndex = 232
        Me.lbl_WebUsr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_verPass
        '
        Me.btn_verPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verPass.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_verPass.Image = CType(resources.GetObject("btn_verPass.Image"), System.Drawing.Image)
        Me.btn_verPass.Location = New System.Drawing.Point(448, 10)
        Me.btn_verPass.Name = "btn_verPass"
        Me.btn_verPass.Size = New System.Drawing.Size(29, 27)
        Me.btn_verPass.TabIndex = 231
        Me.btn_verPass.UseVisualStyleBackColor = True
        '
        'btn_CraeUsrWeb
        '
        Me.btn_CraeUsrWeb.BackColor = System.Drawing.SystemColors.Control
        Me.btn_CraeUsrWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CraeUsrWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CraeUsrWeb.ForeColor = System.Drawing.Color.Black
        Me.btn_CraeUsrWeb.Image = CType(resources.GetObject("btn_CraeUsrWeb.Image"), System.Drawing.Image)
        Me.btn_CraeUsrWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CraeUsrWeb.Location = New System.Drawing.Point(503, 8)
        Me.btn_CraeUsrWeb.Name = "btn_CraeUsrWeb"
        Me.btn_CraeUsrWeb.Size = New System.Drawing.Size(66, 25)
        Me.btn_CraeUsrWeb.TabIndex = 227
        Me.btn_CraeUsrWeb.Text = "Crear"
        Me.btn_CraeUsrWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CraeUsrWeb.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(22, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 228
        Me.Label8.Text = "Usuario"
        '
        'Ctl_txt_WebPass
        '
        Me.Ctl_txt_WebPass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_WebPass.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_WebPass.Location = New System.Drawing.Point(281, 10)
        Me.Ctl_txt_WebPass.Name = "Ctl_txt_WebPass"
        Me.Ctl_txt_WebPass.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_WebPass.Prp_CaracterPasswd = ""
        Me.Ctl_txt_WebPass.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_WebPass.Size = New System.Drawing.Size(165, 20)
        Me.Ctl_txt_WebPass.TabIndex = 230
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(206, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 229
        Me.Label9.Text = "Contraseña"
        '
        'chk_GeneraReceta
        '
        Me.chk_GeneraReceta.AutoSize = True
        Me.chk_GeneraReceta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_GeneraReceta.ForeColor = System.Drawing.Color.Black
        Me.chk_GeneraReceta.Location = New System.Drawing.Point(614, 168)
        Me.chk_GeneraReceta.Name = "chk_GeneraReceta"
        Me.chk_GeneraReceta.Size = New System.Drawing.Size(60, 17)
        Me.chk_GeneraReceta.TabIndex = 86
        Me.chk_GeneraReceta.Text = "Receta"
        Me.chk_GeneraReceta.UseVisualStyleBackColor = True
        '
        'chk_AccWeb
        '
        Me.chk_AccWeb.AutoSize = True
        Me.chk_AccWeb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_AccWeb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AccWeb.ForeColor = System.Drawing.Color.Black
        Me.chk_AccWeb.Location = New System.Drawing.Point(13, 245)
        Me.chk_AccWeb.Name = "chk_AccWeb"
        Me.chk_AccWeb.Size = New System.Drawing.Size(100, 17)
        Me.chk_AccWeb.TabIndex = 225
        Me.chk_AccWeb.Text = "Acceso Web  "
        Me.chk_AccWeb.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(276, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "Provincia"
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Provincia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Provincia.Location = New System.Drawing.Point(340, 44)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(159, 21)
        Me.cmb_Provincia.Sorted = True
        Me.cmb_Provincia.TabIndex = 221
        '
        'lbl_GrupoNombre
        '
        Me.lbl_GrupoNombre.AutoSize = True
        Me.lbl_GrupoNombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GrupoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_GrupoNombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrupoNombre.ForeColor = System.Drawing.Color.Red
        Me.lbl_GrupoNombre.Location = New System.Drawing.Point(506, 20)
        Me.lbl_GrupoNombre.Name = "lbl_GrupoNombre"
        Me.lbl_GrupoNombre.Size = New System.Drawing.Size(68, 13)
        Me.lbl_GrupoNombre.TabIndex = 220
        Me.lbl_GrupoNombre.Text = "MIEMBROS"
        '
        'dgv_MedicosTratantes
        '
        Me.dgv_MedicosTratantes.AllowUserToAddRows = False
        Me.dgv_MedicosTratantes.AllowUserToDeleteRows = False
        Me.dgv_MedicosTratantes.BackgroundColor = System.Drawing.Color.Gray
        Me.dgv_MedicosTratantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_MedicosTratantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_MedicosTratantes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_MedicosTratantes.Location = New System.Drawing.Point(503, 39)
        Me.dgv_MedicosTratantes.Name = "dgv_MedicosTratantes"
        Me.dgv_MedicosTratantes.ReadOnly = True
        Me.dgv_MedicosTratantes.RowHeadersVisible = False
        Me.dgv_MedicosTratantes.Size = New System.Drawing.Size(210, 97)
        Me.dgv_MedicosTratantes.TabIndex = 219
        '
        'grp_consultas
        '
        Me.grp_consultas.Controls.Add(Me.Label5)
        Me.grp_consultas.Controls.Add(Me.cmb_HFin)
        Me.grp_consultas.Controls.Add(Me.cmb_Intervalo)
        Me.grp_consultas.Controls.Add(Me.chkD)
        Me.grp_consultas.Controls.Add(Me.Label4)
        Me.grp_consultas.Controls.Add(Me.chkS)
        Me.grp_consultas.Controls.Add(Me.chkL)
        Me.grp_consultas.Controls.Add(Me.chkV)
        Me.grp_consultas.Controls.Add(Me.cmb_HInicio)
        Me.grp_consultas.Controls.Add(Me.chkJ)
        Me.grp_consultas.Controls.Add(Me.Label6)
        Me.grp_consultas.Controls.Add(Me.chkW)
        Me.grp_consultas.Controls.Add(Me.chkM)
        Me.grp_consultas.ForeColor = System.Drawing.Color.Red
        Me.grp_consultas.Location = New System.Drawing.Point(283, 155)
        Me.grp_consultas.Name = "grp_consultas"
        Me.grp_consultas.Size = New System.Drawing.Size(325, 74)
        Me.grp_consultas.TabIndex = 99
        Me.grp_consultas.TabStop = False
        Me.grp_consultas.Text = "Consultas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(193, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Hora Inicio"
        '
        'cmb_HFin
        '
        Me.cmb_HFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HFin.Items.AddRange(New Object() {"06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00"})
        Me.cmb_HFin.Location = New System.Drawing.Point(262, 44)
        Me.cmb_HFin.Name = "cmb_HFin"
        Me.cmb_HFin.Size = New System.Drawing.Size(52, 21)
        Me.cmb_HFin.Sorted = True
        Me.cmb_HFin.TabIndex = 98
        '
        'cmb_Intervalo
        '
        Me.cmb_Intervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Intervalo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Intervalo.Items.AddRange(New Object() {"05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60"})
        Me.cmb_Intervalo.Location = New System.Drawing.Point(65, 11)
        Me.cmb_Intervalo.Name = "cmb_Intervalo"
        Me.cmb_Intervalo.Size = New System.Drawing.Size(56, 21)
        Me.cmb_Intervalo.Sorted = True
        Me.cmb_Intervalo.TabIndex = 83
        '
        'chkD
        '
        Me.chkD.AutoSize = True
        Me.chkD.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkD.Location = New System.Drawing.Point(144, 36)
        Me.chkD.Name = "chkD"
        Me.chkD.Size = New System.Drawing.Size(19, 31)
        Me.chkD.TabIndex = 97
        Me.chkD.Text = "D"
        Me.chkD.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Intervalo"
        '
        'chkS
        '
        Me.chkS.AutoSize = True
        Me.chkS.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkS.Location = New System.Drawing.Point(120, 36)
        Me.chkS.Name = "chkS"
        Me.chkS.Size = New System.Drawing.Size(18, 31)
        Me.chkS.TabIndex = 96
        Me.chkS.Text = "S"
        Me.chkS.UseVisualStyleBackColor = True
        '
        'chkL
        '
        Me.chkL.AutoSize = True
        Me.chkL.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkL.Location = New System.Drawing.Point(10, 36)
        Me.chkL.Name = "chkL"
        Me.chkL.Size = New System.Drawing.Size(17, 31)
        Me.chkL.TabIndex = 87
        Me.chkL.Text = "L"
        Me.chkL.UseVisualStyleBackColor = True
        '
        'chkV
        '
        Me.chkV.AutoSize = True
        Me.chkV.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkV.Location = New System.Drawing.Point(99, 36)
        Me.chkV.Name = "chkV"
        Me.chkV.Size = New System.Drawing.Size(18, 31)
        Me.chkV.TabIndex = 95
        Me.chkV.Text = "V"
        Me.chkV.UseVisualStyleBackColor = True
        '
        'cmb_HInicio
        '
        Me.cmb_HInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HInicio.Items.AddRange(New Object() {"06:00", "06:30", "07:00", "07:30", "08:00", "08:10", "08:30", "09:00", "09:10", "09:30", "10:00", "10:10", "10:30", "11:00", "11:10", "11:30", "12:00", "12:10", "12:30", "13:00", "13:10", "13:30", "14:00", "14:10", "14:30", "15:00", "15:10", "15:30", "16:00", "16:10", "16:30", "17:00", "17:10", "17:30", "18:00", "18:10", "18:30", "19:00", "19:10", "19:30", "20:00", "20:10", "20:30", "21:00", "21:10", "21:30", "22:00"})
        Me.cmb_HInicio.Location = New System.Drawing.Point(262, 19)
        Me.cmb_HInicio.Name = "cmb_HInicio"
        Me.cmb_HInicio.Size = New System.Drawing.Size(52, 21)
        Me.cmb_HInicio.Sorted = True
        Me.cmb_HInicio.TabIndex = 89
        '
        'chkJ
        '
        Me.chkJ.AutoSize = True
        Me.chkJ.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkJ.Location = New System.Drawing.Point(76, 36)
        Me.chkJ.Name = "chkJ"
        Me.chkJ.Size = New System.Drawing.Size(17, 31)
        Me.chkJ.TabIndex = 94
        Me.chkJ.Text = "J"
        Me.chkJ.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(193, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Hora Fin"
        '
        'chkW
        '
        Me.chkW.AutoSize = True
        Me.chkW.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkW.Location = New System.Drawing.Point(55, 36)
        Me.chkW.Name = "chkW"
        Me.chkW.Size = New System.Drawing.Size(21, 31)
        Me.chkW.TabIndex = 93
        Me.chkW.Text = "M"
        Me.chkW.UseVisualStyleBackColor = True
        '
        'chkM
        '
        Me.chkM.AutoSize = True
        Me.chkM.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkM.Location = New System.Drawing.Point(31, 36)
        Me.chkM.Name = "chkM"
        Me.chkM.Size = New System.Drawing.Size(21, 31)
        Me.chkM.TabIndex = 92
        Me.chkM.Text = "M"
        Me.chkM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Tipo"
        '
        'cmb_medTipo
        '
        Me.cmb_medTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_medTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_medTipo.Items.AddRange(New Object() {"CLIENTE", "GRUPO", "REFERENCIA", "TRATANTE"})
        Me.cmb_medTipo.Location = New System.Drawing.Point(99, 161)
        Me.cmb_medTipo.Name = "cmb_medTipo"
        Me.cmb_medTipo.Size = New System.Drawing.Size(178, 21)
        Me.cmb_medTipo.Sorted = True
        Me.cmb_medTipo.TabIndex = 81
        '
        'cmb_bonificacion
        '
        Me.cmb_bonificacion.DisplayMember = "1"
        Me.cmb_bonificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bonificacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bonificacion.Items.AddRange(New Object() {"CEDULA", "RUC", "PASAPORTE", "NINGUNO"})
        Me.cmb_bonificacion.Location = New System.Drawing.Point(99, 205)
        Me.cmb_bonificacion.Name = "cmb_bonificacion"
        Me.cmb_bonificacion.Size = New System.Drawing.Size(178, 21)
        Me.cmb_bonificacion.TabIndex = 8
        '
        'ctl_txt_dir
        '
        Me.ctl_txt_dir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_dir.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_dir.Location = New System.Drawing.Point(95, 91)
        Me.ctl_txt_dir.Name = "ctl_txt_dir"
        Me.ctl_txt_dir.Prp_CaracterEspecial = New String() {"'"}
        Me.ctl_txt_dir.Prp_CaracterPasswd = ""
        Me.ctl_txt_dir.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.ctl_txt_dir.Size = New System.Drawing.Size(402, 20)
        Me.ctl_txt_dir.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Bonificacion"
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.DisplayMember = "1"
        Me.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_especialidad.Location = New System.Drawing.Point(99, 183)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(178, 21)
        Me.cmb_especialidad.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Especialidad:"
        '
        'Ctl_txt_fono
        '
        Me.Ctl_txt_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_fono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_fono.Location = New System.Drawing.Point(94, 67)
        Me.Ctl_txt_fono.Name = "Ctl_txt_fono"
        Me.Ctl_txt_fono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_fono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_fono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_fono.Size = New System.Drawing.Size(178, 20)
        Me.Ctl_txt_fono.TabIndex = 5
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ciudad.ForeColor = System.Drawing.Color.Black
        Me.lbl_ciudad.Location = New System.Drawing.Point(276, 70)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(45, 13)
        Me.lbl_ciudad.TabIndex = 76
        Me.lbl_ciudad.Text = "Ciudad"
        '
        'cmb_ciudad
        '
        Me.cmb_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ciudad.Location = New System.Drawing.Point(340, 67)
        Me.cmb_ciudad.Name = "cmb_ciudad"
        Me.cmb_ciudad.Size = New System.Drawing.Size(159, 21)
        Me.cmb_ciudad.Sorted = True
        Me.cmb_ciudad.TabIndex = 3
        '
        'lbl_tipdoc
        '
        Me.lbl_tipdoc.AutoSize = True
        Me.lbl_tipdoc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipdoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipdoc.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipdoc.Location = New System.Drawing.Point(15, 48)
        Me.lbl_tipdoc.Name = "lbl_tipdoc"
        Me.lbl_tipdoc.Size = New System.Drawing.Size(72, 13)
        Me.lbl_tipdoc.TabIndex = 74
        Me.lbl_tipdoc.Text = "Documento"
        '
        'cmb_tipodoc
        '
        Me.cmb_tipodoc.DisplayMember = "1"
        Me.cmb_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipodoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipodoc.Items.AddRange(New Object() {"CEDULA", "RUC", "PASAPORTE", "NINGUNO"})
        Me.cmb_tipodoc.Location = New System.Drawing.Point(94, 44)
        Me.cmb_tipodoc.Name = "cmb_tipodoc"
        Me.cmb_tipodoc.Size = New System.Drawing.Size(85, 21)
        Me.cmb_tipodoc.TabIndex = 1
        '
        'Ctl_txt_mail
        '
        Me.Ctl_txt_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_mail.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_mail.Location = New System.Drawing.Point(95, 114)
        Me.Ctl_txt_mail.Name = "Ctl_txt_mail"
        Me.Ctl_txt_mail.Size = New System.Drawing.Size(401, 20)
        Me.Ctl_txt_mail.TabIndex = 6
        '
        'ctl_txt_nombre
        '
        Me.ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_nombre.Location = New System.Drawing.Point(94, 20)
        Me.ctl_txt_nombre.Name = "ctl_txt_nombre"
        Me.ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.ctl_txt_nombre.Size = New System.Drawing.Size(403, 20)
        Me.ctl_txt_nombre.TabIndex = 0
        '
        'ctl_txt_doc
        '
        Me.ctl_txt_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_doc.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_doc.Location = New System.Drawing.Point(182, 44)
        Me.ctl_txt_doc.Name = "ctl_txt_doc"
        Me.ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
        Me.ctl_txt_doc.Size = New System.Drawing.Size(88, 20)
        Me.ctl_txt_doc.TabIndex = 2
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mail.ForeColor = System.Drawing.Color.Black
        Me.lbl_mail.Location = New System.Drawing.Point(17, 119)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(40, 13)
        Me.lbl_mail.TabIndex = 64
        Me.lbl_mail.Text = "Email:"
        '
        'lbl_fono
        '
        Me.lbl_fono.AutoSize = True
        Me.lbl_fono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono.ForeColor = System.Drawing.Color.Black
        Me.lbl_fono.Location = New System.Drawing.Point(15, 71)
        Me.lbl_fono.Name = "lbl_fono"
        Me.lbl_fono.Size = New System.Drawing.Size(56, 13)
        Me.lbl_fono.TabIndex = 62
        Me.lbl_fono.Text = "Telefono"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(15, 25)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(51, 13)
        Me.lbl_nombre.TabIndex = 26
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_dir
        '
        Me.lbl_dir.AutoSize = True
        Me.lbl_dir.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dir.ForeColor = System.Drawing.Color.Black
        Me.lbl_dir.Location = New System.Drawing.Point(16, 95)
        Me.lbl_dir.Name = "lbl_dir"
        Me.lbl_dir.Size = New System.Drawing.Size(59, 13)
        Me.lbl_dir.TabIndex = 20
        Me.lbl_dir.Text = "Direccion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'txt_obs
        '
        Me.txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs.Location = New System.Drawing.Point(185, 408)
        Me.txt_obs.MaxLength = 100
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(360, 20)
        Me.txt_obs.TabIndex = 7
        Me.txt_obs.Visible = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Enabled = False
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(327, 33)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 41)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_cancelar.Location = New System.Drawing.Point(652, 33)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 41)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'dgrd_medicos
        '
        Me.dgrd_medicos.AllowNavigation = False
        Me.dgrd_medicos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_medicos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_medicos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_medicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_medicos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_medicos.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_medicos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_medicos.CaptionText = "Medicos/Instituciones"
        Me.dgrd_medicos.DataMember = ""
        Me.dgrd_medicos.FlatMode = True
        Me.dgrd_medicos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_medicos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_medicos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_medicos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_medicos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_medicos.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_medicos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_medicos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_medicos.Location = New System.Drawing.Point(15, 361)
        Me.dgrd_medicos.Name = "dgrd_medicos"
        Me.dgrd_medicos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_medicos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_medicos.ParentRowsVisible = False
        Me.dgrd_medicos.ReadOnly = True
        Me.dgrd_medicos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_medicos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_medicos.Size = New System.Drawing.Size(719, 187)
        Me.dgrd_medicos.TabIndex = 1
        Me.dgrd_medicos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgts_medicos})
        '
        'dgts_medicos
        '
        Me.dgts_medicos.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.dgts_medicos.BackColor = System.Drawing.Color.LightGray
        Me.dgts_medicos.DataGrid = Me.dgrd_medicos
        Me.dgts_medicos.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgcs_obs, Me.dgcs_id, Me.dgcs_nombre, Me.dgcs_fono, Me.dgcs_dir, Me.dgcs_doc, Me.dgcs_tipodoc, Me.dgcs_mail, Me.dgcs_ciu, Me.dgcs_bon, Me.dgcs_espid, Me.dgcs_Hini, Me.dgcs_Hfin, Me.dgcs_Dias, Me.dgcs_Intervalo, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.LOGIN, Me.PERFILWEB, Me.DataGridTextBoxColumn4})
        Me.dgts_medicos.GridLineColor = System.Drawing.Color.Gray
        Me.dgts_medicos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgts_medicos.HeaderForeColor = System.Drawing.Color.White
        Me.dgts_medicos.MappingName = "Registros"
        Me.dgts_medicos.SelectionBackColor = System.Drawing.Color.Yellow
        Me.dgts_medicos.SelectionForeColor = System.Drawing.Color.Black
        '
        'dgcs_obs
        '
        Me.dgcs_obs.Format = ""
        Me.dgcs_obs.FormatInfo = Nothing
        Me.dgcs_obs.HeaderText = "TIPO"
        Me.dgcs_obs.MappingName = "med_obs"
        Me.dgcs_obs.NullText = ""
        Me.dgcs_obs.Width = 90
        '
        'dgcs_id
        '
        Me.dgcs_id.Format = ""
        Me.dgcs_id.FormatInfo = Nothing
        Me.dgcs_id.MappingName = "MED_ID"
        Me.dgcs_id.NullText = ""
        Me.dgcs_id.Width = 0
        '
        'dgcs_nombre
        '
        Me.dgcs_nombre.Format = ""
        Me.dgcs_nombre.FormatInfo = Nothing
        Me.dgcs_nombre.HeaderText = "Nombre"
        Me.dgcs_nombre.MappingName = "MED_NOMBRE"
        Me.dgcs_nombre.NullText = ""
        Me.dgcs_nombre.Width = 180
        '
        'dgcs_fono
        '
        Me.dgcs_fono.Format = ""
        Me.dgcs_fono.FormatInfo = Nothing
        Me.dgcs_fono.HeaderText = "Telefono"
        Me.dgcs_fono.MappingName = "MED_FONO"
        Me.dgcs_fono.NullText = ""
        Me.dgcs_fono.Width = 80
        '
        'dgcs_dir
        '
        Me.dgcs_dir.Format = ""
        Me.dgcs_dir.FormatInfo = Nothing
        Me.dgcs_dir.HeaderText = "Direccion"
        Me.dgcs_dir.MappingName = "med_direccion"
        Me.dgcs_dir.NullText = ""
        Me.dgcs_dir.Width = 75
        '
        'dgcs_doc
        '
        Me.dgcs_doc.Format = ""
        Me.dgcs_doc.FormatInfo = Nothing
        Me.dgcs_doc.MappingName = "med_doc"
        Me.dgcs_doc.NullText = ""
        Me.dgcs_doc.Width = 0
        '
        'dgcs_tipodoc
        '
        Me.dgcs_tipodoc.Format = ""
        Me.dgcs_tipodoc.FormatInfo = Nothing
        Me.dgcs_tipodoc.MappingName = "med_tipodoc"
        Me.dgcs_tipodoc.NullText = ""
        Me.dgcs_tipodoc.Width = 0
        '
        'dgcs_mail
        '
        Me.dgcs_mail.Format = ""
        Me.dgcs_mail.FormatInfo = Nothing
        Me.dgcs_mail.MappingName = "med_mail"
        Me.dgcs_mail.NullText = ""
        Me.dgcs_mail.Width = 0
        '
        'dgcs_ciu
        '
        Me.dgcs_ciu.Format = ""
        Me.dgcs_ciu.FormatInfo = Nothing
        Me.dgcs_ciu.MappingName = "ciu_id"
        Me.dgcs_ciu.NullText = ""
        Me.dgcs_ciu.Width = 0
        '
        'dgcs_bon
        '
        Me.dgcs_bon.Format = ""
        Me.dgcs_bon.FormatInfo = Nothing
        Me.dgcs_bon.MappingName = "bon_nombre"
        Me.dgcs_bon.NullText = ""
        Me.dgcs_bon.ReadOnly = True
        Me.dgcs_bon.Width = 0
        '
        'dgcs_espid
        '
        Me.dgcs_espid.Format = ""
        Me.dgcs_espid.FormatInfo = Nothing
        Me.dgcs_espid.MappingName = "esp_id"
        Me.dgcs_espid.Width = 0
        '
        'dgcs_Hini
        '
        Me.dgcs_Hini.Format = ""
        Me.dgcs_Hini.FormatInfo = Nothing
        Me.dgcs_Hini.HeaderText = "H INICIO"
        Me.dgcs_Hini.MappingName = "Med_Inicio"
        Me.dgcs_Hini.NullText = ""
        Me.dgcs_Hini.Width = 40
        '
        'dgcs_Hfin
        '
        Me.dgcs_Hfin.Format = ""
        Me.dgcs_Hfin.FormatInfo = Nothing
        Me.dgcs_Hfin.HeaderText = "H INICIO"
        Me.dgcs_Hfin.MappingName = "Med_Fin"
        Me.dgcs_Hfin.NullText = ""
        Me.dgcs_Hfin.Width = 40
        '
        'dgcs_Dias
        '
        Me.dgcs_Dias.Format = ""
        Me.dgcs_Dias.FormatInfo = Nothing
        Me.dgcs_Dias.HeaderText = "DIAS"
        Me.dgcs_Dias.MappingName = "Med_Dias"
        Me.dgcs_Dias.NullText = ""
        Me.dgcs_Dias.Width = 0
        '
        'dgcs_Intervalo
        '
        Me.dgcs_Intervalo.Format = ""
        Me.dgcs_Intervalo.FormatInfo = Nothing
        Me.dgcs_Intervalo.HeaderText = "INTERVALO"
        Me.dgcs_Intervalo.MappingName = "MED_INTERVALO"
        Me.dgcs_Intervalo.NullText = ""
        Me.dgcs_Intervalo.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "PROV_D"
        Me.DataGridTextBoxColumn1.MappingName = "PROV_ID"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "RECETA"
        Me.DataGridTextBoxColumn2.MappingName = "med_receta"
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "FIRMA"
        Me.DataGridTextBoxColumn3.MappingName = "med_firma"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'LOGIN
        '
        Me.LOGIN.Format = ""
        Me.LOGIN.FormatInfo = Nothing
        Me.LOGIN.HeaderText = "LOGIN"
        Me.LOGIN.MappingName = "USR_ID"
        Me.LOGIN.NullText = ""
        Me.LOGIN.ReadOnly = True
        Me.LOGIN.Width = 55
        '
        'PERFILWEB
        '
        Me.PERFILWEB.Format = ""
        Me.PERFILWEB.FormatInfo = Nothing
        Me.PERFILWEB.HeaderText = "PASS"
        Me.PERFILWEB.MappingName = "PERFIL_WEB"
        Me.PERFILWEB.NullText = ""
        Me.PERFILWEB.ReadOnly = True
        Me.PERFILWEB.Width = 70
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(245, 33)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(80, 41)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_elminar
        '
        Me.btn_elminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_elminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_elminar.Enabled = False
        Me.btn_elminar.ForeColor = System.Drawing.Color.Black
        Me.btn_elminar.Image = CType(resources.GetObject("btn_elminar.Image"), System.Drawing.Image)
        Me.btn_elminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_elminar.Location = New System.Drawing.Point(409, 33)
        Me.btn_elminar.Name = "btn_elminar"
        Me.btn_elminar.Size = New System.Drawing.Size(80, 41)
        Me.btn_elminar.TabIndex = 4
        Me.btn_elminar.Text = "Eliminar"
        Me.btn_elminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_elminar.UseVisualStyleBackColor = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(491, 33)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 41)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(750, 25)
        Me.pan_barra.TabIndex = 100
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(4, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(191, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GESTION DE MEDICOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_PerfilMedico
        '
        Me.btn_PerfilMedico.BackColor = System.Drawing.SystemColors.Control
        Me.btn_PerfilMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PerfilMedico.ForeColor = System.Drawing.Color.Black
        Me.btn_PerfilMedico.Image = CType(resources.GetObject("btn_PerfilMedico.Image"), System.Drawing.Image)
        Me.btn_PerfilMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_PerfilMedico.Location = New System.Drawing.Point(572, 33)
        Me.btn_PerfilMedico.Name = "btn_PerfilMedico"
        Me.btn_PerfilMedico.Size = New System.Drawing.Size(80, 41)
        Me.btn_PerfilMedico.TabIndex = 101
        Me.btn_PerfilMedico.Text = "Miembros"
        Me.btn_PerfilMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PerfilMedico.UseVisualStyleBackColor = False
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "GRAFICO"
        Me.DataGridTextBoxColumn4.MappingName = "MED_GRAFICO"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'Frm_medico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(750, 560)
        Me.Controls.Add(Me.btn_PerfilMedico)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_elminar)
        Me.Controls.Add(Me.dgrd_medicos)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.S)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_medico"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medico"
        Me.S.ResumeLayout(False)
        Me.S.PerformLayout()
        Me.grp_UsrWeb.ResumeLayout(False)
        Me.grp_UsrWeb.PerformLayout()
        CType(Me.dgv_MedicosTratantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_consultas.ResumeLayout(False)
        Me.grp_consultas.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_medicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'bandera para reconocer si la operacion es Nuevo = True, Actualiza = False
    Private boo_Flag As Boolean
    Private WithEvents dtt_MedTratante As New DataTable("Registros")
    Dim dtMed As DataTable = New DataTable()
    Dim opr_ciudad As New Cls_Ciudad()
    Dim opr_medico As New Cls_Medico()


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

#Region "Funcionalidad del formulario"

    Sub LimpiaDatos()
        'limpia los datos de las cajas de texto del formulario
        ctl_txt_nombre.texto_Asigna("")
        ctl_txt_doc.texto_Asigna("")
        Ctl_txt_fono.texto_Asigna("")
        ctl_txt_dir.texto_Asigna("")
        Ctl_txt_mail.texto_Asigna("")
        chk_AccWeb.Checked = False
        txt_obs.Text = ""
        cmb_especialidad.SelectedIndex = 0
        cmb_Intervalo.SelectedIndex = 0
        cmb_HInicio.SelectedIndex = 0
        cmb_HFin.SelectedIndex = 0
        For Each ctl1 As Control In Me.grp_consultas.Controls
            If TypeOf ctl1 Is CheckBox Then
                DirectCast(ctl1, CheckBox).Checked = True
            End If
        Next
        chkS.Checked = False
        chkD.Checked = False
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        LimpiaDatos()
        boo_Flag = True
        S.Enabled = True
        btn_aceptar.Enabled = True
        btn_nuevo.Enabled = False
        cmb_bonificacion.SelectedIndex = 0
        cmb_Provincia.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Sub cambia_tipo_doc()
        Select Case cmb_tipodoc.Text
            Case "CEDULA"
                ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
            Case "RUC"
                ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.RUC
            Case "PASAPORTE"
                ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Pasaporte
            Case "NINGUNO"
                ctl_txt_doc.Visible = False
        End Select
    End Sub

    Private Sub cmb_tipdoc_cambiaIndex(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipodoc.SelectedIndexChanged
        ctl_txt_doc.Visible = True
        ctl_txt_doc.texto_Asigna("")
        cambia_tipo_doc()
    End Sub

    Private Sub dgrd_medicos_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_medicos.Enter
        On Error Resume Next
        Efecto_grid()
    End Sub

    Sub Efecto_grid()
        On Error Resume Next
        Dim int_pos_colnum, int_pos_rownum As Integer
        Dim cell_index As DataGridCell
        Dim i As Integer
        Dim arre_dias As String()
        chk_GeneraReceta.Checked = False



        boo_Flag = False
        ctl_txt_nombre.texto_Asigna(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 2))
        ctl_txt_dir.texto_Asigna(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 4))
        Ctl_txt_fono.texto_Asigna(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 3))
        Ctl_txt_mail.texto_Asigna(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 7))
        cmb_medTipo.Text = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 0)
        cmb_bonificacion.Text = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 9)
        cmb_HInicio.Text = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 11)
        cmb_HFin.Text = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 12)
        arre_dias = Split(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 13), "|")
        cmb_Intervalo.Text = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 14)

        If IsDBNull(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 18)) Then
            lbl_WebUsr.Text = ""
            chk_AccWeb.Checked = False
        Else
            lbl_WebUsr.Text = Trim(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 18))
            chk_AccWeb.Checked = True
        End If

        If IsDBNull(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 19)) Then
            Ctl_txt_WebPass.texto_Asigna("")
        Else
            Ctl_txt_WebPass.texto_Asigna(Trim(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 19)))
        End If

        'If IsDBNull(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 18)) Or dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 18) = "" Then
        '    chk_AccWeb.Checked = False
        'Else
        '    chk_AccWeb.Checked = True
        'End If

        If CInt(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 16)) = 0 Then
            chk_GeneraReceta.Checked = False
        Else
            chk_GeneraReceta.Checked = True
        End If

        Select Case CInt(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 20))
            Case 0
                cmb_Grafico.Text = "Ninguno"
            Case 1
                cmb_Grafico.Text = "Fisiograma"
            Case 2
                cmb_Grafico.Text = "Odontograma"
        End Select

        For Each ctl1 As Control In Me.grp_consultas.Controls
            If TypeOf ctl1 Is CheckBox Then
                DirectCast(ctl1, CheckBox).Checked = False
            End If
        Next


        For i = 0 To UBound(arre_dias) - 1
            Select Case arre_dias(i)
                Case "L"
                    chkL.Checked = True
                Case "M"
                    chkM.Checked = True
                Case "W"
                    chkW.Checked = True
                Case "J"
                    chkJ.Checked = True
                Case "V"
                    chkV.Checked = True
                Case "S"
                    chkS.Checked = True
                Case "D"
                    chkD.Checked = True
            End Select

        Next

        For int_pos_rownum = 0 To (cmb_Provincia.Items.Count - 1)
            If (Trim(Mid(cmb_Provincia.Items.Item(int_pos_rownum), 101, 110)) = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 15)) Then
                cmb_Provincia.SelectedIndex = int_pos_rownum
                Exit For
            End If
        Next



        For int_pos_rownum = 0 To (cmb_ciudad.Items.Count - 1)
            If (Trim(Mid(cmb_ciudad.Items.Item(int_pos_rownum), 51, 55)) = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 8)) Then
                cmb_ciudad.SelectedIndex = int_pos_rownum
                Exit For
            End If
        Next

        For int_pos_rownum = 0 To (cmb_especialidad.Items.Count - 1)
            If (cmb_especialidad.Items.Item(int_pos_rownum).substring(75, 5) = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 10)) Then
                cmb_especialidad.SelectedIndex = int_pos_rownum
                Exit For
            End If
        Next


        cmb_tipodoc.SelectedIndex = (dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 6) - 1)
        Call cambia_tipo_doc()
        ctl_txt_doc.texto_Asigna(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 5))
        int_pos_colnum = dgrd_medicos.CurrentCell.ColumnNumber
        int_pos_rownum = dgrd_medicos.CurrentCell.RowNumber
        cell_index.ColumnNumber = 0
        cell_index.RowNumber = int_pos_rownum
        dgrd_medicos.CurrentCell = cell_index
        dgrd_medicos.Select(int_pos_rownum)
        S.Enabled = True
        btn_aceptar.Enabled = True
        btn_elminar.Enabled = True
        btn_nuevo.Enabled = True

        '*********************************************
        '*********** GRID GRUPO MEDICOS TRATANTES **********
        '*********************************************
        Dim dtcMT_columna1 As New DataColumn("con_id", GetType(System.Single))
        Dim dtcMT_columna2 As New DataColumn("med_nombre", GetType(System.String))

        dtt_MedTratante.Columns.Add(dtcMT_columna1)
        dtt_MedTratante.Columns.Add(dtcMT_columna2)

        actualizaDtsMedicoTratanteGrupo(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 1))

        dgv_MedicosTratantes.Columns("con_id").Visible = False
        dgv_MedicosTratantes.Columns("med_nombre").Width = 180
        dgv_MedicosTratantes.Columns("med_nombre").HeaderText = "MEDICO"

        With dgv_MedicosTratantes
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

    End Sub


    Private Sub actualizaDtsMedicoTratanteGrupo(ByVal GMed_id As Integer)
        Dim opr_res As New Cls_Resultado()
        dtt_MedTratante.Clear()
        opr_res.LlenarGrupoMedico(dgv_MedicosTratantes, GMed_id, dtt_MedTratante)
    End Sub

    Private Sub dgrd_medicos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_medicos.CurrentCellChanged
        'para cambio de celda
        Efecto_grid()
    End Sub

#End Region

    Sub graba_registro(ByVal tipo_cal As String)

        Dim opr_med As New Cls_Medico()
        Dim int_id As Integer
        Dim int_indice As Integer
        Dim dias As String = Nothing
        'Dim nombre As String = Nothing

        For Each ctl1 As Control In Me.grp_consultas.Controls
            If TypeOf ctl1 Is CheckBox Then
                If DirectCast(ctl1, CheckBox).Checked = True Then
                    If DirectCast(ctl1, CheckBox).Name = "chkW" Then
                        dias = dias & "W|"
                    Else
                        dias = dias & ctl1.Text & "|"
                    End If

                End If
            End If
        Next

        If Not boo_Flag Then
            'Actualiza
            int_id = dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 1)
            Dim dts_medico As New DataSet()
            dts_medico = dgrd_medicos.DataSource
            For int_indice = 0 To dts_medico.Tables(0).Rows.Count - 1
                'If Trim(dgrd_medicos(int_indice, 1).ToString) = Trim(ctl_txt_nombre.texto_Recupera) And int_id <> CInt(Trim(dgrd_medicos(int_indice, 0).ToString)) Then
                If Trim(dts_medico.Tables(0).Rows(int_indice).Item(4)) = Trim(ctl_txt_nombre.texto_Recupera) And int_id <> CInt(Trim(dts_medico.Tables(0).Rows(int_indice).Item(0))) Then
                    MsgBox("Nombre del Medico/Institucion ya existente", MsgBoxStyle.Exclamation, "ANALISYS")
                    Exit Sub
                End If
                If Trim(dts_medico.Tables(0).Rows(int_indice).Item(4).ToString) = Trim(ctl_txt_doc.texto_Recupera) And Trim(ctl_txt_doc.texto_Recupera) <> "" And int_id <> CInt(Trim(dts_medico.Tables(0).Rows(int_indice).Item(0))) Then
                    MsgBox("Documento de Identidad de Medico/Institucion ya existente", MsgBoxStyle.Exclamation, "ANALISYS")
                    Exit Sub
                End If
            Next
        Else
            'Nuevo
            Dim dts_medico As New DataSet()
            dts_medico = dgrd_medicos.DataSource
            For int_indice = 0 To dts_medico.Tables(0).Rows.Count - 1
                If Trim(dts_medico.Tables(0).Rows(int_indice).Item(1).ToString) = Trim(ctl_txt_nombre.texto_Recupera) Then
                    MsgBox("Nombre del Medico/Institucion ya existente", MsgBoxStyle.Exclamation, "ANALISYS")
                    ctl_txt_nombre.Focus()
                    Exit Sub
                End If
                If Trim(dts_medico.Tables(0).Rows(int_indice).Item(4).ToString) = Trim(ctl_txt_doc.texto_Recupera) And Trim(ctl_txt_doc.texto_Recupera) <> "" Then
                    MsgBox("Documento de Identidad del Medico/Institucion ya existente", MsgBoxStyle.Exclamation, "ANALISYS")
                    ctl_txt_doc.Focus()
                    Exit Sub
                End If
            Next
        End If
        'llamo la funcion para actulizar o crear un nuevo Medico
        Dim medicoId As Integer
        Dim horaIni As String = cmb_HInicio.Text
        Dim horaFin As String = cmb_HFin.Text
        Dim receta As Integer = 0


        If chk_GeneraReceta.Checked = True Then
            receta = 1
        Else
            receta = 0
        End If


        opr_med.OperaMedico(boo_Flag, cmb_ciudad.Text.Substring(50, 5), ctl_txt_doc.texto_Recupera, _
        cmb_tipodoc.SelectedIndex + 1, ctl_txt_nombre.texto_Recupera, cmb_medTipo.Text, Ctl_txt_fono.texto_Recupera, _
        ctl_txt_dir.texto_Recupera, Ctl_txt_mail.texto_Recupera, Trim(cmb_bonificacion.Text), cmb_especialidad.Text.Substring(75, 5), medicoId, cmb_HInicio.Text, cmb_HFin.Text, dias, cmb_Intervalo.Text, CInt(Trim(Mid(cmb_Provincia.Text, 101, 110))), receta, grafico, int_id)

        Dim i As Integer
        'Dim calendario As String()
        Dim opr_agenda As New Cls_Agenda()
        Dim opr_sis As New Cls_sistema()
        Dim age_id As Integer
        Dim totalHoras, totalHoras2 As Integer
        Dim horaTotal As String

        Dim totalTiempo As String()
        Dim param_tiempos As String()
        Dim param_tiempos2 As String()

        ' calendario = Split(opr_agenda.LeerCalendario("Medico", medicoId), ",")


        totalTiempo = Split(opr_sis.sTiempo(horaIni, horaFin), ",")
        param_tiempos = Split(Trim(totalTiempo(1)), " ")

        totalHoras = (CInt(param_tiempos(0)) * 60) / CInt(cmb_Intervalo.Text)

        param_tiempos2 = Split(Trim(totalTiempo(2)), " ")

        If param_tiempos2(0) <> "0" Then
            totalHoras2 = CInt(param_tiempos2(0)) / CInt(cmb_Intervalo.Text)
            totalHoras = totalHoras + totalHoras2
        End If
        opr_agenda.EliminaCalendario("Medico", medicoId)
        opr_agenda.CreaCalendario(opr_agenda.LeeMaximoCalendario(), totalHoras, horaIni, CInt(cmb_Intervalo.Text), "Medico", medicoId)


        boo_Flag = False
        LimpiaDatos()
        'actualizo el grid
        carga_datos_medicos()
    End Sub




    Sub Habilitabtn()
        S.Enabled = False
        btn_elminar.Enabled = False
        btn_aceptar.Enabled = False
        btn_nuevo.Enabled = True
        btn_nuevo.Focus()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        'verifica que le nombre del medico no este vacio
        Dim tipo As String = Nothing
        If Trim(ctl_txt_nombre.texto_Recupera) = "" Then
            MsgBox("El nombre de medico es requerido", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If cmb_medTipo.Text = "Referencia" Then
                tipo = "Laboratorio"
            Else
                tipo = "Medico"
            End If
            graba_registro(tipo)
            Habilitabtn()
        End If
    End Sub

    Private Sub Elminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elminar.Click
        'elimna un medico luego de contestar afirmativa la messagebox
        Dim opr_med As New Cls_Medico()
        Dim exismed As Integer
        If MsgBox("Desea eliminar el medico?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then Exit Sub
        'verifica si el medico esta asignado a algun paciente
        exismed = opr_med.buscamedico(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 1))
        If exismed >= 1 Then
            MsgBox("El medico esta relacionado a una o varias ordenes, no se puede eliminar el registro", MsgBoxStyle.Information, "ANALISYS")
        Else
            'llama a la funcion de elimar el medico, envia el id del Medico
            opr_med.EliminaMedico(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 1))
        End If

        'actualiza el grid
        carga_datos_medicos()
        LimpiaDatos()
        Habilitabtn()
    End Sub

    Sub carga_datos_medicos()
        'acutliza el grid
        Dim opr_medico As New Cls_Medico()
        dgrd_medicos.SetDataBinding(opr_medico.LeerMedico(), "Registros")
    End Sub

    Private Sub Frm_medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'declaracio de variables
        Dim opr_ciu As New Cls_Ciudad()
        Dim dts_ciudad As DataSet
        Dim dtr_filaCiu As DataRow
        Dim opr_bonificacion As New Cls_Bonificacion()

        opr_ciudad.LlenarComboProvincia(cmb_Provincia)

        cmb_Provincia.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)


        cmb_tipodoc.SelectedIndex = 3

        cmb_HInicio.SelectedIndex = 0
        cmb_HFin.SelectedIndex = 0

        cmb_medTipo.SelectedIndex = 0
        'cargo los datos de los Medicos en el datagrid
        carga_datos_medicos()
        'llemo el combo de las bonificaciones
        'envio el combo por referencia
        opr_bonificacion.LlenarComboBonificacion(cmb_bonificacion)
        opr_bonificacion.LlenarComboEspecialidad(cmb_especialidad)
        Habilitabtn()
        ctl_txt_nombre.txt_padre.MaxLength = 100
        Ctl_txt_fono.txt_padre.MaxLength = 30
        ctl_txt_dir.txt_padre.MaxLength = 150
        Ctl_txt_mail.txt_padre.MaxLength = 50
        cmb_especialidad.SelectedIndex = 1
        cmb_Intervalo.SelectedIndex = 2
        cmb_HFin.SelectedIndex = 10
        cmb_Grafico.SelectedIndex = 0

    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_medico()
        'INSTRUCCION SQL PARA OBTENER TODO LOS DATOS DE LOS MEDICOS
        str_sql = "SELECT med_id , 'TIPO DOCUMENTO' as documento, med_doc, med_nombre, med_direccion, med_fono, med_mail, med_obs, bon_nombre, ciu_nombre from medico, ciudad where medico.ciu_id=ciudad.ciu_id ORDER BY med_nombre"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Medicos"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub




    Private Sub btn_PerfilMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PerfilMedico.Click

        'If Not ExisteForm("frm_historico") Then
        Dim frm_MDIChild As New frm_PerfilMedico()
        'frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.med_id = CInt(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber.ToString, 1))
        'frm_MDIChild.Tag = lbl_pacienteD.Tag & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString) & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 14).ToString) & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22).ToString)
        frm_MDIChild.ShowDialog(Me.ParentForm)
        'End If

    End Sub


    Private Sub cmb_Provincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        Dim dtr_filaCiu As DataRow
        Dim dts_ciudad As DataSet

        dts_ciudad = opr_ciudad.LeerCiudad(CInt(Mid(cmb_Provincia.Text, 101, 110)))

        'cargo en el combo los datos del dataset
        For Each dtr_filaCiu In dts_ciudad.Tables("Registros").Rows
            cmb_ciudad.Items.Add(dtr_filaCiu("ciu_nombre").ToString().PadRight(50) & dtr_filaCiu("ciu_id").ToString().PadRight(10))
        Next
        'cmb_tipodoc.SelectedIndex = 3
        cmb_ciudad.Text = g_ciu_nom.ToString().PadRight(50) & g_ciu_id.ToString().PadRight(10)


        '        opr_ciudad.LlenarComboCiudad(cmb_ciudad, CInt(Mid(cmb_Provincia.Text, 101, 110)))


    End Sub

    Private Sub AjustaCliente()
        cmb_Intervalo.Text = "60"
        cmb_HInicio.Text = "18:00"
        cmb_HFin.Text = "22:00"
        cmb_especialidad.Text = "ALERGOLOGO".PadRight(75) & "47".PadRight(5)
        For Each ctl1 As Control In Me.grp_consultas.Controls
            If TypeOf ctl1 Is CheckBox Then
                DirectCast(ctl1, CheckBox).Checked = True
            End If
        Next


    End Sub

    Private Sub cmb_medTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_medTipo.SelectedIndexChanged
        If boo_Flag = True Then
            If cmb_medTipo.Text = "CLIENTE" Then
                AjustaCliente()
            Else
                LimpiaDatos()
            End If
        End If
    End Sub

    Private Sub chk_AccWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AccWeb.CheckedChanged

        If chk_AccWeb.Checked = True Then
            If IsDBNull(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 18)) Then
                grp_UsrWeb.Enabled = True
                Dim cli_med As String = "CLI" & Format(opr_medico.LeerMaxMedico + 1, "0000")
                lbl_WebUsr.Text = cli_med
                Ctl_txt_WebPass.Focus()
            Else
                grp_UsrWeb.Enabled = True
            End If
        Else
            grp_UsrWeb.Enabled = False
        End If



        'If boo_Flag = False Then

        '    If dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 0) = "CLIENTE" Then
        '        If chk_AccWeb.Checked = True Then
        '            grp_UsrWeb.Enabled = True
        '            Dim cli_med As String = "CLI" & Format(opr_medico.LeerMaxMedico + 1, "0000")
        '            lbl_WebUsr.Text = cli_med
        '            Ctl_txt_WebPass.Focus()
        '        Else
        '            grp_UsrWeb.Enabled = False
        '        End If
        '    Else
        '        opr_pedido.VisualizaMensaje("El medico debe ser de tipo CLIENTE para generar credenciales web", 300)
        '        chk_AccWeb.Checked = False
        '    End If

        'Else

        '    If chk_AccWeb.Checked = True Then
        '        If dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 0) = "CLIENTE" Then
        '            grp_UsrWeb.Enabled = True
        '            'Dim cli_med As String = "CLI" & Format(opr_medico.LeerMaxMedico + 1, "0000")
        '        Else
        '            opr_pedido.VisualizaMensaje("El medico debe ser de tipo CLIENTE para generar credenciales web", 300)
        '            chk_AccWeb.Checked = False
        '        End If
        '    Else
        '        grp_UsrWeb.Enabled = False
        '        lbl_WebUsr.Text = ""
        '        Ctl_txt_WebPass.texto_Asigna("")
        '        Ctl_txt_WebPass.Focus()
        '    End If

        'End If

    End Sub

    Private Sub btn_CraeUsrWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CraeUsrWeb.Click
        If (CInt(Ctl_txt_WebPass.texto_Recupera().Length) > 15) = False Then

            'If dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 0) = "CLIENTE" Then
            opr_medico.ActualizaUsuarioWebMedico(lbl_WebUsr.Text, Trim(Ctl_txt_WebPass.texto_Recupera()), CInt(dgrd_medicos.Item(dgrd_medicos.CurrentCell.RowNumber, 1)))
            carga_datos_medicos()
            'Else
            'opr_pedido.VisualizaMensaje("El medico debe ser de tipo CLIENTE para generar credenciales web", 300)
            'End If
        Else
            opr_pedido.VisualizaMensaje("La contraseña no debe superar los 15 caracteres", 300)
        End If
    End Sub


    Private Sub cmb_Grafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Grafico.SelectedIndexChanged
        EscojeGrafico()
    End Sub
    Private Sub EscojeGrafico()
        Select Case cmb_Grafico.Text
            Case "Ninguno"
                grafico = 0
            Case "Fisiograma"
                grafico = 1
            Case "Odontograma"
                grafico = 2
        End Select
    End Sub
End Class
