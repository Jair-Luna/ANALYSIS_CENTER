Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class frm_ConsultaMedico
    Public Age_Id As Integer
    Public Ped_Id As Integer
    Dim opr_res As New Cls_Resultado()
    Dim opr_pedido As New Cls_Pedido()
    Public med_id As Integer
    Public pac_doc As String
    Public ped_turno As String
    Public age_resumen As String
    Dim graf_name As String
    Dim med_grafico As Integer

    Dim datoSv, datoHC, datosDesencadenate, datosSintSob, datosPrurito, datosAccAsmas, datosTos, datosPiel, datosRAM, datosAsma, datosRinit, datosUrtic, datosEccem, datosConjun, datosDrogas, datosMigra, datosEdema, datosOtro, datosResNorm, datosResForz, datosNariz, datosGargan, datosCpiel, datosCimagen, datosCbiopsia, datosSEspc, datosLab1, datosLab2, datosLab3, datosLab4 As String
    Dim diag, trat, evol As String
    Dim dts_agenda As DataSet
    Private WithEvents dtt_InfoPac As New DataTable("Registros")

    Private WithEvents dtt_IPer As New DataTable("Registros")

    Private WithEvents dtt_MedTratante As New DataTable("Registros")

    Private WithEvents dtt_cieConsulta As New DataTable("Registros")

    Private WithEvents dtt_cieHistorico As New DataTable("Registros")

    Private WithEvents dtt_conHist As New DataTable("Registros")

    Private WithEvents dtt_conHistMedicos As New DataTable("Registros")

    Private WithEvents dtt_TTo As New DataTable("Registros")



    Dim dts_InfoPermanente As DataSet
    Dim dts_MedTratante As DataSet

    Dim blnAjustarCeldas As Boolean = True
    Private WithEvents dtt_InfoPermanente As New DataTable("Registros")

    Dim var_Cie4 As String

    Dim dt As DataTable = New DataTable()
    Dim dtMed As DataTable = New DataTable()
    Dim dtDiagCie10 As DataTable = New DataTable()
    Dim dtCut As DataTable = New DataTable()




    Private Sub SeleccionPages(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged


        Select Case TabControl1.SelectedIndex
            Case 0

                'If age_resumen <> "DESPACHO CLIENTE" Then
                '    actualizaDtsMedicoTratante(Age_Id, med_id)
                'Else
                '    actualizaDtsMedicoTratante(Age_Id, opr_pedido.ConsultaMedicosGrupoPac(med_id, Trim(pac_doc)))
                'End If

                ''MsgBox("ACTUAL")
                'datoSv = obtieneSIgnosVitales(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()))
                'datoHC = obtieneHistoriaClinica(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()))
                'datosDesencadenate = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_EmpeoraCom", "EMPEORA COM:")
                'datosSintSob = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_EmpeoraCom", "EMPEORA COM:")

                'obtieneDiagnosticos(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), diag, trat, evol)

                'cargagridInfoPermanente(datoSv, datoHC, diag, trat, evol, datosDesencadenate)

            Case 1

                'MsgBox("ANTERIORES")
            Case 2
                'MsgBox("ESTADISTCA")
        End Select

    End Sub

    Private Function obtieneSIgnosVitales(ByVal pac_id As Integer) As String
        Return opr_res.ConsultaSignosVitales(pac_id)
    End Function

    Private Function obtieneCie10(ByVal Age_id As Integer) As String
        Return opr_res.ConsultaCie10(Age_id)
    End Function



    Private Function obtieneHistoriaClinica(ByVal pac_id As Integer) As String
        Return opr_res.ConsultaHistoriaClinica(pac_id)
    End Function

    Private Function obtieneHistoriaClinicaCAMPO(ByVal str_sql As String, ByVal titulo As String) As String
        Return opr_res.ConsultaHistoriaClinicaCAMPO(str_sql, titulo)
    End Function

    Private Function obtieneDiagnosticos(ByVal pac_id As Integer, ByRef diag As String, ByRef trat As String, ByRef evol As String) As String
        opr_res.ConsultaDiagnosticos(pac_id, diag, trat, evol)
    End Function

    Private Function obtieneDatosTrama(ByVal pac_id As Integer, ByVal campo As String, ByVal titulo As String) As String
        Return opr_res.ConsultaDatosTrama(pac_id, campo, titulo)
    End Function

    Private Function obtieneDatosRCAT(ByVal AGE_ID As Integer) As String
        Return opr_res.ConsultaDatosRCAT(AGE_ID)
    End Function
    Private Function obtieneDatosTramaCutaneas(ByVal pac_id As Integer, ByVal tes_padre As Integer, ByVal titulo As String) As String
        Return opr_res.ConsultaDatosCutaneas(pac_id, tes_padre, titulo)
    End Function


    Private Sub cargaGridHC(ByVal datos As String)

        dgv_InfoPermanente.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_InfoPermanente.DefaultCellStyle.SelectionForeColor = Color.White
        dgv_InfoPermanente.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgv_InfoPermanente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim row As DataRow = dt.NewRow()
        row("codigo") = datos
        dt.Rows.Add(row)

        dt.AcceptChanges()
        dgv_InfoPermanente.DataSource = dt

        'dgv_InfoPermanente.DataSource = dt

    End Sub

    Private Sub cargaGridCIE10(ByVal CodCie As String, ByVal DesCie As String, ByVal Med_id As Integer)

        Dim dtCie10 As DataTable = DirectCast(dgv_Cie10Medico.DataSource, DataTable)
        Dim row As DataRow = dtCie10.NewRow()
        row("CodCie") = CodCie
        row("DesCie") = DesCie
        row("med_id") = Med_id
        dtCie10.Rows.Add(row)
        dgv_Cie10Medico.DataSource = dtCie10


        dgv_Cie10Medico.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Cie10Medico.DefaultCellStyle.SelectionForeColor = Color.White
        dgv_Cie10Medico.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgv_Cie10Medico.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        ' ''Dim row As DataRow = dtDiagCie10.NewRow()
        ' ''row("Cie10") = codigoCie
        ' ''dtDiagCie10.Rows.Add(row)


        ' ''dtDiagCie10.AcceptChanges()
        ' ''dgv_Cie10Medico.DataSource = dtDiagCie10

    End Sub


    Private Sub cargaGridCUT(ByVal datos As String)

        dgv_Cutaneas.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Cutaneas.DefaultCellStyle.SelectionForeColor = Color.White
        dgv_Cutaneas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgv_Cutaneas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim row As DataRow = dtCut.NewRow()
        row("codigo") = datos
        dtCut.Rows.Add(row)

        dtCut.AcceptChanges()
        dgv_Cutaneas.DataSource = dtCut


    End Sub

    Private Sub cargaGridCUT_HIST(ByVal datos As String)

        dgv_HistoricoExamenes.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_HistoricoExamenes.DefaultCellStyle.SelectionForeColor = Color.White
        dgv_HistoricoExamenes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgv_HistoricoExamenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim row As DataRow = dtCut.NewRow()
        row("codigo") = datos
        dtCut.Rows.Add(row)

        dtCut.AcceptChanges()

        dgv_HistoricoExamenes.DataSource = dtCut

    End Sub

    Private Sub cargaGridMED(ByVal medico As String, ByVal fecha As String, ByVal estado As String)

        dgv_MedicosTratantes.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_MedicosTratantes.DefaultCellStyle.SelectionForeColor = Color.LightSkyBlue
        dgv_MedicosTratantes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        dgv_MedicosTratantes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim row1 As DataRow = dtMed.NewRow()
        row1("Medico") = medico
        row1("Fecha") = fecha
        row1("Estado") = estado
        dtMed.Rows.Add(row1)

        'Dim row2 As DataRow = dtMed.NewRow()
        'row2("Fecha") = fecha
        'dtMed.Rows.Add(row2)

        dt.AcceptChanges()
        dgv_MedicosTratantes.DataSource = dtMed

    End Sub


    Private Sub cargaGridDIAG(ByVal texto As String)

        'dgv_Diagnosticos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'dgv_Diagnosticos.DefaultCellStyle.SelectionForeColor = Color.White
        'dgv_Diagnosticos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        'dgv_Diagnosticos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'Dim row1 As DataRow = dtDiag.NewRow()
        'row1("Diagnostico") = texto
        'dtDiag.Rows.Add(row1)

        'dtDiag.AcceptChanges()
        'dgv_Diagnosticos.DataSource = dtDiag

    End Sub

    Private Sub cargagridInfoPermanente(ByVal datosSV As String, ByVal datosHC As String, ByVal diag As String, ByVal trat As String, ByVal evol As String, ByVal empeora As String)
        '***********************************
        ' INFORMACION PERMANENTE
        '***********************************
        Dim dt As DataTable = New DataTable()

        Dim dtcDatos As New DataColumn("Codigo", GetType(System.String))
        dt.Columns.Add(dtcDatos)

        dgv_InfoPermanente.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_InfoPermanente.DefaultCellStyle.SelectionForeColor = Color.LightYellow
        dgv_InfoPermanente.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgv_InfoPermanente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim row0 As DataRow = dt.NewRow()
        row0("codigo") = "SIGNOS VITALES"
        dt.Rows.Add(row0)

        Dim row As DataRow = dt.NewRow()
        row("codigo") = datosSV
        dt.Rows.Add(row)


        Dim row1 As DataRow = dt.NewRow()
        row1("codigo") = "HISTORIA CLINICA"
        dt.Rows.Add(row1)

        Dim row2 As DataRow = dt.NewRow()
        'row("codigo") = dgv_InfoPermanente.Rows.Count + 1
        row2("codigo") = datosHC
        dt.Rows.Add(row2)

        Dim rowE As DataRow = dt.NewRow()
        rowE("codigo") = datosDesencadenate
        dt.Rows.Add(rowE)

        Dim row3 As DataRow = dt.NewRow()
        row3("codigo") = "DIAGNOSTICO"
        dt.Rows.Add(row3)

        Dim row4 As DataRow = dt.NewRow()
        'row("codigo") = dgv_InfoPermanente.Rows.Count + 1
        row4("codigo") = diag
        dt.Rows.Add(row4)

        Dim row5 As DataRow = dt.NewRow()
        row5("codigo") = "TRATAMIENTO"
        dt.Rows.Add(row5)

        Dim row6 As DataRow = dt.NewRow()
        row6("codigo") = trat
        dt.Rows.Add(row6)

        Dim row7 As DataRow = dt.NewRow()
        row7("codigo") = "EVOLUCION"
        dt.Rows.Add(row7)

        Dim row8 As DataRow = dt.NewRow()
        row8("codigo") = evol
        dt.Rows.Add(row8)

        dt.AcceptChanges()

        dgv_InfoPermanente.DataSource = dt



    End Sub

    Private Sub llena_InfoPermanente(ByVal pac_doc As String)

        Dim dtcM_columna1 As New DataColumn("med_nombre", GetType(System.String))
        Dim dtcM_columna2 As New DataColumn("med_id", GetType(System.Single))
        Dim dtcM_columna3 As New DataColumn("med_mail", GetType(System.String))
        dtt_InfoPermanente.Columns.Add(dtcM_columna1)
        dtt_InfoPermanente.Columns.Add(dtcM_columna2)
        dtt_InfoPermanente.Columns.Add(dtcM_columna3)


        actualizaDtsInfoPermanente(dgv_InfoPaciente.CurrentRow.Cells("pac_doc").Value())

        dgv_InfoPermanente.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        dgv_InfoPermanente.Columns("med_nombre").Width = 190
        dgv_InfoPermanente.Columns("med_id").Visible = False
        dgv_InfoPermanente.Columns("med_mail").Visible = False

        dgv_InfoPermanente.DefaultCellStyle.SelectionForeColor = Color.LightYellow
        dgv_InfoPermanente.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)

    End Sub

    Private Function obtieneDatosTramaLab(ByVal pac_id As Integer, ByVal campo As String) As String
        Return opr_res.ConsultaDatosTramaLab(pac_id, campo)
    End Function


    Private Sub actualizaDtsInfoPermanente(ByVal pac_id As Integer)
        dtt_InfoPermanente.Clear()
        opr_res.LlenarGridInfoPermanente(dgv_InfoPermanente, dtt_InfoPermanente, pac_id)
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        ' Dibuja el fondo de la pestaña con un color personalizado
        Dim tabPage As TabPage = TabControl1.TabPages(e.Index)
        Dim tabPageColor As Color = Color.LightBlue ' Puedes cambiar este color según tus preferencias

        Dim g As Graphics = e.Graphics
        Dim bounds As Rectangle = e.Bounds

        ' Dibuja el fondo de la pestaña
        g.FillRectangle(New SolidBrush(tabPageColor), bounds)

        ' Dibuja el texto de la pestaña
        Dim textBrush As New SolidBrush(e.ForeColor)
        Dim tabText As String = TabControl1.TabPages(e.Index).Text
        g.DrawString(tabText, e.Font, textBrush, bounds.Left + 8, bounds.Top + 6)

        ' Establece el color de fondo de la pestaña activa
        If e.Index = TabControl1.SelectedIndex Then
            Dim selectedTabColor As Color = Color.LightCyan ' Puedes cambiar este color según tus preferencias
            g.FillRectangle(New SolidBrush(selectedTabColor), bounds)
        End If

        ' Dibuja el borde de la pestaña
        Dim borderPen As New Pen(Color.Gray)
        g.DrawRectangle(borderPen, bounds)

        ' Libera recursos
        textBrush.Dispose()
        borderPen.Dispose()
    End Sub

    Private Sub frm_ConsultaMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddHandler TabControl1.DrawItem, AddressOf TabControl1_DrawItem

        Dim str_sql As String = Nothing
        Dim datoCAMPO As String = Nothing
        Dim currentRowIndex As Integer = -1

        '------------------------------------------------
        ' INFO PACIENTE
        '----------------------------------------------
        Dim dtcA_columna1 As New DataColumn("pac_nombre", GetType(System.String))
        Dim dtcA_columna2 As New DataColumn("pac_doc", GetType(System.String))
        Dim dtcA_columna3 As New DataColumn("pac_edad", GetType(System.String))
        Dim dtcA_columna4 As New DataColumn("pac_sexo", GetType(System.String))
        Dim dtcA_columna5 As New DataColumn("pac_id", GetType(System.Single))
        dtt_InfoPac.Columns.Add(dtcA_columna1)
        dtt_InfoPac.Columns.Add(dtcA_columna2)
        dtt_InfoPac.Columns.Add(dtcA_columna3)
        dtt_InfoPac.Columns.Add(dtcA_columna4)
        dtt_InfoPac.Columns.Add(dtcA_columna5)

        actualizaDtsInfoPac(Age_Id)

        lbl_MDTratante.Text = ""

        '*********************************************
        '*********** GRID MEDICOS TRATANTES **********
        '*********************************************
        Dim dtcMT_columna1 As New DataColumn("con_id", GetType(System.Single))
        Dim dtcMT_columna2 As New DataColumn("med_nombre", GetType(System.String))
        Dim dtcMT_columna3 As New DataColumn("med_id", GetType(System.Single))
        Dim dtcMT_columna4 As New DataColumn("con_fecha", GetType(System.String))
        Dim dtcMT_columna5 As New DataColumn("con_diagnostico", GetType(System.String))
        Dim dtcMT_columna6 As New DataColumn("con_obs", GetType(System.String))
        Dim dtcMT_columna7 As New DataColumn("con_estado", GetType(System.String))
        Dim dtcMT_columna8 As New DataColumn("ped_id", GetType(System.String))
        Dim dtcMT_columna9 As New DataColumn("med_receta", GetType(System.Single))
        Dim dtcMT_columna10 As New DataColumn("med_grafico", GetType(System.Single))


        dtt_MedTratante.Columns.Add(dtcMT_columna1)
        dtt_MedTratante.Columns.Add(dtcMT_columna2)
        dtt_MedTratante.Columns.Add(dtcMT_columna3)
        dtt_MedTratante.Columns.Add(dtcMT_columna4)
        dtt_MedTratante.Columns.Add(dtcMT_columna5)
        dtt_MedTratante.Columns.Add(dtcMT_columna6)
        dtt_MedTratante.Columns.Add(dtcMT_columna7)
        dtt_MedTratante.Columns.Add(dtcMT_columna8)
        dtt_MedTratante.Columns.Add(dtcMT_columna9)
        dtt_MedTratante.Columns.Add(dtcMT_columna10)

        If age_resumen <> "DESPACHO CLIENTE" Then
            actualizaDtsMedicoTratante(Age_Id, med_id)
        Else
            actualizaDtsMedicoTratante(Age_Id, opr_pedido.ConsultaMedicosGrupoPac(med_id, Trim(pac_doc)))
        End If

        dgv_MedicosTratantes.Columns("con_id").Visible = False
        dgv_MedicosTratantes.Columns("med_nombre").HeaderText = "MEDICO ESPECIALISTA"
        dgv_MedicosTratantes.Columns("med_nombre").Width = 200
        dgv_MedicosTratantes.Columns("med_id").Visible = False

        dgv_MedicosTratantes.Columns("con_fecha").HeaderText = "FECHA"
        dgv_MedicosTratantes.Columns("con_fecha").Width = 115

        dgv_MedicosTratantes.Columns("con_diagnostico").Visible = False

        dgv_MedicosTratantes.Columns("con_estado").HeaderText = "ESTADO"
        dgv_MedicosTratantes.Columns("con_estado").Width = 100

        dgv_MedicosTratantes.Columns("con_obs").HeaderText = "COMENTARIO"
        dgv_MedicosTratantes.Columns("con_obs").Width = 240

        dgv_MedicosTratantes.Columns("ped_id").Visible = False
        dgv_MedicosTratantes.Columns("med_receta").Visible = False
        dgv_MedicosTratantes.Columns("med_grafico").Visible = False


        With dgv_MedicosTratantes
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
        'CAMBIO COLOR SEGUN ESTADO

        'CREO COLUMNAS PARA GRID INFORMACION HC
        Dim dtcDatos As New DataColumn("Codigo", GetType(System.String))
        dt.Columns.Add(dtcDatos)

        Dim dtcDatosCut As New DataColumn("Codigo", GetType(System.String))
        dtCut.Columns.Add(dtcDatosCut)


        '' ''CREO COLUMNAS PARA GRID DIAGNOSTIO CIE10
        Dim dtCie_columna1 As New DataColumn("CodCie", GetType(System.String))
        Dim dtCie_columna2 As New DataColumn("DesCie", GetType(System.String))
        Dim dtCie_columna3 As New DataColumn("med_id", GetType(System.Single))

        dtt_cieConsulta.Columns.Add(dtCie_columna1)
        dtt_cieConsulta.Columns.Add(dtCie_columna2)
        dtt_cieConsulta.Columns.Add(dtCie_columna3)

        actualizaDtsCieConsulta(Age_Id, med_id)

        dgv_Cie10Medico.Columns("CodCie").HeaderText = "CODIGO"
        dgv_Cie10Medico.Columns("CodCie").Width = 40

        dgv_Cie10Medico.Columns("DesCie").HeaderText = "DESCRICION"
        dgv_Cie10Medico.Columns("DesCie").Width = 180

        dgv_Cie10Medico.Columns("med_id").Visible = False

        With dgv_Cie10Medico
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With


        '******************* TAB CONSULTA ACTUAL **************************
        dgv_InfoPermanente.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_InfoPermanente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_InfoPermanente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgv_InfoPaciente.Columns("pac_nombre").Width = 400
        dgv_InfoPaciente.Columns("pac_doc").Width = 140

        dgv_InfoPaciente.Columns("pac_edad").Width = 180
        dgv_InfoPaciente.Columns("pac_sexo").Width = 50
        dgv_InfoPaciente.Columns("pac_id").Visible = False


        dgv_InfoPaciente.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_InfoPaciente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_InfoPaciente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


        With dgv_InfoPaciente
            .DefaultCellStyle.Font = New Font("Arial Rounded MT", 14)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        '******************OBTIENE RESULTADOS CUTANEAS +++++++++++++++++++*

        If opr_pedido.LeerDermografismo(Age_Id) = 1 Then
            cargaGridCUT("DERMOGRAFICO: Si" & vbCrLf)

        Else
            cargaGridCUT("DERMOGRAFICO: No" & vbCrLf)
        End If

        Dim opr_agenda As New Cls_Agenda()
        Dim Exa_str As String()
        Dim Exa_id As String()
        Dim i As Integer

        Exa_str = Split(opr_agenda.BuscaExamenesSolicita(1, "NORMAL"), "º")
        For i = 0 To UBound(Exa_str) - 1
            Exa_id = Split(Exa_str(i), ",")

            Select Case Exa_id(0)
                Case 401310 'CUTANEAS ALIMENTOS
                    Dim datosCutAlimentos As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "ALIMENTOS")
                    If datosCutAlimentos <> "" Then
                        cargaGridCUT(datosCutAlimentos)
                    End If

                Case 401325 'CUTANEAS SUSTANIAS
                    Dim datosCutAlimentos As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "SUSTANCIAS")
                    If datosCutAlimentos <> "" Then
                        cargaGridCUT(datosCutAlimentos)
                    End If

                Case 401311 'CUTANEAS INHALANTES
                    Dim datosCutInhalantes As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "INHALANTES")
                    If datosCutInhalantes <> "" Then
                        cargaGridCUT(datosCutInhalantes)
                    End If

                Case 401312 'CUTANEAS MEDICAMENTOS
                    Dim datosCutMedicamentos As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "MEDICAMENTOS")
                    If datosCutMedicamentos <> "" Then
                        cargaGridCUT(datosCutMedicamentos)
                    End If

                Case 401321 'CUTANEAS ANTIBIOTICOS
                    Dim datosCutAntibioticos As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "ANTIBIOTICOS")
                    If datosCutAntibioticos <> "" Then
                        cargaGridCUT(datosCutAntibioticos)
                    End If

                Case 401322 'CUTANEAS OTROS MEDICAMENTOS
                    Dim datosCutOtrasS As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "OTRAS SUSTANCIAS")
                    If datosCutOtrasS <> "" Then
                        cargaGridCUT(datosCutOtrasS)
                    End If

                Case 401323 'CUTANEAS NIÑOS ALIMENTOS
                    Dim datosCutInfAlimen As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "NIÑOS ALIMENTOS")
                    If datosCutInfAlimen <> "" Then
                        cargaGridCUT(datosCutInfAlimen)
                    End If

                Case 401324 'CUTANEAS NIÑOS INHALANTES
                    Dim datosCutInfInha As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "NIÑOS INHALANTES")
                    If datosCutInfInha <> "" Then
                        cargaGridCUT(datosCutInfInha)
                    End If
            End Select
        Next

        cargaGridCUT(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab1"))
        cargaGridCUT(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab2"))
        cargaGridCUT(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab3"))
        cargaGridCUT(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab4"))

        '******************OBTIENE INFORMACION+++++++++++++++++++*
        ''''txt_Cie10.Text = obtieneCie10(Age_Id)

        datoSv = obtieneSIgnosVitales(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()))
        cargaGridHC(datoSv)

        datoHC = obtieneHistoriaClinica(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()))
        cargaGridHC(datoHC)

        datosDesencadenate = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Desencadenantes", "DESENCADENANTES:")
        cargaGridHC(datosDesencadenate)

        Dim datosMenstrucion As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Menstruacion", "MENSTRUACION:")
        cargaGridHC(datosMenstrucion)

        Dim datosMenstrucionToma As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_MenstruacionToma", "MENSTRUACION TOMA:")
        cargaGridHC(datosMenstrucionToma)

        Dim datosSinOjos As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_SinOjos", "SINTOMAS OJOS:")
        cargaGridHC(datosSinOjos)

        Dim datosSinNariz As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_SinNariz", "SINTOMAS NARIZ:")
        cargaGridHC(datosSinNariz)

        Dim datosSinEstonudos As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Estornudos", "SINTOMAS ESTORNUDOS:")
        cargaGridHC(datosSinEstonudos)

        Dim datosSinBoca As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_SinBoca", "SINTOMAS BOCA:")
        cargaGridHC(datosSinBoca)

        datosPrurito = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Prurito", "PRURITO:")
        cargaGridHC(datosPrurito)

        datosTos = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Tos", "TOS:")
        cargaGridHC(datosTos)

        Dim datosAccAsmaticos As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "Hic_AccAsmaticos", "ACCES. ASMATICOS:")
        cargaGridHC(datosAccAsmaticos)

        datosPiel = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Piel", "PIEL:")
        cargaGridHC(datosPiel)

        Dim datosDigestivos As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Digestivos", "DIGESTIVOS:")
        cargaGridHC(datosDigestivos)


        'RAM
        datoCAMPO = Nothing
        str_sql = "select hic_RAM from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "RAM")
        cargaGridHC(datoCAMPO)

        Dim datosAntASMA As String = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamAsma", "ASMA")
        cargaGridHC(datosAntASMA)

        datosRinit = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamRiñitis", "RIÑITIS")
        cargaGridHC(datosRinit)

        datosUrtic = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamUrticaria", "URTICARIA")
        cargaGridHC(datosUrtic)

        datosEccem = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamEccem", "ECCEMA")
        cargaGridHC(datosEccem)

        datosConjun = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamConjunt", "CONJUNTIVITIS")
        cargaGridHC(datosConjun)

        datosDrogas = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamDrogas", "DROGAS")
        cargaGridHC(datosDrogas)

        datosMigra = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamMigra", "MIGRAÑA")
        cargaGridHC(datosMigra)

        datosEdema = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamEdema", "EDEMA")
        cargaGridHC(datosEdema)

        'SIGNOS ESPECIALES 1 Y 2
        Dim datosEspeciales1 = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamEdema", "SIGNOS ESPECIALES")
        cargaGridHC(datosEspeciales1)

        Dim datosEspeciales2 = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_AntecFamEdema", "")
        cargaGridHC(datosEspeciales2)


        datosResNorm = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_TotaxResNormal", "RESPIRACION NORMAL:")
        cargaGridHC(datosResNorm)

        datosResForz = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_ToraxResForzada", "RESPIRACION FORZADA:")
        cargaGridHC(datosResForz)

        datosNariz = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Nariz", "NARIZ:")
        cargaGridHC(datosNariz)

        datosNariz = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_NarizHiperCorn", "HIPER CORNETES")
        cargaGridHC(datosNariz)

        datosGargan = obtieneDatosTrama(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "hic_Garganta", "GARGANTA:")
        cargaGridHC(datosGargan)

        'CAMPO PIEL
        datoCAMPO = Nothing
        str_sql = "select hic_CampoPiel from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS PIEL")
        cargaGridHC(datoCAMPO)

        'CAMPO LAB IMAGEN
        datoCAMPO = Nothing
        str_sql = "select hic_DatosLabImagen from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS LAB IMAGEN")
        cargaGridHC(datoCAMPO)

        'CAMPO BIOPSIA
        datoCAMPO = Nothing
        str_sql = "select hic_DatosLabBiopsia from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS LAB BIOPSIA")
        cargaGridHC(datoCAMPO)

        'CAMPO LAB 1
        datoCAMPO = Nothing
        str_sql = "select hic_DatosLab1 from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS LABORATORIO 1")
        cargaGridHC(datoCAMPO)

        'CAMPO LAB 2
        datoCAMPO = Nothing
        str_sql = "select hic_DatosLab2 from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS LABORATORIO 2")
        cargaGridHC(datoCAMPO)

        'CAMPO LAB 3
        datoCAMPO = Nothing
        str_sql = "select hic_DatosLab3 from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS LABORATORIO 3")
        cargaGridHC(datoCAMPO)

        'CAMPO LAB 4
        datoCAMPO = Nothing
        str_sql = "select hic_DatosLab4 from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS LABORATORIO 4")
        cargaGridHC(datoCAMPO)

        'CAMPO LAB otros
        datoCAMPO = Nothing
        str_sql = "select hic_DatosLabOtros from historiaClinica where pac_id = " & CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        datoCAMPO = obtieneHistoriaClinicaCAMPO(str_sql, "DATOS LABORATORIO OTROS")
        cargaGridHC(datoCAMPO)

        obtieneDiagnosticos(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), diag, trat, evol)
        'cargaGridHC(diag)
        'cargaGridHC(trat)
        'cargaGridHC(evol)
        'txt_HistoricoDiagnostico.Text = Trim(diag)
        'txt_HC_Tratamiento.Text = Trim(trat)
        txt_HC_Evolucion.Text = Trim(evol)


        '***********************************************************
        '' ''CREO COLUMNAS PARA GRID CONSULTAS HISTORICAS 
        '***********************************************************
        Dim dtConHist_columna1 As New DataColumn("AGE_ID", GetType(System.Single))
        Dim dtConHist_columna2 As New DataColumn("CON_FECHA", GetType(System.String))
        Dim dtConHist_columna3 As New DataColumn("MED_NOMBRE", GetType(System.String))
        Dim dtConHist_columna4 As New DataColumn("MED_ID", GetType(System.Single))
        Dim dtConHist_columna5 As New DataColumn("AGE_ESTADO", GetType(System.String))

        dtt_conHist.Columns.Add(dtConHist_columna1)
        dtt_conHist.Columns.Add(dtConHist_columna2)
        dtt_conHist.Columns.Add(dtConHist_columna3)
        dtt_conHist.Columns.Add(dtConHist_columna4)
        dtt_conHist.Columns.Add(dtConHist_columna5)

        actualizaDtsConHist(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()))

        dgv_ConsultaHistorico.Columns("AGE_ID").HeaderText = "ID"
        dgv_ConsultaHistorico.Columns("AGE_ID").Visible = False

        dgv_ConsultaHistorico.Columns("CON_FECHA").HeaderText = "FECHA"
        dgv_ConsultaHistorico.Columns("CON_FECHA").Width = 120

        dgv_ConsultaHistorico.Columns("MED_NOMBRE").HeaderText = "ESPECIALIDAD"
        dgv_ConsultaHistorico.Columns("MED_NOMBRE").Width = 200

        dgv_ConsultaHistorico.Columns("MED_ID").HeaderText = "IDM"
        dgv_ConsultaHistorico.Columns("MED_ID").Visible = False

        dgv_ConsultaHistorico.Columns("AGE_ESTADO").HeaderText = "ESTADO"
        dgv_ConsultaHistorico.Columns("AGE_ESTADO").Visible = False

        With dgv_ConsultaHistorico
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        lbl_ToTConsultas.Text = CStr(dgv_ConsultaHistorico.Rows.Count)
        lbl_TotCie.Text = ""
        lbl_TotExas.Text = CStr(dgv_HistoricoExamenes.Rows.Count)


        '' ''CREO COLUMNAS PARA GRID MEDICOS HISTORICOS 
        Dim dtMedHist_columna1 As New DataColumn("AGE_ID", GetType(System.Single))
        Dim dtMedHist_columna2 As New DataColumn("CON_FECHA", GetType(System.String))
        Dim dtMedHist_columna3 As New DataColumn("MED_NOMBRE", GetType(System.String))
        Dim dtMedHist_columna4 As New DataColumn("MED_ID", GetType(System.Single))

        dtt_conHistMedicos.Columns.Add(dtMedHist_columna1)
        dtt_conHistMedicos.Columns.Add(dtMedHist_columna2)
        dtt_conHistMedicos.Columns.Add(dtMedHist_columna3)
        dtt_conHistMedicos.Columns.Add(dtMedHist_columna4)



        '************************************************
        '  GRID ARRIBA TRATAMIENTO PACIENTE
        '************************************************
        Dim dtcV_columna1 As New DataColumn("tto_fecha", GetType(System.String))
        Dim dtcV_columna2 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcV_columna3 As New DataColumn("I_PRD_DESCRIPCION", GetType(System.String))
        Dim dtcV_columna4 As New DataColumn("EDAD", GetType(System.String))
        Dim dtcV_columna5 As New DataColumn("tto_cantidad", GetType(System.Single))
        Dim dtcV_columna6 As New DataColumn("I_UNI_DESCRIPCION", GetType(System.String))
        Dim dtcV_columna7 As New DataColumn("vac_lote", GetType(System.String))
        Dim dtcV_columna8 As New DataColumn("TTO_SOLUCIONES", GetType(System.String))
        Dim dtcV_columna9 As New DataColumn("TTO_CONTENIDO", GetType(System.String))
        Dim dtcV_columna10 As New DataColumn("VIA", GetType(System.String))
        Dim dtcV_columna11 As New DataColumn("COMP", GetType(System.String))
        Dim dtcV_columna12 As New DataColumn("ORIGEN", GetType(System.String))
        'Dim dtcV_columna13 As New DataColumn("FEC_VENC", GetType(System.String))
        Dim dtcV_columna14 As New DataColumn("I_PRD_FRASCOS", GetType(System.Single))

        dtt_TTo.Columns.Add(dtcV_columna1)
        dtt_TTo.Columns.Add(dtcV_columna2)
        dtt_TTo.Columns.Add(dtcV_columna3)
        dtt_TTo.Columns.Add(dtcV_columna4)
        dtt_TTo.Columns.Add(dtcV_columna5)
        dtt_TTo.Columns.Add(dtcV_columna6)
        dtt_TTo.Columns.Add(dtcV_columna7)
        dtt_TTo.Columns.Add(dtcV_columna8)
        dtt_TTo.Columns.Add(dtcV_columna9)
        dtt_TTo.Columns.Add(dtcV_columna10)
        dtt_TTo.Columns.Add(dtcV_columna11)
        dtt_TTo.Columns.Add(dtcV_columna12)
        'dtt_TTO.Columns.Add(dtcV_columna13)
        dtt_TTo.Columns.Add(dtcV_columna14)

        If actualizaDtsTTO(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), "PACIENTE") = True Then
            dgv_TToPaciente.Visible = True
            iniciaGridTto()
        Else
            dgv_TToPaciente.Visible = False
        End If

        '******************************************
        '******************************************
        ' CARGA DE ENCUESTA RCAT
        '******************************************
        '******************************************

        Dim respuestas As String = obtieneDatosRCAT(Age_Id)

        Dim arreglo As String() = Nothing

        arreglo = Split(respuestas, "º")

        For i = 0 To UBound(arreglo)

            Select Case i
                Case 0
                    Select Case arreglo(i)
                        Case "Nunca"
                            chk_nunca1.Checked = True

                        Case "Rara"
                            chk_rara1.Checked = True

                        Case "Avec"
                            chk_aveces1.Checked = True

                        Case "Amenu"
                            chk_amenudo1.Checked = True

                        Case "Muy"
                            chk_Muy1.Checked = True
                    End Select

                Case 1
                    Select Case arreglo(i)
                        Case "Nunca"
                            chk_nunca2.Checked = True

                        Case "Rara"
                            chk_rara2.Checked = True

                        Case "Avec"
                            chk_aveces2.Checked = True

                        Case "Amenu"
                            chk_amenudo2.Checked = True

                        Case "Muy"
                            chk_Muy2.Checked = True
                    End Select

                Case 2
                    Select Case arreglo(i)
                        Case "Nunca"
                            chk_nunca3.Checked = True

                        Case "Rara"
                            chk_rara3.Checked = True

                        Case "Avec"
                            chk_aveces3.Checked = True

                        Case "Amenu"
                            chk_amenudo3.Checked = True

                        Case "Muy"
                            chk_Muy3.Checked = True
                    End Select

                Case 3
                    Select Case arreglo(i)
                        Case "Nunca"
                            chk_nunca4.Checked = True

                        Case "Rara"
                            chk_rara4.Checked = True

                        Case "Avec"
                            chk_aveces4.Checked = True

                        Case "Amenu"
                            chk_amenudo4.Checked = True

                        Case "Muy"
                            chk_Muy4.Checked = True
                    End Select

                Case 4
                    Select Case arreglo(i)
                        Case "Nunca"
                            chk_nunca5.Checked = True

                        Case "Rara"
                            chk_rara5.Checked = True

                        Case "Avec"
                            chk_aveces5.Checked = True

                        Case "Amenu"
                            chk_amenudo5.Checked = True

                        Case "Muy"
                            chk_Muy5.Checked = True
                    End Select

                Case 5
                    Select Case arreglo(i)
                        Case "Nunca"
                            chk_nunca6.Checked = True

                        Case "Rara"
                            chk_rara6.Checked = True

                        Case "Avec"
                            chk_aveces6.Checked = True

                        Case "Amenu"
                            chk_amenudo6.Checked = True

                        Case "Muy"
                            chk_Muy6.Checked = True
                    End Select
            End Select
        Next


    End Sub

    Private Sub iniciaGridTto()
        dgv_TToPaciente.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_TToPaciente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_TToPaciente.Columns("tto_fecha").HeaderText = "FECHA"
        dgv_TToPaciente.Columns("tto_fecha").Width = 70

        dgv_TToPaciente.Columns("I_PRD_ID").HeaderText = "SERIE"
        dgv_TToPaciente.Columns("I_PRD_ID").Width = 50

        dgv_TToPaciente.Columns("I_PRD_DESCRIPCION").HeaderText = "DESCRIPCION"
        dgv_TToPaciente.Columns("I_PRD_DESCRIPCION").Width = 120

        dgv_TToPaciente.Columns("EDAD").HeaderText = "EDAD"
        dgv_TToPaciente.Columns("EDAD").Width = 50

        dgv_TToPaciente.Columns("tto_cantidad").HeaderText = "#"
        dgv_TToPaciente.Columns("tto_cantidad").Width = 40

        dgv_TToPaciente.Columns("I_UNI_DESCRIPCION").HeaderText = "UNIDAD"
        dgv_TToPaciente.Columns("I_UNI_DESCRIPCION").Width = 60

        dgv_TToPaciente.Columns("vac_lote").HeaderText = "LOTE"
        dgv_TToPaciente.Columns("vac_lote").Width = 60

        dgv_TToPaciente.Columns("TTO_SOLUCIONES").Visible = False
        dgv_TToPaciente.Columns("TTO_CONTENIDO").Visible = False

        dgv_TToPaciente.Columns("VIA").HeaderText = "VIA"
        dgv_TToPaciente.Columns("VIA").Width = 65

        dgv_TToPaciente.Columns("COMP").HeaderText = "COMP"
        dgv_TToPaciente.Columns("COMP").Width = 160

        dgv_TToPaciente.Columns("ORIGEN").HeaderText = "ORIGEN"
        dgv_TToPaciente.Columns("ORIGEN").Width = 175

        'dgv_TToPaciente.Columns("FEC_VENC").HeaderText = "FEC VENC"
        'dgv_TToPaciente.Columns("FEC_VENC").Visible = False

        dgv_TToPaciente.Columns("I_PRD_FRASCOS").HeaderText = "FCOS"
        dgv_TToPaciente.Columns("I_PRD_FRASCOS").Visible = False


        With dgv_TToPaciente
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

    End Sub

    Private Function actualizaDtsTTO(ByVal pac_id As Integer, ByVal tipo As String) As Boolean
        'Dim ser_id As Integer

        dtt_TTo.Clear()

        opr_res.LlenarGridTTO(dgv_TToPaciente, dtt_TTo, pac_id, tipo)
        If dtt_TTo.Rows.Count > 0 Then
            actualizaDtsTTO = True
        Else
            actualizaDtsTTO = False
        End If

    End Function


    Private Sub actualizaDtsInfoPac(ByVal Age_id As Integer)
        dtt_InfoPac.Clear()
        opr_res.LlenarGridInfoPaciente(dgv_InfoPaciente, Age_id, dtt_InfoPac)
    End Sub




    Private Sub actualizaDtsMedicoTratante(ByVal Age_id As Integer, ByRef med_id As String)
        Dim i As Integer
        Dim med_id1 As String
        dtt_MedTratante.Clear()

        If opr_res.EsGrupo(med_id) = "GRUPO" Then
            med_id1 = opr_res.DevuelveGrupoGrupo(med_id)
            med_id1 = Mid(med_id1, 1, Len(med_id1) - 1)
            opr_res.LlenarGridGrupoMedico(dgv_MedicosTratantes, Age_id, dtt_MedTratante, med_id1)
        Else
            opr_res.LlenarGridGrupoMedico(dgv_MedicosTratantes, Age_id, dtt_MedTratante, med_id)
        End If



        For i = 0 To dtt_MedTratante.Rows.Count - 1

            Select Case Trim(dgv_MedicosTratantes.Rows(i).Cells(6).Value())
                Case "PENDIENTE"
                    dgv_MedicosTratantes.Rows(i).Cells(6).Style.BackColor = Color.Lime
                Case "INGRESADO"
                    dgv_MedicosTratantes.Rows(i).Cells(6).Style.BackColor = Color.Green
                Case "REPORTADO"
                    dgv_MedicosTratantes.Rows(i).Cells(6).Style.BackColor = Color.LightYellow
                Case "CERRADO"
                    dgv_MedicosTratantes.Rows(i).Cells(6).Style.BackColor = Color.Red
            End Select
        Next
    End Sub


    Public Sub actualizaDtsCieConsulta(ByVal Age_id As Integer, ByVal med_id As Integer)
        dtt_cieConsulta.Clear()
        opr_res.LlenarGridCieConsulta(dgv_Cie10Medico, Age_id, med_id, dtt_cieConsulta)

    End Sub


    Public Sub actualizaDtsCieConsultaHist(ByVal Age_id As Integer, ByVal med_id As Integer)
        dtt_cieConsulta.Clear()
        opr_res.LlenarGridCieConsulta(dgv_CieHistorico, Age_id, med_id, dtt_cieConsulta)

    End Sub

    Public Sub actualizaDtsConHist(ByVal pac_id As Integer)
        dtt_conHist.Clear()
        opr_res.LlenarGridConHist(dgv_ConsultaHistorico, pac_id, dtt_conHist)

    End Sub


    Public Function actualizaDtsConHistMedicos(ByVal pac_id As Integer, ByVal med_id As Integer, ByVal Age_id As Integer) As Boolean
        dtt_conHistMedicos.Clear()
        If opr_res.LlenarGridConHistMedicos(dgv_ConsultaHistoricoMedico, pac_id, Age_id, dtt_conHistMedicos) = True Then
            actualizaDtsConHistMedicos = True
        Else
            actualizaDtsConHistMedicos = False
        End If
    End Function

    Private Sub btn_ssalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub dgv_InfoPermanente_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dgv_InfoPermanente.Paint
        If blnAjustarCeldas = True Then
            blnAjustarCeldas = False
            dgv_InfoPermanente.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        End If
    End Sub

    Private Sub btn_SolicitarVacuna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SolicitarVacuna.Click
        If CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()) > 0 Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            Dim turno As String = opr_pedido.devuelveOrdenPedido(Ped_Id)

            Dim frm_MDIChild As New frm_VacunaTratamiento()
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.ventana_tipo = 1 ''1 PACIENTE, 0 MEDICO CLIENTE
            frm_MDIChild.pac_id = CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
            frm_MDIChild.lbl_paciente.Text = dgv_InfoPaciente.CurrentRow.Cells("pac_nombre").Value()
            frm_MDIChild.Age_id = Age_Id
            frm_MDIChild.Age_resumen = age_resumen
            frm_MDIChild.turno = turno
            frm_MDIChild.med_id = dgv_MedicosTratantes.CurrentRow.Cells("Med_id").Value()
            'frm_MDIChild.med_id = 8
            frm_MDIChild.ShowDialog(Me.ParentForm)
            Me.Cursor = System.Windows.Forms.Cursors.Arrow

        Else
            opr_pedido.VisualizaMensaje("Agende un paciente para obtener asistenaci de CIE10", 300)
        End If

    End Sub

    Private Sub btn_RecetaMedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RecetaMedica.Click


        Dim frm_MDIChild As New frm_Receta()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.pac_id = CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        frm_MDIChild.lbl_paciente.Text = dgv_InfoPaciente.CurrentRow.Cells("pac_nombre").Value()
        frm_MDIChild.lbl_cedula.Text = dgv_InfoPaciente.CurrentRow.Cells("pac_doc").Value()
        frm_MDIChild.Age_id = Age_Id
        frm_MDIChild.Ped_id = Ped_Id
        frm_MDIChild.Ped_turno = ped_turno
        frm_MDIChild.Med_nombre = dgv_MedicosTratantes.CurrentRow.Cells("med_nombre").Value()
        frm_MDIChild.Med_id = dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value()
        frm_MDIChild.ShowDialog(Me.ParentForm)

    End Sub


    'Private Sub dgv_MedicosTratantes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_MedicosTratantes.CellContentClick
    '    Dim MedTexto As String

    '    txt_HipDiagnostica.BackColor = System.Drawing.Color.PaleGoldenrod
    '    txt_HipDiagnostica.ReadOnly = True
    '    txt_HipDiagnostica.Text = ""

    '    txt_HipDiagnostica.Text = dgv_MedicosTratantes.CurrentRow.Cells("con_diagnostico").Value
    '    'btn_RecetaMedica.Enabled = True
    '    'btn_SolicitarVacuna.Enabled = True

    '    lbl_MDTratante.Text = dgv_MedicosTratantes.CurrentRow.Cells("med_nombre").Value

    '    btn_DiagObs.Enabled = True

    '    btn_Finalizar.Enabled = True

    '    btn_DiagEditar.Enabled = True

    '    btn_DiagGuardar.Enabled = True

    '    btn_Cie10.Enabled = True

    'End Sub

    Private Sub btn_DiagEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DiagEditar.Click
        txt_HipDiagnostica.BackColor = System.Drawing.Color.White
        txt_HipDiagnostica.ReadOnly = False
        txt_HipDiagnostica.Focus()

    End Sub

    Private Sub btn_DiagGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DiagGuardar.Click

        If opr_pedido.GestionaConsulta(0, dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value, dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value, Age_Id, Trim(txt_HipDiagnostica.Text), "", "INGRESADO", "Update", var_Cie4) = True Then
            actualizaDtsMedicoTratante(Age_Id, med_id)

            opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
        Else
            opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
        End If



        txt_HipDiagnostica.BackColor = System.Drawing.Color.PaleGoldenrod
        txt_HipDiagnostica.ReadOnly = True
    End Sub

    Private Sub btn_DiagObs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DiagObs.Click

        Dim msg As String = "Ingrese el comnetario: "
        Dim comentario As String = InputBox(msg, "ANALISYS")

        If comentario <> "" Then
            If opr_pedido.InsertarComentarioConsulta(Age_Id, dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value, comentario) = True Then
                actualizaDtsMedicoTratante(Age_Id, med_id)
                opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
            Else
                opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
            End If
        End If
    End Sub

    Private Sub dgv_MedicosTratantes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_MedicosTratantes.CellClick


        txt_HipDiagnostica.BackColor = System.Drawing.Color.PaleGoldenrod
        txt_HipDiagnostica.ReadOnly = True
        txt_HipDiagnostica.Text = ""

        txt_HipDiagnostica.Text = dgv_MedicosTratantes.CurrentRow.Cells("con_diagnostico").Value

        'btn_RecetaMedica.Enabled = True
        'btn_SolicitarVacuna.Enabled = True

        lbl_MDTratante.Text = dgv_MedicosTratantes.CurrentRow.Cells("med_nombre").Value

        actualizaDtsCieConsulta(Age_Id, CInt(dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value))

        med_grafico = CInt(dgv_MedicosTratantes.CurrentRow.Cells("med_grafico").Value)

        Select Case med_grafico
            Case 0
                btn_Grafico.Visible = False
                pic_Grafico.SendToBack()

                dgv_Cutaneas.Visible = True

            Case 1
                btn_Grafico.Visible = True
                btn_Grafico.Text = "FISIOGRAMA"
                graf_name = opr_res.ConsultaGraf_name(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value), 1)

                If graf_name = "" Then
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\Fisiograma.PNG")
                    pic_Grafico.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\" & graf_name)
                    pic_Grafico.SizeMode = PictureBoxSizeMode.StretchImage
                End If

            Case 2
                btn_Grafico.Visible = True
                btn_Grafico.Text = "ODONTOGRAMA"

                graf_name = opr_res.ConsultaGraf_name(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value), 2)

                If graf_name = "" Then
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\Odontograma.PNG")
                Else
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\" & graf_name)
                    pic_Grafico.SizeMode = PictureBoxSizeMode.StretchImage
                End If
        End Select

        btn_DiagObs.Enabled = True
        btn_DiagObs.BackColor = Color.LightSkyBlue

        btn_Finalizar.Enabled = True
        btn_Finalizar.BackColor = Color.LightSkyBlue

        btn_DiagEditar.Enabled = True
        btn_DiagEditar.BackColor = Color.LightSkyBlue

        btn_DiagGuardar.Enabled = True
        btn_DiagGuardar.BackColor = Color.LightSkyBlue

        btn_Cie10.Enabled = True
        btn_Cie10.BackColor = Color.LightSkyBlue

        btn_SolicitarVacuna.Enabled = True
        btn_SolicitarVacuna.BackColor = Color.LightSkyBlue

        btn_RecetaMedica.Enabled = True
        btn_RecetaMedica.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Finalizar.Click
        Dim i As Integer
        'For i = 0 To dgv_MedicosTratantes.Rows.Count - 1


        If opr_pedido.GestionaConsulta(0, dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value, dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value, Age_Id, Trim(txt_HipDiagnostica.Text), "", "CERRADO", "Update", var_Cie4) = True Then
            actualizaDtsMedicoTratante(Age_Id, med_id)
        Else
            opr_pedido.VisualizaMensaje("problemas para CERRAR la consulta", 200)
        End If

        txt_HipDiagnostica.BackColor = System.Drawing.Color.PaleGoldenrod
        txt_HipDiagnostica.ReadOnly = True

        'Next

        opr_pedido.VisualizaMensaje("Diagnostico médico " & dgv_MedicosTratantes.CurrentRow.Cells("med_nombre").Value() & " CERRADO satisfactoriamente", 200)
    End Sub


    Private Sub btn_Cie10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cie10.Click
        If CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()) > 0 Then
            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim i As Integer
            Dim str_Cie10 As String

            Dim frm_MDIChild As New frm_Cie10()
            frm_MDIChild.frm_refer_main = Me.ParentForm
            frm_MDIChild.ShowDialog(Me.ParentForm)
            'txt_Cie10.Text = frm_MDIChild.consulta
            var_Cie4 = frm_MDIChild.var_cie4

            dgv_Cie10Medico.DataSource = Nothing

            If opr_pedido.GestionaConsultaCie10(Age_Id, dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value, var_Cie4, "Insertar") = True Then
                actualizaDtsCieConsulta(Age_Id, CInt(dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value))

            Else
                'opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
            End If

            Me.Cursor = System.Windows.Forms.Cursors.Arrow

        Else
            opr_pedido.VisualizaMensaje("Agende un paciente para obtener asistenaci de CIE10", 300)
        End If

    End Sub



    Private Sub dgv_Cie10Medico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Cie10Medico.KeyDown

        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            If MsgBox("Desea eliminar el codigo ?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                'Operaciones al precionar DELETE sobre el grid


                If opr_pedido.GestionaConsultaCie10(Age_Id, dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value, dgv_Cie10Medico.CurrentRow.Cells("CodCie").Value, "Eliminar") = True Then
                    actualizaDtsCieConsulta(Age_Id, med_id)
                    'opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)

                Else
                    'opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
                End If


            Else

            End If
        End If
    End Sub


    Private Sub dgv_ConsultaHistoricoMedico_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ConsultaHistoricoMedico.CellClick
        actualizaDtsCieConsultaHist(Age_Id, CInt(dgv_ConsultaHistoricoMedico.CurrentRow.Cells("MED_ID").Value))
        lbl_TotCie.Text = CStr(dgv_CieHistorico.Rows.Count)
    End Sub



    Private Sub dgv_ConsultaHistorico_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ConsultaHistorico.CellClick

        lbl_TotCie.Text = ""

        If actualizaDtsConHistMedicos(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value()), CInt(dgv_ConsultaHistorico.CurrentRow.Cells("MED_ID").Value()), CInt(dgv_ConsultaHistorico.CurrentRow.Cells("AGE_ID").Value())) = True Then

            dgv_ConsultaHistoricoMedico.Columns("AGE_ID").HeaderText = "ID"
            dgv_ConsultaHistoricoMedico.Columns("AGE_ID").Visible = False

            dgv_ConsultaHistoricoMedico.Columns("CON_FECHA").HeaderText = "FECHA"
            dgv_ConsultaHistoricoMedico.Columns("CON_FECHA").Width = 130

            dgv_ConsultaHistoricoMedico.Columns("MED_NOMBRE").HeaderText = "MEDICO"
            dgv_ConsultaHistoricoMedico.Columns("MED_NOMBRE").Width = 290

            dgv_ConsultaHistoricoMedico.Columns("MED_ID").HeaderText = "IDM"
            dgv_ConsultaHistoricoMedico.Columns("MED_ID").Visible = False

            dgv_ConsultaHistoricoMedico.Columns("AGE_ESTADO").HeaderText = "ESTADO"
            dgv_ConsultaHistoricoMedico.Columns("AGE_ESTADO").Visible = False

            With dgv_ConsultaHistoricoMedico
                .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

            If opr_pedido.LeerDermografismo(CInt(dgv_ConsultaHistorico.CurrentRow.Cells("AGE_ID").Value())) = 1 Then
                cargaGridCUT_HIST("DERMOGRAFICO: Si" & vbCrLf)

            Else
                cargaGridCUT_HIST("DERMOGRAFICO: No" & vbCrLf)
            End If

            Dim opr_agenda As New Cls_Agenda()
            Dim Exa_str As String()
            Dim Exa_id As String()
            Dim i As Integer

            Exa_str = Split(opr_agenda.BuscaExamenesSolicita(1, "NORMAL"), "º")
            For i = 0 To UBound(Exa_str) - 1
                Exa_id = Split(Exa_str(i), ",")

                Select Case Exa_id(0)
                    Case 401310 'CUTANEAS ALIMENTOS
                        Dim datosCutAlimentos As String = obtieneDatosTramaCutaneas(CInt(dgv_ConsultaHistorico.CurrentRow.Cells("PED_ID").Value()), Exa_id(0), "ALIMENTOS")
                        If datosCutAlimentos <> "" Then
                            cargaGridCUT_HIST(datosCutAlimentos)
                        End If

                    Case 401325 'CUTANEAS SUSTANIAS
                        Dim datosCutAlimentos As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "SUSTANCIAS")
                        If datosCutAlimentos <> "" Then
                            cargaGridCUT_HIST(datosCutAlimentos)
                        End If

                    Case 401311 'CUTANEAS INHALANTES
                        Dim datosCutInhalantes As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "INHALANTES")
                        If datosCutInhalantes <> "" Then
                            cargaGridCUT_HIST(datosCutInhalantes)
                        End If

                    Case 401312 'CUTANEAS MEDICAMENTOS
                        Dim datosCutMedicamentos As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "MEDICAMENTOS")
                        If datosCutMedicamentos <> "" Then
                            cargaGridCUT_HIST(datosCutMedicamentos)
                        End If

                    Case 401321 'CUTANEAS ANTIBIOTICOS
                        Dim datosCutAntibioticos As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "ANTIBIOTICOS")
                        If datosCutAntibioticos <> "" Then
                            cargaGridCUT_HIST(datosCutAntibioticos)
                        End If

                    Case 401322 'CUTANEAS OTROS MEDICAMENTOS
                        Dim datosCutOtrasS As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "OTRAS SUSTANCIAS")
                        If datosCutOtrasS <> "" Then
                            cargaGridCUT_HIST(datosCutOtrasS)
                        End If

                    Case 401323 'CUTANEAS NIÑOS ALIMENTOS
                        Dim datosCutInfAlimen As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "NIÑOS ALIMENTOS")
                        If datosCutInfAlimen <> "" Then
                            cargaGridCUT_HIST(datosCutInfAlimen)
                        End If

                    Case 401324 'CUTANEAS NIÑOS INHALANTES
                        Dim datosCutInfInha As String = obtieneDatosTramaCutaneas(Ped_Id, Exa_id(0), "NIÑOS INHALANTES")
                        If datosCutInfInha <> "" Then
                            cargaGridCUT_HIST(datosCutInfInha)
                        End If
                End Select
            Next

            cargaGridCUT_HIST(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab1"))
            cargaGridCUT_HIST(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab2"))
            cargaGridCUT_HIST(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab3"))
            cargaGridCUT_HIST(obtieneDatosTramaLab(dgv_InfoPaciente.CurrentRow.Cells("Pac_id").Value, "hic_DatosLab4"))

        End If


    End Sub

    Private Sub btn_ssalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ssalir.Click
        Me.Close()
    End Sub


    Private Sub btn_FinalizarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FinalizarTodo.Click
        Dim i As Integer

        If MsgBox("Esta seguro que desea CERRAR TOTALMENTE LA CONSULTA?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then

            Dim arre_medico As String()
            arre_medico = Split(opr_pedido.ConsultaMedicosGrupo(med_id), ",")

            For i = 0 To UBound(arre_medico) - 1

                If opr_pedido.GestionaConsulta(0, arre_medico(i), dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value, Age_Id, Trim(txt_HipDiagnostica.Text), "", "CERRADO", "Update", var_Cie4) = True Then
                    'actualizaDtsMedicoTratante(Age_Id, med_id)
                Else
                    opr_pedido.VisualizaMensaje("Problemas para CERRAR TOTALMENTE la consulta", 200)
                End If

                txt_HipDiagnostica.BackColor = System.Drawing.Color.PaleGoldenrod
                txt_HipDiagnostica.ReadOnly = True

            Next
            actualizaDtsMedicoTratante(Age_Id, med_id)
            opr_pedido.VisualizaMensaje("Consulta médica CERRADA TOTALMENTE ", 200)
        Else

        End If

    End Sub


    Private Sub pic_Grafico_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Grafico.DoubleClick

        pic_Grafico.Image.Dispose()
        pic_Grafico.Image = Nothing

        Dim rutaBorrar As String = graf_name

        'File.Delete(Environment.CurrentDirectory & "\Graficos\" & rutaBorrar)

        Dim frm_MDIChild As New frm_Graficos()
        'frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.pac_id = CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value())
        frm_MDIChild.lbl_paciente.Text = dgv_InfoPaciente.CurrentRow.Cells("pac_nombre").Value()

        frm_MDIChild.graf_name = graf_name
        frm_MDIChild.graf_tipo = dgv_MedicosTratantes.CurrentRow.Cells("med_grafico").Value()
        frm_MDIChild.ShowDialog(Me.ParentForm)

    End Sub

    Private Sub frm_ConsultaMedico_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Select Case med_grafico
            Case 0
                btn_Examenes.Text = "Examenes realizados"
                dgv_Cutaneas.Visible = True
                pic_Grafico.SendToBack()

            Case 1
                dgv_Cutaneas.Visible = False
                pic_Grafico.BringToFront()

                graf_name = opr_res.ConsultaGraf_name(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value), 1)

                If graf_name = "" Then
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\Fisiograma.PNG")
                    pic_Grafico.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\" & graf_name)
                    pic_Grafico.SizeMode = PictureBoxSizeMode.StretchImage
                End If

            Case 2
                dgv_Cutaneas.Visible = False
                pic_Grafico.BringToFront()

                graf_name = opr_res.ConsultaGraf_name(CInt(dgv_InfoPaciente.CurrentRow.Cells("pac_id").Value), 2)

                If graf_name = "" Then
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\Odontograma.PNG")
                Else
                    pic_Grafico.Image = Image.FromFile(Environment.CurrentDirectory & "\Graficos\" & graf_name)
                End If
        End Select

    End Sub


    Private Sub btn_btn_Examenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Examenes.Click
        dgv_Cutaneas.Visible = True
        pic_Grafico.SendToBack()
    End Sub

    Private Sub btn_Grafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grafico.Click
        dgv_Cutaneas.Visible = False
        pic_Grafico.BringToFront()
    End Sub
End Class