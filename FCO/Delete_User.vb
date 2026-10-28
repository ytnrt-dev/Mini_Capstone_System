Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Delete_User
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"

    Private Sub Delete_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As New OleDbConnection(conString)
            Dim sqlDisplay As String = "SELECT * FROM account_credentials"

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                Dim Table As New DataTable()
                adapter.Fill(Table)
                DataGridView1.DataSource = Table
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            If Not IsDBNull(row.Cells("user_name").Value) AndAlso row.Cells("user_name") IsNot Nothing Then
                TextBox1.Text = row.Cells("user_name").Value.ToString()
            End If


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using con As New OleDbConnection(conString)
            Dim sqlDelete As String = "DELETE * FROM account_credentials WHERE user_name= '" & TextBox1.Text & "'"

            Using cmd As New OleDbCommand(sqlDelete, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Successfully Deleted!")
                TextBox1.Clear()


                Dim sqlDisplay As String = "SELECT * FROM account_credentials"
                Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                    Dim Table As New DataTable
                    adapter.Fill(Table)
                    DataGridView1.DataSource = Table



                End Using

            End Using
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class