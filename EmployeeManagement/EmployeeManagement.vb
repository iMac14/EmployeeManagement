Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Imports Windows.Win32.System
Public Class EmployeeManagement
    Dim gender As String
    Dim Mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the ComboBox with status options
        ComboBox1.Items.Add("Single")
        ComboBox1.Items.Add("Married")
        load_Table()
    End Sub

    ' Method to search in the database based on the FirstName
    Private Sub SearchInDataGrid()
        Dim connectionString As String = "server=localhost;userid=root;password=03170214@Mac;database=admin"

        ' Create the SQL query with a parameterized LIKE statement to avoid SQL injection
        Dim query As String = "SELECT * FROM employeeuser WHERE FirstName LIKE @SearchText"

        ' Create a connection and command
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                ' Add the search text as a parameter to the query
                cmd.Parameters.AddWithValue("@SearchText", "%" & TbxSearch.Text & "%") ' The "%" allows partial matching

                ' Create a data adapter to fill the DataGridView with the results
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()

                ' Open the connection, fill the DataTable, and bind it to the DataGridView
                conn.Open()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub



    Private Sub ClearFields()
        TbxEID.Text = ""
        TbxFN.Text = ""
        TbxMN.Text = ""
        TbxLN.Text = ""
        TbxAge.Text = ""
        TbxPN.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        ComboBox1.SelectedIndex = -1 ' Reset ComboBox selection

    End Sub
    Private Sub load_Table()
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=03170214@Mac;database=admin"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "Select EmployeeID,FirstName,MiddleName,LastName,Birthday,Age,Gender,PhoneNumber,Status from admin.employeeuser"
            Command = New MySqlCommand(query, Mysqlconn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            Mysqlconn.Close()
        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If Mysqlconn IsNot Nothing Then
                Mysqlconn.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=03170214@Mac;database=admin"
        Try
            Mysqlconn.Open()
            Dim query As String
            ' Construct the SQL query
            query = "INSERT INTO admin.employeeuser (EmployeeID, FirstName, MiddleName, LastName, Birthday, Age, PhoneNumber, Status, Gender) " &
             "VALUES ('" & TbxEID.Text & "', '" & TbxFN.Text & "', '" & TbxMN.Text & "', '" & TbxLN.Text & "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") &
             "', '" & TbxAge.Text & "', '" & TbxPN.Text & "', '" & ComboBox1.SelectedItem.ToString() & "', '" & gender & "')"

            Command = New MySqlCommand(query, Mysqlconn)
            reader = Command.ExecuteReader
            MessageBox.Show("DATA SAVED")
            Mysqlconn.Close()
        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If Mysqlconn IsNot Nothing Then
                Mysqlconn.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try
        load_Table()
        ClearFields()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim today As Date = Date.Now
        Dim birthDate As Date = DateTimePicker1.Value
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust for a birthday not yet reached this year
        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        If age < 18 Then
            MessageBox.Show("Age is too young. Minimum age is 18.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf age > 60 Then
            MessageBox.Show("Age is too old. Maximum age is 60.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        TbxAge.Text = age.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=03170214@Mac;database=admin"
        Try
            Mysqlconn.Open()

            ' Check if the gender value is being correctly assigned from the radio buttons
            Dim gender As String
            If RadioButton1.Checked Then
                gender = "Male"
            ElseIf RadioButton2.Checked Then
                gender = "Female"
            Else
                ' If neither Male nor Female is selected, you can handle this case as needed.
                ' For example, set an error message or leave it empty
                MessageBox.Show("Please select a gender.")
                Return ' Exit the method if no gender is selected
            End If
            Dim query As String
            query = "UPDATE admin.employeeuser SET " &
            "FirstName = '" & TbxFN.Text & "', " &
            "MiddleName = '" & TbxMN.Text & "', " &
            "LastName = '" & TbxLN.Text & "', " &
            "Birthday = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', " &
            "Age = '" & TbxAge.Text & "', " &
            "PhoneNumber = '" & TbxPN.Text & "', " &
            "Status = '" & ComboBox1.SelectedItem.ToString() & "', " &
            "Gender = '" & gender & "' " & _ ' Ensure that there is a comma before the last field
            "WHERE EmployeeID = '" & TbxEID.Text & "'"



            Command = New MySqlCommand(query, Mysqlconn)
            reader = Command.ExecuteReader
            MessageBox.Show("DATA UPDATE")
            Mysqlconn.Close()
        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If Mysqlconn IsNot Nothing Then
                Mysqlconn.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try
        load_Table()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ClearFields()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=03170214@Mac;database=admin"
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "Delete from admin.employeeuser where EmployeeID='" & TbxEID.Text & "'"
            Command = New MySqlCommand(query, Mysqlconn)
            reader = Command.ExecuteReader
            MessageBox.Show("DATA DELETED")
            Mysqlconn.Close()
        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If Mysqlconn IsNot Nothing Then
                Mysqlconn.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try
        load_Table()
        ClearFields()

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            ' Assign values from the selected row to the respective controls
            TbxEID.Text = row.Cells("EmployeeID").Value.ToString()
            TbxFN.Text = row.Cells("FirstName").Value.ToString()
            TbxMN.Text = row.Cells("MiddleName").Value.ToString()
            TbxLN.Text = row.Cells("LastName").Value.ToString()
            gender = row.Cells("Gender").Value.ToString()

            ' Ensure valid date conversion for DateTimePicker
            DateTimePicker1.Value = Convert.ToDateTime(row.Cells("Birthday").Value)

            TbxAge.Text = row.Cells("Age").Value.ToString()
            TbxPN.Text = row.Cells("PhoneNumber").Value.ToString()

            ' Set ComboBox value
            ComboBox1.Text = row.Cells("Status").Value.ToString()

            ' Set the RadioButton for Gender
            If gender = "Male" Then
                RadioButton1.Checked = True
            ElseIf gender = "Female" Then
                RadioButton2.Checked = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TbxSearch.TextChanged
        SearchInDataGrid() ' Call the search function


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub
End Class