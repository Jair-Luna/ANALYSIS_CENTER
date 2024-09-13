Public Class frm_Vademecum
    Private WithEvents dtt_vadem As New DataTable("Registros")
    Public frm_refer_main As Frm_Main
    Dim opr_res As New Cls_Resultado()
    Dim dtv_Vadem As New DataView()
    Public consulta As String = Nothing
    Public var_vadem As String = Nothing
    Dim parametroVad As String = Nothing
    Dim dtVad As DataTable = New DataTable()
    Private WithEvents dtt_agenda As New DataTable("Registros")
    Dim i As Integer
    Dim opr_pedido As New Cls_Pedido()



    Private Sub frm_Vademecum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dgrd_Vademecum.DataSource = dtv_Vadem
        opr_pedido.LlenarGridVademecum(dtv_Vadem, Trim(txt_BuscaVadem.Text))
        txt_BuscaVadem.Focus()

        lbl_MedGen.Text = ""
        lbl_MedTipo.Text = ""

        If dtv_Vadem.Count > 0 Then

        End If

        '***********************************
        ' VADEMECUM
        '***********************************

        ''CREO COLUMNAS PARA GRID CARGA VADEMCUM 
        Dim dtcDatosVad As New DataColumn("vad_medgen", GetType(System.String))
        dtVad.Columns.Add(dtcDatosVad)

        Dim dtcDatosVad1 As New DataColumn("vad_medcom", GetType(System.String))
        dtVad.Columns.Add(dtcDatosVad1)

        Dim dtcDatosVad2 As New DataColumn("vad_presentacion", GetType(System.String))
        dtVad.Columns.Add(dtcDatosVad2)

        Dim dtcDatosVad3 As New DataColumn("vad_cantidad", GetType(System.String))
        dtVad.Columns.Add(dtcDatosVad3)

        Dim dtcDatosVad4 As New DataColumn("vad_indicaciones", GetType(System.String))
        dtVad.Columns.Add(dtcDatosVad4)

        
        
        
    End Sub

    
    Private Sub txt_BuscaVadem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BuscaVadem.TextChanged
        If txt_BuscaVadem.Text <> "" Then
            'opr_pedido.ordena_cedula(txt_filtro.Text, dtv_pedido)
            opr_res.ordena_vademecum(Trim(txt_BuscaVadem.Text), parametroVad, dtv_Vadem)
        Else
            dtv_Vadem.RowFilter = ""
        End If
    End Sub

    Private Sub Dgrd_Vademecum_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Vademecum.CurrentCellChanged
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = Dgrd_Vademecum.CurrentCell.RowNumber
        Dgrd_Vademecum.CurrentCell = dgc_celda
        Dgrd_Vademecum.Select(Dgrd_Vademecum.CurrentCell.RowNumber)
    End Sub

    Private Sub rbt_MedGen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_MedGen.CheckedChanged
        If rbt_MedGen.Checked = True Then
            parametroVad = "MedGen"
        Else
            parametroVad = "MedCom"
        End If
    End Sub

    Private Sub rbt_MedCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_MedCom.CheckedChanged
        If rbt_MedCom.Checked = True Then
            parametroVad = "MedCom"
        Else
            parametroVad = "MedGen"
        End If
    End Sub

    Private Sub Dgrd_Vademecum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Vademecum.Click
        lbl_MedTipo.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 1)
        lbl_MedGen.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 2)
        txt_indcaciones.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 6)
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub




    

    Private Sub cargaGridVAD(ByVal VadGen As String, ByVal VadCom As String, ByVal VadPres As String, ByVal VadCant As String, ByVal VadIndica As String)



        Dim row1 As DataRow = dtVad.NewRow()
        row1("vad_medgen") = VadGen
        row1("vad_medcom") = VadCom
        row1("vad_presentacion") = VadPres
        row1("vad_cantidad") = VadCant
        row1("vad_indicaciones") = VadIndica
        dtVad.Rows.Add(row1)

        'Dim row2 As DataRow = dtMed.NewRow()
        'row2("Fecha") = fecha
        'dtMed.Rows.Add(row2)

        dtVad.AcceptChanges()
        dgv_CargaVadem.DataSource = dtVad

    End Sub


    Private Sub Dgrd_Vademecum_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Vademecum.DoubleClick
        
        cargaGridVAD(Trim(Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 2)), Trim(Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 5)), Trim(Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 3)), Trim(Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 4)), Trim(Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber, 6)))

        dgv_CargaVadem.Columns("vad_medgen").HeaderText = "GENERICO"
        dgv_CargaVadem.Columns("vad_medgen").Width = 140
        dgv_CargaVadem.Columns("vad_medgen").ReadOnly = True

        dgv_CargaVadem.Columns("vad_medcom").HeaderText = "COMERCIAL"
        dgv_CargaVadem.Columns("vad_medcom").Width = 140
        dgv_CargaVadem.Columns("vad_medcom").ReadOnly = True

        dgv_CargaVadem.Columns("vad_presentacion").HeaderText = "PRESENTAC"
        dgv_CargaVadem.Columns("vad_presentacion").Width = 0
        dgv_CargaVadem.Columns("vad_presentacion").ReadOnly = True
        dgv_CargaVadem.Columns("vad_presentacion").Visible = False

        dgv_CargaVadem.Columns("vad_cantidad").HeaderText = "CANT"
        dgv_CargaVadem.Columns("vad_cantidad").Width = 35
        dgv_CargaVadem.Columns("vad_cantidad").ReadOnly = False


        dgv_CargaVadem.Columns("vad_indicaciones").Visible = False

        dgv_CargaVadem.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_CargaVadem.DefaultCellStyle.SelectionForeColor = Color.LightSkyBlue
        dgv_CargaVadem.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgv_CargaVadem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

    End Sub

    Private Sub btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Finalizar.Click
        var_vadem = ""
        Dim j As Integer = 1
        For i = 0 To dgv_CargaVadem.Rows.Count - 1

            'dgv_CargaVadem.Rows(i).Cells(0).Value
            var_vadem = var_vadem & j & ") - " & dgv_CargaVadem.Rows(i).Cells(0).Value & "º" & dgv_CargaVadem.Rows(i).Cells(1).Value & "º" & dgv_CargaVadem.Rows(i).Cells(2).Value & "º" & dgv_CargaVadem.Rows(i).Cells(3).Value & "º" & dgv_CargaVadem.Rows(i).Cells(4).Value & "|"
            j = j + 1
        Next

        Me.Close()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        dtVad.Clear()
        dgv_CargaVadem.DataSource = Nothing

    End Sub

    
    Private Sub btnGestionVademecum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionVademecum.Click
        Dim frm_MDIChild As New frm_VademecumGestion()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)

    End Sub

    Private Sub frm_Vademecum_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        opr_pedido.LlenarGridVademecum(dtv_Vadem, "")
    End Sub
End Class