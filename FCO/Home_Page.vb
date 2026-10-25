Public Class Home_Page

    Private Sub CreateNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewAccountToolStripMenuItem.Click

        Panel1.Controls.Clear()

        Dim AccountForm As New Create_New_Account()

        AccountForm.TopLevel = False
        AccountForm.FormBorderStyle = FormBorderStyle.None
        AccountForm.Dock = DockStyle.Fill

        Panel1.Controls.Add(AccountForm)
        AccountForm.Show()

    End Sub

    Private Sub ViewUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUsersToolStripMenuItem.Click

        Panel1.Controls.Clear()

        Dim accountsView As New Display_All_Users()

        accountsView.TopLevel = False
        accountsView.FormBorderStyle = FormBorderStyle.None
        accountsView.Dock = DockStyle.Fill

        Panel1.Controls.Add(accountsView)
        accountsView.Show()

    End Sub

    Private Sub UpdareAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdareAccountToolStripMenuItem.Click
        Panel1.Controls.Clear()

        Dim UpdateForm As New Update_Account()

        UpdateForm.TopLevel = False
        UpdateForm.FormBorderStyle = FormBorderStyle.None
        UpdateForm.Dock = DockStyle.Fill

        Panel1.Controls.Add(UpdateForm)
        UpdateForm.Show()

    End Sub
End Class