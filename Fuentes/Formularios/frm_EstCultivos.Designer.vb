<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EstCultivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EstCultivos))
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgrd_Test = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lst_ParamMicro = New System.Windows.Forms.ListBox
        Me.lst_ParamPerfil = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_imprimirCul = New System.Windows.Forms.Button
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(12, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(181, 18)
        Me.lbl_textform.TabIndex = 94
        Me.lbl_textform.Text = "ESTRUCTURA CULTIVO"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(13, 252)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(194, 17)
        Me.lbl_Nombre.TabIndex = 113
        Me.lbl_Nombre.Text = "PARAMETROS MICROBIOLOGIA:"
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.Location = New System.Drawing.Point(342, 40)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(73, 40)
        Me.btn_Salir.TabIndex = 112
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.Location = New System.Drawing.Point(186, 40)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(83, 40)
        Me.btn_Aceptar.TabIndex = 110
        Me.btn_Aceptar.Text = "Actualizar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_Test
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.SteelBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Khaki
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
        Me.dgrd_Test.CaptionText = "CULTIVOS"
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
        Me.dgrd_Test.Location = New System.Drawing.Point(10, 86)
        Me.dgrd_Test.Name = "dgrd_Test"
        Me.dgrd_Test.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_Test.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_Test.PreferredColumnWidth = 95
        Me.dgrd_Test.ReadOnly = True
        Me.dgrd_Test.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_Test.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_Test.Size = New System.Drawing.Size(410, 155)
        Me.dgrd_Test.TabIndex = 100
        Me.dgrd_Test.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgrd_Test.TabStop = False
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn4.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "CULTIVO"
        Me.DataGridTextBoxColumn5.MappingName = "TES_NOMBRE"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 290
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "TIM_ID"
        Me.DataGridTextBoxColumn6.MappingName = "TIM_ID"
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn3.MappingName = "TES_TIPO"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "PARAMETRO"
        Me.DataGridTextBoxColumn2.MappingName = "TES_NOMBRE"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 165
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "TES_ID"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 30
        '
        'lst_ParamMicro
        '
        Me.lst_ParamMicro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_ParamMicro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_ParamMicro.ForeColor = System.Drawing.Color.Black
        Me.lst_ParamMicro.Location = New System.Drawing.Point(10, 272)
        Me.lst_ParamMicro.Name = "lst_ParamMicro"
        Me.lst_ParamMicro.Size = New System.Drawing.Size(197, 158)
        Me.lst_ParamMicro.TabIndex = 120
        '
        'lst_ParamPerfil
        '
        Me.lst_ParamPerfil.AllowDrop = True
        Me.lst_ParamPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_ParamPerfil.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_ParamPerfil.ForeColor = System.Drawing.Color.Black
        Me.lst_ParamPerfil.Location = New System.Drawing.Point(219, 272)
        Me.lst_ParamPerfil.Name = "lst_ParamPerfil"
        Me.lst_ParamPerfil.Size = New System.Drawing.Size(203, 158)
        Me.lst_ParamPerfil.TabIndex = 121
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(218, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 17)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "PARAMETROS HABILTADOS"
        '
        'btn_imprimirCul
        '
        Me.btn_imprimirCul.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimirCul.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimirCul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimirCul.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimirCul.Image = CType(resources.GetObject("btn_imprimirCul.Image"), System.Drawing.Image)
        Me.btn_imprimirCul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimirCul.Location = New System.Drawing.Point(269, 40)
        Me.btn_imprimirCul.Name = "btn_imprimirCul"
        Me.btn_imprimirCul.Size = New System.Drawing.Size(73, 40)
        Me.btn_imprimirCul.TabIndex = 123
        Me.btn_imprimirCul.Text = "Imprimir"
        Me.btn_imprimirCul.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimirCul.UseVisualStyleBackColor = False
        '
        'frm_EstCultivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(432, 440)
        Me.Controls.Add(Me.btn_imprimirCul)
        Me.Controls.Add(Me.lst_ParamMicro)
        Me.Controls.Add(Me.lst_ParamPerfil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.dgrd_Test)
        Me.Controls.Add(Me.lbl_textform)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_EstCultivos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_EstCultivos"
        CType(Me.dgrd_Test, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgrd_Test As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lst_ParamMicro As System.Windows.Forms.ListBox
    Friend WithEvents lst_ParamPerfil As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_imprimirCul As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
End Class
