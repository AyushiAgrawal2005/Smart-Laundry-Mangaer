Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class Form3

    Public Property Cust_ID As String
    Public Property SPID As String
    Public Property SPName As String

    Public Property phone As Long
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If phone = 0 Then
            Label18.Text = "unavailable"
        Else
            Label18.Text = phone.ToString()
        End If
        Label18.Visible = True

        Button1.BackColor = Color.Gray
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        WashingBox.Visible = True
        IroningBox.Visible = False
        DryCleaningBox.Visible = False
        Label7.Visible = False
        Totalbtn.Visible = False
        Paymentbtn.Visible = False

        Try
            Using con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
                con.Open()
                Dim query As String = "SELECT ISNULL(WashingPrice, 50) AS WashingPrice, ISNULL(IroningPrice, 10) AS IroningPrice, ISNULL(DryCleaningPrice, 30) AS DryCleaningPrice FROM ServiceProvider WHERE SP_ID = @SP_ID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@SP_ID", SPID)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' Assign default values if prices are null
                        Label13.Text = If(IsDBNull(reader("WashingPrice")), "50", reader("WashingPrice").ToString())
                        Label8.Text = If(IsDBNull(reader("IroningPrice")), "10", reader("IroningPrice").ToString())
                        Label9.Text = If(IsDBNull(reader("DryCleaningPrice")), "30", reader("DryCleaningPrice").ToString())
                    End If
                    If Label13.Text = "0" Then
                        Button8.Visible = False
                        TextBox11.Text = "Not Available"
                    End If
                    If Label8.Text = "0" Then
                        Button6.Visible = False
                        TextBox5.Text = "Not Available"
                    End If
                    If Label9.Text = "0" Then
                        Button5.Visible = False
                        TextBox2.Text = "Not Available"
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading service prices: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Washing
        Button1.BackColor = Color.Gray
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        WashingBox.Visible = True
        IroningBox.Visible = False
        DryCleaningBox.Visible = False
        Label7.Visible = False
        Totalbtn.Visible = False
        Paymentbtn.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  'Ironing
        Button2.BackColor = Color.Gray
        Button1.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        WashingBox.Visible = False
        IroningBox.Visible = True
        DryCleaningBox.Visible = False
        Label7.Visible = False
        Totalbtn.Visible = False
        Paymentbtn.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click  'Dry Cleaning
        Button3.BackColor = Color.Gray
        Button2.BackColor = Color.White
        Button1.BackColor = Color.White
        Button4.BackColor = Color.White
        DryCleaningBox.Visible = True
        WashingBox.Visible = False
        IroningBox.Visible = False
        Label7.Visible = False
        Totalbtn.Visible = False
        Paymentbtn.Visible = False


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackColor = Color.Gray
        Button3.BackColor = Color.White
        Button2.BackColor = Color.White
        Button1.BackColor = Color.White
        Label7.Visible = True
        Totalbtn.Visible = True
        Paymentbtn.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label16.Text = Val(TextBox11.Text) * 50   'Washing
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label15.Text = Val(TextBox5.Text) * 60   'Ironing
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label14.Text = Val(TextBox2.Text) * 100   'Dry Cleaning
    End Sub

    Private Sub Totalbtn_Click(sender As Object, e As EventArgs) Handles Totalbtn.Click
        Label7.Text = Val(Label14.Text) + Val(Label16.Text) + Val(Label15.Text)
    End Sub


    Private Sub Paymentbtn_Click(sender As Object, e As EventArgs) Handles Paymentbtn.Click
        ' Ensure Label7 (Total Amount) is not empty, not "0", and contains a valid number
        If String.IsNullOrWhiteSpace(Label7.Text) OrElse Not IsNumeric(Label7.Text) OrElse Val(Label7.Text) <= 0 Then
            MessageBox.Show("Total amount is invalid or empty. Please calculate the total before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Try to place the order and catch any errors
        Try
            Orderdetails()

            Dim Form4 As New Form4
            Form4.Amount = Val(Label7.Text)
            Form4.Cust_ID = Me.Cust_ID
            Form4.SPID = Me.SPID
            Form4.SPName = Me.SPName
            Me.Hide()
            Form4.Show()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing the payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Orderdetails()


        Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
        Try
            con.Open()

            ' Check Dry Cleaning (TextBox1)
            If Not String.IsNullOrWhiteSpace(Label14.Text) AndAlso IsNumeric(Label14.Text) Then
                InsertOrder(con, "Dry Cleaning", Convert.ToDecimal(Label14.Text), Convert.ToDecimal(TextBox2.Text), Convert.ToDecimal(Label9.Text))
            End If

            ' Check Ironing (TextBox4)
            If Not String.IsNullOrWhiteSpace(Label15.Text) AndAlso IsNumeric(Label15.Text) Then
                InsertOrder(con, "Ironing", Convert.ToDecimal(Label15.Text), Convert.ToDecimal(TextBox5.Text), Convert.ToDecimal(Label8.Text))
            End If

            ' Check Washing (TextBox10)
            If Not String.IsNullOrWhiteSpace(Label16.Text) AndAlso IsNumeric(Label16.Text) Then
                InsertOrder(con, "Washing", Convert.ToDecimal(Label16.Text), Convert.ToDecimal(TextBox11.Text), Convert.ToDecimal(Label13.Text))
            End If

            MessageBox.Show("Order(s) successfully placed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try



    End Sub

    Private Sub InsertOrder(con As SqlConnection, Servicetype As String, Total As Decimal, Weight As Decimal, Priceperkg As Decimal)
        Dim Service_ID As String = Guid.NewGuid().ToString()
        Dim query As String = "INSERT INTO [Order] (Service_ID,Servicetype, Priceperkg, Weight, SP_ID,Cust_ID, Total) " &
                              "VALUES (@Service_ID,@Servicetype, @Priceperkg, @Weight,@Sp_ID,@Cust_ID, @Total)"

        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Service_ID", Service_ID)
            cmd.Parameters.AddWithValue("@Servicetype", Servicetype)
            cmd.Parameters.AddWithValue("@Priceperkg", Priceperkg)
            cmd.Parameters.AddWithValue("@Weight", Weight)
            cmd.Parameters.AddWithValue("@Sp_ID", SPID)
            cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID)
            cmd.Parameters.AddWithValue("@Total", Total)

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub ClearForm()
        Label14.Text = ""
        TextBox2.Text = ""
        Label15.Text = ""
        TextBox5.Text = ""
        Label16.Text = ""
        TextBox11.Text = ""
        Label7.Text = ""
        Label13.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Button5.Visible = True
        Button6.Visible = True
        Button8.Visible = True
    End Sub
End Class