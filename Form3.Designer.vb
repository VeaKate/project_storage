<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel3 = New Panel()
        Label10 = New Label()
        Button3 = New Button()
        Panel2 = New Panel()
        Button2 = New Button()
        TextBox6 = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Blue
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Button3)
        Panel3.Location = New Point(0, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(106, 451)
        Panel3.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(3, 5)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 34)
        Label10.TabIndex = 1
        Label10.Text = "Student"
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(112, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(272, 451)
        Panel2.TabIndex = 4
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
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Name = "Form3"
        Text = "Form3"
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
End Class
