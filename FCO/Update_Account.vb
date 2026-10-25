Imports System.Data.OleDb

Public Class Update_Account
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Using con As New OleDbConnection(conString)

            Dim sqlDisplay = "SELECT * FROM account_credentials WHERE user_name = '" & TextBox1.Text & "'"

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                Dim Table As New DataTable
                adapter.Fill(Table)
                DataGridView1.DataSource = Table

                If Table.Rows.Count > 0 Then
                    TextBox2.Text = Table.Rows(0)("full_name").ToString()
                    TextBox3.Text = Table.Rows(0)("user_name").ToString()
                    TextBox4.Text = Table.Rows(0)("email_address").ToString()
                    TextBox5.Text = Table.Rows(0)("phone_number").ToString()
                    TextBox6.Text = Table.Rows(0)("user_password").ToString()

                    TextBox2.Enabled = False
                    TextBox3.Enabled = False
                    TextBox4.Enabled = False
                    TextBox5.Enabled = False
                    TextBox6.Enabled = False

                Else
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox5.Clear()
                    TextBox6.Clear()
                End If

            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using con As New OleDbConnection(conString)

            Dim sqlUpdate As String = "UPDATE account_credentials SET full_name = '" & TextBox2.Text & "', user_name = '" & TextBox3.Text & "', email_address = '" & TextBox4.Text & "', phone_number = '" & TextBox5.Text & "', user_password = '" & TextBox6.Text & "' WHERE user_name = '" & TextBox1.Text & "'"

            Using cmd As New OleDbCommand(sqlUpdate, con)

                con.Open()
                cmd.ExecuteNonQuery()

                MessageBox.Show("Account Successfully Updated!")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()

            End Using

        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True

    End Sub

End Class