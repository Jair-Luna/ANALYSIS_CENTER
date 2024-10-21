Public Class frm_EtiquetasAlergia

    Public frm_refer_main As Frm_Main
    Dim opr_res As New Cls_Resultado()
    Dim dtv_Vacunas As New DataView()
    Dim opr_pedido As New Cls_Pedido


    Private Sub frm_EtiquetasAlergia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dgrd_Vacunas.DataSource = dtv_Vacunas
        opr_pedido.LlenarGridVacunas("B01", dtv_Vacunas)
    End Sub

    
    Private Sub Dgrd_Vacunas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Vacunas.CurrentCellChanged
        Dim currentRow As Integer = Dgrd_Vacunas.CurrentCell.RowNumber

        ' Seleccionar toda la fila
        Dgrd_Vacunas.Select(currentRow)

        'ver_propiedades()
        btn_Imp1.Enabled = False
        btn_Imp2.Enabled = False
        btn_Imp3.Enabled = False
        btn_Imp4.Enabled = False

        cmb_Cantidad.Text = Dgrd_Vacunas.Item(Dgrd_Vacunas.CurrentCell.RowNumber, 6)
    End Sub
End Class