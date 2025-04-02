Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Employee
    ' Connection string to your database
    Private ReadOnly con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rapha\Documents\EMS.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form loads
        DisplayEmp()
    End Sub

    Private Sub DisplayEmp()
        Try
            con.Open() ' Open the connection
            Dim cmd As New SqlCommand("SELECT * FROM ETBL", con) ' Adjust the query as needed
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(reader) ' Load data into the DataTable

            DataGridView1.DataSource = dt ' Bind the DataTable to the DataGridView
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Sub


    Private Sub LoadData()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle cell content click event here if needed
    End Sub

    Private Sub CrossBtn_Click(sender As Object, e As EventArgs) Handles CrossBtn.Click
        Me.Close() ' Close the current form
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' Create a new instance of the Home form
        Dim h As New Home()

        ' Show the Home form
        h.Show()

        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ' Check if all required fields are filled
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or
       String.IsNullOrWhiteSpace(TextBox2.Text) Or
       String.IsNullOrWhiteSpace(TextBox3.Text) Or
       String.IsNullOrWhiteSpace(TextBox4.Text) Or
       ComboBox1.SelectedItem Is Nothing Or
       ComboBox2.SelectedItem Is Nothing Or
       ComboBox4.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.")
            Return ' Exit the method if any field is empty
        End If

        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rapha\Documents\EMS.mdf;Integrated Security=True;Connect Timeout=30")
            Try
                con.Open() ' Open the connection
                Dim query As String = "INSERT INTO dbo.ETBL (EmpId, EmpName, EmpAdd, EmpPhone, EmpDob, EmpEdu, EmpGen, EmpPos) VALUES (@EmpId, @EmpName, @EmpAdd, @EmpPhone, @EmpDob, @EmpEdu, @EmpGen, @EmpPos)"
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.Add("@EmpId", SqlDbType.VarChar).Value = TextBox1.Text ' EmpId is VARCHAR
                    cmd.Parameters.Add("@EmpName", SqlDbType.VarChar).Value = TextBox2.Text
                    cmd.Parameters.Add("@EmpAdd", SqlDbType.VarChar).Value = TextBox3.Text
                    cmd.Parameters.Add("@EmpPhone", SqlDbType.VarChar).Value = TextBox4.Text
                    cmd.Parameters.Add("@EmpDob", SqlDbType.Date).Value = DateTimePicker1.Value ' Use Date type for date fields
                    cmd.Parameters.Add("@EmpEdu", SqlDbType.VarChar).Value = ComboBox2.SelectedItem.ToString()
                    cmd.Parameters.Add("@EmpGen", SqlDbType.VarChar).Value = ComboBox1.SelectedItem.ToString()
                    cmd.Parameters.Add("@EmpPos", SqlDbType.VarChar).Value = ComboBox4.SelectedItem.ToString()

                    ' Execute the command
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the insert was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Record Entered successfully!")
                    Else
                        MessageBox.Show("Failed to enter record.")
                    End If
                End Using ' Automatically closes the SqlCommand
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message) ' Show detailed error message
            End Try ' Ensure the connection is closed automatically
        End Using ' Automatically closes the SqlConnection
    End Sub

    Private Sub DelectBtn_Click(sender As Object, e As EventArgs) Handles DelectBtn.Click

        Try
            ' Check if the ID TextBox is empty
            If TextBox1.Text = "" Then
                MessageBox.Show("Please enter an ID to delete.")
                Return ' Exit the method if the TextBox is empty
            End If

            ' Create a new SqlConnection
            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rapha\Documents\EMS.mdf;Integrated Security=True;Connect Timeout=30")
                con.Open() ' Open the connection

                ' Prepare the SQL command to delete the record
                Dim query As String = "DELETE FROM ETBL WHERE EmpId = @EmpId"
                Using cmd As New SqlCommand(query, con)
                    ' Add the ID parameter
                    cmd.Parameters.AddWithValue("@EmpId", TextBox1.Text)

                    ' Execute the command
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the delete was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Record deleted successfully!")
                    Else
                        MessageBox.Show("No record found with the specified ID.")
                    End If
                End Using ' Automatically closes the SqlCommand
            End Using ' Automatically closes the SqlConnection
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub





    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            ' Check if the ID TextBox and other TextBoxes are empty
            If String.IsNullOrWhiteSpace(TextBox1.Text) Or
           String.IsNullOrWhiteSpace(TextBox2.Text) Or
           String.IsNullOrWhiteSpace(TextBox3.Text) Or
           String.IsNullOrWhiteSpace(TextBox4.Text) Then
                MessageBox.Show("Please fill in all fields.")
                Return ' Exit the method if any TextBox is empty
            End If

            ' Create a new SqlConnection
            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rapha\Documents\EMS.mdf;Integrated Security=True;Connect Timeout=30")
                con.Open() ' Open the connection

                ' Prepare the SQL command to update the record
                Dim query As String = "UPDATE ETBL SET EmpName = @EmpName, EmpAdd = @EmpAdd, EmpPhone = @EmpPhone, EmpDob = @EmpDob, EmpEdu = @EmpEdu, EmpGen = @EmpGen, EmpPos = @EmpPos WHERE EmpId = @EmpId"
                Using cmd As New SqlCommand(query, con)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@EmpId", TextBox1.Text) ' Assuming TextBox1 contains the EmpId
                    cmd.Parameters.AddWithValue("@EmpName", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@EmpAdd", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@EmpPhone", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@EmpEdu", ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@EmpPos", ComboBox4.Text)
                    cmd.Parameters.AddWithValue("@EmpGen", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@EmpDob", DateTimePicker1.Value) ' Pass the DateTime value

                    ' Execute the command
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the update was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Record updated successfully!")
                    Else
                        MessageBox.Show("No record found with the specified ID.")
                    End If
                End Using ' Automatically closes the SqlCommand
            End Using ' Automatically closes the SqlConnection
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        ' Check if a row is selected
        If DataGridView1.CurrentRow IsNot Nothing Then
            ' Populate the TextBoxes and ComboBoxes with the values from the selected row
            TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString() ' EmpId
            TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString() ' EmpName
            TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString() ' EmpAdd
            ComboBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString() ' EmpPos
            DateTimePicker1.Value = Convert.ToDateTime(DataGridView1.CurrentRow.Cells(4).Value) ' EmpDob
            TextBox4.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString() ' EmpPhone
            ComboBox1.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString() ' EmpGen
            ComboBox2.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString() ' EmpEdu
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ' Clear all TextBoxes
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        ' Reset all ComboBoxes to their default state (first item or empty)
        ComboBox1.SelectedIndex = -1 ' Deselects any selected item
        ComboBox2.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1

        ' Reset the DateTimePicker to the current date or a default date
        DateTimePicker1.Value = DateTime.Now ' or set to a specific default date

        ' Reset labels to empty
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox4.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub
End Class