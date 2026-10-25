Imports System.Data.OleDb


Public Class Form1
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using con As New OleDbConnection(conString)
                con.Open()
                MessageBox.Show("Connection Successful!",
                                "Database Connection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Connection Failed!" & vbCrLf & vbCrLf & ex.Message,
                            "Database Connection Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using con As New OleDbConnection(conString)
            Dim newuser = "INSERT INTO account_credentials(user_, user_password) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "')"

            Using cmd As New OleDbCommand(newuser, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("New User Added!")
                TextBox1.Clear()
                TextBox2.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using con As New OleDbConnection(conString)
            Dim log_account As String = "SELECT COUNT(*) FROM account_credentials WHERE user_name='" & TextBox1.Text & "' And user_password='" & TextBox2.Text & "'"
            Using cmd As New OleDbCommand(log_account, con)

                Try
                    con.Open()

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar)
                    If count > 0 Then
                        MessageBox.Show("Log In Successfully!")
                        Home_Page.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Username and/or Password!")
                    End If

                Catch ex As Exception
                    MessageBox.Show("error:" & ex.Message, "Credentials Mismatched!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class