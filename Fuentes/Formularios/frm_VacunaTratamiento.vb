Imports System.IO

Public Class frm_VacunaTratamiento

    'Private WithEvents dtt_vacuna As New DataTable("Registros")
    Public frm_refer_main As Frm_Main
    Dim opr_res As New Cls_Resultado()
    Dim dtv_Vacunas As New DataView()
    Dim dtv_Materiales As New DataView()

    Dim dtv_Series As New DataView()
    Dim opr_medico As New Cls_Medico()

    Public consulta As String = Nothing
    Public var_vacuna As String = Nothing
    Dim EsAdulto As String
    Dim opr_pedido As New Cls_Pedido
    Public ventana_tipo As Integer
    Public Age_id As Integer
    Public Age_resumen As String
    Public med_id As Integer
    Public med_nombre As String
    Public pac_id As Integer
    Public turno As String
    Dim arr_datosTTO As String()
    Dim swEntra As Boolean
    'Dim opr_agenda As New Cls_Agenda()
    Private WithEvents dtt_PLANTTO As New DataTable("PLAN_TTO")
    Private WithEvents dtt_TTO As New DataTable("TTO")
    Private WithEvents dtt_TTO2 As New DataTable("TTO2")
    Private WithEvents dtt_SER As New DataTable("SER")
    Dim str_imprimir, str_codigo_barras As String
    Dim sw_previo As Boolean

    Dim pac As String()
    Dim noms, apes As String

    Dim arre_unidad As String()

    Dim arre_com As String()



    Private Function actualizaDtsTTO(ByVal pac_id As Integer, ByVal tipo As String) As Boolean
        Dim ser_id As Integer

        dtt_TTO.Clear()

        opr_res.LlenarGridTTO(dgv_TToPaciente, dtt_TTO, pac_id, tipo)
        If dtt_TTO.Rows.Count > 0 Then
            actualizaDtsTTO = True
        Else
            actualizaDtsTTO = False
        End If

    End Function

    Private Function actualizaDtsTTO2(ByVal pac_id As Integer, ByVal tipo As String) As Boolean
        Dim ser_id As Integer

        dtt_TTO2.Clear()

        opr_res.LlenarGridTTO2(dgv_MATPaciente, dtt_TTO2, pac_id, tipo)
        If dtt_TTO2.Rows.Count > 0 Then
            actualizaDtsTTO2 = True
        Else
            actualizaDtsTTO2 = False
        End If

    End Function


    'Private Function actualizaDtsSER(ByVal VAC_CAT) As Boolean

    '    dtt_SER.Clear()

    '    opr_res.LlenarGridSER(dgv_Series, dtt_SER, VAC_CAT)
    '    If dtt_SER.Rows.Count > 0 Then
    '        actualizaDtsSER = True
    '    Else
    '        actualizaDtsSER = False
    '    End If

    'End Function


    Private Sub frm_VacunaTratamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim opr_pedido As New Cls_Pedido()

        If ventana_tipo = 0 Then 'MEDICO -> CLIENTE

            cmb_BodegaAlmacen.Visible = True
            cmb_decimal.Visible = True
            lbl_ml.Visible = True
            cmb_decimal.SelectedIndex = 0

            cargaInfo(med_id, "CLIENTE")

            lbl_solicita.Visible = True
            cmb_medico.Visible = True
            lbl_paciente.Visible = False

            opr_medico.LlenarComboMedico(cmb_medico, "Cliente")
            cmb_medico.Text = med_nombre.PadRight(100) & CStr(med_id).PadRight(5)
            btn_CargaTtoMedico.Visible = True

            pac = Split(Trim(med_nombre), " ")

            opr_pedido.LlenarComboBodegasCliente(cmb_BodegaAlmacen)

            'btn_ImpPlan.Visible = False
            'Panel4.Visible = False
            'btn_Imp1.Visible = False
            'btn_Imp2.Visible = False
            'btn_Imp3.Visible = False
            'btn_Imp4.Visible = False
            'txt_Solicitud.Visible = True
        Else
            'PACIENTE

            cmb_BodegaAlmacen.Visible = False
            cmb_decimal.Visible = False
            lbl_ml.Visible = False

            lbl_solicita.Visible = False
            cmb_medico.Visible = False
            lbl_paciente.Visible = True

            pac = Split(Trim(lbl_paciente.Text), " ")
            cargaInfo(pac_id, "PACIENTE")

            btn_CargaTtoMedico.Visible = False
            'btn_ImpPlan.Visible = True
            'Panel4.Visible = True

            'btn_Imp1.Visible = True
            'btn_Imp2.Visible = True
            'btn_Imp3.Visible = True
            'btn_Imp4.Visible = True
            'txt_Solicitud.Visible = False
            cmb_BodegaAlmacen.Enabled = False
        End If


        

    End Sub

    Private Sub cargaInfo(ByVal pac_id As Integer, ByVal tipo As String)

        '************************************************
        '  GRID ARRIBA TRATAMIENTO MEDICO cliente
        '************************************************
        Dim dtcV_columna1 As New DataColumn("tto_fecha", GetType(System.String))
        Dim dtcV_columna2 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcV_columna3 As New DataColumn("I_PRD_DESCRIPCION", GetType(System.String))
        Dim dtcV_columna4 As New DataColumn("EDAD", GetType(System.String))
        Dim dtcV_columna5 As New DataColumn("tto_cantidad", GetType(System.Double))
        Dim dtcV_columna6 As New DataColumn("I_UNI_DESCRIPCION", GetType(System.String))
        Dim dtcV_columna7 As New DataColumn("vac_lote", GetType(System.String))
        Dim dtcV_columna10 As New DataColumn("VIA", GetType(System.String))
        Dim dtcV_columna11 As New DataColumn("COMP", GetType(System.String))
        Dim dtcV_columna12 As New DataColumn("ORIGEN", GetType(System.String))
        Dim dtcV_columna13 As New DataColumn("I_PRD_FRASCOS", GetType(System.Single))
        Dim dtcV_columna14 As New DataColumn("SER_ID", GetType(System.Single))
        Dim dtcV_columna15 As New DataColumn("I_PRD_ABREV", GetType(System.String))
        Dim dtcV_columna16 As New DataColumn("I_PRD_A_ID", GetType(System.String))

        dtt_TTO.Columns.Add(dtcV_columna1)
        dtt_TTO.Columns.Add(dtcV_columna2)
        dtt_TTO.Columns.Add(dtcV_columna3)
        dtt_TTO.Columns.Add(dtcV_columna4)
        dtt_TTO.Columns.Add(dtcV_columna5)
        dtt_TTO.Columns.Add(dtcV_columna6)
        dtt_TTO.Columns.Add(dtcV_columna7)
        dtt_TTO.Columns.Add(dtcV_columna10)
        dtt_TTO.Columns.Add(dtcV_columna11)
        dtt_TTO.Columns.Add(dtcV_columna12)
        dtt_TTO.Columns.Add(dtcV_columna13)
        dtt_TTO.Columns.Add(dtcV_columna14)
        dtt_TTO.Columns.Add(dtcV_columna15)
        dtt_TTO.Columns.Add(dtcV_columna16)

        If actualizaDtsTTO(pac_id, tipo) = True Then
            dgv_TToPaciente.Visible = True
            iniciaGridTto()
        Else
            dgv_TToPaciente.Visible = False
        End If



        '************************************************
        '  GRID ARRIBA derecha MATERIALES MEDICO CLIENTE
        '************************************************
        Dim dtcM_columna1 As New DataColumn("tto_fecha", GetType(System.String))
        Dim dtcM_columna2 As New DataColumn("I_PRD_ID", GetType(System.String))
        Dim dtcM_columna3 As New DataColumn("I_PRD_DESCRIPCION", GetType(System.String))
        Dim dtcM_columna4 As New DataColumn("EDAD", GetType(System.String))
        Dim dtcM_columna5 As New DataColumn("tto_cantidad", GetType(System.Single))
        Dim dtcM_columna6 As New DataColumn("I_UNI_DESCRIPCION", GetType(System.String))
        Dim dtcM_columna7 As New DataColumn("vac_lote", GetType(System.String))
        Dim dtcM_columna10 As New DataColumn("VIA", GetType(System.String))
        Dim dtcM_columna11 As New DataColumn("COMP", GetType(System.String))
        Dim dtcM_columna12 As New DataColumn("ORIGEN", GetType(System.String))
        Dim dtcM_columna13 As New DataColumn("I_PRD_FRASCOS", GetType(System.Single))
        Dim dtcM_columna14 As New DataColumn("SER_ID", GetType(System.Single))
        Dim dtcM_columna15 As New DataColumn("I_PRD_ABREV", GetType(System.String))

        dtt_TTO2.Columns.Add(dtcM_columna1)
        dtt_TTO2.Columns.Add(dtcM_columna2)
        dtt_TTO2.Columns.Add(dtcM_columna3)
        dtt_TTO2.Columns.Add(dtcM_columna4)
        dtt_TTO2.Columns.Add(dtcM_columna5)
        dtt_TTO2.Columns.Add(dtcM_columna6)
        dtt_TTO2.Columns.Add(dtcM_columna7)
        dtt_TTO2.Columns.Add(dtcM_columna10)
        dtt_TTO2.Columns.Add(dtcM_columna11)
        dtt_TTO2.Columns.Add(dtcM_columna12)
        dtt_TTO2.Columns.Add(dtcM_columna13)
        dtt_TTO2.Columns.Add(dtcM_columna14)
        dtt_TTO2.Columns.Add(dtcM_columna15)


        If actualizaDtsTTO2(pac_id, tipo) = True Then
            dgv_MATPaciente.Visible = True
            iniciaGridTto2()
        Else
            dgv_MATPaciente.Visible = False
        End If



        '****************************************
        '  GRID ABAJO VACUNAS DISPONIBLES   BODEGA 1
        '****************************************

        Dgrd_Vacunas.DataSource = dtv_Vacunas
        opr_pedido.LlenarGridVacunas("B01", dtv_Vacunas)


        '****************************************
        '  GRID ABAJO DERECHA MATERIALES DISPONIBLES  BODEGA 8
        '****************************************
        dgrd_materiales.DataSource = dtv_Materiales
        opr_pedido.LlenarGridMateriales("B08", dtv_Materiales)
        txt_BuscaVacuna.Focus()

        sw_previo = False
        swEntra = True
    End Sub


    Private Sub iniciaGridTto()
        dgv_TToPaciente.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_TToPaciente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_TToPaciente.Columns("tto_fecha").HeaderText = "FECHA"
        dgv_TToPaciente.Columns("tto_fecha").Width = 70

        dgv_TToPaciente.Columns("I_PRD_ABREV").HeaderText = "CODIGO"
        dgv_TToPaciente.Columns("I_PRD_ABREV").Width = 80

        dgv_TToPaciente.Columns("I_PRD_DESCRIPCION").HeaderText = "DESCRIPCION"
        dgv_TToPaciente.Columns("I_PRD_DESCRIPCION").Width = 150

        dgv_TToPaciente.Columns("EDAD").HeaderText = "EDAD"
        dgv_TToPaciente.Columns("EDAD").Visible = False

        dgv_TToPaciente.Columns("tto_cantidad").HeaderText = "CANT"
        dgv_TToPaciente.Columns("tto_cantidad").Width = 40

        dgv_TToPaciente.Columns("I_UNI_DESCRIPCION").HeaderText = "UNIDAD"
        dgv_TToPaciente.Columns("I_UNI_DESCRIPCION").Visible = False

        dgv_TToPaciente.Columns("vac_lote").HeaderText = "LOTE"
        dgv_TToPaciente.Columns("vac_lote").Width = 60

        dgv_TToPaciente.Columns("VIA").HeaderText = "VIA"
        dgv_TToPaciente.Columns("VIA").Visible = False

        dgv_TToPaciente.Columns("COMP").HeaderText = "COMP"
        dgv_TToPaciente.Columns("COMP").Visible = False

        dgv_TToPaciente.Columns("ORIGEN").HeaderText = "ORIGEN"
        dgv_TToPaciente.Columns("ORIGEN").Visible = False

        dgv_TToPaciente.Columns("I_PRD_FRASCOS").HeaderText = "FCOS"
        dgv_TToPaciente.Columns("I_PRD_FRASCOS").Visible = False

        dgv_TToPaciente.Columns("SER_ID").HeaderText = "SER"
        dgv_TToPaciente.Columns("SER_ID").Visible = False

        dgv_TToPaciente.Columns("I_PRD_ID").HeaderText = "ID"
        dgv_TToPaciente.Columns("I_PRD_ID").Visible = False

        dgv_TToPaciente.Columns("I_PRD_A_ID").HeaderText = "AREA"
        dgv_TToPaciente.Columns("I_PRD_A_ID").Visible = False

        With dgv_TToPaciente
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

    End Sub

    Private Sub iniciaGridTto2()
        dgv_MATPaciente.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_MATPaciente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_MATPaciente.Columns("tto_fecha").HeaderText = "FECHA"
        dgv_MATPaciente.Columns("tto_fecha").Width = 70

        dgv_MATPaciente.Columns("I_PRD_ABREV").HeaderText = "CODIGO"
        dgv_MATPaciente.Columns("I_PRD_ABREV").Width = 80

        dgv_MATPaciente.Columns("I_PRD_DESCRIPCION").HeaderText = "DESCRIPCION"
        dgv_MATPaciente.Columns("I_PRD_DESCRIPCION").Width = 110

        dgv_MATPaciente.Columns("EDAD").HeaderText = "EDAD"
        dgv_MATPaciente.Columns("EDAD").Visible = False

        dgv_MATPaciente.Columns("tto_cantidad").HeaderText = "CANT"
        dgv_MATPaciente.Columns("tto_cantidad").Width = 40

        dgv_MATPaciente.Columns("I_UNI_DESCRIPCION").HeaderText = "UNIDAD"
        dgv_MATPaciente.Columns("I_UNI_DESCRIPCION").Visible = False

        dgv_MATPaciente.Columns("vac_lote").HeaderText = "LOTE"
        dgv_MATPaciente.Columns("vac_lote").Width = 60

        dgv_MATPaciente.Columns("VIA").HeaderText = "VIA"
        dgv_MATPaciente.Columns("VIA").Visible = False

        dgv_MATPaciente.Columns("COMP").HeaderText = "COMP"
        dgv_MATPaciente.Columns("COMP").Visible = False

        dgv_MATPaciente.Columns("ORIGEN").HeaderText = "ORIGEN"
        dgv_MATPaciente.Columns("ORIGEN").Visible = False

        dgv_MATPaciente.Columns("I_PRD_FRASCOS").HeaderText = "FCOS"
        dgv_MATPaciente.Columns("I_PRD_FRASCOS").Visible = False

        dgv_MATPaciente.Columns("SER_ID").HeaderText = "SER"
        dgv_MATPaciente.Columns("SER_ID").Visible = False

        dgv_MATPaciente.Columns("I_PRD_ID").HeaderText = "ABREV"
        dgv_MATPaciente.Columns("I_PRD_ID").Visible = False

        With dgv_MATPaciente
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

    End Sub
    Private Sub txt_BuscaVacuna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BuscaVacuna.TextChanged

        If txt_BuscaVacuna.Text <> "" Then
            opr_res.ordena_vacuna(Trim(txt_BuscaVacuna.Text), dtv_Vacunas)
        Else
            dtv_Vacunas.RowFilter = ""
        End If
    End Sub


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Dim dbl_cantidad As Double
        Dim opr_movimiento As New Cls_i_Movimiento()
        Dim STR_PRD_CAD, STR_PRD_STOCK, STR_MSG As String
        'Dim boo_opera As Boolean = False
        Dim boo_modDetalle As Boolean = False
        Dim MOV_ID, mov_estado As Integer
        Dim REF_MOV As String
        Dim dtt_detmov As New DataTable()

        Select Case ventana_tipo

            Case 0 'CLIENTE MEDICO
                If opr_pedido.GestionaTTO(Age_id, med_id, pac_id, Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1), CDbl(cmb_Cantidad.Text), Format(Now(), "dd/MM/yyyy"), Trim(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10), CDbl(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 11)), "Insert", ventana_tipo, "") = True Then
                    dbl_cantidad = opr_movimiento.ProductoBodega(Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5), CDbl(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10)), 0)
                    If dbl_cantidad < 0 Then
                        STR_PRD_STOCK = Chr(13) & Space(10) & " * " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1) & "  " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 2) & STR_PRD_STOCK
                    End If

                    If opr_movimiento.ProductoCaducado(Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1)) = True Then
                        STR_PRD_CAD = Chr(13) & Space(10) & " * " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1) & "  " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 2) & STR_PRD_CAD
                    End If

                    If STR_PRD_STOCK <> "" And Me.Tag = 1 Then
                        opr_pedido.VisualizaMensaje("La cantidad solicitada es mayor al stock disponible," & Chr(13) & "favor revice la cantidad del PRODUCTO: " & STR_PRD_STOCK & "Operacion Interrumpida", g_tiempo)
                        Exit Sub
                    End If


                    ' Agrega las columnas con sus respectivos nombres y tipos de datos
                    dtt_detmov.Columns.Add("MOV_ID", GetType(Integer))
                    dtt_detmov.Columns.Add("MOV_PROD", GetType(String))
                    dtt_detmov.Columns.Add("MOV_BODEGA", GetType(String))
                    dtt_detmov.Columns.Add("MOV_LOTE", GetType(String))
                    dtt_detmov.Columns.Add("MOV_OBS", GetType(String))
                    dtt_detmov.Columns.Add("MOV_CANTIDAD", GetType(Double))
                    dtt_detmov.Columns.Add("MOV_COSTO", GetType(Decimal))
                    'dtt_detmov.Columns.Add("MOV_FCVCTO", GetType(String))
                    dtt_detmov.Columns.Add("MOV_POST", GetType(String))
                    dtt_detmov.Columns.Add("MOV_CANTAUX", GetType(Integer))
                    dtt_detmov.Columns.Add("MOV_UNIDAD", GetType(String))
                    dtt_detmov.Columns.Add("sum_cantidad", GetType(Integer))
                    dtt_detmov.Columns.Add("I_MOV_FSCO1", GetType(String))
                    dtt_detmov.Columns.Add("I_MOV_FSCO2", GetType(String))
                    dtt_detmov.Columns.Add("I_MOV_FSCO3", GetType(String))

                    Dim fila1 As DataRow = dtt_detmov.NewRow()
                    fila1("MOV_ID") = 0
                    fila1("MOV_PROD") = Trim(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1))
                    fila1("MOV_BODEGA") = Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10))
                    fila1("MOV_LOTE") = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)
                    fila1("MOV_OBS") = "EGRESO MEDICO"
                    fila1("MOV_CANTIDAD") = CDbl(cmb_Cantidad.Text)
                    fila1("MOV_COSTO") = CDec(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10))
                    'fila1("MOV_FCVCTO") = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)
                    fila1("MOV_POST") = ""
                    fila1("MOV_CANTAUX") = 0
                    fila1("MOV_UNIDAD") = "SERIE"
                    fila1("sum_cantidad") = dbl_cantidad
                    fila1("I_MOV_FSCO1") = "Si"
                    fila1("I_MOV_FSCO2") = "Si"
                    fila1("I_MOV_FSCO3") = "Si"
                    dtt_detmov.Rows.Add(fila1)

                    'GUARDA MOVIMIENTO DE EGRESO
                    Dim ClientePac As String
                    If ventana_tipo = 0 Then
                        ClientePac = "CLIENTE"
                    Else
                        ClientePac = "PACIENTE"
                    End If
                    If opr_movimiento.OperaMovimiento(True, Format(Now, "yyyy-MM-dd hh:mm"), Format(Now, "yyyy-MM-dd hh:mm"), Age_id, "LABALERGIA", "EGR             Egresos                   EGRESO    ", "LABALERGIA", dtt_detmov, Age_resumen & "-" & Trim(lbl_paciente.Text), Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), MOV_ID, True, REF_MOV, 1) = 1 Then

                        Select Case ventana_tipo
                            ''CLIENTE MEDICO
                            Case 0
                                If Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)) = "B01" Then
                                    Dgrd_Vacunas.DataSource = dtv_Vacunas
                                    opr_pedido.LlenarGridVacunas("B01", dtv_Vacunas)
                                Else
                                    Dgrd_Vacunas.DataSource = dtv_Vacunas
                                    opr_pedido.LlenarGridVacunas("B08", dtv_Vacunas)
                                End If

                                If actualizaDtsTTO(med_id, "CLIENTE") = True Then
                                    dgv_TToPaciente.Visible = True
                                    iniciaGridTto()
                                End If


                                ''PACIENTE
                            Case 1

                        End Select

                        opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
                    End If

                Else
                    opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
                End If

            Case 1 'PACIENTE
                If opr_pedido.GestionaTTO(Age_id, med_id, pac_id, Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1), CDbl(cmb_Cantidad.Text), Format(Now(), "dd/MM/yyyy"), Trim(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 11), "Insert", ventana_tipo, "") = True Then
                    dbl_cantidad = opr_movimiento.ProductoBodega("B01", Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5), CDbl(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10)), 0)
                    If dbl_cantidad < 0 Then
                        STR_PRD_STOCK = Chr(13) & Space(10) & " * " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1) & "  " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10) & STR_PRD_STOCK
                    End If

                    If opr_movimiento.ProductoCaducado("B01", Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1)) = True Then
                        STR_PRD_CAD = Chr(13) & Space(10) & " * " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1) & "  " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10) & STR_PRD_CAD
                    End If

                    If STR_PRD_STOCK <> "" And Me.Tag = 1 Then
                        opr_pedido.VisualizaMensaje("La cantidad solicitada es mayor al stock disponible," & Chr(13) & "favor revice la cantidad del PRODUCTO: " & STR_PRD_STOCK & "Operacion Interrumpida", g_tiempo)
                        Exit Sub
                    End If


                    ' Agrega las columnas con sus respectivos nombres y tipos de datos
                    dtt_detmov.Columns.Add("MOV_ID", GetType(Integer))
                    dtt_detmov.Columns.Add("MOV_PROD", GetType(String))
                    dtt_detmov.Columns.Add("MOV_BODEGA", GetType(String))
                    dtt_detmov.Columns.Add("MOV_LOTE", GetType(String))
                    dtt_detmov.Columns.Add("MOV_OBS", GetType(String))
                    dtt_detmov.Columns.Add("MOV_CANTIDAD", GetType(Double))
                    dtt_detmov.Columns.Add("MOV_COSTO", GetType(Decimal))
                    'dtt_detmov.Columns.Add("MOV_FCVCTO", GetType(String))
                    dtt_detmov.Columns.Add("MOV_POST", GetType(String))
                    dtt_detmov.Columns.Add("MOV_CANTAUX", GetType(Integer))
                    dtt_detmov.Columns.Add("MOV_UNIDAD", GetType(String))
                    dtt_detmov.Columns.Add("sum_cantidad", GetType(Integer))
                    dtt_detmov.Columns.Add("I_MOV_FSCO1", GetType(String))
                    dtt_detmov.Columns.Add("I_MOV_FSCO2", GetType(String))
                    dtt_detmov.Columns.Add("I_MOV_FSCO3", GetType(String))

                    Dim fila1 As DataRow = dtt_detmov.NewRow()
                    fila1("MOV_ID") = 0
                    fila1("MOV_PROD") = Trim(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1))
                    fila1("MOV_BODEGA") = "B01"
                    fila1("MOV_LOTE") = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)
                    fila1("MOV_OBS") = "EGRESO PACIENTE"
                    fila1("MOV_CANTIDAD") = CDbl(cmb_Cantidad.Text)
                    fila1("MOV_COSTO") = CDec(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 10))
                    'fila1("MOV_FCVCTO") = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)
                    fila1("MOV_POST") = ""
                    fila1("MOV_CANTAUX") = 0
                    fila1("MOV_UNIDAD") = "SERIE"
                    fila1("sum_cantidad") = dbl_cantidad
                    fila1("I_MOV_FSCO1") = "Si"
                    fila1("I_MOV_FSCO2") = "Si"
                    fila1("I_MOV_FSCO3") = "Si"
                    dtt_detmov.Rows.Add(fila1)

                    'GUARDA MOVIMIENTO DE EGRESO
                    Dim ClientePac As String
                    If Age_resumen = "DESPACHO CLIENTE" Then
                        ClientePac = "CLIENTE"
                    Else
                        ClientePac = "PACIENTE"
                    End If
                    If opr_movimiento.OperaMovimiento(True, Format(Now, "yyyy-MM-dd hh:mm"), Format(Now, "yyyy-MM-dd hh:mm"), Age_id, "LABALERGIA", "EGR             Egresos                   EGRESO    ", "LABALERGIA", dtt_detmov, Age_resumen & "-" & Trim(lbl_paciente.Text), "B01", MOV_ID, True, REF_MOV, 1) = 1 Then

                        If actualizaDtsTTO(pac_id, "PACIENTE") = True Then
                            dgv_TToPaciente.Visible = True
                            iniciaGridTto()
                        Else
                            dgv_TToPaciente.Visible = False
                        End If

                        Dgrd_Vacunas.DataSource = dtv_Vacunas
                        opr_pedido.LlenarGridVacunas("B01", dtv_Vacunas)

                        opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
                    End If

                Else
                    opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
                End If


        End Select
    End Sub

    

    Sub ImprimirCB_PAC()

        'mando a copiar el archivo generado en el puerto designado
        Dim str_var As String = "Recepcion"
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
        End If

        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
        Dim var_linea = "........................."
        Dim str_cadena As String
        Dim i As Integer

        '************************************
        ' ETIQUETA PACIENTE
        '************************************
        If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
            Dim imp_archivo As FileStream = File.Create(str_imprimir)
            imp_archivo.Close()
        End If
        'abro un archivo para generar as lineas que me permitira imprimir un codigo de barras
        FileOpen(1, str_imprimir, OpenMode.Output)

        'linea obligatoria
        PrintLine(1, "")
        PrintLine(1, "N")
        'reseteo la impresora
        PrintLine(1, "OD")

        'tamaño horizontal
        PrintLine(1, "q450") ' 
        'tamaño vertical
        PrintLine(1, "Q150,30+0")

        'estas tres lineas son obligatorias son seteos de la impresora
        PrintLine(1, "S2") 'S= velocidad
        PrintLine(1, "D8")  'D = Densidad
        PrintLine(1, "ZT")  'Z = OrientaciOn de la impresiOn, T = desde el tope.


        'FECHA DEL PEDIDO LETRA PEQUEÑA
        '''PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")

        str_cadena = "LABALERGIA Quito - Ecuador"
        PrintLine(1, "A70,10,0,2,1,1,N," & """" & str_cadena.ToString & """")


        str_cadena = "ORDEN: " & turno
        PrintLine(1, "A90,30,0,2,1,1,N," & """" & str_cadena.ToString & """")

        'PACIENTE
        'Dim pac As String() = Split(Trim(lbl_paciente.Text), " ")
        'Dim noms, apes As String

        Select Case UBound(pac) + 1
            Case 5
                apes = pac(0) & " " & pac(1)
                noms = pac(2) & " " & pac(3)
            Case 4
                apes = pac(0) & " " & pac(1)
                noms = pac(2) & " " & pac(3)
            Case 3
                apes = pac(0) & " " & pac(1)
                noms = pac(2)
            Case 2
                apes = pac(0)
                noms = pac(2)
        End Select

        str_cadena = apes
        PrintLine(1, "A90,50,0,2,1,1,N," & """" & str_cadena.ToString & """")

        str_cadena = noms
        PrintLine(1, "A90,70,0,2,1,1,N," & """" & str_cadena.ToString & """")

        str_cadena = "FECHA: " & Mid(dgv_TToPaciente.CurrentRow.Cells("tto_fecha").Value(), 1, 10)
        PrintLine(1, "A90,90,0,2,1,1,N," & """" & str_cadena.ToString & """")


        PrintLine(1, "P1")

        'estas lineas son necesario para que la imrpesora regrese a su estado natura
        PrintLine(1, "")
        PrintLine(1, "OD")
        PrintLine(1, "q450")
        PrintLine(1, "Q150,40+0")
        PrintLine(1, "S2")
        PrintLine(1, "D8")
        PrintLine(1, "ZT")
        FileClose(1)

        On Error Resume Next
        FileCopy(str_imprimir, str_var)


    End Sub

    Sub ImprimirCB1()

        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'mando a copiar el archivo generado en el puerto designado
        Dim str_var As String = "Recepcion"
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
        End If

        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
        Dim var_linea = "........................."
        Dim str_cadena As String
        Dim i As Integer

        '************************************
        ' 1ra ETIQUETA GRANDE - 
        '************************************
        If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
            Dim imp_archivo As FileStream = File.Create(str_imprimir)
            imp_archivo.Close()
        End If
        'abro un archivo para generar as lineas que me permitira imprimir un codigo de barras
        FileOpen(1, str_imprimir, OpenMode.Output)

        'linea obligatoria
        PrintLine(1, "")
        PrintLine(1, "N")

        'reseteo la impresora
        PrintLine(1, "OD")


        'tamaño horizontal
        PrintLine(1, "q590") ' 

        'tamaño vertical
        PrintLine(1, "Q390,30+0")

        'estas tres lineas son obligatorias son seteos de la impresora
        PrintLine(1, "S2") 'S= velocidad
        PrintLine(1, "D8")  'D = Densidad
        PrintLine(1, "ZT")  'Z = OrientaciOn de la impresiOn, T = desde el tope.


        'FECHA DEL PEDIDO LETRA PEQUEÑA
        '''PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")

        'mando a escrribir en letras normales el primer 1 en la cadena de parametros de el tamaño del encabezado
        str_cadena = "COMPOSICION"
        PrintLine(1, "A230,5,0,2,1,1,N," & """" & str_cadena & """")
        
        PrintLine(1, "A90,20,0,2,1,1,N," & """" & lbl_1Comp.Text & """")
        PrintLine(1, "A220,40,0,2,1,1,N," & """" & Trim(lbl_1ViaAdmin.Text).ToUpper & """")

        'INFO
        str_cadena = "Conservese en refrigeracion a"
        PrintLine(1, "A120,80,0,2,1,1,N," & """" & str_cadena.ToString & """")

        str_cadena = "temperarura de 2-8 ºC"
        PrintLine(1, "A150,95,0,2,1,1,N," & """" & str_cadena.ToString & """")

        str_cadena = "Venta bajo receta medica"
        PrintLine(1, "A140,110,0,2,1,1,N," & """" & str_cadena.ToString & """")

        str_cadena = "Producto de uso delicado mantengase"
        PrintLine(1, "A100,130,0,2,1,1,N," & """" & str_cadena.ToString & """")

        str_cadena = "fuera de alcance de los ninos"
        PrintLine(1, "A125,145,0,2,1,1,N," & """" & str_cadena.ToString & """")

        'FABRICANTE
        str_cadena = Trim("LABALERGIA Quito-Ecuador")
        PrintLine(1, "A150,180,0,2,1,1,N," & """" & str_cadena.ToString & """")

        str_cadena = Trim("B.Q.F.R. Ximena Cevallos")
        PrintLine(1, "A150,200,0,2,1,1,N," & """" & str_cadena.ToString & """")


        'LOTE
        str_cadena = Trim(lbl_1Lote.Text)
        PrintLine(1, "A120,240,0,2,1,1,N," & """" & str_cadena.ToString & """")

        'FECHA ELAB
        str_cadena = Trim(lbl_1FecElab.Text)
        PrintLine(1, "A120,260,0,2,1,1,N," & """" & str_cadena.ToString & """")

        'FECHA VENCE
        str_cadena = Trim(lbl_1FecVen.Text)
        PrintLine(1, "A120,280,0,2,1,1,N," & """" & str_cadena.ToString & """")


        PrintLine(1, "P1")

        'estas lineas son necesario para que la imrpesora regrese a su estado natura
        PrintLine(1, "")
        PrintLine(1, "OD")
        PrintLine(1, "q590")
        PrintLine(1, "Q390,30+0")
        PrintLine(1, "S2")
        PrintLine(1, "D8")
        PrintLine(1, "ZT")
        FileClose(1)


        On Error Resume Next
        FileCopy(str_imprimir, str_var)


    End Sub

    

    Sub ImprimirCB2()

        'mando a copiar el archivo generado en el puerto designado
        Dim str_var As String = "Recepcion"
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
        End If

        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
        Dim var_linea = "........................."
        Dim str_cadena As String
        Dim i As Integer


        'abro un archivo para generar as lineas que me permitira imprimir un codigo de barras
        FileOpen(1, str_imprimir, OpenMode.Output)

        'linea obligatoria
        PrintLine(1, "")
        PrintLine(1, "N")
        'reseteo la impresora
        PrintLine(1, "OD")

        'tamaño horizontal
        PrintLine(1, "q440") ' 

        'tamaño vertical
        PrintLine(1, "Q150,30+0")

        'estas tres lineas son obligatorias son seteos de la impresora
        PrintLine(1, "S2") 'S= velocidad
        PrintLine(1, "D8")  'D = Densidad
        PrintLine(1, "ZT")  'Z = OrientaciOn de la impresiOn, T = desde el tope.

        'mando a escrribir en letras normales el primer 1 en la cadena de parametros de el tamaño del encabezado
        str_cadena = Trim(lbl_encabezado.Text)
        PrintLine(1, "A75,10,0,2,1,1,N," & """" & str_cadena & """")

        'PrintLine(1, "A10,40,0,1,2,1,N," & """" & var_linea & """")



        str_cadena = Trim(dgv_TToPaciente.CurrentRow.Cells("I_PRD_ID").Value).ToUpper & " " & Trim(dgv_TToPaciente.CurrentRow.Cells("I_PRD_DESCRIPCION").Value)
        PrintLine(1, "A80,40,0,2,1,1,N," & """" & str_cadena.ToString & """")

        'SOLUCIONES
        str_cadena = dgv_TToPaciente.CurrentRow.Cells("TTO_SOLUCIONES").Value
        PrintLine(1, "A80,60,0,2,1,1,N," & """" & str_cadena.ToString & """")

        'FRASCOS
        str_cadena = dgv_TToPaciente.CurrentRow.Cells("tto_cantidad").Value & " FRASCOS"
        PrintLine(1, "A80,80,0,2,1,1,N," & """" & str_cadena.ToString & """")


        '''''''UNIDAD ml
        str_cadena = dgv_TToPaciente.CurrentRow.Cells("TTO_CONTENIDO").Value
        PrintLine(1, "A80,100,0,2,1,1,N," & """" & str_cadena.ToString & """")

        PrintLine(1, "P1")

        'estas lineas son necesario para que la imrpesora regrese a su estado natura
        PrintLine(1, "")
        PrintLine(1, "OD")
        PrintLine(1, "q440")
        PrintLine(1, "Q150,30+0")
        PrintLine(1, "S2")
        PrintLine(1, "D8")
        PrintLine(1, "ZT")
        FileClose(1)
        On Error Resume Next
        FileCopy(str_imprimir, str_var)

    End Sub

    Sub ImprimirEtiquetas()
        '************************************************
        ' OTRAS ETIQUETAS PARA FRASCOS
        '************************************************
        'mando a copiar el archivo generado en el puerto designado
        Dim str_var As String = "Recepcion"
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
        End If

        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
        Dim var_linea = "........................."
        Dim str_cadena As String
        Dim i As Integer


        For i = 0 To CInt(dgv_TToPaciente.CurrentRow.Cells("tto_cantidad").Value) - 1

            'abro un archivo para generar as lineas que me permitira imprimir un codigo de barras
            FileOpen(1, str_imprimir, OpenMode.Output)

            'linea obligatoria
            PrintLine(1, "")
            PrintLine(1, "N")
            'reseteo la impresora
            PrintLine(1, "OD")

            'tamaño horizontal
            PrintLine(1, "q450") ' 
            'tamaño vertical
            PrintLine(1, "Q150,30+0")

            'TTO ANTIALERGICO'
            str_cadena = Trim("TRATAMIENTO ANTIALERGICO")
            PrintLine(1, "A75,10,0,2,1,1,N," & """" & str_cadena.ToString & """")


            'FRASCO No
            str_cadena = "FCO " & i + 1 & " " & Trim(dgv_TToPaciente.CurrentRow.Cells("I_PRD_ID").Value).ToUpper & " " & Trim(dgv_TToPaciente.CurrentRow.Cells("I_PRD_DESCRIPCION").Value)
            PrintLine(1, "A70,30,0,1,1,1,N," & """" & str_cadena.ToString & """")

            str_cadena = Trim(lbl_1ViaAdmin.Text).ToUpper() & " CONTENIDO: " & Trim(arre_unidad(i))
            PrintLine(1, "A70,50,0,1,1,1,N," & """" & str_cadena.ToString & """")

            'COMPOSICION
            

            Select Case UBound(arre_com) + 1
                Case 4
                    str_cadena = Trim(arre_com(0)) & ", " & Trim(arre_com(1))
                    PrintLine(1, "A80,68,0,1,1,1,N," & """" & str_cadena.ToString & """")

                    str_cadena = Trim(arre_com(2)) & ", " & Trim(arre_com(4))
                    PrintLine(1, "A80,82,0,1,1,1,N," & """" & str_cadena.ToString & """")

                Case 3
                    str_cadena = Trim(arre_com(0)) & ", " & Trim(arre_com(1))
                    PrintLine(1, "A80,68,0,1,1,1,N," & """" & str_cadena.ToString & """")

                    str_cadena = Trim(arre_com(2))
                    PrintLine(1, "A80,82,0,1,1,1,N," & """" & str_cadena.ToString & """")

                Case 2
                    str_cadena = Trim(arre_com(0)) & ", " & Trim(arre_com(1))
                    PrintLine(1, "A80,68,0,1,1,1,N," & """" & str_cadena.ToString & """")

            End Select


            str_cadena = Trim(lbl_1Lote.Text) & " " & Trim(lbl_1FecVen.Text)
            PrintLine(1, "A70,100,0,1,1,1,N," & """" & str_cadena.ToString & """")


            ''LAB ALERGIA
            str_cadena = "LABALERGIA Quito - Ecuador"
            PrintLine(1, "A70,120,0,1,1,1,N," & """" & str_cadena.ToString & """")

            PrintLine(1, "P1")

            'estas lineas son necesario para que la imrpesora regrese a su estado natura
            PrintLine(1, "")
            PrintLine(1, "OD")
            PrintLine(1, "q456")
            PrintLine(1, "Q199,40+0")
            PrintLine(1, "S2")
            PrintLine(1, "D8")
            PrintLine(1, "ZT")
            FileClose(1)

            On Error Resume Next
            FileCopy(str_imprimir, str_var)
        Next


        Me.Cursor = System.Windows.Forms.Cursors.Default


        Exit Sub
errores:
        MsgBox("Error al imprimir, revise la impresora " & Err.Description & Err.Number, MsgBoxStyle.Exclamation, "ANALISYS")
    End Sub



    Sub EtiquetasPanel()
        Dim i As Integer
        Dim topPnl As Integer = 10
        pnl.Controls.Clear()
        'dgrd_muestra.Item(i, 22)

        For i = 0 To CInt(arre_unidad.Length() - 1)
            Dim pnl_cb As New Panel()
            Dim lbl_CBtto As New Label()
            Dim lbl_CBtipo As New Label()
            Dim lbl_CBsoluciones As New Label()
            Dim lbl_CBfrascos As New Label()
            Dim lbl_CBcantidad As New Label()
            'Dim lbl_eda As New Label()
            'Dim lbl_recip As New Label()

            pnl_cb.Height = 60
            pnl_cb.Width = 180
            pnl_cb.Left = 10
            pnl_cb.Top = topPnl
            pnl_cb.BackColor = Color.White
            topPnl = topPnl + pnl_cb.Height + 5

            Dim MyFont As New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Pixel)

            lbl_CBtto.BorderStyle = BorderStyle.FixedSingle
            lbl_CBtto.TextAlign = ContentAlignment.MiddleCenter
            lbl_CBtto.Text = lbl_encabezado.Text
            lbl_CBtto.Height = 10
            lbl_CBtto.Width = 180
            lbl_CBtto.Left = 0
            lbl_CBtto.Top = 0
            lbl_CBtto.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            'lbl_paciente.BorderStyle = BorderStyle.FixedSingle
            lbl_CBtipo.TextAlign = ContentAlignment.MiddleLeft
            lbl_CBtipo.Text = "FCO " & i + 1 & " " & Trim(dgv_TToPaciente.CurrentRow.Cells("I_PRD_ID").Value).ToUpper & " " & Trim(dgv_TToPaciente.CurrentRow.Cells("I_PRD_DESCRIPCION").Value)
            lbl_CBtipo.Height = 10
            lbl_CBtipo.Width = 180
            lbl_CBtipo.Left = 5
            lbl_CBtipo.Top = 25
            lbl_CBtipo.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            'Dim MyFontCB As New Font("C39HrP24DhTt", 40, FontStyle.Regular, GraphicsUnit.Pixel)
            'lbl_codigo.BorderStyle = BorderStyle.FixedSingle
            lbl_CBsoluciones.TextAlign = ContentAlignment.MiddleLeft
            lbl_CBsoluciones.Text = Trim(dgv_TToPaciente.CurrentRow.Cells("VIA").Value).ToUpper() & " CONTENIDO: " & Trim(arre_unidad(i))
            lbl_CBsoluciones.Height = 10
            lbl_CBsoluciones.Width = 180
            lbl_CBsoluciones.Left = 5
            lbl_CBsoluciones.Top = 40
            lbl_CBsoluciones.Font = MyFont
            pnl.Controls.Add(pnl_cb)


            'lbl_fecha.BorderStyle = BorderStyle.FixedSingle
            lbl_CBfrascos.TextAlign = ContentAlignment.MiddleLeft
            lbl_CBfrascos.Text = dgv_TToPaciente.CurrentRow.Cells("tto_cantidad").Value
            lbl_CBfrascos.Height = 10
            lbl_CBfrascos.Width = 180
            lbl_CBfrascos.Left = 5
            lbl_CBfrascos.Top = 55
            lbl_CBfrascos.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            'lbl_cedula.BorderStyle = BorderStyle.FixedSingle
            lbl_CBcantidad.TextAlign = ContentAlignment.MiddleLeft
            lbl_CBcantidad.Text = lbl_UnidadFrascos.Text
            lbl_CBcantidad.Height = 102
            lbl_CBcantidad.Width = 80
            lbl_CBcantidad.Left = 5
            lbl_CBcantidad.Top = 70
            lbl_CBcantidad.Font = MyFont
            pnl.Controls.Add(pnl_cb)

            'PANEL MAESTRO
            pnl_cb.Controls.Add(lbl_CBtto)
            pnl_cb.Controls.Add(lbl_CBtipo)
            pnl_cb.Controls.Add(lbl_CBsoluciones)
            pnl_cb.Controls.Add(lbl_CBfrascos)
            pnl_cb.Controls.Add(lbl_CBcantidad)
        Next
    End Sub

    Private Sub limpia()
        lbl_Soluciones.Text = ""
        lbl_Frascos.Text = ""
        lbl_UnidadFrascos.Text = ""
        lbl_Serie.Text = ""
        lbl_1Comp.Text = ""
        lbl_1ViaAdmin.Text = ""
        lbl_1Info.Text = ""
        lbl_1Fabricante.Text = ""
        lbl_1Lote.Text = ""
        lbl_1FecElab.Text = ""
        lbl_1FecVen.Text = ""
    End Sub





    Private Sub Dgrd_Vacunas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ver_gridSeries()
        ver_serie()
    End Sub

    Private Sub Dgrd_Vacunas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ver_gridSeries()
        ver_serie()
    End Sub

    Private Sub ver_gridSeries()

        'actualizaDtsSER(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1))

    End Sub

    Private Sub ver_etiquetas()


        lbl_1Comp.Text = opr_res.ConsultaComposicion(dgv_TToPaciente.CurrentRow.Cells("SER_ID").Value())
        lbl_1ViaAdmin.Text = dgv_TToPaciente.CurrentRow.Cells("VIA").Value()

        lbl_1Info.Text = "Consérvese en refrigeración a temperarura de 2-8 ºC" & vbCrLf & _
                          "Venta bajo receta médica" & vbCrLf & _
                          "Producto de uso delicado mantengase fuera de alcance de los niños."

        lbl_1Fabricante.Text = dgv_TToPaciente.CurrentRow.Cells("ORIGEN").Value() & vbCrLf & "B.Q.F.R. Ximena Cevallos"
        lbl_1Lote.Text = dgv_TToPaciente.CurrentRow.Cells("VAC_LOTE").Value()
        'lbl_1FecElab.Text = "Elab: " & Trim(Mid(dgv_TToPaciente.CurrentRow.Cells("FEC_ELAB").Value(), 1, 10))
        'lbl_1FecVen.Text = "Venc: " & Trim(Mid(dgv_TToPaciente.CurrentRow.Cells("FEC_VENC").Value(), 1, 10))

        
        'ETIQUETAS 2
        lbl_Orden.Text = turno

        'PACIENTE
        arre_com = Split(Trim(lbl_paciente.Text), " ")

        Select Case UBound(pac) + 1
            Case 5
                apes = pac(0) & " " & pac(1)
                noms = pac(2) & " " & pac(3)
            Case 4
                apes = pac(0) & " " & pac(1)
                noms = pac(2) & " " & pac(3)
            Case 3
                apes = pac(0) & " " & pac(1)
                noms = pac(2)
            Case 2
                apes = pac(0)
                noms = pac(1)
        End Select

        lbl_PacienteApellidos.Text = apes
        lbl_PacienteNombres.Text = noms


        lbl_Fecha.Text = dgv_TToPaciente.CurrentRow.Cells("TTO_FECHA").Value


        'ETIQUETA 3

        lbl_Serie.Text = dgv_TToPaciente.CurrentRow.Cells("I_PRD_ID").Value() & " " & dgv_TToPaciente.CurrentRow.Cells("I_PRD_DESCRIPCION").Value()

        arre_unidad = Split(lbl_UnidadFrascos.Text, "/")

        lbl_Frascos.Text = CStr(arre_unidad.Length()) & " FRASCOS"
        'lbl_UnidadFrascos.Text = Trim(dgv_TToPaciente.CurrentRow.Cells("TTO_CONTENIDO").Value)





        'arre_com = Split(comp, "|")


        Call EtiquetasPanel()
    End Sub

    Private Sub ver_serie()
        'ETIQUETA 1

        lbl_1Comp.Text = opr_pedido.LeerComposicion(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1)) 'SER_ID
        'lbl_1ViaAdmin.Text = opr_pedido.LeerTecnica(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 9))
        lbl_1ViaAdmin.Text = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 9)

        lbl_1Info.Text = "Consérvese en refrigeración a temperarura de 2-8 ºC" & vbCrLf & _
                          "Venta bajo receta médica" & vbCrLf & _
                          "Producto de uso delicado mantengase fuera de alcance de los niños."

        'Dim DatosVac As String()


        lbl_1Fabricante.Text = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 8) & vbCrLf & "B.Q.F.R. Ximena Cevallos"
        lbl_1Lote.Text = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 4)
        lbl_1FecElab.Text = "Elab: " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)
        lbl_1FecVen.Text = "Venc: " & opr_pedido.LeerDatosVac(Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 0), Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 4))

        'lbl_PacienteApellido.Text = lbl_paciente.Text



        'ETIQUETAS 2
        lbl_Orden.Text = turno

        'PACIENTE
        arre_com = Split(Trim(lbl_paciente.Text), " ")


        Select Case UBound(pac) + 1
            Case 5
                apes = pac(0) & " " & pac(1)
                noms = pac(2) & " " & pac(3)
            Case 4
                apes = pac(0) & " " & pac(1)
                noms = pac(2) & " " & pac(3)
            Case 3
                apes = pac(0) & " " & pac(1)
                noms = pac(2)
            Case 2
                apes = pac(0)
                noms = pac(1)
        End Select

        lbl_PacienteApellidos.Text = apes
        lbl_PacienteNombres.Text = noms


        'lbl_Fecha.Text = dgv_TToPaciente.CurrentRow.Cells("TTO_FECHA").Value


        'ETIQUETA 3

        lbl_Serie.Text = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 0) & " " & Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 1)
        'lbl_Soluciones.Text = Trim(dgv_TToPaciente.CurrentRow.Cells("tto_soluciones").Value)
        'lbl_Frascos.Text = Trim(dgv_TToPaciente.CurrentRow.Cells("tto_cantidad").Value) & " FRASCOS"
        'lbl_UnidadFrascos.Text = Trim(dgv_TToPaciente.CurrentRow.Cells("TTO_CONTENIDO").Value)

    End Sub


    Private Sub btn_Imp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imp1.Click
        ImprimirCB1()
    End Sub


    Private Sub btn_Imp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imp2.Click
        ImprimirCB2()
    End Sub

    Private Sub btn_Imp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imp3.Click
        ImprimirCB_PAC()
    End Sub

    Private Sub btn_Imp4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imp4.Click
        ImprimirEtiquetas()
    End Sub

    
    Private Sub dgv_TToPaciente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_TToPaciente.KeyDown

        Dim opr_movimiento As New Cls_i_Movimiento()

        If e.KeyCode = Keys.Delete Then
            If MsgBox("Desea eliminar el registro " & dgv_TToPaciente.CurrentRow.Cells("I_PRD_DESCRIPCION").Value & " ?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                'Operaciones al precionar DELETE sobre el grid


                Dim mov_id As Integer
                Dim mov_detalle As Boolean
                Dim mov_ref As String
                '
                'OPERACION DE DEVOLUCION EN INVENTARIO
                If opr_movimiento.OperaMovimiento(True, dgv_TToPaciente.CurrentRow.Cells("tto_fecha").Value(), dgv_TToPaciente.CurrentRow.Cells("tto_fecha").Value(), "NA", "", _
                            "ING             Ingresos                  INGRESO   ", Str(med_id), dtt_TTO, "", "B01", mov_id, True, mov_ref, 1) = 1 Then

                End If

                opr_pedido.EliminaTTo(Age_id, pac_id, dgv_TToPaciente.CurrentRow.Cells("I_PRD_ID").Value(), CInt(dgv_TToPaciente.CurrentRow.Cells("tto_cantidad").Value()))
                If ventana_tipo = 0 Then
                    actualizaDtsTTO(pac_id, "CLIENTE")

                Else
                    actualizaDtsTTO(pac_id, "PACIENTE")
                End If
                Dgrd_Vacunas.DataSource = dtv_Vacunas
                opr_pedido.LlenarGridVacunas("B01", dtv_Vacunas)

            End If
        End If
    End Sub


    Private Sub Dgrd_Vacunas_CurrentCellChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Vacunas.CurrentCellChanged

        Dim currentRow As Integer = Dgrd_Vacunas.CurrentCell.RowNumber

        ' Seleccionar toda la fila
        Dgrd_Vacunas.Select(currentRow)

        'ver_propiedades()
        btn_Imp1.Enabled = False
        btn_Imp2.Enabled = False
        btn_Imp3.Enabled = False
        btn_Imp4.Enabled = False

        cmb_CatindadMat.Text = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 6)

    End Sub


    Private Sub ver_propiedades()
        Select Case CInt(dgv_TToPaciente.CurrentRow.Cells("COMP").Value())
            Case 0


            Case 1 '"SERIE INICIAL" '3 FRASCOS
                'ETIQUETA 1
                lbl_Soluciones.Text = "SOLUCIONES 1-2-3"
                lbl_Frascos.Text = "3 FRASCOS"
                lbl_UnidadFrascos.Text = "2.5 ml/5.5 ml/5.5 ml"

            Case 2 '"SERIE REFUERZO" ' 2 FRASCOS
                lbl_Soluciones.Text = "SOLUCIONES 1-2"
                lbl_Frascos.Text = "2 FRASCOS"
                lbl_UnidadFrascos.Text = "5.5 ml/5.5 ml"

            Case 3 '"FRASCO 1 + INSECTOS" '(ESPECIAL + INSECTOS)
                lbl_Soluciones.Text = "SOLUCIONES 2"
                lbl_Frascos.Text = "2 FRASCOS"
                lbl_UnidadFrascos.Text = "5.5 ml/5.5 ml"

            Case 4 '"FRASCO 1 + 2 + INSECTOS" 'SERIE COMPLETA: (ESPECIAL + INSECTOS)
                lbl_Soluciones.Text = "SOLUCIONES 1-2-3"
                lbl_Frascos.Text = "3 FRASCOS"
                lbl_UnidadFrascos.Text = "5.5 ml/5.5 ml/5.5 ml"

            Case 5 '"LIQUIDO DE ALERGENO"  'LIQUIDO DE ALERGENO
                lbl_Soluciones.Text = "SOLUCION INDIVIDUAL"
                lbl_Frascos.Text = "1 FRASCO"
                lbl_UnidadFrascos.Text = "2.5 ml o 5.5 ml "

            Case 6 '"ACNE"
                lbl_Soluciones.Text = "SOLUCION DE ACNE"
                lbl_Frascos.Text = "1 FRASCO"
                lbl_UnidadFrascos.Text = "2.5 ml o  5.5 ml "
        End Select

        sw_previo = True

    End Sub
    Private Sub rbt_Adulto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Adulto.CheckedChanged

        If rbt_Adulto.Checked = True Then
            EsAdulto = "A"
        End If

        If swEntra = False Then

        Else
            opr_res.ordena_vacunaEsAdulto(EsAdulto, dtv_Vacunas)
        End If
    End Sub


    Private Sub rbt_Ninio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_Ninio.CheckedChanged
        If rbt_Ninio.Checked = True Then
            EsAdulto = "N"
        End If

        If swEntra = False Then

        Else
            opr_res.ordena_vacunaEsAdulto(EsAdulto, dtv_Vacunas)
        End If
    End Sub

    
    
    Private Sub dgv_TToPaciente_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_TToPaciente.CellClick
        ver_propiedades()
        ver_etiquetas()
    End Sub


    Private Sub btn_ImpPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpPlan.Click
        'opr_res.GuardaExistenciaTemporal(dgv_Tendencia, "A")

        Dim str_sql As String
        Dim obj_reporte As New Object
        Dim PLAN_ID As Integer


        Select Case dgv_TToPaciente.CurrentRow.Cells("SER_ID").Value()
            Case 1
                PLAN_ID = 4
            Case 2
                PLAN_ID = 3
            Case 3
                PLAN_ID = 2
            Case Else
                If dgv_TToPaciente.CurrentRow.Cells("I_PRD_A_ID").Value() = 3 Then
                    PLAN_ID = 1
                Else
                    PLAN_ID = 5
                End If
        End Select

        obj_reporte = New rpt_PlanTTO_G()

        str_sql = "Select PLAN_ID, PLAN_DESC, PLAN_FRASCOS from ReportePlanTTO where PLAN_ID = " & PLAN_ID & ""
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)

        Dim frm_ref_main As Frm_Main = Me.ParentForm


        frm_MDIChild.Text = "PLAN TTO INMUNIZACION"
        frm_MDIChild.ShowDialog(Me.ParentForm)

    End Sub

    
    
    Private Sub btn_CargaTtoMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CargaTtoMedico.Click
        Dim med_id1 As String
        Dim Age_Aux As Integer

        'Dgrd_Vacunas.DataSource = Nothing
        If opr_res.EsGrupo(med_id) = "GRUPO" Then
            med_id1 = opr_res.DevuelveGrupoGrupo(med_id)
            med_id1 = Mid(med_id1, 1, Len(med_id1) - 1)
            'Age_Aux = 
            'opr_res.LlenarGridGrupoMedico(dgv_MedicosTratantes, Age_id, dtt_MedTratante, med_id1)
        Else
            'opr_res.LlenarGridGrupoMedico(dgv_MedicosTratantes, Age_id, dtt_MedTratante, med_id)
        End If

        Dim frm_MDIChild As New frm_SolicitudMeddico()
        'frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.var_txt_Solicitud = opr_pedido.LeerSolicitud(Age_id)
        frm_MDIChild.var_meddico = cmb_medico.Text
        frm_MDIChild.Show(Me.ParentForm)




    End Sub

    
    Private Sub cmb_BodegaAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BodegaAlmacen.SelectedIndexChanged

        opr_pedido.LlenarGridVacunas(Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), dtv_Vacunas)

        If Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)) = "B01" Then
            lbl_ml.Visible = False
            cmb_decimal.Visible = False
        Else
            lbl_ml.Visible = True
            cmb_decimal.Visible = True
        End If

    End Sub

    
    Private Sub btnAddMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMat.Click
        Dim dbl_cantidad As Double
        Dim opr_movimiento As New Cls_i_Movimiento()
        Dim STR_PRD_CAD, STR_PRD_STOCK, STR_MSG As String
        'Dim boo_opera As Boolean = False
        Dim boo_modDetalle As Boolean = False
        Dim MOV_ID, mov_estado As Integer
        Dim REF_MOV As String
        Dim dtt_detmovM As New DataTable()
        Dim dtt_detmovM2 As New DataTable()

        Select Case ventana_tipo

            Case 0 'CLIENTE MEDICO
                If opr_pedido.GestionaTTO(Age_id, med_id, pac_id, dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1), CInt(cmb_CatindadMat.Text), Format(Now(), "dd/MM/yyyy"), Trim(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 5)), dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 10), CDec(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 11)), "Insert", ventana_tipo, "") = True Then
                    dbl_cantidad = opr_movimiento.ProductoBodega("B08", dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1), dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 5), CDbl(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 10)), 0)
                    If dbl_cantidad < 0 Then
                        STR_PRD_STOCK = Chr(13) & Space(10) & " * " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1) & "  " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 2) & STR_PRD_STOCK
                    End If

                    If opr_movimiento.ProductoCaducado("B08", dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1)) = True Then
                        STR_PRD_CAD = Chr(13) & Space(10) & " * " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1) & "  " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 2) & STR_PRD_CAD
                    End If

                    If STR_PRD_STOCK <> "" And Me.Tag = 1 Then
                        opr_pedido.VisualizaMensaje("La cantidad solicitada es mayor al stock disponible," & Chr(13) & "favor revice la cantidad del PRODUCTO: " & STR_PRD_STOCK & "Operacion Interrumpida", g_tiempo)
                        Exit Sub
                    End If


                    ' Agrega las columnas con sus respectivos nombres y tipos de datos
                    dtt_detmovM2.Columns.Add("MOV_ID", GetType(Integer))
                    dtt_detmovM2.Columns.Add("MOV_PROD", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_BODEGA", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_LOTE", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_OBS", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_CANTIDAD", GetType(Integer))
                    dtt_detmovM2.Columns.Add("MOV_COSTO", GetType(Decimal))
                    'dtt_detmov.Columns.Add("MOV_FCVCTO", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_POST", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_CANTAUX", GetType(Integer))
                    dtt_detmovM2.Columns.Add("MOV_UNIDAD", GetType(String))
                    dtt_detmovM2.Columns.Add("sum_cantidad", GetType(Integer))
                    dtt_detmovM2.Columns.Add("I_MOV_FSCO1", GetType(String))
                    dtt_detmovM2.Columns.Add("I_MOV_FSCO2", GetType(String))
                    dtt_detmovM2.Columns.Add("I_MOV_FSCO3", GetType(String))

                    Dim fila1 As DataRow = dtt_detmovM2.NewRow()
                    fila1("MOV_ID") = 0
                    fila1("MOV_PROD") = Trim(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1))
                    fila1("MOV_BODEGA") = "B08"
                    fila1("MOV_LOTE") = dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 5)
                    fila1("MOV_OBS") = "EGRESO MEDICO"
                    fila1("MOV_CANTIDAD") = CInt(cmb_CatindadMat.Text)
                    fila1("MOV_COSTO") = CDec(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 10))
                    'fila1("MOV_FCVCTO") = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)
                    fila1("MOV_POST") = ""
                    fila1("MOV_CANTAUX") = 0
                    fila1("MOV_UNIDAD") = "SERIE"
                    fila1("sum_cantidad") = dbl_cantidad
                    fila1("I_MOV_FSCO1") = "Si"
                    fila1("I_MOV_FSCO2") = "Si"
                    fila1("I_MOV_FSCO3") = "Si"
                    dtt_detmovM2.Rows.Add(fila1)

                    'GUARDA MOVIMIENTO DE EGRESO
                    Dim ClientePac As String

                    If ventana_tipo = 0 Then
                        ClientePac = "CLIENTE"
                    Else
                        ClientePac = "PACIENTE"
                    End If
                    If opr_movimiento.OperaMovimiento(True, Format(Now, "yyyy-MM-dd hh:mm"), Format(Now, "yyyy-MM-dd hh:mm"), Age_id, "LABALERGIA", "EGR             Egresos                   EGRESO    ", "LABALERGIA", dtt_detmovM2, Trim(lbl_paciente.Text), "B08", MOV_ID, True, REF_MOV, 1) = 1 Then

                        If actualizaDtsTTO2(med_id, "CLIENTE") = True Then
                            dgv_MATPaciente.Visible = True
                            iniciaGridTto2()
                        Else
                            dgv_MATPaciente.Visible = False
                        End If

                        dgrd_materiales.DataSource = dtv_Materiales
                        opr_pedido.LlenarGridMateriales("B08", dtv_Materiales)

                        opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
                    End If

                Else
                    opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
                End If

            Case 1 'PACIENTE
                If opr_pedido.GestionaTTO(Age_id, med_id, pac_id, dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1), CInt(cmb_CatindadMat.Text), Format(Now(), "dd/MM/yyyy"), Trim(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 5)), dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 10), dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 11), "Insert", ventana_tipo, "") = True Then
                    dbl_cantidad = opr_movimiento.ProductoBodega("B08", dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1), dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 5), CDbl(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 10)), 0)
                    If dbl_cantidad < 0 Then
                        STR_PRD_STOCK = Chr(13) & Space(10) & " * " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1) & "  " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 2) & STR_PRD_STOCK
                    End If

                    If opr_movimiento.ProductoCaducado("B08", dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1)) = True Then
                        STR_PRD_CAD = Chr(13) & Space(10) & " * " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1) & "  " & dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 2) & STR_PRD_CAD
                    End If

                    If STR_PRD_STOCK <> "" And Me.Tag = 1 Then
                        opr_pedido.VisualizaMensaje("La cantidad solicitada es mayor al stock disponible," & Chr(13) & "favor revice la cantidad del PRODUCTO: " & STR_PRD_STOCK & "Operacion Interrumpida", g_tiempo)
                        Exit Sub
                    End If

                    ' Agrega las columnas con sus respectivos nombres y tipos de datos
                    dtt_detmovM2.Columns.Add("MOV_ID", GetType(Integer))
                    dtt_detmovM2.Columns.Add("MOV_PROD", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_BODEGA", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_LOTE", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_OBS", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_CANTIDAD", GetType(Integer))
                    dtt_detmovM2.Columns.Add("MOV_COSTO", GetType(Decimal))
                    'dtt_detmov.Columns.Add("MOV_FCVCTO", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_POST", GetType(String))
                    dtt_detmovM2.Columns.Add("MOV_CANTAUX", GetType(Integer))
                    dtt_detmovM2.Columns.Add("MOV_UNIDAD", GetType(String))
                    dtt_detmovM2.Columns.Add("sum_cantidad", GetType(Integer))
                    dtt_detmovM2.Columns.Add("I_MOV_FSCO1", GetType(String))
                    dtt_detmovM2.Columns.Add("I_MOV_FSCO2", GetType(String))
                    dtt_detmovM2.Columns.Add("I_MOV_FSCO3", GetType(String))

                    Dim fila1 As DataRow = dtt_detmovM2.NewRow()
                    fila1("MOV_ID") = 0
                    fila1("MOV_PROD") = Trim(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 1))
                    fila1("MOV_BODEGA") = "B08"
                    fila1("MOV_LOTE") = dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 5)
                    fila1("MOV_OBS") = "EGRESO PACIENTE"
                    fila1("MOV_CANTIDAD") = CInt(cmb_CatindadMat.Text)
                    fila1("MOV_COSTO") = CDec(dgrd_materiales.Item(dgrd_materiales.CurrentCell.RowNumber, 10))
                    'fila1("MOV_FCVCTO") = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 5)
                    fila1("MOV_POST") = ""
                    fila1("MOV_CANTAUX") = 0
                    fila1("MOV_UNIDAD") = "SERIE"
                    fila1("sum_cantidad") = dbl_cantidad
                    fila1("I_MOV_FSCO1") = "Si"
                    fila1("I_MOV_FSCO2") = "Si"
                    fila1("I_MOV_FSCO3") = "Si"
                    dtt_detmovM2.Rows.Add(fila1)

                    'GUARDA MOVIMIENTO DE EGRESO
                    Dim ClientePac As String
                    If Age_resumen = "DESPACHO CLIENTE" Then
                        ClientePac = "CLIENTE"
                    Else
                        ClientePac = "PACIENTE"
                    End If
                    If opr_movimiento.OperaMovimiento(True, Format(Now, "yyyy-MM-dd hh:mm"), Format(Now, "yyyy-MM-dd hh:mm"), Age_id, "LABALERGIA", "EGR             Egresos                   EGRESO    ", "LABALERGIA", dtt_detmovM2, Trim(lbl_paciente.Text), "B08", MOV_ID, True, REF_MOV, 1) = 1 Then

                        If actualizaDtsTTO2(pac_id, "PACIENTE") = True Then
                            dgv_MATPaciente.Visible = True
                            iniciaGridTto2()
                        Else
                            dgv_MATPaciente.Visible = False
                        End If

                        dgrd_materiales.DataSource = dtv_Materiales
                        opr_pedido.LlenarGridMateriales("B08", dtv_Materiales)

                        opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
                    End If

                Else
                    opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
                End If

        End Select
    End Sub

    
    Private Sub dgrd_materiales_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_materiales.CurrentCellChanged
        Dim currentRow As Integer = dgrd_materiales.CurrentCell.RowNumber

        ' Seleccionar toda la fila
        dgrd_materiales.Select(currentRow)
    End Sub

    
    Private Sub rbt_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_todos.CheckedChanged
        opr_pedido.LlenarGridVacunas("B01", dtv_Vacunas)
    End Sub
End Class