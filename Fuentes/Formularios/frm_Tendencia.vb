Imports System
Imports System.Collections.Generic


Public Class frm_Tendencia

    Private WithEvents dtt_Tdcia As New DataTable("Registros")
    Private WithEvents dtt_TdciaN As New DataTable("Registros")

    Private WithEvents dtt_Consu As New DataTable("Registros")
    Private WithEvents dtt_ConsuN As New DataTable("Registros")

    Private WithEvents dtt_Consu_cli As New DataTable("Registros")
    Private WithEvents dtt_Consu_cliN As New DataTable("Registros")

    Private WithEvents dtt_CGeneral As New DataTable("Registros")
    Private WithEvents dtt_CGeneralA As New DataTable("Registros")
    Private WithEvents dtt_CGeneralN As New DataTable("Registros")

    Private WithEvents dtt_CDiario As New DataTable("Registros")
    Private WithEvents dtt_CDiarioN As New DataTable("Registros")

    Private WithEvents dtt_CDiario_cli As New DataTable("Registros")
    Private WithEvents dtt_CDiario_cliN As New DataTable("Registros")

    Dim opr_res As New Cls_Resultado()
    Dim pendiente As Double
    Dim interseccion As Double
    Dim i As Integer
    Dim tot As Long
    Dim var_mes As Integer
    Dim headerFont As New Font("Arial", 7, FontStyle.Bold)
    Dim opr_ped As New Cls_Pedido()
    

    Private Sub cargaExistencias()
        ''***********************************
        '' DGV EXISTENCIA ADULTOS 
        ''***********************************
        Dim dtcT_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcT_columna2 As New DataColumn("I_PRD_DESCRIPCION", GetType(System.String))
        Dim dtcT_columna3 As New DataColumn("CIRCULACION", GetType(System.String))
        Dim dtcT_columna4 As New DataColumn("EMPAQUE", GetType(System.String))
        Dim dtcT_columna5 As New DataColumn("CUARENTENA", GetType(System.String))

        Dim dtcT_columna6 As New DataColumn("EXISTENCIA", GetType(System.Single))
        Dim dtcT_columna7 As New DataColumn("TENDENCIA", GetType(System.Decimal))
        Dim dtcT_columna8 As New DataColumn("PORCENTAJE REAL", GetType(System.Decimal))

        Dim dtcT_columna9 As New DataColumn("FRECUENCIA", GetType(System.Single))
        Dim dtcT_columna10 As New DataColumn("PRODUCCION", GetType(System.String))

        dtt_Tdcia.Columns.Add(dtcT_columna1)
        dtt_Tdcia.Columns.Add(dtcT_columna2)
        dtt_Tdcia.Columns.Add(dtcT_columna3)
        dtt_Tdcia.Columns.Add(dtcT_columna4)
        dtt_Tdcia.Columns.Add(dtcT_columna5)
        dtt_Tdcia.Columns.Add(dtcT_columna6)
        dtt_Tdcia.Columns.Add(dtcT_columna7)
        dtt_Tdcia.Columns.Add(dtcT_columna8)
        dtt_Tdcia.Columns.Add(dtcT_columna9)
        dtt_Tdcia.Columns.Add(dtcT_columna10)

        actualizaDtsTendencia(dgv_Tendencia, "A", CInt(cmb_Anio.Text), dtt_Tdcia)

        dgv_Tendencia.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Tendencia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_Tendencia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_Tendencia.Columns("I_PRD_ID").Width = 40
        dgv_Tendencia.Columns("I_PRD_ID").HeaderText = "SERIE"
        dgv_Tendencia.Columns("I_PRD_DESCRIPCION").Width = 140
        dgv_Tendencia.Columns("I_PRD_DESCRIPCION").HeaderText = "DESCRIPCION"

        dgv_Tendencia.Columns("CIRCULACION").Width = 90
        dgv_Tendencia.Columns("CIRCULACION").HeaderText = "CIRCUL"

        dgv_Tendencia.Columns("EMPAQUE").Width = 90
        dgv_Tendencia.Columns("EMPAQUE").HeaderText = "EMPAQ"

        dgv_Tendencia.Columns("CUARENTENA").Width = 90
        dgv_Tendencia.Columns("CUARENTENA").HeaderText = "CUARE"

        dgv_Tendencia.Columns("EXISTENCIA").Width = 90
        dgv_Tendencia.Columns("EXISTENCIA").HeaderText = "EXIST"

        dgv_Tendencia.Columns("TENDENCIA").Width = 90
        dgv_Tendencia.Columns("TENDENCIA").HeaderText = "TEND"

        dgv_Tendencia.Columns("PORCENTAJE REAL").Width = 90
        dgv_Tendencia.Columns("PORCENTAJE REAL").HeaderText = "% REAL"

        dgv_Tendencia.Columns("FRECUENCIA").Width = 90
        dgv_Tendencia.Columns("FRECUENCIA").HeaderText = "FREC"

        dgv_Tendencia.Columns("PRODUCCION").Width = 90
        dgv_Tendencia.Columns("PRODUCCION").HeaderText = "PRODUCCION"

        With dgv_Tendencia
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        'EXISTENCIA
        For i = 0 To dgv_Tendencia.Rows.Count - 1
            tot = CLng(dgv_Tendencia.Rows(i).Cells(2).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(3).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(4).Value())
            dgv_Tendencia.Rows(i).Cells(5).Value = tot
        Next


        ''***********************************
        '' DGV EXISTENCIA NIÑOS
        ''***********************************
        Dim dtcTN_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcTN_columna2 As New DataColumn("I_PRD_DESCRIPCION", GetType(System.String))
        Dim dtcTN_columna3 As New DataColumn("CIRCULACION", GetType(System.String))
        Dim dtcTN_columna4 As New DataColumn("EMPAQUE", GetType(System.String))
        Dim dtcTN_columna5 As New DataColumn("CUARENTENA", GetType(System.String))

        Dim dtcTN_columna6 As New DataColumn("EXISTENCIA", GetType(System.Single))
        Dim dtcTN_columna7 As New DataColumn("TENDENCIA", GetType(System.Decimal))
        Dim dtcTN_columna8 As New DataColumn("PORCENTAJE REAL", GetType(System.Decimal))

        Dim dtcTN_columna9 As New DataColumn("FRECUENCIA", GetType(System.Single))
        Dim dtcTN_columna10 As New DataColumn("PRODUCCION", GetType(System.String))

        dtt_TdciaN.Columns.Add(dtcTN_columna1)
        dtt_TdciaN.Columns.Add(dtcTN_columna2)
        dtt_TdciaN.Columns.Add(dtcTN_columna3)
        dtt_TdciaN.Columns.Add(dtcTN_columna4)
        dtt_TdciaN.Columns.Add(dtcTN_columna5)
        dtt_TdciaN.Columns.Add(dtcTN_columna6)
        dtt_TdciaN.Columns.Add(dtcTN_columna7)
        dtt_TdciaN.Columns.Add(dtcTN_columna8)
        dtt_TdciaN.Columns.Add(dtcTN_columna9)
        dtt_TdciaN.Columns.Add(dtcTN_columna10)

        actualizaDtsTendencia(dgv_TendenciaN, "N", CInt(cmb_Anio.Text), dtt_TdciaN)

        dgv_TendenciaN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_TendenciaN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_TendenciaN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_TendenciaN.Columns("I_PRD_ID").Width = 40
        dgv_TendenciaN.Columns("I_PRD_ID").HeaderText = "SERIE"
        dgv_TendenciaN.Columns("I_PRD_DESCRIPCION").Width = 140
        dgv_TendenciaN.Columns("I_PRD_DESCRIPCION").HeaderText = "DESCRIPCION"

        dgv_TendenciaN.Columns("CIRCULACION").Width = 90
        dgv_TendenciaN.Columns("CIRCULACION").HeaderText = "CIRCUL"

        dgv_TendenciaN.Columns("EMPAQUE").Width = 90
        dgv_TendenciaN.Columns("EMPAQUE").HeaderText = "EMPAQ"

        dgv_TendenciaN.Columns("CUARENTENA").Width = 90
        dgv_TendenciaN.Columns("CUARENTENA").HeaderText = "CUARE"

        dgv_TendenciaN.Columns("EXISTENCIA").Width = 90
        dgv_TendenciaN.Columns("EXISTENCIA").HeaderText = "EXIST"

        dgv_TendenciaN.Columns("TENDENCIA").Width = 90
        dgv_TendenciaN.Columns("TENDENCIA").HeaderText = "TEND"

        dgv_TendenciaN.Columns("PORCENTAJE REAL").Width = 90
        dgv_TendenciaN.Columns("PORCENTAJE REAL").HeaderText = "% REAL"

        dgv_TendenciaN.Columns("FRECUENCIA").Width = 90
        dgv_TendenciaN.Columns("FRECUENCIA").HeaderText = "FREC"

        dgv_TendenciaN.Columns("PRODUCCION").Width = 90
        dgv_TendenciaN.Columns("PRODUCCION").HeaderText = "PRODUCCION"

        With dgv_TendenciaN

            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        'EXISTENCIA
        For i = 0 To dgv_TendenciaN.Rows.Count - 1
            tot = CLng(dgv_TendenciaN.Rows(i).Cells(2).Value()) + CLng(dgv_TendenciaN.Rows(i).Cells(3).Value()) + CLng(dgv_TendenciaN.Rows(i).Cells(4).Value())
            dgv_TendenciaN.Rows(i).Cells(5).Value = tot
        Next


    End Sub

    Private Sub cargaMensual()

        ''***********************************
        '' DGV CONSUMO ADULTOS 
        ''***********************************
        Dim dtcCA_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcCA_columna2 As New DataColumn("1", GetType(System.Single))
        Dim dtcCA_columna3 As New DataColumn("2", GetType(System.Single))
        Dim dtcCA_columna4 As New DataColumn("3", GetType(System.Single))
        Dim dtcCA_columna5 As New DataColumn("4", GetType(System.Single))
        Dim dtcCA_columna6 As New DataColumn("5", GetType(System.Single))
        Dim dtcCA_columna7 As New DataColumn("6", GetType(System.Single))
        Dim dtcCA_columna8 As New DataColumn("7", GetType(System.Single))
        Dim dtcCA_columna9 As New DataColumn("8", GetType(System.Single))
        Dim dtcCA_columna10 As New DataColumn("9", GetType(System.Single))
        Dim dtcCA_columna11 As New DataColumn("10", GetType(System.Single))
        Dim dtcCA_columna12 As New DataColumn("11", GetType(System.Single))
        Dim dtcCA_columna13 As New DataColumn("12", GetType(System.Single))


        dtt_Consu.Columns.Add(dtcCA_columna1)
        dtt_Consu.Columns.Add(dtcCA_columna2)
        dtt_Consu.Columns.Add(dtcCA_columna3)
        dtt_Consu.Columns.Add(dtcCA_columna4)
        dtt_Consu.Columns.Add(dtcCA_columna5)
        dtt_Consu.Columns.Add(dtcCA_columna6)
        dtt_Consu.Columns.Add(dtcCA_columna7)
        dtt_Consu.Columns.Add(dtcCA_columna8)
        dtt_Consu.Columns.Add(dtcCA_columna9)
        dtt_Consu.Columns.Add(dtcCA_columna10)
        dtt_Consu.Columns.Add(dtcCA_columna11)
        dtt_Consu.Columns.Add(dtcCA_columna12)
        dtt_Consu.Columns.Add(dtcCA_columna13)

        actualizaDtsConsumo(dgv_ConsumoA, "A", CInt(cmb_Anio.Text), "", dtt_Consu)

        dgv_ConsumoA.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsumoA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsumoA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsumoA.Columns("I_PRD_ID").Width = 50
        dgv_ConsumoA.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsumoA.Columns("1").Width = 50
        dgv_ConsumoA.Columns("1").HeaderText = "ENE"

        dgv_ConsumoA.Columns("2").Width = 50
        dgv_ConsumoA.Columns("2").HeaderText = "FEB"

        dgv_ConsumoA.Columns("3").Width = 50
        dgv_ConsumoA.Columns("3").HeaderText = "MAR"

        dgv_ConsumoA.Columns("4").Width = 50
        dgv_ConsumoA.Columns("4").HeaderText = "ABR"

        dgv_ConsumoA.Columns("5").Width = 50
        dgv_ConsumoA.Columns("5").HeaderText = "MAY"

        dgv_ConsumoA.Columns("6").Width = 50
        dgv_ConsumoA.Columns("6").HeaderText = "JUN"

        dgv_ConsumoA.Columns("7").Width = 50
        dgv_ConsumoA.Columns("7").HeaderText = "JUL"

        dgv_ConsumoA.Columns("8").Width = 50
        dgv_ConsumoA.Columns("8").HeaderText = "AGO"

        dgv_ConsumoA.Columns("9").Width = 50
        dgv_ConsumoA.Columns("9").HeaderText = "SEP"

        dgv_ConsumoA.Columns("10").Width = 50
        dgv_ConsumoA.Columns("10").HeaderText = "OCT"

        dgv_ConsumoA.Columns("11").Width = 50
        dgv_ConsumoA.Columns("11").HeaderText = "NOV"

        dgv_ConsumoA.Columns("12").Width = 50
        dgv_ConsumoA.Columns("12").HeaderText = "DIC"

        With dgv_ConsumoA
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


        ''***********************************
        '' DGV CONSUMO NIÑOS
        ''***********************************
        Dim dtcCN_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcCN_columna2 As New DataColumn("1", GetType(System.Single))
        Dim dtcCN_columna3 As New DataColumn("2", GetType(System.Single))
        Dim dtcCN_columna4 As New DataColumn("3", GetType(System.Single))
        Dim dtcCN_columna5 As New DataColumn("4", GetType(System.Single))
        Dim dtcCN_columna6 As New DataColumn("5", GetType(System.Single))
        Dim dtcCN_columna7 As New DataColumn("6", GetType(System.Single))
        Dim dtcCN_columna8 As New DataColumn("7", GetType(System.Single))
        Dim dtcCN_columna9 As New DataColumn("8", GetType(System.Single))
        Dim dtcCN_columna10 As New DataColumn("9", GetType(System.Single))
        Dim dtcCN_columna11 As New DataColumn("10", GetType(System.Single))
        Dim dtcCN_columna12 As New DataColumn("11", GetType(System.Single))
        Dim dtcCN_columna13 As New DataColumn("12", GetType(System.Single))

        dtt_ConsuN.Columns.Add(dtcCN_columna1)
        dtt_ConsuN.Columns.Add(dtcCN_columna2)
        dtt_ConsuN.Columns.Add(dtcCN_columna3)
        dtt_ConsuN.Columns.Add(dtcCN_columna4)
        dtt_ConsuN.Columns.Add(dtcCN_columna5)
        dtt_ConsuN.Columns.Add(dtcCN_columna6)
        dtt_ConsuN.Columns.Add(dtcCN_columna7)
        dtt_ConsuN.Columns.Add(dtcCN_columna8)
        dtt_ConsuN.Columns.Add(dtcCN_columna9)
        dtt_ConsuN.Columns.Add(dtcCN_columna10)
        dtt_ConsuN.Columns.Add(dtcCN_columna11)
        dtt_ConsuN.Columns.Add(dtcCN_columna12)
        dtt_ConsuN.Columns.Add(dtcCN_columna13)

        actualizaDtsConsumo(dgv_ConsumoN, "N", CInt(cmb_Anio.Text), "", dtt_ConsuN)

        dgv_ConsumoN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsumoN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsumoN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsumoN.Columns("I_PRD_ID").Width = 50
        dgv_ConsumoN.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsumoN.Columns("1").Width = 50
        dgv_ConsumoN.Columns("1").HeaderText = "ENE"

        dgv_ConsumoN.Columns("2").Width = 50
        dgv_ConsumoN.Columns("2").HeaderText = "FEB"

        dgv_ConsumoN.Columns("3").Width = 50
        dgv_ConsumoN.Columns("3").HeaderText = "MAR"

        dgv_ConsumoN.Columns("4").Width = 50
        dgv_ConsumoN.Columns("4").HeaderText = "ABR"

        dgv_ConsumoN.Columns("5").Width = 50
        dgv_ConsumoN.Columns("5").HeaderText = "MAY"

        dgv_ConsumoN.Columns("6").Width = 50
        dgv_ConsumoN.Columns("6").HeaderText = "JUN"

        dgv_ConsumoN.Columns("7").Width = 50
        dgv_ConsumoN.Columns("7").HeaderText = "JUL"

        dgv_ConsumoN.Columns("8").Width = 50
        dgv_ConsumoN.Columns("8").HeaderText = "AGO"

        dgv_ConsumoN.Columns("9").Width = 50
        dgv_ConsumoN.Columns("9").HeaderText = "SEP"

        dgv_ConsumoN.Columns("10").Width = 50
        dgv_ConsumoN.Columns("10").HeaderText = "OCT"

        dgv_ConsumoN.Columns("11").Width = 50
        dgv_ConsumoN.Columns("11").HeaderText = "NOV"

        dgv_ConsumoN.Columns("12").Width = 50
        dgv_ConsumoN.Columns("12").HeaderText = "DIC"

        With dgv_ConsumoN
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


        

        ''***********************************
        '' DGV CONSUMO TOTAL GENERAL
        ''***********************************
        'Dim dtcCG_columna1 As New DataColumn("Mes", GetType(System.String))
        'Dim dtcCG_columna2 As New DataColumn("2023", GetType(System.Single))
        'Dim dtcCG_columna3 As New DataColumn("2024", GetType(System.Single))
        'Dim dtcCG_columna4 As New DataColumn("2025", GetType(System.Single))

        'dtt_CGeneral.Columns.Add(dtcCG_columna1)
        'dtt_CGeneral.Columns.Add(dtcCG_columna2)
        'dtt_CGeneral.Columns.Add(dtcCG_columna3)
        'dtt_CGeneral.Columns.Add(dtcCG_columna4)

        'actualizaDtsConAnual(dgv_CAnualTODO, "T", dtt_CGeneral)

        'dgv_CAnualA.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'dgv_CAnualA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgv_CAnualA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'dgv_CAnualA.Columns("Mes").Width = 70
        'dgv_CAnualA.Columns("Mes").HeaderText = "MES"

        'dgv_CAnualA.Columns("2023").Width = 50
        'dgv_CAnualA.Columns("2023").HeaderText = "2023"

        'dgv_CAnualA.Columns("2024").Width = 50
        'dgv_CAnualA.Columns("2024").HeaderText = "2024"

        'dgv_CAnualA.Columns("2025").Width = 50
        'dgv_CAnualA.Columns("2025").HeaderText = "2025"

        'With dgv_CAnualA
        '    .ColumnHeadersDefaultCellStyle.Font = headerFont
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        '    .DefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .SelectionMode = DataGridViewSelectionMode.CellSelect
        'End With


        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        '' DGV CONSUMO ANUAL NINOS 
        ''***********************************
        'Dim dtcCYN_columna1 As New DataColumn("Mes", GetType(System.String))
        'Dim dtcCYN_columna2 As New DataColumn("2023", GetType(System.String))
        'Dim dtcCYN_columna3 As New DataColumn("2024", GetType(System.String))
        'Dim dtcCYN_columna4 As New DataColumn("2025", GetType(System.String))

        'dtt_CGeneralN.Columns.Add(dtcCYN_columna1)
        'dtt_CGeneralN.Columns.Add(dtcCYN_columna2)
        'dtt_CGeneralN.Columns.Add(dtcCYN_columna3)
        'dtt_CGeneralN.Columns.Add(dtcCYN_columna4)

        'actualizaDtsConAnual(dgv_CAnualN, "N", dtt_CGeneralN)

        'dgv_CAnualN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'dgv_CAnualN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgv_CAnualN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'dgv_CAnualN.Columns("Mes").Width = 70
        'dgv_CAnualN.Columns("Mes").HeaderText = "MES"

        'dgv_CAnualA.Columns("2023").Width = 50
        'dgv_CAnualN.Columns("2023").HeaderText = "2023"

        'dgv_CAnualN.Columns("2024").Width = 50
        'dgv_CAnualN.Columns("2024").HeaderText = "2024"

        'dgv_CAnualN.Columns("2025").Width = 50
        'dgv_CAnualN.Columns("2025").HeaderText = "2025"

        'With dgv_CAnualN
        '    .ColumnHeadersDefaultCellStyle.Font = headerFont
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        '    .DefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .SelectionMode = DataGridViewSelectionMode.CellSelect
        'End With


        'With dgv_ConsumoN
        '    .ColumnHeadersDefaultCellStyle.Font = headerFont
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        '    .DefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .SelectionMode = DataGridViewSelectionMode.CellSelect
        'End With

    End Sub


    Private Sub cargaMensualCliente()

        ''***********************************
        '' DGV CONSUMO ADULTOS 
        ''***********************************
        Dim dtcCA_cli_columna0 As New DataColumn("PAC_APELLIDO", GetType(System.String))
        Dim dtcCA_cli_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcCA_cli_columna2 As New DataColumn("1", GetType(System.Single))
        Dim dtcCA_cli_columna3 As New DataColumn("2", GetType(System.Single))
        Dim dtcCA_cli_columna4 As New DataColumn("3", GetType(System.Single))
        Dim dtcCA_cli_columna5 As New DataColumn("4", GetType(System.Single))
        Dim dtcCA_cli_columna6 As New DataColumn("5", GetType(System.Single))
        Dim dtcCA_cli_columna7 As New DataColumn("6", GetType(System.Single))
        Dim dtcCA_cli_columna8 As New DataColumn("7", GetType(System.Single))
        Dim dtcCA_cli_columna9 As New DataColumn("8", GetType(System.Single))
        Dim dtcCA_cli_columna10 As New DataColumn("9", GetType(System.Single))
        Dim dtcCA_cli_columna11 As New DataColumn("10", GetType(System.Single))
        Dim dtcCA_cli_columna12 As New DataColumn("11", GetType(System.Single))
        Dim dtcCA_cli_columna13 As New DataColumn("12", GetType(System.Single))

        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna0)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna1)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna2)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna3)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna4)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna5)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna6)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna7)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna8)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna9)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna10)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna11)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna12)
        dtt_Consu_cli.Columns.Add(dtcCA_cli_columna13)

        actualizaDtsConsumo_cli(dgv_ConsumoA_cli, "A", CInt(cmb_Anio.Text), "CLIENTE", dtt_Consu_cli)

        dgv_ConsumoA_cli.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsumoA_cli.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsumoA_cli.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsumoA_cli.Columns("PAC_APELLIDO").Width = 110
        dgv_ConsumoA_cli.Columns("PAC_APELLIDO").HeaderText = "CLIENTE"

        dgv_ConsumoA_cli.Columns("I_PRD_ID").Width = 50
        dgv_ConsumoA_cli.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsumoA_cli.Columns("1").Width = 50
        dgv_ConsumoA_cli.Columns("1").HeaderText = "ENE"

        dgv_ConsumoA_cli.Columns("2").Width = 50
        dgv_ConsumoA_cli.Columns("2").HeaderText = "FEB"

        dgv_ConsumoA_cli.Columns("3").Width = 50
        dgv_ConsumoA_cli.Columns("3").HeaderText = "MAR"

        dgv_ConsumoA_cli.Columns("4").Width = 50
        dgv_ConsumoA_cli.Columns("4").HeaderText = "ABR"

        dgv_ConsumoA_cli.Columns("5").Width = 50
        dgv_ConsumoA_cli.Columns("5").HeaderText = "MAY"

        dgv_ConsumoA_cli.Columns("6").Width = 50
        dgv_ConsumoA_cli.Columns("6").HeaderText = "JUN"

        dgv_ConsumoA_cli.Columns("7").Width = 50
        dgv_ConsumoA_cli.Columns("7").HeaderText = "JUL"

        dgv_ConsumoA_cli.Columns("8").Width = 50
        dgv_ConsumoA_cli.Columns("8").HeaderText = "AGO"

        dgv_ConsumoA_cli.Columns("9").Width = 50
        dgv_ConsumoA_cli.Columns("9").HeaderText = "SEP"

        dgv_ConsumoA_cli.Columns("10").Width = 50
        dgv_ConsumoA_cli.Columns("10").HeaderText = "OCT"

        dgv_ConsumoA_cli.Columns("11").Width = 50
        dgv_ConsumoA_cli.Columns("11").HeaderText = "NOV"

        dgv_ConsumoA_cli.Columns("12").Width = 50
        dgv_ConsumoA_cli.Columns("12").HeaderText = "DIC"

        With dgv_ConsumoA_cli
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


        ''***********************************
        '' DGV CONSUMO NIÑOS
        ''***********************************
        Dim dtcCN_cli_columna0 As New DataColumn("PAC_APELLIDO", GetType(System.String))
        Dim dtcCN_cli_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcCN_cli_columna2 As New DataColumn("1", GetType(System.Single))
        Dim dtcCN_cli_columna3 As New DataColumn("2", GetType(System.Single))
        Dim dtcCN_cli_columna4 As New DataColumn("3", GetType(System.Single))
        Dim dtcCN_cli_columna5 As New DataColumn("4", GetType(System.Single))
        Dim dtcCN_cli_columna6 As New DataColumn("5", GetType(System.Single))
        Dim dtcCN_cli_columna7 As New DataColumn("6", GetType(System.Single))
        Dim dtcCN_cli_columna8 As New DataColumn("7", GetType(System.Single))
        Dim dtcCN_cli_columna9 As New DataColumn("8", GetType(System.Single))
        Dim dtcCN_cli_columna10 As New DataColumn("9", GetType(System.Single))
        Dim dtcCN_cli_columna11 As New DataColumn("10", GetType(System.Single))
        Dim dtcCN_cli_columna12 As New DataColumn("11", GetType(System.Single))
        Dim dtcCN_cli_columna13 As New DataColumn("12", GetType(System.Single))

        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna0)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna1)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna2)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna3)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna4)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna5)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna6)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna7)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna8)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna9)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna10)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna11)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna12)
        dtt_Consu_cliN.Columns.Add(dtcCN_cli_columna13)

        actualizaDtsConsumo_cli(dgv_ConsumoN_cli, "N", CInt(cmb_Anio.Text), "CLIENTE", dtt_Consu_cliN)

        dgv_ConsumoN_cli.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsumoN_cli.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsumoN_cli.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsumoN_cli.Columns("PAC_APELLIDO").Width = 110
        dgv_ConsumoN_cli.Columns("PAC_APELLIDO").HeaderText = "CLIENTE"

        dgv_ConsumoN_cli.Columns("I_PRD_ID").Width = 50
        dgv_ConsumoN_cli.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsumoN_cli.Columns("1").Width = 50
        dgv_ConsumoN_cli.Columns("1").HeaderText = "ENE"

        dgv_ConsumoN_cli.Columns("2").Width = 50
        dgv_ConsumoN_cli.Columns("2").HeaderText = "FEB"

        dgv_ConsumoN_cli.Columns("3").Width = 50
        dgv_ConsumoN_cli.Columns("3").HeaderText = "MAR"

        dgv_ConsumoN_cli.Columns("4").Width = 50
        dgv_ConsumoN_cli.Columns("4").HeaderText = "ABR"

        dgv_ConsumoN_cli.Columns("5").Width = 50
        dgv_ConsumoN_cli.Columns("5").HeaderText = "MAY"

        dgv_ConsumoN_cli.Columns("6").Width = 50
        dgv_ConsumoN_cli.Columns("6").HeaderText = "JUN"

        dgv_ConsumoN_cli.Columns("7").Width = 50
        dgv_ConsumoN_cli.Columns("7").HeaderText = "JUL"

        dgv_ConsumoN_cli.Columns("8").Width = 50
        dgv_ConsumoN_cli.Columns("8").HeaderText = "AGO"

        dgv_ConsumoN_cli.Columns("9").Width = 50
        dgv_ConsumoN_cli.Columns("9").HeaderText = "SEP"

        dgv_ConsumoN_cli.Columns("10").Width = 50
        dgv_ConsumoN_cli.Columns("10").HeaderText = "OCT"

        dgv_ConsumoN_cli.Columns("11").Width = 50
        dgv_ConsumoN.Columns("11").HeaderText = "NOV"

        dgv_ConsumoN_cli.Columns("12").Width = 50
        dgv_ConsumoN_cli.Columns("12").HeaderText = "DIC"

        With dgv_ConsumoN_cli
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With




        ''***********************************
        '' DGV CONSUMO TOTAL GENERAL
        ''***********************************
        'Dim dtcCG_columna1 As New DataColumn("Mes", GetType(System.String))
        'Dim dtcCG_columna2 As New DataColumn("2023", GetType(System.Single))
        'Dim dtcCG_columna3 As New DataColumn("2024", GetType(System.Single))
        'Dim dtcCG_columna4 As New DataColumn("2025", GetType(System.Single))

        'dtt_CGeneral.Columns.Add(dtcCG_columna1)
        'dtt_CGeneral.Columns.Add(dtcCG_columna2)
        'dtt_CGeneral.Columns.Add(dtcCG_columna3)
        'dtt_CGeneral.Columns.Add(dtcCG_columna4)

        'actualizaDtsConAnual(dgv_CAnualTODO, "T", dtt_CGeneral)

        'dgv_CAnualA.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'dgv_CAnualA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgv_CAnualA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'dgv_CAnualA.Columns("Mes").Width = 70
        'dgv_CAnualA.Columns("Mes").HeaderText = "MES"

        'dgv_CAnualA.Columns("2023").Width = 50
        'dgv_CAnualA.Columns("2023").HeaderText = "2023"

        'dgv_CAnualA.Columns("2024").Width = 50
        'dgv_CAnualA.Columns("2024").HeaderText = "2024"

        'dgv_CAnualA.Columns("2025").Width = 50
        'dgv_CAnualA.Columns("2025").HeaderText = "2025"

        'With dgv_CAnualA
        '    .ColumnHeadersDefaultCellStyle.Font = headerFont
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        '    .DefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .SelectionMode = DataGridViewSelectionMode.CellSelect
        'End With


        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        ''***********************************
        '' DGV CONSUMO ANUAL NINOS 
        ''***********************************
        'Dim dtcCYN_columna1 As New DataColumn("Mes", GetType(System.String))
        'Dim dtcCYN_columna2 As New DataColumn("2023", GetType(System.String))
        'Dim dtcCYN_columna3 As New DataColumn("2024", GetType(System.String))
        'Dim dtcCYN_columna4 As New DataColumn("2025", GetType(System.String))

        'dtt_CGeneralN.Columns.Add(dtcCYN_columna1)
        'dtt_CGeneralN.Columns.Add(dtcCYN_columna2)
        'dtt_CGeneralN.Columns.Add(dtcCYN_columna3)
        'dtt_CGeneralN.Columns.Add(dtcCYN_columna4)

        'actualizaDtsConAnual(dgv_CAnualN, "N", dtt_CGeneralN)

        'dgv_CAnualN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'dgv_CAnualN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgv_CAnualN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'dgv_CAnualN.Columns("Mes").Width = 70
        'dgv_CAnualN.Columns("Mes").HeaderText = "MES"

        'dgv_CAnualA.Columns("2023").Width = 50
        'dgv_CAnualN.Columns("2023").HeaderText = "2023"

        'dgv_CAnualN.Columns("2024").Width = 50
        'dgv_CAnualN.Columns("2024").HeaderText = "2024"

        'dgv_CAnualN.Columns("2025").Width = 50
        'dgv_CAnualN.Columns("2025").HeaderText = "2025"

        'With dgv_CAnualN
        '    .ColumnHeadersDefaultCellStyle.Font = headerFont
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        '    .DefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .SelectionMode = DataGridViewSelectionMode.CellSelect
        'End With


        'With dgv_ConsumoN
        '    .ColumnHeadersDefaultCellStyle.Font = headerFont
        '    .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        '    .DefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .SelectionMode = DataGridViewSelectionMode.CellSelect
        'End With

    End Sub

    Private Sub cargaDiaria()
        ''***********************************
        '' DGV CONSUMO DIARIO ADULTO
        ''***********************************
        Dim dtcDA_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcDA_columna2 As New DataColumn("1", GetType(System.String))
        Dim dtcDA_columna3 As New DataColumn("2", GetType(System.String))
        Dim dtcDA_columna4 As New DataColumn("3", GetType(System.String))
        Dim dtcDA_columna5 As New DataColumn("4", GetType(System.String))
        Dim dtcDA_columna6 As New DataColumn("5", GetType(System.String))
        Dim dtcDA_columna7 As New DataColumn("6", GetType(System.String))
        Dim dtcDA_columna8 As New DataColumn("7", GetType(System.String))
        Dim dtcDA_columna9 As New DataColumn("8", GetType(System.String))
        Dim dtcDA_columna10 As New DataColumn("9", GetType(System.String))
        Dim dtcDA_columna11 As New DataColumn("10", GetType(System.String))
        Dim dtcDA_columna12 As New DataColumn("11", GetType(System.String))
        Dim dtcDA_columna13 As New DataColumn("12", GetType(System.String))
        Dim dtcDA_columna14 As New DataColumn("13", GetType(System.String))
        Dim dtcDA_columna15 As New DataColumn("14", GetType(System.String))
        Dim dtcDA_columna16 As New DataColumn("15", GetType(System.String))
        Dim dtcDA_columna17 As New DataColumn("16", GetType(System.String))
        Dim dtcDA_columna18 As New DataColumn("17", GetType(System.String))
        Dim dtcDA_columna19 As New DataColumn("18", GetType(System.String))
        Dim dtcDA_columna20 As New DataColumn("19", GetType(System.String))
        Dim dtcDA_columna21 As New DataColumn("20", GetType(System.String))
        Dim dtcDA_columna22 As New DataColumn("21", GetType(System.String))
        Dim dtcDA_columna23 As New DataColumn("22", GetType(System.String))
        Dim dtcDA_columna24 As New DataColumn("23", GetType(System.String))
        Dim dtcDA_columna25 As New DataColumn("24", GetType(System.String))
        Dim dtcDA_columna26 As New DataColumn("25", GetType(System.String))
        Dim dtcDA_columna27 As New DataColumn("26", GetType(System.String))
        Dim dtcDA_columna28 As New DataColumn("27", GetType(System.String))
        Dim dtcDA_columna29 As New DataColumn("28", GetType(System.String))
        Dim dtcDA_columna30 As New DataColumn("29", GetType(System.String))
        Dim dtcDA_columna31 As New DataColumn("30", GetType(System.String))
        Dim dtcDA_columna32 As New DataColumn("31", GetType(System.String))

        dtt_CDiario.Columns.Add(dtcDA_columna1)
        dtt_CDiario.Columns.Add(dtcDA_columna2)
        dtt_CDiario.Columns.Add(dtcDA_columna3)
        dtt_CDiario.Columns.Add(dtcDA_columna4)
        dtt_CDiario.Columns.Add(dtcDA_columna5)
        dtt_CDiario.Columns.Add(dtcDA_columna6)
        dtt_CDiario.Columns.Add(dtcDA_columna7)
        dtt_CDiario.Columns.Add(dtcDA_columna8)
        dtt_CDiario.Columns.Add(dtcDA_columna9)
        dtt_CDiario.Columns.Add(dtcDA_columna10)
        dtt_CDiario.Columns.Add(dtcDA_columna11)
        dtt_CDiario.Columns.Add(dtcDA_columna12)
        dtt_CDiario.Columns.Add(dtcDA_columna13)
        dtt_CDiario.Columns.Add(dtcDA_columna14)
        dtt_CDiario.Columns.Add(dtcDA_columna15)
        dtt_CDiario.Columns.Add(dtcDA_columna16)
        dtt_CDiario.Columns.Add(dtcDA_columna17)
        dtt_CDiario.Columns.Add(dtcDA_columna18)
        dtt_CDiario.Columns.Add(dtcDA_columna19)
        dtt_CDiario.Columns.Add(dtcDA_columna20)
        dtt_CDiario.Columns.Add(dtcDA_columna21)
        dtt_CDiario.Columns.Add(dtcDA_columna22)
        dtt_CDiario.Columns.Add(dtcDA_columna23)
        dtt_CDiario.Columns.Add(dtcDA_columna24)
        dtt_CDiario.Columns.Add(dtcDA_columna25)
        dtt_CDiario.Columns.Add(dtcDA_columna26)
        dtt_CDiario.Columns.Add(dtcDA_columna27)
        dtt_CDiario.Columns.Add(dtcDA_columna28)
        dtt_CDiario.Columns.Add(dtcDA_columna29)
        dtt_CDiario.Columns.Add(dtcDA_columna30)
        dtt_CDiario.Columns.Add(dtcDA_columna31)
        dtt_CDiario.Columns.Add(dtcDA_columna32)

        actualizaDtsConDiario(dgv_ConsDiarioA, "A", CInt(cmb_Anio.Text), var_mes, dtt_CDiario)

        dgv_ConsDiarioA.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsDiarioA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsDiarioA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsDiarioA.Columns("I_PRD_ID").Width = 50
        dgv_ConsDiarioA.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsDiarioA.Columns("1").Width = 50
        dgv_ConsDiarioA.Columns("2").Width = 50
        dgv_ConsDiarioA.Columns("3").Width = 50
        dgv_ConsDiarioA.Columns("4").Width = 50
        dgv_ConsDiarioA.Columns("5").Width = 50
        dgv_ConsDiarioA.Columns("6").Width = 50
        dgv_ConsDiarioA.Columns("7").Width = 50
        dgv_ConsDiarioA.Columns("8").Width = 50
        dgv_ConsDiarioA.Columns("9").Width = 50
        dgv_ConsDiarioA.Columns("10").Width = 50
        dgv_ConsDiarioA.Columns("11").Width = 50
        dgv_ConsDiarioA.Columns("12").Width = 50
        dgv_ConsDiarioA.Columns("13").Width = 50
        dgv_ConsDiarioA.Columns("14").Width = 50
        dgv_ConsDiarioA.Columns("15").Width = 50
        dgv_ConsDiarioA.Columns("16").Width = 50
        dgv_ConsDiarioA.Columns("17").Width = 50
        dgv_ConsDiarioA.Columns("18").Width = 50
        dgv_ConsDiarioA.Columns("19").Width = 50
        dgv_ConsDiarioA.Columns("20").Width = 50
        dgv_ConsDiarioA.Columns("21").Width = 50
        dgv_ConsDiarioA.Columns("22").Width = 50
        dgv_ConsDiarioA.Columns("23").Width = 50
        dgv_ConsDiarioA.Columns("24").Width = 50
        dgv_ConsDiarioA.Columns("25").Width = 50
        dgv_ConsDiarioA.Columns("26").Width = 50
        dgv_ConsDiarioA.Columns("27").Width = 50
        dgv_ConsDiarioA.Columns("28").Width = 50
        dgv_ConsDiarioA.Columns("29").Width = 50
        dgv_ConsDiarioA.Columns("30").Width = 50
        dgv_ConsDiarioA.Columns("31").Width = 50

        With dgv_ConsDiarioA
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        ''***********************************
        '' DGV CONSUMO DIARIO NIÑOS
        ''***********************************
        Dim dtcDN_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcDN_columna2 As New DataColumn("1", GetType(System.String))
        Dim dtcDN_columna3 As New DataColumn("2", GetType(System.String))
        Dim dtcDN_columna4 As New DataColumn("3", GetType(System.String))
        Dim dtcDN_columna5 As New DataColumn("4", GetType(System.String))
        Dim dtcDN_columna6 As New DataColumn("5", GetType(System.String))
        Dim dtcDN_columna7 As New DataColumn("6", GetType(System.String))
        Dim dtcDN_columna8 As New DataColumn("7", GetType(System.String))
        Dim dtcDN_columna9 As New DataColumn("8", GetType(System.String))
        Dim dtcDN_columna10 As New DataColumn("9", GetType(System.String))
        Dim dtcDN_columna11 As New DataColumn("10", GetType(System.String))
        Dim dtcDN_columna12 As New DataColumn("11", GetType(System.String))
        Dim dtcDN_columna13 As New DataColumn("12", GetType(System.String))
        Dim dtcDN_columna14 As New DataColumn("13", GetType(System.String))
        Dim dtcDN_columna15 As New DataColumn("14", GetType(System.String))
        Dim dtcDN_columna16 As New DataColumn("15", GetType(System.String))
        Dim dtcDN_columna17 As New DataColumn("16", GetType(System.String))
        Dim dtcDN_columna18 As New DataColumn("17", GetType(System.String))
        Dim dtcDN_columna19 As New DataColumn("18", GetType(System.String))
        Dim dtcDN_columna20 As New DataColumn("19", GetType(System.String))
        Dim dtcDN_columna21 As New DataColumn("20", GetType(System.String))
        Dim dtcDN_columna22 As New DataColumn("21", GetType(System.String))
        Dim dtcDN_columna23 As New DataColumn("22", GetType(System.String))
        Dim dtcDN_columna24 As New DataColumn("23", GetType(System.String))
        Dim dtcDN_columna25 As New DataColumn("24", GetType(System.String))
        Dim dtcDN_columna26 As New DataColumn("25", GetType(System.String))
        Dim dtcDN_columna27 As New DataColumn("26", GetType(System.String))
        Dim dtcDN_columna28 As New DataColumn("27", GetType(System.String))
        Dim dtcDN_columna29 As New DataColumn("28", GetType(System.String))
        Dim dtcDN_columna30 As New DataColumn("29", GetType(System.String))
        Dim dtcDN_columna31 As New DataColumn("30", GetType(System.String))
        Dim dtcDN_columna32 As New DataColumn("31", GetType(System.String))

        dtt_CDiarioN.Columns.Add(dtcDN_columna1)
        dtt_CDiarioN.Columns.Add(dtcDN_columna2)
        dtt_CDiarioN.Columns.Add(dtcDN_columna3)
        dtt_CDiarioN.Columns.Add(dtcDN_columna4)
        dtt_CDiarioN.Columns.Add(dtcDN_columna5)
        dtt_CDiarioN.Columns.Add(dtcDN_columna6)
        dtt_CDiarioN.Columns.Add(dtcDN_columna7)
        dtt_CDiarioN.Columns.Add(dtcDN_columna8)
        dtt_CDiarioN.Columns.Add(dtcDN_columna9)
        dtt_CDiarioN.Columns.Add(dtcDN_columna10)
        dtt_CDiarioN.Columns.Add(dtcDN_columna11)
        dtt_CDiarioN.Columns.Add(dtcDN_columna12)
        dtt_CDiarioN.Columns.Add(dtcDN_columna13)
        dtt_CDiarioN.Columns.Add(dtcDN_columna14)
        dtt_CDiarioN.Columns.Add(dtcDN_columna15)
        dtt_CDiarioN.Columns.Add(dtcDN_columna16)
        dtt_CDiarioN.Columns.Add(dtcDN_columna17)
        dtt_CDiarioN.Columns.Add(dtcDN_columna18)
        dtt_CDiarioN.Columns.Add(dtcDN_columna19)
        dtt_CDiarioN.Columns.Add(dtcDN_columna20)
        dtt_CDiarioN.Columns.Add(dtcDN_columna21)
        dtt_CDiarioN.Columns.Add(dtcDN_columna22)
        dtt_CDiarioN.Columns.Add(dtcDN_columna23)
        dtt_CDiarioN.Columns.Add(dtcDN_columna24)
        dtt_CDiarioN.Columns.Add(dtcDN_columna25)
        dtt_CDiarioN.Columns.Add(dtcDN_columna26)
        dtt_CDiarioN.Columns.Add(dtcDN_columna27)
        dtt_CDiarioN.Columns.Add(dtcDN_columna28)
        dtt_CDiarioN.Columns.Add(dtcDN_columna29)
        dtt_CDiarioN.Columns.Add(dtcDN_columna30)
        dtt_CDiarioN.Columns.Add(dtcDN_columna31)
        dtt_CDiarioN.Columns.Add(dtcDN_columna32)

        actualizaDtsConDiario(dgv_ConsDiarioN, "N", CInt(cmb_Anio.Text), var_mes, dtt_CDiarioN)

        dgv_ConsDiarioN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsDiarioN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsDiarioN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsDiarioN.Columns("I_PRD_ID").Width = 50
        dgv_ConsDiarioN.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsDiarioN.Columns("1").Width = 50
        dgv_ConsDiarioN.Columns("2").Width = 50
        dgv_ConsDiarioN.Columns("3").Width = 50
        dgv_ConsDiarioN.Columns("4").Width = 50
        dgv_ConsDiarioN.Columns("5").Width = 50
        dgv_ConsDiarioN.Columns("6").Width = 50
        dgv_ConsDiarioN.Columns("7").Width = 50
        dgv_ConsDiarioN.Columns("8").Width = 50
        dgv_ConsDiarioN.Columns("9").Width = 50
        dgv_ConsDiarioN.Columns("10").Width = 50
        dgv_ConsDiarioN.Columns("11").Width = 50
        dgv_ConsDiarioN.Columns("12").Width = 50
        dgv_ConsDiarioN.Columns("13").Width = 50
        dgv_ConsDiarioN.Columns("14").Width = 50
        dgv_ConsDiarioN.Columns("15").Width = 50
        dgv_ConsDiarioN.Columns("16").Width = 50
        dgv_ConsDiarioN.Columns("17").Width = 50
        dgv_ConsDiarioN.Columns("18").Width = 50
        dgv_ConsDiarioN.Columns("19").Width = 50
        dgv_ConsDiarioN.Columns("20").Width = 50
        dgv_ConsDiarioN.Columns("21").Width = 50
        dgv_ConsDiarioN.Columns("22").Width = 50
        dgv_ConsDiarioN.Columns("23").Width = 50
        dgv_ConsDiarioN.Columns("24").Width = 50
        dgv_ConsDiarioN.Columns("25").Width = 50
        dgv_ConsDiarioN.Columns("26").Width = 50
        dgv_ConsDiarioN.Columns("27").Width = 50
        dgv_ConsDiarioN.Columns("28").Width = 50
        dgv_ConsDiarioN.Columns("29").Width = 50
        dgv_ConsDiarioN.Columns("30").Width = 50
        dgv_ConsDiarioN.Columns("31").Width = 50

        With dgv_ConsDiarioN
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


    End Sub


    Private Sub cargaDiariaCliente()
        ''***********************************
        '' DGV CONSUMO DIARIO ADULTO CLIENTE
        ''***********************************
        Dim dtcDA_cli_columna0 As New DataColumn("PAC_APELLIDO", GetType(System.String))
        Dim dtcDA_cli_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcDA_cli_columna2 As New DataColumn("1", GetType(System.String))
        Dim dtcDA_cli_columna3 As New DataColumn("2", GetType(System.String))
        Dim dtcDA_cli_columna4 As New DataColumn("3", GetType(System.String))
        Dim dtcDA_cli_columna5 As New DataColumn("4", GetType(System.String))
        Dim dtcDA_cli_columna6 As New DataColumn("5", GetType(System.String))
        Dim dtcDA_cli_columna7 As New DataColumn("6", GetType(System.String))
        Dim dtcDA_cli_columna8 As New DataColumn("7", GetType(System.String))
        Dim dtcDA_cli_columna9 As New DataColumn("8", GetType(System.String))
        Dim dtcDA_cli_columna10 As New DataColumn("9", GetType(System.String))
        Dim dtcDA_cli_columna11 As New DataColumn("10", GetType(System.String))
        Dim dtcDA_cli_columna12 As New DataColumn("11", GetType(System.String))
        Dim dtcDA_cli_columna13 As New DataColumn("12", GetType(System.String))
        Dim dtcDA_cli_columna14 As New DataColumn("13", GetType(System.String))
        Dim dtcDA_cli_columna15 As New DataColumn("14", GetType(System.String))
        Dim dtcDA_cli_columna16 As New DataColumn("15", GetType(System.String))
        Dim dtcDA_cli_columna17 As New DataColumn("16", GetType(System.String))
        Dim dtcDA_cli_columna18 As New DataColumn("17", GetType(System.String))
        Dim dtcDA_cli_columna19 As New DataColumn("18", GetType(System.String))
        Dim dtcDA_cli_columna20 As New DataColumn("19", GetType(System.String))
        Dim dtcDA_cli_columna21 As New DataColumn("20", GetType(System.String))
        Dim dtcDA_cli_columna22 As New DataColumn("21", GetType(System.String))
        Dim dtcDA_cli_columna23 As New DataColumn("22", GetType(System.String))
        Dim dtcDA_cli_columna24 As New DataColumn("23", GetType(System.String))
        Dim dtcDA_cli_columna25 As New DataColumn("24", GetType(System.String))
        Dim dtcDA_cli_columna26 As New DataColumn("25", GetType(System.String))
        Dim dtcDA_cli_columna27 As New DataColumn("26", GetType(System.String))
        Dim dtcDA_cli_columna28 As New DataColumn("27", GetType(System.String))
        Dim dtcDA_cli_columna29 As New DataColumn("28", GetType(System.String))
        Dim dtcDA_cli_columna30 As New DataColumn("29", GetType(System.String))
        Dim dtcDA_cli_columna31 As New DataColumn("30", GetType(System.String))
        Dim dtcDA_cli_columna32 As New DataColumn("31", GetType(System.String))

        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna0)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna1)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna2)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna3)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna4)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna5)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna6)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna7)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna8)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna9)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna10)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna11)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna12)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna13)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna14)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna15)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna16)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna17)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna18)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna19)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna20)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna21)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna22)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna23)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna24)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna25)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna26)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna27)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna28)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna29)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna30)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna31)
        dtt_CDiario_cli.Columns.Add(dtcDA_cli_columna32)

        actualizaDtsConDiario_cli(dgv_ConsDiarioACli, "A", CInt(cmb_Anio.Text), var_mes, "CLIENTE", dtt_CDiario_cli)

        dgv_ConsDiarioACli.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsDiarioACli.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsDiarioACli.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsDiarioACli.Columns("PAC_APELLIDO").Width = 110
        dgv_ConsDiarioACli.Columns("PAC_APELLIDO").HeaderText = "CLIENTE"

        dgv_ConsDiarioACli.Columns("I_PRD_ID").Width = 50
        dgv_ConsDiarioACli.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsDiarioACli.Columns("1").Width = 50
        dgv_ConsDiarioACli.Columns("2").Width = 50
        dgv_ConsDiarioACli.Columns("3").Width = 50
        dgv_ConsDiarioACli.Columns("4").Width = 50
        dgv_ConsDiarioACli.Columns("5").Width = 50
        dgv_ConsDiarioACli.Columns("6").Width = 50
        dgv_ConsDiarioACli.Columns("7").Width = 50
        dgv_ConsDiarioACli.Columns("8").Width = 50
        dgv_ConsDiarioACli.Columns("9").Width = 50
        dgv_ConsDiarioACli.Columns("10").Width = 50
        dgv_ConsDiarioACli.Columns("11").Width = 50
        dgv_ConsDiarioACli.Columns("12").Width = 50
        dgv_ConsDiarioACli.Columns("13").Width = 50
        dgv_ConsDiarioACli.Columns("14").Width = 50
        dgv_ConsDiarioACli.Columns("15").Width = 50
        dgv_ConsDiarioACli.Columns("16").Width = 50
        dgv_ConsDiarioACli.Columns("17").Width = 50
        dgv_ConsDiarioACli.Columns("18").Width = 50
        dgv_ConsDiarioACli.Columns("19").Width = 50
        dgv_ConsDiarioACli.Columns("20").Width = 50
        dgv_ConsDiarioACli.Columns("21").Width = 50
        dgv_ConsDiarioACli.Columns("22").Width = 50
        dgv_ConsDiarioACli.Columns("23").Width = 50
        dgv_ConsDiarioACli.Columns("24").Width = 50
        dgv_ConsDiarioACli.Columns("25").Width = 50
        dgv_ConsDiarioACli.Columns("26").Width = 50
        dgv_ConsDiarioACli.Columns("27").Width = 50
        dgv_ConsDiarioACli.Columns("28").Width = 50
        dgv_ConsDiarioACli.Columns("29").Width = 50
        dgv_ConsDiarioACli.Columns("30").Width = 50
        dgv_ConsDiarioACli.Columns("31").Width = 50

        With dgv_ConsDiarioACli
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        ''***********************************
        '' DGV CONSUMO DIARIO NIÑOS
        ''***********************************
        Dim dtcDN_cli_columna0 As New DataColumn("PAC_APELLIDO", GetType(System.String))
        Dim dtcDN_cli_columna1 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcDN_cli_columna2 As New DataColumn("1", GetType(System.String))
        Dim dtcDN_cli_columna3 As New DataColumn("2", GetType(System.String))
        Dim dtcDN_cli_columna4 As New DataColumn("3", GetType(System.String))
        Dim dtcDN_cli_columna5 As New DataColumn("4", GetType(System.String))
        Dim dtcDN_cli_columna6 As New DataColumn("5", GetType(System.String))
        Dim dtcDN_cli_columna7 As New DataColumn("6", GetType(System.String))
        Dim dtcDN_cli_columna8 As New DataColumn("7", GetType(System.String))
        Dim dtcDN_cli_columna9 As New DataColumn("8", GetType(System.String))
        Dim dtcDN_cli_columna10 As New DataColumn("9", GetType(System.String))
        Dim dtcDN_cli_columna11 As New DataColumn("10", GetType(System.String))
        Dim dtcDN_cli_columna12 As New DataColumn("11", GetType(System.String))
        Dim dtcDN_cli_columna13 As New DataColumn("12", GetType(System.String))
        Dim dtcDN_cli_columna14 As New DataColumn("13", GetType(System.String))
        Dim dtcDN_cli_columna15 As New DataColumn("14", GetType(System.String))
        Dim dtcDN_cli_columna16 As New DataColumn("15", GetType(System.String))
        Dim dtcDN_cli_columna17 As New DataColumn("16", GetType(System.String))
        Dim dtcDN_cli_columna18 As New DataColumn("17", GetType(System.String))
        Dim dtcDN_cli_columna19 As New DataColumn("18", GetType(System.String))
        Dim dtcDN_cli_columna20 As New DataColumn("19", GetType(System.String))
        Dim dtcDN_cli_columna21 As New DataColumn("20", GetType(System.String))
        Dim dtcDN_cli_columna22 As New DataColumn("21", GetType(System.String))
        Dim dtcDN_cli_columna23 As New DataColumn("22", GetType(System.String))
        Dim dtcDN_cli_columna24 As New DataColumn("23", GetType(System.String))
        Dim dtcDN_cli_columna25 As New DataColumn("24", GetType(System.String))
        Dim dtcDN_cli_columna26 As New DataColumn("25", GetType(System.String))
        Dim dtcDN_cli_columna27 As New DataColumn("26", GetType(System.String))
        Dim dtcDN_cli_columna28 As New DataColumn("27", GetType(System.String))
        Dim dtcDN_cli_columna29 As New DataColumn("28", GetType(System.String))
        Dim dtcDN_cli_columna30 As New DataColumn("29", GetType(System.String))
        Dim dtcDN_cli_columna31 As New DataColumn("30", GetType(System.String))
        Dim dtcDN_cli_columna32 As New DataColumn("31", GetType(System.String))

        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna0)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna1)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna2)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna3)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna4)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna5)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna6)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna7)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna8)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna9)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna10)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna11)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna12)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna13)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna14)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna15)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna16)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna17)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna18)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna19)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna20)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna21)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna22)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna23)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna24)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna25)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna26)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna27)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna28)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna29)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna30)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna31)
        dtt_CDiario_cliN.Columns.Add(dtcDN_cli_columna32)

        actualizaDtsConDiario_cli(dgv_ConsDiarioNCli, "N", CInt(cmb_Anio.Text), var_mes, "CLIENTE", dtt_CDiario_cliN)

        dgv_ConsDiarioNCli.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_ConsDiarioNCli.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_ConsDiarioNCli.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_ConsDiarioNCli.Columns("PAC_APELLIDO").Width = 110
        dgv_ConsDiarioNCli.Columns("PAC_APELLIDO").HeaderText = "CLIENTE"

        dgv_ConsDiarioNCli.Columns("I_PRD_ID").Width = 50
        dgv_ConsDiarioNCli.Columns("I_PRD_ID").HeaderText = "SERIE"

        dgv_ConsDiarioNCli.Columns("1").Width = 50
        dgv_ConsDiarioNCli.Columns("2").Width = 50
        dgv_ConsDiarioNCli.Columns("3").Width = 50
        dgv_ConsDiarioNCli.Columns("4").Width = 50
        dgv_ConsDiarioNCli.Columns("5").Width = 50
        dgv_ConsDiarioNCli.Columns("6").Width = 50
        dgv_ConsDiarioNCli.Columns("7").Width = 50
        dgv_ConsDiarioNCli.Columns("8").Width = 50
        dgv_ConsDiarioNCli.Columns("9").Width = 50
        dgv_ConsDiarioNCli.Columns("10").Width = 50
        dgv_ConsDiarioNCli.Columns("11").Width = 50
        dgv_ConsDiarioNCli.Columns("12").Width = 50
        dgv_ConsDiarioNCli.Columns("13").Width = 50
        dgv_ConsDiarioNCli.Columns("14").Width = 50
        dgv_ConsDiarioNCli.Columns("15").Width = 50
        dgv_ConsDiarioNCli.Columns("16").Width = 50
        dgv_ConsDiarioNCli.Columns("17").Width = 50
        dgv_ConsDiarioNCli.Columns("18").Width = 50
        dgv_ConsDiarioNCli.Columns("19").Width = 50
        dgv_ConsDiarioNCli.Columns("20").Width = 50
        dgv_ConsDiarioNCli.Columns("21").Width = 50
        dgv_ConsDiarioNCli.Columns("22").Width = 50
        dgv_ConsDiarioNCli.Columns("23").Width = 50
        dgv_ConsDiarioNCli.Columns("24").Width = 50
        dgv_ConsDiarioNCli.Columns("25").Width = 50
        dgv_ConsDiarioNCli.Columns("26").Width = 50
        dgv_ConsDiarioNCli.Columns("27").Width = 50
        dgv_ConsDiarioNCli.Columns("28").Width = 50
        dgv_ConsDiarioNCli.Columns("29").Width = 50
        dgv_ConsDiarioNCli.Columns("30").Width = 50
        dgv_ConsDiarioNCli.Columns("31").Width = 50

        With dgv_ConsDiarioNCli
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


    End Sub

    Private Sub PintaCeldaDiariaA()
        Dim j As Integer
        'ENCIENDE ALARMA ADULTO
        For i = 0 To dgv_ConsDiarioA.Rows.Count - 1
            For j = 1 To dgv_ConsDiarioA.Columns.Count - 1
                If CLng(dgv_ConsDiarioA.Rows(i).Cells(j).Value()) <> 0 Then
                    dgv_ConsDiarioA.Rows(i).Cells(j).Style.BackColor = Color.GreenYellow
                End If
            Next
        Next
    End Sub

    Private Sub PintaCeldaDiariaN()
        Dim j As Integer
        'ENCIENDE ALARMA NIÑO
        For i = 0 To dgv_ConsDiarioN.Rows.Count - 1
            For j = 1 To dgv_ConsDiarioN.Columns.Count - 1
                If CLng(dgv_ConsDiarioN.Rows(i).Cells(j).Value()) <> 0 Then
                    dgv_ConsDiarioN.Rows(i).Cells(j).Style.BackColor = Color.GreenYellow
                End If
            Next
        Next
    End Sub

    Private Sub PintaCeldaMesA()
        Dim j As Integer
        'ENCIENDE ALARMA ADULTO
        For i = 0 To dgv_ConsumoA.Rows.Count - 1
            For j = 1 To dgv_ConsumoA.Columns.Count - 1
                If CLng(dgv_ConsumoA.Rows(i).Cells(j).Value()) <> 0 Then
                    dgv_ConsumoA.Rows(i).Cells(j).Style.BackColor = Color.GreenYellow
                End If
            Next
        Next
    End Sub

    Private Sub PintaCeldaMesN()
        Dim j As Integer
        'ENCIENDE ALARMA NIÑO
        For i = 0 To dgv_ConsumoN.Rows.Count - 1
            For j = 1 To dgv_ConsumoN.Columns.Count - 1
                If CLng(dgv_ConsumoN.Rows(i).Cells(j).Value()) <> 0 Then
                    dgv_ConsumoN.Rows(i).Cells(j).Style.BackColor = Color.GreenYellow
                End If
            Next
        Next
    End Sub

    Private Sub frm_Tendencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Anio.Text = Format(Now, "yyyy")
        cmb_Mes.Text = Format(Now, "MMMM").ToString.ToUpper

        'INICIALIZA Y CARGA GRID CON DATOS INICIALES EN FUNCION DEL AÑO
        cargaExistencias()

        'carga datos guardados de TENDENCIA y FRECUENCIA
        cargaFrecuenciaDatos("A", dgv_Tendencia)
        cargaFrecuenciaDatos("N", dgv_TendenciaN)

        'REALIZA CALCULOS PARA OBTENER EL % Y PINTA CELDA ROJO
        CalculaTotalesA()
        calculaTotalesN()


        '*******************************************
        ' DATOS MESNSUALES PACIENTES
        '*******************************************
        cargaMensual()
        cargaDiaria()

        '*******************************************
        ' DATOS MESNSUALES CLIENTES
        '*******************************************
        cargaMensualCliente()
        cargaDiariaCliente()
    End Sub

    Private Sub cargaFrecuenciaDatos(ByVal I_EDAD As Char, ByVal dgv As DataGridView)
        Dim i, j As Integer
        Dim arre_tes_abrev As String()
        Dim arre_res As String()


        arre_tes_abrev = Split(opr_res.ConsultaTendencia_Abrev(I_EDAD), "|")

        If UBound(arre_tes_abrev) > 0 Then
            For i = 0 To UBound(arre_tes_abrev) - 1
                arre_res = Split(arre_tes_abrev(i), "º")
                For j = 0 To dgv.Rows.Count - 1
                    If dgv.Rows(j).Cells(0).Value() = arre_res(0) Then
                        Dim celda As DataGridViewCell = dgv.Rows(j).Cells(6)
                        celda.Value = arre_res(1)

                        Dim celda2 As DataGridViewCell = dgv.Rows(j).Cells(8)
                        celda2.Value = arre_res(2)
                        Exit For
                    End If
                Next
            Next
        End If

    End Sub

    Private Sub calculaTotalesN()

        'TENDENCIA (GASTO MENSUAL) NIÑOS
        'For i = 0 To dgv_Tendencia.Rows.Count - 1
        'tot = (CLng(dgv_Tendencia.Rows(i).Cells(2).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(3).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(4).Value())) / 3
        'dgv_Tendencia.Rows(i).Cells(6).Value = tot
        'Next


        '% REAL NIÑOS
        For i = 0 To dgv_TendenciaN.Rows.Count - 1
            tot = CLng(dgv_TendenciaN.Rows(i).Cells(5).Value()) * 100 / CLng(dgv_TendenciaN.Rows(i).Cells(6).Value())
            dgv_TendenciaN.Rows(i).Cells(7).Value = tot
        Next


        'PintaCeldas("CInt(dgv_ConsDiarioA.Rows(i).Cells(7).Value()) < 100", dgv_TendenciaN, 9, 9, "PRODUCCION", "OK", Color.Red, Color.MediumSeaGreen)
        'dgv_CargaVadem.Rows(i).Cells(0).Value

        'ENCIENDE ALARMA FRECUENCIA NIÑOS
        For i = 0 To dgv_TendenciaN.Rows.Count - 1
            If CLng(dgv_TendenciaN.Rows(i).Cells(7).Value()) < 100 Then
                dgv_TendenciaN.Rows(i).Cells(9).Style.BackColor = Color.Red
                dgv_TendenciaN.Rows(i).Cells(9).Value = "PRODUCCION"
            Else
                dgv_TendenciaN.Rows(i).Cells(9).Style.BackColor = Color.MediumSeaGreen
                dgv_TendenciaN.Rows(i).Cells(9).Value = "OK"
            End If
        Next

    End Sub

    Private Sub CalculaTotalesA()
        'TENDENCIA (GASTO MENSUAL) ADULTOS
        'For i = 0 To dgv_Tendencia.Rows.Count - 1
        'tot = (CLng(dgv_Tendencia.Rows(i).Cells(2).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(3).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(4).Value())) / 3
        'dgv_Tendencia.Rows(i).Cells(6).Value = tot
        'Next


        '% REAL ADULTOS
        For i = 0 To dgv_Tendencia.Rows.Count - 1
            If CLng(dgv_Tendencia.Rows(i).Cells(5).Value()) <> 0 Or CLng(dgv_Tendencia.Rows(i).Cells(6).Value()) <> 0 Then
                If CLng(dgv_Tendencia.Rows(i).Cells(6).Value()) <> 0 Then
                    tot = CLng(dgv_Tendencia.Rows(i).Cells(5).Value()) * 100 / CLng(dgv_Tendencia.Rows(i).Cells(6).Value())
                    dgv_Tendencia.Rows(i).Cells(7).Value = tot
                End If
            Else
                opr_ped.VisualizaMensaje("no existen datos de TENDENCIA Y/O FRECUENCIA para realizar los cálculos", 300)
            End If
        Next

        'PintaCeldas("CInt(dgv_ConsDiarioA.Rows(i).Cells(7).Value()) < 100", dgv_TendenciaA, 7, 9, "PRODUCCION", "OK", Color.Red, Color.MediumSeaGreen)

        'PintaCeldas("CInt(dgv_Tendencia.Rows(i).Cells(7).Value()) < 100", dgv_ConsDiarioN, 7, 9, "PRODUCCION", "OK", Color.Red, Color.MediumSeaGreen)

        'ENCIENDE ALARMA FRECUENCIA NIÑOS
        For i = 0 To dgv_Tendencia.Rows.Count - 1
            If CLng(dgv_Tendencia.Rows(i).Cells(7).Value()) <> 0 Then
                If CLng(dgv_Tendencia.Rows(i).Cells(7).Value()) < 100 Then
                    dgv_Tendencia.Rows(i).Cells(9).Style.BackColor = Color.Red
                    dgv_Tendencia.Rows(i).Cells(9).Value = "PRODUCCION"
                Else
                    dgv_Tendencia.Rows(i).Cells(9).Style.BackColor = Color.MediumSeaGreen
                    dgv_Tendencia.Rows(i).Cells(9).Value = "OK"
                End If
            Else
                opr_ped.VisualizaMensaje("no existen datos de TENDENCIA Y/O FRECUENCIA para realizar los cálculos", 300)
            End If
        Next


    End Sub


    Private Sub CalcularTendencia(ByVal datosX() As Double, ByVal datosY() As Double, ByRef pendiente As Double, ByRef interseccion As Double)

        ' Verificamos que tengamos al menos dos puntos para calcular la tendencia
        If datosX.Length <> datosY.Length OrElse datosX.Length < 2 Then
            Throw New ArgumentException("Se requieren al menos dos puntos para calcular la tendencia.")
        End If

        ' Calculamos la media de X y Y
        'Dim mediaX As Double = datosX.Average()
        'Dim mediaY As Double = datosY.Average()

        ' Calculamos las sumatorias necesarias
        Dim sumatoriaXY As Double = 0.0
        Dim sumatoriaX2 As Double = 0.0
        For i As Integer = 0 To datosX.Length - 1
            sumatoriaXY += datosX(i) * datosY(i)
            sumatoriaX2 += datosX(i) * datosX(i)
        Next

        ' Calculamos la pendiente (coeficiente b) y la intersección (coeficiente a) de la línea de tendencia
        'pendiente = (sumatoriaXY - datosX.Length * mediaX * mediaY) / (sumatoriaX2 - datosX.Length * mediaX * mediaX)
        'interseccion = mediaY - pendiente * mediaX
    End Sub

    Private Sub actualizaDtsConAnual(ByVal dgv As DataGridView, ByVal I_EDAD As Char, ByVal dtt As DataTable)
        dtt.Clear()
        opr_res.LlenarGridConAnual(dgv, I_EDAD, dtt)
    End Sub

    Private Sub actualizaDtsConsumo(ByVal dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal CliPac As String, ByVal dtt As DataTable)
        dtt.Clear()
        opr_res.LlenarGridConsumo(dgv, I_EDAD, anio, CliPac, dtt)
    End Sub



    Private Sub actualizaDtsConsumo_cli(ByVal dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal CliPac As String, ByVal dtt As DataTable)
        dtt.Clear()
        opr_res.LlenarGridConsumo_cli(dgv, I_EDAD, anio, CliPac, dtt)
    End Sub

    Private Sub actualizaDtsConDiario(ByVal dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal mes As Integer, ByVal dtt As DataTable)
        dtt.Clear()
        opr_res.LlenarGridConDiario(dgv, I_EDAD, anio, mes, dtt)
    End Sub

    Private Sub actualizaDtsConDiario_cli(ByVal dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal mes As Integer, ByVal CliPac As String, ByVal dtt As DataTable)
        dtt.Clear()
        opr_res.LlenarGridConDiario_cli(dgv, I_EDAD, anio, mes, CliPac, dtt)
    End Sub

    Private Sub actualizaDtsTendencia(ByVal dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal dtt As DataTable)
        dtt.Clear()
        opr_res.LlenarGridTendencia(dgv, I_EDAD, anio, dtt)
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Calcular.Click
        CalculaTotalesA()
    End Sub


    Private Sub SeleccionPages(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged


        Select Case TabControl1.SelectedIndex
            Case 0
                'MsgBox("EXISTENCIA")

                actualizaDtsTendencia(dgv_Tendencia, "A", CInt(cmb_Anio.Text), dtt_Tdcia)
                'EXISTENCIA
                For i = 0 To dgv_Tendencia.Rows.Count - 1
                    tot = CLng(dgv_Tendencia.Rows(i).Cells(2).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(3).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(4).Value())
                    dgv_Tendencia.Rows(i).Cells(5).Value = tot
                Next

                actualizaDtsTendencia(dgv_TendenciaN, "N", CInt(cmb_Anio.Text), dtt_TdciaN)
                'EXISTENCIA
                For i = 0 To dgv_TendenciaN.Rows.Count - 1
                    tot = CLng(dgv_TendenciaN.Rows(i).Cells(2).Value()) + CLng(dgv_TendenciaN.Rows(i).Cells(3).Value()) + CLng(dgv_TendenciaN.Rows(i).Cells(4).Value())
                    dgv_TendenciaN.Rows(i).Cells(5).Value = tot
                Next
                'carga datos guardados de TENDENCIA y FRECUENCIA

                cargaFrecuenciaDatos("A", dgv_Tendencia)
                cargaFrecuenciaDatos("N", dgv_TendenciaN)

                'REALIZA CALCULOS PARA OBTENER EL % Y PINTA CELDA ROJO
                CalculaTotalesA()
                calculaTotalesN()

            Case 1
                'MsgBox("CONSUMO MENSUAL")

                actualizaDtsConsumo(dgv_ConsumoA, "A", cmb_Anio.Text, "", dtt_Consu)
                actualizaDtsConsumo(dgv_ConsumoN, "N", cmb_Anio.Text, "", dtt_ConsuN)

                PintaCeldaMesA()
                PintaCeldaMesN()
            Case 2
                'MsgBox("CONSUMO DIARIO")
                actualizaDtsConDiario(dgv_ConsDiarioA, "A", CInt(cmb_Anio.Text), var_mes, dtt_CDiario)
                actualizaDtsConDiario(dgv_ConsDiarioN, "N", CInt(cmb_Anio.Text), var_mes, dtt_CDiarioN)

                PintaCeldaDiariaA()
                PintaCeldaDiariaN()
        End Select

    End Sub

    Private Sub btn_CalcularN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CalcularN.Click
        calculaTotalesN()
    End Sub


    Private Sub cmb_Mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Mes.SelectedIndexChanged
        Select Case cmb_Mes.Text
            Case "ENERO"
                var_mes = 1
            Case "FEBREO"
                var_mes = 2
            Case "MARZO"
                var_mes = 3
            Case "ABRIL"
                var_mes = 4
            Case "MAYO"
                var_mes = 5
            Case "JUNIO"
                var_mes = 6
            Case "JULIO"
                var_mes = 7
            Case "AGOSTO"
                var_mes = 8
            Case "SEPTIEMBRE"
                var_mes = 9
            Case "OCTUBRE"
                var_mes = 10
            Case "NOVIEMBRE"
                var_mes = 11
            Case "DICIEMBRE"
                var_mes = 12
        End Select

        actualizaDtsConDiario(dgv_ConsDiarioA, "A", CInt(cmb_Anio.Text), var_mes, dtt_CDiario)
        actualizaDtsConDiario(dgv_ConsDiarioN, "N", CInt(cmb_Anio.Text), var_mes, dtt_CDiarioN)

        PintaCeldaDiariaA()
        PintaCeldaDiariaN()

    End Sub

    
    Private Sub cmb_Anio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Anio.SelectedIndexChanged

        actualizaDtsTendencia(dgv_Tendencia, "A", CInt(cmb_Anio.Text), dtt_Tdcia)
        'EXISTENCIA
        For i = 0 To dgv_Tendencia.Rows.Count - 1
            tot = CLng(dgv_Tendencia.Rows(i).Cells(2).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(3).Value()) + CLng(dgv_Tendencia.Rows(i).Cells(4).Value())
            dgv_Tendencia.Rows(i).Cells(5).Value = tot
        Next

        actualizaDtsTendencia(dgv_TendenciaN, "N", CInt(cmb_Anio.Text), dtt_TdciaN)
        'EXISTENCIA
        For i = 0 To dgv_TendenciaN.Rows.Count - 1
            tot = CLng(dgv_TendenciaN.Rows(i).Cells(2).Value()) + CLng(dgv_TendenciaN.Rows(i).Cells(3).Value()) + CLng(dgv_TendenciaN.Rows(i).Cells(4).Value())
            dgv_TendenciaN.Rows(i).Cells(5).Value = tot
        Next

        'carga datos guardados de TENDENCIA y FRECUENCIA
        cargaFrecuenciaDatos("A", dgv_Tendencia)
        cargaFrecuenciaDatos("N", dgv_TendenciaN)

        'REALIZA CALCULOS PARA OBTENER EL % Y PINTA CELDA ROJO
        CalculaTotalesA()
        CalculaTotalesN()


        '++++++++++++++++++++++++++++++++++++
        'DATOS MENSUALES
        '++++++++++++++++++++++++++++++++++++
        actualizaDtsConsumo(dgv_ConsumoA, "A", cmb_Anio.Text, "", dtt_Consu)
        actualizaDtsConsumo(dgv_ConsumoN, "N", cmb_Anio.Text, "", dtt_ConsuN)

        PintaCeldaMesA()
        PintaCeldaMesN()


        '++++++++++++++++++++++++++++++++++++
        'DATOS DIARIOS
        '++++++++++++++++++++++++++++++++++++
        actualizaDtsConDiario(dgv_ConsDiarioA, "A", CInt(cmb_Anio.Text), var_mes, dtt_CDiario)
        actualizaDtsConDiario(dgv_ConsDiarioN, "N", CInt(cmb_Anio.Text), var_mes, dtt_CDiarioN)

        PintaCeldaDiariaA()
        PintaCeldaDiariaN()



    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        opr_res.GuardaExistenciaTmp(dgv_Tendencia, "A")

        opr_res.GuardaExistenciaTmp(dgv_TendenciaN, "N")
    End Sub

    Private Sub btn_imprimirA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirA.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        opr_res.GuardaExistenciaTemporal(dgv_Tendencia, "A")

        Dim str_sql As String
        Dim obj_reporte As New rpt_Existencia()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        str_sql = "Select * from consumo_temp"

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        frm_MDIChild.Text = "EXISTENCIA ADULTO"
        frm_MDIChild.ShowDialog(Me.ParentForm)




        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class