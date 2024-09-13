Public Class frm_ValRemitidos
    Inherits System.Windows.Forms.Form

#Region "Cdigo de Formulario"
    '    Private m_HtImages As New Hashtable()
    '    Dim imageToDraw As Image

    '    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseEnter, btn_Salir.MouseEnter, btn_Aceptar.MouseEnter
    '        'cuando el mouse se mueve por encima del los botones del formulario
    '        Select Case sender.name
    '            Case "Pic_close"
    '                If m_HtImages.ContainsKey("btn_closep") Then
    '                    imageToDraw = CType(m_HtImages("btn_closep"), System.Drawing.Image)
    '                Else
    '                    Try
    '                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_closep.jpg")
    '                        m_HtImages.Add("btn_closep", imageToDraw)
    '                    Catch
    '                        Return
    '                    End Try
    '                End If
    '                sender.Image = imageToDraw
    '            Case Else
    '                If sender.name Like "btn_*" Then
    '                    sender.Font = New Font(Me.Font, FontStyle.Bold)
    '                    sender.forecolor = Color.White
    '                    If m_HtImages.ContainsKey("barraMenu1") Then
    '                        imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
    '                    Else
    '                        Try
    '                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
    '                            m_HtImages.Add("barraMenu1", imageToDraw)
    '                        Catch
    '                            Return
    '                        End Try
    '                    End If
    '                    sender.BackgroundImage = imageToDraw
    '                End If
    '        End Select
    '    End Sub

    '    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseLeave, btn_Salir.MouseLeave, btn_Aceptar.MouseLeave
    '        'cuando el mouse se pierde el enfoque del los botones del formulario
    '        Select Case sender.name
    '            Case "Pic_close"
    '                If m_HtImages.ContainsKey("btn_close") Then
    '                    imageToDraw = CType(m_HtImages("btn_close"), System.Drawing.Image)
    '                Else
    '                    Try
    '                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_close.jpg")
    '                        m_HtImages.Add("btn_close", imageToDraw)
    '                    Catch
    '                        Return
    '                    End Try
    '                End If
    '                sender.Image = imageToDraw
    '            Case Else
    '                If sender.name Like "btn_*" Then
    '                    sender.Font = New Font(Me.Font, FontStyle.Regular)
    '                    sender.forecolor = Color.Black
    '                    If m_HtImages.ContainsKey("barraMenu2") Then
    '                        imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
    '                    Else
    '                        Try
    '                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
    '                            m_HtImages.Add("barraMenu2", imageToDraw)
    '                        Catch
    '                            Return
    '                        End Try
    '                    End If
    '                    sender.BackgroundImage = imageToDraw
    '                End If
    '        End Select
    '    End Sub

    '    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.Click
    '        Select Case sender.name
    '            Case "Pic_close"
    '                Me.Close()
    '        End Select
    '    End Sub

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
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents dgrd_pedidos As System.Windows.Forms.DataGrid
    Friend WithEvents lbl_pedido As System.Windows.Forms.Label
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents lbl_pedidoR As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_File As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_pacienteR As System.Windows.Forms.Label
    Friend WithEvents dgtc_Labo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_validar As System.Windows.Forms.Button
    Friend WithEvents dgtc_FilePath As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_RemVer As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtc_RemId As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ValRemitidos))
        Me.lbl_msg = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.dgrd_pedidos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_File = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_FilePath = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_Labo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_RemId = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgtc_RemVer = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbl_pedidoR = New System.Windows.Forms.Label
        Me.lbl_pedido = New System.Windows.Forms.Label
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lbl_pacienteR = New System.Windows.Forms.Label
        Me.btn_validar = New System.Windows.Forms.Button
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_msg
        '
        Me.lbl_msg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_msg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.Navy
        Me.lbl_msg.Location = New System.Drawing.Point(36, 256)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(460, 18)
        Me.lbl_msg.TabIndex = 52
        Me.lbl_msg.Visible = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(310, 280)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 32)
        Me.btn_Salir.TabIndex = 49
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(226, 280)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 32)
        Me.btn_Aceptar.TabIndex = 48
        Me.btn_Aceptar.Text = "Adjuntar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'dgrd_pedidos
        '
        Me.dgrd_pedidos.AllowSorting = False
        Me.dgrd_pedidos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_pedidos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_pedidos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_pedidos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_pedidos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.CaptionText = "TEST"
        Me.dgrd_pedidos.DataMember = ""
        Me.dgrd_pedidos.FlatMode = True
        Me.dgrd_pedidos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_pedidos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_pedidos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_pedidos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_pedidos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.Location = New System.Drawing.Point(14, 56)
        Me.dgrd_pedidos.Name = "dgrd_pedidos"
        Me.dgrd_pedidos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_pedidos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.RowHeaderWidth = 20
        Me.dgrd_pedidos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_pedidos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.Size = New System.Drawing.Size(484, 216)
        Me.dgrd_pedidos.TabIndex = 47
        Me.dgrd_pedidos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_pedidos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn3, Me.dgtc_File, Me.dgtc_FilePath, Me.dgtc_Labo, Me.dgtc_RemId, Me.dgtc_RemVer})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.PreferredRowHeight = 18
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "TEST"
        Me.DataGridTextBoxColumn1.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "TEST"
        Me.DataGridTextBoxColumn2.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 140
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = "False"
        Me.DataGridBoolColumn1.HeaderText = "REMITIDO"
        Me.DataGridBoolColumn1.MappingName = "REMITIDO"
        Me.DataGridBoolColumn1.TrueValue = "True"
        Me.DataGridBoolColumn1.Width = 55
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn3.MappingName = "ESTADO"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'dgtc_File
        '
        Me.dgtc_File.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgtc_File.Format = ""
        Me.dgtc_File.FormatInfo = Nothing
        Me.dgtc_File.MappingName = "BUSCAR"
        Me.dgtc_File.ReadOnly = True
        Me.dgtc_File.Width = 20
        '
        'dgtc_FilePath
        '
        Me.dgtc_FilePath.Format = ""
        Me.dgtc_FilePath.FormatInfo = Nothing
        Me.dgtc_FilePath.HeaderText = "ARCHIVO"
        Me.dgtc_FilePath.MappingName = "ARCHIVO"
        Me.dgtc_FilePath.Width = 80
        '
        'dgtc_Labo
        '
        Me.dgtc_Labo.Format = ""
        Me.dgtc_Labo.FormatInfo = Nothing
        Me.dgtc_Labo.HeaderText = "LABORATORIO"
        Me.dgtc_Labo.MappingName = "LABORATORIO"
        Me.dgtc_Labo.Width = 130
        '
        'dgtc_RemId
        '
        Me.dgtc_RemId.Format = ""
        Me.dgtc_RemId.FormatInfo = Nothing
        Me.dgtc_RemId.HeaderText = "REM_ID"
        Me.dgtc_RemId.MappingName = "REM_ID"
        Me.dgtc_RemId.Width = 20
        '
        'dgtc_RemVer
        '
        Me.dgtc_RemVer.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgtc_RemVer.Format = ""
        Me.dgtc_RemVer.FormatInfo = Nothing
        Me.dgtc_RemVer.HeaderText = "VER"
        Me.dgtc_RemVer.MappingName = "VER"
        Me.dgtc_RemVer.ReadOnly = True
        Me.dgtc_RemVer.Width = 30
        '
        'lbl_pedidoR
        '
        Me.lbl_pedidoR.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pedidoR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedidoR.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pedidoR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_pedidoR.Location = New System.Drawing.Point(84, 32)
        Me.lbl_pedidoR.Name = "lbl_pedidoR"
        Me.lbl_pedidoR.Size = New System.Drawing.Size(102, 14)
        Me.lbl_pedidoR.TabIndex = 51
        '
        'lbl_pedido
        '
        Me.lbl_pedido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.Location = New System.Drawing.Point(16, 32)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(60, 14)
        Me.lbl_pedido.TabIndex = 50
        Me.lbl_pedido.Text = "Pedido # :"
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(15, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(104, 19)
        Me.lbl_textform.TabIndex = 94
        Me.lbl_textform.Text = "REMITIDOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_pacienteR
        '
        Me.lbl_pacienteR.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pacienteR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pacienteR.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pacienteR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_pacienteR.Location = New System.Drawing.Point(35, 280)
        Me.lbl_pacienteR.Name = "lbl_pacienteR"
        Me.lbl_pacienteR.Size = New System.Drawing.Size(102, 14)
        Me.lbl_pacienteR.TabIndex = 95
        Me.lbl_pacienteR.Visible = False
        '
        'btn_validar
        '
        Me.btn_validar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_validar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_validar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_validar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validar.ForeColor = System.Drawing.Color.Black
        Me.btn_validar.Image = CType(resources.GetObject("btn_validar.Image"), System.Drawing.Image)
        Me.btn_validar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_validar.Location = New System.Drawing.Point(101, 280)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(119, 32)
        Me.btn_validar.TabIndex = 97
        Me.btn_validar.Text = "Adjuntar y Validar"
        Me.btn_validar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_validar.UseVisualStyleBackColor = False
        '
        'frm_ValRemitidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(520, 326)
        Me.Controls.Add(Me.btn_validar)
        Me.Controls.Add(Me.dgrd_pedidos)
        Me.Controls.Add(Me.lbl_pacienteR)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.lbl_msg)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.lbl_pedidoR)
        Me.Controls.Add(Me.lbl_pedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_ValRemitidos"
        Me.ShowInTaskbar = False
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim opr_resul As New Cls_Resultado()
    Dim opr_pedido As New Cls_Pedido()
    Dim opr_remitidos As New Cls_Remitidos()
    Dim dtt_resPedido As New DataTable("Registros")
    Public frm_refer_main As Frm_Main
    Private boo_cambiaTam As Boolean = False
    Private WithEvents cmb_laboratorio As New ComboBox()
    Private WithEvents btn_buscarpdf As New Button()
    Private WithEvents dtt_tabla As New DataTable("Registros")
    Private WithEvents dtv_tabla As New DataView(dtt_tabla)
    Public dtv_test As New DataView

    Sub inicia()
        On Error Resume Next
        Dim int_tam As Short
        int_tam = 130
        CargarCombo()
        AddHandler dgtc_File.TextBox.DoubleClick, AddressOf TextoDblClick
        AddHandler dgtc_RemVer.TextBox.DoubleClick, AddressOf VerDblClick

        AddHandler dgtc_Labo.TextBox.Enter, AddressOf Despliega_laboratorio
        AddHandler dgtc_Labo.TextBox.MouseEnter, AddressOf Despliega_laboratorio

        'combo de laboratotio
        cmb_laboratorio.Font = New Font("Courier New", 8.2!, FontStyle.Regular)
        cmb_laboratorio.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_laboratorio.Width = int_tam
        dgtc_Labo.TextBox.Width = int_tam
        cmb_laboratorio.Text = dgtc_Labo.TextBox.Text
        dgtc_Labo.TextBox.Controls.Add(cmb_laboratorio)
        cmb_laboratorio.BringToFront()
    End Sub

    Private Sub Despliega_laboratorio(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        cmb_laboratorio.SelectedIndex = UbicaCombo(dgrd_pedidos(dgrd_pedidos.CurrentCell.RowNumber, 5).substring(0, 5), cmb_laboratorio)
        cmb_laboratorio_Enfoque(Sender, e)
    End Sub

    Private Sub select_laboratorio(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_laboratorio.SelectedValueChanged
        On Error Resume Next
        'escribe en el grid el texto seleccionado en el grid
        Inserta_campo(6, sender.text)
        TamColumna(sender, e)
    End Sub


    Sub TamColumna(ByVal sender As Object, ByVal e As System.EventArgs)
        'dgcs_producto.TextBox.Text = Mid(dgcs_producto.TextBox.Text, 15)
        dgtc_Labo.Width = 130
    End Sub

    Private Sub cmb_laboratorio_Enfoque(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_laboratorio.Enter
        boo_cambiaTam = True
        dgtc_Labo.Width = 130
        dgtc_Labo.TextBox.Width = 130
        boo_cambiaTam = False
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

    Sub CargarCombo()
        On Error Resume Next
        Dim dtr_fila As DataRow
        cmb_laboratorio.Items.Clear()
        For Each dtr_fila In opr_remitidos.LeerLabRemitidos().Tables(0).Rows
            cmb_laboratorio.Items.Add(dtr_fila("lar_id").ToString().PadRight(5) & " " & Mid(dtr_fila("lar_nombre").ToString(), 1, 25).PadRight(5))
        Next
    End Sub

    Sub TextoDblClick(ByVal Sender As Object, ByVal e As EventArgs)

        OpenFileDialog1.InitialDirectory = "D:/"
        OpenFileDialog1.Filter = "All Files|*.*|pdf|*.pdf"
        OpenFileDialog1.FilterIndex = 2

        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Try
                'El metodo LoadFile recibe un String con la ubicacion del archivo que cargar�
                Inserta_campo(5, OpenFileDialog1.FileName)
                'AxAcroPDF1.LoadFile(Application.StartupPath & lbl_ruta.Text)
            Catch er As Exception
                MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
            End Try
        End If
    End Sub

    Sub VerDblClick(ByVal Sender As Object, ByVal e As EventArgs)
        Try
            Dim abrirPdf As String
            If (dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 5).ToString <> "     ") Then
                abrirPdf = dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 5).ToString
                System.Diagnostics.Process.Start(abrirPdf)
            Else
                MsgBox("Seleccione el origen del pdf", MsgBoxStyle.Information, "Informacion")
            End If

        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Information, "Informacion")
        End Try

    End Sub

    Sub Inserta_campo(ByVal columna As Short, ByVal texto As String)
        On Error GoTo msgerrcol
        If Trim(texto) = "" Then Exit Sub
        dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, columna) = texto
        Exit Sub
msgerrcol:
        dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, columna) = texto
    End Sub



    Private Sub frm_ValRemitidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        Dim int_indice As Integer
        Dim repetir As String

        inicia()

        Dim STR_CAPTION As String() = {"tes_id", "tes_nombre", "REMITIDO", "ESTADO", "BUSCAR", "ARCHIVO", "LABORATORIO", "REM_ID", "VER"}
        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        '*************************
        For int_indice = 0 To 4
            Dim dtc_columna As New DataColumn(STR_CAPTION(int_indice))
            dtt_resPedido.Columns.Add(dtc_columna)
        Next
        opr_resul.RemitirResultados(CInt(lbl_pedidoR.Text), dtt_resPedido)
        dtv_test = New DataView(dtt_resPedido)
        dtv_test.AllowNew = False
        dgrd_pedidos.DataSource = dtv_test


    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        remitir(0)
    End Sub

    Private Sub remitir(ByVal validar As Integer)
        Dim pac_id, path, ped_id, rem_fecha, pdf, lab As String
        Dim sec As Integer
        Dim modifica As Integer
        Dim tes_id As Integer
        Dim i As Integer

        pac_id = Convert.ToInt32(lbl_pacienteR.Text)
        ped_id = lbl_pedidoR.Text
        rem_fecha = DevuelveFechaFormatoAS(System.DateTime.Now.ToShortDateString())
        Try
            For i = 0 To dtv_test.Count - 1
                If ((dgrd_pedidos.Item(i, 2) = True) And (dgrd_pedidos.Item(i, 3) = "0" Or dgrd_pedidos.Item(i, 3) = "9")) Then ' si esta chequeado y es nuevo
                    modifica = 1
                    If ((dgrd_pedidos.Item(i, 5) <> "     ") Or (dgrd_pedidos.Item(i, 6) <> "     ")) Then ' dejar espacio "     " es un amague, no me pregunte porque pero dejar
                        sec = opr_remitidos.LeerSecuencial(pac_id)
                        path = dgrd_pedidos.Item(i, 5)

                        lab = Trim(Mid(dgrd_pedidos.Item(i, 6), 5, Len(dgrd_pedidos.Item(i, 6))))
                        tes_id = dgrd_pedidos.Item(i, 0)

                        opr_remitidos.GuardaPDF(ped_id, pac_id, sec, path, 1, pdf)
                        opr_remitidos.ActualizaSecuencial(pac_id, sec)
                        opr_remitidos.ActualizaListaTrabajo(ped_id, tes_id, lab, modifica, validar, pdf, rem_fecha)
                    Else
                        MsgBox("Debe ingresar los datos del archivo y laboratorio.", MsgBoxStyle.Exclamation, "ANALISYS")
                    End If
                End If
                If ((dgrd_pedidos.Item(i, 2) = False) And (dgrd_pedidos.Item(i, 3) = "9")) Then ' SI NO ESTA CHEQUEADO Y FUE REMITIDO
                    modifica = 1
                    If ((dgrd_pedidos.Item(i, 5) <> "     ") Or (dgrd_pedidos.Item(i, 6) <> "     ")) Then ' dejar espacio "     " es un amague, no me pregunte porque pero dejar
                        sec = opr_remitidos.LeerSecuencial(pac_id)
                        path = dgrd_pedidos.Item(i, 5)
                        lab = Trim(Mid(dgrd_pedidos.Item(i, 6), 1, 5))
                        tes_id = dgrd_pedidos.Item(i, 0)


                        opr_remitidos.GuardaPDF(ped_id, pac_id, sec, path, 1, pdf)
                        opr_remitidos.ActualizaSecuencial(pac_id, sec)
                        opr_remitidos.ActualizaListaTrabajo(ped_id, tes_id, lab, modifica, validar, pdf, rem_fecha)
                    Else
                        MsgBox("Debe ingresar los datos del archivo y laboratorio.", MsgBoxStyle.Exclamation, "ANALISYS")
                    End If
                End If

            Next
            MsgBox("Remitidos agregados exitosamente.", MsgBoxStyle.Information, "ANALISYS")
            Me.Close()
        Catch er As Exception

        End Try

    End Sub

    Public Sub carga_datos_laboratorio(ByVal laboratorio As String)
        On Error Resume Next
        Dim dts_movimiento As New DataSet()
        Dim dtr_operacion As DataRow
        dtt_tabla.Rows(dgrd_pedidos.CurrentCell.RowNumber).Item(3) = Trim(Mid(laboratorio, 1, 15))
        dtt_tabla.Rows(dgrd_pedidos.CurrentCell.RowNumber).Item(2) = Trim(laboratorio)
        cmb_laboratorio.SelectedText = laboratorio
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validar.Click
        remitir(5)
    End Sub

End Class
