'*************************************************************************
' Nombre:   frm_Perfil
' Tipo de Archivo: Formulario
' Descripcin:  Formulario para la administracion de perfiles de test
' Autores:  RFN
' Fecha de Creaci�n: Agosto del 2002
' Autores:  RFN
' Ultima Modificaci�n: 15/08/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Public Class frm_Perfil
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
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Obs As System.Windows.Forms.TextBox
    Friend WithEvents dgrd_perfil As System.Windows.Forms.DataGrid
    Friend WithEvents lst_Test As System.Windows.Forms.ListBox
    Friend WithEvents lst_TestPerfil As System.Windows.Forms.ListBox
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lst_ As System.Windows.Forms.ListBox
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents grp_perfil As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_listas As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents pan_barra As System.Windows.Forms.Panel
    Friend WithEvents lbl_textform As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Perfil))
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.txt_Obs = New System.Windows.Forms.TextBox
        Me.dgrd_perfil = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lst_Test = New System.Windows.Forms.ListBox
        Me.lst_TestPerfil = New System.Windows.Forms.ListBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.lst_ = New System.Windows.Forms.ListBox
        Me.grp_perfil = New System.Windows.Forms.GroupBox
        Me.cmb_estado = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_listas = New System.Windows.Forms.Label
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.pan_barra = New System.Windows.Forms.Panel
        Me.lbl_textform = New System.Windows.Forms.Label
        CType(Me.dgrd_perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_perfil.SuspendLayout()
        Me.pan_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(12, 26)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(56, 16)
        Me.lbl_Nombre.TabIndex = 26
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Observacion:"
        Me.Label1.Visible = False
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(98, 23)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Mayusculas
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(346, 20)
        Me.Ctl_txt_nombre.TabIndex = 0
        '
        'txt_Obs
        '
        Me.txt_Obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Obs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Obs.ForeColor = System.Drawing.Color.Black
        Me.txt_Obs.Location = New System.Drawing.Point(98, 46)
        Me.txt_Obs.MaxLength = 150
        Me.txt_Obs.Multiline = True
        Me.txt_Obs.Name = "txt_Obs"
        Me.txt_Obs.Size = New System.Drawing.Size(346, 26)
        Me.txt_Obs.TabIndex = 1
        Me.txt_Obs.Visible = False
        '
        'dgrd_perfil
        '
        Me.dgrd_perfil.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_perfil.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_perfil.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_perfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_perfil.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_perfil.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_perfil.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_perfil.CaptionText = "PERFILES"
        Me.dgrd_perfil.DataMember = ""
        Me.dgrd_perfil.FlatMode = True
        Me.dgrd_perfil.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgrd_perfil.ForeColor = System.Drawing.Color.Black
        Me.dgrd_perfil.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_perfil.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_perfil.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_perfil.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_perfil.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_perfil.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_perfil.Location = New System.Drawing.Point(12, 345)
        Me.dgrd_perfil.Name = "dgrd_perfil"
        Me.dgrd_perfil.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_perfil.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_perfil.PreferredColumnWidth = 105
        Me.dgrd_perfil.ReadOnly = True
        Me.dgrd_perfil.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_perfil.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_perfil.Size = New System.Drawing.Size(506, 134)
        Me.dgrd_perfil.TabIndex = 1
        Me.dgrd_perfil.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_perfil
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Gray
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "per_id"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "per_nombre"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 180
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Observaci�n"
        Me.DataGridTextBoxColumn3.MappingName = "per_obs"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 145
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridTextBoxColumn4.MappingName = "estado"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'lst_Test
        '
        Me.lst_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_Test.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Test.ForeColor = System.Drawing.Color.Black
        Me.lst_Test.Location = New System.Drawing.Point(6, 99)
        Me.lst_Test.Name = "lst_Test"
        Me.lst_Test.Size = New System.Drawing.Size(239, 158)
        Me.lst_Test.TabIndex = 3
        '
        'lst_TestPerfil
        '
        Me.lst_TestPerfil.AllowDrop = True
        Me.lst_TestPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_TestPerfil.ContextMenu = Me.ContextMenu1
        Me.lst_TestPerfil.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_TestPerfil.ForeColor = System.Drawing.Color.Black
        Me.lst_TestPerfil.Location = New System.Drawing.Point(251, 99)
        Me.lst_TestPerfil.Name = "lst_TestPerfil"
        Me.lst_TestPerfil.Size = New System.Drawing.Size(246, 158)
        Me.lst_TestPerfil.TabIndex = 4
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Eliminar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Eliminar Todos"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(122, 34)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 37)
        Me.btn_Nuevo.TabIndex = 2
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
        Me.btn_Salir.Location = New System.Drawing.Point(438, 34)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(80, 37)
        Me.btn_Salir.TabIndex = 6
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(280, 34)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 37)
        Me.btn_Eliminar.TabIndex = 4
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
        Me.btn_Aceptar.Location = New System.Drawing.Point(201, 34)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 37)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'lst_
        '
        Me.lst_.Location = New System.Drawing.Point(300, 142)
        Me.lst_.Name = "lst_"
        Me.lst_.Size = New System.Drawing.Size(134, 121)
        Me.lst_.TabIndex = 0
        '
        'grp_perfil
        '
        Me.grp_perfil.BackColor = System.Drawing.Color.Transparent
        Me.grp_perfil.Controls.Add(Me.cmb_estado)
        Me.grp_perfil.Controls.Add(Me.Label2)
        Me.grp_perfil.Controls.Add(Me.lbl_listas)
        Me.grp_perfil.Controls.Add(Me.lst_Test)
        Me.grp_perfil.Controls.Add(Me.lst_TestPerfil)
        Me.grp_perfil.Controls.Add(Me.txt_Obs)
        Me.grp_perfil.Controls.Add(Me.Ctl_txt_nombre)
        Me.grp_perfil.Controls.Add(Me.lbl_Nombre)
        Me.grp_perfil.Controls.Add(Me.Label1)
        Me.grp_perfil.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_perfil.ForeColor = System.Drawing.Color.Navy
        Me.grp_perfil.Location = New System.Drawing.Point(12, 73)
        Me.grp_perfil.Name = "grp_perfil"
        Me.grp_perfil.Size = New System.Drawing.Size(506, 266)
        Me.grp_perfil.TabIndex = 0
        Me.grp_perfil.TabStop = False
        Me.grp_perfil.Text = "Datos:"
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_estado.Items.AddRange(New Object() {"INACTIVO", "ACTIVO"})
        Me.cmb_estado.Location = New System.Drawing.Point(98, 45)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(164, 21)
        Me.cmb_estado.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Estado:"
        '
        'lbl_listas
        '
        Me.lbl_listas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_listas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_listas.ForeColor = System.Drawing.Color.Black
        Me.lbl_listas.Location = New System.Drawing.Point(5, 83)
        Me.lbl_listas.Name = "lbl_listas"
        Me.lbl_listas.Size = New System.Drawing.Size(404, 16)
        Me.lbl_listas.TabIndex = 33
        Me.lbl_listas.Text = "Test Disponibles:                                                  Test del Perfi" & _
            "l:"
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
        Me.btn_imprimir.Location = New System.Drawing.Point(359, 34)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(80, 37)
        Me.btn_imprimir.TabIndex = 5
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'pan_barra
        '
        Me.pan_barra.BackColor = System.Drawing.Color.Transparent
        Me.pan_barra.Controls.Add(Me.lbl_textform)
        Me.pan_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan_barra.Location = New System.Drawing.Point(0, 0)
        Me.pan_barra.Name = "pan_barra"
        Me.pan_barra.Size = New System.Drawing.Size(530, 25)
        Me.pan_barra.TabIndex = 92
        '
        'lbl_textform
        '
        Me.lbl_textform.AutoSize = True
        Me.lbl_textform.BackColor = System.Drawing.Color.Transparent
        Me.lbl_textform.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_textform.ForeColor = System.Drawing.Color.Black
        Me.lbl_textform.Location = New System.Drawing.Point(7, 4)
        Me.lbl_textform.Name = "lbl_textform"
        Me.lbl_textform.Size = New System.Drawing.Size(180, 18)
        Me.lbl_textform.TabIndex = 60
        Me.lbl_textform.Text = "GESTION DE PERFILES"
        Me.lbl_textform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Perfil
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(530, 494)
        Me.Controls.Add(Me.pan_barra)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.grp_perfil)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.dgrd_perfil)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Perfil"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfiles"
        CType(Me.dgrd_perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_perfil.ResumeLayout(False)
        Me.grp_perfil.PerformLayout()
        Me.pan_barra.ResumeLayout(False)
        Me.pan_barra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Codigo de Formulario"
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
        'Funcion para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
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
        'Funcion para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Nuevo.MouseEnter, btn_Eliminar.MouseEnter, btn_Salir.MouseEnter, btn_imprimir.MouseEnter
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

    Dim opr_perfil As New Cls_Perfil()
    Dim opr_test As New Cls_TipoTest()
    Dim str_x As String
    Dim str_y As String
    Dim int_codigo As Integer
    Dim boo_flag As Boolean

    Private Sub frm_Perfil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        Call LimpiarCamposPerfil()
        cmb_estado.SelectedIndex = 1
        grp_perfil.Enabled = False
        dgrd_perfil.SetDataBinding(opr_perfil.LeerPerfil(), "Registros")
        opr_test.LlenarList_Test(lst_Test)
        btn_Nuevo.Focus()
    End Sub

    Private Sub LimpiarCamposPerfil()
        Ctl_txt_nombre.texto_Asigna("")
        Ctl_txt_nombre.txt_padre.MaxLength = 100
        txt_Obs.Text = ""
        lst_TestPerfil.Items.Clear()
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub lst_Test_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_Test.MouseDown
        lst_Test.DoDragDrop(lst_Test.Items.Item(lst_Test.SelectedIndex), DragDropEffects.Copy)
        str_x = lst_Test.Items.Item(lst_Test.SelectedIndex)
    End Sub

    Private Sub lst_TestPerfil_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lst_TestPerfil.DragEnter
        ' Make sure that the format is text.
        Dim int_i As Integer
        Dim str_y As String
        Dim boo_flag As Boolean
        boo_flag = False
        If (lst_TestPerfil.Items.Count() > 0) Then
            For int_i = 1 To lst_TestPerfil.Items.Count()
                If (lst_Test.Items.Item(lst_Test.SelectedIndex)) = lst_TestPerfil.Items.Item(int_i - 1) Then
                    boo_flag = True
                    Exit For
                End If
            Next
        End If
        If (e.Data.GetDataPresent(DataFormats.Text) And boo_flag = False) Then
            ' Allow drop.
            e.Effect = DragDropEffects.Copy
        Else
            ' Do not allow drop.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lst_testperfil_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lst_TestPerfil.DragDrop
        ' Copy the text to the second listBox.
        lst_TestPerfil.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        lst_TestPerfil.Items.Remove(lst_TestPerfil.SelectedItem)
        On Error Resume Next
        lst_TestPerfil.SelectedIndex = 0
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        lst_TestPerfil.Items.Clear()
        On Error Resume Next
        lst_TestPerfil.SelectedIndex = 0
    End Sub

    Private Sub lst_TestPerfil_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_TestPerfil.KeyUp
        On Error Resume Next
        If e.KeyData.ToString = "Delete" Then
            lst_TestPerfil.Items.Remove(lst_TestPerfil.SelectedItem)
            On Error Resume Next
            lst_TestPerfil.SelectedIndex = 0
        End If
        If e.KeyCode = 8 Then
            lst_TestPerfil.Items.Remove(lst_TestPerfil.SelectedItem)
            On Error Resume Next
            lst_TestPerfil.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        btn_Nuevo.Enabled = False
        btn_Aceptar.Enabled = True
        grp_perfil.Enabled = True
        Call LimpiarCamposPerfil()
        Ctl_txt_nombre.Focus()
        boo_flag = True
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If (Ctl_txt_nombre.texto_Recupera = "") Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("Ingrese el nombre del perfil", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If
        'Verifico que no exista otro perfil con el mismo nombre

        If (opr_perfil.BuscarPerfil(Ctl_txt_nombre.texto_Recupera) = True And boo_flag = True) Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            MsgBox("El nombre ingresado ya existe", MsgBoxStyle.Exclamation, "ANALISYS")
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If
        'If (lst_TestPerfil.Items.Count < 2) Then
        '    Me.Cursor = System.Windows.Forms.Cursors.Arrow
        '    MsgBox("Seleccione al menos dos test para el perfil", MsgBoxStyle.Exclamation, "ANALISYS")
        '    Exit Sub
        'End If

        If boo_flag = True Then    '*** Si se trata de una nueva AREA 
            int_codigo = opr_perfil.LeerMaxCodPerfil() + 1
            opr_perfil.GuardarPerfil(int_codigo, Ctl_txt_nombre.texto_Recupera, txt_Obs.Text.ToString, lst_TestPerfil, cmb_estado.SelectedIndex)
        Else
            'En caso de actualizar un PERFIL    
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            If MsgBox("Desea actualizar el registro?", MsgBoxStyle.YesNo, "ANALISYS") = vbNo Then
                Call LimpiarCamposPerfil()
                Exit Sub
            Else
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                opr_perfil.ActualizarPerfil(int_codigo, Ctl_txt_nombre.texto_Recupera, txt_Obs.Text.ToString, lst_TestPerfil, cmb_estado.SelectedIndex)
            End If
        End If
        Call LimpiarCamposPerfil()
        dgrd_perfil.SetDataBinding(opr_perfil.LeerPerfil(), "Registros")
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        btn_Nuevo.Enabled = True
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_perfil.Enabled = False
        btn_Nuevo.Focus()
    End Sub

    Private Sub dgrd_perfil_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_perfil.CurrentCellChanged
        Dim dts_uni As DataSet
        Dim dtr_fila As DataRow
        Dim int_i As Integer
        Dim str_x As String
        Dim int_y As Integer
        dgrd_perfil.Select(dgrd_perfil.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_perfil.Enabled = True
        int_codigo = dgrd_perfil.Item(dgrd_perfil.CurrentCell.RowNumber, 0)
        Ctl_txt_nombre.texto_Asigna(dgrd_perfil.Item(dgrd_perfil.CurrentCell.RowNumber, 1))
        txt_Obs.Text = (dgrd_perfil.Item(dgrd_perfil.CurrentCell.RowNumber, 2).ToString())
        cmb_estado.Text = dgrd_perfil.Item(dgrd_perfil.CurrentCell.RowNumber, 3)
        boo_flag = False
        dts_uni = opr_perfil.LeerPerfil_test(int_codigo)
        lst_TestPerfil.Items.Clear()
        For Each dtr_fila In dts_uni.Tables("RegistrosP").Rows
            int_y = dtr_fila(0)
            'Recorro el list 1 buscando el test y lo copio en el list 2 
            For int_i = 0 To (lst_Test.Items.Count - 1)
                str_x = lst_Test.Items.Item(int_i)
                str_x = str_x.Substring(100, 10)
                If (Val(str_x) = int_y) Then
                    lst_TestPerfil.Items.Add(lst_Test.Items.Item(int_i))
                End If
            Next
        Next
        'C�digo para evitar que se seleccione una celda y no toda la fila 
        Dim dgCell As DataGridCell
        dgCell.ColumnNumber = 0
        dgCell.RowNumber = dgrd_perfil.CurrentCell.RowNumber
        dgrd_perfil.CurrentCell = dgCell
        dgrd_perfil.Select(dgrd_perfil.CurrentCell.RowNumber)

    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If MsgBox("Desea eliminar el perfil?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ANALISYS") = vbYes Then
            If opr_perfil.EliminarPerfil(int_codigo) Then
                MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
            End If
            dgrd_perfil.SetDataBinding(opr_perfil.LeerPerfil(), "Registros")
        End If
        Call LimpiarCamposPerfil()
        grp_perfil.Enabled = False
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_perfil.Enabled = False
        btn_Nuevo.Focus()
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_perfiles()
        'str_sql = "SELECT PER_NOMBRE, PER_ID, '' AS TES_ID, '' AS TES_NOMBRE, PER_OBS, if(PER_ESTADO = 1, 'Activo', 'Inactivo') AS ESTADO FROM PERFIL UNION SELECT PERFIL.PER_NOMBRE AS PER_NOMBRE, PERFIL_TEST.PER_ID, PERFIL_TEST.TES_ID, TEST.TES_NOMBRE AS TES_NOMBRE, PERFIL.PER_OBS AS PER_OBS, if(PERFIL.PER_ESTADO= 1, 'Activo', 'Inactivo') AS ESTADO FROM PERFIL, TEST, PERFIL_TEST WHERE PERFIL.PER_ID = PERFIL_TEST.PER_ID AND TEST.TES_ID = PERFIL_TEST.TES_ID"
        str_sql = "SELECT PERFIL.PER_NOMBRE AS PER_NOMBRE, PERFIL_TEST.PER_ID, PERFIL_TEST.TES_ID, TEST.TES_NOMBRE AS TES_NOMBRE, PERFIL.PER_OBS AS PER_OBS, case when PERFIL.PER_ESTADO= 1 then 'Activo' when PERFIL.PER_ESTADO= 0 then 'Inactivo' end as ESTADO FROM PERFIL, TEST, PERFIL_TEST WHERE PERFIL.PER_ID = PERFIL_TEST.PER_ID AND TEST.TES_ID = PERFIL_TEST.TES_ID"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Perfiles"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub lst_Test_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_Test.KeyDown
        If e.KeyCode = Keys.Enter Then
            lst_TestPerfil.Items.Add(lst_Test.SelectedItem.ToString)
        End If

    End Sub
End Class
