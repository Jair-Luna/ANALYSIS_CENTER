Public Class frm_Autocompletar

    Dim frm_refer_main_form As Frm_Main
    Dim opr_Area As New Cls_Areas()
    Dim opr_Test As New Cls_TipoTest()
    Dim dtv_palabra As New DataView()
    Dim dtv_test As New DataView()
    Dim dtv_Item As New DataView()
    Dim byt_flag As Byte  '0 --> Nuevo registro ;  1 -> Actualizar registro
    Dim str_nombre_antiguo As String
    Dim int_auto_id As Integer



    Private Sub frm_Autocompletar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm

        opr_Area.LlenarCmb_AreaComp(cmb_Area)

        dgrd_Test.DataSource = dtv_test
        opr_Test.LlenarGridtest(dtv_test, CInt(Trim(Mid(cmb_Area.Text, 151, 10))))

        '''dgrd_AutoCompletar.DataSource = dtv_palabra
        '''opr_Test.LlenarGridPalabra(dtv_palabra, CInt(Trim(Mid(cmb_Area.Text, 151, Len(cmb_Area.Text)))))

        '''btn_Aceptar.Enabled = False
        '''btn_Eliminar.Enabled = False
        '''btn_Nuevo.Focus()
        'dgrd_AutoCompletar.SetDataBinding(opr_Area.LeerAutoCompletar(), "RegistrosComp")


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

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_test_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_test.TextChanged
        opr_Test.ordena_Palabra(txt_test.Text, dtv_palabra)
    End Sub

    Private Sub cmb_Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Area.SelectedIndexChanged
        'opr_Area.LlenarCmb_AreaComp(cmb_Area)

        dgrd_Test.DataSource = dtv_test
        opr_Test.LlenarGridtest(dtv_test, CInt(Trim(Mid(cmb_Area.Text, 151, 10))))

    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Ctl_txt_Nombre.Enabled = True
        Ctl_txt_Nombre.Focus()
        byt_flag = 0
    End Sub

    Private Sub Ctl_txt_Nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_Nombre.TextChanged
        If Ctl_txt_Nombre.Text <> "" Then
            btn_Aceptar.Enabled = True
        Else
            btn_Aceptar.Enabled = False
        End If
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'mado a guardar los datos guardados
        'verifico si los datos no son vacios
        If (Ctl_txt_Nombre.Text = "") Then
            MsgBox("Ingrese la palabra", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            Exit Sub
        End If
        'verifco si no existe ya esa palabra
        If (opr_Test.BuscarPalabra(Ctl_txt_Nombre.Text, CInt(Trim(Mid(cmb_Area.Text, 151, Len(cmb_Area.Text))))) = True And byt_flag = 0) Then
            MsgBox("La palabra ingresada ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            Exit Sub
        End If
        'una vez comprovado todo lo anterior mado a guardar los datos de la bonificacion
        If byt_flag = 0 Then
            'cuando es nuevo registro
            opr_Test.GuardarPalabra(Trim(Ctl_txt_Nombre.Text), CInt(Trim(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0))))
            Ctl_txt_Nombre.Text = ""
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            opr_Test.LlenarGridPalabra(dtv_Item, Trim(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0)))
        Else
            'cuando es actualizaciones
            If MsgBox("¿Desea actualizar el registro?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                opr_Test.ActualizarPalabra(Trim(Ctl_txt_Nombre.Text), CInt(Trim(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0))), str_nombre_antiguo)
                Ctl_txt_Nombre.Text = ""
                btn_Aceptar.Enabled = False
                btn_Eliminar.Enabled = False
                opr_Test.LlenarGridPalabra(dtv_palabra, CInt(Trim(Mid(cmb_Area.Text, 151, Len(cmb_Area.Text)))))
            Else
            End If
        End If
    End Sub

    

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'elimino una bonificacion
        If MsgBox("Desea eliminar la palabra?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            opr_Test.EliminaPalabra(str_nombre_antiguo, int_auto_id)
            Ctl_txt_Nombre.Text = ""
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            'opr_Test.LlenarGridAntibiotico(dtv_palabra)
        End If
    End Sub

  
    Private Sub btn_imprimirAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimirAuto.Click
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'Dim str_sql As String
        'Dim obj_reporte As New rpt_AutoCompletado()
        ''INSTRUCCION SQL PARA OBTENER TODO LOS DATOS 
        'str_sql = "SELECT TA.AUTO_ID, TA.AUTO_NOMBRE, T.TES_ID, T.TES_NOMBRE FROM tipo_autocompletar AS TA, TEST AS T WHERE T.TES_ID = TA.TES_ID order by TA.TES_ID, TA.AUTO_ID;"
        'Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte, , , , ,1)
        'frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        'frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        'frm_MDIChild.Text = "Autocompletado Areas"
        'frm_refer_main_form.Crea_formulario(frm_MDIChild)
        'Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dgrd_Test_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Test.CurrentCellChanged
        On Error Resume Next
        dgrd_Items.DataSource = dtv_Item
        opr_Test.LlenarGridPalabra(dtv_Item, Trim(dgrd_Test.Item(dgrd_Test.CurrentCell.RowNumber, 0)))
        btn_Nuevo.Enabled = True
    End Sub

    Private Sub dgrd_Items_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Items.CurrentCellChanged
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        int_auto_id = dgrd_Items.Item(dgrd_Items.CurrentCell.RowNumber, 0)
        str_nombre_antiguo = dgrd_Items.Item(dgrd_Items.CurrentCell.RowNumber, 1)
        Ctl_txt_Nombre.Text = dgrd_Items.Item(dgrd_Items.CurrentCell.RowNumber, 1)
        byt_flag = 1
        Dim dgCell As DataGridCell
        dgCell.ColumnNumber = 2
        dgCell.RowNumber = dgrd_Items.CurrentCell.RowNumber
        dgrd_Items.CurrentCell = dgCell
        dgrd_Items.Select(dgrd_Items.CurrentCell.RowNumber)
    End Sub
End Class