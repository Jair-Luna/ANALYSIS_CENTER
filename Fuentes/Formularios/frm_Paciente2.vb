'*************************************************************************
' Nombre:   frm_Paciente2
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite ingresar un nuevo paciente
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System.Net

Public Class frm_Paciente2
    Inherits System.Windows.Forms.Form
    Dim str_url As String = Nothing

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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_apellido As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_direccion As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_mail As Ctl_txt.ctl_txt_mail
    Friend WithEvents Cmb_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fecnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ctl_txt_fono As Ctl_txt.ctl_txt_letras
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Grup_paciente As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_hisClinica As System.Windows.Forms.TextBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents rbtn_si As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_no As System.Windows.Forms.RadioButton
    Friend WithEvents txt_edad As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_grado As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_poliza As System.Windows.Forms.TextBox
    Friend WithEvents cmb_parentesco As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btn_RedPublica As System.Windows.Forms.Button
    Friend WithEvents lbl_msg_pac As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents pic_wait As System.Windows.Forms.PictureBox
    Friend WithEvents Ctl_txt_Pais As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_Profesion As Ctl_txt.ctl_txt_letras
    Friend WithEvents txt_Url As System.Windows.Forms.TextBox
    Friend WithEvents btn_IrWeb As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Ctl_txt_doc As Ctl_txt.ctl_txt_ci_ruc
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Paciente2))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.Grup_paciente = New System.Windows.Forms.GroupBox
        Me.Ctl_txt_Profesion = New Ctl_txt.ctl_txt_letras
        Me.Dtp_fecnac = New System.Windows.Forms.DateTimePicker
        Me.Ctl_txt_Pais = New Ctl_txt.ctl_txt_letras
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox
        Me.cmb_parentesco = New System.Windows.Forms.DateTimePicker
        Me.txt_poliza = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmb_grado = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_edad = New Ctl_txt.ctl_txt_letras
        Me.rbtn_no = New System.Windows.Forms.RadioButton
        Me.rbtn_si = New System.Windows.Forms.RadioButton
        Me.txt_hisClinica = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_obs = New System.Windows.Forms.TextBox
        Me.pic_wait = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_RedPublica = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.lbl_msg_pac = New System.Windows.Forms.Label
        Me.txt_Url = New System.Windows.Forms.TextBox
        Me.btn_IrWeb = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Grup_paciente.SuspendLayout()
        CType(Me.pic_wait, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellidos:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombres:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Direccion:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(334, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sexo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha Nac:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(11, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Observacion"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Email:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(11, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Ciudad:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctl_txt_apellido
        '
        Me.Ctl_txt_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_apellido.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_apellido.Location = New System.Drawing.Point(87, 57)
        Me.Ctl_txt_apellido.Name = "Ctl_txt_apellido"
        Me.Ctl_txt_apellido.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_apellido.Prp_CaracterPasswd = ""
        Me.Ctl_txt_apellido.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_apellido.Size = New System.Drawing.Size(346, 21)
        Me.Ctl_txt_apellido.TabIndex = 4
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(87, 84)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(346, 21)
        Me.Ctl_txt_nombre.TabIndex = 5
        '
        'Ctl_txt_direccion
        '
        Me.Ctl_txt_direccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_direccion.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_direccion.Location = New System.Drawing.Point(85, 301)
        Me.Ctl_txt_direccion.Name = "Ctl_txt_direccion"
        Me.Ctl_txt_direccion.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_direccion.Prp_CaracterPasswd = ""
        Me.Ctl_txt_direccion.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_direccion.Size = New System.Drawing.Size(482, 21)
        Me.Ctl_txt_direccion.TabIndex = 15
        '
        'Ctl_txt_fono
        '
        Me.Ctl_txt_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_fono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_fono.Location = New System.Drawing.Point(85, 246)
        Me.Ctl_txt_fono.Name = "Ctl_txt_fono"
        Me.Ctl_txt_fono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_fono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_fono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_fono.Size = New System.Drawing.Size(98, 21)
        Me.Ctl_txt_fono.TabIndex = 13
        '
        'Ctl_txt_mail
        '
        Me.Ctl_txt_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_mail.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_mail.Location = New System.Drawing.Point(84, 273)
        Me.Ctl_txt_mail.Name = "Ctl_txt_mail"
        Me.Ctl_txt_mail.Size = New System.Drawing.Size(481, 22)
        Me.Ctl_txt_mail.TabIndex = 14
        '
        'Cmb_tipodoc
        '
        Me.Cmb_tipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_tipodoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_tipodoc.Items.AddRange(New Object() {"CEDULA", "RUC", "PASAPORTE"})
        Me.Cmb_tipodoc.Location = New System.Drawing.Point(87, 30)
        Me.Cmb_tipodoc.Name = "Cmb_tipodoc"
        Me.Cmb_tipodoc.Size = New System.Drawing.Size(118, 21)
        Me.Cmb_tipodoc.TabIndex = 1
        '
        'Cmb_sexo
        '
        Me.Cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_sexo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sexo.Items.AddRange(New Object() {"F", "M"})
        Me.Cmb_sexo.Location = New System.Drawing.Point(380, 111)
        Me.Cmb_sexo.Name = "Cmb_sexo"
        Me.Cmb_sexo.Size = New System.Drawing.Size(53, 21)
        Me.Cmb_sexo.TabIndex = 9
        '
        'Ctl_txt_doc
        '
        Me.Ctl_txt_doc.Enabled = False
        Me.Ctl_txt_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_doc.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_doc.Location = New System.Drawing.Point(213, 30)
        Me.Ctl_txt_doc.Name = "Ctl_txt_doc"
        Me.Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Pasaporte
        Me.Ctl_txt_doc.Size = New System.Drawing.Size(124, 21)
        Me.Ctl_txt_doc.TabIndex = 2
        Me.Ctl_txt_doc.Visible = False
        '
        'Cmb_ciudad
        '
        Me.Cmb_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ciudad.Location = New System.Drawing.Point(85, 217)
        Me.Cmb_ciudad.Name = "Cmb_ciudad"
        Me.Cmb_ciudad.Size = New System.Drawing.Size(152, 21)
        Me.Cmb_ciudad.TabIndex = 11
        '
        'Grup_paciente
        '
        Me.Grup_paciente.BackColor = System.Drawing.Color.Transparent
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_Profesion)
        Me.Grup_paciente.Controls.Add(Me.Dtp_fecnac)
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_Pais)
        Me.Grup_paciente.Controls.Add(Me.Label19)
        Me.Grup_paciente.Controls.Add(Me.Label20)
        Me.Grup_paciente.Controls.Add(Me.Label6)
        Me.Grup_paciente.Controls.Add(Me.cmb_Provincia)
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_direccion)
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_apellido)
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_nombre)
        Me.Grup_paciente.Controls.Add(Me.Cmb_sexo)
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_doc)
        Me.Grup_paciente.Controls.Add(Me.Label8)
        Me.Grup_paciente.Controls.Add(Me.cmb_parentesco)
        Me.Grup_paciente.Controls.Add(Me.txt_poliza)
        Me.Grup_paciente.Controls.Add(Me.Label16)
        Me.Grup_paciente.Controls.Add(Me.Label15)
        Me.Grup_paciente.Controls.Add(Me.Label14)
        Me.Grup_paciente.Controls.Add(Me.cmb_grado)
        Me.Grup_paciente.Controls.Add(Me.Label13)
        Me.Grup_paciente.Controls.Add(Me.txt_edad)
        Me.Grup_paciente.Controls.Add(Me.rbtn_no)
        Me.Grup_paciente.Controls.Add(Me.rbtn_si)
        Me.Grup_paciente.Controls.Add(Me.txt_hisClinica)
        Me.Grup_paciente.Controls.Add(Me.Label2)
        Me.Grup_paciente.Controls.Add(Me.Txt_obs)
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_mail)
        Me.Grup_paciente.Controls.Add(Me.Label9)
        Me.Grup_paciente.Controls.Add(Me.Label10)
        Me.Grup_paciente.Controls.Add(Me.Label11)
        Me.Grup_paciente.Controls.Add(Me.Cmb_tipodoc)
        Me.Grup_paciente.Controls.Add(Me.Label1)
        Me.Grup_paciente.Controls.Add(Me.Label3)
        Me.Grup_paciente.Controls.Add(Me.Cmb_ciudad)
        Me.Grup_paciente.Controls.Add(Me.Label4)
        Me.Grup_paciente.Controls.Add(Me.Label5)
        Me.Grup_paciente.Controls.Add(Me.Ctl_txt_fono)
        Me.Grup_paciente.Controls.Add(Me.Label7)
        Me.Grup_paciente.Controls.Add(Me.pic_wait)
        Me.Grup_paciente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grup_paciente.ForeColor = System.Drawing.Color.Navy
        Me.Grup_paciente.Location = New System.Drawing.Point(6, 94)
        Me.Grup_paciente.Name = "Grup_paciente"
        Me.Grup_paciente.Size = New System.Drawing.Size(572, 388)
        Me.Grup_paciente.TabIndex = 0
        Me.Grup_paciente.TabStop = False
        Me.Grup_paciente.Text = "DEMOGRAFICOS"
        '
        'Ctl_txt_Profesion
        '
        Me.Ctl_txt_Profesion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Profesion.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_Profesion.Location = New System.Drawing.Point(84, 142)
        Me.Ctl_txt_Profesion.Name = "Ctl_txt_Profesion"
        Me.Ctl_txt_Profesion.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Profesion.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Profesion.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_Profesion.Size = New System.Drawing.Size(179, 20)
        Me.Ctl_txt_Profesion.TabIndex = 239
        '
        'Dtp_fecnac
        '
        Me.Dtp_fecnac.CustomFormat = "dd-MMM-yyyy"
        Me.Dtp_fecnac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_fecnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_fecnac.Location = New System.Drawing.Point(87, 111)
        Me.Dtp_fecnac.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.Dtp_fecnac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Dtp_fecnac.Name = "Dtp_fecnac"
        Me.Dtp_fecnac.Size = New System.Drawing.Size(103, 21)
        Me.Dtp_fecnac.TabIndex = 8
        Me.Dtp_fecnac.Value = New Date(2003, 9, 14, 0, 0, 0, 0)
        '
        'Ctl_txt_Pais
        '
        Me.Ctl_txt_Pais.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Pais.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_Pais.Location = New System.Drawing.Point(84, 168)
        Me.Ctl_txt_Pais.Name = "Ctl_txt_Pais"
        Me.Ctl_txt_Pais.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Pais.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Pais.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_Pais.Size = New System.Drawing.Size(179, 20)
        Me.Ctl_txt_Pais.TabIndex = 238
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(11, 175)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 237
        Me.Label19.Text = "PAIS"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(11, 146)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 236
        Me.Label20.Text = "PROFESION"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(11, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Provincia:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Provincia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Provincia.Items.AddRange(New Object() {"Pichincha", "Guayas", "Tungurahua", "Cotopaxi", "Bolivar", "Carchi", "Imbabura"})
        Me.cmb_Provincia.Location = New System.Drawing.Point(84, 193)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(152, 21)
        Me.cmb_Provincia.TabIndex = 175
        '
        'cmb_parentesco
        '
        Me.cmb_parentesco.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parentesco.CustomFormat = "dd/mm/yyyy"
        Me.cmb_parentesco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parentesco.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_parentesco.Location = New System.Drawing.Point(356, 354)
        Me.cmb_parentesco.Name = "cmb_parentesco"
        Me.cmb_parentesco.Size = New System.Drawing.Size(100, 21)
        Me.cmb_parentesco.TabIndex = 36
        Me.cmb_parentesco.Visible = False
        '
        'txt_poliza
        '
        Me.txt_poliza.Location = New System.Drawing.Point(84, 354)
        Me.txt_poliza.MaxLength = 8
        Me.txt_poliza.Name = "txt_poliza"
        Me.txt_poliza.Size = New System.Drawing.Size(213, 21)
        Me.txt_poliza.TabIndex = 35
        Me.txt_poliza.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(11, 361)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 12)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Poliza:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(299, 359)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Desde:"
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 358)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Afiliacion:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Visible = False
        '
        'cmb_grado
        '
        Me.cmb_grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_grado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_grado.Items.AddRange(New Object() {"Familiar", "Individual", "Corporativo"})
        Me.cmb_grado.Location = New System.Drawing.Point(84, 354)
        Me.cmb_grado.Name = "cmb_grado"
        Me.cmb_grado.Size = New System.Drawing.Size(213, 21)
        Me.cmb_grado.TabIndex = 16
        Me.cmb_grado.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Telefono:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_edad
        '
        Me.txt_edad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_edad.Location = New System.Drawing.Point(228, 111)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Prp_CaracterEspecial = New String() {"'"}
        Me.txt_edad.Prp_CaracterPasswd = ""
        Me.txt_edad.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.txt_edad.Size = New System.Drawing.Size(109, 20)
        Me.txt_edad.TabIndex = 10
        '
        'rbtn_no
        '
        Me.rbtn_no.ForeColor = System.Drawing.Color.Black
        Me.rbtn_no.Location = New System.Drawing.Point(143, 117)
        Me.rbtn_no.Name = "rbtn_no"
        Me.rbtn_no.Size = New System.Drawing.Size(40, 18)
        Me.rbtn_no.TabIndex = 7
        Me.rbtn_no.Text = "No"
        Me.rbtn_no.Visible = False
        '
        'rbtn_si
        '
        Me.rbtn_si.Checked = True
        Me.rbtn_si.ForeColor = System.Drawing.Color.Black
        Me.rbtn_si.Location = New System.Drawing.Point(103, 115)
        Me.rbtn_si.Name = "rbtn_si"
        Me.rbtn_si.Size = New System.Drawing.Size(34, 20)
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
        Me.txt_hisClinica.Location = New System.Drawing.Point(447, 31)
        Me.txt_hisClinica.MaxLength = 10
        Me.txt_hisClinica.Name = "txt_hisClinica"
        Me.txt_hisClinica.ReadOnly = True
        Me.txt_hisClinica.Size = New System.Drawing.Size(118, 14)
        Me.txt_hisClinica.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(182, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Edad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_obs
        '
        Me.Txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_obs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_obs.Location = New System.Drawing.Point(84, 328)
        Me.Txt_obs.MaxLength = 150
        Me.Txt_obs.Multiline = True
        Me.Txt_obs.Name = "Txt_obs"
        Me.Txt_obs.Size = New System.Drawing.Size(482, 20)
        Me.Txt_obs.TabIndex = 16
        '
        'pic_wait
        '
        Me.pic_wait.Image = CType(resources.GetObject("pic_wait.Image"), System.Drawing.Image)
        Me.pic_wait.Location = New System.Drawing.Point(468, 71)
        Me.pic_wait.Name = "pic_wait"
        Me.pic_wait.Size = New System.Drawing.Size(99, 87)
        Me.pic_wait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_wait.TabIndex = 174
        Me.pic_wait.TabStop = False
        Me.pic_wait.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(419, 31)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 40)
        Me.btn_aceptar.TabIndex = 18
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_aceptar, "Guardar datos del paciente")
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(498, 31)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(74, 40)
        Me.btn_cancelar.TabIndex = 19
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Salir de esta ventana")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_RedPublica
        '
        Me.btn_RedPublica.BackColor = System.Drawing.SystemColors.Control
        Me.btn_RedPublica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_RedPublica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RedPublica.ForeColor = System.Drawing.Color.Black
        Me.btn_RedPublica.Image = CType(resources.GetObject("btn_RedPublica.Image"), System.Drawing.Image)
        Me.btn_RedPublica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_RedPublica.Location = New System.Drawing.Point(419, 77)
        Me.btn_RedPublica.Name = "btn_RedPublica"
        Me.btn_RedPublica.Size = New System.Drawing.Size(154, 18)
        Me.btn_RedPublica.TabIndex = 172
        Me.btn_RedPublica.Text = "Red Publica >>>"
        Me.btn_RedPublica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_RedPublica, "Guardar datos del paciente")
        Me.btn_RedPublica.UseVisualStyleBackColor = False
        Me.btn_RedPublica.Visible = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(585, 25)
        Me.pan_barra.TabIndex = 93
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(5, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(93, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "PACIENTE"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(748, 31)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(328, 416)
        Me.WebBrowser1.TabIndex = 171
        '
        'lbl_msg_pac
        '
        Me.lbl_msg_pac.AutoSize = True
        Me.lbl_msg_pac.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg_pac.ForeColor = System.Drawing.Color.Red
        Me.lbl_msg_pac.Location = New System.Drawing.Point(93, 53)
        Me.lbl_msg_pac.Name = "lbl_msg_pac"
        Me.lbl_msg_pac.Size = New System.Drawing.Size(155, 18)
        Me.lbl_msg_pac.TabIndex = 173
        Me.lbl_msg_pac.Text = "(lbl_msg_pac.Text)"
        '
        'txt_Url
        '
        Me.txt_Url.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Url.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_Url.Location = New System.Drawing.Point(589, 455)
        Me.txt_Url.Name = "txt_Url"
        Me.txt_Url.Size = New System.Drawing.Size(442, 18)
        Me.txt_Url.TabIndex = 174
        '
        'btn_IrWeb
        '
        Me.btn_IrWeb.Location = New System.Drawing.Point(1033, 454)
        Me.btn_IrWeb.Name = "btn_IrWeb"
        Me.btn_IrWeb.Size = New System.Drawing.Size(43, 20)
        Me.btn_IrWeb.TabIndex = 175
        Me.btn_IrWeb.Text = "Ir"
        Me.btn_IrWeb.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(584, 31)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 206)
        Me.TextBox1.TabIndex = 176
        '
        'frm_Paciente2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(585, 539)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_IrWeb)
        Me.Controls.Add(Me.txt_Url)
        Me.Controls.Add(Me.lbl_msg_pac)
        Me.Controls.Add(Me.btn_RedPublica)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Grup_paciente)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Paciente2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente"
        Me.Grup_paciente.ResumeLayout(False)
        Me.Grup_paciente.PerformLayout()
        CType(Me.pic_wait, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    'declaracion de variables
    Dim opr_ciudad As New Cls_Ciudad()
    Dim opr_paciente As New Cls_Paciente()
    Public par_hc As System.String

#Region "C�digo de Formulario"
    Public frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image


#End Region

    'ROSS
    Private Sub Cmb_tipodoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_tipodoc.SelectedIndexChanged
        'activo o desactivo los cuadros de texto dependiendo de la opcion
        'seleccionada del combo box
        Ctl_txt_doc.Enabled = True
        If Cmb_tipodoc.Text = "CEDULA" Then
            Ctl_txt_doc.Visible = True
            'Ctl_txt_doc.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.Cedula_Identidad
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
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'Me.Top = (frm_refer_main_form.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main_form.mdiClient1.Width - Me.Width) / 2) + frm_refer_main_form.Pan_Menu.Width
        'lleno el combo de la ciudad
        lbl_msg_pac.Text = ""
        Ctl_txt_apellido.txt_padre.MaxLength = 50
        Ctl_txt_nombre.txt_padre.MaxLength = 50
        Ctl_txt_direccion.txt_padre.MaxLength = 150
        Ctl_txt_fono.txt_padre.MaxLength = 30
        Ctl_txt_mail.txt_padre.MaxLength = 500
        txt_poliza.Text = ""
        cmb_grado.SelectedIndex = 0
        'cmb_parentesco.SelectedIndex = 0
        opr_ciudad.LlenarComboProvincia(cmb_Provincia)
        cmb_Provincia.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)
        

        Cmb_tipodoc.SelectedIndex = 0
        Cmb_sexo.SelectedIndex = 0
        Dtp_fecnac.Value = Format(Now, "yyyy/MM/dd")
        Ctl_txt_doc.texto_Asigna(par_hc)
        Ctl_txt_Pais.texto_Asigna("ECUADOR")
        Ctl_txt_Profesion.texto_Asigna("NA")
        txt_hisClinica.Text = opr_paciente.buscamaxHC() + 1
        VerificaCedula(par_hc)

        'Me.Width = 585
    End Sub




    Public Function VerificaCedula(ByVal Cedula As String) As Boolean
        VerificaCedula = True
        If Len(Trim(Cedula)) <> 10 Then
            VerificaCedula = False
        End If

        If Val(Mid(Cedula, 1, 2)) > 25 Then
            VerificaCedula = False
        End If

        If Val(Mid(Cedula, 3, 1)) > 5 Then
            VerificaCedula = False
        End If

        If VerificaCedula = False Then
            lbl_msg_pac.Text = "CEDULA INCORRECTA"
        Else
            Dim Total As Integer
            Dim Cifra As Integer
            Dim a As Integer
            Total = 0

            For a = 1 To 9

                If (a Mod 2) = 0 Then
                    Cifra = Val(Mid(Cedula, a, 1))
                Else
                    Cifra = Val(Mid(Cedula, a, 1)) * 2
                    If Cifra > 9 Then
                        Cifra = Cifra - 9
                    End If
                End If
                Total = Total + Cifra
            Next

            Cifra = Total Mod 10

            If Cifra > 0 Then
                Cifra = 10 - Cifra
            End If

            If Cifra = Val(Mid(Cedula, 10, 1)) Then
                VerificaCedula = True
            Else
                lbl_msg_pac.Text = "CEDULA INVALIDA"
                VerificaCedula = False
            End If

        End If


    End Function

    Public Sub ESPERA(ByVal INTERVALO As Integer)
        Dim PARADA As New Stopwatch
        PARADA.Start()
        Do While PARADA.ElapsedMilliseconds < INTERVALO
            Application.DoEvents()
        Loop
        PARADA.Stop()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim dtr_fila As DataRow
        Dim lng_pac_id As Long
        If Ctl_txt_apellido.texto_Recupera = "" Then
            MsgBox("Los apellidos del paciente son obligatorios", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            Dim bandera As Integer
            bandera = 0
            'verifico que el documento cedula/ruc/pasaporte no se repita    
            If Trim(Ctl_txt_doc.texto_Recupera) <> "" Then
                If opr_paciente.ComprobarDocPaciente(Trim(Ctl_txt_doc.texto_Recupera)) <> 0 Then
                    bandera = 1
                End If
            End If
            'si bandera es 0 significa que no existe ningun panciente en la base con ese documento 
            'y puede almacenarce 
            If bandera = 0 Then
                lng_pac_id = opr_paciente.LeerMaxPaciente() + 1
                'mando a guardar el pacietne
                Dim i As Short = 0
                If rbtn_si.Checked = True Then
                    i = 1
                Else
                    i = 0
                End If
                opr_paciente.GuardarPaciente(lng_pac_id, Trim(Ctl_txt_doc.texto_Recupera), Cmb_tipodoc.SelectedIndex, Trim(Ctl_txt_apellido.texto_Recupera), Trim(Ctl_txt_nombre.texto_Recupera), Trim(Ctl_txt_direccion.texto_Recupera), Trim(Ctl_txt_fono.texto_Recupera), Trim(Cmb_sexo.Text), Trim(Dtp_fecnac.Text), Now, Trim(Txt_obs.Text), Val(Cmb_ciudad.Text.Substring(50, 10)), Trim(Ctl_txt_mail.texto_Recupera), Trim(txt_hisClinica.Text), i, "NINGUNA", cmb_parentesco.Value, 0, Trim(Ctl_txt_Pais.texto_Recupera()), Trim(Ctl_txt_Profesion.texto_Recupera()), "", "", "", CInt(Mid(cmb_Provincia.Text, 100, 10)), Mid(cmb_Provincia.Text, 1, 100), Mid(Cmb_ciudad.Text, 1, 50), CInt(Mid(cmb_Provincia.Text, 100, 10)), Mid(Cmb_ciudad.Text, 50, 10), Mid(cmb_Provincia.Text, 1, 100), Mid(Cmb_ciudad.Text, 1, 50), "")
                'MsgBox("El nuevo paciente fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
                Dim opr_pedido As New Cls_Pedido()
                opr_pedido.VisualizaMensaje("Paciente almacenado correctamente", 250)
                Dim ctl As Form
                Dim ctl2 As frm_Pedido
                'una vez guardado los datos mando a activar el formulario de pedidos
                'pero en su tag envio los datos del paciente que se ingreso como nuevo
                For Each ctl In frm_refer_main_form.MdiChildren
                    If ctl.Name = "frm_Pedido" Then
                        ctl2 = ctl
                        If Me.rbtn_si.Checked = True Then
                            'Si usa fecha de nacimiento 
                            ctl2.Tag = "pac_doc=" & Trim(Ctl_txt_doc.texto_Recupera) & "/*/pac_apellido=" & Trim(Ctl_txt_apellido.texto_Recupera) & "/*/pac_nombre=" & Trim(Ctl_txt_nombre.texto_Recupera) & "/*/pac_direccion=" & Trim(Ctl_txt_direccion.texto_Recupera) & "/*/pac_fono=" & Trim(Ctl_txt_fono.texto_Recupera) & "/*/pac_id=" & lng_pac_id & "/*/pac_hist_clinica=" & Trim(txt_hisClinica.Text & "/*/pac_grado=" & cmb_grado.Text & "/*/pac_parentesco=" & cmb_parentesco.Text & "/*/pac_usafecnac= SI" & "/*/pac_fecnac=" & Dtp_fecnac.Value) & "/*/pac_genero=" & Trim(Cmb_sexo.Text)
                        Else
                            'Si no usa fecha de nacimiento 
                            ctl2.Tag = "pac_doc=" & Trim(Ctl_txt_doc.texto_Recupera) & "/*/pac_apellido=" & Trim(Ctl_txt_apellido.texto_Recupera) & "/*/pac_nombre=" & Trim(Ctl_txt_nombre.texto_Recupera) & "/*/pac_direccion=" & Trim(Ctl_txt_direccion.texto_Recupera) & "/*/pac_fono=" & Trim(Ctl_txt_fono.texto_Recupera) & "/*/pac_id=" & lng_pac_id & "/*/pac_hist_clinica=" & Trim(txt_hisClinica.Text & "/*/pac_grado=" & cmb_grado.Text & "/*/pac_parentesco=" & cmb_parentesco.Text & "/*/pac_usafecnac= NO" & "/*/pac_fecnac= No data") & "/*/pac_genero=" & Trim(Cmb_sexo.Text)
                        End If

                        ctl2.LLena_datos_paciente_doc()
                        ctl.Activate()
                    End If
                Next
                'regreso el formulario a su estado original
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
                Txt_obs.Text = ""
                txt_hisClinica.Text = ""
                Cmb_sexo.SelectedIndex = 0
                Cmb_ciudad.SelectedIndex = 0
                Dtp_fecnac.Text = Format(Now, "yyyy/MM/dd")
                Me.Close()
            Else
                'en caso de existir ya ese paciente con ese numero de documento
                MsgBox("El Paciente con esa identificacion ya existe, reviselo por favor", MsgBoxStyle.Exclamation, "ANALISYS")
            End If
        End If
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
                    txt_edad.texto_Asigna(m & " meses")
                Else
                    txt_edad.texto_Asigna(d & " dias")
                End If
            Else
                txt_edad.texto_Asigna(y & " año y " & m & " meses")
            End If
        Else
            txt_edad.texto_Asigna(y & " años ")
        End If

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


        palabra = Trim(txt_edad.texto_Recupera().Replace("años", ""))

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


    Private Sub btn_RedPublica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RedPublica.Click
        On Error GoTo MsgError
        Dim cadena_pac As String = Nothing
        Dim cadena_pac_aux As String = Nothing
        Dim apellido1 As String = Nothing
        Dim apellido2 As String = Nothing
        Dim nombre1 As String = Nothing
        Dim nombre2 As String = Nothing
        Dim fechanac As String = Nothing
        Dim sw As Integer
        Dim arreglo_datos As String()
        Dim arreglo_datos_aux As String()
        Dim arreglo_nombre As String()
        Dim i As Integer

        Dim tiempo As Integer = System.Configuration.ConfigurationSettings.AppSettings("Tiempo")
        If btn_RedPublica.Text = "Red Publica >>>" Then
            'Me.Width = 1075
            Me.btn_RedPublica.Text = "<<< Red Publica"
            sw = 0
            pic_wait.Visible = True
            WebBrowser1.Refresh()
            'str_url = "https://coresalud.msp.gob.ec/coresalud/app.php/publico/rpis/afiliacion/consultafiliacion/" & par_hc & "/" & Format(Now, "dd-MM-yyyy") & ""
            str_url = "https://srienlinea.sri.gob.ec/movil-servicios/api/v1.0/deudas/porIdentificacion/" & par_hc & ""
            'WebBrowser1.Navigate(str_url)
            'WebBrowser1.Document.Body.Style = "zoom:60%"

            Using client As New WebClient()
                ' Descargar el archivo JSON como cadena
                Dim jsonContent As String = client.DownloadString(str_url)

                ' Mostrar el JSON en el TextBox
                TextBox1.Text = jsonContent
            End Using

            'ESPERA(tiempo)


            ''For Each ETIQUETA As HtmlElement In WebBrowser1.Document.GetElementsByTagName("tbody")
            ''    If sw = 0 Then
            ''        cadena_pac_aux = (ETIQUETA.InnerText)
            ''        sw = sw + 1
            ''    End If
            ''Next

            arreglo_datos_aux = Split(TextBox1.Text, ":")
            arreglo_nombre = Split(arreglo_datos_aux(8), ",")
            Dim varapellidos As String
            Dim varnombres As String

            For i = 0 To UBound(arreglo_nombre)
                Select Case i
                    Case 0
                        If arreglo_nombre(i).ToString() <> "" Then
                            varapellidos += arreglo_nombre(i).ToString()
                        End If

                    Case 1
                        If arreglo_nombre(i).ToString() <> "" Then
                            varapellidos += arreglo_nombre(i).ToString()
                        End If

                    Case 2
                        If arreglo_nombre(i).ToString() <> "" Then
                            varnombres += arreglo_nombre(i).ToString()
                        End If

                    Case 3
                        If arreglo_nombre(i).ToString() <> "" Then
                            varnombres += arreglo_nombre(i).ToString()
                        End If
                End Select
                
            Next
            arreglo_datos = Split(cadena_pac, "º")
            pic_wait.Visible = False
            arreglo_nombre = Split(Mid(arreglo_datos(0), 1, InStr(cadena_pac, "Fecha") - 1), " ")
            Ctl_txt_apellido.texto_Asigna(arreglo_nombre(0) & " " & arreglo_nombre(1))
            If UBound(arreglo_nombre) = 3 Then
                Ctl_txt_nombre.texto_Asigna(arreglo_nombre(2) & " " & arreglo_nombre(3))
            Else
                Ctl_txt_nombre.texto_Asigna(arreglo_nombre(2) & " " & arreglo_nombre(3) & " " & arreglo_nombre(4))
            End If
            'MsgBox(arreglo_datos(0).ToString())
            'MsgBox(arreglo_datos(1).ToString())
            'MsgBox(arreglo_datos(2).ToString())
            'MsgBox(Mid(arreglo_datos(1), 19, 10))

            '''Dtp_fecnac.Value = CDate(Mid(arreglo_datos(1), 19, 10))
        Else
            Me.Width = 585
            pic_wait.Visible = False
            Me.btn_RedPublica.Text = "Red Publica >>>"
        End If
MsgError:
        'g_opr_usuario.MensajeBoxError("Servicio no disponible", Err)
        'Err.Clear()
    End Sub




    Private Sub cmb_Provincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        Dim dtr_filaCiu As DataRow
        Dim dts_ciudad As DataSet

        dts_ciudad = opr_ciudad.LeerCiudad(CInt(Mid(cmb_Provincia.Text, 101, 110)))

        'cargo en el combo los datos del dataset
        For Each dtr_filaCiu In dts_ciudad.Tables("Registros").Rows
            Cmb_ciudad.Items.Add(dtr_filaCiu("ciu_nombre").ToString().PadRight(50) & dtr_filaCiu("ciu_id").ToString().PadRight(10))
        Next
        'Cmb_tipodoc.SelectedIndex = 3
        Cmb_ciudad.Text = g_ciu_nom.ToString().PadRight(50) & g_ciu_id.ToString().PadRight(10)



    End Sub

    Private Sub btn_IrWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IrWeb.Click
        Try
            WebBrowser1.Refresh()
            str_url = Trim(txt_Url.Text)
            WebBrowser1.Navigate(str_url)
        Catch

        End Try
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ' Verificar si la URL cargada es la del JSON
        If WebBrowser1.Url.ToString().EndsWith(Ctl_txt_doc.texto_Recupera() & ".json") Then
            ' Obtener el contenido JSON del documento
            Dim jsonContent As String = WebBrowser1.DocumentText

            ' Mostrar el JSON en el TextBox
            TextBox1.Text = jsonContent
        End If
    End Sub
End Class
