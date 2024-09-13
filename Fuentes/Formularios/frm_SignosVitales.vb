Imports System.Data.SqlClient


Public Class frm_SignosVitales
    Dim opr_pedido As New Cls_Pedido
    Public pac_id As Integer
    Dim arr_datosSV As String()
    Dim arr_fr As String()
    Public frm_refer_main As Frm_Main
    Dim opr_agenda As New Cls_Agenda()
    Dim opr_res As New Cls_Resultado()
    Private WithEvents dtt_signosv As New DataTable("Registros")


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'GUARDO SIGNOS VITALES
        opr_pedido.GuardaSignos(Me, pac_id)
        actualizaDtsSignosV(pac_id)
    End Sub


    Private Sub cargaGrid(ByVal datos As String, ByVal dgv As Windows.Forms.DataGridView, ByVal dt As DataTable)

        With dgv
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Transparent
            .DefaultCellStyle.BackColor = Color.Transparent
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        'With dgvAlcohol
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.Transparent
        '    .DefaultCellStyle.BackColor = Color.Transparent
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'End With

        'With dgvSedent
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.Transparent
        '    .DefaultCellStyle.BackColor = Color.Transparent
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'End With

        'With dgvDrogas
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.Transparent
        '    .DefaultCellStyle.BackColor = Color.Transparent
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'End With


        Dim row As DataRow = dt.NewRow()
        row("codigo") = datos
        dt.Rows.Add(row)

        dt.AcceptChanges()
        dgv.DataSource = dt
        'dgvAlcohol.DataSource = dt
        'dgvSedent.DataSource = dt
        'dgvDrogas.DataSource = dt

    End Sub


    Private Sub frm_SignosVitales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dtcA_columna1 As New DataColumn("pac_id", GetType(System.Double))
        Dim dtcA_columna2 As New DataColumn("paciente", GetType(System.String))
        Dim dtcA_columna3 As New DataColumn("sig_fecha", GetType(System.String))
        Dim dtcA_columna4 As New DataColumn("sig_TensArt", GetType(System.String))
        Dim dtcA_columna5 As New DataColumn("sig_FrecCard", GetType(System.String))
        Dim dtcA_columna6 As New DataColumn("sig_FrecResp", GetType(System.String))
        Dim dtcA_columna7 As New DataColumn("sig_Temp", GetType(System.String))
        Dim dtcA_columna8 As New DataColumn("sig_Satur", GetType(System.String))
        Dim dtcA_columna9 As New DataColumn("sig_Peso", GetType(System.String))
        Dim dtcA_columna10 As New DataColumn("sig_Audiometria", GetType(System.String))
        dtt_signosv.Columns.Add(dtcA_columna1)
        dtt_signosv.Columns.Add(dtcA_columna2)
        dtt_signosv.Columns.Add(dtcA_columna3)
        dtt_signosv.Columns.Add(dtcA_columna4)
        dtt_signosv.Columns.Add(dtcA_columna5)
        dtt_signosv.Columns.Add(dtcA_columna6)
        dtt_signosv.Columns.Add(dtcA_columna7)
        dtt_signosv.Columns.Add(dtcA_columna8)
        dtt_signosv.Columns.Add(dtcA_columna9)
        dtt_signosv.Columns.Add(dtcA_columna10)

        If actualizaDtsSignosV(pac_id) = True Then

            dgv_SignosV.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgv_SignosV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgv_SignosV.Columns("pac_id").Visible = False

            dgv_SignosV.Columns("paciente").HeaderText = "PACIENTE"
            dgv_SignosV.Columns("paciente").Width = 120
            dgv_SignosV.Columns("paciente").Visible = False
            'dgv_SignosV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgv_SignosV.Columns("sig_fecha").HeaderText = "FECHA"
            dgv_SignosV.Columns("sig_fecha").Width = 70

            dgv_SignosV.Columns("sig_TensArt").HeaderText = "T. ARTERIAL"
            dgv_SignosV.Columns("sig_TensArt").Width = 85

            dgv_SignosV.Columns("sig_FrecCard").HeaderText = "F. CARDIACA"
            dgv_SignosV.Columns("sig_FrecCard").Width = 85

            dgv_SignosV.Columns("sig_FrecResp").HeaderText = "F. RESPIR."
            dgv_SignosV.Columns("sig_FrecResp").Width = 85

            dgv_SignosV.Columns("sig_Temp").HeaderText = "TEMPERATURA"
            dgv_SignosV.Columns("sig_Temp").Width = 85

            dgv_SignosV.Columns("sig_Satur").HeaderText = "SATURACION"
            dgv_SignosV.Columns("sig_Satur").Width = 85

            dgv_SignosV.Columns("sig_Peso").HeaderText = "PESO"
            dgv_SignosV.Columns("sig_Peso").Width = 80

            dgv_SignosV.Columns("sig_Audiometria").HeaderText = "ESPIROMETRIA"
            dgv_SignosV.Columns("sig_Audiometria").Width = 100

            With dgv_SignosV
                .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        Else
        End If



        If opr_pedido.ExisteSignosVitales(pac_id) > 0 Then
            arr_datosSV = Split(opr_pedido.LeerSignosVitales(pac_id), "|")
            If UBound(arr_datosSV) > 1 Then
                lbl_hc_fechaSV.Text = arr_datosSV(2)
                txt_hc_TenArterial.Text = arr_datosSV(3)
                txt_hc_FreCardiaca.Text = arr_datosSV(4)
                txt_hc_FrecResp.Text = arr_datosSV(5)
                txt_hc_Temperatura.Text = arr_datosSV(6)
                txt_hc_Saturacion.Text = arr_datosSV(7)
                txt_hc_Peso.Text = arr_datosSV(8)
                txt_hc_Audiometria.Text = arr_datosSV(9)
            End If
        End If

        txt_hc_TenArterial.Tag = "ADULTOS (60 A 64 años): 134 - 87" & vbCrLf & _
                                 "ADULTOS (40 A 55 años): 125 - 86" & vbCrLf & _
                                 "ADULTOS JOVENES (17 A 19 AÑOS) <= 120 - <= 85"

        If opr_pedido.TieneFactoresRiesgo(pac_id) > 0 Then
            arr_fr = Split(opr_pedido.LeerFactoresRiesgo(pac_id), "|")
            If UBound(arr_fr) > 1 Then
                txt_FR_Cigarro.Text = arr_fr(0)
                txt_FR_Alcohol.Text = arr_fr(1)
                txt_FR_Sedent.Text = arr_fr(2)
                txt_FR_Drogas.Text = arr_fr(3)
            End If
        End If

    End Sub


    Private Function actualizaDtsSignosV(ByVal pac_id As Integer) As Boolean

        Dim calendario As String()
        Dim dias As String()
        Dim diahoy As String
        Dim diaNum As Char
        Dim i As Integer
        Dim age_id As Integer = 0
        Dim bandera_dia As Boolean = False
        dtt_signosv.Clear()


        opr_res.LlenarGridSignosV(dgv_SignosV, dtt_signosv, pac_id)
        If dtt_signosv.Rows.Count > 0 Then
            actualizaDtsSignosV = True
        Else
            actualizaDtsSignosV = False
        End If

    End Function

    Private Sub btn_SalirSignosV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalirSignosV.Click
        Me.Close()
    End Sub


    Private Sub lst_Cigarro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Cigarro.SelectedIndexChanged
        txt_FR_Cigarro.Text = lst_Cigarro.SelectedItem
    End Sub

    Private Sub lst_Alcohol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Alcohol.SelectedIndexChanged
        txt_FR_Alcohol.Text = lst_Alcohol.SelectedItem

    End Sub

    Private Sub lst_Sedent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Sedent.SelectedIndexChanged
        txt_FR_Sedent.Text = lst_Sedent.SelectedItem

    End Sub

    Private Sub lst_Drogas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Drogas.SelectedIndexChanged
        txt_FR_Drogas.Text = lst_Drogas.SelectedItem

    End Sub

    Private Sub btn_AddFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddFR.Click
        'GUARDO FR
        opr_pedido.GuardaFaciesgo(Me, pac_id)
        'actualizaDtsSignosV(pac_id)
    End Sub
End Class