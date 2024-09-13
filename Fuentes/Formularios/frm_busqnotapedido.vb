Public Class frm_busqnotapedido
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
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Dgrd_notaped As System.Windows.Forms.DataGrid
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_busqnotapedido))
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.pan_btn = New System.Windows.Forms.Panel
        Me.Pic_close = New System.Windows.Forms.PictureBox
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Dgrd_notaped = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.btn_cancelar = New System.Windows.Forms.Button
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_btn.SuspendLayout()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrd_notaped, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Image = CType(resources.GetObject("pic_barra.Image"), System.Drawing.Image)
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(592, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 92
        Me.pic_barra.TabStop = False
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.Add(Me.Pic_close)
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(556, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(10, 12)
        Me.pan_btn.TabIndex = 93
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
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Image = CType(resources.GetObject("lbl_textform.Image"), System.Drawing.Image)
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(18, 6)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(138, 13)
        Me.lbl_textform.TabIndex = 94
        Me.lbl_textform.Text = "  Buscar nota de pedido"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Buscar pedido nº:     NP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dgrd_notaped
        '
        Me.Dgrd_notaped.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_notaped.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_notaped.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_notaped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_notaped.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_notaped.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_notaped.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_notaped.CaptionText = "NOTA DE PEDIDO"
        Me.Dgrd_notaped.DataMember = ""
        Me.Dgrd_notaped.FlatMode = True
        Me.Dgrd_notaped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_notaped.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_notaped.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_notaped.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_notaped.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_notaped.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_notaped.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_notaped.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_notaped.Location = New System.Drawing.Point(15, 72)
        Me.Dgrd_notaped.Name = "Dgrd_notaped"
        Me.Dgrd_notaped.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_notaped.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_notaped.ParentRowsVisible = False
        Me.Dgrd_notaped.PreferredColumnWidth = 100
        Me.Dgrd_notaped.ReadOnly = True
        Me.Dgrd_notaped.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_notaped.RowHeaderWidth = 0
        Me.Dgrd_notaped.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_notaped.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_notaped.Size = New System.Drawing.Size(563, 278)
        Me.Dgrd_notaped.TabIndex = 135
        Me.Dgrd_notaped.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_notaped
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(176, 36)
        Me.txt_filtro.MaxLength = 50
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(226, 21)
        Me.txt_filtro.TabIndex = 134
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(256, 352)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancelar.TabIndex = 136
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'frm_busqnotapedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(592, 381)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Dgrd_notaped)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.pan_btn)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.pic_barra)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_busqnotapedido"
        Me.Text = "frm_busqnotapedido"
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_btn.ResumeLayout(False)
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrd_notaped, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'declaracion de variables
    Dim opr_pedido As New Cls_Pedido()
    Dim dtv_pedido As New DataView()
    Public frm_refer_main As Frm_Main

#Region "Código de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseEnter, btn_cancelar.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseLeave, btn_cancelar.MouseLeave
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

    Private Sub frm_Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "MOVIMIENTO", "i_mov_id", 200))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "NOTA DE PEDIDO", "i_mov_doc", 300))

        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        Dgrd_notaped.DataSource = dtv_pedido
        opr_pedido.llenarnotped(g_division, dtv_pedido)
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro le formulario
        Me.Close()
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        opr_pedido.ordena_notapedido("i_mov_doc", txt_filtro.Text, dtv_pedido)
    End Sub

    Sub inserta_dato()
        On Error Resume Next
        'Dim ctl As Form
        ''cargo en el tag del formulario pedido los datos del pacietne 
        ''cierro este formulario y activo el formulario de pedido
        'For Each ctl In frm_refer_main.MdiChildren
        '    If ctl.Name = Me.Tag Then
        '        Dim dato As String = Dgrd_notaped.Item(Dgrd_notaped.CurrentCell.RowNumber, 0).ToString.PadRight(15) & " " & _
        '        Mid(Dgrd_notaped.Item(Dgrd_notaped.CurrentCell.RowNumber, 1), 1, 50).ToString.PadRight(25)

        '        Dim ctl2 As frm_i_notapedido
        '        'ctl2 = ctl
        '        'ctl2.carga_datos_producto(dato)
        '        ctl2.lbl_notaped.Text = Mid(dato, 15, 25)
        '        ctl2.Show()
        '        'ctl2.Activate()

        Me.Cursor = Cursors.WaitCursor
        Dim FrM_MDIChild As New frm_i_notapedido()
        FrM_MDIChild.frm_refer_main = frm_refer_main
        FrM_MDIChild.Tag = Me.Name
        FrM_MDIChild.lbl_notaped.Text = Dgrd_notaped.Item(Dgrd_notaped.CurrentCell.RowNumber, 0).ToString.PadRight(15)
        FrM_MDIChild.nped = Dgrd_notaped.Item(Dgrd_notaped.CurrentCell.RowNumber, 0).ToString.PadRight(15)
        'FrM_MDIChild.ShowDialog(frm_refer_main)
        FrM_MDIChild.Show()
        Me.Cursor = Cursors.Default
        '    End If
        'Next
        Me.Close()
    End Sub

    Private Sub Dgrd_notaped_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_notaped.DoubleClick
        inserta_dato()
    End Sub

    Private Sub Dgrd_notaped_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_notaped.CurrentCellChanged
        'selecciono toda la fila 
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 2
        dgc_celda.RowNumber = Dgrd_notaped.CurrentCell.RowNumber
        Dgrd_notaped.CurrentCell = dgc_celda
        Dgrd_notaped.Select(Dgrd_notaped.CurrentCell.RowNumber)
    End Sub
End Class

