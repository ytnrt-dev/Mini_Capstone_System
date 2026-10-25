Imports System.Data.OleDb

Public Class Create_New_Account
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using con As New OleDbConnection(conString)
            Dim newuser = "INSERT INTO account_credentials(full_name, user_id, email_address, phone_number, user_password) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "')"

            Using cmd As New OleDbCommand(newuser, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("New User Added!")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()

            End Using
        End Using
    End Sub

    Private Sub Create_New_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class