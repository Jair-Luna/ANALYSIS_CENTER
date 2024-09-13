Public Class frm_Acerca
    Inherits System.Windows.Forms.Form

#Region "Código de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Dim imageToDraw As Image

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pan_barra.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Función para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter
        'cuando el mouse se mueve por encima del los botones del formulario
        'Select Case sender.name
        '    Case "pic_min"
        '        If m_HtImages.ContainsKey("btn_minp") Then
        '            imageToDraw = CType(m_HtImages("btn_minp"), System.Drawing.Image)
        '        Else
        '            Try
        '                imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_minp.jpg")
        '                m_HtImages.Add("btn_minp", imageToDraw)
        '            Catch
        '                Return
        '            End Try
        '        End If
        '        sender.Image = imageToDraw
        '    Case "Pic_close"
        '        If m_HtImages.ContainsKey("btn_closep") Then
        '            imageToDraw = CType(m_HtImages("btn_closep"), System.Drawing.Image)
        '        Else
        '            Try
        '                imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_closep.jpg")
        '                m_HtImages.Add("btn_closep", imageToDraw)
        '            Catch
        '                Return
        '            End Try
        '        End If
        '        sender.Image = imageToDraw
        '    Case Else
        '        If sender.name Like "btn_*" Then
        '            sender.Font = New Font(Me.Font, FontStyle.Bold)
        '            sender.forecolor = Color.White
        '            If m_HtImages.ContainsKey("barraMenu1") Then
        '                imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
        '            Else
        '                Try
        '                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
        '                    m_HtImages.Add("barraMenu1", imageToDraw)
        '                Catch
        '                    Return
        '                End Try
        '            End If
        '            sender.BackgroundImage = imageToDraw
        '        End If
        'End Select
    End Sub

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave
        'cuando el mouse se pierde el enfoque del los botones del formulario
        'Select Case sender.name
        '    Case "pic_min"
        '        If m_HtImages.ContainsKey("btn_min") Then
        '            imageToDraw = CType(m_HtImages("btn_min"), System.Drawing.Image)
        '        Else
        '            Try
        '                imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_min.jpg")
        '                m_HtImages.Add("btn_min", imageToDraw)
        '            Catch
        '                Return
        '            End Try
        '        End If
        '        sender.Image = imageToDraw
        '    Case "Pic_close"
        '        If m_HtImages.ContainsKey("btn_close") Then
        '            imageToDraw = CType(m_HtImages("btn_close"), System.Drawing.Image)
        '        Else
        '            Try
        '                imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_close.jpg")
        '                m_HtImages.Add("btn_close", imageToDraw)
        '            Catch
        '                Return
        '            End Try
        '        End If
        '        sender.Image = imageToDraw
        '    Case Else
        '        If sender.name Like "btn_*" Then
        '            sender.Font = New Font(Me.Font, FontStyle.Regular)
        '            sender.forecolor = Color.Black
        '            If m_HtImages.ContainsKey("barraMenu2") Then
        '                imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
        '            Else
        '                Try
        '                    imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
        '                    m_HtImages.Add("barraMenu2", imageToDraw)
        '                Catch
        '                    Return
        '                End Try
        '            End If
        '            sender.BackgroundImage = imageToDraw
        '        End If
        'End Select
    End Sub

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_usu As System.Windows.Forms.Label
    Friend WithEvents lbl_maq As System.Windows.Forms.Label
    Friend WithEvents lbl_ProId As System.Windows.Forms.Label
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Acerca))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_usu = New System.Windows.Forms.Label
        Me.lbl_maq = New System.Windows.Forms.Label
        Me.lbl_ProId = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 68)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(18, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 76)
        Me.Label2.TabIndex = 28
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(296, 305)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Aceptar.TabIndex = 0
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(346, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Copyright © 2014 TRUESolutions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_usu
        '
        Me.lbl_usu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_usu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usu.ForeColor = System.Drawing.Color.Navy
        Me.lbl_usu.Location = New System.Drawing.Point(95, 147)
        Me.lbl_usu.Name = "lbl_usu"
        Me.lbl_usu.Size = New System.Drawing.Size(208, 20)
        Me.lbl_usu.TabIndex = 33
        Me.lbl_usu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_maq
        '
        Me.lbl_maq.BackColor = System.Drawing.Color.Transparent
        Me.lbl_maq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_maq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maq.ForeColor = System.Drawing.Color.Navy
        Me.lbl_maq.Location = New System.Drawing.Point(95, 171)
        Me.lbl_maq.Name = "lbl_maq"
        Me.lbl_maq.Size = New System.Drawing.Size(208, 20)
        Me.lbl_maq.TabIndex = 34
        Me.lbl_maq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ProId
        '
        Me.lbl_ProId.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ProId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ProId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProId.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ProId.Location = New System.Drawing.Point(47, 123)
        Me.lbl_ProId.Name = "lbl_ProId"
        Me.lbl_ProId.Size = New System.Drawing.Size(304, 20)
        Me.lbl_ProId.TabIndex = 35
        Me.lbl_ProId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(395, 25)
        Me.pan_barra.TabIndex = 91
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(51, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(286, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'frm_Acerca
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 360)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.lbl_ProId)
        Me.Controls.Add(Me.lbl_maq)
        Me.Controls.Add(Me.lbl_usu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Acerca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Me.Close()
    End Sub

    Private Sub frm_Acerca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_ProId.Text = g_Titulo
        lbl_usu.Text = Environment.UserName.ToString
        lbl_maq.Text = Environment.MachineName.ToString

        'Dim dts_listaM As New DataSet
        'Dim opr_res As New Cls_Resultado()
        'lst_manuales.Items.Clear()

        'MsgBox("hola")
        'dts_listaM = opr_res.LlenaListManuales(lst_manuales, g_orden, 0)
    End Sub

End Class
