Public Class frm_CertificadoAbierto
    Public frm_refer_main As Frm_Main
    Public pac_id As Integer
    Public pac_doc As String
    Public Age_id As Integer
    Public pac_nombre As String
    Dim opr_agenda As New Cls_Agenda()
    Dim opr_pedido As New Cls_Pedido()
    Dim swExisteCert As Boolean


    
    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        'If MsgBox("Desea guardar el certificado?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
        ' GuardaCertAbierto(Trim(txt_Titulo.Text), Trim(txt_Cuerpo.Text), Age_id)
        'Else
        Me.Close()
        'End If
    End Sub

    

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim tipo As String
        If swExisteCert = True Then
            tipo = "Update"
        Else
            tipo = "Insert"
        End If
        Dim SiNoGuardo As Boolean
        opr_agenda.GestionaCertAbierto(opr_agenda.LeeMaximoCertAbierto() + 1, Age_id, Trim(txt_Titulo.Text), Trim(txt_Cuerpo.Text), tipo, SiNoGuardo)

        If SiNoGuardo = True Then
            opr_pedido.VisualizaMensaje("Información almacenada satirfactoriamente", 250)
        Else
            opr_pedido.VisualizaMensaje("No se pudo guardar la los datos, consulte a su administardor", 250)
        End If


    End Sub

    Private Sub frm_CertificadoAbierto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If opr_pedido.ExisteCertAbierto(Age_id) > 0 Then
            btn_ImprimirCert.Enabled = True

            Dim arr_datosCERT As String()

            arr_datosCERT = Split(opr_pedido.LeerCertAbierto(Age_id), "º")

            If UBound(arr_datosCERT) >= 1 Then
                txt_Titulo.Text = arr_datosCERT(0)
                txt_Cuerpo.Text = arr_datosCERT(1)

            End If
            swExisteCert = True
        Else
            txt_Cuerpo.Text = "Certifico que el paciente: " & pac_nombre.ToUpper & ", con CI/PASAPORTE: " & pac_doc
            swExisteCert = False
        End If
    End Sub

    Private Sub btn_ImprimirCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImprimirCert.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim str_sql As String
        Dim obj_reporte As New rpt_Certificados()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        str_sql = "select CERP_ID AS CER_ID, CERP_TITULO as CER_TIPO, CERP_FECHA AS AGE_FECHA, '' as AGE_TUTOR, '' AS AGE_CI, '' AS PACIENTE, CERP_CUERPO  AS TEXTO " & _
                "from certificadoPaciente " & _
                "where AGE_ID = " & Age_id & ""


        'str_sql = "select distinct(receta.rec_id), receta.rec_fecha, medico.MED_NOMBRE, receta.REC_MEDICACION, receta.REC_INDICACIONES, REC_DIETA, cm.cie_cod4, '" & lbl_Cie10.Text & "' as cie_desc4, (paciente.PAC_APELLIDO + ' ' + paciente .PAC_NOMBRE) as pac_nombre, paciente.pac_doc " & _
        '       "from receta, medico, paciente, consultaMedico as cm " & _
        '       "where receta.age_id = " & Age_id & " and  receta.med_id = medico.med_id and paciente.pac_id = receta.pac_id and cm.PAC_ID = paciente.PAC_ID and cm.AGE_ID = receta.AGE_ID  "

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        frm_MDIChild.Text = "CERTIFICADOS"
        frm_MDIChild.ShowDialog(Me.ParentForm)


        'opr_pdf.ExportToPDF(obj_reporte, "RECETA-" & Age_id & " " & lbl_paciente.Text, g_pathFolderReceta)


        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class