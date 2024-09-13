'********************************************************************************
' Nombre:   Cls_Factura
' Tipo de Archivo: clase
' Descripcin:  Clase para operar contra la tabla Factura, Factura_Detalle, Abono
' Autores:  RFN
' Fecha de Creaci�n: 2 de Agosto del 2002
' Proyecto TRUESOLUTIONS
'********************************************************************************
Imports System
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Math
Imports System.Data.SqlClient


Public Class Cls_Factura
    Public Conn_BD As SqlConnection


    Public Function Letras(ByVal numero As String) As String
        Dim palabras, entero, dec, flag As String
        Dim num, x, y As Integer
        flag = "N"
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y
        Dim enterocn As Integer
        '''entero = (entero.Replace(",".ToString, "".ToString))

        If Len(dec) = 1 Then dec = dec & "0"
        flag = "N"
        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                palabras = palabras & "Ciento "
                            Case "2"
                                palabras = palabras & "Doscientos "
                            Case "3"
                                palabras = palabras & "Trescientos "

                            Case "4"
                                palabras = palabras & "Cuatrocientos "
                            Case "5"
                                palabras = palabras & "Quinientos "
                            Case "6"
                                palabras = palabras & "Seiscientos "
                            Case "7"
                                palabras = palabras & "Setecientos "
                            Case "8"
                                palabras = palabras & "Ochocientos "
                                '*hasta el 9
                            Case "9"
                                palabras = palabras & "Novecientos "
                        End Select
                    Case 2, 5, 8
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "Diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "Once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "Doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "Trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "Catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "Quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "Dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "Uno "
                                    Else
                                        palabras = palabras & "Un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "Dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "Tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "Cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "Cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "Seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "Siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "Ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "Nueve "
                        End Select
                End Select

                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And Len(entero) <= 6) Then
                        palabras = palabras & "Mil "
                    End If
                    If y = 7 Then
                        If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                            palabras = palabras & "Millon "
                        Else
                            palabras = palabras & "Millones "
                        End If
                    End If
                End If
            Next y

            If palabras = "" Then
                Letras = "CERO USD"
            Else
                If dec <> "" Then
                    Dim AuxDec As String
                    If dec.Length > 2 Then
                        AuxDec = Mid(dec, 2, 1)
                        Letras = palabras & " " & " Con " & AuxDec & "/100"
                    Else
                        Letras = palabras & " " & " Con " & dec & "/100"
                    End If
                Else
                    Letras = palabras & " USD"
                End If
            End If
            Return Letras
        End If
    End Function


    
    Public Function ExisteFactura(ByVal FAC_ID As String, Optional ByRef FAC_ESTADO As Single = 0) As Boolean
        'Procedimiento para los verificar si una factura existe y su estado
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_operacion As New DataSet()
        Dim dtr_operacion As DataRow
        Dim STR_SQL As String

        opr_conexion.sql_conectar()
        STR_SQL = "Select FAC_ID, FAC_ESTATUS from Factura where FAC_ID = '" & FAC_ID & "'"
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_operacion)
        ExisteFactura = False
        If dts_operacion.Tables(0).Rows.Count() > 0 Then
            ExisteFactura = True
            dtr_operacion = dts_operacion.Tables(0).Rows(0)
            If Not IsDBNull(dtr_operacion(1)) Then
                FAC_ESTADO = dtr_operacion(1)
            End If
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Verifica existencia de factura", Err)
        Err.Clear()
    End Function

    Public Function OperaAbonoPendiente(ByVal FAC_ID As String, ByVal ABO_FECING As Date, ByVal ABO_MONTO As Double, ByVal ABO_REFER As String, ByVal Cancela As Integer) As Short
        'Procedimiento para ingresar los datos de un abono
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        Dim Str_letras As String = Nothing
        If ABO_MONTO = 0.0 Then
            Str_letras = ""
        Else
            Str_letras = Letras(CStr(ABO_MONTO))
        End If
        '& Format(ABO_FECING, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") &
        OperaAbonoPendiente = 1      'ok proceso
        opr_conexion.sql_conectar()
        STR_SQL = "Insert into Abono (FAC_ID, ABO_ID, ABO_FECING, ABO_MONTO, ABO_REFER) values ('" & _
        FAC_ID & "', " & LeerMaxAbono(FAC_ID) + 1 & ", '" & ABO_FECING & "', " & ABO_MONTO & ", '" & ABO_REFER & "')"
        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        g_opr_usuario.CargarTransaccion(g_str_login, "Insertar abono", "Factura=" & FAC_ID & " Abono= " & ABO_MONTO, g_sng_user, "", "", "")
        'se actualiza el estado de la factura
        'cancela 0 emitido, 1 abonada, 2 cancelada, 3 anulada
        STR_SQL = "Update FACTURA set ESTADO_FE = " & Cancela & ", FAC_LETRAS = '" & Str_letras & "' where FAC_ID = '" & FAC_ID & "'"
        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        If Cancela = 0 Then
            g_opr_usuario.CargarTransaccion(g_str_login, "Pendiente FACTURA", "FACTURA=" & FAC_ID, g_sng_user, g_lng_ped_id, "", "")
        Else
            g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza FACTURA", "FACTURA=" & FAC_ID & "/" & ABO_MONTO, g_sng_user, g_lng_ped_id, "", "")
        End If
        opr_conexion.sql_desconn()


        MsgBox("Datos Registrados", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Insertar abono", Err)
        Err.Clear()
        OperaAbonoPendiente = 0      'bad proceso
    End Function

    Public Sub GuardaAbonoTemporal(ByVal str_sql As String)

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()

        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)

        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Ingresa Temporal Abono", Err)
        Err.Clear()
    End Sub


    Public Sub EliminaAbonoTemporal()

        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String = "Delete from abono_temp"

        opr_conexion.sql_conectar()

        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)

        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, Elimina Temporal Abono", Err)
        Err.Clear()
    End Sub

    Public Function LeerFactura(ByVal FAC_ID As String) As DataSet
        'Procedimiento para los datos de una factura especifica
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim STR_SQL As String
        'FAC_DOC-->0        FAC_TIPODOC-->1         FAC_FECING-->2          FAC_TOTAL-->3   
        'FAC_IVA-->4        FAC_DESCUENTO-->5       FAC_NOMBRE-->6          FAC_APELLIDO-->7
        'FAC_FONO-->8       FAC_DIRECCION-->9       FAC_ESTATUS-->10        FAD_CANTIDAD-->11
        'FAD_PRECIO-->12    TES_ID-->13            FAD_TIPO-->14           FAC_TEXTO-->15 
        'FAC_RECARGO-->16   FAC_REFERENCIA-->17     FAC_FORMAPAGO-->18
        opr_conexion.sql_conectar()
        STR_SQL = "SELECT FAC_DOC, FAC_TIPODOC, FAC_FECING, FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_NOMBRE, FAC_APELLIDO,  " & _
        "FAC_FONO, FAC_DIRECCION, FAC_ESTATUS, FAD_CANTIDAD, FAD_PRECIO, TES_ID, FAD_TIPO, FAC_TEXTO, FAC_RECARGO, FAC_REFERENCIA, FAC_FORMAPAGO, FAC_TRANSACCION " & _
        "FROM FACTURA, FACTURA_DETALLE where FACTURA.FAC_ID = '" & FAC_ID & "'  and  FACTURA.FAC_ID = FACTURA_DETALLE.FAC_ID "
        oda_operacion.SelectCommand = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        LeerFactura = New DataSet()
        oda_operacion.Fill(LeerFactura, "Registros")
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, consulta de facturas", Err)
        Err.Clear()
    End Function

    Public Function LeerSumAbonos(ByVal FAC_ID As String) As Double
        'Procedimiento para obtener la suma de los abonos por factura
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        LeerSumAbonos = 0
        opr_conexion.sql_conectar()
        STR_SQL = "select sum(ABO_MONTO) FROM ABONO where FAC_ID = '" & FAC_ID & "' group by FAC_ID"
        Dim odr_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            LeerSumAbonos = odr_operacion.GetValue(0)
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, consulta de abonos", Err)
        Err.Clear()
    End Function


    Public Function LeerTransaccion(ByVal FAC_ID As String) As String
        'Procedimiento para obtener la suma de los abonos por factura
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        LeerTransaccion = 0
        opr_conexion.sql_conectar()
        STR_SQL = "select FAC_TRANSACCION FROM FACTURA where FAC_ID = '" & FAC_ID & "'; "
        Dim odr_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            LeerTransaccion = odr_operacion.GetString(0)
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, consulta transaccion factura", Err)
        Err.Clear()
    End Function

    Public Function LeerEstadoFac(ByVal FAC_ID As String) As Integer
        'Procedimiento para obtener la suma de los abonos por factura
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        LeerEstadoFac = 0
        opr_conexion.sql_conectar()
        STR_SQL = "select FAC_ESTATUS FROM FACTURA where FAC_ID = '" & FAC_ID & "'; "
        Dim odr_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            LeerEstadoFac = odr_operacion.GetValue(0)
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, consulta estado factura", Err)
        Err.Clear()
    End Function


    Public Function LeerTotalFac(ByVal FAC_ID As String) As Double
        'Procedimiento para obtener la suma de los abonos por factura
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim STR_SQL As String
        LeerTotalFac = 0
        opr_conexion.sql_conectar()
        STR_SQL = "select case when FACTURA.fac_descuento > 0 then (FACTURA.fac_total - (FACTURA.fac_total * FACTURA.fac_descuento)/100) " & _
        "when FACTURA.fac_recargo > 0 then (fac_total + (fac_total * fac_recargo )/100) else factura.fac_total end as fac_total " & _
        "FROM FACTURA  " & _
        "where FAC_ID = '" & FAC_ID & "'"
        Dim odr_operacion As SqlDataReader = New SqlCommand(STR_SQL, opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            LeerTotalFac = odr_operacion.GetValue(0)
        End While
        odr_operacion.Close()
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, consulta de abonos", Err)
        Err.Clear()
    End Function

    Public Function LeerMaxAbono(ByVal FAC_ID As String) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxAbono = CInt(New SqlCommand("Select isnull(Max(ABO_ID),0) from abono where FAC_ID = '" & FAC_ID & "'", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo codigo abono", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxFad_id(ByVal FAC_ID As String) As Integer
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxFad_id = CInt(New SqlCommand("Select isnull(Max(FAD_ID),0) from FACTURA_DETALLE where FAC_ID = '" & FAC_ID & "'", opr_conexion.conn_sql).ExecuteScalar)
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo fad_id FACTURA", Err)
        Err.Clear()
    End Function

    Public Function ObtieneNumFactura(ByVal ped_id As Long) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ObtieneNumFactura = New SqlCommand("select FAC_ID from pedido where ped_id = " & ped_id & " ", opr_conexion.conn_sql).ExecuteScalar

        ObtieneNumFactura = ObtieneNumFactura + 1
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo codigo factura", Err)
        Err.Clear()
    End Function

    Public Function ObtieneFac_id(ByVal ped_id As Long) As String
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        ObtieneFac_id = New SqlCommand("select FAC_ID from pedido where ped_id = " & ped_id & " ", opr_conexion.conn_sql).ExecuteScalar

        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo codigo factura", Err)
        Err.Clear()
    End Function


    Public Function LeerMaxFactura() As Long
        'Procedimiento para extraer el c�digo m�ximo de factura
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        LeerMaxFactura = CLng(New SqlCommand("select isnull(max(FOL_NUM), 0) from Folio where FOL_ID=1", opr_conexion.conn_sql).ExecuteScalar)
        If LeerMaxFactura = 0 Then
            'inserta el registro inicial en la tabla folio, que hace la referencia para las facturas
            Dim oda_operacion As SqlCommand
            oda_operacion = New SqlCommand("Delete from FOLIO where fol_id=1", opr_conexion.conn_sql)
            oda_operacion.ExecuteNonQuery()
            oda_operacion = New SqlCommand("Insert into FOLIO (FOL_ID, FOL_NUM) values (1,1)", opr_conexion.conn_sql)
            oda_operacion.ExecuteNonQuery()
            LeerMaxFactura = 1
        Else
            LeerMaxFactura = LeerMaxFactura + 1
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Maximo codigo factura", Err)
        Err.Clear()
    End Function
    Public Function CambiaTransaccionFactura(ByVal fac_id As String, ByVal Fac_Transaccion As String)
        Dim str_sql As String
        Dim odbc_strsql As SqlCommand
        Dim opr_conexion As New Cls_Conexion
        Dim odbc_trans As SqlTransaction

        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)

        str_sql = "Update factura set FAC_ESTATUS = 2, fac_transaccion = '" & Fac_Transaccion & "' where FAC_ID = '" & fac_id & "'"
        odbc_strsql = New SqlCommand(str_sql, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        odbc_trans.Commit()
        opr_conexion.sql_desconn()

    End Function

    Public Function OperaFactura(ByVal pac_id As Integer, ByVal BOO_FLAG As Boolean, ByVal PED_ID() As Long, ByVal FAC_DOC As String, ByVal FAC_TIPODOC As Single, _
    ByVal FAC_FECING As Date, ByVal FAC_TOTAL As Double, ByVal FAC_DSCTO As Double, ByVal FAC_IVA As Single, _
    ByVal FAC_NOMBRE As String, ByVal FAC_APELLIDO As String, ByVal FAC_FONO As String, _
    ByVal FAC_DIRECCION As String, ByVal DET_FACTURA As DataTable, ByVal TXT_FACTURA As String, ByVal ObsContab As String, ByRef num_fac As String, Optional ByRef FAC_ID As String = "", _
    Optional ByVal OperaAbono As Boolean = False, Optional ByVal FAC_RECAR As Double = 0, Optional ByVal FAC_REFER As String = "", Optional ByVal FAC_FORMAPAGO As Short = 1, Optional ByVal FAC_TRANSACCION As String = "") As Integer
        'Procedimiento para actualizar o ingresar los datos de una factura
        On Error GoTo MsgError
        Dim STR_SQL, str_msg As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odbc_trans As SqlTransaction
        Dim odbc_strsql As SqlCommand
        Dim dts_factura As New DataSet()
        Dim int_indice As Integer
        Dim dtr_fila As DataRow
        OperaFactura = 1
        If BOO_FLAG Then        'Nuevas Factura
            If ExisteFactura(num_fac) Then
                num_fac = LeerMaxFactura()

                If MsgBox("Numero de Factura ya existente." & Chr(13) & "Se le asignara el No. " & num_fac & Chr(13) & _
                "Desea Continuar con el registro de la factura?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                    OperaFactura = 0
                    Exit Function
                End If
            End If
        End If
        opr_conexion.sql_conectar()
        odbc_trans = opr_conexion.conn_sql.BeginTransaction(IsolationLevel.ReadCommitted)
        'arreglo de pedidos a una cadena
        For int_indice = 0 To UBound(PED_ID) - 1
            str_msg = str_msg & PED_ID(int_indice) & ", "
        Next

        'Format(frm_formulario.Dtp_ped_fecing.Value, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss")
        str_msg = Mid(str_msg, 1, Len(str_msg) - 2)
        If BOO_FLAG Then
            STR_SQL = "Insert into Factura (FAC_ID, FAC_DOC, FAC_TIPODOC, FAC_FECING, " & _
            "FAC_TOTAL, FAC_IVA, FAC_DESCUENTO, FAC_NOMBRE, FAC_APELLIDO, FAC_FONO, FAC_DIRECCION,  " & _
            "FAC_ESTATUS, FAC_TEXTO, FAC_PEDIDOS, FAC_RECARGO, FAC_REFERENCIA, FAC_FORMAPAGO, FAC_TRANSACCION, ESTADO_FE, PAC_ID) Values ('" & _
            num_fac & "', '" & FAC_DOC & "', " & FAC_TIPODOC & ", '" & Format(FAC_FECING, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "', " & _
            CDbl(FAC_TOTAL) & ", " & FAC_IVA & ", " & CDbl(FAC_DSCTO) & ", '" & FAC_NOMBRE & "', '" & _
            FAC_APELLIDO & "', '" & FAC_FONO & "', '" & FAC_DIRECCION & "', 0, '" & TXT_FACTURA & "', '" & _
            str_msg & "', " & FAC_RECAR & ", '" & FAC_REFER & "', " & FAC_FORMAPAGO & ", '" & FAC_TRANSACCION & "', 0, " & PAC_ID & ")"
            str_msg = "Factura Registrada"
        Else
            STR_SQL = "Update Factura set " & _
            "FAC_DOC='" & FAC_DOC & "', " & _
            "FAC_TIPODOC=" & FAC_TIPODOC & ", " & _
            "FAC_FECING='" & Format(FAC_FECING, "dd/MM/yyyy ") & Format(Now, "HH:mm:ss") & "', " & _
            "FAC_TOTAL=" & CDbl(FAC_TOTAL) & ", " & _
            "FAC_IVA=" & FAC_IVA & ", " & _
            "FAC_DESCUENTO=" & CDbl(FAC_DSCTO) & ", " & _
            "FAC_NOMBRE='" & FAC_NOMBRE & "', " & _
            "FAC_APELLIDO='" & FAC_APELLIDO & "', " & _
            "FAC_FONO='" & FAC_FONO & "', " & _
            "FAC_DIRECCION='" & FAC_DIRECCION & "',  " & _
            "FAC_TEXTO='" & TXT_FACTURA & "', " & _
            "FAC_PEDIDOS='" & str_msg & "', " & _
            "FAC_RECARGO=" & FAC_RECAR & ",  " & _
            "FAC_REFERENCIA='" & ObsContab & "',  " & _
            "FAC_FORMAPAGO=" & FAC_FORMAPAGO & ", " & _
            "FAC_TRANSACCION='" & FAC_TRANSACCION & "' " & _
            "where FAC_ID='" & num_fac & "'"
            str_msg = "Factura Actualizada"
        End If
        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza FACTURA", "FACTURA=" & CStr(num_fac), g_sng_user, PED_ID(int_indice), "", "")
        'borra indistintamente el detalle de la factura
        STR_SQL = "Delete from Factura_Detalle where FAC_ID = '" & num_fac & "'"
        odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
        odbc_strsql.ExecuteNonQuery()
        For int_indice = 0 To DET_FACTURA.Rows.Count - 1
            dtr_fila = DET_FACTURA.Rows.Item(int_indice)
            'en la tabla que devuelve tenemos los valores en las columnas
            '0 --> Id del test      '1 --> tipo de test (P=perfil o T=test)
            '2 --> cantidad         '4 --> precio
            STR_SQL = "Insert into Factura_Detalle (FAD_ID, FAC_ID, FAD_CANTIDAD, FAD_PRECIO, TES_ID, FAD_TIPO) " & _
            "values (" & int_indice + 1 & ", '" & num_fac & "', " & dtr_fila(2) & ", " & CDbl(dtr_fila(4)) & ", " & dtr_fila(0) & ", '" & Mid(dtr_fila(1), 1, 1) & "')"
            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
        Next
        'ingresa solo si es nueva factura
        If BOO_FLAG Then
            'actualiza el numero de folio
            STR_SQL = "Update FOLIO set FOL_NUM = " & CLng(num_fac) & " where FOL_ID = 1"
            odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
            odbc_strsql.ExecuteNonQuery()
            'actualiza la factura por pedido
            For int_indice = 0 To UBound(PED_ID) - 1
                STR_SQL = "Update PEDIDO set FAC_ID = '" & num_fac & "', PED_FAC_ESTADO = 1  where PED_ID = " & PED_ID(int_indice) & ""
                odbc_strsql = New SqlCommand(STR_SQL, opr_conexion.conn_sql, odbc_trans)
                odbc_strsql.ExecuteNonQuery()
                g_opr_usuario.CargarTransaccion(g_str_login, "Ingresa FACTURA", "FACTURA=" & CStr(num_fac), g_sng_user, PED_ID(int_indice), "", "")
            Next
        End If
        odbc_trans.Commit()
        opr_conexion.sql_desconn()
        FAC_ID = num_fac
        g_lng_ped_nunfact = num_fac

        If Not OperaAbono Then MsgBox(str_msg, MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Insercion de Facturas", Err)
        OperaFactura = 0
        odbc_trans.Rollback()
        opr_conexion.sql_desconn()
        Err.Clear()
    End Function


    Public Function OperaAbono(ByVal FAC_ID As String, ByVal ABO_FECING As Date, ByVal ABO_MONTO As Double, ByVal ABO_REFER As String, ByVal Cancela As Integer) As Short
        'Procedimiento para ingresar los datos de un abono
        On Error GoTo MsgError
        Dim STR_SQL As String
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        Dim Str_letras As String = Nothing

        Str_letras = Letras(CStr(ABO_MONTO))

        OperaAbono = 1      'ok proceso
        opr_conexion.sql_conectar()
        STR_SQL = "Insert into Abono (FAC_ID, ABO_ID, ABO_FECING, ABO_MONTO, ABO_REFER) values ('" & _
        FAC_ID & "', " & LeerMaxAbono(FAC_ID) + 1 & ", '" & ABO_FECING & "', " & ABO_MONTO & ", '" & ABO_REFER & "')"
        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        g_opr_usuario.CargarTransaccion(g_str_login, "Insertar abono", "Factura=" & FAC_ID & " Abono= " & ABO_MONTO, g_sng_user, "", "", "")
        'se actualiza el estado de la factura
        'cancela 0 emitido, 1 abonada, 2 cancelada, 3 anulada
        STR_SQL = "Update FACTURA set FAC_ESTATUS = " & Cancela & ", FAC_LETRAS = '" & Str_letras & "' where FAC_ID = '" & FAC_ID & "'"
        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        If Cancela = 2 Then
            g_opr_usuario.CargarTransaccion(g_str_login, "Cancela FACTURA", "FACTURA=" & FAC_ID, g_sng_user, g_lng_ped_id, "", "")
        Else
            g_opr_usuario.CargarTransaccion(g_str_login, "Actualiza FACTURA", "FACTURA=" & FAC_ID & "/" & ABO_MONTO, g_sng_user, g_lng_ped_id, "", "")
        End If
        opr_conexion.sql_desconn()


        MsgBox("Datos Registrados", MsgBoxStyle.Information, "ANALISYS")
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Insertar abono", Err)
        Err.Clear()
        OperaAbono = 0      'bad proceso
    End Function


    Public Function OperaFacturaTransaccion(ByVal fac_id As Long, ByVal fac_transaccion As String, ByVal fac_fecing As Date) As Boolean
        On Error GoTo MsgError

        Dim str_sql As String = Nothing
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand

        str_sql = "Update Factura set " & _
        "FAC_FECING ='" & fac_fecing & "', " & _
        "FAC_TRANSACCION ='" & fac_transaccion & "' " & _
        "where FAC_ID='" & fac_id & "'"

        opr_conexion.sql_conectar()
        odc_operacion = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()

        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Registra Tx Factura", "Factura=" & fac_id, g_sng_user, "", "", "")
        'MsgBox("Transaccion efectuada.", MsgBoxStyle.Information, "ANALISYS")

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Registra transaccion factura ", Err)

        Err.Clear()
    End Function



    Sub AnularFactura(ByVal FAC_ID As String)
        'Procedimiento para anular una factura especifica
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim odc_operacion As SqlCommand
        Dim STR_SQL As String
        'la relaci�n entre las tablas factura y pedidos no debe exigir integridad referencial
        opr_conexion.sql_conectar()
        'Anula la factura pero su detalle y abonos si existieran queda vigentes
        STR_SQL = "Update Factura set FAC_ESTATUS = 3 where FAC_ID = '" & FAC_ID & "'"
        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        'Actualiza el estado = 0 (no tiene factura) y blanquea el numero de factura 
        'en el o los pedidos donde se encuentre
        STR_SQL = "Update Pedido set FAC_ID = '', PED_FAC_ESTADO=0 where FAC_ID='" & FAC_ID & "'"
        odc_operacion = New SqlCommand(STR_SQL, opr_conexion.conn_sql)
        odc_operacion.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        g_opr_usuario.CargarTransaccion(g_str_login, "Anular Factura", "Factura=" & FAC_ID, g_sng_user, "", "", "")
        MsgBox("Factura Anulada", MsgBoxStyle.Information, "ANALISYS")

        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, anular factura", Err)
        Err.Clear()
    End Sub


    Public Function Obtiene_dato_abono_factura(ByVal str_sql As String, ByVal numfact As Long, ByRef dts_registro As DataSet)
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dtr_fila As DataRow
        Dim dbl_sumabono As Double = 0
        Dim int_indice, int_indice2 As Integer

        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_registro, "Registros")
        'XXX CORREGIR ERROR AL SELECCIONAR EL DATO DE LA ULTIMA FACTURA
        dts_registro.Tables(0).Columns.Add("SUM_ABO")

        If "Factura" = "Factura" Then
            str_sql = "select FAC_ID, round(sum(ABO_MONTO),2) FROM ABONO where FAC_ID = '" & numfact & "' group by FAC_ID"
            oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
            oda_operacion.Fill(dts_registro, "Registros2")
            If dts_registro.Tables("Registros2").Rows.Count > 0 Then
                dtr_fila = dts_registro.Tables("Registros2").Rows(int_indice)
                'se llena toda la columna con el dato de la suma de abonos
                If Not IsDBNull(dtr_fila(1)) Then dbl_sumabono = dtr_fila(1)
            End If

            For int_indice = 0 To dts_registro.Tables(0).Rows.Count - 1
                dts_registro.Tables(0).Rows(int_indice).Item("SUM_ABO") = Round(CDbl(dbl_sumabono), 2)
            Next

        Else
            If dts_registro.Tables(0).Rows.Count > 0 Then
                For int_indice = 0 To dts_registro.Tables(0).Rows.Count - 1
                    str_sql = "select FAC_ID, sum(ABO_MONTO) FROM ABONO where FAC_ID = '" & dts_registro.Tables(0).Rows(int_indice).Item(0) & "' group by FAC_ID"
                    oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
                    oda_operacion.Fill(dts_registro, "Registros2")
                    dbl_sumabono = 0
                    If dts_registro.Tables("Registros2").Rows.Count > 0 Then
                        dtr_fila = dts_registro.Tables("Registros2").Rows(int_indice)
                        'se llena toda la columna con el dato de la suma de abonos
                        If Not IsDBNull(dtr_fila(1)) Then dbl_sumabono = dtr_fila(1)
                    End If
                    For int_indice2 = 0 To dts_registro.Tables(0).Rows.Count - 1
                        If dts_registro.Tables(0).Rows(int_indice).Item(0) = dts_registro.Tables(0).Rows(int_indice2).Item(0) Then
                            dts_registro.Tables(0).Rows(int_indice).Item("SUM_ABO") = dbl_sumabono
                        End If
                    Next
                Next
            End If

        End If
        opr_Conexion.sql_desconn()
    End Function


    Public Function Obtiene_dato_factura(ByVal str_sql As String, ByRef dts_registro As DataSet)
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()


        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_registro, "Registros")

        opr_Conexion.sql_desconn()
    End Function


    Public Function ConsultaOrdenFactura(ByVal fecha As Date, ByRef cmb_Orden As ComboBox, ByVal g_numOrden As String)
        Dim opr_factura = New Cls_Factura
        Dim str_crea, str_sql As String
        Dim dts_registro As New DataSet
        Dim numfact As String = g_lng_ped_nunfact
        Dim obj_reporte As Object
        str_crea = ""
        Dim FechaIni, FechaFin As Date
        Dim indice As Integer = 0
        FechaFin = fecha
        FechaIni = Format(Now, ("yyyy-MM") & "-01")
        cmb_Orden.Enabled = False

        If g_numOrden = Nothing Or g_numOrden = "0" Then
            str_sql = "select PEDIDO.PED_FECING, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
                "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno,  " & _
                "PEDIDO.PED_ID " & _
                "from PEDIDO " & _
            "where PEDIDO.PED_FECING BETWEEN '" & Format(FechaIni, "dd/MM/yyyy") & " 00:00:00' AND '" & Format(FechaFin, "dd/MM/yyyy") & " 23:56:59' " & _
            "AND PEDIDO.PED_ESTADO <> 2 " & _
            "ORDER BY PEDIDO.PED_TURNO;"

            Call LlenarComboOrden(str_sql, cmb_Orden, g_numOrden, indice)
            cmb_Orden.SelectedIndex = indice
            cmb_Orden.Enabled = True
            g_numOrden = ""
        Else
            str_sql = "select PEDIDO.PED_FECING, (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),4,2) + (SUBSTRING(convert(char(10),PEDIDO.PED_FECING,103),1,2) )+ " & _
               "case when len(PEDIDO.PED_TURNO) = 1 then('0000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 2 then('000' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 3 then('00' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 4 then('0' + convert(varchar(100),PEDIDO.PED_TURNO)) " & _
                 "when len(PEDIDO.PED_TURNO) = 5 then(convert(varchar(100),PEDIDO.PED_TURNO)) end ) as ped_turno,  " & _
                "PEDIDO.PED_ID " & _
                "from PEDIDO " & _
            "where PEDIDO.PED_FECING BETWEEN '" & Format(FechaFin, "dd/MM/yyyy") & " 00:00:00' AND '" & Format(FechaFin, "dd/MM/yyyy") & " 23:56:59' " & _
            "AND PEDIDO.PED_ESTADO <> 2 and PEDIDO.PED_ID = '" & g_numOrden & "' " & _
            "ORDER BY PEDIDO.PED_TURNO;"

            Call LlenarComboOrden(str_sql, cmb_Orden, g_numOrden, indice)
            cmb_Orden.SelectedIndex = 0
            g_numOrden = ""
        End If

        str_sql = ""

    End Function


    Public Function ConsultaFechaOrden(ByVal g_numOrden As String) As String
            Dim opr_factura = New Cls_Factura
            Dim str_sql As String
            Dim cls_operacion As New Cls_Conexion()

            If g_numOrden = Nothing Or g_numOrden = "0" Then
                str_sql = "select PEDIDO.PED_FECING " & _
                        "from PEDIDO " & _
                        "where PEDIDO.PED_ESTADO <> 2 and PEDIDO.PED_ID = '" & g_numOrden & "'" & _
                        "ORDER BY PEDIDO.PED_TURNO;"

            Else
                str_sql = "select PEDIDO.PED_FECING " & _
                    "from PEDIDO " & _
                    "where PEDIDO.PED_ESTADO <> 2 and PEDIDO.PED_ID = '" & g_numOrden & "' " & _
                    "ORDER BY PEDIDO.PED_TURNO;"

            End If

            cls_operacion.sql_conectar()
            Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader

            While odr_operacion.Read
                ConsultaFechaOrden = odr_operacion.GetValue(0).ToString()
            End While
            odr_operacion.Close()
            cls_operacion.sql_desconn()

            str_sql = ""
            g_numOrden = ""

    End Function


    Sub LlenarComboOrden(ByVal str_sql As String, ByRef cmb_orden As ComboBox, ByVal g_numOrden As String, ByRef indice As Integer)
            On Error GoTo msgerr
            'Para llenar el combo con los datos de un medico        
            Dim cls_operacion As New Cls_Conexion()
            cls_operacion.sql_conectar()
            Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, cls_operacion.conn_sql).ExecuteReader
            cmb_Orden.Items.Clear()
            While odr_operacion.Read
                cmb_Orden.Items.Add(odr_operacion.GetString(1).ToString().PadRight(20) & odr_operacion.GetValue(2).ToString().PadRight(20))
            End While
            odr_operacion.Close()
            cls_operacion.sql_desconn()
            If g_numOrden = Nothing Then
                indice = cmb_Orden.Items.Count - 1
            Else
                indice = 0
            End If
msgerr:
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, llena combo Orden", Err)
            Err.Clear()
    End Sub

End Class