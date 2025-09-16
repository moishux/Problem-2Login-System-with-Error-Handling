Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtUser.Text = "" Then
            lblMessage.Text = "Username cannot be empty."
        ElseIf txtPass.Text = "" Then
            lblMessage.Text = "Password cannot be empty."
        Else
            lblMessage.Text = "Login successful!"
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
