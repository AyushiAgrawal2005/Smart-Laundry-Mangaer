Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm
    Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"c
    End Sub

    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        Dim username As String = TextBox2.Text.Trim()
        Dim password As String = TextBox1.Text.Trim()
        Dim role As String = RoleCombobox.SelectedItem
        Dim idColumn As String = ""

        If username = "" Or password = "" Or role = "" Then
            MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Determine the correct ID column name based on role
        If role = "Admin" Then
            idColumn = "ID"
        ElseIf role = "Customer" Then
            idColumn = "Cust_ID"
        ElseIf role = "ServiceProvider" Then
            idColumn = "SP_ID"
        Else
            MessageBox.Show("Invalid Role Selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            con.Open()

            ' Check if username exists
            Dim userCheckCmd As New SqlCommand($"SELECT COUNT(*) FROM {role} WHERE {idColumn} = @id", con)
            userCheckCmd.Parameters.AddWithValue("@id", username)
            Dim userExists As Integer = Convert.ToInt32(userCheckCmd.ExecuteScalar())

            ' Check if password exists independently
            Dim passCheckCmd As New SqlCommand($"SELECT COUNT(*) FROM {role} WHERE Password = @pass", con)
            passCheckCmd.Parameters.AddWithValue("@pass", password)
            Dim passExists As Integer = Convert.ToInt32(passCheckCmd.ExecuteScalar())

            If userExists = 0 And passExists = 0 Then
                MessageBox.Show("Both username and password are wrong!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf userExists = 0 Then
                MessageBox.Show("Wrong username!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Now check if the username and password match
                Dim loginCmd As New SqlCommand($"SELECT COUNT(*) FROM {role} WHERE {idColumn} = @id AND Password = @pass", con)
                loginCmd.Parameters.AddWithValue("@id", username)
                loginCmd.Parameters.AddWithValue("@pass", password)
                Dim validUser As Integer = Convert.ToInt32(loginCmd.ExecuteScalar())

                If validUser = 0 Then
                    MessageBox.Show("Wrong password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Redirect based on role
                    If role = "Admin" Then
                        admin.Show()
                    ElseIf role = "Customer" Then
                        Dim Form2 As New Form2
                        Form2.Cust_ID = username
                        Form2.Show()
                    ElseIf role = "ServiceProvider" Then
                        Dim SP As New SP
                        SP.SP_ID = username
                        SP.Show()
                    End If

                    Me.Hide()
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    RoleCombobox.Text = ""
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.Checked Then
            TextBox1.PasswordChar = ControlChars.NullChar ' Shows text
        Else
            TextBox1.PasswordChar = "*"c ' Masks it again
        End If
    End Sub

    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Me.Hide()
        SignupForm.Show()
    End Sub
End Class