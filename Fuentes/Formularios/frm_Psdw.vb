'*************************************************************************
' Nombre:   frm_Psdw
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite el cambio de contras�a
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_Pswd
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
    Friend WithEvents grp_Ciudad As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_pswd As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_nuevo_pswd As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_confirma_nuevo_pswd As Ctl_txt.ctl_txt_letras
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pswd))
        Me.grp_Ciudad = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Ctl_txt_confirma_nuevo_pswd = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_nuevo_pswd = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_pswd = New Ctl_txt.ctl_txt_letras
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.grp_Ciudad.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Ciudad
        '
        Me.grp_Ciudad.BackColor = System.Drawing.Color.Transparent
        Me.grp_Ciudad.Controls.Add(Me.PictureBox1)
        Me.grp_Ciudad.Controls.Add(Me.Ctl_txt_confirma_nuevo_pswd)
        Me.grp_Ciudad.Controls.Add(Me.Ctl_txt_nuevo_pswd)
        Me.grp_Ciudad.Controls.Add(Me.Ctl_txt_pswd)
        Me.grp_Ciudad.Controls.Add(Me.Label2)
        Me.grp_Ciudad.Controls.Add(Me.Label1)
        Me.grp_Ciudad.Controls.Add(Me.lbl_Nombre)
        Me.grp_Ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Ciudad.ForeColor = System.Drawing.Color.Navy
        Me.grp_Ciudad.Location = New System.Drawing.Point(10, 31)
        Me.grp_Ciudad.Name = "grp_Ciudad"
        Me.grp_Ciudad.Size = New System.Drawing.Size(384, 145)
        Me.grp_Ciudad.TabIndex = 0
        Me.grp_Ciudad.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Ctl_txt_confirma_nuevo_pswd
        '
        Me.Ctl_txt_confirma_nuevo_pswd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_confirma_nuevo_pswd.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_confirma_nuevo_pswd.Location = New System.Drawing.Point(197, 92)
        Me.Ctl_txt_confirma_nuevo_pswd.Name = "Ctl_txt_confirma_nuevo_pswd"
        Me.Ctl_txt_confirma_nuevo_pswd.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_confirma_nuevo_pswd.Prp_CaracterPasswd = "*"
        Me.Ctl_txt_confirma_nuevo_pswd.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_confirma_nuevo_pswd.Size = New System.Drawing.Size(174, 16)
        Me.Ctl_txt_confirma_nuevo_pswd.TabIndex = 2
        '
        'Ctl_txt_nuevo_pswd
        '
        Me.Ctl_txt_nuevo_pswd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nuevo_pswd.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nuevo_pswd.Location = New System.Drawing.Point(197, 68)
        Me.Ctl_txt_nuevo_pswd.Name = "Ctl_txt_nuevo_pswd"
        Me.Ctl_txt_nuevo_pswd.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nuevo_pswd.Prp_CaracterPasswd = "*"
        Me.Ctl_txt_nuevo_pswd.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_nuevo_pswd.Size = New System.Drawing.Size(174, 16)
        Me.Ctl_txt_nuevo_pswd.TabIndex = 1
        '
        'Ctl_txt_pswd
        '
        Me.Ctl_txt_pswd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_pswd.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_pswd.Location = New System.Drawing.Point(197, 44)
        Me.Ctl_txt_pswd.Name = "Ctl_txt_pswd"
        Me.Ctl_txt_pswd.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_pswd.Prp_CaracterPasswd = "*"
        Me.Ctl_txt_pswd.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_pswd.Size = New System.Drawing.Size(174, 16)
        Me.Ctl_txt_pswd.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(67, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña Nueva:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(67, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Confirmar Contraseña Nueva:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(67, 44)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(124, 16)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Contraseña Anterior:"
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
        Me.btn_Salir.Location = New System.Drawing.Point(314, 182)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 36)
        Me.btn_Salir.TabIndex = 2
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(233, 182)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 36)
        Me.btn_Aceptar.TabIndex = 1
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Controls.Add(Me.pic_barra)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(406, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(8, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(157, 16)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "CAMBIAR CONTRASEÑA"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(406, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 91
        Me.pic_barra.TabStop = False
        '
        'frm_Pswd
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(406, 230)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.grp_Ciudad)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Pswd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.grp_Ciudad.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp, pic_barra.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseMove, pic_barra.MouseMove
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

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseDown, pic_barra.MouseDown
        'Funci�n para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub


    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Salir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Salir.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, lbl_textform.Click, pic_barra.Click
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

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'cierra el formulario
        Me.Close()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'verifica quel os datos estes completos
        If Trim(Ctl_txt_nuevo_pswd.texto_Recupera) = "" Or Trim(Ctl_txt_confirma_nuevo_pswd.texto_Recupera) = "" Or Trim(Ctl_txt_pswd.texto_Recupera) = "" Then
            MsgBox("Los tres cuadros de texto tienen que estar llenos", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            'declaracion de variables
            Dim dts_pswd As DataSet
            Dim dtr_fila As DataRow
            Dim sng_bandera As Single
            Dim opr_encripta As New Cls_Encripta()
            Dim str_pswd As String
            'manda encriptar la contrase�a anterior
            'str_pswd = opr_encripta.Encriptar(Trim(Ctl_txt_pswd.texto_Recupera))
            str_pswd = (Trim(Ctl_txt_pswd.texto_Recupera))
            'verifica si la contrase�a ingresada sea igual a la almacenda ne la base
            dts_pswd = g_opr_usuario.VerificarPswd(g_sng_user, str_pswd)
            'sng_badera =1 sinnifica que es correcta la clavey se puede proceder
            'hacer el cambio de contrase�as
            sng_bandera = 0
            For Each dtr_fila In dts_pswd.Tables("Registros").Rows
                If IsDBNull(dtr_fila(0)) Then
                    sng_bandera = 0
                Else
                    sng_bandera = 1
                End If
            Next
            If sng_bandera = 0 Then
                MsgBox("La contase�a anterior esta incorrecta, rev�sela", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                If sng_bandera = 1 Then
                    If Trim(Ctl_txt_nuevo_pswd.texto_Recupera) = Trim(Ctl_txt_confirma_nuevo_pswd.texto_Recupera) Then
                        'mado a encriptar la nueva clave
                        'str_pswd = opr_encripta.Encriptar(Trim(Ctl_txt_nuevo_pswd.texto_Recupera))
                        str_pswd = (Trim(Ctl_txt_nuevo_pswd.texto_Recupera))
                        'guardo la nueva clave
                        g_opr_usuario.CambiarPswd(g_sng_user, str_pswd)
                        Ctl_txt_pswd.texto_Asigna("")
                        Ctl_txt_nuevo_pswd.texto_Asigna("")
                        Ctl_txt_confirma_nuevo_pswd.texto_Asigna("")
                        Me.Close()
                    Else
                        'despliego mensajes
                        MsgBox("La contrase�a nueva no coincide con la confirmaci�n", MsgBoxStyle.Exclamation, "ANALISYS")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frm_Pswd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ctl_txt_pswd.txt_padre.MaxLength = 50
        Ctl_txt_nuevo_pswd.txt_padre.MaxLength = 50
        Ctl_txt_confirma_nuevo_pswd.txt_padre.MaxLength = 50
    End Sub
End Class
