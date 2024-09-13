<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TrabajoFiltro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TrabajoFiltro))
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.Ctl_txt_Desde = New Ctl_txt.ctl_txt_numeros
        Me.Ctl_txt_Hasta = New Ctl_txt.ctl_txt_numeros
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(485, 25)
        Me.pan_barra.TabIndex = 102
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_textform.Location = New System.Drawing.Point(9, 5)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(75, 14)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "SECUENCIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "DESDE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "HASTA:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = CType(resources.GetObject("btn_aceptar.Image"), System.Drawing.Image)
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.Location = New System.Drawing.Point(297, 48)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(80, 39)
        Me.btn_aceptar.TabIndex = 107
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'Ctl_txt_Desde
        '
        Me.Ctl_txt_Desde.Location = New System.Drawing.Point(79, 58)
        Me.Ctl_txt_Desde.Name = "Ctl_txt_Desde"
        Me.Ctl_txt_Desde.Prp_Formato = True
        Me.Ctl_txt_Desde.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_Desde.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_Desde.Prp_ValDefault = "0"
        Me.Ctl_txt_Desde.Size = New System.Drawing.Size(62, 20)
        Me.Ctl_txt_Desde.TabIndex = 108
        '
        'Ctl_txt_Hasta
        '
        Me.Ctl_txt_Hasta.Location = New System.Drawing.Point(208, 58)
        Me.Ctl_txt_Hasta.Name = "Ctl_txt_Hasta"
        Me.Ctl_txt_Hasta.Prp_Formato = True
        Me.Ctl_txt_Hasta.Prp_NumDecimales = CType(0, Short)
        Me.Ctl_txt_Hasta.Prp_TipoTexto = Ctl_txt.ctl_txt_numeros.ValoresTipoTexto.Decimales
        Me.Ctl_txt_Hasta.Prp_ValDefault = "0"
        Me.Ctl_txt_Hasta.Size = New System.Drawing.Size(62, 20)
        Me.Ctl_txt_Hasta.TabIndex = 109
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.Location = New System.Drawing.Point(383, 48)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 39)
        Me.btn_cancelar.TabIndex = 110
        Me.btn_cancelar.Text = "Salir"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'frm_TrabajoFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(485, 109)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Ctl_txt_Hasta)
        Me.Controls.Add(Me.Ctl_txt_Desde)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pan_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_TrabajoFiltro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_TrabajoFiltro"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Ctl_txt_Desde As Ctl_txt.ctl_txt_numeros
    Friend WithEvents Ctl_txt_Hasta As Ctl_txt.ctl_txt_numeros
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
