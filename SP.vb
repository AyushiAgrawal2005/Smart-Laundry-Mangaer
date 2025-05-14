Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SP
    Public Property SP_ID As String
    Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")

    Private Sub SP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatus()
        LoadOrderDetails()
        LoadPaymentDetails()

    End Sub

    Private Sub LoadStatus()
        Try
            con.Open()
            Dim query As String = "SELECT Status FROM ServiceProvider WHERE SP_ID = @SP_ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SP_ID", SP_ID)
                Dim status As Object = cmd.ExecuteScalar()

                If status IsNot Nothing Then
                    Dim currentStatus As String = status.ToString()

                    If currentStatus = "Active" Then
                        Onlinebtn.BackColor = Color.Green
                        Offlinebtn.BackColor = Color.Gray
                    ElseIf currentStatus = "Not Active" Then
                        Onlinebtn.BackColor = Color.Gray
                        Offlinebtn.BackColor = Color.Red
                    Else
                        Onlinebtn.BackColor = Color.Gray
                        Offlinebtn.BackColor = Color.Gray
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading status: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Onlinebtn_Click(sender As Object, e As EventArgs) Handles Onlinebtn.Click
        Onlinebtn.BackColor = Color.Green
        Offlinebtn.BackColor = Color.Gray
        UpdateStatus("Active")

    End Sub

    Private Sub Offlinebtn_Click(sender As Object, e As EventArgs) Handles Offlinebtn.Click
        Onlinebtn.BackColor = Color.Gray
        Offlinebtn.BackColor = Color.Red
        UpdateStatus("Not Active")

    End Sub

    Private Sub UpdateStatus(newStatus As String)
        Try
            con.Open()

            Dim query As String = "UPDATE ServiceProvider SET Status = @status WHERE SP_ID = @SP_ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@SP_ID", SP_ID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Status updated to " & newStatus, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadOrderDetails()
        Try
            Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim query As String = "SELECT Service_ID,Cust_ID, ServiceType, PricePerKg, Weight,Total FROM [Order] WHERE SP_ID = @SPID"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@SPID", SP_ID)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error loading order details: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPaymentDetails()
        Try
            Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Dim query As String = "SELECT Pay_ID, Cust_ID, Amount, Status,Method FROM Payment WHERE SP_ID = @SPID"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@SPID", SP_ID)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView2.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error loading payment details: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim query As String = "UPDATE ServiceProvider SET WashingPrice = @WashingPrice, IroningPrice = @IroningPrice, DryCleaningPrice = @DryCleaningPrice WHERE SP_ID = @SP_ID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@WashingPrice", Convert.ToDecimal(TextBox1.Text))
                cmd.Parameters.AddWithValue("@IroningPrice", Convert.ToDecimal(TextBox2.Text))
                cmd.Parameters.AddWithValue("@DryCleaningPrice", Convert.ToDecimal(TextBox3.Text))
                cmd.Parameters.AddWithValue("@SP_ID", SP_ID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Prices updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to update prices.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class