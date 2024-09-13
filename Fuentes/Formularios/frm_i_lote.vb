'*************************************************************************
' Nombre:   frm_i_lote
' Tipo de Archivo: formulario
' Descripción: formulario que me permite escoger el lote de un producto
' Autores:  RFN
' Fecha de Creación: 10/09/2003
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_i_lote

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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_seleccionar As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents Dgrd_lote As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents btn_cambiar As System.Windows.Forms.Button
    Friend WithEvents rbtn_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_1 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_lote))
        Me.Dgrd_lote = New System.Windows.Forms.DataGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.Menu_seleccionar = New System.Windows.Forms.MenuItem
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.cmb_filtro = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.rbtn_2 = New System.Windows.Forms.RadioButton
        Me.rbtn_1 = New System.Windows.Forms.RadioButton
        Me.btn_cambiar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Dgrd_lote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgrd_lote
        '
        Me.Dgrd_lote.AllowNavigation = False
        Me.Dgrd_lote.AllowSorting = False
        Me.Dgrd_lote.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_lote.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_lote.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_lote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_lote.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_lote.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_lote.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_lote.CaptionText = "LOTES"
        Me.Dgrd_lote.ContextMenu = Me.ContextMenu1
        Me.Dgrd_lote.DataMember = ""
        Me.Dgrd_lote.FlatMode = True
        Me.Dgrd_lote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_lote.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_lote.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_lote.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_lote.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_lote.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_lote.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_lote.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_lote.Location = New System.Drawing.Point(12, 108)
        Me.Dgrd_lote.Name = "Dgrd_lote"
        Me.Dgrd_lote.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_lote.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_lote.ParentRowsVisible = False
        Me.Dgrd_lote.PreferredColumnWidth = 100
        Me.Dgrd_lote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_lote.RowHeaderWidth = 0
        Me.Dgrd_lote.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_lote.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_lote.Size = New System.Drawing.Size(563, 286)
        Me.Dgrd_lote.TabIndex = 1
        Me.Dgrd_lote.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_lote.TabStop = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_seleccionar})
        '
        'Menu_seleccionar
        '
        Me.Menu_seleccionar.Index = 0
        Me.Menu_seleccionar.Text = "Seleccionar"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_lote
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "LOTE"
        Me.DataGridTextBoxColumn1.MappingName = "LOTE"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "dd/MM/yyyy"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "FECHA DE VENCIMIENTO"
        Me.DataGridTextBoxColumn2.MappingName = "FECHA_VENCIMIENTO"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "TOTAL"
        Me.DataGridTextBoxColumn3.MappingName = "sum_cantidad"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "BODEGA"
        Me.DataGridTextBoxColumn4.MappingName = "i_bod_id"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'txt_filtro
        '
        Me.txt_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(260, 36)
        Me.txt_filtro.MaxLength = 50
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(226, 21)
        Me.txt_filtro.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_filtro, "Ingrese el Lote")
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(492, 70)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Salir de esta ventana")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Items.AddRange(New Object() {"Lote"})
        Me.cmb_filtro.Location = New System.Drawing.Point(114, 36)
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(142, 21)
        Me.cmb_filtro.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(20, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Busqueda por:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtn_2
        '
        Me.rbtn_2.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_2.Location = New System.Drawing.Point(113, 73)
        Me.rbtn_2.Name = "rbtn_2"
        Me.rbtn_2.Size = New System.Drawing.Size(53, 18)
        Me.rbtn_2.TabIndex = 138
        Me.rbtn_2.TabStop = True
        Me.rbtn_2.Text = "Lote"
        Me.rbtn_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_2.UseVisualStyleBackColor = False
        '
        'rbtn_1
        '
        Me.rbtn_1.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_1.Checked = True
        Me.rbtn_1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_1.Location = New System.Drawing.Point(41, 73)
        Me.rbtn_1.Name = "rbtn_1"
        Me.rbtn_1.Size = New System.Drawing.Size(66, 18)
        Me.rbtn_1.TabIndex = 139
        Me.rbtn_1.TabStop = True
        Me.rbtn_1.Text = "Fecha (dd/mm/yyyy)"
        Me.rbtn_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_1.UseVisualStyleBackColor = False
        '
        'btn_cambiar
        '
        Me.btn_cambiar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambiar.ForeColor = System.Drawing.Color.Black
        Me.btn_cambiar.Image = CType(resources.GetObject("btn_cambiar.Image"), System.Drawing.Image)
        Me.btn_cambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cambiar.Location = New System.Drawing.Point(406, 70)
        Me.btn_cambiar.Name = "btn_cambiar"
        Me.btn_cambiar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cambiar.TabIndex = 134
        Me.btn_cambiar.Text = "Cambiar"
        Me.btn_cambiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cambiar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 25)
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
        Me.Label2.Size = New System.Drawing.Size(181, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "LOTES DE PRODUCTOS"
        '
        'frm_i_lote
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(593, 417)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbtn_2)
        Me.Controls.Add(Me.rbtn_1)
        Me.Controls.Add(Me.btn_cambiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_filtro)
        Me.Controls.Add(Me.Dgrd_lote)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_i_lote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Lote"
        CType(Me.Dgrd_lote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'declaracion de variables
    Dim opr_lote As New Cls_i_Producto()
    Dim dtv_lote As New DataView()
    Public frm_refer_main As Frm_Main
    Public producto As String

#Region "Código de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub

#End Region

    Function campofiltro() As String
        Select Case cmb_filtro.Text
            Case "Lote"
                campofiltro = "Lote"
        End Select
    End Function

    Private Sub frm_Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        'DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "LOTE", "LOTE", 150, False))
        'DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "FECHA VENCIMIENTO", "FECHA_VENCIMIENTO", 200, False))
        'DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "TOTAL", "sum_cantidad", 90, False))

        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        cmb_filtro.SelectedIndex = 0
        Dgrd_lote.DataSource = dtv_lote
        opr_lote.ConsultaLote(producto, dtv_lote)
        opr_lote.ordena_producto(campofiltro, txt_filtro.Text, dtv_lote)
        dtv_lote.RowFilter = "sum_cantidad > 0"
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro le formulario
        Me.Close()
    End Sub

    Private Sub Dgrd_lote_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_lote.CurrentCellChanged
        'selecciono toda la fila 
        Dim dgc_celda As DataGridCell
        'dgc_celda.ColumnNumber = 2
        dgc_celda.ColumnNumber = Dgrd_lote.CurrentCell.ColumnNumber
        dgc_celda.RowNumber = Dgrd_lote.CurrentCell.RowNumber
        Dgrd_lote.CurrentCell = dgc_celda
        Dgrd_lote.Select(Dgrd_lote.CurrentCell.RowNumber)


    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        'cuando presiono una tecla mando hacer un filtro del apellido del paciete 
        'opr_lote.ordena_producto(campofiltro, txt_filtro.Text, dtv_lote)
        'If txt_filtro.Text = "" Then dtv_lote.RowFilter = "sum_cantidad > 0"
        Dim campo As String = campofiltro()
        If Trim(txt_filtro.Text) <> "" Then
            dtv_lote.RowFilter = campo & " like '" & Trim(txt_filtro.Text) & "*' and sum_cantidad > 0"
        Else
            dtv_lote.RowFilter = "sum_cantidad > 0"
        End If
        dtv_lote.Sort = campo
    End Sub

    Sub inserta_dato()
        On Error Resume Next
        Dim ctl As Form
        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        For Each ctl In frm_refer_main.MdiChildren
            If ctl.Name = Me.Tag Then
                Dim dato As String = Dgrd_lote.Item(Dgrd_lote.CurrentCell.RowNumber, 0).ToString.PadRight(15) & " " & _
                Mid(Dgrd_lote.Item(Dgrd_lote.CurrentCell.RowNumber, 1).ToString, 1, 10).ToString.PadRight(10) & " " & _
                Dgrd_lote.Item(Dgrd_lote.CurrentCell.RowNumber, 2).ToString.PadRight(20)
                Dim bodega As String = Dgrd_lote.Item(Dgrd_lote.CurrentCell.RowNumber, 3).ToString()
                Select Case Me.Tag
                    Case "Frm_i_Movimientos"
                        Dim ctl2 As Frm_i_Movimientos
                        ctl2 = ctl
                        ctl2.carga_datos_bodega(bodega)
                        ctl2.carga_datos_lote(dato)
                        ctl.Activate()
                End Select

            End If
        Next
        Me.Close()
    End Sub

    Private Sub Dgrd_lote_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_seleccionar.Click, Dgrd_lote.DoubleClick
        inserta_dato()
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgrd_lote.KeyDown
        'Operaciones al presionar ENTER sobre el grid
        If e.KeyCode = Keys.Enter Then inserta_dato()
    End Sub

    '*******************
    'temporal sirve para actualizar los lotes si estan incorrectos
    'jva 18 sept. 2003
    Private Sub btn_cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cambiar.Click
        opr_lote.guardarLote(producto, dtv_lote, Dgrd_lote.Item(Dgrd_lote.CurrentCell.RowNumber, 0).ToString, Mid(Dgrd_lote.Item(Dgrd_lote.CurrentCell.RowNumber, 1).ToString, 1, 10).ToString, rbtn_1.Checked)
        If rbtn_1.Checked = True Then
            MsgBox("La fecha de caducidad ha sido cambiada satisfactoriamente.", MsgBoxStyle.Information, "ANALISYS")
        Else
            MsgBox("El número de Lote ha sido cambiado satisfactoriamente.", MsgBoxStyle.Information, "ANALISYS")
        End If

        opr_lote.ConsultaLote(producto, dtv_lote)
    End Sub

    Private Sub rbtn_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_1.CheckedChanged
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn2.ReadOnly = False
    End Sub

    Private Sub rbtn_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_2.CheckedChanged
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn1.ReadOnly = False
    End Sub
End Class