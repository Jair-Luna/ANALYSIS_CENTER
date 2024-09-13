'*************************************************************************
' Nombre:   frm_historico
' Tipo de Archivo: formulario
' Descripcin:  Formulario consulta de resultados historicos
' Autores:  RFN
' Ultima Modificaci�n: 15/11/2016
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource



Public Class frm_historico

    Inherits System.Windows.Forms.Form
    Public dts_Historico As DataSet
    Public dts_Preliminar As DataSet
    Public str_sql As String = Nothing
    Public reporte As String = Nothing
    Public ds As DataSet
    Dim oprEquipo As New Cls_equipos()
    Public frm_refer_main As Frm_Main


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.White
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(962, 2)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(44, 22)
        Me.btn_Salir.TabIndex = 95
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 40)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(994, 487)
        Me.CrystalReportViewer1.TabIndex = 147
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.btn_Salir)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(1018, 25)
        Me.pan_barra.TabIndex = 93
        '
        'frm_historico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1018, 539)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.pan_barra)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_historico"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_historico"
        Me.pan_barra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "C�digo de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.MouseEnter
        'cuando el mouse se mueve por encima del los botones del formulario
        Select Case sender.name
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_closep") Then
                    imageToDraw = CType(m_HtImages("btn_closep"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_closep.jpg")
                        m_HtImages.Add("btn_closep", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Bold)
                    sender.forecolor = Color.White
                    If m_HtImages.ContainsKey("barraMenu1") Then
                        imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
                            m_HtImages.Add("barraMenu1", imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                    sender.BackgroundImage = imageToDraw
                End If
        End Select
    End Sub

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.MouseLeave
        'cuando el mouse se pierde el enfoque del los botones del formulario
        Select Case sender.name
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_close") Then
                    imageToDraw = CType(m_HtImages("btn_close"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_close.jpg")
                        m_HtImages.Add("btn_close", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Regular)
                    sender.forecolor = Color.Black
                    If m_HtImages.ContainsKey("barraMenu2") Then
                        imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
                            m_HtImages.Add("barraMenu2", imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                    sender.BackgroundImage = imageToDraw
                End If
        End Select
    End Sub

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
        End Select
    End Sub

#End Region
    Public frm_refer_main_form As Frm_Main
    Dim arr_data() As String


    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub frm_historico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim opr_resultado As New Cls_Resultado()
        Select Case reporte
            Case "Historico"
                arr_data = Split(Me.Tag, ",")
                'Me.dgrd_resultados.SetDataBinding(opr_resultado.LeerHistorico(arr_data(0), arr_data(1), arr_data(2), arr_data(3)), "Registros")
                dts_Historico = opr_resultado.LeerHistorico(arr_data(0), arr_data(1), arr_data(2), arr_data(3))
                Call ImprimeHistorico(dts_Historico, "dts_Historico")

            Case "Preliminar"
                'dts_Preliminar = opr_resultado.LeerPreliminar(str_sql)
                dts_Preliminar = ds
                Call ImprimeHistorico(dts_Preliminar, "dts_Preliminar")
        End Select
    End Sub

    Function ImprimeHistorico(ByVal ds As DataSet, ByVal ds_nombre As String)
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE PROFORMA
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor



        Dim cr As New ReportDocument
        Dim strReportName As String
        Dim strReportPath As String

        Select Case ds_nombre
            Case "dts_Historico"
                strReportName = "rpt_Historico"
                strReportPath = Application.StartupPath & _
                   "\Fuentes\Reportes\" & strReportName & ".rpt"


            Case "dts_Preliminar"
                strReportName = "dts_Preliminar"
                strReportPath = Application.StartupPath & _
                   "\Fuentes\Reportes\" & strReportName & ".rpt"


        End Select



        cr.Load(strReportPath)
        cr.SetDataSource(dts_Historico.Tables("Registros"))
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowCloseButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.Zoom(20)




        If System.Configuration.ConfigurationSettings.AppSettings("IMPRESORAS") = True Then
            cr.PrintOptions.PrinterName = oprEquipo.DevuelveImpresora(cr.ToString)
        End If
        'rpv_visor.ReportSource = cr
        CrystalReportViewer1.ReportSource = cr

        If System.Configuration.ConfigurationSettings.AppSettings("IMPRESORAS") = True Then
            cr.PrintToPrinter(1, False, 0, 0)
        End If


        'cr.PrintToPrinter(1, False, 0, 0)
        'CrystalReportViewer1.PrintReport()

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Function

    Private Sub btn_impHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ARMA LA INSTRUCCION SQL PARA ABRIR EL FORMULARIO DE IMPRESION DE REPORTES
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        arr_data = Split(Me.Tag, ",")
        Dim obj_reporte As New rpt_ImpHist()
        'INSTRUCCION SQL PARA OBTENER TODO LOS DATOS 
        str_sql = "select pedido.ped_Fecing, ped_turno, tes_abrev, tes_nombre, prc_resfinal from pedido, res_procesados, test_equipo, test where test.tim_id = res_procesados.tim_id and res_procesados.tes_abrev = teq_abrv_fija And test.tes_id = test_equipo.tes_id And pedido.ped_id = res_procesados.ped_id And pac_id = " & arr_data(0) & " and tes_abrev = '" & arr_data(1) & "' and res_procesados.tim_id = " & arr_data(3) & " order by ped_fecing desc;"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , , 1)
        frm_MDIChild.int_alto = frm_refer_main.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main.mdiClient1.Width
        frm_MDIChild.Text = "HISTORICO PACIENTE"
        frm_refer_main.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


   
End Class
