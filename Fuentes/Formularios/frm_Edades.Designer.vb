<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Edades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Edades))
        Me.cmb_generos = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Ctl_txt_RangoSup = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_RangoInf = New Ctl_txt.ctl_txt_numeros
        Me.lbl_max = New System.Windows.Forms.Label
        Me.lbl_Min = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_eliminar = New System.Windows.Forms.Button
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_abrev = New System.Windows.Forms.TextBox
        Me.dgrd_Test = New System.Windows.Forms.DataGrid
        Me.pan_barra.SuspendLayout()
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_generos
        '
        Me.cmb_generos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_generos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_generos.Items.AddRange(New Object() {"MUJER", "HOMBRE", "NIÑO", "RN"})
        Me.cmb_generos.Location = New System.Drawing.Point(74, 113)
        Me.cmb_generos.Name = "cmb_generos"
        Me.cmb_generos.Size = New System.Drawing.Size(136, 21)
        Me.cmb_generos.TabIndex = 106
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"DIAS", "AÑOS"})
        Me.ComboBox1.Location = New System.Drawing.Point(74, 141)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 107
        '
        'Ctl_txt_RangoSup
        '
        Me.Ctl_txt_RangoSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_RangoSup.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_RangoSup.Location = New System.Drawing.Point(301, 142)
        Me.Ctl_txt_RangoSup.Name = "Ctl_txt_RangoSup"
        Me.Ctl_txt_RangoSup.Prp_Formato = True
        Me.Ctl_txt_RangoSup.Prp_NumDecimales = CType(3, Short)
        Me.Ctl_txt_RangoSup.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_RangoSup.Prp_ValDefault = "0"
        Me.Ctl_txt_RangoSup.Size = New System.Drawing.Size(66, 20)
        Me.Ctl_txt_RangoSup.TabIndex = 109
        '
        'Ctl_txt_RangoInf
        '
        Me.Ctl_txt_RangoInf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_RangoInf.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_RangoInf.Location = New System.Drawing.Point(301, 116)
        Me.Ctl_txt_RangoInf.Name = "Ctl_txt_RangoInf"
        Me.Ctl_txt_RangoInf.Prp_Formato = True
        Me.Ctl_txt_RangoInf.Prp_NumDecimales = CType(3, Short)
        Me.Ctl_txt_RangoInf.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_RangoInf.Prp_ValDefault = "0"
        Me.Ctl_txt_RangoInf.Size = New System.Drawing.Size(66, 20)
        Me.Ctl_txt_RangoInf.TabIndex = 108
        '
        'lbl_max
        '
        Me.lbl_max.BackColor = System.Drawing.Color.Transparent
        Me.lbl_max.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_max.ForeColor = System.Drawing.Color.Black
        Me.lbl_max.Location = New System.Drawing.Point(243, 144)
        Me.lbl_max.Name = "lbl_max"
        Me.lbl_max.Size = New System.Drawing.Size(52, 16)
        Me.lbl_max.TabIndex = 111
        Me.lbl_max.Text = "Máximo:"
        '
        'lbl_Min
        '
        Me.lbl_Min.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Min.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Min.ForeColor = System.Drawing.Color.Black
        Me.lbl_Min.Location = New System.Drawing.Point(243, 118)
        Me.lbl_Min.Name = "lbl_Min"
        Me.lbl_Min.Size = New System.Drawing.Size(52, 16)
        Me.lbl_Min.TabIndex = 110
        Me.lbl_Min.Text = "Mínimo:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Género:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Unidad:"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(95, 33)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(81, 33)
        Me.btn_eliminar.TabIndex = 117
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.Location = New System.Drawing.Point(14, 33)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(81, 33)
        Me.btn_nuevo.TabIndex = 116
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.UseVisualStyleBackColor = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(259, 33)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(81, 33)
        Me.btn_Salir.TabIndex = 115
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(177, 33)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(81, 33)
        Me.btn_Aceptar.TabIndex = 114
        Me.btn_Aceptar.Text = "Guardar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(7, 3)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(73, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GRUPOS"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(597, 25)
        Me.pan_barra.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Grupo:"
        '
        'txt_abrev
        '
        Me.txt_abrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_abrev.Location = New System.Drawing.Point(74, 86)
        Me.txt_abrev.MaxLength = 8
        Me.txt_abrev.Name = "txt_abrev"
        Me.txt_abrev.Size = New System.Drawing.Size(136, 20)
        Me.txt_abrev.TabIndex = 120
        '
        'dgrd_Test
        '
        Me.dgrd_Test.AllowNavigation = False
        Me.dgrd_Test.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_Test.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_Test.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_Test.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_Test.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_Test.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.CaptionText = "GRUPO DE EDADES"
        Me.dgrd_Test.DataMember = ""
        Me.dgrd_Test.FlatMode = True
        Me.dgrd_Test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.ForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_Test.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_Test.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_Test.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_Test.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_Test.Location = New System.Drawing.Point(16, 174)
        Me.dgrd_Test.Name = "dgrd_Test"
        Me.dgrd_Test.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Test.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.PreferredColumnWidth = 95
        Me.dgrd_Test.ReadOnly = True
        Me.dgrd_Test.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Test.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Test.Size = New System.Drawing.Size(565, 173)
        Me.dgrd_Test.TabIndex = 121
        Me.dgrd_Test.TabStop = False
        '
        'frm_Edades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(597, 365)
        Me.Controls.Add(Me.dgrd_Test)
        Me.Controls.Add(Me.txt_abrev)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ctl_txt_RangoSup)
        Me.Controls.Add(Me.Ctl_txt_RangoInf)
        Me.Controls.Add(Me.lbl_max)
        Me.Controls.Add(Me.lbl_Min)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmb_generos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Edades"
        Me.Text = "frm_Edades"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_generos As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Ctl_txt_RangoSup As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_RangoInf As Ctl_txt.ctl_txt_numeros
    Friend WithEvents lbl_max As System.Windows.Forms.Label
    Friend WithEvents lbl_Min As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_abrev As System.Windows.Forms.TextBox
    Friend WithEvents dgrd_Test As System.Windows.Forms.DataGrid
End Class
