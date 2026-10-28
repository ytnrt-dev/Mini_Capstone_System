Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Review_Salary
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Using con As New OleDbConnection(conString)
            Dim sqlDisplay As String = "SELECT * FROM payroll_table WHERE user_name= '" & TextBox1.Text & "'"

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                Dim Table As New DataTable
                adapter.Fill(Table)
                DataGridView1.DataSource = Table
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using con As New OleDbConnection(conString)

            Dim sqlDisplay As String = "SELECT * FROM payroll_table WHERE Date_Start = ? AND Date_End = ?"

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)

                adapter.SelectCommand.Parameters.AddWithValue("@StartDate", DateTimePicker1.Value.Date)
                adapter.SelectCommand.Parameters.AddWithValue("@EndDate", DateTimePicker2.Value.Date)

                Dim Table As New DataTable()
                adapter.Fill(Table)

                DataGridView1.DataSource = Table

            End Using
        End Using

    End Sub

End Class