'*************************************************************************
' Nombre:   cls_AS400
' Tipo de Archivo: Clase
' Descripción:  Clase que contiene funciones que operan con el AS400
' Autores:  RFN
' Fecha de Creación: Diciembre del 2005
' Autores Modificaciones: Jorge Paz, Andres Toledo
' Ultima Modificación: 21/12/2005
' Proyecto TRUESOLUTIONS
'*************************************************************************
Imports System
Imports System.Data
'Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports IBM.Data
Imports IBM.Data.DB2.iSeries
Imports Microsoft.Data.Odbc
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports Microsoft.VisualBasic

Public Class Cls_AS400
    Inherits System.Windows.Forms.Form

    Dim k As Integer = 0

    '    Public Function CountRegistros(ByVal STR_SQL As String) As Integer
    '        'Devuelve el numero de registros del archivo MISDTL
    '        On Error GoTo MsgError
    '        Dim opr_Conexion As New Cls_conexas400()
    '        Dim olector As OleDb.OleDbDataReader
    '        opr_Conexion.ConectarAS()
    '        olector = opr_Conexion.EjecutaEnAS400(STR_SQL)
    '        If olector.Read Then
    '            CountRegistros = CType(olector.GetValue(0), Integer)
    '        End If
    '        opr_Conexion.desconectarAS()
    '        Exit Function
    'MsgError:
    '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, CountRegistros", Err)
    '        Err.Clear()
    '    End Function

    '    Public Function LeerOrdenMIS(ByVal STR_SQL As String) As DataSet
    '        'Devuelve todos los registros de la tabla MISDTL que coincidan con la orden ingresada.
    '        On Error GoTo MsgError
    '        Dim opr_Conexion As New Cls_conexas400()
    '        Dim oda_operacion As oledbDataAdapter = New oledbDataAdapter()
    '        opr_Conexion.ConectarAS()
    '        oda_operacion.SelectCommand = New OledbCommand("SELECT DLNUOR,DLNFECI,DLHIST,DLAPEL,DLNOMB,DLSEXO,DLFECN,DLCODM,DLCODS,DLCEDU,DLPROV,DLSALA,DLCAMA,DLCEXA FROM " & g_ASLibreria & ".MISDTL ORDER BY DLCEXA", opr_Conexion.Conn_BD)
    '        LeerOrdenMIS = New DataSet()
    '        oda_operacion.Fill(LeerOrdenMIS, "Registros")
    '        opr_Conexion.desconectarAS()
    '        Exit Function
    'MsgError:
    '        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Orden MIS", Err)
    '        Err.Clear()
    '    End Function


    '**********************
    'FUNCIONES PARA SQL SERVER QUE SON BASE DE LA PROGRAMACION PARA LUEGO PASARLAS A AS400

    Public Function countregistrosSQL(ByVal orden As String) As Long
        Dim ocon As iDB2Connection
        'Dim str_sql As String = "Select count(*) from " & g_ASLibreria & ".MISDTL WHERE DLNUOR = " & orden & ""
        Dim str_sql As String = "Select count(*) from " & g_ASLibreria & ".MISDTL WHERE DLNUOR = " & orden & ""
        Try
            ocon = New iDB2Connection(g_str_idb2)
            ocon.Open()
            Dim odr_operacion As iDB2DataReader = New iDB2Command(str_sql, ocon).ExecuteReader
            While odr_operacion.Read
                countregistrosSQL = odr_operacion.GetValue(0).ToString()
            End While
            odr_operacion.Close()
        Catch
            existe_error = True
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ocon.Close()
        End Try
    End Function



    Public Function countregistrosDTLMIS(ByVal orden As String, ByVal turno As String) As Long
        Dim ocon As iDB2Connection
        Dim str_sql As String = "Select count(*) from " & g_ASLibreria & ".DTLMIS WHERE DLNUOR = " & orden & " and DLORLA = " & turno & ""
        Try
            ocon = New iDB2Connection(g_str_idb2)
            ocon.Open()
            Dim odr_operacion As iDB2DataReader = New iDB2Command(str_sql, ocon).ExecuteReader
            While odr_operacion.Read
                countregistrosDTLMIS = odr_operacion.GetValue(0).ToString()
            End While
            odr_operacion.Close()
        Catch
            existe_error = True
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ocon.Close()
        End Try
    End Function

    Public Function LeerOrdenMISSQL(ByVal orden As String) As DataSet
        'Devuelve todos los registros de la tabla MISDTL que coincidan con la orden ingresada.
        Dim ocon As iDB2Connection
        Dim oda_menu As iDB2DataAdapter = New iDB2DataAdapter()
        Try
            ocon = New iDB2Connection(g_str_idb2)
            ocon.Open()
            'Dim str_sql As String = "SELECT DLNUOR,DLFECI,DLHIST,DLAPEL,DLNOMB,DLSEXO,DLFECN,DLCMED,DLSER,DLCEDU,DLPROV,DLSALA,DLCAMA,(rtrim(DLRESE) || rtrim(DLCEXA)) as DLCEXA,DLTIPA FROM " & g_ASLibreria & ".MISDTL WHERE DLNUOR =  " & orden & " and DLFEAM = 0"
            'Dim str_sql As String = "SELECT DLNUOR,DLFECI,DLHIST,DLAPEL,DLNOMB,DLSEXO,DLFECN,DLCMED,DLSER,DLCEDU, DLCEXA, DLTIPA FROM " & g_ASLibreria & ".MISDTL WHERE DLNUOR =  " & orden & " and DLFEAM = 0"
            Dim str_sql As String = "SELECT * FROM " & g_ASLibreria & ".MISDTL WHERE DLNUOR =  " & orden & " and DLFEAM = 0"
            oda_menu.SelectCommand = New iDB2Command(str_sql, ocon)
            LeerOrdenMISSQL = New DataSet()
            oda_menu.Fill(LeerOrdenMISSQL, "Registros")
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ocon.Close()
        End Try
    End Function

    Public Function NombrePruebaSQL(ByVal codigo As String) As String
        'Devuelve el nombre de la prueba solicitada por el código
        'Funcion para la consultar los datos de la tabla EQUIPOS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        NombrePruebaSQL = "0"
        Select Case Trim(codigo)
            Case "2002001", "2002002", "2002003", "2002004", "2002005", "2002006", "2002007", "2002008", "2002009", "2002010", "2002011", "2002015", "2002018", "2002021", "2002024", "2002027", "2002029", "2002030", "2002033", "2002036"
                Exit Function
            Case "2002012"
                codigo = "200"
                'orina examen general
            Case "5005015", "5005020", "5005025", "5005030", "5005035", "5005040", "5005045", "5005050", "5005055", "5005060", "5005065", "5005070", "5005075", "5005085", "5005087", "5005090", "5005095", "5005100", "5005105", "5005080"
                Exit Function
            Case "5005010"
                codigo = "500"
                'reaccion widal
            Case "4004045", "4004050", "4004055", "4004060", "4004065"
                Exit Function
            Case "4004040"
                codigo = "400"
                'para la prueba especial de gases arteriales
            Case "7008202", "7008204", "7008206", "7008208", "7008210", "7008212"
                Exit Function
            Case "7008200"
                codigo = "700"
                'para la prueba especial de gases venosos
            Case "7108302", "7108304", "7108306", "7108308", "7108310", "7108312"
                Exit Function
            Case "7108300"
                codigo = "710"
                'para la prueba especial de electrolitos(sodio, potasio, cloro)
            Case "1401172", "1401181"
                Exit Function
            Case "1401188"
                codigo = "140"
                'para la prueba especial de aclaramiento de creatinina
            Case "1801045", "1801239"
                Exit Function
            Case "1801054"
                codigo = "180"
                'PARA LA PRUEBA DE CITOLOGIA DE MOCO FECAL
            Case "6056045", "6056046", "6056048"
                Exit Function
            Case "6056047"
                codigo = "605"
                'para la prueba de citologia de moco nasal
            Case "2702007", "2702008"
                Exit Function
            Case "2702010"
                codigo = "270"
                'para la prueba de citologico citoquimico
            Case "8001001", "8001112", "8002007", "8002008", "8002010", "8005085", "8005087", "8008083", "8008084", "8008086", "8008087", "8008088", "8008120", "8008130" 'revisar las dos ultimas
                Exit Function
            Case "8008085"
                codigo = "800"
        End Select
        'para el caso de que se este importando una prueba de biometria hematica
        'If codigo = "2001" Or codigo = "2002" Or codigo = "2003" Or codigo = "2004" Or codigo = "2005" Or codigo = "2006" Or codigo = "2007" Or codigo = "2008" Or codigo = "2009" Or codigo = "2010" Or codigo = "2011" Or codigo = "2015" Or codigo = "2018" Or codigo = "2021" Or codigo = "2024" Or codigo = "2027" Or codigo = "2029" Or codigo = "2030" Or codigo = "2033" Or codigo = "2036" Then
        '    Exit Function
        'End If
        'If codigo = "2012" Then
        '    codigo = "200"
        'End If
        'para el caso de que se este importando una prueba de orina examen general
        'If codigo = "5015" Or codigo = "5020" Or codigo = "5025" Or codigo = "5030" Or codigo = "5035" Or codigo = "5040" Or codigo = "5045" Or codigo = "5050" Or codigo = "5055" Or codigo = "5060" Or codigo = "5065" Or codigo = "5070" Or codigo = "5075" Or codigo = "5080" Or codigo = "5085" Or codigo = "5090" Or codigo = "5095" Or codigo = "5100" Or codigo = "5105" Then
        '    Exit Function
        'End If
        'If codigo = "5010" Then
        '    codigo = "500"
        'End If
        codigo = RTrim(codigo)
        codigo = LTrim(codigo)

        STR_SQL = "SELECT TES_NOMBRE FROM TEST WHERE TES_OBS = '" & codigo & "';"
        opr_Conexion.conectar()
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            NombrePruebaSQL = oda_operacion.GetValue(0).ToString
        End While
        oda_operacion.Close()
        opr_Conexion.desconectar()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Desc. Test", Err)
        Err.Clear()
    End Function

    'funcion mejorada para para la consulta de nombre de test en 
    Public Function NombrePruebaSQL2(ByVal codigo As String) As String
        'Devuelve el nombre de la prueba solicitada por el código
        Try
            Dim opr_Conexion As New Cls_Conexion()
            Dim STR_SQL As String
            If codigo_temp <> codigo Then
                STR_SQL = "SELECT TES_NOMBRE FROM TEST WHERE TES_ID = " & codigo & ";"
                opr_Conexion.conectar()
                Dim oda_operacion As OleDbDataReader = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
                While oda_operacion.Read
                    NombrePruebaSQL2 = oda_operacion.GetValue(0).ToString
                End While
                oda_operacion.Close()
                opr_Conexion.desconectar()
            Else
                codigo_temp = codigo
            End If
            Exit Function
        Catch
            g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Desc. Test", Err)
            Err.Clear()
        End Try
    End Function


    Public Function existePacienteHC(ByVal HC As String) As Integer
        'Devuelve 0 si no existe esa historia Clinica  o devuelve el pac_id en caso de si encontrarlo. 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.conectar()
        Dim str_sql As String = "Select COUNT(PAC_ID) from PACIENTE WHERE PAC_DOC = '" & HC & "' AND PAC_MIS = 'V';"
        existePacienteHC = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        If existePacienteHC > 0 Then
            str_sql = "Select PAC_ID from PACIENTE WHERE PAC_DOC = '" & HC & "' AND PAC_MIS = 'V';"
            existePacienteHC = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        End If
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, CountRegistros", Err)
        Err.Clear()
    End Function

    Public Function ActualizaDatosPacienteHC(ByVal HC As String, Optional ByVal apellidos As String = "N/N", Optional ByVal nombres As String = "N/N")
        Dim opr_conexion As New Cls_Conexion()
        Dim oDa As New OleDbDataAdapter()
        Dim ds As DataSet
        Dim str_sql As String
        Dim sql_trans As OleDbTransaction

        Try
            str_sql = "select * from paciente where pac_hist_clinica='" & HC & "' "
            opr_conexion.conectar()
            oDa.SelectCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
            ds = New DataSet()
            oDa.Fill(ds, "Datos")
            opr_conexion.desconectar()

            Dim contador As Short = 0
            Dim ape As String
            Dim nom As String
            Dim dtr_filax As DataRow
            For Each dtr_filax In ds.Tables("Datos").Rows
                If contador = 0 Then
                    nom = Trim(dtr_filax("pac_nombre").ToString)
                    ape = Trim(dtr_filax("pac_apellido").ToString)
                End If
            Next

            Dim boo_flag_n As Boolean = False
            Dim boo_flag_a As Boolean = False
            If nom <> nombres Then
                boo_flag_n = True
            Else
                boo_flag_n = False
            End If
            If ape <> apellidos Then
                boo_flag_a = True
            Else
                boo_flag_a = False
            End If

            If boo_flag_n = True Or boo_flag_a = True Then
                Dim str_sql1 As String
                Dim odc As New OleDbCommand()
                str_sql1 = "update paciente set pac_apellido='" & Trim(apellidos) & "', pac_nombre='" & Trim(nombres) & "', pac_mis = 'V' where pac_hist_clinica='" & HC & "' "
                opr_conexion.conectar()
                sql_trans = opr_conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                odc = New OleDbCommand(str_sql1, opr_conexion.Conn_BD, sql_trans)
                odc.ExecuteNonQuery()
                sql_trans.Commit()
            End If
            ds.Reset()
        Catch
            sql_trans.Rollback()
            MsgBox(Err.Description)
            MsgBox("No se pudo realizar la actualizacion de los datos del paciente. ActualizaDatosPacienteHC ", MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            opr_conexion.desconectar()
        End Try
    End Function

    Public Function InsertPacienteSQL(ByVal cedula As String, ByVal apellidos As String, ByVal nombres As String, ByVal sexo As Char, ByVal fecnac As String, ByVal HC As String, ByVal tipo As String) As Integer
        'inserta un nuevo registro en la tabla PACIENTE, con la informacion que se tiene y devuelve el pac_id insertado, 
        Dim opr_sis As New Cls_sistema()
        Dim opr_Conexion As New Cls_Conexion()
        Dim pac_id As Integer = 0
        Dim fecha_nac As Date
        Dim str_cedula, str_tipo As String
        Dim byt_tipodoc, byt_usafecnac As Byte
        Dim sql_trans As OleDbTransaction
        Dim str_sql As String = ""
        Try
            opr_Conexion.odbc_conn()
            str_sql = "Select max(PAC_ID) from PACIENTE;"
            pac_id = CInt(New OdbcCommand(str_sql, opr_Conexion.conn_odbc).ExecuteScalar)
            pac_id = pac_id + 1
            opr_Conexion.odbc_desconn()

            If Len(Trim(cedula)) = 10 Then  'tiene numero de cedula
                byt_tipodoc = 1
                str_cedula = cedula
            Else
                byt_tipodoc = 0
                str_cedula = ""
            End If


            If Len(fecnac) = 8 Then
                byt_usafecnac = 1
                fecha_nac = Mid(fecnac, 1, 4) & "-" & Mid(fecnac, 5, 2) & "-" & Mid(fecnac, 7, 2)

            Else
                'NO TIENE FECHA DE NACIMIENTO
                byt_usafecnac = 0
                fecha_nac = Format(Now, "yyyy-MM-dd hh:mm:ss")
            End If
            opr_Conexion.conectar()
            'sql_trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
            str_sql = "Insert into paciente (pac_id, ciu_id, pac_doc, pac_tipodoc, pac_apellido, pac_nombre, pac_sexo, pac_fecnac, pac_fecing, pac_hist_clinica,pac_usafecnac, pac_grado,pac_mis) " & _
            "values (" & pac_id & ", 1, '" & Trim(str_cedula) & "'," & byt_tipodoc & ", '" & Trim(apellidos) & "', '" & Trim(nombres) & "','" & sexo & "' , '" & fecha_nac & "', '" & Format(Now, "yyyy-MM-dd hh:mm:ss") & " ', '" & HC & "', " & byt_usafecnac & ", '" & tipo & "', 'V');"
            Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
            odc_pedido.ExecuteNonQuery()
            InsertPacienteSQL = pac_id
            'sql_trans.Commit()
        Catch
            'sql_trans.Rollback()
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, InsertPacienteSQL", Err)
            Err.Clear()
        Finally
            opr_Conexion.desconectar()
        End Try
    End Function

    Public Function existeMEDICO(ByVal DLCODM As Integer) As Integer
        'Devuelve 0 si no existe esa registros con ese codigo de medico o devuelve el med_id en caso de si encontrarlo. 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.conectar()
        Dim str_sql As String = "Select IfNULL(COUNT(MED_ID),'0') from MEDICO WHERE MED_ID = " & DLCODM & ";"
        existeMEDICO = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, CountRegistros", Err)
        Err.Clear()
    End Function


    Public Function InsertPedido(ByVal pac_id As Integer, ByVal med_id As Integer, ByVal turno As Integer, ByVal sal_id As Integer, ByVal orden As Integer) As Integer
        'inserta un nuevo registro en la tabla PEDIDO, con la informacion que se tiene y devuelve el PED_ID insertado, 
        'PED_ID,'PAC_ID,'MED_ID,'PED_FECING,'PED_ANTECEDENTE,'PED_MEDICACION,'PED_TIPO
        'PED_ESTADO,'CON_NOMBRE,'FAC_ID,'PED_FAC_ESTADO,'LAB_ID,'PED_NOTA,'PED_TURNO
        'SAL_ID,'PED_ORDEN
        Dim opr_sis As New Cls_sistema()
        Dim opr_Conexion As New Cls_Conexion()
        Dim sql_trans As OleDbTransaction
        Dim ped_id As Integer
        Dim str_sql As String = "Select IFNULL(max(PED_ID),'0') from PEDIDO;"

        Try
            opr_Conexion.odbc_conn()
            ped_id = CInt(New OdbcCommand(str_sql, opr_Conexion.conn_odbc).ExecuteScalar)
            ped_id = ped_id + 1
            opr_Conexion.odbc_desconn()
            opr_Conexion.conectar()
            str_sql = "Insert into pedido (ped_id, pac_id, med_id, ped_fecing,ped_tipo, ped_estado, con_nombre, lab_id,ped_turno,ped_servicio,ped_recibo) " & _
            "values (" & ped_id & ", " & pac_id & ", " & med_id & ", '" & Format(Now, "yyyy-MM-dd HH:mm") & "', 'NORMAL',0,'HJCA',1," & turno & ", " & sal_id & ", " & orden & ");"
            Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
            odc_pedido.ExecuteNonQuery()
            InsertPedido = ped_id

        Catch

            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, InsertPacienteSQL", Err)
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            opr_Conexion.desconectar()
        End Try
    End Function

    Public Sub InsertPedidoDetalle(ByVal pee_id As Short, ByVal ped_id As Integer, ByVal tes_id As Integer, ByRef ocon As OleDbConnection)
        'inserta un nuevo registro en la tabla PEDIDO_detalle, con la informacion que se tiene 
        'PEE_ID
        'PEE_CANTIDAD
        'PED_ID
        'TES_ID
        'PER_ID        
        Dim opr_sis As New Cls_sistema()
        Dim str_sql As String = ""
        Dim conexion As OleDbConnection
        conexion = ocon

        Try
            If conexion.State = ConnectionState.Open Then
                If tes_id = 400 Or tes_id = 700 Or tes_id = 710 Or tes_id = 140 Or tes_id = 180 Or tes_id = 500 Or tes_id = 605 Or tes_id = 270 Or tes_id = 800 Then
                    Select Case tes_id
                        Case 400
                            Dim str_sql1 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 21 & ", 1, " & ped_id & ", " & 4004040 & ");"
                            Dim str_sql2 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 22 & ", 1, " & ped_id & ", " & 4004045 & ");"
                            Dim str_sql3 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 23 & ", 1, " & ped_id & ", " & 4004050 & ");"
                            Dim str_sql4 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 24 & ", 1, " & ped_id & ", " & 4004055 & ");"
                            Dim oComando1 As OleDbCommand = New OleDbCommand(str_sql1, ocon)
                            Dim oComando2 As OleDbCommand = New OleDbCommand(str_sql2, ocon)
                            Dim oComando3 As OleDbCommand = New OleDbCommand(str_sql3, ocon)
                            Dim oComando4 As OleDbCommand = New OleDbCommand(str_sql4, ocon)
                            oComando1.ExecuteNonQuery()
                            oComando2.ExecuteNonQuery()
                            oComando3.ExecuteNonQuery()
                            oComando4.ExecuteNonQuery()

                        Case 700
                            Dim str_sql7 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 41 & ", 1, " & ped_id & ", " & 7008200 & ");"
                            Dim str_sql8 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 42 & ", 1, " & ped_id & ", " & 7008202 & ");"
                            Dim str_sql9 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 43 & ", 1, " & ped_id & ", " & 7008204 & ");"
                            Dim str_sql10 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 44 & ", 1, " & ped_id & ", " & 7008206 & ");"
                            Dim str_sql11 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 45 & ", 1, " & ped_id & ", " & 7008208 & ");"
                            Dim str_sql12 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 46 & ", 1, " & ped_id & ", " & 7008210 & ");"
                            Dim str_sql13 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 47 & ", 1, " & ped_id & ", " & 7008212 & ");"
                            Dim oComando7 As OleDbCommand = New OleDbCommand(str_sql7, ocon)
                            Dim oComando8 As OleDbCommand = New OleDbCommand(str_sql8, ocon)
                            Dim oComando9 As OleDbCommand = New OleDbCommand(str_sql9, ocon)
                            Dim oComando10 As OleDbCommand = New OleDbCommand(str_sql10, ocon)
                            Dim oComando11 As OleDbCommand = New OleDbCommand(str_sql11, ocon)
                            Dim oComando12 As OleDbCommand = New OleDbCommand(str_sql12, ocon)
                            Dim oComando13 As OleDbCommand = New OleDbCommand(str_sql13, ocon)
                            oComando7.ExecuteNonQuery()
                            oComando8.ExecuteNonQuery()
                            oComando9.ExecuteNonQuery()
                            oComando10.ExecuteNonQuery()
                            oComando11.ExecuteNonQuery()
                            oComando12.ExecuteNonQuery()
                            oComando13.ExecuteNonQuery()

                        Case 710
                            Dim str_sql14 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 61 & ", 1, " & ped_id & ", " & 7108300 & ");"
                            Dim str_sql15 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 62 & ", 1, " & ped_id & ", " & 7108302 & ");"
                            Dim str_sql16 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 63 & ", 1, " & ped_id & ", " & 7108304 & ");"
                            Dim str_sql17 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 64 & ", 1, " & ped_id & ", " & 7108306 & ");"
                            Dim str_sql18 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 65 & ", 1, " & ped_id & ", " & 7108308 & ");"
                            Dim str_sql19 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 66 & ", 1, " & ped_id & ", " & 7108310 & ");"
                            Dim str_sql20 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 67 & ", 1, " & ped_id & ", " & 7108312 & ");"
                            Dim oComando14 As OleDbCommand = New OleDbCommand(str_sql14, ocon)
                            Dim oComando15 As OleDbCommand = New OleDbCommand(str_sql15, ocon)
                            Dim oComando16 As OleDbCommand = New OleDbCommand(str_sql16, ocon)
                            Dim oComando17 As OleDbCommand = New OleDbCommand(str_sql17, ocon)
                            Dim oComando18 As OleDbCommand = New OleDbCommand(str_sql18, ocon)
                            Dim oComando19 As OleDbCommand = New OleDbCommand(str_sql19, ocon)
                            Dim oComando20 As OleDbCommand = New OleDbCommand(str_sql20, ocon)
                            oComando14.ExecuteNonQuery()
                            oComando15.ExecuteNonQuery()
                            oComando16.ExecuteNonQuery()
                            oComando17.ExecuteNonQuery()
                            oComando18.ExecuteNonQuery()
                            oComando19.ExecuteNonQuery()
                            oComando20.ExecuteNonQuery()

                        Case 140
                            Dim str_sql21 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 81 & ", 1, " & ped_id & ", " & 1401172 & ");"
                            Dim str_sql22 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 82 & ", 1, " & ped_id & ", " & 1401181 & ");"
                            Dim str_sql23 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 83 & ", 1, " & ped_id & ", " & 1401188 & ");"
                            Dim oComando21 As OleDbCommand = New OleDbCommand(str_sql21, ocon)
                            Dim oComando22 As OleDbCommand = New OleDbCommand(str_sql22, ocon)
                            Dim oComando23 As OleDbCommand = New OleDbCommand(str_sql23, ocon)
                            oComando21.ExecuteNonQuery()
                            oComando22.ExecuteNonQuery()
                            oComando23.ExecuteNonQuery()

                        Case 180
                            Dim str_sql24 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 101 & ", 1, " & ped_id & ", " & 1801045 & ");"
                            Dim str_sql25 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 102 & ", 1, " & ped_id & ", " & 1801054 & ");"
                            Dim str_sql26 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 103 & ", 1, " & ped_id & ", " & 1801239 & ");"
                            Dim oComando24 As OleDbCommand = New OleDbCommand(str_sql24, ocon)
                            Dim oComando25 As OleDbCommand = New OleDbCommand(str_sql25, ocon)
                            Dim oComando26 As OleDbCommand = New OleDbCommand(str_sql26, ocon)
                            oComando24.ExecuteNonQuery()
                            oComando25.ExecuteNonQuery()
                            oComando26.ExecuteNonQuery()

                        Case 500
                            '-----------------05/10/2008--------------------------
                            'Leonela Correa: Cambio de Piocito (5005080) por Leucocito (5005087 )
                            Dim str_sql27 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 121 & ", 1, " & ped_id & ", " & 5005010 & ");"
                            Dim str_sql28 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 122 & ", 1, " & ped_id & ", " & 5005015 & ");"
                            Dim str_sql29 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 123 & ", 1, " & ped_id & ", " & 5005020 & ");"
                            Dim str_sql30 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 124 & ", 1, " & ped_id & ", " & 5005025 & ");"
                            Dim str_sql31 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 125 & ", 1, " & ped_id & ", " & 5005030 & ");"
                            Dim str_sql32 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 126 & ", 1, " & ped_id & ", " & 5005035 & ");"
                            Dim str_sql33 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 127 & ", 1, " & ped_id & ", " & 5005040 & ");"
                            Dim str_sql34 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 128 & ", 1, " & ped_id & ", " & 5005045 & ");"
                            Dim str_sql35 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 129 & ", 1, " & ped_id & ", " & 5005050 & ");"
                            Dim str_sql36 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 130 & ", 1, " & ped_id & ", " & 5005055 & ");"
                            Dim str_sql37 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 131 & ", 1, " & ped_id & ", " & 5005060 & ");"
                            Dim str_sql38 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 132 & ", 1, " & ped_id & ", " & 5005065 & ");"
                            Dim str_sql39 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 133 & ", 1, " & ped_id & ", " & 5005070 & ");"
                            Dim str_sql40 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 134 & ", 1, " & ped_id & ", " & 5005075 & ");"
                            Dim str_sql41 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 135 & ", 1, " & ped_id & ", " & 5005080 & ");"
                            Dim str_sql42 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 136 & ", 1, " & ped_id & ", " & 5005085 & ");"
                            Dim str_sql43 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 137 & ", 1, " & ped_id & ", " & 5005087 & ");"
                            Dim str_sql44 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 138 & ", 1, " & ped_id & ", " & 5005090 & ");"
                            Dim str_sql45 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 139 & ", 1, " & ped_id & ", " & 5005095 & ");"
                            Dim str_sql46 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 140 & ", 1, " & ped_id & ", " & 5005100 & ");"
                            Dim str_sql47 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 141 & ", 1, " & ped_id & ", " & 5005105 & ");"
                            Dim oComando27 As OleDbCommand = New OleDbCommand(str_sql27, ocon)
                            Dim oComando28 As OleDbCommand = New OleDbCommand(str_sql28, ocon)
                            Dim oComando29 As OleDbCommand = New OleDbCommand(str_sql29, ocon)
                            Dim oComando30 As OleDbCommand = New OleDbCommand(str_sql30, ocon)
                            Dim oComando31 As OleDbCommand = New OleDbCommand(str_sql31, ocon)
                            Dim oComando32 As OleDbCommand = New OleDbCommand(str_sql32, ocon)
                            Dim oComando33 As OleDbCommand = New OleDbCommand(str_sql33, ocon)
                            Dim oComando34 As OleDbCommand = New OleDbCommand(str_sql34, ocon)
                            Dim oComando35 As OleDbCommand = New OleDbCommand(str_sql35, ocon)
                            Dim oComando36 As OleDbCommand = New OleDbCommand(str_sql36, ocon)
                            Dim oComando37 As OleDbCommand = New OleDbCommand(str_sql37, ocon)
                            Dim oComando38 As OleDbCommand = New OleDbCommand(str_sql38, ocon)
                            Dim oComando39 As OleDbCommand = New OleDbCommand(str_sql39, ocon)
                            Dim oComando40 As OleDbCommand = New OleDbCommand(str_sql40, ocon)
                            Dim oComando41 As OleDbCommand = New OleDbCommand(str_sql41, ocon)
                            Dim oComando42 As OleDbCommand = New OleDbCommand(str_sql42, ocon)
                            Dim oComando43 As OleDbCommand = New OleDbCommand(str_sql43, ocon)
                            Dim oComando44 As OleDbCommand = New OleDbCommand(str_sql44, ocon)
                            Dim oComando45 As OleDbCommand = New OleDbCommand(str_sql45, ocon)
                            Dim oComando46 As OleDbCommand = New OleDbCommand(str_sql46, ocon)
                            Dim oComando47 As OleDbCommand = New OleDbCommand(str_sql47, ocon)
                            oComando27.ExecuteNonQuery()
                            oComando28.ExecuteNonQuery()
                            oComando29.ExecuteNonQuery()
                            oComando30.ExecuteNonQuery()
                            oComando31.ExecuteNonQuery()
                            oComando32.ExecuteNonQuery()
                            oComando33.ExecuteNonQuery()
                            oComando34.ExecuteNonQuery()
                            oComando35.ExecuteNonQuery()
                            oComando36.ExecuteNonQuery()
                            oComando37.ExecuteNonQuery()
                            oComando38.ExecuteNonQuery()
                            oComando39.ExecuteNonQuery()
                            oComando40.ExecuteNonQuery()
                            oComando41.ExecuteNonQuery()
                            oComando42.ExecuteNonQuery()
                            oComando43.ExecuteNonQuery()
                            oComando44.ExecuteNonQuery()
                            oComando45.ExecuteNonQuery()
                            oComando46.ExecuteNonQuery()
                            oComando47.ExecuteNonQuery()

                        Case 605
                            Dim str_sql47 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 151 & ", 1, " & ped_id & ", " & 6056045 & ");"
                            Dim str_sql48 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 152 & ", 1, " & ped_id & ", " & 6056046 & ");"
                            Dim str_sql49 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 153 & ", 1, " & ped_id & ", " & 6056047 & ");"
                            Dim str_sql50 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 154 & ", 1, " & ped_id & ", " & 6056048 & ");"
                            Dim oComando47 As OleDbCommand = New OleDbCommand(str_sql47, ocon)
                            Dim oComando48 As OleDbCommand = New OleDbCommand(str_sql48, ocon)
                            Dim oComando49 As OleDbCommand = New OleDbCommand(str_sql49, ocon)
                            Dim oComando50 As OleDbCommand = New OleDbCommand(str_sql50, ocon)
                            oComando47.ExecuteNonQuery()
                            oComando48.ExecuteNonQuery()
                            oComando49.ExecuteNonQuery()
                            oComando50.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 270
                            Dim str_sql51 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 155 & ", 1, " & ped_id & ", " & 2702007 & ");"
                            Dim str_sql52 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 156 & ", 1, " & ped_id & ", " & 2702008 & ");"
                            Dim str_sql53 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 157 & ", 1, " & ped_id & ", " & 2702010 & ");"
                            Dim oComando51 As OleDbCommand = New OleDbCommand(str_sql51, ocon)
                            Dim oComando52 As OleDbCommand = New OleDbCommand(str_sql52, ocon)
                            Dim oComando53 As OleDbCommand = New OleDbCommand(str_sql53, ocon)
                            oComando51.ExecuteNonQuery()
                            oComando52.ExecuteNonQuery()
                            oComando53.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 800
                            Dim str_sql54 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 158 & ", 1, " & ped_id & ", " & 8001001 & ");"
                            Dim str_sql55 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 159 & ", 1, " & ped_id & ", " & 8001112 & ");"
                            Dim str_sql56 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 160 & ", 1, " & ped_id & ", " & 8002007 & ");"
                            Dim str_sql57 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 161 & ", 1, " & ped_id & ", " & 8002008 & ");"
                            Dim str_sql58 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 162 & ", 1, " & ped_id & ", " & 8002010 & ");"
                            Dim str_sql59 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 163 & ", 1, " & ped_id & ", " & 8005085 & ");"
                            Dim str_sql60 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 164 & ", 1, " & ped_id & ", " & 8005087 & ");"
                            Dim str_sql61 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 165 & ", 1, " & ped_id & ", " & 8008083 & ");"
                            Dim str_sql62 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 166 & ", 1, " & ped_id & ", " & 8008084 & ");"
                            Dim str_sql63 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 167 & ", 1, " & ped_id & ", " & 8008085 & ");"
                            Dim str_sql64 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 168 & ", 1, " & ped_id & ", " & 8008086 & ");"
                            Dim str_sql65 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 169 & ", 1, " & ped_id & ", " & 8008087 & ");"
                            Dim str_sql66 As String = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 170 & ", 1, " & ped_id & ", " & 8008088 & ");"
                            Dim oComando54 As OleDbCommand = New OleDbCommand(str_sql54, ocon)
                            Dim oComando55 As OleDbCommand = New OleDbCommand(str_sql55, ocon)
                            Dim oComando56 As OleDbCommand = New OleDbCommand(str_sql56, ocon)
                            Dim oComando57 As OleDbCommand = New OleDbCommand(str_sql57, ocon)
                            Dim oComando58 As OleDbCommand = New OleDbCommand(str_sql58, ocon)
                            Dim oComando59 As OleDbCommand = New OleDbCommand(str_sql59, ocon)
                            Dim oComando60 As OleDbCommand = New OleDbCommand(str_sql60, ocon)
                            Dim oComando61 As OleDbCommand = New OleDbCommand(str_sql61, ocon)
                            Dim oComando62 As OleDbCommand = New OleDbCommand(str_sql62, ocon)
                            Dim oComando63 As OleDbCommand = New OleDbCommand(str_sql63, ocon)
                            Dim oComando64 As OleDbCommand = New OleDbCommand(str_sql64, ocon)
                            Dim oComando65 As OleDbCommand = New OleDbCommand(str_sql65, ocon)
                            Dim oComando66 As OleDbCommand = New OleDbCommand(str_sql66, ocon)
                            oComando54.ExecuteNonQuery()
                            oComando55.ExecuteNonQuery()
                            oComando56.ExecuteNonQuery()
                            oComando57.ExecuteNonQuery()
                            oComando58.ExecuteNonQuery()
                            oComando59.ExecuteNonQuery()
                            oComando60.ExecuteNonQuery()
                            oComando61.ExecuteNonQuery()
                            oComando62.ExecuteNonQuery()
                            oComando63.ExecuteNonQuery()
                            oComando64.ExecuteNonQuery()
                            oComando65.ExecuteNonQuery()
                            oComando66.ExecuteNonQuery()
                    End Select
                Else
                    str_sql = "Insert into pedido_detalle (pee_id, pee_cantidad, ped_id,tes_id) values (" & pee_id + 300 & ", 1, " & ped_id & ", " & tes_id & ");"
                    Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, ocon)
                    odc_pedido.ExecuteNonQuery()
                End If
            End If
        Catch
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, InsertPedidoDetalle", Err)
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Sub

    Public Sub InsertPedidoDetalleDesglosado(ByVal ped_id As Integer, ByVal tes_id As Integer, ByRef ocon As OleDbConnection)
        'inserta un nuevo registro en la tabla PEDIDO_detalle_desglosado, con la informacion que se tiene 
        'PED_ID
        'TES_ID
        'PER_ID
        'PDD_ESTADO   
        Dim opr_sis As New Cls_sistema()
        Dim Conexion As OleDbConnection
        Dim str_sql As String = ""
        Conexion = ocon

        Try
            If Conexion.State = ConnectionState.Open Then
                If tes_id = 400 Or tes_id = 700 Or tes_id = 710 Or tes_id = 140 Or tes_id = 180 Or tes_id = 500 Or tes_id = 605 Or tes_id = 270 Or tes_id = 800 Then
                    Select Case tes_id
                        Case 400
                            Dim str_sql1 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 4004040 & ",1);"
                            Dim str_sql2 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 4004045 & ",1);"
                            Dim str_sql3 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 4004050 & ",1);"
                            Dim str_sql4 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 4004055 & ",1);"
                            Dim oComando1 As OleDbCommand = New OleDbCommand(str_sql1, ocon)
                            Dim oComando2 As OleDbCommand = New OleDbCommand(str_sql2, ocon)
                            Dim oComando3 As OleDbCommand = New OleDbCommand(str_sql3, ocon)
                            Dim oComando4 As OleDbCommand = New OleDbCommand(str_sql4, ocon)
                            oComando1.ExecuteNonQuery()
                            oComando2.ExecuteNonQuery()
                            oComando3.ExecuteNonQuery()
                            oComando4.ExecuteNonQuery()

                        Case 700
                            Dim str_sql7 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7008200 & ",1);"
                            Dim str_sql8 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7008202 & ",1);"
                            Dim str_sql9 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7008204 & ",1);"
                            Dim str_sql10 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7008206 & ",1);"
                            Dim str_sql11 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7008208 & ",1);"
                            Dim str_sql12 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7008210 & ",1);"
                            Dim str_sql13 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7008212 & ",1);"
                            Dim oComando7 As OleDbCommand = New OleDbCommand(str_sql7, ocon)
                            Dim oComando8 As OleDbCommand = New OleDbCommand(str_sql8, ocon)
                            Dim oComando9 As OleDbCommand = New OleDbCommand(str_sql9, ocon)
                            Dim oComando10 As OleDbCommand = New OleDbCommand(str_sql10, ocon)
                            Dim oComando11 As OleDbCommand = New OleDbCommand(str_sql11, ocon)
                            Dim oComando12 As OleDbCommand = New OleDbCommand(str_sql12, ocon)
                            Dim oComando13 As OleDbCommand = New OleDbCommand(str_sql13, ocon)
                            oComando7.ExecuteNonQuery()
                            oComando8.ExecuteNonQuery()
                            oComando9.ExecuteNonQuery()
                            oComando10.ExecuteNonQuery()
                            oComando11.ExecuteNonQuery()
                            oComando12.ExecuteNonQuery()
                            oComando13.ExecuteNonQuery()

                        Case 710
                            Dim str_sql14 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7108300 & ",1);"
                            Dim str_sql15 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7108302 & ",1);"
                            Dim str_sql16 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7108304 & ",1);"
                            Dim str_sql17 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7108306 & ",1);"
                            Dim str_sql18 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7108308 & ",1);"
                            Dim str_sql19 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7108310 & ",1);"
                            Dim str_sql20 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 7108312 & ",1);"
                            Dim oComando14 As OleDbCommand = New OleDbCommand(str_sql14, ocon)
                            Dim oComando15 As OleDbCommand = New OleDbCommand(str_sql15, ocon)
                            Dim oComando16 As OleDbCommand = New OleDbCommand(str_sql16, ocon)
                            Dim oComando17 As OleDbCommand = New OleDbCommand(str_sql17, ocon)
                            Dim oComando18 As OleDbCommand = New OleDbCommand(str_sql18, ocon)
                            Dim oComando19 As OleDbCommand = New OleDbCommand(str_sql19, ocon)
                            Dim oComando20 As OleDbCommand = New OleDbCommand(str_sql20, ocon)
                            oComando14.ExecuteNonQuery()
                            oComando15.ExecuteNonQuery()
                            oComando16.ExecuteNonQuery()
                            oComando17.ExecuteNonQuery()
                            oComando18.ExecuteNonQuery()
                            oComando19.ExecuteNonQuery()
                            oComando20.ExecuteNonQuery()

                        Case 140
                            Dim str_sql21 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 1401172 & ",1);"
                            Dim str_sql22 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 1401181 & ",1);"
                            Dim str_sql23 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 1401188 & ",1);"
                            Dim oComando21 As OleDbCommand = New OleDbCommand(str_sql21, ocon)
                            Dim oComando22 As OleDbCommand = New OleDbCommand(str_sql22, ocon)
                            Dim oComando23 As OleDbCommand = New OleDbCommand(str_sql23, ocon)
                            oComando21.ExecuteNonQuery()
                            oComando22.ExecuteNonQuery()
                            oComando23.ExecuteNonQuery()


                        Case 180
                            Dim str_sql24 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 1801045 & ",1);"
                            Dim str_sql25 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 1801054 & ",1);"
                            Dim str_sql26 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 1801239 & ",1);"
                            Dim oComando24 As OleDbCommand = New OleDbCommand(str_sql24, ocon)
                            Dim oComando25 As OleDbCommand = New OleDbCommand(str_sql25, ocon)
                            Dim oComando26 As OleDbCommand = New OleDbCommand(str_sql26, ocon)
                            oComando24.ExecuteNonQuery()
                            oComando25.ExecuteNonQuery()
                            oComando26.ExecuteNonQuery()

                        Case 500
                            '-----------------05/10/2008--------------------------
                            'Leonela Correa: Cambio de Piocito (5005080) por Leucocito (5005087 )
                            Dim str_sql27 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005010 & ",1);"
                            Dim str_sql28 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005015 & ",1);"
                            Dim str_sql29 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005020 & ",1);"
                            Dim str_sql30 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005025 & ",1);"
                            Dim str_sql31 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005030 & ",1);"
                            Dim str_sql32 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005035 & ",1);"
                            Dim str_sql33 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005040 & ",1);"
                            Dim str_sql34 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005045 & ",1);"
                            Dim str_sql35 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005050 & ",1);"
                            Dim str_sql36 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005055 & ",1);"
                            Dim str_sql37 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005060 & ",1);"
                            Dim str_sql38 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005065 & ",1);"
                            Dim str_sql39 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005070 & ",1);"
                            Dim str_sql40 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005075 & ",1);"
                            Dim str_sql41 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005080 & ",1);"
                            Dim str_sql42 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005085 & ",1);"
                            Dim str_sql43 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005087 & ",1);"
                            Dim str_sql44 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005090 & ",1);"
                            Dim str_sql45 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005095 & ",1);"
                            Dim str_sql46 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005100 & ",1);"
                            Dim str_sql47 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 5005105 & ",1);"
                            Dim oComando27 As OleDbCommand = New OleDbCommand(str_sql27, ocon)
                            Dim oComando28 As OleDbCommand = New OleDbCommand(str_sql28, ocon)
                            Dim oComando29 As OleDbCommand = New OleDbCommand(str_sql29, ocon)
                            Dim oComando30 As OleDbCommand = New OleDbCommand(str_sql30, ocon)
                            Dim oComando31 As OleDbCommand = New OleDbCommand(str_sql31, ocon)
                            Dim oComando32 As OleDbCommand = New OleDbCommand(str_sql32, ocon)
                            Dim oComando33 As OleDbCommand = New OleDbCommand(str_sql33, ocon)
                            Dim oComando34 As OleDbCommand = New OleDbCommand(str_sql34, ocon)
                            Dim oComando35 As OleDbCommand = New OleDbCommand(str_sql35, ocon)
                            Dim oComando36 As OleDbCommand = New OleDbCommand(str_sql36, ocon)
                            Dim oComando37 As OleDbCommand = New OleDbCommand(str_sql37, ocon)
                            Dim oComando38 As OleDbCommand = New OleDbCommand(str_sql38, ocon)
                            Dim oComando39 As OleDbCommand = New OleDbCommand(str_sql39, ocon)
                            Dim oComando40 As OleDbCommand = New OleDbCommand(str_sql40, ocon)
                            Dim oComando41 As OleDbCommand = New OleDbCommand(str_sql41, ocon)
                            Dim oComando42 As OleDbCommand = New OleDbCommand(str_sql42, ocon)
                            Dim oComando43 As OleDbCommand = New OleDbCommand(str_sql43, ocon)
                            Dim oComando44 As OleDbCommand = New OleDbCommand(str_sql44, ocon)
                            Dim oComando45 As OleDbCommand = New OleDbCommand(str_sql45, ocon)
                            Dim oComando46 As OleDbCommand = New OleDbCommand(str_sql46, ocon)
                            Dim oComando47 As OleDbCommand = New OleDbCommand(str_sql47, ocon)
                            oComando27.ExecuteNonQuery()
                            oComando28.ExecuteNonQuery()
                            oComando29.ExecuteNonQuery()
                            oComando30.ExecuteNonQuery()
                            oComando31.ExecuteNonQuery()
                            oComando32.ExecuteNonQuery()
                            oComando33.ExecuteNonQuery()
                            oComando34.ExecuteNonQuery()
                            oComando35.ExecuteNonQuery()
                            oComando36.ExecuteNonQuery()
                            oComando37.ExecuteNonQuery()
                            oComando38.ExecuteNonQuery()
                            oComando39.ExecuteNonQuery()
                            oComando40.ExecuteNonQuery()
                            oComando41.ExecuteNonQuery()
                            oComando42.ExecuteNonQuery()
                            oComando43.ExecuteNonQuery()
                            oComando44.ExecuteNonQuery()
                            oComando45.ExecuteNonQuery()
                            oComando46.ExecuteNonQuery()
                            oComando47.ExecuteNonQuery()

                        Case 605
                            Dim str_sql47 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 6056045 & ",1);"
                            Dim str_sql48 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 6056046 & ",1);"
                            Dim str_sql49 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 6056047 & ",1);"
                            Dim str_sql50 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 6056048 & ",1);"
                            Dim oComando47 As OleDbCommand = New OleDbCommand(str_sql47, ocon)
                            Dim oComando48 As OleDbCommand = New OleDbCommand(str_sql48, ocon)
                            Dim oComando49 As OleDbCommand = New OleDbCommand(str_sql49, ocon)
                            Dim oComando50 As OleDbCommand = New OleDbCommand(str_sql50, ocon)
                            oComando47.ExecuteNonQuery()
                            oComando48.ExecuteNonQuery()
                            oComando49.ExecuteNonQuery()
                            oComando50.ExecuteNonQuery()

                        Case 270
                            Dim str_sql51 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 2702007 & ",1);"
                            Dim str_sql52 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 2702008 & ",1);"
                            Dim str_sql53 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 2702010 & ",1);"
                            Dim oComando51 As OleDbCommand = New OleDbCommand(str_sql51, ocon)
                            Dim oComando52 As OleDbCommand = New OleDbCommand(str_sql52, ocon)
                            Dim oComando53 As OleDbCommand = New OleDbCommand(str_sql53, ocon)
                            oComando51.ExecuteNonQuery()
                            oComando52.ExecuteNonQuery()
                            oComando53.ExecuteNonQuery()

                        Case 800
                            Dim str_sql54 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8001001 & ",1);"
                            Dim str_sql55 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8001112 & ",1);"
                            Dim str_sql56 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8002007 & ",1);"
                            Dim str_sql57 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8002008 & ",1);"
                            Dim str_sql58 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8002010 & ",1);"
                            Dim str_sql59 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8005085 & ",1);"
                            Dim str_sql60 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8005087 & ",1);"
                            Dim str_sql61 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8008083 & ",1);"
                            Dim str_sql62 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8008084 & ",1);"
                            Dim str_sql63 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8008085 & ",1);"
                            Dim str_sql64 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8008086 & ",1);"
                            Dim str_sql65 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8008087 & ",1);"
                            Dim str_sql66 As String = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & 8008088 & ",1);"
                            Dim oComando54 As OleDbCommand = New OleDbCommand(str_sql54, ocon)
                            Dim oComando55 As OleDbCommand = New OleDbCommand(str_sql55, ocon)
                            Dim oComando56 As OleDbCommand = New OleDbCommand(str_sql56, ocon)
                            Dim oComando57 As OleDbCommand = New OleDbCommand(str_sql57, ocon)
                            Dim oComando58 As OleDbCommand = New OleDbCommand(str_sql58, ocon)
                            Dim oComando59 As OleDbCommand = New OleDbCommand(str_sql59, ocon)
                            Dim oComando60 As OleDbCommand = New OleDbCommand(str_sql60, ocon)
                            Dim oComando61 As OleDbCommand = New OleDbCommand(str_sql61, ocon)
                            Dim oComando62 As OleDbCommand = New OleDbCommand(str_sql62, ocon)
                            Dim oComando63 As OleDbCommand = New OleDbCommand(str_sql63, ocon)
                            Dim oComando64 As OleDbCommand = New OleDbCommand(str_sql64, ocon)
                            Dim oComando65 As OleDbCommand = New OleDbCommand(str_sql65, ocon)
                            Dim oComando66 As OleDbCommand = New OleDbCommand(str_sql66, ocon)
                            oComando54.ExecuteNonQuery()
                            oComando55.ExecuteNonQuery()
                            oComando56.ExecuteNonQuery()
                            oComando57.ExecuteNonQuery()
                            oComando58.ExecuteNonQuery()
                            oComando59.ExecuteNonQuery()
                            oComando60.ExecuteNonQuery()
                            oComando61.ExecuteNonQuery()
                            oComando62.ExecuteNonQuery()
                            oComando63.ExecuteNonQuery()
                            oComando64.ExecuteNonQuery()
                            oComando65.ExecuteNonQuery()
                            oComando66.ExecuteNonQuery()
                    End Select
                Else
                    str_sql = "Insert into pedido_detalle_desglosado (ped_id, tes_id, pdd_estado) values (" & ped_id & ", " & tes_id & ",1);"
                    Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, ocon)
                    odc_pedido.ExecuteNonQuery()
                End If
            End If
        Catch
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, InsertPedidoDetalleDesglosado", Err)
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Sub

    'Public Sub InsertLista_trabajo(ByVal ped_id As Integer, ByVal tes_id As Integer, ByRef ocon As SqlConnection, ByRef sql_trans As OledbTransaction)
    '    'inserta un nuevo registro en la tabla lista_trabajo, con la informacion que se tiene 
    '    'LISTA_TRABAJO
    '    Dim opr_sis As New Cls_sistema()
    '    Dim opr_Conexion As New Cls_Conexion()
    '    Dim Conexion As SqlConnection
    '    Dim tip_procesa As Byte
    '    Dim EQU_ID, TIM_ID, TUBO, EQUTIMID As Short
    '    Dim LIS_ID As Integer
    '    'Determino si la prueba es manual o de equipo
    '    opr_Conexion.conectar()
    '    Dim str_sql As String = "Select tes_tproces from TEST WHERE TES_ID = " & tes_id & ";"
    '    tip_procesa = CInt(New OledbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
    '    str_sql = "Select ISNULL(max(LIS_ID),0) from LISTA_TRABAJO;"
    '    LIS_ID = CInt(New OledbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
    '    LIS_ID += 1
    '    opr_Conexion.desconectar()

    '    Conexion = ocon

    '    Try
    '        If Conexion.State = ConnectionState.Open Then
    '            If tip_procesa = 0 Then 'MANUAL
    '                If tes_id = 400 Or tes_id = 700 Or tes_id = 710 Or tes_id = 140 Or tes_id = 180 Or tes_id = 500 Or tes_id = 605 Or tes_id = 270 Or tes_id = 800 Then
    '                    Select Case tes_id
    '                        Case 400
    '                            Dim str_sql1 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004040 & ",0,0,0)"
    '                            Dim str_sql2 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004045 & ",0,0,0)"
    '                            Dim str_sql3 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004050 & ",0,0,0)"
    '                            Dim str_sql4 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004055 & ",0,0,0)"
    '                            Dim oComando1 As OledbCommand = New OledbCommand(str_sql1, ocon, sql_trans)
    '                            Dim oComando2 As OledbCommand = New OledbCommand(str_sql2, ocon, sql_trans)
    '                            Dim oComando3 As OledbCommand = New OledbCommand(str_sql3, ocon, sql_trans)
    '                            Dim oComando4 As OledbCommand = New OledbCommand(str_sql4, ocon, sql_trans)
    '                            oComando1.ExecuteNonQuery()
    '                            oComando2.ExecuteNonQuery()
    '                            oComando3.ExecuteNonQuery()
    '                            oComando4.ExecuteNonQuery()

    '                        Case 700
    '                            Dim str_sql7 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008200 & ",0,0,0)"
    '                            Dim str_sql8 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008202 & ",0,0,0)"
    '                            Dim str_sql9 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008204 & ",0,0,0)"
    '                            Dim str_sql10 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008206 & ",0,0,0)"
    '                            Dim str_sql11 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008208 & ",0,0,0)"
    '                            Dim str_sql12 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008210 & ",0,0,0)"
    '                            Dim str_sql13 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008212 & ",0,0,0)"
    '                            Dim oComando7 As OledbCommand = New OledbCommand(str_sql7, ocon, sql_trans)
    '                            Dim oComando8 As OledbCommand = New OledbCommand(str_sql8, ocon, sql_trans)
    '                            Dim oComando9 As OledbCommand = New OledbCommand(str_sql9, ocon, sql_trans)
    '                            Dim oComando10 As OledbCommand = New OledbCommand(str_sql10, ocon, sql_trans)
    '                            Dim oComando11 As OledbCommand = New OledbCommand(str_sql11, ocon, sql_trans)
    '                            Dim oComando12 As OledbCommand = New OledbCommand(str_sql12, ocon, sql_trans)
    '                            Dim oComando13 As OledbCommand = New OledbCommand(str_sql13, ocon, sql_trans)
    '                            oComando7.ExecuteNonQuery()
    '                            oComando8.ExecuteNonQuery()
    '                            oComando9.ExecuteNonQuery()
    '                            oComando10.ExecuteNonQuery()
    '                            oComando11.ExecuteNonQuery()
    '                            oComando12.ExecuteNonQuery()
    '                            oComando13.ExecuteNonQuery()

    '                        Case 710
    '                            Dim str_sql14 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108300 & ",0,0,0)"
    '                            Dim str_sql15 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108302 & ",0,0,0)"
    '                            Dim str_sql16 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108304 & ",0,0,0)"
    '                            Dim str_sql17 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108306 & ",0,0,0)"
    '                            Dim str_sql18 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108308 & ",0,0,0)"
    '                            Dim str_sql19 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108310 & ",0,0,0)"
    '                            Dim str_sql20 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108312 & ",0,0,0)"
    '                            Dim oComando14 As OledbCommand = New OledbCommand(str_sql14, ocon, sql_trans)
    '                            Dim oComando15 As OledbCommand = New OledbCommand(str_sql15, ocon, sql_trans)
    '                            Dim oComando16 As OledbCommand = New OledbCommand(str_sql16, ocon, sql_trans)
    '                            Dim oComando17 As OledbCommand = New OledbCommand(str_sql17, ocon, sql_trans)
    '                            Dim oComando18 As OledbCommand = New OledbCommand(str_sql18, ocon, sql_trans)
    '                            Dim oComando19 As OledbCommand = New OledbCommand(str_sql19, ocon, sql_trans)
    '                            Dim oComando20 As OledbCommand = New OledbCommand(str_sql20, ocon, sql_trans)
    '                            oComando14.ExecuteNonQuery()
    '                            oComando15.ExecuteNonQuery()
    '                            oComando16.ExecuteNonQuery()
    '                            oComando17.ExecuteNonQuery()
    '                            oComando18.ExecuteNonQuery()
    '                            oComando19.ExecuteNonQuery()
    '                            oComando20.ExecuteNonQuery()

    '                        Case 140
    '                            'verifica el tipo de procesamiemto de los electrolitos
    '                            Dim odr As OledbdataReader
    '                            Dim valida As Short
    '                            Dim i As Short = 0
    '                            Dim str_sql21 As String
    '                            Dim str_sql22 As String
    '                            Dim str_sql23 As String
    '                            str_sql21 = "select teq_estado as Estado from test_equipo where tes_id=1401172"
    '                            str_sql22 = "select teq_estado as Estado from test_equipo where tes_id=1401181"
    '                            str_sql23 = "select teq_estado as Estado from test_equipo where tes_id=1401188"

    '                            opr_Conexion.conectar()
    '                            For i = 0 To 2
    '                                Select Case i
    '                                    Case 0
    '                                        odr = New OledbCommand(str_sql21, opr_Conexion.Conn_BD).ExecuteReader
    '                                        While odr.Read
    '                                            valida = odr.GetValue(0)
    '                                        End While
    '                                        odr.Close()
    '                                    Case 1
    '                                        odr = New OledbCommand(str_sql22, opr_Conexion.Conn_BD).ExecuteReader
    '                                        While odr.Read
    '                                            valida = odr.GetValue(0)
    '                                        End While
    '                                        odr.Close()
    '                                    Case 2
    '                                        odr = New OledbCommand(str_sql23, opr_Conexion.Conn_BD).ExecuteReader
    '                                        While odr.Read
    '                                            valida = odr.GetValue(0)
    '                                        End While
    '                                        odr.Close()
    '                                End Select
    '                            Next
    '                            opr_Conexion.desconectar()
    '                            'limpio los string de consulta
    '                            str_sql21 = ""
    '                            str_sql22 = ""
    '                            str_sql23 = ""

    '                            If valida = 0 Then
    '                                'manual
    '                                str_sql21 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401172 & ",0,0,0)"
    '                                str_sql22 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401181 & ",0,0,0)"
    '                                str_sql23 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401188 & ",0,0,0)"
    '                                Dim oComando21 As OledbCommand = New OledbCommand(str_sql21, ocon, sql_trans)
    '                                Dim oComando22 As OledbCommand = New OledbCommand(str_sql22, ocon, sql_trans)
    '                                Dim oComando23 As OledbCommand = New OledbCommand(str_sql23, ocon, sql_trans)
    '                                oComando21.ExecuteNonQuery()
    '                                oComando22.ExecuteNonQuery()
    '                                oComando23.ExecuteNonQuery()
    '                            Else
    '                                'automatica
    '                                str_sql21 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401172 & "," & 1 & ", " & 2 & "," & 1 & ", " & 2 & ",0,0,0); "
    '                                str_sql22 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401181 & "," & 1 & ", " & 2 & "," & 1 & ", " & 2 & ",0,0,0); "
    '                                str_sql23 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401188 & "," & 1 & ", " & 2 & "," & 1 & ", " & 2 & ",0,0,0); "
    '                                Dim oComando21 As OledbCommand = New OledbCommand(str_sql21, ocon, sql_trans)
    '                                Dim oComando22 As OledbCommand = New OledbCommand(str_sql22, ocon, sql_trans)
    '                                Dim oComando23 As OledbCommand = New OledbCommand(str_sql23, ocon, sql_trans)
    '                                oComando21.ExecuteNonQuery()
    '                                oComando22.ExecuteNonQuery()
    '                                oComando23.ExecuteNonQuery()
    '                                'los graba en la tabla res_procesados para cuando se procesa automaticamente
    '                                Call InsertResProcesados(ped_id, 1401172)
    '                                Call InsertResProcesados(ped_id, 1401181)
    '                                Call InsertResProcesados(ped_id, 1401188)
    '                            End If

    '                        Case 180
    '                            Dim str_sql24 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1801045 & ",0,0,0)"
    '                            Dim str_sql25 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1801054 & ",0,0,0)"
    '                            Dim str_sql26 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1801239 & ",0,0,0)"
    '                            Dim oComando24 As OledbCommand = New OledbCommand(str_sql24, ocon, sql_trans)
    '                            Dim oComando25 As OledbCommand = New OledbCommand(str_sql25, ocon, sql_trans)
    '                            Dim oComando26 As OledbCommand = New OledbCommand(str_sql26, ocon, sql_trans)
    '                            oComando24.ExecuteNonQuery()
    '                            oComando25.ExecuteNonQuery()
    '                            oComando26.ExecuteNonQuery()

    '                        Case 500
    '                            Dim str_sql27 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005010 & ",0,0,0)"
    '                            Dim str_sql28 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005015 & ",0,0,0)"
    '                            Dim str_sql29 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005020 & ",0,0,0)"
    '                            Dim str_sql30 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005025 & ",0,0,0)"
    '                            Dim str_sql31 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005030 & ",0,0,0)"
    '                            Dim str_sql32 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005035 & ",0,0,0)"
    '                            Dim str_sql33 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005040 & ",0,0,0)"
    '                            Dim str_sql34 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 7 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005045 & ",0,0,0)"
    '                            Dim str_sql35 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 8 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005050 & ",0,0,0)"
    '                            Dim str_sql36 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 9 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005055 & ",0,0,0)"
    '                            Dim str_sql37 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 10 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005060 & ",0,0,0)"
    '                            Dim str_sql38 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 11 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005065 & ",0,0,0)"
    '                            Dim str_sql39 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 12 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005070 & ",0,0,0)"
    '                            Dim str_sql40 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 13 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005075 & ",0,0,0)"
    '                            Dim str_sql41 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 14 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005080 & ",0,0,0)"
    '                            Dim str_sql42 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 15 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005085 & ",0,0,0)"
    '                            Dim str_sql43 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 16 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005090 & ",0,0,0)"
    '                            Dim str_sql44 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 17 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005095 & ",0,0,0)"
    '                            Dim str_sql45 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 18 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005100 & ",0,0,0)"
    '                            Dim str_sql46 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 19 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005105 & ",0,0,0)"
    '                            Dim oComando27 As OledbCommand = New OledbCommand(str_sql27, ocon, sql_trans)
    '                            Dim oComando28 As OledbCommand = New OledbCommand(str_sql28, ocon, sql_trans)
    '                            Dim oComando29 As OledbCommand = New OledbCommand(str_sql29, ocon, sql_trans)
    '                            Dim oComando30 As OledbCommand = New OledbCommand(str_sql30, ocon, sql_trans)
    '                            Dim oComando31 As OledbCommand = New OledbCommand(str_sql31, ocon, sql_trans)
    '                            Dim oComando32 As OledbCommand = New OledbCommand(str_sql32, ocon, sql_trans)
    '                            Dim oComando33 As OledbCommand = New OledbCommand(str_sql33, ocon, sql_trans)
    '                            Dim oComando34 As OledbCommand = New OledbCommand(str_sql34, ocon, sql_trans)
    '                            Dim oComando35 As OledbCommand = New OledbCommand(str_sql35, ocon, sql_trans)
    '                            Dim oComando36 As OledbCommand = New OledbCommand(str_sql36, ocon, sql_trans)
    '                            Dim oComando37 As OledbCommand = New OledbCommand(str_sql37, ocon, sql_trans)
    '                            Dim oComando38 As OledbCommand = New OledbCommand(str_sql38, ocon, sql_trans)
    '                            Dim oComando39 As OledbCommand = New OledbCommand(str_sql39, ocon, sql_trans)
    '                            Dim oComando40 As OledbCommand = New OledbCommand(str_sql40, ocon, sql_trans)
    '                            Dim oComando41 As OledbCommand = New OledbCommand(str_sql41, ocon, sql_trans)
    '                            Dim oComando42 As OledbCommand = New OledbCommand(str_sql42, ocon, sql_trans)
    '                            Dim oComando43 As OledbCommand = New OledbCommand(str_sql43, ocon, sql_trans)
    '                            Dim oComando44 As OledbCommand = New OledbCommand(str_sql44, ocon, sql_trans)
    '                            Dim oComando45 As OledbCommand = New OledbCommand(str_sql45, ocon, sql_trans)
    '                            Dim oComando46 As OledbCommand = New OledbCommand(str_sql46, ocon, sql_trans)
    '                            oComando27.ExecuteNonQuery()
    '                            oComando28.ExecuteNonQuery()
    '                            oComando29.ExecuteNonQuery()
    '                            oComando30.ExecuteNonQuery()
    '                            oComando31.ExecuteNonQuery()
    '                            oComando32.ExecuteNonQuery()
    '                            oComando33.ExecuteNonQuery()
    '                            oComando34.ExecuteNonQuery()
    '                            oComando35.ExecuteNonQuery()
    '                            oComando36.ExecuteNonQuery()
    '                            oComando37.ExecuteNonQuery()
    '                            oComando38.ExecuteNonQuery()
    '                            oComando39.ExecuteNonQuery()
    '                            oComando40.ExecuteNonQuery()
    '                            oComando41.ExecuteNonQuery()
    '                            oComando42.ExecuteNonQuery()
    '                            oComando43.ExecuteNonQuery()
    '                            oComando44.ExecuteNonQuery()
    '                            oComando45.ExecuteNonQuery()
    '                            oComando46.ExecuteNonQuery()

    '                        Case 605
    '                            Dim str_sql47 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056045 & ",0,0,0)"
    '                            Dim str_sql48 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056046 & ",0,0,0)"
    '                            Dim str_sql49 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056047 & ",0,0,0)"
    '                            Dim str_sql50 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056048 & ",0,0,0)"
    '                            Dim oComando47 As OledbCommand = New OledbCommand(str_sql47, ocon, sql_trans)
    '                            Dim oComando48 As OledbCommand = New OledbCommand(str_sql48, ocon, sql_trans)
    '                            Dim oComando49 As OledbCommand = New OledbCommand(str_sql49, ocon, sql_trans)
    '                            Dim oComando50 As OledbCommand = New OledbCommand(str_sql50, ocon, sql_trans)
    '                            oComando47.ExecuteNonQuery()
    '                            oComando48.ExecuteNonQuery()
    '                            oComando49.ExecuteNonQuery()
    '                            oComando50.ExecuteNonQuery()

    '                        Case 270
    '                            Dim str_sql51 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 2702007 & ",0,0,0)"
    '                            Dim str_sql52 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 2702008 & ",0,0,0)"
    '                            Dim str_sql53 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 2702010 & ",0,0,0)"
    '                            Dim oComando51 As OledbCommand = New OledbCommand(str_sql51, ocon, sql_trans)
    '                            Dim oComando52 As OledbCommand = New OledbCommand(str_sql52, ocon, sql_trans)
    '                            Dim oComando53 As OledbCommand = New OledbCommand(str_sql53, ocon, sql_trans)
    '                            oComando51.ExecuteNonQuery()
    '                            oComando52.ExecuteNonQuery()
    '                            oComando53.ExecuteNonQuery()

    '                        Case 800
    '                            Dim str_sql54 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8001001 & ",0,0,0)"
    '                            Dim str_sql55 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8001112 & ",0,0,0)"
    '                            Dim str_sql56 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8002007 & ",0,0,0)"
    '                            Dim str_sql57 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8002008 & ",0,0,0)"
    '                            Dim str_sql58 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8002010 & ",0,0,0)"
    '                            Dim str_sql59 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8005085 & ",0,0,0)"
    '                            Dim str_sql60 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 7 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8005087 & ",0,0,0)"
    '                            Dim str_sql61 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 8 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008083 & ",0,0,0)"
    '                            Dim str_sql62 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 9 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008084 & ",0,0,0)"
    '                            Dim str_sql63 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 10 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008085 & ",0,0,0)"
    '                            Dim str_sql64 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 11 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008086 & ",0,0,0)"
    '                            Dim str_sql65 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 12 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008087 & ",0,0,0)"
    '                            Dim str_sql66 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 13 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008088 & ",0,0,0)"
    '                            Dim oComando54 As OledbCommand = New OledbCommand(str_sql54, ocon, sql_trans)
    '                            Dim oComando55 As OledbCommand = New OledbCommand(str_sql55, ocon, sql_trans)
    '                            Dim oComando56 As OledbCommand = New OledbCommand(str_sql56, ocon, sql_trans)
    '                            Dim oComando57 As OledbCommand = New OledbCommand(str_sql57, ocon, sql_trans)
    '                            Dim oComando58 As OledbCommand = New OledbCommand(str_sql58, ocon, sql_trans)
    '                            Dim oComando59 As OledbCommand = New OledbCommand(str_sql59, ocon, sql_trans)
    '                            Dim oComando60 As OledbCommand = New OledbCommand(str_sql60, ocon, sql_trans)
    '                            Dim oComando61 As OledbCommand = New OledbCommand(str_sql61, ocon, sql_trans)
    '                            Dim oComando62 As OledbCommand = New OledbCommand(str_sql62, ocon, sql_trans)
    '                            Dim oComando63 As OledbCommand = New OledbCommand(str_sql63, ocon, sql_trans)
    '                            Dim oComando64 As OledbCommand = New OledbCommand(str_sql64, ocon, sql_trans)
    '                            Dim oComando65 As OledbCommand = New OledbCommand(str_sql65, ocon, sql_trans)
    '                            Dim oComando66 As OledbCommand = New OledbCommand(str_sql66, ocon, sql_trans)
    '                            oComando54.ExecuteNonQuery()
    '                            oComando55.ExecuteNonQuery()
    '                            oComando56.ExecuteNonQuery()
    '                            oComando57.ExecuteNonQuery()
    '                            oComando58.ExecuteNonQuery()
    '                            oComando59.ExecuteNonQuery()
    '                            oComando60.ExecuteNonQuery()
    '                            oComando61.ExecuteNonQuery()
    '                            oComando62.ExecuteNonQuery()
    '                            oComando63.ExecuteNonQuery()
    '                            oComando64.ExecuteNonQuery()
    '                            oComando65.ExecuteNonQuery()
    '                            oComando66.ExecuteNonQuery()
    '                    End Select
    '                Else
    '                    str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
    '                              "VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & tes_id & ",0,0,0)"
    '                    Dim odc_pedido As OledbCommand = New OledbCommand(str_sql, ocon, sql_trans)
    '                    odc_pedido.ExecuteNonQuery()
    '                End If
    '            Else  'AUTOMATICA
    '                'EN QUE EQUIPO SE PROCESA?
    '                opr_Conexion.conectar()
    '                str_sql = "select equ_id from test_equipo where tes_id = " & tes_id & " and teq_estado = 1;"
    '                EQU_ID = CInt(New OledbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)

    '                str_sql = "SELECT T.TIM_ID, TUB_DEFAULT, TT.TIM_ID FROM TESTEQUIPO_TIPMUESTRA AS TT, TEST_EQUIPO AS TE, TEST AS T " & _
    '                        "WHERE T.TES_ID = TE.TES_ID And TT.TEQ_ID = TE.TEQ_ID And TE.TES_ID = " & tes_id & " And TEQ_ESTADO = 1 And TIM_DEFAULT = 1;"
    '                Dim oda_operacion As OledbdataReader = New OledbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteReader
    '                While oda_operacion.Read
    '                    TIM_ID = oda_operacion.GetValue(0).ToString
    '                    TUBO = oda_operacion.GetValue(1).ToString
    '                    EQUTIMID = oda_operacion.GetValue(2).ToString
    '                End While
    '                oda_operacion.Close()
    '                opr_Conexion.desconectar()
    '                'LIS_ID   (secuencial)
    '                'PED_ID    (fijo)
    '                'LIS_FECING (fecha actual)
    '                'TES_ID    (dato)
    '                'EQU_ID    (consulto *)
    '                'LIS_RESRANGO  ()
    '                'LIS_RESUNIDAD()
    '                'LIS_RESMANUAL ()
    '                'LIS_RESESTADO (0)
    '                'TIM_ID       (consulto)
    '                'LIS_POSNUM   ()
    '                'LIS_TUBO     (consulto)
    '                'PER_ID       ()
    '                'LIS_EQUTIMID  (consulto)
    '                'LIS_RACK     ()
    '                'LIS_EQUERROR  ()

    '                str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, " & _
    '                "LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
    '                "VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & tes_id & "," & EQU_ID & ", " & TIM_ID & "," & TUBO & ", " & EQUTIMID & ",0,0,0);"
    '                Dim odc_pedido As OledbCommand = New OledbCommand(str_sql, ocon, sql_trans)
    '                odc_pedido.ExecuteNonQuery()
    '                'INSERTA FORMATO EN RESPROCESADOS 
    '                Call InsertResProcesados(ped_id, tes_id)

    '            End If
    '        End If
    '        Exit Sub
    '    Catch
    '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, InsertLista_trabajo", Err)
    '        RutinaError(Err.Number, Err.Description)
    '        Err.Clear()
    '        'pequeña operacion que volvera a insertar el registro en la tabla de la lista de trabajo
    '        k = k + 1
    '        If k <= 3 Then
    '            Call InsertLista_trabajo(ped_id, tes_id, ocon, sql_trans)
    '        Else
    '            Exit Sub
    '        End If
    '    End Try
    'End Sub

    Public Function InsertLista_trabajo(ByVal ped_id As Integer, ByVal tes_id As Integer) As Boolean

        'inserta un nuevo registro en la tabla lista_trabajo, con la informacion que se tiene 
        'LISTA_TRABAJO
        Dim opr_sis As New Cls_sistema()
        Dim opr_Conexion As New Cls_Conexion()
        Dim tip_procesa As Byte
        Dim EQU_ID, TIM_ID, TUBO, EQUTIMID As Short
        Dim LIS_ID As Integer
        Dim trans As OleDbTransaction
        'Determino si la prueba es manual o de equipo
        opr_Conexion.odbc_conn()
        Dim str_sql As String = "Select tes_tproces from TEST WHERE TES_ID = " & tes_id & ";"
        tip_procesa = CInt(New OdbcCommand(str_sql, opr_Conexion.conn_odbc).ExecuteScalar)
        str_sql = "Select IFNULL(max(LIS_ID),'0') from LISTA_TRABAJO;"
        LIS_ID = CInt(New OdbcCommand(str_sql, opr_Conexion.conn_odbc).ExecuteScalar)
        LIS_ID += 1
        opr_Conexion.odbc_desconn()

        Try
            If tip_procesa = 0 Then 'MANUAL
                If tes_id = 400 Or tes_id = 700 Or tes_id = 710 Or tes_id = 140 Or tes_id = 180 Or tes_id = 500 Or tes_id = 605 Or tes_id = 270 Or tes_id = 800 Then
                    Select Case tes_id
                        Case 400
                            Dim str_sql1 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004040 & ",0,0,0)"
                            Dim str_sql2 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004045 & ",0,0,0)"
                            Dim str_sql3 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004050 & ",0,0,0)"
                            Dim str_sql4 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 4004055 & ",0,0,0)"
                            opr_Conexion.conectar()
                            'trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.Conn_BD, trans)
                            Dim oComando2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.Conn_BD, trans)
                            Dim oComando3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.Conn_BD, trans)
                            Dim oComando4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.Conn_BD, trans)
                            oComando1.ExecuteNonQuery()
                            oComando2.ExecuteNonQuery()
                            oComando3.ExecuteNonQuery()
                            oComando4.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 700
                            Dim str_sql7 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008200 & ",0,0,0)"
                            Dim str_sql8 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008202 & ",0,0,0)"
                            Dim str_sql9 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008204 & ",0,0,0)"
                            Dim str_sql10 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008206 & ",0,0,0)"
                            Dim str_sql11 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008208 & ",0,0,0)"
                            Dim str_sql12 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008210 & ",0,0,0)"
                            Dim str_sql13 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7008212 & ",0,0,0)"
                            opr_Conexion.conectar()
                            trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando7 As OleDbCommand = New OleDbCommand(str_sql7, opr_Conexion.Conn_BD, trans)
                            Dim oComando8 As OleDbCommand = New OleDbCommand(str_sql8, opr_Conexion.Conn_BD, trans)
                            Dim oComando9 As OleDbCommand = New OleDbCommand(str_sql9, opr_Conexion.Conn_BD, trans)
                            Dim oComando10 As OleDbCommand = New OleDbCommand(str_sql10, opr_Conexion.Conn_BD, trans)
                            Dim oComando11 As OleDbCommand = New OleDbCommand(str_sql11, opr_Conexion.Conn_BD, trans)
                            Dim oComando12 As OleDbCommand = New OleDbCommand(str_sql12, opr_Conexion.Conn_BD, trans)
                            Dim oComando13 As OleDbCommand = New OleDbCommand(str_sql13, opr_Conexion.Conn_BD, trans)
                            oComando7.ExecuteNonQuery()
                            oComando8.ExecuteNonQuery()
                            oComando9.ExecuteNonQuery()
                            oComando10.ExecuteNonQuery()
                            oComando11.ExecuteNonQuery()
                            oComando12.ExecuteNonQuery()
                            oComando13.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 710
                            Dim str_sql14 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108300 & ",0,0,0)"
                            Dim str_sql15 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108302 & ",0,0,0)"
                            Dim str_sql16 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108304 & ",0,0,0)"
                            Dim str_sql17 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108306 & ",0,0,0)"
                            Dim str_sql18 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108308 & ",0,0,0)"
                            Dim str_sql19 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108310 & ",0,0,0)"
                            Dim str_sql20 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 7108312 & ",0,0,0)"
                            opr_Conexion.conectar()
                            trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando14 As OleDbCommand = New OleDbCommand(str_sql14, opr_Conexion.Conn_BD, trans)
                            Dim oComando15 As OleDbCommand = New OleDbCommand(str_sql15, opr_Conexion.Conn_BD, trans)
                            Dim oComando16 As OleDbCommand = New OleDbCommand(str_sql16, opr_Conexion.Conn_BD, trans)
                            Dim oComando17 As OleDbCommand = New OleDbCommand(str_sql17, opr_Conexion.Conn_BD, trans)
                            Dim oComando18 As OleDbCommand = New OleDbCommand(str_sql18, opr_Conexion.Conn_BD, trans)
                            Dim oComando19 As OleDbCommand = New OleDbCommand(str_sql19, opr_Conexion.Conn_BD, trans)
                            Dim oComando20 As OleDbCommand = New OleDbCommand(str_sql20, opr_Conexion.Conn_BD, trans)
                            oComando14.ExecuteNonQuery()
                            oComando15.ExecuteNonQuery()
                            oComando16.ExecuteNonQuery()
                            oComando17.ExecuteNonQuery()
                            oComando18.ExecuteNonQuery()
                            oComando19.ExecuteNonQuery()
                            oComando20.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 140
                            'verifica el tipo de procesamiemto de los electrolitos
                            Dim odr As OleDbDataReader
                            Dim valida As Short
                            Dim i As Short = 0
                            Dim str_sql21 As String
                            Dim str_sql22 As String
                            Dim str_sql23 As String
                            str_sql21 = "select teq_estado as Estado from test_equipo where tes_id=1401172"
                            str_sql22 = "select teq_estado as Estado from test_equipo where tes_id=1401181"
                            str_sql23 = "select teq_estado as Estado from test_equipo where tes_id=1401188"

                            opr_Conexion.conectar()
                            For i = 0 To 2
                                Select Case i
                                    Case 0
                                        odr = New OleDbCommand(str_sql21, opr_Conexion.Conn_BD).ExecuteReader
                                        While odr.Read
                                            valida = odr.GetValue(0)
                                        End While
                                        odr.Close()
                                    Case 1
                                        odr = New OleDbCommand(str_sql22, opr_Conexion.Conn_BD).ExecuteReader
                                        While odr.Read
                                            valida = odr.GetValue(0)
                                        End While
                                        odr.Close()
                                    Case 2
                                        odr = New OleDbCommand(str_sql23, opr_Conexion.Conn_BD).ExecuteReader
                                        While odr.Read
                                            valida = odr.GetValue(0)
                                        End While
                                        odr.Close()
                                End Select
                            Next
                            opr_Conexion.desconectar()
                            'limpio los string de consulta
                            str_sql21 = ""
                            str_sql22 = ""
                            str_sql23 = ""

                            If valida = 0 Then
                                'manual
                                str_sql21 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401172 & ",0,0,0)"
                                str_sql22 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401181 & ",0,0,0)"
                                str_sql23 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401188 & ",0,0,0)"
                                opr_Conexion.conectar()
                                trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                                Dim oComando21 As OleDbCommand = New OleDbCommand(str_sql21, opr_Conexion.Conn_BD, trans)
                                Dim oComando22 As OleDbCommand = New OleDbCommand(str_sql22, opr_Conexion.Conn_BD, trans)
                                Dim oComando23 As OleDbCommand = New OleDbCommand(str_sql23, opr_Conexion.Conn_BD, trans)
                                oComando21.ExecuteNonQuery()
                                oComando22.ExecuteNonQuery()
                                oComando23.ExecuteNonQuery()
                            Else
                                'automatica
                                str_sql21 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401172 & "," & 1 & ", " & 2 & "," & 1 & ", " & 2 & ",0,0,0); "
                                str_sql22 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401181 & "," & 1 & ", " & 2 & "," & 1 & ", " & 2 & ",0,0,0); "
                                str_sql23 = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1401188 & "," & 1 & ", " & 2 & "," & 1 & ", " & 2 & ",0,0,0); "
                                opr_Conexion.conectar()
                                trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                                Dim oComando21 As OleDbCommand = New OleDbCommand(str_sql21, opr_Conexion.Conn_BD, trans)
                                Dim oComando22 As OleDbCommand = New OleDbCommand(str_sql22, opr_Conexion.Conn_BD, trans)
                                Dim oComando23 As OleDbCommand = New OleDbCommand(str_sql23, opr_Conexion.Conn_BD, trans)
                                oComando21.ExecuteNonQuery()
                                oComando22.ExecuteNonQuery()
                                oComando23.ExecuteNonQuery()
                                'los graba en la tabla res_procesados para cuando se procesa automaticamente
                                Call InsertResProcesados(ped_id, 1401172)
                                Call InsertResProcesados(ped_id, 1401181)
                                Call InsertResProcesados(ped_id, 1401188)
                            End If
                            'sql_trans.Commit()

                        Case 180
                            Dim str_sql24 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1801045 & ",0,0,0)"
                            Dim str_sql25 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1801054 & ",0,0,0)"
                            Dim str_sql26 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 1801239 & ",0,0,0)"
                            opr_Conexion.conectar()
                            trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando24 As OleDbCommand = New OleDbCommand(str_sql24, opr_Conexion.Conn_BD, trans)
                            Dim oComando25 As OleDbCommand = New OleDbCommand(str_sql25, opr_Conexion.Conn_BD, trans)
                            Dim oComando26 As OleDbCommand = New OleDbCommand(str_sql26, opr_Conexion.Conn_BD, trans)
                            oComando24.ExecuteNonQuery()
                            oComando25.ExecuteNonQuery()
                            oComando26.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 500
                            '-----------------05/10/2008--------------------------
                            'Leonela Correa: Cambio de Piocito (5005080) por Leucocito (5005087 )
                            Dim str_sql27 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005010 & ",0,0,0)"
                            Dim str_sql28 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005015 & ",0,0,0)"
                            Dim str_sql29 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005020 & ",0,0,0)"
                            Dim str_sql30 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005025 & ",0,0,0)"
                            Dim str_sql31 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005030 & ",0,0,0)"
                            Dim str_sql32 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005035 & ",0,0,0)"
                            Dim str_sql33 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005040 & ",0,0,0)"
                            Dim str_sql34 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 7 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005045 & ",0,0,0)"
                            Dim str_sql35 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 8 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005050 & ",0,0,0)"
                            Dim str_sql36 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 9 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005055 & ",0,0,0)"
                            Dim str_sql37 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 10 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005060 & ",0,0,0)"
                            Dim str_sql38 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 11 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005065 & ",0,0,0)"
                            Dim str_sql39 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 12 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005070 & ",0,0,0)"
                            Dim str_sql40 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 13 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005075 & ",0,0,0)"
                            Dim str_sql41 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 14 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005080 & ",0,0,0)"
                            Dim str_sql42 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 15 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005085 & ",0,0,0)"
                            Dim str_sql43 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 16 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005087 & ",0,0,0)"
                            Dim str_sql44 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 17 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005090 & ",0,0,0)"
                            Dim str_sql45 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 18 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005095 & ",0,0,0)"
                            Dim str_sql46 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 19 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005100 & ",0,0,0)"
                            Dim str_sql47 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 20 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 5005105 & ",0,0,0)"
                            opr_Conexion.conectar()
                            trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando27 As OleDbCommand = New OleDbCommand(str_sql27, opr_Conexion.Conn_BD, trans)
                            Dim oComando28 As OleDbCommand = New OleDbCommand(str_sql28, opr_Conexion.Conn_BD, trans)
                            Dim oComando29 As OleDbCommand = New OleDbCommand(str_sql29, opr_Conexion.Conn_BD, trans)
                            Dim oComando30 As OleDbCommand = New OleDbCommand(str_sql30, opr_Conexion.Conn_BD, trans)
                            Dim oComando31 As OleDbCommand = New OleDbCommand(str_sql31, opr_Conexion.Conn_BD, trans)
                            Dim oComando32 As OleDbCommand = New OleDbCommand(str_sql32, opr_Conexion.Conn_BD, trans)
                            Dim oComando33 As OleDbCommand = New OleDbCommand(str_sql33, opr_Conexion.Conn_BD, trans)
                            Dim oComando34 As OleDbCommand = New OleDbCommand(str_sql34, opr_Conexion.Conn_BD, trans)
                            Dim oComando35 As OleDbCommand = New OleDbCommand(str_sql35, opr_Conexion.Conn_BD, trans)
                            Dim oComando36 As OleDbCommand = New OleDbCommand(str_sql36, opr_Conexion.Conn_BD, trans)
                            Dim oComando37 As OleDbCommand = New OleDbCommand(str_sql37, opr_Conexion.Conn_BD, trans)
                            Dim oComando38 As OleDbCommand = New OleDbCommand(str_sql38, opr_Conexion.Conn_BD, trans)
                            Dim oComando39 As OleDbCommand = New OleDbCommand(str_sql39, opr_Conexion.Conn_BD, trans)
                            Dim oComando40 As OleDbCommand = New OleDbCommand(str_sql40, opr_Conexion.Conn_BD, trans)
                            Dim oComando41 As OleDbCommand = New OleDbCommand(str_sql41, opr_Conexion.Conn_BD, trans)
                            Dim oComando42 As OleDbCommand = New OleDbCommand(str_sql42, opr_Conexion.Conn_BD, trans)
                            Dim oComando43 As OleDbCommand = New OleDbCommand(str_sql43, opr_Conexion.Conn_BD, trans)
                            Dim oComando44 As OleDbCommand = New OleDbCommand(str_sql44, opr_Conexion.Conn_BD, trans)
                            Dim oComando45 As OleDbCommand = New OleDbCommand(str_sql45, opr_Conexion.Conn_BD, trans)
                            Dim oComando46 As OleDbCommand = New OleDbCommand(str_sql46, opr_Conexion.Conn_BD, trans)
                            Dim oComando47 As OleDbCommand = New OleDbCommand(str_sql47, opr_Conexion.Conn_BD, trans)
                            oComando27.ExecuteNonQuery()
                            oComando28.ExecuteNonQuery()
                            oComando29.ExecuteNonQuery()
                            oComando30.ExecuteNonQuery()
                            oComando31.ExecuteNonQuery()
                            oComando32.ExecuteNonQuery()
                            oComando33.ExecuteNonQuery()
                            oComando34.ExecuteNonQuery()
                            oComando35.ExecuteNonQuery()
                            oComando36.ExecuteNonQuery()
                            oComando37.ExecuteNonQuery()
                            oComando38.ExecuteNonQuery()
                            oComando39.ExecuteNonQuery()
                            oComando40.ExecuteNonQuery()
                            oComando41.ExecuteNonQuery()
                            oComando42.ExecuteNonQuery()
                            oComando43.ExecuteNonQuery()
                            oComando44.ExecuteNonQuery()
                            oComando45.ExecuteNonQuery()
                            oComando46.ExecuteNonQuery()
                            oComando47.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 605
                            Dim str_sql47 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056045 & ",0,0,0)"
                            Dim str_sql48 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056046 & ",0,0,0)"
                            Dim str_sql49 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056047 & ",0,0,0)"
                            Dim str_sql50 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 6056048 & ",0,0,0)"
                            opr_Conexion.conectar()
                            trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando47 As OleDbCommand = New OleDbCommand(str_sql47, opr_Conexion.Conn_BD, trans)
                            Dim oComando48 As OleDbCommand = New OleDbCommand(str_sql48, opr_Conexion.Conn_BD, trans)
                            Dim oComando49 As OleDbCommand = New OleDbCommand(str_sql49, opr_Conexion.Conn_BD, trans)
                            Dim oComando50 As OleDbCommand = New OleDbCommand(str_sql50, opr_Conexion.Conn_BD, trans)
                            oComando47.ExecuteNonQuery()
                            oComando48.ExecuteNonQuery()
                            oComando49.ExecuteNonQuery()
                            oComando50.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 270
                            Dim str_sql51 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 2702007 & ",0,0,0)"
                            Dim str_sql52 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 2702008 & ",0,0,0)"
                            Dim str_sql53 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 2 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 2702010 & ",0,0,0)"
                            opr_Conexion.conectar()
                            trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando51 As OleDbCommand = New OleDbCommand(str_sql51, opr_Conexion.Conn_BD, trans)
                            Dim oComando52 As OleDbCommand = New OleDbCommand(str_sql52, opr_Conexion.Conn_BD, trans)
                            Dim oComando53 As OleDbCommand = New OleDbCommand(str_sql53, opr_Conexion.Conn_BD, trans)
                            oComando51.ExecuteNonQuery()
                            oComando52.ExecuteNonQuery()
                            oComando53.ExecuteNonQuery()
                            'sql_trans.Commit()

                        Case 800
                            Dim str_sql54 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8001001 & ",0,0,0)"
                            Dim str_sql55 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 1 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8001112 & ",0,0,0)"
                            Dim str_sql56 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 3 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8002007 & ",0,0,0)"
                            Dim str_sql57 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 4 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8002008 & ",0,0,0)"
                            Dim str_sql58 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 5 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8002010 & ",0,0,0)"
                            Dim str_sql59 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 6 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8005085 & ",0,0,0)"
                            Dim str_sql60 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 7 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8005087 & ",0,0,0)"
                            Dim str_sql61 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 8 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008083 & ",0,0,0)"
                            Dim str_sql62 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 9 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008084 & ",0,0,0)"
                            Dim str_sql63 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 10 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008085 & ",0,0,0)"
                            Dim str_sql64 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 11 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008086 & ",0,0,0)"
                            Dim str_sql65 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 12 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008087 & ",0,0,0)"
                            Dim str_sql66 As String = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) VALUES (" & LIS_ID + 13 & ", " & ped_id & ", '" & Format(opr_sis.ahora, "yyyy-MM-dd") & "', " & 8008088 & ",0,0,0)"
                            opr_Conexion.conectar()
                            trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                            Dim oComando54 As OleDbCommand = New OleDbCommand(str_sql54, opr_Conexion.Conn_BD, trans)
                            Dim oComando55 As OleDbCommand = New OleDbCommand(str_sql55, opr_Conexion.Conn_BD, trans)
                            Dim oComando56 As OleDbCommand = New OleDbCommand(str_sql56, opr_Conexion.Conn_BD, trans)
                            Dim oComando57 As OleDbCommand = New OleDbCommand(str_sql57, opr_Conexion.Conn_BD, trans)
                            Dim oComando58 As OleDbCommand = New OleDbCommand(str_sql58, opr_Conexion.Conn_BD, trans)
                            Dim oComando59 As OleDbCommand = New OleDbCommand(str_sql59, opr_Conexion.Conn_BD, trans)
                            Dim oComando60 As OleDbCommand = New OleDbCommand(str_sql60, opr_Conexion.Conn_BD, trans)
                            Dim oComando61 As OleDbCommand = New OleDbCommand(str_sql61, opr_Conexion.Conn_BD, trans)
                            Dim oComando62 As OleDbCommand = New OleDbCommand(str_sql62, opr_Conexion.Conn_BD, trans)
                            Dim oComando63 As OleDbCommand = New OleDbCommand(str_sql63, opr_Conexion.Conn_BD, trans)
                            Dim oComando64 As OleDbCommand = New OleDbCommand(str_sql64, opr_Conexion.Conn_BD, trans)
                            Dim oComando65 As OleDbCommand = New OleDbCommand(str_sql65, opr_Conexion.Conn_BD, trans)
                            Dim oComando66 As OleDbCommand = New OleDbCommand(str_sql66, opr_Conexion.Conn_BD, trans)
                            oComando54.ExecuteNonQuery()
                            oComando55.ExecuteNonQuery()
                            oComando56.ExecuteNonQuery()
                            oComando57.ExecuteNonQuery()
                            oComando58.ExecuteNonQuery()
                            oComando59.ExecuteNonQuery()
                            oComando60.ExecuteNonQuery()
                            oComando61.ExecuteNonQuery()
                            oComando62.ExecuteNonQuery()
                            oComando63.ExecuteNonQuery()
                            oComando64.ExecuteNonQuery()
                            oComando65.ExecuteNonQuery()
                            oComando66.ExecuteNonQuery()
                            'sql_trans.Commit()
                    End Select
                Else
                    opr_Conexion.conectar()
                    'trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                    str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, LIS_FECING, TES_ID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
                    "VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(Now, "yyyy-MM-dd") & "', " & tes_id & ",0,0,0)"
                    Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD, trans)
                    odc_pedido.ExecuteNonQuery()
                    'sql_trans.Commit()
                End If
            Else  'AUTOMATICA
                'EN QUE EQUIPO SE PROCESA?
                opr_Conexion.conectar()
                str_sql = "select equ_id from test_equipo where tes_id = " & tes_id & " and teq_estado = 1;"
                EQU_ID = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)

                'str_sql = "SELECT T.TIM_ID, TUB_DEFAULT, TT.TIM_ID FROM TESTEQUIPO_TIPMUESTRA AS TT, TEST_EQUIPO AS TE, TEST AS T " & _
                '        "WHERE T.TES_ID = TE.TES_ID And TT.TEQ_ID = TE.TEQ_ID And TE.TES_ID = " & tes_id & " And TEQ_ESTADO = 1 And TIM_DEFAULT = 1;"

                str_sql = "SELECT TIM_ID, 1, 1  FROM TEST WHERE TES_ID = " & tes_id & ""

                Dim oda_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteReader
                While oda_operacion.Read
                    TIM_ID = oda_operacion.GetValue(0).ToString
                    TUBO = oda_operacion.GetValue(1).ToString
                    EQUTIMID = oda_operacion.GetValue(2).ToString
                End While
                oda_operacion.Close()
                opr_Conexion.desconectar()
                'LIS_ID   (secuencial)
                'PED_ID    (fijo)
                'LIS_FECING (fecha actual)
                'TES_ID    (dato)
                'EQU_ID    (consulto *)
                'LIS_RESRANGO  ()
                'LIS_RESUNIDAD()
                'LIS_RESMANUAL ()
                'LIS_RESESTADO (0)
                'TIM_ID       (consulto)
                'LIS_POSNUM   ()
                'LIS_TUBO     (consulto)
                'PER_ID       ()
                'LIS_EQUTIMID  (consulto)
                'LIS_RACK     ()
                'LIS_EQUERROR  ()
                opr_Conexion.conectar()
                'trans = opr_Conexion.Conn_BD.BeginTransaction(IsolationLevel.ReadCommitted)
                str_sql = "INSERT INTO LISTA_TRABAJO (LIS_ID, PED_ID, " & _
                "LIS_FECING, TES_ID, EQU_ID, TIM_ID, LIS_TUBO,LIS_EQUTIMID,LIS_RESESTADO,LIS_RACK, LIS_POSNUM) " & _
                "VALUES (" & LIS_ID & ", " & ped_id & ", '" & Format(Now, "yyyy-MM-dd") & "', " & tes_id & "," & EQU_ID & ", " & TIM_ID & "," & TUBO & ", " & EQUTIMID & ",0,0,0);"
                Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD, trans)
                odc_pedido.ExecuteNonQuery()
                'INSERTA FORMATO EN RESPROCESADOS 
                Call InsertResProcesados(ped_id, tes_id)
                'sql_trans.Commit()
            End If
            'trans.Commit()
            Return True
        Catch
            'trans.Rollback()
            Return False
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, InsertLista_trabajo", Err)
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
            'pequeña operacion que volvera a insertar el registro en la tabla de la lista de trabajo
            k = k + 1
            If k <= 3 Then
                Call InsertLista_trabajo(ped_id, tes_id)
            Else
                Exit Function
            End If
        Finally
            opr_Conexion.desconectar()
        End Try
    End Function


#Region "Funciones nuevas LT"

    Private Function Valida_Electrolitos() As Boolean
        Dim opr_conexion As New Cls_Conexion()
        Dim odr As OleDbDataReader
        Dim i As Short = 0
        Dim str_sql1, str_sql2, str_sql3 As String
        Dim tmp1, tmp2, tmp3 As Byte
        str_sql1 = "select teq_estado as Estado from test_equipo where tes_id=1401172"
        str_sql2 = "select teq_estado as Estado from test_equipo where tes_id=1401181"
        str_sql3 = "select teq_estado as Estado from test_equipo where tes_id=1401188"

        opr_conexion.conectar()

        For i = 0 To 2
            Select Case i
                Case 0
                    odr = New OleDbCommand(str_sql1, opr_conexion.Conn_BD).ExecuteReader
                    While odr.Read
                        tmp1 = odr.GetValue(0)
                    End While
                    odr.Close()
                Case 1
                    odr = New OleDbCommand(str_sql2, opr_conexion.Conn_BD).ExecuteReader
                    While odr.Read
                        tmp2 = odr.GetValue(0)
                    End While
                    odr.Close()
                Case 2
                    odr = New OleDbCommand(str_sql3, opr_conexion.Conn_BD).ExecuteReader
                    While odr.Read
                        tmp3 = odr.GetValue(0)
                    End While
                    odr.Close()
            End Select
        Next
        opr_conexion.desconectar()
        If tmp1 = 0 Or tmp2 = 0 Or tmp3 = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function Consulta_TipoProces(ByVal tes_id As Integer) As Byte
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        Try
            opr_conexion.conectar()
            str_sql = "Select tes_tproces from TEST WHERE TES_ID = " & tes_id & ";"
            Consulta_TipoProces = CInt(New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteScalar)
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            opr_conexion.desconectar()
        End Try
    End Function

    Private Function Consulta_LISID() As Integer
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        Dim tmp As Integer
        Try
            opr_conexion.desconectar()
            opr_conexion.conectar()
            str_sql = "Select ISNULL(max(LIS_ID),'0') from LISTA_TRABAJO;"
            tmp = CInt(New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteScalar)
            Consulta_LISID = (tmp + 1)
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            opr_conexion.desconectar()
        End Try
    End Function

    Private Function Consulta_Equipo(ByVal tes_id As Integer) As Short
        Dim opr_conexion As New Cls_Conexion()
        Dim str_sql As String
        Try
            opr_conexion.conectar()
            str_sql = "select equ_id from test_equipo where tes_id = " & tes_id & " and teq_estado = 1;"
            Consulta_Equipo = CInt(New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteScalar)
            opr_conexion.desconectar()
            Exit Function
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Function

#End Region

    Public Sub InsertResProcesados(ByVal ped_id As Integer, ByVal tes_id As Integer)
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.conectar()
        Dim odc_pedido As OleDbCommand
        Dim INT_MUESTRA As Integer = 0
        Dim tes_abrev, equipo, sni_nombre As String
        Dim str_sql As String = "select teq_abrv_fija, equ_modelo, sni_nombre from test_equipo as te, equipo as e where te.equ_id = e.equ_id and tes_id = " & tes_id & ";"
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            tes_abrev = oda_operacion.GetValue(0).ToString
            equipo = oda_operacion.GetValue(1).ToString
            sni_nombre = oda_operacion.GetValue(2).ToString
        End While
        oda_operacion.Close()

        If (tes_abrev = "BIOMETRIA HEMATICA") Or (tes_abrev = "HGB") Or (tes_abrev = "HCT") Or (tes_abrev = "PLT") Or (tes_abrev = "FORMULA LEUCOCITARIA") Or (tes_abrev = "INDICES HEMATICOS") Then
            'JPO: en este caso se almacena la estructura original de la Biometria Hemática
            'y en caso de requerir cambios en los parametros de la BH se deberá cambiar 
            'tambien en la parte donde en caso de modificar el pedido (eliminar) y modificar 
            'lista de trabajo
            Dim str_resultados, str_datos() As String
            str_resultados = ""
            Dim x As Short = 0
            If Trim(Mid(equipo, 1, 150)) = "Cell Dyn 3500" Or Trim(Mid(equipo, 1, 150)) = "Cell Dyn 3700" Or Trim(Mid(equipo, 1, 150)) = "MaxM" And Trim(Mid(equipo, 1, 150)) = "CellTac F" Or Trim(Mid(equipo, 1, 150)) = "Celltac F" Then
                'En caso de alamcenar una prueba del cell dyn 3500 genero la siguiente estructura de biometria en la tabla RES_PROCESADOS
                'str_resultados = "WBC,NEU%25,LYM%25,MONO%25,EOS%25,BASO%25,NEU,LYM,MONO,EOS,BASO,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,MPV,PCT,PDW"
                'jpo: SE GRABARA TODA BIOMETRIA COMO QUE SE REALIZA EN EL CELLDYN 3700, PERO SE GRABA CON ESTRUCTURA BH BASICA DEL CD1700
                '
                str_resultados = "WBC,LY,MO,NE,EO,BA,LY%25,MO%25,NE%25,EO%25,BA%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,PCT,MPV,PDW"

            End If
            If Trim(Mid(equipo, 1, 150)) = "Cell Dyn 1700" Then
                'En caso de alamcenar una prueba del cell dyn 1700 genero la siguiente estructura de biometria en la tabla RES_PROCESADOS
                'str_resultados = "WBC,LYM%25,MID%25,GRN%25,LYM,MID,GRN,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT"
                str_resultados = "WBC,LY,MI,GR,LY%25,MI%25,GR%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,MPV"
            End If
            If Trim(Mid(equipo, 1, 150)) = "CellTac E" Or Trim(Mid(equipo, 1, 150)) = "Celltac E" Then
                'En caso de alamcenar una prueba del cell dyn 1700 genero la siguiente estructura de biometria en la tabla RES_PROCESADOS
                'str_resultados = "WBC,NE,LY,MO,EO,BA,NE%25,LY%25,MO%25,EO%25,BA%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,PCT,MPV,PDW"
                'str_resultados = "WBC,LY,MI,GR,LY%25,MI%25,GR%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,MPV"
                str_resultados = "WBC,LY,MO,NE,EO,BA,LY%25,MO%25,NE%25,EO%25,BA%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,PCT,MPV,PDW"
            End If
            str_datos = Split(str_resultados, ",")
            If tes_abrev = "BIOMETRIA HEMATICA" Then
                INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                For x = 0 To UBound(str_datos)
                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, '" & str_datos(x) & "', '" & sni_nombre & "', NULL, '',NULL, '', " & INT_MUESTRA & ")"
                    odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                    odc_pedido.ExecuteNonQuery()
                Next
            Else
                'JVA 06 NOV
                If tes_abrev = "HGB" Then 'HEMOGLOBINA
                    INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, '" & str_datos(12) & "', '" & sni_nombre & "', null, '',null, '', " & INT_MUESTRA & ")"
                    odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                    odc_pedido.ExecuteNonQuery()
                Else
                    If tes_abrev = "HCT" Then 'HEMATOCRITOS
                        INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                        str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, '" & str_datos(13) & "', '" & sni_nombre & "', null, '',null, '', " & INT_MUESTRA & ")"
                        odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                        odc_pedido.ExecuteNonQuery()
                    Else
                        If tes_abrev = "PLT" Then ' PLAQUETAS
                            INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                            str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, '" & str_datos(18) & "', '" & sni_nombre & "', null, '',null, '', " & INT_MUESTRA & ")"
                            odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                            odc_pedido.ExecuteNonQuery()
                        Else
                            If tes_abrev = "FORMULA LEUCOCITARIA" Then
                                INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                                For x = 6 To 10
                                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, '" & str_datos(x) & "', '" & sni_nombre & "', null, '',null, '', " & INT_MUESTRA & ")"
                                    odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                                    odc_pedido.ExecuteNonQuery()
                                Next
                            End If
                            If tes_abrev = "INDICES HEMATICOS" Then
                                INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                                For x = 14 To 16
                                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, '" & str_datos(x) & "', '" & sni_nombre & "', null, '',null, '', " & INT_MUESTRA & ")"
                                    odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                                    odc_pedido.ExecuteNonQuery()
                                Next
                            End If
                        End If
                    End If
                End If
            End If
        Else
            'En caso de ser una prueba diferente de la B.H. grabo en RES_PROCESADOS la prueba que espero se descarguen los resultados
            If tes_abrev = "UREA" Then
                INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, 'UREA', '" & sni_nombre & "', NULL, '',NULL, '', " & INT_MUESTRA & ")"
                odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                odc_pedido.ExecuteNonQuery()
                str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, 'BUN', '" & sni_nombre & "', NULL, NULL,'',NULL, '', " & INT_MUESTRA & ")"
                odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                odc_pedido.ExecuteNonQuery()
            Else
                INT_MUESTRA = LeerTipoMuestraTest(tes_id)
                str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", NULL, NULL, '" & tes_abrev & "', '" & sni_nombre & "', NULL, '',NULL, '', " & INT_MUESTRA & ")"
                odc_pedido = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
                odc_pedido.ExecuteNonQuery()
            End If
        End If
        opr_conexion.desconectar()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, InsertResProcesados", Err)
        Err.Clear()
    End Sub

    Public Function LeerTipoMuestraTest(ByVal tes_id As Integer) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.odbc_conn()
        LeerTipoMuestraTest = CInt(New OdbcCommand("Select ifnull(max(tim_id),0) from TEST WHERE TES_ID = " & tes_id & "", opr_Conexion.conn_odbc).ExecuteScalar)
        opr_Conexion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer tipo de muestra x Test, Cls_AS400", Err)
        Err.Clear()
    End Function

    Public Function codigoTest(ByVal test As String) As Integer
        'Devuelve el numero de registros del archivo MISDTL
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.odbc_conn()
        codigoTest = CInt(New OdbcCommand("select count(tes_id) from test where tes_nombre = '" & test & "';", opr_Conexion.conn_odbc).ExecuteScalar)
        If codigoTest > 0 Then
            codigoTest = CInt(New OdbcCommand("select tes_id from test where tes_nombre = '" & test & "';", opr_Conexion.conn_odbc).ExecuteScalar)
        End If
        opr_Conexion.odbc_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, CódigoTest", Err)
        Err.Clear()
    End Function

    Public Sub ActualizoRegistroLeido(ByVal orden_MIS As Long, ByVal tes_id As Integer)
        'se actualiza campo donde se indica que el registro ya ha sido cargado 
        Dim opr_sistema As New Cls_sistema()
        Dim opr_Conexion As New Cls_conexas400()
        Dim cc As iDB2Connection
        Dim trans As iDB2Transaction
        Dim cadena As String = CStr(Format(Now, "yyyyMMdd"))
        Dim examen, perfil As String
        Try
            perfil = consulta_perfil(tes_id)
            examen = consulta_examen(tes_id)
            Select Case examen
                Case 200
                    ActualizaRegistroMIS_BH(orden_MIS)
                Case 500
                    ActualizaRegistroMIS_EMO(orden_MIS)
                Case 400
                    ActualizaRegistroMIS_Rwidal(orden_MIS)
                Case 700
                    ActualizaRegistroMIS_GasesArteriales(orden_MIS)
                Case 710
                    ActualizaRegistroMIS_GasesVenosos(orden_MIS)
                Case 140
                    ActualizaRegistroMIS_Electrolitos(orden_MIS)
                Case 180
                    ActualizaRegistroMIS_AclaramientoCreatinina(orden_MIS)
                Case 605
                    ActualizaRegistroMIS_CitologiaMocoFecal(orden_MIS)
                Case 270
                    ActualizaRegistroMIS_CitologiaMocoNasal(orden_MIS)
                Case 800
                    ActualizaRegistroMIS_CitologicoCitoquimico(orden_MIS)
                Case Else
                    'sin transaccion
                    'Dim str_sql As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden_MIS & " AND DLCEXA = '" & CStr(examen) & "' and DLRESE='" & CStr(perfil) & "' "
                    'opr_Conexion.ConectarAS()
                    'Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.oConexion)
                    'odc_pedido.ExecuteNonQuery()
                    'opr_Conexion.desconectarAS()

                    'con transaccion
                    Dim cmd As iDB2Command
                    'Dim str_sql As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & " WHERE DLNUOR = " & orden_MIS & " AND DLCEXA = '" & CStr(examen) & "'"

                    Dim str_sql As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden_MIS & " AND DLCEXA = '" & CStr(examen) & "' "

                    cc = New iDB2Connection(g_str_idb2)
                    cmd = New iDB2Command()
                    Try
                        cc.Open()
                        trans = cc.BeginTransaction
                        cmd.Connection = cc
                        cmd.Transaction = trans
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = str_sql
                        cmd.ExecuteNonQuery()
                        trans.Commit()
                    Catch
                        trans.Rollback()
                        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroLeído", Err)
                        RutinaError(Err.Number, Err.Description)
                        Err.Clear()
                    Finally
                        cc.Close()
                    End Try
            End Select
            Exit Sub
        Catch
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroLeído", Err)
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Sub

    'Funcion nueva AT
    Public Function ActualizaRegistroMIS_BH(ByVal orden As Long)
        'actulizo los 22 parametros de la biometria en la tabla del MIS
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2001 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2002 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2003 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql4 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2004 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql5 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2005 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql6 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2006 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql7 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2007 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql8 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2008 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql9 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2009 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql10 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2010 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql11 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2011 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql12 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2012 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql13 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2015 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql14 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2018 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql15 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2021 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql16 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2024 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql17 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2027 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql18 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2029 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql19 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2030 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql20 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2033 & "' AND DLRESE='" & 200 & "' "
        '        Dim str_sql21 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2036 & "' AND DLRESE='" & 200 & "' "
        '        'Dim str_sql22 As String = "update " & g_ASLibreria & ".MISDTL SET DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2001 & "'"

        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()

        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        Dim odc_pedido4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.oConexion)
        '        odc_pedido4.ExecuteNonQuery()
        '        Dim odc_pedido5 As OleDbCommand = New OleDbCommand(str_sql5, opr_Conexion.oConexion)
        '        odc_pedido5.ExecuteNonQuery()
        '        Dim odc_pedido6 As OleDbCommand = New OleDbCommand(str_sql6, opr_Conexion.oConexion)
        '        odc_pedido6.ExecuteNonQuery()
        '        Dim odc_pedido7 As OleDbCommand = New OleDbCommand(str_sql7, opr_Conexion.oConexion)
        '        odc_pedido7.ExecuteNonQuery()
        '        Dim odc_pedido8 As OleDbCommand = New OleDbCommand(str_sql8, opr_Conexion.oConexion)
        '        odc_pedido8.ExecuteNonQuery()
        '        Dim odc_pedido9 As OleDbCommand = New OleDbCommand(str_sql9, opr_Conexion.oConexion)
        '        odc_pedido9.ExecuteNonQuery()
        '        Dim odc_pedido10 As OleDbCommand = New OleDbCommand(str_sql10, opr_Conexion.oConexion)
        '        odc_pedido10.ExecuteNonQuery()
        '        Dim odc_pedido11 As OleDbCommand = New OleDbCommand(str_sql11, opr_Conexion.oConexion)
        '        odc_pedido11.ExecuteNonQuery()
        '        Dim odc_pedido12 As OleDbCommand = New OleDbCommand(str_sql12, opr_Conexion.oConexion)
        '        odc_pedido12.ExecuteNonQuery()
        '        Dim odc_pedido13 As OleDbCommand = New OleDbCommand(str_sql13, opr_Conexion.oConexion)
        '        odc_pedido13.ExecuteNonQuery()
        '        Dim odc_pedido14 As OleDbCommand = New OleDbCommand(str_sql14, opr_Conexion.oConexion)
        '        odc_pedido14.ExecuteNonQuery()
        '        Dim odc_pedido15 As OleDbCommand = New OleDbCommand(str_sql15, opr_Conexion.oConexion)
        '        odc_pedido15.ExecuteNonQuery()
        '        Dim odc_pedido16 As OleDbCommand = New OleDbCommand(str_sql16, opr_Conexion.oConexion)
        '        odc_pedido16.ExecuteNonQuery()
        '        Dim odc_pedido17 As OleDbCommand = New OleDbCommand(str_sql17, opr_Conexion.oConexion)
        '        odc_pedido17.ExecuteNonQuery()
        '        Dim odc_pedido18 As OleDbCommand = New OleDbCommand(str_sql18, opr_Conexion.oConexion)
        '        odc_pedido18.ExecuteNonQuery()
        '        Dim odc_pedido19 As OleDbCommand = New OleDbCommand(str_sql19, opr_Conexion.oConexion)
        '        odc_pedido19.ExecuteNonQuery()
        '        Dim odc_pedido20 As OleDbCommand = New OleDbCommand(str_sql20, opr_Conexion.oConexion)
        '        odc_pedido20.ExecuteNonQuery()
        '        Dim odc_pedido21 As OleDbCommand = New OleDbCommand(str_sql21, opr_Conexion.oConexion)
        '        odc_pedido21.ExecuteNonQuery()

        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroLeído", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2001 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2002 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2003 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2004 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2005 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2006 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2007 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2008 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2009 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2010 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2011 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2012 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2015 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2018 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2021 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2024 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2027 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2029 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2030 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2033 & "' AND DLRESE='" & 200 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2036 & "' AND DLRESE='" & 200 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_EMO(ByVal orden As Long)
        'actulizo los 22 parametros del examen de orina general (fisico-quimico-sedimento)
        'On Error GoTo MsgError
        'Dim opr_sistema As New Cls_sistema()
        'Dim opr_Conexion As New Cls_conexas400()
        'Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        'Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5010 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5015 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5020 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql4 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5025 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql5 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5030 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql6 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5035 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql7 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5040 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql8 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5045 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql9 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5050 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql10 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5055 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql11 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5060 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql12 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5065 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql13 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5070 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql14 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5075 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql15 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5080 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql16 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5085 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql17 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5090 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql18 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5095 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql19 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5100 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql20 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5105 & "' AND DLRESE = '" & 500 & "' "
        'Dim str_sql21 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5087 & "' AND DLRESE = '" & 500 & "' "

        ''Conecto a la base de datos para actualizar campos
        'opr_Conexion.ConectarAS()

        'Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        'odc_pedido1.ExecuteNonQuery()
        'Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        'odc_pedido2.ExecuteNonQuery()
        'Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        'odc_pedido3.ExecuteNonQuery()
        'Dim odc_pedido4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.oConexion)
        'odc_pedido4.ExecuteNonQuery()
        'Dim odc_pedido5 As OleDbCommand = New OleDbCommand(str_sql5, opr_Conexion.oConexion)
        'odc_pedido5.ExecuteNonQuery()
        'Dim odc_pedido6 As OleDbCommand = New OleDbCommand(str_sql6, opr_Conexion.oConexion)
        'odc_pedido6.ExecuteNonQuery()
        'Dim odc_pedido7 As OleDbCommand = New OleDbCommand(str_sql7, opr_Conexion.oConexion)
        'odc_pedido7.ExecuteNonQuery()
        'Dim odc_pedido8 As OleDbCommand = New OleDbCommand(str_sql8, opr_Conexion.oConexion)
        'odc_pedido8.ExecuteNonQuery()
        'Dim odc_pedido9 As OleDbCommand = New OleDbCommand(str_sql9, opr_Conexion.oConexion)
        'odc_pedido9.ExecuteNonQuery()
        'Dim odc_pedido10 As OleDbCommand = New OleDbCommand(str_sql10, opr_Conexion.oConexion)
        'odc_pedido10.ExecuteNonQuery()
        'Dim odc_pedido11 As OleDbCommand = New OleDbCommand(str_sql11, opr_Conexion.oConexion)
        'odc_pedido11.ExecuteNonQuery()
        'Dim odc_pedido12 As OleDbCommand = New OleDbCommand(str_sql12, opr_Conexion.oConexion)
        'odc_pedido12.ExecuteNonQuery()
        'Dim odc_pedido13 As OleDbCommand = New OleDbCommand(str_sql13, opr_Conexion.oConexion)
        'odc_pedido13.ExecuteNonQuery()
        'Dim odc_pedido14 As OleDbCommand = New OleDbCommand(str_sql14, opr_Conexion.oConexion)
        'odc_pedido14.ExecuteNonQuery()
        'Dim odc_pedido15 As OleDbCommand = New OleDbCommand(str_sql15, opr_Conexion.oConexion)
        'odc_pedido15.ExecuteNonQuery()
        'Dim odc_pedido16 As OleDbCommand = New OleDbCommand(str_sql16, opr_Conexion.oConexion)
        'odc_pedido16.ExecuteNonQuery()
        'Dim odc_pedido17 As OleDbCommand = New OleDbCommand(str_sql17, opr_Conexion.oConexion)
        'odc_pedido17.ExecuteNonQuery()
        'Dim odc_pedido18 As OleDbCommand = New OleDbCommand(str_sql18, opr_Conexion.oConexion)
        'odc_pedido18.ExecuteNonQuery()
        'Dim odc_pedido19 As OleDbCommand = New OleDbCommand(str_sql19, opr_Conexion.oConexion)
        'odc_pedido19.ExecuteNonQuery()
        'Dim odc_pedido20 As OleDbCommand = New OleDbCommand(str_sql20, opr_Conexion.oConexion)
        'odc_pedido20.ExecuteNonQuery()
        'Dim odc_pedido21 As OleDbCommand = New OleDbCommand(str_sql21, opr_Conexion.oConexion)
        'odc_pedido21.ExecuteNonQuery()
        ''Desconecta de la base de datos
        'opr_Conexion.desconectarAS()
        'Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_EMO", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5010 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5015 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5020 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5025 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5030 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5035 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5040 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5045 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5050 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5055 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5060 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5065 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5070 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5075 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5080 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5085 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5087 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5090 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5095 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5100 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5105 & "' AND DLRESE = '" & 500 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5087 & "' AND DLRESE = '" & 500 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_Rwidal(ByVal orden As Long)
        'actulizo los 4 parametros de la reaccion de widall
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4040 & "' AND DLRESE = '" & 400 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4045 & "' AND DLRESE = '" & 400 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4050 & "' AND DLRESE = '" & 400 & "' "
        '        Dim str_sql4 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4055 & "' AND DLRESE = '" & 400 & "' "
        '        'Dim str_sql5 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4060 & "' AND DLRESE = '" & 400 & "' "
        '        'Dim str_sql6 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4065 & "' AND DLRESE = '" & 400 & "' "

        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()

        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        Dim odc_pedido4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.oConexion)
        '        odc_pedido4.ExecuteNonQuery()
        '        'Dim odc_pedido5 As OleDbCommand = New OleDbCommand(str_sql5, opr_Conexion.oConexion)
        '        'odc_pedido5.ExecuteNonQuery()
        '        'Dim odc_pedido6 As OleDbCommand = New OleDbCommand(str_sql6, opr_Conexion.oConexion)
        '        'odc_pedido6.ExecuteNonQuery()

        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_RWidall", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4040 & "' AND DLRESE = '" & 400 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4045 & "' AND DLRESE = '" & 400 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4050 & "' AND DLRESE = '" & 400 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 4055 & "' AND DLRESE = '" & 400 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_Electrolitos(ByVal orden As Long)
        'actulizo los 3 parametros de los electroltios (sodio, potasio, cloro)
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1172 & "' AND DLRESE = '" & 140 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1181 & "' AND DLRESE = '" & 140 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1188 & "' AND DLRESE = '" & 140 & "' "
        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()
        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_Electrolitos", Err)
        '        Err.Clear()}

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1172 & "' AND DLRESE = '" & 140 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1181 & "' AND DLRESE = '" & 140 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1188 & "' AND DLRESE = '" & 140 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_AclaramientoCreatinina(ByVal orden As Long)
        'actulizo los 4 parametros del aclaramiento o depuracion de creatinina 
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1045 & "' AND DLRESE = '" & 180 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1054 & "' AND DLRESE = '" & 180 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1239 & "' AND DLRESE = '" & 180 & "'"
        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()
        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_Electrolitos", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1045 & "' AND DLRESE = '" & 180 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1054 & "' AND DLRESE = '" & 180 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1239 & "' AND DLRESE = '" & 180 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)
    End Function

    Public Function ActualizaRegistroMIS_CitologiaMocoFecal(ByVal orden As Long)
        'actulizo los 4 parametros de la citologia de Moco Fecal
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6045 & "' AND DLRESE = '" & 605 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6046 & "' AND DLRESE = '" & 605 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6047 & "' AND DLRESE = '" & 605 & "' "
        '        Dim str_sql4 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6048 & "' AND DLRESE = '" & 605 & "' "
        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()
        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        Dim odc_pedido4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.oConexion)
        '        odc_pedido4.ExecuteNonQuery()
        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_CitologiaMocoFecal", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6045 & "' AND DLRESE = '" & 605 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6046 & "' AND DLRESE = '" & 605 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6047 & "' AND DLRESE = '" & 605 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 6048 & "' AND DLRESE = '" & 605 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_GasesArteriales(ByVal orden As Long)
        'actulizo los 7 parametros de los gases arteriales
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8200 & "' AND DLRESE = '" & 700 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8202 & "' AND DLRESE = '" & 700 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8204 & "' AND DLRESE = '" & 700 & "' "
        '        Dim str_sql4 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8206 & "' AND DLRESE = '" & 700 & "' "
        '        Dim str_sql5 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8208 & "' AND DLRESE = '" & 700 & "' "
        '        Dim str_sql6 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8210 & "' AND DLRESE = '" & 700 & "' "
        '        Dim str_sql7 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8212 & "' AND DLRESE = '" & 700 & "' "

        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()

        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        Dim odc_pedido4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.oConexion)
        '        odc_pedido4.ExecuteNonQuery()
        '        Dim odc_pedido5 As OleDbCommand = New OleDbCommand(str_sql5, opr_Conexion.oConexion)
        '        odc_pedido5.ExecuteNonQuery()
        '        Dim odc_pedido6 As OleDbCommand = New OleDbCommand(str_sql6, opr_Conexion.oConexion)
        '        odc_pedido6.ExecuteNonQuery()
        '        Dim odc_pedido7 As OleDbCommand = New OleDbCommand(str_sql7, opr_Conexion.oConexion)
        '        odc_pedido7.ExecuteNonQuery()

        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_GasesArteriales", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8200 & "' AND DLRESE = '" & 700 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8202 & "' AND DLRESE = '" & 700 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8204 & "' AND DLRESE = '" & 700 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8206 & "' AND DLRESE = '" & 700 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8208 & "' AND DLRESE = '" & 700 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8210 & "' AND DLRESE = '" & 700 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8212 & "' AND DLRESE = '" & 700 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_CitologiaMocoNasal(ByVal orden As Long)
        'actulizo los 3 parametros de la citologia de moco nasal
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2007 & "' AND DLRESE = '" & 270 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2008 & "' AND DLRESE = '" & 270 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2010 & "' AND DLRESE = '" & 270 & "' "
        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()

        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_GasesVenosos", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2007 & "' AND DLRESE = '" & 270 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2008 & "' AND DLRESE = '" & 270 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2010 & "' AND DLRESE = '" & 270 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_CitologicoCitoquimico(ByVal orden As Long)
        'actulizo los 12 parametros de la citologico citquimico
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1001 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1112 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2007 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql4 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2008 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql5 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2010 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql6 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5085 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql7 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5087 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql8 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8083 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql9 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8084 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql10 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8085 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql11 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8086 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql12 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8087 & "' AND DLRESE = '" & 800 & "' "
        '        Dim str_sql13 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8088 & "' AND DLRESE = '" & 800 & "' "
        '        'Dim str_sql14 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8120 & "' AND DLRESE = '" & 800 & "' "
        '        'Dim str_sql15 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8130 & "' AND DLRESE = '" & 800 & "' "

        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()

        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        Dim odc_pedido4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.oConexion)
        '        odc_pedido4.ExecuteNonQuery()
        '        Dim odc_pedido5 As OleDbCommand = New OleDbCommand(str_sql5, opr_Conexion.oConexion)
        '        odc_pedido5.ExecuteNonQuery()
        '        Dim odc_pedido6 As OleDbCommand = New OleDbCommand(str_sql6, opr_Conexion.oConexion)
        '        odc_pedido6.ExecuteNonQuery()
        '        Dim odc_pedido7 As OleDbCommand = New OleDbCommand(str_sql7, opr_Conexion.oConexion)
        '        odc_pedido7.ExecuteNonQuery()
        '        Dim odc_pedido8 As OleDbCommand = New OleDbCommand(str_sql8, opr_Conexion.oConexion)
        '        odc_pedido8.ExecuteNonQuery()
        '        Dim odc_pedido9 As OleDbCommand = New OleDbCommand(str_sql9, opr_Conexion.oConexion)
        '        odc_pedido9.ExecuteNonQuery()
        '        Dim odc_pedido10 As OleDbCommand = New OleDbCommand(str_sql10, opr_Conexion.oConexion)
        '        odc_pedido10.ExecuteNonQuery()
        '        Dim odc_pedido11 As OleDbCommand = New OleDbCommand(str_sql11, opr_Conexion.oConexion)
        '        odc_pedido11.ExecuteNonQuery()
        '        Dim odc_pedido12 As OleDbCommand = New OleDbCommand(str_sql12, opr_Conexion.oConexion)
        '        odc_pedido12.ExecuteNonQuery()
        '        Dim odc_pedido13 As OleDbCommand = New OleDbCommand(str_sql13, opr_Conexion.oConexion)
        '        odc_pedido13.ExecuteNonQuery()
        '        'Dim odc_pedido14 As OleDbCommand = New OleDbCommand(str_sql14, opr_Conexion.oConexion)
        '        'odc_pedido14.ExecuteNonQuery()
        '        'Dim odc_pedido15 As OleDbCommand = New OleDbCommand(str_sql15, opr_Conexion.oConexion)
        '        'odc_pedido15.ExecuteNonQuery()
        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_GasesVenosos", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1001 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 1112 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2007 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2008 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 2010 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5085 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 5087 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8083 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8084 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8085 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8086 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8087 & "' AND DLRESE = '" & 800 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8088 & "' AND DLRESE = '" & 800 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function ActualizaRegistroMIS_GasesVenosos(ByVal orden As Long)
        'actulizo los 7 parametros de los gases venosos
        '        On Error GoTo MsgError
        '        Dim opr_sistema As New Cls_sistema()
        '        Dim opr_Conexion As New Cls_conexas400()
        '        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))

        '        Dim str_sql1 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8300 & "' AND DLRESE = '" & 710 & "' "
        '        Dim str_sql2 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8302 & "' AND DLRESE = '" & 710 & "' "
        '        Dim str_sql3 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8304 & "' AND DLRESE = '" & 710 & "' "
        '        Dim str_sql4 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8306 & "' AND DLRESE = '" & 710 & "' "
        '        Dim str_sql5 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8308 & "' AND DLRESE = '" & 710 & "' "
        '        Dim str_sql6 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8310 & "' AND DLRESE = '" & 710 & "' "
        '        Dim str_sql7 As String = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8312 & "' AND DLRESE = '" & 710 & "' "

        '        'Conecto a la base de datos para actualizar campos
        '        opr_Conexion.ConectarAS()

        '        Dim odc_pedido1 As OleDbCommand = New OleDbCommand(str_sql1, opr_Conexion.oConexion)
        '        odc_pedido1.ExecuteNonQuery()
        '        Dim odc_pedido2 As OleDbCommand = New OleDbCommand(str_sql2, opr_Conexion.oConexion)
        '        odc_pedido2.ExecuteNonQuery()
        '        Dim odc_pedido3 As OleDbCommand = New OleDbCommand(str_sql3, opr_Conexion.oConexion)
        '        odc_pedido3.ExecuteNonQuery()
        '        Dim odc_pedido4 As OleDbCommand = New OleDbCommand(str_sql4, opr_Conexion.oConexion)
        '        odc_pedido4.ExecuteNonQuery()
        '        Dim odc_pedido5 As OleDbCommand = New OleDbCommand(str_sql5, opr_Conexion.oConexion)
        '        odc_pedido5.ExecuteNonQuery()
        '        Dim odc_pedido6 As OleDbCommand = New OleDbCommand(str_sql6, opr_Conexion.oConexion)
        '        odc_pedido6.ExecuteNonQuery()
        '        Dim odc_pedido7 As OleDbCommand = New OleDbCommand(str_sql7, opr_Conexion.oConexion)
        '        odc_pedido7.ExecuteNonQuery()

        '        'Desconecta de la base de datos
        '        opr_Conexion.desconectarAS()
        '        Exit Function
        'MsgError:
        '        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizoRegistroMIS_GasesVenosos", Err)
        '        Err.Clear()

        Dim opr_sistema As New Cls_sistema()
        Dim cadena As String = CStr(Format(opr_sistema.ahora, "yyyyMMdd"))
        Dim str_sql As String

        str_sql = "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8300 & "' AND DLRESE = '" & 710 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8302 & "' AND DLRESE = '" & 710 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8304 & "' AND DLRESE = '" & 710 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8306 & "' AND DLRESE = '" & 710 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8308 & "' AND DLRESE = '" & 710 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8310 & "' AND DLRESE = '" & 710 & "' || "
        str_sql = str_sql & "update " & g_ASLibreria & ".MISDTL SET DLFECD = " & CInt(cadena) & ", DLFEAM = " & CInt(cadena) & " WHERE DLNUOR = " & orden & " AND DLCEXA = '" & 8312 & "' AND DLRESE = '" & 710 & "' || "

        EjecutaActualizacioRegistrosMIS(str_sql)

    End Function

    Public Function EjecutaActualizacioRegistrosMIS(ByVal str_sql As String)
        Dim cmd As iDB2Command
        Dim sql() As String
        Dim cc As iDB2Connection
        Dim trans As iDB2Transaction
        Dim i, x As Integer

        sql = Split(str_sql, "||")
        x = (UBound(sql) - 1)

        Try
            cc = New iDB2Connection(g_str_idb2)
            cmd = New iDB2Command()
            cc.Open()
            trans = cc.BeginTransaction
            cmd.Connection = cc
            cmd.Transaction = trans
            cmd.CommandType = CommandType.Text
            For i = 0 To x
                cmd.CommandText = sql(i)
                cmd.ExecuteNonQuery()
            Next
            trans.Commit()
        Catch
            MsgBox(Err.Description)
            trans.Rollback()
            MsgBox("No pudo Actualizar Registro MIS", MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            cc.Close()
        End Try
    End Function

    Public Function EjecutaInsercionRegistrosMIS(ByVal str_sql As String)
        Dim cmd As iDB2Command
        Dim sql() As String
        Dim cc As iDB2Connection
        Dim trans As iDB2Transaction
        Dim i, x As Integer

        sql = Split(str_sql, "||")
        x = (UBound(sql) - 1)

        Try
            cc = New iDB2Connection(g_str_idb2)
            cmd = New iDB2Command()
            cc.Open()
            trans = cc.BeginTransaction
            cmd.Connection = cc
            cmd.Transaction = trans
            cmd.CommandType = CommandType.Text
            For i = 0 To x
                cmd.CommandText = sql(i)
                cmd.ExecuteNonQuery()
            Next
            trans.Commit()
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            trans.Rollback()
            MsgBox("No pudo Actualizar Registro MIS", MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            cc.Close()
        End Try
    End Function

    Public Function ConsultaOrdenMIS(ByVal ped_id As Long) As Long
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String = "select count(ped_id) from pedido where ped_id = " & ped_id & " and (PED_ORDEN <> '')"
        opr_Conexion.conectar()
        ConsultaOrdenMIS = CInt(New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteScalar)
        If ConsultaOrdenMIS > 0 Then
            STR_SQL = "select ped_orden from pedido where ped_id = " & ped_id & ";"
            ConsultaOrdenMIS = CInt(New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteScalar)
        End If
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, consutaOrdenMIS", Err)
        Err.Clear()
    End Function

    Public Function ConsultaHC(ByVal ped_id As Long) As Long
        On Error GoTo msgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "select pac_hist_clinica from pedido, paciente where paciente.pac_id=pedido.pac_id and pedido.ped_id = '" & ped_id & "'"
        opr_Conexion.conectar()
        ConsultaHC = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        opr_Conexion.desconectar()
        Exit Function
msgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, consulta Historia Clinica Paciente", Err)
        Err.Clear()
    End Function

    Public Function consultaTurno(ByVal ped_id As Long) As Long
        On Error GoTo msgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "select ped_turno from pedido where pedido.ped_id = '" & ped_id & "'"
        opr_Conexion.conectar()
        consultaTurno = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        opr_Conexion.desconectar()
        Exit Function
msgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, consulta Historia Clinica Paciente", Err)
        Err.Clear()
    End Function

    Public Function ConsultaHR(ByVal ped_id As Long, ByVal tes_id As Integer) As String
        On Error GoTo msgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim hora As String
        Dim str_sql As String = "select res_procesados.prc_hora from res_procesados, test_equipo where res_procesados.ped_id='" & ped_id & "' and test_equipo.tes_id='" & tes_id & "' and res_procesados.tes_abrev = test_equipo.teq_abrv_fija"
        opr_Conexion.conectar()
        hora = CStr(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        ConsultaHR = Mid(hora, 10, 2) + Mid(hora, 13, 2)
        opr_Conexion.desconectar()
        Exit Function
msgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, consulta hora resultado", Err)
        Err.Clear()
    End Function

    Public Function Consulta_Unidad(ByVal tes_id As Integer) As String
        On Error GoTo mensaje
        Dim str_sql As String = ""
        Dim opr_conexion As New Cls_Conexion()

        str_sql = "select uni_nomenclatura from test, unidad where tes_id='" & tes_id & "' and test.uni_id=unidad.uni_id "
        opr_conexion.conectar()
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            Consulta_Unidad = oda_operacion.GetValue(0).ToString
        End While
        opr_conexion.desconectar()
        If Consulta_Unidad = "--" Then
            Consulta_Unidad = ""
        End If
        Exit Function
mensaje:
        MsgBox("No se pudo realizar la operacion Consulta Unidad. ", MsgBoxStyle.Critical, "ANALISYS")
        Err.Clear()
    End Function

    Public Function ConsultaRanMin(ByVal tes_id As Long) As String
        On Error GoTo msgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "select teq_ranmin from test_equipo where tes_id = '" & tes_id & "'"
        Dim str_sql1 As String = "select rang_min from test_resultado where tes_id = '" & tes_id & "'"
        Dim str_sql2 As String = "select tes_tproces from test where tes_id= '" & tes_id & "' "
        Dim verifica As Integer
        'verifico el tipo de procesamiento del test
        'si es manual es 0 y si es automatica es 1
        opr_Conexion.conectar()
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(str_sql2, opr_Conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            verifica = oda_operacion.GetValue(0).ToString
        End While
        opr_Conexion.desconectar()
        'opr_Conexion.conectar()
        Select Case verifica
            Case 0
                'Ahora consulto el tipo de rango que posee el test
                'No posee -> 0, Unico -> 1, Multiple ->2
                Dim tipo_rango As Integer
                Dim str_sql_tr As String = "select rang_tipo from test_resultado where tes_id= '" & tes_id & "'"
                opr_Conexion.conectar()
                Dim oda_operacion1 As OleDbDataReader = New OleDbCommand(str_sql_tr, opr_Conexion.Conn_BD).ExecuteReader
                While oda_operacion1.Read
                    tipo_rango = oda_operacion1.GetValue(0).ToString
                End While
                oda_operacion1.Close()
                If tipo_rango = 1 Then
                    ConsultaRanMin = New OleDbCommand(str_sql1, opr_Conexion.Conn_BD).ExecuteScalar
                Else
                    ConsultaRanMin = ""
                End If
                opr_Conexion.desconectar()
            Case 1
                Dim verifica_2 As Integer = Consulta_Rango_Equipo(tes_id)
                Select Case verifica_2
                    Case 0
                        'MsgBox("La prueba es en equipo pero no tiene rangos")
                        ConsultaRanMin = ""
                    Case 1
                        'MsgBox("La prueba es en equipo y si tiene rangos unicos")
                        opr_Conexion.conectar()
                        ConsultaRanMin = New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar
                        opr_Conexion.desconectar()
                    Case 2
                        'MsgBox("la prueba es en equipo pero tiene rango multiple")
                        ConsultaRanMin = ""
                End Select
            Case Else
                ConsultaRanMin = ""
        End Select
        'opr_Conexion.desconectar()
        Exit Function
msgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, consulta rangos minimos pruebas", Err)
        Err.Clear()
    End Function

    Public Function Consulta_Rango_Equipo(ByVal tes_id As Integer) As Integer
        Try
            Dim str_sql As String
            Dim conexion As New Cls_Conexion()
            str_sql = "select teq_trango from test_equipo where tes_id='" & tes_id & "' "
            conexion.conectar()
            Dim oda_operacion As OleDbDataReader = New OleDbCommand(str_sql, conexion.Conn_BD).ExecuteReader
            While oda_operacion.Read
                Consulta_Rango_Equipo = oda_operacion.GetValue(0)
            End While
            conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo establecer rangos de prueba en equipo. ", MsgBoxStyle.Information, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function ConsultaRanMax(ByVal tes_id As Long) As String
        On Error GoTo msgError
        Dim opr_Conexion As New Cls_Conexion()
        'tes_id = 2030
        Dim str_sql As String = "select teq_ranmax from test_equipo where tes_id = '" & tes_id & "'"
        Dim str_sql1 As String = "select rang_max from test_resultado where tes_id = '" & tes_id & "'"
        Dim str_sql2 As String = "select tes_tproces from test where tes_id = '" & tes_id & "'"
        Dim verifica As Integer
        opr_Conexion.conectar()
        'ConsultaRanMax = New OledbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar
        'verifico el tipo de procesamiento del test
        'si es manual es 0 y si es automatica es 1
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(str_sql2, opr_Conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            verifica = oda_operacion.GetValue(0).ToString
        End While
        opr_Conexion.desconectar()
        'opr_Conexion.conectar()
        Select Case verifica
            Case 0
                'Ahora consulto el tipo de rango que posee el test
                'No posee -> 0, Unico -> 1, Multiple ->2
                Dim tipo_rango As Integer
                Dim str_sql_tr As String = "select rang_tipo from test_resultado where tes_id= '" & tes_id & "'"
                opr_Conexion.conectar()
                Dim oda_operacion1 As OleDbDataReader = New OleDbCommand(str_sql_tr, opr_Conexion.Conn_BD).ExecuteReader
                While oda_operacion1.Read
                    tipo_rango = oda_operacion1.GetValue(0).ToString
                End While
                oda_operacion1.Close()
                If tipo_rango = 1 Then
                    ConsultaRanMax = New OleDbCommand(str_sql1, opr_Conexion.Conn_BD).ExecuteScalar
                Else
                    ConsultaRanMax = ""
                End If
                opr_Conexion.desconectar()
            Case 1
                Dim verifica_2 As Integer = Consulta_Rango_Equipo(tes_id)
                Select Case verifica_2
                    Case 0
                        ConsultaRanMax = ""
                    Case 1
                        opr_Conexion.conectar()
                        ConsultaRanMax = New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar
                        opr_Conexion.desconectar()
                    Case 2
                        ConsultaRanMax = ""
                End Select
            Case Else
                ConsultaRanMax = ""
        End Select
        'opr_Conexion.desconectar()
        Exit Function
msgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operacion solicitada, consulta rangos maximos pruebas", Err)
        Err.Clear()
    End Function

    Public Function consultaCampo(ByVal orden As Long, ByVal tes_id As Integer) As String
        'On Error GoTo MsgError
        'Dim odr_operacion As OleDbDataReader
        'Dim OPR_CONEXION As New Cls_conexas400()
        'Dim temp As String
        'Select Case tes_id
        '    Case 34
        '        tes_id = 2012
        '    Case 400
        '        tes_id = 4045 'Or 4050 Or 4055 Or 4060 Or 4065
        '    Case 500
        '        tes_id = 5015
        'End Select
        'Dim str_sql As String = "select DLCOME from " & g_ASLibreria & ".MISDTL where DLNUOR=" & orden & " and DLCEXA= '" & tes_id & "' "
        'OPR_CONEXION.ConectarAS()
        'odr_operacion = New OleDbCommand(str_sql, OPR_CONEXION.oConexion).ExecuteReader
        'While odr_operacion.Read
        '    temp = odr_operacion.GetValue(0).ToString()
        '    consultaCampo = Mid(temp, 1, 10)
        'End While
        'OPR_CONEXION.desconectarAS()
        'Exit Function
        'MsgError:
        '        existe_error = True
        '        consultaCampo = "-1"
        '        MsgBox("No se pudo realizar la transaccion solicitada, ConsultaCampo" & Chr(13) & Err.Description, MsgBoxStyle.Critical, "ANALISYS")


        Dim ccon As iDB2Connection
        Dim odr As iDB2DataReader
        Dim str_sql As String
        Dim tmp As String
        Select Case tes_id
            Case 34
                tes_id = 2012
            Case 400
                tes_id = 4045
            Case 500
                tes_id = 5015
        End Select
        str_sql = "select DLCOME from " & g_ASLibreria & ".MISDTL where DLNUOR=" & orden & " and DLCEXA= '" & tes_id & "' "
        ccon = New iDB2Connection(g_str_idb2)
        Try
            ccon.Open()
            odr = New iDB2Command(str_sql, ccon).ExecuteReader
            While odr.Read
                tmp = odr.GetValue(0).ToString()
                consultaCampo = Mid(tmp, 1, 10)
            End While
            odr.Close()
        Catch
            existe_error = True
            consultaCampo = "-1"
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ccon.Close()
        End Try
    End Function

    Public Function meteCeroHC(ByVal HClinica As Long) As String
        Dim temporal As Integer = Len(CStr(HClinica))
        Select Case temporal
            Case 0
                meteCeroHC = "00000000"
            Case 1
                meteCeroHC = "0000000" + "" + CStr(HClinica)
            Case 2
                meteCeroHC = "000000" + "" + CStr(HClinica)
            Case 3
                meteCeroHC = "00000" + "" + CStr(HClinica)
            Case 4
                meteCeroHC = "0000" + "" + CStr(HClinica)
            Case 5
                meteCeroHC = "000" + "" + CStr(HClinica)
            Case 6
                meteCeroHC = "00" + "" + CStr(HClinica)
            Case 7
                meteCeroHC = "0" + "" + CStr(HClinica)
            Case 8
                meteCeroHC = HClinica
        End Select
    End Function

    Public Function meteCeroNTMIS(ByVal turno As Long) As String
        Dim temporal As Integer = Len(CStr(turno))
        Select Case temporal
            Case 0
                meteCeroNTMIS = "00000000"
            Case 1
                meteCeroNTMIS = "0000000" + "" + CStr(turno)
            Case 2
                meteCeroNTMIS = "000000" + "" + CStr(turno)
            Case 3
                meteCeroNTMIS = "00000" + "" + CStr(turno)
            Case 4
                meteCeroNTMIS = "0000" + "" + CStr(turno)
            Case 5
                meteCeroNTMIS = "000" + "" + CStr(turno)
            Case 6
                meteCeroNTMIS = "00" + "" + CStr(turno)
            Case 7
                meteCeroNTMIS = "0" + "" + CStr(turno)
            Case 8
                meteCeroNTMIS = turno
        End Select
    End Function

    Public Function meteCeroNOMIS(ByVal orden As Long) As String
        Dim temporal As Integer = Len(CStr(orden))
        Select Case temporal
            Case 0
                meteCeroNOMIS = "00000000"
            Case 1
                meteCeroNOMIS = "0000000" + "" + CStr(orden)
            Case 2
                meteCeroNOMIS = "000000" + "" + CStr(orden)
            Case 3
                meteCeroNOMIS = "00000" + "" + CStr(orden)
            Case 4
                meteCeroNOMIS = "0000" + "" + CStr(orden)
            Case 5
                meteCeroNOMIS = "000" + "" + CStr(orden)
            Case 6
                meteCeroNOMIS = "00" + "" + CStr(orden)
            Case 7
                meteCeroNOMIS = "0" + "" + CStr(orden)
            Case 8
                meteCeroNOMIS = orden
        End Select
    End Function

    Public Function consulta_perfil(ByVal tes_id As String) As String
        Try
            Select Case Len(tes_id)
                Case 8
                    consulta_perfil = Mid(tes_id, 1, 4)
                Case 7
                    consulta_perfil = Mid(tes_id, 1, 3)
                Case 3
                    consulta_perfil = tes_id
                Case 2
                    consulta_perfil = 0
                Case Else
                    consulta_perfil = 0
            End Select
            Exit Function
        Catch
            MsgBox("No se pudo ejecutar consulta", MsgBoxStyle.Exclamation, "ANALISYS")
        End Try
    End Function

    Public Function consulta_examen(ByVal tes_id As String) As String
        Try
            'Select Case Len(tes_id)
            '    Case 8
            '        consulta_examen = Mid(tes_id, 5, 8)
            '    Case 7
            '        consulta_examen = Mid(tes_id, 4, 7)
            '    Case 3
            '        consulta_examen = tes_id
            '    Case 2
            '        consulta_examen = tes_id
            '    Case Else
            '        consulta_examen = tes_id
            'End Select

            Dim opr_Conexion As New Cls_Conexion()
            Dim STR_SQL As String = "SELECT TES_OBS FROM TEST WHERE TES_ID = '" & tes_id & "'"
            opr_Conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
            While odr.Read
                consulta_examen = odr.GetValue(0)
            End While
            opr_Conexion.desconectar()
        Catch
            MsgBox("No se pudo ejecutar consulta", MsgBoxStyle.Exclamation, "ANALISYS")
        Finally
        End Try
    End Function

    Public Function INSERTRESMANUALVALIDADO(ByVal ped_id As Long, ByVal tes_id As Integer, ByVal res_man As String) As Boolean
        'INSERTA EL RESULTADO EN LA TABLA DTLMIS (ENVIA RESULTADO A MIS)
        Dim opr_sistema As New Cls_sistema()
        Dim opr_Conexion As New Cls_conexas400()
        Dim ORDEN As Long
        Dim HClinica As Long
        'Dim RangoMin, RangoMax As Double
        Dim RangoMin, RangoMax As String
        Dim HoraR, HoraR1, HoraR2, HoraRM As String
        Dim turno As Integer
        Dim opr_sis As New Cls_sistema()
        Dim fechaTrans As Date = opr_sis.ahora
        Dim fecha As Date = opr_sis.ahora
        Dim str_sql As String = ""
        Dim campo As String
        Dim Hcli, NOrd As String
        Dim unidad As String
        Dim test As String

        Try
            'tomo la fecha actual para grabar la fecha en el campo los resultados manuales
            HoraRM = Format(Now, "HHmm")
            'con esta funcion se consulta la unidad de los test
            unidad = Consulta_Unidad(tes_id)
            'con esta funcion consulto el rango minimo de la prueba realizada en equipo
            RangoMin = Mid(CStr(ConsultaRanMin(tes_id)), 1, 6)
            'esta funcion me devuelve el rango maximo de la prueba
            RangoMax = Mid(CStr(ConsultaRanMax(tes_id)), 1, 6) & " " & unidad
            'consulta el numero de orden del mis
            ORDEN = ConsultaOrdenMIS(ped_id)
            'Consulto la historia clinica del paciente
            HClinica = ConsultaHC(ped_id)
            'consulta la hora de resultado de una prueba procesadas en equipo y valido
            HoraR = Format(Now, "HHmm")
            'Funcion que me devuelve el numero de Turno para enviarlo al MIS
            turno = consultaTurno(ped_id)
            'consulta el codigo del test
            test = consulta_examen(tes_id)
            'Funciona que busca el dlpexa del misdtl para insertarlos en el dtlmis
            campo = consultaCampo(ORDEN, test)
            If campo = "-1" Then
                Exit Function
            End If

            If ORDEN <> 0 Then
                If Len(res_man) <= 10 Then 'inserto el resultado en el campo DLRESE
                    str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLRAMI, DLRAMA, DLRESE, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                      "values (" & ORDEN & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & RangoMin & "', '" & RangoMax & "' , '" & res_man & "','" & turno & "', " & HoraR & ", '" & g_str_login & "', '" & campo & "')"
                    opr_Conexion.ConectarAS()
                    Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.oConexion)
                    odc_pedido.ExecuteNonQuery()
                    opr_Conexion.desconectarAS()
                Else
                    Dim i As Short
                    Dim j As Double
                    Dim res_parcial As String
                    Dim odc_pedido As OleDbCommand
                    If Len(res_man) > 10 And Len(res_man) < 199 Then
                        res_parcial = Mid(res_man, (i * 199) + 1, 199)
                        str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                  "values (" & ORDEN & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & turno & ", " & HoraRM & ", '" & g_str_login & "',  '" & campo & "')"
                        opr_Conexion.ConectarAS()
                        odc_pedido = New OleDbCommand(str_sql, opr_Conexion.oConexion)
                        odc_pedido.ExecuteNonQuery()
                        opr_Conexion.desconectarAS()
                    Else
                        For i = 0 To (Len(res_man) \ 199) - 1
                            res_parcial = Mid(res_man, (i * 199) + 1, 199)
                            str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                      "values (" & ORDEN & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & turno & ", " & HoraRM & ", '" & g_str_login & "', '" & campo & "')"
                            opr_Conexion.ConectarAS()
                            odc_pedido = New OleDbCommand(str_sql, opr_Conexion.oConexion)
                            odc_pedido.ExecuteNonQuery()
                            opr_Conexion.desconectarAS()
                            If i = ((Len(res_man) \ 199) - 1) Then   'CUANDO ESTOY GRABANDO LA ULTIMA PARTE DEL FOR....YPUEDE HABER TODAVÍA UNA PARTE DE LA CADENA DE RESULTADOS QUE NO SE ALMACENA TODAVÍA
                                If (Len(res_man) Mod 199) > 0 Then
                                    res_parcial = Mid(res_man, ((i + 1) * 199) + 1, Len(res_man) - ((i + 1) * 199))
                                End If
                                str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                      "values (" & ORDEN & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & turno & ", " & HoraRM & ", '" & g_str_login & "', '" & campo & "')"
                                opr_Conexion.ConectarAS()
                                odc_pedido = New OleDbCommand(str_sql, opr_Conexion.oConexion)
                                odc_pedido.ExecuteNonQuery()
                                opr_Conexion.desconectarAS()
                            End If
                        Next
                    End If
                End If
                INSERTRESMANUALVALIDADO = True
            Else
                INSERTRESMANUALVALIDADO = False
            End If
            Exit Function
        Catch
            INSERTRESMANUALVALIDADO = False
            existe_error = True
            MsgBox("No se ha podido realizar la operación solicitada en el MIS." & Chr(13) & Err.Description, MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Function

    Public Function Busca_Datos_Test(ByVal TesId As String, ByVal ped_id As Integer) As DataSet
        Dim ocon As New Cls_Conexion()
        'Dim odr As OledbdataReader()
        Dim oda As New OleDbDataAdapter()
        Dim str_sql As String
        Dim dts_datos As DataSet
        Dim x As Short
        str_sql = "Select ifnull(equ_id,0) from lista_trabajo where tes_id='" & TesId & "' and ped_id = " & ped_id & ";"
        Try
            ocon.conectar()
            'Dim odr As OleDbDataReader = New OleDbCommand(str_sql, ocon.Conn_BD).ExecuteScalar
            x = New OleDbCommand(str_sql, ocon.Conn_BD).ExecuteScalar
            'While odr.Read
            '    x = odr.GetValue(0)
            'End While
            'odr.Close()
            ocon.desconectar()
            If x = 0 Then
                str_sql = "select u.uni_nomenclatura as Unidad, tr.rang_min as RanMin, tr.rang_max as RanMax " & _
                          "from test as t, unidad as u, test_resultado as tr " & _
                          "where t.uni_id=u.uni_id and t.tes_id=tr.tes_id " & _
                          "and t.tes_id='" & TesId & "' "
                ocon.conectar()
                oda.SelectCommand = New OleDbCommand(str_sql, ocon.Conn_BD)
                Busca_Datos_Test = New DataSet()
                oda.Fill(Busca_Datos_Test, "Registros")
                ocon.desconectar()
                Exit Function
            ElseIf x = 1 Then
                str_sql = "select u.uni_nomenclatura as Unidad, te.teq_ranmin as RanMin, te.teq_ranmax as RanMax " & _
                          "from test as t, unidad as u, test_equipo as te " & _
                          "where(t.uni_id = u.uni_id) and t.tes_id=te.tes_id " & _
                          "and t.tes_id='" & TesId & "' "
                ocon.conectar()
                oda.SelectCommand = New OleDbCommand(str_sql, ocon.Conn_BD)
                Busca_Datos_Test = New DataSet()
                oda.Fill(Busca_Datos_Test, "Registros")
                ocon.desconectar()
                Exit Function
            End If
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Function

    Public Function Busca_Datos_Pedido(ByVal PedId As String) As DataSet
        Dim ocon As New Cls_Conexion()
        Dim oda As New OleDbDataAdapter()
        Dim str_sql As String
        Dim dts_datos As DataSet
        Dim x As Short
        Try
            str_sql = "select p.ped_turno as Turno, p.ped_orden as Orden, pa.pac_hist_clinica as HC " & _
                      "from pedido as p, paciente as pa " & _
                      "where p.ped_id='" & PedId & "' and p.pac_id=pa.pac_id "
            ocon.conectar()
            oda.SelectCommand = New OleDbCommand(str_sql, ocon.Conn_BD)
            Busca_Datos_Pedido = New DataSet()
            oda.Fill(Busca_Datos_Pedido, "Registros")
            ocon.desconectar()
            Exit Function
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try

    End Function

    Public Function InsertResultadoMIS(ByVal ped_id As Long, ByVal tes_id As Integer, ByVal res_man As String, ByRef oCon As iDB2Connection, ByRef otrans As iDB2Transaction) As Boolean
        'INSERTA EL RESULTADO EN LA TABLA DTLMIS (ENVIA RESULTADO A MIS)
        Dim opr_sistema As New Cls_sistema()
        Dim opr_Conexion As New Cls_conexas400()
        Dim Conexion As iDB2Connection
        Dim odc As iDB2Command
        Dim Orden As Long
        Dim HClinica As Long
        Dim RangoMin, RangoMax As String
        Dim HoraR, HoraR1, HoraR2, HoraRM As String
        Dim Turno As Integer
        Dim opr_sis As New Cls_sistema()
        Dim fechaTrans As Date = opr_sis.ahora
        Dim fecha As Date = opr_sis.ahora
        Dim str_sql As String = ""
        Dim unidad As String
        Dim campo As String
        Dim Hcli, NOrd As String
        Dim test As String
        Dim tmp As String

        Try
            ''tomo la fecha actual para grabar la fecha en el campo los resultados manuales
            HoraRM = Format(Now, "HHmm")
            ''con esta funcion se consulta la unidad de los test
            'unidad = Consulta_Unidad(tes_id)
            ''con esta funcion consulto el rango minimo de la prueba realizada en equipo
            'RangoMin = Mid(CStr(ConsultaRanMin(tes_id)), 1, 6)
            ''esta funcion me devuelve el rango maximo de la prueba
            'RangoMax = Mid(CStr(ConsultaRanMax(tes_id)), 1, 6) & " " & unidad
            ''consulta el numero de orden del mis
            'ORDEN = ConsultaOrdenMIS(ped_id)
            ''Consulto la historia clinica del paciente
            'HClinica = ConsultaHC(ped_id)
            ''consulta la hora de resultado de una prueba procesadas en equipo y valido
            HoraR = Format(Now, "HHmm")
            ''Funcion que me devuelve el numero de Turno Para enviarlo al MIS
            'turno = consultaTurno(ped_id)
            ''consulta el codigo del test
            test = consulta_examen(tes_id)
            ''Funciona que busca el dlpexa del misdtl para insertarlos en el dtlmis
            Dim dts_datos As DataSet
            Dim dtr As DataRow
            dts_datos = Busca_Datos_Test(tes_id, ped_id)
            If dts_datos.Tables(0).Rows.Count <> 0 Then
                For Each dtr In dts_datos.Tables(0).Rows
                    unidad = dtr("Unidad").ToString()
                    RangoMin = dtr("RanMin").ToString()
                    RangoMax = dtr("RanMax").ToString() & " " & unidad
                Next
            End If
            dts_datos.Reset()
            dts_datos = Busca_Datos_Pedido(ped_id)
            If dts_datos.Tables(0).Rows.Count <> 0 Then
                For Each dtr In dts_datos.Tables(0).Rows
                    Orden = dtr("Orden").ToString()
                    Turno = dtr("Turno").ToString()
                    HClinica = dtr("HC").ToString()
                Next
            End If
            dts_datos.Reset()
            campo = consulta_perfil(tes_id)
            'campo = consultaCampo(Orden, test)
            'If campo = "-1" Then
            '    Exit Function
            'End If

            Conexion = oCon
            If Conexion.State = ConnectionState.Open Then
                If Orden <> 0 Then
                    If Len(res_man) <= 10 Then 'inserto el resultado en el campo DLRESE
                        str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLRAMI, DLRAMA, DLRESE, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                  "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & RangoMin & "', '" & RangoMax & "' , '" & res_man & "','" & Turno & "', " & HoraR & ", '" & g_str_login & "', '" & campo & "') "
                        odc = New iDB2Command(str_sql, oCon, otrans)
                        odc.ExecuteNonQuery()
                    Else
                        Dim i As Short
                        Dim j As Double
                        Dim res_parcial As String
                        Dim odc_pedido As OleDbCommand
                        If Len(res_man) > 10 And Len(res_man) < 199 Then
                            res_parcial = Mid(res_man, (i * 199) + 1, 199)
                            str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                      "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & Turno & ", " & HoraRM & ", '" & g_str_login & "',  '" & campo & "') "
                            odc = New iDB2Command(str_sql, oCon, otrans)
                            odc.ExecuteNonQuery()
                        Else
                            For i = 0 To (Len(res_man) \ 199) - 1
                                res_parcial = Mid(res_man, (i * 199) + 1, 199)
                                str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                          "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & Turno & ", " & HoraRM & ", '" & g_str_login & "', '" & campo & "') "
                                odc = New iDB2Command(str_sql, oCon, otrans)
                                odc.ExecuteNonQuery()
                                If i = ((Len(res_man) \ 199) - 1) Then   'CUANDO ESTOY GRABANDO LA ULTIMA PARTE DEL FOR....YPUEDE HABER TODAVÍA UNA PARTE DE LA CADENA DE RESULTADOS QUE NO SE ALMACENA TODAVÍA
                                    If (Len(res_man) Mod 199) > 0 Then
                                        res_parcial = Mid(res_man, ((i + 1) * 199) + 1, Len(res_man) - ((i + 1) * 199))
                                    End If
                                    str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                          "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & Turno & ", " & HoraRM & ", '" & g_str_login & "', '" & campo & "') "
                                    odc = New iDB2Command(str_sql, oCon, otrans)
                                    odc.ExecuteNonQuery()
                                End If
                            Next
                        End If

                    End If
                    InsertResultadoMIS = True
                Else
                    InsertResultadoMIS = False
                End If
            End If
            opr_Conexion.desconectarAS()
            Exit Function
        Catch
            InsertResultadoMIS = False
            existe_error = True
            MsgBox("No se ha podido realizar la operación solicitada en el MIS." & Chr(13) & Err.Description, MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Function

    Public Function INSERTCULTIVO_MIS(ByVal ped_id As Long, ByVal tes_id As Integer, ByVal MICROORGANISMO As String, ByVal ANTIBIOTICO As String, ByVal INTERPRETACION As String, ByVal COMENT As String) As Boolean
        'INSERTA EL RESULTADO EN LA TABLA DTLMIS (ENVIA RESULTADO A MIS)
        On Error GoTo MSGERROR
        Dim ORDEN As Long
        Dim HClinica As Long
        Dim str_sql As String
        Dim horaRM As String
        'Dim Turno As Integer
        Dim opr_sis As New Cls_sistema()
        Dim opr_conexion As New Cls_conexas400()
        Dim turno As Integer
        Dim campo As String
        Dim Hcli, NOrd As String
        'hora = opr_sis.ahora.ToString
        'horaRM = Trim(Mid(hora, 11, 2) + "" + Mid(hora, 14, 2))
        'hora = Trim(Mid(opr_sis.ahora.ToString, 10, Len(opr_sis.ahora.ToString)))
        'If Len(hora) = 11 Then
        '    horaRM = Trim(Mid(hora, 1, 2) + "" + Mid(hora, 4, 2))
        'Else
        '    horaRM = Trim(Mid(hora, 1, 1) + "" + Mid(hora, 3, 2))
        'End If
        horaRM = Format(Now, "HHmm")
        ORDEN = ConsultaOrdenMIS(ped_id)
        'Turno = ConsultaTurno(ped_id)
        HClinica = ConsultaHC(ped_id)
        turno = consultaTurno(ped_id)
        campo = consultaCampo(ORDEN, tes_id)
        Dim micro As String = MICROORGANISMO.PadRight(59)


        Dim fecha As String = Format(opr_sis.ahora, "yyyyMMdd")
        If ORDEN <> 0 Then
            'str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLMICR, DLANTI, DLREAN, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
            '          "values (" & ORDEN & ", " & fecha & ", " & HClinica & " ,'" & tes_id & "', '" & MICROORGANISMO & "', '" & ANTIBIOTICO & "', '" & INTERPRETACION & "', " & turno & ", " & horaRM & ", '" & g_str_login & "',  '" & campo & "')"
            str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLCOME, DLMICR, DLANTI, DLREAN, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                "values (" & ORDEN & ", " & fecha & ", " & HClinica & " ,'" & tes_id & "', '" & COMENT & "','" & micro & "', '" & ANTIBIOTICO & "', '" & INTERPRETACION & "', " & turno & ", " & horaRM & ", '" & g_str_login & "',  '" & campo & "')"
            opr_conexion.ConectarAS()
            Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_conexion.oConexion)
            odc_pedido.ExecuteNonQuery()
            opr_conexion.desconectarAS()
            INSERTCULTIVO_MIS = True
            Hcli = meteCeroHC(HClinica)
            NOrd = meteCeroNOMIS(ORDEN)
            Call RutinaDTLC05(Hcli, NOrd)
        Else
            INSERTCULTIVO_MIS = False
        End If
        Exit Function
MSGERROR:
        INSERTCULTIVO_MIS = False
        Err.Clear()
        MsgBox("No se ha podido realizar la operación solicitada, INSERTCULTIVO_MIS", MsgBoxStyle.Information, "ANALISYS")
    End Function

    'funcion que envia la cabecera del cultivo (dlnuor, dlcexa, dlrese, dlcome, dltimu)
    'dlnuor -> numero de orden
    'dlcexa -> codigo del examen
    'dlrese -> A/B (valor fijo que especifica cultivo y antibiograma de...)
    'dlcome -> comentarios (familia, germen, contaje de colonias, otras observaciones)
    Public Function InsertaCabeceraCultivo_MIS(ByVal ped_id As Long, ByVal tes_id As Integer, ByVal familia As String, Optional ByVal germen As String = "", Optional ByVal beta As String = "", Optional ByVal blee As String = "", Optional ByVal obs As String = "", Optional ByVal contaje As String = "") As Boolean
        Try
            Dim ORDEN As Long
            Dim HClinica As Long
            Dim str_sql As String
            Dim str_sql1 As String
            Dim horaRM As String
            Dim opr_sis As New Cls_sistema()
            Dim opr_conexion As New Cls_conexas400()
            Dim turno As Integer
            Dim campo As String
            Dim Hcli, NOrd As String
            Dim rese As String = "A/B"
            Dim tipo_muestra As String
            Dim comentario As String
            Dim test As String
            Dim i As Short
            Dim j As Double
            Dim res_parcial As String

            horaRM = Format(Now, "HHmm")
            ORDEN = ConsultaOrdenMIS(ped_id)
            HClinica = ConsultaHC(ped_id)
            turno = consultaTurno(ped_id)
            'campo = consultaCampo(ORDEN, tes_id)
            campo = consulta_perfil(tes_id)
            test = consulta_examen(tes_id)
            tipo_muestra = busca_nombre_test(tes_id)
            Dim fecha As String = Format(opr_sis.ahora, "yyyyMMdd")
            If familia <> "" Then
                comentario = "Familia: " + familia
            End If
            If germen <> "" Then
                comentario = comentario + " Germen: " + germen
            End If
            If beta <> "" Then
                comentario = comentario + " Betalactamasa: " + beta
            End If
            If blee <> "" Then
                comentario = comentario + " Blee: " + blee
            End If
            If contaje <> "" Then
                comentario = comentario + " Contaje de Colonias: " + contaje
            End If
            If obs <> "" Then
                comentario = comentario + " Observaciones: " + obs
            End If
            If ORDEN <> 0 Then
                'Lcorrea 22/12/2008 :DTLMIS el campo DLCOME tiene maximo 200 caracteres y necesito enviars n veces para su transmisiòn 
                If Len(comentario) > 1 And Len(comentario) < 199 Then
                    res_parcial = Mid(comentario, (i * 199) + 1, 199)
                    str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLRESE, DLCOME, DLTIMU, DLPEXA) " & _
                     "Values(" & ORDEN & ", " & fecha & ", " & HClinica & " ,'" & test & "', '" & rese & "', '" & res_parcial & "', '" & tipo_muestra & "', '" & campo & "') "
                    opr_conexion.ConectarAS()
                    Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_conexion.oConexion)
                    odc_pedido.ExecuteNonQuery()
                    opr_conexion.desconectarAS()
                Else
                    For i = 0 To (Len(comentario) \ 199) - 1
                        res_parcial = Mid(comentario, (i * 199) + 1, 199)
                        str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLRESE, DLCOME, DLTIMU, DLPEXA) " & _
                         "Values(" & ORDEN & ", " & fecha & ", " & HClinica & " ,'" & test & "', '" & rese & "', '" & res_parcial & "', '" & tipo_muestra & "', '" & campo & "') "
                        opr_conexion.ConectarAS()
                        Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_conexion.oConexion)
                        odc_pedido.ExecuteNonQuery()
                        opr_conexion.desconectarAS()
                        If i = ((Len(comentario) \ 199) - 1) Then   'CUANDO ESTOY GRABANDO LA ULTIMA PARTE DEL FOR....YPUEDE HABER TODAVÍA UNA PARTE DE LA CADENA DE RESULTADOS QUE NO SE ALMACENA TODAVÍA
                            If (Len(comentario) Mod 199) > 0 Then
                                res_parcial = Mid(comentario, ((i + 1) * 199) + 1, Len(comentario) - ((i + 1) * 199))
                            End If
                            str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLRESE, DLCOME, DLTIMU, DLPEXA) " & _
                         "Values(" & ORDEN & ", " & fecha & ", " & HClinica & " ,'" & test & "', '" & rese & "', '" & res_parcial & "', '" & tipo_muestra & "', '" & campo & "') "
                            opr_conexion.ConectarAS()
                            odc_pedido = New OleDbCommand(str_sql, opr_conexion.oConexion)
                            odc_pedido.ExecuteNonQuery()
                            opr_conexion.desconectarAS()
                        End If
                    Next
                End If
            End If
            Return True
            Exit Function
        Catch
            existe_error = True
            'MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Return False
            MsgBox("No se pudo insertar la cabecera del cultivo. Inserta Cabecera Cultivo MIS ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    'funcion que envia la detalle en caso de que el cultivo tenga antibiograma(dlnuor, dlcexa, dlrese, dlcome, dltimu)
    'ped_id -> codigo del pedido
    'tes_id -> codigo del test
    'dlnuor -> numero de orden
    'dlcexa -> codigo del test
    'dlmicr -> nombre del germen
    'dlanti -> nombre del antibiotico
    'dlrean -> interpretacion del cultivo (Resistente, Intermedio, Sensible, No Estandarizado)
    Public Function InsertaDetalleCultivo_MIS(ByVal ped_id As Long, ByVal tes_id As Integer, Optional ByVal germen As String = "", Optional ByVal antibiotico As String = "", Optional ByVal interpretacion As String = "") As Boolean
        Try
            Dim opr_conexion As New Cls_conexas400()
            Dim opr_sis As New Cls_sistema()
            Dim str_sql As String
            Dim ORDEN As Long
            Dim HClinica As Long
            Dim str_sql1 As String
            Dim horaRM As String
            Dim turno As Integer
            Dim campo As String
            Dim test As String
            horaRM = Format(Now, "HHmm")
            ORDEN = ConsultaOrdenMIS(ped_id)
            HClinica = ConsultaHC(ped_id)
            turno = consultaTurno(ped_id)
            'campo = consultaCampo(ORDEN, tes_id)
            campo = consulta_perfil(tes_id)
            test = consulta_examen(tes_id)
            Dim fecha As String = Format(opr_sis.ahora, "yyyyMMdd")
            Dim l_resultado As Integer

            If ORDEN <> 0 Then
                str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLMICR, DLANTI, DLREAN, DLPEXA) " & _
                          "Values(" & ORDEN & ", " & fecha & ", " & HClinica & " ,'" & test & "', '" & germen & "', '" & antibiotico & "', '" & interpretacion & "', '" & campo & "') "
                opr_conexion.ConectarAS()
                Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_conexion.oConexion)
                odc_pedido.ExecuteNonQuery()
                opr_conexion.desconectarAS()
            End If
            Return True
            Exit Function
        Catch
            existe_error = True
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Return False
            MsgBox("No se pudo insertar el detalle del cultivo. Inserta Detalle Cultivo MIS ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    'funcion que dispara los resultados para su visualizacion en MIS - ATV 2006
    Public Function RutinaDTLC05(ByVal hclinica As String, ByVal numOrden As String)
        'On Error GoTo MsgError
        Dim opr_conexion As New Cls_conexas400()
        'Dim historia As ADODB.Parameter
        'Dim orden As ADODB.Parameter
        'Dim tipotransaccion As ADODB.Parameter
        'Dim oComando As ADODB.CommandClass
        Dim str_sql As String
        'Dim conexion As New ADODB.ConnectionClass()
        Dim Conexion As OleDbConnection
        Dim oComandoOle As New OleDb.OleDbCommand()
        Dim oParametro1 As New OleDb.OleDbParameter()
        Dim oParametro2 As New OleDb.OleDbParameter()

        Try
            'opr_conexion.ConectarAS()
            opr_conexion.ConectarAS()

            'str_sql = "{{CALL /QSYS.LIB/CEDOBJ.LIB/DTLC05.PGM(?, ?)}} "
            str_sql = "{{CALL /QSYS.LIB/" & g_ASRutina & ".LIB/" & g_ASPrograma & ".PGM(?, ?)}} "

            Conexion = opr_conexion.ConexionAS400

            If Conexion.State = ConnectionState.Open Then
                oComandoOle.Connection = Conexion
                oComandoOle.CommandText = str_sql
                oComandoOle.CommandType = CommandType.Text
                oParametro1.OleDbType = OleDbType.Char
                oParametro1.Direction = ParameterDirection.InputOutput
                oParametro1.ParameterName = "WXHIST"
                oParametro1.Value = hclinica
                oParametro1.Size = 8
                oParametro2.OleDbType = OleDbType.Char
                oParametro2.Direction = ParameterDirection.Input
                oParametro2.ParameterName = "WXNUOR"
                oParametro2.Value = numOrden
                oParametro2.Size = 8

                oComandoOle.Parameters.Add(oParametro1)
                oComandoOle.Parameters.Add(oParametro2)

                oComandoOle.Prepare()
                oComandoOle.ExecuteNonQuery()

                'grabo un registro de control 
                'del resultado que ha sido enviado
                inserta_Control(hclinica, numOrden)
            End If

            opr_conexion.desconectarAS()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
        Exit Function
        'MsgError:
        '        MsgBox("Error al enviar parametros a la rutina DTLC05", MsgBoxStyle.ApplicationModal, "ANALISYS")
    End Function

    'funcion que graba un registro de control de todos los resultados que se envian al MIS
    'despues de haber sido invocados por la funcion DTLC05 - ATV 16-03-2007
    Public Function inserta_Control(ByVal hclinica As String, ByVal numOrden As String)
        Try
            Dim opr_conexion As New Cls_Conexion()
            'Dim opr_sis As New Cls_sistema()
            Dim str_sql As String
            Dim fecha As Date
            fecha = Date.Now
            str_sql = "insert into control_MIS(res_fecenv, orden, hclinica) values('" & Format(fecha, "yyyy-MM-dd HH:mm") & "', '" & numOrden & "', '" & hclinica & "') "
            opr_conexion.conectar()
            Dim odc As OleDbCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
            odc.ExecuteNonQuery()
            opr_conexion.desconectar()
            Exit Function
        Catch
            'MsgBox(Err.Description)
            MsgBox("No se pudo grabar el registro de control de envio a MIS", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function
    'funcion que actualiza el campo que escribe la rutina dtlc05
    'Andres Toledo 07-02-2007
    Public Function actualiza_dlfecm(ByVal orden As String, ByVal hc As String)
        Dim oCon As iDB2Connection
        Dim otrans As iDB2Transaction
        Dim cmd As iDB2Command
        Dim str_sql As String
        str_sql = "update " & g_ASLibreria & ".DTLMIS set DLFECM=0 where DLNUOR=" & CInt(orden) & " and DLHIST=" & CInt(hc) & " "
        Try
            oCon = New iDB2Connection(g_str_idb2)
            cmd = New iDB2Command()
            oCon.Open()
            otrans = oCon.BeginTransaction
            cmd.Connection = oCon
            cmd.Transaction = otrans
            cmd.CommandType = CommandType.Text
            cmd.CommandText = str_sql
            cmd.ExecuteNonQuery()
            otrans.Commit()
        Catch
            otrans.Rollback()
            MsgBox("No se pudo actualizar el campo DLFECM en DTLMIS ", MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            oCon.Close()
            oCon = Nothing
        End Try
    End Function

    Public Function busca_nombre_test(ByVal tes_id As Integer) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDr As OleDbDataReader
            Dim str_sql As String
            str_sql = "select tes_nombre from test where tes_id='" & tes_id & "' "
            opr_conexion.conectar()
            oDr = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While oDr.Read
                busca_nombre_test = oDr.GetValue(0).ToString()
            End While
            opr_conexion.desconectar()
        Catch
            MsgBox("No pudo buscar el nombre del test. busca nombre test", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function codigoTestAuto(ByVal tes_abrev As String, ByVal tim_id As Short) As Integer
        'Funcion para la consultar el tes_id de una prueba automatica en función de su abreviatura y su muestra
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "select count(TE.TES_ID) from test_equipo AS TE, TEST AS T where T.TES_ID = TE.TES_ID AND teq_abrv_fija = '" & tes_abrev & "' AND TIM_ID = " & tim_id & ";"
        opr_Conexion.conectar()
        codigoTestAuto = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        If codigoTestAuto > 0 Then
            str_sql = "select TE.TES_ID from test_equipo AS TE, TEST AS T where T.TES_ID = TE.TES_ID AND teq_abrv_fija = '" & tes_abrev & "' AND TIM_ID = " & tim_id & " order by te.tes_id;"
            codigoTestAuto = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        End If
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, códigotestAuto", Err)
        Err.Clear()
    End Function

    'Public Sub imprimir_codigo(ByVal ped_id As Long, ByVal turno As Long, ByVal paciente As String, ByVal hc As String)
    '    '************************IMPRESION DE CODIGO DE BARRAS********************** JVA 16-01-06     
    '    Cursor.Current = Cursors.WaitCursor
    '    Dim str_imprimir, str_codigo_barras As String
    '    Dim dts_muestra As DataSet
    '    Dim dtr_fila As DataRow
    '    Dim opr_muestra As New Cls_Muestra()

    '    dts_muestra = selec_tubos(ped_id)
    '    'verifico en el app.config que modelo d codigo de barras

    '    str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
    '    str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
    '    If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
    '        Dim imp_archivo As FileStream = File.Create(str_imprimir)
    '        imp_archivo.Close()
    '    End If
    '    'abro un archivo para generar as lineas que me permitira imprimir un ocdigode barras
    '    FileOpen(1, str_imprimir, OpenMode.Output)
    '    Dim int_aux, i As Integer
    '    Dim str_cadena As String

    '    For Each dtr_fila In dts_muestra.Tables("Registros").Rows

    '        'linea obligatoria
    '        PrintLine(1, "")
    '        'Linea que limpia el buffer de la impresora (Impresoras Mod: TLP 2844)
    '        PrintLine(1, "N")
    '        'reseteo la impresora
    '        PrintLine(1, "OD")
    '        'tamaño horizontal
    '        'PrintLine(1, "q456") ' Etiquetas 
    '        'tamaño vertical
    '        PrintLine(1, "Q215,32+0")
    '        'estas tres lineas son obligatorias son seteos de la impresora
    '        PrintLine(1, "S2") 'S= velocidad
    '        PrintLine(1, "D8")  'D = Densidad
    '        PrintLine(1, "ZT")  'Z = Orientación de la impresión, T = desde el tope.
    '        str_cadena = CInt(turno)
    '        'mando a escrribir en letras normales el primer 1 en la cadena de parámetros de el tamaño del encabezado
    '        PrintLine(1, "LO6,37,430,2")
    '        'Líneas Verticales
    '        PrintLine(1, "LO49,1,2,200")
    '        PrintLine(1, "A23,150,3,3,1,2,R," & """" & str_cadena.ToString & """")
    '        PrintLine(1, "A250,200,0,1,1,1,N," & """" & dtr_fila(0).ToString & """") REM tubo
    '        PrintLine(1, "A420,75,1,1,1,1,N," & """" & Today & """")
    '        Dim TIPO_MUESTRA As Int64 'Variable para determinar el tipo de muestra a utilizar.
    '        TIPO_MUESTRA = opr_muestra.selec_muestra(ped_id, dtr_fila(0).ToString)

    '        str_cadena = Format(CInt(turno), "0000") & "-" & TIPO_MUESTRA

    '        'IMPRIME EL CÓDIGO DE BARRAS.
    '        PrintLine(1, "B94,60,0,3,2,7,110,N," & """" & str_cadena & """")

    '        'finalmente mando a imprimir los datos del paciente
    '        str_cadena = paciente
    '        If Len(str_cadena) > 20 Then
    '            str_cadena = str_cadena.Substring(0, 20)
    '        End If

    '        PrintLine(1, "A55,13,0,1,1,2,N," & """" & str_cadena.ToString & """")
    '        PrintLine(1, "A300,13,0,1,1,2,N," & """" & "HC:" & hc & """")
    '        PrintLine(1, "A55,200,0,2,1,1,N," & """HRGE""")
    '        PrintLine(1, "P1")
    '    Next
    '    'estas lineas son necesario para que la imrpesora regrese a su estado natura
    '    PrintLine(1, "")
    '    PrintLine(1, "OD")

    '    PrintLine(1, "S2")
    '    PrintLine(1, "D8")
    '    PrintLine(1, "ZT")
    '    FileClose(1)
    '    'mando a copiar el archivo generado en el puerto designado
    '    On Error Resume Next
    '    Dim str_var As String
    '    str_var = System.Configuration.ConfigurationSettings.AppSettings("Puerto")

    '    FileCopy(str_imprimir, str_var)

    '    Cursor.Current = Cursors.Default
    'End Sub

    Public Sub imprimir_codigo(ByVal ped_id As Long, ByVal turno As Long, ByVal paciente As String, ByVal hc As String, ByVal orden As String)
        '************************IMPRESION DE CODIGO DE BARRAS********************** JVA 16-01-06     
        Cursor.Current = Cursors.WaitCursor
        Dim str_imprimir, str_codigo_barras As String
        Dim dts_muestra As DataSet
        Dim dtr_fila As DataRow
        Dim opr_muestra As New Cls_Muestra()

        dts_muestra = selec_tubos(ped_id)
        'verifico en el app.config que modelo d codigo de barras

        str_imprimir = System.Configuration.ConfigurationSettings.AppSettings("source")
        str_codigo_barras = System.Configuration.ConfigurationSettings.AppSettings("codigo de barras")
        If Dir(Environment.CurrentDirectory & "\" & str_imprimir) = "" Then
            Dim imp_archivo As FileStream = File.Create(str_imprimir)
            imp_archivo.Close()
        End If
        'abro un archivo para generar as lineas que me permitira imprimir un ocdigode barras
        FileOpen(1, str_imprimir, OpenMode.Output)
        Dim int_aux, i As Integer
        Dim str_cadena As String

        For Each dtr_fila In dts_muestra.Tables("Registros").Rows

            'linea obligatoria
            PrintLine(1, "")
            'Linea que limpia el buffer de la impresora (Impresoras Mod: TLP 2844)
            PrintLine(1, "N")
            'reseteo la impresora
            PrintLine(1, "OD")
            'tamaño horizontal
            PrintLine(1, "q456") ' Etiquetas 
     
            'PrintLine(1, "Q232,32+0") ' 
            'PrintLine(1, "Q215,32+0")
            PrintLine(1, "Q215,32+0")
            'estas tres lineas son obligatorias son seteos de la impresora
            PrintLine(1, "S2") 'S= velocidad
            PrintLine(1, "D8")  'D = Densidad
            PrintLine(1, "ZT")  'Z = Orientación de la impresión, T = desde el tope.
            str_cadena = CInt(turno)
            'mando a escrribir en letras normales el primer 1 en la cadena de parámetros de el tamaño del encabezado
            'PrintLine(1, "LO6,37,430,2")
            PrintLine(1, "L49,37,430,2")
            'Líneas Verticales
            PrintLine(1, "LO49,1,2,200")
            'PrintLine(1, "A23,150,3,3,1,2,R," & """" & str_cadena.ToString & """")
            'PrintLine(1, "A23,180,3,1,1,1,N," & """" & dtr_fila(0).ToString & """")
            'cambio atv 04-11-06
            PrintLine(1, "A36,180,3,1,1,1,N," & """" & dtr_fila(0).ToString & """")
            'PrintLine(1, "A250,200,0,1,1,1,N," & """" & dtr_fila(0).ToString & """") REM tubo
            'PrintLine(1, "A420,75,1,1,1,1,N," & """" & Today & """")
            'cambio atv 04-11-06
            PrintLine(1, "A435,75,1,1,1,1,N," & """" & Today & """")

            Dim TIPO_MUESTRA As Int64 'Variable para determinar el tipo de muestra a utilizar.
            TIPO_MUESTRA = opr_muestra.selec_muestra(ped_id, dtr_fila(0).ToString)

            str_cadena = Format(CInt(turno), "0000") & "-" & TIPO_MUESTRA

            'IMPRIME EL CÓDIGO DE BARRAS.
            'PrintLine(1, "B75,60,0,3,2,7,110,N," & """" & str_cadena & """")
            'cambio atv 04-11-06
            PrintLine(1, "B70,60,0,3,2,7,110,N," & """" & str_cadena & """")
            'IMPRIME EL NUMERO DE TURNO
            'PrintLine(1, "A270,190,0,1,1,2,N," & """" & str_cadena & """") REM TURNO
            'cambio ATV 04-11-06
            PrintLine(1, "A310,190,0,1,1,2,N," & """" & str_cadena & """") REM TURNO
            'IMPRIME EL NUMERO DE ORDEN
            'PrintLine(1, "A75,190,0,1,1,2,N," & """" & orden & """") REM NO. ORDEN
            'cambio ATV 04-11-06
            PrintLine(1, "A90,190,0,1,1,2,N," & """" & orden & """") REM NO. ORDEN
            'finalmente mando a imprimir los datos del paciente
            str_cadena = paciente
            If Len(str_cadena) > 20 Then
                str_cadena = str_cadena.Substring(0, 20)
            End If
            'imprime el nombre y apellidos del paciente
            'PrintLine(1, "A55,13,0,1,1,2,N," & """" & str_cadena.ToString & """")
            'cambio atv 04-11-06
            PrintLine(1, "A90,13,0,1,1,2,N," & """" & str_cadena.ToString & """")
            'imprime la historia clinica del paciente
            'PrintLine(1, "A300,13,0,1,1,2,N," & """" & "HC:" & hc & """")
            'cambio atv 04-11-06
            PrintLine(1, "A320,13,0,1,1,2,N," & """" & "HC:" & hc & """")
            'PrintLine(1, "A55,200,0,2,1,1,N," & """HRGE""")
            PrintLine(1, "P1")
        Next
        'estas lineas son necesario para que la imrpesora regrese a su estado natura
        PrintLine(1, "")
        PrintLine(1, "OD")

        PrintLine(1, "q424") ' Etiqueta 
        PrintLine(1, "Q215,32+0")
        PrintLine(1, "S2")
        PrintLine(1, "D8")
        PrintLine(1, "ZT")
        FileClose(1)
        'mando a copiar el archivo generado en el puerto designado
        On Error Resume Next
        Dim str_var As String
        str_var = System.Configuration.ConfigurationSettings.AppSettings("Puerto")

        FileCopy(str_imprimir, str_var)

        Cursor.Current = Cursors.Default
    End Sub

    Public Function selec_tubos(ByVal ped_id As Long) As DataSet
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
        Dim STR_SQL As String
        opr_conexion.conectar()
        'STR_SQL = "SELECT TIT_NOMBRE, pee_cantidad FROM area, tipo_tubo, pedido_detalle, test, perfil_test, perfil WHERE test.ARE_ID=area.ARE_ID and area.TIT_ID=tipo_tubo.TIT_ID and perfil.PER_ID=perfil_test.PER_ID and test.TES_ID=perfil_test.TES_ID  and PED_ID=" & ped_id & " and pedido_detalle.PER_ID = perfil.PER_ID GROUP BY TIT_NOMBRE UNION SELECT TIT_NOMBRE, pee_cantidad FROM(test, pedido_detalle, area, tipo_tubo) WHERE(test.ARE_ID = area.ARE_ID And area.TIT_ID = tipo_tubo.TIT_ID And pedido_detalle.TES_ID = test.TES_ID And PED_ID = " & ped_id & ") GROUP BY TIT_NOMBRE"
        STR_SQL = "select tt.TIT_NOMBRE as TIT_NOMBRE, '1' as pee_cantidad from pedido_detalle as pd, test as t, tipo_muestra as tm, tipo_tubo as tt where t.tes_id = pd.tes_id and pd.ped_id = " & ped_id & " and t.tim_id = tm.tim_id and tm.tit_id = tt.tit_id GROUP BY TIT_NOMBRE"
        oda_operacion.SelectCommand = New OleDbCommand(STR_SQL, opr_conexion.Conn_BD)
        selec_tubos = New DataSet()
        oda_operacion.Fill(selec_tubos, "Registros")
        opr_conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Leer Detalle Pedido De Factura", Err)
        Err.Clear()
    End Function


    Public Function Cons_ResManSinVal(Optional ByVal ped_id As Integer = 0, Optional ByVal exp As Byte = 0, Optional ByVal TIPO As Byte = 3, Optional ByVal PARAMETRO1 As String = "", Optional ByVal PARAMETRO2 As String = "", Optional ByVal mes As Byte = 0) As DataSet
        'Funcion para la consultar resultados manuales de pruebas que no requieren validacion y que no han 
        'sido transmitidas al MIS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
        opr_Conexion.conectar()
        Dim str_sql As String = ""
        Dim str_aux As String
        If mes = 0 Then
            str_aux = ""
        Else
            If mes = 12 Then
                Dim fechaini, fechafin As Date
                Dim shr_dias As Short
                shr_dias = Date.DaysInMonth(Year(Now), Month(Now))
                fechaini = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-01"
                fechafin = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-" & CStr(shr_dias)
                'str_aux = " and lista_trabajo.LIS_FECING between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
                str_aux = " and lista_trabajo.LIS_FECING between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59' "
            Else
                str_aux = " and lista_trabajo.LIS_FECING between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
            End If

        End If


        Select Case TIPO
            Case 3
                If exp = 0 Then ' NO ES PARA EXPORTACION MANUAL
                    If ped_id = 0 Then
                        str_sql = "SELECT lista_trabajo.PED_ID, lista_trabajo.LIS_RESMANUAL, test.TES_NOMBRE, test.TES_ID, unidad.UNI_NOMENCLATURA, " & _
                            "lista_trabajo.LIS_FECING, pedido.PED_ORDEN, lista_trabajo.lis_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                            "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN " & _
                            "pedido ON lista_trabajo.PED_ID =  pedido.PED_ID WHERE ( lista_trabajo.EQU_ID IS NULL) AND ( lista_trabajo.TES_ID <> 1) AND ( test.TES_VALIDA = 0) AND ( lista_trabajo.LIS_RESESTADO = 2) " & _
                            "AND (test_resultado.RES_ID <> 8) and pedido.ped_orden is not NULL"
                    Else
                        str_sql = "SELECT lista_trabajo.PED_ID, lista_trabajo.LIS_RESMANUAL, test.TES_NOMBRE, test.TES_ID, unidad.UNI_NOMENCLATURA, " & _
                                        "lista_trabajo.LIS_FECING, pedido.PED_ORDEN, lista_trabajo.lis_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                        "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN " & _
                                        "pedido ON lista_trabajo.PED_ID =  pedido.PED_ID WHERE ( lista_trabajo.EQU_ID IS NULL) AND ( lista_trabajo.TES_ID <> 1) AND ( lista_trabajo.LIS_RESESTADO = 2) " & _
                                        "AND (test_resultado.RES_ID <> 8) and pedido.ped_orden is NULL and lista_trabajo.ped_id = " & ped_id & ";"
                    End If
                Else 'ES PARA EXPORTACION
                    str_sql = "SELECT lista_trabajo.PED_ID, lista_trabajo.LIS_RESMANUAL, test.TES_NOMBRE, test.TES_ID, unidad.UNI_NOMENCLATURA, " & _
                                        "lista_trabajo.LIS_FECING, pedido.PED_ORDEN, lista_trabajo.lis_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                        "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN " & _
                                        "pedido ON lista_trabajo.PED_ID =  pedido.PED_ID WHERE ( lista_trabajo.EQU_ID IS NULL) AND ( lista_trabajo.TES_ID <> 1) AND ( lista_trabajo.LIS_RESESTADO = 2 OR lista_trabajo.LIS_RESESTADO = 7) " & _
                                        "AND (test_resultado.RES_ID <> 8) and lista_trabajo.ped_id = " & ped_id & ";"
                End If
            Case 0   'por orden 
                str_sql = "SELECT lista_trabajo.PED_ID, lista_trabajo.LIS_RESMANUAL, test.TES_NOMBRE, test.TES_ID, unidad.UNI_NOMENCLATURA, " & _
                            "lista_trabajo.LIS_FECING, pedido.PED_ORDEN, lista_trabajo.lis_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                            "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN " & _
                            "pedido ON lista_trabajo.PED_ID =  pedido.PED_ID WHERE ( lista_trabajo.EQU_ID IS NULL) AND ( lista_trabajo.TES_ID <> 1) AND ( test.TES_VALIDA = 0) AND ( lista_trabajo.LIS_RESESTADO = 2) " & _
                            "AND (test_resultado.RES_ID <> 8)" & str_aux & " and pedido.ped_turno >= " & PARAMETRO1 & " and pedido.ped_turno <= " & PARAMETRO2 & ";"

            Case 1      'por fecha 
                'Dim fechai As Date = CDate(Mid(PARAMETRO1, 1, 9))
                'Dim fechaf As Date = Format(CDate(Mid(PARAMETRO2, 1, 9))
                str_sql = "SELECT lista_trabajo.PED_ID, lista_trabajo.LIS_RESMANUAL, test.TES_NOMBRE, test.TES_ID, unidad.UNI_NOMENCLATURA, " & _
                           "lista_trabajo.LIS_FECING, pedido.PED_ORDEN, lista_trabajo.lis_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                           "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN " & _
                           "pedido ON lista_trabajo.PED_ID =  pedido.PED_ID WHERE ( lista_trabajo.EQU_ID IS NULL) AND ( lista_trabajo.TES_ID <> 1) AND ( test.TES_VALIDA = 0) AND ( lista_trabajo.LIS_RESESTADO = 2) " & _
                           "AND (test_resultado.RES_ID <> 8) and pedido.ped_orden is not NULL and pedido.ped_fecing between '" & Format(CDate(PARAMETRO1), "yyyy-MM-dd") & " 00:00:00.000' and '" & Format(CDate(PARAMETRO2), "yyyy-MM-dd") & " 23:59:59.000'"
            Case 2
                str_sql = "SELECT lista_trabajo.PED_ID, lista_trabajo.LIS_RESMANUAL, test.TES_NOMBRE, test.TES_ID, unidad.UNI_NOMENCLATURA, " & _
                            "lista_trabajo.LIS_FECING, pedido.PED_ORDEN, lista_trabajo.lis_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                            "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN " & _
                            "pedido ON lista_trabajo.PED_ID =  pedido.PED_ID WHERE ( lista_trabajo.EQU_ID IS NULL) AND ( lista_trabajo.TES_ID <> 1) AND ( test.TES_VALIDA = 0) AND ( lista_trabajo.LIS_RESESTADO = 2) " & _
                            "AND (test_resultado.RES_ID <> 8);"

        End Select
        oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
        Cons_ResManSinVal = New DataSet()
        oda_operacion.Fill(Cons_ResManSinVal, "Registros")
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Cons_ResEQPSinVal", Err)
        Err.Clear()
    End Function


    Public Function Cons_ResEQPSinVal(Optional ByVal ped_id As Integer = 0, Optional ByVal exp As Byte = 0, Optional ByVal tipo As Byte = 3, Optional ByVal parametro1 As String = "", Optional ByVal parametro2 As String = "", Optional ByVal mes As Byte = 0) As DataSet
        'Funcion para la consultar resultados AUTOMATICOS de pruebas que no requieren validacion y que no han  
        'sido transmitidas al MIS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
        opr_Conexion.conectar()
        Dim str_sql As String = ""
        Dim str_aux As String = ""
        If mes = 0 Then
            str_aux = ""
        Else
            If mes = 12 Then
                Dim fechaini, fechafin As Date
                Dim shr_dias As Short
                shr_dias = Date.DaysInMonth(Year(Now), Month(Now))
                fechaini = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-01"
                fechafin = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-" & CStr(shr_dias)
                'str_aux = " and lista_trabajo.LIS_FECING between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
                str_aux = " and pedido.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59' "
            Else
                str_aux = " and pedido.ped_fecing between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
                'str_aux = " and pedido.ped_fecing between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
            End If
        End If

        Select Case tipo
            Case 3
                If exp = 0 Then  'NO  ES PARA EXPORTACION
                    If ped_id = 0 Then
                        str_sql = "SELECT res_procesados.PED_ID AS PED_ID, res_procesados.TES_ABREV ,res_procesados.PRC_RESFINAL AS RESULTADO,  test.TES_NOMBRE AS TES_NOMBRE, " & _
                                   "test_equipo.TES_ID,  unidad.UNI_NOMENCLATURA,  pedido.PED_FECING,  pedido.PED_ORDEN, res_procesados.tim_id as tim_id " & _
                                   "FROM unidad INNER JOIN sni INNER JOIN res_procesados ON  sni.SNI_NOMBRE =  res_procesados.SNI_NOMBRE INNER JOIN " & _
                                   "equipo ON  sni.SNI_NOMBRE =  equipo.SNI_NOMBRE INNER JOIN test_equipo ON  res_procesados.TES_ABREV =  test_equipo.TEQ_ABRV_FIJA AND " & _
                                   "equipo.EQU_ID =  test_equipo.EQU_ID INNER JOIN test ON  res_procesados.TIM_ID =  test.TIM_ID AND  test_equipo.TES_ID =  test.TES_ID ON " & _
                                   "unidad.UNI_ID =  test_equipo.UNI_ID INNER JOIN pedido ON  res_procesados.PED_ID =  pedido.PED_ID " & _
                                   "WHERE ( test.TES_VALIDA = 0) AND ( res_procesados.PRC_RESFINAL IS NOT NULL)"
                    Else
                        str_sql = "SELECT res_procesados.PED_ID AS PED_ID, res_procesados.TES_ABREV ,res_procesados.PRC_RESFINAL AS RESULTADO,  test.TES_NOMBRE AS TES_NOMBRE, " & _
                                               "test_equipo.TES_ID,  unidad.UNI_NOMENCLATURA,  pedido.PED_FECING,  pedido.PED_ORDEN, res_procesados.tim_id as tim_id " & _
                                               "FROM unidad INNER JOIN sni INNER JOIN res_procesados ON  sni.SNI_NOMBRE =  res_procesados.SNI_NOMBRE INNER JOIN " & _
                                               "equipo ON  sni.SNI_NOMBRE =  equipo.SNI_NOMBRE INNER JOIN test_equipo ON  res_procesados.TES_ABREV =  test_equipo.TEQ_ABRV_FIJA AND " & _
                                               "equipo.EQU_ID =  test_equipo.EQU_ID INNER JOIN test ON  res_procesados.TIM_ID =  test.TIM_ID AND  test_equipo.TES_ID =  test.TES_ID ON " & _
                                               "unidad.UNI_ID =  test_equipo.UNI_ID INNER JOIN pedido ON  res_procesados.PED_ID =  pedido.PED_ID " & _
                                               "WHERE ( res_procesados.PRC_RESFINAL IS NOT NULL) and (res_procesados.ped_id = " & ped_id & ");"
                    End If

                Else        ' ES PARA EXPORTACION
                    str_sql = "SELECT res_procesados.PED_ID AS PED_ID, res_procesados.TES_ABREV ,res_procesados.PRC_RESFINAL AS RESULTADO,  test.TES_NOMBRE AS TES_NOMBRE, " & _
                                           "test_equipo.TES_ID,  unidad.UNI_NOMENCLATURA,  pedido.PED_FECING,  pedido.PED_ORDEN, res_procesados.tim_id as tim_id " & _
                                           "FROM unidad INNER JOIN sni INNER JOIN res_procesados ON  sni.SNI_NOMBRE =  res_procesados.SNI_NOMBRE INNER JOIN " & _
                                           "equipo ON  sni.SNI_NOMBRE =  equipo.SNI_NOMBRE INNER JOIN test_equipo ON  res_procesados.TES_ABREV =  test_equipo.TEQ_ABRV_FIJA AND " & _
                                           "equipo.EQU_ID =  test_equipo.EQU_ID INNER JOIN test ON  res_procesados.TIM_ID =  test.TIM_ID AND  test_equipo.TES_ID =  test.TES_ID ON " & _
                                           "unidad.UNI_ID =  test_equipo.UNI_ID INNER JOIN pedido ON  res_procesados.PED_ID =  pedido.PED_ID " & _
                                           "WHERE ( res_procesados.PRC_RESFINAL IS NOT NULL) and (res_procesados.ped_id = " & ped_id & ");"
                End If
            Case 0
                str_sql = "SELECT res_procesados.PED_ID AS PED_ID, res_procesados.TES_ABREV ,res_procesados.PRC_RESFINAL AS RESULTADO,  test.TES_NOMBRE AS TES_NOMBRE, " & _
                                   "test_equipo.TES_ID,  unidad.UNI_NOMENCLATURA,  pedido.PED_FECING,  pedido.PED_ORDEN, res_procesados.tim_id as tim_id " & _
                                   "FROM unidad INNER JOIN sni INNER JOIN res_procesados ON  sni.SNI_NOMBRE =  res_procesados.SNI_NOMBRE INNER JOIN " & _
                                   "equipo ON  sni.SNI_NOMBRE =  equipo.SNI_NOMBRE INNER JOIN test_equipo ON  res_procesados.TES_ABREV =  test_equipo.TEQ_ABRV_FIJA AND " & _
                                   "equipo.EQU_ID =  test_equipo.EQU_ID INNER JOIN test ON  res_procesados.TIM_ID =  test.TIM_ID AND  test_equipo.TES_ID =  test.TES_ID ON " & _
                                   "unidad.UNI_ID =  test_equipo.UNI_ID INNER JOIN pedido ON  res_procesados.PED_ID =  pedido.PED_ID " & _
                                   "WHERE ( test.TES_VALIDA = 0) AND ( res_procesados.PRC_RESFINAL IS NOT NULL) " & str_aux & " and pedido.ped_turno >= " & parametro1 & " and pedido.ped_turno <= " & parametro2 & ";"
            Case 1
                str_sql = "SELECT res_procesados.PED_ID AS PED_ID, res_procesados.TES_ABREV ,res_procesados.PRC_RESFINAL AS RESULTADO,  test.TES_NOMBRE AS TES_NOMBRE, " & _
                                       "test_equipo.TES_ID,  unidad.UNI_NOMENCLATURA,  pedido.PED_FECING,  pedido.PED_ORDEN, res_procesados.tim_id as tim_id " & _
                                       "FROM unidad INNER JOIN sni INNER JOIN res_procesados ON  sni.SNI_NOMBRE =  res_procesados.SNI_NOMBRE INNER JOIN " & _
                                       "equipo ON  sni.SNI_NOMBRE =  equipo.SNI_NOMBRE INNER JOIN test_equipo ON  res_procesados.TES_ABREV =  test_equipo.TEQ_ABRV_FIJA AND " & _
                                       "equipo.EQU_ID =  test_equipo.EQU_ID INNER JOIN test ON  res_procesados.TIM_ID =  test.TIM_ID AND  test_equipo.TES_ID =  test.TES_ID ON " & _
                                       "unidad.UNI_ID =  test_equipo.UNI_ID INNER JOIN pedido ON  res_procesados.PED_ID =  pedido.PED_ID " & _
                                       "WHERE ( test.TES_VALIDA = 0) AND ( res_procesados.PRC_RESFINAL IS NOT NULL) and pedido.ped_fecing between '" & Format(CDate(parametro1), "yyyy-MM-dd") & " 00:00:00.000' and '" & Format(CDate(parametro2), "yyyy-MM-dd") & " 23:59:59.000';"
            Case 2
                str_sql = "SELECT res_procesados.PED_ID AS PED_ID, res_procesados.TES_ABREV ,res_procesados.PRC_RESFINAL AS RESULTADO,  test.TES_NOMBRE AS TES_NOMBRE, " & _
                                   "test_equipo.TES_ID,  unidad.UNI_NOMENCLATURA,  pedido.PED_FECING,  pedido.PED_ORDEN, res_procesados.tim_id as tim_id " & _
                                   "FROM unidad INNER JOIN sni INNER JOIN res_procesados ON  sni.SNI_NOMBRE =  res_procesados.SNI_NOMBRE INNER JOIN " & _
                                   "equipo ON  sni.SNI_NOMBRE =  equipo.SNI_NOMBRE INNER JOIN test_equipo ON  res_procesados.TES_ABREV =  test_equipo.TEQ_ABRV_FIJA AND " & _
                                   "equipo.EQU_ID =  test_equipo.EQU_ID INNER JOIN test ON  res_procesados.TIM_ID =  test.TIM_ID AND  test_equipo.TES_ID =  test.TES_ID ON " & _
                                   "unidad.UNI_ID =  test_equipo.UNI_ID INNER JOIN pedido ON  res_procesados.PED_ID =  pedido.PED_ID " & _
                                   "WHERE ( test.TES_VALIDA = 0) AND ( res_procesados.PRC_RESFINAL IS NOT NULL);"
        End Select



        oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
        Cons_ResEQPSinVal = New DataSet()
        oda_operacion.Fill(Cons_ResEQPSinVal, "Registros")
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Cons_ResEQPSinVal", Err)
        Err.Clear()
    End Function

    Public Function LeerTestID(ByVal abrev As String, ByVal tim_id As Short) As Integer
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        str_sql = "select T.TES_ID from test_equipo as TE, test as T where TE.TEQ_ABRV_FIJA = '" & abrev & "' AND TE.TES_ID = T.TES_ID"
        opr_Conexion.conectar()
        oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            LeerTestID = 0
        Else
            LeerTestID = dts_datos.Tables(0).Rows(0).Item(0)
        End If
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Leer Test Id", Err)
        Err.Clear()
    End Function

    Public Function consultaestadoLT(ByVal lis_id As Long) As Short
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "Select lis_resestado from lista_trabajo where lis_id = " & lis_id & ";"
        opr_Conexion.conectar()
        consultaestadoLT = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, consultaEstadoLT", Err)
        Err.Clear()
    End Function



    Public Function Cons_ResCultSinVal(Optional ByVal ped_id As Integer = 0, Optional ByVal valida As Byte = 0, Optional ByVal EXP As Byte = 0, Optional ByVal tipo As Byte = 3, Optional ByVal parametro1 As String = "", Optional ByVal parametro2 As String = "", Optional ByVal mes As Byte = 0) As DataSet
        'Funcion para la consultar resultados de CULTIVOS que no requieren validacion y que no han 
        'sido transmitidas al MIS
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
        opr_Conexion.conectar()
        Dim str_sql As String = ""
        Dim str_aux As String = ""
        If mes = 0 Then
            str_aux = ""
        Else
            If mes = 12 Then
                Dim fechaini, fechafin As Date
                Dim shr_dias As Short
                shr_dias = Date.DaysInMonth(Year(Now), Month(Now))
                fechaini = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-01"
                fechafin = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-" & CStr(shr_dias)
                str_aux = " and pedido.ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59' "
            Else
                str_aux = " and pedido.ped_fecing between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
            End If
        End If

        Select Case tipo
            Case 3
                If EXP = 0 Then    ' NO PARA EXPORTACION MANUAL
                    If ped_id = 0 Then
                        str_sql = "SELECT      lista_trabajo.PED_ID,  lista_trabajo.LIS_RESMANUAL,  test.TES_NOMBRE,  test.TES_ID,  unidad.UNI_NOMENCLATURA, " & _
                                   "lista_trabajo.LIS_FECING,  pedido.PED_ORDEN,  lista_trabajo.LIS_ID,  m_resultado.MRE_OBS,  m_germen.GER_NOMBRE, " & _
                                   "m_germen_resultado.GRE_CONT, m_germen_resultado.gre_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                   "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN pedido ON  lista_trabajo.PED_ID =  pedido.PED_ID INNER JOIN " & _
                                   "m_resultado ON  test.TES_ID =  m_resultado.TES_ID AND  pedido.PED_ID =  m_resultado.PED_ID INNER JOIN " & _
                                   "m_germen_resultado ON  m_resultado.MRE_ID =  m_germen_resultado.MRE_ID INNER JOIN " & _
                                   "m_germen ON  m_germen_resultado.GER_ID =  m_germen.GER_ID " & _
                                   "WHERE (lista_trabajo.EQU_ID Is NULL) And (lista_trabajo.TES_ID <> 1) And (test.TES_VALIDA = " & valida & ") And (lista_trabajo.LIS_RESESTADO = 2) " & _
                                  "AND ( test_resultado.RES_ID = 8) AND (pedido.PED_ORDEN IS NOT NULL)"
                    Else
                        If valida = 0 Then
                            str_sql = "SELECT      lista_trabajo.PED_ID,  lista_trabajo.LIS_RESMANUAL,  test.TES_NOMBRE,  test.TES_ID,  unidad.UNI_NOMENCLATURA, " & _
                                   "lista_trabajo.LIS_FECING,  pedido.PED_ORDEN,  lista_trabajo.LIS_ID,  m_resultado.MRE_OBS,  m_germen.GER_NOMBRE, " & _
                                   "m_germen_resultado.GRE_CONT, m_germen_resultado.gre_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                   "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN pedido ON  lista_trabajo.PED_ID =  pedido.PED_ID INNER JOIN " & _
                                   "m_resultado ON  test.TES_ID =  m_resultado.TES_ID AND  pedido.PED_ID =  m_resultado.PED_ID INNER JOIN " & _
                                   "m_germen_resultado ON  m_resultado.MRE_ID =  m_germen_resultado.MRE_ID INNER JOIN " & _
                                   "m_germen ON  m_germen_resultado.GER_ID =  m_germen.GER_ID " & _
                                   "WHERE (lista_trabajo.EQU_ID Is NULL) And (lista_trabajo.TES_ID <> 1) And (lista_trabajo.LIS_RESESTADO = 2) " & _
                                  "AND ( test_resultado.RES_ID = 8) AND (pedido.PED_ORDEN IS NULL) and (pedido.ped_id = " & ped_id & ");"
                        Else
                            str_sql = "SELECT      lista_trabajo.PED_ID,  lista_trabajo.LIS_RESMANUAL,  test.TES_NOMBRE,  test.TES_ID,  unidad.UNI_NOMENCLATURA, " & _
                                   "lista_trabajo.LIS_FECING,  pedido.PED_ORDEN,  lista_trabajo.LIS_ID,  m_resultado.MRE_OBS,  m_germen.GER_NOMBRE, " & _
                                   "m_germen_resultado.GRE_CONT, m_germen_resultado.gre_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                   "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN pedido ON  lista_trabajo.PED_ID =  pedido.PED_ID INNER JOIN " & _
                                   "m_resultado ON  test.TES_ID =  m_resultado.TES_ID AND  pedido.PED_ID =  m_resultado.PED_ID INNER JOIN " & _
                                   "m_germen_resultado ON  m_resultado.MRE_ID =  m_germen_resultado.MRE_ID INNER JOIN " & _
                                   "m_germen ON  m_germen_resultado.GER_ID =  m_germen.GER_ID " & _
                                   "WHERE (lista_trabajo.EQU_ID Is NULL) And (lista_trabajo.TES_ID <> 1) And (lista_trabajo.LIS_RESESTADO <> 0) " & _
                                  "AND ( test_resultado.RES_ID = 8) and (pedido.ped_id = " & ped_id & ");"
                        End If
                    End If
                Else    'PARA EXPORTACION MANUAL 
                    str_sql = "SELECT      lista_trabajo.PED_ID,  lista_trabajo.LIS_RESMANUAL,  test.TES_NOMBRE,  test.TES_ID,  unidad.UNI_NOMENCLATURA, " & _
                                               "lista_trabajo.LIS_FECING,  pedido.PED_ORDEN,  lista_trabajo.LIS_ID,  m_resultado.MRE_OBS,  m_germen.GER_NOMBRE, " & _
                                               "m_germen_resultado.GRE_CONT, m_germen_resultado.gre_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                               "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN pedido ON  lista_trabajo.PED_ID =  pedido.PED_ID INNER JOIN " & _
                                               "m_resultado ON  test.TES_ID =  m_resultado.TES_ID AND  pedido.PED_ID =  m_resultado.PED_ID INNER JOIN " & _
                                               "m_germen_resultado ON  m_resultado.MRE_ID =  m_germen_resultado.MRE_ID INNER JOIN " & _
                                               "m_germen ON  m_germen_resultado.GER_ID =  m_germen.GER_ID " & _
                                               "WHERE (lista_trabajo.EQU_ID Is NULL) And (lista_trabajo.TES_ID <> 1) And (lista_trabajo.LIS_RESESTADO <> 0) " & _
                                              "AND ( test_resultado.RES_ID = 8) and (pedido.ped_id = " & ped_id & ");"
                End If


            Case 0
                str_sql = "SELECt lista_trabajo.PED_ID,  lista_trabajo.LIS_RESMANUAL,  test.TES_NOMBRE,  test.TES_ID,  unidad.UNI_NOMENCLATURA, " & _
                                   "lista_trabajo.LIS_FECING,  pedido.PED_ORDEN,  lista_trabajo.LIS_ID,  m_resultado.MRE_OBS,  m_germen.GER_NOMBRE, " & _
                                   "m_germen_resultado.GRE_CONT, m_germen_resultado.gre_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                   "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN pedido ON  lista_trabajo.PED_ID =  pedido.PED_ID INNER JOIN " & _
                                   "m_resultado ON  test.TES_ID =  m_resultado.TES_ID AND  pedido.PED_ID =  m_resultado.PED_ID INNER JOIN " & _
                                   "m_germen_resultado ON  m_resultado.MRE_ID =  m_germen_resultado.MRE_ID INNER JOIN " & _
                                   "m_germen ON  m_germen_resultado.GER_ID =  m_germen.GER_ID " & _
                                   "WHERE (lista_trabajo.EQU_ID Is NULL) And (lista_trabajo.TES_ID <> 1) And (test.TES_VALIDA = " & valida & ") And (lista_trabajo.LIS_RESESTADO = 2 or lista_trabajo.LIS_RESESTADO = 6)" & _
                                  "AND ( test_resultado.RES_ID = 8) " & str_aux & " AND pedido.PED_turno >= '" & parametro1 & "' and pedido.PED_turno <= '" & parametro2 & "';"


            Case 1
                str_sql = "SELECT      lista_trabajo.PED_ID,  lista_trabajo.LIS_RESMANUAL,  test.TES_NOMBRE,  test.TES_ID,  unidad.UNI_NOMENCLATURA, " & _
                                   "lista_trabajo.LIS_FECING,  pedido.PED_ORDEN,  lista_trabajo.LIS_ID,  m_resultado.MRE_OBS,  m_germen.GER_NOMBRE, " & _
                                   "m_germen_resultado.GRE_CONT, m_germen_resultado.gre_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                   "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN pedido ON  lista_trabajo.PED_ID =  pedido.PED_ID INNER JOIN " & _
                                   "m_resultado ON  test.TES_ID =  m_resultado.TES_ID AND  pedido.PED_ID =  m_resultado.PED_ID INNER JOIN " & _
                                   "m_germen_resultado ON  m_resultado.MRE_ID =  m_germen_resultado.MRE_ID INNER JOIN " & _
                                   "m_germen ON  m_germen_resultado.GER_ID =  m_germen.GER_ID " & _
                                   "WHERE (lista_trabajo.EQU_ID Is NULL) And (lista_trabajo.TES_ID <> 1) And (test.TES_VALIDA = " & valida & ") And (lista_trabajo.LIS_RESESTADO = 2) " & _
                                  "AND ( test_resultado.RES_ID = 8) AND (pedido.PED_ORDEN IS NOT NULL) and pedido.ped_fecing between '" & Format(CDate(parametro1), "yyyy-MM-dd") & " 00:00:00.000' and  '" & Format(CDate(parametro2), "yyyy-MM-dd") & " 23:59:59.000'"

            Case 2
                str_sql = "SELECt lista_trabajo.PED_ID,  lista_trabajo.LIS_RESMANUAL,  test.TES_NOMBRE,  test.TES_ID,  unidad.UNI_NOMENCLATURA, " & _
                                  "lista_trabajo.LIS_FECING,  pedido.PED_ORDEN,  lista_trabajo.LIS_ID,  m_resultado.MRE_OBS,  m_germen.GER_NOMBRE, " & _
                                  "m_germen_resultado.GRE_CONT, m_germen_resultado.gre_id FROM unidad INNER JOIN test INNER JOIN lista_trabajo ON  test.TES_ID =  lista_trabajo.TES_ID ON  unidad.UNI_ID =  test.UNI_ID INNER JOIN " & _
                                  "test_resultado ON  test.TES_ID =  test_resultado.TES_ID INNER JOIN pedido ON  lista_trabajo.PED_ID =  pedido.PED_ID INNER JOIN " & _
                                  "m_resultado ON  test.TES_ID =  m_resultado.TES_ID AND  pedido.PED_ID =  m_resultado.PED_ID INNER JOIN " & _
                                  "m_germen_resultado ON  m_resultado.MRE_ID =  m_germen_resultado.MRE_ID INNER JOIN " & _
                                  "m_germen ON  m_germen_resultado.GER_ID =  m_germen.GER_ID " & _
                                  "WHERE (lista_trabajo.EQU_ID Is NULL) And (lista_trabajo.TES_ID <> 1) And (test.TES_VALIDA = " & valida & ") And (lista_trabajo.LIS_RESESTADO = 2) " & _
                                 "AND ( test_resultado.RES_ID = 8);"

        End Select

        oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
        Cons_ResCultSinVal = New DataSet()
        oda_operacion.Fill(Cons_ResCultSinVal, "Registros")
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Cons_ResCultSinVal", Err)
        Err.Clear()
    End Function

    'funcion que consulta la cabecera de los cultivos
    Public Function LeerCabecera(ByVal ped_id As Long, ByVal tes_id As Integer, ByVal gre_id As Long) As DataSet
        Try
            Dim opr_Conexion As New Cls_Conexion()
            Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
            opr_Conexion.conectar()
            Dim str_sql As String = ""
            str_sql = "select a.*, f.fam_nombre as familia, g.ger_nombre as germen, b.gre_cont from m_resultado as a , m_germen_resultado as b, m_germen as g, m_familia as f " & _
                      "where a.ped_id = '" & ped_id & "' and a.tes_id = '" & tes_id & "' and a.mre_id =b.mre_id and g.ger_id = b.ger_id and g.fam_id = f.fam_id and b.gre_id='" & gre_id & "' "
            oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
            LeerCabecera = New DataSet()
            oda_operacion.Fill(LeerCabecera, "Datos")
            opr_Conexion.desconectar()
            Exit Function
        Catch
            g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, LeerCabecera", Err)
            Err.Clear()
        End Try
    End Function


    '    Public Function LeerAntibiograma(ByVal ped_id As Long, ByVal tes_id As Integer, ByVal gre_id As Integer) As DataSet
    '        On Error GoTo MsgError
    '        Dim opr_Conexion As New Cls_Conexion()
    '        Dim oda_operacion As oledbDataAdapter = New oledbDataAdapter()
    '        opr_Conexion.conectar()
    '        Dim str_sql As String = "select a.*, (f.fam_nombre + '   ' + g.ger_nombre) as ger_nombre, b.gre_cont, atb.ant_nombre, ab.atb_interpretacion " & _
    '        "from m_resultado as a , m_germen_resultado as b, m_germen as g, m_antibiograma as ab, " & _
    '        "m_antibiotico as atb, m_familia as f where ped_id = " & ped_id & " and tes_id = " & tes_id & " and a.mre_id =b.mre_id and g.ger_id = b.ger_id and " & _
    '        "b.gre_id = ab.gre_id and ab.ant_id = atb.ant_id and g.fam_id = f.fam_id and ab.gre_id = " & gre_id & ";"
    '        oda_operacion.SelectCommand = New OledbCommand(str_sql, opr_Conexion.Conn_BD)
    '        LeerAntibiograma = New DataSet()
    '        oda_operacion.Fill(LeerAntibiograma, "Datos2")
    '        opr_Conexion.desconectar()
    '        Exit Function
    'MsgError:
    '        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, LeerAntibiograma", Err)
    '        Err.Clear()
    '    End Function

    Public Function LeerAntibiograma(ByVal ped_id As Long, ByVal tes_id As Integer, ByVal gre_id As Integer) As DataSet
        Try
            Dim opr_Conexion As New Cls_Conexion()
            Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
            opr_Conexion.conectar()
            Dim str_sql As String
            str_sql = "select a.mre_id, a.tes_id, a.ped_id, g.ger_nombre as ger_nombre, atb.ant_nombre, ab.atb_interpretacion " & _
                      "from m_resultado as a , m_germen_resultado as b, m_germen as g, m_antibiograma as ab, m_antibiotico as atb, m_familia as f " & _
                      "where(ped_id = '" & ped_id & "' And tes_id = '" & tes_id & "' And a.mre_id = b.mre_id And g.ger_id = b.ger_id And b.gre_id = ab.gre_id) " & _
                      "and ab.ant_id = atb.ant_id and g.fam_id = f.fam_id and ab.gre_id = '" & gre_id & "' "
            oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
            LeerAntibiograma = New DataSet()
            oda_operacion.Fill(LeerAntibiograma, "Datos2")
            opr_Conexion.desconectar()
            Exit Function
        Catch
            g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, LeerAntibiograma", Err)
            Err.Clear()
        End Try
    End Function

    Public Function MaxTurno(ByVal fec_ped As Date) As Integer
        Dim opr_Conexion As New Cls_Conexion()
        'para turno mensual 
        'Dim fechaini, fechafin As Date
        'Dim shr_dias As Short
        'shr_dias = Date.DaysInMonth(Year(fec_ped), Month(fec_ped))
        'fechaini = CStr(Year(fec_ped)) & "-" & CStr(Month(fec_ped)) & "-01"
        'fechafin = CStr(Year(fec_ped)) & "-" & CStr(Month(fec_ped)) & "-" & CStr(shr_dias)
        'Dim str_sql As String = "select ifnull(max(ped_turno),0) from pedido where ped_fecing between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59';"
        'para turno diario 
        Dim str_sql As String = "select ifnull(max(ped_turno),0) from pedido where ped_fecing between '" & Format(Now, "yyyy-MM-dd") & " 00:00:00' and '" & Format(Now, "yyyy-MM-dd") & " 23:59:59';"
        Try
            opr_Conexion.odbc_conn()
            MaxTurno = CInt(New OdbcCommand(str_sql, opr_Conexion.conn_odbc).ExecuteScalar)
            opr_Conexion.odbc_desconn()
            Exit Function
        Catch
            g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, MaxTurno", Err)
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Function

    Public Function ConsultaPedidoAnalisys(ByVal ped_turno As Integer, ByVal fec_ped As Date) As DataSet
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
        opr_Conexion.conectar()
        Dim fechaini, fechafin As Date
        Dim shr_dias As Short
        shr_dias = Date.DaysInMonth(Year(fec_ped), Month(fec_ped))
        fechaini = CStr(Year(fec_ped)) & "-" & CStr(Month(fec_ped)) & "-01"
        fechafin = CStr(Year(fec_ped)) & "-" & CStr(Month(fec_ped)) & "-" & CStr(shr_dias)
        Dim str_sql As String = "select p.ped_id, lt.tes_id, t.tes_nombre, p.ped_orden, " & _
            "(pac.pac_apellido  + ' ' + pac.pac_nombre) as paciente, p.pac_id, p.ped_fecing  " & _
            "from pedido as p, test as t, lista_trabajo as lt, paciente as pac " & _
            "where p.ped_tipo = 'URGENCIA' and ped_turno = " & ped_turno & " and ped_fecing between '" & Format(fechaini, "yyyy-MM-dd") & " 00:00:00' and '" & Format(fechafin, "yyyy-MM-dd") & " 23:59:59' and " & _
            "p.ped_id =lt.ped_id and lt.tes_id = t.tes_id and pac.pac_id = p.pac_id and (lt.lis_resestado <> 7 or lt.lis_resestado <> 0);"
        oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
        ConsultaPedidoAnalisys = New DataSet()
        oda_operacion.Fill(ConsultaPedidoAnalisys, "Registros")
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, LeerAntibiograma", Err)
        Err.Clear()
    End Function

    Public Function Consulta_tipoResultado(ByVal tes_id As Integer) As Byte
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "select tes_tproces from test where tes_id = " & tes_id & ";"
        opr_Conexion.conectar()
        Consulta_tipoResultado = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, consulta_tiporesultado", Err)
        Err.Clear()
    End Function


    Public Function ConsultaAnalisysResMan(ByVal tes_id As Integer, ByVal ped_id As Integer) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String
        STR_SQL = "SELECT lis_resmanual FROM lista_trabajo WHERE TES_ID = " & tes_id & " and ped_id = " & ped_id & ";"
        opr_Conexion.conectar()
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            ConsultaAnalisysResMan = oda_operacion.GetValue(0).ToString
        End While
        oda_operacion.Close()
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, ConsultaResMan", Err)
        Err.Clear()
    End Function

    Public Sub ActualizaLTestado(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal estado As Short)
        On Error GoTo MsgError
        Dim opr_sis As New Cls_sistema()
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.conectar()
        Dim str_sql As String = "Update lista_trabajo set lis_Resestado = " & estado & " where ped_id = " & ped_id & " and tes_id = " & tes_id & ";"
        Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.desconectar()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizaLTestado", Err)
        Err.Clear()
    End Sub

    Public Function LeerTipoRes(ByVal tes_id As Integer) As Short
        'CONSULTA EL TIPO DE RESULTADO DE LA PRUEBA PARA SABER SI ES CULTIVO O NO 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "SELECT RES_ID FROM TEST_RESULTADO WHERE TES_ID = " & tes_id & ";"
        opr_Conexion.conectar()
        LeerTipoRes = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, consulta_tiporesultado", Err)
        Err.Clear()
    End Function

    Public Function consultaExisteSALA(ByVal sal_id As String) As Short
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = "Select COUNT(sal_id) from sala where sal_id = " & sal_id & ";"
        opr_Conexion.conectar()
        consultaExisteSALA = 0
        consultaExisteSALA = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, consultaEstadoLT", Err)
        Err.Clear()
    End Function

    Public Function ConsultaHCxpedido(ByVal pedido As Long) As String
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim STR_SQL As String = "select pac_hist_clinica from pedido, paciente where pedido.pac_id = paciente.pac_id and ped_id = " & pedido
        opr_Conexion.conectar()
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            ConsultaHCxpedido = oda_operacion.GetValue(0).ToString
        End While
        oda_operacion.Close()
        opr_Conexion.desconectar()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, ConsultaHCxpedido(", Err)
        Err.Clear()
    End Function

    Public Sub ActualizaOrdenMIS(ByVal ped_id As Integer, ByVal orden As String)
        On Error GoTo MsgError
        Dim opr_sis As New Cls_sistema()
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.conectar()
        Dim str_sql As String = "Update pedido set ped_orden = '" & orden & "' where ped_id = " & ped_id & ";"
        Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.desconectar()
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, ActualizaOrdenMIS", Err)
        Err.Clear()
    End Sub

    Public Sub Actualiza_Entrega_Resultados(ByVal pedido As Integer)
        On Error GoTo mensaje
        Dim str_sql As String = ""
        Dim opr_conexion As New Cls_Conexion()
        str_sql = "update pedido set ped_estado=5 where ped_id= '" & pedido & "'"
        opr_conexion.conectar()
        Dim odc_pedido As OleDbCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.desconectar()
        Exit Sub
mensaje:
        MsgBox("Error al actualizar el pedido, Actualiza_Entrega_Resultados", MsgBoxStyle.Exclamation, "ANALISYS")
    End Sub

    Public Sub envio_total_MIS(ByVal tipo As Byte, ByVal parametro1 As String, ByVal parametro2 As String, Optional ByVal mes As Byte = 0)
        Dim opr_AS400 As New Cls_AS400()
        Dim opr_sistema As New Cls_sistema()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim tes_id As Integer
        Dim status As Integer = 0
        Dim valida_exp As Integer = 0
        Dim res_man As String
        Dim hcli, orden, NOrd As Long
        Dim hclinica, numOrden As String
        Dim dtr_reg, dtr_test As DataRow
        Dim ped1 As String
        Dim cadena As String
        Dim boo_flag As Boolean = False
        Dim dts_pruebas As DataSet
        Dim res As Integer = 0
        Dim v_loop As Integer = 0
        ped1 = ""
        cadena = ""
        Try
            If MsgBox("Usted ha solicitado enviar al MIS todos los resultados" & Chr(13) & "validados, está seguro de continuar?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Dim dts_datos As DataSet = opr_AS400.Cons_ordenMIS(0, 0, tipo, parametro1, parametro2, mes)

                'conexion con MIS, con transaccion
                Dim oConexion As iDB2Connection
                Dim otrans As iDB2Transaction
                oConexion = New iDB2Connection(g_str_idb2)

                Try
                    oConexion.Open()
                    otrans = oConexion.BeginTransaction
                    If dts_datos.Tables(0).Rows.Count <> 0 Then
                        For Each dtr_reg In dts_datos.Tables("Registros").Rows
                            'Elimina examenes  existente en el MIS 


                            'BorraResultadoMIS(dtr_reg("ped_orden"))


                            'Inicializa el valida del status para de res_procesados = 6 y comenzar a 
                            valida_exp = 0
                            'VOY GRABANDO EN LA TABLA DTLMIS
                            cadena = cadena & "," & dtr_reg("ped_id")

                            'dts_pruebas = opr_AS400.llena_datos(CInt(dtr_reg("ped_orden")))


                            'Valida si la orden tiene test 
                            If dts_pruebas.Tables(0).Rows.Count <> 0 Then
                                'Recorre los test que pertenece a la orden 
                                For Each dtr_test In dts_pruebas.Tables("Registros").Rows
                                    If dtr_test("lis_resestado") <> 6 Then
                                        tes_id = (dtr_test("tes_id"))
                                        'opr_trabajo.CambioEstadoItemListaMIS(dtr_test("ped_id"), tes_id, 6, 0) 'CAMBIO A ESTADO 6 QUE SIGNIFICA EN PROCESO DE ENVIO AL MIS 
                                        'Asigna si el Manual - Automàtica - Cultivo 
                                        status = CInt(opr_AS400.asignar_status(tes_id, dtr_test("ped_id")))
                                        If status = 1 Or status = 2 Then
                                            If tes_id <> 0 And tes_id <> 200 Then
                                                res_man = consulta_resman(dtr_test("ped_id"), tes_id)
                                                If res_man <> "" And res_man <> "NULL" Then
                                                    If opr_AS400.InsertResultadoMIS(dtr_test("ped_id"), tes_id, res_man, oConexion, otrans) = True Then
                                                        opr_sistema.auditoria(dtr_test("ped_id"), tes_id, 11)
                                                    Else
                                                        opr_sistema.auditoria(dtr_test("ped_id"), tes_id, 5)
                                                    End If
                                                Else
                                                    If MsgBox("La orden " & dtr_reg("ped_turno") & "faltan paràmetros de la prueba , está seguro de continuar?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.No Then
                                                        Exit Sub
                                                    End If
                                                End If
                                            Else
                                                If tes_id = 200 Then
                                                    Dim j As Short
                                                    For j = 1 To 22S
                                                        Select Case j
                                                            Case 1
                                                                tes_id = "2002001"
                                                            Case 2
                                                                tes_id = "2002002"
                                                            Case 3
                                                                tes_id = "2002003"
                                                            Case 4
                                                                tes_id = "2002004"
                                                            Case 5
                                                                tes_id = "2002005"
                                                            Case 6
                                                                tes_id = "2002006"
                                                            Case 7
                                                                tes_id = "2002007"
                                                            Case 8
                                                                tes_id = "2002008"
                                                            Case 9
                                                                tes_id = "2002009"
                                                            Case 10
                                                                tes_id = "2002010"
                                                            Case 11
                                                                tes_id = "2002011"
                                                            Case 12
                                                                tes_id = "2002012"
                                                            Case 13
                                                                tes_id = "2002015"
                                                            Case 14
                                                                tes_id = "2002018"
                                                            Case 15
                                                                tes_id = "2002021"
                                                            Case 16
                                                                tes_id = "2002024"
                                                            Case 17
                                                                tes_id = "2002027"
                                                            Case 18
                                                                tes_id = "2002029"
                                                            Case 19
                                                                tes_id = "2002030"
                                                            Case 20
                                                                tes_id = "2002033"
                                                            Case 21
                                                                tes_id = "2002036"
                                                            Case 22
                                                                tes_id = "35"
                                                        End Select
                                                        res_man = opr_AS400.consulta_resman(dtr_test("ped_id"), tes_id)
                                                        If opr_AS400.InsertResultadoMIS(dtr_test("ped_id"), tes_id, res_man, oConexion, otrans) = True Then
                                                            opr_sistema.auditoria(dtr_test("ped_id"), tes_id, 11)
                                                        Else
                                                            opr_sistema.auditoria(dtr_test("ped_id"), tes_id, 5)
                                                        End If
                                                    Next
                                                End If
                                            End If
                                        Else
                                            If opr_AS400.validacion_antibiograma(dtr_test("ped_turno"), CStr(Month(dtr_test("ped_fecing")))) = False Then
                                                opr_sistema.auditoria(dtr_test("ped_id"), tes_id, 11)
                                            Else
                                                opr_sistema.auditoria(dtr_test("ped_id"), tes_id, 5)
                                            End If
                                        End If
                                    Else
                                        'Valida si es status de lis_resestado = 6 entoces no puedes realizar proceso de Importaciòn
                                        If valida_exp = 0 Then
                                            MsgBox("El turno " & dtr_reg("ped_turno") & " esta siendo procesada por otro usuario ", MsgBoxStyle.Information, "ANALISYS")
                                            valida_exp = 1
                                        End If
                                    End If
                                Next
                            End If
                            boo_flag = True
                        Next
                        otrans.Commit()
                    End If

                    'continuo proceso de presentacion de resultados en MIS
                    cadena = Mid(cadena, 2, Len(cadena))

                    If boo_flag = True Then
                        Dim ARR_AUX() As String
                        Dim i As Short
                        ARR_AUX = Split(cadena, ",")
                        For i = 0 To UBound(ARR_AUX)
                            res = res + 1
                            'Actualiza_Entrega_Resultados(ARR_AUX(i))
                            orden = Busca_Orden_Paciente(dtr_test("ped_id"))
                            hclinica = Busca_hClinica_Paciente(dtr_test("ped_id"))
                            hcli = meteCeroHC(hclinica)
                            numOrden = meteCeroNOMIS(CStr(orden))
                            'invoco a la rutina que dispara resultados en MIS
                            Call RutinaDTLC05(hcli, CStr(numOrden))
                            'Verifica errores en el archivo DTINCO
                            If opr_AS400.countregistrosDTINCO(numOrden) = 0 Then
                                For Each dtr_test In dts_pruebas.Tables("Registros").Rows
                                    tes_id = (dtr_test("tes_id"))
                                    opr_trabajo.CambioEstadoEnviadoMIS(dtr_test("ped_id"), tes_id, 6, 7) 'CAMBIO A ESTADO 6 QUE SIGNIFICA EN PROCESO DE ENVIO AL MIS 
                                Next
                                'Actualiza historia Clinica y Orden pero cuando se despues  que se verifique en el DTINCO
                                opr_AS400.actualiza_dlfecm(numOrden, hclinica)
                                v_loop = v_loop + 1
                            Else
                                For Each dtr_test In dts_pruebas.Tables("Registros").Rows
                                    tes_id = (dtr_test("tes_id"))
                                    opr_trabajo.CambioEstadoEnviadoMIS(dtr_test("ped_id"), tes_id, 6, 8) 'CAMBIO A ESTADO 6 QUE SIGNIFICA EN PROCESO DE ENVIO AL MIS 
                                Next
                                MsgBox("Problemas de transmisiòn en la orden " & CStr(orden) & ".", MsgBoxStyle.Information, "ANALISYS")
                            End If
                            'llamo a la funcion que verifica si se han reenviado resultados del paciente
                            Reenvia_Resultados_OrdenMIS(ARR_AUX(i))
                            boo_flag = False
                        Next
                    End If
                Catch
                    otrans.Rollback()
                    Me.Cursor = System.Windows.Forms.Cursors.Arrow
                    RutinaError(Err.Number, Err.Description)
                    Err.Clear()
                Finally
                    oConexion.Close()
                    oConexion = Nothing
                End Try
            End If
        Catch
            MsgBox("Se han enviado resultados al MIS, pero con advertencia de error.", MsgBoxStyle.Information, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Finally
            If v_loop = res Then
                'paso final: presentacion de mensaje de OK
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                MsgBox(" Operacion realizada satisfactoriamente, Resultados Enviados a MIS. ", MsgBoxStyle.Information, "ANALISYS")
            End If
        End Try
    End Sub

    Public Sub enviaMIS(ByVal tipo As Byte, ByVal parametro1 As String, ByVal parametro2 As String, Optional ByVal mes As Byte = 0)
        Dim ORDEN, HClinica As Long
        Dim HCli, NOrd As String
        Dim opr_trabajo As New Cls_Trabajo()
        Dim opr_sistema As New Cls_sistema()
        Dim boo_flag As Boolean = False
        Dim sql As String
        Dim tmp As String
        Try
            If MsgBox("Usted ha solicitado enviar al MIS todos los resultados" & Chr(13) & "validados, está seguro de continuar?", MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Dim opr_As400 As New Cls_AS400()
                'CONSULTO TODO LAS PRUEBAS MANUALES QUE NO REQUIEREN VALIDACION QUE ESTAN PENDIENTES DE TRANSMISION
                'EXCEPTO CULTIVOS
                Dim dts_datos As DataSet = opr_As400.Cons_ResManSinVal(0, 0, tipo, parametro1, parametro2, mes)
                Dim dtr_reg As DataRow
                Dim ped1, ped2 As String
                Dim cadena As String
                ped1 = ""
                ped2 = ""
                cadena = ""

                'conexion con MIS, con transaccion
                Dim oConexion As iDB2Connection
                Dim otrans As iDB2Transaction
                oConexion = New iDB2Connection(g_str_idb2)

                Try
                    oConexion.Open()
                    otrans = oConexion.BeginTransaction
                    If dts_datos.Tables(0).Rows.Count <> 0 Then
                        For Each dtr_reg In dts_datos.Tables("Registros").Rows
                            If IsDBNull(dtr_reg("LIS_RESMANUAL")) = False Then
                                'VOY GRABANDO EN LA TABLA DTLMIS
                                ped1 = dtr_reg("ped_id")
                                If ped2 <> "" Then
                                    If ped1 <> ped2 Then
                                        cadena = cadena & "," & ped2
                                    End If
                                End If
                                If InsertResultadoMIS(dtr_reg("ped_id"), dtr_reg("tes_id"), dtr_reg("LIS_RESMANUAL"), oConexion, otrans) = True Then
                                    ped2 = ped1
                                    opr_trabajo.CambioEstadoItemLista(dtr_reg("LIS_id"), 7)
                                    opr_sistema.auditoria(dtr_reg("ped_id"), dtr_reg("tes_id"), 4)
                                    boo_flag = True
                                Else
                                    opr_trabajo.CambioEstadoItemLista(dtr_reg("LIS_id"), 2)
                                    opr_sistema.auditoria(dtr_reg("ped_id"), dtr_reg("tes_id"), 5)
                                    boo_flag = False
                                End If
                            End If
                        Next
                        otrans.Commit()
                    End If
                Catch
                    otrans.Rollback()
                    Me.Cursor = System.Windows.Forms.Cursors.Arrow
                    RutinaError(Err.Number, Err.Description)
                    Err.Clear()
                Finally
                    oConexion.Close()
                    oConexion = Nothing
                End Try
                'continuo proceso de presentacion de resultados en MIS
                cadena = cadena & "," & ped2
                cadena = Mid(cadena, 2, Len(cadena))
                If boo_flag = True Then
                    Dim ARR_AUX() As String
                    Dim i As Short
                    ARR_AUX = Split(cadena, ",")
                    For i = 0 To UBound(ARR_AUX)
                        Actualiza_Entrega_Resultados(ARR_AUX(i))
                        ORDEN = ConsultaOrdenMIS(ARR_AUX(i))
                        HClinica = ConsultaHC(ARR_AUX(i))
                        HCli = meteCeroHC(HClinica)
                        NOrd = meteCeroNOMIS(ORDEN)
                        'actualizo los datos del campo dlfecm
                        Call actualiza_dlfecm(NOrd, HCli)
                        'invoco a la rutina que dispara resultados en MIS
                        Call RutinaDTLC05(HCli, NOrd)
                        'llamo a la funcion que verifica si se han reenviado resultados del paciente
                        Reenvia_Resultados_OrdenMIS(ARR_AUX(i))
                        boo_flag = False
                    Next
                End If
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                dts_datos.Reset()


                'CONSULTO TODO LAS PRUEBAS AUTOMATICAS QUE NO REQUIEREN VALIDACION QUE ESTAN PENDIENTES DE TRANSMISION
                '''frm_refer_main_form.escribemsj("ENVIANDO RESULTADOS EQP. AL MIS, ESPERE POR FAVOR")
                Dim int_lis_id As Integer
                dts_datos = opr_As400.Cons_ResEQPSinVal(0, 0, tipo, parametro1, parametro2, mes)
                For Each dtr_reg In dts_datos.Tables("Registros").Rows
                    int_lis_id = opr_trabajo.Leer_Lis_ID(CInt(dtr_reg("PED_ID")), dtr_reg("TES_ABREV"), dtr_reg("tim_id"))
                    If opr_As400.consultaestadoLT(int_lis_id) = 2 Then  'LA PRUEBA SE ENCUENTRA CONFIRMADA Y LISTA PARA ENVIO
                        'ENVIO AL MIS 
                        If opr_As400.INSERTRESMANUALVALIDADO(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("RESULTADO")) = True Then
                            'ACTUALIZO EL ESTADO DE LA LISTA DE TRABAJO A ESTADO 7 (ENVIADO A MIS)
                            opr_trabajo.CambioEstadoItemLista(int_lis_id, 7)
                            opr_sistema.auditoria(dtr_reg("PED_ID"), dtr_reg("TES_ID"), 4)
                        Else
                            opr_trabajo.CambioEstadoItemLista(int_lis_id, 2)
                            opr_sistema.auditoria(dtr_reg("PED_ID"), dtr_reg("TES_ID"), 5)
                        End If
                    End If
                Next
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                dts_datos.Reset()

                'nueva funcion que envia los cultivos y antibiogramas hacia MIS - Andres Toledo V. 08-01-2007
                dts_datos = opr_As400.Cons_ResCultSinVal(0, 0, 0, tipo, parametro1, parametro2, mes)
                Dim DTR_ANTIBIOTICO As DataRow
                Dim dts_antibiograma As DataSet
                Dim dts_cabecera As DataSet
                Dim boo_cultivo As Boolean = False
                Dim comentario As String = ""
                Dim coment_ant As String = ""
                Dim bandera As Boolean
                If dts_datos.Tables("Registros").Rows.Count <> 0 Then
                    For Each dtr_reg In dts_datos.Tables("Registros").Rows
                        'consulto la cabecera del cultivo
                        Dim dtr_cab As DataRow
                        dts_cabecera = opr_As400.LeerCabecera(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("gre_id"))
                        If dts_cabecera.Tables("Datos").Rows.Count <> 0 Then
                            For Each dtr_cab In dts_cabecera.Tables("Datos").Rows
                                'mando a grabar la cabecera del cultivo
                                If opr_As400.InsertaCabeceraCultivo_MIS(dtr_cab("ped_id"), dtr_cab("tes_id"), dtr_cab("familia").ToString, dtr_cab("germen").ToString, dtr_cab("mre_beta").ToString, dtr_cab("mre_blee").ToString, dtr_cab("mre_obs").ToString, dtr_cab("gre_cont").ToString) = True Then
                                    bandera = True
                                    'busco si tiene antibiograma este cultivo
                                    'consulto los resultados generales del cultivo y luego si tiene antibiograma 
                                    Dim dtr_det As DataRow
                                    dts_antibiograma = opr_As400.LeerAntibiograma(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("gre_id"))
                                    'comienzo a mandar a grabar al antibiograma en el mis
                                    If dts_antibiograma.Tables("Datos2").Rows.Count <> 0 Then
                                        For Each dtr_det In dts_antibiograma.Tables("Datos2").Rows
                                            'mando a grabar la cabecera del cultivo
                                            If opr_As400.InsertaDetalleCultivo_MIS(dtr_det("ped_id"), dtr_det("tes_id"), dtr_det("ger_nombre"), dtr_det("ant_nombre"), dtr_det("atb_interpretacion")) = True Then
                                                'cambio el estado del cultivo
                                                opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 7)
                                            Else
                                                'no se grabo el cultivo, dejar el estado anterior
                                                opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 2)
                                            End If
                                        Next
                                    End If
                                    dts_antibiograma.Reset()
                                Else
                                    bandera = False
                                End If
                            Next
                        End If
                        'la variable bandera me sirve para cuando el pedido no tiene antibiograna y solo se necesita guaradar la cabecera del cultivo
                        'si la bandera es true significa que se grabo bien la cabecera y tiene que cambiar el estado del cultivo en la lista de trabajo
                        ' si la bandera es false significa que no se grabo la cabecera del cultivo y no debe cambiar el estado de la orden.
                        If bandera = True Then
                            opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 7)
                            opr_sistema.auditoria(dtr_reg("PED_ID"), dtr_reg("TES_ID"), 6)
                        Else
                            opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 2)
                            opr_sistema.auditoria(dtr_reg("PED_ID"), dtr_reg("TES_ID"), 5)
                        End If
                        'reseteo los dataset para grabar el siguiente cultivo del siguiente paciente
                        dts_cabecera.Reset()
                        'invoco a la funcion dtlc05 que es la que dispara los resultados en el MIS
                        Dim ped_orden, hclin As String
                        Dim Orden_Cul, HClinica_Cul As String
                        ped_orden = Busca_Orden_Paciente(dtr_reg("ped_id"))
                        hclin = Busca_hClinica_Paciente(dtr_reg("ped_id"))
                        Orden_Cul = opr_As400.meteCeroNOMIS(ped_orden)
                        HClinica_Cul = opr_As400.meteCeroHC(hclin)
                        'actualizo el campo dlfecm de la tabla dtlmis
                        Call actualiza_dlfecm(Orden_Cul, HClinica_Cul)
                        'invoco a la funcion que dispara los resultados en MIS
                        Call opr_As400.RutinaDTLC05(HClinica_Cul, Orden_Cul)
                        'fin de la transmision del cultivo al MIS, continua con el siguiente cultivo
                        'llamo a la funcion que verifica si se han reenviado resultados del paciente
                        Reenvia_Resultados_OrdenMIS(dtr_reg("ped_id"))
                    Next
                End If
                'Fin de las Transacciones
                Me.Cursor = System.Windows.Forms.Cursors.Arrow
                dts_datos.Reset()
                ' Me.Cursor = Cursors.Arrow
                MsgBox("Fin de la transacción, por favor actualice la lista de trabajo.", MsgBoxStyle.Information, "ANALISYS")
            End If
            Exit Sub
        Catch
            MsgBox("Se han enviado resultados al MIS, pero con advertencia de error.", MsgBoxStyle.Information, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        End Try
    End Sub

    Public Function Busca_Orden_Paciente(ByVal ped_id) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDr As OleDbDataReader
            Dim str_sql As String
            str_sql = "select ped_orden from pedido where ped_id='" & ped_id & "' "
            opr_conexion.conectar()
            oDr = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While oDr.Read
                Busca_Orden_Paciente = oDr.GetValue(0).ToString
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo buscar la orden del paciente para el cultivo. Busca_Orden_Paciente. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function Busca_hClinica_Paciente(ByVal ped_id) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDr As OleDbDataReader
            Dim str_sql As String
            str_sql = "select pac_hist_clinica from pedido, paciente where pedido.pac_id = paciente.pac_id and pedido.ped_id='" & ped_id & "' "
            opr_conexion.conectar()
            oDr = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While oDr.Read
                Busca_hClinica_Paciente = oDr.GetValue(0).ToString
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo buscar la orden del paciente para el cultivo. Busca_HClinica_Paciente. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function Reenvia_Resultados_OrdenMIS(ByVal ped_id As Long)
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim dtr_res As DataRow
            Dim boo_flag As Boolean = False
            Dim verifica As Integer = verifica_reapertura(ped_id)
            Dim test As String = verifica_test(ped_id)
            If verifica <> 0 Then
                'procedimiento para enviar resultados manuales a MIS
                Dim verifica_man As Integer = verifica_resultados(ped_id)
                If verifica_man <> 0 Then
                    Dim dts_datos As DataSet = llena_datos_resman(ped_id)
                    If dts_datos.Tables(0).Rows.Count <> 0 Then
                        For Each dtr_res In dts_datos.Tables(0).Rows
                            If test <> dtr_res("tes_id") Then
                                If INSERTRESMANUALVALIDADO(dtr_res("ped_id"), dtr_res("tes_id"), dtr_res("LIS_RESMANUAL")) = True Then
                                    boo_flag = True
                                End If
                            End If
                        Next
                    End If
                End If
                'procediemiento para enviar resultados automaticos a MIS
                Dim verifica_aut As Integer = verifica_resultados_aut(ped_id)
                If verifica_aut <> 0 Then
                    Dim dts_datos As DataSet = llena_datos_resaut(ped_id)
                    If dts_datos.Tables(0).Rows.Count <> 0 Then
                        For Each dtr_res In dts_datos.Tables(0).Rows
                            If test <> dtr_res("tes_id") Then
                                If INSERTRESMANUALVALIDADO(dtr_res("ped_id"), dtr_res("tes_id"), dtr_res("prc_resul")) = True Then
                                    boo_flag = True
                                End If
                            End If
                        Next
                    End If
                End If
                'procedimiento para enviar cultivos a MIS
                Dim opr_trabajo As New Cls_Trabajo()
                Dim dts_cabecera As DataSet
                Dim dts_antibiograma As DataSet
                Dim bandera As Boolean
                Dim verifica_cul As Integer = verifica_cultivos(ped_id)
                If verifica_cul <> 0 Then
                    Dim dts_datos As DataSet = llena_datos_rescul(ped_id)
                    If dts_datos.Tables(0).Rows.Count <> 0 Then
                        For Each dtr_res In dts_datos.Tables(0).Rows
                            Dim dtr_cab As DataRow
                            dts_cabecera = LeerCabecera(dtr_res("PED_ID"), dtr_res("TES_ID"), dtr_res("gre_id"))
                            If dts_cabecera.Tables("Datos").Rows.Count <> 0 Then
                                For Each dtr_cab In dts_cabecera.Tables("Datos").Rows
                                    If test <> dtr_cab("tes_id") Then
                                        If InsertaCabeceraCultivo_MIS(dtr_cab("ped_id"), dtr_cab("tes_id"), dtr_cab("familia").ToString, dtr_cab("germen").ToString, dtr_cab("mre_beta").ToString, dtr_cab("mre_blee").ToString, dtr_cab("mre_obs").ToString, dtr_cab("gre_cont").ToString) = True Then
                                            boo_flag = True
                                            Dim dtr_det As DataRow
                                            dts_antibiograma = LeerAntibiograma(dtr_res("PED_ID"), dtr_res("TES_ID"), dtr_res("gre_id"))
                                            If dts_antibiograma.Tables("Datos2").Rows.Count <> 0 Then
                                                For Each dtr_det In dts_antibiograma.Tables("Datos2").Rows
                                                    If test <> dtr_det("tes_id") Then
                                                        If InsertaDetalleCultivo_MIS(dtr_det("ped_id"), dtr_det("tes_id"), dtr_det("ger_nombre"), dtr_det("ant_nombre"), dtr_det("atb_interpretacion")) = True Then
                                                            opr_trabajo.CambioEstadoItemLista(dtr_res("lis_id"), 7)
                                                            boo_flag = True
                                                        Else
                                                            opr_trabajo.CambioEstadoItemLista(dtr_res("lis_id"), 2)
                                                        End If
                                                    End If
                                                Next
                                            End If
                                            dts_antibiograma.Reset()
                                        Else
                                            boo_flag = False
                                        End If
                                    End If
                                Next
                            End If
                            dts_cabecera.Reset()
                        Next
                    End If
                End If
                If boo_flag = True Then
                    'entro en el proceso final del reenvio de los resultados
                    Dim pac_hc As String = consulta_pac_hc(dtr_res("ped_id"))
                    Dim pac_or As String = consulta_pac_or(dtr_res("ped_id"))
                    Dim hc As String
                    Dim orden As String
                    hc = meteCeroHC(pac_hc)
                    orden = meteCeroNOMIS(pac_or)
                    'actualizo el campo dlfecm 
                    'actualiza_dlfecm(orden, hc)
                    'invoco a la rutina dtlc05 que dispara resultados en MIS
                    RutinaDTLC05(hc, orden)
                End If
            End If
            Exit Function
        Catch
            MsgBox("No se pudo realizar la operacion. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function llena_datos_rescul(ByVal ped_id As Long) As DataSet
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDa As New OleDbDataAdapter()
            Dim str_sql As String
            str_sql = "select lista_trabajo.lis_id, lista_trabajo.ped_id, lista_trabajo.tes_id, m_germen_resultado.gre_id  " & _
                      "from lista_trabajo, pedido, test, m_resultado, m_germen_resultado " & _
                      "where lista_trabajo.ped_id = pedido.ped_id And lista_trabajo.ped_id = m_resultado.ped_id " & _
                      "and lista_trabajo.tes_id=test.tes_id and pedido.ped_id=m_resultado.ped_id " & _
                      "and pedido.ped_id='" & ped_id & "' and lista_trabajo.lis_resestado=7 " & _
                      "and lista_trabajo.tes_id=m_resultado.tes_id " & _
                      "and m_resultado.mre_id=m_germen_resultado.mre_id "
            opr_conexion.conectar()
            oDa.SelectCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
            llena_datos_rescul = New DataSet()
            oDa.Fill(llena_datos_rescul, "Registros")
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo cargar los resultados enviados a MIS. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function llena_datos_resaut(ByVal ped_id As Long) As DataSet
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDa As New OleDbDataAdapter()
            Dim str_sql As String
            str_sql = "select lista_trabajo.ped_id, lista_trabajo.tes_id, res_procesados.prc_resul from lista_trabajo, pedido, test, test_equipo, res_procesados " & _
                      " where lista_trabajo.ped_id = pedido.ped_id And pedido.ped_id = res_procesados.ped_id " & _
                      " and pedido.ped_id='" & ped_id & "' and lista_trabajo.ped_id=res_procesados.ped_id " & _
                      " and lista_trabajo.lis_resestado=7  and lista_trabajo.tes_id=test.tes_id " & _
                      " and test.tes_id=test_equipo.tes_id and test.tes_tproces=1 " & _
                      " and test_equipo.teq_abrv_fija=res_procesados.tes_abrev "
            opr_conexion.conectar()
            oDa.SelectCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
            llena_datos_resaut = New DataSet()
            oDa.Fill(llena_datos_resaut, "Registros")
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo cargar los resultados enviados a MIS. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function llena_datos_resman(ByVal ped_id As Long) As DataSet
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim oDa As New OleDbDataAdapter()
            Dim str_sql As String
            str_sql = "select pedido.ped_id, lista_trabajo.tes_id, lista_trabajo.lis_resmanual " & _
                      "from lista_trabajo, pedido, test " & _
                      "where lista_trabajo.ped_id=pedido.ped_id and pedido.ped_id='" & ped_id & "' " & _
                      "and lista_trabajo.lis_resestado=7 and lista_trabajo.tes_id=test.tes_id  " & _
                      "and test.tes_tproces=0 "
            opr_conexion.conectar()
            oDa.SelectCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)
            llena_datos_resman = New DataSet()
            oDa.Fill(llena_datos_resman, "Registros")
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo cargar los resultados enviados a MIS. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function consulta_pac_hc(ByVal ped_id As Long) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select pac_hist_clinica from pedido, paciente where pedido.pac_id=paciente.pac_id and pedido.ped_id='" & ped_id & "' "
            opr_conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr.Read
                consulta_pac_hc = odr.GetValue(0).ToString
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo consultar la historia clinica del paciente. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function consulta_pac_or(ByVal ped_id As Long) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select ped_orden from pedido where pedido.ped_id='" & ped_id & "' "
            opr_conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr.Read
                consulta_pac_or = odr.GetValue(0).ToString
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo consultar la historia clinica del paciente. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Private Function verifica_reapertura(ByVal ped_id As Long) As Integer
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select count(*) from reest_orden, pedido where reest_orden.ped_id=pedido.ped_id and pedido.ped_id='" & ped_id & "' "
            opr_conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr.Read
                verifica_reapertura = odr.GetValue(0)
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo verificar el estado de la orden. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Private Function verifica_test(ByVal ped_id As Long) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select tes_id from reest_orden, pedido where reest_orden.ped_id=pedido.ped_id and pedido.ped_id='" & ped_id & "' "
            opr_conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr.Read
                verifica_test = odr.GetValue(0).ToString
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo verificar el estado de la orden. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Private Function verifica_resultados(ByVal ped_id As Long) As Integer
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String
            str_sql = "select count(*) from lista_trabajo, pedido, test " & _
                      " where lista_trabajo.ped_id= pedido.ped_id and pedido.ped_id='" & ped_id & " ' " & _
                      " and lista_trabajo.lis_resestado=7 and lista_trabajo.tes_id=test.tes_id " & _
                      " and  test.tes_tproces=0 "
            opr_conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr.Read
                verifica_resultados = odr.GetValue(0)
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo verificar el estado de la orden. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Private Function verifica_resultados_aut(ByVal ped_id As Long) As Integer
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String
            str_sql = "select count(*) from lista_trabajo, pedido, test, test_equipo, res_procesados " & _
                      " where lista_trabajo.ped_id = pedido.ped_id And pedido.ped_id = res_procesados.ped_id " & _
                      " and pedido.ped_id='" & ped_id & "' and lista_trabajo.ped_id=res_procesados.ped_id " & _
                      " and lista_trabajo.lis_resestado=7  and lista_trabajo.tes_id=test.tes_id " & _
                      " and test.tes_id=test_equipo.tes_id and test.tes_tproces=1 " & _
                      " and test_equipo.teq_abrv_fija=res_procesados.tes_abrev "
            opr_conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr.Read
                verifica_resultados_aut = odr.GetValue(0)
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo verificar el estado de la orden. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Private Function verifica_cultivos(ByVal ped_id As Long) As Integer
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String
            str_sql = "select count(*) from lista_trabajo, pedido, test, m_resultado " & _
                      " where lista_trabajo.ped_id=pedido.ped_id and pedido.ped_id=m_resultado.ped_id " & _
                      " and pedido.ped_id='" & ped_id & "' and lista_trabajo.tes_id=test.tes_id " & _
                      " and lista_trabajo.tes_id=m_resultado.tes_id and lista_trabajo.lis_resestado=7 "
            opr_conexion.conectar()
            Dim odr As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr.Read
                verifica_cultivos = odr.GetValue(0)
            End While
            opr_conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo verificar el estado de la orden. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Private Sub InitializeComponent()
        '
        'Cls_AS400
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "Cls_AS400"
    End Sub

    Private Sub Cls_AS400_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Function Cons_ordenMIS(Optional ByVal ped_id As Integer = 0, Optional ByVal exp As Byte = 0, Optional ByVal TIPO As Byte = 3, Optional ByVal PARAMETRO1 As String = "", Optional ByVal PARAMETRO2 As String = "", Optional ByVal mes As Byte = 0) As DataSet
        'Funcion para la consultar resultados manuales de pruebas que no requieren validacion y que no han 
        'sido transmitidas al MIS
        Try
            Dim opr_Conexion As New Cls_Conexion()
            Dim oda_operacion As OleDbDataAdapter = New OleDbDataAdapter()
            opr_Conexion.conectar()
            Dim str_sql As String = ""
            Dim str_aux As String
            If mes = 0 Then
                str_aux = ""
            Else
                If mes = 12 Then
                    Dim fechaini, fechafin As Date
                    Dim shr_dias As Short
                    shr_dias = Date.DaysInMonth(Year(Now), Month(Now))
                    fechaini = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-01"
                    fechafin = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-" & CStr(shr_dias)
                    str_aux = " and PED_FECING between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59' "
                Else
                    str_aux = " and PED_FECING between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
                End If

            End If
            Select Case TIPO
                Case 0 'por orden 
                    str_sql = "select ped_orden, ped_id,ped_turno from pedido where ped_turno >= " & PARAMETRO1 & " and ped_turno <= " & PARAMETRO2 & str_aux & " and pedido.ped_orden is not NULL;"
                Case 1 'por fecha 
                    str_sql = "select ped_orden, ped_id from pedido where ped_orden is not NULL and ped_fecing between '" & Format(CDate(PARAMETRO1), "yyyy-MM-dd") & " 00:00:00.000' and '" & Format(CDate(PARAMETRO2), "yyyy-MM-dd") & " 23:59:59.000'"
            End Select
            oda_operacion.SelectCommand = New OleDbCommand(str_sql, opr_Conexion.Conn_BD)
            Cons_ordenMIS = New DataSet()
            oda_operacion.Fill(Cons_ordenMIS, "Registros")
            opr_Conexion.desconectar()
        Catch
            MsgBox("No se pudo verificar el estado de la orden. ", MsgBoxStyle.Exclamation, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function BorraResultadoMIS(ByVal orden As String, ByVal TesId As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim validar, v_dtinco As Long
        'Dim orden As String
        Dim OPR_AS400 As New Cls_AS400()
        Dim oConexion As iDB2Connection
        Dim otrans As iDB2Transaction
        Dim cmd As iDB2Command
        Dim tmp, numOrden, numturno As String

        tmp = Len(TesId)
        Select Case tmp
            Case 8
                TesId = Mid(TesId, 5, 8)
            Case 7
                TesId = Mid(TesId, 4, 7)
            Case Else
                TesId = TesId
        End Select

        'numturno = OPR_AS400.meteCeroNTMIS(turno)
        numOrden = OPR_AS400.meteCeroNOMIS(orden)
        'validar = OPR_AS400.countregistrosDTLMIS(numOrden, numturno)
        oConexion = New iDB2Connection(g_str_idb2)

        Try
            'abre conexion a MIS, con transaccion
            oConexion.Open()
            otrans = oConexion.BeginTransaction
            If TesId <> 200 Then
                str_sql = "Delete from " & g_ASLibreria & ".DTLMIS where DLNUOR=" & orden & " and DLCEXA=" & TesId & " "
                cmd = New iDB2Command(str_sql, oConexion, otrans)
                cmd.ExecuteNonQuery()
            ElseIf TesId = 200 Then
                Dim i As Integer
                For i = 1 To 22
                    Select Case i
                        Case 1
                            TesId = "2001"
                        Case 2
                            TesId = "2002"
                        Case 3
                            TesId = "2003"
                        Case 4
                            TesId = "2004"
                        Case 5
                            TesId = "2005"
                        Case 6
                            TesId = "2006"
                        Case 7
                            TesId = "2007"
                        Case 8
                            TesId = "2008"
                        Case 9
                            TesId = "2009"
                        Case 10
                            TesId = "2010"
                        Case 11
                            TesId = "2011"
                        Case 12
                            TesId = "2012"
                        Case 13
                            TesId = "2015"
                        Case 14
                            TesId = "2018"
                        Case 15
                            TesId = "2021"
                        Case 16
                            TesId = "2024"
                        Case 17
                            TesId = "2027"
                        Case 18
                            TesId = "2029"
                        Case 19
                            TesId = "2030"
                        Case 20
                            TesId = "2033"
                        Case 21
                            TesId = "2036"
                        Case 22
                            TesId = "35"
                    End Select
                    str_sql = "Delete from " & g_ASLibreria & ".DTLMIS where DLNUOR=" & orden & " and DLCEXA=" & TesId & " "
                    cmd = New iDB2Command(str_sql, oConexion, otrans)
                    cmd.ExecuteNonQuery()
                Next
            End If
            otrans.Commit()
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
            otrans.Rollback()
        Finally
            oConexion.Close()
            oConexion = Nothing
        End Try
    End Function

    Public Function BorraResultadoDTINCO(ByVal numOrden As String)
        'Elimina registro de la Tabla DTINCO
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str_sql As String
        Dim v_dtinco As Long
        'Dim orden As String
        Dim OPR_AS400 As New Cls_AS400()
        Dim oConexion As iDB2Connection
        Dim otrans As iDB2Transaction
        Dim cmd As iDB2Command
        Dim tmp As String
        v_dtinco = OPR_AS400.countregistrosDTINCO(numOrden)
        oConexion = New iDB2Connection(g_str_idb2)

        Try
            If v_dtinco > 0 Then
                'abre conexion a MIS, con transaccion
                oConexion.Open()
                otrans = oConexion.BeginTransaction
                str_sql = "Delete from " & g_ASLibreria & ".DTINCO where DLNUOR=" & numOrden & ""
                cmd = New iDB2Command(str_sql, oConexion, otrans)
                cmd.ExecuteNonQuery()
                'otrans.Commit()
                'oConexion.Close()
            End If
        Catch
            MsgBox(Err.Description)
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
            otrans.Rollback()
        Finally
            oConexion.Close()
            oConexion = Nothing
        End Try
    End Function

    Public Function llena_datos(ByVal orden As Long, ByVal turno As String) As DataSet
        On Error GoTo mensaje
        Dim str_sql As String = ""
        Dim opr_conexion As New Cls_Conexion()
        Dim oda_menu As New OleDbDataAdapter()
        Dim fecha As Date
        Dim fi, ff As String
        Dim SHR_DIAS As Short
        Dim mes As Integer  ' and lista_trabajo.lis_resestado=6
        Dim str_aux As String
        mes = Month(Now)
        If mes = 0 Then
            str_aux = ""
        Else
            If mes = 12 Then
                Dim fechaini, fechafin As Date
                SHR_DIAS = Date.DaysInMonth(Year(Now), Month(Now))
                fechaini = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-01"
                fechafin = CStr(Year(Now)) & "-" & CStr(Month(Now)) & "-" & CStr(SHR_DIAS)
                str_aux = " and PED_FECING between '" & fechaini & " 00:00:00' and '" & fechafin & " 23:59:59' "
            Else
                str_aux = " and PED_FECING between '" & Year(Now) & "-" & mes & "-01 00:00:00.000' and '" & Year(Now) & "-" & mes + 1 & "-01 00:00:00.000'"
            End If
        End If
        'Para pruebas aumente la fecha aumente  lista_trabajo.lis_resestado  =  2 -5 -7 -8 debido que aquellas pruebas q no tienen resultados no van hacer consideradas   or lista_trabajo.lis_resestado = 7 
        str_sql = "select paciente.pac_nombre, paciente.pac_apellido, paciente.pac_hist_clinica, pedido.ped_fecing, lista_trabajo.tes_id, lista_trabajo.ped_id, test.tes_nombre  ,lista_trabajo.lis_resestado ,lista_trabajo.lis_id,pedido.ped_turno  " & _
                  " from pedido, lista_trabajo, paciente, test where ped_orden = '" & Trim(orden) & "' and lista_trabajo.ped_id=pedido.ped_id and paciente.pac_id = pedido.pac_id and (lista_trabajo.lis_resestado = 2  or lista_trabajo.lis_resestado = 8 ) and test.tes_id = lista_trabajo.tes_id and pedido.ped_turno = '" & Trim(turno) & "' " & str_aux & ";"

        opr_conexion.conectar()
        oda_menu.SelectCommand = New OleDbCommand(str_sql, opr_conexion.Conn_BD)

        llena_datos = New DataSet()
        oda_menu.Fill(llena_datos, "Registros")
        opr_conexion.desconectar()
        Exit Function
mensaje:
        MsgBox(" Error en la operacion llena datos de Reestablecer Orden ", MsgBoxStyle.Exclamation, "ANALISYS")
    End Function

    Public Function consulta_resman(ByVal ped_id As String, ByVal tes_id As String) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim tipo_proc As Integer = verifica(tes_id)
            Select Case tipo_proc
                Case 0
                    Dim str_sql As String = "select lista_trabajo.lis_resmanual from lista_trabajo where lista_trabajo.ped_id='" & ped_id & "' and lista_trabajo.tes_id='" & tes_id & "' "
                    opr_conexion.conectar()
                    Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
                    While odr_operacion.Read
                        consulta_resman = odr_operacion.GetValue(0).ToString()
                    End While
                    opr_conexion.desconectar()
                Case 1
                    Dim abreviatura As String = cons_abreviatura(tes_id)
                    Dim str_sql1 As String = "select prc_resul from res_procesados where ped_id='" & ped_id & "' and tes_abrev='" & abreviatura & "'"
                    opr_conexion.conectar()
                    Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql1, opr_conexion.Conn_BD).ExecuteReader
                    While odr_operacion.Read
                        consulta_resman = odr_operacion.GetValue(0).ToString()
                    End While
                    opr_conexion.desconectar()
            End Select
            Exit Function
        Catch
            MsgBox("No se pudo realizar la operacion solicitada. Consulta_resman", MsgBoxStyle.Critical, "ANALISYS")
        End Try
    End Function
    Public Function verifica(ByVal tes_id As String) As Integer
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select tes_tproces from test where tes_id='" & tes_id & "'"
            opr_conexion.conectar()
            Dim odr_operacion As OleDbDataReader = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteReader
            While odr_operacion.Read
                verifica = odr_operacion.GetValue(0).ToString()
            End While
            opr_conexion.desconectar()
        Catch
            MsgBox("No se pudo realizar la operacion solicitada, Verifica Tipo_Proc", MsgBoxStyle.Information, "ANALISYS")
        End Try
    End Function

    Public Function cons_abreviatura(ByVal tes_id As String) As String
        Try
            Dim opr_conexion As New Cls_Conexion()
            Dim str_sql As String = "select teq_abrv_fija from test_equipo where tes_id='" & tes_id & "' order by teq_abrv_fija "
            opr_conexion.conectar()
            'Dim odr_operacion As OledbdataReader = New OledbCommand(str_sql, opr_conexion.Conn_BD).ExecuteScalar
            'While odr_operacion.Read
            'cons_abreviatura = odr_operacion.GetValue(0).ToString()
            'End While
            cons_abreviatura = New OleDbCommand(str_sql, opr_conexion.Conn_BD).ExecuteScalar
            opr_conexion.desconectar()
        Catch
            MsgBox("No se pudo realizar la operacion solicitada, Consulta_Abreviatura. ", MsgBoxStyle.Information, "ANALISYS")
            Err.Clear()
        End Try
    End Function


    Public Function asignar_status(ByVal tes_id As String, ByVal ped_id As String) As Integer
        'Funciòn para asignar el status y determinar que proceso estamos
        '1 =  Manual
        '2 =  Automàtico
        '3 = Cultivo-manual 
        Try
            Dim opr_Conexion As New Cls_Conexion()
            Dim asigna As Integer = 0
            'Dim str_sql As String = "select tes_tproces from test where tes_id='" & tes_id & "'"
            Dim str_sql As String = "select isnull(equ_id,0) as tes_tproces from lista_trabajo where tes_id = " & tes_id & " and ped_id =" & ped_id & ""
            opr_Conexion.conectar()
            asignar_status = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
            If asignar_status = 0 Then
                str_sql = "select count(*)from lista_trabajo, pedido, test, m_resultado where lista_trabajo.ped_id=pedido.ped_id and pedido.ped_id=m_resultado.ped_id  and pedido.ped_id='" & ped_id & "' and lista_trabajo.tes_id=test.tes_id  and lista_trabajo.tes_id=m_resultado.tes_id and lista_trabajo.lis_resestado>=5 and test.tes_id = '" & tes_id & "'"
                asigna = CInt(New OleDbCommand(str_sql, opr_Conexion.Conn_BD).ExecuteScalar)
                If asigna = 0 Then
                    asignar_status = 1
                Else
                    asignar_status = 3
                End If
            Else
                asignar_status = 2
            End If
            opr_Conexion.desconectar()
            Exit Function
        Catch
            MsgBox("No se pudo realizar la operacion solicitada,  Asignar_Status", MsgBoxStyle.Information, "ANALISYS")
            Err.Clear()
        End Try
    End Function

    Public Function validacion_antibiograma(ByVal Turno As Integer, ByVal mes As Integer) As Boolean
        Dim opr_AS400 As New Cls_AS400()
        Dim opr_sistema As New Cls_sistema()
        Dim opr_trabajo As New Cls_Trabajo()
        Dim dts_datos As DataSet
        Try
            'nueva funcion que envia los cultivos y antibiogramas hacia MIS - Andres Toledo V. 08-01-2007
            dts_datos = opr_AS400.Cons_ResCultSinVal(0, 0, 0, 0, Turno, Turno, CStr(mes))
            Dim DTR_ANTIBIOTICO As DataRow
            Dim dts_antibiograma As DataSet
            Dim dts_cabecera As DataSet
            Dim boo_cultivo As Boolean = False
            Dim comentario As String = ""
            Dim coment_ant As String = ""
            Dim bandera As Boolean
            Dim dtr_reg As DataRow


            If dts_datos.Tables("Registros").Rows.Count <> 0 Then
                For Each dtr_reg In dts_datos.Tables("Registros").Rows
                    'consulto la cabecera del cultivo
                    Dim dtr_cab As DataRow
                    dts_cabecera = opr_AS400.LeerCabecera(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("gre_id"))
                    If dts_cabecera.Tables("Datos").Rows.Count <> 0 Then
                        For Each dtr_cab In dts_cabecera.Tables("Datos").Rows
                            'mando a grabar la cabecera del cultivo
                            If opr_AS400.InsertaCabeceraCultivo_MIS(dtr_cab("ped_id"), dtr_cab("tes_id"), dtr_cab("familia").ToString, dtr_cab("germen").ToString, dtr_cab("mre_beta").ToString, dtr_cab("mre_blee").ToString, dtr_cab("mre_obs").ToString, dtr_cab("gre_cont").ToString) = True Then
                                bandera = True
                                'busco si tiene antibiograma este cultivo
                                'consulto los resultados generales del cultivo y luego si tiene antibiograma 
                                Dim dtr_det As DataRow
                                dts_antibiograma = opr_AS400.LeerAntibiograma(dtr_reg("PED_ID"), dtr_reg("TES_ID"), dtr_reg("gre_id"))
                                'comienzo a mandar a grabar al antibiograma en el mis
                                If dts_antibiograma.Tables("Datos2").Rows.Count <> 0 Then
                                    For Each dtr_det In dts_antibiograma.Tables("Datos2").Rows
                                        'mando a grabar la cabecera del cultivo
                                        'ped_id , tes_id , germen , antibiotico 
                                        If opr_AS400.InsertaDetalleCultivo_MIS(dtr_det("ped_id"), dtr_det("tes_id"), dtr_det("ger_nombre"), dtr_det("ant_nombre"), dtr_det("atb_interpretacion")) = True Then
                                            'cambio el estado del cultivo
                                            'opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 7)
                                        Else
                                            'no se grabo el cultivo, dejar el estado anterior
                                            'opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 2)
                                        End If
                                    Next
                                End If
                                dts_antibiograma.Reset()
                            Else
                                bandera = False
                            End If
                        Next
                    End If
                    'la variable bandera me sirve para cuando el pedido no tiene antibiograna y solo se necesita guaradar la cabecera del cultivo
                    'si la bandera es true significa que se grabo bien la cabecera y tiene que cambiar el estado del cultivo en la lista de trabajo
                    ' si la bandera es false significa que no se grabo la cabecera del cultivo y no debe cambiar el estado de la orden.
                    If bandera = True Then
                        'opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 7)
                        opr_sistema.auditoria(dtr_reg("PED_ID"), dtr_reg("TES_ID"), 6)
                    Else
                        'opr_trabajo.CambioEstadoItemLista(dtr_reg("lis_id"), 2)
                        opr_sistema.auditoria(dtr_reg("PED_ID"), dtr_reg("TES_ID"), 5)
                    End If
                    'reseteo los dataset para grabar el siguiente cultivo del siguiente paciente
                    dts_cabecera.Reset()

                Next
                'Dim ped_orden, hclin As String
                'Dim Orden_Cul, HClinica_Cul As String
                'ped_orden = Busca_Orden_Paciente(dtr_reg("ped_id"))
                'hclin = Busca_hClinica_Paciente(dtr_reg("ped_id"))
                'Orden_Cul = opr_AS400.meteCeroNOMIS(ped_orden)
                'HClinica_Cul = opr_AS400.meteCeroHC(hclin)
                ''FUnction para actualizar el Turno 
                'Call actualiza_dlfecm(Orden_Cul, HClinica_Cul, Turno)
            End If
        Catch
            MsgBox("No se ha podido realizar la operación solicitada en el MIS." & Chr(13) & Err.Description, MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Function

    Public Function countregistrosDTINCO(ByVal orden As String) As Long
        'Funciòn que verifica si existe errores en el DTINCO
        Dim ocon As iDB2Connection
        Dim str_sql As String = "Select count(*) from " & g_ASLibreria & ".DTINCO WHERE DLNUOR = " & orden & ""
        Try
            ocon = New iDB2Connection(g_str_idb2)
            ocon.Open()
            Dim odr_operacion As iDB2DataReader = New iDB2Command(str_sql, ocon).ExecuteReader
            While odr_operacion.Read
                countregistrosDTINCO = odr_operacion.GetValue(0).ToString()
            End While
            odr_operacion.Close()
        Catch
            countregistrosDTINCO = 1
            existe_error = True
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ocon.Close()
        End Try
    End Function

    Public Function selectregistrosDTINCO(ByVal orden As String) As DataSet
        'Funciòn que verifica si existe errores en el DTINCO
        Dim ocon As iDB2Connection
        Dim oda_menu As iDB2DataAdapter = New iDB2DataAdapter()
        Try
            ocon = New iDB2Connection(g_str_idb2)
            ocon.Open()
            Dim str_sql As String = "Select DLCEXA as Examen, DTCOER as Codigo , DTDESC as Descripcion ,  DLRESE  as Resultado from " & g_ASLibreria & ".DTINCO WHERE DLNUOR = " & orden & ""
            oda_menu.SelectCommand = New iDB2Command(str_sql, ocon)
            selectregistrosDTINCO = New DataSet("DTINCO")
            oda_menu.Fill(selectregistrosDTINCO, "Registros")
        Catch
            existe_error = True
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ocon.Close()
        End Try

    End Function

    Public Function countregistrosDTINCOMISDTL(ByVal orden As String, ByVal hc As String, ByVal TesId As String) As Long
        'Funciòn que verifica si existe errores en el DTINCO seleccionando DLFECM = '0' del DTLMIS
        Dim ocon As iDB2Connection
        Dim tmp As String
        'Asigna cero al TestID
        tmp = Len(TesId)
        Select Case tmp
            Case 8
                TesId = Mid(TesId, 5, 8)
            Case 7
                TesId = Mid(TesId, 4, 7)
            Case Else
                TesId = TesId
        End Select
        Dim str_sql As String = "Select COUNT(*) from " & g_ASLibreria & ".DTLMIS where DLNUOR=" & CInt(orden) & " and DLHIST=" & CInt(hc) & " AND DLFECM = '0' AND DLCEXA=" & TesId & "   "
        Try
            ocon = New iDB2Connection(g_str_idb2)
            ocon.Open()
            Dim odr_operacion As iDB2DataReader = New iDB2Command(str_sql, ocon).ExecuteReader
            While odr_operacion.Read
                countregistrosDTINCOMISDTL = odr_operacion.GetValue(0).ToString()
            End While
            odr_operacion.Close()
        Catch
            countregistrosDTINCOMISDTL = 0
            existe_error = True
            MsgBox(Err.Description, MsgBoxStyle.Critical, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ocon.Close()
        End Try
    End Function
    'funcion que actualiza el campo que escribe la rutina dtlc05
    'Andres Toledo 01/06-2009

    Public Function actualiza_dlfecm(ByVal orden As String, ByVal hc As String, ByVal Turno As String)
        Dim oCon As iDB2Connection
        Dim otrans As iDB2Transaction
        Dim cmd As iDB2Command
        Dim str_sql As String
        str_sql = "update " & g_ASLibreria & ".DTLMIS set DLORLA= '" & Turno & "' where DLNUOR=" & CInt(orden) & " and DLHIST=" & CInt(hc) & " "
        Try
            oCon = New iDB2Connection(g_str_idb2)
            cmd = New iDB2Command()
            oCon.Open()
            otrans = oCon.BeginTransaction
            cmd.Connection = oCon
            cmd.Transaction = otrans
            cmd.CommandType = CommandType.Text
            cmd.CommandText = str_sql
            cmd.ExecuteNonQuery()
            otrans.Commit()
        Catch
            otrans.Rollback()
            MsgBox("No se pudo actualizar el campo DLFECM en DTLMIS ", MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            oCon.Close()
            oCon = Nothing
        End Try
    End Function

    'FUNCIONES PRUEBA

    Public Function datosAS() As DataSet
        'Devuelve todos los registros de la tabla MISDTL que coincidan con la orden ingresada.
        Dim ocon As iDB2Connection
        Dim oda_menu As iDB2DataAdapter = New iDB2DataAdapter()
        Try
            ocon = New iDB2Connection(g_str_idb2)
            ocon.Open()
            Dim str_sql As String = "SELECT * FROM " & g_ASLibreria & ".MISDTL" ' WHERE DLNUOR =  " & orden & " and DLFEAM = 0"
            oda_menu.SelectCommand = New iDB2Command(str_sql, ocon)
            datosAS = New DataSet()
            oda_menu.Fill(datosAS, "Registros")
        Catch
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        Finally
            ocon.Close()
        End Try
    End Function


    Public Function consulta_orden_ANALISYS(ByVal ped_id As Integer) As String
        Dim cls_operacion As New Cls_Conexion()
        Try
            Dim str_sql As String = "select ped_recibo from pedido where ped_id = '" & ped_id & "'"
            cls_operacion.odbc_conn()
            consulta_orden_ANALISYS = ""
            Dim oda_operacion As OdbcDataReader = New OdbcCommand(str_sql, cls_operacion.conn_odbc).ExecuteReader
            While oda_operacion.Read
                consulta_orden_ANALISYS = oda_operacion.GetValue(0).ToString
            End While
            oda_operacion.Close()
        Catch
            consulta_orden_ANALISYS = ""
            MsgBox("No se pudo realizar la operación solicitada, CLS_AS400 Consulta_Orden", MsgBoxStyle.Exclamation, "ANALISYS")
        Finally
            cls_operacion.odbc_desconn()
        End Try
    End Function


    Public Function consulta_resultado_ANALISYS(ByVal ped_id As Integer, ByVal tes_id As Integer) As String
        On Error GoTo msgerror
        'CONSULTO EL RESULTADO DE LA PRUEBA EN EL FORMATO PARA ENVIO AL MIS

        'PRIMERO CONSULTO COMO SE PROCESO LA PRUEBA

        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As OdbcDataAdapter = New OdbcDataAdapter()
        opr_Conexion.odbc_conn()
        Dim str_sql As String = "select lis_mis from lista_trabajo where ped_id = " & ped_id & " and tes_id = " & tes_id & ""
        oda_operacion.SelectCommand = New OdbcCommand(str_sql, opr_Conexion.conn_odbc)
        Dim dts_datos As New DataSet()
        oda_operacion.Fill(dts_datos, "Registros")
        Dim dt_fila As DataRow
        For Each dt_fila In dts_datos.Tables("Registros").Rows
            consulta_resultado_ANALISYS = dt_fila(0).ToString
        Next
        opr_Conexion.desconectar()
        Exit Function
msgerror:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la operación solicitada, Buscar Macroscopico", Err)
        Err.Clear()
    End Function


    Public Function enviaResultadoMIS(ByVal ped_id As Integer, ByVal tes_id As Integer, ByVal res_mis As String, ByVal res_man As String) As Boolean
        'Devuelve todos los registros de la tabla MISDTL que coincidan con la orden ingresada.
        'Dim ocon As iDB2Connection
        'Dim oda_menu As iDB2DataAdapter = New iDB2DataAdapter()
        'Try
        '    ocon = New iDB2Connection(g_str_idb2)
        '    ocon.Open()
        '    Dim str_sql As String = "SELECT * FROM " & g_ASLibreria & ".MISDTL" ' WHERE DLNUOR =  " & orden & " and DLFEAM = 0"
        '    oda_menu.SelectCommand = New iDB2Command(str_sql, ocon)
        '    datosAS = New DataSet()
        '    oda_menu.Fill(datosAS, "Registros")
        'Catch
        '    RutinaError(Err.Number, Err.Description)
        '    Err.Clear()
        'Finally
        '    ocon.Close()
        'End Try

        'INSERTA EL RESULTADO EN LA TABLA DTLMIS (ENVIA RESULTADO A MIS)
        Dim opr_sistema As New Cls_sistema()
        Dim opr_Conexion As New Cls_conexas400()
        Dim Conexion As iDB2Connection
        Dim odc As iDB2Command
        Dim Orden As Long
        Dim HClinica As Long
        Dim RangoMin, RangoMax As String
        Dim HoraR, HoraR1, HoraR2, HoraRM As String
        Dim Turno As Integer
        Dim opr_sis As New Cls_sistema()
        Dim fechaTrans As Date = Now
        Dim fecha As Date = Now
        Dim str_sql As String = ""
        Dim unidad As String
        Dim campo As String
        Dim Hcli, NOrd As String
        Dim test As String
        Dim tmp As String

        Dim oCon As iDB2Connection

        Try
            ''tomo la fecha actual para grabar la fecha en el campo los resultados manuales
            HoraRM = Format(Now, "HHmm")
            ''con esta funcion se consulta la unidad de los test
            'unidad = Consulta_Unidad(tes_id)
            ''con esta funcion consulto el rango minimo de la prueba realizada en equipo
            'RangoMin = Mid(CStr(ConsultaRanMin(tes_id)), 1, 6)
            ''esta funcion me devuelve el rango maximo de la prueba
            'RangoMax = Mid(CStr(ConsultaRanMax(tes_id)), 1, 6) & " " & unidad
            ''consulta el numero de orden del mis
            'ORDEN = ConsultaOrdenMIS(ped_id)
            ''Consulto la historia clinica del paciente
            'HClinica = ConsultaHC(ped_id)
            ''consulta la hora de resultado de una prueba procesadas en equipo y valido
            HoraR = Format(Now, "HHmm")
            ''Funcion que me devuelve el numero de Turno para enviarlo al MIS
            'turno = consultaTurno(ped_id)
            ''consulta el codigo del test
            test = consulta_examen(tes_id)
            ''Funciona que busca el dlpexa del misdtl para insertarlos en el dtlmis
            Dim dts_datos As DataSet
            Dim dtr As DataRow
            dts_datos = Busca_Datos_Test(tes_id, ped_id)
            If dts_datos.Tables(0).Rows.Count <> 0 Then
                For Each dtr In dts_datos.Tables(0).Rows
                    unidad = dtr("Unidad").ToString()
                    RangoMin = dtr("RanMin").ToString()
                    RangoMax = dtr("RanMax").ToString() & " " & unidad
                Next
            End If
            dts_datos.Reset()
            campo = consulta_perfil(tes_id)
            oCon = New iDB2Connection(g_str_idb2)
            oCon.Open()
            Dim RES_ARR() As String
            Dim res_2() As String
            RES_ARR = Split(res_man, "|")
            Dim Ix As Short
            For Ix = 0 To UBound(RES_ARR)
                res_2 = Split(RES_ARR(Ix), "º")
                MsgBox(res_2(0))   'PARAMETRO DE LA PRUEBA
                MsgBox(res_2(1))   'RESULTADO 

                If Conexion.State = ConnectionState.Open Then
                    If Orden <> 0 Then
                        If Len(res_man) <= 10 Then 'inserto el resultado en el campo DLRESE
                            str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLRAMI, DLRAMA, DLRESE, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                      "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & RangoMin & "', '" & RangoMax & "' , '" & res_man & "','" & Turno & "', " & HoraR & ", '" & g_str_login & "', '" & campo & "') "
                            odc = New iDB2Command(str_sql, oCon)
                            odc.ExecuteNonQuery()
                        Else
                            Dim i As Short
                            Dim j As Double
                            Dim res_parcial As String
                            Dim odc_pedido As OleDbCommand
                            If Len(res_man) > 10 And Len(res_man) < 199 Then
                                res_parcial = Mid(res_man, (i * 199) + 1, 199)
                                str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                          "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & Turno & ", " & HoraRM & ", '" & g_str_login & "',  '" & campo & "') "
                                odc = New iDB2Command(str_sql, oCon)
                                odc.ExecuteNonQuery()
                            Else
                                For i = 0 To (Len(res_man) \ 199) - 1
                                    res_parcial = Mid(res_man, (i * 199) + 1, 199)
                                    str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST ,DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                              "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & Turno & ", " & HoraRM & ", '" & g_str_login & "', '" & campo & "') "
                                    odc = New iDB2Command(str_sql, oCon)
                                    odc.ExecuteNonQuery()
                                    If i = ((Len(res_man) \ 199) - 1) Then   'CUANDO ESTOY GRABANDO LA ULTIMA PARTE DEL FOR....Y PUEDE HABER TODAVÍA UNA PARTE DE LA CADENA DE RESULTADOS QUE NO SE ALMACENA TODAVÍA
                                        If (Len(res_man) Mod 199) > 0 Then
                                            res_parcial = Mid(res_man, ((i + 1) * 199) + 1, Len(res_man) - ((i + 1) * 199))
                                        End If
                                        str_sql = "insert into " & g_ASLibreria & ".DTLMIS (DLNUOR, DLFECR, DLHIST, DLCEXA, DLCOME, DLORLA, DLHORR, DLUSLA, DLPEXA) " & _
                                              "values (" & Orden & ", " & Format(fechaTrans, "yyyyMMdd") & ", " & HClinica & " ,'" & test & "', '" & res_parcial & "', " & Turno & ", " & HoraRM & ", '" & g_str_login & "', '" & campo & "') "
                                        odc = New iDB2Command(str_sql, oCon)
                                        odc.ExecuteNonQuery()
                                    End If
                                Next
                            End If

                        End If
                        enviaResultadoMIS = True
                    Else
                        enviaResultadoMIS = False
                    End If
                End If
            Next
            opr_Conexion.desconectarAS()
            oCon.Close()
            Exit Function
        Catch
            enviaResultadoMIS = False
            existe_error = True
            MsgBox("No se ha podido realizar la operación solicitada, envío de resultados al MIS." & Chr(13) & Err.Description, MsgBoxStyle.Exclamation, "ANALISYS")
            RutinaError(Err.Number, Err.Description)
            Err.Clear()
        End Try
    End Function


    Public Function GRABA_FORMATO_MIS(ByVal PED_ID As Long, ByVal RESULTADO As String, ByVal ABREV As String, ByVal MUESTRA As Short)

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim TEST_CODIGO As Long
        Dim FORMATO_MIS As String

        Dim ARR_DATA(), ARR_DATA2() As String
        Dim i, y As Short
        'RECUPERO EL CODIGO DE LA PRUEBA
        Dim STR_SQL As String = "SELECT TEST.TES_ID FROM TEST_EQUIPO, TEST WHERE TEST.TES_ID = TEST_EQUIPO.TES_ID AND TEQ_ABRV_FIJA = '" & ABREV & "' AND TIM_ID = " & MUESTRA
        opr_Conexion.conectar()
        Dim oda_operacion As OleDbDataReader = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
        While oda_operacion.Read
            TEST_CODIGO = oda_operacion.GetValue(0)
        End While
        oda_operacion.Close()

        opr_Conexion.desconectar()

        'HAGO UNA EXCEPCION CON LA BIOMETRIA HEMATICA 

        If (TEST_CODIGO >= 10 And TEST_CODIGO <= 33) Or TEST_CODIGO = 400106 Then
            'CONSULTO LO QUE TIENE ACTUALMENTE EN EL CAMPO MISLIS Y SIGO ACUMULANDO.
            opr_Conexion.odbc_conn()
            STR_SQL = "select LIS_MIS from LISTA_TRABAJO where tes_id = 400101 and ped_id = " & PED_ID & ""
            Dim oda_operacion2 As OdbcDataReader = New OdbcCommand(STR_SQL, opr_Conexion.conn_odbc).ExecuteReader
            While oda_operacion2.Read
                FORMATO_MIS = oda_operacion2.GetValue(0).ToString
            End While
            oda_operacion2.Close()
            opr_Conexion.odbc_desconn()

            If TEST_CODIGO = 10 Then   'globulos rojos 
                FORMATO_MIS = FORMATO_MIS & "|B23º" & RESULTADO
            End If
            If TEST_CODIGO = 11 Then   'globulos blancos
                FORMATO_MIS = FORMATO_MIS & "|B10º" & RESULTADO
            End If
            If TEST_CODIGO = 12 Then   'hemoglobina
                FORMATO_MIS = FORMATO_MIS & "|B11º" & RESULTADO
            End If
            If TEST_CODIGO = 13 Then   'hematocrito
                FORMATO_MIS = FORMATO_MIS & "|B12º" & RESULTADO
            End If
            If TEST_CODIGO = 14 Then   'HCM
                FORMATO_MIS = FORMATO_MIS & "|B14º" & RESULTADO
            End If
            If TEST_CODIGO = 15 Then   'CHCM
                FORMATO_MIS = FORMATO_MIS & "|B15º" & RESULTADO
            End If
            If TEST_CODIGO = 16 Then   'PLAQUETAS
                FORMATO_MIS = FORMATO_MIS & "|B25º" & RESULTADO
            End If
            If TEST_CODIGO = 17 Then   'NEU%
                FORMATO_MIS = FORMATO_MIS & "|B34º" & RESULTADO
            End If
            If TEST_CODIGO = 18 Then   'LYM%
                FORMATO_MIS = FORMATO_MIS & "|B33º" & RESULTADO
            End If
            If TEST_CODIGO = 19 Then   'NOMO%
                FORMATO_MIS = FORMATO_MIS & "|B31º" & RESULTADO
            End If
            If TEST_CODIGO = 20 Then   'EOS%
                FORMATO_MIS = FORMATO_MIS & "|B32º" & RESULTADO
            End If
            If TEST_CODIGO = 21 Then   'BASO%
                FORMATO_MIS = FORMATO_MIS & "|B35º" & RESULTADO
            End If
            If TEST_CODIGO = 22 Then   'NEU
                FORMATO_MIS = FORMATO_MIS & "|B22º" & RESULTADO
            End If
            If TEST_CODIGO = 23 Then   'LYM
                FORMATO_MIS = FORMATO_MIS & "|B21º" & RESULTADO
            End If
            If TEST_CODIGO = 24 Then   'MONO
                FORMATO_MIS = FORMATO_MIS & "|B19º" & RESULTADO
            End If
            If TEST_CODIGO = 25 Then   'EOS
                FORMATO_MIS = FORMATO_MIS & "|B20º" & RESULTADO
            End If
            If TEST_CODIGO = 26 Then   'BASO
                FORMATO_MIS = FORMATO_MIS & "|B24º" & RESULTADO
            End If
            If TEST_CODIGO = 27 Then   'RDW
                FORMATO_MIS = FORMATO_MIS & "|B16º" & RESULTADO
            End If
            If TEST_CODIGO = 28 Then   'VCM
                FORMATO_MIS = FORMATO_MIS & "|B13º" & RESULTADO
            End If
            If TEST_CODIGO = 29 Then   'MPV
                FORMATO_MIS = FORMATO_MIS & "|B17º" & RESULTADO
            End If
            If TEST_CODIGO = 30 Then   'PDW
                'NO HAY EQUIVALENTE EN MIS 
            End If
            If TEST_CODIGO = 31 Then   'PCT
                'NO HAY EQUIVALENTE EN MIS 
            End If
            If TEST_CODIGO = 32 Then   'MID%
                'NO HAY EQUIVALENTE EN MIS 
            End If
            If TEST_CODIGO = 33 Then   'GRAN%
                'NO HAY EQUIVALENTE EN MIS 
            End If
            If TEST_CODIGO = 400106 Then   'HCM 
                'NO HAY EQUIVALENTE EN MIS 
            End If
            TEST_CODIGO = 400101
        Else
            'CUANDO SE TRATA DE OTRAS PRUEBAS
            opr_Conexion.conectar()
            'CONSULTO EL CODIGO PARA EL MIS
            STR_SQL = "select hijo from test, EQUIVALENTE where tes_obs = padre and tes_id = '" & TEST_CODIGO & "'"
            oda_operacion = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD).ExecuteReader
            While oda_operacion.Read
                FORMATO_MIS = oda_operacion.GetValue(0) & "º" & RESULTADO & "|"
            End While
            oda_operacion.Close()
            opr_Conexion.desconectar()
        End If


        'GRABO EL RESULTADO EN EL FORMATO DEL MIS
        STR_SQL = "update lista_trabajo set lis_mis='" & FORMATO_MIS & "' where ped_id= '" & PED_ID & "' and tes_id = " & TEST_CODIGO & ""
        opr_Conexion.conectar()
        Dim odc_pedido As OleDbCommand = New OleDbCommand(STR_SQL, opr_Conexion.Conn_BD)
        odc_pedido.ExecuteNonQuery()
        opr_Conexion.desconectar()
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transacción solicitada, Graba_formato_mis", Err)
        Err.Clear()

    End Function
End Class
