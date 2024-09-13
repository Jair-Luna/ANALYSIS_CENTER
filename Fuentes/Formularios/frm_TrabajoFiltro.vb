Public Class frm_TrabajoFiltro

    Public frm_refer_main As Frm_Main
    Public str_desde_hasta As String
    Dim opr_negocio As New Cls_Pedido
    

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        On Error Resume Next
        Dim ctl As Form
        Dim ctl2 As frm_Trabajo

        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        If Ctl_txt_Desde.texto_Recupera() = "" Or Ctl_txt_Hasta.texto_Recupera() = "" Then
            opr_negocio.VisualizaMensaje("Ingrese parametros desde y/o hasta", g_tiempo)
        Else
            Me.Tag = Ctl_txt_Desde.texto_Recupera() & "/" & Ctl_txt_Hasta.texto_Recupera()
        End If
        Me.Close()
    End Sub

    Private Sub frm_TrabajoFiltro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ctl_txt_Desde.Focus()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class