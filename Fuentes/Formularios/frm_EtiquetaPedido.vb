'*************************************************************************
' Nombre:   frm_EtiquetaPedido
' Tipo de Archivo: formulario
' Descripción:  formulario que me permite seleccionar el pedido  
'               para imprimir otras etiquetas
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación:  19/ENE/06
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Windows.Forms
Imports System.IO

Public Class frm_EtiquetaPedido
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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_filtro_apellido As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_seleccionar As System.Windows.Forms.MenuItem
    Friend WithEvents Dgrd_pedido As System.Windows.Forms.DataGrid
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents rbtn_apellido As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtn_turno As System.Windows.Forms.RadioButton
    Friend WithEvents btn_etiquetas As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EtiquetaPedido))
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Dgrd_pedido = New System.Windows.Forms.DataGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.Menu_seleccionar = New System.Windows.Forms.MenuItem
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_filtro_apellido = New System.Windows.Forms.TextBox
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.rbtn_apellido = New System.Windows.Forms.RadioButton
        Me.rbtn_turno = New System.Windows.Forms.RadioButton
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.btn_etiquetas = New System.Windows.Forms.Button
        CType(Me.Dgrd_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(458, 69)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 39)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Dgrd_pedido
        '
        Me.Dgrd_pedido.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_pedido.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_pedido.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_pedido.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_pedido.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_pedido.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_pedido.CaptionText = "PEDIDOS"
        Me.Dgrd_pedido.ContextMenu = Me.ContextMenu1
        Me.Dgrd_pedido.DataMember = ""
        Me.Dgrd_pedido.FlatMode = True
        Me.Dgrd_pedido.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Dgrd_pedido.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_pedido.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_pedido.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_pedido.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_pedido.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_pedido.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_pedido.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_pedido.Location = New System.Drawing.Point(19, 113)
        Me.Dgrd_pedido.Name = "Dgrd_pedido"
        Me.Dgrd_pedido.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_pedido.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_pedido.ParentRowsVisible = False
        Me.Dgrd_pedido.PreferredColumnWidth = 100
        Me.Dgrd_pedido.ReadOnly = True
        Me.Dgrd_pedido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_pedido.RowHeaderWidth = 0
        Me.Dgrd_pedido.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_pedido.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_pedido.Size = New System.Drawing.Size(518, 244)
        Me.Dgrd_pedido.TabIndex = 1
        Me.Dgrd_pedido.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_pedido.TabStop = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_seleccionar})
        '
        'Menu_seleccionar
        '
        Me.Menu_seleccionar.Index = 0
        Me.Menu_seleccionar.Text = "Imprimir"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_pedido
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Pedido"
        Me.DataGridTextBoxColumn1.MappingName = "ped_id"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Turno"
        Me.DataGridTextBoxColumn5.MappingName = "ped_turno"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 70
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn2.MappingName = "ped_fecing"
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridTextBoxColumn3.MappingName = "pac_apellido"
        Me.DataGridTextBoxColumn3.Width = 170
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn4.MappingName = "pac_nombre"
        Me.DataGridTextBoxColumn4.Width = 170
        '
        'txt_filtro_apellido
        '
        Me.txt_filtro_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro_apellido.Location = New System.Drawing.Point(197, 30)
        Me.txt_filtro_apellido.MaxLength = 50
        Me.txt_filtro_apellido.Name = "txt_filtro_apellido"
        Me.txt_filtro_apellido.Size = New System.Drawing.Size(340, 21)
        Me.txt_filtro_apellido.TabIndex = 0
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(564, 25)
        Me.pan_barra.TabIndex = 96
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(16, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(167, 13)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "  Imprimir etiquetas pedidos"
        '
        'rbtn_apellido
        '
        Me.rbtn_apellido.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_apellido.Location = New System.Drawing.Point(107, 33)
        Me.rbtn_apellido.Name = "rbtn_apellido"
        Me.rbtn_apellido.Size = New System.Drawing.Size(82, 16)
        Me.rbtn_apellido.TabIndex = 97
        Me.rbtn_apellido.Text = "Apellidos"
        Me.rbtn_apellido.UseVisualStyleBackColor = False
        '
        'rbtn_turno
        '
        Me.rbtn_turno.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_turno.Checked = True
        Me.rbtn_turno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_turno.Location = New System.Drawing.Point(39, 33)
        Me.rbtn_turno.Name = "rbtn_turno"
        Me.rbtn_turno.Size = New System.Drawing.Size(60, 16)
        Me.rbtn_turno.TabIndex = 98
        Me.rbtn_turno.TabStop = True
        Me.rbtn_turno.Text = "Turno"
        Me.rbtn_turno.UseVisualStyleBackColor = False
        '
        'btn_filtrar
        '
        Me.btn_filtrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtrar.ForeColor = System.Drawing.Color.Black
        Me.btn_filtrar.Image = CType(resources.GetObject("btn_filtrar.Image"), System.Drawing.Image)
        Me.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filtrar.Location = New System.Drawing.Point(291, 68)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(87, 38)
        Me.btn_filtrar.TabIndex = 154
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filtrar.UseVisualStyleBackColor = False
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Black
        Me.lbl_hasta.Location = New System.Drawing.Point(30, 86)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(46, 16)
        Me.lbl_hasta.TabIndex = 156
        Me.lbl_hasta.Text = "Hasta:"
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Black
        Me.lbl_desde.Location = New System.Drawing.Point(34, 59)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(46, 16)
        Me.lbl_desde.TabIndex = 155
        Me.lbl_desde.Text = "Desde:"
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fi.Location = New System.Drawing.Point(82, 55)
        Me.dtp_fi.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(86, 21)
        Me.dtp_fi.TabIndex = 152
        Me.dtp_fi.Value = New Date(2003, 8, 13, 15, 32, 45, 171)
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ff.Location = New System.Drawing.Point(82, 82)
        Me.dtp_ff.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_ff.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(86, 21)
        Me.dtp_ff.TabIndex = 153
        Me.dtp_ff.Value = New Date(2003, 8, 13, 15, 32, 45, 203)
        '
        'btn_etiquetas
        '
        Me.btn_etiquetas.BackColor = System.Drawing.SystemColors.Control
        Me.btn_etiquetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_etiquetas.ForeColor = System.Drawing.Color.Black
        Me.btn_etiquetas.Image = CType(resources.GetObject("btn_etiquetas.Image"), System.Drawing.Image)
        Me.btn_etiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_etiquetas.Location = New System.Drawing.Point(378, 68)
        Me.btn_etiquetas.Name = "btn_etiquetas"
        Me.btn_etiquetas.Size = New System.Drawing.Size(80, 39)
        Me.btn_etiquetas.TabIndex = 157
        Me.btn_etiquetas.Text = "Etiquetas"
        Me.btn_etiquetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_etiquetas.UseVisualStyleBackColor = False
        '
        'frm_EtiquetaPedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(564, 376)
        Me.Controls.Add(Me.btn_etiquetas)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.rbtn_turno)
        Me.Controls.Add(Me.rbtn_apellido)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.txt_filtro_apellido)
        Me.Controls.Add(Me.Dgrd_pedido)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_EtiquetaPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir etiquetas pedido"
        CType(Me.Dgrd_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Código de Formulario"
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
        'Función para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
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
        'Función para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub


    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseEnter, btn_filtrar.MouseEnter, btn_etiquetas.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseLeave, btn_filtrar.MouseLeave, btn_etiquetas.MouseLeave
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
        Dim int_posX As Integer
        int_posX = (Me.MdiParent.Size.Width - Me.MdiParent.Size.Width) / 2
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

    Dim opr_pedido As New Cls_Pedido()
    Dim dtv_pedido As New DataView()
    Dim opr_muestra As New Cls_Muestra()

    Dim str_imprimir, str_codigo_barras As String

    Private Sub frm_Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        Dgrd_pedido.DataSource = dtv_pedido
        'lleno el grid con los datos de los pedidos
        dtp_fi.Value = DateAdd(DateInterval.Day, -1, Now)
        dtp_ff.Value = Now
        opr_pedido.LlenarGridPedido(dtv_pedido, dtp_fi.Text, dtp_ff.Text)
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()


    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub Dgrd_paciente_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_pedido.CurrentCellChanged
        'selecciono toda la fila del grid
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = Dgrd_pedido.CurrentCell.RowNumber
        Dgrd_pedido.CurrentCell = dgc_celda
        Dgrd_pedido.Select(Dgrd_pedido.CurrentCell.RowNumber)
    End Sub

    Private Sub txt_filtro_apellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro_apellido.TextChanged
        'cada que preciono una tecla aplico un filtro al grid en base al apellido de los pacientes
        If rbtn_apellido.Checked = True Then
            opr_pedido.ordena_apellido(txt_filtro_apellido.Text, dtv_pedido)
        Else
            If txt_filtro_apellido.Text <> "" Then
                If IsNumeric(txt_filtro_apellido.Text) = True Then
                    opr_pedido.ordena_turno(txt_filtro_apellido.Text, dtv_pedido)
                Else
                    MsgBox("El pedido solo puede ser numérico", MsgBoxStyle.Information, "ANALISYS")
                End If
            Else
                dtv_pedido.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub Dgrd_paciente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_pedido.DoubleClick, Menu_seleccionar.Click
        'doble click paso a otro formulario para imprimir las etiquetas de ese pedido
        'realiza lo mismo que en dgrd_paciente_double_click
        On Error Resume Next
        Dim frm_MDIChild As New frm_Muestra()
        frm_MDIChild.MdiParent = Me.ParentForm
        g_lng_ped_id = Dgrd_pedido.Item(Dgrd_pedido.CurrentCell.RowNumber, 0).ToString
        frm_MDIChild.Show()
        Me.Close()
    End Sub





    Private Sub rbtn_apellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_apellido.CheckedChanged
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()
    End Sub
    Private Sub rbtn_turno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_turno.CheckedChanged
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()
    End Sub



    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Me.Cursor = Cursors.WaitCursor
        dtp_ff.Value = Format(dtp_ff.Value, "yyy-MM-dd")
        dtp_fi.Value = Format(dtp_fi.Value, "dd/MM/yyyy")
        If dtp_ff.Value < dtp_fi.Value Then
            MsgBox("La Fecha Final no puede ser menor a la Fecha Inicial", MsgBoxStyle.OkOnly, "ANALISYS")
        Else
            opr_pedido.LlenarGridPedido(dtv_pedido, dtp_fi.Text, dtp_ff.Text)
        End If
        txt_filtro_apellido.Text = ""
        txt_filtro_apellido.Focus()
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub btn_etiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_etiquetas.Click
        Dim frm_MDIChild As New frm_impcodigobarras()
        frm_MDIChild.frm_refer_main_form = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
    End Sub


End Class
