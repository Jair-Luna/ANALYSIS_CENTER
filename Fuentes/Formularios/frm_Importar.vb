Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Math

Public Class frm_Importar

    Dim dtt_testeqp As New DataTable("Registros")
    Dim cadenaubicacion As String
    Dim hoja As String
    Dim rango As String
    Dim dtv_test As New DataView(dtt_testeqp)
    Public conn_sql As SqlConnection
    Dim pedido As Integer
    Dim opr_ped As New Cls_Pedido()
    Dim opr_convenio As New Cls_Convenio()
    'Dim opr_trabajo As New Cls_Trabajo()
    Dim opr_medico As New Cls_Medico()
    Dim prioridad As String()
    Dim turno As String = Nothing
    Dim pedidos As String
    Dim pedidosArr As String()
    Public var_desde As String = Nothing

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        lbl_msg.Text = ""
        Dim dir As String
        Dim fileopen As New OpenFileDialog
        ProgressBar1.Value = 0
        fileopen.ShowDialog()
        dir = fileopen.FileName
        TextBox1.Text = dir

        cadenaubicacion = dir
        TextBox2.Text = Mid(TextBox1.Text, 4, Len(TextBox1.Text))
        TextBox3.Focus()

        If carga_info() Then
            btn_procesa.Enabled = True
        Else
            btn_procesa.Enabled = False
        End If
    End Sub

    Private Function carga_info() As Boolean
        Dim posicion_punto As Integer
        Dim extension As String = ""
        Dim num As Integer
        Dim ExcelPath As String = TextBox1.Text.ToLower()

        posicion_punto = Trim(ExcelPath).IndexOf(".")
        num = Trim(ExcelPath).Length
        extension = Mid(Trim(ExcelPath), posicion_punto + 1, num)
        hoja = Trim(TextBox2.Text).Substring(0, TextBox2.Text.Length - extension.Length)

        TextBox2.Text = hoja 'Trim(hoja).Substring(0, hoja.Length - extension.Length)

        rango = TextBox3.Text
        If cargar_hoja(cadenaubicacion, hoja, rango, data, extension, ExcelPath) = 1 Then
            carga_info = True
        Else
            carga_info = False
        End If

        'Dim abo_refer As String
        'abo_refer = TextBox4.Text
        'abo_refer = CStr(Round(CDbl(abo_refer) / 30, 1)) & Len(CStr(Round(CDbl(abo_refer) / 30, 1)))
    End Function



    Private Function cargar_hoja(ByVal cadena As String, ByVal hoja As String, ByVal rango As String, ByVal datagrid As DataGridView, ByVal extension As String, ByVal ExcelPath As String) As Byte
        Try
            If System.IO.File.Exists(cadena) Then
                Dim conexion As New OleDbConnection
                Dim comando As New OleDbCommand
                Dim adaptador As New OleDbDataAdapter
                Dim dsexcel As New DataSet

                Dim sw As Boolean = False

                If Trim(extension) = ".xls" Then
                    conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ExcelPath & "; Extended Properties= ""Excel 8.0;HDR=YES; IMEX=1"""
                    sw = True
                End If

                If Trim(extension) = ".xlsx" Then
                    conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ExcelPath & ";Extended Properties=" & Chr(34) & "Excel 12.0 Xml;HDR=YES;IMEX=1" & Chr(34)
                    sw = True
                End If

                If sw Then
                    'hoja = Trim(hoja).Substring(0, hoja.Length - extension.Length)
                    conexion.Open()
                    comando.CommandText = "select * from " & "[" & hoja & "$" & rango & "]"
                    comando.Connection = conexion
                    adaptador.SelectCommand = comando

                    adaptador.Fill(dsexcel, "excel")

                    'quitafilasvacias(dsexcel)
                    If dsexcel.Tables.Count >= 1 Then
                        cargar_hoja = 1
                    Else
                        cargar_hoja = 0
                    End If

                    data.DataSource = dsexcel.Tables(0)
                    conexion.Close()

                    'Button1.Enabled = True
                Else
                    MsgBox("El archivo seleccionado no es una hoja de Excel válida.", MsgBoxStyle.Information, "ANALISYS")
                    cargar_hoja = 0
                End If
            Else
                MsgBox("No se ha encontrado el archivo " & cadenaubicacion)
                cargar_hoja = 0
            End If
        Catch ex As Exception
            ex.ToString()
            cargar_hoja = 0
        End Try
    End Function

    Private Sub btn_procesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesa.Click
        If opr_ped.GuardaDatosGrid(data, var_desde, Trim(cmb_convenio.Text), Format(dtp_fecha.Value, "dd/MM/yyyy ") & Trim(cmb_hora.Text), Trim(cmb_convenio.Text), Trim(cmb_PrePost.Text), Timer1, ProgressBar1, cmb_medico.Text, pedidos, 0) = 1 Then
            btn_printetiquetas.Enabled = True

            'Me.Close()
        Else

        End If

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_Importar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_hora.SelectedIndex = 1
        cmb_PrePost.SelectedIndex = 0
        opr_ped.LlenarComboPrioridad(cmb_convenio, False, True)
        opr_medico.LlenarComboMedico(cmb_medico, "Referencia")
        'opr_convenio.LlenarComboConvenio(cmb_convenio)

    End Sub

    Private Sub cmb_ped_tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prioridad = Split(cmb_convenio.Text, "/")
        lbl_sec.Text = "INICIO: " & prioridad(1) & " FIN: " & prioridad(2)


    End Sub

    Private Sub btn_printetiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printetiquetas.Click
        Dim pedido_grupo As String
        Dim pedido() As String
        Dim i As Integer
        Dim opr_cod As New Cls_Pedido()

        'pedido_grupo = opr_cod.LeerPedidodeturno(var_desde, var_hasta, dtp_fecha.Value, Trim(Mid(cmb_convenio.Text, 1, 50)))

        Cursor.Current = Cursors.WaitCursor

        pedidosArr = Split(pedidos, ",")
        Dim incremento As Integer
        incremento = UBound(pedidosArr)
        ProgressBar1.Value = 0

        If UBound(pedidosArr) > 0 Then
            For i = 0 To UBound(pedidosArr) - 1
                opr_cod.imprimir_codigo(pedidosArr(i), dtp_fecha.Value)
                ProgressBar1.Increment(incremento)
            Next
            MsgBox("La impresión de las etiquetas se ha realizado exitosamente.", MsgBoxStyle.Information, "ANALISYS")
            data.DataSource = Nothing
        End If
        Cursor.Current = Cursors.Default


    End Sub

    
End Class