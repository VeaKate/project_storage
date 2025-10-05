Imports MySql.Data.MySqlClient

Public Class Form4
    Private connectionString As String = "Server=localhost;" &
                                       "Port=3307;" &
                                       "Database=db_fado;" &
                                       "Uid=root;" &
                                       "Pwd=admin123;"
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = Session.CurrentUsername
        Dim password As String = TextBox5.Text.Trim()
        Dim confirmPassword As String = TextBox6.Text.Trim()

        ' Validate password match
        If password = String.Empty OrElse confirmPassword = String.Empty Then
            MessageBox.Show("Password fields cannot be empty.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not password.Equals(confirmPassword) Then
            MessageBox.Show("Invalid Password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Hash the new password
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

        ' Prepare SQL query
        Dim sql As String = "UPDATE users 
                            SET password_hash = @password
                            WHERE username = @username"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(sql, conn)
                With cmd.Parameters
                    .AddWithValue("@password", hashedPassword)
                    .AddWithValue("@username", username)
                End With

                Try
                    conn.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    Select Case result
                        Case > 0
                            MessageBox.Show("Password updated successfully!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                        Case Else
                            MessageBox.Show("User not found.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                    End Select

                Catch ex As Exception
                    MessageBox.Show($"Database error: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                End Try
            End Using
        End Using

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim LoginForm As Form1
        LoginForm = New Form1() With {
            .WindowState = Me.WindowState
        }

        Me.Hide()
        LoginForm.Show()
    End Sub
End Class