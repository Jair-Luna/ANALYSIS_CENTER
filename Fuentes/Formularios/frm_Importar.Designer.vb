<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Importar
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Importar))
        Me.data = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.lbl_msg = New System.Windows.Forms.Label
        Me.btn_procesa = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.lbl_100 = New System.Windows.Forms.Label
        Me.lbl_0 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lbl_fec = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.cmb_convenio = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_sec = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_printetiquetas = New System.Windows.Forms.Button
        Me.cmb_hora = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_PrePost = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_medico = New System.Windows.Forms.ComboBox
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data
        '
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Location = New System.Drawing.Point(10, 101)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(889, 394)
        Me.data.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "AREA/RANGO"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(141, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 20)
        Me.TextBox3.TabIndex = 17
        Me.TextBox3.Text = "A1:AU2000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "NOMBRE HOJA"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(140, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "UBICACION ARCHIVO"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(140, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 13
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_buscar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(307, 57)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(73, 32)
        Me.btn_buscar.TabIndex = 19
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'lbl_msg
        '
        Me.lbl_msg.AutoSize = True
        Me.lbl_msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.Location = New System.Drawing.Point(21, 510)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(0, 16)
        Me.lbl_msg.TabIndex = 20
        '
        'btn_procesa
        '
        Me.btn_procesa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_procesa.Enabled = False
        Me.btn_procesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_procesa.Image = CType(resources.GetObject("btn_procesa.Image"), System.Drawing.Image)
        Me.btn_procesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_procesa.Location = New System.Drawing.Point(802, 12)
        Me.btn_procesa.Name = "btn_procesa"
        Me.btn_procesa.Size = New System.Drawing.Size(97, 36)
        Me.btn_procesa.TabIndex = 21
        Me.btn_procesa.Text = "CARGAR"
        Me.btn_procesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_procesa.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(802, 51)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(97, 39)
        Me.btn_salir.TabIndex = 22
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'lbl_100
        '
        Me.lbl_100.AutoSize = True
        Me.lbl_100.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_100.ForeColor = System.Drawing.Color.Black
        Me.lbl_100.Location = New System.Drawing.Point(859, 532)
        Me.lbl_100.Name = "lbl_100"
        Me.lbl_100.Size = New System.Drawing.Size(36, 13)
        Me.lbl_100.TabIndex = 142
        Me.lbl_100.Text = "100%"
        '
        'lbl_0
        '
        Me.lbl_0.AutoSize = True
        Me.lbl_0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_0.ForeColor = System.Drawing.Color.Black
        Me.lbl_0.Location = New System.Drawing.Point(634, 531)
        Me.lbl_0.Name = "lbl_0"
        Me.lbl_0.Size = New System.Drawing.Size(24, 13)
        Me.lbl_0.TabIndex = 141
        Me.lbl_0.Text = "0%"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(658, 525)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(201, 20)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 140
        '
        'lbl_fec
        '
        Me.lbl_fec.AutoSize = True
        Me.lbl_fec.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec.ForeColor = System.Drawing.Color.Black
        Me.lbl_fec.Location = New System.Drawing.Point(409, 14)
        Me.lbl_fec.Name = "lbl_fec"
        Me.lbl_fec.Size = New System.Drawing.Size(42, 13)
        Me.lbl_fec.TabIndex = 144
        Me.lbl_fec.Text = "FECHA"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_fecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(455, 10)
        Me.dtp_fecha.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtp_fecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(91, 21)
        Me.dtp_fecha.TabIndex = 143
        '
        'cmb_convenio
        '
        Me.cmb_convenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_convenio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_convenio.Location = New System.Drawing.Point(454, 36)
        Me.cmb_convenio.Name = "cmb_convenio"
        Me.cmb_convenio.Size = New System.Drawing.Size(171, 22)
        Me.cmb_convenio.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(390, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "CONVENIO"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sec.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_sec.Location = New System.Drawing.Point(138, 83)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(85, 13)
        Me.lbl_sec.TabIndex = 149
        Me.lbl_sec.Text = "SECUENCIAS"
        '
        'btn_printetiquetas
        '
        Me.btn_printetiquetas.BackColor = System.Drawing.SystemColors.Control
        Me.btn_printetiquetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_printetiquetas.Enabled = False
        Me.btn_printetiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_printetiquetas.ForeColor = System.Drawing.Color.Black
        Me.btn_printetiquetas.Image = CType(resources.GetObject("btn_printetiquetas.Image"), System.Drawing.Image)
        Me.btn_printetiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_printetiquetas.Location = New System.Drawing.Point(12, 510)
        Me.btn_printetiquetas.Name = "btn_printetiquetas"
        Me.btn_printetiquetas.Size = New System.Drawing.Size(97, 35)
        Me.btn_printetiquetas.TabIndex = 150
        Me.btn_printetiquetas.Text = "Etiquetas"
        Me.btn_printetiquetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_printetiquetas.UseVisualStyleBackColor = False
        Me.btn_printetiquetas.Visible = False
        '
        'cmb_hora
        '
        Me.cmb_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_hora.FormattingEnabled = True
        Me.cmb_hora.Items.AddRange(New Object() {"05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"})
        Me.cmb_hora.Location = New System.Drawing.Point(549, 10)
        Me.cmb_hora.Name = "cmb_hora"
        Me.cmb_hora.Size = New System.Drawing.Size(76, 21)
        Me.cmb_hora.TabIndex = 151
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(631, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "PRE/POST"
        '
        'cmb_PrePost
        '
        Me.cmb_PrePost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PrePost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PrePost.Items.AddRange(New Object() {"NO APLICA", "PRE/POST", "PRE", "POST"})
        Me.cmb_PrePost.Location = New System.Drawing.Point(697, 10)
        Me.cmb_PrePost.Name = "cmb_PrePost"
        Me.cmb_PrePost.Size = New System.Drawing.Size(92, 21)
        Me.cmb_PrePost.TabIndex = 152
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(401, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "MEDICO"
        '
        'cmb_medico
        '
        Me.cmb_medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_medico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_medico.ItemHeight = 13
        Me.cmb_medico.Location = New System.Drawing.Point(455, 63)
        Me.cmb_medico.Name = "cmb_medico"
        Me.cmb_medico.Size = New System.Drawing.Size(170, 21)
        Me.cmb_medico.TabIndex = 155
        '
        'frm_Importar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(913, 561)
        Me.Controls.Add(Me.cmb_medico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_PrePost)
        Me.Controls.Add(Me.cmb_hora)
        Me.Controls.Add(Me.btn_printetiquetas)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_fec)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.cmb_convenio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_100)
        Me.Controls.Add(Me.lbl_0)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_procesa)
        Me.Controls.Add(Me.lbl_msg)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Importar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Importar"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents btn_procesa As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_100 As System.Windows.Forms.Label
    Friend WithEvents lbl_0 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_fec As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_convenio As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_sec As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_printetiquetas As System.Windows.Forms.Button
    Friend WithEvents cmb_hora As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_PrePost As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_medico As System.Windows.Forms.ComboBox
End Class
