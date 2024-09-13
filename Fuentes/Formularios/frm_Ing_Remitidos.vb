Imports System.IO
Imports System.Text
Imports System.Collections
Imports AcroPDFLib
'Imports AxAcroPDFLib


Public Class frm_Ing_Remitidos
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents pic_min As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents rbtn_apellido As System.Windows.Forms.RadioButton
    Friend WithEvents Dgrd_remitidos As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents rbtn_cedula As System.Windows.Forms.RadioButton
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents rbtn_archivo As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Ing_Remitidos))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.pan_btn = New System.Windows.Forms.Panel
        Me.pic_min = New System.Windows.Forms.PictureBox
        Me.Pic_close = New System.Windows.Forms.PictureBox
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.rbtn_apellido = New System.Windows.Forms.RadioButton
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.Dgrd_remitidos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.rbtn_cedula = New System.Windows.Forms.RadioButton
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.rbtn_archivo = New System.Windows.Forms.RadioButton
        Me.pan_btn.SuspendLayout()
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrd_remitidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.Add(Me.pic_min)
        Me.pan_btn.Controls.Add(Me.Pic_close)
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(552, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(27, 12)
        Me.pan_btn.TabIndex = 110
        '
        'pic_min
        '
        Me.pic_min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pic_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_min.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_min.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pic_min.Image = CType(resources.GetObject("pic_min.Image"), System.Drawing.Image)
        Me.pic_min.Location = New System.Drawing.Point(0, 0)
        Me.pic_min.Name = "pic_min"
        Me.pic_min.Size = New System.Drawing.Size(12, 12)
        Me.pic_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_min.TabIndex = 2
        Me.pic_min.TabStop = False
        '
        'Pic_close
        '
        Me.Pic_close.BackColor = System.Drawing.SystemColors.Control
        Me.Pic_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pic_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pic_close.Image = CType(resources.GetObject("Pic_close.Image"), System.Drawing.Image)
        Me.Pic_close.Location = New System.Drawing.Point(15, 0)
        Me.Pic_close.Name = "Pic_close"
        Me.Pic_close.Size = New System.Drawing.Size(12, 12)
        Me.Pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_close.TabIndex = 1
        Me.Pic_close.TabStop = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.White
        Me.lbl_textform.Image = CType(resources.GetObject("lbl_textform.Image"), System.Drawing.Image)
        Me.lbl_textform.Location = New System.Drawing.Point(18, 6)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(71, 13)
        Me.lbl_textform.TabIndex = 111
        Me.lbl_textform.Text = "REMITIDOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtn_apellido
        '
        Me.rbtn_apellido.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_apellido.Location = New System.Drawing.Point(162, 33)
        Me.rbtn_apellido.Name = "rbtn_apellido"
        Me.rbtn_apellido.Size = New System.Drawing.Size(72, 22)
        Me.rbtn_apellido.TabIndex = 116
        Me.rbtn_apellido.Text = "Apellido"
        Me.rbtn_apellido.UseVisualStyleBackColor = False
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(271, 35)
        Me.txt_filtro.MaxLength = 50
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(176, 21)
        Me.txt_filtro.TabIndex = 114
        '
        'Dgrd_remitidos
        '
        Me.Dgrd_remitidos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_remitidos.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_remitidos.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_remitidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_remitidos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_remitidos.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_remitidos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_remitidos.CaptionText = "LISTA DE REMITIDOS"
        Me.Dgrd_remitidos.DataMember = ""
        Me.Dgrd_remitidos.FlatMode = True
        Me.Dgrd_remitidos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_remitidos.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_remitidos.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_remitidos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_remitidos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_remitidos.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_remitidos.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_remitidos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_remitidos.Location = New System.Drawing.Point(12, 64)
        Me.Dgrd_remitidos.Name = "Dgrd_remitidos"
        Me.Dgrd_remitidos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_remitidos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_remitidos.ParentRowsVisible = False
        Me.Dgrd_remitidos.PreferredColumnWidth = 100
        Me.Dgrd_remitidos.ReadOnly = True
        Me.Dgrd_remitidos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_remitidos.RowHeaderWidth = 0
        Me.Dgrd_remitidos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_remitidos.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_remitidos.Size = New System.Drawing.Size(567, 431)
        Me.Dgrd_remitidos.TabIndex = 118
        Me.Dgrd_remitidos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_remitidos.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_remitidos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Ver"
        Me.DataGridTextBoxColumn5.MappingName = "btn"
        Me.DataGridTextBoxColumn5.Width = 20
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "No."
        Me.DataGridTextBoxColumn7.MappingName = "rem_id"
        Me.DataGridTextBoxColumn7.Width = 50
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "pac_id"
        Me.DataGridTextBoxColumn1.MappingName = "pac_id"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Paciente"
        Me.DataGridTextBoxColumn2.MappingName = "paciente"
        Me.DataGridTextBoxColumn2.Width = 280
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Cedula"
        Me.DataGridTextBoxColumn8.MappingName = "pac_doc"
        Me.DataGridTextBoxColumn8.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Laboratorio"
        Me.DataGridTextBoxColumn3.MappingName = "lab_nombre"
        Me.DataGridTextBoxColumn3.Width = 220
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn4.MappingName = "rem_fecha"
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "ARCHIVO"
        Me.DataGridTextBoxColumn6.MappingName = "rem_file"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Location = New System.Drawing.Point(472, 33)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 25)
        Me.btn_buscar.TabIndex = 120
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'rbtn_cedula
        '
        Me.rbtn_cedula.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_cedula.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_cedula.Location = New System.Drawing.Point(89, 32)
        Me.rbtn_cedula.Name = "rbtn_cedula"
        Me.rbtn_cedula.Size = New System.Drawing.Size(68, 22)
        Me.rbtn_cedula.TabIndex = 115
        Me.rbtn_cedula.Text = "Cdula"
        Me.rbtn_cedula.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(498, 501)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 121
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbtn_archivo
        '
        Me.rbtn_archivo.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_archivo.Checked = True
        Me.rbtn_archivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_archivo.Location = New System.Drawing.Point(24, 32)
        Me.rbtn_archivo.Name = "rbtn_archivo"
        Me.rbtn_archivo.Size = New System.Drawing.Size(64, 22)
        Me.rbtn_archivo.TabIndex = 122
        Me.rbtn_archivo.TabStop = True
        Me.rbtn_archivo.Text = "Codigo"
        Me.rbtn_archivo.UseVisualStyleBackColor = False
        '
        'frm_Ing_Remitidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(600, 537)
        Me.Controls.Add(Me.rbtn_archivo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Dgrd_remitidos)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.rbtn_cedula)
        Me.Controls.Add(Me.rbtn_apellido)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.pan_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Ing_Remitidos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Ing_Remitidos"
        Me.pan_btn.ResumeLayout(False)
        CType(Me.pic_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrd_remitidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim opr_remitidos As New Cls_Remitidos()
    Private WithEvents dtt_remitidos As New DataTable("Registros")
    Dim dtv_remitidos As New DataView(dtt_remitidos)
    Dim opr_pedido As New Cls_Pedido()


    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        'funci�n que retorna true si existe el formulario creado en el MDI, false si no lo encuentra creado
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.MdiChildren
            If UCase(ctl.Name) = UCase(str_frmbusca) Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function

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

    'Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_min.MouseEnter, Pic_close.MouseEnter
    '    'cuando el mouse se mueve por encima del los botones del formulario
    '    Select Case sender.name
    '        Case "pic_min"
    '            If m_HtImages.ContainsKey("btn_minp") Then
    '                imageToDraw = CType(m_HtImages("btn_minp"), System.Drawing.Image)
    '            Else
    '                Try
    '                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_minp.jpg")
    '                    m_HtImages.Add("btn_minp", imageToDraw)
    '                Catch
    '                    Return
    '                End Try
    '            End If
    '            sender.Image = imageToDraw
    '        Case "Pic_close"
    '            If m_HtImages.ContainsKey("btn_closep") Then
    '                imageToDraw = CType(m_HtImages("btn_closep"), System.Drawing.Image)
    '            Else
    '                Try
    '                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_closep.jpg")
    '                    m_HtImages.Add("btn_closep", imageToDraw)
    '                Catch
    '                    Return
    '                End Try
    '            End If
    '            sender.Image = imageToDraw
    '        Case Else
    '            If sender.name Like "btn_*" Then
    '                sender.Font = New Font(Me.Font, FontStyle.Bold)
    '                sender.forecolor = Color.White
    '                If m_HtImages.ContainsKey("barraMenu1") Then
    '                    imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
    '                Else
    '                    Try
    '                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
    '                        m_HtImages.Add("barraMenu1", imageToDraw)
    '                    Catch
    '                        Return
    '                    End Try
    '                End If
    '                sender.BackgroundImage = imageToDraw
    '            End If
    '    End Select
    'End Sub

    'Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_min.MouseLeave, Pic_close.MouseLeave
    '    'cuando el mouse se pierde el enfoque del los botones del formulario
    '    Select Case sender.name
    '        Case "pic_min"
    '            If m_HtImages.ContainsKey("btn_min") Then
    '                imageToDraw = CType(m_HtImages("btn_min"), System.Drawing.Image)
    '            Else
    '                Try
    '                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_min.jpg")
    '                    m_HtImages.Add("btn_min", imageToDraw)
    '                Catch
    '                    Return
    '                End Try
    '            End If
    '            sender.Image = imageToDraw
    '        Case "Pic_close"
    '            If m_HtImages.ContainsKey("btn_close") Then
    '                imageToDraw = CType(m_HtImages("btn_close"), System.Drawing.Image)
    '            Else
    '                Try
    '                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_close.jpg")
    '                    m_HtImages.Add("btn_close", imageToDraw)
    '                Catch
    '                    Return
    '                End Try
    '            End If
    '            sender.Image = imageToDraw
    '        Case Else
    '            If sender.name Like "btn_*" Then
    '                sender.Font = New Font(Me.Font, FontStyle.Regular)
    '                sender.forecolor = Color.Black
    '                If m_HtImages.ContainsKey("barraMenu2") Then
    '                    imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
    '                Else
    '                    Try
    '                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
    '                        m_HtImages.Add("barraMenu2", imageToDraw)
    '                    Catch
    '                        Return
    '                    End Try
    '                End If
    '                sender.BackgroundImage = imageToDraw
    '            End If
    '    End Select
    'End Sub

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, lbl_textform.Click, pic_min.Click, Pic_close.Click
        'elimina las funciones activas (ej menu) del formulario MDI.
        'ClickMenu_Principal(Me)
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
        'ClickMenu_Principal(Me)
        'RemoveCtxMenu_Principal(Me, Me.Text)
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



    'Private Sub btn_AddPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    OpenFileDialog1.InitialDirectory = "C:/"
    '    OpenFileDialog1.Filter = "All Files|*.*|pdf|*.pdf"
    '    OpenFileDialog1.FilterIndex = 2

    '    If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
    '        lbl_ruta.Text = OpenFileDialog1.FileName
    '        Try
    '            'El metodo LoadFile recibe un String con la ubicacion del archivo que cargar�
    '            System.Diagnostics.Process.Start(lbl_ruta.Text)
    '            'AxAcroPDF1.LoadFile(Application.StartupPath & lbl_ruta.Text)
    '        Catch er As Exception
    '            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
    '        End Try
    '    End If
    'End Sub



    'Private Sub btn_SavePdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim pac_id, rem_fecha, pdf As String
    '    Dim sec As Integer
    '    Dim rem_id As Integer
    '    Try

    '        If (txt_laboratorio.Text <> "" Or txt_Paciente.Text <> "") Then
    '            'pac_id = Convert.ToInt32(Dgrd_remitidos.Item(Dgrd_remitidos.CurrentCell.RowNumber, 0).ToString)
    '            pac_id = lbl_pac_id.Text
    '            sec = opr_remitidos.LeerSecuencial(pac_id)
    '            rem_id = opr_remitidos.MaxRemitidos()
    '            rem_fecha = Format(dtp_Fecha.Value, "dd/MM/yyyy")

    '            opr_remitidos.GuardaPDF(ped_id, pac_id, sec, lbl_ruta.Text, pdf)
    '            opr_remitidos.GuardaRemitido(rem_id, Convert.ToInt32(pac_id), txt_laboratorio.Text, rem_fecha, txt_obs.Text, pdf)
    '            opr_remitidos.ActualizaSecuencial(pac_id, sec)
    '            llena_grid()
    '        Else
    '            MsgBox("Ingrese el nombre del laboratorio", MsgBoxStyle.Exclamation, "ANALISYS")
    '        End If


    '    Catch er As Exception

    '    End Try
    'End Sub

    Public Sub LLena_datos_paciente_doc()
        'toma los datos del paciete que son dvueltos entagdel formulario
        'luego d haber seleccioando del otro formulario
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        Dim boo_edad As Boolean = True
        'separo los campos en un arreglo
        str_campos = Split(Me.Tag, "/*/")
        'Cuando creo doctor y regreso al formulario de pedido impide que se borre datos del paciente ya ingresados
        Dim i As Integer
        'lbl_pac_id.Text = ""
        'recorro el arreglo
        For int_indice = 0 To UBound(str_campos)
            int_pos = InStr(str_campos(int_indice), "=")
            str_texto = str_campos(int_indice).Substring(0, int_pos - 1)
            str_valor = str_campos(int_indice).Substring(int_pos)
            'segun el nombredevuento el tag, guardo en cada unade las variables
            Select Case str_texto
                Case "pac_doc"
                    'lbl_doc.Text = (str_valor)
                Case "pac_apellido"
                    'txt_Paciente.Text = (str_valor)
                Case "pac_nombre"
                    'txt_Paciente.Text = txt_Paciente.Text & "  " & (str_valor)
                Case "pac_id"
                    'lbl_pac_id.Text = (str_valor)

            End Select
        Next
    End Sub


    Private Sub frm_Ing_Remitidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        llena_grid()
    End Sub

    Private Sub llena_grid()
        dtt_remitidos.Clear()
        opr_remitidos.Leerremitidos(dtt_remitidos)
        dtv_remitidos.AllowNew = False
        Dgrd_remitidos.DataSource = dtv_remitidos
    End Sub


    Private Sub Dgrd_remitidos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrd_remitidos.CurrentCellChanged
        Try
            Dim abrirPdf As String
            abrirPdf = g_pathremitidos & "\" & Dgrd_remitidos.Item(Dgrd_remitidos.CurrentCell.RowNumber, 2).ToString & "\" & Dgrd_remitidos.Item(Dgrd_remitidos.CurrentCell.RowNumber, 7).ToString
            System.Diagnostics.Process.Start(abrirPdf)
            'AxAcroPDF1.LoadFile(Application.StartupPath & abrirPdf)
        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
        End Try
    End Sub

    Private Sub btn_BuscaPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not ExisteForm("Frm_Paciente3") Then
        '    Dim str_tagaux As String
        '    str_tagaux = Me.Tag
        '    Dim frm_MDIChild As New frm_Paciente3()
        '    frm_MDIChild.frm_refer_main = Me.ParentForm
        '    frm_MDIChild.ShowDialog(Me.ParentForm)
        '    Me.Tag = str_tagaux
        'End If

    End Sub


    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Me.Cursor = Cursors.WaitCursor
        Dim criterio As String
        If txt_filtro.Text = "" Then
            MsgBox("Ingrese al menos un caracter para iniciar la busqueda.", MsgBoxStyle.Information, "ANALISYS")
            txt_filtro.Focus()
        Else
            If (rbtn_archivo.Checked) Then
                criterio = "codigo"
            End If
            If (rbtn_cedula.Checked) Then
                criterio = "cedula"
            End If
            If (rbtn_apellido.Checked) Then
                criterio = "apellido"
            End If


            opr_remitidos.LlenarGridRemitidos(Dgrd_remitidos, criterio, Trim(txt_filtro.Text))
        End If

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub rbtn_cedula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_cedula.CheckedChanged
        txt_filtro.Text = ""
        txt_filtro.Focus()
    End Sub

    Private Sub rbtn_archivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_archivo.CheckedChanged
        txt_filtro.Text = ""
        txt_filtro.Focus()
    End Sub

    Private Sub rbtn_apellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_apellido.CheckedChanged
        txt_filtro.Text = ""
        txt_filtro.Focus()
    End Sub



    Private Sub Dgrd_remitidos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_remitidos.DoubleClick
        Try
            Dim abrirPdf As String
            abrirPdf = g_pathremitidos & "\" & Dgrd_remitidos.Item(Dgrd_remitidos.CurrentCell.RowNumber, 2).ToString & "\" & Dgrd_remitidos.Item(Dgrd_remitidos.CurrentCell.RowNumber, 7).ToString
            System.Diagnostics.Process.Start(abrirPdf)
        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
        End Try
    End Sub
End Class
