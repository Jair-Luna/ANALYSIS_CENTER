Public Class frm_i_notapedido
    Inherits System.Windows.Forms.Form
    Public nped As String

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
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents chkl_npedido As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_notaped As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_clave As System.Windows.Forms.Button
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_notapedido))
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pan_btn = New System.Windows.Forms.Panel
        Me.Pic_close = New System.Windows.Forms.PictureBox
        Me.chkl_npedido = New System.Windows.Forms.CheckedListBox
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_notaped = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_clave = New System.Windows.Forms.Button
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.pan_btn.SuspendLayout()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(22, 7)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(82, 13)
        Me.lbl_textform.TabIndex = 94
        Me.lbl_textform.Text = "NOTA PEDIDO"
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.Add(Me.Pic_close)
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(490, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(10, 12)
        Me.pan_btn.TabIndex = 95
        '
        'Pic_close
        '
        Me.Pic_close.BackColor = System.Drawing.SystemColors.Control
        Me.Pic_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pic_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pic_close.Image = CType(resources.GetObject("Pic_close.Image"), System.Drawing.Image)
        Me.Pic_close.Location = New System.Drawing.Point(-2, 0)
        Me.Pic_close.Name = "Pic_close"
        Me.Pic_close.Size = New System.Drawing.Size(12, 12)
        Me.Pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_close.TabIndex = 1
        Me.Pic_close.TabStop = False
        '
        'chkl_npedido
        '
        Me.chkl_npedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkl_npedido.Enabled = False
        Me.chkl_npedido.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkl_npedido.Location = New System.Drawing.Point(22, 92)
        Me.chkl_npedido.Name = "chkl_npedido"
        Me.chkl_npedido.Size = New System.Drawing.Size(490, 152)
        Me.chkl_npedido.TabIndex = 96
        '
        'btn_Salir
        '
        Me.btn_Salir.BackgroundImage = CType(resources.GetObject("btn_Salir.BackgroundImage"), System.Drawing.Image)
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(262, 256)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 2
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.BackgroundImage = CType(resources.GetObject("btn_Aceptar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(166, 256)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Aceptar.TabIndex = 1
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(22, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Nota de Pedido:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_notaped
        '
        Me.lbl_notaped.BackColor = System.Drawing.Color.Transparent
        Me.lbl_notaped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notaped.ForeColor = System.Drawing.Color.Black
        Me.lbl_notaped.Location = New System.Drawing.Point(132, 36)
        Me.lbl_notaped.Name = "lbl_notaped"
        Me.lbl_notaped.Size = New System.Drawing.Size(116, 13)
        Me.lbl_notaped.TabIndex = 139
        Me.lbl_notaped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(100, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Descripcion."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(300, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Cant."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(368, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Lote"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(428, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Fecha Vcto."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_clave
        '
        Me.btn_clave.BackColor = System.Drawing.SystemColors.Control
        Me.btn_clave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clave.ForeColor = System.Drawing.Color.Black
        Me.btn_clave.Image = CType(resources.GetObject("btn_clave.Image"), System.Drawing.Image)
        Me.btn_clave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clave.Location = New System.Drawing.Point(422, 32)
        Me.btn_clave.Name = "btn_clave"
        Me.btn_clave.Size = New System.Drawing.Size(94, 24)
        Me.btn_clave.TabIndex = 3
        Me.btn_clave.Text = "Autorización"
        Me.btn_clave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clave.UseVisualStyleBackColor = False
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(300, 34)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(104, 21)
        Me.txt_clave.TabIndex = 146
        '
        'frm_i_notapedido
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(530, 296)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.btn_clave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_notaped)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.chkl_npedido)
        Me.Controls.Add(Me.pan_btn)
        Me.Controls.Add(Me.lbl_textform)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_i_notapedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Pedido"
        Me.pan_btn.ResumeLayout(False)
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Código de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseEnter, btn_Salir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseLeave, btn_Salir.MouseLeave
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
    Public frm_refer_main As Frm_Main
    Dim opr_pedido As New Cls_Pedido()
    Public g_opr_usuario As New Cls_Usuario()
    Dim opr_encripta As New Cls_Encripta()

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'Cierra el formulario
        Me.Close()
    End Sub

    Private Sub frm_i_notapedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        'ubica el formulario en el centro del main
        ' Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        ' Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        frm_refer_main.Limpia_menu()
        'llenala lista con los equipos que se ecuentran activos
        'en la base equ_estado:
        '0-->Anulado
        '1-->Factura
        '2-->Nota pedido
        opr_pedido.llenarnotaspedido(chkl_npedido, CInt(Trim(nped)))
        chkl_npedido.Enabled = False
        btn_clave.Text = "Autorización"
        txt_clave.Visible = False
    End Sub


    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Dim i As Integer
        Dim notapedido As String = ""
        Dim docped As String = ""
        Dim flagchk As Short = 0
        For i = 0 To (chkl_npedido.Items.Count - 1)
            If chkl_npedido.GetItemChecked(i) = True Then
                flagchk = 1
            End If
        Next
        If flagchk = 0 Then
            MsgBox("Debe escoger por lo menos un pedido", MsgBoxStyle.Exclamation, "ANALISYS")
            btn_Aceptar.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        For i = 0 To (chkl_npedido.Items.Count - 1)
            If chkl_npedido.GetItemChecked(i) = True Then
                notapedido = notapedido & Trim(Mid(chkl_npedido.Items(i), 98, 3)) & ","
                docped = Trim(Mid(chkl_npedido.Items(i), 101, 20))
            End If
        Next
        Dim ctl As Form
        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        For Each ctl In frm_refer_main.MdiChildren
            'If ctl.Name = Me.Tag Then
            'Select Case Me.Tag
            '    Case "Frm_i_Movimientos"
            Dim ctl2 As Frm_i_Movimientos
            ctl2 = ctl
            ctl2.carga_datos_npedido(notapedido, CInt(Trim(nped)), docped)
            ctl.Activate()
            'End Select
            'End If
        Next
        Me.Close()
    End Sub

    Private Sub btn_clave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clave.Click
        If btn_clave.Text = "Autorización" Then
            btn_clave.Text = "Validar"
            txt_clave.Visible = True
            txt_clave.Focus()
        End If

        Dim str_clave As String
        If txt_clave.Text = "" Then
            MsgBox("Ingrese la Clave", MsgBoxStyle.Information, "ANALISYS")
            txt_clave.Text = ""
            txt_clave.Focus()
        Else
            str_clave = g_opr_usuario.existeclave(Trim(txt_clave.Text))
            If Trim(txt_clave.Text) = opr_encripta.Desencriptar(str_clave) Then
                chkl_npedido.Enabled = True
                txt_clave.Text = ""
            Else
                MsgBox("Clave Incorrecta", MsgBoxStyle.Exclamation, "ANALISYS")
                txt_clave.Text = ""
                txt_clave.Focus()
            End If
        End If


    End Sub
End Class
