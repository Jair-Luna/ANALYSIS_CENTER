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

Public Class Cls_Invitado



    Public Function LeerUsuario(ByVal pswd As String) As Byte
        'Procedimiento para la consultar el usuario que coincida con un login y password recibidos por la funcion 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerUsuario = 0
        Dim odr_operacion As SqlDataReader = New SqlCommand("Select invitado_pswd from invitado where invitado_pswd = '" & pswd & "' and invitado_conectar = 0", opr_conexion.conn_sql).ExecuteReader
        Dim count As Byte = 0
        While odr_operacion.Read
            '*** Se asigna el login del usuario en una variable global y los signos auditables
            count = count + 1   'Variable para saber a que divisi�n pertenece el usuario          
            invitado = odr_operacion.GetValue(0)
        End While
        If count = 1 Then
            LeerUsuario = 1
        Else
            MsgBox("Usuario/Invitado no valido", MsgBoxStyle.Exclamation, "ANALISYS")
            LeerUsuario = 0
            g_opr_usuario.CargarTransaccion(g_str_login, "Ingreso CONTRASEÑA FALLIDO", "", g_sng_user, "", "")
        End If
        odr_operacion.Close()
        g_opr_usuario.CargarTransaccion(g_str_login, "Ingreso CONTRASEÑA", "Busca tabla invitado", g_sng_user, "", "")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        LeerUsuario = 0
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Usuario Para accesos al sistema", Err)
        Err.Clear()
    End Function


    Public Function CargaSedes(ByRef cmb_sedes As ComboBox, ByVal sede As Byte) As Byte
        'Procedimiento para la consultar el usuario que coincida con un login y password recibidos por la funcion 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand("Select lab_nombre from laboratorio; ", opr_conexion.conn_sql).ExecuteReader
        Dim count As Byte = 0
        While odr_operacion.Read
            '*** Se asigna el login del usuario en una variable global y los signos auditables
            count = count + 1   'Variable para saber a que divisi�n pertenece el usuario          
            cmb_sedes.Items.Add(odr_operacion.GetValue(0))
        End While
        If count >= 1 Then
            CargaSedes = 1
            cmb_sedes.SelectedIndex = sede
        Else
            MsgBox("No se ha podido cargar sedes", MsgBoxStyle.Exclamation, "ANALISYS")
            CargaSedes = 0
            g_opr_usuario.CargarTransaccion(g_str_login, "Ingreso CONTRASEÑA FALLIDO", "", g_sng_user, "", "")
        End If
        odr_operacion.Close()
        g_opr_usuario.CargarTransaccion(g_str_login, "CARGA SEDES", "Busca tabla laboratorio", g_sng_user, "", "")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        CargaSedes = 0
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Usuario Para accesos al sistema", Err)
        Err.Clear()
    End Function


    Public Function LeeUsuaraioWebM(ByVal usr_id As Integer) As String
        'Procedimiento para la consultar el usuario que coincida con un login y password recibidos por la funcion 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand("Select usuario.usu_login, invitado_pswd from invitado, usuario where invitado.invitado_id = " & usr_id & " and invitado.invitado_id = usuario.invitado_id; ", opr_conexion.conn_sql).ExecuteReader
        Dim count As Byte = 0
        While odr_operacion.Read
            LeeUsuaraioWebM = odr_operacion.GetString(0) & "º" & odr_operacion.GetString(1) & "º" & odr_operacion.GetString(2)
        End While
        
        odr_operacion.Close()
        g_opr_usuario.CargarTransaccion(g_str_login, "LEE USUARIO WEB", "Busca credenciales", g_sng_user, "", "")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        LeeUsuaraioWebM = ""
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Usuario Para accesos a Web", Err)
        Err.Clear()
    End Function

    Public Sub CambiarConectado(ByVal usu_id As Single, ByVal usu_conectado As Byte)
        'Procedimiento para actualizar el campo usu_conectado en usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_usuario As SqlCommand
        opr_conexion.sql_conectar()
        odc_usuario = New SqlCommand("update invitado set invitado_conectar=" & usu_conectado & " where invitado_id = " & usu_id, opr_conexion.conn_sql)
        odc_usuario.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Cambiar Conectado Usuario", Err)
        Err.Clear()
    End Sub

    Public Function LeerUsuario2() As DataSet
        'funcion que devuelve en un dataset los datos de los usuarios
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing
        str_sql = "select invitado.invitado_id, usuario.USU_LOGIN, invitado.invitado_pswd, invitado.invitado_nombre, invitado.invitado_apellido, " & _
        "invitado.invitado_firma, invitado.invitado_ci, invitado.invitado_fecing, invitado.invitado_conectar, invitado.invitado_cargo, " & _
        "invitado.invitado_folio, invitado.invitado_direccion, invitado.invitado_fono, invitado.invitado_mail, invitado.invitado_estado, " & _
        "invitado.invitado_perfilWeb, invitado.invitado_administrador " & _
        "from invitado, usuario where invitado.invitado_id = usuario.invitado_id; "
        Dim oda_usuario As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_usuario.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerUsuario2 = New DataSet()
        oda_usuario.Fill(LeerUsuario2, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Usuarios", Err)
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
            .Sort = "invitado_apellido"
        End With
        dgrd_usuario.DataSource = dtv_usuario
        dgrd_usuario.NavigateTo(0, "Registros")
        dgrd_usuario.CaptionText = "INVITADOS"
    End Sub

    Public Function LeerMenu() As DataSet
        'funcion que retorna en un dataset las opciones del menu
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_menu As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_menu.SelectCommand = New SqlCommand("Select * from MENU ", opr_conexion.conn_sql)
        LeerMenu = New DataSet()
        oda_menu.Fill(LeerMenu, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Menu", Err)
        Err.Clear()
    End Function

    Public Function LeerAreasUsuario(ByVal usu_id As Single, ByRef arr_datos As ArrayList, Optional ByRef arr_nombre As ArrayList = Nothing)
        'funcion que retorna en un dataset las areas a las que pertenece un usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_menu As SqlDataReader = New SqlCommand("Select area.are_id, area.are_nombre from area_usuario, area where area_usuario.are_id = area.are_id and area_usuario.usu_id=" & usu_id & " order by are_nombre;", opr_conexion.conn_sql).ExecuteReader
        While odr_menu.Read
            arr_datos.Add(odr_menu.GetValue(0))
            If Not (arr_nombre Is Nothing) Then arr_nombre.Add(odr_menu.GetValue(1))
        End While
        odr_menu.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAreasUsuario", Err)
        Err.Clear()
    End Function

    '    Public Function LeerMenuSeleccionado(ByVal usu_id As Single) As DataSet
    '        'funcion que retorna las opciones del menu a las que tiene accceso un usuario
    '        'recibe el id del usuario
    '        On Error GoTo MsgError
    '        Dim opr_conexion As New Cls_Conexion()
    '        Dim oda_menu As SqlDataAdapter = New SqlDataAdapter()
    '        opr_Conexion.conn_sql()
    '        oda_menu.SelectCommand = New SqlCommand("Select men_id from USUARIO_MENU where usu_id=" & usu_id, opr_Conexion.conn_sql)
    '        LeerMenuSeleccionado = New DataSet()
    '        oda_menu.Fill(LeerMenuSeleccionado, "Registros")
    '        opr_conexion.sql_desconn
    '        Exit Function
    'MsgError:
    '        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Menu Por Usuario", Err)
    '        Err.Clear()
    '    End Function


    '    Sub LlenarListaMenu(ByRef chkl_menu As CheckedListBox, ByVal usu_id As Single)
    '        'funcion que llena un listbox con las opciones del menu de un dterminado usuario
    '        On Error Resume Next
    '        Dim dts_menu As DataSet
    '        Dim dtr_fila As DataRow
    '        Dim int_i As Integer
    '        Dim sng_flag As Single
    '        dts_menu = LeerMenuSeleccionado(usu_id)
    '        For int_i = 1 To chkl_menu.Items.Count
    '            sng_flag = 0
    '            For Each dtr_fila In dts_menu.Tables("Registros").Rows
    '                If dtr_fila("men_id") = Trim(chkl_menu.Items.Item(int_i - 1).substring(100, 10)) Then
    '                    sng_flag = 1
    '                    Exit For
    '                End If
    '            Next
    '            If sng_flag = 1 Then
    '                chkl_menu.SetItemChecked(int_i - 1, True)
    '            Else
    '                chkl_menu.SetItemChecked(int_i - 1, False)
    '            End If
    '        Next
    '        chkl_menu.SelectedIndex = 0
    '    End Sub

    '    Public Sub GuardarMenu(ByVal chkl_menu As CheckedListBox, ByVal usu_id As Single)
    '        'funcion que guarda las opciones a las que tiene acceso un determinado usuario
    '        On Error GoTo MsgError
    '        Dim opr_conexion As New Cls_Conexion()
    '        Dim odc_paciente As SqlCommand
    '        opr_Conexion.conn_sql()
    '        odc_paciente = New SqlCommand("Delete from usuario_menu where usu_id=" & usu_id, opr_Conexion.conn_sql)
    '        odc_paciente.ExecuteNonQuery()
    '        Dim int_i As Integer
    '        For int_i = 1 To chkl_menu.Items.Count
    '            If chkl_menu.GetItemChecked(int_i - 1) = True Then
    '                odc_paciente = New SqlCommand("insert into usuario_menu(men_id, usu_id) values('" & _
    '                        Trim(chkl_menu.Items.Item(int_i - 1).substring(100, 10)) & "'," & usu_id & _
    '                         ")", opr_Conexion.conn_sql)
    '                odc_paciente.ExecuteNonQuery()
    '                g_opr_invitado.CargarTransaccion(g_str_login, "Nuevo o Actualizar Permisos de Usuario", "insert into usuario_menu(men_id, usu_id) values('" & _
    '                        Trim(chkl_menu.Items.Item(int_i - 1).substring(100, 10)) & "'," & usu_id & _
    '                         ")")
    '            End If
    '        Next
    '        opr_conexion.sql_desconn
    '        MsgBox("Los cambios fueron almacenados correctamente", MsgBoxStyle.Information, "ANALISYS")
    '        Exit Sub
    'MsgError:
    '        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Lista De Menu Por Usuario", Err)
    '        Err.Clear()
    '    End Sub

    Public Function LeerMaxCodUsuario() As Short
        'Funcion para la consultar el c�digo m�ximo de la tabla USUARIO   
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        LeerMaxCodUsuario = CShort(New SqlCommand("Select isnull(Max(invitado_id),0) from invitado", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer M�ximo C�digo de Usuario", Err)
        Err.Clear()
    End Function

    Public Function ExisteLogin(ByVal usu_login As String) As Boolean
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        ExisteLogin = False
        cls_operacion.sql_conectar()
        If CShort(New SqlCommand("Select count(invitado_pswd) from invitado where invitado_pswd='" & usu_login & "'", cls_operacion.conn_sql).ExecuteScalar) > 0 Then
            ExisteLogin = True
        End If
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Comprobar login", Err)
        Err.Clear()
    End Function

    Public Sub GuardarUsuario(ByVal invitado_id As Integer, ByVal usu_login As String, ByVal invitado_pass As String, _
                            ByVal invitado_nombre As String, ByVal invitado_apellido As String, ByVal invitado_firma As String, _
                            ByVal invitado_ci As String, ByVal invitado_cargo As String, ByVal invitado_folio As String, _
                            ByVal invitado_direccion As String, ByVal invitado_fono As String, ByVal invitado_PerfilWeb As String, _
                            ByVal invitado_administrador As String, ByVal invitado_mail As String, ByRef chkl_areas As CheckedListBox)
        'Procedimiento para la insertar un registro en la tabla USUARIO RFN
        If invitado_direccion = "" Then
            invitado_direccion = "ND"
        End If

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        Dim odbc_trans1 As SqlTransaction
        Dim odbc_strsql1 As SqlCommand
        Dim fecing As Date = Now()
        Dim int_i As Integer
        Dim str_sql As String = Nothing
        Dim str_sql1 As String = Nothing

        opr_Conexion.sql_conectar()



        str_sql = "Insert into INVITADO (invitado_id,invitado_pswd,invitado_nombre,invitado_apellido,invitado_firma,invitado_ci,invitado_fecing, invitado_cargo, invitado_folio, invitado_direccion, invitado_fono, invitado_mail, invitado_perfilWeb, invitado_administrador) values (" & invitado_id & ", '" & invitado_pass & "','" & invitado_nombre & "', '" & invitado_apellido & "', '" & invitado_firma & " ', '" & invitado_ci & "' ,'" & fecing & "', '" & invitado_cargo & "'" & ",'" & invitado_folio & "', '" & invitado_direccion & "' , '" & invitado_fono & "' , '" & invitado_mail & "' , '" & invitado_PerfilWeb & "' , '" & invitado_administrador & "')"
        str_sql1 = "Insert into USUARIO values (" & invitado_id & ", '" & usu_login & "')"

        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()

        odbc_trans1 = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql1 = New SqlCommand(str_sql1, opr_Conexion.conn_sql, odbc_trans1)
        odbc_strsql1.ExecuteNonQuery()
        odbc_trans1.Commit()

        'Areas relacionadas al usuario
        For int_i = 0 To (chkl_areas.Items.Count - 1)
            If chkl_areas.GetItemChecked(int_i) = True Then
                str_sql = "insert into area_usuario values (" & Trim(Mid(chkl_areas.Items.Item(int_i), 150)) & ", " & invitado_id & "  )"
                odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()
            End If
        Next

        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        'g_opr_invitado.CargarTransaccion(g_str_login, "Nuevo Test", "Insert into USUARIO values (" & usu_id & ", '" & usu_login & " ', '" & usu_pswd & "',  '" & usu_ci & "', '" & usu_apellido & "', '" & usu_nombre & " ', '" & usu_direccion & "')")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Usuario", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarUsuarioM(ByVal invitado_id As Integer, ByVal usu_login As String, ByVal invitado_pass As String, _
                            ByVal invitado_nombre As String, ByVal invitado_apellido As String, ByVal invitado_firma As String, _
                            ByVal invitado_ci As String, ByVal invitado_cargo As String, ByVal invitado_folio As String, _
                            ByVal invitado_direccion As String, ByVal invitado_fono As String, ByVal invitado_PerfilWeb As String, _
                            ByVal invitado_administrador As String, ByVal invitado_mail As String)
        'Procedimiento para la insertar un registro en la tabla USUARIO RFN
        If invitado_direccion = "" Then
            invitado_direccion = "ND"
        End If

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        Dim odbc_trans1 As SqlTransaction
        Dim odbc_strsql1 As SqlCommand
        Dim fecing As Date = Now()
        Dim int_i As Integer
        Dim str_sql As String = Nothing
        Dim str_sql1 As String = Nothing

        opr_Conexion.sql_conectar()



        str_sql = "Insert into INVITADO (invitado_id,invitado_pswd,invitado_nombre,invitado_apellido,invitado_firma,invitado_ci,invitado_fecing, invitado_cargo, invitado_folio, invitado_direccion, invitado_fono, invitado_mail, invitado_perfilWeb, invitado_administrador) values (" & invitado_id & ", '" & invitado_pass & "','" & invitado_nombre & "', '" & invitado_apellido & "', '" & invitado_firma & " ', '" & invitado_ci & "' ,'" & fecing & "', '" & invitado_cargo & "'" & ",'" & invitado_folio & "', '" & invitado_direccion & "' , '" & invitado_fono & "' , '" & invitado_mail & "' , '" & invitado_PerfilWeb & "' , '" & invitado_administrador & "')"
        str_sql1 = "Insert into USUARIO values (" & invitado_id & ", '" & usu_login & "')"

        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()

        odbc_trans1 = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql1 = New SqlCommand(str_sql1, opr_Conexion.conn_sql, odbc_trans1)
        odbc_strsql1.ExecuteNonQuery()
        odbc_trans1.Commit()

        
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        'g_opr_invitado.CargarTransaccion(g_str_login, "Nuevo Test", "Insert into USUARIO values (" & usu_id & ", '" & usu_login & " ', '" & usu_pswd & "',  '" & usu_ci & "', '" & usu_apellido & "', '" & usu_nombre & " ', '" & usu_direccion & "')")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Usuario", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizaUsuarioM(ByVal invitado_id As Integer, ByVal usu_login As String, ByVal invitado_pass As String, _
                            ByVal invitado_nombre As String, ByVal invitado_apellido As String, ByVal invitado_firma As String, _
                            ByVal invitado_ci As String, ByVal invitado_cargo As String, ByVal invitado_folio As String, _
                            ByVal invitado_direccion As String, ByVal invitado_fono As String, ByVal invitado_PerfilWeb As String, _
                            ByVal invitado_administrador As String, ByVal invitado_mail As String, ByVal usr_id As String)
        'Procedimiento para la insertar un registro en la tabla USUARIO RFN
        If invitado_direccion = "" Then
            invitado_direccion = "ND"
        End If

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        Dim odbc_trans1 As SqlTransaction
        Dim odbc_strsql1 As SqlCommand
        Dim fecing As Date = Now()
        Dim int_i As Integer
        Dim str_sql As String = Nothing
        Dim str_sql1 As String = Nothing

        opr_Conexion.sql_conectar()



        str_sql = "update INVITADO set (invitado_id,invitado_pswd,invitado_nombre,invitado_apellido,invitado_firma,invitado_ci,invitado_fecing, invitado_cargo, invitado_folio, invitado_direccion, invitado_fono, invitado_mail, invitado_perfilWeb, invitado_administrador) values (" & invitado_id & ", '" & invitado_pass & "','" & invitado_nombre & "', '" & invitado_apellido & "', '" & invitado_firma & " ', '" & invitado_ci & "' ,'" & fecing & "', '" & invitado_cargo & "'" & ",'" & invitado_folio & "', '" & invitado_direccion & "' , '" & invitado_fono & "' , '" & invitado_mail & "' , '" & invitado_PerfilWeb & "' , '" & invitado_administrador & "')"
        str_sql1 = "update MEDICO set USR_ID = '" & usr_id & " ' where med_id = " & invitado_id

        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()

        odbc_trans1 = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql1 = New SqlCommand(str_sql1, opr_Conexion.conn_sql, odbc_trans1)
        odbc_strsql1.ExecuteNonQuery()
        odbc_trans1.Commit()


        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        'g_opr_invitado.CargarTransaccion(g_str_login, "Nuevo Test", "Insert into USUARIO values (" & usu_id & ", '" & usu_login & " ', '" & usu_pswd & "',  '" & usu_ci & "', '" & usu_apellido & "', '" & usu_nombre & " ', '" & usu_direccion & "')")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Usuario", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarUsuario(ByVal invitado_id As Integer, ByVal usu_login As String, ByVal invitado_pass As String, _
                            ByVal invitado_nombre As String, ByVal invitado_apellido As String, ByVal invitado_firma As String, _
                            ByVal invitado_ci As String, ByVal invitado_cargo As String, ByVal invitado_folio As String, _
                            ByVal invitado_direccion As String, ByVal invitado_fono As String, ByVal invitado_PerfilWeb As String, _
                            ByVal invitado_administrador As String, ByVal invitado_mail As String, ByRef chkl_areas As CheckedListBox)

        'Procedimiento para la actualizar un registro en la tabla USUARIO
        If invitado_direccion = "" Then
            invitado_direccion = "ND"
        End If

        Dim sw As Integer = Nothing

        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        Dim odbc_trans1 As SqlTransaction
        Dim odbc_strsql1 As SqlCommand

        Dim odbc_trans2 As SqlTransaction
        Dim odbc_strsql2 As SqlCommand

        Dim odbc_trans3 As SqlTransaction
        Dim odbc_strsql3 As SqlCommand

        Dim int_i As Integer
        Dim str_sql As String = Nothing
        Dim str_sql1 As String = Nothing
        Dim str_sql2 As String = Nothing
        Dim str_sql3 As String = Nothing


        On Error GoTo MsgError
        'Actualizo los datos del INVITADO
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        str_sql = "update INVITADO set invitado_pswd = '" & invitado_pass & "',  invitado_nombre = '" & invitado_nombre & "', invitado_apellido = '" & invitado_apellido & "', invitado_ci = '" & invitado_ci & "', invitado_firma = '" & invitado_firma & "', invitado_fono = '" & invitado_fono & "', invitado_cargo = '" & invitado_cargo & "', invitado_folio = '" & invitado_folio & "' ,invitado_mail = '" & invitado_mail & "', invitado_perfilWeb = '" & invitado_PerfilWeb & "', invitado_administrador = '" & invitado_administrador & "' where invitado_id = " & invitado_id
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        sw = 0
        odbc_trans.Commit()


        'Se registra la transaccion USUARIO
        odbc_trans1 = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        str_sql1 = "update USUARIO set usu_login = '" & usu_login & "' where invitado_id = " & invitado_id
        odbc_strsql1 = New SqlCommand(str_sql1, opr_Conexion.conn_sql, odbc_trans1)
        odbc_strsql1.ExecuteNonQuery()
        sw = 1
        odbc_trans1.Commit()

        'Se registra la transaccion AREA_USUARIO
        odbc_trans2 = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        str_sql2 = "Delete from area_usuario where usu_id = " & invitado_id & ""
        odbc_strsql2 = New SqlCommand(str_sql2, opr_Conexion.conn_sql, odbc_trans2)
        odbc_strsql2.ExecuteNonQuery()
        sw = 2
        odbc_trans2.Commit()

        'Actualizo las areas relacionadas al usuario
        odbc_trans3 = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        For int_i = 0 To (chkl_areas.Items.Count - 1)
            If chkl_areas.GetItemChecked(int_i) = True Then
                str_sql3 = "insert into area_usuario values (" & Trim(Mid(chkl_areas.Items.Item(int_i), 150)) & ", " & invitado_id & "  )"
                odbc_strsql3 = New SqlCommand(str_sql3, opr_Conexion.conn_sql, odbc_trans3)
                odbc_strsql3.ExecuteNonQuery()
            End If
        Next
        sw = 3
        odbc_trans3.Commit()

        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Modifica USR", "USR=" & invitado_id, g_sng_user, "", "", "")

        Exit Sub
MsgError:
        Select Case sw
            Case 0 : odbc_trans.Rollback()
            Case 1 : odbc_trans1.Rollback()
            Case 2 : odbc_trans2.Rollback()
            Case 3 : odbc_trans3.Rollback()
        End Select

        opr_Conexion.sql_desconn()
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Usuario", Err)
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
        'Elimino el registro del usuario
        str_sql = "delete from invitado where invitado_id = " & usu_id & ""
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada     
        g_opr_usuario.CargarTransaccion(g_str_login, "Elimina USR", "USR=" & usu_id, g_sng_user, "", "", "")
        EliminarUsuario = True
        Exit Function
MsgError:
        EliminarUsuario = False
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_invitado.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Usuario", Err)
        Err.Clear()
    End Function

    Public Function VerificarPswd(ByVal usu_id As Single, ByVal pswd As String) As DataSet
        'funcion que verifica el password de un determinado usuario
        'recibe el usi_id y el us_pswd
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_usuario As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_usuario.SelectCommand = New SqlCommand("Select * from invitado where usu_id = " & usu_id & " and usu_pswd = '" & pswd & "'", opr_conexion.conn_sql)
        VerificarPswd = New DataSet()
        oda_usuario.Fill(VerificarPswd, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Verificar Pswd Usuario", Err)
        Err.Clear()
    End Function

    Public Sub CambiarPswd(ByVal usu_id As Single, ByVal pswd As String)
        'funcion que me permite el cambio de password de un determinado usuario
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_usuario As SqlCommand
        opr_Conexion.sql_conectar()
        odc_usuario = New SqlCommand("update invitado  set invitado_pswd='" & pswd & "' where invitado_id=" & usu_id, opr_Conexion.conn_sql)
        odc_usuario.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar PASS", usu_id & "=" & pswd, g_sng_user, "", "", "")
        MsgBox("La contrase�a fue cambiada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Cambiar Pswd Usuario", Err)
        Err.Clear()
    End Sub


    Public Sub CargarTransaccion(ByVal usu_login As String, ByVal str_operacion As String, ByVal str_instruccion As String)
        'funcion que alamacena en un archivo .log todas las transacciones realizadas por le usuario
        On Error GoTo MsgError
        Dim str_archivo As String
        If Dir(g_str_transaccion, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_str_transaccion)
        str_archivo = g_str_transaccion & "\trans-" & Month(Now) & "-" & Year(Now) & ".log"
        If File.Exists(str_archivo) = True Then
            Dim txw_archivo As TextWriter = File.AppendText(str_archivo)
            txw_archivo.WriteLine(Now & "," & g_str_login & "," & str_operacion & "," & str_instruccion)
            txw_archivo.WriteLine("*************")
            txw_archivo.Close()
        Else
            Dim fis_archivo As FileStream = File.Create(str_archivo)
            fis_archivo.Close()
            Dim txw_archivo As TextWriter = File.AppendText(str_archivo)
            txw_archivo.WriteLine(Now & "," & usu_login & "," & str_operacion & "," & str_instruccion)
            txw_archivo.WriteLine("*************")
            txw_archivo.Close()
        End If
        Exit Sub
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Cargar transaccion Usuario", Err)
        Err.Clear()
    End Sub

    Sub MensajeBoxError(ByVal str_mensaje As String, Optional ByVal obj_error As ErrObject = Nothing)
        'se lista los errores que se puedan detectar
        '5: cuando se realizan operaciones no v�lidas contra la Base de Datos
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
        STR_SQL = "select invitado_pswd from invitado where invitado_pswd = 'admin'"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        oda_operacion.Fill(dts_operacion)
        If dts_operacion.Tables(0).Rows.Count() > 0 Then
            dtr_operacion = dts_operacion.Tables(0).Rows(0)
            existeclave = dtr_operacion(0)
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_invitado.MensajeBoxError("No se pudo realizar la transaccion solicitada, Verifica password", Err)
        Err.Clear()
    End Function


    Public Function ConsultaIDInvitado(ByVal inv_pswd As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ConsultaIDInvitado = ""
        ConsultaIDInvitado = CStr(New SqlCommand("select invitado_id from invitado where invitado_pswd = '" & inv_pswd & "';", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Invitado Name", Err)
        Err.Clear()
    End Function

    Public Function ConsultaNameInvitado(ByVal inv_pswd As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ConsultaNameInvitado = ""
        ConsultaNameInvitado = CStr(New SqlCommand("select invitado_nombre+' '+ invitado_apellido from invitado where invitado_pswd = '" & inv_pswd & "';", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Invitado Name", Err)
        Err.Clear()
    End Function


    Public Function ConsultaNameCargo(ByVal inv_pswd As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ConsultaNameCargo = ""
        ConsultaNameCargo = CStr(New SqlCommand("select invitado_cargo from usuario, invitado where usuario.invitado_id = invitado.invitado_id and usuario.usu_login = '" & inv_pswd & "';", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cargo", Err)
        Err.Clear()
    End Function

    Public Function ConsultaNameUnidad(ByVal unidad As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 


        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        ConsultaNameUnidad = ""

        STR_SQL = "select sec_nombre, sec_desde, sec_hasta from secuencias where sec_unidad = '" & unidad & "'"


        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        oda_operacion.Fill(dts_operacion)
        If dts_operacion.Tables(0).Rows.Count() > 0 Then
            dtr_operacion = dts_operacion.Tables(0).Rows(0)
            ConsultaNameUnidad = dtr_operacion(0) & "," & dtr_operacion(1) & "," & dtr_operacion(2)
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Unidad/sec", Err)
        Err.Clear()
    End Function

    Public Function ConsultaFirmaInvitado(ByVal invitado_id As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ConsultaFirmaInvitado = ""
        Dim str_sql As String = "select case when invitado_firma <> null then invitado_firma else (invitado_nombre + ' ' + invitado_apellido)  end as INV from invitado where invitado_id = '" & invitado_id & "';"
        ConsultaFirmaInvitado = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Invitado Name", Err)
        Err.Clear()
    End Function


    Public Function ConsultaCargoInvitado(ByVal invitado_id As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ConsultaCargoInvitado = ""
        Dim str_sql As String = "select invitado_cargo as cargo from invitado where invitado_id = '" & invitado_id & "';"
        ConsultaCargoInvitado = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Invitado Name", Err)
        Err.Clear()
    End Function

    Public Function ConsultaFolioInvitado(ByVal invitado_id As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ConsultaFolioInvitado = ""
        Dim str_sql As String = "select invitado_folio as folio from invitado where invitado_id = '" & invitado_id & "';"
        ConsultaFolioInvitado = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Invitado Name", Err)
        Err.Clear()
    End Function


    Public Function ConsultaFechaValidado(ByVal invitado_id As String) As String
        'Funci�n que me devuelve el nombre del invitado para dato informativo 
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ConsultaFechaValidado = ""
        Dim str_sql As String = "select invitado_folio as folio from invitado where invitado_id = '" & invitado_id & "';"
        ConsultaFechaValidado = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Invitado Name", Err)
        Err.Clear()
    End Function

End Class
