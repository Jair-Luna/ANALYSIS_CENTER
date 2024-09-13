'*************************************************************************
' Nombre:   frm_Kardex
' Tipo de Archivo: formulario
' Descripción: formulario que me permite ver el kardex de determinado producto
' Autores: 
' Fecha de Creación:

' Ultima Modificación: 22 Agosto 2003 
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System.IO
Public Class frm_Kardex
    Inherits System.Windows.Forms.Form
    Private m_cls_dgimpresion As cls_dgimpresion = Nothing
    Dim opr_negocio As New Cls_Pedido()


#Region "Código de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    'Dim frm_refer_main_form As Frm_Main
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
    End Sub


    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseDown
        'Función para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.MouseEnter, btn_Salir.MouseEnter, btn_calc.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.MouseLeave, btn_Salir.MouseLeave, btn_calc.MouseLeave
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
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents dgrd_kardex As System.Windows.Forms.DataGrid
    Friend WithEvents btn_calc As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgrd_aux As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbl_SaldInic As System.Windows.Forms.Label
    Friend WithEvents lbl_Cant As System.Windows.Forms.Label
    Friend WithEvents lbl_PreUni As System.Windows.Forms.Label
    Friend WithEvents lbl_ValT As System.Windows.Forms.Label
    Friend WithEvents txt_cant As System.Windows.Forms.TextBox
    Friend WithEvents txt_PrecUni As System.Windows.Forms.TextBox
    Friend WithEvents txt_ValTot As System.Windows.Forms.TextBox
    Friend WithEvents lstv_kardex As System.Windows.Forms.ListView
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents cmb_bodega As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_bodega As System.Windows.Forms.Label
    Friend WithEvents lbl_Producto As System.Windows.Forms.Label
    Friend WithEvents lbl_desde As System.Windows.Forms.Label
    Friend WithEvents dtp_fi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ff As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_kardex As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_divisiones As System.Windows.Forms.ComboBox
    Friend WithEvents btn_busq As System.Windows.Forms.Button
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txt_unidad As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Kardex))
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.dgrd_kardex = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgrd_aux = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_calc = New System.Windows.Forms.Button
        Me.lbl_SaldInic = New System.Windows.Forms.Label
        Me.lbl_Cant = New System.Windows.Forms.Label
        Me.lbl_PreUni = New System.Windows.Forms.Label
        Me.lbl_ValT = New System.Windows.Forms.Label
        Me.txt_cant = New System.Windows.Forms.TextBox
        Me.txt_PrecUni = New System.Windows.Forms.TextBox
        Me.txt_ValTot = New System.Windows.Forms.TextBox
        Me.lstv_kardex = New System.Windows.Forms.ListView
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.cmb_bodega = New System.Windows.Forms.ComboBox
        Me.lbl_bodega = New System.Windows.Forms.Label
        Me.lbl_Producto = New System.Windows.Forms.Label
        Me.lbl_desde = New System.Windows.Forms.Label
        Me.dtp_fi = New System.Windows.Forms.DateTimePicker
        Me.dtp_ff = New System.Windows.Forms.DateTimePicker
        Me.grp_kardex = New System.Windows.Forms.GroupBox
        Me.txt_unidad = New System.Windows.Forms.TextBox
        Me.txt_producto = New System.Windows.Forms.TextBox
        Me.btn_busq = New System.Windows.Forms.Button
        Me.cmb_divisiones = New System.Windows.Forms.ComboBox
        CType(Me.dgrd_kardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_aux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.grp_kardex.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btn_Salir.Location = New System.Drawing.Point(680, 31)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(596, 31)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 24)
        Me.btn_imprimir.TabIndex = 3
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'dgrd_kardex
        '
        Me.dgrd_kardex.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_kardex.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_kardex.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_kardex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_kardex.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_kardex.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_kardex.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_kardex.CaptionText = "KARDEX"
        Me.dgrd_kardex.DataMember = ""
        Me.dgrd_kardex.FlatMode = True
        Me.dgrd_kardex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_kardex.ForeColor = System.Drawing.Color.Black
        Me.dgrd_kardex.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_kardex.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_kardex.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_kardex.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_kardex.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_kardex.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_kardex.Location = New System.Drawing.Point(16, 146)
        Me.dgrd_kardex.Name = "dgrd_kardex"
        Me.dgrd_kardex.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_kardex.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_kardex.ReadOnly = True
        Me.dgrd_kardex.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_kardex.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_kardex.Size = New System.Drawing.Size(744, 409)
        Me.dgrd_kardex.TabIndex = 1
        Me.dgrd_kardex.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_kardex
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White
        '
        'dgrd_aux
        '
        Me.dgrd_aux.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_aux.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_aux.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_aux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_aux.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_aux.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_aux.CaptionText = "AUX"
        Me.dgrd_aux.CaptionVisible = False
        Me.dgrd_aux.DataMember = ""
        Me.dgrd_aux.FlatMode = True
        Me.dgrd_aux.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_aux.ForeColor = System.Drawing.Color.Black
        Me.dgrd_aux.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_aux.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_aux.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_aux.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_aux.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_aux.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_aux.Location = New System.Drawing.Point(16, 226)
        Me.dgrd_aux.Name = "dgrd_aux"
        Me.dgrd_aux.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_aux.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_aux.ReadOnly = True
        Me.dgrd_aux.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_aux.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_aux.Size = New System.Drawing.Size(686, 208)
        Me.dgrd_aux.TabIndex = 40
        Me.dgrd_aux.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_aux.Visible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "MOD ID"
        Me.DataGridTextBoxColumn1.MappingName = "MovDet"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "# Mov"
        Me.DataGridTextBoxColumn16.MappingName = "i_mov_id"
        Me.DataGridTextBoxColumn16.Width = 45
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "dd-MMM-yyyy"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn2.MappingName = "Fecha"
        Me.DataGridTextBoxColumn2.Width = 73
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PRD ID"
        Me.DataGridTextBoxColumn3.MappingName = "prdCod"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Producto"
        Me.DataGridTextBoxColumn4.MappingName = "Producto"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "TIPO MOV ID"
        Me.DataGridTextBoxColumn5.MappingName = "I_TIM_ID"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Detalle"
        Me.DataGridTextBoxColumn6.MappingName = "I_TIM_DESCRIPCION"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Documento"
        Me.DataGridTextBoxColumn20.MappingName = "I_MOV_DOC"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 70
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn17.MappingName = "i_mod_descripcion"
        Me.DataGridTextBoxColumn17.Width = 160
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Lote"
        Me.DataGridTextBoxColumn18.MappingName = "I_MOD_LOTE"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 70
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Vencimiento"
        Me.DataGridTextBoxColumn19.MappingName = "I_MOD_FECVEN"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "0.000"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Ent. Cant."
        Me.DataGridTextBoxColumn7.MappingName = "I_CANTIDAD"
        Me.DataGridTextBoxColumn7.Width = 55
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = "0.000"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "I_VAL_UNI"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = "0.000"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "I_VAL_TOTAL"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = "0.000"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Sal. Cant."
        Me.DataGridTextBoxColumn10.MappingName = "E_CANTIDAD"
        Me.DataGridTextBoxColumn10.Width = 55
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = "0.000"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "E_VAL_UNI"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = "0.000"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "E_VAL_TOTAL"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn13.Format = "0.000"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Total"
        Me.DataGridTextBoxColumn13.MappingName = "T_CANTIDAD"
        Me.DataGridTextBoxColumn13.Width = 55
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn14.Format = "0.000"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "T_VAL_UNI"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn15.Format = "0.000"
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.MappingName = "T_VAL_TOTAL"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'btn_calc
        '
        Me.btn_calc.BackColor = System.Drawing.SystemColors.Control
        Me.btn_calc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calc.ForeColor = System.Drawing.Color.Black
        Me.btn_calc.Image = CType(resources.GetObject("btn_calc.Image"), System.Drawing.Image)
        Me.btn_calc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_calc.Location = New System.Drawing.Point(512, 31)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(80, 24)
        Me.btn_calc.TabIndex = 2
        Me.btn_calc.Text = "Generar"
        Me.btn_calc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_calc.UseVisualStyleBackColor = False
        '
        'lbl_SaldInic
        '
        Me.lbl_SaldInic.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SaldInic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaldInic.Location = New System.Drawing.Point(20, 194)
        Me.lbl_SaldInic.Name = "lbl_SaldInic"
        Me.lbl_SaldInic.Size = New System.Drawing.Size(78, 16)
        Me.lbl_SaldInic.TabIndex = 41
        Me.lbl_SaldInic.Text = "Saldo Inicial :"
        Me.lbl_SaldInic.Visible = False
        '
        'lbl_Cant
        '
        Me.lbl_Cant.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cant.Location = New System.Drawing.Point(102, 194)
        Me.lbl_Cant.Name = "lbl_Cant"
        Me.lbl_Cant.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Cant.TabIndex = 42
        Me.lbl_Cant.Text = "Cantidad:"
        Me.lbl_Cant.Visible = False
        '
        'lbl_PreUni
        '
        Me.lbl_PreUni.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PreUni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PreUni.Location = New System.Drawing.Point(250, 194)
        Me.lbl_PreUni.Name = "lbl_PreUni"
        Me.lbl_PreUni.Size = New System.Drawing.Size(64, 16)
        Me.lbl_PreUni.TabIndex = 43
        Me.lbl_PreUni.Text = "Precio Uni:"
        Me.lbl_PreUni.Visible = False
        '
        'lbl_ValT
        '
        Me.lbl_ValT.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ValT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ValT.Location = New System.Drawing.Point(400, 196)
        Me.lbl_ValT.Name = "lbl_ValT"
        Me.lbl_ValT.Size = New System.Drawing.Size(68, 16)
        Me.lbl_ValT.TabIndex = 44
        Me.lbl_ValT.Text = "Valor Total:"
        Me.lbl_ValT.Visible = False
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(162, 192)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.ReadOnly = True
        Me.txt_cant.Size = New System.Drawing.Size(82, 21)
        Me.txt_cant.TabIndex = 45
        Me.txt_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_cant.Visible = False
        '
        'txt_PrecUni
        '
        Me.txt_PrecUni.Location = New System.Drawing.Point(318, 192)
        Me.txt_PrecUni.Name = "txt_PrecUni"
        Me.txt_PrecUni.ReadOnly = True
        Me.txt_PrecUni.Size = New System.Drawing.Size(76, 21)
        Me.txt_PrecUni.TabIndex = 46
        Me.txt_PrecUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_PrecUni.Visible = False
        '
        'txt_ValTot
        '
        Me.txt_ValTot.Location = New System.Drawing.Point(470, 192)
        Me.txt_ValTot.Name = "txt_ValTot"
        Me.txt_ValTot.ReadOnly = True
        Me.txt_ValTot.Size = New System.Drawing.Size(102, 21)
        Me.txt_ValTot.TabIndex = 47
        Me.txt_ValTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ValTot.Visible = False
        '
        'lstv_kardex
        '
        Me.lstv_kardex.BackColor = System.Drawing.Color.White
        Me.lstv_kardex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstv_kardex.GridLines = True
        Me.lstv_kardex.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstv_kardex.Location = New System.Drawing.Point(260, 306)
        Me.lstv_kardex.Name = "lstv_kardex"
        Me.lstv_kardex.Size = New System.Drawing.Size(122, 36)
        Me.lstv_kardex.TabIndex = 50
        Me.lstv_kardex.UseCompatibleStateImageBehavior = False
        Me.lstv_kardex.View = System.Windows.Forms.View.Details
        Me.lstv_kardex.Visible = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(772, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(6, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(51, 13)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "KARDEX"
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "KARDEX"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'cmb_bodega
        '
        Me.cmb_bodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bodega.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bodega.ItemHeight = 13
        Me.cmb_bodega.Location = New System.Drawing.Point(89, 18)
        Me.cmb_bodega.Name = "cmb_bodega"
        Me.cmb_bodega.Size = New System.Drawing.Size(170, 21)
        Me.cmb_bodega.TabIndex = 1
        '
        'lbl_bodega
        '
        Me.lbl_bodega.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bodega.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bodega.ForeColor = System.Drawing.Color.Black
        Me.lbl_bodega.Location = New System.Drawing.Point(12, 20)
        Me.lbl_bodega.Name = "lbl_bodega"
        Me.lbl_bodega.Size = New System.Drawing.Size(52, 16)
        Me.lbl_bodega.TabIndex = 37
        Me.lbl_bodega.Text = "Bodega:"
        '
        'lbl_Producto
        '
        Me.lbl_Producto.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Producto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_Producto.Location = New System.Drawing.Point(11, 51)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(60, 16)
        Me.lbl_Producto.TabIndex = 29
        Me.lbl_Producto.Text = "Producto:"
        '
        'lbl_desde
        '
        Me.lbl_desde.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desde.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desde.ForeColor = System.Drawing.Color.Black
        Me.lbl_desde.Location = New System.Drawing.Point(286, 24)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(46, 16)
        Me.lbl_desde.TabIndex = 34
        Me.lbl_desde.Text = "Desde:"
        '
        'dtp_fi
        '
        Me.dtp_fi.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fi.Location = New System.Drawing.Point(338, 19)
        Me.dtp_fi.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fi.Name = "dtp_fi"
        Me.dtp_fi.Size = New System.Drawing.Size(88, 21)
        Me.dtp_fi.TabIndex = 2
        Me.dtp_fi.Value = New Date(2019, 6, 25, 0, 0, 0, 0)
        '
        'dtp_ff
        '
        Me.dtp_ff.CustomFormat = "dd/MM/yyyy"
        Me.dtp_ff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ff.Location = New System.Drawing.Point(563, -46)
        Me.dtp_ff.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_ff.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_ff.Name = "dtp_ff"
        Me.dtp_ff.Size = New System.Drawing.Size(86, 21)
        Me.dtp_ff.TabIndex = 3
        Me.dtp_ff.Value = New Date(2019, 6, 25, 0, 0, 0, 0)
        '
        'grp_kardex
        '
        Me.grp_kardex.BackColor = System.Drawing.Color.Transparent
        Me.grp_kardex.Controls.Add(Me.txt_unidad)
        Me.grp_kardex.Controls.Add(Me.txt_producto)
        Me.grp_kardex.Controls.Add(Me.btn_busq)
        Me.grp_kardex.Controls.Add(Me.cmb_bodega)
        Me.grp_kardex.Controls.Add(Me.lbl_bodega)
        Me.grp_kardex.Controls.Add(Me.lbl_Producto)
        Me.grp_kardex.Controls.Add(Me.lbl_desde)
        Me.grp_kardex.Controls.Add(Me.dtp_fi)
        Me.grp_kardex.Controls.Add(Me.dtp_ff)
        Me.grp_kardex.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_kardex.ForeColor = System.Drawing.Color.Navy
        Me.grp_kardex.Location = New System.Drawing.Point(16, 58)
        Me.grp_kardex.Name = "grp_kardex"
        Me.grp_kardex.Size = New System.Drawing.Size(744, 82)
        Me.grp_kardex.TabIndex = 0
        Me.grp_kardex.TabStop = False
        Me.grp_kardex.Text = "Datos:"
        '
        'txt_unidad
        '
        Me.txt_unidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unidad.Location = New System.Drawing.Point(469, 47)
        Me.txt_unidad.Name = "txt_unidad"
        Me.txt_unidad.ReadOnly = True
        Me.txt_unidad.Size = New System.Drawing.Size(88, 21)
        Me.txt_unidad.TabIndex = 136
        Me.txt_unidad.TabStop = False
        '
        'txt_producto
        '
        Me.txt_producto.Enabled = False
        Me.txt_producto.Location = New System.Drawing.Point(87, 47)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(366, 21)
        Me.txt_producto.TabIndex = 135
        Me.txt_producto.TabStop = False
        '
        'btn_busq
        '
        Me.btn_busq.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_busq.ForeColor = System.Drawing.Color.Black
        Me.btn_busq.Location = New System.Drawing.Point(563, 47)
        Me.btn_busq.Name = "btn_busq"
        Me.btn_busq.Size = New System.Drawing.Size(24, 20)
        Me.btn_busq.TabIndex = 134
        Me.btn_busq.Text = "..."
        Me.btn_busq.UseVisualStyleBackColor = False
        '
        'cmb_divisiones
        '
        Me.cmb_divisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_divisiones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_divisiones.Location = New System.Drawing.Point(299, 264)
        Me.cmb_divisiones.Name = "cmb_divisiones"
        Me.cmb_divisiones.Size = New System.Drawing.Size(112, 21)
        Me.cmb_divisiones.TabIndex = 133
        '
        'frm_Kardex
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(772, 570)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.dgrd_kardex)
        Me.Controls.Add(Me.cmb_divisiones)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.grp_kardex)
        Me.Controls.Add(Me.dgrd_aux)
        Me.Controls.Add(Me.lstv_kardex)
        Me.Controls.Add(Me.txt_ValTot)
        Me.Controls.Add(Me.txt_PrecUni)
        Me.Controls.Add(Me.txt_cant)
        Me.Controls.Add(Me.lbl_ValT)
        Me.Controls.Add(Me.lbl_PreUni)
        Me.Controls.Add(Me.lbl_Cant)
        Me.Controls.Add(Me.lbl_SaldInic)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Kardex"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kardex"
        CType(Me.dgrd_kardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_aux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_kardex.ResumeLayout(False)
        Me.grp_kardex.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim opr_i_producto As New Cls_i_Producto()
    Dim opr_i_bodega As New Cls_i_Bodega()
    Dim opr_i_mov As New Cls_i_Movimiento()
    Dim dtt_mov As New DataTable()
    Dim dtt_mov1 As New DataTable()
    Dim dts_mov As New DataSet()
    Dim dtr_fila As DataRow
    Dim int_i As Integer
    Dim int_aux As Integer
    Dim frm_refer_main_form As Frm_Main


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub





    Private Sub frm_Kardex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'Verifico si el usuario pertenece a una division especifica.
        If g_division = 0 Then
            opr_i_bodega.LlenarCombodivision(cmb_divisiones)
        Else
            opr_i_bodega.LlenarCombodivision(cmb_divisiones)
            cmb_divisiones.Enabled = False
            cmb_divisiones.SelectedIndex = g_division - 1
            opr_i_bodega.LlenarComboBodega(cmb_bodega, g_division)
        End If
        'opr_i_producto.LlenarCmbProductos(cmb_Producto)
        'opr_i_bodega.LlenarCmbBodega(cmb_bodega)
        Dim MyDate As Date
        Dim y As Integer
        y = Year(Today)
        MyDate = DateSerial(y, 1, 1)    'Retorna una fecha
        dtp_fi.Text = MyDate
        dtp_ff.Text = Today
        btn_imprimir.Enabled = False
        cmb_bodega.SelectedIndex = 0
    End Sub

    Public Sub carga_datos_producto(ByVal dato As String)
        'toma los datos del paciete que son dvueltos entagdel formulario
        'luego d haber seleccioando del otro formulario
        'separo los campos en un arreglo
        Dim str As String = Nothing
        txt_producto.Text = Mid(dato, 1, 65)
        txt_unidad.Text = Trim(Mid(dato, 85, 15))

    End Sub

    Private Sub btn_calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calc.Click
        Me.Cursor = Cursors.WaitCursor
        If (dtp_fi.Value >= dtp_ff.Value) Then
            ''MsgBox("La fecha inicial del período no puede ser igual o mayor a la final. ", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("La fecha inicial del período no puede ser igual o mayor a la final", g_tiempo)
            Exit Sub
        End If
        If txt_producto.Text = "" Or cmb_bodega.Text = "" Then
            ''MsgBox("No existen productos o bodegas ingresados al sistema, verifíquelo por favor", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("No existen productos o bodegas ingresados al sistema, verifíquelo por favor", g_tiempo)
            Exit Sub
        End If
        Dim dbl_precio_pro As Double
        Dim dbl_cant_saldo As Double
        Dim dbl_vTotal_saldo As Double
        Dim fecha_ini As Date

        fecha_ini = Format(Now, "yyyy") & "/01/01"
        dbl_precio_pro = 0
        dbl_cant_saldo = 0
        dbl_vTotal_saldo = 0
        dtt_mov1.Clear()
        '6:      opr_i_mov.leerMovKardex(Trim(Mid(txt_producto.Text, 1, 15)), Trim(cmb_bodega.Text.Substring(100, 15)), fecha_ini, dtp_ff.Value, dtt_mov1)
        '        Dim dtv_mov1 As New DataView(dtt_mov1)
        '        dtv_mov1.AllowNew = False
        '        dgrd_aux.DataSource = dtv_mov1
        '        'Para el grid de la oculto
        '        If dtt_mov1.Rows.Count > 0 Then
        '            For int_i = 0 To (dtt_mov1.Rows.Count - 1)
        '                dts_mov = opr_i_mov.LeerMovDet(dgrd_aux.Item(int_i, 0), dgrd_aux.Item(int_i, 1))
        '                For Each dtr_fila In dts_mov.Tables("Registros").Rows
        '                    If (dtr_fila(2) = "INGRESO") Then
        '                        'Asigno cantidad del ingreso
        '                        dgrd_aux.Item(int_i, 11) = dtr_fila(0)
        '                    Else   'En caso de EGRESO 
        '                        'Asigno cantidad del egreso
        '                        dgrd_aux.Item(int_i, 14) = Math.Abs(dtr_fila(0))
        '                    End If
        '                    'Asigno cantidad de SALDO

        '                    dgrd_aux.Item(int_i, 17) = Format((dbl_cant_saldo + dtr_fila(0)), "0")
        '                    dbl_cant_saldo = dgrd_aux.Item(int_i, 17)

        '                Next
        '            Next
        '        End If
        '        'Asigno los datos del Inventario inicial del Período consultado 
        txt_cant.Text = dbl_cant_saldo.ToString
        txt_PrecUni.Text = dbl_precio_pro.ToString
        txt_ValTot.Text = dbl_vTotal_saldo.ToString
        dgrd_aux.DataSource = Nothing
        dtt_mov.Clear()
        opr_i_mov.leerMovKardex(Trim(Mid(txt_producto.Text, 1, 15)), Trim(cmb_bodega.Text.Substring(100, 15)), CDate(dtp_fi.Text), CDate(dtp_ff.Text), dtt_mov)
        Dim dtv_mov As New DataView(dtt_mov)
        dtv_mov.AllowNew = False
        dgrd_kardex.DataSource = dtv_mov
        For int_i = 0 To (dtt_mov.Rows.Count - 1)
            dts_mov = opr_i_mov.LeerMovDet(dgrd_kardex.Item(int_i, 0), dgrd_kardex.Item(int_i, 1))
            For Each dtr_fila In dts_mov.Tables("Registros").Rows
                If (dtr_fila(2) = "INGRESO") Then
                    'Asigno cantidad del ingreso
                    dgrd_kardex.Item(int_i, 11) = Format(dtr_fila(0), "0")
                Else   'En caso EGRESO
                    'Asigno cantidad del egreso
                    dgrd_kardex.Item(int_i, 14) = Format(Math.Abs(dtr_fila(0)), "0")
                End If
                'Asigno cantidad de SALDO
                dgrd_kardex.Item(int_i, 17) = Format((dbl_cant_saldo + dtr_fila(0)), "0")
                dbl_cant_saldo = dgrd_kardex.Item(int_i, 17)
                dgrd_kardex.CaptionText = "KARDEX:   ".PadRight(170) & "Saldo Anterior = " & txt_cant.Text 'Producto:  " & Trim(cmb_Producto.Text.Substring(0, 99)) & "    Bodega: " & Trim(cmb_bodega.Text.Substring(0, 99)) & "     Desde: " & dtp_fi.Value & "    Hasta: " & dtp_ff.Value
            Next
        Next
        opr_negocio.VisualizaMensaje("Kardex generado", g_tiempo)
        '''MsgBox("Kardex generado!", MsgBoxStyle.Information, "ANALISYS")
        btn_imprimir.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click

        Dim titulo As String = "KARDEX"
        Dim dtv_mov As New DataView(dtt_mov)
        dgrd_kardex.DataSource = dtv_mov
        Try
            m_cls_dgimpresion = New cls_dgimpresion(dgrd_kardex, PrintDocument1, dtv_mov, dtp_fi.Text, txt_producto.Text, cmb_bodega.Text.Substring(0, 15), dtp_ff.Text, cmb_divisiones.Text, titulo)
            PrintPreviewDialog1.ShowDialog()
            Me.Refresh()
        Catch iex As System.Drawing.Printing.InvalidPrinterException
            ''MsgBox("Error En la Impresora", MsgBoxStyle.Exclamation, "ANALISYS")
            opr_negocio.VisualizaMensaje("Error en la Impresora", g_tiempo)
        End Try
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.Text = "KARDEX"
        PrintPreviewDialog1.Icon = CType(Me.Icon, System.Drawing.Icon)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Control de paginas. en el caso que exista mas de una hoja
        e.HasMorePages = m_cls_dgimpresion.DrawDataGrid(e.Graphics)
        If e.HasMorePages Then
            m_cls_dgimpresion.PageNumber += 1
        Else
            m_cls_dgimpresion.PageNumber = 1
            m_cls_dgimpresion.RowCount = 0
        End If
    End Sub


    Private Sub cmb_divisiones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_divisiones.SelectedValueChanged
        opr_i_bodega.LlenarComboBodega(cmb_bodega, 1)
        'opr_i_producto.LlenarCmbProductos(cmb_Producto, CInt(Trim(Mid(cmb_divisiones.SelectedItem, 50))))
    End Sub

    Private Sub btn_busq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_busq.Click
        'llama a la pantalla de productos
        'If pan_devmov.Enabled = False Then
        Dim FrM_MDIChild As New frm_BusqProducto()
        FrM_MDIChild.frm_refer_main = frm_refer_main_form
        FrM_MDIChild.Tag = Me.Name
        'FrM_MDIChild.txt_producto = txt_producto.Text
        FrM_MDIChild.ShowDialog(frm_refer_main_form)
        'End If
    End Sub

    Private Sub txt_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_producto.TextChanged
        'AL ESCOGER EL PRODUCTO, VERIFICO A QUE BODEGA PERTENECE.
        Dim dts_movimiento As New DataSet()
        Dim dtr_operacion As DataRow

        dts_movimiento = opr_i_mov.leerbodega(Trim(Mid(txt_producto.Text, 1, 15)), Trim(Mid(cmb_bodega.Text, 1, 10)))
        dtr_operacion = dts_movimiento.Tables(0).Rows(0)
        'cmb_bodega.Text = cmb_bodega.GetItemText(cmb_bodega.Items.Item(UbicaCombo(Trim(dtr_operacion(0).ToString().PadRight(15)), cmb_bodega)))

        ' cmb_bodega.GetItemText(cmb_bodega.Items.Item(UbicaCombo(dtr_operacion(0).ToString().PadRight(15), cmb_bodega)))
    End Sub
    Function UbicaCombo(ByVal str_clave As String, ByVal cmb_combo As ComboBox) As Short
        UbicaCombo = 0
        Dim int_pos_rownum As Short
        For int_pos_rownum = 0 To cmb_combo.Items.Count - 1
            If cmb_combo.Items.Item(int_pos_rownum).substring(0, 15) = str_clave Then
                UbicaCombo = int_pos_rownum
                Exit For
            End If
        Next
    End Function



End Class