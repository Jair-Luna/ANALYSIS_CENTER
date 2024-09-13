<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Interpretacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Interpretacion))
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btnRecuperaInt = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Imp2 = New System.Windows.Forms.Button
        Me.btn_Imp1 = New System.Windows.Forms.Button
        Me.txt_InterpRecom2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_InterpRecom = New System.Windows.Forms.TextBox
        Me.txt_InterpInhalantes = New System.Windows.Forms.TextBox
        Me.lbl_FechaInter = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbl_paciente = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Sustancias = New System.Windows.Forms.TextBox
        Me.txt_InterpAlimentos = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_InterpMedicAB = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_InterpMedicOTROS = New System.Windows.Forms.TextBox
        Me.txt_InterpMedicAINES = New System.Windows.Forms.TextBox
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.pan_barra.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(990, 25)
        Me.pan_barra.TabIndex = 224
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
        Me.lbl_textform.Size = New System.Drawing.Size(306, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "INTERPRETACION PRUEBAS CUTANEAS"
        '
        'btnRecuperaInt
        '
        Me.btnRecuperaInt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRecuperaInt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecuperaInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperaInt.ForeColor = System.Drawing.Color.Black
        Me.btnRecuperaInt.Image = CType(resources.GetObject("btnRecuperaInt.Image"), System.Drawing.Image)
        Me.btnRecuperaInt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecuperaInt.Location = New System.Drawing.Point(873, 119)
        Me.btnRecuperaInt.Name = "btnRecuperaInt"
        Me.btnRecuperaInt.Size = New System.Drawing.Size(79, 31)
        Me.btnRecuperaInt.TabIndex = 247
        Me.btnRecuperaInt.Text = "Recuperar"
        Me.btnRecuperaInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecuperaInt.UseVisualStyleBackColor = False
        Me.btnRecuperaInt.Visible = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(888, 49)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(90, 40)
        Me.btn_Salir.TabIndex = 244
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.btn_Guardar.Image = CType(resources.GetObject("btn_Guardar.Image"), System.Drawing.Image)
        Me.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.Location = New System.Drawing.Point(643, 36)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(69, 26)
        Me.btn_Guardar.TabIndex = 243
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Guardar.UseVisualStyleBackColor = False
        Me.btn_Guardar.Visible = False
        '
        'btn_Imp2
        '
        Me.btn_Imp2.BackColor = System.Drawing.Color.White
        Me.btn_Imp2.Image = CType(resources.GetObject("btn_Imp2.Image"), System.Drawing.Image)
        Me.btn_Imp2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imp2.Location = New System.Drawing.Point(649, 49)
        Me.btn_Imp2.Name = "btn_Imp2"
        Me.btn_Imp2.Size = New System.Drawing.Size(120, 40)
        Me.btn_Imp2.TabIndex = 263
        Me.btn_Imp2.Text = "MEDICAMENTOS"
        Me.btn_Imp2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Imp2.UseVisualStyleBackColor = False
        '
        'btn_Imp1
        '
        Me.btn_Imp1.BackColor = System.Drawing.Color.White
        Me.btn_Imp1.Image = CType(resources.GetObject("btn_Imp1.Image"), System.Drawing.Image)
        Me.btn_Imp1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imp1.Location = New System.Drawing.Point(768, 49)
        Me.btn_Imp1.Name = "btn_Imp1"
        Me.btn_Imp1.Size = New System.Drawing.Size(120, 40)
        Me.btn_Imp1.TabIndex = 262
        Me.btn_Imp1.Text = "ALIMENTOS"
        Me.btn_Imp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Imp1.UseVisualStyleBackColor = False
        '
        'txt_InterpRecom2
        '
        Me.txt_InterpRecom2.BackColor = System.Drawing.Color.White
        Me.txt_InterpRecom2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_InterpRecom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InterpRecom2.Location = New System.Drawing.Point(487, 6)
        Me.txt_InterpRecom2.Multiline = True
        Me.txt_InterpRecom2.Name = "txt_InterpRecom2"
        Me.txt_InterpRecom2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_InterpRecom2.Size = New System.Drawing.Size(470, 445)
        Me.txt_InterpRecom2.TabIndex = 260
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(371, 20)
        Me.Label7.TabIndex = 255
        Me.Label7.Text = "INFORME DE PRUEBAS DE SENSIBILIDAD"
        '
        'txt_InterpRecom
        '
        Me.txt_InterpRecom.BackColor = System.Drawing.Color.White
        Me.txt_InterpRecom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_InterpRecom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InterpRecom.Location = New System.Drawing.Point(6, 6)
        Me.txt_InterpRecom.Multiline = True
        Me.txt_InterpRecom.Name = "txt_InterpRecom"
        Me.txt_InterpRecom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_InterpRecom.Size = New System.Drawing.Size(470, 445)
        Me.txt_InterpRecom.TabIndex = 253
        '
        'txt_InterpInhalantes
        '
        Me.txt_InterpInhalantes.BackColor = System.Drawing.Color.White
        Me.txt_InterpInhalantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_InterpInhalantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InterpInhalantes.Location = New System.Drawing.Point(6, 40)
        Me.txt_InterpInhalantes.Multiline = True
        Me.txt_InterpInhalantes.Name = "txt_InterpInhalantes"
        Me.txt_InterpInhalantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_InterpInhalantes.Size = New System.Drawing.Size(315, 430)
        Me.txt_InterpInhalantes.TabIndex = 231
        '
        'lbl_FechaInter
        '
        Me.lbl_FechaInter.AutoSize = True
        Me.lbl_FechaInter.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FechaInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaInter.Location = New System.Drawing.Point(399, 42)
        Me.lbl_FechaInter.Name = "lbl_FechaInter"
        Me.lbl_FechaInter.Size = New System.Drawing.Size(187, 16)
        Me.lbl_FechaInter.TabIndex = 239
        Me.lbl_FechaInter.Text = "(FECHA_INTERPRETACION)"
        Me.lbl_FechaInter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 16)
        Me.Label14.TabIndex = 242
        Me.Label14.Text = "REALIZADOS A:"
        '
        'lbl_paciente
        '
        Me.lbl_paciente.AutoSize = True
        Me.lbl_paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_paciente.ForeColor = System.Drawing.Color.Black
        Me.lbl_paciente.Location = New System.Drawing.Point(141, 62)
        Me.lbl_paciente.Name = "lbl_paciente"
        Me.lbl_paciente.Size = New System.Drawing.Size(83, 16)
        Me.lbl_paciente.TabIndex = 241
        Me.lbl_paciente.Text = "(PACIENTE)"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(11, 93)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(970, 501)
        Me.TabControl1.TabIndex = 247
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_Sustancias)
        Me.TabPage1.Controls.Add(Me.txt_InterpAlimentos)
        Me.TabPage1.Controls.Add(Me.txt_InterpInhalantes)
        Me.TabPage1.Controls.Add(Me.btnRecuperaInt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(962, 475)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "     ALMENTOS - INHALANTES - OTRAS     "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 15)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "En las pruebas de sensibilidad de alergia se encuentran los siguientes resultados" & _
            ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(653, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 269
        Me.Label4.Text = "OTRAS SUSTANCIAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "ALIMENTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 267
        Me.Label2.Text = "INHALANTES"
        '
        'txt_Sustancias
        '
        Me.txt_Sustancias.BackColor = System.Drawing.Color.White
        Me.txt_Sustancias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Sustancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Sustancias.Location = New System.Drawing.Point(651, 39)
        Me.txt_Sustancias.Multiline = True
        Me.txt_Sustancias.Name = "txt_Sustancias"
        Me.txt_Sustancias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Sustancias.Size = New System.Drawing.Size(315, 430)
        Me.txt_Sustancias.TabIndex = 265
        '
        'txt_InterpAlimentos
        '
        Me.txt_InterpAlimentos.BackColor = System.Drawing.Color.White
        Me.txt_InterpAlimentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_InterpAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InterpAlimentos.Location = New System.Drawing.Point(328, 39)
        Me.txt_InterpAlimentos.Multiline = True
        Me.txt_InterpAlimentos.Name = "txt_InterpAlimentos"
        Me.txt_InterpAlimentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_InterpAlimentos.Size = New System.Drawing.Size(315, 430)
        Me.txt_InterpAlimentos.TabIndex = 246
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_InterpMedicAB)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_InterpMedicOTROS)
        Me.TabPage2.Controls.Add(Me.txt_InterpMedicAINES)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(962, 475)
        Me.TabPage2.TabIndex = 7
        Me.TabPage2.Text = "          MEDICAMENTOS          "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(324, 15)
        Me.Label9.TabIndex = 278
        Me.Label9.Text = "En las pruebas  se han obtenido los siguienets resultados:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(654, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 277
        Me.Label8.Text = "OTROS"
        '
        'txt_InterpMedicAB
        '
        Me.txt_InterpMedicAB.BackColor = System.Drawing.Color.White
        Me.txt_InterpMedicAB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_InterpMedicAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InterpMedicAB.Location = New System.Drawing.Point(326, 40)
        Me.txt_InterpMedicAB.Multiline = True
        Me.txt_InterpMedicAB.Name = "txt_InterpMedicAB"
        Me.txt_InterpMedicAB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_InterpMedicAB.Size = New System.Drawing.Size(315, 430)
        Me.txt_InterpMedicAB.TabIndex = 276
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 275
        Me.Label6.Text = "ANTIBIOTICOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 274
        Me.Label5.Text = "AINES"
        '
        'txt_InterpMedicOTROS
        '
        Me.txt_InterpMedicOTROS.BackColor = System.Drawing.Color.White
        Me.txt_InterpMedicOTROS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_InterpMedicOTROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InterpMedicOTROS.Location = New System.Drawing.Point(650, 40)
        Me.txt_InterpMedicOTROS.Multiline = True
        Me.txt_InterpMedicOTROS.Name = "txt_InterpMedicOTROS"
        Me.txt_InterpMedicOTROS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_InterpMedicOTROS.Size = New System.Drawing.Size(315, 430)
        Me.txt_InterpMedicOTROS.TabIndex = 273
        '
        'txt_InterpMedicAINES
        '
        Me.txt_InterpMedicAINES.BackColor = System.Drawing.Color.White
        Me.txt_InterpMedicAINES.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_InterpMedicAINES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InterpMedicAINES.Location = New System.Drawing.Point(3, 40)
        Me.txt_InterpMedicAINES.Multiline = True
        Me.txt_InterpMedicAINES.Name = "txt_InterpMedicAINES"
        Me.txt_InterpMedicAINES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_InterpMedicAINES.Size = New System.Drawing.Size(315, 430)
        Me.txt_InterpMedicAINES.TabIndex = 272
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.LavenderBlush
        Me.TabPage7.Controls.Add(Me.txt_InterpRecom)
        Me.TabPage7.Controls.Add(Me.txt_InterpRecom2)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(962, 475)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "          RECOMENDACIONES          "
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'frm_Interpretacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(990, 605)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_Imp1)
        Me.Controls.Add(Me.btn_Imp2)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_paciente)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbl_FechaInter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Interpretacion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_Interpretacion"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents txt_InterpInhalantes As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaInter As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_paciente As System.Windows.Forms.Label
    Friend WithEvents txt_InterpRecom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_InterpRecom2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_Imp1 As System.Windows.Forms.Button
    Friend WithEvents btn_Imp2 As System.Windows.Forms.Button
    Friend WithEvents btnRecuperaInt As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents txt_InterpAlimentos As System.Windows.Forms.TextBox
    Friend WithEvents txt_Sustancias As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_InterpMedicOTROS As System.Windows.Forms.TextBox
    Friend WithEvents txt_InterpMedicAINES As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_InterpMedicAB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
