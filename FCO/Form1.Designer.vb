<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(60, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 41)
        Label3.TabIndex = 2
        Label3.Text = "User ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(60, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 41)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(280, 165)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "********"
        TextBox1.Size = New Size(330, 35)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(43), CByte(43), CByte(43))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(280, 225)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PlaceholderText = "**********"
        TextBox2.Size = New Size(330, 35)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(280, 280)
        Button1.Name = "Button1"
        Button1.Size = New Size(330, 50)
        Button1.TabIndex = 6
        Button1.Text = "Sign Up"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        Button2.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(280, 336)
        Button2.Name = "Button2"
        Button2.Size = New Size(330, 50)
        Button2.TabIndex = 7
        Button2.Text = "Log In"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_10_25_113742
        PictureBox1.Location = New Point(234, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(218, 103)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        ClientSize = New Size(671, 542)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Name = "Form1"
        Text = "Log_In_Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
