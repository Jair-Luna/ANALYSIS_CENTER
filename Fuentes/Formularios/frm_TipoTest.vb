'*************************************************************************
' Nombre:   frm_TipoTest
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para la administracion de la tabla Tipo_Test
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2012

' Ultima Modificaci�n: 25/02/2014
' Proyecto TRUESOLUTIONS
'*************************************************************************
Public Class frm_TipoTest
    Inherits System.Windows.Forms.Form

#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Dim tes_idd As Integer
    Private m_HtImages As New Hashtable()
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_resultado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_Padre As System.Windows.Forms.ComboBox
    Friend WithEvents dgrd_testHijos As System.Windows.Forms.DataGrid
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
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_paramPlant As System.Windows.Forms.Button
    Friend WithEvents chk_calculadora As System.Windows.Forms.CheckBox
    Friend WithEvents chk_antiobiograma As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txt_Param As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbt_SoloTest As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents txt_ValDefecto As System.Windows.Forms.TextBox
    Friend WithEvents btn_formatos As System.Windows.Forms.Button
    Friend WithEvents chk_SolicitaHC As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Cie10 As System.Windows.Forms.Button
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

    Friend WithEvents grp_Test As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents dgrd_Test As System.Windows.Forms.DataGrid
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Obs As System.Windows.Forms.Label
    Friend WithEvents lbl_Area As System.Windows.Forms.Label
    Friend WithEvents lbl_TipRes As System.Windows.Forms.Label
    Friend WithEvents lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_Nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents txt_Obs As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Area As System.Windows.Forms.ComboBox
    Friend WithEvents Ctl_txt_Precio As Ctl_txt.ctl_txt_numeros
    Friend WithEvents lbl_muestra As System.Windows.Forms.Label
    Friend WithEvents cmb_muestra As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipProces As System.Windows.Forms.Label
    Friend WithEvents cmb_TipProces As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_unidad As System.Windows.Forms.ComboBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents cmb_equip As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_equip As System.Windows.Forms.Label
    Friend WithEvents txt_abrev As System.Windows.Forms.TextBox
    Friend WithEvents lbl_abrev As System.Windows.Forms.Label
    Friend WithEvents txt_test As System.Windows.Forms.TextBox
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_treporte As System.Windows.Forms.ComboBox
    Friend WithEvents btn_orden As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_cbarras As System.Windows.Forms.ComboBox
    Friend WithEvents txt_obs2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_param As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TipoTest))
        Me.grp_Test = New System.Windows.Forms.GroupBox
        Me.chk_SolicitaHC = New System.Windows.Forms.CheckBox
        Me.txt_ValDefecto = New System.Windows.Forms.TextBox
        Me.cmb_unidad = New System.Windows.Forms.ComboBox
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.chk_calculadora = New System.Windows.Forms.CheckBox
        Me.chk_antiobiograma = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_Padre = New System.Windows.Forms.ComboBox
        Me.cmb_resultado = New System.Windows.Forms.ComboBox
        Me.cmb_tipo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_treporte = New System.Windows.Forms.ComboBox
        Me.txt_abrev = New System.Windows.Forms.TextBox
        Me.txt_obs2 = New System.Windows.Forms.TextBox
        Me.cmb_cbarras = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_abrev = New System.Windows.Forms.Label
        Me.cmb_equip = New System.Windows.Forms.ComboBox
        Me.lbl_equip = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_TipProces = New System.Windows.Forms.ComboBox
        Me.lbl_TipProces = New System.Windows.Forms.Label
        Me.cmb_muestra = New System.Windows.Forms.ComboBox
        Me.lbl_muestra = New System.Windows.Forms.Label
        Me.Ctl_txt_Precio = New Ctl_txt.ctl_txt_numeros
        Me.cmb_Area = New System.Windows.Forms.ComboBox
        Me.txt_Obs = New System.Windows.Forms.TextBox
        Me.Ctl_txt_Nombre = New Ctl_txt.ctl_txt_letras
        Me.lbl_Precio = New System.Windows.Forms.Label
        Me.lbl_TipRes = New System.Windows.Forms.Label
        Me.lbl_Area = New System.Windows.Forms.Label
        Me.lbl_Obs = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_orden = New System.Windows.Forms.Button
        Me.dgrd_Test = New System.Windows.Forms.DataGrid
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
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.txt_test = New System.Windows.Forms.TextBox
        Me.lbl_test = New System.Windows.Forms.Label
        Me.btn_param = New System.Windows.Forms.Button
        Me.dgrd_testHijos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_paramPlant = New System.Windows.Forms.Button
        Me.txt_Param = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbt_SoloTest = New System.Windows.Forms.RadioButton
        Me.rbt_Todos = New System.Windows.Forms.RadioButton
        Me.btn_formatos = New System.Windows.Forms.Button
        Me.btn_Cie10 = New System.Windows.Forms.Button
        Me.grp_Test.SuspendLayout()
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        CType(Me.dgrd_testHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Test
        '
        Me.grp_Test.BackColor = System.Drawing.Color.Transparent
        Me.grp_Test.Controls.Add(Me.chk_SolicitaHC)
        Me.grp_Test.Controls.Add(Me.txt_ValDefecto)
        Me.grp_Test.Controls.Add(Me.cmb_unidad)
        Me.grp_Test.Controls.Add(Me.lbl_Tipo)
        Me.grp_Test.Controls.Add(Me.Label7)
        Me.grp_Test.Controls.Add(Me.chk_calculadora)
        Me.grp_Test.Controls.Add(Me.chk_antiobiograma)
        Me.grp_Test.Controls.Add(Me.Label6)
        Me.grp_Test.Controls.Add(Me.cmb_Padre)
        Me.grp_Test.Controls.Add(Me.cmb_resultado)
        Me.grp_Test.Controls.Add(Me.cmb_tipo)
        Me.grp_Test.Controls.Add(Me.Label5)
        Me.grp_Test.Controls.Add(Me.cmb_treporte)
        Me.grp_Test.Controls.Add(Me.txt_abrev)
        Me.grp_Test.Controls.Add(Me.txt_obs2)
        Me.grp_Test.Controls.Add(Me.cmb_cbarras)
        Me.grp_Test.Controls.Add(Me.Label3)
        Me.grp_Test.Controls.Add(Me.Label2)
        Me.grp_Test.Controls.Add(Me.lbl_abrev)
        Me.grp_Test.Controls.Add(Me.cmb_equip)
        Me.grp_Test.Controls.Add(Me.lbl_equip)
        Me.grp_Test.Controls.Add(Me.Label1)
        Me.grp_Test.Controls.Add(Me.cmb_TipProces)
        Me.grp_Test.Controls.Add(Me.lbl_TipProces)
        Me.grp_Test.Controls.Add(Me.cmb_muestra)
        Me.grp_Test.Controls.Add(Me.lbl_muestra)
        Me.grp_Test.Controls.Add(Me.Ctl_txt_Precio)
        Me.grp_Test.Controls.Add(Me.cmb_Area)
        Me.grp_Test.Controls.Add(Me.txt_Obs)
        Me.grp_Test.Controls.Add(Me.Ctl_txt_Nombre)
        Me.grp_Test.Controls.Add(Me.lbl_Precio)
        Me.grp_Test.Controls.Add(Me.lbl_TipRes)
        Me.grp_Test.Controls.Add(Me.lbl_Area)
        Me.grp_Test.Controls.Add(Me.lbl_Obs)
        Me.grp_Test.Controls.Add(Me.lbl_Nombre)
        Me.grp_Test.Controls.Add(Me.Label4)
        Me.grp_Test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Test.ForeColor = System.Drawing.Color.Navy
        Me.grp_Test.Location = New System.Drawing.Point(719, 101)
        Me.grp_Test.Name = "grp_Test"
        Me.grp_Test.Size = New System.Drawing.Size(388, 480)
        Me.grp_Test.TabIndex = 1
        Me.grp_Test.TabStop = False
        '
        'chk_SolicitaHC
        '
        Me.chk_SolicitaHC.AutoSize = True
        Me.chk_SolicitaHC.ForeColor = System.Drawing.Color.Black
        Me.chk_SolicitaHC.Location = New System.Drawing.Point(124, 447)
        Me.chk_SolicitaHC.Name = "chk_SolicitaHC"
        Me.chk_SolicitaHC.Size = New System.Drawing.Size(90, 17)
        Me.chk_SolicitaHC.TabIndex = 144
        Me.chk_SolicitaHC.Text = "Solicitar HC"
        Me.chk_SolicitaHC.UseVisualStyleBackColor = True
        '
        'txt_ValDefecto
        '
        Me.txt_ValDefecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ValDefecto.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ValDefecto.Location = New System.Drawing.Point(109, 322)
        Me.txt_ValDefecto.MaxLength = 100000
        Me.txt_ValDefecto.Multiline = True
        Me.txt_ValDefecto.Name = "txt_ValDefecto"
        Me.txt_ValDefecto.Size = New System.Drawing.Size(183, 40)
        Me.txt_ValDefecto.TabIndex = 143
        '
        'cmb_unidad
        '
        Me.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_unidad.Items.AddRange(New Object() {"Manual", "Equipo"})
        Me.cmb_unidad.Location = New System.Drawing.Point(108, 365)
        Me.cmb_unidad.Name = "cmb_unidad"
        Me.cmb_unidad.Size = New System.Drawing.Size(110, 21)
        Me.cmb_unidad.TabIndex = 8
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tipo.Location = New System.Drawing.Point(10, 14)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(84, 23)
        Me.lbl_Tipo.TabIndex = 108
        Me.lbl_Tipo.Text = "lbl_tipo"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Resul defecto"
        '
        'chk_calculadora
        '
        Me.chk_calculadora.AutoSize = True
        Me.chk_calculadora.ForeColor = System.Drawing.Color.Black
        Me.chk_calculadora.Location = New System.Drawing.Point(291, 447)
        Me.chk_calculadora.Name = "chk_calculadora"
        Me.chk_calculadora.Size = New System.Drawing.Size(92, 17)
        Me.chk_calculadora.TabIndex = 107
        Me.chk_calculadora.Text = "Calculadora"
        Me.chk_calculadora.UseVisualStyleBackColor = True
        Me.chk_calculadora.Visible = False
        '
        'chk_antiobiograma
        '
        Me.chk_antiobiograma.AutoSize = True
        Me.chk_antiobiograma.ForeColor = System.Drawing.Color.Black
        Me.chk_antiobiograma.Location = New System.Drawing.Point(15, 447)
        Me.chk_antiobiograma.Name = "chk_antiobiograma"
        Me.chk_antiobiograma.Size = New System.Drawing.Size(103, 17)
        Me.chk_antiobiograma.TabIndex = 106
        Me.chk_antiobiograma.Text = "Antibiograma"
        Me.chk_antiobiograma.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 14)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Padre:"
        '
        'cmb_Padre
        '
        Me.cmb_Padre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Padre.Enabled = False
        Me.cmb_Padre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Padre.Location = New System.Drawing.Point(108, 92)
        Me.cmb_Padre.Name = "cmb_Padre"
        Me.cmb_Padre.Size = New System.Drawing.Size(206, 21)
        Me.cmb_Padre.TabIndex = 104
        '
        'cmb_resultado
        '
        Me.cmb_resultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_resultado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_resultado.Location = New System.Drawing.Point(108, 298)
        Me.cmb_resultado.Name = "cmb_resultado"
        Me.cmb_resultado.Size = New System.Drawing.Size(185, 21)
        Me.cmb_resultado.TabIndex = 25
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.Items.AddRange(New Object() {"Examen", "Parametro", "Procedimiento", "Farmaco", "Deshabilitado"})
        Me.cmb_tipo.Location = New System.Drawing.Point(108, 70)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(206, 21)
        Me.cmb_tipo.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 14)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tipo:"
        '
        'cmb_treporte
        '
        Me.cmb_treporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_treporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_treporte.Items.AddRange(New Object() {"Estandar", "Separador"})
        Me.cmb_treporte.Location = New System.Drawing.Point(108, 275)
        Me.cmb_treporte.Name = "cmb_treporte"
        Me.cmb_treporte.Size = New System.Drawing.Size(185, 21)
        Me.cmb_treporte.TabIndex = 17
        '
        'txt_abrev
        '
        Me.txt_abrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_abrev.Location = New System.Drawing.Point(108, 251)
        Me.txt_abrev.Name = "txt_abrev"
        Me.txt_abrev.Size = New System.Drawing.Size(184, 21)
        Me.txt_abrev.TabIndex = 15
        '
        'txt_obs2
        '
        Me.txt_obs2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_obs2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs2.Location = New System.Drawing.Point(108, 275)
        Me.txt_obs2.MaxLength = 150
        Me.txt_obs2.Multiline = True
        Me.txt_obs2.Name = "txt_obs2"
        Me.txt_obs2.Size = New System.Drawing.Size(152, 20)
        Me.txt_obs2.TabIndex = 22
        Me.txt_obs2.Visible = False
        '
        'cmb_cbarras
        '
        Me.cmb_cbarras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cbarras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cbarras.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "0"})
        Me.cmb_cbarras.Location = New System.Drawing.Point(108, 411)
        Me.cmb_cbarras.Name = "cmb_cbarras"
        Me.cmb_cbarras.Size = New System.Drawing.Size(110, 21)
        Me.cmb_cbarras.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Etiquetas CB"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tipo etiqueta:"
        '
        'lbl_abrev
        '
        Me.lbl_abrev.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_abrev.ForeColor = System.Drawing.Color.Black
        Me.lbl_abrev.Location = New System.Drawing.Point(12, 255)
        Me.lbl_abrev.Name = "lbl_abrev"
        Me.lbl_abrev.Size = New System.Drawing.Size(87, 18)
        Me.lbl_abrev.TabIndex = 16
        Me.lbl_abrev.Text = "Canal LIS:"
        '
        'cmb_equip
        '
        Me.cmb_equip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_equip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_equip.Location = New System.Drawing.Point(108, 226)
        Me.cmb_equip.Name = "cmb_equip"
        Me.cmb_equip.Size = New System.Drawing.Size(185, 21)
        Me.cmb_equip.TabIndex = 13
        '
        'lbl_equip
        '
        Me.lbl_equip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_equip.ForeColor = System.Drawing.Color.Black
        Me.lbl_equip.Location = New System.Drawing.Point(12, 230)
        Me.lbl_equip.Name = "lbl_equip"
        Me.lbl_equip.Size = New System.Drawing.Size(102, 18)
        Me.lbl_equip.TabIndex = 14
        Me.lbl_equip.Text = "Equipo:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Unidad:"
        '
        'cmb_TipProces
        '
        Me.cmb_TipProces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipProces.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_TipProces.Items.AddRange(New Object() {"Manual", "Equipo"})
        Me.cmb_TipProces.Location = New System.Drawing.Point(108, 226)
        Me.cmb_TipProces.Name = "cmb_TipProces"
        Me.cmb_TipProces.Size = New System.Drawing.Size(185, 21)
        Me.cmb_TipProces.TabIndex = 6
        Me.cmb_TipProces.Visible = False
        '
        'lbl_TipProces
        '
        Me.lbl_TipProces.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipProces.ForeColor = System.Drawing.Color.Black
        Me.lbl_TipProces.Location = New System.Drawing.Point(12, 230)
        Me.lbl_TipProces.Name = "lbl_TipProces"
        Me.lbl_TipProces.Size = New System.Drawing.Size(90, 18)
        Me.lbl_TipProces.TabIndex = 11
        Me.lbl_TipProces.Text = "Tipo Proces.:"
        Me.lbl_TipProces.Visible = False
        '
        'cmb_muestra
        '
        Me.cmb_muestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_muestra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_muestra.Location = New System.Drawing.Point(108, 203)
        Me.cmb_muestra.Name = "cmb_muestra"
        Me.cmb_muestra.Size = New System.Drawing.Size(185, 21)
        Me.cmb_muestra.TabIndex = 5
        '
        'lbl_muestra
        '
        Me.lbl_muestra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_muestra.ForeColor = System.Drawing.Color.Black
        Me.lbl_muestra.Location = New System.Drawing.Point(12, 208)
        Me.lbl_muestra.Name = "lbl_muestra"
        Me.lbl_muestra.Size = New System.Drawing.Size(82, 14)
        Me.lbl_muestra.TabIndex = 10
        Me.lbl_muestra.Text = "Muestra:"
        '
        'Ctl_txt_Precio
        '
        Me.Ctl_txt_Precio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Precio.Location = New System.Drawing.Point(108, 388)
        Me.Ctl_txt_Precio.Name = "Ctl_txt_Precio"
        Me.Ctl_txt_Precio.Prp_Formato = True
        Me.Ctl_txt_Precio.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_Precio.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_Precio.Prp_ValDefault = "0.0"
        Me.Ctl_txt_Precio.Size = New System.Drawing.Size(110, 20)
        Me.Ctl_txt_Precio.TabIndex = 7
        '
        'cmb_Area
        '
        Me.cmb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Area.Location = New System.Drawing.Point(108, 180)
        Me.cmb_Area.Name = "cmb_Area"
        Me.cmb_Area.Size = New System.Drawing.Size(185, 21)
        Me.cmb_Area.TabIndex = 3
        '
        'txt_Obs
        '
        Me.txt_Obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Obs.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Obs.Location = New System.Drawing.Point(108, 115)
        Me.txt_Obs.MaxLength = 100000
        Me.txt_Obs.Multiline = True
        Me.txt_Obs.Name = "txt_Obs"
        Me.txt_Obs.Size = New System.Drawing.Size(275, 63)
        Me.txt_Obs.TabIndex = 2
        '
        'Ctl_txt_Nombre
        '
        Me.Ctl_txt_Nombre.BackColor = System.Drawing.Color.LightGray
        Me.Ctl_txt_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Nombre.Location = New System.Drawing.Point(108, 47)
        Me.Ctl_txt_Nombre.Name = "Ctl_txt_Nombre"
        Me.Ctl_txt_Nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_Nombre.Size = New System.Drawing.Size(275, 20)
        Me.Ctl_txt_Nombre.TabIndex = 1
        '
        'lbl_Precio
        '
        Me.lbl_Precio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Precio.ForeColor = System.Drawing.Color.Black
        Me.lbl_Precio.Location = New System.Drawing.Point(12, 393)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(90, 14)
        Me.lbl_Precio.TabIndex = 5
        Me.lbl_Precio.Text = "Costo:"
        '
        'lbl_TipRes
        '
        Me.lbl_TipRes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipRes.ForeColor = System.Drawing.Color.Black
        Me.lbl_TipRes.Location = New System.Drawing.Point(12, 303)
        Me.lbl_TipRes.Name = "lbl_TipRes"
        Me.lbl_TipRes.Size = New System.Drawing.Size(78, 14)
        Me.lbl_TipRes.TabIndex = 4
        Me.lbl_TipRes.Text = "Tipo Resul."
        '
        'lbl_Area
        '
        Me.lbl_Area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Area.ForeColor = System.Drawing.Color.Black
        Me.lbl_Area.Location = New System.Drawing.Point(12, 185)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Area.TabIndex = 2
        Me.lbl_Area.Text = "Area:"
        '
        'lbl_Obs
        '
        Me.lbl_Obs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Obs.ForeColor = System.Drawing.Color.Black
        Me.lbl_Obs.Location = New System.Drawing.Point(12, 118)
        Me.lbl_Obs.Name = "lbl_Obs"
        Me.lbl_Obs.Size = New System.Drawing.Size(87, 17)
        Me.lbl_Obs.TabIndex = 1
        Me.lbl_Obs.Text = "Metodo:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(12, 51)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(72, 17)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nivel:"
        Me.Label4.Visible = False
        '
        'btn_orden
        '
        Me.btn_orden.BackColor = System.Drawing.SystemColors.Control
        Me.btn_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orden.ForeColor = System.Drawing.Color.Black
        Me.btn_orden.Image = CType(resources.GetObject("btn_orden.Image"), System.Drawing.Image)
        Me.btn_orden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_orden.Location = New System.Drawing.Point(728, 34)
        Me.btn_orden.Name = "btn_orden"
        Me.btn_orden.Size = New System.Drawing.Size(81, 41)
        Me.btn_orden.TabIndex = 97
        Me.btn_orden.Text = "Orden impresion"
        Me.btn_orden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_orden.UseVisualStyleBackColor = False
        '
        'dgrd_Test
        '
        Me.dgrd_Test.AllowNavigation = False
        Me.dgrd_Test.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Test.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Test.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Test.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Test.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Test.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.CaptionText = "TEST DISPONIBLES"
        Me.dgrd_Test.DataMember = ""
        Me.dgrd_Test.FlatMode = True
        Me.dgrd_Test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Test.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Test.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Test.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.Location = New System.Drawing.Point(12, 111)
        Me.dgrd_Test.Name = "dgrd_Test"
        Me.dgrd_Test.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Test.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.PreferredColumnWidth = 95
        Me.dgrd_Test.ReadOnly = True
        Me.dgrd_Test.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Test.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Test.Size = New System.Drawing.Size(702, 232)
        Me.dgrd_Test.TabIndex = 1
        Me.dgrd_Test.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Test.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Test
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn25})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridTextBoxColumn2.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn2.Width = 280
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "TES_PRECIO"
        Me.DataGridTextBoxColumn3.MappingName = "TES_PRECIO"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "AREA ID"
        Me.DataGridTextBoxColumn4.MappingName = "are_id"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "AREA"
        Me.DataGridTextBoxColumn5.MappingName = "are_nombre"
        Me.DataGridTextBoxColumn5.Width = 210
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "TIPO PROCESAMIENTO"
        Me.DataGridTextBoxColumn6.MappingName = "tes_tproces"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Treporte"
        Me.DataGridTextBoxColumn7.MappingName = "Treporte"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "tes_codbarras"
        Me.DataGridTextBoxColumn8.NullText = "SI"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "tes_tipo"
        Me.DataGridTextBoxColumn9.NullText = "0"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "AB"
        Me.DataGridTextBoxColumn19.MappingName = "TES_AB"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 0
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "CALC"
        Me.DataGridTextBoxColumn20.MappingName = "TES_CALC"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "VALOR DEFECTO"
        Me.DataGridTextBoxColumn23.MappingName = "TES_RESDEFECTO"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.ReadOnly = True
        Me.DataGridTextBoxColumn23.Width = 150
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "RESULTADO"
        Me.DataGridTextBoxColumn25.MappingName = "RES_ID"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 0
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(439, 35)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(73, 40)
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
        Me.btn_Salir.Location = New System.Drawing.Point(1034, 35)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(73, 40)
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(584, 35)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(73, 40)
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(511, 35)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(73, 40)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(1123, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(8, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(188, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GESTION DE EXAMENES"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_test
        '
        Me.txt_test.BackColor = System.Drawing.Color.LightGreen
        Me.txt_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_test.Location = New System.Drawing.Point(109, 81)
        Me.txt_test.Name = "txt_test"
        Me.txt_test.Size = New System.Drawing.Size(381, 21)
        Me.txt_test.TabIndex = 0
        '
        'lbl_test
        '
        Me.lbl_test.AutoSize = True
        Me.lbl_test.BackColor = System.Drawing.Color.Transparent
        Me.lbl_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test.Location = New System.Drawing.Point(18, 88)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(85, 13)
        Me.lbl_test.TabIndex = 95
        Me.lbl_test.Text = "BUSCAR TEST:"
        '
        'btn_param
        '
        Me.btn_param.BackColor = System.Drawing.SystemColors.Control
        Me.btn_param.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_param.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_param.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_param.ForeColor = System.Drawing.Color.Black
        Me.btn_param.Image = CType(resources.GetObject("btn_param.Image"), System.Drawing.Image)
        Me.btn_param.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_param.Location = New System.Drawing.Point(656, 35)
        Me.btn_param.Name = "btn_param"
        Me.btn_param.Size = New System.Drawing.Size(73, 40)
        Me.btn_param.TabIndex = 98
        Me.btn_param.Text = "Hoja Trabajo"
        Me.btn_param.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_param.UseVisualStyleBackColor = False
        '
        'dgrd_testHijos
        '
        Me.dgrd_testHijos.AllowNavigation = False
        Me.dgrd_testHijos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_testHijos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_testHijos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_testHijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_testHijos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_testHijos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_testHijos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testHijos.CaptionText = "PARAMETROS PLANTILLA"
        Me.dgrd_testHijos.DataMember = ""
        Me.dgrd_testHijos.FlatMode = True
        Me.dgrd_testHijos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_testHijos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_testHijos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_testHijos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_testHijos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testHijos.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_testHijos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_testHijos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testHijos.Location = New System.Drawing.Point(12, 373)
        Me.dgrd_testHijos.Name = "dgrd_testHijos"
        Me.dgrd_testHijos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_testHijos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_testHijos.PreferredColumnWidth = 95
        Me.dgrd_testHijos.ReadOnly = True
        Me.dgrd_testHijos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_testHijos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_testHijos.Size = New System.Drawing.Size(702, 210)
        Me.dgrd_testHijos.TabIndex = 99
        Me.dgrd_testHijos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgrd_testHijos.TabStop = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle2.DataGrid = Me.dgrd_testHijos
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn24})
        Me.DataGridTableStyle2.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGridTableStyle2.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Registros2"
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle2.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn10.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn10.Width = 50
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "NOMBRE"
        Me.DataGridTextBoxColumn11.MappingName = "TES_NOMBRE"
        Me.DataGridTextBoxColumn11.Width = 400
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "TES_PRECIO"
        Me.DataGridTextBoxColumn12.MappingName = "TES_PRECIO"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "AREA ID"
        Me.DataGridTextBoxColumn13.MappingName = "are_id"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "AREA"
        Me.DataGridTextBoxColumn14.MappingName = "are_nombre"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "TIPO PROCESAMIENTO"
        Me.DataGridTextBoxColumn15.MappingName = "tes_tproces"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Treporte"
        Me.DataGridTextBoxColumn16.MappingName = "treporte"
        Me.DataGridTextBoxColumn16.NullText = "--"
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.MappingName = "tes_codbarras"
        Me.DataGridTextBoxColumn17.NullText = "SI"
        Me.DataGridTextBoxColumn17.Width = 0
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.MappingName = "tes_tipo"
        Me.DataGridTextBoxColumn18.NullText = "0"
        Me.DataGridTextBoxColumn18.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "AB"
        Me.DataGridTextBoxColumn21.MappingName = "TES_AB"
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "CALC"
        Me.DataGridTextBoxColumn22.MappingName = "TES_CALC"
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "VALOR DEFECTO"
        Me.DataGridTextBoxColumn24.MappingName = "TES_RESDEFECTO"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.ReadOnly = True
        Me.DataGridTextBoxColumn24.Width = 150
        '
        'btn_paramPlant
        '
        Me.btn_paramPlant.BackColor = System.Drawing.SystemColors.Control
        Me.btn_paramPlant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_paramPlant.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_paramPlant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_paramPlant.ForeColor = System.Drawing.Color.Black
        Me.btn_paramPlant.Image = CType(resources.GetObject("btn_paramPlant.Image"), System.Drawing.Image)
        Me.btn_paramPlant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_paramPlant.Location = New System.Drawing.Point(888, 35)
        Me.btn_paramPlant.Name = "btn_paramPlant"
        Me.btn_paramPlant.Size = New System.Drawing.Size(73, 40)
        Me.btn_paramPlant.TabIndex = 100
        Me.btn_paramPlant.Text = "Param Plantilla"
        Me.btn_paramPlant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_paramPlant.UseVisualStyleBackColor = False
        '
        'txt_Param
        '
        Me.txt_Param.BackColor = System.Drawing.Color.LightGreen
        Me.txt_Param.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Param.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Param.Location = New System.Drawing.Point(147, 349)
        Me.txt_Param.Name = "txt_Param"
        Me.txt_Param.Size = New System.Drawing.Size(381, 21)
        Me.txt_Param.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "BUSCAR PARAMETRO:"
        '
        'rbt_SoloTest
        '
        Me.rbt_SoloTest.AutoSize = True
        Me.rbt_SoloTest.Checked = True
        Me.rbt_SoloTest.Location = New System.Drawing.Point(18, 58)
        Me.rbt_SoloTest.Name = "rbt_SoloTest"
        Me.rbt_SoloTest.Size = New System.Drawing.Size(77, 17)
        Me.rbt_SoloTest.TabIndex = 106
        Me.rbt_SoloTest.TabStop = True
        Me.rbt_SoloTest.Text = "Solo Test"
        Me.rbt_SoloTest.UseVisualStyleBackColor = True
        '
        'rbt_Todos
        '
        Me.rbt_Todos.AutoSize = True
        Me.rbt_Todos.Location = New System.Drawing.Point(101, 58)
        Me.rbt_Todos.Name = "rbt_Todos"
        Me.rbt_Todos.Size = New System.Drawing.Size(59, 17)
        Me.rbt_Todos.TabIndex = 107
        Me.rbt_Todos.Text = "Todos"
        Me.rbt_Todos.UseVisualStyleBackColor = True
        '
        'btn_formatos
        '
        Me.btn_formatos.BackColor = System.Drawing.SystemColors.Control
        Me.btn_formatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_formatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_formatos.ForeColor = System.Drawing.Color.Black
        Me.btn_formatos.Image = CType(resources.GetObject("btn_formatos.Image"), System.Drawing.Image)
        Me.btn_formatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_formatos.Location = New System.Drawing.Point(808, 34)
        Me.btn_formatos.Name = "btn_formatos"
        Me.btn_formatos.Size = New System.Drawing.Size(81, 41)
        Me.btn_formatos.TabIndex = 108
        Me.btn_formatos.Text = "Asistente Plantilla"
        Me.btn_formatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_formatos.UseVisualStyleBackColor = False
        '
        'btn_Cie10
        '
        Me.btn_Cie10.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cie10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cie10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cie10.ForeColor = System.Drawing.Color.Black
        Me.btn_Cie10.Image = CType(resources.GetObject("btn_Cie10.Image"), System.Drawing.Image)
        Me.btn_Cie10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cie10.Location = New System.Drawing.Point(962, 34)
        Me.btn_Cie10.Name = "btn_Cie10"
        Me.btn_Cie10.Size = New System.Drawing.Size(73, 41)
        Me.btn_Cie10.TabIndex = 109
        Me.btn_Cie10.Text = "Cie10"
        Me.btn_Cie10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cie10.UseVisualStyleBackColor = False
        '
        'frm_TipoTest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(1123, 597)
        Me.Controls.Add(Me.btn_Cie10)
        Me.Controls.Add(Me.btn_formatos)
        Me.Controls.Add(Me.rbt_Todos)
        Me.Controls.Add(Me.rbt_SoloTest)
        Me.Controls.Add(Me.txt_Param)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_paramPlant)
        Me.Controls.Add(Me.dgrd_testHijos)
        Me.Controls.Add(Me.btn_param)
        Me.Controls.Add(Me.btn_orden)
        Me.Controls.Add(Me.txt_test)
        Me.Controls.Add(Me.lbl_test)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.grp_Test)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.dgrd_Test)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_TipoTest"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Tests"
        Me.grp_Test.ResumeLayout(False)
        Me.grp_Test.PerformLayout()
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgrd_testHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim opr_Test As New Cls_TipoTest()
    Dim opr_Area As New Cls_Areas()
    Dim opr_Param As New Cls_Parametros()
    Dim opr_equip As New Cls_equipos()
    Dim opr_res As New Cls_Resultado()
    Dim str_area As String
    Dim dtv_test As New DataView()
    Dim dtv_testHijos As New DataView()
    Dim AB, calc As Byte
    Dim Arreglo_examenes As String()
    Dim i As Integer = 0
    Dim filtro_rbt As Boolean = True

    'Variable bandera para saber si se inserta o se actualiza el registro
    Dim boo_flag As Boolean
    'Variable que almacena el ID del registro a modificar, insertar o eliminar.
    Dim int_codigo As Integer

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub



    Private Sub frm_TipoTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        Ctl_txt_Nombre.txt_padre.MaxLength = 100
        Ctl_txt_Precio.txt_padre.MaxLength = 8
        cmb_treporte.Text = "Estandar"
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        cmb_TipProces.SelectedIndex = 1
        cmb_cbarras.SelectedIndex = 0
        grp_Test.Enabled = False


        dgrd_Test.DataSource = dtv_test
        opr_Test.LlenarGridtest(dtv_test, filtro_rbt)

        dgrd_testHijos.DataSource = dtv_testHijos
        opr_Test.LlenarGridtestHijosAB(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)

        opr_Area.LlenarCmb_Padre(cmb_Padre)
        opr_Area.LlenarCmb_Area(cmb_Area)
        opr_Param.LlenarCmb_MuestraNC(cmb_muestra)
        opr_Param.LlenaCmb_Resultado(cmb_resultado)
        'opr_Param.LlenaChkListResultado(chkl_Resultado)
        opr_Param.LlenarCmb_UnidadC(cmb_unidad)
        opr_equip.LlenarCmbEquipos(cmb_equip)


        ''lleno txt con examenes

        btn_Nuevo.Focus()
        boo_flag = True
    End Sub

    Sub CargarColeccion(ByVal Coleccion As AutoCompleteStringCollection)
        On Error Resume Next
        opr_res.LeerNombreExamen(Coleccion)

    End Sub

    

    

    


    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Call limpiarCamposT()
        grp_Test.Enabled = True
        cmb_tipo.SelectedIndex = 0
        btn_Aceptar.Enabled = True
        btn_Nuevo.Enabled = False
        btn_Eliminar.Enabled = False
        Ctl_txt_Nombre.Focus()
        boo_flag = True
        txt_test.Text = ""
        btn_param.Enabled = False
        opr_Area.LlenarCmb_Padre(cmb_Padre)
        opr_Area.LlenarCmb_Area(cmb_Area)

    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Me.Cursor = Cursors.WaitCursor


        If (Ctl_txt_Nombre.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre del Test", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            btn_Nuevo.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        'Verifico que no exista otro test con el mismo nombre
        ' ''If (opr_Test.BuscarTipTest(Ctl_txt_Nombre.texto_Recupera) = True And boo_flag = True) Then
        ' ''    MsgBox("El nombre ingresado ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
        ' ''    Ctl_txt_Nombre.Focus()
        ' ''    btn_Nuevo.Enabled = True
        ' ''    Me.Cursor = Cursors.Default
        ' ''    Exit Sub
        ' ''End If

        'Verifico que no exista el canal LIS
        If (opr_Test.BuscarAbrev(txt_abrev.Text) = True And boo_flag = True) Then
            MsgBox("El canal LIS ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            btn_Nuevo.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If (Ctl_txt_Precio.texto_Recupera = "") Then
            MsgBox("Ingrese el precio del Test", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_Precio.Focus()
            btn_Nuevo.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim i As Integer
        Dim flagchk As Short = 0
        ''For i = 0 To (chkl_Resultado.Items.Count - 1)
        ''    If chkl_Resultado.GetItemChecked(i) = True Then
        ''        flagchk = 1
        ''    End If
        ''Next
        ''If flagchk = 0 Then
        ''    MsgBox("Debe escoger por lo menos un tipo de resultado", MsgBoxStyle.Exclamation, "ANALISYS")
        ''    btn_Nuevo.Enabled = True
        ''    Me.Cursor = Cursors.Default
        ''    Exit Sub
        ''End If

        If (cmb_TipProces.Text = "Equipo") Then
            If txt_abrev.Text = "" Or cmb_equip.Text = "" Then
                MsgBox("Debe escoger el equipo e ingresar la abreviatura.", MsgBoxStyle.Exclamation, "ANALISYS")
                btn_Nuevo.Enabled = True
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        str_area = opr_Area.AreaId(Mid(cmb_Area.Text, 1, 100))
        Dim opr_convenio As New Cls_Convenio()
        Dim treporte As Byte = 0
        If cmb_treporte.Text = "Separador" Then
            treporte = 1
        End If
        If boo_flag = True Then    '*** Si se trata de un nuevo Test 

            'Consulto el nuevo maximo id para el nuevo test 
            If cmb_tipo.Text = "Parametro" Then ''And (CInt(str_area) = 22 Or CInt(str_area) = 33 Or CInt(str_area) = 7 Or CInt(str_area) = 40) Then
                int_codigo = opr_Test.LeerMaxCodTestParam() + 1
            Else
                int_codigo = opr_Test.LeerMaxCodTest(Trim(cmb_tipo.Text)) + 1
            End If




            'opr_Test.GuardarTest(int_codigo, UCase(Ctl_txt_Nombre.texto_Recupera), txt_Obs.Text.ToString, str_area, Ctl_txt_Precio.texto_Recupera, chkl_Resultado, Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex)
            'Si es manual, se aumenta este test en las listas de precios.
            If (cmb_TipProces.Text = "Equipo") Then
                ' ''    MsgBox("No se puede crear Test de procesamiento por equipo", MsgBoxStyle.Exclamation, "ANALISYS")
                ' ''    btn_Nuevo.Enabled = True
                ' ''    Me.Cursor = Cursors.Default
                ' ''    Exit Sub
                If chk_antiobiograma.Checked Then
                    AB = 1
                Else
                    AB = 0
                End If

                If chk_SolicitaHC.Checked Then
                    calc = 1
                Else
                    calc = 0
                End If
                'opr_Test.ActualizarTest(int_codigo, str_area, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_tipo.Text, CInt(Mid(cmb_Padre.Text, 100, 10)), AB, calc, txt_ValDefecto.Text, Val(cmb_equip.Text.Substring(50, 5)), Trim(txt_abrev.Text), lbl_abrev.Tag)
                opr_Test.GuardarTest(int_codigo, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, CInt(str_area), Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_tipo.Text, CInt(Mid(cmb_Padre.Text, 100, 10)), AB, calc, txt_ValDefecto.Text, Trim(txt_abrev.Text), CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_equip.Text.Substring(50, 5)), Trim(txt_abrev.Text), lbl_abrev.Tag)



            End If
            'If (cmb_TipProces.Text = "Manual") Then

            '    '(ByVal TestCod As Integer, ByVal TestNom As String, _
            '    '              ByVal TestObs As String, ByVal areId As Integer, _
            '    '              ByVal testPrec As Double, ByVal TipoResult As Integer, _
            '    '              ByVal tim_id As Integer, ByVal tes_tproces As String, ByVal uni_id As Short, _
            '    '              ByVal treporte As Byte, ByVal cbarras As Integer, ByVal Tipo As String)

            '    '''opr_Test.GuardarTest(int_codigo, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, CInt(str_area), Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_tipo.Text)
            'End If
        Else    '*** Si se trata de una actualizacion TEST 
            Dim dts_convenio As DataSet
            Dim dtr_fila As DataRow
            If MsgBox("Desea actualizar los datos?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
                If (Ctl_txt_Precio.texto_Recupera <> Ctl_txt_Precio.Tag) Then
                    'If MsgBox("El cambio en el valor del Costo del Test, generar� nuevos precios" & ControlChars.CrLf & " en las Listas de Precios por Convenios, Desea Continuar?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
                    If cmb_TipProces.Text = "Equipo" Then
                        opr_Test.ActualizarTest(int_codigo, str_area, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_tipo.Text, CInt(Mid(cmb_Padre.Text, 100, 10)), AB, calc, Trim(txt_ValDefecto.Text), Val(cmb_equip.Text.Substring(50, 5)), Trim(txt_abrev.Text), lbl_abrev.Tag)
                    Else
                        opr_Test.ActualizarTest(int_codigo, str_area, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_tipo.Text, CInt(Mid(cmb_Padre.Text, 100, 10)), AB, calc, Trim(txt_ValDefecto.Text))
                    End If
                    '    dts_convenio = opr_convenio.ConsultarTestConvenioLP(int_codigo, Ctl_txt_Precio.texto_Recupera)
                    '    For Each dtr_fila In dts_convenio.Tables("Registros").Rows
                    '        opr_convenio.ActualizarPrecioTestLP(dtr_fila(0), (dtr_fila(1) * Ctl_txt_Precio.texto_Recupera), int_codigo)
                    '    Next
                    'End If
                Else
                    If cmb_TipProces.Text = "Equipo" Then
                        opr_Test.ActualizarTest(int_codigo, str_area, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_tipo.Text, CInt(Mid(cmb_Padre.Text, 100, 10)), AB, calc, Trim(txt_ValDefecto.Text), Val(cmb_equip.Text.Substring(50, 5)), Trim(txt_abrev.Text), lbl_abrev.Tag)
                    Else
                        opr_Test.ActualizarTest(int_codigo, str_area, Ctl_txt_Nombre.texto_Recupera, txt_Obs.Text.ToString, Ctl_txt_Precio.texto_Recupera, CInt(Trim(cmb_resultado.Text.Substring(80, 1))), Val(cmb_muestra.Text.Substring(50, 5)), cmb_TipProces.SelectedIndex, Val(cmb_unidad.Text.Substring(50, 5)), treporte, cmb_cbarras.Text, cmb_tipo.Text, CInt(Mid(cmb_Padre.Text, 100, 10)), AB, calc, Trim(txt_ValDefecto.Text))
                    End If
                End If
            Else
                Call limpiarCamposT()
                grp_Test.Enabled = False
                btn_Aceptar.Enabled = False
                btn_Nuevo.Enabled = True
                btn_Nuevo.Focus()
                btn_Eliminar.Enabled = False
                Exit Sub
            End If
        End If
        Call limpiarCamposT()
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Test.Enabled = False
        txt_test.Text = ""

        opr_Test.LlenarGridtest(dtv_test, filtro_rbt)
        opr_Test.LlenarGridtestHijosAB(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)
        'dgrd_Test.SetDataBinding(opr_Test.LeerTestArea(), "Registros")

        cmb_Padre.Items.Clear()
        opr_Area.LlenarCmb_Padre(cmb_Padre)
        btn_Nuevo.Enabled = True
        btn_param.Enabled = False
        btn_Nuevo.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub limpiarCamposT()
        'Procedimiento que limpia los campos de este formulario
        Ctl_txt_Nombre.texto_Asigna("")
        txt_Obs.Text = ""
        Ctl_txt_Precio.texto_Asigna("")
        Ctl_txt_Precio.Tag = ""
        txt_abrev.Text = ""
        lbl_abrev.Tag = ""
        cmb_treporte.Text = "Estandar"
        cmb_Area.SelectedIndex = 0
        txt_ValDefecto.Text = ""
        'Dim int_i As Integer
        'For int_i = 0 To (chkl_Resultado.Items.Count - 1)
        '    chkl_Resultado.SetItemChecked(int_i, False)
        'Next
        'cmb_resultado.SelectedText("")
        cmb_muestra.SelectedIndex = 0
        cmb_tipo.SelectedIndex = 0
        chk_antiobiograma.Checked = False
        chk_calculadora.Checked = False
    End Sub

    Private Sub dgrd_Test_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Test.CurrentCellChanged
        Call limpiarCamposT()
        'dgrd_Test.Select(dgrd_Test.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        lbl_Tipo.Text = "TEST"
        grp_Test.Enabled = True
        int_codigo = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0)
        If dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 6) = 0 Then
            cmb_treporte.Text = "Estandar"
        Else
            cmb_treporte.Text = "Separador"
        End If
        'If dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 7) = 0 Then
        cmb_cbarras.Text = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 7)
        'Else
        '    cmb_cbarras.Text = "SI"
        'End If

        If IsDBNull(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 11)) = False Then
            txt_ValDefecto.Text = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 11)
        End If

        '' ''If IsDBNull(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 12)) = False And dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 12) <> "" Then
        '' ''    Arreglo_examenes = Split(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 12), ",")

        '' ''    For i = 0 To UBound(Arreglo_examenes)
        '' ''        lst_recurrencia.Items.Add(Arreglo_examenes(i))
        '' ''    Next
        '' ''End If

        cmb_TipProces.SelectedIndex = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 5)
        cmb_TipProces.Tag = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 5)
        If cmb_TipProces.Tag = 1 Then
            cmb_equip.SelectedIndex = opr_equip.equipoNombre(int_codigo) - 1
            txt_abrev.Text = Trim(opr_Test.abrevnombre(int_codigo))
            lbl_abrev.Tag = Trim(txt_abrev.Text)
        End If
        Dim dts_test As New DataSet()
        Dim dtr_fila As DataRow
        Dim int_i As Integer
        Dim nombre_muestra As String = Nothing

        dts_test = opr_Test.ConsultarTest1(int_codigo)
        For Each dtr_fila In dts_test.Tables("Registros").Rows
            Ctl_txt_Nombre.texto_Asigna(dtr_fila("tes_nombre"))
            txt_Obs.Text = dtr_fila("tes_obs").ToString
            Ctl_txt_Precio.texto_Asigna(dtr_fila("tes_precio"))
            Ctl_txt_Precio.Tag = dtr_fila("tes_precio")
            int_i = dtr_fila("are_id")
            If CInt(dtr_fila("tes_padre")) <> 0 Then
                cmb_Padre.Text = opr_Test.ConsultaNombreTest(CInt(dtr_fila("tes_padre")))
            Else
                cmb_Padre.SelectedIndex = 0
            End If
        Next
        cmb_Area.Text = opr_Area.AreaNombre(int_i)


        dts_test = opr_Test.ConsultarTest_resultado(int_codigo)
        'Selecciono los tipos de resultados en el CheckedList
        For Each dtr_fila In dts_test.Tables("Registros").Rows
            int_i = dtr_fila("res_id")
        Next

        Select Case int_i
            Case 1
                cmb_resultado.SelectedIndex = 0
            Case 2
                cmb_resultado.SelectedIndex = 1
            Case 3
                cmb_resultado.SelectedIndex = 2
            Case 4
                cmb_resultado.SelectedIndex = 3
            Case 5
                cmb_resultado.SelectedIndex = 4
            Case 6
                cmb_resultado.SelectedIndex = 5
            Case 8
                cmb_resultado.SelectedIndex = 6
            Case 9
                cmb_resultado.SelectedIndex = 7



        End Select


        dts_test = opr_Test.ConsultarTest_TipMuestra(int_codigo)
        'Selecciono el tipo de muestra del test 
        For Each dtr_fila In dts_test.Tables("Registros").Rows
            int_i = dtr_fila("tim_id")
            nombre_muestra = dtr_fila("tim_nombre")
        Next

        'cmb_muestra.Text = Ctl_txt_Nombre.texto_Recupera & int_i
        'cmb_muestra.Text = opr_Test.BuscarMuestra(int_i).PadRight(50) & CStr(int_i).PadRight(5)
        cmb_muestra.Text = nombre_muestra.PadRight(50) & CStr(int_i).PadRight(5)

        cmb_tipo.Text = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 8).ToString

        Dim dts_uni As New DataSet()
        Dim dtr_rowu As DataRow
        dts_uni = opr_Test.ConsultarUnidadTest(int_codigo)
        For Each dtr_rowu In dts_uni.Tables("Registros").Rows
            int_i = dtr_rowu(0)
        Next

        cmb_unidad.SelectedIndex = int_i
        dts_test.Clear()
        boo_flag = False  'Para saber que se puede actualizar 
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = dgrd_Test.CurrentCell.RowNumber
        dgrd_Test.CurrentCell = dgc_celda
        dgrd_Test.Select(dgrd_Test.CurrentCell.RowNumber)

        'CONSULTO SI TIENE ANTIOBIOGRAMA
        If dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 9) = 1 Then
            chk_antiobiograma.Checked = True
            'LLENO GRID DE PARAMETROS ANTIBIOGRAMA
            dgrd_testHijos.DataSource = dtv_testHijos
            opr_Test.LlenarGridtestHijosAB(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)
        Else
            chk_antiobiograma.Checked = False
            'LLENO GRID DE PARAMETROS
            dgrd_testHijos.DataSource = dtv_testHijos
            opr_Test.LlenarGridtestHijos(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0), dtv_testHijos)
        End If


        'CONSULTO SI TIENE CALCULADORA
        If dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 10) = 1 Then
            chk_calculadora.Checked = True
        Else
            chk_calculadora.Checked = False
        End If





    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If MsgBox("Desea eliminar el Test seleccionado?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then

            Me.Cursor = Cursors.WaitCursor
            opr_Test.EliminarTest(int_codigo)

            opr_Test.LlenarGridtest(dtv_test, filtro_rbt)
            'dgrd_Test.SetDataBinding(opr_Test.LeerTestArea(), "Registros")

            Me.Cursor = Cursors.Default
        End If
        Call limpiarCamposT()
        txt_test.Text = ""
        btn_param.Enabled = False
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Test.Enabled = False
    End Sub

    Private Sub txt_abrev_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_abrev.TextChanged
        'JVA 25/02/2004
        'SENTENCIA PARA QUE CUANDO SE PRESIONE UNA LETRA SEA ESTA MAYSCULA.
        'On Error Resume Next
        'Dim sht_posicion As Short = txt_abrev.SelectionStart()
        'txt_abrev.SelectionStart() = Len(txt_abrev.Text)
        'txt_abrev.Text = UCase(txt_abrev.Text)
        'txt_abrev.SelectionStart = sht_posicion
    End Sub

    Private Sub cmb_TipProces_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipProces.SelectedIndexChanged
        If cmb_TipProces.Text = "Equipo" Then
            lbl_equip.Visible = True
            lbl_abrev.Visible = True
            cmb_equip.Visible = True
            cmb_equip.Enabled = True
            txt_abrev.Visible = True
            txt_abrev.Enabled = True
        Else
            lbl_equip.Visible = False
            lbl_abrev.Visible = False
            cmb_equip.Visible = False
            cmb_equip.Enabled = False
            txt_abrev.Visible = False
            txt_abrev.Enabled = False
        End If
    End Sub

    Private Sub txt_test_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_test.TextChanged
        opr_Test.ordena_test(txt_test.Text, dtv_test)

    End Sub

    Private Sub btn_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orden.Click
        btn_param.Enabled = False
        Dim frm_MDIChild As New frm_test_orden()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        'frm_MDIChild.Tag = lbl_pedidoD.Text
        frm_MDIChild.ShowDialog(Me.ParentForm)
    End Sub


    Private Sub btn_param_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_param.Click
        btn_param.Enabled = False
        Dim frm_MDIChild As New frm_test_parametro()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
    End Sub


    Private Sub lbl_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_test.Click

    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo.SelectedIndexChanged
        If cmb_tipo.Text = "Parametro" Then
            cmb_Padre.Enabled = True
            cmb_Padre.Text = "NINGUNO"
            lbl_Tipo.Text = "PARAMETRO"
            cmb_cbarras.SelectedText = "0"
            cmb_cbarras.Enabled = False
        Else
            cmb_Padre.Enabled = False
            lbl_Tipo.Text = "TEST"
            cmb_cbarras.SelectedText = "1"
            cmb_cbarras.Enabled = True

        End If
    End Sub

    Private Sub btn_paramPlant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_paramPlant.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_ParamPlantilla()
        Dim Padre As String = ""

        Padre = opr_Test.nombrePadre(tes_idd)

        If tes_idd > 0 Then
            str_sql = "select '" & Padre & "' AS PADRE, area.ARE_NOMBRE, test.TES_ID, test.TES_NOMBRE, unidad.UNI_NOMENCLATURA from test, area, unidad where test.tes_tipo = 'Parametro' and test.tes_padre <> '' and test.TES_PADRE  = " & tes_idd & " and test.ARE_ID = area.ARE_ID and test.UNI_ID = unidad.UNI_ID "
            Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Paramatreos Plantillas"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Else
            MsgBox("Debe seleccionar un test", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
            'str_sql = "select '" & Padre & "' AS PADRE, area.ARE_NOMBRE, test.TES_ID, test.TES_NOMBRE, unidad.UNI_NOMENCLATURA from test, area, unidad where test.tes_tipo = 'Parametro' and test.tes_padre <> '' and test.TES_PADRE  = " & tes_idd & " and test.ARE_ID = area.ARE_ID and test.UNI_ID = unidad.UNI_ID UNION SELECT area.ARE_NOMBRE, test.TES_ID, test.TES_NOMBRE, unidad.UNI_NOMENCLATURA FROM test, area, unidad WHERE test.ARE_ID = area.ARE_ID and test.UNI_ID = unidad.UNI_ID order by test.TES_ID desc"
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dgrd_Test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Test.Click
        btn_param.Enabled = True

        If dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 12) = 6 Then
            btn_formatos.Enabled = True
        Else
            btn_formatos.Enabled = False
        End If
        tes_idd = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0)

    End Sub

    Private Sub dgrd_testHijos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_testHijos.CurrentCellChanged
        Call limpiarCamposT()
        dgrd_testHijos.Select(dgrd_testHijos.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        lbl_Tipo.Text = "PARAMETRO"
        grp_Test.Enabled = True
        int_codigo = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 0)
        If dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 6) = 0 Then
            cmb_treporte.Text = "Estandar"
        Else
            cmb_treporte.Text = "Separador"
        End If
        'If dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 7) = 0 Then
        cmb_cbarras.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 7)
        'Else
        '    cmb_cbarras.Text = "SI"
        'End If

        cmb_tipo.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 8).ToString

        If IsDBNull(dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 11)) = False Then
            txt_ValDefecto.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 11)
        End If


        cmb_TipProces.SelectedIndex = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 5)
        cmb_TipProces.Tag = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 5)
        If cmb_TipProces.Tag = 1 Then
            cmb_equip.SelectedIndex = opr_equip.equipoNombre(int_codigo) - 1
            txt_abrev.Text = opr_Test.abrevnombre(int_codigo)
            lbl_abrev.Tag = txt_abrev.Text
        End If
        Dim dts_test As New DataSet()
        Dim dtr_fila As DataRow
        Dim int_i As Integer
        Dim nombre_muestra As String = Nothing

        dts_test = opr_Test.ConsultarTest1(int_codigo)
        For Each dtr_fila In dts_test.Tables("Registros").Rows
            Ctl_txt_Nombre.texto_Asigna(dtr_fila("tes_nombre"))
            txt_Obs.Text = dtr_fila("tes_obs").ToString
            Ctl_txt_Precio.texto_Asigna(dtr_fila("tes_precio"))
            Ctl_txt_Precio.Tag = dtr_fila("tes_precio")
            int_i = dtr_fila("are_id")
            If CInt(dtr_fila("tes_padre")) <> 0 Then
                cmb_Padre.Text = opr_Test.ConsultaNombreTest(CInt(dtr_fila("tes_padre")))
            Else
                cmb_Padre.SelectedIndex = 0
            End If
        Next
        cmb_Area.Text = opr_Area.AreaNombre(int_i)


        dts_test = opr_Test.ConsultarTest_resultado(int_codigo)
        'Selecciono los tipos de resultados en el CheckedList
        For Each dtr_fila In dts_test.Tables("Registros").Rows
            int_i = dtr_fila("res_id")
        Next

        Select Case int_i
            Case 1
                cmb_resultado.SelectedIndex = 0
            Case 2
                cmb_resultado.SelectedIndex = 1
            Case 3
                cmb_resultado.SelectedIndex = 2
            Case 4
                cmb_resultado.SelectedIndex = 3
            Case 5
                cmb_resultado.SelectedIndex = 4
            Case 6
                cmb_resultado.SelectedIndex = 5
            Case 8
                cmb_resultado.SelectedIndex = 6
            Case 9
                cmb_resultado.SelectedIndex = 7




        End Select


        dts_test = opr_Test.ConsultarTest_TipMuestra(int_codigo)
        'Selecciono el tipo de muestra del test 
        For Each dtr_fila In dts_test.Tables("Registros").Rows
            int_i = dtr_fila("tim_id")
            nombre_muestra = dtr_fila("tim_nombre")
        Next
        ''dtr_fila("tim_nombre").ToString().PadRight(50) & dtr_fila("tim_id").ToString().PadRight(5)
        cmb_muestra.Text = nombre_muestra.PadRight(50) & CStr(int_i).PadRight(5)

        cmb_tipo.Text = dgrd_testHijos.Item(dgrd_testHijos.CurrentCell.RowNumber, 8).ToString

        Dim dts_uni As New DataSet()
        Dim dtr_rowu As DataRow
        dts_uni = opr_Test.ConsultarUnidadTest(int_codigo)
        For Each dtr_rowu In dts_uni.Tables("Registros").Rows
            int_i = dtr_rowu(0)
        Next

        cmb_unidad.SelectedIndex = int_i
        dts_test.Clear()
        boo_flag = False  'Para saber que se puede actualizar 
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = dgrd_Test.CurrentCell.RowNumber
        dgrd_Test.CurrentCell = dgc_celda
        dgrd_Test.Select(dgrd_Test.CurrentCell.RowNumber)

    End Sub

    Private Sub chk_antiobiograma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_antiobiograma.CheckedChanged
        If chk_antiobiograma.Checked Then
            AB = 1
        Else
            AB = 0
        End If
    End Sub

    Private Sub chk_calculadora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_calculadora.CheckedChanged
        If chk_calculadora.Checked Then
            calc = 1
        Else
            calc = 0
        End If
    End Sub

    Private Sub cmb_resultado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_resultado.SelectedIndexChanged
        If CInt(Trim(cmb_resultado.Text.Substring(80, 1))) = "8" Then
            'cmb_tipo.SelectedIndex = 1
            cmb_Padre.Enabled = False
        Else
            cmb_Padre.Enabled = True
        End If
    End Sub

    Private Sub cmb_Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Area.SelectedIndexChanged
        If Trim(Mid(cmb_Area.Text, 4, Len((cmb_Area.Text)))) = "MEDICINA" Or Trim(Mid(cmb_Area.Text, 4, Len((cmb_Area.Text)))) = "ODONTOLOGIA" Or Trim(Mid(cmb_Area.Text, 4, Len((cmb_Area.Text)))) = "ECOGRAFIA" Then
            cmb_tipo.Text = "Procedimiento"
            cmb_tipo.Enabled = False
            cmb_muestra.SelectedIndex = 50
            'cmb_muestra.Enabled = False
            cmb_equip.SelectedIndex = 5
            cmb_equip.Enabled = False
        Else
            'cmb_tipo.SelectedIndex = 0
            cmb_tipo.Enabled = True
            'cmb_muestra.SelectedIndex = 0
            cmb_muestra.Enabled = True
            cmb_equip.Enabled = True
            'cmb_tipo.Text = "Procedimiento"
        End If
    End Sub

    Private Sub txt_Param_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Param.TextChanged
        opr_Test.ordena_test(txt_Param.Text, dtv_testHijos)
    End Sub

    Private Sub rbt_SoloTest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_SoloTest.CheckedChanged
        If rbt_SoloTest.Checked Then
            filtro_rbt = True
            opr_Test.LlenarGridtest(dtv_test, filtro_rbt)
        Else
            filtro_rbt = False
            opr_Test.LlenarGridtest(dtv_test, filtro_rbt)
        End If
    End Sub

    Private Sub rbt_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Todos.CheckedChanged
        If rbt_Todos.Checked Then
            filtro_rbt = False
            opr_Test.LlenarGridtest(dtv_test, filtro_rbt)
        Else
            filtro_rbt = True
            opr_Test.LlenarGridtest(dtv_test, filtro_rbt)
        End If
    End Sub


    Private Sub btn_formatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_formatos.Click
        'btn_param.Enabled = False
        Dim frm_MDIChild As New frm_formatos()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.tes_id = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0)
        frm_MDIChild.ShowDialog(Me.ParentForm)
    End Sub

    Private Sub btn_Cie10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cie10.Click
        Dim frm_MDIChild As New frm_Cie10Gestion()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        'frm_MDIChild.tes_id = dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0)
        frm_MDIChild.ShowDialog(Me.ParentForm)
    End Sub
End Class
