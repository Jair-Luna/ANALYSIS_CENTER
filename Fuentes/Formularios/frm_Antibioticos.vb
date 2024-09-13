Public Class frm_Antibioticos

    Dim frm_refer_main_form As Frm_Main
    Dim dtv_antibiotico As New DataView()
    Dim opr_Test As New Cls_TipoTest()
    Dim byt_flag As Byte  '0 --> Nuevo registro ;  1 -> Actualizar registro
    Dim str_nombre_antiguo As String



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

    Private Sub frm_Antibioticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm


        dgrd_Antibioticos.DataSource = dtv_antibiotico
        opr_Test.LlenarGridAntibiotico(dtv_antibiotico)

        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        btn_Nuevo.Focus()
    End Sub

    Private Sub txt_test_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_test.TextChanged
        opr_Test.ordena_Antibiotico(txt_test.Text, dtv_antibiotico)
    End Sub

    Private Sub dgrd_Antibioticos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Antibioticos.CurrentCellChanged
        'cuando doy click en un registro del grid los datos se actualizan automaticamente 
        'en los cuadros de texto de la parte superior
        On Error Resume Next
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        str_nombre_antiguo = dgrd_Antibioticos.Item(dgrd_Antibioticos.CurrentCell.RowNumber, 1)
        Ctl_txt_Nombre.Text = dgrd_Antibioticos.Item(dgrd_Antibioticos.CurrentCell.RowNumber, 1)
        txt_codigo.Text = dgrd_Antibioticos.Item(dgrd_Antibioticos.CurrentCell.RowNumber, 2)
        txt_orden.texto_Asigna(dgrd_Antibioticos.Item(dgrd_Antibioticos.CurrentCell.RowNumber, 3))
        byt_flag = 1
        Dim dgCell As DataGridCell
        dgCell.ColumnNumber = 2
        dgCell.RowNumber = dgrd_Antibioticos.CurrentCell.RowNumber
        dgrd_Antibioticos.CurrentCell = dgCell
        dgrd_Antibioticos.Select(dgrd_Antibioticos.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Ctl_txt_Nombre.Enabled = True
        Ctl_txt_Nombre.Focus()
        byt_flag = 0
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'mado a guardar los datos guardados
        'verifico si los datos no son vacios
        If (Ctl_txt_Nombre.Text = "") Then
            MsgBox("Ingrese el antibiotico", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            Exit Sub
        End If

        If (txt_codigo.Text = "") Then
            MsgBox("Ingrese el codigo del antibiotico", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            Exit Sub
        End If


        If CInt(txt_orden.texto_Recupera()) <= 9 Then
            MsgBox("Ingrese el orden del antibiotico mayor a 9", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            Exit Sub
        End If

        If txt_orden.texto_Recupera() = "" Then
            MsgBox("Ingrese el orden del antibiotico", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            Exit Sub
        End If

        'verifco si no existe ya esa palabra
        If (opr_Test.BuscarAntibiotico(Ctl_txt_Nombre.Text) = True And byt_flag = 0) Then
            MsgBox("El antibiotico ingresado ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_Nombre.Focus()
            Exit Sub
        End If
        'una vez comprovado todo lo anterior mado a guardar los datos de la bonificacion
        If byt_flag = 0 Then
            'cuando es nuevo registro
            opr_Test.GuardarAntibiotico(Trim(Ctl_txt_Nombre.Text).ToUpper(), Trim(txt_codigo.Text), txt_orden.texto_Recupera())
            Ctl_txt_Nombre.Text = ""
            txt_codigo.text = ""
            txt_orden.texto_Asigna(9)
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            opr_Test.LlenarGridAntibiotico(dtv_antibiotico)
        Else
            'cuando es actualizaciones
            If MsgBox("¿Desea actualizar el registro?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                opr_Test.ActualizarAntibiotico(Trim(Ctl_txt_Nombre.Text).ToUpper(), Trim(txt_codigo.Text).ToUpper(), txt_orden.texto_Recupera(), str_nombre_antiguo)
                Ctl_txt_Nombre.Text = ""
                txt_codigo.Text = ""
                txt_orden.texto_Asigna(9)
                btn_Aceptar.Enabled = False
                btn_Eliminar.Enabled = False
                opr_Test.LlenarGridAntibiotico(dtv_antibiotico)
            Else
            End If
        End If
    End Sub

    Private Sub Ctl_txt_Nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctl_txt_Nombre.TextChanged
        If Ctl_txt_Nombre.Text <> "" Then
            btn_Aceptar.Enabled = True
        Else
            btn_Aceptar.Enabled = False
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        'elimino una bonificacion
        If MsgBox("Desea eliminar el antibiotico?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            opr_Test.EliminaAntibiotico(str_nombre_antiguo)
            Ctl_txt_Nombre.Text = ""
            txt_codigo.Text = ""
            txt_orden.texto_Asigna(9)
            btn_Aceptar.Enabled = False
            btn_Eliminar.Enabled = False
            opr_Test.LlenarGridAntibiotico(dtv_antibiotico)
        End If
    End Sub

  

End Class