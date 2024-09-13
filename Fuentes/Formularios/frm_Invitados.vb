Public Class frm_Invitados
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
    Friend WithEvents btn_suspender As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents grp_usuario As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_confcontra As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_pswdconf As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_ci As Ctl_txt.ctl_txt_ci_ruc
    Friend WithEvents Ctl_txt_apellido As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_Direcccion As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellidos As System.Windows.Forms.Label
    Friend WithEvents lbl_CI As System.Windows.Forms.Label
    Friend WithEvents lbl_contrasea As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_pswd As Ctl_txt.ctl_txt_letras
    Friend WithEvents btn_desbloquear As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgrd_usuario As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Ctl_txt_direccion As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_folio As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_cargo As Ctl_txt.ctl_txt_letras
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Ctl_txt_login As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents chkl_areas As System.Windows.Forms.CheckedListBox
    Friend WithEvents Ctl_txt_mail As Ctl_txt.ctl_txt_mail
    Friend WithEvents Ctl_txt_fono As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_letras1 As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents lbl_fono As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_AccesoWeb As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_all As System.Windows.Forms.Button
    Friend WithEvents btn_none As System.Windows.Forms.Button
    Friend WithEvents lbl_contrasenia As System.Windows.Forms.Label
    Friend WithEvents buscar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Invitados))
        Me.btn_suspender = New System.Windows.Forms.Button
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.grp_usuario = New System.Windows.Forms.GroupBox
        Me.lbl_contrasenia = New System.Windows.Forms.Label
        Me.chk_AccesoWeb = New System.Windows.Forms.CheckBox
        Me.cmb_tipo = New System.Windows.Forms.ComboBox
        Me.lbl_tipo = New System.Windows.Forms.Label
        Me.Ctl_txt_mail = New Ctl_txt.ctl_txt_mail
        Me.Ctl_txt_fono = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_letras1 = New Ctl_txt.ctl_txt_letras
        Me.lbl_mail = New System.Windows.Forms.Label
        Me.lbl_fono = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Ctl_txt_folio = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_cargo = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_direccion = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_pswdconf = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_pswd = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_login = New Ctl_txt.ctl_txt_letras
        Me.lbl_usuario = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_confcontra = New System.Windows.Forms.Label
        Me.Ctl_txt_ci = New Ctl_txt.ctl_txt_ci_ruc
        Me.Ctl_txt_apellido = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.lbl_Direcccion = New System.Windows.Forms.Label
        Me.lbl_Nombres = New System.Windows.Forms.Label
        Me.lbl_Apellidos = New System.Windows.Forms.Label
        Me.lbl_CI = New System.Windows.Forms.Label
        Me.buscar = New System.Windows.Forms.Button
        Me.btn_desbloquear = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgrd_usuario = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.cd = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.chkl_areas = New System.Windows.Forms.CheckedListBox
        Me.btn_all = New System.Windows.Forms.Button
        Me.btn_none = New System.Windows.Forms.Button
        Me.grp_usuario.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        CType(Me.dgrd_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_suspender
        '
        Me.btn_suspender.BackColor = System.Drawing.SystemColors.Control
        Me.btn_suspender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suspender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suspender.ForeColor = System.Drawing.Color.Black
        Me.btn_suspender.Image = CType(resources.GetObject("btn_suspender.Image"), System.Drawing.Image)
        Me.btn_suspender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_suspender.Location = New System.Drawing.Point(374, 31)
        Me.btn_suspender.Name = "btn_suspender"
        Me.btn_suspender.Size = New System.Drawing.Size(80, 43)
        Me.btn_suspender.TabIndex = 99
        Me.btn_suspender.Text = "Bloquear"
        Me.btn_suspender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suspender.UseVisualStyleBackColor = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(20, 31)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 43)
        Me.btn_Nuevo.TabIndex = 95
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.UseVisualStyleBackColor = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(456, 31)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 43)
        Me.btn_Salir.TabIndex = 100
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(184, 31)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 43)
        Me.btn_Eliminar.TabIndex = 97
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'grp_usuario
        '
        Me.grp_usuario.BackColor = System.Drawing.Color.Transparent
        Me.grp_usuario.Controls.Add(Me.lbl_contrasenia)
        Me.grp_usuario.Controls.Add(Me.chk_AccesoWeb)
        Me.grp_usuario.Controls.Add(Me.cmb_tipo)
        Me.grp_usuario.Controls.Add(Me.lbl_tipo)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_mail)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_fono)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_letras1)
        Me.grp_usuario.Controls.Add(Me.lbl_mail)
        Me.grp_usuario.Controls.Add(Me.lbl_fono)
        Me.grp_usuario.Controls.Add(Me.Label3)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_folio)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_cargo)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_direccion)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_pswdconf)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_pswd)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_login)
        Me.grp_usuario.Controls.Add(Me.lbl_usuario)
        Me.grp_usuario.Controls.Add(Me.Label2)
        Me.grp_usuario.Controls.Add(Me.Label1)
        Me.grp_usuario.Controls.Add(Me.lbl_confcontra)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_ci)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_apellido)
        Me.grp_usuario.Controls.Add(Me.Ctl_txt_nombre)
        Me.grp_usuario.Controls.Add(Me.lbl_Direcccion)
        Me.grp_usuario.Controls.Add(Me.lbl_Nombres)
        Me.grp_usuario.Controls.Add(Me.lbl_Apellidos)
        Me.grp_usuario.Controls.Add(Me.lbl_CI)
        Me.grp_usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_usuario.ForeColor = System.Drawing.Color.Navy
        Me.grp_usuario.Location = New System.Drawing.Point(20, 86)
        Me.grp_usuario.Name = "grp_usuario"
        Me.grp_usuario.Size = New System.Drawing.Size(660, 205)
        Me.grp_usuario.TabIndex = 93
        Me.grp_usuario.TabStop = False
        '
        'lbl_contrasenia
        '
        Me.lbl_contrasenia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contrasenia.ForeColor = System.Drawing.Color.Black
        Me.lbl_contrasenia.Location = New System.Drawing.Point(338, 150)
        Me.lbl_contrasenia.Name = "lbl_contrasenia"
        Me.lbl_contrasenia.Size = New System.Drawing.Size(87, 24)
        Me.lbl_contrasenia.TabIndex = 30
        Me.lbl_contrasenia.Text = "Contraseña"
        '
        'chk_AccesoWeb
        '
        Me.chk_AccesoWeb.AutoSize = True
        Me.chk_AccesoWeb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_AccesoWeb.ForeColor = System.Drawing.Color.Black
        Me.chk_AccesoWeb.Location = New System.Drawing.Point(365, 51)
        Me.chk_AccesoWeb.Name = "chk_AccesoWeb"
        Me.chk_AccesoWeb.Size = New System.Drawing.Size(74, 17)
        Me.chk_AccesoWeb.TabIndex = 10
        Me.chk_AccesoWeb.Text = "Intranet"
        Me.chk_AccesoWeb.UseVisualStyleBackColor = True
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DisplayMember = "Usuario"
        Me.cmb_tipo.Enabled = False
        Me.cmb_tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.cmb_tipo.Location = New System.Drawing.Point(425, 19)
        Me.cmb_tipo.MaxDropDownItems = 2
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(211, 21)
        Me.cmb_tipo.TabIndex = 8
        Me.cmb_tipo.Text = "Administrador"
        Me.cmb_tipo.ValueMember = "Usuario"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipo.Location = New System.Drawing.Point(389, 22)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(40, 16)
        Me.lbl_tipo.TabIndex = 29
        Me.lbl_tipo.Text = "Tipo"
        '
        'Ctl_txt_mail
        '
        Me.Ctl_txt_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_mail.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_mail.Location = New System.Drawing.Point(122, 171)
        Me.Ctl_txt_mail.Name = "Ctl_txt_mail"
        Me.Ctl_txt_mail.Size = New System.Drawing.Size(209, 21)
        Me.Ctl_txt_mail.TabIndex = 7
        '
        'Ctl_txt_fono
        '
        Me.Ctl_txt_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_fono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_fono.Location = New System.Drawing.Point(122, 123)
        Me.Ctl_txt_fono.Name = "Ctl_txt_fono"
        Me.Ctl_txt_fono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_fono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_fono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_fono.Size = New System.Drawing.Size(98, 21)
        Me.Ctl_txt_fono.TabIndex = 5
        '
        'Ctl_txt_letras1
        '
        Me.Ctl_txt_letras1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_letras1.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_letras1.Location = New System.Drawing.Point(425, 76)
        Me.Ctl_txt_letras1.Name = "Ctl_txt_letras1"
        Me.Ctl_txt_letras1.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_letras1.Prp_CaracterPasswd = ""
        Me.Ctl_txt_letras1.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_letras1.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_letras1.TabIndex = 11
        '
        'lbl_mail
        '
        Me.lbl_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mail.ForeColor = System.Drawing.Color.Black
        Me.lbl_mail.Location = New System.Drawing.Point(50, 171)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(54, 14)
        Me.lbl_mail.TabIndex = 27
        Me.lbl_mail.Text = "email"
        '
        'lbl_fono
        '
        Me.lbl_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono.ForeColor = System.Drawing.Color.Black
        Me.lbl_fono.Location = New System.Drawing.Point(48, 127)
        Me.lbl_fono.Name = "lbl_fono"
        Me.lbl_fono.Size = New System.Drawing.Size(58, 14)
        Me.lbl_fono.TabIndex = 25
        Me.lbl_fono.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(50, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Direccion"
        '
        'Ctl_txt_folio
        '
        Me.Ctl_txt_folio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_folio.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_folio.Location = New System.Drawing.Point(425, 124)
        Me.Ctl_txt_folio.Name = "Ctl_txt_folio"
        Me.Ctl_txt_folio.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_folio.Prp_CaracterPasswd = ""
        Me.Ctl_txt_folio.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_folio.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_folio.TabIndex = 13
        '
        'Ctl_txt_cargo
        '
        Me.Ctl_txt_cargo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_cargo.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_cargo.Location = New System.Drawing.Point(425, 100)
        Me.Ctl_txt_cargo.Name = "Ctl_txt_cargo"
        Me.Ctl_txt_cargo.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_cargo.Prp_CaracterPasswd = ""
        Me.Ctl_txt_cargo.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_cargo.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_cargo.TabIndex = 12
        '
        'Ctl_txt_direccion
        '
        Me.Ctl_txt_direccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_direccion.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_direccion.Location = New System.Drawing.Point(121, 147)
        Me.Ctl_txt_direccion.Name = "Ctl_txt_direccion"
        Me.Ctl_txt_direccion.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_direccion.Prp_CaracterPasswd = ""
        Me.Ctl_txt_direccion.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_direccion.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_direccion.TabIndex = 6
        '
        'Ctl_txt_pswdconf
        '
        Me.Ctl_txt_pswdconf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_pswdconf.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_pswdconf.Location = New System.Drawing.Point(425, 172)
        Me.Ctl_txt_pswdconf.Name = "Ctl_txt_pswdconf"
        Me.Ctl_txt_pswdconf.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_pswdconf.Prp_CaracterPasswd = "*"
        Me.Ctl_txt_pswdconf.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_pswdconf.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_pswdconf.TabIndex = 15
        '
        'Ctl_txt_pswd
        '
        Me.Ctl_txt_pswd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_pswd.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_pswd.Location = New System.Drawing.Point(425, 148)
        Me.Ctl_txt_pswd.Name = "Ctl_txt_pswd"
        Me.Ctl_txt_pswd.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_pswd.Prp_CaracterPasswd = "*"
        Me.Ctl_txt_pswd.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_pswd.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_pswd.TabIndex = 14
        '
        'Ctl_txt_login
        '
        Me.Ctl_txt_login.BackColor = System.Drawing.Color.Khaki
        Me.Ctl_txt_login.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_login.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_login.Location = New System.Drawing.Point(121, 19)
        Me.Ctl_txt_login.Name = "Ctl_txt_login"
        Me.Ctl_txt_login.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_login.Prp_CaracterPasswd = ""
        Me.Ctl_txt_login.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_login.Size = New System.Drawing.Size(113, 22)
        Me.Ctl_txt_login.TabIndex = 1
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.Black
        Me.lbl_usuario.Location = New System.Drawing.Point(49, 23)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(60, 14)
        Me.lbl_usuario.TabIndex = 20
        Me.lbl_usuario.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(385, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Folio"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(378, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Cargo"
        '
        'lbl_confcontra
        '
        Me.lbl_confcontra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confcontra.ForeColor = System.Drawing.Color.Black
        Me.lbl_confcontra.Location = New System.Drawing.Point(338, 176)
        Me.lbl_confcontra.Name = "lbl_confcontra"
        Me.lbl_confcontra.Size = New System.Drawing.Size(87, 24)
        Me.lbl_confcontra.TabIndex = 13
        Me.lbl_confcontra.Text = "Confirmacion Contraseña"
        '
        'Ctl_txt_ci
        '
        Me.Ctl_txt_ci.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_ci.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_ci.Location = New System.Drawing.Point(121, 99)
        Me.Ctl_txt_ci.Name = "Ctl_txt_ci"
        Me.Ctl_txt_ci.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
        Me.Ctl_txt_ci.Size = New System.Drawing.Size(99, 21)
        Me.Ctl_txt_ci.TabIndex = 4
        '
        'Ctl_txt_apellido
        '
        Me.Ctl_txt_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_apellido.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_apellido.Location = New System.Drawing.Point(121, 75)
        Me.Ctl_txt_apellido.Name = "Ctl_txt_apellido"
        Me.Ctl_txt_apellido.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_apellido.Prp_CaracterPasswd = ""
        Me.Ctl_txt_apellido.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_apellido.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_apellido.TabIndex = 3
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(121, 51)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(211, 21)
        Me.Ctl_txt_nombre.TabIndex = 2
        '
        'lbl_Direcccion
        '
        Me.lbl_Direcccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Direcccion.ForeColor = System.Drawing.Color.Black
        Me.lbl_Direcccion.Location = New System.Drawing.Point(379, 80)
        Me.lbl_Direcccion.Name = "lbl_Direcccion"
        Me.lbl_Direcccion.Size = New System.Drawing.Size(62, 14)
        Me.lbl_Direcccion.TabIndex = 5
        Me.lbl_Direcccion.Text = "Firma"
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombres.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombres.Location = New System.Drawing.Point(49, 56)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(62, 14)
        Me.lbl_Nombres.TabIndex = 4
        Me.lbl_Nombres.Text = "Nombres"
        '
        'lbl_Apellidos
        '
        Me.lbl_Apellidos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellidos.ForeColor = System.Drawing.Color.Black
        Me.lbl_Apellidos.Location = New System.Drawing.Point(49, 79)
        Me.lbl_Apellidos.Name = "lbl_Apellidos"
        Me.lbl_Apellidos.Size = New System.Drawing.Size(58, 14)
        Me.lbl_Apellidos.TabIndex = 3
        Me.lbl_Apellidos.Text = "Apellidos:"
        '
        'lbl_CI
        '
        Me.lbl_CI.ForeColor = System.Drawing.Color.Black
        Me.lbl_CI.Location = New System.Drawing.Point(48, 103)
        Me.lbl_CI.Name = "lbl_CI"
        Me.lbl_CI.Size = New System.Drawing.Size(55, 16)
        Me.lbl_CI.TabIndex = 2
        Me.lbl_CI.Text = "Cedula"
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.SystemColors.Control
        Me.buscar.Location = New System.Drawing.Point(75, 447)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(80, 24)
        Me.buscar.TabIndex = 14
        Me.buscar.Text = "Imagen"
        Me.buscar.UseVisualStyleBackColor = False
        '
        'btn_desbloquear
        '
        Me.btn_desbloquear.BackColor = System.Drawing.SystemColors.Control
        Me.btn_desbloquear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_desbloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desbloquear.ForeColor = System.Drawing.Color.Black
        Me.btn_desbloquear.Image = CType(resources.GetObject("btn_desbloquear.Image"), System.Drawing.Image)
        Me.btn_desbloquear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_desbloquear.Location = New System.Drawing.Point(266, 31)
        Me.btn_desbloquear.Name = "btn_desbloquear"
        Me.btn_desbloquear.Size = New System.Drawing.Size(106, 43)
        Me.btn_desbloquear.TabIndex = 98
        Me.btn_desbloquear.Text = "Desbloquear"
        Me.btn_desbloquear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_desbloquear.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(967, 25)
        Me.pan_barra.TabIndex = 101
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(10, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(80, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "USUARIO"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID"
        Me.DataGridTextBoxColumn1.MappingName = "invitado_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PSWD"
        Me.DataGridTextBoxColumn3.MappingName = "invitado_pswd"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "CI"
        Me.DataGridTextBoxColumn4.MappingName = "invitado_ci"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 70
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Apellidos"
        Me.DataGridTextBoxColumn5.MappingName = "invitado_apellido"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 110
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Nombres"
        Me.DataGridTextBoxColumn6.MappingName = "invitado_nombre"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 110
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Firma"
        Me.DataGridTextBoxColumn7.MappingName = "invitado_firma"
        Me.DataGridTextBoxColumn7.Width = 143
        '
        'dgrd_usuario
        '
        Me.dgrd_usuario.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_usuario.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_usuario.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_usuario.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_usuario.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_usuario.CaptionText = "USUARIOS REGISTRADOS"
        Me.dgrd_usuario.DataMember = ""
        Me.dgrd_usuario.FlatMode = True
        Me.dgrd_usuario.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_usuario.ForeColor = System.Drawing.Color.Black
        Me.dgrd_usuario.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_usuario.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_usuario.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_usuario.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_usuario.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_usuario.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_usuario.Location = New System.Drawing.Point(170, 297)
        Me.dgrd_usuario.Name = "dgrd_usuario"
        Me.dgrd_usuario.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_usuario.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_usuario.ReadOnly = True
        Me.dgrd_usuario.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_usuario.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_usuario.Size = New System.Drawing.Size(785, 174)
        Me.dgrd_usuario.TabIndex = 94
        Me.dgrd_usuario.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_usuario
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "LOGIN"
        Me.DataGridTextBoxColumn10.MappingName = "USU_LOGIN"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "ALLOW"
        Me.DataGridTextBoxColumn2.MappingName = "invitado_conectar"
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "CARGO"
        Me.DataGridTextBoxColumn8.MappingName = "invitado_cargo"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "FOLIO"
        Me.DataGridTextBoxColumn9.MappingName = "invitado_folio"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "DIRECCION"
        Me.DataGridTextBoxColumn11.MappingName = "invitado_direccion"
        Me.DataGridTextBoxColumn11.Width = 200
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "FONO"
        Me.DataGridTextBoxColumn12.MappingName = "invitado_fono"
        Me.DataGridTextBoxColumn12.Width = 50
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn13.MappingName = "invitado_estado"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "WEB"
        Me.DataGridTextBoxColumn14.MappingName = "invitado_perfilWeb"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "ADMIN"
        Me.DataGridTextBoxColumn15.MappingName = "invitado_administrador"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "EMAIL"
        Me.DataGridTextBoxColumn16.MappingName = "invitado_mail"
        Me.DataGridTextBoxColumn16.Width = 120
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(102, 31)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 43)
        Me.btn_Aceptar.TabIndex = 96
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.AnalisysLAB.My.Resources.Resources.USUARIOM
        Me.PictureBox1.Location = New System.Drawing.Point(29, 306)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'chkl_areas
        '
        Me.chkl_areas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkl_areas.CheckOnClick = True
        Me.chkl_areas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkl_areas.Location = New System.Drawing.Point(704, 92)
        Me.chkl_areas.Name = "chkl_areas"
        Me.chkl_areas.Size = New System.Drawing.Size(251, 194)
        Me.chkl_areas.TabIndex = 16
        '
        'btn_all
        '
        Me.btn_all.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_all.Enabled = False
        Me.btn_all.Image = CType(resources.GetObject("btn_all.Image"), System.Drawing.Image)
        Me.btn_all.Location = New System.Drawing.Point(907, 65)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(24, 24)
        Me.btn_all.TabIndex = 104
        Me.btn_all.Tag = "Seleccionar todo"
        Me.btn_all.UseVisualStyleBackColor = False
        '
        'btn_none
        '
        Me.btn_none.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_none.Enabled = False
        Me.btn_none.Image = CType(resources.GetObject("btn_none.Image"), System.Drawing.Image)
        Me.btn_none.Location = New System.Drawing.Point(931, 65)
        Me.btn_none.Name = "btn_none"
        Me.btn_none.Size = New System.Drawing.Size(24, 24)
        Me.btn_none.TabIndex = 105
        Me.btn_none.Tag = "Seleccionar ninguno"
        Me.btn_none.UseVisualStyleBackColor = False
        '
        'frm_Invitados
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(967, 492)
        Me.Controls.Add(Me.btn_none)
        Me.Controls.Add(Me.btn_all)
        Me.Controls.Add(Me.chkl_areas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_suspender)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.grp_usuario)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.btn_desbloquear)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.dgrd_usuario)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Invitados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invitados"
        Me.grp_usuario.ResumeLayout(False)
        Me.grp_usuario.PerformLayout()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgrd_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
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


    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Nuevo.MouseEnter, btn_Eliminar.MouseEnter, btn_Salir.MouseEnter, btn_desbloquear.MouseEnter, btn_suspender.MouseEnter
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


    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Eliminar.MouseLeave, btn_Nuevo.MouseLeave, btn_Salir.MouseLeave, btn_desbloquear.MouseLeave, btn_suspender.MouseLeave
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
    'declaracion de variables
    Dim boo_flag As Boolean = False
    Dim int_codigo As Integer
    Dim opr_encripta As New Cls_Encripta()
    Dim orp_areas As New Cls_Areas()
    Dim g_opr_invitado As New Cls_Invitado()

    Private Sub frm_Invitados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'Defino capacidad de caracteres de cada campo
        Ctl_txt_nombre.txt_padre.MaxLength = 50
        Ctl_txt_apellido.txt_padre.MaxLength = 50
        Ctl_txt_direccion.txt_padre.MaxLength = 150
        Ctl_txt_pswd.txt_padre.MaxLength = 50
        'activo y desactivo botones     
        grp_usuario.Enabled = False
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        btn_desbloquear.Enabled = False
        btn_suspender.Enabled = False
        btn_Nuevo.Focus()
        'cargo los datos de los usuarios en el data grid 
        dgrd_usuario.SetDataBinding(g_opr_invitado.LeerUsuario2(), "Registros")
        orp_areas.LlenarListaAreas(chkl_areas)
        Ctl_txt_nombre.txt_padre.MaxLength = 50
        Ctl_txt_apellido.txt_padre.MaxLength = 50
        Ctl_txt_direccion.txt_padre.MaxLength = 150
        Ctl_txt_cargo.txt_padre.MaxLength = 150
        Ctl_txt_folio.txt_padre.MaxLength = 150
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'verifico que los datos esten completos
        Dim accesoWeb, administrador As String
        If (Ctl_txt_login.texto_Recupera = "") Then
            MsgBox("Ingrese el login del usuario", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_login.Focus()
            Exit Sub
        End If
        If (Ctl_txt_nombre.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre del usuario", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If
        If (Ctl_txt_apellido.texto_Recupera = "") Then
            MsgBox("Ingrese el apellido del usuario", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_apellido.Focus()
            Exit Sub
        End If
        If (Ctl_txt_ci.texto_Recupera = "") Then
            MsgBox("Ingrese el numero de cedula del usuario", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_ci.Focus()
            Exit Sub
        End If
        If (Ctl_txt_pswd.texto_Recupera = "") Then
            MsgBox("Ingrese la contraseña del usuario", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_pswd.Focus()
            Exit Sub
        Else

            Dim boo_compruebalogin As Boolean = True
            If Not boo_flag Then
                'actualizaci�n
                If dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 1).ToString() = Ctl_txt_login.texto_Recupera Then
                    boo_compruebalogin = False
                End If
            End If
            If boo_compruebalogin Then
                If g_opr_usuario.ExisteLogin(Ctl_txt_login.texto_Recupera) Then
                    MsgBox("El Login ingresado ya existe, ingreso uno diferente", MsgBoxStyle.Exclamation, "ANALISYS")
                    Exit Sub
                End If
            End If
        End If
        '' ''If (Ctl_txt_pswd.texto_Recupera = "") Then
        '' ''    MsgBox("Ingrese la contrase�a del usuario", MsgBoxStyle.Exclamation, "ANALISYS")
        '' ''    Ctl_txt_pswd.Focus()
        '' ''    Exit Sub
        '' ''End If
        If (Ctl_txt_pswd.texto_Recupera <> Ctl_txt_pswdconf.texto_Recupera) Then
            MsgBox("La contraseña y su confirmacion son diferentes", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_pswd.Focus()
            Exit Sub
        End If

        'comprueba que haya seleccionado por lo menos una area 
        Dim i As Short = 0
        Dim boo_area As Boolean = False
        For i = 0 To (chkl_areas.Items.Count - 1)
            If (chkl_areas.GetItemChecked(i) = True) Then
                boo_area = True
                Exit For
            End If
        Next
        If boo_area = False Then
            MsgBox("Debe seleccionar al menos una area relacionada", MsgBoxStyle.Exclamation, "ANALISYS")
            chkl_areas.Focus()
            Exit Sub
        End If


        If chk_AccesoWeb.Checked Then
            accesoWeb = 1
        Else
            accesoWeb = 0
        End If

        If cmb_tipo.Text = "Usuario" Then
            administrador = 0
        Else
            administrador = 1
        End If


        'si se trata d un usuario nuevo
        If boo_flag = True Then
            'leo el maximo codigo de los usuarios
            int_codigo = g_opr_invitado.LeerMaxCodUsuario() + 1

            'mando a guardar los datos del usuario nuevo
            g_opr_invitado.GuardarUsuario(int_codigo, Ctl_txt_login.texto_Recupera(), Ctl_txt_pswd.texto_Recupera.ToString, Ctl_txt_nombre.texto_Recupera, Ctl_txt_apellido.texto_Recupera, Ctl_txt_letras1.texto_Recupera.ToString, Ctl_txt_ci.texto_Recupera, Ctl_txt_cargo.texto_Recupera.ToString, Ctl_txt_folio.texto_Recupera.ToString, Ctl_txt_direccion.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, accesoWeb, administrador, Ctl_txt_mail.texto_Recupera.ToString, chkl_areas)
        Else
            'En caso de actualizar un USUARIO
            If MsgBox("Desea actualizar el registro?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                'limpio los campos del formulario
                Call LimpiarCamposUsu()
                Exit Sub
            Else
                'mando a actualizar los datos del usuario
                g_opr_invitado.ActualizarUsuario(int_codigo, Ctl_txt_login.texto_Recupera(), Ctl_txt_pswd.texto_Recupera.ToString, Ctl_txt_nombre.texto_Recupera, Ctl_txt_apellido.texto_Recupera, Ctl_txt_letras1.texto_Recupera.ToString, Ctl_txt_ci.texto_Recupera, Ctl_txt_cargo.texto_Recupera.ToString, Ctl_txt_folio.texto_Recupera.ToString, Ctl_txt_direccion.texto_Recupera.ToString, Ctl_txt_fono.texto_Recupera.ToString, accesoWeb, administrador, Ctl_txt_mail.texto_Recupera.ToString, chkl_areas)
            End If
        End If
        'limpio los campos del formulario
        Call LimpiarCamposUsu()
        'actualizo el data grid de los usuarios
        dgrd_usuario.SetDataBinding(g_opr_invitado.LeerUsuario2(), "Registros")
        MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        'activo y desativo los botones
        btn_Nuevo.Enabled = True
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_usuario.Enabled = False
        btn_desbloquear.Enabled = False
        btn_all.Enabled = False
        btn_none.Enabled = False
        btn_Nuevo.Focus()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        'activo los campos
        grp_usuario.Enabled = True
        Call LimpiarCamposUsu()
        Ctl_txt_login.Focus()
        btn_Nuevo.Enabled = False
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = False
        btn_desbloquear.Enabled = False
        btn_suspender.Enabled = False
        btn_all.Enabled = True
        btn_none.Enabled = True
        'boo_flag sirve para sabersies nuevo u actualizacion
        'boo_flag-->True Nuevo
        'boo_flag-->False Actualizacion 
        boo_flag = True
    End Sub

    Private Sub LimpiarCamposUsu()
        'limpia todos los campos del formulario
        Ctl_txt_login.texto_Asigna("")
        Ctl_txt_nombre.texto_Asigna("")
        Ctl_txt_apellido.texto_Asigna("")
        Ctl_txt_ci.texto_Asigna("")
        Ctl_txt_direccion.texto_Asigna("")
        Ctl_txt_fono.texto_Asigna("")
        Ctl_txt_cargo.texto_Asigna("")
        Ctl_txt_letras1.texto_Asigna("")
        Ctl_txt_pswd.texto_Asigna("")
        Ctl_txt_pswdconf.texto_Asigna("")
        Ctl_txt_cargo.texto_Asigna("")
        Ctl_txt_folio.texto_Asigna("")
        Ctl_txt_mail.texto_Asigna("")
        Dim i As Short = 0
        For i = 0 To (chkl_areas.Items.Count - 1)
            chkl_areas.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub dgrd_usuario_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_usuario.CurrentCellChanged
        'cuando selecciono un usuario del grid los datos se cargan en los 
        'campos de la parte superior del formulario
        'selecciono toda la fila del data grid
        Dim dgr_cell As DataGridCell
        dgr_cell.ColumnNumber = 0
        dgr_cell.RowNumber = dgrd_usuario.CurrentCell.RowNumber
        dgrd_usuario.CurrentCell = dgr_cell
        dgrd_usuario.Select(dgrd_usuario.CurrentCell.RowNumber)
        'activo botones
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_usuario.Enabled = True
        btn_desbloquear.Enabled = False
        btn_suspender.Enabled = False
        btn_all.Enabled = True
        btn_none.Enabled = True

        'limpio los campos
        Call LimpiarCamposUsu()
        'cargo los cuadors de texto con los valores del grid
        int_codigo = dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 0)
        Ctl_txt_login.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 1).ToString())
        Ctl_txt_nombre.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 3).ToString())
        Ctl_txt_apellido.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 4).ToString())
        Ctl_txt_letras1.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 5).ToString()) 'FIRMA
        Ctl_txt_ci.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 6).ToString())
        Ctl_txt_direccion.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 10).ToString())
        Ctl_txt_fono.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 11).ToString())
        Ctl_txt_mail.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 15).ToString())
        If CInt(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 14).ToString()) = 0 Then
            cmb_tipo.Text = "Usuario"
        Else
            cmb_tipo.Text = "Administrador"
        End If

        Ctl_txt_pswd.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 2))
        Ctl_txt_pswdconf.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 2))
        Ctl_txt_cargo.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 8).ToString())
        Ctl_txt_folio.texto_Asigna(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 9).ToString())

        If dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 7).ToString() = "1" Then
            btn_suspender.Enabled = False
            btn_desbloquear.Enabled = True
        Else
            btn_suspender.Enabled = True
            btn_desbloquear.Enabled = False
        End If


        If dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 13).ToString() = "0" Then
            chk_AccesoWeb.Checked = False
        Else
            chk_AccesoWeb.Checked = True
        End If

        'boo_flag sirve para sabersies nuevo u actualizacion
        'boo_flag-->True Nuevo
        'boo_flag-->False Actualizacion 
        boo_flag = False

        Dim opr_usuario As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim i, j As Short
        opr_usuario.LeerAreasUsuarioParam(int_codigo, arr_datos)

        For j = 0 To arr_datos.Count - 1
            For i = 0 To chkl_areas.Items.Count - 1
                If Trim(Mid(chkl_areas.Items.Item(i), 150)) = arr_datos(j) Then
                    chkl_areas.SetItemChecked(i, True)
                End If
            Next
        Next


    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If MsgBox("Desea eliminar el usuario?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            'llamo a la funcion que eliminara el usuario le envio el codigo del usuario
            If g_opr_invitado.EliminarUsuario(int_codigo) = True Then
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
            Else
                MsgBox("No se pudo realizar la operacin solicitada, Eliminar usuario", MsgBoxStyle.Exclamation, "ANALISYS")
            End If
            'actualizo el data grid
            dgrd_usuario.SetDataBinding(g_opr_invitado.LeerUsuario2(), "Registros")
        End If
        'limpio los campos del formulario
        Call LimpiarCamposUsu()
        'desactivo los botones
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_usuario.Enabled = False
        btn_desbloquear.Enabled = False
        btn_suspender.Enabled = False
        btn_Nuevo.Enabled = True
        btn_Nuevo.Focus()
    End Sub

    Private Sub btn_desbloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_desbloquear.Click
        'funcion que me ermite desbloquear un usuario.
        'nota:
        'un usuario que queda bloqueado cuando no cerro su sesion correctamente
        'o por motivos fuera de su alcance: la maquina se colgo, hubo corte luz,
        'error en la red, etc..
        On Error GoTo msgerr
        If Len(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 0)) > 0 Then
            g_opr_invitado.CambiarConectado(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 0), 0)
            Call LimpiarCamposUsu()
            'actualizo el data grid de los usuarios
            dgrd_usuario.SetDataBinding(g_opr_invitado.LeerUsuario2(), "Registros")
            MsgBox("El usuario " & dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 1).ToString() & " a sido desbloqueado", MsgBoxStyle.Information, "ANALISYS")
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            grp_usuario.Enabled = False
            btn_desbloquear.Enabled = False
            btn_suspender.Enabled = False
            btn_Nuevo.Enabled = True
            btn_Nuevo.Focus()
        End If
        Exit Sub
msgerr:
        g_opr_invitado.MensajeBoxError("Error al realizar la operacion")
        Err.Clear()
    End Sub

    Private Sub btn_suspender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_suspender.Click
        'suspende el ingreso de usuarios al sistema
        On Error GoTo msgerr
        If Len(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 0)) > 0 Then
            If MsgBox("Desea Bloquear el ingreso al sistema del usuario seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                g_opr_invitado.CambiarConectado(dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 0), 1)
                Call LimpiarCamposUsu()
                'actualizo el data grid de los usuarios
                dgrd_usuario.SetDataBinding(g_opr_invitado.LeerUsuario2(), "Registros")
                MsgBox("El usuario " & dgrd_usuario.Item(dgrd_usuario.CurrentCell.RowNumber, 1).ToString() & " a sido suspendido", MsgBoxStyle.Information, "ANALISYS")
            End If
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            grp_usuario.Enabled = False
            btn_desbloquear.Enabled = False
            btn_suspender.Enabled = False
            btn_Nuevo.Enabled = True
            btn_Nuevo.Focus()
        End If
        Exit Sub
msgerr:
        g_opr_invitado.MensajeBoxError("Error al realizar la operacion")
        Err.Clear()
    End Sub

    Private Sub buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscar.Click
        ' ''cd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.TIF)|*.BMP;*.JPG;*.GIF;*.TIF"
        ' ''cd.FilterIndex = 0
        ' ''cd.InitialDirectory = Application.ExecutablePath
        ' ''Dim res As DialogResult = cd.ShowDialog(Me)
        ' ''If res = System.Windows.Forms.DialogResult.OK Then
        ' ''    Ctl_txt_direccion.texto_Asigna(cd.FileName.ToString())
        ' ''End If


        ' Displays an OpenFileDialog so the user can select a Cursor.
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "jpeg, png Files|*.jpg, *.png"
        openFileDialog1.Title = "Selecione la imagen para el logotipo"

        ' Show the Dialog.
        ' If the user clicked OK in the dialog and 
        ' a .CUR file was selected, open it.
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = openFileDialog1.FileName
            'Me.Cursor = New Cursor(openFileDialog1.OpenFile())
        End If

    End Sub


    Private Sub btn_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_all.Click
        Dim i As Short = 0
        For i = 0 To (chkl_areas.Items.Count - 1)
            chkl_areas.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btn_none_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_none.Click
        Dim i As Short = 0
        For i = 0 To (chkl_areas.Items.Count - 1)
            chkl_areas.SetItemChecked(i, False)
        Next
    End Sub

    
End Class
