'*************************************************************************
' Nombre:   frm_LeerSNI
' Tipo de Archivo: formulario
' Descripción:  formulario que permite obtener los datos de los analizadores
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones:
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_LeerSNI
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
    Friend WithEvents grp_Ciudad As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents chkl_equipo As System.Windows.Forms.CheckedListBox
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents pan_btn As System.Windows.Forms.Panel
    Friend WithEvents Pic_close As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pic_barra As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LeerSNI))
        Me.grp_Ciudad = New System.Windows.Forms.GroupBox
        Me.chkl_equipo = New System.Windows.Forms.CheckedListBox
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.pic_icono = New System.Windows.Forms.PictureBox
        Me.pan_btn = New System.Windows.Forms.Panel
        Me.Pic_close = New System.Windows.Forms.PictureBox
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pic_barra = New System.Windows.Forms.PictureBox
        Me.grp_Ciudad.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        CType(Me.pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_btn.SuspendLayout()
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Ciudad
        '
        Me.grp_Ciudad.BackColor = System.Drawing.Color.Transparent
        Me.grp_Ciudad.Controls.Add(Me.chkl_equipo)
        Me.grp_Ciudad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Ciudad.ForeColor = System.Drawing.Color.Navy
        Me.grp_Ciudad.Location = New System.Drawing.Point(20, 36)
        Me.grp_Ciudad.Name = "grp_Ciudad"
        Me.grp_Ciudad.Size = New System.Drawing.Size(358, 134)
        Me.grp_Ciudad.TabIndex = 0
        Me.grp_Ciudad.TabStop = False
        Me.grp_Ciudad.Text = "Obtener datos de:"
        '
        'chkl_equipo
        '
        Me.chkl_equipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkl_equipo.CheckOnClick = True
        Me.chkl_equipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkl_equipo.Location = New System.Drawing.Point(24, 22)
        Me.chkl_equipo.Name = "chkl_equipo"
        Me.chkl_equipo.Size = New System.Drawing.Size(314, 98)
        Me.chkl_equipo.TabIndex = 0
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
        Me.btn_Salir.Location = New System.Drawing.Point(203, 178)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 24)
        Me.btn_Salir.TabIndex = 2
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(115, 178)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Aceptar.TabIndex = 1
        Me.btn_Aceptar.Text = "Leer"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.pic_icono)
        Me.pan_barra.Controls.Add(Me.pan_btn)
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Controls.Add(Me.pic_barra)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(398, 25)
        Me.pan_barra.TabIndex = 93
        '
        'pic_icono
        '
        Me.pic_icono.BackColor = System.Drawing.Color.SteelBlue
        Me.pic_icono.Image = CType(resources.GetObject("pic_icono.Image"), System.Drawing.Image)
        Me.pic_icono.Location = New System.Drawing.Point(22, 5)
        Me.pic_icono.Name = "pic_icono"
        Me.pic_icono.Size = New System.Drawing.Size(16, 16)
        Me.pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_icono.TabIndex = 63
        Me.pic_icono.TabStop = False
        '
        'pan_btn
        '
        Me.pan_btn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pan_btn.Controls.Add(Me.Pic_close)
        Me.pan_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_btn.Location = New System.Drawing.Point(358, 8)
        Me.pan_btn.Name = "pan_btn"
        Me.pan_btn.Size = New System.Drawing.Size(10, 12)
        Me.pan_btn.TabIndex = 3
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
        Me.lbl_textform.ForeColor = System.Drawing.Color.White
        Me.lbl_textform.Image = CType(resources.GetObject("lbl_textform.Image"), System.Drawing.Image)
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(35, 7)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(107, 13)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "  Descargar Datos"
        '
        'pic_barra
        '
        Me.pic_barra.BackColor = System.Drawing.Color.Transparent
        Me.pic_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_barra.Image = CType(resources.GetObject("pic_barra.Image"), System.Drawing.Image)
        Me.pic_barra.Location = New System.Drawing.Point(0, 0)
        Me.pic_barra.Name = "pic_barra"
        Me.pic_barra.Size = New System.Drawing.Size(398, 25)
        Me.pic_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barra.TabIndex = 91
        Me.pic_barra.TabStop = False
        '
        'frm_LeerSNI
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(398, 208)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.grp_Ciudad)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_LeerSNI"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Descargar Datos"
        Me.grp_Ciudad.ResumeLayout(False)
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_btn.ResumeLayout(False)
        CType(Me.Pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public frm_refer_main As Frm_Main

#Region "Código de Formulario"
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseEnter, btn_Aceptar.MouseEnter, btn_Salir.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_close.MouseLeave, btn_Aceptar.MouseLeave, btn_Salir.MouseLeave
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

    Private Sub Formulario_closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Not frm_refer_main.ExisteForm("frm_ValidacionRes") Then
            Dim frm_MDIChild As New frm_ValidacionRes()
            frm_MDIChild.MdiParent = frm_refer_main
            frm_MDIChild.Show()
        End If
    End Sub

#End Region

    Dim opr_SNI As New Cls_SNI()

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'Cierra el formulario
        Me.Close()
    End Sub

    Private Sub frm_LeerSNI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        frm_refer_main.Limpia_menu()
        'llenala lista con los equipos que se ecuentran activos
        'en la base equ_estado:
        '1-->activo
        '2-->desactivado
        opr_SNI.LlenarListaEquipo(chkl_equipo)
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'declaracion de variables
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim int_i As Short
        Dim byt_resultado As Byte
        Dim str_equiposerror As String = ""
        'abre el formulario para la validacion de resultados
        Dim frm_valaux As New frm_ValidacionRes()

        'recorro la lista de equipos
        For int_i = 0 To chkl_equipo.Items.Count - 1
            'pregunto si el equipo esta seleccionado de la lista de equipos
            frm_refer_main.sta_barmain.Panels(2).Text = "EXTRAYENDO DATOS DE: " & Trim(chkl_equipo.Items.Item(int_i).substring(0, 150))
            If chkl_equipo.GetItemChecked(int_i) = True Then
                'procedo a recuperar los datos, devuelve un resultado tipo byte
                'En el siguiente if se separa la interpretación de datos de un equipo con SNI (FTP) y otro SERIAL,
                'para la interfaz serial, si esta se ejecuta en windows 2000 o xp se levanta el servicio ftp, 
                'por lo que se maneja igual que si fuera SNI, si fuera win98 o 95, entonces se accede por medio
                'de carpetas compartidas (xxx pendiente de implementar), para dicho procesos se llama a las interfaces 
                'asi: SNI --> SNI1, SNI2, ...., SNIn       COM --> COM1, COM2, ...., COMn       FOLDER --> FOLDER1, FOLDER2, ...., FOLDERn
                If UCase(Trim(chkl_equipo.Items.Item(int_i).substring(150, 1))) <> "F" Then
                    byt_resultado = opr_SNI.LeerFTP(Trim(chkl_equipo.Items.Item(int_i).substring(170, 20)), Trim(chkl_equipo.Items.Item(int_i).substring(190, 50)), Trim(chkl_equipo.Items.Item(int_i).substring(240, 50)), Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)), Trim(chkl_equipo.Items.Item(int_i).substring(440, 150)))
                    'si existe error devuelve 0 , y muestra un mesnaje 
                    If byt_resultado = 0 Then
                        str_equiposerror = Trim(chkl_equipo.Items.Item(int_i).substring(0, 150)) & ", " & str_equiposerror
                    End If
                    'frm_valaux.InterpretarDatos(Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)))
                    frm_valaux.InterpretarDatos(chkl_equipo.Items.Item(int_i))
                Else
                    'CODIGO PARA INTERPRETAR LOS DATOS DE UN EQUIPO CONECTADO POR SERIAL EN UNA CARPETA COMPARTIDA
                    'byt_resultado = opr_SNI.leer_enviar_Folder(Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)), Trim(chkl_equipo.Items.Item(int_i).substring(440, 150)), "*.cdf")
                    byt_resultado = opr_SNI.leer_traer_Folder(Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)), Trim(chkl_equipo.Items.Item(int_i).substring(440, 150)), "*.cdf")
                    'si existe error devuelve 0 , y muestra un mensaje 
                    If byt_resultado = 0 Then
                        str_equiposerror = Trim(chkl_equipo.Items.Item(int_i).substring(0, 150)) & ", " & str_equiposerror
                    End If
                    'jpo 2003/06/26 Código para recuperar el *.log de cada equipo
                    byt_resultado = opr_SNI.leer_traer_Folder(Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)), Trim(chkl_equipo.Items.Item(int_i).substring(440, 150)), "*.log")
                    If byt_resultado = 0 Then
                        str_equiposerror = Trim(chkl_equipo.Items.Item(int_i).substring(0, 150)) & ", " & str_equiposerror
                    End If
                    byt_resultado = opr_SNI.leer_traer_Folder(Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)), Trim(chkl_equipo.Items.Item(int_i).substring(440, 150)), "*.qct")
                    If byt_resultado = 0 Then
                        str_equiposerror = Trim(chkl_equipo.Items.Item(int_i).substring(0, 150)) & ", " & str_equiposerror
                    End If
                    byt_resultado = opr_SNI.leer_traer_Folder(Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)), Trim(chkl_equipo.Items.Item(int_i).substring(440, 150)), "*.clb")
                    If byt_resultado = 0 Then
                        str_equiposerror = Trim(chkl_equipo.Items.Item(int_i).substring(0, 150)) & ", " & str_equiposerror
                    End If
                    'frm_valaux.InterpretarDatos(Trim(chkl_equipo.Items.Item(int_i).substring(290, 150)))
                    frm_valaux.InterpretarDatos(chkl_equipo.Items.Item(int_i))
                    'jpo 2003/06/26 Código para recuperar el *.log de cada equipo
                End If
            End If
        Next
        If Trim(str_equiposerror) <> "" Then
            str_equiposerror = str_equiposerror.Remove(Len(str_equiposerror) - 2, 2)
            MsgBox("Error al transferir los datos del analizador(es): " & Chr(13) & str_equiposerror, MsgBoxStyle.Exclamation, "ANALISYS")
            frm_refer_main.sta_barmain.Panels(2).Text = "ERROR AL TRANSFERIR LOS DATOS DEL ANALIZADOR(ES)"
        Else
            frm_refer_main.sta_barmain.Panels(2).Text = "DATOS RECIBIDOS DESDE LOS ANALIZADORES"
        End If

        'Función que lee cada uno de los archivos cdf, log, ctl, clb, etc y los inserta en la base
        frm_refer_main.sta_barmain.Panels(2).Text = "ASIGNANDO RESULTADOS A PEDIDOS, ESPERE POR FAVOR"
        'cierro el formulario
        Me.Close()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        frm_refer_main.sta_barmain.Panels(2).Text = "DISPONIBLE"
    End Sub

End Class
