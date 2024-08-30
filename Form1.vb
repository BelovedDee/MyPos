Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter UserName and Passord")
        ElseIf txtUsername.Text = "Admin" And txtPassword.Text = "1234" Then
            Dim obj = New frmHome()
            Me.Hide()
            obj.Show()

        Else
            MsgBox("Wrong UserName or Passord")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub lblReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblReset.LinkClicked
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub
End Class
