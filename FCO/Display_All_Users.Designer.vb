<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_All_Users
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
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(20, 263)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(621, 280)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox1.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.WindowText
        TextBox1.Location = New Point(238, 139)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(403, 35)
        TextBox1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 41)
        Label1.TabIndex = 5
        Label1.Text = "Full Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox2.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(238, 199)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(403, 35)
        TextBox2.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(20, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 41)
        Label2.TabIndex = 7
        Label2.Text = "User ID"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_10_25_113742
        PictureBox1.Location = New Point(216, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(230, 106)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Display_All_Users
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(662, 555)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Display_All_Users"
        Text = "Display_All_Users"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
