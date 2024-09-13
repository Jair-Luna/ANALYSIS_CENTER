Imports System
Imports System.Windows.Forms
Imports System.IO

Public Class frm_BuscaHistorico
    Public frm_refer_main As Frm_Main
    Public pac_id As String = Nothing
    Dim opr_pedido As New Cls_Pedido()
    Dim dtv_pedido As New DataView()
    Public dtt_pedido As New DataTable("Registros")

    Dim dtv_examenes As New DataView()
    Public dtt_examenes As New DataTable("Registros2")


    Private dtv_pedido2 As New DataView(dtt_pedido)


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub frm_BuscaHistorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        dgrd_pedidos.DataSource = dtv_pedido
        'lleno el grid con los datos de los pedidos
        opr_pedido.LlenarGridPedidoHistorico(dtv_pedido, pac_id)

    End Sub

    Private Sub dgrd_pedidos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_pedidos.CurrentCellChanged
        'int_codigo = dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 0)

        dgrd_examenes.DataSource = dtv_examenes
        opr_pedido.LlenarGridPedidoHistoricoExamenes(dtv_examenes, CLng(dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 0)))

        'opr_pedido.LlenarGridUnPedidoHistorico(dtt_pedido, "", CLng(dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 0)))

        'dgrd_examenes.DataSource = dtv_examenes
        'opr_Test.LlenarGridtestRangos(dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 0), dtv_examenes)
    End Sub

    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        carga_orden()
    End Sub

    Private Sub carga_orden()
        On Error Resume Next
        Dim ctl As Form
        Dim ctl2 As frm_Pedido
        Dim opr_pedido As New Cls_Pedido()

        'cargo en el tag del formulario pedido los datos del pacietne 
        'cierro este formulario y activo el formulario de pedido
        For Each ctl In frm_refer_main.MdiChildren
            If ctl.Name = "frm_Pedido" Then
                ctl2 = ctl
                ctl2.Tag = dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 0).ToString & "/" & dgrd_pedidos.Item(dgrd_pedidos.CurrentCell.RowNumber, 3).ToString
                ctl2.LLena_datos_paciente_His()
                ctl.Activate()
            End If
        Next
        Me.Close()
    End Sub

End Class