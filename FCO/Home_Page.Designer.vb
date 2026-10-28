<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        CreateNewAccountToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ViewUsersToolStripMenuItem = New ToolStripMenuItem()
        UpdareAccountToolStripMenuItem = New ToolStripMenuItem()
        DeleteUserToolStripMenuItem = New ToolStripMenuItem()
        PayrollToolStripMenuItem = New ToolStripMenuItem()
        CalculateSalaryToolStripMenuItem = New ToolStripMenuItem()
        ReviewSalaryToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ViewToolStripMenuItem, PayrollToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.BackColor = Color.White
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CreateNewAccountToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(81, 24)
        FileToolStripMenuItem.Text = " Account"
        ' 
        ' CreateNewAccountToolStripMenuItem
        ' 
        CreateNewAccountToolStripMenuItem.Name = "CreateNewAccountToolStripMenuItem"
        CreateNewAccountToolStripMenuItem.Size = New Size(227, 26)
        CreateNewAccountToolStripMenuItem.Text = "Create New Account"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ViewUsersToolStripMenuItem, UpdareAccountToolStripMenuItem, DeleteUserToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(55, 24)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' ViewUsersToolStripMenuItem
        ' 
        ViewUsersToolStripMenuItem.Name = "ViewUsersToolStripMenuItem"
        ViewUsersToolStripMenuItem.Size = New Size(224, 26)
        ViewUsersToolStripMenuItem.Text = "View Users"
        ' 
        ' UpdareAccountToolStripMenuItem
        ' 
        UpdareAccountToolStripMenuItem.Name = "UpdareAccountToolStripMenuItem"
        UpdareAccountToolStripMenuItem.Size = New Size(224, 26)
        UpdareAccountToolStripMenuItem.Text = "Update Account"
        ' 
        ' DeleteUserToolStripMenuItem
        ' 
        DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        DeleteUserToolStripMenuItem.Size = New Size(224, 26)
        DeleteUserToolStripMenuItem.Text = "Delete User"
        ' 
        ' PayrollToolStripMenuItem
        ' 
        PayrollToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CalculateSalaryToolStripMenuItem, ReviewSalaryToolStripMenuItem})
        PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        PayrollToolStripMenuItem.Size = New Size(67, 24)
        PayrollToolStripMenuItem.Text = "Payroll"
        ' 
        ' CalculateSalaryToolStripMenuItem
        ' 
        CalculateSalaryToolStripMenuItem.Name = "CalculateSalaryToolStripMenuItem"
        CalculateSalaryToolStripMenuItem.Size = New Size(224, 26)
        CalculateSalaryToolStripMenuItem.Text = "Calculate Salary"
        ' 
        ' ReviewSalaryToolStripMenuItem
        ' 
        ReviewSalaryToolStripMenuItem.Name = "ReviewSalaryToolStripMenuItem"
        ReviewSalaryToolStripMenuItem.Size = New Size(224, 26)
        ReviewSalaryToolStripMenuItem.Text = "Review Salary"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        Panel1.Location = New Point(12, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 831)
        Panel1.TabIndex = 1
        ' 
        ' Home_Page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 874)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Home_Page"
        Text = "Home_Page"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateNewAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UpdareAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateSalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReviewSalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
End Class
