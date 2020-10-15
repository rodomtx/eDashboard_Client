Imports System.Data.SqlClient
Imports System
Imports System.Diagnostics




Public Class pantalla_produccion
    Dim _conexion_2 = "Data Source=fstraxdbprod ;Initial Catalog=DAX2009_SP1_PROD ;Integrated Security=True"
    Dim SQLConn_2 As New SqlConnection()

    Public query As String
    Public conexion As String
    Public servidor As New sql
    Public dashboard As New pantalla
    Public flash As Integer
    Public Const VK_LSHIFT As Byte = 160
    Public Const KEYEVENTF_KEYUP As Integer = 2
    Public Declare Sub keybd_event Lib "user32" (ByVal bVirtualKey As Byte, ByVal bScanCode As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Public audio_check_pre As Boolean = False
    Public audio_check_end As Boolean = False
    Public timetogoref As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            config_dashboard(dashboard)
            dashboard.idioma = My.Settings.idioma
            dashboard.seleccionar_idioma()
            dashboard.actualizar()
            dashboard.servicio_reloj(True)
            dashboard.acomodar_pantalla()


        Catch ex As Exception

        End Try

    End Sub
    ''' Poner la hora en el reloj y
    '''  acomodar con respecto a la cantidad de digitos , una vez cada minuto deberia funcionar
    '''  se va a poner el interval a 1000 para que se actualize con el segundero (01/19/2016)
    Private Sub tmr_segundo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_segundo.Tick
        dashboard.acomodar_pantalla()
    End Sub
    Sub change_color(ByVal color As Color)

        dashboard.produccion_actual.BackColor = color
        dashboard.meta_actual.BackColor = color
        dashboard.diagonal.backcolor = color
        dashboard.semaforo.backcolor = color
    End Sub


    ''' jala la info de la base de datos
    ''' se ajusta a 60K para ver que tal va (01/19/2016)
    ''' prueba de sonido

    Private Sub tmr_semaforo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_semaforo.Tick
        If (flash = 9) Then
            flash = 0
        End If
        If (flash > 3 And flash < 10) Then
            flash += 1
        End If
        If (flash = 3) Then
            change_color(Color.Transparent)
            flash += 1
        End If
        If (flash = 2) Then
            change_color(Color.Red)
            flash += 1
        End If
        If (flash = 1) Then
            change_color(Color.Transparent)
            flash += 1
        End If

        If (flash = 0) Then
            change_color(Color.Red)
            flash += 1
        End If
    End Sub


    Private Sub tmr_consultas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_consultas.Tick




        Dim timetogo = CInt(dashboard.takt_time.text) - CInt(dashboard.pb_downtime_actual.value)


        If (timetogo > timetogoref) Then
            audio_check_pre = False
            audio_check_end = False
        End If

        timetogoref = timetogo


        If CInt(timetogo) <= 5 And audio_check_pre = False Then
            audio_check_pre = True

            Try
                Dim wave() As Byte = IO.File.ReadAllBytes(My.Settings.pre_takt_time_sound.ToString)
                My.Computer.Audio.Play(wave, AudioPlayMode.Background)

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If




        If CInt(timetogo) <= 0 And audio_check_end = False Then
            audio_check_end = True

            Try
                Dim wave() As Byte = IO.File.ReadAllBytes(My.Settings.takt_time_sound.ToString)
                My.Computer.Audio.Play(wave, AudioPlayMode.Background)

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If



        dashboard.actualizar()


    End Sub
    ''' temporizaor del reloj de la pantalla      
    ''' ''' temporizador cada cuando se jala la informacion

    Private Sub config_dashboard(ByVal _dashboard As Object)
        flash = 0

        With _dashboard
            .takt_time = lbl_takt_time
            .titulo_linea = lbl_linea
            .titulo_hora_actual = lbl_tit_hora_actual
            .titulo_meta = lbl_tit_meta
            .titulo_empleados = lbl_tit_empleados
            .titulo_proceso = gb_proceso
            .titulo_turno_actual = lbl_tit_turno_actual
            .titulo_maquina_actual = lbl_tit_maq_actual
            .titulo_objetivo = gb_objetivo
            .titulo_real = lbl_tit_real
            .titulo_plan = lbl_tit_plan
            .titulo_ultimo_registro = gb_ultimo_registro
            .titulo_serie = lbl_tit_serie
            .titulo_modelo = lbl_tit_modelo
            .titulo_hora = lbl_tit_hora
            .titulo_tiempo_caido = gb_downtime
            .titulo_actul = lbl_tit_actual
            .titulo_acumulado = lbl_tit_acumulado
            .reloj = lbl_reloj
            .area = My.Settings.linea
            .datasource = servidor

            .segundero = tmr_consultas
            .segundero.Interval = 600000
            .semaforo_reloj = tmr_semaforo

            .acomodar_pantalla_tmr = tmr_segundo
            .acomodar_pantalla_tmr.interval = 1000
            .acomodar_pantalla_tmr.enabled = True
            .semaforo_reloj.interval = 150
            .semaforo_reloj.enabled = False
            .meta_del_dia = lbl_daily_goal
            .produccion_actual = lbl_actual
            .meta_actual = lbl_meta_actual
            .diagonal = Label5
            .ultimo_hora = lbl_last_update
            .ultimo_serie = lbl_last_serial
            .ultimo_modelo = lbl_modelo
            .downtime_actual = lbl_downtime_actual
            .downtime_daily = lbl_downtime_daily
            .pb_downtime_actual = pb_actual
            .pb_turno_transcurrido = pb_acumulado
            .empleados_area = lbl_empleados
            .semaforo = gb_objetivo
            .titulo_rev = lbl_rev

        End With



    End Sub
    Private Sub pantalla_produccion_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        frm_opciones.Show()
    End Sub
    Private Sub shift_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shift.Tick
        keybd_event(VK_LSHIFT, 69, KEYEVENTF_KEYUP, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim wave() As Byte = IO.File.ReadAllBytes("C:\Program Files (x86)\iTunes\iTunes.Resources\complete.wav")


        Try
            My.Computer.Audio.Play(wave, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

End Class
