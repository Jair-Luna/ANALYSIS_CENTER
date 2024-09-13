'*************************************************************************
' Nombre:   Cls_Test
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de los tests
' Autores:  RFN
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Test
    

    Public Function BuscaDatosTest(ByVal test_nombre As String, ByVal convenio As String) As String
        'Procedimiento para consultar todos los test y su porecio por convenio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select area.ARE_NOMBRE, tes_nombre, test.tes_id, lip_precio, 'E' as Perfil from test, lista_precio, area where lista_precio.tes_id=test.tes_id and TES_PARAMETRO <>1 and area.ARE_ID = test.ARE_ID and test.TES_NOMBRE = '" & Trim(test_nombre) & "' and lista_precio.CON_NOMBRE = '" & convenio & "'" & _
                                "union select '' as are_nombre, PER_NOMBRE as tes_nombre, PER_ID as tes_id, '' as lip_precio , 'P' as Perfil from perfil where PER_ESTADO = 1 and PER_NOMBRE = '" & test_nombre & "' " & _
                                "order by ARE_NOMBRE, tes_nombre"
        opr_conexion.sql_conectar()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            BuscaDatosTest = odr_operacion(0) & "," & test_nombre.ToUpper() & "," & odr_operacion(2) & "," & odr_operacion(3) & "," & odr_operacion(4)
        End While

        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Convenio Tarifa", Err)
        Err.Clear()
    End Function


    Sub LlenarComboOcupacion(ByRef cmb_ocupacion As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "Select ocu_descripcion, ocu_id from ocupacion where ocu_estado  = 1 order by ocu_descripcion asc ;"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_ocupacion.Items.Clear()
        While odr_operacion.Read
            cmb_ocupacion.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & odr_operacion.GetValue(1).ToString().PadRight(5))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_ocupacion.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar Ocupacion", Err)
        Err.Clear()
    End Sub


    Public Function LeerAbrevFija(ByVal tes_id As Integer, ByVal eqp_id As Integer) As DataSet
        'Procedimiento para consultar la abreviatura de un test seg�n el equipo de procesamiento
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_test.SelectCommand = New SqlCommand("Select TEQ_ABRV_FIJA from test_equipo where tes_id = " & tes_id & " and equ_id = " & eqp_id & "", opr_Conexion.conn_sql)
        LeerAbrevFija = New DataSet()
        oda_test.Fill(LeerAbrevFija, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer AbrevFija", Err)
        Err.Clear()
    End Function

    Public Function LeerTest(ByVal con_nombre As String, ByVal Lista_Areas As String, ByVal Tipo As String) As DataSet
        'Procedimiento para consultar todos los test y su porecio por convenio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select area.ARE_NOMBRE, tes_nombre, test.tes_id, lip_precio from test, lista_precio, area where lista_precio.tes_id=test.tes_id and TES_PARAMETRO <>1 and area.ARE_ID = test.ARE_ID and con_nombre='" & con_nombre & "' and test.TES_TIPO = '" & Tipo & "' and " & Lista_Areas & " order by ARE_NOMBRE, tes_nombre"
        opr_conexion.sql_conectar()
        oda_test.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerTest = New DataSet()
        oda_test.Fill(LeerTest, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test convenio", Err)
        Err.Clear()
    End Function



    Public Function LeerColeccionMedico(ByVal ColeccionMed As AutoCompleteStringCollection, ByVal tipo As String)
        'funcion para la obtencion de los datos
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select med_nombre, med_id, med_mail from Medico where med_obs = '" & tipo & "' and med_id > 0 order by med_nombre asc ;"
        opr_Conexion.sql_conectar()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        ColeccionMed.Clear()

        While odr_operacion.Read
            'ColeccionMed.AddRange(New String() {odr_operacion(0).ToString.PadRight(100) & odr_operacion(1).ToString.PadRight(5) & odr_operacion(2).ToString.PadRight(100)})
            ColeccionMed.AddRange(New String() {odr_operacion(0).ToString.PadRight(100) & odr_operacion(1).ToString.PadRight(5)})
        End While

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Tipo Res AB", Err)
        Err.Clear()
    End Function


    Public Function LeerColeccionOcup(ByVal ColeccionOcup As AutoCompleteStringCollection)
        'funcion para la obtencion de los datos
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select ocu_descripcion, ocu_id from Ocupacion where ocu_estado = 1 order by ocu_descripcion asc ;"
        opr_Conexion.sql_conectar()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        ColeccionOcup.Clear()

        While odr_operacion.Read
            ColeccionOcup.AddRange(New String() {odr_operacion(0).ToString.PadRight(100) & odr_operacion(1).ToString.PadRight(5)})
        End While

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Tipo Res AB", Err)
        Err.Clear()
    End Function




    Public Function LeerTestColeccion(ByVal Coleccion As AutoCompleteStringCollection, ByVal Lista_areas As String, ByVal con_nombre As String, ByVal Tipo As String)
        'funcion para la obtencion de los datos
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select tes_nombre, test.tes_id, lip_precio, area.ARE_NOMBRE, 'E' as Perfil from test, lista_precio, area where lista_precio.tes_id=test.tes_id and TES_PARAMETRO <>1 and area.ARE_ID = test.ARE_ID and con_nombre='" & con_nombre & "' and test.TES_TIPO = '" & Tipo & "' and " & Lista_areas & _
                                " union select PER_NOMBRE as tes_nombre, PER_ID as tes_id, '' as lip_precio, '' as are_nombre, 'P' as Perfil from perfil where PER_ESTADO = 1" & _
                               " order by ARE_NOMBRE, tes_nombre"
        opr_Conexion.sql_conectar()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        Coleccion.Clear()

        While odr_operacion.Read
            Coleccion.AddRange(New String() {odr_operacion(0)})
        End While

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Tipo Res AB", Err)
        Err.Clear()
    End Function

    Public Function LeerConvenioColeccion(ByVal Coleccion As AutoCompleteStringCollection, ByVal Lista_areas As String, ByVal con_nombre As String, ByVal Tipo As String)
        'funcion para la obtencion de los datos
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select tes_nombre, test.tes_id, lip_precio, area.ARE_NOMBRE, 'E' as Perfil from test, lista_precio, area where lista_precio.tes_id=test.tes_id and TES_PARAMETRO <>1 and area.ARE_ID = test.ARE_ID and con_nombre='" & con_nombre & "' and test.TES_TIPO = '" & Tipo & "' and " & Lista_areas & _
                                " union select PER_NOMBRE as tes_nombre, PER_ID as tes_id, '' as lip_precio, '' as are_nombre, 'P' as Perfil from perfil where PER_ESTADO = 1" & _
                               " order by ARE_NOMBRE, tes_nombre"
        opr_Conexion.sql_conectar()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        Coleccion.Clear()

        While odr_operacion.Read
            Coleccion.AddRange(New String() {odr_operacion(0)})
        End While

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Tipo Res AB", Err)
        Err.Clear()
    End Function


    Sub LlenarGridTest_CodNom(ByRef dtv_test As DataView, ByVal con_nombre As String, ByVal Lista_Areas As String, ByVal tipo As String)
        'funcion que llena en un datagrid los datos de los test seg�n el parametro enviado        
        dtv_test.Table = LeerTest(con_nombre, Lista_Areas, tipo).Tables("Registros")
    End Sub

    Public Function LeerPrecioTest(ByVal tes_id As Integer, ByVal con_nombre As String) As Double
        'Procedimiento para el precio de un test por ID y por convenio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_test As New DataSet()
        Dim dtr_test As DataRow
        Dim STR_SQL As String

        LeerPrecioTest = 0
        opr_conexion.sql_conectar()
        STR_SQL = "Select lip_precio, test.tes_id  from test, lista_precio where test.tes_id = " & tes_id & " and  test.tes_id=lista_precio.tes_id and con_nombre='" & con_nombre & "'"
        oda_test.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_test.Fill(dts_test, "Registros")
        If dts_test.Tables(0).Rows.Count > 0 Then
            dtr_test = dts_test.Tables(0).Rows(0)
            If Not IsDBNull(dtr_test(0)) Then
                LeerPrecioTest = dtr_test(0)
            End If
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Precio Test", Err)
        Err.Clear()
    End Function

    Public Function LeerTestRangos() As DataSet
        'Funcion para la consultar los rangos de normalidad de todos los test
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "SELECT IF(TEST.TES_TPROCES =1,'EQUIPO','MANUAL') AS TES_TPROCES, TEST.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, UNIDAD.UNI_ID as uni_id, " & _
        "UNIDAD.UNI_NOMENCLATURA as uni_nomenclatura, TEST_RESULTADO.RANG_TIPO as rang_tipo, TEST_RESULTADO.RANG_MIN as rang_min, " & _
        "TEST_RESULTADO.RANG_MAX as rang_max, TEST_RESULTADO.RANG_MUL as rang_mul FROM UNIDAD INNER JOIN " & _
        "(TEST INNER JOIN TEST_RESULTADO ON TEST.TES_ID = TEST_RESULTADO.TES_ID) ON " & _
        "UNIDAD.UNI_ID = TEST.UNI_ID"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerTestRangos = New DataSet("Registros")
        oda_operacion.Fill(LeerTestRangos, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Rangos", Err)
        Err.Clear()
    End Function

    Public Sub GuardarRangoN_Test(ByVal Tipo As String, ByVal test_id As Integer, ByVal tipo_rango As Short, ByVal rangInf As Double, ByVal rangSup As Double, ByVal rangMul As String)
        'Funcion para guardar el rango de normalidad de un test sea sin rango, unico o multiple.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_equipos As New Cls_equipos()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        If Tipo <> "EQUIPO" Then
            ''''' GUARDO VALORES DE REFERENCIA PARA EXAMENES MANUALES
            If tipo_rango = 1 Then  'Rango Unico
                STR_SQL = "Update TEST_RESULTADO set rang_tipo = 1, rang_min = " & rangInf & ", rang_max = " & _
                           rangSup & ", rang_mul = ' ' where tes_id = " & test_id & ""
            Else
                If tipo_rango = 2 Then '--> Rango multiple
                    STR_SQL = "Update TEST_RESULTADO set rang_tipo = 2, rang_min = NULL, rang_max = NULL," & _
                              " rang_mul = '" & rangMul & "' where tes_id = " & test_id & ""

                Else  'Igual a Cero --> No tiene rango
                    STR_SQL = "Update TEST_RESULTADO set rang_tipo = 0, rang_min = NULL, rang_max = NULL, " & _
                              "rang_mul = Null where tes_id = " & test_id & ""
                End If
            End If

        Else
            ''''' GUARDO VALORES DE REFERENCIA PARA EXAMENES CON EQUIPO



        End If

        Dim odc_operacion As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Rango Unico", "TEST=" & test_id & "/" & rangInf & "/" & rangSup, g_sng_user, "", "", test_id)
        Exit Sub
MsgError: MsgBox("No se pudo realizar la transaccion solicitada, Cls_Test GuardarRangoU_Test", MsgBoxStyle.Exclamation, "ANALISYS")
        Err.Clear()
    End Sub


    Public Sub ConsultaTestManualesPendientes(ByRef arr_test As ArrayList, ByVal con_nombre As String)
        'funci�n que consulta los todos test manuales pendientes
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        '0  tes_nombre      1   tes_id              2   uni_nom         3   ran_tip
        '4  ran_min         5   ran_max             6   ran_mul         7   res_id
        str_sql = "SELECT distinct(TEST.TES_NOMBRE) as tes_nombre, LISTA_TRABAJO.TES_ID as tes_id, UNIDAD.UNI_NOMENCLATURA as uni_nom, TEST_EQUIPO.TEQ_TRANGO  as ran_tip, test_equipo .TEQ_RANMIN  as ran_min, TEST_EQUIPO.TEQ_RANMAX as ran_max, TEST_EQUIPO.TEQ_RANMUL  as ran_mul, TEST_RESULTADO.RES_ID as res_id, TEST.TES_LIS as abrev " & _
                  "from test, unidad, lista_trabajo, test_resultado, test_equipo, pedido " & _
                  "where pedido.PED_ID = lista_trabajo.PED_ID and pedido.CON_NOMBRE = '" & con_nombre & "' and test.TES_ID = lista_trabajo .TES_ID and unidad.UNI_ID = test.UNI_ID and test_resultado.TES_ID = test.TES_ID and test_resultado.TES_ID = lista_trabajo.TES_ID and test_equipo.TES_ID = test.TES_ID " & _
                  "order by TEST.TES_NOMBRE asc; "
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        arr_test.Clear()
        While odr_operacion.Read
            'ascci 145
            arr_test.Add(odr_operacion.GetValue(0).ToString.PadRight(150) & "º" & odr_operacion.GetValue(1) & "º" & odr_operacion.GetValue(2) & "º" & odr_operacion.GetValue(3) & "º" & odr_operacion.GetValue(4) & "º" & odr_operacion.GetValue(5) & "º" & odr_operacion.GetValue(6) & "º" & odr_operacion.GetValue(7) & "º" & odr_operacion.GetValue(8))
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
    End Sub

    Public Sub ConsultaTestManualesPendientes(ByRef arr_test As ArrayList, ByVal testid As Integer, ByVal fechaI As String, ByVal fechaF As String, ByVal tipo As String)
        'funci�n que consulta el detalle de los test manuales pendientes deacuerdo a test especifico
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim mes_aux, dia_aux As String


        opr_conexion.sql_conectar()
        '0  ped_id      1   ped_fecing      2   paciente        3   ped_tipo        4   lis_id
        str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, " & _
        "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS paciente, PEDIDO.PED_TIPO as ped_tipo, LISTA_TRABAJO.LIS_ID, " & _
        "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, test.TIM_ID as tim_id " & _
        "FROM TEST " & _
        "INNER JOIN PACIENTE  " & _
        "INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
        "INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID ON TEST.TES_ID = LISTA_TRABAJO.TES_ID  " & _
        "WHERE (LISTA_TRABAJO.LIS_RESESTADO=0 or LISTA_TRABAJO.LIS_RESESTADO=1) and LISTA_TRABAJO.TES_ID = " & testid & " and LISTA_TRABAJO.LIS_FECING between '" & fechaI & " 00:00:00' and '" & fechaF & " 23:59:00' and PEDIDO.CON_NOMBRE = '" & tipo & "' ORDER BY  PEDIDO.ped_turno asc, PEDIDO.PED_FECING desc"
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        arr_test.Clear()
        While odr_operacion.Read
            arr_test.Add(odr_operacion.GetValue(0) & "º" & odr_operacion.GetValue(1) & "º" & odr_operacion.GetValue(2) & "º" & odr_operacion.GetValue(3) & "º" & odr_operacion.GetValue(4) & "º" & odr_operacion.GetValue(5) & "º" & odr_operacion.GetValue(6))
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
    End Sub




    Public Sub AlmacenaTestManualesPendientes(ByVal fec_valida As Date, ByVal dtt_tabla As DataTable, ByVal testid As Integer, ByVal rango As String, Optional ByVal TIPO As Short = 0)
        '07/Ago/2003
        'funci�n que guarda los resultados de los test ingresados en serie, y cambia de estado a los test
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim int_cont As Short
        Dim arreglo As String()
        Dim resul As String = Nothing
        Dim prc_error As String = Nothing
        Dim opr_pedido As New Cls_Pedido()


        opr_conexion.sql_conectar()

        arreglo = Split(rango, "-")

        If (arreglo.Length > 2) Then

        End If

        If TIPO = 0 Then
            'CUANDO ES SOLO GUARDAR EL RESULTADO
            For int_cont = 0 To dtt_tabla.Rows.Count - 1
                If Not IsDBNull(dtt_tabla.Rows(int_cont).Item(6)) Then
                    If dtt_tabla.Rows(int_cont).Item(6) <> "" Then


                        str_sql = "Update res_procesados set PRC_RESUL ='" & dtt_tabla.Rows(int_cont).Item(6) & "', " & _
                        "PRC_RESFINAL ='" & dtt_tabla.Rows(int_cont).Item(6) & "', PRC_RANGO = '" & rango & "', PRC_ALARMA = '" & prc_error & "' WHERE PED_ID= " & dtt_tabla.Rows(int_cont).Item(0) & " and (TES_ABREV = '" & dtt_tabla.Rows(int_cont).Item(7) & "' or TES_ABREV = '" & dtt_tabla.Rows(int_cont).Item(7) & "H' or TES_ABREV = '" & dtt_tabla.Rows(int_cont).Item(7) & "N' or TES_ABREV = '" & dtt_tabla.Rows(int_cont).Item(7) & "R') and TIM_ID = " & dtt_tabla.Rows(int_cont).Item(8) & " "
                        Dim odc_operacion As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
                        odc_operacion.ExecuteNonQuery()
                        opr_pedido.ActualizarPdd_Estado(dtt_tabla.Rows(int_cont).Item(0), testid, 1)
                        opr_pedido.ActualizarLis_resEstado(dtt_tabla.Rows(int_cont).Item(0), testid, 1, Now)
                    End If
                End If
            Next
        Else
            'CUANDO SE GRABA EL RESULTADO Y SE VALIDA ' *** Y SE ENVIA A MIS JPO
            Dim ordenMIS As String
            'Dim opr_as400 As Cls_AS400
            Dim RES_MIS As String

            For int_cont = 0 To dtt_tabla.Rows.Count - 1
                If Not IsDBNull(dtt_tabla.Rows(int_cont).Item(6)) Then
                    If dtt_tabla.Rows(int_cont).Item(6) <> "" Then
                        str_sql = "Update res_procesados set PRC_RESUL ='" & dtt_tabla.Rows(int_cont).Item(6) & "', " & _
                         "PRC_RESFINAL ='" & dtt_tabla.Rows(int_cont).Item(6) & "', PRC_RANGO = '" & rango & "', PRC_ALARMA = '" & prc_error & "', LIS_USER = " & g_invitadoID & ", LIS_FECVALIDADO = '" & Format(fec_valida, "dd/MM/yyyy hh:mm:ss") & "' WHERE PED_ID= " & dtt_tabla.Rows(int_cont).Item(0) & " and (TES_ABREV  = '" & dtt_tabla.Rows(int_cont).Item(7) & "H' or TES_ABREV = '" & dtt_tabla.Rows(int_cont).Item(7) & "H' or TES_ABREV = '" & dtt_tabla.Rows(int_cont).Item(7) & "N' or TES_ABREV = '" & dtt_tabla.Rows(int_cont).Item(7) & "R') and TIM_ID = " & dtt_tabla.Rows(int_cont).Item(8) & " "
                        Dim odc_operacion As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
                        odc_operacion.ExecuteNonQuery()
                        opr_pedido.ActualizarPdd_Estado(dtt_tabla.Rows(int_cont).Item(0), testid, 3)
                        opr_pedido.ActualizarLis_resEstado(dtt_tabla.Rows(int_cont).Item(0), testid, 2, fec_valida)
                        opr_pedido.ActualizarEstadoPedido(dtt_tabla.Rows(int_cont).Item(0), 5)

                        '*****************************************
                    End If
                End If
            Next
        End If
        opr_conexion.sql_desconn()
    End Sub


    'Public Sub AlmacenaTestManualesPendientes(ByVal dtt_tabla As DataTable, ByVal testid As Short, ByVal rango As String, Optional ByVal tipo As Byte = 0)
    '    '    'funci�n que guarda los resultados de los test ingresados en serie, y cambia de estado a los test
    '    '    '13/Oct/2004 JPO:  Este procedimiento permite guardar los resultados si tipo = 0 y los valida si tipo = 1
    '    Dim opr_conexion As New Cls_Conexion()
    '    Dim str_sql As String
    '    Dim int_cont As Short
    '    opr_Conexion.conn_sql()
    '    Dim opr_pedido As New Cls_Pedido()
    '    If tipo = 0 Then
    '        'CUANDO ES SOLO GUARDAR EL RESULTADO
    '        For int_cont = 0 To dtt_tabla.Rows.Count - 1
    '            If Not IsDBNull(dtt_tabla.Rows(int_cont).Item(6)) Then
    '                If dtt_tabla.Rows(int_cont).Item(6) <> "" Then
    '                    str_sql = "Update LISTA_TRABAJO set LIS_RESMANUAL='" & dtt_tabla.Rows(int_cont).Item(6) & "', " & _
    '                    "LIS_RESESTADO=1, LIS_RESRANGO = '" & rango & "' WHERE LIS_RESESTADO=0 and LIS_ID=" & dtt_tabla.Rows(int_cont).Item(5)
    '                    Dim odc_operacion As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
    '                    odc_operacion.ExecuteNonQuery()
    '                    opr_pedido.ActualizarPdd_Estado(dtt_tabla.Rows(int_cont).Item(0), testid, 1)
    '                End If
    '            End If
    '        Next
    '    Else
    '        'CUANDO SE GRABA EL RESULTADO Y SE VALIDA
    '        For int_cont = 0 To dtt_tabla.Rows.Count - 1
    '            If Not IsDBNull(dtt_tabla.Rows(int_cont).Item(6)) Then
    '                If dtt_tabla.Rows(int_cont).Item(6) <> "" Then
    '                    str_sql = "Update LISTA_TRABAJO set LIS_RESMANUAL='" & dtt_tabla.Rows(int_cont).Item(6) & "', " & _
    '                    "LIS_RESESTADO=2, LIS_RESRANGO = '" & rango & "' WHERE LIS_RESESTADO=0 and LIS_ID=" & dtt_tabla.Rows(int_cont).Item(5)
    '                    Dim odc_operacion As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
    '                    odc_operacion.ExecuteNonQuery()
    '                    opr_pedido.ActualizarPdd_Estado(dtt_tabla.Rows(int_cont).Item(0), testid, 1)
    '                End If
    '            End If
    '        Next
    '    End If
    '    opr_conexion.sql_desconn

    '  End Sub

    Sub LlenarGridRangNormal(ByRef data As DataView)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTestRangos().Tables("Registros")
    End Sub

    Sub ordena_RangNormal(ByVal test As String, ByRef data As DataView)
        'funci�n que orderna por apellido al dataview
        With data
            If Trim(test) <> "" Then
                .RowFilter = "TES_NOMBRE like '" & Trim(test) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "TES_NOMBRE"
        End With
    End Sub


    Public Function testperfil(ByVal tests As String, ByVal convenio As String) As DataSet
        'Procedimiento para consultar todos los test y su porecio por convenio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        Dim areas() As String
        Dim i, x As Int32
        Dim str_aux As String = "("
        areas = Split(tests, ",")
        x = UBound(areas)
        'en caso de que exista areas a donde consultar
        If x >= 0 Then
            For i = 0 To (x)
                If i = 0 Then
                    str_aux = str_aux & "test.tes_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or test.tes_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If

        oda_test.SelectCommand = New SqlCommand("select area.ARE_NOMBRE, tes_nombre, test.tes_id,lip_precio from test, lista_precio, area  where " & str_aux & " and lista_precio.tes_id=test.tes_id and TES_PARAMETRO <> 1 and area.ARE_ID  = test.ARE_ID and con_nombre='" & convenio & "' order by ARE_NOMBRE, tes_nombre", opr_conexion.conn_sql)
        testperfil = New DataSet()
        oda_test.Fill(testperfil, "RegistrosC")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test del perfil", Err)
        Err.Clear()
    End Function

    Public Sub LlenarCmb_Test(ByRef cmb_test As ComboBox)
        'Funcion para la Llenar un combo con todas los test manuales.
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_filaAre As DataRow
        dts_area = LeertestManuales()
        For Each dtr_filaAre In dts_area.Tables("Registros").Rows
            cmb_test.Items.Add(dtr_filaAre("tes_nombre").ToString())
        Next
        cmb_test.SelectedIndex = 0
    End Sub

    Public Function LeerTestManuales() As DataSet
        'Funcion para la consultar los datos de la tabla TEST MANUALES
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()
        oda_operacion.SelectCommand = New SqlCommand("SELECT TEST.tes_nombre  FROM LISTA_TRABAJO, TEST WHERE LISTA_TRABAJO.TES_ID = TEST.TES_ID And  LISTA_TRABAJO.EQU_ID = 6	group by TEST.tes_nombre order by TEST.tes_nombre;", opr_Conexion.conn_sql)
        LeerTestManuales = New DataSet("TEST")
        oda_operacion.Fill(LeerTestManuales, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Areas", Err)
        Err.Clear()
    End Function


End Class
