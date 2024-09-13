'*************************************************************************
' Nombre:   Cls_Pedido
' Tipo de Archivo: clase
' Descripcin:  Clase para la manipulacion de los pedidos
' Autores:  rfn, Carlos Bola�os
' Fecha de Creaci�n: 
' Autores Modificaciones: Carlos Bola�os
' Ultima Modificaci�n: 
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.IO
Imports System.Data.SqlClient



Public Class Cls_Pedido
    'Public med_id As Integer
    Dim secuencia As String()
    Dim opr_agenda As New Cls_Agenda()
    Dim opr_res As New Cls_Resultado()
    Dim opr_resul As New Cls_Resultado()
    Dim j As Integer


    Sub LlenarComboSeries(ByRef cmb_Serie As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select SER_DES , SER_ID from vacunaSerie order by ser_id asc "
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_Serie.Items.Clear()
        While odr_operacion.Read
            cmb_Serie.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(50) & odr_operacion.GetValue(1).ToString().PadRight(10))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_Serie.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar Especialidad", Err)
        Err.Clear()
    End Sub


    Sub LlenarComboBodegasCliente(ByRef cmb_bodegas As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select I_BOD_ID, I_BOD_DESCRIPCION from i_bodega where I_BOD_ID in('B01', 'B08')"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_bodegas.Items.Clear()
        While odr_operacion.Read
            cmb_bodegas.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(10) & odr_operacion.GetValue(1).ToString().PadRight(50))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_bodegas.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar BODEGA", Err)
        Err.Clear()
    End Sub

    Sub LlenarComboBodegasPreparacion(ByRef cmb_bodegas As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select I_BOD_ID, I_BOD_DESCRIPCION from i_bodega where I_BOD_ID in('B09')"
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_bodegas.Items.Clear()
        While odr_operacion.Read
            cmb_bodegas.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(10) & odr_operacion.GetValue(1).ToString().PadRight(50))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_bodegas.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar BODEGA", Err)
        Err.Clear()
    End Sub


    Sub LlenarComboBodegas(ByRef cmb_bodegas As ComboBox)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico        
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select I_BOD_ID, I_BOD_DESCRIPCION from i_bodega "
        cls_operacion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_bodegas.Items.Clear()
        While odr_operacion.Read
            cmb_bodegas.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(10) & odr_operacion.GetValue(1).ToString().PadRight(50))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_bodegas.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar BODEGA", Err)
        Err.Clear()
    End Sub


    Public Sub VisualizaMensaje(ByVal mensaje As String, ByVal tiempo As Integer)
        Dim frm_MDIChild As New frm_mensaje()
        frm_MDIChild.tiempo = tiempo
        frm_MDIChild.msg = mensaje
        'frm_MDIChild.frm_refer_main = Form.ParentForm
        frm_MDIChild.ShowDialog() 'Me.ParentForm)
    End Sub


    Public Function Base64ToImageOcupacional(ByVal Base64Code As String, ByVal numorden As String, ByVal nombre_tipo As String, ByRef NombreArchivo As String, ByVal tipoQR As String) As Image
        Dim imageBytes As Byte()
        Try
            imageBytes = Convert.FromBase64String(Base64Code)

            'opr_resul.GuardarImagen(ped_id, nombre_tipo, imageBytes)
            Dim vFileName As String = Nothing

            'Dim diskOpts As New DiskFileDestinationOptions()

            If numorden <> "" Then

                Select Case tipoQR
                    Case "FIRMA"
                        NombreArchivo = nombre_tipo & numorden & ".jpg"
                    Case "ACCESO"
                        NombreArchivo = nombre_tipo & numorden & "W.jpg"
                End Select


                If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\" & g_pathFolderQR & "\" & NombreArchivo

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
        Catch

        End Try

    End Function

    Public Function DevuelveDataSetQr1(ByVal tipoQR As String, ByVal orden As Long, ByVal pic_control As Windows.Forms.PictureBox) As DataSet
        'QR FIRMA ELECTRONICA
        Dim archivoQR As String = Nothing
        Dim str_sql As String = Nothing
        Dim archivos As String = Nothing
        archivoQR = Nothing

        '' '' '' ''******** CONSULTO SI TIENE QR ******
        str_sql = "SELECT  pedido.PED_ID, img_base64 " & _
           "FROM pedido, ptoImagen " & _
           "where pedido.ped_id = ptoImagen.ped_id  " & _
           "and pedido.PED_ID = " & orden & " and ptoImagen.img_nombre  = '" & tipoQR & "'"

        archivoQR = opr_resul.ConsultaPathFilesImagenQR(str_sql)

        If archivoQR <> "" Then
            archivos = Nothing
            Dim tramaTXT As String
            Dim NombreArchivo As String


            tramaTXT = opr_resul.ConsultaImagen(CInt(orden), tipoQR)
            pic_control.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & orden, "", NombreArchivo, tipoQR)
            opr_resul.GuardarImagenOcupacional(CInt(orden), tipoQR, NombreArchivo)
            tramaTXT = ""
            pic_control.Image = Nothing
            'Pic_QR.Refresh()
            'Pic_QR.Dispose()

            str_sql = "SELECT  pedido.PED_ID,  img_file " & _
                 "FROM pedido, ptoImagen " & _
                 "where pedido.ped_id = ptoImagen.ped_id  " & _
                 "and pedido.PED_ID = " & CInt(orden) & " and ptoImagen.Img_NOMBRE = '" & tipoQR & "'"

            archivos = opr_resul.ConsultaPathFilesImgOcupacional(str_sql)
            DevuelveDataSetQr1 = ReturnDataSetOcup(archivos, tipoQR)

        End If
    End Function

    Public Function ReturnDataSetOcup(ByVal files As String, ByVal tipoQR As String) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "\")

        pathImg = Environment.CurrentDirectory & "\" & g_pathFolderQR

        dt.Columns.Add(New DataColumn("Codigo", GetType(Short)))
        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))


        dr = dt.NewRow()
        dr("Codigo") = 1
        dr("Descripcion") = tipoQR
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

                If Dir(Environment.CurrentDirectory & "\" & g_pathFolderImg, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & g_pathFolderImg)
                vFileName = Environment.CurrentDirectory & "\" & g_pathFolderQR & "\" & NombreArchivo

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
        Catch

        End Try

    End Function

   



    Public Function ContarRegImagen(ByVal ped_id As Long) As Integer
        'Funcion para la consultar los datos de la tabla PEDIDO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim int_lic, int_disponible As Integer
        ContarRegImagen = 0
        opr_Conexion.sql_conectar()
        str_sql = "SELECT COUNT(*) FROM ptoimagen WHERE ped_id = " & ped_id & ""
        ContarRegImagen = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Contar registros imagenes", Err)
        Err.Clear()
    End Function

    Public Function LeeTipoImg(ByVal ped_id As Long, ByVal tipoQR As String) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeeTipoImg = CInt(New SqlCommand("Select count (*) from ptoimagen WHERE ped_ID = " & ped_id & " and img_nombre = '" & tipoQR & "'", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer tipo de imagen ", Err)
        Err.Clear()
    End Function


    Public Sub InsertarRegImagen(ByVal ped_id As Integer, ByVal tipoQR As String)
        'PROCEDIMIENTO para insertar una nota al examen( )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "insert into ptoimagen values(" & ped_id & ",'" & tipoQR & "','','','');"
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar reg imagen", Err)
        Err.Clear()
    End Sub


    Public Function DevuelveDataSetQr(ByVal tipoQR As String, ByVal orden As Long, ByVal pic_control As Windows.Forms.PictureBox) As DataSet
        'QR FIRMA ELECTRONICA
        Dim archivoQR As String = Nothing
        Dim str_sql As String = Nothing
        Dim archivos As String = Nothing
        archivoQR = Nothing

        '' '' '' ''******** CONSULTO SI TIENE QR ******
        str_sql = "SELECT  pedido.PED_ID, img_base64 " & _
           "FROM pedido, ptoImagen " & _
           "where pedido.ped_id = ptoImagen.ped_id  " & _
           "and pedido.PED_ID = " & orden & " and ptoImagen.img_nombre  = '" & tipoQR & "'"

        archivoQR = opr_resul.ConsultaPathFilesImagenQR(str_sql)

        If archivoQR <> "" Then
            archivos = Nothing
            Dim tramaTXT As String
            Dim NombreArchivo As String


            tramaTXT = opr_resul.ConsultaImagen(CInt(orden), tipoQR)
            pic_control.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & orden, "", NombreArchivo, tipoQR)
            opr_resul.GuardarImagenOcupacional(CInt(orden), tipoQR, NombreArchivo)
            tramaTXT = ""
            pic_control.Image = Nothing
            'Pic_QR.Refresh()
            'Pic_QR.Dispose()

            str_sql = "SELECT  pedido.PED_ID,  img_file " & _
                 "FROM pedido, ptoImagen " & _
                 "where pedido.ped_id = ptoImagen.ped_id  " & _
                 "and pedido.PED_ID = " & CInt(orden) & " and ptoImagen.Img_NOMBRE = '" & tipoQR & "'"

            archivos = opr_resul.ConsultaPathFilesImgOcupacional(str_sql)
            DevuelveDataSetQr = ReturnDataSetOcup(archivos, tipoQR)

        End If
    End Function


    Public Function EliminaArchivoTxt(ByVal ruta_archivo As String) As Boolean
        Try
            If File.Exists(ruta_archivo) Then
                ':::Eliminamos el archivo TXT
                File.Delete(ruta_archivo)
                'MsgBox("Archivo eliminado correctamente", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")

            Else
                'MsgBox("No se encuentra el archivo especificado", MsgBoxStyle.Information, ":::Aprendamos de Programación:::")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al eliminar el archivo: " & ex.Message, MsgBoxStyle.Critical, "AnalisysLAb")
        End Try
    End Function

    Public Function ReturnDataSetOcup(ByVal files As String) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "\")

        pathImg = Environment.CurrentDirectory & "\" & g_pathFolderQR

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




    'Public Function ConvertImageToBase64String(ByVal PictureBox1 As ) As String
    '    Using ms As New MemoryStream()
    '        PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png) 'We load the image from first PictureBox in the MemoryStream
    '        Dim obyte = ms.ToArray() 'We tranform it to byte array..

    '        Return Convert.ToBase64String(obyte) 'We then convert the byte array to base 64 string.
    '    End Using
    'End Function

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

    'Here's the part of your code (which works)
    Private Function convertbytetoimage(ByVal BA As Byte())
        Dim ms As MemoryStream = New MemoryStream(BA)
        Dim image = System.Drawing.Image.FromStream(ms)
        Return image
    End Function

    Public Function devuelvePedidosBloque(ByVal frm_formulario As frm_VisResul, ByVal orden As String, ByVal ped_id As Long, ByVal fecha_nac As Date, ByRef dts_histograma As DataSet, ByRef dts_imagen As DataSet) As String
        Dim str_sql As String = Nothing
        Dim archivos As String = Nothing
        Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")
        Dim unidad As String = Nothing
        Dim archivoQR As String = Nothing

        '************* calcula edad
        Dim str_edad As String = Nothing

        str_edad = CalculaEdad(fecha_nac, unidad)
        str_edad = str_edad & " " & unidad


        str_sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
            "FROM pedido, ptohistograma " & _
            "where pedido.ped_id = ptohistograma.ped_id  " & _
            "and pedido.PED_ID = " & CInt(ped_id) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

        'Dim dts_histograma As New DataSet()
        Dim str_his As String = "NOHISTOGRAMA"


        ''archivos = opr_res.ConsultaPathFiles(str_sql)

        ''If archivos <> "" Then

        ''    Dim tramaTXT As String
        ''    Dim NombreArchivo As String


        ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSMS")
        ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSMS", NombreArchivo)
        ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSMS", NombreArchivo)
        ''tramaTXT = ""

        ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageLSHS")
        ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageLSHS", NombreArchivo)
        ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageLSHS", NombreArchivo)
        ''tramaTXT = ""

        ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageHSMS")
        ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageHSMS", NombreArchivo)
        ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageHSMS", NombreArchivo)
        ''tramaTXT = ""

        ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(lbl_pedidoD.Text), fabricante, "DiffimageBASO")
        ''pic_Diff.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "DiffimageBASO", NombreArchivo)
        ''opr_resul.GuardarImagen(CInt(lbl_pedidoD.Text), "DiffimageBASO", NombreArchivo)
        ''tramaTXT = ""

        ' ''    tramaTXT = opr_resul.ConsultaHistgrama(CInt(ped_id), fabricante, "WBCImage")
        ' ''    pic_plt.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "WBCImage", NombreArchivo)
        ' ''    opr_resul.GuardarImagen(CInt(ped_id), "WBCImage", NombreArchivo)
        ' ''    tramaTXT = ""

        ' ''    tramaTXT = opr_resul.ConsultaHistgrama(CInt(ped_id), fabricante, "RBCimage")
        ' ''    pic_rbc.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "RBCimage", NombreArchivo)
        ' ''    opr_resul.GuardarImagen(CInt(ped_id), "RBCimage", NombreArchivo)
        ' ''    tramaTXT = ""

        ' ''    tramaTXT = opr_resul.ConsultaHistgrama(CInt(ped_id), fabricante, "PLTimage")
        ' ''    pic_plt.Image = Base64ToImage(tramaTXT, Trim(dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString), "PLTimage", NombreArchivo)
        ' ''    opr_resul.GuardarImagen(CInt(ped_id), "PLTimage", NombreArchivo)
        ' ''    tramaTXT = ""




        ' ''    ''str_sql = "SELECT  pedido.PED_ID, File_DiffimageLSMS, File_DiffimageLSHS, File_DiffimageHSMS, File_DiffimageBASO, file_RBCimage, file_PLTimage, File_WBCimage " & _
        ' ''    ''"FROM pedido, ptohistograma " & _
        ' ''    ''"where pedido.ped_id = ptohistograma.ped_id  " & _
        ' ''    ''"and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

        ' ''    'str_sql = "SELECT  pedido.PED_ID, File_DiffimageLSMS, File_DiffimageLSHS, File_DiffimageHSMS, File_DiffimageBASO, file_RBCimage, file_PLTimage, File_WBCimage " & _
        ' ''    '"FROM pedido, ptohistograma " & _
        ' ''    '"where pedido.ped_id = ptohistograma.ped_id  " & _
        ' ''    '"and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

        ' ''    str_sql = "SELECT  pedido.PED_ID, file_WBCimage, file_RBCimage, file_PLTimage " & _
        ' ''    "FROM pedido, ptohistograma " & _
        ' ''    "where pedido.ped_id = ptohistograma.ped_id  " & _
        ' ''    "and pedido.PED_ID = " & CInt(lbl_pedidoD.Text) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"

        ' ''    archivos = opr_res.ConsultaPathFilesImg(str_sql)
        ' ''    dts_histograma = ReturnDataSet(archivos)
        ' ''End If

        ' ''If dts_histograma.Tables.Count >= 1 Then
        ' ''    str_his = "HISTOGRAMA"
        ' ''Else
        ' ''    str_his = "NOHISTOGRAMA"
        ' ''End If





        '' '' '' ''******** CONSULTO SI TIENE QR ******
        str_sql = "SELECT  pedido.PED_ID, img_base64 " & _
           "FROM pedido, ptoImagen " & _
           "where pedido.ped_id = ptoImagen.ped_id  " & _
           "and pedido.PED_ID = " & CInt(ped_id) & " and ptoImagen.img_nombre  = 'QR'"

        'Dim dts_imagen As New DataSet()
        Dim str_img As String = "NOIMAGEN"

        archivoQR = opr_resul.ConsultaPathFilesImagenQR(str_sql)

        ' archivoQR = Nothing

        If archivoQR <> "" Then
            archivos = Nothing
            Dim tramaTXT As String
            Dim NombreArchivo As String


            tramaTXT = opr_resul.ConsultaImagen(CInt(ped_id), "QR")
            frm_VisResul.Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & orden, "", NombreArchivo)
            opr_resul.GuardarImagenOcupacional(CInt(ped_id), "QR", NombreArchivo)
            tramaTXT = ""

            str_sql = "SELECT  pedido.PED_ID,  img_file " & _
                 "FROM pedido, ptoImagen " & _
                 "where pedido.ped_id = ptoImagen.ped_id  " & _
                 "and pedido.PED_ID = " & CInt(ped_id) & " and ptoImagen.Img_NOMBRE = 'QR'"

            archivos = opr_resul.ConsultaPathFilesImgOcupacional(str_sql)
            dts_imagen = ReturnDataSetOcup(archivos)
        End If
       

        '(((365* year(getdate()))-(365*(year(paciente.PAC_FECNAC))))+ (month(getdate())-month(paciente.PAC_FECNAC))*30 +(day(getdate()) - day(paciente.PAC_FECNAC)))/365

        str_sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
      "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL) end AS resultado1, " & _
      "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end AS resultado2, RES_PROCESADOS.PRC_ALARMA as Alarma, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
      "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
          "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
          "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
          "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO," & _
          "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
          "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
         "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
          "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
      "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id " & _
          "FROM AREA INNER JOIN (UNIDAD " & _
          "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
          "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
          "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
          "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
          "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO " & _
              "WHERE TEST_RESULTADO.RES_ID <>1 AND RES_PROCESADOS.PED_ID='" & ped_id & "' AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
          "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID and test.are_id <> 83 "
        'str_sql = str_sql & str_aux
        str_sql = str_sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2,'' as Alarma, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "RESAB_PROCESADOS.PRC_NOTASECC AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_RECIBO AS CONVENIO, " & _
                "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, resAB_procesados.LIS_user as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' as RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id " & _
        "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
        "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = " & ped_id & " AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
        "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
        "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
        "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "

        str_sql = str_sql & " order by AREA.ARE_OBS, test.TES_ORDENIMP, RES_PROCESADOS.TIM_ID "

        devuelvePedidosBloque = str_sql

    End Function


    Public Function devuelvePedidosBloqueVF(ByVal frm_formulario As frm_ValFinal, ByRef orden As String, ByVal fecha_nac As Date, ByVal aareas As String, ByRef dts_histograma As DataSet, ByRef dts_imagen As DataSet) As String
        Dim str_sql As String = Nothing
        Dim archivos As String = Nothing
        Dim archivoQR As String = Nothing
        Dim fabricante As String = System.Configuration.ConfigurationSettings.AppSettings("HistogramaEquipo")

        '******Dependiendo si existe o no histograma va el campo Histograma
        str_sql = "SELECT  pedido.PED_ID, WBCimage, RBCimage, PLTimage " & _
                   "FROM pedido, ptohistograma " & _
                   "where pedido.ped_id = ptohistograma.ped_id  " & _
                  "and pedido.PED_ID = " & CInt(orden) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"



        'Dim dts_histograma As New DataSet()
        Dim str_his As String = "NOHISTOGRAMA"
        Dim unidad As String = Nothing

        '************* calcula edad
        Dim str_edad As String = Nothing

        str_edad = CalculaEdad(fecha_nac, unidad)
        str_edad = str_edad & " " & unidad


        archivos = opr_resul.ConsultaPathFiles(str_sql)

        If archivos <> "" Then

            Dim tramaTXT As String
            Dim NombreArchivo As String

            'tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), "Human", "Diffimage")
            'frm_formulario.pic_Diff.Image = Base64ToImage(tramaTXT, orden, "Diffimage", NombreArchivo)
            'opr_resul.GuardarImagen(CInt(orden), "Diffimage", NombreArchivo)
            'tramaTXT = ""
            frm_formulario.pic_wbc.Image = Nothing


            

            tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "WBCimage")

            'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
            Dim byteArrayWBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
            Dim imageWBC = convertbytetoimage(byteArrayWBC) 'Using Functions To Make the code tidier
            NombreArchivo = "WBCimage.gif"
            opr_resul.GuardarImagen(CInt(orden), "WBCimage", NombreArchivo)
            tramaTXT = ""


            'tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "RBCimage")

            ''Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
            'Dim byteArrayRBC = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
            'Dim imageRBC = convertbytetoimage(byteArrayRBC) 'Using Functions To Make the code tidier
            'NombreArchivo = "RBCimage.gif"
            'opr_resul.GuardarImagen(CInt(orden), "RBCimage", NombreArchivo)
            'tramaTXT = ""


            tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "PLTimage")

            'Dim base64String = ConvertImageToBase64String() 'Using Functions To Make the code tidier
            Dim byteArrayPLT = ConvertBase64ToByteArray(tramaTXT) 'Using Functions To Make the code tidier
            Dim image = convertbytetoimage(byteArrayPLT) 'Using Functions To Make the code tidier
            NombreArchivo = "PLTimage.gif"
            opr_resul.GuardarImagen(CInt(orden), "PLTimage", NombreArchivo)
            tramaTXT = ""

            ' ''frm_formulario.pic_wbc.Image = Base64ToImage(tramaTXT, orden, "WBCimage", NombreArchivo)
            ''opr_resul.GuardarImagen(CInt(orden), "WBCimage", NombreArchivo)
            ''tramaTXT = ""

            ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "RBCimage")
            ''frm_formulario.pic_rbc.Image = Base64ToImage(tramaTXT, orden, "RBCimage", NombreArchivo)
            ''opr_resul.GuardarImagen(CInt(orden), "RBCimage", NombreArchivo)
            ''tramaTXT = ""

            ''tramaTXT = opr_resul.ConsultaHistgrama(CInt(orden), fabricante, "PLTimage")
            ''frm_formulario.pic_plt.Image = Base64ToImage(tramaTXT, orden, "PLTimage", NombreArchivo)
            ''opr_resul.GuardarImagen(CInt(orden), "PLTimage", NombreArchivo)
            ''tramaTXT = ""

            str_sql = "SELECT  pedido.PED_ID, file_WBCimage, file_RBCimage, file_PLTimage " & _
            "FROM pedido, ptohistograma " & _
            "where pedido.ped_id = ptohistograma.ped_id  " & _
            "and pedido.PED_ID = " & CInt(orden) & " and ptohistograma.HIS_NOMBRE = '" & fabricante & "'"


            archivos = opr_resul.ConsultaPathFilesImg(str_sql)
            dts_histograma = ReturnDataSet(archivos, byteArrayWBC, byteArrayWBC, byteArrayPLT)
            'dts_histograma = ReturnDataSet(archivos, byteArrayWBC, byteArrayRBC, byteArrayPLT)
        End If

       
        'QR
        archivoQR = Nothing

        '' '' '' ''******** CONSULTO SI TIENE QR ******
        str_sql = "SELECT  pedido.PED_ID, img_base64 " & _
           "FROM pedido, ptoImagen " & _
           "where pedido.ped_id = ptoImagen.ped_id  " & _
           "and pedido.PED_ID = " & CInt(orden) & " and ptoImagen.img_nombre  = 'QR'"

        archivoQR = opr_resul.ConsultaPathFilesImagenQR(str_sql)

        If archivoQR <> "" Then
            archivos = Nothing
            Dim tramaTXT As String
            Dim NombreArchivo As String


            tramaTXT = opr_resul.ConsultaImagen(CInt(orden), "QR")
            frm_formulario.Pic_QR.Image = Base64ToImageOcupacional(tramaTXT, Format(Now, "yy") & orden, "", NombreArchivo)
            opr_resul.GuardarImagenOcupacional(CInt(orden), "QR", NombreArchivo)
            tramaTXT = ""
            frm_formulario.Pic_QR.Image = Nothing
            'Pic_QR.Refresh()
            'Pic_QR.Dispose()

            str_sql = "SELECT  pedido.PED_ID,  img_file " & _
                 "FROM pedido, ptoImagen " & _
                 "where pedido.ped_id = ptoImagen.ped_id  " & _
                 "and pedido.PED_ID = " & CInt(orden) & " and ptoImagen.Img_NOMBRE = 'QR'"

            archivos = opr_resul.ConsultaPathFilesImgOcupacional(str_sql)
            dts_imagen = ReturnDataSetOcup(archivos)

        End If
        
        ''''''PDF VF
        str_sql = "SELECT RES_PROCESADOS.PED_ID AS num_pedido, RES_PROCESADOS.TES_ABREV AS abreviatura, test.TES_NOMBRE AS test, UNIDAD.UNI_NOMENCLATURA AS unidad, " & _
      "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else  (RES_PROCESADOS.PRC_RESFINAL)  end AS resultado1, " & _
      "case when (RES_PROCESADOS.PRC_RESFINAL = 'MEMO') then (RES_PROCESADOS.PRC_TEXTO) else (RES_PROCESADOS.PRC_RESFINAL) end AS resultado2, RES_PROCESADOS.PRC_ALARMA as Alarma, RES_PROCESADOS.PRC_RANGO AS rango, PEDIDO.PED_FECING AS PED_FECING, " & _
      "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, " & _
          "MEDICO.MED_NOMBRE AS MED_NOMBRE, test.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
          "PRC_NOTASECC AS SECC, test.TES_ORDENIMP AS ORDEN_IMP, '3' as TIPO, test.TES_TIPOREPORTE as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
          "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_TIPO AS CONVENIO," & _
          "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, RES_PROCESADOS.PRC_ERROR as observaciones, " & _
          "INVITADO.invitado_firma as LIS_USER, PACIENTE.PAC_SEXO, RES_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, " & _
         "SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) +" & _
          "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
          "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
      "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, case test.TES_TIPO when 'Examen' then test.TES_OBS else test.TES_OBS end as metodo, RES_PROCESADOS.TIM_ID, AREA.ARE_OBS, TEST_EQUIPO.TEQ_TRANGO AS RANG_TIPO, PEDIDO.PED_NUMAUX, test_resultado.RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id, PEDIDO.ped_TIPO " & _
          "FROM AREA INNER JOIN (UNIDAD " & _
          "INNER JOIN (test INNER JOIN (PACIENTE INNER JOIN (MEDICO INNER JOIN ( INVITADO INNER JOIN (EQUIPO INNER JOIN ((RES_PROCESADOS " & _
          "INNER JOIN TEST_EQUIPO ON RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA) " & _
          "INNER JOIN PEDIDO ON RES_PROCESADOS.PED_ID = PEDIDO.PED_ID) ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) " & _
          "ON INVITADO.invitado_id = RES_PROCESADOS.LIS_USER) ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) ON test.TES_ID = TEST_EQUIPO.TES_ID) " & _
          "ON UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID) ON AREA.ARE_ID = test.ARE_ID, TEST_RESULTADO " & _
              "WHERE TEST_RESULTADO.RES_ID <>1 AND RES_PROCESADOS.PED_ID='" & orden & "' AND RES_PROCESADOS.PRC_RESFINAL <> '' AND RES_PROCESADOS.TIM_ID = test.TIM_ID AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
          "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre and TEST_RESULTADO.TES_ID = TEST.TES_ID and test.are_id <> 83 "
        'str_sql = str_sql & str_aux

        If aareas <> 83 Then

        Else
            str_sql = str_sql & " and area.are_id <> 83 "
        End If


        str_sql = str_sql & "union select RESAB_PROCESADOS.PED_ID AS num_pedido, '' AS abreviatura, ('     ' + ANTIBIOTICO.ANB_NOMBRE) AS test, '' AS unidad, " & _
                "RESAB_PROCESADOS.PRC_RESUL as resultado1, RESAB_PROCESADOS.PRC_RESUL as resultado2,'' as Alarma, '' as rango, PEDIDO.PED_FECING as PED_FECING, " & _
                "(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, MEDICO.MED_NOMBRE AS MED_NOMBRE, ANTIBIOTICO.ARE_ID AS AREA_ID, AREA.ARE_NOMBRE AS AREA_NOMBRE, " & _
                "'' AS SECC, ANTIBIOTICO.ANB_ORDEN AS ORDEN_IMP, '' AS TIPO, '' as tipo_reporte, PEDIDO.PED_TURNO as turno, " & _
                "PACIENTE.pac_fecnac as grado, PACIENTE.pac_usafecnac as usa_fec_nac, '" & str_edad & "' as edad, pedido.PED_TIPO AS CONVENIO, " & _
                "ped_servicio AS SERVICIO, PACIENTE.pac_doc as pac_hist_clinica, '' as observaciones, resAB_procesados.LIS_user as LIS_USER, PACIENTE.PAC_SEXO, RESAB_PROCESADOS.lis_fecvalidado as LIS_FECVALIDADO, SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2)) + " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                "when len(PEDIDO.PED_TURNO) = 5 then( convert(varchar(100),PEDIDO.PED_TURNO)) end as CB, " & _
                "INVITADO.invitado_cargo as cargo, INVITADO.invitado_folio as folio, '' as metodo, RESAB_PROCESADOS.TIM_ID as TIM_ID, AREA.ARE_OBS, '' as RANG_TIPO, PEDIDO.PED_NUMAUX, '' as RES_ID, '" & str_his & "' AS HISTOGRAMA, paciente.PAC_FONO as fono, INVITADO.invitado_id, PEDIDO.ped_TIPO " & _
        "FROM RESAB_PROCESADOS, ANTIBIOTICO, PEDIDO, PACIENTE, MEDICO, AREA, INVITADO " & _
        "WHERE AREA.ARE_ID = antibiotico.ARE_ID and RESAB_PROCESADOS.PED_ID = '" & orden & "' AND INVITADO.INVITADO_ID = resab_procesados.LIS_USER AND RESAB_PROCESADOS.PED_ID = PEDIDO.PED_ID " & _
        "AND RESAB_PROCESADOS.ANB_ID = ANTIBIOTICO.ANB_ID " & _
        "AND PEDIDO.PAC_ID = PACIENTE.PAC_ID " & _
        "AND MEDICO.MED_ID = PEDIDO.MED_ID AND RESAB_PROCESADOS.PRC_RESUL <> '' "


        str_sql = str_sql & " order by AREA.ARE_OBS, test.TES_ORDENIMP, RES_PROCESADOS.TIM_ID "

        devuelvePedidosBloqueVF = str_sql

    End Function



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

            If File.Exists(vFileName) = True Then
                ' AQUI
                'File.Delete(vFileName)
                EliminaArchivoTxt(vFileName)
            Else

            End If
            'diskOpts.DiskFileName = vFileName

            File.WriteAllBytes(vFileName, imageBytes)


            Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
            Dim tmpImage As Image = Image.FromStream(ms, True)
            'NombreArchivo = vFileName

            Return tmpImage
        End If
    End Function


    Public Function ReturnDataSet(ByVal files As String, ByVal WBCImageByte As Byte(), ByVal RBCImageByte As Byte(), ByVal PLTImageByte As Byte()) As DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim files_arreglo As String()
        Dim pathImg As String = Nothing
        files_arreglo = Split(files, "\")

        pathImg = Environment.CurrentDirectory & "\" & g_pathFolderImg

        dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt.Columns.Add(New DataColumn("Descripcion2", GetType(String)))
        dt.Columns.Add(New DataColumn("Descripcion3", GetType(String)))
        'dt.Columns.Add(New DataColumn("Descripcion4", GetType(String)))
        'dt.Columns.Add(New DataColumn("Descripcion5", GetType(String)))
        'dt.Columns.Add(New DataColumn("Descripcion6", GetType(String)))
        'dt.Columns.Add(New DataColumn("Descripcion7", GetType(String)))

        dt.Columns.Add(New DataColumn("Imagen", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen2", GetType(Byte())))
        dt.Columns.Add(New DataColumn("Imagen3", GetType(Byte())))
        'dt.Columns.Add(New DataColumn("Imagen4", GetType(Byte())))
        'dt.Columns.Add(New DataColumn("Imagen5", GetType(Byte())))
        'dt.Columns.Add(New DataColumn("Imagen6", GetType(Byte())))
        'dt.Columns.Add(New DataColumn("Imagen7", GetType(Byte())))


        dr = dt.NewRow()
        'dr("Descripcion") = "LM-LS "
        'dr("Descripcion2") = "LS-HS"
        'dr("Descripcion3") = "LS-HS"
        'dr("Descripcion4") = "HS-MS"
        dr("Descripcion") = "WBC"
        dr("Descripcion2") = "RBC"
        dr("Descripcion3") = "PLT"

        dr("Imagen") = WBCImageByte
        dr("Imagen2") = RBCImageByte
        dr("Imagen3") = PLTImageByte

        'dr("Imagen") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(0)))
        'dr("Imagen2") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(1)))
        'dr("Imagen3") = ImageToByte(Image.FromFile(pathImg & "\" & files_arreglo(2)))


        dt.Rows.Add(dr)

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

    Public Function GuardaDatosGrid(ByRef dg As DataGridView, ByRef var_desde As Integer, ByVal convenio As String, ByVal fecha As Date, ByVal prioridad As String, ByVal PrePost As String, ByVal Timer1 As System.Windows.Forms.Timer, ByVal Progresbar1 As Windows.Forms.ProgressBar, ByVal medico As String, ByRef pedidos As String, Optional ByVal OPERACION As Byte = 0) As Byte

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim str_sql As String = Nothing
        Dim num_regexcel As Integer
        Dim MaxPedido As Integer
        Dim pac_id As Integer
        Dim doc_id As String = Nothing
        Dim pac_hc As String
        Dim opr_pac As New Cls_Paciente
        Dim opr_ped As New Cls_Pedido
        Dim pac_edad As String
        Dim pac_dir As String
        Dim pac_sexo As Char
        Dim pac_fecnac As Date
        Dim pacienteA As String = Nothing
        Dim pacienteN As String = Nothing
        Dim pac_usafec As Byte
        Dim afiliacion As String = Nothing
        Dim pac_fecing As Date
        Dim ciu_id, prov_id As Integer
        Dim ciu_nombre, prov_nombre As String
        Dim dtr_fila As DataRow
        Dim dts_perfiles As DataSet
        Dim cont As Integer = 0
        Dim parametros As String = Nothing
        Dim examenes As String = Nothing
        Dim precios As String = Nothing
        Dim prioridad_1 As String()
        Dim var_tot As Integer
        Dim var_no As Integer
        Dim med_id As Integer
        Dim grado As String = Nothing
        Dim pac_fono As String = Nothing

        med_id = CInt(Trim(Mid(medico, 100, 10)))

        On Error GoTo MsgError
        

        num_regexcel = dg.RowCount - 1


        Dim Incremento As Long
        Incremento = 100 / num_regexcel

        For i = 0 To (num_regexcel - 1)
            '1 BUSCO PACIENTE CASO CONTRARIO LO CREO
            If opr_pac.buscapacienteCed(Trim(dg.Item(3, i).Value.ToString())) = 0 Then
                pac_id = opr_pac.LeerMaxPaciente() + 1
                pac_hc = opr_pac.buscamaxHC() + 1
                pac_fecing = Format(Now, "yyyy/MM/dd HH:mm")
                ciu_id = System.Configuration.ConfigurationSettings.AppSettings("CIU_ID")
                prov_id = System.Configuration.ConfigurationSettings.AppSettings("PROV_ID")

                ciu_nombre = System.Configuration.ConfigurationSettings.AppSettings("CIU_NOM")
                prov_nombre = System.Configuration.ConfigurationSettings.AppSettings("PROV_NOMBRE")

                opr_pac.GuardarPaciente(pac_id, Trim(dg.Item(3, i).Value.ToString()), 1, Trim(dg.Item(1, i).Value.ToString()), Trim(dg.Item(2, i).Value.ToString()), "", "", Trim(dg.Item(5, i).Value.ToString()), Trim(dg.Item(4, i).Value.ToString()), pac_fecing, "", ciu_id, "", pac_hc, 1, "", "", 0, "Ecuador", "NA", "", "", "", prov_id, prov_nombre, ciu_nombre, prov_id, ciu_id, prov_nombre, ciu_nombre, "")

            Else
                'ByVal doc As String, ByRef pac_hc As String, ByRef paciente As String, ByRef edad As String, ByRef pacdireccion As String, ByRef pacsexo As String, ByRef usafec As Integer, ByRef afiliacion As String, ByRef fechanac As Date, ByRef fecing As String, ByRef pac_id As String
                opr_pac.buscapacienteHC(Trim(dg.Item(3, i).Value.ToString()), pac_hc, pacienteA, pacienteN, pac_edad, pac_dir, pac_sexo, pac_usafec, afiliacion, pac_fecnac, pac_fecing, pac_id, grado, pac_fono)
            End If


            '2 BUSCO EXAMENES DEL PERFIL 
            Dim perfil_nombre As String
            Dim perfil As String()
            Dim nom_conv As String()

            perfil = Split(dg.Item(6, i).Value.ToString(), "/")

            nom_conv = Split(convenio, "/")
            perfil_nombre = Trim(perfil(0))

            opr_ped.LeePerfilExamenes(perfil_nombre, Trim(nom_conv(0)), examenes, precios)

            '3 REGISTRO PEDIDOS
            prioridad_1 = Split(prioridad, "/")

            Dim turno As String = Format(opr_ped.LeerMaxturno(Trim(prioridad_1(0)), Format(fecha, "dd/MM/yyyy"), Val(1), False), "0000#")
            If turno = "0" Or turno = "00001" Then
                var_desde = prioridad_1(1)
            Else
                ' If turno = prioridad(1) Then
                var_desde = Trim(turno)
            End If

            parametros = fecha & "," & Trim(prioridad_1(0)) & "," & prioridad_1(0) & "," & var_desde

            MaxPedido = LeerMaxPedido() + 1
            pedidos = pedidos & CStr(MaxPedido) & ","

            If opr_ped.GuardarPedidoConvenioImportar(parametros, CLng(pac_id), CLng(MaxPedido), 1, examenes, precios, fecha, Trim(dg.Item(5, i).Value.ToString()), Trim(dg.Item(4, i).Value.ToString()), PrePost, med_id, Trim(dg.Item(7, i).Value.ToString())) = 1 Then
            Else
                var_no = var_nota + 1
            End If
            Progresbar1.Increment(Incremento)
        Next
        Progresbar1.Increment(Incremento)
        MsgBox("Se ha completado el proceso de importacion, " & vbCrLf & "Total registros cargados: " & num_regexcel, MsgBoxStyle.Information, "ANALISYS")
        GuardaDatosGrid = 1

        Exit Function

MsgError:
        GuardaDatosGrid = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer perfil", Err)
        Err.Clear()
    End Function

    Public Function lee_perfiles() As DataSet
        'Funcion para la consultar los datos de la tabla PEDIDO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()

        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        str_sql = "Select tes_nombre, test.tes_id, 'E' as Perfil from test, lista_precio, area where lista_precio.tes_id=test.tes_id and TES_PARAMETRO <>1 and area.ARE_ID = test.ARE_ID and con_nombre='BIOTEC' and test.TES_TIPO = 'Examen' and area.ARE_NOMBRE = 'P' " & _
        "union " & _
        "select PER_NOMBRE as tes_nombre, PER_ID as tes_id, 'P' as Perfil from perfil where PER_ESTADO = 1 order by  tes_nombre;"

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        lee_perfiles = New DataSet()
        oda_operacion.Fill(lee_perfiles, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Perfil", Err)
        Err.Clear()
    End Function

    Public Function LeerPedidos() As DataSet
        'Funcion para la consultar los datos de la tabla PEDIDO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        opr_Conexion.sql_conectar()
        str_sql = "SELECT PEDIDO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_NOMBRE, ' ' , PACIENTE.PAC_APELLIDO) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota FROM PACIENTE INNER JOIN (MEDICO INNER JOIN PEDIDO ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID where PEDIDO.ped_estado < 2"
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPedidos = New DataSet("Pedidos")
        oda_operacion.Fill(LeerPedidos, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedidos", Err)
        Err.Clear()
    End Function


    



    Sub LlenarComboPrioridad(ByRef combo As ComboBox, ByVal VisibleTODOS As Boolean, ByVal VerEliminar As Boolean)
        On Error Resume Next
        'Para llenar el combo de convenio
        Dim dts_prioridad As DataSet
        Dim dtr_fila As DataRow
        dts_prioridad = LeerPrioridad(VerEliminar)
        combo.Items.Clear()

        'combo.Items.Add("TODOS".PadRight(50) & "/0".PadRight(4) & "/99999".PadRight(4))

        For Each dtr_fila In dts_prioridad.Tables("Registros").Rows
            combo.Items.Add(dtr_fila("sec_nombre").ToString().PadRight(50) & "/" & dtr_fila("sec_desde").ToString().PadRight(4) & "/" & dtr_fila("sec_hasta").ToString().PadRight(4))
            'combo.Items.Add("REVIR".PadRight(50) & "/" & "2900".PadRight(4) & "/" & "3100".PadRight(4))
        Next
        dts_prioridad.Dispose()
        combo.SelectedIndex = 0

    End Sub


    Sub LlenarComboPrioridadTODOS(ByRef combo As ComboBox, ByVal VisibleTODOS As Boolean)
        On Error Resume Next
        'Para llenar el combo de convenio
        Dim dts_prioridad As DataSet
        Dim dtr_fila As DataRow
        dts_prioridad = LeerPrioridadTODOS()
        combo.Items.Clear()

        combo.Items.Add("TODOS".PadRight(50) & "/0".PadRight(4) & "/99999".PadRight(4))

        For Each dtr_fila In dts_prioridad.Tables("Registros").Rows
            combo.Items.Add(dtr_fila("sec_nombre").ToString().PadRight(50) & "/" & dtr_fila("sec_desde").ToString().PadRight(4) & "/" & dtr_fila("sec_hasta").ToString().PadRight(4))
            'combo.Items.Add("REVIR".PadRight(50) & "/" & "2900".PadRight(4) & "/" & "3100".PadRight(4))
        Next
        dts_prioridad.Dispose()
        combo.SelectedIndex = 0
    End Sub


    Public Function LeerPrioridad(ByVal VerEliminar As Boolean) As DataSet
        'Procedimiento para consultar todas los Convenios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        opr_Conexion.sql_conectar()
        If VerEliminar Then
            str_sql = "Select * from secuencias order by sec_id asc;"
        Else
            str_sql = "Select * from secuencias where sec_estado <> 0 order by sec_id asc;"
        End If
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPrioridad = New DataSet()
        oda_operacion.Fill(LeerPrioridad, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Secuencias", Err)
        Err.Clear()
    End Function


    Public Function LeerPrioridadTODOS() As DataSet
        'Procedimiento para consultar todas los Convenios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        opr_Conexion.sql_conectar()
            str_sql = "Select * from secuencias where sec_estado <> 0 order by sec_id asc;"
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPrioridadTODOS = New DataSet()
        oda_operacion.Fill(LeerPrioridadTODOS, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Secuencias", Err)
        Err.Clear()
    End Function


    Public Function LeerEquId(ByVal ped_id As Integer, ByVal tes_id As Integer) As Integer

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerEquId = CInt(New SqlCommand("select distinct(equ_id) from lista_trabajo where ped_id = " & ped_id & " and tes_id =  " & tes_id & "; ", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerNombreTest", Err)
        Err.Clear()
    End Function




    Public Sub InsertarNotaArea(ByVal ped_id As Integer, ByVal are_id As Integer, ByVal nota As String)
        'PROCEDIMIENTO para insertar una nota al examen( )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "update res_procesados set PRC_NOTASECC = '" & nota & "' where PED_ID = " & ped_id & " and are_id = " & are_id & "; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "update resab_procesados set PRC_NOTASECC = '" & nota & "' where PED_ID = " & ped_id & " ; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar Nota Area", Err)
        Err.Clear()
    End Sub



    Public Function LeerPedidosLTxValidar(ByVal usu_id As Integer, ByVal fec_ini As Date, ByVal fec_fin As Date) As DataSet
        'Funcion que consulta los pedidos que est�n en la lista de trabajo y tienen al menos un resultado ingresado
        'tiempo: 0 todos ;  1 ultimo mes; 2 ultimo d�a
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        Dim str_areas As String = ""
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer

       

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)
       
        opr_Conexion.sql_conectar()
        'concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno
        '"PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE ((LISTA_TRABAJO.LIS_RESESTADO = 1) OR ((LISTA_TRABAJO.LIS_reSESTADO = 0 or LISTA_TRABAJO.LIS_reSESTADO = 3 or LISTA_TRABAJO.LIS_reSESTADO = 4) AND NOT ISNULL(LISTA_TRABAJO.EQU_ID))) AND MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        str_sql = "SELECT PEDIDO.PED_TURNO as ped_turno, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, IF(PEDIDO.PED_ESTADO = 3,'VALIDADO',if (PEDIDO.PED_ESTADO = 2,'PROCESADO','PENDIENTE')) as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO FROM " & _
        "PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        '"PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE LISTA_TRABAJO.LIS_RESESTADO <> 2 AND MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        int_i = UBound(areas)
        'controla que tenga areas por consultar
        Dim i As Integer
        If int_i > 0 Then
            For i = 0 To (int_i - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If

        str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') group by PEDIDO.PED_ID order by ped_fecing desc, ped_turno desc"
        str_sql = str_sql & " " & str_aux


        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPedidosLTxValidar = New DataSet("Pedidos")
        oda_operacion.Fill(LeerPedidosLTxValidar, "Registros")
        LeerPedidosLTxValidar.Dispose()
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedidos", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function


    Public Function LeerPedidosLTxValidar2(ByVal usu_id As Integer, ByVal fec_ini As Date, ByVal fec_fin As Date, ByVal prioridad As String, ByVal areas As Integer) As DataSet
        'Funcion que consulta los pedidos que est�n en la lista de trabajo y tienen al menos un resultado ingresado
        'tiempo: 0 todos ;  1 ultimo mes; 2 ultimo d�a
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing
        Dim str_order As String = Nothing
        Dim str_areas As String = Nothing
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer

        'opr_user.LeerAreasUsuario(g_sng_user, arr_datos, arr_nombre)
        ' For int_i = 0 To arr_datos.Count - 1
        'str_areas = str_areas & arr_datos(int_i) & ","
        str_areas = areas
        'Next
        opr_Conexion.sql_conectar()
        '' '' '' ''concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno
        '' '' '' ''"PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE ((LISTA_TRABAJO.LIS_RESESTADO = 1) OR ((LISTA_TRABAJO.LIS_reSESTADO = 0 or LISTA_TRABAJO.LIS_reSESTADO = 3 or LISTA_TRABAJO.LIS_reSESTADO = 4) AND NOT ISNULL(LISTA_TRABAJO.EQU_ID))) AND MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        ' '' '' ''str_sql = "SELECT PEDIDO.PED_TURNO as ped_turno, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO+ ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, case when (PEDIDO.PED_ESTADO = 3) then 'VALIDADO' else case when (PEDIDO.PED_ESTADO = 2) then 'PROCESADO' else 'PENDIENTE' end end as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO FROM " & _
        ' '' '' ''"PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        '' '' '' ''"PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE LISTA_TRABAJO.LIS_RESESTADO <> 2 AND MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        '' '' '' ''Dim areas() As String
        ' '' '' ''Dim str_aux As String = "and TEST.are_id in (" & areas & ") "
        '' '' '' ''areas = Split(str_areas, ",")
        '' '' '' ''int_i = UBound(areas)
        '' '' '' ''controla que tenga areas por consultar
        '' '' '' ''Dim i As Integer
        '' '' '' ''If int_i > 0 Then
        '' '' '' ''    For i = 0 To (int_i - 1)
        '' '' '' ''        If i = 0 Then
        '' '' '' ''            str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
        '' '' '' ''        Else
        '' '' '' ''            str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
        '' '' '' ''        End If
        '' '' '' ''    Next
        '' '' '' ''    str_aux = str_aux & " ) "
        '' '' '' ''End If

        ' '' '' ''str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') " & str_areas & " & group by PEDIDO.PED_ID, PEDIDO.PED_TURNO, PEDIDO.PED_FECING, PEDIDO.PAC_ID, PACIENTE.PAC_APELLIDO,PACIENTE.PAC_NOMBRE, PACIENTE.PAC_FECNAC, PEDIDO.PED_ESTADO, PEDIDO.PED_MEDICACION, MEDICO.MED_ID, MEDICO.MED_NOMBRE, PEDIDO.ped_nota, LISTA_TRABAJO.PED_ID, PACIENTE.PAC_USAFECNAC, PEDIDO.pac_id, PED_RECIBO order by ped_fecing desc, ped_turno desc; "
        ' '' '' ''str_sql = str_sql & " " & str_aux


        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
        "Case when PEDIDO.PED_ESTADO = 0 then 'INGRESADO' when PEDIDO.PED_ESTADO = 1 then 'PROCESADO' when PEDIDO.PED_ESTADO = 2 then 'ANULADO' when PEDIDO.PED_ESTADO = 3 then 'VALIDADO INCOMPLETO' when PEDIDO.PED_ESTADO = 4 then 'IMPRESO' when PEDIDO.PED_ESTADO = 5 then 'VALIDADO COMPLETO' when PEDIDO.PED_ESTADO = 5 then 'ENVIADO CORREO' end AS ESTADO, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_DOC as CI " & _
        "from pedido, medico, paciente, lista_trabajo, test " & _
        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
        "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
        "and PEDIDO.PED_PROF <> 1 " & _
        "and (TEST.TES_TIPO = 'Examen') " & _
        "and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 3 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _
        "and (PEDIDO.ped_fecing between '" & Mid(CStr(fec_ini), 1, 10) & " 00:00:00' and '" & Mid(CStr(fec_fin), 1, 10) & " 23:59:59') "

        str_order = " order by ped_fecing desc, ped_turno desc;"

        If prioridad <> "TODOS" Then
            str_sql = str_sql & " and PEDIDO.PED_TIPO = '" & prioridad & "'" & str_order
        Else
            str_sql = str_sql & str_order
        End If



        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPedidosLTxValidar2 = New DataSet("Pedidos")
        oda_operacion.Fill(LeerPedidosLTxValidar2, "Registros")
        LeerPedidosLTxValidar2.Dispose()
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedidos", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function


    Public Function LeerPedidosLTxValidarWin(ByVal usu_id As Integer, ByVal fec_ini As Date, ByVal fec_fin As Date) As DataSet
        'Funcion que consulta los pedidos que estan en la lista de trabajo y tienen al menos un resultado ingresado
        'tiempo: 0 todos ;  1 ultimo mes; 2 ultimo dia
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        Dim str_areas As String = ""
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)
      
        opr_Conexion.sql_conectar()
        'str_sql = "SELECT PEDIDO.PED_TURNO as ped_turno, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac FROM " & _
        '"PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE ((LISTA_TRABAJO.LIS_RESESTADO = 1) OR ((LISTA_TRABAJO.LIS_reSESTADO = 0 or LISTA_TRABAJO.LIS_reSESTADO = 3 or LISTA_TRABAJO.LIS_reSESTADO = 4) AND NOT ISNULL(LISTA_TRABAJO.EQU_ID))) AND MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        str_sql = "Select concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO))) ) as ped_turno, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO FROM " & _
        "PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE LISTA_TRABAJO.LIS_RESESTADO <> 2 AND MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID "
        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        int_i = UBound(areas)
        'controla que tenga areas por consultar
        Dim i As Integer
        If int_i > 0 Then
            For i = 0 To (int_i - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If

        str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') group by PEDIDO.PED_ID order by ped_fecing desc, ped_turno desc"
        str_sql = str_sql & " " & str_aux


        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPedidosLTxValidarWin = New DataSet("Pedidos")
        oda_operacion.Fill(LeerPedidosLTxValidarWin, "Registros")
        LeerPedidosLTxValidarWin.Dispose()
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedidos", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function

    Public Function LeerVademecum() As DataSet
        'Funcion para la consultar pedidos validados
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "select VAD_ID, VAD_TIPO, vp.PRES_DESCRIPCION, vp.PRES_ID, VAD_CANTIDAD, VAD_MEDGENERICO, VAD_MEDCOMERCIAL, VAD_INDICACIONES, VAD_EXTRAS " & _
                            "from vademecum as v, vademecumPresentacion as vp " & _
                            "where v.PRES_ID = vp.PRES_ID order by VAD_MEDCOMERCIAL"

        opr_Conexion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerVademecum = New DataSet()
        oda_operacion.Fill(LeerVademecum, "Registros")
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer vademecum", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function



    Public Function LeerPedidosValidos(ByVal fec_ini As Date, ByVal fec_fin As Date) As DataSet
        'Funcion para la consultar pedidos validados
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        opr_Conexion.sql_conectar()

        'str_sql = "SELECT PEDIDO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, concat(PACIENTE.PAC_APELLIDO , ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.PED_NOTA AS ped_nota, PEDIDO.PED_TURNO AS ped_turno, PACIENTE.PAC_USAFECNAC as pac_usafecnac, pac_doc as CI FROM PACIENTE INNER JOIN (MEDICO INNER JOIN PEDIDO ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID where (ped_estado = 3 or ped_estado = 4 or ped_estado = 5) and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') order by ped_fecing desc"
        str_sql = "SELECT PEDIDO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.PED_NOTA AS ped_nota, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
        "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
        "PACIENTE.PAC_USAFECNAC as pac_usafecnac, pac_doc as CI FROM PACIENTE INNER JOIN (MEDICO INNER JOIN PEDIDO ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID where (ped_estado <> 2 and ped_estado <> 1 and ped_estado <> 0)  and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') order by ped_fecing desc"
        'str_sql = "SELECT PEDIDO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, concat(PACIENTE.PAC_APELLIDO , ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.PED_NOTA AS ped_nota, PEDIDO.PED_TURNO AS ped_turno, PACIENTE.PAC_USAFECNAC as pac_usafecnac, pac_doc as CI FROM PACIENTE INNER JOIN (MEDICO INNER JOIN PEDIDO ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID where ped_estado = 2  and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59') order by ped_fecing desc"

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPedidosValidos = New DataSet()
        oda_operacion.Fill(LeerPedidosValidos, "Registros")
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedidos Validos", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function


    Public Function LeerCie10() As DataSet
        'Funcion para la consultar pedidos validados
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "select cie_cod3, cie_desc3, cie_cod4, cie_desc4 from cie10 order by cie_cod3, cie_cod4"

        opr_Conexion.sql_conectar()
        
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerCie10 = New DataSet()
        LeerCie10.Clear()
        oda_operacion.Fill(LeerCie10, "Registros")
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cie10", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function

    Public Function LeerVacunas(ByVal I_BOD_ID As String) As DataSet
        'Funcion para la consultar STOCK VACUNAS
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        
        Dim str_sql As String = "select p.I_PRD_ID, p.I_PRD_DESCRIPCION,  sum(md.I_MOD_CANTIDAD) as INV_CANTIDAD, bod.I_BOD_DESCRIPCION, md.I_MOD_LOTE, p.I_PRD_FRASCOS, SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) AS EDAD, 'LabAlergia Quito - Ecuador' AS ORIGEN, 'Subcutanea' as VIA, md.I_MOD_COSTO, p.SER_ID, u.I_UNI_DESCRIPCION, pn.PRES_DESCRIPCION, p.I_PRD_ABREV " & _
                "from i_movimiento as m, i_movimiento_detalle as md, i_producto as p, i_bodega as bod, vacunaSerie as vs, i_unidad as u, i_presentacion as pn " & _
                "where m.I_MOV_ID = md.I_MOV_ID And p.I_PRD_ID = md.I_PRD_ID And bod.I_BOD_ID = md.I_BOD_ID and p.I_AID <> 4 " & _
                "and p.I_UNI_ID = u.I_UNI_ID And vs.SER_ID = p.SER_ID and pn.PRES_ID = p.PRES_ID and bod.I_BOD_ID = '" & I_BOD_ID & "' " & _
                "group by p.I_PRD_ID, p.I_PRD_DESCRIPCION, bod.I_BOD_DESCRIPCION, md.I_MOD_LOTE, p.I_PRD_FRASCOS, md.I_MOD_COSTO, p.SER_ID, u.I_UNI_DESCRIPCION, pn.PRES_DESCRIPCION, p.I_PRD_ABREV "

        opr_Conexion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerVacunas = New DataSet()
        oda_operacion.Fill(LeerVacunas, "Registros")
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Vacunas", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function


    Public Function LeerMateriales(ByVal I_BOD_ID As String) As DataSet
        'Funcion para la consultar STOCK VACUNAS
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()


        Dim str_sql As String = "select p.I_PRD_ID, p.I_PRD_DESCRIPCION,  sum(md.I_MOD_CANTIDAD) as INV_CANTIDAD, bod.I_BOD_DESCRIPCION, md.I_MOD_LOTE, p.I_PRD_FRASCOS, SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) AS EDAD, 'LabAlergia Quito - Ecuador' AS ORIGEN, 'Subcutanea' as VIA, md.I_MOD_COSTO, p.SER_ID, u.I_UNI_DESCRIPCION, pn.PRES_DESCRIPCION, p.I_PRD_ABREV " & _
                "from i_movimiento as m, i_movimiento_detalle as md, i_producto as p, i_bodega as bod, vacunaSerie as vs, i_unidad as u, i_presentacion as pn " & _
                "where m.I_MOV_ID = md.I_MOV_ID And p.I_PRD_ID = md.I_PRD_ID And bod.I_BOD_ID = md.I_BOD_ID and p.I_AID = 4 " & _
                "and p.I_UNI_ID = u.I_UNI_ID And vs.SER_ID = p.SER_ID and pn.PRES_ID = p.PRES_ID and bod.I_BOD_ID = '" & I_BOD_ID & "'" & _
                "group by p.I_PRD_ID, p.I_PRD_DESCRIPCION, bod.I_BOD_DESCRIPCION, md.I_MOD_LOTE, p.I_PRD_FRASCOS, md.I_MOD_COSTO, p.SER_ID, u.I_UNI_DESCRIPCION, pn.PRES_DESCRIPCION, p.I_PRD_ABREV  "

        opr_Conexion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerMateriales = New DataSet()
        oda_operacion.Fill(LeerMateriales, "Registros")
        opr_Conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Materiales", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function


    Public Function LeerSeries(ByVal parametro As String) As DataSet

        'Funcion para la consultar STOCK VACUNAS
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select * from vacunaSerie where vac_cat = '" & parametro & "'"

        opr_Conexion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerSeries = New DataSet()
        oda_operacion.Fill(LeerSeries, "Series")
        opr_Conexion.sql_desconn()

        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Series", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function

    Public Function CalculaEdad(ByVal fecha As String, ByRef unidad As String) As String
        'funcion para calcular la edad del paciente
        Dim y, yn As Integer
        Dim m, mn As Integer
        Dim d, dn As Integer
        y = Year(Now)
        yn = Year(fecha)
        m = Month(Now)
        mn = Month(fecha)
        d = Microsoft.VisualBasic.Day(Now)
        dn = Microsoft.VisualBasic.Day(fecha)
        If dn <= d Then
            d = d - dn
        Else
            d = d + 30
            m = m - 1
            d = d - dn
        End If
        If mn <= m Then
            m = m - mn
        Else
            m = m + 12
            y = y - 1
            m = m - mn
        End If
        y = y - yn
        If (y < 2) Then
            If y < 1 Then
                If m > 0 Then
                    'meses
                    'Select Case m

                    'End Select
                    unidad = "MESES"
                    CalculaEdad = m
                    Exit Function
                Else
                    'dias
                    unidad = "DIAS"
                    CalculaEdad = d
                    Exit Function
                End If
            Else

                'anos y meses
                unidad = "AÑOS"
                CalculaEdad = y
            End If
        Else
            ' anos
            unidad = "AÑOS"
            CalculaEdad = y
        End If
        '**********
    End Function

    Public Function GuardaHistoriaCambios(ByVal HIC_ID As Integer, ByVal CAMPO As String, ByVal VAL_ANTERIOR As String, ByVal VAL_NUEVO As String, ByVal pac_id As Long, ByVal USR_ID As Integer)
        'Dim hic_id As Integer
        Dim str_sql As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        'hic_id = LeerMaxIdHistoria()
        str_sql = "insert into HistoriaClinicaCambios values(" & HIC_ID & ", getdate(), " & pac_id & " , '" & CAMPO & "', '" & VAL_ANTERIOR & "' , '" & VAL_NUEVO & "', " & USR_ID & ")"

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        odbc_trans.Commit()
        opr_conexion.sql_desconn()

    End Function

    Public Function GuardaHistoria(ByVal frm_formulario As frm_HistoriaClinica, ByVal pac_id As Long, ByVal var_hic_cli As String, ByVal arr_datoshc As String(), ByVal EsNUevo As Boolean)
        Dim str_sql As String = Nothing
        Dim str_sql1 As String = Nothing
        Dim sig_id As Integer
        Dim hic_id As Integer
        Dim efi_id As Integer
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim hic_Desencadenante, hic_Menstrua, hic_Ojos, hic_SNariz, hic_CEstornudos, hic_SBoca, hic_Prurito, hic_AccAsmaticos, hic_Piel, hic_Tos, hic_Digest, hic_SigEsp1, hic_SigEsp2, hic_asma, hic_rinitis, hic_urticaria, hic_eccem, hic_conjun, hic_drogas, hic_migra, hic_edema, hic_Otro, hic_ResNormal, hic_ResForzada, hic_Nariz, hic_NarizCorn, hic_NarizPol, hic_Garganta As String
        Dim hic_DeseOtro As String
        Dim temp_nuevo, temp_ant As String

        'CREO NUEVA HC
        sig_id = 1

        For Each ctlDesencadena As Control In frm_formulario.grp_Desencadena.Controls
            If TypeOf ctlDesencadena Is CheckBox Then
                If DirectCast(ctlDesencadena, CheckBox).Checked = True Then
                    hic_Desencadenante = hic_Desencadenante & ctlDesencadena.Text & ",1|"
                Else
                    hic_Desencadenante = hic_Desencadenante & ctlDesencadena.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_Desencadenante, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(23), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "DESENCADENANTES", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        If frm_formulario.chk1_OTROS.Checked Then
            hic_DeseOtro = Trim(frm_formulario.txt_DesOtro.Text)
        End If

        If EsNUevo = False Then
            If arr_datoshc(24) <> hic_DeseOtro Then
                GuardaHistoriaCambios(var_hic_cli, "DESENCADENANTE OTRO", arr_datoshc(24), hic_DeseOtro, pac_id, g_sng_user)
            End If
        End If


        For Each ctlMentruacion As Control In frm_formulario.grp_Menstruacion.Controls
            If TypeOf ctlMentruacion Is CheckBox Then
                If DirectCast(ctlMentruacion, CheckBox).Checked = True Then
                    hic_Menstrua = hic_Menstrua & ctlMentruacion.Text & ",1|"
                Else
                    hic_Menstrua = hic_Menstrua & ctlMentruacion.Text & ",0|"
                End If
            End If
        Next

        temp_nuevo = Replace(Replace(hic_Menstrua, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(25), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "MENSTRUACION", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        'MENSTRUACION TOMA MEDICAMENTO
        Dim hic_MenstruaToma As String
        If frm_formulario.chkM_Toma.Checked Then
            hic_MenstruaToma = Trim(frm_formulario.txt_MenstruToma.Text)
        End If

        If EsNUevo = False Then
            If arr_datoshc(26) <> hic_MenstruaToma Then
                GuardaHistoriaCambios(var_hic_cli, "MENSTRUACION TOMA", arr_datoshc(26), hic_MenstruaToma, pac_id, g_sng_user)
            End If
        End If

        For Each ctlOjos As Control In frm_formulario.grp_SinOjos.Controls
            If TypeOf ctlOjos Is CheckBox Then
                If DirectCast(ctlOjos, CheckBox).Checked = True Then
                    hic_Ojos = hic_Ojos & ctlOjos.Text & ",1|"
                Else
                    hic_Ojos = hic_Ojos & ctlOjos.Text & ",0|"
                End If
            End If
        Next

        temp_nuevo = Replace(Replace(hic_Ojos, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(27), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "SINT. OJOS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlSNariz As Control In frm_formulario.grp_SinNariz.Controls
            If TypeOf ctlSNariz Is CheckBox Then
                If DirectCast(ctlSNariz, CheckBox).Checked = True Then
                    hic_SNariz = hic_SNariz & ctlSNariz.Text & ",1|"
                Else
                    hic_SNariz = hic_SNariz & ctlSNariz.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_SNariz, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(28), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "SINT. NARIZ", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlEstornudos As Control In frm_formulario.grp_SinEstornuodos.Controls
            If TypeOf ctlEstornudos Is CheckBox Then
                If DirectCast(ctlEstornudos, CheckBox).Checked = True Then
                    hic_CEstornudos = hic_CEstornudos & ctlEstornudos.Text & ",1|"
                Else
                    hic_CEstornudos = hic_CEstornudos & ctlEstornudos.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_CEstornudos, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(29), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "SINT. ESTORNUDOS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If
        For Each ctlSBoca As Control In frm_formulario.grp_SinBoca.Controls
            If TypeOf ctlSBoca Is CheckBox Then
                If DirectCast(ctlSBoca, CheckBox).Checked = True Then
                    hic_SBoca = hic_SBoca & ctlSBoca.Text & ",1|"
                Else
                    hic_SBoca = hic_SBoca & ctlSBoca.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_SBoca, ",0", "( )"), ",1", "(x)")
        If IsDBNull(arr_datoshc) = True Then
            temp_ant = Replace(Replace(arr_datoshc(30), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "SINT. BOCA", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlPrurito As Control In frm_formulario.grp_Pruirito.Controls
            If TypeOf ctlPrurito Is CheckBox Then
                If DirectCast(ctlPrurito, CheckBox).Checked = True Then
                    hic_Prurito = hic_Prurito & ctlPrurito.Text & ",1|"
                Else
                    hic_Prurito = hic_Prurito & ctlPrurito.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_Prurito, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(31), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "PRURITO", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlTos As Control In frm_formulario.grp_Tos.Controls
            If TypeOf ctlTos Is CheckBox Then
                If DirectCast(ctlTos, CheckBox).Checked = True Then
                    hic_Tos = hic_Tos & ctlTos.Text & ",1|"
                Else
                    hic_Tos = hic_Tos & ctlTos.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_Tos, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(32), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "TOS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If

        End If

        For Each ctlAccAsmaticos As Control In frm_formulario.grp_AccAsmaticos.Controls
            If TypeOf ctlAccAsmaticos Is CheckBox Then
                If DirectCast(ctlAccAsmaticos, CheckBox).Checked = True Then
                    hic_AccAsmaticos = hic_AccAsmaticos & ctlAccAsmaticos.Text & ",1|"
                Else
                    hic_AccAsmaticos = hic_AccAsmaticos & ctlAccAsmaticos.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_AccAsmaticos, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(33), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "ACC. ASMATICOS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlPiel As Control In frm_formulario.grp_SinPiel.Controls
            If TypeOf ctlPiel Is CheckBox Then
                If DirectCast(ctlPiel, CheckBox).Checked = True Then
                    hic_Piel = hic_Piel & ctlPiel.Text & ",1|"
                Else
                    hic_Piel = hic_Piel & ctlPiel.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_Piel, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(34), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "PIEL", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        'PIEL CAMPO OTRO
        Dim hic_PielCampo As String
        If frm_formulario.chk6_Otros.Checked Then
            hic_PielCampo = Trim(frm_formulario.txt_PielOtros.Text)
        End If

        If EsNUevo = False Then
            If arr_datoshc(35) <> hic_PielCampo Then
                GuardaHistoriaCambios(var_hic_cli, "PIEL OTROS", arr_datoshc(35), hic_PielCampo, pac_id, g_sng_user)
            End If
        End If

        For Each ctlDiges As Control In frm_formulario.grp_SinDigestivos.Controls
            If TypeOf ctlDiges Is CheckBox Then
                If DirectCast(ctlDiges, CheckBox).Checked = True Then
                    hic_Digest = hic_Digest & ctlDiges.Text & ",1|"
                Else
                    hic_Digest = hic_Digest & ctlDiges.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_Digest, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(36), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "DIGESTIVOS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        'DIGESTIVOS OTRO
        Dim hic_DigIntCampo As String
        If frm_formulario.chkDig_IntolAlim.Checked Then
            hic_DigIntCampo = Trim(frm_formulario.txt_DigIntolerAlim.Text)
        End If

        If EsNUevo = False Then
            If arr_datoshc(37) <> hic_DigIntCampo Then
                GuardaHistoriaCambios(var_hic_cli, "DIGESTIVOS OTRO", arr_datoshc(37), hic_DigIntCampo, pac_id, g_sng_user)
            End If
        End If

        'ANTECEDENTES
        'Dim str_familiares As String = "MADRE, FAM. MATERNA, PADRE, FAM. PATERNA, HERMANOS, HIJOS"
        'Dim arre_familiares As String() = Split(str_familiares, ",")
        'Dim ii As Integer = 0


        For Each ctlAsma As Control In frm_formulario.grp_Asma.Controls
            If TypeOf ctlAsma Is CheckBox Then
                If DirectCast(ctlAsma, CheckBox).Checked = True Then
                    hic_asma = hic_asma & ctlAsma.Tag & ",1|"
                Else
                    hic_asma = hic_asma & ctlAsma.Tag & ",0|"
                End If
                'ii = ii + 1
            End If
        Next
        temp_nuevo = Replace(Replace(hic_asma, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(38), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "ASMA", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlRin As Control In frm_formulario.grp_Rini.Controls
            If TypeOf ctlRin Is CheckBox Then
                If DirectCast(ctlRin, CheckBox).Checked = True Then
                    hic_rinitis = hic_rinitis & ctlRin.Tag & ",1|"
                Else
                    hic_rinitis = hic_rinitis & ctlRin.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_rinitis, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(39), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "RINITIS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlUrt As Control In frm_formulario.grp_Urt.Controls
            If TypeOf ctlUrt Is CheckBox Then
                If DirectCast(ctlUrt, CheckBox).Checked = True Then
                    hic_urticaria = hic_urticaria & ctlUrt.Tag & ",1|"
                Else
                    hic_urticaria = hic_urticaria & ctlUrt.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_urticaria, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(40), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "URTICARIA", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlEcc As Control In frm_formulario.grp_Eccen.Controls
            If TypeOf ctlEcc Is CheckBox Then
                If DirectCast(ctlEcc, CheckBox).Checked = True Then
                    hic_eccem = hic_eccem & ctlEcc.Tag & ",1|"
                Else
                    hic_eccem = hic_eccem & ctlEcc.Tag & ",0|"
                End If
            End If
        Next

        temp_nuevo = Replace(Replace(hic_eccem, ",0", "( )"), ",1", "(x)")
        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(41), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "ECCEMAS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlConj As Control In frm_formulario.grp_Conj.Controls
            If TypeOf ctlConj Is CheckBox Then
                If DirectCast(ctlConj, CheckBox).Checked = True Then
                    hic_conjun = hic_conjun & ctlConj.Tag & ",1|"
                Else
                    hic_conjun = hic_conjun & ctlConj.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_conjun, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(42), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "CONJUNTIVITIS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlDrog As Control In frm_formulario.grp_Drog.Controls
            If TypeOf ctlDrog Is CheckBox Then
                If DirectCast(ctlDrog, CheckBox).Checked = True Then
                    hic_drogas = hic_drogas & ctlDrog.Tag & ",1|"
                Else
                    hic_drogas = hic_drogas & ctlDrog.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_drogas, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(43), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "DROGAS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlMig As Control In frm_formulario.grp_Migra.Controls
            If TypeOf ctlMig Is CheckBox Then
                If DirectCast(ctlMig, CheckBox).Checked = True Then
                    hic_migra = hic_migra & ctlMig.Tag & ",1|"
                Else
                    hic_migra = hic_migra & ctlMig.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_migra, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(44), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "MIGRAÑA", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlEde As Control In frm_formulario.grp_Edema.Controls
            If TypeOf ctlEde Is CheckBox Then
                If DirectCast(ctlEde, CheckBox).Checked = True Then
                    hic_edema = hic_edema & ctlEde.Tag & ",1|"
                Else
                    hic_edema = hic_edema & ctlEde.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_edema, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(45), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "EDEMA", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        Dim hic_FamOtroCampo = Trim(frm_formulario.txt_AntFamOtro.Text)

        If EsNUevo = False Then
            If arr_datoshc(46) <> hic_FamOtroCampo Then
                GuardaHistoriaCambios(var_hic_cli, "ANT. FAMILIAR OTRO", arr_datoshc(46), hic_FamOtroCampo, pac_id, g_sng_user)
            End If
        End If



        'EXAMEN FISICO INDICE DEL ARREGLO 49

        For Each ctlSigEsp_1 As Control In frm_formulario.grp_SigEsp1.Controls
            If TypeOf ctlSigEsp_1 Is CheckBox Then
                If DirectCast(ctlSigEsp_1, CheckBox).Checked = True Then
                    hic_SigEsp1 = hic_SigEsp1 & ctlSigEsp_1.Tag & ",1|"
                Else
                    hic_SigEsp1 = hic_SigEsp1 & ctlSigEsp_1.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_SigEsp1, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(49), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "SIGNOS ESPECIALES", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlSigEsp_2 As Control In frm_formulario.grp_SigEsp2.Controls
            If TypeOf ctlSigEsp_2 Is CheckBox Then
                If DirectCast(ctlSigEsp_2, CheckBox).Checked = True Then
                    hic_SigEsp2 = hic_SigEsp2 & ctlSigEsp_2.Tag & ",1|"
                Else
                    hic_SigEsp2 = hic_SigEsp2 & ctlSigEsp_2.Tag & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_SigEsp2, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(50), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "SIGNOS ESPECIALES", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If


        For Each ctlResNormal As Control In frm_formulario.grp_ResNormal.Controls
            If TypeOf ctlResNormal Is CheckBox Then
                If DirectCast(ctlResNormal, CheckBox).Checked = True Then
                    hic_ResNormal = hic_ResNormal & ctlResNormal.Text & ",1|"
                Else
                    hic_ResNormal = hic_ResNormal & ctlResNormal.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_ResNormal, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(51), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "TORAX RESP. NORMAL", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If


        For Each ctlResForzada As Control In frm_formulario.grp_ResForzada.Controls
            If TypeOf ctlResForzada Is CheckBox Then
                If DirectCast(ctlResForzada, CheckBox).Checked = True Then
                    hic_ResForzada = hic_ResForzada & ctlResForzada.Text & ",1|"
                Else
                    hic_ResForzada = hic_ResForzada & ctlResForzada.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_ResForzada, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(52), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "TORAX RESP. FORZADA", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If


        For Each ctlNariz As Control In frm_formulario.grp_Nariz.Controls
            If TypeOf ctlNariz Is CheckBox Then
                If DirectCast(ctlNariz, CheckBox).Checked = True Then
                    hic_Nariz = hic_Nariz & ctlNariz.Text & ",1|"
                Else
                    hic_Nariz = hic_Nariz & ctlNariz.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_Nariz, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(53), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "NARIZ", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If


        'NARIZ % INDICE ARREGLO 55
        Dim hic_NarizPorc As String
        If frm_formulario.chk9_Obs.Checked Then
            hic_NarizPorc = Trim(frm_formulario.txt_Obstr.Text)
        End If

        For Each ctlNarizCorn As Control In frm_formulario.grpNarizCorn.Controls
            If TypeOf ctlNarizCorn Is CheckBox Then
                If DirectCast(ctlNarizCorn, CheckBox).Checked = True Then
                    hic_NarizCorn = hic_NarizCorn & ctlNarizCorn.Text & ",1|"
                Else
                    hic_NarizCorn = hic_NarizCorn & ctlNarizCorn.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_NarizCorn, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(55), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "NARIZ CORNETES", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        For Each ctlNarizPolipos As Control In frm_formulario.grpNarizPolipos.Controls
            If TypeOf ctlNarizPolipos Is CheckBox Then
                If DirectCast(ctlNarizPolipos, CheckBox).Checked = True Then
                    hic_NarizPol = hic_NarizPol & ctlNarizPolipos.Text & ",1|"
                Else
                    hic_NarizPol = hic_NarizPol & ctlNarizPolipos.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_NarizPol, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(56), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "NARIZ POLIPOS", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If


        'GARGANTA
        For Each ctlGarganta As Control In frm_formulario.grp_Garganta.Controls
            If TypeOf ctlGarganta Is CheckBox Then
                If DirectCast(ctlGarganta, CheckBox).Checked = True Then
                    hic_Garganta = hic_Garganta & ctlGarganta.Text & ",1|"
                Else
                    hic_Garganta = hic_Garganta & ctlGarganta.Text & ",0|"
                End If
            End If
        Next
        temp_nuevo = Replace(Replace(hic_Garganta, ",0", "( )"), ",1", "(x)")

        If EsNUevo = False Then
            temp_ant = Replace(Replace(arr_datoshc(58), ",0", "( )"), ",1", "(x)")
        End If

        If EsNUevo = False Then
            If temp_nuevo <> temp_ant Then
                GuardaHistoriaCambios(var_hic_cli, "GARGANTA", Replace(temp_ant, "|", ""), Replace(temp_nuevo, "|", ""), pac_id, g_sng_user)
            End If
        End If

        Dim str_lab1 As String
        For j = 0 To frm_formulario.dgv_Lab1.Rows.Count - 1
            str_lab1 = str_lab1 & frm_formulario.dgv_Lab1.Rows(j).Cells(0).Value & "," & frm_formulario.dgv_Lab1.Rows(j).Cells(1).Value & "|"
        Next

        Dim str_lab2 As String
        For j = 0 To frm_formulario.dgv_Lab2.Rows.Count - 1
            str_lab2 = str_lab2 & frm_formulario.dgv_Lab2.Rows(j).Cells(0).Value & "," & frm_formulario.dgv_Lab2.Rows(j).Cells(1).Value & "|"
        Next

        Dim str_lab3 As String
        For j = 0 To frm_formulario.dgv_Lab3.Rows.Count - 1
            str_lab3 = str_lab3 & frm_formulario.dgv_Lab3.Rows(j).Cells(0).Value & "," & frm_formulario.dgv_Lab3.Rows(j).Cells(1).Value & "|"
        Next

        Dim str_lab4 As String
        For j = 0 To frm_formulario.dgv_Lab4.Rows.Count - 1
            str_lab4 = str_lab4 & frm_formulario.dgv_Lab4.Rows(j).Cells(0).Value & "," & frm_formulario.dgv_Lab4.Rows(j).Cells(1).Value & "|"
        Next

        'GUARDO HISTORIA CLINICA

        If ExisteHistoriaClinica(pac_id) > 0 Then
            'str_sql = "update HistoriaClinica set hic_fecha = '" & Format(Now(), "dd/MM/yyyy HH:mm:ss") & "', pac_id = '" & pac_id & "',  hic_Zona = '" & Trim(frm_formulario.cmb_zona.Text) & "', hic_Ocupacion = '" & Trim(frm_formulario.txt_HOcupacion.Text) & "', hic_Hobbies = '" & Trim(frm_formulario.txt_hcHobbies.Text) & "', hic_Inmunizaciones = '" & Trim(frm_formulario.txt_hcInmun.Text) & "', hic_HabitosToxicos = '" & Trim(frm_formulario.cmb_HabTox.Text) & "', hic_HabitosCampo = '" & Trim(frm_formulario.txt_HabiTox_Otro.Text) & "', hic_Tiempo= '" & Trim(frm_formulario.txt_TiemHab.Text) & "', hic_MotivoConsulta = '" & Trim(frm_formulario.txt_hc_MotConsulta.Text) & "', hic_HistEnferActual = '" & Trim(frm_formulario.txt_HisEnfeAct.Text) & "', hic_TTo_Ananmesis = '" & Trim(frm_formulario.txt_HTToAnam.Text) & "', hic_Seguimiento = '" & Trim(frm_formulario.txt_HSeg.Text) & "', hic_PsicoS = '" & Trim(frm_formulario.txt_HPsicoS.Text) & "', hic_EnferEvolInicio = '" & Trim(frm_formulario.txt_hcEvolInicio.Text) & "', hic_App = '" & Trim(frm_formulario.cmb_APP.Text) & "', hic_EnferToroideas = '" & Trim(frm_formulario.cmb_EnfToroideas.Text) & "', hic_Cancer = '" & Trim(frm_formulario.txt_Cancer.Text) & "', hic_EnferInfecc = '" & Trim(frm_formulario.txt_EnferInfecc.Text) & "', hic_Otras = '" & Trim(frm_formulario.txt_OtrasEnfer.Text) & "', hic_TTo_Antec = '" & Trim(frm_formulario.txt_TTo_Antec.Text) & "' , hc_Cirugias = '" & Trim(frm_formulario.txt_Cirugias.Text) & "', hic_Desencadenantes = '" & Trim(hic_Desencadenante) & "', hic_DesencadenantesOtro = '" & Trim(hic_DeseOtro) & "', hic_Menstruacion = '" & Trim(hic_Menstrua) & "', hic_MenstruacionToma = '" & hic_MenstruaToma & "', hic_SinOjos = '" & Trim(hic_Ojos) & "', hic_SinNariz = '" & Trim(hic_SNariz) & "', hic_Estornudos ='" & Trim(hic_CEstornudos) & "', hic_SinBoca = '" & Trim(hic_SBoca) & "', hic_Prurito = '" & Trim(hic_Prurito) & "' , hic_Tos = '" & Trim(hic_Tos) & "', hic_AccAsmaticos = '" & Trim(hic_AccAsmaticos) & "', hic_Piel = '" & Trim(hic_Piel) & "', hic_PielCampo = '" & hic_PielCampo & "' ,hic_Digestivos = '" & Trim(hic_Digest) & "', hic_DigestivosCampo = '" & hic_DigIntCampo & "', hic_RAM = '" & Trim(frm_formulario.txt_Ram.Text) & "', hic_AntecFamAsma = '" & Trim(hic_asma) & "', hic_AntecFamRiñitis = '" & Trim(hic_rinitis) & "', hic_AntecFamUrticaria = '" & Trim(hic_urticaria) & "', hic_AntecFamEccem = '" & Trim(hic_eccem) & "', hic_AntecFamConjunt = '" & Trim(hic_conjun) & "', hic_AntecFamDrogas = '" & Trim(hic_drogas) & "', hic_AntecFamMigra = '" & Trim(hic_migra) & "', hic_AntecFamEdema = '" & Trim(hic_edema) & "', hic_AntecFamOtro = '" & Trim(hic_Otro) & "', hic_AntecFamOtroCampo = '" & hic_FamOtroCampo & "', hic_SignosEsp1 = '" & Trim(hic_SigEsp1) & "', hic_SignosEsp2 = '" & Trim(hic_SigEsp2) & "',  hic_TotaxResNormal = '" & Trim(hic_ResNormal) & "', hic_ToraxResForzada = '" & Trim(hic_ResForzada) & "', hic_Nariz = '" & Trim(hic_Nariz) & "', hic_NarizPorcentaje = '" & hic_NarizPorc & "', hic_NarizHiperCorn = '" & Trim(hic_NarizCorn) & "', hic_NarizPolipos = '" & Trim(hic_NarizPol) & "', hic_NarizMucosa = '" & Trim(frm_formulario.txt_NarizMucosa.Text) & "', hic_Garganta = '" & Trim(hic_Garganta) & "', hic_CampoPiel = '" & Trim(frm_formulario.txt_CampoPiel.Text) & "', hic_DatosLabImagen = '" & Trim(frm_formulario.txt_LabImagen.Text) & "', hic_DatosLabBiopsia = '" & Trim(frm_formulario.txt_LabBiopsia.Text) & "', hic_DatosLab1 = '" & Trim(str_lab1) & "', hic_DatosLab2 = '" & Trim(str_lab2) & "',hic_DatosLab3 = '" & Trim(str_lab3) & "',hic_DatosLab4 = '" & Trim(str_lab4) & "', hic_DatosLabOtros = '" & Trim(frm_formulario.txt_LabOtros.Text) & "' WHERE pac_id = " & pac_id & ""
            str_sql = "update HistoriaClinica set pac_id = '" & pac_id & "',  hic_Zona = '" & Trim(frm_formulario.cmb_zona.Text) & "', hic_Ocupacion = '" & Trim(frm_formulario.txt_HOcupacion.Text) & "', hic_Hobbies = '" & Trim(frm_formulario.txt_hcHobbies.Text) & "', hic_Inmunizaciones = '" & Trim(frm_formulario.txt_hcInmun.Text) & "', hic_HabitosToxicos = '" & Trim(frm_formulario.cmb_HabTox.Text) & "', hic_HabitosCampo = '" & Trim(frm_formulario.txt_HabiTox_Otro.Text) & "', hic_Tiempo= '" & Trim(frm_formulario.txt_TiemHab.Text) & "', hic_MotivoConsulta = '" & Trim(frm_formulario.txt_hc_MotConsulta.Text) & "', hic_HistEnferActual = '" & Trim(frm_formulario.txt_HisEnfeAct.Text) & "', hic_TTo_Ananmesis = '" & Trim(frm_formulario.txt_HTToAnam.Text) & "', hic_Seguimiento = '" & Trim(frm_formulario.txt_HSeg.Text) & "', hic_PsicoS = '" & Trim(frm_formulario.txt_HPsicoS.Text) & "', hic_EnferEvolInicio = '" & Trim(frm_formulario.txt_hcEvolInicio.Text) & "', hic_App = '" & Trim(frm_formulario.cmb_APP.Text) & "', hic_EnferToroideas = '" & Trim(frm_formulario.cmb_EnfToroideas.Text) & "', hic_Cancer = '" & Trim(frm_formulario.txt_Cancer.Text) & "', hic_EnferInfecc = '" & Trim(frm_formulario.txt_EnferInfecc.Text) & "', hic_Otras = '" & Trim(frm_formulario.txt_OtrasEnfer.Text) & "', hic_TTo_Antec = '" & Trim(frm_formulario.txt_TTo_Antec.Text) & "' , hc_Cirugias = '" & Trim(frm_formulario.txt_Cirugias.Text) & "', hic_Desencadenantes = '" & Trim(hic_Desencadenante) & "', hic_DesencadenantesOtro = '" & Trim(hic_DeseOtro) & "', hic_Menstruacion = '" & Trim(hic_Menstrua) & "', hic_MenstruacionToma = '" & hic_MenstruaToma & "', hic_SinOjos = '" & Trim(hic_Ojos) & "', hic_SinNariz = '" & Trim(hic_SNariz) & "', hic_Estornudos ='" & Trim(hic_CEstornudos) & "', hic_SinBoca = '" & Trim(hic_SBoca) & "', hic_Prurito = '" & Trim(hic_Prurito) & "' , hic_Tos = '" & Trim(hic_Tos) & "', hic_AccAsmaticos = '" & Trim(hic_AccAsmaticos) & "', hic_Piel = '" & Trim(hic_Piel) & "', hic_PielCampo = '" & hic_PielCampo & "' ,hic_Digestivos = '" & Trim(hic_Digest) & "', hic_DigestivosCampo = '" & hic_DigIntCampo & "', hic_RAM = '" & Trim(frm_formulario.txt_Ram.Text) & "', hic_AntecFamAsma = '" & Trim(hic_asma) & "', hic_AntecFamRiñitis = '" & Trim(hic_rinitis) & "', hic_AntecFamUrticaria = '" & Trim(hic_urticaria) & "', hic_AntecFamEccem = '" & Trim(hic_eccem) & "', hic_AntecFamConjunt = '" & Trim(hic_conjun) & "', hic_AntecFamDrogas = '" & Trim(hic_drogas) & "', hic_AntecFamMigra = '" & Trim(hic_migra) & "', hic_AntecFamEdema = '" & Trim(hic_edema) & "', hic_AntecFamOtro = '" & Trim(hic_Otro) & "', hic_AntecFamOtroCampo = '" & hic_FamOtroCampo & "', hic_SignosEsp1 = '" & Trim(hic_SigEsp1) & "', hic_SignosEsp2 = '" & Trim(hic_SigEsp2) & "',  hic_TotaxResNormal = '" & Trim(hic_ResNormal) & "', hic_ToraxResForzada = '" & Trim(hic_ResForzada) & "', hic_Nariz = '" & Trim(hic_Nariz) & "', hic_NarizPorcentaje = '" & hic_NarizPorc & "', hic_NarizHiperCorn = '" & Trim(hic_NarizCorn) & "', hic_NarizPolipos = '" & Trim(hic_NarizPol) & "', hic_NarizMucosa = '" & Trim(frm_formulario.txt_NarizMucosa.Text) & "', hic_Garganta = '" & Trim(hic_Garganta) & "', hic_CampoPiel = '" & Trim(frm_formulario.txt_CampoPiel.Text) & "', hic_DatosLabImagen = '" & Trim(frm_formulario.txt_LabImagen.Text) & "', hic_DatosLabBiopsia = '" & Trim(frm_formulario.txt_LabBiopsia.Text) & "', hic_DatosLab1 = '" & Trim(str_lab1) & "', hic_DatosLab2 = '" & Trim(str_lab2) & "',hic_DatosLab3 = '" & Trim(str_lab3) & "',hic_DatosLab4 = '" & Trim(str_lab4) & "', hic_DatosLabOtros = '" & Trim(frm_formulario.txt_LabOtros.Text) & "' WHERE pac_id = " & pac_id & ""

        Else
            hic_id = LeerMaxIdHistoria()
            str_sql = "insert into HistoriaClinica values(" & hic_id & ", getdate(), " & pac_id & " , '" & Trim(frm_formulario.cmb_zona.Text) & "', '" & Trim(frm_formulario.txt_HOcupacion.Text) & "','" & Trim(frm_formulario.txt_hcHobbies.Text) & "', '" & Trim(frm_formulario.txt_hcInmun.Text) & "', '" & Trim(frm_formulario.cmb_HabTox.Text) & "', '" & Trim(frm_formulario.txt_HabiTox_Otro.Text) & "', '" & Trim(frm_formulario.txt_TiemHab.Text) & "', '" & Trim(frm_formulario.txt_hc_MotConsulta.Text) & "', '" & Trim(frm_formulario.txt_HisEnfeAct.Text) & "', '" & Trim(frm_formulario.txt_HTToAnam.Text) & "', '" & Trim(frm_formulario.txt_HSeg.Text) & "', '" & Trim(frm_formulario.txt_HPsicoS.Text) & "', '" & Trim(frm_formulario.txt_hcEvolInicio.Text) & "','" & Trim(frm_formulario.cmb_APP.Text) & "','" & Trim(frm_formulario.cmb_EnfToroideas.Text) & "','" & Trim(frm_formulario.txt_Cancer.Text) & "','" & Trim(frm_formulario.txt_EnferInfecc.Text) & "','" & Trim(frm_formulario.txt_OtrasEnfer.Text) & "', '" & Trim(frm_formulario.txt_TTo_Antec.Text) & "', '" & Trim(frm_formulario.txt_Cirugias.Text) & "', '" & Trim(hic_Desencadenante) & "', '" & Trim(hic_DeseOtro) & "', '" & Trim(hic_Menstrua) & "', '" & Trim(hic_MenstruaToma) & "' ,'" & Trim(hic_Ojos) & "', '" & Trim(hic_SNariz) & "', '" & Trim(hic_CEstornudos) & "', '" & Trim(hic_SBoca) & "', '" & Trim(hic_Prurito) & "', '" & Trim(hic_Tos) & "', '" & Trim(hic_AccAsmaticos) & "', '" & Trim(hic_Piel) & "', '" & Trim(hic_PielCampo) & "' , '" & Trim(hic_Digest) & "', '" & Trim(hic_DigIntCampo) & "', '" & Trim(frm_formulario.txt_Ram.Text) & "','" & Trim(hic_asma) & "','" & Trim(hic_rinitis) & "','" & Trim(hic_urticaria) & "','" & Trim(hic_eccem) & "','" & Trim(hic_conjun) & "','" & Trim(hic_drogas) & "','" & Trim(hic_migra) & "', '" & Trim(hic_edema) & "','" & Trim(hic_Otro) & "', '" & hic_FamOtroCampo & "','" & Trim(hic_SigEsp1) & "', '" & Trim(hic_SigEsp2) & "', '" & Trim(hic_ResNormal) & "', '" & Trim(hic_ResForzada) & "', '" & Trim(hic_Nariz) & "', '" & Trim(hic_NarizPorc) & "', '" & Trim(hic_NarizCorn) & "', '" & Trim(hic_NarizPol) & "', '" & Trim(frm_formulario.txt_NarizMucosa.Text) & "' ,'" & Trim(hic_Garganta) & "', '" & Trim(frm_formulario.txt_CampoPiel.Text) & "', '" & Trim(frm_formulario.txt_LabImagen.Text) & "', '" & Trim(frm_formulario.txt_LabBiopsia.Text) & "', '" & Trim(str_lab1) & "','" & Trim(str_lab2) & "','" & Trim(str_lab3) & "','" & Trim(str_lab4) & "', '" & Trim(frm_formulario.txt_LabOtros.Text) & "','','','')"

        End If



        If sig_id > 0 Then
            opr_conexion.sql_conectar()
            odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

            odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()

            odbc_trans.Commit()
            opr_conexion.sql_desconn()
        End If


        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function


    

    Public Function GuardaSignos(ByVal frm_formulario As frm_SignosVitales, ByVal pac_id As Long)
        Dim str_sql As String = Nothing
        Dim sig_id As Integer
        Dim hic_id As Integer
        Dim efi_id As Integer
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand

        'GUARDO SIGNOS VITALES
        sig_id = LeerMaxIdSignos()
        str_sql = "insert into SignosVitales values(" & _
              sig_id & "," & pac_id & ",'" & g_invitado & "', getdate(),'" & _
              Trim(frm_formulario.txt_hc_TenArterial.Text) & "','" & Trim(frm_formulario.txt_hc_FreCardiaca.Text) & "','" & Trim(frm_formulario.txt_hc_FrecResp.Text) & "','" & Trim(frm_formulario.txt_hc_Temperatura.Text) & "','" & Trim(frm_formulario.txt_hc_Saturacion.Text) & "','" & Trim(frm_formulario.txt_hc_Peso.Text) & "','" & Trim(frm_formulario.txt_hc_Audiometria.Text) & "')"

        If sig_id > 0 Then
            opr_conexion.sql_conectar()
            odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

            odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            odbc_trans.Commit()
            opr_conexion.sql_desconn()
        End If

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function

    Public Function TieneFactoresRiesgo(ByVal pac_id As Integer) As Integer
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "select count(pac_id) from FACTORESRIESGO where pac_id = " & pac_id & ""

        opr_conexion.sql_conectar()
        TieneFactoresRiesgo = 0
        TieneFactoresRiesgo = CStr(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        VisualizaMensaje("No se pudo realizar la operacion solicitada, consulta FACTORS DE RIESGO", g_tiempo)
        Err.Clear()

    End Function

    Public Function GuardaFaciesgo(ByVal frm_formulario As frm_SignosVitales, ByVal pac_id As Long)
        Dim str_sql As String = Nothing
        Dim FR_ID As Integer
        Dim hic_id As Integer
        Dim efi_id As Integer
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand

        If TieneFactoresRiesgo(pac_id) > 0 Then
            str_sql = "update factoresRiesgo set FR_FECHA = getdate(), FR_CIGARRO = '" & frm_formulario.lst_Cigarro.SelectedItem & "', FR_ALCOHOL = '" & frm_formulario.lst_Alcohol.SelectedItem & "', FR_SEDENTARISMO = '" & frm_formulario.lst_Sedent.SelectedItem & "', FR_DROGAS = '" & frm_formulario.lst_Drogas.SelectedItem & "' WHERE PAC_ID = " & pac_id & ""
        Else
            str_sql = "insert into factoresRiesgo values(getdate(), " & pac_id & ", '" & frm_formulario.lst_Cigarro.SelectedItem & "', '" & frm_formulario.lst_Alcohol.SelectedItem & "', '" & frm_formulario.lst_Sedent.SelectedItem & "', '" & frm_formulario.lst_Drogas.SelectedItem & "', '" & g_invitado & "')"
        End If

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function

    Public Function GuardaActividad(ByVal frm_formulario As frm_Actividad)
        Dim str_sql As String = Nothing
        Dim act_id As Integer

        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim fec_Fin As Date

        ' 1 diario
        ' 2 semanal
        ' 3 mensual
        ' 4 anual

        Select Case Trim(frm_formulario.cmb_Recursividad.Text)
            Case "Diario"
                fec_Fin = frm_formulario.dtp_IniciaActividad.SelectionRange.Start
            Case "Semanal"
                str_sql = "SELECT DATEDIFF(DAY,aact_fechaIni,aact_fechaFin) from agendaActividad where aact_id = 2"

                fec_Fin = DateAdd(DateInterval.Day, 7, frm_formulario.dtp_IniciaActividad.SelectionRange.Start)

            Case "Mensual"
                fec_Fin = DateAdd(DateInterval.Month, 1, frm_formulario.dtp_IniciaActividad.SelectionRange.Start)

            Case "Anual"
                fec_Fin = DateAdd(DateInterval.Year, 1, frm_formulario.dtp_IniciaActividad.SelectionRange.Start)
        End Select

        'GUARDO ACTIVIDAD
        act_id = LeerMaxIdActividad()
        str_sql = "insert into agendaActividad values(" & _
              act_id & ",'" & Trim(Mid(frm_formulario.cmb_Actividad.Text, 1, 100)) & "','" & Trim(Mid(frm_formulario.cmb_Recursividad.Text, 1, 100)) & "','" & Format(frm_formulario.dtp_IniciaActividad.SelectionRange.Start, "dd/MM/yyyy") & "' ,'" & fec_Fin & "','" & Trim(frm_formulario.cmb_Hora.Text) & "','" & frm_formulario.med_id & "')"

        If act_id > 0 Then
            opr_conexion.sql_conectar()
            odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

            odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            odbc_trans.Commit()
            opr_conexion.sql_desconn()
        End If

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function

    Public Function EliminaTTo(ByVal AGE_ID As Integer, ByVal PAC_ID As Integer, ByVal I_PRD_ID As String, ByVal TTO_CANTIDAD As Integer)
        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        str_sql = "delete from vacunaTratamiento where AGE_ID = " & AGE_ID & " and PAC_ID = " & PAC_ID & " AND I_PRD_ID = '" & I_PRD_ID & "' AND TTO_CANTIDAD = " & TTO_CANTIDAD & ""

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        VisualizaMensaje("Registro eliminado satisfactoriamente", 300)
    End Function



    Public Function EliminaElementoGrupo(ByVal GMED_ID As Integer, ByVal MED_ID As Integer)
        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        str_sql = "delete from GrupoMedicoElementos where GMED_ID = " & GMED_ID & " and MED_ID = " & MED_ID & ""

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function


    Public Function EliminaGrupoMedico(ByVal GMED_ID As Integer)
        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        str_sql = "update GrupoMedico set GMED_ESTADO = 0 where GMED_ID = " & GMED_ID & ""

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function



    Public Function GuardaGrupoMedico(ByVal GMED_ID As Integer, ByVal GMED_NOMBRE As String, ByVal GMED_OBS As String)
        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        str_sql = "insert into GrupoMedico values(" & GMED_ID & ",'" & GMED_NOMBRE & "', '" & GMED_OBS & "', '" & Format(Now(), "dd/MM/yyyy") & "', 1)"

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function


    Public Function GuardaElementoMedico(ByVal GMED_ID As Integer, ByVal Med_id As Integer)
        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        str_sql = "insert into GrupoMedicoElementos values(" & GMED_ID & "," & Med_id & ")"

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function

    Public Function ActualizaHistoria(ByVal frm_formulario As frm_HistoriaClinica, ByVal pac_id As Long)
        Dim str_sql As String = Nothing
        Dim sig_id As Integer
        Dim hic_id As Integer
        Dim efi_id As Integer
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand



        'GUARDO HISTORIA CLINICA
        hic_id = LeerMaxIdSignos()
        'str_sql = "insert into HistoriaClinica values(" & hic_id & ", getdate(),'" & Trim(Mid(frm_formulario.cmb_ocupacion.Text, 101, 5)) & "','" & Trim(frm_formulario.txt_hc_AntPatPersonales.Text) & "','" & Trim(frm_formulario.txt_hc_AntPatFamiliares.Text) & "','" & Trim(frm_formulario.txt_hc_MedHabitual.Text) & "','" & Trim(frm_formulario.txt_hc_Alergias.Text) & "','" & Trim(frm_formulario.txt_hc_Tabaco.Text) & "','" & Trim(frm_formulario.txt_hc_Drogas.Text) & "','" & Trim(frm_formulario.txt_hc_Alcohol.Text) & "','" & Trim(frm_formulario.txt_hc_MotConsulta.Text) & "','" & Trim(frm_formulario.txt_hc_EnferActual.Text) & "')"

        If sig_id > 0 Then
            opr_conexion.sql_conectar()
            odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

            odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            odbc_trans.Commit()
            opr_conexion.sql_desconn()
        End If


        ''GUARDO EXAMEN FISICO
        'efi_id = LeerMaxIdExamenFisico()
        'str_sql = "insert into ExamenFisico values(" & efi_id & ", getdate(),'" & pac_id & "','" & Trim(frm_formulario.txt_hc_Cabeza.Text) & "','" & Trim(frm_formulario.txt_hc_Oidos.Text) & "','" & Trim(frm_formulario.txt_hc_Nariz.Text) & "','" & Trim(frm_formulario.txt_hc_Orofaringe.Text) & "','" & Trim(frm_formulario.txt_hc_Cuello.Text) & "','" & Trim(frm_formulario.txt_hc_Torax.Text) & "','" & Trim(frm_formulario.txt_hc_Pulmones.Text) & "','" & Trim(frm_formulario.txt_hc_Corazon.Text) & "','" & Trim(frm_formulario.txt_hc_Abdomen.Text) & "','" & Trim(frm_formulario.txt_hc_Extremidades.Text) & "')"

        'If sig_id > 0 Then
        '    opr_conexion.sql_conectar()
        '    odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        '    odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        '    odbc_strsql.ExecuteNonQuery()
        '    odbc_trans.Commit()
        '    opr_conexion.sql_desconn()
        'End If

        VisualizaMensaje("Datos almacenados correctamente", 300)
    End Function


    

    Public Function GuardarPedido(ByVal frm_formulario As frm_Pedido, ByVal pac_id As Long, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal proforma As Integer, ByVal varMed As Integer) As Byte

        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim dtr_fila As DataRow
        Dim turno As String = Nothing
        Dim lng_ped_id As Long
        Dim i As Integer
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        Dim edad As Integer = 0
        Dim genero As String = Nothing
        Dim OrdenExiste As String = ""
        Dim unidad As String = Nothing
        Dim int_paciente As Integer = 0

        'obtiene le codigo maximo de los pedidos 
        'lng_ped_id = LeerMaxPedido() + 1
        lng_ped_id = ped_id
        g_lng_ped_id = ped_id

        edad = CalculaEdad(frm_formulario.lbl_fecnac.Text, unidad)
        genero = Trim(frm_formulario.lbl_genero.Text)

        int_paciente = consultapacientePEDIDO(g_lng_ped_id)
        If int_paciente = -1 Then
            int_paciente = pac_id
        End If
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)



        ' genero y valido las secuencias
        Dim sec_nombre As String = Nothing
        Dim sec_inicio, sec_fin As Integer

        'combo.Items.Add(dtr_fila("sec_nombre").ToString().PadRight(50) & dtr_fila("sec_desde").ToString().PadRight(5) & dtr_fila("sec_hasta").ToString().PadRight(5))
        secuencia = Split(frm_formulario.cmb_convenio.Text, "/")

        'For i = 0 To UBound(secuencia) - 1
        sec_nombre = Trim(secuencia(0).ToString)
        sec_inicio = CInt(secuencia(1).ToString)
        sec_fin = CInt(secuencia(2).ToString)



        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL, STR_SQL1 As String

        turno = Format(LeerMaxturno(sec_nombre, Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy"), Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)), True), "00#")


        If turno <> Nothing Then
            If turno > sec_fin Then
                VisualizaMensaje("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", g_tiempo)
                ''MsgBox("Ud. ha excedido el numero permitido de pedidos para " & sec_nombre & ".  Pongase en contacto con el Administrador del sistema.", MsgBoxStyle.Information, "ANALISYS")
                Exit Function
            Else
                If turno < sec_inicio Then
                    turno = sec_inicio
                End If
                If System.Configuration.ConfigurationSettings.AppSettings("AUTOMATICO") = "False" Then
                    STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id, med_id, lab_id, ped_nota, ped_turno, ped_servicio, PED_RECIBO, PED_PROF, PED_NUMAUX, PED_OBS) values(" & _
                    lng_ped_id & ",'" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "','" & frm_formulario.txt_recibo.Text & "','" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "','" & _
                    sec_nombre & "','" & sec_nombre & "'," & pac_id & "," & Val(varMed) & ",'" & Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)) & "', '" & Trim(frm_formulario.cmb_PrePost.Text) & "'" & _
                    ", " & turno & ", '" & frm_formulario.cmb_servicios.Text & "', '" & g_invitado & "', " & proforma & "," & CInt(frm_formulario.txt_NumAux.Text) & " , '" & Trim(frm_formulario.Ctl_txt_ped_antecedente.Text) & "')"
                Else
                    Dim fecha_toma_muestra As Date
                    Dim minutos As Integer = System.Configuration.ConfigurationSettings.AppSettings("TOMAMUESTRA")

                    fecha_toma_muestra = DateAdd(DateInterval.Minute, minutos, frm_formulario.Dtp_ped_fecing.Value)
                    STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id, med_id, ped_nota, lab_id, ped_turno, ped_servicio, PED_RECIBO, PED_PROF, PED_NUMAUX, PED_OBS) values(" & _
                    lng_ped_id & ",'" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "','" & frm_formulario.txt_recibo.Text & "','" & fecha_toma_muestra & "','" & _
                    sec_nombre & "','" & sec_nombre & "'," & pac_id & "," & Val(varMed) & ",'" & Trim(frm_formulario.cmb_PrePost.Text) & "', " & Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)) & _
                    ", " & turno & ", '" & frm_formulario.cmb_servicios.Text & "', '" & g_invitado & "', " & proforma & "," & CInt(frm_formulario.txt_NumAux.Text) & ", '" & Trim(frm_formulario.Ctl_txt_ped_antecedente.Text) & "')"
                End If

            End If
        Else
            turno = sec_inicio

        End If

        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        'actualizo  paciente y observacion (ENFERMEDAD):
        Dim ape_nom As String()
        Dim ape As String = Nothing
        Dim nom As String = Nothing
        
        ape_nom = Split(Trim(frm_formulario.lbl_nombres.Text), " ")

        Select Case UBound(ape_nom) + 1
            Case 2
                ape = ape_nom(0)
                nom = ape_nom(1)

            Case 3
                ape = ape_nom(0) & " " & ape_nom(1)
                nom = ape_nom(2)

            Case 4
                ape = ape_nom(0) & " " & ape_nom(1)
                nom = ape_nom(2) & " " & ape_nom(3)

            Case 5
                ape = ape_nom(0) & " " & ape_nom(1)
                nom = ape_nom(2) & " " & ape_nom(3) & " " & ape_nom(4)
        End Select

        STR_SQL = "update paciente set pac_apellido = '" & ape & "', pac_nombre = '" & nom & "', pac_direccion = '" & Trim(frm_formulario.lbl_direccion_fono.Text) & "', pac_fono = '" & Trim(frm_formulario.lbl_fono.Text) & "',  pac_sexo = '" & Trim(frm_formulario.lbl_genero.Text) & "', pac_obs = '" & Trim(frm_formulario.txt_obs_pac.Text) & "', pac_grado = '" & Trim(frm_formulario.cmb_afiliacion.Text) & "' where pac_id = " & int_paciente & ";"
        odbc_strsql.CommandText = STR_SQL
        odbc_strsql.ExecuteNonQuery()


        
        For i = 0 To frm_formulario.dtt_pedido.Rows.Count - 1
            'ejecuta esta parte si es un test
            If Trim(frm_formulario.dtt_pedido.Rows(i).Item(5)) = "T" Then
                odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & _
                lng_ped_id & "," & i + 1 & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(1)) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, tes_id, pdd_estado,lip_precio) values(" & _
                lng_ped_id & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ",1," & CLng(Trim(frm_formulario.dtt_pedido.Rows(i).Item(4))) * CLng(Trim(frm_formulario.dtt_pedido.Rows(i).Item(1))) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                odbc_strsql1.ExecuteNonQuery()
                'Funcion que graba los test en la lista de trabajo automaticamente
                opr_trabajo.InsertLista_trabajo(lng_ped_id, Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)), Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy HH:mm:ss"), genero, edad, unidad, "")

            Else
                'caso contrario es un perfil                
                odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, per_id) values(" & _
                lng_ped_id & "," & i + 1 & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(1)) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                Dim opr_perfil As New Cls_Perfil()
                Dim dts_operacion As DataSet
                dts_operacion = opr_perfil.LeerPerfil_test(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)))
                For Each dtr_fila In dts_operacion.Tables("Registros").Rows
                    odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, per_id, tes_id,lip_precio) values(" & _
                   lng_ped_id & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & "," & dtr_fila(1) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & _
                   ")", opr_conexion.conn_sql, odbc_trans)
                    odbc_strsql1.ExecuteNonQuery()
                Next
            End If

            odbc_strsql.ExecuteNonQuery()
        Next

        opr_trabajo.InsertPtoPdf(lng_ped_id, "LABORATORIO", 0)
        opr_trabajo.InsertPtoImg(lng_ped_id, "QR")

        'si no hubo errores commit
        odbc_trans.Commit()
        opr_conexion.sql_desconn()


        

        GuardarPedido = 1


        If System.Configuration.ConfigurationSettings.AppSettings("INTERFACE") = True Then
            ''Dim opr_Interfaz As New Cls_Interfases()
            ''Dim arre_cabe As String()
            ''Dim arre_test As String()
            ''Dim texto As String = Nothing
            ''Dim cabecera, examenes As String
            ''Dim ii As Integer = 0
            ''Dim fecha As String = Nothing
            ''Dim fechaNac As String = Nothing

            ''fecha = Format(Now, "yyyyMMddhhssmm")

            ''arre_cabe = Split(LeeOrdenQuimicaCabecera(lng_ped_id), ",")

            ''If UBound(arre_cabe) >= 1 Then



            ''    fechaNac = Format(CDate(arre_cabe(2)), "yyyyMMdd")

            ''    arre_test = Split(LeeOrdenQuimicaExamenes(lng_ped_id), ",")
            ''    For ii = 0 To UBound(arre_test) - 1
            ''        examenes = examenes & "O|" & ii + 1 & "|||" & arre_test(ii) & "|False||||||||||Serum|||||||||||||||" & Chr(13) & Chr(10)
            ''    Next

            ''    texto = "H|\^&|||||||||||ANALISYS|" & fecha & Chr(13) & Chr(10) & _
            ''            "P|1||" & arre_cabe(0) & "||" & arre_cabe(1) & "||" & fechaNac & "|CANE|||||||||||||||||||||||||" & Chr(13) & Chr(10)

            ''    texto = texto & "C|1|||" & Chr(13) & Chr(10) & examenes & "L||N"

            ''    If opr_Interfaz.GeneraOrdenTxt(texto, arre_cabe(0)) = True Then
            ''        frm_formulario.lbl_InterfaceNombre.Text = arre_cabe(0) & " ok"
            ''    End If
            ''End If
        End If
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarPedido = 0
        VisualizaMensaje("No se pudo realizar la operacion solicitada, Guardar Pedido", g_tiempo)
        ''g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function


    ' ''    Public Function GuardarPedidoAgenda(ByVal frm_formulario As frm_HistoriaClinica, ByVal pac_id As Long, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal proforma As Integer, ByVal varMed As Integer) As Byte

    ' ''        'funcion que permite guardar un pedido nuevo
    ' ''        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
    ' ''        On Error GoTo MsgError
    ' ''        Dim opr_conexion As New Cls_Conexion()
    ' ''        Dim odbc_trans As SqlTransaction
    ' ''        Dim odbc_strsql As SqlCommand
    ' ''        Dim odbc_strsql1 As SqlCommand
    ' ''        Dim dtr_fila As DataRow
    ' ''        Dim turno As String = Nothing
    ' ''        Dim lng_ped_id As Long
    ' ''        Dim i As Integer
    ' ''        Dim opr_trabajo As New Cls_Trabajo()
    ' ''        Dim opr_pedido As New Cls_Pedido()
    ' ''        Dim edad As Integer = 0
    ' ''        Dim genero As String = Nothing
    ' ''        Dim OrdenExiste As String = ""
    ' ''        Dim unidad As String = Nothing
    ' ''        Dim int_paciente As Integer = 0

    ' ''        'obtiene le codigo maximo de los pedidos 
    ' ''        'lng_ped_id = LeerMaxPedido() + 1
    ' ''        lng_ped_id = ped_id
    ' ''        g_lng_ped_id = ped_id

    ' ''        'edad = CalculaEdad(frm_formulario.lbl_fecnac.Text, unidad)
    ' ''        'genero = Trim(frm_formulario.lbl_genero.Text)

    ' ''        int_paciente = consultapacientePEDIDO(g_lng_ped_id)
    ' ''        If int_paciente = -1 Then
    ' ''            int_paciente = pac_id
    ' ''        End If
    ' ''        opr_conexion.sql_conectar()
    ' ''        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)



    ' ''        ' genero y valido las secuencias
    ' ''        Dim sec_nombre As String = Nothing
    ' ''        Dim sec_inicio, sec_fin As Integer

    ' ''        'combo.Items.Add(dtr_fila("sec_nombre").ToString().PadRight(50) & dtr_fila("sec_desde").ToString().PadRight(5) & dtr_fila("sec_hasta").ToString().PadRight(5))




    ' ''        'utilizo transacciones para la cabecera detalle
    ' ''        Dim STR_SQL, STR_SQL1 As String

    ' ''        turno = Format(LeerMaxturno(sec_nombre, Format(frm_formulario.var_Fecha, "dd/MM/yyyy"), Val(frm_formulario.var_Lab.Substring(100, 10)), True), "00#")


    ' ''        If turno <> Nothing Then
    ' ''            If turno > sec_fin Then
    ' ''                VisualizaMensaje("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", g_tiempo)
    ' ''                ''MsgBox("Ud. ha excedido el numero permitido de pedidos para " & sec_nombre & ".  Pongase en contacto con el Administrador del sistema.", MsgBoxStyle.Information, "ANALISYS")
    ' ''                Exit Function
    ' ''            Else
    ' ''                If turno < sec_inicio Then
    ' ''                    turno = sec_inicio
    ' ''                End If
    ' ''                If System.Configuration.ConfigurationSettings.AppSettings("AUTOMATICO") = "False" Then
    ' ''                    STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id, med_id, lab_id, ped_nota, ped_turno, ped_servicio, PED_RECIBO, PED_PROF, PED_NUMAUX, PED_OBS) values(" & _
    ' ''                    lng_ped_id & ",'" & Format(frm_formulario.var_Fecha, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "',"",'" & Format(frm_formulario.var_Fecha, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "','" & _
    ' ''                    sec_nombre & "','" & sec_nombre & "'," & pac_id & "," & Val(varMed) & ",'" & Val(frm_formulario.var_Lab.Substring(100, 10)) & "', '" & frm_formulario.var_PrePost & "'" & _
    ' ''                    ", " & turno & ", '" & frm_formulario.var_Servicio & "', '" & g_invitado & "', " & proforma & "," & CInt(frm_formulario.Var_NumAux) & " , "")"
    ' ''                Else
    ' ''                    Dim fecha_toma_muestra As Date
    ' ''                    Dim minutos As Integer = System.Configuration.ConfigurationSettings.AppSettings("TOMAMUESTRA")

    ' ''                    fecha_toma_muestra = DateAdd(DateInterval.Minute, minutos, frm_formulario.var_Fecha)
    ' ''                    STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id, med_id, ped_nota, lab_id, ped_turno, ped_servicio, PED_RECIBO, PED_PROF, PED_NUMAUX, PED_OBS) values(" & _
    ' ''                    lng_ped_id & ",'" & Format(frm_formulario.var_Fecha, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "',"",'" & fecha_toma_muestra & "','" & _
    ' ''                    sec_nombre & "','" & sec_nombre & "'," & pac_id & "," & Val(varMed) & ",'" & Trim(frm_formulario.var_PrePost) & "', " & Val(frm_formulario.var_Lab.Substring(100, 10)) & _
    ' ''                    ", " & turno & ", '" & frm_formulario.var_Servicio & "', '" & g_invitado & "', " & proforma & "," & CInt(frm_formulario.Var_NumAux) & ", "")"
    ' ''                End If

    ' ''            End If
    ' ''        Else
    ' ''            turno = sec_inicio

    ' ''        End If

    ' ''        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
    ' ''        odbc_strsql.ExecuteNonQuery()


    ' ''        ' ''actualizo  paciente y observacion (ENFERMEDAD):
    ' ''        ''Dim ape_nom As String()
    ' ''        ''Dim ape As String = Nothing
    ' ''        ''Dim nom As String = Nothing

    ' ''        ''ape_nom = Split(Trim(frm_formulario.lbl_paciente.Text), " ")

    ' ''        ''Select Case UBound(ape_nom) + 1
    ' ''        ''    Case 2
    ' ''        ''        ape = ape_nom(0)
    ' ''        ''        nom = ape_nom(1)

    ' ''        ''    Case 3
    ' ''        ''        ape = ape_nom(0) & " " & ape_nom(1)
    ' ''        ''        nom = ape_nom(2)

    ' ''        ''    Case 4
    ' ''        ''        ape = ape_nom(0) & " " & ape_nom(1)
    ' ''        ''        nom = ape_nom(2) & " " & ape_nom(3)

    ' ''        ''    Case 5
    ' ''        ''        ape = ape_nom(0) & " " & ape_nom(1)
    ' ''        ''        nom = ape_nom(2) & " " & ape_nom(3) & " " & ape_nom(4)
    ' ''        ''End Select

    ' ''        ''STR_SQL = "update paciente set pac_apellido = '" & ape & "', pac_nombre = '" & nom & "', pac_direccion = '" & Trim(frm_formulario.lbl_direccion_fono.Text) & "', pac_fono = '" & Trim(frm_formulario.lbl_fono.Text) & "',  pac_sexo = '" & Trim(frm_formulario.lbl_genero.Text) & "', pac_obs = '" & Trim(frm_formulario.txt_obs_pac.Text) & "', pac_grado = '" & Trim(frm_formulario.cmb_afiliacion.Text) & "' where pac_id = " & int_paciente & ";"
    ' ''        ''odbc_strsql.CommandText = STR_SQL
    ' ''        ''odbc_strsql.ExecuteNonQuery()



    ' ''        'ejecuta esta parte si es un test
    ' ''        odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & _
    ' ''            lng_ped_id & "," & i + 1 & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(1)) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & _
    ' ''            ")", opr_conexion.conn_sql, odbc_trans)
    ' ''        odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, tes_id, pdd_estado,lip_precio) values(" & _
    ' ''        lng_ped_id & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ",1," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & _
    ' ''        ")", opr_conexion.conn_sql, odbc_trans)
    ' ''        odbc_strsql1.ExecuteNonQuery()
    ' ''        'Funci�n que graba los test en la lista de trabajo autom�ticamente
    ' ''        opr_trabajo.InsertLista_trabajo(lng_ped_id, Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)), Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy HH:mm:ss"), genero, edad, unidad)




    ' ''        odbc_strsql.ExecuteNonQuery()

    ' ''        opr_trabajo.InsertPtoPdf(lng_ped_id)
    ' ''        opr_trabajo.InsertPtoImg(lng_ped_id)

    ' ''        'si no hubo errores commit
    ' ''        odbc_trans.Commit()
    ' ''        opr_conexion.sql_desconn()


    ' ''        GuardarPedidoAgenda = 1



    ' ''        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
    ' ''        Exit Function
    ' ''MsgError:
    ' ''        odbc_trans.Rollback()
    ' ''        opr_conexion.sql_desconn()
    ' ''        GuardarPedidoAgenda = 0
    ' ''        VisualizaMensaje("No se pudo realizar la operacion solicitada, Guardar Agenda Medico", g_tiempo)
    ' ''        ''g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
    ' ''        Err.Clear()
    ' ''    End Function


    Public Function LeeOrdenQuimicaCabecera(ByVal ped_id As Long) As String
        'funcion que devuelve un dataset con el codigo maximo de los pedidos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim str_sql As String = Nothing
        Dim dtr_fila As DataRow

        str_sql = "SELECT DISTINCT (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno,(paciente.PAC_APELLIDO + ' ' + paciente.PAC_NOMBRE) as paciente, paciente.PAC_FECNAC as fechanac " & _
        "from pedido, paciente, lista_trabajo, res_procesados, test " & _
        "where pedido.pac_id = paciente.pac_id And lista_trabajo.ped_id = pedido.ped_Id And res_procesados.ped_Id = pedido.ped_id And test.TES_ID = lista_trabajo.tes_id And pedido.PED_ID = " & ped_id & " And res_procesados.TIM_ID = 2;"

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeeOrdenQuimicaCabecera = dtr_fila(0) & "," & dtr_fila(1) & "," & dtr_fila(2)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codigo Pedido", Err)
        Err.Clear()
    End Function


    Public Function LeeOrdenQuimicaExamenes(ByVal ped_id As Long) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim str_sql As String = Nothing
        Dim dtr_fila As DataRow

        str_sql = "SELECT DISTINCT res_procesados.TES_ABREV " & _
        "from pedido, paciente, lista_trabajo, res_procesados, test " & _
        "where pedido.pac_id = paciente.pac_id And lista_trabajo.ped_id = pedido.ped_Id And res_procesados.ped_Id = pedido.ped_id And test.TES_ID = lista_trabajo.tes_id And pedido.PED_ID = " & ped_id & " And res_procesados.TIM_ID = 2;"

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeeOrdenQuimicaExamenes = LeeOrdenQuimicaExamenes & Trim(dtr_fila(0)) & ","
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerID_Hijos", Err)
        Err.Clear()
    End Function

    Public Function GuardarPedido(ByVal frm_formulario As frm_Pedido, ByVal pac_id As Long, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal proforma As Integer, ByVal FechaAgenda As String, ByVal VarMed As Integer) As Byte

        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim dtr_fila As DataRow
        Dim turno As String = ""
        Dim lng_ped_id As Long
        Dim i As Integer
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_pedido As New Cls_Pedido()
        Dim edad As Integer = 0
        Dim OrdenExiste As String = ""
        Dim unidad As String = Nothing
        'obtiene le codigo m�ximo de los pedidos 
        'lng_ped_id = LeerMaxPedido() + 1
        lng_ped_id = ped_id
        g_lng_ped_id = ped_id

        edad = CalculaEdad(frm_formulario.lbl_fecnac.Text, unidad)


        ' genero y valido las secuencias
        Dim sec_nombre As String = Nothing
        Dim sec_inicio, sec_fin As Integer

        'combo.Items.Add(dtr_fila("sec_nombre").ToString().PadRight(50) & dtr_fila("sec_desde").ToString().PadRight(5) & dtr_fila("sec_hasta").ToString().PadRight(5))
        secuencia = Split(frm_formulario.cmb_convenio.Text, "/")

        'For i = 0 To UBound(secuencia) - 1
        sec_nombre = Trim(secuencia(0).ToString)
        sec_inicio = CInt(secuencia(1).ToString)
        sec_fin = CInt(secuencia(2).ToString)


        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle

        Dim STR_SQL As String


        turno = Format(LeerMaxturno(sec_nombre, Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy"), Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)), True), "00#")


        If turno <> Nothing Then
            If turno > sec_fin Then
                MsgBox("Ud. ha excedido el numero permitido de pedidos para " & sec_nombre & ".  Pongase en contacto con el Administrador del sistema.", MsgBoxStyle.Information, "ANALISYS")
                Exit Function
            Else
                If turno < sec_inicio Then
                    turno = sec_inicio
                End If
                STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id,med_id, lab_id, ped_turno, ped_servicio,  PED_PROF) values(" & _
                lng_ped_id & ",'" & FechaAgenda & "','" & Trim(frm_formulario.Ctl_txt_ped_antecedente.Text) & "','" & frm_formulario.Ctl_txt_medicacion.texto_Recupera & "','" & _
                sec_nombre & "','" & Trim(frm_formulario.cmb_convenio.Text) & "'," & pac_id & "," & Val(VarMed) & "," & Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)) _
                & ", " & turno & ", '" & frm_formulario.cmb_servicios.Text & "',  " & proforma & ")"

            End If
        Else
            turno = sec_inicio

        End If

        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        'actualizo el tipo de afiliaci�n del paciente:
        STR_SQL = "update paciente set pac_grado = '" & frm_formulario.lbl_grado.Text & "' where pac_id = " & pac_id & ";"
        odbc_strsql.CommandText = STR_SQL
        odbc_strsql.ExecuteNonQuery()

        For i = 0 To frm_formulario.dtt_pedido.Rows.Count - 1
            'ejecuta esta parte si es un test
            If Trim(frm_formulario.dtt_pedido.Rows(i).Item(5)) = "T" Then
                odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & _
                lng_ped_id & "," & i + 1 & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(1)) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, tes_id, pdd_estado,lip_precio) values(" & _
                lng_ped_id & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ",1," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                odbc_strsql1.ExecuteNonQuery()
                'Funci�n que graba los test en la lista de trabajo autom�ticamente
                opr_trabajo.InsertLista_trabajo(lng_ped_id, Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)), FechaAgenda, Trim(frm_formulario.lbl_genero.Text), edad, unidad, "")

            Else
                'caso contrario es un perfil                
                odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, per_id) values(" & _
                lng_ped_id & "," & i + 1 & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(1)) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                Dim opr_perfil As New Cls_Perfil()
                Dim dts_operacion As DataSet
                dts_operacion = opr_perfil.LeerPerfil_test(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)))
                For Each dtr_fila In dts_operacion.Tables("Registros").Rows
                    odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, per_id, tes_id,lip_precio) values(" & _
                   lng_ped_id & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & "," & dtr_fila(1) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & _
                   ")", opr_conexion.conn_sql, odbc_trans)
                    odbc_strsql1.ExecuteNonQuery()
                Next
            End If
            odbc_strsql.ExecuteNonQuery()
        Next
        'si no hubo errores commit
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        GuardarPedido = 1
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarPedido = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function


    Public Function GuardarPedidoConvenioImportar(ByVal parametros As String, ByVal pac_id As Long, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal examenes As String, ByVal precios As String, ByVal fecha As String, ByVal Sexo As String, ByVal edad As String, ByVal PrePost As String, ByVal med_id As Integer, ByVal servicio As String) As Byte
        edad = CInt(Format(Now(), "yyyy") - CInt(Mid(edad, 7, 4)))
        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim dtr_fila As DataRow

        Dim lng_ped_id As Long
        Dim i As Integer
        Dim opr_trabajo As New Cls_Trabajo()
        'obtiene le codigo m�ximo de los pedidos 
        'lng_ped_id = LeerMaxPedido() + 1
        '
        lng_ped_id = ped_id
        '
        opr_conexion.sql_conectar()
        'odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        Dim datos As String()
        datos = Split(parametros, ",")

        Dim fecha_toma_muestra As Date
        Dim minutos As Integer = System.Configuration.ConfigurationSettings.AppSettings("TOMAMUESTRA")
        Dim matriz As String

        If System.Configuration.ConfigurationSettings.AppSettings("MATRIZ") = True Then
            matriz = "Matriz"
        Else
            matriz = "Sucursal"
        End If

        fecha_toma_muestra = DateAdd(DateInterval.Minute, minutos, CDate(datos(0)))


        STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id,med_id, lab_id, ped_nota, ped_turno, ped_servicio, ped_recibo, ped_prof) values(" & _
        lng_ped_id & ",'" & Format(CDate(datos(0)), "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "','" & matriz & "','" & fecha_toma_muestra & "','" & Trim(datos(1).ToString) & "', '" & Trim(datos(1).ToString) & "'," & pac_id & "," & med_id & ",1,'" & PrePost & "', " & Trim(datos(3).ToString) & ", '" & servicio & "', '" & g_invitado & "',0)"


        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()

        Dim datos_tesId As String()
        datos_tesId = Split(examenes, ",")

        Dim datos_precio As String()
        datos_precio = Split(precios, ",")

        'Dim var_intervalo As Long

        'var_intervalo = 100 / UBound(datos_tesId) - 1

        For i = 0 To UBound(datos_tesId) - 1
            'ejecuta esta parte si es un test

            odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & _
            lng_ped_id & "," & i + 1 & ",1," & Trim(datos_tesId(i)) & _
            ")", opr_conexion.conn_sql, odbc_trans)
            odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, tes_id, pdd_estado,lip_precio) values(" & _
            lng_ped_id & "," & Trim(datos_tesId(i)) & ",1," & Trim(datos_precio(i)) & _
            ")", opr_conexion.conn_sql, odbc_trans)
            odbc_strsql1.ExecuteNonQuery()
            'Funci�n que graba los test en la lista de trabajo autom�ticamente
            opr_trabajo.InsertLista_trabajo(lng_ped_id, datos_tesId(i), Format(CDate(fecha), "dd/MM/yyyy"), Sexo, edad, "AÑOS", "")

            odbc_strsql.ExecuteNonQuery()


            'Timer1.Start()
            'timer1.Interval = var_intervalo
        Next
        'si no hubo errores commit
        'odbc_trans.Commit()
        opr_trabajo.InsertPtoPdf(lng_ped_id, "LABORATORIO", 0)
        opr_trabajo.InsertPtoImg(lng_ped_id, "QR")
        opr_conexion.sql_desconn()
        g_lng_ped_id = lng_ped_id
        GuardarPedidoConvenioImportar = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Pedido IMPORTACION", Trim(datos(1).ToString) & "/" & ped_id, g_sng_user, "", "", "")
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarPedidoConvenioImportar = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function

    Public Function GuardarPedidoConvenio(ByVal parametros As String, ByVal pac_id As Long, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal dtt_pedido1 As DataTable, ByVal fecha As String, ByVal edad As Integer, ByVal genero As String) As Byte

        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim dtr_fila As DataRow

        Dim lng_ped_id As Long
        Dim i As Integer
        Dim opr_trabajo As New Cls_Trabajo()
        'obtiene le codigo m�ximo de los pedidos 
        'lng_ped_id = LeerMaxPedido() + 1
        '
        lng_ped_id = ped_id
        '
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        Dim datos As String()
        datos = Split(parametros, ",")

        Dim Matriz As String = Nothing
        If System.Configuration.ConfigurationSettings.AppSettings("MATRIZ") Then
            Matriz = "Matriz"
        Else
            Matriz = "Sucursal"
        End If

        STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id,med_id, lab_id, ped_nota, ped_turno, ped_servicio, ped_recibo, ped_prof) values(" & _
        lng_ped_id & ",'" & Format(CDate(datos(0)), "dd/MM/yyyy ") & Format(TimeOfDay, "HH:mm:ss") & "','" & Matriz & "', '" & Format(CDate(datos(0)), "dd/MM/yyyy ") & Format(TimeOfDay, "HH:mm:ss") & "','" & Trim(datos(2).ToString) & "', '" & Trim(datos(2).ToString) & "'," & pac_id & ",0,1,'NO APLICA'," & Trim(datos(3).ToString) & ", 'CONSULTA EXTERNA', '',0)"


        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        For i = 0 To dtt_pedido1.Rows.Count - 1
            'ejecuta esta parte si es un test
            If Trim(dtt_pedido1.Rows(i).Item(4)) = "T" Then
                odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & _
                lng_ped_id & "," & i + 1 & "," & Trim(dtt_pedido1.Rows(i).Item(0)) & "," & Trim(dtt_pedido1.Rows(i).Item(2)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, tes_id, pdd_estado,lip_precio) values(" & _
                lng_ped_id & "," & Trim(dtt_pedido1.Rows(i).Item(2)) & ",1," & Trim(dtt_pedido1.Rows(i).Item(3)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                odbc_strsql1.ExecuteNonQuery()

                'opr_trabajo.InsertLista_trabajo(lng_ped_id, Trim(dtt_pedido1.Rows(i).Item(2)), Format(CDate(fecha), "dd/MM/yyyy"), frm_Pedido.lbl_genero.Text, frm_Pedido.lbl_edad.Text, "AÑOS")
                opr_trabajo.InsertLista_trabajo(lng_ped_id, Trim(dtt_pedido1.Rows(i).Item(2)), Format(CDate(fecha), "dd/MM/yyyy"), genero, edad, "AÑOS", "")

            Else
                'caso contrario es un perfil                
                odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, per_id) values(" & _
                lng_ped_id & "," & i + 1 & "," & Trim(dtt_pedido1.Rows(i).Item(0)) & "," & Trim(dtt_pedido1.Rows(i).Item(2)) & _
                ")", opr_conexion.conn_sql, odbc_trans)
                Dim opr_perfil As New Cls_Perfil()
                Dim dts_operacion As DataSet
                dts_operacion = opr_perfil.LeerPerfil_test(Trim(dtt_pedido1.Rows(i).Item(2)))
                For Each dtr_fila In dts_operacion.Tables("Registros").Rows
                    odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, per_id, tes_id,lip_precio) values(" & _
                   lng_ped_id & "," & Trim(dtt_pedido1.Rows(i).Item(2)) & "," & dtr_fila(0) & "," & Trim(dtt_pedido1.Rows(i).Item(3)) & _
                   ")", opr_conexion.conn_sql, odbc_trans)
                    odbc_strsql1.ExecuteNonQuery()
                Next
            End If
            odbc_strsql.ExecuteNonQuery()
        Next
        'si no hubo errores commit
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        g_lng_ped_id = lng_ped_id
        GuardarPedidoConvenio = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Pedido PRE CARGA", Trim(datos(1).ToString) & "/" & ped_id, g_sng_user, "", "", "")
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarPedidoConvenio = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function


    Public Function GuardarPedidoAgenda(ByVal parametros As String, ByVal pac_id As Long, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal param_procedimientos As String, ByVal fecha As String, ByVal edad As Integer, ByVal unidad As String, ByVal genero As String, ByVal med_id As Integer, ByVal ped_turno As Integer, ByVal TipoTx As String) As Byte

        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim odbc_strsql1 As SqlCommand
        Dim dtr_fila As DataRow

        Dim lng_ped_id As Long
        Dim i As Integer
        Dim opr_trabajo As New Cls_Trabajo()

        lng_ped_id = ped_id
        '
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        Dim datos As String()
        datos = Split(parametros, "/")

        Dim Matriz As String = Nothing
        If System.Configuration.ConfigurationSettings.AppSettings("MATRIZ") Then
            Matriz = "Matriz"
        Else
            Matriz = "Sucursal"
        End If
        If TipoTx = "Insert" Then
            STR_SQL = "insert into pedido(ped_id, ped_fecing, ped_antecedente, ped_medicacion, ped_tipo, con_nombre, pac_id, med_id, lab_id, ped_nota, ped_turno, ped_servicio, ped_recibo, ped_prof) values(" & _
            lng_ped_id & ",'" & Format(CDate(datos(0)), "dd/MM/yyyy ") & Format(TimeOfDay, "HH:mm:ss") & "','" & Matriz & "', '" & Format(CDate(datos(0)), "dd/MM/yyyy ") & Format(TimeOfDay, "HH:mm:ss") & "','" & Trim(datos(1).ToString) & "', '" & Trim(datos(1).ToString) & "'," & pac_id & "," & med_id & ", 1, 'NO APLICA'," & Trim(datos(4).ToString) & ", 'CONSULTA EXTERNA', '',0)"

            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
        End If

        Dim arre_procedimiento As String()
        arre_procedimiento = Split(param_procedimientos, "º")

        'For i = 0 To UBound(arre_procedimiento) - 1
        'ejecuta esta parte si es un test
        Dim arre_exaid As String()
        For i = 0 To UBound(arre_procedimiento) - 1
            arre_exaid = Split(arre_procedimiento(i), ",")
            odbc_strsql = New SqlCommand("insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & _
            lng_ped_id & "," & i + 1 & ",1," & Trim(arre_exaid(0)) & _
            ")", opr_conexion.conn_sql, odbc_trans)
            odbc_strsql1 = New SqlCommand("insert into pedido_detalle_desglosado(ped_id, tes_id, pdd_estado,lip_precio) values(" & _
            lng_ped_id & "," & Trim(arre_exaid(0)) & ",1," & Trim(arre_exaid(2)) & _
            ")", opr_conexion.conn_sql, odbc_trans)
            odbc_strsql1.ExecuteNonQuery()

            odbc_strsql.ExecuteNonQuery()

            opr_trabajo.InsertLista_trabajo(lng_ped_id, Trim(arre_exaid(0)), Format(CDate(fecha), "dd/MM/yyyy"), genero, edad, unidad, param_procedimientos)


        Next

        opr_trabajo.InsertPtoPdf(lng_ped_id, "RECETA", 0)
        opr_trabajo.InsertPtoImg(lng_ped_id, "RECETA")

        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        g_lng_ped_id = lng_ped_id
        GuardarPedidoAgenda = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Pedido PRE CARGA", Trim(datos(1).ToString) & "/" & ped_id, g_sng_user, "", "", "")
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarPedidoAgenda = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function


    Public Function GuardarSigEspeciales(ByVal hic_id As Integer, ByVal str_hicSigEspeciales As String) As Byte

        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        '
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String


        STR_SQL = "update historiaClinica set hic_SignosEspeciales= '" & str_hicSigEspeciales & "' where HIC_ID = " & hic_id & ""


        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        GuardarSigEspeciales = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA SINGOS ESPECIALES", hic_id, g_sng_user, "", "", "")
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarSigEspeciales = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function


    Public Function GuardarCutaneas(ByVal ped_id As Integer, ByVal fecha As String, ByVal hora As String, ByVal TES_ABREV As String, ByVal TES_RESUL_ANIO As String, ByVal TES_RESUL_INT As String, ByVal TIM_ID As Integer, ByVal TES_ID As Integer) As Byte

        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim visto As Char = ChrW(10003)

        If TES_RESUL_INT = visto Then
            TES_RESUL_INT = "I"
        End If

        '
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        STR_SQL = "update res_cutaneas set PRCC_FECHA = '" & fecha & "', PRCC_HORA = '" & hora & "', PRCC_RESUL_ANIO= '" & TES_RESUL_ANIO & "', PRCC_RESUL_INT = '" & TES_RESUL_INT & "' where PED_ID =" & ped_id & " and TES_ABREV = '" & TES_ABREV & "' and TIM_ID = " & TIM_ID & " and TES_PADRE = " & TES_ID

        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)

        'g_opr_usuario.CargarTransaccion(g_str_login, "CUTANEAS", TES_ABREV, g_sng_user, "", "", "")

        'MsgBox("Seleccionado" & TES_ABREV & " - - CONVERTIDO ASCII " & Asc(TES_ABREV).ToString)
        odbc_strsql.ExecuteNonQuery()
        'MsgBox("Guardado " & TES_ABREV)

        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        GuardarCutaneas = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "CUTANEAS", TES_ABREV, g_sng_user, "", "", "")
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        MsgBox("No guarda " & TES_ABREV)
        g_opr_usuario.CargarTransaccion(g_str_login, "CUTANEAS", "NO GUARDA: " & TES_ABREV, g_sng_user, "", "", "")
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarCutaneas = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function

    Public Function EliminaExistencia(ByVal I_EDAD As Char) As Byte

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        STR_SQL = "delete from I_TMPCONSUMO where SUBSTRING(TMP_I_PRD_ID, LEN(TMP_I_PRD_ID), 1) = '" & I_EDAD & "'"

        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        EliminaExistencia = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "ELIMINA EXISTENCIA TEMP", 0, g_sng_user, "", "", "")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        EliminaExistencia = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Elimina existencia", Err)
        Err.Clear()
    End Function

    Public Sub InsertaEncuesta(ByVal Age_id As Integer)

        'funcion que permite guardar un pedido nuevo
        'TIPO:    SI ES 1 SE TRATA DE UN PEDIDO, SI ES 0 SE TRATA DE UN RECIBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        '
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String


        STR_SQL = "Insert into EncuestaRCAT values(" & Age_id & ",'','','','','','');"


        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        odbc_trans.Commit()
        opr_conexion.sql_desconn()


        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA ENCUESTA", Age_id, g_sng_user, "", "", "")
        'MsgBox("El pedido # " & CShort(frm_formulario.cmb_turno.Text) & " fue almacenado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Encuesta", Err)
        Err.Clear()
    End Sub



    Public Function EliminaExistenciaTemporal(ByVal I_EDAD As Char) As Byte

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        STR_SQL = "delete from consumo_temp where SUBSTRING(I_PRD_ID, LEN(I_PRD_ID), 1) = '" & I_EDAD & "'"

        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        EliminaExistenciaTemporal = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "ELIMINA EXISTENCIA TEMP", 0, g_sng_user, "", "", "")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        EliminaExistenciaTemporal = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Elimina existencia", Err)
        Err.Clear()
    End Function


    Public Function GuardarExistencia(ByVal I_PRD_ID As String, ByVal VAL_TENDENCIA As Double, ByVal VAL_FRECUENCIA As Double) As Byte

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        STR_SQL = "insert into I_TMPCONSUMO values('" & I_PRD_ID & "', " & VAL_TENDENCIA & ", " & VAL_FRECUENCIA & ")"

        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        GuardarExistencia = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA EXISTENCIA TEMP", 0, g_sng_user, "", "", "")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarExistencia = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function


    Public Function GuardarExistenciaTemporal(ByVal I_PRD_ID As String, ByVal I_PRD_DESCRIPCION As String, ByVal CIRCUL As Double, ByVal EMPAQ As Double, ByVal CUARE As Double, ByVal EXIST As Double, ByVal TEND As Double, ByVal REAL As Double, ByVal FREC As Double, ByVal PRODUCCION As String) As Byte

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'utilizo transacciones para la cabecera detalle
        Dim STR_SQL As String

        STR_SQL = "insert into consumo_temp values('" & I_PRD_ID & "', '" & I_PRD_DESCRIPCION & "', " & CIRCUL & ", " & EMPAQ & ", " & CUARE & ", " & EXIST & ", " & TEND & ", " & REAL & ", " & FREC & ", '" & PRODUCCION & "' )"

        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()


        odbc_trans.Commit()
        opr_conexion.sql_desconn()

        GuardarExistenciaTemporal = 1
        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA EXISTENCIA TEMP", 0, g_sng_user, "", "", "")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        GuardarExistenciaTemporal = 0
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Pedido", Err)
        Err.Clear()
    End Function



    Public Function LeerMaxPedido() As Long
        'funcion que devuelve un dataset con el codigo maximo de los pedidos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxPedido = CLng(New SqlCommand("Select isnull(Max(ped_id),0) from pedido", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codigo Pedido", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodigo() As Long
        'funcion que devuelve un dataset con el codigo maximo de los pedidos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxCodigo = CLng(New SqlCommand("Select isnull(Max(cod_num),0) from codigo", opr_conexion.conn_sql).ExecuteScalar) + 1
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codigo ", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxConsultaMedico() As Long
        'funcion que devuelve un dataset con el codigo maximo de los pedidos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxConsultaMedico = CLng(New SqlCommand("Select isnull(Max(con_id),0) from consultaMedico", opr_conexion.conn_sql).ExecuteScalar) + 1
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codigo ", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxReceta() As Long
        'funcion que devuelve un dataset con el codigo maximo de los pedidos
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxReceta = CLng(New SqlCommand("Select isnull(Max(rec_id),0) from receta", opr_conexion.conn_sql).ExecuteScalar) + 1
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo receta ", Err)
        Err.Clear()
    End Function

    Public Function LeerNombreTest(ByVal tes_nombre As String) As Integer

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerNombreTest = CInt(New SqlCommand("select tes_id from test where tes_nombre = '" & tes_nombre & "'; ", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerNombreTest", Err)
        Err.Clear()
    End Function


    Public Function LeerNombreTest2(ByVal tes_id As Integer, ByVal genero As String) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerNombreTest2 = New SqlCommand("select TEQ_ABRV_FIJA from test_equipo where tes_id = " & tes_id & " and TEQ_ABREVIATURA = '" & genero & "'; ", opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAbrevTest", Err)
        Err.Clear()
    End Function


    Public Function LeerResultadoTest2(ByVal TES_ABREV As String, ByVal ped_id As Long) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        'Dim tes_brev_nuevo = Mid(TES_ABREV, 1, Len(TES_ABREV) - 1)


        opr_conexion.sql_conectar()
        LeerResultadoTest2 = New SqlCommand("select (case prc_resfinal when '' then 'NA' else prc_resfinal end) as resul from res_procesados where TES_ABREV like '" & TES_ABREV & "%' and ped_id = " & ped_id & "; ", opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAbrevTest", Err)
        Err.Clear()
    End Function



    Public Function LeerIdTestEquipo(ByVal TEQ_ABRV_FIJA As String) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerIdTestEquipo = New SqlCommand("select tes_id from test_equipo where TEQ_ABRV_FIJA = '" & TEQ_ABRV_FIJA & "'; ", opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerAbrevTest", Err)
        Err.Clear()
    End Function




    Public Function LeerIdPadreTest(ByVal tes_padre As Integer) As String

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("select tes_id from test where tes_padre = " & tes_padre, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerIdPadreTest = LeerIdPadreTest & dtr_fila(0) & ","
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerID_Hijos", Err)
        Err.Clear()
    End Function




    Public Function LeerIdPadreTest(ByVal tes_nombre As String, ByVal ped_id As Integer) As Integer

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerIdPadreTest = CInt(New SqlCommand("select tes_padre from res_procesados where tes_abrev = '" & tes_nombre & "' and ped_id = " & ped_id & "; ", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, LeerIDest", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxturno(ByVal tipo As String, ByVal fecha As Date, ByVal laboratorio As Short, ByVal SumaSecuencia As Boolean) As Integer
        'funcion que devuelve el numero máximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()

        '****************************************
        'PARA GENERAR NUEVA NOMENCLATURA TURNO
        'Dim str_sql As String = "Select isnull(Max(Substring(ped_turno,7,4)),0) from pedido where ped_tipo = '" & tipo & "' AND PED_FECING LIKE '" & Format(fecha, "dd/MM/yyyy") & "%' AND LAB_ID = " & laboratorio & ";"
        '****************************************
        Dim mes, año As Short
        Dim fec_ini, fec_fin As String
        Dim str_sql As String


        'PARA TURNO MENSUAL
        If g_tiposecuencia = "MENSUAL" Then
            fec_ini = "01" & "/" & Mid(fecha, 4, 2) & "/" & Mid(fecha, 7, 4)
            fec_fin = opr_agenda.DevuelveUltimoDiaMes(fecha)
            'str_sql = "Select isnull(Max(ped_turno),0) from pedido where ped_tipo = '" & Trim(tipo) & "'and ped_fecing between '" & fec_ini & " 00:00:01' and '" & fec_fin & " 23:59:59';"
        End If


        'PARA TURNO DIARIO
        If g_tiposecuencia = "DIARIO" Then
            fec_ini = Mid(fecha, 1, 2) & "/" & Mid(fecha, 4, 2) & "/" & Mid(fecha, 7, 4)
            fec_fin = fec_ini 'Mid(fecha, 1, 2) & "/" & Mid(fecha, 4, 2) & "/" & Mid(fecha, 7, 4)
        End If
        '***GENERA SECUENCIA DEL TURNO SIN SALTO
        'str_sql = "Select isnull(Max(ped_turno),0) from pedido where ped_tipo = '" & Trim(tipo) & "' and ped_estado <> 2 and ped_fecing between '" & fec_ini & " 00:00:01' and '" & fec_fin & " 23:59:59';"


        '***GENERA SECUENCIA DEL TURNO CON SALTO
        str_sql = "Select isnull(Max(ped_turno),0) from pedido where ped_tipo = '" & Trim(tipo) & "' and ped_fecing between '" & fec_ini & " 00:00:01' and '" & fec_fin & " 23:59:59';"


        opr_conexion.sql_conectar()

        LeerMaxturno = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)

        If LeerMaxturno >= 0 Then
            LeerMaxturno = LeerMaxturno + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer M�ximo Turno", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxNumAux(ByVal fecha As Date) As Integer
        'funcion que devuelve el numero m�ximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim anio As Short
        Dim fec_ini, fec_fin As Date
        Dim str_sql As String

        anio = Format(Now, "yyyy")
        'PARA TURNO ANUAL
        fec_ini = fecha
        fec_fin = "31/12/" & anio & " 23:59:59"


        If (DateTime.Compare(fec_ini, fec_ini) > 0) Then
            LeerMaxNumAux = 1
        Else
            str_sql = "Select isnull(Max(PED_NUMAUX),0) as codigo  from pedido;"
            opr_conexion.sql_conectar()

            LeerMaxNumAux = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
            If LeerMaxNumAux >= 0 Then
                LeerMaxNumAux = LeerMaxNumAux + 1
            End If

            opr_conexion.sql_desconn()

        End If


        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo Codigo", Err)
        Err.Clear()
    End Function



    Public Function LeerMaxIdSignos() As Integer
        'funcion que devuelve el numero maximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String

        str_sql = "Select isnull(Max(sig_id),0) as codigo from SignosVitales;"
        opr_conexion.sql_conectar()

        LeerMaxIdSignos = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdSignos >= 0 Then
            LeerMaxIdSignos = LeerMaxIdSignos + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo ID SV", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxIdFacRiesgo() As Integer
        'funcion que devuelve el numero maximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String

        str_sql = "Select isnull(Max(FR_ID),0) as codigo from factoresRiesgo;"
        opr_conexion.sql_conectar()

        LeerMaxIdFacRiesgo = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdFacRiesgo >= 0 Then
            LeerMaxIdFacRiesgo = LeerMaxIdFacRiesgo() + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo FR", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxIdActividad() As Integer
        'funcion que devuelve el numero maximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String

        str_sql = "Select isnull(Max(Aact_id),0) as codigo from agendaActividad;"
        opr_conexion.sql_conectar()

        LeerMaxIdActividad = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdActividad >= 0 Then
            LeerMaxIdActividad = LeerMaxIdActividad + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo ACTIVIDAD", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxIdGrupoMedico() As Integer
        'funcion que devuelve el numero maximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String

        str_sql = "Select isnull(Max(GMED_id),10000) as codigo from GrupoMedico;"
        opr_conexion.sql_conectar()

        LeerMaxIdGrupoMedico = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdSignos >= 0 Then
            LeerMaxIdGrupoMedico = LeerMaxIdGrupoMedico + 10000
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo GRUPO MEDICO", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxIdExamenFisico() As Integer
        'funcion que devuelve el numero maximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String

        str_sql = "Select isnull(Max(efi_id),0) as codigo from ExamenFisico;"
        opr_conexion.sql_conectar()

        LeerMaxIdExamenFisico = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdExamenFisico >= 0 Then
            LeerMaxIdExamenFisico = LeerMaxIdExamenFisico + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo ID examen fisico", Err)
        Err.Clear()
    End Function



    Public Function LeerMaxIdHistoria() As Integer
        'funcion que devuelve el numero maximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String

        str_sql = "Select isnull(Max(hic_id),0) as codigo from HistoriaClinica;"
        opr_conexion.sql_conectar()

        LeerMaxIdHistoria = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdHistoria >= 0 Then
            LeerMaxIdHistoria = LeerMaxIdHistoria + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo ID SV", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxIdHistoriaCambios() As Integer
        'funcion que devuelve el numero maximo de turno en base de tipo pedido, fecha y laboratorio
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String

        str_sql = "Select isnull(Max(hic_id),0) as codigo from HistoriaClinicaCambios;"
        opr_conexion.sql_conectar()

        LeerMaxIdHistoriaCambios = CLng(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxIdHistoria >= 0 Then
            LeerMaxIdHistoriaCambios = LeerMaxIdHistoriaCambios + 1
        End If

        opr_conexion.sql_desconn()

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Maximo ID ", Err)
        Err.Clear()
    End Function


    Public Function Imprimeproforma(ByVal g_lng_ped_id As Long, ByRef Ds As DataSet)
        'Dim ds_proforma As DataSet
        'Private m_cls_dgimpresion As cls_dgimpresion = Nothing



        'Dim titulo As String = "LISTA DE TRABAJO"
        'If ds_proforma.Tables.Count > 0 Then
        '    'If MsgBox("Para imprimir, debe guardar la lista de trabajo. Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = MsgBoxResult.Yes Then
        '    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        '    'Guarda_lista(2)
        '    Try
        '        m_cls_dgimpresion = New cls_dgimpresion(dgrd_trabajo, PrintDocument1, dtv_trabajo, dtp_fecing.Text, cmb_eqp.Text, cmb_area.Text, cmb_vistas.Text, Me.Tag, titulo)
        '        PrintPreviewDialog1.ShowDialog()
        '        Me.Refresh()
        '    Catch iex As System.Drawing.Printing.InvalidPrinterException
        '        MsgBox("Error En la Impresora", MsgBoxStyle.Exclamation, "ANALISYS")
        '    End Try
        '    Me.Cursor = System.Windows.Forms.Cursors.Arrow
        '    'End If
        'End If

    End Function


    Public Function LeerProforma(ByVal g_lng_ped_id As Long) As DataSet
        'funcion que devuelve en un dataset los datos del los pedidos
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor

        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, (pac_apellido+ ' '+pac_nombre) AS pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, pedido_detalle_desglosado.LIP_PRECIO from paciente, pedido, medico, laboratorio, pedido_detalle, perfil, pedido_detalle_desglosado where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id and pedido_detalle_desglosado.PED_ID = pedido_detalle.PED_ID UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad, tes_nombre as prueba, pedido_detalle_desglosado.LIP_PRECIO from paciente, pedido, medico, laboratorio, pedido_detalle, test, pedido_detalle_desglosado where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id and pedido_detalle_desglosado.PED_ID = pedido_detalle.PED_ID and pedido_detalle_desglosado.TES_ID  = test.TES_ID "
        'Consulto todos los pedidos, menos los anulados
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        LeerProforma = New DataSet()
        oda_pedido.Fill(LeerProforma, "Registros")
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function



    Public Function llenaProforma(ByVal g_lng_ped_id As Long) As DataSet
        On Error GoTo MsgError
        Dim str_sql As String
        str_sql = "Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre,pee_cantidad, per_nombre as prueba, pedido_detalle_desglosado.LIP_PRECIO from paciente, pedido, medico, laboratorio, pedido_detalle, perfil, pedido_detalle_desglosado where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and perfil.per_id=pedido_detalle.per_id and pedido.ped_id=pedido_detalle.ped_id and pedido_detalle_desglosado.PED_ID = pedido_detalle.PED_ID UNION Select pedido.ped_id, ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, med_nombre, con_nombre, lab_nombre, pee_cantidad, tes_nombre as prueba, pedido_detalle_desglosado.LIP_PRECIO from paciente, pedido, medico, laboratorio, pedido_detalle, test, pedido_detalle_desglosado where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and  pedido.pac_id=paciente.pac_id and pedido.ped_id=" & g_lng_ped_id & " and  pedido.ped_id=pedido_detalle.ped_id and pedido_detalle.tes_id=test.tes_id and pedido_detalle_desglosado.PED_ID = pedido_detalle.PED_ID and pedido_detalle_desglosado.TES_ID  = test.TES_ID "
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        llenaProforma = New DataSet()
        oda_pedido.Fill(llenaProforma, "Tabla")

        opr_conexion.sql_desconn()
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Proforma", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default

    End Function



    Public Function LeerPedido(ByVal fec_ini As Date, ByVal fec_fin As Date) As DataSet
        'funcion que devuelve en un dataset los datos del los pedidos
        On Error GoTo MsgError
        Dim STR_FECHA As String = ""
        Cursor.Current = Cursors.WaitCursor
        STR_FECHA = " and (pedido.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59')"
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String = "Select pdd.ped_id, pedido.ped_fecing, pac_apellido, pac_nombre, ped_tipo, ped_turno, pac_hist_clinica, ped_recibo, sum(pdd.lip_precio) as total from paciente, pedido, pedido_detalle_desglosado as pdd where pedido.ped_id = pdd.ped_id and pedido.pac_id=paciente.pac_id  and (ped_estado <> 2)" & STR_FECHA & " group by pdd.ped_id order by ped_fecing desc , ped_turno"
        'Consulto todos los pedidos, menos los anulados
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerPedido = New DataSet()
        oda_pedido.Fill(LeerPedido, "Registros")
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function



    Public Function LeerPedidoHistorico(ByVal pac_id As Integer) As DataSet
        'funcion que devuelve en un dataset los datos del los pedidos
        On Error GoTo MsgError
        Dim STR_FECHA As String = ""
        Cursor.Current = Cursors.WaitCursor
        'STR_FECHA = " and (pedido.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59')"
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String = "Select pdd.ped_id, pedido.ped_fecing, ped_tipo, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno from paciente, pedido, pedido_detalle_desglosado as pdd where pedido.ped_id = pdd.ped_id and pedido.pac_id=paciente.pac_id and (ped_estado <> 2) and pedido.PAC_ID = " & pac_id & " group by pdd.ped_id,ped_fecing, ped_tipo, PED_TURNO  order by ped_fecing desc , PED_TURNO "
        'Consulto todos los pedidos, menos los anulados
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerPedidoHistorico = New DataSet()
        oda_pedido.Fill(LeerPedidoHistorico, "Registros")
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido Historico", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function


    Public Function LeerPedidoHistoricoExamenes(ByVal ped_id As Integer) As DataSet
        'funcion que devuelve en un dataset los datos del los pedidos
        On Error GoTo MsgError
        Dim STR_FECHA As String = ""
        Cursor.Current = Cursors.WaitCursor
        'STR_FECHA = " and (pedido.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59')"
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String = "SELECT AREA.ARE_NOMBRE, test.TES_ID, test.TES_NOMBRE, res_procesados.PRC_RESFINAL " & _
        "FROM pedido_detalle_desglosado, test, area, res_procesados, test_equipo " & _
        "where pedido_detalle_desglosado.ped_id = res_procesados .PED_ID and test.TES_ID = test_equipo.TES_ID and test_equipo .TES_ID = pedido_detalle_desglosado.TES_ID and test .TES_ID =  pedido_detalle_desglosado.TES_ID and pedido_detalle_desglosado.TES_ID = test.tes_id and pedido_detalle_desglosado.TES_ID = test.tes_id And test.ARE_ID = area.ARE_ID And pedido_detalle_desglosado.ped_id = " & ped_id

        'Consulto todos los pedidos, menos los anulados
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerPedidoHistoricoExamenes = New DataSet()
        oda_pedido.Fill(LeerPedidoHistoricoExamenes, "RegistrosExa")
        opr_conexion.sql_desconn()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido Historico", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function


    Public Function LeerEstadoFactura(ByVal ped_id As Integer, ByRef numFac As String) As Byte
        On Error GoTo MsgError
        Dim str_sql As String = ""
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        'str_sql = "Select case when PED_FAC_ESTADO IS NULL  then 0 else PED_FAC_ESTADO end as PED_FAC_ESTADO, case when fac_id IS NULL then 'SIN GENERAR' else case when fac_id > 0 then fac_id else '0'end end as fac_id from pedido where PED_id =" & ped_id

        str_sql = "Select case when factura.FAC_ESTATUS IS NULL  then 0 else factura.FAC_ESTATUS end as PED_FAC_ESTADO, case when pedido.fac_id IS NULL then 'SIN GENERAR' else case when pedido.fac_id > 0 then pedido.fac_id else '0'end end as fac_id from pedido, factura where pedido.FAC_ID = factura.FAC_ID  and PED_id =" & ped_id
        LeerEstadoFactura = 0

        'opr_Conexion.conn_sql()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerEstadoFactura = dtr_fila(0).ToString
            numFac = dtr_fila(1).ToString
        Next

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer PedEstado Factura", Err)
        Err.Clear()
    End Function


    Public Function LeerParamGrupoSanguineo(ByVal tes_padre As Integer) As String
        On Error GoTo MsgError
        Dim str_sql As String = ""
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        'str_sql = "Select case when PED_FAC_ESTADO IS NULL  then 0 else PED_FAC_ESTADO end as PED_FAC_ESTADO, case when fac_id IS null then 'SIN GENERAR' when fac_id > 0 then fac_id end as fac_id from pedido where PED_id = " & ped_id & ""
        str_sql = "select PRC_RESFINAL from res_procesados where tes_padre  in( " & tes_padre & ");"
        LeerParamGrupoSanguineo = ""

        'opr_Conexion.conn_sql()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerParamGrupoSanguineo = dtr_fila(0).ToString
        Next

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer parametros grupo sanguineo", Err)
        Err.Clear()
    End Function



    Public Function LeerTelefono(ByVal pac_id As String) As String
        On Error GoTo MsgError
        Dim str_sql As String = ""
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        'str_sql = "Select case when PED_FAC_ESTADO IS NULL  then 0 else PED_FAC_ESTADO end as PED_FAC_ESTADO, case when fac_id IS null then 'SIN GENERAR' when fac_id > 0 then fac_id end as fac_id from pedido where PED_id = " & ped_id & ""
        str_sql = "select pac_fono from paciente where PAC_ID = '" & pac_id & "';"
        LeerTelefono = ""

        'opr_Conexion.conn_sql()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerTelefono = dtr_fila(0).ToString
        Next

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Telefono Paciente", Err)
        Err.Clear()
    End Function


    Public Function LeerTelefonoMedico(ByVal med_id As String) As String
        On Error GoTo MsgError
        Dim str_sql As String = ""
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        'str_sql = "Select case when PED_FAC_ESTADO IS NULL  then 0 else PED_FAC_ESTADO end as PED_FAC_ESTADO, case when fac_id IS null then 'SIN GENERAR' when fac_id > 0 then fac_id end as fac_id from pedido where PED_id = " & ped_id & ""
        str_sql = "select med_fono from medico where med_id = " & med_id & ";"
        LeerTelefonoMedico = String.Empty

        'opr_Conexion.conn_sql()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerTelefonoMedico = dtr_fila(0).ToString
        Next

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Telefono Paciente", Err)
        Err.Clear()
    End Function


    Public Function LeerNombreMedico(ByVal med_id As String) As String
        On Error GoTo MsgError
        Dim str_sql As String = ""
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        'str_sql = "Select case when PED_FAC_ESTADO IS NULL  then 0 else PED_FAC_ESTADO end as PED_FAC_ESTADO, case when fac_id IS null then 'SIN GENERAR' when fac_id > 0 then fac_id end as fac_id from pedido where PED_id = " & ped_id & ""
        str_sql = "select med_nombre from medico where med_id = " & med_id & ";"
        LeerNombreMedico = String.Empty

        'opr_Conexion.conn_sql()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerNombreMedico = dtr_fila(0).ToString
        Next

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Telefono Paciente", Err)
        Err.Clear()
    End Function


    Public Function LeerEstadoPedidos(ByVal ped_id As Long) As Byte
        On Error GoTo MsgError
        Dim str_sql As String = ""
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        'str_sql = "Select case when PED_FAC_ESTADO IS NULL  then 0 else PED_FAC_ESTADO end as PED_FAC_ESTADO, case when fac_id IS null then 'SIN GENERAR' when fac_id > 0 then fac_id end as fac_id from pedido where PED_id = " & ped_id & ""
        str_sql = "Select case when PED_FAC_ESTADO IS NULL  then 0 else PED_FAC_ESTADO end as PED_FAC_ESTADO, case when fac_id IS NULL then 'SIN GENERAR' else case when fac_id > 0 then fac_id else '0'end end as fac_id from pedido where PED_id =" & ped_id
        LeerEstadoPedidos = 0

        'opr_Conexion.conn_sql()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerEstadoPedidos = dtr_fila(0).ToString
        Next

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer PedEstado Factura", Err)
        Err.Clear()
    End Function


    Public Function LeerPedEstadoFactura(ByVal ped_id As Integer) As DataSet
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("Select ped_fac_estado from pedido where ped_id = " & ped_id & "", opr_conexion.conn_sql)
        LeerPedEstadoFactura = New DataSet()
        oda_pedido.Fill(LeerPedEstadoFactura, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer PedEstado Factura", Err)
        Err.Clear()
    End Function

    Public Function LeerPedEstado(ByVal ped_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("Select ped_estado from pedido where ped_id = " & ped_id & "", opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerPedEstado = dtr_fila(0)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer PedEstado", Err)
        Err.Clear()
    End Function


    Public Sub LeerInfoGlobal(ByVal ped_fecing As Date, ByVal convenio As String, ByRef total As Integer, ByRef sin_procesar As Integer, ByRef validados As Integer, ByRef sin_validar As Integer, ByRef impresos As Integer, ByRef enviados As Integer, ByRef pacientes As Integer, ByRef pac_his As Integer)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila1, dtr_fila2, dtr_fila3, dtr_fila4, dtr_fila5, dtr_fila6, dtr_fila7 As DataRow
        Dim str_sql1, str_sql2, str_sql3, str_sql4, str_sql5, str_sql6, str_sql7, str_sql8 As String
        opr_conexion.sql_conectar()


        '*******TOTAL
        str_sql1 = "select COUNT(ped_id) as TOTAL from pedido " & _
                "where convert(char(10),PEDIDO.PED_FECING,103) like '" & Replace(Format(ped_fecing, "dd/MM/yyyy"), "-", "/") & "'" & _
                "and pedido.CON_NOMBRE = '" & convenio & "';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql1, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila1 In dts_estado.Tables("Registros").Rows
            total = dtr_fila1(0)
        Next
        dts_estado.Clear()

        '*******SIN PROCESAR
        str_sql2 = "select COUNT(ped_id) as 'SIN PROCESAR' from pedido " & _
                "where pedido.PED_ESTADO = 0 AND convert(char(10),PEDIDO.PED_FECING,103) like '" & Replace(Format(ped_fecing, "dd/MM/yyyy"), "-", "/") & "'" & _
                "and pedido.CON_NOMBRE = '" & convenio & "';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql2, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila2 In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila2(1)) Then
                sin_procesar = 0
            Else
                sin_procesar = dtr_fila2(1)
            End If
        Next
        dts_estado.Clear()

        '*******'TOTAL VALIDADOS'
        str_sql3 = "select COUNT(ped_id) as 'VALIDADOS' from pedido " & _
                "where pedido.PED_ESTADO = 3 AND convert(char(10),PEDIDO.PED_FECING,103) like '" & Replace(Format(ped_fecing, "dd/MM/yyyy"), "-", "/") & "'" & _
                "and pedido.CON_NOMBRE = '" & convenio & "';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql3, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila3 In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila3(2)) Then
                validados = 0
            Else
                validados = dtr_fila3(2)
            End If
        Next
        dts_estado.Clear()

        '*******'SIN VALIDAR'
        str_sql4 = "select COUNT(ped_id) as 'SIN VALIDAR' from pedido " & _
                "where pedido.PED_ESTADO = 5 AND convert(char(10),PEDIDO.PED_FECING,103) like '" & Replace(Format(ped_fecing, "dd/MM/yyyy"), "-", "/") & "'" & _
                "and pedido.CON_NOMBRE = '" & convenio & "';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql4, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila4 In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila4(3)) Then
                sin_validar = 0
            Else
                sin_validar = dtr_fila4(3)
            End If
        Next
        dts_estado.Clear()

        '*******''IMPRESOS' 
        str_sql5 = "select COUNT(ped_id) as 'IMPRESOS' from pedido " & _
                "where pedido.PED_ESTADO = 4 AND convert(char(10),PEDIDO.PED_FECING,103) like '" & Replace(Format(ped_fecing, "dd/MM/yyyy"), "-", "/") & "'" & _
                "and pedido.CON_NOMBRE = '" & convenio & "';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql5, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila5 In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila5(4)) Then
                impresos = 0
            Else
                impresos = dtr_fila5(4)
            End If
        Next
        dts_estado.Clear()

        '*******''ENVIADOS CORREO' 
        str_sql6 = "select COUNT(ped_id) as 'ENVIADOS' from pedido " & _
                "where pedido.PED_ESTADO = 6 AND convert(char(10),PEDIDO.PED_FECING,103) like '" & Replace(Format(ped_fecing, "dd/MM/yyyy"), "-", "/") & "'" & _
                "and pedido.CON_NOMBRE = '" & convenio & "';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql6, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila6 In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila6(5)) Then
                enviados = 0
            Else
                enviados = dtr_fila6(5)
            End If
        Next
        dts_estado.Clear()

        '*******''PACIENTES NUEVOS' 
        str_sql7 = "select COUNT(pedido.pac_id) as NUEVOS from paciente, pedido " & _
                   "where paciente.pac_id = pedido.PAC_ID and paciente.PAC_FECING between '" & ped_fecing & " 00:00:00' " & " AND '" & ped_fecing & " 23:59:59' " & " and pedido.CON_NOMBRE = '" & convenio & "';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql7, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila7 In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila7(6)) Then
                pacientes = 0
            Else
                pacientes = dtr_fila7(6)
            End If
        Next
        dts_estado.Clear()

        '*******''PACIENTES HIS' 
        str_sql8 = "select COUNT(pedido.pac_id) as HIS from paciente, pedido " & _
                   "where paciente.pac_id = pedido.PAC_ID and paciente.PAC_FECING between '" & ped_fecing & " 00:00:00' " & " AND '" & ped_fecing & " 23:59:59' " & " and pedido.PED_NOTA <> '';"
        oda_pedido.SelectCommand = New SqlCommand(str_sql7, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        For Each dtr_fila7 In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila7(6)) Then
                pac_his = 0
            Else
                pac_his = dtr_fila7(6)
            End If
        Next
        dts_estado.Clear()


        opr_conexion.sql_desconn()

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer PedEstado", Err)
        Err.Clear()
    End Sub


    Public Function LeerPedtipo(ByVal ped_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("Select ped_tipo from pedido where ped_id = " & ped_id & "", opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerPedtipo = dtr_fila(0)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer tipo pedido", Err)
        Err.Clear()
    End Function

    Public Function ExisteHistoriaClinica(ByVal pac_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select count(hic_id) from historiaClinica where pac_id = " & pac_id & ""

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteHistoriaClinica = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe Historia Clinica", Err)
        Err.Clear()
    End Function

    Public Function ExisteReceta(ByVal age_id As Integer, ByVal pac_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select count(rec_id) from receta where Age_id = " & age_id & " and pac_id = " & pac_id & ""

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteReceta = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe Receta", Err)
        Err.Clear()
    End Function

    Public Function ExisteCertAbierto(ByVal age_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select count(Age_id) from certificadoPaciente where Age_id = " & age_id & "; "

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteCertAbierto = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe Certificado", Err)
        Err.Clear()
    End Function

    Public Function ExisteInterpretacion(ByVal ped_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select count(ped_id) from res_cutaneasInterpretacion where ped_id = " & ped_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteInterpretacion = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe Interpretacion", Err)
        Err.Clear()
    End Function



    Public Function LeerHistoriaClinica(ByVal pac_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select * from historiaClinica where pac_id = " & pac_id & ""

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerHistoriaClinica = dtr_fila(0) & "º" & dtr_fila(1) & "º" & dtr_fila(2) & "º" & dtr_fila(3) & "º" & dtr_fila(4) & "º" & dtr_fila(5) & "º" & dtr_fila(6) & "º" & dtr_fila(7) & "º" & dtr_fila(8) & "º" & dtr_fila(9) & "º" & dtr_fila(10) & "º" & dtr_fila(11) & "º" & dtr_fila(12) & "º" & dtr_fila(13) & "º" & dtr_fila(14) & "º" & dtr_fila(15) & "º" & dtr_fila(16) & "º" & dtr_fila(17) & "º" & dtr_fila(18) & "º" & dtr_fila(19) & "º" & dtr_fila(20) & "º" & dtr_fila(21) & "º" & dtr_fila(22) & "º" & dtr_fila(23) & "º" & dtr_fila(24) & "º" & dtr_fila(25) & "º" & dtr_fila(26) & "º" & dtr_fila(27) & "º" & dtr_fila(28) & "º" & dtr_fila(29) & "º" & dtr_fila(30) & "º" & dtr_fila(31) & "º" & dtr_fila(32) & "º" & dtr_fila(33) & "º" & dtr_fila(34) & "º" & dtr_fila(35) & "º" & dtr_fila(36) & "º" & dtr_fila(37) & "º" & dtr_fila(38) & "º" & dtr_fila(39) & "º" & dtr_fila(40) & "º" & dtr_fila(41) & "º" & dtr_fila(42) & "º" & dtr_fila(43) & "º" & dtr_fila(44) & "º" & dtr_fila(45) & "º" & dtr_fila(46) & "º" & dtr_fila(47) & "º" & dtr_fila(48) & "º" & dtr_fila(49) & "º" & dtr_fila(50) & "º" & dtr_fila(51) & "º" & dtr_fila(52) & "º" & dtr_fila(53) & "º" & dtr_fila(54) & "º" & dtr_fila(55) & "º" & dtr_fila(56) & "º" & dtr_fila(57) & "º" & dtr_fila(58) & "º" & dtr_fila(59) & "º" & dtr_fila(60) & "º" & dtr_fila(61) & "º" & dtr_fila(62) & "º" & dtr_fila(63) & "º" & dtr_fila(64) & "º" & dtr_fila(65) & "º" & dtr_fila(66) & "º" & dtr_fila(67) & "º" & dtr_fila(68) & "º" & dtr_fila(69)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Historia Clinica", Err)
        Err.Clear()
    End Function

    Public Function LeerDemografico(ByVal pac_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select pac_id, pac_doc, PAC_APELLIDO, PAC_NOMBRE, PAC_DIRECCION, PAC_FONO, PAC_MAIL, PAC_SEXO, PAC_FECNAC, PAC_OBS, PAC_POLIZA, PAC_PAIS, provincia.PROV_NOMBRE, ciudad.CIU_NOMBRE, PAC_PROFESION " & _
                                "from paciente, provincia, ciudad " & _
                                "where provincia.PROV_ID = paciente.PROV_ID And provincia.PROV_ID = ciudad.PROV_ID And ciudad.CIU_ID = paciente.CIU_ID " & _
                                "and pac_id = " & pac_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerDemografico = dtr_fila(0) & "º" & dtr_fila(1) & "º" & dtr_fila(2) & "º" & dtr_fila(3) & "º" & dtr_fila(4) & "º" & dtr_fila(5) & "º" & dtr_fila(6) & "º" & dtr_fila(7) & "º" & dtr_fila(8) & "º" & dtr_fila(9) & "º" & dtr_fila(10) & "º" & dtr_fila(11) & "º" & dtr_fila(12) & "º" & dtr_fila(13) & "º" & dtr_fila(14)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Demografico", Err)
        Err.Clear()
    End Function


    Public Function LeerDermografismo(ByVal pac_id As Integer) As Integer
        'SOLO DERMOGRAFISMO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select distinct(con_dermografico) " & _
                            "from consultaMedico " & _
                            "where Age_id= " & pac_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerDermografismo = dtr_fila(0)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Dermografismo", Err)
        Err.Clear()
    End Function


    Public Function LeerInfante(ByVal Age_id As Integer) As Integer
        'SOLO DERMOGRAFISMO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select distinct(con_infante) " & _
                            "from consultaMedico " & _
                            "where Age_id= " & Age_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerInfante = dtr_fila(0)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Infante", Err)
        Err.Clear()
    End Function

    Public Function LeerLife(ByVal pac_id As Integer) As Integer
        'SOLO DERMOGRAFISMO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select distinct(pac_poliza) " & _
                            "from paciente " & _
                            "where pac_id= " & pac_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerLife = dtr_fila(0)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Life", Err)
        Err.Clear()
    End Function


    Public Function LeerInterpretacion(ByVal ped_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select * from res_cutaneasInterpretacion where ped_id = " & ped_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerInterpretacion = dtr_fila(0) & "º" & dtr_fila(1) & "º" & dtr_fila(2) & "º" & dtr_fila(3) & "º" & dtr_fila(4) & "º" & dtr_fila(5) & "º" & dtr_fila(6) & "º" & dtr_fila(7) & "º" & dtr_fila(8) & "º" & dtr_fila(9) & "º" & dtr_fila(10) & "º" & dtr_fila(11)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer interpretacion", Err)
        Err.Clear()
    End Function


    Public Function LeerMenu(ByVal Age_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select PRCC_INT_ALIMENTOS from res_cutaneasInterpretacion where Age_id = " & Age_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerMenu = dtr_fila(0)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer interpretacion MENU", Err)
        Err.Clear()
    End Function


    Public Function LeerResultadosInterpretacion(ByVal PED_ID As Integer, ByVal TES_PADRE As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select t.TES_NOMBRE, PRCC_RESUL_INT, rc.TES_PADRE " & _
                                "from res_cutaneas as rc, test_equipo as te, test as t " & _
                                "where t.TES_ID = te.TES_ID and  te.TEQ_ABRV_FIJA = rc.TES_ABREV and rc.ped_id = " & PED_ID & "  AND rc.TES_PADRE = " & TES_PADRE & " and PRCC_RESUL_INT <> '' " & _
                                "order by rc.TES_PADRE, rc.TES_ABREV "


        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerResultadosInterpretacion = LeerResultadosInterpretacion & Trim(dtr_fila(0)) & "º" & Trim(dtr_fila(1)) & "º" & Trim(dtr_fila(2)) & "|"
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer interpretacion", Err)
        Err.Clear()
    End Function

    Public Function LeerReceta(ByVal Age_id As Integer, ByVal pac_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select distinct(receta.rec_id), receta.rec_fecha, medico.MED_NOMBRE, receta.REC_MEDICACION, receta.REC_INDICACIONES, receta.REC_DIETA, (paciente.PAC_APELLIDO + ' ' + paciente .PAC_NOMBRE) as pac_nombre " & _
                            "from receta, cie10, medico, paciente, consultaMedico as cm " & _
                            "where receta.Age_id = " & Age_id & " and receta.pac_id = " & pac_id & " and  receta.med_id = medico.med_id and paciente.pac_id = receta.pac_id and cm.PAC_ID = paciente.PAC_ID and cm.AGE_ID = receta .AGE_ID "

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerReceta = dtr_fila(0) & "º" & dtr_fila(1) & "º" & dtr_fila(2) & "º" & dtr_fila(3) & "º" & dtr_fila(4) & "º" & dtr_fila(5) & "º" & dtr_fila(6)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Receta", Err)
        Err.Clear()
    End Function


    Public Function LeerCertAbierto(ByVal Age_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select CERP_TITULO, CERP_CUERPO from certificadoPaciente"

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerCertAbierto = Trim(dtr_fila(0)) & "º" & Trim(dtr_fila(1))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Certificado", Err)
        Err.Clear()
    End Function




    Public Function ExisteSignosVitales(ByVal pac_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select count(hic_id) from historiaClinica where pac_id = " & pac_id & ""

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteSignosVitales = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe Signos Vitales", Err)
        Err.Clear()
    End Function


    Public Function ExisteTTO(ByVal Age_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select count(Age_id) from vacunatratamiento where Age_id = " & Age_id & ""

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteTTO = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe TTo", Err)
        Err.Clear()
    End Function


    Public Function ExisteActividad(ByVal aact_tipo As String, ByVal aact_hora As String, ByVal aact_fechaIni As Date) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow

        Select Case aact_tipo
            Case "Diario"

            Case "Semanal"

            Case "Mensual"

            Case "Anual"
        End Select

        Dim str_sql As String = "select count(aact_id) from agendaActividad " & _
                        "where aact_tipo = '" & aact_tipo & "' and aact_hora = '" & aact_hora & "' and aact_fechaIni = '" & aact_fechaIni & "'"

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteActividad = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe Signos Vitales", Err)
        Err.Clear()
    End Function


    Public Function ExisteExamenFisico(ByVal pac_id As Integer) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select count(efi_id) from ExamenFisico where pac_id = " & pac_id & ""

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            ExisteExamenFisico = CInt(dtr_fila(0))
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Existe Examen fisico", Err)
        Err.Clear()
    End Function

    Public Function LeerSignosVitales(ByVal pac_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select sig_id, lis_user, sig_fecha, sig_TensArt, sig_FrecCard, sig_FrecResp, sig_Temp, sig_Satur, sig_Peso, sig_Audiometria " & _
                         "from SignosVitales where pac_id = " & pac_id & " order by sig_id asc"


        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerSignosVitales = dtr_fila(0) & "|" & dtr_fila(1) & "|" & dtr_fila(2) & "|" & dtr_fila(3) & "|" & dtr_fila(4) & "|" & dtr_fila(5) & "|" & dtr_fila(6) & "|" & dtr_fila(7) & "|" & dtr_fila(8) & "|" & dtr_fila(9)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Signos Vitales", Err)
        Err.Clear()
    End Function


    Public Function LeerFactoresRiesgo(ByVal pac_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select FR_CIGARRO, FR_ALCOHOL, FR_SEDENTARISMO, FR_DROGAS, lis_user " & _
                         "from FACTORESRIESGO where pac_id = " & pac_id & ""

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerFactoresRiesgo = dtr_fila(0) & "|" & dtr_fila(1) & "|" & dtr_fila(2) & "|" & dtr_fila(3)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Factores Riesgo", Err)
        Err.Clear()
    End Function

    Public Function LeerTTO(ByVal Age_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select age_id, pac_id, med_id, vac_id, tto_Cantidad, tto_fecha, tto_plan " & _
                            "from vacunatratamiento" & _
                            "where Age_id = " & Age_id & " order by Age_id asc"


        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerTTO = dtr_fila(0) & "|" & dtr_fila(1) & "|" & dtr_fila(2) & "|" & dtr_fila(3) & "|" & dtr_fila(4) & "|" & dtr_fila(5) & "|" & dtr_fila(6)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Signos Vitales", Err)
        Err.Clear()
    End Function


    Public Function LeerExamenFisico(ByVal pac_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select efi_id, efi_fecha, efi_cabeza, efi_oidos, efi_nariz, efi_orofaringe, efi_cuello, efi_torax, efi_pulmones, efi_corazon, efi_abdomen, efi_extremidades " & _
                         "from ExamenFisico where pac_id = " & pac_id & " order by efi_id asc"


        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerExamenFisico = dtr_fila(0) & "|" & dtr_fila(1) & "|" & dtr_fila(2) & "|" & dtr_fila(3) & "|" & dtr_fila(4) & "|" & dtr_fila(5) & "|" & dtr_fila(6) & "|" & dtr_fila(7) & "|" & dtr_fila(8) & "|" & dtr_fila(9) & "|" & dtr_fila(10) & "|" & dtr_fila(11)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Examen fisico", Err)
        Err.Clear()
    End Function


    Public Function LeerOcupacion(ByVal pac_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select ocupacion.ocu_descripcion, ocu_id from ocupacion where ocupacion .ocu_id = " & pac_id

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerOcupacion = dtr_fila(0).ToString.PadRight(100) & dtr_fila(1).ToString.PadRight(10)
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer ocupacion", Err)
        Err.Clear()
    End Function

    Public Function LeerSolicitud(ByVal Age_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select sol_texto from medicoSolicitud where age_id =  " & Age_id & ""
                                
        opr_conexion.sql_conectar()
        LeerSolicitud = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar
        opr_Conexion.sql_desconn()
        Exit Function

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer SOlicutud", Err)
        Err.Clear()
    End Function

    Public Function LeerAgeIdMedico(ByVal Med_id As Integer) As String
        On Error GoTo MsgError

        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select sol_texto from medicoSolicitud where age_id =  " & Med_id & ""

        opr_conexion.sql_conectar()
        LeerAgeIdMedico = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer SOlicutud", Err)
        Err.Clear()
    End Function


    Public Function LeerComposicion(ByVal Ser_id As String) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select vc.COM_DESC " & _
                                "from serieComposicion as sc, vacunaComposicion as vc " & _
                                "where sc.COM_ID = vc.COM_ID  and sc.SER_ID = '" & Ser_id & "' " & _
                                "order by vc.COM_DESC"

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            If IsDBNull(dtr_fila(0).ToString) Then
                LeerComposicion = LeerComposicion & "" & ", "
            Else
                LeerComposicion = LeerComposicion & Trim(dtr_fila(0).ToString) & ", "
            End If
        Next
        Return Mid(Replace(Trim(LeerComposicion), vbCrLf, ""), 1, Len(Trim(LeerComposicion)) - 9)
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Composicion", Err)
        Err.Clear()
    End Function

    Public Function LeerDatosVac(ByVal I_PRD_ID As String, ByVal I_MOD_LOTE As String) As String

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select I_MOD_FECVEN " & _
                                "from i_movimiento_detalle " & _
                                "where I_PRD_ID = '" & I_PRD_ID & "' and I_MOD_LOTE = '" & I_MOD_LOTE & "'"

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerDatosVac = dtr_fila(0).ToString
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer LOTE", Err)
        Err.Clear()
    End Function
    Public Function LeerTecnica(ByVal VAC_ID As String) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = "select v.VAC_ID, vt.VACT_DESC " & _
                                "from vacunaTecnica as vt, vacuna as v " & _
                                "where vt.VACT_ID = v.VACT_ID and v.VAC_ID = '" & VAC_ID & "'"

        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerTecnica = dtr_fila(1).ToString
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer tecnica", Err)
        Err.Clear()
    End Function


    Public Function LeerAreas(ByVal areas As String) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("Select are_nombre from area where are_id in (" & areas & ");", opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerAreas = dtr_fila(0) & ","
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Areas", Err)
        Err.Clear()
    End Function




    Sub LlenarGridPedido(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date)
        'funcion que llena en un datagrid los datos de los pedidos
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedido(fec_ini, fec_fin).Tables("Registros")
    End Sub


    Sub LlenarGridPedidoHistorico(ByRef data As DataView, ByVal pac_id As Integer)
        'funcion que llena en un datagrid los datos de los pedidos
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedidoHistorico(pac_id).Tables("Registros")
    End Sub


    Sub LlenarGridPedidoHistoricoExamenes(ByRef data As DataView, ByVal ped_id As Long)
        'funcion que llena en un datagrid los datos de los pedidos
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedidoHistoricoExamenes(ped_id).Tables("RegistrosExa")
    End Sub


    Sub ordena_apellido(ByVal apellido As String, ByRef data As DataView)
        'funci�n que orderna por apellido al dataview
        With data
            If Trim(apellido) <> "" Then
                .RowFilter = "pac_apellido like '" & Trim(apellido) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "ped_fecing desc"
        End With
    End Sub

    Sub ordena_pedidoapellido(ByVal apellido As String, ByRef data As DataView)
        'funcion que orderna por apellido al dataview
        With data
            If Trim(apellido) <> "" Then
                .RowFilter = "PACIENTE like '" & Trim(apellido) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "ped_fecing desc"
        End With
    End Sub

    Sub ordena_cedula(ByVal cedula As String, ByRef data As DataView)
        'funcion que orderna por pedido al dataview
        With data
            If Trim(cedula) <> "" Then
                .RowFilter = "CI like '" & Trim(cedula)
            Else
                .RowFilter = ""
            End If
            .Sort = "CI"
        End With
    End Sub

    Sub ordena_hclinica(ByVal hclinica As String, ByRef data As DataView)
        'funcion que orderna la h. clinica al dataview
        With data
            If Trim(hclinica) <> "" Then
                .RowFilter = "pac_hist_clinica like '" & hclinica & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "pac_hist_clinica"
        End With
    End Sub

    Sub ordena_turno(ByVal turno As Integer, ByRef data As DataView, Optional ByVal fecha As String = "")
        'funci�n que orderna por turno al dataview
        With data
            If Trim(turno) <> "" Then
                .RowFilter = "ped_turno = " & Trim(turno) '& " and ped_fecing like '" & Format(CDate(fecha), "dd/MM/yyyy") & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = "ped_fecing desc"
        End With
    End Sub

    Public Function LeerUnPedido(ByVal ped_id As Long) As DataSet
        'funcion que retorna un dataset los datos de un pedido ,recibe el codigo del pedido
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("Select ped_fecing, ped_medicacion, ped_antecedente, ped_tipo, pac_apellido, pac_doc, pac_nombre, pac_direccion, pac_fono, pac_hist_clinica, medico.med_id as med_id, med_nombre, con_nombre, pac_tipodoc, lab_nombre, laboratorio.lab_id as lab_id, ped_turno, pac_hist_clinica, ped_servicio, ped_estado, pac_obs, pac_grado, pac_usafecnac, pac_fecnac, ped_recibo, pac_sexo, secuencias.sec_desde, secuencias.sec_hasta, med_mail, PED_NUMAUX, ped_nota, ped_obs, paciente.pac_id from paciente, pedido, medico, laboratorio, secuencias where laboratorio.lab_id=pedido.lab_id and pedido.med_id=medico.med_id and secuencias.sec_nombre = pedido.PED_TIPO and pedido.pac_id=paciente.pac_id and ped_id=" & ped_id, opr_conexion.conn_sql)
        LeerUnPedido = New DataSet()
        oda_pedido.Fill(LeerUnPedido, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Un Pedido", Err)
        Err.Clear()
    End Function

    Public Sub LlenarGridUnPedido(ByRef dtt_pedido As DataTable, ByVal con_nombre As String, ByVal ped_id As Long, Optional ByVal nuevo As Byte = 0)
        'llena en un grid los datos de un pedido especifico
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataReader
        Dim opr_perfil As New Cls_Perfil()
        Dim str_sql As String
        opr_conexion.sql_conectar()

        'str_sql = "SELECT perfil.PER_ID, perfil.PER_NOMBRE " & _
        '"FROM pedido_detalle " & _
        '"LEFT OUTER JOIN perfil ON (pedido_detalle.PER_ID = perfil.PER_ID) " & _
        '"INNER JOIN pedido_detalle_desglosado ON (pedido_detalle.PED_ID = pedido_detalle_desglosado.PED_ID) AND (pedido_detalle.PER_ID = pedido_detalle_desglosado.PER_ID) " & _
        '"WHERE " & _
        '"pedido_detalle_desglosado.ped_id=" & ped_id & " " & _
        '"GROUP BY perfil.PER_NOMBRE " & _
        '"ORDER BY perfil.PER_NOMBRE "
        'oda_pedido = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        'While oda_pedido.Read
        '    'para comprobar perfil 
        '    Dim dtr_fila3 As DataRow = dtt_pedido.NewRow
        '    Dim LISTATEST As String
        '    Dim ESTADOTEST As Short
        '    dtr_fila3(0) = 1
        '    dtr_fila3(1) = oda_pedido.GetValue(1).ToString
        '    dtr_fila3(2) = oda_pedido.GetValue(0).ToString
        '    dtr_fila3(3) = opr_perfil.LeerPrecioPerfil(oda_pedido.GetValue(1).ToString, con_nombre) 'RETORNA EL PRECIO POR PERFIL Y CONVENIO
        '    dtr_fila3(4) = "P"
        '    ActualizaPerfilGrid(oda_pedido.GetValue(0), nuevo, LISTATEST, ESTADOTEST, ped_id)
        '    dtr_fila3(5) = ESTADOTEST    'es nuevo o no esta en la lista de trabajo o es modificable
        '    dtr_fila3(6) = LISTATEST   'lista de test
        '    dtr_fila3(7) = 0    'antiguo
        '    dtt_pedido.Rows.Add(dtr_fila3)
        'End While

        'oda_pedido.Close()

        str_sql = "SELECT AREA.ARE_NOMBRE, test.TES_ID, test.TES_NOMBRE, lista_trabajo.LIS_RESESTADO, pedido_detalle_desglosado.LIP_PRECIO, lista_precio.LIP_PRECIO as LIP_PRECIOU, pedido_detalle.PEE_CANTIDAD " & _
        "FROM pedido_detalle_desglosado " & _
        "INNER JOIN pedido_detalle ON (pedido_detalle_desglosado.PED_ID = pedido_detalle.PED_ID) AND (pedido_detalle_desglosado.TES_ID = pedido_detalle.TES_ID) " & _
        "LEFT OUTER JOIN lista_trabajo ON (pedido_detalle.PED_ID = lista_trabajo.PED_ID) AND (pedido_detalle.TES_ID = lista_trabajo.TES_ID) " & _
        "LEFT OUTER JOIN test ON (pedido_detalle_desglosado.TES_ID = test.TES_ID) " & _
        "LEFT OUTER JOIN lista_precio ON (test.TES_ID = lista_precio.TES_ID) INNER JOIN AREA	 on AREA.ARE_ID = test.ARE_ID " & _
        "WHERE " & _
        "pedido_detalle_desglosado.ped_id=" & ped_id & " AND " & _
        "lista_precio.con_nombre='" & con_nombre & "'"
        oda_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While oda_pedido.Read
            'para comprobar TEST
            Dim dtr_fila3 As DataRow = dtt_pedido.NewRow
            dtr_fila3(0) = oda_pedido.GetValue(0).ToString
            dtr_fila3(1) = Val((oda_pedido.GetValue(6).ToString))
            dtr_fila3(2) = oda_pedido.GetValue(2).ToString
            dtr_fila3(3) = oda_pedido.GetValue(1).ToString
            dtr_fila3(4) = Val((oda_pedido.GetValue(5).ToString))
            dtr_fila3(5) = "T"
            'estado
            dtr_fila3(6) = 0    'es nuevo o no esta en la lista de trabajo o es modificable
            If nuevo = 0 Then
                If Not IsDBNull(oda_pedido.GetValue(2)) Then    'el test esta incluido en la lista de trabajo 
                    'si el test no esta procesado, validado o enviado al equipo, entonces se puede eliminar del pedido
                    'lista_trabajo (0 ingresado, 1 procesado, 2 validado , 3 enviado al equipo, 4 rechazado)
                    'pedido_detalle_desglosado  (0 no procesado, 1 procesado, 2 repetir)
                    If oda_pedido.GetValue(3) = 1 OrElse oda_pedido.GetValue(3) = 2 OrElse oda_pedido.GetValue(3) = 3 Then
                        'el test tiene estado de validado entonces ya no se puede modificar(eliminar)
                        dtr_fila3(6) = 1
                    Else
                        'se puede modificar, pero advierte que se encuentra utilizado
                        If oda_pedido.GetValue(3) = 4 Then dtr_fila3(6) = 2
                    End If
                End If
            End If
            'lista de test
            dtr_fila3(7) = dtr_fila3(2)
            dtr_fila3(8) = 0    'antiguo
            dtr_fila3(9) = Val((oda_pedido.GetValue(6).ToString)) * Val((oda_pedido.GetValue(5).ToString))
            dtt_pedido.Rows.Add(dtr_fila3)
        End While
        oda_pedido.Close()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Grid Un Pedido", Err)
        Err.Clear()
    End Sub

    Public Sub LlenarGridUnPedidoHistorico(ByRef dtt_pedido As DataTable, ByVal con_nombre As String, ByVal ped_id As Long, Optional ByVal nuevo As Byte = 0)
        'llena en un grid los datos de un pedido especifico
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataReader
        Dim opr_perfil As New Cls_Perfil()
        Dim str_sql As String
        opr_conexion.sql_conectar()


        str_sql = "SELECT AREA.ARE_NOMBRE, test.TES_ID, test.TES_NOMBRE " & _
        "FROM pedido_detalle_desglosado, test, area " & _
        "where pedido_detalle_desglosado.TES_ID = test.tes_id And test.ARE_ID = area.ARE_ID And pedido_detalle_desglosado.ped_id = " & ped_id

        oda_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader


        While oda_pedido.Read
            'para comprobar TEST
            Dim dtr_fila3 As DataRow = dtt_pedido.NewRow
            dtr_fila3(0) = oda_pedido.GetString(0).ToString
            dtr_fila3(1) = oda_pedido.GetValue(1).ToString
            dtr_fila3(2) = oda_pedido.GetString(2).ToString


            dtt_pedido.Rows.Add(dtr_fila3)
        End While
        oda_pedido.Close()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Grid Un Pedido", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizaPerfilGrid(ByVal Perfilid As Short, ByVal nuevo As Byte, ByRef LISTATEST As String, ByRef ESTADOTEST As Short, Optional ByVal pedid As Long = 0)
        'funci�n que consulta los test por perfil y los estados en la lista de trabajo
        'y luego los llena para permitir o evitar modificaciones en el grid del pedido
        'devuelve la lista de test por perfil de la siguiente manera: 1,2,3,4,etc
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataReader
        Dim str_sql As String
        opr_conexion.sql_conectar()

        LISTATEST = ""
        ESTADOTEST = 0

        'lista de test
        str_sql = "SELECT TES_ID FROM perfil_test where per_id=" & Perfilid
        oda_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While oda_pedido.Read
            LISTATEST = LISTATEST & "," & oda_pedido.GetValue(0)
        End While
        If LISTATEST.StartsWith(",") Then LISTATEST = LISTATEST.Remove(0, 1)

        oda_pedido.Close()

        If nuevo = 0 Then
            'estado en la lista de trabajo por test
            str_sql = "SELECT LIS_RESESTADO FROM lista_trabajo where ped_id=" & pedid & "  and  " & "per_id=" & Perfilid
            oda_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
            Dim boo1 As Boolean = False
            Dim boo2 As Boolean = False
            While oda_pedido.Read
                If oda_pedido.GetValue(0) = 1 OrElse oda_pedido.GetValue(0) = 2 OrElse oda_pedido.GetValue(0) = 3 Then
                    'el test tiene estado de validado entonces ya no se puede modificar(eliminar)
                    boo1 = True
                    Exit While
                Else
                    'se puede modificar, pero advierte que se encuentra utilizado
                    If oda_pedido.GetValue(0) = 4 Then boo2 = True
                End If
            End While
            If boo1 Then
                ESTADOTEST = 1
            Else
                If boo2 Then ESTADOTEST = 2
            End If
            oda_pedido.Close()
        End If
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar Grid Perfil Un Pedido", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarResTesPedido(ByVal ped_id As Integer, ByVal abrev As String)
        'Procedimiento para eliminar el o los resultados de un test de un pedido que se va a repetir
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql
        opr_Conexion.sql_conectar()
        str_sql = "delete from RES_PROCESADOS where ped_id = " & ped_id & " and tes_abrev = '" & abrev & "'"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar resultado a repetir", "Test=" & abrev, g_sng_user, ped_id, "", abrev)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar ResTes Pedido", Err)
        Err.Clear()
    End Sub


    Public Sub EliminarAuxHis(ByVal ped_id As Integer)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql
        opr_Conexion.sql_conectar()
        str_sql = "delete from AUX_HIS where aux_ped_id = " & ped_id & " "
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar resultado AUX_HIS", "", g_sng_user, ped_id, "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar resultado AUX_HIS", Err)
        Err.Clear()
    End Sub


    Public Sub EliminarTesLista(ByVal ped_id As Integer, ByVal tes_id As Integer)
        'Procedimiento para eliminar un test de un pedido de la lista de trabajo
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql
        opr_Conexion.sql_conectar()
        str_sql = "delete from LISTA_TRABAJO where ped_id = " & ped_id & " and tes_id = " & tes_id & ""
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar resultado a repetir", "Pedido=" & ped_id, g_sng_user, ped_id, "", tes_id)
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar TesLista", Err)
        Err.Clear()
    End Sub

    'Funcion para consultar el id del paciente para que pueda ser actualizado al modificar.
    Public Function consultapaciente(ByVal pac_id As Integer) As Integer
        'funcion que devuelve un numero del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        consultapaciente = CLng(New SqlCommand("SELECT PAC_ID FROM PACIENTE WHERE (PAC_APELLIDO+' '+PAC_NOMBRE) = " & pac_id & "", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Paciente", Err)
        Err.Clear()

    End Function


    'Funcion para consultar el id del paciente para que pueda ser actualizado al modificar.
    Public Function consultapaciente(ByVal pac_nombres As String) As Integer
        'funcion que devuelve un numero del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        consultapaciente = CLng(New SqlCommand("SELECT PAC_ID FROM PACIENTE WHERE (PAC_APELLIDO+' '+PAC_NOMBRE) = '" & pac_nombres & "'", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Paciente", Err)
        Err.Clear()

    End Function


    Public Function consultapacienteHC(ByVal pac_id As Integer) As Integer
        'funcion que devuelve un numero del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        consultapacienteHC = CInt(New SqlCommand("SELECT HIC_ID FROM HISTORIACLINICA WHERE hic_cli = " & pac_id & "", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Paciente HC", Err)
        Err.Clear()

    End Function


    Public Function consultaArchivo(ByVal ped_id As Long, ByVal pdf_examen As String) As String
        'funcion que devuelve un numero del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        consultaArchivo = New SqlCommand("select (ptopdf.pdf_orden + ' - ' +paciente.PAC_APELLIDO + ' ' + paciente.PAC_NOMBRE + ' (' + ptopdf.pdf_examen + ')' ) from ptopdf, pedido, paciente where ptopdf.ped_id = " & ped_id & " and ptopdf.pdf_examen = '" & pdf_examen & "' and ptopdf.ped_id = pedido.PED_ID and pedido.PAC_ID = paciente.PAC_ID; ", opr_conexion.conn_sql).ExecuteScalar
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        consultaArchivo = ""
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Archivo", Err)
        'Err.Clear()

    End Function


    Public Function consultapacientePEDIDO(ByVal ped_id As Long) As Integer
        'funcion que devuelve un numero del paciente
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        consultapacientePEDIDO = New SqlCommand("SELECT PAC_ID FROM pedido WHERE ped_id = " & ped_id, opr_conexion.conn_sql).ExecuteScalar
        If consultapacientePEDIDO = 0 Then
            consultapacientePEDIDO = -1
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Paciente", Err)
        Err.Clear()

    End Function


    Public Function ActualizarPedido(ByVal frm_formulario As frm_Pedido, Optional ByVal Aorden As Integer = 0) As Byte
        'funcion que actualiza los datos d un pedido, recibe por valor un formularios
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As New SqlCommand()
        Dim odbc_strsql1 As New SqlCommand()
        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        Dim int_paciente As Integer = 0
        Dim dtr_fila As DataRow
        Dim i As Integer
        Dim shr_estado As Short 'Variable que almacenara el estado anterior del pedido para modificarlo.
        Dim oper_fac As New Cls_Factura()

        Dim arregloParam(), arregloIDParam() As String
        Dim z, x As Short

        Dim TIENE_AB_CALC() As String
        Dim arregloID_AB() As String
        Dim oper_trabajo As New Cls_Trabajo()
        Dim unidad As String = Nothing
        Dim prioridad As String() = Nothing
        prioridad = Split(frm_formulario.cmb_convenio.Text, "/")
        Dim seC_nombre, sec_inicio, sec_fin As String
        Dim turno As String = Nothing
        Dim auditoria_ex As String = Nothing

        shr_estado = LeerPedEstado(CInt(frm_formulario.Tag))
        int_paciente = consultapaciente(frm_formulario.lbl_nombres.Text)
        'int_paciente = consultapacientePEDIDO(g_lng_ped_id)

        Dim fac_id As Integer = oper_fac.ObtieneFac_id(CLng(frm_formulario.Tag))
        Dim fad_id As Integer = oper_fac.LeerMaxFad_id(fac_id) + 1
        Dim fac_total As Double
        If frm_formulario.rbtn_pedido.Checked = True Then



            seC_nombre = Trim(prioridad(0).ToString)
            sec_inicio = CInt(prioridad(1).ToString)
            sec_fin = CInt(prioridad(2).ToString)
            If seC_nombre <> opr_resul.LeerNombreConvenio(g_lng_ped_id) Then
                turno = Format(LeerMaxturno(seC_nombre, Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy"), Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)), True), "00#")

                If turno <> Nothing Then
                    If CLng(turno) > CLng(sec_fin) Then
                        VisualizaMensaje("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", g_tiempo)
                        ''MsgBox("Ud. ha excedido el numero permitido de pedidos para " & sec_nombre & ".  Pongase en contacto con el Administrador del sistema.", MsgBoxStyle.Information, "ANALISYS")
                        Exit Function
                    Else
                        If CLng(turno) < CLng(sec_inicio) Then
                            turno = sec_inicio
                        End If
                        'SQL_sTR
                    End If
                    'Else
                    '   turno = Trim(frm_formulario.cmb_turno.Text)
                End If
            Else
                turno = Trim(frm_formulario.cmb_turno.Text)
            End If




            If shr_estado = 9 Then   'SI ESTABA COMO RECIBO Y AHORA ES PEDIDO
                str_sql = "update pedido " & _
                          "set pac_id =" & int_paciente & ", ped_tipo='" & Trim(prioridad(0).ToString()) & _
                          "', med_id='" & Val(frm_formulario.cmb_medico.Text.Substring(50, 10)) & _
                          "', ped_fecing ='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & " " & Format(Now, "HH:mm:ss") & _
                          "', ped_antecedente ='" & frm_formulario.txt_recibo.Text & _
                          "', ped_medicacion='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & _
                          "', con_nombre='" & Trim(prioridad(0).ToString()) & _
                          "', lab_id=" & Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)) & _
                          ",  ped_turno=" & turno & _
                          ", ped_estado = 0, ped_servicio = '" & frm_formulario.cmb_servicios.Text & "', ped_recibo = '" & g_invitado & "', ped_prof = " & Aorden & ", ped_obs = '" & Trim(frm_formulario.Ctl_txt_ped_antecedente.Text) & "' where ped_id=" & frm_formulario.Tag
            Else        'SI ERA PEDIDO Y SOLO SE CAMBIO ALGUN DATO.
                If frm_formulario.txt_NumAux.Text <> "" Then
                    str_sql = "update pedido " & _
                              "set pac_id =" & int_paciente & ", ped_tipo='" & Trim(prioridad(0).ToString()) & _
                              "', med_id='" & Val(frm_formulario.cmb_medico.Text.Substring(50, 5)) & _
                              "', ped_fecing ='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & " " & Format(Now, "HH:mm:ss") & _
                              "', ped_antecedente='" & frm_formulario.txt_recibo.Text & _
                              "', ped_medicacion='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & _
                              "', ped_origen= getdate()" & _
                              ", con_nombre='" & Trim(prioridad(0).ToString()) & _
                              "', lab_id=" & Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)) & _
                              ", ped_turno=" & turno & _
                                ", ped_servicio = '" & frm_formulario.cmb_servicios.Text & "', ped_recibo = '" & g_invitado & "', ped_prof = " & Aorden & ", PED_NUMAUX = " & frm_formulario.txt_NumAux.Text & " , ped_obs = '" & Trim(frm_formulario.Ctl_txt_ped_antecedente.Text) & "' where ped_id=" & frm_formulario.Tag
                Else
                    'BUSCO NUEVOS DATOS DE FACTURA POR SI SE MODIFICO'
                    'Frm_Factura .

                    'Frm_Factura.Llena_detalle_factura(oper_fac.ObtieneNumFactura(g_lng_ped_id))

                    str_sql = "update pedido " & _
                          "set pac_id =" & int_paciente & ", ped_tipo='" & Trim(prioridad(0).ToString()) & _
                          "', med_id='" & Val(frm_formulario.cmb_medico.Text.Substring(50, 10)) & _
                          "', ped_fecing ='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & " " & Format(Now, "HH:mm:ss") & _
                          "', ped_antecedente='" & frm_formulario.txt_recibo.Text & _
                          "', ped_medicacion='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & _
                          "', ped_origen= getdate()" & _
                          ", con_nombre='" & Trim(prioridad(0).ToString()) & _
                          "', lab_id=" & Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)) & _
                          ", ped_turno=" & turno & _
                            ", ped_servicio = '" & frm_formulario.cmb_servicios.Text & "', ped_recibo = '" & g_invitado & "', ped_prof = " & Aorden & " , ped_obs = '" & Trim(frm_formulario.Ctl_txt_ped_antecedente.Text) & "' where ped_id=" & frm_formulario.Tag
                End If
                '", ped_servicio = '" & frm_formulario.cmb_servicios.Text & "', ped_recibo = '" & g_invitado & "', ped_prof = " & Aorden & " where ped_id=" & frm_formulario.Tag
            End If
        Else
            str_sql = "update pedido " & _
                 "set pac_id =" & int_paciente & ", ped_tipo='" & Trim(prioridad(0).ToString()) & _
                 "', med_id='" & Val(frm_formulario.cmb_medico.Text.Substring(50, 10)) & _
                "', ped_fecing ='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & " " & Format(Now, "HH:mm:ss") & _
                "', ped_antecedente='" & frm_formulario.txt_recibo.Text & _
                 "', ped_medicacion='" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & _
                 "', con_nombre='" & Trim(prioridad(0).ToString()) & _
                 "', lab_id=" & Val(frm_formulario.cmb_laboratorio.Text.Substring(100, 10)) & _
                 ",  ped_turno=" & frm_formulario.cmb_turno.Text & _
                 ", ped_estado = 9, ped_servicio = '" & frm_formulario.cmb_servicios.Text & "', ped_obs = '" & Trim(frm_formulario.Ctl_txt_ped_antecedente.Text) & "' where ped_id=" & frm_formulario.Tag
        End If
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        odbc_strsql.Connection = opr_conexion.conn_sql
        odbc_strsql.Transaction = odbc_trans
        odbc_strsql.CommandText = str_sql
        odbc_strsql.ExecuteNonQuery()
        str_sql = "update lista_trabajo set lis_fecing = '" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & "' where ped_id = " & frm_formulario.Tag & ";"
        odbc_strsql.CommandText = str_sql
        odbc_strsql.ExecuteNonQuery()

        'actualizo  paciente y observacion (ENFERMEDAD):
        Dim ape_nom As String()
        Dim ape As String = Nothing
        Dim nom As String = Nothing

        ape_nom = Split(Trim(frm_formulario.lbl_nombres.Text), " ")

        Select Case UBound(ape_nom) + 1
            Case 2
                ape = ape_nom(0)
                nom = ape_nom(1)

            Case 3
                ape = ape_nom(0) & " " & ape_nom(1)
                nom = ape_nom(2)

            Case 4
                ape = ape_nom(0) & " " & ape_nom(1)
                nom = ape_nom(2) & " " & ape_nom(3)

            Case 5
                ape = ape_nom(0) & " " & ape_nom(1)
                nom = ape_nom(2) & " " & ape_nom(3) & " " & ape_nom(4)
        End Select

        'str_sql = "update paciente set pac_apellido = '" & ape & "', pac_nombre = '" & nom & "', pac_direccion = '" & Trim(frm_formulario.lbl_direccion_fono.Text) & "', pac_fono = '" & Trim(frm_formulario.lbl_fono.Text) & "',  pac_sexo = '" & Trim(frm_formulario.lbl_genero.Text) & "', pac_obs = '" & Trim(frm_formulario.txt_obs_pac.Text) & "', pac_grado = '" & Trim(frm_formulario.cmb_afiliacion.Text) & "' where pac_id = " & int_paciente & ";"
        'odbc_strsql.CommandText = str_sql
        'odbc_strsql.ExecuteNonQuery()


        'estado del pedido   2 ANULADO , 1, 0 ESPERA DE SER ASIGNADO, 3 PROCESADO LISTO
        'lis_resestado=0,1,2,3,4     lista_trabajo
4:      'pdd_estado=0 o 2            pedido_detalle_desglosado  (0 no procesado, 2 = repetir)
        If Not (frm_formulario.pedidoborra Is Nothing) Then
            'entra cuando se a borrado test del pedido
            For i = 0 To UBound(frm_formulario.pedidoborra)
                Dim arr_tmp() As String = Split(frm_formulario.pedidoborra(i), ",")
                If arr_tmp(0) = "T" Then
                    odbc_strsql.CommandText = "Delete from pedido_detalle where ped_id=" & frm_formulario.Tag & " and tes_id=" & arr_tmp(1) & "  and  per_id is NULL"
                    odbc_strsql.ExecuteNonQuery()
                    odbc_strsql.CommandText = "Delete from pedido_detalle_desglosado where ped_id=" & frm_formulario.Tag & " and tes_id=" & arr_tmp(1) & "  and  per_id is NULL"
                    odbc_strsql.ExecuteNonQuery()
                    odbc_strsql.CommandText = "Delete from factura_detalle where fac_id=" & fac_id & " and tes_id=" & arr_tmp(1) & ""
                    odbc_strsql.ExecuteNonQuery()
                    'se recorre la lista de trabajo con los pedidos 
                    Dim str_sentencias() As String = Nothing
                    Dim sht_j As Short = 0
                    Dim sht_h As Short = 0
                    'If arr_tmp(1) = "400230" Then  'EN CASO DE EMO, TIENE QUE ELIMINARSE
                    '    'borra todas las posibles coincidencias con los equipos de emo
                    '    str_sql = "Delete from res_procesados where ped_id=" & frm_formulario.Tag & " and sni_nombre='COM7'"
                    '    odbc_strsql.CommandText = str_sql
                    '    odbc_strsql.ExecuteNonQuery()
                    'End If

                    auditoria_ex = auditoria_ex & arr_tmp(1) & ","

                    Dim odr_lista As SqlDataReader = New SqlCommand("Select equ_id from lista_trabajo where ped_id=" & frm_formulario.Tag & " and tes_id=" & arr_tmp(1) & " and per_id is NULL and equ_id is not NULL", opr_conexion.conn_sql, odbc_trans).ExecuteReader
                    While odr_lista.Read
                        Dim opr_archivos As New Cls_Archivos()
                        Dim opr_equipos As New Cls_equipos()
                        Dim str_abrev As String = opr_archivos.Abrev_TestAuto(arr_tmp(1))
                        Dim str_sni As String = opr_equipos.LeerSNIEquipo(odr_lista.GetValue(0))
                        'se borran las por abreviatura y sni que coincida, pero de ser el caso BIOMETRIA HEMATICA, se borr�n de acuerdo
                        'al equipo y las siglas que son fijas para los equipos celldyn 1700 y cell3500
                        'OJO: se almacena en un arreglo de string, debido a que no se puede ejecutar ningun otro
                        'commando, mientras el datareader est� tomado la base
                        ReDim Preserve str_sentencias(sht_j)
                        str_sentencias(sht_j) = "Delete from res_procesados where ped_id=" & frm_formulario.Tag & " and tes_padre= " & arr_tmp(1) & " and sni_nombre='" & str_sni & "'"
                        'str_sentencias(sht_h) = "Delete from res_historicos where ped_id=" & frm_formulario.Tag
                        sht_j = sht_j + 1
                        'sht_h = sht_h + 1
                    End While
                    odr_lista.Close()
                    If Not (str_sentencias Is Nothing) Then
                        'borra todos los datos de res_procesados
                        For sht_j = 0 To UBound(str_sentencias)
                            odbc_strsql.CommandText = str_sentencias(sht_j)
                            odbc_strsql.ExecuteNonQuery()

                            '   odbc_strsql1.CommandText = str_sentencias(sht_h)
                            '  odbc_strsql1.ExecuteNonQuery()
                        Next
                    End If
                    odbc_strsql.CommandText = "Delete from lista_trabajo where ped_id=" & frm_formulario.Tag & " and tes_id=" & arr_tmp(1) & "  and  per_id is NULL"
                    odbc_strsql.ExecuteNonQuery()
                Else
                    odbc_strsql.CommandText = "Delete from pedido_detalle where ped_id=" & frm_formulario.Tag & " and per_id=" & arr_tmp(1)
                    odbc_strsql.ExecuteNonQuery()
                    odbc_strsql.CommandText = "Delete from pedido_detalle_desglosado where ped_id=" & frm_formulario.Tag & " and per_id=" & arr_tmp(1)
                    odbc_strsql.ExecuteNonQuery()
                    'se recorre la lista de trabajo con los pedidos 
                    Dim str_sentencias() As String = Nothing
                    Dim sht_j As Short = 0
                    Dim sht_h As Short = 0

                    auditoria_ex = auditoria_ex & arr_tmp(1) & ","

                    Dim odr_lista As SqlDataReader = New SqlCommand("Select equ_id, tes_id from lista_trabajo where ped_id=" & frm_formulario.Tag & " and per_id=" & arr_tmp(1) & " and equ_id is not NULL", opr_conexion.conn_sql, odbc_trans).ExecuteReader
                    While odr_lista.Read
                        Dim opr_archivos As New Cls_Archivos()
                        Dim opr_equipos As New Cls_equipos()
                        Dim str_abrev As String = opr_archivos.Abrev_TestAuto(odr_lista.GetValue(1))
                        Dim str_sni As String = opr_equipos.LeerSNIEquipo(odr_lista.GetValue(0))
                        'se borran las por abreviatura y sni que coincida, pero de ser el caso BIOMETRIA HEMATICA, se borr�n de acuerdo
                        'al equipo y las siglas que son fijas para los equipos celldyn 1700 y cell3500
                        'OJO: se almacena en un arreglo de string, debido a que no se puede ejecutar ningun otro
                        'commando, mientras el datareader est� tomado la base
                        ReDim Preserve str_sentencias(sht_j)

                        str_sentencias(sht_j) = "Delete from res_procesados where ped_id=" & frm_formulario.Tag & " and tes_Padre='" & arr_tmp(1) & "' and sni_nombre='" & str_sni & "'"

                        'str_sentencias(sht_h) = "Delete from res_historicos where ped_id=" & frm_formulario.Tag

                        sht_j = sht_j + 1
                        'sht_h = sht_h + 1

                    End While
                    odr_lista.Close()
                    If Not (str_sentencias Is Nothing) Then
                        'borra todos los datos de res_procesados
                        For sht_j = 0 To UBound(str_sentencias)
                            odbc_strsql.CommandText = str_sentencias(sht_j)
                            odbc_strsql.ExecuteNonQuery()

                            '   odbc_strsql1.CommandText = str_sentencias(sht_h)
                            '  odbc_strsql1.ExecuteNonQuery()
                        Next
                    End If
                    odbc_strsql.CommandText = "Delete from lista_trabajo where ped_id=" & frm_formulario.Tag & " and per_id=" & arr_tmp(1)
                    odbc_strsql.ExecuteNonQuery()
                End If

            Next
        End If
        'consulto el indice para el detalle
        Dim lng_peeid As Short = CShort(New SqlCommand("Select isnull(Max(pee_id),0) from pedido_detalle where ped_id=" & frm_formulario.Tag, opr_conexion.conn_sql, odbc_trans).ExecuteScalar)
        Dim INT_MUESTRA As Integer = 0
        For i = 0 To frm_formulario.dtt_pedido.Rows.Count - 1
            If frm_formulario.dtt_pedido.Rows(i).Item(8) = 1 Then   'verifica que sea nuevo
                lng_peeid = lng_peeid + 1
                If Trim(frm_formulario.dtt_pedido.Rows(i).Item(5)) = "T" Then
                    odbc_strsql.CommandText = "insert into pedido_detalle(ped_id, pee_id, pee_cantidad, tes_id) values(" & _
                    frm_formulario.Tag & "," & lng_peeid & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(1)) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ")"
                    odbc_strsql.ExecuteNonQuery()
                    odbc_strsql.CommandText = "insert into pedido_detalle_desglosado(ped_id, tes_id, pdd_estado, lip_precio) values(" & _
                    frm_formulario.Tag & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ",1, " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & ")"
                    odbc_strsql.ExecuteNonQuery()

                    'grabo el pedido directamente en la lista de trabajo.                    
                    Dim tip_procesa As Byte
                    Dim EQU_ID, TIM_ID, TUBO, EQUTIMID As Short
                    Dim LIS_ID As Integer
                    Dim val_defecto As String = Nothing
                    'Determino si la prueba es manual o de equipo
                    'opr_Conexion.conn_sql()
                    str_sql = "Select tes_tproces from TEST WHERE TES_ID = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ";"
                    Dim odr_lista As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans).ExecuteReader
                    While odr_lista.Read
                        tip_procesa = odr_lista.GetValue(0)
                    End While
                    odr_lista.Close()
                    str_sql = "Select isnull(max(LIS_ID),'0') from LISTA_TRABAJO;"
                    odr_lista = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans).ExecuteReader
                    While odr_lista.Read
                        LIS_ID = odr_lista.GetValue(0)
                    End While
                    odr_lista.Close()
                    'LIS_ID = CInt(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
                    LIS_ID += 1
                    If tip_procesa = 0 Then 'MANUAL
                        str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
                        "VALUES (" & LIS_ID & ", " & frm_formulario.Tag & ", '" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & "', " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(2)) & ",0,0,0)"
                        'Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
                        odbc_strsql.CommandText = str_sql
                        odbc_strsql.ExecuteNonQuery()
                        'opr_conexion.sql_desconn
                    Else  'AUTOMATICA
                        'EN QUE EQUIPO SE PROCESA?
                        str_sql = "select equ_id from test_equipo where tes_id = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & " and teq_estado = 1;"
                        odr_lista = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans).ExecuteReader
                        While odr_lista.Read
                            EQU_ID = odr_lista.GetValue(0)
                        End While
                        'EQU_ID = CInt(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
                        odr_lista.Close()
                        str_sql = "SELECT T.TIM_ID, TUB_DEFAULT, TT.TIM_ID FROM TESTEQUIPO_TIPMUESTRA AS TT, TEST_EQUIPO AS TE, TEST AS T " & _
                                "WHERE T.TES_ID = TE.TES_ID And TT.TEQ_ID = TE.TEQ_ID And TE.TES_ID = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & " And TEQ_ESTADO = 1 And TIM_DEFAULT = 1;"
                        odr_lista = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans).ExecuteReader
                        While odr_lista.Read
                            TIM_ID = odr_lista.GetValue(0).ToString
                            TUBO = odr_lista.GetValue(1).ToString
                            EQUTIMID = odr_lista.GetValue(2).ToString
                        End While
                        odr_lista.Close()
                        'inserto el registro en la lista de trabajo
                        str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, " & _
                        "LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
                        "VALUES (" & LIS_ID & ", " & frm_formulario.Tag & ", '" & Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy") & "', " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & "," & EQU_ID & ", " & TIM_ID & "," & TUBO & ", " & EQUTIMID & ",0,0,0);"
                        odbc_strsql.CommandText = str_sql
                        odbc_strsql.ExecuteNonQuery()
                        'INSERTA FORMATO EN RESPROCESADOS 
                        '*********************

                        Dim tes_abrev, equipo, sni_nombre As String

                        Dim genero As Char = Nothing
                        Dim edad As String = Nothing
                        Dim ggenero As String = Nothing

                        genero = Trim(frm_formulario.lbl_genero.Text)
                        edad = CalculaEdad(frm_formulario.lbl_fecnac.Text, unidad)

                        Select Case unidad
                            Case "MESES", "meses"
                                If genero = "F" Or genero = "M" Then
                                    If (CInt(edad) >= 1 And CInt(edad) <= 12) Then
                                        ggenero = "NIÑO"
                                    End If
                                End If

                            Case "DIAS", "dias", "días"
                                If genero = "F" Or genero = "M" Then
                                    If (CInt(edad) >= 0 And CInt(edad) <= 30) Then
                                        ggenero = "RN"
                                    End If
                                End If

                            Case "años", "AÑOS"
                                If genero = "F" Then
                                    If (CInt(edad) >= 1 And CInt(edad) <= 16) Then
                                        ggenero = "NIÑO"
                                    End If
                                    If (CInt(edad) >= 17 And CInt(edad) <= 110) Then
                                        ggenero = "MUJER"
                                    End If
                                Else
                                    If (CInt(edad) >= 1 And CInt(edad) <= 16) Then
                                        ggenero = "NIÑO"
                                    End If
                                    If (CInt(edad) >= 17 And CInt(edad) <= 100) Then
                                        ggenero = "HOMBRE"
                                    End If
                                End If

                        End Select

                        If oper_trabajo.LeerTieneAbrev(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)), ggenero) >= 1 Then
                            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & " AND te.TEQ_ABREVIATURA = '" & ggenero & "';"
                        Else
                            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, test.TES_RESDEFECTO from test_equipo as te, equipo as e, test where te.equ_id = e.equ_id and test.TES_ID = te.TES_ID and te.tes_id = " & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & " AND te.TEQ_ABREVIATURA = 'HOMBRE';"
                        End If
                        odr_lista = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans).ExecuteReader
                        While odr_lista.Read
                            tes_abrev = odr_lista.GetValue(0).ToString
                            equipo = odr_lista.GetValue(1).ToString
                            sni_nombre = odr_lista.GetValue(2).ToString
                            val_defecto = odr_lista.GetValue(3).ToString
                        End While
                        odr_lista.Close()

                        Dim opr_archivo As New Cls_Archivos()
                        Dim str_tipo_pac As String
                        Dim are_id As Integer

                        ''''''''''''''''''''''''''''''''
                        INT_MUESTRA = LeerTipoMuestraTest(CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))))
                        TIENE_AB_CALC = Split(oper_trabajo.LeerTieneAB(CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)))), ",")
                        are_id = LeerAreaTest(CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))))

                        If TIENE_AB_CALC(0) = 1 Or TieneParametros(CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)))) > 1 Then
                            'INSERTO EL TEST PADRE
                            str_sql = "Insert into RES_PROCESADOS values (" & frm_formulario.Tag & ", '', '', '" & tes_abrev & "', '" & sni_nombre & "', '" & Trim(val_defecto) & "', '','" & Trim(val_defecto) & "', '', " & INT_MUESTRA & ",'',''," & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & ",'','','', " & are_id & ",'')"
                            ' str_sql1 = "Insert into RES_HISORICOS values (" & frm_formulario.Tag & ", '" & tes_abrev & "', '', " & INT_MUESTRA & ")"
                            odbc_strsql.CommandText = str_sql
                            odbc_strsql.ExecuteNonQuery()

                            ' odbc_strsql1.CommandText = str_sql1
                            ' odbc_strsql1.ExecuteNonQuery()


                            arregloIDParam = Split(LeeIdParametros(CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)))), ",")

                            For z = 0 To UBound(arregloIDParam) - 1
                                arregloParam = Split(LeeParametros(arregloIDParam(z), genero, edad, CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)))), ",")

                                str_sql = "Insert into RES_PROCESADOS values (" & frm_formulario.Tag & ", '', '', '" & arregloParam(0) & "', '" & sni_nombre & "',  '" & arregloParam(3) & "' , '','" & arregloParam(3) & "', '', " & INT_MUESTRA & ",'',''," & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & ",'','','', " & are_id & ",'')"
                                odbc_strsql.CommandText = str_sql
                                odbc_strsql.ExecuteNonQuery()

                                '    str_sql1 = "Insert into RES_HISORICOS values (" & frm_formulario.Tag & ", '" & tes_abrev & "', '', " & INT_MUESTRA & ")"
                                '   odbc_strsql1.CommandText = str_sql1
                                '  odbc_strsql1.ExecuteNonQuery()

                            Next
                        Else

                            str_sql = "Insert into RES_PROCESADOS values (" & frm_formulario.Tag & ", NULL, NULL, '" & tes_abrev & "', '" & sni_nombre & "', '" & Trim(val_defecto) & "', '','" & Trim(val_defecto) & "', '', " & INT_MUESTRA & ",'',''," & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & ",'','','', " & are_id & ",'')"
                            odbc_strsql.CommandText = str_sql
                            odbc_strsql.ExecuteNonQuery()

                            str_sql = "Insert into FACTURA_DETALLE values (" & fad_id & ", '" & fac_id & "', 1, '" & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & "', " & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & ",'T')"
                            odbc_strsql.CommandText = str_sql
                            odbc_strsql.ExecuteNonQuery()

                        End If
                    End If
                Else
                    odbc_strsql.CommandText = "insert into pedido_detalle(ped_id, pee_id, pee_cantidad, per_id) values(" & _
                    frm_formulario.Tag & "," & lng_peeid & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(1)) & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ")"
                    odbc_strsql.ExecuteNonQuery()
                    Dim opr_perfil As New Cls_Perfil()
                    Dim dts_operacion As DataSet
                    dts_operacion = opr_perfil.LeerPerfil_test(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)))
                    For Each dtr_fila In dts_operacion.Tables("Registros").Rows
                        odbc_strsql.CommandText = "insert into pedido_detalle_desglosado(ped_id, per_id, tes_id, lip_precio) values(" & _
                        frm_formulario.Tag & "," & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & "," & dtr_fila(0) & ", " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & ")"
                        odbc_strsql.ExecuteNonQuery()
                    Next
                End If


                If TIENE_AB_CALC(0) = 1 Then
                    str_sql = "delete from RESAB_PROCESADOS where ped_id = " & frm_formulario.Tag & " and TIM_ID =  " & INT_MUESTRA & " and TES_ID = " & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & ""
                    odbc_strsql.CommandText = str_sql
                    odbc_strsql.ExecuteNonQuery()

                    arregloID_AB = Split(oper_trabajo.LeeId_AB(), ",")
                    For x = 0 To UBound(arregloID_AB) - 1
                        str_sql = "Insert into RESAB_PROCESADOS values (" & frm_formulario.Tag & ", '', '', " & CInt(arregloID_AB(x)) & ", null, " & CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))) & ", " & INT_MUESTRA & ",'','','','');"
                        odbc_strsql.CommandText = str_sql
                        odbc_strsql.ExecuteNonQuery()
                    Next
                End If

                Dim es_carga As Byte
                Dim opr_trabajo As New Cls_Trabajo()
                Dim nombre_exa As String = Nothing


                es_carga = opr_trabajo.LeerTipoResCarga(CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))))

                If es_carga = 1 Then
                    nombre_exa = opr_trabajo.LeerExamen(CInt(Trim(frm_formulario.dtt_pedido.Rows(i).Item(3))))
                    opr_trabajo.EliminaPtoPdf(frm_formulario.Tag, nombre_exa)
                    opr_trabajo.InsertPtoPdf(frm_formulario.Tag, nombre_exa, 0)
                End If

                ''Call ActualizarEstadoPedido(frm_formulario.Tag, 0)
                odbc_strsql.CommandText = "update PEDIDO set PEDIDO.PED_ESTADO = 0, PEDIDO.PED_ORIGEN = getdate() where PED_ID = " & frm_formulario.Tag & "; "
                odbc_strsql.ExecuteNonQuery()


                'Dim opr_trabajo As New Cls_Trabajo()
            Else 'SI NO ES NUEVO SOLO ACTUALIZACION, VERIFICO LOS PRECIOS DE LAS PRUEBAS
                If Trim(frm_formulario.dtt_pedido.Rows(i).Item(5)) = "T" Then
                    odbc_strsql.CommandText = "UPDATE pedido_detalle_desglosado set lip_precio = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & " where " & _
                    " ped_id = " & frm_formulario.Tag & " and tes_id = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ";"
                    odbc_strsql.ExecuteNonQuery()



                    str_sql = "update FACTURA_DETALLE set FAD_PRECIO = '" & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & "' where FAC_ID =  " & fac_id & "  and TES_ID = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & " "
                    odbc_strsql.CommandText = str_sql
                    odbc_strsql.ExecuteNonQuery()

                Else
                    Dim opr_perfil As New Cls_Perfil()
                    Dim dts_operacion As DataSet
                    dts_operacion = opr_perfil.LeerPerfil_test(Trim(frm_formulario.dtt_pedido.Rows(i).Item(2)))
                    For Each dtr_fila In dts_operacion.Tables("Registros").Rows
                        odbc_strsql.CommandText = "UPDATE pedido_detalle_desglosado set lip_precio = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(4)) & " where " & _
                        " ped_id = " & frm_formulario.Tag & " and tes_id = " & Trim(frm_formulario.dtt_pedido.Rows(i).Item(3)) & ";"
                        odbc_strsql.ExecuteNonQuery()
                    Next
                End If
            End If
        Next
        'ACTUALIZO ENCABEZADO DE FACTURA

        For i = 0 To frm_formulario.dtt_pedido.Rows.Count - 1
            fac_total = fac_total + Trim(frm_formulario.dtt_pedido.Rows(i).Item(4))
        Next
        str_sql = "UPDATE FACTURA SET  FAC_TOTAL = " & fac_total & " where fac_pedidos = '" & frm_formulario.Tag & "';"
        odbc_strsql.CommandText = str_sql
        odbc_strsql.ExecuteNonQuery()

        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        ActualizarPedido = 1
        g_lng_ped_id = frm_formulario.Tag

        Dim aud_detalle As String = Nothing
        If auditoria_ex <> "" Then
            aud_detalle = " " & seC_nombre & " EXAMENES: " & auditoria_ex
        Else
            aud_detalle = seC_nombre
        End If


        g_opr_usuario.CargarTransaccion(g_str_login, "1 MODIFICA ORDEN" & aud_detalle, "PEDIDO=" & g_lng_ped_id, g_sng_user, g_lng_ped_id, "", "")

        VisualizaMensaje("El pedido fue modificado correctamente", g_tiempo)
        ''MsgBox("El pedido fue modificado correctamente", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        ActualizarPedido = 0
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Pedido", Err)
        Err.Clear()
    End Function

    Public Function ConsultaMedicosGrupo(ByVal gmed_id As Integer) As String
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        str_sql = "select med_id from GrupoMedicoElementos  where gmed_id =" & gmed_id
        opr_conexion.sql_conectar()
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            ConsultaMedicosGrupo = ConsultaMedicosGrupo & odr_parametros.GetValue(0) & ","
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        VisualizaMensaje("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", g_tiempo)
        ''g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", Err)
        Err.Clear()
    End Function


    Public Function ConsultaMedicosGrupoPac(ByVal gmed_id As Integer, ByVal med_doc As String) As Integer
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql
        str_sql = "select med_id from medico where med_doc = '" & med_doc & "'"
        opr_conexion.sql_conectar()
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            ConsultaMedicosGrupoPac = odr_parametros.GetValue(0)
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        VisualizaMensaje("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", g_tiempo)
        ''g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", Err)
        Err.Clear()
    End Function


    Public Function TieneParametros(ByVal tes_padre As Integer) As Integer
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "select count(tes_id) as param from test where tes_padre = " & tes_padre
        opr_conexion.sql_conectar()
        TieneParametros = 0
        TieneParametros = CStr(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        VisualizaMensaje("No se pudo realizar la operacion solicitada, consulta parametros EXAMEN", g_tiempo)
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Parametros EXAMEN", Err)
        Err.Clear()

    End Function



    Public Function LeePerfilExamenes(ByVal perfil_nombre As String, ByVal perfil_convenio As String, ByRef examenes As String, ByRef precios As String) As Byte
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        examenes = ""
        precios = ""
        str_sql = "select perfil_test.TES_ID, lista_precio.LIP_PRECIO from perfil, perfil_test, lista_precio where perfil.PER_ID = perfil_test.PER_ID and perfil.PER_ESTADO =1 and perfil_test.TES_ID = lista_precio.TES_ID and perfil.PER_NOMBRE = '" & perfil_nombre & "' and lista_precio.CON_NOMBRE = '" & perfil_convenio & "' order by perfil_test.PER_ID, perfil_test.TES_ID asc;"
        opr_conexion.sql_conectar()
        LeePerfilExamenes = ""
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            examenes = examenes & odr_parametros.GetValue(0) & ","
            precios = precios & odr_parametros.GetValue(1) & ","
        End While
        LeePerfilExamenes = 1
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        VisualizaMensaje("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", g_tiempo)
        ''g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer EXAMEN-PERFIL", Err)
        Err.Clear()
        LeePerfilExamenes = 0
    End Function




    Public Function LeeIdParametros(ByVal tes_padre As Integer) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        str_sql = "select tes_id from test where tes_padre = " & tes_padre & " order by tes_id asc"
        opr_conexion.sql_conectar()
        LeeIdParametros = ""
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            LeeIdParametros = LeeIdParametros & Str(odr_parametros.GetValue(0)) & ","
        End While
        'LeeIdParametros = tes_id & "," & LeeIdParametros
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Parametros EXAMEN", Err)
        Err.Clear()
    End Function


    Public Function LeeParametros(ByVal tes_id As Integer, ByVal genero As Char, ByVal edad As String, ByVal tes_padre As Integer) As String
        'funci�n para leer un equipo guardado para un item de la lista de trabajo
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = ""
        Dim ggenero As String = ""

        If genero = "F" Then
            ggenero = "MUJER"
        Else
            If (CInt(edad) >= 1 And CInt(edad) <= 10) Then
                ggenero = "NIÑO"
            Else
                If (CInt(edad) >= 11 And CInt(edad) <= 100) Then
                    ggenero = "HOMBRE"
                Else
                    ggenero = "RN"
                End If
            End If

        End If

        If tes_padre <> 400101 Then
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, t.TES_RESDEFECTO from test_equipo as te, equipo as e, test as t  where te.equ_id = e.equ_id and te.TES_ID = t.TES_ID and te.tes_id = " & tes_id & " ;"
        Else
            str_sql = "select teq_abrv_fija, equ_modelo, sni_nombre, t.TES_RESDEFECTO from test_equipo as te, equipo as e, test as t where te.equ_id = e.equ_id and t.TES_ID= te.TES_ID and te.tes_id = " & tes_id & " AND te.TEQ_ABREVIATURA = '" & ggenero & "';"
        End If
        opr_conexion.sql_conectar()
        LeeParametros = ""
        Dim odr_parametros As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_parametros.Read
            LeeParametros = odr_parametros.GetString(0) & "," & odr_parametros.GetString(1) & "," & odr_parametros.GetString(2) & "," & Trim(odr_parametros.GetString(3)) & ","
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Parametros EXAMEN", Err)
        Err.Clear()
    End Function

    Public Sub AnularPedido(ByVal ped_id As Long)
        'procedimiento que sirve para anular un pedido, recibe le codigo del pedido        
        ActualizarEstadoPedido(ped_id, 2)
    End Sub

    Public Sub AnularFactura(ByVal fac_id As Long)
        'procedimiento que sirve para anular un pedido, recibe le codigo del pedido        
        EliminaFactura(fac_id)
    End Sub

    Public Sub anularReg(ByVal ped_id As Integer)
        'Funcion que libera el turno utilizado por el pedido y elimina los registros innecesarios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer

        opr_Conexion.sql_conectar()

        STR_SQL = "delete from res_procesados where ped_id = " & ped_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "delete from ptohistograma where ped_id = " & ped_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "delete from lista_trabajo where ped_id = " & ped_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "delete from resab_procesados  where ped_id = " & ped_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "delete from ptopdf where ped_id = " & ped_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "delete from res_historicos where ped_id = " & ped_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        MsgBox("Error al liberar el turno", MsgBoxStyle.Information, "ANALISYS")
        Err.Clear()
    End Sub


    Public Function LeerPedidoPaciente(Optional ByVal tiempo As Short = 0) As DataTable
        'Funcion para consultar los pedidos que no tienen asignadas facturas
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        'tiempo 0: TODOS LOS ARCHIVOS
        'TIEMPO 1: 1 MES ATRAS
        'TIEMPO 2: 1 DIA 
        opr_Conexion.sql_conectar()
        'el estado es: 0 no tiene factura, 1 posee factura, 2 no se factura(gratis, con lo que no las consultamos)

        Select Case tiempo
            Case 0
                STR_SQL = "SELECT distinct(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) as PACIENTE, pedido.CON_NOMBRE, paciente.PAC_ID " & _
                          "FROM PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
                          "WHERE (((PEDIDO.PED_FAC_ESTADO)=0)) "
            Case 1
                Dim date_busq As Date = DateAdd(DateInterval.Month, -1, Today)
                STR_SQL = "SELECT distinct(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) as PACIENTE, pedido.CON_NOMBRE, paciente.PAC_ID " & _
                          "FROM PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
                          "WHERE PEDIDO.PED_FAC_ESTADO = 0 "
                STR_SQL = STR_SQL & " and PEDIDO.PED_FECING > '" & Format(date_busq, "dd/MM/yyyy") & "' "
            Case Else
                Dim date_busq As Date = DateAdd(DateInterval.Day, -1, Today)
                STR_SQL = "SELECT distinct(PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) as PACIENTE, pedido.CON_NOMBRE, paciente.PAC_ID " & _
                          "FROM PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
                          "WHERE PEDIDO.PED_FAC_ESTADO = 0 "
                STR_SQL = STR_SQL & " and PEDIDO.PED_FECING > '" & Format(date_busq, "dd/MM/yyyy") & "' "
        End Select

        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        LeerPedidoPaciente = New DataTable("Pacientes")
        oda_operacion.Fill(LeerPedidoPaciente)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pacientes Facturas", Err)
        Err.Clear()
    End Function



    Public Function LeerPedidoSinFactura(Optional ByVal tiempo As Short = 0) As DataTable
        'Funcion para consultar los pedidos que no tienen asignadas facturas
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        'tiempo 0: TODOS LOS ARCHIVOS
        'TIEMPO 1: 1 MES ATRAS
        'TIEMPO 2: 1 DIA 
        opr_Conexion.sql_conectar()
        'el estado es: 0 no tiene factura, 1 posee factura, 2 no se factura(gratis, con lo que no las consultamos)

        Select Case tiempo
            Case 0
                STR_SQL = "SELECT PEDIDO.PED_ID, PEDIDO.PED_FECING, PACIENTE.PAC_APELLIDO, PACIENTE.PAC_NOMBRE, PEDIDO.PED_FAC_ESTADO, pedido.CON_NOMBRE, paciente.PAC_ID " & _
                          "FROM PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
                          "WHERE (((PEDIDO.PED_FAC_ESTADO)=0)) "
            Case 1
                Dim date_busq As Date = DateAdd(DateInterval.Month, -1, Today)
                STR_SQL = "SELECT PEDIDO.PED_ID, PEDIDO.PED_FECING, PACIENTE.PAC_APELLIDO, PACIENTE.PAC_NOMBRE, PEDIDO.PED_FAC_ESTADO, pedido.CON_NOMBRE, paciente.PAC_ID " & _
                          "FROM PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
                          "WHERE PEDIDO.PED_FAC_ESTADO = 0 "
                STR_SQL = STR_SQL & " and PEDIDO.PED_FECING > '" & Format(date_busq, "dd/MM/yyyy") & "' "
            Case Else
                Dim date_busq As Date = DateAdd(DateInterval.Day, -1, Today)
                STR_SQL = "SELECT PEDIDO.PED_ID, PEDIDO.PED_FECING, PACIENTE.PAC_APELLIDO, PACIENTE.PAC_NOMBRE, PEDIDO.PED_FAC_ESTADO, pedido.CON_NOMBRE, paciente.PAC_ID " & _
                          "FROM PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
                          "WHERE PEDIDO.PED_FAC_ESTADO = 0 "
                STR_SQL = STR_SQL & " and PEDIDO.PED_FECING > '" & Format(date_busq, "dd/MM/yyyy") & "' "
        End Select

        'STR_SQL = "SELECT PEDIDO.PED_ID, PEDIDO.PED_FECING, PACIENTE.PAC_APELLIDO, PACIENTE.PAC_NOMBRE, PEDIDO.PED_FAC_ESTADO " & _
        '"FROM PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID " & _
        '"WHERE (((PEDIDO.PED_FAC_ESTADO)=0)) "
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        LeerPedidoSinFactura = New DataTable("Registros")
        oda_operacion.Fill(LeerPedidoSinFactura)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido Sin Factura", Err)
        Err.Clear()
    End Function

    Public Function ExistePedido(ByVal ped_id As Integer) As Byte
        'Funcion que devuelve 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = ""
        str_sql = "Select ped_estado from pedido where ped_id = " & ped_id & ""
        opr_Conexion.sql_conectar()
        'Estado:  Si un pedido est� anulado(2), 
        'en una lista de trabajo(1) o en espera de ser asignado(0), 
        'pedido procesado y listo(3), (4) Enviar al Equipo
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        ExistePedido = 0
        While odr_operacion.Read
            'Pregunto si est� validado el pedido
            If (odr_operacion.GetValue(0) = 3 Or odr_operacion.GetValue(0) = 4) Then
                'Si es 3 (validado completamente y listo)
                ExistePedido = 2
            Else
                'No est� VALIDADO, SI SE SUBEN LOS RESULTADOS
                ExistePedido = 1
            End If
        End While
        odr_operacion.Close()
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Existe Pedido", Err)
        Err.Clear()
    End Function

    Public Function EstadoPrueba(ByVal ped_id As Integer, ByVal tes_id As Integer) As Byte
        'Funci�n que devuelve: 
        '1: SI SE PUEDE ACTUALIZAR
        '0: NO SE PUEDE ACTUALIZAR
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = ""
        str_sql = "Select lis_resestado from lista_trabajo where ped_id = " & ped_id & " and tes_id = " & tes_id & ";"
        opr_Conexion.sql_conectar()
        'Estado de lista de trabajo:  
        '0:  ITEM SIN RESULTADO
        '1:  ITEM CON RESULTADO
        '2:  ITEM VALIDADO
        '3:  ITEM ENVIADO AL EQUIPO

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        EstadoPrueba = 0
        While odr_operacion.Read
            'Pregunto si est� validado el pedido
            If odr_operacion.GetValue(0) = 2 Then
                EstadoPrueba = 0
            Else
                EstadoPrueba = 1
            End If
        End While
        odr_operacion.Close()
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Estado Prueba", Err)
        Err.Clear()
    End Function


    Public Function PedidoNuevo(ByVal ped_id As Integer) As Byte
        'Funcion que devuelve 1 si el numero de pedido ya ha sido utilizado, caso contrario 0
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        PedidoNuevo = CInt(New SqlCommand("Select isnull(count(ped_id),0) from pedido where ped_id = " & ped_id & "", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, PedidoNuevo", Err)
        Err.Clear()
    End Function

    Public Function PedidoConHisto(ByVal ped_id As Integer) As Byte
        'Funcion para la consultar si un pedido tiene Histogramas o no 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        PedidoConHisto = 0  'No posee Histograma
        Dim str_sql As String = "select count(ped_id) from pedido_detalle_desglosado where ped_id = " & ped_id & " and tes_id = 400101"
        opr_Conexion.sql_conectar()
        If CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
            PedidoConHisto = 1  'Si posee Histograma
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Pedido ConHisto", Err)
        Err.Clear()
    End Function


    Public Function LlenarcomboPaciente(ByRef combo As ComboBox, ByVal tiempo As Integer)
        On Error Resume Next
        'Para llenar el combo de convenio
        Dim dts_pacientes As DataSet
        Dim dtr_fila As DataRow
        dts_pacientes = LlenaPaciente(tiempo)
        combo.Items.Clear()
        For Each dtr_fila In dts_pacientes.Tables("Registros").Rows
            combo.Items.Add(dtr_fila("PAC_ID").ToString())
        Next
        dts_pacientes.Dispose()
        combo.SelectedIndex = 0
    End Function


    Public Function LlenarcomboGrupos(ByRef combo As ComboBox, ByVal estado As Integer)
        On Error Resume Next
        'Para llenar el combo de convenio
        Dim dts_grupos As DataSet
        Dim dtr_fila As DataRow
        dts_grupos = LlenaGrupos(estado)
        combo.Items.Clear()
        'Format(CInt(lbl_histC.Text), "0000")
        For Each dtr_fila In dts_grupos.Tables("Registros").Rows
            'combo.Items.Add(Format(CInt(dtr_fila("tip_id").ToString()), "00").PadRight(5) & dtr_fila("tip_grupo").ToString().PadRight(50))
            combo.Items.Add(dtr_fila("tip_grupo").ToString())
        Next
        dts_grupos.Dispose()
        combo.SelectedIndex = 0
    End Function

    Public Function LlenaPaciente(ByVal tiempo As Integer) As DataSet
        'Procedimiento para consultar todas los Convenios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select * from CONVENIO", opr_Conexion.conn_sql)
        LlenaPaciente = New DataSet()
        oda_operacion.Fill(LlenaPaciente, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Convenios", Err)
        Err.Clear()
    End Function


    Public Function LlenaGrupos(ByVal estado As Integer) As DataSet
        'Procedimiento para consultar todas los Convenios
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select tip_id, tip_grupo from rango_edades where tip_estado =1 order by tip_id", opr_Conexion.conn_sql)
        LlenaGrupos = New DataSet()
        oda_operacion.Fill(LlenaGrupos, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Grupos", Err)
        Err.Clear()
    End Function

    Public Sub ActualizarEstadoPedidoFactura(ByVal str_pedidos() As Long)
        'Funcion para consultar los pedidos que no tienen asignadas facturas
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer
        opr_Conexion.sql_conectar()
        'el estado es: 0 no tiene factura, 1 posee factura, 2 no se factura(gratis)
        For int_indice = 0 To UBound(str_pedidos) - 1
            STR_SQL = "update PEDIDO set PED_FAC_ESTADO = 2 where PED_ID = " & str_pedidos(int_indice)
            odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
        Next
        opr_Conexion.sql_desconn()
        MsgBox("Datos Registrados", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Estado Pedido", Err)
        Err.Clear()
    End Sub


    Public Sub EliminaFactura(ByVal fac_id As Integer)
        'PROCEDIMIENTO para actualizar el estado de un pedido a ESTADO LIS (PROCESADO Y VALIDADO)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer

        opr_Conexion.sql_conectar()
        'Si un pedido est� anulado (2),  (1) o en espera de ser asignado (0), pedido procesado y listo (3), (4) impreso

        STR_SQL = "delete from factura where fac_id = " & fac_id & "; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "delete from factura_detalle where fac_id = " & fac_id & "; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Estado Pedido Listo", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarEstadoPedido(ByVal ped_id As Integer, ByVal estado As Integer)
        'PROCEDIMIENTO para actualizar el estado de un pedido a ESTADO LIS (PROCESADO Y VALIDADO)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer

        opr_Conexion.sql_conectar()
        'Si un pedido est� anulado (2),  (1) o en espera de ser asignado (0), pedido procesado y listo (3), (4) impreso
        STR_SQL = "update PEDIDO set PEDIDO.PED_ESTADO = " & estado & " where PED_ID = " & ped_id & "; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Estado Pedido Listo", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizaCodigo(ByVal cod_num As Long)
        'PROCEDIMIENTO para actualizar el estado de un pedido a ESTADO LIS (PROCESADO Y VALIDADO)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer
        opr_Conexion.sql_conectar()
        'Si un pedido est� anulado (2),  (1) o en espera de ser asignado (0), pedido procesado y listo (3), (4) impreso
        STR_SQL = "update CODIGO set cod_num = " & cod_num & " where Cod_id = 1; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar CODIGO ID", Err)
        Err.Clear()
    End Sub


    Public Function LeerTipoMuestraTest(ByVal tes_id As Integer) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerTipoMuestraTest = CInt(New SqlCommand("Select isnull(max(tim_id),0) from TEST WHERE TES_ID = " & tes_id & "", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer tipo de muestra x Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function

    Public Function LeerAreaTest(ByVal tes_id As Integer) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerAreaTest = CInt(New SqlCommand("Select are_id from TEST WHERE TES_ID = " & tes_id & "", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Area Test, Cls_TRABAJO", Err)
        Err.Clear()
    End Function


    Public Function todasPruebasValidadas(ByVal ped_id As Integer) As Byte
        'Funcion para la consultar si un pedido tiene todas sus pruebas procesadas y validadas
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        todasPruebasValidadas = 0 'si estan todas validadas
        Dim str_sql As String = "select count(ped_id) from lista_trabajo where ped_id = " & ped_id & " and lis_resestado <> 2"
        opr_Conexion.sql_conectar()
        If CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
            todasPruebasValidadas = 1  'NO, EXISTEN PRUEBAS SIN VALIDAR
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Pruebas Validadas", Err)
        Err.Clear()
    End Function




    Public Sub InsertarNotaPedido(ByVal ped_id As Integer, ByVal nota As String)
        'PROCEDIMIENTO para insertar una nota al pedido (luego de la validaci�n )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "update PEDIDO set PED_nota = '" & nota & "' where PED_ID = " & ped_id & " "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar Nota Pedido", Err)
        Err.Clear()
    End Sub

    Public Sub InsertarNotaExamen(ByVal ped_id As Integer, ByVal tes_abrev As String, ByVal nota As String)
        'PROCEDIMIENTO para insertar una nota al examen( )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "update res_procesados set PRC_ERROR = '" & nota & "' where PED_ID = " & ped_id & " and TES_ABREV like '" & tes_abrev & "%'; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        STR_SQL = "update resab_procesados set PRC_ERROR = '" & nota & "' where PED_ID = " & ped_id & " ; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar Nota Pedido", Err)
        Err.Clear()
    End Sub


    Public Sub InsertarPresentacion(ByVal PRES_ID As Integer, ByVal PRES_DESCRIPCION As String)
        'PROCEDIMIENTO para insertar una nota al examen( )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "insert into VademecumPresentacion values(" & PRES_ID & ", '" & PRES_DESCRIPCION & "'); "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar presentacion", Err)
        Err.Clear()
    End Sub


    Public Function InsertarComentarioConsulta(ByVal Age_id As Integer, ByVal med_id As Integer, ByVal obs As String) As Boolean
        'PROCEDIMIENTO para insertar una nota la consulta 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        InsertarComentarioConsulta = False
        opr_Conexion.sql_conectar()
        STR_SQL = "update consultaMedico set CON_OBS = '" & obs & "' where Age_ID = " & Age_id & " and med_id = " & med_id & "; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        InsertarComentarioConsulta = True

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        InsertarComentarioConsulta = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar Observaciones Consulta", Err)
        Err.Clear()
    End Function


    Public Sub InsertarResExamen(ByVal ped_id As Integer, ByVal tes_abrev As String)
        'PROCEDIMIENTO para insertar una nota al examen( )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        STR_SQL = "update res_procesados set PRC_RESUL = '!', PRC_RESFINAL = '!' where PED_ID = " & ped_id & " and TES_ABREV = '" & tes_abrev & "'; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar Nota Pedido", Err)
        Err.Clear()
    End Sub



    Public Sub InsertaResCalculo(ByVal ped_id As Integer, ByVal tes_abrev As String, ByVal resul As String)
        'PROCEDIMIENTO para insertar una nota al examen( )
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim tes_abrev_nuevo As String = Nothing
        'tes_abrev_nuevo = Mid(tes_abrev, 1, Len(tes_abrev) - 1)

        opr_Conexion.sql_conectar()
        STR_SQL = "update res_procesados set PRC_RESUL = '" & resul & "', PRC_RESFINAL = '" & resul & "' where PED_ID = " & ped_id & " and (TES_ABREV = '" & tes_abrev & "' or TES_ABREV = '" & tes_abrev & "H' or TES_ABREV = '" & tes_abrev & "N' or TES_ABREV = '" & tes_abrev & "RN') ; "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar Nota Pedido", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarPdd_Estado(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal estado As Integer)
        '07-ago-2014
        'PROCEDIMIENTO PARA ACTUALIZAR EL ESTADO DE UN TEST DE UN PEDIDO (PEE_ESTADO) 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer
        opr_Conexion.sql_conectar()
        'PEDIDO_DETALLE ESTADO:   INDICA EL ESTADO DE CADA TEST DE UN PEDIDO (0 --> NO PROCESADO; 1--> PROCESADO; 2-->REPETIR)
        STR_SQL = "update PEDIDO_DETALLE_DESGLOSADO set Pdd_ESTADO = " & estado & " where PED_ID = " & ped_id & " AND tes_id = " & tes_id & " "
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar PeeEstado", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarLis_resEstado(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal estado As Integer, ByVal fecha As Date)
        'PROCEDIMIENTO PARA ACTUALIZAR EL ESTADO DE UN ITEM EN LA LISTA DE TRABAJO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido, odc_pedido1, odc_pedido2 As New SqlCommand()
        Dim STR_SQL, STR_SQL1, STR_SQL2 As String
        Dim int_indice As Integer
        opr_Conexion.sql_conectar()
        'LIS_RESESTADO:   0 : no procesado;;; 1 :procesado;;;; 2 :validado;;;;; 3: ENVIADO AL EQUIPO
        If estado = 2 Or estado = 9 Then
            STR_SQL = "update LISTA_TRABAJO set LIS_RESESTADO = " & estado & ", LIS_USER= '" & g_invitadoID & "' , LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' where PED_ID = " & ped_id & " AND tes_id = " & tes_id & " and (lis_resestado <> 2 or lis_resestado <> 9);"
            STR_SQL1 = "update RES_PROCESADOS set RES_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RES_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RES_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RES_PROCESADOS.PED_ID and lista_trabajo.TES_ID = res_procesados.TES_PADRE;"
            STR_SQL2 = "update RESAB_PROCESADOS set RESAB_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RESAB_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RESAB_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RESAB_PROCESADOS.PED_ID;"
        Else
            STR_SQL = "update LISTA_TRABAJO set LIS_RESESTADO = " & estado & " where PED_ID = " & ped_id & " AND tes_id = " & tes_id & ""
            STR_SQL1 = "update RES_PROCESADOS set RES_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RES_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RES_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RES_PROCESADOS.PED_ID and lista_trabajo.TES_ID = res_procesados.TES_PADRE;"
            STR_SQL2 = "update RESAB_PROCESADOS set RESAB_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RESAB_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RESAB_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RESAB_PROCESADOS.PED_ID;"
        End If
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido1 = New SqlCommand(STR_SQL1, opr_Conexion.conn_sql)
        odc_pedido2 = New SqlCommand(STR_SQL2, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        odc_pedido1.ExecuteNonQuery()
        odc_pedido2.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Lis ResEstado", Err)
        Err.Clear()
    End Sub


    Public Sub ActualizarLis_resEstadoPreliminar(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal estado As Integer, ByVal fecha As Date)
        'PROCEDIMIENTO PARA ACTUALIZAR EL ESTADO DE UN ITEM EN LA LISTA DE TRABAJO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido, odc_pedido1, odc_pedido2 As New SqlCommand()
        Dim STR_SQL, STR_SQL1, STR_SQL2 As String
        Dim int_indice As Integer
        opr_Conexion.sql_conectar()
        'LIS_RESESTADO:   0 : no procesado;;; 1 :procesado;;;; 2 :validado;;;;; 3: ENVIADO AL EQUIPO
        If estado = 2 Or estado = 9 Then
            STR_SQL1 = "update RES_PROCESADOS set RES_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RES_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RES_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RES_PROCESADOS.PED_ID and lista_trabajo.TES_ID = res_procesados.TES_PADRE;"
            STR_SQL2 = "update RESAB_PROCESADOS set RESAB_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RESAB_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RESAB_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RESAB_PROCESADOS.PED_ID;"
        Else
            STR_SQL1 = "update RES_PROCESADOS set RES_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RES_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RES_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RES_PROCESADOS.PED_ID and lista_trabajo.TES_ID = res_procesados.TES_PADRE;"
            STR_SQL2 = "update RESAB_PROCESADOS set RESAB_PROCESADOS.LIS_USER= '" & g_invitadoID & "' , RESAB_PROCESADOS.LIS_FECVALIDADO = '" & Format(fecha, "dd/MM/yyyy hh:mm:ss") & "' FROM LISTA_TRABAJO where RESAB_PROCESADOS.PED_ID = " & ped_id & " AND LISTA_TRABAJO.tes_id = " & tes_id & " and (LISTA_TRABAJO.lis_resestado <> 2 or LISTA_TRABAJO.lis_resestado <> 9) and LISTA_TRABAJO.PED_ID = RESAB_PROCESADOS.PED_ID;"
        End If
        odc_pedido1 = New SqlCommand(STR_SQL1, opr_Conexion.conn_sql)
        odc_pedido2 = New SqlCommand(STR_SQL2, opr_Conexion.conn_sql)
        odc_pedido1.ExecuteNonQuery()
        odc_pedido2.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Actualizar Lis ResEstado", Err)
        Err.Clear()
    End Sub

    Public Function LeerPedidoFactura(ByVal ped_id As Long) As DataSet
        'retorna en un dataset el los pedidos que correspoden a un factura
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        STR_SQL = "Select ped_fecing, pac_tipodoc, pac_doc, pac_apellido, pac_nombre, pac_direccion, case when pac_fono is null then'ND' else pac_fono end as pac_fono, convenio.con_nombre as con_nombre, con_valor from paciente, pedido, convenio where convenio.con_nombre=pedido.con_nombre and pedido.pac_id=paciente.pac_id and ped_id = " & ped_id
        oda_pedido.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerPedidoFactura = New DataSet()
        oda_pedido.Fill(LeerPedidoFactura, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido Por Factura", Err)
        Err.Clear()
    End Function

    Public Function tes_asociados(ByVal equ_id As Integer, ByVal tes_id As Integer) As DataSet
        'Funci�n para consultar los test relacionados a otro test seg�n un equipo
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_pedido.SelectCommand = New SqlCommand("SELECT TEST_RELACIONADO.TES_ID_HIJO, TEST_EQUIPO.TEQ_ABRV_FIJA FROM TEST_RELACIONADO, TEST_EQUIPO WHERE (TEST_RELACIONADO.TES_ID_PADRE = " & tes_id & ") AND (TEST_EQUIPO.EQU_ID = " & equ_id & ") AND (TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO)", opr_conexion.conn_sql)
        tes_asociados = New DataSet()
        oda_pedido.Fill(tes_asociados, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Test Asociados", Err)
        Err.Clear()
    End Function

    Public Function LeerDetPedidoFactura(ByVal ped_id As Long) As DataSet
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        STR_SQL = "SELECT PERFIL.PER_NOMBRE, PERFIL.PER_ID, TEST.TES_NOMBRE, TEST.TES_ID, PEDIDO_DETALLE.PED_ID, PEE_CANTIDAD, TEST.TES_PRECIO  " & _
        "FROM TEST RIGHT JOIN (PERFIL RIGHT JOIN PEDIDO_DETALLE ON PERFIL.PER_ID = PEDIDO_DETALLE.PER_ID) ON TEST.TES_ID = PEDIDO_DETALLE.TES_ID " & _
        "WHERE PEDIDO_DETALLE.PED_ID = " & ped_id & " ORDER BY PEDIDO_DETALLE.PED_ID; "
        oda_pedido.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerDetPedidoFactura = New DataSet()
        oda_pedido.Fill(LeerDetPedidoFactura, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Detalle Pedido De Factura", Err)
        Err.Clear()
    End Function

    Public Function LeerPedidoDeFactura(ByVal fac_id As String) As DataSet
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        opr_conexion.sql_conectar()
        STR_SQL = "select PED_ID, PED_ESTADO, CON_NOMBRE  from pedido where FAC_ID = '" & fac_id & "'"
        oda_pedido.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerPedidoDeFactura = New DataSet()
        oda_pedido.Fill(LeerPedidoDeFactura, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido De Factura", Err)
        Err.Clear()
    End Function

    Public Function ContarPedido() As Byte
        'Funcion para la consultar los datos de la tabla PEDIDO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim int_lic, int_disponible As Integer
        opr_Conexion.sql_conectar()
        str_sql = "SELECT COUNT(*) FROM pedido WHERE PED_FECING between '" & Format(Today, "dd/MM/yyyy") & " 00:00:01' and  '" & Format(Today, "dd/MM/yyyy") & " 23:59:59'"
        ContarPedido = 1
        int_lic = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        str_sql = "select par_cantidad from parametro"
        int_disponible = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        'If int_lic >= int_disponible Then
        '    MsgBox("LA LICENCIA DEMO DE ANALISYS PERMITE REALIZAR UN MAXIMO DE " & int_disponible.ToString() & " ORDENES DIARIAS.", MsgBoxStyle.Exclamation, "ANALISYS")
        '    ContarPedido = 0
        'End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Contar Pedidos", Err)
        Err.Clear()
    End Function





    Public Function ContarPedidoTotal() As Byte
        'Funcion para la consultar los datos de la tabla PEDIDO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim int_lic, int_disponible As Integer
        opr_Conexion.sql_conectar()
        str_sql = "SELECT COUNT(*) FROM pedido;"
        ContarPedidoTotal = 1
        int_lic = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        'str_sql = "select par_cantidad from parametro"
        'int_disponible = CInt(New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteScalar)
        If int_lic >= 60 Then
            MsgBox("LA LICENCIA DEMO DE ANALISYS HA EXPIRADO, CONSULTE CON SU PROVEEDOR DE SOFTWARE.", MsgBoxStyle.Exclamation, "ANALISYS")
            ContarPedidoTotal = 0
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Contar Pedidos", Err)
        Err.Clear()
    End Function


    'Sub LlenarGridValPedidos(ByRef dgrd_pedidos As DataGrid, ByVal ped_id As String, ByVal tipo As Byte)
    'JVA 15-ENE 04 GRID
    Sub LlenarGridValPedidos(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedidosLTxValidar(g_sng_user, fec_ini, fec_fin).Tables("Registros")
    End Sub


    Sub LlenarGridValPedidos2(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date, ByVal prioridad As String, ByVal areas As String)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedidosLTxValidar2(g_sng_user, fec_ini, fec_fin, prioridad, areas).Tables("Registros")
    End Sub

    Sub LlenarGridValPedidosWin(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedidosLTxValidarWin(g_sng_user, fec_ini, fec_fin).Tables("Registros")
    End Sub


    Sub LlenarGridCie10(ByRef data As DataView, ByVal parametro As String)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerCie10().Tables("Registros")
    End Sub

    Sub LlenarGridVademecum(ByRef data As DataView, ByVal parametro As String)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerVademecum().Tables("Registros")
    End Sub

    
    Sub LlenarGridVacunas(ByVal I_BOD_ID As String, ByRef data As DataView)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerVacunas(I_BOD_ID).Tables("Registros")
    End Sub

    Sub LlenarGridMateriales(ByVal I_BOD_ID As String, ByRef data As DataView)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerMateriales(I_BOD_ID).Tables("Registros")
    End Sub

    Sub LlenarGridSeries(ByRef data As DataView, ByVal parametro As String)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerSeries(parametro).Tables("Series")
    End Sub


    Sub LlenarGridPedValidados(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date)
        On Error Resume Next
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedidosValidos(fec_ini, fec_fin).Tables("Registros")
    End Sub


    'ByRef ORDENEXISTE As String,
    Function Existeturno(ByVal FECHA As Date, ByVal TURNO As Short, Optional ByVal PEDIDO As Integer = 0, Optional ByVal Nuevo As Boolean = True, Optional ByVal TIPO As String = "NORMAL") As Boolean
        Dim str_sql As String
        Existeturno = False
        'Dim FEC_INI, FEC_FIN As String

        If TURNO <> 0 Or Not Nuevo Then

            If PEDIDO = 0 Then
                'If TIPO = "URGENCIA" Then

                'str_sql = "Select count(*) from Pedido where PED_TURNO= " & TURNO & " and PED_ESTADO <> 2 AND PED_FECING BETWEEN '" & FEC_INI & "' AND '" & FEC_FIN & "'"   ' and PED_TIPO = '" & TIPO & "'
                'Else

                str_sql = "Select count(*),  PEDIDO.PED_FECING from Pedido where PED_TURNO=" & TURNO & " and PED_ESTADO <> 2 and PED_FECING between  '" & Format(FECHA, "yyyy-MM-01") & " 00:00:00' and '" & Format(FECHA, "yyyy-MM-31") & " 23:59:59' "
            End If
        Else
            str_sql = "Select count(*) from Pedido where PED_TURNO=" & TURNO & " and PED_ESTADO <> 2 and PED_FECING  like '" & Format(FECHA, "dd/MM/yyyy") & "%' and PED_ID=" & PEDIDO
            'str_sql = "Select count(*) from Pedido where PED_TURNO=" & TURNO & " and PED_ESTADO <> 2 and PED_FECING  BETWEEN '" & FEC_INI & "' AND '" & FEC_FIN & "' and PED_ID=" & PEDIDO    'PED_TIPO = '" & TIPO & "' and
        End If
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        If CLng(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
            Existeturno = True
        End If
        opr_Conexion.sql_desconn()
        'End If
        Exit Function
    End Function

    Function Existeturno1(ByVal FECHA As Date, ByVal TURNO As Short, Optional ByVal PEDIDO As Integer = 0, Optional ByVal Nuevo As Boolean = True, Optional ByVal TIPO As String = "URGENCIA") As Boolean
        Dim str_sql As String
        Existeturno1 = False
        Dim FEC_INI, FEC_FIN As String
        Dim ANO, MES, DIAS_MES As Short
        ANO = Year(FECHA)
        MES = Month(FECHA)
        DIAS_MES = Date.DaysInMonth(Year(FECHA), Month(FECHA))
        MES = Month(FECHA)
        DIAS_MES = Date.DaysInMonth(Year(FECHA), Month(FECHA))
        FEC_INI = ANO & "-" & MES & "-01 00:00:00"
        FEC_FIN = ANO & "-" & MES & "-" & DIAS_MES & " 23:59:59"
        If TURNO <> 0 Or Not Nuevo Then
            If PEDIDO = 0 Then
                'If TIPO = "URGENCIA" Then
                'ANO = Year(FECHA)
                'FEC_INI = ANO & "-01-01 00:00:00"
                'FEC_FIN = ANO & "-12-31 23:59:59"
                str_sql = "Select count(*) from Pedido where PED_TURNO= " & TURNO & " and PED_ESTADO <> 2 and PED_FECING BETWEEN '" & FEC_INI & "' AND '" & FEC_FIN & "'"     'PED_TIPO = '" & TIPO & "' AND 
                'Else
                '    str_sql = "Select count(*) from Pedido where PED_TURNO=" & TURNO & " and PED_ESTADO <> 2 and PED_TIPO = '" & TIPO & "' and PED_FECING like '" & Format(FECHA, "dd/MM/yyyy") & "%'"
                'End If
            Else
                str_sql = "Select count(*) from Pedido where PED_TURNO=" & TURNO & " and PED_ESTADO <> 2 and PED_FECING PED_FECING BETWEEN '" & FEC_INI & "' AND '" & FEC_FIN & "' and PED_ID=" & PEDIDO     'and PED_TIPO = '" & TIPO & "' 

            End If
            Dim opr_Conexion As New Cls_Conexion()
            opr_Conexion.sql_conectar()
            If CLng(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
                Existeturno1 = True
            End If
            opr_Conexion.sql_desconn()
        End If
        Exit Function
    End Function

    Sub ordena_notapedido(ByVal campo As String, ByVal busqueda As String, ByRef data As DataView)
        'funci�n que orderna por campo al dataview
        With data
            If Trim(busqueda) <> "" Then
                .RowFilter = campo & " like 'NP " & Trim(busqueda) & "*'"
            Else
                .RowFilter = ""
            End If
            .Sort = campo
        End With
        data.AllowEdit = True
        data.AllowNew = False
    End Sub

    Sub llenarnotaspedido(ByRef chkl_npedido As CheckedListBox, ByRef nped As Integer)

        'funcion que llena en un lista las notas de pedido
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim fecha As String
        Dim i As Int64
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand("select a.i_mov_id,a.i_prd_id, b.i_prd_descripcion, a.i_mod_cantidad,a.i_bod_id, a.i_mod_fecven, a.i_mod_lote, a.i_mod_id, c.i_mov_doc from i_movimiento_detalle as a, i_producto as b, i_movimiento as c where  a.i_mov_id= " & nped & " and a.i_mov_id = c.i_mov_id and a.i_mod_estado = 1 and a.i_prd_id = b.i_prd_id", opr_conexion.conn_sql).ExecuteReader
        'Dim odr_operacion As SqlDataReader = New SqlCommand("select i_movimiento.i_mov_id, i_movimiento.i_mov_doc from i_movimiento, i_producto, i_movimiento_detalle where i_movimiento.i_mov_id =i_movimiento_detalle.i_mov_id and i_movimiento_detalle.i_prd_id = i_producto.i_prd_id  and i_producto.div_id = " & g_division & " and i_movimiento.i_mov_estado=2 group by i_mov_id order by i_mov_doc", opr_Conexion.conn_sql).ExecuteReader
        chkl_npedido.Items.Clear()
        While odr_operacion.Read
            If IsDBNull(odr_operacion.GetValue(5).ToString.PadRight(10)) Or Trim(odr_operacion.GetValue(5).ToString.PadRight(10)) = "" Then
                fecha = "NP".PadRight(18)
            Else
                fecha = odr_operacion.GetDateTime(5).ToString.PadRight(18)
            End If
            chkl_npedido.Items.Add(odr_operacion.GetString(1).PadRight(14) & Mid(odr_operacion.GetString(2), 1, 25).PadRight(30) & odr_operacion.GetFloat(3).ToString.PadRight(5) & odr_operacion.GetString(6).PadRight(10) & fecha & odr_operacion.GetString(4).PadRight(20) & odr_operacion.GetValue(7).ToString.PadRight(3) & odr_operacion.GetValue(8).ToString.PadRight(20), False)
        End While
        For i = 0 To (chkl_npedido.Items.Count - 1)
            chkl_npedido.SetItemChecked(i, True)
        Next
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        'chkl_npedido.SelectedIndex = 0
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar notas de pedido", Err)
        Err.Clear()
    End Sub


    Public Sub llenarnotped(ByVal division As Short, ByRef data As DataView)
        'procedimiento que consulta los productos por divisi�n, para llenar un grid
        'division 1 medica, 2 diagnostica
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        'division = 0 AMBAS, 1 MEDICA, 2 DIAGNOSTICA
        If division = 0 Then
            'STR_SQL = "select i_movimiento.i_mov_id, i_movimiento.i_mov_doc from i_movimiento, i_producto, i_movimiento_detalle where i_movimiento.i_mov_id =i_movimiento_detalle.i_mov_id and i_movimiento_detalle.i_prd_id = i_producto.i_prd_id  and i_movimiento.i_mov_estado=2 group by i_mov_id order by i_mov_doc "
            STR_SQL = "select i_movimiento.i_mov_id, i_movimiento.i_mov_doc from i_movimiento, i_producto, i_movimiento_detalle where i_movimiento.i_mov_id =i_movimiento_detalle.i_mov_id and i_movimiento_detalle.i_prd_id = i_producto.i_prd_id  and i_movimiento_detalle.i_mod_estado=1 and i_movimiento.i_mov_estado <> 0 group by i_mov_id order by i_mov_doc "
        Else
            'STR_SQL = "select i_movimiento.i_mov_id, i_movimiento.i_mov_doc from i_movimiento, i_producto, i_movimiento_detalle where i_movimiento.i_mov_id =i_movimiento_detalle.i_mov_id and i_movimiento_detalle.i_prd_id = i_producto.i_prd_id  and i_producto.div_id = " & division & " and i_movimiento.i_mov_estado=2 group by i_mov_id order by i_mov_doc "
            STR_SQL = "select i_movimiento.i_mov_id, i_movimiento.i_mov_doc from i_movimiento, i_producto, i_movimiento_detalle where i_movimiento.i_mov_id =i_movimiento_detalle.i_mov_id and i_movimiento_detalle.i_prd_id = i_producto.i_prd_id  and i_producto.div_id = " & division & " and i_movimiento_detalle.i_mod_estado=1 and i_movimiento.i_mov_estado <> 0 group by i_mov_id order by i_mov_doc "
        End If
        opr_conexion.sql_conectar()
        Dim oda_operacion As New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        oda_operacion.Fill(dts_operacion, "Registros")
        opr_conexion.sql_desconn()
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = dts_operacion.Tables("Registros")
    End Sub

    Sub LlenarGridValPedidoscorregir(ByRef data As DataView, ByVal fec_ini As Date, ByVal fec_fin As Date)

        On Error Resume Next
        data.Table.Clear()
        data.AllowDelete = False
        data.AllowEdit = False
        data.AllowNew = False
        data.Table = LeerPedidosLTvalidados(g_sng_user, fec_ini, fec_fin).Tables("Registros")
    End Sub

    Public Function LeerPedidosLTvalidados(ByVal usu_id As Integer, ByVal fec_ini As Date, ByVal fec_fin As Date) As DataSet
        'Funcion que consulta los pedidos que est�n en la lista de trabajo y tienen al menos un resultado ingresado
        On Error GoTo MsgError
        Cursor.Current = Cursors.WaitCursor
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        Dim str_areas As String = ""
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer

        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)
        For int_i = 0 To arr_datos.Count - 1
            str_areas = str_areas & arr_datos(int_i) & ","
        Next
        opr_Conexion.sql_conectar()
        str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, PEDIDO.PED_TURNO as ped_turno FROM " & _
        "PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE ((LISTA_TRABAJO.LIS_reSESTADO = 2 AND NOT ISNULL(LISTA_TRABAJO.EQU_ID))) AND MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID"
        Dim areas() As String
        Dim str_aux As String = "and ("
        areas = Split(str_areas, ",")
        int_i = UBound(areas)
        'controla que tenga areas por consultar
        Dim i As Integer
        If int_i > 0 Then
            For i = 0 To (int_i - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If

        str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59')  group by PEDIDO.PED_ID order by ped_fecing desc"
        str_sql = str_sql & " " & str_aux
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerPedidosLTvalidados = New DataSet("Pedidos")
        oda_operacion.Fill(LeerPedidosLTvalidados, "Registros")
        opr_Conexion.sql_desconn()
        LeerPedidosLTvalidados.Dispose()
        Cursor.Current = Cursors.Default
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedidos", Err)
        Err.Clear()
        Cursor.Current = Cursors.Default
    End Function

    Public Function todoProcesado(ByVal int_pedido) As Boolean
        'Funcion para la consultar el c�digo m�ximo del area de test  
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        Dim x As Integer
        x = CInt(New SqlCommand("SELECT COUNT(LIS_ID) FROM LISTA_TRABAJO WHERE PED_ID = " & int_pedido & " AND LIS_RESESTADO <> 2", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        If x = 0 Then
            todoProcesado = True   'TODO PROCESADO VERDAD
        Else
            todoProcesado = False  'TODO PROCESADO FALSO FALTAN PRUEBAS
        End If
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, TodoProcesado", Err)
        Err.Clear()
    End Function

    Public Sub ingreso_aspirantes(ByVal paciente As String, ByVal desde As String, ByVal hasta As String, ByVal fecha As String, ByVal tipo As String, ByVal sexo As String)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_prue() As String
        Dim aux_prec() As String
        Dim precio As String
        Dim STR_SQL, pruebas, nom_pruebas As String
        Dim j As Integer
        Dim MaxPedido, MAXLISID, I, F As Long
        Dim pedido_grupo As String = ""
        opr_Conexion.sql_conectar()

        Cursor.Current = Cursors.WaitCursor
        'INGRESO EL PEDIDO
        Dim boo_impresionCB As Boolean = False
        For I = CLng(desde) To CLng(hasta)
            MaxPedido = LeerMaxPedido()
            pedido_grupo = MaxPedido + 1 & "," & pedido_grupo
            STR_SQL = "INSERT INTO PEDIDO VALUES (" & MaxPedido + 1 & "," & paciente & ",1,'" & fecha & " " & Format(Now, "HH:mm:ss") & "','','','NORMAL',0,'PARTICULAR',null,0,1,null," & I & ",'" & tipo & "', null);"
            odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()

            pruebas = "400101,400140,400141,400142,400114,400161,400230,400244,400277,400278,400304"
            If sexo = "F" Then pruebas = pruebas + ",400182"
            aux_prue = Split(pruebas, ",")
            precio = selec_precio(pruebas, "PARTICULAR")
            aux_prec = Split(precio, ",")
            For j = 0 To UBound(aux_prue)
                'PEDIDO DETALLE
                STR_SQL = "INSERT INTO PEDIDO_DETALLE VALUES (" & j + 1 & ",1," & MaxPedido + 1 & "," & aux_prue(j) & ",null);"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
                'PEDIDO DETALLE DESGLOSADO
                STR_SQL = "INSERT INTO PEDIDO_DETALLE_DESGLOSADO VALUES (" & MaxPedido + 1 & "," & aux_prue(j) & ",null,1, " & aux_prec(j) & ");"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Next


            'LISTA TRABAJO
            MAXLISID = opr_trabajo.LeerMaxTrabajo()
            STR_SQL = "INSERT INTO LISTA_TRABAJO VALUES (" & MAXLISID + 1 & "," & MaxPedido + 1 & ",'" & fecha & " 00:00:00'" & ",400101,2,null,null,null,0,1,0,1,null,'S','',null);"
            odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()

            For j = 1 To 3
                MAXLISID = opr_trabajo.LeerMaxTrabajo()
                STR_SQL = "INSERT INTO LISTA_TRABAJO VALUES (" & MAXLISID + 1 & "," & MaxPedido + 1 & ",'" & fecha & " 00:00:00'" & "," & aux_prue(j) & ",1,null,null,null,0,2,0,2,null,'1','',null);"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Next

            For j = 4 To 10
                MAXLISID = opr_trabajo.LeerMaxTrabajo()
                STR_SQL = "INSERT INTO LISTA_TRABAJO VALUES (" & MAXLISID + 1 & "," & MaxPedido + 1 & ",'" & fecha & " 00:00:00'" & "," & aux_prue(j) & ",null,null,null,null,0,0,0,0,null,'0','0',null);"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Next

            If sexo = "F" Then
                MAXLISID = opr_trabajo.LeerMaxTrabajo()
                STR_SQL = "INSERT INTO LISTA_TRABAJO VALUES (" & MAXLISID + 1 & "," & MaxPedido + 1 & ",'" & fecha & " 00:00:00'" & "," & aux_prue(11) & ",3,null,null,null,0,2,0,2,null,'0','',null);"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            End If

            STR_SQL = "update lista_trabajo as a, pedido as b set a.lis_resrango ='', a.lis_resestado = 2, a.lis_resmanual ='NEGATIVO' where a.ped_id = b.ped_id and b.ped_turno >= " & CLng(desde) & " and b.ped_turno <= " & CLng(hasta) & " and (a.tes_id =400161 or a.tes_id = 400278 or a.tes_id =400304 or a.tes_id = 400277);"
            odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()

            'RES PROCESADOS
            nom_pruebas = "BUN,CREA,GLU,WBC,NEU%25,LYM%25,MONO%25,EOS%25,BASO%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,MPV"
            If sexo = "H" Then nom_pruebas = "BUN,CREA,GLU,WBCH,NEU%25H,LYM%25H,MONO%25H,EOS%25H,BASO%25H,RBCH,HGBH,HCTH,MCVH,MCHH,MCHCH,RDWH,PLTH,MPVH"

            If sexo = "F" Then nom_pruebas = nom_pruebas + ",HCG-BETA_1"
            aux_prue = Split(nom_pruebas, ",")
            For j = 0 To 2
                STR_SQL = "INSERT INTO RES_PROCESADOS VALUES (" & MaxPedido + 1 & ",'','','" & aux_prue(j) & "','COM1',null,'',null,'',12);"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Next

            For j = 3 To 17
                STR_SQL = "INSERT INTO RES_PROCESADOS VALUES (" & MaxPedido + 1 & ",'','','" & aux_prue(j) & "','COM2',null,'',null,'',1);"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Next

            If sexo = "F" Then
                'el tim_id es 2 para manejar suero...... verificar que tipo de muestra se va a utilizar
                STR_SQL = "INSERT INTO RES_PROCESADOS VALUES (" & MaxPedido + 1 & ",'','','" & aux_prue(18) & "','COM3',null,'',null,'',13);"
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            End If
            'JPO
            'PREGUNTO SI DESEO IMPRIMIR LAS ETIQUETAS DE CB, EN CASO AFIRMATIVO PROCEDO A MANDAR A IMPRIMIR DE PEDIDO EN PEDIDO NO EN BLOQUE...
            If I = CLng(desde) Then
                If MsgBox("Desea Imprimir las etiquetas de codigo de barras?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                    boo_impresionCB = True
                End If
            End If
            If boo_impresionCB = True Then
                imprimir_codigo(MaxPedido + 1, CDate(fecha))
            End If
        Next
        'EL SIGUIENTE CODIGO SIRVE PARA IMPRIMIR LAS ETIQUETAS DE CODIGO DE BARRAS EN BLOQUE....
        'If MsgBox("Desea Imprimir las etiquetas de codigo de barras?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
        '    imprimir_codigo(pedido_grupo, "Aspirante")
        'End If
        Cursor.Current = Cursors.Default
        opr_Conexion.sql_desconn()
        MsgBox("Los Aspirantes han sido almacenados.", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Ingresar Aspirante.", Err)
        Err.Clear()
    End Sub


    Public Function devuelveIdpaciente(ByVal convenio As String) As String
        'Funcion para la consultar el ID para paciente de un convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        devuelveIdpaciente = (New SqlCommand("select isnull(pac_id,0) as PAC_ID from paciente where paciente.PAC_GRADO = '" & convenio & "'", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Devolver ID convenio, Cls_TRABAJO", Err)
        Err.Clear()
    End Function


    Public Function devuelveOrdenPedido(ByVal ped_id As Integer) As String
        'Funcion para la consultar el ID para paciente de un convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "SELECT DISTINCT (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) ) + " & _
            "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
            "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno " & _
            "from pedido where ped_id = " & ped_id & ""

        opr_Conexion.sql_conectar()
        devuelveOrdenPedido = (New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Devolver No ORDEN, Cls_PEDIDO", Err)
        Err.Clear()
    End Function


    Public Function devuelveMaxPresentacion() As String
        'Funcion para la consultar el ID para paciente de un convenio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "SELECT max(PRES_ID) from VademecumPresentacion"

        opr_Conexion.sql_conectar()
        devuelveMaxPresentacion = (New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Devolver No ORDEN, Cls_PEDIDO", Err)
        Err.Clear()
    End Function


    Public Function GestionaConsulta(ByVal con_id As Integer, ByVal med_id As Integer, ByVal pac_id As Integer, ByVal age_id As Integer, ByVal con_diagnostico As String, ByVal con_obs As String, ByVal con_estado As String, ByVal tipoTx As String, ByVal cie_cod4 As String) As Boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_med() As String
        Dim STR_SQL As String
        Dim MaxConsulta As Integer

        GestionaConsulta = False
        opr_Conexion.sql_conectar()
        Select Case tipoTx
            Case "Insert"
                STR_SQL = "insert into consultaMedico values(" & con_id & "," & med_id & "," & pac_id & ", null," & age_id & ",'','','PENDIENTE','',0,0)"

            Case "Update"
                STR_SQL = "update consultaMedico set con_fecha = '" & Format(Now(), "dd/MM/yyyy HH:mm:ss") & "', con_diagnostico = '" & Trim(con_diagnostico) & "', con_estado = '" & Trim(con_estado) & "' where Age_id = " & age_id & " and med_id = " & med_id & " and pac_id = " & pac_id & ""

        End Select
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        GestionaConsulta = True
        Exit Function

MsgError:
        GestionaConsulta = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, actualiza consultas.", Err)
        Err.Clear()

    End Function


    Public Function GestionaConsultaCie10(ByVal Age_id As Integer, ByVal med_id As Integer, ByVal cie_cod4 As String, ByVal tipoTx As String) As Boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim arre_cie As String()
        Dim STR_SQL As String
        Dim i As Integer

        GestionaConsultaCie10 = False
        opr_Conexion.sql_conectar()

        Select Case tipoTx
            Case "Eliminar"
                STR_SQL = "delete from cie10Consulta where cie_cod4 = '" & cie_cod4 & "' and Age_id = " & Age_id & " and med_id = " & med_id & ""
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()

            Case "Insertar"
                STR_SQL = "insert into cie10Consulta values('" & cie_cod4 & "', " & Age_id & "," & med_id & ")"
        End Select


        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        GestionaConsultaCie10 = True
        Exit Function

MsgError:
        GestionaConsultaCie10 = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, actualiza consultas CI10.", Err)
        Err.Clear()

    End Function


    Public Function GestionaCie10(ByVal cie_cod3 As String, ByVal cie_desc3 As String, ByVal cie_cod4 As String, ByVal cie_desc4 As String, ByVal tipoTx As String) As Boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim arre_cie As String()
        Dim STR_SQL As String
        Dim i As Integer

        GestionaCie10 = False
        opr_Conexion.sql_conectar()

        Select Case tipoTx
            Case "Eliminar"
                STR_SQL = "delete from cie10 where cie_cod3 = '" & cie_cod3 & "' and cie_desc3 = " & cie_desc3
                odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()

            Case "Insertar"
                STR_SQL = "insert into cie10 values('" & cie_cod3 & "', '" & cie_desc3 & "', '" & cie_cod4 & "','" & cie_desc4 & "')"

            Case "Actualizar"
                STR_SQL = "update cie10 set cie_cod3 = '" & cie_cod3 & "', cie_desc3 = '" & cie_desc3 & "', cie_cod4 = '" & cie_cod4 & "', cie_desc4 = '" & cie_desc4 & "')"
        End Select


        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        GestionaCie10 = True
        Exit Function

MsgError:
        GestionaCie10 = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, actualiza consultas CI10.", Err)
        Err.Clear()

    End Function

    Public Sub GestionaReceta(ByVal rec_id As Integer, ByVal age_id As Integer, ByVal med_id As Integer, ByVal pac_id As Integer, ByVal rec_medicacion As String, ByVal rec_indicaciones As String, ByVal rec_dieta As String, ByVal rec_estado As String, ByVal cie_cod4 As String, ByVal swExisteReceta As Boolean)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_med() As String
        Dim STR_SQL As String
        Dim MaxConsulta As Integer
        Dim rec_fecven As Date

        rec_fecven = DateAdd(DateInterval.Day, CInt(System.Configuration.ConfigurationSettings.AppSettings("DIAS_RECETA")), Now)
        opr_Conexion.sql_conectar()
        Select Case swExisteReceta
            Case False
                STR_SQL = "insert into receta values(" & rec_id & ",'" & Format(Now(), "dd-MM-yyyy") & "'," & age_id & "," & med_id & ", " & pac_id & ",'" & rec_medicacion & "','" & rec_indicaciones & "', '" & rec_dieta & "', 'PENDIENTE', '" & rec_fecven & "')"
            Case True
                STR_SQL = "update receta set rec_fecha = '" & Format(Now(), "dd-MM-yyyy") & "', rec_medicacion = '" & rec_medicacion & "', rec_indicaciones = '" & rec_indicaciones & "', rec_dieta = '" & rec_dieta & "', rec_estado = '" & rec_estado & "', rec_fecvenc = '" & rec_fecven & "' where Age_id = " & age_id & " and pac_id = " & pac_id & ""

        End Select
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Crear consultas.", Err)
        Err.Clear()

    End Sub


    Public Sub GestionaInterpretacion(ByVal ped_id As Integer, ByVal prcc_interp_Alimentos As String, ByVal prcc_interp_Sustancias As String, ByVal prcc_interp_Inhalantes As String, ByVal prcc_interp_MedicAINES As String, ByVal prcc_interp_MedicAB As String, ByVal prcc_interp_MedicOTROS As String, ByVal prcc_interp_Recomendacion As String, ByVal prcc_interp_Recomendacion2 As String, ByVal PAC_ID As Integer, ByVal AGE_ID As Integer, ByVal ExisteInterpretacion As Boolean)
        On Error GoTo MsgError
        Dim opr_pedido = New Cls_Pedido()
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_med() As String
        Dim STR_SQL As String
        Dim MaxConsulta As Integer
        Dim fechaHora As DateTime = Format(Now, "dd-MM-yyyy HH:mm")

        opr_Conexion.sql_conectar()
        Select Case ExisteInterpretacion
            Case False
                STR_SQL = "insert into res_cutaneasInterpretacion values(" & ped_id & ",'" & Mid(fechaHora, 1, 10) & "','" & Mid(fechaHora, 11, 6) & "', '" & prcc_interp_Alimentos & "', '" & prcc_interp_Sustancias & "', '" & prcc_interp_Inhalantes & "', '" & prcc_interp_MedicAINES & "', '" & prcc_interp_MedicAB & "', '" & prcc_interp_MedicOTROS & "' , '" & prcc_interp_Recomendacion & "', '" & prcc_interp_Recomendacion2 & "', '" & g_invitadoID & "'," & PAC_ID & ", " & AGE_ID & ")"
            Case True
                STR_SQL = "update res_cutaneasInterpretacion set prcc_fecha = '" & Mid(fechaHora, 1, 10) & "', prcc_hora = '" & Mid(fechaHora, 11, 6) & "', PRCC_INT_ALIMENTOS = '" & prcc_interp_Alimentos & "', PRCC_INT_SUSTANCIAS = '" & prcc_interp_Sustancias & "', PRCC_INT_INHALANTES = '" & prcc_interp_Inhalantes & "', PRCC_INT_MED_AINES = '" & prcc_interp_MedicAINES & "', PRCC_INT_MED_AB = '" & prcc_interp_MedicAB & "', PRCC_INT_MED_OTRAS = '" & prcc_interp_MedicOTROS & "', PRCC_INT_RECOMEN1 = '" & prcc_interp_Recomendacion & "', PRCC_INT_RECOMEN2 = '" & prcc_interp_Recomendacion2 & "', LIS_USER = '" & g_invitadoID & "', PAC_ID = " & PAC_ID & ", AGE_ID = " & AGE_ID & " where PED_ID = " & ped_id

        End Select
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        opr_pedido.VisualizaMensaje("INTERPRETACION actualizada satisfactoriamente", 300)
        Exit Sub

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Crear Interpetacion.", Err)
        Err.Clear()

    End Sub

    Public Function GestionaTTO(ByVal Age_id As Integer, ByVal med_id As Integer, ByVal pac_id As Integer, ByVal I_prd_id As String, ByVal ser_cantidad As Decimal, ByVal tto_fecha As String, ByVal vac_lote As String, ByVal TTO_COSTO As Decimal, ByVal SERIE_ID As String, ByVal tipoTx As String, ByVal ventana_tipo As Integer, ByVal TTO_PROCESO As String) As Boolean
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_med() As String
        Dim STR_SQL As String
        Dim MaxConsulta As Integer

        GestionaTTO = False
        opr_Conexion.sql_conectar()
        Select Case (ventana_tipo)

            Case 0 ''CLIENTE
                Select Case tipoTx
                    Case "Insert"
                        STR_SQL = "insert into TratamientoCliente values(" & Age_id & "," & med_id & ", '" & I_prd_id & "', " & ser_cantidad & ", '" & vac_lote & "','" & tto_fecha & "','" & SERIE_ID & "', " & TTO_COSTO & ")"

                    Case "Update"
                        STR_SQL = "update TratamientoCliente set con_fecha = '" & Format(Now(), "dd/MM/yyyy HH:mm:ss") & "',  vac_lote = '" & Trim(vac_lote) & "', tto_cantidad = " & ser_cantidad & ", I_PRD_ID = '" & I_prd_id & "', SER_ID = '" & SERIE_ID & "', TTO_COSTO = " & TTO_COSTO & " where Age_id = " & Age_id & " and med_id = " & med_id & " "
                End Select

            Case 1 ''PACIENTE
                Select Case tipoTx
                    Case "Insert"
                        STR_SQL = "insert into TratamientoPaciente values(" & Age_id & "," & pac_id & "," & med_id & ", '" & I_prd_id & "', " & ser_cantidad & ", '" & vac_lote & "','" & tto_fecha & "','" & SERIE_ID & "', " & TTO_COSTO & ")"

                    Case "Update"
                        STR_SQL = "update TratamientoPaciente set con_fecha = '" & Format(Now(), "dd/MM/yyyy HH:mm:ss") & "',  vac_lote = '" & Trim(vac_lote) & "', tto_cantidad = " & ser_cantidad & ", I_PRD_ID = '" & I_prd_id & "', SER_ID = '" & SERIE_ID & "', TTO_COSTO = " & TTO_COSTO & " where Age_id = " & Age_id & " and med_id = " & med_id & " and pac_id = " & pac_id & ""
                End Select

            Case 2 ''PREPARACION
                Select Case tipoTx
                    Case "Insert"
                        STR_SQL = "insert into TratamientoPreparacion values('" & I_prd_id & "', " & ser_cantidad & ", '" & vac_lote & "','" & tto_fecha & "','" & SERIE_ID & "', " & TTO_COSTO & ", '" & TTO_PROCESO & "')"

                    Case "Update"
                        STR_SQL = "update TratamientoPreparacion set con_fecha = '" & Format(Now(), "dd/MM/yyyy HH:mm:ss") & "',  vac_lote = '" & Trim(vac_lote) & "', tto_cantidad = " & ser_cantidad & ", I_PRD_ID = '" & I_prd_id & "', SER_ID = '" & SERIE_ID & "', TTO_COSTO = " & TTO_COSTO & ", TTO_PROCESO = '" & TTO_PROCESO & "' where Age_id = " & I_prd_id & " "
                End Select
        End Select

        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        GestionaTTO = True
        Exit Function

MsgError:
        GestionaTTO = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, actualiza consultas.", Err)
        Err.Clear()

    End Function


    Public Sub ingreso_OrdenAgenda(ByVal pacienteID As String, ByVal fecha As String, ByVal convenio As String, ByVal param_procedimiento As String, ByVal prioridad As String, ByVal edad As Integer, ByVal unidad As String, ByVal genero As String, ByVal turno As Integer, ByVal ped_id As Integer, ByVal med_id As Integer, ByVal ped_turno As Integer)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_prue() As String
        Dim aux_prec() As String
        Dim precio As String
        Dim STR_SQL, pruebas, nom_pruebas As String
        Dim j As Integer
        Dim MaxPedido, MAXLISID, I, F As Long
        Dim elec As String = ""
        Dim pedido_grupo As String = ""
        opr_Conexion.sql_conectar()
        Dim opr_pedido As New Cls_Pedido()
        Dim parametros As String

        Cursor.Current = Cursors.WaitCursor
        'INGRESO EL PEDIDO



        'MaxPedido = LeerMaxPedido() + 1
        parametros = fecha & "/" & convenio & "/" & turno
        If opr_pedido.GuardarPedidoAgenda(parametros, CLng(pacienteID), CLng(ped_id), 1, param_procedimiento, fecha, edad, unidad, genero, med_id, turno, "Insert") > 0 Then

        Else

        End If
        'opr_trabajo.InsertPtoPdf(MaxPedido, "MEDICO", 0)
        'opr_trabajo.InsertPtoImg(MaxPedido)



        Cursor.Current = Cursors.Default
        opr_Conexion.sql_desconn()
        'opr_pedido.VisualizaMensaje("Orden ingresada satisfactoriamente", 300)
        'MsgBox("Las ordenes PRE CARGA han sido almacenadas satisfactoriamente.", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Ingresar Ascensos.", Err)
        Err.Clear()
    End Sub

    Public Sub actualizaDermografico(ByVal dermografico As Integer, ByVal Age_id As Integer)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_med() As String
        Dim STR_SQL As String
        Dim MaxConsulta As Integer

        'actualizaDermografico = False
        opr_Conexion.sql_conectar()

        STR_SQL = "update consultaMedico set con_dermografico = " & dermografico & " where Age_id = " & Age_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        'actualizaDermografico = True
        Exit Sub

MsgError:
        'actualizaDermografico = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, actualiza consultas.", Err)
        Err.Clear()

    End Sub


    Public Sub actualizaInfante(ByVal infante As Integer, ByVal Age_id As Integer)
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_med() As String
        Dim STR_SQL As String
        Dim MaxConsulta As Integer

        'actualizaDermografico = False
        opr_Conexion.sql_conectar()

        STR_SQL = "update consultaMedico set con_infante = " & infante & " where Age_id = " & Age_id
        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        'actualizaDermografico = True
        Exit Sub

MsgError:
        'actualizaDermografico = False
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, actualiza infante.", Err)
        Err.Clear()

    End Sub

    Public Sub ingreso_Cutaneas(ByVal dgv_alimentos As DataGridView, ByVal dgv_sustancias As DataGridView, ByVal dgv_inhalantes As DataGridView, ByVal dgv_medicamentos As DataGridView, ByVal dgv_antibioticos As DataGridView, ByVal dgv_otros As DataGridView, ByVal ped_id As Integer, ByVal fecha As String, ByVal hora As String)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL, pruebas, nom_pruebas As String
        Dim j As Integer

        opr_Conexion.sql_conectar()
        Dim opr_pedido As New Cls_Pedido()


        'INGRESO EL CUTANEAS
        For j = 0 To dgv_alimentos.Rows.Count - 1
            If IsDBNull(dgv_alimentos.Rows(j).Cells(6).Value) = True Then
                dgv_alimentos.Rows(j).Cells(6).Value = ""
            End If
            opr_pedido.GuardarCutaneas(ped_id, fecha, hora, dgv_alimentos.Rows(j).Cells(3).Value, Trim(dgv_alimentos.Rows(j).Cells(5).Value), Trim(dgv_alimentos.Rows(j).Cells(6).Value), dgv_alimentos.Rows(j).Cells(11).Value, dgv_alimentos.Rows(j).Cells(13).Value)
        Next

        For j = 0 To dgv_sustancias.Rows.Count - 1
            If IsDBNull(dgv_sustancias.Rows(j).Cells(6).Value) = False Then
                If Trim(dgv_sustancias.Rows(j).Cells(6).Value) <> "" Then
                    opr_pedido.GuardarCutaneas(ped_id, fecha, hora, dgv_sustancias.Rows(j).Cells(3).Value, Trim(dgv_sustancias.Rows(j).Cells(5).Value), Trim(dgv_sustancias.Rows(j).Cells(6).Value), dgv_sustancias.Rows(j).Cells(11).Value, dgv_sustancias.Rows(j).Cells(13).Value)
                End If
            End If
        Next

        For j = 0 To dgv_inhalantes.Rows.Count - 1
            If IsDBNull(dgv_inhalantes.Rows(j).Cells(6).Value) = False Then
                If Trim(dgv_inhalantes.Rows(j).Cells(6).Value) <> "" Then
                    opr_pedido.GuardarCutaneas(ped_id, fecha, hora, dgv_inhalantes.Rows(j).Cells(3).Value, Trim(dgv_inhalantes.Rows(j).Cells(5).Value), Trim(dgv_inhalantes.Rows(j).Cells(6).Value), dgv_inhalantes.Rows(j).Cells(11).Value, dgv_inhalantes.Rows(j).Cells(13).Value)
                End If
            End If
        Next

        For j = 0 To dgv_medicamentos.Rows.Count - 1
            If IsDBNull(dgv_medicamentos.Rows(j).Cells(6).Value) = False Then
                If Trim(dgv_medicamentos.Rows(j).Cells(6).Value) <> "" Then
                    opr_pedido.GuardarCutaneas(ped_id, fecha, hora, dgv_medicamentos.Rows(j).Cells(3).Value, Trim(dgv_medicamentos.Rows(j).Cells(5).Value), Trim(dgv_medicamentos.Rows(j).Cells(6).Value), dgv_medicamentos.Rows(j).Cells(11).Value, dgv_medicamentos.Rows(j).Cells(13).Value)
                End If
            End If
        Next

        For j = 0 To dgv_antibioticos.Rows.Count - 1
            If IsDBNull(dgv_antibioticos.Rows(j).Cells(6).Value) = False Then
                If Trim(dgv_antibioticos.Rows(j).Cells(6).Value) <> "" Or IsDBNull(dgv_antibioticos.Rows(j).Cells(6).Value) Then
                    opr_pedido.GuardarCutaneas(ped_id, fecha, hora, dgv_antibioticos.Rows(j).Cells(3).Value, Trim(dgv_antibioticos.Rows(j).Cells(5).Value), Trim(dgv_antibioticos.Rows(j).Cells(6).Value), dgv_antibioticos.Rows(j).Cells(11).Value, dgv_antibioticos.Rows(j).Cells(13).Value)
                End If
            End If
        Next

        For j = 0 To dgv_otros.Rows.Count - 1
            If IsDBNull(dgv_otros.Rows(j).Cells(6).Value) = False Then
                If Trim(dgv_otros.Rows(j).Cells(6).Value) <> "" Or IsDBNull(dgv_otros.Rows(j).Cells(6).Value) Then
                    opr_pedido.GuardarCutaneas(ped_id, fecha, hora, dgv_otros.Rows(j).Cells(3).Value, Trim(dgv_otros.Rows(j).Cells(5).Value), Trim(dgv_otros.Rows(j).Cells(6).Value), dgv_otros.Rows(j).Cells(11).Value, dgv_otros.Rows(j).Cells(13).Value)
                End If
            End If
        Next

        opr_Conexion.sql_desconn()
        opr_pedido.VisualizaMensaje("PRUEBAS CUTANEAS almacenadas satisfactoriamente", 300)
        'MsgBox("PRUEBAS CUTANEAS almacenadas satisfactoriamente.", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Pruebas cutaneas.", Err)
        Err.Clear()
    End Sub



    Public Sub ingreso_convenios(ByVal pacienteID As String, ByVal desde As String, ByVal hasta As String, ByVal fecha As String, ByVal convenio As String, ByVal dtt_pedido1 As DataTable, ByVal prioridad As String, ByRef ProgressBar1 As ProgressBar, ByRef lbl_generado As Label, ByVal edad As Integer, ByVal genero As String)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim aux_prue() As String
        Dim aux_prec() As String
        Dim precio As String
        Dim STR_SQL, pruebas, nom_pruebas As String
        Dim j As Integer
        Dim MaxPedido, MAXLISID, I, F As Long
        Dim elec As String = ""
        Dim pedido_grupo As String = ""
        opr_Conexion.sql_conectar()
        Dim opr_pedido As New Cls_Pedido()
        Dim parametros As String
        Cursor.Current = Cursors.WaitCursor
        'INGRESO EL PEDIDO
        Dim incremento As Integer = 100 / (CLng(hasta) - CLng(desde))


        For I = CLng(desde) To CLng(hasta)
            lbl_generado.Text = desde
            ProgressBar1.Increment(incremento)

            MaxPedido = LeerMaxPedido() + 1
            parametros = fecha & "," & convenio & "," & prioridad & "," & desde
            If opr_pedido.GuardarPedidoConvenio(parametros, CLng(pacienteID), CLng(MaxPedido), 1, dtt_pedido1, fecha, edad, genero) > 0 Then

            Else

            End If
            'ProgressBar1.Increment(incremento)
            opr_trabajo.InsertPtoPdf(MaxPedido, "LABORATORIO", 0)
            opr_trabajo.InsertPtoImg(MaxPedido.ToString, "QR")
            desde = desde + 1
        Next


        Cursor.Current = Cursors.Default
        opr_Conexion.sql_desconn()
        opr_pedido.VisualizaMensaje("Las ordenes PRE CARGA han sido almacenadas satisfactoriamente", 300)
        'MsgBox("Las ordenes PRE CARGA han sido almacenadas satisfactoriamente.", MsgBoxStyle.Information, "ANALISYS")
        Exit Sub

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Ingresar Ascensos.", Err)
        Err.Clear()
    End Sub

    Public Sub imprimir_codigo(ByVal ped_id As String, ByVal fecha As Date)

        Dim str_imprimir, str_codigo_barras As String
        Dim dts_muestra As DataSet
        Dim dtr_fila As DataRow
        Dim opr_muestra As New Cls_Muestra()


        dts_muestra = selec_tubos(ped_id)

        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
        If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
            Dim imp_archivo As FileStream = File.Create(str_imprimir)
            imp_archivo.Close()
        End If
        'abro un archivo para generar as lineas que me permitira imprimir un ocdigode barras
        FileOpen(1, str_imprimir, OpenMode.Output)
        Dim int_aux, i As Integer
        Dim str_cadena As String

        For Each dtr_fila In dts_muestra.Tables("Registros").Rows

            'linea obligatoria
            PrintLine(1, "")
            PrintLine(1, "N")
            'reseteo la impresora
            PrintLine(1, "OD")
            'tama�o horizontal
            PrintLine(1, "q456")
            'tamaño vertical
            PrintLine(1, "Q220,40+0")
            'PrintLine(1, "Q50,0+0") 'GCT

            'estas tres lineas son obligatorias son seteos de la impresora
            PrintLine(1, "S2") 'S= velocidad
            PrintLine(1, "D8")  'D = Densidad
            PrintLine(1, "ZT")  'Z = Orientaci�n de la impresi�n, T = desde el tope.

            'mando a escrribir en letras normales el primer 1 en la cadena de par�metros de el tama�o del encabezado
            PrintLine(1, "A100,10,0,1,2,1,N," & """'" & g_Titulo & "'""")

            'mprimir los datos del paciente
            str_cadena = dtr_fila(4)
            If Len(str_cadena) > 40 Then
                str_cadena = Mid(str_cadena, 1, 35)
            End If
            PrintLine(1, "A100,30,0,1,1,1,N," & """" & str_cadena.ToString & """")
            'ÌMPRIMO(CONVENIO)

            PrintLine(1, "A380,150,3,1,1,1,N," & """" & dtr_fila(6).ToString & """")

            'mando a escrribir en letras normales el primer 1 en la cadena de par�metros de el tama�o del encabezado
            'PrintLine(1, "A125,2,0,1,1,2,N," & """Lab. CRUZ BLANCA""")
            'PrintLine(1, "A6,152,3,1,1,2,R," & """Turno""")

            'PrintLine(1, "A28,122,3,2,1,1,R," & """" & str_cadena.ToString & """")
            'PrintLine(1, "A15,152,3,1,1,2,R," & """" & Mid(str_cadena.ToString, 5, 4) & """")
            'PrintLine(1, "A250,171,0,1,1,1,N," & """" & dtr_fila(1).ToString & """")
            'PrintLine(1, "A450,50,1,1,1,1,N," & """" & Today & """")

            ''ESCRIBE EL TIPO DE ENVASE EN VERTICAL IZQUIERDA ETIQUETAS NORMALES
            PrintLine(1, "A50,145,3,1,1,1,N," & """" & Trim(dtr_fila(1).ToString) & """")


            ''ESCRIBE SERVICIO EN VERTICAL IZQUIERDA ETIQUETAS NORMALES
            PrintLine(1, "A80,170,3,1,1,1,N," & """" & Trim(dtr_fila(6).ToString) & """")
            'MsgBox(Trim(dtr_fila(6).ToString))
            'PrintLine(1, "A70,145,3,1,1,1,N," & """" & lbl_Servicio.Text & """")

            'FECHA DEL PEDIDO
            str_cadena = Mid(fecha, 4, 2) & Mid(fecha, 1, 2) & Format(CInt(dtr_fila(3).ToString), "00000")

            PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(fecha), "dd/MM/yyyy") & """")

            'CI + EDAD
            PrintLine(1, "A100,174,0,1,1,1,N," & """" & dtr_fila(5).ToString & """")
            'PrintLine(1, "A240,174,0,1,1,1,N," & """" & "EDAD: " & lbl_edad.Text & """")



            Dim TIPO_MUESTRA As Int64 'Variable para determinar el tipo de muestra a utilizar.
            TIPO_MUESTRA = opr_muestra.selec_muestra(dtr_fila(0), dtr_fila(1).ToString)

            str_cadena = str_cadena & "-" & TIPO_MUESTRA

            'IMPRIME EL CODIGO DE BARRAS.
            PrintLine(1, "B100,50,0,1,2,5,72,B," & """" & str_cadena & """")



            PrintLine(1, "P1")
        Next
        'estas lineas son necesario para que la imrpesora regrese a su estado natura
        PrintLine(1, "")
        PrintLine(1, "OD")
        PrintLine(1, "q456")
        'tamaño vertical
        PrintLine(1, "Q220,40+0")
        PrintLine(1, "S2")
        PrintLine(1, "D8")
        PrintLine(1, "ZT")
        FileClose(1)
        'mando a copiar el archivo generado en el puerto designado
        On Error Resume Next
        Dim str_var As String
        str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")

        FileCopy(str_imprimir, str_var)

    End Sub

    Public Function LeerPedidodeturno(ByVal i_turno As Integer, ByVal f_turno As Integer, ByVal fecha As Date, ByVal tipo As String) As String
        'FUNCION PARA ESCOGER EL PEDIDO DE UN RANGO DE TURNOS SELECCIONADOS.
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_estado As New DataSet()
        Dim dtr_fila As DataRow
        Dim str_sql As String = Nothing
        LeerPedidodeturno = ""
        opr_conexion.sql_conectar()

        str_sql = "select ped_id from pedido where ped_tipo = '" & tipo & "' and ped_estado <> 2 and cast(ped_fecing as DATE) like '" & Format(fecha, "yyyy-MM-dd") & "%'  and ped_id between " & i_turno & " and " & f_turno & ";"
        oda_pedido.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_pedido.Fill(dts_estado, "Registros")
        opr_conexion.sql_desconn()
        For Each dtr_fila In dts_estado.Tables("Registros").Rows
            LeerPedidodeturno = LeerPedidodeturno & dtr_fila(0) & ","
        Next
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Pedido del turno", Err)
        Err.Clear()
    End Function

    Public Function selec_tubos(ByVal ped_id As String) As DataSet
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_pedido As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        Dim pedido() As String
        Dim var_pedid As String
        Dim i As Integer

        'validaci�n por areas.
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0
        Dim str_aux As String = "and ("


        opr_conexion.sql_conectar()
        pedido = Split(ped_id, ",")
        If UBound(pedido) > 0 Then
            For i = 0 To UBound(pedido) - 1
                If i = 0 Then
                    var_pedid = var_pedid & "pedido.PED_ID =" & pedido(i)
                Else
                    var_pedid = var_pedid & " or pedido.PED_ID =" & pedido(i)
                End If
            Next

        Else
            var_pedid = var_pedid & "pedido.PED_ID =" & ped_id
        End If

        If (g_CBpedido) Then

            STR_SQL = "select pedido.PED_ID, 'PEDIDO                   ' as tit_nombre, '1' as pee_cantidad,pedido.PED_TURNO, ('('+paciente.pac_sexo + ')-'+ paciente.pac_apellido+' '+ paciente.pac_nombre) as nombres, paciente.PAC_DOC as CI, pedido.CON_NOMBRE as convenio, pedido.PED_SERVICIO " & _
                "from lista_trabajo, test, tipo_muestra, tipo_tubo, pedido, paciente " & _
                "where pedido.ped_id = lista_trabajo.ped_id and pedido.pac_id = paciente.pac_id and test.tes_id = lista_trabajo.tes_id and tipo_muestra.tim_id = test.tim_id and tipo_muestra.tit_id = tipo_tubo.tit_id And (pedido.PED_ID ='" & ped_id & "') " & _
                "UNION " & _
                "select pedido.PED_ID, tipo_tubo.TIT_NOMBRE, test.TES_CODBARRAS as pee_cantidad,pedido.PED_TURNO, ('('+paciente.pac_sexo + ')-'+ paciente.pac_apellido+' '+ paciente.pac_nombre) as nombres, paciente.PAC_DOC as CI, pedido.CON_NOMBRE as convenio, pedido.PED_SERVICIO " & _
                "from lista_trabajo, test, tipo_muestra, tipo_tubo, pedido, paciente " & _
                "where pedido.ped_id = lista_trabajo.ped_id and pedido.pac_id = paciente.pac_id and test.tes_id = lista_trabajo.tes_id and tipo_muestra.tim_id = test.tim_id and tipo_muestra.tit_id = tipo_tubo.tit_id And (pedido.PED_ID ='" & ped_id & "') " & _
                "group by pedido.ped_id, tipo_tubo.TIT_NOMBRE,test.TES_CODBARRAS,pedido.PED_TURNO, paciente.pac_apellido, paciente.pac_nombre, paciente.pac_sexo, paciente.PAC_DOC, pedido.CON_NOMBRE, pedido.PED_SERVICIO "

            STR_SQL = STR_SQL '& " group by ped_id, tit_nombre order by ped_id;"

        Else

            STR_SQL = "select pedido.PED_ID, tipo_tubo.TIT_NOMBRE, test.TES_CODBARRAS as pee_cantidad,pedido.PED_TURNO, ('('+paciente.pac_sexo + ')-'+ paciente.pac_apellido+' '+ paciente.pac_nombre) as nombres, paciente.PAC_DOC as CI, pedido.CON_NOMBRE as convenio " & _
                "from lista_trabajo, test, tipo_muestra, tipo_tubo, pedido, paciente " & _
                "where pedido.ped_id = lista_trabajo.ped_id and pedido.pac_id = paciente.pac_id and test.tes_id = lista_trabajo.tes_id and tipo_muestra.tim_id = test.tim_id and tipo_muestra.tit_id = tipo_tubo.tit_id And (pedido.PED_ID ='" & ped_id & "') " & _
                "group by pedido.ped_id, tipo_tubo.TIT_NOMBRE,test.TES_CODBARRAS,pedido.PED_TURNO, paciente.pac_apellido, paciente.pac_nombre, paciente.pac_sexo, paciente.PAC_DOC, pedido.CON_NOMBRE  "

            STR_SQL = STR_SQL '& " group by ped_id, tit_nombre order by ped_id;"
        End If
        oda_pedido.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        selec_tubos = New DataSet()
        oda_pedido.Fill(selec_tubos, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Detalle Pedido De Factura", Err)
        Err.Clear()
    End Function


    Function selec_precio(ByVal pruebas As String, ByVal convenio As String) As String
        'Funcion para la consultar el precio de ascensos y aspirantes
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim aux_prue() As String
        Dim prec As String = ""
        Dim i As Integer
        opr_Conexion.sql_conectar()
        aux_prue = Split(pruebas, ",")
        For i = 0 To UBound(aux_prue)
            prec = prec & New SqlCommand("select lip_precio from lista_precio where con_nombre = '" & convenio & "' AND tes_id = " & aux_prue(i) & ";", opr_Conexion.conn_sql).ExecuteScalar & ","
        Next
        selec_precio = prec
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Seleccionar Precio", Err)
        Err.Clear()
    End Function


    Public Sub InsertaAuxHis(ByVal str_sql As String)
        'PROCEDIMIENTO para insertar un reg en AUX HIS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        opr_Conexion.sql_conectar()
        'STR_SQL = "update res_procesados set PRC_NOTASECC = '" & nota & "' where PED_ID = " & ped_id & " and are_id = " & are_id & "; "
        odc_pedido = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar AUX_HIS", Err)
        Err.Clear()
    End Sub



End Class