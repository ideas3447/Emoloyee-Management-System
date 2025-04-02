Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Salary

    Private ReadOnly con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rapha\Documents\EMS.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Fetchemp()
        Try
            ' Check if Eid is empty
            If String.IsNullOrWhiteSpace(Eid.Text) Then
                MessageBox.Show("Please enter an Employee ID.")
                Return
            End If

            con.Open()
            Dim query As String = "SELECT * FROM ETBL WHERE EmpId = @EmpId"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@EmpId", Eid.Text)

            Dim dt As New DataTable()
            Dim sda As New SqlDataAdapter(cmd)
            sda.Fill(dt)

            ' Check if any records were returned
            If dt.Rows.Count > 0 Then
                Dim dr As DataRow = dt.Rows(0) ' Get the first row
                En.Text = dr("EmpName").ToString()
                Ep.Text = dr("EmpPos").ToString()
            Else
                MessageBox.Show("No employee found with the specified ID.")
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles En.TextChanged

    End Sub

    Private Sub CrossBtn_Click(sender As Object, e As EventArgs) Handles CrossBtn.Click
        Me.Close()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' Create a new instance of the Home form
        Dim h As New Home()

        ' Show the Home form
        h.Show()

        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        ' Check if the employee position is selected
        If String.IsNullOrWhiteSpace(Ep.Text) Then
            MessageBox.Show("Select An Employee")
            Return
        End If

        ' Check if the number of days is valid
        Dim days As Integer
        If Not Integer.TryParse(Wd.Text, days) OrElse days < 1 OrElse days > 28 Then
            MessageBox.Show("Enter A Valid number of Days (1-28)")
            Return
        End If

        ' Determine the daily base salary based on the employee position
        Dim dailyBase As Decimal
        If Ep.Text.Trim() = "Manager" Then
            dailyBase = 1200
        ElseIf Ep.Text.Trim() = "Senior Developer" Then
            dailyBase = 1000
        ElseIf Ep.Text.Trim() = "Junior Developer" Then
            dailyBase = 950
        ElseIf Ep.Text.Trim() = "IT Personel" Then
            dailyBase = 1100
        ElseIf Ep.Text.Trim() = "Accountant" Then
            dailyBase = 920
        ElseIf Ep.Text.Trim() = "Director" Then
            dailyBase = 1500
        ElseIf Ep.Text.Trim() = "Marketing Direcor" Then
            dailyBase = 1500
        ElseIf Ep.Text.Trim() = "Secretary" Then
            dailyBase = 1000

        Else
            MessageBox.Show("Unknown employee position.")
            Return
        End If

        ' Calculate the total salary
        Dim total As Decimal = dailyBase * days

        ' Display the information in the RichTextBox
        SS.Text = "Employee ID: " & Eid.Text & Environment.NewLine &
              "Employee Name: " & En.Text & Environment.NewLine &
              "Employee Position: " & Ep.Text & Environment.NewLine &
              "Daily Salary: " & dailyBase.ToString("C") & Environment.NewLine &
              "Total Amount: " & total.ToString("C")
    End Sub


    Private Sub FetchdataBtn_Click(sender As Object, e As EventArgs) Handles FetchdataBtn.Click
        Fetchemp()
    End Sub
End Class