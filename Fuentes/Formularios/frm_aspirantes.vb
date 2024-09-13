Public Class frm_aspirantes
    Inherits System.Windows.Forms.Form
    Public frm_refer_main As Frm_Main
    Dim opr_pedido As New Cls_Pedido()

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
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents pic_min As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaf As System.Windows.Forms.Label
    Friend WithEvents lbl_fechai As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txt_desde As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents rbtn_act As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_ing As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_ascenso As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_aspirante As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_aspirantes))
        Me.pic_barra = New System.Windows.Forms.PictureBox()
        Me.lbl_textform = New System.Windows.Forms.Label()
        Me.pic_icono = New System.Windows.Forms.PictureBox()
        Me.pan_btn = New System.Windows.Forms.Panel()
        Me.pic_min = New System.Windows.Forms.PictureBox()
        Me.Pic_close = New System.Windows.Forms.PictureBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_fechaf = New System.Windows.Forms.Label()
        Me.lbl_fechai = New System.Windows.Forms.Label()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_hasta = New System.Windows.Forms.TextBox()
        Me.txt_desde = New System.Windows.Forms.TextBox()
        Me.rbtn_ascenso = New System.Windows.Forms.RadioButton()
        Me.rbtn_aspirante = New System.Windows.Forms.RadioButton()
        Me.rbtn_act = New System.Windows.Forms.RadioButton()
        Me.rbtn_ing = New System.Windows.Forms.RadioButton()
        Me.pan_btn.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Image = CType(resources.GetObject("pic_barra.Image"), System.Drawing.Bitmap)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(398, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 92
        Me.pic_barra.TabStop = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.White
        Me.lbl_textform.Image = CType(resources.GetObject("lbl_textform.Image"), System.Drawing.Bitmap)
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(35, 7)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(178, 14)
        Me.lbl_textform.TabIndex = 94
        Me.lbl_textform.Text = "  Ingreso Aspirantes/Ascensos"
        '
        'pic_icono
        '
        Me.pic_icono.BackColor = System.Drawing.Color.SteelBlue
        Me.pic_icono.Image = CType(resources.GetObject("pic_icono.Image"), System.Drawing.Bitmap)
        Me.pic_icono.Location = New System.Drawing.Point(11, 5)
        Me.pic_icono.Name = "pic_icono"
        Me.pic_icono.Size = New System.Drawing.Size(16, 16)
        Me.pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_icono.TabIndex = 95
        Me.pic_icono.TabStop = False
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.AddRange(New System.Windows.Forms.Control() {Me.pic_min, Me.Pic_close})
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(344, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(27, 12)
        Me.pan_btn.TabIndex = 96
        '
        'pic_min
        '
        Me.pic_min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pic_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_min.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_min.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pic_min.Image = CType(resources.GetObject("pic_min.Image"), System.Drawing.Bitmap)
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
        Me.Pic_close.Image = CType(resources.GetObject("Pic_close.Image"), System.Drawing.Bitmap)
        Me.Pic_close.Location = New System.Drawing.Point(15, 0)
        Me.Pic_close.Name = "Pic_close"
        Me.Pic_close.Size = New System.Drawing.Size(12, 12)
        Me.Pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_close.TabIndex = 1
        Me.Pic_close.TabStop = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CustomFormat = "ddd, dd - MMMM - yyyy"
        Me.dtp_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_fecha.Location = New System.Drawing.Point(80, 64)
        Me.dtp_fecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(92, 21)
        Me.dtp_fecha.TabIndex = 98
        Me.dtp_fecha.Value = New Date(2003, 7, 23, 0, 0, 0, 0)
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(24, 72)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(46, 14)
        Me.lbl_fecha.TabIndex = 97
        Me.lbl_fecha.Text = "Fecha:"
        '
        'lbl_fechaf
        '
        Me.lbl_fechaf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechaf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaf.Location = New System.Drawing.Point(216, 80)
        Me.lbl_fechaf.Name = "lbl_fechaf"
        Me.lbl_fechaf.Size = New System.Drawing.Size(44, 16)
        Me.lbl_fechaf.TabIndex = 100
        Me.lbl_fechaf.Text = "Hasta:"
        '
        'lbl_fechai
        '
        Me.lbl_fechai.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechai.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechai.Location = New System.Drawing.Point(24, 80)
        Me.lbl_fechai.Name = "lbl_fechai"
        Me.lbl_fechai.Size = New System.Drawing.Size(46, 14)
        Me.lbl_fechai.TabIndex = 99
        Me.lbl_fechai.Text = "Desde:"
        '
        'btn_Salir
        '
        Me.btn_Salir.BackgroundImage = CType(resources.GetObject("btn_Salir.BackgroundImage"), System.Drawing.Bitmap)
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Bitmap)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(216, 224)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 102
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackgroundImage = CType(resources.GetObject("btn_aceptar.BackgroundImage"), System.Drawing.Bitmap)
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Bitmap)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(104, 224)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 24)
        Me.btn_aceptar.TabIndex = 101
        Me.btn_aceptar.Text = "Ingresar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txt_hasta, Me.txt_desde, Me.lbl_fechaf, Me.lbl_fechai, Me.rbtn_ascenso, Me.rbtn_aspirante})
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 112)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TURNO:"
        '
        'txt_hasta
        '
        Me.txt_hasta.Location = New System.Drawing.Point(264, 72)
        Me.txt_hasta.Name = "txt_hasta"
        Me.txt_hasta.Size = New System.Drawing.Size(80, 21)
        Me.txt_hasta.TabIndex = 102
        Me.txt_hasta.Text = ""
        '
        'txt_desde
        '
        Me.txt_desde.Location = New System.Drawing.Point(80, 72)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(88, 21)
        Me.txt_desde.TabIndex = 101
        Me.txt_desde.Text = ""
        '
        'rbtn_ascenso
        '
        Me.rbtn_ascenso.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_ascenso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_ascenso.Location = New System.Drawing.Point(200, 32)
        Me.rbtn_ascenso.Name = "rbtn_ascenso"
        Me.rbtn_ascenso.Size = New System.Drawing.Size(120, 16)
        Me.rbtn_ascenso.TabIndex = 105
        Me.rbtn_ascenso.Text = "Ascensos"
        Me.rbtn_ascenso.Visible = False
        '
        'rbtn_aspirante
        '
        Me.rbtn_aspirante.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_aspirante.Checked = True
        Me.rbtn_aspirante.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_aspirante.Location = New System.Drawing.Point(40, 32)
        Me.rbtn_aspirante.Name = "rbtn_aspirante"
        Me.rbtn_aspirante.Size = New System.Drawing.Size(112, 16)
        Me.rbtn_aspirante.TabIndex = 104
        Me.rbtn_aspirante.TabStop = True
        Me.rbtn_aspirante.Text = "Aspirantes"
        '
        'rbtn_act
        '
        Me.rbtn_act.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_act.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_act.Location = New System.Drawing.Point(216, 32)
        Me.rbtn_act.Name = "rbtn_act"
        Me.rbtn_act.Size = New System.Drawing.Size(120, 16)
        Me.rbtn_act.TabIndex = 107
        Me.rbtn_act.Text = "Actualizar"
        '
        'rbtn_ing
        '
        Me.rbtn_ing.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_ing.Checked = True
        Me.rbtn_ing.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_ing.Location = New System.Drawing.Point(56, 32)
        Me.rbtn_ing.Name = "rbtn_ing"
        Me.rbtn_ing.Size = New System.Drawing.Size(112, 16)
        Me.rbtn_ing.TabIndex = 106
        Me.rbtn_ing.TabStop = True
        Me.rbtn_ing.Text = "Ingreso"
        '
        'frm_aspirantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(398, 264)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtn_act, Me.rbtn_ing, Me.GroupBox1, Me.btn_Salir, Me.btn_aceptar, Me.dtp_fecha, Me.lbl_fecha, Me.pan_btn, Me.lbl_textform, Me.pic_icono, Me.pic_barra})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_aspirantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Aspirantes/Ascensos"
        Me.pan_btn.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub



#End Region

#Region "Código de Formulario"
    Public frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Public fecha As Date
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseEnter, btn_aceptar.MouseEnter, btn_Salir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseLeave, btn_aceptar.MouseLeave, btn_Salir.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.Click
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub

#End Region

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        If txt_desde.Text = "" Or txt_hasta.Text = "" Then
            MsgBox("Debe ingresar los límites del turno", MsgBoxStyle.Information)
            Exit Sub
        ElseIf CInt(txt_hasta.Text) < CInt(txt_desde.Text) Then
            MsgBox("El valor de Turno final no puede ser menor al inicial.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If rbtn_ing.Checked = True Then
            opr_pedido.GuardarPedidoasp(txt_desde.Text, txt_hasta.Text, dtp_fecha.Value)
        ElseIf rbtn_act.Checked = True Then
            opr_pedido.ActualizarPedidoasp(txt_desde.Text, txt_hasta.Text, dtp_fecha.Value)
        End If
        Me.Close()
    End Sub

    Private Sub frm_aspirantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (frm_refer_main_form.mdiClient1.Height - Me.Height) / 2
        Me.Left = ((frm_refer_main_form.mdiClient1.Width - Me.Width) / 2) + frm_refer_main_form.Pan_Menu.Width
        dtp_fecha.Value = Now

    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub rbtn_ing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_ing.CheckedChanged
        If rbtn_ing.Checked = True Then
            btn_aceptar.Text = "Ingresar"
            rbtn_aspirante.Visible = True
            rbtn_ascenso.Visible = True

        ElseIf rbtn_act.Checked = True Then
            btn_aceptar.Text = "Actualizar"
            rbtn_aspirante.Visible = False
            rbtn_ascenso.Visible = False
        End If

    End Sub
End Class
