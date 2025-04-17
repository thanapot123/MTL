Public Class NG_form
    Private Sub NG_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class