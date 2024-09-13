Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Math
Imports System.Data.SqlClient



Public Class frm_Rpt_Factura
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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_tipo_reporte As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_tiporep As System.Windows.Forms.Label
    Friend WithEvents lbl_fec1 As System.Windows.Forms.Label
    Friend WithEvents lbl_fec2 As System.Windows.Forms.Label
    Friend WithEvents lbl_numfact As System.Windows.Forms.Label
    Friend WithEvents grp_datos As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fec1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fec2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ctl_txt_numfact As Ctl_txt.ctl_txt_numeros
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Rpt_Factura))
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.cmb_tipo_reporte = New System.Windows.Forms.ComboBox
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.lbl_tiporep = New System.Windows.Forms.Label
        Me.lbl_fec1 = New System.Windows.Forms.Label
        Me.lbl_fec2 = New System.Windows.Forms.Label
        Me.dtp_fec1 = New System.Windows.Forms.DateTimePicker
        Me.dtp_fec2 = New System.Windows.Forms.DateTimePicker
        Me.lbl_numfact = New System.Windows.Forms.Label
        Me.grp_datos = New System.Windows.Forms.GroupBox
        Me.Ctl_txt_numfact = New Ctl_txt.ctl_txt_numeros
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.grp_datos.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(292, 196)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 41)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'cmb_tipo_reporte
        '
        Me.cmb_tipo_reporte.DisplayMember = "1"
        Me.cmb_tipo_reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_reporte.Location = New System.Drawing.Point(109, 49)
        Me.cmb_tipo_reporte.Name = "cmb_tipo_reporte"
        Me.cmb_tipo_reporte.Size = New System.Drawing.Size(240, 21)
        Me.cmb_tipo_reporte.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(210, 196)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 41)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Consultar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.UseMnemonic = False
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'lbl_tiporep
        '
        Me.lbl_tiporep.AutoSize = True
        Me.lbl_tiporep.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tiporep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tiporep.ForeColor = System.Drawing.Color.Black
        Me.lbl_tiporep.Location = New System.Drawing.Point(51, 52)
        Me.lbl_tiporep.Name = "lbl_tiporep"
        Me.lbl_tiporep.Size = New System.Drawing.Size(52, 13)
        Me.lbl_tiporep.TabIndex = 108
        Me.lbl_tiporep.Text = "Reporte"
        Me.lbl_tiporep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_fec1
        '
        Me.lbl_fec1.AutoSize = True
        Me.lbl_fec1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fec1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec1.ForeColor = System.Drawing.Color.Black
        Me.lbl_fec1.Location = New System.Drawing.Point(9, 31)
        Me.lbl_fec1.Name = "lbl_fec1"
        Me.lbl_fec1.Size = New System.Drawing.Size(70, 13)
        Me.lbl_fec1.TabIndex = 109
        Me.lbl_fec1.Text = "Fec. Inicial"
        Me.lbl_fec1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_fec2
        '
        Me.lbl_fec2.AutoSize = True
        Me.lbl_fec2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fec2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec2.ForeColor = System.Drawing.Color.Black
        Me.lbl_fec2.Location = New System.Drawing.Point(183, 31)
        Me.lbl_fec2.Name = "lbl_fec2"
        Me.lbl_fec2.Size = New System.Drawing.Size(63, 13)
        Me.lbl_fec2.TabIndex = 3
        Me.lbl_fec2.Text = "Fec. Final"
        Me.lbl_fec2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_fec1
        '
        Me.dtp_fec1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec1.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fec1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fec1.Location = New System.Drawing.Point(83, 29)
        Me.dtp_fec1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fec1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fec1.Name = "dtp_fec1"
        Me.dtp_fec1.Size = New System.Drawing.Size(88, 20)
        Me.dtp_fec1.TabIndex = 0
        '
        'dtp_fec2
        '
        Me.dtp_fec2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec2.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fec2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fec2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fec2.Location = New System.Drawing.Point(251, 29)
        Me.dtp_fec2.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fec2.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fec2.Name = "dtp_fec2"
        Me.dtp_fec2.Size = New System.Drawing.Size(88, 20)
        Me.dtp_fec2.TabIndex = 1
        '
        'lbl_numfact
        '
        Me.lbl_numfact.AutoSize = True
        Me.lbl_numfact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_numfact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_numfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numfact.ForeColor = System.Drawing.Color.Black
        Me.lbl_numfact.Location = New System.Drawing.Point(45, 82)
        Me.lbl_numfact.Name = "lbl_numfact"
        Me.lbl_numfact.Size = New System.Drawing.Size(50, 13)
        Me.lbl_numfact.TabIndex = 114
        Me.lbl_numfact.Text = "Factura"
        '
        'grp_datos
        '
        Me.grp_datos.BackColor = System.Drawing.Color.Transparent
        Me.grp_datos.Controls.Add(Me.dtp_fec1)
        Me.grp_datos.Controls.Add(Me.lbl_fec2)
        Me.grp_datos.Controls.Add(Me.lbl_fec1)
        Me.grp_datos.Controls.Add(Me.dtp_fec2)
        Me.grp_datos.Location = New System.Drawing.Point(12, 113)
        Me.grp_datos.Name = "grp_datos"
        Me.grp_datos.Size = New System.Drawing.Size(354, 66)
        Me.grp_datos.TabIndex = 2
        Me.grp_datos.TabStop = False
        '
        'Ctl_txt_numfact
        '
        Me.Ctl_txt_numfact.Location = New System.Drawing.Point(111, 76)
        Me.Ctl_txt_numfact.Name = "Ctl_txt_numfact"
        Me.Ctl_txt_numfact.Prp_Formato = False
        Me.Ctl_txt_numfact.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_numfact.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Enteros
        Me.Ctl_txt_numfact.Prp_ValDefault = "0"
        Me.Ctl_txt_numfact.Size = New System.Drawing.Size(238, 20)
        Me.Ctl_txt_numfact.TabIndex = 0
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(398, 25)
        Me.pan_barra.TabIndex = 115
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(7, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(119, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "FACTURACION"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Rpt_Factura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(398, 255)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.Ctl_txt_numfact)
        Me.Controls.Add(Me.grp_datos)
        Me.Controls.Add(Me.lbl_tiporep)
        Me.Controls.Add(Me.lbl_numfact)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cmb_tipo_reporte)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Rpt_Factura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tip"
        Me.grp_datos.ResumeLayout(False)
        Me.grp_datos.PerformLayout()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Cdigo de Formulario"

    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image


#End Region

    Public lng_factura As Long
    Public sht_opera As Long
    Public frm_refer_main As Frm_Main
    Dim opr_fac As New Cls_Factura()

    Private Const str_reporte1 As String = "Factura"
    Private Const str_reporte2 As String = "Abono"
    Private Const str_reporte3 As String = "Facturas por Cobrar"
    Private Const str_reporte4 As String = "Caja"
    Private Const str_reporte5 As String = "Abonos diarios"


    Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Sub Obtiene_dato_abono_factura(ByVal str_sql As String, ByRef dts_registro As DataSet)
        'funci�n que une dos dataset para el caso de una o varias facturas, donde se obtiene
        'el total de abonado
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dbl_sumabono As Double = 0
        Dim int_indice, int_indice2 As Integer

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_registro, "Registros")
        'XXX CORREGIR ERROR AL SELECCIONAR EL DATO DE LA ULTIMA FACTURA
        dts_registro.Tables(0).Columns.Add("SUM_ABO")

        If cmb_tipo_reporte.Text = str_reporte1 Then
            str_sql = "select FAC_ID, round(sum(ABO_MONTO),2) FROM ABONO where FAC_ID = '" & Ctl_txt_numfact.texto_Recupera & "' group by FAC_ID"
            oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            oda_operacion.Fill(dts_registro, "Registros2")
            If dts_registro.Tables("Registros2").Rows.Count > 0 Then
                dtr_fila = dts_registro.Tables("Registros2").Rows(int_indice)
                'se llena toda la columna con el dato de la suma de abonos
                If Not IsDBNull(dtr_fila(1)) Then dbl_sumabono = dtr_fila(1)
            End If

            For int_indice = 0 To dts_registro.Tables(0).Rows.Count - 1
                dts_registro.Tables(0).Rows(int_indice).Item("SUM_ABO") = Round(CDbl(dbl_sumabono), 2)
            Next

        Else
            If dts_registro.Tables(0).Rows.Count > 0 Then
                For int_indice = 0 To dts_registro.Tables(0).Rows.Count - 1
                    str_sql = "select FAC_ID, sum(ABO_MONTO) FROM ABONO where FAC_ID = '" & dts_registro.Tables(0).Rows(int_indice).Item(0) & "' group by FAC_ID"
                    oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
                    oda_operacion.Fill(dts_registro, "Registros2")
                    dbl_sumabono = 0
                    If dts_registro.Tables("Registros2").Rows.Count > 0 Then
                        dtr_fila = dts_registro.Tables("Registros2").Rows(int_indice)
                        'se llena toda la columna con el dato de la suma de abonos
                        If Not IsDBNull(dtr_fila(1)) Then dbl_sumabono = dtr_fila(1)
                    End If
                    For int_indice2 = 0 To dts_registro.Tables(0).Rows.Count - 1
                        If dts_registro.Tables(0).Rows(int_indice).Item(0) = dts_registro.Tables(0).Rows(int_indice2).Item(0) Then
                            dts_registro.Tables(0).Rows(int_indice).Item("SUM_ABO") = dbl_sumabono
                        End If
                    Next
                Next
            End If

        End If
        opr_Conexion.sql_desconn()

    End Sub

    Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If Ctl_txt_numfact.texto_Recupera = 0 And cmb_tipo_reporte.Text <> str_reporte3 And cmb_tipo_reporte.Text <> str_reporte4 And cmb_tipo_reporte.Text <> str_reporte5 Then
            'If cmb_tipo_reporte.Text = str_reporte1 Or cmb_tipo_reporte.Text = str_reporte1 Then
            MsgBox("Ingrese el numero de factura a consultar", MsgBoxStyle.Information, "ANALISYS")
            'End If
        Else
            Dim STR_SQL, str_crea As String
            Dim obj_reporte As Object
            Dim dts_registro As DataSet = Nothing

            opr_fac.EliminaAbonoTemporal()

            'Se selecciona los reportes a ser presentados
            str_crea = ""
            Select Case cmb_tipo_reporte.Text
                Case str_reporte1
                    'ID             FAC_DOC         FAC_TOTAL       FAC_IVA         FAC_DESCUENTO 
                    'FAC_RECARGO    FAC_NOMBRE      FAC_APELLIDO    FAC_FONO        FAC_DIRECCION
                    'FAC_ESTATUS    FAC_FORMAPAGO   FAD_CANTIDAD    FAD_PRECIO      FADTIPO
                    'TESTID         TESTNOMBRE      PER_ID          PER_NOMBRE      SUM_ABO
                    'STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO, FAC_NOMBRE, FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, " & _
                    '"FACTURA_DETALLE.FAD_TIPO AS FADTIPO, TEST.TES_ID AS TESTID, TEST.TES_NOMBRE AS TESTNOMBRE, PER_ID, PER_NOMBRE " & _
                    '"FROM FACTURA INNER JOIN ((FACTURA_DETALLE LEFT JOIN TEST ON FACTURA_DETALLE.TES_ID = TEST.TES_ID) LEFT JOIN PERFIL ON FACTURA_DETALLE.TES_ID = PERFIL.PER_ID) ON FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID " & _
                    '"WHERE(FACTURA.FAC_ID = '" & Ctl_txt_numfact.texto_Recupera & "') " & _
                    '"ORDER BY FACTURA.FAC_ID "

                    STR_SQL = "SELECT FACTURA.FAC_ID AS ID, FAC_DOC, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO,FAC_FECING as FAC_NOMBRE, (FAC_APELLIDO + ' ' + FAC_NOMBRE) as FAC_APELLIDO, FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAC_FORMAPAGO, FAD_CANTIDAD, FAD_PRECIO, FACTURA_DETALLE.FAD_TIPO AS FADTIPO, " & _
   "CASE when PEDIDO.CON_NOMBRE = 'CONVENIO 1' then convert(nvarchar(100),TEST.TES_ID) else TEST.TES_ID end as TESTID, " & _
"TEST.TES_NOMBRE AS TESTNOMBRE, '' as PER_ID, '' as PER_NOMBRE, FAC_FECING AS FAC_FECING, FAC_REFERENCIA " & _
"FROM FACTURA, FACTURA_DETALLE, TEST, PEDIDO, LISTA_TRABAJO " & _
"WHERE FACTURA_DETALLE.TES_ID = TEST.TES_ID AND FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID AND FACTURA.FAC_ID = PEDIDO.FAC_ID AND FACTURA_DETALLE.FAC_ID = PEDIDO.FAC_ID AND FACTURA.FAC_ID = '" & Ctl_txt_numfact.texto_Recupera() & "' AND LISTA_TRABAJO.PED_ID = pedido.PED_ID AND test.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = FACTURA_DETALLE.TES_ID AND lista_trabajo.TES_ID = test.TES_ID " & _
"ORDER BY FACTURA.FAC_ID, TEST.TES_NOMBRE;"


                    dts_registro = New DataSet()

                    Obtiene_dato_abono_factura(STR_SQL, dts_registro)
                    If dts_registro.Tables(0).Rows.Count = 0 Then
                        MsgBox("No existe datos de la factura solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
                    Else
                        str_crea = "Factura"
                        obj_reporte = New rpt_factura()
                    End If
                    STR_SQL = ""
                Case str_reporte2
                    If dtp_fec1.Value > dtp_fec2.Value Then
                        MsgBox("El rango de fechas no se encuentra correctamente ingresado", MsgBoxStyle.Exclamation, "ANALISYS")
                    Else
                        STR_SQL = "SELECT FAC_ID, FAC_FECING, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO, FAC_NOMBRE, FAC_APELLIDO, FAC_FONO, " & _
                        "FAC_ESTATUS, FAC_REFERENCIA, FAC_FORMAPAGO, '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' as FEC1, '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & "' as FEC2  " & _
                        "FROM FACTURA WHERE (FAC_ESTATUS=0 OR FAC_ESTATUS=1) and (FAC_FECING >= '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "'  and  FAC_FECING<='" & Format(dtp_fec2.Value, "dd/MM/yyyy") & "') And FAC_ID = " & Ctl_txt_numfact.texto_Recupera() & _
                        " ORDER BY FAC_FECING, FAC_ID; "
                        dts_registro = New DataSet()
                        Obtiene_dato_abono_factura(STR_SQL, dts_registro)
                        If dts_registro.Tables(0).Rows.Count = 0 Then
                            MsgBox("No existe datos en la consulta solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
                        Else
                            str_crea = "ABONOS"
                            'obj_reporte = New rpt_factura_cobro()
                        End If
                        STR_SQL = ""
                    End If
                Case str_reporte3
                    'FAC_ID         FAC_FECING      FAC_TOTAL       FAC_IVA     
                    'FAC_DESCUENTO  FAC_RECARGO     FAC_NOMBRE      FAC_APELLIDO
                    'FAC_FONO       FAC_ESTATUS     FAC_REFERENCIA  FAC_FORMAPAGO   
                    If dtp_fec1.Value > dtp_fec2.Value Then
                        MsgBox("El rango de fechas no se encuentra correctamente ingresado", MsgBoxStyle.Exclamation, "ANALISYS")
                    Else
                        ''STR_SQL = "SELECT FAC_ID, FAC_FECING, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO, FAC_NOMBRE, FAC_APELLIDO, FAC_FONO, " & _
                        ''"FAC_ESTATUS, FAC_REFERENCIA, FAC_FORMAPAGO, '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' as FEC1, '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & "' as FEC2  " & _
                        ''"FROM FACTURA WHERE (FAC_ESTATUS=0 OR FAC_ESTATUS=1) and (FAC_FECING>= '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00'  and  FAC_FECING<='" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59')" & _
                        ''"ORDER BY FAC_FECING, FAC_ID; "

                        STR_SQL = "SELECT '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' AS FINI, a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                   "a.FAC_ESTATUS, case when a.FAC_FORMAPAGO ='1' then 'EFECTIVO' else case when a.FAC_FORMAPAGO ='2' then 'CHEQUE' else case when a.FAC_FORMAPAGO ='3' then 'T. CREDITO' else case when a.FAC_FORMAPAGO ='4' then 'TRANSF' else ''END END END  end AS FAC_FORMAPAGO,  b.ped_turno, round(abt.abo_total,2) as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, abt.abo_saldo " & _
                   "FROM FACTURA as a, pedido as b, abono as c, invitado as i, abono_temp as abt " & _
                   "WHERE abt.Fac_id = a.fac_id and (a.FAC_ESTATUS = 0 or a.FAC_ESTATUS = 1 or a.FAC_ESTATUS = 2) and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  c.ABO_FECING between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                   "And ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO and abt.abo_saldo=0 " & _
                   "group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, abt.abo_total, b.ped_turno, i.invitado_apellido, i.invitado_nombre, abt.abo_saldo "
                        '/*NO FACTURADO*/
                        STR_SQL = STR_SQL + "UNION select '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' AS FINI,'S/F' as fac_id, p.ped_fecing as fac_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                        "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, '0' as fac_formapago, " & _
                        "p.ped_turno as TURNO, '0' AS abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, (round(sum(pdd.lip_precio),2) - 0) as abo_saldo " & _
                        "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, invitado as i " & _
                        "where p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id And ped_prof <> 1 And p.ped_fecing " & _
                        "between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                        "and p.ped_fac_estado = 0 and p.ped_estado <> 2 and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO group by pdd.ped_id, p.ped_fecing, pac.PAC_APELLIDO, pac.PAC_NOMBRE, p.ped_turno, i.invitado_apellido, i.invitado_nombre "
                        ''FACTURADO Y NO CANCELADO
                        'STR_SQL = STR_SQL + "UNION select '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' AS FINI, f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                        '"f.FAC_ESTATUS, case when f.FAC_FORMAPAGO ='1' then 'EFECTIVO' else case when f.FAC_FORMAPAGO ='2' then 'CHEQUE' else case when f.FAC_FORMAPAGO ='3' then 'T. CREDITO' else case when f.FAC_FORMAPAGO ='4' then 'TRANSF' else ''END END END  end AS FAC_FORMAPAGO, p.ped_turno,0 as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, abt.abo_saldo " & _
                        '"FROM pedido as p, factura as f, invitado as i, abono_temp as abt where  ped_fac_estado = 1  " & _
                        '"And ped_prof <> 1 and fac_estatus = 0 and p.fac_id = f.fac_id and ped_fecing between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59'" & _
                        '" and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO  group by f.fac_id , p.ped_fecing , f.fac_total, f.fac_iva,f.fac_descuento, fac_recargo, f.FAC_APELLIDO, f.FAC_NOMBRE, f.FAC_ESTATUS, f.FAC_FORMAPAGO, abt.abo_total, p.ped_turno, i.invitado_apellido, i.invitado_nombre, abt.abo_saldo; "
                        str_crea = "Facturas por cobrar"
                        obj_reporte = New rpt_facCobrar()


                        ' ''dts_registro = New DataSet()
                        ' ''Obtiene_dato_abono_factura(STR_SQL, dts_registro)
                        ' ''If dts_registro.Tables(0).Rows.Count = 0 Then
                        ' ''    MsgBox("No existe datos en la consulta solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
                        ' ''Else
                        ' ''    str_crea = "Facturas por cobrar"
                        ' ''    obj_reporte = New rpt_factura_cobros()
                        ' ''End If
                        ' ''STR_SQL = ""
                    End If

                Case str_reporte4
                    ' consulto el FAC_ID del pedido
                    Dim fac_Datos As String
                    Dim Datosfac_arre As String()
                    Dim i As Integer = 0
                    Dim DatosFac As String()
                    Dim total_Abonos, saldo, Abonos_Fecha As Double

                    Datosfac_arre = Split(Recupera_DatosFac(dtp_fec1.Value, dtp_fec2.Value), "º")
                    For i = 0 To UBound(Datosfac_arre) - 1
                        DatosFac = Split(Datosfac_arre(i), ",")
                        total_Abonos = TotalAbonos(CDbl(DatosFac(0)))
                        Abonos_Fecha = AbonosFecha(CDbl(DatosFac(0)), dtp_fec1.Value, dtp_fec2.Value)
                        'If total_Abonos = Abonos_Fecha Then
                        saldo = DatosFac(3) - total_Abonos
                        'Else
                        'saldo = DatosFac(3) - total_Abonos
                        'saldo = total_Abonos - Abonos_Fecha
                        'End If

                        STR_SQL = "Insert into abono_temp values('" & DatosFac(0) & "', " & Abonos_Fecha & ", " & saldo & ")"
                        opr_fac.GuardaAbonoTemporal(STR_SQL)
                    Next

                    ' cosulto total de abonos

                    'If lbl_desde.Checked Then
                    'If txt_desde.Text = "" Or txt_hasta.Text = "" Then
                    '    MsgBox("Debe ingresar el rango de turnos a consultar.", MsgBoxStyle.Exclamation, "ANALISYS")
                    'Else
                    '/*FACTURADO Y CANCELADO o ABONADO */
                    '                                                                                                                                                                                                            DateAdd(DateInterval.Day, -28, Now)
                    STR_SQL = "SELECT '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' AS FINI, a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, (a.FAC_APELLIDO+' '+ a.FAC_NOMBRE) as fac_nombre,  " & _
                    "a.FAC_ESTATUS, case when a.FAC_FORMAPAGO ='1' then 'EFECTIVO' else case when a.FAC_FORMAPAGO ='2' then 'CHEQUE' else case when a.FAC_FORMAPAGO ='3' then 'T. CREDITO' else case when a.FAC_FORMAPAGO ='4' then 'TRANSF' else ''END END END  end AS FAC_FORMAPAGO,  b.ped_turno, round(abt.abo_total,2) as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, abt.abo_saldo " & _
                    "FROM FACTURA as a, pedido as b, abono as c, invitado as i, abono_temp as abt " & _
                    "WHERE abt.Fac_id = a.fac_id and (a.FAC_ESTATUS = 0 or a.FAC_ESTATUS = 1 or a.FAC_ESTATUS = 2) and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  c.ABO_FECING between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "And ped_prof <> 1 and (i.invitado_nombre + ' ' + i.invitado_apellido) = b.PED_RECIBO " & _
                    "group by a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, a.FAC_APELLIDO, a.FAC_NOMBRE, a.FAC_ESTATUS, a.FAC_FORMAPAGO, abt.abo_total, b.ped_turno, i.invitado_apellido, i.invitado_nombre, abt.abo_saldo "
                    '/*NO FACTURADO*/
                    STR_SQL = STR_SQL + "UNION select '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' AS FINI,'S/F' as fac_id, p.ped_fecing as fac_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                    "(pac.PAC_APELLIDO+' '+ pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, '0' as fac_formapago, " & _
                    "p.ped_turno as TURNO, '0' AS abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, (round(sum(pdd.lip_precio),2) - 0) as abo_saldo " & _
                    "from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac, invitado as i " & _
                    "where p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id And ped_prof <> 1 And p.ped_fecing " & _
                    "between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    "and p.ped_fac_estado = 0 and p.ped_estado <> 2 and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO group by pdd.ped_id, p.ped_fecing, pac.PAC_APELLIDO, pac.PAC_NOMBRE, p.ped_turno, i.invitado_apellido, i.invitado_nombre "
                    ''FACTURADO Y NO CANCELADO
                    'STR_SQL = STR_SQL + "UNION select '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' AS FINI, f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,(f.FAC_APELLIDO+' '+ f.FAC_NOMBRE) as fac_nombre, " & _
                    '"f.FAC_ESTATUS, case when f.FAC_FORMAPAGO ='1' then 'EFECTIVO' else case when f.FAC_FORMAPAGO ='2' then 'CHEQUE' else case when f.FAC_FORMAPAGO ='3' then 'T. CREDITO' else case when f.FAC_FORMAPAGO ='4' then 'TRANSF' else ''END END END  end AS FAC_FORMAPAGO, p.ped_turno,0 as abo_monto, (i.invitado_apellido + ' ' + i.invitado_nombre)  as fac_user, abt.abo_saldo " & _
                    '"FROM pedido as p, factura as f, invitado as i, abono_temp as abt where  ped_fac_estado = 1  " & _
                    '"And ped_prof <> 1 and fac_estatus = 0 and p.fac_id = f.fac_id and ped_fecing between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59'" & _
                    '" and (i.invitado_nombre + ' ' + i.invitado_apellido) = p.PED_RECIBO  group by f.fac_id , p.ped_fecing , f.fac_total, f.fac_iva,f.fac_descuento, fac_recargo, f.FAC_APELLIDO, f.FAC_NOMBRE, f.FAC_ESTATUS, f.FAC_FORMAPAGO, abt.abo_total, p.ped_turno, i.invitado_apellido, i.invitado_nombre, abt.abo_saldo; "
                    str_crea = "caja"
                    obj_reporte = New rpt_caja()
                    'End If
                    'Else
                    '/*FACTURADO Y CANCELADO o ABONADO */
                    'STR_SQL = "SELECT a.FAC_ID, a.FAC_FECING, a.FAC_TOTAL, a.FAC_IVA, a.FAC_DESCUENTO, a.FAC_RECARGO, concat(a.FAC_APELLIDO,' ', a.FAC_NOMBRE) as fac_nombre,  " & _
                    '"a.FAC_ESTATUS, a.FAC_FORMAPAGO,  b.ped_turno, round(sum(c.abo_monto),2)as abo_monto   " & _
                    '"FROM FACTURA as a, pedido as b, abono as c WHERE (a.FAC_ESTATUS = 0 or a.FAC_ESTATUS = 1 or a.FAC_ESTATUS = 2) and  b.ped_id = a.fac_pedidos and a.fac_id = c.fac_id and  a.FAC_FECING between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59'" & _
                    '" group by fac_id  "
                    ''/*NO FACTURADO*/
                    'STR_SQL = STR_SQL + "UNION select 'S/F' as fac_id, p.ped_fecing as fac_fecing,round(sum(pdd.lip_precio),2) as TOTAL,0 AS IVA,0 AS DESCUENTO,0 AS RECARGO, " & _
                    '"concat(pac.PAC_APELLIDO,' ', pac.PAC_NOMBRE) as fac_nombre,  0 as fac_estatus, 0 as fac_formapago, " & _
                    '"p.ped_turno as TURNO, '0' AS abo_monto  " & _
                    '"from pedido_detalle_desglosado as pdd, pedido as p, paciente as pac " & _
                    '"where p.ped_id = pdd.ped_id And p.pac_id = pac.pac_id  And p.ped_fecing " & _
                    '"between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59' " & _
                    '"and p.ped_fac_estado = 0 and p.ped_estado <> 2 group by pdd.ped_id  "
                    ''FACTURADO Y NO CANCELADO
                    'STR_SQL = STR_SQL + "UNION select f.fac_id , p.ped_fecing , f.fac_total ,f.fac_iva,f.fac_descuento, fac_recargo,concat(f.FAC_APELLIDO,' ', f.FAC_NOMBRE) as fac_nombre, " & _
                    '"f.FAC_ESTATUS, f.FAC_FORMAPAGO, p.ped_turno,0 as abo_monto " & _
                    '"FROM pedido as p, factura as f	where  ped_fac_estado = 1  " & _
                    '"and fac_estatus = 0 and p.fac_id = f.fac_id and ped_fecing between '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & " 00:00:00' and '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & " 23:59:59'" & _
                    '" group by p.PED_ID order by ped_turno;"
                    'str_crea = "caja"
                    'obj_reporte = New rpt_caja()
                    'End If
                Case str_reporte5
                    If dtp_fec1.Value > dtp_fec2.Value Then
                        MsgBox("El rango de fechas no se encuentra correctamente ingresado", MsgBoxStyle.Exclamation, "ANALISYS")
                    Else
                        STR_SQL = "SELECT FAC_ID, FAC_FECING, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_RECARGO, FAC_NOMBRE, FAC_APELLIDO, FAC_FONO, " & _
                        "FAC_ESTATUS, FAC_REFERENCIA, FAC_FORMAPAGO, '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "' as FEC1, '" & Format(dtp_fec2.Value, "dd/MM/yyyy") & "' as FEC2  " & _
                        "FROM FACTURA WHERE (FAC_ESTATUS=0 OR FAC_ESTATUS=1) and (FAC_FECING>= '" & Format(dtp_fec1.Value, "dd/MM/yyyy") & "'  and  FAC_FECING<='" & Format(dtp_fec2.Value, "dd/MM/yyyy") & "')" & _
                        "ORDER BY FAC_FECING, FAC_ID, TEST.TES_NOMBRE "
                        dts_registro = New DataSet()
                        Obtiene_dato_abono_factura(STR_SQL, dts_registro)
                        If dts_registro.Tables(0).Rows.Count = 0 Then
                            MsgBox("No existe datos en la consulta solicitada", MsgBoxStyle.Exclamation, "ANALISYS")
                        Else
                            str_crea = "ABONOS DIARIOS"
                            obj_reporte = New rpt_factura_cobros()
                        End If
                        STR_SQL = ""
                    End If
                Case Else
                    MsgBox("Debe seleccionar alguna opcion disponible", MsgBoxStyle.Exclamation, "ANALISYS")
            End Select

            If str_crea <> "" Then
                Dim frm_MDIChild As New Frm_reportes(STR_SQL, "", obj_reporte, dts_registro)
                frm_MDIChild.int_alto = frm_Pedido.Height
                frm_MDIChild.int_ancho = frm_Pedido.Width
                frm_MDIChild.Text = str_crea
                frm_MDIChild.Show()
                'frm_refer_main.Crea_formulario(frm_MDIChild)
                'Me.Close()
            End If
            opr_fac.EliminaAbonoTemporal()
        End If

    End Sub

    Public Function TotalAbonos(ByVal fac_id As Integer) As Double
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


    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm
        Dim sht_indice As Short

        'ubica el formulario en el centro del main
        'Me.Top = (frm_refer_main.mdiClient1.Height - Me.Height) / 2
        'Me.Left = ((frm_refer_main.mdiClient1.Width - Me.Width) / 2) + frm_refer_main.Pan_Menu.Width
        'frm_refer_main.Limpia_menu()
        'establecemos los reportes disponibles para facturas, deacuerdo al numero de constantes que existen
        cmb_tipo_reporte.Items.Add(str_reporte1)
        cmb_tipo_reporte.Items.Add(str_reporte2)
        cmb_tipo_reporte.Items.Add(str_reporte3)
        cmb_tipo_reporte.Items.Add(str_reporte4)
        'cmb_tipo_reporte.Items.Add(str_reporte5)
        dtp_fec1.Value = Today
        dtp_fec2.Value = Today
        cmb_tipo_reporte.Text = "Caja"

        'bandera de las operaciones del combo
        Select Case sht_opera
            Case 1  'abono
                cmb_tipo_reporte.SelectedIndex = 1
                'txt_desde.Visible = False
                'txt_hasta.Visible = False
                'lbl_desde.Visible = False
                'lbl_hasta.Visible = False
                Ctl_txt_numfact.Visible = True
                lbl_numfact.Visible = True
                grp_datos.Visible = False

            Case 2
                'txt_desde.Visible = True
                'txt_hasta.Visible = True
                'lbl_desde.Visible = True
                'lbl_hasta.Visible = True
                Ctl_txt_numfact.Visible = False
                lbl_numfact.Visible = False
                grp_datos.Visible = True

            Case Else
                cmb_tipo_reporte.SelectedIndex = 0
        End Select
        'desactivo la escritura en el texto de factura, cuando ya se selecciono la factura
        If lng_factura = 0 Then
            Ctl_txt_numfact.texto_Asigna(0)
        Else
            Ctl_txt_numfact.txt_padre.ReadOnly = True
            Ctl_txt_numfact.texto_Asigna(lng_factura)
        End If
    End Sub

    Private Sub cmb_tipo_reporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo_reporte.SelectedIndexChanged
        'Select Case cmb_tipo_reporte.Text
        '    Case str_reporte3
        'grp_datos.Enabled = True
        '    Case Else
        'grp_datos.Enabled = False
        'End Select

        Ctl_txt_numfact.Visible = True
        lbl_numfact.Visible = True
        lbl_fec2.Visible = True
        dtp_fec2.Visible = True
        cmb_tipo_reporte.Visible = True

        Select Case cmb_tipo_reporte.Text

            Case str_reporte2
                grp_datos.Enabled = True
                grp_datos.Visible = True
                'txt_desde.Visible = False
                'txt_hasta.Visible = False
                Ctl_txt_numfact.Visible = True
                lbl_numfact.Visible = False

                lbl_fec1.Visible = False
                lbl_fec2.Visible = False
                dtp_fec1.Visible = False
                dtp_fec2.Visible = False

            Case str_reporte3
                grp_datos.Enabled = True
                grp_datos.Visible = True
                'lbl_desde.Visible = False
                'lbl_hasta.Visible = False
                'txt_desde.Visible = False
                'txt_hasta.Visible = False
                Ctl_txt_numfact.Visible = False
                lbl_numfact.Visible = False

            Case str_reporte4 ' CAJA
                grp_datos.Enabled = True
                grp_datos.Visible = True
                'lbl_desde.Visible = True
                'lbl_hasta.Visible = True
                'txt_desde.Visible = True
                'txt_hasta.Visible = True
                Ctl_txt_numfact.Visible = False
                lbl_numfact.Visible = False
                

                lbl_fec1.Visible = True
                dtp_fec1.Visible = True
                lbl_fec2.Visible = True
                dtp_fec2.Visible = True
                'txt_desde.Enabled = False
                'txt_hasta.Enabled = False

                'Ctl_txt_numfact
            Case str_reporte5
                grp_datos.Enabled = True
                grp_datos.Visible = True
                'txt_desde.Visible = True
                'txt_hasta.Visible = False
                Ctl_txt_numfact.Visible = False
                lbl_numfact.Visible = False
                lbl_fec2.Visible = False
                dtp_fec2.Visible = True

            Case Else
                grp_datos.Enabled = False
                grp_datos.Visible = False
                'lbl_desde.Visible = False
                'lbl_hasta.Visible = False
                'txt_desde.Visible = False
                'txt_hasta.Visible = False
        End Select
    End Sub


End Class
