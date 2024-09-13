'*************************************************************************
' Nombre:   frm_Inicio
' Tipo de Archivo: formulario
' Descripcin:  formulario que permite le ingreso de los usuarios
' Autores:  rfn
' Fecha de Creaci�n: 

' Ultima Modificaci�n:  Dic - 2008
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports Microsoft.Win32
Public Class frm_Inicio
    Inherits System.Windows.Forms.Form

    Dim oprEncr As New Cls_Encripta()
    Dim oprArch As New Cls_Archivos()
    Dim var_usr As String = Nothing
    Dim var_pass As String = Nothing
    Dim opr_formulario As New Cls_Formularios()
    Dim contador As Integer = 1
    Dim opr_encripta As New Cls_Encripta()
    Dim opr_negocio As New Cls_Pedido()
    Dim opr_usr As New Cls_Usuario()
    Dim DIBUJO As Graphics
    Dim BM As Bitmap
    Dim LAPIZ As New Pen(Color.Red, 1)
    Dim g_opr_invitado As New Cls_Invitado()



#Region "Codigo de Formulario"
    Private m_HtImages As New Hashtable()
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents cmb_Sedes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents lst_IniciaModulos As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Dim imageToDraw As Image

    'Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'cuando el mouse se mueve por encima del los botones del formulario
    'If sender.name Like "btn_*" Then
    '    sender.Font = New Font(Me.Font, FontStyle.Bold)
    '    sender.forecolor = Color.White
    '    If m_HtImages.ContainsKey("barraMenu1") Then
    '        imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
    '    Else
    '        Try
    '            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
    '            m_HtImages.Add("barraMenu1", imageToDraw)
    '        Catch
    '            Return
    '        End Try
    '    End If
    '    sender.BackgroundImage = imageToDraw
    'End If


    'End Sub

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cuando el mouse se pierde el enfoque del los botones del formulario
        'If sender.name Like "btn_*" Then
        '    sender.Font = New Font(Me.Font, FontStyle.Regular)
        '    sender.forecolor = Color.Black
        '    If m_HtImages.ContainsKey("barraMenu2") Then
        '        imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
        '    Else
        '        Try
        '            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
        '            m_HtImages.Add("barraMenu2", imageToDraw)
        '        Catch
        '            Return
        '        End Try
        '    End If
        '    sender.BackgroundImage = imageToDraw
        'End If
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

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Inicio))
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.Ctl_txt_usuario = New System.Windows.Forms.TextBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.cmb_Sedes = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_titulo = New System.Windows.Forms.Label
        Me.lst_IniciaModulos = New System.Windows.Forms.ListBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(397, 202)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(144, 30)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Tag = "Ingresar"
        Me.btn_Aceptar.Text = "Siguiente"
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'Ctl_txt_usuario
        '
        Me.Ctl_txt_usuario.Location = New System.Drawing.Point(388, 157)
        Me.Ctl_txt_usuario.Name = "Ctl_txt_usuario"
        Me.Ctl_txt_usuario.Size = New System.Drawing.Size(162, 21)
        Me.Ctl_txt_usuario.TabIndex = 20
        Me.Ctl_txt_usuario.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cerrar.ForeColor = System.Drawing.Color.DimGray
        Me.btn_Cerrar.Location = New System.Drawing.Point(533, 4)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(40, 20)
        Me.btn_Cerrar.TabIndex = 21
        Me.btn_Cerrar.TabStop = False
        Me.btn_Cerrar.Text = "Close"
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'cmb_Sedes
        '
        Me.cmb_Sedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sedes.Enabled = False
        Me.cmb_Sedes.FormattingEnabled = True
        Me.cmb_Sedes.Location = New System.Drawing.Point(173, 260)
        Me.cmb_Sedes.Name = "cmb_Sedes"
        Me.cmb_Sedes.Size = New System.Drawing.Size(161, 21)
        Me.cmb_Sedes.TabIndex = 22
        Me.cmb_Sedes.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(366, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "msg"
        Me.Label1.Visible = False
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_titulo.Location = New System.Drawing.Point(432, 98)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(56, 15)
        Me.lbl_titulo.TabIndex = 24
        Me.lbl_titulo.Text = "lbl_titulo"
        '
        'lst_IniciaModulos
        '
        Me.lst_IniciaModulos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lst_IniciaModulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_IniciaModulos.ForeColor = System.Drawing.Color.White
        Me.lst_IniciaModulos.FormattingEnabled = True
        Me.lst_IniciaModulos.Location = New System.Drawing.Point(364, 238)
        Me.lst_IniciaModulos.Name = "lst_IniciaModulos"
        Me.lst_IniciaModulos.Size = New System.Drawing.Size(202, 52)
        Me.lst_IniciaModulos.TabIndex = 26
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 220)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'frm_Inicio
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(576, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lst_IniciaModulos)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Sedes)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.Ctl_txt_usuario)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frm_Inicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'opr_formulario.Redondear_Formulario(Me, 100)
        'Dim g_sede As Byte
        Dim arre_accesos As String = Nothing
        Dim arre_modulos As String()
        Dim arre_desc As String()
        Dim i, j As Integer
        Dim arre_drives As String()

        'verifica si el sistema ha sido instalado con autorizacion
        g_Titulo = System.Configuration.ConfigurationSettings.AppSettings("TITULO")
        lbl_titulo.Text = g_Titulo

        IniciaParametros()

        arre_drives = Split(opr_usr.DevuelveSerialDRIVE(), "º")

        If GetSetting("TRUESOLUTIONS", "1712996840", "Acceso") <> Trim(g_opr_usuario.LeeKey()) Then

            ' arre_drives(0) = "1C040404090C00040801"

            ' If opr_encripta.Encriptar(Mid(arre_drives(0), 5, Len(arre_drives(0)))) <> Trim(g_opr_usuario.LeeKey()) Then
            'MsgBox("Usted a instalado una copia ilegal de este software", MsgBoxStyle.Critical, "ANALISYS")
            arre_accesos = arre_accesos & "ANALISYS LAB,0º"
            btn_Aceptar.Enabled = True
        Else
            arre_accesos = arre_accesos & "ANALISYS LAB,1º"
            btn_Aceptar.Enabled = True
        End If



        If GetSetting("TRUESOLUTIONS", "1712996840", "Acceso2") <> Trim(g_opr_usuario.LeeKeyOcupacional()) Then
            'If opr_encripta.Encriptar(Mid(arre_drives(0), 5, Len(arre_drives(0)))) <> Trim(g_opr_usuario.LeeKeyOcupacional()) Then
            arre_accesos = arre_accesos & "ANALISYS MEDIC,0º"
            g_EsOcupacional = 0
        Else
            arre_accesos = arre_accesos & "ANALISYS MEDIC,1º"
            g_EsOcupacional = 1
        End If
        g_EsOcupacional = 1
        lst_IniciaModulos.Items.Add("CONSULTANDO ACCESOS...")

        arre_modulos = Split(arre_accesos, "º")

        For i = 0 To UBound(arre_modulos) - 1
            arre_desc = Split(arre_modulos(i), ",")

            If arre_desc(1).ToString = "1" Then
                lst_IniciaModulos.Items.Add(arre_desc(0).ToString & ".... Autorizado")
            Else
                lst_IniciaModulos.Items.Add(arre_desc(0).ToString & ".... Sin licencia")
            End If
        Next




        '''
        '''g_sede = System.Configuration.ConfigurationSettings.AppSettings("SEDE")
        'g_opr_invitado.CargaSedes(cmb_Sedes, g_sede) ' >= 1 Then
        'cmb_Sedes.Enabled = True
        'Else
        'cmb_Sedes.Enabled = False
        'End If

        'If oprEncr.Desencriptar((oprEncr.DevuelveSerialUSB) = oprEncr.Desencriptar(oprArch.DevuelveLicenciaCliente) Then



        'Codigo para obterner los datos creados en el odbc de windows (DSN de sistema)
        'Dim regKey As RegistryKey

        'regKey = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("ODBC").OpenSubKey("ODBC.INI").OpenSubKey("ODBC Data Sources")

        'Dim valueName As String

        'Iterate through the list of DSN names. 

        'If (g_motorBDD = "SQL Server") Then
        ''    For Each valueName In regKey.GetValueNames()
        ''        If regKey.GetValue(valueName) = "SQL Server" Then
        ''            'Lleno los datos de nombres DSN en el combo
        ''            cmb_bd.Items.Add(valueName)
        ''        End If
        ''    Next
        ''End If

        ''If (g_motorBDD = "Mysql") Then
        ''    For Each valueName In regKey.GetValueNames()
        ''        If regKey.GetValue(valueName) = "MySQL ODBC 3.51 Driver" Then
        ''            'Lleno los datos de nombres DSN en el combo
        ''            cmb_bd.Items.Add(valueName)
        ''        End If
        ''    Next
        ''End If


        'Else
        'MsgBox("Fallo en la lectura de la llave de seguridad.", MsgBoxStyle.Critical, "ANALISYS")
        'End If

    End Sub



    Public Sub IniciaParametros()
        'Procedimiento que conecta el app.config para la ruta donde se encuentra ubicada la base de datos
        Dim str_datasource, str_provider, str_location, str_user, str_password, str_port As String

        str_provider = System.Configuration.ConfigurationSettings.AppSettings("ProviderSql")
        str_location = System.Configuration.ConfigurationSettings.AppSettings("LocationSql")
        'str_location = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("ODBC").OpenSubKey("ODBC.INI").OpenSubKey("" & str_datasource & "").GetValue("Server")

        str_datasource = System.Configuration.ConfigurationSettings.AppSettings("DatasourceSql")
        'g_str_bd = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("ODBC").OpenSubKey("ODBC.INI").OpenSubKey("" & str_datasource & "").GetValue("Database")

        str_user = System.Configuration.ConfigurationSettings.AppSettings("UseridSql")
        'str_user = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("ODBC").OpenSubKey("ODBC.INI").OpenSubKey("" & str_datasource & "").GetValue("User")

        str_port = System.Configuration.ConfigurationSettings.AppSettings("Port")
        str_password = System.Configuration.ConfigurationSettings.AppSettings("PasswordSql")

        'str_password = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("ODBC").OpenSubKey("ODBC.INI").OpenSubKey("" & str_datasource & "").GetValue("Password")
        g_str_transaccion = System.Configuration.ConfigurationSettings.AppSettings("SourceT")

        g_unidad = System.Configuration.ConfigurationSettings.AppSettings("UNIDAD")

        'ESTE NO'
        'str_password = opr_encripta.Encriptar(str_password)
        'ESTE(SI) '
        str_password = opr_encripta.Desencriptar(str_password)

        'instruccion para conectarse con password  a MySQL

        'g_str_conexion = "Provider=" & str_provider & ";Location=" & str_location & ";Data Source=" & g_str_bd & ";User ID=" & str_user & ";Password=" & str_password & ";Port=" & str_port
        'g_str_conexion_odbc = "Driver={MySQL ODBC 3.51 Driver};Server=" & str_location & ";Port=" & str_port & ";Database=" & g_str_bd & ";Uid=" & str_user & ";Pwd=" & str_password
        'str_password = "analisys0114"
        g_str_conexion_SQL = "Data Source =" & str_location & " ;Initial catalog = " & str_datasource & "; user id = " & str_user & "; password = " & str_password & ";packet size=4096;"
        g_str_conexion_SQL_PDF = "Data Source =" & str_location & " ;Initial catalog = " & str_datasource & "; user id = pdf; password = " & str_password & ";packet size=4096;"
    End Sub



    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Dim str_pswd As String = Nothing
        'Dim arregloUSB As String()
        Dim byt_habilitausuario As Byte = 0
        Dim byt_habilitainvitado As Byte = 0
        Dim byt_VerificaCodigo As Byte = 0
        Dim str_error As String = Nothing

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Label1.Visible = False

        If btn_Aceptar.Text = "Siguiente" Then

            'verifica que los campos no esten vacios
            If (Ctl_txt_usuario.Text = "") Then
                ''MsgBox("Verifique el usuario.", MsgBoxStyle.Exclamation, "ANALISYS")
                opr_negocio.VisualizaMensaje("Verifique el usuario", g_tiempo)
                Ctl_txt_usuario.Focus()
            Else
                'pic_progress.Visible = True
                Dim opr_encripta As New Cls_Encripta()
                Dim msg As String = Nothing
                'IniciaParametros()

                'If contador = 1 Then
                'Dim opr_auditoria As New cls_auditoria()
                'opr_auditoria.GuardaCodigo("")
                'End If

                If contador <= g_intentos Then
                    '******aqui
                    'If g_opr_usuario.detectallave() Then
                    If g_opr_usuario.controlaFechaVenc() > 3 Then
                        byt_habilitausuario = g_opr_usuario.LeerUsuario(Ctl_txt_usuario.Text, msg)
                        'If msg <> Nothing Then
                        'Label1.Text = msg
                        'End If
                        '******aqui
                    Else
                        '******aqui 2
                        If g_opr_usuario.controlaFechaVenc() <= 0 Then
                            MsgBox("Se ha bloqueado el acceso hasta que renueve su liciencia, ponga en contacto con TRUESolutions.", MsgBoxStyle.Critical, "ANALISYS")
                            byt_habilitausuario = 9
                        End If
                        If byt_habilitausuario = 9 Then

                        Else

                            If g_opr_usuario.controlaFechaVenc() <= 3 Then
                                byt_habilitausuario = g_opr_usuario.LeerUsuario(Ctl_txt_usuario.Text, msg)
                                ''MsgBox("Ud. tiene " & g_opr_usuario.controlaFechaVenc() & " d�a(s) para renovar su licencia.", MsgBoxStyle.Exclamation, "ANALISYS")
                                opr_negocio.VisualizaMensaje("Ud. tiene " & g_opr_usuario.controlaFechaVenc() & " dia(s) para renovar su licencia.", g_tiempo)
                            End If
                        End If

                    End If
                Else
                    opr_negocio.VisualizaMensaje("Ud. ha superado el numero de intentos validos para acceder al sistema", g_tiempo)
                    ''MsgBox("Ud. ha superado el n�mero de intentos validos para acceder al sistema.", MsgBoxStyle.Exclamation, "ANALISYS")
                    g_opr_usuario.CargarTransaccion(g_str_login, "SUPERADO INTENTOS FALLIDO USR", "", g_sng_user, "", "")
                    Me.Close()
                End If


                If byt_habilitausuario = 0 Or byt_habilitausuario = 9 Then
                    g_usuarioF = Nothing
                Else
                    g_usuarioF = Ctl_txt_usuario.Text
                    contador = 0
                End If


                Select Case byt_habilitausuario
                    Case 0

                        'usuario no v�lido
                        Label1.Visible = True
                        Label1.Text = "Usuario no existe"
                        Ctl_txt_usuario.Text = ""
                        Ctl_txt_usuario.Focus()
                        contador = contador + 1

                    Case 1
                        'usuario(ok)
                        'Me.Hide()
                        'usuario ok..........
                        Label1.Visible = True
                        Label1.Text = "Escribir contraseña para " & g_usuarioF
                        var_usr = Ctl_txt_usuario.Text
                        btn_Aceptar.Text = "Iniciar Sesion"
                        Ctl_txt_usuario.Text = ""
                        var_pass = Ctl_txt_usuario.Text
                        'Ctl_txt_usuario.
                        Ctl_txt_usuario.PasswordChar = "*"
                        Ctl_txt_usuario.Focus()
                        'btn_Atras.Visible = True
                        'pic_progress.Visible = False

                    Case 9

                        'usuario no v�lido
                        Label1.Visible = True
                        Label1.Text = "LICENCIA VENCIDA"
                        Ctl_txt_usuario.Text = ""
                        Ctl_txt_usuario.Focus()
                        contador = contador + 1
                End Select
            End If
        Else
            var_pass = Ctl_txt_usuario.Text




            byt_habilitainvitado = g_opr_invitado.LeerUsuario(var_pass)
            If contador <= g_intentos Then
                If byt_habilitainvitado = 1 Then
                    g_invitado = g_opr_invitado.ConsultaNameInvitado(var_pass)
                    g_invitadoID = g_opr_invitado.ConsultaIDInvitado(var_pass)
                    g_invitadoF = g_opr_invitado.ConsultaFirmaInvitado(g_invitadoID)
                    g_str_login = g_opr_invitado.ConsultaNameCargo(g_usuarioF)
                    g_str_unidad = g_opr_invitado.ConsultaNameUnidad(g_unidad)
                    ' Ctl_txt_usuario.texto_Recupera
                    Me.Hide()
                    g_user_log = var_pass
                    Dim f1 As New Frm_Main()
                    f1.ShowDialog()
                Else
                    Ctl_txt_usuario.Text = ""
                    contador = contador + 1
                End If
            Else
                opr_negocio.VisualizaMensaje("Ud. ha superado el numero de intentos validos para acceder al sistema", g_tiempo)
                ''MsgBox("Ud. ha superado el numero de intentos validos para acceder al sistema.", MsgBoxStyle.Exclamation, "ANALISYS")
                Me.Close()
                g_opr_usuario.CargarTransaccion(g_str_login, "SUPERADO INTENTOS FALLIDO PASS", "", g_sng_user, "", "")
            End If
            '' '' ''    Else
            '' '' ''Label1.Text = "NO HAY LLAVE"
            ''''''''End If
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        'Else
        'Me.Close()
        'End If
    End Sub




    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
        'DiffimageLSMS.Image = Image.FromFile(Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & "DiffimageLSMS64.gif")
        '' ''Dim i As Integer
        '' ''Dim x, y, x1, y1 As Integer
        '' ''Dim cadena As String = "0;0;0;0;0;4;13;26;35;34;32;32;34;41;51;64;79;94;105;110;111;108;101;91;79;67;54;41;34;29;23;16;11;10;11;12;14;15;13;10;9;10;11;15;17;17;17;18;19;21;25;29;35;40;42;42;46;55;65;73;84;101;119;132;138;142;155;170;182;196;212;223;225;228;233;240;241;236;236;237;230;227;228;221;210;200;187;174;165;156;142;129;116;105;97;88;78;69;63;60;58;54;45;35;29;24;21;18;13;10;9;10;9;7;5;3;3;2;2;2;2;1;0;0;0;0;0;0;"
        '' ''Dim arreglo As String()
        '' ''arreglo = Split(cadena, ";")
        '' ''PINTA()
        '' ''For i = 1 To UBound(arreglo) - 4
        '' ''    x = arreglo(i)
        '' ''    y = arreglo(i + 1)
        '' ''    x1 = arreglo(i + 2)
        '' ''    y1 = arreglo(i + 3)
        '' ''    DIBUJO.DrawCurve((LAPIZ, x) ', y, x1, y1)
        '' ''    i = i + 4
        '' ''Next
        '' ''PictureBox1.Image = BM
    End Sub


    Public Sub PINTA()

        'BM = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        'DIBUJO = Graphics.FromImage(BM)
        'DIBUJO.Clear(Color.White)
        'DIBUJO.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        'DIBUJO.DrawLine(Pens.LightGray, CSng(PictureBox1.Width / 2), 0, CSng(PictureBox1.Width / 2), PictureBox1.Height)
        'DIBUJO.DrawLine(Pens.LightGray, 0, CSng(PictureBox1.Height / 2), PictureBox1.Width, CSng(PictureBox1.Height / 2))

        'DIBUJO.TranslateTransform(CSng(PictureBox1.Width / 2), CSng(PictureBox1.Height / 2))

    End Sub

    Private Sub btn_Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' ''Try
        ' ''    Dim MyGraphics As System.D  rawing.Graphics
        ' ''    Dim MyPen As New System.Drawing.Pen(Color.Yellow)
        ' ''    MyGraphics = Me.CreateGraphics()
        ' ''    MyGraphics.DrawLine(MyPen, CInt(txt_X1.Text), CInt(txt_Y1.Text), CInt(txt_X2.Text), CInt(txt_Y2.Text)) 'Dibujamos la Linea
        ' ''Catch
        ' ''    Dim oper_ped As New Cls_Pedido()
        ' ''    oper_ped.VisualizaMensaje("", 100)
        ' ''End Try

        'Label1.Text = "INICIO DE SESION"
        'btn_Aceptar.Text = "Siguiente" 
        'btn_Atras.Visible = False
        'var_pass = Nothing
        'var_usr = Nothing
        'Ctl_txt_usuario.Focus()
        'Ctl_txt_usuario.PasswordChar = ""
    End Sub

    Private Sub frm_Inicio_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Ctl_txt_usuario.Focus()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ctl_txt_usuario.Focus()
    End Sub








   
End Class