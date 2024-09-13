Public Class frm_impcodigobarras
    Inherits System.Windows.Forms.Form
    Dim str_areas As String = ""
    Friend WithEvents cmb_ped_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private opr_cod As New Cls_Pedido()

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
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fec As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_desde As System.Windows.Forms.TextBox
    Friend WithEvents txt_hasta As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_impcodigobarras))
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_fec = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmb_area = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_desde = New System.Windows.Forms.TextBox
        Me.txt_hasta = New System.Windows.Forms.TextBox
        Me.cmb_ped_tipo = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(164, 213)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(88, 39)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Imprimir"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(258, 213)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(88, 39)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(142, 109)
        Me.dtp_fecha.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(94, 21)
        Me.dtp_fecha.TabIndex = 5
        '
        'lbl_fec
        '
        Me.lbl_fec.AutoSize = True
        Me.lbl_fec.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec.ForeColor = System.Drawing.Color.Black
        Me.lbl_fec.Location = New System.Drawing.Point(62, 112)
        Me.lbl_fec.Name = "lbl_fec"
        Me.lbl_fec.Size = New System.Drawing.Size(42, 13)
        Me.lbl_fec.TabIndex = 107
        Me.lbl_fec.Text = "FECHA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "SECCION"
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.Location = New System.Drawing.Point(141, 164)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(152, 21)
        Me.cmb_area.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_desde)
        Me.GroupBox1.Controls.Add(Me.txt_hasta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SECUENCIAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Desde:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Hasta:"
        '
        'txt_desde
        '
        Me.txt_desde.Location = New System.Drawing.Point(94, 34)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(52, 20)
        Me.txt_desde.TabIndex = 1
        '
        'txt_hasta
        '
        Me.txt_hasta.Location = New System.Drawing.Point(238, 34)
        Me.txt_hasta.Name = "txt_hasta"
        Me.txt_hasta.Size = New System.Drawing.Size(52, 20)
        Me.txt_hasta.TabIndex = 2
        '
        'cmb_ped_tipo
        '
        Me.cmb_ped_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ped_tipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ped_tipo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cmb_ped_tipo.Location = New System.Drawing.Point(141, 137)
        Me.cmb_ped_tipo.Name = "cmb_ped_tipo"
        Me.cmb_ped_tipo.Size = New System.Drawing.Size(151, 21)
        Me.cmb_ped_tipo.TabIndex = 134
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(61, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "PRIORIDAD"
        '
        'frm_impcodigobarras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(368, 273)
        Me.Controls.Add(Me.cmb_ped_tipo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_fec)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_impcodigobarras"
        Me.ShowInTaskbar = False
        Me.Text = "Imprimir codigos de barras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Cdigo de Formulario"
    Public frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Public fecha As Date
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Salir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Salir.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub

#End Region


    Private Sub frm_impcodigobarras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        Me.Top = (frm_refer_main_form.mdiClient1.Height - Me.Height) / 2
        Me.Left = ((frm_refer_main_form.mdiClient1.Width - Me.Width) / 2) + frm_refer_main_form.Pan_Menu.Width

        Dim opr_user As New Cls_Usuario()
        Dim opr_pedido As New Cls_Pedido()
        Dim int_i As Short
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()

        cmb_area.Items.Add("<Disponibles>")
        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)
        For int_i = 0 To arr_datos.Count - 1
            'str_areas = str_areas & arr_datos(int_i) & ","
            cmb_area.Items.Add(arr_nombre(int_i).ToString.PadRight(50) & arr_datos(int_i).ToString.PadRight(10))
        Next
        cmb_area.SelectedIndex = 0


        'lleno combo prioridad con secuencias
        opr_pedido.LlenarComboPrioridad(cmb_ped_tipo, False, False)
        cmb_ped_tipo.SelectedIndex = 0

    End Sub


    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click

        Dim pedido_grupo As String
        Dim pedido() As String
        Dim i As Integer
        Dim usuario As Single = 0

        'CONDICIONES EXISTENTES EN LOS TURNOS A ELEJIR
        If Not IsNumeric(txt_desde.Text) Or Not IsNumeric(txt_hasta.Text) Then
            MsgBox("Los valores DESDE y HASTA deben ser num�ricos.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        ElseIf txt_desde.Text = "" Or txt_hasta.Text = "" Then
            MsgBox("El campo DESDE y HASTA deben tener datos.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        ElseIf CLng(txt_desde.Text) > CLng(txt_hasta.Text) Then
            MsgBox("El campo DESDE debe ser menor al campo HASTA.", MsgBoxStyle.Information, "ANALISYS")
            Exit Sub
        End If

        If cmb_area.Text <> "<Disponibles>" Then
            usuario = Trim(Mid(cmb_area.Text, 51, 10))
        End If


        pedido_grupo = opr_cod.LeerPedidodeturno(txt_desde.Text, txt_hasta.Text, dtp_fecha.Value, Trim(cmb_ped_tipo.SelectedText))
        Cursor.Current = Cursors.WaitCursor
        pedido = Split(pedido_grupo, ",")
        If UBound(pedido) > 0 Then
            For i = 0 To UBound(pedido) - 1
                opr_cod.imprimir_codigo(pedido(i), dtp_fecha.Value)
            Next
            MsgBox("La impresi�n de las etiquetas se ha realizado exitosamente.", MsgBoxStyle.Information, "ANALISYS")
        End If
        Cursor.Current = Cursors.Default

    End Sub

   
    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class
