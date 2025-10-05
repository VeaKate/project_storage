Imports MySql.Data.MySqlClient

Module Session
    Public CurrentUsername As String
    Public CurrentRole As String
End Module
Public Class Form1
    Private connectionString As String = "Server=localhost;" &
                                         "Port=3307;" &
                                         "Database=db_fado;" &
                                         "Uid=root;" &
                                         "Pwd=admin123;"
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter a valid username and password.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return
        End If
        Dim sql As String =
    "SELECT u.password_hash, r.role_name " &
    "FROM users u " &
    "JOIN roles r ON u.role_id = r.role_id " &
    "WHERE u.username = @user;"

        Dim dbConnection As New MySqlConnection(connectionString)
        Dim dbCommand As New MySqlCommand(sql, dbConnection)
        dbCommand.Parameters.AddWithValue("@user", username)

        Try
            dbConnection.Open()
            Dim rdr As MySqlDataReader = dbCommand.ExecuteReader()

            If Not rdr.HasRows Then
                MessageBox.Show("No account found for this username.",
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
                rdr.Close()
                Return
            End If

            rdr.Read()
            Dim hashFromDb As String = Convert.ToString(rdr("password_hash"))
            Dim role As String = Convert.ToString(rdr("role_name"))

            If BCrypt.Net.BCrypt.Verify(password, hashFromDb) Then
                Session.CurrentUsername = username
                MessageBox.Show($"Welcome, {username}! You are logged in as {role}.",
                        "Access Granted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

                Dim nextForm As Form = Nothing

                Select Case role.Trim().ToLower()
                    Case "admin"
                        nextForm = New Form2()
                    Case "student"
                        nextForm = New Form3()
                    Case "instructor"
                        nextForm = New Form4()
                    Case Else
                        MessageBox.Show("Your role is not recognized.",
                                "Access Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                        rdr.Close()
                        Return
                End Select

                nextForm.WindowState = FormWindowState.Maximized
                nextForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect password. Please try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            End If

            rdr.Close()

        Catch ex As MySqlException
            MessageBox.Show("A database connection error occurred:" & vbCrLf & ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred:" & vbCrLf & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

        Finally
            If dbConnection.State = ConnectionState.Open Then
                dbConnection.Close()
            End If
        End Try

    End Sub
End Class
