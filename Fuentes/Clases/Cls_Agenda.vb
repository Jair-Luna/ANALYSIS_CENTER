'*************************************************************************
' Nombre:   Cls_Agenda
' Tipo de Archivo: Clase
' Descripción:  Clase para manipular los archivos de respuestas bajados de los analizadores (SNI)
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.IO
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient

Public Class Cls_Agenda

    Dim opr_conexion As New Cls_Conexion()


    Function LlenarGridActividad(ByRef dgv_Actividad As DataGridView, ByVal med_id As Integer, ByVal periodo As String, ByRef dtt_Actividad As DataTable) As Boolean
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()
        LlenarGridActividad = False
        str_sql = "SELECT aact_id, aact_tipo, aact_fechaIni, aact_fechaFin, aact_Hora, aact_Hora_agenda " & _
                "FROM agendaActividad " & _
                "where agendaActividad.med_id = " & med_id & " and aact_hora = '" & periodo & "'" & _
                "order by aact_fechaIni asc;"

        Dim odr_Actividad As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_Actividad.Read
            dtr_fila = dtt_Actividad.NewRow
            dtr_fila(0) = odr_Actividad.Item(0)
            dtr_fila(1) = odr_Actividad.Item(1)
            dtr_fila(2) = odr_Actividad.Item(2)
            dtr_fila(3) = odr_Actividad.Item(3)
            dtr_fila(4) = odr_Actividad.Item(4)
            dtr_fila(5) = odr_Actividad.Item(5)
            dtt_Actividad.Rows.Add(dtr_fila)
            LlenarGridActividad = True
        End While
        dgv_Actividad.DataSource = dtt_Actividad
        odr_Actividad.Close()

        opr_conexion.sql_desconn()


        Exit Function
        LlenarGridActividad = False
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Function


    Public Function GestionaActividad(ByVal aact_id As Integer, ByVal aact_tipo As String, ByVal acct_FechaIni As String, ByVal acct_FechaFin As String, ByVal med_id As Integer, ByVal acct_hora As String, ByVal TipoTx As String, ByVal acct_hora_agenda As String, ByVal acct_hora_reloj As String) As Boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim i As Integer

        GestionaActividad = False
        opr_Conexion.sql_conectar()

        Select Case TipoTx
            Case "Eliminar"
                STR_SQL = "delete from agendaActividad where aact_id = " & aact_id & ";"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()

            Case "Insertar"
                STR_SQL = "insert into agendaActividad values(" & aact_id & ", 'RESERVADA', '" & aact_tipo & "', '" & acct_FechaIni & "', '" & acct_FechaFin & "', '" & acct_hora & "', " & med_id & ", '" & acct_hora_agenda & "', '" & acct_hora_reloj & "')"
        End Select


        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        GestionaActividad = True
        Exit Function

MsgError:
        GestionaActividad = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, actualiza consultas CI10.", Err)
        Err.Clear()

    End Function


    Public Function DevuelveLunesSemana(ByVal fechaHoy As DateTime, ByVal NumdiaHoy As Integer) As DateTime
        Dim dias() As Integer = {5, 6, 0, 1, 2, 3, 4}
        Return fechaHoy.Subtract(New TimeSpan(dias(NumdiaHoy), 0, 0, 0))
    End Function


    Public Function DevuelveUltimoDiaMes(ByVal fechaHoy As DateTime) As DateTime

        DevuelveUltimoDiaMes = New DateTime(fechaHoy.Year, fechaHoy.Month, DateTime.DaysInMonth(fechaHoy.Year, fechaHoy.Month))

    End Function

    Sub LlenarGridAgenda(ByRef data As DataView, ByVal fecha As String, ByVal tipo As String)
        'llena un datagrid con los datos de los test
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerAgenda(fecha, tipo).Tables("Registros")
    End Sub

    Public Function LeerCalendario(ByVal tipo As String, ByVal med_id As Integer) As String
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim retorno As String = Nothing
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select calendario.cal_hora AS HORA from calendario where calendario.cal_tipo  = '" & tipo & "' and med_id = " & med_id & " order by calendario.cal_id;"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            retorno = retorno & oda_operacion.GetValue(0).ToString & ","
        End While

        LeerCalendario = retorno
        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Calendario medico", Err)
        Err.Clear()
    End Function

    Public Function LeerDias(ByVal tipo As String, ByVal med_id As Integer) As String
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim retorno As String = Nothing
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select med_dias from medico where med_id =" & med_id & ";"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            retorno = Trim(oda_operacion.GetValue(0).ToString)
        End While

        LeerDias = retorno
        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Dias medico", Err)
        Err.Clear()
    End Function

    Public Function LeerAgenda(ByVal fecha As String, ByVal tipo As String) As DataSet
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim str_sql As String = "select agenda.age_id, agenda.age_hora, agenda.age_fecha , agenda.pac_id , agenda.med_id , agenda.ped_id, agenda.age_resumen from agenda where agenda.age_fecha = '" & fecha & "' and age_tipo = '" & tipo & "';"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerAgenda = New DataSet("AGENDA")
        dt_operacion.Fill(LeerAgenda, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Agenda", Err)
        Err.Clear()
    End Function


    Public Function ExisteHistClinica(ByVal pac_id As Integer) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select count(hic_id) from historiaClinica where pac_id = " & pac_id & ";"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteHistClinica = CInt(oda_operacion.GetValue(0).ToString)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Historia Clinica", Err)
        Err.Clear()
    End Function


    Public Function ExisteAgenda(ByVal fecha As String, ByVal tipo As String, ByVal med_id As Integer) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select count(agenda.age_hora) from agenda where agenda.age_fecha = '" & fecha & "' and age_tipo = '" & tipo & "' and med_id = " & med_id & ";"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteAgenda = CInt(oda_operacion.GetValue(0).ToString)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Agenda", Err)
        Err.Clear()
    End Function


    Public Function ExisteHistorico(ByVal hic_id As Integer) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select count(hic_fecha) from historiaclinicaCambios where hic_id = " & hic_id & ";"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteHistorico = CInt(oda_operacion.GetValue(0).ToString)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Historico", Err)
        Err.Clear()
    End Function

    Public Function ExisteAgendaActividad(ByVal fecha As String, ByVal tipo As String, ByVal med_id As Integer, ByRef motivo As String, ByVal hora_agenda As String) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql, str_sql2 As String

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Select Case tipo
            Case "MES"
                str_sql = "select count(agendaActividad.aact_descripcion) as Actividad from agendaActividad where agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_hora_agenda = '" & hora_agenda & "' and agendaActividad.aact_descripcion = 'RESERVADA';"
                str_sql2 = "select agendaActividad.aact_tipo from agendaActividad where agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_hora_agenda = '" & hora_agenda & "';"

            Case "DIA"
                str_sql = "select count(agendaActividad.aact_descripcion) as Actividad from agendaActividad where agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_hora_agenda = '" & hora_agenda & "' and agendaActividad.aact_descripcion = 'RESERVADA';"
                str_sql2 = "select agendaActividad.aact_tipo from agendaActividad where agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_hora_agenda = '" & hora_agenda & "';"

            Case "HORA"
                str_sql = "select count(agendaActividad.aact_descripcion) as Actividad from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_descripcion = 'RESERVADA';"
                str_sql2 = "select agendaActividad.aact_tipo from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & ";"
        End Select


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteAgendaActividad = CInt(oda_operacion.GetValue(0).ToString)
        End While
        oda_operacion.Close()


        If ExisteAgendaActividad > 0 Then
            Dim oda_operacion2 As SqlDataReader = New SqlCommand(str_sql2, cls_operacion.conn_sql).ExecuteReader
            While oda_operacion2.Read
                motivo = oda_operacion2.GetValue(0).ToString
            End While
            oda_operacion2.Close()
        End If


        cls_operacion.sql_desconn()


        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Agenda", Err)
        Err.Clear()
    End Function


    Public Function ExisteActividad(ByVal fecha As String, ByVal hora As String, ByVal tipo As String, ByVal med_id As Integer, ByVal hora_act As String, ByRef motivo As String) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql, str_sql2 As String
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        motivo = ""
        Select Case tipo

            Case "HORA"
                str_sql = "select count(agendaActividad.aact_hora_agenda) as Actividad from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " AND aact_hora_agenda = '" & hora_act & "' and agendaActividad.aact_descripcion = 'RESERVADA';"
                str_sql2 = "select agendaActividad.aact_tipo from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " AND aact_hora_agenda = '" & hora_act & "';"

            Case "DIA"
                str_sql = "select count(agendaActividad.aact_hora_agenda) as Actividad from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_fechaFin  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_descripcion = 'RESERVADA';"
                str_sql2 = "select agendaActividad.aact_tipo from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_fechaFin  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & ";"

            Case "MES"
                str_sql = "select count(agendaActividad.aact_hora_agenda) as Actividad from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_descripcion = 'RESERVADA';"
                str_sql2 = "select agendaActividad.aact_tipo from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & ";"

        End Select


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteActividad = oda_operacion.GetValue(0)
        End While
        oda_operacion.Close()

        Select Case tipo
            Case "MES", "HORA", "DIA"
                If ExisteActividad > 0 Then
                    Dim oda_operacion2 As SqlDataReader = New SqlCommand(str_sql2, cls_operacion.conn_sql).ExecuteReader
                    While oda_operacion2.Read
                        motivo = oda_operacion2.GetValue(0).ToString
                    End While
                    oda_operacion2.Close()
                End If

                ' ''Case "DIA"
                ' ''    If ExisteHoraActividad > 0 Then
                ' ''        Dim oda_operacion2 As SqlDataReader = New SqlCommand(str_sql2, cls_operacion.conn_sql).ExecuteReader
                ' ''        While oda_operacion2.Read
                ' ''            motivo = motivo & oda_operacion2.GetValue(0).ToString & ", "
                ' ''        End While
                ' ''        oda_operacion2.Close()
                ' ''    End If
        End Select
        cls_operacion.sql_desconn()


        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Agenda", Err)
        Err.Clear()
    End Function



    Public Function ExisteHoraActividadString(ByVal fecha As String, ByVal hora As String, ByVal tipo As String, ByVal med_id As Integer, ByRef motivo As String) As String
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql, str_sql2 As String
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        motivo = ""
        Select Case tipo
            Case "MES"
                str_sql = "select agendaActividad.aact_hora_agenda as Actividad from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & " and agendaActividad.aact_descripcion = 'RESERVADA';"
                str_sql2 = "select agendaActividad.aact_tipo from agendaActividad where agendaActividad.aact_fechaIni  = '" & fecha & "' and agendaActividad.aact_hora  = '" & tipo & "' and med_id = " & med_id & ";"

            Case "HORA"
                str_sql = "select count(age_id) from agenda where med_id = " & med_id & " and age_fecha = '" & fecha & " 00:00:00' and age_hora = '" & hora & "' and PAC_ID <> 0;"
                str_sql2 = "select age_id from agenda where med_id = " & med_id & " and age_fecha = '" & fecha & " 00:00:00' and age_hora = '" & hora & "' and PAC_ID = 0;"

        End Select


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteHoraActividadString = oda_operacion.GetValue(0).ToString
        End While
        oda_operacion.Close()

        Select Case tipo
            Case "MES"
                If ExisteHoraActividadString > "" Then
                    Dim oda_operacion2 As SqlDataReader = New SqlCommand(str_sql2, cls_operacion.conn_sql).ExecuteReader
                    While oda_operacion2.Read
                        motivo = oda_operacion2.GetValue(0).ToString
                    End While
                    oda_operacion2.Close()
                End If
            Case "HORA"
                If ExisteHoraActividadString = "0" Then
                    Dim oda_operacion2 As SqlDataReader = New SqlCommand(str_sql2, cls_operacion.conn_sql).ExecuteReader
                    While oda_operacion2.Read
                        motivo = oda_operacion2.GetValue(0)
                    End While
                    oda_operacion2.Close()
                End If


        End Select
        cls_operacion.sql_desconn()


        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Agenda", Err)
        Err.Clear()
    End Function


    Public Function ExisteAgenda(ByVal fecha As String, ByVal tipo As String, ByVal med_id As Integer, ByVal hora As String) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select count(agenda.age_hora) from agenda where agenda.age_hora = '" & hora & "' and agenda.age_fecha = '" & fecha & "' and age_tipo = 'Medico' and med_id = " & med_id & ";"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteAgenda = CInt(oda_operacion.GetValue(0).ToString)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Agenda", Err)
        Err.Clear()
    End Function


    Public Function ExisteAgendaS(ByVal fecha As String, ByVal tipo As String, ByVal med_id As Integer, ByVal hora As String, ByRef retorna_hora As String, ByRef retorna_Age_Id As Integer) As String
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim str_sql, str_sql2, str_sql3 As String

        Select Case tipo
            Case "DIA"
                str_sql = "select count(agenda.age_hora) from agenda where agenda.age_fecha = '" & fecha & "' and age_tipo = 'Medico' and med_id = " & med_id & ";"
                str_sql2 = "select agenda.age_hora from agenda where agenda.age_hora = '" & hora & "' and agenda.age_fecha = '" & fecha & "' and age_tipo = 'Medico' and med_id = " & med_id & ";"
                str_sql3 = "select agenda.age_id from agenda where agenda.age_hora = '" & hora & "' and agenda.age_fecha = '" & fecha & "' and age_tipo = 'Medico' and med_id = " & med_id & ";"

            Case Else
                str_sql = "select count(agenda.age_hora) from agenda where agenda.age_hora = '" & hora & "' and agenda.age_fecha = '" & fecha & "' and age_tipo = 'Medico' and med_id = " & med_id & ";"
                str_sql2 = "select agenda.age_hora from agenda where agenda.age_hora = '" & hora & "' and agenda.age_fecha = '" & fecha & "' and age_tipo = 'Medico' and med_id = " & med_id & ";"
                str_sql3 = "select agenda.age_id from agenda where agenda.age_hora = '" & hora & "' and agenda.age_fecha = '" & fecha & "' and age_tipo = 'Medico' and med_id = " & med_id & ";"
        End Select

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteAgendaS = oda_operacion.GetValue(0).ToString
        End While

        oda_operacion.Close()

        If ExisteAgendaS > 0 Then
            Dim oda_operacion2 As SqlDataReader = New SqlCommand(str_sql2, cls_operacion.conn_sql).ExecuteReader
            While oda_operacion2.Read
                ExisteAgendaS = oda_operacion2.GetValue(0).ToString
            End While
            oda_operacion2.Close()

            Dim oda_operacion3 As SqlDataReader = New SqlCommand(str_sql3, cls_operacion.conn_sql).ExecuteReader
            While oda_operacion3.Read
                retorna_Age_Id = CInt(oda_operacion3.GetValue(0))
            End While
            oda_operacion3.Close()
        End If

        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe Agenda", Err)
        Err.Clear()
    End Function


    Public Function ExisteAgendaHora(ByVal fecha As String, ByVal hora As String, ByVal tipo As String, ByVal med_id As Integer) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select count(agenda.PAC_ID) from agenda where agenda.age_fecha = '" & fecha & "' and agenda.age_hora = '" & hora & "' and age_tipo = '" & tipo & "' and med_id = " & med_id & " AND PAC_ID <> 0;"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteAgendaHora = CInt(oda_operacion.GetValue(0).ToString)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe agernda Hora", Err)
        Err.Clear()
    End Function

    Public Function LeeMaximoAgenda() As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select isnull(Max(age_id),0) from agenda"


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            LeeMaximoAgenda = oda_operacion.GetValue(0)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Lee maximo agenda", Err)
        Err.Clear()
    End Function

    Public Function LeeMaximoCertAbierto() As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select isnull(Max(CERP_ID),0) from certificadoPaciente"


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            LeeMaximoCertAbierto = oda_operacion.GetValue(0)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Lee maximo agenda", Err)
        Err.Clear()
    End Function


    Public Function BuscaExamenesSolicita(ByVal tes_cal As Byte, ByVal con_nombre As String) As String
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select t.tes_id, t.tes_nombre, lp.LIP_PRECIO " & _
                            "from test as t, lista_precio as lp " & _
                            "where t.TES_CALC = 1 and t.TES_TIPO <> 'Parametro' and lp.CON_NOMBRE = '" & con_nombre & "' and lp.TES_ID = t.tes_id order by t.tes_id asc "


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            BuscaExamenesSolicita = BuscaExamenesSolicita & oda_operacion.GetValue(0) & "," & oda_operacion.GetValue(1) & "," & oda_operacion.GetValue(2) & "º"
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Lee maximo agenda", Err)
        Err.Clear()
    End Function


    Public Function LeeMaximoCalendario() As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select isnull(Max(cal_id),0) from calendario"


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            LeeMaximoCalendario = oda_operacion.GetValue(0) + 1
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Lee maximo agenda", Err)
        Err.Clear()
    End Function


    Public Function LeeMaximoActividad() As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select isnull(Max(aact_id),0) from agendaActividad"


        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            LeeMaximoActividad = oda_operacion.GetValue(0) + 1
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Lee maximo LeeMaximoActividad", Err)
        Err.Clear()
    End Function

    Public Function ExisteAgendaHoras(ByVal fecha As String, ByVal horaDesde As String, ByVal horaHasta As String) As Integer
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select count(agenda.age_hora) from agenda where agenda.age_fecha = '" & fecha & "' and agenda.age_hora between '" & horaDesde & "' and '" & horaHasta & "' and agenda.age_resumen <> '';"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ExisteAgendaHoras = CInt(oda_operacion.GetValue(0).ToString)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe agernda Hora", Err)
        Err.Clear()
    End Function

    Public Function ConsultaAgendaResumen(ByVal fecha As String, ByVal horaDesde As String, ByVal horaHasta As String) As String
        'Funcion para la consultar los datos de la tabla TEST
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim str_sql As String = "select agenda.age_resumen from agenda where agenda.age_fecha = '" & fecha & "' and agenda.age_hora between '" & horaDesde & "' and '" & horaHasta & "' and agenda.age_resumen <> '';"

        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            ConsultaAgendaResumen = (oda_operacion.GetString(0).ToString)
        End While

        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Existe agernda Hora", Err)
        Err.Clear()
    End Function


    Public Sub CreaAgenda(ByVal age_id As Integer, ByVal fecha As String, ByVal hora As String, ByVal tipo As String, ByVal med_id As Integer, ByVal descripcion As String, ByVal resumen As String)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing
        'If resumen <> "" Then
        STR_SQL = "Insert into AGENDA values (" & age_id & ", '" & hora & "', '" & fecha & "', 0, " & med_id & ", 0    , '" & resumen & "','','" & tipo & "','','','','" & descripcion & "',0,0);"
        'Else
        'STR_SQL = "Insert into AGENDA values (" & age_id & ", '" & hora & "', '" & fecha & "', 0, " & med_id & ", 0    , '','','" & tipo & "','','','','" & descripcion & "',0);"
        'End If
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub

    Public Sub ModificaAgenda(ByVal age_id As Integer, ByVal fecha As String, ByVal hora As String, ByVal tipo As String, ByVal med_id As Integer, ByVal descripcion As String, ByVal resumen As String)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing
        Select Case tipo
            Case "DIA"
                STR_SQL = "Update AGENDA set AGE_ESTADO = '" & descripcion & "', AGE_RESUMEN = '" & resumen & "' where AGE_ID = " & age_id & " and MED_ID = " & med_id & ";"

            Case "HORA"
                STR_SQL = "Update AGENDA set AGE_ESTADO = '" & descripcion & "', AGE_RESUMEN = '" & resumen & "' where AGE_ID = " & age_id & " and MED_ID = " & med_id & " and age_hora = '" & hora & "';"

            Case "MES"
                STR_SQL = "Update AGENDA set AGE_ESTADO = '" & descripcion & "', AGE_RESUMEN = '" & resumen & "' where AGE_ID = " & age_id & " and MED_ID = " & med_id & " and age_hora = '" & hora & "';"
        End Select


        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Modifica Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub


    Public Sub CreaAgendaActividad(ByVal age_id As Integer, ByVal fecha As String, ByVal hora As String, ByVal tipo As String, ByVal med_id As Integer, ByVal resumen As String)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing
        STR_SQL = "Insert into AGENDA values (" & age_id & ", '" & hora & "', '" & fecha & "', 0, " & med_id & ", 0    , '" & resumen & "','','" & tipo & "','','','','RESERVADA',0);"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub


    Public Sub InsertaAgenda(ByVal age_id As Integer, ByVal fecha As String, ByVal hora As String, ByVal ped_id As Integer, ByVal pac_id As Integer, ByVal tipo As String, ByVal med_id As Integer, ByRef SiNoGuardo As Boolean)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing
        STR_SQL = "Insert into AGENDA values (" & age_id & ", '" & hora & "', '" & fecha & "', " & pac_id & ", " & med_id & ", " & ped_id & ", '','','" & tipo & "');"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        SiNoGuardo = True
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        SiNoGuardo = False
        Err.Clear()
    End Sub

    Public Sub CreaCalendario(ByVal cal_id As Integer, ByVal totalHoras As Integer, ByVal horaIni As Date, ByVal intervalo As Integer, ByVal tipo As String, ByVal med_id As Integer)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        Dim i As Integer
        Dim STR_SQL As String
        Dim horaReg As Date

        On Error GoTo MsgError
        opr_Conexion.sql_conectar()

        For i = 0 To totalHoras


            STR_SQL = "Insert into CALENDARIO values (" & cal_id & ", '" & Format(horaIni, "HH:mm") & "', '" & tipo & "'," & med_id & ");"
            Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            horaIni = Format(DateAdd(DateInterval.Minute, intervalo, CDate(horaIni)), "HH:mm")
            cal_id = cal_id + 1
            
        Next

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Calendario, Cls_Agenda", Err)
        Err.Clear()
    End Sub


    Public Sub EliminaCalendario(ByVal tipo As String, ByVal med_id As Integer)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        Dim i As Integer
        Dim STR_SQL As String
        Dim horaReg As Date

        On Error GoTo MsgError
        opr_Conexion.sql_conectar()

        

        STR_SQL = "delete from CALENDARIO where cal_tipo = '" & tipo & "' and med_id = " & med_id & ""
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Eliminar calendario, Cls_Agenda", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizaCertificado(ByVal age_id As Integer, ByVal pac_id As Integer, ByVal ped_id As Integer, ByVal cer_id As Integer, ByVal cer_fecha As Date, ByVal cer_tutor As String, ByVal cer_ci As String, ByVal Txtipo As String, ByRef SiNoGuardo As Boolean)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing

        STR_SQL = "update Agenda set cer_id = '" & cer_id & "', cer_fecha = '" & cer_fecha & "', cer_tutor = '" & cer_tutor & "' , cer_ci = '" & cer_ci & "' where age_id = '" & age_id & "' and pac_id = " & pac_id & ";"


        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        SiNoGuardo = True
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub

    
    Public Sub ModificaAgendaHora(ByVal age_id As Integer, ByVal ped_id As Integer, ByVal pac_id As Integer, ByVal med_id As Integer, ByVal pac_edad As String, ByVal resumen As String, ByVal cer_str As String, ByVal age_tutor As String, ByVal age_ci As String, ByVal age_estado As String, ByVal ped_turno As Integer, ByRef SiNoGuardo As Boolean)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing

        STR_SQL = "update AGENDA set pac_id = " & pac_id & ", med_id = " & med_id & ", pac_edad = '" & pac_edad & "' , ped_id = " & ped_id & ", age_resumen = '" & resumen & "', CER_STR = '" & cer_str & "', age_tutor = '" & age_tutor & "', age_ci = '" & age_ci & "', age_estado = '" & age_estado & "', ped_turno = " & ped_turno & " where age_id = '" & age_id & "';"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        SiNoGuardo = True
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub


    Public Sub GestionaCertAbierto(ByVal CERP_ID As Integer, ByVal Age_id As Integer, ByVal titulo As String, ByVal cuerpo As String, ByVal tipo As String, ByRef SiNoGuardo As Boolean)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing

        Select Case tipo
            Case "Insert"
                STR_SQL = "insert into certificadoPaciente values (" & CERP_ID & ", '" & titulo & "', '" & cuerpo & "' , GetDate() ," & Age_id & ");"
            Case "Update"
                STR_SQL = "Update certificadoPaciente set CERP_TITULO = '" & titulo & "', CERP_CUERPO = '" & cuerpo & "', CERP_FECHA =  '" & Format(Now(), "dd/MM/yyyy") & "', AGE_ID = " & Age_id & ""
        End Select

        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        SiNoGuardo = True
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub



    Public Sub ModificaAgendaActividad(ByVal age_fecha As String, ByVal med_id As Integer, ByVal estado As String, ByVal resumen As String, ByRef SiNoGuardo As Boolean)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL As String = Nothing
        STR_SQL = "update AGENDA set age_estado = '" & estado & "', age_resumen = '" & resumen & "' where med_id = " & med_id & " and age_fecha = '" & age_fecha & "';"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        SiNoGuardo = True
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub

    Public Sub CreaAgendaHora(ByVal fecha As String, ByVal hora As String, ByVal pac_id As Integer, ByVal med_id As Integer, ByVal ped_id As Integer, ByVal resumen As String)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL = "Insert into AGENDA values ('" & hora & "', '" & fecha & "', " & pac_id & ", " & med_id & ", " & ped_id & ", '" & resumen & "');"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Crear Agenda, Cls_Agenda", Err)
        Err.Clear()
    End Sub

End Class
