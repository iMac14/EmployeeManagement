Imports MySql.Data.MySqlClient
Imports Windows.Win32.System
Public Class Form1
    Dim Mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=03170214@Mac;database=admin"
        Try
            Mysqlconn.Open()
            Dim Query = "SELECT * FROM users Where username='" & TbxUser.Text & "' and password='" & TbxPw.Text & "'"
            Command = New MySqlCommand(Query, Mysqlconn)
            reader = Command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Login Succesful")
                EmployeeManagement.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are incorrect")

            End If
            Mysqlconn.Close()

        Catch ex As Exception ' Corrected "Catch ex As Con" to "Catch ex As Exception"
            MessageBox.Show(ex.Message)
        Finally
            If Mysqlconn IsNot Nothing Then
                Mysqlconn.Dispose() ' Dispose releases resources, but Close() would be safer for connections
            End If
        End Try

    End Sub
End Class
