Public Class frm_test_orden
    Inherits System.Windows.Forms.Form

#Region "Cdigo de Formulario"
    Private m_HtImages As New Hashtable()
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgrd_testorden2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbt_examen As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_area As System.Windows.Forms.RadioButton
    Friend WithEvents txt_test As System.Windows.Forms.TextBox
    Dim imageToDraw As Image

    
    
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
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents grp_area As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents dgrd_testorden As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim btn_arriba As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_test_orden))
        Dim btn_abajo As System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.grp_area = New System.Windows.Forms.GroupBox
        Me.cmb_area = New System.Windows.Forms.ComboBox
        Me.rbt_examen = New System.Windows.Forms.RadioButton
        Me.rbt_area = New System.Windows.Forms.RadioButton
        Me.dgrd_testorden = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgrd_testorden2 = New System.Windows.Forms.DataGridView
        Me.txt_test = New System.Windows.Forms.TextBox
        btn_arriba = New System.Windows.Forms.Button
        btn_abajo = New System.Windows.Forms.Button
        Me.pan_barra.SuspendLayout()
        Me.grp_area.SuspendLayout()
        CType(Me.dgrd_testorden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_testorden2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_arriba
        '
        btn_arriba.BackColor = System.Drawing.Color.Transparent
        btn_arriba.Cursor = System.Windows.Forms.Cursors.Hand
        btn_arriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btn_arriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_arriba.ForeColor = System.Drawing.Color.Black
        btn_arriba.Image = CType(resources.GetObject("btn_arriba.Image"), System.Drawing.Image)
        btn_arriba.Location = New System.Drawing.Point(625, 263)
        btn_arriba.Name = "btn_arriba"
        btn_arriba.Size = New System.Drawing.Size(39, 33)
        btn_arriba.TabIndex = 103
        btn_arriba.UseVisualStyleBackColor = False
        AddHandler btn_arriba.Click, AddressOf Me.btn_arriba_Click
        '
        'btn_abajo
        '
        btn_abajo.BackColor = System.Drawing.Color.Transparent
        btn_abajo.Cursor = System.Windows.Forms.Cursors.Hand
        btn_abajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btn_abajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_abajo.ForeColor = System.Drawing.Color.Black
        btn_abajo.Image = CType(resources.GetObject("btn_abajo.Image"), System.Drawing.Image)
        btn_abajo.Location = New System.Drawing.Point(625, 302)
        btn_abajo.Name = "btn_abajo"
        btn_abajo.Size = New System.Drawing.Size(39, 31)
        btn_abajo.TabIndex = 104
        btn_abajo.UseVisualStyleBackColor = False
        AddHandler btn_abajo.Click, AddressOf Me.btn_abajo_Click
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
        Me.btn_Salir.Location = New System.Drawing.Point(529, 41)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 41)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(447, 41)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 41)
        Me.btn_Aceptar.TabIndex = 2
        Me.btn_Aceptar.Text = "Guardar"
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
        Me.pan_barra.Size = New System.Drawing.Size(685, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(14, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(194, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "ORDEN DE IMPRESION"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_area
        '
        Me.grp_area.BackColor = System.Drawing.Color.Transparent
        Me.grp_area.Controls.Add(Me.cmb_area)
        Me.grp_area.Controls.Add(Me.rbt_examen)
        Me.grp_area.Controls.Add(Me.rbt_area)
        Me.grp_area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_area.ForeColor = System.Drawing.Color.Navy
        Me.grp_area.Location = New System.Drawing.Point(22, 31)
        Me.grp_area.Name = "grp_area"
        Me.grp_area.Size = New System.Drawing.Size(410, 72)
        Me.grp_area.TabIndex = 98
        Me.grp_area.TabStop = False
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_area.Location = New System.Drawing.Point(74, 19)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(281, 21)
        Me.cmb_area.TabIndex = 0
        '
        'rbt_examen
        '
        Me.rbt_examen.AutoSize = True
        Me.rbt_examen.Enabled = False
        Me.rbt_examen.Location = New System.Drawing.Point(74, 21)
        Me.rbt_examen.Name = "rbt_examen"
        Me.rbt_examen.Size = New System.Drawing.Size(69, 17)
        Me.rbt_examen.TabIndex = 1
        Me.rbt_examen.Text = "EXAMEN"
        Me.rbt_examen.UseVisualStyleBackColor = True
        '
        'rbt_area
        '
        Me.rbt_area.AutoSize = True
        Me.rbt_area.Checked = True
        Me.rbt_area.Location = New System.Drawing.Point(13, 21)
        Me.rbt_area.Name = "rbt_area"
        Me.rbt_area.Size = New System.Drawing.Size(55, 17)
        Me.rbt_area.TabIndex = 0
        Me.rbt_area.TabStop = True
        Me.rbt_area.Text = "AREA"
        Me.rbt_area.UseVisualStyleBackColor = True
        '
        'dgrd_testorden
        '
        Me.dgrd_testorden.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_testorden.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_testorden.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_testorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_testorden.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_testorden.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testorden.CaptionText = "ORDEN DE IMPRESION DEL TEST"
        Me.dgrd_testorden.DataMember = ""
        Me.dgrd_testorden.FlatMode = True
        Me.dgrd_testorden.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_testorden.ForeColor = System.Drawing.Color.Black
        Me.dgrd_testorden.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_testorden.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_testorden.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testorden.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_testorden.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_testorden.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testorden.Location = New System.Drawing.Point(12, 109)
        Me.dgrd_testorden.Name = "dgrd_testorden"
        Me.dgrd_testorden.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_testorden.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_testorden.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_testorden.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_testorden.Size = New System.Drawing.Size(607, 408)
        Me.dgrd_testorden.TabIndex = 99
        Me.dgrd_testorden.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_testorden
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "TEST"
        Me.DataGridTextBoxColumn2.MappingName = "TES_NOMBRE"
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "RESULTADO"
        Me.DataGridTextBoxColumn4.MappingName = "TES_RESDEFECTO"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn3.MappingName = "TES_ORDENIMP"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'dgrd_testorden2
        '
        Me.dgrd_testorden2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrd_testorden2.Location = New System.Drawing.Point(134, 215)
        Me.dgrd_testorden2.Name = "dgrd_testorden2"
        Me.dgrd_testorden2.Size = New System.Drawing.Size(268, 84)
        Me.dgrd_testorden2.TabIndex = 105
        '
        'txt_test
        '
        Me.txt_test.BackColor = System.Drawing.Color.GreenYellow
        Me.txt_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_test.Location = New System.Drawing.Point(96, 77)
        Me.txt_test.Name = "txt_test"
        Me.txt_test.Size = New System.Drawing.Size(281, 21)
        Me.txt_test.TabIndex = 100
        Me.txt_test.Visible = False
        '
        'frm_test_orden
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(685, 529)
        Me.Controls.Add(Me.dgrd_testorden)
        Me.Controls.Add(Me.dgrd_testorden2)
        Me.Controls.Add(btn_abajo)
        Me.Controls.Add(Me.txt_test)
        Me.Controls.Add(btn_arriba)
        Me.Controls.Add(Me.grp_area)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_test_orden"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Impresion del Test"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_area.ResumeLayout(False)
        Me.grp_area.PerformLayout()
        CType(Me.dgrd_testorden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_testorden2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim dtt_test As New DataTable("Registros")
    Dim opr_areas As New Cls_Areas()
    Dim opr_convenio As New Cls_Convenio()
    Dim dtv_test As New DataView(dtt_test)
    Dim sw As Byte = 0
    Public frm_refer_main As Frm_Main

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub frm_test_orden_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm

        'opr_areas.LlenarCmb_Area(cmb_area)
        'sw = 1
        ''cmb_area.SelectedIndex = (cmb_area.Items.Count - 1)

        
    End Sub

    Private Sub cmb_area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_area.SelectedIndexChanged
        If (sw = 1) Then
            dtt_test.Clear()
            opr_areas.Leertestarea(Mid(Trim(cmb_area.Text), 101, 10), dtt_test)
            dtv_test.AllowNew = False
            dgrd_testorden.DataSource = dtv_test
            dgrd_testorden2.DataSource = dtv_test
            Exit Sub
        End If
        If (sw = 0) Then
            dtt_test.Clear()
            opr_areas.LeerExamenParametro(Mid(cmb_area.Text, Len(Trim(cmb_area.Text)) - 6, Len(Trim(cmb_area.Text))), dtt_test)
            dtv_test.AllowNew = False
            dgrd_testorden.DataSource = dtv_test
            dgrd_testorden2.DataSource = dtv_test
            Exit Sub
        End If

    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If cmb_area.Text = "" Then
            MsgBox("No existe ninguna area para revisar", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            If MsgBox("Desea Guardar los cambios realizados? " & Trim(Mid(Trim(cmb_area.Text), 1, 100)) & "?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
                'Guarda el numero para ordenar el test en impresion
                opr_areas.Guardarordentest(dgrd_testorden, (dtv_test.Count - 1), Trim(cmb_area.Text.ToString))
            End If
        End If
        txt_test.Text = ""
        opr_convenio.ordena_test(txt_test.Text, dtv_test)
    End Sub

    Private Sub txt_test_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_test.TextChanged
        opr_convenio.ordena_test(txt_test.Text, dtv_test)
    End Sub


    Private Sub dgrd_testorden_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_testorden.CurrentCellChanged
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private celdaanteriorped As Short

    Private Sub Grid_Seleccionar_Celda_Ped()
        On Error Resume Next
        'funci�n que no permite que exista selecci�n multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        dgrd_testorden.UnSelect(celdaanteriorped)
        dgrd_testorden.Select(dgrd_testorden.CurrentCell.RowNumber)
        celdaanteriorped = dgrd_testorden.CurrentCell.RowNumber
    End Sub

    Private Sub btn_arriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fd As Integer = 1
        Dim LaFila As Integer = dgrd_testorden2.CurrentRow.Index
        Dim LaFilaAnterior As Integer = dgrd_testorden2.CurrentRow.Index - fd

        Dim FilaOrigen As DataGridViewRow = dgrd_testorden2.Rows(LaFila)
        Dim FilaDestino As DataGridViewRow = dgrd_testorden2.Rows(LaFilaAnterior)

        Dim rowDataOrigen As Object() = New Object(FilaOrigen.Cells.Count - 1) {}
        Dim rowDataDestino As Object() = New Object(FilaDestino.Cells.Count - 1) {}

        'Cargo los valores de las respectivas celdas a copiar

        For i As Integer = 0 To rowDataOrigen.Length - 1
            rowDataOrigen(i) = FilaOrigen.Cells(i).Value
            rowDataDestino(i) = FilaDestino.Cells(i).Value
        Next

        'Aqui realizo el cambio de fila

        For i As Integer = 0 To rowDataOrigen.Length - 1
            dgrd_testorden2.Rows(LaFila).Cells(i).Value = rowDataDestino(i)
            dgrd_testorden2.Rows(LaFila - fd).Cells(i).Value = rowDataOrigen(i)
            dgrd_testorden2.CurrentCell = dgrd_testorden2.Item(0, LaFila - fd)
        Next
    End Sub


    Private Sub btn_abajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fd As Integer = 1
        Dim LaFila As Integer = dgrd_testorden2.CurrentRow.Index
        Dim LaFilaProxima As Integer = dgrd_testorden2.CurrentRow.Index + fd

        Dim FilaOrigen As DataGridViewRow = dgrd_testorden2.Rows(LaFila)
        Dim FilaDestino As DataGridViewRow = dgrd_testorden2.Rows(LaFilaProxima)

        Dim rowDataOrigen As Object() = New Object(FilaOrigen.Cells.Count - 1) {}
        Dim rowDataDestino As Object() = New Object(FilaDestino.Cells.Count - 1) {}

        'Cargo los valores de las respectivas celdas a copiar

        For i As Integer = 0 To rowDataOrigen.Length - 1
            rowDataOrigen(i) = FilaOrigen.Cells(i).Value
            rowDataDestino(i) = FilaDestino.Cells(i).Value
        Next

        'Aqui realizo el cambio de fila

        For i As Integer = 0 To rowDataOrigen.Length - 1
            dgrd_testorden2.Rows(LaFila).Cells(i).Value = rowDataDestino(i)
            dgrd_testorden2.Rows(LaFila + fd).Cells(i).Value = rowDataOrigen(i)
            dgrd_testorden2.CurrentCell = dgrd_testorden2.Item(0, LaFila + fd)
        Next
    End Sub

    Private Sub rbt_area_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_area.CheckedChanged
        If rbt_area.Checked = True Then
            opr_areas.LlenarCmb_Area(cmb_area)
            sw = 1
            cmb_area.SelectedIndex = 0
        End If

    End Sub

    Private Sub rbt_examen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_examen.CheckedChanged

        If rbt_examen.Checked = True Then
            opr_areas.LlenarCmb_TestParam(cmb_area, opr_areas.BuscaIdSonPlatilla())
            sw = 0
            cmb_area.SelectedIndex = 0
        End If
    End Sub
End Class
