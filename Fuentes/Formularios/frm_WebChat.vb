Imports System
Imports System.IO
Imports System.Drawing.Imaging
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource


Public Class frm_WebChat
    Inherits System.Windows.Forms.Form
    Public frm_refer_main_form As Frm_Main
    Dim opr_resul As New Cls_Resultado()
    Public Numorden As String
    Public NumPedido As Integer
    Public Str_sql As String = Nothing
    Public dts_Historico As DataSet
    Public int_alto, int_ancho As Integer




    Private Sub frm_WebChat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim opr_res As New Cls_Resultado()
        Try

            Dim tramaTXT As String
            Dim NombreArchivo As String

            tramaTXT = opr_resul.ConsultaHistgrama(NumPedido, "Human", "Diffimage")
            pic_diff.Image = Base64ToImage(tramaTXT, Numorden, "Diffimage", NombreArchivo)
            opr_resul.GuardarImagen(NumPedido, "Diffimage", NombreArchivo)
            tramaTXT = ""

            tramaTXT = opr_resul.ConsultaHistgrama(NumPedido, "Human", "Basoimage")
            Pic_Baso.Image = Base64ToImage(tramaTXT, Numorden, "Basoimage", NombreArchivo)
            opr_resul.GuardarImagen(NumPedido, "Basoimage", NombreArchivo)
            tramaTXT = ""

            tramaTXT = opr_resul.ConsultaHistgrama(NumPedido, "Human", "RBCimage")
            pic_rbc.Image = Base64ToImage(tramaTXT, Numorden, "RBCimage", NombreArchivo)
            opr_resul.GuardarImagen(NumPedido, "RBCimage", NombreArchivo)
            tramaTXT = ""

            tramaTXT = opr_resul.ConsultaHistgrama(NumPedido, "Human", "PLTimage")
            pic_plt.Image = Base64ToImage(tramaTXT, Numorden, "PLTimage", NombreArchivo)
            opr_resul.GuardarImagen(NumPedido, "PLTimage", NombreArchivo)
            tramaTXT = ""

            'Dim rpt As New crImagenes
            Dim rpt As New rpt_HistogramaInterfaz
            rpt.Load()
            rpt.SetDataSource(ReturnDataSet(opr_res.ConsultaPathFiles(Str_sql)))
            rpt.Refresh()

            Me.int_alto = frm_refer_main_form.mdiClient1.Height
            Me.int_ancho = frm_refer_main_form.mdiClient1.Width

            Me.Height = int_alto - 15
            Me.Width = int_ancho - 15
            Me.Top = (int_alto - Me.Height) / 2
            Me.Left = (int_ancho - Me.Width) / 2
            Me.TopMost = True
            CrystalReportViewer1.Zoom(70)

            Me.Reporte = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
    End Sub


    Public Function Base64ToImage(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(Base64Code)
        'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
        Dim vFileName As String = Nothing

        'Dim diskOpts As New DiskFileDestinationOptions()

        If numorden <> "" Then

            NombreArchivo = nombre_tipo & numorden & ".gif"

            If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
            vFileName = Environment.CurrentDirectory & "\" & g_pathFolderImg & "\" & NombreArchivo

            'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo

            If File.Exists(vFileName) Then
                File.Delete(vFileName)
            End If
            'diskOpts.DiskFileName = vFileName

            File.WriteAllBytes(vFileName, imageBytes)


            Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
            Dim tmpImage As Image = Image.FromStream(ms, True)
            'NombreArchivo = vFileName

            Return tmpImage
        End If
    End Function


    'Public Function ByteToImage(ByVal data As Byte) As Image
    '    Dim imageBytes As Byte() = Convert.ToByte(data)
    '    Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
    '    Dim tmpImage As Image = Image.FromStream(ms, True)
    '    Return tmpImage
    'End Function


    Public Sub ESPERA(ByVal INTERVALO As Integer)
        Dim PARADA As New Stopwatch
        PARADA.Start()
        Do While PARADA.ElapsedMilliseconds < INTERVALO
            Application.DoEvents()
        Loop
        PARADA.Stop()
    End Sub


    Sub LlenarArchivos()
        Dim Archivos(), NombreArchivo As String : Dim InfoArchivo As FileInfo
        Dim oListViewItem As ListViewItem
        Archivos = Directory.GetFiles(Directory.GetCurrentDirectory & "\pdf")
        'Limpiamos el ListView1, de esta manera nos aseguramos de actualizarlo.
        'ListView1.Items.Clear()
        'Me.LstArchivos.Items.Clear()
        'For Each NombreArchivo In Archivos
        '    InfoArchivo = New FileInfo(NombreArchivo)
        '    Me.LstArchivos.Items.Add(InfoArchivo.Name)
        '    'Recuperamos y mostramos tan solo el nombre del archivo, de no ser
        '    'así no tiene sentido mostrar la extensión por separado.
        '    oListViewItem = ListView1.Items.Add(Microsoft.VisualBasic.Left _
        '    (InfoArchivo.Name.ToString, Len(InfoArchivo.Name.ToString) - 4))
        '    'Mostramos la longitud del archivo en Bytes.
        '    oListViewItem.SubItems.Add(InfoArchivo.Length.ToString & " Bytes")
        '    'Mostramos la fecha en la que fue creado el archivo.
        '    oListViewItem.SubItems.Add(InfoArchivo.CreationTime)
        '    'Mostramos la extensión del archivo.
        '    oListViewItem.SubItems.Add(InfoArchivo.Extension)
        '    'Mostramos cantidad de atributos del archivo.
        '    oListViewItem.SubItems.Add(InfoArchivo.Attributes)
        '    'Mostramos la hora en la que se utilizó por última vez el archivo.
        '    oListViewItem.SubItems.Add(InfoArchivo.LastAccessTime)
        '    'Mostramos  la hora en la que se escribió por última vez en el archivo.
        '    oListViewItem.SubItems.Add(InfoArchivo.LastWriteTime)
        'Next
    End Sub


    Dim mReporte As Object

    Public Property Reporte() As Object
        Get
            Return mReporte
        End Get
        Set(ByVal Value As Object)
            mReporte = Value

            Me.CrystalReportViewer1.ReportSource = Nothing
            Me.CrystalReportViewer1.ReportSource = mReporte
        End Set
    End Property

    
    

    Function ImprimeHistorico(ByVal ds As DataSet)
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE PROFORMA
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'Dim obj_reporte As New rpt_proHistorico()

        'dgrd_proforma.DataSource = ds
        'dgrd_proforma.DataMember = ("Registros")


        Dim cr As New ReportDocument
        Dim strReportName As String
        strReportName = "rpt_HistogramaInterfaz"
        Dim strReportPath As String = Application.StartupPath & _
           "\Fuentes\Reportes\" & strReportName & ".rpt"

        cr.Load(strReportPath)
        cr.SetDataSource(dts_Historico.Tables("Registros"))
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowCloseButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.Zoom(20)

        CrystalReportViewer1.ReportSource = cr
        'CrystalReportViewer1.PrintReport()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Function


    Private Function ReturnDataSet(ByVal files As String) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "º")

        pathImg = Environment.CurrentDirectory & "\" & g_pathFolderImg

        'dt.Columns.Add(New DataColumn("Codigo", GetType(Short)))
        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt.Columns.Add(New DataColumn("Descripcion2", GetType(String)))
        dt.Columns.Add(New DataColumn("Descripcion3", GetType(String)))
        dt.Columns.Add(New DataColumn("Descripcion4", GetType(String)))
        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen2", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen3", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen4", GetType(Byte())))
        'dt.Columns.Add(New DataColumn("paciente", GetType(String)))
        'dt.Columns.Add(New DataColumn("ped_fecing", GetType(Date)))
        'dt.Columns.Add(New DataColumn("med_nombre", GetType(String)))
        'dt.Columns.Add(New DataColumn("edad", GetType(String)))
        'dt.Columns.Add(New DataColumn("pac_hist_clinica", GetType(String)))
        'dt.Columns.Add(New DataColumn("sexo", GetType(String)))
        'dt.Columns.Add(New DataColumn("lis_user", GetType(String)))
        'dt.Columns.Add(New DataColumn("lis_fecvalidado", GetType(Date)))
        'dt.Columns.Add(New DataColumn("CB", GetType(String)))
        'dt.Columns.Add(New DataColumn("ped_numaux", GetType(Integer)))


        dr = dt.NewRow()
        'dr("Codigo") = 1
        dr("Descripcion") = "DIFF"
        dr("Descripcion2") = "BAS"
        dr("Descripcion3") = "RBC"
        dr("Descripcion4") = "PLT"
        dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(0)))
        dr("Imagen2") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(1)))
        dr("Imagen3") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(2)))
        dr("Imagen4") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(3)))
        'dr("paciente") = files_arreglo(0).ToString
        'dr("ped_fecing") = files_arreglo(1).ToString
        'dr("med_nombre") = files_arreglo(2).ToString
        'dr("edad") = files_arreglo(3).ToString
        'dr("pac_hist_clinica") = files_arreglo(4).ToString
        'dr("sexo") = files_arreglo(5).ToString
        'dr("lis_user") = files_arreglo(6).ToString
        'dr("lis_fecvalidado") = files_arreglo(7).ToString
        'dr("CB") = files_arreglo(8).ToString
        'dr("ped_numaux") = files_arreglo(9).ToString
        dt.Rows.Add(dr)

        ''dr = dt.NewRow()
        ''dr("Codigo") = 2
        ''dr("Descripcion") = "BAS"
        ''dr("Imagen2") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(11)))
        ''dr("paciente") = files_arreglo(0).ToString
        ''dr("ped_fecing") = files_arreglo(1).ToString
        ''dr("med_nombre") = files_arreglo(2).ToString
        ''dr("edad") = files_arreglo(3).ToString
        ''dr("pac_hist_clinica") = files_arreglo(4).ToString
        ''dr("sexo") = files_arreglo(5).ToString
        ''dr("lis_user") = files_arreglo(6).ToString
        ''dr("lis_fecvalidado") = files_arreglo(7).ToString
        ''dr("CB") = files_arreglo(8).ToString
        ''dr("ped_numaux") = files_arreglo(9).ToString
        ''dt.Rows.Add(dr)

        ''dr = dt.NewRow()
        ''dr("Codigo") = 3
        ''dr("Descripcion") = "RBC"
        ''dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(12)))
        ''dr("paciente") = files_arreglo(0).ToString
        ''dr("ped_fecing") = files_arreglo(1).ToString
        ''dr("med_nombre") = files_arreglo(2).ToString
        ''dr("edad") = files_arreglo(3).ToString
        ''dr("pac_hist_clinica") = files_arreglo(4).ToString
        ''dr("sexo") = files_arreglo(5).ToString
        ''dr("lis_user") = files_arreglo(6).ToString
        ''dr("lis_fecvalidado") = files_arreglo(7).ToString
        ''dr("CB") = files_arreglo(8).ToString
        ''dr("ped_numaux") = files_arreglo(9).ToString
        ''dt.Rows.Add(dr)

        ''dr = dt.NewRow()
        ''dr("Codigo") = 4
        ''dr("Descripcion") = "PLT"
        ''dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(13)))
        ''dr("paciente") = files_arreglo(0).ToString
        ''dr("ped_fecing") = files_arreglo(1).ToString
        ''dr("med_nombre") = files_arreglo(2).ToString
        ''dr("edad") = files_arreglo(3).ToString
        ''dr("pac_hist_clinica") = files_arreglo(4).ToString
        ''dr("sexo") = files_arreglo(5).ToString
        ''dr("lis_user") = files_arreglo(6).ToString
        ''dr("lis_fecvalidado") = files_arreglo(7).ToString
        ''dr("CB") = files_arreglo(8).ToString
        ''dr("ped_numaux") = files_arreglo(9).ToString
        ''dt.Rows.Add(dr)


        ds.Tables.Add(dt)
        ds.Tables(0).TableName = "Imagenes"

        Dim iDS As New dsImagenes
        iDS.Merge(ds, False, System.Data.MissingSchemaAction.Ignore)
        Return iDS
    End Function

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

End Class