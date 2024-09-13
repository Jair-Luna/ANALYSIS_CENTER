
Public Class frm_PerfilMedico
    Inherits System.Windows.Forms.Form

    Dim opr_perfil As New Cls_Perfil()
    Dim opr_test As New Cls_TipoTest()
    Dim opr_pedido As New Cls_Pedido()
    Dim str_x As String
    Dim str_y As String
    Dim int_codigo As Integer
    Dim boo_flag As Boolean
    Dim GRUPO_ID As Integer
    Dim dbl_x As Double

    Dim dts_medico As DataSet
    Private WithEvents dtt_medico As New DataTable("Registros")

    
    Dim dts_GRUPOMedico As DataSet
    Private WithEvents dtt_GRUPOmedico As New DataTable("Registros")

    Dim dts_ELEMENTOmedico As DataSet
    Private WithEvents dtt_ELEMENTOmedico As New DataTable("Registros")


    Dim opr_res As New Cls_Resultado()
    Dim opr_agenda As New Cls_Agenda()
    Dim opr_pac As New Cls_Paciente()
    Private opr_medico As New Cls_Medico()

    Dim blnAjustarCeldas As Boolean = True
    Dim frm_refer_main_form As Frm_Main
    Public med_id As Integer

    Private Sub frm_PerfilMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'btn_Aceptar.Enabled = False
        Call LimpiarCamposPerfil()


        opr_medico.LlenarComboEspecialidad(cmb_Especialidad)

        '***********************************
        ' MEDICO
        '***********************************
        Dim dtcM_columna1 As New DataColumn("med_nombre", GetType(System.String))
        Dim dtcM_columna2 As New DataColumn("med_id", GetType(System.Single))
        Dim dtcM_columna3 As New DataColumn("med_mail", GetType(System.String))
        dtt_medico.Columns.Add(dtcM_columna1)
        dtt_medico.Columns.Add(dtcM_columna2)
        dtt_medico.Columns.Add(dtcM_columna3)

        If cmb_Especialidad.Text = "Todas" Then
            actualizaDtsMedico(0, 1)
        Else
            actualizaDtsMedico(CInt(Mid(cmb_Especialidad.Text, 101, 110)), 1)
        End If

        dgv_Medico.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        dgv_Medico.Columns("med_nombre").Width = 190
        dgv_Medico.Columns("med_id").Visible = False
        dgv_Medico.Columns("med_mail").Visible = False

        dgv_Medico.DefaultCellStyle.SelectionForeColor = Color.LightYellow
        dgv_Medico.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgv_Medico.DefaultCellStyle.WrapMode = DataGridViewTriState.True


        '***********************************
        ' GRUPOS DE MEDICOS - teams
        '***********************************
        Dim dtcTEAM_columna1 As New DataColumn("med_nombre", GetType(System.String))
        Dim dtcTEAM_columna2 As New DataColumn("med_id", GetType(System.Single))
        Dim dtcTEAM_columna3 As New DataColumn("med_email", GetType(System.String))
        Dim dtcTEAM_columna4 As New DataColumn("esp_id", GetType(System.Single))
        dtt_GRUPOmedico.Columns.Add(dtcTEAM_columna1)
        dtt_GRUPOmedico.Columns.Add(dtcTEAM_columna2)
        dtt_GRUPOmedico.Columns.Add(dtcTEAM_columna3)
        dtt_GRUPOmedico.Columns.Add(dtcTEAM_columna4)

        actualizaDtsGRUPOMed()

        dgv_GruposMed.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        dgv_GruposMed.Columns("med_nombre").HeaderText = "NOMBRE DEL GRUPO"
        dgv_GruposMed.Columns("med_nombre").Width = 220

        dgv_GruposMed.Columns("MED_ID").Visible = False

        dgv_GruposMed.Columns("med_email").HeaderText = "OBSERVACIONES"
        dgv_GruposMed.Columns("med_email").Width = 200

        dgv_GruposMed.Columns("esp_id").Visible = False

        dgv_GruposMed.DefaultCellStyle.SelectionForeColor = Color.LightSeaGreen
        dgv_GruposMed.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgv_GruposMed.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        With dgv_GruposMed
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        'If dtt_GRUPOmedico.Columns.Count > 0 Then
        '    dgv_GruposMed.Rows(0).Selected = True
        'End If
        'dgv_GruposMed.Rows("GMED_ID").Selected = True
        'dgv_GruposMed.CurrentCell = dgv_GruposMed.Rows("GMED_ID").Cells(0)
        '***********************************
        ' ELEMENTOS DEL GRUPO DE MEDICOS 
        '***********************************
        Dim dtcELEM_columna1 As New DataColumn("MED_NOMBRE", GetType(System.String))
        Dim dtcELEM_columna2 As New DataColumn("MED_ID", GetType(System.Single))
        Dim dtcELEM_columna3 As New DataColumn("esp_desc", GetType(System.String))
        Dim dtcELEM_columna4 As New DataColumn("MED_MAIL", GetType(System.String))
        dtt_ELEMENTOmedico.Columns.Add(dtcELEM_columna1)
        dtt_ELEMENTOmedico.Columns.Add(dtcELEM_columna2)
        dtt_ELEMENTOmedico.Columns.Add(dtcELEM_columna3)
        dtt_ELEMENTOmedico.Columns.Add(dtcELEM_columna4)

        actualizaDtsELEMENTOSMed(med_id)

        dgv_ElementosMed.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        dgv_ElementosMed.Columns("MED_NOMBRE").HeaderText = "MEDICO"
        dgv_ElementosMed.Columns("MED_NOMBRE").Visible = True
        dgv_ElementosMed.Columns("MED_NOMBRE").Width = 140

        dgv_ElementosMed.Columns("MED_ID").Visible = False

        dgv_ElementosMed.Columns("esp_desc").HeaderText = "ESPECIALIDAD"
        dgv_ElementosMed.Columns("esp_desc").Visible = True
        dgv_ElementosMed.Columns("esp_desc").Width = 150

        dgv_ElementosMed.Columns("MED_MAIL").HeaderText = "CORREO"
        dgv_ElementosMed.Columns("MED_MAIL").Visible = True
        dgv_ElementosMed.Columns("MED_MAIL").Width = 200

        'dgv_ElementosMed.DefaultCellStyle.SelectionForeColor = Color.Silver
        dgv_ElementosMed.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgv_ElementosMed.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        With dgv_ElementosMed
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        btn_Nuevo.Focus()
    End Sub

    Private Sub actualizaDtsMedico(ByVal esp_id As Integer, ByVal tipo As Integer)
        dtt_medico.Clear()
        opr_res.LlenarGridMedico(dgv_Medico, dtt_medico, esp_id, tipo, True)
    End Sub

    
    Private Sub actualizaDtsGRUPOMed()
        dtt_GRUPOmedico.Clear()
        opr_res.LlenarGridGRUPOMed(dgv_GruposMed, dtt_GRUPOmedico)
    End Sub

    Private Sub actualizaDtsELEMENTOSMed(ByVal MED_ID As Integer)
        dtt_ELEMENTOmedico.Clear()
        opr_res.LlenarGridELEMENTOSMed(MED_ID, dgv_ElementosMed, dtt_ELEMENTOmedico)
    End Sub


    Private Sub LimpiarCamposPerfil()
        Ctl_txt_nombre.texto_Asigna("")
        Ctl_txt_nombre.txt_padre.MaxLength = 100
    End Sub


    

    Private Sub dgv_GRUPOSMed_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dgv_GruposMed.Paint
        If blnAjustarCeldas = True Then
            blnAjustarCeldas = False
            dgv_GruposMed.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        End If
    End Sub

    Private Sub dgv_Medico_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dgv_Medico.Paint
        If blnAjustarCeldas = True Then
            blnAjustarCeldas = False
            dgv_Medico.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        End If
    End Sub

    Private Sub dgv_GruposMed_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_GruposMed.CellClick
        actualizaDtsELEMENTOSMed(CInt(dgv_GruposMed.CurrentRow.Cells("MED_ID").Value))
        'GRUPO_ID = dgv_GruposMed.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click

        opr_pedido.GuardaGrupoMedico(opr_pedido.LeerMaxIdGrupoMedico(), Trim(txt_NombreGrupo.Text), Trim(txt_ObsGrupo.Text))
        actualizaDtsGRUPOMed()
        txt_NombreGrupo.Text = ""
        txt_ObsGrupo.Text = ""
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click

        Dim GRUPO_ID As Integer = dgv_GruposMed.CurrentRow.Cells(1).Value
        opr_pedido.GuardaElementoMedico(GRUPO_ID, CInt(dgv_Medico.CurrentRow.Cells("MED_ID").Value))
        actualizaDtsELEMENTOSMed(med_id)
        'actualizaDtsGRUPOMed()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        txt_NombreGrupo.Text = ""
        txt_ObsGrupo.Text = ""
    End Sub

    Private Sub dgv_ElementosMed_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_ElementosMed.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            If MsgBox("Desea remover al medico " & dgv_ElementosMed.CurrentRow.Cells("MED_NOMBRE").Value & " ?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                'Operaciones al precionar DELETE sobre el grid

                Dim GRUPO_ID As Integer = dgv_GruposMed.CurrentRow.Cells(1).Value
                opr_pedido.EliminaElementoGrupo(GRUPO_ID, CInt(dgv_ElementosMed.CurrentRow.Cells("MED_ID").Value))
                actualizaDtsELEMENTOSMed(GRUPO_ID)
            Else

            End If
        End If
    End Sub

    
    Private Sub cmb_Especialidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Especialidad.SelectedIndexChanged
        If cmb_Especialidad.Text = "Todas" Then
            actualizaDtsMedico(0, 1)
        Else
            actualizaDtsMedico(CInt(Mid(cmb_Especialidad.Text, 101, 110)), 1)
        End If
        dgv_Medico.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
    End Sub

    
End Class