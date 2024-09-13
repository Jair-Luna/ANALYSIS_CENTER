Public Class frm_Cie10Gestion

    Private WithEvents dtt_cie As New DataTable("Registros")
    Public frm_refer_main As Frm_Main
    Dim opr_res As New Cls_Resultado()
    Dim dtv_Cie As New DataView()
    Dim opr_pedido As New Cls_Pedido()
    Dim sw_opera As String = Nothing

    Private Sub Limpia()
        txt_Cod3.Text = ""
        txt_Cod4.Text = ""
        txt_Des3.Text = ""
        txt_Des4.Text = ""

    End Sub


    Private Sub frm_Cie10Gestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dgrd_Cie10.DataSource = dtv_Cie
        opr_pedido.LlenarGridCie10(dtv_Cie, "")

    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Limpia()
        txt_Cod3.Focus()
        sw_opera = "Nuevo"
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Select Case sw_opera
            Case "Nuevo"
                If opr_pedido.GestionaCie10(Trim(txt_Cod3.Text), Trim(txt_Des3.Text), Trim(txt_Cod4.Text), Trim(txt_Des4.Text), "Insertar") = True Then
                    opr_pedido.LlenarGridCie10(dtv_Cie, "")
                    opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
                Else
                    opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
                End If

            Case "Actualiza"
                If opr_pedido.GestionaCie10(Trim(txt_Cod3.Text), Trim(txt_Des3.Text), Trim(txt_Cod4.Text), Trim(txt_Des4.Text), "Actualizar") = True Then
                    opr_pedido.LlenarGridCie10(dtv_Cie, "")
                    opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
                Else
                    opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
                End If
        End Select

        sw_opera = ""

    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If opr_pedido.GestionaCie10(Trim(txt_Cod3.Text), Trim(txt_Des3.Text), Trim(txt_Cod4.Text), Trim(txt_Des4.Text), "Eliminar") = True Then
            opr_pedido.LlenarGridCie10(dtv_Cie, "")
            opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
        Else
            opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
        End If
    End Sub

    Private Sub Dgrd_Cie10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgrd_Cie10.Click
        txt_Cod3.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 0)
        txt_Des3.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 1)
        txt_Cod4.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 2)
        txt_Des4.Text = Dgrd_Cie10.Item(Dgrd_Cie10.CurrentCell.RowNumber, 3)
        sw_opera = True
    End Sub
End Class