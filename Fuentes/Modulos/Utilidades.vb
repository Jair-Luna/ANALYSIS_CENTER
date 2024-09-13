Imports System.Data.SqlClient

Module Utilidades


    Public Function DevuelveFechaFormatoAS(ByVal fecha As Date) As String
        Dim pfecAnio As String
        Dim pfecMes As String
        Dim pfecDia As String

        pfecAnio = Mid(fecha, 7, 4)
        pfecMes = Mid(fecha, 4, 2)
        pfecDia = Mid(fecha, 1, 2)

        If (pfecMes.Length = 1) Then
            pfecMes = "0" + pfecMes
        End If
        If (pfecDia.Length = 1) Then
            pfecDia = "0" + pfecDia
        End If

        DevuelveFechaFormatoAS = pfecAnio + "-" + pfecMes + "-" + pfecDia

    End Function



    Public Function DevuelveFechaFormatoAS(ByVal dpFecha As System.Windows.Forms.DateTimePicker) As String
        Dim pfecAnio As String
        Dim pfecMes As String
        Dim pfecDia As String

        pfecAnio = dpFecha.Value.Year.ToString()
        pfecMes = dpFecha.Value.Month.ToString()
        pfecDia = dpFecha.Value.Day.ToString()

        If (pfecMes.Length = 1) Then
            pfecMes = "0" + pfecMes
        End If
        If (pfecDia.Length = 1) Then
            pfecDia = "0" + pfecDia
        End If

        DevuelveFechaFormatoAS = pfecAnio + "-" + pfecMes + "-" + pfecDia + " " + "00:00:00"

    End Function


    Public Function RutinaError(ByVal errnum As Integer, ByVal ErrDesc As String)
        Dim opr_conexion As New Cls_Conexion()
        Dim codigo As Integer
        Dim str_sql As String
        Dim err_parcial1 As String
        Dim err_parcial2 As String
        Dim obs_usu As String
        Dim errfec As DateTime = DateTime.Now
        Dim i As Integer

        Try
            'para consultar el codigo del error a grabar
            str_sql = "Select isnull(max(err_id),0) from LogErrores"
            opr_conexion.sql_conectar()
            Dim odr As SqlDataReader = New SqlCommand(str_sql, opr_Conexion.conn_sql).ExecuteReader
            While odr.Read
                codigo = odr.GetValue(0)
            End While
            opr_conexion.sql_desconn()
            odr.Close()
            codigo += 1

            'procedo a grabar el error en la tabla LogErrores
            obs_usu = "Usurio: " & g_str_login
            If Len(ErrDesc) < 1999 Then
                str_sql = " insert into LogErrores(Err_id, Err_Fecha, Err_numero, Err_Descripcion, Err_Obs) " & _
                          " values(" & codigo & ", '" & Format(errfec, "dd/MM/yyyy HH:mm:ss") & "', '" & errnum & "', '" & ErrDesc & "', '" & obs_usu & "') "
                opr_conexion.sql_conectar()
                Dim odc As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
                odc.ExecuteNonQuery()
                opr_conexion.sql_desconn()
            ElseIf Len(ErrDesc) > 1999 Then
                err_parcial1 = Mid(ErrDesc, 1, 1999)
                err_parcial2 = Mid(ErrDesc, 2000, 999)
                str_sql = " insert into LogErrores(Err_id, Err_Fecha, Err_numero, Err_descripcion, Err_Obs) " & _
                          " values(" & codigo & ", '" & Format(errfec, "dd/MM/yyyy HH:mm:ss") & "', '" & errnum & "', '" & err_parcial1 & "', '" & err_parcial2 & "') "
                opr_conexion.sql_conectar()
                Dim oDc1 As SqlCommand = New SqlCommand(str_sql, opr_Conexion.conn_sql)
                oDc1.ExecuteNonQuery()
                opr_conexion.sql_desconn()
            End If
        Catch
            MsgBox("El sistema ha capturado un Error y no pudo grabar detalles del Error en el Log." & Chr(13) & Err.Number & "  " & Err.Description, MsgBoxStyle.Critical, "ANALISYS CONTROL DE ERRORES")
            Err.Clear()
        End Try
    End Function

End Module
