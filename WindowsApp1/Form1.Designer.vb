<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuSecundario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_nuevoviaje = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_nuevoviaje
        '
        Me.btn_nuevoviaje.Location = New System.Drawing.Point(12, 39)
        Me.btn_nuevoviaje.Name = "btn_nuevoviaje"
        Me.btn_nuevoviaje.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevoviaje.TabIndex = 0
        Me.btn_nuevoviaje.Text = "Nuevo Viaje"
        Me.btn_nuevoviaje.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(117, 39)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'FormMenuSecundario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 80)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevoviaje)
        Me.Name = "FormMenuSecundario"
        Me.Text = "Seleccione"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_nuevoviaje As Button
    Friend WithEvents btn_salir As Button
End Class
