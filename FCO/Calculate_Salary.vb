Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Calculate_Salary
    Dim conString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;" &
        "Data Source=" & Application.StartupPath & "\Database.accdb;" &
        "Persist Security Info=False;"

    Private Sub TotalDays()
        Dim StartDate As Date = DateTimePicker1.Value.Date
        Dim EndDate As Date = DateTimePicker2.Value.Date

        If EndDate >= StartDate Then
            Dim TotalDays As Integer = 0
            Dim CurrentDay As Date = StartDate

            While CurrentDay <= EndDate
                If CurrentDay.DayOfWeek <> DayOfWeek.Saturday AndAlso CurrentDay.DayOfWeek <> DayOfWeek.Sunday Then
                    TotalDays += 1


                End If
                CurrentDay = CurrentDay.AddDays(1)

            End While
            TextBox4.Text = TotalDays.ToString
        Else
            TextBox4.Text = "0"
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TotalDays()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        TotalDays()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Using con As New OleDbConnection(conString)
            Dim sqlDisplay As String = "SELECT * FROM account_credentials WHERE user_name='" & TextBox1.Text & "'"

            Using adapter As New OleDbDataAdapter(sqlDisplay, con)
                Dim Table As New DataTable()
                adapter.Fill(Table)

                If Table.Rows.Count > 0 Then
                    TextBox2.Text = Table.Rows(0)("full_name").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub TextBo4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox5.Text = Val(TextBox3.Text) * Val(TextBox4.Text)
        TextBox7.Text = 150
        TextBox8.Text = 100
        TextBox9.Text = 150
        TextBox10.Text = 0
        TextBox11.Text = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Dim Deduction As Integer
        Deduction = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)
        TextBox11.Text = Deduction
        TextBox6.Text = Val(TextBox5.Text) - Deduction
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using con As New OleDbConnection(conString)
            Dim sqlInsert As String = "INSERT INTO payroll_table(user_name, basic_salary, date_Start, date_end, total_days, gross_salary, sss, pag_ibig, philhealth, absent_late, total_deduction, net_salary) VALUES ('" & TextBox1.Text & "', " & TextBox3.Text & ", '" & DateTimePicker1.Value.Date & "', '" & DateTimePicker2.Value.Date & "', " & TextBox4.Text & ", " & TextBox5.Text & ", " & TextBox7.Text & ", " & TextBox8.Text & ", " & TextBox9.Text & ", " & TextBox10.Text & ", " & TextBox11.Text & ", " & TextBox6.Text & ")"
            Using cmd As New OleDbCommand(sqlInsert, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Sucessfully Added!")
            End Using
        End Using
    End Sub
End Class