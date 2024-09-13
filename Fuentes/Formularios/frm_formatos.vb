
Public Class frm_formatos

    Dim opr_Param As New Cls_Parametros()
    Dim opr_test As New Cls_TipoTest()
    Dim dtv_formatos As New DataView()
    Dim dtv_parametros As New DataView()
    Public frm_refer_main As Frm_Main
    Public tes_id As Integer
    Dim var_area As Integer
    Dim var_tim As Integer
    Dim oper_test As New Cls_TipoTest()






    Private Sub frm_formatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtr_fila As DataRow


        lbl_AreaFormato.Text = Mid(opr_test.ConsultaAreaTest(tes_id), 1, 100)
        var_area = CInt(Mid(opr_test.ConsultaAreaTest(tes_id), 101, 50))

        lbl_TestFormato.Text = opr_test.ConsultaNombreTest(tes_id)
        var_tim = opr_test.ConsultaTimId(tes_id)

        cmb_NoCampos.Text = CStr(opr_test.LeerParametrosTest(tes_id))



        dgrd_parametros.DataSource = dtv_parametros
        opr_test.LlenarGridtestHijos(tes_id, dtv_parametros)
        If CInt(cmb_NoCampos.Text) > 0 Then
            btn_Nuevo.Enabled = False
        Else
            btn_Nuevo.Enabled = True
        End If

        EtiquetasPanel(cmb_NoCampos.Text, dgrd_parametros)

    End Sub



    Sub EtiquetasPanel(ByVal Nparametros As Integer, ByVal dgrd_parametros As DataGrid)
        Dim i As Integer
        Dim topPnl As Integer = 10
        lbl_msg.Text = ""
        pnl.Controls.Clear()
        'dgrd_muestra.Item(i, 22)
        If Nparametros > 0 Then

            For i = 1 To Nparametros

                Dim pnl_parametros As New Panel()
                'Dim lbl_lab As New Label()
                Dim lbl_parametro As New Label()
                Dim txt_parametro As New TextBox()

                pnl_parametros.Height = 60
                pnl_parametros.Width = 160
                pnl_parametros.Left = 40
                pnl_parametros.Top = topPnl
                pnl_parametros.BackColor = Color.White
                topPnl = topPnl + pnl_parametros.Height + 10

                Dim MyFont As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel)
                lbl_parametro.BorderStyle = BorderStyle.FixedSingle
                lbl_parametro.TextAlign = ContentAlignment.MiddleLeft
                lbl_parametro.Text = dgrd_parametros.Item(i, 1)  'lbl_encabezado.Text   'dtt_muestras.Rows(i).Item(1).ToString
                lbl_parametro.Height = 20
                lbl_parametro.Width = 150
                lbl_parametro.Left = 0
                lbl_parametro.Top = 0
                lbl_parametro.Font = MyFont
                pnl.Controls.Add(lbl_parametro)

                'lbl_paciente.BorderStyle = BorderStyle.FixedSingle
                'txt_parametro.TextAlign = ContentAlignment.MiddleLeft
                txt_parametro.Text = dgrd_parametros.Item(i, 10) 'lbl_nombres.Text
                txt_parametro.Height = 20
                txt_parametro.Width = 150
                txt_parametro.Left = 0
                txt_parametro.Top = 20
                txt_parametro.Font = MyFont
                pnl.Controls.Add(pnl_parametros)

                'PANEL MAESTRO
                pnl_parametros.Controls.Add(lbl_parametro)
                pnl_parametros.Controls.Add(txt_parametro)
            Next
        Else
            lbl_msg.Text = "El examen no tiene parametros, para crear utilice NUEVO"
        End If
    End Sub




    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Dim i As Integer

        oper_test.guardaTestAsistente(dgrd_parametros.Item(i, 0), var_area, "", var_tim, "", 0, "", CInt(cmb_NoCampos.Text), "MUESTRAºTECNICAºVALOR REFERENCIALºMUESTRA ANALIZADA")

    End Sub

    
    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        cmb_NoCampos.Enabled = True

    End Sub

    Private Sub cmb_NoCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_NoCampos.SelectedIndexChanged
        Dim i As Integer
        Dim topPnl As Integer = 10
        Dim var_nombres As String = "MUESTRAºTECNICAºVALOR REFERENCIALºMUESTRA ANALIZADA"
        Dim arre_nombres As String()
        arre_nombres = Split(var_nombres, "º")

        lbl_msg.Text = ""
        pnl.Controls.Clear()

        If CInt(cmb_NoCampos.Text) > 0 Then

            For i = 0 To CInt(cmb_NoCampos.Text)

                Dim pnl_parametros As New Panel()
                'Dim lbl_lab As New Label()
                Dim lbl_parametro As New Label()
                Dim txt_parametro As New TextBox()

                pnl_parametros.Height = 60
                pnl_parametros.Width = 160
                pnl_parametros.Left = 40
                pnl_parametros.Top = topPnl
                pnl_parametros.BackColor = Color.White
                topPnl = topPnl + pnl_parametros.Height + 10

                Dim MyFont As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel)
                lbl_parametro.BorderStyle = BorderStyle.FixedSingle
                lbl_parametro.TextAlign = ContentAlignment.MiddleLeft
                lbl_parametro.Text = arre_nombres(i)  'lbl_encabezado.Text   'dtt_muestras.Rows(i).Item(1).ToString
                lbl_parametro.Height = 20
                lbl_parametro.Width = 150
                lbl_parametro.Left = 0
                lbl_parametro.Top = 0
                lbl_parametro.Font = MyFont
                pnl.Controls.Add(lbl_parametro)

                'lbl_paciente.BorderStyle = BorderStyle.FixedSingle
                'txt_parametro.TextAlign = ContentAlignment.MiddleLeft
                txt_parametro.Text = "" 'lbl_nombres.Text
                txt_parametro.Height = 20
                txt_parametro.Width = 150
                txt_parametro.Left = 0
                txt_parametro.Top = 20
                txt_parametro.Font = MyFont
                pnl.Controls.Add(pnl_parametros)

                'PANEL MAESTRO
                pnl_parametros.Controls.Add(lbl_parametro)
                pnl_parametros.Controls.Add(txt_parametro)
            Next
        Else
            lbl_msg.Text = "Debe escojer al menos 1 parametro"
        End If
    End Sub
End Class