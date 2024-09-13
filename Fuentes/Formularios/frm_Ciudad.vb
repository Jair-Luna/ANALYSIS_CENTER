'*************************************************************************
' Nombre:   frm_Ciudad
' Tipo de Archivo: formulario
' Descripcin:  Formulario para la administracion de la tabla CIUDAD 
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2002
' Autores:  RFN
' Ultima Modificaci�n: 07/08/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_Ciudad
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
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_Ciudad As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Ciudad))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grp_Ciudad = New System.Windows.Forms.GroupBox
        Me.cmb_Provincia = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.dgv_Ciudad = New System.Windows.Forms.DataGridView
        Me.grp_Ciudad.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        CType(Me.dgv_Ciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Ciudad
        '
        Me.grp_Ciudad.BackColor = System.Drawing.Color.Transparent
        Me.grp_Ciudad.Controls.Add(Me.cmb_Provincia)
        Me.grp_Ciudad.Controls.Add(Me.Label1)
        Me.grp_Ciudad.Controls.Add(Me.Ctl_txt_nombre)
        Me.grp_Ciudad.Controls.Add(Me.lbl_Nombre)
        Me.grp_Ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Ciudad.ForeColor = System.Drawing.Color.Navy
        Me.grp_Ciudad.Location = New System.Drawing.Point(8, 79)
        Me.grp_Ciudad.Name = "grp_Ciudad"
        Me.grp_Ciudad.Size = New System.Drawing.Size(503, 94)
        Me.grp_Ciudad.TabIndex = 0
        Me.grp_Ciudad.TabStop = False
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Provincia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Provincia.Items.AddRange(New Object() {"NINGUNA", "AFILIADO", "FAMILIAR"})
        Me.cmb_Provincia.Location = New System.Drawing.Point(85, 28)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.Size = New System.Drawing.Size(209, 21)
        Me.cmb_Provincia.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "PROVINCIA"
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(85, 55)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(393, 20)
        Me.Ctl_txt_nombre.TabIndex = 0
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(12, 60)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(54, 16)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(64, 34)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 39)
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
        Me.btn_Salir.Location = New System.Drawing.Point(301, 34)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 39)
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(222, 34)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 39)
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(143, 34)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 39)
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
        Me.pan_barra.Size = New System.Drawing.Size(532, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(5, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(68, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "CIUDAD"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_Ciudad
        '
        Me.dgv_Ciudad.AllowUserToAddRows = False
        Me.dgv_Ciudad.AllowUserToDeleteRows = False
        Me.dgv_Ciudad.BackgroundColor = System.Drawing.Color.Gray
        Me.dgv_Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Ciudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Ciudad.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Ciudad.Location = New System.Drawing.Point(12, 179)
        Me.dgv_Ciudad.Name = "dgv_Ciudad"
        Me.dgv_Ciudad.ReadOnly = True
        Me.dgv_Ciudad.RowHeadersVisible = False
        Me.dgv_Ciudad.Size = New System.Drawing.Size(499, 205)
        Me.dgv_Ciudad.TabIndex = 219
        '
        'frm_Ciudad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(532, 396)
        Me.Controls.Add(Me.dgv_Ciudad)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.grp_Ciudad)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Ciudad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ciudades"
        Me.grp_Ciudad.ResumeLayout(False)
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgv_Ciudad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim opr_ciudad As New Cls_Ciudad()
    Dim opr_res As New Cls_Resultado()
    Dim boo_flag As Boolean   'Si es Nuevo True y es actualizacion False
    Dim int_codigo As Short   'Codigo de la ciudad que se maneja

    Private WithEvents dtt_Ciudad As New DataTable("Registros")
    Dim dtCIU As DataTable = New DataTable()

#Region "Codigo de Formulario"
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

    Private Sub frm_Ciudad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        opr_ciudad.LlenarComboProvincia(cmb_Provincia)

        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Ciudad.Enabled = True

        Dim dtcCIU_columna1 As New DataColumn("prov_id", GetType(System.Single))
        Dim dtcCIU_columna2 As New DataColumn("prov_nombre", GetType(System.String))
        Dim dtcCIU_columna3 As New DataColumn("ciu_id", GetType(System.Single))
        Dim dtcCIU_columna4 As New DataColumn("ciu_nombre", GetType(System.String))
        

        dtt_Ciudad.Columns.Add(dtcCIU_columna1)
        dtt_Ciudad.Columns.Add(dtcCIU_columna2)
        dtt_Ciudad.Columns.Add(dtcCIU_columna3)
        dtt_Ciudad.Columns.Add(dtcCIU_columna4)
        
        actualizaDtsCiudad(1)

        dgv_Ciudad.Columns("prov_id").Visible = False
        dgv_Ciudad.Columns("prov_nombre").HeaderText = "PROVINCIA"
        dgv_Ciudad.Columns("prov_nombre").Width = 180

        dgv_Ciudad.Columns("ciu_id").Visible = False
        dgv_Ciudad.Columns("ciu_nombre").HeaderText = "CIUDAD"
        dgv_Ciudad.Columns("ciu_nombre").Width = 280


        btn_Nuevo.Focus()
        Ctl_txt_nombre.txt_padre.MaxLength = 100
    End Sub


    Private Sub actualizaDtsCiudad(ByVal Prov_id As Integer)
        Dim i As Integer
        dtt_Ciudad.Clear()
        opr_res.LlenarGridCiudad(dgv_Ciudad, Prov_id, dtt_Ciudad)

        
    End Sub


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        btn_Nuevo.Enabled = False
        Ctl_txt_nombre.texto_Asigna("")
        btn_Aceptar.Enabled = True
        grp_Ciudad.Enabled = True
        boo_flag = True
        Ctl_txt_nombre.Focus()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If (Ctl_txt_nombre.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre de la ciudad", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If
        'Verifico que no exista otra ciudad con el mismo nombre
        If (opr_ciudad.BuscarCiudad(Ctl_txt_nombre.texto_Recupera) = True And boo_flag = True) Then
            MsgBox("La ciudad ingresada ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If
        If boo_flag = True Then    '*** Si se trata de una nueva AREA 
            int_codigo = opr_ciudad.LeerMaxCodCiudad + 1
            opr_ciudad.GuardarCiudad(int_codigo, UCase(Ctl_txt_nombre.texto_Recupera))
        Else
            'En caso de actualizar un PERFIL    
            If (MsgBox("Desea actualizar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = vbNo) Then
                Ctl_txt_nombre.texto_Asigna("")
                Exit Sub
            Else
                opr_ciudad.ActualizarCiudad(int_codigo, UCase(Ctl_txt_nombre.texto_Recupera), CInt(dgv_Ciudad.CurrentRow.Cells("prov_id").Value()))
            End If
        End If
        Ctl_txt_nombre.texto_Asigna("")
        'dgrd_Ciudad.SetDataBinding(opr_ciudad.LeerCiudad(CInt(Mid(cmb_Provincia.Text, 101, 110))), "Registros")

        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Ciudad.Enabled = False
        btn_Nuevo.Enabled = True
        btn_Nuevo.Focus()
    End Sub

    Private Sub Eliminar()
        If MsgBox("Desea eliminar la ciudad seleccionada?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.Yes Then
            opr_ciudad.EliminarCiudad(int_codigo)
            MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
            actualizaDtsCiudad(CInt(Mid(cmb_Provincia.Text, 101, 110)))
        End If
        Ctl_txt_nombre.texto_Asigna("")
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Eliminar()
    End Sub


#Region "Manejo del Grid"

    Private Sub Grid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_Ciudad.Enabled = True


        int_codigo = CInt(dgv_Ciudad.CurrentRow.Cells("ciu_id").Value())
        Ctl_txt_nombre.texto_Asigna(dgv_Ciudad.CurrentRow.Cells("nombre_id").Value())

        boo_flag = False
        Grid_Seleccionar_Celda()
    End Sub

    Private Sub Grid_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Operaciones al precionar CURSOR DE ARRIBA O ABAJO, sobre el grid y controla que siempre exista una celda seleccionada
        Grid_Seleccionar_Celda()
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            'Operaciones al precionar DELETE sobre el grid
            Eliminar()
        End If
        Grid_Seleccionar_Celda()
    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Operaciones al precionar DOBLE CLICK sobre el grid
        Grid_Seleccionar_Celda()
    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Operaciones al precionar CLICK sobre el grid
        Grid_Seleccionar_Celda()
    End Sub

    Private celdaanterior As Short
    Private Sub Grid_Seleccionar_Celda()
        On Error Resume Next
        'funcion que no permite que exista seleccion multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        
    End Sub

#End Region

    Private Sub cmb_Provincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        actualizaDtsCiudad(CInt(Mid(cmb_Provincia.Text, 101, 110)))
    End Sub
End Class