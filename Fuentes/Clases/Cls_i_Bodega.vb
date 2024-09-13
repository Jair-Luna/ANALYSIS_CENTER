'*************************************************************************
' Nombre:   Cls_i_Bodega
' Tipo de Archivo: clase
' Descripción:  Clase para la manipulacion de bodegas
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient



Public Class Cls_i_Bodega

    Public Sub LlenarCmbBodega(ByRef cmb_bodega As ComboBox)
        'Funcion para la Llenar un combo con todas las bodegas.
        On Error Resume Next
        Dim dts_bodega As DataSet
        Dim dtr_fila As DataRow
        dts_bodega = LeerBodega(g_division)
        For Each dtr_fila In dts_bodega.Tables("Registros").Rows
            cmb_bodega.Items.Add(dtr_fila("i_bod_descripcion").ToString().PadRight(100) & dtr_fila("i_bod_id").PadRight(15).ToString)
        Next
        cmb_bodega.SelectedIndex = 0
    End Sub

    Public Function LeerBodega(ByVal div_id As Byte) As DataSet
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        If div_id <> 0 Then   'Cuando es Médica o diagnóstica
            oda_operacion.SelectCommand = New SqlCommand("Select i_bod_id,  i_bod_descripcion, div_nombre from i_bodega, division where i_bodega.div_id =  division.div_id and i_bodega.div_id = " & div_id & " ORDER BY i_bod_id", cls_operacion.conn_sql)
        Else    'Cuando es Médica
            oda_operacion.SelectCommand = New SqlCommand("Select i_bod_id,  i_bod_descripcion, div_nombre from i_bodega, division where i_bodega.div_id =  division.div_id ORDER BY i_bod_id", cls_operacion.conn_sql)
        End If
        LeerBodega = New DataSet()
        oda_operacion.Fill(LeerBodega, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Bodega", Err)
        Err.Clear()
    End Function


    Public Sub EliminaBodega(ByVal i_bod_id As String)
        'funcion que permite la eliminacion de una bodega recibe el codigo de la bodega
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim cls_operacion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        cls_operacion.sql_conectar()
        STR_SQL = "Delete from i_bodega where i_bod_id = '" & i_bod_id & "'"
        odc_operacion = New SqlCommand(STR_SQL, cls_operacion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        cls_operacion.sql_desconn()
        MsgBox("Bodega eliminada", MsgBoxStyle.Information, "ANALISYS")
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Bodega", "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Eliminar Bodega", Err)
        Err.Clear()
    End Sub

    Sub LlenarGridBodega(ByRef dts_Bodega As DataSet, ByRef dgrd_Bodega As DataGrid, ByVal g_division As Byte)
        'funcion que me permite llenar los de bodegas en un grid
        On Error Resume Next
        Dim dtv_Bodega As New DataView()
        dts_Bodega = LeerBodega(g_division)
        With dtv_Bodega
            .Table = dts_Bodega.Tables("Registros")
            .AllowDelete = True
            .AllowEdit = True
            .AllowNew = True
        End With
        dgrd_Bodega.DataSource = dtv_Bodega
        dgrd_Bodega.NavigateTo(0, "Registros")
        dgrd_Bodega.CaptionText = "BODEGAS"
    End Sub

    Public Function GuardarBodega(ByVal dts_Bodega As DataSet, ByVal boo_mensaje As Boolean) As Boolean
        'funcion que me permite la guardar los datos de una bodega
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        GuardarBodega = False
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim int_i As Integer
        For int_i = 0 To dts_Bodega.Tables("registros").Rows.Count() - 1
            If dts_Bodega.Tables("registros").Rows(int_i).Item(2).ToString = "" Then
                STR_SQL = "insert into i_bodega(i_bod_id, i_bod_descripcion, lab_id, div_id) values('" & dts_Bodega.Tables("registros").Rows(int_i).Item(0) & "','" & _
                dts_Bodega.Tables("registros").Rows(int_i).Item(1) & "'," & g_division & ", " & g_division & ")"
            Else
                STR_SQL = "Update i_bodega set i_bod_id='" & dts_Bodega.Tables("registros").Rows(int_i).Item(0) & "' , i_bod_descripcion='" & dts_Bodega.Tables("registros").Rows(int_i).Item(1) & "' " & _
                " where i_bod_id='" & dts_Bodega.Tables("registros").Rows(int_i).Item(0) & "'"
            End If
            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            g_opr_usuario.CargarTransaccion(g_str_login, "Guardar Bodega", "")
        Next
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        GuardarBodega = True
        If boo_mensaje Then MsgBox("Datos Almacenados", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Guardar Bodega", Err)
        Err.Clear()
    End Function

    Public Function BuscarLab(ByVal lab_nombre As String) As Single
        'funcion que me permite obtener el codigo de un laboratorio recibe el nombre del laboratorio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_operacion As DataRow
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select lab_id from laboratorio where lab_nombre='" & lab_nombre & "'", opr_Conexion.conn_sql)
        Dim dts_lab As New DataSet()
        oda_operacion.Fill(dts_lab, "Registros")
        dtr_operacion = dts_lab.Tables(0).Rows(0)
        If IsDBNull(dtr_operacion(0)) Then
            BuscarLab = 1
        Else
            BuscarLab = dtr_operacion(0)
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Buscar Laboratorio", Err)
        Err.Clear()
    End Function

    Sub LlenarCombodivision(ByRef cmb_divisiones As ComboBox)
        'funcion que me permite llenar un combo con los datos de la division
        'Procedimiento para la Llenar un combo con todos los Equipos (Nombre y Código)
        Dim arr_eqp As New ArrayList()
        arr_eqp = Leerdivision()
        Dim i As Short
        For i = 0 To arr_eqp.Count - 1
            cmb_divisiones.Items.Add(arr_eqp.Item(i))
        Next
        cmb_divisiones.SelectedIndex = 0
    End Sub

    Sub LlenarComboBodega(ByRef cmb_bodega As ComboBox, Optional ByVal div_id As Short = 0)
        'funcion que me permite llenar un combo con los datos de una bodega
        On Error Resume Next
        Dim dts_medico As DataSet
        Dim dtr_fila As DataRow
        dts_medico = LeerBodega(div_id)
        cmb_bodega.Items.Clear()
        For Each dtr_fila In dts_medico.Tables("Registros").Rows
            'cmb_bodega.Items.Add(dtr_fila("I_BOD_ID").ToString().PadRight(15) & " " & Mid(dtr_fila("I_BOD_DESCRIPCION").ToString(), 1, 25).PadRight(20))
            cmb_bodega.Items.Add(dtr_fila("i_bod_descripcion").ToString().PadRight(100) & dtr_fila("i_bod_id").ToString().PadRight(15))
        Next
        'cmb_bodega.SelectedIndex = 0
    End Sub
    '    Sub LlenarComboBodega1(ByVal div_id As Short, ByRef cmb_bodega As ComboBox)
    '        'funcion que me permite llenar un combo con los datos de una bodega
    '        On Error GoTo MsgError
    '        Dim opr_conexion As New Cls_Conexion()
    '        opr_Conexion.conn_sql()
    '        cmb_bodega.Items.Clear()
    '        Dim odr_trabajo As SqlDataReader = New SqlCommand("select i_bod_descripcion from i_bodega where lab_id = " & div_id & " ", opr_Conexion.conn_sql).ExecuteReader
    '        While odr_trabajo.Read
    '            cmb_bodega.Items.Add(odr_trabajo.GetValue(0))
    '            'cmb_bodega.SelectedIndex = 0
    '        End While
    '        opr_conexion.sql_desconn
    '        Exit Sub
    'MsgError:
    '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Llenar CmbEquipos", Err)
    '        Err.Clear()
    '    End Sub

    Public Function Leerdivision() As ArrayList
        'Funcion para la consultar los datos de la tabla EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        STR_SQL = "Select div_nombre, div_id from division"
        Leerdivision = New ArrayList()
        Leerdivision.Clear()
        opr_Conexion.sql_conectar()
        Dim oda_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_Conexion.conn_sql).ExecuteReader
        While oda_operacion.Read
            Leerdivision.Add(oda_operacion.GetValue(0).ToString.PadRight(20) & oda_operacion.GetValue(1).ToString.PadRight(5))
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, leer division", Err)
        Err.Clear()
    End Function

    Sub LlenarListaDivisiones(ByRef chkl_areas As CheckedListBox)
        'funcion que llena en un lista las areas
        On Error Resume Next
        Dim dts_area As DataSet
        Dim dtr_fila As DataRow
        Dim int_i As Integer
        Dim sng_flag As Single
        dts_area = LeerDivisiones()
        chkl_areas.Items.Clear()
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            chkl_areas.Items.Add(dtr_fila("div_nombre").ToString().PadRight(150) & dtr_fila("div_id").ToString(), False)
        Next
    End Sub

    Public Function LeerDivisiones() As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("SELECT DIV_ID, DIV_NOMBRE FROM DIVISION ORDER BY DIV_NOMBRE ASC;", opr_Conexion.conn_sql)
        LeerDivisiones = New DataSet()
        oda_operacion.Fill(LeerDivisiones, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Divisiones", Err)
        Err.Clear()
    End Function

    Public Function LeerDivisionesUsuario(ByVal usu_id As Single, ByRef arr_datos As ArrayList, Optional ByRef arr_nombre As ArrayList = Nothing)
        'funcion que retorna en un dataset las areas a las que pertenece un usuario
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_menu As SqlDataReader = New SqlCommand("Select division.div_id, division.div_nombre from usuario_division, division where usuario_division.div_id = division.div_id and usuario_division.usu_id=" & usu_id, opr_Conexion.conn_sql).ExecuteReader
        While odr_menu.Read
            arr_datos.Add(odr_menu.GetValue(0))
            If Not (arr_nombre Is Nothing) Then arr_nombre.Add(odr_menu.GetValue(1))
        End While
        odr_menu.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, LeerDivisionesUsuario", Err)
        Err.Clear()
    End Function
End Class
