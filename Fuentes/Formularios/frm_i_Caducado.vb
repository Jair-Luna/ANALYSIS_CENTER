'*************************************************************************
' Nombre:   frm_i_Caducado
' Tipo de Archivo: formulario
' Descripción:  formulario que me permite visualizar los productos caducados
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_i_Caducado
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_bodega As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstv_caducado As System.Windows.Forms.ListView
    Friend WithEvents imgl_caducado As System.Windows.Forms.ImageList
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents cmb_divisiones As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_Caducado))
        Me.lstv_caducado = New System.Windows.Forms.ListView
        Me.imgl_caducado = New System.Windows.Forms.ImageList(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_bodega = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.cmb_divisiones = New System.Windows.Forms.ComboBox
        Me.cmb_tipo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstv_caducado
        '
        Me.lstv_caducado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstv_caducado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstv_caducado.Location = New System.Drawing.Point(7, 156)
        Me.lstv_caducado.Name = "lstv_caducado"
        Me.lstv_caducado.Size = New System.Drawing.Size(584, 242)
        Me.lstv_caducado.TabIndex = 1
        Me.lstv_caducado.UseCompatibleStateImageBehavior = False
        '
        'imgl_caducado
        '
        Me.imgl_caducado.ImageStream = CType(resources.GetObject("imgl_caducado.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgl_caducado.TransparentColor = System.Drawing.Color.Transparent
        Me.imgl_caducado.Images.SetKeyName(0, "")
        Me.imgl_caducado.Images.SetKeyName(1, "")
        Me.imgl_caducado.Images.SetKeyName(2, "")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Bodega:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_bodega
        '
        Me.cmb_bodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bodega.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bodega.Location = New System.Drawing.Point(80, 41)
        Me.cmb_bodega.Name = "cmb_bodega"
        Me.cmb_bodega.Size = New System.Drawing.Size(181, 21)
        Me.cmb_bodega.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(7, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 32)
        Me.Panel1.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(198, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Caduca a largo plazo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(358, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(378, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Caduca en corto plazo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Producto caducado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(176, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.TabIndex = 122
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(600, 25)
        Me.pan_barra.TabIndex = 127
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(4, 6)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(80, 13)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "  CADUCIDAD"
        '
        'cmb_divisiones
        '
        Me.cmb_divisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_divisiones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_divisiones.Location = New System.Drawing.Point(404, 218)
        Me.cmb_divisiones.Name = "cmb_divisiones"
        Me.cmb_divisiones.Size = New System.Drawing.Size(144, 21)
        Me.cmb_divisiones.TabIndex = 129
        Me.cmb_divisiones.Visible = False
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.Items.AddRange(New Object() {"<Escoger>", "Todos", "Caducado", "Corto plazo", "Largo plazo"})
        Me.cmb_tipo.Location = New System.Drawing.Point(103, 82)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(110, 21)
        Me.cmb_tipo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 12)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Tipo de Vista:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_hasta
        '
        Me.lbl_hasta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hasta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasta.ForeColor = System.Drawing.Color.Black
        Me.lbl_hasta.Location = New System.Drawing.Point(401, 86)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(46, 14)
        Me.lbl_hasta.TabIndex = 137
        Me.lbl_hasta.Text = "Hasta:"
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Black
        Me.lbl_desde.Location = New System.Drawing.Point(233, 86)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(46, 14)
        Me.lbl_desde.TabIndex = 136
        Me.lbl_desde.Text = "Desde:"
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fi.Location = New System.Drawing.Point(299, 82)
        Me.dtp_fi.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(88, 21)
        Me.dtp_fi.TabIndex = 2
        Me.dtp_fi.Value = New Date(2003, 8, 13, 15, 32, 45, 171)
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ff.Location = New System.Drawing.Point(469, 82)
        Me.dtp_ff.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_ff.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(86, 21)
        Me.dtp_ff.TabIndex = 3
        Me.dtp_ff.Value = New Date(2003, 8, 13, 15, 32, 45, 203)
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(418, 420)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 24)
        Me.btn_imprimir.TabIndex = 4
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(508, 420)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'frm_i_Caducado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(600, 472)
        Me.Controls.Add(Me.lstv_caducado)
        Me.Controls.Add(Me.lbl_hasta)
        Me.Controls.Add(Me.lbl_desde)
        Me.Controls.Add(Me.dtp_fi)
        Me.Controls.Add(Me.dtp_ff)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.cmb_divisiones)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_bodega)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_i_Caducado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caducidad de Productos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim opr_movimiento As New Cls_i_Movimiento()
    Dim opr_bodega As New Cls_i_Bodega()
    'Dim sng_dias, sng_diasexp As Single
    Public TIPO As String = Nothing

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
        'cmb_tipo.Text = TIPO
    End Sub

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseDown
        'Función para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseEnter, btn_imprimir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseLeave, btn_imprimir.MouseLeave
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

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub frm_i_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'obtengo de app.config el numero dias para que me indique cuando se caduca
        'sng_dias = System.Configuration.ConfigurationSettings.AppSettings("dias")
        'sng_diasexp = System.Configuration.ConfigurationSettings.AppSettings("diasexp")


        If g_division = 0 Then
            'mando a llenar el combo de bodegas
            opr_bodega.LlenarCombodivision(cmb_divisiones)
        Else
            opr_bodega.LlenarCombodivision(cmb_divisiones)
            cmb_divisiones.Enabled = False
            cmb_divisiones.SelectedIndex = g_division - 1
            'opr_bodega.LlenarComboBodega(cmb_bodega, g_division)
        End If
        'opr_bodega.LlenarComboBodega(cmb_bodega)
        dtp_fi.Value = CDate("01/01/" & Year(Now))
        dtp_ff.Value = Now
        'defino las columnas del listview
        lstv_caducado.View = View.Details
        lstv_caducado.Columns.Add("CODIGO", 95, HorizontalAlignment.Left)
        lstv_caducado.Columns.Add("PRODUCTO", 275, HorizontalAlignment.Left)
        lstv_caducado.Columns.Add("CANTIDAD", 50, HorizontalAlignment.Right)
        lstv_caducado.Columns.Add("UNIDAD", 55, HorizontalAlignment.Left)
        lstv_caducado.Columns.Add("FECHA", 85, HorizontalAlignment.Left)
        lstv_caducado.Columns.Add("LOTE", 60, HorizontalAlignment.Left)
        lstv_caducado.SmallImageList = imgl_caducado
        cmb_bodega.SelectedIndex = 0


        Select Case TIPO
            Case "Corto plazo"
                cmb_tipo.SelectedIndex = 3
                btn_imprimir.PerformClick()
                'Me.Close()
            Case "Caducados"
                cmb_tipo.SelectedIndex = 2
                btn_imprimir.PerformClick()
                'Me.Close()
            Case "Todos"
                cmb_tipo.SelectedIndex = 1
            Case "<Escoger>"
                cmb_tipo.SelectedIndex = 0
        End Select
    End Sub

    Private Sub cmb_bodega_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_bodega.SelectedIndexChanged
        'cuando cambia la bodega, se refresca el listview 
        'carga los productos por caducarce o caducados
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        Dim conteo As Integer
        Dim dts_operacion As New DataSet

        'opr_movimiento.LlenarListaCaducado(lstv_caducado, Trim(cmb_bodega.Text.Substring(0, 15)), sng_dias, sng_diasexp)
        If cmb_tipo.Text = "<Escoger>" Or cmb_tipo.Text = "" Then
            Me.Cursor = Windows.Forms.Cursors.Arrow
            Exit Sub
        ElseIf cmb_tipo.Text = "Anual" Then
            opr_movimiento.LlenarListaCaducado(lstv_caducado, Trim(cmb_bodega.Text.Substring(0, 15)), "formulario", conteo, dts_operacion, cmb_tipo.Text, dtp_fi.Value, dtp_ff.Value)
        ElseIf cmb_tipo.Text <> "" Then
            opr_movimiento.LlenarListaCaducado(lstv_caducado, Trim(cmb_bodega.Text.Substring(0, 15)), "formulario", conteo, dts_operacion, cmb_tipo.Text)
        Else
            opr_movimiento.LlenarListaCaducado(lstv_caducado, Trim(cmb_bodega.Text.Substring(0, 15)), "formulario", conteo, dts_operacion)
        End If
        Me.Cursor = Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        'INSTRUCCION SQL QUE ME PERMITE OBTENER EL STOCK DE PRODUCTOS DE UNA DETERMINADA BODEGA HASTA UNA FECHA ESPECIFICA
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim dts_caducado As New DataSet()
        Dim dtt_caducado As New DataTable("Registros")
        dts_caducado.Tables.Add(dtt_caducado)
        Dim dtc_columna1 As New DataColumn("CODIGO", GetType(System.String))
        Dim dtc_columna2 As New DataColumn("PRODUCTO", GetType(System.String))
        Dim dtc_columna3 As New DataColumn("CANTIDAD", GetType(System.String))
        Dim dtc_columna4 As New DataColumn("UNIDAD", GetType(System.String))
        Dim dtc_columna5 As New DataColumn("FECHA", GetType(System.String))
        Dim dtc_columna6 As New DataColumn("BODEGA", GetType(System.String))
        Dim dtc_columna7 As New DataColumn("LOTE", GetType(System.String))
        Dim dtc_columna8 As New DataColumn("ESTADO", GetType(System.String))

        dts_caducado.Tables("Registros").Columns.Add(dtc_columna1)
        dts_caducado.Tables("Registros").Columns.Add(dtc_columna2)
        dts_caducado.Tables("Registros").Columns.Add(dtc_columna3)
        dts_caducado.Tables("Registros").Columns.Add(dtc_columna4)
        dts_caducado.Tables("Registros").Columns.Add(dtc_columna5)
        dts_caducado.Tables("Registros").Columns.Add(dtc_columna6)
        dts_caducado.Tables("Registros").Columns.Add(dtc_columna7)
        dts_caducado.Tables("Registros").Columns.Add(dtc_columna8)
        Dim int_i As Integer
        For int_i = 0 To lstv_caducado.Items.Count - 1
            Dim dtr_fila As DataRow = dts_caducado.Tables("Registros").NewRow
            dtr_fila(0) = lstv_caducado.Items(int_i).Text
            dtr_fila(1) = lstv_caducado.Items(int_i).SubItems(1).Text
            dtr_fila(2) = lstv_caducado.Items(int_i).SubItems(2).Text
            dtr_fila(3) = lstv_caducado.Items(int_i).SubItems(3).Text
            dtr_fila(4) = Format(CDate(lstv_caducado.Items(int_i).SubItems(4).Text), "dd/MM/yyyy")
            dtr_fila(5) = Trim(cmb_bodega.Text.Substring(0, 15))
            dtr_fila(6) = lstv_caducado.Items(int_i).SubItems(5).Text
            If lstv_caducado.Items(int_i).ImageIndex = 0 Then
                dtr_fila(7) = "Caduca en largo plazo"
            ElseIf lstv_caducado.Items(int_i).ImageIndex = 1 Then
                dtr_fila(7) = "Caducado"
            ElseIf lstv_caducado.Items(int_i).ImageIndex = 2 Then
                dtr_fila(7) = "Caduca en corto plazo"
            Else
                dtr_fila(7) = ""
            End If
            dts_caducado.Tables("Registros").Rows.Add(dtr_fila)
        Next
        Dim str_sql As String
        Dim obj_reporte As New rpt_i_caducado()

        ''Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        Dim frm_MDIChild As New Frm_reportes("", "", obj_reporte, dts_caducado)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Caducidad de Productos"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub


    Private Sub cmb_divisiones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_divisiones.SelectedValueChanged
        opr_bodega.LlenarComboBodega(cmb_bodega, CInt(Trim(Mid(cmb_divisiones.SelectedItem, 50))))
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo.SelectedIndexChanged
        Dim conteo As Integer
        Dim dts_operacion As New DataSet

        If cmb_tipo.Text = "Anual" Then
            lbl_desde.Visible = True
            lbl_hasta.Visible = True
            dtp_fi.Visible = True
            dtp_ff.Visible = True
            opr_movimiento.LlenarListaCaducado(lstv_caducado, Trim(Mid(cmb_bodega.Text, 100, 10)), "formulario", conteo, dts_operacion, cmb_tipo.Text, dtp_fi.Value, dtp_ff.Value)
        Else
            lbl_desde.Visible = False
            lbl_hasta.Visible = False
            dtp_fi.Visible = False
            dtp_ff.Visible = False
            If cmb_tipo.Text <> "<Escoger>" Then
                opr_movimiento.LlenarListaCaducado(lstv_caducado, Trim(Mid(cmb_bodega.Text, 100, 10)), "formulario", conteo, dts_operacion, cmb_tipo.Text)
            End If
        End If
    End Sub

    Private Sub dtp_ff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_ff.ValueChanged
        Dim conteo As Integer
        Dim dts_operacion As New DataSet

        If cmb_tipo.Text = "Anual" Then
            opr_movimiento.LlenarListaCaducado(lstv_caducado, Trim(cmb_bodega.Text.Substring(0, 15)), "formulario", conteo, dts_operacion, cmb_tipo.Text, dtp_fi.Value, dtp_ff.Value)
        End If
    End Sub
End Class
