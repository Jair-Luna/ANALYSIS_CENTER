Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.SqlClient


Public Class frm_IngresoCutaneas


    'Dim dts_agenda As DataSet
    'Dim orden As String()
    Public ped_id As Integer
    Public Age_id As Integer
    Public Pac_id As Integer

    Dim opr_pedido As New Cls_Pedido()
    Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_res As New Cls_Resultado()
    Dim boo_error As Boolean = False
    Public frm_refer_main As Frm_Main

    'Private WithEvents dtt_agenda As New DataTable("Registros")
    'Dim dts_agenda As DataSet
    Private WithEvents dtt_Cut5 As New DataTable("Registros")
    Private WithEvents dtt_Cut4 As New DataTable("Registros")
    Private WithEvents dtt_Cut3 As New DataTable("Registros")
    Private WithEvents dtt_Cut2 As New DataTable("Registros")
    Private WithEvents dtt_Cut As New DataTable("Registros")
    Private WithEvents dtt_Cut6 As New DataTable("Registros")
    Dim dts_cutaneas As DataSet
    Dim dtv_cutaneas As New DataView()

    Dim fechaCutanea As String
    Dim sw_historicos As Integer
    Dim age_anterior, age_anterior2 As Integer



    Private Sub actualizaDtsCutaneas(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal dgv As DataGridView, ByVal dtt As DataTable, ByRef fechaCutanea As String)
        dtt.Clear()
        opr_res.LlenarGridCutaneas(dgv, dtt, ped_id, tes_id, fechaCutanea)
    End Sub


    

    Private Sub frm_IngresoCutaneas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim visto As Char = ChrW(10003)

        Dim headerFont As New Font("Arial", 7, FontStyle.Bold)

        'lbl_Teclas.Text = "F9 = +" & vbCrLf & "F10= " & visto & vbCrLf & "F11 = O" & vbCrLf & "F12 = ." & vbCrLf

        ''***********************************
        '' ALIMENTOS
        ''***********************************
        Dim dtcC_columna1 As New DataColumn("ped_id", GetType(System.Single))
        Dim dtcC_columna2 As New DataColumn("PRCC_FECHA", GetType(System.String))
        Dim dtcC_columna3 As New DataColumn("PRCC_HORA", GetType(System.String))
        Dim dtcC_columna4 As New DataColumn("TES_ABREV", GetType(System.String))
        Dim dtcC_columna5 As New DataColumn("TES_NOMBRE", GetType(System.String))

        Dim dtcC_columna6 As New DataColumn("PRCC_RESUL_ANIO", GetType(System.String))
        Dim dtcC_columna7 As New DataColumn("PRCC_RESUL_INT", GetType(System.String))


        Dim dtcC_columna8 As New DataColumn("PRCC_RESUL_ANIO2", GetType(System.String))
        Dim dtcC_columna9 As New DataColumn("PRCC_RESUL_INT2", GetType(System.String))

        Dim dtcC_columna10 As New DataColumn("PRCC_RESUL_ANIO3", GetType(System.String))
        Dim dtcC_columna11 As New DataColumn("PRCC_RESUL_INT3", GetType(System.String))

        Dim dtcC_columna12 As New DataColumn("TIM_ID", GetType(System.Single))
        Dim dtcC_columna13 As New DataColumn("SECC", GetType(System.String))
        Dim dtcC_columna14 As New DataColumn("TES_PADRE", GetType(System.Single))
        Dim dtcC_columna15 As New DataColumn("ARE_ID", GetType(System.Single))
        Dim dtcC_columna16 As New DataColumn("ORDEN", GetType(System.Single))

        dtt_Cut.Columns.Add(dtcC_columna1)
        dtt_Cut.Columns.Add(dtcC_columna2)
        dtt_Cut.Columns.Add(dtcC_columna3)
        dtt_Cut.Columns.Add(dtcC_columna4)
        dtt_Cut.Columns.Add(dtcC_columna5)
        dtt_Cut.Columns.Add(dtcC_columna6)
        dtt_Cut.Columns.Add(dtcC_columna7)
        dtt_Cut.Columns.Add(dtcC_columna8)
        dtt_Cut.Columns.Add(dtcC_columna9)
        dtt_Cut.Columns.Add(dtcC_columna10)
        dtt_Cut.Columns.Add(dtcC_columna11)
        dtt_Cut.Columns.Add(dtcC_columna12)
        dtt_Cut.Columns.Add(dtcC_columna13)
        dtt_Cut.Columns.Add(dtcC_columna14)
        dtt_Cut.Columns.Add(dtcC_columna15)
        dtt_Cut.Columns.Add(dtcC_columna16)

        actualizaDtsCutaneas(ped_id, 401310, dgv_Alimentos, dtt_Cut, fechaCutanea)

        dgv_Alimentos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Alimentos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_Alimentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_Alimentos.Columns("ped_id").Visible = False
        dgv_Alimentos.Columns("PRCC_FECHA").Visible = False
        dgv_Alimentos.Columns("PRCC_HORA").Visible = False
        dgv_Alimentos.Columns("TES_ABREV").Visible = False
        dgv_Alimentos.Columns("TES_NOMBRE").Width = 80
        dgv_Alimentos.Columns("TES_NOMBRE").HeaderText = "SUSTANCIA"

        dgv_Alimentos.Columns("PRCC_RESUL_ANIO").Width = 40
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO").HeaderText = "(R) " & fechaCutanea
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO").ReadOnly = True

        dgv_Alimentos.Columns("PRCC_RESUL_INT").Width = 40
        dgv_Alimentos.Columns("PRCC_RESUL_INT").HeaderText = "(I) " & fechaCutanea
        dgv_Alimentos.Columns("PRCC_RESUL_INT").ReadOnly = True

        dgv_Alimentos.Columns("PRCC_RESUL_ANIO2").Width = 40
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO2").HeaderText = ""
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO2").ReadOnly = True
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO2").Visible = False

        dgv_Alimentos.Columns("PRCC_RESUL_INT2").Width = 40
        dgv_Alimentos.Columns("PRCC_RESUL_INT2").HeaderText = ""
        dgv_Alimentos.Columns("PRCC_RESUL_INT2").ReadOnly = True
        dgv_Alimentos.Columns("PRCC_RESUL_INT2").Visible = False

        dgv_Alimentos.Columns("PRCC_RESUL_ANIO3").Width = 40
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO3").HeaderText = ""
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO3").ReadOnly = True
        dgv_Alimentos.Columns("PRCC_RESUL_ANIO3").Visible = False

        dgv_Alimentos.Columns("PRCC_RESUL_INT3").Width = 40
        dgv_Alimentos.Columns("PRCC_RESUL_INT3").HeaderText = ""
        dgv_Alimentos.Columns("PRCC_RESUL_INT3").ReadOnly = True
        dgv_Alimentos.Columns("PRCC_RESUL_INT3").Visible = False

        dgv_Alimentos.Columns("TIM_ID").Visible = False
        dgv_Alimentos.Columns("SECC").Visible = False
        dgv_Alimentos.Columns("TES_PADRE").Visible = False
        dgv_Alimentos.Columns("ARE_ID").Visible = False
        dgv_Alimentos.Columns("ORDEN").Visible = False

        dgv_Alimentos.Name = "ALIMENTOS"


        With dgv_Alimentos

            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


        ''***********************************
        '' OTRAS SUSTACIAS
        ''***********************************
        Dim dtcS_columna1 As New DataColumn("ped_id", GetType(System.Single))
        Dim dtcS_columna2 As New DataColumn("PRCC_FECHA", GetType(System.String))
        Dim dtcS_columna3 As New DataColumn("PRCC_HORA", GetType(System.String))
        Dim dtcS_columna4 As New DataColumn("TES_ABREV", GetType(System.String))
        Dim dtcS_columna5 As New DataColumn("TES_NOMBRE", GetType(System.String))

        Dim dtcS_columna6 As New DataColumn("PRCC_RESUL_ANIO", GetType(System.String))
        Dim dtcS_columna7 As New DataColumn("PRCC_RESUL_INT", GetType(System.String))

        Dim dtcS_columna8 As New DataColumn("PRCC_RESUL_ANIO2", GetType(System.String))
        Dim dtcS_columna9 As New DataColumn("PRCC_RESUL_INT2", GetType(System.String))

        Dim dtcS_columna10 As New DataColumn("PRCC_RESUL_ANIO3", GetType(System.String))
        Dim dtcS_columna11 As New DataColumn("PRCC_RESUL_INT3", GetType(System.String))

        Dim dtcS_columna12 As New DataColumn("TIM_ID", GetType(System.Single))
        Dim dtcS_columna13 As New DataColumn("SECC", GetType(System.String))
        Dim dtcS_columna14 As New DataColumn("TES_PADRE", GetType(System.Single))
        Dim dtcS_columna15 As New DataColumn("ARE_ID", GetType(System.Single))
        Dim dtcS_columna16 As New DataColumn("ORDEN", GetType(System.Single))

        dtt_Cut6.Columns.Add(dtcS_columna1)
        dtt_Cut6.Columns.Add(dtcS_columna2)
        dtt_Cut6.Columns.Add(dtcS_columna3)
        dtt_Cut6.Columns.Add(dtcS_columna4)
        dtt_Cut6.Columns.Add(dtcS_columna5)
        dtt_Cut6.Columns.Add(dtcS_columna6)
        dtt_Cut6.Columns.Add(dtcS_columna7)
        dtt_Cut6.Columns.Add(dtcS_columna8)
        dtt_Cut6.Columns.Add(dtcS_columna9)
        dtt_Cut6.Columns.Add(dtcS_columna10)
        dtt_Cut6.Columns.Add(dtcS_columna11)
        dtt_Cut6.Columns.Add(dtcS_columna12)
        dtt_Cut6.Columns.Add(dtcS_columna13)
        dtt_Cut6.Columns.Add(dtcS_columna14)
        dtt_Cut6.Columns.Add(dtcS_columna15)
        dtt_Cut6.Columns.Add(dtcS_columna16)

        actualizaDtsCutaneas(ped_id, 401322, dgv_Sustancias, dtt_Cut6, fechaCutanea)

        dgv_Sustancias.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Sustancias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_Sustancias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_Sustancias.Columns("ped_id").Visible = False
        dgv_Sustancias.Columns("PRCC_FECHA").Visible = False
        dgv_Sustancias.Columns("PRCC_HORA").Visible = False
        dgv_Sustancias.Columns("TES_ABREV").Visible = False
        dgv_Sustancias.Columns("TES_NOMBRE").Width = 80
        dgv_Sustancias.Columns("TES_NOMBRE").HeaderText = "SUSTANCIA"

        dgv_Sustancias.Columns("PRCC_RESUL_ANIO").Width = 40
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO").HeaderText = "(R) " & fechaCutanea
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO").ReadOnly = True

        dgv_Sustancias.Columns("PRCC_RESUL_INT").Width = 40
        dgv_Sustancias.Columns("PRCC_RESUL_INT").HeaderText = "(I) " & fechaCutanea
        dgv_Sustancias.Columns("PRCC_RESUL_INT").ReadOnly = True

        dgv_Sustancias.Columns("PRCC_RESUL_ANIO2").Width = 40
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO2").HeaderText = ""
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO2").ReadOnly = True
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO2").Visible = False

        dgv_Sustancias.Columns("PRCC_RESUL_INT2").Width = 40
        dgv_Sustancias.Columns("PRCC_RESUL_INT2").HeaderText = ""
        dgv_Sustancias.Columns("PRCC_RESUL_INT2").ReadOnly = True
        dgv_Sustancias.Columns("PRCC_RESUL_INT2").Visible = False

        dgv_Sustancias.Columns("PRCC_RESUL_ANIO3").Width = 40
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO3").HeaderText = ""
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO3").ReadOnly = True
        dgv_Sustancias.Columns("PRCC_RESUL_ANIO3").Visible = False

        dgv_Sustancias.Columns("PRCC_RESUL_INT3").Width = 40
        dgv_Sustancias.Columns("PRCC_RESUL_INT3").HeaderText = ""
        dgv_Sustancias.Columns("PRCC_RESUL_INT3").ReadOnly = True
        dgv_Sustancias.Columns("PRCC_RESUL_INT3").Visible = False

        dgv_Sustancias.Columns("TIM_ID").Visible = False
        dgv_Sustancias.Columns("SECC").Visible = False
        dgv_Sustancias.Columns("TES_PADRE").Visible = False
        dgv_Sustancias.Columns("ARE_ID").Visible = False
        dgv_Sustancias.Columns("ORDEN").Visible = False

        dgv_Sustancias.Name = "OTRAS SUSTANCIAS"

        With dgv_Sustancias
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With



        '***********************************
        ' INHALANTES
        '***********************************
        Dim dtcI_columna1 As New DataColumn("ped_id", GetType(System.Single))
        Dim dtcI_columna2 As New DataColumn("PRCC_FECHA", GetType(System.String))
        Dim dtcI_columna3 As New DataColumn("PRCC_HORA", GetType(System.String))
        Dim dtcI_columna4 As New DataColumn("TES_ABREV", GetType(System.String))
        Dim dtcI_columna5 As New DataColumn("TES_NOMBRE", GetType(System.String))

        Dim dtcI_columna6 As New DataColumn("PRCC_RESUL_ANIO", GetType(System.String))
        Dim dtcI_columna7 As New DataColumn("PRCC_RESUL_INT", GetType(System.String))

        Dim dtcI_columna8 As New DataColumn("PRCC_RESUL_ANIO2", GetType(System.String))
        Dim dtcI_columna9 As New DataColumn("PRCC_RESUL_INT2", GetType(System.String))

        Dim dtcI_columna10 As New DataColumn("PRCC_RESUL_ANIO3", GetType(System.String))
        Dim dtcI_columna11 As New DataColumn("PRCC_RESUL_INT3", GetType(System.String))

        Dim dtcI_columna12 As New DataColumn("TIM_ID", GetType(System.Single))
        Dim dtcI_columna13 As New DataColumn("SECC", GetType(System.String))
        Dim dtcI_columna14 As New DataColumn("TES_PADRE", GetType(System.Single))
        Dim dtcI_columna15 As New DataColumn("ARE_ID", GetType(System.Single))
        Dim dtcI_columna16 As New DataColumn("ORDEN", GetType(System.Single))

        dtt_Cut2.Columns.Add(dtcI_columna1)
        dtt_Cut2.Columns.Add(dtcI_columna2)
        dtt_Cut2.Columns.Add(dtcI_columna3)
        dtt_Cut2.Columns.Add(dtcI_columna4)
        dtt_Cut2.Columns.Add(dtcI_columna5)
        dtt_Cut2.Columns.Add(dtcI_columna6)
        dtt_Cut2.Columns.Add(dtcI_columna7)
        dtt_Cut2.Columns.Add(dtcI_columna8)
        dtt_Cut2.Columns.Add(dtcI_columna9)
        dtt_Cut2.Columns.Add(dtcI_columna10)
        dtt_Cut2.Columns.Add(dtcI_columna11)
        dtt_Cut2.Columns.Add(dtcI_columna12)
        dtt_Cut2.Columns.Add(dtcI_columna13)
        dtt_Cut2.Columns.Add(dtcI_columna14)
        dtt_Cut2.Columns.Add(dtcI_columna15)
        dtt_Cut2.Columns.Add(dtcI_columna16)

        actualizaDtsCutaneas(ped_id, 401311, dgv_Inhalantes, dtt_Cut2, fechaCutanea)

        dgv_Inhalantes.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Inhalantes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_Inhalantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_Inhalantes.Columns("ped_id").Visible = False
        dgv_Inhalantes.Columns("PRCC_FECHA").Visible = False
        dgv_Inhalantes.Columns("PRCC_HORA").Visible = False
        dgv_Inhalantes.Columns("TES_ABREV").Visible = False

        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO").Width = 40
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO").HeaderText = "(R) " & fechaCutanea
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO").ReadOnly = True

        dgv_Inhalantes.Columns("PRCC_RESUL_INT").Width = 40
        dgv_Inhalantes.Columns("PRCC_RESUL_INT").HeaderText = "(I) " & fechaCutanea
        dgv_Inhalantes.Columns("PRCC_RESUL_INT").ReadOnly = True

        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO2").Width = 40
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO2").HeaderText = ""
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO2").ReadOnly = True
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO2").Visible = False

        dgv_Inhalantes.Columns("PRCC_RESUL_INT2").Width = 40
        dgv_Inhalantes.Columns("PRCC_RESUL_INT2").HeaderText = ""
        dgv_Inhalantes.Columns("PRCC_RESUL_INT2").ReadOnly = True
        dgv_Inhalantes.Columns("PRCC_RESUL_INT2").Visible = False

        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO3").Width = 40
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO3").HeaderText = ""
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO3").ReadOnly = True
        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO3").Visible = False

        dgv_Inhalantes.Columns("PRCC_RESUL_INT3").Width = 40
        dgv_Inhalantes.Columns("PRCC_RESUL_INT3").HeaderText = ""
        dgv_Inhalantes.Columns("PRCC_RESUL_INT3").ReadOnly = True
        dgv_Inhalantes.Columns("PRCC_RESUL_INT3").Visible = False

        dgv_Inhalantes.Columns("TIM_ID").Visible = False
        dgv_Inhalantes.Columns("SECC").Visible = False
        dgv_Inhalantes.Columns("TES_PADRE").Visible = False
        dgv_Inhalantes.Columns("ARE_ID").Visible = False
        dgv_Inhalantes.Columns("ORDEN").Visible = False

        dgv_Inhalantes.Name = "INHALANTES"
        With dgv_Inhalantes
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


        '***********************************
        ' MEDICAMENTOS
        '***********************************
        Dim dtcM_columna1 As New DataColumn("ped_id", GetType(System.Single))
        Dim dtcM_columna2 As New DataColumn("PRCC_FECHA", GetType(System.String))
        Dim dtcM_columna3 As New DataColumn("PRCC_HORA", GetType(System.String))
        Dim dtcM_columna4 As New DataColumn("TES_ABREV", GetType(System.String))
        Dim dtcM_columna5 As New DataColumn("TES_NOMBRE", GetType(System.String))

        Dim dtcM_columna6 As New DataColumn("PRCC_RESUL_ANIO", GetType(System.String))
        Dim dtcM_columna7 As New DataColumn("PRCC_RESUL_INT", GetType(System.String))

        Dim dtcM_columna8 As New DataColumn("PRCC_RESUL_ANIO2", GetType(System.String))
        Dim dtcM_columna9 As New DataColumn("PRCC_RESUL_INT2", GetType(System.String))

        Dim dtcM_columna10 As New DataColumn("PRCC_RESUL_ANIO3", GetType(System.String))
        Dim dtcM_columna11 As New DataColumn("PRCC_RESUL_INT3", GetType(System.String))

        Dim dtcM_columna12 As New DataColumn("TIM_ID", GetType(System.Single))
        Dim dtcM_columna13 As New DataColumn("SECC", GetType(System.String))
        Dim dtcM_columna14 As New DataColumn("TES_PADRE", GetType(System.Single))
        Dim dtcM_columna15 As New DataColumn("ARE_ID", GetType(System.Single))
        Dim dtcM_columna16 As New DataColumn("ORDEN", GetType(System.Single))

        dtt_Cut3.Columns.Add(dtcM_columna1)
        dtt_Cut3.Columns.Add(dtcM_columna2)
        dtt_Cut3.Columns.Add(dtcM_columna3)
        dtt_Cut3.Columns.Add(dtcM_columna4)
        dtt_Cut3.Columns.Add(dtcM_columna5)
        dtt_Cut3.Columns.Add(dtcM_columna6)
        dtt_Cut3.Columns.Add(dtcM_columna7)
        dtt_Cut3.Columns.Add(dtcM_columna8)
        dtt_Cut3.Columns.Add(dtcM_columna9)
        dtt_Cut3.Columns.Add(dtcM_columna10)
        dtt_Cut3.Columns.Add(dtcM_columna11)
        dtt_Cut3.Columns.Add(dtcM_columna12)
        dtt_Cut3.Columns.Add(dtcM_columna13)
        dtt_Cut3.Columns.Add(dtcM_columna14)
        dtt_Cut3.Columns.Add(dtcM_columna15)
        dtt_Cut3.Columns.Add(dtcM_columna16)

        actualizaDtsCutaneas(ped_id, 401312, dgv_Medicamentos, dtt_Cut3, fechaCutanea)

        dgv_Medicamentos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Medicamentos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_Medicamentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_Medicamentos.Columns("ped_id").Visible = False
        dgv_Medicamentos.Columns("PRCC_FECHA").Visible = False
        dgv_Medicamentos.Columns("PRCC_HORA").Visible = False
        dgv_Medicamentos.Columns("TES_ABREV").Visible = False
        dgv_Medicamentos.Columns("TES_NOMBRE").Width = 100
        dgv_Medicamentos.Columns("TES_NOMBRE").HeaderText = "SUSTANCIA"

        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO").Width = 40
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO").HeaderText = "(R) " & fechaCutanea
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO").ReadOnly = True

        dgv_Medicamentos.Columns("PRCC_RESUL_INT").Width = 60
        dgv_Medicamentos.Columns("PRCC_RESUL_INT").HeaderText = "(I) " & fechaCutanea
        dgv_Medicamentos.Columns("PRCC_RESUL_INT").ReadOnly = True

        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO2").Width = 40
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO2").HeaderText = ""
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO2").ReadOnly = True
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO2").Visible = False

        dgv_Medicamentos.Columns("PRCC_RESUL_INT2").Width = 60
        dgv_Medicamentos.Columns("PRCC_RESUL_INT2").HeaderText = ""
        dgv_Medicamentos.Columns("PRCC_RESUL_INT2").ReadOnly = True
        dgv_Medicamentos.Columns("PRCC_RESUL_INT2").Visible = False

        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO3").Width = 40
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO3").HeaderText = ""
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO3").ReadOnly = True
        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO3").Visible = False

        dgv_Medicamentos.Columns("PRCC_RESUL_INT3").Width = 60
        dgv_Medicamentos.Columns("PRCC_RESUL_INT3").HeaderText = ""
        dgv_Medicamentos.Columns("PRCC_RESUL_INT3").ReadOnly = True
        dgv_Medicamentos.Columns("PRCC_RESUL_INT3").Visible = False

        dgv_Medicamentos.Columns("TIM_ID").Visible = False
        dgv_Medicamentos.Columns("SECC").Visible = False
        dgv_Medicamentos.Columns("TES_PADRE").Visible = False
        dgv_Medicamentos.Columns("ARE_ID").Visible = False
        dgv_Medicamentos.Columns("ORDEN").Visible = False

        dgv_Medicamentos.Name = "AINES"

        With dgv_Medicamentos
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        ''***********************************
        '' ANTIBIOTICOS
        ''***********************************
        Dim dtcA_columna1 As New DataColumn("ped_id", GetType(System.Single))
        Dim dtcA_columna2 As New DataColumn("PRCC_FECHA", GetType(System.String))
        Dim dtcA_columna3 As New DataColumn("PRCC_HORA", GetType(System.String))
        Dim dtcA_columna4 As New DataColumn("TES_ABREV", GetType(System.String))
        Dim dtcA_columna5 As New DataColumn("TES_NOMBRE", GetType(System.String))

        Dim dtcA_columna6 As New DataColumn("PRCC_RESUL_ANIO", GetType(System.String))
        Dim dtcA_columna7 As New DataColumn("PRCC_RESUL_INT", GetType(System.String))

        Dim dtcA_columna8 As New DataColumn("PRCC_RESUL_ANIO2", GetType(System.String))
        Dim dtcA_columna9 As New DataColumn("PRCC_RESUL_INT2", GetType(System.String))

        Dim dtcA_columna10 As New DataColumn("PRCC_RESUL_ANIO3", GetType(System.String))
        Dim dtcA_columna11 As New DataColumn("PRCC_RESUL_INT3", GetType(System.String))

        Dim dtcA_columna12 As New DataColumn("TIM_ID", GetType(System.Single))
        Dim dtcA_columna13 As New DataColumn("SECC", GetType(System.String))
        Dim dtcA_columna14 As New DataColumn("TES_PADRE", GetType(System.Single))
        Dim dtcA_columna15 As New DataColumn("ARE_ID", GetType(System.Single))
        Dim dtcA_columna16 As New DataColumn("ORDEN", GetType(System.Single))

        dtt_Cut4.Columns.Add(dtcA_columna1)
        dtt_Cut4.Columns.Add(dtcA_columna2)
        dtt_Cut4.Columns.Add(dtcA_columna3)
        dtt_Cut4.Columns.Add(dtcA_columna4)
        dtt_Cut4.Columns.Add(dtcA_columna5)
        dtt_Cut4.Columns.Add(dtcA_columna6)
        dtt_Cut4.Columns.Add(dtcA_columna7)
        dtt_Cut4.Columns.Add(dtcA_columna8)
        dtt_Cut4.Columns.Add(dtcA_columna9)
        dtt_Cut4.Columns.Add(dtcA_columna10)
        dtt_Cut4.Columns.Add(dtcA_columna11)
        dtt_Cut4.Columns.Add(dtcA_columna12)
        dtt_Cut4.Columns.Add(dtcA_columna13)
        dtt_Cut4.Columns.Add(dtcA_columna14)
        dtt_Cut4.Columns.Add(dtcA_columna15)
        dtt_Cut4.Columns.Add(dtcA_columna16)

        actualizaDtsCutaneas(ped_id, 401321, dgv_Antibioticos, dtt_Cut4, fechaCutanea)

        dgv_Antibioticos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Antibioticos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_Antibioticos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_Antibioticos.Columns("ped_id").Visible = False
        dgv_Antibioticos.Columns("PRCC_FECHA").Visible = False
        dgv_Antibioticos.Columns("PRCC_HORA").Visible = False
        dgv_Antibioticos.Columns("TES_ABREV").Visible = False
        dgv_Antibioticos.Columns("TES_NOMBRE").Width = 80
        dgv_Antibioticos.Columns("TES_NOMBRE").HeaderText = "SUSTANCIA"

        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO").Width = 40
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO").HeaderText = "(R) " & fechaCutanea
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO").ReadOnly = True

        dgv_Antibioticos.Columns("PRCC_RESUL_INT").Width = 60
        dgv_Antibioticos.Columns("PRCC_RESUL_INT").HeaderText = "(I) " & fechaCutanea
        dgv_Antibioticos.Columns("PRCC_RESUL_INT").ReadOnly = True

        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO2").Width = 40
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO2").HeaderText = ""
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO2").ReadOnly = True
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO2").Visible = False

        dgv_Antibioticos.Columns("PRCC_RESUL_INT2").Width = 60
        dgv_Antibioticos.Columns("PRCC_RESUL_INT2").HeaderText = ""
        dgv_Antibioticos.Columns("PRCC_RESUL_INT2").ReadOnly = True
        dgv_Antibioticos.Columns("PRCC_RESUL_INT2").Visible = False

        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO3").Width = 40
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO3").HeaderText = ""
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO3").ReadOnly = True
        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO3").Visible = False

        dgv_Antibioticos.Columns("PRCC_RESUL_INT3").Width = 60
        dgv_Antibioticos.Columns("PRCC_RESUL_INT3").HeaderText = ""
        dgv_Antibioticos.Columns("PRCC_RESUL_INT3").ReadOnly = True
        dgv_Antibioticos.Columns("PRCC_RESUL_INT3").Visible = False

        dgv_Antibioticos.Columns("TIM_ID").Visible = False
        dgv_Antibioticos.Columns("SECC").Visible = False
        dgv_Antibioticos.Columns("TES_PADRE").Visible = False
        dgv_Antibioticos.Columns("ARE_ID").Visible = False
        dgv_Antibioticos.Columns("ORDEN").Visible = False

        dgv_Antibioticos.Name = "ANTIBIOTICOS"

        With dgv_Antibioticos
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With


        ''***********************************
        '' OTRAS SUSTANCIAS
        ''***********************************
        Dim dtcO_columna1 As New DataColumn("ped_id", GetType(System.Single))
        Dim dtcO_columna2 As New DataColumn("PRCC_FECHA", GetType(System.String))
        Dim dtcO_columna3 As New DataColumn("PRCC_HORA", GetType(System.String))
        Dim dtcO_columna4 As New DataColumn("TES_ABREV", GetType(System.String))
        Dim dtcO_columna5 As New DataColumn("TES_NOMBRE", GetType(System.String))

        Dim dtcO_columna6 As New DataColumn("PRCC_RESUL_ANIO", GetType(System.String))
        Dim dtcO_columna7 As New DataColumn("PRCC_RESUL_INT", GetType(System.String))

        Dim dtcO_columna8 As New DataColumn("PRCC_RESUL_ANIO2", GetType(System.String))
        Dim dtcO_columna9 As New DataColumn("PRCC_RESUL_INT2", GetType(System.String))

        Dim dtcO_columna10 As New DataColumn("PRCC_RESUL_ANIO3", GetType(System.String))
        Dim dtcO_columna11 As New DataColumn("PRCC_RESUL_INT3", GetType(System.String))

        Dim dtcO_columna12 As New DataColumn("TIM_ID", GetType(System.Single))
        Dim dtcO_columna13 As New DataColumn("SECC", GetType(System.String))
        Dim dtcO_columna14 As New DataColumn("TES_PADRE", GetType(System.Single))
        Dim dtcO_columna15 As New DataColumn("ARE_ID", GetType(System.Single))
        Dim dtcO_columna16 As New DataColumn("ORDEN", GetType(System.Single))

        dtt_Cut5.Columns.Add(dtcO_columna1)
        dtt_Cut5.Columns.Add(dtcO_columna2)
        dtt_Cut5.Columns.Add(dtcO_columna3)
        dtt_Cut5.Columns.Add(dtcO_columna4)
        dtt_Cut5.Columns.Add(dtcO_columna5)
        dtt_Cut5.Columns.Add(dtcO_columna6)
        dtt_Cut5.Columns.Add(dtcO_columna7)
        dtt_Cut5.Columns.Add(dtcO_columna8)
        dtt_Cut5.Columns.Add(dtcO_columna9)
        dtt_Cut5.Columns.Add(dtcO_columna10)
        dtt_Cut5.Columns.Add(dtcO_columna11)
        dtt_Cut5.Columns.Add(dtcO_columna12)
        dtt_Cut5.Columns.Add(dtcO_columna13)
        dtt_Cut5.Columns.Add(dtcO_columna14)
        dtt_Cut5.Columns.Add(dtcO_columna15)
        dtt_Cut5.Columns.Add(dtcO_columna16)

        actualizaDtsCutaneas(ped_id, 401325, dgv_Otros, dtt_Cut5, fechaCutanea)

        dgv_Otros.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Otros.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_Otros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv_Otros.Columns("ped_id").Visible = False
        dgv_Otros.Columns("PRCC_FECHA").Visible = False
        dgv_Otros.Columns("PRCC_HORA").Visible = False
        dgv_Otros.Columns("TES_ABREV").Visible = False
        dgv_Otros.Columns("TES_NOMBRE").Width = 80
        dgv_Otros.Columns("TES_NOMBRE").HeaderText = "SUSTANCIA"

        dgv_Otros.Columns("PRCC_RESUL_ANIO").Width = 40
        dgv_Otros.Columns("PRCC_RESUL_ANIO").HeaderText = "(R) " & fechaCutanea
        dgv_Otros.Columns("PRCC_RESUL_ANIO").ReadOnly = True

        dgv_Otros.Columns("PRCC_RESUL_INT").Width = 60
        dgv_Otros.Columns("PRCC_RESUL_INT").HeaderText = "(I) " & fechaCutanea
        dgv_Otros.Columns("PRCC_RESUL_INT").ReadOnly = True

        dgv_Otros.Columns("PRCC_RESUL_ANIO2").Width = 40
        dgv_Otros.Columns("PRCC_RESUL_ANIO2").HeaderText = ""
        dgv_Otros.Columns("PRCC_RESUL_ANIO2").ReadOnly = True
        dgv_Otros.Columns("PRCC_RESUL_ANIO2").Visible = False

        dgv_Otros.Columns("PRCC_RESUL_INT2").Width = 60
        dgv_Otros.Columns("PRCC_RESUL_INT2").HeaderText = ""
        dgv_Otros.Columns("PRCC_RESUL_INT2").ReadOnly = True
        dgv_Otros.Columns("PRCC_RESUL_INT2").Visible = False

        dgv_Otros.Columns("PRCC_RESUL_ANIO3").Width = 40
        dgv_Otros.Columns("PRCC_RESUL_ANIO3").HeaderText = ""
        dgv_Otros.Columns("PRCC_RESUL_ANIO3").ReadOnly = True
        dgv_Otros.Columns("PRCC_RESUL_ANIO3").Visible = False

        dgv_Otros.Columns("PRCC_RESUL_INT3").Width = 60
        dgv_Otros.Columns("PRCC_RESUL_INT3").HeaderText = ""
        dgv_Otros.Columns("PRCC_RESUL_INT3").ReadOnly = True
        dgv_Otros.Columns("PRCC_RESUL_INT3").Visible = False

        dgv_Otros.Columns("TIM_ID").Visible = False
        dgv_Otros.Columns("SECC").Visible = False
        dgv_Otros.Columns("TES_PADRE").Visible = False
        dgv_Otros.Columns("ARE_ID").Visible = False
        dgv_Otros.Columns("ORDEN").Visible = False


        dgv_Otros.Name = "OTRAS SUSTANCIAS"

        With dgv_Otros
            .ColumnHeadersDefaultCellStyle.Font = headerFont
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.CellSelect
        End With

        

        If opr_pedido.LeerDermografismo(Age_id) = 1 Then
            chk_Dermografico.Checked = True
        Else
            chk_Dermografico.Checked = False
        End If

        If opr_pedido.LeerInfante(Age_id) = 1 Then
            chk_Infante.Checked = True
        Else
            chk_Infante.Checked = False
        End If

        sw_historicos = 1
    End Sub

    Private Sub cargaHistoricos(ByVal Age_Anterior As Integer, ByVal fechaAnterior As String, ByVal nivel As Integer)
        ''BUSCO EL No DE AGENDA ANTERIOR INMEDIATA

        Dim i, j As Integer
        Dim arre_tes_abrev As String()
        Dim str_res As String
        Dim arre_res As String()

        If Age_Anterior > 0 Then

        Select nivel
                Case 1
                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401310), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Alimentos.Columns("PRCC_RESUL_ANIO2").Width = 40
                        dgv_Alimentos.Columns("PRCC_RESUL_ANIO2").HeaderText = "(R) " & fechaAnterior
                        dgv_Alimentos.Columns("PRCC_RESUL_ANIO2").Visible = True

                        dgv_Alimentos.Columns("PRCC_RESUL_INT2").Width = 40
                        dgv_Alimentos.Columns("PRCC_RESUL_INT2").HeaderText = "(I) " & fechaAnterior
                        dgv_Alimentos.Columns("PRCC_RESUL_INT2").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Alimentos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Alimentos.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Alimentos.Rows(j).Cells(7)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Alimentos.Rows(j).Cells(8)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next

                        Next
                    End If


                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401322), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Sustancias.Columns("PRCC_RESUL_ANIO2").Width = 40
                        dgv_Sustancias.Columns("PRCC_RESUL_ANIO2").HeaderText = "(R) " & fechaAnterior
                        dgv_Sustancias.Columns("PRCC_RESUL_ANIO2").Visible = True

                        dgv_Sustancias.Columns("PRCC_RESUL_INT2").Width = 40
                        dgv_Sustancias.Columns("PRCC_RESUL_INT2").HeaderText = "(I) " & fechaAnterior
                        dgv_Sustancias.Columns("PRCC_RESUL_INT2").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Sustancias.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Sustancias.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Sustancias.Rows(j).Cells(7)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Sustancias.Rows(j).Cells(8)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next

                        Next
                    End If

                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401311), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO2").Width = 40
                        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO2").HeaderText = "(R) " & fechaAnterior
                        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO2").Visible = True

                        dgv_Inhalantes.Columns("PRCC_RESUL_INT2").Width = 40
                        dgv_Inhalantes.Columns("PRCC_RESUL_INT2").HeaderText = "(I) " & fechaAnterior
                        dgv_Inhalantes.Columns("PRCC_RESUL_INT2").Visible = True
                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")
                            For j = 0 To dgv_Alimentos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Inhalantes.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Inhalantes.Rows(j).Cells(7)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Inhalantes.Rows(j).Cells(8)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next

                        Next
                    End If


                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401312), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO2").Width = 40
                        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO2").HeaderText = "(R) " & fechaAnterior
                        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO2").Visible = True

                        dgv_Medicamentos.Columns("PRCC_RESUL_INT2").Width = 40
                        dgv_Medicamentos.Columns("PRCC_RESUL_INT2").HeaderText = "(I) " & fechaAnterior
                        dgv_Medicamentos.Columns("PRCC_RESUL_INT2").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Medicamentos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Medicamentos.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Medicamentos.Rows(j).Cells(7)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Medicamentos.Rows(j).Cells(8)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next
                        Next
                    End If


                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401321), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO2").Width = 40
                        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO2").HeaderText = "(R) " & fechaAnterior
                        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO2").Visible = True

                        dgv_Antibioticos.Columns("PRCC_RESUL_INT2").Width = 40
                        dgv_Antibioticos.Columns("PRCC_RESUL_INT2").HeaderText = "(I) " & fechaAnterior
                        dgv_Antibioticos.Columns("PRCC_RESUL_INT2").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Antibioticos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Antibioticos.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Antibioticos.Rows(j).Cells(7)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Antibioticos.Rows(j).Cells(8)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401325), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Otros.Columns("PRCC_RESUL_ANIO2").Width = 40
                        dgv_Otros.Columns("PRCC_RESUL_ANIO2").HeaderText = "(R) " & fechaAnterior
                        dgv_Otros.Columns("PRCC_RESUL_ANIO2").Visible = True

                        dgv_Otros.Columns("PRCC_RESUL_INT2").Width = 40
                        dgv_Otros.Columns("PRCC_RESUL_INT2").HeaderText = "(I) " & fechaAnterior
                        dgv_Otros.Columns("PRCC_RESUL_INT2").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Otros.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Otros.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Otros.Rows(j).Cells(7)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Otros.Rows(j).Cells(8)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next
                        Next
                    End If


                Case 2
                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401310), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Alimentos.Columns("PRCC_RESUL_ANIO3").Width = 40
                        dgv_Alimentos.Columns("PRCC_RESUL_ANIO3").HeaderText = "(R) " & fechaAnterior
                        dgv_Alimentos.Columns("PRCC_RESUL_ANIO3").Visible = True

                        dgv_Alimentos.Columns("PRCC_RESUL_INT3").Width = 40
                        dgv_Alimentos.Columns("PRCC_RESUL_INT3").HeaderText = "(I) " & fechaAnterior
                        dgv_Alimentos.Columns("PRCC_RESUL_INT3").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Alimentos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Alimentos.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Alimentos.Rows(j).Cells(9)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Alimentos.Rows(j).Cells(10)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next

                        Next
                    End If


                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401322), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Sustancias.Columns("PRCC_RESUL_ANIO3").Width = 40
                        dgv_Sustancias.Columns("PRCC_RESUL_ANIO3").HeaderText = "(R) " & fechaAnterior
                        dgv_Sustancias.Columns("PRCC_RESUL_ANIO3").Visible = True

                        dgv_Sustancias.Columns("PRCC_RESUL_INT3").Width = 40
                        dgv_Sustancias.Columns("PRCC_RESUL_INT3").HeaderText = "(I) " & fechaAnterior
                        dgv_Sustancias.Columns("PRCC_RESUL_INT3").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Sustancias.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Sustancias.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Sustancias.Rows(j).Cells(9)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Sustancias.Rows(j).Cells(10)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next

                        Next
                    End If

                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401311), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO3").Width = 40
                        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO3").HeaderText = "(R) " & fechaAnterior
                        dgv_Inhalantes.Columns("PRCC_RESUL_ANIO3").Visible = True

                        dgv_Inhalantes.Columns("PRCC_RESUL_INT3").Width = 40
                        dgv_Inhalantes.Columns("PRCC_RESUL_INT3").HeaderText = "(I) " & fechaAnterior
                        dgv_Inhalantes.Columns("PRCC_RESUL_INT3").Visible = True
                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")
                            For j = 0 To dgv_Alimentos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Inhalantes.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Inhalantes.Rows(j).Cells(9)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Inhalantes.Rows(j).Cells(10)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next

                        Next
                    End If


                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401312), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO3").Width = 40
                        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO3").HeaderText = "(R) " & fechaAnterior
                        dgv_Medicamentos.Columns("PRCC_RESUL_ANIO3").Visible = True

                        dgv_Medicamentos.Columns("PRCC_RESUL_INT3").Width = 40
                        dgv_Medicamentos.Columns("PRCC_RESUL_INT3").HeaderText = "(I) " & fechaAnterior
                        dgv_Medicamentos.Columns("PRCC_RESUL_INT3").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Medicamentos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Medicamentos.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Medicamentos.Rows(j).Cells(9)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Medicamentos.Rows(j).Cells(10)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next
                        Next
                    End If


                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401321), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO3").Width = 40
                        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO3").HeaderText = "(R) " & fechaAnterior
                        dgv_Antibioticos.Columns("PRCC_RESUL_ANIO3").Visible = True

                        dgv_Antibioticos.Columns("PRCC_RESUL_INT3").Width = 40
                        dgv_Antibioticos.Columns("PRCC_RESUL_INT3").HeaderText = "(I) " & fechaAnterior
                        dgv_Antibioticos.Columns("PRCC_RESUL_INT3").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Antibioticos.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Antibioticos.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Antibioticos.Rows(j).Cells(9)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Antibioticos.Rows(j).Cells(10)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next
                        Next
                    End If

                    arre_tes_abrev = Split(opr_res.ConsultaTes_Abrev(Age_Anterior, Pac_id, 401325), "º")
                    If UBound(arre_tes_abrev) > 0 Then
                        dgv_Otros.Columns("PRCC_RESUL_ANIO3").Width = 40
                        dgv_Otros.Columns("PRCC_RESUL_ANIO3").HeaderText = "(R) " & fechaAnterior
                        dgv_Otros.Columns("PRCC_RESUL_ANIO3").Visible = True

                        dgv_Otros.Columns("PRCC_RESUL_INT3").Width = 40
                        dgv_Otros.Columns("PRCC_RESUL_INT3").HeaderText = "(I) " & fechaAnterior
                        dgv_Otros.Columns("PRCC_RESUL_INT3").Visible = True

                        For i = 0 To UBound(arre_tes_abrev)
                            str_res = opr_res.ConsultaAgendaHistorico(Age_Anterior, arre_tes_abrev(i), Pac_id, 8)
                            arre_res = Split(str_res, "º")

                            For j = 0 To dgv_Otros.Rows.Count - 1
                                If arre_tes_abrev(i) = dgv_Otros.Rows(j).Cells(3).Value() Then
                                    Dim celda As DataGridViewCell = dgv_Otros.Rows(j).Cells(9)
                                    celda.Value = arre_res(0)

                                    Dim celda2 As DataGridViewCell = dgv_Otros.Rows(j).Cells(10)
                                    celda2.Value = arre_res(1)
                                    Exit For
                                End If
                            Next
                        Next
                    End If

            End Select

        End If


    End Sub
    

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim dermografico As Integer
        Dim infante As Integer

        If chk_Dermografico.Checked = True Then
            dermografico = 1
        Else
            dermografico = 0
        End If
        opr_pedido.actualizaDermografico(dermografico, Age_id)

        If chk_Infante.Checked = True Then
            infante = 1
        Else
            infante = 0
        End If
        opr_pedido.actualizaInfante(infante, Age_id)

        opr_pedido.ingreso_Cutaneas(dgv_Alimentos, dgv_Sustancias, dgv_Inhalantes, dgv_Medicamentos, dgv_Antibioticos, dgv_Otros, ped_id, Format(Now(), "dd-MM-yyyy"), Format(Now(), "HH:mm"))

    End Sub

    Private Sub chk_Infante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Infante.CheckedChanged
        If chk_Infante.Checked = True Then
            actualizaDtsCutaneas(ped_id, 401323, dgv_Alimentos, dtt_Cut, fechaCutanea)
            actualizaDtsCutaneas(ped_id, 401324, dgv_Inhalantes, dtt_Cut2, fechaCutanea)


            dgv_Medicamentos.Visible = False
            dgv_Antibioticos.Visible = False
            dgv_Sustancias.Visible = False
            dgv_Otros.Visible = False

            lblMedAines.Visible = False
            lblMedAB.Visible = False
            lblMedOtros.Visible = False
            lblSustancias.Visible = False
        Else
            dgv_Medicamentos.Visible = True
            dgv_Antibioticos.Visible = True
            dgv_Otros.Visible = True
            dgv_Sustancias.Visible = True

            lblMedAines.Visible = True
            lblMedAB.Visible = True
            lblMedOtros.Visible = True
            lblSustancias.Visible = True

            actualizaDtsCutaneas(ped_id, 401310, dgv_Alimentos, dtt_Cut, fechaCutanea)
            actualizaDtsCutaneas(ped_id, 401322, dgv_Sustancias, dtt_Cut6, fechaCutanea)
            actualizaDtsCutaneas(ped_id, 401311, dgv_Inhalantes, dtt_Cut2, fechaCutanea)
            actualizaDtsCutaneas(ped_id, 401312, dgv_Medicamentos, dtt_Cut3, fechaCutanea)
            actualizaDtsCutaneas(ped_id, 401321, dgv_Antibioticos, dtt_Cut4, fechaCutanea)
            actualizaDtsCutaneas(ped_id, 401325, dgv_Otros, dtt_Cut5, fechaCutanea)

        End If
    End Sub

    Private Sub dgv_Alimentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Alimentos.KeyDown
        'Dim visto As Char = ChrW(10003)
        Dim currentCell As DataGridViewCell = dgv_Alimentos.CurrentCell

        If currentCell IsNot Nothing Then
            ' Accede a la columna actual
            Dim currentColumn As DataGridViewColumn = dgv_Alimentos.Columns(currentCell.ColumnIndex)

            ' Obtiene la información de la celda actual
            Dim cellValue As Object = currentCell.Value
            Dim columnName As String = currentColumn.Name
            Dim rowIndex As Integer = currentCell.RowIndex
            Dim columnIndex As Integer = currentCell.ColumnIndex

            If e.KeyCode = Keys.Delete Then
                dgv_Alimentos.Rows(rowIndex).Cells(columnIndex).Value = ""
            End If

        End If

        ' ''Select Case e.KeyCode
        ' ''    Case Keys.Delete
        ' ''        dgv_Alimentos.CurrentRow.Cells("PRCC_RESUL_ANIO").Value = ""
        ' ''        'Keys.F9()
        ' ''        'dgv_Alimentos.CurrentRow.Cells("PRCC_RESUL_ANIO").Value = "+"

        ' ''        'Case Keys.F10
        ' ''        '    dgv_Alimentos.CurrentRow.Cells("PRCC_RESUL_INT").Value = visto

        ' ''        'Case Keys.F11
        ' ''        '    dgv_Alimentos.CurrentRow.Cells("PRCC_RESUL_INT").Value = "O"

        ' ''        'Case Keys.F12
        ' ''        '    dgv_Alimentos.CurrentRow.Cells("PRCC_RESUL_INT").Value = "."
        ' ''End Select

    End Sub

    Private Sub dgv_Sustancias_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Sustancias.KeyDown
        Dim currentCell As DataGridViewCell = dgv_Alimentos.CurrentCell

        If currentCell IsNot Nothing Then
            ' Accede a la columna actual
            Dim currentColumn As DataGridViewColumn = dgv_Sustancias.Columns(currentCell.ColumnIndex)

            ' Obtiene la información de la celda actual
            Dim cellValue As Object = currentCell.Value
            Dim columnName As String = currentColumn.Name
            Dim rowIndex As Integer = currentCell.RowIndex
            Dim columnIndex As Integer = currentCell.ColumnIndex

            If e.KeyCode = Keys.Delete Then
                dgv_Sustancias.Rows(rowIndex).Cells(columnIndex).Value = ""
            End If

        End If
    End Sub

    Private Sub dgv_Inhalantes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Inhalantes.KeyDown
        Dim currentCell As DataGridViewCell = dgv_Alimentos.CurrentCell

        If currentCell IsNot Nothing Then
            ' Accede a la columna actual
            Dim currentColumn As DataGridViewColumn = dgv_Inhalantes.Columns(currentCell.ColumnIndex)

            ' Obtiene la información de la celda actual
            Dim cellValue As Object = currentCell.Value
            Dim columnName As String = currentColumn.Name
            Dim rowIndex As Integer = currentCell.RowIndex
            Dim columnIndex As Integer = currentCell.ColumnIndex

            If e.KeyCode = Keys.Delete Then
                dgv_Inhalantes.Rows(rowIndex).Cells(columnIndex).Value = ""
            End If

        End If
    End Sub

    Private Sub dgv_Medicamentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Medicamentos.KeyDown
        Dim currentCell As DataGridViewCell = dgv_Alimentos.CurrentCell

        If currentCell IsNot Nothing Then
            ' Accede a la columna actual
            Dim currentColumn As DataGridViewColumn = dgv_Medicamentos.Columns(currentCell.ColumnIndex)

            ' Obtiene la información de la celda actual
            Dim cellValue As Object = currentCell.Value
            Dim columnName As String = currentColumn.Name
            Dim rowIndex As Integer = currentCell.RowIndex
            Dim columnIndex As Integer = currentCell.ColumnIndex

            If e.KeyCode = Keys.Delete Then
                dgv_Medicamentos.Rows(rowIndex).Cells(columnIndex).Value = ""
            End If

        End If
    End Sub

    Private Sub dgv_Antibioticos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Antibioticos.KeyDown
        Dim currentCell As DataGridViewCell = dgv_Alimentos.CurrentCell

        If currentCell IsNot Nothing Then
            ' Accede a la columna actual
            Dim currentColumn As DataGridViewColumn = dgv_Antibioticos.Columns(currentCell.ColumnIndex)

            ' Obtiene la información de la celda actual
            Dim cellValue As Object = currentCell.Value
            Dim columnName As String = currentColumn.Name
            Dim rowIndex As Integer = currentCell.RowIndex
            Dim columnIndex As Integer = currentCell.ColumnIndex

            If e.KeyCode = Keys.Delete Then
                dgv_Antibioticos.Rows(rowIndex).Cells(columnIndex).Value = ""
            End If

        End If
    End Sub

    Private Sub dgv_Otros_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_Otros.KeyDown
        Dim currentCell As DataGridViewCell = dgv_Alimentos.CurrentCell

        If currentCell IsNot Nothing Then
            ' Accede a la columna actual
            Dim currentColumn As DataGridViewColumn = dgv_Otros.Columns(currentCell.ColumnIndex)

            ' Obtiene la información de la celda actual
            Dim cellValue As Object = currentCell.Value
            Dim columnName As String = currentColumn.Name
            Dim rowIndex As Integer = currentCell.RowIndex
            Dim columnIndex As Integer = currentCell.ColumnIndex

            If e.KeyCode = Keys.Delete Then
                dgv_Otros.Rows(rowIndex).Cells(columnIndex).Value = ""
            End If

        End If
    End Sub

    Private Sub cambiaColorColumna(ByVal e As DataGridViewCellFormattingEventArgs)
        'Private Sub cambiaColorColumna(ByVal dgv As DataGridView, ByVal e As DataGridViewCellFormattingEventArgs, ByVal nombreColumna As String)

        e.CellStyle.BackColor = Color.SteelBlue

        'If dgv.Columns(e.ColumnIndex).Name = nombreColumna Then
        '    ' Obtener el valor de la celda
        '    Dim valor As String = dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

        '    ' Cambiar el color de fondo de la celda según el valor
        '    If valor = "ValorDeseado" Then
        '        e.CellStyle.BackColor = Color.Red ' Cambiar el color a rojo
        '        e.CellStyle.ForeColor = Color.White ' Cambiar el color del texto a blanco
        '    ElseIf valor = "OtroValor" Then
        '        e.CellStyle.BackColor = Color.Blue ' Cambiar el color a azul
        '        e.CellStyle.ForeColor = Color.Yellow ' Cambiar el color del texto a amarillo
        '    End If
        'End If
    End Sub


    
    Private Sub btn_CargaHistoricos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CargaHistoricos.Click
        Dim fechaAnterior As String


        Select Case sw_historicos
            Case 1
                age_anterior = opr_res.ConsultaAgendaAnterior(Age_id, Pac_id, fechaAnterior)

                If age_anterior = 0 Then
                    opr_pedido.VisualizaMensaje("El paciente no tiene historicos", 250)
                Else
                    cargaHistoricos(age_anterior, fechaAnterior, 1)
                    sw_historicos = 2
                End If
            Case 2
                age_anterior2 = opr_res.ConsultaAgendaAnterior(age_anterior, Pac_id, fechaAnterior)

                If age_anterior2 = 0 Then
                    opr_pedido.VisualizaMensaje("El paciente no tiene historicos", 250)
                Else
                    cargaHistoricos(age_anterior2, fechaAnterior, 2)
                    sw_historicos = 0
                End If

                


        End Select
        

    End Sub

    Private Sub dgv_Alimentos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Alimentos.CellFormatting
        ' Verificar si es la columna deseada (por ejemplo, la columna 2)
        If e.ColumnIndex = 7 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 8 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If

        If e.ColumnIndex = 9 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 10 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub dgv_Inhalantes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Inhalantes.CellFormatting
        ' Verificar si es la columna deseada (por ejemplo, la columna 2)
        If e.ColumnIndex = 7 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 8 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If

        If e.ColumnIndex = 9 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 10 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub dgv_Sustancias_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Sustancias.CellFormatting
        ' Verificar si es la columna deseada (por ejemplo, la columna 2)
        If e.ColumnIndex = 7 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 8 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If

        If e.ColumnIndex = 9 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 10 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub dgv_Medicamentos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Medicamentos.CellFormatting
        ' Verificar si es la columna deseada (por ejemplo, la columna 2)
        If e.ColumnIndex = 7 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 8 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If

        If e.ColumnIndex = 9 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 10 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub dgv_Antibioticos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Antibioticos.CellFormatting
        ' Verificar si es la columna deseada (por ejemplo, la columna 2)
        If e.ColumnIndex = 7 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 8 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If

        If e.ColumnIndex = 9 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 10 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub dgv_Otros_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv_Otros.CellFormatting
        ' Verificar si es la columna deseada (por ejemplo, la columna 2)
        If e.ColumnIndex = 7 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 8 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If

        If e.ColumnIndex = 9 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightSteelBlue
        End If

        If e.ColumnIndex = 10 Then
            ' Cambiar el color de fondo de la celda actual
            e.CellStyle.BackColor = Color.LightGray
        End If
    End Sub

    
   

    Private Sub dgv_Alimentos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Alimentos.CellClick

        Dim visto As Char = ChrW(10003)

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Select Case e.ColumnIndex
                Case 5
                    Select Case Trim(dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "+"
                            dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "++"
                            'dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "++"
                        Case "++"
                            dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                        Case "", " ", "   ", "          "
                            dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "+"
                    End Select


                Case 6
                    Select Case Trim(dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "", " ", "   ", "          "
                            dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "."
                        Case "."
                            dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = visto
                        Case visto
                            dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "O"
                        Case "O"
                            dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""

                    End Select

            End Select
            dgv_Alimentos.ClearSelection()

            'Dim valorCelda As Object = dgv_Alimentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value



        End If

    End Sub

    Private Sub dgv_Inhalantes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Inhalantes.CellClick
        Dim visto As Char = ChrW(10003)

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Select Case e.ColumnIndex
                Case 5
                    Select Case Trim(dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "+"
                            dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "++"
                        Case "++"
                            dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                        Case "", " ", "   ", "          "
                            dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "+"
                    End Select


                Case 6
                    Select Case Trim(dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "", " ", "   ", "          "
                            dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = visto
                        Case visto
                            dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "O"
                        Case "O"
                            dgv_Inhalantes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""

                    End Select

            End Select
        End If

    End Sub

    Private Sub dgv_Medicamentos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Medicamentos.CellClick
        Dim visto As Char = ChrW(10003)

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Select Case e.ColumnIndex
                Case 5
                    Select Case Trim(dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "+"
                            dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                        Case "", " ", "   ", "          "
                            dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "+"
                    End Select


                Case 6
                    Select Case Trim(dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "", " ", "   ", "          "
                            dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Positivo"
                        Case "p", "P", "POSITIVO", "positivo", "Positivo"
                            dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Negativo"
                        Case "n", "N", "NEGATIVO", "negativo", "Negativo"
                            dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Positivo"
                        Case "Positivo"
                            dgv_Medicamentos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                    End Select

            End Select
        End If


    End Sub

    Private Sub dgv_Antibioticos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Antibioticos.CellClick
        Dim visto As Char = ChrW(10003)

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Select Case e.ColumnIndex
                Case 5
                    Select Case Trim(dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "+"
                            dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                        Case "", " ", "   ", "          "
                            dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "+"
                    End Select


                Case 6
                    Select Case Trim(dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "", " ", "   ", "          "
                            dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Positivo"
                        Case "p", "P", "POSITIVO", "positivo", "Positivo"
                            dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Negativo"
                        Case "n", "N", "NEGATIVO", "negativo", "Negativo"
                            dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Positivo"
                        Case "Positivo"
                            dgv_Antibioticos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""

                    End Select

            End Select
        End If
    End Sub

    Private Sub dgv_Sustancias_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Sustancias.CellClick
        Dim visto As Char = ChrW(10003)

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Select Case e.ColumnIndex
                Case 5
                    Select Case Trim(dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "+"
                            dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "++"
                        Case "++"
                            dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                        Case "", " ", "   ", "          "
                            dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "+"
                    End Select


                Case 6
                    Select Case Trim(dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "", " ", "   ", "          "
                            dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = visto
                        Case visto
                            dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "O"
                        Case "O"
                            dgv_Sustancias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""

                    End Select

            End Select
        End If
    End Sub

    Private Sub dgv_Otros_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Otros.CellClick
        Dim visto As Char = ChrW(10003)

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Select Case e.ColumnIndex
                Case 5
                    Select Case Trim(dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "+"
                            dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                        Case "", " ", "   ", "          "
                            dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "+"
                    End Select


                Case 6
                    Select Case Trim(dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                        Case "", " ", "   ", "          "
                            dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Positivo"
                        Case "p", "P", "POSITIVO", "positivo", "Positivo"
                            dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Negativo"
                        Case "n", "N", "NEGATIVO", "negativo", "Negativo"
                            dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Positivo"
                        Case "Positivo"
                            dgv_Otros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""


                    End Select

            End Select
        End If
    End Sub


End Class