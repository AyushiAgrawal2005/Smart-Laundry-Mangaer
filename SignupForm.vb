Imports System.Data.SqlClient

Public Class SignupForm
    ' Replace with your actual SQL Server details
    Dim connectionString As String = "Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"c
        TextBox4.MaxLength = 10
    End Sub
    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        ' Ensure the user selected a role
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select a role (Customer / Service Provider).", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRole As String = ComboBox1.SelectedItem.ToString()

        If selectedRole = "Customer" Then
            Label6.Visible = False
            TextBox5.Visible = False
            CustomerSignup()

        ElseIf selectedRole = "Service Provider" Then
            Label6.Visible = True
            TextBox5.Visible = True
            ServiceProviderSignup()
        Else
            MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CustomerSignup()
        ' Collect Customer data
        Dim custID As String = TextBox2.Text.Trim()      ' Username becomes Customer ID
        Dim password As String = TextBox1.Text.Trim()
        Dim confirmPassword As String = TextBox8.Text.Trim() ' Confirm Password
        Dim name As String = TextBox3.Text.Trim()
        Dim phone As String = TextBox4.Text.Trim()
        Dim city As String = TextBox6.Text.Trim()
        Dim state As String = TextBox7.Text.Trim()

        ' Validation
        If String.IsNullOrEmpty(custID) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmPassword) OrElse
       String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(city) OrElse String.IsNullOrEmpty(state) Then
            MessageBox.Show("Please fill in all customer fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "INSERT INTO Customer (Cust_ID, Password, Name, Phone, City, State) " &
"VALUES (@CustID, @Password, @Name, @Phone, @City, @State)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@CustID", custID)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Phone", phone)
                cmd.Parameters.AddWithValue("@City", city)
                cmd.Parameters.AddWithValue("@State", state)

                Try
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Customer signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                    Else
                        MessageBox.Show("Customer signup failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Database error: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub ServiceProviderSignup()
        ' Collect Service Provider data
        Dim spID As String = TextBox2.Text.Trim()      ' Username becomes SP_ID
        Dim password As String = TextBox1.Text.Trim()
        Dim confirmPassword As String = TextBox8.Text.Trim() ' Confirm Password
        Dim name As String = TextBox3.Text.Trim()
        Dim phone As String = TextBox4.Text.Trim()
        Dim city As String = TextBox6.Text.Trim()
        Dim state As String = TextBox7.Text.Trim()
        Dim branch As String = TextBox5.Text.Trim()

        ' Validation
        If String.IsNullOrEmpty(spID) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmPassword) OrElse
       String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(city) OrElse String.IsNullOrEmpty(state) OrElse String.IsNullOrEmpty(branch) Then
            MessageBox.Show("Please fill in all service provider fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Transaction starts: first insert into Location, then into Service Provider
        Using con As New SqlConnection(connectionString)
            con.Open()

            Dim transaction As SqlTransaction = con.BeginTransaction()

            Try
                Dim existingLocationID As String = Nothing
                Dim checkLocationQuery As String = "SELECT Location_ID FROM Location WHERE City = @City AND State = @State AND Branch = @Branch"
                Dim checkLocationCmd As New SqlCommand(checkLocationQuery, con, transaction)
                checkLocationCmd.Parameters.AddWithValue("@City", city)
                checkLocationCmd.Parameters.AddWithValue("@State", state)
                checkLocationCmd.Parameters.AddWithValue("@Branch", branch)

                Dim result As Object = checkLocationCmd.ExecuteScalar()
                If result IsNot Nothing Then
                    existingLocationID = result.ToString() ' Use existing Location_ID
                Else
                    ' No existing Location found, insert a new one
                    existingLocationID = Guid.NewGuid().ToString()
                    Dim insertLocationQuery As String = "INSERT INTO Location (Location_ID, City, State, Branch) VALUES (@LocationID, @City, @State, @Branch)"
                    Dim insertLocationCmd As New SqlCommand(insertLocationQuery, con, transaction)
                    insertLocationCmd.Parameters.AddWithValue("@LocationID", existingLocationID)
                    insertLocationCmd.Parameters.AddWithValue("@City", city)
                    insertLocationCmd.Parameters.AddWithValue("@State", state)
                    insertLocationCmd.Parameters.AddWithValue("@Branch", branch)
                    insertLocationCmd.ExecuteNonQuery()
                End If

                ' Insert into Service Provider table using the determined Location_ID
                Dim insertSPQuery As String = "INSERT INTO ServiceProvider (SP_ID, Name, Password, Phone, Location_ID, Status) VALUES (@SPID, @Name, @Password, @Phone, @LocationID, @Status)"
                Dim spCmd As New SqlCommand(insertSPQuery, con, transaction)
                spCmd.Parameters.AddWithValue("@SPID", spID)
                spCmd.Parameters.AddWithValue("@Name", name)
                spCmd.Parameters.AddWithValue("@Password", password)
                spCmd.Parameters.AddWithValue("@Phone", phone)
                spCmd.Parameters.AddWithValue("@LocationID", existingLocationID)
                spCmd.Parameters.AddWithValue("@Status", "Active")

                spCmd.ExecuteNonQuery()
                transaction.Commit()

                MessageBox.Show("Service Provider signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                Me.Close()
                LoginForm.Show()

            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Signup failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub

    Private Sub ClearForm()
        TextBox1.Text = "" ' Password
        TextBox2.Text = "" ' Username / Cust_ID / SP_ID
        TextBox3.Text = "" ' Name
        TextBox4.Text = "" ' Phone
        TextBox5.Text = "" ' Branch (Only for SP)
        TextBox6.Text = "" ' City
        TextBox7.Text = "" ' State
        ComboBox1.SelectedIndex = -1 ' Role
    End Sub


    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        Me.Close()
        LoginForm.Show()

    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.Checked Then
            TextBox1.PasswordChar = ControlChars.NullChar ' Shows text
        Else
            TextBox1.PasswordChar = "*"c ' Masks it again
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem = "Customer" Then
            Label6.Visible = False
            TextBox5.Visible = False

        ElseIf ComboBox1.SelectedItem = "Service Provider" Then
            Label6.Visible = True
            TextBox5.Visible = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only numeric values are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox8.PasswordChar = ControlChars.NullChar ' Shows text
        Else
            TextBox8.PasswordChar = "*"c ' Masks it again
        End If
    End Sub
End Class