<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pantalla_produccion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantalla_produccion))
        Me.lbl_linea = New System.Windows.Forms.Label()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.lbl_empleados = New System.Windows.Forms.Label()
        Me.lbl_downtime_daily = New System.Windows.Forms.Label()
        Me.lbl_downtime_actual = New System.Windows.Forms.Label()
        Me.lbl_daily_goal = New System.Windows.Forms.Label()
        Me.lbl_meta_actual = New System.Windows.Forms.Label()
        Me.lbl_actual = New System.Windows.Forms.Label()
        Me.lbl_last_serial = New System.Windows.Forms.Label()
        Me.lbl_tit_hora = New System.Windows.Forms.Label()
        Me.lbl_tit_real = New System.Windows.Forms.Label()
        Me.lbl_tit_plan = New System.Windows.Forms.Label()
        Me.lbl_tit_meta = New System.Windows.Forms.Label()
        Me.lbl_tit_actual = New System.Windows.Forms.Label()
        Me.lbl_tit_acumulado = New System.Windows.Forms.Label()
        Me.lbl_tit_empleados = New System.Windows.Forms.Label()
        Me.lbl_tit_modelo = New System.Windows.Forms.Label()
        Me.lbl_last_update = New System.Windows.Forms.Label()
        Me.gb_objetivo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gb_ultimo_registro = New System.Windows.Forms.GroupBox()
        Me.lbl_tit_serie = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gb_downtime = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_reloj = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmr_segundo = New System.Windows.Forms.Timer(Me.components)
        Me.gb_proceso = New System.Windows.Forms.GroupBox()
        Me.lbl_takt_time = New System.Windows.Forms.Label()
        Me.pb_acumulado = New System.Windows.Forms.ProgressBar()
        Me.lbl_tit_turno_actual = New System.Windows.Forms.Label()
        Me.pb_actual = New System.Windows.Forms.ProgressBar()
        Me.lbl_tit_maq_actual = New System.Windows.Forms.Label()
        Me.lbl_tit_hora_actual = New System.Windows.Forms.Label()
        Me.tmr_semaforo = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_consultas = New System.Windows.Forms.Timer(Me.components)
        Me.mnu_opciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Idioma = New System.Windows.Forms.ToolStripComboBox()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuruRuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RurururuTaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.shift = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_tit_rev = New System.Windows.Forms.Label()
        Me.lbl_rev = New System.Windows.Forms.Label()
        Me.gb_objetivo.SuspendLayout()
        Me.gb_ultimo_registro.SuspendLayout()
        Me.gb_downtime.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_proceso.SuspendLayout()
        Me.mnu_opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_linea
        '
        Me.lbl_linea.AutoSize = True
        Me.lbl_linea.BackColor = System.Drawing.Color.Transparent
        Me.lbl_linea.Font = New System.Drawing.Font("Arial Narrow", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_linea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_linea.Location = New System.Drawing.Point(447, 14)
        Me.lbl_linea.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_linea.Name = "lbl_linea"
        Me.lbl_linea.Size = New System.Drawing.Size(32, 75)
        Me.lbl_linea.TabIndex = 0
        Me.lbl_linea.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modelo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_modelo.Location = New System.Drawing.Point(134, 72)
        Me.lbl_modelo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(74, 45)
        Me.lbl_modelo.TabIndex = 1
        Me.lbl_modelo.Text = "IBD"
        '
        'lbl_empleados
        '
        Me.lbl_empleados.AutoSize = True
        Me.lbl_empleados.BackColor = System.Drawing.Color.Transparent
        Me.lbl_empleados.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empleados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_empleados.Location = New System.Drawing.Point(197, 81)
        Me.lbl_empleados.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_empleados.Name = "lbl_empleados"
        Me.lbl_empleados.Size = New System.Drawing.Size(37, 45)
        Me.lbl_empleados.TabIndex = 2
        Me.lbl_empleados.Text = "?"
        '
        'lbl_downtime_daily
        '
        Me.lbl_downtime_daily.AutoSize = True
        Me.lbl_downtime_daily.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_downtime_daily.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_downtime_daily.Location = New System.Drawing.Point(223, 11)
        Me.lbl_downtime_daily.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_downtime_daily.Name = "lbl_downtime_daily"
        Me.lbl_downtime_daily.Size = New System.Drawing.Size(179, 78)
        Me.lbl_downtime_daily.TabIndex = 4
        Me.lbl_downtime_daily.Text = "00:00"
        '
        'lbl_downtime_actual
        '
        Me.lbl_downtime_actual.AutoSize = True
        Me.lbl_downtime_actual.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_downtime_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_downtime_actual.Location = New System.Drawing.Point(223, 97)
        Me.lbl_downtime_actual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_downtime_actual.Name = "lbl_downtime_actual"
        Me.lbl_downtime_actual.Size = New System.Drawing.Size(179, 78)
        Me.lbl_downtime_actual.TabIndex = 5
        Me.lbl_downtime_actual.Text = "00:00"
        '
        'lbl_daily_goal
        '
        Me.lbl_daily_goal.AutoSize = True
        Me.lbl_daily_goal.Font = New System.Drawing.Font("Calibri", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_daily_goal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_daily_goal.Location = New System.Drawing.Point(216, 39)
        Me.lbl_daily_goal.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_daily_goal.Name = "lbl_daily_goal"
        Me.lbl_daily_goal.Size = New System.Drawing.Size(56, 44)
        Me.lbl_daily_goal.TabIndex = 6
        Me.lbl_daily_goal.Text = "00"
        '
        'lbl_meta_actual
        '
        Me.lbl_meta_actual.AutoSize = True
        Me.lbl_meta_actual.Font = New System.Drawing.Font("Calibri", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_meta_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_meta_actual.Location = New System.Drawing.Point(398, 101)
        Me.lbl_meta_actual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_meta_actual.Name = "lbl_meta_actual"
        Me.lbl_meta_actual.Size = New System.Drawing.Size(244, 195)
        Me.lbl_meta_actual.TabIndex = 7
        Me.lbl_meta_actual.Text = "00"
        '
        'lbl_actual
        '
        Me.lbl_actual.AutoSize = True
        Me.lbl_actual.Font = New System.Drawing.Font("Calibri", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_actual.Location = New System.Drawing.Point(1, 101)
        Me.lbl_actual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_actual.Name = "lbl_actual"
        Me.lbl_actual.Size = New System.Drawing.Size(244, 195)
        Me.lbl_actual.TabIndex = 9
        Me.lbl_actual.Text = "00"
        '
        'lbl_last_serial
        '
        Me.lbl_last_serial.AutoSize = True
        Me.lbl_last_serial.BackColor = System.Drawing.Color.Transparent
        Me.lbl_last_serial.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last_serial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_last_serial.Location = New System.Drawing.Point(136, 114)
        Me.lbl_last_serial.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_last_serial.Name = "lbl_last_serial"
        Me.lbl_last_serial.Size = New System.Drawing.Size(152, 45)
        Me.lbl_last_serial.TabIndex = 10
        Me.lbl_last_serial.Text = "------------"
        '
        'lbl_tit_hora
        '
        Me.lbl_tit_hora.AutoSize = True
        Me.lbl_tit_hora.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_hora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_hora.Location = New System.Drawing.Point(10, 37)
        Me.lbl_tit_hora.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_hora.Name = "lbl_tit_hora"
        Me.lbl_tit_hora.Size = New System.Drawing.Size(71, 36)
        Me.lbl_tit_hora.TabIndex = 21
        Me.lbl_tit_hora.Text = "Hora"
        '
        'lbl_tit_real
        '
        Me.lbl_tit_real.AutoSize = True
        Me.lbl_tit_real.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_real.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_real.Location = New System.Drawing.Point(113, 42)
        Me.lbl_tit_real.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_real.Name = "lbl_tit_real"
        Me.lbl_tit_real.Size = New System.Drawing.Size(65, 36)
        Me.lbl_tit_real.TabIndex = 20
        Me.lbl_tit_real.Text = "Real"
        '
        'lbl_tit_plan
        '
        Me.lbl_tit_plan.AutoSize = True
        Me.lbl_tit_plan.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_plan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_plan.Location = New System.Drawing.Point(491, 42)
        Me.lbl_tit_plan.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_plan.Name = "lbl_tit_plan"
        Me.lbl_tit_plan.Size = New System.Drawing.Size(66, 36)
        Me.lbl_tit_plan.TabIndex = 18
        Me.lbl_tit_plan.Text = "Plan"
        '
        'lbl_tit_meta
        '
        Me.lbl_tit_meta.AutoSize = True
        Me.lbl_tit_meta.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_meta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_meta.Location = New System.Drawing.Point(70, 45)
        Me.lbl_tit_meta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_meta.Name = "lbl_tit_meta"
        Me.lbl_tit_meta.Size = New System.Drawing.Size(78, 36)
        Me.lbl_tit_meta.TabIndex = 17
        Me.lbl_tit_meta.Text = "Meta"
        '
        'lbl_tit_actual
        '
        Me.lbl_tit_actual.AutoSize = True
        Me.lbl_tit_actual.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_actual.Location = New System.Drawing.Point(23, 130)
        Me.lbl_tit_actual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_actual.Name = "lbl_tit_actual"
        Me.lbl_tit_actual.Size = New System.Drawing.Size(90, 36)
        Me.lbl_tit_actual.TabIndex = 16
        Me.lbl_tit_actual.Text = "Actual"
        '
        'lbl_tit_acumulado
        '
        Me.lbl_tit_acumulado.AutoSize = True
        Me.lbl_tit_acumulado.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_acumulado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_acumulado.Location = New System.Drawing.Point(23, 37)
        Me.lbl_tit_acumulado.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_acumulado.Name = "lbl_tit_acumulado"
        Me.lbl_tit_acumulado.Size = New System.Drawing.Size(148, 36)
        Me.lbl_tit_acumulado.TabIndex = 15
        Me.lbl_tit_acumulado.Text = "Acumulado"
        '
        'lbl_tit_empleados
        '
        Me.lbl_tit_empleados.AutoSize = True
        Me.lbl_tit_empleados.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tit_empleados.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_empleados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_empleados.Location = New System.Drawing.Point(44, 88)
        Me.lbl_tit_empleados.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_empleados.Name = "lbl_tit_empleados"
        Me.lbl_tit_empleados.Size = New System.Drawing.Size(143, 36)
        Me.lbl_tit_empleados.TabIndex = 13
        Me.lbl_tit_empleados.Text = "Empleados"
        '
        'lbl_tit_modelo
        '
        Me.lbl_tit_modelo.AutoSize = True
        Me.lbl_tit_modelo.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_modelo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_modelo.Location = New System.Drawing.Point(10, 79)
        Me.lbl_tit_modelo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_modelo.Name = "lbl_tit_modelo"
        Me.lbl_tit_modelo.Size = New System.Drawing.Size(106, 36)
        Me.lbl_tit_modelo.TabIndex = 12
        Me.lbl_tit_modelo.Text = "Modelo"
        '
        'lbl_last_update
        '
        Me.lbl_last_update.AutoSize = True
        Me.lbl_last_update.BackColor = System.Drawing.Color.Transparent
        Me.lbl_last_update.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_last_update.Location = New System.Drawing.Point(145, 27)
        Me.lbl_last_update.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_last_update.Name = "lbl_last_update"
        Me.lbl_last_update.Size = New System.Drawing.Size(106, 45)
        Me.lbl_last_update.TabIndex = 24
        Me.lbl_last_update.Text = "00:00"
        '
        'gb_objetivo
        '
        Me.gb_objetivo.BackColor = System.Drawing.Color.Transparent
        Me.gb_objetivo.Controls.Add(Me.lbl_tit_plan)
        Me.gb_objetivo.Controls.Add(Me.Label5)
        Me.gb_objetivo.Controls.Add(Me.lbl_meta_actual)
        Me.gb_objetivo.Controls.Add(Me.lbl_tit_real)
        Me.gb_objetivo.Controls.Add(Me.lbl_actual)
        Me.gb_objetivo.Location = New System.Drawing.Point(356, 129)
        Me.gb_objetivo.Margin = New System.Windows.Forms.Padding(5)
        Me.gb_objetivo.Name = "gb_objetivo"
        Me.gb_objetivo.Padding = New System.Windows.Forms.Padding(5)
        Me.gb_objetivo.Size = New System.Drawing.Size(646, 308)
        Me.gb_objetivo.TabIndex = 25
        Me.gb_objetivo.TabStop = False
        Me.gb_objetivo.Text = "Objetivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(262, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 146)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "/"
        '
        'gb_ultimo_registro
        '
        Me.gb_ultimo_registro.BackColor = System.Drawing.Color.Transparent
        Me.gb_ultimo_registro.Controls.Add(Me.lbl_tit_serie)
        Me.gb_ultimo_registro.Controls.Add(Me.lbl_modelo)
        Me.gb_ultimo_registro.Controls.Add(Me.lbl_tit_modelo)
        Me.gb_ultimo_registro.Controls.Add(Me.lbl_last_update)
        Me.gb_ultimo_registro.Controls.Add(Me.lbl_last_serial)
        Me.gb_ultimo_registro.Controls.Add(Me.lbl_tit_hora)
        Me.gb_ultimo_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ultimo_registro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_ultimo_registro.Location = New System.Drawing.Point(524, 447)
        Me.gb_ultimo_registro.Margin = New System.Windows.Forms.Padding(5)
        Me.gb_ultimo_registro.Name = "gb_ultimo_registro"
        Me.gb_ultimo_registro.Padding = New System.Windows.Forms.Padding(5)
        Me.gb_ultimo_registro.Size = New System.Drawing.Size(478, 187)
        Me.gb_ultimo_registro.TabIndex = 26
        Me.gb_ultimo_registro.TabStop = False
        Me.gb_ultimo_registro.Text = "Ultimo Registro"
        '
        'lbl_tit_serie
        '
        Me.lbl_tit_serie.AutoSize = True
        Me.lbl_tit_serie.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_serie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_serie.Location = New System.Drawing.Point(10, 121)
        Me.lbl_tit_serie.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_serie.Name = "lbl_tit_serie"
        Me.lbl_tit_serie.Size = New System.Drawing.Size(114, 36)
        Me.lbl_tit_serie.TabIndex = 25
        Me.lbl_tit_serie.Text = "No Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(37, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 75)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "eDashboard"
        '
        'gb_downtime
        '
        Me.gb_downtime.BackColor = System.Drawing.Color.Transparent
        Me.gb_downtime.Controls.Add(Me.lbl_downtime_daily)
        Me.gb_downtime.Controls.Add(Me.lbl_downtime_actual)
        Me.gb_downtime.Controls.Add(Me.lbl_tit_acumulado)
        Me.gb_downtime.Controls.Add(Me.lbl_tit_actual)
        Me.gb_downtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_downtime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_downtime.Location = New System.Drawing.Point(14, 447)
        Me.gb_downtime.Margin = New System.Windows.Forms.Padding(5)
        Me.gb_downtime.Name = "gb_downtime"
        Me.gb_downtime.Padding = New System.Windows.Forms.Padding(5)
        Me.gb_downtime.Size = New System.Drawing.Size(500, 187)
        Me.gb_downtime.TabIndex = 28
        Me.gb_downtime.TabStop = False
        Me.gb_downtime.Text = "Tiempo Caido"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 644)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'lbl_reloj
        '
        Me.lbl_reloj.AutoSize = True
        Me.lbl_reloj.BackColor = System.Drawing.Color.Transparent
        Me.lbl_reloj.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reloj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_reloj.Location = New System.Drawing.Point(412, 649)
        Me.lbl_reloj.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_reloj.Name = "lbl_reloj"
        Me.lbl_reloj.Size = New System.Drawing.Size(261, 78)
        Me.lbl_reloj.TabIndex = 30
        Me.lbl_reloj.Text = "00:00:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(477, 1018)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 36)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Hora Actual"
        '
        'tmr_segundo
        '
        Me.tmr_segundo.Interval = 1000
        '
        'gb_proceso
        '
        Me.gb_proceso.BackColor = System.Drawing.Color.Transparent
        Me.gb_proceso.Controls.Add(Me.lbl_takt_time)
        Me.gb_proceso.Controls.Add(Me.lbl_tit_meta)
        Me.gb_proceso.Controls.Add(Me.pb_acumulado)
        Me.gb_proceso.Controls.Add(Me.lbl_daily_goal)
        Me.gb_proceso.Controls.Add(Me.lbl_tit_turno_actual)
        Me.gb_proceso.Controls.Add(Me.pb_actual)
        Me.gb_proceso.Controls.Add(Me.lbl_tit_maq_actual)
        Me.gb_proceso.Location = New System.Drawing.Point(14, 129)
        Me.gb_proceso.Margin = New System.Windows.Forms.Padding(5)
        Me.gb_proceso.Name = "gb_proceso"
        Me.gb_proceso.Padding = New System.Windows.Forms.Padding(5)
        Me.gb_proceso.Size = New System.Drawing.Size(332, 308)
        Me.gb_proceso.TabIndex = 29
        Me.gb_proceso.TabStop = False
        Me.gb_proceso.Text = "Proceso"
        '
        'lbl_takt_time
        '
        Me.lbl_takt_time.AutoSize = True
        Me.lbl_takt_time.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_takt_time.Font = New System.Drawing.Font("Calibri", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_takt_time.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_takt_time.Location = New System.Drawing.Point(140, 252)
        Me.lbl_takt_time.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_takt_time.Name = "lbl_takt_time"
        Me.lbl_takt_time.Size = New System.Drawing.Size(56, 44)
        Me.lbl_takt_time.TabIndex = 24
        Me.lbl_takt_time.Text = "00"
        '
        'pb_acumulado
        '
        Me.pb_acumulado.ForeColor = System.Drawing.Color.Lime
        Me.pb_acumulado.Location = New System.Drawing.Point(10, 142)
        Me.pb_acumulado.Margin = New System.Windows.Forms.Padding(5)
        Me.pb_acumulado.Name = "pb_acumulado"
        Me.pb_acumulado.Size = New System.Drawing.Size(315, 48)
        Me.pb_acumulado.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb_acumulado.TabIndex = 22
        '
        'lbl_tit_turno_actual
        '
        Me.lbl_tit_turno_actual.AutoSize = True
        Me.lbl_tit_turno_actual.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_turno_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_turno_actual.Location = New System.Drawing.Point(89, 101)
        Me.lbl_tit_turno_actual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_turno_actual.Name = "lbl_tit_turno_actual"
        Me.lbl_tit_turno_actual.Size = New System.Drawing.Size(164, 36)
        Me.lbl_tit_turno_actual.TabIndex = 15
        Me.lbl_tit_turno_actual.Text = "Turno Actual"
        '
        'pb_actual
        '
        Me.pb_actual.ForeColor = System.Drawing.Color.Lime
        Me.pb_actual.Location = New System.Drawing.Point(10, 250)
        Me.pb_actual.Margin = New System.Windows.Forms.Padding(5)
        Me.pb_actual.Name = "pb_actual"
        Me.pb_actual.Size = New System.Drawing.Size(315, 48)
        Me.pb_actual.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb_actual.TabIndex = 23
        '
        'lbl_tit_maq_actual
        '
        Me.lbl_tit_maq_actual.AutoSize = True
        Me.lbl_tit_maq_actual.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_maq_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_maq_actual.Location = New System.Drawing.Point(26, 209)
        Me.lbl_tit_maq_actual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_maq_actual.Name = "lbl_tit_maq_actual"
        Me.lbl_tit_maq_actual.Size = New System.Drawing.Size(274, 36)
        Me.lbl_tit_maq_actual.TabIndex = 16
        Me.lbl_tit_maq_actual.Text = "Maquina Actual - Takt"
        '
        'lbl_tit_hora_actual
        '
        Me.lbl_tit_hora_actual.AutoSize = True
        Me.lbl_tit_hora_actual.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tit_hora_actual.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_hora_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_hora_actual.Location = New System.Drawing.Point(233, 670)
        Me.lbl_tit_hora_actual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_hora_actual.Name = "lbl_tit_hora_actual"
        Me.lbl_tit_hora_actual.Size = New System.Drawing.Size(153, 36)
        Me.lbl_tit_hora_actual.TabIndex = 17
        Me.lbl_tit_hora_actual.Text = "Hora Actual"
        '
        'tmr_semaforo
        '
        Me.tmr_semaforo.Interval = 500
        '
        'tmr_consultas
        '
        Me.tmr_consultas.Interval = 600000
        '
        'mnu_opciones
        '
        Me.mnu_opciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Idioma, Me.IdiomaToolStripMenuItem, Me.CadenaToolStripMenuItem})
        Me.mnu_opciones.Name = "mnu_opciones"
        Me.mnu_opciones.Size = New System.Drawing.Size(182, 75)
        '
        'Idioma
        '
        Me.Idioma.Name = "Idioma"
        Me.Idioma.Size = New System.Drawing.Size(121, 23)
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        Me.IdiomaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.IdiomaToolStripMenuItem.Text = "Idioma"
        '
        'CadenaToolStripMenuItem
        '
        Me.CadenaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TuruRuToolStripMenuItem, Me.RurururuTaToolStripMenuItem})
        Me.CadenaToolStripMenuItem.Name = "CadenaToolStripMenuItem"
        Me.CadenaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CadenaToolStripMenuItem.Text = "Cadena"
        '
        'TuruRuToolStripMenuItem
        '
        Me.TuruRuToolStripMenuItem.Name = "TuruRuToolStripMenuItem"
        Me.TuruRuToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TuruRuToolStripMenuItem.Text = "turu ru"
        '
        'RurururuTaToolStripMenuItem
        '
        Me.RurururuTaToolStripMenuItem.Name = "RurururuTaToolStripMenuItem"
        Me.RurururuTaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.RurururuTaToolStripMenuItem.Text = "rurururu ta"
        '
        'shift
        '
        Me.shift.Enabled = True
        Me.shift.Interval = 60000
        '
        'lbl_tit_rev
        '
        Me.lbl_tit_rev.AutoSize = True
        Me.lbl_tit_rev.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tit_rev.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_rev.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tit_rev.Location = New System.Drawing.Point(848, 14)
        Me.lbl_tit_rev.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_tit_rev.Name = "lbl_tit_rev"
        Me.lbl_tit_rev.Size = New System.Drawing.Size(45, 26)
        Me.lbl_tit_rev.TabIndex = 26
        Me.lbl_tit_rev.Text = "Rev."
        '
        'lbl_rev
        '
        Me.lbl_rev.AutoSize = True
        Me.lbl_rev.BackColor = System.Drawing.Color.Transparent
        Me.lbl_rev.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rev.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_rev.Location = New System.Drawing.Point(903, 14)
        Me.lbl_rev.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_rev.Name = "lbl_rev"
        Me.lbl_rev.Size = New System.Drawing.Size(45, 26)
        Me.lbl_rev.TabIndex = 32
        Me.lbl_rev.Text = "000"
        '
        'pantalla_produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.lbl_rev)
        Me.Controls.Add(Me.lbl_tit_rev)
        Me.Controls.Add(Me.lbl_tit_hora_actual)
        Me.Controls.Add(Me.gb_proceso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_reloj)
        Me.Controls.Add(Me.gb_ultimo_registro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gb_downtime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gb_objetivo)
        Me.Controls.Add(Me.lbl_tit_empleados)
        Me.Controls.Add(Me.lbl_empleados)
        Me.Controls.Add(Me.lbl_linea)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "pantalla_produccion"
        Me.Text = "eDashboard"
        Me.gb_objetivo.ResumeLayout(False)
        Me.gb_objetivo.PerformLayout()
        Me.gb_ultimo_registro.ResumeLayout(False)
        Me.gb_ultimo_registro.PerformLayout()
        Me.gb_downtime.ResumeLayout(False)
        Me.gb_downtime.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_proceso.ResumeLayout(False)
        Me.gb_proceso.PerformLayout()
        Me.mnu_opciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_linea As System.Windows.Forms.Label
    Friend WithEvents lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents lbl_empleados As System.Windows.Forms.Label
    Friend WithEvents lbl_downtime_daily As System.Windows.Forms.Label
    Friend WithEvents lbl_downtime_actual As System.Windows.Forms.Label
    Friend WithEvents lbl_daily_goal As System.Windows.Forms.Label
    Friend WithEvents lbl_meta_actual As System.Windows.Forms.Label
    Friend WithEvents lbl_actual As System.Windows.Forms.Label
    Friend WithEvents lbl_last_serial As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_hora As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_real As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_plan As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_meta As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_actual As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_acumulado As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_empleados As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_modelo As System.Windows.Forms.Label
    Friend WithEvents lbl_last_update As System.Windows.Forms.Label
    Friend WithEvents gb_objetivo As System.Windows.Forms.GroupBox
    Friend WithEvents gb_ultimo_registro As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_tit_serie As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gb_downtime As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_reloj As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tmr_segundo As System.Windows.Forms.Timer
    Friend WithEvents gb_proceso As System.Windows.Forms.GroupBox
    Friend WithEvents pb_acumulado As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_tit_turno_actual As System.Windows.Forms.Label
    Friend WithEvents pb_actual As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_tit_maq_actual As System.Windows.Forms.Label
    Friend WithEvents lbl_tit_hora_actual As System.Windows.Forms.Label
    Friend WithEvents tmr_semaforo As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tmr_consultas As System.Windows.Forms.Timer
    Friend WithEvents mnu_opciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Idioma As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents IdiomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadenaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TuruRuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RurururuTaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_takt_time As System.Windows.Forms.Label
    Friend WithEvents shift As System.Windows.Forms.Timer
    Friend WithEvents lbl_tit_rev As System.Windows.Forms.Label
    Friend WithEvents lbl_rev As System.Windows.Forms.Label

End Class
