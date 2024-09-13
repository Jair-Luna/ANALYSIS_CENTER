Imports System.IO
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource






Public Class frm_imprimiendo

    Private WithEvents dtt_muestras As New DataTable("Registros")
    Dim str_nombre, str_apellido As String
    Dim opr_muestra As New Cls_Muestra()
    Dim I As Integer = 0
    Dim str_imprimir, str_codigo_barras As String
    Dim cont As Integer = 1
    Public dts_proforma As DataSet
    Dim str_servicio As String
    Dim usafecnac As Integer
    Dim fechanac As Date
    Dim str_fecing As String
    Public Ped_id As Long
    Dim str_NumAux As String = Nothing
    Public usuario As String = Nothing
    Public contrasena As String = Nothing
    Public sitio As String = Nothing


    

    Public Sub llenar_cmb_impBC(ByRef cmb_impBC As ComboBox)
        Dim str_var As String
        cmb_impBC.Items.Clear()
        str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP")
        cmb_impBC.Items.Add(str_var)
        str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1")
        cmb_impBC.Items.Add(str_var)
        str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2")
        cmb_impBC.Items.Add(str_var)
        cmb_impBC.SelectedIndex = 0
    End Sub

    Sub CalcularCantidad()
        'recorro el grid y sumo la columna numera 2 del datagrid
        Dim int_indice As Integer = 0
        Dim int_cantidad As Integer = 0
        For int_indice = 0 To dtt_muestras.Rows.Count - 1
            If dtt_muestras.Rows(int_indice).Item(1).ToString = "" Then dtt_muestras.Rows(int_indice).Item(1) = 0
            int_cantidad = CInt(dtt_muestras.Rows(int_indice).Item(1)) + int_cantidad
        Next
        'despliego en le label el total
        lbl_total.Text = int_cantidad
    End Sub

    Private Sub frm_imprimiendo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Label1.Text

            Case "Enviando etiquetas muestras"
                Me.Size = New Size(429, 73)
                Dim dtr_fila As DataRow
                Dim dts_muestra As DataSet
                Dim str_servicio As String = Nothing


                Dim opr_paciente As New Cls_Paciente()
                Timer1.Start()
                dtt_muestras.DefaultView.AllowNew = False
                dtt_muestras.DefaultView.AllowDelete = False
                Dim dtc_columna1 As New DataColumn("tit_nombre", GetType(System.String))
                Dim dtc_columna2 As New DataColumn("pee_cantidad", GetType(System.Single))
                dtt_muestras.Columns.Add(dtc_columna1)
                dtt_muestras.Columns.Add(dtc_columna2)
                Call llenar_cmb_impBC(Me.cmb_impBC)
                Dim prefijo As String = ""
                'muestro en un label el codigo del pedido
                lbl_pedido.Text = Format(g_lng_ped_id, "00")
                lbl_turno.Text = opr_muestra.Leerturno(g_lng_ped_id)
                prefijo = opr_muestra.LeerFechaPedido(g_lng_ped_id)

                If Month(prefijo) < 10 Then
                    If Microsoft.VisualBasic.Day(prefijo) < 10 Then
                        prefijo = "0" & Month(prefijo) & "0" & Microsoft.VisualBasic.Day(prefijo)
                    Else
                        prefijo = "0" & Month(prefijo) & Microsoft.VisualBasic.Day(prefijo)
                    End If
                Else
                    If Microsoft.VisualBasic.Day(prefijo) < 10 Then
                        prefijo = Month(prefijo) & "0" & Microsoft.VisualBasic.Day(prefijo)
                    Else
                        prefijo = Month(prefijo) & Microsoft.VisualBasic.Day(prefijo)
                    End If
                End If

                lbl_codigo_barras.Text = prefijo & Format(CInt(lbl_turno.Text), "00000")
                prefijo = lbl_codigo_barras.Text

                g_opr_usuario.CargarTransaccion(g_str_login, "02 IMPRIMIR COD BARRAS", "PEDIDO=" & lbl_pedido.Text, g_sng_user, lbl_pedido.Text, lbl_turno.Text)

                'recupero en un dataset los datos del paciente d un determinado pedido
                dts_muestra = opr_paciente.LeerUnPaciente(g_lng_ped_id)
                For Each dtr_fila In dts_muestra.Tables("Registros").Rows
                    str_apellido = dtr_fila(0).ToString
                    str_nombre = dtr_fila(1).ToString
                    lbl_fecha.Text = CDate(dtr_fila(2).ToString)
                    lbl_sexo.Text = dtr_fila(3).ToString
                    lbl_doc.Text = dtr_fila(4).ToString
                    usafecnac = dtr_fila(6)
                    fechanac = dtr_fila(7).ToString
                    lbl_tipo.Text = dtr_fila(8).ToString
                    str_fecing = Format(CDate(dtr_fila(2).ToString), "dd/MM/yyyy HH:mm:ss")
                    str_NumAux = dtr_fila(9).ToString
                    lblServicio.text = dtr_fila(10).ToString


                Next
                If usafecnac = 1 Then
                    lbl_edad.Text = opr_paciente.calcula_edad(CDate(fechanac))
                Else
                    lbl_edad.Text = "ND"
                End If

                lbl_nombres.Text = "(" & lbl_sexo.Text & ") - " & str_apellido & " " & str_nombre
                'lleno el grid con las meustras de dicho pedido
                opr_muestra.LlenarGridMuestra(dgrd_muestra, dtt_muestras, g_lng_ped_id)
                'llena combo de las muestras para escojer otro tipode muestra
                opr_muestra.LlenarComboMuestra(cmb_muestra)
                'enveto par para el dataview
                'llamo al funcion para desplegar la cantidad de muestras
                Call CalcularCantidad()

            Case "Enviando proforma"
                'Me.Size = New Size(578, 436)

                Call ImprimeProforma(g_lng_ped_id, dts_proforma)
                g_opr_usuario.CargarTransaccion(g_str_login, "IMPRIMIR PROFORMA", "Proforma=" & g_lng_ped_id&, g_sng_user, g_lng_ped_id, "", "")

            Case "Enviando etiquetas acceso"
                Call llenar_cmb_impBC(Me.cmb_impBC)
                Call ImprimeAccesoWeb()
                g_opr_usuario.CargarTransaccion(g_str_login, "02 IMPRIMIR ACC WEB", "PEDIDO=" & lbl_pedido.Text, g_sng_user, lbl_pedido.Text, lbl_turno.Text)


        End Select

    End Sub

    Function ImprimeProforma(ByVal Num_pedido As Long, ByVal ds As DataSet)
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE PROFORMA
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim obj_reporte As New rpt_proforma()

        'dgrd_proforma.DataSource = ds
        'dgrd_proforma.DataMember = ("Registros")


        Dim cr As New ReportDocument
        Dim strReportName As String
        strReportName = "rpt_proforma"
        Dim strReportPath As String = Application.StartupPath & _
           "\Fuentes\Reportes\" & strReportName & ".rpt"

        cr.Load(strReportPath)
        cr.SetDataSource(dts_proforma.Tables("Registros"))
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowCloseButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.Zoom(30)


        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.PrintReport()

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Increment(20)
            Timer1.Interval = 10
        Else
            Timer1.Stop()
            'Call ActualizaFechaToma()
            Call ImprimirCB()
            Me.Close()
        End If
    End Sub

    Sub ActualizaFechaToma()
        opr_muestra.ActualizaFechaToma(Ped_id)
    End Sub
    Sub ImprimirCB()
        On Error GoTo errores
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'pregunto si el total de equiquetas son mayores a 0
        If Val(lbl_total.Text) > 0 Then
            'verifico en el app.config que modelo d codigo de barras
            'existe 2 opciones :
            'code 39
            'code 128
            str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
            str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("Codigo de Barras")
            If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
                Dim imp_archivo As FileStream = File.Create(str_imprimir)
                imp_archivo.Close()
            End If
            'abro un archivo para generar as lineas que me permitira imprimir un código de barras
            FileOpen(1, str_imprimir, OpenMode.Output)
            Dim int_aux, i As Integer
            Dim str_cadena As String
            Dim TIPO_MUESTRA As Int64 'Variable para determinar el tipo de muestra a utilizar.

            For int_aux = 1 To Val(lbl_total.Text)
                'linea obligatoria
                PrintLine(1, "")
                PrintLine(1, "N")
                'reseteo la impresora
                PrintLine(1, "OD")
                'tamaño horizontal
                PrintLine(1, "q456")
                'tamaño vertical

                'PrintLine(1, "Q199,30+0") '2844 
                PrintLine(1, "Q190,32+0") 'GCT

                'estas tres lineas son obligatorias son seteos de la impresora
                PrintLine(1, "S2") 'S= velocidad
                PrintLine(1, "D8")  'D = Densidad
                PrintLine(1, "ZT")  'Z = Orientación de la impresión, T = desde el tope.

                'mando a escrribir en letras normales el primer 1 en la cadena de parámetros de el tamaño del encabezado
                'CM
                PrintLine(1, "A100,30,0,1,2,1,N," & """'" & g_Titulo & "'""")
                'OK
                'PrintLine(1, "A100,10,0,1,2,1,N," & """'" & g_Titulo & "'""")

                str_cadena = CInt(lbl_turno.Text)
                str_cadena = Trim(dtt_muestras.Rows(i).Item(0).ToString)
                If Len(str_cadena) > 16 Then
                    str_cadena = str_cadena.Substring(0, 16)
                End If

                ''ESCRIBE EL TIPO DE ENVASE EN VERTICAL IZQUIERDA ETIQUETAS NORMALES
                'CM
                PrintLine(1, "A40,165,3,1,1,1,N," & """" & str_cadena & """")
                'ok
                'PrintLine(1, "A40,145,3,1,1,1,N," & """" & str_cadena & """")

                ''ESCRIBE SERVICIO EN VERTICAL IZQUIERDA ETIQUETAS NORMALES
                PrintLine(1, "A60,170,3,1,1,1,N," & """" & lblServicio.Text & """")


                'FECHA DEL PEDIDO
                'OK
                'PrintLine(1, "A100,156,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")
                PrintLine(1, "A100,176,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")

                'CI + EDAD
                'OK
                'PrintLine(1, "A100,170,0,1,1,1,N," & """" & lbl_doc.Text & """")
                'PrintLine(1, "A240,170,0,1,1,1,N," & """" & "EDAD: " & lbl_edad.Text & """")

                PrintLine(1, "A100,190,0,1,1,1,N," & """" & lbl_doc.Text & """")
                PrintLine(1, "A240,190,0,1,1,1,N," & """" & "EDAD: " & lbl_edad.Text & """")


                TIPO_MUESTRA = opr_muestra.selec_muestra(g_lng_ped_id, dtt_muestras.Rows(i).Item(0).ToString)
                If dtt_muestras.Rows(i).Item(1) <> 1 Then
                    If cont = dtt_muestras.Rows(i).Item(1) Then
                        i += 1
                        cont = 1
                    Else
                        cont += 1
                    End If
                Else
                    i += 1
                End If

                'str_cadena = Format(CInt(lbl_turno.Text), "0000") & "-" & TIPO_MUESTRA
                str_cadena = lbl_codigo_barras.Text & "-" & TIPO_MUESTRA
                'OK
                'PrintLine(1, "B90,55,0,1,2,5,60,B," & """" & str_cadena & """")

                PrintLine(1, "B90,75,0,1,2,5,60,B," & """" & str_cadena & """")



                'OK
                'PrintLine(1, "A380,150,3,1,1,1,N," & """" & lbl_tipo.Text & """")
                'PrintLine(1, "A385,150,3,1,1,4,N," & """" & str_NumAux & """")


                PrintLine(1, "A380,170,3,1,1,1,N," & """" & lbl_tipo.Text & """")
                PrintLine(1, "A385,170,3,1,1,4,N," & """" & str_NumAux & """")
                

                'finalmente mando a imprimir los datos del paciente
                str_cadena = str_apellido & " " & str_nombre '.Substring(0, 3)
                If Len(str_cadena) > 28 Then
                    str_cadena = str_cadena.Substring(0, 28)
                End If
                'OK
                'PrintLine(1, "A90,30,0,1,1,1,N," & """" & "(" & lbl_sexo.Text & ")-" & str_cadena.ToString & """")

                PrintLine(1, "A90,50,0,1,1,1,N," & """" & "(" & lbl_sexo.Text & ")-" & str_cadena.ToString & """")
                

                PrintLine(1, "P1")
            Next


            '''GTC420
            PrintLine(1, "")
            PrintLine(1, "OD")
            PrintLine(1, "q456")
            PrintLine(1, "Q190,30+0")
            PrintLine(1, "S2")
            PrintLine(1, "D8")
            PrintLine(1, "ZT")
            FileClose(1)


            ''PrintLine(1, "")
            ''PrintLine(1, "OD")
            ''PrintLine(1, "q456")
            ''PrintLine(1, "Q220,40+0")
            ' ''PrintLine(1, "Q217,32+0")
            ''PrintLine(1, "S2")
            ''PrintLine(1, "D8")
            ''PrintLine(1, "ZT")
            ''FileClose(1)
            'mando a copiar el archivo generado en el puerto designado
            On Error Resume Next
            Dim str_var As String = cmb_impBC.Text
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
            End If
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
            End If
            If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
                str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
            End If
            FileCopy(str_imprimir, str_var)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            'MsgBox("Las Etiquetas fueron impresas", MsgBoxStyle.Information, "ANALISYS")
        Else
            'si existiese errores
            Me.Cursor = System.Windows.Forms.Cursors.Default
            If Label1.Text = "Enviando etiquetas " Then

                MsgBox("Debe seleccionar por lo menos una muestra", MsgBoxStyle.Exclamation, "ANALISYS")
            Else
                ' MsgBox("Se ha generado la proforma con exito", MsgBoxStyle.Information, "ANALISYS")
            End If
        End If
        Exit Sub
errores:
        MsgBox("Error al imprimir, revise la impresora " & Err.Description & Err.Number, MsgBoxStyle.Exclamation, "ANALISYS")
    End Sub



    Sub ImprimeAccesoWeb()
        On Error GoTo errores
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'verifico en el app.config que modelo d codigo de barras
        'existe 2 opciones :
        'code 39
        'code 128
        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("Codigo de Barras")
        If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
            Dim imp_archivo As FileStream = File.Create(str_imprimir)
            imp_archivo.Close()
        End If
        'abro un archivo para generar as lineas que me permitira imprimir un código de barras
        FileOpen(1, str_imprimir, OpenMode.Output)

        'linea obligatoria
        PrintLine(1, "")
        PrintLine(1, "N")
        'reseteo la impresora
        PrintLine(1, "OD")
        'tamaño horizontal
        PrintLine(1, "q456")
        'tamaño vertical

        PrintLine(1, "Q212,32+0") '2844 
        'PrintLine(1, "Q176,32+0") 'GCT

        'estas tres lineas son obligatorias son seteos de la impresora
        PrintLine(1, "S2") 'S= velocidad
        PrintLine(1, "D8")  'D = Densidad
        PrintLine(1, "ZT")  'Z = Orientación de la impresión, T = desde el tope.

        'mando a escrribir en letras normales el primer 1 en la cadena de parámetros de el tamaño del encabezado
        PrintLine(1, "A100,10,0,1,2,1,N," & """'" & g_Titulo & "'""")

        'FECHA DEL PEDIDO
        'PrintLine(1, "A100,156,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy HH:mm") & """")


        PrintLine(1, "A70,80,0,1,1,1,N," & """" & usuario & """")
        PrintLine(1, "A70,100,0,1,1,1,N," & """" & contrasena & """")
        PrintLine(1, "A70,120,0,1,1,1,N," & """" & sitio & """")
       


        'PrintLine(1, "A100,160,0,1,1,1,N," & """" & Format(CDate(lbl_fecha.Text), "dd/MM/yyyy") & """")
        'str_cadena = "HC: " & Format(CInt(lbl_histC.Text), "0000")
        'PrintLine(1, "A100,174,0,1,1,1,N," & """" & str_cadena.ToString & """")


        PrintLine(1, "P1")



        'estas lineas son necesario para que la imrpesora regrese a su estado natura

        '''GTC420
        PrintLine(1, "")
        PrintLine(1, "OD")
        PrintLine(1, "q456")
        PrintLine(1, "Q199,30+0")
        PrintLine(1, "S2")
        PrintLine(1, "D8")
        PrintLine(1, "ZT")
        FileClose(1)


        ''PrintLine(1, "")
        ''PrintLine(1, "OD")
        ''PrintLine(1, "q456")
        ''PrintLine(1, "Q220,40+0")
        ' ''PrintLine(1, "Q217,32+0")
        ''PrintLine(1, "S2")
        ''PrintLine(1, "D8")
        ''PrintLine(1, "ZT")
        ''FileClose(1)
        'mando a copiar el archivo generado en el puerto designado
        On Error Resume Next

        'Dim str_var As String = "Recepcion"
        Dim str_var As String = cmb_impBC.Text

        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpP") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoP")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS1") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS1")
        End If
        If str_var = System.Configuration.ConfigurationSettings.AppSettings("ImpS2") Then
            str_var = System.Configuration.ConfigurationSettings.AppSettings("PuertoS2")
        End If

        FileCopy(str_imprimir, str_var)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        'MsgBox("Las Etiquetas fueron impresas", MsgBoxStyle.Information, "ANALISYS")
       
        Exit Sub
errores:
        MsgBox("Error al imprimir, revise la impresora " & Err.Description & Err.Number, MsgBoxStyle.Exclamation, "ANALISYS")
    End Sub


    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 15
        Timer1.Enabled = True
    End Sub
End Class