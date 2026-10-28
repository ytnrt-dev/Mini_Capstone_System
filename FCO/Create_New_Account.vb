Imports System.Data.OleDb

Public Class Create_New_Account
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox5.Text <> TextBox8.Text Then
            MessageBox.Show("Passwords do not match!")
            TextBox8.Clear()
            TextBox8.Focus()
            Return
        End If

        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a position!")
            Return
        End If

        Using con As New OleDbConnection(conString)
            Dim newuser = "INSERT INTO account_credentials(user_name, email_address, last_name, first_name, middle_name, phone_number, user_password, user_role) VALUES('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & ComboBox1.SelectedItem.ToString() & "')"

            Using cmd As New OleDbCommand(newuser, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("New User Added!")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
                TextBox8.Clear()
                ComboBox1.SelectedIndex = -1

            End Using
        End Using
    End Sub
End Class