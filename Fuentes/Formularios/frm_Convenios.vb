'*************************************************************************
' Nombre:   frm_Convenios
' Tipo de Archivo: formulario
' Descripcin:  Formulario para la administracion de la tabla CONVENIOS 
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2002
' Autores Modificaciones:
' Ultima Modificaci�n: 08/08/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Public Class frm_Convenios
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
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_valor As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_valor As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents grp_convenio As System.Windows.Forms.GroupBox
    Friend WithEvents dgrd_Convenios As System.Windows.Forms.DataGrid
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents dgrd_listaprecio As System.Windows.Forms.DataGrid
    Friend WithEvents btn_repPerfiles As System.Windows.Forms.Button
    Friend WithEvents btn_reportes As System.Windows.Forms.Button
    Friend WithEvents btn_actualiza_precios As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txt_test As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Hasta As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_Unidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_EmailConvenio As System.Windows.Forms.TextBox
    Friend WithEvents rbtn_Web As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Normal As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents txt_usrweb As System.Windows.Forms.TextBox
    Friend WithEvents txt_ConCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Calcular As System.Windows.Forms.Button
    Friend WithEvents txt_desde As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_restablecer As System.Windows.Forms.Button
    Friend WithEvents rbtn_recargo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Dsto As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_usrpass As System.Windows.Forms.Label
    Friend WithEvents txt_usrRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_EnviaCredenciales As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Convenios))
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_valor = New System.Windows.Forms.Label
        Me.Ctl_txt_valor = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_Nombre = New System.Windows.Forms.TextBox
        Me.grp_convenio = New System.Windows.Forms.GroupBox
        Me.txt_ConCodigo = New System.Windows.Forms.TextBox
        Me.txt_usrRuc = New System.Windows.Forms.TextBox
        Me.lbl_msg = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_usrweb = New System.Windows.Forms.TextBox
        Me.lbl_usrpass = New System.Windows.Forms.Label
        Me.btn_EnviaCredenciales = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.rbtn_Web = New System.Windows.Forms.RadioButton
        Me.rbtn_Normal = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_EmailConvenio = New System.Windows.Forms.TextBox
        Me.Ctl_txt_Unidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Hasta = New Ctl_txt.ctl_txt_numeros
        Me.txt_desde = New Ctl_txt.ctl_txt_numeros
        Me.dgrd_Convenios = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgrd_listaprecio = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_repPerfiles = New System.Windows.Forms.Button
        Me.btn_reportes = New System.Windows.Forms.Button
        Me.btn_actualiza_precios = New System.Windows.Forms.Button
        Me.txt_test = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_restablecer = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_Calcular = New System.Windows.Forms.Button
        Me.rbtn_recargo = New System.Windows.Forms.RadioButton
        Me.rbtn_Dsto = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.grp_convenio.SuspendLayout()
        CType(Me.dgrd_Convenios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_listaprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(12, 20)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 42)
        Me.btn_Nuevo.TabIndex = 2
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
        Me.btn_Salir.Location = New System.Drawing.Point(334, 18)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(65, 42)
        Me.btn_Salir.TabIndex = 5
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(168, 20)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 42)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(90, 20)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 42)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(9, 98)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(54, 14)
        Me.lbl_nombre.TabIndex = 45
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_valor
        '
        Me.lbl_valor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.ForeColor = System.Drawing.Color.Black
        Me.lbl_valor.Location = New System.Drawing.Point(11, 26)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(89, 16)
        Me.lbl_valor.TabIndex = 46
        Me.lbl_valor.Text = "PORCENTAJE"
        '
        'Ctl_txt_valor
        '
        Me.Ctl_txt_valor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_valor.Location = New System.Drawing.Point(103, 21)
        Me.Ctl_txt_valor.Name = "Ctl_txt_valor"
        Me.Ctl_txt_valor.Prp_Formato = True
        Me.Ctl_txt_valor.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_valor.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_valor.Prp_ValDefault = "1.0"
        Me.Ctl_txt_valor.Size = New System.Drawing.Size(48, 22)
        Me.Ctl_txt_valor.TabIndex = 4
        '
        'Ctl_txt_Nombre
        '
        Me.Ctl_txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ctl_txt_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Nombre.Location = New System.Drawing.Point(67, 93)
        Me.Ctl_txt_Nombre.MaxLength = 150
        Me.Ctl_txt_Nombre.Multiline = True
        Me.Ctl_txt_Nombre.Name = "Ctl_txt_Nombre"
        Me.Ctl_txt_Nombre.Size = New System.Drawing.Size(257, 22)
        Me.Ctl_txt_Nombre.TabIndex = 1
        '
        'grp_convenio
        '
        Me.grp_convenio.BackColor = System.Drawing.Color.Transparent
        Me.grp_convenio.Controls.Add(Me.txt_ConCodigo)
        Me.grp_convenio.Controls.Add(Me.txt_usrRuc)
        Me.grp_convenio.Controls.Add(Me.lbl_msg)
        Me.grp_convenio.Controls.Add(Me.Label9)
        Me.grp_convenio.Controls.Add(Me.txt_usrweb)
        Me.grp_convenio.Controls.Add(Me.lbl_usrpass)
        Me.grp_convenio.Controls.Add(Me.btn_EnviaCredenciales)
        Me.grp_convenio.Controls.Add(Me.Label7)
        Me.grp_convenio.Controls.Add(Me.Label6)
        Me.grp_convenio.Controls.Add(Me.rbtn_Web)
        Me.grp_convenio.Controls.Add(Me.rbtn_Normal)
        Me.grp_convenio.Controls.Add(Me.Label5)
        Me.grp_convenio.Controls.Add(Me.btn_Nuevo)
        Me.grp_convenio.Controls.Add(Me.txt_EmailConvenio)
        Me.grp_convenio.Controls.Add(Me.btn_Eliminar)
        Me.grp_convenio.Controls.Add(Me.Ctl_txt_Unidad)
        Me.grp_convenio.Controls.Add(Me.btn_Aceptar)
        Me.grp_convenio.Controls.Add(Me.Label2)
        Me.grp_convenio.Controls.Add(Me.Label3)
        Me.grp_convenio.Controls.Add(Me.txt_Hasta)
        Me.grp_convenio.Controls.Add(Me.txt_desde)
        Me.grp_convenio.Controls.Add(Me.Ctl_txt_Nombre)
        Me.grp_convenio.Controls.Add(Me.lbl_nombre)
        Me.grp_convenio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_convenio.ForeColor = System.Drawing.Color.Navy
        Me.grp_convenio.Location = New System.Drawing.Point(12, 31)
        Me.grp_convenio.Name = "grp_convenio"
        Me.grp_convenio.Size = New System.Drawing.Size(360, 337)
        Me.grp_convenio.TabIndex = 0
        Me.grp_convenio.TabStop = False
        '
        'txt_ConCodigo
        '
        Me.txt_ConCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ConCodigo.Enabled = False
        Me.txt_ConCodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ConCodigo.Location = New System.Drawing.Point(82, 220)
        Me.txt_ConCodigo.MaxLength = 150
        Me.txt_ConCodigo.Multiline = True
        Me.txt_ConCodigo.Name = "txt_ConCodigo"
        Me.txt_ConCodigo.Size = New System.Drawing.Size(216, 22)
        Me.txt_ConCodigo.TabIndex = 154
        '
        'txt_usrRuc
        '
        Me.txt_usrRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usrRuc.Enabled = False
        Me.txt_usrRuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usrRuc.Location = New System.Drawing.Point(82, 197)
        Me.txt_usrRuc.MaxLength = 150
        Me.txt_usrRuc.Multiline = True
        Me.txt_usrRuc.Name = "txt_usrRuc"
        Me.txt_usrRuc.Size = New System.Drawing.Size(216, 22)
        Me.txt_usrRuc.TabIndex = 147
        '
        'lbl_msg
        '
        Me.lbl_msg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_msg.Location = New System.Drawing.Point(80, 272)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(246, 65)
        Me.lbl_msg.TabIndex = 152
        Me.lbl_msg.Text = "Al crear un convenio WEB, se envia automaticamente el usuario y contraseña.   Re " & _
            "envíe el usuario y contraseña para CONVENIOS mediante el boton Re Enviar"
        Me.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "CONTRASEÑA"
        '
        'txt_usrweb
        '
        Me.txt_usrweb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usrweb.Enabled = False
        Me.txt_usrweb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usrweb.Location = New System.Drawing.Point(82, 243)
        Me.txt_usrweb.MaxLength = 150
        Me.txt_usrweb.Multiline = True
        Me.txt_usrweb.Name = "txt_usrweb"
        Me.txt_usrweb.Size = New System.Drawing.Size(216, 22)
        Me.txt_usrweb.TabIndex = 151
        '
        'lbl_usrpass
        '
        Me.lbl_usrpass.AutoSize = True
        Me.lbl_usrpass.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usrpass.Location = New System.Drawing.Point(127, 228)
        Me.lbl_usrpass.Name = "lbl_usrpass"
        Me.lbl_usrpass.Size = New System.Drawing.Size(27, 10)
        Me.lbl_usrpass.TabIndex = 155
        Me.lbl_usrpass.Text = "(pass)"
        '
        'btn_EnviaCredenciales
        '
        Me.btn_EnviaCredenciales.BackColor = System.Drawing.SystemColors.Control
        Me.btn_EnviaCredenciales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_EnviaCredenciales.Enabled = False
        Me.btn_EnviaCredenciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EnviaCredenciales.ForeColor = System.Drawing.Color.Black
        Me.btn_EnviaCredenciales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EnviaCredenciales.Location = New System.Drawing.Point(299, 173)
        Me.btn_EnviaCredenciales.Name = "btn_EnviaCredenciales"
        Me.btn_EnviaCredenciales.Size = New System.Drawing.Size(55, 25)
        Me.btn_EnviaCredenciales.TabIndex = 102
        Me.btn_EnviaCredenciales.Text = "Re Enviar"
        Me.btn_EnviaCredenciales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_EnviaCredenciales.UseVisualStyleBackColor = False
        Me.btn_EnviaCredenciales.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(4, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "ID EMPRESA"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(4, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "USUARIO"
        '
        'rbtn_Web
        '
        Me.rbtn_Web.AutoSize = True
        Me.rbtn_Web.Location = New System.Drawing.Point(83, 69)
        Me.rbtn_Web.Name = "rbtn_Web"
        Me.rbtn_Web.Size = New System.Drawing.Size(50, 17)
        Me.rbtn_Web.TabIndex = 149
        Me.rbtn_Web.Text = "Web"
        Me.rbtn_Web.UseVisualStyleBackColor = True
        '
        'rbtn_Normal
        '
        Me.rbtn_Normal.AutoSize = True
        Me.rbtn_Normal.Checked = True
        Me.rbtn_Normal.Location = New System.Drawing.Point(6, 69)
        Me.rbtn_Normal.Name = "rbtn_Normal"
        Me.rbtn_Normal.Size = New System.Drawing.Size(68, 17)
        Me.rbtn_Normal.TabIndex = 148
        Me.rbtn_Normal.TabStop = True
        Me.rbtn_Normal.Text = "Interno"
        Me.rbtn_Normal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "Correo:"
        '
        'txt_EmailConvenio
        '
        Me.txt_EmailConvenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_EmailConvenio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmailConvenio.Location = New System.Drawing.Point(82, 174)
        Me.txt_EmailConvenio.MaxLength = 150
        Me.txt_EmailConvenio.Multiline = True
        Me.txt_EmailConvenio.Name = "txt_EmailConvenio"
        Me.txt_EmailConvenio.Size = New System.Drawing.Size(216, 22)
        Me.txt_EmailConvenio.TabIndex = 146
        '
        'Ctl_txt_Unidad
        '
        Me.Ctl_txt_Unidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ctl_txt_Unidad.Enabled = False
        Me.Ctl_txt_Unidad.Location = New System.Drawing.Point(82, 266)
        Me.Ctl_txt_Unidad.Name = "Ctl_txt_Unidad"
        Me.Ctl_txt_Unidad.Size = New System.Drawing.Size(216, 21)
        Me.Ctl_txt_Unidad.TabIndex = 5
        Me.Ctl_txt_Unidad.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(121, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Fin:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Inicio:"
        '
        'txt_Hasta
        '
        Me.txt_Hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Hasta.Location = New System.Drawing.Point(168, 117)
        Me.txt_Hasta.Name = "txt_Hasta"
        Me.txt_Hasta.Prp_Formato = True
        Me.txt_Hasta.Prp_NumDecimales = CType(0, Short)
        Me.txt_Hasta.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.txt_Hasta.Prp_ValDefault = "13"
        Me.txt_Hasta.Size = New System.Drawing.Size(48, 20)
        Me.txt_Hasta.TabIndex = 3
        '
        'txt_desde
        '
        Me.txt_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desde.Location = New System.Drawing.Point(67, 117)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Prp_Formato = True
        Me.txt_desde.Prp_NumDecimales = CType(0, Short)
        Me.txt_desde.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.txt_desde.Prp_ValDefault = ""
        Me.txt_desde.Size = New System.Drawing.Size(48, 20)
        Me.txt_desde.TabIndex = 2
        '
        'dgrd_Convenios
        '
        Me.dgrd_Convenios.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Convenios.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Convenios.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Convenios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Convenios.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Convenios.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Convenios.CaptionText = "CONVENIOS"
        Me.dgrd_Convenios.DataMember = ""
        Me.dgrd_Convenios.FlatMode = True
        Me.dgrd_Convenios.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_Convenios.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Convenios.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Convenios.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Convenios.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Convenios.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Convenios.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Convenios.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Convenios.Location = New System.Drawing.Point(12, 374)
        Me.dgrd_Convenios.Name = "dgrd_Convenios"
        Me.dgrd_Convenios.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Convenios.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Convenios.ReadOnly = True
        Me.dgrd_Convenios.RowHeaderWidth = 20
        Me.dgrd_Convenios.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Convenios.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Convenios.Size = New System.Drawing.Size(360, 194)
        Me.dgrd_Convenios.TabIndex = 1
        Me.dgrd_Convenios.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Convenios
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CONVENIO"
        Me.DataGridTextBoxColumn1.MappingName = "con_nombre"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 105
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = " %"
        Me.DataGridTextBoxColumn2.MappingName = "con_valor"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 35
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "INICIO"
        Me.DataGridTextBoxColumn6.MappingName = "sec_desde"
        Me.DataGridTextBoxColumn6.Width = 60
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "FIN"
        Me.DataGridTextBoxColumn7.MappingName = "sec_hasta"
        Me.DataGridTextBoxColumn7.Width = 60
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "ABRV"
        Me.DataGridTextBoxColumn8.MappingName = "sec_unidad"
        Me.DataGridTextBoxColumn8.Width = 50
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "EMAIL"
        Me.DataGridTextBoxColumn9.MappingName = "email"
        Me.DataGridTextBoxColumn9.NullText = "N/A"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Sec"
        Me.DataGridTextBoxColumn10.MappingName = "sec_id"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn11.MappingName = "codigo"
        Me.DataGridTextBoxColumn11.NullText = "N/A"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "login"
        Me.DataGridTextBoxColumn12.MappingName = "login"
        Me.DataGridTextBoxColumn12.NullText = "N/A"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "pass"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "TIPO"
        Me.DataGridTextBoxColumn14.MappingName = "CON_TIPO"
        Me.DataGridTextBoxColumn14.NullText = "0"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'dgrd_listaprecio
        '
        Me.dgrd_listaprecio.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_listaprecio.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_listaprecio.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_listaprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_listaprecio.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_listaprecio.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_listaprecio.CaptionText = "LISTA DE PRECIOS POR CONVENIO"
        Me.dgrd_listaprecio.DataMember = ""
        Me.dgrd_listaprecio.FlatMode = True
        Me.dgrd_listaprecio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_listaprecio.ForeColor = System.Drawing.Color.Black
        Me.dgrd_listaprecio.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_listaprecio.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_listaprecio.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_listaprecio.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_listaprecio.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_listaprecio.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_listaprecio.Location = New System.Drawing.Point(378, 198)
        Me.dgrd_listaprecio.Name = "dgrd_listaprecio"
        Me.dgrd_listaprecio.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_listaprecio.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_listaprecio.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_listaprecio.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_listaprecio.Size = New System.Drawing.Size(406, 370)
        Me.dgrd_listaprecio.TabIndex = 93
        Me.dgrd_listaprecio.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgrd_listaprecio
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Registros"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "TEST"
        Me.DataGridTextBoxColumn3.MappingName = "tes_id"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "TEST"
        Me.DataGridTextBoxColumn4.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn4.Width = 260
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = "$ ##,##.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "VALOR USD"
        Me.DataGridTextBoxColumn5.MappingName = "lip_precio"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.Label8)
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(796, 25)
        Me.pan_barra.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(361, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 18)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "LISTA DE PRECIOS"
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(4, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(185, 18)
        Me.lbl_textform.TabIndex = 62
        Me.lbl_textform.Text = "CONVENIOS / TARIFAS"
        '
        'btn_repPerfiles
        '
        Me.btn_repPerfiles.BackColor = System.Drawing.SystemColors.Control
        Me.btn_repPerfiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_repPerfiles.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_repPerfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_repPerfiles.ForeColor = System.Drawing.Color.Black
        Me.btn_repPerfiles.Image = CType(resources.GetObject("btn_repPerfiles.Image"), System.Drawing.Image)
        Me.btn_repPerfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_repPerfiles.Location = New System.Drawing.Point(263, 18)
        Me.btn_repPerfiles.Name = "btn_repPerfiles"
        Me.btn_repPerfiles.Size = New System.Drawing.Size(73, 42)
        Me.btn_repPerfiles.TabIndex = 100
        Me.btn_repPerfiles.Text = "Perfiles"
        Me.btn_repPerfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_repPerfiles.UseVisualStyleBackColor = False
        Me.btn_repPerfiles.Visible = False
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reportes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_reportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reportes.ForeColor = System.Drawing.Color.Black
        Me.btn_reportes.Image = CType(resources.GetObject("btn_reportes.Image"), System.Drawing.Image)
        Me.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reportes.Location = New System.Drawing.Point(191, 18)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(73, 42)
        Me.btn_reportes.TabIndex = 99
        Me.btn_reportes.Text = "Imprimir"
        Me.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reportes.UseVisualStyleBackColor = False
        '
        'btn_actualiza_precios
        '
        Me.btn_actualiza_precios.BackColor = System.Drawing.SystemColors.Control
        Me.btn_actualiza_precios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualiza_precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualiza_precios.ForeColor = System.Drawing.Color.Black
        Me.btn_actualiza_precios.Image = CType(resources.GetObject("btn_actualiza_precios.Image"), System.Drawing.Image)
        Me.btn_actualiza_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualiza_precios.Location = New System.Drawing.Point(106, 18)
        Me.btn_actualiza_precios.Name = "btn_actualiza_precios"
        Me.btn_actualiza_precios.Size = New System.Drawing.Size(86, 42)
        Me.btn_actualiza_precios.TabIndex = 63
        Me.btn_actualiza_precios.Text = "Actualizar"
        Me.btn_actualiza_precios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualiza_precios.UseVisualStyleBackColor = False
        '
        'txt_test
        '
        Me.txt_test.BackColor = System.Drawing.Color.LightGreen
        Me.txt_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_test.Location = New System.Drawing.Point(58, 69)
        Me.txt_test.Name = "txt_test"
        Me.txt_test.Size = New System.Drawing.Size(294, 21)
        Me.txt_test.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Test:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_restablecer)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_actualiza_precios)
        Me.GroupBox1.Controls.Add(Me.txt_test)
        Me.GroupBox1.Controls.Add(Me.btn_Salir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_reportes)
        Me.GroupBox1.Controls.Add(Me.btn_repPerfiles)
        Me.GroupBox1.Location = New System.Drawing.Point(378, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 100)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        '
        'btn_restablecer
        '
        Me.btn_restablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restablecer.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_restablecer.Location = New System.Drawing.Point(381, 79)
        Me.btn_restablecer.Name = "btn_restablecer"
        Me.btn_restablecer.Size = New System.Drawing.Size(17, 15)
        Me.btn_restablecer.TabIndex = 104
        Me.btn_restablecer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32363, 32100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 16)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Calcular
        '
        Me.btn_Calcular.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Calcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calcular.ForeColor = System.Drawing.Color.Black
        Me.btn_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Calcular.Location = New System.Drawing.Point(299, 14)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(101, 42)
        Me.btn_Calcular.TabIndex = 102
        Me.btn_Calcular.Text = "Calcular %"
        Me.btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Calcular.UseVisualStyleBackColor = False
        '
        'rbtn_recargo
        '
        Me.rbtn_recargo.AutoSize = True
        Me.rbtn_recargo.Location = New System.Drawing.Point(211, 22)
        Me.rbtn_recargo.Name = "rbtn_recargo"
        Me.rbtn_recargo.Size = New System.Drawing.Size(65, 17)
        Me.rbtn_recargo.TabIndex = 155
        Me.rbtn_recargo.Text = "Recargo"
        Me.rbtn_recargo.UseVisualStyleBackColor = True
        '
        'rbtn_Dsto
        '
        Me.rbtn_Dsto.AutoSize = True
        Me.rbtn_Dsto.Checked = True
        Me.rbtn_Dsto.Location = New System.Drawing.Point(159, 22)
        Me.rbtn_Dsto.Name = "rbtn_Dsto"
        Me.rbtn_Dsto.Size = New System.Drawing.Size(52, 17)
        Me.rbtn_Dsto.TabIndex = 156
        Me.rbtn_Dsto.TabStop = True
        Me.rbtn_Dsto.Text = "Dscto"
        Me.rbtn_Dsto.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtn_Dsto)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btn_Calcular)
        Me.GroupBox2.Controls.Add(Me.rbtn_recargo)
        Me.GroupBox2.Controls.Add(Me.Ctl_txt_valor)
        Me.GroupBox2.Controls.Add(Me.lbl_valor)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 62)
        Me.GroupBox2.TabIndex = 105
        Me.GroupBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(31996, 32100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(18, 16)
        Me.Button3.TabIndex = 103
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frm_Convenios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(796, 580)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgrd_listaprecio)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.dgrd_Convenios)
        Me.Controls.Add(Me.grp_convenio)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Convenios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenios"
        Me.grp_convenio.ResumeLayout(False)
        Me.grp_convenio.PerformLayout()
        CType(Me.dgrd_Convenios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_listaprecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Dim OPERACION As Byte = 0
    Dim tipo As Byte
    Dim dtt_testeqp As New DataTable("Registros")
    Dim opr_convenio As New Cls_Convenio()
    Dim dtv_test As New DataView(dtt_testeqp)
    Dim str_convenio As String = Nothing

    Dim opr_Sec As New Cls_Secuencias()
    Dim byt_flag As Byte  '0 --> Nuevo registro ;  1 -> Actualizar registro
    Dim str_nombre_antiguo As String
    Dim estado As Byte = 0
    Dim var_SecId As Integer




    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Funci�n para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub



#End Region


    Dim boo_flag As Boolean   ' True --> Para nuevo ;; False --> Para actualizar
    Dim dtv_convenios As New DataView()
    Dim dtv_secuencias As New DataView()



    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub frm_Convenios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm

        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        'grp_convenio.Enabled = False

        dgrd_Convenios.DataSource = dtv_convenios
        opr_convenio.LlenarGridConvenios(dtv_convenios)

        'dgrd_Convenios.SetDataBinding(opr_convenio.LeerConvenio(), "Registros")

        btn_Nuevo.Focus()
        Ctl_txt_valor.txt_padre.MaxLength = 5
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Ctl_txt_Nombre.Text = ""
        Ctl_txt_valor.texto_Asigna("")
        txt_desde.texto_Asigna("")
        txt_Hasta.texto_Asigna("")
        Ctl_txt_Unidad.Text = ""
        txt_EmailConvenio.Text = ""
        txt_ConCodigo.Text = ""
        txt_usrRuc.Text = ""
        txt_usrweb.Text = ""
        btn_EnviaCredenciales.Enabled = False

        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = False
        btn_Nuevo.Enabled = False
        grp_convenio.Enabled = True
        boo_flag = True
        Ctl_txt_valor.texto_Asigna(1.0)
        Ctl_txt_Nombre.Enabled = True
        Ctl_txt_Nombre.Focus()
        OPERACION = 1
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Dim secuenciaError As String = Nothing


        If (Ctl_txt_Nombre.Text = "") Then
            MsgBox("Ingrese el nombre del convenio", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            btn_Nuevo.Enabled = True
            Exit Sub
        End If
        If (Ctl_txt_valor.texto_Recupera = "") Then
            MsgBox("Ingrese el valor (%) del convenio", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_valor.Focus()
            btn_Nuevo.Enabled = True
            Exit Sub
        End If
        If (txt_desde.texto_Recupera = "") Then
            MsgBox("Ingrese la secuencia inicial", MsgBoxStyle.Exclamation, "ANALISYS")
            txt_desde.Focus()
            btn_Nuevo.Enabled = True
            Exit Sub
        End If
        If (txt_Hasta.texto_Recupera = "") Then
            MsgBox("Ingrese la secuencia final", MsgBoxStyle.Exclamation, "ANALISYS")
            txt_Hasta.Focus()
            btn_Nuevo.Enabled = True
            Exit Sub
        Else
            If CInt(txt_Hasta.texto_Recupera) <= CInt(txt_desde.texto_Recupera) Then
                MsgBox("el valor del inicio no puede ser igual o menor al del fin", MsgBoxStyle.Information, "ANALISYS")
                txt_Hasta.Focus()
            End If
        End If
        If (Ctl_txt_Unidad.Text = "") Then
            MsgBox("Ingrese una abreviatura para el convenio", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_Unidad.Focus()
            btn_Nuevo.Enabled = True
            Exit Sub
        End If

        Dim opr_mail As New Cls_NetMail()
        Dim opr_encripta As New Cls_Encripta()
        Dim emp_codigo As String
        Dim emp_login As String
        Dim emp_pass As String
        Dim texto As String
        Dim ParamCorreo As String()

        If boo_flag = True Then    '*** Si se trata de un nuevo CONVENIO 
            If OPERACION <> 1 Then
                MsgBox("Para generar un NUEVO CONVENIO presione el boton NUEVO ", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                Dim dts_area As DataSet
                Dim dtr_fila As DataRow
                Dim dtt_testeqp As New DataTable("Registros")
                Dim dtv_test As New DataView(dtt_testeqp)
                Dim Max_Sec = opr_convenio.devuelveMaxIdConvenio() + 1

                ''''''''''''''''''''''''''''''''''
                'GUARDO EL CONVENIO 
                ''''''''''''''''''''''''''''''''''
                emp_codigo = "clab" & CStr(Format(Max_Sec, "000"))
                txt_ConCodigo.Text = emp_codigo

                opr_convenio.GuardarConvenio(Max_Sec, Trim(Ctl_txt_Nombre.Text.ToUpper()), CDbl(Ctl_txt_valor.texto_Recupera), emp_codigo, Trim(Ctl_txt_Nombre.Text), Trim(txt_usrRuc.Text), Trim(txt_EmailConvenio.Text), tipo)

                dtt_testeqp.Clear()
                opr_convenio.LeerPreciosTest(CDbl(Ctl_txt_valor.texto_Recupera()), dtt_testeqp)


                ''''''''''''''''''''''''''''''''''
                'GUARDO LAS SECUENCIAS
                ''''''''''''''''''''''''''''''''''
                'verifco si no existe ya esa palabra
                If (opr_Sec.BuscarSecuencia(Ctl_txt_Nombre.Text) = True And byt_flag = 0) Then
                    MsgBox("El secuencial ingresado ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
                    Ctl_txt_Nombre.Focus()
                    Exit Sub
                End If

                ' valido que no se choquen las secuencias 
                If (opr_Sec.ValidaChoque(CInt(txt_desde.texto_Recupera()), dtv_secuencias, secuenciaError) = True And byt_flag = 0) Then
                    MsgBox("Verifique la secuencia ingresada que no este dentro de las secuencias existentes. " & secuenciaError, MsgBoxStyle.Exclamation, "ANALISYS")
                    Ctl_txt_Nombre.Focus()
                    Exit Sub
                End If



                opr_Sec.GuardarSecuencia(Max_Sec, Ctl_txt_Nombre.Text.ToUpper(), CInt(Trim(txt_desde.texto_Recupera())), CInt(Trim(txt_Hasta.texto_Recupera)), Ctl_txt_Unidad.Text.ToUpper())

                ''''''''''''''''''''''''''''''''''
                'GUARDO LA LISTA DE PRECIO
                ''''''''''''''''''''''''''''''''''
                opr_convenio.GuardarListaPrecio(dtv_test, (dtv_test.Count - 1), Trim(Ctl_txt_Nombre.Text.ToUpper()), OPERACION)
                'opr_ped.VisualizaMensaje("Convenio creado correctamente", 350)
                ''If rbtn_Web.Checked = True Then
                ''    texto = opr_encripta.Genera_empresa(Max_Sec, Ctl_txt_Nombre.Text, emp_codigo, emp_login, Trim(txt_usrRuc.Text))
                ''    txt_usrweb.Text = emp_login
                ''    'txt_ConCodigo.Text = emp_codigo

                ''    ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
                ''    opr_mail.EnviaCorreo(Trim(txt_EmailConvenio.Text), "CREDENCIALES EMPRESA", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "", ParamCorreo(5))
                ''End If

                dtv_test.AllowNew = False
                dgrd_listaprecio.DataSource = dtv_test
                Ctl_txt_Nombre.Text = ""
                Ctl_txt_valor.texto_Asigna("")

                dgrd_Convenios.DataSource = dtv_convenios
                opr_convenio.LlenarGridConvenios(dtv_convenios)
                OPERACION = 0
                ''dgrd_Convenios.SetDataBinding(opr_convenio.LeerConvenio(), "Registros")
                End If
        Else
                'En caso de actualizar el CONVENIO
                If MsgBox("Desea actualizar el registro?", MsgBoxStyle.YesNo, "ANALISYS") = vbNo Then
                    Ctl_txt_Nombre.Text = ""
                    Ctl_txt_valor.texto_Asigna("")
                    btn_Nuevo.Enabled = True
                    Exit Sub
                Else    'En caso de SI desea actualizar
                    'If opr_convenio.ExisteListaPrecio(Ctl_txt_Nombre.Text.ToUpper()) = True Then
                    'En caso de que tenga el convenio una lista de precios ya generada.
                    'If MsgBox("El cambio del porcentage de ganancia generar� una nueva lista de precios" & ControlChars.CrLf & "lista de precios para el convenio, desea continuar?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
                'str_nombre_antiguo
                opr_convenio.ActualizarConvenio(Ctl_txt_Nombre.Text.ToUpper(), Ctl_txt_valor.texto_Recupera, CInt(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 6)), Trim(txt_usrweb.Text), Trim(txt_usrRuc.Text), Trim(txt_EmailConvenio.Text), tipo)
                opr_Sec.ActualizarSecuencia((Ctl_txt_Nombre.Text).ToUpper(), CInt(Trim(txt_desde.texto_Recupera)), CInt(Trim(txt_Hasta.texto_Recupera)), CInt(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 6)))
                opr_Sec.ActualizarListaPrecio((Ctl_txt_Nombre.Text).ToUpper(), dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0), CDbl(Ctl_txt_valor.texto_Recupera()))
                opr_Sec.ActualizarConvenioPedido(Ctl_txt_Nombre.Text.ToUpper(), str_nombre_antiguo)


                ' ''If rbtn_Web.Checked Then
                ' ''    texto = opr_encripta.Genera_empresa(CInt(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 6)), Ctl_txt_Nombre.Text, emp_codigo, emp_login, Trim(txt_usrRuc.Text))
                ' ''    ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
                ' ''    opr_mail.EnviaCorreo(Trim(txt_EmailConvenio.Text), "CREDENCIALES EMPRESA", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "", ParamCorreo(5))
                ' ''End If


                End If
        End If

        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_convenio.Enabled = False
        btn_Nuevo.Enabled = True
        btn_Nuevo.Focus()
        'opr_convenio.LeerListaPrecio(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)), dtt_testeqp)

        dgrd_Convenios.DataSource = dtv_convenios
        opr_convenio.LlenarGridConvenios(dtv_convenios)


    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click

        If dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 4) <> "NA" Then

            Dim obj_r As Object
            obj_r = MsgBox("Desea eliminar el convenio?", MsgBoxStyle.YesNo, "ANALISYS")
            If obj_r = vbYes Then
                opr_convenio.EliminarConvenio(Ctl_txt_Nombre.Text)
                opr_convenio.EliminarListaPrecios(Ctl_txt_Nombre.Text)
                opr_Sec.EliminaSecuencia(Ctl_txt_Nombre.Text)

                dgrd_Convenios.DataSource = dtv_convenios
                opr_convenio.LlenarGridConvenios(dtv_convenios)
            End If

            Ctl_txt_Nombre.Enabled = True
            Ctl_txt_Nombre.Text = ""
            Ctl_txt_valor.texto_Asigna("")
            txt_desde.texto_Asigna("")
            txt_Hasta.texto_Asigna("")

            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            grp_convenio.Enabled = False
        Else
            MsgBox("Esta secuencia no se puede eliminar por razones de estandar del sistema.", MsgBoxStyle.Information, "ANALISYS")
        End If
    End Sub



    Private Sub Ctl_txt_valor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Ctl_txt_valor.Validating
        If Ctl_txt_valor.texto_Recupera = "" Then
            MsgBox("Debe ingresar el porcentaje de ganancia para este convenio", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If CInt(Ctl_txt_valor.texto_Recupera) > 500 Or CInt(Ctl_txt_valor.texto_Recupera) < 0 Then
                MsgBox("Valor fuera de rango", MsgBoxStyle.Exclamation, "ANALISYS")
                Ctl_txt_valor.texto_Asigna("")
                Ctl_txt_valor.Focus()
            End If
        End If
    End Sub

    Private Sub dgrd_Convenios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Convenios.Click

        If (opr_convenio.ExisteListaPrecio(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0))) = True) Then

            str_convenio = Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0))
            dtt_testeqp.Clear()
            opr_convenio.LeerListaPrecio(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)), dtt_testeqp)
            'Dim dtv_test As New DataView(dtt_testeqp)
            dtv_test.AllowNew = False
            dgrd_listaprecio.DataSource = dtv_test
        Else
            dtt_testeqp.Clear()
            opr_convenio.LeerPreciosTestRestaura(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 1)), dtt_testeqp)
            'Dim dtv_test As New DataView(dtt_testeqp)
            dtv_test.AllowNew = False
            dgrd_listaprecio.DataSource = dtv_test
        End If

        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_convenio.Enabled = True
        'Dim dgc_celda As DataGridCell
        'dgc_celda.ColumnNumber = 0
        'dgc_celda.RowNumber = dgrd_Convenios.CurrentCell.RowNumber
        'dgrd_Convenios.CurrentCell = dgc_celda
        'dgrd_Convenios.Select(dgrd_Convenios.CurrentCell.RowNumber)
        Ctl_txt_valor.Focus()
        btn_Nuevo.Enabled = True

        'txt_nombre.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 1)
        'txt_nombre.Enabled = False
        'Ctl_txt_valor.texto_Asigna(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 2))
        boo_flag = False
        OPERACION = 0



    End Sub

    Private Sub txt_test_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_test.TextChanged
        opr_convenio.ordena_test(txt_test.Text, dtv_test)
    End Sub


    Private Sub btn_actualiza_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualiza_precios.Click
        If Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)) = "" Then
            MsgBox("No existe ningun convenio para realizar la transaccion solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If MsgBox("Desea guardar la lista de precios para el convenio " & Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)) & "?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
                'Guardo la lista de precios del convenio escogido
                If Me.Tag = "" Then
                    opr_convenio.GuardarListaPrecio(dtv_test, (dtv_test.Count - 1), Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)), 0)
                Else
                    opr_convenio.GuardarListaPrecio(dtv_test, (dtv_test.Count - 1), Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)), 1)
                End If

            End If
        End If
        txt_test.Text = ""
        opr_convenio.ordena_test(txt_test.Text, dtv_test)
    End Sub

    Private Sub dgrd_Convenios_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Convenios.CurrentCellChanged
        Dim esWeb As Byte = 0

        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        btn_EnviaCredenciales.Enabled = True
        str_nombre_antiguo = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)
        Ctl_txt_Nombre.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)
        Ctl_txt_Unidad.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 4)
        'var_SecId = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)
        txt_desde.texto_Asigna(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 2))
        txt_Hasta.texto_Asigna(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 3))
        txt_EmailConvenio.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 5)
        txt_ConCodigo.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 7)
        txt_usrweb.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 8)
        lbl_usrpass.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 9)
        txt_usrRuc.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 9)
        esWeb = CInt(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 10))

        If esWeb = 1 Then
            rbtn_Web.Checked = True
            rbtn_Normal.Checked = False
        Else
            rbtn_Web.Checked = False
            rbtn_Normal.Checked = True
        End If

        'If txt_EmailConvenio.Text <> "" Or txt_EmailConvenio.Text <> "N/A" Then
        If rbtn_Web.Checked = True Then
            btn_EnviaCredenciales.Enabled = True
            txt_EmailConvenio.Enabled = True
            txt_usrRuc.Enabled = True
        Else
            btn_EnviaCredenciales.Enabled = False
            txt_EmailConvenio.Enabled = False
            txt_usrRuc.Enabled = False
        End If
        byt_flag = 1
        Dim dgCell As DataGridCell
        dgCell.ColumnNumber = 2
        dgCell.RowNumber = dgrd_Convenios.CurrentCell.RowNumber
        dgrd_Convenios.CurrentCell = dgCell
        dgrd_Convenios.Select(dgrd_Convenios.CurrentCell.RowNumber)
        If (opr_convenio.ExisteListaPrecio(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0))) = True) Then

            str_convenio = Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0))
            dtt_testeqp.Clear()
            opr_convenio.LeerListaPrecio(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)), dtt_testeqp)
            'Dim dtv_test As New DataView(dtt_testeqp)
            dtv_test.AllowNew = False
            dgrd_listaprecio.DataSource = dtv_test
        Else
            dtt_testeqp.Clear()
            opr_convenio.LeerPreciosTestRestaura(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 1)), dtt_testeqp)
            'Dim dtv_test As New DataView(dtt_testeqp)
            dtv_test.AllowNew = False
            dgrd_listaprecio.DataSource = Nothing
            dgrd_listaprecio.DataSource = dtv_test
        End If

        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_convenio.Enabled = True
        'btn_EnviaCredenciales.Enabled = False

        'Dim dgc_celda As DataGridCell
        'dgc_celda.ColumnNumber = 0
        'dgc_celda.RowNumber = dgrd_Convenios.CurrentCell.RowNumber
        'dgrd_Convenios.CurrentCell = dgc_celda
        'dgrd_Convenios.Select(dgrd_Convenios.CurrentCell.RowNumber)
        Ctl_txt_valor.Focus()
        btn_Nuevo.Enabled = True

        'txt_nombre.Text = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 1)
        'txt_nombre.Enabled = False
        'Ctl_txt_valor.texto_Asigna(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 2))
        boo_flag = False
        OPERACION = 0


    End Sub

    Private Sub rbtn_Normal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_Normal.CheckedChanged

        

        If rbtn_Normal.Checked Then
            tipo = 0
            txt_EmailConvenio.Enabled = False
            txt_usrRuc.Enabled = False
        Else
            tipo = 1
            txt_EmailConvenio.Enabled = True
            txt_usrRuc.Enabled = True
        End If
    End Sub


    Private Sub Ctl_txt_Nombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_Nombre.Leave
        If Ctl_txt_Nombre.Text = "NORMAL" Or Ctl_txt_Nombre.Text = "URGENCIA" Then

            Ctl_txt_Unidad.Text = "NA"
        Else

            Ctl_txt_Unidad.Text = Mid(Ctl_txt_Nombre.Text, 1, 3)
        End If
    End Sub

    Private Sub rbtn_Web_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_Web.CheckedChanged
        
        If rbtn_Web.Checked Then
            tipo = 1
            txt_EmailConvenio.Enabled = True
            txt_usrRuc.Enabled = True
            txt_usrweb.Text = Trim(Ctl_txt_Nombre.Text)
        Else
            tipo = 0
            txt_EmailConvenio.Enabled = False
            txt_usrRuc.Enabled = False
            txt_usrweb.Text = ""
        End If
    End Sub

    Private Sub btn_EnviaCredenciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EnviaCredenciales.Click
        Dim opr_encripta As New Cls_Encripta()
        Dim opr_mail As New Cls_NetMail()
        Dim opr_ped As New Cls_Pedido()
        Dim emp_codigo As String
        Dim emp_login As String
        Dim emp_pass As String
        Dim ParamCorreo As String()
        If txt_EmailConvenio.Text <> "" Then
            Dim texto As String = Nothing
            texto = opr_encripta.Reenvia_empresa(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 6), Ctl_txt_Nombre.Text, Trim(txt_ConCodigo.Text), Trim(txt_usrweb.Text), Trim(txt_usrRuc.Text))

            ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
            opr_mail.EnviaCorreo(Trim(txt_EmailConvenio.Text), "CREDENCIALES EMPRESA", texto, ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "", ParamCorreo(5))
            opr_ped.VisualizaMensaje("Credenciales enviadas con exito", 350)
        Else
            opr_ped.VisualizaMensaje("No tiene una direccion de correo válida", 350)
        End If
    End Sub

    Private Sub btn_reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reportes.Click
        ' ''Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ' ''Dim str_sql As String
        ' ''Dim obj_reporte As New rpt_convenios()
        '' ''Envio el sql que se requiere para que genere Crystal el reporte deseado
        ' ''str_sql = "select convenio.CON_ID, convenio.CON_NOMBRE, convenio.CON_WEB_EMAIL, secuencias.sec_desde, secuencias.sec_hasta from convenio, secuencias where convenio.CON_ID = secuencias.sec_id and secuencias.sec_estado = 1 order by convenio.CON_ID asc;"
        ' ''Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte)
        ' ''frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        ' ''frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        ' ''frm_MDIChild.Text = "CONVENIOS"
        ' ''frm_refer_main_form.Crea_formulario(frm_MDIChild)
        ' ''Me.Cursor = System.Windows.Forms.Cursors.Arrow

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_listasPrecios()
        'str_sql = "SELECT C.CON_NOMBRE AS CON_NOMBRE, A.TES_NOMBRE AS TES_NOMBRE, B.LIP_PRECIO AS LIP_PRECIO  FROM TEST A, LISTA_PRECIO B, CONVENIO C  WHERE B.TES_ID = A.TES_ID AND B.CON_NOMBRE = C.CON_NOMBRE"
        str_sql = "SELECT C.CON_NOMBRE AS CON_NOMBRE, A.TES_NOMBRE AS TES_NOMBRE, B.LIP_PRECIO AS LIP_PRECIO, C.CON_VALOR AS CON_VALOR FROM TEST A, LISTA_PRECIO B, CONVENIO C  WHERE B.TES_ID = A.TES_ID AND B.CON_NOMBRE = C.CON_NOMBRE AND A.TES_TIPO = 'Examen' order by TES_NOMBRE, CON_VALOR"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "LISTADO DE PRECIOS TEST"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub



    Private Sub btn_Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Calcular.Click
        Dim secuenciaError As String = Nothing
        Dim opr_ped As New Cls_Pedido()
        Dim convenio = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)
        Dim Dscto As Integer

        If rbtn_Dsto.Checked Then
            Dscto = 1
        End If


        If rbtn_recargo.Checked Then
            Dscto = 0
        End If


        If convenio <> "NORMAL" Then
            If MsgBox("Se va a volver a calcular los precios para el convenio " & Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)) & ", con el porcentaje " & Ctl_txt_valor.texto_Recupera & " esta seguro?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
                txt_test.Text = ""
                opr_convenio.EliminarListaPrecios(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)))
                opr_convenio.LeerPreciosTest1(convenio, Ctl_txt_valor.texto_Recupera(), dtt_testeqp, Dscto)
                opr_convenio.GuardarListaPrecio(dtv_test, (dtv_test.Count - 1), Trim(convenio), 1)
                opr_convenio.LeerListaPrecio(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)), dtt_testeqp)
                dtv_test.AllowNew = False
                dgrd_listaprecio.DataSource = Nothing
                dgrd_listaprecio.DataSource = dtv_test
                opr_ped.VisualizaMensaje("Calculo aplicado con exito", 250)
                OPERACION = 0
            Else

            End If
        Else

            opr_ped.VisualizaMensaje("Este convenio no se puede calcular ya que es convenio base", 350)
        End If
    End Sub


    Private Sub btn_restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restablecer.Click
        Dim secuenciaError As String = Nothing
        Dim convenio = dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)

        If MsgBox("Se van a volver a generar los precios para el convenio " & Trim(convenio) & ", esta seguro?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            opr_convenio.EliminarListaPrecios(Trim(convenio))
            opr_convenio.LeerPreciosTestRestaura(convenio, dtt_testeqp)
            opr_convenio.GuardarListaPrecio(dtv_test, (dtv_test.Count - 1), Trim(convenio), 1)
            opr_convenio.LeerListaPrecio(Trim(dgrd_Convenios.Item(dgrd_Convenios.CurrentCell.RowNumber, 0)), dtt_testeqp)
            dtv_test.AllowNew = False
            dgrd_listaprecio.DataSource = dtv_test
            OPERACION = 0
        Else

        End If

    End Sub



    
    Private Sub Ctl_txt_Nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_Nombre.TextChanged
        If rbtn_Web.Checked = True Then
            txt_usrweb.Text = Ctl_txt_Nombre.Text
        End If
    End Sub

   
   
End Class
