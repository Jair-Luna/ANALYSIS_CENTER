Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Data

Imports System.Data.Odbc

Public Class frm_FiltroAreas
    Inherits System.Windows.Forms.Form
    Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_invitado As New Cls_Invitado()
    Dim opr_user As New Cls_Usuario()
    Dim dts_listaM As New DataSet
    Dim opr_pedido As New Cls_Pedido()
    Public frm_refer_main As Frm_Main
    Public CadenaFiltro As String = Nothing
    Private WithEvents dtt_areas As New DataTable("Registros")
    Dim frm_refer_main_form As Frm_Main
    Dim fechaIni As String = Nothing
    Dim fechaFin As String = Nothing
    Dim Prioridad As String = Nothing
    Dim arregloAreas As String()
    Dim CadenaAreas As String = Nothing
    Public LabOcup As Byte
    Public filtroOrdenes As String
    Dim arr_datos As New ArrayList()
    Dim str_areas As String = Nothing



    Private Sub frm_FiltroAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm

        

        dtt_areas.DefaultView.AllowNew = False
        dtt_areas.DefaultView.AllowDelete = False
        Dim dtc_columna1 As New DataColumn("are_id", GetType(System.String))
        Dim dtc_columna2 As New DataColumn("are_nombre", GetType(System.String))
        dtt_areas.Columns.Add(dtc_columna1)
        dtt_areas.Columns.Add(dtc_columna2)

        lbl_LabOcup.Text = CStr(LabOcup)
        Dim int_i As Integer

        Dim arr_nombre As New ArrayList()
        'lleno combo prioridad con secuencias
        opr_pedido.LlenarComboPrioridadTODOS(cmb_Prioridad, True)

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, LabOcup, str_areas, arr_nombre)

        cmb_area.Items.Add("TODAS".PadRight(60) & "00".PadRight(10))
        For int_i = 0 To arr_datos.Count - 1
            ''' str_areas = str_areas & arr_datos(int_i) & ","
            cmb_area.Items.Add(arr_nombre(int_i).ToString.PadRight(60) & arr_datos(int_i).ToString.PadRight(10))
        Next


        cmb_Prioridad.SelectedIndex = 0
        cmb_area.SelectedIndex = 0
        cmb_area.Focus()


    End Sub

    Private Sub cmb_area_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_area.KeyPress
        Dim int_indice As Integer = 0
        Dim sng_flag As Single = 0

        If e.KeyChar = (Convert.ToChar(Keys.Enter)) Then

            For int_indice = 0 To dtt_areas.Rows.Count - 1
                If dtt_areas.Rows(int_indice).Item(1).ToString = Trim(Mid(cmb_area.Text, 1, 60)) Then sng_flag = 1
            Next
            If sng_flag = 0 Then
                lbl_msg.Text = ""
                Dim dtr_fila As DataRow
                dtr_fila = dtt_areas.NewRow
                dtr_fila(0) = Trim(Mid(cmb_area.Text, 61, cmb_area.Text.Length))
                dtr_fila(1) = Trim(Mid(cmb_area.Text, 1, 60))
                dtt_areas.Rows.Add(dtr_fila)
            Else
                lbl_msg.Text = "El area seleccionada ya se encuentra en la lista."
            End If
            dgrd_areas.DataSource = dtt_areas
            dgrd_areas.NavigateTo(0, "Registros")
        End If

        
        If dtt_areas.Rows.Count >= 1 Then
            btn_buscar.Enabled = True
        Else
            btn_buscar.Enabled = False
        End If

    End Sub

    Public Function CreaCadenaAreas(ByVal CadenaFiltro As String) As String
        'recorro el grid y acumulo los ID de las areas
        Dim int_indice As Integer = 0
        Dim int_cantidad As Integer = 0

        For int_indice = 0 To dtt_areas.Rows.Count - 1
            CreaCadenaAreas = CreaCadenaAreas & dtt_areas.Rows(int_indice).Item(0) & ","
        Next
        CreaCadenaAreas = CadenaFiltro & CreaCadenaAreas
    End Function

    
    Private Function FormularioActivo(ByVal _form As Form) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next
        Return Nothing
    End Function



    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim prioridad As String()
        Dim i As Integer

        ''If LabOcup = False Then

        If dtt_areas.Rows.Count > 0 Then

            For i = 0 To dtt_areas.Rows.Count - 1
                CadenaAreas = CadenaAreas & dtt_areas.Rows(i).Item(0).ToString() & ","

            Next
            If CadenaAreas = "00," Then
                CadenaAreas = ""
                For i = 0 To arr_datos.Count - 1
                    CadenaAreas = CadenaAreas & arr_datos(i) & ","
                Next
            End If



            fechaIni = Format(dtp_fi.Value, "dd/MM/yyyy")
            fechaFin = Format(dtp_ff.Value, "dd/MM/yyyy")
            prioridad = Split(cmb_Prioridad.Text, "/")
            CadenaFiltro = fechaIni & "," & fechaFin & "," & Trim(prioridad(0)) & "," & Trim(prioridad(1) & "," & Trim(prioridad(2)) & "," & CadenaAreas)
            g_ConvenioSecuencia = Trim(prioridad(0)) & "," & Trim(prioridad(1)) & "," & Trim(prioridad(2))
        Else
            MsgBox("No ha seleccionado ninguna area.", MsgBoxStyle.Exclamation, "ANALISYS")
        End If
        If CadenaFiltro <> "" Then
            Me.Close()
            If chk_PorTest.Checked Then

                If cmb_area.Text <> "TODOS" Then

                    Dim frm_MDIChild As New frm_Ing_Resul_porTest()
                    If FormularioActivo(frm_MDIChild) Then
                        frm_MDIChild.Close()
                        Dim frm_MDIChild1 As New frm_Ing_Resul_porTest()
                        frm_MDIChild1.Tag = CadenaFiltro
                        frm_MDIChild1.LabOcup = CByte(lbl_LabOcup.Text)
                        'frm_MDIChild.ConvenioSecuencia = Trim(prioridad(0)) & "," & Trim(prioridad(1)) & "," & Trim(prioridad(2))

                        frm_MDIChild1.ShowDialog(Me.ParentForm)
                    End If
                    'frm_MDIChild.Close()
                    frm_MDIChild.Tag = CadenaFiltro
                    frm_MDIChild.LabOcup = CByte(lbl_LabOcup.Text)

                    If FormularioActivo(frm_MDIChild) = False Then
                        frm_MDIChild.ShowDialog(Me.ParentForm)
                    End If
                Else
                    opr_pedido.VisualizaMensaje("Debe escjer un convenio", 250)

                End If

            Else

                Dim frm_MDIChild As New frm_ValidacionRes()
                If FormularioActivo(frm_MDIChild) Then
                    frm_MDIChild.Close()
                    Dim frm_MDIChild1 As New frm_ValidacionRes()
                    frm_MDIChild1.Tag = CadenaFiltro
                    frm_MDIChild1.LabOcup = LabOcup
                    'frm_MDIChild.ConvenioSecuencia = Trim(prioridad(0)) & "," & Trim(prioridad(1)) & "," & Trim(prioridad(2))

                    frm_MDIChild1.ShowDialog(Me.ParentForm)
                End If
                'frm_MDIChild.Close()
                frm_MDIChild.Tag = CadenaFiltro
                frm_MDIChild.LabOcup = LabOcup
                If FormularioActivo(frm_MDIChild) = False Then
                    frm_MDIChild.ShowDialog(Me.ParentForm)
                End If
                'frm_MDIChild.ConvenioSecuencia = Trim(prioridad(0)) & "," & Trim(prioridad(1)) & "," & Trim(prioridad(2))
            End If
        End If
        
    End Sub

    'Private Sub dgrd_areas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_areas.CurrentCellChanged
    '    'If dtt_areas.Rows.Count > 0 Then
    '    dtt_areas.Rows(dgrd_areas.CurrentCell.RowNumber).Delete()

    '    'Call RealizaCambios()
    '    'End If
    'End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        ''If CadenaFiltro = "" Then
        Me.Close()
        ''End If
    End Sub

    Private celdaanteriorped As Short

    Private Sub Grid_Seleccionar_Celda_Ped()
        On Error Resume Next
        'función que no permite que exista selección multiple para el datagrid,
        'y para que luego de cada evento la celda continue con el enfoque
        dgrd_areas.UnSelect(celdaanteriorped)
        dgrd_areas.Select(dgrd_areas.CurrentCell.RowNumber)
        celdaanteriorped = dgrd_areas.CurrentCell.RowNumber
    End Sub


    Private Sub dgrd_areas_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_areas.KeyUp
        Grid_Seleccionar_Celda_Ped()
    End Sub

    Private Sub dgrd_areas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgrd_areas.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER sobre el grid
        ElseIf e.KeyCode = Keys.Delete Then
            'Operaciones al precionar DELETE sobre el grid
            dtt_areas.Rows.Item(dgrd_areas.CurrentCell.RowNumber).Delete()
        End If
        Grid_Seleccionar_Celda_Ped()
    End Sub
End Class