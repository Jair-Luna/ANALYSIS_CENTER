
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
'IMPRESION DE VALIDADO
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient




Public Class frm_ValidacionRes

    Inherits System.Windows.Forms.Form
    Dim area As Integer = Nothing
    Dim dts_lista As New DataSet
    'Dim CadenaFiltro As String = Nothing
    Dim aareas As String = Nothing
    Friend WithEvents Pic_GrabaSecc As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_nota_exa As System.Windows.Forms.Label



    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Paciente As System.Windows.Forms.Button
    Friend WithEvents btn_Plantilla As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents dgtc_Plantilla As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_LabId As System.Windows.Forms.Label
    Friend WithEvents btn_historico As System.Windows.Forms.Button

    Dim arregloAreas As String()
    Dim Prioridad As String = Nothing

    Dim fechaIni As String = ""
    Dim fechaFin As String = ""
    Dim areas As String = Nothing
    Public filtroOrdenes As String = Nothing
    Public LabOcup As Byte
    Public ConvenioSecuencia As String = Nothing
    Friend WithEvents dgtc_TesId As System.Windows.Forms.DataGridTextBoxColumn

    Dim i As Integer = Nothing
    Friend WithEvents btn_ImprTodo As System.Windows.Forms.Button
    Friend WithEvents rbtn_PorValidar As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Imcompletos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Todos As System.Windows.Forms.RadioButton
    Private WithEvents cmb_resultado As New ComboBox()
    Friend WithEvents btn_NotaExa As System.Windows.Forms.Button
    Friend WithEvents lbl_NotaSecc As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreConvenio As System.Windows.Forms.Label

    Public op_filtro As String
    Friend WithEvents dgtc_notaSECC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Servicio As System.Windows.Forms.Label
    Friend WithEvents lbl_edadPac As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DiffimageHSMS As System.Windows.Forms.PictureBox
    Friend WithEvents WBCImage As System.Windows.Forms.PictureBox
    Friend WithEvents DiffimageLSHS As System.Windows.Forms.PictureBox
    Friend WithEvents RBCimage As System.Windows.Forms.PictureBox
    Friend WithEvents DiffimageBASO As System.Windows.Forms.PictureBox
    Friend WithEvents DiffimageLSMS As System.Windows.Forms.PictureBox
    Friend WithEvents PLTimage As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_hoja As System.Windows.Forms.Button
    Friend WithEvents Pic_QR As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_Convenio As System.Windows.Forms.Label
    Dim valores As String = Nothing






#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Me.DoubleBuffered = True ' Para mejorar el rendimiento de dibujo
        'Me.Size = New Size(400, 400)


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
    Friend WithEvents grp_seleccion As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_OBS As System.Windows.Forms.Label
    Friend WithEvents lbl_pedidoD As System.Windows.Forms.Label
    Friend WithEvents lbl_pacienteD As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaD As System.Windows.Forms.Label
    Friend WithEvents lbl_doctorD As System.Windows.Forms.Label
    Friend WithEvents lbl_FecNacD As System.Windows.Forms.Label
    Friend WithEvents lbl_fecNac As System.Windows.Forms.Label
    Friend WithEvents dgrd_resPedido As System.Windows.Forms.DataGrid
    Friend WithEvents txt_ResMan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_notaArea As System.Windows.Forms.TextBox
    Friend WithEvents btn_Histograma As System.Windows.Forms.Button
    Friend WithEvents pan_hist As System.Windows.Forms.Panel
    Friend WithEvents pic_wbc As System.Windows.Forms.PictureBox
    Friend WithEvents pic_rbc As System.Windows.Forms.PictureBox
    Friend WithEvents pic_plt As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents lbl_turno As System.Windows.Forms.Label
    Friend WithEvents btn_Leer As System.Windows.Forms.Button
    Friend WithEvents lbl_ordenMIS As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_adjuntapdf As System.Windows.Forms.Button
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
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_File As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_Labo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_RemId As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lst_remitidos As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lst_pedidos As System.Windows.Forms.ListBox
    Friend WithEvents lbl_pac_idD As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ValidacionRes))
        Me.grp_seleccion = New System.Windows.Forms.GroupBox
        Me.lbl_Convenio = New System.Windows.Forms.Label
        Me.Pic_QR = New System.Windows.Forms.PictureBox
        Me.lbl_edadPac = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_Servicio = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.lbl_pac_idD = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_turno = New System.Windows.Forms.Label
        Me.lbl_edad = New System.Windows.Forms.Label
        Me.lbl_FecNacD = New System.Windows.Forms.Label
        Me.lbl_fecNac = New System.Windows.Forms.Label
        Me.lbl_doctorD = New System.Windows.Forms.Label
        Me.lbl_fechaD = New System.Windows.Forms.Label
        Me.lbl_pacienteD = New System.Windows.Forms.Label
        Me.lbl_OBS = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.lbl_pedidoD = New System.Windows.Forms.Label
        Me.lbl_pedido = New System.Windows.Forms.Label
        Me.lbl_ordenMIS = New System.Windows.Forms.Label
        Me.btn_Histograma = New System.Windows.Forms.Button
        Me.dgrd_resPedido = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgtc_notaSECC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_File = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_Labo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_RemId = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_Plantilla = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_TesId = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.txt_ResMan = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_notaArea = New System.Windows.Forms.TextBox
        Me.pan_hist = New System.Windows.Forms.Panel
        Me.pic_plt = New System.Windows.Forms.PictureBox
        Me.pic_rbc = New System.Windows.Forms.PictureBox
        Me.pic_wbc = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Pic_GrabaSecc = New System.Windows.Forms.PictureBox
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_Leer = New System.Windows.Forms.Button
        Me.btn_adjuntapdf = New System.Windows.Forms.Button
        Me.lst_remitidos = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lst_pedidos = New System.Windows.Forms.ListBox
        Me.lbl_nota_exa = New System.Windows.Forms.Label
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.btn_Paciente = New System.Windows.Forms.Button
        Me.btn_Plantilla = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.lbl_LabId = New System.Windows.Forms.Label
        Me.btn_historico = New System.Windows.Forms.Button
        Me.btn_ImprTodo = New System.Windows.Forms.Button
        Me.rbtn_PorValidar = New System.Windows.Forms.RadioButton
        Me.rbtn_Imcompletos = New System.Windows.Forms.RadioButton
        Me.rbtn_Todos = New System.Windows.Forms.RadioButton
        Me.btn_NotaExa = New System.Windows.Forms.Button
        Me.lbl_NotaSecc = New System.Windows.Forms.Label
        Me.lbl_NombreConvenio = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DiffimageHSMS = New System.Windows.Forms.PictureBox
        Me.WBCImage = New System.Windows.Forms.PictureBox
        Me.DiffimageLSHS = New System.Windows.Forms.PictureBox
        Me.RBCimage = New System.Windows.Forms.PictureBox
        Me.DiffimageBASO = New System.Windows.Forms.PictureBox
        Me.DiffimageLSMS = New System.Windows.Forms.PictureBox
        Me.PLTimage = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_hoja = New System.Windows.Forms.Button
        Me.grp_seleccion.SuspendLayout()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_resPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_hist.SuspendLayout()
        CType(Me.pic_plt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_rbc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_wbc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_GrabaSecc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DiffimageHSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WBCImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiffimageLSHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBCimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiffimageBASO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiffimageLSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_seleccion
        '
        Me.grp_seleccion.BackColor = System.Drawing.Color.Transparent
        Me.grp_seleccion.Controls.Add(Me.lbl_Convenio)
        Me.grp_seleccion.Controls.Add(Me.Pic_QR)
        Me.grp_seleccion.Controls.Add(Me.lbl_edadPac)
        Me.grp_seleccion.Controls.Add(Me.Label4)
        Me.grp_seleccion.Controls.Add(Me.lbl_Servicio)
        Me.grp_seleccion.Controls.Add(Me.PictureBox6)
        Me.grp_seleccion.Controls.Add(Me.lbl_pac_idD)
        Me.grp_seleccion.Controls.Add(Me.Label7)
        Me.grp_seleccion.Controls.Add(Me.lbl_turno)
        Me.grp_seleccion.Controls.Add(Me.lbl_edad)
        Me.grp_seleccion.Controls.Add(Me.lbl_FecNacD)
        Me.grp_seleccion.Controls.Add(Me.lbl_fecNac)
        Me.grp_seleccion.Controls.Add(Me.lbl_doctorD)
        Me.grp_seleccion.Controls.Add(Me.lbl_fechaD)
        Me.grp_seleccion.Controls.Add(Me.lbl_pacienteD)
        Me.grp_seleccion.Controls.Add(Me.lbl_OBS)
        Me.grp_seleccion.Controls.Add(Me.Label2)
        Me.grp_seleccion.Controls.Add(Me.lbl_fecha)
        Me.grp_seleccion.Controls.Add(Me.lbl_pedidoD)
        Me.grp_seleccion.Controls.Add(Me.lbl_pedido)
        Me.grp_seleccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_seleccion.ForeColor = System.Drawing.Color.Navy
        Me.grp_seleccion.Location = New System.Drawing.Point(9, 79)
        Me.grp_seleccion.Name = "grp_seleccion"
        Me.grp_seleccion.Size = New System.Drawing.Size(748, 106)
        Me.grp_seleccion.TabIndex = 0
        Me.grp_seleccion.TabStop = False
        '
        'lbl_Convenio
        '
        Me.lbl_Convenio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Convenio.ForeColor = System.Drawing.Color.White
        Me.lbl_Convenio.Location = New System.Drawing.Point(556, 81)
        Me.lbl_Convenio.Name = "lbl_Convenio"
        Me.lbl_Convenio.Size = New System.Drawing.Size(184, 18)
        Me.lbl_Convenio.TabIndex = 193
        Me.lbl_Convenio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Pic_QR
        '
        Me.Pic_QR.BackColor = System.Drawing.Color.Transparent
        Me.Pic_QR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_QR.Location = New System.Drawing.Point(676, 14)
        Me.Pic_QR.Name = "Pic_QR"
        Me.Pic_QR.Size = New System.Drawing.Size(65, 64)
        Me.Pic_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_QR.TabIndex = 192
        Me.Pic_QR.TabStop = False
        Me.Pic_QR.Visible = False
        '
        'lbl_edadPac
        '
        Me.lbl_edadPac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edadPac.ForeColor = System.Drawing.Color.White
        Me.lbl_edadPac.Location = New System.Drawing.Point(393, 32)
        Me.lbl_edadPac.Name = "lbl_edadPac"
        Me.lbl_edadPac.Size = New System.Drawing.Size(82, 14)
        Me.lbl_edadPac.TabIndex = 48
        Me.lbl_edadPac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(253, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Servicio:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Servicio
        '
        Me.lbl_Servicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Servicio.ForeColor = System.Drawing.Color.White
        Me.lbl_Servicio.Location = New System.Drawing.Point(311, 82)
        Me.lbl_Servicio.Name = "lbl_Servicio"
        Me.lbl_Servicio.Size = New System.Drawing.Size(219, 17)
        Me.lbl_Servicio.TabIndex = 46
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(58, 62)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 41
        Me.PictureBox6.TabStop = False
        '
        'lbl_pac_idD
        '
        Me.lbl_pac_idD.Location = New System.Drawing.Point(392, 31)
        Me.lbl_pac_idD.Name = "lbl_pac_idD"
        Me.lbl_pac_idD.Size = New System.Drawing.Size(100, 12)
        Me.lbl_pac_idD.TabIndex = 22
        Me.lbl_pac_idD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(230, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Observacion:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_turno
        '
        Me.lbl_turno.BackColor = System.Drawing.Color.White
        Me.lbl_turno.Font = New System.Drawing.Font("C39HrP24DhTt", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_turno.ForeColor = System.Drawing.Color.Black
        Me.lbl_turno.Location = New System.Drawing.Point(74, 18)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(146, 75)
        Me.lbl_turno.TabIndex = 17
        Me.lbl_turno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_edad
        '
        Me.lbl_edad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.ForeColor = System.Drawing.Color.Navy
        Me.lbl_edad.Location = New System.Drawing.Point(424, 30)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(106, 14)
        Me.lbl_edad.TabIndex = 15
        Me.lbl_edad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_FecNacD
        '
        Me.lbl_FecNacD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FecNacD.ForeColor = System.Drawing.Color.White
        Me.lbl_FecNacD.Location = New System.Drawing.Point(313, 30)
        Me.lbl_FecNacD.Name = "lbl_FecNacD"
        Me.lbl_FecNacD.Size = New System.Drawing.Size(82, 14)
        Me.lbl_FecNacD.TabIndex = 11
        Me.lbl_FecNacD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_fecNac
        '
        Me.lbl_fecNac.AutoSize = True
        Me.lbl_fecNac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecNac.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecNac.Location = New System.Drawing.Point(241, 30)
        Me.lbl_fecNac.Name = "lbl_fecNac"
        Me.lbl_fecNac.Size = New System.Drawing.Size(69, 13)
        Me.lbl_fecNac.TabIndex = 10
        Me.lbl_fecNac.Text = "Fecha Nac.:"
        Me.lbl_fecNac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_doctorD
        '
        Me.lbl_doctorD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doctorD.ForeColor = System.Drawing.Color.Navy
        Me.lbl_doctorD.Location = New System.Drawing.Point(412, 79)
        Me.lbl_doctorD.Name = "lbl_doctorD"
        Me.lbl_doctorD.Size = New System.Drawing.Size(194, 14)
        Me.lbl_doctorD.TabIndex = 9
        Me.lbl_doctorD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_doctorD.Visible = False
        '
        'lbl_fechaD
        '
        Me.lbl_fechaD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaD.ForeColor = System.Drawing.Color.White
        Me.lbl_fechaD.Location = New System.Drawing.Point(313, 49)
        Me.lbl_fechaD.Name = "lbl_fechaD"
        Me.lbl_fechaD.Size = New System.Drawing.Size(98, 14)
        Me.lbl_fechaD.TabIndex = 8
        Me.lbl_fechaD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pacienteD
        '
        Me.lbl_pacienteD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pacienteD.ForeColor = System.Drawing.Color.White
        Me.lbl_pacienteD.Location = New System.Drawing.Point(313, 14)
        Me.lbl_pacienteD.Name = "lbl_pacienteD"
        Me.lbl_pacienteD.Size = New System.Drawing.Size(296, 12)
        Me.lbl_pacienteD.TabIndex = 7
        Me.lbl_pacienteD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_OBS
        '
        Me.lbl_OBS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OBS.ForeColor = System.Drawing.Color.White
        Me.lbl_OBS.Location = New System.Drawing.Point(313, 67)
        Me.lbl_OBS.Name = "lbl_OBS"
        Me.lbl_OBS.Size = New System.Drawing.Size(289, 15)
        Me.lbl_OBS.TabIndex = 5
        Me.lbl_OBS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(251, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Paciente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecha.Location = New System.Drawing.Point(226, 49)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(84, 13)
        Me.lbl_fecha.TabIndex = 3
        Me.lbl_fecha.Text = "Fecha Pedido:"
        Me.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_pedidoD
        '
        Me.lbl_pedidoD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedidoD.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pedidoD.Location = New System.Drawing.Point(400, 132)
        Me.lbl_pedidoD.Name = "lbl_pedidoD"
        Me.lbl_pedidoD.Size = New System.Drawing.Size(68, 14)
        Me.lbl_pedidoD.TabIndex = 6
        Me.lbl_pedidoD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_pedidoD.Visible = False
        '
        'lbl_pedido
        '
        Me.lbl_pedido.AutoSize = True
        Me.lbl_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.ForeColor = System.Drawing.Color.Black
        Me.lbl_pedido.Location = New System.Drawing.Point(344, 112)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(48, 13)
        Me.lbl_pedido.TabIndex = 1
        Me.lbl_pedido.Text = "Pedido:"
        Me.lbl_pedido.Visible = False
        '
        'lbl_ordenMIS
        '
        Me.lbl_ordenMIS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ordenMIS.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ordenMIS.Location = New System.Drawing.Point(594, 136)
        Me.lbl_ordenMIS.Name = "lbl_ordenMIS"
        Me.lbl_ordenMIS.Size = New System.Drawing.Size(92, 14)
        Me.lbl_ordenMIS.TabIndex = 21
        Me.lbl_ordenMIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Histograma
        '
        Me.btn_Histograma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Histograma.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Histograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Histograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Histograma.ForeColor = System.Drawing.Color.Black
        Me.btn_Histograma.Image = CType(resources.GetObject("btn_Histograma.Image"), System.Drawing.Image)
        Me.btn_Histograma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Histograma.Location = New System.Drawing.Point(908, 34)
        Me.btn_Histograma.Name = "btn_Histograma"
        Me.btn_Histograma.Size = New System.Drawing.Size(80, 24)
        Me.btn_Histograma.TabIndex = 2
        Me.btn_Histograma.Text = "&Histogr."
        Me.btn_Histograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Histograma.Visible = False
        '
        'dgrd_resPedido
        '
        Me.dgrd_resPedido.AllowNavigation = False
        Me.dgrd_resPedido.AllowSorting = False
        Me.dgrd_resPedido.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_resPedido.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_resPedido.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_resPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_resPedido.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_resPedido.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_resPedido.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_resPedido.CaptionText = "RESULTADOS DISPONIBLES"
        Me.dgrd_resPedido.DataMember = ""
        Me.dgrd_resPedido.FlatMode = True
        Me.dgrd_resPedido.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_resPedido.ForeColor = System.Drawing.Color.Black
        Me.dgrd_resPedido.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_resPedido.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_resPedido.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_resPedido.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_resPedido.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_resPedido.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_resPedido.Location = New System.Drawing.Point(9, 189)
        Me.dgrd_resPedido.Name = "dgrd_resPedido"
        Me.dgrd_resPedido.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_resPedido.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_resPedido.RowHeaderWidth = 20
        Me.dgrd_resPedido.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_resPedido.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_resPedido.Size = New System.Drawing.Size(977, 344)
        Me.dgrd_resPedido.TabIndex = 1
        Me.dgrd_resPedido.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_resPedido
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgtc_notaSECC, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.dgtc_File, Me.dgtc_Labo, Me.dgtc_RemId, Me.dgtc_Plantilla, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn17, Me.dgtc_TesId, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'dgtc_notaSECC
        '
        Me.dgtc_notaSECC.Format = ""
        Me.dgtc_notaSECC.FormatInfo = Nothing
        Me.dgtc_notaSECC.HeaderText = "AREA"
        Me.dgtc_notaSECC.MappingName = "SECC"
        Me.dgtc_notaSECC.NullText = ""
        Me.dgtc_notaSECC.ReadOnly = True
        Me.dgtc_notaSECC.Width = 150
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "# PEDIDO"
        Me.DataGridTextBoxColumn1.MappingName = "ped_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "FECHA"
        Me.DataGridTextBoxColumn2.MappingName = "prc_fecha"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 63
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "HORA"
        Me.DataGridTextBoxColumn3.MappingName = "prc_hora"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 35
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "ABREVIATURA"
        Me.DataGridTextBoxColumn4.MappingName = "teq_abrv_fija"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "TEST"
        Me.DataGridTextBoxColumn5.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "RESULTADO"
        Me.DataGridTextBoxColumn6.MappingName = "prc_resul"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "HISTORICO"
        Me.DataGridTextBoxColumn16.MappingName = "TES_CALC"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "HISTORICO"
        Me.DataGridTextBoxColumn10.MappingName = "prc_resulm"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "UNID"
        Me.DataGridTextBoxColumn7.MappingName = "uni_nomenclatura"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 60
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "RANG NORMAL"
        Me.DataGridTextBoxColumn8.MappingName = "rango_normal"
        Me.DataGridTextBoxColumn8.NullText = "No Disponible"
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 120
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "NOTA EXAM"
        Me.DataGridTextBoxColumn9.MappingName = "prc_error"
        Me.DataGridTextBoxColumn9.NullText = " "
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "ERROR"
        Me.DataGridTextBoxColumn11.MappingName = "ERR_DESC"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn12.MappingName = "ORDEN"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "MUESTRA"
        Me.DataGridTextBoxColumn13.MappingName = "MUESTRA"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn14.MappingName = "ESTADO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 10
        '
        'dgtc_File
        '
        Me.dgtc_File.Format = ""
        Me.dgtc_File.FormatInfo = Nothing
        Me.dgtc_File.HeaderText = "ARCHIVO"
        Me.dgtc_File.MappingName = "ARCHIVO"
        Me.dgtc_File.ReadOnly = True
        Me.dgtc_File.Width = 0
        '
        'dgtc_Labo
        '
        Me.dgtc_Labo.Format = ""
        Me.dgtc_Labo.FormatInfo = Nothing
        Me.dgtc_Labo.HeaderText = "LABORATORIO"
        Me.dgtc_Labo.MappingName = "LABORATORIO"
        Me.dgtc_Labo.NullText = ""
        Me.dgtc_Labo.ReadOnly = True
        Me.dgtc_Labo.Width = 0
        '
        'dgtc_RemId
        '
        Me.dgtc_RemId.Format = ""
        Me.dgtc_RemId.FormatInfo = Nothing
        Me.dgtc_RemId.HeaderText = "REM_ID"
        Me.dgtc_RemId.MappingName = "REM_ID"
        Me.dgtc_RemId.NullText = ""
        Me.dgtc_RemId.ReadOnly = True
        Me.dgtc_RemId.Width = 0
        '
        'dgtc_Plantilla
        '
        Me.dgtc_Plantilla.Format = ""
        Me.dgtc_Plantilla.FormatInfo = Nothing
        Me.dgtc_Plantilla.MappingName = "RES_ID"
        Me.dgtc_Plantilla.ReadOnly = True
        Me.dgtc_Plantilla.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "AB"
        Me.DataGridTextBoxColumn15.MappingName = "TES_AB"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "ICONO"
        Me.DataGridTextBoxColumn17.ReadOnly = True
        Me.DataGridTextBoxColumn17.Width = 40
        '
        'dgtc_TesId
        '
        Me.dgtc_TesId.Format = ""
        Me.dgtc_TesId.FormatInfo = Nothing
        Me.dgtc_TesId.MappingName = "TES_ID"
        Me.dgtc_TesId.NullText = ""
        Me.dgtc_TesId.ReadOnly = True
        Me.dgtc_TesId.Width = 0
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "ARE_ID"
        Me.DataGridTextBoxColumn18.MappingName = "are_id"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.ReadOnly = True
        Me.DataGridTextBoxColumn18.Width = 0
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "REPETICION"
        Me.DataGridTextBoxColumn19.MappingName = "PRC_REPETICION"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 75
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(724, 446)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "&Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        Me.btn_Salir.Visible = False
        '
        'txt_ResMan
        '
        Me.txt_ResMan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_ResMan.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ResMan.Location = New System.Drawing.Point(194, 216)
        Me.txt_ResMan.MaxLength = 5000
        Me.txt_ResMan.Multiline = True
        Me.txt_ResMan.Name = "txt_ResMan"
        Me.txt_ResMan.ReadOnly = True
        Me.txt_ResMan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ResMan.Size = New System.Drawing.Size(413, 277)
        Me.txt_ResMan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(19, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = " RESULTADOS MANUALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(403, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 23)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = " NOTAS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_notaArea
        '
        Me.txt_notaArea.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_notaArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notaArea.Location = New System.Drawing.Point(766, 115)
        Me.txt_notaArea.MaxLength = 5000
        Me.txt_notaArea.Multiline = True
        Me.txt_notaArea.Name = "txt_notaArea"
        Me.txt_notaArea.ReadOnly = True
        Me.txt_notaArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notaArea.Size = New System.Drawing.Size(222, 65)
        Me.txt_notaArea.TabIndex = 1
        '
        'pan_hist
        '
        Me.pan_hist.Controls.Add(Me.pic_plt)
        Me.pan_hist.Controls.Add(Me.pic_rbc)
        Me.pan_hist.Controls.Add(Me.pic_wbc)
        Me.pan_hist.Location = New System.Drawing.Point(64, 326)
        Me.pan_hist.Name = "pan_hist"
        Me.pan_hist.Size = New System.Drawing.Size(423, 144)
        Me.pan_hist.TabIndex = 49
        '
        'pic_plt
        '
        Me.pic_plt.BackColor = System.Drawing.Color.White
        Me.pic_plt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_plt.Location = New System.Drawing.Point(282, 3)
        Me.pic_plt.Name = "pic_plt"
        Me.pic_plt.Size = New System.Drawing.Size(138, 134)
        Me.pic_plt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_plt.TabIndex = 2
        Me.pic_plt.TabStop = False
        Me.pic_plt.Visible = False
        '
        'pic_rbc
        '
        Me.pic_rbc.BackColor = System.Drawing.Color.White
        Me.pic_rbc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_rbc.Location = New System.Drawing.Point(142, 3)
        Me.pic_rbc.Name = "pic_rbc"
        Me.pic_rbc.Size = New System.Drawing.Size(138, 134)
        Me.pic_rbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_rbc.TabIndex = 3
        Me.pic_rbc.TabStop = False
        Me.pic_rbc.Visible = False
        '
        'pic_wbc
        '
        Me.pic_wbc.BackColor = System.Drawing.Color.White
        Me.pic_wbc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_wbc.Location = New System.Drawing.Point(7, 3)
        Me.pic_wbc.Name = "pic_wbc"
        Me.pic_wbc.Size = New System.Drawing.Size(138, 134)
        Me.pic_wbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_wbc.TabIndex = 4
        Me.pic_wbc.TabStop = False
        Me.pic_wbc.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1021, 202)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 100
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "EDITAR")
        Me.PictureBox3.Visible = False
        '
        'Pic_GrabaSecc
        '
        Me.Pic_GrabaSecc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_GrabaSecc.Image = CType(resources.GetObject("Pic_GrabaSecc.Image"), System.Drawing.Image)
        Me.Pic_GrabaSecc.Location = New System.Drawing.Point(766, 87)
        Me.Pic_GrabaSecc.Name = "Pic_GrabaSecc"
        Me.Pic_GrabaSecc.Size = New System.Drawing.Size(28, 25)
        Me.Pic_GrabaSecc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_GrabaSecc.TabIndex = 162
        Me.Pic_GrabaSecc.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Pic_GrabaSecc, "GRABAR NOTA EXAMEN")
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(1300, 25)
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
        Me.lbl_textform.Size = New System.Drawing.Size(182, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "VALIDAR RESULTADOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Leer
        '
        Me.btn_Leer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Leer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Leer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Leer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Leer.ForeColor = System.Drawing.Color.Black
        Me.btn_Leer.Image = CType(resources.GetObject("btn_Leer.Image"), System.Drawing.Image)
        Me.btn_Leer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Leer.Location = New System.Drawing.Point(104, 628)
        Me.btn_Leer.Name = "btn_Leer"
        Me.btn_Leer.Size = New System.Drawing.Size(80, 24)
        Me.btn_Leer.TabIndex = 94
        Me.btn_Leer.Text = "&Leer"
        Me.btn_Leer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Leer.Visible = False
        '
        'btn_adjuntapdf
        '
        Me.btn_adjuntapdf.BackColor = System.Drawing.SystemColors.Control
        Me.btn_adjuntapdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adjuntapdf.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_adjuntapdf.Enabled = False
        Me.btn_adjuntapdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adjuntapdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adjuntapdf.ForeColor = System.Drawing.Color.Black
        Me.btn_adjuntapdf.Image = CType(resources.GetObject("btn_adjuntapdf.Image"), System.Drawing.Image)
        Me.btn_adjuntapdf.Location = New System.Drawing.Point(482, 326)
        Me.btn_adjuntapdf.Name = "btn_adjuntapdf"
        Me.btn_adjuntapdf.Size = New System.Drawing.Size(67, 59)
        Me.btn_adjuntapdf.TabIndex = 96
        Me.btn_adjuntapdf.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_adjuntapdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_adjuntapdf.UseVisualStyleBackColor = False
        Me.btn_adjuntapdf.Visible = False
        '
        'lst_remitidos
        '
        Me.lst_remitidos.FormattingEnabled = True
        Me.lst_remitidos.ItemHeight = 11
        Me.lst_remitidos.Location = New System.Drawing.Point(992, 446)
        Me.lst_remitidos.Name = "lst_remitidos"
        Me.lst_remitidos.Size = New System.Drawing.Size(299, 59)
        Me.lst_remitidos.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(199, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(412, 23)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = " RESULTADOS MANUALES"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lst_pedidos
        '
        Me.lst_pedidos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_pedidos.FormattingEnabled = True
        Me.lst_pedidos.ItemHeight = 14
        Me.lst_pedidos.Location = New System.Drawing.Point(993, 109)
        Me.lst_pedidos.Name = "lst_pedidos"
        Me.lst_pedidos.Size = New System.Drawing.Size(300, 424)
        Me.lst_pedidos.TabIndex = 104
        '
        'lbl_nota_exa
        '
        Me.lbl_nota_exa.AutoSize = True
        Me.lbl_nota_exa.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nota_exa.ForeColor = System.Drawing.Color.Red
        Me.lbl_nota_exa.Location = New System.Drawing.Point(710, 479)
        Me.lbl_nota_exa.Name = "lbl_nota_exa"
        Me.lbl_nota_exa.Size = New System.Drawing.Size(94, 14)
        Me.lbl_nota_exa.TabIndex = 163
        Me.lbl_nota_exa.Text = "NOTA EXAMEN"
        Me.lbl_nota_exa.Visible = False
        '
        'btn_filtrar
        '
        Me.btn_filtrar.BackColor = System.Drawing.Color.White
        Me.btn_filtrar.Image = CType(resources.GetObject("btn_filtrar.Image"), System.Drawing.Image)
        Me.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filtrar.Location = New System.Drawing.Point(582, 34)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(95, 46)
        Me.btn_filtrar.TabIndex = 165
        Me.btn_filtrar.Text = "FILTRAR"
        Me.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filtrar.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.White
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cerrar.Location = New System.Drawing.Point(676, 34)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(97, 46)
        Me.btn_cerrar.TabIndex = 166
        Me.btn_cerrar.Text = "CERRAR"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'btn_Paciente
        '
        Me.btn_Paciente.BackColor = System.Drawing.Color.White
        Me.btn_Paciente.Image = CType(resources.GetObject("btn_Paciente.Image"), System.Drawing.Image)
        Me.btn_Paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Paciente.Location = New System.Drawing.Point(8, 34)
        Me.btn_Paciente.Name = "btn_Paciente"
        Me.btn_Paciente.Size = New System.Drawing.Size(90, 46)
        Me.btn_Paciente.TabIndex = 167
        Me.btn_Paciente.Text = "BUSCAR"
        Me.btn_Paciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Paciente.UseVisualStyleBackColor = False
        '
        'btn_Plantilla
        '
        Me.btn_Plantilla.BackColor = System.Drawing.Color.White
        Me.btn_Plantilla.Enabled = False
        Me.btn_Plantilla.Image = CType(resources.GetObject("btn_Plantilla.Image"), System.Drawing.Image)
        Me.btn_Plantilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Plantilla.Location = New System.Drawing.Point(192, 34)
        Me.btn_Plantilla.Name = "btn_Plantilla"
        Me.btn_Plantilla.Size = New System.Drawing.Size(94, 46)
        Me.btn_Plantilla.TabIndex = 169
        Me.btn_Plantilla.Text = "PLANTILLA"
        Me.btn_Plantilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Plantilla.UseVisualStyleBackColor = False
        '
        'btn_Validar
        '
        Me.btn_Validar.BackColor = System.Drawing.Color.White
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = CType(resources.GetObject("btn_Validar.Image"), System.Drawing.Image)
        Me.btn_Validar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Validar.Location = New System.Drawing.Point(98, 34)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(94, 46)
        Me.btn_Validar.TabIndex = 170
        Me.btn_Validar.Text = "VALIDAR"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.UseVisualStyleBackColor = False
        '
        'lbl_LabId
        '
        Me.lbl_LabId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LabId.ForeColor = System.Drawing.Color.Navy
        Me.lbl_LabId.Location = New System.Drawing.Point(740, 226)
        Me.lbl_LabId.Name = "lbl_LabId"
        Me.lbl_LabId.Size = New System.Drawing.Size(92, 14)
        Me.lbl_LabId.TabIndex = 171
        Me.lbl_LabId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_LabId.Visible = False
        '
        'btn_historico
        '
        Me.btn_historico.BackColor = System.Drawing.Color.White
        Me.btn_historico.Enabled = False
        Me.btn_historico.Image = CType(resources.GetObject("btn_historico.Image"), System.Drawing.Image)
        Me.btn_historico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_historico.Location = New System.Drawing.Point(386, 34)
        Me.btn_historico.Name = "btn_historico"
        Me.btn_historico.Size = New System.Drawing.Size(99, 46)
        Me.btn_historico.TabIndex = 172
        Me.btn_historico.Text = "HISTORICO"
        Me.btn_historico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_historico.UseVisualStyleBackColor = False
        '
        'btn_ImprTodo
        '
        Me.btn_ImprTodo.BackColor = System.Drawing.Color.White
        Me.btn_ImprTodo.Enabled = False
        Me.btn_ImprTodo.Image = CType(resources.GetObject("btn_ImprTodo.Image"), System.Drawing.Image)
        Me.btn_ImprTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ImprTodo.Location = New System.Drawing.Point(285, 34)
        Me.btn_ImprTodo.Name = "btn_ImprTodo"
        Me.btn_ImprTodo.Size = New System.Drawing.Size(102, 46)
        Me.btn_ImprTodo.TabIndex = 175
        Me.btn_ImprTodo.Text = "PRELIMINAR"
        Me.btn_ImprTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprTodo.UseVisualStyleBackColor = False
        '
        'rbtn_PorValidar
        '
        Me.rbtn_PorValidar.AutoSize = True
        Me.rbtn_PorValidar.Checked = True
        Me.rbtn_PorValidar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_PorValidar.ForeColor = System.Drawing.Color.White
        Me.rbtn_PorValidar.Location = New System.Drawing.Point(1049, 85)
        Me.rbtn_PorValidar.Name = "rbtn_PorValidar"
        Me.rbtn_PorValidar.Size = New System.Drawing.Size(76, 17)
        Me.rbtn_PorValidar.TabIndex = 176
        Me.rbtn_PorValidar.TabStop = True
        Me.rbtn_PorValidar.Text = "Por validar"
        Me.rbtn_PorValidar.UseVisualStyleBackColor = True
        '
        'rbtn_Imcompletos
        '
        Me.rbtn_Imcompletos.AutoSize = True
        Me.rbtn_Imcompletos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Imcompletos.ForeColor = System.Drawing.Color.White
        Me.rbtn_Imcompletos.Location = New System.Drawing.Point(1126, 85)
        Me.rbtn_Imcompletos.Name = "rbtn_Imcompletos"
        Me.rbtn_Imcompletos.Size = New System.Drawing.Size(83, 17)
        Me.rbtn_Imcompletos.TabIndex = 177
        Me.rbtn_Imcompletos.TabStop = True
        Me.rbtn_Imcompletos.Text = "Incompletos"
        Me.rbtn_Imcompletos.UseVisualStyleBackColor = True
        '
        'rbtn_Todos
        '
        Me.rbtn_Todos.AutoSize = True
        Me.rbtn_Todos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Todos.ForeColor = System.Drawing.Color.White
        Me.rbtn_Todos.Location = New System.Drawing.Point(990, 85)
        Me.rbtn_Todos.Name = "rbtn_Todos"
        Me.rbtn_Todos.Size = New System.Drawing.Size(54, 17)
        Me.rbtn_Todos.TabIndex = 178
        Me.rbtn_Todos.TabStop = True
        Me.rbtn_Todos.Text = "Todos"
        Me.rbtn_Todos.UseVisualStyleBackColor = True
        '
        'btn_NotaExa
        '
        Me.btn_NotaExa.BackColor = System.Drawing.Color.White
        Me.btn_NotaExa.Enabled = False
        Me.btn_NotaExa.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NotaExa.Image = CType(resources.GetObject("btn_NotaExa.Image"), System.Drawing.Image)
        Me.btn_NotaExa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NotaExa.Location = New System.Drawing.Point(484, 34)
        Me.btn_NotaExa.Name = "btn_NotaExa"
        Me.btn_NotaExa.Size = New System.Drawing.Size(98, 46)
        Me.btn_NotaExa.TabIndex = 168
        Me.btn_NotaExa.Text = "NOTA EXAM"
        Me.btn_NotaExa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NotaExa.UseVisualStyleBackColor = False
        '
        'lbl_NotaSecc
        '
        Me.lbl_NotaSecc.AutoSize = True
        Me.lbl_NotaSecc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NotaSecc.ForeColor = System.Drawing.Color.White
        Me.lbl_NotaSecc.Location = New System.Drawing.Point(803, 91)
        Me.lbl_NotaSecc.Name = "lbl_NotaSecc"
        Me.lbl_NotaSecc.Size = New System.Drawing.Size(65, 13)
        Me.lbl_NotaSecc.TabIndex = 161
        Me.lbl_NotaSecc.Text = "NOTA AREA"
        '
        'lbl_NombreConvenio
        '
        Me.lbl_NombreConvenio.AutoSize = True
        Me.lbl_NombreConvenio.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreConvenio.ForeColor = System.Drawing.Color.White
        Me.lbl_NombreConvenio.Location = New System.Drawing.Point(988, 55)
        Me.lbl_NombreConvenio.Name = "lbl_NombreConvenio"
        Me.lbl_NombreConvenio.Size = New System.Drawing.Size(132, 25)
        Me.lbl_NombreConvenio.TabIndex = 179
        Me.lbl_NombreConvenio.Text = "[CONVENIO]"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DiffimageHSMS)
        Me.Panel1.Controls.Add(Me.WBCImage)
        Me.Panel1.Controls.Add(Me.DiffimageLSHS)
        Me.Panel1.Controls.Add(Me.RBCimage)
        Me.Panel1.Controls.Add(Me.DiffimageBASO)
        Me.Panel1.Controls.Add(Me.DiffimageLSMS)
        Me.Panel1.Controls.Add(Me.PLTimage)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btn_hoja)
        Me.Panel1.Location = New System.Drawing.Point(51, 207)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 251)
        Me.Panel1.TabIndex = 189
        '
        'DiffimageHSMS
        '
        Me.DiffimageHSMS.BackColor = System.Drawing.Color.White
        Me.DiffimageHSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageHSMS.Location = New System.Drawing.Point(488, 127)
        Me.DiffimageHSMS.Name = "DiffimageHSMS"
        Me.DiffimageHSMS.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageHSMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageHSMS.TabIndex = 197
        Me.DiffimageHSMS.TabStop = False
        Me.DiffimageHSMS.Visible = False
        '
        'WBCImage
        '
        Me.WBCImage.BackColor = System.Drawing.Color.White
        Me.WBCImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WBCImage.Location = New System.Drawing.Point(631, 9)
        Me.WBCImage.Name = "WBCImage"
        Me.WBCImage.Size = New System.Drawing.Size(122, 109)
        Me.WBCImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WBCImage.TabIndex = 195
        Me.WBCImage.TabStop = False
        '
        'DiffimageLSHS
        '
        Me.DiffimageLSHS.BackColor = System.Drawing.Color.White
        Me.DiffimageLSHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageLSHS.Location = New System.Drawing.Point(488, 14)
        Me.DiffimageLSHS.Name = "DiffimageLSHS"
        Me.DiffimageLSHS.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageLSHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageLSHS.TabIndex = 196
        Me.DiffimageLSHS.TabStop = False
        Me.DiffimageLSHS.Visible = False
        '
        'RBCimage
        '
        Me.RBCimage.BackColor = System.Drawing.Color.White
        Me.RBCimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RBCimage.Location = New System.Drawing.Point(56, 127)
        Me.RBCimage.Name = "RBCimage"
        Me.RBCimage.Size = New System.Drawing.Size(122, 109)
        Me.RBCimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RBCimage.TabIndex = 194
        Me.RBCimage.TabStop = False
        '
        'DiffimageBASO
        '
        Me.DiffimageBASO.BackColor = System.Drawing.Color.White
        Me.DiffimageBASO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageBASO.Location = New System.Drawing.Point(203, 127)
        Me.DiffimageBASO.Name = "DiffimageBASO"
        Me.DiffimageBASO.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageBASO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageBASO.TabIndex = 193
        Me.DiffimageBASO.TabStop = False
        Me.DiffimageBASO.Visible = False
        '
        'DiffimageLSMS
        '
        Me.DiffimageLSMS.BackColor = System.Drawing.Color.White
        Me.DiffimageLSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiffimageLSMS.Location = New System.Drawing.Point(203, 14)
        Me.DiffimageLSMS.Name = "DiffimageLSMS"
        Me.DiffimageLSMS.Size = New System.Drawing.Size(122, 109)
        Me.DiffimageLSMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiffimageLSMS.TabIndex = 192
        Me.DiffimageLSMS.TabStop = False
        Me.DiffimageLSMS.Visible = False
        '
        'PLTimage
        '
        Me.PLTimage.BackColor = System.Drawing.Color.White
        Me.PLTimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLTimage.Location = New System.Drawing.Point(56, 14)
        Me.PLTimage.Name = "PLTimage"
        Me.PLTimage.Size = New System.Drawing.Size(122, 109)
        Me.PLTimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PLTimage.TabIndex = 191
        Me.PLTimage.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(604, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 41
        '
        'btn_hoja
        '
        Me.btn_hoja.BackColor = System.Drawing.Color.White
        Me.btn_hoja.Image = CType(resources.GetObject("btn_hoja.Image"), System.Drawing.Image)
        Me.btn_hoja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hoja.Location = New System.Drawing.Point(659, 45)
        Me.btn_hoja.Name = "btn_hoja"
        Me.btn_hoja.Size = New System.Drawing.Size(81, 46)
        Me.btn_hoja.TabIndex = 190
        Me.btn_hoja.Text = "HOJA"
        Me.btn_hoja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hoja.UseVisualStyleBackColor = False
        Me.btn_hoja.Visible = False
        '
        'frm_ValidacionRes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(4, 11)
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(1300, 550)
        Me.Controls.Add(Me.dgrd_resPedido)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pic_GrabaSecc)
        Me.Controls.Add(Me.lbl_NombreConvenio)
        Me.Controls.Add(Me.rbtn_Todos)
        Me.Controls.Add(Me.rbtn_Imcompletos)
        Me.Controls.Add(Me.rbtn_PorValidar)
        Me.Controls.Add(Me.btn_ImprTodo)
        Me.Controls.Add(Me.btn_historico)
        Me.Controls.Add(Me.txt_notaArea)
        Me.Controls.Add(Me.btn_Validar)
        Me.Controls.Add(Me.btn_Plantilla)
        Me.Controls.Add(Me.btn_NotaExa)
        Me.Controls.Add(Me.btn_Paciente)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.lbl_nota_exa)
        Me.Controls.Add(Me.lbl_NotaSecc)
        Me.Controls.Add(Me.btn_Histograma)
        Me.Controls.Add(Me.lst_pedidos)
        Me.Controls.Add(Me.txt_ResMan)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lst_remitidos)
        Me.Controls.Add(Me.btn_Leer)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.grp_seleccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pan_hist)
        Me.Controls.Add(Me.btn_adjuntapdf)
        Me.Controls.Add(Me.lbl_LabId)
        Me.Controls.Add(Me.lbl_ordenMIS)
        Me.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ValidacionRes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VALIDACION DE RESULTADOS"
        Me.grp_seleccion.ResumeLayout(False)
        Me.grp_seleccion.PerformLayout()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_resPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_hist.ResumeLayout(False)
        CType(Me.pic_plt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_rbc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_wbc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_GrabaSecc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DiffimageHSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WBCImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiffimageLSHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBCimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiffimageBASO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiffimageLSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Codigo de Formulario"
    Dim frm_refer_main_form As Frm_Main
    Private mouse_offset As Point
    Dim dbl_x As Double
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    'Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp
    '    If e.Button = MouseButtons.Left Then
    '        Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
    '        frm_refer_main_form.limpiaGrp()
    '        Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
    '    End If
    'End Sub


    Private Sub Formulario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        On Error Resume Next
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm

    End Sub



    Private Sub Formulario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'elimina la referecnia del formulario del MDI
        ClickMenu_Principal(Me)
        RemoveCtxMenu_Principal(Me, Me.Text)
    End Sub


#End Region
    'Dim frm_refer_main_form As Frm_Main
    Dim hist_ok As Boolean = False
    Dim opr_hist As New Cls_Hist()
    Dim str As String
    Dim arr_wbc(), arr_rbc(), arr_plt() As String
    Dim pen As New Pen(Color.White)
    Dim str_dir As String = Environment.CurrentDirectory & "\~tempimg"
    Dim dts_datos As New DataSet()

    Dim dts_trabajo As DataSet
    Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_archivo As New Cls_Archivos()
    Dim opr_remitidos As New Cls_Remitidos()
    Dim opr_invitado As New Cls_Invitado()
    Dim str_antecedentes As String = ""
    Dim str_medicamentos As String = ""
    Dim opr_res As New Cls_Resultado()
    Dim opr_ped As New Cls_Pedido()
    Dim opr_SNI As New Cls_SNI()
    Dim str_edad As String = ""
    Dim dts_resp As DataSet
    Dim dtt_res As New DataTable("Registros")
    Dim dtv_resp As New DataView(dtt_res)
    'Dim boo_his As Boolean = False 'Variable que determina si un pedido tiene o no histogramas
    '*****
    'C�digo para hacer sonar la alarma
    Public Const SND_ASYNC = &H1 ' play asynchronously
    Public Const SND_LOOP = &H8 ' loop the sound until next sndPlaySound
    Public Const SND_NOSTOP = &H10 ' don't stop any currently playing sound
    Public Const SND_NOWAIT = &H2000 ' don't wait if the driver is busy
    Dim rem_id As String
    Dim abrirPdf As String

    Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As String, ByVal hModule As Long, ByVal dwFlags As Long) As Long

    '*****

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        If MsgBox("Desea cerrar la ventana Validacion de resultados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub



    Private Sub btn_busqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        LimpiarCamposVR()
        If Not ExisteForm("frm_Busq_Pedidos") Then
            Dim frm_MDIChild As New frm_Busq_Pedidos()
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.ShowDialog(Me.ParentForm)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.ParentForm.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function

    Private Function FormularioActivo(ByVal _form As Form) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next
        Return Nothing
    End Function


    Public Sub llena_datos(ByVal tipo As String)
        On Error Resume Next
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        Dim unidad As String = Nothing
        Dim ped_id_historico As Long

        If Me.Tag = "" Then
            LimpiarCamposVR()
            Exit Sub
        End If
        hist_ok = False
        If (btn_Histograma.Text <> "Histogr.") Then
            txt_ResMan.Visible = True
            txt_notaArea.Visible = True
            Label3.Visible = True
            Label1.Visible = True
            pic_wbc.Image = Nothing
            pic_rbc.Image = Nothing
            pic_plt.Image = Nothing
            pan_hist.Visible = False
            'btn_Histograma.Text = "Histogr."
        End If

        str_campos = Split(Me.Tag, "/*/")
        lbl_pedidoD.Text = ""
        lbl_pacienteD.Text = ""
        lbl_fechaD.Text = ""
        lbl_FecNacD.Text = ""
        lbl_doctorD.Text = ""
        str_antecedentes = ""
        str_medicamentos = ""
        lbl_pacienteD.Tag = ""
        lbl_OBS.Text = ""
        For int_indice = 0 To UBound(str_campos)
            int_pos = InStr(str_campos(int_indice), "=")
            str_texto = str_campos(int_indice).Substring(0, int_pos - 1)
            str_valor = str_campos(int_indice).Substring(int_pos)
            Select Case str_texto
                Case "ped_orden"
                    lbl_ordenMIS.Text = (str_valor)
                Case "ped_turno"
                    lbl_turno.Text = Trim((str_valor))
                    g_orden = Trim(lbl_turno.Text)
                Case "ped_fecing"
                    lbl_fechaD.Text = Trim(Format(CDate(str_valor), "dd - MMM - yyyy"))
                    opr_ped.CalculaEdad(CDate(str_valor), unidad)
                    lbl_edadPac.Text = "(" & opr_ped.CalculaEdad(CDate(str_valor), unidad) & " " & unidad & ")"
                Case "pac_nombre"
                    lbl_pacienteD.Text = (str_valor)
                Case "pac_fecnac"
                    lbl_FecNacD.Text = Trim(Format(CDate(str_valor), "dd-MMM-yyyy"))
                    opr_ped.CalculaEdad(CDate(str_valor), unidad)
                    lbl_edadPac.Text = "(" & opr_ped.CalculaEdad(CDate(str_valor), unidad) & " " & unidad & ")"
                Case "ped_antecedentes"
                    str_antecedentes = (str_valor)
                Case "ped_medicacion"
                    str_medicamentos = (str_valor)
                Case "servicio"
                    lbl_Servicio.Text = (str_valor)
                Case "med_nombre"
                    lbl_doctorD.Text = (str_valor)
                Case "pac_doc"
                    lbl_pacienteD.Tag = str_valor
                Case "ped_nota"
                    lbl_ordenMIS.Text = (str_valor)
                Case "ped_id"
                    lbl_pedidoD.Text = (str_valor)
                Case "pac_usafecnac"
                    If str_valor = 0 Then
                        lbl_FecNacD.Text = "--"
                    End If
                Case "LAB"
                    lbl_LabId.Text = (str_valor)
                Case "OBS"
                    lbl_OBS.Text = Trim((str_valor))

                Case "ped_obs"
                    lbl_OBS.Text = lbl_OBS.Text & " - " & Trim((str_valor))

                Case "ped_tipo"
                    lbl_Convenio.Text = Trim((str_valor))
            End Select
        Next
       

        'Cargo los resultados de los equipos en el grid
        opr_res.ResultadosPedido(dtv_resp, dgrd_resPedido, CInt(lbl_pedidoD.Text), 0, aareas, ped_id_historico)

        
        Dim boo_error As Boolean = False
        Dim i As Integer
        Dim boo_desc As Boolean = False
        'EN EL SIGUIENTE FOR CONSULTO LA DESCRIPCION DEL ERROR SEGUN EL PRC_ERROR Y SNI_NOMBRE
        'SI NO EXISTE ESCRIBIMOS EN LA CELDA "ERROR DESCONOCIDO, CASO CONTRARIO LA DESC. DEL ERROR"
        For i = 0 To dtv_resp.Count - 1
            'dtv_resp.Item(i).Row(11) = opr_res.ErrorDesc(dtv_resp.Item(i).Row(9), dtv_resp.Item(i).Row(10))
            dtv_resp.Item(i).Row(12) = opr_res.ErrorDesc(dtv_resp.Item(i).Row(9), dtv_resp.Item(i).Row(11))
        Next
        'EN EL SIGUIENTE FOR DETERMINO SI EXISTEN ERRORES EN LAS PRUEBAS AUTOMATICAS, y SI LOS CONSULTO 
        'RESULTADOS ESTAN DENTRO DE LOS RANGOS DE NORMALIDAD DEFINIDOS
        Dim dts_rango As New DataSet()
        Dim res_Historico As String = Nothing

        Dim dtr_fila As DataRow
        For i = 0 To dtv_resp.Count - 1
            dts_rango = opr_res.LeerRangNormal(dtv_resp.Item(i).Row(4), dtv_resp.Item(i).Row(3))

            'consulta orden anterio para historico
            'ped_id_historico = opr_res.PedidoHistorico(CLng(lbl_pacienteD.Tag), CDate(lbl_fechaD.Text))

            For Each dtr_fila In dts_rango.Tables(0).Rows
                If dtr_fila(1) = 1 Then
                    If dtv_resp.Item(i).Row(10) = "" Then
                        'dtv_resp.Item(i).Row(11) = "Resultado no disponible"
                        'dtv_resp.Item(i).Row(12) = "Resultado no disponible"
                        dtv_resp.Item(i).Row(11) = ""
                        dtv_resp.Item(i).Row(12) = ""
                        'If (dtv_resp.Item(i).Row(5) Is DBNull.Value) = False Or dtv_resp.Item(i).Row(5).ToString <> "" Then
                        If dtv_resp.Item(i).Row(5).ToString <> "" Then

                            If (CDbl(dtv_resp.Item(i).Row(5)) > CDbl(dtr_fila(2) And CDbl(dtv_resp.Item(i).Row(5)) < CDbl(dtr_fila(3)))) Then
                                dtv_resp.Item(i).Row(9) = ""
                                dtv_resp.Item(i).Row(10) = ""
                                boo_error = False
                            End If

                            If CDbl(dtv_resp.Item(i).Row(5)) > CDbl(dtr_fila(3)) Then
                                dtv_resp.Item(i).Row(9) = "Alto"
                                dtv_resp.Item(i).Row(10) = "Alto"
                               
                                

                                boo_error = True
                            End If

                            If CDbl(dtv_resp.Item(i).Row(5)) < CDbl(dtr_fila(2)) Then
                                dtv_resp.Item(i).Row(9) = "Bajo"
                                dtv_resp.Item(i).Row(10) = "Bajo"
                                boo_error = True
                            End If

                        End If
                    End If

                End If
            Next
            If dtv_resp.Item(i).Row(9) <> "00000" And dtv_resp.Item(i).Row(9) <> "" Then
                boo_error = True
                'If dtv_resp.Item(i).Row(9) = "Alto" Then
                'dgrd_resPedido.Item(i, 8).defaultcellstyle.backcolor = Color.Red
                'dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 8).backcolor = Color.Red
                dgrd_resPedido.AlternatingBackColor = Color.Red
                dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 8).Style.BackColor = Color.Red
                'End If
            End If
        Next


        Dim dtr_fila1 As DataRow

        ' CONSULTO LA ORDEN ANTERIOR
        For i = 0 To dtv_resp.Count - 1


            ped_id_historico = opr_res.PedidoHistorico(CLng(lbl_pacienteD.Tag), CDate(lbl_fechaD.Text), dtv_resp.Item(i).Row(3))

            If ped_id_historico <> "-1" Then
                res_Historico = opr_res.LeerHistorico(ped_id_historico, dtv_resp.Item(i).Row(3), CInt(dtv_resp.Item(i).Row(14)))
                'consulta orden anterio para historico
                'For Each dtr_fila1 In dts_Historico.Tables(0).Rows
                'If dtr_fila1(0) <> "" Then
                dtv_resp.Item(i).Row(6) = res_Historico
                'dtv_resp.Item(i).Row(4) = res_Historico
                End If

        Next



        Dim rc As Long
        Dim temp As Object
        If boo_error = True Then

            'Reproduzco el sonido wav como alarma sonora
            'file in bin directory
            rc = PlaySound(System.AppDomain.CurrentDomain.BaseDirectory & "\system\REMINDER.WAV", 0, SND_NOSTOP)
            If rc = 0 Then
                '    'Sound(didn) 't play, so just beep...
                Beep()
            End If
            'temp = sndPlaySound(System.AppDomain.CurrentDomain.BaseDirectory & "REMINDER.WAV", 1)

        End If
        ''Dim dts_resm As DataSet
        'Dim dtr_fila As DataRow
        ''dts_resm = opr_res.LeerResultadoM(CInt(lbl_pedidoD.Text), tipo)
        ''Dim x As String = ""
        ''txt_ResMan.Text = ""
        'For Each dtr_fila In dts_resm.Tables("Registros").Rows
        '    x = x & dtr_fila(1) & ": " & txt_ResMan.Text & dtr_fila(0) & "  " & dtr_fila(3) & ControlChars.CrLf  'NOMBRE DEL TEST y RESULTADOS DEL TEST 
        'Next
        ''For Each dtr_fila In dts_resm.Tables("Registros").Rows
        'Codigo insertado 08-mayo-2003  (Para insertar el rango de normalidad de test manuales)
        '********************
        'dtr_fila(0) --> resultado manual
        '(1) --> nombre del test
        '(2) --> id del test
        '(3) --> unidad
        '(4) --> tipo de rango normal
        '(5) --> rango minimo
        '(6) --> rango maximo
        '(7) --> rango multiple
        ''x = x & ControlChars.CrLf & dtr_fila(1) & ": " & txt_ResMan.Text & dtr_fila(0) & "  " & dtr_fila(3) & ControlChars.CrLf  'NOMBRE DEL TEST y RESULTADOS DEL TEST 
        ''If (dtr_fila(4) > 0) Then
        ''    If (dtr_fila(4) = 1) Then  'Rango unico
        ''        x = x & ControlChars.CrLf & "RANGO NORMAL: " & ControlChars.CrLf & dtr_fila(5) & " -- " & dtr_fila(6) & ControlChars.CrLf
        ''    Else 'Rango multiple
        ''        x = x & ControlChars.CrLf & "RANGO NORMAL: " & ControlChars.CrLf & dtr_fila(7) & ControlChars.CrLf
        ''    End If
        ''End If
        ' ''08-mayo-2003
        '*******************
        ''Next
        ''txt_ResMan.Text = x
        'opr_res.LlenaListRemitido(lst_remitidos, CInt(lbl_pedidoD.Text))
        txt_notaArea.ReadOnly = False
        'btn_adjuntapdf.Enabled = True
    End Sub


    Private Sub btn_ObsPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (str_antecedentes = "" And str_medicamentos = "") Then
            MsgBox("No hay antecedentes, ni medicacion", MsgBoxStyle.Information, "ANALISYS - Observaciones sobre el paciente")
        Else
            MsgBox("Antecedentes:" & Chr(13) & str_antecedentes & Chr(13) & Chr(13) & "Medicacion: " & Chr(13) & str_medicamentos, MsgBoxStyle.Information, "ANALISYS - Observaciones sobre el paciente")
        End If
    End Sub



    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        ' Dim OPR_AS400 As New Cls_AS400()
        Dim testcod As String
        On Error Resume Next
        If (lbl_pedidoD.Text <> "Pedido" And lbl_pedidoD.Text <> "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'If MsgBox("Los cambios realizados en los resultados autom�ticos y las" & Chr(13) & "notas sobre los resultados del pedido ser�n almacenadas" & Chr(13) & "en este momento, desea continuar?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'opr_ped.InsertarNotaPedido(CInt(lbl_pedidoD.Text), txt_notaArea.Text)
            opr_res.ActualizarResMan(CInt(lbl_pedidoD.Text), txt_ResMan.Text)
            Dim shr_x As Short = 0
            Dim int_codigo As Integer = 0
            Dim estavalidado As Integer
            Dim dtv_resauto As New DataView()
            Dim str_opera As String
            dtv_resauto = dgrd_resPedido.DataSource
            'For shr_x = 0 To (dtt_res.Rows.Count)
            For shr_x = 0 To ((dtv_resauto.Table.Rows.Count) - 1)
                int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 3), dgrd_resPedido(shr_x, 12))
                estavalidado = opr_trabajo.Leer_Validado(int_codigo)

                Select Case estavalidado
                    Case 0, 1, 2
                        If ((IsDBNull(dgrd_resPedido(shr_x, 5)) = False) And (Convert.ToString(dgrd_resPedido(shr_x, 5)) <> "")) Then
                            If (CDbl(dgrd_resPedido(shr_x, 5)) <> 0) Then
                                opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 3), CStr(dgrd_resPedido(shr_x, 5)), Trim(dgrd_resPedido(shr_x, 8)), dgrd_resPedido(shr_x, 12), 1, Trim(dgrd_resPedido(shr_x, 11)))
                                str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 3) & "/" & CStr(dgrd_resPedido(shr_x, 5))
                                g_opr_usuario.CargarTransaccion(g_str_login, "Valida Automatico", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", testcod)
                                opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                            End If
                        End If
                    Case 9
                        If (CDbl(dgrd_resPedido(shr_x, 5)) <> 0) Then
                            opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 3), CStr(dgrd_resPedido(shr_x, 5)), Trim(dgrd_resPedido(shr_x, 8)), dgrd_resPedido(shr_x, 12), 9, Trim(dgrd_resPedido(shr_x, 11)))

                            str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 3) & "/" & CStr(dgrd_resPedido(shr_x, 5))
                            g_opr_usuario.CargarTransaccion(g_str_login, "Valida Automatico", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", testcod)
                            opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)
                        End If

                End Select

            Next
            If Not ExisteForm("frm_ValFinal") Then
                Dim frm_MDIChild As New frm_ValFinal()
                frm_MDIChild.frm_refer_main = Me.ParentForm
                frm_MDIChild.Tag = lbl_pedidoD.Text & "," & lbl_ordenMIS.Text
                frm_MDIChild.ShowDialog(Me.ParentForm)
            End If
            '*****CODIGO PARA IMPRIMIR LO VALIDADO FIN 
            If Me.Tag <> "False" Then
                If MsgBox("Desea Imprimir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "ANALISYS") = MsgBoxResult.Yes Then
                    If (lbl_pedidoD.Text = "") Then
                        MsgBox("No ha seleccionado ningon pedido", MsgBoxStyle.Information, "ANALISYS")
                    Else
                        'frm_refer_main_form.escribemsj("INICIANDO GENERACI�N DE REPORTE")
                        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                        'Dim opr_pedido As New Cls_Pedido()
                        '(*)funci�n no utilizada para el club de leones y PUCE por que ellos no usan facturaci�n
                        'chequea que la factura del pedido se encuentre cancelada
                        '(*)Select Case opr_pedido.LeerPedEstadoFactura(CInt(lbl_pedidoD.Text))
                        '0 emitido, 1 abonada, 2 cancelada, 3 anulada
                        '(*)Case 0, 1
                        '(*)MsgBox("El pedido no tiene cancelado sus valores", MsgBoxStyle.Information, "ANALISYS")
                        '(*)Case 3
                        '(*)MsgBox("El pedido tiene su factura anulada, no puede continuar el proceso", MsgBoxStyle.Information, "ANALISYS")
                        '(*)Case 2
                        'C�digo que actualiza el campo ped_estado a 4 --> Pedido impreso y entregado
                        If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                            If MsgBox("El pedido ya fue impreso, desea imprimirlo nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                                Exit Sub
                            End If
                        End If
                        ''frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
                        'opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
                        ''frm_refer_main_form.escribemsj("CONSULTANDO DATOS")

                        Dim dts_operacion As New DataSet()
                        Dim cls_operacion As New Cls_Conexion()
                        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
                        cls_operacion.sql_conectar()
                        ''frm_refer_main_form.escribemsj("CONSULTANDO TEST...")                        'Este select sirve para extraer los datos del los test con equipos
                        'OJO: el primer select trae el rango como resultado2, esto ocurre, porque los campos son blob, y da un problema de casting
                        'con los otros select en la columna resultado2. Los otros dos select que son parte del union, estos otros select si traen el resultado2,
                        'en el 1er select resultado1 trae los resultados, en el 2do y 3ero el campo resultado2 trae los resultados
                        'En el campo TIPO, trae a donde pertenece el dato:
                        '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
                        '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
                        '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 


                        'CODIGO PARA SOLO IMPRIMIR LO QUE PERTENECE A MI AREA

                        Dim str_Areas As String
                        Dim opr_user As New Cls_Usuario()
                        Dim arr_datos As New ArrayList()
                        Dim arr_nombre As New ArrayList()
                        Dim int_i As Integer = 0
                        Dim tes_id As Integer = 0
                        Dim tes_padre As Integer = 0
                        Dim NotaArea As String
                        Dim g_validador, g_validadorID As String
                        g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
                        g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
                        Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
                        Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

                        tes_id = opr_pedido.LeerNombreTest(Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 5).ToString()))
                        tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString()), CInt(lbl_pedidoD.Text))


                        If (tes_id = 10 Or tes_id = 11 Or tes_id = 12 Or tes_id = 13 Or tes_id = 14 Or tes_id = 15 Or tes_id = 16 Or tes_id = 17 Or tes_id = 18 Or tes_id = 19 Or tes_id = 20 Or tes_id = 21 Or tes_id = 22 Or tes_id = 23 Or tes_id = 24 Or tes_id = 25 Or tes_id = 26 Or tes_id = 27 Or tes_id = 28 Or tes_id = 29 Or tes_id = 30 Or tes_id = 31 Or tes_id = 32 Or tes_id = 33 Or tes_id = 34 Or tes_id = 35 Or tes_id = 36 Or tes_id = 37) Then
                            tes_id = 400101
                        End If
                        Dim g_notaArea As String
                        g_notaArea = opr_res.LeerNotaArea(CInt(lbl_pedidoD.Text), tes_id, 1)


                        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_Areas, arr_nombre)
                       
                        Dim x, i As Short
                        Dim areas() As String
                        Dim str_aux As String = "and ("
                        areas = Split(str_Areas, ",")
                        x = UBound(areas)
                        'en caso de que exista areas a donde consultar
                        If x > 0 Then
                            For i = 0 To (x - 1)
                                If i = 0 Then
                                    str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                                Else
                                    str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                                End If
                            Next
                            str_aux = str_aux & " ) "
                        End If
                        'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA
                        Dim str_Sql As String = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, " & _
                   "test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, if(RES_PROCESADOS.PRC_ALARMA='*',concat('* ', RES_PROCESADOS.PRC_RESFINAL),if(RES_PROCESADOS.PRC_RESFINAL ='MEMO',RES_PROCESADOS.PRC_TEXTO, RES_PROCESADOS.PRC_RESFINAL)) AS resultado1, " & _
                   "if(RES_PROCESADOS.PRC_ALARMA='*',concat('* ', RES_PROCESADOS.PRC_RESFINAL),if(RES_PROCESADOS.PRC_RESFINAL ='MEMO',RES_PROCESADOS.PRC_TEXTO, RES_PROCESADOS.PRC_RESFINAL)) AS resultado2, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                   "CONCAT(PACIENTE.PAC_APELLIDO , ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                   "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                   "'" & g_notaArea & "' AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                   "PACIENTE.pac_fecnac as fec_nac, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, " & _
                   "PEDIDO.CON_NOMBRE AS CONVENIO, if (PEDIDO.PED_ESTADO = 4,'COPIA DEL INFORME','') AS SERVICIO, PACIENTE.pac_hist_clinica as pac_hist_clinica, " & _
                   "PEDIDO.ped_antecedente as observaciones, '" & g_validador & "' as LIS_USER, PACIENTE.PAC_SEXO, PEDIDO.PED_ORIGEN as LIS_FECVALIDADO, concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(LENGTH(PEDIDO.ped_turno)=1,concat('000',PEDIDO.ped_turno),if(LENGTH(PEDIDO.ped_turno)=2,concat('00',PEDIDO.ped_turno),if(LENGTH(PEDIDO.ped_turno)=3,concat('0',PEDIDO.ped_turno),'')))) as CB, '" & g_validadorCargo & "' as cargo, '" & g_validadorFolio & "' as folio, test.TES_OBS as metodo, RES_PROCESADOS.TES_PADRE " & _
                   "FROM AREA INNER JOIN (UNIDAD " & _
                   "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                   "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                   "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                   "ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                   "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID " & _
                       "WHERE RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND AREA.ARE_ID = test.ARE_ID  AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                   "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre  "
                        str_Sql = str_Sql & str_aux & " order by ORDEN_IMP"

                        oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
                        oda_operacion.Fill(dts_operacion, "Registros")
                        cls_operacion.sql_desconn()
                        Dim dts_histograma As New DataSet()
                        Dim obj_reporte As New Object

                        'Cargo grid con  valores resultadis + AB disponibles 
                        Dim dts_operaAB As New DataSet()
                        Dim dtt_resAB As New DataTable("RegistrosRESAB")
                        Dim dtv_resAB As New DataView(dtt_resAB)


                        dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)
                        'Dim str_his As String = str_his = "NOHistograma"
                        Dim str_his As String = "NOHistograma"

                        '******Dependiendo si existe o no histograma va el campo Histograma
                        If carga_histograma(dts_histograma) Then str_his = "Histograma"

                        Select Case lbl_LabId.Text
                            Case "2"
                                obj_reporte = New rpt_entregaresultados()
                            Case "3"
                                'obj_reporte = New rpt_entregaresultadosCMR()
                        End Select

                        Dim frm_MDIChild As New Frm_reportes(str_his, "", obj_reporte, dts_operacion, dts_histograma, dts_histograma, dts_operaAB, True)
                        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                        frm_MDIChild.Text = "Emision de Resultados"
                        frm_refer_main_form.Crea_formulario(frm_MDIChild)
                        '(*)End Select
                        'frm_refer_main_form.escribemsj("DISPONIBLE")
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                    End If
                End If
            End If
            '*****CODIGO PARA IMPRIMIR LO VALIDADO FIN 
            LimpiarCamposVR()
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Else
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        End If

    End Sub



    Function carga_histograma(ByRef dts_registro As DataSet) As Boolean
        Dim int_indice As Integer
        Dim dts_datos As New DataSet()
        dts_datos = opr_hist.LeerDatosHistograma(CStr(lbl_pedidoD.Text))
        Dim dtr_fila As DataRow
        Dim boo_his As Boolean = False
        For Each dtr_fila In dts_datos.Tables("Registros").Rows
            boo_his = True
            If dts_datos.Tables(0).Rows.Count < 3 Then
                'El pedido no tiene HISTOGRAMAS
                carga_histograma = False
                Exit Function
            Else
                carga_histograma = True
                If (dtr_fila(0) = "WBC") Then
                    str = dtr_fila(1)
                    arr_wbc = Split(str, ",")
                Else
                    If (dtr_fila(0) = "RBC") Then
                        str = dtr_fila(1)
                        arr_rbc = Split(str, ",")
                    Else
                        'En caso de ser PLT
                        str = dtr_fila(1)
                        arr_plt = Split(str, ",")
                    End If
                End If
            End If
        Next
        If boo_his = True Then
            'En caso de haber un histograma 
            dts_registro.Tables.Add("Registros")
            Dim STR_CAPTION As String() = {"Punto", "Dato_wbc", "Dato_rbc", "Dato_plt"}
            For int_indice = 0 To 3
                Dim dtc_columna As New DataColumn(STR_CAPTION(int_indice))
                dts_registro.Tables("Registros").Columns.Add(dtc_columna)
            Next
            'se asume que se tiene 256 puntos
            For int_indice = 0 To 63 'UBound(str_wbc_arr) - 1  *CELLDYN3500
                'For int_indice = 0 To 254 'UBound(str_wbc_arr) - 1 *CELLDYN1700
                dtr_fila = dts_registro.Tables("Registros").NewRow
                dtr_fila(0) = int_indice
                dtr_fila(1) = CShort(arr_wbc(int_indice))
                dtr_fila(2) = CShort(arr_rbc(int_indice))
                dtr_fila(3) = CShort(arr_plt(int_indice))
                dts_registro.Tables("Registros").Rows.Add(dtr_fila)
            Next
        End If
    End Function

    Public Sub LimpiarCamposVR()
        lst_remitidos.Items.Clear()
        btn_adjuntapdf.Enabled = False
        lbl_pedidoD.Text = ""
        lbl_ordenMIS.Text = ""
        lbl_pacienteD.Text = ""
        lbl_pacienteD.Tag = ""
        lbl_fechaD.Text = ""
        lbl_FecNacD.Text = ""
        lbl_doctorD.Text = ""
        opr_res.ResAutoPedido(dtt_res, 0)
        txt_ResMan.Text = ""
        txt_notaArea.Text = ""
        txt_notaArea.ReadOnly = True
        dtv_resp.Table.Clear()
        pic_wbc.Image = Nothing
        pic_rbc.Image = Nothing
        pic_plt.Image = Nothing
        lbl_turno.Text = ""
        pan_hist.Visible = False
        txt_ResMan.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        txt_notaArea.Visible = True
        lbl_OBS.Text = ""
    End Sub

    Private Sub lbl_FecNacD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_FecNacD.TextChanged
        If (IsDate(lbl_FecNacD.Text)) Then
            Dim var_x As Integer
            lbl_edad.Text = ""
            If lbl_FecNacD.Text = "" Then
                lbl_edad.Text = ""
                str_edad = lbl_edad.Text
                Exit Sub
            End If
            var_x = DateDiff(DateInterval.Month, CDate(lbl_FecNacD.Text), Now)
            If var_x < 12 Then
                If var_x = 12 Then
                    lbl_edad.Text = "1 año"
                Else
                    If var_x > 1 Then
                        lbl_edad.Text = var_x & " meses"
                    Else
                        var_x = DateDiff(DateInterval.Day, CDate(lbl_FecNacD.Text), Now)
                        lbl_edad.Text = var_x & " dias"
                    End If
                End If
            Else
                If var_x < 24 Then
                    lbl_edad.Text = "1 año y " & (var_x - 12) & " meses"
                Else
                    lbl_edad.Text = (var_x \ 12) & " años"
                End If
            End If
        Else
            lbl_edad.Text = ""
        End If
        str_edad = lbl_edad.Text
    End Sub

    Private Sub txt_ResMan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ResMan.DoubleClick
        If (lbl_pedidoD.Text <> "" And txt_ResMan.Text <> "") Then
            txt_ResMan.ReadOnly = False
        Else
            MsgBox("No editable", MsgBoxStyle.Information, "ANALISYS")
        End If
    End Sub

    Private Sub btn_Histograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Histograma.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If (btn_Histograma.Text = "&Histogr.") Then
            If hist_ok = False Then
                'dts_datos = opr_hist.LeerDatosHistograma(CStr(lbl_pedidoD.Text))
                'If dts_datos.Tables(0).Rows.Count < 3 Then
                ' Me.Cursor = System.Windows.Forms.Cursors.Arrow
                'MsgBox("El pedido no posee Histogramas", MsgBoxStyle.Information, "ANALISYS")
                'Else

                'btn_Histograma.Text = "&R. Manual"
                'pic_wbc.Image = Nothing
                'pic_rbc.Image = Nothing
                'pic_plt.Image = Nothing
                'Label3.Visible = False
                'Label1.Visible = False
                'pan_hist.Visible = True

                'Dim dtr_fila As DataRow
                'Dim boo_his As Boolean = False
                'For Each dtr_fila In dts_datos.Tables("Registros").Rows
                '    boo_his = True
                '    If (dtr_fila(0) = "WBC") Then
                '        str = dtr_fila(1)
                '        arr_wbc = Split(str, ",")
                '    Else
                '        If (dtr_fila(0) = "RBC") Then
                '            str = dtr_fila(1)
                '            arr_rbc = Split(str, ",")
                '        Else
                '            'En caso de ser PLT
                '            str = dtr_fila(1)
                '            arr_plt = Split(str, ",")
                '        End If
                '    End If
                'Next
                'If boo_his = True Then
                '    opr_hist.Grafica_Histogramas(arr_wbc, arr_rbc, arr_plt, Me.pic_wbc, Me.pic_rbc, Me.pic_plt)
                '    hist_ok = True
                'Else
                '    MsgBox("El pedido no posee Histogramas", MsgBoxStyle.Information, "ANALISYS")
                'End If
                'End If
                '*****HISTOGRAMAS FIN 
            Else
                btn_Histograma.Text = "R. Manual"
                pan_hist.Visible = True
                pan_hist.BringToFront()
            End If
        Else
            txt_ResMan.Visible = True
            txt_notaArea.Visible = True
            Label3.Visible = True
            Label1.Visible = True
            pan_hist.Visible = False
            'btn_Histograma.Text = "Histogr."
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub frm_ValidacionRes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '''If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_Grafica("", "GRAF_ERROR", 30, False))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_Grafica("ERROR", "DESCRIP", 0, True))
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(11).WidthChanged, AddressOf CambiaTamanoCelda

        lst_remitidos.Items.Clear()
        '
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer
        Dim str_areas As String = Nothing
        Dim secuenciaIni As String = Nothing
        Dim secuenciaFin As String = Nothing
        g_orden = ""

        g_CadenaFiltro = Me.Tag

        btn_historico.Enabled = False
        If Me.Tag <> "" Then
            arregloAreas = Split(Me.Tag, ",")
            fechaIni = arregloAreas(0).ToString
            fechaFin = arregloAreas(1).ToString
            secuenciaIni = arregloAreas(3).ToString
            secuenciaFin = arregloAreas(4).ToString
            Prioridad = arregloAreas(2).ToString


            ConvenioSecuencia = Prioridad & "," & secuenciaIni & "," & secuenciaFin

            lbl_NombreConvenio.Text = Trim(Prioridad)

            For i = 5 To UBound(arregloAreas) - 1
                areas = areas & arregloAreas(i) & ","
            Next
            aareas = Mid(areas, 1, areas.Length - 1)

            dtv_resp.Table.Clear()

            lst_pedidos.Items.Clear()
            dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), ConvenioSecuencia, op_filtro, 0, filtroOrdenes)
            If dts_lista.Tables.Count > 0 Then
                btn_Validar.Enabled = True
                'btn_Plantilla.Enabled = True
                btn_NotaExa.Enabled = True
            Else
                btn_Validar.Enabled = False
                'btn_Plantilla.Enabled = False
                btn_NotaExa.Enabled = False
            End If
        End If
    End Sub

    Sub CambiaTamanoCelda(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.GetType.Name = "Cls_Celda_Grafica" Then
            sender.Width = 18
        End If
    End Sub

    Public Sub InterpretarDatos(ByVal equipo As String) '(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ResBD.Click
        '******JPO  26 Junio 2003
        Dim x, y, h As Array
        Dim i, j As Short
        Dim ruta As String = ""
        Dim dir_cdf() As String
        Dim aux As Short = 0
        Dim boo_read As Boolean = False  'Variable que indica si un archivo fue leido o no 
        Dim fecha As String
        Dim path_local As String = Trim(equipo.Substring(290, 150))
        ruta = Dir(Environment.CurrentDirectory & "/Resultados", FileAttribute.Directory)
        If ruta = "" Then
            Directory.CreateDirectory(Environment.CurrentDirectory & "\Resultados")
        End If
        'SE RECUPERAN LOS ARCHIVOS *H.CDF Y SE LOS ALMACENA EN LA BASE DE DATOS (HISTOGRAMAS )
        '/*INICIO   JVA 25-FEB-2004
        h = Directory.GetFiles(Environment.CurrentDirectory & path_local, "*H.cdf")
        If (UBound(h) <> -1) Then
            For i = 0 To UBound(h)
                'PROCESO EN EL QUE SE GUARDA EN LA BASE LOS DATOS DE LOS HISTOGRAMAS
                opr_archivo.Guarda_Dat_Hist(h(i), boo_read, fecha)
                If boo_read = False Then
                    'Si el archivo no fue leido y es de m�s de 4 d�as de antiguedad lo borro
                    'Caso contrario se lo conserva
                    If DateDiff("d", CDate(fecha), Today) > 4 Then
                        File.Delete(h(i))
                    End If
                Else
                    'Si ya fue leido es borrado.
                    File.Delete(h(i))
                End If
            Next
            opr_SNI.LeerFTP(Trim(equipo.Substring(170, 20)), Trim(equipo.Substring(190, 50)), Trim(equipo.Substring(240, 50)), Trim(equipo.Substring(290, 150)), Trim(equipo.Substring(440, 150)), 1, "H.cdf")
        End If

        'SE RECUPERAN LOS ARCHIVOS *.CDF Y SE LOS ALMACENA EN LA BASE DE DATOS 
        h = Directory.GetFiles(Environment.CurrentDirectory & path_local, "*.cdf")
        If (UBound(h) <> -1) Then
            For i = 0 To UBound(h)
                'PROCESO EN EL QUE SE GUARDA EN LA BASE LOS DATOS DE LOS HISTOGRAMAS
                boo_read = False
                opr_archivo.Guarda_Archiv_Procesados(h(i), boo_read, fecha)
                'UNA VEZ ALMACENADOS LOS cdfs EL ARCHIVO ES ELIMINADO
                If boo_read = False Then
                    'Si el archivo no fue leido y es de m�s de 4 d�as de antiguedad lo borro
                    'Caso contrario se lo conserva
                    If DateDiff("d", CDate(fecha), Today) > 4 Then
                        File.Delete(h(i))
                    End If
                Else
                    'Si ya fue leido es borrado.
                    File.Delete(h(i))
                End If
            Next
            'JVA 14-04-2004

            'CAMBIO QUE DEVUELVE LOS ARCHIVOS QUE NO HAN SIDO LEIDOS A SU DESTINO ORIGINAL. MEDIANTE FTP
            '**OJO*** JPO
            'ESTE CAMBIO SI FUNCIONA, PERO POR MOTIVOS DESCONOCIDOS EN EL CLUB DE LEONES HAY UNA PERDIDA DE ARCHIVOS
            'POR LO CUAL TEMPORALMENTE QUEDA DESHABILITADO LA LECTURA CON FTP DESDE CUALESQUIER MAQUINA, PARA QUEDAR
            'UNICAMENTE CON LA LECTURA LOCAL.
            opr_SNI.LeerFTP(Trim(equipo.Substring(170, 20)), Trim(equipo.Substring(190, 50)), Trim(equipo.Substring(240, 50)), Trim(equipo.Substring(290, 150)), Trim(equipo.Substring(440, 150)), 1, ".cdf")
        End If
        'SE RECUPERAN LOS ARCHIVOS *.LOG Y SE LOS ACTUALIZA EN LA LISTA DE TRABAJO COMO RECHAZADOS
        h = Directory.GetFiles(Environment.CurrentDirectory & path_local, "*.log")
        If (UBound(h) <> -1) Then
            For i = 0 To UBound(h)
                'PROCESO EN EL QUE SE GUARDA EN LA BASE LOS DATOS DE LOS HISTOGRAMAS
                opr_archivo.ActualizaArchivosRechazados(h(i))
                'UNA VEZ ALMACENADOS LOS HISTOGRAMAS EL ARCHIVO ES ELIMINADO
                File.Delete(h(i))
            Next
        End If

        h = Directory.GetFiles(Environment.CurrentDirectory & path_local, "*.qct")
        If (UBound(h) <> -1) Then
            For i = 0 To UBound(h)
                'PROCESO EN EL QUE SE GUARDA EN LA BASE LOS DATOS DE LOS HISTOGRAMAS
                opr_archivo.GuardarArchivoCTL(h(i))
                'UNA VEZ ALMACENADOS LOS HISTOGRAMAS EL ARCHIVO ES ELIMINADO
                File.Delete(h(i))
            Next
        End If

        h = Directory.GetFiles(Environment.CurrentDirectory & path_local, "*.clb")
        If (UBound(h) <> -1) Then
            For i = 0 To UBound(h)
                'PROCESO EN EL QUE SE GUARDA EN LA BASE LOS DATOS DE LOS HISTOGRAMAS
                opr_archivo.GuardarArchivoCLB(h(i))
                'UNA VEZ ALMACENADOS LOS HISTOGRAMAS EL ARCHIVO ES ELIMINADO
                File.Delete(h(i))
            Next
        End If
        '/******FIN
    End Sub




    Private Sub btn_historico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (lbl_pedidoD.Text <> "Pedido" And lbl_pedidoD.Text <> "") Then

            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'LimpiarCamposVR()
            'If Not ExisteForm("frm_historico") Then
            '    Dim frm_MDIChild As New frm_historico()
            '    frm_MDIChild.frm_refer_main = Me.ParentForm
            '    frm_MDIChild.ShowDialog(Me.ParentForm)
            'End If
            'Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Else
            MsgBox("No hay ningun pedido seleccionado para la busqueda.", MsgBoxStyle.Exclamation, "ANALISYS")
        End If


    End Sub



    Private Sub dgrd_resPedido_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_resPedido.CurrentCellChanged
        Dim dgc_celda As DataGridCell
        Dim NotaExamen As String = ""
        Dim NotaArea As String = ""
        Dim tes_padre As Integer
        Dim opr_pedido As New Cls_Pedido()
        Dim tabla_val As String()
        Dim formula As String = Nothing
        ' 6 = PLANTILLA
        ' 8 = CULTIVO

        valores = Nothing

        


        For i = 0 To dtv_resp.Table.Rows.Count - 1
            If IsDBNull(dgrd_resPedido.Item(i, 6)) Then
                dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 6) = ""
            End If

            valores = valores & CStr(dgrd_resPedido.Item(i, 22)) & "," & dgrd_resPedido.Item(i, 6) & "|"
        Next




        tabla_val = Split(valores, "|")

        If opr_res.verifica_autocompletar(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22)) <= 0 Then
            cmb_resultado.Hide()
            cmb_resultado.SendToBack()
            'If opr_res.verifica_autoCalcular(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)) <= 0 Then
            '    inicia_gridCal(CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)))
            'End If
        Else
            cmb_resultado.Show()
            inicia_gridRes(75, CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22)))

        End If



        ' 4: MOLECULAR 
        ' 6: PLANTILLA
        ' 8: CULTIVO
        ' 9: DIAGNOTICO (OCUPACIONAL)

        If dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19) = 6 Or dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19) = 8 Or dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19) = 1 Or dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19) = 4 Or dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19) = 9 Then
            btn_Plantilla.Enabled = True
        Else
            btn_Plantilla.Enabled = False
        End If

        
        If opr_res.LeerFormula(CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22)), formula) <> "" Then
            Dim factores As String()
            Dim valores_aux As String()
            Dim valor1 As String
            Dim valor2 As String
            Dim valor3 As String
            Dim valor4 As String
            Dim resul As Double

            opr_res.EjecutaFormula(formula, factores)
            Select Case UBound(factores) + 1
                Case 1
                    For i = 0 To UBound(tabla_val) - 1
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(0) Then
                            valor1 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                    Next

                Case 2 : For i = 0 To UBound(tabla_val) - 1
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(0) Then
                            valor1 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(1) Then
                            valor2 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                    Next

                Case 3 : For i = 0 To UBound(tabla_val) - 1
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(0) Then
                            valor1 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(1) Then
                            valor2 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(2) Then
                            valor3 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                    Next


            End Select

            If (valor1 <> "" Or valor2 <> "" Or valor3 <> "" Or valor4 <> "" Or IsDBNull(valor1) Or IsDBNull(valor2) Or IsDBNull(valor3) Or IsDBNull(valor4)) Then
                opr_res.VisualizaCalculo(CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22)), valor1, valor2, valor3, valor4, resul)
                dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 6) = CStr(resul)
            End If

        End If

        ''dgc_celda.ColumnNumber = 6
        ''dgc_celda.RowNumber = dgrd_resPedido.CurrentCell.RowNumber
        ''dgrd_resPedido.CurrentCell = dgc_celda
        ''dgrd_resPedido.Select(dgrd_resPedido.CurrentCell.RowNumber)

        'RFN
        dgrd_resPedido.CaptionText = "RESULTADOS DISPONIBLES:          " & dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 0).ToString()
        'lbl_nota_exa.Text = dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString()
        lbl_NotaSecc.Text = dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 0).ToString()


        tes_padre = Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22).ToString())


        'NotaExamen = opr_res.LeerNotaExamen(CInt(lbl_pedidoD.Text), tes_id, 1)

        'If NotaExamen <> "" Then
        '    txt_notas.Text = NotaExamen
        'Else
        '    txt_notas.Text = ""
        'End If

        ' ''If (tes_id = 10 Or tes_id = 11 Or tes_id = 12 Or tes_id = 13 Or tes_id = 14 Or tes_id = 15 Or tes_id = 16 Or tes_id = 17 Or tes_id = 18 Or tes_id = 19 Or tes_id = 20 Or tes_id = 21 Or tes_id = 22 Or tes_id = 23 Or tes_id = 24 Or tes_id = 25 Or tes_id = 26 Or tes_id = 27 Or tes_id = 28 Or tes_id = 29 Or tes_id = 30 Or tes_id = 31 Or tes_id = 32 Or tes_id = 33 Or tes_id = 34 Or tes_id = 35 Or tes_id = 36 Or tes_id = 37) Then
        ' ''    tes_id = 400101
        ' ''End If
        NotaArea = opr_res.LeerNotaArea(CInt(lbl_pedidoD.Text), tes_padre, 1)

        If NotaArea <> "" Then
            txt_notaArea.Text = NotaArea
        Else
            txt_notaArea.Text = ""
        End If
        If dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4) <> "" Then
            btn_historico.Enabled = True
        Else
            'btn_historico.Enabled = False
        End If

        'opr_res.ResultadosPedido(dtv_resp, dgrd_resPedido, CInt(lbl_pedidoD.Text), 0, aareas)


    End Sub


    Public Function inicia_gridRes(ByVal int_tam As Integer, ByVal test As Integer, Optional ByVal are_id As Integer = 0)
        On Error Resume Next
        'Dim int_tam As Short

        'cmb_resultado.Items.Clear()
        CargarCombo(cmb_resultado, opr_res.LeerTipoResultado(test))

        AddHandler DataGridTextBoxColumn6.TextBox.Enter, AddressOf Despliega_resultado
        AddHandler DataGridTextBoxColumn6.TextBox.MouseEnter, AddressOf Despliega_resultado
        'AddHandler dgtc_Resul.TextBox.MouseDoubleClick, AddressOf TextoDblClick
        'combo de laboratotio
        cmb_resultado.Font = New Font("Courier New", 8.2!, FontStyle.Regular)
        cmb_resultado.DropDownStyle = ComboBoxStyle.DropDown
        cmb_resultado.Width = int_tam
        DataGridTextBoxColumn6.TextBox.Width = int_tam + 10
        DataGridTextBoxColumn6.TextBox.Height = 28
        'cmb_resultado.Text = dgtc_TRes.TextBox.Text
        DataGridTextBoxColumn6.TextBox.Controls.Add(cmb_resultado)
        cmb_resultado.BringToFront()

    End Function


    Private Sub Despliega_resultado(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        cmb_resultado.Text = ""
        'cmb_resultado.SelectedIndex = UbicaTextbox(dgrd_resPedido(dgrd_resPedido.CurrentCell.RowNumber, 2), cmb_resultado)
        ''''''''txt_resultado_Enfoque(Sender, e)
    End Sub


    Sub CargarCombo(ByVal Combobox As ComboBox, ByVal parametros As String)
        On Error Resume Next
        Dim param As String()
        Dim i As Integer = 0

        param = Split(parametros, ",")
        'Dim dtr_fila As DataRow
        Combobox.Items.Clear()
        For i = 0 To UBound(param)
            Combobox.Items.Add(param(i).ToString)
        Next
    End Sub

    Private Sub select_resultado(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_resultado.TextChanged
        On Error Resume Next
        'escribe en el grid el texto seleccionado en el TXT
        Inserta_campo(6, sender.text)
        TamColumna(sender, e)
    End Sub

    Sub TamColumna(ByVal sender As Object, ByVal e As System.EventArgs)
        DataGridTextBoxColumn6.Width = 75
    End Sub


    Sub Inserta_campo(ByVal columna As Short, ByVal texto As String)
        On Error GoTo msgerrcol
        If Trim(texto) = "" Then Exit Sub
        dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, columna) = texto
        Exit Sub
msgerrcol:
        dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, columna) = texto
    End Sub


    Private Sub btn_adjuntapdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adjuntapdf.Click

        Dim frm_MDIChild As New frm_ValRemitidos()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.lbl_pedidoR.Text = lbl_pedidoD.Text
        frm_MDIChild.lbl_pacienteR.Text = lbl_pacienteD.Tag
        frm_MDIChild.ShowDialog(Me.ParentForm)
        LimpiarCamposVR()

    End Sub



    Private Sub lst_remitidos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_remitidos.DoubleClick
        Try
            abrirPdf = g_pathremitidosLee & Trim(Mid(lst_remitidos.SelectedItem.ToString(), 61, Len(lst_remitidos.SelectedItem.ToString())))
            System.Diagnostics.Process.Start(abrirPdf)

        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
        End Try
    End Sub




    Private Sub filtrar()
        On Error Resume Next
        'fechaIni = Format(dtp_fi.Value, "dd/MM/yyyy")
        'fechaFin = Format(dtp_ff.Value, "dd/MM/yyyy")
        'area = cmb_area.Text.Substring(50, 2)
        'dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, area, 1)
    End Sub





    Private Sub lst_pedidos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_pedidos.KeyDown
        On Error Resume Next
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If dts_lista.Tables(0).Rows.Count > 0 Then
            btn_NotaExa.Visible = True
            'btn_Editar.Visible = True
            btn_Validar.Visible = True
            btn_Paciente.Visible = True
            btn_Plantilla.Visible = True
        Else
            btn_NotaExa.Visible = False
            'btn_Editar.Visible = False
            btn_Validar.Visible = False
            btn_Paciente.Visible = False
            btn_Plantilla.Visible = False
        End If

        Me.Tag = ""
        Me.Tag = "ped_turno= " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString & "/*/ped_fecing=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(0).ToString & "/*/pac_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString & "/*/pac_fecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(4).ToString & "/*/ped_antecedentes=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(5).ToString & "/*/ped_medicacion=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(6).ToString & "/*/med_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(7).ToString & "/*/ped_nota=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(9).ToString & "/*/ped_id=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & "/*/pac_usafecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(11).ToString & "/*/pac_doc=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(12).ToString & "/*/ped_orden=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(13).ToString
        Me.llena_datos("Validacion")
        Me.Activate()

        btn_NotaExa.Enabled = True
        Me.Cursor = System.Windows.Forms.Cursors.Arrow


    End Sub

    Private Sub lst_pedidos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_pedidos.KeyUp, dgrd_resPedido.KeyDown
        On Error Resume Next
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If dts_lista.Tables(0).Rows.Count > 0 Then
            btn_NotaExa.Visible = True
            'btn_Editar.Visible = True
            btn_Validar.Visible = True
            btn_Paciente.Visible = True
            btn_Plantilla.Visible = True
        Else
            btn_NotaExa.Visible = False
            'btn_Editar.Visible = False
            btn_Validar.Visible = False
            btn_Paciente.Visible = False
            btn_Plantilla.Visible = False
        End If

        Me.Tag = ""
        Me.Tag = "ped_turno= " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString & "/*/ped_fecing=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(0).ToString & "/*/pac_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString & "/*/pac_fecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(4).ToString & "/*/ped_antecedentes=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(5).ToString & "/*/ped_medicacion=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(6).ToString & "/*/med_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(7).ToString & "/*/ped_nota=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(9).ToString & "/*/ped_id=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & "/*/pac_usafecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(11).ToString & "/*/pac_doc=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(12).ToString & "/*/ped_orden=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(13).ToString
        Me.llena_datos("Validacion")
        Me.Activate()

        btn_NotaExa.Enabled = True
        Me.Cursor = System.Windows.Forms.Cursors.Arrow


    End Sub


    Private Sub Pic_GrabaSecc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_GrabaSecc.Click
        Dim equ_id, are_id As Integer
        Dim opr_pedido As New Cls_Pedido()

        If txt_notaArea.Text <> "NOTA AREA" Then
            are_id = CInt(Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 23).ToString()))

            opr_ped.InsertarNotaArea(CInt(lbl_pedidoD.Text), are_id, Trim(txt_notaArea.Text))
            g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA NOTA AREA", "AREA EXAMEN =" & are_id & "/" & Trim(txt_notaArea.Text), g_sng_user, lbl_pedidoD.Text, "", "")
            lbl_NotaSecc.Text = "GUARDADO: " & lbl_NotaSecc.Text
        End If
    End Sub



    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim frm_Validares As New frm_ValidacionRes
        Dim filtroOrdenes As String

        If FormularioActivo(frm_Validares) Then
            frm_Validares.Close()

            Dim frm_MDIChild As New frm_FiltroAreas
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.ShowDialog(Me.ParentForm)
            g_CadenaFiltro = frm_MDIChild.CadenaFiltro
            ''End If


            'USANDO EL FILTRO
            If g_CadenaFiltro <> "" Then
                arregloAreas = Split(g_CadenaFiltro, ",")
                fechaIni = arregloAreas(0).ToString
                fechaFin = arregloAreas(1).ToString
                Prioridad = arregloAreas(2).ToString

                For i = 3 To UBound(arregloAreas) - 1
                    areas = areas & arregloAreas(i) & ","
                Next
                aareas = Mid(areas, 1, areas.Length - 1)
                dtv_resp.Table.Clear()
                lst_pedidos.Items.Clear()

                dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), g_str_unidad, op_filtro, 0, filtroOrdenes)
                If dts_lista.Tables.Count > 0 Then
                    btn_Validar.Enabled = True
                    'btn_Plantilla.Enabled = True
                    btn_NotaExa.Enabled = True
                Else
                    btn_Validar.Enabled = False
                    'btn_Plantilla.Enabled = False
                    btn_NotaExa.Enabled = False
                End If
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Arrow

        Else
            Me.Close()
        End If
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        If MsgBox("Desea cerrar la ventana Validacion de resultados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub btn_Paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Paciente.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'LimpiarCamposVR()
        Dim ped_id As Integer = 0
        Dim frm_MDIChild As New frm_Busq_Pedidos()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        areas = ""
        orden = frm_MDIChild.orden

        Dim sw As Boolean = False

        For i = 0 To (lst_pedidos.Items.Count - 1)
            If orden = Trim(Mid(lst_pedidos.Items.Item(i), 4, 9)) Then
                'obtiene_indice = lst_pedidos.SelectedIndex
                lst_pedidos.SetSelected(i, True)
                sw = True
                Exit For

            End If
        Next

        If sw = False Then
            opr_ped.VisualizaMensaje("No se encontro el registro", 300)
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Arrow


        ''If g_CadenaFiltro <> "" Then
        ''    arregloAreas = Split(g_CadenaFiltro, ",")
        ''    fechaIni = arregloAreas(0).ToString
        ''    fechaFin = arregloAreas(1).ToString
        ''    Prioridad = arregloAreas(2).ToString
        ''    For i = 3 To UBound(arregloAreas) - 1
        ''        areas = areas & arregloAreas(i) & ","
        ''    Next
        ''    aareas = Mid(areas, 1, areas.Length - 1)
        ''    dtv_resp.Table.Clear()
        ''End If

        ''Dim area_aux As String()

        ''area_aux = Split(aareas, ",")
        ' ''USANDO EL BUSCAR
        ''If g_CadenaFiltro <> "" Then
        ''    dtv_resp.Table.Clear()
        ''    lst_pedidos.Items.Clear()

        ''    dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, area_aux(2), 1, Trim(Prioridad), g_str_unidad, "", ped_id)
        ''    ''dts_lista = opr_res.LlenaListPedidoPaciente(lst_pedidos, CInt(CadenaFiltro))
        ''    If dts_lista.Tables.Count > 0 Then
        ''        btn_Validar.Enabled = True
        ''        'btn_Plantilla.Enabled = True
        ''        btn_NotaExa.Enabled = True
        ''    Else
        ''        btn_Validar.Enabled = False
        ''        'btn_Plantilla.Enabled = False
        ''        btn_NotaExa.Enabled = False
        ''    End If
        ''End If

    End Sub


    Private Sub btn_NotaExa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NotaExa.Click
        Dim msg As String = Nothing
        Dim tes_id As Integer
        Dim tes_abrev As String = Nothing

        Dim opr_pedido As New Cls_Pedido()
        If Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22).ToString()) <> Nothing Then
            Dim Idtest As Integer = Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22))
            Dim comentario As String = ""
            msg = "Ingrese la nota para " & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString())

            comentario = InputBox(msg, "ANALISYS")

            If comentario <> "" Then
                tes_abrev = opr_pedido.LeerNombreTest2(Idtest, "MUJER")
                If tes_abrev = Nothing Then
                    tes_abrev = opr_pedido.LeerNombreTest2(Idtest, "HOMBRE")
                End If
                opr_ped.InsertarNotaExamen(CInt(lbl_pedidoD.Text), tes_abrev, comentario)
                If dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 6) Is DBNull.Value Then
                    opr_ped.InsertarResExamen(CInt(lbl_pedidoD.Text), tes_abrev)
                End If
            End If
        End If
        If True Then

        End If

    End Sub

    Private Sub btn_Plantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Plantilla.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor


        Me.Tag = ""
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        Dim testcod As String
        On Error Resume Next
        If (lbl_pedidoD.Text <> "Pedido" And lbl_pedidoD.Text <> "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim shr_x As Short = 0
            Dim int_codigo As Integer = 0
            Dim estavalidado As Integer
            Dim dtv_resauto As New DataView()
            Dim str_opera As String
            dtv_resauto = dgrd_resPedido.DataSource
            'For shr_x = 0 To (dtt_res.Rows.Count)
            For shr_x = 0 To ((dtv_resauto.Table.Rows.Count) - 1)
                int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), dgrd_resPedido(shr_x, 14))
                estavalidado = opr_trabajo.Leer_Validado(int_codigo)

                Select Case estavalidado
                    Case 0, 1, 2
                        If ((IsDBNull(dgrd_resPedido(shr_x, 6)) = False) And (Convert.ToString(dgrd_resPedido(shr_x, 6)) <> "")) Then
                            If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                                opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 14), 1, Trim(dgrd_resPedido(shr_x, 11)))
                                str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                                'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADO", CStr(dgrd_resPedido(shr_x, 6)) & "=" & Trim(dgrd_resPedido(shr_x, 9)), g_sng_user, lbl_pedidoD.Text, "", CStr(dgrd_resPedido(shr_x, 6)))
                                opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                            End If
                        End If
                    Case 9
                        If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                            opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 14), 9, Trim(dgrd_resPedido(shr_x, 11)))

                            str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                            'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADO", CStr(dgrd_resPedido(shr_x, 6)) & "=" & Trim(dgrd_resPedido(shr_x, 9)), g_sng_user, lbl_pedidoD.Text, "", CStr(dgrd_resPedido(shr_x, 6)))
                            opr_trabajo.CambioEstadoItemLista(int_codigo, 9) ' ESTADO 9 remitido 
                            opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)
                        End If

                End Select


            Next
        End If
        btn_Plantilla.Enabled = False
        dts_lista.AcceptChanges()

        Dim frm_MDIChild As New frm_Ing_Plantilla
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.lbl_pacD.Text = lbl_pacienteD.Text
        frm_MDIChild.DatosTag = lbl_pacienteD.Tag & "º" & lbl_fechaD.Text
        frm_MDIChild.ReceptaAreas = aareas
        frm_MDIChild.filtroOrdenes = filtroOrdenes
        frm_MDIChild.abrev = dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4)
        frm_MDIChild.ped_fecing = dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(0).ToString
        frm_MDIChild.Indice = lst_pedidos.SelectedIndex
        frm_MDIChild.ShowDialog(Me.ParentForm)
        '''''***

        Me.Tag = "ped_turno= " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString & "/*/ped_fecing=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(0).ToString & "/*/pac_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString & "/*/pac_fecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(4).ToString & "/*/ped_antecedentes=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(5).ToString & "/*/ped_medicacion=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(6).ToString & "/*/med_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(8).ToString & "/*/ped_nota=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(9).ToString & "/*/ped_id=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & "/*/pac_usafecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(11).ToString & "/*/pac_doc=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(12).ToString '& "/*/ped_indice=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString
        Me.llena_datos("Validacion")

        filtroOrdenes = "PorValidar"
        lst_pedidos.Items.Clear()
        dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), ConvenioSecuencia, op_filtro, , filtroOrdenes)

        If dts_lista.Tables.Count > 0 Then
            btn_Validar.Enabled = True
            'btn_Plantilla.Enabled = True
            btn_NotaExa.Enabled = True
        Else
            btn_Validar.Enabled = False
            'btn_Plantilla.Enabled = False
            btn_NotaExa.Enabled = False
        End If
        'Me.Activate()
        ''End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub btn_Validar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        'BTN VALIDAR
        Me.Tag = ""
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        Dim testcod As String
        On Error Resume Next
        If (lbl_pedidoD.Text <> "Pedido" And lbl_pedidoD.Text <> "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'If MsgBox("Los cambios realizados en los resultados automaticos y las" & Chr(13) & "notas sobre los resultados del pedido seran almacenadas" & Chr(13) & "en este momento, desea continuar?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'opr_ped.InsertarNotaPedido(CInt(lbl_pedidoD.Text), txt_notaArea.Text)
            'opr_res.ActualizarResMan(CInt(lbl_pedidoD.Text), txt_ResMan.Text)
            Dim shr_x As Short = 0
            Dim int_codigo As Integer = 0
            Dim estavalidado As Integer
            Dim dtv_resauto As New DataView()
            Dim str_opera As String
            dtv_resauto = dgrd_resPedido.DataSource
            'For shr_x = 0 To (dtt_res.Rows.Count)
            For shr_x = 0 To ((dtv_resauto.Table.Rows.Count) - 1)
                int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), dgrd_resPedido(shr_x, 14))
                estavalidado = opr_trabajo.Leer_Validado(int_codigo)

                Select Case estavalidado
                    Case 0, 1, 2
                        If ((IsDBNull(dgrd_resPedido(shr_x, 6)) = False) And (Convert.ToString(dgrd_resPedido(shr_x, 6))) <> "") Then
                            'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADO", CStr(dgrd_resPedido(shr_x, 6)) <> "")) Then
                            If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                                opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 10)), dgrd_resPedido(shr_x, 14), 1, Trim(dgrd_resPedido(shr_x, 24)))

                                str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6)) & " = " & CStr(Trim(dgrd_resPedido(shr_x, 9)) & g_sng_user & lbl_pedidoD.Text & "" & CStr(dgrd_resPedido(shr_x, 6)))
                                opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                            End If
                        End If
                    Case 9
                        If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                            opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 10)), dgrd_resPedido(shr_x, 14), 9, Trim(dgrd_resPedido(shr_x, 24)))

                            str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                            'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADO", CStr(dgrd_resPedido(shr_x, 6)) & "=" & Trim(dgrd_resPedido(shr_x, 9)), g_sng_user, lbl_pedidoD.Text, "", CStr(dgrd_resPedido(shr_x, 6)))
                            opr_trabajo.CambioEstadoItemLista(int_codigo, 9) ' ESTADO 9 remitido 
                            opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)
                        End If

                End Select

            Next
            If Not ExisteForm("frm_ValFinal") Then
                Dim frm_MDIChild As New frm_ValFinal()
                frm_MDIChild.frm_refer_main = Me.ParentForm
                frm_MDIChild.Tag = lbl_pedidoD.Text & "," & lbl_ordenMIS.Text & "," & Trim(lbl_pac_idD.Text)
                frm_MDIChild.aareas = aareas
                frm_MDIChild.LabOcup = LabOcup
                frm_MDIChild.Convenio = lbl_Convenio.Text
                frm_MDIChild.ShowDialog(Me.ParentForm)
            End If
            '*****CODIGO PARA IMPRIMIR LO VALIDADO FIN 

            '*****CODIGO PARA IMPRIMIR LO VALIDADO FIN 
            LimpiarCamposVR()

            lst_pedidos.Items.Clear()
            dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), ConvenioSecuencia, op_filtro, , filtroOrdenes)

            If dts_lista.Tables.Count > 0 Then
                btn_Validar.Enabled = True
                'btn_Plantilla.Enabled = True
                btn_NotaExa.Enabled = True
            Else
                btn_Validar.Enabled = False
                'btn_Plantilla.Enabled = False
                btn_NotaExa.Enabled = False
            End If

            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Else
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        End If
    End Sub

    Private Sub btn_historico_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_historico.Click
        On Error Resume Next
        If IsDBNull(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 3).ToString) Then
            MsgBox("No ha seleccionado ninguna prueba para consultar.", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            Dim arr_data() As String
            Dim str_sql As String = ""
            Dim str_tag = lbl_pacienteD.Tag & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString) & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 14).ToString) & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 14).ToString) & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 23).ToString)
            arr_data = Split(str_tag, ",")
            Dim obj_reporte As New rpt_ImpHist()

        
            If Not ExisteForm("frm_historico") Then
                Dim frm_MDIChild As New frm_historico()
                frm_MDIChild.frm_refer_main = Me.ParentForm
                frm_MDIChild.reporte = "Historico"
                frm_MDIChild.Tag = lbl_pacienteD.Tag & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString) & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 14).ToString) & "," & Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 22).ToString)
                frm_MDIChild.ShowDialog(Me.ParentForm)
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub


    Public Sub Crea_formulario(ByVal FrM_MDIChild As Form, Optional ByVal frm_Padre As Form = Nothing)
        'se usa el parametro opcional, cuando se crea la forma desde otro form que se encuentra como modal
        Dim menuItem As New MenuItem()
        If IsNothing(frm_Padre) Then
            FrM_MDIChild.MdiParent = Me
        Else
            FrM_MDIChild.MdiParent = frm_Padre
        End If
        'If ExisteForm(FrM_MDIChild.Name) Then
        'FrM_MDIChild.Close()
        'End If
        FrM_MDIChild.Show()
    End Sub



    Private Sub btn_ImprTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImprTodo.Click

        Me.Tag = ""
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        Dim testcod As String
        Dim tes_padre As Integer = 0

        'On Error Resume Next
        If (lbl_pedidoD.Text <> "Pedido" And lbl_pedidoD.Text <> "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'If MsgBox("Los cambios realizados en los resultados autom�ticos y las" & Chr(13) & "notas sobre los resultados del pedido ser�n almacenadas" & Chr(13) & "en este momento, desea continuar?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'opr_ped.InsertarNotaPedido(CInt(lbl_pedidoD.Text), txt_notaArea.Text)
            'opr_res.ActualizarResMan(CInt(lbl_pedidoD.Text), txt_ResMan.Text)
            Dim shr_x As Short = 0
            Dim int_codigo As Integer = 0
            Dim estavalidado As Integer
            Dim dtv_resauto As New DataView()
            Dim str_opera As String
            dtv_resauto = dgrd_resPedido.DataSource
            'For shr_x = 0 To (dtt_res.Rows.Count)
            For shr_x = 0 To ((dtv_resauto.Table.Rows.Count) - 1)
                int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), dgrd_resPedido(shr_x, 14))
                estavalidado = opr_trabajo.Leer_Validado(int_codigo)

                
                Select Case estavalidado
                    Case 0, 1, 2
                        If ((IsDBNull(dgrd_resPedido(shr_x, 6)) = False) And (Convert.ToString(dgrd_resPedido(shr_x, 6)) <> "")) Then
                            
                            opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 14), 1, Trim(dgrd_resPedido(shr_x, 11)))
                            str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_resPedido.Item(shr_x, 4).ToString()), CInt(lbl_pedidoD.Text))
                            opr_pedido.ActualizarLis_resEstadoPreliminar(CInt(lbl_pedidoD.Text), tes_padre, 0, Format(Now, "dd/MM/yyyy HH:mm"))    'NO PROCESADO PARA PREMILIMINAR)


                            'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADO", CStr(dgrd_resPedido(shr_x, 6)) & "=" & Trim(dgrd_resPedido(shr_x, 9)), g_sng_user, lbl_pedidoD.Text, "", CStr(dgrd_resPedido(shr_x, 6)))
                            opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                        End If
                    Case 9
                        If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                            opr_res.ResAutoFinal(CInt(lbl_pedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 14), 9, Trim(dgrd_resPedido(shr_x, 11)))
                            str_opera = lbl_pedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))

                            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_resPedido.Item(shr_x, 4).ToString()), CInt(lbl_pedidoD.Text))
                            opr_pedido.ActualizarLis_resEstadoPreliminar(CInt(lbl_pedidoD.Text), tes_padre, 0, Format(Now, "dd/MM/yyyy HH:mm"))    'NO PROCESADO PARA PREMILIMINAR)


                            'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADO", CStr(dgrd_resPedido(shr_x, 6)) & "=" & Trim(dgrd_resPedido(shr_x, 9)), g_sng_user, lbl_pedidoD.Text, "", CStr(dgrd_resPedido(shr_x, 6)))
                            opr_trabajo.CambioEstadoItemLista(int_codigo, 9) ' ESTADO 9 remitido 
                            opr_pedido.ActualizarPdd_Estado(CInt(lbl_pedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)
                        End If

                End Select


            Next
        End If
        'btn_Plantilla.Enabled = False
        'dts_lista.AcceptChanges()

        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        Else
            'frm_refer_main_form.escribemsj("INICIANDO GENERACI�N DE REPORTE")
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            '(*)funci�n no utilizada para el club de leones y PUCE por que ellos no usan facturaci�n
            'chequea que la factura del pedido se encuentre cancelada
            '(*)Select Case opr_pedido.LeerPedEstadoFactura(CInt(lbl_pedidoD.Text))
            '0 emitido, 1 abonada, 2 cancelada, 3 anulada
            '(*)Case 0, 1
            '(*)MsgBox("El pedido no tiene cancelado sus valores", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 3
            '(*)MsgBox("El pedido tiene su factura anulada, no puede continuar el proceso", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 2
            'C�digo que actualiza el campo ped_estado a 4 --> Pedido impreso y entregado
            'If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
            '    If MsgBox("El pedido ya fue impreso, desea imprimirlo nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
            '        Exit Sub
            '    End If
            'End If
            'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
            If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
            End If
            'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            cls_operacion.sql_conectar()

            'En el campo TIPO, trae a donde pertenece el dato:
            '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
            '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
            '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 


            Dim opr_resul As New Cls_Resultado()
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            Dim tim_id As Integer = 0

            Dim NotaArea As String = Nothing
            Dim g_validadorID As String = Nothing
            Dim g_validador As String = Nothing
            Dim str_Sql As String = Nothing
            Dim archivos As String = Nothing
            Dim archivoQR As String = Nothing


            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            'g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
            'g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
            'Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            'Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            ''tim_id = Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 21).ToString())
            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString()), CInt(lbl_pedidoD.Text))

         
            opr_user.LeerAreasUsuario(g_sng_user, arr_datos, LabOcup, str_Areas, arr_nombre)

            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If


            Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")

            str_Sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

            Dim dts_histograma As New DataSet()
            Dim str_his As String = "NOHISTOGRAMA"
            Dim str_img As String = "NOIMAGEN"


            'AQUI 09
            'archivos = opr_res.ConsultaPathFiles(str_sql)

            If archivos <> "" Then

                Dim tramaTXT As String
                Dim NombreArchivo As String


                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSMS")
                DiffimageLSMS.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSMS", NombreArchivo)
                opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSMS", NombreArchivo)
                tramaTXT = ""

                ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSHS")
                ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSHS", NombreArchivo)
                ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSHS", NombreArchivo)
                ''tramaTXT = ""

                ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageHSMS")
                ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageHSMS", NombreArchivo)
                ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageHSMS", NombreArchivo)
                ''tramaTXT = ""

                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageBASO")
                DiffimageBASO.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageBASO", NombreArchivo)
                opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageBASO", NombreArchivo)
                tramaTXT = ""

                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "WBCImage")
                WBCImage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "WBCImage", NombreArchivo)
                opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "WBCImage", NombreArchivo)
                tramaTXT = ""

                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "RBCimage")
                RBCimage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "RBCimage", NombreArchivo)
                opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "RBCimage", NombreArchivo)
                tramaTXT = ""

                tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "PLTimage")
                PLTimage.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "PLTimage", NombreArchivo)
                opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "PLTimage", NombreArchivo)
                tramaTXT = ""




                ''str_sql = "SELECT  pedido.PED_ID, File_DiffimageLSMS, File_DiffimageLSHS, File_DiffimageHSMS, File_DiffimageBASO, file_RBCimage, file_PLTimage, File_WBCimage " & _
                ''"FROM pedido, ptohistograma " & _
                ''"where pedido.ped_id = ptohistograma.ped_id  " & _
                ''"and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                'str_sql = "SELECT  pedido.PED_ID, File_DiffimageLSMS, File_DiffimageLSHS, File_DiffimageHSMS, File_DiffimageBASO, file_RBCimage, file_PLTimage, File_WBCimage " & _
                '"FROM pedido, ptohistograma " & _
                '"where pedido.ped_id = ptohistograma.ped_id  " & _
                '"and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                str_Sql = "SELECT  pedido.PED_ID, file_WBCimage, file_RBCimage, file_PLTimage " & _
                "FROM pedido, ptohistograma " & _
                "where pedido.ped_id = ptohistograma.ped_id  " & _
                "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                archivos = opr_res.ConsultaPathFilesImg(str_Sql)
                dts_histograma = ReturnDataSet(archivos)
            End If

            If dts_histograma.Tables.Count >= 1 Then
                str_his = "HISTOGRAMA"
            Else
                str_his = "NOHISTOGRAMA"
            End If


            '' '' '' ''******** CONSULTO SI TIENE QR ******
            str_Sql = "SELECT  pedido.PED_ID, img_base64 " & _
               "FROM pedido, ptoImagen " & _
               "where pedido.ped_id = ptoImagen.ped_id  " & _
               "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.img_nombre  = 'QR'"

            Dim dts_imagen As New DataSet()
            ''Dim str_img As String = "NOIMAGEN"

            archivoQR = opr_res.ConsultaPathFilesImagenQR(str_Sql)

            ' archivoQR = Nothing

            If archivoQR <> "" Then
                archivos = Nothing
                Dim tramaTXT As String
                Dim NombreArchivo As String


                tramaTXT = opr_resul.ConsultaImagen(CInt(lbl_pedidoD.Text), "QR")
                Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "", NombreArchivo)
                opr_resul.GuardarImagenOcupacional(CInt(lbl_pedidoD.Text), "QR", NombreArchivo)
                tramaTXT = ""

                str_Sql = "SELECT  pedido.PED_ID,  img_file " & _
                     "FROM pedido, ptoImagen " & _
                     "where pedido.ped_id = ptoImagen.ped_id  " & _
                     "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptoImagen.Img_NOMBRE = 'QR'"

                archivos = opr_res.ConsultaPathFilesImgOcupacional(str_Sql)
                dts_imagen = ReturnDataSetOcup(archivos)
            End If

            If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                Try
                    If dts_imagen.Tables.Count >= 1 Then
                        str_img = "IMAGEN"
                        ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                    Else
                        str_img = "NOIMAGEN"
                    End If
                Catch
                    If IsDBNull(dts_imagen) = False Then
                        Select Case opr_pedido.ContarRegImagen(CLng(lbl_pedidoD.Text))
                            Case 0
                                If opr_pedido.LeeTipoImg(CLng(lbl_pedidoD.Text), "IMAGEN") = 0 Then
                                    opr_pedido.InsertarRegImagen(CLng(lbl_pedidoD.Text), "IMAGEN")
                                End If
                            Case 1
                                If dts_imagen.Tables.Count >= 1 Then
                                    str_img = "IMAGEN"
                                Else
                                    str_img = "NOIMAGEN"
                                End If
                        End Select
                    Else
                        str_img = "NOIMAGEN"
                    End If
                End Try
            End If


            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA

            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA

            str_Sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, " & _
                "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end AS resultado2, RES_PROCESADOS.PRC_ALARMA as Alarma, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
                "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
                "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
                "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
            "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id  " & _
                "FROM AREA INNER JOIN (UNIDAD " & _
                "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO " & _
                    "WHERE TEST_RESULTADO.RES_ID <>1 AND RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID and test.are_id <> 83 "
            str_Sql = str_Sql & str_aux
            str_Sql = str_Sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                    "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2,'' as Alarma, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                    "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                    "'' AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                    "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, pedido.PED_RECIBO AS CONVENIO, " & _
                    "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                    "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' as RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id " & _
            "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
            "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
            "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
            "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
            "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "

            str_Sql = str_Sql & " order by AREA.ARE_OBS, test.TES_ORDENIMP, RES_PROCESADOS.TIM_ID "

            'str_Sql = str_Sql & " order by AREA.ARE_OBS asc, RES_PROCESADOS.TIM_ID, test.TES_ORDENIMP "
            oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")
            cls_operacion.sql_desconn()


            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


            'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")
            'Dim dts_histograma As New DataSet()
            'Dim str_his As String = "NOHistograma"



            ''quemado
            lbl_LabId.Text = "1"

            '******Dependiendo si existe o no histograma va el campo Histograma
            'If carga_histograma(dts_histograma) Then str_his = "Histograma"

            '' ''If System.Configuration.ConfigurationSettings.AppSettings("FIRMADUAL") = True Then
            '' ''    If MsgBox("Desea visualizar por Area o Continuo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            '' ''        obj_reporte = New rpt_entregaContinua()
            '' ''    Else
            '' ''        obj_reporte = New rpt_entregaContinua2()
            '' ''    End If
            '' ''Else
            '' ''    obj_reporte = New rpt_entregaContinua()
            '' ''End If

            Dim obj_reporte As New Object
            obj_reporte = New rpt_entregaresultadosP()


            Dim FrmMain As New Frm_Main

            Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
            frm_MDIChild.int_alto = 650
            frm_MDIChild.int_ancho = 1360
            frm_MDIChild.StartPosition = FormStartPosition.CenterParent
            frm_MDIChild.Text = "Preliminar de Resultados"
            frm_MDIChild.ShowDialog(Me.ParentForm)
        
            g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME TODO", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Public Function ReturnDataSet(ByVal files As String) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "\")

        pathImg = Environment.CurrentDirectory & "\" & g_pathFolderImg

        dt.Columns.Add(New DataColumn("Codigo", GetType(Short)))
        dt.Columns.Add(New DataColumn("Codigo2", GetType(Short)))
        dt.Columns.Add(New DataColumn("Codigo3", GetType(Short)))

        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt.Columns.Add(New DataColumn("Descripcion2", GetType(String)))
        dt.Columns.Add(New DataColumn("Descripcion3", GetType(String)))

        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen2", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen3", GetType(Byte())))


        dr = dt.NewRow()
        dr("Codigo") = 1
        dr("Descripcion") = "WBC"
        dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(0)))
        'dt.Rows.Add(dr)

        'dr = dt.NewRow()
        dr("Codigo2") = 2
        dr("Descripcion2") = "RBC"
        dr("Imagen2") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(1)))
        'dt.Rows.Add(dr)

        'dr = dt.NewRow()
        dr("Codigo3") = 3
        dr("Descripcion3") = "PLT"
        dr("Imagen3") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(2)))

        dt.Rows.Add(dr)


        ds.Tables.Add(dt)
        ds.Tables(0).TableName = "Imagenes"

        Dim iDS As New dsImagenes
        iDS.Merge(ds, False, System.Data.MissingSchemaAction.Ignore)
        Return iDS
    End Function

    Public Function ImageToByte(ByVal pImagen As Image) As Byte()
        Dim mImage() As Byte
        Try
            If Not IsNothing(pImagen) Then
                Dim ms As New System.IO.MemoryStream
                pImagen.Save(ms, pImagen.RawFormat)
                mImage = ms.GetBuffer
                ms.Close()
                Return mImage
            End If
        Catch
        End Try
    End Function



    Public Function ReturnDataSetOcup(ByVal files As String) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "\")

        pathImg = Environment.CurrentDirectory & "\" & g_pathFolderQR

        dt.Columns.Add(New DataColumn("Codigo", GetType(Short)))
        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))


        dr = dt.NewRow()
        dr("Codigo") = 1
        dr("Descripcion") = "QR"
        dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(0)))
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)
        ds.Tables(0).TableName = "ImagenesQR"

        Dim iDS As New dsImgOcup
        iDS.Merge(ds, False, System.Data.MissingSchemaAction.Ignore)
        Return iDS
    End Function


    Public Function Base64ToImage(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte()
        Try
            imageBytes = Convert.FromBase64String(Base64Code)

            'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            If numorden <> "" Then

                NombreArchivo = nombre_tipo & numorden & ".gif"

                If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo

                'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

                If File.Exists(vFileName) Then
                    'File.Delete(vFileName)
                    EliminaArchivoTxt(vFileName)
                End If
                'diskOpts.DiskFileName = vFileName

                File.WriteAllBytes(vFileName, imageBytes)


                Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
                Dim tmpImage As Image = Image.FromStream(ms, True)
                'NombreArchivo = vFileName

                Return tmpImage
            End If
        Catch

        End Try

    End Function

    Public Function EliminaArchivoTxt(ByVal ruta_archivo As String) As Boolean
        Try
            If File.Exists(ruta_archivo) Then
                ':::Eliminamos el archivo TXT
                File.Delete(ruta_archivo)
                'MsgBox("Archivo eliminado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")

            Else
                'MsgBox("No se encuentra el archivo especificado", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            End If
        Catch ex As Exception
            'MsgBox("Se presento un problema al eliminar el archivo: " & ex.Message, MsgBoxStyle.Critical, "AnalisysLAb")
        End Try
    End Function


    Public Function Base64ToImageOcupacional(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte()
        Try
            imageBytes = Convert.FromBase64String(Base64Code)

            'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            If numorden <> "" Then

                NombreArchivo = nombre_tipo & numorden & ".jpg"

                If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\" & g_pathFolderQR & "\" & NombreArchivo

                'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

                If File.Exists(vFileName) Then
                    File.Delete(vFileName)
                    'EliminaArchivoTxt(vFileName)
                End If
                'diskOpts.DiskFileName = vFileName

                File.WriteAllBytes(vFileName, imageBytes)


                Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
                Dim tmpImage As Image = Image.FromStream(ms, True)
                'NombreArchivo = vFileName

                Return tmpImage
            End If
        Catch

        End Try

    End Function




    Private Sub btn_ImpArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (lbl_pedidoD.Text = "") Then
            MsgBox("No ha seleccionado ningun pedido", MsgBoxStyle.Information, "ANALISYS")
        Else
            'frm_refer_main_form.escribemsj("INICIANDO GENERACI�N DE REPORTE")
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim opr_pedido As New Cls_Pedido()
            '(*)funci�n no utilizada para el club de leones y PUCE por que ellos no usan facturaci�n
            'chequea que la factura del pedido se encuentre cancelada
            '(*)Select Case opr_pedido.LeerPedEstadoFactura(CInt(lbl_pedidoD.Text))
            '0 emitido, 1 abonada, 2 cancelada, 3 anulada
            '(*)Case 0, 1
            '(*)MsgBox("El pedido no tiene cancelado sus valores", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 3
            '(*)MsgBox("El pedido tiene su factura anulada, no puede continuar el proceso", MsgBoxStyle.Information, "ANALISYS")
            '(*)Case 2
            'C�digo que actualiza el campo ped_estado a 4 --> Pedido impreso y entregado
            If (opr_pedido.LeerPedEstado(CInt(lbl_pedidoD.Text)) = 4) Then
                If MsgBox("El pedido ya fue impreso, desea imprimirlo nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            'frm_refer_main_form.escribemsj("ACTUALIZANDO ESTADO")
            If opr_pedido.todasPruebasValidadas(CInt(lbl_pedidoD.Text)) = 0 Then
                opr_pedido.ActualizarEstadoPedido(CInt(lbl_pedidoD.Text), 4)
            End If
            'frm_refer_main_form.escribemsj("CONSULTANDO DATOS")
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
            cls_operacion.sql_conectar()
            'frm_refer_main_form.escribemsj("CONSULTANDO TEST...")
            'Este select sirve para extraer los datos del los test con equipos
            'OJO: el primer select trae el rango como resultado2, esto ocurre, porque los campos son blob, y da un problema de casting
            'con los otros select en la columna resultado2. Los otros dos select que son parte del union, estos otros select si traen el resultado2,
            'en el 1er select resultado1 trae los resultados, en el 2do y 3ero el campo resultado2 trae los resultados
            'En el campo TIPO, trae a donde pertenece el dato:
            '1: test por equipo --> Describe los resultados, realizados en el 1er select, que trae todos los datos del RES_PROCESADOS, osea los realizados en equipo, incluidas las biometr�as que se ingresaron manualmente
            '2: test manual --> Describe los resultados, realizados en el 2do select, que trae todos los datos de LISTA_TRABAJO, osea los realizados manualmente
            '3: test equipo pero hecho manualmente --> Describe los resultados, realizados en el 3er select, que trae todos los datos de LISTA_TRABAJO, que se deben hacer en equipo, pero se lo ha hecho manualmente, excepto las biometr�as, TEST.TES_TPROCES = 1 AND TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' and LISTA_TRABAJO.EQU_ID IS NULL 


            Dim opr_resul As New Cls_Resultado()
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            Dim tim_id As Integer = 0
            Dim tes_padre As Integer = 0
            Dim NotaArea As String = Nothing
            Dim g_validadorID As String = Nothing
            Dim g_validador As String = Nothing


            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            'g_validadorID = opr_user.LeerValidador(lbl_pedidoD.Text)
            'g_validador = opr_invitado.ConsultaFirmaInvitado(g_validadorID)
            'Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            'Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)

            ''tim_id = Trim(dgrd_ResPedido.Item(dgrd_ResPedido.CurrentCell.RowNumber, 21).ToString())
            tes_padre = opr_pedido.LeerIdPadreTest(Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString()), CInt(lbl_pedidoD.Text))



            opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_Areas, arr_nombre)
            
            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If
            'CODIGO PARA SOLO IMPRIMIR LO QUE PERMETECE A MI AREA

            Dim str_Sql As String = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
                "case when (RES_PROCESADOS.PRC_ALARMA = '*') then ('* '+ RES_PROCESADOS.PRC_RESFINAL) when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, " & _
                "case when (RES_PROCESADOS.PRC_ALARMA = '*') then ('* '+ RES_PROCESADOS.PRC_RESFINAL) else case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end end AS resultado2, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
                "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as fec_nac, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, PEDIDO.CON_NOMBRE AS CONVENIO," & _
                "case when (PEDIDO.PED_ESTADO = 4)  then ('COPIA DEL INFORME') else '' end AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, PEDIDO.ped_antecedente as observaciones, " & _
                "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
                "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
            "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, test.TES_OBS as metodo, RES_PROCESADOS.TIM_ID " & _
                "FROM AREA INNER JOIN (UNIDAD " & _
                "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
                "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
                "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
                "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
                "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID " & _
                    "WHERE RES_PROCESADOS.PED_ID=" & lbl_pedidoD.Text & " AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
                "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre  "
            str_Sql = str_Sql & str_aux
            str_Sql = str_Sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                    "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                    "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                    "'' AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                    "PACIENTE.pac_fecnac as fec_nac, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' AS edad, PEDIDO.CON_NOMBRE AS CONVENIO, " & _
                    "case when (PEDIDO.PED_ESTADO) = 4 then ('COPIA DEL INFORME') else ('') end AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, PEDIDO.ped_antecedente as observaciones, resAB_procesados.LIS_user as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                    "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID " & _
            "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
            "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & lbl_pedidoD.Text & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
            "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
            "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
            "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "

            str_Sql = str_Sql & " order by RES_PROCESADOS.TIM_ID, test.TES_ORDENIMP "

            oda_operacion.SelectCommand = New SqlCommand(str_Sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")
            cls_operacion.sql_desconn()


            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            Dim dtt_resAB As New DataTable("RegistrosRESAB")
            Dim dtv_resAB As New DataView(dtt_resAB)


            dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


            'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")
            Dim dts_histograma As New DataSet()
            Dim str_his As String = "NOHistograma"
            Dim obj_reporte As New Object


            ''quemado
            lbl_LabId.Text = "1"
            '******Dependiendo si existe o no histograma va el campo Histograma
            If carga_histograma(dts_histograma) Then str_his = "Histograma"

            'Select Case lbl_LabId.Text
            '   Case "1", "2"
            obj_reporte = New rpt_entregaresultados()
            '   Case "3"
            'obj_reporte = New rpt_entregaresultadosCMR()
            'End Select

            Dim frm_MDIChild As New Frm_reportes(str_his, "", obj_reporte, dts_operacion, dts_histograma, dts_histograma, dts_operaAB, True, 1)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Emision de Resultados"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)
            '(*)End Select
            'frm_refer_main_form.escribemsj("DISPONIBLE")
            Me.Cursor = System.Windows.Forms.Cursors.Default
            g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIME POR AREA", "PEDIDO=" & lbl_pedidoD.Text, g_sng_user, lbl_pedidoD.Text, "", "")
        End If
    End Sub



    Private Sub rbtn_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_Todos.CheckedChanged

        '0 INGRESADO
        '2 ANULADO
        '3 VALIDADO COMPLETO
        '4 IMPRESO
        '5 VALIDADO Incompletos
        '6 ENVIADO CORREO

        If rbtn_Todos.Checked Then
            op_filtro = " (0,1,3,4,5,6) "
        End If

        For i = 5 To UBound(arregloAreas) - 1
            areas = areas & arregloAreas(i) & ","
        Next
        aareas = Mid(areas, 1, areas.Length - 1)

        filtroOrdenes = "Todos"
        'dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), g_str_unidad, op_filtro)
        dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), g_ConvenioSecuencia, op_filtro, 0, filtroOrdenes)
        ' dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), ConvenioSecuencia, op_filtro, 0, filtroOrdenes)
    End Sub

    Private Sub rbtn_PorValidar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_PorValidar.CheckedChanged
        '0 INGRESADO
        '2 ANULADO
        '3 VALIDADO COMPLETO
        '4 IMPRESO
        '5 VALIDADO Incompletos
        '6 ENVIADO CORREO

        Dim a_rea As String()
        If rbtn_PorValidar.Checked Then
            op_filtro = " (5,0) "
        End If
        If aareas <> Nothing Then
            a_rea = Split(aareas, ",")
            If UBound(a_rea) > 1 Then
                aareas = a_rea(2)
            Else
                aareas = a_rea(0)
            End If
        End If

        filtroOrdenes = "PorValidar"

        dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), g_ConvenioSecuencia, op_filtro, 0, filtroOrdenes)
        'dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), g_str_unidad, op_filtro)

    End Sub

    Private Sub rbtn_Imcompletos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_Imcompletos.CheckedChanged
        '0 INGRESADO
        '2 ANULADO
        '3 VALIDADO COMPLETO
        '4 IMPRESO
        '5 VALIDADO Incompletos
        '6 ENVIADO CORREO


        If rbtn_Imcompletos.Checked Then
            op_filtro = " (5) "
        End If
        dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), g_ConvenioSecuencia, op_filtro, 0, filtroOrdenes)
        'dts_lista = opr_res.LlenaListPedido(lst_pedidos, fechaIni, fechaFin, aareas, 1, Trim(Prioridad), g_str_unidad, op_filtro)

    End Sub

    Private Sub lst_pedidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_pedidos.SelectedIndexChanged
        btn_Plantilla.Enabled = False
       

        If dts_lista.Tables(0).Rows.Count > 0 Then
            'btn_NotaExa.Visible = True
            'btn_Editar.Visible = True
            btn_Validar.Visible = True
            btn_Paciente.Visible = True
            btn_Plantilla.Visible = True
        Else
            'btn_NotaExa.Visible = False
            'btn_Editar.Visible = False
            btn_Validar.Visible = False
            btn_Paciente.Visible = False
            btn_Plantilla.Visible = False
        End If

        Me.Tag = ""
        Me.Tag = "ped_turno= " & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString & "/*/ped_fecing=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(0).ToString & "/*/pac_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(3).ToString & "/*/pac_fecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(4).ToString & "/*/ped_antecedentes=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(5).ToString & "/*/ped_medicacion=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(6).ToString & "/*/med_nombre=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(7).ToString & "/*/ped_nota=" & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(9).ToString) & "/*/ped_id=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(10).ToString & "/*/pac_usafecnac=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(11).ToString & "/*/pac_doc=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(12).ToString & "/*/ped_orden=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(13).ToString & "/*/LAB=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(16).ToString & "/*/OBS=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(19).ToString & "/*/servicio=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(20).ToString & "/*/ped_obs=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(22).ToString & "/*/ped_tipo=" & dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(23).ToString

        Me.llena_datos("Validacion")


        Me.Activate()



    End Sub

    Private Sub btn_NotaExa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim msg As String = ""
        Dim tes_id As Integer
        Dim opr_pedido As New Cls_Pedido()
        If Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString()) <> Nothing Then
            Dim nombretest As String = Trim(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 4).ToString())
            Dim comentario As String = ""
            msg = "Ingrese el comentario para " & nombretest

            comentario = InputBox(msg, "ANALISYS")
            If comentario <> "" Then
                tes_id = opr_pedido.LeerNombreTest(nombretest)
                opr_ped.InsertarNotaExamen(CInt(lbl_pedidoD.Text), tes_id, comentario)
            End If
        End If
        If True Then

        End If
    End Sub


    Private Sub dgrd_resPedido_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim ii As Integer
        'For ii = 0 To dtv_resp.Count - 1
        'If (opr_res.LeerFormula(dtv_resp.Item(ii).Row(21).ToString) <> "") Then
        'opr_res.EjecutaFormula(dtv_resp.Item(ii).Row(21), opr_res.LeerFormula(dtv_resp.Item(ii).Row(21)), Replace(str_campos(8), "ped_id=", ""))
        'Else
        'End If
        'Next

    End Sub



    
   
    

End Class