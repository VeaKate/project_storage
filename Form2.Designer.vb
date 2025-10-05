<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        Button1 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ListBox1 = New ListBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        TextBox6 = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        Panel3 = New Panel()
        Label10 = New Label()
        Button3 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(111, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(399, 456)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(94, 355)
        Button1.Name = "Button1"
        Button1.Size = New Size(227, 52)
        Button1.TabIndex = 11
        Button1.Text = "Add New User"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(9, 291)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 30)
        Label6.TabIndex = 10
        Label6.Text = "Department:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(18, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 30)
        Label5.TabIndex = 9
        Label5.Text = "Last Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 30)
        Label4.TabIndex = 8
        Label4.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(82, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 30)
        Label3.TabIndex = 7
        Label3.Text = "role:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 30)
        Label2.TabIndex = 6
        Label2.Text = "username:"
        ' 
        ' ListBox1
        ' 
        ListBox1.AllowDrop = True
        ListBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 30
        ListBox1.Items.AddRange(New Object() {"Admin", "Instructor", "Student"})
        ListBox1.Location = New Point(149, 140)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(235, 34)
        ListBox1.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(149, 288)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(235, 33)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(149, 238)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(235, 33)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(149, 189)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 33)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(149, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 33)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(396, 43)
        Label1.TabIndex = 0
        Label1.Text = "Add User"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(516, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(272, 451)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(17, 280)
        Button2.Name = "Button2"
        Button2.Size = New Size(243, 52)
        Button2.TabIndex = 12
        Button2.Text = "Change Password"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(17, 225)
        TextBox6.Name = "TextBox6"
        TextBox6.PasswordChar = "*"c
        TextBox6.Size = New Size(243, 33)
        TextBox6.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(17, 192)
        Label9.Name = "Label9"
        Label9.Size = New Size(182, 30)
        Label9.TabIndex = 8
        Label9.Text = "confirm password:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(17, 92)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 30)
        Label8.TabIndex = 7
        Label8.Text = "password:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(17, 125)
        TextBox5.Name = "TextBox5"
        TextBox5.PasswordChar = "*"c
        TextBox5.Size = New Size(243, 33)
        TextBox5.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(272, 52)
        Label7.TabIndex = 0
        Label7.Text = "Change Password"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Blue
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Button3)
        Panel3.Location = New Point(-1, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(106, 451)
        Panel3.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(3, 5)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 34)
        Label10.TabIndex = 1
        Label10.Text = "Admin"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(3, 355)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 36)
        Button3.TabIndex = 0
        Button3.Text = "Sign Out"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
End Class
