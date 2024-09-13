Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports MessagingToolkit.QRCode.Codec

Public Class frm_Receta
    Public frm_refer_main As Frm_Main
    Public Age_id As Integer
    Public Ped_id As Integer
    Public Ped_turno As String
    Public pac_id As Integer
    Public Med_nombre As String
    Public Med_id As Integer
    Dim swExisteReceta As Boolean
    Dim opr_pedido As New Cls_Pedido()
    Dim opr_res As New Cls_Resultado()
    Dim opr_pdf As New Cls_ToPdf()
    Dim var_vadem As String
    Dim txt_URL As String = Nothing
    Dim archivoQR As String = Nothing
    Dim archivos As String = Nothing
    Dim opr_resul As New Cls_Resultado()


    


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Function obtieneCie10(ByVal Age_id As Integer) As String
        Return opr_res.ConsultaCie10(Age_id)
    End Function


    Private Sub frm_Receta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_Cie10.Text = obtieneCie10(Age_id)
        

        If opr_pedido.ExisteReceta(Age_id, pac_id) > 0 Then
            btn_ImprimirReceta.Enabled = True
            Dim arr_datosRECETA As String()

            txt_URL = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR_RECETA") & Ped_id)

            arr_datosRECETA = Split(opr_pedido.LeerReceta(Age_id, pac_id), "º")

            If UBound(arr_datosRECETA) > 1 Then
                lbl_FechaReceta.Text = Format(CDate(arr_datosRECETA(1)), "dd/MMM/yyyy")
                lbl_FecValidez.Text = DateAdd(DateInterval.Day, CInt(System.Configuration.ConfigurationSettings.AppSettings("DIAS_RECETA")), CDate(lbl_FechaReceta.Text))

                txt_Medicacion.Text = arr_datosRECETA(3)
                txt_Indicaciones.Text = arr_datosRECETA(4)
                txt_RecDieta.Text = arr_datosRECETA(5)

                'lbl_MD_REPORTA.Text = arr_datosRECETA(2)
                'lbl_MD_REPORTA2.Text = arr_datosRECETA(2)
                'lbl_Cie10.Text = arr_datosRECETA(5) & " " & arr_datosRECETA(5)
            End If
            swExisteReceta = True
        Else
            lbl_FechaReceta.Text = Format(Now(), "dd/MMM/yyyy")
            txt_URL = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR_RECETA") & Ped_id)
            lbl_FecValidez.Text = DateAdd(DateInterval.Day, CInt(System.Configuration.ConfigurationSettings.AppSettings("DIAS_RECETA")), CDate(lbl_FechaReceta.Text))
            'lbl_MD_REPORTA.Text = Med_nombre
            'lbl_MD_REPORTA2.Text = Med_nombre
            swExisteReceta = False
            btn_ImprimirReceta.Enabled = False
        End If
        qrcodeGen()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim cie_cod4 As String = ""

        If opr_pedido.ExisteReceta(Age_id, pac_id) > 0 Then
            swExisteReceta = True
        Else
            swExisteReceta = False
        End If
        opr_pedido.GestionaReceta(opr_pedido.LeerMaxReceta(), Age_id, Med_id, pac_id, Trim(txt_Medicacion.Text), Trim(txt_Indicaciones.Text), Trim(txt_RecDieta.Text), "INGRESADA", cie_cod4, swExisteReceta)

        ConvierteBase64QR(System.Configuration.ConfigurationSettings.AppSettings("QRRECETA"), Format(CDate(lbl_FechaReceta.Text), "MMdd") & Format(CInt(Ped_turno), "00000"), Ped_id, "RECETA")
        opr_pdf.EliminaQR(Ped_id, System.Configuration.ConfigurationSettings.AppSettings("QRRECETA"))

        opr_pedido.VisualizaMensaje("Receta guardada satisfactoriamente", 300)
        btn_ImprimirReceta.Enabled = True
        'actualizaDtsMedicoTratante(Age_Id)
    End Sub

    Private Sub ConvierteBase64QR(ByVal path As String, ByVal nombreFILE As String, ByVal ped_id As Long, ByVal img_nombre As String)

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
        STR_SQL = "update ptoimagen set img_base64 = '" & base64String & "', img_orden = '" & img_orden & "' where ped_id = " & ped_id & " and img_nombre = '" & img_nombre & "' "

        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar QR", Err)
        Err.Clear()

    End Sub

    
    Private Sub qrcodeGen()
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            'System.Configuration.ConfigurationSettings.AppSettings("PATHQR") 
            'Me.txt_URL.Text = Trim(System.Configuration.ConfigurationSettings.AppSettings("PATHQR"))
            Me.Pic_QR.Image = qrCode.Encode(txt_URL, System.Text.Encoding.UTF8)
            Me.Pic_QR.Image.Save(IO.Path.Combine(Environment.CurrentDirectory & "\" & (System.Configuration.ConfigurationSettings.AppSettings("QRRECETA")), Ped_id & ".jpg"))

            'Call ConvierteBase64QR(System.Configuration.ConfigurationSettings.AppSettings("QR"), lbl_ordenMIS.Text, CLng(lbl_pedidoD.Text))
        Catch ex As Exception
            opr_pedido.VisualizaMensaje(ex.Message, 250)
            'MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Function ImageToByte(ByVal pImagen As Image) As Byte()
        Dim mImage() As Byte
        Try
            If Not IsNothing(pImagen) Then
                Dim ms As New System.IO.MemoryStream
                pImagen.Save(ms, pImagen.RawFormat)
                mImage = ms.GetBuffer
                ms.Close()
                Return mImage
            End If
        Catch
        End Try
    End Function


    Public Function ReturnDataSetOcup(ByVal files As String) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "\")

        pathImg = Environment.CurrentDirectory & "\" & "QRRECETA"

        dt.Columns.Add(New DataColumn("Codigo", GetType(Short)))
        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))


        dr = dt.NewRow()
        dr("Codigo") = 1
        dr("Descripcion") = "QR"
        dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(0)))
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)
        ds.Tables(0).TableName = "ImagenesQR"

        Dim iDS As New dsImgOcup
        iDS.Merge(ds, False, System.Data.MissingSchemaAction.Ignore)
        Return iDS
    End Function



    Public Function Base64ToImageOcupacional(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte()
        Try
            imageBytes = Convert.FromBase64String(Base64Code)

            'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            If numorden <> "" Then

                NombreArchivo = nombre_tipo & numorden & ".jpg"

                If Dir(Environment.CurrentDirectory & "\QRRECETA", FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\QRRECETA\" & NombreArchivo

                'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

                If File.Exists(vFileName) Then
                    File.Delete(vFileName)
                    'EliminaArchivoTxt(vFileName)
                End If
                'diskOpts.DiskFileName = vFileName

                File.WriteAllBytes(vFileName, imageBytes)


                Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
                Dim tmpImage As Image = Image.FromStream(ms, True)
                'NombreArchivo = vFileName

                Return tmpImage
            End If
        Catch

        End Try

    End Function


    Private Sub btn_ImprimirReceta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImprimirReceta.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_RecetaMedica()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        Dim dts_operacion As New DataSet()
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()




        Dim dts_operaAB As New DataSet()
        
        Dim dts_histograma As New DataSet()
        Dim str_his As String = "NOHISTOGRAMA"
        Dim str_img As String = "NOIMAGEN"

        '' '' '' ''******** CONSULTO SI TIENE QR ******
        Dim dts_imagen As New DataSet()

        str_sql = "SELECT  pedido.PED_ID, img_base64 " & _
           "FROM pedido, ptoImagen " & _
           "where pedido.ped_id = ptoImagen.ped_id  " & _
           "and pedido.PED_ID = " & Ped_id & " and ptoImagen.img_nombre  = 'RECETA'"

        archivoQR = opr_res.ConsultaPathFilesImagenQR(str_sql)

        If archivoQR <> "" Then
            archivos = Nothing
            Dim tramaTXT As String
            Dim NombreArchivo As String

            tramaTXT = opr_resul.ConsultaImagen(Ped_id, "RECETA")
            Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(CDate(lbl_FechaReceta.Text), "MMdd") & Format(CInt(Ped_turno), "00000"), "", NombreArchivo)
            opr_resul.GuardarImagenOcupacional(Ped_id, "RECETA", NombreArchivo)
            tramaTXT = ""

            'str_sql = "SELECT  pedido.PED_ID,  img_file " & _
            '     "FROM pedido, ptoImagen " & _
            '     "where pedido.ped_id = ptoImagen.ped_id  " & _
            '     "and pedido.PED_ID = " & Ped_id & " and ptoImagen.Img_NOMBRE = 'RECETA'"

            'archivos = opr_res.ConsultaPathFilesImgOcupacional(str_sql)
            dts_imagen = ReturnDataSetOcup(NombreArchivo)
        End If

        If System.Configuration.ConfigurationSettings.AppSettings("ControlQR") = True Then
            Try
                If dts_imagen.Tables.Count >= 1 Then
                    str_img = "IMAGEN"
                    ' opr_pdf.EliminaQR(Format(Now, "yy") & Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), System.Configuration.ConfigurationSettings.AppSettings("QR"))
                Else
                    str_img = "NOIMAGEN"
                End If
            Catch
                If IsDBNull(dts_imagen) = False Then
                    Select Case opr_pedido.ContarRegImagen(Ped_id)
                        Case 0
                            If opr_pedido.LeeTipoImg(Ped_id, "IMAGEN") = 0 Then
                                opr_pedido.InsertarRegImagen(Ped_id, "IMAGEN")
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
            End Try
        End If

        str_sql = "select distinct(receta.rec_id), receta.rec_fecha, medico.MED_NOMBRE, receta.REC_MEDICACION, receta.REC_INDICACIONES, REC_DIETA, cm.cie_cod4, '" & lbl_Cie10.Text & "' as cie_desc4, (paciente.PAC_APELLIDO + ' ' + paciente .PAC_NOMBRE) as pac_nombre, paciente.pac_doc, receta.rec_fecvenc " & _
                "from receta, medico, paciente, consultaMedico as cm " & _
                "where receta.age_id = " & Age_id & " and  receta.med_id = medico.med_id and paciente.pac_id = receta.pac_id and cm.PAC_ID = paciente.PAC_ID and cm.AGE_ID = receta.AGE_ID  "

        cls_operacion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dts_operacion.Merge(dts_operacion, False, System.Data.MissingSchemaAction.Ignore)
        oda_operacion.Fill(dts_operacion, "Registros")
        cls_operacion.sql_desconn()

        str_img = "NOIMAGEN"


        Dim frm_MDIChild As New Frm_reportes(str_his, str_img, obj_reporte, dts_operacion, dts_histograma, dts_imagen, dts_operaAB, True, 1)
        'Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , True, 0)
        'Dim frm_MDIChild As New Frm_reportes(str_sql, str_img, obj_reporte, , , dts_imagen, , True, 0)
        
        frm_MDIChild.Text = "RECETA MEDICA"
        frm_MDIChild.ShowDialog(Me.ParentForm)


        'opr_pdf.ExportToPDF(obj_reporte, "RECETA-" & Age_id & " " & lbl_paciente.Text, g_pathFolderReceta)


        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub



    Private Sub btn_enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim msg As String = Nothing
        Dim telefono As String = Nothing
        Dim vFileName As String = Nothing
        vFileName = Environment.CurrentDirectory & "\" & g_pathFolderReceta


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_RecetaMedica()
        Dim frm_ref_main As Frm_Main = Me.ParentForm

        str_sql = "select receta.rec_id, receta.rec_fecha, medico.MED_NOMBRE, receta.REC_MEDICACION, receta.REC_INDICACIONES, (paciente.PAC_APELLIDO + ' ' + paciente .PAC_NOMBRE) as pac_nombre " & _
                "from receta, cie10, medico, paciente, consultaMedico as cm " & _
                "where receta.age_id = " & Age_id & " and  receta.med_id = medico.med_id and paciente.pac_id = receta.pac_id and cie10.cie_cod4 = cm.cie_cod4 and cm.PAC_ID = paciente .PAC_ID and cm.AGE_ID = receta .AGE_ID "

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        '''frm_MDIChild.int_alto = frm_ref_main.mdiClient1.Height
        '''frm_MDIChild.int_ancho = frm_ref_main.mdiClient1.Width
        frm_MDIChild.Text = "RECETA MEDICA"
        frm_MDIChild.ShowDialog(Me.ParentForm)


        opr_pdf.ExportToPDF(obj_reporte, "RECETA-" & Age_id & " " & lbl_paciente.Text, g_pathFolderReceta)

        Me.Cursor = System.Windows.Forms.Cursors.Default

        msg = "Ingrese el numero telefonico del destinatario"
        Dim myValue As String = InputBox(msg, "ANALISYS", "")

        If String.IsNullOrEmpty(myValue) Then
            'MessageBox.Show("Se cancelo el Inputbox")
            Return
        Else
            Dim Wmsg As String = g_Titulo & Chr(10) & "Agradece la confianza"
            '&text=''
            'System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(myValue, 2, 9) & "text=" & Wmsg)
            System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=593" & Mid(myValue, 2, 9))
            System.Diagnostics.Process.Start("explorer.exe", vFileName)
        End If

    End Sub


    Private Sub btn_Vademecum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Vademecum.Click
        Dim i As Integer
        Dim str_medica As String
        Dim str_indica As String

        Dim arreglo As String()
        Dim param As String()
        Dim frm_MDIChild As New frm_Vademecum()
        frm_MDIChild.frm_refer_main = Me.ParentForm
        frm_MDIChild.ShowDialog(Me.ParentForm)
        'txt_Cie10.Text = frm_MDIChild.consulta
        var_Vadem = frm_MDIChild.var_vadem

        arreglo = Split(var_vadem, "|")
        For i = 0 To UBound(arreglo)
            param = Split(arreglo(i), "º")
            If param(0) <> "" Then
                str_medica = str_medica & param(0) & ",  " & param(1) & ", " & param(2) & ",  # " & param(3) & vbCrLf & vbCrLf
                str_indica = str_indica & param(4) & vbCrLf & vbCrLf
            End If
        Next

        txt_Medicacion.Text = txt_Medicacion.Text & str_medica
        txt_Indicaciones.Text = txt_Indicaciones.Text & str_indica
        
        'If opr_pedido.GestionaConsultaCie10(Age_id, dgv_MedicosTratantes.CurrentRow.Cells("med_id").Value, var_Cie4, "Insertar") = True Then
        '    actualizaDtsCieConsulta(Age_id)
        '    'opr_pedido.VisualizaMensaje("Datos almacenados satisfactoriamente", 200)
        'Else
        '    'opr_pedido.VisualizaMensaje("No se pudo almacenar la informacion", 200)
        'End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_Medicacion.Text = ""
        txt_Indicaciones.Text = ""
    End Sub

    Private Sub btn_RecMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RecMenu.Click

        'Dim arr_datosInterpret As String()
        'arr_datosInterpret = 

        'If UBound(arr_datosInterpret) > 1 Then
        '    txt_RecMenu.Text = arr_datosInterpret(3)
        'End If
        If opr_pedido.LeerMenu(Age_id) <> "" Then
            txt_RecDieta.Text = opr_pedido.LeerMenu(Age_id)
        Else
            opr_pedido.VisualizaMensaje("El paciente no tiene reportado la interpretacion de ALIMENTOS", 300)
        End If
    End Sub

    
    
    
    
End Class