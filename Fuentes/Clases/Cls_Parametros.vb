'*************************************************************************
' Nombre:   Cls_Parametros
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra las tablas UNIDAD, TIPOMUESTRA, TIPOTUBO
' Autores:  RFN
' Fecha de Creaci�n: Julio del 2002
' Autores Modificaciones: 
' Ultima Modificaci�n: 17/07/2002
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Parametros

    Public Function LeerUnidades() As DataSet
        'Funcion para la consultar los datos de la tabla unidad
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select UNI_ID AS CODIGO, UNI_NOMENCLATURA AS NOMENCLATURA, UNI_TIPO AS SISTEMA from UNIDAD where uni_id <> 0 order by uni_id", opr_Conexion.conn_sql)
        LeerUnidades = New DataSet("UNIDADES")
        oda_operacion.Fill(LeerUnidades, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Unidades", Err)
        Err.Clear()
    End Function

    Public Function LeerUnidadesCmb(ByVal parametro As Short) As DataSet
        'Funcion para la consultar los datos de la tabla unidad
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        If parametro = 1 Then
            str_sql = "select * from UNIDAD where uni_id <> 0 order by uni_id"
        Else
            str_sql = "select * from UNIDAD order by uni_id"
        End If
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerUnidadesCmb = New DataSet("UNIDADES")
        oda_operacion.Fill(LeerUnidadesCmb, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Unidades", Err)
        Err.Clear()
    End Function

    Public Function LeerTiposTubos() As DataSet
        'Funcion para la consultar los datos de la tabla TIPOTUBO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select tit_id, tit_nombre , tit_tipo , tit_Obs From TIPO_TUBO order by tit_nombre", opr_Conexion.conn_sql)
        LeerTiposTubos = New DataSet("TIPOS DE TUBOS")
        oda_operacion.Fill(LeerTiposTubos, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Tipos Tubos", Err)
        Err.Clear()
    End Function

    Public Function LeerTiposMuestras() As DataSet
        'Funcion para la consultar los datos de la tabla TIPOMUESTRA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from TIPO_MUESTRA order by tim_id", opr_Conexion.conn_sql)
        LeerTiposMuestras = New DataSet("TIPOS DE MUESTRAS")
        oda_operacion.Fill(LeerTiposMuestras, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Tipo de Muestras", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodTipTubo() As Integer
        'Funcion para la consultar el c�digo m�ximo del tipo de tubo 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodTipTubo = CInt(New SqlCommand("Select isnull(Max(tit_id),0) from TIPO_TUBO", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer max codtip tubo", Err)
        Err.Clear()
    End Function

    Public Sub GuardarTipoTubo(ByVal tubId As Integer, ByVal TubNom As String, _
                               ByVal tubObs As String, ByVal tubTipo As String)
        'Procedimiento para la insertar un registro en la tabla TIPO_TUBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Insert into TIPO_TUBO values (" & tubId & ", '" & TubNom & "', '" & tubObs & "', '" & tubTipo & "')", opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Recipiente", "Recipiente=" & TubNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Tipo Tubo", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarTipoTubos(ByVal TubCod As Integer, ByVal TubNom As String, _
                                ByVal TubObs As String, ByVal tubTipo As String)
        'Procedimiento para la actualizar un registro en la tabla TIPOTUBO
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Update TIPO_TUBO set tit_Nombre = '" & TubNom & "', tit_obs = '" & TubObs & "', tit_tipo = '" & tubTipo & "' where tit_id = " & TubCod & "", opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Recipiente", "Recipiente= '" & TubNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Tipo Tubos", Err)
        Err.Clear()
    End Sub

    Public Function LeerMaxCodTipMuestra() As Integer
        'Funcion para la consultar el c�digo m�ximo del tipo de tubo 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodTipMuestra = CInt(New SqlCommand("Select isnull(Max(Tim_id),0) from TIPO_MUESTRA", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodTip Muestra", Err)
        Err.Clear()
    End Function

    Public Sub GuardarTipoMuestra(ByVal MueCodigo As Integer, ByVal MueNom As String, _
                                ByVal MueObs As String, ByVal tit_id As Integer)
        'Procedimiento para la insertar un registro en la tabla TIPOMUESTRA
        On Error GoTo MsgError

        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Insert into TIPO_MUESTRA values (" & MueCodigo & ", '" & MueNom & "', '" & MueObs & "', " & tit_id & ")", opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Tipo Muestra", "Muestra=" & MueNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Tipo Muestra", Err)
        Err.Clear()
    End Sub

    Public Function BuscarUnidad(ByVal uni_nomenclatura As String) As Boolean
        'Funci�n para consultar si existe el nombre de una unidad antes de insertar otra igual 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from UNIDAD where uni_nomenclatura = '" & uni_nomenclatura & "'", opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_act, "Registros")
        For Each dtr_fila In dts_act.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarUnidad = False
            Else
                BuscarUnidad = True
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Buscar Unidad", Err)
        Err.Clear()
    End Function

    Public Function BuscarTipMuestra(ByVal tim_nombre As String) As Boolean
        'Funci�n para consultar si existe el nombre de un tipo de muestra antes de insertar otro igual 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from TIPO_MUESTRA where tim_nombre = '" & tim_nombre & "'", opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_act, "Registros")
        For Each dtr_fila In dts_act.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarTipMuestra = False
            Else
                BuscarTipMuestra = True
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar Tip Muestra", Err)
        Err.Clear()
    End Function

    Public Sub ActualizarTipoMuestra(ByVal MueCod As Integer, ByVal MueNom As String, _
                                      ByVal MueDes As String, ByVal tit_id As Integer)
        'Procedimiento para la actualizar un registro en la tabla TIPOMUESTRA
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Update TIPO_MUESTRA set tim_Nombre = '" & _
                                      MueNom & "', tim_Obs ='" & _
                                      MueDes & "', tit_id = " & tit_id & " where tim_id = " & MueCod & "", opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza Tipo Muestra", "Muestra=" & MueNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Tipo Muestra", Err)
        Err.Clear()
    End Sub

    Public Function codUnidad(ByVal uni_nomenclatura As String) As DataSet
        'Funci�n que consulta y retorna el id de una unidad, recibiendo el nombre.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select uni_id from UNIDAD where uni_nomenclatura = '" & uni_nomenclatura & "'", opr_Conexion.conn_sql)
        codUnidad = New DataSet()
        oda_operacion.Fill(codUnidad, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Codigo Unidad", Err)
        Err.Clear()
    End Function

    Public Function VerificarEqui(ByVal uni_id1 As Integer, ByVal uni_id2 As Integer) As DataSet
        'Funci�n que consulta si existe alguna equivalencia ingresada entre las dos unidades enviadas
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select une_id from UNIDAD_EQUIVALENCIA where uni_id = " & uni_id1 & " and uni_uni_id = " & uni_id2 & " or uni_id = " & uni_id2 & " and uni_uni_id = " & uni_id1 & "", opr_Conexion.conn_sql)
        VerificarEqui = New DataSet()
        oda_operacion.Fill(VerificarEqui, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Verificar Equipo", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodUnidad() As Integer
        'Funcion para la consultar el c�digo m�ximo de la tabla unidad
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodUnidad = CInt(New SqlCommand("Select isnull(Max(uni_id),0) from UNIDAD", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max Codigo Unidad", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxCodUniEqui() As Integer
        'Funcion para la consultar el c�digo m�ximo de la tabla UNIDAD_EQUIVALENCIA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodUniEqui = CInt(New SqlCommand("Select isnull(Max(une_id),0) from UNIDAD_EQUIVALENCIA", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max CodUni Equipo", Err)
        Err.Clear()
    End Function

    Public Sub GuardarUnidad(ByVal uniCodigo As Integer, ByVal uniNom As String, _
                                   ByVal uniTipo As String)
        'Procedimiento para la insertar un registro en la tabla UNIDAD
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Insert into UNIDAD values (" & uniCodigo & ", '" & uniNom & "', '" & uniTipo & "' )", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nueva Unidad", "Insert into UNIDAD values (" & uniCodigo & ", '" & uniNom & "', '" & uniTipo & "' )")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Unidad", Err)
        Err.Clear()
    End Sub

    Public Sub GuardarUniEqui(ByVal uni_id1 As Integer, ByVal uni_id2 As Integer, _
                                   ByVal une_id As Integer, ByVal une_factor As Double)
        'Procedimiento para la insertar un registro en la tabla UNIDAD_EQUIVALENCIA
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Insert into UNIDAD_EQUIVALENCIA values (" & _
          une_id & ", " & uni_id1 & ", " & uni_id2 & ", " & _
          une_factor & ")", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nueva Equivalencia Unidad", "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Unidad Equipo", Err)
        Err.Clear()
    End Sub

    Public Sub Actualizarunidad(ByVal uniCodigo As Integer, ByVal uniNom As String, ByVal uniTipo As String)
        'Procedimiento para la actualizar un registro en la tabla UNIDAD
        On Error GoTo MsgError

        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Update UNIDAD set  uni_Nomenclatura = '" & _
                                      uniNom & "', uni_Tipo ='" & _
                                      uniTipo & "' where uni_id = " & _
                                      uniCodigo & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza Unidad", "Unidad=" & uniNom, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualiza Unidad", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarUniEqui(ByVal une_id As Integer, ByVal uni_id1 As Integer, ByVal uni_id2 As Integer, ByVal une_factor As Double)
        'Procedimiento para la actualizar un registro en la tabla UNIDAD_EQUIVALENCIA
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("Update UNIDAD_EQUIVALENCIA set  uni_id = " & _
                                      uni_id1 & ", uni_uni_id = " & _
                                      uni_id2 & ", une_factor = " & _
                                      une_factor & " where une_id = " & _
                                      une_id & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Equivalencia Unidad", "")
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitad", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarUnidad(ByVal uniCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla UNIDAD  
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("delete from UNIDAD where uni_id = " & uniCod & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Unidad", "Unidad=" & uniCod & "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Unidad", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarUniEqui(ByVal une_id As Integer)
        'Procedimiento para la eliminar un registro en la tabla UNIDAD_EQUIVALENCIA   
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("delete from UNIDAD_EQUIVALENCIA where une_id = " & une_id & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Equivalencia Unidad", "une_id = " & une_id & "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Unidad Equipo", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarTipoMuestra(ByVal mueCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla TIPOMUESTRA  
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("delete from TIPO_MUESTRA where tim_id = " & mueCod & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Tipo Muestra", "TIPO_MUESTRA= " & mueCod & "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar tipo muestra", Err)
        Err.Clear()
    End Sub

    Public Sub EliminarTipoTubo(ByVal tubCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla TIPOTUBO  
        On Error GoTo MsgError

        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("delete from TIPO_TUBO where tit_id = " & tubCod & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar Tipo Tubo", "TIPO_TUBO = " & tubCod, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Tipo Tubo", Err)
        Err.Clear()
    End Sub

    Public Function LeerUniEqui() As DataSet
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select une_id AS CODIGO, b.uni_nomenclatura AS UNIDAD1, a.une_factor AS FACTOR, c.uni_nomenclatura AS UNIDAD2 from UNIDAD_EQUIVALENCIA a, UNIDAD b, UNIDAD c where a.uni_id = b.uni_id and  a.uni_uni_id = c.uni_id ", opr_Conexion.conn_sql)
        LeerUniEqui = New DataSet("TABLA CONVERSION DE UNIDADES")
        oda_operacion.Fill(LeerUniEqui, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Unidad Equipo", Err)
        Err.Clear()
    End Function

    Public Sub LLenarCmbUnidad(ByRef cmb_Unidad As ComboBox)
        On Error Resume Next
        'Para llenar el combo de Unidades
        Dim dts_unidad As DataSet
        Dim dtr_filaUni As DataRow
        dts_unidad = LeerUnidadesCmb(1)
        For Each dtr_filaUni In dts_unidad.Tables("Registros").Rows
            cmb_Unidad.Items.Add(dtr_filaUni("uni_nomenclatura").ToString())
        Next
        cmb_Unidad.SelectedIndex = 0
    End Sub

    Public Sub LlenarCmb_UnidadC(ByRef cmb_unidad As ComboBox)
        'Procedimiento para la Llenar un combo con todos las Unidades y sus respectivos c�digos
        'Parametro 1 ->> No incluye la unidad 0 (No unidad)
        'Parametro 2 ->> Incluye Ninguna unidad para selecci�n en el combo
        On Error Resume Next
        cmb_unidad.Items.Clear()
        Dim dts_TipMue As DataSet
        Dim dtr_fila As DataRow
        dts_TipMue = LeerUnidadesCmb(2)
        cmb_unidad.Items.Add(dtr_fila("uni_nomenclatura").ToString().PadRight(50) & dtr_fila("uni_id").ToString().PadRight(5))
        For Each dtr_fila In dts_TipMue.Tables("Registros").Rows
            cmb_unidad.Items.Add(dtr_fila("uni_nomenclatura").ToString().PadRight(50) & dtr_fila("uni_id").ToString().PadRight(5))
        Next
        cmb_unidad.SelectedIndex = 0
    End Sub

    Public Sub LlenarCmb_TipMue(ByRef cmb_TipMue As ComboBox)
        'Procedimiento para llenar un combo con todos los Tipos de Muestras
        On Error Resume Next
        Dim dts_TipMue As DataSet
        Dim dtr_fila As DataRow
        dts_TipMue = LeerTiposMuestras()
        For Each dtr_fila In dts_TipMue.Tables("Registros").Rows
            cmb_TipMue.Items.Add(dtr_fila("tim_nombre").ToString())
        Next
        cmb_TipMue.SelectedIndex = 0
    End Sub

    Public Sub LlenarCmb_MuestraNC(ByRef cmb_TipMue As ComboBox)
        'Procedimiento para la Llenar un combo con todos los Tipos de Muestras (Nombre y C�digo)
        On Error Resume Next
        Dim dts_TipMue As DataSet
        Dim dtr_fila As DataRow
        dts_TipMue = LeerTiposMuestras()
        For Each dtr_fila In dts_TipMue.Tables("Registros").Rows
            cmb_TipMue.Items.Add(dtr_fila("tim_nombre").ToString().PadRight(50) & dtr_fila("tim_id").ToString().PadRight(5))
        Next
        cmb_TipMue.SelectedIndex = 0
    End Sub

    Public Sub LlenarCmb_TipTub(ByRef cmb_TipTub As ComboBox)
        'Procedimiento para la Llenar un combo con todos los Tipos de Muestras
        On Error Resume Next
        Dim dts_TipTub As DataSet
        Dim dtr_fila As DataRow
        dts_TipTub = LeerTiposTubos()
        For Each dtr_fila In dts_TipTub.Tables("Registros").Rows
            cmb_TipTub.Items.Add((dtr_fila("tit_nombre").ToString() & ", " & dtr_fila("tit_tipo").ToString).PadRight(50) & dtr_fila("tit_id").ToString().PadRight(5))
        Next
        cmb_TipTub.SelectedIndex = 0
    End Sub

    Public Function TipoMuestra_Id(ByVal TipMue_Nombre As String) As Integer
        'Funci�n que consulta el tim_id de un Tipo de muestra, enviando el nombre de la misma 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("Select tim_id from TIPO_MUESTRA where tim_nombre = '" & TipMue_Nombre & "'", opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        oda_operacion.Fill(dts_act, "Registros")
        Dim dtr_fila As DataRow
        For Each dtr_fila In dts_act.Tables("Registros").Rows
            TipoMuestra_Id = dtr_fila(0)
        Next
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Tipo MuestraID", Err)
        Err.Clear()
    End Function

    Sub LlenaChkListTipMue(ByRef chkl_TipMue As CheckedListBox)
        On Error Resume Next
        'Para llenar la lista de los tipos de muestra
        Dim dts_perfil As DataSet
        Dim dtr_filaPer As DataRow
        dts_perfil = LeerTiposMuestras()
        For Each dtr_filaPer In dts_perfil.Tables("Registros").Rows
            chkl_TipMue.Items.Insert(dtr_filaPer("tim_id").ToString - 1, dtr_filaPer("tim_nombre").ToString())
        Next
    End Sub

    Sub LlenaCmb_Resultado(ByRef cmb_Res As ComboBox)

        'Procedimiento para la Llenar un combo con todos los Tipos de Muestras (Nombre y C�digo)
        On Error Resume Next
        Dim dts_TipRes As DataSet
        Dim dtr_fila As DataRow
        dts_TipRes = LeerResultados()
        For Each dtr_fila In dts_TipRes.Tables("Registros").Rows
            cmb_Res.Items.Add(dtr_fila("res_nombre").ToString().PadRight(80) & dtr_fila("res_id").ToString().PadRight(2))
        Next
        cmb_Res.SelectedIndex = 0


    End Sub

    Public Function LeerResultados() As DataSet
        'Funcion para la consultar los datos de la tabla RESULTADO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select * from RESULTADO order by res_id", opr_Conexion.conn_sql)
        LeerResultados = New DataSet("RESULTADO")
        oda_operacion.Fill(LeerResultados, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Resultados", Err)
        Err.Clear()
    End Function

End Class
