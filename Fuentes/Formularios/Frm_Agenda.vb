

Public Class Frm_Agenda

    Public frm_refer_main_form As Frm_Main
    Public VarPac As Integer
    Public NomPac As String
    Public VarMed As Integer
    Public VarPed As Integer
    Public MedEmail As String = Nothing
    Private opr_medico As New Cls_Medico()
    Private opr_agenda As New Cls_Agenda()
    Private opr_mail As New Cls_NetMail()
    Dim dtv_agenda As New DataView()
    Dim calendario As String()
    Dim i As Integer = 0
    Dim resumen As String = Nothing
    Public SiNoGuardo As Boolean = False
    Dim opr_res As New Cls_Resultado()
    Dim dts_recomendac As New DataSet
    Dim arreglo As String()
    Dim age_id As Integer = 0

    Private Sub Frm_Agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm

        'If Tag = 1 Then
        opr_medico.LlenarComboMedico(cmb_tratante, "Referencia")
        opr_res.llenaListaRecomendacion(chkl_recom)
        'cmb_tratante.Text = "LABORATORIO"

        lbl_paciente.Text = NomPac.PadRight(20)
        lbl_Fecha.Text = Format(cal1.SelectionRange.Start, "dddd, dd MMMM yyyy")
        dgrd_Cal.DataSource = dtv_agenda
        resumen = Label3.Text & " " & Trim(Mid(cmb_tratante.Text, 1, 100)) & " " & vbCr & _
        Label1.Text & " " & lbl_paciente.Text & " " & vbCr & _
        Label4.Text & " " & lbl_Fecha.Text & " " & vbCr & _
        Label5.Text & " " & lbl_Hora.Text & " " & vbCr & _
        lbl_medico.Text = ""

        'VERIFICO SI EXISTE LA AGENDA DIARIA, CASO CONTRARIO LA CREO



        If opr_agenda.ExisteAgenda(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio", Mid(cmb_tratante.Text, 101, 10)) > 0 Then
            'LEO LA AGENDA DIARIA
            opr_agenda.LlenarGridAgenda(dtv_agenda, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio")
        Else
            calendario = Split(opr_agenda.LeerCalendario("Laboratorio", CInt(Mid(cmb_tratante.Text, 101, 10))), ",")

            For i = 0 To UBound(calendario) - 1
                age_id = opr_agenda.LeeMaximoAgenda()
                opr_agenda.CreaAgenda(age_id, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), calendario(i), "Laboratorio", CInt(Mid(cmb_tratante.Text, 101, 10)), "", "")
            Next
            'LEO LA AGENDA DIARIA
            opr_agenda.LlenarGridAgenda(dtv_agenda, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio")

        End If
        'LEO LA AGENDA DIARIA
        opr_medico.LlenarComboMedico(cmb_tratante, "Tratante")
        dgrd_Cal.DataSource = dtv_agenda
        cmb_tratante.Enabled = True
        Panel1.Enabled = False
        chkl_recom.Enabled = True
        btn_NotificarMail.Enabled = False

        opr_agenda.LlenarGridAgenda(dtv_agenda, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio")



    End Sub

    Private Sub cmb_tratante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tratante.SelectedIndexChanged
        lbl_medico.Text = Trim(Mid(cmb_tratante.Text, 1, 100))
        VarMed = CInt(Trim(Mid(cmb_tratante.Text, 101, 10)))
        MedEmail = Trim(Mid(cmb_tratante.Text, 111, 100))

    End Sub



    Private Sub dgrd_Cal_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Cal.CurrentCellChanged
        lbl_Hora.Text = dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0)
        If Tag = 1 Then
            btn_Aceptar.Enabled = True
        Else
            btn_Aceptar.Enabled = False
            btn_imprimirCal.Enabled = True

        End If
    End Sub

    Private Sub cal1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles cal1.DateChanged
        lbl_Fecha.Text = Format(cal1.SelectionRange.Start, "dddd, dd MMMM yyyy")
        dgrd_Cal.CaptionText = "CALENDARIO " & lbl_Fecha.Text

        'If cal1.SelectionRange.Start.DayOfWeek = 7 Then
        'If MsgBox("El dia seleccionado para agendar es DOMINGO, desea agendar ?", MsgBoxStyle.YesNo.Information, "ANALISYS") = MsgBoxResult.Yes Then

        'If opr_agenda.ExisteAgenda(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio") > 0 Then
        '    'LEO LA AGENDA DIARIA
        '    opr_agenda.LlenarGridAgenda(dtv_agenda, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio")
        '    'btn_imprimirCal.Enabled = True
        '    btn_imprimirCalDia.Enabled = True
        '    btn_imprimirCalSemana.Enabled = True
        '    btn_imprimirCalMedico.Enabled = True
        'Else
        '    calendario = Split(opr_agenda.LeerCalendario("Laboratorio"), ",")

        '    For i = 0 To UBound(calendario) - 1
        '        age_id = opr_agenda.LeeMaximoAgenda()
        '        opr_agenda.CreaAgenda(age_id, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), calendario(i), "Laboratorio")
        '    Next
        '    'LEO LA AGENDA DIARIA
        '    opr_agenda.LlenarGridAgenda(dtv_agenda, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio")
        '    'btn_imprimirCal.Enabled = False
        '    btn_imprimirCalDia.Enabled = True
        '    btn_imprimirCalSemana.Enabled = True
        '    btn_imprimirCalMedico.Enabled = True
        'End If

        'End If
        'End If

    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'comprueba que haya seleccionado por lo menos una area 
        Dim i As Short = 0
        Dim recomendaciones As String = Nothing
        Dim boo_recom As Boolean = False
        For i = 0 To (chkl_recom.Items.Count - 1)
            If (chkl_recom.GetItemChecked(i) = True) Then
                boo_recom = True
                Exit For
            End If
        Next
        If boo_recom = False Then
            MsgBox("Debe seleccionar al menos una área relacionada", MsgBoxStyle.Exclamation, "ANALISYS")
            chkl_recom.Focus()
            Exit Sub
        End If

        'Recomendaciones relacionadas 
        For i = 0 To (chkl_recom.Items.Count - 1)
            If chkl_recom.GetItemChecked(i) = True Then
                recomendaciones = recomendaciones & Trim(Mid(chkl_recom.Items.Item(i), 1, 60)) & vbCrLf
            End If
        Next


        resumen = Label3.Text & " " & Trim(Mid(cmb_tratante.Text, 1, 100)) & " " & vbCrLf & _
        Label1.Text & " " & NomPac & " " & vbCrLf & _
        recomendaciones


        If opr_agenda.ExisteAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), "Laboratorio", 1) >= 1 Then
            If MsgBox("La agenda para ese dia se encuentra ocupada, desea modificar la agenda ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                opr_agenda.ModificaAgendaHora(dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 2), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 1), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 3), "", "", "", "", "", "", 0, SiNoGuardo)
                'btn_imprimirCul.Enabled = True
            Else
                'opr_agenda.CreaAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), VarPac, VarMed, VarPed, resumen)
                'opr_agenda.ModificaAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), VarPac, VarMed, VarPed, resumen)
            End If
        Else
            'opr_agenda.ModificaAgendaHora(CInt(dgv_Agenda.CurrentRow.Cells("age_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("ped_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("pac_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("med_id").Value()), CInt(dgv_Agenda.CurrentRow.Cells("pac_edad").Value()), dgv_Agenda.CurrentRow.Cells("age_resumen").Value.ToString, SiNoGuardo)
            opr_agenda.ModificaAgendaHora(dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 2), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 1), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 3), "", "", "", "", "", "", 0, SiNoGuardo)
            'btn_imprimirCul.Enabled = True
        End If
        opr_agenda.LlenarGridAgenda(dtv_agenda, Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), "Laboratorio")
        btn_imprimirCal.Enabled = True
        btn_imprimirCalDia.Enabled = True
        btn_imprimirCalSemana.Enabled = True
        btn_NotificarMail.Enabled = True
    End Sub

    Private Sub btn_imprimirCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirCal.Click
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim str_sql As String = Nothing
        Dim obj_reporte As New rpt_Agenda()
        Dim hora As String = dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0)
        Dim fecha As String = Format(cal1.SelectionRange.Start, "dd/MM/yyyy")
        If opr_agenda.ExisteAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0), "Laboratorio", 1) >= 1 Then
            'INSTRUCCION SQL PARA OBTENER TODO LOS DATOS 
            str_sql = "select age_hora, age_fecha, age_resumen from agenda where age_hora = '" & hora & "' and age_fecha = '" & fecha & "';"
            Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1, 1)
            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
            frm_MDIChild.Text = "Agenda Hora"
            frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Else

        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
        ''opr_agenda.DevuelveSerialUSB()

    End Sub

    Private Sub btn_imprimirCalDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirCalDia.Click
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim str_sql As String = Nothing
        Dim obj_reporte As New rpt_Agenda()
        Dim hora As String = dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0)
        Dim fecha As String = Format(cal1.SelectionRange.Start, "dd/MM/yyyy")
        'If opr_agenda.ExisteAgendaHora(Format(cal1.SelectionRange.Start, "dd/MM/yyyy"), dgrd_Cal.Item(dgrd_Cal.CurrentCell.RowNumber, 0)) >= 1 Then
        'INSTRUCCION SQL PARA OBTENER TODO LOS DATOS 
        str_sql = "select age_hora, age_fecha, age_resumen from agenda where age_fecha = '" & fecha & "' and age_resumen <> '';"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , , 1)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Agenda Diaria"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        'Else

        'End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_imprimirCalSemana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirCalSemana.Click
        Dim FechaLunes As DateTime
        Dim FechaDomingo As DateTime
        Dim FechaHoy As DateTime

        FechaHoy = CDate(cal1.SelectionRange.Start)
        FechaLunes = opr_agenda.DevuelveLunesSemana(FechaHoy, Weekday(FechaHoy))
        FechaDomingo = DateAdd(DateInterval.Day, 7, FechaLunes)

        Dim str_sql As String = Nothing
        Dim obj_reporte As New rpt_Agenda()

        'INSTRUCCION SQL PARA OBTENER TODO LOS DATOS 

        str_sql = "select '" & FechaLunes & "' as FechaInicial, '" & FechaDomingo & "' as fechaFinal, age_hora, age_fecha, age_resumen from agenda where age_fecha between '" & Format(FechaLunes, "dd/MM/yyyy") & "' and '" & Format(FechaDomingo, "dd/MM/yyyy") & "' and age_resumen <> '' group by age_fecha, age_hora, age_resumen;"
        'Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , , , , 1, 1)
        'frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        'frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        'frm_MDIChild.Text = "Agenda Semanal"
        'frm_refer_main_form.Crea_formulario(frm_MDIChild)

    End Sub

  
    Private Sub btn_NotificarMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NotificarMail.Click
        Dim wtexto As String = Nothing
        Dim myValue As String = "0992715345"
        ' ''Dim asunto As String = Nothing
        ' ''Dim ParamCorreo As String()

        ' ''asunto = resumen & vbCrLf & vbCrLf & vbCrLf & g_Titulo
        ' ''MedEmail = "rossvanflores@hotmail.com"
        ' ''If MedEmail <> "" Then
        ' ''    ParamCorreo = Split(opr_mail.RecuperaConfigCorreo(), ",")
        ' ''    If (opr_mail.EnviaCorreo(MedEmail, resumen, "", ParamCorreo(0), ParamCorreo(1), ParamCorreo(2), ParamCorreo(3), ParamCorreo(4), "", ParamCorreo(5))) Then
        ' ''        MsgBox("Notificacion correcta", MsgBoxStyle.Information, "Analisys")
        ' ''    Else
        ' ''        MsgBox("Error al enviar la notificacion, contactese con el administrador del sistema.", MsgBoxStyle.Exclamation, "Analisys")
        ' ''    End If
        ' ''Else
        ' ''    MsgBox("No se puede enviar la notificacion, verifique que el destinatario (Medico) tenga registrado correo elecgtronico.", MsgBoxStyle.Exclamation, "Analisys")
        ' ''End If
        'wtexto & "*USUARIO:*%20" & credenciales(0) & "%0A" & "*CONTRASEÑA:*%20" & credenciales(1) & "%0A" & "*LINK:*%20" & System.Configuration.ConfigurationSettings.AppSettings("SITIO") & "%0A%0A" & g_Titulo
        wtexto = "*ESTIMADO DOCTOR A CONTINUACION LE CONFIRMAMOS UN NUEVO AGENDAMIENTO*%0A%0A" & wtexto

        '&text=''
        System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(myValue, 2, 9) & "&text=" & wtexto)

    End Sub

    
   
    Private Sub btn_imprimirCalMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirCalMedico.Click

        
        Dim FechaLunes As DateTime
        Dim FechaDomingo As DateTime
        Dim FechaHoy As DateTime

        FechaHoy = CDate(cal1.SelectionRange.Start)
        FechaLunes = opr_agenda.DevuelveLunesSemana(FechaHoy, Weekday(FechaHoy))
        FechaDomingo = DateAdd(DateInterval.Day, 7, FechaLunes)

        Dim str_sql As String = Nothing
        Dim obj_reporte As New rpt_AgendaMedico()

        'INSTRUCCION SQL PARA OBTENER TODO LOS DATOS 
        ''str_sql = "select '" & FechaLunes & "' as FechaInicial, '" & FechaDomingo & "' as fechaFinal, age_hora, age_fecha, age_resumen from agenda where age_fecha between '" & Format(FechaLunes, "dd/MM/yyyy") & "' and '" & Format(FechaDomingo, "dd/MM/yyyy") & "' and age_resumen <> '' group by age_fecha, age_hora, age_resumen;"
        str_sql = "select '" & FechaLunes & "' as FechaInicial, '" & FechaDomingo & "' as fechaFinal, age_hora, age_fecha, age_resumen, medico.MED_ID, medico.MED_NOMBRE from agenda, medico where age_fecha between '" & Format(FechaLunes, "dd/MM/yyyy") & "' and '" & Format(FechaDomingo, "dd/MM/yyyy") & "' and age_resumen <> '' and medico.MED_ID = agenda.med_id group by medico.MED_NOMBRE, age_fecha, age_hora, age_resumen, medico.med_id ;"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1, 1)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Agenda Semanal MEDICO"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)

    End Sub

End Class