Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.Odbc


Public Class frm_Rpt_PruebasFecha
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btn_reportes As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents cmb_parametros As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_secuencias As System.Windows.Forms.Label
    Friend WithEvents lbl_nomreporte As System.Windows.Forms.Label
    Friend WithEvents txt_parametros2 As System.Windows.Forms.TextBox
    Friend WithEvents CMB_PARAMETROS2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_parametro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_parametro As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fechaf As System.Windows.Forms.Label
    Friend WithEvents dtp_fechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_fechai As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lst_reportesHC As System.Windows.Forms.ListBox
    Friend WithEvents lst_reportes As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Rpt_PruebasFecha))
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_reportes = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.lst_reportes = New System.Windows.Forms.ListBox
        Me.cmb_parametros = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.lbl_secuencias = New System.Windows.Forms.Label
        Me.lbl_nomreporte = New System.Windows.Forms.Label
        Me.txt_parametros2 = New System.Windows.Forms.TextBox
        Me.CMB_PARAMETROS2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.txt_parametro = New System.Windows.Forms.TextBox
        Me.lbl_parametro = New System.Windows.Forms.Label
        Me.dtp_fechaF = New System.Windows.Forms.DateTimePicker
        Me.lbl_fechaf = New System.Windows.Forms.Label
        Me.dtp_fechaI = New System.Windows.Forms.DateTimePicker
        Me.lbl_fechai = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lst_reportesHC = New System.Windows.Forms.ListBox
        Me.pan_barra.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(544, 337)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 37)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reportes.ForeColor = System.Drawing.Color.Black
        Me.btn_reportes.Image = CType(resources.GetObject("btn_reportes.Image"), System.Drawing.Image)
        Me.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reportes.Location = New System.Drawing.Point(463, 337)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(80, 37)
        Me.btn_reportes.TabIndex = 3
        Me.btn_reportes.Text = "Consultar"
        Me.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reportes.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(644, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(7, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(97, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "REPORTES"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lst_reportes
        '
        Me.lst_reportes.FormattingEnabled = True
        Me.lst_reportes.Location = New System.Drawing.Point(6, 3)
        Me.lst_reportes.Name = "lst_reportes"
        Me.lst_reportes.Size = New System.Drawing.Size(221, 316)
        Me.lst_reportes.TabIndex = 101
        '
        'cmb_parametros
        '
        Me.cmb_parametros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_parametros.Location = New System.Drawing.Point(340, 104)
        Me.cmb_parametros.Name = "cmb_parametros"
        Me.cmb_parametros.Size = New System.Drawing.Size(190, 21)
        Me.cmb_parametros.TabIndex = 111
        Me.cmb_parametros.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(340, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox1.TabIndex = 115
        Me.ComboBox1.Visible = False
        '
        'lbl_secuencias
        '
        Me.lbl_secuencias.BackColor = System.Drawing.Color.Transparent
        Me.lbl_secuencias.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secuencias.Location = New System.Drawing.Point(265, 138)
        Me.lbl_secuencias.Name = "lbl_secuencias"
        Me.lbl_secuencias.Size = New System.Drawing.Size(80, 14)
        Me.lbl_secuencias.TabIndex = 117
        Me.lbl_secuencias.Text = "Secuencia:"
        Me.lbl_secuencias.Visible = False
        '
        'lbl_nomreporte
        '
        Me.lbl_nomreporte.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nomreporte.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomreporte.ForeColor = System.Drawing.Color.Black
        Me.lbl_nomreporte.Location = New System.Drawing.Point(261, 28)
        Me.lbl_nomreporte.Name = "lbl_nomreporte"
        Me.lbl_nomreporte.Size = New System.Drawing.Size(343, 22)
        Me.lbl_nomreporte.TabIndex = 116
        Me.lbl_nomreporte.Text = "lbl_nomreporte"
        '
        'txt_parametros2
        '
        Me.txt_parametros2.Enabled = False
        Me.txt_parametros2.Location = New System.Drawing.Point(436, 161)
        Me.txt_parametros2.Name = "txt_parametros2"
        Me.txt_parametros2.Size = New System.Drawing.Size(172, 21)
        Me.txt_parametros2.TabIndex = 114
        '
        'CMB_PARAMETROS2
        '
        Me.CMB_PARAMETROS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_PARAMETROS2.Enabled = False
        Me.CMB_PARAMETROS2.Items.AddRange(New Object() {"CEDULA", "APELLIDOS"})
        Me.CMB_PARAMETROS2.Location = New System.Drawing.Point(340, 161)
        Me.CMB_PARAMETROS2.Name = "CMB_PARAMETROS2"
        Me.CMB_PARAMETROS2.Size = New System.Drawing.Size(88, 21)
        Me.CMB_PARAMETROS2.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Buscar por:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_apellido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido.Location = New System.Drawing.Point(266, 108)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(66, 17)
        Me.lbl_apellido.TabIndex = 110
        Me.lbl_apellido.Text = "Apellidos:"
        Me.lbl_apellido.Visible = False
        '
        'txt_parametro
        '
        Me.txt_parametro.Location = New System.Drawing.Point(340, 104)
        Me.txt_parametro.Name = "txt_parametro"
        Me.txt_parametro.Size = New System.Drawing.Size(192, 21)
        Me.txt_parametro.TabIndex = 109
        Me.txt_parametro.Visible = False
        '
        'lbl_parametro
        '
        Me.lbl_parametro.BackColor = System.Drawing.Color.Transparent
        Me.lbl_parametro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_parametro.Location = New System.Drawing.Point(272, 112)
        Me.lbl_parametro.Name = "lbl_parametro"
        Me.lbl_parametro.Size = New System.Drawing.Size(74, 14)
        Me.lbl_parametro.TabIndex = 108
        Me.lbl_parametro.Text = "ID:"
        Me.lbl_parametro.Visible = False
        '
        'dtp_fechaF
        '
        Me.dtp_fechaF.CustomFormat = "ddd, dd - MMMM - yyyy"
        Me.dtp_fechaF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaF.Location = New System.Drawing.Point(516, 75)
        Me.dtp_fechaF.Name = "dtp_fechaF"
        Me.dtp_fechaF.Size = New System.Drawing.Size(92, 21)
        Me.dtp_fechaF.TabIndex = 106
        Me.dtp_fechaF.Value = New Date(2003, 7, 23, 0, 0, 0, 0)
        '
        'lbl_fechaf
        '
        Me.lbl_fechaf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechaf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechaf.Location = New System.Drawing.Point(460, 79)
        Me.lbl_fechaf.Name = "lbl_fechaf"
        Me.lbl_fechaf.Size = New System.Drawing.Size(44, 16)
        Me.lbl_fechaf.TabIndex = 107
        Me.lbl_fechaf.Text = "Hasta:"
        '
        'dtp_fechaI
        '
        Me.dtp_fechaI.CustomFormat = "ddd, dd - MMMM - yyyy"
        Me.dtp_fechaI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaI.Location = New System.Drawing.Point(340, 75)
        Me.dtp_fechaI.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtp_fechaI.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtp_fechaI.Name = "dtp_fechaI"
        Me.dtp_fechaI.Size = New System.Drawing.Size(92, 21)
        Me.dtp_fechaI.TabIndex = 105
        Me.dtp_fechaI.Value = New Date(2003, 7, 23, 0, 0, 0, 0)
        '
        'lbl_fechai
        '
        Me.lbl_fechai.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechai.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechai.Location = New System.Drawing.Point(266, 79)
        Me.lbl_fechai.Name = "lbl_fechai"
        Me.lbl_fechai.Size = New System.Drawing.Size(64, 14)
        Me.lbl_fechai.TabIndex = 104
        Me.lbl_fechai.Text = "Desde:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(244, 347)
        Me.TabControl1.TabIndex = 118
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lst_reportes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(236, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Laboratorio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lst_reportesHC)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(236, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historias Clinicas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lst_reportesHC
        '
        Me.lst_reportesHC.FormattingEnabled = True
        Me.lst_reportesHC.Location = New System.Drawing.Point(6, 2)
        Me.lst_reportesHC.Name = "lst_reportesHC"
        Me.lst_reportesHC.Size = New System.Drawing.Size(221, 316)
        Me.lst_reportesHC.TabIndex = 102
        '
        'frm_Rpt_PruebasFecha
        '
        Me.AcceptButton = Me.btn_reportes
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(644, 390)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmb_parametros)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbl_secuencias)
        Me.Controls.Add(Me.lbl_nomreporte)
        Me.Controls.Add(Me.txt_parametros2)
        Me.Controls.Add(Me.CMB_PARAMETROS2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.txt_parametro)
        Me.Controls.Add(Me.lbl_parametro)
        Me.Controls.Add(Me.dtp_fechaF)
        Me.Controls.Add(Me.lbl_fechaf)
        Me.Controls.Add(Me.dtp_fechaI)
        Me.Controls.Add(Me.lbl_fechai)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_reportes)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Rpt_PruebasFecha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccin de Reportes"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image
    Dim opr_res As New Cls_Resultado()
    Dim dts_reportes As New DataSet
    Dim dts_reportesHC As New DataSet
    Dim num_reporte As Integer = 0


    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub



    Dim opr_usuario As New Cls_Usuario() 'variable para llamar a la clase Usuario


    Public Function Recupera_DatosFac(ByVal fac_fechaI As Date, ByVal fac_fechaF As Date) As String
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim str_sql As String = Nothing
        str_sql = "SELECT a.FAC_ID, b.PED_ID, case WHEN a.FAC_DESCUENTO > 0 THEN round((a.FAC_TOTAL - (a.FAC_TOTAL * a.FAC_DESCUENTO)/100 ),2) else a.FAC_TOTAL end AS TOTAL, c.abo_monto " & _
                  "FROM FACTURA as a, pedido as b, abono as c, invitado as i " & _
                  "WHERE(a.FAC_ESTATUS = 0 Or a.FAC_ESTATUS = 1 Or a.FAC_ESTATUS = 2) " & _
                  "and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id " & _
                  "and b.PED_ESTADO <>2 " & _
                  "and  c.ABO_FECING between '" & Format(fac_fechaI, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fac_fechaF, "dd/MM/yyyy") & " 23:59:59' " & _
                  "and ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO " & _
                  "group by a.FAC_ID, b.PED_ID, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_turno, i.invitado_apellido, i.invitado_nombre, c.abo_monto "

        Dim dtr_fila As DataRow
        Dim dts_abonos As New DataSet()

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_abonos, "Registros")
        opr_Conexion.sql_desconn()
        For Each dtr_fila In dts_abonos.Tables("Registros").Rows
            Recupera_DatosFac = Recupera_DatosFac & dtr_fila(0).ToString() & "," & dtr_fila(1).ToString() & "," & dtr_fila(3).ToString() & "," & dtr_fila(2).ToString() & "º"
        Next
        Exit Function

    End Function


    Public Function Recupera_DatosFacCuentas(ByVal fac_fechaI As Date, ByVal fac_fechaF As Date, ByVal ped_tipo As String) As String
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim str_sql As String = Nothing
        str_sql = "SELECT a.FAC_ID, b.PED_ID, case WHEN a.FAC_DESCUENTO > 0 THEN round((a.FAC_TOTAL - (a.FAC_TOTAL * a.FAC_DESCUENTO)/100 ),2) else a.FAC_TOTAL end AS TOTAL, c.abo_monto " & _
                  "FROM FACTURA as a, pedido as b, abono as c, invitado as i " & _
                  "WHERE b.ped_tipo = '" & ped_tipo & "' and (a.FAC_ESTATUS = 0 Or a.FAC_ESTATUS = 1 Or a.FAC_ESTATUS = 2) " & _
                  "and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id " & _
                  "and b.PED_ESTADO <>2 " & _
                  "and  c.ABO_FECING between '" & Format(fac_fechaI, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fac_fechaF, "dd/MM/yyyy") & " 23:59:59' " & _
                  "and ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO " & _
                  "group by a.FAC_ID, b.PED_ID, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_turno, i.invitado_apellido, i.invitado_nombre, c.abo_monto "

        Dim dtr_fila As DataRow
        Dim dts_abonos As New DataSet()

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_abonos, "Registros")
        opr_Conexion.sql_desconn()
        For Each dtr_fila In dts_abonos.Tables("Registros").Rows
            Recupera_DatosFacCuentas = Recupera_DatosFacCuentas & dtr_fila(0).ToString() & "," & dtr_fila(1).ToString() & "," & dtr_fila(3).ToString() & "," & dtr_fila(2).ToString() & "º"
        Next
        Exit Function

    End Function

    Public Function TotalAbonos(ByVal fac_id As Double) As Double
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim str_sql As String = "select SUM(round(abo_monto,2)) AS abo_total from ABONO where fac_id = " & fac_id
        Dim dtr_fila As DataRow
        Dim dts_abonos As New DataSet()

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_abonos, "Registros")
        opr_Conexion.sql_desconn()
        For Each dtr_fila In dts_abonos.Tables("Registros").Rows
            TotalAbonos = dtr_fila(0)
        Next
        Exit Function

    End Function


    Public Function AbonosFecha(ByVal fac_id As Integer, ByVal fec_ini As Date, ByVal fec_fin As Date) As Double
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim str_sql As String = "select SUM(round(abo_monto,2)) AS abo_total from ABONO where fac_id = " & fac_id & " and abo_fecing between '" & Format(fec_ini, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fec_fin, "dd/MM/yyyy") & " 23:59:59'"
        Dim dtr_fila As DataRow
        Dim dts_abonos As New DataSet()

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_abonos, "Registros")
        opr_Conexion.sql_desconn()
        For Each dtr_fila In dts_abonos.Tables("Registros").Rows
            AbonosFecha = dtr_fila(0)
        Next
        Exit Function

    End Function



    Private Sub btn_reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reportes.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim opr_fac As New Cls_Factura

        'frm_refer_main_form.escribemsj("GENERANDO REPORTE, ESPERE UN MOMENTO")
        If (dtp_fechaI.Value > dtp_fechaF.Value) Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("La fecha inicial del periodo de consulta no puede ser mayor a la final", MsgBoxStyle.Exclamation, "ANALISYS")
        Else
            Dim str_sql As String
            Dim int_usuario As Integer
            '****************************************
            'REPORTES LABORATORIO LAB
            '****************************************

            '1	Reporte Caja por CONVENIOS                                                                                                
            '2	Bonificaciones a medicos                                                                                                
            '3	Reporte Caja por CONVENIOS CONSOLIDADO                                                                                                                                                                                      
            '4	Medico / especialidad                                                                                                   
            '5	test / origen                                                                                                           
            '6	Estadistica conteo por Areas                                                                                            
            '7	Estadistica conteo por Edades                                                                                           
            '8	Estadistica conteo por Servicio                                                                                         
            '9	Estadistica conteo por Sexo                                                                                             
            '10 Estadistica(Produccion)
            '11	Informe de Ingresos                                                                                                     
            '12 Pruebas(ejecutadas)
            '13	Pruebas ejecutadas por Equipos                                                                                          
            '14	Reporte de Produccion por pacientes atendidos 
            '15 Reportes resultados por bloque
            '16 Trazabilidad muestra
            '17 RESULTADS POR CONVENIO
            '18 listado de cuentas
            '19 reporte medicos 
            '20 reporte pacientes HIS
            '21 reporte dialisis
            '22 Reporte ordenes ANULADAS

            '****************************************
            'REPORTES HISTORIAS CLINICAS HC
            '****************************************
            '23 Reporte pacientes atendidos
            '24 Reporte tratamientos pacientes
            '25 Reporte tratamientos medico
            '26 Reporte cutaneas AINES
            '27 Reporte alergias
            ' 28 Reporte paciente LIFE

            opr_fac.EliminaAbonoTemporal()

            Select Case num_reporte
                Case 1 '"Reporte Caja por CONVENIOS"
                    'Reporte de los convenios existentes y lo que deben.
                    Dim obj_reporte As New rpt_cajaXconvenio()

                    '/*FACTURADO Y CANCELADO o ABONADO */
                    str_sql = "SELECT a.FAC_ID, a.FAC_FECING as ped_fecing, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                    "a.FAC_ESTATUS, convert(char(1), a.FAC_FORMAPAGO) as FAC_FORMAPAGO, b.ped_antecedente, (SUBSTRING(convert(char(10),b.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),b.PED_FECING,103),1,2) )+ case when len(b.PED_TURNO) = 1 then('000' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 2 then('00' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 3 then('0' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 4 then(convert(varchar(100),b.PED_TURNO)) end ) as ped_turno , round(sum(c.abo_monto),2)as abo_monto, b.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, '' as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, '' as FAD_CANTIDAD " & _
                    "FROM FACTURA as a, pedido as b, abono as c, paciente as pac WHERE pac.pac_id = b.pac_id and b.FAC_ID = a.FAC_PEDIDOS and ( a.FAC_ESTATUS = 0 or  a.FAC_ESTATUS = 1 or  a.FAC_ESTATUS = 2)  and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  a.FAC_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    " group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE,c.abo_monto, b.CON_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, b.PED_FECING, b.ped_turno, pac.PAC_APELLIDO, pac.PAC_NOMBRE "
                    '/*NO FACTURADO*/
                    str_sql = str_sql + "UNION select 'S/F' as fac_id, p.ped_fecing as ped_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                    "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, '0' as FAC_FORMAPAGO, " & _
                    " p.ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, '0' AS abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, '' as FAD_CANTIDAD " & _
                    "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, test as t " & _
                    "where pac.pac_id = p.pac_id and t.TES_ID = pdd.TES_ID and p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id  And p.ped_fecing " & _
                    "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "and p.ped_fac_estado = 0 and p.ped_estado <> 2 group by p.ped_fecing, lip_precio, pac.PAC_APELLIDO,pac.PAC_NOMBRE,p.ped_antecedente, p.ped_turno, p.CON_NOMBRE, t.TES_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE "
                    'FACTURADO Y NO CANCELADO
                    str_sql = str_sql + "UNION select f.fac_id , p.ped_fecing ,  round(sum(fd.fad_precio * fd.FAD_CANTIDAD),2) as TOTAL ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                    "f.FAC_ESTATUS, convert(char(1), f.FAC_FORMAPAGO) as FAC_FORMAPAGO, p.ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, 0 as abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, fd.FAD_CANTIDAD " & _
                    "FROM pedido as p, factura as f, paciente as pac, test as t, factura_detalle as fd where pac.pac_id = p.pac_id and f.FAC_ID = fd.FAC_ID and fd.TES_ID = t.TES_ID and ped_fac_estado = 1 and p.ped_estado <> 2 " & _
                    "and (fac_estatus = 0 or fac_estatus = 1 or fac_estatus = 2) and p.fac_id = f.fac_id  and ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "group by f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,f.FAC_APELLIDO,f.FAC_NOMBRE,f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, p.ped_turno,p.CON_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE, TES_NOMBRE, fd.FAD_CANTIDAD order by ped_turno ASC;"


                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Caja de Convenios"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 19 '"Reporte medicos"

                    Dim obj_reporte As New rpt_cajaXmedico()

                    '/*FACTURADO Y CANCELADO o ABONADO */
                    str_sql = "SELECT a.FAC_ID, a.FAC_FECING as ped_fecing, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                    "a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, (SUBSTRING(convert(char(10),b.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),b.PED_FECING,103),1,2) )+ case when len(b.PED_TURNO) = 1 then('000' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 2 then('00' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 3 then('0' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 4 then(convert(varchar(100),b.PED_TURNO)) end ) as ped_turno , round(sum(c.abo_monto),2)as abo_monto, b.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, '' as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, m.med_nombre " & _
                    "FROM FACTURA as a, pedido as b, abono as c, paciente as pac, medico as m " & _
                    "WHERE m.med_id = b.med_id and pac.pac_id = b.pac_id and b.FAC_ID = a.FAC_PEDIDOS and ( a.FAC_ESTATUS = 0 or  a.FAC_ESTATUS = 1 or  a.FAC_ESTATUS = 2)  and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  a.FAC_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    " group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE,c.abo_monto, b.CON_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, b.PED_FECING, b.ped_turno, pac.PAC_APELLIDO, pac.PAC_NOMBRE, m.med_nombre "
                    '/*NO FACTURADO*/
                    str_sql = str_sql + "UNION select 'S/F' as fac_id, p.ped_fecing as ped_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                    "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
                    " p.ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, '0' AS abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, m.med_nombre " & _
                    "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, test as t, medico as m " & _
                    "where m.med_id = p.med_id and pac.pac_id = p.pac_id and t.TES_ID = pdd.TES_ID and p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id  And p.ped_fecing " & _
                    "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "and p.ped_fac_estado = 0 and p.ped_estado <> 2 " & _
                    "group by p.ped_fecing, lip_precio, pac.PAC_APELLIDO,pac.PAC_NOMBRE,p.ped_antecedente, p.ped_turno, p.CON_NOMBRE, t.TES_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE, m.med_nombre "
                    'FACTURADO Y NO CANCELADO
                    str_sql = str_sql + "UNION select f.fac_id , p.ped_fecing ,  round(sum(fd.fad_precio),2) as TOTAL ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                    "f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, 0 as abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, m.med_nombre " & _
                    "FROM pedido as p, factura as f, paciente as pac, test as t, factura_detalle as fd, medico as m " & _
                    "where m.med_id = p.med_id and pac.pac_id = p.pac_id and f.FAC_ID = fd.FAC_ID and fd.TES_ID = t.TES_ID and ped_fac_estado = 1 and p.ped_estado <> 2 " & _
                    "and (fac_estatus = 0 or fac_estatus = 1 or fac_estatus = 2) and p.fac_id = f.fac_id  and ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "group by f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,f.FAC_APELLIDO,f.FAC_NOMBRE,f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, p.ped_turno,p.CON_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE, TES_NOMBRE, m.med_nombre order by ped_turno ASC;"


                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte medicos"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 22
                    Dim obj_reporte As New rpt_InformeAnulados()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FEC_INI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FEC_FIN, " & _
                    "p.ped_id, p.PED_FECING, p.PED_TURNO, p.PED_ESTADO, p.con_nombre, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE) as Paciente, p.PED_RECIBO as INGRESA, (i.invitado_apellido + ' ' + i.invitado_nombre ) as ANULA, a.aud_sql, a.aud_fecha  " & _
                    "from pedido as p, paciente as pac, auditoria as a, invitado as i " & _
                    "where p.ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and p.ped_estado = 2 And p.PAC_ID = pac.PAC_ID and p.ped_id = a.ped_id and a.aud_descripcion ='1 ANULA ORDEN' and i.invitado_id = a.aud_usuario " & _
                    "order by ped_id desc "

                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Anulados"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 20

                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, " & _
                            "case when len(pedido.ped_numaux) =1 then ('0000000' + convert(varchar(100),pedido.ped_numaux)) " & _
                              "when len(pedido.ped_numaux) =2 then ('000000' + convert(varchar(100),pedido.ped_numaux)) " & _
                              "when len(pedido.ped_numaux) =3 then ('00000' + convert(varchar(100),pedido.ped_numaux)) " & _
                              "when len(pedido.ped_numaux) =4 then ('0000' + convert(varchar(100),pedido.ped_numaux)) " & _
                              "when len(pedido.ped_numaux) =5 then ('000' + convert(varchar(100),pedido.ped_numaux)) " & _
                              "when len(pedido.ped_numaux) =6 then ('00' + convert(varchar(100),pedido.ped_numaux)) " & _
                              "when len(pedido.ped_numaux) =7 then ('0' + convert(varchar(100),pedido.ped_numaux)) " & _
                              "when len(pedido.ped_numaux) =8 then (convert(varchar(100),pedido.ped_numaux)) end as ped_numaux, " & _
                              "paciente.pac_doc, (paciente.pac_apellido+ ' ' + paciente.pac_nombre) as paciente, " & _
                              "test_homologacion.tes_his1, test_homologacion.tes_his2, '1' as cantidad " & _
                              "from pedido, paciente, test, test_homologacion, pedido_detalle " & _
                              "where pedido.ped_id = pedido_detalle.ped_id and " & _
                              "pedido_detalle.TES_ID  = test_homologacion.tes_id and " & _
                              "test.tes_id = test_homologacion.tes_id and pedido.pac_id = paciente.pac_id and " & _
                              "pedido.PED_SERVICIO = 'IESS' ORDER BY pedido.PED_ID asc "

                    Dim obj_reporte As New rpt_PacientesHIS()

                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Pacientes HIS"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 21 ' REPORTE CAJA POR USUARIO / AREAS

                    Dim obj_reporte As New rpt_cajaXusuario()
                    Dim opr_user As New Cls_Usuario
                    Dim arr_datos As New ArrayList()
                    Dim arr_nombre As New ArrayList()
                    Dim LabOcup As Byte
                    Dim str_areas As String = Nothing
                    'g_invitado

                    opr_user.LeerAreasUsuario(g_sng_user, arr_datos, CStr(LabOcup), str_areas, arr_nombre)

                    '/*FACTURADO Y CANCELADO o ABONADO */
                    str_sql = "SELECT a.FAC_ID, a.FAC_FECING as ped_fecing, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                    "a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, (SUBSTRING(convert(char(10),b.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),b.PED_FECING,103),1,2) )+ case when len(b.PED_TURNO) = 1 then('000' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 2 then('00' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 3 then('0' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 4 then(convert(varchar(100),b.PED_TURNO)) end ) as ped_turno , round(sum(c.abo_monto),2)as abo_monto, b.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, '' as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, '" & g_invitado & "' as usr_sistema " & _
                    "FROM FACTURA as a, pedido as b, abono as c, paciente as pac WHERE pac.pac_id = b.pac_id and b.FAC_ID = a.FAC_PEDIDOS and ( a.FAC_ESTATUS = 0 or  a.FAC_ESTATUS = 1 or  a.FAC_ESTATUS = 2)  and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  a.FAC_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    " group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE,c.abo_monto, b.CON_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, b.PED_FECING, b.ped_turno, pac.PAC_APELLIDO, pac.PAC_NOMBRE "
                    '/*NO FACTURADO*/
                    str_sql = str_sql + "UNION select 'S/F' as fac_id, p.ped_fecing as ped_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                    "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
                    " p.ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, '0' AS abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, '" & g_invitado & "' as usr_sistema " & _
                    "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, test as t, area as ar " & _
                    "where ar.ARE_ID = t.ARE_ID and pac.pac_id = p.pac_id and t.TES_ID = pdd.TES_ID and p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id  And p.ped_fecing " & _
                    "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "and p.ped_fac_estado = 0 and p.ped_estado <> 2 " & _
                    "and ar.ARE_ID in(" & Mid(str_areas, 1, Len(str_areas) - 1) & ") " & _
                    "group by p.ped_fecing, lip_precio, pac.PAC_APELLIDO,pac.PAC_NOMBRE,p.ped_antecedente, p.ped_turno, p.CON_NOMBRE, t.TES_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE "
                    'FACTURADO Y NO CANCELADO
                    str_sql = str_sql + "UNION select f.fac_id , p.ped_fecing ,  round(sum(fd.fad_precio),2) as TOTAL ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                    "f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, 0 as abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente, '" & g_invitado & "' as usr_sistema " & _
                    "FROM pedido as p, factura as f, paciente as pac, test as t, factura_detalle as fd, area as ar  " & _
                    "where ar.ARE_ID = t.ARE_ID and pac.pac_id = p.pac_id and f.FAC_ID = fd.FAC_ID and fd.TES_ID = t.TES_ID and ped_fac_estado = 1 and p.ped_estado <> 2 " & _
                    "and (fac_estatus = 0 or fac_estatus = 1 or fac_estatus = 2) and p.fac_id = f.fac_id  and ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "and ar.ARE_ID in(" & Mid(str_areas, 1, Len(str_areas) - 1) & ") " & _
                    "group by f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,f.FAC_APELLIDO,f.FAC_NOMBRE,f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, p.ped_turno,p.CON_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE, TES_NOMBRE order by ped_turno ASC;"


                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Caja de Convenios"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)



                Case 2 '"Bonificaciones"
                    'REPORTE DE BONIFICACIONES
                    Dim obj_reporte As New rpt_bonificacion()

                    str_sql = "SELECT (SUBSTRING(convert(char(10), P.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),P.PED_FECING,103),1,2)) + case when len(P.PED_TURNO) = 1 then('000' + convert(varchar(100),P.PED_TURNO)) when len(P.PED_TURNO) = 2 then('00' + convert(varchar(100),P.PED_TURNO)) when len(P.PED_TURNO) = 3 then('0' + convert(varchar(100),P.PED_TURNO)) when len(P.PED_TURNO) = 4 then(convert(varchar(100),P.PED_TURNO)) end) AS PEDIDO, P.PED_FECING AS FECHA, P.MED_ID AS MED_ID, M.MED_NOMBRE AS MEDICO, B.BON_PORCENTAJE AS PORCENTAJE, " & _
                        "'" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' as FECHAI , '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' as FECHAF, case when F.FAC_DESCUENTO <> 0 then F.FAC_DESCUENTO else case when F.FAC_RECARGO <> 0 then F.FAC_RECARGO else 0 end end as INCREMENTO, (PAC.PAC_APELLIDO +' '+PAC.PAC_NOMBRE) AS PACIENTE " & _
                        ", sum(AB.ABO_MONTO) AS TOTAL " & _
                        "FROM PEDIDO AS P, MEDICO AS M,  BONIFICACION AS B, FACTURA AS F, PACIENTE AS PAC, ABONO AS AB " & _
                        "WHERE M.MED_NOMBRE = '" & Trim(cmb_parametros.Text) & "' AND " & _
                        "M.MED_ID = P.MED_ID AND " & _
                        "P.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' AND " & _
                        "PAC.PAC_ID = P.PAC_ID AND " & _
                        "B.BON_NOMBRE = M.BON_NOMBRE AND AB.FAC_ID = F.FAC_ID AND F.FAC_PEDIDOS = cast(P.PED_ID as varchar) " & _
                        "group by P.PED_FECING, P.PED_TURNO, pac.PAC_ID, P.MED_ID, M.MED_NOMBRE, B.BON_PORCENTAJE, F.FAC_DESCUENTO, F.FAC_RECARGO, PAC.PAC_APELLIDO, PAC.PAC_NOMBRE "
                    'If int_usuario = 1 Then
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte de Bonificaciones por Fecha"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)
                    'Else
                    'MsgBox("Usted no tiene los privilegios necesarios para ver estos informes", MsgBoxStyle.Critical, "ANALISYS")
                    'End If


                Case 15 '' reporte resultaddos convenio
                    Dim prioridad As String()
                    Dim opr_pedido As New Cls_Pedido()
                    'Dim obj_reporte As New rpt_entregaResConvenio()
                    prioridad = Split(ComboBox1.Text, "/")
                    ' SECUENCIA = Trim(prioridad(0)) 
                    ' NUM_INICIO = Trim(prioridad(1)) 
                    ' NUM_FIN = Trim(prioridad(2)) 

                    Dim dts_operacion As New DataSet()
                    Dim cls_operacion As New Cls_Conexion()
                    Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
                    cls_operacion.sql_conectar()
                    Dim opr_resul As New Cls_Resultado()
                    Dim str_Areas As String
                    Dim opr_user As New Cls_Usuario()
                    Dim arr_datos As New ArrayList()
                    Dim arr_nombre As New ArrayList()
                    Dim int_i As Integer = 0
                    Dim tim_id As Integer = 0
                    Dim tes_padre As Integer = 0
                    Dim NotaArea As String
                    Dim g_validador, g_validadorID As String
                    Dim str_pedidos As String = Nothing
                    Dim pedidos As String()

                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, ped.ped_id, (SUBSTRING(convert(char(10),PED.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PED.PED_FECING,103),1,2) )+ " & _
                    "case when len(PED.PED_TURNO) = 1 then('0000' + convert(varchar(100),PED.PED_TURNO)) " & _
                    "when len(PED.PED_TURNO) = 2 then('000' + convert(varchar(100),PED.PED_TURNO)) " & _
                    "when len(PED.PED_TURNO) = 3 then('00' + convert(varchar(100),PED.PED_TURNO)) " & _
                    "when len(PED.PED_TURNO) = 4 then('0' + convert(varchar(100),PED.PED_TURNO)) end) as ped_turno,(pac_apellido+ ' '+ pac_nombre) as paciente, pac_doc, ped_servicio, pac_grado, are_nombre, med_nombre as medico, rp.PED_ID, rp.TES_ABREV, t.TES_NOMBRE, ped.PED_NOTA, rp.PRC_RESFINAL " & _
                    "from res_procesados as rp, test as t, area, test_equipo as te, paciente as pac, pedido as ped, medico as med " & _
                    "where PED.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59'  " & _
                    "and PED.CON_NOMBRE in('" & Trim(Mid(ComboBox1.Text, 1, 50)) & "') " & _
                    "and ped.PED_ID = rp.PED_ID and pac.PAC_ID = ped.pac_id and med.MED_ID = ped.MED_ID and te.TEQ_ABRV_FIJA = rp.TES_ABREV and t.tes_id = te.TES_ID and area.ARE_ID = t.ARE_ID and t.TES_TIPOREPORTE <> 1 " & _
                    "order by t.TES_ORDENIMP asc"

                    oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
                    oda_operacion.Fill(dts_operacion, "Registros")
                    cls_operacion.sql_desconn()

                    'Dim rpt As String = "D:\ME\ANALISYSCENTER_SQL\Fuentes\Reportes\rpt_entregaContinua.rpt"
                    'Dim pdf As String = "C:\ResultadosPDF.pdf"
                    'RptToPdf(rpt, dts_operacion, pdf)


                    'Cargo grid con  valores resultadis + AB disponibles 
                    Dim dts_operaAB As New DataSet()
                    Dim dtt_resAB As New DataTable("RegistrosRESAB")
                    Dim dtv_resAB As New DataView(dtt_resAB)


                    ''''dts_operaAB = opr_res.CargarAB(dtv_resAB, CInt(lbl_pedidoD.Text), tes_padre)


                    'frm_refer_main_form.escribemsj("GENERANDO HISTOGRAMA")
                    Dim dts_histograma As New DataSet()
                    Dim str_his As String = "NOHistograma"
                    Dim obj_reporte1 As New Object

                    obj_reporte1 = New rpt_ReporteResultados2()

                    '******Dependiendo si existe o no histograma va el campo Histograma

                    Dim frm_MDIChild As New Frm_reportes(str_his, "", obj_reporte1, dts_operacion, dts_histograma, dts_histograma, dts_operaAB, True, 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Emision de Resultados"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 17 '' reporte resultaddos convenio

                    Dim obj_reporte As New rpt_listadoXconvenio()

                    '/*FACTURADO Y CANCELADO o ABONADO */
                    str_sql = "SELECT pac.PAC_DOC as fac_id, a.FAC_FECING as ped_fecing, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                    "a.FAC_ESTATUS, a.FAC_FORMAPAGO, pac.PAC_DOC as ped_antecedente, (SUBSTRING(convert(char(10),b.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),b.PED_FECING,103),1,2) )+ case when len(b.PED_TURNO) = 1 then('000' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 2 then('00' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 3 then('0' + convert(varchar(100),b.PED_TURNO)) when len(b.PED_TURNO) = 4 then(convert(varchar(100),b.PED_TURNO)) end ) as ped_turno , round(sum(c.abo_monto),2)as abo_monto, b.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, '' as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente " & _
                    "FROM FACTURA as a, pedido as b, abono as c, paciente as pac WHERE pac.pac_id = b.pac_id and b.FAC_ID = a.FAC_PEDIDOS and ( a.FAC_ESTATUS = 0 or  a.FAC_ESTATUS = 1 or  a.FAC_ESTATUS = 2)  and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  a.FAC_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    " group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE,c.abo_monto, b.CON_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, b.PED_FECING, b.ped_turno, pac.PAC_APELLIDO, pac.PAC_NOMBRE, pac.pac_doc "
                    '/*NO FACTURADO*/
                    str_sql = str_sql + "UNION select 'NA' as fac_id, p.ped_fecing as ped_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                    "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
                    " pac.PAC_DOC as ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, '0' AS abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente " & _
                    "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, test as t " & _
                    "where pac.pac_id = p.pac_id and t.TES_ID = pdd.TES_ID and p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id  And p.ped_fecing " & _
                    "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "and p.ped_fac_estado = 0 and p.ped_estado <> 2 group by p.ped_fecing, lip_precio, pac.PAC_APELLIDO,pac.PAC_NOMBRE,p.ped_antecedente, p.ped_turno, p.CON_NOMBRE, t.TES_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE, pac.pac_doc "
                    'FACTURADO Y NO CANCELADO
                    str_sql = str_sql + "UNION select pac.PAC_DOC as fac_id, p.ped_fecing ,  round(sum(fd.fad_precio),2) as TOTAL ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                    "f.FAC_ESTATUS, f.FAC_FORMAPAGO, pac.PAC_DOC as ped_antecedente, (SUBSTRING(convert(char(10),p.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),p.PED_FECING,103),1,2) )+ case when len(p.PED_TURNO) = 1 then('000' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 2 then('00' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 3 then('0' + convert(varchar(100),p.PED_TURNO)) when len(p.PED_TURNO) = 4 then(convert(varchar(100),p.PED_TURNO)) end ) as ped_turno, 0 as abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente " & _
                    "FROM pedido as p, factura as f, paciente as pac, test as t, factura_detalle as fd where pac.pac_id = p.pac_id and f.FAC_ID = fd.FAC_ID and fd.TES_ID = t.TES_ID and ped_fac_estado = 1 and p.ped_estado <> 2 " & _
                    "and (fac_estatus = 0 or fac_estatus = 1 or fac_estatus = 2) and p.fac_id = f.fac_id  and ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "group by f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,f.FAC_APELLIDO,f.FAC_NOMBRE,f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, p.ped_turno,p.CON_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE, TES_NOMBRE, pac.pac_doc order by ped_turno;"


                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Listado de Convenios"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                    
                Case 18 ' Reporte listado de cuentas

                    Dim fac_Datos As String
                    Dim Datosfac_arre As String()
                    Dim i As Integer = 0
                    Dim DatosFac As String()
                    Dim total_Abonos, saldo, Abonos_Fecha As Double
                    'Dim opr_fac As New Cls_Factura()
                    Dim str_crea As String
                    Dim obj_reporte As Object


                    Datosfac_arre = Split(Recupera_DatosFacCuentas(dtp_fechaI.Value, dtp_fechaF.Value, Trim(Mid(ComboBox1.Text, 1, 50))), "º")

                    For i = 0 To UBound(Datosfac_arre) - 1
                        DatosFac = Split(Datosfac_arre(i), ",")
                        total_Abonos = TotalAbonos(CDbl(DatosFac(0)))
                        Abonos_Fecha = AbonosFecha(CDbl(DatosFac(0)), dtp_fechaI.Value, dtp_fechaF.Value)
                        'If total_Abonos = Abonos_Fecha Then
                        saldo = DatosFac(3) - total_Abonos
                        'Else
                        'saldo = DatosFac(3) - total_Abonos
                        'saldo = total_Abonos - Abonos_Fecha
                        'End If

                        str_sql = "Insert into abono_temp values('" & DatosFac(0) & "', " & Abonos_Fecha & ", " & saldo & ")"
                        opr_fac.GuardaAbonoTemporal(str_sql)
                    Next


                    If Trim(Mid(ComboBox1.Text, 1, 50)) <> "TODAS" Then
                        '/*FACTURADO Y CANCELADO o ABONADO */
                        '                                                                                                                                                                                                            DateAdd(DateInterval.Day, -28, Now)
                        str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FINI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FFIN, a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                        "a.FAC_ESTATUS, a.FAC_FORMAPAGO,  b.ped_turno, round(abt.abo_total,2) as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, abt.abo_saldo, b.PED_NUMAUX, b.ped_tipo " & _
                        "FROM FACTURA as a, pedido as b, abono as c, invitado as i, abono_temp as abt " & _
                        "WHERE  b.ped_tipo = '" & Trim(Mid(ComboBox1.Text, 1, 50)) & "' and  abt.Fac_id = a.fac_id and (a.FAC_ESTATUS = 0 or a.FAC_ESTATUS = 1 or a.FAC_ESTATUS = 2) and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  c.ABO_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "And ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO " & _
                        "group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, abt.abo_total, b.ped_turno, i.invitado_apellido, i.invitado_nombre, abt.abo_saldo, b.PED_NUMAUX, b.ped_tipo "
                        '/*NO FACTURADO*/
                        str_sql = str_sql + "UNION SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FINI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FFIN, 'S/F' as fac_id, p.ped_fecing as fac_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                        "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
                        "p.ped_turno as TURNO, '0' AS abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, '' as abo_saldo, p.PED_NUMAUX, p.ped_tipo " & _
                        "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, invitado as i " & _
                        "where p.ped_tipo = '" & Trim(Mid(ComboBox1.Text, 1, 50)) & "' and p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id And ped_prof <> 1 And p.ped_fecing " & _
                        "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "and p.ped_fac_estado = 0 and p.ped_estado <> 2 and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO group by pdd.ped_id, p.ped_fecing, pac.PAC_APELLIDO, pac.PAC_NOMBRE, p.ped_turno, i.invitado_apellido, i.invitado_nombre, p.PED_NUMAUX, p.ped_tipo "
                        'FACTURADO Y NO CANCELADO
                        'str_sql = str_sql + "UNION SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FINI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FFIN, f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                        '"f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_turno,0 as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, abt.abo_saldo, p.PED_NUMAUX, p.ped_tipo " & _
                        '"FROM pedido as p, factura as f, invitado as i, abono_temp as abt where  ped_fac_estado = 1  " & _
                        '"And ped_prof <> 1 and fac_estatus = 0 and p.fac_id = f.fac_id and ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59'" & _
                        '" and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO  group by f.fac_id , p.ped_fecing , f.fac_total, f.fac_iva,f.fac_descuento, fac_recargo, f.FAC_APELLIDO, f.FAC_NOMBRE, f.FAC_ESTATUS, f.FAC_FORMAPAGO, abt.abo_total, p.ped_turno, i.invitado_apellido, i.invitado_nombre, abt.abo_saldo, p.PED_NUMAUX, p.ped_tipo; "
                    Else
                        str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FINI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FFIN, a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                        "a.FAC_ESTATUS, a.FAC_FORMAPAGO,  b.ped_turno, round(abt.abo_total,2) as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, abt.abo_saldo, b.PED_NUMAUX, b.ped_tipo " & _
                        "FROM FACTURA as a, pedido as b, abono as c, invitado as i, abono_temp as abt " & _
                        "WHERE  abt.Fac_id = a.fac_id and (a.FAC_ESTATUS = 0 or a.FAC_ESTATUS = 1 or a.FAC_ESTATUS = 2) and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  c.ABO_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "And ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO " & _
                        "group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, abt.abo_total, b.ped_turno, i.invitado_apellido, i.invitado_nombre, abt.abo_saldo, b.PED_NUMAUX, b.ped_tipo "
                        '/*NO FACTURADO*/
                        str_sql = str_sql + "UNION SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FINI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FFIN, 'S/F' as fac_id, p.ped_fecing as fac_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                        "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
                        "p.ped_turno as TURNO, '0' AS abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, '' as abo_saldo, p.PED_NUMAUX, p.ped_tipo " & _
                        "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, invitado as i " & _
                        "where p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id And ped_prof <> 1 And p.ped_fecing " & _
                        "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "and p.ped_fac_estado = 0 and p.ped_estado <> 2 and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO group by pdd.ped_id, p.ped_fecing, pac.PAC_APELLIDO, pac.PAC_NOMBRE, p.ped_turno, i.invitado_apellido, i.invitado_nombre, p.PED_NUMAUX, p.ped_tipo "

                    End If
                    str_crea = "CUENTAS"
                    obj_reporte = New rpt_listadoCuentas()

                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte listado cuentas"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 3 'Reporte Caja por TARIFAS CONSOLIDADO

                    Dim obj_reporte As New rpt_cajaXconvenioConsolidado()
                    '/*FACTURADO Y CANCELADO o ABONADO */
                    str_sql = "SELECT a.FAC_ID, a.FAC_FECING as ped_fecing, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                     "a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, b.ped_turno, round(sum(c.abo_monto),2)as abo_monto, b.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, '' as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente " & _
                     "FROM FACTURA as a, pedido as b, abono as c, paciente as pac WHERE pac.pac_id = b.pac_id and b.FAC_ID = a.FAC_PEDIDOS and ( a.FAC_ESTATUS = 0 or  a.FAC_ESTATUS = 1 or  a.FAC_ESTATUS = 2)  and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  a.FAC_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                     " group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE,c.abo_monto, b.CON_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, b.ped_antecedente, b.ped_turno, pac.PAC_APELLIDO, pac.PAC_NOMBRE "
                    '/*NO FACTURADO*/
                    str_sql = str_sql + "UNION select 'S/F' as fac_id, p.ped_fecing as ped_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                    "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
                    " p.ped_antecedente, p.ped_turno as TURNO, '0' AS abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente " & _
                    "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, test as t " & _
                    "where pac.pac_id = p.pac_id and t.TES_ID = pdd.TES_ID and p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id  And p.ped_fecing " & _
                    "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "and p.ped_fac_estado = 0 and p.ped_estado <> 2 group by p.ped_fecing, lip_precio, pac.PAC_APELLIDO,pac.PAC_NOMBRE,p.ped_antecedente, p.ped_turno, p.CON_NOMBRE, t.TES_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE "
                    'FACTURADO Y NO CANCELADO
                    str_sql = str_sql + "UNION select f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                    "f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, p.ped_turno,0 as abo_monto, p.CON_NOMBRE, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, '' as TES_NOMBRE, (pac.PAC_APELLIDO + ' ' + pac.PAC_NOMBRE ) as paciente " & _
                    "FROM pedido as p, factura as f, paciente as pac where pac.pac_id = p.pac_id and ped_fac_estado = 1  " & _
                    "and (fac_estatus = 0 or fac_estatus = 1 or fac_estatus = 2) and p.fac_id = f.fac_id  and ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "group by f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,f.FAC_APELLIDO,f.FAC_NOMBRE,f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_antecedente, p.ped_turno,p.CON_NOMBRE, pac.PAC_APELLIDO, pac.PAC_NOMBRE order by ped_turno;"

                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Caja de Convenios CONSOLIDADO"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 33 '"Test / grupos hetareos"
                    'Dim obj_reporte As New rpt_test_hetareos()
                    ''str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, pac_sexo, pac_usafecnac, pac_fecnac, PEDIDO.ped_id, " & _
                    ''    "ROUND(PERIOD_DIFF(CONCAT(YEAR(NOW()),IF(MONTH(NOW())<10,CONCAT('0',MONTH(NOW())),MONTH(NOW()))), CONCAT(YEAR(PAC_FECNAC),IF(MONTH(PAC_FECNAC)<10,CONCAT('0',MONTH(PAC_FECNAC)),MONTH(PAC_FECNAC))))/12,0) AS EDAD, " & _
                    ''    "count(LISTA_TRABAJO.tes_id) as examenes FROM PEDIDO, LISTA_TRABAJO, paciente " & _
                    ''    "WHERE ped_estado <> 2 And lis_resestado = 2 AND PEDIDO.PED_eSTADO <> 2 AND LISTA_TRABAJO.LIS_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and PEDIDO.pac_id = paciente.pac_id " & _
                    ''   "GROUP BY LISTA_TRABAJO.ped_id"
                    'str_sql = "sELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, tes_nombre, " & _
                    '    "ROUND(PERIOD_DIFF(CONCAT(YEAR(NOW()),IF(MONTH(NOW())<10,CONCAT('0',MONTH(NOW())),MONTH(NOW()))), CONCAT(YEAR(PAC_FECNAC),IF(MONTH(PAC_FECNAC)<10,CONCAT('0',MONTH(PAC_FECNAC)),MONTH(PAC_FECNAC))))/12,0) AS EDAD, " & _
                    '    "count(LISTA_TRABAJO.tes_id) as examenes " & _
                    '    "FROM PEDIDO, LISTA_TRABAJO, paciente, test " & _
                    '    "WHERE LISTA_TRABAJO.tes_id = test.tes_id and ped_estado <> 2 And (lis_resestado = 2 or lis_resestado = 9) AND PEDIDO.PED_eSTADO <> 2 AND LISTA_TRABAJO.LIS_FECING " & _
                    '    "BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and " & _
                    '    "PEDIDO.pac_id = paciente.pac_id GROUP BY LISTA_TRABAJO.tes_id order by tes_nombre"

                    'Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte, , , , ,1)
                    'frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    'frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    'frm_MDIChild.Text = "Reporte de Producci�n Test / Grupos Hetareos"
                    'frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 30 '"Consolidado por grupos hetareos"
                    'Dim obj_reporte As New rpt_conHetareos()

                    'str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, pac_sexo, pac_usafecnac, pac_fecnac, PEDIDO.ped_id, " & _
                    '    "ROUND(PERIOD_DIFF(CONCAT(YEAR(NOW()),IF(MONTH(NOW())<10,CONCAT('0',MONTH(NOW())),MONTH(NOW()))), CONCAT(YEAR(PAC_FECNAC),IF(MONTH(PAC_FECNAC)<10,CONCAT('0',MONTH(PAC_FECNAC)),MONTH(PAC_FECNAC))))/12,0) AS EDAD, " & _
                    '    "count(LISTA_TRABAJO.tes_id) as examenes FROM PEDIDO, LISTA_TRABAJO, paciente " & _
                    '    "WHERE ped_estado <> 2 And (lis_resestado = 2 or lis_resestado = 9) AND PEDIDO.PED_eSTADO <> 2 AND LISTA_TRABAJO.LIS_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and PEDIDO.pac_id = paciente.pac_id " & _
                    '    "GROUP BY LISTA_TRABAJO.ped_id"

                    'Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte, , , , , 1)
                    'frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    'frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    'frm_MDIChild.Text = "Reporte de Produccion Consolidado por Grupos Hetareos"
                    'frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 40 

                Case 4 '"Medico / especialidad"
                    Dim obj_reporte As New rpt_ConMedicoEspe()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, medico.med_nombre, especialidad.esp_desc, lista_trabajo.ped_id, pedido_detalle_desglosado.TES_ID as Test, lip_precio from lista_trabajo, pedido, medico, especialidad, test , pedido_detalle_desglosado where pedido.ped_estado <> 2 And (lista_trabajo.lis_resestado = 2 or lista_trabajo.lis_resestado = 9) and pedido_detalle_desglosado.PED_ID  = lista_trabajo.PED_ID and test.TES_ID = lista_trabajo.TES_ID and pedido_detalle_desglosado.PED_ID = pedido.PED_ID and pedido_detalle_desglosado.TES_ID = test.TES_ID AND pedido.med_id = medico.med_id And pedido.ped_id = lista_trabajo.ped_id And medico.esp_id = especialidad.esp_id and pedido_detalle_desglosado.TES_ID = lista_trabajo.TES_ID And lista_trabajo.lis_fecing between  '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and lista_trabajo.tes_id = test.tes_id  order by pedido.PED_ID, pedido_detalle_desglosado.TES_ID  "

                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte de Produccion medico / especialidad"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 16 'TRAZABILIDAD MUESTRA'
                    Dim obj_reporte As New rpt_TrazabilidadMuestra()
                    str_sql = ""
                    Dim fecha As Date
                    Dim ped_id As Integer = Nothing

                    If txt_parametro.Text <> "" Then
                        fecha = CDate(Format(Now, "yyyy") & "-" & Mid(Trim(txt_parametro.Text), 1, 2) & "-" & Mid(Trim(txt_parametro.Text), 3, 2))
                        ped_id = opr_res.ConsultarPedidoxTurno(Mid(txt_parametro.Text, 5, 5), fecha)

                        If ped_id > 0 Then
                            str_sql = "select '" & Trim(txt_parametro.Text) & "' as ORDEN, " & ped_id & " as PEDIDO, (pa.PAC_APELLIDO+' '+pa.PAC_NOMBRE)  AS PAC_APELLIDO, (i.invitado_apellido+' '+i.invitado_nombre) as Usuario, a.aud_fecha, a.aud_descripcion, a.aud_sql from auditoria as a, invitado as i, paciente as pa, pedido as pe " & _
                                        "where pe.PED_ID = a.ped_id and pe.PAC_ID = pa.PAC_ID and i.invitado_id = a.aud_usuario and a.ped_id = " & ped_id & " order by a.aud_fecha, a.aud_sql asc;"

                            Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                            frm_MDIChild.Text = "TRAZABILIDAD MUESTRA"
                            frm_refer_main_form.Crea_formulario(frm_MDIChild)
                        Else
                            MsgBox("No existen registros para ese numero de ORDEN " & Trim(txt_parametro.Text), MsgBoxStyle.Exclamation, "ANALISYS")
                        End If
                    Else
                        MsgBox("Debe ingresar el numero de muestra", MsgBoxStyle.Exclamation, "ANALISYS")
                    End If


                Case 60 '"Consolidado por vinculaci�n"
                    Dim obj_reporte As New rpt_conVincula()

                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, count(tes_id) as examenes, pac_grado, lista_trabajo.ped_id " & _
                        "from lista_trabajo, pedido, paciente " & _
                        "where And ped_estado <> 2 And (lis_resestado = 2 or lis_resestado = 9) AND  pedido.pac_id = paciente.pac_id and pedido.ped_id = lista_trabajo.ped_id and lis_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "group by pac_grado, lista_trabajo.ped_id"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte de Produccion Consolidado por Vinculacion"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 61 '"Consolidado por origen"
                    Dim obj_reporte As New rpt_ConOrigen()

                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, pedido.ped_recibo, count(lista_trabajo.tes_id) as examenes, lista_trabajo.ped_id " & _
                        "from lista_trabajo, pedido " & _
                        "where pedido.ped_estado <> 2 And (lista_trabajo.lis_resestado = 2 or lista_trabajo.lis_resestado = 9) AND pedido.ped_id = lista_trabajo.ped_id and lista_trabajo.lis_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "group by pedido.ped_recibo, lista_trabajo.ped_id"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte de Produccion Consolidado por Origen"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 5 '"test / convenio"
                    Dim obj_reporte As New rpt_origen()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, are_nombre, tes_nombre, count(lista_trabajo.tes_id) as items, ped_tipo " & _
                        "from lista_trabajo, pedido, test, area " & _
                        "where ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and lista_trabajo.ped_id = pedido.ped_id And lista_trabajo.tes_id = test.tes_id And test.are_id = area.are_id And ped_estado <> 2 " & _
                        "group by are_nombre, tes_nombre, lista_trabajo.tes_id, ped_tipo order by are_nombre, tes_nombre;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte de Produccion Test / Convenios"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 63 '"Histirico de pruebas manuales x paciente"
                    If CMB_PARAMETROS2.Text = "CEDULA" Then
                        str_sql = "select concat(pac_apellido, ' ', pac_nombre) AS paciente, ped_fecing, ped_turno ,tes_nombre, LIS_RESMANUal as RESULTADO, '" & txt_parametros2.Text & "' as parametro, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                            "from pedido, paciente, lista_trabajo, test " & _
                            "where ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and ISNULL(lista_trabajo.equ_id) AND pedido.pac_id=paciente.pac_id and lista_trabajo.tes_id = test.tes_id and " & _
                            "pedido.ped_id = lista_trabajo.ped_id And paciente.pac_doc like '" & Trim(txt_parametros2.Text) & "%' And ped_estado <> 2 and test.tes_nombre = '" & Trim(cmb_parametros.Text) & "' " & _
                            "UNION " & _
                            "select concat(pac_apellido, ' ', pac_nombre) AS paciente, ped_fecing, ped_turno, " & _
                            "tes_nombre, prc_resfinal as RESULTADO, '" & txt_parametros2.Text & "' as parametro, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                            "from res_procesados as r, test as t, test_equipo as te, pedido as p, paciente as pac " & _
                            "where p.pac_id = pac.pac_id and p.ped_id = r.ped_id and t.tim_id = r.tim_id and te.tes_id = t.tes_id and " & _
                            "ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and " & _
                            "te.teq_abrv_fija = r.tes_abrev and tes_nombre = '" & Trim(cmb_parametros.Text) & "' AND pac.pac_doc like '" & Trim(txt_parametros2.Text) & "%' and ped_estado <> 2 " & _
                            "order by ped_fecing desc;"
                    Else
                        str_sql = "select concat(pac_apellido, ' ', pac_nombre) AS paciente, ped_fecing, ped_turno, tes_nombre, LIS_RESMANUal as RESULTADO, '" & txt_parametros2.Text & "' as parametro, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                            "from pedido, paciente, lista_trabajo, test " & _
                            "where ped_estado <> 2 and ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and ISNULL(lista_trabajo.equ_id) AND pedido.pac_id=paciente.pac_id and lista_trabajo.tes_id = test.tes_id and " & _
                            "pedido.ped_id = lista_trabajo.ped_id And paciente.pac_APELLIDO like '" & Trim(txt_parametros2.Text) & "%' And test.tes_nombre = '" & Trim(cmb_parametros.Text) & "' " & _
                            "UNION " & _
                            "select concat(pac_apellido, ' ', pac_nombre) AS paciente, ped_fecing, ped_turno, " & _
                            "tes_nombre, prc_resfinal as RESULTADO, '" & txt_parametros2.Text & "' as parametro, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                            "from res_procesados as r, test as t, test_equipo as te, pedido as p, paciente as pac " & _
                            "where p.pac_id = pac.pac_id and p.ped_id = r.ped_id and t.tim_id = r.tim_id and te.tes_id = t.tes_id and " & _
                            "ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and " & _
                            "te.teq_abrv_fija = r.tes_abrev and tes_nombre = '" & Trim(cmb_parametros.Text) & "' AND pac_APELLIDO like '" & Trim(txt_parametros2.Text) & "%' and ped_estado <> 2 " & _
                            "order by ped_fecing desc;"
                    End If
                    'Dim obj_reporte As New rpt_HistoricoManual()

                    'Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte, , , , ,1)
                    'frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    'frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    'frm_MDIChild.Text = "Historico de pruebas manuales x paciente"
                    'frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 14 '"Reporte de Produccion por pacientes atendidos"
                    Dim obj_reporte As New rpt_produc_paciente()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, ped.ped_id, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, (pac_apellido+ ' '+ pac_nombre) as paciente, pac_doc, ped_servicio, pac_grado, tes_nombre, are_nombre, med_nombre as medico, '" & cmb_parametros.Text & "' as serv, " & _
                    "rp.PED_ID, rp.TES_ABREV, t.TES_NOMBRE, t.TIM_ID " & _
                    "from res_procesados as rp, test as t, area, test_equipo as te, paciente as pac, pedido as ped, medico as med " & _
                    "where p.CON_NOMBRE = '" & Trim(cmb_parametros.Text) & "' AND P.PED_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and ped.PED_ID = rp.PED_ID and pac.PAC_ID = ped.pac_id and med.MED_ID = ped.MED_ID and te.TEQ_ABRV_FIJA = rp.TES_ABREV and t.tes_id = te.TES_ID and area.ARE_ID = t.ARE_ID and t.TES_TIPOREPORTE <>1 " & _
                    "order by area.ARE_OBS asc, t.TES_ORDENIMP asc;"


                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte de Produccion por pacientes atendidos"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                
                Case 9 '"Estadistica conteo por Sexo"
                    Dim obj_reporte As New rpt_est_sexo()
                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, count(lista_trabajo.tes_id) as conteo, lista_trabajo.tes_id as tes_id, test.tes_nombre as test, area.are_nombre as area, paciente.pac_sexo " & _
                        "FROM lista_trabajo, test, area, paciente, pedido " & _
                        "WHERE ped_estado <> 2 and (lis_resestado = 2 or lis_resestado = 9) and pedido.ped_id = lista_trabajo.ped_id And pedido.pac_id = paciente.pac_id And test.are_id = area.are_id And lista_trabajo.tes_id = test.tes_id And lis_fecing BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "GROUP BY lista_trabajo.tes_id, pac_sexo, test.tes_nombre, area.are_nombre, paciente.pac_sexo order by are_nombre, tes_id, pac_sexo;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Estadistica conteo por Areas"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 67 '"Informe estadastico"
                    'INFORME DE DETERMINACIONES POR FECHA Y MULTIPLES OPCIONES

                    Dim obj_reporte As New rpt_informe()
                    ''Dim obj_reporte As New rpt_informeEstadistico()

                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "'AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & _
                    "' AS FECHAF,  PED.PED_ID AS PEDIDOS , " & _
                    "COUNT(A.ARE_ID) AS PRUEBAS, " & _
                    "P.PAC_OBS as BENEFICIARIO, T.ARE_ID AS AREA, A.ARE_NOMBRE AS AREAN, COUNT(P.PAC_SEXO) AS SEXO, " & _
                    "if (P.PAC_SEXO='F','FEMENINO','MASCULINO') AS SEXON, " & _
                    "IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), " & _
                    "count(IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))) as EDAD, " & _
                    "count(if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac)))))<12, " & _
                    "if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac)))))<1, 'Menor de 1 mes', " & _
                    "if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac)))))<=11, 'De 1 a 11 meses', '>11')), " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=14, 'De 1 a 14 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=40, 'De 15 a 40 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=60, 'De 16 a 60 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>60,'De 61 en adelante','')))))) as Rangos, " & _
                    "if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))))) <12 , " & _
                    "if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac)))))<1, 'Menor de 1 mes' , " & _
                    "if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac)))))<=11, 'De 1 a 11 meses' , '>11')), " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=14, 'De 1 a 14 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=40, 'De 15 a 40 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=60, 'De 16 a 60 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>60,'De 61 en adelante',''))))) as Rangosn, " & _
                    "if(PED_SERVICIO='CONSULTA EXTERNA',COUNT(PED_SERVICIO),IF(PED_SERVICIO='HOSPITALIZACION', COUNT(PED_SERVICIO),IF(PED_SERVICIO='EMERGENCIA',COUNT(PED_SERVICIO),IF(PED_SERVICIO='OTRAS UNIDADES',COUNT(PED_SERVICIO),COUNT(PED_SERVICIO))))) AS SERVICIOS, " & _
                    "PED_SERVICIO AS SERVICIOSN " & _
                    "FROM PEDIDO_DETALLE_DESGLOSADO AS PDD, PEDIDO AS PED, PACIENTE AS P, AREA AS A, TEST AS T WHERE " & _
                    "PED.PED_ESTADO <> 2 AND PED.PED_ID=PDD.PED_ID AND " & _
                    "PED.PAC_ID=P.PAC_ID AND " & _
                    "PDD.TES_ID=T.TES_ID AND " & _
                    "A.ARE_ID=T.ARE_ID " & _
                    "AND LEFT(PED.PED_FECING, 10 ) BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' " & _
                    "GROUP BY A.ARE_ID, PED.PED_ID , PED.PED_FECING " & _
                    "ORDER BY PED.PED_FECING"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    'frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    'frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    'frm_MDIChild.Text = "Informe Estadistico IESS x Areas"
                    'frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 68 '"Informe estadistico Rutina"
                    'INFORME DE DETERMINACIONES POR FECHA Y MULTIPLES OPCIONES
                    Dim obj_reporte As New rpt_informe()
                    'Dim obj_reporte As New rpt_informeEstadistico()

                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "'AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & _
                    "' AS FECHAF,  PED.PED_ID AS PEDIDOS , " & _
                    "T.TES_NOMBRE AS TEST , COUNT(T.TES_ID) AS PRUEBAS, " & _
                    "PED.CON_NOMBRE as BENEFICIARIO, T.ARE_ID AS AREA, A.ARE_NOMBRE AS AREAN, COUNT(P.PAC_SEXO) AS SEXO, " & _
                    "if (P.PAC_SEXO='F','FEMENINO','MASCULINO') AS SEXON, " & _
                    "IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), " & _
                    "count(IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))) as EDAD, " & _
                    "count(if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangos, " & _
                    "IF (P.PAC_USAFECNAC = 0, 'Fecha de Nacimiento desconocida', if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangosn, " & _
                    "PED_SERVICIO AS SERVICIOSN, PED_TIPO AS TIPO " & _
                    "FROM PEDIDO_DETALLE_DESGLOSADO AS PDD, LISTA_TRABAJO AS LT ,PEDIDO AS PED, PACIENTE AS P, AREA AS A, TEST AS T WHERE " & _
                    "PED.PED_ESTADO <> 2 AND PED.PED_ID=PDD.PED_ID AND " & _
                    "PED.PAC_ID=P.PAC_ID AND " & _
                    "PDD.TES_ID=T.TES_ID AND " & _
                    "LT.PED_ID= PED.PED_ID AND " & _
                    "LT.TES_ID= T.TES_ID AND " & _
                    "A.ARE_ID=T.ARE_ID " & _
                    "AND PED.PED_TIPO= 'NORMAL' " & _
                    "AND PED.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "GROUP BY LT.LIS_ID " & _
                    "ORDER BY PED.PED_FECING"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Informe Estadistico Rutina"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 68 '"Informe estadistico Emergencia"
                    'INFORME DE DETERMINACIONES POR FECHA Y MULTIPLES OPCIONES
                    Dim obj_reporte As New rpt_informe()
                    'Dim obj_reporte As New rpt_informeEstadistico()

                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "'AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & _
                        "' AS FECHAF,  PED.PED_ID AS PEDIDOS , " & _
                        "T.TES_NOMBRE AS TEST , COUNT(T.TES_ID) AS PRUEBAS, " & _
                        "PED.CON_NOMBRE as BENEFICIARIO, T.ARE_ID AS AREA, A.ARE_NOMBRE AS AREAN, COUNT(P.PAC_SEXO) AS SEXO, " & _
                        "if (P.PAC_SEXO='F','FEMENINO','MASCULINO') AS SEXON, " & _
                        "IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), " & _
                        "count(IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))) as EDAD, " & _
                        "count(if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangos, " & _
                        "IF (P.PAC_USAFECNAC = 0, 'Fecha de Nacimiento desconocida', if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                        "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangosn, " & _
                        "PED_SERVICIO AS SERVICIOSN, PED_TIPO AS TIPO " & _
                        "FROM PEDIDO_DETALLE_DESGLOSADO AS PDD, LISTA_TRABAJO AS LT ,PEDIDO AS PED, PACIENTE AS P, AREA AS A, TEST AS T WHERE " & _
                        "PED_ESTADO <> 2 AND PED.PED_ID=PDD.PED_ID AND " & _
                        "PED.PAC_ID=P.PAC_ID AND " & _
                        "PDD.TES_ID=T.TES_ID AND " & _
                        "LT.PED_ID= PED.PED_ID AND " & _
                        "LT.TES_ID= T.TES_ID AND " & _
                        "A.ARE_ID=T.ARE_ID " & _
                        "AND PED.PED_TIPO= 'URGENCIA' " & _
                        "AND PED.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "GROUP BY LT.LIS_ID " & _
                        "ORDER BY PED.PED_FECING"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Informe Estadistico Emergencia"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 11 '"Informe de Ingresos"
                    '17 feb 2005 
                    'INFORME DE INGRESO POR RECAUDACIONES EN UN PERIODO DE TIEMPO.
                    Dim obj_reporte As New rpt_ingresos()
                    str_sql = "select p.ped_id, p.con_nombre, p.ped_fecing, pdd.tes_id, lp.lip_precio, " & _
                    "'" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & _
                    "' AS FECHAF " & _
                    "from pedido as p, pedido_detalle_desglosado as pdd, lista_precio as lp " & _
                    "where " & _
                    "ped_estado <> 2 and p.ped_id = pdd.ped_id And p.con_nombre = lp.con_nombre " & _
                    "and pdd.tes_id = lp.tes_id and " & _
                    "p.ped_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "order by p.con_nombre, pdd.ped_id"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Informe de Ingresos"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 69 '"Pedidos Hospitalizacion"
                    '25 jul 2005 
                    'INFORME DE PEDIDOS REALIZADOS PARA PACIENTES HOSPITALIZADOS
                    Dim obj_reporte As New rpt_PruebasXPedido()
                    str_sql = "SELECT PED.PED_ID AS PEDIDO, PED.PED_FECING AS FECHA, concat(P.PAC_APELLIDO, ' ',P.PAC_NOMBRE) AS NOMBRE, T.TES_NOMBRE AS TEST, COUNT(LT.TES_ID) AS PRUEBAS, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FEC_INI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FEC_FIN, " & _
                    "PED.PED_TURNO AS TURNO, PED.PED_SERVICIO AS SERVICIO, PED.PED_ANTECEDENTE AS ANTECEDENTE FROM LISTA_TRABAJO as LT, TEST AS T, PACIENTE AS P, PEDIDO AS PED WHERE  PED.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' AND T.TES_ID = LT.TES_ID AND LT.PED_ID = PED.PED_ID AND PED.PAC_ID = P.PAC_ID  AND (PED.PED_SERVICIO = 'H2' OR PED.PED_SERVICIO = 'H3' OR PED.PED_SERVICIO ='UCI' OR PED.PED_SERVICIO = 'Gineco Pediatria') GROUP BY NOMBRE, TEST ORDER BY TURNO "
                    'str_sql = "SELECT PED.PED_ID AS PEDIDO, PED.PED_FECING AS FECHA, concat(P.PAC_APELLIDO, ' ',P.PAC_NOMBRE) AS NOMBRE, T.TES_NOMBRE AS TEST, COUNT(LT.TES_ID) AS PRUEBAS, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FEC_INI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FEC_FIN FROM LISTA_TRABAJO as LT, TEST AS T, PACIENTE AS P, PEDIDO AS PED WHERE PED.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' AND T.TES_ID = LT.TES_ID AND LT.PED_ID = PED.PED_ID AND PED.PAC_ID = P.PAC_ID GROUP BY NOMBRE, TEST ORDER BY PEDIDO"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Pruebas por Pedido"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                    'Case 21 '"Estadistica conteo Remitidos"
                    '    Dim obj_reporte As New rpt_est_remitidos()
                    '    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, count(lista_trabajo.tes_id) as conteo, lista_trabajo.tes_id as tes_id, tes_nombre as test, " & _
                    '        "are_nombre as area from lista_trabajo, test, area " & _
                    '        "where (lis_resestado = 9) and test.are_id = area.are_id And lista_trabajo.tes_id = test.tes_id And lis_fecing " & _
                    '        "between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' and area.ARE_NOMBRE like 'remitido%' group by tes_id order by are_nombre, tes_id;"
                    '    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    '    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    '    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    '    frm_MDIChild.Text = "Estadistica conteo por Areas"
                    '    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 6 '"Estadistica conteo por Areas"
                    Dim obj_reporte As New rpt_est_area()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, count(lista_trabajo.tes_id) as conteo, lista_trabajo.tes_id as tes_id, test.tes_nombre as test, area.are_nombre as area  " & _
                        "from lista_trabajo, test, area " & _
                        "where (lis_resestado = 2 or lis_resestado = 9) and test.are_id = area.are_id And lista_trabajo.tes_id = test.tes_id And lis_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "group by lista_trabajo.tes_id, test.tes_nombre, area.are_nombre order by area.are_nombre, lista_trabajo.tes_id;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Estadistica conteo por Areas"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 7 '"Estadistica conteo por Edades"
                    '31-10-2014 rfn
                    'informe CONTEO DE PRUEBAS X EDAD PACS
                    Dim obj_reporte As New rpt_est_edades()
                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, A.ARE_NOMBRE AS AREA, T.TES_NOMBRE, COUNT(PDD.TES_ID) AS CONTEO, " & _
                        "IF(P.PAC_USAFECNAC =0, 'INDETER.',if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))))) <12 , if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac)))))<1, 'Menor de 1 mes' , if(IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) > 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) - (MID(now(), 9, 2) < MID(pac_fecnac, 9, 2)), IF((((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) < 0, (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac))) + (MID(pac_fecnac, 9, 2) < MID(now(), 9, 2)), (((YEAR(now()) - 1) * 12 + MONTH(now())) - ((YEAR(pac_fecnac) - 1) * 12 + MONTH(pac_fecnac)))))<=11, 'De 1 a 11 meses' , '>11')), if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=14, 'De 1 a 14 años', if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=40, 'De 15 a 40 años', if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=60, 'De 41 a 60 años', if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>60,'De 61 en adelante','')))))) " & _
                        "as Rangosn FROM PEDIDO_DETALLE_DESGLOSADO AS PDD, PEDIDO AS PED, PACIENTE AS P, AREA AS A, TEST AS T " & _
                        "WHERE PED_ESTADO <> 2 AND PED.PED_ID=PDD.PED_ID AND PED.PAC_ID=P.PAC_ID AND PDD.TES_ID=T.TES_ID AND A.ARE_ID=T.ARE_ID AND LEFT(PED.PED_FECING, 10 ) BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' " & _
                        "GROUP BY A.ARE_NOMBRE, PDD.TES_ID, RANGOSN  " & _
                        "ORDER BY A.ARE_NOMBRE, T.TES_NOMBRE, RANGOSN;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Estadistica conteo por Tipo de Afiliacion"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 8 '"Estadistica conteo por Servicio"
                    Dim obj_reporte As New rpt_est_servicio()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, count(lista_trabajo.tes_id) as conteo,  lista_trabajo.tes_id as tes_id, test.tes_nombre as test, are_nombre as area, ped_servicio as servicio " & _
                    "from lista_trabajo, test, area, pedido " & _
                    "where (lis_resestado = 2 or lis_resestado = 9) and lista_trabajo.ped_id = pedido.ped_id And test.are_id = area.are_id And lista_trabajo.tes_id = test.tes_id And lis_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "group by lista_trabajo.tes_id, test.tes_nombre, area.are_nombre, pedido.ped_servicio order by are_nombre, tes_id;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Estadistica conteo por Servicio"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 10 '"Estadistica Produccion"
                    Dim obj_reporte As New rpt_produccion()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, lista_trabajo.tes_id as tes_id, lista_trabajo.ped_id, test.tes_nombre as test, area.are_nombre as area, pedido.ped_servicio as servicio " & _
                        "from lista_trabajo, test, area, pedido  " & _
                        "where pedido.ped_estado <> 2 and (lista_trabajo.lis_resestado = 2 or lista_trabajo.lis_resestado = 9) and lista_trabajo.ped_id = pedido.ped_id And test.are_id = area.are_id And lista_trabajo.tes_id = test.tes_id And lista_trabajo.lis_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "order by servicio, area.are_nombre, lista_trabajo.tes_id, pedido.ped_id;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Estadistica Produccion por Servicio"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 222 '"Estadistica conteo por tipo Afiliacion"
                    Dim obj_reporte As New rpt_est_afiliacion()
                    str_sql = "select '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, count(lista_trabajo.tes_id) as conteo, " & _
                        "lista_trabajo.tes_id as tes_id, tes_nombre as test, are_nombre as area, pac_grado as afiliacion " & _
                        "from lista_trabajo, test, area, pedido, paciente " & _
                        "where ped_estado <> 2 and (lis_resestado = 2 or lis_resestado = 9) and pedido.pac_id = paciente.pac_id and lista_trabajo.ped_id = pedido.ped_id And test.are_id = area.are_id And " & _
                        "lista_trabajo.tes_id = test.tes_id And lis_fecing between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' " & _
                        "group by tes_id, are_nombre, pac_grado " & _
                        "order by are_nombre, tes_id, pac_grado;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Estadistica conteo por Tipo de Afiliacion"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 23 ' Reporte pacientes atendidos HC

                    Dim obj_reporte As New rpt_pacientesAtendidos()
                    str_sql = "select cm.con_id, cm.con_fecha, (p.PAC_NOMBRE + ' '+ p.PAC_APELLIDO) as paciente, cm.med_id, m.MED_NOMBRE, cm.con_estado, cm.CON_OBS, Case when a.age_resumen ='' then 'CONSULTA INTERNA' ELSE 'CONSULTA WEB' end as TIPO,  '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, a.AGE_ID, count(a.AGE_ID )as COUNT_AGEID, p.PAC_POLIZA " & _
                            "from consultaMedico as cm, paciente as p, medico as m, agenda as a " & _
                            "where a.age_fecha between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' and cm.PAC_ID = p.PAC_ID and m.med_id = cm.MED_ID and a.age_id = cm.age_id " & _
                            "group by cm.con_id, cm.con_fecha, p.PAC_NOMBRE, p.PAC_APELLIDO, cm.med_id, m.MED_NOMBRE, cm.con_estado, cm.CON_OBS, a.age_resumen, a.AGE_ID, p.PAC_POLIZA " & _
                            "order by cm.CON_ID desc "


                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Pacientes Atendidos"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 24 ' Reporte tratamientos pacientes TODOS HC

                    Dim obj_reporte As New rpt_TratamientoPac()
                    str_sql = "select vt.TTO_FECHA, vt.I_PRD_ID, ip.I_PRD_DESCRIPCION, vt.VAC_LOTE, VT.TTO_CANTIDAD, (p.PAC_APELLIDO  + ' '  + PAC_NOMBRE) as paciente, p.PAC_DOC, m.MED_NOMBRE,  '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                            "from vacunaTratamiento as vt, paciente  as p, i_producto as ip, medico as m " & _
                            "where vt.TTO_FECHA between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and vt.I_PRD_ID = ip.I_PRD_ID and p.PAC_ID = vt.PAC_ID and m.MED_ID = vt.MED_ID "

                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte tratamientos pacientes TODOS"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)


                Case 25 ' Reporte tratamientos pacientes TODOS HC

                    Dim obj_reporte As New rpt_TratamientoPac()
                    str_sql = "select vt.TTO_FECHA, vt.I_PRD_ID, ip.I_PRD_DESCRIPCION, vt.VAC_LOTE,  VT.TTO_CANTIDAD, (p.PAC_APELLIDO  + ' '  + PAC_NOMBRE) as paciente, p.PAC_DOC, m.MED_NOMBRE,  '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                            "from vacunaTratamiento as vt, paciente as p, i_producto as ip, medico as m " & _
                            "where p.PAC_DOC = '" & Trim(txt_parametros2.Text) & "' and  vt.TTO_FECHA between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and vt.I_PRD_ID = ip.I_PRD_ID and p.PAC_ID = vt.PAC_ID and m.MED_ID = vt.MED_ID "

                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte tratamientos pacientes TODOS"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 27 ' Reporte cutaneas AINES
                    Dim obj_reporte As New rpt_PacientesAINES()
                    If cmb_parametros.Text = "Todos" Then
                        str_sql = "select distinct(a.age_id), a.AGE_FECHA, (p.PAC_NOMBRE + ' '+ p.PAC_APELLIDO) as paciente, t.tes_nombre, rc.PRCC_RESUL_ANIO, rc.PRCC_RESUL_INT, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                                "from paciente as p, consultaMedico as cm, agenda as a, res_cutaneas as rc, test_equipo as te, test as t " & _
                                "where a.AGE_FECHA between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and cm.PAC_ID = p.PAC_ID and a.age_id = cm.AGE_ID and a.ped_id = rc.PED_ID and te.TEQ_ABRV_FIJA = rc.TES_ABREV and te.tes_id = t.tes_id " & _
                                "and rc.PRCC_RESUL_ANIO <> '' and t.tes_padre = 401312 " & _
                                "order by a.age_id asc"
                    Else
                        str_sql = "select distinct(a.age_id), a.AGE_FECHA, (p.PAC_NOMBRE + ' '+ p.PAC_APELLIDO) as paciente, t.tes_nombre, rc.PRCC_RESUL_ANIO, rc.PRCC_RESUL_INT, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF " & _
                                "from paciente as p, consultaMedico as cm, agenda as a, res_cutaneas as rc, test_equipo as te, test as t " & _
                                "where a.AGE_FECHA between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' and cm.PAC_ID = p.PAC_ID and a.age_id = cm.AGE_ID and a.ped_id = rc.PED_ID and te.TEQ_ABRV_FIJA = rc.TES_ABREV and te.tes_id = t.tes_id " & _
                                "and rc.PRCC_RESUL_ANIO <> '' and t.tes_padre = 401312 and rc.PRCC_RESUL_INT = '" & Trim(cmb_parametros.Text) & "'" & _
                                "order by a.age_id asc"
                    End If


                Case 28 ' Reporte cutaneas TODAS ALERGIAS

                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

                    Select Case Mid(Trim(cmb_parametros.Text), 40, 6)
                        Case "401310", "401323"     'ALIMENTOS
                            Dim obj_reporte As New rpt_PacientesALERGIAS()
                            str_sql = "select * from ( " & _
                                    "select t.TES_NOMBRE, count(rc.PRCC_RESUL_INT) as CONTEO_RES, rc.PRCC_RESUL_INT, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_PADRE " & _
                                    "from agenda as a, res_cutaneas as rc, test_equipo as te, test as t " & _
                                    "where a.AGE_FECHA between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                                    "and a.ped_id = rc.PED_ID and te.TEQ_ABRV_FIJA = rc.TES_ABREV and te.tes_id = t.tes_id " & _
                                    "and rc.PRCC_RESUL_ANIO <> '' and t.tes_padre = " & Mid(Trim(cmb_parametros.Text), 40, 6) & " " & _
                                    "group by rc.PRCC_RESUL_INT, t.TES_NOMBRE, t.TES_PADRE " & _
                                    ") as alergias " & _
                                    "PIVOT (count(CONTEO_RES) FOR PRCC_RESUL_INT IN ([.], [I], [O]) " & _
                                    ") AS PivotTable;"
                            Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                            frm_MDIChild.Text = "Reporte Cutaneas ALERGIAS " & Mid(Trim(cmb_parametros.Text), 1, 30)
                            frm_refer_main_form.Crea_formulario(frm_MDIChild)

                        Case "401311", "401324" 'INHALANTES
                            Dim obj_reporte As New rpt_PacientesALERGIAS2()
                            str_sql = "select * from ( " & _
                                    "select t.TES_NOMBRE, count(rc.PRCC_RESUL_INT) as CONTEO_RES, rc.PRCC_RESUL_INT, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_PADRE " & _
                                    "from agenda as a, res_cutaneas as rc, test_equipo as te, test as t " & _
                                    "where a.AGE_FECHA between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                                    "and a.ped_id = rc.PED_ID and te.TEQ_ABRV_FIJA = rc.TES_ABREV and te.tes_id = t.tes_id " & _
                                    "and rc.PRCC_RESUL_ANIO <> '' and t.tes_padre = " & Mid(Trim(cmb_parametros.Text), 40, 6) & " " & _
                                    "group by rc.PRCC_RESUL_INT, t.TES_NOMBRE, t.TES_PADRE " & _
                                    ") as alergias " & _
                                    "PIVOT (count(CONTEO_RES) FOR PRCC_RESUL_INT IN ([I], [O]) " & _
                                    ") AS PivotTable;"
                            Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                            frm_MDIChild.Text = "Reporte Cutaneas ALERGIAS " & Mid(Trim(cmb_parametros.Text), 1, 30)
                            frm_refer_main_form.Crea_formulario(frm_MDIChild)

                        Case "401312", "401321", "401322", "401324", "401325" 'MEDICAMENTOS
                            Dim obj_reporte As New rpt_PacientesALERGIAS3()
                            str_sql = "select * from ( " & _
                                    "select t.TES_NOMBRE, count(rc.PRCC_RESUL_INT) as CONTEO_RES, rc.PRCC_RESUL_INT, '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, t.TES_PADRE " & _
                                    "from agenda as a, res_cutaneas as rc, test_equipo as te, test as t " & _
                                    "where a.AGE_FECHA between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                                    "and a.ped_id = rc.PED_ID and te.TEQ_ABRV_FIJA = rc.TES_ABREV and te.tes_id = t.tes_id " & _
                                    "and rc.PRCC_RESUL_ANIO <> '' and t.tes_padre = " & Mid(Trim(cmb_parametros.Text), 40, 6) & " " & _
                                    "group by rc.PRCC_RESUL_INT, t.TES_NOMBRE, t.TES_PADRE " & _
                                    ") as alergias " & _
                                    "PIVOT (count(CONTEO_RES) FOR PRCC_RESUL_INT IN ([Positivo], [Negativo]) " & _
                                    ") AS PivotTable;"
                            Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                            frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                            frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                            frm_MDIChild.Text = "Reporte Cutaneas ALERGIAS " & Mid(Trim(cmb_parametros.Text), 1, 30)
                            frm_refer_main_form.Crea_formulario(frm_MDIChild)
                           
                    End Select

                    

                    
                    Me.Cursor = System.Windows.Forms.Cursors.Default

                Case 28

                Case 29 '"Informe estadistico Pacientes Rutina"
                    'INFORME DE DETERMINACIONES POR FECHA Y MULTIPLES OPCIONES
                    Dim obj_reporte As New rpt_EstadisticaPacientes()
                    'Dim obj_reporte As New rpt_informeEstadistico()

                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "'AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & _
                    "' AS FECHAF,  PED.PED_ID AS PEDIDOS , " & _
                    "T.TES_NOMBRE AS TEST , COUNT(T.TES_ID) AS PRUEBAS, " & _
                    "P.PAC_PARENTESCO as BENEFICIARIO, T.ARE_ID AS AREA, A.ARE_NOMBRE AS AREAN, COUNT(P.PAC_SEXO) AS SEXO, " & _
                    "if (P.PAC_SEXO='F','FEMENINO','MASCULINO') AS SEXON, " & _
                    "IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), " & _
                    "count(IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))) as EDAD, " & _
                    "count(if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangos, " & _
                    "IF (P.PAC_USAFECNAC = 0, 'Fecha de Nacimiento desconocida', if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangosn, " & _
                    "PED_SERVICIO AS SERVICIOSN, PED_TIPO AS TIPO " & _
                    "FROM PEDIDO_DETALLE_DESGLOSADO AS PDD, LISTA_TRABAJO AS LT ,PEDIDO AS PED, PACIENTE AS P, AREA AS A, TEST AS T WHERE " & _
                    "PED_ESTADO <> 2 AND PED.PED_ID=PDD.PED_ID AND " & _
                    "PED.PAC_ID=P.PAC_ID AND " & _
                    "PDD.TES_ID=T.TES_ID AND " & _
                    "LT.PED_ID= PED.PED_ID AND " & _
                    "LT.TES_ID= T.TES_ID AND " & _
                    "A.ARE_ID=T.ARE_ID " & _
                    "AND PED.PED_TIPO= 'NORMAL' " & _
                    "AND PED.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "GROUP BY PED.PED_ID " & _
                    "ORDER BY PED.PED_FECING"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Informe Estadistico Pacientes Rutina"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 31 '"Informe estadistico Pacientes Emergencia"
                    'INFORME DE DETERMINACIONES POR FECHA Y MULTIPLES OPCIONES
                    Dim obj_reporte As New rpt_EstadisticaPacientesE()
                    'Dim obj_reporte As New rpt_informeEstadistico()

                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "'AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & _
                    "' AS FECHAF,  PED.PED_ID AS PEDIDOS , " & _
                    "T.TES_NOMBRE AS TEST , COUNT(T.TES_ID) AS PRUEBAS, " & _
                    "P.PAC_PARENTESCO as BENEFICIARIO, T.ARE_ID AS AREA, A.ARE_NOMBRE AS AREAN, COUNT(P.PAC_SEXO) AS SEXO, " & _
                    "if (P.PAC_SEXO='F','FEMENINO','MASCULINO') AS SEXON, " & _
                    "IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), " & _
                    "count(IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))) as EDAD, " & _
                    "count(if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangos, " & _
                    "IF (P.PAC_USAFECNAC = 0, 'Fecha de Nacimiento desconocida', if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=1, 'De 1 año o menos', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=12, 'De 2 a 12 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=18, 'De 13 a 18 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))<=54, 'De 19 a 54 años', " & _
                    "if(IF((YEAR(now()) - YEAR(pac_fecnac)) > 0, (YEAR(now()) - YEAR(pac_fecnac)) - (MID(now(), 6, 5) < MID(pac_fecnac, 6, 5)), IF((YEAR(now()) - YEAR(pac_fecnac)) < 0, (YEAR(now()) - YEAR(pac_fecnac)) + (MID(pac_fecnac, 6, 5) < MID(now(), 6, 5)), (YEAR(now()) - YEAR(pac_fecnac))))>=55,'Mayor de 55 años','')))))) as Rangosn, " & _
                    "PED_SERVICIO AS SERVICIOSN, PED_TIPO AS TIPO " & _
                    "FROM PEDIDO_DETALLE_DESGLOSADO AS PDD, LISTA_TRABAJO AS LT ,PEDIDO AS PED, PACIENTE AS P, AREA AS A, TEST AS T WHERE " & _
                    "PED_ESTADO <> 2 AND PED.PED_ID=PDD.PED_ID AND " & _
                    "PED.PAC_ID=P.PAC_ID AND " & _
                    "PDD.TES_ID=T.TES_ID AND " & _
                    "LT.PED_ID= PED.PED_ID AND " & _
                    "LT.TES_ID= T.TES_ID AND " & _
                    "A.ARE_ID=T.ARE_ID " & _
                    "AND PED.PED_TIPO= 'URGENCIA' " & _
                    "AND PED.PED_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "GROUP BY PED.PED_ID " & _
                    "ORDER BY PED.PED_FECING"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Informe Estadistico Pacientes Emergencia"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 15 '"Aspirantes"
                    'REPORTE DE RESULTADOS DE ASPIRANTES 1HOJA
                    Dim opr_reportes As New Cls_Resultado()
                    Dim str_cadena, str_sql_res, resultado, str_sql1, flag As String
                    Dim ped_id As Integer = opr_reportes.ConsultarPedidoxTurno(CInt(txt_parametro.Text), dtp_fechaI.Value)
                    If ped_id = -1 Then
                        Me.Cursor = System.Windows.Forms.Cursors.Arrow
                        MsgBox("El numero ingresado no existe, verifiquelo por favor", MsgBoxStyle.Exclamation, "ANALISYS")
                        Exit Sub
                    End If
                    'Voy consultando los resultados del aspirante

                    'Primero consulto si esta validado o sino presento ND  No Disponible
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400101"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        'WBC
                        resultado = "ND"
                        str_cadena = "SELECT '" & resultado & "' AS WBC, "
                        'RBC
                        str_cadena = str_cadena & "'" & resultado & "' AS RBC, "
                        'HGB
                        str_cadena = str_cadena & "'" & resultado & "' AS HGB, "
                        'HCT
                        str_cadena = str_cadena & "'" & resultado & "' AS HCT, "
                        'MONO%
                        str_cadena = str_cadena & "'" & resultado & "' AS MONO, "
                        'NEU%
                        str_cadena = str_cadena & "'" & resultado & "' AS NEU, "
                        'BASO%
                        str_cadena = str_cadena & "'" & resultado & "' AS BASO, "
                        'LYM%
                        str_cadena = str_cadena & "'" & resultado & "' AS LYM, "
                        'EOS%
                        str_cadena = str_cadena & "'" & resultado & "' AS EOS, "
                    Else
                        'WBC
                        str_sql_res = "select PRC_RESFINAL AS WBC from res_procesados where TES_ABREV LIKE 'WBC%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = "SELECT '" & resultado & "' AS WBC, "
                        str_sql_res = "select PRC_RESFINAL AS WBC from res_procesados where TES_ABREV LIKE 'WBC%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = "SELECT '" & resultado & "' AS WBC, "
                        'RBC
                        str_sql_res = "select PRC_RESFINAL AS RBC from res_procesados where TES_ABREV LIKE 'RBC%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS RBC, "
                        'HGB
                        str_sql_res = "select PRC_RESFINAL AS HGB from res_procesados where TES_ABREV LIKE 'HGB%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS HGB, "
                        'HCT
                        str_sql_res = "select PRC_RESFINAL AS HCT from res_procesados where TES_ABREV LIKE 'HCT%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS HCT, "
                        'MONO%
                        str_sql_res = "select PRC_RESFINAL AS MONO from res_procesados where TES_ABREV LIKE 'MONO%%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS MONO, "
                        'NEU%
                        str_sql_res = "select PRC_RESFINAL AS NEU from res_procesados where TES_ABREV LIKE 'NEU%%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS NEU, "
                        'BASO%
                        str_sql_res = "select PRC_RESFINAL AS BASO from res_procesados where TES_ABREV LIKE 'BASO%%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS BASO, "
                        'LYM%
                        str_sql_res = "select PRC_RESFINAL AS LYM from res_procesados where TES_ABREV LIKE 'LYM%%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS LYM, "
                        'EOS%
                        str_sql_res = "select PRC_RESFINAL AS EOS from res_procesados where TES_ABREV LIKE 'EOS%%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS EOS, "
                    End If
                    'FTA
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400164"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS FTA, "
                    Else
                        str_sql_res = "SELECT LIS_RESMANUAL AS PTHA FROM LISTA_TRABAJO where TES_ID = 400164 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS FTA, "
                    End If

                    'TIPIFICACION
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400114"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS GRUPO, "
                    Else
                        str_sql_res = "SELECT LIS_RESMANUAL AS GRUPO FROM LISTA_TRABAJO where TES_ID = 400114 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS GRUPO, "
                    End If

                    'VDRL
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400161"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS VDRL, "
                    Else
                        str_sql_res = "SELECT LIS_RESMANUAL AS VDRL FROM LISTA_TRABAJO where TES_ID = 400161 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS VDRL, "
                    End If

                    'RPR
                    'str_sql_res = "SELECT LIS_RESMANUAL AS RPR FROM LISTA_TRABAJO where TES_ID = 400162 AND PED_ID = " & ped_id
                    'resultado = opr_reportes.ResAspirante(str_sql_res)
                    'str_cadena = str_cadena & "'" & resultado & "' AS RPR, "

                    'GLU
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400142"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS GLU, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS GLU FROM RES_PROCESADOS where TES_ABREV = 'GLU' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS GLU, "
                    End If

                    'UREA
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400140"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS UREA, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS UREA FROM RES_PROCESADOS where TES_ABREV = 'BUN' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS UREA, "
                    End If

                    'CREATININA
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400141"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS CREA, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS CREA FROM RES_PROCESADOS where TES_ABREV = 'CREA' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS CREA, "
                    End If
                    'AC URICO
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400148"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS URCA, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS URCA FROM RES_PROCESADOS where TES_ABREV = 'URCA' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS URCA, "
                    End If
                    'CHOL
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400149"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS CHOL, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS CHOL FROM RES_PROCESADOS where TES_ABREV = 'CHOL' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS CHOL, "
                    End If

                    'HDL
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400150"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS HDL, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS HDL FROM RES_PROCESADOS where TES_ABREV = 'AHDL' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS HDL, "
                    End If

                    'TRIG
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400151"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS TRIG, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS TRIG FROM RES_PROCESADOS where (TES_ABREV = 'TGL' OR TES_ABREV = 'TRIG') AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS TRIG, "
                    End If

                    'HCV
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400277"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS HCV, "
                    Else
                        str_sql_res = "SELECT LIS_RESMANUAL AS HCV FROM LISTA_TRABAJO where TES_ID = 400277 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS HCV, "
                    End If

                    'HIV
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400278"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS VIH, "
                    Else
                        str_sql_res = "SELECT lis_resmanual AS VIH FROM lista_trabajo where TES_ID = 400278 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS VIH, "
                    End If

                    'HBSAG
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400304"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS HBSAG, "
                    Else
                        str_sql_res = "SELECT LIS_RESMANUAL AS HBSAG FROM LISTA_TRABAJO where TES_ID = 400304 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS HBSAG, "
                    End If

                    'BETA HCG
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400182"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS BETAHCG, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS HCGBETA FROM RES_PROCESADOS where TES_ABREV like 'HCG-BETA%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS BETAHCG, "
                    End If

                    'PSA
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400282"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS PSA, "
                    Else
                        str_sql_res = "SELECT PRC_RESFINAL AS PSA FROM RES_PROCESADOS where TES_ABREV like 'PSA%' AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS PSA, "
                    End If

                    'COPRO
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400244"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS COPRO, "
                    Else
                        str_sql_res = "SELECT LIS_rESMANUAL AS COPRO FROM LISTA_TRABAJO where TES_ID = 400244 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS COPRO, "
                    End If

                    'EMO
                    str_sql1 = "select LIS_RESESTADO from lista_trabajo where ped_id = " & ped_id & " and tes_id = 400230"
                    flag = opr_reportes.ResValidado(str_sql1)
                    If flag = "ND" Then
                        resultado = "ND"
                        str_cadena = str_cadena & "'" & resultado & "' AS EMO, "
                    Else
                        str_sql_res = "SELECT LIS_RESMANUAL AS EMO FROM LISTA_TRABAJO where TES_ID = 400230 AND PED_ID = " & ped_id
                        resultado = opr_reportes.ResAspirante(str_sql_res)
                        str_cadena = str_cadena & "'" & resultado & "' AS EMO, "
                    End If

                    str_cadena = str_cadena & "'" & txt_parametro.Text & "' as TURNO, "
                    str_cadena = str_cadena & "PED_ID AS PEDIDO, PED_FECING as FECHA FROM PEDIDO WHERE PED_ID = " & ped_id


                    Dim obj_reporte As New rpt_aspirantes()
                    Dim frm_MDIChild As New Frm_reportes(str_cadena, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Resultados Aspirantes"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)

                Case 33

                Case 12 '"Pruebas ejecutadas"
                    'PRUEBAS EJECUTADAS EN UN PERIODO DE TIEMPO   
                    Dim obj_reporte As New rpt_PrueEjecutadas()
                    'str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' as FECHAF, B.TES_NOMBRE, A.PRUEBAS FROM (SELECT P.TES_ID AS TEST, COUNT (P.TES_ID) AS PRUEBAS FROM LISTA_TRABAJO AS P WHERE P.LIS_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' GROUP BY P.TES_ID) AS A, TEST AS B WHERE A.TEST = B.TES_ID"
                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AS FECHAF, pedido.CON_NOMBRE, pedido.PED_FECING, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, (paciente.PAC_APELLIDO + '' + paciente.PAC_NOMBRE) as paciente, test.TES_NOMBRE " & _
                              "from pedido, paciente, test, lista_trabajo " & _
                              "where lista_trabajo.ped_id = pedido.ped_id and lista_trabajo.tes_id = test.tes_id and pedido.PAC_ID = paciente.PAC_ID and pedido.PED_ESTADO <> 5 and pedido.PED_FECING between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                              "order by pedido.PED_ID asc "
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Pruebas ejecutadas"
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)
                Case 13 '"Pruebas ejecutadas por Equipos"
                    'PRUEBAS EJECUTADAS EN UN PERIODO DE TIEMPO POR EQUIPO
                    Dim obj_reporte As New rpt_PrueEjecutadas()
                    'str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' as FECHAF, EQUIPO.EQU_MODELO as EQUIPO, TEST.TES_NOMBRE AS TEST, Count(LISTA_TRABAJO.TES_ID) AS PRUEBAS FROM TEST INNER JOIN ((EQUIPO INNER JOIN LISTA_TRABAJO ON EQUIPO.EQU_ID = LISTA_TRABAJO.EQU_ID) INNER JOIN TEST_EQUIPO ON EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID) ON (TEST.TES_ID = TEST_EQUIPO.TES_ID) AND (TEST.TES_ID = LISTA_TRABAJO.TES_ID) WHERE (((LISTA_TRABAJO.LIS_FECING) Between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "')) GROUP BY EQUIPO.EQU_MODELO, TEST.TES_NOMBRE, LISTA_TRABAJO.EQU_ID, LISTA_TRABAJO.TES_ID, TEST.TES_TPROCES HAVING (((TEST.TES_TPROCES)=0))"
                    str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AS FECHAI, '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' as FECHAF, E.EQU_MODELO as EQUIPO, T.TES_NOMBRE AS TEST, Count(LT.TES_ID) AS PRUEBAS FROM LISTA_TRABAJO as LT, TEST AS T, EQUIPO AS E WHERE LIS_RESESTADO <> 2 AND LT.LIS_FECING BETWEEN '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' AND  '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' AND T.TES_ID = LT.TES_ID  AND T.TES_TPROCES = 1 AND E.EQU_ID = LT.EQU_ID GROUP BY LT.EQU_ID, LT.TES_ID, E.EQU_MODELO, T.TES_NOMBRE;"
                    Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , 1)
                    frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    frm_MDIChild.Text = "Reporte Pruebas Ejecutadas "
                    frm_refer_main_form.Crea_formulario(frm_MDIChild)
                Case 16 '"Pruebas no registradas"
                    ''PRUEBAS EJECUTADAS EN UN PERIODO DE TIEMPO Y QUE NO CORRESPONDEN A NINGUN PEDIDO REALIZADO EN EL SISTEMA
                    'Dim obj_reporte As New rpt_PruebasNoRegistradas()
                    'str_sql = "SELECT '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' as FECHAI , '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' as FECHAF, E.equ_modelo as EQUIPO, LA.log_test as TEST, count(LA.log_test) as PRUEBAS from log_archivo AS LA, equipo as E where LA.log_fecha between '" & Format(dtp_fechaI.Value, "dd/MM/yyyy") & "' and '" & Format(dtp_fechaF.Value, "dd/MM/yyyy") & "' and LA.log_equipo = E.sni_nombre group by LA.log_test, E.equ_modelo"
                    'Dim frm_MDIChild As New Frm_reportes(str_sql, obj_reporte, , , , ,1)
                    'frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
                    'frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
                    'frm_MDIChild.Text = "Reporte Pruebas no Registradas"
                    'frm_refer_main_form.Crea_formulario(frm_MDIChild)
            End Select
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        'frm_refer_main_form.escribemsj("DISPONIBLE")
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub frm_Rpt_PruebasFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        'cmb_reporte.SelectedIndex = 0
        dts_reportes = opr_res.llenaListaReportes(lst_reportes, 1, "LA")
        dts_reportesHC = opr_res.llenaListaReportes(lst_reportesHC, 1, "HC")
        dtp_fechaI.Value = Today
        dtp_fechaF.Value = Today
    End Sub

    Private Sub cmb_reporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim opr_area As New Cls_Areas()
        'Dim opr_servicios As New Cls_servicios
        'Dim opr_test As New Cls_Test()
        'Select Case cmb_reporte.Text
        '    Case "Aspirantes", "Vales de Laboratorio diario (NORMAL)", "Vales de Laboratorio diario (URGENCIA)", "L�quidos (Citoqu�mico y Bacteriol�gico)", "Estadistica Produccion"
        '        lbl_parametro.Visible = True
        '        lbl_apellido.Visible = False
        '        txt_parametro.Visible = True
        '        txt_parametro.Text = ""
        '        txt_parametro.Focus()
        '        dtp_fechaI.Enabled = True
        '        dtp_fechaF.Enabled = False
        '        cmb_parametros.Items.Clear()
        '        cmb_parametros.Enabled = False
        '        CMB_PARAMETROS2.Items.Clear()
        '        CMB_PARAMETROS2.Enabled = False
        '        txt_parametros2.Text = ""
        '        txt_parametros2.Enabled = False

        '    Case "Vales de Laboratorio total (AMBOS)"
        '        txt_parametro.Text = ""
        '        txt_parametro.Width = 254
        '        lbl_parametro.Visible = False
        '        lbl_apellido.Visible = True
        '        txt_parametro.Visible = True
        '        dtp_fechaI.Enabled = True
        '        dtp_fechaF.Enabled = True

        '    Case "Hist�rico de pruebas manuales x paciente"
        '        cmb_parametros.Visible = True
        '        lbl_apellido.Visible = True
        '        lbl_apellido.Text = "Par�metro:"
        '        opr_test.LlenarCmb_Test(cmb_parametros)
        '        CMB_PARAMETROS2.Enabled = True
        '        txt_parametros2.Enabled = True
        '        txt_parametros2.Text = ""

        '    Case "Bonificaciones"
        '        txt_parametros2.Visible = False
        '        cmb_parametros.Visible = True
        '        cmb_parametros.Items.Clear()
        '        LlenarComboParametros(cmb_parametros)
        '        cmb_parametros.SelectedIndex = 0
        '        cmb_parametros.Enabled = True
        '        'lbl_pedido.Visible = False
        '        Label2.Visible = True
        '        Label2.Text = "Medico:"

        '    Case "Reporte de Produccion por pacientes atendidos"
        '        cmb_parametros.Visible = True
        '        lbl_apellido.Visible = True
        '        lbl_apellido.Text = "Par�metro:"
        '        cmb_parametros.Items.Clear()
        '        opr_servicios.LlenarCmb_Servicios(cmb_parametros)
        '        'opr_area.LlenarCmb_Area(cmb_parametros)

        '    Case Else
        '        txt_parametro.Text = ""
        '        lbl_parametro.Visible = False
        '        lbl_apellido.Visible = False
        '        txt_parametro.Visible = False
        '        dtp_fechaI.Enabled = True
        '        dtp_fechaF.Enabled = True
        '        cmb_parametros.Items.Clear()
        '        cmb_parametros.Enabled = False
        '        CMB_PARAMETROS2.Enabled = False
        '        CMB_PARAMETROS2.Visible = False
        '        txt_parametros2.Text = ""
        '        txt_parametros2.Enabled = False
        'End Select

    End Sub

    Sub LlenarComboParametros(ByRef cmb_parametros As ComboBox, Optional ByVal parametro As Byte = 0)
        On Error GoTo msgerr
        'Para llenar el combo con los datos de un medico y la Bonificacion que posee
        Dim cls_operacion As New Cls_Conexion()
        cls_operacion.sql_conectar()
        Dim str_sql As String = ""
        If parametro = 0 Then
            str_sql = "Select med_nombre, med_id from Medico order by med_nombre"
        Else
            str_sql = "Select con_nombre from convenio order by con_nombre"
        End If
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        cmb_parametros.Items.Clear()
        If parametro = 1 Then
            cmb_parametros.Items.Add("TODOS")
        End If
        While odr_operacion.Read
            cmb_parametros.Items.Add(odr_operacion.GetValue(0).ToString())
            'cmb_parametros.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & odr_operacion.GetValue(1).ToString().PadRight(10))
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        cmb_parametros.SelectedIndex = 0
        Exit Sub
msgerr:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Llenar combo parametros", Err)
        Err.Clear()
    End Sub


    Private Sub lst_reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_reportes.Click
        Dim pos As Integer = 0

        pos = lst_reportes.SelectedIndex
        lst_reportes.SelectedIndex = pos
        If pos >= 0 Then
            num_reporte = dts_reportes.Tables(0).Rows(pos).Item(1).ToString
            lbl_nomreporte.Text = Trim(dts_reportes.Tables(0).Rows(pos).Item(0).ToString)
            Call CargaParametros(num_reporte)
        End If
        lst_reportes.SelectedIndex = (pos)
    End Sub

    Function CargaParametros(ByVal num_reporte As Integer)
        Dim opr_area As New Cls_Areas()
        Dim opr_servicios As New Cls_servicios
        Dim opr_test As New Cls_Test()

        '1	Reporte Caja por CONVENIOS 
        '2	Bonificaciones a medicos                                                                                                
        '3	Test / grupos hetareos                                                                                                  
        '4	Medico / especialidad                                                                                                   
        '5	test / origen                                                                                                           
        '6	Estadistica conteo por Areas                                                                                            
        '7	Estadistica conteo por Edades                                                                                           
        '8	Estadistica conteo por Servicio                                                                                         
        '9	Estadistica conteo por Sexo                                                                                             
        '10 Estadistica(Produccion)
        '11	Informe de Ingresos                                                                                                     
        '12 Pruebas(ejecutadas)
        '13	Pruebas ejecutadas por Equipos                                                                                          
        '14	Reporte de Produccion por pacientes atendidos 
        '15 Reportes resultados por bloque
        '16 Trazabilidad muestra
        '18 Listado cuentas
        '19	Reporte medicos
        '20	Reporte pacientes HIS

        CMB_PARAMETROS2.Visible = False
        cmb_parametros.Visible = False

        Select Case num_reporte

            Case 28
                'txt_parametros2.Visible = True
                'txt_parametros2.Enabled = True
                'txt_parametros2.Text = ""
                cmb_parametros.Items.Clear()
                cmb_parametros.Visible = True
                cmb_parametros.Enabled = True
                cmb_parametros.Items.Add("CUTANEAS ALIMENTOS                     401310")
                cmb_parametros.Items.Add("CUTANEAS INHALANTES                    401311")
                cmb_parametros.Items.Add("CUTANEAS MEDICAMENTOS                  401312")
                cmb_parametros.Items.Add("CUTANEAS ANTIBIOTICOS                  401321")
                cmb_parametros.Items.Add("CUTANEAS OTRAS SUSTANCIAS              401322")
                cmb_parametros.Items.Add("CUTANEAS OTROS MEDICAMENTOS            401325")
                cmb_parametros.Items.Add("CUTANEAS NIÑOS ALIMENTOS               401323")
                cmb_parametros.Items.Add("CUTANEAS NIÑOS INHALANTES              401324")
                

                cmb_parametros.SelectedIndex = 0

            Case 27
                'txt_parametros2.Visible = True
                'txt_parametros2.Enabled = True
                'txt_parametros2.Text = ""
                cmb_parametros.Items.Clear()
                cmb_parametros.Visible = True
                cmb_parametros.Enabled = True
                cmb_parametros.Items.Add("Todos")
                cmb_parametros.Items.Add("Positivo")
                cmb_parametros.Items.Add("Negativo")
                cmb_parametros.SelectedIndex = 0

            Case 25
                txt_parametros2.Visible = True
                txt_parametros2.Enabled = True
                txt_parametros2.Text = ""
                'lbl_apellido.Visible = False
                'lbl_parametro.Text = "Cedula/Pas:"
                'lbl_parametro.Visible = True

            Case 0 '"Aspirantes", "Vales de Laboratorio diario (NORMAL)", "Vales de Laboratorio diario (URGENCIA)", "L�quidos (Citoqu�mico y Bacteriol�gico)", "Estadistica Produccion"
                lbl_parametro.Visible = True
                lbl_apellido.Visible = False
                txt_parametro.Visible = True
                txt_parametro.Text = ""
                txt_parametro.Focus()
                dtp_fechaI.Enabled = True
                dtp_fechaF.Enabled = False
                cmb_parametros.Items.Clear()
                cmb_parametros.Enabled = False

                CMB_PARAMETROS2.Visible = True
                CMB_PARAMETROS2.Items.Clear()
                CMB_PARAMETROS2.Enabled = False
                txt_parametros2.Text = ""
                txt_parametros2.Enabled = False

            Case 6, 7, 8, 9
                txt_parametro.Text = ""
                txt_parametro.Width = 254
                lbl_parametro.Visible = False
                lbl_apellido.Visible = True
                txt_parametro.Visible = True
                dtp_fechaI.Enabled = True
                dtp_fechaF.Enabled = True

            Case 312
                cmb_parametros.Visible = True
                lbl_apellido.Visible = True
                lbl_apellido.Text = "Parametro:"
                opr_test.LlenarCmb_Test(cmb_parametros)
                CMB_PARAMETROS2.Enabled = True
                txt_parametros2.Enabled = True
                txt_parametros2.Text = ""

            Case 11
                cmb_parametros.Visible = False
                lbl_apellido.Visible = False
                'opr_area.LlenarCmb_Area(cmb_parametros)
                CMB_PARAMETROS2.Visible = False
                CMB_PARAMETROS2.Enabled = False
                txt_parametros2.Enabled = False
                txt_parametros2.Text = ""


            Case 2, 19
                txt_parametros2.Visible = False
                cmb_parametros.Visible = True
                cmb_parametros.Items.Clear()
                LlenarComboParametros(cmb_parametros)
                cmb_parametros.SelectedIndex = 0
                cmb_parametros.Enabled = True
                'lbl_pedido.Visible = False
                lbl_apellido.Visible = True
                lbl_apellido.Text = "Medico:"

            Case 14
                cmb_parametros.Visible = True
                lbl_apellido.Visible = True
                lbl_apellido.Text = "Parametro:"
                cmb_parametros.Items.Clear()
                opr_servicios.LlenarCmb_Servicios(cmb_parametros)
                'opr_area.LlenarCmb_Area(cmb_parametros)

            Case 19

                Dim opr_pedido As New Cls_Pedido

                cmb_parametros.Visible = True
                lbl_apellido.Visible = True
                lbl_apellido.Text = "Empresa:"
                ComboBox1.Items.Clear()
                ComboBox1.Visible = True
                opr_servicios.LlenarCmb_ExamenTODOS(ComboBox1)
                ComboBox1.Enabled = True

                cmb_parametros.Items.Clear()
                cmb_parametros.Visible = True
                opr_pedido.LlenarComboPrioridadTODOS(cmb_parametros, True)
                cmb_parametros.Enabled = True



            Case 15
                Dim opr_pedido As New Cls_Pedido
                ComboBox1.Visible = True

                'cmb_parametros.Items.Clear()
                ComboBox1.Items.Clear()

                'LlenarComboParametros(cmb_parametros, 1)
                opr_pedido.LlenarComboPrioridad(ComboBox1, True, False)

                'LlenarComboParametros(ComboBox1, 2)

                'cmb_parametros.SelectedIndex = 0
                ComboBox1.SelectedIndex = 0

                'cmb_parametros.Enabled = True
                ComboBox1.Enabled = True

                'lbl_apellido.Visible = True
                'lbl_apellido.Text = "Convenio:"

                lbl_secuencias.Visible = True
                lbl_secuencias.Text = "Secuencia:"

                Label2.Visible = False
                CMB_PARAMETROS2.Visible = False

            Case 16
                txt_parametro.Visible = True
                ComboBox1.Visible = False
                txt_parametro.Text = ""
                txt_parametro.Width = 254
                dtp_fechaI.Enabled = False
                dtp_fechaF.Enabled = False
                cmb_parametros.Visible = False

                CMB_PARAMETROS2.Visible = False
                CMB_PARAMETROS2.Enabled = False

            Case 18
                Dim opr_pedido As New Cls_Pedido
                txt_parametro.Visible = True
                ComboBox1.Visible = True
                ComboBox1.Items.Clear()
                'LlenarComboParametros(cmb_parametros, 1)
                opr_pedido.LlenarComboPrioridadTODOS(ComboBox1, True)

                'cmb_parametros.SelectedIndex = 0
                ComboBox1.SelectedIndex = 0

                'cmb_parametros.Enabled = True
                ComboBox1.Enabled = True


                txt_parametro.Text = ""
                txt_parametro.Width = 254
                dtp_fechaI.Enabled = True
                dtp_fechaF.Enabled = True
                cmb_parametros.Visible = False
                CMB_PARAMETROS2.Visible = False
                CMB_PARAMETROS2.Enabled = False

            Case 20
                txt_parametro.Visible = True
                lbl_apellido.Visible = False
                lbl_secuencias.Visible = False
                Label2.Visible = False
                cmb_parametros.Visible = False
                CMB_PARAMETROS2.Visible = False
                ComboBox1.Visible = False
                txt_parametros2.Visible = False
                txt_parametro.Visible = False

            Case Else
                txt_parametro.Text = ""
                lbl_parametro.Visible = False
                lbl_apellido.Visible = False
                txt_parametro.Visible = False
                dtp_fechaI.Enabled = True
                dtp_fechaF.Enabled = True
                cmb_parametros.Items.Clear()
                cmb_parametros.Enabled = False
                CMB_PARAMETROS2.Visible = False
                CMB_PARAMETROS2.Enabled = False
                CMB_PARAMETROS2.Visible = False
                txt_parametros2.Text = ""
                txt_parametros2.Enabled = False
        End Select

    End Function

    Private Sub lst_reportesHC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_reportesHC.Click
        Dim pos As Integer = 0

        pos = lst_reportesHC.SelectedIndex
        lst_reportesHC.SelectedIndex = pos
        If pos >= 0 Then
            num_reporte = dts_reportesHC.Tables(0).Rows(pos).Item(1).ToString
            lbl_nomreporte.Text = Trim(dts_reportesHC.Tables(0).Rows(pos).Item(0).ToString)
            Call CargaParametros(num_reporte)
        End If
        lst_reportesHC.SelectedIndex = (pos)
    End Sub
End Class

