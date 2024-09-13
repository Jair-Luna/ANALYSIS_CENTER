'*************************************************************************
' Nombre:   frm_i_Unidad
' Tipo de Archivo: formulario
' Descripción:  formulario que me permite manipular las unidades
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class frm_i_Unidad
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
    Friend WithEvents dgrd_Unidad As System.Windows.Forms.DataGrid
    Friend WithEvents btn_deshacer As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_Unidad))
        Me.dgrd_Unidad = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_deshacer = New System.Windows.Forms.Button
        CType(Me.dgrd_Unidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrd_Unidad
        '
        Me.dgrd_Unidad.AllowSorting = False
        Me.dgrd_Unidad.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Unidad.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Unidad.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Unidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Unidad.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Unidad.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Unidad.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Unidad.CaptionText = "UNIDADES"
        Me.dgrd_Unidad.DataMember = ""
        Me.dgrd_Unidad.FlatMode = True
        Me.dgrd_Unidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Unidad.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Unidad.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Unidad.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Unidad.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Unidad.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Unidad.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Unidad.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Unidad.Location = New System.Drawing.Point(12, 79)
        Me.dgrd_Unidad.Name = "dgrd_Unidad"
        Me.dgrd_Unidad.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Unidad.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Unidad.RowHeaderWidth = 20
        Me.dgrd_Unidad.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Unidad.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Unidad.Size = New System.Drawing.Size(363, 264)
        Me.dgrd_Unidad.TabIndex = 0
        Me.dgrd_Unidad.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Unidad
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
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
        Me.DataGridTextBoxColumn1.MappingName = "i_uni_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 105
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.MappingName = "i_uni_descripcion"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 195
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "i_uni_id2"
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
        Me.btn_Salir.Location = New System.Drawing.Point(295, 30)
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(211, 30)
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
        Me.btn_Guardar.Location = New System.Drawing.Point(127, 30)
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
        Me.btn_deshacer.Location = New System.Drawing.Point(43, 30)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(80, 24)
        Me.btn_deshacer.TabIndex = 1
        Me.btn_deshacer.Text = "Deshacer"
        Me.btn_deshacer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'frm_i_Unidad
        '
        Me.AcceptButton = Me.btn_Guardar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(396, 367)
        Me.Controls.Add(Me.btn_deshacer)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.dgrd_Unidad)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_i_Unidad"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidad"
        CType(Me.dgrd_Unidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim opr_Unidad As New Cls_i_Unidad()
    Dim dts_Unidad As DataSet
    Private boo_mensaje As Boolean = True
    Private boo_guardo As Boolean = True

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


    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.MouseEnter, btn_Salir.MouseEnter, btn_Guardar.MouseEnter, btn_deshacer.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.MouseLeave, btn_Salir.MouseLeave, btn_Guardar.MouseLeave, btn_Guardar.MouseLeave, btn_deshacer.MouseLeave
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

    Private Sub formulario(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'desactivo los botones
        btn_Guardar.Enabled = False
        btn_Eliminar.Enabled = False
        DataGridTableStyle1.PreferredRowHeight = 22
        'mando a llenar le grid con las unidades
        opr_Unidad.LlenarGridUnidad(dts_Unidad, dgrd_Unidad)
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'cierro el formulario
        Me.Close()
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'elimino una unidad
        Dim str_uniid As String = ""
        dgrd_Unidad.Select(dgrd_Unidad.CurrentCell.RowNumber)
        If Not IsDBNull(dgrd_Unidad.Item(dgrd_Unidad.CurrentCell.RowNumber, 2)) Then
            str_uniid = dgrd_Unidad.Item(dgrd_Unidad.CurrentCell.RowNumber, 2)
        Else
            If Trim(dgrd_Unidad.Item(dgrd_Unidad.CurrentCell.RowNumber, 0).ToString) = "" Then
                MsgBox("Debe ingresar los codigos para las unidades", MsgBoxStyle.Information, "ANALISYS")
                Exit Sub
            End If
            str_uniid = dgrd_Unidad.Item(dgrd_Unidad.CurrentCell.RowNumber, 0)
        End If
        If MsgBox("¿Desea eliminar la unidad: " & dgrd_Unidad.Item(dgrd_Unidad.CurrentCell.RowNumber, 1) & "?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            boo_mensaje = False
            boo_guardo = False
            btn_Guardar_Click(sender, e)
            boo_mensaje = True
            If boo_guardo Then
                opr_Unidad.EliminaUnidad(str_uniid)
                'refresco el data grid
                opr_Unidad.LlenarGridUnidad(dts_Unidad, dgrd_Unidad)
            End If
        End If
        btn_Eliminar.Enabled = False
        btn_Guardar.Enabled = False
    End Sub

    Private Sub btn_deshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deshacer.Click
        'refresco el grid
        opr_Unidad.LlenarGridUnidad(dts_Unidad, dgrd_Unidad)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'guardo los datos
        dgrd_Unidad.Update()
        Dim int_i, int_i2 As Integer
        For int_i = 0 To dts_Unidad.Tables("registros").Rows.Count() - 1
            Dim sng_i As Single = 0
            'verifoco que los codigos no se repitan
            For int_i2 = 0 To dts_Unidad.Tables("registros").Rows.Count() - 1
                If IsDBNull(dts_Unidad.Tables("registros").Rows(int_i2).Item(0)) Then
                    MsgBox("Debe ingresar los codigos para la unidad", MsgBoxStyle.Information, "ANALISYS")
                    Exit Sub
                Else
                    If Trim(dts_Unidad.Tables("registros").Rows(int_i2).Item(0).ToString) = "" Then
                        MsgBox("Debe ingresar los codigos para la unidad", MsgBoxStyle.Information, "ANALISYS")
                        Exit Sub
                    Else
                        If dts_Unidad.Tables("registros").Rows(int_i).Item(0) = dts_Unidad.Tables("registros").Rows(int_i2).Item(0) Then
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
        'verifico que la descripcion no se encutnre vacia
        For int_i = 0 To dts_Unidad.Tables("registros").Rows.Count() - 1
            If dts_Unidad.Tables("registros").Rows(int_i).Item(1).ToString = "" Then
                MsgBox("La descripción no puede estar en blanco", MsgBoxStyle.Exclamation, "ANALISYS")
                Exit Sub
            End If
        Next
        dgrd_Unidad.Update()
        boo_guardo = opr_Unidad.GuardarUnidad(dts_Unidad, boo_mensaje)
        opr_Unidad.LlenarGridUnidad(dts_Unidad, dgrd_Unidad)
        boo_mensaje = True
        btn_Eliminar.Enabled = False
        btn_Guardar.Enabled = False
    End Sub

    Private Sub dgrd_Unidad_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_Unidad.CurrentCellChanged
        btn_Eliminar.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

End Class
