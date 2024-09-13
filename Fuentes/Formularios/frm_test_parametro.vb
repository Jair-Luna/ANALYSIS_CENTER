Public Class frm_test_parametro
    Inherits System.Windows.Forms.Form

#Region "Cdigo de Formulario"
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.MouseEnter, btn_Aceptar.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.MouseLeave, btn_Aceptar.MouseLeave
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
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_area As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_test As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_area As System.Windows.Forms.Label
    Friend WithEvents txt_test As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgrd_testparametro As System.Windows.Forms.DataGrid
    Friend WithEvents btn_AddParam As System.Windows.Forms.Button
    Friend WithEvents btn_DelParam As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_test_parametro))
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.grp_area = New System.Windows.Forms.GroupBox
        Me.cmb_test = New System.Windows.Forms.ComboBox
        Me.lbl_area = New System.Windows.Forms.Label
        Me.txt_test = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgrd_testparametro = New System.Windows.Forms.DataGrid
        Me.btn_AddParam = New System.Windows.Forms.Button
        Me.btn_DelParam = New System.Windows.Forms.Button
        Me.pan_barra.SuspendLayout()
        Me.grp_area.SuspendLayout()
        CType(Me.dgrd_testparametro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(520, 25)
        Me.pan_barra.TabIndex = 93
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(14, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(125, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "PARAMETROS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_Salir.Location = New System.Drawing.Point(417, 277)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 37)
        Me.btn_Salir.TabIndex = 95
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Enabled = False
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(337, 277)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 37)
        Me.btn_Aceptar.TabIndex = 94
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'grp_area
        '
        Me.grp_area.BackColor = System.Drawing.Color.Transparent
        Me.grp_area.Controls.Add(Me.cmb_test)
        Me.grp_area.Controls.Add(Me.lbl_area)
        Me.grp_area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_area.ForeColor = System.Drawing.Color.Navy
        Me.grp_area.Location = New System.Drawing.Point(72, 32)
        Me.grp_area.Name = "grp_area"
        Me.grp_area.Size = New System.Drawing.Size(368, 56)
        Me.grp_area.TabIndex = 99
        Me.grp_area.TabStop = False
        Me.grp_area.Text = "Seleccione el test"
        '
        'cmb_test
        '
        Me.cmb_test.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_test.Location = New System.Drawing.Point(64, 22)
        Me.cmb_test.Name = "cmb_test"
        Me.cmb_test.Size = New System.Drawing.Size(280, 21)
        Me.cmb_test.TabIndex = 0
        '
        'lbl_area
        '
        Me.lbl_area.BackColor = System.Drawing.Color.Transparent
        Me.lbl_area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_area.ForeColor = System.Drawing.Color.Black
        Me.lbl_area.Location = New System.Drawing.Point(16, 24)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(38, 14)
        Me.lbl_area.TabIndex = 8
        Me.lbl_area.Text = "Test:"
        '
        'txt_test
        '
        Me.txt_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_test.Enabled = False
        Me.txt_test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_test.Location = New System.Drawing.Point(200, 240)
        Me.txt_test.Name = "txt_test"
        Me.txt_test.Size = New System.Drawing.Size(216, 21)
        Me.txt_test.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Abreviatura:"
        '
        'dgrd_testparametro
        '
        Me.dgrd_testparametro.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_testparametro.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_testparametro.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_testparametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_testparametro.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_testparametro.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testparametro.CaptionText = "ABREVIATURAS PARAMETROS TEST"
        Me.dgrd_testparametro.DataMember = ""
        Me.dgrd_testparametro.FlatMode = True
        Me.dgrd_testparametro.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_testparametro.ForeColor = System.Drawing.Color.Black
        Me.dgrd_testparametro.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_testparametro.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_testparametro.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testparametro.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_testparametro.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_testparametro.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_testparametro.Location = New System.Drawing.Point(72, 96)
        Me.dgrd_testparametro.Name = "dgrd_testparametro"
        Me.dgrd_testparametro.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_testparametro.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_testparametro.ReadOnly = True
        Me.dgrd_testparametro.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_testparametro.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_testparametro.Size = New System.Drawing.Size(368, 128)
        Me.dgrd_testparametro.TabIndex = 103
        '
        'btn_AddParam
        '
        Me.btn_AddParam.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddParam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddParam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddParam.ForeColor = System.Drawing.Color.Black
        Me.btn_AddParam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AddParam.Location = New System.Drawing.Point(256, 277)
        Me.btn_AddParam.Name = "btn_AddParam"
        Me.btn_AddParam.Size = New System.Drawing.Size(80, 37)
        Me.btn_AddParam.TabIndex = 104
        Me.btn_AddParam.Text = "Añadir"
        Me.btn_AddParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AddParam.UseVisualStyleBackColor = False
        '
        'btn_DelParam
        '
        Me.btn_DelParam.BackColor = System.Drawing.SystemColors.Control
        Me.btn_DelParam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DelParam.Enabled = False
        Me.btn_DelParam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DelParam.ForeColor = System.Drawing.Color.Black
        Me.btn_DelParam.Image = CType(resources.GetObject("btn_DelParam.Image"), System.Drawing.Image)
        Me.btn_DelParam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_DelParam.Location = New System.Drawing.Point(175, 277)
        Me.btn_DelParam.Name = "btn_DelParam"
        Me.btn_DelParam.Size = New System.Drawing.Size(80, 37)
        Me.btn_DelParam.TabIndex = 105
        Me.btn_DelParam.Text = "Eliminar"
        Me.btn_DelParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_DelParam.UseVisualStyleBackColor = False
        '
        'frm_test_parametro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(520, 326)
        Me.Controls.Add(Me.btn_DelParam)
        Me.Controls.Add(Me.btn_AddParam)
        Me.Controls.Add(Me.dgrd_testparametro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_test)
        Me.Controls.Add(Me.grp_area)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.pan_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_test_parametro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_test_parametro"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_area.ResumeLayout(False)
        CType(Me.dgrd_testparametro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim dtt_test As New DataTable("Registros")
    Dim opr_areas As New Cls_Areas()
    Dim opr_convenio As New Cls_Convenio()
    Dim dtv_test As New DataView(dtt_test)
    Public frm_refer_main As Frm_Main

    Private Sub frm_test_parametro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        opr_areas.LlenarCmb_Test(cmb_test)

        If (Me.Tag <> "") Then
            cmb_test.SelectedIndex = (cmb_test.Items.Count - 1)
        End If
    End Sub


    Private Sub cmb_test_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_test.SelectedIndexChanged
        If (cmb_test.Text <> "") Then
            llena_grid()
        End If

    End Sub

    Private Sub llena_grid()
        dtt_test.Clear()
        opr_areas.Leertestparametro(opr_areas.BuscaTestId(cmb_test.SelectedItem), dtt_test)
        dtv_test.AllowNew = False
        dgrd_testparametro.DataSource = dtv_test
    End Sub

    Private Sub btn_AddParam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddParam.Click
        btn_DelParam.Enabled = False
        txt_test.Enabled = True
        txt_test.Text = ""
        txt_test.Focus()
        btn_Aceptar.Enabled = True
        btn_AddParam.Enabled = False
    End Sub

    Private Sub dgrd_testparametro_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_testparametro.CurrentCellChanged
        txt_test.Text = dgrd_testparametro.Item(dgrd_testparametro.CurrentCell.RowNumber, 1).ToString
        txt_test.Tag = dgrd_testparametro.Item(dgrd_testparametro.CurrentCell.RowNumber, 0).ToString
        btn_AddParam.Enabled = True
        btn_DelParam.Enabled = True

    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If (txt_test.Text <> "") Then
            Dim cod_test As String = opr_areas.BuscaTestId(cmb_test.SelectedItem)
            opr_areas.GuardarTestParametro(txt_test.Text, cod_test)
            btn_AddParam.Enabled = True
            btn_DelParam.Enabled = False
            btn_Aceptar.Enabled = False
            txt_test.Enabled = False
            llena_grid()
        Else
            MessageBox.Show("El campo abreviatura no debe ser nulo.", "ANALISYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btn_DelParam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelParam.Click
        If (txt_test.Text <> "") Then
            opr_areas.EliminaTestParametro(txt_test.Text, dgrd_testparametro.Item(dgrd_testparametro.CurrentCell.RowNumber, 2).ToString)
            btn_AddParam.Enabled = True
            btn_DelParam.Enabled = False
            btn_Aceptar.Enabled = False
            txt_test.Enabled = False
            llena_grid()
        Else
            MessageBox.Show("El campo abreviatura no debe ser nulo.", "ANALISYS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class
