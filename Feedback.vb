Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient

Public Class Form5
    Public Property CustID As String
    Public Property SPID As String
    Public Property SPName As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = SPID.ToString()
        TextBox2.Text = SPName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comment As String = TextBox3.Text
        Dim rating As String = ComboBox1.Text

        If String.IsNullOrWhiteSpace(comment) OrElse String.IsNullOrWhiteSpace(rating) Then
            MessageBox.Show("Please fill in all feedback details.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim con As New SqlClient.SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            con.Open()

            Dim Feedback_Id As String = Guid.NewGuid().ToString()
            Dim query As String = "INSERT INTO Feedback (Feedback_Id,Cust_ID, Sp_ID, Comment, Rating)" &
                "VALUES (@Feedback_Id,@CustID, @SPID, @Comment, @Rating)"
            Dim cmd As New SqlClient.SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@Feedback_Id", Feedback_Id)
            cmd.Parameters.AddWithValue("@CustID", CustID)
            cmd.Parameters.AddWithValue("@SPID", SPID)
            cmd.Parameters.AddWithValue("@Comment", comment)
            cmd.Parameters.AddWithValue("@Rating", rating)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            Dim Form2 As New Form2
            Form2.Cust_ID = Me.CustID
            Me.Close()
            Form2.Show()


        Catch ex As Exception
            MessageBox.Show("Error while submitting feedback: " & ex.Message)
        End Try
    End Sub

End Class