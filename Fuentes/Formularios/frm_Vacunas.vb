Public Class frm_Vacunas
    Dim dtVacuna As DataTable = New DataTable()
    Public frm_refer_main As Frm_Main
    Public pac_id As Integer

    Private Sub frm_Vacunas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtcDatosMed1 As New DataColumn("Vacuna", GetType(System.String))
        dtVacuna.Columns.Add(dtcDatosMed1)

        Dim dtcDatosMed2 As New DataColumn("Presentacion", GetType(System.String))
        dtVacuna.Columns.Add(dtcDatosMed2)

        Dim dtcDatosMed3 As New DataColumn("Marca", GetType(System.String))
        dtVacuna.Columns.Add(dtcDatosMed3)

        Dim dtcDatosMed4 As New DataColumn("Existencia", GetType(System.String))
        dtVacuna.Columns.Add(dtcDatosMed4)

        'Dim dtcDatosMed5 As New DataColumn("Marca", GetType(System.String))
        'dtVacuna.Columns.Add(dtcDatosMed5)

        cargaGridVAC("VACUNA 1", "Ampolla 5 ml", "Physer", 20)
        cargaGridVAC("VACUNA 2", "Ampolla 5 ml", "Roche", 12)
        cargaGridVAC("VACUNA 3", "Jarabe 10 ml", "MSP", 8)

        dgv_Vacunas.Columns("Vacuna").Width = 150
        dgv_Vacunas.Columns("Presentacion").Width = 100
        dgv_Vacunas.Columns("Marca").Width = 100
        dgv_Vacunas.Columns("Existencia").Width = 30

    End Sub

    Private Sub cargaGridVAC(ByVal vacuna As String, ByVal Presentacion As String, ByVal Marca As String, ByVal Existencia As String)

        dgv_Vacunas.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Vacunas.DefaultCellStyle.SelectionForeColor = Color.LightSkyBlue
        dgv_Vacunas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgv_Vacunas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim row1 As DataRow = dtVacuna.NewRow()
        row1("Vacuna") = vacuna
        row1("Presentacion") = Presentacion
        row1("Marca") = Marca
        row1("Existencia") = Existencia
        dtVacuna.Rows.Add(row1)


        dtVacuna.AcceptChanges()
        dgv_Vacunas.DataSource = dtVacuna

    End Sub

    
    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    
End Class