Public Class frm_ImpWhaCertificado
    Public frm_refer_main As Frm_Main

    Public opcion As Integer

    Private Sub frm_ImpWhaCertificado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opcion = 0

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        opcion = 1
        Me.Close()
    End Sub

    Private Sub btnWhats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhats.Click
        opcion = 2
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        opcion = 0
        Me.Close()
    End Sub
End Class