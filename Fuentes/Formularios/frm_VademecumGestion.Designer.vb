<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VademecumGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VademecumGestion))
        Me.Dgrd_Vademecum = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.VAD_ID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.VAD_TIPO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PRES_DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.VAD_CANTIDAD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.VAD_MEDGENERICO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.VAD_MEDCOMERCIAL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.VAD_INDICACIONES = New System.Windows.Forms.DataGridTextBoxColumn
        Me.VAD_EXTRAS = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.txt_NomGenerico = New System.Windows.Forms.TextBox
        Me.cmb_Edad = New System.Windows.Forms.ComboBox
        Me.cmb_Presentacion = New System.Windows.Forms.ComboBox
        Me.txt_NomComercial = New System.Windows.Forms.TextBox
        Me.txt_indicaciones = New System.Windows.Forms.TextBox
        Me.txt_Extras = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Cantidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_BuscaVadem = New System.Windows.Forms.TextBox
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_AddVadem = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PRES_ID = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.Dgrd_Vademecum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgrd_Vademecum
        '
        Me.Dgrd_Vademecum.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.Dgrd_Vademecum.BackColor = System.Drawing.Color.Gainsboro
        Me.Dgrd_Vademecum.BackgroundColor = System.Drawing.Color.Silver
        Me.Dgrd_Vademecum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Dgrd_Vademecum.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Dgrd_Vademecum.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Vademecum.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Vademecum.CaptionText = "VADEMECUM"
        Me.Dgrd_Vademecum.DataMember = ""
        Me.Dgrd_Vademecum.FlatMode = True
        Me.Dgrd_Vademecum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Vademecum.ForeColor = System.Drawing.Color.Black
        Me.Dgrd_Vademecum.GridLineColor = System.Drawing.Color.DimGray
        Me.Dgrd_Vademecum.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Dgrd_Vademecum.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Vademecum.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgrd_Vademecum.HeaderForeColor = System.Drawing.Color.White
        Me.Dgrd_Vademecum.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Dgrd_Vademecum.Location = New System.Drawing.Point(11, 96)
        Me.Dgrd_Vademecum.Name = "Dgrd_Vademecum"
        Me.Dgrd_Vademecum.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.Dgrd_Vademecum.ParentRowsForeColor = System.Drawing.Color.Black
        Me.Dgrd_Vademecum.ParentRowsVisible = False
        Me.Dgrd_Vademecum.PreferredColumnWidth = 100
        Me.Dgrd_Vademecum.ReadOnly = True
        Me.Dgrd_Vademecum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dgrd_Vademecum.RowHeaderWidth = 0
        Me.Dgrd_Vademecum.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Dgrd_Vademecum.SelectionForeColor = System.Drawing.Color.White
        Me.Dgrd_Vademecum.Size = New System.Drawing.Size(749, 187)
        Me.Dgrd_Vademecum.TabIndex = 188
        Me.Dgrd_Vademecum.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dgrd_Vademecum.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dgrd_Vademecum
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.VAD_ID, Me.VAD_TIPO, Me.PRES_DESCRIPCION, Me.PRES_ID, Me.VAD_CANTIDAD, Me.VAD_MEDGENERICO, Me.VAD_MEDCOMERCIAL, Me.VAD_INDICACIONES, Me.VAD_EXTRAS})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        '
        'VAD_ID
        '
        Me.VAD_ID.Format = ""
        Me.VAD_ID.FormatInfo = Nothing
        Me.VAD_ID.HeaderText = "ID"
        Me.VAD_ID.MappingName = "VAD_ID"
        Me.VAD_ID.NullText = ""
        Me.VAD_ID.Width = 0
        '
        'VAD_TIPO
        '
        Me.VAD_TIPO.Format = ""
        Me.VAD_TIPO.FormatInfo = Nothing
        Me.VAD_TIPO.HeaderText = "EDAD"
        Me.VAD_TIPO.MappingName = "VAD_TIPO"
        Me.VAD_TIPO.Width = 0
        '
        'PRES_DESCRIPCION
        '
        Me.PRES_DESCRIPCION.Format = ""
        Me.PRES_DESCRIPCION.FormatInfo = Nothing
        Me.PRES_DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.PRES_DESCRIPCION.MappingName = "PRES_DESCRIPCION"
        Me.PRES_DESCRIPCION.Width = 200
        '
        'VAD_CANTIDAD
        '
        Me.VAD_CANTIDAD.Format = ""
        Me.VAD_CANTIDAD.FormatInfo = Nothing
        Me.VAD_CANTIDAD.HeaderText = "CANTIDAD"
        Me.VAD_CANTIDAD.MappingName = "VAD_CANTIDAD"
        Me.VAD_CANTIDAD.Width = 0
        '
        'VAD_MEDGENERICO
        '
        Me.VAD_MEDGENERICO.Format = ""
        Me.VAD_MEDGENERICO.FormatInfo = Nothing
        Me.VAD_MEDGENERICO.HeaderText = "NOMBRE GENERICO"
        Me.VAD_MEDGENERICO.MappingName = "VAD_MEDGENERICO"
        Me.VAD_MEDGENERICO.Width = 250
        '
        'VAD_MEDCOMERCIAL
        '
        Me.VAD_MEDCOMERCIAL.Format = ""
        Me.VAD_MEDCOMERCIAL.FormatInfo = Nothing
        Me.VAD_MEDCOMERCIAL.HeaderText = "NOMBRE COMERCIAL"
        Me.VAD_MEDCOMERCIAL.MappingName = "VAD_MEDCOMERCIAL"
        Me.VAD_MEDCOMERCIAL.Width = 200
        '
        'VAD_INDICACIONES
        '
        Me.VAD_INDICACIONES.Format = ""
        Me.VAD_INDICACIONES.FormatInfo = Nothing
        Me.VAD_INDICACIONES.HeaderText = "INDICACIONES"
        Me.VAD_INDICACIONES.MappingName = "VAD_INDICACIONES"
        Me.VAD_INDICACIONES.NullText = ""
        Me.VAD_INDICACIONES.Width = 0
        '
        'VAD_EXTRAS
        '
        Me.VAD_EXTRAS.Format = ""
        Me.VAD_EXTRAS.FormatInfo = Nothing
        Me.VAD_EXTRAS.HeaderText = "EXTRAS"
        Me.VAD_EXTRAS.MappingName = "VAD_EXTRAS"
        Me.VAD_EXTRAS.NullText = "N/A"
        Me.VAD_EXTRAS.Width = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 25)
        Me.Panel1.TabIndex = 193
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "GESTION DE VADEMECUM "
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Salir.Location = New System.Drawing.Point(669, 47)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(92, 38)
        Me.btn_Salir.TabIndex = 192
        Me.btn_Salir.Text = "Cerrar"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'txt_NomGenerico
        '
        Me.txt_NomGenerico.Location = New System.Drawing.Point(114, 45)
        Me.txt_NomGenerico.Name = "txt_NomGenerico"
        Me.txt_NomGenerico.Size = New System.Drawing.Size(300, 20)
        Me.txt_NomGenerico.TabIndex = 5
        '
        'cmb_Edad
        '
        Me.cmb_Edad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Edad.FormattingEnabled = True
        Me.cmb_Edad.Items.AddRange(New Object() {"ADULTO", "NIÑOS"})
        Me.cmb_Edad.Location = New System.Drawing.Point(338, 19)
        Me.cmb_Edad.Name = "cmb_Edad"
        Me.cmb_Edad.Size = New System.Drawing.Size(76, 21)
        Me.cmb_Edad.TabIndex = 3
        '
        'cmb_Presentacion
        '
        Me.cmb_Presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Presentacion.FormattingEnabled = True
        Me.cmb_Presentacion.Location = New System.Drawing.Point(114, 19)
        Me.cmb_Presentacion.Name = "cmb_Presentacion"
        Me.cmb_Presentacion.Size = New System.Drawing.Size(152, 21)
        Me.cmb_Presentacion.TabIndex = 2
        '
        'txt_NomComercial
        '
        Me.txt_NomComercial.Location = New System.Drawing.Point(114, 71)
        Me.txt_NomComercial.Name = "txt_NomComercial"
        Me.txt_NomComercial.Size = New System.Drawing.Size(300, 20)
        Me.txt_NomComercial.TabIndex = 6
        '
        'txt_indicaciones
        '
        Me.txt_indicaciones.Location = New System.Drawing.Point(114, 97)
        Me.txt_indicaciones.Multiline = True
        Me.txt_indicaciones.Name = "txt_indicaciones"
        Me.txt_indicaciones.Size = New System.Drawing.Size(566, 42)
        Me.txt_indicaciones.TabIndex = 7
        '
        'txt_Extras
        '
        Me.txt_Extras.Location = New System.Drawing.Point(114, 145)
        Me.txt_Extras.Multiline = True
        Me.txt_Extras.Name = "txt_Extras"
        Me.txt_Extras.Size = New System.Drawing.Size(566, 42)
        Me.txt_Extras.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Presentación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "Nombre Genérico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 202
        Me.Label4.Text = "Nombre Comercial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Edad"
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Location = New System.Drawing.Point(479, 20)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(40, 20)
        Me.txt_Cantidad.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 205
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Indicaciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Extras"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Guardar.Location = New System.Drawing.Point(651, 10)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(92, 30)
        Me.btn_Guardar.TabIndex = 9
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 210
        Me.Label9.Text = "BUSCAR"
        '
        'txt_BuscaVadem
        '
        Me.txt_BuscaVadem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BuscaVadem.Location = New System.Drawing.Point(69, 55)
        Me.txt_BuscaVadem.Name = "txt_BuscaVadem"
        Me.txt_BuscaVadem.Size = New System.Drawing.Size(327, 22)
        Me.txt_BuscaVadem.TabIndex = 209
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(268, 18)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(23, 23)
        Me.btn_nuevo.TabIndex = 211
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Editar.Enabled = False
        Me.btn_Editar.Location = New System.Drawing.Point(578, 47)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(92, 38)
        Me.btn_Editar.TabIndex = 212
        Me.btn_Editar.Text = "Editar"
        Me.btn_Editar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_Eliminar.Location = New System.Drawing.Point(559, 10)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(92, 30)
        Me.btn_Eliminar.TabIndex = 213
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_AddVadem
        '
        Me.btn_AddVadem.BackColor = System.Drawing.SystemColors.Control
        Me.btn_AddVadem.Location = New System.Drawing.Point(490, 47)
        Me.btn_AddVadem.Name = "btn_AddVadem"
        Me.btn_AddVadem.Size = New System.Drawing.Size(92, 38)
        Me.btn_AddVadem.TabIndex = 214
        Me.btn_AddVadem.Text = "Añadir"
        Me.btn_AddVadem.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_NomGenerico)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.cmb_Edad)
        Me.GroupBox1.Controls.Add(Me.cmb_Presentacion)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.txt_NomComercial)
        Me.GroupBox1.Controls.Add(Me.btn_Guardar)
        Me.GroupBox1.Controls.Add(Me.txt_indicaciones)
        Me.GroupBox1.Controls.Add(Me.txt_Extras)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(11, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 217)
        Me.GroupBox1.TabIndex = 215
        Me.GroupBox1.TabStop = False
        '
        'PRES_ID
        '
        Me.PRES_ID.Format = ""
        Me.PRES_ID.FormatInfo = Nothing
        Me.PRES_ID.MappingName = "PRES_ID"
        Me.PRES_ID.NullText = ""
        Me.PRES_ID.Width = 0
        '
        'frm_VademecumGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(773, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_AddVadem)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_BuscaVadem)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Dgrd_Vademecum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_VademecumGestion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_VademecumGestion"
        CType(Me.Dgrd_Vademecum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgrd_Vademecum As System.Windows.Forms.DataGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents txt_NomGenerico As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Edad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Presentacion As System.Windows.Forms.ComboBox
    Friend WithEvents txt_NomComercial As System.Windows.Forms.TextBox
    Friend WithEvents txt_indicaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_Extras As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_BuscaVadem As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents VAD_ID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VAD_TIPO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PRES_DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VAD_CANTIDAD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VAD_MEDGENERICO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VAD_MEDCOMERCIAL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VAD_INDICACIONES As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VAD_EXTRAS As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_AddVadem As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PRES_ID As System.Windows.Forms.DataGridTextBoxColumn
End Class
