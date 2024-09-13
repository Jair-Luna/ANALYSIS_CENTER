'************************************
'ESTE FORMUALARIO SOLO CONTEMPLA EL
'INGRESO DE DATOS DE TEST MANUALES
'PENDIENTES Y SOLO PUEDE INGRESAR 
'RESULTADOS EN TEXTO O NUMERICOS
'CB.
'************************************
Public Class frm_Ing_Resul_porTest


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
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents dgrd_ingreso As System.Windows.Forms.DataGrid
    Friend WithEvents lst_test As System.Windows.Forms.ListBox
    Friend WithEvents lbl_rangod As System.Windows.Forms.Label
    Friend WithEvents lbl_rango As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_tipres As System.Windows.Forms.Label
    Friend WithEvents lbl_uni As System.Windows.Forms.Label
    Friend WithEvents lbl_test As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents lbl_testid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_valida As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Ing_Resul_porTest))
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.dgrd_ingreso = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.lst_test = New System.Windows.Forms.ListBox
        Me.lbl_rangod = New System.Windows.Forms.Label
        Me.lbl_rango = New System.Windows.Forms.Label
        Me.lbl_tipres = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_uni = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_test = New System.Windows.Forms.Label
        Me.lbl_testid = New System.Windows.Forms.Label
        Me.btn_validar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtp_fecha_valida = New System.Windows.Forms.DateTimePicker
        Me.pan_barra.SuspendLayout()
        CType(Me.dgrd_ingreso, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.Location = New System.Drawing.Point(591, 111)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(84, 35)
        Me.btn_Salir.TabIndex = 3
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.Location = New System.Drawing.Point(419, 111)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(84, 35)
        Me.btn_Aceptar.TabIndex = 2
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(114, 358)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(76, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(686, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(11, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(214, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "INGRESO DE RESULTADOS "
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgrd_ingreso
        '
        Me.dgrd_ingreso.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_ingreso.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_ingreso.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_ingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_ingreso.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_ingreso.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_ingreso.CaptionText = "INGRESO DE RESULTADOS"
        Me.dgrd_ingreso.DataMember = ""
        Me.dgrd_ingreso.FlatMode = True
        Me.dgrd_ingreso.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_ingreso.ForeColor = System.Drawing.Color.Black
        Me.dgrd_ingreso.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_ingreso.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_ingreso.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_ingreso.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_ingreso.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_ingreso.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_ingreso.Location = New System.Drawing.Point(10, 174)
        Me.dgrd_ingreso.Name = "dgrd_ingreso"
        Me.dgrd_ingreso.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_ingreso.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_ingreso.RowHeaderWidth = 5
        Me.dgrd_ingreso.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_ingreso.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_ingreso.Size = New System.Drawing.Size(664, 356)
        Me.dgrd_ingreso.TabIndex = 1
        Me.dgrd_ingreso.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_ingreso
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White
        '
        'lst_test
        '
        Me.lst_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_test.Location = New System.Drawing.Point(10, 49)
        Me.lst_test.Name = "lst_test"
        Me.lst_test.Size = New System.Drawing.Size(240, 119)
        Me.lst_test.TabIndex = 0
        '
        'lbl_rangod
        '
        Me.lbl_rangod.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rangod.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rangod.ForeColor = System.Drawing.Color.Black
        Me.lbl_rangod.Location = New System.Drawing.Point(465, 78)
        Me.lbl_rangod.Name = "lbl_rangod"
        Me.lbl_rangod.Size = New System.Drawing.Size(209, 49)
        Me.lbl_rangod.TabIndex = 64
        '
        'lbl_rango
        '
        Me.lbl_rango.AutoSize = True
        Me.lbl_rango.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rango.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rango.Location = New System.Drawing.Point(465, 55)
        Me.lbl_rango.Name = "lbl_rango"
        Me.lbl_rango.Size = New System.Drawing.Size(86, 14)
        Me.lbl_rango.TabIndex = 63
        Me.lbl_rango.Text = "Rango Normal:"
        '
        'lbl_tipres
        '
        Me.lbl_tipres.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipres.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipres.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipres.Location = New System.Drawing.Point(352, 55)
        Me.lbl_tipres.Name = "lbl_tipres"
        Me.lbl_tipres.Size = New System.Drawing.Size(90, 14)
        Me.lbl_tipres.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(258, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 14)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Tipo Resultado:"
        '
        'lbl_uni
        '
        Me.lbl_uni.BackColor = System.Drawing.Color.Transparent
        Me.lbl_uni.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uni.ForeColor = System.Drawing.Color.Black
        Me.lbl_uni.Location = New System.Drawing.Point(306, 78)
        Me.lbl_uni.Name = "lbl_uni"
        Me.lbl_uni.Size = New System.Drawing.Size(88, 14)
        Me.lbl_uni.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 14)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Unidad:"
        '
        'lbl_test
        '
        Me.lbl_test.BackColor = System.Drawing.Color.Transparent
        Me.lbl_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test.ForeColor = System.Drawing.Color.Black
        Me.lbl_test.Location = New System.Drawing.Point(290, 34)
        Me.lbl_test.Name = "lbl_test"
        Me.lbl_test.Size = New System.Drawing.Size(292, 14)
        Me.lbl_test.TabIndex = 66
        '
        'lbl_testid
        '
        Me.lbl_testid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_testid.Location = New System.Drawing.Point(588, 35)
        Me.lbl_testid.Name = "lbl_testid"
        Me.lbl_testid.Size = New System.Drawing.Size(78, 14)
        Me.lbl_testid.TabIndex = 93
        Me.lbl_testid.Visible = False
        '
        'btn_validar
        '
        Me.btn_validar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_validar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_validar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_validar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_validar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validar.ForeColor = System.Drawing.Color.Black
        Me.btn_validar.Image = CType(resources.GetObject("btn_validar.Image"), System.Drawing.Image)
        Me.btn_validar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_validar.Location = New System.Drawing.Point(505, 111)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(84, 35)
        Me.btn_validar.TabIndex = 94
        Me.btn_validar.Text = "Validar"
        Me.btn_validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_validar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Test:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "CONVENIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(388, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 13)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Los resultados se validaran con fecha:"
        '
        'dtp_fecha_valida
        '
        Me.dtp_fecha_valida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_valida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_valida.Location = New System.Drawing.Point(582, 150)
        Me.dtp_fecha_valida.Name = "dtp_fecha_valida"
        Me.dtp_fecha_valida.Size = New System.Drawing.Size(93, 21)
        Me.dtp_fecha_valida.TabIndex = 101
        '
        'frm_Ing_Resul_porTest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(686, 542)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_fecha_valida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_validar)
        Me.Controls.Add(Me.lbl_testid)
        Me.Controls.Add(Me.lst_test)
        Me.Controls.Add(Me.dgrd_ingreso)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.lbl_test)
        Me.Controls.Add(Me.lbl_uni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_rango)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_tipres)
        Me.Controls.Add(Me.lbl_rangod)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Ing_Resul_porTest"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de resultados por Test"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgrd_ingreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Cdigo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Public LabOcup As Byte



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

    Private Sub frm_Ing_Resul_porTest_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If IsNothing(frm_refer_main_form) Then
            frm_refer_main_form = Me.ParentForm


        End If
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Salir.MouseEnter, btn_validar.MouseEnter
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


    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Salir.MouseLeave, btn_validar.MouseLeave
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

    Friend WithEvents DGTBC_VALOR As DataGridTextBoxColumn = New DataGridTextBoxColumn()
    Private WithEvents dtt_ingresotest As New DataTable("Registros")
    Dim dtv_ingresotest As New DataView(dtt_ingresotest)
    Dim opr_test As New Cls_Test()

    Sub CargarDatos()
        Dim arr_test As New ArrayList()
        Dim i As Integer
        Dim prioridad As String()
        prioridad = Split(Me.Tag, ",")
        lst_test.Items.Clear()
        dtt_ingresotest.Clear()

        opr_test.ConsultaTestManualesPendientes(arr_test, prioridad(2))
        For i = 0 To arr_test.Count - 1
            lst_test.Items.Add(arr_test(i))
        Next
    End Sub

    Sub CambiaTamanoCelda(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Width = 65
    End Sub

    Sub CambiaTamanoCelda2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Width = 175
    End Sub

    Private Sub Columna_width(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGTBC_VALOR.WidthChanged
        DGTBC_VALOR.Width = 176
    End Sub

    Private Sub frm_Ing_Resul_porTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        DGTBC_VALOR.Format = String.Empty
        DGTBC_VALOR.HeaderText = "Resultado"
        DGTBC_VALOR.MappingName = "res"
        DGTBC_VALOR.NullText = ""
        DGTBC_VALOR.Width = 200
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "# Ped", "pedid", 0))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Turno", "pedturno", 90))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Paciente", "paciente", 180))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Fecha Ing", "fechaing", 65))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Convenio", "pritip", 65))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "lisid", "lisid", 0))
        DataGridTableStyle1.GridColumnStyles.Add(DGTBC_VALOR)
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "abrev", "abrev", 100))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_NoEditable(String.Empty, "Muestra", "tim_id", 0))

        AddHandler DataGridTableStyle1.GridColumnStyles.Item(0).WidthChanged, AddressOf CambiaTamanoCelda
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(1).WidthChanged, AddressOf CambiaTamanoCelda
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(2).WidthChanged, AddressOf CambiaTamanoCelda2
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(3).WidthChanged, AddressOf CambiaTamanoCelda
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(4).WidthChanged, AddressOf CambiaTamanoCelda
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(5).WidthChanged, AddressOf CambiaTamanoCelda
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(5).WidthChanged, AddressOf CambiaTamanoCelda

        dtt_ingresotest.Columns.Add("pedid")
        dtt_ingresotest.Columns.Add("pedturno")
        dtt_ingresotest.Columns.Add("paciente")
        dtt_ingresotest.Columns.Add("fechaing")
        dtt_ingresotest.Columns.Add("pritip")
        dtt_ingresotest.Columns.Add("lisid")
        dtt_ingresotest.Columns.Add("res")
        dtt_ingresotest.Columns.Add("abrev")
        dtt_ingresotest.Columns.Add("tim_id")

        dtv_ingresotest.AllowDelete = False
        dtv_ingresotest.AllowNew = False
        dgrd_ingreso.DataSource = dtv_ingresotest
        Dim prioridad As String()
        prioridad = Split(Me.Tag, ",")
        Label2.Text = Trim(prioridad(2))
        CargarDatos()
    End Sub

    Private Sub lst_test_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_test.DoubleClick
        'se carga datos en el grid
        If MsgBox("Desea cargar el examen seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            dtt_ingresotest.Clear()
            Dim abrev As String = Nothing
            Dim arr_tmp() As String

            arr_tmp = Split(lst_test.Items(lst_test.SelectedIndex), "º")
            abrev = Trim(arr_tmp(8))
            lbl_test.Text = Trim(arr_tmp(0))
            'comparar con la base de datos pero los valores que se mantienen son:
            '1 num�rico, 2 texto, 3 cualitativa, 4 f�rmula, 5 micro, 6 funcional, 7 grafico
            Select Case arr_tmp(7)
                Case 1
                    lbl_tipres.Text = "NUMERICO"
                Case 2
                    lbl_tipres.Text = "TEXTO"
                Case Else
                    lbl_tipres.Text = ""
            End Select
            lbl_uni.Text = arr_tmp(2)
            'tipo de rango
            Select Case arr_tmp(3)
                Case 0  'no tiene rangos
                    lbl_rangod.Text = ""
                Case 1  'tiene rango n�merico
                    lbl_rangod.Text = arr_tmp(4) & " - " & arr_tmp(5)
                Case 2  'tiene rango multiple
                    lbl_rangod.Text = arr_tmp(6)
            End Select
            Dim arr_test As New ArrayList()
            Dim i As Short
            Dim arregloAreas As String()
            g_CadenaFiltro = Me.Tag
            Dim prioridad As String
            Dim fechaIni As String
            Dim fechaFin As String

            If Me.Tag <> "" Then
                arregloAreas = Split(Me.Tag, ",")
                fechaIni = arregloAreas(0).ToString
                fechaFin = arregloAreas(1).ToString
                'secuenciaIni = arregloAreas(3).ToString
                'secuenciaFin = arregloAreas(4).ToString
                prioridad = Trim(arregloAreas(2).ToString)


                '    ConvenioSecuencia = Prioridad & "," & secuenciaIni & "," & secuenciaFin
            End If
            lbl_testid.Text = arr_tmp(1)
            opr_test.ConsultaTestManualesPendientes(arr_test, arr_tmp(1), fechaIni, fechaFin, prioridad)
            For i = 0 To arr_test.Count - 1
                arr_tmp = Split(arr_test(i), "º")
                Dim dtr_fila As DataRow = dtt_ingresotest.NewRow
                dtr_fila(0) = arr_tmp(0)
                dtr_fila(1) = arr_tmp(5)
                dtr_fila(2) = arr_tmp(2)
                dtr_fila(3) = Format(CDate(arr_tmp(1)), "dd/MM/yyyy")
                dtr_fila(4) = arr_tmp(3)
                dtr_fila(5) = arr_tmp(4)
                dtr_fila(7) = abrev
                dtr_fila(8) = arr_tmp(6)
                dtt_ingresotest.Rows.Add(dtr_fila)
            Next
        End If
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub frm_Ing_Resul_porTest_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MsgBox("Desea cerrar el formulario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar el formulario") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

#Region "Manejo Grid Trabajo"

    Private Sub Grid_ColumnChanging(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles dtt_ingresotest.ColumnChanging
        'se controla que el valor ingresado sea num�rico, cuando el tipo de resultado es num�rico
        Select Case e.Column.ToString
            Case "res"
                If lbl_tipres.Text = "NUMERICO" Then
                    If Not IsNumeric(e.ProposedValue) Then
                        e.ProposedValue = ""
                    End If
                End If
        End Select
    End Sub

    Private Sub Grid_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_ingreso.KeyUp
        'Operaciones al precionar CURSOR DE ARRIBA O ABAJO, sobre el grid y controla que siempre exista una celda seleccionada
        Grid_Seleccionar_Celda()
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_ingreso.KeyDown
        Grid_Seleccionar_Celda()
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            'Operaciones al precionar DELETE sobre el grid
            If e.KeyData.ToString = "Delete" Then
            End If
        End If
    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_ingreso.Click
        'Operaciones al precionar CLICK sobre el grid
        Grid_Seleccionar_Celda()
    End Sub

    Private celdaanterior As Short
    Private Sub Grid_Seleccionar_Celda()
        On Error Resume Next
        'funci�n que no permite que exista selecci�n multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        dgrd_ingreso.UnSelect(celdaanterior)
        dgrd_ingreso.Select(dgrd_ingreso.CurrentCell.RowNumber)
        celdaanterior = dgrd_ingreso.CurrentCell.RowNumber
    End Sub

#End Region

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If dtt_ingresotest.Rows.Count > 0 Then
            If MsgBox("Desea guardar los cambios realizados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                opr_test.AlmacenaTestManualesPendientes(dtp_fecha_valida.Value, dtt_ingresotest, CInt(lbl_testid.Text), lbl_rangod.Text)
                CargarDatos()
            End If
        Else
            ''frm_refer_main_form.escribemsj("NO EXISTEN DATOS PARA ALMACENAR")
        End If
    End Sub

    Private Sub btn_validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validar.Click
        If dtt_ingresotest.Rows.Count > 0 Then
            If MsgBox("Desea guardar los cambios realizados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                opr_test.AlmacenaTestManualesPendientes(dtp_fecha_valida.Value, dtt_ingresotest, CInt(lbl_testid.Text), lbl_rangod.Text, 1)
                CargarDatos()
            End If
        Else
            ''frm_refer_main_form.escribemsj("NO EXISTEN DATOS PARA ALMACENAR")
        End If
    End Sub




End Class