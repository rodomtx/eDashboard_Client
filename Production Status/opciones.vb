Public Class frm_opciones

    Private Sub frm_opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'llenar combo de seleccion de idiomas
        cmb_idiomas.Items.Clear()
        cmb_idiomas.Items.Add("ES_MX")
        cmb_idiomas.Items.Add("EN_US")
        
        'traer valores actuales de configuracion en My Settings
        cmb_idiomas.SelectedText = My.Settings.idioma
        cmb_minutos.SelectedText = My.Settings.pre_takt_time_time
        tb_pre_takt_time_sound.Text = My.Settings.pre_takt_time_sound.ToString
        tb_takt_time_sound.Text = My.Settings.takt_time_sound.ToString


        'vaciar / rellenar combo de areas con info de DB'

        cmb_areas.Items.Clear()
        For Each area In (pantalla_produccion.servidor.obtener_lista_areas())
            If (IsNothing(area)) Then
            Else
                cmb_areas.Items.Add(area)
            End If
        Next area
        cmb_areas.SelectedText = My.Settings.linea

        'vaciar / rellenar combo de cantidad de minutos '
        cmb_minutos.Items.Clear()
        For i = 0 To 10
            cmb_minutos.Items.Add(i)
        Next

    End Sub

    Private Sub btn_cancel_cambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel_cambios.Click
        'cerrar ventana sin realizar cambios'
        pantalla_produccion.Focus()
        Me.Close()


    End Sub

    Private Sub btn_guardar_cambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar_cambios.Click

        'guardar cambios de sonido de takt time
        ' si el valor es igual no hace nada
        'si el valor nuevo es vacio tampoco hace nada
        ' solo si el valor nuevo es diferente lo guarda 

        If tb_takt_time_sound.Text = My.Settings.takt_time_sound Then
        Else
            If tb_takt_time_sound.Text = "" Then
            Else
                My.Settings.takt_time_sound = tb_takt_time_sound.Text
            End If
        End If


        'guardar cambios de sonido de pre takt time
        ' si el valor es igual no hace nada
        'si el valor nuevo es vacio tampoco hace nada
        ' solo si el valor nuevo es diferente lo guarda 

        If tb_pre_takt_time_sound.Text = My.Settings.pre_takt_time_sound Then
        Else
            If tb_pre_takt_time_sound.Text = "" Then
            Else
                My.Settings.pre_takt_time_sound = tb_pre_takt_time_sound.Text
            End If
        End If

        'guardar cambios de idioma
        ' si el valor es igual no hace nada
        'si el valor nuevo es vacio tampoco hace nada
        ' solo si el valor nuevo es diferente lo guarda 
        ' y despues llama la funcion que cambia las cadenas del idioma


        If cmb_idiomas.SelectedItem = My.Settings.idioma Then
        Else
            If cmb_idiomas.SelectedItem = "" Then
            Else
                My.Settings.idioma = cmb_idiomas.SelectedItem
                pantalla_produccion.dashboard.configurar_idioma()
            End If
        End If

        'guardar cambios de el area del tablero
        ' si el valor es igual al anterior  no hace nada
        'si el valor nuevo es vacio tampoco hace nada
        ' solo si el valor nuevo es diferente lo guarda 


        If cmb_areas.SelectedItem = My.Settings.linea Then
        Else
            If cmb_areas.SelectedItem = "" Then
            Else
                My.Settings.linea = cmb_areas.SelectedItem
                pantalla_produccion.dashboard.area = My.Settings.linea

            End If
        End If

        'guardar cambios de el area del tablero
        ' si el valor es igual al anterior  no hace nada
        'si el valor nuevo es vacio tampoco hace nada
        ' solo si el valor nuevo es diferente lo guarda 

        Try

            If cmb_minutos.SelectedItem = My.Settings.pre_takt_time_time Then
            Else
                If IsNothing(cmb_minutos.SelectedItem) Then
                Else
                    My.Settings.pre_takt_time_time = CInt(cmb_minutos.SelectedItem.ToString)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

        'al final actualiza la informacion en el tablero con los cambios
        'despues enfoca la pantalla principal y se cierra'

        pantalla_produccion.dashboard.actualizar()
        pantalla_produccion.Focus()
        Me.Close()
    End Sub

    
    Private Sub picb_pre_takt_time_Click(sender As Object, e As EventArgs) Handles picb_pre_takt_time.Click

        Try
            Dim wave() As Byte = IO.File.ReadAllBytes(My.Settings.pre_takt_time_sound.ToString)
            My.Computer.Audio.Play(wave, AudioPlayMode.Background)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub picb_takt_time_Click(sender As Object, e As EventArgs) Handles picb_takt_time.Click
        Try
            Dim wave() As Byte = IO.File.ReadAllBytes(My.Settings.takt_time_sound.ToString)
            My.Computer.Audio.Play(wave, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btn_path_pre_takt_time_sound_Click(sender As Object, e As EventArgs) Handles btn_path_pre_takt_time_sound.Click
        'abre dialogo para buscar archivo con filtro wav y lo guarda en el textbox correspondiente
        OPFD_pre_takt_time_sound.Filter = "Sound Files (*.wav)|*.wav"
        OPFD_pre_takt_time_sound.ShowDialog()

        tb_pre_takt_time_sound.Text = OPFD_pre_takt_time_sound.FileName
    End Sub

    Private Sub btn_path_takt_time_sound_Click(sender As Object, e As EventArgs) Handles btn_path_takt_time_sound.Click
        'abre dialogo para buscar archivo con filtro wav y lo guarda en el textbox correspondiente
        OPFD_pre_takt_time_sound.Filter = "Sound Files (*.wav)|*.wav"

        OPFD_pre_takt_time_sound.ShowDialog()

        tb_takt_time_sound.Text = OPFD_pre_takt_time_sound.FileName
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class