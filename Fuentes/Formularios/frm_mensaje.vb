Public Class frm_mensaje

    Public msg As String
    Public tiempo As Integer
    Public frm_refer_main As Frm_Main


    Private Sub frm_mensaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_msg.Text = msg
        'Timer1.Interval = tiempo
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Increment(20)
            Timer1.Interval = tiempo
        Else
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
End Class