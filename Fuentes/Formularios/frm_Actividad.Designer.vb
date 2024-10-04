<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Actividad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.btn_SalirAct = New System.Windows.Forms.Button
        Me.cmb_Actividad = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Recursividad = New System.Windows.Forms.ComboBox
        Me.btn_AceptaAct = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_IniciaActividad = New System.Windows.Forms.MonthCalendar
        Me.dgv_Actividad = New System.Windows.Forms.DataGridView
        Me.btn_EliminaAct = New System.Windows.Forms.Button
        Me.lbl_Medico = New System.Windows.Forms.Label
        Me.lbl_FechaSeleccionada = New System.Windows.Forms.Label
        Me.cmb_Hora = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbt_Hora = New System.Windows.Forms.RadioButton
        Me.rbt_Dia = New System.Windows.Forms.RadioButton
        Me.rbt_Mes = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_HoraFin = New System.Windows.Forms.ComboBox
        Me.cmb_Motivo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_Mes = New System.Windows.Forms.ComboBox
        Me.pan_barra.SuspendLayout()
        CType(Me.dgv_Actividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(8, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(269, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "AGENDAR / RESERVAR ACTIVIDAD"
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(450, 25)
        Me.pan_barra.TabIndex = 223
        '
        'btn_SalirAct
        '
        Me.btn_SalirAct.BackColor = System.Drawing.Color.White
        Me.btn_SalirAct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SalirAct.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SalirAct.Location = New System.Drawing.Point(351, 35)
        Me.btn_SalirAct.Name = "btn_SalirAct"
        Me.btn_SalirAct.Size = New System.Drawing.Size(83, 40)
        Me.btn_SalirAct.TabIndex = 222
        Me.btn_SalirAct.Text = "SALIR"
        Me.btn_SalirAct.UseVisualStyleBackColor = False
        '
        'cmb_Actividad
        '
        Me.cmb_Actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Actividad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Actividad.Location = New System.Drawing.Point(237, 141)
        Me.cmb_Actividad.Name = "cmb_Actividad"
        Me.cmb_Actividad.Size = New System.Drawing.Size(154, 21)
        Me.cmb_Actividad.TabIndex = 226
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(234, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "ESTADO"
        '
        'cmb_Recursividad
        '
        Me.cmb_Recursividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Recursividad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Recursividad.Items.AddRange(New Object() {"Mensual", "Diario", "Hora"})
        Me.cmb_Recursividad.Location = New System.Drawing.Point(237, 101)
        Me.cmb_Recursividad.Name = "cmb_Recursividad"
        Me.cmb_Recursividad.Size = New System.Drawing.Size(154, 21)
        Me.cmb_Recursividad.TabIndex = 229
        '
        'btn_AceptaAct
        '
        Me.btn_AceptaAct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_AceptaAct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AceptaAct.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AceptaAct.Location = New System.Drawing.Point(227, 254)
        Me.btn_AceptaAct.Name = "btn_AceptaAct"
        Me.btn_AceptaAct.Size = New System.Drawing.Size(83, 30)
        Me.btn_AceptaAct.TabIndex = 230
        Me.btn_AceptaAct.Text = "ACEPTAR"
        Me.btn_AceptaAct.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(234, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 231
        Me.Label3.Text = "PERIODO"
        '
        'dtp_IniciaActividad
        '
        Me.dtp_IniciaActividad.Location = New System.Drawing.Point(12, 103)
        Me.dtp_IniciaActividad.Name = "dtp_IniciaActividad"
        Me.dtp_IniciaActividad.TabIndex = 232
        '
        'dgv_Actividad
        '
        Me.dgv_Actividad.AllowUserToAddRows = False
        Me.dgv_Actividad.AllowUserToDeleteRows = False
        Me.dgv_Actividad.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgv_Actividad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Actividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Actividad.Location = New System.Drawing.Point(11, 320)
        Me.dgv_Actividad.Name = "dgv_Actividad"
        Me.dgv_Actividad.ReadOnly = True
        Me.dgv_Actividad.RowHeadersVisible = False
        Me.dgv_Actividad.Size = New System.Drawing.Size(423, 199)
        Me.dgv_Actividad.TabIndex = 233
        '
        'btn_EliminaAct
        '
        Me.btn_EliminaAct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_EliminaAct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_EliminaAct.Enabled = False
        Me.btn_EliminaAct.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EliminaAct.Location = New System.Drawing.Point(316, 254)
        Me.btn_EliminaAct.Name = "btn_EliminaAct"
        Me.btn_EliminaAct.Size = New System.Drawing.Size(83, 30)
        Me.btn_EliminaAct.TabIndex = 234
        Me.btn_EliminaAct.Text = "ELIMINAR"
        Me.btn_EliminaAct.UseVisualStyleBackColor = False
        '
        'lbl_Medico
        '
        Me.lbl_Medico.AutoSize = True
        Me.lbl_Medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Medico.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_Medico.Location = New System.Drawing.Point(7, 40)
        Me.lbl_Medico.Name = "lbl_Medico"
        Me.lbl_Medico.Size = New System.Drawing.Size(104, 24)
        Me.lbl_Medico.TabIndex = 242
        Me.lbl_Medico.Text = "(MEDICO)"
        '
        'lbl_FechaSeleccionada
        '
        Me.lbl_FechaSeleccionada.AutoSize = True
        Me.lbl_FechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaSeleccionada.ForeColor = System.Drawing.Color.White
        Me.lbl_FechaSeleccionada.Location = New System.Drawing.Point(6, 64)
        Me.lbl_FechaSeleccionada.Name = "lbl_FechaSeleccionada"
        Me.lbl_FechaSeleccionada.Size = New System.Drawing.Size(94, 24)
        Me.lbl_FechaSeleccionada.TabIndex = 246
        Me.lbl_FechaSeleccionada.Text = "(FECHA)"
        '
        'cmb_Hora
        '
        Me.cmb_Hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Hora.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Hora.Location = New System.Drawing.Point(237, 221)
        Me.cmb_Hora.Name = "cmb_Hora"
        Me.cmb_Hora.Size = New System.Drawing.Size(69, 21)
        Me.cmb_Hora.TabIndex = 248
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 250
        Me.Label2.Text = "VER:"
        '
        'rbt_Hora
        '
        Me.rbt_Hora.AutoSize = True
        Me.rbt_Hora.Location = New System.Drawing.Point(186, 297)
        Me.rbt_Hora.Name = "rbt_Hora"
        Me.rbt_Hora.Size = New System.Drawing.Size(56, 17)
        Me.rbt_Hora.TabIndex = 251
        Me.rbt_Hora.Text = "HORA"
        Me.rbt_Hora.UseVisualStyleBackColor = True
        '
        'rbt_Dia
        '
        Me.rbt_Dia.AutoSize = True
        Me.rbt_Dia.Location = New System.Drawing.Point(136, 297)
        Me.rbt_Dia.Name = "rbt_Dia"
        Me.rbt_Dia.Size = New System.Drawing.Size(43, 17)
        Me.rbt_Dia.TabIndex = 252
        Me.rbt_Dia.Text = "DIA"
        Me.rbt_Dia.UseVisualStyleBackColor = True
        '
        'rbt_Mes
        '
        Me.rbt_Mes.AutoSize = True
        Me.rbt_Mes.Checked = True
        Me.rbt_Mes.Location = New System.Drawing.Point(79, 297)
        Me.rbt_Mes.Name = "rbt_Mes"
        Me.rbt_Mes.Size = New System.Drawing.Size(48, 17)
        Me.rbt_Mes.TabIndex = 254
        Me.rbt_Mes.TabStop = True
        Me.rbt_Mes.Text = "MES"
        Me.rbt_Mes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(234, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 255
        Me.Label5.Text = "INICIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(323, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 256
        Me.Label6.Text = "FIN"
        '
        'cmb_HoraFin
        '
        Me.cmb_HoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HoraFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_HoraFin.Location = New System.Drawing.Point(322, 221)
        Me.cmb_HoraFin.Name = "cmb_HoraFin"
        Me.cmb_HoraFin.Size = New System.Drawing.Size(69, 21)
        Me.cmb_HoraFin.TabIndex = 257
        '
        'cmb_Motivo
        '
        Me.cmb_Motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Motivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Motivo.Items.AddRange(New Object() {"CAPACITACION", "MANTENIMIENTO", "REUNION", "VACACIONES", "NO APLICA"})
        Me.cmb_Motivo.Location = New System.Drawing.Point(237, 181)
        Me.cmb_Motivo.Name = "cmb_Motivo"
        Me.cmb_Motivo.Size = New System.Drawing.Size(154, 21)
        Me.cmb_Motivo.TabIndex = 258
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(237, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 259
        Me.Label7.Text = "MOTIVO"
        '
        'cmb_Mes
        '
        Me.cmb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Mes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Mes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmb_Mes.Location = New System.Drawing.Point(237, 221)
        Me.cmb_Mes.Name = "cmb_Mes"
        Me.cmb_Mes.Size = New System.Drawing.Size(110, 21)
        Me.cmb_Mes.TabIndex = 260
        '
        'frm_Actividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(450, 531)
        Me.Controls.Add(Me.cmb_Mes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_Motivo)
        Me.Controls.Add(Me.cmb_HoraFin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbt_Mes)
        Me.Controls.Add(Me.rbt_Dia)
        Me.Controls.Add(Me.rbt_Hora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_Hora)
        Me.Controls.Add(Me.lbl_FechaSeleccionada)
        Me.Controls.Add(Me.lbl_Medico)
        Me.Controls.Add(Me.btn_EliminaAct)
        Me.Controls.Add(Me.dgv_Actividad)
        Me.Controls.Add(Me.dtp_IniciaActividad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_AceptaAct)
        Me.Controls.Add(Me.cmb_Recursividad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Actividad)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_SalirAct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Actividad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_Actividad"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgv_Actividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents btn_SalirAct As System.Windows.Forms.Button
    Friend WithEvents cmb_Actividad As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Recursividad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_AceptaAct As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_IniciaActividad As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgv_Actividad As System.Windows.Forms.DataGridView
    Friend WithEvents btn_EliminaAct As System.Windows.Forms.Button
    Friend WithEvents lbl_Medico As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents cmb_Hora As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbt_Hora As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Dia As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Mes As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_HoraFin As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Mes As System.Windows.Forms.ComboBox
End Class
