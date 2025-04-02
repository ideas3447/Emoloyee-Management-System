Imports System.Runtime.CompilerServices

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrossBtn_Click(sender As Object, e As EventArgs) Handles CrossBtn.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim login As New Login()
        login.Show()
        Me.Hide()


    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs)
        Dim loginForm As New Login()

        ' Show the Login form
        loginForm.Show()

        ' Hide the current form (the one with the logout button)
        Me.Hide()
    End Sub

    Private Sub EmployeeBtn_Click(sender As Object, e As EventArgs) Handles EmployeeBtn.Click
        ' Create a new instance of the Employee form
        Dim obj As New Employee()

        ' Show the Employee form
        obj.Show()

        ' Optionally, hide the current form (HomeForm)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create a new instance of the Employee form
        Dim obj As New view()

        ' Show the Employee form
        obj.Show()

        ' Optionally, hide the current form (HomeForm)
        Me.Hide()
    End Sub

    Private Sub SalaryBtn_Click(sender As Object, e As EventArgs) Handles SalaryBtn.Click
        Dim Sa As New Salary
        Sa.Show()
        Me.Hide()
    End Sub
End Class