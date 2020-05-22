<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
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
        Me.lbl_menuprincial = New System.Windows.Forms.Label()
        Me.lbl_Remiseria = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_menuprincial
        '
        Me.lbl_menuprincial.AutoSize = True
        Me.lbl_menuprincial.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menuprincial.Location = New System.Drawing.Point(12, 9)
        Me.lbl_menuprincial.Name = "lbl_menuprincial"
        Me.lbl_menuprincial.Size = New System.Drawing.Size(200, 26)
        Me.lbl_menuprincial.TabIndex = 0
        Me.lbl_menuprincial.Text = "MENU PRINCIPAL"
        '
        'lbl_Remiseria
        '
        Me.lbl_Remiseria.AutoSize = True
        Me.lbl_Remiseria.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remiseria.Location = New System.Drawing.Point(48, 56)
        Me.lbl_Remiseria.Name = "lbl_Remiseria"
        Me.lbl_Remiseria.Size = New System.Drawing.Size(111, 26)
        Me.lbl_Remiseria.TabIndex = 1
        Me.lbl_Remiseria.Text = "Remiseria"
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 198)
        Me.Controls.Add(Me.lbl_Remiseria)
        Me.Controls.Add(Me.lbl_menuprincial)
        Me.Name = "FormMenuPrincipal"
        Me.Text = "Bienvenido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menuprincial As Label
    Friend WithEvents lbl_Remiseria As Label
End Class
