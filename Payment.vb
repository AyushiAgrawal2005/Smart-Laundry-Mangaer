Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form4
    Public Property Amount As String
    Public Property Cust_ID As String
    Public Property SPID As String
    Public Property SPName As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Visible = False
        TextBox1.Visible = False
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label3.Visible = False
            TextBox1.Visible = False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label3.Visible = True
            TextBox1.Visible = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Allow only digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only numbers are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim digitsOnly As String = New String(TextBox1.Text.Where(Function(c) Char.IsDigit(c)).ToArray())
        If digitsOnly.Length > 16 Then
            MessageBox.Show("Card number cannot exceed 16 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = digitsOnly.Substring(0, 16)
            TextBox1.SelectionStart = TextBox1.Text.Length ' Move cursor to the end
        Else
            ' Format as #### #### #### ####
            TextBox1.Text = String.Join(" ", Enumerable.Range(0, digitsOnly.Length \ 4 + If(digitsOnly.Length Mod 4 = 0, 0, 1)) _
            .Select(Function(i) digitsOnly.Substring(i * 4, Math.Min(4, digitsOnly.Length - i * 4))))
            TextBox1.SelectionStart = TextBox1.Text.Length ' Move cursor to the end
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Method = ""
        Dim cardNumber As String = ""
        Dim Status = "Success"

        If RadioButton1.Checked Then
            Method = "Cash"
        ElseIf RadioButton2.Checked Then
            Method = "Debit Card"
            cardNumber = TextBox1.Text.Replace(" ", "").Trim()

            ' Validate card number input
            If cardNumber = "" OrElse cardNumber.Length <> 16 Then
                MessageBox.Show("Please enter a valid 16-digit card number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else
            MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Now insert into your Payment table
        Try
            Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            con.Open()

            Dim Pay_ID = Guid.NewGuid().ToString()
            Dim query = "INSERT INTO Payment(Pay_ID,Cust_ID,SP_ID,Amount,Status,Method) " &
                    "VALUES(@Pay_ID,@Cust_ID,@SP_ID,@Amount,@Status,@Method)"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Pay_ID", Pay_ID)
            cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID)
            cmd.Parameters.AddWithValue("@SP_ID", SPID)
            cmd.Parameters.AddWithValue("@Amount", Amount)
            cmd.Parameters.AddWithValue("@Status", Status)
            cmd.Parameters.AddWithValue("@Method", Method)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult.OK Then
                Hide()
                Dim Form5 As New Form5
                Form5.CustID = Cust_ID
                Form5.SPID = SPID
                Form5.SPName = SPName
                Form5.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class