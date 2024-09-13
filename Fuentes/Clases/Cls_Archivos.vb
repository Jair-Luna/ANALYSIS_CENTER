'*************************************************************************
' Nombre:   Cls_Archivos
' Tipo de Archivo: Clase
' Descripcin:  Clase para manipular los archivos de respuestas bajados de los analizadores (SNI)
' Autores:  rfn
' Fecha de Creaci�n: 
' Autores Modificaciones: 
' Ultima Modificaci�n: 24 Julio 2013
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.IO
Imports System.Data

Imports Microsoft.Data.Odbc
Imports System.Data.SqlClient


Public Class Cls_Archivos

    Dim opr_pedido As New Cls_Pedido()
    Dim opr_conexion As New Cls_Conexion()
    'Public Sub Guarda_Archiv_Procesados(ByVal archivo As String)
    '    'FUNCION QUE GRABA LOS DATOS DEL ARCHIVO A LA BASE DE DATOS 
    '    ' EN LA TABLA RESUL_PROCESADOS

    '    Dim aux As TextReader
    '    Dim int_Nres As Short
    '    Dim str_sni As String
    '    Dim int_Nped As Integer
    '    Dim str_fecha As String = ""
    '    Dim str_hora As String = ""
    '    Dim i As Short
    '    Dim str As String
    '    Dim d As Array
    '    aux = File.OpenText(archivo)
    '    str = aux.ReadLine
    '    d = Split(str, ",")
    '    int_Nres = CInt(d(9))
    '    str_sni = CStr(d(2))
    '    str_fecha = CStr(d(4))
    '    str_hora = CStr(d(5))
    '    str = str_fecha.Substring(0, 4) & "/" & str_fecha.Substring(4, 2) & "/" & str_fecha.Substring(6, 2)
    '    str_fecha = str
    '    str = str_hora.Substring(0, 2) & ":" & str_hora.Substring(2, 2) & ":" & str_hora.Substring(4, 2)
    '    str_hora = str
    '    If IsNumeric(d(6)) Then
    '        int_Nped = CInt(d(6))
    '        If opr_pedido.ExistePedido(int_Nped) = 1 Then  'Si existe el pedido y no est� validado
    '            '0 = no existe o ya esta validado
    '            For i = 1 To int_Nres
    '                str = aux.ReadLine
    '                d = Split(str, ",")
    '                'RECUPERO LA ABREV, ERROR Y EL RESULTADO DEL TEST  Y MANDO A GRABAR
    '                GuardarResArchivo(int_Nped, str_fecha, str_hora, CStr(d(1)), str_sni, CDbl(d(3)), CStr(d(2)))
    '            Next
    '        Else
    '            If opr_pedido.ExistePedido(int_Nped) = 2 Then
    '                GuardarLogArchivo(d(6).ToString, str_sni, CStr(d(1)), str_fecha, str_hora, "Validado")
    '            Else
    '                ' = 0   No existe el pedido
    '                GuardarLogArchivo(d(6).ToString, str_sni, CStr(d(1)), str_fecha, str_hora, "No existe pedido")
    '            End If
    '        End If
    '    Else    'El campo # pedido del archivo no es n�merico, no corresponde a ningun pedido
    '        GuardarLogArchivo(d(6).ToString, str_sni, CStr(d(1)), str_fecha, str_hora, "No existe pedido")
    '    End If
    '    aux.Close()
    'End Sub


    Public Function IsFileOpen(ByVal filePath As String) As Boolean
        Dim rtnvalue As Boolean = False
        Try
            Dim fs As System.IO.FileStream = System.IO.File.OpenWrite(filePath)
            fs.Close()
        Catch ex As System.IO.IOException
            rtnvalue = True
        End Try
        Return rtnvalue
    End Function


    Public Function DevuelveLicenciaCliente() As String

        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = ""
        str_sql = "Select lic_numero from licencia where lic_id = 1;"
        opr_Conexion.sql_conectar()
        'Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        DevuelveLicenciaCliente = Nothing
        While odr_operacion.Read
            'Pregunto si tiene resultado > 0 
            If odr_operacion.GetValue(0) <> "" Then
                'Si lo tiene
                DevuelveLicenciaCliente = odr_operacion.GetValue(0)
            End If
        End While
        odr_operacion.Close()
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Posee Resultado", Err)
        Err.Clear()


    End Function
    Public Sub Guarda_Archiv_Procesados(ByVal archivo As String, ByRef boo_read As Boolean, ByRef fecha As String)
        On Error GoTo msgerror
        Dim opr_trabajo As New Cls_Trabajo()
        'FUNCION QUE GRABA LOS DATOS DEL ARCHIVO A LA BASE DE DATOS 
        ' EN LA TABLA RESUL_PROCESADOS
        Dim aux As TextReader
        Dim int_Nres As Short
        Dim str_sni As String
        Dim int_Nped As Integer
        Dim STR_AUXPED As String  'ALMACENO EL NUMERO DE PEDIDO QUE DEVUELVE EL EQUIPO, SI ESTE NO ES NUMERO EJ: 2PP234
        Dim STR_AUXTEST As String   'VOY A ALMACENAR LA PARTE DEL CODIGO DE LA PRUEBA ESPECIAL QUE SE AGREGA AL PEDIDO EJM: 2PP
        Dim str_fecha As String = ""
        Dim str_hora As String = ""
        Dim i As Short
        Dim shr_limite As Short = 0
        Dim str_turno As String
        Dim str As String
        Dim shr_muestra As Short = 0
        Dim d As Array
        Dim str_dpedido() As String

        aux = File.OpenText(archivo)
        str = aux.ReadLine
        d = Split(str, ",")
        int_Nres = CInt(d(9))
        str_sni = CStr(d(2))
        'Si la cadena que recibo como fecha no es de 8 digitos no me sirve el archivo y lo elimino
        If Len(CStr(d(4))) <> 8 Then
            'Pongo la bandera de lectura en True para que el archivo sea eliminado
            'Doy una fecha ficticia para que el archivo sea eliminado como antiguo
            fecha = "2000/01/01"
            aux.Close()
            boo_read = True
            Exit Sub
        End If
        str_fecha = CStr(d(4))
        str_hora = CStr(d(5))
        str = str_fecha.Substring(0, 4) & "/" & str_fecha.Substring(4, 2) & "/" & str_fecha.Substring(6, 2)
        str_fecha = str
        fecha = str_fecha
        'JPO: 21/Oct/04: Si la cadena de la fecha que he armado no resulta ser una fecha la elimino
        If IsDate(fecha) = False Then
            'Pongo la bandera de lectura en True para que el archivo sea eliminado
            'Doy una fecha ficticia para que el archivo sea eliminado como antiguo
            fecha = "2000/01/01"
            boo_read = True
            aux.Close()
            Exit Sub
        End If
        str = str_hora.Substring(0, 2) & ":" & str_hora.Substring(2, 2) '& ":" & str_hora.Substring(4, 2)
        str_hora = str
        str_dpedido = Split(d(6), "-")
        If IsNumeric(str_dpedido(0)) Then
            str_turno = CStr(str_dpedido(0))
        End If
        If IsNumeric(str_dpedido(1)) Then
            shr_muestra = CInt(str_dpedido(1))
        End If
        'str_turno = CStr(d(6))

        If str_sni = "COM2" Or str_sni = "FOLDER2" Then 'SI VIENE DEL CELL DYN/CELL TAC E  CAPTURO EL LIMITE (1 hombres,2 mujeres,3 NIÑOs,4 dilusiones)
            'str_turno = 0 'd(3)
            'EN EL CAMPO DE No. DE PEDIDO VIENE DEL CELL TAC EL No. DE TURNO
            'Y TENEMOS QUE CONSULTAR EL NUMERO DE PEDIDO EN FUNCION DEL TURNO Y LA FECHA
            'str_turno = CStr(d(6))
            shr_limite = CInt(d(8))
        End If
        Dim opr_pedido As New Cls_Pedido()
        If IsNumeric(d(6)) = True Then
            'int_Nped = CInt(d(6))
            str_turno = CStr(d(6))
        Else
            'STR_AUXPED = d(6)
            'STR_AUXTEST = ""
            'STR_AUXTEST = Left(d(6), 3)
            'If IsNumeric(Mid((6), 4)) Then
            '    int_Nped = CInt((Mid(d(6), 4)))
            'Else
            '    int_Nped = 0
            'End If
            If IsNumeric(str_dpedido(0)) Then
                str_turno = CStr(str_dpedido(0))
            End If
            If IsNumeric(str_dpedido(1)) Then
                shr_muestra = CInt(str_dpedido(1))
            End If
        End If
        'int_Nped = CInt(d(6))
        If str_turno <> "" And (str_sni = "COM2" Or str_sni = "FOLDER2") Then 'en el caso de ser archivos enviados desde el Cell Dyn/CELL TAC E 
            'Comentado para que funcione los turnos diarios
            'If opr_pedido.Existeturno(str_fecha, str_turno, CInt(d(6)), False) = True Then

            int_Nped = LeerPedidoxTurnoDia(CInt(str_turno), CDate(str_fecha))

            If opr_pedido.ExistePedido(int_Nped) = 1 Then  'Si existe el pedido y no est� validado
                '0 = no existe o ya esta validado
                For i = 1 To int_Nres
                    str = aux.ReadLine
                    d = Split(str, ",")
                    'RECUPERO LA ABREV, ERROR Y EL RESULTADO DEL TEST  Y MANDO A GRABAR
                    'Hago una verificacion seg�n el limite devuelto por el equipo CD1700
                    Dim str_abrev As String = CStr(d(1))
                    'En caso de ser limite dos ejecuta normalmente (MUJERES)
                    If shr_limite = 1 Then  'en caso de uno (HOMBRES)
                        str_abrev = Trim(str_abrev) & "H"
                        boo_read = GuardarResArchivoLimite(int_Nped, str_fecha, str_hora, str_abrev, str_sni, CDbl(d(3)), CStr(d(2)), 1)
                    End If
                    If shr_limite = 3 Then  'en caso de tres (Neonatos)
                        str_abrev = Trim(str_abrev) & "R"
                        boo_read = GuardarResArchivoLimite(int_Nped, str_fecha, str_hora, str_abrev, str_sni, CDbl(d(3)), CStr(d(2)), 3)
                    End If
                    If shr_limite = 4 Then  'en caso de cuatro (NIÑOS)
                        str_abrev = Trim(str_abrev) & "N"
                        boo_read = GuardarResArchivoLimite(int_Nped, str_fecha, str_hora, str_abrev, str_sni, CDbl(d(3)), CStr(d(2)), 4)
                    End If
                    If shr_limite = 0 Or shr_limite = 2 Then
                        boo_read = GuardarResArchivo(int_Nped, str_fecha, str_hora, str_abrev, str_sni, CDbl(d(3)), CStr(d(2)))
                    End If
                Next
                If boo_read = True Then
                    opr_trabajo.Actu_Test_Trabajo(int_Nped, 400101, "")
                End If
            Else
                boo_read = False
                '    If opr_pedido.ExistePedido(int_Nped) = 2 Then
                '        GuardarLogArchivo(d(6).ToString, str_sni, CStr(d(1)), str_fecha, str_hora, "Validado")
                '    Else
                '        ' = 0   No existe el pedido
                '        GuardarLogArchivo(d(6).ToString, str_sni, CStr(d(1)), str_fecha, str_hora, "No existe pedido")
                '    End If
            End If
            'Comentado para que funcione los turnos diarios 
            'Else
            '    'Aqui no puedo registrar la prueba que se ejecut� ya que todav�a no leo las pruebas solo verifique que no existe el turno ni el pedido
            '    GuardarLogArchivo(d(6).ToString, str_sni, str_sni, str_fecha, str_hora, "Sin pedido o turno")
            'End If
        End If
        If ((str_sni = "COM2" Or str_sni = "FOLDER2") And str_turno = "") Then
            aux.Close()
            GuardarLogArchivo(d(6).ToString, str_sni, CStr(d(1)), str_fecha, str_hora, "No posee turno")
            Exit Sub
        End If
        'Cuando se trata de otros equipos diferentes al CEll Dyn
        If str_sni <> "COM2" And str_sni <> "FOLDER2" Then
            Dim estado_prueba As Short = 0
            int_Nped = LeerPedidoxTurnoDia(CInt(str_turno), CDate(str_fecha))
            If opr_pedido.ExistePedido(int_Nped) = 1 Then  'Si existe el pedido y no est� validado
                For i = 1 To int_Nres
                    str = aux.ReadLine
                    d = Split(str, ",")
                    'VERIFICO QUE EL ARCHIVO SE PUEDA ACTUALIZAR EL RESULTADO

                    estado_prueba = opr_trabajo.LeerEstadoTest_LT(int_Nped, CStr(d(1)))
                    If estado_prueba <> 2 Then ' La prueba no ha sido validada a�n
                        If (STR_AUXTEST = "2PP" Or STR_AUXTEST = "CCR") Then
                            Select Case STR_AUXTEST
                                Case "2PP"   'CASO DE GLUCOSA POST PRANDIAL
                                    boo_read = GuardarResArchivo(int_Nped, str_fecha, str_hora, "GLUP", str_sni, CDbl(d(3)), CStr(d(2)))
                                    If boo_read = True Then
                                        opr_trabajo.Actu_Test_Trabajo(int_Nped, LeerTestID("GLUP"), "")
                                    End If

                                Case "CCR"   'CASO DE CLEARENCE DE CREATININA
                                    boo_read = GuardarResArchivo(int_Nped, str_fecha, str_hora, "CCR", str_sni, CDbl(d(3)), CStr(d(2)))
                                    If boo_read = True Then
                                        opr_trabajo.Actu_Test_Trabajo(int_Nped, LeerTestID("CCR"), "")
                                    End If
                            End Select
                        Else
                            If (CStr(d(1)) = "LDL") Or (CStr(d(1)) = "IBIL") Then
                                If (CStr(d(1)) = "LDL") Then
                                    opr_trabajo.Actu_Test_Trabajo(int_Nped, 400295, CStr(Trim(d(3))))
                                    opr_trabajo.GuardarRangoManual(int_Nped, 400295, "0.0 - 130")
                                    boo_read = True
                                End If
                                If (CStr(d(1)) = "IBIL") Then
                                    opr_trabajo.GrabaIBil(int_Nped, 400296, d(3))
                                    opr_trabajo.GuardarRangoManual(int_Nped, 400296, "0.0 - 0.75")
                                    boo_read = True
                                End If
                            Else
                                boo_read = GuardarResArchivo(int_Nped, str_fecha, str_hora, CStr(d(1)), str_sni, CDbl(d(3)), CStr(d(2)))
                                If boo_read = True Then
                                    opr_trabajo.Actu_Test_Trabajo(int_Nped, LeerTestID(CStr(d(1))), "")
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        End If
        'Else    'El campo # pedido del archivo no es n�merico, no corresponde a ningun pedido
        '     GuardarLogArchivo(d(6).ToString, str_sni, CStr(d(1)), str_fecha, str_hora, "No existe pedido")
        ' End If
        aux.Close()
        Exit Sub
msgerror:
        Err.Clear()
        fecha = "2000/01/01"
        boo_read = True
        aux.Close()
    End Sub

    Public Function LeerTestID(ByVal abrev As String) As Integer
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        str_sql = "select T.TES_ID from test_equipo as TE, test as T where TE.TEQ_ABRV_FIJA = '" & abrev & "' AND TE.TES_ID = T.TES_ID"
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            LeerTestID = 0
        Else
            LeerTestID = dts_datos.Tables(0).Rows(0).Item(0)
        End If
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Test Id", Err)
        Err.Clear()
    End Function

    Public Function GuardarResArchivo(ByVal ped_id As Integer, ByVal prc_fecha As String, _
                                  ByVal prc_hora As String, ByVal tes_abrev As String, _
                                  ByVal sni_nombre As String, ByVal prc_resul As String, _
                                  ByVal prc_error As String) As Boolean
        'Procedimiento para la insertar un registro en la tabla RES_PROCESADOS

        On Error GoTo MsgError
        Dim OPR_PED As New Cls_Pedido()
        Dim INT_TEST As Integer = ConsultaTestIDxPedido(ped_id, tes_abrev)
        GuardarResArchivo = False
        Dim str_sql As String = ""
        If OPR_PED.EstadoPrueba(ped_id, INT_TEST) = 1 Then 'SI SE PUEDE ACTUALIZAR EL RESUTADO 
            opr_conexion.sql_conectar()

            GuardarResArchivo = False
            str_sql = "update res_procesados set prc_fecha = '" & prc_fecha & "', prc_hora = '" & prc_hora & "', " & _
                      " sni_nombre = '" & sni_nombre & "', prc_resul = '" & prc_resul & "', prc_error= '" & prc_error & "', " & _
                      " prc_resfinal='" & prc_resul & "' where ped_id = " & ped_id & " and tes_abrev = '" & tes_abrev & "'"
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            GuardarResArchivo = True
            opr_conexion.sql_desconn()
        End If
        'Dim opr_pedido As New Cls_Pedido()
        'opr_pedido.ActualizarPdd_Estado(ped_id, CInt(lbl_test.Text), 1)
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Resultado Modificado", tes_abrev & "=" & prc_resul, g_sng_user, "", "", "")
        Exit Function

MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar ResArchivo", Err)
        GuardarResArchivo = False
        Err.Clear()
    End Function

    Public Function Consultar_tipoPaciente(ByVal ped_id As Integer) As String
        'R: NEONATO (0-1 A�O)
        'N: NIÑO (1-12 A�OS)
        'H: HOMBRE 
        'M: MUJER 
        On Error GoTo MsgError
        Dim str_sexo, str_usafecnac, str_limite As String
        Dim dat_fecnac As Date

        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand("select paciente.pac_usafecnac, paciente.pac_sexo, paciente.pac_fecnac from paciente, pedido where pedido.ped_id = " & ped_id & " and pedido.pac_id = paciente.pac_id;", opr_Conexion.conn_sql)
        Dim dts_bonificacion As New DataSet()
        opr_Conexion.sql_desconn()
        Dim dtr_fila As DataRow
        str_limite = "H"
        oda_operacion.Fill(dts_bonificacion, "Registros")
        For Each dtr_fila In dts_bonificacion.Tables("Registros").Rows
            If (IsDBNull(dtr_fila(0))) Then
                str_limite = "H"
            Else
                str_usafecnac = dtr_fila(0)
                str_sexo = dtr_fila(1)
                If str_usafecnac = "1" Then
                    dat_fecnac = dtr_fila(2)
                End If
            End If
            Exit For
        Next
        If str_usafecnac = "1" Then
            Dim int_meses As Integer = 0
            'SI EL PACIENTE DE ESTE PEDIDO SE INGRESO CON FECHA DE NACIMIENTO
            If IsDate(dat_fecnac) Then
                int_meses = DateDiff(DateInterval.Month, dat_fecnac, Today)
                If int_meses >= 0 And int_meses <= 2 Then
                    Consultar_tipoPaciente = "R"
                Else
                    If int_meses >= 13 And int_meses <= 144 Then
                        Consultar_tipoPaciente = "N"
                    Else
                        If str_sexo = "F" Then
                            Consultar_tipoPaciente = "M"
                        Else
                            Consultar_tipoPaciente = "H"
                        End If
                    End If
                End If
            Else
                If str_sexo = "F" Then
                    Consultar_tipoPaciente = "M"
                Else
                    Consultar_tipoPaciente = "H"
                End If
            End If
        Else 'NO SE CONOCE LA FECHA DE NACIMIENTO
            If str_sexo = "F" Then
                Consultar_tipoPaciente = "M"
            Else
                Consultar_tipoPaciente = "H"
            End If
        End If

        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("Problemas al realizar la transaccion solicitada, Consultar_tipoPaciente", Err)
        Err.Clear()
    End Function

    'Public Function consultarTipoPaciente(ByVal ped_id As Integer) As String
    '    Dim fec_nac, sexo As String

    'End Function

    Public Function LeerTipoMuestraTest(ByVal tes_id As Integer) As Integer
        'Funcion para la consultar el tipo de muestra de un test 
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerTipoMuestraTest = CInt(New SqlCommand("Select isnull(tim_id,0) from TEST WHERE TES_ID = " & tes_id & "", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer tipo de muestra x Test", Err)
        Err.Clear()
    End Function


    Public Sub GuardarTrabajoResArchivo(ByVal ped_id As Integer, ByVal prc_fecha As String, _
                                  ByVal prc_hora As String, ByVal tes_abrev As String, _
                                  ByVal sni_nombre As String, ByVal prc_resul As String, _
                                  ByVal prc_error As String, ByVal equipo As String, ByVal tipo As String, ByVal tes_id As Integer)
        'Procedimiento para la insertar un registro en la tabla RES_PROCESADOS

        On Error GoTo MsgError
        Dim str_tipo_pac As String
        Dim int_muestra As Integer = 0
        str_tipo_pac = Consultar_tipoPaciente(ped_id)
        If str_tipo_pac = "M" Then
            str_tipo_pac = ""
        End If
        ' MsgBox(str_tipo_pac, MsgBoxStyle.Critical, "ANALISYS")

        opr_conexion.sql_conectar()
        Dim str_sql As String = ""
        Dim odc_pedido As SqlCommand
        If (tes_abrev = "BIOMETRIA HEMATICA") Or (tes_abrev = "HGB") Or (tes_abrev = "HCT") Or (tes_abrev = "PLT") Or (tes_abrev = "FORMULA LEUCOCITARIA") Or (tes_abrev = "INDICES HEMATICOS") Then
            'JPO: en este caso se almacena la estructura original de la Biometria Hem�tica
            'y en caso de requerir cambios en los parametros de la BH se deber� cambiar 
            'tambien en la parte donde en caso de modificar el pedido (eliminar) y modificar 
            'lista de trabajo
            Dim str_resultados, str_datos() As String
            str_resultados = ""
            Dim x As Short = 0
            If Trim(Mid(equipo, 1, 150)) = "Cell Dyn 3500" Or Trim(Mid(equipo, 1, 150)) = "Cell Dyn 3700" Or Trim(Mid(equipo, 1, 150)) = "CellTac F" Then
                'En caso de alamcenar una prueba del cell dyn 3500 genero la siguiente estructura de biometria en la tabla RES_PROCESADOS
                str_resultados = "WBC,NEU%25,LYM%25,MONO%25,EOS%25,BASO%25,NEU,LYM,MONO,EOS,BASO,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,MPV"
            End If
            If Trim(Mid(equipo, 1, 150)) = "Cell Dyn 1700" Then
                'En caso de alamcenar una prueba del cell dyn 1700 genero la siguiente estructura de biometria en la tabla RES_PROCESADOS
                str_resultados = "WBC,LYM%25,MID%25,GRN%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT"
            End If
            If Trim(Mid(equipo, 1, 150)) = "CellTac E" Then
                'En caso de alamcenar una prueba del cell dyn 1700 genero la siguiente estructura de biometria en la tabla RES_PROCESADOS
                str_resultados = "WBC,NE,LY,MO,EO,BA,NE%25,LY%25,MO%25,EO%25,BA%25,RBC,HGB,HCT,MCV,MCH,MCHC,RDW,PLT,PCT,MPV,PDW"
            End If
            str_datos = Split(str_resultados, ",")
            If tes_abrev = "BIOMETRIA HEMATICA" Then
                int_muestra = LeerTipoMuestraTest(tes_id)
                For x = 0 To UBound(str_datos)
                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & str_datos(x) & str_tipo_pac & "', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                    odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                    odc_pedido.ExecuteNonQuery()
                Next
            Else
                'JVA 06 NOV
                If tes_abrev = "HGB" Then 'HEMOGLOBINA
                    int_muestra = LeerTipoMuestraTest(tes_id)
                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & str_datos(12) & "', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                    odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                    odc_pedido.ExecuteNonQuery()
                Else
                    If tes_abrev = "HCT" Then 'HEMATOCRITOS
                        int_muestra = LeerTipoMuestraTest(tes_id)
                        str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & str_datos(13) & "', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                        odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                        odc_pedido.ExecuteNonQuery()
                    Else
                        If tes_abrev = "PLT" Then ' PLAQUETAS
                            int_muestra = LeerTipoMuestraTest(tes_id)
                            str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & str_datos(18) & "', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                            odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                            odc_pedido.ExecuteNonQuery()
                        Else
                            If tes_abrev = "FORMULA LEUCOCITARIA" Then
                                int_muestra = LeerTipoMuestraTest(tes_id)
                                For x = 6 To 10
                                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & str_datos(x) & "', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                                    odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                                    odc_pedido.ExecuteNonQuery()
                                Next
                            End If
                            If tes_abrev = "INDICES HEMATICOS" Then
                                int_muestra = LeerTipoMuestraTest(tes_id)
                                For x = 14 To 16
                                    str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & str_datos(x) & "', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                                    odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
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
                int_muestra = LeerTipoMuestraTest(tes_id)
                str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', 'UREA', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
                str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', 'BUN', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            Else
                int_muestra = LeerTipoMuestraTest(tes_id)
                str_sql = "Insert into RES_PROCESADOS values (" & ped_id & ", '" & prc_fecha & " ', '" & prc_hora & "', '" & tes_abrev & "', '" & sni_nombre & "', " & prc_resul & ", '" & prc_error & "'," & prc_resul & ", '', " & int_muestra & ")"
                odc_pedido = New SqlCommand(str_sql, opr_conexion.conn_sql)
                odc_pedido.ExecuteNonQuery()
            End If
        End If
        opr_conexion.sql_desconn()
        Exit Sub
MsgError:
        'g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Trabajo ResArchivo", Err)
        'Err.Clear()
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Public Function Abrev_TestAuto(ByVal tes_id As Integer) As String
        'Funci�n que consulta la abreviatura de un test en un equipo
        On Error GoTo MsgError
        'Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = ""
        str_sql = "select teq_abrv_fija from test_equipo where tes_id = " & tes_id & " and teq_prioridad = 1 and teq_estado = 1"
        opr_conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            Abrev_TestAuto = ""
        Else
            Abrev_TestAuto = dts_datos.Tables(0).Rows(0).Item(0).ToString
        End If
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Abrev TestAuto", Err)
        Err.Clear()
    End Function

    Public Sub Guarda_Dat_Hist(ByVal archivo As String, ByRef boo_read As Boolean, ByRef fecha As String)
        On Error GoTo msgerror
        'FUNCION QUE GRABA LOS DATOS DEL ARCHIVO A LA BASE DE DATOS 
        ' EN LA TABLA 
        Dim datos As String = ""
        Dim aux As TextReader
        Dim int_Nped As Long
        Dim d As Array
        Dim str As String
        Dim Nom_his As String = ""
        Dim ndatos As Integer = 0
        Dim i As Integer = 1
        Dim str_turno As Short

        aux = File.OpenText(archivo)
        str = aux.ReadLine
        d = Split(str, ",")
        Dim str_fecha As String
        'Si el cadena que recibo como fecha no tiene 8 digitos el archivo posee una fecha no valida y lo elimino
        If Len(CStr(d(4))) <> 8 Then
            'Pongo la bandera de lectura en True para que el archivo sea eliminado.
            'Doy una fecha ficticia para que sea eliminado como un archivo antiguo
            fecha = "2000/01/01"
            aux.Close()
            boo_read = True
            Exit Sub
        End If
        str_fecha = CStr(d(4))

        str_fecha = str_fecha.Substring(0, 4) & "/" & str_fecha.Substring(4, 2) & "/" & str_fecha.Substring(6, 2)
        fecha = str_fecha
        If (IsDate(fecha)) = False Then
            fecha = "2000/01/01"
            aux.Close()
            boo_read = True
            Exit Sub
        End If
        If IsNumeric(d(6)) Then ' SI SOLO HAY EL NUMERO DE PEDIDO SIN MUESTRA.
            'EN EL EQUIPO CELLTAC E NO SE TRABAJA CON EL NUMERO DE PEDIDO  
            'SINO CON UN TURNO DIARIO DE 1 - 100 POR LO QUE EL NUMERO QUE SE INGRESA COMO 
            'IDENTIFICADOR DE LA PRUEBA EN EL EQUIPO CORRESPONDE AL NUMERO DE TURNO
            'int_Nped = CInt(d(6))
            str_turno = CInt(d(6))
            int_Nped = LeerPedidoxTurnoDia(str_turno, CDate(str_fecha))
        Else
            'No existe el pedido (porque no es numerico), guardo en un log el archivo descargado
            Dim str_dpedidos() As String
            str_dpedidos = Split(d(6), "-")
            If IsNumeric(str_dpedidos(0)) Then
                str_turno = CInt(str_dpedidos(0))
                int_Nped = LeerPedidoxTurnoDia(str_turno, CDate(str_fecha))
            End If
            aux.Close()
            Exit Sub
        End If

        If (opr_pedido.ExistePedido(int_Nped) = 0) Then
            'No existe el pedido, guardo en un log el archivo descargado
            aux.Close()
            Exit Sub
        End If
        If opr_pedido.PedidoConHisto(int_Nped) = 0 Then
            'El pedido no posee histogramas por lo que registro el archivo en un log y no lo agrego a la base.
            aux.Close()
            Exit Sub
        End If

        'Verifico que exista el pedido y el turno 
        If opr_pedido.Existeturno(Format(Today, "dd/MM/yyyy"), str_turno, 0, False) = False Then
            aux.Close()
            Exit Sub
        End If
        Nom_his = CStr(d(7))
        ndatos = CInt(d(9))
        For i = 1 To (ndatos)
            str = aux.ReadLine
            d = Split(str, ",")
            datos = datos & d(2) & ","
        Next
        aux.Close()
        GuardarHistograma(int_Nped, Nom_his, datos)
        boo_read = True
        Exit Sub
msgerror:
        Err.Clear()
        fecha = "2000/01/01"
        aux.Close()
        boo_read = True
        Exit Sub
    End Sub

    Private Function LeerPedidoxTurnoDia(ByVal turno As Short, ByVal fecha As Date) As Long
        'Funci�n que lee el No. de Pedido en funci�n de un turno diario para lo cual requiere 
        'de el No. de turno y el d�a del turno.
        On Error GoTo msgerror
        Dim opr_Conexion As New Cls_Conexion()
        Dim oda_operacion As SqlDataAdapter = New SqlDataAdapter()
        Dim dts_datos As New DataSet()
        Dim str_sql As String = "select ped_id from pedido where ped_turno = " & turno & " and ped_fecing between '" & Format(fecha, "dd/MM/yyyy") & " 00:00:00' and '" & Format(fecha, "dd/MM/yyyy") & " 23:59:59'"
        LeerPedidoxTurnoDia = 0
        opr_Conexion.sql_conectar()
        oda_operacion.SelectCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
        oda_operacion.Fill(dts_datos, "Registros")
        If (dts_datos.Tables(0).Rows.Count = 0) Then
            LeerPedidoxTurnoDia = 0
        Else
            LeerPedidoxTurnoDia = dts_datos.Tables(0).Rows(0).Item(0)
        End If
        opr_Conexion.sql_desconn()
        Exit Function
msgerror:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, LeerPedidoxTurnoDia", Err)
        Err.Clear()
    End Function

    Public Sub GuardarHistograma(ByVal ped_id As Integer, ByVal his_nombre As String, ByVal dat_his As String)
        'Procedimiento para la insertar un registro en la tabla PTOHISTOGRAMA
        On Error GoTo MsgError
        Dim str_sql As String
        'Verifico que no exista el registro del histograma 
        'En caso de haber actualizo, en caso de no haber grabo nuevo 
        If ExisteHisSN(ped_id, his_nombre) = False Then
            str_sql = "Insert into PTOHISTOGRAMA values (" & ped_id & ", '" & his_nombre & "', '" & dat_his & "')"
        Else
            str_sql = "Update PTOHISTOGRAMA set datos = '" & dat_his & " ' where ped_id = " & ped_id & " and his_nombre = '" & his_nombre & "'"
        End If
        opr_conexion.sql_conectar()
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Histograma Mdificado", "", g_sng_user, "", "", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Histograma", Err)
        Err.Clear()
    End Sub


    Public Function ExisteHisSN(ByVal Ped_id As Integer, ByVal his_nombre As String) As Boolean
        On Error GoTo msgerror
        'Funci�n que consulta si ya tiene el pedido histograma
        ExisteHisSN = False
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        If CShort(New SqlCommand("Select count(ped_id) from ptohistograma where ped_id = " & Ped_id & " and his_nombre = '" & his_nombre & "'", opr_Conexion.conn_sql).ExecuteScalar) > 0 Then
            ExisteHisSN = True
        End If
        opr_Conexion.sql_desconn()
        Exit Function
msgerror:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Existe Histograma S/N", Err)
        Err.Clear()
    End Function

    Public Function DNLDimensionAR(ByRef dtr_fila As DataRow) As String
        On Error GoTo MsgError
        ' dtr_fila posee 48 campos
        Dim str_sniNombre, str_formato, str_elemento(), str_cadena, str_sql As String
        str_formato = dtr_fila("EQU_FORMATO").ToString()  'Almaceno el formato de la cadena que necesita el equipo para entender una orden
        str_elemento = Split(str_formato, ",")
        Dim sng_i, sng_count As Single
        sng_i = UBound(str_elemento)
        str_sniNombre = dtr_fila("SNI_NOMBRE").ToString() 'Almaceno el nombre del dispositivo de interfaceamiento (SNI o COM)
        str_cadena = ""
        If Mid(str_sniNombre, 1, 1) = "S" Then  'Si la prueba se realiza en un equipo conectado con SNI 
            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
                str_cadena = ""
                For sng_count = 0 To sng_i
                    Select Case str_elemento(sng_count)
                        Case "ID"
                            str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","
                        Case "Code"
                            Select Case dtr_fila("PED_TIPO").ToString
                                Case "NORMAL"
                                    str_cadena = str_cadena & "0,"
                                Case "URGENCIA"
                                    str_cadena = str_cadena & "1,"
                                Case "ASAP"
                                    str_cadena = str_cadena & "2,"
                                Case "QC"
                                    str_cadena = str_cadena & "3,"
                                Case "XQC"
                                    str_cadena = str_cadena & "4,"
                                Case Else
                                    str_cadena = str_cadena & "0,"
                            End Select
                        Case "Action Code"
                            str_cadena = str_cadena & "AP,"
                        Case "LoadList"
                            str_cadena = str_cadena & "0;"
                        Case "CarrierID"
                            str_cadena = str_cadena & "0,"
                        Case "Type"
                            'Tipo de muestra (LIS_EQUTIMID)
                            str_cadena = str_cadena & Trim(dtr_fila("PER_ID").ToString) & ","
                        Case "SampleID"
                            str_cadena = str_cadena & dtr_fila("LIS_EQUTIMID").ToString & ";"
                            'str_cadena = str_cadena & ";"
                        Case "Dilution"
                            opr_conexion.sql_conectar()
                            str_sql = "select a.* from testequipo_tipmuestra as a , test_equipo as b where b.tes_id = " & dtr_fila("TES_ID").ToString() & " and b.equ_id = " & dtr_fila("EQU_ID").ToString() & " and a.tim_id = " & dtr_fila("TIM_ID").ToString() & " and a.teq_id = b.teq_id"
                            Dim oda_disol As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_disol As New DataSet()
                            oda_disol.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
                            oda_disol.Fill(dts_disol, "Registros")
                            Dim dtr_dfila As DataRow
                            If dts_disol.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_dfila In dts_disol.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_dfila(2).ToString() & ","
                                Next
                            Else
                                str_cadena = str_cadena & ","
                            End If
                            opr_conexion.sql_desconn()
                        Case "PatientID"
                            str_cadena = str_cadena & ";"
                        Case "SSN"
                            str_cadena = str_cadena & ";"
                        Case "Last First"
                            str_cadena = str_cadena & ";"
                        Case "Mid"
                            str_cadena = str_cadena & ";"
                        Case "Blank"
                            str_cadena = str_cadena & ";"
                        Case "Location"
                            str_cadena = str_cadena & ","
                        Case "Blanco"
                            str_cadena = str_cadena & ","
                        Case "Test"
                            Dim STR_SQL3 As String
                            opr_conexion.sql_conectar()
                            STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("TES_ID").ToString()
                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_test As New DataSet()
                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                            oda_test.Fill(dts_test, "Registros")
                            Dim dtr_test As DataRow
                            If dts_test.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            Else
                                STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_EQUIPO  WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString()
                                dts_test = New DataSet()
                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                                oda_test.Fill(dts_test, "Registros")
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            End If
                            opr_conexion.sql_desconn()
                        Case ""
                            str_cadena = str_cadena & ","
                    End Select
                Next
            End If
        Else  'Si la prueba se realiza en un equipo conectado con COM o FOLDER (C � F)
            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
                str_cadena = ""
                For sng_count = 0 To sng_i
                    Select Case str_elemento(sng_count)
                        Case "Equipo"
                            str_cadena = str_cadena & dtr_fila("EQU_MODELO").ToString & ","
                        Case "ID"
                            'str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","
                            str_cadena = str_cadena & dtr_fila("PED_TURNO").ToString() & ","
                        Case "Code"
                            Select Case dtr_fila("PED_TIPO").ToString
                                Case "NORMAL"
                                    str_cadena = str_cadena & "0,"
                                Case "URGENCIA"
                                    str_cadena = str_cadena & "1,"
                                Case "ASAP"
                                    str_cadena = str_cadena & "2,"
                                Case "QC"
                                    str_cadena = str_cadena & "3,"
                                Case "XQC"
                                    str_cadena = str_cadena & "4,"
                                Case Else
                                    str_cadena = str_cadena & "0,"
                            End Select
                        Case "Type"
                            'Tipo de muestra                            
                            str_cadena = str_cadena & Trim(dtr_fila("LIS_EQUTIMID").ToString) & ","
                        Case "Position"
                            'If dtr_fila("LIS_POSNUM").ToString = "0" Then
                            '    'En caso de ser c�digo de barras
                            str_cadena = str_cadena & "*,"
                            'Else
                            '    'Caso contrario se env�a la posici�n
                            '    'str_cadena = str_cadena & dtr_fila("LIS_POSNUM").ToString & ","
                            'str_cadena = str_cadena & "0,"
                            'End If
                        Case "PatientName"
                            str_cadena = str_cadena & dtr_fila("Nombres").ToString & ","
                        Case "SampleCarrierID"
                            'RAck o Rueda en la que est� la muestra, si no se utiliza c�digo de barras
                            'str_cadena = str_cadena & "," & dtr_fila("LIS_EQUTIMID").ToString
                            str_cadena = str_cadena & ",0"
                        Case "Test"
                            Dim STR_SQL3 As String
                            STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("EQU_ID").ToString()
                            opr_conexion.sql_conectar()
                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_test As New DataSet()
                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                            oda_test.Fill(dts_test, "Registros")
                            Dim dtr_test As DataRow
                            If dts_test.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            Else
                                STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_EQUIPO WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString()
                                dts_test = New DataSet()
                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                                oda_test.Fill(dts_test, "Registros")
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    'CODIGO QUE PERMITE ENVIAR AL EQUIPO PRUEBAS TALES COMO GLUCOSA POST PRANDIAL O CLEARENCE DE CREATININA O ALGUNA OTRA GLUCOSA ESPECIAL
                                    'CUYA ABREVIATURA PARA EL EQUIPO ES GLU O CREA, PARA LO CUAL ES NECESARIO UTILIZAR UN ARTIFICIO QUE PONE AL PEDIDO TRES DIGITOS PRIMERO
                                    '2PP -> PARA POSPRANDIAL Y CCR -> PARA CLEARENCE DE CREATININA, PARA DE ESTA FORMA OBLIGAR AL EQUIPO PARA QUE ASIGNE OTRA POSICI�N PARA 
                                    'ESTAS PRUEBAS Y LAS CORRA COMO GLUCOSA O CREATININA NORMAL 

                                    If (dtr_test("TEQ_ABREVIATURA").ToString() = "GLUP" Or dtr_test("TEQ_ABREVIATURA").ToString() = "CCR") Then
                                        Dim nueva_Cadena() As String
                                        Dim Aux As String = ""
                                        Dim i_cont As Single = 0
                                        'COPIO LA CADENA QUE SE ESTABA GENERANDO EN UNA NUEVA
                                        nueva_Cadena = Split(str_cadena, ",")
                                        'VOY COPIANDO UNO A UNO LOS ITEMS DE LA CADENA 
                                        'Y REALIZO CAMBIOS EN LA POSICION DEL PEDIDO Y DEL TEST
                                        For i_cont = 0 To (UBound(nueva_Cadena) - 1)
                                            If i_cont = 2 Then
                                                Select Case dtr_test("TEQ_ABREVIATURA").ToString()
                                                    Case "GLUP"
                                                        Aux = Aux & "2PP" & nueva_Cadena(i_cont) & ","
                                                    Case "CCR"
                                                        Aux = Aux & "CCR" & nueva_Cadena(i_cont) & ","
                                                End Select
                                            Else
                                                Aux = Aux & nueva_Cadena(i_cont) & ","
                                            End If
                                        Next
                                        'ASIGNO A LA CADENA LA PRUEBA QUE REALMENTE EJECUTA EL EQUIPO
                                        Select Case dtr_test("TEQ_ABREVIATURA").ToString()
                                            Case "GLUP"
                                                Aux = Aux & "GLU,"
                                            Case "CCR"
                                                Aux = Aux & "CREA,"
                                        End Select
                                        'PONGO COMO CADENA GENERADA LA QUE MODIFICAMOS
                                        str_cadena = Aux
                                    Else
                                        str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                    End If
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            End If
                            opr_conexion.sql_desconn()
                        Case ""
                            str_cadena = str_cadena & ","
                    End Select
                Next
            End If
        End If
        DNLDimensionAR = str_cadena
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, DNL DimensionAR", Err)
        Err.Clear()
    End Function


    '    Public Function DNLCellDyn3500(ByRef dtr_fila As DataRow) As String
    '        On Error GoTo MsgError
    '        ' dtr_fila posee 48 campos
    '        Dim str_sniNombre, str_formato, str_elemento(), str_cadena, str_sql As String
    '        str_formato = dtr_fila("EQU_FORMATO").ToString()  'Almaceno el formato de la cadena que necesita el equipo para entender una orden
    '        str_elemento = Split(str_formato, ",")
    '        Dim sng_i, sng_count, parametro, limite As Single
    '        Dim str_fecha As Date
    '        Dim m_edad As Integer
    '        sng_i = UBound(str_elemento)
    '        str_sniNombre = dtr_fila("SNI_NOMBRE").ToString() 'Almaceno el nombre del dispositivo de interfaceamiento (SNI o COM)
    '        str_cadena = ""

    '        'DEFINO EL PARAMETRO (QUE PRUEBAS SE REQUIEREN) Y EL LIMITE (RANGOS NORMALES)
    '        If (dtr_fila("USAFECNAC").ToString) = 1 Then
    '            'TIENE DEFINIDA FECHA DE NACIMIENTO
    '            If IsDate(dtr_fila("FECNAC").ToString) Then
    '                str_fecha = CDate(dtr_fila("FECNAC").ToString)
    '                m_edad = DateDiff(DateInterval.Month, str_fecha, Today)
    '                If m_edad <= 1 Then 'PARAMETRO NEONATO 
    '                    limite = 4
    '                Else
    '                    If m_edad <= 144 Then  'PARAMETRO NINO
    '                        limite = 3
    '                    Else 'CUANDO SON ADULTOS
    '                        If (dtr_fila("SEXO").ToString) = "F" Then
    '                            limite = 1
    '                        Else
    '                            limite = 0
    '                        End If
    '                    End If
    '                End If
    '            Else
    '                If (dtr_fila("SEXO").ToString) = "F" Then
    '                    limite = 1
    '                Else
    '                    limite = 0
    '                End If
    '            End If
    '        Else
    '            'NO TIENE DEFINIDA FECHA DE NACIMIENTO
    '            If (dtr_fila("SEXO").ToString) = "F" Then
    '                limite = 1
    '            Else
    '                limite = 0
    '            End If
    '        End If


    '        If Mid(str_sniNombre, 1, 1) = "S" Then  'Si la prueba se realiza en un equipo conectado con SNI 

    '            'NO SE HA IMPLEMENTADO TODAVIA

    '        Else  'Si la prueba se realiza en un equipo conectado con COM o FOLDER (C � F)
    '            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
    '                str_cadena = ""
    '                For sng_count = 0 To sng_i
    '                    Select Case str_elemento(sng_count)
    '                        'Equipo,PatientName,IDSpeciment,BarCode,Limite,Parametro,Test,blank
    '                    Case "Equipo"
    '                            str_cadena = str_cadena & dtr_fila("EQU_MODELO").ToString & ","
    '                        Case "BarCode"
    '                            str_cadena = str_cadena & "----,"
    '                        Case "IDSpeciment"
    '                            str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","
    '                        Case "PatientName"
    '                            'Nombres del paciente
    '                            str_cadena = str_cadena & dtr_fila("Nombres").ToString & ","
    '                        Case "Limite"
    '                            'Limite (1->hombres adultos, 2->mujeres adultas, 3->NIÑOs)
    '                            str_cadena = str_cadena & limite & ","
    '                            'str_cadena = str_cadena & "1,"
    '                        Case "Parametro"
    '                            '0 -> default
    '                            'str_cadena = str_cadena & "0,"
    '                            str_cadena = str_cadena & parametro & ","
    '                        Case "Test"
    '                            'str_cadena = str_cadena & "BIOMETRIA HEMATICA,"
    '                            Dim STR_SQL3 As String
    '                            opr_Conexion.conn_sql()
    '                            STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("TES_ID").ToString()
    '                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
    '                            Dim dts_test As New DataSet()
    '                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_Conexion.conn_sql)
    '                            oda_test.Fill(dts_test, "Registros")
    '                            Dim dtr_test As DataRow
    '                            If dts_test.Tables("Registros").Rows.Count > 0 Then
    '                                For Each dtr_test In dts_test.Tables("Registros").Rows
    '                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
    '                                Next
    '                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
    '                            Else
    '                                STR_SQL3 = "SELECT DISTINCT TEQ_ABRV_FIJA FROM TEST_EQUIPO WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString() & " LIMIT 1;"
    '                                dts_test = New DataSet()
    '                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_Conexion.conn_sql)
    '                                oda_test.Fill(dts_test, "Registros")
    '                                For Each dtr_test In dts_test.Tables("Registros").Rows
    '                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
    '                                Next
    '                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
    '                            End If
    '                            opr_conexion.sql_desconn
    '                    End Select
    '                Next
    '            End If
    '        End If
    '        DNLCellDyn3500 = str_cadena
    '        Exit Function
    'MsgError:
    '        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, DNL CellDyn3000Series", Err)
    '        Err.Clear()
    '    End Function



    Public Sub ActualizaArchivosRechazados(ByVal archivo As String)
        '26 junio 2003   JPO
        'FUNCION QUE GRABA LOS DATOS DEL ARCHIVO A LA BASE DE DATOS 
        ' EN LA TABLA RESUL_PROCESADOS
        Dim opr_trabajo As New Cls_Trabajo()
        Dim aux As TextReader
        Dim int_Nres As Short
        Dim str_equipo As String
        Dim int_Nped As Integer
        'Dim str_fecha As String = ""
        'Dim str_hora As String = ""
        Dim i As Short
        Dim str As String
        Dim d As Array
        Dim int_lis_id As Integer = 0
        aux = File.OpenText(archivo)
        d = Split(str, ",")
        While aux.Peek <> -1
            str = aux.ReadLine
            d = Split(str, ",")  'Asigno en un arreglo los datos de cada una de las lineas del LOG, (fecha, hora, pedido, paciente, test)
            If IsNumeric(d(2)) Then    'Verifico que le item de #Pedido sea numerico
                int_Nped = CInt(d(2))
                If (opr_pedido.ExistePedido(int_Nped) = 1) Then  'Verifico que el n�mero de pedido capturado corresponda a alg�n pedido
                    'Si es que requiero la hora y la fecha descomento el siguiente c�digo
                    'str = ""
                    'str = str_fecha.Substring(0, 4) & "/" & str_fecha.Substring(4, 2) & "/" & str_fecha.Substring(6, 2)
                    'str_fecha = str
                    'str = ""
                    'str = str_hora.Substring(0, 2) & ":" & str_hora.Substring(2, 2) & ":" & str_hora.Substring(4, 2)
                    'str_hora = str
                    If opr_trabajo.Leer_Lis_ID(int_Nped, d(5), 0) <> 0 Then 'Pregunto si el LIS_ID consultado se encontro (0 no se encontro)
                        opr_trabajo.CambioEstadoItemLista(opr_trabajo.Leer_Lis_ID(int_Nped, d(4), 0), 4)
                    End If
                End If
            End If
        End While
        aux.Close()
    End Sub

    Public Sub GuardarArchivoCTL(ByVal archivo As String)
        'Public Sub ActualizaArchivosRechazados(ByVal archivo As String)
        'FUNCION QUE GRABA LOS DATOS DEL ARCHIVO A LA BASE DE DATOS 
        ' EN LA TABLA CONTROL_CALIDAD
        Dim opr_archivo As New Cls_Archivos()
        Dim aux As TextReader
        Dim arr_datos(10) As String   'Arreglo que almacena los datos del archivo
        'arr_datos() = equipo, fecha, hora, sampleType, priority, control, prueba, error, valor, unidad 
        Dim str As String
        Dim d As Array
        aux = File.OpenText(archivo)
        d = Split(str, ",")
        Dim COUNT As Integer = 1
        While aux.Peek <> -1
            str = aux.ReadLine
            d = Split(str, ",")  'Asigno en un arreglo los datos de cada una de las lineas del QCT, (fecha, hora, pedido, paciente, test)
            If COUNT = 1 Then
                'If d(2) = "COM2" Then
                '    arr_datos(5) = "BIOMETRIA HEMATICA"
                'Else

                'End If
                arr_datos(0) = Mid(d(2), 4, 1)   'Equipo ID
                arr_datos(1) = d(4)     'fecha
                arr_datos(2) = d(5)     'Hora
                arr_datos(3) = d(7)     'SampleType
                arr_datos(4) = d(8)     'Priority
                arr_datos(5) = d(6)     'Control
                COUNT = COUNT + 1
            Else
                If COUNT = 2 Then
                    If d(0) = "9" Then
                        COUNT = COUNT + 1
                    Else
                        arr_datos(6) = d(1)     'Prueba
                        If d(2) = "" Then
                            arr_datos(7) = Format(d(2), "00000")    'Error
                        Else
                            arr_datos(7) = d(2)   'Error
                        End If
                        arr_datos(8) = d(3)     'Valor
                        arr_datos(9) = d(4)     'Unidad
                        COUNT = 2
                        Call GuardarControl(arr_datos)
                    End If
                End If
            End If
            'COUNT = COUNT + 1
        End While
        aux.Close()
        'Call GuardarControl(arr_datos)
    End Sub

    Public Sub GuardarArchivoCLB(ByVal archivo As String)
        '03 julio 2003 JPO
        'FUNCION QUE GRABA LOS DATOS DEL ARCHIVO A LA BASE DE DATOS 
        ' EN LA TABLA CALIBRACION

        Dim aux As TextReader
        Dim arr_datos(10) As String   'Arreglo que almacena los datos del archivo
        'arr_datos() = equipo, fecha, hora, prueba, unidades, numero Lote, Calibrador, Slope, Intercep
        Dim str As String
        Dim d As Array
        aux = File.OpenText(archivo)
        d = Split(str, ",")
        Dim COUNT As Integer = 1
        While aux.Peek <> -1
            str = aux.ReadLine
            d = Split(str, ",")  'Asigno en un arreglo los datos de cada una de las lineas del LOG, (fecha, hora, pedido, paciente, test)
            If COUNT = 1 Then
                arr_datos(0) = Mid(d(2), 4, 1)     'Equipo ID
                arr_datos(1) = d(4)     'fecha
                arr_datos(2) = d(5)     'Hora                
            Else
                arr_datos(COUNT + 1) = d(3)
            End If
            COUNT = COUNT + 1
        End While
        aux.Close()
        Call GuardarCalibracion(arr_datos)
    End Sub


    Public Sub GuardarControl(ByVal arr_datos() As String)
        'Procedimiento para insertar un registro en la tabla control_calidad
        On Error GoTo MsgError
        'Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        'arr_datos () = equipo, fecha, hora, sampleType, priority, control, prueba, error, valor, unidad 
        Dim str_sql As String
        str_sql = "Insert into CONTROL_CALIDAD values ('" & arr_datos(6).ToString & "', '" & arr_datos(5).ToString & "', '" & arr_datos(1).ToString & "', '" & arr_datos(2).ToString & "', '" & arr_datos(3).ToString & "', '" & arr_datos(4).ToString & "' , '" & arr_datos(8).ToString & "' , '" & arr_datos(9).ToString & "', '" & arr_datos(7).ToString & "', " & CInt(arr_datos(0)) & "," & leerrango("teq_ranmin", arr_datos(6)) & "," & leerrango("teq_ranmax", arr_datos(6)) & ")"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Control Calidad", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Control", Err)
        Err.Clear()
    End Sub

    Public Function leerrango(ByVal nombre As String, ByVal abrev As String) As Double
        'Procedimiento para extraer el rango maximo y minimo de las pruebas 
        'JVA
        On Error GoTo MsgError
        Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim odr_operacion As SqlDataReader = New SqlCommand("Select " & nombre & " from test_equipo where teq_abrv_fija = '" & abrev & "' ", opr_conexion.conn_sql).ExecuteReader
        While odr_operacion.Read
            leerrango = CDbl(odr_operacion.GetValue(0))
        End While
        opr_conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Rango ", Err)
        Err.Clear()
    End Function

    Public Sub GuardarCalibracion(ByVal arr_datos() As String)
        'Procedimiento para la insertar un registro en la tabla calibracion
        On Error GoTo MsgError
        'Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        'arr_datos() = equipo, fecha, hora, prueba, unidades, numero Lote, Calibrador, calibrador lote , Slope, Intercep
        Dim str_sql As String
        str_sql = "Insert into calibracion values ('" & arr_datos(3).ToString & "', '" & arr_datos(5).ToString & " ', '" & arr_datos(4).ToString & "', '" & arr_datos(7).ToString & "', '" & arr_datos(6).ToString & "', '" & arr_datos(1).ToString & "' , '" & arr_datos(2).ToString & "' , '" & arr_datos(8).ToString & "', '" & arr_datos(9).ToString & "', " & CInt(arr_datos(0)) & ")"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nueva Calibracion", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Calibracion", Err)
        Err.Clear()
    End Sub

    Public Sub CompruebaPath(ByRef str_path As String)
        Dim l As Short = Len(str_path)
        If str_path.EndsWith("\") Or str_path.EndsWith("/") Then
            If (Dir(Environment.CurrentDirectory & Mid(str_path, 1, l - 1), FileAttribute.Directory) = "") Then   'No existe el directorio
                MkDir(Environment.CurrentDirectory & Mid(str_path, 1, l - 1))
            End If
        Else
            If (Dir(Environment.CurrentDirectory & str_path, FileAttribute.Directory) = "") Then   'No existe el directorio
                MkDir(Environment.CurrentDirectory & str_path)
            End If
        End If
    End Sub

    Public Sub GuardarLogArchivo(ByVal ped_id As String, ByVal sni_nombre As String, _
                                 ByVal tes_abrev As String, ByVal prc_fecha As String, _
                                  ByVal prc_hora As String, ByVal log_desc As String)
        'Procedimiento para la insertar un registro en la tabla RES_PROCESADOS

        On Error GoTo MsgError
        'Dim opr_conexion As New Cls_Conexion()
        opr_conexion.sql_conectar()
        Dim int_varX As Integer = 1
        int_varX = LeerMaxCodLogArchivo() + 1
        Dim str_sql As String = "Insert into LOG_ARCHIVO values ('" & ped_id & "', '" & _
        sni_nombre & "', '" & tes_abrev & "', '" & prc_fecha & "', '" & prc_hora & "', '" & log_desc & "', " & int_varX & ")"
        Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
        odc_pedido.ExecuteNonQuery()
        opr_conexion.sql_desconn()
        'Se registra de la transaccion realizada
        g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Registro en Log_Archivo", "")
        Exit Sub
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar Log Archivo", Err)
        Err.Clear()
    End Sub

    Public Function LeerMaxCodLogArchivo() As Integer
        'Funcion para la consultar el c�digo m�ximo de la tabla LOG_ARCHIVO
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        opr_Conexion.sql_conectar()
        LeerMaxCodLogArchivo = CInt(New SqlCommand("Select isnull(max(LOG_ID),0) from log_archivo", opr_Conexion.conn_sql).ExecuteScalar)
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Leer Max Cod Log_Archivo", Err)
        Err.Clear()
    End Function

    Public Sub LeerDNLNoEnviado(ByVal archivo As String)
        'FUNCION LEE UN DNL LOS TEST QUE SE ENCUENTRAN EN EL 
        'SON PUESTOS COMO PENDIENTES EN LA LISTA DE TRABAJO.
        Dim opr_trabajo As New Cls_Trabajo()
        Dim aux As TextReader
        Dim int_Nres As Short
        Dim str_equipo As String
        Dim int_Nped As Integer
        'Dim str_fecha As String = ""
        'Dim str_hora As String = ""
        Dim i As Short
        Dim str As String
        Dim d As Array
        Dim int_lis_id As Integer = 0
        Dim shr_var As Short = 0
        Dim shr_i As Short = 0

        aux = File.OpenText(archivo)
        d = Split(str, ",")
        While aux.Peek <> -1
            str = aux.ReadLine
            d = Split(str, ",")  'Asigno en un arreglo los datos de cada una de las lineas del LOG, (fecha, hora, pedido, paciente, test)
            If d(0) = "Dimension AR" Then
                shr_var = UBound(d)
                If shr_var > 7 Then     'Cuando el DNL tiene m�s de una prueba 
                    For shr_i = 6 To shr_var - 1
                        If IsNumeric(d(2)) Then    'Verifico que el item de #Pedido sea numerico
                            int_Nped = CInt(d(2))
                            If (opr_pedido.ExistePedido(int_Nped) = 1) Then  'Verifico que el n�mero de pedido capturado corresponda a alg�n pedido                        
                                If opr_trabajo.Leer_Lis_ID(int_Nped, d(shr_i), 0) <> 0 Then 'Pregunto si el LIS_ID consultado se encontro (0 no se encontro)
                                    opr_trabajo.CambioEstadoItemLista(opr_trabajo.Leer_Lis_ID(int_Nped, d(shr_i), 0), 0)
                                End If
                            End If
                        End If
                    Next
                Else
                    If shr_var = 7 Then   'Cuando el DNL tiene una sola prueba
                        If IsNumeric(d(2)) Then    'Verifico que el item de #Pedido sea numerico
                            int_Nped = CInt(d(2))
                            If (opr_pedido.ExistePedido(int_Nped) = 1) Then  'Verifico que el n�mero de pedido capturado corresponda a alg�n pedido                        
                                If opr_trabajo.Leer_Lis_ID(int_Nped, d(6), 0) <> 0 Then 'Pregunto si el LIS_ID consultado se encontro (0 no se encontro)
                                    opr_trabajo.CambioEstadoItemLista(opr_trabajo.Leer_Lis_ID(int_Nped, d(6), 0), 0)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End While
        aux.Close()
    End Sub


    Public Function ConsultaTestIDxPedido(ByVal ped_id As Integer, ByVal tes_abrev As String) As Integer
        'Funcion que devuelve el ID de un test en funcion de el pedido y la prueba 
        On Error GoTo MsgError
        'cuando se trata de PARAMETROS DE BIOMETRIAS
        If tes_abrev = "WBC" Or tes_abrev = "NEU%25" Or tes_abrev = "LYM%25" Or tes_abrev = "MONO%25" Or tes_abrev = "EOS%25" Or tes_abrev = "BASO%25" Or tes_abrev = "RBC" Or tes_abrev = "HGB" Or tes_abrev = "HCT" Or tes_abrev = "MCV" Or tes_abrev = "MCH" Or tes_abrev = "MCHC" Or tes_abrev = "RDW" Or tes_abrev = "PLT" Or tes_abrev = "MPV" Or tes_abrev = "NEU" Or tes_abrev = "LYM" Or tes_abrev = "MONO" Or tes_abrev = "EOS" Or tes_abrev = "BASO" Or tes_abrev = "PCT" Or tes_abrev = "PDW" Then
            ConsultaTestIDxPedido = 400101  'BIOMETRIA HEMATICA
        Else
            Dim opr_Conexion As New Cls_Conexion()
            Dim str_sql As String = "SELECT TES_ID FROM TEST_EQUIPO WHERE TEQ_ABRV_FIJA = '" & tes_abrev & "'"
            opr_Conexion.sql_conectar()
            ConsultaTestIDxPedido = CInt(New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteScalar)
            opr_Conexion.sql_desconn()
        End If
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, ConsultaTestIDxPedido, Cls_archivo", Err)
        Err.Clear()
    End Function

    Public Function GuardarResArchivoLimite(ByVal ped_id As Integer, ByVal prc_fecha As String, _
                                  ByVal prc_hora As String, ByVal tes_abrev As String, _
                                  ByVal sni_nombre As String, ByVal prc_resul As Double, _
                                  ByVal prc_error As String, ByVal limite As Short) As Boolean
        'Procedimiento para la insertar un registro en la tabla RES_PROCESADOS cuando es un CDF con limites
        On Error GoTo MsgError
        Dim abrev_general As String = Mid(tes_abrev, 1, Len(tes_abrev) - 1)
        Dim OPR_PED As New Cls_Pedido()
        Dim INT_TEST As Integer = ConsultaTestIDxPedido(ped_id, abrev_general)
        GuardarResArchivoLimite = False
        If OPR_PED.EstadoPrueba(ped_id, INT_TEST) = 1 Then 'SI SE PUEDE ACTUALIZAR EL RESUTADO 
            Dim str_sql As String
            If ExistePruebaProcesada(ped_id, tes_abrev) = True Then
                str_sql = "update res_procesados set prc_fecha = '" & prc_fecha & "', prc_hora = '" & prc_hora & "', tes_abrev = '" & tes_abrev & "', " & _
                          " sni_nombre = '" & sni_nombre & "', prc_resul = " & prc_resul & ", prc_error= '" & prc_error & "', " & _
                          " prc_resfinal=" & prc_resul & " where ped_id = " & ped_id & " and tes_abrev = '" & tes_abrev & "'"
            Else
                str_sql = "update res_procesados set prc_fecha = '" & prc_fecha & "', prc_hora = '" & prc_hora & "', tes_abrev = '" & tes_abrev & "', " & _
                          " sni_nombre = '" & sni_nombre & "', prc_resul = " & prc_resul & ", prc_error= '" & prc_error & "', " & _
                          " prc_resfinal=" & prc_resul & " where ped_id = " & ped_id & " and tes_abrev = '" & abrev_general & "'"
            End If

            opr_conexion.sql_conectar()
            Dim odc_pedido As SqlCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
            odc_pedido.ExecuteNonQuery()
            GuardarResArchivoLimite = True
            opr_conexion.sql_desconn()
            'Se registra de la transaccion realizada
            g_opr_usuario.CargarTransaccion(g_str_login, "Nuevo Resultado", "")
        End If
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Guardar ResArchivo Limite", Err)
        GuardarResArchivoLimite = False
        Err.Clear()
    End Function
    Public Function ExistePruebaProcesada(ByVal ped_id As Integer, ByVal tes_abrev As String) As Boolean
        'Funcion que devuelve true si encontro el pedido y la abrev del test en res_procesados
        On Error GoTo MsgError
        Dim opr_Conexion As New Cls_Conexion()
        Dim str_sql As String = ""
        str_sql = "Select * from res_procesados where ped_id = " & ped_id & " and tes_abrev = '" & tes_abrev & "'"
        opr_Conexion.sql_conectar()
        'Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        Dim odr_operacion As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
        ExistePruebaProcesada = False
        While odr_operacion.Read
            'Pregunto si tiene resultado > 0 
            If odr_operacion.GetValue(0) > 0 Then
                'Si lo tiene
                ExistePruebaProcesada = True
            End If
        End While
        odr_operacion.Close()
        opr_Conexion.sql_desconn()
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, Posee Resultado", Err)
        Err.Clear()

    End Function
    Public Function DNLElecsys2010(ByRef dtr_fila As DataRow) As String
        On Error GoTo MsgError
        ' dtr_fila posee 48 campos
        Dim str_sniNombre, str_formato, str_elemento(), str_cadena, str_sql As String
        str_formato = dtr_fila("EQU_FORMATO").ToString()  'Almaceno el formato de la cadena que necesita el equipo para entender una orden
        str_elemento = Split(str_formato, ",")
        Dim sng_i, sng_count As Single
        sng_i = UBound(str_elemento)
        str_sniNombre = dtr_fila("SNI_NOMBRE").ToString() 'Almaceno el nombre del dispositivo de interfaceamiento (SNI o COM)
        str_cadena = ""
        If Mid(str_sniNombre, 1, 1) = "S" Then  'Si la prueba se realiza en un equipo conectado con SNI 
            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
                str_cadena = ""
                For sng_count = 0 To sng_i
                    Select Case str_elemento(sng_count)
                        Case "ID"
                            str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","
                        Case "Code"
                            Select Case dtr_fila("PED_TIPO").ToString
                                Case "NORMAL"
                                    str_cadena = str_cadena & "0,"
                                Case "URGENCIA"
                                    str_cadena = str_cadena & "1,"
                                Case "ASAP"
                                    str_cadena = str_cadena & "2,"
                                Case "QC"
                                    str_cadena = str_cadena & "3,"
                                Case "XQC"
                                    str_cadena = str_cadena & "4,"
                                Case Else
                                    str_cadena = str_cadena & "0,"
                            End Select
                        Case "Action Code"
                            str_cadena = str_cadena & "AP,"
                        Case "LoadList"
                            str_cadena = str_cadena & "0;"
                        Case "CarrierID"
                            str_cadena = str_cadena & "0,"
                        Case "Type"
                            'Tipo de muestra (LIS_EQUTIMID)
                            str_cadena = str_cadena & Trim(dtr_fila("PER_ID").ToString) & ","
                        Case "SampleID"
                            str_cadena = str_cadena & dtr_fila("LIS_EQUTIMID").ToString & ";"
                            'str_cadena = str_cadena & ";"
                        Case "Dilution"
                            opr_conexion.sql_conectar()
                            str_sql = "select a.* from testequipo_tipmuestra as a , test_equipo as b where b.tes_id = " & dtr_fila("TES_ID").ToString() & " and b.equ_id = " & dtr_fila("EQU_ID").ToString() & " and a.tim_id = " & dtr_fila("TIM_ID").ToString() & " and a.teq_id = b.teq_id"
                            Dim oda_disol As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_disol As New DataSet()
                            oda_disol.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
                            oda_disol.Fill(dts_disol, "Registros")
                            Dim dtr_dfila As DataRow
                            If dts_disol.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_dfila In dts_disol.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_dfila(2).ToString() & ","
                                Next
                            Else
                                str_cadena = str_cadena & ","
                            End If
                            opr_conexion.sql_desconn()
                        Case "PatientID"
                            str_cadena = str_cadena & ";"
                        Case "SSN"
                            str_cadena = str_cadena & ";"
                        Case "Last First"
                            str_cadena = str_cadena & ";"
                        Case "Mid"
                            str_cadena = str_cadena & ";"
                        Case "Blank"
                            str_cadena = str_cadena & ";"
                        Case "Location"
                            str_cadena = str_cadena & ","
                        Case "Blanco"
                            str_cadena = str_cadena & ","
                        Case "Test"
                            Dim STR_SQL3 As String
                            opr_conexion.sql_conectar()
                            STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("TES_ID").ToString()
                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_test As New DataSet()
                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                            oda_test.Fill(dts_test, "Registros")
                            Dim dtr_test As DataRow
                            If dts_test.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            Else
                                STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_EQUIPO  WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString()
                                dts_test = New DataSet()
                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                                oda_test.Fill(dts_test, "Registros")
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            End If
                            opr_conexion.sql_desconn()
                        Case ""
                            str_cadena = str_cadena & ","
                    End Select
                Next
            End If
        Else  'Si la prueba se realiza en un equipo conectado con COM o FOLDER (C � F)
            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
                str_cadena = ""
                For sng_count = 0 To sng_i
                    'Equipo,PatientName,ID,IDinformation,Prioridad,Position,Test,CarrierID
                    Select Case str_elemento(sng_count)
                        Case "Equipo"
                            str_cadena = str_cadena & dtr_fila("EQU_MODELO").ToString & ","
                        Case "ID"
                            'str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","   ' CUANDO SE UTILIZA UN NUMERO SECUENCIAL
                            str_cadena = str_cadena & dtr_fila("PED_TURNO").ToString() & ","
                        Case "Type"
                            str_cadena = str_cadena & "C,"
                        Case "Code"
                            str_cadena = str_cadena & "U,"
                        Case "Code1"
                            str_cadena = str_cadena & "0,"
                        Case "Prioridad"
                            Select Case dtr_fila("PED_TIPO").ToString
                                Case "NORMAL"
                                    str_cadena = str_cadena & "U,"
                                Case "URGENCIA"
                                    str_cadena = str_cadena & "1,"
                                Case "ASAP"
                                    str_cadena = str_cadena & "2,"
                                Case "QC"
                                    str_cadena = str_cadena & "3,"
                                Case "XQC"
                                    str_cadena = str_cadena & "4,"
                                Case Else
                                    str_cadena = str_cadena & "0,"
                            End Select
                        Case "Position"
                            'If dtr_fila("LIS_POSNUM").ToString = "0" Then
                            '    'En caso de ser c�digo de barras
                            '    str_cadena = str_cadena & "**,"
                            'Else
                            '    'Caso contrario se env�a la posici�n
                            '    'str_cadena = str_cadena & dtr_fila("LIS_POSNUM").ToString & ","
                            str_cadena = str_cadena & "0,"
                            'End If
                        Case "PatientName"
                            str_cadena = str_cadena & dtr_fila("Nombres").ToString & ","
                        Case "CarrierID"
                            'RAck o Rueda en la que est� la muestra, si no se utiliza c�digo de barras
                            'str_cadena = str_cadena & "," & dtr_fila("LIS_EQUTIMID").ToString
                            str_cadena = str_cadena & ",1"
                        Case "Test"
                            Dim STR_SQL3 As String
                            STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("EQU_ID").ToString()
                            opr_conexion.sql_conectar()
                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_test As New DataSet()
                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                            oda_test.Fill(dts_test, "Registros")
                            Dim dtr_test As DataRow
                            If dts_test.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            Else
                                STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_EQUIPO WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString()
                                dts_test = New DataSet()
                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                                oda_test.Fill(dts_test, "Registros")
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    'CODIGO QUE PERMITE ENVIAR AL EQUIPO PRUEBAS TALES COMO GLUCOSA POST PRANDIAL O CLEARENCE DE CREATININA O ALGUNA OTRA GLUCOSA ESPECIAL
                                    'CUYA ABREVIATURA PARA EL EQUIPO ES GLU O CREA, PARA LO CUAL ES NECESARIO UTILIZAR UN ARTIFICIO QUE PONE AL PEDIDO TRES DIGITOS PRIMERO
                                    '2PP -> PARA POSPRANDIAL Y CCR -> PARA CLEARENCE DE CREATININA, PARA DE ESTA FORMA OBLIGAR AL EQUIPO PARA QUE ASIGNE OTRA POSICI�N PARA 
                                    'ESTAS PRUEBAS Y LAS CORRA COMO GLUCOSA O CREATININA NORMAL 

                                    If (dtr_test("TEQ_ABREVIATURA").ToString() = "GLUP" Or dtr_test("TEQ_ABREVIATURA").ToString() = "CCR") Then
                                        Dim nueva_Cadena() As String
                                        Dim Aux As String = ""
                                        Dim i_cont As Single = 0
                                        'COPIO LA CADENA QUE SE ESTABA GENERANDO EN UNA NUEVA
                                        nueva_Cadena = Split(str_cadena, ",")
                                        'VOY COPIANDO UNO A UNO LOS ITEMS DE LA CADENA 
                                        'Y REALIZO CAMBIOS EN LA POSION DEL PEDIDO Y DEL TEST
                                        For i_cont = 0 To (UBound(nueva_Cadena) - 1)
                                            If i_cont = 2 Then
                                                Select Case dtr_test("TEQ_ABREVIATURA").ToString()
                                                    Case "GLUP"
                                                        Aux = Aux & "2PP" & nueva_Cadena(i_cont) & ","
                                                    Case "CCR"
                                                        Aux = Aux & "CCR" & nueva_Cadena(i_cont) & ","
                                                End Select
                                            Else
                                                Aux = Aux & nueva_Cadena(i_cont) & ","
                                            End If
                                        Next
                                        'ASIGNO A LA CADENA LA PRUEBA QUE REALMENTE EJECUTA EL EQUIPO
                                        Select Case dtr_test("TEQ_ABREVIATURA").ToString()
                                            Case "GLUP"
                                                Aux = Aux & "GLU,"
                                            Case "CCR"
                                                Aux = Aux & "CREA,"
                                        End Select
                                        'PONGO COMO CADENA GENERADA LA QUE MODIFICAMOS
                                        str_cadena = Aux
                                    Else
                                        'JPO(08-Ene-2004): Cambio implementado para que se automaticen pruebas del HITACHI, simulando 
                                        'que se procesa en el Dimension AR, pero no se deben enviar estas pruebas al equipo
                                        'If dtr_test("TEQ_ABREVIATURA").ToString() <> "GLUP" Or dtr_test("TEQ_ABREVIATURA").ToString() <> "GLUP" Or dtr_test("TEQ_ABREVIATURA").ToString() <> "GLUP" Then
                                        str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                        'End If
                                    End If
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            End If
                            opr_conexion.sql_desconn()
                        Case ""
                            str_cadena = str_cadena & ","
                    End Select
                Next
            End If
        End If
        DNLElecsys2010 = str_cadena
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, DNL Elecsys1010", Err)
        Err.Clear()
    End Function
    Public Function DNLElecsys1010(ByRef dtr_fila As DataRow) As String
        On Error GoTo MsgError
        ' dtr_fila posee 48 campos
        Dim str_sniNombre, str_formato, str_elemento(), str_cadena, str_sql As String
        str_formato = dtr_fila("EQU_FORMATO").ToString()  'Almaceno el formato de la cadena que necesita el equipo para entender una orden
        str_elemento = Split(str_formato, ",")
        Dim sng_i, sng_count As Single
        sng_i = UBound(str_elemento)
        str_sniNombre = dtr_fila("SNI_NOMBRE").ToString() 'Almaceno el nombre del dispositivo de interfaceamiento (SNI o COM)
        str_cadena = ""
        If Mid(str_sniNombre, 1, 1) = "S" Then  'Si la prueba se realiza en un equipo conectado con SNI 
            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
                str_cadena = ""
                For sng_count = 0 To sng_i
                    Select Case str_elemento(sng_count)
                        Case "ID"
                            'str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","    'CUANDO SE TRABAJA CON PEDIDO
                            str_cadena = str_cadena & dtr_fila("PED_TURNO").ToString() & ","  'CUANDO SE TRABAJA CON TURNO
                        Case "Code"
                            Select Case dtr_fila("PED_TIPO").ToString
                                Case "NORMAL"
                                    str_cadena = str_cadena & "0,"
                                Case "URGENCIA"
                                    str_cadena = str_cadena & "1,"
                                Case "ASAP"
                                    str_cadena = str_cadena & "2,"
                                Case "QC"
                                    str_cadena = str_cadena & "3,"
                                Case "XQC"
                                    str_cadena = str_cadena & "4,"
                                Case Else
                                    str_cadena = str_cadena & "0,"
                            End Select
                        Case "Action Code"
                            str_cadena = str_cadena & "AP,"
                        Case "LoadList"
                            str_cadena = str_cadena & "0;"
                        Case "CarrierID"
                            str_cadena = str_cadena & "0,"
                        Case "Type"
                            'Tipo de muestra (LIS_EQUTIMID)
                            str_cadena = str_cadena & Trim(dtr_fila("PER_ID").ToString) & ","
                        Case "SampleID"
                            str_cadena = str_cadena & dtr_fila("LIS_EQUTIMID").ToString & ";"
                            'str_cadena = str_cadena & ";"
                        Case "Dilution"
                            opr_conexion.sql_conectar()
                            str_sql = "select a.* from testequipo_tipmuestra as a , test_equipo as b where b.tes_id = " & dtr_fila("TES_ID").ToString() & " and b.equ_id = " & dtr_fila("EQU_ID").ToString() & " and a.tim_id = " & dtr_fila("TIM_ID").ToString() & " and a.teq_id = b.teq_id"
                            Dim oda_disol As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_disol As New DataSet()
                            oda_disol.SelectCommand = New SqlCommand(str_sql, opr_conexion.conn_sql)
                            oda_disol.Fill(dts_disol, "Registros")
                            Dim dtr_dfila As DataRow
                            If dts_disol.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_dfila In dts_disol.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_dfila(2).ToString() & ","
                                Next
                            Else
                                str_cadena = str_cadena & ","
                            End If
                            opr_conexion.sql_desconn()
                        Case "PatientID"
                            str_cadena = str_cadena & ";"
                        Case "SSN"
                            str_cadena = str_cadena & ";"
                        Case "Last First"
                            str_cadena = str_cadena & ";"
                        Case "Mid"
                            str_cadena = str_cadena & ";"
                        Case "Blank"
                            str_cadena = str_cadena & ";"
                        Case "Location"
                            str_cadena = str_cadena & ","
                        Case "Blanco"
                            str_cadena = str_cadena & ","
                        Case "Test"
                            Dim STR_SQL3 As String
                            opr_conexion.sql_conectar()
                            STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("TES_ID").ToString()
                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_test As New DataSet()
                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                            oda_test.Fill(dts_test, "Registros")
                            Dim dtr_test As DataRow
                            If dts_test.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            Else
                                STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_EQUIPO  WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString()
                                dts_test = New DataSet()
                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                                oda_test.Fill(dts_test, "Registros")
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            End If
                            opr_conexion.sql_desconn()
                        Case ""
                            str_cadena = str_cadena & ","
                    End Select
                Next
            End If
        Else  'Si la prueba se realiza en un equipo conectado con COM o FOLDER (C � F)
            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
                str_cadena = ""
                For sng_count = 0 To sng_i
                    'Equipo,PatientName,ID,IDinformation,Prioridad,Position,Test,CarrierID
                    Select Case str_elemento(sng_count)
                        Case "Equipo"
                            str_cadena = str_cadena & dtr_fila("EQU_MODELO").ToString & ","
                        Case "ID"
                            'str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","    'CUANDO SE TRABAJA CON PEDIDO
                            str_cadena = str_cadena & dtr_fila("PED_TURNO").ToString() & ","  'CUANDO SE TRABAJA CON TURNO
                        Case "IDinformation"
                            str_cadena = str_cadena & "C,"
                        Case "Prioridad"
                            Select Case dtr_fila("PED_TIPO").ToString
                                Case "NORMAL"
                                    str_cadena = str_cadena & "U,"
                                Case "URGENCIA"
                                    str_cadena = str_cadena & "1,"
                                Case "ASAP"
                                    str_cadena = str_cadena & "2,"
                                Case "QC"
                                    str_cadena = str_cadena & "3,"
                                Case "XQC"
                                    str_cadena = str_cadena & "4,"
                                Case Else
                                    str_cadena = str_cadena & "0,"
                            End Select
                        Case "Position"
                            'If dtr_fila("LIS_POSNUM").ToString = "0" Then
                            '    'En caso de ser c�digo de barras
                            '    str_cadena = str_cadena & "**,"
                            'Else
                            '    'Caso contrario se env�a la posici�n
                            '    'str_cadena = str_cadena & dtr_fila("LIS_POSNUM").ToString & ","
                            str_cadena = str_cadena & "0,"
                            'End If
                        Case "PatientName"
                            str_cadena = str_cadena & dtr_fila("Nombres").ToString & ","
                        Case "CarrierID"
                            'RAck o Rueda en la que est� la muestra, si no se utiliza c�digo de barras
                            'str_cadena = str_cadena & "," & dtr_fila("LIS_EQUTIMID").ToString
                            str_cadena = str_cadena & ",1"
                        Case "Test"
                            Dim STR_SQL3 As String
                            STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("EQU_ID").ToString()
                            opr_conexion.sql_conectar()
                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_test As New DataSet()
                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                            oda_test.Fill(dts_test, "Registros")
                            Dim dtr_test As DataRow
                            If dts_test.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            Else
                                STR_SQL3 = "SELECT DISTINCT TEQ_ABREVIATURA FROM TEST_EQUIPO WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString()
                                dts_test = New DataSet()
                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                                oda_test.Fill(dts_test, "Registros")
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    'CODIGO QUE PERMITE ENVIAR AL EQUIPO PRUEBAS TALES COMO GLUCOSA POST PRANDIAL O CLEARENCE DE CREATININA O ALGUNA OTRA GLUCOSA ESPECIAL
                                    'CUYA ABREVIATURA PARA EL EQUIPO ES GLU O CREA, PARA LO CUAL ES NECESARIO UTILIZAR UN ARTIFICIO QUE PONE AL PEDIDO TRES DIGITOS PRIMERO
                                    '2PP -> PARA POSPRANDIAL Y CCR -> PARA CLEARENCE DE CREATININA, PARA DE ESTA FORMA OBLIGAR AL EQUIPO PARA QUE ASIGNE OTRA POSICI�N PARA 
                                    'ESTAS PRUEBAS Y LAS CORRA COMO GLUCOSA O CREATININA NORMAL 

                                    If (dtr_test("TEQ_ABREVIATURA").ToString() = "GLUP" Or dtr_test("TEQ_ABREVIATURA").ToString() = "CCR") Then
                                        Dim nueva_Cadena() As String
                                        Dim Aux As String = ""
                                        Dim i_cont As Single = 0
                                        'COPIO LA CADENA QUE SE ESTABA GENERANDO EN UNA NUEVA
                                        nueva_Cadena = Split(str_cadena, ",")
                                        'VOY COPIANDO UNO A UNO LOS ITEMS DE LA CADENA 
                                        'Y REALIZO CAMBIOS EN LA POSION DEL PEDIDO Y DEL TEST
                                        For i_cont = 0 To (UBound(nueva_Cadena) - 1)
                                            If i_cont = 2 Then
                                                Select Case dtr_test("TEQ_ABREVIATURA").ToString()
                                                    Case "GLUP"
                                                        Aux = Aux & "2PP" & nueva_Cadena(i_cont) & ","
                                                    Case "CCR"
                                                        Aux = Aux & "CCR" & nueva_Cadena(i_cont) & ","
                                                End Select
                                            Else
                                                Aux = Aux & nueva_Cadena(i_cont) & ","
                                            End If
                                        Next
                                        'ASIGNO A LA CADENA LA PRUEBA QUE REALMENTE EJECUTA EL EQUIPO
                                        Select Case dtr_test("TEQ_ABREVIATURA").ToString()
                                            Case "GLUP"
                                                Aux = Aux & "GLU,"
                                            Case "CCR"
                                                Aux = Aux & "CREA,"
                                        End Select
                                        'PONGO COMO CADENA GENERADA LA QUE MODIFICAMOS
                                        str_cadena = Aux
                                    Else
                                        'JPO(08-Ene-2004): Cambio implementado para que se automaticen pruebas del HITACHI, simulando 
                                        'que se procesa en el Dimension AR, pero no se deben enviar estas pruebas al equipo
                                        'If dtr_test("TEQ_ABREVIATURA").ToString() <> "GLUP" Or dtr_test("TEQ_ABREVIATURA").ToString() <> "GLUP" Or dtr_test("TEQ_ABREVIATURA").ToString() <> "GLUP" Then
                                        str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                        'End If
                                    End If
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            End If
                            opr_conexion.sql_desconn()
                        Case ""
                            str_cadena = str_cadena & ","
                    End Select
                Next
            End If
        End If
        DNLElecsys1010 = str_cadena
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, DNL Elecsys1010", Err)
        Err.Clear()
    End Function

    Public Function DNLCellDyn3500(ByRef dtr_fila As DataRow) As String
        On Error GoTo MsgError
        ' dtr_fila posee 48 campos
        Dim str_sniNombre, str_formato, str_elemento(), str_cadena, str_sql As String
        str_formato = dtr_fila("EQU_FORMATO").ToString()  'Almaceno el formato de la cadena que necesita el equipo para entender una orden
        str_elemento = Split(str_formato, ",")
        Dim sng_i, sng_count, limite As Single
        Dim str_fecha As Date  'variable en la que almaceno la fecha de nacimiento  
        Dim m_edad As Integer  'edad en meses
        sng_i = UBound(str_elemento)
        str_sniNombre = dtr_fila("SNI_NOMBRE").ToString() 'Almaceno el nombre del dispositivo de interfaceamiento (SNI o COM)
        str_cadena = ""

        'DEFINO EL PARAMETRO (QUE PRUEBAS SE REQUIEREN) Y EL LIMITE (RANGOS NORMALES)
        If (dtr_fila("USAFECNAC").ToString) = 1 Then
            'TIENE DEFINIDA FECHA DE NACIMIENTO
            If IsDate(dtr_fila("FECNAC").ToString) Then
                str_fecha = CDate(dtr_fila("FECNAC").ToString)
                m_edad = DateDiff(DateInterval.Month, str_fecha, Today)
                If m_edad <= 1 Then 'PARAMETRO NEONATO 
                    limite = 4
                Else
                    If m_edad <= 144 Then  'PARAMETRO NIÑO
                        limite = 3
                    Else 'CUANDO SON ADULTOS
                        If (dtr_fila("SEXO").ToString) = "F" Then  ' MUJER
                            limite = 2
                        Else  'HOMBRE
                            limite = 1
                        End If
                    End If
                End If
            Else
                If (dtr_fila("SEXO").ToString) = "F" Then
                    limite = 2
                Else
                    limite = 1
                End If
            End If
        Else
            'NO TIENE DEFINIDA FECHA DE NACIMIENTO
            If (dtr_fila("SEXO").ToString) = "F" Then
                limite = 2
            Else
                limite = 1
            End If
        End If

        If Mid(str_sniNombre, 1, 1) = "S" Then  'Si la prueba se realiza en un equipo conectado con SNI 
            'NO SE HA REQUERIDO
        Else  'Si la prueba se realiza en un equipo conectado con COM o FOLDER (C � F)
            If sng_i > 0 Then  'Veo que existan elementos en la cadena de formato
                str_cadena = ""
                For sng_count = 0 To sng_i
                    Select Case str_elemento(sng_count)
                        'Equipo,PatientName,IDSpeciment,BarCode,Limite,Parametro,Test,blank
                        Case "Equipo"
                            str_cadena = str_cadena & dtr_fila("EQU_MODELO").ToString & ","
                        Case "PatientName"
                            str_cadena = str_cadena & dtr_fila("Nombres").ToString & ","
                        Case "IDSpeciment"
                            'str_cadena = str_cadena & dtr_fila("PED_ID").ToString() & ","
                            str_cadena = str_cadena & dtr_fila("PED_TURNO").ToString() & ","
                        Case "BarCode"
                            str_cadena = str_cadena & "----,"
                        Case "Limite"
                            'Envio el limite que debe aplicarse a la muestra (Rangos normales)
                            'Limite (1->hombres adultos, 2->mujeres adultas, 3->NIÑOs)
                            str_cadena = str_cadena & limite & ","
                        Case "Parametro"
                            'Que pruebas se van a ejecutar 0 - toda la biometria
                            '0 -> default
                            str_cadena = str_cadena & "@,"
                            'str_cadena = str_cadena & parametro & ","
                        Case "Test"
                            Dim STR_SQL3 As String
                            STR_SQL3 = "SELECT DISTINCT TEQ_ABRV_FIJA FROM TEST_RELACIONADO, TEST_EQUIPO, TEST  WHERE TEST.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND TEST_EQUIPO.TES_ID=TEST_RELACIONADO.TES_ID_HIJO AND  TEST_RELACIONADO.TES_ID_PADRE=" & dtr_fila("TES_ID").ToString() & " AND TEST_EQUIPO.EQU_ID=" & dtr_fila("EQU_ID").ToString()
                            opr_conexion.sql_conectar()
                            Dim oda_test As SqlDataAdapter = New SqlDataAdapter()
                            Dim dts_test As New DataSet()
                            oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                            oda_test.Fill(dts_test, "Registros")
                            Dim dtr_test As DataRow
                            If dts_test.Tables("Registros").Rows.Count > 0 Then
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABREVIATURA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            Else
                                STR_SQL3 = "SELECT DISTINCT TEQ_ABRV_FIJA FROM TEST_EQUIPO WHERE TES_ID=" & dtr_fila("TES_ID").ToString() & " AND EQU_ID=" & dtr_fila("EQU_ID").ToString() & " LIMIT 1;"
                                dts_test = New DataSet()
                                oda_test.SelectCommand = New SqlCommand(STR_SQL3, opr_conexion.conn_sql)
                                oda_test.Fill(dts_test, "Registros")
                                For Each dtr_test In dts_test.Tables("Registros").Rows
                                    str_cadena = str_cadena & dtr_test("TEQ_ABRV_FIJA").ToString() & ","
                                Next
                                str_cadena = Left(str_cadena, Len(str_cadena) - 1)
                            End If
                            opr_conexion.sql_desconn()
                        Case ""
                            str_cadena = str_cadena & ","
                    End Select
                Next
            End If
        End If
        DNLCellDyn3500 = str_cadena
        Exit Function
MsgError:
        g_opr_usuario.MensajeBoxError("No se pudo realizar la transaccion solicitada, DNL CellDyn3000 Series", Err)
        Err.Clear()
    End Function



End Class

