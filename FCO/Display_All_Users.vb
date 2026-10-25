Imports System.Data.OleDb

Public Class Display_All_Users
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"

    Private Sub Display_All_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As New OleDbConnection(conString)
            Dim sqlDisplay As String = "SELECT * FROM account_credentials"

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                Dim Table As New DataTable()
                adapter.Fill(Table)
                DataGridView1.DataSource = Table
            End Using
        End Using
    End Sub

    Private Sub Textbox1_Textchanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim sqlDisplay As String

        Using con As New OleDbConnection(conString)
            If String.IsNullOrWhiteSpace(TextBox1.Text) Then
                sqlDisplay = "SELECT * FROM account_credentials"
            Else
                sqlDisplay = "SELECT * FROM account_credentials WHERE full_name= '" & TextBox1.Text & "'"

            End If

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                Dim Table As New DataTable()
                adapter.Fill(Table)
                DataGridView1.DataSource = Table
            End Using
        End Using
    End Sub

    Private Sub Textbox2_Textchanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim sqlDisplay As String

        Using con As New OleDbConnection(conString)
            If String.IsNullOrWhiteSpace(TextBox2.Text) Then
                sqlDisplay = "SELECT * FROM account_credentials"
            Else
                sqlDisplay = "SELECT * FROM account_credentials WHERE user_name= '" & TextBox2.Text & "'"

            End If

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                Dim Table As New DataTable()
                adapter.Fill(Table)
                DataGridView1.DataSource = Table
            End Using
        End Using
    End Sub
End Class