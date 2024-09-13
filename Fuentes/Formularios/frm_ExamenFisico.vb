Public Class frm_ExamenFisico

    Private Sub frm_ExamenFisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each controlText As Windows.Forms.Control In Me.grp_ExFisico.Controls
            If TypeOf controlText Is TextBox Then
                CType(controlText, TextBox).Clear()
            End If
        Next
    End Sub
End Class