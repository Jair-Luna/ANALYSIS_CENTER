Imports System.Globalization

Public Class frm_Actividad
    Public med_id As Integer
    Dim opr_medico As New Cls_Medico()
    Dim opr_agenda As New Cls_Agenda()
    Dim opr_pedido As New Cls_Pedido()
    Public frm_refer_main As Frm_Main
    Public fechaSeleccionadaCal As DateTime
    Dim diaDeLaSemana As DayOfWeek
    Dim calendario As String()
    Dim EscojeTipo As String
    Dim MesDia As Integer
    Dim motivo As String
    Dim sinoguardo As Boolean
    Private WithEvents dtt_actividad As New DataTable("Registros")
    Dim retorna_hora, retorna_Age_id As String



    Public Sub AjustaMesAnioCalendario(ByVal mes As Integer, ByVal anio As Integer, ByVal MonthCalendar1 As System.Windows.Forms.MonthCalendar)

        'Dim year As Integer = Format(anio, "yyyy") ' Cambia el año según tus necesidades
        'Dim month As Integer = Format(mes, "dd")  ' Cambia el mes según tus necesidades (1 para enero, 2 para febrero, etc.)

        ' Crear un objeto DateTime con el año y el mes deseado
        Dim selectedDate As New DateTime(anio, mes, 1)

        ' Asignar la fecha al control MonthCalendar
        MonthCalendar1.SetDate(selectedDate)
    End Sub


    Private Function actualizaDtsActividad(ByVal med_id As Integer, ByVal periodo As String) As Boolean
        dtt_actividad.Clear()
        If opr_agenda.LlenarGridActividad(dgv_Actividad, med_id, periodo, dtt_actividad) = True Then
            actualizaDtsActividad = True
        Else
            actualizaDtsActividad = False
        End If
    End Function


    Private Sub frm_Actividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'fechaSeleccionadaCal = e.Start
        'lbl_FechaSeleccionada.Text = Format(Now(), "dd MMM yyyy")
        lbl_FechaSeleccionada.Text = ""


        calendario = Split(opr_agenda.LeerCalendario("Medico", med_id), ",")
        opr_medico.LlenarCalendarioMedico(cmb_Hora, med_id)
        opr_medico.LlenarCalendarioMedico(cmb_HoraFin, med_id)
        opr_medico.LlenarComboActividad(cmb_Actividad)
        cmb_Motivo.Text = "NO APLICA"
        cmb_Mes.Text = Format(Now(), "MMMM").ToUpper()

        cmb_Recursividad.SelectedIndex = 0

        If Format(Now(), "MM") <= 6 Then
            cmb_Trimestre.SelectedIndex = 0
        Else
            cmb_Trimestre.SelectedIndex = 1
        End If

        'btn_AceptaAct.Enabled = False
        'btn_EliminaAct.Enabled = False

        '' ''CREO COLUMNAS PARA GRID DIAGNOSTIO ACTIVIDAD
        Dim dtAct_columna1 As New DataColumn("aact_id", GetType(System.Int32))
        Dim dtAct_columna2 As New DataColumn("aact_tipo", GetType(System.String))
        Dim dtAct_columna3 As New DataColumn("aact_FecIni", GetType(System.String))
        Dim dtAct_columna4 As New DataColumn("aact_FecFin", GetType(System.String))
        Dim dtAct_columna5 As New DataColumn("aact_Hora", GetType(System.String))
        Dim dtAct_columna6 As New DataColumn("aact_Hora_agenda", GetType(System.String))

        dtt_actividad.Columns.Add(dtAct_columna1)
        dtt_actividad.Columns.Add(dtAct_columna2)
        dtt_actividad.Columns.Add(dtAct_columna3)
        dtt_actividad.Columns.Add(dtAct_columna4)
        dtt_actividad.Columns.Add(dtAct_columna5)
        dtt_actividad.Columns.Add(dtAct_columna6)

        If actualizaDtsActividad(med_id, EscojeTipo) = True Then

            dgv_Actividad.Columns("aact_id").HeaderText = "CODIGO"
            dgv_Actividad.Columns("aact_id").Visible = False

            dgv_Actividad.Columns("aact_tipo").HeaderText = "TIPO"
            dgv_Actividad.Columns("aact_tipo").Width = 100

            dgv_Actividad.Columns("aact_FecIni").HeaderText = "INICIA"
            dgv_Actividad.Columns("aact_FecIni").Width = 80

            dgv_Actividad.Columns("aact_FecFin").HeaderText = "FINALIZA"
            'dgv_Actividad.Columns("aact_FecFin").Visible = False
            dgv_Actividad.Columns("aact_FecFin").Width = 80

            dgv_Actividad.Columns("aact_hora").HeaderText = "PERIODO"
            dgv_Actividad.Columns("aact_hora").Width = 60

            dgv_Actividad.Columns("aact_hora_agenda").HeaderText = "DIA/HORA"
            dgv_Actividad.Columns("aact_hora_agenda").Width = 110

        End If
        With dgv_Actividad

            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With



    End Sub

    Private Sub btn_AceptaActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AceptaAct.Click
        On Error Resume Next
        Dim ctl As Form
        'Dim ctl2 As frm_AgendaCitaMedica
        Dim opr_pedido As New Cls_Pedido()
        Dim opr_agenda As New Cls_Agenda()
        Dim a_dias As String()
        Dim diahoy As String
        Dim a_hora As String
        Dim i, j, dias, d, diaNum, k As Integer
        Dim age_id As Integer = 0
        Dim bandera_dia As Boolean = False
        Dim calendario As String()
        Dim motivo, a_hora_agenda As String

        Select Case cmb_Recursividad.Text
            Case "Hora"
                dias = 0
                a_hora = "HORA"
                a_hora_agenda = cmb_Hora.Text
            Case "Diario"
                dias = 0
                a_hora = "DIA"
                a_hora_agenda = fechaSeleccionadaCal.ToString("dddd", New CultureInfo("es-ES")).ToUpper()

            Case "Mensual"
                Dim ultimoDiaDelMes As Integer
                a_hora = "MES"
                a_hora_agenda = Trim(cmb_Mes.Text)

                If Format(Now(), "MMMM").ToUpper() <> cmb_Mes.Text Then
                    fechaSeleccionadaCal = CDate(Format(Now(), "yyyy/" & MesDia & "/01"))
                    ultimoDiaDelMes = DateTime.DaysInMonth(Format(Now(), "yyyy"), MesDia)
                    dias = ultimoDiaDelMes - 1
                Else
                    fechaSeleccionadaCal = CDate(Format(Now(), "yyyy/MM/dd"))
                    ultimoDiaDelMes = DateTime.DaysInMonth(Format(Now(), "yyyy"), Format(Now(), "MM"))
                    dias = ultimoDiaDelMes - CInt(Format(Now(), "dd"))
                End If
        End Select

        
        Select Case a_hora
            Case "DIA"
                If lbl_FechaSeleccionada.Text = "" Then
                    opr_pedido.VisualizaMensaje("Debe seleccionar una fecha en el calendario", 350)
                    Exit Sub
                End If

            Case "HORA"
                If lbl_FechaSeleccionada.Text = "" Then
                    opr_pedido.VisualizaMensaje("Debe seleccionar una fecha en el calendario", 350)
                    Exit Sub
                End If
                If CDate(cmb_Hora.Text) > CDate(cmb_HoraFin.Text) Then
                    opr_pedido.VisualizaMensaje("La hora inicial no puede ser maoyor a la hoa final", 350)
                    Exit Sub
                End If
        End Select


        Select Case a_hora
            Case "DIA"
                'For i = 0 To UBound(calendario) - 1
                If opr_agenda.ExisteActividad(Format(fechaSeleccionadaCal, "dd/MM/yyyy"), cmb_Hora.Text, "DIA", med_id, "", motivo) > 0 Then
                    opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & motivo, 450)
                Else
                    If opr_agenda.ExisteAgendaS(Format(fechaSeleccionadaCal, "dd/MM/yyyy"), "DIA", med_id, "", retorna_hora, retorna_Age_id) = "0" Then
                        opr_pedido.VisualizaMensaje("Para reservar este FERIADO debe generar agenda mensual para el MES de " & Format(fechaSeleccionadaCal, "MMMM").ToUpper(), 450)
                    Else
                        opr_agenda.ModificaAgendaActividad(Format(fechaSeleccionadaCal, "dd/MM/yyyy"), med_id, "RESERVADA", cmb_Motivo.Text, sinoguardo)

                        If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), cmb_Motivo.Text, fechaSeleccionadaCal, fechaSeleccionadaCal.AddDays(dias), med_id, a_hora, "Insertar", a_hora_agenda, "24:00") = True Then
                            actualizaDtsActividad(med_id, EscojeTipo)

                            'a_dias = Split(opr_agenda.LeerDias("Medico", CInt(med_id)), "|")

                            'calendario = Split(opr_agenda.LeerCalendario("Medico", CInt(med_id)), ",")

                            'age_id = opr_agenda.LeeMaximoAgenda() + 1
                        End If
                    End If
                    'Next
                End If

            Case "HORA"
                If opr_agenda.ExisteActividad(Format(fechaSeleccionadaCal, "dd/MM/yyyy"), cmb_Hora.Text, "HORA", med_id, Trim(cmb_Hora.Text), motivo) > 0 Then
                    opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & Mid(motivo, 1, motivo.Length - 1), 450)
                    Exit Sub
                Else
                    a_dias = Split(opr_agenda.LeerDias("Medico", CInt(med_id)), "|")

                    Dim indiceIni As Integer = cmb_Hora.SelectedIndex
                    Dim indiceFin As Integer = cmb_HoraFin.SelectedIndex
                    Dim intervalo As Integer = indiceFin - indiceIni
                    Dim arre_datos As String()
                    Dim datos_Fin As String
                    Dim valor As String

                    For k = indiceIni To indiceFin
                        datos_Fin = datos_Fin & cmb_Hora.Items(indiceIni).ToString() & "º"
                        indiceIni = indiceIni + 1
                    Next

                    arre_datos = Split(datos_Fin, "º")

                    For i = 0 To UBound(arre_datos) - 1

                        If opr_agenda.ExisteHoraActividadString(Format(fechaSeleccionadaCal, "dd/MM/yyyy"), arre_datos(i), "HORA", med_id, motivo) = 0 Then

                            If motivo <> "" Then
                                opr_agenda.ModificaAgenda(motivo, Format(fechaSeleccionadaCal, "dd/MM/yyyy"), arre_datos(i), "HORA", med_id, "RESERVADA", cmb_Motivo.Text)
                            Else
                                opr_pedido.VisualizaMensaje("Para reservar esta fecha debe generar agenda mensual para el MES de " & Format(fechaSeleccionadaCal, "MMMM").ToUpper(), 450)
                                Exit Sub
                            End If
                            'Next
                        Else
                            'opr_pedido.VisualizaMensaje("Para reservar esta fecha debe generar agenda mensual para el MES de " & Format(fechaSeleccionadaCal, "MMMM").ToUpper(), 450)
                        End If
                    Next
                    If motivo <> "" Then
                        If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), Trim(Mid(cmb_Actividad.Text, 1, 100)), fechaSeleccionadaCal, fechaSeleccionadaCal.AddDays(dias), med_id, a_hora, "Insertar", a_hora_agenda, cmb_Hora.Text & "-" & cmb_HoraFin.Text) = True Then
                            actualizaDtsActividad(med_id, EscojeTipo)
                        End If
                    End If
                End If
            Case "MES"
                If opr_agenda.ExisteAgendaActividad(fechaSeleccionadaCal, a_hora, med_id, cmb_Recursividad.Text, a_hora_agenda) > 0 Then
                    opr_pedido.VisualizaMensaje("Ya existe una actividad con esa descripcion", 400)
                Else
                    a_dias = Split(opr_agenda.LeerDias("Medico", CInt(med_id)), "|")

                    calendario = Split(opr_agenda.LeerCalendario("Medico", CInt(med_id)), ",")

                    age_id = opr_agenda.LeeMaximoAgenda() + 1



                    If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), Trim(Mid(cmb_Actividad.Text, 1, 100)), fechaSeleccionadaCal, fechaSeleccionadaCal.AddDays(dias), med_id, a_hora, "Insertar", a_hora_agenda, cmb_Mes.Text) = True Then
                        actualizaDtsActividad(med_id, EscojeTipo)
                    End If

                    For j = 0 To dias
                        For i = 0 To UBound(calendario) - 1
                            'If calendario(i) <> opr_agenda.ExisteHoraActividadString(Format(fechaSeleccionadaCal, "dd/MM/yyyy"), cmb_Hora.Text, "MES", med_id, motivo) Then
                            If calendario(i) <> opr_agenda.ExisteAgendaS(Format(fechaSeleccionadaCal, "dd/MM/yyyy"), "MES", med_id, cmb_Hora.Text, retorna_hora, retorna_Age_id) Then
                                opr_agenda.CreaAgenda(age_id, Format(fechaSeleccionadaCal, "dd/MM/yyyy"), calendario(i), "Medico", med_id, Trim(Mid(cmb_Actividad.Text, 1, 100)), "")
                                age_id = age_id + 1
                            Else
                                opr_agenda.ModificaAgenda(retorna_Age_id, Format(fechaSeleccionadaCal, "dd/MM/yyyy"), calendario(i), "MES", med_id, Trim(Mid(cmb_Actividad.Text, 1, 100)), motivo)
                            End If
                            'age_id = age_id + 1
                        Next
                        ''AUMENTO EN UN DIA LA FECHA y EL ID
                        fechaSeleccionadaCal = fechaSeleccionadaCal.AddDays(1)
                    Next

                End If
        End Select


    End Sub

    Private Sub btn_SolicitarVacuna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalirAct.Click
        Me.Close()
    End Sub

    Private Sub dtp_IniciaActividad_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles dtp_IniciaActividad.DateChanged
        fechaSeleccionadaCal = e.Start

        lbl_FechaSeleccionada.Text = Format(fechaSeleccionadaCal, "dd MMM yyyy")

        ' Obtener el día de la semana
        diaDeLaSemana = fechaSeleccionadaCal.DayOfWeek

        ' Convertir el valor DayOfWeek a una cadena de texto
        Dim nombreDelDia As String = diaDeLaSemana.ToString()
    End Sub


    Private Sub cmb_Trimestre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Trimestre.SelectedIndexChanged
        Select Case cmb_Trimestre.SelectedIndex
            Case 0
                AjustaMesAnioCalendario(1, Format(Now(), "yyyy"), calM1)
                AjustaMesAnioCalendario(2, Format(Now(), "yyyy"), calM2)
                AjustaMesAnioCalendario(3, Format(Now(), "yyyy"), calM3)
                AjustaMesAnioCalendario(4, Format(Now(), "yyyy"), calM4)
                AjustaMesAnioCalendario(5, Format(Now(), "yyyy"), calM5)
                AjustaMesAnioCalendario(6, Format(Now(), "yyyy"), calM6)
            Case 1
                AjustaMesAnioCalendario(7, Format(Now(), "yyyy"), calM1)
                AjustaMesAnioCalendario(8, Format(Now(), "yyyy"), calM2)
                AjustaMesAnioCalendario(9, Format(Now(), "yyyy"), calM3)
                AjustaMesAnioCalendario(10, Format(Now(), "yyyy"), calM4)
                AjustaMesAnioCalendario(11, Format(Now(), "yyyy"), calM5)
                AjustaMesAnioCalendario(12, Format(Now(), "yyyy"), calM6)
        End Select
    End Sub


    Private Sub calM1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calM1.DateSelected
        Dim fechaSeleccionada As DateTime = e.Start
        Dim SiNoGuardo As Boolean = False
        Dim age_id, i As Integer
        Dim nombreDiaSemana As String = fechaSeleccionada.ToString("dddd", New CultureInfo("es-ES")).ToUpper

        If opr_agenda.ExisteActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), cmb_Hora.Text, "DIA", med_id, "", motivo) > 0 Then
            opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & Mid(motivo, 1, motivo.Length - 1), 400)
        Else
            If opr_agenda.ExisteAgendaS(Format(fechaSeleccionada, "dd/MM/yyyy"), "DIA", med_id, "", retorna_hora, retorna_Age_id) = "0" Then
                opr_pedido.VisualizaMensaje("Para reservar este FERIADO debe generar agenda mensual para el MES de " & Format(fechaSeleccionada, "MMMM"), 400)
            Else

                opr_agenda.ModificaAgendaActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), med_id, "RESERVADA", "FERIADO", SiNoGuardo)
                If SiNoGuardo = True Then
                    If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), "FERIADO", fechaSeleccionada, fechaSeleccionada, med_id, "DIA", "Insertar", nombreDiaSemana.ToUpper(), "") = True Then
                        actualizaDtsActividad(med_id, EscojeTipo)
                        rbt_Dia.Checked = True
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub calM2_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calM2.DateSelected
        Dim fechaSeleccionada As DateTime = e.Start
        Dim SiNoGuardo As Boolean = False
        Dim age_id, i As Integer
        Dim nombreDiaSemana As String = fechaSeleccionada.ToString("dddd", New CultureInfo("es-ES")).ToUpper

        If opr_agenda.ExisteActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), cmb_Hora.Text, "DIA", med_id, "", motivo) > 0 Then
            opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & Mid(motivo, 1, motivo.Length - 1), 400)
        Else
            If opr_agenda.ExisteAgendaS(Format(fechaSeleccionada, "dd/MM/yyyy"), "DIA", med_id, "", retorna_hora, retorna_Age_id) = "0" Then
                opr_pedido.VisualizaMensaje("Para reservar este FERIADO debe generar agenda mensual para el MES de " & Format(fechaSeleccionada, "MMMM"), 400)
            Else

                opr_agenda.ModificaAgendaActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), med_id, "RESERVADA", "FERIADO", SiNoGuardo)
                If SiNoGuardo = True Then
                    If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), "FERIADO", fechaSeleccionada, fechaSeleccionada, med_id, "DIA", "Insertar", nombreDiaSemana.ToUpper(), "") = True Then
                        actualizaDtsActividad(med_id, EscojeTipo)
                        rbt_Dia.Checked = True
                    End If
                End If
            End If
        End If
       
    End Sub

    Private Sub calM3_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calM3.DateSelected
        Dim fechaSeleccionada As DateTime = e.Start
        Dim SiNoGuardo As Boolean = False
        Dim age_id, i As Integer
        Dim nombreDiaSemana As String = fechaSeleccionada.ToString("dddd", New CultureInfo("es-ES")).ToUpper

        rbt_Dia.Checked = True
        If opr_agenda.ExisteActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), cmb_Hora.Text, "DIA", med_id, "", motivo) > 0 Then
            opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & Mid(motivo, 1, motivo.Length - 1), 400)
        Else
            opr_agenda.ModificaAgendaActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), med_id, "RESERVADA", "FERIADO", SiNoGuardo)
            If SiNoGuardo = True Then
                If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), "FERIADO", fechaSeleccionada, fechaSeleccionada, med_id, "DIA", "Insertar", nombreDiaSemana.ToUpper(), "") = True Then
                    actualizaDtsActividad(med_id, EscojeTipo)
                End If
            End If
        End If
    End Sub

    Private Sub calM4_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calM4.DateSelected
        Dim fechaSeleccionada As DateTime = e.Start
        Dim SiNoGuardo As Boolean = False
        Dim age_id, i As Integer
        Dim nombreDiaSemana As String = fechaSeleccionada.ToString("dddd", New CultureInfo("es-ES")).ToUpper


        If opr_agenda.ExisteActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), cmb_Hora.Text, "DIA", med_id, "", motivo) > 0 Then
            opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & Mid(motivo, 1, motivo.Length - 1), 400)
        Else
            If opr_agenda.ExisteAgendaS(Format(fechaSeleccionada, "dd/MM/yyyy"), "DIA", med_id, "", retorna_hora, retorna_Age_id) = "0" Then
                opr_pedido.VisualizaMensaje("Para reservar este FERIADO debe generar agenda mensual para el MES de " & Format(fechaSeleccionada, "MMMM"), 400)
            Else

                opr_agenda.ModificaAgendaActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), med_id, "RESERVADA", "FERIADO", SiNoGuardo)
                If SiNoGuardo = True Then
                    If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), "FERIADO", fechaSeleccionada, fechaSeleccionada, med_id, "DIA", "Insertar", nombreDiaSemana.ToUpper(), "") = True Then
                        actualizaDtsActividad(med_id, EscojeTipo)
                        rbt_Dia.Checked = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub calM5_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calM5.DateSelected
        Dim fechaSeleccionada As DateTime = e.Start
        Dim SiNoGuardo As Boolean = False
        Dim age_id, i As Integer
        Dim nombreDiaSemana As String = fechaSeleccionada.ToString("dddd", New CultureInfo("es-ES")).ToUpper

        If opr_agenda.ExisteActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), cmb_Hora.Text, "DIA", med_id, "", motivo) > 0 Then
            opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & Mid(motivo, 1, motivo.Length - 1), 400)
        Else
            If opr_agenda.ExisteAgendaS(Format(fechaSeleccionada, "dd/MM/yyyy"), "DIA", med_id, "", retorna_hora, retorna_Age_id) = "0" Then
                opr_pedido.VisualizaMensaje("Para reservar este FERIADO debe generar agenda mensual para el MES de " & Format(fechaSeleccionada, "MMMM"), 400)
            Else

                opr_agenda.ModificaAgendaActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), med_id, "RESERVADA", "FERIADO", SiNoGuardo)
                If SiNoGuardo = True Then
                    If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), "FERIADO", fechaSeleccionada, fechaSeleccionada, med_id, "DIA", "Insertar", nombreDiaSemana.ToUpper(), "") = True Then
                        actualizaDtsActividad(med_id, EscojeTipo)
                        rbt_Dia.Checked = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub calM6_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calM6.DateSelected
        Dim fechaSeleccionada As DateTime = e.Start
        Dim SiNoGuardo As Boolean = False
        Dim age_id, i As Integer
        Dim nombreDiaSemana As String = fechaSeleccionada.ToString("dddd", New CultureInfo("es-ES")).ToUpper
        If opr_agenda.ExisteActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), cmb_Hora.Text, "DIA", med_id, "", motivo) > 0 Then
            opr_pedido.VisualizaMensaje("No se puede reservar, existen agendas a las " & Mid(motivo, 1, motivo.Length - 1), 400)
        Else
            If opr_agenda.ExisteAgendaS(Format(fechaSeleccionada, "dd/MM/yyyy"), "DIA", med_id, "", retorna_hora, retorna_Age_id) = "0" Then
                opr_pedido.VisualizaMensaje("Para reservar este FERIADO debe generar agenda mensual para el MES de " & Format(fechaSeleccionada, "MMMM"), 400)
            Else

                opr_agenda.ModificaAgendaActividad(Format(fechaSeleccionada, "dd/MM/yyyy"), med_id, "RESERVADA", "FERIADO", SiNoGuardo)
                If SiNoGuardo = True Then
                    If opr_agenda.GestionaActividad(opr_agenda.LeeMaximoActividad(), "FERIADO", fechaSeleccionada, fechaSeleccionada, med_id, "DIA", "Insertar", nombreDiaSemana.ToUpper(), "") = True Then
                        actualizaDtsActividad(med_id, EscojeTipo)
                        rbt_Dia.Checked = True
                    End If
                End If
            End If
        End If

    End Sub

    
    Private Sub btn_EliminaAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EliminaAct.Click

        If opr_agenda.GestionaActividad(dgv_Actividad.CurrentRow.Cells("aact_id").Value(), Trim(Mid(cmb_Actividad.Text, 1, 100)), fechaSeleccionadaCal, fechaSeleccionadaCal, med_id, "", "Eliminar", Trim(cmb_Hora.Text), "") = True Then
            actualizaDtsActividad(med_id, EscojeTipo)
        End If
    End Sub

    Private Sub dgv_Actividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_Actividad.Click
        btn_EliminaAct.Enabled = True
    End Sub

    
    Private Sub rbt_Hora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Hora.CheckedChanged
        If rbt_Hora.Checked = True Then
            EscojeTipo = "HORA"
            actualizaDtsActividad(med_id, EscojeTipo)
        End If
    End Sub

    Private Sub rbt_Dia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Dia.CheckedChanged
        If rbt_Dia.Checked = True Then
            EscojeTipo = "DIA"
            actualizaDtsActividad(med_id, EscojeTipo)
        End If
    End Sub


    Private Sub rbt_Mes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Mes.CheckedChanged
        If rbt_Mes.Checked = True Then
            EscojeTipo = "MES"
            actualizaDtsActividad(med_id, EscojeTipo)
        End If
    End Sub

    Private Sub cmb_Recursividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Recursividad.SelectedIndexChanged
        CargaCombos(cmb_Recursividad.Text)
    End Sub

    Private Sub CargaCombos(ByVal periodo As String)
        Select Case periodo
            Case "Mensual"
                cmb_HoraFin.Visible = False
                cmb_Hora.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                cmb_Mes.Visible = True
                dtp_IniciaActividad.Visible = False
                rbt_Mes.Checked = True
                cmb_Actividad.SelectedIndex = 0
                'cmb_Actividad.Enabled = True

            Case "Diario"
                cmb_HoraFin.Visible = False
                cmb_Hora.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                cmb_Mes.Visible = False
                dtp_IniciaActividad.Visible = True
                rbt_Dia.Checked = True
                cmb_Actividad.SelectedIndex = 1
                cmb_Actividad.Enabled = False
            Case "Hora"
                cmb_HoraFin.Visible = True
                cmb_Hora.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                cmb_Mes.Visible = False
                dtp_IniciaActividad.Visible = True
                rbt_Hora.Checked = True
                cmb_Actividad.SelectedIndex = 1
                cmb_Actividad.Enabled = False
        End Select

    End Sub

    Private Sub cmb_Mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Mes.SelectedIndexChanged
        Select Case cmb_Mes.Text
            Case "ENERO"
                MesDia = 1
            Case "FEBRERO"
                MesDia = 2
            Case "MARZO"
                MesDia = 3
            Case "ABRIL"
                MesDia = 4
            Case "MAYO"
                MesDia = 5
            Case "JUNIO"
                MesDia = 6
            Case "JULIO"
                MesDia = 7
            Case "AGOSTO"
                MesDia = 8
            Case "SEPTIEMBRE"
                MesDia = 9
            Case "OCTUBRE"
                MesDia = 10
            Case "NOVIEMBRE"
                MesDia = 11
            Case "DICIEMBRE"
                MesDia = 12
        End Select

    End Sub

    
    Private Sub dtp_IniciaActividad_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles dtp_IniciaActividad.DateSelected
        fechaSeleccionadaCal = e.Start

        lbl_FechaSeleccionada.Text = Format(fechaSeleccionadaCal, "dd MMM yyyy")

        ' Obtener el día de la semana
        diaDeLaSemana = fechaSeleccionadaCal.DayOfWeek

        ' Convertir el valor DayOfWeek a una cadena de texto
        Dim nombreDelDia As String = diaDeLaSemana.ToString()
    End Sub
End Class