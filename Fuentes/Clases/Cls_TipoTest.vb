'*************************************************************************
' Nombre:   Cls_TipoTest
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla TEST
' Autores:  RFN 
' Fecha de Creaci�n: Agosto del 2002
' Autores:  RFN
' Ultima Modificaci�n: 01/08/2002 /*/ 25/02/2004
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data
Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient



Public Class Cls_TipoTest

    Public Function LeerTest() As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand("SELECT TES_ID, TES_NOMBRE, TES_PRECIO FROM TEST order by TES_nombre", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTest = New DataSet("TEST")
        dt_operacion.Fill(LeerTest, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Function

    Public Function LeerTestDisponibles() As DataSet
        'Funcion para todos los test que se encuentran disponibles en el laboratorio,
        'en estos se encuentran los manuales y los que se encuentran activos por equipos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        cls_operacion.sql_conectar()
        str_sql = "select tes_nombre, test_equipo.tes_id from test_equipo, test where test_equipo.teq_estado = 1 and test.tes_tipo = 'Examen' and test_equipo.tes_id = test.tes_id union select tes_nombre, tes_id from test where tes_tproces = 0 order by tes_nombre asc"
        '"select tes_nombre, test_equipo.tes_id from test_equipo, test where test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id and test.tes_parametro <> 1 union select tes_nombre, tes_id from test where tes_tproces = 0 and tes_parametro <> 1 order by tes_nombre asc"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTestDisponibles = New DataSet()
        dt_operacion.Fill(LeerTestDisponibles, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Disponibles", Err)
        Err.Clear()
    End Function


    Public Function LeerMedicosDisponibles() As DataSet
        'Funcion para todos los test que se encuentran disponibles en el laboratorio,
        'en estos se encuentran los manuales y los que se encuentran activos por equipos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        cls_operacion.sql_conectar()
        str_sql = "select tes_nombre, test_equipo.tes_id from test_equipo, test where test_equipo.teq_estado = 1 and test.tes_tipo = 'Examen' and test_equipo.tes_id = test.tes_id union select tes_nombre, tes_id from test where tes_tproces = 0 order by tes_nombre asc"
        '"select tes_nombre, test_equipo.tes_id from test_equipo, test where test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id and test.tes_parametro <> 1 union select tes_nombre, tes_id from test where tes_tproces = 0 and tes_parametro <> 1 order by tes_nombre asc"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerMedicosDisponibles = New DataSet()
        dt_operacion.Fill(LeerTestDisponibles, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Disponibles", Err)
        Err.Clear()
    End Function

    Public Function guardaTestAsistente(ByVal tes_padre As Integer, ByVal are_id As Integer, ByVal tes_nombre As String, ByVal tim_id As Integer, ByVal tes_nombrefijo As String, ByVal uni_id As Integer, ByVal tes_resdefecto As String, ByVal Nparametros As Integer, ByVal var_nombres As String)
        On Error GoTo MsgError

        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim str_sql As String = Nothing
        Dim ordenImp As Integer
        Dim tes_id As Integer
        Dim i As Integer
        Dim arre_nombres As String()
        opr_Conexion.sql_conectar()

        ordenImp = LeerMaxOrdenImp(tes_padre) + 1
        tes_id = LeerMaxCodTest("Parametro")
        arre_nombres = Split(var_nombres, "º")

        For i = 0 To Nparametros
            odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
            odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            str_sql = "Insert into TEST_RESULTADO values (" & tes_id & ", 2,0,NULL,NULL,NULL)"
            odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()


            str_sql = "Insert into TEST values (" & tes_id + 1 & ", " & are_id & ", '" & arre_nombres(i) & "', '', '0' , '" & Today & "', " & tim_id & ", 1, '" & arre_nombres(i) & "', 0, " & uni_id & "," & ordenImp & " ,0, 1, 'Parametro'," & tes_padre & " ', 0, 0,''," & arre_nombres(i) & " ');"
            opr_Conexion.sql_conectar()
            odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
            odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            odbc_trans.Commit()
            opr_Conexion.sql_desconn()
        Next
MsgError:
        guardaTestAsistente = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar test Asistente", Err)
        Err.Clear()
    End Function

    Public Function LeerParamDisponibles() As DataSet
        'Funcion para todos los test que se encuentran disponibles en el laboratorio,
        'en estos se encuentran los manuales y los que se encuentran activos por equipos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        cls_operacion.sql_Conectar()
        str_sql = "select tes_nombre, test_equipo.tes_id from test_equipo, test where test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id and test.ARE_ID = 22 and test.TES_TIPO = 'Parametro' union select tes_nombre, tes_id from test where tes_tproces = 0 order by tes_nombre asc"
        '"select tes_nombre, test_equipo.tes_id from test_equipo, test where test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id and test.tes_parametro <> 1 union select tes_nombre, tes_id from test where tes_tproces = 0 and tes_parametro <> 1 order by tes_nombre asc"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerParamDisponibles = New DataSet()
        dt_operacion.Fill(LeerParamDisponibles, "Registros2")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Parametros Micro", Err)
        Err.Clear()
    End Function

    Public Function LeerParamMicro() As DataSet
        'Funcion para todos los test que se encuentran disponibles en el laboratorio,
        'en estos se encuentran los manuales y los que se encuentran activos por equipos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        cls_operacion.sql_Conectar()
        str_sql = "select distinct(test.TES_ID), test.tes_nombre from test_cultivo, test where test_cultivo.tes_id = test.tes_id and test.TES_TIPO = 'Parametro';"
        '"select tes_nombre, test_equipo.tes_id from test_equipo, test where test_equipo.teq_estado = 1 and test_equipo.tes_id = test.tes_id and test.tes_parametro <> 1 union select tes_nombre, tes_id from test where tes_tproces = 0 and tes_parametro <> 1 order by tes_nombre asc"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerParamMicro = New DataSet()
        dt_operacion.Fill(LeerParamMicro, "Registros3")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Parametros Micro", Err)
        Err.Clear()
    End Function

    Public Function LeerParamFormatos(ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        cls_operacion.sql_conectar()

        str_sql = "select area.ARE_NOMBRE, t.TES_ID, t.TES_NOMBRE " & _
                "from test as t, test_resultado as tr, area " & _
                "where tr.RES_ID = " & tes_id & " and " & _
                "t.TES_ID = tr.TES_ID and " & _
                "area.are_id = t.are_id;"

        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerParamFormatos = New DataSet("FORMATO")
        dt_operacion.Fill(LeerParamFormatos, "Registros")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test tipo Formato", Err)
        Err.Clear()
    End Function


    Public Function LeerTestFormatos(ByVal filtro As Integer, ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        cls_operacion.sql_conectar()

        str_sql = "select area.ARE_NOMBRE, t.TES_ID, t.TES_NOMBRE " & _
                "from test as t, test_resultado as tr, area " & _
                "where tr.RES_ID = " & filtro & " and t.tes_id = " & tes_id & " " & _
                "and t.TES_ID = tr.TES_ID and " & _
                "area.are_id = t.are_id;"

        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTestFormatos = New DataSet("FORMATO")
        dt_operacion.Fill(LeerTestFormatos, "Registros")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test tipo Formato", Err)
        Err.Clear()
    End Function


    Public Function LeerTestArea(ByVal filtro As Boolean) As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        cls_operacion.sql_conectar()
        If filtro Then
            str_sql = "SELECT TEST.TES_ID, TEST.TES_NOMBRE, TEST.TES_PRECIO, TEST.ARE_ID, AREA.ARE_NOMBRE, TEST.TES_TPROCES, TEST.TES_TIPOREPORTE AS TREPORTE, TES_CODBARRAS, TES_TIPO, TES_PADRE, TES_AB, TES_CALC, TES_RESDEFECTO, test_resultado.RES_ID FROM AREA, TEST, test_resultado WHERE AREA.ARE_ID = TEST.ARE_ID and test_resultado.tes_id = test.tes_id and test.TES_TIPO <> 'Parametro' order by TEST.TES_NOMBRE;"
        Else
            str_sql = "SELECT TEST.TES_ID, TEST.TES_NOMBRE, TEST.TES_PRECIO, TEST.ARE_ID, AREA.ARE_NOMBRE, TEST.TES_TPROCES, TEST.TES_TIPOREPORTE AS TREPORTE, TES_CODBARRAS, TES_TIPO, TES_PADRE, TES_AB, TES_CALC, TES_RESDEFECTO, test_resultado.RES_ID FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID, test_resultado where test_resultado.TES_ID = test.TES_ID order by TEST.TES_NOMBRE;"
        End If
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTestArea = New DataSet("TEST")
        dt_operacion.Fill(LeerTestArea, "Registros")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Function

    Public Function LeerParametroArea() As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand("SELECT TEST.TES_ID, TEST.TES_NOMBRE, TEST.TES_PRECIO, TEST.ARE_ID, AREA.ARE_NOMBRE, TEST.TES_TPROCES, TEST.TES_TIPOREPORTE AS TREPORTE, TES_CODBARRAS, TES_TIPO, TES_PADRE, TES_AB, TES_CALC, TES_RESDEFECTO FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID WHERE test.TES_TIPO = 'Parametro' order by TEST.TES_NOMBRE;", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerParametroArea = New DataSet("TEST")
        dt_operacion.Fill(LeerParametroArea, "Registros")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Function


    Public Function LeerTestArea(ByVal are_id As Integer) As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        cls_operacion.sql_conectar()

        str_sql = "SELECT TEST.TES_ID, TEST.TES_NOMBRE,  TEST.ARE_ID, AREA.ARE_NOMBRE FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID and area.ARE_ID = " & are_id & " order by test.TES_ID, test.TES_ORDENIMP, TEST.TES_NOMBRE;"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTestArea = New DataSet("TEST")
        dt_operacion.Fill(LeerTestArea, "Registros")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Function


    Public Function LeerAutoCompletar(ByVal test As Integer) As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()
        oda_operacion.SelectCommand = New SqlCommand("SELECT TA.AUTO_ID, TA.AUTO_NOMBRE, TA.TES_ID, T.TES_NOMBRE FROM tipo_autocompletar AS TA, TEST AS T WHERE TA.TES_ID = T.TES_ID AND TA.TES_ID = " & test & " order by TA.TES_ID;", opr_Conexion.conn_sql)
        LeerAutoCompletar = New DataSet("AUTOCOMPLETE")

        oda_operacion.Fill(LeerAutoCompletar, "Registros2")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer AutoCompletar", Err)
        Err.Clear()

    End Function

    Public Function LeerAntibiotico() As DataSet
        'Funcion para la consultar los datos de la tabla ANTIBIOTICO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()
        oda_operacion.SelectCommand = New SqlCommand("select antibiotico.ANB_ID, antibiotico.ANB_NOMBRE, antibiotico.ANB_CODIGO, antibiotico.ANB_ORDEN  from antibiotico where antibiotico.ANB_ESTADO = 1;", opr_Conexion.conn_sql)
        LeerAntibiotico = New DataSet("ANTIBIOTICO")

        oda_operacion.Fill(LeerAntibiotico, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer ANTIBIOTICO", Err)
        Err.Clear()

    End Function

    Public Function LeerEstCultivo() As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_Conectar()
        Dim BDCmd = New SqlCommand("SELECT TEST.TES_ID, TEST.TES_NOMBRE, TEST.TES_TIPO, TEST.TIM_ID FROM TEST, AREA, TEST_RESULTADO WHERE AREA.ARE_ID = TEST.ARE_ID AND TEST.TES_ID = TEST_RESULTADO.TES_ID AND TES_AB = 1 AND AREA.ARE_ID = 22 AND TEST_RESULTADO.RES_ID = 8 order by TEST.TES_NOMBRE;", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerEstCultivo = New DataSet("TEST")
        dt_operacion.Fill(LeerEstCultivo, "Registros")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Function

    Public Function LeerTestHijosAB(ByVal tes_id As Integer) As DataSet
        '
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_Conectar()
        Dim BDCmd = New SqlCommand("SELECT TEST.TES_ID, TEST.TES_NOMBRE, TEST.TES_PRECIO, TEST.ARE_ID, AREA.ARE_NOMBRE, TEST.TES_TPROCES, TEST.TES_TIPOREPORTE AS TREPORTE, TES_CODBARRAS, TES_TIPO, TES_PADRE, TES_RESDEFECTO FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID WHERE TEST.TES_PADRE = " & tes_id & " order by TEST.TES_NOMBRE, TEST.TES_ID;", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTestHijosAB = New DataSet("TESTH")
        dt_operacion.Fill(LeerTestHijosAB, "Registros2")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Parametros", Err)
        Err.Clear()
    End Function


    Public Function LeerTestHijos(ByVal tes_id As Integer) As DataSet
        '
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_Conectar()
        'Dim BDCmd = New SqlCommand("SELECT  test.TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, TEST.TES_PRECIO, TEST.ARE_ID, AREA.ARE_NOMBRE, TEST.TES_TPROCES, TEST.TES_TIPOREPORTE AS TREPORTE, TES_CODBARRAS, TES_TIPO, TES_PADRE, TES_RESDEFECTO FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID WHERE TEST.TES_PADRE = " & tes_id & " and TEST.TES_TIPO = 'Parametro' order by TEST.TES_ORDENIMP, TEST.TES_NOMBRE, TEST.TES_ID;", cls_operacion.conn_sql)

        Dim BDCmd = New SqlCommand("SELECT test.TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, TEST.TES_PRECIO, TEST.ARE_ID, AREA.ARE_NOMBRE, TEST.TES_TPROCES, TEST.TES_TIPOREPORTE AS TREPORTE, TES_CODBARRAS, TES_TIPO, TES_PADRE, TES_RESDEFECTO FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID WHERE (TEST.TES_PADRE = " & tes_id & " or  TEST.TES_ID = " & tes_id & ") and TEST.TES_TIPO in ('Parametro','Examen') order by TEST.TES_ORDENIMP, TEST.TES_NOMBRE, TEST.TES_ID;", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTestHijos = New DataSet("TESTH")
        dt_operacion.Fill(LeerTestHijos, "Registros2")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Parametros", Err)
        Err.Clear()
    End Function


    Public Function LeerTestRangos(ByVal tes_id As Integer) As DataSet
        '
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing

        cls_operacion.sql_conectar()
        str_sql = "select test.TES_ID, " & _
            "CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, " & _
            "test_equipo.TEQ_ABRV_FIJA,test_equipo.TEQ_ABREVIATURA,test_equipo.TEQ_RANMIN,test_equipo.TEQ_RANMAX, " & _
            "test_equipo.TEQ_RANMUL, unidad.UNI_NOMENCLATURA, test_equipo.TEQ_ID, test_equipo.TEQ_TRANGO, test.TES_ORDENIMP, test_equipo.EQU_ID, unidad.UNI_ID, test.TES_LIS " & _
            "from test, test_equipo, unidad " & _
            "where(test.TES_ID = test_equipo.TES_ID) and unidad.UNI_ID = test.UNI_ID " & _
            "and (test.tes_ID = " & tes_id & " or test.TES_PADRE = " & tes_id & ") " & _
            "AND test.TES_TIPO IN('Examen','Parametro') " & _
            "order by test.TES_ORDENIMP, test.TES_NOMBRE asc "

        'str_sql = "select test.TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, " & _
        '            "test.TES_RESDEFECTO, unidad.UNI_NOMENCLATURA, test_equipo.TEQ_ID from test, test_equipo, unidad " & _
        '            "where(test.TES_ID = test_equipo.TES_ID) and unidad.UNI_ID = test.UNI_ID " & _
        '            "and (test.tes_ID = " & tes_id & " or test.TES_PADRE = " & tes_id & ") " & _
        '            "AND test.TES_TIPO IN('Examen','Parametro')  order by test.TES_ORDENIMP, test.TES_NOMBRE asc "

        'str_sql = "SELECT test.TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, " & _
        '         "TEST.TES_RESDEFECTO, '' AS UNI_NOMENCLATURA, '' as TEQ_ID " & _
        '        " FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID WHERE (TEST.TES_PADRE = " & tes_id & " or  TEST.TES_ID = " & tes_id & ") and TEST.TES_TIPO in ('Parametro','Examen') order by TEST.TES_ORDENIMP, TEST.TES_NOMBRE, TEST.TES_ID;"

        'str_sql = "SELECT test.TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, " & _
        '        "TEST.TES_RESDEFECTO, '' AS TEQ_ABRV_FIJA, '' AS TEQ_ABREVIATURA, '' AS TEQ_RANMIN, '' AS TEQ_RANMAX, " & _
        '        "'' AS TEQ_RANMUL, '' AS UNI_NOMENCLATURA, '' AS TEQ_ID, '' AS TEQ_TRANGO, test.TES_ORDENIMP, " & _
        '        "'' AS EQU_ID " & _
        '        "FROM AREA INNER JOIN TEST ON AREA.ARE_ID = TEST.ARE_ID " & _
        '        "Where (test.tes_ID = " & tes_id & " or test.TES_PADRE = " & tes_id & ") " & _
        '        "and TEST.TES_TIPO in ('Parametro','Examen') " & _
        '        "order by TEST.TES_ORDENIMP, TEST.TES_NOMBRE, TEST.TES_ID;"

        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerTestRangos = New DataSet("TESTH")
        dt_operacion.Fill(LeerTestRangos, "Registros2")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Parametros", Err)
        Err.Clear()
    End Function


    Public Function ConsultaNombreTest(ByVal tes_id As Integer) As String
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "Select tes_nombre, tes_id from TEST where tes_id =" & tes_id
        cls_operacion.sql_Conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            ConsultaNombreTest = odr_operacion.GetString(0).PadRight(100) & CStr(odr_operacion.GetValue(1)).PadRight(10)
        End While

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTest", Err)
        Err.Clear()
    End Function

    Public Function ConsultaTimId(ByVal tes_id As Integer) As Integer
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "Select tim_id, tes_id from TEST where tes_id =" & tes_id
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            ConsultaTimId = odr_operacion.GetValue(0)
        End While

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer tim", Err)
        Err.Clear()
    End Function


    Public Function ConsultaAreaTest(ByVal tes_id As Integer) As String
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "Select area.ARE_NOMBRE, area.Are_id from TEST, area where area.are_id = test.ARE_ID and tes_id = " & tes_id
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            ConsultaAreaTest = odr_operacion.GetString(0).PadRight(100) & CStr(odr_operacion.GetValue(1)).PadRight(10)
        End While

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTest", Err)
        Err.Clear()
    End Function


    Public Function ConsultaCostoTest(ByVal tes_id As Integer, ByVal convenio As String) As String
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select lista_precio.LIP_PRECIO from test, lista_precio where test.TES_ID = lista_precio.TES_ID and lista_precio .CON_NOMBRE = '" & convenio & "' and lista_precio.TES_ID = " & tes_id & ""
        'Dim str_sql As String = "Select area.ARE_NOMBRE, area.Are_id from TEST, area where area.are_id = test.ARE_ID and tes_id = " & tes_id
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            ConsultaCostoTest = CStr(odr_operacion.GetSqlDouble(0).ToString)
        End While

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer precio examen", Err)
        Err.Clear()
    End Function


    Public Function BuscarMuestra(ByVal tim_id As Integer) As String
        'Funci�n para consultar si existe el nombre de un test antes de insertar otra igual 
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand("select tim_nombre from tipo_muestra where tim_id  = " & tim_id & "", cls_operacion.conn_sql).ExecuteReader
        Dim act As New DataSet()
        Dim dtrow As DataRow
        dt_operacion.Fill(act, "Registros")
        For Each dtrow In act.Tables("Registros").Rows
            BuscarMuestra = dtrow(0)
        Next
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar MUESTRA", Err)
        Err.Clear()
    End Function

    Public Function ConsultarTest(ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar los datos de  un test espec�fico en funci�n de su ID
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand("SELECT tes_nombre, tes_obs, tes_precio FROM TEST where tes_id = " & tes_id & "", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        ConsultarTest = New DataSet("TEST")
        dt_operacion.Fill(ConsultarTest, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Consultar Test", Err)
        Err.Clear()
    End Function

    Public Function ConsultarTest1(ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar los datos de  un test espec�fico en funci�n de su ID
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand("SELECT tes_nombre, tes_obs, tes_precio, are_id, tes_padre FROM TEST where tes_id = " & tes_id & "", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        ConsultarTest1 = New DataSet("TEST")
        dt_operacion.Fill(ConsultarTest1, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Consultar Test", Err)
        Err.Clear()
    End Function

    Public Function ConsultarTest_resultado(ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar los tipos de resultados de un test espec�fico en funci�n de su ID
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim str_sql As String = ""
        str_sql = "SELECT TEST_RESULTADO.RES_ID, UNIDAD.UNI_NOMENCLATURA, TEST_RESULTADO.RANG_TIPO, TEST_RESULTADO.RANG_MIN, TEST_RESULTADO.RANG_MAX, TEST_RESULTADO.RANG_MUL FROM UNIDAD INNER JOIN (TEST INNER JOIN TEST_RESULTADO ON TEST.TES_ID = TEST_RESULTADO.TES_ID) ON UNIDAD.UNI_ID = TEST.UNI_ID WHERE (((TEST_RESULTADO.TES_ID)=" & tes_id & "))"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        ConsultarTest_resultado = New DataSet()
        dt_operacion.Fill(ConsultarTest_resultado, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Consultar Test Resultado", Err)
        Err.Clear()
    End Function

    Public Function ConsultarTest_TipMuestra(ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar los tipos de muestras de un test espec�fico en funci�n de su ID
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        str_sql = "SELECT TEST.TIM_ID, TEST.TES_ID, TEST.TES_NOMBRE, tipo_muestra.TIM_NOMBRE FROM TEST, tipo_muestra WHERE TEST.TES_ID = " & tes_id & " AND tipo_muestra.TIM_ID = test.TIM_ID ;"
        cls_operacion.sql_conectar()
        'Dim BDCmd = New SqlCommand("SELECT tim_id FROM TEST_TIPMUESTRA where tes_id = " & tes_id & "", cls_operacion.conn_sql)
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        ConsultarTest_TipMuestra = New DataSet("TEST")
        dt_operacion.Fill(ConsultarTest_TipMuestra, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Consultar Test TipMuestra", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodTest(ByVal tipo As String) As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxCodTest = CInt(New SqlCommand("Select isnull(Max(tes_id),0) from TEST;", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTest", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodTestParam() As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxCodTestParam = CInt(New SqlCommand("Select isnull(Max(tes_id),0) from TEST where tes_id between 500 and 3000;", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTest", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxCodTestParamCul() As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxCodTestParamCul = CInt(New SqlCommand("Select isnull(Max(tes_id),0) from TEST where tes_id between 500 and 600", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTest", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxCodTest() As Integer
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxCodTest = CInt(New SqlCommand("Select isnull(Max(tes_id),0) from TEST", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTest", Err)
        Err.Clear()
    End Function


    Public Function LeerParametrosTest(ByVal tes_padre As Integer) As Integer
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        LeerParametrosTest = 0
        cls_operacion.sql_conectar()
        LeerParametrosTest = CInt(New SqlCommand("Select isnull(Count(tes_padre),0) from test where tes_padre = " & tes_padre & "", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        LeerParametrosTest = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Contar parametros Test", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxOrdenImp(ByVal tes_padre As Integer) As Integer
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        LeerMaxOrdenImp = New SqlCommand("Select isnull(Max(TES_ORDENIMP),0) from TEST WHERE TES_PADRE = " & tes_padre, cls_operacion.conn_sql).ExecuteScalar
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max OrdenImpresion", Err)
        Err.Clear()
    End Function


    Public Sub GuardarTest(ByVal TestCod As Integer, ByVal TestNom As String, _
                              ByVal TestObs As String, ByVal areId As Integer, _
                              ByVal testPrec As Double, ByVal TipoResult As Integer, _
                              ByVal tim_id As Integer, ByVal tes_tproces As String, ByVal uni_id As Short, _
                              ByVal treporte As Byte, ByVal cbarras As Integer, ByVal Tipo As String, _
                              ByVal Padre As Integer, ByVal AB As Byte, ByVal calc As Byte, ByVal ValDefecto As String, _
                              ByVal tes_lis As String, ByVal res_id As Integer, ByVal equ_id As Integer, ByVal Abrev As String, ByVal Abrev1 As String)

        'Procedimiento para la insertar un registro en la tabla TEST
        On Error GoTo MsgError
        'Procedimiento para la eliminar un registro en la tabla PERFIL Y PERFIL_TEST
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_convenios As New Cls_Convenio()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim opr_convenio As New Cls_Convenio()
        Dim opr_test As New Cls_TipoTest()
        Dim ordenImp As Integer = 0
        If areId = 22 And TipoResult = 8 And Tipo = "Parametro" Then
            ordenImp = opr_test.LeerMaxOrdenImp(Padre) + 1
        Else
            ordenImp = opr_test.LeerMaxOrdenImp(Padre) + 1
        End If
        If Tipo <> "Parametro" Then
            Padre = 0

        End If


        Dim int_i As Integer
        Dim dts_convenio As New DataSet()
        Dim dtr_fila As DataRow


        Dim str_sql As String = "Insert into TEST values (" & TestCod & ", " & areId & ", '" & TestNom & "', '" & TestObs & "', " & testPrec & " , '" & Today & "', " & tim_id & ", " & tes_tproces & ", '" & TestNom & "', 0, " & uni_id & ", " & ordenImp & ", " & treporte & "," & cbarras & ",'" & Tipo & "', '" & Padre & "'," & AB & ", " & calc & ", '" & ValDefecto & "', '" & tes_lis & " ');"
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        'Tipos de respuesta del test
        'For int_i = 0 To (chkl_Res.Items.Count - 1)
        'If chkl_Res.GetItemChecked(int_i) = True Then
        str_sql = "Insert into TEST_RESULTADO values (" & TestCod & ", " & TipoResult & ",0,NULL,NULL,NULL)"
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        dts_convenio = opr_convenio.LeerConvenio()
        For Each dtr_fila In dts_convenio.Tables("Registros").Rows
            If (opr_convenio.ExisteListaPrecio(dtr_fila(1)) = True) Then
                opr_convenio.AgregarTestListaPrecio(TestCod, testPrec, dtr_fila(1), dtr_fila(2))
            End If
        Next

        odbc_trans.Commit()
        opr_Conexion.sql_desconn()

        ActualizarTest(TestCod, areId, TestNom, TestObs, testPrec, res_id, tim_id, tes_tproces, uni_id, treporte, cbarras, Tipo, Padre, AB, calc, ValDefecto, equ_id, Trim(Abrev), Trim(Abrev1))

        If TipoResult = 4 Then
            Dim PadrePadre = TestCod
            Dim testtest = TestNom
            Dim i As Integer

            Dim arre_molecular As String()
            Dim str_molecular As String = "MUESTRA,TECNICA,VALOR DE REFERENCIA,MUESTRA ANALIZADA,COMENTARIO"
            Dim arre_mol_lis As String()
            Dim str_mol_lis As String = "MUESTRA,TECNICA,VALREF,ANALIZ,COMENT"

            arre_molecular = Split(str_molecular, ",")
            arre_mol_lis = Split(str_mol_lis, ",")


            For i = 0 To UBound(arre_molecular)
                TestCod = TestCod + 1
                ordenImp = ordenImp + 1
                str_sql = "Insert into TEST values (" & TestCod & ", " & areId & ", '" & Trim(arre_molecular(i)) & "', '', '0.0' , '" & Today & "', " & tim_id & ", " & tes_tproces & ", '" & Trim(arre_molecular(i)) & "', 0, " & uni_id & ", " & ordenImp & ", 0," & cbarras & ",'Parametro', '" & PadrePadre & "'," & AB & ", " & calc & ", '" & ValDefecto & "', '" & Trim(testtest) & "_" & Trim(arre_mol_lis(i)) & " ');"
                Dim str_sql1 As String = "Insert into TEST_RESULTADO values (" & TestCod & ", " & TipoResult & ",0,NULL,NULL,NULL)"

                opr_Conexion.sql_conectar()
                odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

                odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()

                odbc_strsql = New SqlCommand(str_sql1, opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()


                dts_convenio = opr_convenio.LeerConvenio()
                For Each dtr_fila In dts_convenio.Tables("Registros").Rows
                    If (opr_convenio.ExisteListaPrecio(dtr_fila(1)) = True) Then
                        opr_convenio.AgregarTestListaPrecio(TestCod, testPrec, dtr_fila(1), dtr_fila(2))
                    End If
                Next

                odbc_trans.Commit()
                opr_Conexion.sql_desconn()

                ActualizarTest(TestCod, areId, arre_molecular(i), TestObs, testPrec, res_id, tim_id, tes_tproces, uni_id, 0, cbarras, "Parametro", PadrePadre, AB, calc, ValDefecto, equ_id, Trim(Trim(testtest) & "_" & Trim(arre_mol_lis(i))), Trim(Abrev1))

            Next
        End If



        '*****
        'Se registra la transaccion realizada     
        g_opr_usuario.CargarTransaccion(g_str_login, "INGRESA TEST", "TEST=" & TestNom, g_sng_user, "", "", TestCod)
        'MsgBox("Datos registrados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Añadir Test", Err)
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        Err.Clear()
    End Sub

    Public Function BuscarTipTest(ByVal tes_nombre As String) As Boolean
        'Funci�n para consultar si existe el nombre de un test antes de insertar otra igual 
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        dt_operacion.SelectCommand = New SqlCommand("select * from test where tes_nombre = '" & tes_nombre & "'", cls_operacion.conn_sql)
        Dim act As New DataSet()
        Dim dtrow As DataRow
        dt_operacion.Fill(act, "Registros")
        For Each dtrow In act.Tables("Registros").Rows
            If (IsDBNull(dtrow(0))) Then
                BuscarTipTest = False
            Else
                BuscarTipTest = True
            End If
            Exit For
        Next
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar TipTest", Err)
        Err.Clear()
    End Function


    Public Function BuscarAbrev(ByVal abrev As String) As Boolean
        'Funci�n para consultar si existe el nombre de un test antes de insertar otra igual 
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_Conectar()
        dt_operacion.SelectCommand = New SqlCommand("select * from test where TES_LIS = '" & abrev & "'", cls_operacion.conn_sql)
        Dim act As New DataSet()
        Dim dtrow As DataRow
        dt_operacion.Fill(act, "Registros")
        For Each dtrow In act.Tables("Registros").Rows
            If (IsDBNull(dtrow(0))) Then
                BuscarAbrev = False
            Else
                BuscarAbrev = True
            End If
            Exit For
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar CANAL LIS", Err)
        Err.Clear()
    End Function


    ' Val(cmb_equip.Text.Substring(50, 5)), Trim(txt_abrev.Text), lbl_abrev.Tag)
    Public Sub ActualizarTest(ByVal TestCod As Integer, ByVal areId As Integer, _
                              ByVal TestNom As String, ByVal TestObs As String, _
                              ByVal TestPrec As Double, ByRef TipoResul As Integer, _
                              ByVal Tim_id As Integer, ByVal tes_tproces As Integer, ByVal uni_id As Integer, _
                              ByVal treporte As Byte, ByVal CBARRAS As String, ByVal Tipo As String, _
                              ByVal Padre As Integer, ByVal AB As Byte, ByVal calc As Byte, ByVal ValDefecto As String, _
                              Optional ByVal equipo As Integer = 0, Optional ByVal abrev_nueva As String = "", _
                              Optional ByVal old_abrev As String = "")
        'Procedimiento para la actualizar un registro en la tabla TEST, TEST_RESULTADO, TEST_TIPMUE
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql3 As SqlCommand
        Dim int_i As Integer
        Dim boo_exist As Boolean
        Dim teq_id As String = Nothing
        Dim teq_arreglo As String()
        Dim teq_values As String = Nothing
        Dim teq_values_arre As String()
        Dim str_sql3 As String = Nothing

        If Tipo <> "Parametro" Then
            Padre = 0
            'Else
            '    Padre = Padre
        End If

        Dim str_sql4 As String = "select RANG_TIPO, RANG_MIN, RANG_MAX, RANG_MUL from test_resultado where TES_ID = " & TestCod & ""
        Dim str_sql As String = "select  TEQ_ID from test_equipo where TES_ID = " & TestCod & ""

        Dim int_codigo As Integer = LeerMaxCodTestequipo() + 1
        Dim i As Integer
        Dim EQU_ID, TEQ_ESTADO, TEQ_TRANGO, TEQ_PRIORIDAD As Integer
        Dim TEQ_RANMIN, TEQ_RANMAX As Long
        Dim TEQ_RANMUL, TEQ_ABREVIATURA, TEQ_ABRV_FIJA As String
        Dim abrev As String = Nothing
        opr_Conexion.sql_conectar()


        If CInt(New SqlCommand("SELECT count(tes_id) from test_equipo where tes_id = " & TestCod & "", opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
            boo_exist = True
            Dim odr_operacion1 As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
            Dim ubica_genero As Integer
            Dim sw As Integer = 0

            While odr_operacion1.Read
                teq_id = teq_id & odr_operacion1.GetValue(0) & ","
            End While
            odr_operacion1.Close()

            teq_arreglo = Split(teq_id, ",")
            For i = 0 To UBound(teq_arreglo) - 1
                Dim str_sql2 As String = "select UNI_ID, EQU_ID, TEQ_ESTADO, TEQ_TRANGO, TEQ_RANMIN, TEQ_RANMAX, TEQ_RANMUL, TEQ_PRIORIDAD, TEQ_ABREVIATURA, TEQ_ABRV_FIJA, TEQ_ID from test_equipo where TEQ_ID = " & teq_arreglo(i) & ""
                Dim odr_operacion2 As SqlDataReader = New SqlCommand(str_sql2, opr_Conexion.conn_sql).ExecuteReader
                While odr_operacion2.Read
                    'uni_id = odr_operacion2.GetValue(0)
                    'EQU_ID = odr_operacion2.GetValue(1)
                    TEQ_ESTADO = odr_operacion2.GetValue(2)
                    TEQ_TRANGO = odr_operacion2.GetValue(3)
                    TEQ_RANMIN = odr_operacion2.GetValue(4)
                    TEQ_RANMAX = odr_operacion2.GetValue(5)
                    TEQ_RANMUL = odr_operacion2.GetString(6)
                    TEQ_PRIORIDAD = odr_operacion2.GetValue(7)
                    TEQ_ABREVIATURA = Trim(odr_operacion2.GetString(8))
                    TEQ_ABRV_FIJA = Trim(odr_operacion2.GetString(9))
                    teq_id = odr_operacion2.GetValue(10)
                End While
                odr_operacion2.Close()
                abrev = abrev_nueva

                Select Case TEQ_ABREVIATURA
                    Case "HOMBRE"
                        abrev = abrev & "H"
                    Case "MUJER"
                        abrev = abrev

                    Case "RN"
                        abrev = abrev & "R"

                    Case "NIÑO"
                        abrev = abrev & "N"

                End Select

                str_sql = "Update TEST_EQUIPO set UNI_ID = " & uni_id & ", EQU_ID = " & EQU_ID & ", TEQ_ESTADO = " & TEQ_ESTADO & ", TEQ_TRANGO = " & TEQ_TRANGO & ", TEQ_RANMIN = " & TEQ_RANMIN & ", TEQ_RANMAX = " & TEQ_RANMAX & ", TEQ_RANMUL = '" & TEQ_RANMUL & "', TEQ_PRIORIDAD = " & TEQ_PRIORIDAD & ", TEQ_ABREVIATURA = '" & TEQ_ABREVIATURA & "', TEQ_ABRV_FIJA = '" & abrev & "' where teq_id = " & teq_arreglo(i) & ""
                odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()

                'ACTUALIZO EL HSITORICO CUANDO MODIFICO UNA ABREVIATURA 
                str_sql3 = "update RES_PROCESADOS set tes_abrev = '" & abrev & "', tim_id = " & Tim_id & " where tes_abrev = '" & Trim(TEQ_ABRV_FIJA) & "';"
                odbc_strsql3 = New SqlCommand(str_sql3, opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql3.ExecuteNonQuery()
            Next

        Else
            boo_exist = False
        End If

        Dim rang_mul, rang_min, rang_max As String

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql4, opr_Conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            If odr_operacion.GetValue(0) = 2 Then
                rang_mul = odr_operacion.GetValue(3)
            ElseIf odr_operacion.GetValue(0) = 1 Then
                rang_min = odr_operacion.GetValue(1)
                rang_max = odr_operacion.GetValue(2)
            End If
        End While
        odr_operacion.Close()

        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'cabecera     
        ' ''If Tipo <> "Parametro" Then
        ' ''    Padre = 0
        ' ''Else
        ' ''    Padre = TestCod
        ' ''End If
        str_sql = "Update TEST set are_Id = " & areId & ", tes_nombre = '" & TestNom & "', Tes_obs = '" & TestObs & "', tes_precio = " & TestPrec & ", tim_id = " & Tim_id & ", tes_tproces = " & tes_tproces & ", uni_id = " & uni_id & ", tes_tiporeporte = " & treporte & ", tes_codbarras = " & CBARRAS & ", tes_Tipo = '" & Tipo & "', tes_Padre = " & Padre & ", tes_AB = " & AB & ", tes_calc = " & calc & ", tes_resdefecto = '" & Trim(ValDefecto) & "', tes_lis = '" & Trim(abrev_nueva) & "' where tes_id = " & TestCod & ""
        odbc_strsql = New SqlCommand(str_sql, opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        'Borramos los tipos de respuesta del test 
        odbc_strsql = New SqlCommand("Delete from TEST_RESULTADO where tes_id = " & _
        TestCod & "", opr_Conexion.conn_sql, odbc_trans)

        'odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        'Tipos de respuesta del test

        '''str_sql = "insert into TEST_RESULTADO values (" & TestCod & "," & TipoResul & ","& &", ) RES_ID = " & TipoResul & " where TES_ID = " & TestCod & ";"
        If rang_mul = "" And rang_min <> "" Then
            odbc_strsql = New SqlCommand("Insert into TEST_RESULTADO values (" & _
            TestCod & ", " & TipoResul & ", 1," & rang_min & "," & rang_max & ",NUll)", opr_Conexion.conn_sql, odbc_trans)
        ElseIf rang_min = "" And rang_mul <> "" Then
            odbc_strsql = New SqlCommand("Insert into TEST_RESULTADO values (" & _
            TestCod & ", " & TipoResul & ", 2, Null,NUll,'" & rang_mul & "')", opr_Conexion.conn_sql, odbc_trans)
        Else
            odbc_strsql = New SqlCommand("Insert into TEST_RESULTADO values (" & _
            TestCod & ", " & TipoResul & ", 0, Null,NUll,NUll)", opr_Conexion.conn_sql, odbc_trans)
        End If
        odbc_strsql.ExecuteNonQuery()


        If tes_tproces = 1 Then
            If boo_exist = True Then
                If Padre <> 400101 Then
                    'odbc_strsql = New SqlCommand("update TEST_EQUIPO set teq_estado = 1, uni_id =" & uni_id & ", equ_id = " & equipo & ", teq_abrv_fija = '" & abrev & "' , teq_prioridad = 1 where tes_id = " & TestCod & "", opr_Conexion.conn_sql, odbc_trans)
                    odbc_strsql = New SqlCommand("update TEST_EQUIPO set teq_estado = 1, uni_id =" & uni_id & ", equ_id = " & equipo & ", teq_prioridad = 1 where tes_id = " & TestCod & "", opr_Conexion.conn_sql, odbc_trans)
                Else
                    odbc_strsql = New SqlCommand("update TEST_EQUIPO set teq_estado = 1, uni_id =" & uni_id & ", equ_id = " & equipo & ",  teq_prioridad = 1 where tes_id = " & TestCod & "", opr_Conexion.conn_sql, odbc_trans)
                End If
            Else
                odbc_strsql = New SqlCommand("Insert into TEST_EQUIPO values (" & TestCod & _
                ", " & uni_id & "," & equipo & ", 1,0, 0,0,'',1,'HOMBRE','" & Trim(abrev_nueva) & "H'," & int_codigo & ")", opr_Conexion.conn_sql, odbc_trans)
            End If
            odbc_strsql.ExecuteNonQuery()
        Else
            If boo_exist = True Then
                odbc_strsql = New SqlCommand("update TEST_EQUIPO set teq_estado = 0, teq_prioridad = 0 where tes_id = " & TestCod & "", opr_Conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()
            End If
        End If

        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza Test", "Test=" & TestNom, g_sng_user, "", "", TestCod)
        'MsgBox("Datos almacenados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        'odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Test", Err)
        Err.Clear()
    End Sub

    Public Function LeerMaxCodTestequipo() As Integer
        'Funcion para consultar el TEQ_ID del TEST_EQUIPO
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_Conectar()
        LeerMaxCodTestequipo = CInt(New SqlCommand("Select isnull(Max(teq_id),0) from TEST_EQUIPO", cls_operacion.conn_sql).ExecuteScalar)
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTest", Err)
        Err.Clear()
    End Function


    Public Sub EliminarTest(ByVal TestCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla TEST, TEST_RESULTADO, TEST_TIPMUE
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim opr_Conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim int_i As Integer
        opr_Conexion.sql_conectar()
        odbc_trans = opr_Conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'borramos todos los Tipos de Muestras del Test        
        odbc_strsql = New SqlCommand("Delete from TEST_TIPMUESTRA where tes_Id = " & TestCod & "", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        'Borramos los tipos de respuesta del test         
        odbc_strsql = New SqlCommand("Delete from TEST_RESULTADO where tes_Id = " & _
        TestCod & "", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        '****** JPO 08/JULIO/2003
        'Borramos AL test de las listas de precios
        odbc_strsql = New SqlCommand("Delete from LISTA_PRECIO where tes_Id = " & _
        TestCod & "", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        'elimina el test_equipo si hubiera.
        odbc_strsql = New SqlCommand("Delete from TEST_EQUIPO where tes_id = " & TestCod & "", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        '******JPO  08/JULIO/2003
        'Borra el test            
        odbc_strsql = New SqlCommand("Delete from TEST where tes_id = " & TestCod & "", opr_Conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Test", "TEST=" & TestCod, g_sng_user, "", "", TestCod)
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Test", Err)
        odbc_trans.Rollback()
        opr_Conexion.sql_desconn()
        Err.Clear()
    End Sub

    Public Sub LlenarList_Test(ByRef lst_test As ListBox)
        'Procedimiento para la Llenar un listBox con todas los test.
        On Error Resume Next
        Dim dt_test As DataSet
        Dim dt_fila As DataRow
        dt_test = LeerTestDisponibles()
        Dim x As String
        For Each dt_fila In dt_test.Tables("Registros").Rows
            lst_test.Items.Add(dt_fila("tes_nombre").ToString().PadRight(100) & dt_fila("tes_id").ToString().PadRight(10))
        Next
        lst_test.SelectedIndex = 0
    End Sub


    Public Sub LlenarList_Medico(ByRef lst_Medico As ListBox)
        'Procedimiento para la Llenar un listBox con todas los test.
        On Error Resume Next
        Dim dt_test As DataSet
        Dim dt_fila As DataRow
        dt_test = LeerTestDisponibles()
        Dim x As String
        For Each dt_fila In dt_test.Tables("Registros").Rows
            lst_Medico.Items.Add(dt_fila("med_nombre").ToString().PadRight(100) & dt_fila("med_id").ToString().PadRight(10))
        Next
        lst_Medico.SelectedIndex = 0
    End Sub



    Public Sub LlenarList_ParamCul(ByRef lst_test As ListBox)
        'Procedimiento para la Llenar un listBox con todas los test.
        On Error Resume Next
        Dim dt_test As DataSet
        Dim dt_fila As DataRow
        dt_test.Clear()
        lst_test.Items.Clear()
        dt_test = LeerParamDisponibles()
        Dim x As String
        For Each dt_fila In dt_test.Tables("Registros2").Rows
            lst_test.Items.Add(dt_fila("tes_nombre").ToString().PadRight(100) & dt_fila("tes_id").ToString().PadRight(10))
        Next
        lst_test.SelectedIndex = 0
    End Sub

    Public Sub LlenarList_ParamMicro(ByRef lst_test As ListBox)
        'Procedimiento para la Llenar un listBox con todas los test.
        On Error Resume Next
        Dim dt_test As DataSet
        Dim dt_fila As DataRow
        dt_test.Clear()
        lst_test.Items.Clear()
        dt_test = LeerParamMicro()
        Dim x As String
        For Each dt_fila In dt_test.Tables("Registros3").Rows
            lst_test.Items.Add(dt_fila("tes_nombre").ToString().PadRight(100) & dt_fila("tes_id").ToString().PadRight(10))
        Next
        lst_test.SelectedIndex = 0
    End Sub


    Public Function ConsultarUnidadTest(ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar la unidad de un test
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand("Select uni_id from TEST where tes_id = " & tes_id & "", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        ConsultarUnidadTest = New DataSet()
        dt_operacion.Fill(ConsultarUnidadTest, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Consultar Unidad Test", Err)
        Err.Clear()
    End Function

    Public Function abrevnombre(ByVal testid As Integer) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select test.tes_lis from test where tes_id =" & testid & " ;", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            abrevnombre = Trim(dtr_fila(0))
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Nombre Abreviattura", Err)
        Err.Clear()
    End Function

    Sub LlenarGridEstCultivo(ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerEstCultivo().Tables("Registros")
    End Sub


    Sub LlenarGridFormatos(ByRef data As DataView, ByVal filtro As Integer, ByVal tes_id As Integer)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestFormatos(filtro, tes_id).Tables("Registros")
    End Sub

    Sub LlenarGridParametrosFormatos(ByRef data As DataView, ByVal tes_id As Integer)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerParamFormatos(tes_id).Tables("Registros")
    End Sub


    Sub LlenarGridtest(ByRef data As DataView, ByVal filtro As Boolean)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestArea(filtro).Tables("Registros")
    End Sub

    Sub LlenarGridParam(ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerParametroArea().Tables("Registros")
    End Sub
    Sub LlenarGridtest(ByRef data As DataView, ByVal are_id As Integer)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestArea(are_id).Tables("Registros")
    End Sub


    Sub LlenarGridPalabra(ByRef data2 As DataView, ByVal test As Integer)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data2.AllowDelete = False
        data2.AllowEdit = False
        data2.AllowNew = False
        data2.Table = LeerAutoCompletar(test).Tables("Registros2")
    End Sub

    Sub LlenarGridAntibiotico(ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerAntibiotico().Tables("Registros")
    End Sub

    Public Function nombrePadre(ByVal testid As Integer) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select tes_nombre from test where tes_id =" & testid & "", opr_Conexion.conn_sql)
        Dim dts_padre As New DataSet()
        oda_operacion.Fill(dts_padre, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_padre.Tables("Registros").Rows
            nombrePadre = dtr_fila(0).ToString
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Nombre Abreviattura", Err)
        Err.Clear()
    End Function

    Sub LlenarGridtestHijos(ByVal tes_idd As Integer, ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestHijos(tes_idd).Tables("Registros2")
    End Sub

    Sub LlenarGridtestRangos(ByVal tes_idd As Integer, ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestRangos(tes_idd).Tables("Registros2")
    End Sub

    Sub LlenarGridtestHijosAB(ByVal tes_idd As Integer, ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestHijosAB(tes_idd).Tables("Registros2")
    End Sub

    Sub ordena_test(ByVal test As String, ByRef data As DataView)
        'funcion que orderna por test al dataview
        With data
            If Trim(test) <> "" Then
                .RowFilter = "TES_NOMBRE like '" & Trim(test) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "TES_NOMBRE"
        End With
    End Sub



    Sub ordena_Antibiotico(ByVal test As String, ByRef data As DataView)
        'funci�n que orderna por palabra al dataview
        With data
            If Trim(test) <> "" Then
                .RowFilter = "ANB_NOMBRE like '" & Trim(test) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "ANB_NOMBRE"
        End With
    End Sub

    Sub ordena_Palabra(ByVal test As String, ByRef data As DataView)
        'funci�n que orderna por palabra al dataview
        With data
            If Trim(test) <> "" Then
                .RowFilter = "AUTO_NOMBRE like '" & Trim(test) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "AUTO_NOMBRE"
        End With
    End Sub

    Public Function BuscarPalabra(ByVal palabra As String, ByVal test As Integer) As Boolean
        'funcion que nos permite ferificar si existe una boniicacion especifica se recibe
        ' le nombre de la bonificacion y se debuelve on boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from tipo_autocompletar where auto_nombre = '" & palabra & "' and TES_ID = " & test & ";", opr_Conexion.conn_sql)
        Dim dts_palabra As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_palabra, "Registros")
        For Each dtr_fila In dts_palabra.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarPalabra = False
            Else
                BuscarPalabra = True
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Buscar palabra", Err)
        Err.Clear()
    End Function

    Public Function BuscarAntibiotico(ByVal antibiotico As String) As Boolean
        'funcion que nos permite ferificar si existe una boniicacion especifica se recibe
        ' le nombre de la bonificacion y se debuelve on boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from antibiotico where anb_nombre = '" & antibiotico & "';", opr_Conexion.conn_sql)
        Dim dts_palabra As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_palabra, "Registros")
        For Each dtr_fila In dts_palabra.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                antibiotico = False
            Else
                antibiotico = True
            End If
            Exit For
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Buscar antibiotico", Err)
        Err.Clear()
    End Function


    Public Sub GuardarPalabra(ByVal palabra As String, ByVal test As Integer)
        'funcion que nos permite guardar los datos de una nueva bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "insert into tipo_autocompletar (AUTO_NOMBRE, TES_ID) VALUES ('" & palabra & "'," & test & ")"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Guardar palabra", "PALABRA=" & palabra, g_sng_user, "", "", "")
        MsgBox("La palabra autocompletar fue almacenada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar palabra", Err)
        Err.Clear()
    End Sub

    Public Sub GuardarAntibiotico(ByVal antibiotico As String, ByVal codigo As String, ByVal orden As Integer)
        'funcion que nos permite guardar los datos de una nueva bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_Conectar()
        STR_SQL = "insert into antibiotico (ANB_NOMBRE, ANB_CODIGO, ANB_ORDEN, ARE_ID) VALUES ('" & antibiotico & "','" & codigo & "'," & orden & ",22);"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Guardar antibiotico", "ANTIBIOTICO=" & antibiotico, g_sng_user, "", "", "")
        MsgBox("El antibiotico fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar antibiotico", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarPalabra(ByVal palabra As String, ByVal tes_id As Integer, ByVal bon_nombre_antiguo As String)
        'funcion que nos permite actualizar los datos de las bonificaciones
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "update tipo_autocompletar set auto_nombre ='" & palabra & "', tes_id =" & tes_id & " where auto_nombre='" & bon_nombre_antiguo & "'"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Palabra", "PALABRA=" & palabra, g_sng_user, "", "", "")
        MsgBox("La palabra fue modificada correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar palabra", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarAntibiotico(ByVal antibiotico As String, ByVal codigo As String, ByVal orden As Integer, ByVal bon_nombre_antiguo As String)
        'funcion que nos permite actualizar los datos de las bonificaciones
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_palabra As SqlCommand
        cls_operacion.sql_Conectar()
        STR_SQL = "update antibiotico set anb_nombre ='" & antibiotico & "', anb_codigo ='" & codigo & "', anb_orden = " & orden & " where anb_nombre='" & bon_nombre_antiguo & "'"
        odc_palabra = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_palabra.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Antibiotico", "ANTIBIOTICO=" & antibiotico, g_sng_user, "", "", "")
        MsgBox("El antibiotico fue modificado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar antibiotico", Err)
        Err.Clear()
    End Sub


    Public Sub EliminaAntibiotico(ByVal antibiotico As String)
        'funcion que nos permite la eliminacion de una bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_Conectar()
        STR_SQL = "Delete from antibiotico where anb_nombre = '" & antibiotico & "'"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Antibiotico", "NATIBIOTICO=" & antibiotico, g_sng_user, "", "", "")
        MsgBox("El antibiotico fue eliminado", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Eliminar Antibiotico", Err)
        Err.Clear()
    End Sub

    Public Sub EliminaPalabra(ByVal palabra As String, ByVal auto_id As Integer)
        'funcion que nos permite la eliminacion de una bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from tipo_autocompletar where auto_nombre = '" & palabra & "' and auto_id = " & auto_id & ";"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Palabra", "PALABRA=" & palabra, g_sng_user, "", "", "")
        MsgBox("La palabra fue eliminada", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Eliminar Antibiotico", Err)
        Err.Clear()
    End Sub


End Class
