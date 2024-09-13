<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BuscaHistorico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BuscaHistorico))
        Me.dgrd_pedidos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgrd_examenes = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_cargar = New System.Windows.Forms.Button
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_examenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrd_pedidos
        '
        Me.dgrd_pedidos.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_pedidos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_pedidos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_pedidos.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_pedidos.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.CaptionText = "ORDENES"
        Me.dgrd_pedidos.DataMember = ""
        Me.dgrd_pedidos.FlatMode = True
        Me.dgrd_pedidos.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_pedidos.ForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_pedidos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_pedidos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_pedidos.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_pedidos.Location = New System.Drawing.Point(12, 71)
        Me.dgrd_pedidos.Name = "dgrd_pedidos"
        Me.dgrd_pedidos.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_pedidos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_pedidos.ReadOnly = True
        Me.dgrd_pedidos.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_pedidos.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_pedidos.Size = New System.Drawing.Size(249, 150)
        Me.dgrd_pedidos.TabIndex = 2
        Me.dgrd_pedidos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_pedidos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ORDEN"
        Me.DataGridTextBoxColumn1.MappingName = "ped_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "FECHA"
        Me.DataGridTextBoxColumn2.MappingName = "ped_fecing"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 70
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CONVENIO"
        Me.DataGridTextBoxColumn3.MappingName = "ped_tipo"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "TURNO"
        Me.DataGridTextBoxColumn4.MappingName = "ped_turno"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 50
        '
        'dgrd_examenes
        '
        Me.dgrd_examenes.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_examenes.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_examenes.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_examenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_examenes.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_examenes.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_examenes.CaptionText = "EXAMENES"
        Me.dgrd_examenes.DataMember = ""
        Me.dgrd_examenes.FlatMode = True
        Me.dgrd_examenes.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_examenes.ForeColor = System.Drawing.Color.Black
        Me.dgrd_examenes.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_examenes.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_examenes.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_examenes.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_examenes.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_examenes.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_examenes.Location = New System.Drawing.Point(267, 71)
        Me.dgrd_examenes.Name = "dgrd_examenes"
        Me.dgrd_examenes.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_examenes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_examenes.ReadOnly = True
        Me.dgrd_examenes.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_examenes.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_examenes.Size = New System.Drawing.Size(424, 289)
        Me.dgrd_examenes.TabIndex = 3
        Me.dgrd_examenes.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgrd_examenes
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "RegistrosExa"
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "AREA"
        Me.DataGridTextBoxColumn5.MappingName = "are_nombre"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn6.MappingName = "tes_id"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "EXAMEN"
        Me.DataGridTextBoxColumn7.MappingName = "tes_nombre"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 190
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(611, 29)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 40)
        Me.btn_cancelar.TabIndex = 154
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_cargar
        '
        Me.btn_cargar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cargar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cargar.ForeColor = System.Drawing.Color.Black
        Me.btn_cargar.Image = CType(resources.GetObject("btn_cargar.Image"), System.Drawing.Image)
        Me.btn_cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cargar.Location = New System.Drawing.Point(530, 29)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(80, 40)
        Me.btn_cargar.TabIndex = 155
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar.UseVisualStyleBackColor = False
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.Location = New System.Drawing.Point(12, 29)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(73, 15)
        Me.lbl_paciente.TabIndex = 156
        Me.lbl_paciente.Text = "PACIENTE"
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(703, 25)
        Me.pan_barra.TabIndex = 157
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(4, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(207, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "HISTORIAL DEL PACIENTE"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "RESULTADO"
        Me.DataGridTextBoxColumn8.MappingName = "PRC_RESFINAL"
        Me.DataGridTextBoxColumn8.NullText = "N/D"
        '
        'frm_BuscaHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(703, 375)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dgrd_examenes)
        Me.Controls.Add(Me.dgrd_pedidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_BuscaHistorico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_BuscaHistorico"
        CType(Me.dgrd_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_examenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgrd_pedidos As System.Windows.Forms.DataGrid
    Friend WithEvents dgrd_examenes As System.Windows.Forms.DataGrid
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
End Class
