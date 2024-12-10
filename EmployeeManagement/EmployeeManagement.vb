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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=03170214@Mac;database=admin"
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "INSERT INTO admin.employeeuser (EmployeeID, FirstName, MiddleName, LastName, Birthday, Age, PhoneNumber, Status) " &
        "VALUES ('" & TbxEID.Text & "', '" & TbxFN.Text & "', '" & TbxMN.Text & "', '" & TbxLN.Text &
        "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & TbxAge.Text & "', '" & TbxPN.Text & "', '" & ComboBox1.SelectedItem.ToString() & "')"

            Command = New MySqlCommand(Query, Mysqlconn)
            reader = Command.ExecuteReader
            MessageBox.Show("SAVED")
            Mysqlconn.Close()
        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If Mysqlconn IsNot Nothing Then
                Mysqlconn.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim birthDate As DateTime = DateTimePicker1.Value
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust if the birthday hasn't occurred yet this year
        If (birthDate > today.AddYears(-age)) Then
            age -= 1
        End If

        ' Display the age in the TextBox
        TbxAge.Text = age.ToString()
    End Sub
End Class