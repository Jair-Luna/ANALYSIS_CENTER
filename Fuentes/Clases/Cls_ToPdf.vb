'*************************************************************************
' Nombre:   Cls_ToPdf
' Tipo de Archivo: Clase
' Descripción:  Clase para egnerar archivos pdf
' Autores:  rfn
' Fecha de Creación: 2017-agosto
' Autores Modificaciones: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.IO
Imports System.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient


Public Class Cls_ToPdf

    Dim opr_conexion As New Cls_Conexion()

    Public Shared Function ExportToPDF(ByVal rpt As ReportDocument, ByVal NombreArchivo As String, ByVal pathFolder As String) As String
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()

        Try
            rpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            rpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

            'Este es la ruta donde se guardara tu archivo.

            If Dir(Environment.CurrentDirectory & "\" & pathFolder, FileAttribute.Directory) = "" Then MkDir(Environment.CurrentDirectory & "\" & pathFolder)
            vFileName = Environment.CurrentDirectory & "\" & pathFolder & "\" & NombreArchivo
            'str_archivo = g_str_transaccion & "\Log-" & Month(Now) & "-" & Year(Now) & ".log"


            'If Dir(Environment.CurrentDirectory & pathFolder, FileAttribute.Directory) = "" Then
            'MkDir(Environment.CurrentDirectory & "\" & pathFolder)


            'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo
            If File.Exists(vFileName) Then
                'FileOpen(1, vFileName, OpenMode.Input)   ' Open file.
                'Do While Not EOF(1)   ' Loop until end of file.
                '    vFileName = LineInput(1)   ' Read line into variable.
                '    'MsgBox(TextLine)   ' Display the line
                'Loop
                'FileClose(1)
                File.Delete(vFileName)
            End If
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            'rpt.SummaryInfo.ReportAuthor = g_Titulo
            rpt.Export()
            rpt.Refresh()

        Catch ex As Exception
            'Throw ex
        End Try
        rpt.Refresh()
        Return vFileName
    End Function


    Public Shared Function EliminaQR(ByVal NombreArchivo As String, ByVal pathFolder As String) As String
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()

        Try
            'Este es la ruta donde se elimina archivo.

            If Dir(Environment.CurrentDirectory & "\" & pathFolder, FileAttribute.Directory) <> "" Then
                vFileName = Environment.CurrentDirectory & "\" & pathFolder & "\" & NombreArchivo & ".jpg"
                'str_archivo = g_str_transaccion & "\Log-" & Month(Now) & "-" & Year(Now) & ".log"


                'If Dir(Environment.CurrentDirectory & pathFolder, FileAttribute.Directory) = "" Then
                'MkDir(Environment.CurrentDirectory & "\" & pathFolder)


                'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo
                If File.Exists(vFileName) Then
                    File.Delete(vFileName)
                End If

            Else

                'diskOpts.DiskFileName = vFileName

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


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

        opr_Conexion.sql_conectar()

        If EsOcup = 0 Then
            STR_SQL = "update ptopdf set pdf_base64 = @Content, pdf_orden = '" & pdf_orden & "', pdf_dwn = 1 where ped_id = " & ped_id & " and pdf_examen = 'LABORATORIO' "
        Else
            STR_SQL = "update ptopdf set pdf_base64 = @Content, pdf_orden = '" & pdf_orden & "', pdf_dwn = 1 where ped_id = " & ped_id & " and pdf_examen = '" & pdf_examen & "'"
        End If

        Dim cmd As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        cmd.Parameters.Add("@Content", SqlDbType.VarBinary).Value = beneficiosVida
        cmd.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar pdf", Err)
        Err.Clear()

    End Sub


    Public Function AbreProcesoPDF(ByVal ped_id As Integer, ByVal pdf_examen As String) As String
        Dim spath As String, sexe As String, apppath As String, sfile As String
        ''sfile = "sign rfn.pdf"
        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim cmd As SqlCommand
        Dim ProcesoPDF As Byte()
        'Procedimiento para la consultar el usuario que coincida con un login y password recibidos por la funcion 
        On Error GoTo MsgError
        str_sql = "SELECT pdf_base64 from ptopdf where pdf_examen = '" & pdf_examen & "' and ped_id = " & ped_id & ""
        opr_conexion.sql_conectar()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_operacion.Read
            ProcesoPDF = CType(odr_operacion.GetValue(0), Byte())
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()

        'Dim Base64Byte() As Byte = Convert.FromBase64String(AbreProcesoPDF)
        Dim obj As FileStream = File.Create(Environment.CurrentDirectory & "\" & g_pathFolder & "\" & ped_id & "-" & pdf_examen & ".pdf")
        obj.Write(ProcesoPDF, 0, ProcesoPDF.Length)
        obj.Flush()
        obj.Close()
        System.Diagnostics.Process.Start(Environment.CurrentDirectory & "\" & g_pathFolder & "\" & ped_id & "-" & pdf_examen & ".pdf")

        'saber el path donde se esta ejecutando el  EXE pues el archivo pdf esta alli
        'spath = Environment.CurrentDirectory & "\" & g_pathFolder
        'sexe = Dir(spath)
        ''saca el path y el archivo que deseamos ver
        'apppath = Microsoft.VisualBasic.Left(spath, Len(spath) - Len(sexe)) + sfile
        ''procedimiento para abrir cualquier archivo asociado a su programa en este caso PDF acrobat
        'Dim Proc As New System.Diagnostics.Process
        'Proc.StartInfo.FileName = apppath
        'Proc.Start()
        g_opr_usuario.CargarTransaccion(g_str_login, "LEE PDF", "Busca base64", g_sng_user, "", "")
MsgError:
        AbreProcesoPDF = ""
        'g_opr_invitado.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer pdf base  64 ", Err)
        Err.Clear()

    End Function

    Public Shared Function ExportToPDFServer(ByVal rpt As ReportDocument, ByVal NombreArchivo As String, ByVal pathFolder As String) As String
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()

        Try

            rpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            rpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

            'Este es la ruta donde se guardara tu archivo.

            If Dir(pathFolder, FileAttribute.Directory) = "" Then MkDir(pathFolder)
            vFileName = pathFolder & "\" & NombreArchivo
            'str_archivo = g_str_transaccion & "\Log-" & Month(Now) & "-" & Year(Now) & ".log"


            'If Dir(Environment.CurrentDirectory & pathFolder, FileAttribute.Directory) = "" Then
            'MkDir(Environment.CurrentDirectory & "\" & pathFolder)


            'vFileName = Environment.CurrentDirectory & "\" & pathFolder & NombreArchivo
            If File.Exists(vFileName) Then
                File.Delete(vFileName)
            End If
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
            rpt.Refresh()

        Catch ex As Exception
            Throw ex
        End Try
        rpt.Refresh()
        Return vFileName
    End Function
End Class
