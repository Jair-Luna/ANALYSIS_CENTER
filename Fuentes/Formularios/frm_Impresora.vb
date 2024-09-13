Imports System
Imports System.Drawing.Printing

Public Class frm_Impresora
    Dim opr_Equipo As New Cls_equipos()
    Dim frm_refer_main_form As Frm_Main
    Dim dtv_impresoras As New DataView()
    Dim str_nombre_antiguo As String


    Private Sub Form1_Load( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm

        Dim pd As New PrintDocument
        Dim Impresoras As String

        ' Default printer      
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        ' recorre las impresoras instaladas  
        For Each Impresoras In PrinterSettings.InstalledPrinters
            cmb_impresoras.Items.Add(Impresoras.ToString)
        Next
        ' selecciona la impresora predeterminada  
        cmb_impresoras.Text = s_Default_Printer

        cmb_reportes.SelectedIndex = 0

        dgrd_Impresoras.DataSource = dtv_impresoras
        opr_Equipo.LlenarGridImpresoras(dtv_impresoras)


        
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If (cmb_reportes.Text = "ESCOJA UN REPORTE") Then
            MsgBox("Escoja un reporte", MsgBoxStyle.Information, "ANALISYS")
            cmb_reportes.Focus()
            Exit Sub
        End If
        Dim reporte As String

        'Resultados AREA
        'Resultados TODO
        'Factura TOTAL
        'Factura DETALLE
        'Nota de venta TOTAL
        'Nota de venta DETALLE
        'Codigo de barras
        'Reportes ESTADISTICA


        Select Case Trim(cmb_reportes.Text)
            Case "Resultados AREA" : reporte = "AnalisysLAB.rpt_entregaresultados"
            Case "Resultados TODO" : reporte = "AnalisysLAB.rpt_entregaContinua"
            Case "Factura TOTAL" : reporte = "AnalisysLAB.rpt_factura"
            Case "Factura DETALLE" : reporte = "AnalisysLAB.rpt_factura"
            Case "Nota de venta TOTAL" : reporte = "AnalisysLAB.rpt_factura"
            Case "Nota de venta DETALLE" : reporte = "AnalisysLAB.rpt_factura"
            Case "ESTADISTICA" : reporte = "" 'SE VAN POR DEFECTO A LA IMPRESORAR PRE DETERMINADA
        End Select

        opr_Equipo.GuardarImpresora(opr_Equipo.LeerMaxCodImp(), Trim(cmb_impresoras.Text).ToUpper(), Trim(cmb_reportes.Text), reporte)
        opr_Equipo.LlenarGridImpresoras(dtv_impresoras)

    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If MsgBox("Desea eliminar la asignacion de la impresora?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            opr_Equipo.EliminaImpresora(str_nombre_antiguo)
            'Ctl_txt_Nombre.Text = ""
            'txt_codigo.Text = ""
            'txt_orden.texto_Asigna(9)
            'btn_Aceptar.Enabled = False
            'btn_Eliminar.Enabled = False
            opr_Equipo.LlenarGridImpresoras(dtv_impresoras)
        End If
    End Sub

    Private Sub dgrd_Impresoras_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_Impresoras.CurrentCellChanged
        str_nombre_antiguo = dgrd_Impresoras.Item(dgrd_Impresoras.CurrentCell.RowNumber, 2)
        'Ctl_txt_Nombre.Text = dgrd_Antibioticos.Item(dgrd_Antibioticos.CurrentCell.RowNumber, 1)
        'txt_codigo.Text = dgrd_Antibioticos.Item(dgrd_Antibioticos.CurrentCell.RowNumber, 2)
        'txt_orden.texto_Asigna(dgrd_Antibioticos.Item(dgrd_Antibioticos.CurrentCell.RowNumber, 3))
        'byt_flag = 1
        Dim dgCell As DataGridCell
        dgCell.ColumnNumber = 2
        dgCell.RowNumber = dgrd_Impresoras.CurrentCell.RowNumber
        dgrd_Impresoras.CurrentCell = dgCell
        dgrd_Impresoras.Select(dgrd_Impresoras.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub
End Class