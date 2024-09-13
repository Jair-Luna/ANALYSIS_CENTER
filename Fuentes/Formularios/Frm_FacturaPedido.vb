Public Class Frm_FacturaPedido
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
    Friend WithEvents btn_facturar As System.Windows.Forms.Button
    Friend WithEvents btn_nofactura As System.Windows.Forms.Button
    Friend WithEvents chkl_pedidos As System.Windows.Forms.CheckedListBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtn_todos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_1mes As System.Windows.Forms.RadioButton
    Friend WithEvents btn_none As System.Windows.Forms.Button
    Friend WithEvents btn_all As System.Windows.Forms.Button
    Friend WithEvents cmb_paciente As System.Windows.Forms.ComboBox
    Friend WithEvents rbtn_1dia As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_FacturaPedido))
        Me.btn_nofactura = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_facturar = New System.Windows.Forms.Button
        Me.chkl_pedidos = New System.Windows.Forms.CheckedListBox
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbtn_todos = New System.Windows.Forms.RadioButton
        Me.rbtn_1mes = New System.Windows.Forms.RadioButton
        Me.rbtn_1dia = New System.Windows.Forms.RadioButton
        Me.btn_none = New System.Windows.Forms.Button
        Me.btn_all = New System.Windows.Forms.Button
        Me.cmb_paciente = New System.Windows.Forms.ComboBox
        Me.pan_barra.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_nofactura
        '
        Me.btn_nofactura.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nofactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nofactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nofactura.ForeColor = System.Drawing.Color.Black
        Me.btn_nofactura.Image = CType(resources.GetObject("btn_nofactura.Image"), System.Drawing.Image)
        Me.btn_nofactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nofactura.Location = New System.Drawing.Point(100, 37)
        Me.btn_nofactura.Name = "btn_nofactura"
        Me.btn_nofactura.Size = New System.Drawing.Size(124, 50)
        Me.btn_nofactura.TabIndex = 1
        Me.btn_nofactura.Text = "No posee Factura"
        Me.btn_nofactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nofactura.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(225, 37)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 50)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_facturar
        '
        Me.btn_facturar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_facturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_facturar.Enabled = False
        Me.btn_facturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturar.ForeColor = System.Drawing.Color.Black
        Me.btn_facturar.Image = CType(resources.GetObject("btn_facturar.Image"), System.Drawing.Image)
        Me.btn_facturar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_facturar.Location = New System.Drawing.Point(19, 37)
        Me.btn_facturar.Name = "btn_facturar"
        Me.btn_facturar.Size = New System.Drawing.Size(80, 50)
        Me.btn_facturar.TabIndex = 2
        Me.btn_facturar.Text = "Facturar"
        Me.btn_facturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturar.UseVisualStyleBackColor = False
        '
        'chkl_pedidos
        '
        Me.chkl_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkl_pedidos.CheckOnClick = True
        Me.chkl_pedidos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkl_pedidos.HorizontalScrollbar = True
        Me.chkl_pedidos.Location = New System.Drawing.Point(12, 102)
        Me.chkl_pedidos.Name = "chkl_pedidos"
        Me.chkl_pedidos.Size = New System.Drawing.Size(697, 223)
        Me.chkl_pedidos.Sorted = True
        Me.chkl_pedidos.TabIndex = 0
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(807, 25)
        Me.pan_barra.TabIndex = 110
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(14, 2)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(166, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "AGRUPAR FACTURAS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.rbtn_todos)
        Me.Panel1.Controls.Add(Me.rbtn_1mes)
        Me.Panel1.Controls.Add(Me.rbtn_1dia)
        Me.Panel1.Location = New System.Drawing.Point(715, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 93)
        Me.Panel1.TabIndex = 111
        '
        'rbtn_todos
        '
        Me.rbtn_todos.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_todos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_todos.Location = New System.Drawing.Point(8, 61)
        Me.rbtn_todos.Name = "rbtn_todos"
        Me.rbtn_todos.Size = New System.Drawing.Size(64, 22)
        Me.rbtn_todos.TabIndex = 102
        Me.rbtn_todos.Text = "Todos"
        Me.rbtn_todos.UseVisualStyleBackColor = False
        '
        'rbtn_1mes
        '
        Me.rbtn_1mes.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_1mes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_1mes.Location = New System.Drawing.Point(8, 33)
        Me.rbtn_1mes.Name = "rbtn_1mes"
        Me.rbtn_1mes.Size = New System.Drawing.Size(64, 22)
        Me.rbtn_1mes.TabIndex = 101
        Me.rbtn_1mes.Text = "1 mes"
        Me.rbtn_1mes.UseVisualStyleBackColor = False
        '
        'rbtn_1dia
        '
        Me.rbtn_1dia.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_1dia.Checked = True
        Me.rbtn_1dia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_1dia.Location = New System.Drawing.Point(8, 5)
        Me.rbtn_1dia.Name = "rbtn_1dia"
        Me.rbtn_1dia.Size = New System.Drawing.Size(56, 22)
        Me.rbtn_1dia.TabIndex = 100
        Me.rbtn_1dia.TabStop = True
        Me.rbtn_1dia.Text = "1 da"
        Me.rbtn_1dia.UseVisualStyleBackColor = False
        '
        'btn_none
        '
        Me.btn_none.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_none.Image = CType(resources.GetObject("btn_none.Image"), System.Drawing.Image)
        Me.btn_none.Location = New System.Drawing.Point(685, 65)
        Me.btn_none.Name = "btn_none"
        Me.btn_none.Size = New System.Drawing.Size(24, 24)
        Me.btn_none.TabIndex = 113
        Me.btn_none.Tag = "Seleccionar ninguno"
        Me.btn_none.UseVisualStyleBackColor = False
        '
        'btn_all
        '
        Me.btn_all.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_all.Image = CType(resources.GetObject("btn_all.Image"), System.Drawing.Image)
        Me.btn_all.Location = New System.Drawing.Point(661, 65)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(24, 24)
        Me.btn_all.TabIndex = 112
        Me.btn_all.Tag = "Seleccionar todo"
        Me.btn_all.UseVisualStyleBackColor = False
        '
        'cmb_paciente
        '
        Me.cmb_paciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_paciente.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_paciente.FormattingEnabled = True
        Me.cmb_paciente.Location = New System.Drawing.Point(434, 66)
        Me.cmb_paciente.Name = "cmb_paciente"
        Me.cmb_paciente.Size = New System.Drawing.Size(221, 23)
        Me.cmb_paciente.TabIndex = 114
        '
        'Frm_FacturaPedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(807, 343)
        Me.Controls.Add(Me.cmb_paciente)
        Me.Controls.Add(Me.btn_none)
        Me.Controls.Add(Me.btn_all)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.chkl_pedidos)
        Me.Controls.Add(Me.btn_facturar)
        Me.Controls.Add(Me.btn_nofactura)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_FacturaPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignaci�n  de Pedidos a Facturas"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private opr_pedido As New Cls_Pedido()
    Private dtt_pedidos As New DataTable()
    Private dtt_pacientes As New DataTable()
    Private str_pedidos() As Long


    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp
        'If e.Button = MouseButtons.Left Then
        '    Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
        '    frm_refer_main_form.limpiaGrp()
        '    Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        'End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseMove
        'ClickMenu_Principal(Me)
        ''Funci�n para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
        'If e.Button = MouseButtons.Left Then
        '    Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
        '    mousePos.Offset(mouse_offset.X, mouse_offset.Y)
        '    dbl_x = mousePos.X
        '    frm_refer_main_form.ubica(Me.Width, Me.Height, mousePos.Y, mousePos.X - frm_refer_main_form.Splitter.Width)
        'End If
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



    Sub Cargar_Datos(ByVal cmb_paciente As ComboBox, Optional ByVal tiempo As Short = 0)
        Dim int_indice As Integer
        Dim str_cadena As String
        chkl_pedidos.Items.Clear()
        dtt_pedidos = opr_pedido.LeerPedidoSinFactura(tiempo)
        dtt_pacientes = opr_pedido.LeerPedidoPaciente(tiempo)



        For int_indice = 0 To dtt_pedidos.Rows.Count - 1
            str_cadena = dtt_pedidos.Rows(int_indice).Item(0).ToString.PadRight(10) & "   " & Mid(dtt_pedidos.Rows(int_indice).Item(2), 1, 20).ToString.PadRight(20) & " " & Mid(dtt_pedidos.Rows(int_indice).Item(3), 1, 15).ToString.PadRight(15) & "    " & Mid(dtt_pedidos.Rows(int_indice).Item(1), 1, 10).ToString.PadRight(10) & "    " & dtt_pedidos.Rows(int_indice).Item(5).ToString
            chkl_pedidos.Items.Add(str_cadena)
        Next

        cmb_paciente.Items.Add("TODOS".PadRight(20) & "".PadRight(20))
        For int_indice = 0 To dtt_pacientes.Rows.Count - 1
            cmb_paciente.Items.Add(Mid(dtt_pacientes.Rows(int_indice).Item(0), 1, 20).ToString.PadRight(20) & " - " & dtt_pacientes.Rows(int_indice).Item(1).ToString.PadRight(20) & dtt_pacientes.Rows(int_indice).Item(1).ToString.PadRight(20))
        Next
        cmb_paciente.SelectedIndex = 0
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Frm_FacturaPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        chkl_pedidos.Font = New Font("Courier New", 10, FontStyle.Regular)
        'Cargar_Datos(cmb_paciente, 2)
        'opr_pedido.LlenarcomboPaciente(cmb_paciente, 2)
    End Sub

    Sub Carga_arreglo()
        Dim int_cont, int_indice As Integer
        For int_cont = 0 To chkl_pedidos.Items.Count - 1
            If chkl_pedidos.GetItemChecked(int_cont) = True Then
                ReDim Preserve str_pedidos(int_indice + 1)
                str_pedidos(int_indice) = Mid(chkl_pedidos.Items.Item(int_cont), 1, 10)
                int_indice = int_indice + 1
            End If
        Next
    End Sub

    Private Sub btn_facturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_facturar.Click
        Dim int_cont, int_indice As Integer
        For int_cont = 0 To chkl_pedidos.Items.Count - 1
            If chkl_pedidos.GetItemChecked(int_cont) = True Then
                int_indice = int_indice + 1
            End If
        Next
        If chkl_pedidos.Items.Count = 0 Or int_indice = 0 Then Exit Sub

        If MsgBox("Desea Agrupar los pedidos seleccionados en una sola factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            If Not frm_refer_main_form.ExisteForm("Frm_Factura") Then
                Dim frm_Mdichild As New Frm_Factura()
                frm_Mdichild.Tag = "3"
                Carga_arreglo()
                frm_Mdichild.str_arr_pedidos = str_pedidos
                frm_refer_main_form.Crea_formulario(frm_Mdichild)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btn_nofactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nofactura.Click
        If chkl_pedidos.Items.Count = 0 Then Exit Sub
        If MsgBox("Los pedidos seleccionados estaran sin asignar factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Carga_arreglo()
            Cargar_Datos(cmb_paciente, 2)
        End If
    End Sub

    Private Sub rbtn_1dia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_1dia.CheckedChanged
        If rbtn_1dia.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            Cargar_Datos(cmb_paciente, 2)
            Me.Cursor = Cursors.Arrow
        End If

    End Sub

    Private Sub rbtn_1mes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_1mes.CheckedChanged
        If rbtn_1mes.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            Cargar_Datos(cmb_paciente, 1)
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub rbtn_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_todos.CheckedChanged
        If rbtn_1dia.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            Cargar_Datos(cmb_paciente, 0)
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub btn_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_all.Click
        Dim i As Short = 0
        For i = 0 To (chkl_pedidos.Items.Count - 1)
            chkl_pedidos.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btn_none_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_none.Click
        Dim i As Short = 0
        For i = 0 To (chkl_pedidos.Items.Count - 1)
            chkl_pedidos.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub chkl_pedidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkl_pedidos.SelectedIndexChanged
        If chkl_pedidos.SelectedIndex >= 0 Then
            btn_facturar.Enabled = True
        Else
            btn_facturar.Enabled = False
        End If
    End Sub

    Private Sub cmb_paciente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_paciente.SelectedIndexChanged
        cambio_vista()
    End Sub

    Sub cambio_vista()
        Dim str_vista, str_eqp, str_area, str_and As String
        Dim pac_id = Trim(Mid(cmb_paciente.Text, 1, 45))

        'dtv_trabajo.RowFilter = str_vista & str_eqp & str_area
        'dtv_trabajo.RowStateFilter = DataViewRowState.CurrentRows

    End Sub

End Class