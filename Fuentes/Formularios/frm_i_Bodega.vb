'*************************************************************************
' Nombre:   frm_i_Bodega
' Tipo de Archivo: formulario
' Descripción:  formulario que me permite manipular las bodegas
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************


Public Class frm_i_Bodega
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
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgrd_TipoMovimiento As System.Windows.Forms.DataGrid
    Friend WithEvents btn_deshacer As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_Bodega))
        Me.dgrd_TipoMovimiento = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_deshacer = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.dgrd_TipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrd_TipoMovimiento
        '
        Me.dgrd_TipoMovimiento.AllowSorting = False
        Me.dgrd_TipoMovimiento.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_TipoMovimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_TipoMovimiento.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_TipoMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_TipoMovimiento.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_TipoMovimiento.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_TipoMovimiento.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_TipoMovimiento.CaptionText = "BODEGAS"
        Me.dgrd_TipoMovimiento.DataMember = ""
        Me.dgrd_TipoMovimiento.FlatMode = True
        Me.dgrd_TipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_TipoMovimiento.ForeColor = System.Drawing.Color.Black
        Me.dgrd_TipoMovimiento.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_TipoMovimiento.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_TipoMovimiento.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_TipoMovimiento.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_TipoMovimiento.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_TipoMovimiento.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_TipoMovimiento.Location = New System.Drawing.Point(12, 74)
        Me.dgrd_TipoMovimiento.Name = "dgrd_TipoMovimiento"
        Me.dgrd_TipoMovimiento.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_TipoMovimiento.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_TipoMovimiento.RowHeaderWidth = 20
        Me.dgrd_TipoMovimiento.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_TipoMovimiento.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_TipoMovimiento.Size = New System.Drawing.Size(382, 280)
        Me.dgrd_TipoMovimiento.TabIndex = 0
        Me.dgrd_TipoMovimiento.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_TipoMovimiento
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "i_bod_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridTextBoxColumn2.MappingName = "i_bod_descripcion"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 175
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "LABORATORIO"
        Me.DataGridTextBoxColumn4.MappingName = "lab_nombre"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "i_bod_id2"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(313, 38)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(229, 38)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Eliminar.TabIndex = 3
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_Guardar.Image = CType(resources.GetObject("btn_Guardar.Image"), System.Drawing.Image)
        Me.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.Location = New System.Drawing.Point(145, 38)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'btn_deshacer
        '
        Me.btn_deshacer.BackColor = System.Drawing.SystemColors.Control
        Me.btn_deshacer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deshacer.ForeColor = System.Drawing.Color.Black
        Me.btn_deshacer.Image = CType(resources.GetObject("btn_deshacer.Image"), System.Drawing.Image)
        Me.btn_deshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_deshacer.Location = New System.Drawing.Point(61, 38)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(80, 24)
        Me.btn_deshacer.TabIndex = 1
        Me.btn_deshacer.Text = "Deshacer"
        Me.btn_deshacer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 25)
        Me.Panel1.TabIndex = 171
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(8, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "BODEGAS"
        '
        'frm_i_Bodega
        '
        Me.AcceptButton = Me.btn_Guardar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(406, 375)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_deshacer)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.dgrd_TipoMovimiento)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_i_Bodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bodega"
        CType(Me.dgrd_TipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim opr_Bodega As New Cls_i_Bodega()
    Dim opr_laboratorio As New Cls_Laboratorio()
    Dim dts_Bodega As DataSet
    Private boo_mensaje As Boolean = True
    Private boo_guardo As Boolean = True
    Private WithEvents cmb_Bodega As New ComboBox()

#Region "Código de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deshacer.MouseEnter, btn_Eliminar.MouseEnter, btn_Guardar.MouseEnter, btn_Salir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deshacer.MouseLeave, btn_Eliminar.MouseLeave, btn_Guardar.MouseLeave, btn_Salir.MouseLeave
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

    Private Sub Formulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'desactivo los botones
        btn_Guardar.Enabled = False
        btn_Eliminar.Enabled = False
        DataGridTableStyle1.PreferredRowHeight = 22
        'creo un evento en el columna
        AddHandler DataGridTextBoxColumn4.TextBox.Enter, AddressOf CargarCombo
        'mando a llenar el combo de los laboratorios
        '''opr_laboratorio.LlenarComboLab2(cmb_Bodega)
        'lleno le grid con los datos de las bodegas
        opr_Bodega.LlenarGridBodega(dts_Bodega, dgrd_TipoMovimiento, g_division)
    End Sub

    Private Sub CargarCombo(ByVal Sender As Object, ByVal e As EventArgs)
        'esta funcion se creo, y funciona el momento en que se creo el evento enter en el gridTextBoxColumm
        'on error Resume Next 
        cmb_Bodega.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_Bodega.Cursor = System.Windows.Forms.Cursors.Default
        cmb_Bodega.Width = DataGridTextBoxColumn4.Width
        cmb_Bodega.Text = DataGridTextBoxColumn4.TextBox.Text
        DataGridTextBoxColumn4.TextBox.Controls.Add(cmb_Bodega)
        cmb_Bodega.BringToFront()
    End Sub

    Private Sub cmb_combo_select(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Bodega.SelectedValueChanged, cmb_Bodega.Click, cmb_Bodega.Enter
        dgrd_TipoMovimiento(dgrd_TipoMovimiento.CurrentCell) = cmb_Bodega.Text
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'elimina una bodega
        Dim str_bodid As String = ""
        dgrd_TipoMovimiento.Select(dgrd_TipoMovimiento.CurrentCell.RowNumber)
        If Not IsDBNull(dgrd_TipoMovimiento.Item(dgrd_TipoMovimiento.CurrentCell.RowNumber, 1)) Then
            str_bodid = dgrd_TipoMovimiento.Item(dgrd_TipoMovimiento.CurrentCell.RowNumber, 0)
        Else
            If Trim(dgrd_TipoMovimiento.Item(dgrd_TipoMovimiento.CurrentCell.RowNumber, 0).ToString) = "" Then
                MsgBox("Debe ingresar los codigos para la bodega", MsgBoxStyle.Information, "ANALISYS")
                Exit Sub
            End If
            str_bodid = dgrd_TipoMovimiento.Item(dgrd_TipoMovimiento.CurrentCell.RowNumber, 0)
        End If
        If MsgBox("¿Desea eliminar la bodega: " & dgrd_TipoMovimiento.Item(dgrd_TipoMovimiento.CurrentCell.RowNumber, 1) & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.Yes Then
            boo_mensaje = False
            boo_guardo = False
            btn_Guardar_Click(sender, e)
            boo_mensaje = True
            If boo_guardo Then
                opr_Bodega.EliminaBodega(str_bodid)
                'actualiza el grid de bodegas
                opr_Bodega.LlenarGridBodega(dts_Bodega, dgrd_TipoMovimiento, g_division)
            End If
            btn_Eliminar.Enabled = False
            btn_Guardar.Enabled = False
        End If
    End Sub

    Private Sub btn_deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deshacer.Click
        'mado a refrescar le grid
        opr_Bodega.LlenarGridBodega(dts_Bodega, dgrd_TipoMovimiento, g_division)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'mando a guardar los datos de la bodega  
        dgrd_TipoMovimiento.Update()
        Dim int_i, int_i2 As Integer
        Dim sng_i As Single = 0
        For int_i = 0 To dts_Bodega.Tables("registros").Rows.Count() - 1
            sng_i = 0
            'verifico que los codigos no se repitan
            For int_i2 = 0 To dts_Bodega.Tables("registros").Rows.Count() - 1
                If IsDBNull(dts_Bodega.Tables("registros").Rows(int_i2).Item(0)) Then
                    MsgBox("Debe ingresar los codigos para la bodega", MsgBoxStyle.Information, "ANALISYS")
                    Exit Sub
                Else
                    If Trim(dts_Bodega.Tables("registros").Rows(int_i2).Item(0).ToString) = "" Then
                        MsgBox("Debe ingresar los codigos para la bodega", MsgBoxStyle.Information, "ANALISYS")
                        Exit Sub
                    Else
                        If dts_Bodega.Tables("registros").Rows(int_i).Item(0) = dts_Bodega.Tables("registros").Rows(int_i2).Item(0) Then
                            sng_i += 1
                        End If
                        If sng_i = 2 Then
                            MsgBox("Los codigos no deben repetirse corrijalos por favor", MsgBoxStyle.Exclamation, "ANALISYS")
                            Exit Sub
                        End If
                    End If
                End If
            Next
        Next
        'verifico que la descripcion no este en blanco
        For int_i = 0 To dts_Bodega.Tables("registros").Rows.Count() - 1
            If dts_Bodega.Tables("registros").Rows(int_i).Item(1).ToString = "" Then
                MsgBox("La descripción no puede estar en blanco", MsgBoxStyle.Exclamation, "ANALISYS")
                Exit Sub
            End If
        Next
        ''verifico que todas las bodegas tengan un laboratorio seleccionado
        'For int_i = 0 To dts_Bodega.Tables("registros").Rows.Count() - 1
        '    If dts_Bodega.Tables("registros").Rows(int_i).Item(2).ToString = "" Then
        '        MsgBox("Debe seleccionar un Laboratorio", MsgBoxStyle.Exclamation, "ANALISYS")
        '        Exit Sub
        '    End If
        'Next
        'actualizo el grid
        dgrd_TipoMovimiento.Update()
        boo_guardo = opr_Bodega.GuardarBodega(dts_Bodega, boo_mensaje)
        'refresco el grid
        opr_Bodega.LlenarGridBodega(dts_Bodega, dgrd_TipoMovimiento, g_division)
        boo_mensaje = True
        btn_Eliminar.Enabled = False
        btn_Guardar.Enabled = False
    End Sub

    Private Sub dgrd_TipoMovimiento_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_TipoMovimiento.CurrentCellChanged
        btn_Eliminar.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

End Class
