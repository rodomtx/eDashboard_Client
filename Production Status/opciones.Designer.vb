<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_opciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_opciones))
        Me.btn_guardar_cambios = New System.Windows.Forms.Button()
        Me.btn_cancel_cambios = New System.Windows.Forms.Button()
        Me.cmb_idiomas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_path_takt_time_sound = New System.Windows.Forms.Button()
        Me.btn_path_pre_takt_time_sound = New System.Windows.Forms.Button()
        Me.picb_takt_time = New System.Windows.Forms.PictureBox()
        Me.picb_pre_takt_time = New System.Windows.Forms.PictureBox()
        Me.tb_takt_time_sound = New System.Windows.Forms.TextBox()
        Me.tb_pre_takt_time_sound = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_minutos = New System.Windows.Forms.ComboBox()
        Me.lbl_tit_pc_prett = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_areas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_tit_idioma = New System.Windows.Forms.Label()
        Me.OPFD_pre_takt_time_sound = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picb_takt_time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picb_pre_takt_time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_guardar_cambios
        '
        Me.btn_guardar_cambios.Location = New System.Drawing.Point(102, 247)
        Me.btn_guardar_cambios.Name = "btn_guardar_cambios"
        Me.btn_guardar_cambios.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar_cambios.TabIndex = 0
        Me.btn_guardar_cambios.Text = "Guardar"
        Me.btn_guardar_cambios.UseVisualStyleBackColor = True
        '
        'btn_cancel_cambios
        '
        Me.btn_cancel_cambios.Location = New System.Drawing.Point(202, 247)
        Me.btn_cancel_cambios.Name = "btn_cancel_cambios"
        Me.btn_cancel_cambios.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel_cambios.TabIndex = 1
        Me.btn_cancel_cambios.Text = "Cancelar"
        Me.btn_cancel_cambios.UseVisualStyleBackColor = True
        '
        'cmb_idiomas
        '
        Me.cmb_idiomas.FormattingEnabled = True
        Me.cmb_idiomas.Location = New System.Drawing.Point(190, 23)
        Me.cmb_idiomas.Name = "cmb_idiomas"
        Me.cmb_idiomas.Size = New System.Drawing.Size(121, 21)
        Me.cmb_idiomas.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_path_takt_time_sound)
        Me.GroupBox1.Controls.Add(Me.btn_path_pre_takt_time_sound)
        Me.GroupBox1.Controls.Add(Me.picb_takt_time)
        Me.GroupBox1.Controls.Add(Me.picb_pre_takt_time)
        Me.GroupBox1.Controls.Add(Me.tb_takt_time_sound)
        Me.GroupBox1.Controls.Add(Me.tb_pre_takt_time_sound)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_minutos)
        Me.GroupBox1.Controls.Add(Me.lbl_tit_pc_prett)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_areas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_tit_idioma)
        Me.GroupBox1.Controls.Add(Me.cmb_idiomas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 216)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuraciones Regionales"
        '
        'btn_path_takt_time_sound
        '
        Me.btn_path_takt_time_sound.Location = New System.Drawing.Point(315, 159)
        Me.btn_path_takt_time_sound.Name = "btn_path_takt_time_sound"
        Me.btn_path_takt_time_sound.Size = New System.Drawing.Size(30, 21)
        Me.btn_path_takt_time_sound.TabIndex = 18
        Me.btn_path_takt_time_sound.Text = "..."
        Me.btn_path_takt_time_sound.UseVisualStyleBackColor = True
        '
        'btn_path_pre_takt_time_sound
        '
        Me.btn_path_pre_takt_time_sound.Location = New System.Drawing.Point(315, 122)
        Me.btn_path_pre_takt_time_sound.Name = "btn_path_pre_takt_time_sound"
        Me.btn_path_pre_takt_time_sound.Size = New System.Drawing.Size(30, 21)
        Me.btn_path_pre_takt_time_sound.TabIndex = 17
        Me.btn_path_pre_takt_time_sound.Text = "..."
        Me.btn_path_pre_takt_time_sound.UseVisualStyleBackColor = True
        '
        'picb_takt_time
        '
        Me.picb_takt_time.Image = CType(resources.GetObject("picb_takt_time.Image"), System.Drawing.Image)
        Me.picb_takt_time.Location = New System.Drawing.Point(345, 162)
        Me.picb_takt_time.Name = "picb_takt_time"
        Me.picb_takt_time.Size = New System.Drawing.Size(22, 17)
        Me.picb_takt_time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picb_takt_time.TabIndex = 16
        Me.picb_takt_time.TabStop = False
        '
        'picb_pre_takt_time
        '
        Me.picb_pre_takt_time.Image = CType(resources.GetObject("picb_pre_takt_time.Image"), System.Drawing.Image)
        Me.picb_pre_takt_time.Location = New System.Drawing.Point(346, 125)
        Me.picb_pre_takt_time.Name = "picb_pre_takt_time"
        Me.picb_pre_takt_time.Size = New System.Drawing.Size(22, 17)
        Me.picb_pre_takt_time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picb_pre_takt_time.TabIndex = 15
        Me.picb_pre_takt_time.TabStop = False
        '
        'tb_takt_time_sound
        '
        Me.tb_takt_time_sound.Location = New System.Drawing.Point(190, 159)
        Me.tb_takt_time_sound.Name = "tb_takt_time_sound"
        Me.tb_takt_time_sound.Size = New System.Drawing.Size(121, 20)
        Me.tb_takt_time_sound.TabIndex = 14
        '
        'tb_pre_takt_time_sound
        '
        Me.tb_pre_takt_time_sound.Location = New System.Drawing.Point(190, 122)
        Me.tb_pre_takt_time_sound.Name = "tb_pre_takt_time_sound"
        Me.tb_pre_takt_time_sound.Size = New System.Drawing.Size(121, 20)
        Me.tb_pre_takt_time_sound.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sonido Takt Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sonido Pre Takt TIme"
        '
        'cmb_minutos
        '
        Me.cmb_minutos.FormattingEnabled = True
        Me.cmb_minutos.Location = New System.Drawing.Point(190, 91)
        Me.cmb_minutos.Name = "cmb_minutos"
        Me.cmb_minutos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_minutos.TabIndex = 9
        '
        'lbl_tit_pc_prett
        '
        Me.lbl_tit_pc_prett.AutoSize = True
        Me.lbl_tit_pc_prett.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_pc_prett.Location = New System.Drawing.Point(55, 94)
        Me.lbl_tit_pc_prett.Name = "lbl_tit_pc_prett"
        Me.lbl_tit_pc_prett.Size = New System.Drawing.Size(129, 18)
        Me.lbl_tit_pc_prett.TabIndex = 8
        Me.lbl_tit_pc_prett.Text = "Mins. Pre Takt Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Area"
        '
        'cmb_areas
        '
        Me.cmb_areas.FormattingEnabled = True
        Me.cmb_areas.Location = New System.Drawing.Point(190, 55)
        Me.cmb_areas.Name = "cmb_areas"
        Me.cmb_areas.Size = New System.Drawing.Size(121, 21)
        Me.cmb_areas.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Area"
        '
        'lbl_tit_idioma
        '
        Me.lbl_tit_idioma.AutoSize = True
        Me.lbl_tit_idioma.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit_idioma.Location = New System.Drawing.Point(133, 26)
        Me.lbl_tit_idioma.Name = "lbl_tit_idioma"
        Me.lbl_tit_idioma.Size = New System.Drawing.Size(51, 18)
        Me.lbl_tit_idioma.TabIndex = 3
        Me.lbl_tit_idioma.Text = "Idioma"
        '
        'frm_opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 295)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancel_cambios)
        Me.Controls.Add(Me.btn_guardar_cambios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_opciones"
        Me.Text = "Opciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picb_takt_time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picb_pre_takt_time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_guardar_cambios As System.Windows.Forms.Button
    Friend WithEvents btn_cancel_cambios As System.Windows.Forms.Button
    Friend WithEvents cmb_idiomas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_tit_idioma As System.Windows.Forms.Label
    Friend WithEvents cmb_areas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_minutos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tit_pc_prett As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_takt_time_sound As System.Windows.Forms.TextBox
    Friend WithEvents tb_pre_takt_time_sound As System.Windows.Forms.TextBox
    Friend WithEvents picb_takt_time As System.Windows.Forms.PictureBox
    Friend WithEvents picb_pre_takt_time As System.Windows.Forms.PictureBox
    Friend WithEvents btn_path_takt_time_sound As System.Windows.Forms.Button
    Friend WithEvents btn_path_pre_takt_time_sound As System.Windows.Forms.Button
    Friend WithEvents OPFD_pre_takt_time_sound As System.Windows.Forms.OpenFileDialog
End Class
