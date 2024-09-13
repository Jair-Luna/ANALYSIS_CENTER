'*************************************************************************
' Nombre:   frm_servicios
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para la administracion de los Servicios para ingreso de pedidos y estadisticas
' Autores:  RFN
' Fecha de Creaci�n: julio del 2007
' Autores:  RFN
' Ultima Modificaci�n: 20/07/2007
' Proyecto TRUESOLUTIONS
'*************************************************************************

Public Class frm_servicio
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents grp_Area As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipTubo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_areaNom As Ctl_txt.ctl_txt_letras
    Friend WithEvents dgrd_servicios As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_Correo As Ctl_txt.ctl_txt_letras
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_Celular As Ctl_txt.ctl_txt_letras
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_servicio))
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.grp_Area = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Ctl_txt_Correo = New Ctl_txt.ctl_txt_letras
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmb_tipTubo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Ctl_txt_areaNom = New Ctl_txt.ctl_txt_letras
        Me.dgrd_servicios = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Ctl_txt_Celular = New Ctl_txt.ctl_txt_letras
        Me.Label3 = New System.Windows.Forms.Label
        Me.pan_barra.SuspendLayout()
        Me.grp_Area.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrd_servicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(622, 25)
        Me.pan_barra.TabIndex = 93
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(14, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_textform.Size = New System.Drawing.Size(205, 19)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GESTION DE SERVICIOS"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(450, 31)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 35)
        Me.btn_imprimir.TabIndex = 99
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(198, 31)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 35)
        Me.btn_Nuevo.TabIndex = 96
        Me.btn_Nuevo.Text = "Nuevo"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.UseVisualStyleBackColor = False
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
        Me.btn_Salir.Location = New System.Drawing.Point(534, 31)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 35)
        Me.btn_Salir.TabIndex = 100
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(366, 31)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 35)
        Me.btn_Eliminar.TabIndex = 98
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(282, 31)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 35)
        Me.btn_Aceptar.TabIndex = 97
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'grp_Area
        '
        Me.grp_Area.BackColor = System.Drawing.Color.Transparent
        Me.grp_Area.Controls.Add(Me.Label3)
        Me.grp_Area.Controls.Add(Me.Ctl_txt_Celular)
        Me.grp_Area.Controls.Add(Me.Label2)
        Me.grp_Area.Controls.Add(Me.Ctl_txt_Correo)
        Me.grp_Area.Controls.Add(Me.PictureBox1)
        Me.grp_Area.Controls.Add(Me.cmb_tipTubo)
        Me.grp_Area.Controls.Add(Me.Label1)
        Me.grp_Area.Controls.Add(Me.lbl_Nombre)
        Me.grp_Area.Controls.Add(Me.Ctl_txt_areaNom)
        Me.grp_Area.Enabled = False
        Me.grp_Area.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Area.ForeColor = System.Drawing.Color.Navy
        Me.grp_Area.Location = New System.Drawing.Point(12, 74)
        Me.grp_Area.Name = "grp_Area"
        Me.grp_Area.Size = New System.Drawing.Size(598, 98)
        Me.grp_Area.TabIndex = 94
        Me.grp_Area.TabStop = False
        Me.grp_Area.Text = "Servicios"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(75, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CORREO:"
        '
        'Ctl_txt_Correo
        '
        Me.Ctl_txt_Correo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Correo.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_Correo.Location = New System.Drawing.Point(145, 46)
        Me.Ctl_txt_Correo.Name = "Ctl_txt_Correo"
        Me.Ctl_txt_Correo.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Correo.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Correo.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_Correo.Size = New System.Drawing.Size(407, 20)
        Me.Ctl_txt_Correo.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'cmb_tipTubo
        '
        Me.cmb_tipTubo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipTubo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipTubo.Items.AddRange(New Object() {"APOYO MEDICO", "CONSULTA EXTERNA", "HOSPITALIZACION", "URGENCIAS", "OTROS"})
        Me.cmb_tipTubo.Location = New System.Drawing.Point(390, 21)
        Me.cmb_tipTubo.Name = "cmb_tipTubo"
        Me.cmb_tipTubo.Size = New System.Drawing.Size(162, 21)
        Me.cmb_tipTubo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(320, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TIPO:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(75, 24)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(64, 18)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "SERVICIO:"
        '
        'Ctl_txt_areaNom
        '
        Me.Ctl_txt_areaNom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_areaNom.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_areaNom.Location = New System.Drawing.Point(145, 20)
        Me.Ctl_txt_areaNom.Name = "Ctl_txt_areaNom"
        Me.Ctl_txt_areaNom.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_areaNom.Prp_CaracterPasswd = ""
        Me.Ctl_txt_areaNom.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_areaNom.Size = New System.Drawing.Size(162, 20)
        Me.Ctl_txt_areaNom.TabIndex = 0
        '
        'dgrd_servicios
        '
        Me.dgrd_servicios.AllowNavigation = False
        Me.dgrd_servicios.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_servicios.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_servicios.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_servicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_servicios.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_servicios.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_servicios.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_servicios.CaptionText = "SERVICIOS"
        Me.dgrd_servicios.DataMember = ""
        Me.dgrd_servicios.FlatMode = True
        Me.dgrd_servicios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_servicios.ForeColor = System.Drawing.Color.Black
        Me.dgrd_servicios.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_servicios.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_servicios.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_servicios.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_servicios.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_servicios.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_servicios.Location = New System.Drawing.Point(12, 178)
        Me.dgrd_servicios.Name = "dgrd_servicios"
        Me.dgrd_servicios.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_servicios.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_servicios.ParentRowsVisible = False
        Me.dgrd_servicios.PreferredColumnWidth = 145
        Me.dgrd_servicios.ReadOnly = True
        Me.dgrd_servicios.RowHeaderWidth = 20
        Me.dgrd_servicios.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_servicios.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_servicios.Size = New System.Drawing.Size(598, 247)
        Me.dgrd_servicios.TabIndex = 95
        Me.dgrd_servicios.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_servicios
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn1.MappingName = "ser_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Servicio"
        Me.DataGridTextBoxColumn2.MappingName = "ser_nombre"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn3.MappingName = "ser_tipo"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 125
        '
        'Ctl_txt_Celular
        '
        Me.Ctl_txt_Celular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_Celular.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_Celular.Location = New System.Drawing.Point(145, 72)
        Me.Ctl_txt_Celular.Name = "Ctl_txt_Celular"
        Me.Ctl_txt_Celular.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_Celular.Prp_CaracterPasswd = ""
        Me.Ctl_txt_Celular.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_Celular.Size = New System.Drawing.Size(162, 20)
        Me.Ctl_txt_Celular.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(75, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "TELEFONO:"
        '
        'frm_servicio
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(622, 437)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.grp_Area)
        Me.Controls.Add(Me.dgrd_servicios)
        Me.Controls.Add(Me.pan_barra)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_servicio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.grp_Area.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrd_servicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "C�digo de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image


    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseMove
        ClickMenu_Principal(Me)
        'Funci�n para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            dbl_x = mousePos.X
            frm_refer_main_form.ubica(Me.Width, Me.Height, mousePos.Y, mousePos.X - frm_refer_main_form.Splitter.Width)
        End If
    End Sub

    Private Sub Formulario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated, MyBase.Enter
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
    End Sub

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_textform.MouseDown
        'Funci�n para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub


    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Eliminar.MouseEnter, btn_Nuevo.MouseEnter, btn_Salir.MouseEnter, btn_imprimir.MouseEnter
        'cuando el mouse se mueve por encima del los botones del formulario
        Select Case sender.name
            Case "pic_min"
                If m_HtImages.ContainsKey("btn_minp") Then
                    imageToDraw = CType(m_HtImages("btn_minp"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_minp.jpg")
                        m_HtImages.Add("btn_minp", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_closep") Then
                    imageToDraw = CType(m_HtImages("btn_closep"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_closep.jpg")
                        m_HtImages.Add("btn_closep", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Bold)
                    sender.forecolor = Color.White
                    If m_HtImages.ContainsKey("barraMenu1") Then
                        imageToDraw = CType(m_HtImages("barraMenu1"), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu1.jpg")
                            m_HtImages.Add("barraMenu1", imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                    sender.BackgroundImage = imageToDraw
                End If
        End Select
    End Sub

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Eliminar.MouseLeave, btn_Nuevo.MouseLeave, btn_Salir.MouseLeave, btn_imprimir.MouseLeave
        'cuando el mouse se pierde el enfoque del los botones del formulario
        Select Case sender.name
            Case "pic_min"
                If m_HtImages.ContainsKey("btn_min") Then
                    imageToDraw = CType(m_HtImages("btn_min"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_min.jpg")
                        m_HtImages.Add("btn_min", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case "Pic_close"
                If m_HtImages.ContainsKey("btn_close") Then
                    imageToDraw = CType(m_HtImages("btn_close"), System.Drawing.Image)
                Else
                    Try
                        imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\btn_close.jpg")
                        m_HtImages.Add("btn_close", imageToDraw)
                    Catch
                        Return
                    End Try
                End If
                sender.Image = imageToDraw
            Case Else
                If sender.name Like "btn_*" Then
                    sender.Font = New Font(Me.Font, FontStyle.Regular)
                    sender.forecolor = Color.Black
                    If m_HtImages.ContainsKey("barraMenu2") Then
                        imageToDraw = CType(m_HtImages("barraMenu2"), System.Drawing.Image)
                    Else
                        Try
                            imageToDraw = Drawing.Image.FromFile(Environment.CurrentDirectory & "\Imagenes\barraMenu2.jpg")
                            m_HtImages.Add("barraMenu2", imageToDraw)
                        Catch
                            Return
                        End Try
                    End If
                    sender.BackgroundImage = imageToDraw
                End If
        End Select
    End Sub

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, lbl_textform.Click
        'elimina las funciones activas (ej menu) del formulario MDI.
        Dim int_posX As Integer
        int_posX = (Me.MdiParent.Size.Width - Me.MdiParent.Size.Width) / 2
        ClickMenu_Principal(Me)
        Select Case sender.name
            Case "Pic_close"
                Me.Close()
            Case "pic_min"
                Me.WindowState = FormWindowState.Minimized
                Me.ControlBox = True
                Me.MaximizeBox = False
        End Select
    End Sub

    Private Sub Formulario_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'elimina la referecnia del formulario del MDI
        ClickMenu_Principal(Me)
        RemoveCtxMenu_Principal(Me, Me.Text)
    End Sub

    Private Sub Formulario_Borde(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
        'controla que el formulario cuando se encuentra minimizado tenga borde, y cuando se encuentra normal no tenga borde
        Dim lng_height, lng_width As Long
        lng_height = Me.Height
        lng_width = Me.Width
        Select Case Me.WindowState
            Case 0
                Me.FormBorderStyle = FormBorderStyle.None
            Case 1
                Me.FormBorderStyle = FormBorderStyle.FixedSingle
        End Select
        Me.Height = lng_height
        Me.Width = lng_width
    End Sub

#End Region

    Dim boo_flag As Boolean
    Dim int_codigo As Integer = 0
    Dim opr_servicio As New Cls_servicios()

    Private Sub frm_servicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        dgrd_servicios.SetDataBinding(opr_servicio.LeerServiciosGrid, "Registros")
        Me.cmb_tipTubo.Text = "APOYO MEDICO"
        btn_Nuevo.Enabled = True
        Me.btn_Eliminar.Enabled = False
        Me.btn_Aceptar.Enabled = False
        Me.btn_imprimir.Enabled = True
        boo_flag = False
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Me.grp_Area.Enabled = True
        Me.Ctl_txt_areaNom.Focus()
        btn_Aceptar.Enabled = True
        boo_flag = True   'INDICO A LA BANDERA QUE ES UN REGISTRO NUEVO

    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'Valido que los campos obligatorios est�n ingresados
        'int_codigo = 0
        If (Ctl_txt_areaNom.texto_Recupera = "") Then
            MsgBox("Ingrese el nombre del Servicio", MsgBoxStyle.Information, "ANALISYS")
            Ctl_txt_areaNom.Focus()
            Exit Sub
        End If
        'Hago una diferencia entre los registros nuevos y las actualizaciones 
        If boo_flag = True Then    '*** Si se trata de una nuevo Servicio
            int_codigo = opr_servicio.LeerMaxCodServicios() + 1
            opr_servicio.GuardarServicio(int_codigo, Ctl_txt_areaNom.texto_Recupera, cmb_tipTubo.Text, Ctl_txt_Correo.texto_Recupera(), Ctl_txt_Celular.texto_Recupera())

        Else    '*** Si se trata de una actualizaci�n a una Servicio
            Dim obj_res As Object
            obj_res = MsgBox("Desea actualizar los datos?", MsgBoxStyle.YesNo, "ANALISYS")
            If (obj_res = vbYes) Then
                opr_servicio.ActualizarServicio(int_codigo, Ctl_txt_areaNom.texto_Recupera, cmb_tipTubo.Text, Ctl_txt_Correo.texto_Recupera, Ctl_txt_Celular.texto_Recupera())
            End If
        End If
        Ctl_txt_areaNom.texto_Asigna("")
        Me.cmb_tipTubo.Text = "APOYO MEDICO"
        grp_Area.Enabled = False
        btn_Aceptar.Enabled = False
        btn_Nuevo.Focus()
        dgrd_servicios.SetDataBinding(opr_servicio.LeerServiciosGrid, "Registros")
        btn_Nuevo.Focus()
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If MsgBox("Desea eliminar el Servicio seleccionado? Esto puede causar la perdida de Informacion", MsgBoxStyle.YesNo, "ANALISYS") = vbYes Then
            Dim opr_areas As New Cls_Areas()
            opr_servicio.EliminarServicio(int_codigo)
            dgrd_servicios.SetDataBinding(opr_servicio.LeerServiciosGrid, "Registros")
        End If
        Me.Ctl_txt_areaNom.texto_Asigna("")
        Me.cmb_tipTubo.Text = "APOYO MEDICO"
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_Area.Enabled = False
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New Rpt_Servicios()
        'Envio el sql que se requiere para que genere Crystal el reporte deseado
        str_sql = "SELECT * FROM SERVICIO ORDER BY SER_TIPO, SER_NOMBRE;"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Reporte de Servicios"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    Private Sub dgrd_servicios_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_servicios.CurrentCellChanged
        dgrd_servicios.Select(dgrd_servicios.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_Area.Enabled = True
        boo_flag = False
        int_codigo = dgrd_servicios.Item(dgrd_servicios.CurrentCell.RowNumber, 0)
        Ctl_txt_areaNom.texto_Asigna(dgrd_servicios.Item(dgrd_servicios.CurrentCell.RowNumber, 1))
        'Me.cmb_tipTubo.Text = (dgrd_servicios.Item(dgrd_servicios.CurrentCell.RowNumber, 2).ToString())
        Dim int_i As Short
        For int_i = 0 To (cmb_tipTubo.Items.Count - 1)
            If (Trim(cmb_tipTubo.Items.Item(int_i)) = Trim(dgrd_servicios.Item(dgrd_servicios.CurrentCell.RowNumber, 2).ToString())) Then
                cmb_tipTubo.SelectedIndex = int_i
                Exit For
            End If
        Next
        boo_flag = False
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 0
        dgc_celda.RowNumber = dgrd_servicios.CurrentCell.RowNumber
        dgrd_servicios.CurrentCell = dgc_celda
        dgrd_servicios.Select(dgrd_servicios.CurrentCell.RowNumber)
    End Sub

End Class
