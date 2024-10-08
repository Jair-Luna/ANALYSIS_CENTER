Imports System.Data

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient



Public Class Frm_reportes

    Inherits System.Windows.Forms.Form
    Public int_alto, int_ancho As Integer
    Public crp_mail As Object
    Dim oprEquipo As New Cls_equipos()
    Private str_directorio As String
    Dim frm_refer_main_form As Frm_Main

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal str_sql As String, ByVal str_img As String, ByVal crp_reporte As Object, Optional ByVal dts_reporte As DataSet = Nothing, Optional ByVal dts_subreporte As DataSet = Nothing, Optional ByVal dts_subreporteImg As DataSet = Nothing, Optional ByVal dts_antibiograma As DataSet = Nothing, Optional ByVal boo_Agrupa As Boolean = False, Optional ByVal tipoConn As Byte = 0)
        MyBase.New()
        Me.Cursor = Cursors.WaitCursor
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        If dts_reporte Is Nothing Then
            Dim opr_Conexion As New Cls_Conexion()
            Dim dts_registro = New DataSet()
            If tipoConn = 1 Then
                'se conecta con el proveedor ODBC
                opr_Conexion.sql_conectar()
                Dim odr_operacion As SqlDataAdapter = New SqlDataAdapter(str_sql, opr_Conexion.conn_sql)
                odr_operacion.Fill(dts_registro, "Registros")
                crp_reporte.Database.Tables(0).SetDataSource(dts_registro.Tables("Registros"))
                opr_Conexion.sql_desconn()
            Else
                opr_Conexion.sql_conectar()
                Dim odr_operacion As SqlDataAdapter = New SqlDataAdapter(str_sql, opr_Conexion.conn_sql)
                odr_operacion.Fill(dts_registro, "Registros")
                crp_reporte.Database.Tables(0).SetDataSource(dts_registro.Tables("Registros"))
                opr_Conexion.sql_desconn()
                '' ''se conecta con el proveedor OLEDB
                ' ''Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
                ' ''opr_Conexion.sql_conectar()
                ' ''oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
                ' ''oda_operacion.Fill(dts_registro, "Registros")
                ' ''crp_reporte.Database.Tables(0).SetDataSource(dts_registro.Tables("Registros"))
                ' ''opr_conexion.sql_desconn()
            End If
        Else
            crp_reporte.Database.Tables(0).SetDataSource(dts_reporte.Tables("Registros"))
            Select Case Trim(UCase(str_sql))
                Case "HISTOGRAMA", "NOHISTOGRAMA"
                    'tiene o no histograma, en caso positivo se inserta un subreporte
                    Dim rpt_doc As New ReportDocument()

                    rpt_doc = crp_reporte.OpenSubreport("rpt_HistogramaInterfaz.rpt")
                    If Trim(UCase(str_sql)) = "HISTOGRAMA" Then
                        rpt_doc.Database.Tables(0).SetDataSource(dts_subreporte.Tables("Imagenes"))
                    Else

                    End If

            End Select
            Select Case Trim(UCase(str_img))
                Case "IMAGEN", "NOIMAGEN"

                    'MsgBox(str_sql)
                    'MsgBox(dts_subreporteImg.ToString())
                    Dim rpt_doc As New ReportDocument()
                    'rpt_doc = crp_reporte.OpenSubreport("rpt_sub_histograma.rpt")
                    rpt_doc = crp_reporte.OpenSubreport("rpt_HistogramaImagen.rpt")
                    If Trim(UCase(str_img)) = "IMAGEN" Then
                        rpt_doc.Database.Tables(0).SetDataSource(dts_subreporteImg.Tables("ImagenesQR"))
                    Else
                        'rpt_doc.Database.Tables(0).SetDataSource(dts_subreporteImg.Tables.Nothing)
                    End If

                Case Else
            End Select
            ''If dts_antibiograma.Tables.Count >= 1 Then
            ''    Dim rpt_doc As New ReportDocument()
            ''    rpt_doc = crp_reporte.OpenSubreport("rpt_sub_antibiograma.rpt")
            ''    'rpt_doc.Database.Tables(0).SetDataSource(dts_antibiograma.Tables("RegistrosAB"))
            ''End If
        End If
        If tipoConn = 1 Then
            If System.Configuration.ConfigurationSettings.AppSettings("IMPRESORAS") = True Then
                crp_reporte.PrintOptions.PrinterName = oprEquipo.DevuelveImpresora(crp_reporte.ToString)
            End If
            rpv_visor.ReportSource = crp_reporte

            If System.Configuration.ConfigurationSettings.AppSettings("IMPRESORAS") = True Then
                crp_reporte.PrintToPrinter(1, False, 0, 0)
            End If
        Else
            rpv_visor.ReportSource = crp_reporte
        End If

        crp_mail = crp_reporte
        'rpv_visor.DisplayGroupTree = boo_Agrupa
        'rpv_visor.ShowGroupTreeButton = boo_Agrupa
        Me.Cursor = Cursors.Arrow
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
    Friend WithEvents rpv_visor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ttp_mail As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_reportes))
        Me.rpv_visor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ttp_mail = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'rpv_visor
        '
        Me.rpv_visor.ActiveViewIndex = -1
        Me.rpv_visor.AutoScroll = True
        Me.rpv_visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rpv_visor.DisplayBackgroundEdge = False
        Me.rpv_visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpv_visor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpv_visor.Location = New System.Drawing.Point(0, 0)
        Me.rpv_visor.Name = "rpv_visor"
        Me.rpv_visor.SelectionFormula = ""
        Me.rpv_visor.ShowCloseButton = False
        Me.rpv_visor.Size = New System.Drawing.Size(1160, 636)
        Me.rpv_visor.TabIndex = 0
        Me.rpv_visor.ViewTimeSelectionFormula = ""
        '
        'Frm_reportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1160, 636)
        Me.Controls.Add(Me.rpv_visor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_reportes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_reportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'btn_mail.Enabled = True
        'grp_mail.Visible = False

        rpv_visor.DisplayToolbar = True
        rpv_visor.Zoom(100)

        Select Case Me.Text
            Case "Factura"
                Me.Height = int_alto - 15
                Me.Width = int_ancho - 80
                Me.Top = 120
                Me.Left = 80

            Case "Reporte de Caja"
                Me.Height = int_alto - 15
                Me.Width = int_ancho - 15
                Me.Top = 120
                Me.Left = 80
            Case "Entrega de Resultados"
                Me.Height = int_alto - 15
                Me.Width = int_ancho - 15
                Me.Top = (int_alto - Me.Height) / 2
                Me.Left = (int_ancho - Me.Width) / 2

            Case "Preliminar de Resultados"
                Me.Height = int_alto - 15
                Me.Width = int_ancho - 15
                Me.Top = 80
                Me.Left = (int_ancho - Me.Width) / 2
                'rpv_visor.DisplayToolbar = False
                rpv_visor.Zoom(80)
        End Select

        Me.TopMost = True
        Me.StartPosition = FormStartPosition.CenterParent


        
        'Dim paramFields As New ParameterFields()
        'Dim paramField1 As New ParameterField()
        'Dim discreteVal1 As New ParameterDiscreteValue()
        'paramField1.ParameterFieldName = "P_Nota"
        'discreteVal1.Value = var_nota
        'paramField1.CurrentValues.Add(discreteVal1)
        'paramFields.Add(paramField1)
        'rpv_visor.ParameterFieldInfo = paramFields

        'establecemos la direccin local para cuando se exporta, caso contrario esta se pierde y surge un error
        str_directorio = Environment.CurrentDirectory
    End Sub




#Region "Codigo de Formulario"

    Private Sub Formulario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
    End Sub

#End Region


    Private Sub Frm_reportes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Environment.CurrentDirectory = str_directorio
    End Sub

    Private Sub rpv_visor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, rpv_visor.MouseMove
        On Error Resume Next
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.limpiaGrp()
    End Sub


End Class
