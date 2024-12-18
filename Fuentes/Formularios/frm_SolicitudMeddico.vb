
Public Class frm_SolicitudMeddico

    Public var_txt_Solicitud As String
    Public var_meddico As String

    Private Sub frm_SolicitudMeddico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Solicitud.Multiline = True
        txt_Solicitud.ScrollBars = ScrollBars.Vertical
        txt_Solicitud.Text = var_txt_Solicitud.Replace("\n", Environment.NewLine).Replace("\r\n", Environment.NewLine).Replace("\r", Environment.NewLine)
        Me.Text = var_meddico
    End Sub
End Class