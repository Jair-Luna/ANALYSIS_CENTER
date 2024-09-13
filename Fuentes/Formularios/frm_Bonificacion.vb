'*************************************************************************
' Nombre:   frm_Bonificacion
' Tipo de Archivo: formulario
' Descripcin:  formulario que me permite manipular las bonificaciones
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_Bonificacion
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
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_porcentaje As Ctl_txt.ctl_txt_numeros
    Friend WithEvents grp_Bonificacion As System.Windows.Forms.GroupBox
    Friend WithEvents dgrd_Bonificacion As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Bonificacion))
        Me.grp_Bonificacion = New System.Windows.Forms.GroupBox
        Me.Ctl_txt_porcentaje = New Ctl_txt.ctl_txt_numeros
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.dgrd_Bonificacion = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.grp_Bonificacion.SuspendLayout()
        CType(Me.dgrd_Bonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Bonificacion
        '
        Me.grp_Bonificacion.BackColor = System.Drawing.Color.Transparent
        Me.grp_Bonificacion.Controls.Add(Me.Ctl_txt_porcentaje)
        Me.grp_Bonificacion.Controls.Add(Me.Label1)
        Me.grp_Bonificacion.Controls.Add(Me.Ctl_txt_nombre)
        Me.grp_Bonificacion.Controls.Add(Me.lbl_Nombre)
        Me.grp_Bonificacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Bonificacion.ForeColor = System.Drawing.Color.Navy
        Me.grp_Bonificacion.Location = New System.Drawing.Point(10, 81)
        Me.grp_Bonificacion.Name = "grp_Bonificacion"
        Me.grp_Bonificacion.Size = New System.Drawing.Size(376, 94)
        Me.grp_Bonificacion.TabIndex = 0
        Me.grp_Bonificacion.TabStop = False
        '
        'Ctl_txt_porcentaje
        '
        Me.Ctl_txt_porcentaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_porcentaje.Location = New System.Drawing.Point(92, 53)
        Me.Ctl_txt_porcentaje.Name = "Ctl_txt_porcentaje"
        Me.Ctl_txt_porcentaje.Prp_Formato = True
        Me.Ctl_txt_porcentaje.Prp_NumDecimales = CType(2, Short)
        Me.Ctl_txt_porcentaje.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_porcentaje.Prp_ValDefault = "0"
        Me.Ctl_txt_porcentaje.Size = New System.Drawing.Size(130, 20)
        Me.Ctl_txt_porcentaje.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Porcenaje:"
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(92, 25)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(130, 20)
        Me.Ctl_txt_nombre.TabIndex = 0
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(14, 27)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(70, 16)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'dgrd_Bonificacion
        '
        Me.dgrd_Bonificacion.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Bonificacion.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Bonificacion.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Bonificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Bonificacion.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Bonificacion.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Bonificacion.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Bonificacion.CaptionText = "BONIFICACION"
        Me.dgrd_Bonificacion.DataMember = ""
        Me.dgrd_Bonificacion.FlatMode = True
        Me.dgrd_Bonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Bonificacion.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Bonificacion.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Bonificacion.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Bonificacion.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Bonificacion.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Bonificacion.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Bonificacion.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Bonificacion.Location = New System.Drawing.Point(10, 181)
        Me.dgrd_Bonificacion.Name = "dgrd_Bonificacion"
        Me.dgrd_Bonificacion.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Bonificacion.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Bonificacion.ReadOnly = True
        Me.dgrd_Bonificacion.RowHeaderWidth = 20
        Me.dgrd_Bonificacion.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Bonificacion.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Bonificacion.Size = New System.Drawing.Size(376, 179)
        Me.dgrd_Bonificacion.TabIndex = 1
        Me.dgrd_Bonificacion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Bonificacion
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn1.MappingName = "bon_nombre"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 105
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "#,##0.00 ""%"""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Porcentaje"
        Me.DataGridTextBoxColumn2.MappingName = "bon_porcentaje"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "bon_nombre2"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(44, 35)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 40)
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
        Me.btn_Salir.Location = New System.Drawing.Point(296, 35)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 40)
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(212, 35)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 40)
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(128, 35)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 40)
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
        Me.pan_barra.Size = New System.Drawing.Size(398, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(7, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(126, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "BONIFICACION"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Bonificacion
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(398, 372)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.dgrd_Bonificacion)
        Me.Controls.Add(Me.grp_Bonificacion)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Bonificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ciudades"
        Me.grp_Bonificacion.ResumeLayout(False)
        CType(Me.dgrd_Bonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim opr_bonificacion As New Cls_Bonificacion()
    Dim byt_flag As Byte  '0 --> Nuevo registro ;  1 -> Actualizar registro
    Dim str_nombre_antiguo As String

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


    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Eliminar.MouseEnter, btn_Nuevo.MouseEnter, btn_Salir.MouseEnter
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


    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Eliminar.MouseLeave, btn_Nuevo.MouseLeave, btn_Salir.MouseLeave
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

    Private Sub frm_Bonificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'mando a desplegar los datos d las bonificaciones ne un grid
        'desativo los botones
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Bonificacion.Enabled = False
        opr_bonificacion.LlenarGridBonificacion(dgrd_Bonificacion)
        btn_Nuevo.Focus()
        Ctl_txt_nombre.txt_padre.MaxLength = 50
        Ctl_txt_porcentaje.txt_padre.MaxLength = 6
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        'cuando preciono btn Nuevo activo los campos de ingreso de datos
        Ctl_txt_nombre.texto_Asigna("")
        Ctl_txt_porcentaje.texto_Asigna("")
        btn_Aceptar.Enabled = True
        grp_Bonificacion.Enabled = True
        byt_flag = 0
        Ctl_txt_nombre.Focus()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'mado a guardar los datos guardados
        'verifico si los datos no son vacios
        If (Ctl_txt_nombre.texto_Recupera = "" Or Ctl_txt_porcentaje.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre y el porcentaje de la bonificacion", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If
        'verifco si no existe ya esa bonificacion
        If (opr_bonificacion.BuscarBonificacion(Ctl_txt_nombre.texto_Recupera) = True And byt_flag = 0) Then
            MsgBox("La Bonificacion ingresada ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If
        'una vez comprovado todo lo anterior mado a guardar los datos de la bonificacion
        If byt_flag = 0 Then
            'cuando es nuevo registro
            opr_bonificacion.GuardarBonificacion(Trim(Ctl_txt_nombre.texto_Recupera), Trim(Ctl_txt_porcentaje.texto_Recupera))
            Ctl_txt_nombre.texto_Asigna("")
            Ctl_txt_porcentaje.texto_Asigna("")
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            grp_Bonificacion.Enabled = False
            opr_bonificacion.LlenarGridBonificacion(dgrd_Bonificacion)
        Else
            'cuando es actualizaciones
            If MsgBox("Desea actualizar el registro?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                opr_bonificacion.ActualizarBonificacion(Trim(Ctl_txt_nombre.texto_Recupera), Trim(Ctl_txt_porcentaje.texto_Recupera), str_nombre_antiguo)
                Ctl_txt_nombre.texto_Asigna("")
                Ctl_txt_porcentaje.texto_Asigna("")
                btn_Aceptar.Enabled = False
                btn_Eliminar.Enabled = False
                grp_Bonificacion.Enabled = False
                opr_bonificacion.LlenarGridBonificacion(dgrd_Bonificacion)
            Else
            End If
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'elimino una bonificacion
        If MsgBox("Desea eliminar la Bonificacion?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            opr_bonificacion.EliminaBonificacion(str_nombre_antiguo)
            Ctl_txt_nombre.texto_Asigna("")
            Ctl_txt_porcentaje.texto_Asigna("")
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            opr_bonificacion.LlenarGridBonificacion(dgrd_Bonificacion)
        End If
    End Sub

    Private Sub dgrd_Bonificacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Bonificacion.Click
        'cuando doy click en un registro del grid los datos se actualizan automaticamente 
        'en los cuadros de texto de la parte superior
        On Error Resume Next
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_Bonificacion.Enabled = True
        str_nombre_antiguo = dgrd_Bonificacion.Item(dgrd_Bonificacion.CurrentCell.RowNumber, 0)
        Ctl_txt_nombre.texto_Asigna(dgrd_Bonificacion.Item(dgrd_Bonificacion.CurrentCell.RowNumber, 0))
        Ctl_txt_porcentaje.texto_Asigna(dgrd_Bonificacion.Item(dgrd_Bonificacion.CurrentCell.RowNumber, 1))
        byt_flag = 1
        Dim dgCell As DataGridCell
        dgCell.ColumnNumber = 2
        dgCell.RowNumber = dgrd_Bonificacion.CurrentCell.RowNumber
        dgrd_Bonificacion.CurrentCell = dgCell
        dgrd_Bonificacion.Select(dgrd_Bonificacion.CurrentCell.RowNumber)
    End Sub

    Private Sub Ctl_txt_porcentaje_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ctl_txt_porcentaje.Leave
        'verifico que le porcentaje no sea mayor a 0 o negativo
        If Ctl_txt_porcentaje.texto_Recupera < 0 Or Ctl_txt_porcentaje.texto_Recupera > 100 Then
            MsgBox("El porcentaje de Bonificacion no puede ser mayor al 100%", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_porcentaje.Focus()
        End If
    End Sub

    Private Sub dgrd_Bonificacion_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Bonificacion.CurrentCellChanged
        'selecciono toda la fila del registro 
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_Bonificacion.Enabled = True
        str_nombre_antiguo = dgrd_Bonificacion.Item(dgrd_Bonificacion.CurrentCell.RowNumber, 0)
        Ctl_txt_nombre.texto_Asigna(dgrd_Bonificacion.Item(dgrd_Bonificacion.CurrentCell.RowNumber, 0))
        Ctl_txt_porcentaje.texto_Asigna(dgrd_Bonificacion.Item(dgrd_Bonificacion.CurrentCell.RowNumber, 1))
        byt_flag = 1
        Dim dgCell As DataGridCell
        dgCell.ColumnNumber = 2
        dgCell.RowNumber = dgrd_Bonificacion.CurrentCell.RowNumber
        dgrd_Bonificacion.CurrentCell = dgCell
        dgrd_Bonificacion.Select(dgrd_Bonificacion.CurrentCell.RowNumber)
    End Sub
End Class