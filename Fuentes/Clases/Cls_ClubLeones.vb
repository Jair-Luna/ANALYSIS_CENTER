'*************************************************************************
' Nombre:   Cls_ClubLeones
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulaci�n de los datos, y requerientos 
' espec�ficos del club de leones
' Autores:  RFN
' Fecha de Creaci�n: 08/08/2003
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_ClubLeones

    'CDL_PED_ESTADO --> 0 NO leeido, 1 Leeido

    Function CDL_InsertaPedido() As Byte
        'funcion que permite guardar un pedido nuevo
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsq As SqlCommand
        CDL_InsertaPedido = 0
        'obtiene le codigo m�ximo de los pedidos 
        opr_conexion.sql_conectar()
        '''''opr_Conexion.conn_sql()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'se lee los datos de la tabla cdl_pedido
        Dim odr_datos As SqlDataReader
        Dim str_sql As String
        Dim IDPAC As Integer
        Dim IDPED As Long = 0
        Dim IDPEDANT As Long = 0
        Dim int_cont, IDMED, TURNO As Short
        str_sql = "Select CDL_PED_PEDID, CDL_PED_PACNOMBRE, CDL_PED_PACAPELLIDO, CDL_PED_TESTID, CDL_PED_MEDNOMBRE, CDL_PED_PRIORIDAD, CDL_PED_TURNO, CDL_PED_ESTADO, CDL_TEST_LUMID " & _
        "from cdl_pedido, cdl_test  " & _
        "where CDL_PED_ESTADO=0 and cdl_test.CDL_TEST_TESTID = cdl_pedido.CDL_PED_TESTID  " & _
        "order by CDL_PED_PEDID, CDL_PED_TESTID"
        odr_datos = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        While odr_datos.Read
            IDPEDANT = IDPED
            IDPED = odr_datos.GetValue(0)
            If IDPED <> IDPEDANT Then
                'si ingresa, significa que existe un nuevo pedido, si no, es el mismo pedido con diferente test
                int_cont = 0
                'OJO: se quema los siguiente c�digos
                'ciudad:1,  tipo de documento:4(ninguno),  laboratorio:1,  convenio:NOMBRE DE CONVENIO POR DEFECTO,
                'Prioridad = NORMAL
                'si los c�digos no existiesen, podr�an surgir errores de inconsistencia, revisar la existencia de dichos c�digos
                'comprueba datos paciente, si no existe crea uno nuevo
                Dim opr_paciente As New Cls_Paciente()
                IDPAC = opr_paciente.ComprobarNomPaciente(odr_datos.GetValue(1).ToString.ToUpper, odr_datos.GetValue(2).ToString.ToUpper)
                If IDPAC = 0 Then
                    'si IDPAC es 0, significa que no encontro el paciente por apellido y nombre
                    'se inserta los datos del paciente
                    'xxx se recomienda que ingrese los datos como sexo, fecha de nacimiento e historia cl�nica
                    IDPAC = opr_paciente.LeerMaxPaciente + 1
                    str_sql = "insert into paciente(pac_id, pac_doc, pac_tipodoc, pac_apellido, pac_nombre, pac_direccion, pac_fono, pac_sexo, pac_fecnac, pac_fecing, pac_obs, ciu_id, pac_mail, pac_hist_clinica) values(" & _
                    IDPAC & ",'',4,'" & odr_datos.GetValue(2).ToString.ToUpper & "','" & odr_datos.GetValue(1).ToString.ToUpper & "','','','','" & Format(Today, "dd/MM/yyyy") & "','" & Format(Today, "dd/MM/yyyy") & "','',1,'','')"
                    odbc_strsq = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
                    odbc_strsq.ExecuteNonQuery()
                End If
                'comprueba datos medico, si no existe crea uno nuevo
                Dim opr_medico As New Cls_Medico()
                IDMED = opr_medico.ComprobarNomMedico(odr_datos.GetValue(4).ToString.ToUpper)
                If IDMED = 0 Then
                    'si IDPAC es 0, significa que no encontro el paciente por apellido y nombre
                    'se inserta los datos del paciente
                    IDMED = opr_medico.LeerMaxMedico + 1
                    str_sql = "insert into medico(med_id, med_nombre) values(" & IDMED & ",'" & odr_datos.GetValue(4).ToString.ToUpper & "')"
                    odbc_strsq = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
                    odbc_strsq.ExecuteNonQuery()
                End If
                'xxx comprueba datos turno
                'xxx comprueba la existencia del pedido, ver que sucede con actualizaciones o eliminaciones, ellos deber�an cambiar el estatus y punto
                'se inserta los datos en la tabla pedido
                str_sql = "insert into pedido(ped_id,ped_fecing,ped_antecedente,ped_medicacion,ped_tipo,con_nombre,pac_id,med_id,lab_id,ped_turno) values(" & _
                IDPED & ",'" & Format(Today, "dd/MM/yyyy HH:mm:ss") & "','','', 'NORMAL','Precios P.U.C.E.'," & IDPAC & "," & IDMED & ",1," & TURNO & ")"
                odbc_strsq = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
                odbc_strsq.ExecuteNonQuery()
                'actualizar el estado de los pedidos, a 1(utilizados)
                str_sql = "update cdl_pedido set CDL_PED_ESTADO=1 where CDL_PED_PEDID=" & IDPED
                odbc_strsq = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
                odbc_strsq.ExecuteNonQuery()
            End If
            int_cont = int_cont + 1
            'los datos son enviados por el CDL, desglosados, es decir no envian nada como perfiles, sino como test sueltos
            str_sql = "insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & IDPED & "," & int_cont & ",1," & odr_datos.GetValue(8) & ")"
            odbc_strsq = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
            odbc_strsq.ExecuteNonQuery()
            str_sql = "insert into pedido_detalle_desglosado(ped_id, tes_id) values(" & IDPED & "," & odr_datos.GetValue(8) & ")"
            odbc_strsq = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
            odbc_strsq.ExecuteNonQuery()
        End While

        'si no hubo errores commit
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        opr_conexion.sql_desconn()
        CDL_InsertaPedido = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Pedido", str_sql)
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        CDL_InsertaPedido = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Inserta Pedido CDL " & Err.Description, Err)
        Err.Clear()
    End Function

    Dim opr_resultado As New Cls_Resultado()
    Public Sub GuardarResultadoPedido(ByVal ped_id As Integer)
        'guarda los resultados en la base de datos
        On Error GoTo msgError
        LeeResAutomaticos(ped_id)
        LeeResManual(ped_id)
        Exit Sub
msgError: g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, guardarResultadoPedidoCDL " & Err.Description, Err)
        Err.Clear()
    End Sub

    Public Sub LeeResManual(ByVal ped_id As Integer)        ' As DataSet
        'Funcion para la consultar los resultados Manuales de un pedido
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim dts_rr As New DataSet()
        Dim dtr_fila As DataRow
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "SELECT LISTA_TRABAJO.PED_ID as PED_ID, CDL_TEST.CDL_TEST_TESTID AS TES_ID, LISTA_TRABAJO.LIS_RESMANUAL, UNIDAD.UNI_NOMENCLATURA AS UNI_ID, LISTA_TRABAJO.LIS_RESRANGO AS RANGO, LISTA_TRABAJO.LIS_FECING AS FECHA FROM UNIDAD, TEST, LISTA_TRABAJO, TEST_RESULTADO, CDL_TEST WHERE TEST.TES_ID = CDL_TEST.CDL_TEST_LUMID AND TEST.TES_ID = LISTA_TRABAJO.TES_ID AND UNIDAD.UNI_ID = TEST.UNI_ID AND TEST.TES_ID = TEST_RESULTADO.TES_ID AND (((LISTA_TRABAJO.PED_ID)=" & ped_id & ") AND ((TEST.TES_TPROCES)=0)) " & _
        " UNION " & _
        "SELECT LISTA_TRABAJO.PED_ID as PED_ID, CDL_TEST.CDL_TEST_TESTID AS TES_ID, LISTA_TRABAJO.LIS_RESMANUAL, UNIDAD.UNI_NOMENCLATURA AS UNI_ID, LISTA_TRABAJO.LIS_RESRANGO AS RANGO, LISTA_TRABAJO.LIS_FECING FROM UNIDAD,TEST, LISTA_TRABAJO, TEST_RESULTADO, CDL_TEST WHERE TEST.TES_ID = CDL_TEST.CDL_TEST_LUMID AND TEST.TES_ID = LISTA_TRABAJO.TES_ID AND UNIDAD.UNI_ID = TEST.UNI_ID AND TEST.TES_ID = TEST_RESULTADO.TES_ID AND LISTA_TRABAJO.PED_ID=" & ped_id & " AND TEST.TES_TPROCES = 1 AND TEST.TES_ID = CDL_TEST.CDL_TEST_LUMID And TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' AND LISTA_TRABAJO.EQU_ID Is NULL"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_rr, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_rr.Tables("Registros").Rows
            'Almaceno cada uno de los resultados manuales
            GuardarResultadoCDL(CInt(dtr_fila("PED_ID").ToString), dtr_fila("UNI_ID").ToString, dtr_fila("TES_ID").ToString, dtr_fila("LIS_RESMANUAL").ToString, dtr_fila("RANGO").ToString, dtr_fila("FECHA").ToString)
        Next
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, LeeResAutomaticos", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarResultadoCDL(ByVal ped_id As Integer, ByVal uni_id As String, _
        ByVal tes_id As String, ByVal resultado As String, ByVal rango As String, _
        ByVal fecha As String)
        'Procedimiento para la insertar un registro en la tabla CDL_RESULTADOS
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        If fecha = "" Then
            fecha = Today
        End If
        Dim str_sql As String = "Insert into CDL_resultados values " & _
        " (" & ped_id & ", '" & uni_id & "', '" & tes_id & "', '" & resultado & "', '" & rango & "', '" & Format(CDate(fecha), "dd/MM/yyyy") & "',, 0)"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "ResAutoCDL", str_sql)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, GuardarArea", Err)
        Err.Clear()
    End Sub

    Public Sub LeeResAutomaticos(ByVal ped_id As Integer)        'As DataSet
        'Funcion para la consultar los resultados Automaticos de un pedido
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        'Dim str_sql As String = "SELECT A.PED_ID AS PED_ID, C.TES_ID AS TES_ID, A.PRC_RESFINAL AS PRC_RESULTADO, D.UNI_ID AS UNI_ID, A.PRC_RANGO AS RANGO_NORMAL, E.EQU_ID AS EQU_ID, A.PRC_FECHA AS PRC_FECHA FROM UNIDAD AS D INNER JOIN (TEST AS C INNER JOIN (((RES_PROCESADOS AS A INNER JOIN SNI AS G ON A.SNI_NOMBRE = G.SNI_NOMBRE) INNER JOIN EQUIPO AS E ON G.SNI_NOMBRE = E.SNI_NOMBRE) INNER JOIN TEST_EQUIPO AS B ON (B.TEQ_ABRV_FIJA = A.TES_ABREV) AND (E.EQU_ID = B.EQU_ID)) ON C.TES_ID = B.TES_ID) ON D.UNI_ID = B.UNI_ID WHERE A.PED_ID= " & ped_id & ""
        Dim str_Sql As String = "SELECT A.PED_ID AS PED_ID, TC.CDL_TEST_TESTID AS TES_ID, A.PRC_RESFINAL AS PRC_RESULTADO, D.UNI_NOMENCLATURA AS UNI_ID, A.PRC_RANGO AS RANGO_NORMAL, E.EQU_ID AS EQU_ID, A.PRC_FECHA AS PRC_FECHA FROM UNIDAD AS D, TEST AS C, CDL_TEST AS TC, RES_PROCESADOS AS A, SNI AS G, EQUIPO AS E, TEST_EQUIPO AS B WHERE C.TES_ID = TC.CDL_TEST_LUMID AND A.SNI_NOMBRE = G.SNI_NOMBRE AND G.SNI_NOMBRE = E.SNI_NOMBRE AND B.TEQ_ABRV_FIJA = A.TES_ABREV AND E.EQU_ID = B.EQU_ID AND C.TES_ID = B.TES_ID AND D.UNI_ID = B.UNI_ID and A.PED_ID=" & ped_id & ""
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_Sql, opr_Conexion.conn_sql)
        Dim dts_aa As New DataSet()
        Dim dtr_fila As DataRow
        dts_aa = New DataSet()
        oda_operacion.Fill(dts_aa, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_aa.Tables("Registros").Rows
            'Recorro el dataset y almaceno los resultados
            GuardarResultadoCDL(CInt(dtr_fila("PED_ID").ToString), dtr_fila("UNI_ID").ToString, CInt(dtr_fila("TES_ID").ToString), dtr_fila("PRC_RESULTADO").ToString, dtr_fila("RANGO_NORMAL").ToString, dtr_fila("PRC_FECHA").ToString)
        Next
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, LeeResAutomaticos", Err)
        Err.Clear()
    End Sub

End Class
