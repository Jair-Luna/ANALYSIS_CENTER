Public Class frm_EstCultivos


    Dim frm_refer_main_form As Frm_Main
    Dim opr_Test As New Cls_TipoTest()
    Dim opr_perfil As New Cls_Perfil()
    Dim dtv_test As New DataView()
    Dim str_x As String
    Dim str_y As String
    Dim i, j As Integer
    Dim boo_flag As Boolean



    Private Sub frm_EstCultivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        dgrd_Test.DataSource = dtv_test

        '' LLENO LOS EXAMENES CATALOGADOS DENTRO DE MICROBILOGIA Y SELECCIONADOS CON AB
        opr_Test.LlenarGridEstCultivo(dtv_test)

        '' LLENO LOS PARAMETROS DISPONIBLES PARA CULTIVOS
        opr_Test.LlenarList_ParamCul(lst_ParamMicro)

        '' LLENO LOS PARAMETROS GUARDADOS PARA CULTIVOS
        opr_Test.LlenarList_ParamMicro(lst_ParamPerfil)

    End Sub

    Private Sub pic_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'elimina las funciones activas (ej menu) del formulario MDI.
        'ClickMenu_Principal(Me)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
            Case "pic_min"
                Me.WindowState = FormWindowState.Minimized
                Me.ControlBox = True
                Me.MaximizeBox = False
        End Select
    End Sub

    Private Sub Pic_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'elimina las funciones activas (ej menu) del formulario MDI.
        'ClickMenu_Principal(Me)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
            Case "pic_min"
                Me.WindowState = FormWindowState.Minimized
                Me.ControlBox = True
                Me.MaximizeBox = False
        End Select
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub


    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'En caso de actualizar un PERFIL    
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        If MsgBox("¿Desea actualizar el registro?", MsgBoxStyle.YesNo, "ANALISYS") = vbNo Then
            Exit Sub
        Else
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            opr_perfil.EliminoPerfilMicro()
            opr_perfil.ActualizarPerfilMicro(dtv_test, lst_ParamPerfil)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        opr_Test.LlenarGridEstCultivo(dtv_test)
        opr_Test.LlenarList_ParamCul(lst_ParamMicro)

        '' LLENO LOS PARAMETROS CARGADOS

        opr_Test.LlenarList_ParamMicro(lst_ParamPerfil)
        btn_Aceptar.Enabled = False


    End Sub

  

    Private Sub lst_ParamMicro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_ParamMicro.KeyDown

        If e.KeyCode = Keys.Enter Then
            lst_ParamPerfil.Items.Add(lst_ParamMicro.SelectedItem.ToString)
        End If
    End Sub



    Private Sub lst_ParamCul_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_ParamPerfil.KeyUp
        On Error Resume Next
        If e.KeyData.ToString = "Delete" Then
            lst_ParamPerfil.Items.Remove(lst_ParamPerfil.SelectedItem)
            On Error Resume Next
            lst_ParamPerfil.SelectedIndex = 0
        End If
        If e.KeyCode = 8 Then
            lst_ParamPerfil.Items.Remove(lst_ParamPerfil.SelectedItem)
            On Error Resume Next
            lst_ParamPerfil.SelectedIndex = 0
        End If
        If lst_ParamPerfil.Items.Count > 0 Then
            btn_Aceptar.Enabled = True
        Else
            btn_Aceptar.Enabled = False
        End If
    End Sub

    Private Sub lst_ParamMicro_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_ParamMicro.MouseDown

        lst_ParamMicro.DoDragDrop(lst_ParamMicro.Items.Item(lst_ParamMicro.SelectedIndex), DragDropEffects.Copy)
        str_x = lst_ParamMicro.Items.Item(lst_ParamMicro.SelectedIndex)
    End Sub

    Private Sub lst_ParamPerfil_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lst_ParamPerfil.DragEnter
        ' Make sure that the format is text.
        Dim int_i As Integer
        Dim str_y As String
        Dim boo_flag As Boolean
        boo_flag = False
        If (lst_ParamPerfil.Items.Count() > 0) Then
            For int_i = 1 To lst_ParamPerfil.Items.Count()
                If (lst_ParamMicro.Items.Item(lst_ParamMicro.SelectedIndex)) = lst_ParamPerfil.Items.Item(int_i - 1) Then
                    boo_flag = True
                    Exit For
                End If
            Next
        End If
        If (e.Data.GetDataPresent(DataFormats.Text) And boo_flag = False) Then
            ' Allow drop.
            e.Effect = DragDropEffects.Copy
        Else
            ' Do not allow drop.
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Private Sub lst_ParamPerfil_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lst_ParamPerfil.DragDrop
        ' Copy the text to the second listBox.
        lst_ParamPerfil.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
        If lst_ParamPerfil.Items.Count > 0 Then
            btn_Aceptar.Enabled = True
        Else
            btn_Aceptar.Enabled = False
        End If
    End Sub

  
    Private Sub btn_imprimirCul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirCul.Click
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_EstCultivo()
        'INSTRUCCION SQL PARA OBTENER TODO LOS DATOS 
        str_sql = "select t2.tes_nombre as tes_id, t1.TES_NOMBRE,  t2.TES_NOMBRE from test_cultivo as tc, test_cultivo as tc2, test as t1, test as t2 where t1.tes_id = tc.tcu_id and t2.tes_id = tc.tes_id and t2.tes_id = tc2.tes_id and tc2.tcu_id = t1.tes_id;"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Parametros Cultivos"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    
End Class