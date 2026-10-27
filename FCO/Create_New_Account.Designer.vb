<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_New_Account
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
        TextBox2 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
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
        TextBox1.Location = New Point(347, 176)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(330, 35)
        TextBox1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(60, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 41)
        Label3.TabIndex = 5
        Label3.Text = "Full Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(347, 236)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(330, 35)
        TextBox2.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(60, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 41)
        Label4.TabIndex = 7
        Label4.Text = "User ID"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(347, 475)
        Button1.Name = "Button1"
        Button1.Size = New Size(330, 50)
        Button1.TabIndex = 9
        Button1.Text = "Create Account"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(347, 296)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(330, 35)
        TextBox3.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(60, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(257, 41)
        Label5.TabIndex = 10
        Label5.Text = "Email Address"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = Color.White
        TextBox4.Location = New Point(347, 356)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(330, 35)
        TextBox4.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(60, 350)
        Label6.Name = "Label6"
        Label6.Size = New Size(271, 41)
        Label6.TabIndex = 12
        Label6.Text = "Phone Number"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.ForeColor = Color.White
        TextBox5.Location = New Point(347, 416)
        TextBox5.Name = "TextBox5"
        TextBox5.PasswordChar = "*"c
        TextBox5.Size = New Size(330, 35)
        TextBox5.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(60, 410)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 41)
        Label7.TabIndex = 14
        Label7.Text = "Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources._868403053_1650702099782619_6299859084371940794_n
        PictureBox1.Location = New Point(282, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(248, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Create_New_Account
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(800, 606)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox5)
        Controls.Add(Label7)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        MaximizeBox = False
        Name = "Create_New_Account"
        Text = "Create_New_Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
