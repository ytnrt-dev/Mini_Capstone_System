<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Review_Salary
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
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(119, 144)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(653, 35)
        TextBox1.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 13.8F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(13, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 28)
        Label3.TabIndex = 11
        Label3.Text = "User ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 13.8F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(14, 220)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 28)
        Label1.TabIndex = 13
        Label1.Text = "FROM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 13.8F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(55, 288)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 28)
        Label2.TabIndex = 14
        Label2.Text = "To"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 13.8F)
        DateTimePicker1.Location = New Point(119, 221)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(653, 27)
        DateTimePicker1.TabIndex = 15
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DateTimePicker2.CalendarFont = New Font("Segoe UI", 13.8F)
        DateTimePicker2.Location = New Point(119, 290)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(653, 27)
        DateTimePicker2.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(27, 398)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(745, 254)
        DataGridView1.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(620, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 46)
        Button1.TabIndex = 18
        Button1.Text = "Display"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._868403053_1650702099782619_6299859084371940794_n
        PictureBox1.Location = New Point(309, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 112)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Review_Salary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(800, 680)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Name = "Review_Salary"
        Text = "Review_Salary"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
