<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Account
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
        DataGridView1 = New DataGridView()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
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
        TextBox1.Location = New Point(246, 155)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "**********"
        TextBox1.Size = New Size(520, 35)
        TextBox1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(32, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 41)
        Label3.TabIndex = 7
        Label3.Text = "User ID"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(41, 212)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(725, 170)
        DataGridView1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(325, 419)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(441, 35)
        TextBox2.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(41, 408)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 41)
        Label4.TabIndex = 12
        Label4.Text = "Full Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.White
        TextBox3.Location = New Point(325, 474)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(441, 35)
        TextBox3.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(41, 468)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 41)
        Label5.TabIndex = 14
        Label5.Text = "User ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(41, 528)
        Label6.Name = "Label6"
        Label6.Size = New Size(257, 41)
        Label6.TabIndex = 16
        Label6.Text = "Email Address"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(41, 588)
        Label7.Name = "Label7"
        Label7.Size = New Size(271, 41)
        Label7.TabIndex = 17
        Label7.Text = "Phone Number"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(41, 648)
        Label8.Name = "Label8"
        Label8.Size = New Size(183, 41)
        Label8.TabIndex = 18
        Label8.Text = "Password"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = Color.White
        TextBox4.Location = New Point(325, 534)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(441, 35)
        TextBox4.TabIndex = 19
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.ForeColor = Color.White
        TextBox5.Location = New Point(325, 594)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(441, 35)
        TextBox5.TabIndex = 20
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox6.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.ForeColor = Color.White
        TextBox6.Location = New Point(325, 654)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(441, 35)
        TextBox6.TabIndex = 21
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Tahoma", 13.8F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(416, 711)
        Button1.Name = "Button1"
        Button1.Size = New Size(350, 50)
        Button1.TabIndex = 22
        Button1.Text = "Update Account"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Tahoma", 13.8F, FontStyle.Bold)
        Button2.Location = New Point(41, 711)
        Button2.Name = "Button2"
        Button2.Size = New Size(350, 50)
        Button2.TabIndex = 23
        Button2.Text = "Enable Editing"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._868403053_1650702099782619_6299859084371940794_n
        PictureBox1.Location = New Point(315, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Update_Account
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(847, 782)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Name = "Update_Account"
        Text = "Update_Account"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
