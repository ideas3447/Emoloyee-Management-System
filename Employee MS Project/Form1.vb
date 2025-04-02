Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Logging

Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar.Click

    End Sub

    Private Sub Slapsh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(1)
        If ProgressBar.Value >= ProgressBar.Maximum Then
            ' Stop the Timer
            Timer1.Stop()

            ' Hide the current form
            Me.Hide()

            ' Create and show the Login form
            Dim log As New Login()
            log.Show()
        End If
    End Sub
End Class
