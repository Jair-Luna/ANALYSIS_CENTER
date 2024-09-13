'*************************************************************************
' Nombre:   Cls_Trabajo
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de la lista de Trabajo
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 
' Proyecto / TRUE SOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Trabajo

    Public Function LeerPedido(ByVal tipo As String) As DataSet
        'Procedimiento para consultar todos los perfiles
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_trabajo As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        STR_SQL = "Select ped_id, pac_nombre, pac_apellido, ped_fecing from PEDIDO, PACIENTE where paciente.pac_id=pedido.pac_id and ped_estado=0 and ped_tipo='" & tipo & "'"
        oda_trabajo.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        LeerPedido = New DataSet()
        oda_trabajo.Fill(LeerPedido, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido Sin Lista de Trabajo", Err)
        Err.Clear()
    End Function


    Sub LlenarListaTrabajo(ByRef lst_trabajo As ListBox, ByVal tipo As String, ByVal str_areas As String, ByVal DesdeHasta As String)
        'Procedimiento para consultar todos los pedidos con sus test pendientes
        On Error GoTo MsgError
        lst_trabajo.Items.Clear()
        Dim x, i As Short
        Dim areas() As String
        areas = Split(str_areas, ",")
        x = UBound(areas)
        If x > 0 Then
            Dim str_aux As String = "and ("
            For i = 0 To (x - 1)
                If i = 0 Then
                    str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            Dim STR_SQL As String
            Dim opr_conexion As New Cls_Conexion()

            opr_conexion.sql_conectar()

            If DesdeHasta = "" Then
                str_aux = str_aux & " ) order by pedido.ped_turno"
                STR_SQL = "SELECT DISTINCT pedido.PED_ID, paciente.PAC_NOMBRE, paciente.PAC_APELLIDO, paciente.PAC_FECNAC, pedido.PED_FECING, test.are_id, ped_turno " & _
                "FROM paciente,  pedido, pedido_detalle_desglosado, test WHERE (pedido.ped_estado <> 2 and pedido.ped_estado <> 9) and pedido.PED_ID = pedido_detalle_desglosado.PED_ID " & _
                "and paciente.PAC_ID = pedido.PAC_ID and pedido_detalle_desglosado.tes_id = test.tes_id and paciente.PAC_ID=pedido.pac_id " & _
                "AND pedido.PED_TIPO='" & tipo & "' and PEDIDO.PED_PROF <> 1 AND pedido_detalle_desglosado.PDD_ESTADO=0 " & str_aux & ""
                Dim odr_trabajo As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
                While odr_trabajo.Read
                    lst_trabajo.Items.Add(odr_trabajo.GetValue(5).ToString() & (Mid(odr_trabajo.GetValue(2).ToString() & " " & odr_trabajo.GetValue(1).ToString(), 1, 25)).ToString.PadRight(25) & "  " & Format(odr_trabajo.GetValue(3), "dd/MM/yyyy HH:mm").ToString().PadRight(16) & odr_trabajo.GetValue(0).ToString().PadRight(7))
                    'lst_trabajo.Items.Add(odr_trabajo.GetValue(0).ToString().PadRight(7)  & (Mid(odr_trabajo.GetValue(2).ToString() & " " & odr_trabajo.GetValue(1).ToString(), 1, 25)).ToString.PadRight(25) & "  " & Format(odr_trabajo.GetValue(3), "dd/MM/yyyy HH:mm").ToString().PadRight(16) & " " & odr_trabajo.GetValue(5).ToString.PadRight(5))
                End While
                odr_trabajo.Close()
            Else
                Dim Arre_DesdeHasta As String()
                Arre_DesdeHasta = Split(DesdeHasta, "/")

                str_aux = str_aux & " ) order by pedido.ped_turno"
                STR_SQL = "SELECT DISTINCT pedido.PED_ID, paciente.PAC_NOMBRE, paciente.PAC_APELLIDO, paciente.PAC_FECNAC, pedido.PED_FECING, test.are_id, ped_turno " & _
                "FROM paciente,  pedido, pedido_detalle_desglosado, test WHERE (pedido.ped_estado <> 2 and pedido.ped_estado <> 9) and pedido.PED_ID = pedido_detalle_desglosado.PED_ID " & _
                "and paciente.PAC_ID = pedido.PAC_ID and pedido_detalle_desglosado.tes_id = test.tes_id and paciente.PAC_ID=pedido.pac_id " & _
                "AND pedido.PED_TIPO='" & tipo & "' and PEDIDO.PED_PROF <> 1 AND pedido_detalle_desglosado.PDD_ESTADO=0 and pedido.PED_TURNO between " & Arre_DesdeHasta(0) & " and " & Arre_DesdeHasta(1) & " " & str_aux
                Dim odr_trabajo As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
                While odr_trabajo.Read
                    lst_trabajo.Items.Add(odr_trabajo.GetValue(5).ToString() & (Mid(odr_trabajo.GetValue(2).ToString() & " " & odr_trabajo.GetValue(1).ToString(), 1, 25)).ToString.PadRight(25) & "  " & Format(odr_trabajo.GetValue(3), "dd/MM/yyyy HH:mm").ToString().PadRight(16) & odr_trabajo.GetValue(0).ToString().PadRight(7))
                    'lst_trabajo.Items.Add(odr_trabajo.GetValue(0).ToString().PadRight(7)  & (Mid(odr_trabajo.GetValue(2).ToString() & " " & odr_trabajo.GetValue(1).ToString(), 1, 25)).ToString.PadRight(25) & "  " & Format(odr_trabajo.GetValue(3), "dd/MM/yyyy HH:mm").ToString().PadRight(16) & " " & odr_trabajo.GetValue(5).ToString.PadRight(5))
                End While
                odr_trabajo.Close()
            End If

            opr_conexion.sql_desconn()
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido Sin Lista de Trabajo", Err)
        Err.Clear()
    End Sub

    Public Function LeerDetallePedido(ByVal ped_id As Long) As DataSet
        'Procedimiento para consultar todos los test por pedidos que estan pedientes de realizar
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        'tes_nombre-->0                         tes_id-->1
        'pedido_detalle_desglosado.ped_id-->2   pedido_detalle_desglosado.pdd_estado-->3
        'pedido_detalle_desglosado.tes_id-->4   pedido_detalle_desglosado.per_id-->5
        STR_SQL = "SELECT tes_nombre, test.tes_id, pedido_detalle_desglosado.ped_id,  pedido_detalle_desglosado.pdd_estado, pedido_detalle_desglosado.tes_id, if(pedido_detalle_desglosado.per_id is NULL, 0, pedido_detalle_desglosado.per_id)  " & _
        "FROM pedido_detalle_desglosado, test " & _
        "WHERE pedido_detalle_desglosado.tes_id = test.tes_id And pedido_detalle_desglosado.ped_id = " & ped_id & "  and pdd_estado=0"
        oda_trabajo.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerDetallePedido = New DataSet()
        oda_trabajo.Fill(LeerDetallePedido, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Detalle Pedido", Err)
        Err.Clear()
    End Function

    Public Sub LeerDetallePedidoArea(ByVal ped_id As Long, ByVal str_areas As String, ByRef arr_datos As ArrayList)
        'Procedimiento para consultar todos los test por pedidos que estan pedientes de realizar seg�n las areas escogidas
        On Error GoTo MsgError
        Dim x, i As Short
        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        x = UBound(areas)
        'controla que tenga areas por consultar
        If x > 0 Then
            For i = 0 To (x - 1)
                If i = 0 Then
                    str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
            'tes_nombre     --> 0   test.tes_id     -->1    pedido_detalle_desglosado.ped_id    -->2
            'pedido_detalle_desglosado.pdd_estado   -->3    pedido_detalle_desglosado.tes_id    -->4
            'pedido_detalle_desglosado.per_id       -->5    test.are_id                         -->6
            Dim STR_SQL As String
            Dim opr_conexion As New Cls_Conexion()
            opr_conexion.sql_conectar()
            STR_SQL = "SELECT tes_nombre, test.tes_id, pedido_detalle_desglosado.ped_id, pedido_detalle_desglosado.pdd_estado, " & _
            "pedido_detalle_desglosado.tes_id, if(pedido_detalle_desglosado.per_id is NULL, 0, pedido_detalle_desglosado.per_id), test.are_id as AREAID " & _
            "FROM pedido_detalle_desglosado, test WHERE pedido_detalle_desglosado.tes_id = test.tes_id And " & _
            "pedido_detalle_desglosado.ped_id = " & ped_id & " and pdd_estado=0 " & str_aux
            Dim odr_trabajo As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
            arr_datos.Clear()
            While odr_trabajo.Read
                arr_datos.Add(odr_trabajo.GetValue(0) & "°" & odr_trabajo.GetValue(1) & "°" & odr_trabajo.GetValue(2) & "°" & _
                odr_trabajo.GetValue(3) & "°" & odr_trabajo.GetValue(4) & "°" & odr_trabajo.GetValue(5) & "°" & odr_trabajo.GetValue(6))
            End While
            odr_trabajo.Close()
            opr_conexion.sql_desconn()
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Detalle Pedido Area", Err)
        Err.Clear()
    End Sub

    Public Sub LeerDetallePedido_dia(ByVal fecha_hoy As Date, ByVal str_tipo As String, ByVal str_areas As String, ByRef arr_datos As ArrayList)
        'Procedimiento para consultar todos los perfiles
        On Error GoTo MsgError
        Dim x, i As Short
        Dim areas() As String
        Dim str_auxtipo As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        x = UBound(areas)
        'en caso de que exista areas a donde consultar
        If x > 0 Then
            For i = 0 To (x - 1)
                If i = 0 Then
                    str_aux = str_aux & "test.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or test.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
            Dim STR_SQL As String
            'PEDIDO.PED_ID              -->0    PACIENTE.PAC_ID                 -->1
            'PACIENTE.PAC_APELLIDO      -->2    PACIENTE.PAC_NOMBRE             -->3
            'LISTA_TRABAJO.TIM_ID       -->4    LISTA_TRABAJO.LIS_POSNUM        -->5
            'LISTA_TRABAJO.LIS_TUBO     -->6    LISTA_TRABAJO.EQU_ID            -->7
            'TIPO_MUESTRA.TIM_NOMBRE    -->8    EQUIPO.EQU_MODELO               -->9
            'LISTA_TRABAJO.TES_ID       -->10   TEST.TES_NOMBRE                 -->11
            'LISTA_TRABAJO.LIS_ID       -->12   PEDIDO_DETALLE_DESGLOSADO.PER_ID-->13
            'EQUIPO.EQU_ESTADO          -->14   LISTA_TRABAJO.LIS_RESESTADO     -->15
            'lista_trabajo.LIS_RESESTADO-->16   LISTA_TRABAJO.LIS_RACK          -->17
            'LISTA_TRABAJO.LIS_EQUERROR -->18   PEDIDO.PED_TURNO                -->19
            'TEST.ARE_ID                -->20

            str_tipo = Trim(Mid(str_tipo, 1, 50))
            STR_SQL = "SELECT pedido.PED_ID, paciente.PAC_ID, paciente.PAC_APELLIDO, paciente.PAC_NOMBRE, " & _
            "lista_trabajo.TIM_ID, lista_trabajo.LIS_POSNUM, lista_trabajo.LIS_TUBO, " & _
            "lista_trabajo.EQU_ID, tipo_muestra.TIM_NOMBRE, equipo.EQU_MODELO, " & _
            "lista_trabajo.TES_ID, test.TES_NOMBRE, lista_trabajo.LIS_ID, " & _
            "pedido_detalle_desglosado.per_id, equipo.EQU_ESTADO, lista_trabajo.LIS_RESESTADO, " & _
            "lista_trabajo.LIS_RESESTADO as graf_estado, lista_trabajo.LIS_RACK, lista_trabajo.LIS_EQUERROR, pedido.PED_TURNO AS TURNO, test.are_id as AREAID " & _
            "FROM tipo_muestra " & _
            "RIGHT OUTER JOIN lista_trabajo ON (tipo_muestra.TIM_ID = lista_trabajo.TIM_ID)  " & _
            "LEFT OUTER JOIN pedido ON (lista_trabajo.PED_ID = pedido.PED_ID)  " & _
            "INNER JOIN paciente ON (pedido.PAC_ID = paciente.PAC_ID)  " & _
            "LEFT OUTER JOIN pedido_detalle_desglosado ON (lista_trabajo.PED_ID = pedido_detalle_desglosado.PED_ID) AND (lista_trabajo.TES_ID = pedido_detalle_desglosado.TES_ID) AND (lista_trabajo.PER_ID = pedido_detalle_desglosado.PER_ID)  " & _
            "LEFT OUTER JOIN test ON (lista_trabajo.TES_ID = test.TES_ID)  " & _
            "LEFT OUTER JOIN equipo ON (lista_trabajo.EQU_ID = equipo.EQU_ID) " & _
            "WHERE lista_trabajo.LIS_FECING BETWEEN '" & Format(fecha_hoy, "dd/MM/yyyy 00:00:00") & "' AND '" & Format(fecha_hoy, "dd/MM/yyyy 23:59:59") & "'  And PED_PROF <> 1 "

            str_auxtipo = "and PED_TIPO='" & str_tipo & "'"

            str_aux = " ORDER BY pedido.ped_turno "

            If str_tipo <> "TODOS" Then
                STR_SQL = STR_SQL & str_auxtipo & str_aux
            Else
                STR_SQL = STR_SQL & str_aux
            End If

            Dim opr_conexion As New Cls_Conexion()
            opr_conexion.sql_conectar()
            Dim odr_trabajo As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
            arr_datos.Clear()
            While odr_trabajo.Read
                arr_datos.Add(odr_trabajo.GetValue(0) & "�" & odr_trabajo.GetValue(1) & "�" & odr_trabajo.GetValue(3) & "�" & _
                odr_trabajo.GetValue(2) & "�" & odr_trabajo.GetValue(4) & "�" & odr_trabajo.GetValue(5) & "�" & odr_trabajo.GetValue(6) & "�" & _
                odr_trabajo.GetValue(7) & "�" & odr_trabajo.GetValue(8) & "�" & odr_trabajo.GetValue(9) & "�" & odr_trabajo.GetValue(10) & "�" & _
                odr_trabajo.GetValue(11) & "�" & odr_trabajo.GetValue(12) & "�" & odr_trabajo.GetValue(13) & "�" & odr_trabajo.GetValue(14) & "�" & _
                odr_trabajo.GetValue(15) & "�" & odr_trabajo.GetValue(16) & "�" & odr_trabajo.GetValue(17) & "�" & odr_trabajo.GetValue(18) & "�" & _
                odr_trabajo.GetValue(19) & "�" & odr_trabajo.GetValue(20))
            End While
            odr_trabajo.Close()
            opr_conexion.sql_desconn()
        End If
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Lista de Trabajo", Err)
        Err.Clear()
    End Sub


    Public Function LeerMaxTrabajo() As Integer
        'funcion que obtiene el codigo m�ximo de una lista de trabajo 
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxTrabajo = 0
        LeerMaxTrabajo = CInt(New SqlCommand("Select isnull(Max(lis_id),0) from lista_trabajo", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer M�ximo C�digo Lista de Trabajo. 01", Err)
        Err.Clear()
    End Function

    Public Function GuardarTrabajo(ByVal dtt_trabajo As DataTable, ByVal lis_fecing As Date, ByVal TIPO As String) As Boolean
        'funcion que guarda una lista de trabajo
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_trabajo As SqlCommand
        Dim lng_lis_id As Long
        Dim STR_SQL As String
        Dim int_indice As Short = 0
        Dim int_idtubo, int_pos, int_muestraid As Short
        Dim str_muestraideqp As String
        GuardarTrabajo = False

        For int_indice = 0 To dtt_trabajo.Rows.Count - 1
            'solo se pueden registrar o actualizar los datos que no han sido enviadas, procesadas o validadas
            'osea estado = 0

            If dtt_trabajo.Rows(int_indice).Item(10) = 0 Then
                Select Case Trim(dtt_trabajo.Rows(int_indice).Item(7).ToString)
                    Case "Tubo Primario"
                        int_idtubo = 1
                    Case "Copa"
                        int_idtubo = 2
                    Case Else
                        int_idtubo = 0
                End Select
                int_muestraid = 0
                str_muestraideqp = 0
                If Trim(dtt_trabajo.Rows(int_indice).Item(6).ToString) <> "" Then
                    If IsNumeric(Trim(dtt_trabajo.Rows(int_indice).Item(6).ToString.Substring(150, 10))) Then
                        int_muestraid = dtt_trabajo.Rows(int_indice).Item(6).substring(150, 10)
                        'busca la muestra dentro de la cadena que se encuentra definida para el equipo (ej: #1-#2,1-2,2-3,5-6)
                        'donde el #1 es el n�mero id en el equipo, #2 es el id de la muestra en la BD LIS
                        Dim i As Short
                        Dim s() As String = Split(dtt_trabajo.Rows(int_indice).Item(16).ToString, ",")
                        If UBound(s) = 0 Then
                            Dim aux() As String = Split(dtt_trabajo.Rows(int_indice).Item(16).ToString, "-")
                            If aux.Length = 2 Then If aux(1) = int_muestraid Then str_muestraideqp = aux(0)
                        Else
                            For i = 0 To UBound(s) - 1
                                Dim aux() As String = Split(s(i), "-")
                                If aux(1) = int_muestraid Then
                                    str_muestraideqp = aux(0)
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                End If

                If IsNumeric(Trim(dtt_trabajo.Rows(int_indice).Item(9).ToString)) Then
                    int_pos = dtt_trabajo.Rows(int_indice).Item(9)
                Else
                    int_pos = 0
                End If

                'si es nuevo = 0
                If dtt_trabajo.Rows(int_indice).Item(15) = 0 Then
                    'controla el ingreso de perfiles nulo o el n�mero correspondiente
                    Dim per_aux As String = "NULL"
                    If dtt_trabajo.Rows(int_indice).Item(14) <> 0 Then
                        per_aux = dtt_trabajo.Rows(int_indice).Item(14)
                    End If
                    'aumenta el contador para los
                    lng_lis_id = LeerMaxTrabajo() + 1
                    'graba los nuevos elementos
                    If Trim(dtt_trabajo.Rows(int_indice).Item(5).ToString) = "" Or Trim(dtt_trabajo.Rows(int_indice).Item(5).ToString) = "<MANUAL>" Then
                        'entra si es manual
                        'c�digo para guardar la fecha de ingreso de la lista con hora, mejor no usar por pequ�os inconvenientes que surgen luego
                        STR_SQL = "Insert into lista_trabajo(lis_id, lis_fecing, ped_id, tes_id, equ_id, lis_resestado, tim_id, lis_posnum, lis_tubo, lis_equtimid, lis_rack, per_id) " & _
                        "values(" & lng_lis_id & ",'" & Format(lis_fecing, "dd/MM/yyyy") & "'," & Trim(dtt_trabajo.Rows(int_indice).Item(0).ToString) & "," & _
                        Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString) & ", NULL,0," & int_muestraid & "," & int_pos & "," & int_idtubo & ",'0','0'," & per_aux & ")"
                    Else
                        'entra si se hace con equipo
                        STR_SQL = "insert into lista_trabajo(lis_id, lis_fecing, ped_id, tes_id, equ_id, lis_resestado, tim_id, lis_posnum, lis_tubo, lis_equtimid, lis_rack, per_id) " & _
                        "values(" & lng_lis_id & ",'" & Format(lis_fecing, "dd/MM/yyyy") & "'," & Trim(dtt_trabajo.Rows(int_indice).Item(0).ToString) & "," & _
                        Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString) & "," & Trim(dtt_trabajo.Rows(int_indice).Item(5).substring(150, 10)) & ",0," & _
                        int_muestraid & "," & int_pos & "," & int_idtubo & ",'" & str_muestraideqp & "','" & Trim(Mid(dtt_trabajo.Rows(int_indice).Item(8).ToString, 1, 10)) & "', " & per_aux & ")"
                        'Codigo para guardar la lista de trabajo en la tabla res_procesados...
                        'lo que permitir� tener las pruebas de un pedido de las que se espera...
                        'un resultado autom�tico.
                        Dim opr_archivos As New Cls_Archivos()
                        Dim opr_equipos As New Cls_equipos()
                        opr_archivos.GuardarTrabajoResArchivo(CInt(Trim(dtt_trabajo.Rows(int_indice).Item(0).ToString)), "", "", opr_archivos.Abrev_TestAuto(Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString)), opr_equipos.LeerSNIEquipo(Trim(dtt_trabajo.Rows(int_indice).Item(5).substring(150, 10))), "NULL", "", Trim(dtt_trabajo.Rows(int_indice).Item(5).ToString), TIPO, Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString))
                    End If
                Else
                    'ingresa en el caso de ser actualizaci�n de registro
                    Dim str_eqpid As String = ""
                    Dim str_eqpant As String = EquipoItemListaTrabajo(dtt_trabajo.Rows(int_indice).Item(15))
                    'consulta si se cambi� el equipo, para realizar la oparaci�n
                    If str_eqpant <> Trim(dtt_trabajo.Rows(int_indice).Item(5).ToString.PadRight(160).Substring(150, 10)) Then
                        'ese caso se da si se cambiar�a el test realizado en equipo a realizado manualmente
                        Dim opr_archivos As New Cls_Archivos()
                        Dim opr_equipos As New Cls_equipos()
                        If Trim(dtt_trabajo.Rows(int_indice).Item(5).ToString) = "" Or Trim(dtt_trabajo.Rows(int_indice).Item(5).ToString) = "<MANUAL>" Then
                            str_eqpid = "equ_id=NULL, "
                            'se eliminan indistintamente del sni de res_procesados, �nicamente debe coincidir el pedido id y abreviatura
                            Dim str_abrev As String = opr_archivos.Abrev_TestAuto(Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString))
                            Select Case str_abrev
                                Case "BIOMETRIA HEMATICA"
                                    'borra todas las posibles coincidencias con los equipos celldyn 1700 y cell3500, (c�digo quemado)
                                    STR_SQL = "Delete from res_procesados where ped_id=" & CInt(Trim(dtt_trabajo.Rows(int_indice).Item(0).ToString)) & " and (" & _
                                    "tes_abrev='WBC' or tes_abrev='NE' or tes_abrev='LY' or tes_abrev='MO' or tes_abrev='EO' or tes_abrev='BA' or " & _
                                    "tes_abrev='NE%' or tes_abrev='LY%' or tes_abrev='MO%' or tes_abrev='EO%' or tes_abrev='BA%' or tes_abrev='RBC' or " & _
                                    "tes_abrev='HGB' or tes_abrev='HCT' or tes_abrev='MCV' or tes_abrev='MCH' or tes_abrev='MCHC' or tes_abrev='RDW' or " & _
                                    "tes_abrev='PLT' or tes_abrev='PCT' or tes_abrev='MPV' or tes_abrev='PDW')"
                                Case Else
                                    STR_SQL = "Delete from res_procesados where ped_id=" & CInt(Trim(dtt_trabajo.Rows(int_indice).Item(0).ToString)) & " and tes_abrev='" & str_abrev & "'"
                            End Select
                            opr_conexion.sql_conectar()
                            odc_trabajo = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
                            odc_trabajo.ExecuteNonQuery()
                            opr_conexion.sql_desconn()
                        Else
                            str_eqpid = "equ_id=" & Trim(dtt_trabajo.Rows(int_indice).Item(5).substring(150, 10)) & ", "
                            opr_archivos.GuardarTrabajoResArchivo(CInt(Trim(dtt_trabajo.Rows(int_indice).Item(0).ToString)), "", "", opr_archivos.Abrev_TestAuto(Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString)), opr_equipos.LeerSNIEquipo(Trim(dtt_trabajo.Rows(int_indice).Item(5).substring(150, 10))), 0, "", Trim(dtt_trabajo.Rows(int_indice).Item(5).ToString), TIPO, Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString))
                        End If
                    End If
                    'se actualiza los valores de la lista
                    STR_SQL = "Update lista_trabajo set " & str_eqpid & _
                    "tim_id=" & int_muestraid & ", " & _
                    "lis_equtimid='" & str_muestraideqp & "', " & _
                    "lis_posnum=" & int_pos & ", " & _
                    "lis_tubo=" & int_idtubo & ", " & _
                    "lis_rack='" & Trim(Mid(dtt_trabajo.Rows(int_indice).Item(8).ToString, 1, 10)) & "' " & _
                    "where lis_id = " & dtt_trabajo.Rows(int_indice).Item(15) & "  and LIS_RESESTADO=0"
                End If
                opr_conexion.sql_conectar()
                odc_trabajo = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
                odc_trabajo.ExecuteNonQuery()
                opr_conexion.sql_desconn()
                'g_opr_usuario.CargarTransaccion(g_str_login, "Nueva Detalle Lista Trabajo", STR_SQL)
                If dtt_trabajo.Rows(int_indice).Item(15) = 0 Then
                    'actualizamos el estatus en la tabla pedido
                    Dim str_sqlaux As String
                    If dtt_trabajo.Rows(int_indice).Item(14) <> 0 Then
                        str_sqlaux = " and per_id=" & dtt_trabajo.Rows(int_indice).Item(14)
                    Else
                        str_sqlaux = " and per_id is NULL"
                    End If
                    STR_SQL = "update PEDIDO_DETALLE_DESGLOSADO set PDD_ESTADO=1 " & _
                    "where ped_id=" & dtt_trabajo.Rows(int_indice).Item(0) & " " & str_sqlaux & "  and  TES_ID=" & Trim(dtt_trabajo.Rows(int_indice).Item(4).ToString)
                    opr_conexion.sql_conectar()
                    odc_trabajo = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
                    odc_trabajo.ExecuteNonQuery()
                    opr_conexion.sql_desconn()
                End If
            End If

        Next
        Return True
        '***************original
        'opr_conexion.sql_desconn
        '***************original
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Lista de Trabajo", Err)
        Err.Clear()
    End Function


    Public Function LeerEquipoTest(ByVal tes_id As Integer, ByVal byt_buscar As Byte) As DataSet
        'funcion que devuelve el equio para un determinado test
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_equipo As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        Select Case byt_buscar
            Case 0
                oda_equipo.SelectCommand = New SqlCommand("SELECT equ_modelo, equipo.equ_id, equipo.equ_estado FROM equipo, test_equipo where equipo.equ_id=test_equipo.equ_id and teq_estado=1 and test_equipo.tes_id= " & tes_id, opr_conexion.conn_sql)
            Case 1
                oda_equipo.SelectCommand = New SqlCommand("SELECT equ_modelo, equipo.equ_id, equipo.equ_estado FROM equipo, test_equipo where equipo.equ_id=test_equipo.equ_id and teq_prioridad=1 and teq_estado=1 and test_equipo.tes_id= " & tes_id, opr_conexion.conn_sql)
        End Select
        LeerEquipoTest = New DataSet()
        oda_equipo.Fill(LeerEquipoTest, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Equipo por Test", Err)
        Err.Clear()
    End Function

    Public Function LeerRangoNormalTest(ByVal tes_id As Integer) As String
        On Error GoTo msgerror
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String = "SELECT IF(RANG_TIPO = 0,'',IF(RANG_TIPO = 2,RANG_MUL,CONCAT(RANG_MIN, '--', RANG_MAX)))  AS RANGO FROM TEST_RESULTADO WHERE TES_ID = " & tes_id & ";"
        opr_conexion.sql_conectar()
        LeerRangoNormalTest = ""
        LeerRangoNormalTest = CStr(New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
msgerror:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Rango Normal Test", Err)
        Err.Clear()
    End Function

    Public Function LeerTrabajo(ByVal usu_id As Integer, ByVal fec_ini As Date, ByVal fec_fin As Date) As DataSet
        'LEE EL LOS TEST DE LA LISTA DE TRABAJO QUE SON MANUALES 
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo_manual As SqlDataAdapter = New SqlDataAdapter()
        Dim str_areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)
       
        Dim STR_FECHA As String

        STR_FECHA = " and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') "

        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing , CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST INNER JOIN ((PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID) ON TEST.TES_ID = LISTA_TRABAJO.TES_ID WHERE (((LISTA_TRABAJO.LIS_RESESTADO) = 0 or (LISTA_TRABAJO.LIS_RESESTADO) = 3) And ((TEST.TES_TPROCES) = 0)) " & STR_FECHA
        str_sql1 = "union SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST, PACIENTE, PEDIDO, LISTA_TRABAJO WHERE TEST.TES_ID = LISTA_TRABAJO.TES_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND LISTA_TRABAJO.LIS_RESESTADO=0 AND TEST.TES_TPROCES=1 AND PACIENTE.PAC_ID = PEDIDO.PAC_ID and LISTA_TRABAJO.EQU_ID IS NULL" & STR_FECHA

        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        int_i = UBound(areas)
        'controla que tenga areas por consultar
        Dim i As Integer
        If int_i > 0 Then
            For i = 0 To (int_i - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If
        str_sql = str_sql & str_aux

        str_aux = str_aux & "group by PEDIDO.PED_ID order by ped_fecing desc"
        str_sql = str_sql & str_sql1 & " " & str_aux

        oda_trabajo_manual.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerTrabajo = New DataSet()
        oda_trabajo_manual.Fill(LeerTrabajo, "Registros")
        LeerTrabajo.Dispose()
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Lista de Trabajo", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function

    'Sub LlenarGridTrabajoManual(ByRef dgrd_trabajo_manual As DataGrid, ByVal ped_id As String, ByVal tipo As Byte)
    Sub LlenarGridTrabajoManual(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date)
        'tiempo 0 -- todos;  1--1 mes; 2-- 1 d�a  
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTrabajo(g_sng_user, fec_ini, fec_fin).Tables("Registros")
    End Sub

    Public Function LlenarGridTrabajoManualOrden(ByRef data As DataView, ByVal orden As String) As DataSet
        'On Error Resume Next
        'data.AllowDelete = False
        'data.AllowEdit = False
        'data.AllowNew = False
        'data.Table = LeerTrabajoOrden(g_sng_user, orden).Tables("Registros")
        ''LeerTrabajoOrden
        'LEE EL LOS TEST DE LA LISTA DE TRABAJO QUE SON MANUALES 
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo_manual As SqlDataAdapter = New SqlDataAdapter()
        Dim str_areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer
        Dim fec_ini, fec_fin, turno As String

        fec_ini = Format(Now, "yyyy") & "-" & Mid(orden, 1, 2) & "-" & Mid(orden, 3, 2)
        fec_fin = fec_ini
        turno = Mid(orden, 5, 4)

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)
       
        Dim STR_FECHA As String

        STR_FECHA = " and (PEDIDO.ped_fecing between '" & fec_ini & " 00:00:00' and '" & fec_fin & " 23:59:59') and PEDIDO.ped_turno = " & turno & " "

        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing , CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST INNER JOIN ((PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID) ON TEST.TES_ID = LISTA_TRABAJO.TES_ID WHERE (((LISTA_TRABAJO.LIS_RESESTADO) = 0 or (LISTA_TRABAJO.LIS_RESESTADO) = 3) And ((TEST.TES_TPROCES) = 0)) " & STR_FECHA
        str_sql1 = "union SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST, PACIENTE, PEDIDO, LISTA_TRABAJO WHERE TEST.TES_ID = LISTA_TRABAJO.TES_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND LISTA_TRABAJO.LIS_RESESTADO=0 AND TEST.TES_TPROCES=1 AND PACIENTE.PAC_ID = PEDIDO.PAC_ID and LISTA_TRABAJO.EQU_ID IS NULL" & STR_FECHA

        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        int_i = UBound(areas)
        'controla que tenga areas por consultar
        Dim i As Integer
        If int_i > 0 Then
            For i = 0 To (int_i - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If
        str_sql = str_sql & str_aux

        str_aux = str_aux & "group by PEDIDO.PED_ID order by ped_fecing desc"
        str_sql = str_sql & str_sql1 & " " & str_aux

        oda_trabajo_manual.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LlenarGridTrabajoManualOrden = New DataSet()
        oda_trabajo_manual.Fill(LlenarGridTrabajoManualOrden, "Registros")
        '******************************
        '******************************

        LlenarGridTrabajoManualOrden.Dispose()
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Lista de Trabajo", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default


    End Function


    Public Function LlenarListPlantillaOrden(ByRef lst_manuales As ListBox, ByVal orden As String, ByVal filtro As Integer, ByVal ReceptaAreas As String, ByVal ped_fecing As String, ByVal abrev As String) As DataSet

        'LEE EL LOS TEST DE LA LISTA DE TRABAJO QUE SON MANUALES 
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo_manual As SqlDataAdapter = New SqlDataAdapter()
        Dim str_areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer
        Dim fec_ini, fec_fin, turno As String

        'fec_ini = Mid(orden, 3, 2) & "/" & Mid(orden, 1, 2) & "/" & Format(Now, "yyyy")
        fec_ini = Format(CDate(ped_fecing), "dd/MM/yyyy")
        fec_fin = fec_ini
        turno = Mid(orden, 5, 5)

        'opr_user.LeerAreasUsuario(g_sng_user, arr_datos, arr_nombre)
        'For int_i = 0 To arr_datos.Count - 1
        'str_areas = str_areas & arr_datos(int_i) & ","
        'Next
        Dim STR_FECHA As String
        STR_FECHA = " and (PEDIDO.ped_fecing between '" & fec_ini & " 00:00:00' and '" & fec_fin & " 23:59:59') and PEDIDO.ped_turno = " & turno & " "

        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""

        str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, (PACIENTE.PAC_APELLIDO+ ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST_RESULTADO.RES_ID as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac, " & _
                    "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                "TEST_EQUIPO.TEQ_ABRV_FIJA AS ABREV, TEST.TIM_ID as TIM_ID, TEST.TES_ID, TEST.TES_AB, case when LISTA_TRABAJO.LIS_RESESTADO = 0 then 'PENDIENTE' when LISTA_TRABAJO.LIS_RESESTADO = 1 then 'PROCESADO' when LISTA_TRABAJO.LIS_RESESTADO = 2 then 'VALIDADO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'IMPRESO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'ANULADO' end as ESTADO, AREA.ARE_OBS " & _
                "FROM TEST INNER JOIN ((PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID) ON TEST.TES_ID = LISTA_TRABAJO.TES_ID INNER JOIN TEST_RESULTADO ON TEST_RESULTADO.TES_ID = TEST.TES_ID INNER JOIN TEST_EQUIPO ON TEST_EQUIPO.TES_ID  = TEST.TES_ID, AREA " & _
                "WHERE AREA.ARE_ID = TEST.ARE_ID AND (((LISTA_TRABAJO.LIS_RESESTADO) <> 5 ) And ((TEST.TES_TPROCES) = 1)) AND (TEST_RESULTADO.RES_ID = 1 or TEST_RESULTADO.RES_ID = 4 or TEST_RESULTADO.RES_ID = 6 OR TEST_RESULTADO.RES_ID =8 OR TEST_RESULTADO.RES_ID =9) " & STR_FECHA
        str_sql1 = "union SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, (PACIENTE.PAC_APELLIDO+ ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac, " & _
            "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, TEST_EQUIPO.TEQ_ABRV_FIJA AS ABREV, TEST.TIM_ID as TIM_ID, TEST.TES_ID, TEST.TES_AB, case when LISTA_TRABAJO.LIS_RESESTADO = 0 then 'PENDIENTE' when LISTA_TRABAJO.LIS_RESESTADO = 1 then 'PROCESADO' when LISTA_TRABAJO.LIS_RESESTADO = 2 then 'VALIDADO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'IMPRESO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'ANULADO' end as ESTADO, AREA.ARE_OBS " & _
            "FROM TEST, PACIENTE, PEDIDO, LISTA_TRABAJO, TEST_EQUIPO, AREA " & _
            "WHERE TEST_EQUIPO.TES_ID = TEST.TES_ID AND TEST.TES_ID = LISTA_TRABAJO.TES_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND (LISTA_TRABAJO.LIS_RESESTADO<>5) AND TEST.TES_TPROCES=1 AND PACIENTE.PAC_ID = PEDIDO.PAC_ID and LISTA_TRABAJO.EQU_ID IS NULL and AREA.ARE_ID = TEST.ARE_ID" & STR_FECHA

        ''Dim areas() As String
        Dim str_aux As String = ""


        If ReceptaAreas <> "00" Then
            str_aux = "and ("
            str_aux = str_aux & "TEST.are_id in(" & ReceptaAreas & ")) "
            str_sql = str_sql & str_aux
        End If

        str_aux = str_aux & "order by AREA.ARE_OBS asc"
        str_sql = str_sql & str_sql1 & " " & str_aux

        oda_trabajo_manual.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LlenarListPlantillaOrden = New DataSet()
        oda_trabajo_manual.Fill(LlenarListPlantillaOrden, "Registros")
        '******************************

        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        opr_conexion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LlenarListPlantillaOrden = New DataSet()
        oda_operacion.Fill(LlenarListPlantillaOrden, "Registros")


        lst_manuales.Items.Clear()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_manuales.Items.Add(odr_operacion.GetValue(13).ToString().PadRight(8) & "    " & odr_operacion.GetValue(4).ToString().PadRight(160) & odr_operacion.GetValue(14).ToString() & odr_operacion.GetValue(17).ToString() & odr_operacion.GetValue(6).ToString())
        End While
        'odr_operacion.Close()
        opr_conexion.sql_desconn()



        '******************************

        LlenarListPlantillaOrden.Dispose()
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, llenar Lista de plantilla", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default


    End Function


    Public Function LlenarListCutaneasOrden(ByRef lst_manuales As ListBox, ByVal ped_id As Integer) As DataSet

        'LEE EL LOS TEST DE LA LISTA DE TRABAJO QUE SON MANUALES 
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo_manual As SqlDataAdapter = New SqlDataAdapter()
        Dim str_areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer
        Dim fec_ini, fec_fin, turno As String

    
        opr_conexion.sql_conectar()
        Dim str_sql As String = ""

        str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, (PACIENTE.PAC_APELLIDO+ ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST_RESULTADO.RES_ID as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac, " & _
                    "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                "TEST_EQUIPO.TEQ_ABRV_FIJA AS ABREV, TEST.TIM_ID as TIM_ID, TEST.TES_ID, TEST.TES_AB, case when LISTA_TRABAJO.LIS_RESESTADO = 0 then 'PENDIENTE' when LISTA_TRABAJO.LIS_RESESTADO = 1 then 'PROCESADO' when LISTA_TRABAJO.LIS_RESESTADO = 2 then 'VALIDADO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'IMPRESO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'ANULADO' end as ESTADO, AREA.ARE_OBS " & _
                "FROM TEST INNER JOIN ((PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID) ON TEST.TES_ID = LISTA_TRABAJO.TES_ID INNER JOIN TEST_RESULTADO ON TEST_RESULTADO.TES_ID = TEST.TES_ID INNER JOIN TEST_EQUIPO ON TEST_EQUIPO.TES_ID  = TEST.TES_ID, AREA " & _
                "WHERE PEDIDO.PED_ID = " & ped_id & " AND AREA.ARE_ID = TEST.ARE_ID AND (((LISTA_TRABAJO.LIS_RESESTADO) <> 5 ) And ((TEST.TES_TPROCES) = 1)) AND (TEST_RESULTADO.RES_ID = 1 or TEST_RESULTADO.RES_ID = 4 or TEST_RESULTADO.RES_ID = 6 OR TEST_RESULTADO.RES_ID =8 OR TEST_RESULTADO.RES_ID =9) " & _
            "union SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, (PACIENTE.PAC_APELLIDO+ ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac, " & _
            "(SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, TEST_EQUIPO.TEQ_ABRV_FIJA AS ABREV, TEST.TIM_ID as TIM_ID, TEST.TES_ID, TEST.TES_AB, case when LISTA_TRABAJO.LIS_RESESTADO = 0 then 'PENDIENTE' when LISTA_TRABAJO.LIS_RESESTADO = 1 then 'PROCESADO' when LISTA_TRABAJO.LIS_RESESTADO = 2 then 'VALIDADO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'IMPRESO' when LISTA_TRABAJO.LIS_RESESTADO = 4 then 'ANULADO' end as ESTADO, AREA.ARE_OBS " & _
            "FROM TEST, PACIENTE, PEDIDO, LISTA_TRABAJO, TEST_EQUIPO, AREA " & _
            "WHERE TEST_EQUIPO.TES_ID = TEST.TES_ID AND TEST.TES_ID = LISTA_TRABAJO.TES_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND (LISTA_TRABAJO.LIS_RESESTADO<>5) AND TEST.TES_TPROCES=1 AND PACIENTE.PAC_ID = PEDIDO.PAC_ID and LISTA_TRABAJO.EQU_ID IS NULL and AREA.ARE_ID = TEST.ARE_ID order by AREA.ARE_OBS asc"


        oda_trabajo_manual.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LlenarListCutaneasOrden = New DataSet()
        oda_trabajo_manual.Fill(LlenarListCutaneasOrden, "Registros")
        '******************************

        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        opr_conexion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LlenarListCutaneasOrden = New DataSet()
        oda_operacion.Fill(LlenarListCutaneasOrden, "Registros")


        lst_manuales.Items.Clear()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_manuales.Items.Add(odr_operacion.GetValue(13).ToString().PadRight(8) & "    " & odr_operacion.GetValue(4).ToString().PadRight(160) & odr_operacion.GetValue(14).ToString() & odr_operacion.GetValue(17).ToString() & odr_operacion.GetValue(6).ToString())
        End While
        'odr_operacion.Close()
        opr_conexion.sql_desconn()



        '******************************

        LlenarListCutaneasOrden.Dispose()
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, llenar Lista cutaneas", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default


    End Function


    Public Function LeerTrabajoOrden(ByVal usu_id As Integer, ByVal orden As String) As DataSet
        'LEE EL LOS TEST DE LA LISTA DE TRABAJO QUE SON MANUALES 
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo_manual As SqlDataAdapter = New SqlDataAdapter()
        Dim str_areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer
        Dim fec_ini, fec_fin, turno As String

        fec_ini = Format(Now, "yyyy") & "-" & Mid(orden, 1, 2) & "-" & Mid(orden, 3, 2)
        fec_fin = fec_ini
        turno = Mid(orden, 5, 4)

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)
        '' ''For int_i = 0 To arr_datos.Count - 1
        '' ''    str_areas = str_areas & arr_datos(int_i) & ","
        '' ''Next
        Dim STR_FECHA As String

        STR_FECHA = " and (PEDIDO.ped_fecing between '" & fec_ini & " 00:00:00' and '" & fec_fin & " 23:59:59') and PEDIDO.ped_turno = " & turno & " "

        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing , CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST INNER JOIN ((PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID) ON TEST.TES_ID = LISTA_TRABAJO.TES_ID WHERE (((LISTA_TRABAJO.LIS_RESESTADO) = 0 or (LISTA_TRABAJO.LIS_RESESTADO) = 3) And ((TEST.TES_TPROCES) = 0)) " & STR_FECHA
        str_sql1 = "union SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST, PACIENTE, PEDIDO, LISTA_TRABAJO WHERE TEST.TES_ID = LISTA_TRABAJO.TES_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND LISTA_TRABAJO.LIS_RESESTADO=0 AND TEST.TES_TPROCES=1 AND PACIENTE.PAC_ID = PEDIDO.PAC_ID and LISTA_TRABAJO.EQU_ID IS NULL" & STR_FECHA

        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        int_i = UBound(areas)
        'controla que tenga areas por consultar
        Dim i As Integer
        If int_i > 0 Then
            For i = 0 To (int_i - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If
        str_sql = str_sql & str_aux

        str_aux = str_aux & "group by PEDIDO.PED_ID order by ped_fecing desc"
        str_sql = str_sql & str_sql1 & " " & str_aux

        oda_trabajo_manual.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerTrabajoOrden = New DataSet()
        oda_trabajo_manual.Fill(LeerTrabajoOrden, "Registros")
        '******************************
        '******************************

        LeerTrabajoOrden.Dispose()
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Lista de Trabajo", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function



    Public Sub Actu_Test_Trabajo(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal str_resultado As String, Optional ByVal rango As String = "--")
        On Error GoTo MsgError
        Dim OPR_CONEXION As New Cls_Conexion()
        Dim estado As Integer
        OPR_CONEXION.sql_conectar()
        If (str_resultado = "Remitido") Then
            estado = 9
        Else
            estado = 1

        End If
        Dim odc_pedido As SqlCommand = New SqlCommand("Update LISTA_TRABAJO set LIS_RESMANUAL = '" & str_resultado & "', LIS_RESESTADO = " & estado & ", lis_resrango = '" & rango & "' where ped_id = " & ped_id & " and tes_id = " & tes_id & "", OPR_CONEXION.conn_sql)
        odc_pedido.ExecuteNonQuery()
        OPR_CONEXION.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Graba result manual", "", g_sng_user, ped_id, "", tes_id)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar test Lista de Trabajo", Err)
        Err.Clear()
    End Sub

    Public Sub Actu_Test_Trabajo2(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal str_resultado As String, ByRef boo_guardar As Boolean, ByVal res_mis As String, ByVal tes_abrev As String, ByVal tim_id As Integer)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Update LISTA_TRABAJO set LIS_RESMANUAL = '" & str_resultado & "', LIS_RESESTADO = 1, LIS_RESRANGO = '" & res_mis & "' where ped_id = " & ped_id & " and tes_id = " & tes_id & ""
        Dim str_sql2 As String = "Update RES_PROCESADOS set PRC_RESFINAL = 'MEMO', PRC_RESUL = 'MEMO', PRC_RANGO = '" & res_mis & "', PRC_TEXTO = '" & str_resultado & "' where ped_id = " & ped_id & " and TES_ABREV = '" & tes_abrev & "' and TIM_ID = " & tim_id & ";"
        'str_sql = "update res_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "', prc_rango = '" & rango & "', prc_alarma = '" & prc_error & "' where ped_id = " & ped_id & " And TES_ABREV = '" & abrev & "' and tim_id = " & tim_id & ";"
        Dim odb_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        Dim odb_pedido2 As SqlCommand = New SqlCommand(str_sql2, opr_conexion.conn_sql)
        odb_pedido.ExecuteNonQuery()
        odb_pedido2.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        boo_guardar = True
        MsgBox("Resultados manuales almacenados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "GRABA R_MANUAL Lis", "PEDIDO=" & ped_id, g_sng_user, ped_id, "", tes_id)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar test Lista de Trabajo", Err)
        Err.Clear()
    End Sub

    Public Sub LeerDatosTest_LIS(ByVal TEST_ID As Integer, ByVal EQP_ID As Integer, ByRef ARR_STR_DATOS As String())
        'EXTRAE TODOS LOS DATOS DE UN TEST ESPECIFICO con el EQUIPO en que se ejecuta, trae
        'LOS TUBOS (1: tubo con c�digo de barra, 2: copa o tubo sin c�digo de barra, 3: ambos), y MUESTRAS
        On Error Resume Next 'MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        STR_SQL = "SELECT test.TES_NOMBRE, equipo.EQU_TUBO, equipo.EQU_MUESTRA, testequipo_tipmuestra.TIM_ID, equipo.EQU_MUESTRAID, testequipo_tipmuestra.TIM_DEFAULT, testequipo_tipmuestra.TUB_DEFAULT, EQU_RACK " & _
          "FROM test, testequipo_tipmuestra, test_equipo, equipo WHERE test.TES_ID = test_equipo.TES_ID AND equipo.EQU_ID = test_equipo.EQU_ID AND " & _
          "test_equipo.TEQ_ID = testequipo_tipmuestra.TEQ_ID AND test_equipo.TES_ID=" & TEST_ID & " AND test_equipo.EQU_ID=" & EQP_ID
        Dim odr_datos As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
        Dim byt_cont As Byte = 0
        ReDim ARR_STR_DATOS(7)
        While odr_datos.Read
            If byt_cont = 0 Then
                'EQUIPO.EQU_TUBO
                ARR_STR_DATOS(0) = odr_datos.GetValue(1)
                'EQUIPO.EQU_MUESTRA
                ARR_STR_DATOS(1) = odr_datos.GetValue(2)
                'EQUIPO.EQU_MUESTRAID
                ARR_STR_DATOS(3) = odr_datos.GetValue(4)
                'TESTEQUIPO_TIPMUESTRA.TUB_DEFAULT 1 DEFAULT, inicializa el tubo por default con 0
                ARR_STR_DATOS(5) = 0
                'TESTEQUIPO_TIPMUESTRA.TIM_ID los respectivos c�digos
                ARR_STR_DATOS(2) = ""
                ARR_STR_DATOS(4) = ""
                'extrae los datos del rack y el n�mero de posiciones que acepta ej: A-100 donde A es el rack, 100 el n�mero m�ximo de muestras que acepta dicho rack
                ARR_STR_DATOS(6) = odr_datos.GetValue(7)
            End If
            byt_cont = 1
            If Not IsDBNull(odr_datos.GetValue(3)) Then
                If Trim(odr_datos.GetValue(3)) <> "" Then
                    ARR_STR_DATOS(2) = odr_datos.GetValue(3) & "," & ARR_STR_DATOS(2)
                    If odr_datos.GetValue(5) = 1 Then
                        'ARR_STR_DATOS(4) en esta variable se coloca el valor de la muestra predeterminada, cuando TESTEQUIPO_TIPMUESTRA.TIM_DEFAULT = 1
                        ARR_STR_DATOS(4) = odr_datos.GetValue(3)
                        'establece el tubo por default para un tipo de muestra espec�fico
                        ARR_STR_DATOS(5) = odr_datos.GetValue(6)
                    End If
                End If
            End If
        End While
        If ARR_STR_DATOS(2) <> "" Then ARR_STR_DATOS(2) = Mid(ARR_STR_DATOS(2), 1, Len(ARR_STR_DATOS(2)) - 1)
        odr_datos.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer datos del test configurados", Err)
        '        Err.Clear()
    End Sub

    Public Function LeerEquipo(ByVal ped_id As Integer, ByVal tes_id As Integer) As DataSet
        'Funcion para la consultar el equipo en el que se proceso un test de un pedido 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select equ_id from LISTA_TRABAJO where ped_id = " & ped_id & " and tes_id = " & tes_id & "", opr_Conexion.conn_sql)
        LeerEquipo = New DataSet()
        oda_operacion.Fill(LeerEquipo, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Equipo", Err)
        Err.Clear()
    End Function

    Sub LlenarFechaListaTrabajo(ByRef lst_trabajo As CheckedListBox)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_trabajo As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_trabajo As New DataSet()
        opr_conexion.sql_conectar()
        STR_SQL = "SELECT distinct LIS_FECING FROM LISTA_TRABAJO, equipo  WHERE LIS_RESESTADO = 0 and equipo.EQU_ID=LISTA_TRABAJO.EQU_ID AND EQU_FORMATO<>'' ORDER BY LIS_FECING;"
        oda_trabajo.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        oda_trabajo.Fill(dts_trabajo, "Registros")
        opr_conexion.sql_desconn()
        lst_trabajo.Items.Clear()
        Dim dtr_fila As DataRow
        Dim dat_fecha As Date
        For Each dtr_fila In dts_trabajo.Tables("Registros").Rows
            dat_fecha = dtr_fila("LIS_FECING").ToString()
            lst_trabajo.Items.Add(Format(dat_fecha, "dd-MMM-yyyy"))
        Next
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Fecha Lista Trabajo", Err)
        Err.Clear()
    End Sub

    Public Sub CambioEstadoItemLista(ByVal lis_id As Integer, ByVal estado As Single)
        '18-06-2013
        'Los estados posibles de la lista de trabajo son:
        '0 : no procesado, 
        '1 :procesado
        '2 :validado
        '3 :enviado al equipo 
        '4 :error al suboir datos al equipo
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()

        Dim str_sql As String = "update lista_trabajo set lis_resestado=" & estado & "  where lis_id=" & lis_id & " and lis_resestado <> 2"

        'Dim odc_pedido2 As SqlCommand = New SqlCommand(str_sql2, opr_Conexion.conn_sql)
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)

        'odc_pedido2.ExecuteNonQuery()
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Cambio Estado Item Lista", Err)
        Err.Clear()
    End Sub

    Sub LlenarComboServicio(ByRef cmb_servicios As ComboBox)
        On Error Resume Next
        'Para llenar el combo de convenio
        Dim dts_convenio As DataSet
        Dim dtr_fila As DataRow
        dts_convenio = LeerServicio()
        cmb_servicios.Items.Clear()
        For Each dtr_fila In dts_convenio.Tables("Registros").Rows
            cmb_servicios.Items.Add(dtr_fila("ser_nombre").ToString())
        Next
        dts_convenio.Dispose()
        cmb_servicios.SelectedIndex = 0
    End Sub



    Public Function LeerServicio() As DataSet
        'Procedimiento para consultar todas los Convenios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select * from SERVICIO ORDER BY SER_ID", opr_Conexion.conn_sql)
        LeerServicio = New DataSet()
        oda_operacion.Fill(LeerServicio, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Convenios", Err)
        Err.Clear()
    End Function


    Public Function Leer_Validado(ByVal int_lisid As Integer) As Integer
        'RF
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        Dim valor As Integer
        str_sql = "select lista_trabajo.LIS_RESESTADO from lista_trabajo, test where lista_trabajo.TES_ID = test.TES_ID and lis_id = " & int_lisid & " ;"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            Leer_Validado = 0
        Else
            Leer_Validado = dts_datos.Tables(0).Rows(0).Item(0)
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer EstadoLisID", Err)
        Err.Clear()
    End Function


    Public Function Leer_Lis_ID(ByVal ped_id As Integer, ByVal str_abrev As String, ByVal TIM_ID As Integer) As Integer
        ' 26 JUNIO 2013 Funcion para la consultar el lis_id de una prueba determinada 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        Dim valor As Integer
        '                                                           "WBC,LYM%25,MID%25,GRN%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT"
        'If str_abrev = "WBC" Or str_abrev = "MID%25" Or str_abrev = "GRN%25" Or str_abrev = "RBC" Or str_abrev = "MCV" Or str_abrev = "MCH" Or str_abrev = "MCHC" Or str_abrev = "RDW" Then
        If str_abrev.StartsWith("WBC") Or str_abrev.StartsWith("MID%25") Or str_abrev.StartsWith("GRN%25") Or str_abrev.StartsWith("RBC") Or str_abrev.StartsWith("MCV") Or str_abrev.StartsWith("MCH") Or str_abrev.StartsWith("MCHC") Or str_abrev.StartsWith("RDW") Then
            valor = tipo_lis(ped_id)
            If valor = 2 Then
                str_abrev = "BIOMETRIA HEMATICA"
            ElseIf valor = 1 Then
                str_abrev = "FORMULA LEUCOCITARIA"
            ElseIf valor = 3 Then
                str_abrev = "INDICES HEMATICOS"
            End If
        End If
        'str_sql = "select LT.LIS_ID from lista_trabajo as LT, test_equipo as TE, test as T where LT.ped_id = " & ped_id & "  and TE.TEQ_ABRV_FIJA = '" & Trim(str_abrev) & "' AND LT.TES_ID = T.TES_ID AND TE.TES_ID = T.TES_ID AND LT.TES_ID = TE.TES_ID"
        str_sql = "select LT.LIS_ID from lista_trabajo as LT, test_equipo as TE, test as T where LT.ped_id = " & ped_id & "  and TE.TEQ_ABRV_FIJA = '" & Trim(str_abrev) & "' AND LT.TES_ID = T.TES_ID AND TE.TES_ID = T.TES_ID AND LT.TES_ID = TE.TES_ID AND T.TIM_ID = " & TIM_ID & ";"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            Leer_Lis_ID = 0
        Else
            Leer_Lis_ID = dts_datos.Tables(0).Rows(0).Item(0)
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer LisID", Err)
        Err.Clear()
    End Function


    Public Function Leer_Lis_ID(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal TIM_ID As Integer) As Integer
        ' 26 JUNIO 2013 Funcion para la consultar el lis_id de una prueba determinada 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        Dim valor As Integer

        str_sql = "select LT.LIS_ID from lista_trabajo as LT, test_equipo as TE, test as T where LT.ped_id = " & ped_id & "  and LT.TES_ID = " & tes_id & " AND LT.TES_ID = T.TES_ID AND TE.TES_ID = T.TES_ID AND LT.TES_ID = TE.TES_ID AND T.TIM_ID = " & TIM_ID & ";"

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            Leer_Lis_ID = 0
        Else
            Leer_Lis_ID = dts_datos.Tables(0).Rows(0).Item(0)
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer LisID", Err)
        Err.Clear()
    End Function


    Public Function tipo_lis(ByVal ped_id As Integer) As Integer
        '6 nov- 2003 JVA verifica si es biometria o formula leucocitaria
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""

        str_sql = "select tes_id from pedido_detalle where ped_id = " & ped_id
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        Dim int_indice As Short = 0
        Dim dtr_fila As DataRow
        For int_indice = 0 To dts_datos.Tables(0).Rows.Count - 1
            ' 36 codigo de FORMULA LEUCOCITARIA 
            If dts_datos.Tables(0).Rows(int_indice).Item(0) = "36" Then
                tipo_lis = 1
                ' 1 codigo BIOMETRIA HEMATICA
            ElseIf dts_datos.Tables(0).Rows(int_indice).Item(0) = "400101" Then
                tipo_lis = 2
                '488 INDICES HEMATICOS
            ElseIf dts_datos.Tables(0).Rows(int_indice).Item(0) = "488" Then
                tipo_lis = 3
            End If
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, TIPO LIS", Err)
        Err.Clear()
    End Function


    Public Sub GuardarRangoManual(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal rango As String)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Update LISTA_TRABAJO set LIS_RESRANGO = '" & rango & "' where ped_id = " & ped_id & " and tes_id = " & tes_id & ""
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "GuardarRangoManual", "RANGO=" & rango, g_sng_user, ped_id, "", tes_id)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, GuardarRangoManual", Err)
        Err.Clear()
    End Sub

    Public Function Leer_testIDTrabajo(ByVal lis_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        str_sql = "select LT.TES_ID from lista_trabajo as LT where LT.lis_id = " & lis_id & ""
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            Leer_testIDTrabajo = 0
        Else
            Leer_testIDTrabajo = dts_datos.Tables(0).Rows(0).Item(0)
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer testIDTrabajo", Err)
        Err.Clear()
    End Function

    Public Function TieneParametros(ByVal tes_padre As Integer) As Integer
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "select count(tes_id) as param from test where tes_padre = " & tes_padre
        opr_conexion.sql_conectar()
        TieneParametros = 0
        TieneParametros = CStr(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Parametros EXAMEN", Err)
        Err.Clear()

    End Function


    Public Function LeeIdParametros(ByVal tes_padre As Integer, ByVal EsCultivo As Byte) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        If EsCultivo = 1 Then
            str_sql = "select tes_id from test where tes_padre = " & tes_padre & " order by tes_id asc"
            'str_sql = "select tes_id from test_cultivo where tcu_id = " & tes_padre & " order by tes_id asc"
        Else
            str_sql = "select tes_id from test where tes_padre = " & tes_padre & " order by tes_id asc"
        End If

        opr_conexion.sql_conectar()
        LeeIdParametros = ""
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            LeeIdParametros = LeeIdParametros & Str(odr_parametros.GetValue(0)) & ","
        End While
        'LeeIdParametros = tes_id & "," & LeeIdParametros
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Parametros EXAMEN", Err)
        Err.Clear()
    End Function


    Public Function LeeId_AB() As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        str_sql = "select antibiotico.ANB_ID , antibiotico.ANB_NOMBRE from antibiotico where antibiotico.ANB_ESTADO = 1 order by antibiotico.ANB_ORDEN; "

        opr_conexion.sql_conectar()
        LeeId_AB = ""
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            LeeId_AB = LeeId_AB & Str(odr_parametros.GetValue(0)) & ","
        End While
        'LeeIdParametros = tes_id & "," & LeeIdParametros
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Parametros EXAMEN", Err)
        Err.Clear()
    End Function


    Public Function LeeParametros(ByVal tes_id As Integer, ByVal genero As Char, ByVal edad As String, ByVal tes_padre As Integer, ByVal unidad As String) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing
        Dim ggenero As String = Nothing
        Dim entro As Boolean = False

        '''***********************************************************
        Select Case unidad
            Case "MESES", "meses"
                If genero = "F" Or genero = "M" Then
                    If (CInt(edad) >= 1 And CInt(edad) <= 12) Then
                        ggenero = "NIÑO"
                    End If
                End If

            Case "DIAS", "dias", "días"

                If genero = "F" Or genero = "M" Then
                    If (CInt(edad) = 0) Then
                        If entro = False Then
                            ggenero = "R1"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 1 And CInt(edad) <= 3) Then
                        If entro = False Then
                            ggenero = "R2"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 4 And CInt(edad) <= 7) Then
                        If entro = False Then
                            ggenero = "R3"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 8 And CInt(edad) <= 14) Then
                        If entro = False Then
                            ggenero = "R4"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 15 And CInt(edad) <= 31) Then
                        If entro = False Then
                            ggenero = "R5"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 32 And CInt(edad) <= 60) Then
                        If entro = False Then
                            ggenero = "R6"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 0 And CInt(edad) <= 30) Then
                        If entro = False Then
                            ggenero = "RN"
                            entro = True
                        End If
                    End If
                End If

            Case "años", "AÑOS"
                If genero = "F" Then
                    If (CInt(edad) >= 1 And CInt(edad) < 6) Then
                        ggenero = "NIÑO"
                    End If

                    If (CInt(edad) >= 6 And CInt(edad) <= 11) Then
                        ggenero = "MUJER"
                        entro = True
                    End If

                    If (CInt(edad) >= 12 And CInt(edad) <= 18) Then
                        ggenero = "M1"
                        entro = True
                    End If

                    If (CInt(edad) >= 19 And CInt(edad) <= 49) Then
                        ggenero = "M2"
                        entro = True
                    End If

                    If (CInt(edad) >= 50 And CInt(edad) <= 110) Then
                        ggenero = "MUJER"
                        entro = True
                    End If
                Else
                    If (CInt(edad) >= 1 And CInt(edad) < 6) Then
                        ggenero = "NIÑO"
                    End If

                    If (CInt(edad) >= 6 And CInt(edad) <= 11) Then
                        ggenero = "HOMBRE"
                        entro = True
                    End If

                    If (CInt(edad) >= 12 And CInt(edad) <= 18) Then
                        ggenero = "H1"
                        entro = True
                    End If

                    If (CInt(edad) >= 19 And CInt(edad) <= 49) Then
                        ggenero = "H2"
                        entro = True
                    End If

                    If (CInt(edad) >= 50 And CInt(edad) <= 110) Then
                        ggenero = "HOMBRE"
                        entro = True
                    End If
                End If

        End Select

        If LeerTieneAbrev(tes_id, ggenero) >= 1 Then
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = '" & ggenero & "';"
        Else
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = 'HOMBRE';"
        End If

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader




        opr_conexion.sql_conectar()
        LeeParametros = ""
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            LeeParametros = Trim(odr_parametros.GetString(0)) & "," & odr_parametros.GetString(1) & "," & odr_parametros.GetString(2) & "," & Trim(odr_parametros.GetString(3)) & ","
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Parametros EXAMEN", Err)
        Err.Clear()
    End Function

    Public Function EquipoItemListaTrabajo(ByVal idlista As Integer) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next '* Aqu� da un error pero no sabemos porque 
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        EquipoItemListaTrabajo = ""
        EquipoItemListaTrabajo = CStr(New SqlCommand("Select isnull(equ_id,'') from lista_trabajo where lis_id=" & idlista, opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codgo Lista de Trabajo", Err)
        Err.Clear()
    End Function

    Sub LlenarGridTrabajoCorregir(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date)
        'funcion que llena en un datagrid los datos de los pedidos
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerTrabajoCorregir(fec_ini, fec_fin).Tables("Registros")

    End Sub

    Public Function LeerTrabajoCorregir(ByVal fec_ini As Date, ByVal fec_fin As Date) As DataSet
        'LEE EL LOS TEST DE LA LISTA DE TRABAJO QUE SON MANUALES 
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo_manual As SqlDataAdapter = New SqlDataAdapter()
        Dim str_fecha As String = ""
        opr_conexion.sql_conectar()

        str_fecha = " and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') "

        Dim str_sql As String = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing , CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno FROM TEST INNER JOIN ((PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID) ON TEST.TES_ID = LISTA_TRABAJO.TES_ID WHERE (LISTA_TRABAJO.LIS_RESESTADO = 1  or LISTA_TRABAJO.lis_resestado = 2) And TEST.TES_TPROCES= 0 " & str_fecha
        str_sql = str_sql & " union SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno FROM TEST, PACIENTE, PEDIDO, LISTA_TRABAJO WHERE TEST.TES_ID = LISTA_TRABAJO.TES_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND (LISTA_TRABAJO.LIS_RESESTADO=1 or LISTA_TRABAJO.lis_resestado = 2) AND TEST.TES_TPROCES=1 AND PACIENTE.PAC_ID = PEDIDO.PAC_ID and LISTA_TRABAJO.EQU_ID IS NULL " & str_fecha
        oda_trabajo_manual.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerTrabajoCorregir = New DataSet()
        oda_trabajo_manual.Fill(LeerTrabajoCorregir, "Registros")
        LeerTrabajoCorregir.Dispose()
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Trabajo Corregir", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function

    Public Sub Actu_Test_Trabajo2(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal str_resultado As String)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_Sql As String = "Update LISTA_TRABAJO set LIS_RESMANUAL = '" & str_resultado & "' where ped_id = " & ped_id & " and tes_id = " & tes_id & ""
        Dim odc_pedido As SqlCommand = New SqlCommand(str_Sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        MsgBox("El resultado se actualizo con exito", MsgBoxStyle.Information, "ANALISYS")
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actu_Test_Trabajo", "PEDIDO=" & ped_id, g_sng_user, ped_id, "", tes_id)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar test Lista de Trabajo", Err)
        Err.Clear()
    End Sub

    Public Function LeerResManPedTest(ByVal ped_id As Integer, ByVal tes_id As Integer) As DataSet
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_trabajo_manual As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Select lis_id, lis_resmanual, uni_nomenclatura, rang_tipo, rang_max, rang_min, rang_mul, tes_nombre, lista_trabajo.ped_id as ped_id, lista_trabajo.tes_id as tes_id from lista_trabajo, unidad, test, test_resultado where lista_trabajo.tes_id = test_resultado.tes_id and lista_trabajo.tes_id = test.tes_id and test.uni_id = unidad.uni_id and ped_id = " & ped_id & " and lista_trabajo.tes_id = " & tes_id & ""
        oda_trabajo_manual.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerResManPedTest = New DataSet()
        oda_trabajo_manual.Fill(LeerResManPedTest, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, LeerResManPedTest", Err)
        Err.Clear()
    End Function

    Sub LlenarComboturno(ByRef cmb_turno As ComboBox, ByVal fechaped As Date, ByVal pedtipo As String)
        On Error GoTo msgerr
        'Para llenar el combo         
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        Dim strsql As String
        'Dim ff, fi, mes, a�o As String
        'fi = Year(fechaped) & "-" & Month(fechaped) & "-01 00:00:00"
        'If Month(fechaped) = 12 Then
        '    a�o = Year(fechaped) + 1
        '    mes = "01"
        'Else
        '    a�o = Year(fechaped)
        '    mes = Month(fechaped) + 1
        'End If
        'ff = a�o & "-" & mes & "-01 00:00:00"
        'If pedtipo = "NORMAL" Then
        strsql = "select ped_turno from pedido where ped_fecing between  '" & Format(fechaped, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fechaped, "dd/MM/yyyy") & " 23:59:59' and ped_estado <> 2 order by ped_turno"
        'Else
        'strsql = "select ped_turno from pedido where ped_fecing between  '" & Format(Now, "yyyy") & "-01-01  00:00:00' and '" & Format(Now, "dd/MM/yyyy") & " 23:59:59' and ped_estado <> 2 order by ped_turno"
        'strsql = "select ped_turno from pedido where ped_fecing between  '" & fi & "' and '" & ff & "' and ped_estado <> 2 order by ped_turno"
        'End If
        Dim odr_operacion As SqlDataReader = New SqlCommand(strsql, cls_operacion.conn_sql).ExecuteReader
        cmb_turno.Text = "0"
        cmb_turno.Items.Clear()
        While odr_operacion.Read
            cmb_turno.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(3))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_turno.SelectedIndex = (cmb_turno.Items.Count) - 1
        If cmb_turno.Text = "" Then
            cmb_turno.Text = 1
        Else
            cmb_turno.Text = Int(cmb_turno.Text) + 1
        End If
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar Turno", Err)
        Err.Clear()
    End Sub

    Sub ordena_apellido(ByVal apellido As String, ByRef data As DataView)
        'funci�n que orderna por apellido al dataview
        With data
            If Trim(apellido) <> "" Then
                .RowFilter = "PACIENTE like '" & Trim(apellido) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "ped_fecing desc"
        End With
    End Sub

    Sub ordena_pedido(ByVal pedido As String, ByRef data As DataView)
        'funci�n que orderna por pedido al dataview
        With data
            If Trim(pedido) <> "" Then
                .RowFilter = "ped_id = " & Trim(pedido) & ""
            Else
                .RowFilter = ""
            End If
            .Sort = "ped_id"
        End With
    End Sub

    Public Sub GrabaIBil(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal str_resultado As String)
        'Procedimiento grabar el resultado de la IBIL desde el Dimension AR
        On Error GoTo msgerror
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Update LISTA_TRABAJO set LIS_RESMANUAL = '" & str_resultado & "' where ped_id = " & ped_id & " and tes_id = " & tes_id & ""
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
msgerror:
        MsgBox("No se pudo realizar la operacion solicitada, GrabaIBil", MsgBoxStyle.Exclamation, "ANALISYS")
        Err.Clear()
    End Sub

    Public Function LeerEstadoTest_LT(ByVal ped_id As Integer, ByVal teq_abrvfija As String) As Integer
        'Se consulta el estado de la prueba en la lista de trabajo en funcion de esto se
        'Permitir� actualizar el registro o bloquearlo
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerEstadoTest_LT = 0
        LeerEstadoTest_LT = CInt(New SqlCommand("select lt.lis_resestado from lista_trabajo as lt, test_equipo as te where lt.ped_id = " & ped_id & " and te.teq_abrv_fija = '" & teq_abrvfija & "' and lt.tes_id = te.tes_id ", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer EstadoTest_LT", Err)
        Err.Clear()
    End Function

    Public Sub InsertLista_trabajo(ByVal ped_id As Long, ByVal tes_id As String, ByVal FechaAgenda As String, ByVal genero As Char, ByVal edad As String, ByVal unidad As String, ByVal arre As String)
        'inserta un nuevo registro en la tabla lista_trabajo, con la informacion que se tiene 
        'LISTA_TRABAJO
        On Error GoTo MsgError
        Dim i As Integer
        Dim opr_Conexion As New Cls_Conexion()
        Dim tip_procesa As Byte
        Dim EQU_ID, TIM_ID, TUBO, EQUTIMID As Short
        Dim LIS_ID As Integer

        'g_proceso = "En proceso.."
        g_proceso = ""

        'Determino si la prueba es manual o de equipo
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "Select tes_tproces from TEST WHERE TES_ID = " & tes_id & ";"
        tip_procesa = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        str_sql = "Select isnull(max(LIS_ID),'0') from LISTA_TRABAJO;"
        LIS_ID = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        LIS_ID += 1
        If tip_procesa = 0 Then 'MANUAL
            str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESMANUAL, LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
            "VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(CDate(FechaAgenda), "dd/MM/yyyy HH:mm:ss") & "', " & tes_id & ",'" & g_proceso & "',0,0,0)"
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            opr_Conexion.sql_desconn()
            'CODIGO PARA EMO EN EQUIPO AUTOMATIZADO 
            'If tes_id = 400230 Then
            '    Call InsertResProcesados(ped_id, tes_id)
            'End If
        Else  'AUTOMATICA
            'EN QUE EQUIPO SE PROCESA?
            str_sql = "select equ_id from test_equipo where tes_id = " & tes_id & " and teq_estado = 1;"
            EQU_ID = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)

            str_sql = "SELECT T.TIM_ID, TUB_DEFAULT, TT.TIM_ID FROM TESTEQUIPO_TIPMUESTRA AS TT, TEST_EQUIPO AS TE, TEST AS T " & _
                    "WHERE T.TES_ID = TE.TES_ID And TT.TEQ_ID = TE.TEQ_ID And TE.TES_ID = " & tes_id & " And TEQ_ESTADO = 1 And TIM_DEFAULT = 1;"
            Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
            While oda_operacion.Read
                TIM_ID = oda_operacion.GetValue(0).ToString
                TUBO = oda_operacion.GetValue(1).ToString
                EQUTIMID = oda_operacion.GetValue(2).ToString
            End While
            oda_operacion.Close()

            str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, " & _
            "LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESMANUAL,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
            "VALUES (" & LIS_ID & ", " & ped_id & ", '" & FechaAgenda & "', " & tes_id & "," & EQU_ID & ", " & TIM_ID & "," & TUBO & ", " & EQUTIMID & ",'" & g_proceso & " ',0,0,0);"
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            opr_Conexion.sql_desconn()
            'INSERTA FORMATO EN RESPROCESADOS 
            '401310, 401311, 401312

            'Dim solicitados As String = Nothing
            'Dim arre_test As String()
            'Dim arre_solicitados As String() = Split(arre, "º")

            'For i = 1 To UBound(arre_solicitados) - 1
            '    arre_test = Split(arre_solicitados(i), ",")
            '    'solicitados = solicitados & "tes_id =" & arre_test(i) & " or "
            '    If tes_id = arre_test(0) Then
            '        Call InsertResCutaneas(ped_id, tes_id, genero, edad, unidad)
            '    Else
            '        Call InsertResProcesados(ped_id, tes_id, genero, edad, unidad)
            '    End If
            'Next

            ''solicitados = Mid(solicitados, 1, solicitados.Length - 3)

            If (tes_id = 401310 Or tes_id = 401311 Or tes_id = 401312 Or tes_id = 401321 Or tes_id = 401322 Or tes_id = 401323 Or tes_id = 401324 Or tes_id = 401325) Then
                Call InsertResCutaneas(ped_id, tes_id, genero, edad, unidad)
            Else
                Call InsertResProcesados(ped_id, tes_id, genero, edad, unidad)
            End If

            If tes_id = 400101 Or tes_id = 401097 Then
                Call InsertPtoHistograma(ped_id, System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo"))
            End If

        End If

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, InsertLista_trabajo", )
        Err.Clear()
    End Sub



    Public Sub InsertPtoHistograma(ByVal ped_id As Integer, ByVal his_nombre As String)
        On Error GoTo msgerror
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Insert into ptoHistograma values(" & ped_id & ",'" & his_nombre & "','','','','','','','','','','','','','','','');"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
msgerror:
        MsgBox("No se pudo realizar la operacion solicitada, Graba Histograma", MsgBoxStyle.Exclamation, "ANALISYS")
        Err.Clear()
    End Sub

    Public Sub InsertPtoImg(ByVal ped_id As Integer, ByVal img_nombre As String)
        On Error GoTo msgerror
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Insert into ptoimagen (ped_id, img_nombre) values(" & ped_id & ",'" & img_nombre & "');"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
msgerror:
        MsgBox("No se pudo realizar la operacion solicitada, Graba Img", MsgBoxStyle.Exclamation, "ANALISYS")
        Err.Clear()
    End Sub


    Public Sub InsertPtoPdf(ByVal ped_id As Integer, ByVal tes_nombre As String, ByVal pdf_sec As Integer)
        On Error GoTo msgerror
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Insert into ptopdf (ped_id, pdf_examen, pdf_dwn, pdf_sec) values(" & ped_id & ",'" & tes_nombre & "',0, " & pdf_sec & ");"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
msgerror:
        MsgBox("No se pudo realizar la operacion solicitada inserta Pdf", MsgBoxStyle.Exclamation, "ANALISYS")
        Err.Clear()
    End Sub

    Public Sub EliminaPtoPdf(ByVal ped_id As Integer, ByVal tes_nombre As String)
        On Error GoTo msgerror
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim str_sql As String = "Delete from ptopdf where ped_id = " & ped_id & " and pdf_examen = '" & tes_nombre & "';"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
msgerror:
        MsgBox("No se pudo realizar la operacion elimina Pdf", MsgBoxStyle.Exclamation, "ANALISYS")
        Err.Clear()
    End Sub


    Public Function LeerTieneAbrev(ByVal tes_id As Integer, ByVal genero As String) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String

        opr_Conexion.sql_conectar()
        Dim odr_parametros As SqlDataReader = New SqlCommand("select count(teq_abrv_fija) as ABREV from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = '" & genero & "'", opr_Conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            LeerTieneAbrev = odr_parametros.GetValue(0)
        End While
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer tipo de muestra x Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function



    Public Sub InsertResProcesados(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal genero As Char, ByVal edad As String, ByVal unidad As String) ', ByVal unidad As String, ByVal minimo As Integer, ByVal maximo As Integer)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand
        Dim odc_pedido1 As SqlCommand
        Dim INT_MUESTRA As Integer = 0
        Dim tes_abrev, equipo, sni_nombre, val_defecto As String
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        Dim str_resultados, str_datos(), arregloParam(), arregloIDParam(), arregloID_AB() As String
        Dim x, i As Short
        Dim TIENE_AB_CALC() As String
        Dim ggenero As String = Nothing

        ''''***************************************************************
        'R1 PARTO
        'R2 1-3 DIAS
        'R3 1 SEMANA
        'R4 2 SEMANAS
        'R5 1 MES
        'R6 2 MESES
        'R7 3-6 MESES
        'R8 0.5-2 AÑOS
        'R9 2-6 AÑOS
        '''''*******************************
        Dim entro As Boolean = False

        Select Case unidad
            Case "MESES", "meses"
                If genero = "F" Or genero = "M" Then
                    If (CInt(edad) >= 1 And CInt(edad) <= 12) Then
                        ggenero = "NIÑO"
                    End If
                End If

            Case "DIAS", "dias", "días"

                If genero = "F" Or genero = "M" Then
                    If (CInt(edad) = 0) Then
                        If entro = False Then
                            ggenero = "R1"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 1 And CInt(edad) <= 3) Then
                        If entro = False Then
                            ggenero = "R2"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 4 And CInt(edad) <= 7) Then
                        If entro = False Then
                            ggenero = "R3"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 8 And CInt(edad) <= 14) Then
                        If entro = False Then
                            ggenero = "R4"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 15 And CInt(edad) <= 31) Then
                        If entro = False Then
                            ggenero = "R5"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 32 And CInt(edad) <= 60) Then
                        If entro = False Then
                            ggenero = "R6"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 91 And CInt(edad) <= 180) Then
                        If entro = False Then
                            ggenero = "R7"
                            entro = True
                        End If
                    End If

                    

                    If (CInt(edad) >= 1 And CInt(edad) <= 30) Then
                        If entro = False Then
                            ggenero = "RN"
                            entro = True
                        End If
                    End If
                End If

            Case "años", "AÑOS"
                If genero = "F" Then
                    If (CInt(edad) >= 1 And CInt(edad) < 17) Then
                        ggenero = "NIÑO"
                    End If

                    If (CInt(edad) >= 6 And CInt(edad) <= 110) Then
                        ggenero = "MUJER"
                        entro = True
                    End If

                    'If (CInt(edad) >= 12 And CInt(edad) <= 18) Then
                    '    ggenero = "M1"
                    '    entro = True
                    'End If

                    'If (CInt(edad) >= 19 And CInt(edad) <= 49) Then
                    '    ggenero = "M2"
                    '    entro = True
                    'End If

                    'If (CInt(edad) >= 50 And CInt(edad) <= 110) Then
                    '    ggenero = "MUJER"
                    '    entro = True
                    'End If


                Else
                    If (CInt(edad) >= 1 And CInt(edad) < 17) Then
                        ggenero = "NIÑO"
                    End If

                    If (CInt(edad) >= 17 And CInt(edad) <= 110) Then
                        ggenero = "HOMBRE"
                        entro = True
                    End If

                    'If (CInt(edad) >= 12 And CInt(edad) <= 18) Then
                    '    ggenero = "H1"
                    '    entro = True
                    'End If

                    'If (CInt(edad) >= 19 And CInt(edad) <= 49) Then
                    '    ggenero = "H2"
                    '    entro = True
                    'End If


                    'If (CInt(edad) >= 2 And CInt(edad) <= 6) Then
                    '    If entro = False Then
                    '        ggenero = "R9"
                    '        entro = True
                    '    End If
                    'End If
                    'If (CInt(edad) >= 50 And CInt(edad) <= 110) Then
                    '    ggenero = "HOMBRE"
                    '    entro = True
                    'End If


                End If

        End Select

        

        If LeerTieneAbrev(tes_id, ggenero) >= 1 Then
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = '" & ggenero & "';"
        Else
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = 'HOMBRE';"
        End If

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While oda_operacion.Read
            tes_abrev = Trim(oda_operacion.GetValue(0).ToString)
            equipo = oda_operacion.GetValue(1).ToString
            sni_nombre = oda_operacion.GetValue(2).ToString
            val_defecto = Trim(oda_operacion.GetValue(3).ToString)
        End While
        'valor defecto rfn
        oda_operacion.Close()
        Dim opr_archivo As New Cls_Archivos()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim str_tipo_pac As String
        Dim are_id As Integer
        Dim es_carga As Byte
        Dim nombre_exa As String = Nothing

        INT_MUESTRA = LeerTipoMuestraTest(tes_id)
        are_id = LeerAreaTest(tes_id)
        es_carga = LeerTipoResCarga(tes_id)
        nombre_exa = LeerExamen(tes_id)
        TIENE_AB_CALC = Split(LeerTieneAB(tes_id), ",")



        If TIENE_AB_CALC(0) = 1 Or TieneParametros(tes_id) > 1 Then

            str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '', '', '" & tes_abrev & "', '" & sni_nombre & "',  '" & val_defecto & "', '', '" & val_defecto & "', '', " & INT_MUESTRA & ",'','','" & tes_id & "','','',''," & are_id & ",'')"
            odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()

            arregloIDParam = Split(LeeIdParametros(tes_id, TIENE_AB_CALC(0)), ",")
            'INT_MUESTRA = LeerTipoMuestraTest(arregloIDParam(x))

            For x = 0 To UBound(arregloIDParam) - 1
                arregloParam = Split(LeeParametros(arregloIDParam(x), genero, edad, tes_id, unidad), ",")
                If TieneParametros(tes_id) > 1 Then
                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '', '', '" & arregloParam(0) & "', '" & sni_nombre & "',  '" & arregloParam(3) & "', '', '" & arregloParam(3) & "', '', " & INT_MUESTRA & ",'','','" & tes_id & "','','',''," & are_id & ",'')"
                    str_sql1 = "insert into res_historicos values (" & ped_id & ", '" & arregloParam(0) & "','', " & INT_MUESTRA & ")"
                Else
                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '', '', '" & arregloParam(0) & "', '" & sni_nombre & "',  '" & arregloParam(3) & "', '', '" & arregloParam(3) & "', '', " & INT_MUESTRA & ",'','','" & arregloIDParam(x) & "','','',''," & are_id & ",'')"
                    str_sql1 = "insert into res_historicos values (" & ped_id & ", '" & arregloParam(0) & "','', " & INT_MUESTRA & ")"
                End If

                odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()

                odc_pedido1 = New SqlCommand(str_sql1, opr_conexion.conn_sql)
                odc_pedido1.ExecuteNonQuery()
            Next
        Else
            str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '', '', '" & tes_abrev & "', '" & sni_nombre & "', '" & val_defecto & "', '', '" & val_defecto & "', '', " & INT_MUESTRA & ",'',''," & tes_id & ",'','',''," & are_id & ",'')"
            str_sql1 = "insert into res_historicos values (" & ped_id & ", '" & tes_abrev & "','', " & INT_MUESTRA & ")"
            odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()

            odc_pedido1 = New SqlCommand(str_sql1, opr_conexion.conn_sql)
            odc_pedido1.ExecuteNonQuery()
        End If

        If TIENE_AB_CALC(0) = 1 Then
            arregloID_AB = Split(LeeId_AB(), ",")
            For x = 0 To UBound(arregloID_AB) - 1
                str_sql = "Insert into RESAB_PROCESADOS values (" & ped_id & ", '', '', " & CInt(arregloID_AB(x)) & ", null, " & tes_id & ", " & INT_MUESTRA & ",'','','','');"
                odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Next
        End If


        If es_carga = 1 Then
            opr_trabajo.InsertPtoPdf(ped_id, nombre_exa, 0)
        End If
       
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, InsertResProcesados", Err)
        Err.Clear()
    End Sub




    Public Sub InsertResCutaneas(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal genero As Char, ByVal edad As String, ByVal unidad As String)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand
        Dim odc_pedido1 As SqlCommand
        Dim INT_MUESTRA As Integer = 0
        Dim tes_abrev, equipo, sni_nombre, val_defecto, val_interp As String
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        Dim str_resultados, str_datos(), arregloParam(), arregloIDParam(), arregloID_AB() As String
        Dim x, i As Short
        Dim ggenero As String = Nothing

        ''''***************************************************************
        'R1 PARTO
        'R2 1-3 DIAS
        'R3 1 SEMANA
        'R4 2 SEMANAS
        'R5 1 MES
        'R6 2 MESES
        'R7 3-6 MESES
        'R8 0.5-2 AÑOS
        'R9 2-6 AÑOS
        '''''*******************************
        Dim entro As Boolean = False

        Select Case unidad
            Case "MESES", "meses"
                If genero = "F" Or genero = "M" Then
                    If (CInt(edad) >= 1 And CInt(edad) <= 12) Then
                        ggenero = "NIÑO"
                    End If
                End If

            Case "DIAS", "dias", "días"

                If genero = "F" Or genero = "M" Then
                    If (CInt(edad) = 0) Then
                        If entro = False Then
                            ggenero = "R1"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 1 And CInt(edad) <= 3) Then
                        If entro = False Then
                            ggenero = "R2"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 4 And CInt(edad) <= 7) Then
                        If entro = False Then
                            ggenero = "R3"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 8 And CInt(edad) <= 14) Then
                        If entro = False Then
                            ggenero = "R4"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 15 And CInt(edad) <= 31) Then
                        If entro = False Then
                            ggenero = "R5"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 32 And CInt(edad) <= 60) Then
                        If entro = False Then
                            ggenero = "R6"
                            entro = True
                        End If
                    End If

                    If (CInt(edad) >= 0 And CInt(edad) <= 30) Then
                        If entro = False Then
                            ggenero = "RN"
                            entro = True
                        End If
                    End If
                End If

            Case "años", "AÑOS"
                If genero = "F" Then
                    If (CInt(edad) >= 1 And CInt(edad) < 6) Then
                        ggenero = "NIÑO"
                    End If

                    If (CInt(edad) >= 6 And CInt(edad) <= 11) Then
                        ggenero = "MUJER"
                        entro = True
                    End If

                    If (CInt(edad) >= 12 And CInt(edad) <= 18) Then
                        ggenero = "M1"
                        entro = True
                    End If

                    If (CInt(edad) >= 19 And CInt(edad) <= 49) Then
                        ggenero = "M2"
                        entro = True
                    End If

                    If (CInt(edad) >= 50 And CInt(edad) <= 110) Then
                        ggenero = "MUJER"
                        entro = True
                    End If
                Else
                    If (CInt(edad) >= 1 And CInt(edad) < 6) Then
                        ggenero = "NIÑO"
                    End If

                    If (CInt(edad) >= 6 And CInt(edad) <= 11) Then
                        ggenero = "HOMBRE"
                        entro = True
                    End If

                    If (CInt(edad) >= 12 And CInt(edad) <= 18) Then
                        ggenero = "H1"
                        entro = True
                    End If

                    If (CInt(edad) >= 19 And CInt(edad) <= 49) Then
                        ggenero = "H2"
                        entro = True
                    End If

                    If (CInt(edad) >= 50 And CInt(edad) <= 110) Then
                        ggenero = "HOMBRE"
                        entro = True
                    End If
                End If

        End Select



        If LeerTieneAbrev(tes_id, ggenero) >= 1 Then
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = '" & ggenero & "';"
        Else
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = 'HOMBRE';"
        End If

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While oda_operacion.Read
            tes_abrev = Trim(oda_operacion.GetValue(0).ToString)
            equipo = oda_operacion.GetValue(1).ToString
            sni_nombre = oda_operacion.GetValue(2).ToString
            val_defecto = Trim(oda_operacion.GetValue(3).ToString)
        End While
        'valor defecto rfn
        oda_operacion.Close()
        Dim opr_archivo As New Cls_Archivos()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim str_tipo_pac As String
        Dim are_id As Integer
        Dim es_carga As Byte
        Dim nombre_exa As String = Nothing

        INT_MUESTRA = LeerTipoMuestraTest(tes_id)
        are_id = LeerAreaTest(tes_id)
        es_carga = LeerTipoResCarga(tes_id)
        nombre_exa = LeerExamen(tes_id)



        If TieneParametros(tes_id) > 1 Then
            str_sql = "Insert into RES_CUTANEAS values (" & ped_id & ", '', '', '" & tes_abrev & "', '" & val_defecto & "',  '" & val_interp & "','','', " & INT_MUESTRA & ",'', '" & tes_id & "',''," & are_id & ",0)"
            odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()

            arregloIDParam = Split(LeeIdParametros(tes_id, 0), ",")
            'INT_MUESTRA = LeerTipoMuestraTest(arregloIDParam(x))
            For x = 0 To UBound(arregloIDParam) - 1

                arregloParam = Split(LeeParametros(arregloIDParam(x), genero, edad, tes_id, unidad), ",")
                If TieneParametros(tes_id) > 1 Then
                    str_sql = "Insert into RES_CUTANEAS values (" & ped_id & ", '', '', '" & arregloParam(0) & "', '" & val_defecto & "',  '" & arregloParam(3) & "','','', " & INT_MUESTRA & ",'','" & tes_id & "',''," & are_id & ",0)"
                    'str_sql1 = "insert into res_historicos values (" & ped_id & ", '" & arregloParam(0) & "','', " & INT_MUESTRA & ")"
                Else
                    str_sql = "Insert into RES_CUTANEAS values (" & ped_id & ", '', '', '" & arregloParam(0) & "', '" & val_defecto & "',  '" & arregloParam(3) & "','','', " & INT_MUESTRA & ",'','" & arregloIDParam(x) & "',''," & are_id & ",0)"
                    'str_sql1 = "insert into res_historicos values (" & ped_id & ", '" & arregloParam(0) & "','', " & INT_MUESTRA & ")"
                End If

                odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()

                'odc_pedido1 = New SqlCommand(str_sql1, opr_conexion.conn_sql)
                'odc_pedido1.ExecuteNonQuery()
            Next
        Else
            'str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '', '', '" & tes_abrev & "', '" & val_defecto & "', '" & val_interp & "',  " & INT_MUESTRA & ",''," & tes_id & ",'','',''," & are_id & ")"
            'str_sql1 = "insert into res_historicos values (" & ped_id & ", '" & tes_abrev & "','', " & INT_MUESTRA & ")"
            'odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
            'odc_pedido.ExecuteNonQuery()

            'odc_pedido1 = New SqlCommand(str_sql1, opr_conexion.conn_sql)
            'odc_pedido1.ExecuteNonQuery()
        End If



        If es_carga = 1 Then
            opr_trabajo.InsertPtoPdf(ped_id, nombre_exa, 0)
        End If

        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, InsertResProcesados", Err)
        Err.Clear()
    End Sub


    Public Function consultaClasificacion(ByVal genero As String, ByVal edad As Integer, ByVal unidad As String) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = Nothing

        Select Case genero
            Case "M" : genero = "HOMBRE"
            Case "F" : genero = "MUJER"
        End Select

        str_sql = "SELECT tip_grupo, tip_minimo, tip_maximo FROM RANGO_EDADES " & _
                "WHERE TIP_GENERO = 'AMBOS' " & _
                "and tip_unidad = '" & unidad & "' and tip_estado = 1"

        opr_Conexion.sql_conectar()
        Dim odr_parametros1 As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        While odr_parametros1.Read
            consultaClasificacion = consultaClasificacion & odr_parametros1.GetString(0) & "," & odr_parametros1.GetValue(1) & "," & odr_parametros1.GetValue(2) & ""
        End While
        opr_Conexion.sql_desconn()


        If consultaClasificacion = "" Then
            str_sql = "SELECT tip_grupo, tip_minimo, tip_maximo FROM RANGO_EDADES " & _
                    "WHERE TIP_GENERO = '" & genero & "' " & _
                    "and tip_unidad = '" & unidad & "' and tip_estado = 1 "

            opr_Conexion.sql_conectar()
            Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
            While odr_parametros.Read
                consultaClasificacion = consultaClasificacion & odr_parametros.GetString(0) & "," & odr_parametros.GetValue(1) & "," & odr_parametros.GetValue(2) & ""
            End While
            opr_Conexion.sql_desconn()


        End If


        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer rangos edades", Err)
        Err.Clear()
    End Function


    Public Function LeerTieneAB(ByVal tes_id As Integer) As String
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        Dim odr_parametros As SqlDataReader = New SqlCommand("Select TEST.TES_AB, TEST.TES_CALC from TEST WHERE TES_ID = " & tes_id, opr_Conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            LeerTieneAB = odr_parametros.GetValue(0) & "," & odr_parametros.GetValue(1)
        End While
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer tipo de muestra x Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function

    Public Function LeerTipoMuestraTest(ByVal tes_id As Integer) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerTipoMuestraTest = CInt(New SqlCommand("Select isnull(max(tim_id),0) from TEST WHERE TES_ID = " & tes_id & "", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer tipo de muestra x Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function

    Public Function LeerTipoResCarga(ByVal tes_id As Integer) As Byte
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerTipoResCarga = CInt(New SqlCommand("select res_id from test_resultado where TES_ID = " & tes_id & "", opr_Conexion.conn_sql).ExecuteScalar)
        If LeerTipoResCarga = 1 Then
            LeerTipoResCarga = 1
        Else
            LeerTipoResCarga = 0
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer AREA Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function


    Public Function LeerAreaTest(ByVal tes_id As Integer) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerAreaTest = CInt(New SqlCommand("Select are_id from TEST WHERE TES_ID = " & tes_id & "", opr_Conexion.conn_sql).ExecuteScalar)

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer AREA Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function


    Public Function LeerExamen(ByVal tes_id As Integer) As String
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerExamen = New SqlCommand("Select tes_nombre from TEST WHERE TES_ID = " & tes_id & "", opr_Conexion.conn_sql).ExecuteScalar

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer AREA Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function


    Public Sub CambioEstadoEnviadoMIS(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal estado_anterior As Single, ByVal estado_nuevo As Single)
        '18-06-2003
        'Los estados posibles de la lista de trabajo son:
        '0 : no procesado, 
        '1 :procesado
        '2 :validado
        '3 :enviado al equipo 
        '4 :error al suboir datos al equipo
        '6 :Procesado para enviar MIS 
        '7 :Enviado MIS
        '8 :Procesado por MIS/Detectaron Errores
        Dim opr_conexion As New Cls_Conexion()
        'Dim sql_trans As SqlTransaction

        Try
            opr_conexion.sql_conectar()
            Dim str_sql As String = "update lista_trabajo set lis_resestado=" & estado_nuevo & " where ped_id=" & ped_id & " and (lis_resestado = " & estado_anterior & " or lis_resestado = 8 ) and tes_id = " & tes_id & ""
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            'sql_trans.Commit()
        Catch
            'sql_trans.Rollback()
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Cambio Estado Item Enviado MIS", Err)
            Err.Clear()
        Finally
            opr_conexion.sql_desconn()
        End Try
    End Sub



End Class