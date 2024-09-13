'*************************************************************************
' Nombre:   Cls_Usuario
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de los Usuarios
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data
Imports System.IO
Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient
Imports Scripting

Public Class Cls_Usuario

    Public Function DevuelveSerialDRIVE() As String

        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            Try
                Dim fso As Scripting.FileSystemObject
                Dim oDrive As Drive
                fso = CreateObject("Scripting.FileSystemObject")
                oDrive = fso.GetDrive(drive.Name)
                DevuelveSerialDRIVE = DevuelveSerialDRIVE & drive.Name & " " & oDrive.SerialNumber & "º"
            Catch ex As Exception

            End Try
        Next
    End Function


    Public Function LeeKey() As String
        'Funcion para la consultar el codigo maximo de la tabla USUARIO   
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        LeeKey = New SqlCommand("select Cod_licencia from codigo where cod_id = 1;", cls_operacion.conn_sql).ExecuteScalar
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer codigo key", Err)
        Err.Clear()
    End Function

    Public Function LeeKeyOcupacional() As String
        'Funcion para la consultar el codigo maximo de la tabla USUARIO   
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        LeeKeyOcupacional = New SqlCommand("select Cod_licencia from codigo where cod_id = 2;", cls_operacion.conn_sql).ExecuteScalar
        If LeeKeyOcupacional Is Nothing Then
            LeeKeyOcupacional = "NO"
        End If
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer codigo key Ocupacional", Err)
        Err.Clear()
    End Function


    Public Function LeerValidador(ByVal ped_id As String) As String
        'Funcion para la consultar el c�digo m�ximo de la tabla USUARIO   
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerValidador = New SqlCommand("Select isnull(lis_user,'') from lista_trabajo where ped_id = '" & ped_id & "' ;", cls_operacion.conn_sql).ExecuteScalar
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, busca Usuario", Err)
        Err.Clear()
    End Function


    Public Function DevuelveCodigo() As String
        'Funcion para la consultar el c�digo m�ximo de la tabla USUARIO   
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        DevuelveCodigo = New SqlCommand("Select cod_num from codigo where cod_id = 1;", cls_operacion.conn_sql).ExecuteScalar
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, busca Usuario", Err)
        Err.Clear()
    End Function


    Public Function BuscarCargo() As Integer
        'Procedimiento para verificar si el usuario es ADMINISTRADOR o no
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        BuscarCargo = CInt(New SqlCommand("Select usu_administrador from usuario where usu_id= '" & g_sng_user & "'", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Verificar usuario con privilegios de Administrador", Err)
        Err.Clear()
    End Function


    Public Function LeerUsuario(ByVal usu As String, ByRef msg As String) As Byte
        'Procedimiento para la consultar el usuario que coincida con un login y password recibidos por la funcion 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing
        msg = Nothing
        opr_conexion.sql_conectar()
        LeerUsuario = 0
        str_sql = "Select USUARIO.invitado_id, usu_login, invitado_conectar, invitado_administrador from INVITADO, USUARIO where usuario.invitado_id = invitado.invitado_id and usuario.USU_LOGIN  = @usu "

        Dim odr_operacion As SqlDataReader ' = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        Dim cmd As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        'cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@usu", SqlDbType.VarChar, 32).Value = usu

        'odr_operacion.Parameters.Add("@usu", SqlDbType.VarChar, 32).Value = usu

        Dim count As Byte = 0
        odr_operacion = cmd.ExecuteReader()

        While odr_operacion.Read
            '*** Se asigna el login del usuario en una variable global y los signos auditables
            count = count + 1   'Variable para saber a que divisi�n pertenece el usuario
            Dim int_conectado As Integer
            g_sng_user = CSng(odr_operacion.GetValue(0))
            g_str_login = odr_operacion.GetString(1)
            int_conectado = odr_operacion.GetValue(2)
            g_byt_administrador = odr_operacion.GetValue(3)

            If int_conectado = 0 Then
                If g_byt_administrador = 0 Then
                    g_opr_usuario.CambiarConectado(g_sng_user, 1)
                End If
                'carga la transacion realizada por el usario al archivo .log
                g_opr_usuario.CargarTransaccion(g_str_login, "Ingreso USUARIO", "Busca tabla invitado", g_sng_user, "", "")
                LeerUsuario = 1
            Else
                If g_byt_administrador = 1 Then
                    LeerUsuario = 1
                Else
                    'si el usario estubiese conectado desde otro estacion
                    MsgBox("Su sesion se encuentra abierta, desde otra estacion", MsgBoxStyle.Exclamation, "ANALISYS")
                    LeerUsuario = 0
                End If
            End If
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        If g_sng_user = 0 Then
            msg = "Usuario no valido, verifique por favor!"
        End If


        Exit Function
MsgError:
        LeerUsuario = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Usuario Para accesos al sistema", Err)
        Err.Clear()
    End Function

    Public Sub CambiarConectado(ByVal usu_id As Single, ByVal usu_conectado As Byte)
        'Procedimiento para actualizar el campo usu_conectado en usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_usuario As SqlCommand
        opr_conexion.sql_conectar()
        odc_usuario = New SqlCommand("update USUARIO set usu_conectado=" & usu_conectado & " where usu_id = " & usu_id, opr_conexion.conn_sql)
        odc_usuario.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Cambiar Conectado Usuario", Err)
        Err.Clear()
    End Sub

    Public Function LeerUsuario2() As DataSet
        'funcion que devuelve en un dataset los datos de los usuarios
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_usuario As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_usuario.SelectCommand = New SqlCommand("Select * from USUARIO ", opr_conexion.conn_sql)
        LeerUsuario2 = New DataSet()
        oda_usuario.Fill(LeerUsuario2, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Usuarios", Err)
        Err.Clear()
    End Function

    Public Function controlaFechaVenc() As Integer
        'CONVERT(varchar(10),usu_fecVence, 102)<CONVERT(varchar(10),GETDATE(), 102)
        'funcion que retorna en un dataset las areas a las que pertenece un usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_Control As SqlDataReader = New SqlCommand("SELECT DATEDIFF(day, GETDATE(), Cod_fecVence) from codigo ;", opr_conexion.conn_sql).ExecuteReader
        While odr_Control.Read
            controlaFechaVenc = odr_Control.GetValue(0)
        End While
        odr_Control.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAreasUsuario", Err)
        Err.Clear()


    End Function


    Public Function detectallave() As Boolean
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        detectallave = False
        cls_operacion.sql_conectar()
        If CShort(New SqlCommand("Select count(Cod_num) from CODIGO where Cod_id=1 and Cod_num <> '';", cls_operacion.conn_sql).ExecuteScalar) >= 1 Then
            detectallave = True
        Else
            detectallave = False
        End If
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Comprobar login", Err)
        Err.Clear()
    End Function

    Sub LlenarGridUsuario(ByRef dgrd_usuario As DataGrid)
        'funcion que llena un datagrid con los datos de los usuarios
        On Error Resume Next
        Dim dts_usuario As DataSet
        Dim dtv_usuario As New DataView()
        dts_usuario = LeerUsuario2()
        With dtv_usuario
            .Table = dts_usuario.Tables("Registros")
            .Sort = "usu_apellido"
        End With
        dgrd_usuario.DataSource = dtv_usuario
        dgrd_usuario.NavigateTo(0, "Registros")
        dgrd_usuario.CaptionText = "USUARIOS"
    End Sub

    Public Function LeerMenu() As DataSet
        'funcion que retorna en un dataset las opciones del menu
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_menu As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_menu.SelectCommand = New SqlCommand("Select * from MENU order by men_id;", opr_conexion.conn_sql)
        LeerMenu = New DataSet()
        oda_menu.Fill(LeerMenu, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer MENU", Err)
        Err.Clear()
    End Function


    Public Function LeerAreasUsuarioParam(ByVal usu_id As Single, ByRef arr_datos As ArrayList, Optional ByRef arr_nombre As ArrayList = Nothing)
        'funcion que retorna en un dataset las areas a las que pertenece un usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing

        str_sql = "Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " and ARE_OCUPACIONAL in(0,1) order by area.are_obs;"
        opr_conexion.sql_conectar()

        Dim odr_menu As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_menu.Read
            arr_datos.Add(odr_menu.GetValue(0))
            If Not (arr_nombre Is Nothing) Then arr_nombre.Add(odr_menu.GetValue(1))
        End While
        odr_menu.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAreasUsuario", Err)
        Err.Clear()
    End Function


    Public Function LeerAreasUsuario(ByVal usu_id As Single, ByRef arr_datos As ArrayList, ByVal LabOcup As Byte, ByRef arre_areas As String, Optional ByRef arr_nombre As ArrayList = Nothing)
        'funcion que retorna en un dataset las areas a las que pertenece un usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing
        arr_datos.Clear()

        If LabOcup = 0 Then
            str_sql = "Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " and ARE_OCUPACIONAL = 0 order by area.are_obs;"
        Else
            str_sql = "Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " and ARE_OCUPACIONAL in(1) order by area.are_obs;"
        End If
        opr_conexion.sql_conectar()
        arre_areas = Nothing

        Dim odr_menu As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_menu.Read
            arr_datos.Add(odr_menu.GetValue(0))
            arre_areas = arre_areas & CStr(odr_menu.GetValue(0)) & ","
            If Not (arr_nombre Is Nothing) Then arr_nombre.Add(odr_menu.GetValue(1))

        End While
        odr_menu.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAreasUsuario", Err)
        Err.Clear()
    End Function


    Public Function LeerAreasUsuarioValida(ByVal usu_id As Single, ByRef arr_datos As ArrayList, ByVal LabOcup As Byte, Optional ByRef arr_nombre As ArrayList = Nothing)
        'funcion que retorna en un dataset las areas a las que pertenece un usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing

        If LabOcup = 0 Then
            str_sql = "Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " and ARE_OCUPACIONAL = 0 order by area.are_obs;"
        Else
            str_sql = "Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " and ARE_OCUPACIONAL in(0,1) order by area.are_obs;"
        End If
        opr_conexion.sql_conectar()

        Dim odr_menu As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_menu.Read
            arr_datos.Add(odr_menu.GetValue(0))
            If Not (arr_nombre Is Nothing) Then arr_nombre.Add(odr_menu.GetValue(1))
        End While
        odr_menu.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAreasUsuario", Err)
        Err.Clear()
    End Function




    Public Function LeerAreasUsuarioLT(ByVal usu_id As Single, ByRef arr_datos As ArrayList, ByVal EsOcup As Boolean, Optional ByRef arr_nombre As ArrayList = Nothing)
        'funcion que retorna en un dataset las areas a las que pertenece un usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing

        If EsOcup = False Then
            str_sql = "Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " and ARE_OCUPACIONAL = 0 order by area.are_obs;"
        Else
            str_sql = "Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " and ARE_OCUPACIONAL in(0,1) order by area.are_obs;"
        End If
        opr_conexion.sql_conectar()

        Dim odr_menu As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_menu.Read
            arr_datos.Add(odr_menu.GetValue(0))
            If Not (arr_nombre Is Nothing) Then arr_nombre.Add(odr_menu.GetValue(1))
        End While
        odr_menu.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAreasUsuario", Err)
        Err.Clear()
    End Function


    Public Function LeerMenuSeleccionado(ByVal usu_id As Single) As DataSet
        'funcion que retorna las opciones del menu a las que tiene accceso un usuario
        'recibe el id del usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_menu As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_menu.SelectCommand = New SqlCommand("Select men_id from USUARIO_MENU where usu_id=" & usu_id, opr_conexion.conn_sql)
        LeerMenuSeleccionado = New DataSet()
        oda_menu.Fill(LeerMenuSeleccionado, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Menu Por Usuario", Err)
        Err.Clear()
    End Function


    Sub LlenarListaMenu(ByRef chkl_menu As CheckedListBox, ByVal invitado_id As Single)
        'funcion que llena un listbox con las opciones del menu de un dterminado usuario
        On Error Resume Next
        Dim dts_menu As DataSet
        Dim dtr_fila As DataRow
        Dim int_i As Integer
        Dim sng_flag As Single
        dts_menu = LeerMenuSeleccionado(invitado_id)
        For int_i = 1 To chkl_menu.Items.Count
            sng_flag = 0
            For Each dtr_fila In dts_menu.Tables("Registros").Rows
                If dtr_fila("men_id") = Trim(chkl_menu.Items.Item(int_i - 1).substring(200, 10)) Then
                    sng_flag = 1
                    Exit For
                End If
            Next
            If sng_flag = 1 Then
                chkl_menu.SetItemChecked(int_i - 1, True)
            Else
                chkl_menu.SetItemChecked(int_i - 1, False)
            End If
        Next
        chkl_menu.SelectedIndex = 0
    End Sub

    Public Sub GuardarMenu(ByVal chkl_menu As CheckedListBox, ByVal usu_id As Single)
        'funcion que guarda las opciones a las que tiene acceso un determinado usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_paciente As SqlCommand
        opr_conexion.sql_conectar()
        odc_paciente = New SqlCommand("Delete from usuario_menu where usu_id=" & usu_id, opr_conexion.conn_sql)
        odc_paciente.ExecuteNonQuery()
        Dim int_i As Integer
        For int_i = 1 To chkl_menu.Items.Count
            If chkl_menu.GetItemChecked(int_i - 1) = True Then
                odc_paciente = New SqlCommand("insert into usuario_menu(men_id, usu_id) values('" & _
                        Trim(chkl_menu.Items.Item(int_i - 1).substring(200, 10)) & "'," & usu_id & _
                         ")", opr_conexion.conn_sql)
                odc_paciente.ExecuteNonQuery()
                g_opr_usuario.CargarTransaccion(g_str_login, "Ingreso o Actualizacion Permisos de Usuario", "", g_sng_user, "", "", "")
            End If
        Next
        opr_conexion.sql_desconn()
        MsgBox("Los cambios fueron almacenados correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Lista De Menu Por Usuario", Err)
        Err.Clear()
    End Sub

    Public Function LeerMaxCodUsuario() As Short
        'Funcion para la consultar el c�digo m�ximo de la tabla USUARIO   
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxCodUsuario = CShort(New SqlCommand("Select isnull(Max(usu_id),0) from USUARIO", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codigo de Usuario", Err)
        Err.Clear()
    End Function

    Public Function ExisteLogin(ByVal usu_login As String) As Boolean
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        ExisteLogin = False
        cls_operacion.sql_Conectar()
        If CShort(New SqlCommand("Select count(usu_login) from USUARIO where usu_login='" & usu_login & "'", cls_operacion.conn_sql).ExecuteScalar) > 0 Then
            ExisteLogin = True
        End If
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Comprobar login", Err)
        Err.Clear()
    End Function

    Public Sub GuardarUsuario(ByVal usu_id As Integer, ByVal usu_nombre As String, _
                            ByVal usu_apellido As String, ByVal usu_ci As String, _
                            ByVal usu_direccion As String, ByVal usu_fono As String, _
                            ByVal usu_cargo As String, ByVal usu_mail As String, _
                            ByVal usu_login As String, ByVal usu_pswd As String, _
                            ByVal usu_administrador As Byte, ByRef chkl_areas As CheckedListBox)
        'Procedimiento para la insertar un registro en la tabla USUARIO
        On Error GoTo MsgError
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        str_sql = "Insert into USUARIO values (" & usu_id & ", '" & usu_login & " ', '" & usu_pswd & "',  '" & usu_ci & "', '" & usu_apellido & "', '" & usu_nombre & " ', '" & usu_direccion & "', '" & usu_fono & "', '" & usu_cargo & "', '" & usu_mail & "', '" & Today & "', 0, '" & usu_administrador & "',1,1,1)"
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        'Areas relacionadas al usuario
        For int_i = 0 To (chkl_areas.Items.Count - 1)
            If chkl_areas.GetItemChecked(int_i) = True Then
                str_sql = "insert into area_usuario values (" & Trim(Mid(chkl_areas.Items.Item(int_i), 150)) & ", " & usu_id & "  )"
                odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()
            End If
        Next
        str_sql = "Insert into USUARIO_DIVISION (usu_id,div_id) values (" & usu_id & ",1)"
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Usuario", "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Usuario", Err)
        Err.Clear()
    End Sub

    Public Sub GeneraUsuarioWeb(ByVal pac_web_id As Integer, ByVal usu_id As Integer, _
                            ByVal pac_web_fecing As Date, _
                            ByVal pac_web_login As String, ByVal pac_web_pass As String)

        'Procedimiento para la insertar un registro en la tabla PACIENTE WEB
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        str_sql = "Insert into PACIENTE_WEB values (" & pac_web_id & ", " ' & usu_id & ", '" & usu_login & " ', '" & usu_pswd & "',  '" & usu_ci & "', '" & usu_apellido & "', '" & usu_nombre & " ', '" & usu_direccion & "', '" & usu_fono & "', '" & usu_cargo & "', '" & usu_mail & "', '" & Today & "', 0, '" & usu_administrador & "',1,1,1)"
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Usuario", "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Usuario", Err)
        Err.Clear()
    End Sub


    '    Public Sub ActualizarUsuario(ByVal usu_id As Integer, ByVal usu_nombre As String, _
    '                            ByVal usu_apellido As String, ByVal usu_ci As String, _
    '                            ByVal usu_direccion As String, ByVal usu_fono As String, _
    '                            ByVal usu_cargo As String, ByVal usu_mail As String, _
    '                            ByVal usu_login As String, ByVal usu_pswd As String, _
    '                            ByVal usu_administrador As Byte, ByRef chkl_areas As CheckedListBox)
    '        'Procedimiento para la actualizar un registro en la tabla USUARIO
    '        On Error GoTo MsgError
    '        Dim cls_operacion As New Cls_Conexion()
    '        Dim odc_operacion As SqlCommand
    '        cls_operacion.sql_conectar()
    '        odc_operacion = New SqlCommand(, cls_operacion.conn_sql)
    '        odc_operacion.ExecuteNonQuery()
    '        cls_operacion.sql_desconn()
    '        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Usuario", "update USUARIO set usu_login = '" & usu_login & "',usu_pswd = '" & usu_pswd & "',  usu_nombre = '" & _
    '        usu_nombre & "', usu_apellido = '" & usu_apellido & "', usu_ci = '" & usu_ci & "', usu_direccion = '" & usu_direccion & "', usu_fono = '" & _
    '        usu_fono & "', usu_cargo = '" & usu_cargo & "', usu_mail = '" & usu_mail & "', usu_administrador = " & usu_administrador & " where usu_id = " & _
    '        usu_id)
    '        Exit Sub
    'MsgError: MsgBox("No se pudo realizar la operacion solicitada, Actualizar Usuario", MsgBoxStyle.Exclamation, "ANALISYS")
    '        Err.Clear()
    '    End Sub

    Public Sub ActualizarUsuario(ByVal usu_id As Integer, ByVal usu_nombre As String, _
                            ByVal usu_apellido As String, ByVal usu_ci As String, _
                            ByVal usu_direccion As String, ByVal usu_fono As String, _
                            ByVal usu_cargo As String, ByVal usu_mail As String, _
                            ByVal usu_login As String, ByVal usu_pswd As String, _
                            ByVal usu_administrador As Byte, ByRef chkl_areas As CheckedListBox)
        'Procedimiento para la actualizar un registro en la tabla USUARIO
        On Error GoTo MsgError
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'Elimino las areas relacionadas al usuario
        str_sql = "Delete from area_usuario where usu_id = " & usu_id & ""
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        'Actualizo los datos del usuario
        str_sql = "update USUARIO set usu_login = '" & usu_login & "',usu_pswd = '" & usu_pswd & "',  usu_nombre = '" & _
                usu_nombre & "', usu_apellido = '" & usu_apellido & "', usu_ci = '" & usu_ci & "', usu_direccion = '" & usu_direccion & "', usu_fono = '" & _
                usu_fono & "', usu_cargo = '" & usu_cargo & "', usu_mail = '" & usu_mail & "', usu_administrador = " & usu_administrador & " where usu_id = " & usu_id
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        'Actualizo las areas relacionadas al usuario
        For int_i = 0 To (chkl_areas.Items.Count - 1)
            If chkl_areas.GetItemChecked(int_i) = True Then
                str_sql = "insert into area_usuario values (" & Trim(Mid(chkl_areas.Items.Item(int_i), 150)) & ", " & usu_id & "  )"
                odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()
            End If
        Next
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        str_sql = "update USUARIO set usu_login = '" & usu_login & "',usu_pswd = '" & usu_pswd & "',  usu_nombre = '" & _
                        usu_nombre & "', usu_apellido = '" & usu_apellido & "', usu_ci = '" & usu_ci & "', usu_direccion = '" & usu_direccion & "', usu_fono = '" & _
                        usu_fono & "', usu_cargo = '" & usu_cargo & "', usu_mail = '" & usu_mail & "', usu_administrador = " & usu_administrador & " where usu_id = " & usu_id
        g_opr_usuario.CargarTransaccion(g_str_login, "ACTUALIZA USR", "USUARIO=" & usu_login, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Usuario", Err)
        Err.Clear()
    End Sub


    Public Function EliminarUsuario(ByVal usu_id As String) As Boolean
        'Procedimiento para la eliminar un registro en la tabla USUARIO 
        On Error GoTo MsgError
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'Elimino las areas relacionadas al usuario
        str_sql = "Delete from area_usuario where usu_id = " & usu_id & ""
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        'Elimino las menu relacionadas al usuario
        str_sql = "Delete from usuario_menu where usu_id = " & usu_id & ""
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        'Elimino el registro del usuario
        str_sql = "delete from usuario where usu_id = " & usu_id & ""
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        str_sql = "delete from usuario_division where usu_id = " & usu_id & ""
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        g_opr_usuario.CargarTransaccion(g_str_login, "ELIMINA USR", "USUARIO=" & usu_id, g_sng_user, "", "", "")
        EliminarUsuario = True
        Exit Function
MsgError:
        EliminarUsuario = False
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Usuario", Err)
        Err.Clear()
    End Function

    Public Function VerificarPswd(ByVal usu_id As Single, ByVal pswd As String) As DataSet
        'funcion que verifica el password de un determinado usuario
        'recibe el usi_id y el us_pswd
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_usuario As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_usuario.SelectCommand = New SqlCommand("Select * from INVITADO where invitado_id = " & usu_id & " and invitado_pswd = '" & pswd & "'", opr_conexion.conn_sql)
        VerificarPswd = New DataSet()
        oda_usuario.Fill(VerificarPswd, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Verificar Pswd Usuario", Err)
        Err.Clear()
    End Function

    Public Sub CambiarPswd(ByVal usu_id As Single, ByVal pswd As String)
        'funcion que me permite el cambio de password de un determinado usuario
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_usuario As SqlCommand
        opr_Conexion.sql_conectar()
        odc_usuario = New SqlCommand("update INVITADO set invitado_pswd='" & pswd & "' where invitado_id=" & usu_id, opr_Conexion.conn_sql)
        odc_usuario.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "ACTUALIZA PASS USR", "USR=" & usu_id & " PASS=" & pswd, g_sng_user, "", "", "")
        MsgBox("La contrasena fue cambiada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Cambiar Pswd Usuario", Err)
        Err.Clear()
    End Sub

    Public Function LeerUsuarioConectado() As DataSet
        'funcion que me permite verificar cuantos ycuales usuarios tienen una session activa 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_usuario As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_usuario.SelectCommand = New SqlCommand("Select usu_login from USUARIO where usu_conectado=1", opr_conexion.conn_sql)
        LeerUsuarioConectado = New DataSet()
        oda_usuario.Fill(LeerUsuarioConectado, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Usuarios Conectados", Err)
        Err.Clear()
    End Function

    Public Sub CargarTransaccion(ByVal usu_login As String, ByVal str_operacion As String, ByVal str_instruccion As String, Optional ByVal g_sng_user As Integer = 0, Optional ByVal ped_id As String = "", Optional ByVal ped_turno As String = "", Optional ByVal tes_id As String = "")
        'funcion que alamacena en un archivo .log todas las transacciones realizadas por le usuario
        On Error GoTo MsgError
        Dim str_archivo As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_usuario As SqlCommand
        Dim str_sql As String = Nothing

        str_sql = "insert into AUDITORIA values('" & ped_id & "', '" & ped_turno & "', '" & tes_id & "', '" & g_sng_user & "', getdate(), '" & str_operacion & "', '" & str_instruccion & "');"
        opr_conexion.sql_conectar()
        odc_usuario = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_usuario.ExecuteNonQuery()
        opr_conexion.sql_desconn()


        If Dir(g_str_transaccion, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_str_transaccion)
        str_archivo = g_str_transaccion & "\Log-" & Month(Now) & "-" & Year(Now) & ".log"

        If System.IO.File.Exists(str_archivo) = True Then
            Dim txw_archivo As TextWriter = System.IO.File.AppendText(str_archivo)
            txw_archivo.WriteLine(Now & "," & invitado & "," & str_operacion & "," & str_instruccion)
            txw_archivo.WriteLine("*************")
            txw_archivo.Close()
        Else
            Dim fis_archivo As FileStream = System.IO.File.Create(str_archivo)
            fis_archivo.Close()
            Dim txw_archivo As TextWriter = System.IO.File.AppendText(str_archivo)
            txw_archivo.WriteLine(Now & "," & invitado & "," & str_operacion & "," & str_instruccion)
            txw_archivo.WriteLine("*************")
            txw_archivo.Close()
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Registrar Transaccion", Err)
        Err.Clear()
    End Sub

    Sub MensajeBoxError(ByVal str_mensaje As String, Optional ByVal obj_error As ErrObject = Nothing)
        'se lista los errores que se puedan detectar
        '5: cuando se realizan operaciones no validas contra la Base de Datos
        Select Case obj_error.Number
            Case 5
                MsgBox(str_mensaje & Chr(13) & "operaciones, con la base de datos, " & obj_error.Description, MsgBoxStyle.Exclamation, "ANALISYS")
            Case Else
                MsgBox(str_mensaje, MsgBoxStyle.Exclamation, "ANALISYS")
        End Select
    End Sub

    Public Function existeclave(ByVal clave As String) As String
        'Procedimiento para los verificar la clave de gerencia
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        STR_SQL = "select usu_pswd from usuario where usu_login = 'admin'"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        oda_operacion.Fill(dts_operacion)
        If dts_operacion.Tables(0).Rows.Count() > 0 Then
            dtr_operacion = dts_operacion.Tables(0).Rows(0)
            existeclave = dtr_operacion(0)
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Verifica password", Err)
        Err.Clear()
    End Function

    Public Sub VerificarBD()
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'proceso de CHEQUEO DE TABLAS
        'Dim str_sql As String = "CHECK TABLE abono,area,area_usuario,bonificacion,calibracion,ciudad,control_calidad,convenio,division,equipo,error_equipo,factura,factura_detalle,folio,i_bodega,i_modalidad_conservacion,i_movimiento,i_movimiento_detalle,i_producto,i_proveedor,i_tipo_movimiento,i_unidad,laboratorio,lista_precio,lista_trabajo,log_archivo,medico,menu,muestra,paciente,parametro,pedido,pedido_detalle,pedido_detalle_desglosado,perfil,perfil_test,ptohistograma,res_procesados,resultado,sni,test,test_equipo,test_relacionado,test_resultado,test_tipmuestra,testequipo_tipmuestra,tipo_muestra,tipo_prioridad,tipo_tubo,unidad,unidad_equivalencia,usuario,usuario_division,usuario_menu;"
        Dim str_sql As String = "CHECK TABLE lista_precio,lista_trabajo,pedido,pedido_detalle,pedido_detalle_desglosado,ptohistograma,res_procesados,test,test_equipo;"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        'PROCESO DE ANALISIS DE LAS TABLAS
        'str_sql = "ANALYZE TABLE abono,area,area_usuario,bonificacion,calibracion,ciudad,control_calidad,convenio,division,equipo,error_equipo,factura,factura_detalle,folio,i_bodega,i_modalidad_conservacion,i_movimiento,i_movimiento_detalle,i_producto,i_proveedor,i_tipo_movimiento,i_unidad,laboratorio,lista_precio,lista_trabajo,log_archivo,medico,menu,muestra,paciente,parametro,pedido,pedido_detalle,pedido_detalle_desglosado,perfil,perfil_test,ptohistograma,res_procesados,resultado,sni,test,test_equipo,test_relacionado,test_resultado,test_tipmuestra,testequipo_tipmuestra,tipo_muestra,tipo_prioridad,tipo_tubo,unidad,unidad_equivalencia,usuario,usuario_division,usuario_menu;"
        str_sql = "ANALYZE TABLE lista_precio,lista_trabajo,pedido,pedido_detalle,pedido_detalle_desglosado,ptohistograma,res_procesados,test,test_equipo;"
        odc_pedido.ExecuteNonQuery()
        'PROCESOS DE REPARACION DE TABLAS
        'str_sql = "REPAIR TABLE abono,area,area_usuario,bonificacion,calibracion,ciudad,control_calidad,convenio,division,equipo,error_equipo,factura,factura_detalle,folio,i_bodega,i_modalidad_conservacion,i_movimiento,i_movimiento_detalle,i_producto,i_proveedor,i_tipo_movimiento,i_unidad,laboratorio,lista_precio,lista_trabajo,log_archivo,medico,menu,muestra,paciente,parametro,pedido,pedido_detalle,pedido_detalle_desglosado,perfil,perfil_test,ptohistograma,res_procesados,resultado,sni,test,test_equipo,test_relacionado,test_resultado,test_tipmuestra,testequipo_tipmuestra,tipo_muestra,tipo_prioridad,tipo_tubo,unidad,unidad_equivalencia,usuario,usuario_division,usuario_menu TYPE = QUICK;"
        str_sql = "REPAIR TABLE lista_precio,lista_trabajo,pedido,pedido_detalle,pedido_detalle_desglosado,ptohistograma,res_procesados,test,test_equipo TYPE = QUICK;"
        odc_pedido.ExecuteNonQuery()
        'PROCESO DE OPTIMIZACI�N DE TABLAS
        'str_sql = "OPTIMIZE TABLE abono;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE area;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE area_usuario;"
        'str_sql = ""
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE bonificacion;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE calibracion;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE ciudad;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE control_calidad;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE convenio;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE division;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE equipo;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE error_equipo;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE factura;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE factura_detalle;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE folio;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_bodega;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_modalidad_conservacion;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_movimiento;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_movimiento_detalle;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_producto;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_proveedor;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_tipo_movimiento;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE i_unidad;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE laboratorio;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE lista_precio;"
        'odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE lista_trabajo;"
        odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE log_archivo;"
        'odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE medico;"
        odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE menu;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE muestra;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE paciente;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE parametro;"
        'odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE pedido;"
        odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE pedido_detalle;"
        odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE pedido_detalle_desglosado;"
        odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE perfil;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE perfil_test;"
        'odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE ptohistograma;"
        odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE res_procesados;"
        odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE resultado;"
        odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE sni;"
        'odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE test;"
        odc_pedido.ExecuteNonQuery()
        str_sql = "OPTIMIZE TABLE test_equipo;"
        odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE test_relacionado;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE test_resultado;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE test_tipmuestra;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE testequipo_tipmuestra;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE tipo_muestra;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE tipo_prioridad;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE tipo_tubo;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE unidad;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE unidad_equivalencia;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE usuario;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE usuario_division;"
        'odc_pedido.ExecuteNonQuery()
        'str_sql = "OPTIMIZE TABLE usuario_menu;"
        'odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        MsgBox("operacion exitosa", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Verificar BD", Err)
        Err.Clear()
    End Sub

End Class
