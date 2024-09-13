'*************************************************************************
' Nombre:   frm_BusqProducto
' Tipo de Archivo: formulario
' Descripción: formulario que me permite la busqueda de producto con diferentes criterios
' Autores:  RFN
' Fecha de Creación: 22/08/2003
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_BusqProducto

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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_seleccionar As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents Dgrd_producto As System.Windows.Forms.DataGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BusqProducto))
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Dgrd_producto = New System.Windows.Forms.DataGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.Menu_seleccionar = New System.Windows.Forms.MenuItem
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_filtro = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Dgrd_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(501, 34)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 24)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btn_cancelar, "Salir de esta ventana")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Dgrd_producto
        '
        Me.Dgrd_producto.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_producto.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_producto.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_producto.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_producto.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_producto.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_producto.CaptionText = "PRODUCTOS"
        Me.Dgrd_producto.ContextMenu = Me.ContextMenu1
        Me.Dgrd_producto.DataMember = ""
        Me.Dgrd_producto.FlatMode = True
        Me.Dgrd_producto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_producto.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_producto.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_producto.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_producto.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_producto.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_producto.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_producto.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_producto.Location = New System.Drawing.Point(15, 66)
        Me.Dgrd_producto.Name = "Dgrd_producto"
        Me.Dgrd_producto.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_producto.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_producto.ParentRowsVisible = False
        Me.Dgrd_producto.PreferredColumnWidth = 100
        Me.Dgrd_producto.ReadOnly = True
        Me.Dgrd_producto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_producto.RowHeaderWidth = 0
        Me.Dgrd_producto.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_producto.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_producto.Size = New System.Drawing.Size(563, 278)
        Me.Dgrd_producto.TabIndex = 1
        Me.Dgrd_producto.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
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
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_producto
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
        Me.txt_filtro.Location = New System.Drawing.Point(260, 36)
        Me.txt_filtro.MaxLength = 50
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(226, 21)
        Me.txt_filtro.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_filtro, "Ingrese el codigo del producto")
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.Items.AddRange(New Object() {"Descripción del Producto", "Código del Producto"})
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
        Me.Label2.Size = New System.Drawing.Size(160, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "BUSCAR PRODUCTO"
        '
        'frm_BusqProducto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(593, 368)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_filtro)
        Me.Controls.Add(Me.Dgrd_producto)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_BusqProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar producto"
        CType(Me.Dgrd_producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'declaracion de variables
    Dim opr_prodcucto As New Cls_i_Producto()
    Dim dtv_producto As New DataView()


    Public frm_refer_main As Frm_Main

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
            Case "Código del Producto"
                campofiltro = "ABREV"
            Case "Descripción del Producto"
                campofiltro = "DESCRIPCION"
        End Select
    End Function

    Private Sub frm_Paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "CODIGO", "CODIGO", 100))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "DESCRIPCION", "DESCRIPCION", 300))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "PERECIBLE", "PERECIBLE", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "UNIDAD", "UNIDAD", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "FRASCOS", "FRASCOS", 50))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "PRESENT", "PRESENT", 70))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "ABREV", "ABREV", 40))


        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        cmb_filtro.SelectedIndex = 0
        Dgrd_producto.DataSource = dtv_producto
        opr_prodcucto.ConsultaProducto(1, dtv_producto)
        opr_prodcucto.ordena_producto(campofiltro, txt_filtro.Text, dtv_producto)
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'cierro le formulario
        Me.Close()
    End Sub

    Private Sub Dgrd_producto_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_producto.CurrentCellChanged
        'selecciono toda la fila 
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 3
        dgc_celda.RowNumber = Dgrd_producto.CurrentCell.RowNumber
        Dgrd_producto.CurrentCell = dgc_celda
        Dgrd_producto.Select(Dgrd_producto.CurrentCell.RowNumber)
    End Sub

    Private Sub txt_filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.TextChanged
        'cuando presiono una tecla mando hacer un filtro del apellido del paciete 
        opr_prodcucto.ordena_producto(campofiltro, txt_filtro.Text, dtv_producto)
    End Sub

    Sub inserta_dato()
        On Error Resume Next
        Dim ctl As Form
        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        For Each ctl In frm_refer_main.MdiChildren
            If ctl.Name = Me.Tag Then
                Dim dato As String = Dgrd_producto.Item(Dgrd_producto.CurrentCell.RowNumber, 0).ToString.PadRight(15) & " " & _
                Mid(Dgrd_producto.Item(Dgrd_producto.CurrentCell.RowNumber, 1), 1, 50).ToString.PadRight(50) & " " & _
                Dgrd_producto.Item(Dgrd_producto.CurrentCell.RowNumber, 2).ToString.PadRight(20) & " " & _
                Dgrd_producto.Item(Dgrd_producto.CurrentCell.RowNumber, 3).ToString.PadRight(50) & " " & _
                Dgrd_producto.Item(Dgrd_producto.CurrentCell.RowNumber, 4).ToString.PadRight(20) & " " & _
                Dgrd_producto.Item(Dgrd_producto.CurrentCell.RowNumber, 5).ToString.PadRight(20) & " " & _
                Dgrd_producto.Item(Dgrd_producto.CurrentCell.RowNumber, 6).ToString.PadRight(20)

                Select Case Me.Tag
                    Case "Frm_i_Movimientos"
                        Dim ctl2 As Frm_i_Movimientos
                        ctl2 = ctl
                        ctl2.carga_datos_producto(dato)
                        ctl2.Activate()
                    Case "frm_Kardex"
                        Dim ctl2 As frm_Kardex
                        ctl2 = ctl
                        ctl2.carga_datos_producto(dato)
                        ctl2.Activate()

                        'g_varProducto = Mid(dato, 1, 65)
                        'g_varUnidad = Trim(Mid(dato, 85, 15))
                End Select

            End If
        Next
        Me.Close()
    End Sub

    Private Sub Dgrd_producto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_seleccionar.Click, Dgrd_producto.DoubleClick
        inserta_dato()
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dgrd_producto.KeyDown
        'Operaciones al presionar ENTER sobre el grid
        If e.KeyCode = Keys.Enter Then inserta_dato()
    End Sub

    Private Sub cmb_filtro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_filtro.SelectedIndexChanged
        txt_filtro.Text = ""
    End Sub
End Class