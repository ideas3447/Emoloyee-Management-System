Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class view

    ' Connection string to your database
    Private ReadOnly con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rapha\Documents\EMS.mdf;Integrated Security=True;Connect Timeout=30")

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Method to fetch employee details
    Private Sub Fetchemp()
        Try
            ' Check if EmpId is provided
            If String.IsNullOrWhiteSpace(TextBox1.Text) Then
                MessageBox.Show("Please enter an Employee ID.")
                Return
            End If

            ' Open the connection
            con.Open()

            ' Use parameterized query to prevent SQL injection
            Dim query As String = "SELECT * FROM ETBL WHERE EmpId = @EmpId"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@EmpId", TextBox1.Text.Trim()) ' Add parameter for EmpId

            ' Execute the query and use a SqlDataReader to read the results
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then ' Check if there is at least one record
                    Lbl1.Text = reader("EmpId").ToString()
                    Lbl2.Text = reader("EmpName").ToString()
                    Lbl3.Text = reader("EmpGen").ToString()
                    Lbl4.Text = reader("EmpAdd").ToString()
                    Lbl5.Text = reader("EmpPos").ToString()
                    Lbl6.Text = reader("EmpDob").ToString()
                    Lbl7.Text = reader("EmpPhone").ToString()
                    Lbl8.Text = reader("EmpEdu").ToString()

                    Lbl1.Visible = True
                    Lbl2.Visible = True
                    Lbl3.Visible = True
                    Lbl4.Visible = True
                    Lbl5.Visible = True
                    Lbl6.Visible = True
                    Lbl7.Visible = True
                    Lbl8.Visible = True
                Else
                    MessageBox.Show("No employee found with the specified ID.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Fetch_Click(sender As Object, e As EventArgs) Handles FetchBtn.Click
        Fetchemp()
    End Sub

    Private Sub CrossBtn_Click(sender As Object, e As EventArgs) Handles CrossBtn.Click
        Me.Close()
    End Sub

    Private Sub view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can initialize any components or load data here if needed
    End Sub

    ' Assuming your home form is named "HomeForm"
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' Create an instance of the home form
        Dim home As New Home()

        ' Show the home form
        home.Show()

        ' Close the current view form
        Me.Close()
    End Sub
End Class