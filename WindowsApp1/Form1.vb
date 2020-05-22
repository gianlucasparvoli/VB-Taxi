Public Class FormMenuSecundario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Btn_nuevoviaje_Click(sender As Object, e As EventArgs) Handles btn_nuevoviaje.Click
        FormNuevoViaje.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub
End Class
