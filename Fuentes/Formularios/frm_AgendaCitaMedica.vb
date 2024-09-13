'Imports System.Data.SqlClient

Public Class frm_AgendaCitaMedica
    Dim opr_res As New Cls_Resultado()
    Dim opr_agenda As New Cls_Agenda()
    Dim opr_pac As New Cls_Paciente()
    Private opr_medico As New Cls_Medico()
    Public LabOcup As Byte
    Dim opr_test As New Cls_TipoTest()
    Dim opr_pedido As New Cls_Pedido()
    'Dim dts_lista As New DataSet
    Dim dtv_agenda As New DataView()
    Public DatosTag As String = Nothing
    Public var_actividad As String = Nothing
    Dim indiceSeleccionado As Integer
    Dim dts_medico As DataSet
    Dim dts_agenda As DataSet
    Dim var_fecha As Date
    Private WithEvents dtt_medico As New DataTable("Registros")
    Private WithEvents dtt_agenda As New DataTable("Registros")
    Private WithEvents dtt_agendaD As New DataTable("Registros")

    Dim paciente As String = Nothing
    Dim edad, unidad As String
    Dim ped_id As Integer
    Dim age_id As Integer
    Dim param_conv As String()
    Dim param_pac As String()
    Dim pac_sexo, pac_dir, pac_fono, pac_email As String
    Dim pac_fecnac As Date
    Dim SiNoGuardo As Boolean = False
    Dim blnAjustarCeldas As Boolean = True
    Dim frm_refer_main_form As Frm_Main
    Dim i As Integer
    Dim str_cer As String
    Dim var_sol, var_fras, var_unid As String
    Dim pac_id As Integer
    Dim visto As Char = ChrW(10003)
    Dim currentRowIndex As Integer = -1 ' Inicialmente, configuramos el valor en -1 para indicar que no se ha seleccionado ninguna fila aún

    Public med_Despacho As Integer
    Dim var_label As String
    Dim Var_Vergrupo As Boolean




    Private Sub frm_AgendaCitaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_AgendarA.Text = "Escoja una hora para agendar"

        var_fecha = Format(Now(), "dd/MM/yyyy")

        opr_medico.LlenarComboEspecialidad(cmb_Especialidad)

        Var_Vergrupo = True
        '***********************************
        ' MEDICO
        '***********************************
        Dim dtcM_columna1 As New DataColumn("med_nombre", GetType(System.String))
        Dim dtcM_columna2 As New DataColumn("med_id", GetType(System.Single))
        Dim dtcM_columna3 As New DataColumn("med_mail", GetType(System.String))
        dtt_medico.Columns.Add(dtcM_columna1)
        dtt_medico.Columns.Add(dtcM_columna2)
        dtt_medico.Columns.Add(dtcM_columna3)

        If cmb_Especialidad.Text = "Todas" Then
            actualizaDtsMedico(0, 0, Var_Vergrupo)
        Else
            actualizaDtsMedico(CInt(Mid(cmb_Especialidad.Text, 101, 110)), 0, Var_Vergrupo)
        End If

        dgv_Medico.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        dgv_Medico.Columns("med_nombre").Width = 190
        dgv_Medico.Columns("med_id").Visible = False
        dgv_Medico.Columns("med_mail").Visible = False

        dgv_Medico.DefaultCellStyle.SelectionForeColor = Color.LightYellow
        dgv_Medico.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)

        '***********************************
        ' AGENDA NORMAL
        '***********************************
        Dim dtcA_columna1 As New DataColumn("age_id", GetType(System.Double))
        Dim dtcA_columna2 As New DataColumn("age_hora", GetType(System.String))
        Dim dtcA_columna3 As New DataColumn("age_fecha", GetType(System.String))
        Dim dtcA_columna4 As New DataColumn("pac_id", GetType(System.Double))
        Dim dtcA_columna5 As New DataColumn("pac_nombre", GetType(System.String))
        Dim dtcA_columna6 As New DataColumn("pac_edad", GetType(System.String))
        Dim dtcA_columna7 As New DataColumn("med_id", GetType(System.Double))
        Dim dtcA_columna8 As New DataColumn("ped_id", GetType(System.Double))
        Dim dtcA_columna9 As New DataColumn("age_resumen", GetType(System.String))
        Dim dtcA_columna10 As New DataColumn("age_cutaneas", GetType(System.String))
        Dim dtcA_columna11 As New DataColumn("age_dermografismo", GetType(System.String))
        Dim dtcA_columna12 As New DataColumn("age_receta", GetType(System.String))
        Dim dtcA_columna13 As New DataColumn("age_tratamiento", GetType(System.String))
        Dim dtcA_columna14 As New DataColumn("age_finalizado", GetType(System.String))
        Dim dtcA_columna15 As New DataColumn("cer_str", GetType(System.String))
        Dim dtcA_columna16 As New DataColumn("age_tutor", GetType(System.String))
        Dim dtcA_columna17 As New DataColumn("age_ci", GetType(System.String))
        Dim dtcA_columna18 As New DataColumn("pac_doc", GetType(System.String))
        Dim dtcA_columna19 As New DataColumn("age_estado", GetType(System.String))
        Dim dtcA_columna20 As New DataColumn("ped_turno", GetType(System.String))

        dtt_agenda.Columns.Add(dtcA_columna1)
        dtt_agenda.Columns.Add(dtcA_columna2)
        dtt_agenda.Columns.Add(dtcA_columna3)
        dtt_agenda.Columns.Add(dtcA_columna4)
        dtt_agenda.Columns.Add(dtcA_columna5)
        dtt_agenda.Columns.Add(dtcA_columna6)
        dtt_agenda.Columns.Add(dtcA_columna7)
        dtt_agenda.Columns.Add(dtcA_columna8)
        dtt_agenda.Columns.Add(dtcA_columna9)
        dtt_agenda.Columns.Add(dtcA_columna10)
        dtt_agenda.Columns.Add(dtcA_columna11)
        dtt_agenda.Columns.Add(dtcA_columna12)
        dtt_agenda.Columns.Add(dtcA_columna13)
        dtt_agenda.Columns.Add(dtcA_columna14)
        dtt_agenda.Columns.Add(dtcA_columna15)
        dtt_agenda.Columns.Add(dtcA_columna16)
        dtt_agenda.Columns.Add(dtcA_columna17)
        dtt_agenda.Columns.Add(dtcA_columna18)
        dtt_agenda.Columns.Add(dtcA_columna19)
        dtt_agenda.Columns.Add(dtcA_columna20)

        med_Despacho = opr_medico.buscamedicoNombre("DESPACHO")

        If med_Despacho > 0 Then
            If med_Despacho <> dgv_Medico.CurrentRow.Cells("med_id").Value Then
                If actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value)) = True Then

                    dgv_Agenda.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    dgv_Agenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                    dgv_Agenda.Columns("age_id").Visible = False
                    dgv_Agenda.Columns("age_hora").HeaderText = "HORA"
                    dgv_Agenda.Columns("age_hora").Width = 50
                    dgv_Agenda.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    dgv_Agenda.Columns("age_fecha").Visible = False
                    dgv_Agenda.Columns("pac_id").Visible = False
                    dgv_Agenda.Columns("pac_nombre").HeaderText = "PACIENTE"
                    dgv_Agenda.Columns("pac_nombre").Width = 270
                    dgv_Agenda.Columns("med_id").Visible = False
                    dgv_Agenda.Columns("pac_edad").HeaderText = "EDAD"
                    dgv_Agenda.Columns("pac_edad").Width = 100
                    dgv_Agenda.Columns("ped_id").Visible = False
                    dgv_Agenda.Columns("age_resumen").HeaderText = "RESUMEN"
                    dgv_Agenda.Columns("age_resumen").Width = 170
                    dgv_Agenda.Columns("age_cutaneas").HeaderText = "CUT"
                    dgv_Agenda.Columns("age_cutaneas").Width = 44
                    dgv_Agenda.Columns("age_dermografismo").HeaderText = "DER"
                    dgv_Agenda.Columns("age_dermografismo").Width = 44
                    dgv_Agenda.Columns("age_receta").HeaderText = "REC"
                    dgv_Agenda.Columns("age_receta").Width = 44
                    dgv_Agenda.Columns("age_tratamiento").HeaderText = "TTO"
                    dgv_Agenda.Columns("age_tratamiento").Width = 44
                    dgv_Agenda.Columns("age_finalizado").HeaderText = "CLOSE"
                    dgv_Agenda.Columns("age_finalizado").Width = 44
                    dgv_Agenda.Columns("cer_str").Visible = False
                    dgv_Agenda.Columns("age_tutor").Visible = False
                    dgv_Agenda.Columns("age_ci").Visible = False
                    dgv_Agenda.Columns("pac_doc").Visible = False
                    dgv_Agenda.Columns("age_estado").HeaderText = "ESTADO"
                    dgv_Agenda.Columns("age_estado").Width = 80
                    dgv_Agenda.Columns("ped_turno").HeaderText = "TURNO"
                    dgv_Agenda.Columns("ped_turno").Visible = False
                    PintaGrid()
                End If

                With dgv_Agenda
                    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .DefaultCellStyle.BackColor = Color.WhiteSmoke
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With

                '***********************************
                ' AGENDA DESPACHO
                '***********************************
                Dim dtcD_columna1 As New DataColumn("age_id", GetType(System.Double))
                Dim dtcD_columna2 As New DataColumn("age_hora", GetType(System.String))
                Dim dtcD_columna3 As New DataColumn("age_fecha", GetType(System.String))
                Dim dtcD_columna4 As New DataColumn("pac_id", GetType(System.Double))
                Dim dtcD_columna5 As New DataColumn("med_id", GetType(System.Double))
                Dim dtcD_columna6 As New DataColumn("MED_NOMBRE", GetType(System.String))
                Dim dtcD_columna7 As New DataColumn("ped_id", GetType(System.Double))
                Dim dtcD_columna8 As New DataColumn("age_resumen", GetType(System.String))
                Dim dtcD_columna9 As New DataColumn("age_ci", GetType(System.String))
                Dim dtcD_columna10 As New DataColumn("MED_DOC", GetType(System.String))
                Dim dtcD_columna11 As New DataColumn("age_estado", GetType(System.String))


                dtt_agendaD.Columns.Add(dtcD_columna1)
                dtt_agendaD.Columns.Add(dtcD_columna2)
                dtt_agendaD.Columns.Add(dtcD_columna3)
                dtt_agendaD.Columns.Add(dtcD_columna4)
                dtt_agendaD.Columns.Add(dtcD_columna5)
                dtt_agendaD.Columns.Add(dtcD_columna6)
                dtt_agendaD.Columns.Add(dtcD_columna7)
                dtt_agendaD.Columns.Add(dtcD_columna8)
                dtt_agendaD.Columns.Add(dtcD_columna9)
                dtt_agendaD.Columns.Add(dtcD_columna10)
                dtt_agendaD.Columns.Add(dtcD_columna11)

            End If
        End If
        lbl_AgendarDia.Text = Format(dtp_CitaMedica.SelectionRange.Start, "dd MMMM yyyy")
        If dgv_Medico.CurrentRow.Cells("med_nombre").Value.PadRight(150) <> "" Then
            lbl_MedicoCita.Text = dgv_Medico.CurrentRow.Cells("med_nombre").Value.PadRight(150)
        Else
            lbl_MedicoCita.Text = ""
        End If
        opr_pedido.LlenarComboPrioridad(cmb_convenio, False, True)


    End Sub


    'dts_agenda = opr_res.LlenaMedicoAgenda(Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"))
    'lst_medico.Items.Clear()
    'dts_lista = opr_res.LlenaListMedicoAgenda(lst_medico, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"))


    Private Sub actualizaDtsMedico(ByVal esp_id As Integer, ByVal tipo As Integer, ByVal Var_Vergrupo As Boolean)
        dtt_medico.Clear()
        opr_res.LlenarGridMedico(dgv_Medico, dtt_medico, esp_id, tipo, Var_Vergrupo)
    End Sub



    Private Function actualizaDtsAgenda(ByVal med_id As Integer) As Boolean

        Dim calendario As String()
        Dim dias As String()
        Dim diahoy As String
        Dim diaNum As Char
        Dim i As Integer
        Dim age_id As Integer = 0
        Dim bandera_dia As Boolean = False
        dtt_agenda.Clear()
        Dim motivo As String

        dias = Split(opr_agenda.LeerDias("Medico", med_id), "|")
        diahoy = Now().DayOfWeek()
        Select Case diahoy
            Case 0 : diaNum = "D"
            Case 1 : diaNum = "L"
            Case 2 : diaNum = "M"
            Case 3 : diaNum = "W"
            Case 4 : diaNum = "J"
            Case 5 : diaNum = "V"
            Case 6 : diaNum = "S"

        End Select

        For i = 0 To UBound(dias) - 1
            If diaNum = dias(i) Then
                bandera_dia = True
            End If
        Next

        If opr_agenda.ExisteAgendaActividad(Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "DIA", med_id, motivo, "") = 0 Then

            lbl_NoDisponible.Visible = False
            lbl_NoDisponible.Text = ""

            If bandera_dia = True Then
                If opr_agenda.ExisteAgenda(Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "Medico", med_id) > 0 Then
                    'LEO LA AGENDA DIARIA
                    opr_res.LlenarGridAgenda(dgv_Agenda, dtt_agenda, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "Medico", med_id)
                    PintaGrid()
                Else

                    calendario = Split(opr_agenda.LeerCalendario("Medico", med_id), ",")
                    age_id = opr_agenda.LeeMaximoAgenda() + 1

                    For i = 0 To UBound(calendario) - 1
                        If calendario(i) <> opr_agenda.ExisteHoraActividadString(Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "", "MES", med_id, motivo) Then
                            opr_agenda.CreaAgenda(age_id + i, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), calendario(i), "Medico", med_id, "DISPONIBLE", "")
                        Else
                            opr_agenda.CreaAgenda(age_id + i, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), calendario(i), "Medico", med_id, "RESERVADA", motivo)
                        End If
                    Next

                    'LEO LA AGENDA DIARIA
                    opr_res.LlenarGridAgenda(dgv_Agenda, dtt_agenda, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "Medico", med_id)
                    PintaGrid()
                End If
                actualizaDtsAgenda = True
            Else
                actualizaDtsAgenda = False
                opr_pedido.VisualizaMensaje("El medico solicitado no tiene agenda para este dia", 250)
            End If

        Else
            opr_pedido.VisualizaMensaje("AGENDA NO DISPONIBLE PARA ESTA FECHA, ACTIVIDAD: " & motivo, 350)
            lbl_NoDisponible.Visible = True
            lbl_NoDisponible.Text = "LA FECHA SELECCIONADA NO ESTÁ DISPONIBLE ACTIVIDAD: " & motivo
        End If

        

    End Function

    Private Function actualizaDtsAgendaDespacho(ByVal med_id As Integer) As Boolean

        Dim calendario As String()
        Dim dias As String()
        Dim diahoy As String
        Dim diaNum As Char
        Dim i As Integer
        Dim age_id As Integer = 0
        Dim bandera_dia As Boolean = False
        dtt_agenda.Clear()
        Dim motivo As String

        dias = Split(opr_agenda.LeerDias("Medico", med_id), "|")
        diahoy = Now().DayOfWeek()
        Select Case diahoy
            Case 0 : diaNum = "D"
            Case 1 : diaNum = "L"
            Case 2 : diaNum = "M"
            Case 3 : diaNum = "W"
            Case 4 : diaNum = "J"
            Case 5 : diaNum = "V"
            Case 6 : diaNum = "S"

        End Select

        For i = 0 To UBound(dias) - 1
            If diaNum = dias(i) Then
                bandera_dia = True
            End If
        Next

        If opr_agenda.ExisteAgendaActividad(Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "DIA", med_id, motivo, "") = 0 Then

            lbl_NoDisponible.Visible = False
            lbl_NoDisponible.Text = ""

            If bandera_dia = True Then
                If opr_agenda.ExisteAgenda(Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "Medico", med_id) > 0 Then
                    'LEO LA AGENDA DIARIA
                    opr_res.LlenarGridAgenda(dgv_AgendaDespacho, dtt_agendaD, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "Medico", med_id)
                    'PintaGrid()
                Else

                    calendario = Split(opr_agenda.LeerCalendario("Medico", med_id), ",")
                    age_id = opr_agenda.LeeMaximoAgenda() + 1

                    For i = 0 To UBound(calendario) - 1
                        If calendario(i) <> opr_agenda.ExisteHoraActividadString(Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "", "MES", med_id, motivo) Then
                            opr_agenda.CreaAgenda(age_id + i, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), calendario(i), "Medico", med_id, "DISPONIBLE", "")
                        Else
                            opr_agenda.CreaAgenda(age_id + i, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), calendario(i), "Medico", med_id, "RESERVADA", motivo)
                        End If
                    Next

                    'LEO LA AGENDA DIARIA
                    opr_res.LlenarGridAgenda(dgv_AgendaDespacho, dtt_agendaD, Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), "Medico", med_id)
                    'PintaGrid()
                End If
                actualizaDtsAgendaDespacho = True
            Else
                actualizaDtsAgendaDespacho = False
                opr_pedido.VisualizaMensaje("El medico solicitado no tiene agenda para este dia", 250)
            End If

        Else
            opr_pedido.VisualizaMensaje("AGENDA NO DISPONIBLE PARA ESTA FECHA, ACTIVIDAD: " & motivo, 350)
            lbl_NoDisponible.Visible = True
            lbl_NoDisponible.Text = "LA FECHA SELECCIONADA NO ESTÁ DISPONIBLE ACTIVIDAD: " & motivo
        End If



    End Function


    Private Sub PintaGrid()

        For i = 0 To dtt_agenda.Rows.Count - 1
            ' AGENDA WEB
            If dtt_agenda.Rows(i).Item(8) = "AGENDA WEB" Then
                'dtt_agenda.Rows(i).Item(8) = "AGENDA WEB CONFIRMADA"
                dgv_Agenda.Rows(i).Cells(8).Style.BackColor = Color.Yellow
                'dgv_Agenda.Rows(i).Cells(9).Style.BackColor = Color.Lime
                'dgv_Agenda.Rows(i).Cells(10).Style.BackColor = Color.Red
                'dgv_Agenda.Rows(i).Cells(5).Style.BackColor = Color.Blue
                dgv_Agenda.Rows(i).Cells(4).Style.BackColor = Color.Yellow
            End If


            If dtt_agenda.Rows(i).Item(8) = "FERIADO" Then
                dgv_Agenda.Rows(i).Cells(8).Style.BackColor = Color.Violet
                dgv_Agenda.Rows(i).Cells(4).Style.BackColor = Color.Violet
            End If


            If dtt_agenda.Rows(i).Item(18) = "DISPONIBLE" Then
                dgv_Agenda.Rows(i).Cells(18).Style.BackColor = Color.Lime
            End If

            If dtt_agenda.Rows(i).Item(18) = "RESERVADA" Then
                dgv_Agenda.Rows(i).Cells(18).Style.BackColor = Color.Red
            End If
            If dtt_agenda.Rows(i).Item(18) = "CONFIRMADO" Then
                dgv_Agenda.Rows(i).Cells(18).Style.BackColor = Color.BlueViolet
            End If

            ' CUTANEAS
            If opr_res.TieneCutaneas(dtt_agenda.Rows(i).Item(7)) = True Then 'dgv_Agenda.CurrentRow.Cells("Age_id").Value()) Then
                dtt_agenda.Rows(i).Item(9) = visto
                dgv_Agenda.Rows(i).Cells(9).Style.BackColor = Color.Olive
            Else
                dtt_agenda.Rows(i).Item(9) = ""
            End If

            ' dermografismo
            If opr_res.TieneDermografismo(dtt_agenda.Rows(i).Item(0)) = True Then 'dgv_Agenda.CurrentRow.Cells("Age_id").Value()) Then
                dtt_agenda.Rows(i).Item(10) = visto
                dgv_Agenda.Rows(i).Cells(10).Style.BackColor = Color.Orange
            Else
                dtt_agenda.Rows(i).Item(10) = ""
            End If

            ' RECETA
            If opr_res.TieneReceta(dtt_agenda.Rows(i).Item(0)) = True Then 'dgv_Agenda.CurrentRow.Cells("Age_id").Value()) Then
                dtt_agenda.Rows(i).Item(11) = visto
                dgv_Agenda.Rows(i).Cells(11).Style.BackColor = Color.SeaGreen
            Else
                dtt_agenda.Rows(i).Item(11) = ""
            End If

            ' TRATAMMIENTO
            If opr_res.TieneTratamiento(dtt_agenda.Rows(i).Item(0)) = True Then 'dgv_Agenda.CurrentRow.Cells("Age_id").Value()) Then
                dtt_agenda.Rows(i).Item(12) = visto
                dgv_Agenda.Rows(i).Cells(12).Style.BackColor = Color.RoyalBlue
            Else
                dtt_agenda.Rows(i).Item(12) = ""
            End If

            ' FINALIZADO
            Dim arre_medico As String()
            arre_medico = Split(opr_pedido.ConsultaMedicosGrupo(CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value())), ",")

            If opr_res.TieneFinalizado(dtt_agenda.Rows(i).Item(0)) >= 1 Then 'dgv_Agenda.CurrentRow.Cells("Age_id").Value()) Then
                dtt_agenda.Rows(i).Item(13) = visto
                dgv_Agenda.Rows(i).Cells(13).Style.BackColor = Color.Orange
                'dgv_Agenda.Rows(i).Cells(13).Value = "CERRADO"
            Else
                dtt_agenda.Rows(i).Item(13) = ""
            End If

        Next

    End Sub
    Private Sub dtp_CitaMedica_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles dtp_CitaMedica.DateChanged

        If var_fecha <> dtp_CitaMedica.SelectionRange.Start Then
            cambiaFecha()
            var_fecha = dtp_CitaMedica.SelectionRange.Start
        Else


        End If
    End Sub

    Private Sub cambiaFecha()
        lbl_AgendarDia.Text = Format(dtp_CitaMedica.SelectionRange.Start, "dd MMMM yyyy")
        actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))
    End Sub



    Private Sub dgv_Agenda_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles dgv_Agenda.Scroll
        dgv_Agenda.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
    End Sub

    Private Sub dgv_Medico_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dgv_Medico.Paint
        If blnAjustarCeldas = True Then
            blnAjustarCeldas = False
            dgv_Medico.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        End If
    End Sub

    Private Sub dgv_Medico_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles dgv_Medico.Scroll
        dgv_Medico.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
    End Sub

    Private Sub dgv_Medico_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Medico.CellClick

        If dgv_Medico.CurrentRow.Cells("med_id").Value <> 15 Then
            btn_certificadoM.Enabled = True
        Else
            btn_certificadoM.Enabled = False
        End If

        If med_Despacho <> CInt(dgv_Medico.CurrentRow.Cells("med_id").Value) Then
            actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))
            btn_Solicitud.Enabled = False

            dgv_Agenda.Visible = True
            dgv_AgendaDespacho.Visible = False
        Else
            If actualizaDtsAgendaDespacho(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value)) = True Then
                dgv_AgendaDespacho.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                dgv_AgendaDespacho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                dgv_AgendaDespacho.Columns("age_id").Visible = False
                dgv_AgendaDespacho.Columns("age_hora").HeaderText = "HORA"
                dgv_AgendaDespacho.Columns("age_hora").Width = 50
                dgv_AgendaDespacho.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgv_AgendaDespacho.Columns("age_fecha").Visible = False
                dgv_AgendaDespacho.Columns("pac_id").Visible = False
                dgv_AgendaDespacho.Columns("med_id").Visible = False
                dgv_AgendaDespacho.Columns("MED_NOMBRE").HeaderText = "MEDIC"
                dgv_AgendaDespacho.Columns("MED_NOMBRE").Visible = False
                dgv_AgendaDespacho.Columns("ped_id").Visible = False
                dgv_AgendaDespacho.Columns("age_resumen").HeaderText = "MEDICO"
                dgv_AgendaDespacho.Columns("age_resumen").Width = 500
                dgv_AgendaDespacho.Columns("age_ci").Visible = False
                dgv_AgendaDespacho.Columns("MED_DOC").Visible = False
                dgv_AgendaDespacho.Columns("age_estado").HeaderText = "ESTADO"
                dgv_AgendaDespacho.Columns("age_estado").Width = 100
                
                btn_Solicitud.Enabled = True

                'End If

                With dgv_AgendaDespacho
                    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .DefaultCellStyle.BackColor = Color.WhiteSmoke
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                End With
            End If
            dgv_Agenda.Visible = False
            dgv_AgendaDespacho.Visible = True

        End If

        lbl_MedicoCita.Text = dgv_Medico.CurrentRow.Cells("med_nombre").Value

    End Sub

    Private Sub CambiaColorBoton(ByVal boton As Windows.Forms.Button)
        boton.BackColor = Color.YellowGreen
    End Sub

    Private Sub RestableceColorBoton(ByVal boton As Windows.Forms.Button)
        boton.BackColor = Color.White
    End Sub


    Private Sub VerificaBotonPresionado(ByVal boton As Windows.Forms.Button)
        Select Case boton.ToString()
            Case "btn_AgendarPaciente"
                RestableceColorBoton(btn_AgendarActividad)

            Case "btn_AgendarActividad"
                RestableceColorBoton(btn_AgendarPaciente)

            Case "btn_AgenrarGrupo"
                RestableceColorBoton(btn_AgendarActividad)
        End Select
    End Sub

    Private Sub btn_AgendarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VerificaBotonPresionado(btn_AgendarPaciente)
    End Sub
    Private Sub btn_AgendarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VerificaBotonPresionado(btn_AgendarActividad)
    End Sub



    Private Sub btn_ssalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ssalir.Click
        Me.Close()
    End Sub

    Private Sub dgv_Agenda_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Agenda.CellClick

        habilitaBtns(1)

        indiceSeleccionado = dgv_Agenda.SelectedRows(0).Index
        'dgv_Agenda.CurrentRow.Cells("pac_id").Value() = CInt(dgv_Agenda.CurrentRow.Cells("pac_id").Value())

        grp_Accion.Visible = True

        btn_AgendarPaciente.Enabled = False
        btn_AgendarActividad.Enabled = False
        btn_gguardar.Enabled = False
        btn_Confirmar.Enabled = False

        Select Case dgv_Agenda.CurrentRow.Cells("age_estado").Value()
            Case "DISPONIBLE"
                btn_AgendarPaciente.Enabled = True
                btn_AgendarActividad.Enabled = True
                btn_gguardar.Enabled = True
                btn_Confirmar.Enabled = True

            Case "RESERVADA"
                btn_AgendarPaciente.Enabled = False
                btn_AgendarActividad.Enabled = False
                btn_gguardar.Enabled = False
                btn_Confirmar.Enabled = False
                lbl_AgendarA.Text = "Horario agendado para " & vbCrLf & dgv_Agenda.CurrentRow.Cells("age_resumen").Value & vbCrLf & "*** OCUPADO ***"
                var_label = "Horario agendado para " & vbCrLf & dgv_Agenda.CurrentRow.Cells("age_resumen").Value & vbCrLf & "*** OCUPADO ***"
                opr_pedido.VisualizaMensaje("Esta agenda se encuentra RESERVADA", 300)
                Exit Sub
        End Select

        Select dgv_Agenda.CurrentRow.Cells("age_resumen").Value()
            Case "FERIADO"
                btn_AgendarPaciente.Enabled = False
                btn_AgendarActividad.Enabled = False
                btn_gguardar.Enabled = False
                btn_Confirmar.Enabled = False

            Case "AGENDA WEB"
                btn_AgendarPaciente.Enabled = True
                btn_AgendarActividad.Enabled = True
                btn_gguardar.Enabled = True
                btn_Confirmar.Enabled = True
        End Select

        If dgv_Agenda.CurrentRow.Cells("age_tratamiento").Value() <> "" Then
            btn_CerAsist.Enabled = True
            btn_CerAsistTut.Enabled = True
            btn_CerVac.Enabled = True
            btn_CerVacTut.Enabled = True
        Else
            btn_CerAsist.Enabled = False
            btn_CerAsistTut.Enabled = False
            btn_CerVac.Enabled = False
            btn_CerVacTut.Enabled = False
        End If

        If dgv_Agenda.CurrentRow.Cells("age_finalizado").Value() = "Si" Then
            opr_pedido.VisualizaMensaje("Esta agenda se encuentra FINALIZADA", 300)
        End If

        If dgv_Agenda.CurrentRow.Cells("cer_str").Value() <> "" Then
            Dim arre_cert As String() = Split(dgv_Agenda.CurrentRow.Cells("cer_str").Value, "|")
            Dim param As String()
            Dim i As Integer
            For i = 0 To UBound(arre_cert) - 1
                param = Split(arre_cert(i), ",")

                Select Case param(0)
                    Case "1"
                        If param(1) = 1 Then
                            chk_CerAs.Checked = True
                        Else
                            chk_CerAs.Checked = False
                        End If
                    Case "2"
                        If param(1) = 1 Then
                            chk_CerAsiTut.Checked = True
                        Else
                            chk_CerAsiTut.Checked = False
                        End If
                    Case "3"
                        If param(1) = 1 Then
                            chk_certVac.Checked = True
                        Else
                            chk_certVac.Checked = False
                        End If
                    Case "4"
                        If param(1) = 1 Then
                            chk_cerVacTut.Checked = True
                        Else
                            chk_cerVacTut.Checked = False
                        End If
                End Select

            Next

            txt_CerTutor.Text = dgv_Agenda.CurrentRow.Cells("age_tutor").Value
            txt_CerCI.Text = dgv_Agenda.CurrentRow.Cells("age_ci").Value

            lbl_AgendarA.Text = "Horario agendado para " & vbCrLf & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & vbCrLf & "*** OCUPADO ***"
            var_label = "Horario agendado para " & vbCrLf & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & vbCrLf & "*** OCUPADO ***"
        Else
            For Each ctl1 As Control In Me.grp_Certificados.Controls
                If TypeOf ctl1 Is CheckBox Then
                    DirectCast(ctl1, CheckBox).Checked = False
                End If
            Next
            txt_CerTutor.Text = ""
            txt_CerCI.Text = ""
            lbl_AgendarA.Text = "¿ Qué desea agendar a las " & dgv_Agenda.CurrentRow.Cells("age_hora").Value & " ?" & vbCrLf & "*** DISPONIBLE ***"
            var_label = "¿ Qué desea agendar a las " & dgv_Agenda.CurrentRow.Cells("age_hora").Value & " ?" & vbCrLf & "*** DISPONIBLE ***"

            btn_AgendarPaciente.Enabled = True
            btn_AgendarActividad.Enabled = True
            btn_gguardar.Enabled = True
            btn_Confirmar.Enabled = True


        End If


    End Sub

    Private Sub cmb_Especialidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Especialidad.SelectedIndexChanged
        If cmb_Especialidad.Text = "Todas" Then
            actualizaDtsMedico(0, 0, Var_Vergrupo)
        Else
            If CInt(Mid(cmb_Especialidad.Text, 101, 110)) <> 0 Then
                actualizaDtsMedico(CInt(Mid(cmb_Especialidad.Text, 101, 110)), 0, Var_Vergrupo)
            Else
                actualizaDtsMedico(CInt(Mid(cmb_Especialidad.Text, 101, 110)), 1, Var_Vergrupo)
            End If
        End If
        dgv_Medico.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
    End Sub

    Private Sub btn_AgendarPaciente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgendarPaciente.Click
        'abro el formulario para seleccioanar un paciente
        Dim str_tagaux As String
        Dim tagaux As String()
        Dim tagrado As String()

        Dim frm_MDIChild As New frm_Paciente()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.sw_viene = True
        str_tagaux = Me.Tag
        frm_MDIChild.ShowDialog(Me.ParentForm)

        tagaux = Split(Me.Tag, "/*/")
        If UBound(tagaux) > 1 Then
            If tagaux(7) <> "" Then
                tagrado = Split(tagaux(7), "=")
                If tagrado(1) = "CLIENTE" Then
                    dgv_Agenda.CurrentRow.Cells("age_resumen").Value = "DESPACHO CLIENTE"
                End If
            End If
        End If
        'Me.Tag = str_tagaux

        'mantieneDatos() '

        'actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

        'RestaurarSeleccion()

    End Sub

    Public Sub LLena_datos_paciente_doc()
        'toma los datos del paciete que son dvueltos entagdel formulario
        'luego d haber seleccioando del otro formulario
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim parametrogrid() As String
        Dim str_texto, str_valor As String
        Dim boo_edad As Boolean = True
        Dim i, ii As Integer

        Dim fecha_nac As Date

        str_campos = Split(Me.Tag, "/*/")
        'Cuando creo doctor y regreso al formulario de pedido impide que se borre datos del paciente ya ingresados

        For i = 1 To UBound(str_campos)

            parametrogrid = Split(str_campos(i), "=")

            Select Case i

                Case 1
                    paciente = parametrogrid(1) & " "
                Case 2

                    paciente = paciente & parametrogrid(1)
                    dgv_Agenda.CurrentRow.Cells("pac_nombre").Value = Trim(paciente)

                Case 10
                    fecha_nac = Trim(parametrogrid(1))

                    '**********
                    'funcion para calcular la edad del paciente
                    Dim y, yn As Integer
                    Dim m, mn As Integer
                    Dim d, dn As Integer
                    y = Year(Now)
                    yn = Year(fecha_nac)
                    m = Month(Now)
                    mn = Month(fecha_nac)
                    d = Microsoft.VisualBasic.Day(Now)
                    dn = Microsoft.VisualBasic.Day(fecha_nac)
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

                    dgv_Agenda.CurrentRow.Cells("pac_edad").Value = Trim(edad) & " " & Trim(unidad)
                    Exit Sub

                Case 3
                    'direccion domicilio paciente
                    'dgv_Agenda.CurrentRow.Cells("med_nombre").Value = parametrogrid(1)

                Case 5
                    dgv_Agenda.CurrentRow.Cells("pac_id").Value = Trim(parametrogrid(1))
            End Select
        Next

    End Sub




    Private Sub dgv_Agenda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Agenda.KeyDown


        Select Case e.KeyCode
            Case Keys.Enter
                dgv_Agenda.CurrentRow.Cells("age_resumen").Value = Trim(txt_CitaGeneral.Text).ToUpper
                txt_CitaGeneral.Text = ""


            Case Keys.Delete

                If MsgBox("Desea borrar la agenda de las " & dgv_Agenda.CurrentRow.Cells("age_hora").Value & " ?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then

                    If dgv_Agenda.CurrentRow.Cells("age_cutaneas").Value = visto Or dgv_Agenda.CurrentRow.Cells("age_dermografismo").Value = visto Or dgv_Agenda.CurrentRow.Cells("age_receta").Value = visto Or dgv_Agenda.CurrentRow.Cells("age_tratamiento").Value = visto Then
                        opr_pedido.VisualizaMensaje("Esta agenda se encuentra en PROCESO, no se puede eliminar", 300)
                    Else
                        Dim SiNoGuardo As Boolean
                        'Operaciones al precionar DELETE sobre el grid
                        dgv_Agenda.CurrentRow.Cells("pac_nombre").Value = ""
                        dgv_Agenda.CurrentRow.Cells("pac_edad").Value = ""
                        dgv_Agenda.CurrentRow.Cells("age_resumen").Value = ""

                        opr_agenda.ModificaAgendaHora(CInt(dgv_Agenda.CurrentRow.Cells("age_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("ped_id").Value()), 0, CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), "", "", "", "", "", "DISPONIBLE", CInt(dgv_Agenda.CurrentRow.Cells("ped_turno").Value()), SiNoGuardo)

                        mantieneDatos()

                        actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

                        RestaurarSeleccion()
                    End If
                End If

            Case Keys.F3
                btn_SignosVitales.PerformClick()

            Case Keys.F4
                btn_HistoriaClinica.PerformClick()

            Case Keys.F5
                btn_PruebaCutanea.PerformClick()

            Case Keys.F6
                btn_Interpretacion.PerformClick()
        End Select

        
    End Sub

    Private Sub RestaurarSeleccion()
        ' Restaura la selección a la fila previamente seleccionada si el índice de fila es válido
        If currentRowIndex >= 0 And currentRowIndex < dgv_Agenda.Rows.Count Then
            dgv_Agenda.CurrentCell = dgv_Agenda.Rows(currentRowIndex).Cells(1)
        End If
    End Sub


    Private Sub btn_gguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gguardar.Click


        If dgv_Agenda.CurrentRow.Cells("pac_nombre").Value() <> "" Then


            Dim Supo As String = Nothing
            str_cer = Nothing

            If opr_agenda.ExisteAgendaHora(Format(dtp_CitaMedica.SelectionRange.Start, "dd-MM-yyyy"), dgv_Agenda.CurrentRow.Cells("age_hora").Value, "Medico", dgv_Agenda.CurrentRow.Cells("med_id").Value) >= 1 Then
                If MsgBox("La agenda para ese dia se encuentra ocupada, desea modificar la agenda ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then

                    For Each ctlCert As Control In grp_Certificados.Controls
                        If TypeOf ctlCert Is CheckBox Then
                            If DirectCast(ctlCert, CheckBox).Checked = True Then
                                str_cer = str_cer & ctlCert.Tag & ",1|"
                            Else
                                str_cer = str_cer & ctlCert.Tag & ",0|"
                            End If
                        End If
                    Next


                    opr_agenda.ModificaAgendaHora(CInt(dgv_Agenda.CurrentRow.Cells("age_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("ped_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("pac_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), Trim(dgv_Agenda.CurrentRow.Cells("pac_edad").Value()), Trim(dgv_Agenda.CurrentRow.Cells("age_resumen").Value()), Trim(str_cer), Trim(txt_CerTutor.Text), Trim(txt_CerCI.Text), "CONFIRMADO", CInt(dgv_Agenda.CurrentRow.Cells("ped_turno").Value()), SiNoGuardo)

                    mantieneDatos()

                    actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

                    RestaurarSeleccion()


                Else
                    'opr_agenda.CreaAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), VarPac, VarMed, VarPed, resumen)
                    'opr_agenda.ModificaAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), VarPac, VarMed, VarPed, resumen)
                End If
            Else
                'opr_agenda.CreaAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), VarPac, VarMed, VarPed, resumen)
                Dim hora As String = dgv_Agenda.CurrentRow.Cells("age_hora").Value.ToString()
                pac_id = dgv_Agenda.CurrentRow.Cells("pac_id").Value()
                Dim med_id As Integer = dgv_Agenda.CurrentRow.Cells("med_id").Value()

                age_id = dgv_Agenda.CurrentRow.Cells("age_id").Value()

                Dim turno As String = Nothing
                Dim edad As String





                If IsDBNull(dgv_Agenda.CurrentRow.Cells("ped_id").Value()) Or dgv_Agenda.CurrentRow.Cells("ped_id").Value() = 0 Then
                    ped_id = opr_pedido.LeerMaxPedido() + 1
                    'ped_id = ped_id + 1

                    'age_id = opr_agenda.LeeMaximoAgenda() + 1
                    'ped_id = ped_id + 1
                Else
                    ped_id = dgv_Agenda.CurrentRow.Cells("ped_id").Value()
                    age_id = dgv_Agenda.CurrentRow.Cells("age_id").Value()
                End If

                If pac_id <> 0 Or med_id <> 0 Then

                    turno = Format(opr_pedido.LeerMaxturno(Mid(cmb_convenio.Text, 1, 50), Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy"), Val(1), False), "000#")

                    If turno > 0 Then
                        turno = Trim(turno)
                    End If

                    param_pac = Split(opr_pac.Devuelvepaciente(pac_id), "º")
                    param_conv = Split(cmb_convenio.Text, "/")

                    opr_pac.buscapacienteAgendaMedica(param_pac(0), edad, unidad, pac_dir, pac_sexo, pac_fecnac, pac_fono, pac_email)


                    opr_pedido.ingreso_OrdenAgenda(pac_id, Format(Now(), "dd-MM-yyyy"), Trim(cmb_convenio.Text), opr_agenda.BuscaExamenesSolicita(1, Trim(Mid(cmb_convenio.Text, 1, 50))), Trim(param_conv(0)), edad, unidad, pac_sexo, turno, ped_id, med_id, turno)


                    Dim i As Integer
                    Dim arre_medico As String()
                    arre_medico = Split(opr_pedido.ConsultaMedicosGrupo(CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value())), ",")

                    If UBound(arre_medico) > 2 Then
                        For i = 0 To UBound(arre_medico) - 1
                            opr_pedido.GestionaConsulta(opr_pedido.LeerMaxConsultaMedico(), arre_medico(i), pac_id, age_id, "", "", "PENDIENTE", "Insert", "")
                        Next
                    Else
                        opr_pedido.GestionaConsulta(opr_pedido.LeerMaxConsultaMedico(), CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), pac_id, age_id, "", "", "PENDIENTE", "Insert", "")
                    End If

                    'OBTENGO los certificados escojidosB


                    For Each ctlCert As Control In grp_Certificados.Controls
                        If TypeOf ctlCert Is CheckBox Then
                            If DirectCast(ctlCert, CheckBox).Checked = True Then
                                str_cer = str_cer & ctlCert.Tag & ",1|"
                            Else
                                str_cer = str_cer & ctlCert.Tag & ",0|"
                            End If
                        End If
                    Next


                    opr_agenda.ModificaAgendaHora(age_id, ped_id, pac_id, CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), Trim(edad) & " " & Trim(unidad), Trim(dgv_Agenda.CurrentRow.Cells("age_resumen").Value()), Trim(str_cer), Trim(txt_CerTutor.Text), Trim(txt_CerCI.Text), "CONFIRMADO", turno, SiNoGuardo)

                    opr_pedido.InsertaEncuesta(age_id)

                    'opr_agenda.ActualizaCertificado(age_id, pac_id, ped_id, str_cer, dgv_Agenda.CurrentRow.Cells("age_fecha").Value(), Trim(txt_CerTutor.Text), Trim(txt_CerCI.Text), "Insertar", SiNoGuardo)

                    If SiNoGuardo = True Then
                        dgv_Agenda.CurrentRow.Cells("ped_id").Value() = ped_id
                        dgv_Agenda.CurrentRow.Cells("ped_turno").Value() = turno
                        opr_pedido.VisualizaMensaje("Agenda registrada satisfactoriamente", g_tiempo)
                        lbl_AgendarA.Text = "Horario agendado para " & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & "     *** OCUPADO ***"

                        mantieneDatos()

                        actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

                        RestaurarSeleccion()


                    Else
                        opr_pedido.VisualizaMensaje("No se pudo registrar la agenda", g_tiempo)
                    End If
                Else
                    opr_pedido.VisualizaMensaje("Debe seleccionar un paciente y medico tratante", g_tiempo)
                End If
            End If
        Else
            opr_pedido.VisualizaMensaje("Debe seleccionar un paciente", g_tiempo)
        End If

    End Sub

    Private Sub mantieneDatos()

        If dgv_Agenda.CurrentRow IsNot Nothing Then
            currentRowIndex = dgv_Agenda.CurrentRow.Index
        End If

        'dgv_Agenda.Rows(indiceSeleccionado).Selected = True
        'dgv_Agenda.FirstDisplayedScrollingRowIndex = indiceSeleccionado


        dgv_Agenda.CurrentRow.Cells("pac_id").Value() = pac_id
        dgv_Agenda.CurrentRow.Cells("pac_nombre").Value() = paciente
        dgv_Agenda.CurrentRow.Cells("pac_edad").Value() = edad & " " & unidad
        dgv_Agenda.CurrentRow.Cells("ped_id").Value() = ped_id
        dgv_Agenda.CurrentRow.Cells("Age_id").Value() = age_id

    End Sub

    Private Sub mantieneDatosDespacho()

        If dgv_AgendaDespacho.CurrentRow IsNot Nothing Then
            currentRowIndex = dgv_AgendaDespacho.CurrentRow.Index
        End If

        dgv_AgendaDespacho.CurrentRow.Cells("pac_id").Value() = pac_id
        dgv_AgendaDespacho.CurrentRow.Cells("pac_nombre").Value() = paciente
        dgv_AgendaDespacho.CurrentRow.Cells("pac_edad").Value() = edad & " " & unidad
        dgv_AgendaDespacho.CurrentRow.Cells("ped_id").Value() = ped_id
        dgv_AgendaDespacho.CurrentRow.Cells("Age_id").Value() = age_id

    End Sub

    Private Sub dgv_Agenda_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Agenda.CellDoubleClick
        If dgv_Agenda.CurrentRow.Cells("age_estado").Value() = "CONFIRMADO" Then
            If Not ExisteForm("frm_ConsultaMedico") Then
                Dim frm_MDIChild As New frm_ConsultaMedico()
                'frm_MDIChild.frm_refer_main = Me.ParentForm
                frm_MDIChild.Age_Id = dgv_Agenda.CurrentRow.Cells("age_id").Value()
                frm_MDIChild.Ped_Id = dgv_Agenda.CurrentRow.Cells("ped_id").Value()
                frm_MDIChild.med_id = dgv_Agenda.CurrentRow.Cells("Med_id").Value()
                frm_MDIChild.pac_doc = dgv_Agenda.CurrentRow.Cells("pac_doc").Value()
                frm_MDIChild.ped_turno = dgv_Agenda.CurrentRow.Cells("ped_turno").Value()
                frm_MDIChild.age_resumen = dgv_Agenda.CurrentRow.Cells("age_resumen").Value()
                frm_MDIChild.ShowDialog(Me.ParentForm)

                mantieneDatos()

                actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

                RestaurarSeleccion()

            End If
        Else
            opr_pedido.VisualizaMensaje("GUARDE O CONFIRME LA AGENDA para continuar con la consulta", 300)
        End If
    End Sub



    Private Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.ParentForm.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function


    Private Sub btn_SignosVitales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SignosVitales.Click

        If dgv_Agenda.CurrentRow.Cells("age_estado").Value() = "CONFIRMADO" Then


            Dim str_tagaux As String
            str_tagaux = Me.Tag
            Dim frm_MDIChild As New frm_SignosVitales()
            frm_MDIChild.frm_refer_main = Me.ParentForm

            frm_MDIChild.pac_id = CInt(dgv_Agenda.CurrentRow.Cells("pac_id").Value())
            frm_MDIChild.lbl_paciente.Text = dgv_Agenda.CurrentRow.Cells("pac_nombre").Value()
            frm_MDIChild.lbl_edad.Text = dgv_Agenda.CurrentRow.Cells("pac_edad").Value()
            frm_MDIChild.ShowDialog(Me.ParentForm)
            Me.Tag = str_tagaux

            mantieneDatos()

            actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

            RestaurarSeleccion()



        Else
            opr_pedido.VisualizaMensaje("Agende un paciente para registrar signos vitales", 300)
        End If

    End Sub

    Private Sub btn_HistoriaClinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HistoriaClinica.Click



        If dgv_Agenda.CurrentRow.Cells("age_estado").Value() = "CONFIRMADO" Then

            'btn_gguardar.PerformClick()

            'Dim str_ped_id As String
            Dim frm_MDIChild As New frm_HistoriaClinica()
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.pac_id = CInt(dgv_Agenda.CurrentRow.Cells("pac_id").Value())
            frm_MDIChild.lbl_paciente.Text = dgv_Agenda.CurrentRow.Cells("pac_nombre").Value()
            frm_MDIChild.lbl_edad.Text = dgv_Agenda.CurrentRow.Cells("pac_edad").Value()
            frm_MDIChild.var_Convenio = Trim(cmb_convenio.Text)
            frm_MDIChild.Var_Ped_id = dgv_Agenda.CurrentRow.Cells("ped_id").Value()

            frm_MDIChild.ShowDialog(Me.ParentForm)
            mantieneDatos()

            actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

            RestaurarSeleccion()
        Else
            opr_pedido.VisualizaMensaje("Agende un paciente para registrar la historia clínica", 300)
        End If


    End Sub

    Private Sub btn_PruebaCutanea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PruebaCutanea.Click
        If dgv_Agenda.CurrentRow.Cells("age_estado").Value() = "CONFIRMADO" Then

            Dim frm_MDIChild As New frm_IngresoCutaneas
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.lbl_pacD.Text = dgv_Agenda.CurrentRow.Cells("pac_nombre").Value()
            frm_MDIChild.lbl_edadPac.Text = dgv_Agenda.CurrentRow.Cells("pac_edad").Value()
            frm_MDIChild.ped_id = dgv_Agenda.CurrentRow.Cells("ped_id").Value()
            frm_MDIChild.Age_id = dgv_Agenda.CurrentRow.Cells("Age_id").Value()
            frm_MDIChild.Pac_id = dgv_Agenda.CurrentRow.Cells("Pac_id").Value()

            frm_MDIChild.ShowDialog(Me.ParentForm)

            mantieneDatos()

            actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

            RestaurarSeleccion()

        Else
            opr_pedido.VisualizaMensaje("Agende un paciente para reportar pruebas cutáneas", 300)
        End If

        '''''***
    End Sub

    Private Sub btn_Interpretacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Interpretacion.Click
        If dgv_Agenda.CurrentRow.Cells("age_estado").Value() = "CONFIRMADO" Then

            Dim frm_MDIChild As New frm_Interpretacion
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.lbl_paciente.Text = dgv_Agenda.CurrentRow.Cells("pac_nombre").Value()
            frm_MDIChild.Ped_id = dgv_Agenda.CurrentRow.Cells("Ped_id").Value()
            frm_MDIChild.Pac_id = dgv_Agenda.CurrentRow.Cells("Pac_id").Value()
            frm_MDIChild.Age_id = dgv_Agenda.CurrentRow.Cells("Age_id").Value()
            frm_MDIChild.ShowDialog(Me.ParentForm)

            mantieneDatos()

            actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

            RestaurarSeleccion()

        Else
            opr_pedido.VisualizaMensaje("Agende un paciente para reportar pruebas cutáneas", 300)
        End If
    End Sub



    Private Sub btn_AgendarActividad_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgendarActividad.Click
        Dim str_tagaux As String
        str_tagaux = Me.Tag
        Dim edad, unidad, pac_dir, pac_sexo, pac_fono, pac_email As String
        Dim pac_fechanac As Date
        Dim frm_MDIChild As New frm_Actividad()

        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.med_id = dgv_Medico.CurrentRow.Cells("med_id").Value
        frm_MDIChild.lbl_Medico.Text = Trim(lbl_MedicoCita.Text)
        'frm_MDIChild.cmb_medico.Text
        frm_MDIChild.ShowDialog(Me.ParentForm)
        Dim opr_pac As New Cls_Paciente()
        opr_pac.buscapacienteAgendaMedica("0000000001", edad, unidad, pac_dir, pac_sexo, pac_fechanac, pac_fono, pac_email)

        dgv_Agenda.CurrentRow.Cells("pac_nombre").Value = System.Configuration.ConfigurationSettings.AppSettings("TITULO") & ": RESERVADO"
        dgv_Agenda.CurrentRow.Cells("pac_id").Value = 1
        'dgv_Agenda.CurrentRow.Cells("med_id").Value = Trim(Mid(frm_MDIChild.cmb_medico.Text, 51, 60))
        dgv_Agenda.CurrentRow.Cells("pac_edad").Value = edad & " " & unidad
        dgv_Agenda.CurrentRow.Cells("age_resumen").Value = Trim(Mid(frm_MDIChild.cmb_Actividad.Text, 1, 100))
        var_actividad = Trim(frm_MDIChild.cmb_Recursividad.Text)

        mantieneDatos()

        actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

        RestaurarSeleccion()


    End Sub




    Private Function obtieneDiagnostico(ByVal Age_id As Integer) As String
        Return opr_res.ConsultaDiagnostico(Age_id)
    End Function

    Private Function obtieneCie10(ByVal Age_id As Integer) As String
        Return opr_res.ConsultaCie10(Age_id)
    End Function

    Private Function obtieneSER_ID(ByVal Age_id As Integer) As String
        Return opr_res.ConsultaSer_Id(Age_id)
    End Function

    Private Function obtieneCert_Tipo(ByVal Cer_id As Integer) As String
        Return opr_res.ConsultaCert_tipo(Cer_id)
    End Function



    Private Sub DevuelveFrascos(ByVal SER_DES As String)

        Select Case SER_DES

            Case "SERIE INICIAL" '3 FRASCOS
                'ETIQUETA 1
                var_sol = "SOLUCIONES 1-2-3"
                var_fras = "3 FRASCOS"
                var_unid = "2.5 ml/5.5 ml/5.5 ml"

            Case "SERIE REFUERZO" ' 2 FRASCOS
                var_sol = "SOLUCIONES 1-2"
                var_fras = "2 FRASCOS"
                var_unid = "5.5 ml/5.5 ml"

            Case "FRASCO 1 + INSECTOS" '(ESPECIAL + INSECTOS)
                var_sol = "SOLUCIONES 2"
                var_fras = "2 FRASCOS"
                var_unid = "5.5 ml/5.5 ml"

            Case "FRASCO 1 + 2 + INSECTOS" 'SERIE COMPLETA: (ESPECIAL + INSECTOS)
                var_sol = "SOLUCIONES 1-2-3"
                var_fras = "3 FRASCOS"
                var_unid = "5.5 ml/5.5 ml/5.5 ml"

            Case "LIQUIDO DE ALERGENO"  'LIQUIDO DE ALERGENO
                var_sol = "SOLUCION INDIVIDUAL"
                var_fras = "1 FRASCO"
                var_unid = "2.5 ml o 5.5 ml "

            Case "ACNE"
                var_sol = "SOLUCION DE ACNE"
                var_fras = "1 FRASCO"
                var_unid = "2.5 ml o  5.5 ml "
        End Select

    End Sub

    Private Sub ImprimeCertificados(ByVal cer_id As Integer)

        Dim str_sql, texto, cie10, frascos, cert_tipo, diagnostico As String
        Dim obj_reporte As New rpt_Certificados()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        cert_tipo = obtieneCert_Tipo(cer_id)

        Select Case cer_id
            Case 1 : texto = "Certifico que el paciente: " & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & " , con CI/PASAPORTE: " & dgv_Agenda.CurrentRow.Cells("pac_doc").Value & " se presento el día " & Mid(dgv_Agenda.CurrentRow.Cells("age_fecha").Value, 1, 10) & " a la consulta de especialidad de alergia, y se encuentra recibiendo tratamiento."

            Case 2 : texto = "Certifico que el paciente: " & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & " , con CI/PASAPORTE: " & dgv_Agenda.CurrentRow.Cells("pac_doc").Value & " se presento el día " & Mid(dgv_Agenda.CurrentRow.Cells("age_fecha").Value, 1, 10) & " a la consulta de especialidad de alergia, en compañía de su tutor: " & Trim(txt_CerTutor.Text) & " con CI: " & Trim(txt_CerCI.Text) & " y se encuentra recibiendo tratamiento."

            Case 3
                cie10 = obtieneCie10(dgv_Agenda.CurrentRow.Cells("Age_id").Value)
                DevuelveFrascos(obtieneSER_ID(dgv_Agenda.CurrentRow.Cells("Age_id").Value))
                texto = "Certifico que el paciente: " & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & " , con CI/PASAPORTE: " & dgv_Agenda.CurrentRow.Cells("pac_doc").Value & " presenta un proceso alérgico con diagnostico de  " & cie10 & " por lo que se envía una serie de vacunas para su tratamiento, consistente en: " & var_fras & ",  " & var_sol & " mas jeringuillas descartables de 1 c.c. o de insulina para su aplicacion."

            Case 4
                cie10 = obtieneCie10(dgv_Agenda.CurrentRow.Cells("Age_id").Value)
                DevuelveFrascos(obtieneSER_ID(dgv_Agenda.CurrentRow.Cells("Age_id").Value))
                texto = "Certifico que " & Trim(txt_CerTutor.Text) & " con CI: " & Trim(txt_CerCI.Text) & " lle a en su equipaje una serie de vacunas consistente en: " & var_fras & ",  " & var_sol & " mas jeringuillas descartables de 1 c.c. o de insulina para su aplicacion del tratamiemto del paciente: " & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & " , con CI/PASAPORTE: " & dgv_Agenda.CurrentRow.Cells("pac_doc").Value & " que presenta un proceso alérgico con diagnostico de  " & cie10 & " "
                'en compañía de su tutor:  y se encuentra recibiendo tratamiento."

            Case 5
                cie10 = obtieneCie10(dgv_Agenda.CurrentRow.Cells("Age_id").Value)
                diagnostico = obtieneDiagnostico(dgv_Agenda.CurrentRow.Cells("Age_id").Value)
                'DevuelveFrascos(obtieneSER_ID(dgv_Agenda.CurrentRow.Cells("Age_id").Value))
                texto = "Por el presente me permito certificar que: " & Trim(dgv_Agenda.CurrentRow.Cells("pac_nombre").Value) & ", con CI/PASAPORTE: " & Trim(dgv_Agenda.CurrentRow.Cells("pac_doc").Value) & " de " & Trim(dgv_Agenda.CurrentRow.Cells("pac_edad").Value) & " de edad, presenta el siguiente diagnóstico médico: " & vbCrLf & vbCrLf & diagnostico & cie10

            Case 7
                texto = "LA PRUEBA CUTANEA: Es una manera de evaluar la presencia de anticuerpos que causan" & _
            "alergia en el paciente. Consiste en la introducción de pequeñas dosis de alérgenos en la piel del" & _
            "paciente. Un alérgeno es una sustancia, probablemente causante de la alergia, por ejemplo: gato," & _
            "pólenes, hongos, ácaros.Después de la aplicación se observa la respuesta del paciente: en una" & _
            "prueba positiva se notará la aparición de una roncha o elevación de la piel sobre una mancha" & _
            "roja. Los resultados se leen de 15 a 20 min, después de la aplicación del alérgeno. Existen dos" & _
            "métodos de Pruebas Cutáneas:• PRICK: Se aplica una gota de cada alérgeno sobre el brazo o" & _
            "espalda y se hace un pequeño raspado sobre la gota para que penetren las partículas del" & _
            "alérgeno muy superficial en la piel. • INTRADERMICO: Es la inyección de pequeñas cantidades" & _
            "de alérgeno directamente en la capa superficial de la piel. Se realiza si el resultado de la prueba" & _
            "Prick es dudoso.En caso de tener una sensibilidad alérgica específica a uno de los alérgenos," & _
            "aparecerá una roncha roja con comezón después de unos 20 min. (causada por la liberación de" & _
            "histamina). Estas reacciones positivas inmediatas, desaparecerán de 30 a 60 min. y" & _
            "generalmente la comezón no requiere de tratamiento. A veces de observa reacción tardía que" & _
            "consta de una roncha o hinchazón en el lugar de la prueba, 4-8 hrs después. Esto se ve" & _
            "mayormente en lugares de pruebas intradérmicas. Estas reacciones no son severas y" & _
            "desaparecen en días. Le pedimos medirlas y reportarlas con la doctora en la próxima cita." & _
            "La interpretación de la importancia clínica de una prueba, requiere conocimiento a fondo de los" & _
            "alérgenos. Reacciones positivas en la prueba cutánea nos indican la existencia de anticuerpos" & _
            "alérgicos, pero no necesariamente tienen que tener correlación con los síntomas clínicos. Son" & _
            "importantes en Ecuador según nos indicaron los estudios del Dr. Plutarco Naranjo los alérgenos" & _
            "de céspedes, malezas, hongos, ácaros de polvo casero y de almacenamiento, epitelios de gato," & _
            "perro y cucaracha. A veces son agregados algunos alimentos. SÍ SE PUEDE Seguir inhalando" & _
            "sprays nasales contra rinitis alérgica como pero no el día de la Prueba. No hay problema con los" & _
            "aerosoles y polvo seco contra asma (Combivent, Seretide, Ventolin y otros), antileucotrienos y vía" & _
            "oral no interfieren con la prueba y se tienen que seguir tal como prescritos.NO DEBE tomar antihistamínicos" & _
            "de prescripción o comprados sin receta 5 días antes de la prueba. Incluye tabletas" & _
            "contra la gripa, sinusitis y medicamentos para la comezón o ronchas. En algunos casos se" & _
            "suspenderán los anti-histamínicos por más tiempo. Las tabletas para dormir y medicinas que se" & _
            "prescriben contra depresión o ansiedad, como amitriptilina tiene actividad anti - histamínica y se" & _
            "tienen que dejar de tomar mínimo por 2 semanas antes de la Prueba Cutánea, siempre" & _
            "consultando con su médico. Por favor comente al médico si toma estos medicamentos para tomar" & _
            "las precauciones adecuadas.Las pruebas cutáneas y la inmunoterapia de inicio, las realiza y" & _
            "aplica una enfermera cuidadosamente preparada y en mi presencia, dado que rara vez" & _
            "reacciones adversas requieren de tratamiento inmediato. Estas reacciones pueden consistir en" & _
            "uno o todos los síntomas siguientes: comezón en ojos, nariz, garganta, tapazón nasal, fluido" & _
            "nasal, falta de aire, o sensación de garganta o pecho cerrado, sibilancias, mareo, desmayo," & _
            "náuseas, vomito, ronchas, comezón en todo en cuerpo y choque anafiláctico, este último se ha" & _
            "descrito a nivel mundial bajo circunstancias extremas. Todas estas reacciones pasan muy rara" & _
            "vez.Después de la Prueba, pasara a consulta, para comentar acerca del saneamiento ambiental y" & _
            "el tratamiento con inmunoterapia. Le pedimos su plena atención en la prueba y la consulta, por" & _
            "eso recomendamos no traer niños pequeños, o en caso de ser niños no traer hermanitos, para" & _
            "que toda la atención sea hacia el paciente. El tiempo que le fue asignado para la prueba es" & _
            "exclusivo para usted ya que tenemos que preparar específicamente algunos alérgenos.Si por" & _
            "alguna razón se le hace imposible venir a la prueba tiene que cancelar la cita con 48 hrs. de" & _
            "anticipación, para que no se le cobre. Por favor sea consciente, ya que rechazamos pacientes" & _
            "debido a que la agenda está llena de lunes a viernes." & _
            "INMUNOTERAPIALa enfermedad que usted tiene es una alergia a uno o varios alérgenos." & _
            "Las sustancias que le provocaron las ronchas en la prueba cutánea están anotadas en la hoja de" & _
            "resultados.El único tratamiento hoy en día reconocido por la Organización Mundial de la Salud" & _
            "para atacar la causa de la alergia y que reduce sus síntomas o hasta curar las reacciones" & _
            "alérgicas es la inmunoterapia subcutánea(inyectada) que es la que manejamos o sublingual." & _
            "La idea de la inmunoterapia es estimular el cuerpo repetitivamente con lo que le causa la alergia, con" & _
            "dosis pequeñas que el cuerpo aguanta.Cada aplicación inyectada va aumentando poco a poca la" & _
            "dosis, además que los frascos son cada vez más concentrados. De esta manera el estímulo es" & _
            "cada vez mayor y al final de unos meses se llegará a la dosis de mantenimiento que son 1000 -" & _
            "10,000x más que la dosis inicial. Como las aplicaciones son constantes, con intervalos regulares" & _
            "entre sí, el cuerpo empieza a generar primero tolerancia y después protección con" & _
            "inmunoglobulinas contra lo que causa alergia." & _
            "INMUNOTERAPIA SUBCUTANEA: Entre 3/4meses es el momento en que se ve mejoría clínica o" & _
            "crisis menos frecuentes, lo que nos permitirá bajar poco a poco las dosis en los medicamentos." & _
            "BASES CIENTÍFICASSe ha demostrado que en los 3-4 meses de tratamiento la inmunoglobulina" & _
            "causante de alergias empieza a bajar y la inmunoglobulina de protección empieza a aumentar en" & _
            "la sangre del paciente. En niños el inicio temprano de inmunoterapia puede prevenir el desarrollo" & _
            "de asma y reducir la aparición de nuevas alergias.Por su seguridad exigimos que la primera dosis" & _
            "de un frasco nuevo de la inmunoterapia sea aplicada en el consultorio y que el paciente espere 30" & _
            "min después de la aplicación.Si el paciente es menor de edad, un padre o tutor debe estar" & _
            "presente durante la espera." & _
            "Consentimiento informado para prueba cutánea e inicio de inmunoterapiaHe leído las hojas de" & _
            "información para el paciente acerca de la prueba cutánea e inmunoterapia y la entiendo. Estoy de" & _
            "acuerdo de que en caso que se presente alguna reacción adversa el medico encargado me trate" & _
            "para protegerme contra estas reacciones.Reconozco que con el hecho de mi firma doy" & _
            "autorización a Labalergia de cobrarme el tratamiento de inmunoterapia una vez que acepte su" & _
            "preparación, y si decido interrumpir el tratamiento ya que la inmunoterapia es personalizada y no" & _
            "le sirve a nadie más que al paciente en tratamiento"

        End Select

        Select Case cer_id
            Case 1, 2, 3, 4
                str_sql = "select " & cer_id & " as CER_ID, '" & cert_tipo & "' AS CER_TIPO,'" & dgv_Agenda.CurrentRow.Cells("Age_fecha").Value & "' as AGE_FECHA, '" & Trim(txt_CerTutor.Text) & "' as AGE_TUTOR, '" & Trim(txt_CerCI.Text) & "' as AGE_CI, '" & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & "' as PACIENTE, '" & texto & "' as TEXTO " & _
                "from vacunaTratamiento as vt, agenda as a " & _
                "WHERE vt.AGE_ID = a.age_id and a.age_id = " & dgv_Agenda.CurrentRow.Cells("Age_id").Value & ""
            Case 5
                str_sql = "select " & cer_id & " as CER_ID, '" & cert_tipo & "' AS CER_TIPO,'" & dgv_Agenda.CurrentRow.Cells("Age_fecha").Value & "' as AGE_FECHA, '" & Trim(txt_CerTutor.Text) & "' as AGE_TUTOR, '" & Trim(txt_CerCI.Text) & "' as AGE_CI, '" & dgv_Agenda.CurrentRow.Cells("pac_nombre").Value & "' as PACIENTE, '" & texto & "' as TEXTO " & _
                "from agenda as a " & _
                "WHERE a.age_id = " & dgv_Agenda.CurrentRow.Cells("Age_id").Value & ""
            Case 6
                str_sql = "select CERP_ID AS CER_ID, CERP_TITULO as CER_TIPO, CERP_FECHA AS AGE_FECHA, '' as AGE_TUTOR, '' AS AGE_CI, '' AS PACIENTE, CERP_CUERPO  AS TEXTO " & _
                "from certificadoPaciente " & _
                "where AGE_ID = " & age_id & ""

            Case 7
                str_sql = "select AGE_CONSENTIMIENTO" & _
                "from agenda " & _
                "where AGE_ID = " & age_id & ""

        End Select

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        frm_MDIChild.Text = "CERTIFICADOS"
        frm_MDIChild.ShowDialog(Me.ParentForm)


        mantieneDatos()

        actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

        RestaurarSeleccion()


        'opr_pdf.ExportToPDF(obj_reporte, "RECETA-" & Age_id & " " & lbl_paciente.Text, g_pathFolderReceta)

    End Sub

    Private Sub txt_CitaGeneral_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CitaGeneral.KeyDown
        If e.KeyCode = Keys.Enter Then
            'dgv_SerieVac.CurrentRow.Cells("ser_id").Value()
            dgv_Agenda.CurrentRow.Cells("age_resumen").Value = Trim(txt_CitaGeneral.Text).ToUpper
        ElseIf e.KeyCode = Keys.Delete Then
            dgv_Agenda.CurrentRow.Cells("age_resumen").Value = ""

        End If
    End Sub


    Private Sub btn_CerAsist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerAsist.Click

        ImprimeCertificados(1)

    End Sub

    Private Sub btn_CerAsistTut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerAsistTut.Click

        ImprimeCertificados(2)

    End Sub

    Private Sub btn_CerVac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerVac.Click

        ImprimeCertificados(3)

    End Sub

    Private Sub btn_CerVacTut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CerVacTut.Click
        ImprimeCertificados(4)
    End Sub


    ''Private Sub dgv_Agenda_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_Agenda.SelectionChanged
    ''    If dgv_Agenda.CurrentRow IsNot Nothing Then
    ''        currentRowIndex = dgv_Agenda.CurrentRow.Index
    ''    End If
    ''End Sub



    Private Sub btn_ImpAgenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpAgenda.Click
        Dim str_sql As String
        Dim obj_reporte As New rpt_AgendaConsulta()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        str_sql = "select agenda.age_id, agenda.age_hora, agenda.age_fecha, (paciente.PAC_APELLIDO  + ' ' + paciente.PAC_NOMBRE) as PAC_NOMBRE, PAC_EDAD, medico.MED_NOMBRE,  agenda.age_resumen,age_tutor, age_ci, case when paciente.pac_doc = '0000000000' then '' else paciente.pac_doc end as pac_doc, especialidad.esp_desc " & _
                  "from agenda, paciente, medico, especialidad " & _
                  "where medico.ESP_ID = especialidad.esp_id and paciente.PAC_ID = agenda.pac_id and medico.med_id = agenda.med_id and agenda.age_fecha between '" & Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_CitaMedica.SelectionRange.Start, "dd/MM/yyyy") & " 23:59:59' and age_tipo = 'Medico' and medico.med_id = " & dgv_Agenda.CurrentRow.Cells("med_id").Value() & " " & _
                  "order by agenda.age_id asc"

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        frm_MDIChild.Text = "AGENDA MEDICA"
        frm_MDIChild.ShowDialog(Me.ParentForm)


        'opr_pdf.ExportToPDF(obj_reporte, "RECETA-" & Age_id & " " & lbl_paciente.Text, g_pathFolderReceta)



        mantieneDatos()

        actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

        RestaurarSeleccion()
    End Sub


    Private Sub btn_certificadoM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_certificadoM.Click
        ImprimeCertificados(5)
    End Sub


    Private Sub btn_Confirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirmar.Click

        If dgv_Agenda.CurrentRow.Cells("ped_id").Value <> 0 Then
            If dgv_Agenda.CurrentRow.Cells("age_resumen").Value = "AGENDA WEB" Then
                'If dgv_Agenda.CurrentRow.Cells("age_estado").Value <> "CONFIRMADO" Then
                Dim parametros As String
                Dim SiNoGuardo As Boolean
                param_pac = Split(opr_pac.Devuelvepaciente(dgv_Agenda.CurrentRow.Cells("pac_id").Value), "º")
                param_conv = Split(cmb_convenio.Text, "/")

                opr_pac.buscapacienteAgendaMedica(param_pac(0), edad, unidad, pac_dir, pac_sexo, pac_fecnac, pac_fono, pac_email)

                param_conv = Split(cmb_convenio.Text, "/")


                parametros = Format(Now, "dd-mm-yyyy") & "/" & param_conv(0) & "/" & dgv_Agenda.CurrentRow.Cells("ped_turno").Value()

                If opr_pedido.GuardarPedidoAgenda(parametros, CLng(dgv_Agenda.CurrentRow.Cells("pac_id").Value), CLng(dgv_Agenda.CurrentRow.Cells("ped_id").Value), 1, opr_agenda.BuscaExamenesSolicita(1, Trim(Mid(cmb_convenio.Text, 1, 50))), Format(Now(), "dd-MM-yyyy"), edad, unidad, pac_sexo, dgv_Agenda.CurrentRow.Cells("med_id").Value, CLng(dgv_Agenda.CurrentRow.Cells("ped_turno").Value), "Update") > 0 Then

                    opr_agenda.ModificaAgendaHora(dgv_Agenda.CurrentRow.Cells("age_id").Value(), dgv_Agenda.CurrentRow.Cells("ped_id").Value(), dgv_Agenda.CurrentRow.Cells("pac_id").Value(), CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), Trim(edad) & " " & Trim(unidad), Trim(dgv_Agenda.CurrentRow.Cells("age_resumen").Value()), Trim(str_cer), Trim(txt_CerTutor.Text), Trim(txt_CerCI.Text), "CONFIRMADO", CInt(dgv_Agenda.CurrentRow.Cells("ped_turno").Value()), SiNoGuardo)
                    If SiNoGuardo = True Then

                        Dim i As Integer
                        Dim arre_medico As String()
                        arre_medico = Split(opr_pedido.ConsultaMedicosGrupo(CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value())), ",")

                        If UBound(arre_medico) > 2 Then
                            For i = 0 To UBound(arre_medico) - 1
                                opr_pedido.GestionaConsulta(opr_pedido.LeerMaxConsultaMedico(), arre_medico(i), dgv_Agenda.CurrentRow.Cells("pac_id").Value, dgv_Agenda.CurrentRow.Cells("age_id").Value, "", "", "PENDIENTE", "Insert", "")
                            Next
                        Else
                            opr_pedido.GestionaConsulta(opr_pedido.LeerMaxConsultaMedico(), CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), dgv_Agenda.CurrentRow.Cells("pac_id").Value, dgv_Agenda.CurrentRow.Cells("age_id").Value, "", "", "PENDIENTE", "Insert", "")
                        End If

                        opr_pedido.VisualizaMensaje("Agenda CONFIRMARDA satisfactoriamente", 300)
                        mantieneDatos()

                        actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

                        RestaurarSeleccion()

                    End If
                End If
                'Else
                'opr_pedido.VisualizaMensaje("LA AGENDA ya se encuentra CONFIRMADO", 300)
            End If

        Else
            opr_pedido.VisualizaMensaje("Unicamente las AGENDA WEB se pueden CONFIRMAR", 300)
        End If
    End Sub


    'Private Sub dgv_Agenda_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Agenda.CellFormatting

    '    PintaGrid()

    'End Sub

    

    Private Sub BuscarYSeleccionarCelda(ByVal textoBuscado As String)
        ' Itera a través de las filas del GridView.
        For Each row As DataGridViewRow In dgv_Agenda.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().Contains(textoBuscado) Then
                    ' Selecciona la celda coincidente.
                    dgv_Agenda.CurrentCell = cell
                    ' Enfoca la celda.
                    dgv_Agenda.Focus()
                    ' Sale del bucle.
                    Return
                End If
            Next
        Next

        ' Si no se encuentra el texto buscado, puedes mostrar un mensaje o realizar otra acción.
        opr_pedido.VisualizaMensaje("No se encontraron coincidencias.", 300)
    End Sub

    
    
    Private Sub btn_GrabaTutor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrabaTutor.Click
        If dgv_Agenda.CurrentRow.Cells("age_estado").Value() = "CONFIRMADO" Then
            str_cer = ""
            For Each ctlCert As Control In grp_Certificados.Controls
                If TypeOf ctlCert Is CheckBox Then
                    If DirectCast(ctlCert, CheckBox).Checked = True Then
                        str_cer = str_cer & ctlCert.Tag & ",1|"
                    Else
                        str_cer = str_cer & ctlCert.Tag & ",0|"
                    End If
                End If
            Next

            If str_cer = "" Then
                opr_pedido.VisualizaMensaje("Debe seleccionar al menos un certificado", 300)
                Exit Sub
            End If

            If txt_CerCI.Text = "" Then
                opr_pedido.VisualizaMensaje("Debe ingresar la cedula del tutor", 300)
                Exit Sub
            End If

            If txt_CerTutor.Text = "" Then
                opr_pedido.VisualizaMensaje("Debe el nombre deltutor", 300)
                Exit Sub
            End If

            opr_agenda.ModificaAgendaHora(CInt(dgv_Agenda.CurrentRow.Cells("age_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("ped_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("pac_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), Trim(dgv_Agenda.CurrentRow.Cells("pac_edad").Value()), Trim(dgv_Agenda.CurrentRow.Cells("age_resumen").Value()), Trim(str_cer), Trim(txt_CerTutor.Text), Trim(txt_CerCI.Text), "CONFIRMADO", CInt(dgv_Agenda.CurrentRow.Cells("ped_turno").Value()), SiNoGuardo)

            If SiNoGuardo = True Then
                opr_pedido.VisualizaMensaje("Información almacenada satirfactoriamente", 250)

                mantieneDatos()

                actualizaDtsAgenda(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

                RestaurarSeleccion()

            Else
                opr_pedido.VisualizaMensaje("No se pudo guardar la informacion de Tutor, consulte al admin", 250)
            End If
        Else
            opr_pedido.VisualizaMensaje("Primero guarde la agenda", 250)
        End If
    End Sub


    
    Private Sub btn_CrearCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CrearCert.Click
        Dim frm_MDIChild As New frm_CertificadoAbierto()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.pac_id = CInt(dgv_Agenda.CurrentRow.Cells("pac_id").Value())
        frm_MDIChild.pac_nombre = dgv_Agenda.CurrentRow.Cells("pac_nombre").Value()
        frm_MDIChild.pac_doc = dgv_Agenda.CurrentRow.Cells("pac_doc").Value()
        frm_MDIChild.Age_id = dgv_Agenda.CurrentRow.Cells("Age_id").Value()
        
        frm_MDIChild.ShowDialog(Me.ParentForm)
    End Sub

    Private Sub btn_Solicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Solicitud.Click

    End Sub

    Private Sub dgv_AgendaDespacho_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_AgendaDespacho.CellClick
        habilitaBtns(0)
    End Sub

    Private Sub btn_Consent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Consent.Click
        ImprimeCertificados(7)
    End Sub

    Private Sub habilitaBtns(ByVal tipo As Integer)
        Select Case tipo
            Case 1
                btn_AgendarPaciente.Enabled = True
                btn_AgendarActividad.Enabled = True
                btn_gguardar.Enabled = True
                btn_Confirmar.Enabled = True
            Case 0
                btn_AgendarPaciente.Enabled = False
                btn_AgendarActividad.Enabled = False
                btn_gguardar.Enabled = False
                btn_Confirmar.Enabled = False
        End Select

    End Sub

    Private Sub dgv_AgendaDespacho_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_AgendaDespacho.CellDoubleClick
        If dgv_AgendaDespacho.CurrentRow.Cells("age_estado").Value() = "DISPONIBLE" Then
            If Not ExisteForm("frm_VacunaTratamiento") Then
                Dim frm_MDIChild As New frm_VacunaTratamiento()
                'frm_MDIChild.frm_refer_main = Me.ParentForm
                frm_MDIChild.Age_Id = dgv_AgendaDespacho.CurrentRow.Cells("age_id").Value()
                frm_MDIChild.med_nombre = dgv_AgendaDespacho.CurrentRow.Cells("age_resumen").Value()
                frm_MDIChild.med_id = dgv_AgendaDespacho.CurrentRow.Cells("Med_doc").Value()
                'frm_MDIChild.pac_doc = dgv_AgendaDespacho.CurrentRow.Cells("pac_doc").Value()
                'frm_MDIChild.ped_turno = dgv_AgendaDespacho.CurrentRow.Cells("ped_turno").Value()
                'frm_MDIChild.age_resumen = dgv_AgendaDespacho.CurrentRow.Cells("age_resumen").Value()
                frm_MDIChild.ShowDialog(Me.ParentForm)

                'mantieneDatosDespacho()

                actualizaDtsAgendaDespacho(CInt(dgv_Medico.CurrentRow.Cells("med_id").Value))

                'RestaurarSeleccion()

            End If
        Else
            opr_pedido.VisualizaMensaje("GUARDE O CONFIRME LA AGENDA para continuar con la consulta", 300)
        End If
    End Sub

    Private Sub btn_buscaAgenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaAgenda.Click
        Dim msg As String = Nothing
        Dim textoBuscado As String = Nothing
        msg = "Ingrese el apellido del paciente"

        textoBuscado = InputBox(msg, "ANALISYS")

        If textoBuscado <> "" Then
            BuscarYSeleccionarCelda(textoBuscado)
        End If
    End Sub

    Private Sub btn_AgendarPaciente_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_AgendarPaciente.MouseMove
        lbl_AgendarA.Text = "Ingresa paciente"
    End Sub

    
    Private Sub btn_AgendarActividad_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_AgendarActividad.MouseMove
        lbl_AgendarA.Text = "Agregar Actividad"
    End Sub

    
    Private Sub btn_Confirmar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_Confirmar.MouseMove
        lbl_AgendarA.Text = "Confirmar agenda WEB"
    End Sub

    Private Sub btn_gguardar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_gguardar.MouseMove
        lbl_AgendarA.Text = "Guardar agenda"
    End Sub


    

    Private Sub btn_AgendarPaciente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgendarPaciente.MouseLeave
        If var_label <> "" Then
            lbl_AgendarA.Text = var_label
        Else
            lbl_AgendarA.Text = "Escoja una hora para agendar"
        End If
    End Sub

    Private Sub btn_buscaAgenda_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_buscaAgenda.MouseMove
        lbl_AgendarA.Text = "Busca paciente agendado"
    End Sub

    Private Sub btn_ImpAgenda_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_ImpAgenda.MouseMove
        lbl_AgendarA.Text = "Imprime agenda"
    End Sub

    Private Sub btn_ssalir_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_ssalir.MouseMove
        lbl_AgendarA.Text = "Cerrar agenda"
    End Sub

    Private Sub btn_AgendarActividad_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgendarActividad.MouseLeave
        If var_label <> "" Then
            lbl_AgendarA.Text = var_label
        Else
            lbl_AgendarA.Text = "Escoja una hora para agendar"
        End If
    End Sub

    Private Sub btn_Confirmar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirmar.MouseLeave
        If var_label <> "" Then
            lbl_AgendarA.Text = var_label
        Else
            lbl_AgendarA.Text = "Escoja una hora para agendar"
        End If
    End Sub

    Private Sub btn_gguardar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gguardar.MouseLeave
        If var_label <> "" Then
            lbl_AgendarA.Text = var_label
        Else
            lbl_AgendarA.Text = "Escoja una hora para agendar"
        End If
    End Sub

    Private Sub btn_buscaAgenda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscaAgenda.MouseLeave
        If var_label <> "" Then
            lbl_AgendarA.Text = var_label
        Else
            lbl_AgendarA.Text = "Escoja una hora para agendar"
        End If
    End Sub

    Private Sub btn_ImpAgenda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpAgenda.MouseLeave
        If var_label <> "" Then
            lbl_AgendarA.Text = var_label
        Else
            lbl_AgendarA.Text = "Escoja una hora para agendar"
        End If
    End Sub

    Private Sub btn_ssalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ssalir.MouseLeave
        If var_label <> "" Then
            lbl_AgendarA.Text = var_label
        Else
            lbl_AgendarA.Text = "Escoja una hora para agendar"
        End If
    End Sub

    Private Sub rbt_Grp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Grp.CheckedChanged
        If rbt_Grp.Checked = True Then
            Var_Vergrupo = True
        End If
       
    End Sub

    Private Sub rbt_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_All.CheckedChanged
        If rbt_All.Checked = True Then
            Var_Vergrupo = False
        End If
       
    End Sub
End Class