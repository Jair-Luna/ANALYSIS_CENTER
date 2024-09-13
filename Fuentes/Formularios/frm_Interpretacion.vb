Public Class frm_Interpretacion

    Public frm_refer_main As Frm_Main
    Public Ped_id As Integer
    Public Pac_id As Integer
    Public Age_id As Integer

    Dim swExisteInterp As Boolean
    Dim ExisteInterpretacion As Boolean
    Dim opr_pedido As New Cls_Pedido()
    Dim opr_res As New Cls_Resultado()


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'If opr_pedido.ExisteInterpretacion(Ped_id) > 0 Then
        ' ExisteInterpretacion = True
        ' Else
        'ExisteInterpretacion = False
        'End If
        opr_pedido.GestionaInterpretacion(Ped_id, Trim(txt_InterpAlimentos.Text), Trim(txt_Sustancias.Text), Trim(txt_InterpInhalantes.Text), Trim(txt_InterpMedicAINES.Text), Trim(txt_InterpMedicAB.Text), Trim(txt_InterpMedicOTROS.Text), Trim(txt_InterpRecom.Text), Trim(txt_InterpRecom2.Text), Pac_id, Age_id, ExisteInterpretacion)
    End Sub



    Private Sub frm_Interpretacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If opr_pedido.ExisteInterpretacion(Ped_id) > 0 Then

            swExisteInterp = True
        Else

            swExisteInterp = False
        End If
        RecuperaIntepretacion(swExisteInterp)
    End Sub

    Private Sub RecuperaIntepretacion(ByVal swExisteInterp As Boolean)
        Dim visto As Char = ChrW(10003)
        Dim i As Integer
        Dim j As Integer
        Dim arr_ResulInterpret As String()
        Dim arr_Resul As String()
        Dim arre_test As String()
        Dim str_test As String = "401310,401325,401311,401312,401321,401322"
        'Dim var_ali1, var_ali2, var_ali3, var_Sus1, var_Sus1_1, var_Sus2, var_Sus3, var_Sus1_Tar, var_Sus1_MX, var_in_humedad_moderada, var_in_polvos_moderada, var_in_moderada, var_in_acaros_moderada, var_in_resto_moderada, var_in_humedad_intensa, var_in_polvos_intensa, var_in_intensa, var_in_acaros_intensa, var_in_moho_intensa, var_in_moho_moderada, var_in_resto_intensa, var_AINES1, var_AB1, var_AB2, var_OTR1, var_OTR2, var_AINESN As String

        arre_test = Split(str_test, ",")

        txt_InterpAlimentos.Text = ""
        txt_InterpInhalantes.Text = ""
        txt_InterpMedicAB.Text = ""
        txt_InterpMedicAINES.Text = ""
        txt_InterpMedicOTROS.Text = ""
        txt_InterpRecom.Text = ""
        txt_InterpRecom2.Text = ""
        txt_Sustancias.Text = ""

        Dim moderada_titulo, intensa_titulo As String
        Dim otras_sust_MX, otras_sust, otras_tar_para As String
        Dim moderada, intensa, intensa_polenes, moderada_polenes, moderada_polvos, intensa_polvos, moderada_acaros, intensa_acaros, moderada_humedad, intensa_humedad, intensa_insectos, moderada_insectos, intensa_parabenos, moderada_parabenos As String
        Dim var_AINES1, var_AINESN, var_AB1, var_AB2, var_OTR1, var_OTR2 As String
        Dim var_Sus1_MX, var_Sus1, var_Sus1_Tar, var_Sus2

        For i = 0 To UBound(arre_test)
            Select Case arre_test(i)


                Case 401310 'ALIMENTOS
                    Dim comerpoco_ali, suspender3_ali, suspender6_ali As String

                    arr_ResulInterpret = Split(opr_pedido.LeerResultadosInterpretacion(Ped_id, CInt(arre_test(i))), "|")
                    For j = 0 To UBound(arr_ResulInterpret) - 1
                        arr_Resul = Split(arr_ResulInterpret(j), "º")

                        Select Case arr_Resul(1)
                            Case "."
                                comerpoco_ali = comerpoco_ali & " - " & arr_Resul(0) & vbCrLf
                            Case "I", visto
                                suspender3_ali = suspender3_ali & " - " & arr_Resul(0) & vbCrLf
                            Case "O"
                                suspender6_ali = suspender6_ali & " - " & arr_Resul(0) & vbCrLf
                        End Select
                    Next

                    If comerpoco_ali <> "" Then
                        txt_InterpAlimentos.Text = txt_InterpAlimentos.Text & "Comer poco" & vbCrLf & comerpoco_ali & vbCrLf
                    End If
                    If suspender3_ali <> "" Then
                        txt_InterpAlimentos.Text = txt_InterpAlimentos.Text & "Suprimir por 2 meses" & vbCrLf & suspender3_ali & vbCrLf
                    End If
                    If suspender6_ali <> "" Then
                        txt_InterpAlimentos.Text = txt_InterpAlimentos.Text & "Suprimir por 6 meses o más" & vbCrLf & suspender6_ali & vbCrLf
                    End If




                Case 401311 'INHALANTES

                    arr_ResulInterpret = Split(opr_pedido.LeerResultadosInterpretacion(Ped_id, CInt(arre_test(i))), "|")
                    For j = 0 To UBound(arr_ResulInterpret) - 1
                        arr_Resul = Split(arr_ResulInterpret(j), "º")

                        Select Case arr_Resul(1)

                            Case "O" 'INTENSA
                                Select Case arr_Resul(0)
                                    Case "CYNODON", "HOLCUS", "LOLIUM", "POA", "AGROSTIS", "BROMUS", "DACTILIS", "PHLEUM", "GRAMINEA"
                                        intensa_polenes = intensa_polenes & " - " & arr_Resul(0) & vbCrLf

                                    Case "POLVO CUARTO C", "POLVO CUARTO S"
                                        intensa_polvos = intensa_polvos & " - POLVO DE HABITACION" & vbCrLf

                                    Case "DT. PTERONYSSINUS", "DT. BLOMIA", "DT. SIBONEY"
                                        intensa_acaros = intensa_acaros & " - " & arr_Resul(0) & vbCrLf

                                    Case "HORMODENDRO", "ASPERGILLUS", "CANDIDA", "MUCOR", "PENICILLIUM", "RHIZOPUS"
                                        intensa_humedad = intensa_humedad & " - " & arr_Resul(0) & vbCrLf
                                    Case Else
                                        intensa = intensa & "- " & arr_Resul(0) & vbCrLf
                                End Select

                            Case "I", visto 'MODERADA
                                Select Case arr_Resul(0)
                                    Case "CYNODON", "HOLCUS", "LOLIUM", "POA", "AGROSTIS", "BROMUS", "DACTILIS", "PHLEUM", "GRAMINEA"
                                        moderada_polenes = moderada_polenes & " - " & arr_Resul(0) & vbCrLf

                                    Case "POLVO CUARTO C", "POLVO CUARTO S"
                                        moderada_polvos = moderada_polvos & " - POLVO DE HABITACION" & vbCrLf

                                    Case "DT. PTERONYSSINUS", "DT. BLOMIA", "DT. SIBONEY"
                                        moderada_acaros = moderada_acaros & " - " & arr_Resul(0) & vbCrLf

                                    Case "HORMODENDRO", "ASPERGILLUS", "CANDIDA", "MUCOR", "PENICILLIUM", "RHIZOPUS"
                                        moderada_humedad = moderada_humedad & " - " & arr_Resul(0) & vbCrLf
                                    Case Else
                                        moderada = moderada & "- " & arr_Resul(0) & vbCrLf
                                End Select

                        End Select

                    Next

                    '*********************************
                    ' INTENSA O
                    '*********************************
                    If intensa <> "" Or intensa_polenes <> "" Or intensa_polvos <> "" Or intensa_acaros <> "" Or intensa_humedad <> "" Then
                        intensa_titulo = "Intensa Sensibilidad" & vbCrLf
                    End If

                    If intensa_polenes <> "" Then
                        intensa = intensa & "   PÓLENES EN ESPECIAL :" & vbCrLf & intensa_polenes
                    End If

                    If intensa_polvos <> "" Then
                        intensa = intensa & intensa_polvos
                    End If

                    If intensa_parabenos <> "" Then
                        intensa = intensa & vbCrLf & intensa_parabenos
                    End If

                    If intensa_acaros <> "" Then
                        intensa = intensa & vbCrLf & "   ACAROS EN ESPECIAL DE : " & vbCrLf & intensa_acaros
                    End If

                    If intensa_humedad <> "" Then
                        intensa = intensa & vbCrLf & "   MOHO DE HUMEDAD EN ESPECIAL :" & vbCrLf & intensa_humedad
                    End If

                    txt_InterpInhalantes.Text = intensa_titulo & intensa & vbCrLf

                    '*********************************
                    ' MODERADA VISTO
                    '*********************************
                    If moderada <> "" Or moderada_polenes <> "" Or moderada_polvos <> "" Or moderada_acaros <> "" Or moderada_humedad <> "" Then
                        moderada_titulo = "Moderada Sensibilidad" & vbCrLf
                    End If

                    If moderada_polenes <> "" Then
                        moderada = moderada & "   PÓLENES EN ESPECIAL :" & vbCrLf & moderada_polenes
                    End If

                    If moderada_polvos <> "" Then
                        moderada = moderada & moderada_polvos
                    End If

                    If moderada_parabenos <> "" Then
                        moderada = moderada & moderada_parabenos
                    End If

                    If moderada_acaros <> "" Then
                        moderada = moderada & "   ACAROS EN ESPECIAL DE : " & vbCrLf & moderada_acaros
                    End If

                    If moderada_humedad <> "" Then
                        moderada = moderada & "   MOHO DE HUMEDAD EN ESPECIAL :" & vbCrLf & moderada_humedad
                    End If

                    txt_InterpInhalantes.Text = txt_InterpInhalantes.Text & vbCrLf & moderada_titulo & vbCrLf & moderada


                Case 401312 'MEDICAMENTOS AINES
                    arr_ResulInterpret = Split(opr_pedido.LeerResultadosInterpretacion(Ped_id, CInt(arre_test(i))), "|")
                    For j = 0 To UBound(arr_ResulInterpret) - 1
                        arr_Resul = Split(arr_ResulInterpret(j), "º")

                        Select Case arr_Resul(1)
                            Case "I", "POSITIVO", "positivo", "Positivo", "P", "p", visto
                                var_AINES1 = var_AINES1 & " - " & arr_Resul(0) & vbCrLf

                            Case "N", "NEGATIVO", "negativo", "Negativo", "N", "n", visto
                                var_AINESN = var_AINESN & " - " & arr_Resul(0) & vbCrLf
                        End Select
                    Next
                    If var_AINES1 <> "" Then
                        txt_InterpMedicAINES.Text = txt_InterpMedicAINES.Text & vbCrLf & "Positivo" & vbCrLf & var_AINES1
                        'txt_InterpMedicAINES.Text = txt_InterpMedicAINES.Text & vbCrLf & var_AINES1
                    End If

                    If var_AINESN <> "" Then
                        txt_InterpMedicAINES.Text = txt_InterpMedicAINES.Text & vbCrLf & "Negativo" & vbCrLf & var_AINESN
                        'txt_InterpMedicAINES.Text = txt_InterpMedicAINES.Text & vbCrLf & var_AINESN
                    End If

                Case 401321 ' AB
                    arr_ResulInterpret = Split(opr_pedido.LeerResultadosInterpretacion(Ped_id, CInt(arre_test(i))), "|")
                    For j = 0 To UBound(arr_ResulInterpret) - 1
                        arr_Resul = Split(arr_ResulInterpret(j), "º")

                        Select Case arr_Resul(1)
                            Case "I", "POSITIVO", "positivo", "Positivo", "P", "p", visto
                                var_AB1 = var_AB1 & " - " & arr_Resul(0) & vbCrLf
                            Case "NEGATIVO", "negativo", "Negativo", "N", "n"
                                var_AB2 = var_AB2 & " - " & arr_Resul(0) & vbCrLf
                        End Select
                    Next
                    If var_AB1 <> "" Then
                        txt_InterpMedicAB.Text = txt_InterpMedicAB.Text & vbCrLf & "Positivo" & vbCrLf & var_AB1
                        'txt_InterpMedicAB.Text = txt_InterpMedicAB.Text & vbCrLf & var_AB1
                    End If
                    If var_AB2 <> "" Then
                        txt_InterpMedicAB.Text = txt_InterpMedicAB.Text & vbCrLf & "Negativo" & vbCrLf & var_AB2
                        'txt_InterpMedicAB.Text = txt_InterpMedicAB.Text & vbCrLf & var_AB2
                    End If



                Case 401325 ' OTROS MEDICAMENTOS
                    arr_ResulInterpret = Split(opr_pedido.LeerResultadosInterpretacion(Ped_id, CInt(arre_test(i))), "|")
                    For j = 0 To UBound(arr_ResulInterpret) - 1
                        arr_Resul = Split(arr_ResulInterpret(j), "º")

                        Select Case arr_Resul(1)
                            Case "I", "POSITIVO", "positivo", "Positivo", "P", "p", visto
                                var_OTR1 = var_OTR1 & " - " & arr_Resul(0) & vbCrLf
                            Case "NEGATIVO", "negativo", "Negativo", "N", "n"
                                var_OTR2 = var_OTR2 & " - " & arr_Resul(0) & vbCrLf
                        End Select
                    Next
                    If var_OTR1 <> "" Then
                        txt_InterpMedicOTROS.Text = txt_InterpMedicOTROS.Text & vbCrLf & "Positivo" & vbCrLf & var_OTR1
                        'txt_InterpMedicOTROS.Text = txt_InterpMedicOTROS.Text & vbCrLf & var_OTR1
                    End If

                    If var_OTR2 <> "" Then
                        txt_InterpMedicOTROS.Text = txt_InterpMedicOTROS.Text & vbCrLf & "Negativo" & vbCrLf & var_OTR2
                        'txt_InterpMedicOTROS.Text = txt_InterpMedicOTROS.Text & vbCrLf & var_OTR2
                    End If



                Case 401322 'OTRAS SUSTANCIAS

                    arr_ResulInterpret = Split(opr_pedido.LeerResultadosInterpretacion(Ped_id, CInt(arre_test(i))), "|")
                    For j = 0 To UBound(arr_ResulInterpret) - 1
                        arr_Resul = Split(arr_ResulInterpret(j), "º")

                        Select Case arr_Resul(0)
                            Case "INSECTOS MX"
                                otras_sust_MX = otras_sust_MX & "    SECRECIÓN QUE INYECTAN LOS INSECTOS AL PICAR" & vbCrLf

                            Case "TARTRAZINA", "PARABENOS"
                                otras_tar_para = otras_tar_para & " - " & arr_Resul(0) & vbCrLf

                            Case Else
                                Select Case arr_Resul(1)

                                    Case "I", visto
                                        otras_sust = otras_sust & " - " & arr_Resul(0) & vbCrLf
                                End Select
                        End Select

                    Next

                    If otras_sust_MX <> "" Then
                        otras_sust = otras_sust_MX & otras_sust
                    End If

                    If otras_tar_para <> "" Then
                        otras_sust = otras_sust & vbCrLf & otras_tar_para
                    End If

                    txt_Sustancias.Text = txt_Sustancias.Text & otras_sust & vbCrLf
                    
            End Select

        Next

        lbl_FechaInter.Text = Format(Now(), "dd/MMM/yyyy")
        txt_InterpRecom.Text = "Para pacientes con alergias respiratorias." & vbCrLf & vbCrLf & _
                        "Evitar acumulación de polvo en habitaciones. En dormitorios suprimir alfombras, peluches y objetos que acumulen polvo. Limpiar las habitaciones de preferencia con paño húmedo para evitar que el polvo se quede en el ambiente. " & vbCrLf & vbCrLf & _
                        "Evitar sustancias que causen irritación de las vías respiratorias como: humo de tabaco, insecticidas, pintura, cera de pisos, productos de limpieza con olores y perfumes fuertes; etc. " & vbCrLf & vbCrLf & _
                        "En alimentación: Evitar alimentos y bebidas procesadas, tales como: conservas, enlatados, bebidas gaseosas, jugos, gelatinas, vinos y otras bebidas alcohólicas. Varios de estos alimentos y bebidas pueden contener colorantes artificiales y preservantes."


        txt_InterpRecom2.Text = "No se descarta reacciones Pseudo-Alérgicas con otro tipo de medicamentos, re recomienda uso previo de MEDICACIÓN ANTIHISTAMÍNICA y CORTICOIDEA antes de cualquier precedimiento médico." & vbCrLf & vbCrLf & _
                        "1. NO AUTO MEDICARSE." & vbCrLf & _
                        "2. EVITAR MEDICAMENTOS COMBINADOS." & vbCrLf & _
                        "3. EVITAR MEDICACIÓN MULTIPLE (Diferencia entre (1/2 hora entre medicamentos)." & vbCrLf & _
                        "4. EVITAR MEDICACIÓN PARENTERAL AMBULATORIA (Inyecciones)." & vbCrLf & _
                        "5. CUALQUIER MEDICAMENTO PREEESCRITO INICIAR CON DOSIS BAJAS TERAPEUTICAS." & vbCrLf & _
                        "6. APUNTAR EN UNA LIBRETA LOS MEDICAMENTOS QUE CAUSEN ALGUNA REACCIÓN ADVERSA."

        'txt_InterpRecom2.Text = "En las prueba de sensibilidad de alergia" & vbCrLf & vbCrLf & _
        '                "1. SENSIBILIDAD A ANTINFLAMATORIOS NO ESTEROIDEOS (AINE):" & _
        '                "" & _
        '                "" & _
        '                ""

        opr_pedido.GestionaInterpretacion(Ped_id, Trim(txt_InterpAlimentos.Text), Trim(txt_Sustancias.Text), Trim(txt_InterpInhalantes.Text), Trim(txt_InterpMedicAINES.Text), Trim(txt_InterpMedicAB.Text), Trim(txt_InterpMedicOTROS.Text), Trim(txt_InterpRecom.Text), Trim(txt_InterpRecom2.Text), Pac_id, Age_id, swExisteInterp)

    End Sub

    
    
    Private Sub btn_Imp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imp1.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_interpretacion1()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        str_sql = "select PED_ID, PRCC_FECHA, PRCC_HORA, PRCC_INT_ALIMENTOS, PRCC_INT_SUSTANCIAS, PRCC_INT_INHALANTES, PRCC_INT_MED_AINES, " & _
                    "PRCC_INT_MED_AB, PRCC_INT_MED_OTRAS, PRCC_INT_RECOMEN1, PRCC_INT_RECOMEN2, ci.LIS_USER,(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE " & _
                    "from res_cutaneasInterpretacion as ci, paciente " & _
                    "where paciente.PAC_ID = ci.PAC_ID And ci.PED_ID = " & Ped_id

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        frm_MDIChild.Text = "INTERPRETACION"
        frm_MDIChild.ShowDialog(Me.ParentForm)


        'opr_pdf.ExportToPDF(obj_reporte, "RECETA-" & Age_id & " " & lbl_paciente.Text, g_pathFolderReceta)


        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_Imp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imp2.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_interpretacion2()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        str_sql = "select PED_ID, PRCC_FECHA, PRCC_HORA, PRCC_INT_ALIMENTOS, PRCC_INT_INHALANTES, PRCC_INT_INHALANTES, PRCC_INT_MED_AINES, " & _
                    "PRCC_INT_MED_AB, PRCC_INT_MED_OTRAS, PRCC_INT_RECOMEN1, PRCC_INT_RECOMEN2, ci.LIS_USER,(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE " & _
                    "from res_cutaneasInterpretacion as ci, paciente " & _
                    "where paciente.PAC_ID = ci.PAC_ID And ci.PED_ID = " & Ped_id

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        frm_MDIChild.Text = "INTERPRETACION"
        frm_MDIChild.ShowDialog(Me.ParentForm)


        'opr_pdf.ExportToPDF(obj_reporte, "RECETA-" & Age_id & " " & lbl_paciente.Text, g_pathFolderReceta)


        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    

End Class