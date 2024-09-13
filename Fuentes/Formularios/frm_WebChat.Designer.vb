<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_WebChat
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
        Me.pan_hist = New System.Windows.Forms.Panel
        Me.Pic_Baso = New System.Windows.Forms.PictureBox
        Me.pic_rbc = New System.Windows.Forms.PictureBox
        Me.pic_diff = New System.Windows.Forms.PictureBox
        Me.pic_plt = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.pan_hist.SuspendLayout()
        CType(Me.Pic_Baso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_rbc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_diff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_plt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_hist
        '
        Me.pan_hist.Controls.Add(Me.Pic_Baso)
        Me.pan_hist.Controls.Add(Me.pic_rbc)
        Me.pan_hist.Controls.Add(Me.pic_diff)
        Me.pan_hist.Controls.Add(Me.pic_plt)
        Me.pan_hist.Location = New System.Drawing.Point(12, 21)
        Me.pan_hist.Name = "pan_hist"
        Me.pan_hist.Size = New System.Drawing.Size(808, 185)
        Me.pan_hist.TabIndex = 169
        '
        'Pic_Baso
        '
        Me.Pic_Baso.BackColor = System.Drawing.Color.White
        Me.Pic_Baso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Baso.Location = New System.Drawing.Point(206, 5)
        Me.Pic_Baso.Name = "Pic_Baso"
        Me.Pic_Baso.Size = New System.Drawing.Size(195, 177)
        Me.Pic_Baso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Baso.TabIndex = 5
        Me.Pic_Baso.TabStop = False
        '
        'pic_rbc
        '
        Me.pic_rbc.BackColor = System.Drawing.Color.White
        Me.pic_rbc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_rbc.Location = New System.Drawing.Point(407, 5)
        Me.pic_rbc.Name = "pic_rbc"
        Me.pic_rbc.Size = New System.Drawing.Size(195, 177)
        Me.pic_rbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_rbc.TabIndex = 3
        Me.pic_rbc.TabStop = False
        '
        'pic_diff
        '
        Me.pic_diff.BackColor = System.Drawing.Color.White
        Me.pic_diff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_diff.Location = New System.Drawing.Point(5, 5)
        Me.pic_diff.Name = "pic_diff"
        Me.pic_diff.Size = New System.Drawing.Size(195, 177)
        Me.pic_diff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_diff.TabIndex = 4
        Me.pic_diff.TabStop = False
        '
        'pic_plt
        '
        Me.pic_plt.BackColor = System.Drawing.Color.White
        Me.pic_plt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_plt.Location = New System.Drawing.Point(607, 5)
        Me.pic_plt.Name = "pic_plt"
        Me.pic_plt.Size = New System.Drawing.Size(195, 177)
        Me.pic_plt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_plt.TabIndex = 2
        Me.pic_plt.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Diff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Baso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(423, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "RBC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(622, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "PLT"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1043, 493)
        Me.CrystalReportViewer1.TabIndex = 174
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frm_WebChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1043, 493)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pan_hist)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_WebChat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HISTOGRAMA"
        Me.pan_hist.ResumeLayout(False)
        CType(Me.Pic_Baso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_rbc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_diff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_plt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pan_hist As System.Windows.Forms.Panel
    Friend WithEvents pic_rbc As System.Windows.Forms.PictureBox
    Friend WithEvents pic_diff As System.Windows.Forms.PictureBox
    Friend WithEvents pic_plt As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Baso As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
