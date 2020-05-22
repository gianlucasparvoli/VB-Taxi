Public Class FormMenuPrincipal
    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub FormMenuPrincipal_Click(sender As Object, e As EventArgs) Handles Me.Click
        FormMenuSecundario.Show()
        Me.Hide()
    End Sub
End Class