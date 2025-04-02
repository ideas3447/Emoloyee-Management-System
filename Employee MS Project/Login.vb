Public Class Login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CrossBtn_Click(sender As Object, e As EventArgs) Handles CrossBtn.Click
        Me.Close()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Admin.Text = ""
        Password.Text = ""
    End Sub

    Private Sub Admin_TextChanged(sender As Object, e As EventArgs) Handles Admin.TextChanged

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        ' Check if either Admin or Password fields are empty
        If (Admin.Text = "" OrElse Password.Text = "") Then

        ElseIf (Admin.Text = "Admin" AndAlso Password.Text = "Password") Then
            ' Create a new instance of the Home form and show it
            Dim home As New Home()
            home.Show()
            Me.Hide() ' Hide the current form
        Else
            ' Show an error message for wrong credentials
            MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class