Imports MySql.Data.MySqlClient


Public Class Form2
    Private connectionString As String = "Server=localhost;" &
                                       "Port=3307;" &
                                       "Database=db_fado;" &
                                       "Uid=root;" &
                                       "Pwd=admin123;"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usr As String = TextBox1.Text.Trim()
        Dim pwdRaw As String = $"{TextBox1.Text.Trim()}"
        Dim userRole As String = ListBox1.Text.Trim()
        Dim fName As String = TextBox2.Text.Trim()
        Dim lName As String = TextBox3.Text.Trim()
        Dim deptOrDob As String = TextBox4.Text.Trim()
        Dim hashedPwd As String = BCrypt.Net.BCrypt.HashPassword(pwdRaw)

        ' Validate fields
        If String.IsNullOrWhiteSpace(usr) OrElse
           String.IsNullOrWhiteSpace(fName) OrElse
           String.IsNullOrWhiteSpace(lName) Then

            MessageBox.Show("All fields are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using dbConn As New MySqlConnection(connectionString)
            dbConn.Open()
            Dim trans As MySqlTransaction = dbConn.BeginTransaction()

            Try
                ' Insert role record
                Dim insertRoleSql = "INSERT INTO roles (role_name) VALUES (@roleName)"
                Using roleCmd As New MySqlCommand(insertRoleSql, dbConn, trans)
                    roleCmd.Parameters.AddWithValue("@roleName", userRole)
                    roleCmd.ExecuteNonQuery()
                End Using

                Dim newRoleId As Integer = CInt(New MySqlCommand("SELECT LAST_INSERT_ID()", dbConn, trans).ExecuteScalar())

                ' Insert user record
                Dim insertUserSql = "INSERT INTO users (username, password_hash, role_id) " &
                            "VALUES (@uname, @pass, @rId)"
                Using userCmd As New MySqlCommand(insertUserSql, dbConn, trans)
                    userCmd.Parameters.AddWithValue("@uname", usr)
                    userCmd.Parameters.AddWithValue("@pass", hashedPwd)
                    userCmd.Parameters.AddWithValue("@rId", newRoleId)
                    userCmd.ExecuteNonQuery()
                End Using

                Dim newUserId As Integer = CInt(New MySqlCommand("SELECT LAST_INSERT_ID()", dbConn, trans).ExecuteScalar())

                ' Handle instructor/student role insertion
                Select Case userRole.Trim().ToLower()
                    Case "instructor"
                        Dim insertInstr = "INSERT INTO instructors (user_id, first_name, last_name, department) " &
                                  "VALUES (@uid, @fname, @lname, @dept)"
                        Using insCmd As New MySqlCommand(insertInstr, dbConn, trans)
                            With insCmd.Parameters
                                .AddWithValue("@uid", newUserId)
                                .AddWithValue("@fname", fName)
                                .AddWithValue("@lname", lName)
                                .AddWithValue("@dept", deptOrDob)
                            End With
                            insCmd.ExecuteNonQuery()
                        End Using

                    Case "student"
                        Dim insertStud = "INSERT INTO students (user_id, first_name, last_name, date_of_birth) " &
                                 "VALUES (@uid, @fname, @lname, @dob)"
                        Using studCmd As New MySqlCommand(insertStud, dbConn, trans)
                            With studCmd.Parameters
                                .AddWithValue("@uid", newUserId)
                                .AddWithValue("@fname", fName)
                                .AddWithValue("@lname", lName)
                                .AddWithValue("@dob", deptOrDob)
                            End With
                            studCmd.ExecuteNonQuery()
                        End Using
                End Select

                trans.Commit()
                MessageBox.Show($"New {userRole} Added!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("User creation failed: " & ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            End Try
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim role As String = ListBox1.SelectedItem.ToString().Trim()

        Select Case role.ToLower()
            Case "student"
                Label6.Text = "Date of Birth"
                Label6.Visible = True
                TextBox4.Visible = True
                TextBox4.PlaceholderText = "YYYY-MM-DD"

            Case "instructor"
                Label6.Text = "Department"
                Label6.Visible = True
                TextBox4.Visible = True
                TextBox4.PlaceholderText = ""

            Case "admin"
                Label6.Visible = False
                TextBox4.Visible = False

            Case Else
                Label6.Text = "Unknown Role"
                Label6.Visible = False
                TextBox4.Visible = False
        End Select
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
End Class