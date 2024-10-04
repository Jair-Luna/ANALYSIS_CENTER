'*************************************************************************
' Nombre:   Cls_Resultado
' Tipo de Archivo: clase
' Descripcin:  Clase para manejar los resultados de los test 
' Autores:  RFN, 
' Fecha de Creaci�n: Enero del 2014
' Autores:  RFN
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient




Public Class Cls_Resultado

    Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()



    Public Sub InsertarGrafico(ByVal pac_id As Integer, ByVal gra_name As String, ByVal gra_tipo As Integer, ByVal tipo As String)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        opr_Conexion.sql_conectar()
        Select Case tipo
            Case "Update"
                STR_SQL = "update Graficos set gra_name = '" & gra_name & "', gra_fecha = getdate()  where pac_id = " & pac_id & " and gra_tipo = " & gra_tipo & "; "

            Case "Insert"
                STR_SQL = "Insert into Graficos values (" & pac_id & ", '" & gra_name & "', getdate(), " & gra_tipo & ")"
        End Select

        odc_pedido = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Insertar grafico", Err)
        Err.Clear()
    End Sub

    Public Function BuscarCie(ByVal codigo As String, ByVal busqueda As String) As Boolean
        'Funcion para consultar si existe el nombre de una ciudad antes de insertar otra igual 
        On Error GoTo MsgError

        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String

        opr_Conexion.sql_conectar()

        Select Case codigo
            Case "Cie3"
                str_sql = "select count(cie_cod3) from cie10 where cie_cod3 = '" & busqueda & "'"

            Case "Cie4"
                str_sql = "select count(cie_cod4) from cie10 where cie_cod4 = '" & busqueda & "'"
        End Select

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_act, "Registros")
        For Each dtr_fila In dts_act.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarCie = False
            Else
                BuscarCie = True
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar Cie10", Err)
        Err.Clear()
    End Function

    Public Function BuscarVademecum(ByVal busqueda As String) As Boolean
        'Funcion para consultar si existe el nombre de una ciudad antes de insertar otra igual 
        On Error GoTo MsgError

        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String

        opr_Conexion.sql_conectar()

        
        str_sql = "select VAD_ID from vademecum  where VAD_MEDCOMERCIAL  = '" & busqueda & "'"


        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_act As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_act, "Registros")
        For Each dtr_fila In dts_act.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                BuscarVademecum = False
            Else
                BuscarVademecum = True
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Buscar Vademecum", Err)
        Err.Clear()
    End Function


    Public Sub GuardarCie(ByVal cie_cod3 As String, ByVal cie_desc3 As String, ByVal cie_cod4 As String, ByVal cie_desc4 As String, ByVal tipo As String)
        'Procedimiento para la insertar un registro en la tabla CIUDAD

        Dim str_sql As String

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Select Case tipo
            Case "Insert"
                str_sql = "Insert into CIE10 values ('" & cie_cod3 & "', '" & cie_desc3 & "', '" & cie_cod4 & "', '" & cie_desc4 & "')"
            Case "Update"
                str_sql = "update CIE10 set cie_desc3 = '" & cie_desc3 & "', cie_desc4 = '" & cie_desc4 & "' where cie_cod3 = '" & cie_cod3 & "' and cie_cod4 = '" & cie_cod4 & "'"
            Case "Delete"
                str_sql = "delete from CIE10 where cie_cod3 = '" & cie_cod3 & "' and cie_cod4 = '" & cie_cod4 & "'"

        End Select

        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        MsgBox("Transaccion ejecutada satisfactoriamente", MsgBoxStyle.Information, "ANALISYS")
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo CIE10", "Cie=" & cie_cod3 & " " & cie_cod4, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, cie10", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarVademecum(ByVal VAD_ID As Integer, ByVal VAD_TIPO As String, ByVal PRES_ID As Integer, ByVal VAD_CANTIDAD As Integer, ByVal VAD_MEDGNERICO As String, ByVal VAD_COMERCIAL As String, ByVal VAD_INDICACIONES As String, ByVal VAD_EXTRAS As String, ByVal tipo As String)
        'Procedimiento para la insertar un registro en la tabla CIUDAD
        Dim str_sql As String

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Select Case tipo
            Case "Insert"
                str_sql = "Insert into vademecum values (" & VAD_ID & ", '" & VAD_TIPO & "', " & PRES_ID & ",  " & VAD_CANTIDAD & ", '" & VAD_MEDGNERICO & "', '" & VAD_COMERCIAL & "', '" & VAD_INDICACIONES & "', '" & VAD_EXTRAS & "', '')"
            Case "Update"
                str_sql = "Update vademecum set VAD_TIPO = '" & VAD_TIPO & "', PRES_ID = " & PRES_ID & ", VAD_CANTIDAD = " & VAD_CANTIDAD & ", VAD_MEDGENERICO = '" & VAD_MEDGNERICO & "', VAD_MEDCOMERCIAL = '" & VAD_COMERCIAL & "', VAD_INDICACIONES = '" & VAD_INDICACIONES & "', VAD_EXTRAS = '" & VAD_EXTRAS & "' where VAD_ID = " & VAD_ID & ""
            Case "Delete"
                str_sql = "delete from vademecum where VAD_ID = " & VAD_ID & ""
        End Select

        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        MsgBox("Transaccion realizada satisfactoriamente", MsgBoxStyle.Information, "ANALISYS")
        opr_conexion.sql_desconn()
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo VADEMECUM", "Generico=" & VAD_MEDGNERICO & " " & VAD_MEDGNERICO, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, VADEMEDCUM", Err)
        Err.Clear()
    End Sub

    Public Sub EliminaCie(ByVal cie_cod3 As String, ByVal cie_cod4 As String)
        'Procedimiento para la actualizar un registro en la tabla CIUDAD
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "delete from CIE10 where cie_cod3 = '" & cie_cod3 & "'and cie_cod4 = '" & cie_cod4 & "'"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos elimnados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Ciudad", "CIE10=" & cie_cod4, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Ciudad", Err)
        Err.Clear()
    End Sub


    Public Sub EliminaVademecum(ByVal VAD_MEDCOMERCIAL As String)
        'Procedimiento para la actualizar un registro en la tabla CIUDAD
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "delete FROM vademecum where VAD_MEDCOMERCIAL = '" & VAD_MEDCOMERCIAL & "'"
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        MsgBox("Datos elimnados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        'g_opr_usuario.CargarTransaccion(g_str_login, "Actualizar Ciudad", "CIE10=" & cie_cod4, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Actualizar Ciudad", Err)
        Err.Clear()
    End Sub



    Public Sub Pinta_dgv(ByVal dgv As DataGridView)
        Dim i As Integer = 0
        Dim LaColumna As String
        Dim NumeroCaracteres As Integer

        For i = 0 To dgv.Rows.Count - 1

            LaColumna = dgv.Item("Columna", i).Value
            NumeroCaracteres = LaColumna.Length

            Select Case NumeroCaracteres
                Case "Primer Caso"
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.Turquoise
                Case "Segundo Caso"
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.Violet
                Case Else
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            End Select

        Next

    End Sub

    Sub ordena_cie(ByVal cie As String, ByRef data As DataView)
        'funcion que orderna por test al dataview
        With data
            If Trim(cie) <> "" Then
                Select Case Len(cie)
                    Case 3
                        .RowFilter = "cie_cod3 like '" & Trim(cie) & "*'"
                        .Sort = "cie_cod3"

                    Case 4
                        .RowFilter = "cie_cod4 like '" & Trim(cie) & "*'"
                        .Sort = "cie_cod4"

                    Case Else
                        .RowFilter = "cie_desc4 like '" & Trim(cie) & "*'"
                        .Sort = "cie_desc4"

                End Select

            Else
                .RowFilter = ""
            End If

        End With
    End Sub

    Sub ordena_vademecum(ByVal parametro As String, ByVal tipo As String, ByRef data As DataView)
        'funcion que orderna por test al dataview
        With data
            If Trim(parametro) <> "" Then
                Select Case tipo
                    Case "MedGen"
                        .RowFilter = "VAD_MEDGENERICO like '" & Trim(parametro) & "*'"
                        .Sort = "VAD_MEDGENERICO"

                    Case "MedCom"
                        .RowFilter = "VAD_MEDCOMERCIAL like '" & Trim(parametro) & "*'"
                        .Sort = "VAD_MEDCOMERCIAL"

                        'Case Else
                        '    .RowFilter = "cie_desc4 like '" & Trim(parametroad) & "*'"
                        '    .Sort = "cie_desc4"

                End Select
            Else
                .RowFilter = ""
            End If

        End With
    End Sub

    Sub ordena_vacunaEsAdulto(ByVal EsAdulto As String, ByRef data As DataView)
        'funcion que orderna por test al dataview
        With data
            If Trim(EsAdulto) <> "" Then
                Select Case EsAdulto
                    Case "A"
                        .RowFilter = "EDAD like '" & Trim(EsAdulto) & "*'"
                        .Sort = "I_PRD_ID"

                    Case "N"
                        .RowFilter = "EDAD like '" & Trim(EsAdulto) & "*'"
                        .Sort = "I_PRD_ID"

                        'Case "INDEPENDIENTE"
                        '   .RowFilter = "VAC_CAT = I"
                        '  .Sort = "vac_ID"
                End Select

            Else
                .RowFilter = ""
            End If

        End With
    End Sub


    Sub ordena_vacuna(ByVal vacuna As String, ByRef data As DataView)
        'funcion que orderna por test al dataview
        With data
            If Trim(vacuna) <> "" Then
                Select Case Len(vacuna)
                    Case 3, 4
                        .RowFilter = "I_PRD_ID like '" & Trim(vacuna) & "*'"
                        .Sort = "I_PRD_ID"

                    Case 5
                        .RowFilter = "I_PRD_DESCRIPCION like '" & Trim(vacuna) & "*'"
                        .Sort = "I_PRD_ID"

                        'Case Else
                        '    .RowFilter = "vac_descripcion like '" & Trim(vacuna) & "*'"
                        '    .Sort = "vac_descripcion"

                End Select

            Else
                .RowFilter = ""
            End If

        End With
    End Sub



    Public Function ConsultaSiHayMolecular(ByVal str_sql As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaSiHayMolecular = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaSiHayMolecular = Trim(dtr_fila(0)).ToString & "|" & Trim(dtr_fila(1)).ToString & "|" & Trim(dtr_fila(2)).ToString
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Param molecular", Err)
        Err.Clear()
    End Function


    Public Function ExisteRegistroErrorCorreo(ByVal ped_id As Integer) As Boolean
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select count(ped_id) from correo_error where ped_id = " & ped_id & ""

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ExisteRegistroErrorCorreo = False

        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) > 0 Then
                ExisteRegistroErrorCorreo = True
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta existe Reg error correo", Err)
        Err.Clear()
    End Function

    Public Function ConsultaSignosVitales(ByVal pac_id As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select top 1 sig_id, sig_TensArt, sig_FrecCard  ,sig_FrecResp, sig_Temp, sig_Satur, sig_Peso " & _
                    "from signosvitales " & _
                    "where pac_id = " & pac_id & " order by sig_fecha desc "


        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaSignosVitales = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaSignosVitales = "SIGNOS VITALES" & vbCrLf & "TENSION ARTERIAL: " & Trim(dtr_fila(1)).ToString & vbCrLf & "FRECUENCIA CARDIACA: " & Trim(dtr_fila(2)).ToString & vbCrLf & "FRECUENCIA RESPIRATORIA: " & Trim(dtr_fila(3)).ToString & vbCrLf & "TEMPERATURA: " & Trim(dtr_fila(4)).ToString & vbCrLf & "SATURACION: " & Trim(dtr_fila(5)).ToString & vbCrLf & "PESO: " & Trim(dtr_fila(6)).ToString & vbCrLf
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Signos Vitales", Err)
        Err.Clear()
    End Function

    

    Public Function ConsultaSer_Id(ByVal Age_id As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        Dim str_sql As String = "select vt.I_PRD_ID, p.I_PRD_DESCRIPCION, p.I_PRD_FRASCOS " & _
                                "from tratamientoPaciente as vt, i_producto  as p " & _
                                "where vt.I_PRD_ID = p.I_PRD_ID And vt.Age_id = " & Age_id


        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaSer_Id = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(1).ToString) <> "" Then
                ConsultaSer_Id = ConsultaSer_Id & Trim(dtr_fila(1)).ToString
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta SER_DESC", Err)
        Err.Clear()

    End Function

    Public Function ConsultaCie10(ByVal Age_id As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "SELECT ciec.cie_cod4, cie.cie_desc4 " & _
                    "FROM cie10Consulta as ciec, cie10 as cie " & _
                    "where cie.cie_cod4 = ciec.cie_cod4 and ciec.Age_id = " & Age_id


        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaCie10 = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaCie10 = ConsultaCie10 & Trim(dtr_fila(0)).ToString & " - " & Trim(dtr_fila(1)).ToString & vbCrLf
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Signos Vitales", Err)
        Err.Clear()
    End Function


    Public Function ConsultaDiagnostico(ByVal Age_id As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "SELECT CON_DIAGNOSTICO " & _
                    "FROM consultaMedico " & _
                    "where Age_id = " & Age_id


        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaDiagnostico = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaDiagnostico = Trim(dtr_fila(0)).ToString & vbCrLf
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Signos Vitales", Err)
        Err.Clear()
    End Function

    Public Function ConsultaGraf_name(ByVal pac_id As Integer, ByVal gra_tipo As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select GRA_NAME from graficos where PAC_ID = " & pac_id & " AND GRA_TIPO = " & gra_tipo & ""

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaGraf_name = Nothing

        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaGraf_name = Trim(dtr_fila(0)).ToString
            Else
                ConsultaGraf_name = ""
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TIPO CERTIFICADO", Err)
        Err.Clear()
    End Function



    Public Function ConsultaCert_tipo(ByVal Cer_id As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select CER_TIPO from certificados where CER_ID = " & Cer_id

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaCert_tipo = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaCert_tipo = Trim(dtr_fila(0)).ToString
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TIPO CERTIFICADO", Err)
        Err.Clear()
    End Function


    Public Function ConsultaComposicion(ByVal SER_ID As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select  c.COM_NOMBRE " & _
            "from serieComposicion as sc, composicion as c " & _
            "where sc.SER_ID = " & SER_ID & " " & _
            "and sc.COM_ID = c.COM_ID"


        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaComposicion = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaComposicion = ConsultaComposicion & Trim(dtr_fila(0)).ToString & "|"
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TIPO CERTIFICADO", Err)
        Err.Clear()
    End Function


    Public Function ConsultaCompId(ByVal SER_ID As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select SER_NOMBRE " & _
            "from VacunaSerie " & _
            "where SER_ID = " & SER_ID


        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaCompId = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaCompId = dtr_fila(0).ToString()
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta SERIE NOMBRE", Err)
        Err.Clear()
    End Function

    Public Function ConsultaAgendaAnterior(ByVal Age_idActual As Integer, ByVal pac_id As Integer, ByRef FechaAnterior As String) As Integer

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select top 1 cm.Age_id, RC.PRCC_FECHA " & _
            "from consultaMedico as cm, agenda as a, res_cutaneas as rc " & _
            "where cm.AGE_ID = a.age_id  and a.ped_id = rc.ped_id and rc.PRCC_RESUL_ANIO <> '' and cm.pac_id = " & pac_id & "  and cm.age_id < " & Age_idActual & " order by cm.age_id desc "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaAgendaAnterior = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaAgendaAnterior = Trim(dtr_fila(0))
                FechaAnterior = Format(CDate(dtr_fila(1)), "MMM yyyy")
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta AGENDA ANTERIOR", Err)
        Err.Clear()
    End Function



    Public Function ConsultaTes_Abrev(ByVal Age_idAnterior As Integer, ByVal pac_id As Integer, ByVal tes_padre As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select rc.TES_PADRE, rc.TES_ABREV " & _
                                "from consultaMedico as cm, agenda as a, res_cutaneas as rc " & _
                                "where cm.AGE_ID = a.age_id  and a.ped_id = rc.ped_id and rc.PRCC_RESUL_ANIO <> '' and cm.MED_ID = 8 and cm.pac_id = " & pac_id & "  and cm.age_id= " & Age_idAnterior & " and rc.TES_PADRE = " & tes_padre & " " & _
                                "order by cm.age_id desc, rc.TES_PADRE asc"


        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaTes_Abrev = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaTes_Abrev = ConsultaTes_Abrev & Trim(dtr_fila(1)) & "º"
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta AGENDA ANTERIOR", Err)
        Err.Clear()
    End Function


    Public Function ConsultaTendencia_Abrev(ByVal I_EDAD As Char) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select * from i_tmpConsumo where SUBSTRING(TMP_I_PRD_ID, LEN(TMP_I_PRD_ID), 1) = '" & I_EDAD & "'"

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaTendencia_Abrev = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaTendencia_Abrev = ConsultaTendencia_Abrev & Trim(dtr_fila(0)) & "º" & Trim(dtr_fila(1)) & "º" & Trim(dtr_fila(2)) & "|"
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TENDENCIAS OTROS", Err)
        Err.Clear()
    End Function


    Public Function ConsultaAgendaHistorico(ByVal Age_idAnterior As Integer, ByVal tes_abrev As String, ByVal pac_id As Integer, ByVal med_id As Integer) As String

        On Error GoTo MsgError
        Dim visto As Char = ChrW(10003)
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select cm.Age_id, cm.pac_id, rc.PED_ID, rc.TES_PADRE, rc.TES_ABREV, rc.PRCC_RESUL_ANIO, rc.PRCC_RESUL_INT " & _
            "from consultaMedico as cm, agenda as a, res_cutaneas as rc " & _
            "where cm.AGE_ID = a.age_id  and a.ped_id = rc.ped_id and rc.PRCC_RESUL_ANIO <> '' and cm.MED_ID = " & med_id & " and cm.pac_id = " & pac_id & " and cm.age_id = " & Age_idAnterior & " and rc.TES_ABREV = '" & tes_abrev & "' " & _
            "order by cm.age_id desc, rc.TES_PADRE asc"

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaAgendaHistorico = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaAgendaHistorico = Trim(dtr_fila(5)).ToString & "º" & Replace(Trim(dtr_fila(6)).ToString, "I", visto)
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TIPO CERTIFICADO", Err)
        Err.Clear()
    End Function


    Public Function ConsultaHistoriaClinicaCAMPO(ByVal str_sql As String, ByVal titulo As String) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaHistoriaClinicaCAMPO = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaHistoriaClinicaCAMPO = titulo & vbCrLf & vbCrLf & Trim(dtr_fila(0)).ToString & vbCrLf
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Campo HC", Err)
        Err.Clear()
    End Function


    Public Function ConsultaHistoriaClinica(ByVal pac_id As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select hic_id, hic_fecha, hic_Zona, hic_Ocupacion,  hic_Hobbies, hic_Inmunizaciones, hic_HabitosToxicos, hic_Tiempo, hic_MotivoConsulta, hic_HistEnferActual, hic_TTo_Ananmesis, hic_Seguimiento, hic_PsicoS, hic_EnferEvolInicio, hic_App, hic_EnferToroideas, hic_Cancer, hic_EnferInfecc, hic_Otras, hic_TTo_Antec,  hc_Cirugias, hic_RAM, hic_CampoPiel, hic_DatosLabImagen, hic_DatosLabBiopsia, hic_DatosLabOtros " & _
                                "from historiaClinica " & _
                                "where pac_id = " & pac_id & " "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaHistoriaClinica = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaHistoriaClinica = "HISTORIA CLINICA" & vbCrLf & vbCrLf & "FECHA HC: " & Trim(dtr_fila(1)).ToString & vbCrLf & vbCrLf & "ZONA: " & Trim(dtr_fila(2)).ToString & vbCrLf & "OCUPACION: " & Trim(dtr_fila(3)).ToString & vbCrLf & "HOBBIES: " & Trim(dtr_fila(4)).ToString & vbCrLf & "INMUNIZACIONES: " & Trim(dtr_fila(5)).ToString & vbCrLf & "HABITOS TOXICOS: " & Trim(dtr_fila(6)).ToString & vbCrLf & "TIEMPO: " & Trim(dtr_fila(7)).ToString & vbCrLf & vbCrLf & "MOTIVO DE LA CONSULTA: " & Trim(dtr_fila(8)).ToString & vbCrLf & "HIST. ENFERMEDAD ACTUAL: " & Trim(dtr_fila(9)).ToString & vbCrLf & "TTO: " & Trim(dtr_fila(10)).ToString & vbCrLf & "SEGUIMIENTO: " & Trim(dtr_fila(11)).ToString & vbCrLf & "PSICO S.: " & Trim(dtr_fila(12)).ToString & vbCrLf & "ENFER. EVOLUCION INICIO: " & Trim(dtr_fila(13)).ToString & vbCrLf & "APP: " & Trim(dtr_fila(14)).ToString & vbCrLf & "ENFERMEDADES TIROIDEAS: " & Trim(dtr_fila(15)).ToString & vbCrLf & "CANCER: " & Trim(dtr_fila(16)).ToString & vbCrLf & "ENFER. INFECCIOSAS: " & Trim(dtr_fila(17)).ToString & vbCrLf & "OTRAS ENFER.: " & Trim(dtr_fila(18)).ToString & vbCrLf & "TTO: " & Trim(dtr_fila(19)).ToString & vbCrLf & "CIRUGIAS: " & Trim(dtr_fila(20)).ToString & vbCrLf
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Signos Vitales", Err)
        Err.Clear()
    End Function

    Public Sub ConsultaDiagnosticos(ByVal pac_id As Integer, ByRef diag As String, ByRef trat As String, ByRef evol As String)

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select hic_id, hic_Diagnostico, hic_Tratamiento, hic_Evolucion  " & _
                                "from historiaClinica " & _
                                "where pac_id = " & pac_id & " "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                diag = "DIAGNOSTICOS" & vbCrLf & Trim(dtr_fila(1)).ToString & vbCrLf
                trat = "TRATAMIENTO" & vbCrLf & Trim(dtr_fila(2)).ToString & vbCrLf
                evol = "EVOLUCION" & vbCrLf & Trim(dtr_fila(3)).ToString & vbCrLf
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Diagnosticos", Err)
        Err.Clear()
    End Sub


    Public Function ConsultaDatosRCAT(ByVal AGE_ID As Integer) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim arreglo As String()
        Dim param As String()
        Dim i As Integer
        Dim str_sql As String = "select RCAT_1, RCAT_2, RCAT_3, RCAT_4, RCAT_5, RCAT_6 from encuestaRCAT where Age_id = " & AGE_ID & ""

        cls_operacion.sql_conectar()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            ConsultaDatosRCAT = Trim(odr_operacion.GetValue(0).ToString()) & "º" & Trim(odr_operacion.GetValue(1).ToString()) & "º" & Trim(odr_operacion.GetValue(2).ToString()) & "º" & Trim(odr_operacion.GetValue(3).ToString()) & "º" & Trim(odr_operacion.GetValue(4).ToString()) & "º" & Trim(odr_operacion.GetValue(5).ToString())
        End While

        odr_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta RCAT", Err)
        Err.Clear()
    End Function


    Public Function ConsultaDatosTrama(ByVal pac_id As Integer, ByVal campo As String, ByVal titulo As String) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim arreglo As String()
        Dim param As String()
        Dim i As Integer
        Dim str_sql As String = "select hic_id, " & campo & " " & _
                                "from historiaClinica " & _
                                "where pac_id = " & pac_id & " "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaDatosTrama = Nothing
        oda_operacion.Fill(dts_auto, "Files")

        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                arreglo = Split(Trim(dtr_fila(1)).ToString, "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(1)
                        Case "1"
                            ConsultaDatosTrama = ConsultaDatosTrama & param(0) & vbCrLf
                    End Select
                Next
            End If
        Next
        ConsultaDatosTrama = titulo & vbCrLf & vbCrLf & ConsultaDatosTrama
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TRAMAS", Err)
        Err.Clear()
    End Function


    Public Function ConsultaDatosTramaLab(ByVal pac_id As Integer, ByVal campo As String) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim arreglo As String()
        Dim param As String()
        Dim i As Integer
        Dim str_sql As String = "select hic_id, " & campo & " " & _
                                "from historiaClinica " & _
                                "where pac_id = " & pac_id & " "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaDatosTramaLab = Nothing
        oda_operacion.Fill(dts_auto, "Files")

        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                arreglo = Split(Trim(dtr_fila(1)).ToString, "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    If param(1) <> "" Then
                        ConsultaDatosTramaLab = ConsultaDatosTramaLab & param(0) & ": " & param(1) & vbCrLf
                    End If
                Next
            End If
        Next
        'ConsultaDatosTramaLab = ConsultaDatosTramaLab
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TRAMAS", Err)
        Err.Clear()
    End Function


    Public Function ConsultaDatosTramaTodo(ByVal pac_id As Integer, ByVal campo As String) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim arreglo As String()
        Dim param As String()
        Dim i As Integer
        Dim str_sql As String = "select hic_id, " & campo & " " & _
                                "from historiaClinica " & _
                                "where pac_id = " & pac_id & " "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaDatosTramaTodo = Nothing
        oda_operacion.Fill(dts_auto, "Files")

        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                arreglo = Split(Trim(dtr_fila(1)).ToString, "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(1)
                        Case "0"
                            ConsultaDatosTramaTodo = ConsultaDatosTramaTodo & Replace(param(0), vbCrLf, "") & "(_)  "
                        Case "1"
                            ConsultaDatosTramaTodo = ConsultaDatosTramaTodo & Replace(param(0), vbCrLf, "") & "(x)  "
                    End Select
                Next
            End If
        Next
        'ConsultaDatosTramaTodo = ConsultaDatosTramaTodo
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TRAMAS", Err)
        Err.Clear()
    End Function


    Public Function ConsultaDatosTramaSolo(ByVal pac_id As Integer, ByVal campo As String) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim arreglo As String()
        Dim param As String()
        Dim i As Integer
        Dim str_sql As String = "select hic_id, " & campo & " " & _
                                "from historiaClinica " & _
                                "where pac_id = " & pac_id & " "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaDatosTramaSolo = Nothing
        oda_operacion.Fill(dts_auto, "Files")

        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                arreglo = Split(Trim(dtr_fila(1)).ToString, "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(1)
                        Case "0"
                            'ConsultaDatosTramaSolo = ConsultaDatosTramaSolo & Replace(param(0), vbCrLf, "") & "(_)  "
                        Case "1"
                            ConsultaDatosTramaSolo = ConsultaDatosTramaSolo & Replace(param(0), vbCrLf, "") & "(x)  "
                    End Select
                Next
            End If
        Next
        'ConsultaDatosTramaTodo = ConsultaDatosTramaTodo
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TRAMAS", Err)
        Err.Clear()
    End Function

    Public Function ConsultaDatosTramaVertical(ByVal pac_id As Integer, ByVal campo As String) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim arreglo As String()
        Dim param As String()
        Dim i As Integer
        Dim str_sql As String = "select hic_id, " & campo & " " & _
                                "from historiaClinica " & _
                                "where pac_id = " & pac_id & " "

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaDatosTramaVertical = Nothing
        oda_operacion.Fill(dts_auto, "Files")

        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                arreglo = Split(Trim(dtr_fila(1)).ToString, "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(1)
                        Case "0"
                            ConsultaDatosTramaVertical = ConsultaDatosTramaVertical & "(_)" & vbCrLf
                        Case "1"
                            ConsultaDatosTramaVertical = ConsultaDatosTramaVertical & "(x)" & vbCrLf
                    End Select
                Next
            End If
        Next
        'ConsultaDatosTramaVertical = ConsultaDatosTramaVertical
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TRAMAS", Err)
        Err.Clear()
    End Function


    Public Function ConsultaDatosCutaneas(ByVal ped_id As Integer, ByVal tes_padre As Integer, ByVal titulo As String) As String

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim datos As String
        Dim str_sql As String = "select t.TES_NOMBRE, rc.PRCC_FECHA, rc.PRCC_HORA, rc.PRCC_RESUL_ANIO, rc.PRCC_RESUL_INT, t.TES_ORDENIMP " & _
                            "from res_cutaneas as rc, test as t, test_equipo as te  " & _
                            "where rc.ped_id = " & ped_id & " and rc.tes_padre = " & tes_padre & " and rc.TES_ABREV = te.TEQ_ABRV_FIJA  and t.tes_id = te.tes_id and rc.PRCC_RESUL_INT <> '' " & _
                            "order by t.TES_ORDENIMP asc "


        cls_operacion.sql_conectar()
        'oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)


        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            ConsultaDatosCutaneas = ConsultaDatosCutaneas & odr_operacion(0).ToString & " " & odr_operacion(3).ToString & vbCrLf
            datos = odr_operacion(1).ToString & " " & odr_operacion(2).ToString & vbCrLf
        End While

        If ConsultaDatosCutaneas <> "" Then
            If tes_padre = 401310 Then
                ConsultaDatosCutaneas = "FECHA: " & datos & vbCrLf & titulo & vbCrLf & ConsultaDatosCutaneas
            Else
                ConsultaDatosCutaneas = "***" & titulo & "***" & vbCrLf & ConsultaDatosCutaneas
            End If
        End If
            cls_operacion.odbc_desconn()
            Exit Function
MsgError:
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta TRAMAS", Err)
            Err.Clear()
    End Function

    Public Function ConsultaResMolecular(ByVal str_sql As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaResMolecular = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaResMolecular = Trim(dtr_fila(2)).ToString
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Res molecular", Err)
        Err.Clear()
    End Function



    Public Function ConsultaMolecular(ByVal str_sql As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaMolecular = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(0).ToString) <> "" Then
                ConsultaMolecular = ConsultaMolecular & Trim(dtr_fila(0)).ToString & "º"
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Parametros Molecular", Err)
        Err.Clear()
    End Function



    Public Function consultar_hijos_mis(ByVal tes_id As Integer) As String
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select hijo, descripcion from test, equivalente where test.tes_obs = equivalente.padre AND tes_id = '" & tes_id & "'"
        cls_operacion.sql_conectar()
        Dim retorno As String
        'consultar_hijos_mis = "0"
        Dim oda_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While oda_operacion.Read
            retorno = retorno & oda_operacion.GetValue(0).ToString & ","
        End While
        If retorno = "0" Then
            retorno = CStr(tes_id)
        End If
        consultar_hijos_mis = retorno
        oda_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ConsultarHijosMIS", Err)
        Err.Clear()
    End Function


    Public Function LeerNotaArea(ByVal ped_id As Integer, ByVal tes_padre As Integer, ByVal tipo As Integer) As String

        'fUNCION PARA CONSULTAR LOS DATOS DE LOS EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String

        opr_Conexion.sql_conectar()
        If tipo = 1 Then 'CUANDO SE TRATA DE VALIDACION DE RESULTADOS 

            str_sql = "select PRC_NOTASECC as NotaArea from res_procesados where ped_id = " & ped_id & " and TES_PADRE = " & tes_padre & ";"
            oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            Dim dts_area As New DataSet()
            Dim dtr_fila As DataRow
            oda_operacion.Fill(dts_area, "Registros")
            LeerNotaArea = ""
            For Each dtr_fila In dts_area.Tables("Registros").Rows
                If (IsDBNull(dtr_fila(0))) Then
                    LeerNotaArea = ""
                Else
                    LeerNotaArea = dtr_fila(0)
                End If
                Exit For
            Next

        End If
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Resultado Pedido", Err)
        Err.Clear()
    End Function


    Public Function LeerNombreConvenio(ByVal ped_id As Integer) As String

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String

        opr_Conexion.sql_conectar()

        str_sql = "select CON_NOMBRE from pedido where ped_id = " & ped_id & " ;"
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        LeerNombreConvenio = ""
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                LeerNombreConvenio = "NORMAL"
            Else
                LeerNombreConvenio = dtr_fila(0)
            End If
            Exit For
        Next

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)

        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Convenio Pedido", Err)
        Err.Clear()
    End Function


    Public Function LeerTipoResultado(ByVal test As Integer) As String
        'funcion para la obtencion de los datos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "select AUTO_NOMBRE from tipo_autocompletar WHERE TES_ID = " & test & " order by AUTO_ID;"

        cls_operacion.sql_conn()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            LeerTipoResultado = LeerTipoResultado & odr_operacion(0).ToString & ","
        End While


        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Tipo Res AB", Err)
        Err.Clear()
    End Function


    Public Function VisualizaCalculo(ByVal tes_id As Integer, ByVal valor1 As String, ByVal valor2 As String, ByVal valor3 As String, ByVal valor4 As String, ByRef resultado As Double)
        On Error GoTo MsgError
        Select Case tes_id
            Case 10 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 0.11)), 2)
            Case 12 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / 3.05), 2)
            Case 14 : resultado = Math.Round(Math.Abs(CDbl(valor1) * 10) / Math.Abs(CDbl(valor2)), 2)
            Case 28 : resultado = Math.Round(Math.Abs(CDbl(valor1) * 10) / Math.Abs(CDbl(valor2)), 2)
            Case 18 : resultado = Math.Round(100 - Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2)) - Math.Abs(CDbl(valor3)), 2)
            Case 22, 23, 24, 25, 26 : resultado = Math.Round((Math.Abs(CDbl(valor1)) * Math.Abs(CDbl(valor2))) / 100, 2)



            Case 400296 : resultado = Math.Round((Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2))), 2)
            Case 400476 : resultado = Math.Round((Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2)) - Math.Abs(CDbl(valor3) / 5)), 2)
            Case 400574 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / 2.14), 2) 'BUN
            Case 401093 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / 2.14), 2) 'BUN POST
            Case 400368 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / 10), 2)
            Case 400915 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / 2), 2)
            Case 400927 : resultado = Math.Round(((Math.Abs(CDbl(valor1)) * Math.Abs(CDbl(valor2))) / 405), 2)
                ' '' '' ''            10 GLOBULOS ROJOS/ HEMATIES
                ' '' '' ''            HTO * 110000
                ' '' '' ''            Case 10 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 1000000)), 2)
            Case 11 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 1000)), 2)
            Case 16 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 1000)), 2)

            Case 401331 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 28.7) - 46.7), 2)
                ' '' '' ''12:             HEMOGLOBINA()
                ' '' '' ''                HTO * HGB
                ' '' '' ''            Case 12 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / 3.05), 2)

                ' '' '' ''                14 HB CORPUSCULAR MEDIA
                ' '' '' ''                (HGB * 100) / GLOBULOS ROJOS * 100000
                ' '' '' ''            Case 14 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 100) / Math.Abs(CDbl(valor2)) * 100000), 2)

                ' '' '' ''                28 VOLUMEN CORPUSCULAR MEDIO󠠠/ VCM
                ' '' '' ''                (HTO * 100) / GLOBULOS ROJOS * 100000
                ' '' '' ''            Case 28 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 100) / Math.Abs(CDbl(valor2)) * 100000), 2)

                '15 'CONC.HB(CORPUSCULAR)
                '(HGB * 100) / HTO 
            Case 15 : resultado = Math.Round(Math.Abs(CDbl(valor1) * 100) / Math.Abs(CDbl(valor2)), 2)

                ' '' '' ''18:             LIN%()
                ' '' '' ''            Case 18 : resultado = Math.Round(100 - Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2)) - Math.Abs(CDbl(valor3)), 2)

                ' '' '' ''                22 neu    23 lin    24 mono   25 esos  26 baso
                ' '' '' ''            Case 22, 23, 24, 25, 26 : resultado = Math.Round((Math.Abs(CDbl(valor1)) * Math.Abs(CDbl(valor2))) / 100, 2)

                ' '' '' ''400296:         BI()
                ' '' '' ''400476:         LDL()
                ' '' '' ''400574:         BUN()
                ' '' '' ''400368:         INR()
                ' '' '' ''400915:
                ' '' '' ''                400951, 401069 INDICE HOMA
                ' '' '' ''400891:         LIPIDOS(TOT)
                ' '' '' ''400294:         GLOBULINA()

            Case 400847 : resultado = Math.Round(Math.Abs(CDbl(valor1)) - (Math.Abs(CDbl(valor2)) + Math.Abs(CDbl(valor3))), 2)
            Case 400296 : resultado = Math.Round((Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2))), 2)
            Case 400476 : resultado = Math.Round((Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2)) - Math.Abs(CDbl(valor3) / 5)), 2)
            Case 400718 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / Math.Abs(CDbl(valor2)) * 100), 2)
            Case 400368 : resultado = Math.Round(potencia(Math.Abs(CDbl(valor1) / 12), 1.41), 2)
            Case 400915 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / 2), 2)
            Case 400951, 401069 : resultado = Math.Round(((Math.Abs(CDbl(valor1)) * Math.Abs(CDbl(valor2))) / 405), 2)
            Case 400891 : resultado = Math.Round((Math.Abs(CDbl(valor1)) + (Math.Abs(CDbl(valor2)) * 1.6)), 2)
            Case 400294 : resultado = Math.Round((Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2))), 2)

            Case 914 : resultado = Math.Round((Math.Abs(CDbl(valor3) * 20) - (Math.Abs(CDbl(valor2)) * (1 - Math.Abs(CDbl(valor1) / 100)))) / (Math.Abs(CDbl(valor1) / 100)), 2)

            Case 401142 : resultado = Math.Round(28.7 * (Math.Abs(CDbl(valor1)) - 46.7), 2)

            Case 401143 : resultado = Math.Round((Math.Abs(CDbl(valor1)) / Math.Abs(CDbl(valor2))) * 100, 2)

            Case 400718 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 17.9) / Math.Abs(CDbl(valor2) * 0.23)), 2)

            Case 400640 : resultado = Math.Round((Math.Abs(CDbl(valor1) * 0.179) / Math.Abs(CDbl(valor2) * 0.126)), 2)

            Case 401069 : resultado = Math.Round((Math.Abs(CDbl(valor1)) * Math.Abs(CDbl(valor2) * 0.0024666)), 2)

        End Select
MsgError:

    End Function



    Private Function potencia(ByVal base As Double, ByVal exponente As Double) As Double
        Dim resultado, I As Double
        resultado = 0
        resultado = base ^ exponente
        'For I = 0 To exponente
        '    resultado = resultado * base
        'Next
        Return resultado
    End Function


    Public Function EjecutaFormula(ByVal formula As String, ByRef factores As String())
        'Dim operador1 As Char = Nothing
        'Dim operador2 As Char = Nothing
        Dim factores_aux As String()
        Dim valor1 As String
        Dim valor2 As String
        Dim valor3 As String
        'Dim inicio_operador As Integer = 0
        Dim i As Integer = 0
        Dim oper_pedido As New Cls_Pedido()

        'inicio_operador = formula.IndexOf("]", 1) + 1
        'operador1 = Mid(formula, inicio_operador + 1, 1)


        factores_aux = Split(formula, "|")
        Select Case UBound(factores_aux) + 1
            Case 1 : valor1 = Mid(Replace(factores_aux(0), "]", ""), 2, Len(Replace(factores_aux(0), "]", "")))
                factores = Split(valor1, ",")
            Case 2 : valor1 = Mid(Replace(factores_aux(0), "]", ""), 2, Len(Replace(factores_aux(0), "]", "")))
                valor2 = Mid(Replace(factores_aux(1), "]", ""), 2, Len(Replace(factores_aux(1), "]", "")))
                factores = Split(valor1 & "," & valor2, ",")
            Case 3 : valor1 = Mid(Replace(factores_aux(0), "]", ""), 2, Len(Replace(factores_aux(0), "]", "")))
                valor2 = Mid(Replace(factores_aux(1), "]", ""), 2, Len(Replace(factores_aux(1), "]", "")))
                valor3 = Mid(Replace(factores_aux(2), "]", ""), 2, Len(Replace(factores_aux(2), "]", "")))
                factores = Split(valor1 & "," & valor2 & "," & valor3, ",")

        End Select



        'Dim nombre_test1, nombre_test2, nombre_res1 As String

        'nombre_test1 = oper_pedido.LeerNombreTest2(CInt(Mid(Replace(factores(0), "]", ""), 2, Len(Replace(factores(0), "]", "")))), "MUJER")
        'If nombre_test1 = Nothing Then
        '    nombre_test1 = oper_pedido.LeerNombreTest2(CInt(Mid(Replace(factores(0), "]", ""), 2, Len(Replace(factores(0), "]", "")))), "HOMBRE")
        'End If


        'nombre_test2 = oper_pedido.LeerNombreTest2(CInt(Mid(Replace(factores(1), "]", ""), 2, Len(Replace(factores(1), "]", "")))), "MUJER")
        'If nombre_test2 = Nothing Then
        '    nombre_test2 = oper_pedido.LeerNombreTest2(CInt(Mid(Replace(factores(1), "]", ""), 2, Len(Replace(factores(1), "]", "")))), "HOMBRE")
        'End If

        'nombre_res1 = oper_pedido.LeerNombreTest2(tes_id, "MUJER")
        'If nombre_res1 = Nothing Then
        '    nombre_res1 = oper_pedido.LeerNombreTest2(tes_id, "HOMBRE")
        'End If
        'valor1 = oper_pedido.LeerResultadoTest2(nombre_test1, ped_id)
        'valor2 = oper_pedido.LeerResultadoTest2(nombre_test2, ped_id)

        'If (valor1 = Nothing Or valor1 = "NA" Or valor2 = Nothing Or valor2 = "NA") Then

        'Else
        '    'Select Case tes_id
        '    '   Case 19, 22, 25, 26 : resultado = Math.Round((Math.Abs(CDbl(valor1)) * Math.Abs(CDbl(valor2))) / 100, 2)
        '    '   Case 400296 : resultado = Math.Round((Math.Abs(CDbl(valor1)) - Math.Abs(CDbl(valor2))))
        '    'End Select

        ''oper_pedido.InsertaResCalculo(ped_id, nombre_res1, resultado)
        'End If
    End Function


    Public Function LeerFormula(ByVal tes_id As Integer, ByRef Formula As String) As String
        'funcion para la obtencion de los datos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "select for_formula from formulas where for_tes_id = " & tes_id & " and for_estado =1;"

        cls_operacion.sql_conn()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            LeerFormula = odr_operacion(0)
            Formula = odr_operacion(0)
        End While

        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Leer Formula", Err)
        Err.Clear()
    End Function



    Public Function LeerNombreExamen(ByVal Coleccion As AutoCompleteStringCollection)
        'funcion para la obtencion de los datos
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "select (test.TES_NOMBRE + ' | ' + cast(test.TES_ID as nvarchar(10))) from test where test.TES_TIPO  = 'Examen' order  by test.TES_ID;"

        cls_operacion.sql_conn()

        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            Coleccion.AddRange(New String() {odr_operacion(0)})
        End While


        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Tipo Res AB", Err)
        Err.Clear()
    End Function


    Public Function verifica_autocompletar(ByVal tes_id As Integer) As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select count(AUTO_ID) from tipo_autocompletar WHERE TES_ID = " & tes_id & ";"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        verifica_autocompletar = 0
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                verifica_autocompletar = CInt(dtr_fila(0).ToString)
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Bodega", Err)
        Err.Clear()
    End Function


    Public Function verifica_autoCalcular(ByVal tes_id As Integer) As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select count(AUTO_ID) from ti po_autoCalcular WHERE TES_ID = " & tes_id & ";"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        verifica_autoCalcular = 0
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                verifica_autoCalcular = CInt(dtr_fila(0).ToString)
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Bodega", Err)
        Err.Clear()
    End Function


    ''    Public Function LeerInterfaz(ByVal ped_id As Integer, ByVal his_nombre As String) As DataSet
    ''        'Procedimiento para la consultar los resultados de un pedido
    ''        On Error GoTo MsgError
    ''        Dim cls_operacion As New Cls_Conexion()
    ''        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
    ''        cls_operacion.sql_conectar()
    ''        Dim str_sql As String = "select file_diffimage, file_Basoimage, file_RBCimage, file_PLTimage from ptohistograma where ped_id = " & ped_id & " and his_nombre ='" & his_nombre & "';"
    ''        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
    ''        dt_operacion.SelectCommand = BDCmd
    ''        LeerInterfaz = New DataSet()
    ''        dt_operacion.Fill(LeerInterfaz, "Registros")
    ''        cls_operacion.sql_desconn()
    ''        Exit Function
    ''MsgError:
    ''        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Interfaz", Err)
    ''        Err.Clear()
    ''    End Function



    Public Function ConsultaHistgrama(ByVal ped_id As Integer, ByVal his_nombre As String, ByVal Nombre_imagen As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select " & Nombre_imagen & " from ptohistograma where ped_id = " & ped_id & " and his_nombre = '" & his_nombre & "';"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaHistgrama = Nothing
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                ConsultaHistgrama = Trim(dtr_fila(0)).ToString
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, ConsultaHistograma", Err)
        Err.Clear()
    End Function


    Public Function ConsultaImagen(ByVal ped_id As Integer, ByVal Nombre_imagen As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select img_base64 from ptoImagen where img_nombre = '" & Nombre_imagen & "' and ped_id = " & ped_id & " ;"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaImagen = Nothing
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                ConsultaImagen = Trim(dtr_fila(0)).ToString
            End If
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Imagen", Err)
        Err.Clear()
    End Function


    Public Function ConsultaPdf(ByVal ped_id As Integer, ByVal pdf_examen As String) As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select pdf_dwn from ptoPdf where pdf_examen = '" & pdf_examen & "' and ped_id = " & ped_id & " ;"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaPdf = Nothing
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                ConsultaPdf = CInt(dtr_fila(0))
            End If
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Imagen", Err)
        Err.Clear()
    End Function


    Public Function MaximoPdf(ByVal ped_id As Integer, ByVal pdf_examen As String) As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select pdf_sec from ptoPdf where pdf_examen = '" & pdf_examen & "' and ped_id = " & ped_id & " ;"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        MaximoPdf = Nothing
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                MaximoPdf = CInt(dtr_fila(0))
            End If
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Imagen", Err)
        Err.Clear()
    End Function


    Public Function ConsultaMaxPdf(ByVal ped_id As Integer, ByVal pdf_examen As String) As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select max(pdf_sec) from ptoPdf where pdf_examen = '" & pdf_examen & "' and ped_id = " & ped_id & " ;"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaMaxPdf = Nothing
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                ConsultaMaxPdf = CInt(dtr_fila(0))
            End If
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Max PDF", Err)
        Err.Clear()
    End Function


    Public Function ConsultaMaxVademecum() As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select max(VAD_ID) from VADEMECUM ;"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaMaxVademecum = Nothing
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                ConsultaMaxVademecum = CInt(dtr_fila(0))
            End If
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Max VEDEMECUM", Err)
        Err.Clear()
    End Function


    Public Function ConsultaMaxErrorCorreo() As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select max(cer_id) from Correo_error;"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaMaxErrorCorreo = Nothing
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                ConsultaMaxErrorCorreo = CInt(dtr_fila(0))
            End If
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consulta Max Error Correo", Err)
        Err.Clear()
    End Function


    ' ''    Public Function ConsultaPathFiles(ByVal ped_id As Integer, ByVal his_nombre As String) As String
    ' ''        'funcion para la obtencion de los datos de bodegas retorna un dataset
    ' ''        On Error GoTo MsgError
    ' ''        Dim cls_operacion As New Cls_Conexion()
    ' ''        Dim str_sql As String = "select file_diffimage, file_Basoimage, file_RBCimage, file_PLTimage from ptohistograma where ped_id = " & ped_id & " and his_nombre ='" & his_nombre & "';"
    ' ''        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
    ' ''        Dim dtr_fila As DataRow
    ' ''        Dim dts_auto As New DataSet()

    ' ''        cls_operacion.sql_conectar()
    ' ''        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

    ' ''        ConsultaPathFiles = Nothing
    ' ''        oda_operacion.Fill(dts_auto, "Registros")
    ' ''        For Each dtr_fila In dts_auto.Tables(0).Rows
    ' ''            If dtr_fila(0).ToString <> "" Then
    ' ''                ConsultaPathFiles = Trim(dtr_fila(0)).ToString & "" & Trim(dtr_fila(1)).ToString & "" & Trim(dtr_fila(2)).ToString & "󺺺" & Trim(dtr_fila(3)).ToString & "�"
    ' ''            End If
    ' ''        Next

    ' ''        cls_operacion.odbc_desconn()
    ' ''        Exit Function
    ' ''MsgError:
    ' ''        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, ConsultaHistograma", Err)
    ' ''        Err.Clear()
    ' ''    End Function


    Public Function ConsultaPathFiles(ByVal str_sql As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaPathFiles = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(1).ToString) <> "" Then
                'ConsultaPathFiles = Trim(dtr_fila(1)).ToString & "º" & Trim(dtr_fila(2)).ToString & "º" & Trim(dtr_fila(3)).ToString & "º" & Trim(dtr_fila(4)).ToString & "º" & Trim(dtr_fila(5)).ToString & "º" & Trim(dtr_fila(6)).ToString & "º" & Trim(dtr_fila(7)).ToString & "º"
                ConsultaPathFiles = Trim(dtr_fila(1)).ToString & "º" & Trim(dtr_fila(2)).ToString & "º" & Trim(dtr_fila(3)).ToString
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Histograma", Err)
        Err.Clear()
    End Function


    Public Function ConsultaPathFilesImagenQR(ByVal str_sql As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaPathFilesImagenQR = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(1).ToString) <> "" Then
                'ConsultaPathFiles = Trim(dtr_fila(1)).ToString & "º" & Trim(dtr_fila(2)).ToString & "º" & Trim(dtr_fila(3)).ToString & "º" & Trim(dtr_fila(4)).ToString & "º" & Trim(dtr_fila(5)).ToString & "º" & Trim(dtr_fila(6)).ToString & "º" & Trim(dtr_fila(7)).ToString & "º"
                ConsultaPathFilesImagenQR = Trim(dtr_fila(1)).ToString
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta ImagenQR", Err)
        Err.Clear()
    End Function



    Public Function ConsultaPathFilesImg(ByVal str_sql As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaPathFilesImg = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(1).ToString) <> "" Then
                'ConsultaPathFilesImg = Trim(dtr_fila(1)).ToString & "\" & Trim(dtr_fila(2)).ToString & "\" & Trim(dtr_fila(3)).ToString & "\" & Trim(dtr_fila(4)).ToString & "\" & Trim(dtr_fila(5)).ToString & "\" & Trim(dtr_fila(6)).ToString & "\" & Trim(dtr_fila(7)).ToString & "\"
                ConsultaPathFilesImg = Trim(dtr_fila(1)).ToString & "\" & Trim(dtr_fila(2)).ToString & "\" & Trim(dtr_fila(3)).ToString
            End If
        Next


        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, ConsultaHistograma", Err)
        Err.Clear()
    End Function


    Public Function ConsultaPathFilesImgOcupacional(ByVal str_sql As String) As String
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaPathFilesImgOcupacional = Nothing
        oda_operacion.Fill(dts_auto, "Files")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If Trim(dtr_fila(1).ToString) <> "" Then
                'ConsultaPathFilesImg = Trim(dtr_fila(1)).ToString & "\" & Trim(dtr_fila(2)).ToString & "\" & Trim(dtr_fila(3)).ToString & "\" & Trim(dtr_fila(4)).ToString & "\" & Trim(dtr_fila(5)).ToString & "\" & Trim(dtr_fila(6)).ToString & "\" & Trim(dtr_fila(7)).ToString & "\"
                ConsultaPathFilesImgOcupacional = Trim(dtr_fila(1)).ToString & "\"
            End If
        Next
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta Imagen", Err)
        Err.Clear()
    End Function




    Public Function verifica_autocompletarArea(ByVal area As Integer) As Integer
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select count(AUTO_ID) from tipo_autocompletar WHERE TES_ID = " & area & ";"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        verifica_autocompletarArea = 0
        oda_operacion.Fill(dts_auto, "Registros")
        For Each dtr_fila In dts_auto.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                verifica_autocompletarArea = CInt(dtr_fila(0).ToString)
            End If
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Bodega", Err)
        Err.Clear()
    End Function


    Public Function LeerTipoResultado() As DataSet
        'funcion para la obtencion de los datos de bodegas retorna un dataset
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = "select RESAB_NOMBRE from tipo_resab order by RESAB_ID;"
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        LeerTipoResultado = New DataSet()
        oda_operacion.Fill(LeerTipoResultado, "Registros")
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Bodega", Err)
        Err.Clear()
    End Function


    Public Function LeerResultado() As DataSet

        'Procedimiento para la consultar los resultados de un pedido
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand("SELECT LISTA_TRABAJO.PED_ID, PEDIDO.PED_FECING, PEDIDO.PAC_ID, PEDIDO.MED_ID, PACIENTE.PAC_APELLIDO, PACIENTE.PAC_NOMBRE, MEDICO.MED_NOMBRE FROM (PACIENTE INNER JOIN (MEDICO INNER JOIN PEDIDO ON MEDICO.MED_ID = PEDIDO.MED_ID) ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID GROUP BY LISTA_TRABAJO.PED_ID, PEDIDO.PED_FECING, PEDIDO.PAC_ID, PEDIDO.MED_ID, PACIENTE.PAC_APELLIDO, PACIENTE.PAC_NOMBRE, MEDICO.MED_NOMBRE, LISTA_TRABAJO.LIS_RESESTADO HAVING (((LISTA_TRABAJO.LIS_RESESTADO)=1));", cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerResultado = New DataSet()
        dt_operacion.Fill(LeerResultado, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Resultado", Err)
        Err.Clear()
    End Function

    Public Sub ResultadosPedido(ByRef dtv_resp As DataView, ByRef dgrd_resPedido As DataGrid, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal aareas As String, Optional ByVal ped_id_historico As Long = 0)
        '07/Ago/2013
        'TIPO SE USA PARA DIFERENCIAR LA CONSULTA DE RANGOS NORMALES EN VISRESULTADOS Y VALIDACIONRES
        '0 ES VALIDACION Y 1 ES VISUALIZACION
        On Error Resume Next
        Dim dts_resp As DataSet

        dts_resp.Clear()
        dts_resp = LeerResultadoPedido(ped_id, tipo, aareas, ped_id_historico)

        'dts_lista.Tables(0).Rows(lst_pedidos.SelectedIndex).Item(1).ToString


        With dtv_resp
            .Table = dts_resp.Tables("Registros")
        End With
        dtv_resp.AllowNew = False
        dtv_resp.AllowDelete = False
        dtv_resp.Sort = "AR.ARE_OBS"
        dgrd_resPedido.DataSource = dtv_resp
        dgrd_resPedido.NavigateTo(0, "Registros")
    End Sub

    Public Function TieneReceta(ByVal Age_id As Integer) As Boolean

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql = "select count(age_id) from receta where age_id = " & Age_id & ""
                        

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        TieneReceta = False
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If dtr_fila(0) >= 1 Then
                TieneReceta = True
            Else
                TieneReceta = False
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, pedido hitorico", Err)
        Err.Clear()
    End Function


    Public Function TieneFinalizado(ByVal Age_id As Integer) As Integer

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql = "select count(age_id) from consultaMedico where age_id = " & Age_id & " and CON_ESTADO = 'CERRADO' "


        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        TieneFinalizado = False
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If dtr_fila(0) >= 1 Then
                TieneFinalizado = dtr_fila(0)
            Else
                TieneFinalizado = 0
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, pedido hitorico", Err)
        Err.Clear()
    End Function


    Public Function TieneTratamiento(ByVal Age_id As Integer) As Boolean

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql = "select count(age_id) from TratamientoPaciente where age_id = " & Age_id & ""


        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        TieneTratamiento = False
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If dtr_fila(0) >= 1 Then
                TieneTratamiento = True
            Else
                TieneTratamiento = False
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, pedido hitorico", Err)
        Err.Clear()
    End Function

    Public Function TieneDermografismo(ByVal Age_id As Integer) As Boolean

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql = "select count(age_id) from consultaMedico where age_id = " & Age_id & " and con_dermografico = 1"


        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        TieneDermografismo = False
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If dtr_fila(0) >= 1 Then
                TieneDermografismo = True
            Else
                TieneDermografismo = False
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, pedido hitorico", Err)
        Err.Clear()
    End Function


    Public Function TieneCutaneas(ByVal ped_id As Integer) As Boolean

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        'Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql = "select count(prcc_resul_anio) from res_cutaneas where ped_id = " & ped_id & " and prcc_resul_anio <> '' "


        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        TieneCutaneas = False
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If dtr_fila(0) >= 1 Then
                TieneCutaneas = True
            Else
                TieneCutaneas = False
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, pedido hitorico", Err)
        Err.Clear()
    End Function



    Public Function PedidoHistorico(ByVal pac_id As Integer, ByVal ped_fecing As Date, ByVal tes_abrev As String) As Integer

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql = "select top 1 ped.ped_id, ped.PED_FECING, ped.ped_turno " & _
                        "from pedido as ped, res_procesados as rp " & _
                        "where ped.PAC_ID = " & pac_id & " " & _
                        "and rp.TES_ABREV = '" & tes_abrev & "' " & _
                        "and rp.PED_ID = ped.PED_ID " & _
                        "and ped.PED_ESTADO <> 2 " & _
                        "and ped.ped_fecing < '" & Format(ped_fecing, "dd/MM/yyyy") & "' " & _
                        "and rp.PRC_RESFINAL <> '' order by ped_fecing desc;"

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        PedidoHistorico = -1
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                PedidoHistorico = -1
            Else
                PedidoHistorico = dtr_fila(0)
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, pedido hitorico", Err)
        Err.Clear()
    End Function



    Public Sub ResultadosPedidoP(ByRef dtv_resp As DataView, ByRef dgrd_resPedido As DataGrid, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal tes_padre As Integer, ByVal tes_hijos As String, ByVal tim_padre As String)
        On Error Resume Next
        Dim dts_resp As DataSet
        dts_resp.Clear()
        dts_resp = LeerResultadoPedidoP(ped_id, tipo, tes_padre, tes_hijos, tim_padre)
        With dtv_resp
            .Table = dts_resp.Tables("Registros")
        End With
        dtv_resp.AllowNew = False
        dtv_resp.Sort = "ORDEN"
        dgrd_resPedido.DataSource = dtv_resp
        dgrd_resPedido.NavigateTo(0, "Registros")
    End Sub



    Public Sub ResultadosPedidoAB(ByRef dtv_resAB As DataView, ByRef dgrd_resAB As DataGrid, ByVal ped_id As Integer, ByVal tipo As Byte, ByVal tes_padre As Integer)
        On Error Resume Next
        Dim dts_resAB As DataSet
        dts_resAB.Clear()
        dts_resAB = LeerResultadoPedidoAB(ped_id, tipo, tes_padre)
        With dtv_resAB
            .Table = dts_resAB.Tables("RegistrosRESAB")
        End With
        dtv_resAB.AllowNew = False
        dtv_resAB.Sort = "ORDEN"
        dgrd_resAB.DataSource = dtv_resAB
        dgrd_resAB.NavigateTo(0, "RegistrosRESAB")
    End Sub

    Public Function CargarAB(ByVal dtv_resAB As DataView, ByVal ped_id As Integer, ByVal tes_padre As Integer) As DataSet
        On Error Resume Next
        Dim dts_AB As DataSet

        CargarAB.Clear()
        CargarAB = LeerAntibioticos(dtv_resAB, ped_id, tes_padre)
        Return CargarAB
        'With dtv_AB
        '    .Table = dts_AB.Tables("RegistrosAB")
        'End With
        'dtv_AB.AllowNew = False
        'dtv_AB.Sort = "ORDEN"
        'dgrd_resAB.DataSource = dtv_AB
        'dgrd_resAB.NavigateTo(0, "RegistrosAB")
    End Function

    Public Sub ResAutoPedido(ByRef dtt_res As DataTable, ByVal ped_id As Integer)
        'procedimiento que consulta los resultados autom�ticos de un pedido
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        dtt_res.Clear()
        opr_Conexion.sql_conectar()
        STR_SQL = "SELECT A.PED_ID AS PED_ID, A.PRC_FECHA AS PRC_FECHA, A.PRC_HORA AS PRC_HORA, " & _
                "B.TEQ_ABRV_FIJA AS TEQ_ABRV_FIJA, C.TES_NOMBRE AS TES_NOMBRE, A.PRC_RESUL " & _
                "AS PRC_RESUL, A.PRC_RESUL AS PRC_RESULM, D.UNI_NOMENCLATURA AS UNI_NOMENCLATURA," & _
                "(cast(B.TEQ_RANMIN as varchar(250)) + ' - ' + cast(B.TEQ_RANMAX as varchar(250)) + ' ' + cast(B.TEQ_RANMUL as varchar(250))) AS RANGO_NORMAL, " & _
                "A.PRC_ERROR AS PRC_ERROR, F.ERR_DESCRIPCION AS ERR_DESC FROM ERROR_EQUIPO AS F," & _
                "UNIDAD AS D INNER JOIN (TEST AS C INNER JOIN (((RES_PROCESADOS AS A INNER JOIN " & _
                "SNI AS G ON A.SNI_NOMBRE = G.SNI_NOMBRE) INNER JOIN EQUIPO AS E ON G.SNI_NOMBRE = E.SNI_NOMBRE)" & _
                "INNER JOIN TEST_EQUIPO AS B ON (B.TEQ_ABRV_FIJA = A.TES_ABREV) AND (E.EQU_ID = B.EQU_ID))" & _
                "ON C.TES_ID = B.TES_ID) ON D.UNI_ID = B.UNI_ID WHERE A.PED_ID= " & ped_id & " AND " & _
                "E.EQU_ID=F.equ_id AND F.ERR_ID=A.prc_error"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        'cargamos en el parametro enviado por referencia
        oda_operacion.Fill(dtt_res)
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Resultados Pedido", Err)
        Err.Clear()
    End Sub

    Public Sub ActualizarResMan(ByVal ped_id As Integer, ByVal res_man As String)
        'Procedimiento que actualiza el resultado manual de un pedido
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim opr_res As New Cls_Resultado()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim odc_pedido As New SqlCommand()
        Dim STR_SQL As String
        Dim int_indice As Integer
        opr_Conexion.sql_conectar()

        Dim dts_resm As DataSet
        Dim dtr_fila As DataRow
        Dim j As Short = 0
        Dim i As Short = 0
        Dim str As String = ""
        Dim count As Short = 0
        Dim str_opera As String = ""
        Dim nom_test As String = ""
        'AQUI
        dts_resm = opr_res.LeerResultadoM(ped_id, "Validacion")
        count = dts_resm.Tables(0).Rows.Count
        If (count > 0) Then
            Dim test(2) As Short
            Dim testN(2) As String
            Dim testID(2) As String
            Dim uniP(2) As String   'Variable que almacena la unidad (nomenclatura) de cada prueba
            Dim g As Short = 1
            ReDim test(count)
            ReDim testN(count)
            ReDim testID(count)
            ReDim uniP(count)

            For Each dtr_fila In dts_resm.Tables("Registros").Rows
                test(g) = (InStr(res_man, dtr_fila(1), CompareMethod.Text)) - 1
                testN(g) = dtr_fila(1)   'NOMBRE DEL TEST
                testID(g) = dtr_fila(2)   'ID DEL TEST
                uniP(g) = dtr_fila(3)   'NOMENCLATURA DE LA UNIDAD DEL TEST 
                g = g + 1
            Next
            For i = 1 To count
                g = 0
                If (i <> count) Then
                    g = test(i + 1) - test(i)
                    str = res_man.Substring(test(i), g - 2)
                    g = Len(testN(i))
                    str = str.Substring(g + 1)
                    'If (Mid(str, 1, 13) = " En proceso..") Then

                    'Else
                    g = InStr(str, uniP(i), CompareMethod.Text)
                    str = Mid(str, 1, g - 1)
                    'End If
                Else
                    g = Len(res_man) - test(i)
                    str = res_man.Substring(test(i), g)
                    g = Len(testN(i))
                    'If (Mid(str, 1, 13) = "En proceso..") Then

                    'Else
                    str = str.Substring(g + 1)
                    g = InStr(str, uniP(i), CompareMethod.Text)
                    str = Mid(str, 1, g - 1)
                    'End If
                End If
                Dim RANGO As String = ""
                If Trim(str) <> "" Then
                    RANGO = opr_trabajo.LeerRangoNormalTest(testID(i))
                    opr_trabajo.Actu_Test_Trabajo(ped_id, testID(i), Trim(str), RANGO)
                    str_opera = CStr(ped_id) & "/" & testID(i) & "/" & Trim(str)
                    g_opr_usuario.CargarTransaccion(g_str_login, "Valida ResManual ", "", g_sng_user, "", "", "")
                End If
            Next
        End If
        Exit Sub
MsgError: MsgBox("No se pudo realizar la operacion solicitada, ActualizarResMan - Cls_Resultado", MsgBoxStyle.Exclamation, "ANALISYS")
        Err.Clear()
    End Sub

    Public Function LeerResultadoPedido(ByVal ped_id As Integer, ByVal tipo As Byte, ByVal aareas As String, ByVal ped_id_historico As Long) As DataSet
        '07/Ago/2013
        'fUNCION PARA CONSULTAR LOS DATOS DE LOS EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        Dim str_aux As String = "and (C.are_id in ("

        opr_Conexion.sql_conectar()
        If tipo = 0 Then  'CUANDO SE TRATA DE VALIDACION DE RESULTADOS 
            'validacion por areas.
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0



            'str_aux = aareas & "))"
            ''rfn

            str_sql = "SELECT A.PED_ID AS PED_ID, A.PRC_FECHA AS PRC_FECHA, A.PRC_HORA AS PRC_HORA, B.TEQ_ABRV_FIJA AS TEQ_ABRV_FIJA, C.TES_NOMBRE AS TES_NOMBRE, " & _
                "case when (A.PRC_RESUL = '') then (A.PRC_TEXTO) else (A.PRC_RESUL) end AS PRC_RESUL, " & _
                "case when (A.PRC_RESFINAL = '') then (A.PRC_TEXTO) else (A.PRC_RESFINAL) end AS PRC_RESULM, " & _
                "D.UNI_NOMENCLATURA AS UNI_NOMENCLATURA, " & _
                "case when (B.TEQ_TRANGO = 0) then '' when (B.TEQ_TRANGO = 1) then ( convert(nvarchar(max), B.TEQ_RANMIN) + ' - ' + convert(nvarchar(max),B.TEQ_RANMAX)) else (convert(nvarchar(max),B.TEQ_RANMUL)) end AS RANGO_NORMAL, " & _
                "A.PRC_ERROR AS PRC_ERROR, A.PRC_ERROR as GRAF_ERROR ,A.SNI_NOMBRE as ERR_DESC,A.PRC_ERROR as DESCRIP, C.TES_ORDENIMP AS ORDEN, A.TIM_ID AS MUESTRA, AR.ARE_NOMBRE AS SECC, B.TEQ_TRANGO as RANGO_ID, TR.RES_ID AS RES_ID, C.TES_AB AS TES_AB, C.TES_CALC AS TES_CALC, A.TIM_ID as TIM_ID, C.TES_ID, '0' as Imp, c.ARE_ID, A.PRC_REPETICION " & _
                "FROM UNIDAD AS D, TEST AS C, RES_PROCESADOS AS A, SNI AS G, EQUIPO AS E, TEST_EQUIPO AS B, AREA AS AR, TEST_RESULTADO AS TR " & _
                "WHERE TR.TES_ID = C.TES_ID AND C.TES_TIPO in ('Examen','Procedimiento') AND AR.ARE_ID = C.ARE_ID AND A.TIM_ID = C.TIM_ID " & _
                "AND A.SNI_NOMBRE = G.SNI_NOMBRE AND G.SNI_NOMBRE = E.SNI_NOMBRE AND B.TEQ_ABRV_FIJA = A.TES_ABREV " & _
                "AND E.EQU_ID = B.EQU_ID AND C.TES_ID = B.TES_ID AND  D.UNI_ID = B.UNI_ID AND A.PED_ID = " & ped_id & ""
            If aareas <> "00" Or "00,00" Then
                'str_sql = str_sql & " " & str_aux
            End If

        Else    'CUANDO SE TRATA DE VISUALIZACION DE RESULTADOS  (ENTREGA)

            str_sql = "SELECT A.PED_ID AS PED_ID, A.PRC_FECHA AS PRC_FECHA, A.PRC_HORA AS PRC_HORA, B.TEQ_ABRV_FIJA AS TEQ_ABRV_FIJA, C.TES_NOMBRE AS TES_NOMBRE, " & _
                "case when (A.PRC_RESUL = '') then (A.PRC_TEXTO) else (A.PRC_RESUL) end AS PRC_RESUL, " & _
                "case when (A.PRC_RESFINAL = '') then (A.PRC_TEXTO) else (A.PRC_RESFINAL) end AS PRC_RESULM, " & _
                "D.UNI_NOMENCLATURA AS UNI_NOMENCLATURA, " & _
                "case when (B.TEQ_TRANGO = 0) then '' when (B.TEQ_TRANGO = 1) then ( convert(nvarchar(max), B.TEQ_RANMIN) + ' - ' + convert(nvarchar(max),B.TEQ_RANMAX)) else (convert(nvarchar(max),B.TEQ_RANMUL)) end AS RANGO_NORMAL, " & _
                "A.PRC_ERROR AS PRC_ERROR, A.PRC_ERROR as GRAF_ERROR ,A.SNI_NOMBRE as ERR_DESC,A.PRC_ERROR as DESCRIP, C.TES_ORDENIMP AS ORDEN, A.TIM_ID AS MUESTRA, AR.ARE_NOMBRE AS SECC, B.TEQ_TRANGO as RANGO_ID, TR.RES_ID AS RES_ID, C.TES_AB AS TES_AB, C.TES_CALC AS TES_CALC, A.TES_PADRE as TES_ID, C.TES_ID, '0' as Imp, c.ARE_ID, A.PRC_REPETICION " & _
                "FROM UNIDAD AS D, TEST AS C, RES_PROCESADOS AS A, SNI AS G, EQUIPO AS E, TEST_EQUIPO AS B, AREA AS AR, TEST_RESULTADO AS TR " & _
                "WHERE TR.TES_ID = C.TES_ID AND C.TES_TIPO in ('Examen','Procedimiento') AND AR.ARE_ID = C.ARE_ID AND A.TIM_ID = C.TIM_ID " & _
                "AND A.SNI_NOMBRE = G.SNI_NOMBRE AND G.SNI_NOMBRE = E.SNI_NOMBRE AND B.TEQ_ABRV_FIJA = A.TES_ABREV " & _
                "AND E.EQU_ID = B.EQU_ID AND C.TES_ID = B.TES_ID AND  D.UNI_ID = B.UNI_ID AND A.PED_ID = " & ped_id & ""
            If aareas <> "00" And aareas <> "" Then
                str_sql = str_sql & str_aux & CStr(Mid(aareas, 1, Len(aareas) - 1)) & ")) "
            End If



        End If
        str_sql = str_sql & " order by AR.ARE_OBS, C.TES_ORDENIMP "

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerResultadoPedido = New DataSet()
        oda_operacion.Fill(LeerResultadoPedido, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Resultado Pedido", Err)
        Err.Clear()
    End Function


    Public Function LeerResultadoPedidoHistorico(ByVal ped_id As Integer) As DataSet
        '07/Ago/2013
        'fUNCION PARA CONSULTAR LOS DATOS DE LOS EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        Dim str_aux As String = "and (C.are_id in ("

        opr_Conexion.sql_conectar()
        'validacion por areas.
        Dim str_Areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0




        str_sql = "SELECT A.PED_ID AS PED_ID, A.PRC_FECHA AS PRC_FECHA, A.PRC_HORA AS PRC_HORA, B.TEQ_ABRV_FIJA AS TEQ_ABRV_FIJA, C.TES_NOMBRE AS TES_NOMBRE, " & _
            "case when (A.PRC_RESUL = '') then (A.PRC_TEXTO) else (A.PRC_RESUL) end AS PRC_RESUL, " & _
            "case when (A.PRC_RESFINAL = '') then (A.PRC_TEXTO) else (A.PRC_RESFINAL) end AS PRC_RESULM, " & _
            "D.UNI_NOMENCLATURA AS UNI_NOMENCLATURA, " & _
            "case when (B.TEQ_TRANGO = 0) then '' when (B.TEQ_TRANGO = 1) then ( convert(nvarchar(max), B.TEQ_RANMIN) + ' - ' + convert(nvarchar(max),B.TEQ_RANMAX)) else (convert(nvarchar(max),B.TEQ_RANMUL)) end AS RANGO_NORMAL, " & _
            "A.PRC_ERROR AS PRC_ERROR, A.PRC_ERROR as GRAF_ERROR ,A.SNI_NOMBRE as ERR_DESC,A.PRC_ERROR as DESCRIP, C.TES_ORDENIMP AS ORDEN, A.TIM_ID AS MUESTRA, AR.ARE_NOMBRE AS SECC, B.TEQ_TRANGO as RANGO_ID, TR.RES_ID AS RES_ID, C.TES_AB AS TES_AB, C.TES_CALC AS TES_CALC, A.TIM_ID as TIM_ID, C.TES_ID, '0' as Imp, c.ARE_ID " & _
            "FROM UNIDAD AS D, TEST AS C, RES_PROCESADOS AS A, SNI AS G, EQUIPO AS E, TEST_EQUIPO AS B, AREA AS AR, TEST_RESULTADO AS TR " & _
            "WHERE TR.TES_ID = C.TES_ID AND C.TES_TIPO in ('Examen','Procedimiento') AND AR.ARE_ID = C.ARE_ID AND A.TIM_ID = C.TIM_ID " & _
            "AND A.SNI_NOMBRE = G.SNI_NOMBRE AND G.SNI_NOMBRE = E.SNI_NOMBRE AND B.TEQ_ABRV_FIJA = A.TES_ABREV " & _
            "AND E.EQU_ID = B.EQU_ID AND C.TES_ID = B.TES_ID AND  D.UNI_ID = B.UNI_ID AND A.PED_ID = " & ped_id & ""


        str_sql = str_sql & " order by AR.ARE_OBS, C.TES_ORDENIMP "

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerResultadoPedidoHistorico = New DataSet()
        oda_operacion.Fill(LeerResultadoPedidoHistorico, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Resultado Pedido HISTORICO", Err)
        Err.Clear()
    End Function




    Public Function LeerResultadoPedidoP(ByVal ped_id As Integer, ByVal tipo As Byte, ByVal tes_padre As Integer, ByVal tes_hijos As String, ByVal tim_padre As String) As DataSet
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql, str_sql1 As String
        Dim decimales As Integer = System.Configuration.ConfigurationSettings.AppSettings("decimales")

        opr_Conexion.sql_conectar()
        If tipo = 0 Then  'CUANDO SE TRATA DE VALIDACION DE RESULTADOS 
            'validacion por areas.
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0
            opr_user.LeerAreasUsuarioValida(g_sng_user, arr_datos, g_EsOcupacional, arr_nombre)
            For int_i = 0 To arr_datos.Count - 1
                str_Areas = str_Areas & arr_datos(int_i) & ","
            Next
            Dim x, i As Short
            Dim areas() As String
            Dim str_aux As String = "and ("
            areas = Split(str_Areas, ",")
            x = UBound(areas)
            'en caso de que exista areas a donde consultar
            If x > 0 Then
                For i = 0 To (x - 1)
                    If i = 0 Then
                        str_aux = str_aux & "C.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or C.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If

            'rfn
            If tes_hijos = "" Then
                str_sql = "SELECT A.PED_ID AS PED_ID, A.PRC_FECHA AS PRC_FECHA, A.PRC_HORA AS PRC_HORA, B.TEQ_ABRV_FIJA AS TEQ_ABRV_FIJA, C.TES_NOMBRE AS TES_NOMBRE, case when (A.PRC_RESUL = '') then ('') else (A.PRC_RESUL) end AS PRC_RESUL, case when (A.PRC_RESFINAL = '') then (A.PRC_TEXTO) else (A.PRC_RESFINAL) end AS PRC_RESULM, D.UNI_NOMENCLATURA AS UNI_NOMENCLATURA, " & _
    "case when (B.TEQ_TRANGO = 0) then '' when  (B.TEQ_TRANGO = 1) then (CONVERT(nvarchar(255),LTRIM(RTRIM(str(ISNULL(teq_ranmin,0),20," & decimales & ")))) + ' - ' + CONVERT(nvarchar(255),LTRIM(RTRIM(str(ISNULL(teq_ranmax,0),20," & decimales & "))))) else  (B.TEQ_RANMUL) end AS RANGO_NORMAL, " & _
    "A.PRC_RESFINAL AS PRC_RESULM, D.UNI_NOMENCLATURA AS UNI_NOMENCLATURA, " & _
    "A.PRC_ERROR AS PRC_ERROR, A.PRC_ERROR as GRAF_ERROR ,A.SNI_NOMBRE as ERR_DESC,A.PRC_ERROR as DESCRIP,  C.TES_ORDENIMP AS ORDEN, A.TIM_ID AS MUESTRA, AR.ARE_NOMBRE AS SECC, C.TES_PADRE, " & tes_padre & " as TES_PADRE1, " & CInt(tim_padre) & " as TIM_ID1, AR.ARE_ID, C.TES_ID " & _
    "FROM UNIDAD AS D, TEST AS C, RES_PROCESADOS AS A, SNI AS G, EQUIPO AS E, " & _
    "TEST_EQUIPO AS B, AREA AS AR WHERE C.TES_TIPO = 'Parametro' AND C.TES_PADRE = " & tes_padre & " AND AR.ARE_ID = C.ARE_ID AND A.TIM_ID = C.TIM_ID AND A.SNI_NOMBRE = G.SNI_NOMBRE AND G.SNI_NOMBRE = E.SNI_NOMBRE AND " & _
    "B.TEQ_ABRV_FIJA = A.TES_ABREV AND E.EQU_ID = B.EQU_ID AND C.TES_ID = B.TES_ID AND " & _
    " D.UNI_ID = B.UNI_ID AND A.PED_ID = " & ped_id & ""

                str_sql = str_sql & " " & str_aux
            Else

                str_sql = "SELECT distinct(A.PED_ID) AS PED_ID, A.PRC_FECHA AS PRC_FECHA, A.PRC_HORA AS PRC_HORA, " & _
    "B.TEQ_ABRV_FIJA AS TEQ_ABRV_FIJA, C.TES_NOMBRE AS TES_NOMBRE, case when (A.PRC_RESUL = '') then ('') else (A.PRC_RESUL) end AS PRC_RESUL, case when (A.PRC_RESFINAL = '') then (A.PRC_TEXTO) else (A.PRC_RESFINAL) end AS PRC_RESULM, " & _
    "D.UNI_NOMENCLATURA AS UNI_NOMENCLATURA, " & _
    "case when (B.TEQ_TRANGO = 0) then '' when  (B.TEQ_TRANGO = 1) then (CONVERT(nvarchar(255),LTRIM(RTRIM(str(ISNULL(teq_ranmin,0),20," & decimales & ")))) + ' - ' + CONVERT(nvarchar(255),LTRIM(RTRIM(str(ISNULL(teq_ranmax,0),20," & decimales & "))))) else  (B.TEQ_RANMUL) end AS RANGO_NORMAL, " & _
    "A.PRC_ERROR AS PRC_ERROR, A.PRC_ERROR as GRAF_ERROR ,A.SNI_NOMBRE as ERR_DESC,A.PRC_ERROR as DESCRIP, " & _
    "C.TES_ORDENIMP AS ORDEN, A.TIM_ID AS MUESTRA, AR.ARE_NOMBRE AS SECC, C.TES_PADRE, " & tes_padre & " as TES_PADRE1, " & CInt(tim_padre) & " as TIM_ID1, AR.ARE_ID, C.TES_ID " & _
    "FROM UNIDAD AS D, TEST AS C, RES_PROCESADOS AS A, SNI AS G, EQUIPO AS E, " & _
    "TEST_EQUIPO AS B, AREA AS AR WHERE C.TES_TIPO = 'Parametro' AND C.TES_ID IN(" & tes_hijos & ") AND AR.ARE_ID = C.ARE_ID AND A.SNI_NOMBRE = G.SNI_NOMBRE AND G.SNI_NOMBRE = E.SNI_NOMBRE AND " & _
    "B.TEQ_ABRV_FIJA = A.TES_ABREV AND E.EQU_ID = B.EQU_ID AND C.TES_ID = B.TES_ID AND " & _
    " D.UNI_ID = B.UNI_ID AND A.PED_ID = " & ped_id & " AND A.TIM_ID = " & tim_padre & ""
                str_sql = str_sql & " " & str_aux
            End If
        Else    'CUANDO SE TRATA DE VISUALIZACION DE RESULTADOS  (ENTREGA)
            str_sql = "Select res_procesados.PED_ID AS PED_ID, res_procesados.PRC_FECHA AS PRC_FECHA, res_procesados.PRC_HORA AS PRC_HORA," & _
            "res_procesados.TES_ABREV AS TEQ_ABRV_FIJA, test.TES_NOMBRE AS TES_NOMBRE, res_procesados.PRC_RESUL AS PRC_RESUL," & _
            "res_procesados.PRC_RESFINAL AS PRC_RESULM, unidad.UNI_NOMENCLATURA AS UNI_NOMENCLATURA, " & _
            "res_procesados.PRC_RANGO AS RANGO_NORMAL, res_procesados.PRC_ERROR AS PRC_ERROR," & _
            "res_procesados.PRC_ERROR as GRAF_ERROR, sni.SNI_NOMBRE as ERR_DESC, res_procesados.PRC_ERROR as DESCRIP, " & _
            "test.TES_ORDENIMP AS ORDEN, area.ARE_NOMBRE as SECC from (lista_trabajo, pedido, paciente, medico, area, test, test_equipo, res_procesados, " & _
            "unidad, equipo, sni) where (lista_trabajo.LIS_RESESTADO = 0 or lista_trabajo.LIS_RESESTADO = 2 or lista_trabajo.LIS_RESESTADO = 9)and res_procesados.tim_id = test.tim_id and lista_trabajo.equ_id = equipo.equ_id and equipo.sni_nombre = sni.sni_nombre and " & _
            "test_equipo.uni_id = unidad.uni_id and pedido.ped_id = res_procesados.ped_id and lista_trabajo.ped_id = pedido.ped_id and " & _
            "pedido.pac_id = paciente.pac_id and medico.med_id = pedido.med_id and lista_trabajo.tes_id = test.tes_id and test.are_id = area.are_id " & _
            "and test.tes_id = test_equipo.tes_id and res_procesados.tes_abrev = test_equipo.teq_abrv_fija and lista_trabajo.ped_id = " & ped_id & " and " & _
            "not isnull(lista_trabajo.equ_id) and lista_trabajo.tes_id <> 1 " & _
            "UNION " & _
            "SELECT RES_PROCESADOS.PED_ID AS PED_ID, RES_PROCESADOS.PRC_FECHA AS PRC_FECHA, RES_PROCESADOS.PRC_HORA AS PRC_HORA, " & _
            "RES_PROCESADOS.TES_ABREV AS TEQ_ABRV_FIJA, TEST.TES_NOMBRE AS TES_NOMBRE, RES_PROCESADOS.PRC_RESUL AS PRC_RESUL, " & _
            "RES_PROCESADOS.PRC_RESFINAL AS PRC_RESULM, UNIDAD.UNI_NOMENCLATURA AS unidad, RES_PROCESADOS.PRC_RANGO AS RANGO_NORMAL, " & _
            "RES_PROCESADOS.PRC_ERROR AS PRC_ERROR, RES_PROCESADOS.PRC_ERROR as GRAF_ERROR, SNI.SNI_NOMBRE as ERR_DESC,RES_PROCESADOS.PRC_ERROR as DESCRIP, " & _
            "TEST.TES_ORDENIMP AS ORDEN, AREA.ARE_NOMBRE as SECC FROM AREA, UNIDAD, TEST, PACIENTE, MEDICO, EQUIPO, RES_PROCESADOS, TEST_EQUIPO, PEDIDO, " & _
            "SNI WHERE RES_PROCESADOS.TIM_ID = TEST.TIM_ID and EQUIPO.SNI_NOMBRE = SNI.SNI_NOMBRE AND MEDICO.MED_ID = PEDIDO.MED_ID AND UNIDAD.UNI_ID = TEST_EQUIPO.UNI_ID AND " & _
            "AREA.ARE_ID = TEST.ARE_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND TEST.TES_ID = TEST_EQUIPO.TES_ID AND EQUIPO.EQU_ID = TEST_EQUIPO.EQU_ID AND " & _
            "RES_PROCESADOS.PED_ID = PEDIDO.PED_ID AND RES_PROCESADOS.TES_ABREV = TEST_EQUIPO.TEQ_ABRV_FIJA AND RES_PROCESADOS.PED_ID=" & ped_id & " AND TEST_EQUIPO.EQU_ID=EQUIPO.equ_id AND " & _
            "EQUIPO.SNI_NOMBRE = RES_PROCESADOS.sni_nombre AND (RES_PROCESADOS.TES_ABREV = 'WBC' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'WBCH' OR RES_PROCESADOS.TES_ABREV = 'WBCN' OR RES_PROCESADOS.TES_ABREV = 'NEU' OR RES_PROCESADOS.TES_ABREV = 'NEUH' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'NEUN' OR RES_PROCESADOS.TES_ABREV = 'LYM' OR RES_PROCESADOS.TES_ABREV = 'LYMH' OR RES_PROCESADOS.TES_ABREV = 'LYMN' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MONO' OR RES_PROCESADOS.TES_ABREV = 'MONOH' OR RES_PROCESADOS.TES_ABREV = 'MONON' OR RES_PROCESADOS.TES_ABREV = 'EOS' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'EOSH' OR RES_PROCESADOS.TES_ABREV = 'EOSN' OR RES_PROCESADOS.TES_ABREV = 'BASO' OR RES_PROCESADOS.TES_ABREV = 'BASOH' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'BASON' OR RES_PROCESADOS.TES_ABREV = 'NEU%25' OR RES_PROCESADOS.TES_ABREV = 'NEU%25H' OR RES_PROCESADOS.TES_ABREV = 'NEU%25N' " & _
            "OR RES_PROCESADOS.TES_ABREV = 'LYM%25' OR RES_PROCESADOS.TES_ABREV = 'LYM%25H' OR RES_PROCESADOS.TES_ABREV = 'LYM%25N' OR RES_PROCESADOS.TES_ABREV = 'MONO%25' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MONO%25H' OR RES_PROCESADOS.TES_ABREV = 'MONO%25N' OR RES_PROCESADOS.TES_ABREV = 'EOS%25' OR RES_PROCESADOS.TES_ABREV = 'EOS%25H' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'EOS%25N' OR RES_PROCESADOS.TES_ABREV = 'BASO%25' OR RES_PROCESADOS.TES_ABREV = 'BASO%25H' OR RES_PROCESADOS.TES_ABREV = 'BASO%25N' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'RBC' OR RES_PROCESADOS.TES_ABREV = 'RBCH' OR RES_PROCESADOS.TES_ABREV = 'RBCN' OR RES_PROCESADOS.TES_ABREV = 'HGB' OR RES_PROCESADOS.TES_ABREV = 'HGBH' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'HGBN' OR RES_PROCESADOS.TES_ABREV = 'HCT' OR RES_PROCESADOS.TES_ABREV = 'HCTH' OR RES_PROCESADOS.TES_ABREV = 'HCTN' OR RES_PROCESADOS.TES_ABREV = 'MCV' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MCVH' OR RES_PROCESADOS.TES_ABREV = 'MCVN' OR RES_PROCESADOS.TES_ABREV = 'MCH' OR RES_PROCESADOS.TES_ABREV = 'MCHH' OR RES_PROCESADOS.TES_ABREV = 'MCHN' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MCHC' OR RES_PROCESADOS.TES_ABREV = 'MCHCH' OR RES_PROCESADOS.TES_ABREV = 'MCHCN' OR RES_PROCESADOS.TES_ABREV = 'RDWSD' OR RES_PROCESADOS.TES_ABREV = 'RDWSDH' OR RES_PROCESADOS.TES_ABREV = 'RDWSDN' OR RES_PROCESADOS.TES_ABREV = 'RDWCV' OR RES_PROCESADOS.TES_ABREV = 'RDWCVH' OR RES_PROCESADOS.TES_ABREV = 'RDWCVN' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'RDWSDN' OR RES_PROCESADOS.TES_ABREV = 'PLT' OR RES_PROCESADOS.TES_ABREV = 'PLTH' OR RES_PROCESADOS.TES_ABREV = 'PLTN' OR RES_PROCESADOS.TES_ABREV = 'MPV' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MPVH' OR RES_PROCESADOS.TES_ABREV = 'MPVN' or " & _
            "RES_PROCESADOS.TES_ABREV = 'WBCR' or RES_PROCESADOS.TES_ABREV = 'NEU%25R' OR RES_PROCESADOS.TES_ABREV = 'LYM%25R' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MONO%25R' OR RES_PROCESADOS.TES_ABREV = 'EOS%25R' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'BASO%25R' OR RES_PROCESADOS.TES_ABREV = 'RBCR' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'HGBR' OR RES_PROCESADOS.TES_ABREV = 'HCTR' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MCVR' OR RES_PROCESADOS.TES_ABREV = 'MCHR' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MCHCR' OR RES_PROCESADOS.TES_ABREV = 'RDWSDR' OR RES_PROCESADOS.TES_ABREV = 'RDWCVR' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'PLTR' OR RES_PROCESADOS.TES_ABREV = 'MPVR' or RES_PROCESADOS.TES_ABREV = 'MID%25' OR RES_PROCESADOS.TES_ABREV = 'MID%25H' OR " & _
            "RES_PROCESADOS.TES_ABREV = 'MID%25N' OR RES_PROCESADOS.TES_ABREV = 'MID%25R' OR RES_PROCESADOS.TES_ABREV = 'GRAN%25' OR RES_PROCESADOS.TES_ABREV = 'GRAN%25H' OR RES_PROCESADOS.TES_ABREV = 'GRAN%25N' OR RES_PROCESADOS.TES_ABREV = 'GRAN%25R') order by ORDEN"


        End If
        str_sql = str_sql & " order by C.TES_ORDENIMP "
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerResultadoPedidoP = New DataSet()
        oda_operacion.Fill(LeerResultadoPedidoP, "Registros")
        opr_Conexion.sql_desconn()

        'If res_id = 4 Then

        'End If
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Resultado Pedido", Err)
        Err.Clear()
    End Function


    Public Function LeerResultadoPedidoAB(ByVal ped_id As Integer, ByVal tipo As Byte, ByVal tes_padre As Integer) As DataSet
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String

        opr_Conexion.sql_conectar()
        If tipo = 0 Then  'CUANDO SE TRATA DE VALIDACION DE RESULTADOS 
            'validacion por areas.
            Dim str_Areas As String
            Dim opr_user As New Cls_Usuario()
            Dim arr_datos As New ArrayList()
            Dim arr_nombre As New ArrayList()
            Dim int_i As Integer = 0


            'rfn
            str_sql = "select RAB.ANB_ID, AB.ANB_NOMBRE, RAB.PRC_RESUL AS ANB_RESULTADO, ARE_ID From antibiotico as AB, resab_procesados as RAB, pedido as P where AB.ANB_ID = RAB.ANB_ID and RAB.PED_ID = " & ped_id & " and RAB.TES_ID = " & tes_padre & " and P.PED_ID = RAB.PED_ID ORDER BY AB.ANB_ORDEN asc"


        Else    'CUANDO SE TRATA DE VISUALIZACION DE RESULTADOS  (ENTREGA)

            str_sql = ""
        End If

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerResultadoPedidoAB = New DataSet()
        oda_operacion.Fill(LeerResultadoPedidoAB, "RegistrosRESAB")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Resultado Antibioticos", Err)
        Err.Clear()
    End Function

    Public Sub ResultadoValidado(ByVal ped_id As Integer, ByVal tes_id As Integer)
        'Procedimiento para la actualizar el campo estado de los resultados 
        'Definiendolos como validados
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand("update lista_trabajo set lis_resestado = 1 " & _
        "where ped_id = " & ped_id & " And tes_id = " & tes_id & "", opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Resultado Valido", Err)
        Err.Clear()
    End Sub

    Public Function LeerResultadoM(ByVal ped_id As Integer, ByRef tipo As String) As DataSet
        'Funci�n para la consultar los resultados manuales de un pedido
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        'Resultados Manuales de test manuales y test autom�ticos seleccionados como manuales
        'JPO: 09/Feb/2004
        'Cambio para consultar los test en funci�n del tipo de procesamiento que tuvieron en la lista de trabajo.
        'Dim STR_SQL = "SELECT LISTA_TRABAJO.LIS_RESMANUAL, TEST.TES_NOMBRE, TEST.TES_ID, UNIDAD.UNI_NOMENCLATURA, TEST_RESULTADO.RANG_TIPO, TEST_RESULTADO.RANG_MIN, TEST_RESULTADO.RANG_MAX, TEST_RESULTADO.RANG_MUL FROM (UNIDAD INNER JOIN (TEST INNER JOIN LISTA_TRABAJO ON TEST.TES_ID = LISTA_TRABAJO.TES_ID) ON UNIDAD.UNI_ID = TEST.UNI_ID) INNER JOIN TEST_RESULTADO ON TEST.TES_ID = TEST_RESULTADO.TES_ID WHERE LISTA_TRABAJO.PED_ID=" & ped_id & " and (LISTA_TRABAJO.LIS_RESESTADO = 2 or LISTA_TRABAJO.LIS_RESESTADO = 9) AND ISNULL(LISTA_TRABAJO.EQU_ID) AND LISTA_TRABAJO.TES_ID <> 1 "
        If (tipo = "Validacion") Then
            STR_SQL = "SELECT LISTA_TRABAJO.LIS_RESMANUAL, TEST.TES_NOMBRE, TEST.TES_ID, UNIDAD.UNI_NOMENCLATURA, TEST_RESULTADO.RANG_TIPO, TEST_RESULTADO.RANG_MIN, TEST_RESULTADO.RANG_MAX, TEST_RESULTADO.RANG_MUL FROM (UNIDAD INNER JOIN (TEST INNER JOIN LISTA_TRABAJO ON TEST.TES_ID = LISTA_TRABAJO.TES_ID) ON UNIDAD.UNI_ID = TEST.UNI_ID) INNER JOIN TEST_RESULTADO ON TEST.TES_ID = TEST_RESULTADO.TES_ID WHERE LISTA_TRABAJO.PED_ID=" & ped_id & " AND ISNULL(LISTA_TRABAJO.EQU_ID) AND LISTA_TRABAJO.TES_ID <> 1  "
        End If
        If (tipo = "Entrega") Then
            STR_SQL = "SELECT LISTA_TRABAJO.LIS_RESMANUAL, TEST.TES_NOMBRE, TEST.TES_ID, UNIDAD.UNI_NOMENCLATURA, TEST_RESULTADO.RANG_TIPO, TEST_RESULTADO.RANG_MIN, TEST_RESULTADO.RANG_MAX, TEST_RESULTADO.RANG_MUL FROM (UNIDAD INNER JOIN (TEST INNER JOIN LISTA_TRABAJO ON TEST.TES_ID = LISTA_TRABAJO.TES_ID) ON UNIDAD.UNI_ID = TEST.UNI_ID) INNER JOIN TEST_RESULTADO ON TEST.TES_ID = TEST_RESULTADO.TES_ID WHERE LISTA_TRABAJO.PED_ID=" & ped_id & " AND ISNULL(LISTA_TRABAJO.EQU_ID) AND LISTA_TRABAJO.TES_ID <> 9 and  (LISTA_TRABAJO.LIS_RESESTADO = 0 or LISTA_TRABAJO.LIS_RESESTADO = 2 or LISTA_TRABAJO.LIS_RESESTADO = 9)  "
        End If
        Dim str_areas As String
        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0
        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, str_areas, arr_nombre)

        Dim x, i As Short
        Dim areas() As String
        Dim str_aux As String = " and ("
        areas = Split(str_areas, ",")
        x = UBound(areas)
        'en caso de que exista areas a donde consultar
        If x > 0 Then
            For i = 0 To (x - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) ORDER BY TEST.TES_ORDENIMP "
        End If
        'ROSS
        STR_SQL = STR_SQL & " " & str_aux
        'STR_SQL = STR_SQL & " UNION SELECT LISTA_TRABAJO.LIS_RESMANUAL, TEST.TES_NOMBRE, TEST.TES_ID, UNIDAD.UNI_NOMENCLATURA, TEST_RESULTADO.RANG_TIPO, TEST_RESULTADO.RANG_MIN, TEST_RESULTADO.RANG_MAX, TEST_RESULTADO.RANG_MUL FROM (UNIDAD INNER JOIN (TEST INNER JOIN LISTA_TRABAJO ON TEST.TES_ID = LISTA_TRABAJO.TES_ID) ON UNIDAD.UNI_ID = TEST.UNI_ID) INNER JOIN TEST_RESULTADO ON TEST.TES_ID = TEST_RESULTADO.TES_ID WHERE LISTA_TRABAJO.PED_ID=" & ped_id & " AND TEST.TES_TPROCES = 1 And TEST.TES_NOMBRE <> 'BIOMETRIA HEMATICA' AND LISTA_TRABAJO.EQU_ID Is NULL"
        'STR_SQL = STR_SQL & " " & str_aux
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)

        LeerResultadoM = New DataSet()
        oda_operacion.Fill(LeerResultadoM, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer ResultadoM", Err)
        Err.Clear()
    End Function

    Public Function LeerRangNormal(ByVal tes_nombre As String, ByVal abrv_fija As String) As DataSet
        'Funci�n para la consultar el rango de normalidad de un test en funci�n de su nombre
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        tes_nombre = Trim(tes_nombre)
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql = "SELECT TEST.TES_NOMBRE, TEST_EQUIPO.TEQ_TRANGO, case when TEST_EQUIPO.TEQ_RANMIN <> '' then TEST_EQUIPO.TEQ_RANMIN else '' end as TEQ_RANMIN, " & _
                      "case when TEST_EQUIPO.TEQ_RANMAX <> '' then TEST_EQUIPO.TEQ_RANMAX else '' end as TEQ_RANMAX, TEST_EQUIPO.TEQ_RANMUL,TEST_EQUIPO.TEQ_ABRV_FIJA FROM TEST INNER JOIN " & _
                      "TEST_EQUIPO ON TEST.TES_ID = TEST_EQUIPO.TES_ID WHERE TEST.TES_NOMBRE ='" & tes_nombre & "'and TEST_EQUIPO.TEQ_ABRV_FIJA= '" & abrv_fija & "'"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerRangNormal = New DataSet()
        oda_operacion.Fill(LeerRangNormal, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Rang Normal", Err)
        Err.Clear()
    End Function


    Public Function LeerHistorico(ByVal ped_id As Integer, ByVal abrv_fija As String, ByVal tim_id As Integer) As String
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()

        Dim str_sql = "select PRC_RESFINAL  " & _
                       "from res_procesados where ped_id = " & ped_id & _
                       " and tes_abrev = '" & abrv_fija & "' and TIM_ID = " & tim_id & _
                       " and PRC_RESFINAL <> ''"

        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        Dim dts_err As New DataSet()
        Dim dtr_fila As DataRow
        Dim boo_desc As Boolean = False
        dt_operacion.Fill(dts_err, "Registros")

        For Each dtr_fila In dts_err.Tables(0).Rows
            LeerHistorico = dtr_fila(0).ToString
        Next
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Rang Normal", Err)
        Err.Clear()
    End Function

    Public Function LeerAntibioticos(ByVal dtv_resAB As DataView, ByVal ped_id As Integer, ByVal tes_padre As Integer) As DataSet
        'Funci�n para la consultar el rango de normalidad de un test en funci�n de su nombre
        On Error GoTo MsgError
        Dim x As Integer = 0
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = ""
        str_sql = "select RAB.ANB_ID, AB.ANB_NOMBRE, RAB.PRC_RESUL AS ANB_RESULTADO From antibiotico as AB, resab_procesados as RAB, pedido as P where AB.ANB_ID = RAB.ANB_ID and RAB.PRC_RESUL <>'' and RAB.PED_ID = " & ped_id & " and RAB.TES_ID = " & tes_padre & " and P.PED_ID = RAB.PED_ID ORDER BY AB.ANB_ORDEN asc"
        Dim dtr_fila As DataRow

        opr_Conexion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        LeerAntibioticos = New DataSet()
        oda_operacion.Fill(LeerAntibioticos, "RegistrosAB")
        opr_Conexion.sql_desconn()

        'For x = 0 To dtv_resAB.Table.Rows.Count - 1
        '    If dtv_resAB.Item(x).Row(0) = odr_operacion.GetValue(0).ToString Then
        '        dtr_fila(0) = odr_operacion.GetValue(0).ToString()
        '        dtr_fila(1) = odr_operacion.GetValue(1).ToString()
        '        dtr_fila(2) = dtv_resAB.Item(x).Row(2)
        '    Else
        '        dtr_fila(0) = odr_operacion.GetValue(0).ToString()
        '        dtr_fila(1) = odr_operacion.GetValue(1).ToString()
        '        dtr_fila(2) = odr_operacion.GetValue(1).ToString()
        '    End If
        'Next

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Antibioticos", Err)
        Err.Clear()
    End Function


    Public Function ValidarResultados(ByVal ped_id As Integer, ByRef dtt_resPedido As DataTable, ByVal aareas As String, ByVal LabOcup As Byte) As DataSet
        'funcion que devuelve todos los test de un pedido y su respectivo estado de procesamiento y si fueron repetidos.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String = Nothing
        Dim STR_SQL2 As String = Nothing
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()

        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0

        Dim str_aux As String = " and TEST.are_id in (" & aareas & ")"

        'Selecciona todos los test de un pedido indicando si est� procesado y si se repitio

        STR_SQL = "SELECT PEDIDO_DETALLE_DESGLOSADO.tes_id as TES_ID, TEST.tes_nombre as TES_NOMBRE, '                              ' AS PER_ID, '                              ' AS PER_NOMBRE, " & _
                  "case when (PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 0 or PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 2 or LISTA_TRABAJO.lis_resestado = 0) then 'False' else 'True' end as PROCESADO,  " & _
                  "case when (PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 3 or PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 0 or PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 1) then  'False' else  'True' end AS OK, LISTA_TRABAJO.LIS_RESESTADO as ESTADO, " & _
                  "case when (LISTA_TRABAJO.LIS_RESESTADO = 9) then  'True' else 'False' end as REMITIDO, PEDIDO.PED_FECING, (PACIENTE.PAC_APELLIDO +' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PEDIDO.PED_TURNO AS TURNO, PACIENTE.PAC_MAIL AS CORREO, PACIENTE.PAC_ID AS PAC_ID, CONVENIO.CON_TIPO AS TIPO, CONVENIO.con_web_email as CONVENIOMAIL, PACIENTE.PAC_FECNAC, test_resultado.RES_ID " & _
                  "FROM TEST, PEDIDO_DETALLE_DESGLOSADO, LISTA_TRABAJO, PEDIDO, PACIENTE, CONVENIO, TEST_RESULTADO " & _
                  "WHERE CONVENIO.con_nombre = PEDIDO.PED_TIPO and PACIENTE.PAC_ID = PEDIDO.PAC_ID and PEDIDO.PED_ID = PEDIDO_DETALLE_DESGLOSADO.PED_ID and PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and LISTA_TRABAJO.PED_ID = PEDIDO_DETALLE_DESGLOSADO.PED_ID and TEST.tes_id = PEDIDO_DETALLE_DESGLOSADO.tes_id And PEDIDO_DETALLE_DESGLOSADO.ped_id = " & ped_id & " And LISTA_TRABAJO.tes_id = TEST.tes_id And LISTA_TRABAJO.ped_id = PEDIDO_DETALLE_DESGLOSADO.ped_id And PEDIDO_DETALLE_DESGLOSADO.PER_ID Is NULL and test_resultado.TES_ID = test.TES_ID and test_resultado.tes_id = lista_trabajo.TES_ID and test_resultado.TES_ID = pedido_detalle_desglosado.TES_ID "
        STR_SQL = STR_SQL & str_aux

        STR_SQL2 = "UNION SELECT PERFIL_TEST.TES_ID AS TES_ID, TEST.TES_NOMBRE AS TES_NOMBRE, PEDIDO_DETALLE_DESGLOSADO.PER_ID AS PER_ID, PERFIL.PER_NOMBRE AS PER_NOMBRE, " & _
                   "case when (PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 0 or PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 2 OR LISTA_TRABAJO.lis_resestado = 0 or LISTA_TRABAJO.lis_resestado = 3 or LISTA_TRABAJO.lis_resestado = 4) then 'False' else 'True' end AS PROCESADO, " & _
                   "case when (PEDIDO_DETALLE_DESGLOSADO.pdd_estado = 2) then 'True' else 'False' end AS OK, LISTA_TRABAJO.LIS_RESESTADO as ESTADO, " & _
                   "case when (LISTA_TRABAJO.LIS_RESESTADO = 9) then  'True' else 'False' end as REMITIDO, PEDIDO.PED_FECING, (PACIENTE.PAC_APELLIDO +' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PEDIDO.PED_TURNO AS TURNO, PACIENTE.PAC_MAIL AS CORREO, PACIENTE.PAC_ID AS PAC_ID, CONVENIO.CON_TIPO AS TIPO, CONVENIO.con_web_email as CONVENIOMAIL, PACIENTE.PAC_FECNAC, test_resultado.RES_ID " & _
                   "FROM PERFIL, TEST, PERFIL_TEST, PEDIDO_DETALLE_DESGLOSADO, LISTA_TRABAJO, PEDIDO, PACIENTE, CONVENIO, TEST_RESULTADO " & _
                   "WHERE CONVENIO.con_nombre = PEDIDO.PED_TIPO and PACIENTE.PAC_ID = PEDIDO.PAC_ID and PEDIDO.PED_ID = PEDIDO_DETALLE_DESGLOSADO.PED_ID and PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and LISTA_TRABAJO.PED_ID = PEDIDO_DETALLE_DESGLOSADO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID AND TEST.TES_ID = PEDIDO_DETALLE_DESGLOSADO.TES_ID and PERFIL.PER_ID = PEDIDO_DETALLE_DESGLOSADO.PER_ID and TEST.TES_ID = PERFIL_TEST.TES_ID and PERFIL.PER_ID = PERFIL_TEST.PER_ID and PERFIL_TEST.TES_ID=TEST.TES_ID AND PEDIDO_DETALLE_DESGLOSADO.PER_ID= PERFIL_TEST.PER_ID And PEDIDO_DETALLE_DESGLOSADO.PER_ID=PERFIL.PER_ID And PEDIDO_DETALLE_DESGLOSADO.PER_ID Is Not Null AND PEDIDO_DETALLE_DESGLOSADO.PED_ID = LISTA_TRABAJO.PED_ID and test_resultado.TES_ID = test.TES_ID and test_resultado.tes_id = lista_trabajo.TES_ID and test_resultado.TES_ID = pedido_detalle_desglosado.TES_ID AND PEDIDO_DETALLE_DESGLOSADO.PED_ID = " & ped_id & ""
        STR_SQL2 = STR_SQL2 & str_aux

        STR_SQL = STR_SQL & STR_SQL2

        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_resPedido)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Validar resultados", Err)
        Err.Clear()
    End Function


    Public Function RemitirResultados(ByVal ped_id As Integer, ByRef dtt_resPedido As DataTable) As DataSet
        'funcion que devuelve todos los test de un pedido y su respectivo estado de procesamiento y si fueron repetidos.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()

        Dim STR_AREAS As String

        Dim opr_user As New Cls_Usuario()
        Dim arr_datos As New ArrayList()
        Dim arr_nombre As New ArrayList()
        Dim int_i As Integer = 0
        opr_user.LeerAreasUsuario(g_sng_user, arr_datos, g_EsOcupacional, STR_AREAS, arr_nombre)

        Dim x, i As Short
        Dim areas() As String
        Dim str_aux As String = " and ("
        areas = Split(STR_AREAS, ",")
        x = UBound(areas)
        'en caso de que exista areas a donde consultar
        If x > 0 Then
            For i = 0 To (x - 1)
                If i = 0 Then
                    str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                Else
                    str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                End If
            Next
            str_aux = str_aux & " ) "
        End If

        'Selecciona todos los test de un pedido indicando si est� procesado y si se repitio
        STR_SQL = "Select LISTA_TRABAJO.tes_id as TES_ID, TEST.tes_nombre as TES_NOMBRE, if(LISTA_TRABAJO.lis_resestado = 9 ,'True','False') as REMITIDO, '...' as Buscar, LISTA_TRABAJO.LIS_RESESTADO as ESTADO, if(LISTA_TRABAJO.LIS_MIS is null, '',LISTA_TRABAJO.LIS_MIS) as ARCHIVO, if(LISTA_TRABAJO.LIS_EQUERROR is null, '', LISTA_TRABAJO.LIS_EQUERROR) as LABORATORIO, '...' as VER FROM TEST, LISTA_TRABAJO WHERE LISTA_TRABAJO.ped_id = " & ped_id & " And LISTA_TRABAJO.tes_id = TEST.tes_id "
        'STR_SQL = "Select LISTA_TRABAJO.tes_id as TES_ID, TEST.tes_nombre as TES_NOMBRE, if(LISTA_TRABAJO.lis_resestado = 9 ,'True','False') as REMITIDO, LISTA_TRABAJO.LIS_RESESTADO as ESTADO, '        ' as ARCHIVO, '        ' as LABORATORIO, REMITIDOS.rem_id  FROM TEST, LISTA_TRABAJO, REMITIDOS, LAB_REMITIDOS, PEDIDO WHERE REMITIDOS.ped_id = LISTA_TRABAJO.PED_ID and PEDIDO.PED_ID = REMITIDOS.ped_id and PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID and LAB_REMITIDOS.lar_id = REMITIDOS.lar_id and LISTA_TRABAJO.ped_id = " & ped_id & ""
        STR_SQL = STR_SQL & " " & str_aux
        STR_SQL = STR_SQL & " group by tes_id"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_operacion.Fill(dtt_resPedido)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Validar resultados", Err)
        Err.Clear()
    End Function



    Public Sub ResAutoFinal(ByVal Padre As Integer, ByVal ped_id As Integer, ByVal abrev As String, ByVal resul As String, ByVal rango As String, ByVal tim_id As Integer, ByVal esremitido As Integer, ByVal tim_Padre As Integer, ByVal Tes_IdPadre As Integer)
        '07/Ago/2013
        'Procedimiento para la almacenar el resultado automotico final luego de la validacion
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql, str_sql2, prc_error As String
        Dim arreglo As String()
        On Error GoTo MsgError
        opr_Conexion.sql_conectar()
        prc_error = ""
        arreglo = Split(rango, "-")

        '****************************
        If resul <> "" Then
            If IsNumeric(resul) Then
                If (arreglo.Length = 2) Then
                    If IsNumeric(Trim(arreglo(0))) Then
                        If Convert.ToDouble(resul) < Convert.ToDouble(arreglo(0)) Then
                            prc_error = "*"
                        End If
                        If Convert.ToDouble(resul) > Convert.ToDouble(arreglo(1)) Then
                            prc_error = "*"
                        End If
                    Else
                        prc_error = ""
                    End If
                End If
            End If
        Else

        End If
        If (arreglo.Length > 2) Then

        End If
        '***************************

        If (esremitido = 9) Then
            str_sql = "update res_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "', prc_rango = '" & rango & "', prc_alarma = '" & prc_error & "', PRC_TEXTO = 'MEMO' where ped_id = " & ped_id & " And TES_ABREV = '" & Trim(abrev) & "' and tim_id = " & tim_id & " ;" 'and TES_PADRE = " & Tes_IdPadre & ";"
            str_sql2 = "update res_procesados set prc_texto = 'MEMO' where ped_id = " & ped_id & " And tes_padre = " & Tes_IdPadre & " and tim_id = " & tim_id & ";"

        Else
            str_sql = "update res_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "', prc_rango = '" & rango & "', prc_alarma = '" & prc_error & "', PRC_TEXTO = 'MEMO' where ped_id = " & ped_id & " And TES_ABREV = '" & Trim(abrev) & "' and tim_id = " & tim_id & " ;" 'and TES_PADRE = " & Tes_IdPadre & ";"
            str_sql2 = "update res_procesados set prc_texto = 'MEMO' where ped_id = " & ped_id & " And tes_padre = " & Tes_IdPadre & " and tim_id = " & tim_Padre & ";"
        End If
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        Dim odc_pedido2 As SqlCommand = New SqlCommand(str_sql2, opr_Conexion.conn_sql)
        odc_pedido2.ExecuteNonQuery()

        str_sql = "update res_historicos set prc_resfinal = '" & resul & "' where ped_id = " & ped_id & " and tim_id = " & tim_id & " and tes_abrev ='" & abrev & "'"
        Dim odc_res As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_res.ExecuteNonQuery()
        opr_Conexion.sql_desconn()


        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", abrev & "=" & resul, g_sng_user, ped_id, "", abrev)

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ResAuto Final", Err)
        Err.Clear()
    End Sub




    Public Sub ResAutoFinalPlatillas(ByVal Padre As Integer, ByVal ped_id As Integer, ByVal abrev As String, ByVal resul As String, ByVal rango As String, ByVal tim_id As Integer, ByVal esremitido As Integer, ByVal tim_Padre As Integer, ByVal Tes_IdPadre As Integer)
        '07/Ago/2013
        'Procedimiento para la almacenar el resultado autom�tico final luego de la validaci�n
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql, str_sql2, prc_error As String
        Dim arreglo As String()
        On Error GoTo MsgError
        opr_Conexion.sql_conectar()
        prc_error = ""
        arreglo = Split(rango, "-")

        '****************************
        If resul <> "" Then
            If IsNumeric(resul) Then
                If (arreglo.Length = 2) Then
                    If IsNumeric(Trim(arreglo(0))) Then
                        If Convert.ToDouble(resul) < Convert.ToDouble(arreglo(0)) Then
                            prc_error = "*"
                        End If
                        If Convert.ToDouble(resul) > Convert.ToDouble(arreglo(1)) Then
                            prc_error = "*"
                        End If
                    Else
                        prc_error = ""
                    End If
                End If
            End If
        Else

        End If
        If (arreglo.Length > 2) Then

        End If
        '***************************

        If (esremitido = 9) Then
            str_sql = "update res_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "', prc_rango = '" & rango & "', prc_alarma = '" & prc_error & "', PRC_TEXTO = 'MEMO' where ped_id = " & ped_id & " And (TES_ABREV = '" & Trim(abrev) & "' or TES_ABREV = '" & Trim(abrev) & "H' or TES_ABREV = '" & Trim(abrev) & "N' or TES_ABREV = '" & Trim(abrev) & "R') and tim_id = " & tim_Padre & " ;" 'and TES_PADRE = " & Tes_IdPadre & ";"
            str_sql2 = "update res_procesados set prc_texto = 'MEMO' where ped_id = " & ped_id & " And tes_padre = " & Tes_IdPadre & " and tim_id = " & tim_Padre & ";"

        Else
            str_sql = "update res_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "', prc_rango = '" & rango & "', prc_alarma = '" & prc_error & "', PRC_TEXTO = 'MEMO' where ped_id = " & ped_id & " And (TES_ABREV = '" & Trim(abrev) & "' or TES_ABREV = '" & Trim(abrev) & "H' or TES_ABREV = '" & Trim(abrev) & "N' or TES_ABREV = '" & Trim(abrev) & "R') and tim_id = " & tim_Padre & " ;" 'and TES_PADRE = " & Tes_IdPadre & ";"
            str_sql2 = "update res_procesados set prc_texto = 'MEMO' where ped_id = " & ped_id & " And tes_padre = " & Tes_IdPadre & " and tim_id = " & tim_Padre & ";"
        End If
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        Dim odc_pedido2 As SqlCommand = New SqlCommand(str_sql2, opr_Conexion.conn_sql)
        odc_pedido2.ExecuteNonQuery()

        str_sql = "update res_historicos set prc_resfinal = '" & resul & "' where ped_id = " & ped_id & " and tim_id = " & tim_id & " and tes_abrev ='" & abrev & "'"
        Dim odc_res As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_res.ExecuteNonQuery()
        opr_Conexion.sql_desconn()


        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", abrev & "=" & resul, g_sng_user, ped_id, "", abrev)

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ResAuto Final", Err)
        Err.Clear()
    End Sub



    Public Sub ResABFinal(ByVal Padre As Integer, ByVal ped_id As Integer, ByVal abrev As String, ByVal resul As String, ByVal rango As String, ByVal tim_id As Integer, ByVal esremitido As Integer, ByVal tim_Padre As Integer, ByVal Tes_IdPadre As Integer)
        'Procedimiento para la almacenar el resultado de  AB final luego de la validaci�n
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql, str_sql2, prc_error As String
        Dim arreglo As String()
        On Error GoTo MsgError
        opr_Conexion.sql_conectar()
        prc_error = ""
        arreglo = Split(rango, "-")

        '****************************
        If (arreglo.Length = 2) Then
            If Convert.ToDouble(resul) < Convert.ToDouble(arreglo(0)) Then
                prc_error = "*"
            End If
            If Convert.ToDouble(resul) > Convert.ToDouble(arreglo(1)) Then
                prc_error = "*"
            End If
        Else
            prc_error = ""
        End If
        If (arreglo.Length > 2) Then

        End If
        '***************************
        ' Dim str_sql2 As String = "Update RES_PROCESADOS set PRC_RESFINAL = 'MEMO', PRC_RESUL = 'MEMO' where ped_id = " & ped_id & " and TES_ABREV = '" & tes_abrev & "' and TIM_ID = " & tim_id & ";"

        If (esremitido = 9) Then
            str_sql = "insert into resAB_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "'  where ped_id = " & ped_id & " And ANB_CODIGO = '" & abrev & "';"
            str_sql2 = "update res_procesados set prc_texto = 'MEMO' where ped_id = " & ped_id & " And tes_padre = " & Tes_IdPadre & " and tim_id = " & tim_id & ";"

        Else
            str_sql = "insert into resAB_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "'  where ped_id = " & ped_id & " And ANB_CODIGO = '" & abrev & "';"
            str_sql2 = "update res_procesados set prc_texto = 'MEMO' where ped_id = " & ped_id & " And tes_padre = " & Tes_IdPadre & " and tim_id = " & tim_Padre & ";"
        End If
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()

        Dim odc_pedido2 As SqlCommand = New SqlCommand(str_sql2, opr_Conexion.conn_sql)
        odc_pedido2.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ResAuto Final", Err)
        Err.Clear()
    End Sub


    Public Sub ResAutoFinal(ByVal ped_id As Integer, ByVal abrev As String, ByVal resul As String, ByVal rango As String, ByVal tim_id As Integer, ByVal esremitido As Integer, ByVal val_repeticion As String)
        '07/Ago/2013
        'Procedimiento para la almacenar el resultado autom�tico final luego de la validaci�n
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql, prc_error As String
        Dim arreglo As String()
        'On Error GoTo MsgError
        opr_Conexion.sql_conectar()
        prc_error = ""
        arreglo = Split(rango, "-")
        Try
            '****************************
            If (arreglo.Length = 2) Then
                If Convert.ToDouble(resul) < Convert.ToDouble(arreglo(0)) Then
                    prc_error = "*"
                End If
                If Convert.ToDouble(resul) > Convert.ToDouble(arreglo(1)) Then
                    prc_error = "*"
                End If
            Else
                prc_error = ""
            End If
            If (arreglo.Length > 2) Then

            End If
        Catch

        End Try '***************************
        ' Dim str_sql2 As String = "Update RES_PROCESADOS set PRC_RESFINAL = 'MEMO', PRC_RESUL = 'MEMO' where ped_id = " & ped_id & " and TES_ABREV = '" & tes_abrev & "' and TIM_ID = " & tim_id & ";"

        If (esremitido = 9) Then
            str_sql = "update res_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "', prc_rango = '" & rango & "', prc_alarma = '" & prc_error & "',  PRC_TEXTO = '" & resul & "', LIS_USER = '" & g_invitadoID & "', PRC_REPETICION = '" & val_repeticion & "' where ped_id = " & ped_id & " And TES_ABREV = '" & abrev & "' and tim_id = " & tim_id & ";"
            '      str_sql2 = "update res_procesados set prc_resfinal = 'MEMO', prc_resul = 'MEMO' where ped_id = " & ped_id & " And TES_ABREV = '" & abrev & "' and tim_id = " & tim_id & ";"

        Else
            str_sql = "update res_procesados set prc_resfinal = '" & resul & "', prc_resul = '" & resul & "', prc_rango = '" & rango & "', prc_alarma = '" & prc_error & "',  PRC_TEXTO = '" & resul & "',  LIS_USER = '" & g_invitadoID & "', PRC_REPETICION = '" & val_repeticion & "' where ped_id = " & ped_id & " And TES_ABREV = '" & abrev & "' and tim_id = " & tim_id & ";"
        End If
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()


        str_sql = "update res_historicos set prc_resfinal = '" & resul & "' where ped_id = " & ped_id & " and tim_id = " & tim_id & " and tes_abrev ='" & abrev & "';"
        Dim odc_res As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_res.ExecuteNonQuery()
        opr_Conexion.sql_desconn()

        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA RESULTADOS", abrev & "=" & resul, g_sng_user, ped_id, "", abrev)

        Exit Sub
        'MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ResAuto Final", Err)
        Err.Clear()
    End Sub



    Public Function FormatodeResultados(ByVal ped_id As Integer) As DataSet
        'Procedimiento para cargar los datos de los resultados para ingresar manualmente datos de los analizadores.
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String
        opr_Conexion.sql_conectar()
        str_sql = "select pedido_detalle_desglosado.ped_id AS PED_ID, date_format(curdate(), '%d/%m/%Y') AS PRC_FECHA, curtime() AS PRC_HORA, test_equipo.teq_abrv_fija AS TEQ_ABRV_FIJA,test.tes_nombre AS TES_NOMBRE, '' AS PRC_RESUL, '' AS PRC_RESULM, unidad.uni_nomenclatura as UNI_NOMENCLATURA,concat(test_equipo.TEQ_RANMIN , '---' , test_equipo.TEQ_RANMAX , ' ' , test_equipo.TEQ_RANMUL) AS RANGO_NORMAL,'00000' as GRAF_ERROR, '' as ERR_DESC, '' as DESCRIP  FROM pedido_detalle_desglosado, test, test_equipo, unidad where test.tes_id = pedido_detalle_desglosado.tes_id and test.tes_id = test_equipo.tes_id and test_equipo.teq_prioridad = 1 and test_equipo.teq_estado = 1 and pedido_detalle_desglosado.ped_id = " & ped_id & " and test_equipo.uni_id = unidad.uni_id group by pedido_detalle_desglosado.tes_id"
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        FormatodeResultados = New DataSet()
        oda_operacion.Fill(FormatodeResultados, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Formato de Resultados", Err)
        Err.Clear()
    End Function

    Public Function ErrorDesc(ByVal err_id As String, ByVal sni_nombre As String) As String
        'Funcion para consultar la descripci�n de un error en funci�n del codigo del error y el sni_nombre
        On Error GoTo MsgError
        Dim str_desc As String
        If err_id = "" Then
            str_desc = "Sin Resultado"
            Exit Function
        End If
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()

        cls_operacion.sql_conectar()
        Dim str_sql = "SELECT ERROR_EQUIPO.ERR_DESCRIPCION AS ERRDESC FROM EQUIPO LEFT JOIN ERROR_EQUIPO ON EQUIPO.EQU_ID = ERROR_EQUIPO.EQU_ID WHERE (((ERROR_EQUIPO.ERR_ID)='" & err_id & "' ) AND ((EQUIPO.SNI_NOMBRE)='" & sni_nombre & "'))"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        Dim dts_err As New DataSet()
        Dim dtr_fila As DataRow
        Dim boo_desc As Boolean = False
        dt_operacion.Fill(dts_err, "Registros")

        For Each dtr_fila In dts_err.Tables(0).Rows
            str_desc = dtr_fila(0).ToString
            boo_desc = True
        Next
        If boo_desc = False Then
            str_desc = "Error Desconocido"
        End If
        ErrorDesc = str_desc
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ErrorDesc", Err)
        Err.Clear()
    End Function

    Public Sub GuardarRangNormal(ByVal lis_id As Integer, ByVal RangoN As String)
        'Procedimiento para almacenar el rango normal con el que se efectuo una prueba (por que los rangos de normalidad cambian seg�n el reactivo)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL = "Update lista_trabajo set lis_resmanual = '" & RangoN & "' where lis_id = " & lis_id & ""
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar Rango Normal", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarImagen(ByVal ped_id As Integer, ByVal nombre_img As String, ByVal NombreArchivo As String)

        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError

        Dim str_sql As String = Nothing

        str_sql = "Update ptohistograma set File_" & nombre_img & " = '" & NombreArchivo & "' where ped_id = " & ped_id & ""
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()

        Exit Sub
MsgError:
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar imagen ", Err)
        'Err.Clear()
    End Sub


    Public Sub GestionaErrorCorreo(ByVal ped_id As Integer, ByVal ced_orden As String, ByVal cer_descrip As String, ByVal EsNuevo As Boolean)

        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError

        Dim str_sql As String = Nothing
        If EsNuevo = True Then
            str_sql = "Insert into correo_error values(" & ped_id & ",'" & Format(Now, "dd/MM/yyyy HH:mm") & "','" & ced_orden & "','" & cer_descrip & "')"
        Else
            str_sql = "Update correo_error set cer_fecha = '" & Format(Now, "dd/MM/yyyy HH:mm") & "', cer_orden = '" & ced_orden & "', cer_descrip = '" & cer_descrip & "' where ped_id = " & ped_id & ""
        End If
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar error correo ", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarImagenOcupacional(ByVal ped_id As Integer, ByVal nombre_img As String, ByVal NombreArchivo As String)

        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError

        Dim str_sql As String = Nothing

        str_sql = "Update ptoImagen set img_File = '" & NombreArchivo & "' where ped_id = " & ped_id & ""
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar imagen Ocupap", Err)
        Err.Clear()
    End Sub


    Public Sub GuardarImagenByte(ByVal ped_id As Integer, ByVal nombre_img As String, ByVal imageBytes As Byte())

        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        'Dim image As Byte()
        Dim str_sql As String = Nothing

        'str_sql = "Select USUARIO.invitado_id, usu_login, invitado_conectar, invitado_administrador from INVITADO, USUARIO where usuario.invitado_id = invitado.invitado_id and usuario.USU_LOGIN  = @usu "
        str_sql = "Update ptohistograma set " & nombre_img & "_byte = @image where ped_id = " & ped_id & ""
        opr_Conexion.sql_conectar()

        Dim odr_operacion As SqlDataReader ' = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        Dim cmd As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        'cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@image", SqlDbType.Image, 32).Value = imageBytes

        cmd.ExecuteNonQuery()

        'Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        'odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar imagen ", Err)
        Err.Clear()
    End Sub



    Public Sub GuardarAB_procesados(ByVal ped_id As Integer, ByVal AB_Id As Integer, ByVal resultado As String, ByVal Tes_padre As Integer, ByVal AB_nombre As String)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim prc_fecha As String = Format(Now, "yyyy/MM/dd")
        Dim prc_hora As String = Format(Now, "HH:mm")
        Dim STR_SQL As String = Nothing
        If resultado <> "" Then
            STR_SQL = "update RESAB_PROCESADOS set PRC_FECHA = '" & prc_fecha & "', PRC_HORA = '" & prc_hora & "', PRC_RESUL = '" & resultado & "' WHERE PED_ID = " & ped_id & " AND ANB_ID = " & AB_Id & " AND TES_ID = " & Tes_padre & ";"
            opr_Conexion.sql_conectar()
            Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            opr_Conexion.sql_desconn()
        End If

        g_opr_usuario.CargarTransaccion(g_str_login, "GUARDA ANTIBIOGRANA", AB_nombre & "=" & resultado, g_sng_user, ped_id, "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar ResAB_procesados, Cls_Resultado", Err)
        Err.Clear()
    End Sub


    Public Sub EliminarAB_procesados(ByVal ped_id As Integer, ByVal Tes_padre As Integer)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError

        Dim STR_SQL As String = Nothing
        STR_SQL = "delete from RESAB_PROCESADOS where ped_id = " & ped_id & " and Tes_id = " & Tes_padre & ";"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Guardar ResAB_procesados, Cls_Resultado", Err)
        Err.Clear()
    End Sub


    Public Sub GuardaExistenciaTmp(ByVal dgv As DataGridView, ByVal I_EDAD As Char)
        Dim str_sql As String = Nothing
        Dim j As Integer
        Dim opr_pedido As New Cls_Pedido

        opr_pedido.EliminaExistencia(I_EDAD)

        For j = 0 To dgv.Rows.Count - 1
            opr_pedido.GuardarExistencia(dgv.Rows(j).Cells(0).Value, dgv.Rows(j).Cells(6).Value, dgv.Rows(j).Cells(8).Value)
        Next


        Exit Sub


    End Sub

    Public Sub GuardaExistenciaTemporal(ByVal dgv As DataGridView, ByVal I_EDAD As Char)
        Dim str_sql As String = Nothing
        Dim j As Integer
        Dim opr_pedido As New Cls_Pedido

        opr_pedido.EliminaExistenciaTemporal(I_EDAD)

        For j = 0 To dgv.Rows.Count - 1
            opr_pedido.GuardarExistenciaTemporal(dgv.Rows(j).Cells(0).Value, dgv.Rows(j).Cells(1).Value, dgv.Rows(j).Cells(2).Value, dgv.Rows(j).Cells(3).Value, dgv.Rows(j).Cells(4).Value, dgv.Rows(j).Cells(5).Value, dgv.Rows(j).Cells(6).Value, dgv.Rows(j).Cells(7).Value, dgv.Rows(j).Cells(8).Value, dgv.Rows(j).Cells(9).Value)
        Next


        Exit Sub

    End Sub

    Public Sub GuardarRes_procesados(ByVal ped_id As Integer, ByVal prc_fecha As String, ByVal prc_hora As String, ByVal abrev As String, ByVal resultado As String)
        'Procedimiento que almacena resultados en la tabla Res_procesados (para uso de ingreso de BH enforma manual)
        Dim opr_Conexion As New Cls_Conexion()
        On Error GoTo MsgError
        Dim STR_SQL = "Insert into RES_PROCESADOS " & _
        "values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & abrev & "', 'COM2', " & resultado & ", '00000'," & resultado & ", '')"
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, GuardarRes_procesados, Cls_Resultado", Err)
        Err.Clear()
    End Sub



    Public Function LeerEstructuraBH(ByVal tipo As String, ByRef dtt_biometria As DataTable)
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim aux As String = ""
        If tipo <> "MUJER" Then aux = Mid(tipo, 1, 1)
        Dim oda_operacion As SqlDataReader
        'Dim str_sql = "select t.tes_nombre as TEST, te.teq_abrv_fija as ABREV, '' as RESULTADO, u.uni_nomenclatura as UNIDAD, concat(te.TEQ_RANMIN , '---' , te.TEQ_RANMAX , ' ' , te.TEQ_RANMUL) AS RANGO, t.tes_ordenimp as ORDEN from test_equipo as te, test as t, unidad as u where t.tes_id = te.tes_id and te.teq_abreviatura = '" & tipo & "' and u.uni_id = te.uni_id and (te.teq_abrv_fija <> 'LYM" & aux & "' AND te.teq_abrv_fija <> 'GRN" & aux & "' AND te.teq_abrv_fija <> 'MID" & aux & "')"
        Dim str_sql As String = "select t.tes_nombre as TEST, te.teq_abrv_fija as ABREV, '' as RESULTADO, u.uni_nomenclatura as UNIDAD, if(te.teq_trango = 0, 'No definidos', if (te.teq_trango < 2, concat(te.TEQ_RANMIN , '---' , te.TEQ_RANMAX), te.TEQ_RANMUL)) AS RANGO, t.tes_ordenimp as ORDEN from test_equipo as te, test as t, unidad as u where t.tes_id = te.tes_id and te.teq_abreviatura = '" & tipo & "' and u.uni_id = te.uni_id"
        opr_Conexion.sql_conectar()
        oda_operacion = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        While oda_operacion.Read
            Dim dtr_fila As DataRow = dtt_biometria.NewRow
            dtr_fila(0) = oda_operacion.GetValue(0)
            dtr_fila(1) = oda_operacion.GetValue(1)
            dtr_fila(2) = 0
            dtr_fila(3) = oda_operacion.GetValue(3)
            dtr_fila(4) = oda_operacion.GetValue(4)
            dtr_fila(5) = oda_operacion.GetValue(5)
            dtt_biometria.Rows.Add(dtr_fila)
        End While
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, LeerEstructuraBH Cls_resultado", Err)
        Err.Clear()
    End Function

    Public Function LeerResultadoCLEARENCE(ByVal ped_id As Integer) As DataSet
        'Procedimiento para la consultar los resultados de un pedido
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = "Select TES_ABREV, PRC_RESFINAL, TIM_ID from RES_PROCESADOS WHERE PED_ID = " & ped_id & " and (TES_ABREV = 'CREA' or TES_ABREV = 'CREA') ORDER BY TIM_ID"
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerResultadoCLEARENCE = New DataSet()
        dt_operacion.Fill(LeerResultadoCLEARENCE, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, LeerResultadoCLEARENCE", Err)
        Err.Clear()
    End Function


    Public Function ResAspirante(ByVal str_sql_res As String) As String
        'Funcion para consultar 
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()

        Dim BDCmd = New SqlCommand(str_sql_res, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        Dim dts_err As New DataSet()
        Dim dtr_fila As DataRow
        Dim boo_desc As Boolean = False
        ResAspirante = "No realizado"
        dt_operacion.Fill(dts_err, "Registros")
        For Each dtr_fila In dts_err.Tables(0).Rows
            If dtr_fila(0).ToString <> "" Then
                ResAspirante = dtr_fila(0).ToString
            End If
        Next
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ResAspirante", Err)
        Err.Clear()
    End Function

    Public Function ResValidado(ByVal str_sql1 As String) As String
        'Funcion para consultar 
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim BDCmd = New SqlCommand(str_sql1, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        Dim dts_err As New DataSet()
        Dim dtr_fila As DataRow
        Dim boo_desc As Boolean = False
        ResValidado = "D"  'NO DISPONIBLE
        dt_operacion.Fill(dts_err, "Registros")
        For Each dtr_fila In dts_err.Tables(0).Rows
            If dtr_fila(0).ToString <> 2 Then
                ResValidado = "ND"
            End If
        Next
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, ResValidado", Err)
        Err.Clear()
    End Function

    Public Function ConsultarPedidoxTurno(ByVal turno As Integer, ByVal fecha As Date) As Integer
        'funcion que devuelve el pedido teniendo como argumento el turno y la fecha
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "Select ped_id from pedido where ped_turno = " & turno & " And ped_fecing between '" & Format(fecha, "dd/MM/yyyy") & " 00:00:00" & "' and '" & Format(fecha, "dd/MM/yyyy") & " 23:59:59" & "'"
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        ConsultarPedidoxTurno = -1
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                ConsultarPedidoxTurno = -1
            Else
                ConsultarPedidoxTurno = dtr_fila(0)
            End If
            Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, ConsultarPedidoxTurno", Err)
        Err.Clear()
    End Function


    Public Function LeerInterfaz(ByVal ped_id As Integer, ByVal his_nombre As String) As DataSet
        'Procedimiento para la consultar los resultados de un pedido
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim str_sql As String = "select file_diffimage, file_Basoimage, file_RBCimage, file_PLTimage from ptohistograma where ped_id = " & ped_id & " and his_nombre ='" & his_nombre & "';"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerInterfaz = New DataSet()
        dt_operacion.Fill(LeerInterfaz, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Interfaz", Err)
        Err.Clear()
    End Function

    Public Function LeerPreliminar(ByVal str_sql As String) As DataSet
        'Procedimiento para la consultar los resultados de un pedido
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        'Dim str_sql As String = "select pedido.ped_FECing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO))end ) as ped_turno, tes_abrev, tes_nombre, prc_resfinal, TES_ORDENIMP from pedido, res_procesados, test_equipo, test where test.tim_id = res_procesados.tim_id and res_procesados.tes_abrev = teq_abrv_fija And test.tes_id = test_equipo.tes_id And pedido.ped_id = res_procesados.ped_id And pac_id = " & pac_id & " and res_procesados.TES_PADRE = " & tes_id & " and res_procesados.TIM_ID = " & tim_id & " and prc_resfinal <> '' group by pedido.ped_FECing, PEDIDO.PED_TURNO, tes_abrev, tes_nombre, prc_resfinal, TES_ORDENIMP order by TES_ORDENIMP asc;"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerPreliminar = New DataSet()
        dt_operacion.Fill(LeerPreliminar, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Preliminar", Err)
        Err.Clear()
    End Function

    Public Function LeerHistorico(ByVal pac_id As Integer, ByVal abrev As String, ByVal tim_id As Short, ByVal tes_id As Integer) As DataSet
        'Procedimiento para la consultar los resultados de un pedido
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim dt_operacion As SqlDataAdapter = New SqlDataAdapter()
        cls_operacion.sql_conectar()
        Dim str_sql As String = "select pedido.ped_FECing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO))end ) as ped_turno, tes_abrev, tes_nombre, prc_resfinal, TES_ORDENIMP from pedido, res_procesados, test_equipo, test where test.tim_id = res_procesados.tim_id and res_procesados.tes_abrev = teq_abrv_fija And test.tes_id = test_equipo.tes_id And pedido.ped_id = res_procesados.ped_id And pac_id = " & pac_id & " and res_procesados.TES_PADRE = " & tes_id & " and res_procesados.TIM_ID = " & tim_id & " and prc_resfinal <> '' group by pedido.ped_FECing, PEDIDO.PED_TURNO, tes_abrev, tes_nombre, prc_resfinal, TES_ORDENIMP order by TES_ORDENIMP asc;"
        Dim BDCmd = New SqlCommand(str_sql, cls_operacion.conn_sql)
        dt_operacion.SelectCommand = BDCmd
        LeerHistorico = New DataSet()
        dt_operacion.Fill(LeerHistorico, "Registros")
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer Historico", Err)
        Err.Clear()
    End Function

    Public Sub EliminarArea(ByVal serCod As Integer)
        'Procedimiento para la eliminar un registro en la tabla Servicio
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "delete from Servicio where ser_id = " & serCod & ""
        opr_Conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.sql_desconn()
        MsgBox("Datos eliminados", MsgBoxStyle.Information, "ANALISYS")
        'Se registra la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Eliminar servicio", "SERVICIO=" & serCod, g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Eliminar Servicio", Err)
        Err.Clear()
    End Sub

    Function ConsultarEMO_QUIMICA(ByVal ped_id As Integer) As DataSet
        'Funcion para consultar los resultados de qu�mica de un EMO realizado en 
        'un MIDITRON
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "select TES_ABREV AS PARAMETRO, PRC_RESUL AS RESULTADO from res_procesados where ped_id = " & ped_id & " and (tes_abrev = 'BILO' or tes_abrev = 'ERY' OR tes_abrev = 'GLUO' OR tes_abrev = 'KET' OR tes_abrev = 'LEUO' OR tes_abrev = 'NIT' OR tes_abrev = 'PH' OR tes_abrev = 'PRO' OR tes_abrev = 'SG' OR tes_abrev = 'UBG')"
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        ConsultarEMO_QUIMICA = New DataSet("AREAS")
        oda_operacion.Fill(ConsultarEMO_QUIMICA, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Consultar QUIMICA EMO", Err)
        Err.Clear()
    End Function


    Public Function LlenaListRemitido(ByRef lst_remitidos As ListBox, ByVal ped_id As Integer) As DataSet
        '17/Ago/2010
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String
        Dim dtt_aux As New DataTable()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        str_sql = "SELECT TEST.TES_NOMBRE, PEDIDO.PAC_ID as Folder, LISTA_TRABAJO.lis_mis as pdf FROM LISTA_TRABAJO, TEST,PEDIDO where LISTA_TRABAJO.TES_ID = TEST.TES_ID and LISTA_TRABAJO.PED_ID = " & ped_id & " and LISTA_TRABAJO.lis_mis <> '' and PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID order by TEST.TES_NOMBRE;"
        cls_operacion.sql_conectar()
        lst_remitidos.Items.Clear()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_remitidos.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(60) & "          " & odr_operacion.GetValue(1).ToString() & "\" & odr_operacion.GetValue(2).ToString())
        End While
        odr_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Precio Perfil", Err)
        Err.Clear()
    End Function


    Public Function llenaListaReportes(ByRef lst_reportes As ListBox, ByVal estado As Byte, ByVal rep_tipo As String) As DataSet
        Dim cls_operacion As New Cls_Conexion()
        Dim str_sql As String = Nothing
        Dim dtt_aux As New DataTable()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        Select Case rep_tipo
            Case "LA"
                str_sql = "Select rep_descripcion, rep_id from reportes where rep_estado =1 and rep_tipo = 'LA';"

            Case "HC"
                str_sql = "Select rep_descripcion, rep_id from reportes where rep_estado =1 and rep_tipo = 'HC';"
        End Select

        cls_operacion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        llenaListaReportes = New DataSet()
        oda_operacion.Fill(llenaListaReportes, "Registros")

        lst_reportes.Items.Clear()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_reportes.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & " " & odr_operacion.GetValue(1).ToString().PadRight(2))
        End While

        odr_operacion.Close()
        cls_operacion.sql_desconn()
    End Function




    Sub llenaListaRecomendacion(ByRef chk_recomen As CheckedListBox)
        'funcion que llena en un lista las areas
        On Error Resume Next
        Dim dts_recom As DataSet
        Dim dtr_fila As DataRow
        Dim int_i As Integer
        Dim sng_flag As Single
        dts_recom = LeerRecomen(1)
        chk_recomen.Items.Clear()
        For Each dtr_fila In dts_recom.Tables("Registros").Rows
            chk_recomen.Items.Add(dtr_fila("rec_desc").ToString().PadRight(60) & dtr_fila("rec_id").ToString(), False)
        Next

    End Sub

    Public Function LeerRecomen(ByVal estado As Integer) As DataSet
        'Funcion para la consultar los datos de la tabla AREA
        On Error GoTo MsgError
        LeerRecomen = Nothing
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim selectCommand As SqlCommand = New SqlCommand()

        oda_operacion.SelectCommand = New SqlCommand("Select rec_desc, rec_id from recomendacion where rec_estado =" & estado & " ;", opr_Conexion.conn_sql)
        LeerRecomen = New DataSet("RECOMEN")

        oda_operacion.Fill(LeerRecomen, "Registros")
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Areas", Err)
        Err.Clear()
    End Function

    Public Function LlenaListPedido(ByRef lst_pedidos As ListBox, ByVal fechaini As String, ByVal fechafin As String, ByVal aareas As String, ByVal proforma As Integer, ByVal prioridad As String, ByVal secuencias As String, ByVal estado As String, Optional ByVal ped_id As Integer = 0, Optional ByRef fitroOrdenes As String = "") As DataSet
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim str_sql As String = Nothing
        Dim str_aux As String = Nothing
        Dim str_prio As String = Nothing
        Dim str_order As String = Nothing
        Dim str_sec() As String
        Dim str_secuencias As String = Nothing
        Dim i As Integer
        str_sec = Split(secuencias, ",")



        If str_sec(0).ToString() = "NORMAL" Or str_sec(0).ToString() = "URGENCIA" Or str_sec(0).ToString() = "EMERGENCIA" Then

        Else

            str_secuencias = " and pedido.ped_turno between '" & str_sec(1) & "' and '" & str_sec(2) & "' "
        End If


        If Trim(str_sec(0).ToString()) <> "TODOS" Then
            str_prio = " and pedido.PED_TIPO = '" & Trim(str_sec(0).ToString()) & "'"
        End If


        
        str_order = " order by ped_id, ped_fecing, ped_turno, pac_id, PACIENTE, pac_fecnac, ped_antecedente, ped_medicacion, med_id, med_nombre, ped_nota, pac_usafecnac, CI, LAB, PROF, EMAIL asc "



        Select Case proforma
            Case 0 ' es pedido sin validar
                If aareas <> "00" And aareas <> "0" Then
                    str_sql = "SELECT PEDIDO.PED_FECING as ped_fecing, concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO, if(PEDIDO.PED_PROF=1,'P',if(length(PEDIDO.PED_TIPO)=6,'N','E' )) as PED_PROF, IF(PEDIDO.FAC_ID <> '',PEDIDO.FAC_ID,'ND') as FAC_ID, PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, PEDIDO.PED_OBS, PEDIDO_TIPO " & _
                    "FROM PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID  AND TEST.are_id in (" & aareas & ") "

                    str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') group by PEDIDO.PED_ID order by PEDIDO.ped_id asc, PEDIDO.ped_turno asc  "
                    str_sql = str_sql & " " & str_aux

                Else
                    str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                    "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                    "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                    "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                    "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                    "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                    "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                    "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, pedido.PED_SERVICIO as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.ped_TIPO " & _
                    "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                    "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                    "and servicio.ser_nombre = pedido.ped_servicio " & _
                    "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                    "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                    "and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 3 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5 OR PEDIDO.PED_ESTADO = 6) " & _
                    "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') "
                    '"and test.ARE_ID = '" & areas & "'"


                    If prioridad <> "TODOS" Then
                        str_sql = str_sql & str_prio & str_order
                    Else
                        str_sql = str_sql & str_secuencias & str_order
                    End If

                    ''str_sql = "SELECT PEDIDO.PED_FECING as ped_fecing, concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO, if(PEDIDO.PED_PROF=1,'P',if(length(PEDIDO.PED_TIPO)=6,'N','E' )) as PED_PROF, IF(PEDIDO.FAC_ID <> '',PEDIDO.FAC_ID,'ND') as FAC_ID, PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF  " & _
                    ''"FROM PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') AND (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 3 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) "

                    ''str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') group by PEDIDO.PED_ID order by PEDIDO.ped_id asc, PEDIDO.ped_turno asc  "
                    ''str_sql = str_sql & " " & str_aux

                End If

            Case 1 ' es proforma
                If aareas <> "00" And aareas <> "0" Then
                    If ped_id = 0 Then
                        If fitroOrdenes = "PorValidar" Then
                            str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                            "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                        "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                            "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                            "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                            "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                            "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                            "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                            "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                            "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, pedido.PED_SERVICIO as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.ped_TIPO " & _
                            "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                            "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                            "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                            "and servicio.ser_nombre = pedido.ped_servicio " & _
                            "and PEDIDO.PED_PROF <> 1 " & _
                            "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                            "and PEDIDO.PED_ESTADO in " & estado & _
                            "and lista_trabajo.LIS_RESESTADO <> 2 " & _
                            "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') " & _
                            "and test.ARE_ID in( " & aareas & ")"
                        Else
                            str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                           "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                       "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                       "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                       "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                       "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                           "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                           "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                           "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                           "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                           "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                           "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                           "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, pedido.PED_SERVICIO as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.ped_TIPO " & _
                           "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                           "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                           "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                           "and servicio.ser_nombre = pedido.ped_servicio " & _
                           "and PEDIDO.PED_PROF <> 1 " & _
                           "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                           "and PEDIDO.PED_ESTADO in " & estado & _
                           "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') " & _
                           "and test.ARE_ID in( " & aareas & ")"
                        End If
                        '"and (PEDIDO.PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _

                        If prioridad <> "TODOS" Then
                            str_sql = str_sql & str_prio & str_order
                        Else
                            str_sql = str_sql & str_secuencias & str_order
                        End If
                    Else
                        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                        "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, pedido.PED_SERVICIO as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.ped_TIPO " & _
                        "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                        "and LISTA_TRABAJO.PED_ID = pedido.PED_I and test.TES_ID = lista_trabajo.TES_ID " & _
                        "and servicio.ser_nombre = pedido.ped_servicio " & _
                        "and PEDIDO.PED_PROF <> 1 " & _
                        "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                        "and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _
                        "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') and PEDIDO.PED_id = " & ped_id & _
                        "and test.ARE_ID = '" & aareas & "'"

                        If prioridad <> "TODOS" Then
                            str_sql = str_sql & str_prio & str_order
                        Else
                            str_sql = str_sql & str_secuencias & str_order
                        End If
                    End If
                Else
                    If ped_id = 0 Then
                        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                        "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, pedido.PED_SERVICIO as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.ped_TIPO" & _
                        "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                        "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                        "and servicio.ser_nombre = pedido.ped_servicio " & _
                        "and PEDIDO.PED_PROF <> 1 " & _
                        "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                        "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') " & _
                        "and PEDIDO.PED_ESTADO in " & estado
                        '"and test.ARE_ID = '" & areas & "'"
                        '"and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _

                        If prioridad <> "TODOS" Then
                            str_sql = str_sql & str_prio & str_order
                        Else
                            str_sql = str_sql & str_secuencias & str_order
                        End If
                    Else
                        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                        "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, pedido.PED_SERVICIO as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.ped_TIPO " & _
                        "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                        "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                        "and servicio.ser_nombre = pedido.ped_servicio " & _
                        "and PEDIDO.PED_PROF <> 1 " & _
                        "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                        "and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _
                        "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') and PEDIDO.PED_id = " & ped_id
                        '"and test.ARE_ID = '" & areas & "'"


                        If Trim(str_sec(0).ToString()) <> "TODOS" Then
                            'str_prio = " and pedido.PED_TIPO = '" & Trim(str_sec(0).ToString()) & "'"
                            If prioridad <> "TODOS" Then
                                str_sql = str_sql & str_prio & str_order
                            Else
                                str_sql = str_sql & str_secuencias & str_order
                            End If
                        Else


                            If prioridad <> "TODOS" Then
                                str_sql = str_sql & str_prio & str_order
                            Else
                                str_sql = str_sql & str_secuencias & str_order
                            End If

                        End If
                    End If

                End If

            Case 2 ' es pedido validado
                'If aareas <> "00" And aareas <> "0" Then
                If aareas = "00" And aareas = "0" Then
                    str_sql = "SELECT PEDIDO.PED_FECING as ped_fecing, concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO, if(PEDIDO.PED_PROF=1,'P',if(length(PEDIDO.PED_TIPO)=6,'N','E' )) as PED_PROF, PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, PEDIDO.PED_OBS " & _
                    "FROM PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID and PEDIDO.PED_PROF <> " & proforma & " AND TEST.are_id in( " & aareas & ") "

                    str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') group by PEDIDO.PED_ID order by PEDIDO.ped_id asc, PEDIDO.ped_turno asc  "
                    str_sql = str_sql & " " & str_aux

                Else

                    str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                    "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                    "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                    "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                    "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                    "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' ELSE 'N' end as PED_PROF, " & _
                    "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                    "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, PED_SERVICIO as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.ped_TIPO " & _
                    "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                    "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                    "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                    "and servicio.ser_nombre = pedido.PED_SERVICIO " & _
                    "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                    "and (PEDIDO.PED_ESTADO  <> 2 and PEDIDO.PED_ESTADO <> 1 and PEDIDO.PED_ESTADO <> 0) " & _
                    "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') " & _
                    "and test.ARE_ID in ( " & Mid(aareas, 1, Len(aareas) - 1) & " )"

                    If prioridad <> "TODOS" Then
                        str_sql = str_sql & str_prio & str_order
                    Else
                        str_sql = str_sql & str_secuencias & str_order
                    End If

                End If

        End Select


        Dim dtt_aux As New DataTable()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim tienesaldo As String = ""
        Dim saldo As Double = 0

        cls_operacion.sql_conectar()
        lst_pedidos.Items.Clear()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        LlenaListPedido = New DataSet()
        oda_operacion.Fill(LlenaListPedido, "Registros")


        fitroOrdenes = Nothing
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_pedidos.Items.Add("(" & odr_operacion.GetValue(14).ToString() & ")" & odr_operacion.GetValue(1).ToString() & "     " & odr_operacion.GetValue(3).ToString().PadRight(50) & "     " & odr_operacion.GetValue(10).ToString().PadRight(10) & "     " & odr_operacion.GetValue(18).ToString().PadRight(100) & "     " & odr_operacion.GetValue(4).ToString() & "     " & odr_operacion.GetValue(19).ToString() & "     " & odr_operacion.GetValue(20).ToString() & "     " & odr_operacion.GetValue(21).ToString() & "     " & odr_operacion.GetValue(23).ToString())
            fitroOrdenes = fitroOrdenes & odr_operacion.GetValue(1).ToString() & ","
        End While


        odr_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        'r
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer lista pedidos", Err)
        'Err.Clear()
    End Function


    Public Function LlenaListPedidoPDF(ByRef lst_pedidos As ListBox, ByVal ped_id As Integer) As DataSet
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim str_sql As String = Nothing

        str_sql = ""



        cls_operacion.sql_conectar()
        'lst_pedidos.Items.Clear()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        LlenaListPedidoPDF = New DataSet()
        oda_operacion.Fill(LlenaListPedidoPDF, "Registros")


        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        'r
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer lista pedidos", Err)
        'Err.Clear()
    End Function

    Sub LlenarGridGRUPOMed(ByRef dgv_GRUPOMed As DataGridView, ByRef dtt_GRUPOmedico As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        'str_sql = "select GMED_ID, GMED_NOMBRE, GMED_OBS " & _
        '            "from GrupoMedico " & _
        '            "where GrupoMedico.Gmed_estado = 1"

        str_sql = "select ('GRUPO MEDICO: ' + m.MED_NOMBRE) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('GRUPO')"

        Dim odr_Tmedico As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_Tmedico.Read
            dtr_fila = dtt_GRUPOmedico.NewRow
            dtr_fila(0) = odr_Tmedico.Item(0)
            dtr_fila(1) = odr_Tmedico.Item(1)
            dtr_fila(2) = odr_Tmedico.Item(2)
            dtr_fila(3) = odr_Tmedico.Item(3)
            dtt_GRUPOmedico.Rows.Add(dtr_fila)
        End While
        dgv_GRUPOMed.DataSource = dtt_GRUPOmedico
        odr_Tmedico.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub



    Sub LlenarGridELEMENTOSMed(ByVal MED_ID As Integer, ByRef dgv_ELEMENTOSmed As DataGridView, ByRef dtt_ELEMENTOSmed As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()


        str_sql = "select m.MED_NOMBRE as MED_NOMBRE, m.MED_ID, e.esp_desc , m.MED_MAIL " & _
                    "from medico as m, GrupoMedicoElementos as gm, especialidad as e " & _
                    "where m.MED_OBS in('TRATANTE','CLIENTE') and gm.Gmed_id = " & MED_ID & " AND gm.MED_ID = m.MED_ID and e.esp_id = m.esp_id"

        Dim odr_Gmedico As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_Gmedico.Read
            dtr_fila = dtt_ELEMENTOSmed.NewRow
            dtr_fila(0) = odr_Gmedico.Item(0)
            dtr_fila(1) = odr_Gmedico.Item(1)
            dtr_fila(2) = odr_Gmedico.Item(2)
            dtr_fila(3) = odr_Gmedico.Item(3)
            dtt_ELEMENTOSmed.Rows.Add(dtr_fila)
        End While
        dgv_ELEMENTOSmed.DataSource = dtt_ELEMENTOSmed
        odr_Gmedico.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub

    Public Function LlenarInventario(ByRef dgv_InvDetalle As DataGridView, ByRef dtt_inventario As DataTable, ByVal i_mov_id As Integer) As Integer
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = ""
        Dim odr_inv As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_inv.Read
            dtr_fila = dtt_inventario.NewRow
            dtr_fila(0) = odr_inv.Item(0)
            dtr_fila(1) = odr_inv.Item(1)
            dtr_fila(2) = odr_inv.Item(2)
            dtt_inventario.Rows.Add(dtr_fila)
        End While
        LlenarInventario = 1
        dgv_InvDetalle.DataSource = dtt_inventario
        odr_inv.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        LlenarInventario = 0
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Function


    Sub LlenarGridMedico(ByRef dgv_medico As DataGridView, ByRef dtt_medico As DataTable, ByVal esp_id As Integer, ByVal tipo As Integer, ByVal Var_Vergrupo As Boolean)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        If Var_Vergrupo = True Then
            Select Case tipo
                Case 0
                    If esp_id = 0 Then
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('GRUPO') order by m.med_obs "
                    Else
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('GRUPO') and e.esp_id = " & esp_id & " order by m.med_obs"
                    End If

                Case 1
                    If esp_id = 0 Then
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('TRATANTE','CLIENTE') order by m.med_obs"
                    Else
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('TRATANTE','CLIENTE') and e.esp_id = " & esp_id & " order by m.med_obs"
                    End If

                Case 2
                    If esp_id = 0 Then
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('GRUPO') order by m.med_obs"
                    Else
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('GRUPO') and e.esp_id = " & esp_id & " order by m.med_obs"
                    End If

            End Select
        Else
            Select Case tipo
                Case 0
                    If esp_id = 0 Then
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('TRATANTE','GRUPO') order by m.med_obs "
                    Else
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('TRATANTE','GRUPO') and e.esp_id = " & esp_id & " order by m.med_obs"
                    End If

                Case 1
                    If esp_id = 0 Then
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('TRATANTE','CLIENTE') order by m.med_obs"
                    Else
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('TRATANTE','CLIENTE') and e.esp_id = " & esp_id & " order by m.med_obs"
                    End If

                Case 2
                    If esp_id = 0 Then
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('GRUPO') order by m.med_obs"
                    Else
                        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS in('GRUPO') and e.esp_id = " & esp_id & " order by m.med_obs"
                    End If

            End Select

        End If

        Dim odr_medico As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_medico.Read
            dtr_fila = dtt_medico.NewRow
            dtr_fila(0) = odr_medico.Item(0)
            dtr_fila(1) = odr_medico.Item(1)
            dtr_fila(2) = odr_medico.Item(2)
            dtt_medico.Rows.Add(dtr_fila)
        End While
        dgv_medico.DataSource = dtt_medico
        odr_medico.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub

    Sub LlenarGridInfoPermanente(ByRef dgrd_InfoPermanente As DataGridView, ByRef dtt_InfoPermanent As DataTable, ByVal Pac_doc As String)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "select (m.MED_NOMBRE + ' ' + char(13) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL, e.esp_id from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.med_id > 0 and m.MED_OBS = 'Tratante' and e.esp_id = " & Pac_doc & ""

        Dim odr_medico As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_medico.Read
            dtr_fila = dtt_InfoPermanent.NewRow
            dtr_fila(0) = odr_medico.Item(0)
            dtr_fila(1) = odr_medico.Item(1)
            dtr_fila(2) = odr_medico.Item(2)
            dtt_InfoPermanent.Rows.Add(dtr_fila)
        End While
        dgrd_InfoPermanente.DataSource = dtt_InfoPermanent
        odr_medico.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub

    Sub LlenarGridSignosV(ByRef dgrd_SignosV As DataGridView, ByRef dtt_agenda As DataTable, ByVal pac_id As Integer)

        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "SELECT p.PAC_ID, (p.PAC_APELLIDO + ' ' + p.PAC_NOMBRE) as paciente, sv.sig_fecha, sv.sig_TensArt, sv.sig_FrecCard, sv.sig_FrecResp, sv.sig_Temp, sv.sig_Satur, sv.sig_Peso, sv.sig_Audiometria " & _
                "from SignosVitales as sv, paciente as p " & _
                "where sv.pac_id = " & pac_id & " And sv.pac_id = p.pac_id"

        Dim odr_agenda As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_agenda.Read
            dtr_fila = dtt_agenda.NewRow
            dtr_fila(0) = odr_agenda.Item(0)
            dtr_fila(1) = odr_agenda.Item(1)
            dtr_fila(2) = odr_agenda.Item(2)
            dtr_fila(3) = odr_agenda.Item(3)
            dtr_fila(4) = odr_agenda.Item(4)
            dtr_fila(5) = odr_agenda.Item(5)
            dtr_fila(6) = odr_agenda.Item(6)
            dtr_fila(7) = odr_agenda.Item(7)
            dtr_fila(8) = odr_agenda.Item(8)
            dtr_fila(9) = odr_agenda.Item(9)
            dtt_agenda.Rows.Add(dtr_fila)
        End While
        dgrd_SignosV.DataSource = dtt_agenda
        odr_agenda.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub

    Public Function ConsultaSer_id(ByVal Age_id As Integer, ByVal Pac_id As Integer) As Integer

        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dts_auto As New DataSet()
        Dim str_sql As String = "select VT.SER_ID " & _
                                "from vacuna as v, vacunaTratamiento as vt, vacunaContenido AS vc, vacunaTecnica as vtec, vacunaInventario  as vi, vacunaTipoMovimiento as vtm " & _
                                "where v.vac_id = vi.VAC_ID and v.VAC_ID = vi.VAC_ID and vi.MOV_ID = vtm .MOV_ID and vi.VACT_ID = vtec.VACT_ID and vi.VACC_ID = vc.VACC_ID and vi.VAC_LOTE = vt.vac_lote and vt.pac_id = " & Pac_id & " and vt.AGE_ID = " & Age_id

        cls_operacion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)

        ConsultaSer_id = 0

        oda_operacion.Fill(dts_auto, "Files")

        For Each dtr_fila In dts_auto.Tables(0).Rows
            ConsultaSer_id = dtr_fila(0)
        Next

        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacin solicitada, Consulta existe Reg error correo", Err)
        Err.Clear()

    End Function

    Sub LlenarGridTTO(ByRef dgrd_TTO As DataGridView, ByRef dtt_TTO As DataTable, ByVal pac_id As Integer, ByVal tipo As String)

        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()
        'CONVERT(VARCHAR, vt.TTO_FECHA, 103) AS Fecha_Corta
        Select Case tipo
            Case "CLIENTE"
                str_sql = "SELECT CONVERT(VARCHAR, vt.TTO_FECHA, 103), p.I_PRD_ID, p.I_PRD_DESCRIPCION, case when SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) = 'A' then 'ADULTO' else 'NIÑO' end AS EDAD, vt.TTO_CANTIDAD, u.I_UNI_DESCRIPCION, vt.VAC_LOTE, 'Subcutanea' as VIA, vt.SER_ID as COMP, 'LabAlergia Quito - Ecuador' AS ORIGEN, p.I_PRD_FRASCOS, p.SER_ID, p.I_PRD_ABREV " & _
                                    "FROM TratamientoCliente as vt, i_producto as p, i_unidad as u " & _
                                    "where u.I_UNI_ID = p.I_UNI_ID And vt.MED_ID = " & pac_id & " " & _
                                    "and p.I_PRD_ID = vt.I_PRD_ID and p.I_AID <> 4"

            Case "PACIENTE"
                str_sql = "SELECT CONVERT(VARCHAR, vt.TTO_FECHA, 103), p.I_PRD_ID, p.I_PRD_DESCRIPCION, case when SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) = 'A' then 'ADULTO' else 'NIÑO' end AS EDAD, vt.TTO_CANTIDAD, u.I_UNI_DESCRIPCION, vt.VAC_LOTE, 'Subcutanea' as VIA, vt.SER_ID as COMP, 'LabAlergia Quito - Ecuador' AS ORIGEN, p.I_PRD_FRASCOS, p.SER_ID, p.I_PRD_ABREV, p.I_AID " & _
                    "FROM TratamientoPaciente as vt, i_producto as p,i_unidad as u " & _
                    "where u.I_UNI_ID = p.I_UNI_ID And vt.PAC_ID = " & pac_id & " " & _
                    "and p.I_PRD_ID = vt.I_PRD_ID and p.I_AID <> 4"


            Case "PREPARACION"
                str_sql = "SELECT CONVERT(VARCHAR, vt.TTO_FECHA, 103), p.I_PRD_ABREV, p.I_PRD_DESCRIPCION, case when SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) = 'A' then 'ADULTO' else 'NIÑO' end AS EDAD, vt.TTO_CANTIDAD, u.I_UNI_DESCRIPCION, vt.VAC_LOTE, 'Subcutanea' as VIA, vt.SER_ID as COMP, 'LabAlergia Quito - Ecuador' AS ORIGEN, p.I_PRD_FRASCOS, p.SER_ID, p.I_PRD_ID " & _
                                    "FROM TratamientoPreparacion as vt, i_producto as p, i_unidad as u " & _
                                    "where u.I_UNI_ID = p.I_UNI_ID " & _
                                    "and p.I_PRD_ID = vt.I_PRD_ID "


        End Select
        

        Dim odr_agenda As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_agenda.Read
            dtr_fila = dtt_TTO.NewRow
            dtr_fila(0) = odr_agenda.Item(0)
            dtr_fila(1) = odr_agenda.Item(1)
            dtr_fila(2) = odr_agenda.Item(2)
            dtr_fila(3) = odr_agenda.Item(3)
            dtr_fila(4) = odr_agenda.Item(4)
            dtr_fila(5) = odr_agenda.Item(5)
            dtr_fila(6) = odr_agenda.Item(6)
            dtr_fila(7) = odr_agenda.Item(7)
            dtr_fila(8) = odr_agenda.Item(8)
            dtr_fila(9) = odr_agenda.Item(9)
            dtr_fila(10) = odr_agenda.Item(10)
            dtr_fila(11) = odr_agenda.Item(11)
            dtr_fila(12) = odr_agenda.Item(12)


            dtt_TTO.Rows.Add(dtr_fila)
        End While
        dgrd_TTO.DataSource = dtt_TTO
        odr_agenda.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridTTO2(ByRef dgrd_TTO As DataGridView, ByRef dtt_TTO As DataTable, ByVal pac_id As Integer, ByVal tipo As String)

        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()
        'CONVERT(VARCHAR, vt.TTO_FECHA, 103) AS Fecha_Corta
        Select Case tipo
            Case "CLIENTE"
                str_sql = "SELECT CONVERT(VARCHAR, vt.TTO_FECHA, 103), p.I_PRD_ID, p.I_PRD_DESCRIPCION, case when SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) = 'A' then 'ADULTO' else 'NIÑO' end AS EDAD, vt.TTO_CANTIDAD, u.I_UNI_DESCRIPCION, vt.VAC_LOTE, 'Subcutanea' as VIA, vt.SER_ID as COMP, 'LabAlergia Quito - Ecuador' AS ORIGEN, p.I_PRD_FRASCOS, p.SER_ID, I_PRD_ABREV " & _
                                    "FROM TratamientoCliente as vt, i_producto as p, i_unidad as u " & _
                                    "where u.I_UNI_ID = p.I_UNI_ID And vt.MED_ID = " & pac_id & " " & _
                                    "and p.I_PRD_ID = vt.I_PRD_ID and p.I_AID = 4"

            Case "PACIENTE"
                str_sql = "SELECT CONVERT(VARCHAR, vt.TTO_FECHA, 103), p.I_PRD_ID, p.I_PRD_DESCRIPCION, case when SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) = 'A' then 'ADULTO' else 'NIÑO' end AS EDAD, vt.TTO_CANTIDAD, u.I_UNI_DESCRIPCION, vt.VAC_LOTE, 'Subcutanea' as VIA, vt.SER_ID as COMP, 'LabAlergia Quito - Ecuador' AS ORIGEN, p.I_PRD_FRASCOS, p.SER_ID, I_PRD_ABREV " & _
                    "FROM TratamientoPaciente as vt, i_producto as p,i_unidad as u " & _
                    "where u.I_UNI_ID = p.I_UNI_ID And vt.PAC_ID = " & pac_id & " " & _
                    "and p.I_PRD_ID = vt.I_PRD_ID and p.I_AID = 4"

            Case "PREPARACION"
                str_sql = "SELECT CONVERT(VARCHAR, vt.TTO_FECHA, 103), p.I_PRD_ID, p.I_PRD_DESCRIPCION, case when SUBSTRING(p.I_PRD_DESCRIPCION, LEN(p.I_PRD_DESCRIPCION), 1) = 'A' then 'ADULTO' else 'NIÑO' end AS EDAD, vt.TTO_CANTIDAD, u.I_UNI_DESCRIPCION, vt.VAC_LOTE, 'Subcutanea' as VIA, vt.SER_ID as COMP, 'LabAlergia Quito - Ecuador' AS ORIGEN, p.I_PRD_FRASCOS, p.SER_ID, I_PRD_ABREV " & _
                    "FROM TratamientoPaciente as vt, i_producto as p,i_unidad as u " & _
                    "where u.I_UNI_ID = p.I_UNI_ID " & _
                    "and p.I_PRD_ID = vt.I_PRD_ID and p.I_AID in(4)"

        End Select


        Dim odr_agenda As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_agenda.Read
            dtr_fila = dtt_TTO.NewRow
            dtr_fila(0) = odr_agenda.Item(0)
            dtr_fila(1) = odr_agenda.Item(1)
            dtr_fila(2) = odr_agenda.Item(2)
            dtr_fila(3) = odr_agenda.Item(3)
            dtr_fila(4) = odr_agenda.Item(4)
            dtr_fila(5) = odr_agenda.Item(5)
            dtr_fila(6) = odr_agenda.Item(6)
            dtr_fila(7) = odr_agenda.Item(7)
            dtr_fila(8) = odr_agenda.Item(8)
            dtr_fila(9) = odr_agenda.Item(9)
            dtr_fila(10) = odr_agenda.Item(10)
            dtr_fila(11) = odr_agenda.Item(11)
            dtr_fila(12) = odr_agenda.Item(12)


            dtt_TTO.Rows.Add(dtr_fila)
        End While
        dgrd_TTO.DataSource = dtt_TTO
        odr_agenda.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridSER(ByRef dgrd_SER As DataGridView, ByRef dtt_SER As DataTable, ByVal VAC_CAT As String)

        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "select * from vacunaSerie where vac_cat = '" & VAC_CAT & "'"

        Dim odr_agenda As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_agenda.Read
            dtr_fila = dtt_SER.NewRow
            dtr_fila(0) = odr_agenda.Item(0)
            dtr_fila(1) = odr_agenda.Item(1)
            dtr_fila(2) = odr_agenda.Item(2)
            dtr_fila(3) = odr_agenda.Item(3)

            dtt_SER.Rows.Add(dtr_fila)
        End While

        dgrd_SER.DataSource = dtt_SER
        odr_agenda.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub



    Sub LlenarGridCie10(ByRef dgvCie As DataGridView, ByRef dtt_cie As DataTable, ByVal parametro As String)

        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        Dim str_where As String
        opr_conexion.sql_conectar()

        str_sql = "select cie_cod3, cie_desc3, cie_cod4, cie_desc4 from cie10 "
        Select Case Len(parametro)
            Case 0

            Case 3
                str_where = " where cie_cod3 = '" & parametro & "'"
            Case 4
                str_where = " where cie_cod4 = '" & parametro & "'"
            Case Else
                str_where = " where cie_des3 = '" & parametro & "'"
        End Select

        str_sql = str_sql & str_where
        Dim odr_agenda As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_agenda.Read
            dtr_fila = dtt_cie.NewRow
            dtr_fila(0) = odr_agenda.Item(0)
            dtr_fila(1) = odr_agenda.Item(1)
            dtr_fila(2) = odr_agenda.Item(2)
            dtr_fila(3) = odr_agenda.Item(3)

            dtt_cie.Rows.Add(dtr_fila)
        End While
        dgvCie.DataSource = dtt_cie
        odr_agenda.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridAgenda(ByRef dgrd_agenda As DataGridView, ByRef dtt_agenda As DataTable, ByVal fecha_ini As String, ByVal fecha_fin As String, ByVal tipo As String, ByVal med_id As Integer)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        dtt_agenda.Clear()

        Select Case dgrd_agenda.Name
            Case "dgv_Agenda"
                str_sql = "select agenda.age_id, agenda.age_hora, agenda.age_fecha, agenda.pac_id, (paciente.PAC_APELLIDO  + ' ' + paciente.PAC_NOMBRE) as PAC_NOMBRE, PAC_EDAD, agenda.med_id, agenda.ped_id, agenda.age_resumen, '' as age_cutaneas, '' as age_dermografismo, '' as age_receta, '' as age_tratamiento, '' as age_finalizado, cer_str, age_tutor, age_ci, paciente.pac_doc, age_estado, ped_turno " & _
                          "from agenda, paciente, medico, especialidad " & _
                          "where medico.ESP_ID = especialidad.esp_id and paciente.PAC_ID = agenda.pac_id and medico.med_id = agenda.med_id and agenda.age_fecha between '" & fecha_ini & " 00:00:00' and '" & fecha_fin & " 23:59:59' and age_tipo = '" & tipo & "' and medico.med_id = " & med_id & "" & _
                          "order by agenda.age_id asc"

                Dim odr_agenda As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
                While odr_agenda.Read
                    dtr_fila = dtt_agenda.NewRow
                    dtr_fila(0) = odr_agenda.Item(0)
                    dtr_fila(1) = odr_agenda.Item(1)
                    dtr_fila(2) = odr_agenda.Item(2)
                    dtr_fila(3) = odr_agenda.Item(3)
                    dtr_fila(4) = odr_agenda.Item(4)
                    dtr_fila(5) = odr_agenda.Item(5)
                    dtr_fila(6) = odr_agenda.Item(6)
                    dtr_fila(7) = odr_agenda.Item(7)
                    dtr_fila(8) = odr_agenda.Item(8)
                    dtr_fila(9) = odr_agenda.Item(9)
                    dtr_fila(10) = odr_agenda.Item(10)
                    dtr_fila(11) = odr_agenda.Item(11)
                    dtr_fila(12) = odr_agenda.Item(12)
                    dtr_fila(13) = odr_agenda.Item(13)
                    dtr_fila(14) = odr_agenda.Item(14)
                    dtr_fila(15) = odr_agenda.Item(15)
                    dtr_fila(16) = odr_agenda.Item(16)
                    dtr_fila(17) = odr_agenda.Item(17)
                    dtr_fila(18) = odr_agenda.Item(18)
                    dtr_fila(19) = odr_agenda.Item(19)

                    dtt_agenda.Rows.Add(dtr_fila)
                End While
                dgrd_agenda.DataSource = dtt_agenda
                odr_agenda.Close()
                opr_conexion.sql_desconn()

            Case "dgv_AgendaDespacho"
                str_sql = "select agenda.age_id, agenda.age_hora, agenda.age_fecha, agenda.pac_id, agenda.med_id, medico.MED_NOMBRE, agenda.ped_id, agenda.age_resumen, agenda.age_ci, agenda.ped_turno as MED_DOC, age_estado " & _
                          "from agenda, medico, especialidad " & _
                          "where medico.ESP_ID = especialidad.esp_id and medico.med_id = agenda.pac_id and agenda.age_fecha between '" & fecha_ini & " 00:00:00' and '" & fecha_fin & " 23:59:59' and age_tipo = '" & tipo & "' and agenda.med_id = " & med_id & " " & _
                          "order by agenda.age_id asc"
                Dim odr_agenda As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
                While odr_agenda.Read
                    dtr_fila = dtt_agenda.NewRow
                    dtr_fila(0) = odr_agenda.Item(0)
                    dtr_fila(1) = odr_agenda.Item(1)
                    dtr_fila(2) = odr_agenda.Item(2)
                    dtr_fila(3) = odr_agenda.Item(3)
                    dtr_fila(4) = odr_agenda.Item(4)
                    dtr_fila(5) = odr_agenda.Item(5)
                    dtr_fila(6) = odr_agenda.Item(6)
                    dtr_fila(7) = odr_agenda.Item(7)
                    dtr_fila(8) = odr_agenda.Item(8)
                    dtr_fila(9) = odr_agenda.Item(9)
                    dtr_fila(10) = odr_agenda.Item(10)


                    dtt_agenda.Rows.Add(dtr_fila)
                End While
                dgrd_agenda.DataSource = dtt_agenda
                odr_agenda.Close()
                opr_conexion.sql_desconn()


        End Select

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub



    Sub LlenarGridHC_Historico(ByRef dgrd_Historico As DataGridView, ByRef dtt_Historico As DataTable, ByVal hic_id As Integer, ByVal campo As String)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        Select Case campo
            Case "<TODOS>"
                str_sql = "select hic_id, hic_fecha, campo, valor_anterior, valor_nuevo, (invitado.invitado_apellido + ' ' + invitado .invitado_nombre) as usuario " & _
                    "from historiaClinicaCambios, invitado " & _
                    "where hic_id = " & hic_id & " and historiaClinicaCambios.usr_id = invitado.invitado_id " & _
                    "order by hic_fecha desc; "

            Case Else
                str_sql = "select hic_id, hic_fecha, campo, valor_anterior, valor_nuevo, (invitado.invitado_apellido + ' ' + invitado .invitado_nombre) as usuario " & _
                  "from historiaClinicaCambios, invitado " & _
                  "where hic_id = " & hic_id & " and historiaClinicaCambios.usr_id = invitado.invitado_id and historiaClinicaCambios.CAMPO = '" & campo & "' " & _
                  "order by hic_fecha desc; "

        End Select
        

        Dim odr_historico As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_historico.Read
            dtr_fila = dtt_Historico.NewRow
            dtr_fila(0) = odr_historico.Item(0)
            dtr_fila(1) = odr_historico.Item(1)
            dtr_fila(2) = odr_historico.Item(2)
            dtr_fila(3) = odr_historico.Item(3)
            dtr_fila(4) = odr_historico.Item(4)
            dtr_fila(5) = odr_historico.Item(5)

            dtt_Historico.Rows.Add(dtr_fila)
        End While
        dgrd_Historico.DataSource = dtt_Historico
        odr_historico.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridCutaneas(ByRef dgv As DataGridView, ByRef dtt_Cut As DataTable, ByVal ped_id As Integer, ByVal tes_id As Integer, ByRef fechaCutanea As String)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        Dim visto As Char = ChrW(10003)

        opr_conexion.sql_conectar()

        str_sql = "SELECT rc.ped_id, rc.PRCC_FECHA, rc.PRCC_HORA, rc.TES_ABREV, test.TES_NOMBRE, rc.PRCC_RESUL_ANIO, rc.PRCC_RESUL_INT, '' as PRCC_RESUL_ANIO2, '' as PRCC_RESUL_INT2, '' as PRCC_RESUL_ANIO3, '' as PRCC_RESUL_INT3, rc.TIM_ID , area.ARE_NOMBRE as SECC, rc.TES_PADRE, rc.ARE_ID, test.TES_ORDENIMP AS ORDEN " & _
                "FROM res_cutaneas as rc, area, test, test_equipo as teq " & _
                "where test.TES_TIPO = 'Parametro' and rc.ARE_ID = area.ARE_ID And teq.TEQ_ABRV_FIJA = rc.TES_ABREV and test.tes_id = teq.TES_ID And rc.PED_ID = " & ped_id & " and rc.TES_PADRE = " & tes_id & " order by test.TES_ORDENIMP"


        Dim odr_cutaneas As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_cutaneas.Read
            dtr_fila = dtt_Cut.NewRow
            dtr_fila(0) = odr_cutaneas.Item(0) ' PED_iD
            dtr_fila(1) = odr_cutaneas.Item(1) ' PRCC_FECHA
            fechaCutanea = Format(CDate(odr_cutaneas.Item(1)), "MMM yyyy") ' PRCC_FECHA

            dtr_fila(2) = odr_cutaneas.Item(2) ' PRCC_HORA
            dtr_fila(3) = odr_cutaneas.Item(3) ' TES_ABREV
            dtr_fila(4) = odr_cutaneas.Item(4) ' TES_NOMBRE

            dtr_fila(5) = Trim(odr_cutaneas.Item(5)) ' PRCC_RESUL_ANIO
            dtr_fila(6) = Replace(odr_cutaneas.Item(6), "I", visto) ' PRCC_RESUL_INT

            dtr_fila(7) = Trim(odr_cutaneas.Item(7))
            dtr_fila(8) = Replace(odr_cutaneas.Item(8), "I", visto)

            dtr_fila(9) = Trim(odr_cutaneas.Item(9))
            dtr_fila(10) = Replace(odr_cutaneas.Item(10), "I", visto)

            dtr_fila(11) = odr_cutaneas.Item(11)
            dtr_fila(12) = odr_cutaneas.Item(12)
            dtr_fila(13) = odr_cutaneas.Item(13)
            dtr_fila(14) = odr_cutaneas.Item(14)
            dtr_fila(15) = odr_cutaneas.Item(15)
            dtt_Cut.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt_Cut
        odr_cutaneas.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub



    Sub LlenarGridTendencia(ByRef dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByRef dtt_Tdcia As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""

        opr_conexion.sql_conectar()

        str_sql = "select * from ( " & _
                "select p.I_PRD_ID, p.I_PRD_DESCRIPCION,  sum(md.I_MOD_CANTIDAD) as INV_CANTIDAD, bod.I_BOD_DESCRIPCION " & _
                "from i_movimiento as m, i_movimiento_detalle as md,i_producto as p, i_bodega as bod " & _
                "where(m.I_MOV_ID = md.I_MOV_ID And p.I_PRD_ID = md.I_PRD_ID And bod.I_BOD_ID = md.I_BOD_ID) " & _
                "and bod.I_BOD_ID IN ('B01','B02','B04') and SUBSTRING(p.I_PRD_ABREV, LEN(p.I_PRD_ABREV), 1) = '" & I_EDAD & "' and Year(m.i_mov_fecing) = " & anio & " " & _
                "group by p.I_PRD_ID, p.I_PRD_DESCRIPCION, bod.I_BOD_DESCRIPCION " & _
                ") as tandencia " & _
                "PIVOT ( " & _
                "SUM(INV_CANTIDAD) " & _
                "FOR I_BOD_DESCRIPCION IN ([CIRCULACION], [EMPAQUE], [CUARENTENA], [EXISTENCIA], [GASTO MENSUAL], [PORCENTAJE REAL], [FRECUENCIA], [PRODUCCION]) " & _
                ") AS PivotTable;"

        Dim odr_tendencia As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_tendencia.Read
            dtr_fila = dtt_Tdcia.NewRow
            dtr_fila(0) = odr_tendencia.Item(0) ' I_PRD_ID
            dtr_fila(1) = odr_tendencia.Item(1) ' I_PRD_DESCRIPCION

            If IsDBNull(odr_tendencia.Item(2)) Then ' CIRCULACION
                dtr_fila(2) = 0
            Else
                dtr_fila(2) = odr_tendencia.Item(2)
            End If

            If IsDBNull(odr_tendencia.Item(3)) Then ' EMPAQUE
                dtr_fila(3) = 0
            Else
                dtr_fila(3) = odr_tendencia.Item(3)
            End If

            If IsDBNull(odr_tendencia.Item(4)) Then ' CUARENTENA
                dtr_fila(4) = 0
            Else
                dtr_fila(4) = odr_tendencia.Item(4)
            End If

            If IsDBNull(odr_tendencia.Item(5)) Then ' EXISTENCIA
                dtr_fila(5) = 0
            Else
                dtr_fila(5) = odr_tendencia.Item(5)
            End If

            If IsDBNull(odr_tendencia.Item(6)) Then ' GASTO MENSUAL
                dtr_fila(6) = 0
            Else
                dtr_fila(6) = odr_tendencia.Item(6)
            End If

            If IsDBNull(odr_tendencia.Item(7)) Then ' % REAL
                dtr_fila(7) = 0
            Else
                dtr_fila(7) = odr_tendencia.Item(7)
            End If

            If IsDBNull(odr_tendencia.Item(8)) Then ' FRECUENCIA
                dtr_fila(8) = 0
            Else
                dtr_fila(8) = odr_tendencia.Item(8)
            End If

            If IsDBNull(odr_tendencia.Item(9)) Then ' PRODUCCION
                dtr_fila(9) = 0
            Else
                dtr_fila(9) = odr_tendencia.Item(9)
            End If


            dtt_Tdcia.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt_Tdcia
        odr_tendencia.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridConsumo(ByRef dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal CliPac As String, ByRef dtt_Consu As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""

        opr_conexion.sql_conectar()
        If CliPac = "CLIENTE" Then
            str_sql = "select * from ( SELECT p.i_prd_descripcion, MONTH(tp.TTO_FECHA) as MES, sum(tp.TTO_CANTIDAD) as TotalVendido FROM TratamientoCliente AS tp, i_producto as p WHERE YEAR(TTO_FECHA) = " & anio & " AND SUBSTRING(p.I_PRD_ABREV, LEN(p.I_PRD_ABREV), 1) = '" & I_EDAD & "' AND p.I_PRD_ID = tp.I_PRD_ID GROUP BY p.I_PRD_DESCRIPCION, Month(tp.TTO_FECHA)) as CONSUMO PIVOT(SUM(TotalVendido) FOR Mes IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12])) AS PivotTable;"
        Else
            str_sql = "select * from ( SELECT p.i_prd_descripcion, MONTH(tp.TTO_FECHA) as MES, sum(tp.TTO_CANTIDAD) as TotalVendido FROM TratamientoPaciente AS tp, i_producto as p WHERE YEAR(TTO_FECHA) = " & anio & " AND SUBSTRING(p.I_PRD_ABREV, LEN(p.I_PRD_ABREV), 1) = '" & I_EDAD & "' AND p.I_PRD_ID = tp.I_PRD_ID GROUP BY p.I_PRD_DESCRIPCION, Month(tp.TTO_FECHA)) as CONSUMO PIVOT(SUM(TotalVendido) FOR Mes IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12])) AS PivotTable;"
        End If

        Dim odr_tendencia As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_tendencia.Read
            dtr_fila = dtt_Consu.NewRow
            dtr_fila(0) = odr_tendencia.Item(0) ' I_PRD_ID

            If IsDBNull(odr_tendencia.Item(1)) Then ' ENERO
                dtr_fila(1) = 0
            Else
                dtr_fila(1) = odr_tendencia.Item(1)
            End If

            If IsDBNull(odr_tendencia.Item(2)) Then ' FEBRERO
                dtr_fila(2) = 0
            Else
                dtr_fila(2) = odr_tendencia.Item(2)
            End If

            If IsDBNull(odr_tendencia.Item(3)) Then ' MARZO
                dtr_fila(3) = 0
            Else
                dtr_fila(3) = odr_tendencia.Item(3)
            End If

            If IsDBNull(odr_tendencia.Item(4)) Then ' ABRIL
                dtr_fila(4) = 0
            Else
                dtr_fila(4) = odr_tendencia.Item(4)
            End If

            If IsDBNull(odr_tendencia.Item(5)) Then ' MAYO
                dtr_fila(5) = 0
            Else
                dtr_fila(5) = odr_tendencia.Item(5)
            End If

            If IsDBNull(odr_tendencia.Item(6)) Then ' JUNIO
                dtr_fila(6) = 0
            Else
                dtr_fila(6) = odr_tendencia.Item(6)
            End If

            If IsDBNull(odr_tendencia.Item(7)) Then ' JULIO
                dtr_fila(7) = 0
            Else
                dtr_fila(7) = odr_tendencia.Item(7)
            End If

            If IsDBNull(odr_tendencia.Item(8)) Then ' AGO
                dtr_fila(8) = 0
            Else
                dtr_fila(8) = odr_tendencia.Item(8)
            End If

            If IsDBNull(odr_tendencia.Item(9)) Then ' SEP
                dtr_fila(9) = 0
            Else
                dtr_fila(9) = odr_tendencia.Item(9)
            End If

            If IsDBNull(odr_tendencia.Item(10)) Then ' OCT
                dtr_fila(10) = 0
            Else
                dtr_fila(10) = odr_tendencia.Item(10)
            End If

            If IsDBNull(odr_tendencia.Item(11)) Then ' NOVIEMBRE
                dtr_fila(11) = 0
            Else
                dtr_fila(11) = odr_tendencia.Item(11)
            End If

            If IsDBNull(odr_tendencia.Item(12)) Then ' DICIEMBRE
                dtr_fila(12) = 0
            Else
                dtr_fila(12) = odr_tendencia.Item(12)
            End If


            dtt_Consu.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt_Consu
        odr_tendencia.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridConsumo_cli(ByRef dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal CliPac As String, ByRef dtt_Consu As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""

        opr_conexion.sql_conectar()

        If CliPac = "CLIENTE" Then
            str_sql = "select * from ( " & _
                "SELECT m.MED_NOMBRE, p.i_prd_descripcion, MONTH(tp.TTO_FECHA) as MES, sum(tp.TTO_CANTIDAD) as TotalVendido " & _
                "FROM TratamientoCliente AS tp, i_producto as p, medico as m " & _
                "WHERE YEAR(TTO_FECHA) = " & anio & " AND SUBSTRING(p.I_PRD_ABREV, LEN(p.I_PRD_ABREV), 1) = '" & I_EDAD & "' AND p.I_PRD_ID = tp.I_PRD_ID AND tp.MED_ID = m.MED_ID GROUP BY m.MED_NOMBRE, p.I_PRD_DESCRIPCION, Month(tp.TTO_FECHA)) as CONSUMO PIVOT(SUM(TotalVendido) FOR Mes IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12])) AS PivotTable;"
        Else
            str_sql = "select * from ( " & _
                    "SELECT " & _
                    "MONTH(TTO_FECHA) AS Mes, (paciente.PAC_NOMBRE + ' '+ PACIENTE.PAC_APELLIDO) as PAC_APELLIDO, I_PRD_ID, SUM(TTO_CANTIDAD) AS TotalVendido " & _
                    "FROM vacunaTratamiento, paciente " & _
                    "WHERE vacunaTratamiento.PAC_ID = paciente.PAC_ID and Year(TTO_FECHA) = " & anio & " and SUBSTRING(I_PRD_ABREV, LEN(I_PRD_ABREV), 1) = '" & I_EDAD & "' and paciente.PAC_GRADO <> 'CLIENTE'" & _
                    "GROUP BY " & _
                    "MONTH(TTO_FECHA), PAC_NOMBRE, PAC_APELLIDO, I_PRD_ID  " & _
                    ") as consumo " & _
                    "PIVOT ( " & _
                    "SUM(TotalVendido) " & _
                    "FOR Mes IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12]) " & _
                    ") AS PivotTable;"
        End If

        Dim odr_tendencia As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_tendencia.Read
            dtr_fila = dtt_Consu.NewRow

            dtr_fila(0) = odr_tendencia.Item(0) ' PAC_APELLIDO

            dtr_fila(1) = odr_tendencia.Item(1) ' I_PRD_ID


            If IsDBNull(odr_tendencia.Item(2)) Then ' ENE
                dtr_fila(2) = 0
            Else
                dtr_fila(2) = odr_tendencia.Item(2)
            End If

            If IsDBNull(odr_tendencia.Item(3)) Then ' FEB
                dtr_fila(3) = 0
            Else
                dtr_fila(3) = odr_tendencia.Item(3)
            End If

            If IsDBNull(odr_tendencia.Item(4)) Then ' MAR
                dtr_fila(4) = 0
            Else
                dtr_fila(4) = odr_tendencia.Item(4)
            End If

            If IsDBNull(odr_tendencia.Item(5)) Then ' ABR
                dtr_fila(5) = 0
            Else
                dtr_fila(5) = odr_tendencia.Item(5)
            End If

            If IsDBNull(odr_tendencia.Item(6)) Then ' MAY
                dtr_fila(6) = 0
            Else
                dtr_fila(6) = odr_tendencia.Item(6)
            End If

            If IsDBNull(odr_tendencia.Item(7)) Then ' JUN
                dtr_fila(7) = 0
            Else
                dtr_fila(7) = odr_tendencia.Item(7)
            End If

            If IsDBNull(odr_tendencia.Item(8)) Then ' JUL
                dtr_fila(8) = 0
            Else
                dtr_fila(8) = odr_tendencia.Item(8)
            End If

            If IsDBNull(odr_tendencia.Item(9)) Then ' AGO
                dtr_fila(9) = 0
            Else
                dtr_fila(9) = odr_tendencia.Item(9)
            End If

            If IsDBNull(odr_tendencia.Item(10)) Then ' SEP
                dtr_fila(10) = 0
            Else
                dtr_fila(10) = odr_tendencia.Item(10)
            End If

            If IsDBNull(odr_tendencia.Item(11)) Then ' OCT
                dtr_fila(11) = 0
            Else
                dtr_fila(11) = odr_tendencia.Item(11)
            End If

            If IsDBNull(odr_tendencia.Item(12)) Then ' NOV
                dtr_fila(12) = 0
            Else
                dtr_fila(12) = odr_tendencia.Item(12)
            End If

            If IsDBNull(odr_tendencia.Item(13)) Then ' DIC
                dtr_fila(13) = 0
            Else
                dtr_fila(13) = odr_tendencia.Item(13)
            End If


            dtt_Consu.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt_Consu
        odr_tendencia.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridConDiario(ByRef dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal mes As Integer, ByRef dtt_CDiario As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""

        opr_conexion.sql_conectar()
        str_sql = "select * from ( " & _
            "SELECT p.I_PRD_DESCRIPCION, DAY(tp.TTO_FECHA) AS Dia,  ISNULL(SUM(tp.TTO_CANTIDAD), 0) AS TotalVendido " & _
        "FROM TratamientoPaciente as tp, i_producto as p " & _
        "WHERE p.I_PRD_ID = tp.I_PRD_ID and Year(tp.TTO_FECHA) = " & anio & " and month(tp.TTO_FECHA) IN(" & mes & ") " & _
        "and SUBSTRING(I_PRD_ABREV, LEN(I_PRD_ABREV), 1) = '" & I_EDAD & "'" & _
          "GROUP BY DAY(tp.TTO_FECHA), p.I_PRD_DESCRIPCION ) as consumo " & _
        "PIVOT (SUM(TotalVendido) FOR Dia IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], " & _
        "[11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], " & _
        "[25], [26], [27], [28], [29], [30], [31])) AS PivotTable;"

        'str_sql = "select * from (SELECT p.I_PRD_DESCRIPCION, DAY(tp.TTO_FECHA) AS Dia,  SUM(tp.TTO_CANTIDAD) AS TotalVendido`FROM TratamientoPaciente as tp, i_producto as p WHERE Year(tp.TTO_FECHA) = " & anio & " and month(tp.TTO_FECHA) IN(" & mes & ") and SUBSTRING(I_PRD_ABREV, LEN(I_PRD_ABREV), 1) = '" & I_EDAD & "' p.I_PRD_ID = tp.I_PRD_ID GROUP BY DAY(tp.TTO_FECHA), p.I_PRD_DESCRIPCION ) as consumo PIVOT (SUM(TotalVendido) FOR Dia IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31])) AS PivotTable;"

        Dim odr_tendencia As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_tendencia.Read
            dtr_fila = dtt_CDiario.NewRow
            dtr_fila(0) = odr_tendencia.Item(0) ' I_PRD_ID

            If IsDBNull(odr_tendencia.Item(1)) Then ' 
                dtr_fila(1) = 0
            Else
                dtr_fila(1) = odr_tendencia.Item(1)
            End If

            If IsDBNull(odr_tendencia.Item(2)) Then ' 
                dtr_fila(2) = 0
            Else
                dtr_fila(2) = odr_tendencia.Item(2)
            End If

            If IsDBNull(odr_tendencia.Item(3)) Then ' 
                dtr_fila(3) = 0
            Else
                dtr_fila(3) = odr_tendencia.Item(3)
            End If

            If IsDBNull(odr_tendencia.Item(4)) Then ' 
                dtr_fila(4) = 0
            Else
                dtr_fila(4) = odr_tendencia.Item(4)
            End If

            If IsDBNull(odr_tendencia.Item(5)) Then ' 
                dtr_fila(5) = 0
            Else
                dtr_fila(5) = odr_tendencia.Item(5)
            End If

            If IsDBNull(odr_tendencia.Item(6)) Then ' 
                dtr_fila(6) = 0
            Else
                dtr_fila(6) = odr_tendencia.Item(6)
            End If

            If IsDBNull(odr_tendencia.Item(7)) Then ' 
                dtr_fila(7) = 0
            Else
                dtr_fila(7) = odr_tendencia.Item(7)
            End If

            If IsDBNull(odr_tendencia.Item(8)) Then ' 
                dtr_fila(8) = 0
            Else
                dtr_fila(8) = odr_tendencia.Item(8)
            End If

            If IsDBNull(odr_tendencia.Item(9)) Then ' 
                dtr_fila(9) = 0
            Else
                dtr_fila(9) = odr_tendencia.Item(9)
            End If

            If IsDBNull(odr_tendencia.Item(10)) Then ' 
                dtr_fila(10) = 0
            Else
                dtr_fila(10) = odr_tendencia.Item(10)
            End If

            If IsDBNull(odr_tendencia.Item(11)) Then ' 
                dtr_fila(11) = 0
            Else
                dtr_fila(11) = odr_tendencia.Item(11)
            End If

            If IsDBNull(odr_tendencia.Item(12)) Then ' 
                dtr_fila(12) = 0
            Else
                dtr_fila(12) = odr_tendencia.Item(12)
            End If

            If IsDBNull(odr_tendencia.Item(13)) Then ' 
                dtr_fila(13) = 0
            Else
                dtr_fila(13) = odr_tendencia.Item(13)
            End If

            If IsDBNull(odr_tendencia.Item(14)) Then ' 
                dtr_fila(14) = 0
            Else
                dtr_fila(14) = odr_tendencia.Item(14)
            End If

            If IsDBNull(odr_tendencia.Item(15)) Then ' 
                dtr_fila(15) = 0
            Else
                dtr_fila(15) = odr_tendencia.Item(15)
            End If

            If IsDBNull(odr_tendencia.Item(15)) Then ' 
                dtr_fila(15) = 0
            Else
                dtr_fila(15) = odr_tendencia.Item(15)
            End If

            If IsDBNull(odr_tendencia.Item(16)) Then ' 
                dtr_fila(16) = 0
            Else
                dtr_fila(16) = odr_tendencia.Item(16)
            End If

            If IsDBNull(odr_tendencia.Item(17)) Then ' 
                dtr_fila(17) = 0
            Else
                dtr_fila(17) = odr_tendencia.Item(17)
            End If

            If IsDBNull(odr_tendencia.Item(18)) Then ' 
                dtr_fila(18) = 0
            Else
                dtr_fila(18) = odr_tendencia.Item(18)
            End If

            If IsDBNull(odr_tendencia.Item(19)) Then ' 
                dtr_fila(19) = 0
            Else
                dtr_fila(19) = odr_tendencia.Item(19)
            End If

            If IsDBNull(odr_tendencia.Item(20)) Then ' 
                dtr_fila(20) = 0
            Else
                dtr_fila(20) = odr_tendencia.Item(20)
            End If

            If IsDBNull(odr_tendencia.Item(21)) Then ' 
                dtr_fila(21) = 0
            Else
                dtr_fila(21) = odr_tendencia.Item(21)
            End If

            If IsDBNull(odr_tendencia.Item(22)) Then ' 
                dtr_fila(22) = 0
            Else
                dtr_fila(22) = odr_tendencia.Item(22)
            End If

            If IsDBNull(odr_tendencia.Item(23)) Then ' 
                dtr_fila(23) = 0
            Else
                dtr_fila(23) = odr_tendencia.Item(23)
            End If

            If IsDBNull(odr_tendencia.Item(24)) Then ' 
                dtr_fila(24) = 0
            Else
                dtr_fila(24) = odr_tendencia.Item(24)
            End If

            If IsDBNull(odr_tendencia.Item(25)) Then ' 
                dtr_fila(25) = 0
            Else
                dtr_fila(25) = odr_tendencia.Item(25)
            End If

            If IsDBNull(odr_tendencia.Item(26)) Then ' 
                dtr_fila(26) = 0
            Else
                dtr_fila(26) = odr_tendencia.Item(26)
            End If

            If IsDBNull(odr_tendencia.Item(27)) Then ' 
                dtr_fila(27) = 0
            Else
                dtr_fila(27) = odr_tendencia.Item(27)
            End If

            If IsDBNull(odr_tendencia.Item(28)) Then ' 
                dtr_fila(28) = 0
            Else
                dtr_fila(28) = odr_tendencia.Item(28)
            End If

            If IsDBNull(odr_tendencia.Item(29)) Then ' 
                dtr_fila(29) = 0
            Else
                dtr_fila(29) = odr_tendencia.Item(29)
            End If

            If IsDBNull(odr_tendencia.Item(30)) Then ' 
                dtr_fila(30) = 0
            Else
                dtr_fila(30) = odr_tendencia.Item(30)
            End If

            If IsDBNull(odr_tendencia.Item(31)) Then ' 
                dtr_fila(31) = 0
            Else
                dtr_fila(31) = odr_tendencia.Item(31)
            End If

            dtt_CDiario.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt_CDiario
        odr_tendencia.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridConDiario_cli(ByRef dgv As DataGridView, ByVal I_EDAD As Char, ByVal anio As Integer, ByVal mes As Integer, ByVal CliPac As String, ByRef dtt_CDiario As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""

        opr_conexion.sql_conectar()

        If CliPac = "CLIENTE" Then
            str_sql = "select * from (SELECT m.MED_NOMBRE, p.I_PRD_DESCRIPCION, DAY(tp.TTO_FECHA) AS Dia,  SUM(tp.TTO_CANTIDAD) AS TotalVendido FROM TratamientoCliente as tp, i_producto as p, medico as m WHERE m.MED_ID = tp.med_id AND Year(tp.TTO_FECHA) = " & anio & " and month(tp.TTO_FECHA) IN(" & mes & ") and SUBSTRING(I_PRD_ABREV, LEN(I_PRD_ABREV), 1) = '" & I_EDAD & "' and p.I_PRD_ID = tp.I_PRD_ID GROUP BY m.MED_NOMBRE, DAY(tp.TTO_FECHA), p.I_PRD_DESCRIPCION ) as consumo PIVOT (SUM(TotalVendido) FOR Dia IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31])) AS PivotTable;"
        Else
            str_sql = "select * from ( " & _
                    "SELECT DAY(TTO_FECHA) AS Dia, (paciente.PAC_NOMBRE + ' '+ PACIENTE.PAC_APELLIDO) as PAC_APELLIDO, I_PRD_ID, SUM(TTO_CANTIDAD) AS TotalVendido " & _
                    "FROM vacunaTratamiento, paciente " & _
                     "WHERE vacunaTratamiento.PAC_ID = paciente.PAC_ID and Year(TTO_FECHA) = " & anio & " and month(TTO_FECHA) IN(" & mes & ") and SUBSTRING(I_PRD_ABREV, LEN(I_PRD_ABREV), 1) = '" & I_EDAD & "' and paciente.PAC_GRADO <> 'CLIENTE'" & _
                     "GROUP BY DAY(TTO_FECHA), PAC_NOMBRE, PAC_APELLIDO, I_PRD_ID ) " & _
                     "as consumo " & _
                     "PIVOT ( SUM(TotalVendido) FOR Dia IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23], [24], [25], [26], [27], [28], [29], [30], [31]) " & _
                ") AS PivotTable;"
        End If

        Dim odr_tendencia As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        While odr_tendencia.Read
            dtr_fila = dtt_CDiario.NewRow

            dtr_fila(0) = odr_tendencia.Item(0) ' PAC_APELLIDO

            dtr_fila(1) = odr_tendencia.Item(1) ' I_PRD_ID

            If IsDBNull(odr_tendencia.Item(2)) Then ' 
                dtr_fila(2) = 0
            Else
                dtr_fila(2) = odr_tendencia.Item(2)
            End If

            If IsDBNull(odr_tendencia.Item(3)) Then ' 
                dtr_fila(3) = 0
            Else
                dtr_fila(3) = odr_tendencia.Item(3)
            End If

            If IsDBNull(odr_tendencia.Item(4)) Then ' 
                dtr_fila(4) = 0
            Else
                dtr_fila(4) = odr_tendencia.Item(4)
            End If

            If IsDBNull(odr_tendencia.Item(5)) Then ' 
                dtr_fila(5) = 0
            Else
                dtr_fila(5) = odr_tendencia.Item(5)
            End If

            If IsDBNull(odr_tendencia.Item(6)) Then ' 
                dtr_fila(6) = 0
            Else
                dtr_fila(6) = odr_tendencia.Item(6)
            End If

            If IsDBNull(odr_tendencia.Item(7)) Then ' 
                dtr_fila(7) = 0
            Else
                dtr_fila(7) = odr_tendencia.Item(7)
            End If

            If IsDBNull(odr_tendencia.Item(8)) Then ' 
                dtr_fila(8) = 0
            Else
                dtr_fila(8) = odr_tendencia.Item(8)
            End If

            If IsDBNull(odr_tendencia.Item(9)) Then ' 
                dtr_fila(9) = 0
            Else
                dtr_fila(9) = odr_tendencia.Item(9)
            End If

            If IsDBNull(odr_tendencia.Item(10)) Then ' 
                dtr_fila(10) = 0
            Else
                dtr_fila(10) = odr_tendencia.Item(10)
            End If

            If IsDBNull(odr_tendencia.Item(11)) Then ' 
                dtr_fila(11) = 0
            Else
                dtr_fila(11) = odr_tendencia.Item(11)
            End If

            If IsDBNull(odr_tendencia.Item(12)) Then ' 
                dtr_fila(12) = 0
            Else
                dtr_fila(12) = odr_tendencia.Item(12)
            End If

            If IsDBNull(odr_tendencia.Item(13)) Then ' 
                dtr_fila(13) = 0
            Else
                dtr_fila(13) = odr_tendencia.Item(13)
            End If

            If IsDBNull(odr_tendencia.Item(14)) Then ' 
                dtr_fila(14) = 0
            Else
                dtr_fila(14) = odr_tendencia.Item(14)
            End If

            If IsDBNull(odr_tendencia.Item(15)) Then ' 
                dtr_fila(15) = 0
            Else
                dtr_fila(15) = odr_tendencia.Item(15)
            End If

            If IsDBNull(odr_tendencia.Item(16)) Then ' 
                dtr_fila(16) = 0
            Else
                dtr_fila(16) = odr_tendencia.Item(16)
            End If

            If IsDBNull(odr_tendencia.Item(17)) Then ' 
                dtr_fila(17) = 0
            Else
                dtr_fila(17) = odr_tendencia.Item(17)
            End If

            If IsDBNull(odr_tendencia.Item(18)) Then ' 
                dtr_fila(18) = 0
            Else
                dtr_fila(18) = odr_tendencia.Item(18)
            End If

            If IsDBNull(odr_tendencia.Item(19)) Then ' 
                dtr_fila(19) = 0
            Else
                dtr_fila(19) = odr_tendencia.Item(19)
            End If

            If IsDBNull(odr_tendencia.Item(20)) Then ' 
                dtr_fila(20) = 0
            Else
                dtr_fila(20) = odr_tendencia.Item(20)
            End If

            If IsDBNull(odr_tendencia.Item(21)) Then ' 
                dtr_fila(21) = 0
            Else
                dtr_fila(21) = odr_tendencia.Item(21)
            End If

            If IsDBNull(odr_tendencia.Item(22)) Then ' 
                dtr_fila(22) = 0
            Else
                dtr_fila(22) = odr_tendencia.Item(22)
            End If

            If IsDBNull(odr_tendencia.Item(23)) Then ' 
                dtr_fila(23) = 0
            Else
                dtr_fila(23) = odr_tendencia.Item(23)
            End If

            If IsDBNull(odr_tendencia.Item(24)) Then ' 
                dtr_fila(24) = 0
            Else
                dtr_fila(24) = odr_tendencia.Item(24)
            End If

            If IsDBNull(odr_tendencia.Item(25)) Then ' 
                dtr_fila(25) = 0
            Else
                dtr_fila(25) = odr_tendencia.Item(25)
            End If

            If IsDBNull(odr_tendencia.Item(26)) Then ' 
                dtr_fila(26) = 0
            Else
                dtr_fila(26) = odr_tendencia.Item(26)
            End If

            If IsDBNull(odr_tendencia.Item(27)) Then ' 
                dtr_fila(27) = 0
            Else
                dtr_fila(27) = odr_tendencia.Item(27)
            End If

            If IsDBNull(odr_tendencia.Item(28)) Then ' 
                dtr_fila(28) = 0
            Else
                dtr_fila(28) = odr_tendencia.Item(28)
            End If

            If IsDBNull(odr_tendencia.Item(29)) Then ' 
                dtr_fila(29) = 0
            Else
                dtr_fila(29) = odr_tendencia.Item(29)
            End If

            If IsDBNull(odr_tendencia.Item(30)) Then ' 
                dtr_fila(30) = 0
            Else
                dtr_fila(30) = odr_tendencia.Item(30)
            End If

            If IsDBNull(odr_tendencia.Item(31)) Then ' 
                dtr_fila(31) = 0
            Else
                dtr_fila(31) = odr_tendencia.Item(31)
            End If

            If IsDBNull(odr_tendencia.Item(32)) Then ' 
                dtr_fila(32) = 0
            Else
                dtr_fila(32) = odr_tendencia.Item(32)
            End If

            dtt_CDiario.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt_CDiario
        odr_tendencia.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridConAnual(ByRef dgv As DataGridView, ByVal anio As Integer, ByVal I_EDAD As Char, ByRef dtt As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql, str_sqlW, str_sql2 As String

        opr_conexion.sql_conectar()

        str_sql = "SELECT " & _
            "p.I_PRD_DESCRIPCION, SUM(tp.TTO_CANTIDAD) as totalVendido " & _
            "FROM " & _
            "TratamientoPaciente as tp, i_producto as p " & _
            "WHERE tp.I_PRD_ID = p.I_PRD_ID " & _
            "AND YEAR(tp.TTO_FECHA) = " & anio & ""

        str_sqlW = "AND SUBSTRING(p.I_PRD_ABREV, LEN(p.I_PRD_ABREV), 1) = '" & I_EDAD & "'"

        str_sql2 = "GROUP BY " & _
                "p.I_PRD_DESCRIPCION"

        If I_EDAD <> "T" Then
            str_sql = str_sql & str_sqlW & str_sql2
        Else
            str_sql = str_sql & str_sql2
        End If

        Dim odr_tendencia As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_tendencia.Read
            dtr_fila = dtt.NewRow

            dtr_fila(0) = odr_tendencia.Item(0) ' Mes
            If IsDBNull(odr_tendencia.Item(1)) Then ' 2023
                dtr_fila(1) = 0
            Else
                dtr_fila(1) = odr_tendencia.Item(1)
            End If

            If IsDBNull(odr_tendencia.Item(2)) Then ' 2024
                dtr_fila(2) = 0
            Else
                dtr_fila(2) = odr_tendencia.Item(2)
            End If

            If IsDBNull(odr_tendencia.Item(3)) Then ' 2025
                dtr_fila(3) = 0
            Else
                dtr_fila(3) = odr_tendencia.Item(3)
            End If
            dtt.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt
        odr_tendencia.Close()
        opr_conexion.sql_desconn()

        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridConAnual_cli(ByRef dgv As DataGridView, ByVal anio As Integer, ByVal I_EDAD As Char, ByRef dtt As DataTable)
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql, str_sqlW, str_sql2 As String

        opr_conexion.sql_conectar()

        str_sql = "SELECT " & _
           "p.I_PRD_DESCRIPCION, SUM(tp.TTO_CANTIDAD) as totalVendido " & _
           "FROM " & _
           "TratamientoCliente as tp, i_producto as p " & _
           "WHERE tp.I_PRD_ID = p.I_PRD_ID " & _
           "AND YEAR(tp.TTO_FECHA) = " & anio & ""

        str_sqlW = "AND SUBSTRING(p.I_PRD_ABREV, LEN(p.I_PRD_ABREV), 1) = '" & I_EDAD & "'"

        str_sql2 = "GROUP BY " & _
                "p.I_PRD_DESCRIPCION"

        If I_EDAD <> "T" Then
            str_sql = str_sql & str_sqlW & str_sql2
        Else
            str_sql = str_sql & str_sql2
        End If

        Dim odr_tendencia As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_tendencia.Read
            dtr_fila = dtt.NewRow

            dtr_fila(0) = odr_tendencia.Item(0) ' Mes
            If IsDBNull(odr_tendencia.Item(1)) Then ' 2023
                dtr_fila(1) = 0
            Else
                dtr_fila(1) = odr_tendencia.Item(1)
            End If

            If IsDBNull(odr_tendencia.Item(2)) Then ' 2024
                dtr_fila(2) = 0
            Else
                dtr_fila(2) = odr_tendencia.Item(2)
            End If

            If IsDBNull(odr_tendencia.Item(3)) Then ' 2025
                dtr_fila(3) = 0
            Else
                dtr_fila(3) = odr_tendencia.Item(3)
            End If
            dtt.Rows.Add(dtr_fila)
        End While
        dgv.DataSource = dtt
        odr_tendencia.Close()
        opr_conexion.sql_desconn()

        Exit Sub
    End Sub



    Sub LlenarGridInfoPaciente(ByRef dgrd_InfoPaciente As DataGridView, ByRef Age_id As Integer, ByRef dtt_infoPac As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "select (paciente.PAC_APELLIDO + ' ' +paciente.PAC_NOMBRE) as pac_nombre, paciente.PAC_DOC, agenda.pac_edad, paciente .PAC_SEXO, paciente.pac_id " & _
                 "from agenda, paciente " & _
                 "where agenda.pac_id = paciente.PAC_ID and agenda .age_id = " & Age_id & ""

        Dim odr_InfoPAc As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader
        'Dim odr_muestra As SqlDataReader = New SqlCommand("SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & g_lng_ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And  area.TIT_ID=tipo_tubo.TIT_ID and tipo_tubo.TIT_ID=1 And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & g_lng_ped_id & ") GROUP BY TIT_NOMBRE", opr_Conexion.conn_sql).ExecuteReader
        While odr_InfoPAc.Read
            dtr_fila = dtt_infoPac.NewRow
            dtr_fila(0) = odr_InfoPAc.Item(0)
            dtr_fila(1) = odr_InfoPAc.Item(1)
            dtr_fila(2) = odr_InfoPAc.Item(2)
            dtr_fila(3) = odr_InfoPAc.Item(3)
            dtr_fila(4) = odr_InfoPAc.Item(4)
            dtt_infoPac.Rows.Add(dtr_fila)
        End While
        dgrd_InfoPaciente.DataSource = dtt_infoPac
        odr_InfoPAc.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridGrupoMedico(ByRef dgv_MedicosTratantes As DataGridView, ByRef Age_id As Integer, ByRef dtt_GrupoMedico As DataTable, ByVal med_id As String)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()
        'med_id = 0

        'str_sql = "select consultaMedico.CON_ID, medico.MED_NOMBRE,medico.med_id, consultaMedico.CON_FECHA, consultaMedico.CON_DIAGNOSTICO, consultaMedico.CON_OBS, " & _
        '        "consultaMedico.CON_ESTADO, agenda.ped_id, medico.MED_RECETA " & _
        '        "from medico, agenda, consultaMedico " & _
        '        "where consultaMedico.AGE_ID = agenda.age_id and medico.med_id in (" & med_id & ") and agenda.age_id  = " & Age_id & " "


        str_sql = "select consultaMedico.CON_ID, medico.MED_NOMBRE,medico.med_id, consultaMedico.CON_FECHA, consultaMedico.CON_DIAGNOSTICO, consultaMedico.CON_OBS, " & _
                "consultaMedico.CON_ESTADO, agenda.ped_id, medico.MED_RECETA, medico.MED_GRAFICO " & _
                "from medico, agenda, consultaMedico " & _
                "where consultaMedico.AGE_ID = agenda.age_id and consultaMedico.MED_ID = medico.med_id and medico.med_id in (" & med_id & ") and agenda.age_id  = " & Age_id & " "

        Dim odr_MedTratante As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_MedTratante.Read
            dtr_fila = dtt_GrupoMedico.NewRow
            dtr_fila(0) = odr_MedTratante.Item(0)
            dtr_fila(1) = odr_MedTratante.Item(1)
            dtr_fila(2) = odr_MedTratante.Item(2)
            If med_id = 0 Then
                med_id = CInt(odr_MedTratante.Item(2))
            End If
            dtr_fila(3) = odr_MedTratante.Item(3)
            dtr_fila(4) = odr_MedTratante.Item(4)
            dtr_fila(5) = odr_MedTratante.Item(5)
            dtr_fila(6) = odr_MedTratante.Item(6)
            dtr_fila(7) = odr_MedTratante.Item(7)
            dtr_fila(8) = odr_MedTratante.Item(8)
            dtr_fila(9) = odr_MedTratante.Item(9)
            dtt_GrupoMedico.Rows.Add(dtr_fila)
        End While
        dgv_MedicosTratantes.DataSource = dtt_GrupoMedico
        odr_MedTratante.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub

    Public Function DevuelveGrupoGrupo(ByVal GMED_ID As Integer) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "select med_id " & _
                    "from GrupoMedicoElementos " & _
                    "where gmed_id = " & GMED_ID & "" & _
                    "order by med_id asc"

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        DevuelveGrupoGrupo = ""
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            DevuelveGrupoGrupo = DevuelveGrupoGrupo & dtr_fila(0) & ","
            'Exit For
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, consulta medicos grupo", Err)
        Err.Clear()
    End Function


    Public Function EsGrupo(ByVal MED_ID As Integer) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        Dim str_sql As String = "select MED_OBS " & _
                    "from medico " & _
                    "where med_id = " & MED_ID & ""

        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        Dim dts_area As New DataSet()
        Dim dtr_fila As DataRow
        oda_operacion.Fill(dts_area, "Registros")
        EsGrupo = ""
        For Each dtr_fila In dts_area.Tables("Registros").Rows
            EsGrupo = dtr_fila(0)
        Next
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, consulta si es grupo", Err)
        Err.Clear()
    End Function


    Sub LlenarGridCieConsulta(ByRef dgv_Cie10Medico As DataGridView, ByVal Age_id As Integer, ByVal med_id As Integer, ByRef dtt_cieConsulta As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "SELECT ciec.cie_cod4, cie.cie_desc4, ciec.med_id " & _
                "FROM cie10Consulta as ciec, cie10 cie " & _
                "where cie.cie_cod4 = ciec.cie_cod4 and ciec.Age_id = " & Age_id & " and med_id = " & med_id & ""

        Dim odr_CieMedico As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_CieMedico.Read
            dtr_fila = dtt_cieConsulta.NewRow
            dtr_fila(0) = odr_CieMedico.Item(0)
            dtr_fila(1) = odr_CieMedico.Item(1)
            dtr_fila(2) = odr_CieMedico.Item(2)
            dtt_cieConsulta.Rows.Add(dtr_fila)
        End While
        dgv_Cie10Medico.DataSource = dtt_cieConsulta
        odr_CieMedico.Close()
        opr_conexion.sql_desconn()


        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Sub LlenarGridConHist(ByRef dgv_ConsultaHistorico As DataGridView, ByVal pac_id As Integer, ByRef dtt_conHist As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        ''str_sql = "select AGE_ID, CON_FECHA, MEDICO.MED_NOMBRE, MEDICO.MED_ID " & _
        ''        "from consultaMedico, medico " & _
        ''        "where medico.med_id= consultaMedico.MED_ID and pac_id=" & pac_id & " and CON_FECHA <> ''"

        str_sql = "select AGE_ID, AGE_FECHA, AGE_HORA, MEDICO.MED_NOMBRE, MEDICO.MED_ID, AGENDA.AGE_ESTADO " & _
                    "from agenda, medico " & _
                    "where medico.med_id = agenda.med_id and pac_id = " & pac_id & " " & _
                    "order by age_id desc"

        Dim odr_ConHist As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_ConHist.Read
            dtr_fila = dtt_conHist.NewRow
            dtr_fila(0) = odr_ConHist.Item(0)
            dtr_fila(1) = odr_ConHist.Item(1)
            dtr_fila(2) = odr_ConHist.Item(2)
            dtr_fila(3) = odr_ConHist.Item(3)
            dtr_fila(4) = odr_ConHist.Item(4)
            dtr_fila(5) = odr_ConHist.Item(5)
            dtt_conHist.Rows.Add(dtr_fila)
        End While
        dgv_ConsultaHistorico.DataSource = dtt_conHist
        odr_ConHist.Close()
        opr_conexion.sql_desconn()


        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub


    Public Function LlenarGridConHistMedicos(ByRef dgv_ConsultaHistoricoMedico As DataGridView, ByVal pac_id As Integer, ByVal AGE_ID As Integer, ByRef dtt_conHistMedicos As DataTable) As Boolean
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "select consultaMedico.AGE_ID, CON_FECHA, MEDICO.MED_NOMBRE, MEDICO.MED_ID, PED_ID " & _
                "from consultaMedico, medico, agenda " & _
                "where medico.med_id= consultaMedico.MED_ID and agenda.age_id = consultaMedico.AGE_ID and consultaMedico.pac_id=" & pac_id & " and consultaMedico.AGE_ID = " & AGE_ID & " and CON_FECHA <> ''"

        Dim odr_ConHist As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_ConHist.Read
            dtr_fila = dtt_conHistMedicos.NewRow
            dtr_fila(0) = odr_ConHist.Item(0)
            dtr_fila(1) = odr_ConHist.Item(1)
            dtr_fila(2) = odr_ConHist.Item(2)
            dtr_fila(3) = odr_ConHist.Item(3)
            dtr_fila(4) = odr_ConHist.Item(4)
            dtt_conHistMedicos.Rows.Add(dtr_fila)
        End While

        dgv_ConsultaHistoricoMedico.DataSource = dtt_conHistMedicos
        If dtt_conHistMedicos.Rows.Count > 0 Then
            LlenarGridConHistMedicos = True
        Else
            LlenarGridConHistMedicos = False
        End If

        odr_ConHist.Close()
        opr_conexion.sql_desconn()

        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Function


    Sub LlenarGridCiudad(ByRef dgv_Ciudad As DataGridView, ByRef Prov_id As Integer, ByRef dtt_Ciudad As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "SELECT provincia.PROV_ID, provincia.PROV_NOMBRE, ciudad.CIU_ID, ciudad.CIU_NOMBRE " & _
                "from provincia, CIUDAD " & _
                "where provincia.PROV_ID = ciudad.prov_id and provincia .PROV_ID = " & Prov_id & " order by ciudad.ciu_nombre;"

        Dim odr_Ciudad As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_Ciudad.Read
            dtr_fila = dtt_Ciudad.NewRow
            dtr_fila(0) = odr_Ciudad.Item(0)
            dtr_fila(1) = odr_Ciudad.Item(1)
            dtr_fila(2) = odr_Ciudad.Item(2)
            dtr_fila(3) = odr_Ciudad.Item(3)
            dtt_Ciudad.Rows.Add(dtr_fila)
        End While
        dgv_Ciudad.DataSource = dtt_Ciudad
        odr_Ciudad.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub



    Sub LlenarGrupoMedico(ByRef dgv_MedicosTratantes As DataGridView, ByRef GMed_id As Integer, ByRef dtt_GrupoMedico As DataTable)
        'funcion que llena un datagrid con los tipos y cantidades de muestra de un pedido determinado
        On Error Resume Next
        Dim opr_conexion As New Cls_Conexion()
        Dim dtr_fila As DataRow
        Dim str_sql As String = ""
        opr_conexion.sql_conectar()

        str_sql = "select gm.MED_ID, m.MED_NOMBRE " & _
                    "from Medico as m, GrupoMedicoElementos as gm " & _
                    "where(m.med_id = gm.med_id And m.MED_ESTADO <> 0) " & _
                    "and gm.gmed_id = " & GMed_id

        Dim odr_MedTratante As SqlDataReader = New SqlCommand(str_sql, opr_conexion.conn_sql).ExecuteReader

        While odr_MedTratante.Read
            dtr_fila = dtt_GrupoMedico.NewRow
            dtr_fila(0) = odr_MedTratante.Item(0)
            dtr_fila(1) = odr_MedTratante.Item(1)

            dtt_GrupoMedico.Rows.Add(dtr_fila)
        End While
        dgv_MedicosTratantes.DataSource = dtt_GrupoMedico
        odr_MedTratante.Close()
        opr_conexion.sql_desconn()
        Exit Sub
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Leer Cantidad Muestra", Err)
        '        Err.Clear()
    End Sub



    Public Function LlenaMedicoAgenda(ByVal fechaini As String, ByVal fechafin As String) As DataSet
        'funcion que devuelve los datos de un paciente en un dataset,recibe el codigo de un determinado pedido
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_paciente As SqlDataAdapter = New SqlDataAdapter()
        opr_conexion.sql_conectar()
        oda_paciente.SelectCommand = New SqlCommand("select (m.MED_NOMBRE + char(13) + char(14) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.MED_OBS = 'Tratante'", opr_conexion.conn_sql)
        LlenaMedicoAgenda = New DataSet()
        oda_paciente.Fill(LlenaMedicoAgenda, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Leer medico especialdiad", Err)
        Err.Clear()
    End Function



    Public Function LlenaListMedicoAgenda(ByRef lst_pedidos As ListBox, ByVal fechaini As String, ByVal fechafin As String) As DataSet
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim str_sql As String = Nothing

        str_sql = "select (m.MED_NOMBRE + char(13) + char(14) + e.esp_desc) as MED_NOMBRE, m.MED_ID, m.MED_MAIL from medico as m, especialidad as e where m.ESP_ID = e.esp_id and m.MED_OBS = 'Tratante'"

        Dim dtt_aux As New DataTable()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim tienesaldo As String = ""
        Dim saldo As Double = 0

        cls_operacion.sql_conectar()
        lst_pedidos.Items.Clear()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        LlenaListMedicoAgenda = New DataSet()
        oda_operacion.Fill(LlenaListMedicoAgenda, "Registros")



        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_pedidos.Items.Add(odr_operacion.GetValue(0).ToString().PadRight(100) & odr_operacion.GetValue(1).ToString() & vbCrLf & odr_operacion.GetValue(2).ToString().PadRight(50))
        End While


        odr_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer lista agenda medicos", Err)
        Err.Clear()
    End Function




    Public Function LlenaListPedidoConvenio(ByRef lst_pedidos As ListBox, ByVal fechaini As String, ByVal fechafin As String, ByVal areas As String, ByVal proforma As Integer, ByVal prioridad As String, ByVal secuencias As String, ByVal estado As String, Optional ByVal ped_id As Integer = 0, Optional ByRef fitroOrdenes As String = "") As DataSet
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim str_sql As String = Nothing
        Dim str_aux As String = Nothing
        Dim str_prio As String = Nothing
        Dim str_order As String = Nothing
        Dim str_sec() As String
        Dim str_secuencias As String = Nothing

        str_sec = Split(secuencias, ",")
        fitroOrdenes = Nothing


        If Trim(str_sec(0).ToString()) <> "TODOS" Then
            str_prio = " and pedido.PED_TIPO = '" & Trim(str_sec(0).ToString()) & "'"
        End If


        If str_sec(0).ToString() = "NORMAL" Or str_sec(0).ToString() = "URGENCIA" Or str_sec(0).ToString() = "EMERGENCIA" Or str_sec(0).ToString() = "TODOS" Then

        Else

            str_secuencias = " and pedido.ped_turno between '" & str_sec(1) & "' and '" & str_sec(2) & "' "
        End If



        'MACROLAB
        str_order = " order by ped_id, ped_fecing, ped_turno, pac_id, PACIENTE, pac_fecnac, ped_antecedente, ped_medicacion, med_id, med_nombre, ped_nota, pac_usafecnac, CI, LAB, PROF, EMAIL asc "

        Select Case proforma
            Case 0 ' es pedido sin validar
                If areas <> "00" And areas <> "0" Then
                    str_sql = "SELECT PEDIDO.PED_FECING as ped_fecing, concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO, if(PEDIDO.PED_PROF=1,'P',if(length(PEDIDO.PED_TIPO)=6,'N','E' )) as PED_PROF, IF(PEDIDO.FAC_ID <> '',PEDIDO.FAC_ID,'ND') as FAC_ID, PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, PEDIDO.PED_OBS " & _
                    "FROM PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID  AND TEST.are_id in (" & areas & ") "

                    str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') group by PEDIDO.PED_ID order by PEDIDO.ped_id asc, PEDIDO.ped_turno asc  "
                    str_sql = str_sql & " " & str_aux

                Else
                    str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                    "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                    "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                    "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                    "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                    "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                    "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                    "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, ped_servicio as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS " & _
                    "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                    "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                    "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                    "and servicio.ser_nombre = pedido.ped_servicio " & _
                    "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                    "and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 3 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5 OR PEDIDO.PED_ESTADO = 6) " & _
                    "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') "
                    '"and test.ARE_ID = '" & areas & "'"


                    If prioridad <> "TODOS" Then
                        str_sql = str_sql & str_secuencias & str_order

                    Else
                        str_sql = str_sql & str_prio & str_order

                    End If

                    ''str_sql = "SELECT PEDIDO.PED_FECING as ped_fecing, concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO, if(PEDIDO.PED_PROF=1,'P',if(length(PEDIDO.PED_TIPO)=6,'N','E' )) as PED_PROF, IF(PEDIDO.FAC_ID <> '',PEDIDO.FAC_ID,'ND') as FAC_ID, PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF  " & _
                    ''"FROM PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') AND (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 3 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) "

                    ''str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') group by PEDIDO.PED_ID order by PEDIDO.ped_id asc, PEDIDO.ped_turno asc  "
                    ''str_sql = str_sql & " " & str_aux

                End If

            Case 1 ' es proforma
                If areas <> "00" And areas <> "0" Then
                    If ped_id = 0 Then
                        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                        "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, ped_servicio as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS " & _
                        "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                        "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                        "and servicio.ser_nombre = pedido.ped_servicio " & _
                        "and PEDIDO.PED_PROF <> 1 " & _
                        "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                        "and PEDIDO.PED_ESTADO in " & estado & _
                        "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') " & _
                        "and test.ARE_ID = '" & areas & "'"

                        '"and (PEDIDO.PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _

                        If prioridad <> "TODOS" Then
                            str_sql = str_sql & str_prio & str_order
                        Else
                            str_sql = str_sql & str_secuencias & str_order
                        End If
                    Else
                        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                        "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, ped_servicio as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS " & _
                        "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                        "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                        "and servicio.ser_nombre = pedido.ped_servicio " & _
                        "and PEDIDO.PED_PROF <> 1 " & _
                        "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                        "and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _
                        "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') and PEDIDO.PED_id = " & ped_id & _
                        "and test.ARE_ID = '" & areas & "'"

                        If prioridad <> "TODOS" Then
                            str_sql = str_sql & str_prio & str_order
                        Else
                            str_sql = str_sql & str_secuencias & str_order
                        End If
                    End If
                Else
                    If ped_id = 0 Then
                        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                        "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, ped_servicio as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS " & _
                        "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                        "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                        "and servicio.ser_nombre = pedido.ped_servicio " & _
                        "and PEDIDO.PED_PROF <> 1 " & _
                        "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                        "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') " & _
                        "and PEDIDO.PED_ESTADO in " & estado
                        '"and test.ARE_ID = '" & areas & "'"
                        '"and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _

                        If prioridad <> "TODOS" Then
                            str_sql = str_sql & str_prio & str_order
                        Else
                            str_sql = str_sql & str_secuencias & str_order
                        End If
                    Else
                        str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                        "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                        "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                        "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                        "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                        "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                        "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' else 'N' end as PED_PROF, " & _
                        "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                        "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, ped_servicio as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS " & _
                        "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                        "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                        "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                        "and PEDIDO.PED_PROF <> 1 " & _
                        "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                        "and (PEDIDO. PED_ESTADO  = 0 or PEDIDO. PED_ESTADO  = 1 OR PEDIDO.PED_ESTADO = 2 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) " & _
                        "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') and PEDIDO.PED_id = " & ped_id
                        '"and test.ARE_ID = '" & areas & "'"


                        If Trim(str_sec(0).ToString()) <> "TODOS" Then
                            'str_prio = " and pedido.PED_TIPO = '" & Trim(str_sec(0).ToString()) & "'"
                            If prioridad <> "TODOS" Then
                                str_sql = str_sql & str_prio & str_order
                            Else
                                str_sql = str_sql & str_secuencias & str_order
                            End If
                        Else


                            If prioridad <> "TODOS" Then
                                str_sql = str_sql & str_prio & str_order
                            Else
                                str_sql = str_sql & str_secuencias & str_order
                            End If

                        End If
                    End If

                End If

            Case 2 ' es pedido validado
                If areas <> "00" And areas <> "0" Then
                    str_sql = "SELECT PEDIDO.PED_FECING as ped_fecing, concat(mid(PEDIDO.PED_FECING,6,2),mid(PEDIDO.PED_FECING,9,2), if(length(PEDIDO.PED_TURNO)=1,concat('000',PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=2,concat('00', PEDIDO.PED_TURNO), if(length(PEDIDO.PED_TURNO)=3,concat('0', PEDIDO.PED_TURNO), PEDIDO.PED_TURNO)))) as ped_turno, PEDIDO.PAC_ID as pac_id, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO, if(PEDIDO.PED_PROF=1,'P',if(length(PEDIDO.PED_TIPO)=6,'N','E' )) as PED_PROF, PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, PEDIDO.PED_OBS " & _
                    "FROM PACIENTE, MEDICO, PEDIDO, LISTA_TRABAJO, TEST WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID and TEST.TES_ID = LISTA_TRABAJO.TES_ID and PEDIDO.PED_PROF <> " & proforma & " AND TEST.are_id in( " & areas & ") "

                    str_aux = str_aux & " and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') group by PEDIDO.PED_ID order by PEDIDO.ped_id asc, PEDIDO.ped_turno asc  "
                    str_sql = str_sql & " " & str_aux

                Else

                    str_sql = "SELECT DISTINCT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                    "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                    "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end) as ped_turno, " & _
                    "PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO + ' ' + PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac,  " & _
                    "PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, " & _
                    "MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, LISTA_TRABAJO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, " & _
                    "PEDIDO.pac_id as CI, PED_RECIBO, " & _
                    "case when (PEDIDO.PED_PROF=1) then 'P' when (PEDIDO.PED_TIPO)='URGENCIA' then 'E' ELSE 'N' end as PED_PROF, " & _
                    "case when len(PEDIDO.PED_TIPO)<> 6 then PEDIDO.FAC_ID When (PEDIDO.FAC_ID <> '') then PEDIDO.FAC_ID else 'ND' end as FAC_ID, " & _
                    "PEDIDO.LAB_ID AS LAB, PEDIDO.PED_PROF AS PROF, paciente.PAC_MAIL as EMAIL, paciente.PAC_OBS as OBS, ped_servicio as servicio, servicio.ser_correo as SvrCorreo, PEDIDO.PED_OBS, PEDIDO.PED_TIPO " & _
                    "from pedido, medico, paciente, lista_trabajo, test, servicio " & _
                    "where MEDICO.MED_ID = PEDIDO.MED_ID and paciente.PAC_ID = pedido.PAC_ID " & _
                    "and servicio.ser_nombre = pedido.ped_servicio " & _
                    "and LISTA_TRABAJO.PED_ID = pedido.PED_ID and test.TES_ID = lista_trabajo.TES_ID " & _
                    "and (TEST.TES_TIPO = 'Examen' or TEST.TES_TIPO = 'Procedimiento' or TEST.TES_TIPO = 'Farmaco') " & _
                    "and (PEDIDO.PED_ESTADO  <> 2 and PEDIDO.PED_ESTADO <> 1 and PEDIDO.PED_ESTADO <> 0) " & _
                    "and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') "
                    '"and test.ARE_ID = '" & areas & "'"

                    If prioridad <> "TODOS" Then
                        str_sql = str_sql & str_prio & str_order
                    Else
                        str_sql = str_sql & str_secuencias & str_order
                    End If

                End If

        End Select


        Dim dtt_aux As New DataTable()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim tienesaldo As String = ""
        Dim saldo As Double = 0

        cls_operacion.sql_conectar()
        lst_pedidos.Items.Clear()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        LlenaListPedidoConvenio = New DataSet()
        oda_operacion.Fill(LlenaListPedidoConvenio, "Registros")



        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_pedidos.Items.Add("(" & odr_operacion.GetValue(14).ToString() & ")" & odr_operacion.GetValue(1).ToString() & "     " & odr_operacion.GetValue(3).ToString().PadRight(50) & "     " & odr_operacion.GetValue(10).ToString().PadRight(10) & "     " & odr_operacion.GetValue(18).ToString().PadRight(100) & "     " & odr_operacion.GetValue(4).ToString() & "     " & odr_operacion.GetValue(19).ToString() & "     " & odr_operacion.GetValue(21).ToString())
            fitroOrdenes = fitroOrdenes & odr_operacion.GetValue(1).ToString() & ","
        End While


        odr_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer lista pedidos", Err)
        Err.Clear()
    End Function




    Public Function LlenaListPedidoPaciente(ByRef lst_pedidos As ListBox, ByVal Ped_id As Integer) As DataSet
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim str_sql As String = ""
        Dim str_aux As String = ""



        str_sql = "SELECT PEDIDO.PED_FECING as ped_fecing, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ case when len(PEDIDO.PED_TURNO) = 1 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 2 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 3 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) when len(PEDIDO.PED_TURNO) = 4 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno, PEDIDO.PAC_ID as pac_id, (PACIENTE.PAC_APELLIDO+ ' '+ PACIENTE.PAC_NOMBRE) AS PACIENTE, PACIENTE.PAC_FECNAC as pac_fecnac, PEDIDO.PED_ANTECEDENTE as ped_antecedente, PEDIDO.PED_MEDICACION as ped_medicacion, MEDICO.MED_ID as med_id, MEDICO.MED_NOMBRE as med_nombre, PEDIDO.ped_nota as ped_nota, PEDIDO.PED_ID as ped_id, PACIENTE.PAC_USAFECNAC as pac_usafecnac, PEDIDO.pac_id as CI, PED_RECIBO, case when (PEDIDO.PED_PROF=1) then 'P' else case when (len(PEDIDO.PED_TIPO)=6) then 'N'else 'E' end end as PED_PROF, PEDIDO.LAB_ID AS LAB  " & _
        "FROM PACIENTE, MEDICO, PEDIDO WHERE MEDICO.MED_ID = PEDIDO.MED_ID AND PACIENTE.PAC_ID = PEDIDO.PAC_ID AND (PEDIDO.PED_ESTADO  = 2 OR PEDIDO.PED_ESTADO = 1 OR PEDIDO.PED_ESTADO = 0 OR PEDIDO.PED_ESTADO = 3 OR PEDIDO.PED_ESTADO = 4 OR PEDIDO.PED_ESTADO = 5) and PEDIDO.PED_ID = " & Ped_id & " "

        Dim dtt_aux As New DataTable()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim tienesaldo As String = ""
        Dim saldo As Double = 0

        cls_operacion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        LlenaListPedidoPaciente = New DataSet()
        oda_operacion.Fill(LlenaListPedidoPaciente, "Registros")


        lst_pedidos.Items.Clear()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_pedidos.Items.Add("(" & odr_operacion.GetValue(14).ToString() & ")" & odr_operacion.GetValue(1).ToString() & "     " & odr_operacion.GetValue(3).ToString().PadRight(40) & "     " & odr_operacion.GetValue(10).ToString().PadRight(10))
        End While

        odr_operacion.Close()
        cls_operacion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Precio Perfil", Err)
        Err.Clear()
    End Function


    Public Function LlenaListManuales(ByRef lst_manuales As ListBox, ByVal orden As String, ByVal area As Integer) As DataSet
        On Error GoTo MsgError
        Dim cls_operacion As New Cls_Conexion()

        Dim str_sql As String = ""
        Dim str_sql1 As String = ""
        Dim str_aux As String = ""
        Dim fechaini, fechafin, turno, STR_FECHA As String
        Dim str_areas As String = ""
        Dim int_i As Integer


        fechaini = Format(Now, "yyyy") & "-" & Mid(orden, 1, 2) & "-" & Mid(orden, 3, 2)
        fechafin = fechaini
        turno = Mid(orden, 5, 4)


        If area <> 0 Then


        Else

            STR_FECHA = " and (PEDIDO.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59') and PEDIDO.ped_turno = " & turno & " "
            str_sql = "SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing , CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST INNER JOIN ((PACIENTE INNER JOIN PEDIDO ON PACIENTE.PAC_ID = PEDIDO.PAC_ID) INNER JOIN LISTA_TRABAJO ON PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID) ON TEST.TES_ID = LISTA_TRABAJO.TES_ID WHERE (((LISTA_TRABAJO.LIS_RESESTADO) = 0 or (LISTA_TRABAJO.LIS_RESESTADO) = 3) And ((TEST.TES_TPROCES) = 0)) " & STR_FECHA
            str_sql1 = "union SELECT LISTA_TRABAJO.PED_ID as ped_id, PEDIDO.PED_FECING as ped_fecing, CONCAT(PACIENTE.PAC_APELLIDO, ' ' , PACIENTE.PAC_NOMBRE) AS PACIENTE, LISTA_TRABAJO.TES_ID as tes_id, TEST.TES_NOMBRE as tes_nombre, LISTA_TRABAJO.LIS_RESESTADO as lis_resestado, TEST.TES_TPROCES as tes_tproces, PEDIDO.PED_TIPO as ped_tipo, PEDIDO.PED_TIPO as ped_tipo, PACIENTE.pac_fecnac as pac_fecnac, PACIENTE.pac_obs as pac_obs, PEDIDO.ped_antecedente as ped_antecedente, PEDIDO.ped_medicacion as ped_medicacion, PEDIDO.ped_turno as ped_turno, PACIENTE.pac_usafecnac as pac_usafecnac FROM TEST, PACIENTE, PEDIDO, LISTA_TRABAJO WHERE TEST.TES_ID = LISTA_TRABAJO.TES_ID AND PEDIDO.PED_ID = LISTA_TRABAJO.PED_ID AND LISTA_TRABAJO.LIS_RESESTADO=0 AND TEST.TES_TPROCES=1 AND PACIENTE.PAC_ID = PEDIDO.PAC_ID and LISTA_TRABAJO.EQU_ID IS NULL" & STR_FECHA

            Dim areas() As String
            str_aux = "and ("
            areas = Split(str_areas, ",")
            int_i = UBound(areas)
            'controla que tenga areas por consultar
            Dim i As Integer
            If int_i > 0 Then
                For i = 0 To (int_i - 1)
                    If i = 0 Then
                        str_aux = str_aux & "TEST.are_id=" & Trim(areas(i))
                    Else
                        str_aux = str_aux & " or TEST.are_id = " & Trim(areas(i)) & ""
                    End If
                Next
                str_aux = str_aux & " ) "
            End If
            str_sql = str_sql & str_aux

            str_aux = str_aux & "group by PEDIDO.PED_ID order by ped_fecing desc"
            str_sql = str_sql & str_sql1 & " " & str_aux


        End If

        Dim dtt_aux As New DataTable()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()

        cls_operacion.sql_conectar()

        oda_operacion.SelectCommand = New SqlCommand(str_sql, cls_operacion.conn_sql)
        LlenaListManuales = New DataSet()
        oda_operacion.Fill(LlenaListManuales, "Registros")


        lst_manuales.Items.Clear()
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
        While odr_operacion.Read
            lst_manuales.Items.Add(odr_operacion.GetValue(1).ToString() & "          " & odr_operacion.GetValue(3).ToString())
        End While
        'odr_operacion.Close()
        cls_operacion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Precio Perfil", Err)
        Err.Clear()
    End Function


End Class