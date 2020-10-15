Imports System.Data.SqlClient

Public Class sql

    Dim _conexion = "Data Source=" & My.Settings.servidor & "\" & My.Settings.instancia & " ;Initial Catalog=" & My.Settings.bd & ";Integrated Security=True"
    Dim SQLConn As New SqlConnection()
    Function obtener_meta_actual(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_meta_actual", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_maquinas_producidas(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_produccion", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area


        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_daily_rate(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_daily_rate", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@descripcion_area", SqlDbType.VarChar)
        cmd.Parameters("@descripcion_area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_ultimo_registrol(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_ultimo_registro", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_ultimo_modelo(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_ultimo_modelo", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_ultimo_hora(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_ultimo_hora", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_ultimo_serie(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_ultimo_serie", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure


        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_downtime_actual(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_downtime_actual", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_pb_downtime_actual(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_actual_runtime", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_takt_time(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_takt_time", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_spill_time(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_spill_time", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_semaforo(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_status_produccion", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_turno_duracion(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_turno_duracion", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_turno_transcurrido(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_turno_transcurrido", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function obtener_empleados_area(ByVal area As String)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If


        Dim cmd As New SqlCommand("usp_get_cantidad_empleados_area", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add("@area", SqlDbType.VarChar)
        cmd.Parameters("@area").Value = area

        Return read_single(cmd)
        SQLConn.Close()

    End Function
    Function read_single(ByVal cmd As SqlCommand)
        Dim _output As String
        _output = 0
        Try
            SQLConn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                If reader(0) = Nothing Then
                    Return 0
                Else
                    _output = reader(0)
                End If

            End While
            reader.Close()

        Catch error_lectura As Exception
            pantalla.WriteToEventLog("Error al comunicar con la base de datos " & error_lectura.Message & cmd.CommandText, , EventLogEntryType.Error)
            Return 0
        Finally
            SQLConn.Close()

        End Try
        Return _output
    End Function
    Function set_spill_done(ByVal id_spill As Double)
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If
        Dim cmd As New SqlCommand("usp_set_spill_reportado", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@id_spill", SqlDbType.Int)
        cmd.Parameters("@id_spill").Value = CInt(id_spill)

        Return read_single(cmd)
        SQLConn.Close()
    End Function
    Function read_multiple(ByVal cmd As SqlCommand)
        Dim _output() As String = Nothing

        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        Try

            Dim i As Integer
            i = 0
            While reader.Read()
                If reader(i) = Nothing Then
                    Return 0
                Else
                    ReDim _output((reader.FieldCount) - 1)
                    For i = 0 To ((reader.FieldCount) - 1)
                        If IsDBNull(reader(i)) Then
                            _output(i) = 0
                        Else
                            _output(i) = CStr(reader(i))
                        End If
                    Next i
                End If

            End While


        Catch error_lectura As Exception
            pantalla.WriteToEventLog("Error al comunicar con la base de datos " & error_lectura.Message & cmd.CommandText, , EventLogEntryType.Error)
            Return 0
        Finally
            reader.Close()
            SQLConn.Close()
        End Try

        Return _output
    End Function
    Function read_multiple_2(ByVal cmd As SqlCommand)
        Dim _out() As String = Nothing
        SQLConn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim i As Integer
        i = 0

        ReDim _out(50)
        Try


            While reader.Read()
                If (IsNothing(reader(0))) Then
                    Return 0
                Else
                    If IsDBNull(reader(0)) Then
                        _out(i) = 0
                    Else
                        _out(i) = reader(0)
                        i = i + 1
                    End If
                End If

            End While
        Catch error_lectura As Exception
            pantalla.WriteToEventLog("Error al comunicar con la base de datos " & error_lectura.Message & cmd.CommandText, , EventLogEntryType.Error)
            Return 0
        Finally
            reader.Close()
            SQLConn.Close()
        End Try

        Return _out
    End Function
    Function obtener_lista_areas()

        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        Else
            SQLConn.ConnectionString = _conexion
        End If

        Dim cmd As New SqlCommand("usp_list_areas", SQLConn)
        cmd.CommandType = CommandType.StoredProcedure

        Return read_multiple_2(cmd)
        SQLConn.Close()
    End Function
End Class
