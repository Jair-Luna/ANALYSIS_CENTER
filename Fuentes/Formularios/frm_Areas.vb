'*************************************************************************
' Nombre:   frm_Areas
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para la administracion de las �reas 
' Autores:  RFN
' Fecha de Creaci�n: Julio del 2012
' Autores:  RFN
' Ultima Modificaci�n: 18/07/2012
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System.Drawing.Printing
Public Class frm_Areas

    Inherits System.Windows.Forms.Form

#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Friend WithEvents dgrd_areaOrden2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_orden As System.Windows.Forms.Button
    Friend WithEvents grp_btn As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chk_ocupacional As System.Windows.Forms.CheckBox
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
    'Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    'Friend WithEvents lbl_Desc As System.Windows.Forms.Label
    Friend WithEvents dgrd_Areas As System.Windows.Forms.DataGrid
    'Friend WithEvents Ctl_txt_areaNom As Ctl_txt.ctl_txt_letras
    Friend WithEvents grp_Area As System.Windows.Forms.GroupBox
    'Friend WithEvents txt_AreaObs As System.Windows.Forms.TextBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_areaNom As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents txt_AreaObs As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipTubo As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim btn_abajo As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Areas))
        Dim btn_arriba As System.Windows.Forms.Button
        Me.dgrd_Areas = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.grp_Area = New System.Windows.Forms.GroupBox
        Me.chk_ocupacional = New System.Windows.Forms.CheckBox
        Me.cmb_tipTubo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Ctl_txt_areaNom = New Ctl_txt.ctl_txt_letras
        Me.txt_AreaObs = New System.Windows.Forms.TextBox
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_orden = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.dgrd_areaOrden2 = New System.Windows.Forms.DataGridView
        Me.grp_btn = New System.Windows.Forms.GroupBox
        btn_abajo = New System.Windows.Forms.Button
        btn_arriba = New System.Windows.Forms.Button
        CType(Me.dgrd_Areas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Area.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        CType(Me.dgrd_areaOrden2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_btn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_abajo
        '
        btn_abajo.BackColor = System.Drawing.Color.Transparent
        btn_abajo.Cursor = System.Windows.Forms.Cursors.Hand
        btn_abajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btn_abajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_abajo.ForeColor = System.Drawing.Color.Black
        btn_abajo.Image = CType(resources.GetObject("btn_abajo.Image"), System.Drawing.Image)
        btn_abajo.Location = New System.Drawing.Point(11, 187)
        btn_abajo.Name = "btn_abajo"
        btn_abajo.Size = New System.Drawing.Size(39, 31)
        btn_abajo.TabIndex = 106
        btn_abajo.UseVisualStyleBackColor = False
        AddHandler btn_abajo.Click, AddressOf Me.btn_abajo_Click
        '
        'btn_arriba
        '
        btn_arriba.BackColor = System.Drawing.Color.Transparent
        btn_arriba.Cursor = System.Windows.Forms.Cursors.Hand
        btn_arriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btn_arriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_arriba.ForeColor = System.Drawing.Color.Black
        btn_arriba.Image = CType(resources.GetObject("btn_arriba.Image"), System.Drawing.Image)
        btn_arriba.Location = New System.Drawing.Point(11, 148)
        btn_arriba.Name = "btn_arriba"
        btn_arriba.Size = New System.Drawing.Size(39, 33)
        btn_arriba.TabIndex = 105
        btn_arriba.UseVisualStyleBackColor = False
        AddHandler btn_arriba.Click, AddressOf Me.btn_arriba_Click
        '
        'dgrd_Areas
        '
        Me.dgrd_Areas.AllowNavigation = False
        Me.dgrd_Areas.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Areas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Areas.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Areas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Areas.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Areas.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Areas.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Areas.CaptionText = "AREAS"
        Me.dgrd_Areas.DataMember = ""
        Me.dgrd_Areas.FlatMode = True
        Me.dgrd_Areas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Areas.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Areas.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Areas.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Areas.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Areas.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Areas.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Areas.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Areas.Location = New System.Drawing.Point(9, 154)
        Me.dgrd_Areas.Name = "dgrd_Areas"
        Me.dgrd_Areas.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Areas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Areas.ParentRowsVisible = False
        Me.dgrd_Areas.PreferredColumnWidth = 145
        Me.dgrd_Areas.ReadOnly = True
        Me.dgrd_Areas.RowHeaderWidth = 20
        Me.dgrd_Areas.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Areas.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Areas.Size = New System.Drawing.Size(412, 365)
        Me.dgrd_Areas.TabIndex = 1
        Me.dgrd_Areas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Areas
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeaderWidth = 20
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID AREA"
        Me.DataGridTextBoxColumn1.MappingName = "are_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "are_nombre"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 260
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "OBSERVACION "
        Me.DataGridTextBoxColumn3.MappingName = "are_obs"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "TIPO TUBO"
        Me.DataGridTextBoxColumn4.MappingName = "tit_id"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "OCUP"
        Me.DataGridTextBoxColumn5.MappingName = "ARE_OCUPACIONAL"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'grp_Area
        '
        Me.grp_Area.BackColor = System.Drawing.Color.Transparent
        Me.grp_Area.Controls.Add(Me.chk_ocupacional)
        Me.grp_Area.Controls.Add(Me.cmb_tipTubo)
        Me.grp_Area.Controls.Add(Me.Label1)
        Me.grp_Area.Controls.Add(Me.lbl_Nombre)
        Me.grp_Area.Controls.Add(Me.Ctl_txt_areaNom)
        Me.grp_Area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Area.ForeColor = System.Drawing.Color.Navy
        Me.grp_Area.Location = New System.Drawing.Point(9, 74)
        Me.grp_Area.Name = "grp_Area"
        Me.grp_Area.Size = New System.Drawing.Size(478, 74)
        Me.grp_Area.TabIndex = 0
        Me.grp_Area.TabStop = False
        '
        'chk_ocupacional
        '
        Me.chk_ocupacional.AutoSize = True
        Me.chk_ocupacional.Location = New System.Drawing.Point(279, 43)
        Me.chk_ocupacional.Name = "chk_ocupacional"
        Me.chk_ocupacional.Size = New System.Drawing.Size(105, 17)
        Me.chk_ocupacional.TabIndex = 5
        Me.chk_ocupacional.Text = "OCUPACIONAL"
        Me.chk_ocupacional.UseVisualStyleBackColor = True
        '
        'cmb_tipTubo
        '
        Me.cmb_tipTubo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipTubo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipTubo.Location = New System.Drawing.Point(98, 39)
        Me.cmb_tipTubo.Name = "cmb_tipTubo"
        Me.cmb_tipTubo.Size = New System.Drawing.Size(162, 21)
        Me.cmb_tipTubo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "RECIPIENTE"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(18, 18)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(54, 18)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "NOMBRE"
        '
        'Ctl_txt_areaNom
        '
        Me.Ctl_txt_areaNom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_areaNom.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_areaNom.Location = New System.Drawing.Point(98, 14)
        Me.Ctl_txt_areaNom.Name = "Ctl_txt_areaNom"
        Me.Ctl_txt_areaNom.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_areaNom.Prp_CaracterPasswd = ""
        Me.Ctl_txt_areaNom.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_areaNom.Size = New System.Drawing.Size(292, 20)
        Me.Ctl_txt_areaNom.TabIndex = 0
        '
        'txt_AreaObs
        '
        Me.txt_AreaObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_AreaObs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AreaObs.Location = New System.Drawing.Point(53, 292)
        Me.txt_AreaObs.MaxLength = 149
        Me.txt_AreaObs.Multiline = True
        Me.txt_AreaObs.Name = "txt_AreaObs"
        Me.txt_AreaObs.Size = New System.Drawing.Size(332, 58)
        Me.txt_AreaObs.TabIndex = 1
        Me.txt_AreaObs.Visible = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(89, 31)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 39)
        Me.btn_Nuevo.TabIndex = 2
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_Nuevo, "Ingresar una nueva �rea")
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
        Me.btn_Salir.Location = New System.Drawing.Point(407, 31)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 39)
        Me.btn_Salir.TabIndex = 6
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_Salir, "Salir del formulario / Cerrar")
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(328, 31)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 39)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_Eliminar, "Eliminar una �rea")
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(168, 31)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 39)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Guardar Nombre"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_Aceptar, "Guardar los datos ingresados")
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btn_orden
        '
        Me.btn_orden.BackColor = System.Drawing.SystemColors.Control
        Me.btn_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orden.ForeColor = System.Drawing.Color.Black
        Me.btn_orden.Image = CType(resources.GetObject("btn_orden.Image"), System.Drawing.Image)
        Me.btn_orden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_orden.Location = New System.Drawing.Point(248, 31)
        Me.btn_orden.Name = "btn_orden"
        Me.btn_orden.Size = New System.Drawing.Size(80, 39)
        Me.btn_orden.TabIndex = 108
        Me.btn_orden.Text = "Guardar Orden"
        Me.btn_orden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_orden, "Eliminar una �rea")
        Me.btn_orden.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(500, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(6, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(156, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GESTION DE AREAS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgrd_areaOrden2
        '
        Me.dgrd_areaOrden2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrd_areaOrden2.Location = New System.Drawing.Point(99, 283)
        Me.dgrd_areaOrden2.Name = "dgrd_areaOrden2"
        Me.dgrd_areaOrden2.Size = New System.Drawing.Size(268, 84)
        Me.dgrd_areaOrden2.TabIndex = 107
        '
        'grp_btn
        '
        Me.grp_btn.Controls.Add(btn_arriba)
        Me.grp_btn.Controls.Add(btn_abajo)
        Me.grp_btn.Location = New System.Drawing.Point(427, 147)
        Me.grp_btn.Name = "grp_btn"
        Me.grp_btn.Size = New System.Drawing.Size(61, 372)
        Me.grp_btn.TabIndex = 109
        Me.grp_btn.TabStop = False
        '
        'frm_Areas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(500, 531)
        Me.Controls.Add(Me.grp_btn)
        Me.Controls.Add(Me.btn_orden)
        Me.Controls.Add(Me.dgrd_Areas)
        Me.Controls.Add(Me.dgrd_areaOrden2)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.txt_AreaObs)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.grp_Area)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Areas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Areas de test"
        CType(Me.dgrd_Areas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Area.ResumeLayout(False)
        Me.grp_Area.PerformLayout()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgrd_areaOrden2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_btn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private opr_Areas As New Cls_Areas()
    Private opr_param As New Cls_Parametros()
    'boo_flag es una bandera para saber si se actualiza o se ingresa un nuevo registro.
    Private boo_flag As Boolean   'True --> Nuevo registro, False --> Actualizar registro  
    Dim int_codigo As Integer   'c�digo del �rea a insertar


    Dim dtt_areas As New DataTable("Registros")
    Dim opr_convenio As New Cls_Convenio()
    Dim dtv_Areas As New DataView(dtt_areas)
    Dim nombre_old As String = Nothing
    Dim sw, mueve As Integer



    Private Sub frm_Areas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Area.Enabled = False
        'txt_AreaObs.Visible = True
        'dgrd_Areas.SetDataBinding(opr_Areas.LeerAreas(), "Registros")
        opr_param.LlenarCmb_TipTub(cmb_tipTubo)
        btn_Nuevo.Focus()
        boo_flag = False
        Ctl_txt_areaNom.txt_padre.MaxLength = 50
        'txt_AreaObs.MaxLength = 150


        dtt_areas.Clear()
        opr_Areas.LeerArea(dtt_areas)
        dtv_Areas.AllowNew = False
        dgrd_Areas.DataSource = dtv_Areas
        dgrd_areaOrden2.DataSource = dtv_Areas
        sw = 0
        mueve = 0
        'grp_btn.Enabled = False

    End Sub

    Private Sub limpiarCamposA()
        'Procedimiento para limpiar los campos de lformulario
        Ctl_txt_areaNom.texto_Asigna("")
        'txt_AreaObs.Text = ""
    End Sub

    Private Sub dgrd_Areas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Areas.CurrentCellChanged
        Grid_Seleccionar_Celda_Ped()

        dgrd_Areas.Select(dgrd_Areas.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_Area.Enabled = True
        int_codigo = dgrd_Areas.Item(dgrd_Areas.CurrentCell.RowNumber, 0)
        Ctl_txt_areaNom.texto_Asigna(dgrd_Areas.Item(dgrd_Areas.CurrentCell.RowNumber, 1))
        txt_AreaObs.Text = (dgrd_Areas.Item(dgrd_Areas.CurrentCell.RowNumber, 2).ToString())
        If dgrd_Areas.Item(dgrd_Areas.CurrentCell.RowNumber, 3).ToString() = "1" Then
            chk_ocupacional.Checked = True
        Else
            chk_ocupacional.Checked = False
        End If

        Dim int_i As Integer
        For int_i = 0 To (cmb_tipTubo.Items.Count - 1)
            If (Val(cmb_tipTubo.Items.Item(int_i).substring(50, 5)) = Val(dgrd_Areas.Item(dgrd_Areas.CurrentCell.RowNumber, 3).ToString())) Then
                cmb_tipTubo.SelectedIndex = int_i
                Exit For
            End If
        Next
        boo_flag = False
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = dgrd_Areas.CurrentCell.RowNumber
        dgrd_Areas.CurrentCell = dgc_celda
        dgrd_Areas.Select(dgrd_Areas.CurrentCell.RowNumber)
        sw = 1
    End Sub

    Private celdaanteriorped As Short

    Private Sub Grid_Seleccionar_Celda_Ped()
        On Error Resume Next
        'funci�n que no permite que exista selecci�n multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        dgrd_Areas.UnSelect(celdaanteriorped)
        dgrd_Areas.Select(dgrd_Areas.CurrentCell.RowNumber)
        celdaanteriorped = dgrd_Areas.CurrentCell.RowNumber
    End Sub


    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Dim dt_are As DataSet
        Dim dt_fila As DataRow
        Dim numTubo As Integer
        'Limpio los campos de ingreso de datos y activo los boton de aceptar
        Call limpiarCamposA()
        btn_Aceptar.Enabled = True
        grp_Area.Enabled = True
        Ctl_txt_areaNom.Focus()
        boo_flag = True
        sw = 1
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'Valido que los campos obligatorios estan ingresados
        Dim EsOcup As Byte

        If sw = 1 Then
            If (Ctl_txt_areaNom.texto_Recupera = "") Then
                MsgBox("Ingrese el nombre del area", MsgBoxStyle.Information, "ANALISYS")
                Ctl_txt_areaNom.Focus()
                Exit Sub
            End If
            'Verifico que no exista otra area con el mismo nombre
            If (opr_Areas.BuscarArea(Ctl_txt_areaNom.texto_Recupera) = True And boo_flag = True) Then
                MsgBox("El area ingresada ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
                Ctl_txt_areaNom.Focus()
                Exit Sub
            End If


            'Hago una diferencia entre los registros nuevos y las actualizaciones 
            If boo_flag = True Then    '*** Si se trata de una nueva AREA             
                int_codigo = opr_Areas.LeerMaxCodArea() + 1

                opr_Areas.GuardarArea(int_codigo, Ctl_txt_areaNom.texto_Recupera, UCase(opr_Areas.LeerMaxOrdenArea() + 1), cmb_tipTubo.Text.Substring(50, 5), EsOcup)
                sw = 0
                opr_Areas.LeerArea(dtt_areas)
                dtv_Areas.AllowNew = False
                dgrd_Areas.DataSource = dtv_Areas
                dgrd_areaOrden2.DataSource = dtv_Areas
            Else    '*** Si se trata de una actualizacion a una AREA 
                Dim obj_res As Object
                obj_res = MsgBox("Desea actualizar los datos?", MsgBoxStyle.YesNo, "ANALISYS")
                If (obj_res = vbYes) Then
                    opr_Areas.ActualizarAreas(int_codigo, Ctl_txt_areaNom.texto_Recupera, UCase(txt_AreaObs.Text.ToString), cmb_tipTubo.Text.Substring(50, 5), EsOcup)
                    sw = 0
                    opr_Areas.LeerArea(dtt_areas)
                    dtv_Areas.AllowNew = False
                    dgrd_Areas.DataSource = dtv_Areas
                    dgrd_areaOrden2.DataSource = dtv_Areas
                Else
                    Call limpiarCamposA()
                    grp_Area.Enabled = False
                    btn_Aceptar.Enabled = False
                    btn_Nuevo.Focus()
                    btn_Eliminar.Enabled = False
                    Exit Sub
                End If
            End If
            'If sw = "orden" Then
            '    opr_Areas.ActualizarAreasOrden(int_codigo, UCase(txt_AreaObs.Text.ToString))
            '    sw = Nothing
            'End If

            Call limpiarCamposA()
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            grp_Area.Enabled = False
            dgrd_Areas.SetDataBinding(opr_Areas.LeerAreas(), "Registros")
            btn_Nuevo.Focus()
        Else
            MsgBox("Debe Guardar los cambios", MsgBoxStyle.Information, "ANALISYS")
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If MsgBox("Desea eliminar el �rea seleccionada?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            opr_Areas.EliminarArea(int_codigo)
            dgrd_Areas.SetDataBinding(opr_Areas.LeerAreas(), "Registros")
        End If

        Call limpiarCamposA()
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Area.Enabled = False

    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_areas()
        'Envio el sql que se requiere para que genere Crystal el reporte deseado
        str_sql = "SELECT AREA.ARE_NOMBRE AS ARE_NOMBRE, TEST.ARE_ID, TEST.TES_ID, TEST.TES_NOMBRE AS TES_NOMBRE, AREA.ARE_OBS AS ARE_OBS FROM AREA, TEST WHERE AREA.ARE_ID = TEST.ARE_ID order by TEST.tes_id asc;"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Areas"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub


    Private Sub btn_arriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mueve = 1
        Dim fd As Integer = 1
        Dim LaFila As Integer = dgrd_areaOrden2.CurrentRow.Index
        Dim LaFilaAnterior As Integer = dgrd_areaOrden2.CurrentRow.Index - fd

        Dim FilaOrigen As DataGridViewRow = dgrd_areaOrden2.Rows(LaFila)
        Dim FilaDestino As DataGridViewRow = dgrd_areaOrden2.Rows(LaFilaAnterior)

        Dim rowDataOrigen As Object() = New Object(FilaOrigen.Cells.Count - 1) {}
        Dim rowDataDestino As Object() = New Object(FilaDestino.Cells.Count - 1) {}

        'Cargo los valores de las respectivas celdas a copiar

        For i As Integer = 0 To rowDataOrigen.Length - 1
            rowDataOrigen(i) = FilaOrigen.Cells(i).Value
            rowDataDestino(i) = FilaDestino.Cells(i).Value
            nombre_old = FilaDestino.Cells(1).Value
            Ctl_txt_areaNom.texto_Asigna(nombre_old)
        Next

        'Aqui realizo el cambio de fila

        For i As Integer = 0 To rowDataOrigen.Length - 1
            dgrd_areaOrden2.Rows(LaFila).Cells(i).Value = rowDataDestino(i)
            dgrd_areaOrden2.Rows(LaFila - fd).Cells(i).Value = rowDataOrigen(i)
            dgrd_areaOrden2.CurrentCell = dgrd_areaOrden2.Item(0, LaFila - fd)
        Next
    End Sub

    Private Sub btn_abajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mueve = 1
        Dim fd As Integer = 1
        Dim LaFila As Integer = dgrd_areaOrden2.CurrentRow.Index
        Dim LaFilaProxima As Integer = dgrd_areaOrden2.CurrentRow.Index + fd

        Dim FilaOrigen As DataGridViewRow = dgrd_areaOrden2.Rows(LaFila)
        Dim FilaDestino As DataGridViewRow = dgrd_areaOrden2.Rows(LaFilaProxima)

        Dim rowDataOrigen As Object() = New Object(FilaOrigen.Cells.Count - 1) {}
        Dim rowDataDestino As Object() = New Object(FilaDestino.Cells.Count - 1) {}

        'Cargo los valores de las respectivas celdas a copiar

        For i As Integer = 0 To rowDataOrigen.Length - 1
            rowDataOrigen(i) = FilaOrigen.Cells(i).Value
            rowDataDestino(i) = FilaDestino.Cells(i).Value
            nombre_old = FilaDestino.Cells(1).Value
            Ctl_txt_areaNom.texto_Asigna(nombre_old)

        Next

        'Aqui realizo el cambio de fila

        For i As Integer = 0 To rowDataOrigen.Length - 1
            dgrd_areaOrden2.Rows(LaFila).Cells(i).Value = rowDataDestino(i)
            dgrd_areaOrden2.Rows(LaFila + fd).Cells(i).Value = rowDataOrigen(i)
            dgrd_areaOrden2.CurrentCell = dgrd_areaOrden2.Item(0, LaFila + fd)
        Next
    End Sub



    Private Sub btn_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orden.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If sw = 1 And mueve = 1 Then
            opr_Areas.GuardarordenArea(dgrd_Areas, (dtv_Areas.Count - 1))
            mueve = 0
        Else
            MsgBox("Debe guardar los cambios antes de guardar el orden", MsgBoxStyle.Information, "ANALISYS")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
End Class
