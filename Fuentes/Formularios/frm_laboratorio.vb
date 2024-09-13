'*************************************************************************
' Nombre:   frm_laboratorio
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite manipular los laboratorios
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System.Data

Imports System.IO

Public Class frm_laboratorio
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
    Friend WithEvents lbl_NombreLab As System.Windows.Forms.Label
    Friend WithEvents lbl_RucLab As System.Windows.Forms.Label
    Friend WithEvents lbl_DirLab As System.Windows.Forms.Label
    Friend WithEvents lbl_TelfLab As System.Windows.Forms.Label
    Friend WithEvents lbl_FaxLab As System.Windows.Forms.Label
    Friend WithEvents lbl_emailLab As System.Windows.Forms.Label
    Friend WithEvents lbl_WebLab As System.Windows.Forms.Label
    Friend WithEvents lbl_EspecLab As System.Windows.Forms.Label
    Friend WithEvents lbl_RepLab As System.Windows.Forms.Label
    Friend WithEvents lbl_CiudadLab As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_NomLab As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_RucLab As Ctl_txt.ctl_txt_ci_ruc
    Friend WithEvents Ctl_txt_EmailLab As Ctl_txt.ctl_txt_mail
    Friend WithEvents Ctl_txt_WebLab As Ctl_txt.ctl_txt_letras
    Friend WithEvents cmb_Ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_TelfLab As System.Windows.Forms.TextBox
    Friend WithEvents txt_FaxLab As System.Windows.Forms.TextBox
    Friend WithEvents txt_Dir As System.Windows.Forms.TextBox
    Friend WithEvents txt_Especialidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_Representante As System.Windows.Forms.TextBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents grp_laboratorio As System.Windows.Forms.GroupBox
    Friend WithEvents dgrd_laboratorio As System.Windows.Forms.DataGrid
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
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_from As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_port As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_server As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_pass As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_GuardaEmail As System.Windows.Forms.Button
    Friend WithEvents Dts_hojaT1 As AnalisysLAB.dts_hojaT
    Friend WithEvents chk_ssl As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscalogo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_laboratorio))
        Me.lbl_NombreLab = New System.Windows.Forms.Label
        Me.lbl_RucLab = New System.Windows.Forms.Label
        Me.lbl_DirLab = New System.Windows.Forms.Label
        Me.lbl_TelfLab = New System.Windows.Forms.Label
        Me.lbl_FaxLab = New System.Windows.Forms.Label
        Me.lbl_emailLab = New System.Windows.Forms.Label
        Me.lbl_WebLab = New System.Windows.Forms.Label
        Me.lbl_EspecLab = New System.Windows.Forms.Label
        Me.lbl_RepLab = New System.Windows.Forms.Label
        Me.lbl_CiudadLab = New System.Windows.Forms.Label
        Me.Ctl_txt_NomLab = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_RucLab = New Ctl_txt.ctl_txt_ci_ruc
        Me.Ctl_txt_EmailLab = New Ctl_txt.ctl_txt_mail
        Me.Ctl_txt_WebLab = New Ctl_txt.ctl_txt_letras
        Me.cmb_Ciudad = New System.Windows.Forms.ComboBox
        Me.txt_TelfLab = New System.Windows.Forms.TextBox
        Me.txt_FaxLab = New System.Windows.Forms.TextBox
        Me.grp_laboratorio = New System.Windows.Forms.GroupBox
        Me.btn_buscalogo = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmb_tipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Representante = New System.Windows.Forms.TextBox
        Me.txt_Especialidad = New System.Windows.Forms.TextBox
        Me.txt_Dir = New System.Windows.Forms.TextBox
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.dgrd_laboratorio = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Ctl_txt_from = New Ctl_txt.ctl_txt_letras
        Me.Label4 = New System.Windows.Forms.Label
        Me.Ctl_txt_port = New Ctl_txt.ctl_txt_letras
        Me.Label5 = New System.Windows.Forms.Label
        Me.Ctl_txt_server = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_pass = New Ctl_txt.ctl_txt_letras
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_GuardaEmail = New System.Windows.Forms.Button
        Me.Dts_hojaT1 = New AnalisysLAB.dts_hojaT
        Me.chk_ssl = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox
        Me.grp_laboratorio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_laboratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        CType(Me.Dts_hojaT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NombreLab
        '
        Me.lbl_NombreLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NombreLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_NombreLab.Location = New System.Drawing.Point(110, 23)
        Me.lbl_NombreLab.Name = "lbl_NombreLab"
        Me.lbl_NombreLab.Size = New System.Drawing.Size(70, 14)
        Me.lbl_NombreLab.TabIndex = 6
        Me.lbl_NombreLab.Text = "NOMBRE"
        '
        'lbl_RucLab
        '
        Me.lbl_RucLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RucLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RucLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_RucLab.Location = New System.Drawing.Point(17, 77)
        Me.lbl_RucLab.Name = "lbl_RucLab"
        Me.lbl_RucLab.Size = New System.Drawing.Size(46, 12)
        Me.lbl_RucLab.TabIndex = 7
        Me.lbl_RucLab.Text = "R.U.C."
        '
        'lbl_DirLab
        '
        Me.lbl_DirLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DirLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DirLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_DirLab.Location = New System.Drawing.Point(109, 48)
        Me.lbl_DirLab.Name = "lbl_DirLab"
        Me.lbl_DirLab.Size = New System.Drawing.Size(70, 14)
        Me.lbl_DirLab.TabIndex = 8
        Me.lbl_DirLab.Text = "DIRECCION"
        '
        'lbl_TelfLab
        '
        Me.lbl_TelfLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TelfLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TelfLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_TelfLab.Location = New System.Drawing.Point(17, 104)
        Me.lbl_TelfLab.Name = "lbl_TelfLab"
        Me.lbl_TelfLab.Size = New System.Drawing.Size(70, 14)
        Me.lbl_TelfLab.TabIndex = 9
        Me.lbl_TelfLab.Text = "TELEFONO"
        '
        'lbl_FaxLab
        '
        Me.lbl_FaxLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FaxLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FaxLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_FaxLab.Location = New System.Drawing.Point(304, 104)
        Me.lbl_FaxLab.Name = "lbl_FaxLab"
        Me.lbl_FaxLab.Size = New System.Drawing.Size(28, 14)
        Me.lbl_FaxLab.TabIndex = 10
        Me.lbl_FaxLab.Text = "FAX"
        '
        'lbl_emailLab
        '
        Me.lbl_emailLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_emailLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emailLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_emailLab.Location = New System.Drawing.Point(17, 128)
        Me.lbl_emailLab.Name = "lbl_emailLab"
        Me.lbl_emailLab.Size = New System.Drawing.Size(70, 14)
        Me.lbl_emailLab.TabIndex = 11
        Me.lbl_emailLab.Text = "EMAIL"
        '
        'lbl_WebLab
        '
        Me.lbl_WebLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_WebLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_WebLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_WebLab.Location = New System.Drawing.Point(304, 132)
        Me.lbl_WebLab.Name = "lbl_WebLab"
        Me.lbl_WebLab.Size = New System.Drawing.Size(34, 14)
        Me.lbl_WebLab.TabIndex = 12
        Me.lbl_WebLab.Text = "WEB"
        '
        'lbl_EspecLab
        '
        Me.lbl_EspecLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EspecLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EspecLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_EspecLab.Location = New System.Drawing.Point(17, 156)
        Me.lbl_EspecLab.Name = "lbl_EspecLab"
        Me.lbl_EspecLab.Size = New System.Drawing.Size(94, 19)
        Me.lbl_EspecLab.TabIndex = 13
        Me.lbl_EspecLab.Text = "ESPECIALIDAD"
        '
        'lbl_RepLab
        '
        Me.lbl_RepLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_RepLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RepLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_RepLab.Location = New System.Drawing.Point(17, 186)
        Me.lbl_RepLab.Name = "lbl_RepLab"
        Me.lbl_RepLab.Size = New System.Drawing.Size(101, 16)
        Me.lbl_RepLab.TabIndex = 14
        Me.lbl_RepLab.Text = "REPRESENTANTE"
        '
        'lbl_CiudadLab
        '
        Me.lbl_CiudadLab.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CiudadLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CiudadLab.ForeColor = System.Drawing.Color.Black
        Me.lbl_CiudadLab.Location = New System.Drawing.Point(277, 211)
        Me.lbl_CiudadLab.Name = "lbl_CiudadLab"
        Me.lbl_CiudadLab.Size = New System.Drawing.Size(56, 14)
        Me.lbl_CiudadLab.TabIndex = 15
        Me.lbl_CiudadLab.Text = "CIUDAD"
        '
        'Ctl_txt_NomLab
        '
        Me.Ctl_txt_NomLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_NomLab.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_NomLab.Location = New System.Drawing.Point(185, 17)
        Me.Ctl_txt_NomLab.Name = "Ctl_txt_NomLab"
        Me.Ctl_txt_NomLab.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_NomLab.Prp_CaracterPasswd = ""
        Me.Ctl_txt_NomLab.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_NomLab.Size = New System.Drawing.Size(321, 20)
        Me.Ctl_txt_NomLab.TabIndex = 1
        '
        'Ctl_txt_RucLab
        '
        Me.Ctl_txt_RucLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_RucLab.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_RucLab.Location = New System.Drawing.Point(110, 72)
        Me.Ctl_txt_RucLab.Name = "Ctl_txt_RucLab"
        Me.Ctl_txt_RucLab.Prp_Documento = Ctl_txt.ctl_txt_ci_ruc.ValoresTipoDoc.RUC
        Me.Ctl_txt_RucLab.Size = New System.Drawing.Size(180, 20)
        Me.Ctl_txt_RucLab.TabIndex = 2
        '
        'Ctl_txt_EmailLab
        '
        Me.Ctl_txt_EmailLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_EmailLab.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_EmailLab.Location = New System.Drawing.Point(112, 127)
        Me.Ctl_txt_EmailLab.Name = "Ctl_txt_EmailLab"
        Me.Ctl_txt_EmailLab.Size = New System.Drawing.Size(178, 20)
        Me.Ctl_txt_EmailLab.TabIndex = 6
        '
        'Ctl_txt_WebLab
        '
        Me.Ctl_txt_WebLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_WebLab.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_WebLab.Location = New System.Drawing.Point(356, 127)
        Me.Ctl_txt_WebLab.Name = "Ctl_txt_WebLab"
        Me.Ctl_txt_WebLab.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_WebLab.Prp_CaracterPasswd = ""
        Me.Ctl_txt_WebLab.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_WebLab.Size = New System.Drawing.Size(150, 20)
        Me.Ctl_txt_WebLab.TabIndex = 7
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Ciudad.Location = New System.Drawing.Point(332, 208)
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Size = New System.Drawing.Size(174, 21)
        Me.cmb_Ciudad.TabIndex = 10
        '
        'txt_TelfLab
        '
        Me.txt_TelfLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TelfLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TelfLab.Location = New System.Drawing.Point(110, 98)
        Me.txt_TelfLab.MaxLength = 30
        Me.txt_TelfLab.Name = "txt_TelfLab"
        Me.txt_TelfLab.Size = New System.Drawing.Size(180, 21)
        Me.txt_TelfLab.TabIndex = 4
        '
        'txt_FaxLab
        '
        Me.txt_FaxLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FaxLab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FaxLab.Location = New System.Drawing.Point(356, 98)
        Me.txt_FaxLab.MaxLength = 30
        Me.txt_FaxLab.Name = "txt_FaxLab"
        Me.txt_FaxLab.Size = New System.Drawing.Size(150, 21)
        Me.txt_FaxLab.TabIndex = 5
        '
        'grp_laboratorio
        '
        Me.grp_laboratorio.BackColor = System.Drawing.Color.Transparent
        Me.grp_laboratorio.Controls.Add(Me.cmb_Ciudad)
        Me.grp_laboratorio.Controls.Add(Me.txt_Representante)
        Me.grp_laboratorio.Controls.Add(Me.Label7)
        Me.grp_laboratorio.Controls.Add(Me.cmb_Provincia)
        Me.grp_laboratorio.Controls.Add(Me.btn_buscalogo)
        Me.grp_laboratorio.Controls.Add(Me.PictureBox2)
        Me.grp_laboratorio.Controls.Add(Me.PictureBox1)
        Me.grp_laboratorio.Controls.Add(Me.cmb_tipo)
        Me.grp_laboratorio.Controls.Add(Me.Label1)
        Me.grp_laboratorio.Controls.Add(Me.txt_Especialidad)
        Me.grp_laboratorio.Controls.Add(Me.txt_Dir)
        Me.grp_laboratorio.Controls.Add(Me.lbl_FaxLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_TelfLab)
        Me.grp_laboratorio.Controls.Add(Me.txt_FaxLab)
        Me.grp_laboratorio.Controls.Add(Me.Ctl_txt_NomLab)
        Me.grp_laboratorio.Controls.Add(Me.txt_TelfLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_RucLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_NombreLab)
        Me.grp_laboratorio.Controls.Add(Me.Ctl_txt_RucLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_DirLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_CiudadLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_EspecLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_WebLab)
        Me.grp_laboratorio.Controls.Add(Me.Ctl_txt_WebLab)
        Me.grp_laboratorio.Controls.Add(Me.Ctl_txt_EmailLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_emailLab)
        Me.grp_laboratorio.Controls.Add(Me.lbl_RepLab)
        Me.grp_laboratorio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_laboratorio.ForeColor = System.Drawing.Color.Navy
        Me.grp_laboratorio.Location = New System.Drawing.Point(10, 73)
        Me.grp_laboratorio.Name = "grp_laboratorio"
        Me.grp_laboratorio.Size = New System.Drawing.Size(771, 248)
        Me.grp_laboratorio.TabIndex = 0
        Me.grp_laboratorio.TabStop = False
        '
        'btn_buscalogo
        '
        Me.btn_buscalogo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscalogo.Location = New System.Drawing.Point(669, 181)
        Me.btn_buscalogo.Name = "btn_buscalogo"
        Me.btn_buscalogo.Size = New System.Drawing.Size(83, 23)
        Me.btn_buscalogo.TabIndex = 20
        Me.btn_buscalogo.Text = "Buscar Logo"
        Me.btn_buscalogo.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(512, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 158)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.Items.AddRange(New Object() {"SUCURSAL", "MATRIZ", "ANEXO"})
        Me.cmb_tipo.Location = New System.Drawing.Point(356, 70)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(150, 21)
        Me.cmb_tipo.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(303, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "TIPO"
        '
        'txt_Representante
        '
        Me.txt_Representante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Representante.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Representante.Location = New System.Drawing.Point(112, 181)
        Me.txt_Representante.MaxLength = 150
        Me.txt_Representante.Name = "txt_Representante"
        Me.txt_Representante.Size = New System.Drawing.Size(394, 21)
        Me.txt_Representante.TabIndex = 9
        '
        'txt_Especialidad
        '
        Me.txt_Especialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Especialidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Especialidad.Location = New System.Drawing.Point(112, 154)
        Me.txt_Especialidad.MaxLength = 150
        Me.txt_Especialidad.Name = "txt_Especialidad"
        Me.txt_Especialidad.Size = New System.Drawing.Size(394, 21)
        Me.txt_Especialidad.TabIndex = 8
        '
        'txt_Dir
        '
        Me.txt_Dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Dir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Dir.Location = New System.Drawing.Point(185, 41)
        Me.txt_Dir.MaxLength = 150
        Me.txt_Dir.Name = "txt_Dir"
        Me.txt_Dir.Size = New System.Drawing.Size(321, 21)
        Me.txt_Dir.TabIndex = 3
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(449, 31)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 43)
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
        Me.btn_Salir.Location = New System.Drawing.Point(701, 31)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 43)
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(617, 31)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 43)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(533, 31)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 43)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'dgrd_laboratorio
        '
        Me.dgrd_laboratorio.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_laboratorio.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_laboratorio.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_laboratorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_laboratorio.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_laboratorio.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_laboratorio.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_laboratorio.CaptionText = "LABORATORIO Y SUCURSALES"
        Me.dgrd_laboratorio.DataMember = ""
        Me.dgrd_laboratorio.FlatMode = True
        Me.dgrd_laboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_laboratorio.ForeColor = System.Drawing.Color.Black
        Me.dgrd_laboratorio.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_laboratorio.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_laboratorio.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_laboratorio.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_laboratorio.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_laboratorio.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_laboratorio.Location = New System.Drawing.Point(12, 327)
        Me.dgrd_laboratorio.Name = "dgrd_laboratorio"
        Me.dgrd_laboratorio.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_laboratorio.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_laboratorio.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_laboratorio.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_laboratorio.Size = New System.Drawing.Size(484, 133)
        Me.dgrd_laboratorio.TabIndex = 1
        Me.dgrd_laboratorio.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_laboratorio
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "lab_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "lab_nombre"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 175
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "RUC"
        Me.DataGridTextBoxColumn3.MappingName = "lab_ruc"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Direcci�n"
        Me.DataGridTextBoxColumn4.MappingName = "lab_direccion"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 150
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Tel�fono"
        Me.DataGridTextBoxColumn5.MappingName = "lab_fono"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "lab_fax"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "lab_mail"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "lab_web"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "lab_especialidad"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Representante"
        Me.DataGridTextBoxColumn10.MappingName = "lab_representante"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 240
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "ciu_nombre"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "lab_tipo"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "ciu_id"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(793, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(16, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(121, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "LABORATORIO"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(500, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "FROM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(499, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 18)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "DATOS CORREO ENVIO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ctl_txt_from
        '
        Me.Ctl_txt_from.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_from.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_from.Location = New System.Drawing.Point(553, 351)
        Me.Ctl_txt_from.Name = "Ctl_txt_from"
        Me.Ctl_txt_from.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_from.Prp_CaracterPasswd = ""
        Me.Ctl_txt_from.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_from.Size = New System.Drawing.Size(232, 20)
        Me.Ctl_txt_from.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(500, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "PORT"
        '
        'Ctl_txt_port
        '
        Me.Ctl_txt_port.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_port.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_port.Location = New System.Drawing.Point(553, 375)
        Me.Ctl_txt_port.Name = "Ctl_txt_port"
        Me.Ctl_txt_port.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_port.Prp_CaracterPasswd = ""
        Me.Ctl_txt_port.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_port.Size = New System.Drawing.Size(45, 20)
        Me.Ctl_txt_port.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(500, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "SERVER"
        '
        'Ctl_txt_server
        '
        Me.Ctl_txt_server.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_server.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_server.Location = New System.Drawing.Point(552, 399)
        Me.Ctl_txt_server.Name = "Ctl_txt_server"
        Me.Ctl_txt_server.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_server.Prp_CaracterPasswd = ""
        Me.Ctl_txt_server.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_server.Size = New System.Drawing.Size(232, 20)
        Me.Ctl_txt_server.TabIndex = 96
        '
        'Ctl_txt_pass
        '
        Me.Ctl_txt_pass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_pass.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_pass.Location = New System.Drawing.Point(552, 423)
        Me.Ctl_txt_pass.Name = "Ctl_txt_pass"
        Me.Ctl_txt_pass.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_pass.Prp_CaracterPasswd = ""
        Me.Ctl_txt_pass.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_pass.Size = New System.Drawing.Size(232, 20)
        Me.Ctl_txt_pass.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(500, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "PASS"
        '
        'btn_GuardaEmail
        '
        Me.btn_GuardaEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GuardaEmail.Location = New System.Drawing.Point(700, 448)
        Me.btn_GuardaEmail.Name = "btn_GuardaEmail"
        Me.btn_GuardaEmail.Size = New System.Drawing.Size(83, 23)
        Me.btn_GuardaEmail.TabIndex = 21
        Me.btn_GuardaEmail.Text = "Guardar"
        Me.btn_GuardaEmail.UseVisualStyleBackColor = True
        '
        'Dts_hojaT1
        '
        Me.Dts_hojaT1.DataSetName = "dts_hojaT"
        Me.Dts_hojaT1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'chk_ssl
        '
        Me.chk_ssl.AutoSize = True
        Me.chk_ssl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_ssl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ssl.Location = New System.Drawing.Point(508, 449)
        Me.chk_ssl.Name = "chk_ssl"
        Me.chk_ssl.Size = New System.Drawing.Size(58, 17)
        Me.chk_ssl.TabIndex = 99
        Me.chk_ssl.Text = "SSL    "
        Me.chk_ssl.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "PROVINCIA"
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Provincia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Provincia.Location = New System.Drawing.Point(111, 209)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(161, 21)
        Me.cmb_Provincia.TabIndex = 21
        '
        'frm_laboratorio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(793, 480)
        Me.Controls.Add(Me.chk_ssl)
        Me.Controls.Add(Me.btn_GuardaEmail)
        Me.Controls.Add(Me.Ctl_txt_pass)
        Me.Controls.Add(Me.Ctl_txt_server)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ctl_txt_port)
        Me.Controls.Add(Me.Ctl_txt_from)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.dgrd_laboratorio)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.grp_laboratorio)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_laboratorio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratorio"
        Me.grp_laboratorio.ResumeLayout(False)
        Me.grp_laboratorio.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_laboratorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.Dts_hojaT1, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.MouseEnter, btn_Eliminar.MouseEnter, btn_Nuevo.MouseEnter, btn_Salir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.MouseLeave, btn_Eliminar.MouseLeave, btn_Nuevo.MouseLeave, btn_Salir.MouseLeave
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

    Dim opr_ciudad As New Cls_Ciudad()
    Dim opr_laboratorio As New Cls_Laboratorio()
    Dim byt_flag As Byte

    Private Sub frm_laboratorio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'llena el combo de la ciudad
        opr_ciudad.LlenarComboProvincia(cmb_Provincia)
        opr_ciudad.LlenarComboCiudad(cmb_Ciudad, CInt(Mid(cmb_Provincia.text, 101, 110)))
        grp_laboratorio.Enabled = False
        'mando a llemar el grid con los datos de el laboratorio
        opr_laboratorio.LlenarGridLab(dgrd_laboratorio)
        Ctl_txt_NomLab.txt_padre.MaxLength = 50
        Ctl_txt_EmailLab.txt_padre.MaxLength = 50
        Ctl_txt_WebLab.txt_padre.MaxLength = 50
        btn_aceptar.Enabled = False
        btn_Eliminar.Enabled = False
    End Sub
    'funcion para asignar vacio a  los campos 
    Private Function limpiarCampos()
        Ctl_txt_NomLab.texto_Asigna("")
        Ctl_txt_RucLab.texto_Asigna("")
        txt_Dir.Text = ""
        txt_TelfLab.Text = ""
        txt_FaxLab.Text = ""
        Ctl_txt_EmailLab.texto_Asigna("")
        Ctl_txt_WebLab.texto_Asigna("")
        txt_Especialidad.Text = ""
        txt_Representante.Text = ""
        cmb_tipo.SelectedIndex = 0
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'cierra el formulario
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        'para ingresar un nuevo laboratorio
        Call limpiarCampos()
        byt_flag = 0
        grp_laboratorio.Enabled = True
        btn_Nuevo.Enabled = False
        btn_aceptar.Enabled = True
        btn_Eliminar.Enabled = False
        Ctl_txt_NomLab.Focus()
    End Sub

    Private Sub dgrd_laboratorio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_laboratorio.CurrentCellChanged
        'cuando selecciono una fila del grid los datos se actualizan automanticamente en lo cuadros de texto de la parte superior
        btn_Nuevo.Enabled = True
        btn_aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_laboratorio.Enabled = True
        Ctl_txt_NomLab.texto_Asigna(dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 1))
        Ctl_txt_RucLab.texto_Asigna(dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 2))
        txt_Dir.Text = dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 3)
        txt_TelfLab.Text = dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 4)
        txt_FaxLab.Text = dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 5)
        Ctl_txt_EmailLab.texto_Asigna(dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 6))
        Ctl_txt_WebLab.texto_Asigna(dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 7))
        txt_Especialidad.Text = dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 8)
        txt_Representante.Text = dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 9)
        cmb_Ciudad.Text = dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 10).ToString.PadRight(50) & dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 12).ToString.PadRight(10)
        cmb_tipo.Text = dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 11)
        byt_flag = 1
        Dim dgCell As DataGridCell
        'selecciono toda la fila del grid
        dgCell.ColumnNumber = 0
        dgCell.RowNumber = dgrd_laboratorio.CurrentCell.RowNumber
        dgrd_laboratorio.CurrentCell = dgCell
        dgrd_laboratorio.Select(dgrd_laboratorio.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        'mando guardar los datos
        'verifico que le nombre no sea vacio
        If (Ctl_txt_NomLab.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre del Laboratorio", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_NomLab.Focus()
            Exit Sub
        End If
        'verifoc que le RUC no sea vacio
        If (Ctl_txt_RucLab.texto_Recupera = "") Then
            MsgBox("Ingrese el R.U.C. del Laboratorio", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_RucLab.Focus()
            Exit Sub
        End If
        'verifoc que la direccion no sea vacia
        If (txt_Dir.Text = "") Then
            MsgBox("Ingrese la direcci�n del Laboratorio", MsgBoxStyle.Information, "ANALISYS")
            txt_Dir.Focus()
            Exit Sub
        End If
        'verifoco que no exista un laboratorio con ese nombre
        If (opr_laboratorio.BuscarLab(Ctl_txt_NomLab.texto_Recupera)) = True And byt_flag = 0 Then
            MsgBox("Ya existe un laboratorio con ese nombre", MsgBoxStyle.Information, "ANALISYS")
            txt_Dir.Focus()
            Exit Sub
        End If
        'verifoc que el laboratorio  tenga telefono
        If (txt_TelfLab.Text = "") Then
            MsgBox("Ingrese el tel�fono del Laboratorio", MsgBoxStyle.Information, "ANALISYS")
            txt_TelfLab.Focus()
            Exit Sub
        End If
        'si la variable byt_flag es 0 sigfica que es un nuevo laboratorio
        If byt_flag = 0 Then
            opr_laboratorio.GuardarLab(opr_laboratorio.LeerMaxLab + 1, cmb_tipo.Text, Ctl_txt_NomLab.texto_Recupera, Ctl_txt_RucLab.texto_Recupera, txt_Dir.Text, txt_TelfLab.Text, txt_FaxLab.Text, Ctl_txt_EmailLab.texto_Recupera, Ctl_txt_WebLab.texto_Recupera, txt_Especialidad.Text, txt_Representante.Text, Trim(cmb_Ciudad.Text.Substring(50, 10)))
        Else
            'mando a actualizar el laboratorio
            opr_laboratorio.ActualizarLab(dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 0), cmb_tipo.Text, Ctl_txt_NomLab.texto_Recupera, Ctl_txt_RucLab.texto_Recupera, txt_Dir.Text.ToString, txt_TelfLab.Text, txt_FaxLab.Text, Ctl_txt_EmailLab.texto_Recupera, Ctl_txt_WebLab.texto_Recupera, txt_Especialidad.Text.ToString, txt_Representante.Text.ToString, Trim(cmb_Ciudad.Text.Substring(50, 10)))
        End If
        Call limpiarCampos()
        btn_aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_laboratorio.Enabled = False
        'mando a refrescar le grid
        opr_laboratorio.LlenarGridLab(dgrd_laboratorio)
    End Sub
    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'elimino un laboratorio si la respuesta es afirmativa al messagebox
        If MsgBox("Desea eliminar el Laboratorio?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            opr_laboratorio.EliminaLab(dgrd_laboratorio.Item(dgrd_laboratorio.CurrentCell.RowNumber, 0))
            Call limpiarCampos()
            btn_aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            btn_Nuevo.Enabled = True
            grp_laboratorio.Enabled = False
            'actualizo el grid
            opr_laboratorio.LlenarGridLab(dgrd_laboratorio)
        End If
    End Sub
    Private Sub txt_Dir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Dir.KeyDown, Ctl_txt_NomLab.KeyDown, Ctl_txt_RucLab.KeyDown, txt_TelfLab.KeyDown, txt_FaxLab.KeyDown, Ctl_txt_RucLab.KeyDown, Ctl_txt_EmailLab.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub btn_buscalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscalogo.Click
        ' Displays an OpenFileDialog so the user can select a Cursor.
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "jpeg, png Files|*.jpg, *.png"
        openFileDialog1.Title = "Selecione la imagen para el logotipo"

        ' Show the Dialog.
        ' If the user clicked OK in the dialog and 
        ' a .CUR file was selected, open it.
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox2.ImageLocation = openFileDialog1.FileName
            'Me.Cursor = New Cursor(openFileDialog1.OpenFile())
        End If



    End Sub

    Private Sub btn_GuardaEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardaEmail.Click
        Dim opr_email As Cls_NetMail()

    End Sub
End Class

