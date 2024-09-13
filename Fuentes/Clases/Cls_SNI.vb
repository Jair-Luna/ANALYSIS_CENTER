'*************************************************************************
' Nombre:   Cls_SNI
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de la obtencion y envio de los 
'               datos de los equipos SNI o interfaces para cada equipo
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Option Strict Off
Option Explicit On 

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports AnalisysLAB.Cls_WinInet
Imports VB = Microsoft.VisualBasic

Public Class Cls_SNI
    Private int_hConnection, int_hopen As Integer
    Private EnumItemName As New Collection()
    Private EnumItemAttribute As New Collection()
    Private str_ip2, str_path_local2 As String

    Dim opr_archivo As New Cls_Archivos()

#Region "Varias Funciones"

    Sub LlenarListaEquipo(ByRef chkl_equipo As CheckedListBox)
        'funcion que llena en un lista los equipos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand("Select equ_modelo, sni.sni_nombre, sni_ip, sni_login, sni_pswd, sni_path_local, sni_path_remoto from equipo, sni where equipo.sni_nombre <> ''  and equipo.sni_nombre=sni.sni_nombre", opr_Conexion.conn_sql).ExecuteReader
        chkl_equipo.Items.Clear()
        While odr_operacion.Read
            chkl_equipo.Items.Add(odr_operacion.GetString(0).PadRight(150) & odr_operacion.GetString(1).PadRight(20) & odr_operacion.GetString(2).PadRight(20) & odr_operacion.GetString(3).PadRight(50) & odr_operacion.GetString(4).PadRight(50) & odr_operacion.GetString(5).PadRight(150) & odr_operacion.GetString(6).PadRight(150), False)
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        chkl_equipo.SelectedIndex = 0
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Usuario Equipo para leer datos SNI", Err)
        Err.Clear()
    End Sub

    Sub CrearDirectorio(ByVal str_path_local As String)
        'Verificar si existe la direcci�n
        If str_path_local.EndsWith("\") Then str_path_local = str_path_local.Substring(0, Len(str_path_local) - 1)
        If Dir(str_path_local, FileAttribute.Directory) = "" Then MkDir(str_path_local)
    End Sub

    Function MaxNumeroArchivoFolder(ByVal str_dir As String, ByVal ext As String) As Integer
        On Error Resume Next
        Dim int_nummax, int_num, int_cont As Short
        Dim fi As FileInfo
        Dim ri As New DirectoryInfo(str_dir)
        MaxNumeroArchivoFolder = 0
        int_nummax = 0
        int_num = 0
        ri.Refresh()
        fi.Refresh()
        For Each fi In ri.GetFiles(ext)
            Select Case ext
                Case "*.cdf", "*.qct", "*.clb", "*.dnl"
                    int_num = Replace(fi.Name, fi.Extension, "")
                Case "*H.cdf"
                    int_num = Replace(fi.Name, "H.cdf", "")
            End Select
            If int_num > int_nummax Then int_nummax = int_num
        Next
        MaxNumeroArchivoFolder = int_nummax + 1
    End Function

    Function MaxNumeroArchivoFTP(ByVal str_dir As String, ByVal ext As String) As Integer
        On Error Resume Next
        'para que esta funci�n se ejecute debe, estar activa la conexi�n ftp
        Dim hFind As Integer
        Dim pData As WIN32_FIND_DATA
        Dim bRet As Boolean
        Dim int_nummax, int_num As Short
        MaxNumeroArchivoFTP = 0
        int_nummax = 0
        int_num = 0
        If Len(str_dir) > 0 Then RCD((str_dir))
        pData.cFileName = New String("0", MAX_PATH)
        hFind = FtpFindFirstFile(int_hConnection, ext, pData, 0, 0)
        If hFind <> 0 Then
            int_num = Replace(pData.cFileName, Replace(ext, "*", ""), "")
            If int_num > int_nummax Then int_nummax = int_num
            Do
                pData.cFileName = New String(Chr(0), MAX_PATH)
                bRet = InternetFindNextFile(hFind, pData)
                If bRet Then
                    int_num = Replace(pData.cFileName, Replace(ext, "*", ""), "")
                    If int_num > int_nummax Then int_nummax = int_num
                ElseIf Err.LastDllError = ERROR_NO_MORE_FILES Then
                    Exit Do
                End If
            Loop
        End If
        MaxNumeroArchivoFTP = int_nummax + 1
    End Function

    Sub LlenarListaEquipodisponible(ByRef chkl_trabajo As CheckedListBox, ByVal fecha As Date)
        'JVA 19-04-2004
        'funcion que llena en un lista los equipos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand("Select equ_modelo, sni.sni_nombre, sni_ip, sni_login, sni_pswd from equipo, sni, lista_trabajo where lista_trabajo.equ_id=equipo.equ_id  and equipo.sni_nombre=sni.sni_nombre  and lista_trabajo.lis_fecing= '" & Format(fecha, "dd/MM/yyyy") & "' and lista_trabajo.lis_resestado=0 and equipo.equ_formato <> '' and equipo.equ_modelo = 'Cell Dyn 3700' group by equ_modelo", opr_conexion.conn_sql).ExecuteReader
        chkl_trabajo.Items.Clear()
        While odr_operacion.Read
            chkl_trabajo.Items.Add(odr_operacion.GetString(0).PadRight(150) & odr_operacion.GetString(1).PadRight(20) & odr_operacion.GetString(2).PadRight(20) & odr_operacion.GetString(3).PadRight(50) & odr_operacion.GetString(4).PadRight(50), False)
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar equipo enviar SNI", Err)
        Err.Clear()
    End Sub

#End Region

#Region "Enviar FTP"

    'Funci�n creada por XBR (2)
    Public Sub Cambia_Estado(ByVal nombre As String, ByVal str_fecing As Date)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "update lista_trabajo , equipo set lis_resestado = 0 where lis_resestado = 3 and equipo.equ_id=lista_trabajo.equ_id and lis_fecing = '" & Format(str_fecing, "dd/MM/yyyy") & " 00:00:00' and equ_modelo= '" & nombre & "'"
        If MsgBox("Est� seguro que desea cambiar el ESTADO para Reenv�o?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "ANALISYS") = MsgBoxResult.Yes Then
            opr_conexion.sql_conectar()
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            opr_conexion.sql_desconn()
            MsgBox("Los datos han sido modificados. Favor actualice la lista de trabajo.", MsgBoxStyle.Information, "ANALISYS")
            'Se registra de la transaccion realizada
            g_opr_usuario.CargarTransaccion(g_str_login, "ACTUALIZA Estado", "Estado actualizado para reenvio", g_sng_user, "", "", "")
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, GuardarArea", Err)
        Err.Clear()
    End Sub

    Public Function EnviarSNI(ByVal nombre As String, ByVal str_fecing As Date) As String
        'funcion que envia los arhivos a los diferntes equipos para ser procesados
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL, str_ftp As String
        Dim str_locales(0) As String
        Dim arr_ftp(0) As String
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        opr_conexion.sql_conectar()
        '0  PEDIDO.PED_ID               1   PEDIDO.PED_TIPO, 
        '2  LISTA_TRABAJO.LIS_ID        3   LISTA_TRABAJO.LIS_POSNUM
        '4  LISTA_TRABAJO.PER_ID        5   LISTA_TRABAJO.LIS_EQUTIMID
        '6  LISTA_TRABAJO.TIM_ID        7   LISTA_TRABAJO.TES_ID
        '8  EQUIPO.EQU_FORMATO          9   EQUIPO.EQU_MODELO
        '10  EQUIPO.EQU_ID              11  SNI.SNI_NOMBRE
        '12 SNI.SNI_PATH_ENVIA          13  SNI.SNI_IP
        '14 SNI.SNI_LOGIN               15  SNI.SNI_PSWD
        '16 SNI.SNI_PATH_CARGA          17  PACIENTE nombre unido

        'JVA 07-ENE-04 A�ADO PED_TURNO Y UN ORDER BY
        '19-04-2004 a�ado al final la validacion: "and equipo.equ_modelo = '" & Trim(nombre) & "'"
        STR_SQL = "select pedido.PED_ID as PED_ID, pedido.PED_TIPO as PED_TIPO, lista_trabajo.LIS_ID as LIS_ID, " & _
        "lista_trabajo.LIS_POSNUM as LIS_POSNUM, lista_trabajo.PER_ID as PER_ID, lista_trabajo.LIS_EQUTIMID as LIS_EQUTIMID, " & _
        "lista_trabajo.TIM_ID as TIM_ID, lista_trabajo.TES_ID as TES_ID, equipo.EQU_FORMATO as EQU_FORMATO, equipo.EQU_MODELO as EQU_MODELO, " & _
        "equipo.EQU_ID as EQU_ID, sni.SNI_NOMBRE as SNI_NOMBRE, sni.SNI_PATH_ENVIA as SNI_PATH_ENVIA, sni.SNI_IP as SNI_IP, " & _
        "sni.SNI_LOGIN as SNI_LOGIN, sni.SNI_PSWD as SNI_PSWD, sni.SNI_PATH_CARGA as SNI_PATH_CARGA, " & _
        "concat(paciente.pac_apellido, ' ', paciente.pac_nombre) as Nombres, pedido.PED_TURNO as PED_TURNO, paciente.pac_sexo as SEXO, " & _
        "paciente.pac_fecnac AS FECNAC, paciente.pac_usafecnac AS USAFECNAC " & _
        "from pedido, equipo, lista_trabajo, sni, paciente " & _
        "where pedido.ped_id=lista_trabajo.ped_id and lista_trabajo.equ_id=equipo.equ_id and equipo.sni_nombre=sni.sni_nombre " & _
        "and lis_fecing='" & Format(str_fecing, "dd/MM/yyyy") & "' and lis_resestado=0 and pedido.pac_id = paciente.pac_id and equipo.equ_modelo = '" & Trim(nombre) & "' ORDER BY PED_TURNO"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        opr_conexion.sql_desconn()
        Dim dtr_fila As DataRow
        Dim sng_i As Single
        Dim str_cadena, str_aux, str_pathaux, str_login, str_pswd, str_ip, str_path_remoto, str_path, str_formato, str_sniNombre As String
        Dim str_elemento() As String
        str_aux = ""

        str_locales(0) = ""
        Dim opr_archivo As New Cls_Archivos()
        Dim opr_trabajo As New Cls_Trabajo()
        For Each dtr_fila In dts_operacion.Tables("Registros").Rows
            str_cadena = ""
            If dtr_fila("EQU_FORMATO").ToString() <> "" Then
                str_sniNombre = dtr_fila("SNI_NOMBRE").ToString() 'Almaceno el nombre del dispositivo de interfaceamiento (SNI o COM)
                str_path = dtr_fila("SNI_PATH_ENVIA").ToString()  'Almaceno la direcci�n donde se almacenaran localmente el archivo
                opr_archivo.CompruebaPath(str_path)
                'str_path = Environment.CurrentDirectory & str_path
                str_formato = dtr_fila("EQU_FORMATO").ToString()  'Almaceno el formato de la cadena que necesita el equipo para entender una orden
                str_elemento = Split(str_formato, ",")
                str_ip = dtr_fila("SNI_IP").ToString()
                str_login = dtr_fila("SNI_LOGIN").ToString()
                str_pswd = dtr_fila("SNI_PSWD").ToString()
                str_path_remoto = dtr_fila("SNI_PATH_CARGA").ToString()
                str_ftp = str_path & "," & str_ip & "," & str_path_remoto & "," & str_login & "," & str_pswd & "," & str_sniNombre
                Select Case dtr_fila("EQU_MODELO")
                    Case "Dimension AR", "Dimension XL", "Dimension RXL"
                        str_cadena = opr_archivo.DNLDimensionAR(dtr_fila)
                    Case "Immulite"
                        str_cadena = ""
                    Case "Immulite 2000"
                        str_cadena = ""
                    Case "Cell Dyn 3500", "Cell Dyn 3700"
                        str_cadena = opr_archivo.DNLCellDyn3500(dtr_fila)
                    Case "Elecsys1010"
                        str_cadena = opr_archivo.DNLElecsys1010(dtr_fila)
                    Case "Elecsys2010"
                        str_cadena = opr_archivo.DNLElecsys2010(dtr_fila)

                End Select
                'Actualizo el estado del pedido para ponerlo como ya enviado 
                opr_trabajo.CambioEstadoItemLista(CInt(dtr_fila("LIS_ID").ToString), 3)
            End If
            Dim arr_datosAnt(), arr_datos() As String
            Dim s As Short = 0
            arr_datosAnt = Split(str_aux, ",")
            If UBound(arr_datosAnt) <> 0 Then
                arr_datos = Split(str_cadena, ",")
                If (arr_datos(0) <> "") Then
                    'Comparo las cadenas siempre y cuando correspondan al mismo formato
                    s = UBound(arr_datosAnt)

                    If arr_datos(0) = "Cell Dyn 3700" Then
                        If (arr_datos(0) = arr_datosAnt(0) And arr_datos(1) = arr_datosAnt(1)) And (Trim(arr_datos(1)) <> "ASPIRANTE" And Trim(arr_datosAnt(1)) <> "ASPIRANTE" And Trim(arr_datos(1)) <> "ASCENSO" And Trim(arr_datosAnt(1)) <> "ASCENSO") Then
                            'El mismo pedido en el mismo equipo Celldyn (Agrego el test una sola cadena)
                            's = Len(str_aux)
                            'str_aux = Mid(str_aux, 1, s - 2)
                            str_aux = str_aux & "," & arr_datos(6) '& "," '& arr_datos(7)
                            str_aux = str_aux.Replace("@", "2")
                        Else
                            'CrearDirectorio(str_pathaux)
                            opr_archivo.CompruebaPath(str_pathaux)
                            If (str_aux <> "") Then
                                If Mid(str_sniNombre, 1, 1) = "F" Then
                                    Call cadenaDirectorios(str_locales, str_pathaux, str_ftp)
                                End If
                                Dim str_numFile As String = CStr(MaxNumeroArchivoFolder(Environment.CurrentDirectory & str_pathaux, "*.dnl"))
                                If CInt(str_numFile) > 0 And CInt(str_numFile) < 10 Then
                                    str_numFile = "0" & Trim(str_numFile)
                                End If
                                str_pathaux = str_pathaux & str_numFile & ".dnl"
                                FileOpen(1, Environment.CurrentDirectory & str_pathaux, OpenMode.Append)
                                str_aux = str_aux.Replace("@", "1")
                                PrintLine(1, str_aux)
                                FileClose(1)
                                str_aux = ""
                                str_pathaux = str_path

                            End If
                            str_aux = str_cadena
                            str_cadena = ""
                            str_pathaux = str_path
                        End If
                    End If

                Else
                    If arr_datos(0) = arr_datosAnt(0) And arr_datos(2) = arr_datosAnt(2) And arr_datos(3) = arr_datosAnt(3) And arr_datosAnt(s) = arr_datos(7) Then
                        'El mismo pedido en el mismo equipo (Agrego el test una sola cadena)
                        s = Len(str_aux)
                        str_aux = Mid(str_aux, 1, s - 2)
                        str_aux = str_aux & "," & arr_datos(6) & "," & arr_datos(7)
                    Else
                        'CrearDirectorio(str_pathaux)
                        opr_archivo.CompruebaPath(str_pathaux)
                        If (str_aux <> "") Then
                            If Mid(str_sniNombre, 1, 1) = "F" Then
                                Call cadenaDirectorios(str_locales, str_pathaux, str_ftp)
                            End If
                            Dim str_numFile As String = CStr(MaxNumeroArchivoFolder(Environment.CurrentDirectory & str_pathaux, "*.dnl"))
                            If CInt(str_numFile) > 0 And CInt(str_numFile) < 10 Then
                                str_numFile = "0" & Trim(str_numFile)
                            End If
                            str_pathaux = str_pathaux & str_numFile & ".dnl"
                            FileOpen(1, Environment.CurrentDirectory & str_pathaux, OpenMode.Append)
                            PrintLine(1, str_aux)
                            FileClose(1)
                            str_aux = ""
                            str_pathaux = str_path
                        End If
                        str_aux = str_cadena
                        str_cadena = ""
                        str_pathaux = str_path
                    End If
                End If
                'str_aux = str_cadena
                'str_cadena = ""
                'str_pathaux = str_path
            Else
                str_aux = str_cadena
                str_cadena = ""
                str_pathaux = str_path
            End If
        Next
        'CrearDirectorio(str_path)
        opr_archivo.CompruebaPath(str_pathaux)
        Call cadenaDirectorios(str_locales, str_pathaux, str_ftp)
        '***********
        'Cambio para que en el directorio remoto tambien me grabe el archivo como 01.dnl en caso de ser mayor entre 1 a 9 .dnl
        Dim str_numFile2 As String = CStr(MaxNumeroArchivoFolder(Environment.CurrentDirectory & str_path, "*.dnl"))
        If CInt(str_numFile2) > 0 And CInt(str_numFile2) < 10 Then
            str_numFile2 = "0" & Trim(str_numFile2)
        End If
        str_path = str_path & str_numFile2 & ".dnl"

        '***********
        'str_path = str_path &  & ".dnl"
        FileOpen(1, Environment.CurrentDirectory & str_path, OpenMode.Append)
        str_aux = str_aux.Replace("@", "1")
        PrintLine(1, str_aux)
        FileClose(1)
        str_aux = ""

        'El arreglo que contiene los directorios en los que se creo CDFs es str_locales
        'se procede a guardar los dnl en la direcci�n ftp o carpeta remota        
        Dim str_equipofalla As String = ""
        Dim sht_contador As Short
        Dim datos() As String
        For sht_contador = 0 To UBound(str_locales)
            'xxx pendiente como se hace cuando son carpetas compartidas
            datos = Split(str_locales(sht_contador), ",")
            If (Mid(datos(5), 1, 1) = "F") Then 'Comunicaci�n FOLDER (VIA RED)
                If leer_enviar_Folder(datos(2), datos(0), "*.dnl") = 0 Then str_equipofalla = str_equipofalla & datos(1) & ", "
            Else   'Comunicaci�n con FTP
                'If LeerFTP(str_ip, str_login, str_pswd, str_locales(sht_contador), str_path_remoto, 1) = 0 Then str_equipofalla = str_equipofalla & str_ip & ", "
                If LeerFTP(datos(1), datos(3), datos(4), datos(0), datos(2), 1) = 0 Then str_equipofalla = str_equipofalla & datos(1) & ", "
            End If
        Next
        If Trim(str_equipofalla) <> "" Then
            str_equipofalla = str_equipofalla.Substring(0, Len(str_equipofalla) - 2)
            MsgBox("No se concluy� la operacion enviar datos a los analizadores/interfaces" & Chr(13) & str_equipofalla, MsgBoxStyle.Exclamation, "ANALISYS")
        End If
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Enviar Datos " & Err.Description, Err)
        EnviarSNI = "Error: No se Puedo Enviar los Datos a ningun Analizador de la Lista de Trabajo del D�a"
        Err.Clear()
    End Function

    Public Function cadenaDirectorios(ByVal datos() As String, ByVal path As String, ByVal str_ftp As String) As String()
        Dim x, i As Integer
        Dim y() As String
        Dim existe As Boolean = False
        x = UBound(datos)
        For i = 0 To UBound(datos)
            y = Split(datos(i), ",")
            If y(0) = path Then
                existe = True
                Exit For
            End If
        Next
        If existe = False Then
            If datos(x) = "" Then
                'datos(x) = path
                datos(x) = str_ftp
            Else
                ReDim Preserve datos(x + 1)
                datos(x + 1) = path & "," & str_ftp
            End If
        End If
    End Function

#End Region

#Region "Conectar FTP"

    Public Function LeerFTP(ByVal str_ip As String, ByVal str_login As String, ByVal str_pswd As String, ByVal str_path_local As String, ByVal str_path_remoto As String, Optional ByVal byt_opera As Byte = 0, Optional ByVal extension As String = ".dnl") As Byte
        'funcion que lee y obtiene uno por uno los datos de los diferentes equipos
        On Error GoTo MsgError
        opr_archivo.CompruebaPath(str_path_local)
        int_hopen = InternetOpen(scUserAgent, INTERNET_OPEN_TYPE_DIRECT, vbNullString, vbNullString, 0)
        LeerFTP = 0
        If int_hopen <> 0 Then
            If int_hConnection <> 0 Then InternetCloseHandle(int_hConnection)
            str_ip2 = str_ip
            str_path_local2 = Environment.CurrentDirectory & str_path_local
            int_hConnection = InternetConnect(int_hopen, str_ip2, INTERNET_INVALID_PORT_NUMBER, str_login, str_pswd, INTERNET_SERVICE_FTP, INTERNET_FLAG_PASSIVE, 0)
            If int_hConnection <> 0 Then
                Select Case byt_opera
                    Case 0
                        'con la conexi�n activa recolecta los datos
                        'Verifica la existencia de archivos de: 
                        'Datos *.cfd, Control de calidad *.qct, calibraciones *.clb
                        LeerFTP = 0
                        If FtpEnumDirectory(str_path_remoto, "cdf") Then
                            LeerFTP = 1
                        Else
                            LeerFTP = 0
                        End If
                        If FtpEnumDirectory(str_path_remoto, "qct") Then
                            LeerFTP = 1
                        Else
                            LeerFTP = 2
                        End If
                        If FtpEnumDirectory(str_path_remoto, "clb") Then
                            LeerFTP = 1
                        Else
                            LeerFTP = 3
                        End If
                        If int_hConnection <> 0 Then InternetCloseHandle(int_hConnection)
                        If int_hopen <> 0 Then InternetCloseHandle(int_hopen)
                    Case 1
                        Dim fi As FileInfo
                        Dim ri As DirectoryInfo
                        Dim Flags, int_numarch As Integer
                        Flags = FTP_TRANSFER_TYPE_ASCII
                        'lectura de los archivos cdf
                        ri = New DirectoryInfo(Environment.CurrentDirectory & str_path_local)
                        'lee el m�ximo n�mero de archivos cdf
                        int_numarch = MaxNumeroArchivoFTP(str_path_remoto, "*" & extension)
                        Dim xx As String = 0  'Variable en la que almaceno el numero de archivo pero este puede ser 01,02,03,04
                        For Each fi In ri.GetFiles("*" & extension)
                            If int_numarch > 0 And int_numarch < 10 Then
                                xx = "0" & CStr(int_numarch)
                            Else
                                xx = CStr(int_numarch)
                            End If
                            If FtpPutFile(int_hConnection, Environment.CurrentDirectory & str_path_local & fi.Name, str_path_remoto & xx & extension, Flags, 0) Then
                                File.Delete(Environment.CurrentDirectory & str_path_local & fi.Name)
                            End If
                            int_numarch = int_numarch + 1
                        Next
                        ri = Nothing
                        If int_hConnection <> 0 Then InternetCloseHandle(int_hConnection)
                        If int_hopen <> 0 Then InternetCloseHandle(int_hopen)
                        LeerFTP = 1
                End Select
            Else
                'Cuando no se ha podido establecer una coneccion
                falloConexion(str_path_local2)
            End If
        End If
        Exit Function
MsgError:
        LeerFTP = 0
        Err.Clear()
    End Function

    Public Sub falloConexion(ByVal str_dir_local As String)
        'Public Sub InterpretarDatos() '(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ResBD.Click
        '******JPO    09 Julio 2003
        Dim x, y, h As Array
        Dim i, j As Short
        Dim ruta As String = ""
        Dim dir_dnl() As String
        Dim aux As Short = 0
        ruta = Dir(str_dir_local, FileAttribute.Directory)
        If ruta <> "" Then
            h = Directory.GetFiles(str_dir_local, "*.dnl")
            If (UBound(h) <> -1) Then
                For i = 0 To UBound(h)
                    'PROCESO EN EL QUE LEO EL ARCHIVO DNL PARA PONER A SUS TEST COMO NO ENVIADOS
                    'opr_archivo.LeerDNLNoEnviado(h(i))
                    'UNA VEZ ALMACENADOS CAMBIADOS EL ESTADO EN LA LISTA DE TRABAJO LOS ELIMINO
                    'File.Delete(h(i))
                Next
            End If
        End If
    End Sub



#End Region

#Region "Recibir FTP"

    Public Function FtpEnumDirectory(ByRef strDirectory As String, ByVal ext As String) As Byte
        'funcion que obtiene los archivos de un equipos
        On Error GoTo MsgError
        Dim hFind As Integer
        Dim pData As WIN32_FIND_DATA
        Dim Flags As Integer
        Dim bRet As Boolean
        Dim strItemName As String

        ClearCollections()

        If Len(strDirectory) > 0 Then RCD((strDirectory))
        pData.cFileName = New String("0", MAX_PATH)
        hFind = FtpFindFirstFile(int_hConnection, "*." & ext, pData, 0, 0)
        If hFind = 0 Then
            FtpEnumDirectory = 1
            Exit Function
        End If

        EnumItemAttribute.Add(pData.dwFileAttributes)
        strItemName = pData.cFileName
        EnumItemName.Add(strItemName)
        Do
            pData.cFileName = New String(Chr(0), MAX_PATH)
            bRet = InternetFindNextFile(hFind, pData)
            If bRet Then
                EnumItemAttribute.Add(pData.dwFileAttributes)
                strItemName = pData.cFileName
                EnumItemName.Add(strItemName)
            ElseIf Err.LastDllError = ERROR_NO_MORE_FILES Then
                Exit Do
            End If
        Loop

        CrearDirectorio(str_path_local2)

        Flags = FTP_TRANSFER_TYPE_ASCII
        Dim int_i As Short
        Dim str_numext As String
        For int_i = 1 To EnumItemName.Count()
            'controla que el archivo es o no de tipo histograma
            'se extrae el cdf, qct, clb con mayor n�mero y se asigna al nuevo archivo
            If EnumItemName.Item(int_i).ToString.EndsWith("H." & ext) Then
                str_numext = str_path_local2 & MaxNumeroArchivoFolder(str_path_local2, "*H." & ext) & "H." & ext
            Else
                str_numext = str_path_local2 & MaxNumeroArchivoFolder(str_path_local2, "*." & ext) & "." & ext
            End If
            'se copia los cdf, qct, clb en la direcci�n local seleccionada, procede si no existe error en la extracci�n de los archivos
            If FtpGetFile(int_hConnection, strDirectory & EnumItemName.Item(int_i), str_numext, False, INTERNET_FLAG_RELOAD, Flags, 0) Then
                'se borra los cdf, qct, clb en la direcci�n ftp o remota seleccionada
                If Not FtpDeleteFile(int_hConnection, strDirectory & EnumItemName.Item(int_i)) Then
                    'indica que existe error el momento de borrar los datos
                End If
            Else
                'indica que existe error el momento de extraer los datos
            End If
        Next
        InternetCloseHandle(hFind)
        FtpEnumDirectory = 1
        Exit Function
MsgError:
        FtpEnumDirectory = 0
        Err.Clear()
    End Function

    Public Sub ClearCollections()
        'funcion que limpia las colecciones de datos
        Dim Num As Short
        For Num = 1 To EnumItemName.Count()
            EnumItemName.Remove(1)
        Next Num
        For Num = 1 To EnumItemAttribute.Count()
            EnumItemAttribute.Remove(1)
        Next Num
    End Sub

    Public Sub RCD(ByRef pszDir As String)
        Dim sPathFromRoot As String
        Dim bRet As Boolean
        If InStr(1, pszDir, str_ip2) Then
            sPathFromRoot = Mid(pszDir, Len(str_ip2) + 1, Len(pszDir) - Len(str_ip2))
        Else
            sPathFromRoot = pszDir
        End If
        If sPathFromRoot = "" Then sPathFromRoot = "/"
        bRet = FtpSetCurrentDirectory(int_hConnection, sPathFromRoot)
    End Sub
#End Region

#Region "Operaciones con Folder"

    Public Function leer_enviar_Folder(ByVal str_path_destino As String, ByVal str_path_origen As String, ByVal ext As String) As Byte
        'c�digo v�lido cuando es windows 98 o 95, y la carpeta es compartida y 
        'no tiene clave pero es oculta (con el signo $ al final del path)
        On Error GoTo AVISO
        opr_archivo.CompruebaPath(str_path_origen)
        Dim fi As FileInfo
        Dim ri As DirectoryInfo
        'lectura de los archivos cdf
        ri = New DirectoryInfo(Environment.CurrentDirectory & str_path_origen)
        For Each fi In ri.GetFiles(ext)
            If Dir(str_path_destino & fi.Name, FileAttribute.Archive) = "" Then
                'controla que el directorio no existe
                fi.MoveTo(str_path_destino & fi.Name)
            Else
                'si existe el archivo, entonces lo graba con el n�mero mayor disponible
                fi.MoveTo(str_path_destino & MaxNumeroArchivoFolder(str_path_destino, ext) & Replace(ext, "*", ""))
            End If
        Next
        ri = Nothing
        leer_enviar_Folder = 1
        Exit Function
AVISO:
        g_opr_usuario.MensajeBoxError("No se pudo recuperar los datos, " & Err.Description, Err)
        Err.Clear()
msgerr:
        leer_enviar_Folder = 0
        Err.Clear()
    End Function

    Public Function leer_traer_Folder(ByVal str_path_destino As String, ByVal str_path_origen As String, ByVal ext As String) As Byte
        'c�digo v�lido cuando es windows 98 o 95, y la carpeta es compartida y 
        'no tiene clave pero es oculta (con el signo $ al final del path)
        On Error GoTo AVISO
        opr_archivo.CompruebaPath(str_path_destino)
        Dim fi As FileInfo
        Dim ri As DirectoryInfo
        'lectura de los archivos cdf
        ri = New DirectoryInfo(str_path_origen)
        For Each fi In ri.GetFiles(ext)
            If Dir(str_path_destino & fi.Name, FileAttribute.Archive) = "" Then
                'controla que el directorio no existe
                fi.MoveTo(Environment.CurrentDirectory & str_path_destino & fi.Name)
            Else
                'si existe el archivo, entonces lo graba con el n�mero mayor disponible
                fi.MoveTo(Environment.CurrentDirectory & str_path_destino & MaxNumeroArchivoFolder(str_path_destino, ext) & Replace(ext, "*", ""))
            End If
        Next
        ri = Nothing
        leer_traer_Folder = 1
        Exit Function
AVISO:
        g_opr_usuario.MensajeBoxError("No se pudo recuperar los datos, " & Err.Description, Err)
        Err.Clear()
msgerr:
        leer_traer_Folder = 0
        Err.Clear()
    End Function

#End Region

End Class