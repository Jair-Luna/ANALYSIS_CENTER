<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SolicitudMeddico
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
        Me.txt_Solicitud = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txt_Solicitud
        '
        Me.txt_Solicitud.AcceptsTab = True
        Me.txt_Solicitud.BackColor = System.Drawing.Color.White
        Me.txt_Solicitud.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Solicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Solicitud.Location = New System.Drawing.Point(12, 12)
        Me.txt_Solicitud.Multiline = True
        Me.txt_Solicitud.Name = "txt_Solicitud"
        Me.txt_Solicitud.ReadOnly = True
        Me.txt_Solicitud.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Solicitud.Size = New System.Drawing.Size(314, 406)
        Me.txt_Solicitud.TabIndex = 279
        '
        'frm_SolicitudMeddico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 430)
        Me.Controls.Add(Me.txt_Solicitud)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SolicitudMeddico"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud Meddico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Solicitud As System.Windows.Forms.TextBox
End Class
