

Public Class frm_Cie10
    Private WithEvents dtt_cie As New DataTable("Registros")
    Public frm_refer_main As Frm_Main
    Dim opr_res As New Cls_Resultado()
    Dim opr_pedido As New Cls_Pedido()
    Dim dtv_Cie As New DataView()
    Public consulta As String = Nothing
    Public var_cie4 As String = Nothing
    Dim sw_tipo As String   'Si es Nuevo, Actualiza o elimina
    Dim boo_flag As Boolean = False




    Private Function actualizaDtsCie10(ByVal parametro As String) As Boolean
        'dtt_cie.Clear()


        'opr_res.LlenarGridCie10(dgv_Cie10, dtt_cie, parametro)
        'If dtt_cie.Rows.Count > 0 Then
        ' actualizaDtsCie10 = True
        ' Else
        ' actualizaDtsCie10 = False
        ' End If

    End Function

    Private Sub frm_Cie10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GroupBox1.Enabled = False
        Dgrd_Cie10.DataSource = dtv_Cie
        opr_pedido.LlenarGridCie10(dtv_Cie, Trim(txt_BuscaCie.Text))
        txt_BuscaCie.Focus()


    End Sub

    

    Private Sub txt_BuscaCie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BuscaCie.TextChanged


        If txt_BuscaCie.Text <> "" Then
            'opr_pedido.ordena_cedula(txt_filtro.Text, dtv_pedido)
            opr_res.ordena_cie(Trim(txt_BuscaCie.Text), dtv_Cie)
        Else
            'Dgrd_Cie10.DataSource = dtv_Cie
            opr_pedido.LlenarGridCie10(dtv_Cie, Trim(txt_BuscaCie.Text))
            'dtv_Cie.RowFilter = ""
        End If

        'actualizaDtsCie10(Trim(txt_BuscaCie.Text))
    End Sub

    
    Private Sub Dgrd_Cie10_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Cie10.CurrentCellChanged
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = Dgrd_Cie10.CurrentCell.RowNumber
        Dgrd_Cie10.CurrentCell = dgc_celda
        Dgrd_Cie10.Select(Dgrd_Cie10.CurrentCell.RowNumber)
        txt_CodCie3.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber.ToString, 0)
        txt_CodCie4.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber.ToString, 2)

        txt_DesCie3.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber.ToString, 1)
        'txt_DesCie4.Text = ""

    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub Dgrd_Cie10_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Cie10.DoubleClick
        On Error Resume Next
        Dim ctl As Form
        Dim ctl2 As frm_ConsultaMedico

        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        For Each ctl In frm_refer_main.MdiChildren
            'If ctl.Name = "frm_Pedido" Or "frm_Ing_Remitidos" Or "Ingreso_Aspirantes" Then
            ctl2 = ctl
            consulta = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 3)
            var_cie4 = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 2)
            'ctl2.LLena_datosCie10(consulta)
            'ctl2.actualizaDtsCieConsulta(Age_Id, med_id)
            ctl.Activate()
            'End If
        Next
        Me.Close()
    End Sub

    Private Sub btn_AddCie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddCie.Click
        GroupBox1.Enabled = True

        txt_CodCie3.Enabled = False
        txt_DesCie3.Enabled = False

        txt_CodCie4.Enabled = True
        txt_DesCie4.Enabled = True

        txt_CodCie4.Text = ""
        txt_DesCie4.Text = ""

        txt_CodCie4.Focus()
        sw_tipo = "Insert"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardaCie.Click
        If (txt_CodCie3.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese el CODIGO DE 3 digitos", 300)
            txt_CodCie3.Focus()
            Exit Sub
        End If

        If (txt_CodCie4.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese el CODIGO DE 4 digitos", 300)
            txt_CodCie4.Focus()
            Exit Sub
        End If

        If (txt_DesCie3.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese la DESCRIPCION PARA 3 digitos", 300)
            txt_CodCie3.Focus()
            Exit Sub
        End If

        If (txt_DesCie4.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese la DESCRIPCION PARA 4 digitos", 300)
            txt_CodCie4.Focus()
            Exit Sub
        End If


        'If (opr_res.BuscarCie("Cie3", Trim(txt_CodCie3.Text)) = True And boo_flag = True) Then
        '    opr_pedido.VisualizaMensaje("El codigo 3 digitos " & Trim(txt_CodCie3.Text) & " ya existe", 300)
        '    txt_CodCie3.Focus()
        '    Exit Sub
        'End If

        If (opr_res.BuscarCie("Cie4", Trim(txt_CodCie4.Text)) = True And boo_flag = True) = True Then
            opr_pedido.VisualizaMensaje("El codigo 4 digitos " & Trim(txt_CodCie4.Text) & " ya existe", 300)
            txt_CodCie4.Focus()
            boo_flag = True
            Exit Sub
        Else
            boo_flag = False
        End If

        Select Case sw_tipo
            Case "Insert"
                If boo_flag = False Then
                    opr_res.GuardarCie(Trim(txt_CodCie3.Text), Trim(txt_DesCie3.Text), Trim(txt_CodCie4.Text), Trim(txt_DesCie4.Text), "Insert")
                    'opr_pedido.VisualizaMensaje("Registro Cie10 almacenado satisfactoriamente", 300)
                Else
                    opr_res.GuardarCie(Trim(txt_CodCie3.Text), Trim(txt_DesCie3.Text), Trim(txt_CodCie4.Text), Trim(txt_DesCie4.Text), "Update")
                End If

            Case "Update"
                opr_res.GuardarCie(Trim(txt_CodCie3.Text), Trim(txt_DesCie3.Text), Trim(txt_CodCie4.Text), Trim(txt_DesCie4.Text), "Update")
        End Select
        txt_CodCie3.Text = ""
        txt_CodCie4.Text = ""
        txt_DesCie3.Text = ""
        txt_DesCie4.Text = ""

        GroupBox1.Enabled = False
        opr_pedido.LlenarGridCie10(dtv_Cie, Trim(txt_BuscaCie.Text))
        btn_AddCie.Enabled = True
        btnEditCie.Enabled = True
    End Sub

    Private Sub btnEditCie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCie.Click
        GroupBox1.Enabled = True
        txt_CodCie3.Enabled = False
        txt_CodCie4.Enabled = False
        txt_DesCie3.Enabled = False
        txt_DesCie4.Enabled = True
        txt_DesCie4.Focus()
        sw_tipo = "Update"
    End Sub

    Private Sub Dgrd_Cie10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Cie10.Click
        GroupBox1.Enabled = True
        txt_CodCie3.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 0)
        txt_DesCie3.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 1)
        txt_CodCie4.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 2)
        txt_DesCie4.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 3)
        sw_tipo = "Update"

        txt_CodCie3.Enabled = False
        txt_CodCie4.Enabled = False
        txt_DesCie3.Enabled = False
        txt_DesCie4.Enabled = False

        'txt_DesCie3.Focus()

        btn_AddCie.Enabled = True
        btnEditCie.Enabled = True
    End Sub

    
    Private Sub Btn_EliminaCie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EliminaCie.Click
        If (MsgBox("Desea elimnar el registro Cie10 seleccionado?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = vbNo) Then
            txt_CodCie3.Focus()
            Exit Sub
        Else
            opr_res.GuardarCie(Trim(txt_CodCie3.Text), Trim(txt_DesCie3.Text), Trim(txt_CodCie4.Text), Trim(txt_DesCie4.Text), "Delete")
            GroupBox1.Enabled = False
            opr_pedido.LlenarGridCie10(dtv_Cie, Trim(txt_BuscaCie.Text))
            btn_AddCie.Enabled = True
            btnEditCie.Enabled = True
        End If
    End Sub


    Private Sub txt_CodCie4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CodCie4.TextChanged
        txt_CodCie4.Text = txt_CodCie4.Text.ToUpper()
        txt_CodCie4.SelectionStart = txt_CodCie4.Text.Length
    End Sub

    Private Sub txt_DesCie4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DesCie4.TextChanged
        txt_DesCie4.Text = txt_DesCie4.Text.ToUpper()
        txt_DesCie4.SelectionStart = txt_DesCie4.Text.Length
    End Sub

    Private Sub txt_CodCie3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CodCie3.TextChanged
        txt_CodCie3.Text = txt_CodCie3.Text.ToUpper()
        txt_CodCie3.SelectionStart = txt_CodCie3.Text.Length
    End Sub

    Private Sub txt_DesCie3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DesCie3.TextChanged
        txt_DesCie3.Text = txt_DesCie3.Text.ToUpper()
        txt_DesCie3.SelectionStart = txt_DesCie3.Text.Length
    End Sub
End Class