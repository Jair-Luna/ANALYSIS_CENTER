Public Class frm_i_Proveedor
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
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_id As Ctl_txt.ctl_txt_letras
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_dir As System.Windows.Forms.Label
    Friend WithEvents lbl_fono As System.Windows.Forms.Label
    Friend WithEvents lbl_fax As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_Rep As System.Windows.Forms.Label
    Friend WithEvents lbl_fono_rep As System.Windows.Forms.Label
    Friend WithEvents lbl_cell_fono As System.Windows.Forms.Label
    Friend WithEvents Ctl_txt_nombre As Ctl_txt.ctl_txt_letras
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents Ctl_txt_rep As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_mail As Ctl_txt.ctl_txt_mail
    Friend WithEvents grp_proveedor As System.Windows.Forms.GroupBox
    Friend WithEvents Ctl_txt_profono As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_fax As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_repFono As Ctl_txt.ctl_txt_letras
    Friend WithEvents Ctl_txt_cell As Ctl_txt.ctl_txt_letras
    Friend WithEvents dgrd_proveedor As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btn_reportes As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_i_Proveedor))
        Me.btn_Nuevo = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.dgrd_proveedor = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbl_codigo = New System.Windows.Forms.Label
        Me.Ctl_txt_id = New Ctl_txt.ctl_txt_letras
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.lbl_dir = New System.Windows.Forms.Label
        Me.lbl_fono = New System.Windows.Forms.Label
        Me.lbl_fax = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_Rep = New System.Windows.Forms.Label
        Me.lbl_fono_rep = New System.Windows.Forms.Label
        Me.lbl_cell_fono = New System.Windows.Forms.Label
        Me.Ctl_txt_nombre = New Ctl_txt.ctl_txt_letras
        Me.txt_dir = New System.Windows.Forms.TextBox
        Me.Ctl_txt_rep = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_mail = New Ctl_txt.ctl_txt_mail
        Me.grp_proveedor = New System.Windows.Forms.GroupBox
        Me.Ctl_txt_cell = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_repFono = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_fax = New Ctl_txt.ctl_txt_letras
        Me.Ctl_txt_profono = New Ctl_txt.ctl_txt_letras
        Me.btn_reportes = New System.Windows.Forms.Button
        CType(Me.dgrd_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_proveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.Location = New System.Drawing.Point(221, 31)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(80, 24)
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
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.Location = New System.Drawing.Point(565, 31)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(86, 24)
        Me.btn_Salir.TabIndex = 6
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_Eliminar.Image = CType(resources.GetObject("btn_Eliminar.Image"), System.Drawing.Image)
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.Location = New System.Drawing.Point(389, 31)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.Location = New System.Drawing.Point(305, 31)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(80, 24)
        Me.btn_Aceptar.TabIndex = 3
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'dgrd_proveedor
        '
        Me.dgrd_proveedor.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgrd_proveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.dgrd_proveedor.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrd_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgrd_proveedor.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dgrd_proveedor.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_proveedor.CaptionText = "PROVEEDORES"
        Me.dgrd_proveedor.DataMember = ""
        Me.dgrd_proveedor.FlatMode = True
        Me.dgrd_proveedor.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgrd_proveedor.ForeColor = System.Drawing.Color.Black
        Me.dgrd_proveedor.GridLineColor = System.Drawing.Color.DimGray
        Me.dgrd_proveedor.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgrd_proveedor.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_proveedor.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgrd_proveedor.HeaderForeColor = System.Drawing.Color.White
        Me.dgrd_proveedor.LinkColor = System.Drawing.Color.MidnightBlue
        Me.dgrd_proveedor.Location = New System.Drawing.Point(13, 289)
        Me.dgrd_proveedor.Name = "dgrd_proveedor"
        Me.dgrd_proveedor.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.dgrd_proveedor.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgrd_proveedor.ReadOnly = True
        Me.dgrd_proveedor.RowHeaderWidth = 10
        Me.dgrd_proveedor.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dgrd_proveedor.SelectionForeColor = System.Drawing.Color.White
        Me.dgrd_proveedor.Size = New System.Drawing.Size(638, 219)
        Me.dgrd_proveedor.TabIndex = 1
        Me.dgrd_proveedor.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DataGridTableStyle1.DataGrid = Me.dgrd_proveedor
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridTableStyle1.MappingName = "Registros"
        Me.DataGridTableStyle1.RowHeaderWidth = 10
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "i_pro_id"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridTextBoxColumn2.MappingName = "i_pro_nombre"
        Me.DataGridTextBoxColumn2.Width = 195
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "DIRECCION"
        Me.DataGridTextBoxColumn3.MappingName = "i_pro_direccion"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "TELEFONO"
        Me.DataGridTextBoxColumn4.MappingName = "i_pro_fono"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "FAX"
        Me.DataGridTextBoxColumn5.MappingName = "i_pro_fax"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "E-MAIL"
        Me.DataGridTextBoxColumn6.MappingName = "i_pro_mail"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "REPRESENTANTE"
        Me.DataGridTextBoxColumn7.MappingName = "i_pro_rep_nombre"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 95
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "FONO REP."
        Me.DataGridTextBoxColumn8.MappingName = "i_pro_rep_fono"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "CELULAR"
        Me.DataGridTextBoxColumn9.MappingName = "i_pro_rep_Cell"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'lbl_codigo
        '
        Me.lbl_codigo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_codigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.ForeColor = System.Drawing.Color.Black
        Me.lbl_codigo.Location = New System.Drawing.Point(14, 22)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(74, 18)
        Me.lbl_codigo.TabIndex = 37
        Me.lbl_codigo.Text = "Código:"
        '
        'Ctl_txt_id
        '
        Me.Ctl_txt_id.Enabled = False
        Me.Ctl_txt_id.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_id.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_id.Location = New System.Drawing.Point(106, 22)
        Me.Ctl_txt_id.Name = "Ctl_txt_id"
        Me.Ctl_txt_id.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_id.Prp_CaracterPasswd = ""
        Me.Ctl_txt_id.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_id.Size = New System.Drawing.Size(139, 20)
        Me.Ctl_txt_id.TabIndex = 1
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_Nombre.Location = New System.Drawing.Point(14, 46)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(74, 18)
        Me.lbl_Nombre.TabIndex = 39
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_dir
        '
        Me.lbl_dir.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dir.ForeColor = System.Drawing.Color.Black
        Me.lbl_dir.Location = New System.Drawing.Point(14, 74)
        Me.lbl_dir.Name = "lbl_dir"
        Me.lbl_dir.Size = New System.Drawing.Size(74, 18)
        Me.lbl_dir.TabIndex = 40
        Me.lbl_dir.Text = "Dirección:"
        '
        'lbl_fono
        '
        Me.lbl_fono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono.ForeColor = System.Drawing.Color.Black
        Me.lbl_fono.Location = New System.Drawing.Point(12, 96)
        Me.lbl_fono.Name = "lbl_fono"
        Me.lbl_fono.Size = New System.Drawing.Size(74, 18)
        Me.lbl_fono.TabIndex = 41
        Me.lbl_fono.Text = "Teléfono:"
        '
        'lbl_fax
        '
        Me.lbl_fax.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fax.ForeColor = System.Drawing.Color.Black
        Me.lbl_fax.Location = New System.Drawing.Point(275, 98)
        Me.lbl_fax.Name = "lbl_fax"
        Me.lbl_fax.Size = New System.Drawing.Size(42, 18)
        Me.lbl_fax.TabIndex = 42
        Me.lbl_fax.Text = "Fax:"
        '
        'lbl_email
        '
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.Black
        Me.lbl_email.Location = New System.Drawing.Point(12, 122)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(74, 18)
        Me.lbl_email.TabIndex = 43
        Me.lbl_email.Text = "E-mail:"
        '
        'lbl_Rep
        '
        Me.lbl_Rep.AutoSize = True
        Me.lbl_Rep.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Rep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Rep.ForeColor = System.Drawing.Color.Black
        Me.lbl_Rep.Location = New System.Drawing.Point(12, 148)
        Me.lbl_Rep.Name = "lbl_Rep"
        Me.lbl_Rep.Size = New System.Drawing.Size(92, 13)
        Me.lbl_Rep.TabIndex = 44
        Me.lbl_Rep.Text = "Representante"
        '
        'lbl_fono_rep
        '
        Me.lbl_fono_rep.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fono_rep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fono_rep.ForeColor = System.Drawing.Color.Black
        Me.lbl_fono_rep.Location = New System.Drawing.Point(12, 172)
        Me.lbl_fono_rep.Name = "lbl_fono_rep"
        Me.lbl_fono_rep.Size = New System.Drawing.Size(74, 18)
        Me.lbl_fono_rep.TabIndex = 45
        Me.lbl_fono_rep.Text = "Teléfono: "
        '
        'lbl_cell_fono
        '
        Me.lbl_cell_fono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cell_fono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cell_fono.ForeColor = System.Drawing.Color.Black
        Me.lbl_cell_fono.Location = New System.Drawing.Point(273, 172)
        Me.lbl_cell_fono.Name = "lbl_cell_fono"
        Me.lbl_cell_fono.Size = New System.Drawing.Size(53, 18)
        Me.lbl_cell_fono.TabIndex = 46
        Me.lbl_cell_fono.Text = "Celular:"
        '
        'Ctl_txt_nombre
        '
        Me.Ctl_txt_nombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_nombre.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_nombre.Location = New System.Drawing.Point(106, 46)
        Me.Ctl_txt_nombre.Name = "Ctl_txt_nombre"
        Me.Ctl_txt_nombre.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_nombre.Prp_CaracterPasswd = ""
        Me.Ctl_txt_nombre.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_nombre.Size = New System.Drawing.Size(364, 20)
        Me.Ctl_txt_nombre.TabIndex = 2
        '
        'txt_dir
        '
        Me.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dir.Location = New System.Drawing.Point(106, 70)
        Me.txt_dir.MaxLength = 150
        Me.txt_dir.Multiline = True
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(364, 22)
        Me.txt_dir.TabIndex = 3
        '
        'Ctl_txt_rep
        '
        Me.Ctl_txt_rep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_rep.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_rep.Location = New System.Drawing.Point(106, 144)
        Me.Ctl_txt_rep.Name = "Ctl_txt_rep"
        Me.Ctl_txt_rep.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_rep.Prp_CaracterPasswd = ""
        Me.Ctl_txt_rep.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_rep.Size = New System.Drawing.Size(364, 20)
        Me.Ctl_txt_rep.TabIndex = 7
        '
        'Ctl_txt_mail
        '
        Me.Ctl_txt_mail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_mail.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_mail.Location = New System.Drawing.Point(106, 120)
        Me.Ctl_txt_mail.Name = "Ctl_txt_mail"
        Me.Ctl_txt_mail.Size = New System.Drawing.Size(364, 20)
        Me.Ctl_txt_mail.TabIndex = 6
        '
        'grp_proveedor
        '
        Me.grp_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_cell)
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_repFono)
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_fax)
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_profono)
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_nombre)
        Me.grp_proveedor.Controls.Add(Me.lbl_Rep)
        Me.grp_proveedor.Controls.Add(Me.lbl_Nombre)
        Me.grp_proveedor.Controls.Add(Me.lbl_cell_fono)
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_id)
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_rep)
        Me.grp_proveedor.Controls.Add(Me.lbl_dir)
        Me.grp_proveedor.Controls.Add(Me.lbl_fono)
        Me.grp_proveedor.Controls.Add(Me.txt_dir)
        Me.grp_proveedor.Controls.Add(Me.Ctl_txt_mail)
        Me.grp_proveedor.Controls.Add(Me.lbl_fax)
        Me.grp_proveedor.Controls.Add(Me.lbl_codigo)
        Me.grp_proveedor.Controls.Add(Me.lbl_fono_rep)
        Me.grp_proveedor.Controls.Add(Me.lbl_email)
        Me.grp_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_proveedor.ForeColor = System.Drawing.Color.Navy
        Me.grp_proveedor.Location = New System.Drawing.Point(12, 77)
        Me.grp_proveedor.Name = "grp_proveedor"
        Me.grp_proveedor.Size = New System.Drawing.Size(639, 206)
        Me.grp_proveedor.TabIndex = 0
        Me.grp_proveedor.TabStop = False
        Me.grp_proveedor.Text = "Datos:"
        '
        'Ctl_txt_cell
        '
        Me.Ctl_txt_cell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_cell.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_cell.Location = New System.Drawing.Point(332, 170)
        Me.Ctl_txt_cell.Name = "Ctl_txt_cell"
        Me.Ctl_txt_cell.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_cell.Prp_CaracterPasswd = ""
        Me.Ctl_txt_cell.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_cell.Size = New System.Drawing.Size(138, 20)
        Me.Ctl_txt_cell.TabIndex = 9
        '
        'Ctl_txt_repFono
        '
        Me.Ctl_txt_repFono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_repFono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_repFono.Location = New System.Drawing.Point(106, 170)
        Me.Ctl_txt_repFono.Name = "Ctl_txt_repFono"
        Me.Ctl_txt_repFono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_repFono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_repFono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_repFono.Size = New System.Drawing.Size(138, 20)
        Me.Ctl_txt_repFono.TabIndex = 8
        '
        'Ctl_txt_fax
        '
        Me.Ctl_txt_fax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_fax.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_fax.Location = New System.Drawing.Point(330, 96)
        Me.Ctl_txt_fax.Name = "Ctl_txt_fax"
        Me.Ctl_txt_fax.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_fax.Prp_CaracterPasswd = ""
        Me.Ctl_txt_fax.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_fax.Size = New System.Drawing.Size(140, 20)
        Me.Ctl_txt_fax.TabIndex = 5
        '
        'Ctl_txt_profono
        '
        Me.Ctl_txt_profono.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctl_txt_profono.ForeColor = System.Drawing.Color.Black
        Me.Ctl_txt_profono.Location = New System.Drawing.Point(106, 96)
        Me.Ctl_txt_profono.Name = "Ctl_txt_profono"
        Me.Ctl_txt_profono.Prp_CaracterEspecial = New String() {"'"}
        Me.Ctl_txt_profono.Prp_CaracterPasswd = ""
        Me.Ctl_txt_profono.Prp_TipoLetra = Ctl_txt.ctl_txt_letras.ValoresTipoLetra.Independiente
        Me.Ctl_txt_profono.Size = New System.Drawing.Size(138, 20)
        Me.Ctl_txt_profono.TabIndex = 4
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reportes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reportes.ForeColor = System.Drawing.Color.Black
        Me.btn_reportes.Image = CType(resources.GetObject("btn_reportes.Image"), System.Drawing.Image)
        Me.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reportes.Location = New System.Drawing.Point(475, 31)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(86, 24)
        Me.btn_reportes.TabIndex = 5
        Me.btn_reportes.Text = "Imprimir"
        Me.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reportes.UseVisualStyleBackColor = False
        '
        'frm_i_Proveedor
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(663, 520)
        Me.Controls.Add(Me.btn_reportes)
        Me.Controls.Add(Me.grp_proveedor)
        Me.Controls.Add(Me.dgrd_proveedor)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_i_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor"
        CType(Me.dgrd_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_proveedor.ResumeLayout(False)
        Me.grp_proveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Código de Formulario"
    Private mouse_offset As Point
    Dim dbl_x As Double
    Dim frm_refer_main_form As Frm_Main
    Private m_HtImages As New Hashtable()
    Dim imageToDraw As Image

    Private Sub Formulario_Ubica(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = frm_refer_main_form.mdiClient1.MousePosition
            frm_refer_main_form.limpiaGrp()
            Me.SetDesktopLocation(mousePos.X - frm_refer_main_form.Splitter.Width - (mousePos.X - dbl_x), mousePos.Y)
        End If
    End Sub

    Private Sub Formulario_Mueve(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ClickMenu_Principal(Me)
        'Función para cuando se presiona en la barra de superior del form, esto ayuda a su movimiento.
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

    Private Sub Formulario_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Función para cuando se presiona en la barra de superior del form, ubica el mouse en cierta posici{on.
        mouse_offset = New Point(-e.X, -e.Y)
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        frm_refer_main_form.ubica(Me.Width, Me.Height, Me.Top, Me.Left)
    End Sub

    Private Sub Boton_Enfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseEnter, btn_Nuevo.MouseEnter, btn_Eliminar.MouseEnter, btn_Salir.MouseEnter, btn_reportes.MouseEnter
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

    Private Sub Boton_SinEnfoque(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.MouseLeave, btn_Eliminar.MouseLeave, btn_Nuevo.MouseLeave, btn_Salir.MouseLeave, btn_reportes.MouseLeave
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

    Private Sub Formulario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
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

    Dim boo_flag As Boolean
    Dim opr_i_proveedor As New Cls_i_Proveedor()
    Dim opr_negocio As New Cls_Pedido

    Private Sub frm_i_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(frm_refer_main_form) Then frm_refer_main_form = Me.ParentForm
        Ctl_txt_id.txt_padre.MaxLength = 15
        Ctl_txt_nombre.txt_padre.MaxLength = 100
        Ctl_txt_mail.txt_padre.MaxLength = 50
        Ctl_txt_profono.txt_padre.MaxLength = 30
        Ctl_txt_fax.txt_padre.MaxLength = 30
        Ctl_txt_rep.txt_padre.MaxLength = 100
        Ctl_txt_repFono.txt_padre.MaxLength = 30
        Ctl_txt_cell.txt_padre.MaxLength = 30
        dgrd_proveedor.SetDataBinding(opr_i_proveedor.LeerProveedor(), "Registros")
        grp_proveedor.Enabled = False
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        btn_Nuevo.Focus()
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        grp_proveedor.Enabled = True
        limpiarCampos()
        'Ctl_txt_id.Enabled = True
        Ctl_txt_nombre.Focus()
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = False
        boo_flag = True
    End Sub


    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click

        ''If (Ctl_txt_id.texto_Recupera = "") Then
        ''    '''MsgBox("Ingrese el código del proveedor", MsgBoxStyle.Information, "ANALISYS")
        ''    opr_negocio.VisualizaMensaje("Ingrese el código del proveedor, ingrese otro", g_tiempo)
        ''    Ctl_txt_id.Focus()
        ''    Exit Sub
        ''End If

        If (Ctl_txt_nombre.texto_Recupera = "") Then
            '''MsgBox("Ingrese el nombre del proveedor", MsgBoxStyle.Information, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese el nombre del proveedor", g_tiempo)
            Ctl_txt_nombre.Focus()
            Exit Sub
        End If

        If (txt_dir.Text = "") Then
            '''MsgBox("Ingrese la dirección del proveedor", MsgBoxStyle.Information, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese la dirección del proveedor", g_tiempo)
            txt_dir.Focus()
            Exit Sub
        End If

        If (Ctl_txt_profono.texto_Recupera = "") Then
            '''MsgBox("Ingrese el teléfono del proveedor", MsgBoxStyle.Information, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese el teléfono del proveedor", g_tiempo)
            Ctl_txt_profono.Focus()
            Exit Sub
        End If

        If (Ctl_txt_rep.texto_Recupera = "") Then
            '''MsgBox("Ingrese el representante del proveedor", MsgBoxStyle.Information, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese el representante del proveedor", g_tiempo)
            Ctl_txt_rep.Focus()
            Exit Sub
        End If

        If (Ctl_txt_repFono.texto_Recupera = "") Then
            '''MsgBox("Ingrese el teléfono del representante", MsgBoxStyle.Information, "ANALISYS")
            opr_negocio.VisualizaMensaje("Ingrese el teléfono del representante", g_tiempo)
            Ctl_txt_repFono.Focus()
            Exit Sub
        End If

        'Verifico que no exista otra producto con el mismo código
        ' ''If (opr_i_proveedor.BuscarProveedor(Ctl_txt_id.texto_Recupera) = True And boo_flag = True) Then
        ' ''    '''MsgBox("El código ingresado ya existe, ingrese otro", MsgBoxStyle.Exclamation, "ANALISYS")
        ' ''    opr_negocio.VisualizaMensaje("El código ingresado ya existe, ingrese otro", g_tiempo)
        ' ''    Ctl_txt_id.Focus()
        ' ''    Exit Sub
        ' ''End If

        If boo_flag = True Then    '*** Si se trata de un nuevo PROVEEDOR
            opr_i_proveedor.GuardarProveedor(opr_i_proveedor.LeerMaxIdProv(), Ctl_txt_nombre.texto_Recupera, txt_dir.Text, _
            Ctl_txt_profono.texto_Recupera, Ctl_txt_fax.texto_Recupera.ToString, Ctl_txt_mail.texto_Recupera.ToString, _
            Ctl_txt_rep.texto_Recupera.ToString, Ctl_txt_repFono.texto_Recupera.ToString, Ctl_txt_cell.texto_Recupera)
        Else    '*** Si se trata de una actualización a una AREA 
            Dim obj_res As Object
            obj_res = MsgBox("¿Desea actualizar los datos?", MsgBoxStyle.YesNo, "ANALISYS")
            If (obj_res = vbYes) Then

                opr_i_proveedor.ActualizarProveedor(Ctl_txt_id.texto_Recupera, Ctl_txt_nombre.texto_Recupera, txt_dir.Text, _
            Ctl_txt_profono.texto_Recupera, Ctl_txt_fax.texto_Recupera.ToString, Ctl_txt_mail.texto_Recupera.ToString, _
            Ctl_txt_rep.texto_Recupera.ToString, Ctl_txt_repFono.texto_Recupera.ToString, Ctl_txt_cell.texto_Recupera, Ctl_txt_id.Tag)
            Else
                Call limpiarCampos()
                grp_proveedor.Enabled = False
                btn_Aceptar.Enabled = False
                btn_Eliminar.Enabled = False
                btn_Nuevo.Focus()
                Exit Sub
            End If
        End If
        dgrd_proveedor.SetDataBinding(opr_i_proveedor.LeerProveedor(), "Registros")
        Call limpiarCampos()
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_proveedor.Enabled = False
        Ctl_txt_id.Enabled = True
        btn_Nuevo.Focus()
    End Sub

    Public Sub limpiarCampos()
        Ctl_txt_id.texto_Asigna("")
        Ctl_txt_nombre.texto_Asigna("")
        txt_dir.Text = ""
        Ctl_txt_profono.texto_Asigna("")
        Ctl_txt_fax.texto_Asigna("")
        Ctl_txt_mail.texto_Asigna("")
        Ctl_txt_rep.texto_Asigna("")
        Ctl_txt_repFono.texto_Asigna("")
        Ctl_txt_cell.texto_Asigna("")
    End Sub


    Private Sub dgrd_proveedor_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrd_proveedor.CurrentCellChanged
        Call limpiarCampos()
        dgrd_proveedor.Select(dgrd_proveedor.CurrentCell.RowNumber)
        btn_Aceptar.Enabled = True
        btn_Eliminar.Enabled = True
        grp_proveedor.Enabled = True
        Ctl_txt_id.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 0))
        Ctl_txt_id.Tag = dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 0)
        'Ctl_txt_id.Enabled = False
        Ctl_txt_nombre.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 1))
        txt_dir.Text = dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 2).ToString
        Ctl_txt_profono.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 3).ToString)
        Ctl_txt_fax.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 4).ToString)
        Ctl_txt_mail.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 5).ToString)
        Ctl_txt_rep.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 6).ToString)
        Ctl_txt_repFono.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 7).ToString)
        Ctl_txt_cell.texto_Asigna(dgrd_proveedor.Item(dgrd_proveedor.CurrentCell.RowNumber, 8).ToString)
        boo_flag = False  'Para saber que se puede actualizar 
        Dim dgc_celda As DataGridCell
        dgc_celda.ColumnNumber = 2
        dgc_celda.RowNumber = dgrd_proveedor.CurrentCell.RowNumber
        dgrd_proveedor.CurrentCell = dgc_celda
        dgrd_proveedor.Select(dgrd_proveedor.CurrentCell.RowNumber)
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim obj_r As Object
        obj_r = MsgBox("¿Desea eliminar el proveedor seleccionado?", MsgBoxStyle.YesNo, "ANALISYS")
        If (obj_r = vbYes) Then
            Dim opr_i_producto As New Cls_i_Producto()
            opr_i_proveedor.EliminarProveedor(Ctl_txt_id.texto_Recupera)
            dgrd_proveedor.SetDataBinding(opr_i_proveedor.LeerProveedor(), "Registros")
        End If
        Call limpiarCampos()
        btn_Aceptar.Enabled = False
        btn_Eliminar.Enabled = False
        grp_proveedor.Enabled = False
    End Sub

    Private Sub btn_reportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reportes.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim obj_reporte As New rpt_I_Proveedor()
        str_sql = "SELECT I_PROVEEDOR.I_PRO_NOMBRE, I_PROVEEDOR.I_PRO_ID, I_PROVEEDOR.I_PRO_DIRECCION, I_PROVEEDOR.I_PRO_FONO, I_PROVEEDOR.I_PRO_FAX, I_PROVEEDOR.I_PRO_MAIL, I_PROVEEDOR.I_PRO_REP_NOMBRE, I_PROVEEDOR.I_PRO_REP_FONO, I_PROVEEDOR.I_PRO_REP_CELL FROM I_PROVEEDOR order by I_PROVEEDOR.I_PRO_NOMBRE"
        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte)
        frm_MDIChild.int_alto = frm_refer_main_form.mdiClient1.Height
        frm_MDIChild.int_ancho = frm_refer_main_form.mdiClient1.Width
        frm_MDIChild.Text = "Consulta de Proveedores"
        frm_refer_main_form.Crea_formulario(frm_MDIChild)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub


End Class
