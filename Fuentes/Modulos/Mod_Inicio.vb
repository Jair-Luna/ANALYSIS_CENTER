'*************************************************************************
' Nombre:   Mod_Inicio
' Tipo de Archivo: Modulo
' Descripcin:  Modulo con todas las funciones y variables P�blicas
' Autores:  rfn, 
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System.IO
Imports System.Globalization
Imports AcroPDFLib
'Imports AxAcroPDFLib

Module Mod_Inicio

#Region " Para saber si una aplicaci�n est� en memoria "
    <System.Runtime.InteropServices.DllImport("user32.dll", _
            EntryPoint:="SetForegroundWindow")> _
    Public Function SetForegroundWindow( _
            ByVal hWnd As IntPtr) As Boolean
    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll", _
            EntryPoint:="FindWindow")> _
    Public Function FindWindow( _
            ByVal lpClassName As String, _
            ByVal lpWindowName As String) As IntPtr
    End Function
    Public ceroIntPtr As New IntPtr(0)
#End Region

    'Variable global de la cadena de conexi�n
    Public g_tiempo As Integer
    Public g_Minuto As Integer
    Public g_MinEspera As Integer
    Public g_str_conexion As String
    Public g_str_conexion_odbc As String
    Public g_sng_user As Single
    Public g_str_login As String
    Public g_str_bd As String
    Public g_opr_usuario As New Cls_Usuario()
    Public g_opr_invitado As New Cls_Invitado()
    Public g_lng_ped_id As Long
    Public g_byt_administrador As Byte
    Public g_str_transaccion As String
    Public g_division As Byte
    Public g_str_idb2 As String
    Public g_ASdatasource As String
    Public g_ASuser As String
    Public g_ASpassword As String
    Public g_ASLibreria As String
    Public g_ASRutina As String
    Public g_ASPrograma As String
    Public g_ASTimeOut As Integer = 30
    Public a_str_conexion As String
    Public g_str_connAS400 As String
    Public invitado As String
    Public CLAVE As String
    Public var_nota As String
    Public g_lng_ped_nunfact As String
    Public g_numOrden As String


    Public g_user_log As String 'LOGIN DE INVITADO CONECTADO
    Public g_invitado As String
    Public g_invitadoID As String
    Public g_invitadoF As String
    Public g_usuarioF As String
    Public g_str_unidad As String
    Public g_unidad As String
    Public g_ciu_id As String
    Public g_ciu_nom As String


    Public g_modocompletar As String = Nothing

    Public g_CadenaFiltro As String = Nothing
    Public g_ConvenioSecuencia As String = Nothing

    'PARA EMITIR ETIQUETAS ADICIONALES Y AUTOMATICAMENTE
    Public g_CBautomatico As Boolean = False
    Public g_CBpedido As Boolean = False
    Public g_CBpaciente As Boolean = False

    'PARA TITULOS
    Public g_Titulo As String

    'PARA GENERAR TIPO DE SECUENCIA DEL TURNO
    Public g_tiposecuencia As String

    'PARA GENERAR CARPETA REMITIDOS EN PDF
    Public g_pathremitidos As String
    Public g_pathremitidosLee As String
    Public g_datos_paciente As String
    Public g_pathFolder As String = Nothing
    Public g_pathFolderImg As String = Nothing
    Public g_pathFolderQR As String = Nothing
    Public g_pathFolderServer As String = Nothing
    Public g_pathFolderReceta As String = Nothing

    'PARA TARABAJAR CON SQL SERVER
    Public g_motorBDD As String
    Public g_str_conexion_SQL As String
    Public g_str_conexion_SQL_PDF As String

    'variable para el emnsaje de EN PROCESO
    Public g_proceso As String
    Public g_orden As String

    ' variable para cadena de areas
    Public g_CadenaAreas As String = Nothing

    'variable que sirve para diferenciar la carga de codigos desde mis 
    Public codigo_temp As String = ""
    'variable para inidcar el # de orden de los test pendientes de importar
    Public orden As String = ""
    Public existe_error As Boolean = False

    ' variable numer ode intentos
    Public g_intentos As Integer = 0

    ' variable modulo WEB
    Public g_SalidaWeb As Boolean = False

    ' variable par asaber si es MEDICINA OCUPACIONAL
    Public g_EsOcupacional As Byte = 0


    Public Sub Main()
        IniciaParametros()
        '********************
        Dim oldDecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If Not oldDecimalSeparator = "." Then
            Dim forceDotCulture As CultureInfo
            forceDotCulture = Application.CurrentCulture.Clone()
            forceDotCulture.NumberFormat.NumberDecimalSeparator = "."
            forceDotCulture.NumberFormat.NumberGroupSeparator = ","
            forceDotCulture.NumberFormat.CurrencyDecimalSeparator = "."
            forceDotCulture.NumberFormat.CurrencyGroupSeparator = ","
            forceDotCulture.DateTimeFormat.DateSeparator = "-"
            forceDotCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
            Application.CurrentCulture = forceDotCulture
        End If
        'Dim frmInicio As New frm_Inicio()
        'frmInicio.ShowDialog()
        ' Se comprueba si la aplicaci�n est� en memoria
        'Dim nWnd As IntPtr
        'Dim nWnd2 As IntPtr

        ''Dim frmInicio As frm_Inicio
        ''Dim frmMain As Frm_Main

        'If nWnd.Equals(ceroIntPtr) Or nWnd2.Equals(ceroIntPtr) Then
        '    ' Si no est�, se carga la actual
        '    'Application.Run(New frm_Inicio())
        Dim frmInicio As New frm_Inicio()
        frmInicio.ShowDialog()
        'Else
        '    ' Si ya est�, se activa
        '    SetForegroundWindow(nWnd)
        '    ' y se sale de la actual
        '    Application.Exit()
        'End If
    End Sub

    Public Sub IniciaParametros()
        '    'Procedimiento que conecta el app.config para la ruta donde se encuentra ubicada la base de datos
        '    Dim str_provider, str_location, str_datasource, str_user, str_password, str_port As String

        '    str_provider = System.Configuration.ConfigurationSettings.AppSettings("Provider")
        '    str_location = System.Configuration.ConfigurationSettings.AppSettings("Location")
        '    str_datasource = System.Configuration.ConfigurationSettings.AppSettings("Datasource")
        '    str_user = System.Configuration.ConfigurationSettings.AppSettings("Userid")

        '    str_port = System.Configuration.ConfigurationSettings.AppSettings("Port")
        '    str_password = System.Configuration.ConfigurationSettings.AppSettings("Password")
        '    g_str_transaccion = System.Configuration.ConfigurationSettings.AppSettings("SourceT")

        '    'instruccion para conectarse con password  a MySQL
        '    g_str_conexion = "Provider=" & str_provider & ";Location=" & str_location & ";Data Source=" & str_datasource & ";User ID=" & str_user & ";Password=" & str_password & ";Port=" & str_port
        '    g_str_conexion_odbc = "Driver={MySQL ODBC 3.51 Driver};Server=" & str_location & ";Port=" & str_port & ";Database=" & str_datasource & ";Uid=" & str_user & ";Pwd=" & str_password

        '    g_ASdatasource = System.Configuration.ConfigurationSettings.AppSettings("g_ASdatasource")
        '    g_ASuser = System.Configuration.ConfigurationSettings.AppSettings("g_ASuser")
        '    g_ASpassword = System.Configuration.ConfigurationSettings.AppSettings("g_ASpassword")
        '    g_ASLibreria = System.Configuration.ConfigurationSettings.AppSettings("g_ASlibreria")
        '    g_ASRutina = System.Configuration.ConfigurationSettings.AppSettings("g_ASRutina")
        '    g_ASPrograma = System.Configuration.ConfigurationSettings.AppSettings("g_ASPrograma")
        '    g_ASTimeOut = System.Configuration.ConfigurationSettings.AppSettings("g_ASTimeOut")
        '    g_str_connAS400 = "Provider=IBMDA400;Data Source=" & g_ASdatasource & " ;Force Translate=1;User ID = " & g_ASuser & " ;Password = " & g_ASpassword & " ;Connect Timeout= " & g_ASTimeOut
        '    g_str_idb2 = "DataSource=" & g_ASdatasource & ";User ID=" & g_ASuser & ";PassWord=" & g_ASpassword & "; Connect Timeout=" & g_ASTimeOut
        '    a_str_conexion = System.Configuration.ConfigurationSettings.AppSettings("a_Conexion")

        g_CBautomatico = System.Configuration.ConfigurationSettings.AppSettings("AUTOMATICO")
        g_CBpedido = System.Configuration.ConfigurationSettings.AppSettings("CBPEDIDO")
        g_CBpaciente = System.Configuration.ConfigurationSettings.AppSettings("CBPACIENTE")
        g_MinEspera = System.Configuration.ConfigurationSettings.AppSettings("MINESPERA")

        g_tiposecuencia = System.Configuration.ConfigurationSettings.AppSettings("TSecuencia")

        g_ciu_id = System.Configuration.ConfigurationSettings.AppSettings("CIU_ID")
        g_ciu_nom = System.Configuration.ConfigurationSettings.AppSettings("CIU_NOM")

        g_SalidaWeb = System.Configuration.ConfigurationSettings.AppSettings("SALIDA")

        g_modocompletar = System.Configuration.ConfigurationSettings.AppSettings("MODO")
        g_intentos = System.Configuration.ConfigurationSettings.AppSettings("INTENTOS")
        g_pathremitidos = System.Configuration.ConfigurationSettings.AppSettings("Remitidos")
        g_pathremitidosLee = System.Configuration.ConfigurationSettings.AppSettings("RemitidosLee")
        g_motorBDD = System.Configuration.ConfigurationSettings.AppSettings("motorBDD")
        g_pathFolder = System.Configuration.ConfigurationSettings.AppSettings("ReportesPDF")
        g_pathFolderImg = System.Configuration.ConfigurationSettings.AppSettings("Histogramas")
        g_pathFolderQR = System.Configuration.ConfigurationSettings.AppSettings("QR")
        g_pathFolderServer = System.Configuration.ConfigurationSettings.AppSettings("ServerPDF")
        g_pathFolderReceta = System.Configuration.ConfigurationSettings.AppSettings("Recetas")
        g_tiempo = System.Configuration.ConfigurationSettings.AppSettings("Delay")
    End Sub

    Sub ClickMenu_Principal(ByVal frmOpera As Windows.Forms.Form)
        Dim Frm_Main As Frm_Main = frmOpera.ParentForm
        'Frm_Main.Limpia_menu()
    End Sub

    Sub RemoveCtxMenu_Principal(ByVal frmOpera As Windows.Forms.Form, ByVal Menufrm As String)
        'Elimina los sub menus del context menu del formulario principal
        Dim Frm_Main As Frm_Main = frmOpera.ParentForm
        Dim int_indice As Integer
        'For int_indice = 0 To Frm_Main.Ctm_menu.MenuItems.Count - 1
        '    If Frm_Main.Ctm_menu.MenuItems.Item(int_indice).Text = Menufrm Then
        '        Frm_Main.Ctm_menu.MenuItems.RemoveAt(int_indice)
        '        Exit For
        '    End If
        'Next
    End Sub

End Module
