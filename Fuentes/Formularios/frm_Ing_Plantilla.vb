Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.SqlClient
Imports MessagingToolkit.QRCode.Codec




Public Class frm_Ing_Plantilla

    Inherits System.Windows.Forms.Form
    Public aareas As String = Nothing
    Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_invitado As New Cls_Invitado()
    Dim dts_listaM As New DataSet
    Dim opr_pedido As New Cls_Pedido()
    Public frm_refer_main As Frm_Main
    Dim dts_trabajo As DataSet
    Dim str_antecedentes, str_medicamentos, str_obs As String
    Dim dtt_biometria As DataTable
    Dim dtv_biometria As DataView
    Dim boo_guardar As Boolean = False  'Variable que permite controlar si se almaceno o no un resultado
    Dim opr_res As New Cls_Resultado()
    Public dtt_res As New DataTable("Registros")
    Dim dtv_resp As New DataView(dtt_res)
    Dim boo_error As Boolean = False
    Public dtt_resAB As New DataTable("RegistrosRESAB")
    Public dtv_resAB As New DataView(dtt_resAB)

    Public dtt_AB As New DataTable("RegistrosAB")
    Public dtv_AB As New DataView(dtt_AB)

    Dim str_edad As String = ""
    Public ReceptaAreas As String = Nothing
    Public filtroOrdenes As String = Nothing
    Public abrev As String = Nothing
    Public ped_fecing As String = Nothing
    Public Indice As Integer = 0
    Public DatosTag As String = Nothing


    Private WithEvents cmb_resultado As New ComboBox()
    Private WithEvents cmb_resultadoAB As New ComboBox()

    Private boo_cambiaTam As Boolean = False

    'Código para hacer sonar la alarma
    Public Const SND_ASYNC = &H1 ' play asynchronously
    Public Const SND_LOOP = &H8 ' loop the sound until next sndPlaySound
    Public Const SND_NOSTOP = &H10 ' don't stop any currently playing sound
    Public Const SND_NOWAIT = &H2000 ' don't wait if the driver is busy

    Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As String, ByVal hModule As Long, ByVal dwFlags As Long) As Long
    Dim frm_refer_main_form As Frm_Main

    Dim orden As String()
    Dim valores As String = Nothing
    Dim paramMol As String()
    Dim info As String()
    Dim str_sql As String = Nothing
    Public LabOcup As Byte


    





    Public Function inicia_Antibiograma(ByVal area As Integer)
        On Error Resume Next
        Dim int_tam As Short
        Dim sender As Object
        Dim Coleccion As New AutoCompleteStringCollection
        CargarColeccion(Coleccion, 22)
        'cmb_resultadoAB.BorderStyle = BorderStyle.None
        cmb_resultadoAB.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmb_resultadoAB.AutoCompleteSource = AutoCompleteSource.CustomSource
        cmb_resultadoAB.AutoCompleteCustomSource = Coleccion

        int_tam = 150


        AddHandler dgtc_abRes.TextBox.Enter, AddressOf Despliega_resultadoAB
        AddHandler dgtc_abRes.TextBox.MouseEnter, AddressOf Despliega_resultadoAB

        'AddHandler dgtc_Resul.TextBox.MouseDoubleClick, AddressOf TextoDblClick
        'combo de laboratotio
        cmb_resultadoAB.Font = New Font("Courier New", 8.2!, FontStyle.Regular)
        'txt_resultado.DropDownStyle = ComboBoxStyle.DropDown
        cmb_resultadoAB.Width = int_tam - 5
        dgtc_abRes.TextBox.Width = int_tam
        cmb_resultadoAB.Text = dgtc_abRes.TextBox.Text
        dgtc_abRes.TextBox.Controls.Add(cmb_resultadoAB)
        cmb_resultadoAB.BringToFront()
    End Function

    Public Function inicia_gridRes(ByVal int_tam As Integer, ByVal test As Integer, Optional ByVal are_id As Integer = 0)
        On Error Resume Next
        'Dim int_tam As Short
        'Dim modo As String = Nothing
        'Dim Coleccion As New AutoCompleteStringCollection
        'CargarColeccion(Coleccion, test)
        '''cmb_resultado.BorderStyle = BorderStyle.None
        'aqui

        ''modo = g_modocompletar

        ''Select Case modo
        ''    Case "NONE"
        ''        txt_resultado.AutoCompleteMode = AutoCompleteMode.None
        ''    Case "APPEND"
        ''        txt_resultado.AutoCompleteMode = AutoCompleteMode.Append
        ''    Case "SUGGEST"
        ''        txt_resultado.AutoCompleteMode = AutoCompleteMode.Suggest
        ''    Case "SUGGESTAPPEND"
        ''        txt_resultado.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        ''End Select


        'cmb_resultado.AutoCompleteSource = AutoCompleteSource.CustomSource
        'cmb_resultado.AutoCompleteCustomSource = Coleccion


        'cmb_resultado.Items.Clear()
        CargarCombo(cmb_resultado, opr_res.LeerTipoResultado(test))


        AddHandler dgtc_TRes.TextBox.Enter, AddressOf Despliega_resultado
        AddHandler dgtc_TRes.TextBox.MouseEnter, AddressOf Despliega_resultado
        'AddHandler dgtc_Resul.TextBox.MouseDoubleClick, AddressOf TextoDblClick
        'combo de laboratotio
        cmb_resultado.Font = New Font("Courier New", 8.2!, FontStyle.Regular)
        cmb_resultado.DropDownStyle = ComboBoxStyle.DropDown
        cmb_resultado.Width = int_tam - 5
        dgtc_TRes.TextBox.Width = int_tam
        dgtc_TRes.TextBox.Height = 28
        'cmb_resultado.Text = dgtc_TRes.TextBox.Text
        dgtc_TRes.TextBox.Controls.Add(cmb_resultado)
        cmb_resultado.BringToFront()
    End Function


    Public Function inicia_gridCal(ByVal test As Integer, Optional ByVal are_id As Integer = 0)
        On Error Resume Next
        Dim int_tam As Short
        int_tam = 200

        'CargaCalculo(opr_res.LeerTipoResultado(test))

        AddHandler dgtc_TRes.TextBox.Enter, AddressOf Despliega_resultado
        AddHandler dgtc_TRes.TextBox.MouseEnter, AddressOf Despliega_resultado
        'AddHandler dgtc_Resul.TextBox.MouseDoubleClick, AddressOf TextoDblClick
        'combo de laboratotio
        dgtc_TRes.TextBox.Width = int_tam
        dgtc_TRes.TextBox.Height = 28
        dgtc_TRes.TextBox.Controls.Add(cmb_resultado)
    End Function


    Sub CargarCombo(ByVal Combobox As ComboBox, ByVal parametros As String)
        On Error Resume Next
        Dim param As String()
        Dim i As Integer = 0

        param = Split(parametros, ",")
        'Dim dtr_fila As DataRow
        Combobox.Items.Clear()
        For i = 0 To UBound(param)
            Combobox.Items.Add(param(i).ToString)
        Next
    End Sub

    Private Sub Despliega_resultado(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        cmb_resultado.Text = ""
        'cmb_resultado.SelectedIndex = UbicaTextbox(dgrd_resPedido(dgrd_resPedido.CurrentCell.RowNumber, 2), cmb_resultado)
        txt_resultado_Enfoque(Sender, e)
    End Sub

    Private Sub Despliega_resultadoAB(ByVal Sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        ''txt_resultadoAB.Text = ""
        'txt_resultado.SelectedIndex = UbicaTextbox(dgrd_resAB(dgrd_resAB.CurrentCell.RowNumber, 2), txt_resultado)
        txt_resultado_EnfoqueAB(Sender, e)
    End Sub

    Private Sub txt_resultado_Enfoque(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_resultado.Enter
        boo_cambiaTam = True
        dgtc_TRes.Width = 200
        dgtc_TRes.TextBox.Width = 200 - 5
        boo_cambiaTam = False
    End Sub

    Private Sub txt_resultado_EnfoqueAB(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_resultadoAB.Enter
        boo_cambiaTam = True
        dgtc_abRes.Width = 150
        dgtc_abRes.TextBox.Width = 150 - 5
        boo_cambiaTam = False
    End Sub

    Private Sub select_resultado(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_resultado.TextChanged
        On Error Resume Next
        'escribe en el grid el texto seleccionado en el TXT
        Inserta_campo(6, sender.text)
        TamColumna(sender, e)
    End Sub

    Private Sub select_resultadoAB(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_resultadoAB.TextChanged
        On Error Resume Next
        'escribe en el grid el texto seleccionado en el combo
        Inserta_campoAB(2, sender.text)
        TamColumnaAB(sender, e)
    End Sub


    Sub TamColumna(ByVal sender As Object, ByVal e As System.EventArgs)
        dgtc_TRes.Width = 200
    End Sub

    Sub TamColumnaAB(ByVal sender As Object, ByVal e As System.EventArgs)
        dgtc_abRes.Width = 150
    End Sub


    Function UbicaTextbox(ByVal str_clave As String, ByVal cmb_resultado As ComboBox) As Short
        UbicaTextbox = 0
        Dim int_pos_rownum As Short
        For int_pos_rownum = 0 To cmb_resultado.Items.Count - 1
            If cmb_resultado.Items.Item(int_pos_rownum).substring(0, 15) = str_clave Then
                UbicaTextbox = int_pos_rownum
                Exit For
            End If
        Next
    End Function


    Sub CargarColeccion(ByVal Coleccion As AutoCompleteStringCollection, ByVal area As Integer)
        On Error Resume Next
        opr_res.LeerTipoResultado()

    End Sub

    Sub Inserta_campo(ByVal columna As Short, ByVal texto As String)
        On Error GoTo msgerrcol
        If Trim(texto) = "" Then Exit Sub
        dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, columna) = texto
        Exit Sub
msgerrcol:
        dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, columna) = texto
    End Sub


    Sub Inserta_campoAB(ByVal columna As Short, ByVal texto As String)
        On Error GoTo msgerrcol
        If Trim(texto) = "" Then Exit Sub
        grd_antibioticos.Item(grd_antibioticos.CurrentCell.RowNumber, columna) = texto
        Exit Sub
msgerrcol:
        grd_antibioticos.Item(grd_antibioticos.CurrentCell.RowNumber, columna) = texto
    End Sub

    Sub CambiaTamañoCelda(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.GetType.Name = "Cls_Celda_Grafica" Then
            sender.Width = 18
        End If
    End Sub


    Private Sub frm_Ing_Plantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_Grafica("", "GRAF_ERROR", 40, False))
        DataGridTableStyle1.GridColumnStyles.Add(New Cls_Celda_Grafica("ERROR", "DESCRIP", 0, True))
        AddHandler DataGridTableStyle1.GridColumnStyles.Item(11).WidthChanged, AddressOf CambiaTamañoCelda
        Dim unidad As String = Nothing


        lst_Plantillas.Items.Clear()

        orden = Split(filtroOrdenes, ",")

        dts_listaM = opr_trabajo.LlenarListPlantillaOrden(lst_Plantillas, orden(Indice), 1, ReceptaAreas, ped_fecing, abrev)

        If dts_listaM.Tables.Count = 1 Then
            'lst_Plantillas.SelectedIndex = 0
            'lst_Plantillas.SetSelected(0, True)

            On Error Resume Next
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            If dts_listaM.Tables(0).Rows.Count > 0 Then
                btn_Guardar.Enabled = True
                lbl_pacD.Text = dts_listaM.Tables(0).Rows(0).Item(2).ToString
                lbl_orden.Text = dts_listaM.Tables(0).Rows(0).Item(13).ToString
                lbl_convenio.Text = dts_listaM.Tables(0).Rows(0).Item(7).ToString
                lbl_edadPac.Text = "(" & opr_pedido.CalculaEdad(CDate(dts_listaM.Tables(0).Rows(0).Item(8).ToString), unidad) & " " & unidad & ")"

                lst_Plantillas.SetSelected(0, True)
            Else
                btn_Guardar.Enabled = False
            End If



            Call qrcodeGen()
            Me.Cursor = System.Windows.Forms.Cursors.Arrow

        End If

    End Sub

    Private Sub qrcodeGen()
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            'System.Configuration.ConfigurationSettings.AppSettings("PATHQR") 
            'Me.txt_URL.Text = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR"))
            Me.Pic_QR.Image = qrCode.Encode(Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR") & lbl_PedidoD.Text), System.Text.Encoding.UTF8)
            Me.Pic_QR.Image.Save(IO.Path.Combine(Environment.CurrentDirectory & "\" & (System.Configuration.ConfigurationSettings.AppSettings("QR")), lbl_pedidoD.Text & ".jpg"))

            'Call ConvierteBase64QR(System.Configuration.ConfigurationSettings.AppSettings("QR"), lbl_ordenMIS.Text, CLng(lbl_pedidoD.Text))
        Catch ex As Exception
            opr_pedido.VisualizaMensaje(ex.Message, 250)
            'MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub



    Public Sub llena_datosP(ByVal tipo As String)
        On Error Resume Next
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        str_campos = Split(Me.Tag, "/*/")
        lbl_PedidoD.Text = Nothing
        'Dim nombreTest As String = Nothing
        Dim tes_padre As Integer
        Dim tes_hijos As String = Nothing
        Dim estado As String = Nothing
        Dim tim_padre As String = Nothing
        Dim tes_AB As Byte = 0
        Dim RESULTADO As Integer = 0

        For int_indice = 0 To UBound(str_campos)
            int_pos = InStr(str_campos(int_indice), "=")
            str_texto = str_campos(int_indice).Substring(0, int_pos - 1)
            str_valor = str_campos(int_indice).Substring(int_pos)
            Select Case str_texto
                Case "ped_id"
                    lbl_PedidoD.Text = (str_valor)
                Case "tes_id"
                    tes_padre = CInt((str_valor))
                Case "TEST"
                    lbl_nombreTest.Text = ((str_valor))
                Case "ESTADO"
                    estado = ((str_valor))
                Case "TIM_PADRE"
                    tim_padre = (str_valor)

                Case "TES_AB"
                    tes_AB = (str_valor)

                Case "RESULTADO"
                    RESULTADO = (str_valor)

            End Select
            dgrd_resPedido.CaptionText = "ESTADO:  " & estado
        Next

        tes_hijos = opr_trabajo.LeeIdParametros(tes_padre, tes_AB)
        Dim hijos As String()
        Dim ii As Integer = 0
        Dim formula As String = Nothing
        hijos = Split(tes_hijos, ",")


    
        If RESULTADO <> 7 Then


            opr_res.ResultadosPedidoP(dtv_resp, dgrd_resPedido, CInt(lbl_PedidoD.Text), 0, tes_padre, Mid(tes_hijos, 1, Len(tes_hijos) - 1), tim_padre)

            Dim i As Integer
            Dim boo_desc As Boolean = False

            dgrd_resPedido.Visible = True

            'EN EL SIGUIENTE FOR CONSULTO LA DESCRIPCION DEL ERROR SEGUN EL PRC_ERROR Y SNI_NOMBRE
            'SI NO EXISTE ESCRIBIMOS EN L   A CELDA "ERROR DESCONOCIDO, CASO CONTRARIO LA DESC. DEL ERROR"
            For i = 0 To dtv_resp.Count - 1
                'dtv_resp.Item(i).Row(11) = opr_res.ErrorDesc(dtv_resp.Item(i).Row(9), dtv_resp.Item(i).Row(10))
                dtv_resp.Item(i).Row(12) = opr_res.ErrorDesc(dtv_resp.Item(i).Row(9), dtv_resp.Item(i).Row(11))
            Next
            'EN EL SIGUIENTE FOR DETERMINO SI EXISTEN ERRORES EN LAS PRUEBAS AUTOMATICAS, y SI LOS CONSULTO 
            'RESULTADOS ESTAN DENTRO DE LOS RANGOS DE NORMALIDAD DEFINIDOS
            Dim dts_rango As New DataSet()
            Dim dtr_fila As DataRow
            For i = 0 To dtv_resp.Count - 1
                dts_rango = opr_res.LeerRangNormal(dtv_resp.Item(i).Row(4), dtv_resp.Item(i).Row(3))
                For Each dtr_fila In dts_rango.Tables(0).Rows
                    If dtr_fila(1) = 1 Then
                        If dtv_resp.Item(i).Row(10) = "" Then
                            'dtv_resp.Item(i).Row(11) = "Resultado no disponible"
                            'dtv_resp.Item(i).Row(12) = "Resultado no disponible"
                            dtv_resp.Item(i).Row(11) = ""
                            dtv_resp.Item(i).Row(12) = ""

                            If dtv_resp.Item(i).Row(5).ToString <> "" Then

                                If (CDbl(dtv_resp.Item(i).Row(5)) > CDbl(dtr_fila(2) And CDbl(dtv_resp.Item(i).Row(5)) < CDbl(dtr_fila(3)))) Then
                                    dtv_resp.Item(i).Row(9) = ""
                                    dtv_resp.Item(i).Row(10) = ""
                                    boo_error = False
                                End If

                                If CDbl(dtv_resp.Item(i).Row(5)) > CDbl(dtr_fila(3)) Then
                                    dtv_resp.Item(i).Row(9) = "Alto"
                                    dtv_resp.Item(i).Row(10) = "Alto"
                                    boo_error = True
                                End If

                                If CDbl(dtv_resp.Item(i).Row(5)) < CDbl(dtr_fila(2)) Then
                                    dtv_resp.Item(i).Row(9) = "Bajo"
                                    dtv_resp.Item(i).Row(10) = "Bajo"
                                    boo_error = True
                                End If

                            End If
                        End If
                        ''If CDbl(dtr_fila(2)) > CDbl(dtv_resp.Item(i).Row(5)) Or CDbl(dtr_fila(3)) < CDbl(dtv_resp.Item(i).Row(5)) Then
                        ''    'dtv_resp.Item(i).Row(10) = "Fuera del Rango Normal"
                        ''    'dtv_resp.Item(i).Row(12) = "Fuera del Rango Normal"

                        ''    boo_error = True
                        ''End If
                    End If
                Next
                If dtv_resp.Item(i).Row(9) <> "00000" And dtv_resp.Item(i).Row(9) <> "" Then
                    boo_error = True
                End If
            Next
        Else
            opr_res.ResultadosPedidoP(dtv_resp, dgrd_resPedido, CInt(lbl_PedidoD.Text), 0, tes_padre, Mid(tes_hijos, 1, Len(tes_hijos) - 1), tim_padre)
            dgrd_resPedido.Visible = False

        End If

        'Cargo los resultados de los equipos en el grid




        Dim rc As Long
        Dim temp As Object
        If boo_error Then

            'Reproduzco el sonido wav como alarma sonora
            'file in bin directory
            rc = PlaySound(System.AppDomain.CurrentDomain.BaseDirectory & "\system\REMINDER.WAV", 0, SND_NOSTOP)
            If rc = 0 Then
                '    'Sound(didn) 't play, so just beep...
                Beep()
            End If
            'También funciona la siguiente linea (con el Mod_wave)
            'temp = sndPlaySound(System.AppDomain.CurrentDomain.BaseDirectory & "REMINDER.WAV", 1)

        End If

    End Sub

    Public Sub llena_datosAB(ByVal tipo As String)
        On Error Resume Next
        Dim int_indice, int_pos As Integer
        Dim str_campos() As String
        Dim str_texto, str_valor As String
        str_campos = Split(Me.Tag, "/*/")
        lbl_PedidoD.Text = ""
        Dim tes_padre As Integer

        For int_indice = 0 To UBound(str_campos)
            int_pos = InStr(str_campos(int_indice), "=")
            str_texto = str_campos(int_indice).Substring(0, int_pos - 1)
            str_valor = str_campos(int_indice).Substring(int_pos)
            Select Case str_texto
                Case "ped_id"
                    lbl_PedidoD.Text = (str_valor)
                Case "tes_id"
                    tes_padre = CInt((str_valor))
            End Select
        Next


        'Cargo los resultados de los equipos en el grid
        opr_res.ResultadosPedidoAB(dtv_resAB, grd_antibioticos, CInt(lbl_PedidoD.Text), 0, tes_padre)

        'Cargo grid con  valores resultadis + AB disponibles 
        'opr_res.CargarAB(dtv_resAB)


        Dim rc As Long

        'Reproduzco el sonido wav como alarma sonora
        'file in bin directory
        rc = PlaySound(System.AppDomain.CurrentDomain.BaseDirectory & "\system\REMINDER.WAV", 0, SND_NOSTOP)
        If rc = 0 Then
            '    'Sound(didn) 't play, so just beep...
            Beep()
        End If
        'También funciona la siguiente linea (con el Mod_wave)
        'temp = sndPlaySound(System.AppDomain.CurrentDomain.BaseDirectory & "REMINDER.WAV", 1)


    End Sub

    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.ParentForm.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function



    Public Sub LimpiarCamposVR()
        lbl_PedidoD.Text = ""
        opr_res.ResAutoPedido(dtt_res, 0)
        dtv_resp.Table.Clear()
        pan_histograma.Visible = False
        dtv_resAB.Table.Clear()
        txt_ruta.Text = ""

    End Sub


    Private Sub Pic_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'elimina las funciones activas (ej menu) del formulario MDI.
        'ClickMenu_Principal(Me)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
            Case "pic_min"
                Me.WindowState = FormWindowState.Minimized
                Me.ControlBox = True
                Me.MaximizeBox = False
        End Select
    End Sub

    Private Sub pic_min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'elimina las funciones activas (ej menu) del formulario MDI.
        'ClickMenu_Principal(Me)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
            Case "pic_min"
                Me.WindowState = FormWindowState.Minimized
                Me.ControlBox = True
                Me.MaximizeBox = False
        End Select
    End Sub



    Private Sub dgrd_resPedido_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrd_resPedido.CurrentCellChanged
        Dim tabla_val As String()
        Dim formula As String = Nothing
        Dim i As Integer
        'Dim opr_res As New Cls_Resultado()

        valores = Nothing

        If opr_res.verifica_autocompletar(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)) <= 0 Then
            cmb_resultado.Hide()
            cmb_resultado.SendToBack()
            'If opr_res.verifica_autoCalcular(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)) <= 0 Then
            'inicia_gridCal(CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)))
            'End If
        Else
            cmb_resultado.Show()
            inicia_gridRes(200, CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)))

        End If




        For i = 0 To dtv_resp.Table.Rows.Count - 1
            If IsDBNull(dgrd_resPedido.Item(i, 6)) Then
                dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 6) = ""
            End If

            valores = valores & CStr(dgrd_resPedido.Item(i, 19)) & "," & dtv_resp.Item(i).Row(5) & "|"
        Next
        tabla_val = Split(valores, "|")

        If opr_res.LeerFormula(CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)), formula) <> "" Then
            Dim factores As String()
            Dim valores_aux As String()
            Dim valor1 As String
            Dim valor2 As String
            Dim valor3 As String
            Dim valor4 As String
            Dim resul As Double

            opr_res.EjecutaFormula(formula, factores)
            Select Case UBound(factores) + 1
                Case 1
                    For i = 0 To UBound(tabla_val) - 1
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(0) Then
                            valor1 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                    Next

                Case 2 : For i = 0 To UBound(tabla_val) - 1
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(0) Then
                            valor1 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(1) Then
                            valor2 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                    Next

                Case 3 : For i = 0 To UBound(tabla_val) - 1
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(0) Then
                            valor1 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(1) Then
                            valor2 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(2) Then
                            valor3 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                    Next

                Case 4 : For i = 0 To UBound(tabla_val) - 1
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(0) Then
                            valor1 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(1) Then
                            valor2 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If

                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(2) Then
                            valor3 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                        If Mid(tabla_val(i), 1, InStr(1, tabla_val(i), ",") - 1) = factores(3) Then
                            valor4 = Mid(tabla_val(i), InStr(1, tabla_val(i), ",") + 1, Len(tabla_val(i)))
                        End If
                    Next

            End Select

            If (valor1 <> "" Or valor2 <> "" Or valor3 <> "" Or valor4 <> "" Or IsDBNull(valor1) Or IsDBNull(valor2) Or IsDBNull(valor3) Or IsDBNull(valor4)) Then
                opr_res.VisualizaCalculo(CInt(dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 19)), valor1, valor2, valor3, valor4, resul)
                dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 6) = CStr(resul)
            End If
        End If


    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'BOTON GUARDAR
        Me.Tag = ""
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        Dim opr_test As New Cls_Test()
        ' Dim OPR_AS400 As New Cls_AS400()
        Dim testcod As String
        On Error Resume Next
        If (lbl_PedidoD.Text <> "Pedido" And lbl_PedidoD.Text <> "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'If MsgBox("Los cambios realizados en los resultados automáticos y las" & Chr(13) & "notas sobre los resultados del pedido serán almacenadas" & Chr(13) & "en este momento, desea continuar?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim shr_x As Short = 0
            Dim int_codigo As Integer = 0
            Dim estavalidado As Integer
            Dim dtv_resauto As New DataView()
            Dim str_opera As String
            Dim Padre As Integer
            Dim resultado As String = Nothing

            Select Case dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(6).ToString
                Case 4 'MOLECULAR
                    int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString, CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString))
                    estavalidado = opr_trabajo.Leer_Validado(int_codigo)
                    Padre = CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString)
                    Select Case estavalidado
                        Case 0, 1, 2, 9
                            If txt_MuestraAnalizada.Text <> "" Then
                                Dim rango As String
                                Dim i As Integer
                                Dim resul As String
                                Dim res As String()

                                rango = Trim(txt_ValRefMolecular.Text)
                                str_sql = "select tes_id from test where TES_PADRE = " & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString & " order by TES_ID asc;"
                                paramMol = Split(opr_res.ConsultaMolecular(str_sql), "º")
                                For i = 0 To UBound(paramMol) - 1
                                    str_sql = "select TES_NOMBRE, tes_resdefecto, tes_lis from test where tes_id = " & CInt(paramMol(i)) & " and TES_PADRE = " & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString) & ""
                                    info = Split(opr_res.ConsultaSiHayMolecular(str_sql), "|")
                                    resul = Trim(txt_MolMuestra.Text) & "°" & Trim(txt_MolTecnica.Text) & "°" & Trim(txt_ValRefMolecular.Text) & "°" & Trim(txt_MuestraAnalizada.Text) & "°" & Trim(txt_Comentario.Text)
                                    res = Split(resul, "°")
                                    opr_res.ResAutoFinalPlatillas(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString), CInt(lbl_PedidoD.Text), Trim(info(2)), Trim(res(i)), Trim(res(0)), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(6).ToString, 1, CInt(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString)), CInt(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString)))
                                Next
                                str_opera = lbl_PedidoD.Text & "/" & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString) & "/" & Trim(txt_MuestraAnalizada.Text)
                                opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                            Else
                                opr_pedido.VisualizaMensaje("Ingrese un valor para muestra analizada (Resultado)", 350)

                                'opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), dgrd_resPedido(shr_x, 4), "", Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 13), 1, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))
                                'str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                            End If
                        Case 9
                    End Select

                Case 6, 8 'PLATILLAS, CULTIVOS

                    dtv_resauto = dgrd_resPedido.DataSource
                    For shr_x = 0 To ((dtv_resauto.Table.Rows.Count) - 1)
                        int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_PedidoD.Text), CInt(dgrd_resPedido(shr_x, 16)), dgrd_resPedido(shr_x, 17))
                        estavalidado = opr_trabajo.Leer_Validado(int_codigo)
                        Padre = CInt(dgrd_resPedido(shr_x, 16))
                        Select Case estavalidado
                            Case 0, 1, 2
                                If (IsDBNull(dgrd_resPedido(shr_x, 6)) = False) Then 'And (Convert.ToString(dgrd_resPedido(shr_x, 6)) <> "")) Then
                                    If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                                        Dim rango As String
                                        rango = dgrd_resPedido(shr_x, 9)
                                        opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), Trim(dgrd_resPedido(shr_x, 4)), Trim(CStr(dgrd_resPedido(shr_x, 6))), Trim(rango), dgrd_resPedido(shr_x, 13), 1, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))
                                        str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                                        'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", "PEDIDO=" & lbl_PedidoD.Text, g_sng_user, lbl_PedidoD.Text, "")
                                        opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                                    End If
                                Else
                                    opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), dgrd_resPedido(shr_x, 4), "", Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 13), 1, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))
                                    str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                                End If
                            Case 9
                                If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                                    opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 13), 9, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))

                                    str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                                    'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", str_opera, g_sng_user, lbl_PedidoD.Text, "")
                                    opr_trabajo.CambioEstadoItemLista(int_codigo, 9) ' ESTADO 9 remitido 
                                    opr_pedido.ActualizarPdd_Estado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)

                                End If

                        End Select

                    Next
                    'GUARDO LOS VALORES DEL ANTIBIOGRAMA
                    ''opr_res.EliminarAB_procesados(CInt(lbl_PedidoD.Text), Padre)
                    For shr_x = 0 To (dtv_resAB.Table.Rows.Count) - 1
                        opr_res.GuardarAB_procesados(CInt(lbl_PedidoD.Text), grd_antibioticos(shr_x, 0), grd_antibioticos(shr_x, 2), Padre, grd_antibioticos(shr_x, 1))
                    Next

                    LimpiarCamposVR()
                    Me.Cursor = System.Windows.Forms.Cursors.Arrow

                Case 9  'DIAGNOSTICO
                    Dim arre_etiq As String()
                    Dim arre_valor As String()
                    Dim etiquetas As String = Nothing
                    Dim valores As String = Nothing
                    Dim i As Integer = 0


                    int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString, CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString))
                    estavalidado = opr_trabajo.Leer_Validado(int_codigo)
                    Padre = CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString)

                    Select Case dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString

                        Case "AUDIOMETRIA"
                            Dim gr As Graphics = Me.CreateGraphics
                            Dim fSize As Size = New Size(590, 545)
                            Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
                            Dim gr2 As Graphics = Graphics.FromImage(bm)
                            'gr2.CopyFromScreen(160, 180, 0, 0, fSize)
                            gr2.CopyFromScreen(160, 180, 0, 0, fSize)
                            'gr2.CopyFromScreen(CInt(txt_X1.Text), CInt(txt_Y1.Text), CInt(txt_X2.Text), CInt(txt_Y2.Text), fSize)
                            Me.PictureBox1.Image = bm

                            'GuardaCaptura(g_pathFolderOcup, Mid(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(13).ToString, 1, 8))

                            'ConvierteBase64CAPTURA(g_pathFolderOcup, Mid(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(13).ToString, 1, 8), CInt(lbl_PedidoD.Text))

                            resultado = resultado & "OTOSCOPIA: " & vbCrLf & Trim(txt_Otoscopia.Text) & vbCrLf & _
                            "DIAGNOSTICO OD: " & vbCrLf & Trim(txt_ADiagOD.Text) & vbCrLf & _
                            "DIAGNOSTICO OI: " & vbCrLf & Trim(txt_ADiagOI.Text) & vbCrLf & _
                            "RECOMENDACIONES: " & vbCrLf & Trim(txt_ARecom.Text) & vbCrLf

                            'Dim print As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                            'Dim g As Graphics = Graphics.FromImage(print)
                            'g.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                            
                        Case "OPTOMETRIA"

                            'etiquetas = "APP,APF, ANT. OFTALMOLOGICOS, AVSC OD, AVSC OI, AVSCC OD, AVSCC OI, VISION COLORES OD, VISION COLORES OI, REFRACCION OD, REFRACCION OI, REFRACCION ADD, DIAGNOSTICO, PLAN"
                            resultado = resultado & "APP: " & Trim(txt_app.Text) & vbCrLf & _
                            "AFP: " & Trim(txt_apf.Text) & vbCrLf & vbCrLf & _
                            "ANTECEDENTES OFTALMOLOGICOS" & vbCrLf & Trim(txt_ant_opt.Text) & vbCrLf & _
                            "AVSC OD: " & Trim(txt_avscOD.Text) & vbCrLf & _
                            "AVSC OI: " & Trim(txt_avscOI.Text) & vbCrLf & _
                            "AVSCC OD: " & Trim(txt_avsccOD.Text) & vbCrLf & _
                            "AVSCC OI: " & Trim(txt_avsccOI.Text) & vbCrLf & vbCrLf & _
                            "VISION COLORES" & vbCrLf & _
                            "OD: " & Trim(txt_ColoresOD.Text) & vbCrLf & _
                            "OI: " & Trim(txt_ColoresOI.Text) & vbCrLf & vbCrLf & _
                            "REFRACCION: " & vbCrLf & _
                            "OD: " & Trim(txt_RefracOD.Text) & vbCrLf & _
                            "OI: " & Trim(txt_RefracOI.Text) & vbCrLf & _
                            "ADD: " & Trim(txt_RefracADD.Text) & vbCrLf & vbCrLf & _
                            "DIAGNOSTICO: " & vbCrLf & Trim(txt_OpDiag.Text) & vbCrLf & _
                            "PLAN: " & vbCrLf & Trim(txtx_OpPlan.Text) & vbCrLf

                    End Select

                Case 1 'CARGA ARCHIVO
                    Dim Pdfs As String

                    Pdfs = dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(13).ToString & "-" & Trim(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(2).ToString) & ".pdf"

                    If opr_res.ConsultaPdf(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString) = 0 Then
                        Call ConvierteBase64PDF(Trim(txt_ruta.Text), Pdfs, CInt(lbl_PedidoD.Text), 1, dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)
                    Else

                        Dim pdf_sec As Integer = opr_res.MaximoPdf(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)
                        opr_trabajo.InsertPtoPdf(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString, pdf_sec + 1)
                        Call ConvierteBase64PDF(Trim(txt_ruta.Text), Pdfs, CInt(lbl_PedidoD.Text), 1, dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)

                    End If
            End Select

            opr_res.ResAutoFinal(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString), CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString, resultado, "", dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString, 9, CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString), CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString))
            str_opera = lbl_PedidoD.Text & "/" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString & "/" & resultado
            'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", str_opera, g_sng_user, lbl_PedidoD.Text, "")
            opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
            opr_pedido.ActualizarPdd_Estado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)

            opr_pedido.VisualizaMensaje("Resultado guardados satisfactoriamente", 260)
            LimpiarCamposVR()
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Else

            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("No ha seleccionado ningún pedido", MsgBoxStyle.Information, "ANALISYS")
        End If

        WBCImage.Image = Image.FromFile(Environment.CurrentDirectory & "\CARGANDO_info.GIF")
        RBCimage.Image = Image.FromFile(Environment.CurrentDirectory & "\CARGANDO_info.GIF")
        PLTimage.Image = Image.FromFile(Environment.CurrentDirectory & "\CARGANDO_info.GIF")

    End Sub

    
    Public Sub ConvierteBase64PDF(ByVal path As String, ByVal nombrePDF As String, ByVal ped_id As Long, ByVal EsOcup As Byte, ByVal pdf_examen As String)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim param As SqlParameter
        Dim beneficiosVida As Byte()
        Dim archivo As String = path & "\" & nombrePDF
        Dim pdf_orden As String = Trim(Mid(nombrePDF, 1, 9))

        beneficiosVida = File.ReadAllBytes(path)

        opr_Conexion.sql_conectarpdf()



            If EsOcup = 0 Then
                STR_SQL = "update ptopdf set pdf_base64 = @Content, pdf_orden = '" & pdf_orden & "', pdf_dwn = 1 where ped_id = " & ped_id & " and pdf_examen = 'LABORATORIO' "
            Else
                STR_SQL = "update ptopdf set pdf_base64 = @Content, pdf_orden = '" & pdf_orden & "', pdf_dwn = 1 where ped_id = " & ped_id & " and pdf_examen = '" & pdf_examen & "'"
            End If

            Dim cmd As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql_pdf)
            cmd.Parameters.Add("@Content", SqlDbType.VarBinary).Value = beneficiosVida
            cmd.ExecuteNonQuery()
            opr_Conexion.sql_desconn_pdf()
            Exit Sub
MsgError:
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar pdf", Err)
            Err.Clear()

    End Sub


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        If MsgBox("Desea cerrar la ventana Plantillas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub dgrd_resAB_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd_antibioticos.CurrentCellChanged
        If opr_res.verifica_autocompletarArea(grd_antibioticos.Item(grd_antibioticos.CurrentCell.RowNumber, 3)) <= 0 Then
            'If dgrd_resPedido.Item(dgrd_resPedido.CurrentCell.RowNumber, 18) <> 22 Then
            cmb_resultado.Hide()
            cmb_resultado.SendToBack()

        Else
            cmb_resultado.Show()
            inicia_gridRes(100, CInt(grd_antibioticos.Item(grd_antibioticos.CurrentCell.RowNumber, 3)))

            'opr_res.LeerTipoResultado(Coleccion, area)
        End If
    End Sub

    Private Sub btn_dtpUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dtpUp.Click

        If (filtroOrdenes <> "") Then


            If Indice > UBound(orden) - 2 Then
                MsgBox("Fin del bloque", MsgBoxStyle.Information, "ANALISYS")
            Else
                Indice = Indice + 1
                dts_listaM.Clear()
                dts_listaM = opr_trabajo.LlenarListPlantillaOrden(lst_Plantillas, orden(Indice), 1, ReceptaAreas, ped_fecing, abrev)

                If lst_Plantillas.Items.Count >= 1 Then
                    'lst_Plantillas.SelectedIndex = 0
                    lst_Plantillas.SetSelected(0, True)
                    On Error Resume Next
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    If dts_listaM.Tables(0).Rows.Count > 0 Then
                        lbl_pacD.ForeColor = Color.DarkBlue
                        lbl_convenio.Text = dts_listaM.Tables(0).Rows(0).Item(7).ToString
                        lbl_orden.Text = dts_listaM.Tables(0).Rows(0).Item(13).ToString()
                        lbl_pacD.Text = dts_listaM.Tables(0).Rows(0).Item(2).ToString
                        btn_Guardar.Enabled = True
                    Else
                        btn_Guardar.Enabled = False
                    End If

                    Dim dtr_fila1 As DataRow
                    Dim i As Integer
                    Dim ped_id_historico As Integer
                    Dim res_Historico As String
                    Dim datos As String()

                    datos = Split(DatosTag, "º")

                    For i = 0 To dtv_resp.Count - 1

                        ' CONSULTO LA ORDEN ANTERIOR
                        ped_id_historico = opr_res.PedidoHistorico(datos(0), CDate(datos(1)), dtv_resp.Item(i).Row(3))

                        res_Historico = opr_res.LeerHistorico(ped_id_historico, dtv_resp.Item(i).Row(3), CInt(dtv_resp.Item(i).Row(14)))
                        'consulta orden anterio para historico
                        'For Each dtr_fila1 In dts_Historico.Tables(0).Rows
                        'If dtr_fila1(0) <> "" Then
                        dtv_resp.Item(i).Row(6) = res_Historico
                        'End If

                    Next

                    Me.Cursor = System.Windows.Forms.Cursors.Arrow
                Else
                    lbl_orden.Text = orden(Indice)
                    lbl_pacD.ForeColor = Color.Red
                    lbl_pacD.Text = "NO TIENE EXAMENES PLANTILLA"
                    dgrd_resPedido.DataSource = Nothing
                    lbl_nombreTest.Text = ""
                End If
            End If
        End If
    End Sub




    Private Sub btn_dtpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dtpDown.Click

        If (filtroOrdenes <> "") Then

            If Indice = 0 Then
                MsgBox("Fin del bloque", MsgBoxStyle.Information, "ANALISYS")
            Else
                Indice = Indice - 1

                dts_listaM = opr_trabajo.LlenarListPlantillaOrden(lst_Plantillas, orden(Indice), 1, ReceptaAreas, ped_fecing, abrev)

                If lst_Plantillas.Items.Count >= 1 Then
                    'lst_Plantillas.SelectedIndex = 0
                    lst_Plantillas.SetSelected(0, True)
                    On Error Resume Next
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    If dts_listaM.Tables(0).Rows.Count > 0 Then
                        lbl_pacD.ForeColor = Color.DarkBlue
                        lbl_convenio.Text = dts_listaM.Tables(0).Rows(0).Item(7).ToString
                        lbl_orden.Text = dts_listaM.Tables(0).Rows(0).Item(13).ToString()
                        lbl_pacD.Text = dts_listaM.Tables(0).Rows(0).Item(2).ToString
                        btn_Guardar.Enabled = True
                    Else
                        btn_Guardar.Enabled = False
                    End If
                    Dim dtr_fila1 As DataRow
                    Dim i As Integer
                    Dim ped_id_historico As Integer
                    Dim res_Historico As String
                    Dim datos As String()

                    datos = Split(DatosTag, "º")

                    For i = 0 To dtv_resp.Count - 1

                        ' CONSULTO LA ORDEN ANTERIOR
                        ped_id_historico = opr_res.PedidoHistorico(datos(0), CDate(datos(1)), dtv_resp.Item(i).Row(3))

                        res_Historico = opr_res.LeerHistorico(ped_id_historico, dtv_resp.Item(i).Row(3), CInt(dtv_resp.Item(i).Row(14)))
                        'consulta orden anterio para historico
                        'For Each dtr_fila1 In dts_Historico.Tables(0).Rows
                        'If dtr_fila1(0) <> "" Then
                        dtv_resp.Item(i).Row(6) = res_Historico
                        'End If

                    Next
                    Me.Cursor = System.Windows.Forms.Cursors.Arrow
                Else
                    lbl_orden.Text = orden(Indice)
                    lbl_pacD.ForeColor = Color.Red
                    lbl_pacD.Text = "NO TIENE EXAMENES PLANTILLA"
                    dgrd_resPedido.DataSource = Nothing
                    lbl_nombreTest.Text = ""
                End If
            End If
        End If
    End Sub




    Public Function Base64ToImage(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte()
        Try
            'If (Len(Base64Code) / 4 > 0) Then

            'End If

            imageBytes = Convert.FromBase64String(Base64Code)

            'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            If numorden <> "" Then

                NombreArchivo = nombre_tipo & numorden & ".gif"

                If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo

                'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

                If File.Exists(vFileName) Then
                    'File.Delete(vFileName)
                    EliminaArchivoTxt(vFileName)
                End If
                'diskOpts.DiskFileName = vFileName

                File.WriteAllBytes(vFileName, imageBytes)


                Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
                Dim tmpImage As Image = Image.FromStream(ms, True)
                'NombreArchivo = vFileName

                Return tmpImage
            End If
        Catch ex As Exception
            imageBytes = Convert.FromBase64String(Mid(Base64Code, 1, Len(Base64Code) - 1))
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            ' If numorden <> "" Then

            NombreArchivo = nombre_tipo & numorden & ".gif"

            If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
            vFileName = Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo

            'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

            If File.Exists(vFileName) Then
                'File.Delete(vFileName)
                EliminaArchivoTxt(vFileName)
            End If
            'diskOpts.DiskFileName = vFileName

            File.WriteAllBytes(vFileName, imageBytes)


            Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
            Dim tmpImage As Image = Image.FromStream(ms, True)
            'NombreArchivo = vFileName

            Return tmpImage
            'MsgBox("Se presento un problema al eliminar el archivo")
        End Try

    End Function

    Public Function EliminaArchivoTxt(ByVal ruta_archivo As String) As Boolean
        Try
            If File.Exists(ruta_archivo) Then
                File.Delete(ruta_archivo)
            Else

            End If
        Catch ex As Exception

        End Try
    End Function


    Private Sub lst_Plantillas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_Plantillas.SelectedIndexChanged
        On Error Resume Next
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim str_sql As String = Nothing
        Dim archivos As String = Nothing
        Dim opr_resul As New Cls_Resultado()
        Dim i As Integer = 0



        pan_histograma.Visible = False
        If dts_listaM.Tables(0).Rows.Count > 0 Then
            btn_Guardar.Enabled = True
        Else
            btn_Guardar.Enabled = False
        End If

        Me.Tag = ""
        Me.Tag = "ped_turno= " & Mid(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(13).ToString, 5, 5) & "/*/pac_nombre=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(2).ToString & "/*/ped_id=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString & "/*/tes_id=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(3).ToString & "/*/ESTADO=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(18).ToString & "/*/TEST=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString & "/*/TIM_PADRE=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString & "/*/TES_AB=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(17).ToString & "/*/RESULTADO=" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(6).ToString

        Me.llena_datosP("Validacion")

        grp_CargaArchivo.Visible = False
        dgrd_resPedido.Visible = False
        grd_antibioticos.Visible = False
        grp_Molecular.Visible = False
        grp_Audiometria.Visible = False
        grp_Optometria.Visible = False
        txt_ruta.Text = ""
        'grp_Espirometria.Visible = False
        'grp_Radiografia.Visible = False

        Select Case dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(6).ToString

            '4 PLANTILLA BIOLOGIA MOLECULAR
            Case 4
                grd_antibioticos.Visible = False
                dgrd_resPedido.Visible = False
                grp_Molecular.Visible = True



                str_sql = "select lt.ped_id, lt.tes_id, lt.LIS_RESESTADO, lt.TIM_ID " & _
                        "from lista_trabajo as lt, test_resultado as tr " & _
                        "where lt.ped_id = " & CInt(lbl_PedidoD.Text) & " And tr.RES_ID = 4 And lt.tes_id = '" & dtv_resp.Item(1).Row(16) & "' and lt.tes_id = tr.tes_id "

                If opr_res.ConsultaResMolecular(str_sql) = 1 Then

                    For i = 0 To dtv_resp.Table.Rows.Count - 1
                        Select Case i
                            Case 0 : txt_MolMuestra.Text = dtv_resp.Item(i).Row(6)
                            Case 1 : txt_MolTecnica.Text = dtv_resp.Item(i).Row(6)
                            Case 2 : txt_ValRefMolecular.Text = dtv_resp.Item(i).Row(6)
                            Case 3 : txt_MuestraAnalizada.Text = dtv_resp.Item(i).Row(6)
                            Case 4 : txt_Comentario.Text = dtv_resp.Item(i).Row(6)
                        End Select
                    Next

                Else
                    str_sql = "select tes_id from test where TES_PADRE = " & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString & " order by TES_ID asc;"
                    paramMol = Split(opr_res.ConsultaMolecular(str_sql), "º")
                    For i = 0 To UBound(paramMol) - 1
                        str_sql = "select TES_NOMBRE, tes_resdefecto, tes_lis from test where tes_id = " & CInt(paramMol(i)) & " and TES_PADRE = " & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString) & ""
                        info = Split(opr_res.ConsultaSiHayMolecular(str_sql), "|")

                        Select Case info(0).ToString.ToUpper
                            Case "MUESTRA"
                                txt_MolMuestra.Text = info(1).ToString
                            Case "TECNICA", "TÉCNICA"
                                txt_MolTecnica.Text = info(1).ToString
                            Case "VALOR DE REFERENCIA", "VALOR REFERENCIA", "VALOR REFERENCIAL"
                                txt_ValRefMolecular.Text = info(1).ToString
                            Case "MUESTRA ANALIZADA"
                                txt_MuestraAnalizada.Text = info(1).ToString
                                'str_sql = "select rp.PRC_RESFINAL " & _
                                '"from res_procesados as rp " & _
                                '"where rp.ped_id = " & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString) & " and rp.TES_PADRE = " & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(3).ToString) & " " & _
                                '"and (rp.TES_ABREV = '" & Trim(info(2)) & "' OR rp.TES_ABREV = '" & Trim(info(2)) & "H' OR rp.TES_ABREV = '" & Trim(info(2)) & "R' OR rp.TES_ABREV = '" & Trim(info(2)) & "N')  "
                            Case "COMENTARIO", "OBSERVACIONES"
                                txt_Comentario.Text = info(1).ToString

                        End Select
                    Next

                End If


                '6 PLANTILLAS ESTANDAR
            Case 6
                dgrd_resPedido.Visible = False
                grd_antibioticos.Visible = False
                grp_Molecular.Visible = False
                grp_Audiometria.Visible = False
                grp_Optometria.Visible = False
                grp_CargaArchivo.Visible = False

                dgrd_resPedido.Visible = True
                grd_antibioticos.Visible = False
                grp_Molecular.Visible = False
                'If dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(17).ToString = 2 Then
                '    grd_antibioticos.Visible = False
                'End If

                If System.Configuration.ConfigurationSettings.AppSettings("VerHIstograma") = True And (dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(3).ToString = 400101 Or dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(3).ToString = 401097) Then

                    pan_histograma.Visible = True
                    Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")

                    '******Dependiendo si existe o no histograma va el campo Histograma
                    ''str_sql = "SELECT  pedido.PED_ID, DiffimageLSMS, DiffimageLSHS, DiffimageHSMS, DiffimageBASO, RBCimage, PLTimage, WBCImage " & _
                    ''"FROM pedido, ptohistograma " & _
                    ''"where pedido.ped_id = ptohistograma.ped_id  " & _
                    ''"and pedido.PED_ID = " & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

                    'str_sql = "SELECT  pedido.PED_ID, DiffimageLSMS, DiffimageLSHS, DiffimageHSMS, DiffimageBASO, RBCimage, PLTimage, WBCImage " & _

                    str_sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
                    "FROM pedido, ptohistograma " & _
                    "where pedido.ped_id = ptohistograma.ped_id  " & _
                    "and pedido.PED_ID = " & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"


                    Dim dts_histograma As New DataSet()
                    Dim str_his As String = "NOHISTOGRAMA"

                    archivos = opr_res.ConsultaPathFiles(str_sql)

                    If archivos <> "" Then
                        Dim tramaTXT As String
                        Dim NombreArchivo As String


                        tramaTXT = opr_resul.ConsultaHistgrama(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), fabricante, "WBCImage")
                        Dim byteArrayWBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                        Dim imageWBC = convertbytetoimage(byteArrayWBC) 'Using Functions To Make the code tidier
                        NombreArchivo = "WBCimage.gif"
                        opr_resul.GuardarImagen(CInt(lbl_PedidoD.Text), "WBCimage", NombreArchivo)
                        tramaTXT = ""
                        WBCImage.Image = imageWBC 'since we're using a small windows form app, we'll set back the image to a second picture box.

                        tramaTXT = opr_resul.ConsultaHistgrama(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), fabricante, "RBCImage")
                        Dim byteArrayRBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                        Dim imageRBC = convertbytetoimage(byteArrayRBC) 'Using Functions To Make the code tidier
                        NombreArchivo = "RBCimage.gif"
                        opr_resul.GuardarImagen(CInt(lbl_PedidoD.Text), "RBCimage", NombreArchivo)
                        tramaTXT = ""
                        RBCimage.Image = imageRBC 'since we're using a small windows form app, we'll set back the image to a second picture box.


                        tramaTXT = opr_resul.ConsultaHistgrama(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), fabricante, "PLTImage")
                        Dim byteArrayPLT = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
                        Dim imagePLT = convertbytetoimage(byteArrayPLT) 'Using Functions To Make the code tidier
                        NombreArchivo = "PLTimage.gif"
                        opr_resul.GuardarImagen(CInt(lbl_PedidoD.Text), "PLTimage", NombreArchivo)
                        tramaTXT = ""
                        PLTimage.Image = imagePLT 'since we're using a small windows form app, we'll set back the image to a second picture box.

                        'tramaTXT = opr_resul.ConsultaHistgrama(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), fabricante, "WBCImage")
                        'WBCImage.Image = Base64ToImage(tramaTXT, Trim(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), "WBCImage", NombreArchivo)
                        'opr_resul.GuardarImagen(CInt(lbl_PedidoD.Text), "WBCImage", NombreArchivo)
                        'WBCImage.Image = Image.FromFile(Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo)
                        'tramaTXT = ""

                        'tramaTXT = opr_resul.ConsultaHistgrama(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), fabricante, "RBCimage")
                        'RBCimage.Image = Base64ToImage(tramaTXT, Trim(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), "RBCimage", NombreArchivo)
                        'opr_resul.GuardarImagen(CInt(lbl_PedidoD.Text), "RBCimage", NombreArchivo)
                        'RBCimage.Image = Image.FromFile(Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo)
                        'tramaTXT = ""

                        'tramaTXT = opr_resul.ConsultaHistgrama(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), fabricante, "PLTimage")
                        'PLTimage.Image = Base64ToImage(tramaTXT, Trim(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(0).ToString), "PLTimage", NombreArchivo)
                        'opr_resul.GuardarImagen(CInt(lbl_PedidoD.Text), "PLTimage", NombreArchivo)
                        'PLTimage.Image = Image.FromFile(Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo)
                        'tramaTXT = ""


                    End If
                End If


                '8 PLANTILLA CULTIVO AB
            Case 8

                dgrd_resPedido.Visible = True
                grp_Molecular.Visible = False
                grd_antibioticos.Visible = True
                Me.llena_datosAB("Validacion")

                '1 PLANTILLA OCUPACIONAL (CARGA PDF)


            Case 9

                dgrd_resPedido.Visible = False
                grd_antibioticos.Visible = False
                grp_Molecular.Visible = False
                grp_Audiometria.Visible = False
                grp_Optometria.Visible = False
                grp_CargaArchivo.Visible = False


                Select Case dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString
                    Case "AUDIOMETRIA"
                        grp_Audiometria.Visible = True
                    Case "OPTOMETRIA"
                        grp_Optometria.Visible = True

                        For Each ctl1 As Control In Me.grp_Optometria.Controls
                            If TypeOf ctl1 Is TextBox Then
                                valores = valores & ctl1.Text = ""
                            End If
                        Next

                    Case "ELECTROCARDIOGRAMA", "RAYOS X", "ESPIROMETRIA", "RX LUMBAR APL", "RX CERVICAL APL", "RX COLUMNA DORSAL APL", "RX TORAX"
                        grp_CargaArchivo.Visible = True
                End Select


            Case 1

                If (opr_pedido.consultaArchivo(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)) <> "" Then
                    lbl_Achivo.Text = opr_pedido.consultaArchivo(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)
                Else
                    lbl_Achivo.Text = "SIN ARCHIVO"
                End If
                dgrd_resPedido.Visible = False
                grd_antibioticos.Visible = False
                grp_Molecular.Visible = False
                grp_Audiometria.Visible = False
                grp_Optometria.Visible = False
                grp_CargaArchivo.Visible = True
                'grp_Espirometria.Visible = False
                'grp_Radiografia.Visible = False



        End Select


        Dim dtr_fila1 As DataRow
        Dim ped_id_historico As Integer
        Dim res_Historico As String
        Dim datos As String()

        datos = Split(DatosTag, "º")

        For i = 0 To dtv_resp.Count - 1

            ' CONSULTO LA ORDEN ANTERIOR
            ped_id_historico = opr_res.PedidoHistorico(datos(0), CDate(datos(1)), dtv_resp.Item(i).Row(3))

            res_Historico = opr_res.LeerHistorico(ped_id_historico, dtv_resp.Item(i).Row(3), CInt(dtv_resp.Item(i).Row(14)))
            'consulta orden anterio para historico
            'For Each dtr_fila1 In dts_Historico.Tables(0).Rows
            'If dtr_fila1(0) <> "" Then
            dtv_resp.Item(i).Row(6) = res_Historico
            'End If

        Next

        
        Me.Activate()


        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    Public Function ConvertImageToBase64String(ByVal PicBox As PictureBox) As String
        Using ms As New MemoryStream()
            PicBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png) 'We load the image from first PictureBox in the MemoryStream
            Dim obyte = ms.ToArray() 'We tranform it to byte array..

            Return Convert.ToBase64String(obyte) 'We then convert the byte array to base 64 string.
        End Using
    End Function


    Public Function ConvertBase64ToByteArray(ByVal base64 As String) As Byte()
        Return Convert.FromBase64String(IsBase64String(base64)) 'Convert the base64 back to byte array.
    End Function


    Public Function IsBase64String(ByVal s As String) As String
        If (Trim(s).Length Mod 4) > 0 Then
            Return Mid(s, 1, s.Length - 1) ' & "="
        Else
            Return s
        End If

        'Return (s.Length Mod 4 = 0) AndAlso Regex.IsMatch(s, "^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None)
    End Function


    Private Sub btn_Primero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Primero.Click
        If (filtroOrdenes <> "") Then

            If Indice = 0 Then
                MsgBox("Fin del bloque", MsgBoxStyle.Information, "ANALISYS")
            Else
                Indice = 0

                dts_listaM = opr_trabajo.LlenarListPlantillaOrden(lst_Plantillas, orden(Indice), 1, ReceptaAreas, ped_fecing, abrev)

                If lst_Plantillas.Items.Count >= 1 Then
                    'lst_Plantillas.SelectedIndex = 0
                    lst_Plantillas.SetSelected(0, True)
                    On Error Resume Next
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    If dts_listaM.Tables(0).Rows.Count > 0 Then
                        lbl_pacD.ForeColor = Color.DarkBlue
                        lbl_convenio.Text = dts_listaM.Tables(0).Rows(0).Item(7).ToString
                        lbl_orden.Text = dts_listaM.Tables(0).Rows(0).Item(13).ToString()
                        lbl_pacD.Text = dts_listaM.Tables(0).Rows(0).Item(2).ToString
                        btn_Guardar.Enabled = True
                    Else
                        btn_Guardar.Enabled = False
                    End If

                    Dim dtr_fila1 As DataRow
                    Dim i As Integer
                    Dim ped_id_historico As Integer
                    Dim res_Historico As String
                    Dim datos As String()

                    datos = Split(DatosTag, "º")

                    For i = 0 To dtv_resp.Count - 1

                        ' CONSULTO LA ORDEN ANTERIOR
                        ped_id_historico = opr_res.PedidoHistorico(datos(0), CDate(datos(1)), dtv_resp.Item(i).Row(3))

                        res_Historico = opr_res.LeerHistorico(ped_id_historico, dtv_resp.Item(i).Row(3), CInt(dtv_resp.Item(i).Row(14)))
                        'consulta orden anterio para historico
                        'For Each dtr_fila1 In dts_Historico.Tables(0).Rows
                        'If dtr_fila1(0) <> "" Then
                        dtv_resp.Item(i).Row(6) = res_Historico
                        'End If

                    Next
                    Me.Cursor = System.Windows.Forms.Cursors.Arrow
                Else
                    lbl_orden.Text = orden(Indice)
                    lbl_pacD.ForeColor = Color.Red
                    lbl_pacD.Text = "NO TIENE EXAMENES PLANTILLA"
                    dgrd_resPedido.DataSource = Nothing
                    lbl_nombreTest.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub btn_ultimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ultimo.Click
        If (filtroOrdenes <> "") Then


            If Indice > UBound(orden) - 2 Then
                MsgBox("Fin del bloque", MsgBoxStyle.Information, "ANALISYS")
            Else
                Indice = UBound(orden) - 1
                dts_listaM = opr_trabajo.LlenarListPlantillaOrden(lst_Plantillas, orden(Indice), 1, ReceptaAreas, ped_fecing, abrev)

                If lst_Plantillas.Items.Count >= 1 Then
                    'lst_Plantillas.SelectedIndex = 0
                    lst_Plantillas.SetSelected(0, True)
                    On Error Resume Next
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    If dts_listaM.Tables(0).Rows.Count > 0 Then
                        lbl_pacD.ForeColor = Color.DarkBlue
                        lbl_convenio.Text = dts_listaM.Tables(0).Rows(0).Item(7).ToString
                        lbl_orden.Text = dts_listaM.Tables(0).Rows(0).Item(13).ToString()
                        lbl_pacD.Text = dts_listaM.Tables(0).Rows(0).Item(2).ToString
                        btn_Guardar.Enabled = True
                    Else
                        btn_Guardar.Enabled = False
                    End If

                    Dim dtr_fila1 As DataRow
                    Dim i As Integer
                    Dim ped_id_historico As Integer
                    Dim res_Historico As String
                    Dim datos As String()

                    datos = Split(DatosTag, "º")

                    For i = 0 To dtv_resp.Count - 1

                        ' CONSULTO LA ORDEN ANTERIOR
                        ped_id_historico = opr_res.PedidoHistorico(datos(0), CDate(datos(1)), dtv_resp.Item(i).Row(3))

                        res_Historico = opr_res.LeerHistorico(ped_id_historico, dtv_resp.Item(i).Row(3), CInt(dtv_resp.Item(i).Row(14)))
                        'consulta orden anterio para historico
                        'For Each dtr_fila1 In dts_Historico.Tables(0).Rows
                        'If dtr_fila1(0) <> "" Then
                        dtv_resp.Item(i).Row(6) = res_Historico
                        'End If

                    Next

                    Me.Cursor = System.Windows.Forms.Cursors.Arrow
                Else
                    lbl_orden.Text = orden(Indice)
                    lbl_pacD.ForeColor = Color.Red
                    lbl_pacD.Text = "NO TIENE EXAMENES PLANTILLA"
                    dgrd_resPedido.DataSource = Nothing
                    lbl_nombreTest.Text = ""
                End If
            End If
        End If
    End Sub


    Private Sub btn_Histograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Histograma.Click

        Me.Tag = ""
        Dim frm_MDIChild As New frm_WebChat()
        frm_MDIChild.frm_refer_main_form = Me.ParentForm
        frm_MDIChild.Numorden = Trim(lbl_orden.Text)
        'frm_MDIChild.Numorden = Trim(lbl_PedidoD.Text)

        frm_MDIChild.ShowDialog(Me.ParentForm)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub


    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'OpenFileDialog1.ShowDialog()
        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Archivo PDF|*.pdf"
            If archivo.ShowDialog = DialogResult.OK Then
                txt_ruta.Text = archivo.FileName
                'AxAcroPDF1.src = archivo.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click


        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Archivo PDF|*.pdf"
            If archivo.ShowDialog = DialogResult.OK Then
                txt_ruta.Text = archivo.FileName
                'ArcPDF.src = archivo.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub GuardaCaptura(ByVal path As String, ByVal nombreImg As String)
        Dim vFileName As String = Nothing

        If Dir(Environment.CurrentDirectory & "\" & path, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & path)
        vFileName = Environment.CurrentDirectory & "\" & path & "\" & Format(Now, "yy") & nombreImg & ".jpg"

        If File.Exists(vFileName) Then
            File.Delete(vFileName)
        End If

        PictureBox1.Image.Save(vFileName, ImageFormat.Jpeg)

        ' Usar el formato según la extensión
        ''Dim ext As String = path.GetExtension(nombreImg).ToLower()
        ''Select Case ext
        ''    Case ".jpg"
        ''        Me.picCaptura.Image.Save(Me.txtNombre.Text, ImageFormat.Jpeg)
        ''    Case ".png"
        ''        Me.picCaptura.Image.Save(Me.txtNombre.Text, ImageFormat.Png)
        ''    Case ".gif"
        ''        Me.picCaptura.Image.Save(Me.txtNombre.Text, ImageFormat.Gif)
        ''    Case ".bmp"
        ''        Me.picCaptura.Image.Save(Me.txtNombre.Text, ImageFormat.Bmp)
        ''    Case ".tif"
        ''        Me.picCaptura.Image.Save(Me.txtNombre.Text, ImageFormat.Tiff)
        ''    Case Else
        ''        Me.picCaptura.Image.Save(Me.txtNombre.Text)
        ''End Select
    End Sub


    Private Sub ConvierteBase64CAPTURA(ByVal path As String, ByVal nombreFILE As String, ByVal ped_id As Long)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        '  Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim param As SqlParameter
        Dim beneficiosVida As Byte()
        Dim archivo As String = path & "\" & Format(Now, "yy") & nombreFILE
        Dim img_orden As String = Format(Now, "yy") & Trim(Mid(nombreFILE, 1, 8))

        beneficiosVida = File.ReadAllBytes(Environment.CurrentDirectory & "\" & archivo & ".jpg")
        Dim base64String As String = Convert.ToBase64String(beneficiosVida, 0, beneficiosVida.Length)

        opr_Conexion.sql_conectar()
        STR_SQL = "update ptoimagen set img_base64 = '" & base64String & "', img_nombre = 'Audiometria', img_orden = '" & img_orden & "' where ped_id = " & ped_id & "  "

        opr_Conexion.sql_conectar()

        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()

        opr_Conexion.sql_conectar()
        STR_SQL = "update ptoHistograma set RBCimage = '" & base64String & "' where ped_id = " & ped_id & "  "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()


        'Dim cmd As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        'cmd.Parameters.Add("@Content", SqlDbType.VarBinary).Value = base64String
        'cmd.ExecuteNonQuery()
        'opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar img", Err)
        Err.Clear()

    End Sub




    Private Sub boton_enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AI01.MouseEnter, btn_AI02.MouseEnter, btn_AI03.MouseEnter, btn_AI99.MouseEnter, btn_AI98.MouseEnter, btn_AI97.MouseEnter, btn_AI96.MouseEnter, btn_AI95.MouseEnter, btn_AI94.MouseEnter, btn_AI93.MouseEnter, btn_AI92.MouseEnter, btn_AI91.MouseEnter, btn_AI90.MouseEnter, btn_AI89.MouseEnter, btn_AI88.MouseEnter, btn_AI87.MouseEnter, btn_AI86.MouseEnter, btn_AI85.MouseEnter, btn_AI84.MouseEnter, btn_AI83.MouseEnter, btn_AI82.MouseEnter, btn_AI81.MouseEnter, btn_AI80.MouseEnter, btn_AI79.MouseEnter, btn_AI78.MouseEnter, btn_AI77.MouseEnter, btn_AI76.MouseEnter, btn_AI75.MouseEnter, btn_AI74.MouseEnter, btn_AI73.MouseEnter, btn_AI72.MouseEnter, btn_AI71.MouseEnter, btn_AI70.MouseEnter, btn_AI69.MouseEnter, btn_AI68.MouseEnter, btn_AI67.MouseEnter, btn_AI66.MouseEnter, btn_AI65.MouseEnter, btn_AI64.MouseEnter, btn_AI63.MouseEnter, btn_AI62.MouseEnter, btn_AI61.MouseEnter, btn_AI60.MouseEnter, btn_AI59.MouseEnter, btn_AI58.MouseEnter, btn_AI57.MouseEnter, btn_AI56.MouseEnter, btn_AI55.MouseEnter, btn_AI54.MouseEnter, btn_AI53.MouseEnter, btn_AI52.MouseEnter, btn_AI51.MouseEnter, btn_AI50.MouseEnter, btn_AI49.MouseEnter, btn_AI48.MouseEnter, btn_AI47.MouseEnter, btn_AI46.MouseEnter, btn_AI45.MouseEnter, btn_AI44.MouseEnter, btn_AI43.MouseEnter, btn_AI42.MouseEnter, btn_AI41.MouseEnter, btn_AI40.MouseEnter, btn_AI39.MouseEnter, btn_AI38.MouseEnter, btn_AI37.MouseEnter, btn_AI36.MouseEnter, btn_AI35.MouseEnter, btn_AI34.MouseEnter, btn_AI33.MouseEnter, btn_AI32.MouseEnter, btn_AI31.MouseEnter, btn_AI30.MouseEnter, btn_AI29.MouseEnter, btn_AI28.MouseEnter, btn_AI27.MouseEnter, btn_AI26.MouseEnter, btn_AI25.MouseEnter, btn_AI24.MouseEnter, btn_AI230.MouseEnter, btn_AI23.MouseEnter, btn_AI229.MouseEnter, btn_AI228.MouseEnter, btn_AI227.MouseEnter, btn_AI226.MouseEnter, btn_AI225.MouseEnter, btn_AI224.MouseEnter, btn_AI223.MouseEnter, btn_AI222.MouseEnter, btn_AI221.MouseEnter, btn_AI220.MouseEnter, btn_AI22.MouseEnter, btn_AI219.MouseEnter, btn_AI218.MouseEnter, btn_AI217.MouseEnter, btn_AI216.MouseEnter, btn_AI215.MouseEnter, btn_AI214.MouseEnter, btn_AI213.MouseEnter, btn_AI212.MouseEnter, btn_AI211.MouseEnter, btn_AI210.MouseEnter, btn_AI21.MouseEnter, btn_AI209.MouseEnter, btn_AI208.MouseEnter, btn_AI207.MouseEnter, btn_AI206.MouseEnter, btn_AI205.MouseEnter, btn_AI204.MouseEnter, btn_AI203.MouseEnter, btn_AI202.MouseEnter, btn_AI201.MouseEnter, btn_AI200.MouseEnter, btn_AI20.MouseEnter, btn_AI199.MouseEnter, btn_AI198.MouseEnter, btn_AI197.MouseEnter, btn_AI196.MouseEnter, btn_AI195.MouseEnter, btn_AI194.MouseEnter, btn_AI193.MouseEnter, btn_AI192.MouseEnter, btn_AI191.MouseEnter, btn_AI190.MouseEnter, btn_AI19.MouseEnter, btn_AI189.MouseEnter, btn_AI188.MouseEnter, btn_AI187.MouseEnter, btn_AI186.MouseEnter, btn_AI185.MouseEnter, btn_AI184.MouseEnter, btn_AI183.MouseEnter, btn_AI182.MouseEnter, btn_AI181.MouseEnter, btn_AI180.MouseEnter, btn_AI18.MouseEnter, btn_AI179.MouseEnter, btn_AI178.MouseEnter, btn_AI177.MouseEnter, btn_AI176.MouseEnter, btn_AI175.MouseEnter, btn_AI174.MouseEnter, btn_AI173.MouseEnter, btn_AI172.MouseEnter, btn_AI171.MouseEnter, btn_AI170.MouseEnter, btn_AI17.MouseEnter, btn_AI169.MouseEnter, btn_AI168.MouseEnter, btn_AI167.MouseEnter, btn_AI166.MouseEnter, btn_AI165.MouseEnter, btn_AI164.MouseEnter, btn_AI163.MouseEnter, btn_AI162.MouseEnter, btn_AI161.MouseEnter, btn_AI160.MouseEnter, btn_AI16.MouseEnter, btn_AI159.MouseEnter, btn_AI158.MouseEnter, btn_AI157.MouseEnter, btn_AI156.MouseEnter, btn_AI155.MouseEnter, btn_AI154.MouseEnter, btn_AI153.MouseEnter, btn_AI152.MouseEnter, btn_AI151.MouseEnter, btn_AI150.MouseEnter, btn_AI15.MouseEnter, btn_AI149.MouseEnter, btn_AI148.MouseEnter, btn_AI147.MouseEnter, btn_AI146.MouseEnter, btn_AI145.MouseEnter, btn_AI144.MouseEnter, btn_AI143.MouseEnter, btn_AI142.MouseEnter, btn_AI141.MouseEnter, btn_AI140.MouseEnter, btn_AI14.MouseEnter, btn_AI139.MouseEnter, btn_AI138.MouseEnter, btn_AI137.MouseEnter, btn_AI136.MouseEnter, btn_AI135.MouseEnter, btn_AI134.MouseEnter, btn_AI133.MouseEnter, btn_AI132.MouseEnter, btn_AI131.MouseEnter, btn_AI130.MouseEnter, btn_AI13.MouseEnter, btn_AI129.MouseEnter, btn_AI128.MouseEnter, btn_AI127.MouseEnter, btn_AI126.MouseEnter, btn_AI125.MouseEnter, btn_AI124.MouseEnter, btn_AI123.MouseEnter, btn_AI122.MouseEnter, btn_AI121.MouseEnter, btn_AI120.MouseEnter, btn_AI12.MouseEnter, btn_AI119.MouseEnter, btn_AI118.MouseEnter, btn_AI117.MouseEnter, btn_AI115.MouseEnter, btn_AI114.MouseEnter, btn_AI113.MouseEnter, btn_AI112.MouseEnter, btn_AI1116.MouseEnter, btn_AI111.MouseEnter, btn_AI110.MouseEnter, btn_AI11.MouseEnter, btn_AI109.MouseEnter, btn_AI108.MouseEnter, btn_AI107.MouseEnter, btn_AI106.MouseEnter, btn_AI105.MouseEnter, btn_AI104.MouseEnter, btn_AI103.MouseEnter, btn_AI102.MouseEnter, btn_AI101.MouseEnter, btn_AI100.MouseEnter, btn_AI10.MouseEnter, btn_AI09.MouseEnter, btn_AI08.MouseEnter, btn_AI07.MouseEnter, btn_AI06.MouseEnter, btn_AI05.MouseEnter, btn_AI04.MouseEnter, btn_AD99.MouseEnter, btn_AD98.MouseEnter, btn_AD97.MouseEnter, btn_AD96.MouseEnter, btn_AD95.MouseEnter, btn_AD94.MouseEnter, btn_AD93.MouseEnter, btn_AD92.MouseEnter, btn_AD91.MouseEnter, btn_AD90.MouseEnter, btn_AD89.MouseEnter, btn_AD88.MouseEnter, btn_AD87.MouseEnter, btn_AD86.MouseEnter, btn_AD85.MouseEnter, btn_AD84.MouseEnter, btn_AD83.MouseEnter, btn_AD82.MouseEnter, btn_AD81.MouseEnter, btn_AD80.MouseEnter, btn_AD79.MouseEnter, btn_AD78.MouseEnter, btn_AD77.MouseEnter, btn_AD76.MouseEnter, btn_AD75.MouseEnter, btn_AD74.MouseEnter, btn_AD73.MouseEnter, btn_AD72.MouseEnter, btn_AD71.MouseEnter, btn_AD70.MouseEnter, btn_AD69.MouseEnter, btn_AD68.MouseEnter, btn_AD67.MouseEnter, btn_AD66.MouseEnter, btn_AD65.MouseEnter, btn_AD64.MouseEnter, btn_AD63.MouseEnter, btn_AD62.MouseEnter, btn_AD61.MouseEnter, btn_AD60.MouseEnter, btn_AD59.MouseEnter, btn_AD58.MouseEnter, btn_AD57.MouseEnter, btn_AD56.MouseEnter, btn_AD55.MouseEnter, btn_AD54.MouseEnter, btn_AD53.MouseEnter, btn_AD52.MouseEnter, btn_AD51.MouseEnter, btn_AD50.MouseEnter, btn_AD49.MouseEnter, btn_AD48.MouseEnter, btn_AD47.MouseEnter, btn_AD46.MouseEnter, btn_AD45.MouseEnter, btn_AD44.MouseEnter, btn_AD43.MouseEnter, btn_AD42.MouseEnter, btn_AD41.MouseEnter, btn_AD40.MouseEnter, btn_AD39.MouseEnter, btn_AD38.MouseEnter, btn_AD37.MouseEnter, btn_AD36.MouseEnter, btn_AD35.MouseEnter, btn_AD34.MouseEnter, btn_AD33.MouseEnter, btn_AD32.MouseEnter, btn_AD31.MouseEnter, btn_AD30.MouseEnter, btn_AD29.MouseEnter, btn_AD28.MouseEnter, btn_AD27.MouseEnter, btn_AD26.MouseEnter, btn_AD25.MouseEnter, btn_AD24.MouseEnter, btn_AD230.MouseEnter, btn_AD23.MouseEnter, btn_AD229.MouseEnter, btn_AD228.MouseEnter, btn_AD227.MouseEnter, btn_AD226.MouseEnter, btn_AD225.MouseEnter, btn_AD224.MouseEnter, btn_AD223.MouseEnter, btn_AD222.MouseEnter, btn_AD221.MouseEnter, btn_AD220.MouseEnter, btn_AD22.MouseEnter, btn_AD219.MouseEnter, btn_AD218.MouseEnter, btn_AD217.MouseEnter, btn_AD216.MouseEnter, btn_AD215.MouseEnter, btn_AD214.MouseEnter, btn_AD213.MouseEnter, btn_AD212.MouseEnter, btn_AD211.MouseEnter, btn_AD210.MouseEnter, btn_AD21.MouseEnter, btn_AD209.MouseEnter, btn_AD208.MouseEnter, btn_AD207.MouseEnter, btn_AD206.MouseEnter, btn_AD205.MouseEnter, btn_AD204.MouseEnter, btn_AD203.MouseEnter, btn_AD202.MouseEnter, btn_AD201.MouseEnter, btn_AD200.MouseEnter, btn_AD20.MouseEnter, btn_AD199.MouseEnter, btn_AD198.MouseEnter, btn_AD197.MouseEnter, btn_AD196.MouseEnter, btn_AD195.MouseEnter, btn_AD194.MouseEnter, btn_AD193.MouseEnter, btn_AD192.MouseEnter, btn_AD191.MouseEnter, btn_AD190.MouseEnter, btn_AD19.MouseEnter, btn_AD189.MouseEnter, btn_AD188.MouseEnter, btn_AD187.MouseEnter, btn_AD186.MouseEnter, btn_AD185.MouseEnter, btn_AD184.MouseEnter, btn_AD183.MouseEnter, btn_AD182.MouseEnter, btn_AD181.MouseEnter, btn_AD180.MouseEnter, btn_AD18.MouseEnter, btn_AD179.MouseEnter, btn_AD178.MouseEnter, btn_AD177.MouseEnter, btn_AD176.MouseEnter, btn_AD175.MouseEnter, btn_AD174.MouseEnter, btn_AD173.MouseEnter, btn_AD172.MouseEnter, btn_AD171.MouseEnter, btn_AD170.MouseEnter, btn_AD17.MouseEnter, btn_AD169.MouseEnter, btn_AD168.MouseEnter, btn_AD167.MouseEnter, btn_AD166.MouseEnter, btn_AD165.MouseEnter, btn_AD164.MouseEnter, btn_AD163.MouseEnter, btn_AD162.MouseEnter, btn_AD161.MouseEnter, btn_AD160.MouseEnter, btn_AD16.MouseEnter, btn_AD159.MouseEnter, btn_AD158.MouseEnter, btn_AD157.MouseEnter, btn_AD156.MouseEnter, btn_AD155.MouseEnter, btn_AD154.MouseEnter, btn_AD153.MouseEnter, btn_AD152.MouseEnter, btn_AD151.MouseEnter, btn_AD150.MouseEnter, btn_AD15.MouseEnter, btn_AD149.MouseEnter, btn_AD148.MouseEnter, btn_AD147.MouseEnter, btn_AD146.MouseEnter, btn_AD145.MouseEnter, btn_AD144.MouseEnter, btn_AD143.MouseEnter, btn_AD142.MouseEnter, btn_AD141.MouseEnter, btn_AD140.MouseEnter, btn_AD14.MouseEnter, btn_AD139.MouseEnter, btn_AD138.MouseEnter, btn_AD137.MouseEnter, btn_AD136.MouseEnter, btn_AD135.MouseEnter, btn_AD134.MouseEnter, btn_AD133.MouseEnter, btn_AD132.MouseEnter, btn_AD131.MouseEnter, btn_AD130.MouseEnter, btn_AD13.MouseEnter, btn_AD129.MouseEnter, btn_AD128.MouseEnter, btn_AD127.MouseEnter, btn_AD126.MouseEnter, btn_AD125.MouseEnter, btn_AD124.MouseEnter, btn_AD123.MouseEnter, btn_AD122.MouseEnter, btn_AD121.MouseEnter, btn_AD120.MouseEnter, btn_AD12.MouseEnter, btn_AD119.MouseEnter, btn_AD118.MouseEnter, btn_AD117.MouseEnter, btn_AD116.MouseEnter, btn_AD115.MouseEnter, btn_AD114.MouseEnter, btn_AD113.MouseEnter, btn_AD112.MouseEnter, btn_AD111.MouseEnter, btn_AD110.MouseEnter, btn_AD11.MouseEnter, btn_AD109.MouseEnter, btn_AD108.MouseEnter, btn_AD107.MouseEnter, btn_AD106.MouseEnter, btn_AD105.MouseEnter, btn_AD104.MouseEnter, btn_AD103.MouseEnter, btn_AD102.MouseEnter, btn_AD101.MouseEnter, btn_AD100.MouseEnter, btn_AD10.MouseEnter, btn_AD09.MouseEnter, btn_AD08.MouseEnter, btn_AD07.MouseEnter, btn_AD06.MouseEnter, btn_AD05.MouseEnter, btn_AD04.MouseEnter, btn_AD03.MouseEnter, btn_AD02.MouseEnter, btn_AD01.MouseEnter
        If sender.name Like "btn_Aud*" Then
            sender.backcolor = Color.Yellow
        End If
    End Sub


    Private Sub boton_sinenfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AI01.MouseLeave, btn_AI03.MouseLeave, btn_AI02.MouseLeave, btn_AI99.MouseLeave, btn_AI98.MouseLeave, btn_AI97.MouseLeave, btn_AI96.MouseLeave, btn_AI95.MouseLeave, btn_AI94.MouseLeave, btn_AI93.MouseLeave, btn_AI92.MouseLeave, btn_AI91.MouseLeave, btn_AI90.MouseLeave, btn_AI89.MouseLeave, btn_AI88.MouseLeave, btn_AI87.MouseLeave, btn_AI86.MouseLeave, btn_AI85.MouseLeave, btn_AI84.MouseLeave, btn_AI83.MouseLeave, btn_AI82.MouseLeave, btn_AI81.MouseLeave, btn_AI80.MouseLeave, btn_AI79.MouseLeave, btn_AI78.MouseLeave, btn_AI77.MouseLeave, btn_AI76.MouseLeave, btn_AI75.MouseLeave, btn_AI74.MouseLeave, btn_AI73.MouseLeave, btn_AI72.MouseLeave, btn_AI71.MouseLeave, btn_AI70.MouseLeave, btn_AI69.MouseLeave, btn_AI68.MouseLeave, btn_AI67.MouseLeave, btn_AI66.MouseLeave, btn_AI65.MouseLeave, btn_AI64.MouseLeave, btn_AI63.MouseLeave, btn_AI62.MouseLeave, btn_AI61.MouseLeave, btn_AI60.MouseLeave, btn_AI59.MouseLeave, btn_AI58.MouseLeave, btn_AI57.MouseLeave, btn_AI56.MouseLeave, btn_AI55.MouseLeave, btn_AI54.MouseLeave, btn_AI53.MouseLeave, btn_AI52.MouseLeave, btn_AI51.MouseLeave, btn_AI50.MouseLeave, btn_AI49.MouseLeave, btn_AI48.MouseLeave, btn_AI47.MouseLeave, btn_AI46.MouseLeave, btn_AI45.MouseLeave, btn_AI44.MouseLeave, btn_AI43.MouseLeave, btn_AI42.MouseLeave, btn_AI41.MouseLeave, btn_AI40.MouseLeave, btn_AI39.MouseLeave, btn_AI38.MouseLeave, btn_AI37.MouseLeave, btn_AI36.MouseLeave, btn_AI35.MouseLeave, btn_AI34.MouseLeave, btn_AI33.MouseLeave, btn_AI32.MouseLeave, btn_AI31.MouseLeave, btn_AI30.MouseLeave, btn_AI29.MouseLeave, btn_AI28.MouseLeave, btn_AI27.MouseLeave, btn_AI26.MouseLeave, btn_AI25.MouseLeave, btn_AI24.MouseLeave, btn_AI230.MouseLeave, btn_AI23.MouseLeave, btn_AI229.MouseLeave, btn_AI228.MouseLeave, btn_AI227.MouseLeave, btn_AI226.MouseLeave, btn_AI225.MouseLeave, btn_AI224.MouseLeave, btn_AI223.MouseLeave, btn_AI222.MouseLeave, btn_AI221.MouseLeave, btn_AI220.MouseLeave, btn_AI22.MouseLeave, btn_AI219.MouseLeave, btn_AI218.MouseLeave, btn_AI217.MouseLeave, btn_AI216.MouseLeave, btn_AI215.MouseLeave, btn_AI214.MouseLeave, btn_AI213.MouseLeave, btn_AI212.MouseLeave, btn_AI211.MouseLeave, btn_AI210.MouseLeave, btn_AI21.MouseLeave, btn_AI209.MouseLeave, btn_AI208.MouseLeave, btn_AI207.MouseLeave, btn_AI206.MouseLeave, btn_AI205.MouseLeave, btn_AI204.MouseLeave, btn_AI203.MouseLeave, btn_AI202.MouseLeave, btn_AI201.MouseLeave, btn_AI200.MouseLeave, btn_AI20.MouseLeave, btn_AI199.MouseLeave, btn_AI198.MouseLeave, btn_AI197.MouseLeave, btn_AI196.MouseLeave, btn_AI195.MouseLeave, btn_AI194.MouseLeave, btn_AI193.MouseLeave, btn_AI192.MouseLeave, btn_AI191.MouseLeave, btn_AI190.MouseLeave, btn_AI19.MouseLeave, btn_AI189.MouseLeave, btn_AI188.MouseLeave, btn_AI187.MouseLeave, btn_AI186.MouseLeave, btn_AI185.MouseLeave, btn_AI184.MouseLeave, btn_AI183.MouseLeave, btn_AI182.MouseLeave, btn_AI181.MouseLeave, btn_AI180.MouseLeave, btn_AI18.MouseLeave, btn_AI179.MouseLeave, btn_AI178.MouseLeave, btn_AI177.MouseLeave, btn_AI176.MouseLeave, btn_AI175.MouseLeave, btn_AI174.MouseLeave, btn_AI173.MouseLeave, btn_AI172.MouseLeave, btn_AI171.MouseLeave, btn_AI170.MouseLeave, btn_AI17.MouseLeave, btn_AI169.MouseLeave, btn_AI168.MouseLeave, btn_AI167.MouseLeave, btn_AI166.MouseLeave, btn_AI165.MouseLeave, btn_AI164.MouseLeave, btn_AI163.MouseLeave, btn_AI162.MouseLeave, btn_AI161.MouseLeave, btn_AI160.MouseLeave, btn_AI16.MouseLeave, btn_AI159.MouseLeave, btn_AI158.MouseLeave, btn_AI157.MouseLeave, btn_AI156.MouseLeave, btn_AI155.MouseLeave, btn_AI154.MouseLeave, btn_AI153.MouseLeave, btn_AI152.MouseLeave, btn_AI151.MouseLeave, btn_AI150.MouseLeave, btn_AI15.MouseLeave, btn_AI149.MouseLeave, btn_AI148.MouseLeave, btn_AI147.MouseLeave, btn_AI146.MouseLeave, btn_AI145.MouseLeave, btn_AI144.MouseLeave, btn_AI143.MouseLeave, btn_AI142.MouseLeave, btn_AI141.MouseLeave, btn_AI140.MouseLeave, btn_AI14.MouseLeave, btn_AI139.MouseLeave, btn_AI138.MouseLeave, btn_AI137.MouseLeave, btn_AI136.MouseLeave, btn_AI135.MouseLeave, btn_AI134.MouseLeave, btn_AI133.MouseLeave, btn_AI132.MouseLeave, btn_AI131.MouseLeave, btn_AI130.MouseLeave, btn_AI13.MouseLeave, btn_AI129.MouseLeave, btn_AI128.MouseLeave, btn_AI127.MouseLeave, btn_AI126.MouseLeave, btn_AI125.MouseLeave, btn_AI124.MouseLeave, btn_AI123.MouseLeave, btn_AI122.MouseLeave, btn_AI121.MouseLeave, btn_AI120.MouseLeave, btn_AI12.MouseLeave, btn_AI119.MouseLeave, btn_AI118.MouseLeave, btn_AI117.MouseLeave, btn_AI115.MouseLeave, btn_AI114.MouseLeave, btn_AI113.MouseLeave, btn_AI112.MouseLeave, btn_AI1116.MouseLeave, btn_AI111.MouseLeave, btn_AI110.MouseLeave, btn_AI11.MouseLeave, btn_AI109.MouseLeave, btn_AI108.MouseLeave, btn_AI107.MouseLeave, btn_AI106.MouseLeave, btn_AI105.MouseLeave, btn_AI104.MouseLeave, btn_AI103.MouseLeave, btn_AI102.MouseLeave, btn_AI101.MouseLeave, btn_AI100.MouseLeave, btn_AI10.MouseLeave, btn_AI09.MouseLeave, btn_AI08.MouseLeave, btn_AI07.MouseLeave, btn_AI06.MouseLeave, btn_AI05.MouseLeave, btn_AI04.MouseLeave, btn_AD99.MouseLeave, btn_AD98.MouseLeave, btn_AD97.MouseLeave, btn_AD96.MouseLeave, btn_AD95.MouseLeave, btn_AD94.MouseLeave, btn_AD93.MouseLeave, btn_AD92.MouseLeave, btn_AD91.MouseLeave, btn_AD90.MouseLeave, btn_AD89.MouseLeave, btn_AD88.MouseLeave, btn_AD87.MouseLeave, btn_AD86.MouseLeave, btn_AD85.MouseLeave, btn_AD84.MouseLeave, btn_AD83.MouseLeave, btn_AD82.MouseLeave, btn_AD81.MouseLeave, btn_AD80.MouseLeave, btn_AD79.MouseLeave, btn_AD78.MouseLeave, btn_AD77.MouseLeave, btn_AD76.MouseLeave, btn_AD75.MouseLeave, btn_AD74.MouseLeave, btn_AD73.MouseLeave, btn_AD72.MouseLeave, btn_AD71.MouseLeave, btn_AD70.MouseLeave, btn_AD69.MouseLeave, btn_AD68.MouseLeave, btn_AD67.MouseLeave, btn_AD66.MouseLeave, btn_AD65.MouseLeave, btn_AD64.MouseLeave, btn_AD63.MouseLeave, btn_AD62.MouseLeave, btn_AD61.MouseLeave, btn_AD60.MouseLeave, btn_AD59.MouseLeave, btn_AD58.MouseLeave, btn_AD57.MouseLeave, btn_AD56.MouseLeave, btn_AD55.MouseLeave, btn_AD54.MouseLeave, btn_AD53.MouseLeave, btn_AD52.MouseLeave, btn_AD51.MouseLeave, btn_AD50.MouseLeave, btn_AD49.MouseLeave, btn_AD48.MouseLeave, btn_AD47.MouseLeave, btn_AD46.MouseLeave, btn_AD45.MouseLeave, btn_AD44.MouseLeave, btn_AD43.MouseLeave, btn_AD42.MouseLeave, btn_AD41.MouseLeave, btn_AD40.MouseLeave, btn_AD39.MouseLeave, btn_AD38.MouseLeave, btn_AD37.MouseLeave, btn_AD36.MouseLeave, btn_AD35.MouseLeave, btn_AD34.MouseLeave, btn_AD33.MouseLeave, btn_AD32.MouseLeave, btn_AD31.MouseLeave, btn_AD30.MouseLeave, btn_AD29.MouseLeave, btn_AD28.MouseLeave, btn_AD27.MouseLeave, btn_AD26.MouseLeave, btn_AD25.MouseLeave, btn_AD24.MouseLeave, btn_AD230.MouseLeave, btn_AD23.MouseLeave, btn_AD229.MouseLeave, btn_AD228.MouseLeave, btn_AD227.MouseLeave, btn_AD226.MouseLeave, btn_AD225.MouseLeave, btn_AD224.MouseLeave, btn_AD223.MouseLeave, btn_AD222.MouseLeave, btn_AD221.MouseLeave, btn_AD220.MouseLeave, btn_AD22.MouseLeave, btn_AD219.MouseLeave, btn_AD218.MouseLeave, btn_AD217.MouseLeave, btn_AD216.MouseLeave, btn_AD215.MouseLeave, btn_AD214.MouseLeave, btn_AD213.MouseLeave, btn_AD212.MouseLeave, btn_AD211.MouseLeave, btn_AD210.MouseLeave, btn_AD21.MouseLeave, btn_AD209.MouseLeave, btn_AD208.MouseLeave, btn_AD207.MouseLeave, btn_AD206.MouseLeave, btn_AD205.MouseLeave, btn_AD204.MouseLeave, btn_AD203.MouseLeave, btn_AD202.MouseLeave, btn_AD201.MouseLeave, btn_AD200.MouseLeave, btn_AD20.MouseLeave, btn_AD199.MouseLeave, btn_AD198.MouseLeave, btn_AD197.MouseLeave, btn_AD196.MouseLeave, btn_AD195.MouseLeave, btn_AD194.MouseLeave, btn_AD193.MouseLeave, btn_AD192.MouseLeave, btn_AD191.MouseLeave, btn_AD190.MouseLeave, btn_AD19.MouseLeave, btn_AD189.MouseLeave, btn_AD188.MouseLeave, btn_AD187.MouseLeave, btn_AD186.MouseLeave, btn_AD185.MouseLeave, btn_AD184.MouseLeave, btn_AD183.MouseLeave, btn_AD182.MouseLeave, btn_AD181.MouseLeave, btn_AD180.MouseLeave, btn_AD18.MouseLeave, btn_AD179.MouseLeave, btn_AD178.MouseLeave, btn_AD177.MouseLeave, btn_AD176.MouseLeave, btn_AD175.MouseLeave, btn_AD174.MouseLeave, btn_AD173.MouseLeave, btn_AD172.MouseLeave, btn_AD171.MouseLeave, btn_AD170.MouseLeave, btn_AD17.MouseLeave, btn_AD169.MouseLeave, btn_AD168.MouseLeave, btn_AD167.MouseLeave, btn_AD166.MouseLeave, btn_AD165.MouseLeave, btn_AD164.MouseLeave, btn_AD163.MouseLeave, btn_AD162.MouseLeave, btn_AD161.MouseLeave, btn_AD160.MouseLeave, btn_AD16.MouseLeave, btn_AD159.MouseLeave, btn_AD158.MouseLeave, btn_AD157.MouseLeave, btn_AD156.MouseLeave, btn_AD155.MouseLeave, btn_AD154.MouseLeave, btn_AD153.MouseLeave, btn_AD152.MouseLeave, btn_AD151.MouseLeave, btn_AD150.MouseLeave, btn_AD15.MouseLeave, btn_AD149.MouseLeave, btn_AD148.MouseLeave, btn_AD147.MouseLeave, btn_AD146.MouseLeave, btn_AD145.MouseLeave, btn_AD144.MouseLeave, btn_AD143.MouseLeave, btn_AD142.MouseLeave, btn_AD141.MouseLeave, btn_AD140.MouseLeave, btn_AD14.MouseLeave, btn_AD139.MouseLeave, btn_AD138.MouseLeave, btn_AD137.MouseLeave, btn_AD136.MouseLeave, btn_AD135.MouseLeave, btn_AD134.MouseLeave, btn_AD133.MouseLeave, btn_AD132.MouseLeave, btn_AD131.MouseLeave, btn_AD130.MouseLeave, btn_AD13.MouseLeave, btn_AD129.MouseLeave, btn_AD128.MouseLeave, btn_AD127.MouseLeave, btn_AD126.MouseLeave, btn_AD125.MouseLeave, btn_AD124.MouseLeave, btn_AD123.MouseLeave, btn_AD122.MouseLeave, btn_AD121.MouseLeave, btn_AD120.MouseLeave, btn_AD12.MouseLeave, btn_AD119.MouseLeave, btn_AD118.MouseLeave, btn_AD117.MouseLeave, btn_AD116.MouseLeave, btn_AD115.MouseLeave, btn_AD114.MouseLeave, btn_AD113.MouseLeave, btn_AD112.MouseLeave, btn_AD111.MouseLeave, btn_AD110.MouseLeave, btn_AD11.MouseLeave, btn_AD109.MouseLeave, btn_AD108.MouseLeave, btn_AD107.MouseLeave, btn_AD106.MouseLeave, btn_AD105.MouseLeave, btn_AD104.MouseLeave, btn_AD103.MouseLeave, btn_AD102.MouseLeave, btn_AD101.MouseLeave, btn_AD100.MouseLeave, btn_AD10.MouseLeave, btn_AD09.MouseLeave, btn_AD08.MouseLeave, btn_AD07.MouseLeave, btn_AD06.MouseLeave, btn_AD05.MouseLeave, btn_AD04.MouseLeave, btn_AD03.MouseLeave, btn_AD02.MouseLeave, btn_AD01.MouseLeave
        If sender.name Like "btn_Aud*" Then
            sender.backcolor = Color.White
        End If
    End Sub


    Private Sub boton_selecciona(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AI01.Click, btn_AI02.Click, btn_AI03.Click, btn_AI07.Click, btn_AI06.Click, btn_AI05.Click, btn_AI04.Click, btn_AI10.Click, btn_AI09.Click, btn_AI08.Click, btn_AI133.Click, btn_AI134.Click, btn_AI135.Click, btn_AI136.Click, btn_AI137.Click, btn_AI138.Click, btn_AI139.Click, btn_AI140.Click, btn_AI41.Click, btn_AI42.Click, btn_AI43.Click, btn_AI44.Click, btn_AI45.Click, btn_AI46.Click, btn_AI47.Click, btn_AI48.Click, btn_AI49.Click, btn_AI50.Click, btn_AI51.Click, btn_AI52.Click, btn_AI53.Click, btn_AI54.Click, btn_AI55.Click, btn_AI56.Click, btn_AI57.Click, btn_AI58.Click, btn_AI59.Click, btn_AI60.Click, btn_AI61.Click, btn_AI62.Click, btn_AI63.Click, btn_AI64.Click, btn_AI65.Click, btn_AI66.Click, btn_AI67.Click, btn_AI68.Click, btn_AI69.Click, btn_AI70.Click, btn_AI71.Click, btn_AI72.Click, btn_AI73.Click, btn_AI74.Click, btn_AI75.Click, btn_AI76.Click, btn_AI77.Click, btn_AI78.Click, btn_AI79.Click, btn_AI80.Click, btn_AI21.Click, btn_AI22.Click, btn_AI23.Click, btn_AI24.Click, btn_AI25.Click, btn_AI26.Click, btn_AI27.Click, btn_AI28.Click, btn_AI29.Click, btn_AI30.Click, btn_AI31.Click, btn_AI32.Click, btn_AI33.Click, btn_AI35.Click, btn_AI36.Click, btn_AI81.Click, btn_AI82.Click, btn_AI37.Click, btn_AI83.Click, btn_AI84.Click, btn_AI85.Click, btn_AI86.Click, btn_AI87.Click, btn_AI88.Click, btn_AI89.Click, btn_AI90.Click, btn_AI91.Click, btn_AI92.Click, btn_AI38.Click, btn_AI93.Click, btn_AI94.Click, btn_AI95.Click, btn_AI96.Click, btn_AI97.Click, btn_AI98.Click, btn_AI99.Click, btn_AI100.Click, btn_AI101.Click, btn_AI102.Click, btn_AI39.Click, btn_AI103.Click, btn_AI104.Click, btn_AI105.Click, btn_AI106.Click, btn_AI107.Click, btn_AI108.Click, btn_AI109.Click, btn_AI110.Click, btn_AI111.Click, btn_AI112.Click, btn_AI40.Click, btn_AI113.Click, btn_AI114.Click, btn_AI115.Click, btn_AI1116.Click, btn_AI117.Click, btn_AI118.Click, btn_AI119.Click, btn_AI120.Click, btn_AI121.Click, btn_AI122.Click, btn_AI123.Click, btn_AI124.Click, btn_AI125.Click, btn_AI126.Click, btn_AI127.Click, btn_AI128.Click, btn_AI129.Click, btn_AI130.Click, btn_AI131.Click, btn_AI132.Click, btn_AI20.Click, btn_AI19.Click, btn_AI18.Click, btn_AI17.Click, btn_AI16.Click, btn_AI15.Click, btn_AI14.Click, btn_AI13.Click, btn_AI12.Click, btn_AI11.Click, btn_AI155.Click, btn_AI154.Click, btn_AI153.Click, btn_AI152.Click, btn_AI151.Click, btn_AI150.Click, btn_AI149.Click, btn_AI148.Click, btn_AI147.Click, btn_AI146.Click, btn_AI145.Click, btn_AI144.Click, btn_AI143.Click, btn_AI142.Click, btn_AI141.Click, btn_AI230.Click, btn_AI229.Click, btn_AI228.Click, btn_AI227.Click, btn_AI226.Click, btn_AI225.Click, btn_AI224.Click, btn_AI223.Click, btn_AI222.Click, btn_AI221.Click, btn_AI220.Click, btn_AI219.Click, btn_AI218.Click, btn_AI217.Click, btn_AI216.Click, btn_AI215.Click, btn_AI214.Click, btn_AI213.Click, btn_AI212.Click, btn_AI211.Click, btn_AI210.Click, btn_AI209.Click, btn_AI208.Click, btn_AI207.Click, btn_AI206.Click, btn_AI205.Click, btn_AI204.Click, btn_AI203.Click, btn_AI202.Click, btn_AI201.Click, btn_AI200.Click, btn_AI199.Click, btn_AI198.Click, btn_AI197.Click, btn_AI196.Click, btn_AI195.Click, btn_AI194.Click, btn_AI193.Click, btn_AI192.Click, btn_AI191.Click, btn_AI190.Click, btn_AI189.Click, btn_AI188.Click, btn_AI187.Click, btn_AI186.Click, btn_AI185.Click, btn_AI184.Click, btn_AI183.Click, btn_AI182.Click, btn_AI181.Click, btn_AI180.Click, btn_AI179.Click, btn_AI178.Click, btn_AI177.Click, btn_AI176.Click, btn_AI175.Click, btn_AI174.Click, btn_AI173.Click, btn_AI172.Click, btn_AI171.Click, btn_AI170.Click, btn_AI169.Click, btn_AI168.Click, btn_AI167.Click, btn_AI166.Click, btn_AI165.Click, btn_AI164.Click, btn_AI163.Click, btn_AI162.Click, btn_AI161.Click, btn_AI160.Click, btn_AI159.Click, btn_AI158.Click, btn_AI157.Click, btn_AI156.Click, btn_AD99.Click, btn_AD98.Click, btn_AD97.Click, btn_AD96.Click, btn_AD95.Click, btn_AD94.Click, btn_AD93.Click, btn_AD92.Click, btn_AD91.Click, btn_AD90.Click, btn_AD89.Click, btn_AD88.Click, btn_AD87.Click, btn_AD86.Click, btn_AD85.Click, btn_AD84.Click, btn_AD83.Click, btn_AD82.Click, btn_AD81.Click, btn_AD80.Click, btn_AD79.Click, btn_AD78.Click, btn_AD77.Click, btn_AD76.Click, btn_AD75.Click, btn_AD74.Click, btn_AD73.Click, btn_AD72.Click, btn_AD71.Click, btn_AD70.Click, btn_AD69.Click, btn_AD68.Click, btn_AD67.Click, btn_AD66.Click, btn_AD65.Click, btn_AD64.Click, btn_AD63.Click, btn_AD62.Click, btn_AD61.Click, btn_AD60.Click, btn_AD59.Click, btn_AD58.Click, btn_AD57.Click, btn_AD56.Click, btn_AD55.Click, btn_AD54.Click, btn_AD53.Click, btn_AD52.Click, btn_AD51.Click, btn_AD50.Click, btn_AD49.Click, btn_AD48.Click, btn_AD47.Click, btn_AD46.Click, btn_AD45.Click, btn_AD44.Click, btn_AD43.Click, btn_AD42.Click, btn_AD41.Click, btn_AD40.Click, btn_AD39.Click, btn_AD38.Click, btn_AD37.Click, btn_AD36.Click, btn_AD35.Click, btn_AD34.Click, btn_AD33.Click, btn_AD32.Click, btn_AD31.Click, btn_AD30.Click, btn_AD29.Click, btn_AD28.Click, btn_AD27.Click, btn_AD26.Click, btn_AD25.Click, btn_AD24.Click, btn_AD230.Click, btn_AD23.Click, btn_AD229.Click, btn_AD228.Click, btn_AD227.Click, btn_AD226.Click, btn_AD225.Click, btn_AD224.Click, btn_AD223.Click, btn_AD222.Click, btn_AD221.Click, btn_AD220.Click, btn_AD22.Click, btn_AD219.Click, btn_AD218.Click, btn_AD217.Click, btn_AD216.Click, btn_AD215.Click, btn_AD214.Click, btn_AD213.Click, btn_AD212.Click, btn_AD211.Click, btn_AD210.Click, btn_AD21.Click, btn_AD209.Click, btn_AD208.Click, btn_AD207.Click, btn_AD206.Click, btn_AD205.Click, btn_AD204.Click, btn_AD203.Click, btn_AD202.Click, btn_AD201.Click, btn_AD200.Click, btn_AD20.Click, btn_AD199.Click, btn_AD198.Click, btn_AD197.Click, btn_AD196.Click, btn_AD195.Click, btn_AD194.Click, btn_AD193.Click, btn_AD192.Click, btn_AD191.Click, btn_AD190.Click, btn_AD19.Click, btn_AD189.Click, btn_AD188.Click, btn_AD187.Click, btn_AD186.Click, btn_AD185.Click, btn_AD184.Click, btn_AD183.Click, btn_AD182.Click, btn_AD181.Click, btn_AD180.Click, btn_AD18.Click, btn_AD179.Click, btn_AD178.Click, btn_AD177.Click, btn_AD176.Click, btn_AD175.Click, btn_AD174.Click, btn_AD173.Click, btn_AD172.Click, btn_AD171.Click, btn_AD170.Click, btn_AD17.Click, btn_AD169.Click, btn_AD168.Click, btn_AD167.Click, btn_AD166.Click, btn_AD165.Click, btn_AD164.Click, btn_AD163.Click, btn_AD162.Click, btn_AD161.Click, btn_AD160.Click, btn_AD16.Click, btn_AD159.Click, btn_AD158.Click, btn_AD157.Click, btn_AD156.Click, btn_AD155.Click, btn_AD154.Click, btn_AD153.Click, btn_AD152.Click, btn_AD151.Click, btn_AD150.Click, btn_AD15.Click, btn_AD149.Click, btn_AD148.Click, btn_AD147.Click, btn_AD146.Click, btn_AD145.Click, btn_AD144.Click, btn_AD143.Click, btn_AD142.Click, btn_AD141.Click, btn_AD140.Click, btn_AD14.Click, btn_AD139.Click, btn_AD138.Click, btn_AD137.Click, btn_AD136.Click, btn_AD135.Click, btn_AD134.Click, btn_AD133.Click, btn_AD132.Click, btn_AD131.Click, btn_AD130.Click, btn_AD13.Click, btn_AD129.Click, btn_AD128.Click, btn_AD127.Click, btn_AD126.Click, btn_AD125.Click, btn_AD124.Click, btn_AD123.Click, btn_AD122.Click, btn_AD121.Click, btn_AD120.Click, btn_AD12.Click, btn_AD119.Click, btn_AD118.Click, btn_AD117.Click, btn_AD116.Click, btn_AD115.Click, btn_AD114.Click, btn_AD113.Click, btn_AD112.Click, btn_AD111.Click, btn_AD110.Click, btn_AD11.Click, btn_AD109.Click, btn_AD108.Click, btn_AD107.Click, btn_AD106.Click, btn_AD105.Click, btn_AD104.Click, btn_AD103.Click, btn_AD102.Click, btn_AD101.Click, btn_AD100.Click, btn_AD10.Click, btn_AD09.Click, btn_AD08.Click, btn_AD07.Click, btn_AD06.Click, btn_AD05.Click, btn_AD04.Click, btn_AD03.Click, btn_AD02.Click, btn_AD01.Click, btn_AI34.Click
        If sender.name Like "btn_AI*" Then
            If sender.text = "o" Then
                sender.text = ""
            Else
                sender.Font = New Font(Me.Font, FontStyle.Regular)
                sender.forecolor = Color.Black
                sender.text = "o"
            End If
        End If

        If sender.name Like "btn_AD*" Then
            If sender.text = "x" Then
                sender.text = ""
            Else
                sender.Font = New Font(Me.Font, FontStyle.Regular)
                sender.forecolor = Color.Black
                sender.text = "x"
            End If
        End If
    End Sub



    Private Sub ConvierteBase64QR(ByVal path As String, ByVal nombreFILE As String, ByVal ped_id As Long)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim param As SqlParameter
        Dim beneficiosVida As Byte()
        Dim archivo As String = path & "\" & ped_id & ".jpg"
        Dim img_orden As String = Format(Now, "yy") & Trim(Mid(nombreFILE, 1, 9))

        beneficiosVida = File.ReadAllBytes(Environment.CurrentDirectory & "\" & archivo)
        Dim base64String As String = Convert.ToBase64String(beneficiosVida, 0, beneficiosVida.Length)

        opr_Conexion.sql_conectar()
        STR_SQL = "update ptoimagen set img_base64 = '" & base64String & "', img_orden = '" & img_orden & "' where ped_id = " & ped_id & " and img_nombre = 'QR' "

        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar QR", Err)
        Err.Clear()

    End Sub



    Private Sub btn_validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validar.Click
        'BOTON VALIDAR
        Me.Tag = ""
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        Dim opr_test As New Cls_Test()
        Dim str_sql As String = Nothing
        Dim testcod As String


        On Error Resume Next
        If (lbl_PedidoD.Text <> "Pedido" And lbl_PedidoD.Text <> "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            'If MsgBox("Los cambios realizados en los resultados automáticos y las" & Chr(13) & "notas sobre los resultados del pedido serán almacenadas" & Chr(13) & "en este momento, desea continuar?", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim shr_x As Short = 0
            Dim int_codigo As Integer = 0
            Dim estavalidado As Integer
            Dim dtv_resauto As New DataView()
            Dim str_opera As String
            Dim Padre As Integer
            Dim resultado As String = Nothing
            Dim Pdfs As String

            Select Case dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(6).ToString
                Case 4 'MOLECULAR
                    int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString, CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString))
                    estavalidado = opr_trabajo.Leer_Validado(int_codigo)
                    Padre = CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString)
                    Select Case estavalidado
                        Case 0, 1, 2, 9
                            If txt_MuestraAnalizada.Text <> "" Then
                                Dim rango As String
                                Dim i As Integer
                                Dim resul As String
                                Dim res As String()

                                rango = Trim(txt_ValRefMolecular.Text)
                                str_sql = "select tes_id from test where TES_PADRE = " & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString & " order by TES_ID asc;"
                                paramMol = Split(opr_res.ConsultaMolecular(str_sql), "º")
                                For i = 0 To UBound(paramMol) - 1
                                    str_sql = "select TES_NOMBRE, tes_resdefecto, tes_lis from test where tes_id = " & CInt(paramMol(i)) & " and TES_PADRE = " & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString) & ""
                                    info = Split(opr_res.ConsultaSiHayMolecular(str_sql), "|")
                                    resul = Trim(txt_MolMuestra.Text) & "°" & Trim(txt_MolTecnica.Text) & "°" & Trim(txt_ValRefMolecular.Text) & "°" & Trim(txt_MuestraAnalizada.Text)
                                    res = Split(resul, "°")
                                    opr_res.ResAutoFinalPlatillas(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString), CInt(lbl_PedidoD.Text), Trim(info(2)), Trim(res(i)), Trim(res(0)), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(6).ToString, 1, CInt(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString)), CInt(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString)))
                                Next
                                str_opera = lbl_PedidoD.Text & "/" & CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString) & "/" & Trim(txt_MuestraAnalizada.Text)
                                'opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                                opr_pedido.ActualizarLis_resEstado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 2, Format(Now, "yyyy/MM/dd"))
                                opr_pedido.ActualizarPdd_Estado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 3)
                                opr_pedido.ActualizarEstadoPedido(CInt(lbl_PedidoD.Text), 5)   'El pedido esta solo con algunas pruebas validadas
                            Else
                                opr_pedido.VisualizaMensaje("Ingrese un valor para muestra analizada (Resultado)", 350)

                                'opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), dgrd_resPedido(shr_x, 4), "", Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 13), 1, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))
                                'str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                            End If
                        Case 9
                    End Select

                Case 6, 8 'PLATILLAS, CULTIVOS

                    dtv_resauto = dgrd_resPedido.DataSource
                    For shr_x = 0 To ((dtv_resauto.Table.Rows.Count) - 1)
                        int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_PedidoD.Text), CInt(dgrd_resPedido(shr_x, 16)), dgrd_resPedido(shr_x, 17))
                        estavalidado = opr_trabajo.Leer_Validado(int_codigo)
                        Padre = CInt(dgrd_resPedido(shr_x, 16))
                        Select Case estavalidado
                            Case 0, 1, 2
                                If (IsDBNull(dgrd_resPedido(shr_x, 6)) = False) Then 'And (Convert.ToString(dgrd_resPedido(shr_x, 6)) <> "")) Then
                                    If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                                        Dim rango As String
                                        rango = dgrd_resPedido(shr_x, 9)
                                        opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), Trim(dgrd_resPedido(shr_x, 4)), Trim(CStr(dgrd_resPedido(shr_x, 6))), Trim(rango), dgrd_resPedido(shr_x, 13), 1, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))
                                        str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                                        'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", "PEDIDO=" & lbl_PedidoD.Text, g_sng_user, lbl_PedidoD.Text, "")
                                        'opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
                                        opr_pedido.ActualizarLis_resEstado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 2, Format(Now, "yyyy/MM/dd"))
                                        opr_pedido.ActualizarPdd_Estado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 3)
                                        opr_pedido.ActualizarEstadoPedido(CInt(lbl_PedidoD.Text), 5)   'El pedido esta solo con algunas pruebas validadas
                                    End If
                                Else
                                    opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), dgrd_resPedido(shr_x, 4), "", Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 13), 1, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))
                                    str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                                End If
                            Case 9
                                If IsNumeric(CDbl(dgrd_resPedido(shr_x, 6))) Then
                                    opr_res.ResAutoFinal(CInt(dgrd_resPedido(shr_x, 15)), CInt(lbl_PedidoD.Text), dgrd_resPedido(shr_x, 4), CStr(dgrd_resPedido(shr_x, 6)), Trim(dgrd_resPedido(shr_x, 9)), dgrd_resPedido(shr_x, 13), 9, CInt(dgrd_resPedido(shr_x, 17)), CInt(dgrd_resPedido(shr_x, 16)))

                                    str_opera = lbl_PedidoD.Text & "/" & dgrd_resPedido(shr_x, 4) & "/" & CStr(dgrd_resPedido(shr_x, 6))
                                    'g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", str_opera, g_sng_user, lbl_PedidoD.Text, "")
                                    opr_trabajo.CambioEstadoItemLista(int_codigo, 9) ' ESTADO 9 remitido 
                                    opr_pedido.ActualizarPdd_Estado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)

                                End If

                        End Select

                    Next
                    'GUARDO LOS VALORES DEL ANTIBIOGRAMA
                    ''opr_res.EliminarAB_procesados(CInt(lbl_PedidoD.Text), Padre)
                    For shr_x = 0 To (dtv_resAB.Table.Rows.Count) - 1
                        opr_res.GuardarAB_procesados(CInt(lbl_PedidoD.Text), grd_antibioticos(shr_x, 0), grd_antibioticos(shr_x, 2), Padre, grd_antibioticos(shr_x, 1))
                    Next

                    

                Case 9  'DIAGNOSTICO
                    Dim arre_etiq As String()
                    Dim arre_valor As String()
                    Dim etiquetas As String = Nothing
                    Dim valores As String = Nothing
                    Dim i As Integer = 0


                    int_codigo = opr_trabajo.Leer_Lis_ID(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString, CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString))
                    estavalidado = opr_trabajo.Leer_Validado(int_codigo)
                    Padre = CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString)

                    Select Case dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString

                        Case "AUDIOMETRIA"
                            Dim gr As Graphics = Me.CreateGraphics
                            Dim fSize As Size = New Size(590, 545)
                            Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
                            Dim gr2 As Graphics = Graphics.FromImage(bm)
                            'gr2.CopyFromScreen(160, 180, 0, 0, fSize)
                            gr2.CopyFromScreen(160, 180, 0, 0, fSize)
                            'gr2.CopyFromScreen(CInt(txt_X1.Text), CInt(txt_Y1.Text), CInt(txt_X2.Text), CInt(txt_Y2.Text), fSize)
                            Me.PictureBox1.Image = bm

                            'GuardaCaptura(g_pathFolderOcup, Mid(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(13).ToString, 1, 8))

                            'ConvierteBase64CAPTURA(g_pathFolderOcup, Mid(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(13).ToString, 1, 8), CInt(lbl_PedidoD.Text))

                            resultado = resultado & "OTOSCOPIA: " & vbCrLf & Trim(txt_Otoscopia.Text) & vbCrLf & _
                            "DIAGNOSTICO OD: " & vbCrLf & Trim(txt_ADiagOD.Text) & vbCrLf & _
                            "DIAGNOSTICO OI: " & vbCrLf & Trim(txt_ADiagOI.Text) & vbCrLf & _
                            "RECOMENDACIONES: " & vbCrLf & Trim(txt_ARecom.Text) & vbCrLf

                            'Dim print As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                            'Dim g As Graphics = Graphics.FromImage(print)
                            'g.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))

                        Case "OPTOMETRIA"

                            'etiquetas = "APP,APF, ANT. OFTALMOLOGICOS, AVSC OD, AVSC OI, AVSCC OD, AVSCC OI, VISION COLORES OD, VISION COLORES OI, REFRACCION OD, REFRACCION OI, REFRACCION ADD, DIAGNOSTICO, PLAN"
                            resultado = resultado & "APP: " & Trim(txt_app.Text) & vbCrLf & _
                            "AFP: " & Trim(txt_apf.Text) & vbCrLf & vbCrLf & _
                            "ANTECEDENTES OFTALMOLOGICOS" & vbCrLf & Trim(txt_ant_opt.Text) & vbCrLf & _
                            "AVSC OD: " & Trim(txt_avscOD.Text) & vbCrLf & _
                            "AVSC OI: " & Trim(txt_avscOI.Text) & vbCrLf & _
                            "AVSCC OD: " & Trim(txt_avsccOD.Text) & vbCrLf & _
                            "AVSCC OI: " & Trim(txt_avsccOI.Text) & vbCrLf & vbCrLf & _
                            "VISION COLORES" & vbCrLf & _
                            "OD: " & Trim(txt_ColoresOD.Text) & vbCrLf & _
                            "OI: " & Trim(txt_ColoresOI.Text) & vbCrLf & vbCrLf & _
                            "REFRACCION: " & vbCrLf & _
                            "OD: " & Trim(txt_RefracOD.Text) & vbCrLf & _
                            "OI: " & Trim(txt_RefracOI.Text) & vbCrLf & _
                            "ADD: " & Trim(txt_RefracADD.Text) & vbCrLf & vbCrLf & _
                            "DIAGNOSTICO: " & vbCrLf & Trim(txt_OpDiag.Text) & vbCrLf & _
                            "PLAN: " & vbCrLf & Trim(txtx_OpPlan.Text) & vbCrLf

                    End Select

                Case 1 'CARGA ARCHIVO

                    'Select Case dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString

                    'Case "ELECTROCARDIOGRAMA"
                    'Case "ESPIROMETRIA"

                    'End Select

                    Pdfs = dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(13).ToString & "-" & Trim(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(2).ToString) & ".pdf"

                    If opr_res.ConsultaPdf(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString) = 0 Then
                        Call ConvierteBase64PDF(Trim(txt_ruta.Text), Pdfs, CInt(lbl_PedidoD.Text), 1, dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)

                    Else

                        Dim pdf_sec As Integer = opr_res.ConsultaPdf(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)
                        opr_trabajo.InsertPtoPdf(CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString, pdf_sec + 1)
                        Call ConvierteBase64PDF(Trim(txt_ruta.Text), Pdfs, CInt(lbl_PedidoD.Text), 1, dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(4).ToString)

                    End If
            End Select

            opr_res.ResAutoFinal(CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString), CInt(lbl_PedidoD.Text), dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString, resultado, "", dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString, 9, CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(15).ToString), CInt(dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(16).ToString))
            str_opera = lbl_PedidoD.Text & "/" & dts_listaM.Tables(0).Rows(lst_Plantillas.SelectedIndex).Item(14).ToString & "/" & resultado



            'opr_trabajo.CambioEstadoItemLista(int_codigo, 1) ' ESTADO 1 procesado
            'opr_pedido.ActualizarPdd_Estado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 1)

            opr_pedido.ActualizarLis_resEstado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 2, Format(Now, "yyyy/MM/dd"))
            opr_pedido.ActualizarPdd_Estado(CInt(lbl_PedidoD.Text), opr_trabajo.Leer_testIDTrabajo(int_codigo), 3)
            opr_pedido.ActualizarEstadoPedido(CInt(lbl_PedidoD.Text), 5)   'El pedido esta solo con algunas pruebas validadas

            '*********************************************************
            Dim dts_operacion As New DataSet()
            Dim cls_operacion As New Cls_Conexion()
            Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

            Dim opr_resul As New Cls_Resultado()
            Dim opr_user As New Cls_Usuario()
            Dim opr_invitado As New Cls_Invitado()
            Dim opr_pdf As New Cls_ToPdf()
            Dim opr_paciente As New Cls_Paciente()

            Dim g_validador, g_validadorID As String

            Dim g_validadorCargo As String = opr_invitado.ConsultaCargoInvitado(g_validadorID)
            Dim g_validadorFolio As String = opr_invitado.ConsultaFolioInvitado(g_validadorID)



            Dim numT As Integer = 0
            Dim DatosPedidos As String = Nothing
            Dim DatosPDFS As String = Nothing
            Dim OrdenFecha As String
            Dim nombrePdf As String = Nothing
            'Dim Pdfs As String = Nothing
            'Dim str_sql As String = Nothing
            Dim dts_histograma As New DataSet()
            Dim str_his As String = "NOHistograma"
            Dim str_img As String = "NOIMAGEN"
            Dim dts_imagen As New DataSet()


            Dim obj_reporte As New Object

            'Cargo grid con  valores resultadis + AB disponibles 
            Dim dts_operaAB As New DataSet()
            'Dim dtt_resAB As New DataTable("RegistrosRESAB")
            'Dim dtv_resAB As New DataView(dtt_resAB)
            Dim usu_login, usu_pass As String
            Dim pdf_examen As String = Nothing

            cls_operacion.sql_conectar()

            dts_operacion.Clear()

            OrdenFecha = lbl_orden.Text
            Pdfs = OrdenFecha & "-" & lbl_pacD.Text & ".pdf"
            If LabOcup = 0 Then
                pdf_examen = "LABORATORIO"
            Else
                pdf_examen = ""
            End If

            ConvierteBase64QR(System.Configuration.ConfigurationSettings.AppSettings("QR"), lbl_orden.Text, CInt(lbl_PedidoD.Text))
            opr_pdf.EliminaQR(CLng(lbl_PedidoD.Text), System.Configuration.ConfigurationSettings.AppSettings("QR"))


            'AQUI GENERO EL QUERY CON LOS DATOS DE CADA PEDIDO
            str_sql = opr_pedido.devuelvePedidosBloqueVF(frm_ValFinal, lbl_PedidoD.Text, CDate(dts_listaM.Tables(0).Rows(0).Item(8).ToString), aareas, dts_histograma, dts_imagen)


            If dts_histograma.Tables.Count >= 1 Then
                str_his = "HISTOGRAMA"
            Else
                str_his = "NOHISTOGRAMA"
            End If




            If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
                On Error GoTo Imagen
                If dts_imagen.Tables.Count >= 1 Then
                    str_img = "IMAGEN"
                Else
                    str_img = "NOIMAGEN"
                End If
Imagen:
                If IsDBNull(dts_imagen) = False Then
                    Select Case opr_pedido.ContarRegImagen(CLng(lbl_PedidoD.Text))
                        Case 0
                            If opr_pedido.LeeTipoImg(CLng(lbl_PedidoD.Text), "IMAGEN") = 0 Then
                                opr_pedido.InsertarRegImagen(CLng(lbl_PedidoD.Text), "IMAGEN")
                            End If
                        Case 1
                            If dts_imagen.Tables.Count >= 1 Then
                                str_img = "IMAGEN"
                            Else
                                str_img = "NOIMAGEN"
                            End If
                    End Select
                Else
                    str_img = "NOIMAGEN"
                End If

            End If

            dts_operacion.Merge(dts_operacion, False, System.Data.MissingSchemaAction.Ignore)

            oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
            oda_operacion.Fill(dts_operacion, "Registros")


            'dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(OrdenFecha(i)), tes_padre)



            obj_reporte = New rpt_entregaContinua()

            Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
            If LabOcup = 0 Then
                opr_pdf.ExportToPDF(obj_reporte, Pdfs, g_pathFolder)
                frm_ValFinal.ConvierteBase64PDF(g_pathFolder, Pdfs, CLng(lbl_PedidoD.Text), pdf_examen)
            End If
            cls_operacion.sql_desconn()

            'Limpiarcampos()








            opr_pedido.VisualizaMensaje("Resultado validado satisfactoriamente", 280)
            
            LimpiarCamposVR()
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Else

            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("No ha seleccionado ningún pedido", MsgBoxStyle.Information, "ANALISYS")
        End If

    End Sub

    
    Public Function UnicodeStringToBytes(ByVal str As String) As Byte()

        Return System.Text.Encoding.Unicode.GetBytes(Str)
    End Function

    Private Function convertbytetoimage(ByVal BA As Byte())
        Dim ms As MemoryStream = New MemoryStream(BA)
        Dim image = System.Drawing.Image.FromStream(ms)
        Return image
    End Function
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opr_resul As New Cls_Resultado()
        Dim str As String
        str = "516b31533841414141414141414459414141416f414141416f5141414148384141414142414267414141414141427a774141424d49674141537977414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414945416a4f7a3836397672323976723041434141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141704d436e57313962332b2f665732395a726257734945416a4f7a38363976723239767230414341414945416a4f7a38363976723239767230414341414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414345696f5476382b2f65333937653339356157566f4945416a4f7a38363976723239767230414341414945416a4f7a38363976723239767230414341414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141425355564c477838624779386131767255494441674945416a4f7a38363976723239767230414341414945416a4f7a38363976723239767230414341414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141416333467a6c4a7155414141416c4a71555932566a414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414133742f6549536768414141416333467a6c4a7155414141416c4a71555932566a6333467a6c4a7155414141416c4a71555932566a414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414542415176634f39516b6c4341414141414141416333467a6c4a7155414141416c4a71555932566a6333467a6c4a7155414141416c4a71555932566a41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141416741414141414141414174627131576c31616333467a6c4a7155414141416c4a71555932566a6333467a6c4a7155414141416c4a71555932566a4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414a79656e474e705977414141477470613553616c41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414e37663369456f49514141414a79656e474e705977414141477470613553616c4a79656e474e705977414141477470613553616c4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141416751434c33447655704a53674141414a79656e474e705977414141477470613553616c4a79656e474e705977414141477470613553616c4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414142676747454a4a51746262316a45774d5a79656e474e705977414141477470613553616c4a79656e474e705977414141477470613553616c41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414143636f70786a5a574d414141426a5a574f636f7077414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414465333934684b434541414143636f70786a5a574d414141426a5a574f636f7079636f70786a5a574d414141426a5a574f636f70774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414945416a5731395959484269636f70786a5a574d414141426a5a574f636f7079636f70786a5a574d414141426a5a574f636f707741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414142376658764779385a37676e7341414143636f70786a5a574d414141426a5a574f636f7079636f70786a5a574d414141426a5a574f636f70774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141416533313768497145414141416849614565344a37414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414133742f6549536768414141416533313768497145414141416849614565344a376533313768497145414141416849614565344a37414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141416c4a365559326c6a6533313768497145414141416849614565344a376533313768497145414141416849614565344a3741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414133755065474341596533313768497145414141416849614565344a376533313768497145414141416849614565344a37414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141426763474e3766336e4e316339376a33696b734b514141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141446b384f646258317666333979456f4951414141426763474e3766336e4e316339376a33696b734b526763474e3766336e4e316339376a33696b734b514141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414445344d5a79696e484e35632b6672357a6b384f526763474e3766336e4e316339376a33696b734b526763474e3766336e4e316339376a33696b734b5141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414267674749534b68487543652b2f763778415545426763474e3766336e4e316339376a33696b734b526763474e3766336e4e316339376a33696b734b5141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141594842686158566f704b436b4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414341413551546b494541674141414141414141594842686158566f704b436b4141414141414141594842686158566f704b436b414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141784e44466159566f704c436b4141414141414141594842686158566f704b436b4141414141414141594842686158566f704b436b41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141424352554a6158566f594842674141414141414141594842686158566f704b436b4141414141414141594842686158566f704b436b41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f2f774141414141414141414141414141414141414141414141502f2f2f77414141502f2f2f2f2f2f2f2f2f2f2f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141442f2f2f2f2f2f2f384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f2f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414151412f2f2f2f414141414d546778392f763333755065337550654f547735414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414541502f2f2f774141414445344d6337547a674141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414241442f2f2f3841414141784f44484f3038344141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414f5477352f2f2f2f536b6c4b4d5467787a74504f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141474e6c592f2f2f2f337439657a45344d6337547a674141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414476382b38684b4345784f44484f3038344141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141556c465374627131495441684f547735414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414150384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414150384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141503841415038414150384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414" & _
        "141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414150384141503841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414150384141503841415038414150384141503841415038414150384141502f2f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841415038414150384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141502f2f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f2f2f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f2f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141503841415038414150384141502f2f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f2f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f2f2f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414150384141502f2f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414150384141502f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f4141442f4141442f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741412f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f2f2f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f2f2f2f2f4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f7741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f2f2f2f2f77414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141502f2f2f774141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f38414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f3841414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141442f2f2f384141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141412f2f2f2f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141" & _
        "41414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414143414159494267494541674141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141392f663361326c7241414141414141415932466a392f76334d546778392f66332f2f2f2f2f2f2f2f352b666e684971454141514141414141434241496e4b4b63392f66332f2f2f2f2f2f2f2f7462713141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141506633393274706177414141416751434f6672353479536a41414141506633393374356578676347464a56557666333933743965774141414c322b76652f7637317068576867634743456b4956706457674141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414433392f647261577341414143556d705465333934494441674141414433392f6472615773414141414141414447793861747371303550446e2f2f2f39535756494141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141392f663376634f3974626131372b2f764b5441704141414141414141392f6633684971454f54773561334672392f76335932566a6333567a392f7633414167414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141506633393757367459534b684d37507a7233447651674d4341414141506633392b2f76372b6672352f663739324e705977414141484e31632f6637397741414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414433392f6472615773414141414944416a33392f64726257734141414433392f6472615773414141426a5a575076382b38514742424353554c2f2f2f383550446b4141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141392f663361326c724141414145426751392f76336533313741414141392f663361326c72414141414d5467782f2f2f2f536b314b414141417a74504f7a74504f4742675941414141414141414141674141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141506633393962583172322b76656672352b666e357867674741414141506633393837547a72573674652f763739376633676751434141414143456b49646258317666333937572b74625736746337547a67414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141426a59574e6a5a574e6a5a574e535656494944416741414141414141426a59574e6a5a574e6a5a574e4b55556f49434167414141414141414141414141414241425356564a37676e74376658744b53556f414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141414141413d3d"
        'UnicodeStringToBytes(str)

        Dim byteArrayWBC = convertbytetoimage(UnicodeStringToBytes(str))
       

        'opr_resul.GuardarImagen(CInt(lbl_PedidoD.Text), "WBCimage", NombreArchivo)
        WBCImage.Image = byteArrayWBC

        'WBCImage.Image = Image.FromFile(Environment.CurrentDirectory & "\CARGANDO_info.GIF")

        'Dim stream As MemoryStream = New MemoryStream()
        'stream.Write()

        'Dim bm As Bitmap = New Bitmap(stream)
        'bm.Save("C:example.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


        'Dim fileSize As Integer
        'Dim rawData() As Byte
        'Dim fs As FileStream

        'Dim myDAL As New ImagingDAL
        'Dim data As New ImagingData

        'data = myDAL.SelectOneImage()

        'If Not data Is Nothing Then
        '    With data
        '        fileSize = .ImageSize
        '        rawData = .ImageRawData
        '    End With
        'End If

        'rawData = New Byte(fileSize) {}
        'fs = New FileStream("c:\temp\image.jpg", FileMode.OpenOrCreate, FileAccess.Write)
        'fs.Write(rawData, 0, fileSize)
        'fs.Close()
    End Sub
End Class