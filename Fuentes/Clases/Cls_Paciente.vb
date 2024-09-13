'*************************************************************************
' Nombre:   Cls_Paciente
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de los pacientes
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Paciente
    Public Shared informacion As DataSet
    Public oda_paciente As SqlDataAdapter = New SqlDataAdapter()
    Public PacDataSet As DataSet = New DataSet()


    Public Function LeerPaciente() As DataSet
        'funcion que devuelve un dataset con los datos de los pacientes
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_paciente.SelectCommand = New SqlCommand("Select pac_id, pac_doc,pac_tipodoc,  pac_apellido , pac_nombre, pac_direccion, ciu_nombre, pac_fono, pac_fecnac, pac_sexo, pac_obs, pac_mail, PAC_HIST_CLINICA, pac_grado, pac_parentesco, PAC_PROFESION, PAC_LUGARNAC, PAC_LUGARVIVE,  from paciente, PAC_CONOCIO_FUENTE, PAC_CONOCIO_OTRO ciudad where paciente.ciu_id=ciudad.ciu_id order by pac_apellido, pac_nombre", opr_conexion.conn_sql)
        LeerPaciente = New DataSet()
        oda_paciente.Fill(LeerPaciente, "Registros")
        LeerPaciente.Dispose()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Pacientes", Err)
        Err.Clear()
    End Function


    Public Function buscapacienteHC(ByVal doc As String, ByRef pac_hc As String, ByRef pacienteA As String, ByRef pacienteN As String, ByRef edad As String, ByRef pacdireccion As String, ByRef pacsexo As String, ByRef usafec As Integer, ByRef afiliacion As String, ByRef fechanac As Date, ByRef fecing As String, ByRef pac_id As String, ByRef grado As String, ByRef PAC_FONO As String)
        'Procedimiento para buscar  un paceinte con su HC
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        'Dim str_sql As String = "Select pac_hist_clinica, concat(pac_apellido,' ', pac_nombre) as Paciente, pac_fecnac as Fechanac, paciente.PAC_DIRECCION, paciente.PAC_SEXO from paciente where pac_doc = '" & doc & "'"
        Dim str_sql As String = "Select pac_id, pac_doc, pac_tipodoc,  pac_apellido , pac_nombre, pac_direccion, ciu_nombre, pac_fono, pac_fecnac, pac_sexo, pac_obs, pac_mail, PAC_HIST_CLINICA, PAC_USAFECNAC, pac_obs, pac_parentesco, pac_usafecnac, pac_grado, pac_fecing " & _
                                "from paciente where pac_doc = '" & doc & "' order by pac_apellido, pac_nombre;"
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_operacion.Read
            pac_id = odr_operacion.GetValue(0).ToString()
            pac_hc = odr_operacion.GetValue(12).ToString()
            pacienteA = odr_operacion.GetString(3).ToString()
            pacienteN = odr_operacion.GetString(4).ToString()
            fechanac = odr_operacion.GetDateTime(8)
            pacdireccion = odr_operacion.GetString(5)
            pacsexo = odr_operacion.GetString(9)
            usafec = CInt(odr_operacion.GetValue(13))
            afiliacion = odr_operacion.GetString(14)
            grado = odr_operacion.GetString(17)
            fecing = odr_operacion.GetDateTime(18)
            PAC_FONO = odr_operacion.GetString(7)
            If usafec = 1 Then
                'Dim edad As String
                Dim fecha As Date
                fecha = CDate(fechanac)
                '**********
                'funcion para calcular la edad del paciente
                Dim y, yn As Integer
                Dim m, mn As Integer
                Dim d, dn As Integer
                y = Year(Now)
                yn = Year(fecha)
                m = Month(Now)
                mn = Month(fecha)
                d = Microsoft.VisualBasic.Day(Now)
                dn = Microsoft.VisualBasic.Day(fecha)
                If dn <= d Then
                    d = d - dn
                Else
                    d = d + 30
                    m = m - 1
                    d = d - dn
                End If
                If mn <= m Then
                    m = m - mn
                Else
                    m = m + 12
                    y = y - 1
                    m = m - mn
                End If
                y = y - yn
                If (y < 2) Then
                    If y < 1 Then
                        If m > 0 Then
                            edad = m & " meses"
                        Else
                            edad = d & " dias"
                        End If
                    Else
                        edad = y & " año y " & m & " meses"
                    End If
                Else
                    edad = y & " años "
                End If
                '**********
            Else
                edad = "--"
            End If


        End While
        'edad = System.DateTime.Now.Year - fechanac.Year
        opr_conexion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, buscar paciente", Err)
        Err.Clear()
    End Function


    Public Function buscapacienteAgendaMedica(ByVal doc As String, ByRef edad As String, ByRef unidad As String, ByRef pac_dir As String, ByRef pac_sexo As String, ByRef pac_fecnac As Date, ByRef PAC_FONO As String, ByRef pac_email As String)

        'Procedimiento para buscar  un paceinte con su HC
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Select pac_fecnac, pac_sexo, pac_fono, pac_obs, pac_mail, pac_grado, pac_direccion from paciente where pac_doc = '" & doc & "'"
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_operacion.Read
            pac_fecnac = odr_operacion.GetDateTime(0)
            pac_sexo = odr_operacion.GetString(1)
            PAC_FONO = odr_operacion.GetString(2)
            pac_email = odr_operacion.GetString(4)
            pac_dir = odr_operacion.GetString(6)

            Dim fecha As Date
            fecha = CDate(pac_fecnac)
            '**********
            'funcion para calcular la edad del paciente
            Dim y, yn As Integer
            Dim m, mn As Integer
            Dim d, dn As Integer
            y = Year(Now)
            yn = Year(fecha)
            m = Month(Now)
            mn = Month(fecha)
            d = Microsoft.VisualBasic.Day(Now)
            dn = Microsoft.VisualBasic.Day(fecha)
            If dn <= d Then
                d = d - dn
            Else
                d = d + 30
                m = m - 1
                d = d - dn
            End If
            If mn <= m Then
                m = m - mn
            Else
                m = m + 12
                y = y - 1
                m = m - mn
            End If
            y = y - yn
            If (y < 2) Then
                If y < 1 Then
                    If m > 0 Then
                        edad = m & " meses"
                    Else
                        edad = d & " dias"
                    End If
                Else
                    edad = y & " año y " & m & " meses"
                End If
            Else
                edad = y & " años "
            End If
            '**********
            Dim param_edad As String()

            param_edad = Split(edad, " ")
            edad = param_edad(0)
            unidad = param_edad(1)
        End While
        'edad = System.DateTime.Now.Year - fechanac.Year
        opr_conexion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, buscar paciente", Err)
        Err.Clear()
    End Function


    Public Function buscamaxHC() As Integer
        'funcion que retorna el maximo codigo de un paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        buscamaxHC = CInt(New SqlCommand("Select isnull(max(pac_id),0) from paciente", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Codigo paciente", Err)
        Err.Clear()
    End Function


    Public Function CuentaHistorico(ByVal pac_id As String) As Integer
        'procedimiento que consulta un producto especifico, para llenar sus datos en el grid de movimiento
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String = "Select count(ped_id) from pedido,paciente where pedido.PAC_ID = paciente.PAC_ID and paciente.pac_doc = '" & pac_id & "' and pedido.ped_estado NOT in(2);"
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            CuentaHistorico = CInt(odr_operacion.GetValue(0))
        End While
        opr_conexion.sql_desconn()
    End Function



    ''    Public Function buscaHistoricoOrdenes(ByVal pac_id As String) As Integer
    ''        'funcion que retorna el historico de paciente
    ''        On Error GoTo MsgError
    ''        Dim opr_conexion As New Cls_Conexion()
    ''        opr_conexion.sql_conectar()

    ''        buscaHistoricoOrdenes = CInt(New SqlCommand("Select count(ped_id) from pedido,paciente where pedido.PAC_ID = paciente.PAC_ID and paciente.pac_doc = '" & pac_id & "' and pedido.ped_estado not in(0,2);", opr_conexion.conn_sql).ExecuteScalar)
    ''        opr_conexion.sql_desconn()
    ''        Exit Function
    ''MsgError:
    ''        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Busca Historico", Err)
    ''        Err.Clear()
    ''    End Function



    Public Function LeerUnPaciente(ByVal ped_id As Long) As DataSet
        'funcion que devuelve los datos de un paciente en un dataset,recibe el codigo de un determinado pedido
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_paciente.SelectCommand = New SqlCommand("Select pac_apellido, pac_nombre, pedido.ped_medicacion, pac_sexo, pac_doc, pac_hist_clinica, PAC_USAFECNAC, pac_fecnac, pedido.PED_TIPO, pedido.PED_NUMAUX, pedido.PED_SERVICIO from paciente, pedido where paciente.pac_id=pedido.pac_id and ped_id=" & ped_id, opr_conexion.conn_sql)
        LeerUnPaciente = New DataSet()
        oda_paciente.Fill(LeerUnPaciente, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Paciente", Err)
        Err.Clear()
    End Function


    Public Function calcula_edad(ByVal fechanac As Date) As String
        'funcion para calcular la edad del paciente
        Dim y, yn As Integer
        Dim m, mn As Integer
        Dim d, dn As Integer
        calcula_edad = ""
        y = Year(Now)
        yn = Year(fechanac)
        m = Month(Now)
        mn = Month(fechanac)
        d = Microsoft.VisualBasic.Day(Now)
        dn = Microsoft.VisualBasic.Day(fechanac)
        If dn <= d Then
            d = d - dn
        Else
            d = d + 30
            m = m - 1
            d = d - dn
        End If
        If mn <= m Then
            m = m - mn
        Else
            m = m + 12
            y = y - 1
            m = m - mn
        End If
        y = y - yn
        If (y < 2) Then
            If y < 1 Then
                If m > 0 Then
                    calcula_edad = (m & " meses")
                Else
                    calcula_edad = (d & " dias")
                End If
            Else
                calcula_edad = (y & " anio y " & m & " meses")
            End If
        Else
            calcula_edad = (y & " anios ")
        End If
    End Function



    Public Function LeerUnPaciente_PARAMETRO(ByVal parametro As String, ByVal tipo As Byte) As DataSet
        'funcion que devuelve los datos de uno o varios paciente en un dataset,recibe el/los apellido/s o el numero de cedula
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        ' SI tipo = 0 entonces se busca por apellidos 
        Dim STR_SQL As String
        If tipo = 0 Then
            STR_SQL = "Select pac_id, pac_doc, pac_tipodoc,  pac_apellido, pac_nombre, pac_direccion, pac_fono, pac_fecnac, pac_sexo, pac_obs, pac_mail, PAC_HIST_CLINICA, PAC_USAFECNAC, pac_grado, pac_parentesco,  pac_poliza, paciente.pac_pais, paciente.pac_profesion, PAC_CONOCIO_FUENTE, PAC_CONOCIO_OTRO, PAC_CONOCIO_FAMILIA, PROV_ID, CIU_ID, PROV_NOMBRE, CIU_NOMBRE, PROV_ID_VIVE, CIU_ID_VIVE, PROV_NOMBRE_VIVE, CIU_NOMBRE_VIVE, PAC_LUGARVIVE " & _
                      "from paciente where pac_apellido like '" & parametro & "%' order by pac_apellido, pac_nombre"
        ElseIf tipo = 1 Then
            STR_SQL = "Select pac_id, pac_doc, pac_tipodoc,  pac_apellido, pac_nombre, pac_direccion, pac_fono, pac_fecnac, pac_sexo, pac_obs, pac_mail, PAC_HIST_CLINICA, PAC_USAFECNAC, pac_grado, pac_parentesco,  pac_poliza, paciente.pac_pais, paciente.pac_profesion, PAC_CONOCIO_FUENTE, PAC_CONOCIO_OTRO, PAC_CONOCIO_FAMILIA, PROV_ID, CIU_ID, PROV_NOMBRE, CIU_NOMBRE, PROV_ID_VIVE, CIU_ID_VIVE, PROV_NOMBRE_VIVE, CIU_NOMBRE_VIVE, PAC_LUGARVIVE " & _
                      "from paciente where pac_apellido like '" & parametro & "%' order by pac_apellido, pac_nombre"
        Else
            STR_SQL = "Select pac_id, pac_doc, pac_tipodoc,  pac_apellido, pac_nombre, pac_direccion, pac_fono, pac_fecnac, pac_sexo, pac_obs, pac_mail, PAC_HIST_CLINICA, PAC_USAFECNAC, pac_grado, pac_parentesco,  pac_poliza, paciente.pac_pais, paciente.pac_profesion, PAC_CONOCIO_FUENTE, PAC_CONOCIO_OTRO, PAC_CONOCIO_FAMILIA, PROV_ID, CIU_ID, PROV_NOMBRE, CIU_NOMBRE, PROV_ID_VIVE, CIU_ID_VIVE, PROV_NOMBRE_VIVE, CIU_NOMBRE_VIVE, PAC_LUGARVIVE " & _
                      "from paciente where pac_apellido like '" & parametro & "%' order by pac_apellido, pac_nombre"
        End If
        oda_paciente.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerUnPaciente_PARAMETRO = New DataSet()
        oda_paciente.Fill(LeerUnPaciente_PARAMETRO, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Paciente por parametro", Err)
        Err.Clear()
    End Function


    Sub LlenarGridPaciente(ByRef data As DataView)
        'llena un datagrid con los datos de TODOS los pacientes
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPaciente().Tables("Registros")
    End Sub


    Sub LlenarGridPaciente2(ByRef dgrd_paciente As DataGrid, ByVal pac_apellido As String)
        'llena un datagrid con los datos de los pacientes SEGUN UN PARAMETRO.
        On Error Resume Next
        Dim dts_paciente As DataSet
        Dim dtv_paciente As New DataView()
        dts_paciente = LeerUnPaciente_PARAMETRO(Trim(pac_apellido), 0)
        With dtv_paciente
            .Table = dts_paciente.Tables("Registros")
            'If pac_apellido <> "" Then
            '    .RowFilter = "pac_apellido like '" & pac_apellido & "*'"
            'End If
            .Sort = "pac_apellido"

        End With
        dts_paciente.Dispose()
        dgrd_paciente.DataSource = dtv_paciente
        dgrd_paciente.NavigateTo(0, "Registros")
        dgrd_paciente.CaptionText = "PACIENTES"
    End Sub



    Sub ordena_apellido(ByVal apellido As String, ByRef data As DataView)
        'funci�n que orderna por apellido al dataview
        With data
            If Trim(apellido) <> "" Then
                .RowFilter = "pac_apellido like '" & Trim(apellido) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "pac_apellido"
        End With
    End Sub
    Sub ordena_cedula(ByVal cedula As String, ByRef data As DataView)
        'funci�n que orderna por apellido al dataview
        With data
            If Trim(cedula) <> "" Then
                .RowFilter = "pac_doc like '" & Trim(cedula) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "pac_apellido"
        End With
    End Sub


    Sub LlenarGridPaciente_cedu(ByRef dgrd_paciente As DataGrid, ByVal pac_cedula As String)
        'llena un datagrid con los datos de los pacientes
        On Error Resume Next
        Dim dts_paciente As DataSet
        Dim dtv_paciente As New DataView()
        dts_paciente = LeerUnPaciente_PARAMETRO(pac_cedula, 1)
        With dtv_paciente
            .Table = dts_paciente.Tables("Registros")
            'If pac_cedula <> "" Then
            '    .RowFilter = "pac_doc like '" & pac_cedula & "*'"
            'End If
            .Sort = "pac_doc"
        End With
        dgrd_paciente.DataSource = dtv_paciente
        dgrd_paciente.NavigateTo(0, "Registros")
        dgrd_paciente.CaptionText = "PACIENTES"
    End Sub

    Sub LlenarGridPaciente_hisclin(ByRef dgrd_paciente As DataGrid, ByVal pac_hisclin As String)
        'llena un datagrid con los datos de los pacientes con busqueda por his. clinica
        On Error Resume Next
        Dim dts_paciente As DataSet
        Dim dtv_paciente As New DataView()
        dts_paciente = LeerUnPaciente_PARAMETRO(pac_hisclin, 2)
        With dtv_paciente
            .Table = dts_paciente.Tables("Registros")
            'If pac_cedula <> "" Then
            '    .RowFilter = "pac_doc like '" & pac_cedula & "*'"
            'End If
            .Sort = "PAC_HIST_CLINICA"
        End With
        dgrd_paciente.DataSource = dtv_paciente
        dgrd_paciente.NavigateTo(0, "Registros")
        dgrd_paciente.CaptionText = "PACIENTES"
    End Sub

    Public Sub GuardarPaciente(ByVal pac_id As Long, ByVal pac_doc As String, ByVal pac_tipodoc As Single, ByVal pac_apellido As String, ByVal pac_nombre As String, ByVal pac_direccion As String, ByVal pac_fono As String, ByVal pac_sexo As String, ByVal pac_fecnac As Date, ByVal pac_fecing As Date, ByVal pac_obs As String, ByVal ciu_id As Integer, ByVal pac_mail As String, ByVal his_clinica As String, ByVal usa_fecnac As Short, ByVal pac_grado As String, ByVal pac_parentesco As String, ByVal var_life As Integer, ByVal pac_pais As String, ByVal pac_profesion As String, ByVal PAC_CONOCIO_FUENTE As String, ByVal PAC_CONOCIO_OTRO As String, ByVal PAC_CONOCIO_FAMILIA As String, ByVal PROV_ID As Integer, ByVal PROV_NOMBRE As String, ByVal CIU_NOMBRE As String, ByVal PROV_ID_VIVE As Integer, ByVal CI_ID_VIVE As Integer, ByVal PROV_NOMBRE_VIVE As String, ByVal CIU_NOMBRE_VIVE As String, ByVal PAC_LUGARVIVE As String)


        'procedimiento que guarda en la base los datos de un nuevo paciente
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "insert into paciente(pac_id, pac_doc, pac_tipodoc, pac_apellido, pac_nombre, pac_direccion, pac_fono, pac_sexo, pac_fecnac, pac_fecing, pac_obs, pac_mail, pac_hist_clinica, pac_usafecnac, pac_grado, pac_parentesco, pac_poliza, pac_pais, pac_profesion, " & _
        "PAC_CONOCIO_FUENTE, PAC_CONOCIO_OTRO, PAC_CONOCIO_FAMILIA, PROV_ID, CIU_ID, PROV_NOMBRE, CIU_NOMBRE, PROV_ID_VIVE, CIU_ID_VIVE, PROV_NOMBRE_VIVE, CIU_NOMBRE_VIVE, PAC_LUGARVIVE) values(" & _
        pac_id & ",'" & pac_doc & "'," & pac_tipodoc + 1 & ",'" & pac_apellido & "','" & _
        pac_nombre & "','" & pac_direccion & "','" & pac_fono & "','" & pac_sexo & "'," & _
        "'" & Format(pac_fecnac, "dd/MM/yyyy") & "','" & Format(pac_fecing, "dd/MM/yyyy") & "','" & pac_obs & "','" & pac_mail & _
        "', '" & his_clinica & "', " & usa_fecnac & ", '" & pac_grado & "', '" & pac_parentesco & "', " & var_life & ",'" & pac_pais & "','" & pac_profesion & _
        "','" & PAC_CONOCIO_FUENTE & "','" & PAC_CONOCIO_OTRO & "','" & PAC_CONOCIO_FAMILIA & "', " & PROV_ID & ", " & ciu_id & ",'" & Trim(PROV_NOMBRE) & "', '" & Trim(CIU_NOMBRE) & "', " & PROV_ID_VIVE & "," & CI_ID_VIVE & ", '" & Trim(PROV_NOMBRE_VIVE) & "', '" & Trim(CIU_NOMBRE_VIVE) & "','" & Trim(PAC_LUGARVIVE) & "')"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Generar Paciente", "Paciente=" & pac_apellido & " " & pac_nombre, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ingreso de registro", Err)
        Err.Clear()
    End Sub

    Public Function LeerMaxPaciente() As Integer
        'funcion que retorna el mAximo codigo de un paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxPaciente = CInt(New SqlCommand("Select isnull(Max(pac_id),0) from paciente", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Codigo paciente", Err)
        Err.Clear()
    End Function

    Public Function ComprobarDocPaciente(ByVal pac_doc As String) As Byte
        'compruba la existencia del documento del paciente este documento puede set
        'cedula, pasaporte, ruc
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ComprobarDocPaciente = CByte(New SqlCommand("Select count(*) from paciente where pac_doc='" & pac_doc & "'", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, comprobar datos paciente", Err)
        Err.Clear()
    End Function

    Public Function ComprobarNomPaciente(ByVal pac_nombre As String, ByVal pac_apellido As String) As Integer
        'comprueba la existencia de un paciente, comparando por apellido y nombre
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ComprobarNomPaciente = CInt(New SqlCommand("Select isnull(pac_id,0) from paciente where pac_apellido='" & Trim(pac_apellido) & "' and pac_nombre='" & Trim(pac_nombre) & "' LIMIT 0, 1", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, comprobar nombres del paciente", Err)
        Err.Clear()
    End Function

    Public Sub EliminarPaciente(ByVal pac_id As Long)
        'procedimiento para eliminar un paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_paciente.SelectCommand = New SqlCommand("delete  from paciente where pac_id=" & pac_id, opr_conexion.conn_sql)
        Dim eliminar As DataSet
        eliminar = New DataSet()
        oda_paciente.Fill(eliminar, "Registros")
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Elimina Paciente", "Paciente=" & pac_id)
        MsgBox("El paciente fue eliminado", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al tratar de eliminar el registro", Err)
        Err.Clear()
    End Sub

    Function buscapaciente(ByVal pac_id As String) As String
        'Procedimiento para eliminar un Medico
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        If IsNothing(New SqlCommand("select pac_doc from paciente where pac_id = " & pac_id, cls_operacion.conn_sql).ExecuteScalar) Then
            buscapaciente = 1
        Else
            buscapaciente = 2
        End If
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, buscar paciente", Err)
        Err.Clear()
    End Function



    Function Devuelvepaciente(ByVal pac_id As String) As String
        'Procedimiento para eliminar un Medico
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select pac_doc, (pac_apellido + ' ' + pac_nombre) as pac_paciente from paciente where pac_id = " & pac_id & ""
        cls_operacion.sql_conectar()
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_parametros.Read
            Devuelvepaciente = odr_parametros.GetValue(0) & "º" & odr_parametros.GetValue(1)
        End While
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, devuelve paciente", Err)
        Err.Clear()
    End Function

    Function buscapacienteCed(ByVal pac_doc As String) As String
        'Procedimiento para eliminar un Medico
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        If IsNothing(New SqlCommand("select pac_id from paciente where pac_doc = '" & pac_doc & "'", cls_operacion.conn_sql).ExecuteScalar) Then
            buscapacienteCed = 0
        Else
            buscapacienteCed = 1
        End If
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, buscar paciente cedula", Err)
        Err.Clear()
    End Function


    Public Sub ActualizarPaciente(ByVal pac_id As Long, ByVal pac_doc As String, ByVal pac_tipodoc As Single, ByVal pac_apellido As String, ByVal pac_nombre As String, ByVal pac_direccion As String, ByVal pac_fono As String, ByVal pac_fecnac As Date, ByVal pac_sexo As String, ByVal pac_obs As String, ByVal pac_mail As String, ByVal his_clinica As String, ByVal usa_fecnac As Short, ByVal pac_grado As String, ByVal pac_parentesco As String, ByVal var_life As Integer, ByVal pac_pais As String, ByVal pac_profesion As String, ByVal PAC_CONOCIO_FUENTE As String, ByVal PAC_CONOCIO_OTRO As String, ByVal PAC_CONOCIO_FAMILIA As String, ByVal PROV_ID As Integer, ByVal CIU_ID As Integer, ByVal PROV_NOMBRE As String, ByVal CIU_NOMBRE As String, ByVal PROV_ID_VIVE As Integer, ByVal CIU_ID_VIVE As Integer, ByVal PROV_NOMBRE_VIVE As String, ByVal CIU_NOMBRE_VIVE As String, ByVal PAC_LUGARVIVE As String)
        'actuliza los datos del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        Dim adrEdit As DataRow()
        str_sql = "update paciente set  pac_doc='" & _
        pac_doc & "', pac_tipodoc=" & pac_tipodoc + 1 & ",pac_apellido='" & pac_apellido & "',pac_nombre='" & _
        pac_nombre & "',pac_direccion='" & pac_direccion & "',pac_fono='" & pac_fono & "'," & _
        "pac_fecnac='" & Format(pac_fecnac, "dd/MM/yyyy") & "', pac_sexo='" & pac_sexo & "', pac_obs='" & pac_obs & "', " & _
        "pac_mail='" & pac_mail & "', pac_hist_clinica = '" & his_clinica & "', pac_usafecnac = " & usa_fecnac & ", pac_grado = '" & pac_grado & "', " & _
        "pac_parentesco= '" & pac_parentesco & "', pac_poliza = " & var_life & ", pac_pais = '" & pac_pais & "', PAC_PROFESION = '" & pac_profesion & "', " & _
        "PAC_CONOCIO_FUENTE = '" & PAC_CONOCIO_FUENTE & "', PAC_CONOCIO_OTRO = '" & PAC_CONOCIO_OTRO & "', PAC_CONOCIO_FAMILIA = '" & PAC_CONOCIO_OTRO & "', " & _
        "PROV_ID = " & PROV_ID & ", CIU_ID = " & CIU_ID & ", PROV_NOMBRE = '" & PROV_NOMBRE & "', CIU_NOMBRE = '" & CIU_NOMBRE & "', PROV_ID_VIVE = " & PROV_ID_VIVE & ", CIU_ID_VIVE = " & CIU_ID_VIVE & ", PROV_NOMBRE_VIVE = '" & PROV_NOMBRE_VIVE & "', CIU_NOMBRE_VIVE = '" & CIU_NOMBRE_VIVE & "', PAC_LUGARVIVE = '" & PAC_LUGARVIVE & "' where pac_id = " & pac_id
        oda_paciente.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        Dim actualizar As DataSet
        actualizar = New DataSet()
        oda_paciente.Fill(actualizar, "Registros")
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza Paciente", "Paciente=" & pac_apellido & " " & pac_nombre, g_sng_user, "", "", "")

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al tratar de actualizar el registro", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarPacienteMail(ByVal pac_id As Long, ByVal pac_mail As String)
        'actuliza mail del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        str_sql = "update paciente set paciente.pac_mail= '" & pac_mail & "' where paciente.pac_id = " & pac_id & ";"

        oda_paciente.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        Dim actualizar As DataSet
        actualizar = New DataSet()
        oda_paciente.Fill(actualizar, "Registros")
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza Mail Paciente", "Paciente=" & pac_id & " " & pac_mail, g_sng_user, "", "", "")

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al tratar de actualizar el registro", Err)
        Err.Clear()
    End Sub





    Public Sub Ingresa_UsrWeb(ByVal pac_id As Long, ByVal usu_login As String, ByVal usu_pass As String)
        'actuliza mail del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        Dim fechaVence As Date
        fechaVence = Format(DateAdd(DateInterval.Day, 30, Now()), "yyyy-MM-dd")
        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        str_sql = "insert into usuario_web values(" & pac_id & ",'" & Trim(usu_login) & "','" & Trim(usu_pass) & "','" & fechaVence & "',1)"

        oda_paciente.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        Dim actualizar As DataSet
        actualizar = New DataSet()
        oda_paciente.Fill(actualizar, "Registros")
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Inserta usuario web", "Paciente=" & pac_id & " " & usu_login, g_sng_user, "", "", "")

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al tratar de actualizar el registro", Err)
        Err.Clear()
    End Sub


    Public Function verifica_usrWeb(ByVal pac_id As Integer) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        str_sql = "select usuario_web.pac_id from usuario_web, paciente where paciente.pac_id = " & pac_id & " and usuario_web.usu_estado = 1 and usuario_web.pac_id = paciente.PAC_ID; "

        opr_conexion.sql_conectar()
        verifica_usrWeb = ""

        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            verifica_usrWeb = verifica_usrWeb & Str(odr_parametros.GetValue(0))
        End While
        

        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, ", Err)
        Err.Clear()
    End Function

    Public Function Busca_usrWeb(ByVal pac_id As Integer) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        str_sql = "select usu_login, usu_pass from usuario_web where pac_id = " & pac_id & " and usu_estado = 1; "

        opr_conexion.sql_conectar()
        Busca_usrWeb = Nothing

        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            Busca_usrWeb = Busca_usrWeb & Trim(odr_parametros.GetValue(0)) & "," & Str(odr_parametros.GetValue(1))
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Busca usrWeb", Err)
        Err.Clear()
    End Function

    Public Function Busca_usrWebCI(ByVal pac_id As Integer) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        str_sql = "select pac_doc from paciente where pac_id = " & pac_id & " ; "

        opr_conexion.sql_conectar()
        Busca_usrWebCI = Nothing

        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            Busca_usrWebCI = Busca_usrWebCI & Str(odr_parametros.GetValue(0))
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Busca usrWeb CI", Err)
        Err.Clear()
    End Function

End Class
