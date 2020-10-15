Imports System.Data.SqlClient

Public Class pantalla
    Private _meta_del_dia As Label
    Private _reloj As Label
    Private _segundero As Timer
    Private _produccion_actual As Label
    Private _meta_actual As Label
    Private _ultimo_serie As Label
    Private _ultimo_modelo As Label
    Private _ultimo_hora As Label
    Private _datasource As Object
    Private _area As Object
    Private _downtime_actual As Label
    Private _pb_downtime_actual As ProgressBar
    Private _semaforo As Object
    Private _pb_turno_transcurrido As ProgressBar
    Private _semaforo_reloj As Timer
    Private _acomodar_pantalla_tmr As Timer
    Private _downtime_daily As Label
    Private _diagonal As Label
    Private _cant_empleados As Label
    Private _takt_time As Label
    Private _tit_empleados As Object
    Private _tit_proceso As Object
    Private _tit_turno_actual As Object
    Private _tit_maquina_actual As Object
    Private _tit_objetivo As Object
    Private _tit_real As Object
    Private _tit_plan As Object
    Private _tit_ultimo_registro As Object
    Private _tit_serie As Object
    Private _tit_modelo As Object
    Private _tit_hora As Object
    Private _tit_tiempo_caido As Object
    Private _tit_actual As Object
    Private _tit_acumulado As Object
    Private _tit_hora_actual As Object
    Private _tit_meta As Object
    Private _tit_linea As Object
    Private _idioma As String
    Private _tit_rev As Label




    Property titulo_linea
        Set(ByVal value)
            _tit_linea = value
        End Set
        Get
            Return _tit_linea
        End Get
    End Property

    Property titulo_rev
        Set(ByVal value)
            _tit_rev = value
        End Set
        Get
            Return _tit_rev
        End Get
    End Property

    Property takt_time
        Set(ByVal value)
            _takt_time = value
        End Set
        Get
            Return _takt_time
        End Get
    End Property
    Property idioma
        Set(ByVal value)
            _idioma = value
        End Set
        Get
            Return _idioma
        End Get
    End Property
    Property titulo_empleados
        Set(ByVal value)
            _tit_empleados = value
        End Set
        Get
            Return _tit_empleados
        End Get
    End Property
    Property titulo_proceso
        Set(ByVal value)
            _tit_proceso = value
        End Set
        Get
            Return _tit_proceso
        End Get
    End Property
    Property titulo_turno_actual
        Set(ByVal value)
            _tit_turno_actual = value
        End Set
        Get
            Return _tit_turno_actual
        End Get
    End Property
    Property titulo_maquina_actual
        Set(ByVal value)
            _tit_maquina_actual = value
        End Set
        Get
            Return _tit_maquina_actual
        End Get
    End Property
    Property titulo_objetivo
        Set(ByVal value)
            _tit_objetivo = value
        End Set
        Get
            Return _tit_objetivo
        End Get
    End Property
    Property titulo_real
        Set(ByVal value)
            _tit_real = value
        End Set
        Get
            Return _tit_real
        End Get
    End Property
    Property titulo_plan
        Set(ByVal value)
            _tit_plan = value
        End Set
        Get
            Return _tit_plan
        End Get
    End Property
    Property titulo_ultimo_registro
        Set(ByVal value)
            _tit_ultimo_registro = value
        End Set
        Get
            Return _tit_ultimo_registro
        End Get
    End Property
    Property titulo_serie
        Set(ByVal value)
            _tit_serie = value
        End Set
        Get
            Return _tit_serie
        End Get
    End Property
    Property titulo_modelo
        Set(ByVal value)
            _tit_modelo = value
        End Set
        Get
            Return _tit_modelo
        End Get
    End Property
    Property titulo_hora
        Set(ByVal value)
            _tit_hora = value
        End Set
        Get
            Return _tit_hora
        End Get
    End Property
    Property titulo_tiempo_caido
        Set(ByVal value)
            _tit_tiempo_caido = value
        End Set
        Get
            Return _tit_tiempo_caido
        End Get
    End Property
    Property titulo_actul
        Set(ByVal value)
            _tit_actual = value
        End Set
        Get
            Return _tit_actual
        End Get
    End Property
    Property titulo_acumulado
        Set(ByVal value)
            _tit_acumulado = value
        End Set
        Get
            Return _tit_acumulado
        End Get
    End Property
    Property titulo_hora_actual
        Set(ByVal value)
            _tit_hora_actual = value
        End Set
        Get
            Return _tit_hora_actual
        End Get
    End Property
    Property titulo_meta
        Set(ByVal value)
            _tit_meta = value
        End Set
        Get
            Return _tit_meta
        End Get
    End Property
    Property empleados_area
        Set(ByVal value)
            _cant_empleados = value
        End Set
        Get
            Return _cant_empleados
        End Get
    End Property
    Property diagonal
        Set(ByVal value)
            _diagonal = value
        End Set
        Get
            Return _diagonal
        End Get
    End Property
    Property segundero
        Set(ByVal value)
            _segundero = value
        End Set
        Get
            Return _segundero
        End Get
    End Property
    Property meta_del_dia
        Set(ByVal value)
            _meta_del_dia = value
        End Set
        Get
            Return _meta_del_dia
        End Get
    End Property
    Property produccion_actual
        Set(ByVal value)
            _produccion_actual = value
        End Set
        Get
            Return _produccion_actual
        End Get
    End Property
    Property reloj
        Set(ByVal value)
            _reloj = value
        End Set
        Get
            Return _reloj
        End Get
    End Property
    Property meta_actual
        Set(ByVal value)
            _meta_actual = value
        End Set
        Get
            Return _meta_actual
        End Get
    End Property
    Sub actualizar_meta_actual(ByVal Value As Integer)
        _meta_actual.Text = Value
    End Sub
    Property ultimo_serie
        Set(ByVal value)
            _ultimo_serie = value
        End Set
        Get
            Return _ultimo_serie
        End Get
    End Property
    Sub actualizar_ultimo_serie(ByVal Value As String)
        _ultimo_serie.Text = Value
    End Sub
    Property ultimo_modelo
        Set(ByVal value)
            _ultimo_modelo = value
        End Set
        Get
            Return _ultimo_modelo
        End Get
    End Property
    Sub actualizar_ultimo_modelo(ByVal Value As String)
        _ultimo_modelo.Text = Value
    End Sub
    Property downtime_actual
        Set(ByVal value)
            _downtime_actual = value
        End Set
        Get
            Return _downtime_actual
        End Get
    End Property
    Sub actualizar_downtime_actual(ByVal Value As String)
        _downtime_actual.Text = Value
    End Sub
    Property ultimo_hora
        Set(ByVal value)
            _ultimo_hora = value
        End Set
        Get
            Return _ultimo_hora
        End Get
    End Property
    Sub actualizar_ultimo_hora(ByVal Value As String)
        _ultimo_hora.Text = Value
    End Sub
    Property datasource
        Set(ByVal value)
            _datasource = value
        End Set
        Get
            Return _datasource
        End Get
    End Property
    Property area
        Set(ByVal value)
            _area = value
        End Set
        Get
            Return _area
        End Get
    End Property
    Sub actualizar_downtime_daily(ByVal Value As String)
        _downtime_daily.Text = Value
    End Sub
    Sub actualizar_empleados_area(ByVal Value As String)
        _cant_empleados.Text = Value
    End Sub
    Property downtime_daily
        Set(ByVal value)
            _downtime_daily = value
        End Set
        Get
            Return _downtime_daily
        End Get
    End Property
    Function actualizar()

        configurar_idioma()
        config_turno_transcurrido()
        config_downtime_actual()
        actualizar_linea()
        actualizar_rev()
        actualizar_meta_del_dia(_datasource.obtener_daily_rate(_area))
        actualizar_produccion_actual(_datasource.obtener_maquinas_producidas(_area))
        actualizar_meta_actual(_datasource.obtener_meta_actual(_area))
        actualizar_ultimo_modelo(_datasource.obtener_ultimo_modelo(_area))
        actualizar_ultimo_serie(_datasource.obtener_ultimo_serie(_area))
        actualizar_ultimo_hora(_datasource.obtener_ultimo_hora(_area))
        actualizar_downtime_actual((convert_int_to_time(_datasource.obtener_downtime_actual(_area))))
        actualizar_downtime_daily((convert_int_to_time(_datasource.obtener_spill_time(_area))))
        actualizar_empleados_area(_datasource.obtener_empleados_area(_area))
        actualizar_pb_downtime_actual(_datasource.obtener_pb_downtime_actual(_area))
        actualizar_semaforo(CInt(_produccion_actual.Text) - CInt(_meta_actual.Text))
        actualizar_pb_turno_transcurrido(_datasource.obtener_turno_transcurrido(_area))
        Return 1
    End Function
    Function convert_int_to_time(ByVal minutes As Integer)
        Dim _cadena As String

        _cadena = "Error"

        If (minutes >= 0 And minutes <= 9) Then
            _cadena = ("00:0" & minutes)
        End If
        If (minutes > 9 And minutes <= 59) Then
            _cadena = ("00:" & minutes)
        End If
        If (minutes > 59 And minutes < 1440) Then
            Dim horas As Integer
            Dim mod_horas As Long
            Dim minutos As Integer

            mod_horas = minutes Mod 60

            horas = (minutes / 60)
            minutos = mod_horas
            If (minutos >= 0 And minutos <= 9) Then
                _cadena = horas & ":0" & minutos
            End If
            If (minutos > 9 And minutos <= 59) Then
                _cadena = (horas & ":" & minutos)
            End If

        End If
        Return _cadena
    End Function
    Sub actualizar_pb_downtime_actual(ByVal Value As String)

        If (Value > 0.98 * (pb_downtime_actual.maximum)) Then
            _pb_downtime_actual.ForeColor = Color.Red
        Else
            _pb_downtime_actual.ForeColor = Color.Lime
        End If
        _pb_downtime_actual.Value = Value
        Dim _comp1 As Double = (0.4 * (pb_downtime_actual.maximum))
        Dim _comp2 As Double = (0.98 * (pb_downtime_actual.maximum))

        If (Value <= _comp1) Then
            _takt_time.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.Control)
        Else

            If (_comp2 > Value < _comp1) Then
                _takt_time.BackColor = Color.Lime

                If (Value >= _comp2) Then
                    _takt_time.BackColor = Color.Red
                Else
                End If
            End If

        End If


    End Sub
    Property pb_downtime_actual
        Set(ByVal value)
            _pb_downtime_actual = value
        End Set
        Get
            Return _pb_downtime_actual
        End Get
    End Property
    Property semaforo
        Set(ByVal value)
            _semaforo = value
        End Set
        Get
            Return _semaforo
        End Get
    End Property
    Property semaforo_reloj
        Set(ByVal value)
            _semaforo_reloj = value
        End Set
        Get
            Return _semaforo_reloj
        End Get
    End Property
    Sub actualizar_linea()

        _tit_linea.text = My.Settings.linea

    End Sub
    Sub actualizar_rev()
        Try
            _tit_rev.Text = My.Application.Deployment.CurrentVersion.Revision.ToString
        Catch ex As Exception
            _tit_rev.Text = "Dev Mode"
            pantalla.WriteToEventLog("Error al obtener la revision " & ex.Message, , EventLogEntryType.Warning)
        End Try

    End Sub
    Sub actualizar_semaforo(ByVal Value As String)

        If (Value < 0) Then
            _semaforo_reloj.Enabled = True
        Else
            _semaforo.backcolor = Color.ForestGreen
            _produccion_actual.BackColor = Color.ForestGreen
            _meta_actual.BackColor = Color.ForestGreen
            _diagonal.BackColor = Color.ForestGreen
            _semaforo_reloj.Enabled = False
        End If

    End Sub
    Sub actualizar_hora()
        _reloj.Text = Format(Now, "h:mm tt")
    End Sub
    Sub actualizar_meta_del_dia(ByVal Value As Integer)
        _meta_del_dia.Text = Value
    End Sub
    Sub actualizar_produccion_actual(ByVal Value As Integer)
        _produccion_actual.Text = Value
    End Sub
    Function servicio_reloj(ByVal status As Boolean)
        _segundero.Enabled = status
        Return 1
    End Function
    Property pb_turno_transcurrido
        Set(ByVal value)
            _pb_turno_transcurrido = value
        End Set
        Get
            Return _pb_turno_transcurrido
        End Get
    End Property
    Sub actualizar_pb_turno_transcurrido(ByVal Value As String)
        _pb_turno_transcurrido.Value = Value
    End Sub
    Sub config_downtime_actual()
        _pb_downtime_actual.Minimum = 0
        _pb_downtime_actual.Maximum = _datasource.obtener_takt_time(_area)
        _takt_time.Text = CStr(_pb_downtime_actual.Maximum)
    End Sub
    Sub config_turno_transcurrido()
        _pb_turno_transcurrido.Minimum = 0
        _pb_turno_transcurrido.Maximum = _datasource.obtener_turno_duracion(_area)

    End Sub
    Property acomodar_pantalla_tmr
        Set(ByVal value)
            _acomodar_pantalla_tmr = value
        End Set
        Get
            Return _acomodar_pantalla_tmr
        End Get
    End Property
    Function acomodar_pantalla()
        actualizar_hora()
        Dim _longitud As Integer

        _longitud = Len(_meta_actual.Text)
        If _longitud = 1 Then
            Dim lbl_meta_actual_location As New System.Drawing.Point(419, 42)
            _meta_actual.Location = lbl_meta_actual_location
        End If
        If _longitud > 1 Then
            Dim lbl_meta_actual_location As New System.Drawing.Point(341, 42)
            _meta_actual.Location = lbl_meta_actual_location
        End If

        _longitud = Len(_produccion_actual.Text)
        If _longitud = 1 Then
            Dim lbl_actual_location As New System.Drawing.Point(43, 42)
            _produccion_actual.Location = lbl_actual_location
        End If
        If _longitud > 1 Then
            Dim lbl_actual_location As New System.Drawing.Point(-38, 42)
            _produccion_actual.Location = lbl_actual_location
        End If

        _longitud = Len(_downtime_actual.Text)
        If _longitud = 4 Then
            Dim lbl_downtime_actual_location As New System.Drawing.Point(257, 104)
            _downtime_actual.Location = lbl_downtime_actual_location
        End If
        If _longitud > 4 Then
            Dim lbl_downtime_actual_location As New System.Drawing.Point(223, 104)
            _downtime_actual.Location = lbl_downtime_actual_location
        End If

        _longitud = Len(_ultimo_hora.Text)
        If _longitud = 7 Then
            Dim lbl_ultimo_hora_location As New System.Drawing.Point(130, 28)
            _ultimo_hora.Location = lbl_ultimo_hora_location
        End If
        If _longitud > 7 Then
            Dim lbl_ultimo_hora_location As New System.Drawing.Point(146, 28)
            _ultimo_hora.Location = lbl_ultimo_hora_location
        End If
        _longitud = Len(_downtime_daily.Text)
        If _longitud = 4 Then
            Dim lbl_downtime_daily_location As New System.Drawing.Point(257, 11)
            _downtime_daily.Location = lbl_downtime_daily_location
        End If
        If _longitud > 4 Then
            Dim lbl_downtime_daily_location As New System.Drawing.Point(223, 11)
            _downtime_daily.Location = lbl_downtime_daily_location
        End If
        Return 1
    End Function
    Function configurar_idioma()
        Dim _val As Integer = 0
        Try
            If _idioma = My.Settings.idioma Then

            Else
                _idioma = My.Settings.idioma
                seleccionar_idioma()
            End If
            _val = 1

        Catch ex As Exception
            pantalla.WriteToEventLog("Error al configurar idioma " & ex.Message, , EventLogEntryType.Error)
            _val = 0
        End Try
        Return _val
    End Function
    Function seleccionar_idioma()

        Select Case _idioma
            Case "ES_MX"
                _tit_empleados.text = "Empleados"
                _tit_proceso.text = "Proceso"
                _tit_turno_actual.text = "Turno Actual"
                _tit_maquina_actual.text = "Maquina Actual - Takt"
                _tit_objetivo.text = "Objetivo"
                _tit_real.text = "Real"
                _tit_plan.text = "Plan"
                _tit_ultimo_registro.text = "Ultimo Registro"
                _tit_serie.text = "Serie"
                _tit_modelo.text = "Modelo"
                _tit_hora.text = "Hora"
                _tit_tiempo_caido.text = "Tiempo Caido - Spill"
                _tit_actual.text = "Actual"
                _tit_acumulado.text = "Acumulado"
                _tit_hora_actual.text = "Hora Actual"
                _tit_meta.text = "Meta"
            Case "EN_US"
                _tit_empleados.text = "Employees"
                _tit_proceso.text = "Process"
                _tit_turno_actual.text = "Actual Shift"
                _tit_maquina_actual.text = "Actual Machine - Takt"
                _tit_objetivo.text = "Objective"
                _tit_real.text = "Actual"
                _tit_plan.text = "Plan"
                _tit_ultimo_registro.text = "Last Register"
                _tit_serie.text = "Series"
                _tit_modelo.text = "Model"
                _tit_hora.text = "Time"
                _tit_tiempo_caido.text = "Downtime - Spill"
                _tit_actual.text = "Actual"
                _tit_acumulado.text = "Accumulated"
                _tit_hora_actual.text = "Actual Time"
                _tit_meta.text = "Goal"
        End Select
        Return 1
    End Function

    Public Shared Function WriteToEventLog(ByVal entry As String,
                    Optional ByVal aplicacion As String = "eDashboard",
                    Optional ByVal eventType As EventLogEntryType = EventLogEntryType.Information,
                    Optional ByVal logName As String = "eDashboard") As Boolean

        Dim objEventLog As New EventLog

        Try

            If Not EventLog.SourceExists(aplicacion) Then
                EventLog.CreateEventSource(aplicacion, logName)
            End If

            objEventLog.Source = aplicacion
            objEventLog.WriteEntry(entry, eventType)

            Return True

        Catch Ex As Exception

            Return False

        End Try

    End Function

End Class
