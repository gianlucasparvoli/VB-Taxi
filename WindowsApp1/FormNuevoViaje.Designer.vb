<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNuevoViaje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label_idremisero = New System.Windows.Forms.Label()
        Me.cmb_idremisero = New System.Windows.Forms.ComboBox()
        Me.label_idpasajero = New System.Windows.Forms.Label()
        Me.cmb_idpasajero = New System.Windows.Forms.ComboBox()
        Me.label_FechaViaje = New System.Windows.Forms.Label()
        Me.dtp_fechaviaje = New System.Windows.Forms.DateTimePicker()
        Me.label_Direccionorigen = New System.Windows.Forms.Label()
        Me.txt_direccionorigen = New System.Windows.Forms.TextBox()
        Me.txt_direcciondestino = New System.Windows.Forms.TextBox()
        Me.lbl_direcciondestino = New System.Windows.Forms.Label()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.label_tipodeservicio = New System.Windows.Forms.Label()
        Me.rb_ejecutivo = New System.Windows.Forms.RadioButton()
        Me.rb_exclusivo = New System.Windows.Forms.RadioButton()
        Me.rb_compartido = New System.Windows.Forms.RadioButton()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.cb_anulado = New System.Windows.Forms.CheckBox()
        Me.label_anulado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label_idremisero
        '
        Me.label_idremisero.AutoSize = True
        Me.label_idremisero.Location = New System.Drawing.Point(14, 25)
        Me.label_idremisero.Name = "label_idremisero"
        Me.label_idremisero.Size = New System.Drawing.Size(62, 13)
        Me.label_idremisero.TabIndex = 0
        Me.label_idremisero.Text = "IDRemisero"
        '
        'cmb_idremisero
        '
        Me.cmb_idremisero.FormattingEnabled = True
        Me.cmb_idremisero.Location = New System.Drawing.Point(116, 22)
        Me.cmb_idremisero.Name = "cmb_idremisero"
        Me.cmb_idremisero.Size = New System.Drawing.Size(200, 21)
        Me.cmb_idremisero.TabIndex = 1
        '
        'label_idpasajero
        '
        Me.label_idpasajero.AutoSize = True
        Me.label_idpasajero.Location = New System.Drawing.Point(17, 52)
        Me.label_idpasajero.Name = "label_idpasajero"
        Me.label_idpasajero.Size = New System.Drawing.Size(59, 13)
        Me.label_idpasajero.TabIndex = 2
        Me.label_idpasajero.Text = "IDPasajero"
        '
        'cmb_idpasajero
        '
        Me.cmb_idpasajero.FormattingEnabled = True
        Me.cmb_idpasajero.Location = New System.Drawing.Point(116, 49)
        Me.cmb_idpasajero.Name = "cmb_idpasajero"
        Me.cmb_idpasajero.Size = New System.Drawing.Size(200, 21)
        Me.cmb_idpasajero.TabIndex = 3
        '
        'label_FechaViaje
        '
        Me.label_FechaViaje.AutoSize = True
        Me.label_FechaViaje.Location = New System.Drawing.Point(20, 76)
        Me.label_FechaViaje.Name = "label_FechaViaje"
        Me.label_FechaViaje.Size = New System.Drawing.Size(60, 13)
        Me.label_FechaViaje.TabIndex = 4
        Me.label_FechaViaje.Text = "FechaViaje"
        '
        'dtp_fechaviaje
        '
        Me.dtp_fechaviaje.Location = New System.Drawing.Point(116, 76)
        Me.dtp_fechaviaje.Name = "dtp_fechaviaje"
        Me.dtp_fechaviaje.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fechaviaje.TabIndex = 5
        '
        'label_Direccionorigen
        '
        Me.label_Direccionorigen.AutoSize = True
        Me.label_Direccionorigen.Location = New System.Drawing.Point(20, 105)
        Me.label_Direccionorigen.Name = "label_Direccionorigen"
        Me.label_Direccionorigen.Size = New System.Drawing.Size(83, 13)
        Me.label_Direccionorigen.TabIndex = 6
        Me.label_Direccionorigen.Text = "DireccionOrigen"
        '
        'txt_direccionorigen
        '
        Me.txt_direccionorigen.Location = New System.Drawing.Point(116, 102)
        Me.txt_direccionorigen.Name = "txt_direccionorigen"
        Me.txt_direccionorigen.Size = New System.Drawing.Size(200, 20)
        Me.txt_direccionorigen.TabIndex = 7
        '
        'txt_direcciondestino
        '
        Me.txt_direcciondestino.Location = New System.Drawing.Point(116, 128)
        Me.txt_direcciondestino.Name = "txt_direcciondestino"
        Me.txt_direcciondestino.Size = New System.Drawing.Size(200, 20)
        Me.txt_direcciondestino.TabIndex = 9
        '
        'lbl_direcciondestino
        '
        Me.lbl_direcciondestino.AutoSize = True
        Me.lbl_direcciondestino.Location = New System.Drawing.Point(20, 131)
        Me.lbl_direcciondestino.Name = "lbl_direcciondestino"
        Me.lbl_direcciondestino.Size = New System.Drawing.Size(88, 13)
        Me.lbl_direcciondestino.TabIndex = 8
        Me.lbl_direcciondestino.Text = "DireccionDestino"
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(116, 154)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(200, 20)
        Me.txt_importe.TabIndex = 11
        '
        'lbl_importe
        '
        Me.lbl_importe.AutoSize = True
        Me.lbl_importe.Location = New System.Drawing.Point(20, 157)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(42, 13)
        Me.lbl_importe.TabIndex = 10
        Me.lbl_importe.Text = "Importe"
        '
        'label_tipodeservicio
        '
        Me.label_tipodeservicio.AutoSize = True
        Me.label_tipodeservicio.Location = New System.Drawing.Point(23, 191)
        Me.label_tipodeservicio.Name = "label_tipodeservicio"
        Me.label_tipodeservicio.Size = New System.Drawing.Size(80, 13)
        Me.label_tipodeservicio.TabIndex = 12
        Me.label_tipodeservicio.Text = "TipoDeServicio"
        '
        'rb_ejecutivo
        '
        Me.rb_ejecutivo.AutoSize = True
        Me.rb_ejecutivo.Location = New System.Drawing.Point(116, 191)
        Me.rb_ejecutivo.Name = "rb_ejecutivo"
        Me.rb_ejecutivo.Size = New System.Drawing.Size(69, 17)
        Me.rb_ejecutivo.TabIndex = 13
        Me.rb_ejecutivo.TabStop = True
        Me.rb_ejecutivo.Text = "Ejecutivo"
        Me.rb_ejecutivo.UseVisualStyleBackColor = True
        '
        'rb_exclusivo
        '
        Me.rb_exclusivo.AutoSize = True
        Me.rb_exclusivo.Location = New System.Drawing.Point(116, 215)
        Me.rb_exclusivo.Name = "rb_exclusivo"
        Me.rb_exclusivo.Size = New System.Drawing.Size(70, 17)
        Me.rb_exclusivo.TabIndex = 14
        Me.rb_exclusivo.TabStop = True
        Me.rb_exclusivo.Text = "Exclusivo"
        Me.rb_exclusivo.UseVisualStyleBackColor = True
        '
        'rb_compartido
        '
        Me.rb_compartido.AutoSize = True
        Me.rb_compartido.Location = New System.Drawing.Point(116, 239)
        Me.rb_compartido.Name = "rb_compartido"
        Me.rb_compartido.Size = New System.Drawing.Size(78, 17)
        Me.rb_compartido.TabIndex = 15
        Me.rb_compartido.TabStop = True
        Me.rb_compartido.Text = "Compartido"
        Me.rb_compartido.UseVisualStyleBackColor = True
        '
        'btn_Registrar
        '
        Me.btn_Registrar.Location = New System.Drawing.Point(26, 331)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(293, 23)
        Me.btn_Registrar.TabIndex = 16
        Me.btn_Registrar.Text = "Registrar"
        Me.btn_Registrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(26, 360)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(293, 23)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'cb_anulado
        '
        Me.cb_anulado.AutoSize = True
        Me.cb_anulado.Location = New System.Drawing.Point(116, 292)
        Me.cb_anulado.Name = "cb_anulado"
        Me.cb_anulado.Size = New System.Drawing.Size(15, 14)
        Me.cb_anulado.TabIndex = 18
        Me.cb_anulado.UseVisualStyleBackColor = True
        '
        'label_anulado
        '
        Me.label_anulado.AutoSize = True
        Me.label_anulado.Location = New System.Drawing.Point(26, 292)
        Me.label_anulado.Name = "label_anulado"
        Me.label_anulado.Size = New System.Drawing.Size(46, 13)
        Me.label_anulado.TabIndex = 19
        Me.label_anulado.Text = "Anulado"
        '
        'FormNuevoViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 390)
        Me.Controls.Add(Me.label_anulado)
        Me.Controls.Add(Me.cb_anulado)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_Registrar)
        Me.Controls.Add(Me.rb_compartido)
        Me.Controls.Add(Me.rb_exclusivo)
        Me.Controls.Add(Me.rb_ejecutivo)
        Me.Controls.Add(Me.label_tipodeservicio)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.lbl_importe)
        Me.Controls.Add(Me.txt_direcciondestino)
        Me.Controls.Add(Me.lbl_direcciondestino)
        Me.Controls.Add(Me.txt_direccionorigen)
        Me.Controls.Add(Me.label_Direccionorigen)
        Me.Controls.Add(Me.dtp_fechaviaje)
        Me.Controls.Add(Me.label_FechaViaje)
        Me.Controls.Add(Me.cmb_idpasajero)
        Me.Controls.Add(Me.label_idpasajero)
        Me.Controls.Add(Me.cmb_idremisero)
        Me.Controls.Add(Me.label_idremisero)
        Me.Name = "FormNuevoViaje"
        Me.Text = "Nuevo Viaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_idremisero As Label
    Friend WithEvents cmb_idremisero As ComboBox
    Friend WithEvents label_idpasajero As Label
    Friend WithEvents cmb_idpasajero As ComboBox
    Friend WithEvents label_FechaViaje As Label
    Friend WithEvents dtp_fechaviaje As DateTimePicker
    Friend WithEvents label_Direccionorigen As Label
    Friend WithEvents txt_direccionorigen As TextBox
    Friend WithEvents txt_direcciondestino As TextBox
    Friend WithEvents lbl_direcciondestino As Label
    Friend WithEvents txt_importe As TextBox
    Friend WithEvents lbl_importe As Label
    Friend WithEvents label_tipodeservicio As Label
    Friend WithEvents rb_ejecutivo As RadioButton
    Friend WithEvents rb_exclusivo As RadioButton
    Friend WithEvents rb_compartido As RadioButton
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents cb_anulado As CheckBox
    Friend WithEvents label_anulado As Label
End Class
