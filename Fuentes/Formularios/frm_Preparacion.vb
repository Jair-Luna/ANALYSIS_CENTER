Public Class frm_Preparacion

    Public frm_refer_main As Frm_Main
    Dim opr_res As New Cls_Resultado()
    Dim opr_pedido As New Cls_Pedido()
    Dim dtv_Vacunas As New DataView()
    Dim dtv_Materiales As New DataView()

    Dim dtv_Series As New DataView()
    Dim opr_medico As New Cls_Medico()

    Private WithEvents dtt_TTO As New DataTable("TTO")
    Private WithEvents dtt_TTO2 As New DataTable("TTO")

    Dim dtt_detmovM2 As New DataTable()
    Dim dbl_cantidad As Double
    Dim opr_movimiento As New Cls_i_Movimiento()
    Dim STR_PRD_CAD, STR_PRD_STOCK, STR_MSG As String
    'Dim boo_opera As Boolean = False
    Dim boo_modDetalle As Boolean = False
    Dim MOV_ID, mov_estado As Integer
    Dim REF_MOV As String


    
    Private Sub lbx_Sustancia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'lbl_Sustancia.Text = lbx_Sustancia.SelectedItem
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarTTo.Click
        If (txt_Proceso.Text <> "" And txt_Sustancia.Text <> "" And txt_CantML.Text <> "") Then

            Dim dbl_cantidad As Double
            Dim opr_movimiento As New Cls_i_Movimiento()
            Dim STR_PRD_CAD, STR_PRD_STOCK, STR_MSG As String
            'Dim boo_opera As Boolean = False
            Dim boo_modDetalle As Boolean = False
            Dim MOV_ID, mov_estado As Integer
            Dim REF_MOV As String
            Dim dtt_detmov As New DataTable()

            If opr_pedido.GestionaTTO(0, 2, 2, Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 1), CDec(txt_CantML.Text), Format(Now(), "dd/MM/yyyy"), Trim(Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 5)), Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 10), CDec(Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 11)), "Insert", 2, lbx_Proceso.SelectedItem.ToString()) = True Then
                dbl_cantidad = opr_movimiento.ProductoBodega(Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 0), Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 5), CDbl(Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 10)), 0)
                If dbl_cantidad < 0 Then
                    STR_PRD_STOCK = Chr(13) & Space(10) & " * " & Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 1) & "  " & Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 2) & STR_PRD_STOCK
                End If

                If opr_movimiento.ProductoCaducado(Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 1)) = True Then
                    STR_PRD_CAD = Chr(13) & Space(10) & " * " & Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 1) & "  " & Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 2) & STR_PRD_CAD
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
                dtt_detmov.Columns.Add("MOV_CANTIDAD", GetType(Decimal))
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
                fila1("MOV_PROD") = Trim(Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 1))
                fila1("MOV_BODEGA") = "B09"
                fila1("MOV_LOTE") = Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 5)
                fila1("MOV_OBS") = "EGRESO PREPARACION"
                fila1("MOV_CANTIDAD") = CDec(txt_CantML.Text)
                fila1("MOV_COSTO") = CDec(Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 10))
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

                ClientePac = "CLIENTE"

                If opr_movimiento.OperaMovimiento(True, Format(Now, "yyyy-MM-dd hh:mm"), Format(Now, "yyyy-MM-dd hh:mm"), 0, "LABALERGIA", "EGR             Egresos                   EGRESO    ", "LABALERGIA", dtt_detmov, "", Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)), MOV_ID, True, REF_MOV, 1) = 1 Then


                    ''PREPARACION
                    If Trim(Mid(cmb_BodegaAlmacen.Text, 1, 10)) = "B09" Then
                        Dgrd_Sustancias.DataSource = dtv_Vacunas
                        opr_pedido.LlenarGridVacunas("B09", dtv_Vacunas)
                    End If

                    If actualizaDtsTTO(2, "PREPARACION") = True Then
                        Dgrd_Sustancias.Visible = True
                        iniciaGridTto()
                    End If


                    opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
                End If

            Else
                opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
            End If
        Else
            opr_pedido.VisualizaMensaje("Debe seleccionar una sustancia y/o proceso para ingresar inventario", 200)
        End If

    End Sub

    Private Sub frm_Preparacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        opr_pedido.LlenarComboBodegasPreparacion(cmb_BodegaAlmacen)

        '************************************************
        '  GRID DERECHA ARRIBA TRATAMIENTO MEDICO
        '************************************************
        Dim dtcV_columna1 As New DataColumn("tto_fecha", GetType(System.String))
        Dim dtcV_columna2 As New DataColumn("I_PRD_ABREV", GetType(System.String))
        Dim dtcV_columna3 As New DataColumn("I_PRD_DESCRIPCION", GetType(System.String))
        Dim dtcV_columna4 As New DataColumn("EDAD", GetType(System.String))
        Dim dtcV_columna5 As New DataColumn("tto_cantidad", GetType(System.Single))
        Dim dtcV_columna6 As New DataColumn("I_UNI_DESCRIPCION", GetType(System.String))
        Dim dtcV_columna7 As New DataColumn("vac_lote", GetType(System.String))
        Dim dtcV_columna10 As New DataColumn("VIA", GetType(System.String))
        Dim dtcV_columna11 As New DataColumn("COMP", GetType(System.String))
        Dim dtcV_columna12 As New DataColumn("ORIGEN", GetType(System.String))
        Dim dtcV_columna13 As New DataColumn("I_PRD_FRASCOS", GetType(System.Single))
        Dim dtcV_columna14 As New DataColumn("SER_ID", GetType(System.Single))
        Dim dtcV_columna15 As New DataColumn("I_PRD_ID", GetType(System.Single))

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

        If actualizaDtsTTO(2, "PREPARACION") = True Then
            dgv_Preparacion.Visible = True
            iniciaGridTto()
        Else
            dgv_MATPaciente.Visible = False
        End If


        '************************************************
        '  GRID DERECHA  ABAJO MATERIALES MEDICO CLIENTE
        '************************************************
        Dim dtcM_columna1 As New DataColumn("tto_fecha", GetType(System.String))
        Dim dtcM_columna2 As New DataColumn("I_PRD_ABREV", GetType(System.String))
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
        Dim dtcM_columna15 As New DataColumn("I_PRD_ID", GetType(System.String))

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


        If actualizaDtsTTO2(2, "PREPARACION") = True Then
            dgv_MATPaciente.Visible = True
            iniciaGridTto2()
        Else
            dgv_MATPaciente.Visible = False
        End If


        '****************************************
        '  GRID ARRIBA IZQUIERDA TTOS DISPONIBLES   BODEGA 9 PREPARACION
        '****************************************

        Dgrd_Sustancias.DataSource = dtv_Vacunas
        opr_pedido.LlenarGridVacunas("B09", dtv_Vacunas)


        '****************************************
        '  GRID ABAJO IZQUIERDA MATERIALES DISPONIBLES  BODEGA 8
        '****************************************
        Dgrd_Materiales.DataSource = dtv_Materiales
        opr_pedido.LlenarGridMateriales("B08", dtv_Materiales)


    End Sub


    Private Sub iniciaGridTto()
        dgv_Preparacion.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Preparacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        dgv_Preparacion.Columns("tto_fecha").HeaderText = "FECHA"
        dgv_Preparacion.Columns("tto_fecha").Width = 70

        dgv_Preparacion.Columns("I_PRD_ABREV").HeaderText = "CODIGO"
        dgv_Preparacion.Columns("I_PRD_ABREV").Width = 70

        dgv_Preparacion.Columns("I_PRD_DESCRIPCION").HeaderText = "DESCRIPCION"
        dgv_Preparacion.Columns("I_PRD_DESCRIPCION").Width = 150

        dgv_Preparacion.Columns("EDAD").HeaderText = "EDAD"
        dgv_Preparacion.Columns("EDAD").Visible = False

        dgv_Preparacion.Columns("tto_cantidad").HeaderText = "CANT"
        dgv_Preparacion.Columns("tto_cantidad").Width = 40

        dgv_Preparacion.Columns("I_UNI_DESCRIPCION").HeaderText = "UNIDAD"
        dgv_Preparacion.Columns("I_UNI_DESCRIPCION").Visible = False

        dgv_Preparacion.Columns("vac_lote").HeaderText = "LOTE"
        dgv_Preparacion.Columns("vac_lote").Width = 60

        dgv_Preparacion.Columns("VIA").HeaderText = "VIA"
        dgv_Preparacion.Columns("VIA").Visible = False

        dgv_Preparacion.Columns("COMP").HeaderText = "COMP"
        dgv_Preparacion.Columns("COMP").Visible = False

        dgv_Preparacion.Columns("ORIGEN").HeaderText = "ORIGEN"
        dgv_Preparacion.Columns("ORIGEN").Visible = False

        dgv_Preparacion.Columns("I_PRD_FRASCOS").HeaderText = "FCOS"
        dgv_Preparacion.Columns("I_PRD_FRASCOS").Visible = False

        dgv_Preparacion.Columns("SER_ID").HeaderText = "SER"
        dgv_Preparacion.Columns("SER_ID").Visible = False

        dgv_Preparacion.Columns("I_PRD_ID").Visible = False

        With dgv_Preparacion
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
        dgv_MATPaciente.Columns("I_PRD_ABREV").Width = 70

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

        dgv_MATPaciente.Columns("I_PRD_ID").Visible = False

        With dgv_MATPaciente
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

    End Sub

    Private Function actualizaDtsTTO(ByVal pac_id As Integer, ByVal tipo As String) As Boolean
        Dim ser_id As Integer

        dtt_TTO.Clear()

        opr_res.LlenarGridTTO(dgv_Preparacion, dtt_TTO, pac_id, tipo)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    
    Private Sub Dgrd_Materiales_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Materiales.CurrentCellChanged
        cmb_Frscos.Text = Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 5)
    End Sub

    Private Sub Dgrd_Sustancias_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Sustancias.CurrentCellChanged
        lbl_Unidad.Text = Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 12)
        txt_Sustancia.Text = Dgrd_Sustancias.Item(Dgrd_Sustancias.CurrentCell.RowNumber, 2)
    End Sub

    Private Sub txt_CantML_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CantML.TextChanged
        If txt_CantML.Text <> "" Then
            btn_AgregarTTo.Enabled = True
        Else
            btn_AgregarTTo.Enabled = False
        End If
    End Sub

    Private Sub btn_AgregarMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarMaterial.Click

        If opr_pedido.GestionaTTO(0, 0, 0, Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 1), CInt(cmb_Frscos.Text), Format(Now(), "dd/MM/yyyy"), Trim(Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 5)), Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 10), Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 11), "Insert", 2, "") = True Then
            dbl_cantidad = opr_movimiento.ProductoBodega("B08", Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 1), Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 5), CDbl(Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 10)), 0)
            If dbl_cantidad < 0 Then
                STR_PRD_STOCK = Chr(13) & Space(10) & " * " & Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 1) & "  " & Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 2) & STR_PRD_STOCK
            End If

            If opr_movimiento.ProductoCaducado("B08", Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 1)) = True Then
                STR_PRD_CAD = Chr(13) & Space(10) & " * " & Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 1) & "  " & Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 2) & STR_PRD_CAD
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
            fila1("MOV_PROD") = Trim(Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 1))
            fila1("MOV_BODEGA") = "B08"
            fila1("MOV_LOTE") = Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 5)
            fila1("MOV_OBS") = "EGRESO PREPARACION"
            fila1("MOV_CANTIDAD") = CInt(cmb_Frscos.Text)
            fila1("MOV_COSTO") = CDec(Dgrd_Materiales.Item(Dgrd_Materiales.CurrentCell.RowNumber, 10))
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

            If opr_movimiento.OperaMovimiento(True, Format(Now, "yyyy-MM-dd hh:mm"), Format(Now, "yyyy-MM-dd hh:mm"), 0, "LABALERGIA", "EGR             Egresos                   EGRESO    ", "LABALERGIA", dtt_detmovM2, "", "B08", MOV_ID, True, REF_MOV, 1) = 1 Then

                If actualizaDtsTTO2(0, "PACIENTE") = True Then
                    dgv_MATPaciente.Visible = True
                    iniciaGridTto2()
                Else
                    dgv_MATPaciente.Visible = False
                End If

                Dgrd_Materiales.DataSource = dtv_Materiales
                opr_pedido.LlenarGridMateriales("B08", dtv_Materiales)

                opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
            End If

        Else
            opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
        End If

    End Sub

    Private Sub lbx_Proceso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbx_Proceso.SelectedIndexChanged
        txt_Proceso.Text = lbx_Proceso.SelectedItem
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        txt_Proceso.Text = String.Empty
        txt_Sustancia.Text = String.Empty
        txt_CantML.Text = String.Empty
    End Sub
End Class