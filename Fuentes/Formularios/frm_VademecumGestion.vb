Public Class frm_VademecumGestion

    Private WithEvents dtt_vadem As New DataTable("Registros")
    Public frm_refer_main As Frm_Main
    Dim opr_res As New Cls_Resultado()
    Dim dtv_Vadem As New DataView()
    Public consulta As String = Nothing
    Public var_vadem As String = Nothing
    Dim parametroVad As String = Nothing
    Dim dtVad As DataTable = New DataTable()
    Dim opr_pedido As New Cls_Pedido()
    Dim opr_medico As New Cls_Medico()
    Dim boo_flag As Boolean   'Si es Nuevo True y es actualizacion False
    Dim sw_tipo As String   'Si es Nuevo, Actualiza o elimina
    Dim VARVAD_ID As Integer


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub frm_VademecumGestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        opr_medico.LlenarComboPresentacion(cmb_Presentacion)

        cmb_Edad.SelectedIndex = 0

        Dgrd_Vademecum.DataSource = dtv_Vadem
        opr_pedido.LlenarGridVademecum(dtv_Vadem, Trim(txt_BuscaVadem.Text))

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If (txt_NomGenerico.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese el nombre GENERICO", 300)
            txt_NomGenerico.Focus()
            Exit Sub
        End If
        If (txt_NomComercial.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese el nombre COMERCIAL", 300)
            txt_NomComercial.Focus()
            Exit Sub
        End If
        If (txt_Cantidad.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese la CANTIDAD", 300)
            txt_Cantidad.Focus()
            Exit Sub
        End If
        If (txt_indicaciones.Text = "") Then
            opr_pedido.VisualizaMensaje("Ingrese las INDICACIONES", 300)
            txt_indicaciones.Focus()
            Exit Sub
        End If

        If (cmb_Presentacion.Text = "Todas") Then
            opr_pedido.VisualizaMensaje("Debe escojer un tipo presentación para el producto", 300)
            cmb_Presentacion.Focus()
            Exit Sub
        End If
        If (txt_Extras.Text = "") Then
            txt_Extras.Text = "N/A"
            'opr_pedido.VisualizaMensaje("Ingrese los EXTRAS", 300)
            'txt_Extras.Focus()
            'Exit Sub
        End If


        If (opr_res.BuscarVademecum(Trim(txt_NomComercial.Text)) = True And boo_flag = True) = True Then
            opr_pedido.VisualizaMensaje("El producto " & Trim(txt_NomComercial.Text) & " ya existe", 300)
            txt_NomGenerico.Focus()
            boo_flag = False
            Exit Sub
        Else
            boo_flag = True
        End If
        Select Case sw_tipo
            Case "Insert"
                If boo_flag = True Then    '*** Si se trata de una nuevo cie
                    opr_res.GuardarVademecum(opr_res.ConsultaMaxVademecum() + 1, Trim(cmb_Edad.Text), Trim(Mid(cmb_Presentacion.Text, 101, 10)), CInt(Trim(txt_Cantidad.Text)), Trim(txt_NomGenerico.Text), Trim(txt_NomComercial.Text), Trim(txt_indicaciones.Text), Trim(txt_Extras.Text), "Insert")
                Else
                    opr_res.GuardarVademecum(VARVAD_ID, Trim(cmb_Edad.Text), Trim(Mid(cmb_Presentacion.Text, 101, 10)), CInt(Trim(txt_Cantidad.Text)), Trim(txt_NomGenerico.Text), Trim(txt_NomComercial.Text), Trim(txt_indicaciones.Text), Trim(txt_Extras.Text), "Update")
                End If

            Case "Update"
                opr_res.GuardarVademecum(VARVAD_ID, Trim(cmb_Edad.Text), Trim(Mid(cmb_Presentacion.Text, 101, 10)), CInt(Trim(txt_Cantidad.Text)), Trim(txt_NomGenerico.Text), Trim(txt_NomComercial.Text), Trim(txt_indicaciones.Text), Trim(txt_Extras.Text), "Update")

        End Select
        
        txt_NomGenerico.Text = ""
        txt_NomComercial.Text = ""
        txt_Cantidad.Text = ""
        txt_indicaciones.Text = ""
        txt_Extras.Text = ""
        cmb_Presentacion.SelectedIndex = 0
        cmb_Edad.SelectedIndex = 0
        GroupBox1.Enabled = False
        opr_pedido.LlenarGridVademecum(dtv_Vadem, "")

        btn_nuevo.Enabled = False
        btn_Editar.Enabled = False

        'opr_pedido.VisualizaMensaje("Registro guardado satisfactoriamente", 300)
    End Sub


    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Dim msg As String = Nothing
        Dim comentario As String
        Dim opr_ped As New Cls_Pedido()

        msg = "Ingrese el nobre de la nueva presentacion "

        comentario = InputBox(msg, "ANALISYS")

        If comentario <> "" Then
            opr_ped.InsertarPresentacion(opr_ped.devuelveMaxPresentacion() + 1, comentario)
            opr_ped.VisualizaMensaje("Presentacion añadida", 300)
            cmb_Presentacion.Items.Clear()
            opr_medico.LlenarComboPresentacion(cmb_Presentacion)
        End If

    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'En caso de actualizar un PERFIL    
        If (MsgBox("Desea elimnar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = vbNo) Then
            txt_NomComercial.Focus()
            Exit Sub
        Else
            opr_res.EliminaVademecum(Trim(txt_NomComercial.Text))
        End If
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click
        GroupBox1.Enabled = True
        txt_NomGenerico.Focus()
        sw_tipo = "Update"
    End Sub

    
    Private Sub Dgrd_Vademecum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Vademecum.Click
        btn_nuevo.Enabled = True
        btn_Editar.Enabled = True
    End Sub

    Private Sub btn_AddVadem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddVadem.Click
        GroupBox1.Enabled = True

        txt_NomGenerico.Text = ""
        txt_NomComercial.Text = ""
        txt_Cantidad.Text = "1"
        txt_indicaciones.Text = ""
        txt_Extras.Text = ""
        cmb_Presentacion.SelectedIndex = 0
        cmb_Edad.SelectedIndex = 0

        cmb_Presentacion.Focus()

        sw_tipo = "Insert"
    End Sub

    Private Sub Dgrd_Vademecum_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Vademecum.CurrentCellChanged
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0

        dgc_celda.RowNumber = Dgrd_Vademecum .CurrentCell.RowNumber
        Dgrd_Vademecum.CurrentCell = dgc_celda
        Dgrd_Vademecum.Select(Dgrd_Vademecum.CurrentCell.RowNumber)

        VARVAD_ID = CInt(Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 0))
        cmb_Edad.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 1)
        cmb_Presentacion.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 2).PadRight(100) & Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 3).ToString().PadRight(5)
        txt_Cantidad.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 4)
        txt_NomGenerico.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 5)
        txt_NomComercial.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 6)
        txt_indicaciones.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 7)
        txt_Extras.Text = Dgrd_Vademecum.Item(Dgrd_Vademecum.CurrentCell.RowNumber.ToString, 8)

    End Sub
End Class