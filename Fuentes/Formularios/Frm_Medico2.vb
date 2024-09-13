'*************************************************************************
' Nombre:   frm_Mdico2
' Tipo de Archivo: formulario
' Descripci�n:  formulario que me permite el ingreos de un nuevo Medico
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class Frm_medico2
    Inherits System.Windows.Forms.Form
    Dim dts_ciudad As DataSet
    Dim opr_ciu As New Cls_Ciudad()

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
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
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
    Friend WithEvents Ctl_txt_fono As Ctl_txt.ctl_txt_letras
    Friend WithEvents cmb_tipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_bonificacion As System.Windows.Forms.ComboBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_medTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_medico2))
        Me.grp_datos = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_medTipo = New System.Windows.Forms.ComboBox
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_bonificacion = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ctl_txt_fono = New Ctl_txt.ctl_txt_letras
        Me.lbl_ciudad = New System.Windows.Forms.Label
        Me.cmb_ciudad = New System.Windows.Forms.ComboBox
        Me.lbl_tipdoc = New System.Windows.Forms.Label
        Me.cmb_tipodoc = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_mail = New Ctl_txt.ctl_txt_mail
        Me.ctl_txt_dir = New Ctl_txt.ctl_txt_letras
        Me.ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.ctl_txt_doc = New Ctl_txt.ctl_txt_ci_ruc
        Me.lbl_mail = New System.Windows.Forms.Label
        Me.lbl_fono = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_dir = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.grp_datos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_datos
        '
        Me.grp_datos.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos.Controls.Add(Me.Label3)
        Me.grp_datos.Controls.Add(Me.Label4)
        Me.grp_datos.Controls.Add(Me.cmb_medTipo)
        Me.grp_datos.Controls.Add(Me.cmb_Provincia)
        Me.grp_datos.Controls.Add(Me.cmb_especialidad)
        Me.grp_datos.Controls.Add(Me.Label2)
        Me.grp_datos.Controls.Add(Me.cmb_bonificacion)
        Me.grp_datos.Controls.Add(Me.Label1)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_fono)
        Me.grp_datos.Controls.Add(Me.lbl_ciudad)
        Me.grp_datos.Controls.Add(Me.cmb_ciudad)
        Me.grp_datos.Controls.Add(Me.lbl_tipdoc)
        Me.grp_datos.Controls.Add(Me.cmb_tipodoc)
        Me.grp_datos.Controls.Add(Me.Ctl_txt_mail)
        Me.grp_datos.Controls.Add(Me.ctl_txt_dir)
        Me.grp_datos.Controls.Add(Me.ctl_txt_nombre)
        Me.grp_datos.Controls.Add(Me.ctl_txt_doc)
        Me.grp_datos.Controls.Add(Me.lbl_mail)
        Me.grp_datos.Controls.Add(Me.lbl_fono)
        Me.grp_datos.Controls.Add(Me.lbl_nombre)
        Me.grp_datos.Controls.Add(Me.lbl_dir)
        Me.grp_datos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_datos.ForeColor = System.Drawing.Color.Navy
        Me.grp_datos.Location = New System.Drawing.Point(14, 67)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(522, 301)
        Me.grp_datos.TabIndex = 0
        Me.grp_datos.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(284, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Provincia"
        '
        'cmb_medTipo
        '
        Me.cmb_medTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_medTipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_medTipo.Items.AddRange(New Object() {"Referencia"})
        Me.cmb_medTipo.Location = New System.Drawing.Point(94, 193)
        Me.cmb_medTipo.Name = "cmb_medTipo"
        Me.cmb_medTipo.Size = New System.Drawing.Size(158, 21)
        Me.cmb_medTipo.Sorted = True
        Me.cmb_medTipo.TabIndex = 94
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Provincia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Provincia.Location = New System.Drawing.Point(358, 44)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(135, 21)
        Me.cmb_Provincia.Sorted = True
        Me.cmb_Provincia.TabIndex = 81
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.DisplayMember = "1"
        Me.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_especialidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_especialidad.Items.AddRange(New Object() {"CEDULA", "RUC", "PASAPORTE", "NINGUNO"})
        Me.cmb_especialidad.Location = New System.Drawing.Point(94, 216)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(158, 21)
        Me.cmb_especialidad.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Especialidad:"
        '
        'cmb_bonificacion
        '
        Me.cmb_bonificacion.DisplayMember = "1"
        Me.cmb_bonificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bonificacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bonificacion.Items.AddRange(New Object() {"CEDULA", "RUC", "PASAPORTE", "NINGUNO"})
        Me.cmb_bonificacion.Location = New System.Drawing.Point(94, 239)
        Me.cmb_bonificacion.Name = "cmb_bonificacion"
        Me.cmb_bonificacion.Size = New System.Drawing.Size(158, 21)
        Me.cmb_bonificacion.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Bonificacion"
        '
        'Ctl_txt_fono
        '
        Me.Ctl_txt_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_fono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_fono.Location = New System.Drawing.Point(93, 67)
        Me.Ctl_txt_fono.Name = "Ctl_txt_fono"
        Me.Ctl_txt_fono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_fono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_fono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_fono.Size = New System.Drawing.Size(108, 20)
        Me.Ctl_txt_fono.TabIndex = 5
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ciudad.ForeColor = System.Drawing.Color.Black
        Me.lbl_ciudad.Location = New System.Drawing.Point(283, 72)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(45, 13)
        Me.lbl_ciudad.TabIndex = 76
        Me.lbl_ciudad.Text = "Ciudad"
        '
        'cmb_ciudad
        '
        Me.cmb_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ciudad.Location = New System.Drawing.Point(357, 69)
        Me.cmb_ciudad.Name = "cmb_ciudad"
        Me.cmb_ciudad.Size = New System.Drawing.Size(135, 21)
        Me.cmb_ciudad.Sorted = True
        Me.cmb_ciudad.TabIndex = 3
        '
        'lbl_tipdoc
        '
        Me.lbl_tipdoc.AutoSize = True
        Me.lbl_tipdoc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipdoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipdoc.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipdoc.Location = New System.Drawing.Point(12, 48)
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
        Me.cmb_tipodoc.Location = New System.Drawing.Point(93, 44)
        Me.cmb_tipodoc.Name = "cmb_tipodoc"
        Me.cmb_tipodoc.Size = New System.Drawing.Size(85, 21)
        Me.cmb_tipodoc.TabIndex = 1
        '
        'Ctl_txt_mail
        '
        Me.Ctl_txt_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_mail.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_mail.Location = New System.Drawing.Point(94, 162)
        Me.Ctl_txt_mail.Name = "Ctl_txt_mail"
        Me.Ctl_txt_mail.Size = New System.Drawing.Size(400, 20)
        Me.Ctl_txt_mail.TabIndex = 6
        '
        'ctl_txt_dir
        '
        Me.ctl_txt_dir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_dir.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_dir.Location = New System.Drawing.Point(94, 138)
        Me.ctl_txt_dir.Name = "ctl_txt_dir"
        Me.ctl_txt_dir.Prp_CaracterEspecial = New String() {"'"}
        Me.ctl_txt_dir.Prp_CaracterPasswd = ""
        Me.ctl_txt_dir.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.ctl_txt_dir.Size = New System.Drawing.Size(400, 20)
        Me.ctl_txt_dir.TabIndex = 4
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
        Me.ctl_txt_nombre.Size = New System.Drawing.Size(400, 20)
        Me.ctl_txt_nombre.TabIndex = 0
        '
        'ctl_txt_doc
        '
        Me.ctl_txt_doc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctl_txt_doc.ForeColor = System.Drawing.Color.Black
        Me.ctl_txt_doc.Location = New System.Drawing.Point(181, 44)
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
        Me.lbl_mail.Location = New System.Drawing.Point(12, 162)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(30, 13)
        Me.lbl_mail.TabIndex = 64
        Me.lbl_mail.Text = "Mail"
        '
        'lbl_fono
        '
        Me.lbl_fono.AutoSize = True
        Me.lbl_fono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono.ForeColor = System.Drawing.Color.Black
        Me.lbl_fono.Location = New System.Drawing.Point(12, 71)
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
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 23)
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
        Me.lbl_dir.Location = New System.Drawing.Point(12, 140)
        Me.lbl_dir.Name = "lbl_dir"
        Me.lbl_dir.Size = New System.Drawing.Size(59, 13)
        Me.lbl_dir.TabIndex = 20
        Me.lbl_dir.Text = "Direccion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 80
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
        Me.btn_aceptar.Location = New System.Drawing.Point(374, 31)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 37)
        Me.btn_aceptar.TabIndex = 10
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
        Me.btn_cancelar.Location = New System.Drawing.Point(456, 31)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 37)
        Me.btn_cancelar.TabIndex = 12
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(555, 25)
        Me.pan_barra.TabIndex = 93
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(6, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(178, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GESTION DE MEDICOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_medico2
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(555, 385)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_medico2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Medico"
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'bandera para reconocer si la operacion es Nuevo = True, Actualiza = False

#Region "C�digo de Formulario"
    Public frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.MouseEnter, btn_cancelar.MouseEnter
        'cuando el mouse se mueve por encima del los botones del formulario
        Select Case sender.name
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.MouseLeave, btn_cancelar.MouseLeave
        'cuando el mouse se pierde el enfoque del los botones del formulario
        Select Case sender.name
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
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub

#End Region

#Region "Funcionalidad del formulario"

    Sub LimpiaDatos()
        'limpia los datos de las cajas de texto del formulario
        ctl_txt_nombre.texto_Asigna("")
        ctl_txt_nombre.txt_padre.MaxLength = 100
        ctl_txt_doc.texto_Asigna("")
        Ctl_txt_fono.texto_Asigna("")
        Ctl_txt_fono.txt_padre.MaxLength = 30
        ctl_txt_dir.texto_Asigna("")
        ctl_txt_dir.txt_padre.MaxLength = 150
        Ctl_txt_mail.texto_Asigna("")
        Ctl_txt_mail.txt_padre.MaxLength = 100
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

#End Region


    Sub graba_registro()
        'lamo a la funcion para crear el nuevo Medico
        Dim opr_med As New Cls_Medico()

        opr_med.OperaMedico(True, Trim(cmb_ciudad.Text.Substring(50, 5)), ctl_txt_doc.texto_Recupera, _
        cmb_tipodoc.SelectedIndex + 1, ctl_txt_nombre.texto_Recupera, cmb_medTipo.Text, Ctl_txt_fono.texto_Recupera, _
        ctl_txt_dir.texto_Recupera, Ctl_txt_mail.texto_Recupera, Trim(cmb_bonificacion.Text), Trim(cmb_especialidad.Text.Substring(75, 5)), 0, "07:00", "18:00", "L|M|W|J|V|S|D|", 30, CInt(Trim(Mid(cmb_Provincia.Text, 101, 110))), 0, 0, 0)
        'llamo a funcion que limpia los  campos del formulario
        LimpiaDatos()
    End Sub


    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        'verifica que el nombre del medico no sea vacio
        If Trim(ctl_txt_nombre.texto_Recupera) = "" Then
            MsgBox("El nombre de medico es requerido", MsgBoxStyle.Exclamation, "ANALISYS")
            Exit Sub
        End If
        'manda a grabar los datos del medico en la base de datos
        graba_registro()
        Dim ctl As Form
        For Each ctl In frm_refer_main_form.MdiChildren
            If ctl.Name = "frm_Pedido" Then
                Dim ctl2 As frm_Pedido
                ctl2 = ctl
                ctl2.Tag = "frm_medico2"
                ctl2.LLena_datos_paciente_doc()
                ctl2.Activate()
            End If
        Next
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub Frm_medico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'declaracion de variables



        Dim opr_bonificacion As New Cls_Bonificacion()

        opr_ciu.LlenarComboProvincia(cmb_Provincia)

        cmb_Provincia.Text = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE").PadRight(100) & System.Configuration.ConfigurationSettings.AppSettings("PROV_ID").PadRight(10)

        'Me.Top = (frm_refer_main_form.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main_form.mdiClient1.Width - Me.Width) / 2) + frm_refer_main_form.Pan_Menu.Width
        'cargo en un dataset los datos de las ciudades
        'dts_ciudad = opr_ciu.LeerCiudad(CInt(Mid(cmb_Provincia.Text, 101, 110)))
        
        cmb_tipodoc.SelectedIndex = 3
        cmb_medTipo.SelectedIndex = 0
        'cargo el combo de las bonificaciones
        opr_bonificacion.LlenarComboBonificacion(cmb_bonificacion)
        opr_bonificacion.LlenarComboEspecialidad(cmb_especialidad)
        cmb_especialidad.SelectedIndex = 1
        LimpiaDatos()
    End Sub


    Private Sub cmb_Provincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        Dim dtr_filaCiu As DataRow
        'dts_ciudad.Clear()

        dts_ciudad = opr_ciu.LeerCiudad(CInt(Mid(cmb_Provincia.Text, 101, 110)))

        'cargo en el combo los datos del dataset
        For Each dtr_filaCiu In dts_ciudad.Tables("Registros").Rows
            cmb_ciudad.Items.Add(dtr_filaCiu("ciu_nombre").ToString().PadRight(50) & dtr_filaCiu("ciu_id").ToString().PadRight(10))
        Next
        cmb_tipodoc.SelectedIndex = 3
        cmb_ciudad.Text = g_ciu_nom.ToString().PadRight(50) & g_ciu_id.ToString().PadRight(10)


    End Sub
End Class
