Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Imports Windows.Win32.System
Public Class EmployeeManagement
    Dim Mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the ComboBox with status options
        ComboBox1.Items.Add("Single")
        ComboBox1.Items.Add("Married")
        load_Table()
    End Sub
    Private Sub ClearFields()
        TbxEID.Text = ""
        TbxFN.Text = ""
        TbxMN.Text = ""
        TbxLN.Text = ""
        TbxAge.Text = ""
        TbxPN.Text = ""
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
            query = "Select EmployeeID,FirstName,MiddleName,LastName,Birthday,Age,PhoneNumber,Status from admin.employeeuser"
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
            query = "INSERT INTO admin.employeeuser (EmployeeID, FirstName, MiddleName, LastName, Birthday, Age, PhoneNumber, Status) " &
        "VALUES ('" & TbxEID.Text & "', '" & TbxFN.Text & "', '" & TbxMN.Text & "', '" & TbxLN.Text &
        "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & TbxAge.Text & "', '" & TbxPN.Text & "', '" & ComboBox1.SelectedItem.ToString() & "')"

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
            Dim query As String
            query = "UPDATE admin.employeeuser " &
        "SET EmployeeID = '" & TbxEID.Text & "', " &
        "FirstName = '" & TbxFN.Text & "', " &
        "MiddleName = '" & TbxMN.Text & "', " &
        "LastName = '" & TbxLN.Text & "', " &
        "Birthday = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', " &
        "Age = '" & TbxAge.Text & "', " &
        "PhoneNumber = '" & TbxPN.Text & "', " &
        "Status = '" & ComboBox1.SelectedItem.ToString() & "' " &
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

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=03170214@Mac;database=admin"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "Select EmployeeID,FirstName,MiddleName,LastName,Birthday,Age,PhoneNumber,Status from admin.employeeuser"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class