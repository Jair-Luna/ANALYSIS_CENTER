'*************************************************************************
' Nombre:   Cls_Equipos
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla EQUIPO
' Autores:  RFN 
' Fecha de Creaci�n: Julio del 2002
' Autores Modificaciones:
' Ultima Modificaci�n: 18/07/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports System.IO
Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_equipos

    Public Function LeerEquipos() As DataSet
        'Funcion para la consultar los datos de la tabla EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "SELECT EQUIPO.EQU_ID as equ_id, EQUIPO.EQU_MARCA as equ_marca, EQUIPO.EQU_MODELO as equ_modelo, EQUIPO.EQU_SERIE as equ_serie, If(equ_estado=1,'Activo','Inactivo') AS equ_estado FROM EQUIPO where equ_estado = 1"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        LeerEquipos = New DataSet()
        oda_operacion.Fill(LeerEquipos, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Equipos", Err)
        Err.Clear()
    End Function


    Public Sub EliminaImpresora(ByVal impresora As String)
        'funcion que nos permite la eliminacion de una bonificacion
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_bonificacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from impresora where imp_descripcion = '" & impresora & "'"
        odc_bonificacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_bonificacion.ExecuteNonQuery()
        cls_operacion.odbc_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Impresora ", "IMP=" & impresora, g_sng_user, "", "", "")

        MsgBox("la impresora fue eliminada", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Eliminar Antibiotico", Err)
        Err.Clear()
    End Sub


    Public Function LeerEquipos1() As ArrayList
        'Funcion para la consultar los datos de la tabla EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        STR_SQL = "SELECT EQUIPO.EQU_MODELO as equ_modelo, EQUIPO.EQU_ID as equ_id FROM EQUIPO where equ_estado = 1 order by equ_id"
        LeerEquipos1 = New ArrayList()
        LeerEquipos1.Clear()
        opr_Conexion.sql_conectar()
        Dim oda_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_Conexion.conn_sql).ExecuteReader
        While oda_operacion.Read
            LeerEquipos1.Add(oda_operacion.GetValue(0).ToString.PadRight(50) & oda_operacion.GetValue(1).ToString.PadRight(5))
        End While
        oda_operacion.Close()
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Equipos1", Err)
        Err.Clear()
    End Function


    Public Function LeerTuboEquipo(ByVal equ_id As Integer) As DataSet
        'funcion que devuelve el tipo de tubo que utiliza un equipo 
        '1 --> Tubo Primario
        '2 --> Copa
        '3 --> Ambos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_equipo As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select equ_tubo from equipo where equ_id = " & equ_id & ""
        opr_conexion.sql_conectar()
        oda_equipo.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerTuboEquipo = New DataSet()
        oda_equipo.Fill(LeerTuboEquipo, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Tubo Equipo", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodEqui() As Integer
        'Funcion para la consultar el c�digo m�ximo de la tabla EQUIPO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodEqui = CInt(New SqlCommand("select isnull(max(equ_id),0) from EQUIPO", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo Codigo de Equipos", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodEquiTest() As Integer
        'M�ximo c�digo de test_equipo
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodEquiTest = CInt(New SqlCommand("select isnull(max(TEQ_ID),0) from TEST_EQUIPO", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo Codigo de Test en Equipo", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxCodImp() As Integer
        'M�ximo c�digo de test_equipo
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodImp = CInt(New SqlCommand("select isnull(max(IMP_ID),0) from impresora", opr_Conexion.conn_sql).ExecuteScalar)
        LeerMaxCodImp = LeerMaxCodImp + 1
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo Codigo de Test en Equipo", Err)
        Err.Clear()
    End Function

    Public Sub GuardarEquipoTest(ByVal TablaTest As DataTable)
        'Procedimiento para la predeterminaci�n de equipos por test
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim int_prioridad, int_eqp As Single
        Dim int_cont, TestId, EqpId As Integer
        Dim odc_pedido As New SqlCommand()
        opr_Conexion.sql_conectar()

        'Colocamos todos los valores de los test predeterminados en 0 ???
        STR_SQL = "Update TEST_EQUIPO set TEQ_PRIORIDAD = 0"
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        For int_cont = 0 To TablaTest.Rows.Count - 1
            'asignamos valor prederterminado a todos los test que tengan equipo,
            'si no lo tienen no acurre tal actualizaci�n
            TestId = TablaTest.Rows.Item(int_cont).Item(0)
            EqpId = TablaTest.Rows.Item(int_cont).Item(2).ToString().Substring(70, 5)
            STR_SQL = "Update TEST_EQUIPO set TEQ_PRIORIDAD = 1  " & _
            "Where TES_ID = " & TestId & "  and  " & " EQU_ID = " & EqpId
            odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            Dim opr_pedido As New Cls_Pedido()
            Dim cont As Short
            Dim dtt_testrelacionado As New DataTable()
            dtt_testrelacionado = opr_pedido.tes_asociados(EqpId, TestId).Tables(0)
            For cont = 0 To dtt_testrelacionado.Rows.Count - 1
                STR_SQL = "Update TEST_EQUIPO set TEQ_PRIORIDAD = 1  " & _
                "Where TES_ID = " & dtt_testrelacionado.Rows(cont).Item(0) & "  and  " & " EQU_ID = " & EqpId
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Next

            If EqpId = 0 Then
                int_eqp = 1
            Else
                int_eqp = 0
            End If
            STR_SQL = "Update TEST set TES_TPROCES = " & int_eqp & "  " & _
            "Where TES_ID = " & TestId
            odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
        Next
        g_opr_usuario.CargarTransaccion(g_str_login, "Predeterminacion de Equipo por Test", "", g_sng_user, "", "", "")
        MsgBox("Datos Registrados", MsgBoxStyle.Information, "ANALISYS")
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Predeterminacion de Equipo por Test", Err)
        Err.Clear()
    End Sub

    Public Sub LlenarCmbEquipos(ByRef cmb_Equipos As ComboBox)
        'Procedimiento para la Llenar un combo con todos los Equipos (Nombre y C�digo)
        Dim arr_eqp As New ArrayList()
        arr_eqp = LeerEquipos1()
        Dim i As Short
        For i = 0 To arr_eqp.Count - 1
            cmb_Equipos.Items.Add(arr_eqp.Item(i))
        Next
        cmb_Equipos.SelectedIndex = 0
    End Sub

    Public Sub ActualizarEstEquipoTest(ByVal TestId As Integer, ByVal EqpId As Integer, ByVal Estado As Single, ByVal Abreviatura As String)
        'Procedimiento para actualizar los estados, abreviatura de los test que contiene cada equipo
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "Update TEST_EQUIPO set TEQ_ESTADO=" & Estado & ", " & _
                "TEQ_ABREVIATURA='" & Abreviatura & "'  " & _
                "where TES_ID=" & TestId & " and  EQU_ID=" & EqpId
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        If Estado = 0 Then   'SI SE DESACTIVA LA PRUEBA, LA MISMA PARA A CONSTAR COMO MANUAL.
            STR_SQL = "UPDATE TEST SET TES_TPROCES = 0 WHERE TES_ID=" & TestId & ";"
            odc_operacion = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_operacion.ExecuteNonQuery()
        Else   'SI EL OPERADOR ACTIVA LA PRUEBA, ESTA SE PONE COMO PROCESAMIENTO EN EQUIPO
            STR_SQL = "UPDATE TEST SET TES_TPROCES = 1 WHERE TES_ID=" & TestId & ";"
            odc_operacion = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_operacion.ExecuteNonQuery()
        End If
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Datos del Test por Equipo", "Test=" & TestId, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Registrar datos Test por Equipos", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarEquipo(ByVal equiCod As Integer, ByVal equiMarca As String, _
                              ByVal equiMod As String, ByVal equiSer As String)
        'Procedimiento que actualiza los datos de un equipo
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()

        STR_SQL = "Update EQUIPO set equ_marca = '" & equiMarca & "', equ_modelo = '" & _
        equiMod & "', equ_serie = '" & equiSer & "' where equ_id = " & equiCod & ""
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Equipo", "Equipo=" & equiMarca, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Equipo", Err)
        Err.Clear()
    End Sub

    Public Sub CambiaEstadoEquipo(ByVal equiCod As Integer, ByVal estado As Short)
        'Procedimiento que cambia el estado del equipo
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()

        STR_SQL = "Update EQUIPO set equ_estado = " & estado & " where equ_id = " & equiCod & ""
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "CambiaEstadoEquipo", "Equipo=" & equiCod, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, CambiaEstadoEquipo", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarEquipo(ByVal equiCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla EQUIPO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand

        opr_Conexion.sql_conectar()
        odc_operacion = New SqlCommand("delete from TEST_EQUIPO where equ_id = " & equiCod & "", opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        odc_operacion = New SqlCommand("delete from EQUIPO where equ_id = " & equiCod & "", opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Equipo", "Equipo=" & equiCod, g_sng_user, "", "", "")
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Equipo", Err)
        Err.Clear()
    End Sub

    Sub LeerTestEquipos(ByRef data As DataView)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestRangos().Tables("Registros")
    End Sub


    Public Function LeerTestRangos() As DataSet
        'Funcion para la consultar los rangos de normalidad de todos los test
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing

        'str_sql = "select a.ARE_NOMBRE,  t.TES_ID, CASE when TES_TIPO = 'Examen' then  ('** ' + TES_NOMBRE + ' **') when TES_TIPO = 'Parametro' then  ('  --> ' + TES_NOMBRE) END as TES_NOMBRE, te.TEQ_ABREVIATURA  " & _
        '    "from test as t, test_equipo as te, area as a " & _
        '    "where t.ARE_ID = 1 AND a.ARE_ID = t.ARE_ID  AND t.TES_ID = te.TES_ID and TES_TIPO IN('Examen','Parametro')order by TES_ORDENIMP asc"


        str_sql = "SELECT area.ARE_NOMBRE, TEST_EQUIPO.TES_ID as testId, TEST.TES_NOMBRE as testNombre, TEST_EQUIPO.EQU_ID as equiId, EQUIPO.EQU_MODELO as equiMod, TEST_EQUIPO.UNI_ID as uniId, UNIDAD.UNI_NOMENCLATURA as uniNom, TEST_EQUIPO.TEQ_ESTADO as testEst, TEST_EQUIPO.TEQ_TRANGO as testTRango, TEST_EQUIPO.TEQ_RANMIN as testRanMin, TEST_EQUIPO.TEQ_RANMAX as testRanMax, TEST_EQUIPO.TEQ_RANMUL as testRanMul, TEST_EQUIPO.TEQ_ABREVIATURA as test_abrev, TEST_EQUIPO.TEQ_ABRV_FIJA as ABREVIA, TEST_EQUIPO.TEQ_ID as teq_id, TEST.tes_lis as tlis " & _
        "FROM test_equipo, test, equipo, unidad, area " & _
        "WHERE test_equipo.TES_ID = test.TES_ID and EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID and test.UNI_ID = unidad.UNI_ID and test.ARE_ID = area.ARE_ID " & _
        "order by area.ARE_OBS, test.TES_ID  asc"

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerTestRangos = New DataSet("Registros")
        oda_operacion.Fill(LeerTestRangos, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Rangos", Err)
        Err.Clear()
    End Function


    Sub ordena_RangNormal(ByVal test As String, ByRef data As DataView)
        'funci�n que orderna por apellido al dataview
        With data
            If Trim(test) <> "" Then
                .RowFilter = "testNombre like '" & Trim(test) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "testNombre"
        End With
    End Sub


    ' ''    Public Function LeerTestEquipos() As DataSet
    ' ''        'Funcion para la consultar los test por equipo 
    ' ''        On Error GoTo MsgError
    ' ''        Dim opr_Conexion As New Cls_Conexion()
    ' ''        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
    ' ''        Dim str_sql = "SELECT TEST_EQUIPO.TES_ID as testId, (TEST.TES_NOMBRE+ ' '+TEST_EQUIPO.TEQ_ABREVIATURA)  as testNombre, " & _
    ' ''        "TEST_EQUIPO.EQU_ID as equiId, EQUIPO.EQU_MODELO as equiMod, TEST_EQUIPO.UNI_ID as uniId, " & _
    ' ''        "UNIDAD.UNI_NOMENCLATURA as uniNom, TEST_EQUIPO.TEQ_ESTADO as testEst, TEST_EQUIPO.TEQ_TRANGO as testTRango, " & _
    ' ''        "TEST_EQUIPO.TEQ_RANMIN as testRanMin, TEST_EQUIPO.TEQ_RANMAX as testRanMax, TEST_EQUIPO.TEQ_RANMUL as testRanMul, " & _
    ' ''        "TEST_EQUIPO.TEQ_ABREVIATURA as test_abrev FROM UNIDAD INNER JOIN (TEST INNER JOIN (EQUIPO INNER JOIN TEST_EQUIPO " & _
    ' ''        "ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) ON TEST.TES_ID = TEST_EQUIPO.TES_ID) ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID"
    ' ''        opr_Conexion.sql_conectar()
    ' ''        'oda_operacion.SelectCommand = New SqlCommand("SELECT TEST_EQUIPO.TES_ID as testId, TEST.TES_NOMBRE as testNombre, TEST_EQUIPO.EQU_ID as equiId, EQUIPO.EQU_MODELO as equiMod, TEST_EQUIPO.UNI_ID as uniId, UNIDAD.UNI_NOMENCLATURA as uniNom, TEST_EQUIPO.TEQ_ESTADO as testEst, TEST_EQUIPO.TEQ_TRANGO as testTRango, TEST_EQUIPO.TEQ_RANMIN as testRanMin, TEST_EQUIPO.TEQ_RANMAX as testRanMax, TEST_EQUIPO.TEQ_RANMUL as testRanMul FROM UNIDAD INNER JOIN (TEST INNER JOIN (EQUIPO INNER JOIN TEST_EQUIPO ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) ON TEST.TES_ID = TEST_EQUIPO.TES_ID) ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID", opr_Conexion.conn_sql)
    ' ''        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
    ' ''        LeerTestEquipos = New DataSet("Registros")
    ' ''        oda_operacion.Fill(LeerTestEquipos, "Registros")
    ' ''        opr_conexion.sql_desconn()
    ' ''        Exit Function
    ' ''MsgError:
    ' ''        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer test equipos", Err)
    ' ''        Err.Clear()
    ' ''    End Function

    Public Sub TestxEquipo(ByRef dtt_testeqp As DataTable, ByVal Int_IDEquipo As Single)
        'Funcion para la consultar los test por un equipo 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        STR_SQL = "SELECT TEST.TES_ID  as eqpT_ID, TEST.TES_NOMBRE as eqpT_Nombre, TEST_EQUIPO.TEQ_ESTADO as eqpT_Est, TEST_EQUIPO.TEQ_ABREVIATURA as eqpT_Abv, TEST_EQUIPO.UNI_ID as eqpT_unidad, TEST_EQUIPO.TEQ_ABRV_Fija as eqpT_Abvfija " & _
        "FROM TEST INNER JOIN TEST_EQUIPO ON TEST.TES_ID = TEST_EQUIPO.TES_ID " & _
        "WHERE(((TEST_EQUIPO.EQU_ID) = " & Int_IDEquipo & ")) " & _
        "ORDER BY TEST.TES_NOMBRE "
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        'cargamos en el parametro enviado por referencia
        oda_operacion.Fill(dtt_testeqp)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test por Equipo", Err)
        Err.Clear()
    End Sub

    Public Sub LeerTest(ByRef dtt_registros As DataTable)
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        dt_operacion.SelectCommand = New SqlCommand("SELECT TES_ID, TES_NOMBRE  FROM TEST order by TES_nombre", opr_Conexion.conn_sql)
        'cargamos en el parametro enviado por referencia
        dt_operacion.Fill(dtt_registros)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Sub

    Public Function LeerSNIEquipo(ByRef equ_id As Integer) As String
        'Funcion para la consultar el dispositivo de Conexi�n que utiliza cada equipo SNI/COM
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        str_sql = "SELECT sni_nombre from  equipo where equ_id = " & equ_id & ""
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            LeerSNIEquipo = ""
        Else
            LeerSNIEquipo = dts_datos.Tables(0).Rows(0).Item(0).ToString
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Conexion Equipo", Err)
        Err.Clear()
    End Function


    Public Function VerificaTestResultado(ByRef tes_id As Integer) As Boolean
        'Funcion para la consultar el dispositivo de Conexi�n que utiliza cada equipo SNI/COM
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        str_sql = "select * from test_resultado where TES_ID = " & tes_id & ""
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            VerificaTestResultado = False
        Else
            VerificaTestResultado = True
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Conexion Equipo", Err)
        Err.Clear()
    End Function

    Public Function LeerEstadoEquipo(ByRef equ_id As Short) As DataSet
        'Funcion para la consultar el estado actual de un equipo (activo -->1 / inactivo --> 0 )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT equ_estado FROM equipo where equ_id = " & equ_id & " ", opr_Conexion.conn_sql)
        LeerEstadoEquipo = New DataSet("Registros")
        oda_operacion.Fill(LeerEstadoEquipo, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Estado Equipo", Err)
        Err.Clear()
    End Function

    Public Sub LeerTest_Visibles(ByRef dtt_registros As DataTable)
        'Funcion para la consultar los datos de la tabla TEST, abarca los que tengan de tes_parametro = 0
        'eso significa que son a nivel de test que abarcan los test que son como parametros
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        dt_operacion.SelectCommand = New SqlCommand("SELECT TES_ID, TES_NOMBRE FROM TEST where TES_PARAMETRO=0 order by TES_nombre", opr_Conexion.conn_sql)
        'cargamos en el parametro enviado por referencia
        dt_operacion.Fill(dtt_registros)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test", Err)
        Err.Clear()
    End Sub



    Sub LlenarGridImpresoras(ByRef data As DataView)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerImpresoras().Tables("Registros")
    End Sub

    Public Function LeerImpresoras() As DataSet
        'Funcion para la consultar los datos de la tabla ANTIBIOTICO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()
        oda_operacion.SelectCommand = New SqlCommand("select impresora.IMP_ID, impresora.IMP_IMPRESORA, impresora.IMP_REPORTE, impresora.IMP_OBJETO from impresora;", opr_Conexion.conn_sql)
        LeerImpresoras = New DataSet("IMPRESORAS")

        oda_operacion.Fill(LeerImpresoras, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer IMPRESORAS", Err)
        Err.Clear()

    End Function



    Public Sub GuardarImpresora(ByVal imp_id As Integer, ByVal imp_impresora As String, ByVal imp_reporte As String, ByVal imp_objeto As String)
        'Funcion para guardar el rango de normalidad Unico de un test.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String


        opr_Conexion.sql_conectar()
        STR_SQL = "Insert into IMPRESORA values (" & imp_id & ", '" & imp_impresora & "','" & imp_reporte & "' , '" & imp_objeto & "')"

        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Ingresa impresora ", "IMP= " & imp_id, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Rango Unico", Err)
        Err.Clear()
    End Sub


    Public Function LeerEquipoTest(ByVal byt_buscar As Byte) As DataSet
        'busca el quipos activo por test
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_equipo As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        Select Case byt_buscar
            Case 0
                oda_equipo.SelectCommand = New SqlCommand("SELECT equ_modelo, equipo.equ_id, tes_id, equipo.equ_estado FROM equipo, test_equipo where equipo.equ_id=test_equipo.equ_id and teq_estado=1 ", opr_conexion.conn_sql)
            Case 1
                oda_equipo.SelectCommand = New SqlCommand("SELECT equ_modelo, equipo.equ_id, tes_id, equipo.equ_estado FROM equipo, test_equipo where equipo.equ_id=test_equipo.equ_id and teq_prioridad=1 and teq_estado=1 ", opr_conexion.conn_sql)
        End Select
        LeerEquipoTest = New DataSet()
        oda_equipo.Fill(LeerEquipoTest, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Equipo Test", Err)
        Err.Clear()
    End Function

    Public Sub GuardarRangoU_TestEquipos(ByVal equ_id As Integer, ByVal test_id As Integer, ByVal trango As Integer, ByVal rangInf As Double, ByVal rangSup As Double, ByVal abrev As String, ByVal genero As String, ByVal uni_id As Integer, ByVal teq_id As Integer)
        'Funcion para guardar el rango de normalidad Unico de un test.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String

        Select Case genero
            Case "" : genero = "MUJER"
            Case "H" : genero = "HOMBRE"
            Case "N" : genero = "NIÑO"
            Case "R" : genero = "RN"
        End Select

        opr_Conexion.sql_conectar()
        STR_SQL = "Insert into TEST_EQUIPO values (" & test_id & ", " & uni_id & ", " & equ_id & ", 1, 1," & rangInf & ", " & rangSup & ", '', 1,'" & genero & "', '" & abrev & "', '" & teq_id & "')"

        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Rango Unico", "Test=" & test_id & " Rango=" & rangInf & "-" & rangSup, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Rango Unico", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarRangoM_TestEquipos(ByVal equ_id As Integer, ByVal test_id As Integer, ByVal trango As Integer, ByVal rangInf As Double, ByVal rangSup As Double, ByVal abrev As String, ByVal genero As String, ByVal uni_id As Integer, ByVal teq_id As Integer)
        'Funcion para guardar el rango de normalidad Unico de un test.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String


        opr_Conexion.sql_conectar()
        STR_SQL = "Insert into TEST_EQUIPO values (" & test_id & ", " & uni_id & ", " & equ_id & ", 1, 1," & rangInf & ", " & rangSup & ", '', 1,'" & genero & "', '" & abrev & "', '" & teq_id & "')"

        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Rango Unico", "Test=" & test_id & " Rango=" & rangInf & "-" & rangSup, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Rango Unico", Err)
        Err.Clear()
    End Sub



    Public Sub GuardarTestResultado(ByVal test_id As Integer, ByVal res_id As Integer, ByVal trango As Integer)
        'Funcion para guardar el rango de normalidad Unico de un test.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String

        opr_Conexion.sql_conectar()
        STR_SQL = "Insert into test_resultado values (" & test_id & ", " & res_id & ", " & trango & ", '', '', '');"

        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Inserta TEST RESULTADO", "Test=" & test_id & " Rango = " & trango & "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Rango Unico", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizaRangoU_TestEquipos(ByVal teq_id As Integer, ByVal test_id As Integer, ByVal trango As Integer, ByVal rangInf As Double, ByVal rangSup As Double, ByVal abrev As String, ByVal genero As String)
        'Funcion para guardar el rango de normalidad Unico de un test.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String


        opr_Conexion.sql_conectar()
        STR_SQL = "Update TEST_EQUIPO set teq_trango = " & trango & ", teq_ranmin = " & rangInf & ", teq_ranmax = " & rangSup & ", teq_ranmul = '' , TEQ_ABRV_FIJA = '" & abrev & "'" & _
                  "where teq_abreviatura = '" & genero & "' and teq_id = " & teq_id & " and tes_id = " & test_id & ""
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Rango Unico", "Test=" & test_id & " Rango=" & rangInf & "-" & rangSup, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Rango Unico", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizaRangoM_TestEquipos(ByVal equ_id As Integer, ByVal test_id As Integer, ByVal trango As Integer, ByVal rango As String, ByVal abrev As String, ByVal teq_id As Integer)
        'Funcion para guardar el rango de normalidad M�ltiple (Tabla) de un test.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "Update TEST_EQUIPO set teq_trango = " & trango & ", teq_ranmin = 0, teq_ranmax = 0, teq_abreviatura = '" & abrev & "', teq_ranMul = '" & rango & "' where teq_id = " & teq_id & " and tes_id = " & test_id & " and equ_id = " & equ_id & ""
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Rango Multiple", "Test= " & test_id & " Rango=" & rango, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Rango Multiple", Err)
        Err.Clear()
    End Sub


    Public Sub Elimina_TestEquipos(ByVal teq_id As Integer)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "delete from TEST_EQUIPO where teq_id = '" & teq_id & "'; "
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliina Rango Multiple", "Teq_id=" & teq_id, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Rango", Err)
        Err.Clear()
    End Sub

    Public Sub GuardarRangoM_TestEquipos(ByVal equ_id As Integer, ByVal test_id As Integer, ByVal trango As Integer, ByVal rango As String, ByVal abrev As String, ByVal uni_id As Integer, ByVal abrev_fija As String, ByVal teq_id As Integer)
        'Funcion para guardar el rango de normalidad M�ltiple (Tabla) de un test.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "insert into TEST_EQUIPO values (" & test_id & "," & uni_id & "," & equ_id & ",1, " & trango & ", '','','" & rango & "', 1,'" & abrev & "','" & abrev_fija & "', " & teq_id & "); "
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Rango Multiple", "Test=" & test_id & " Rango=" & rango, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Rango Multiple", Err)
        Err.Clear()
    End Sub


    Function InstalaEquipo(ByRef bar_instala As ProgressBar, ByVal opr_leeArchivo As Cls_IniFile) As Integer
        Dim int_indice, int_tiempo As Double
        Dim int_numEqp, int_cont, int_cambiasigla, int_tubo As Short
        Dim STR_SQL, str_marca, str_modelo, str_muestras, str_muestrasID, str_prioridades, str_aux, str_test As String
        Dim opr_conexion As New Cls_Conexion()
        'Dim ocd_instala As New SqlCommand()
        'Dim ott_instala As OleDbTransaction
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim dts_instala As New DataSet()
        Dim int_codid As Integer
        On Error GoTo MsgErr
        InstalaEquipo = 0
        str_muestras = ""
        str_prioridades = ""
        int_cambiasigla = 0
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'Tipo de tubo que usa el equipo, 1 tubo con c�digo de barras, 2 copa o tubo sin c�sigo de barras, 3 ambos
        With opr_leeArchivo
            int_numEqp = LeerMaxCodEqui() + 1     'm�ximo c�digo de equipo
            int_codid = LeerMaxCodEquiTest() + 1  'm�ximo c�digo de test_equipo
            str_marca = "<Nuevo> " & .ReadString("Generalidades", "Marca")
            str_modelo = "<Nuevo> " & .ReadString("Generalidades", "Modelo")
            int_tubo = .ReadString("Generalidades", "Tubos", 0)
            If Trim(LCase(.ReadString("Generalidades", "CmbSigla"))) = "si" Then
                int_cambiasigla = 1
            End If
            For int_cont = 1 To .ReadString("Generalidades", "Muestras")
                str_aux = int_cont
                str_aux = str_aux.PadLeft(2, "0")
                str_muestras = .ReadString("Muestra" & str_aux, "IdLis") & "," & str_muestras
                str_muestrasID = .ReadString("Muestra" & str_aux, "IdEquipo") & "-" & .ReadString("Muestra" & str_aux, "IdLis") & "," & str_muestrasID
            Next
            For int_cont = 1 To .ReadString("Generalidades", "Priorida")
                str_aux = int_cont
                str_aux = str_aux.PadLeft(2, "0")
                str_prioridades = .ReadString("Prioridad" & str_aux, "IdEquipo") & "-" & .ReadString("Prioridad" & str_aux, "IdLis") & "," & str_prioridades
            Next
            If Len(Trim(str_muestras)) > 0 Then str_muestras = Mid(Trim(str_muestras), 1, Len(str_muestras) - 1)
            If Len(Trim(str_muestrasID)) > 0 Then str_muestrasID = Mid(Trim(str_muestrasID), 1, Len(str_muestrasID) - 1)
            If Len(Trim(str_prioridades)) > 0 Then str_prioridades = Mid(Trim(str_prioridades), 1, Len(str_prioridades) - 1)
            STR_SQL = "Insert into EQUIPO (EQU_ID, EQU_MARCA, EQU_MODELO, EQU_SERIE, EQU_FECING, EQU_TUBO, EQU_MUESTRA, EQU_MUESTRAID, EQU_PRIORIDADES, EQU_SIGLACAMBIO, EQU_ESTADO)  " & _
            "values (" & int_numEqp & ", '" & str_marca & "', '" & str_modelo & "', '<Nuevo>', '" & Today & "', " & _
            int_tubo & ", '" & str_muestras & "','" & str_muestrasID & "','" & str_prioridades & "'," & int_cambiasigla & ", 1)"
            'ocd_instala.CommandText = STR_SQL
            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Equipo", "Equipo=" & str_marca, g_sng_user, "", "", "")
            bar_instala.Value = 100
            int_tiempo = .ReadInteger("Generalidades", "CantTest", 0)
            int_tiempo = Fix((bar_instala.Maximum - 100) / int_tiempo)
            'Tipos de resultado del test a instalar
            'Numerica  	    -> 1        Texto		    -> 2       Cualitativa	-> 3
            'Formula		-> 4        Microbiologia   -> 5       Funcional	-> 6
            'Grafico		-> 7
            'Instalaci�n de test por equipo
            For int_indice = 1 To .ReadInteger("Generalidades", "CantTest", 0)
                str_test = int_indice
                str_test = "Test" & str_test.PadLeft(5, "0")
                'inserta en la tabla test por equipo
                STR_SQL = "Insert into TEST_EQUIPO (TES_ID, UNI_ID, EQU_ID, TEQ_ESTADO, TEQ_TRANGO, TEQ_RANMIN, TEQ_RANMAX, TEQ_RANMUL, TEQ_PRIORIDAD, TEQ_ABREVIATURA, TEQ_ABRV_FIJA, TEQ_ID) " & _
                "VALUES (" & .ReadString(str_test, "Codigo") & ", " & CShort(.ReadString(str_test, "UnidadID", 0)) & ", " & int_numEqp & ", 0, 0, 0, 0, '', 0, '" & .ReadString(str_test, "Abrv_pre") & "', '" & .ReadString(str_test, "Abrv_eqp") & "', " & int_codid & ")"
                odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()
                'inserta en la tabla de unidades por test por equipo
                STR_SQL = "Insert into TESTEQUIPO_TIPMUESTRA (TEQ_ID, TIM_ID) " & _
                "VALUES (" & int_codid & "," & CShort(.ReadString(str_test, "Muestras")) & ")"
                odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()
                int_codid = int_codid + 1
                If bar_instala.Value + int_tiempo < bar_instala.Value.MaxValue Then bar_instala.Value = bar_instala.Value + int_tiempo
                g_opr_usuario.CargarTransaccion(g_str_login, "Registrar Test por Equipos", "", g_sng_user, "", "", "")
            Next
        End With
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        InstalaEquipo = 1
        MsgBox("Instalacion Satisfactoria", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgErr:
        g_opr_usuario.MensajeBoxError("Instalacion Interrumpida, Consulte con su proveedor", Err)
        InstalaEquipo = 0
        bar_instala.Value = 0
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        Err.Clear()
    End Function

    Public Function Leer_Test_Activ_Predet(ByRef equ_id As Integer) As DataSet
        'funci�n para consultar los test activos y predeterminados de un equipo de un equipo
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT " & _
        "TEST_EQUIPO.EQU_ID, TEST.TES_ID, TEST.TES_NOMBRE, TEST_EQUIPO.TEQ_ESTADO," & _
        "TEST_EQUIPO.TEQ_PRIORIDAD FROM TEST INNER JOIN (EQUIPO INNER JOIN " & _
        "TEST_EQUIPO ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) ON TEST.TES_ID = " & _
        "TEST_EQUIPO.TES_ID WHERE (((TEST_EQUIPO.EQU_ID)= " & equ_id & ") AND " & _
        "(( TEST_EQUIPO.TEQ_ESTADO)=1) AND ((TEST_EQUIPO.TEQ_PRIORIDAD)=1))", opr_Conexion.conn_sql)
        Leer_Test_Activ_Predet = New DataSet("Registros")
        oda_operacion.Fill(Leer_Test_Activ_Predet, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer TestActivPredet", Err)
        Err.Clear()
    End Function

    Public Sub Desact_Test_equipo(ByVal tes_id As Integer, ByVal equ_id As Integer)
        'Procedimiento que cambia el estado del test a no activo y prioridad 0 (normal), pero al mismo
        'tiempo dsactiva los test ocupados por test
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        'Mucho ojo con el teq_estado cuando desactiva un equipo, ya que deshabilita los ex�menes
        STR_SQL = "Update TEST_EQUIPO set TEQ_ESTADO = 0, " & _
                "TEQ_PRIORIDAD=0   " & _
                "where TES_ID=" & tes_id & " and  EQU_ID=" & equ_id
        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Desactivar test por equipo", "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Registrar datos Test por Equipos", Err)
        Err.Clear()
    End Sub

    Public Sub LeerParametros(ByRef dtt_registros As DataTable, ByVal equ_id As Integer)
        'Funcion para la consultar los datos de la tabla TEST, abarca los que tengan de tes_parametro = 0
        'eso significa que son a nivel de test que abarcan los test que son como parametros
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        Dim str_sql = "select d.tes_nombre as tes_nombre, c.equ_id as equ_id, a.teq_id as teq_id, " & _
                      "e.tim_nombre, a.tim_id as tim_id, a.dis_factor as dis_factor, a.tim_default as tim_default, " & _
                      "if(a.tub_default = 1, 'Tubo Primario', 'Copa') " & _
                      "as dgcs_eqp from testequipo_tipmuestra as a, test_equipo as b, equipo as c, " & _
                      "test as d, tipo_muestra as e where a.teq_id = b.teq_id And b.tes_id = d.tes_id " & _
                      " And b.equ_id = c.equ_id And a.tim_id = e.tim_id And b.equ_id = " & equ_id & " order by " & _
                      "tes_nombre, equ_modelo, tim_nombre"
        'dt_operacion.SelectCommand = New SqlCommand("SELECT TES_ID, TES_NOMBRE FROM TEST where TES_PARAMETRO=0 order by TES_nombre", opr_Conexion.conn_sql)
        dt_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        'cargamos en el parametro enviado por referencia
        dt_operacion.Fill(dtt_registros)
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Parametros", Err)
        Err.Clear()
    End Sub

    Public Sub GuardarParametrosEquipo(ByVal TablaTest As DataTable)
        'Procedimiento para la predeterminaci�n de equipos por test
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim int_prioridad, int_eqp As Single
        Dim int_cont, var1, var2, int_cont2, TestId, EqpId As Integer
        Dim x As Short = 0
        'Realizo una verificaci�n de los datos ingresados en el grid

        For int_cont = 0 To TablaTest.Rows.Count - 1
            var1 = TablaTest.Rows.Item(int_cont).Item(2)   'Guardo el Teq_id 
            var2 = TablaTest.Rows.Item(int_cont).Item(5)   'Guardo el tim_default
            If var2 = 1 Then
                'Verifico que una prueba no tenga 2 o m�s muestras por defecto
                For int_cont2 = int_cont + 1 To TablaTest.Rows.Count - 1
                    If var1 = TablaTest.Rows.Item(int_cont2).Item(2) And var2 = TablaTest.Rows.Item(int_cont2).Item(5) Then  'Guardo el Teq_id
                        MsgBox("La prueba " & TablaTest.Rows.Item(int_cont).Item(0) & " no puede tener mas de 1 muestra por defecto", MsgBoxStyle.Exclamation, "ANALISYS")
                        Exit Sub
                    End If
                Next
            Else
                'Verifico que la prueba tenga por defecto 1 muestra
                Dim boo_flag = False
                For int_cont2 = 0 To TablaTest.Rows.Count - 1
                    If var1 = TablaTest.Rows.Item(int_cont2).Item(2) And TablaTest.Rows.Item(int_cont2).Item(5) = 1 Then  'Guardo el Teq_id
                        boo_flag = True
                        Exit For
                    End If
                Next
                If boo_flag = False Then
                    MsgBox("La prueba " & TablaTest.Rows.Item(int_cont).Item(0) & " no posee ninguna muestra por defecto", MsgBoxStyle.Exclamation, "ANALISYS")
                    Exit Sub
                End If
            End If
        Next

        Dim odc_pedido As New SqlCommand()
        opr_Conexion.sql_conectar()
        'Una vez verificada la Informacion la almacenamos 
        For int_cont = 0 To TablaTest.Rows.Count - 1
            If (TablaTest.Rows.Item(int_cont).Item(7) = "Tubo Primario") Then
                x = 1
            Else
                x = 2
            End If
            STR_SQL = "Update testequipo_tipmuestra set dis_factor= " & TablaTest.Rows.Item(int_cont).Item(6) & ", tim_default = " & TablaTest.Rows.Item(int_cont).Item(5) & ", tub_default = " & x & " where " & _
                      "teq_id = " & TablaTest.Rows.Item(int_cont).Item(2) & " and tim_id = " & TablaTest.Rows.Item(int_cont).Item(4) & " "
            odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
        Next
        g_opr_usuario.CargarTransaccion(g_str_login, "Parametros de Equipo", "", g_sng_user, "", "", "")
        MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Parametros Equipo, Cls_equipos", Err)
        Err.Clear()
    End Sub

    Public Function equipoNombre(ByVal testid As Integer) As Integer

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select equipo.equ_modelo, equipo.equ_id from equipo, test_equipo where test_equipo.equ_id = equipo.equ_id and test_equipo.tes_id = " & testid & "", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            equipoNombre = dtr_fila(1)
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Nombre Equipo", Err)
        Err.Clear()
    End Function


    Public Function DevuelveImpresora(ByVal objeto As String) As String

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select impresora.IMP_IMPRESORA from impresora where impresora.imp_objeto = '" & objeto & "'", opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        oda_operacion.Fill(dts_area, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            DevuelveImpresora = Trim(dtr_fila(0))
        Next
        If DevuelveImpresora = "" Then
            oda_operacion.SelectCommand = New SqlCommand("select impresora.IMP_IMPRESORA from impresora where imp_id = 1;", opr_Conexion.conn_sql)
            oda_operacion.Fill(dts_area, "Registros")
            Dim dtr_fila1 As DataRow
            For Each dtr_fila1 In dts_area.Tables("Registros").Rows
                DevuelveImpresora = Trim(dtr_fila1(0))
            Next
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, devuelve impresora", Err)
        Err.Clear()
    End Function

End Class
