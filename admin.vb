Imports System.Data.SqlClient

Public Class admin

    Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
    Dim daLocation As SqlDataAdapter
    Dim daOrder As SqlDataAdapter
    Dim daFeedback As SqlDataAdapter
    Dim daServiceProvider As SqlDataAdapter ' New adapter for ServiceProvider

    Dim ds As New DataSet()

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLocationData()
        LoadOrderData()
        LoadFeedbackData()
        LoadServiceProviderData() ' Load the ServiceProvider data

        ' Add handler for Save button click
        AddHandler SaveBtn.Click, AddressOf SaveBtn_Click
    End Sub

    Private Sub LoadLocationData()
        Try
            con.Open()
            daLocation = New SqlDataAdapter("SELECT * FROM Location", con)
            ds.Tables.Add("Location")
            daLocation.Fill(ds.Tables("Location"))
            DataGridView1.DataSource = ds.Tables("Location")
        Catch ex As Exception
            MessageBox.Show("Error loading Location data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadOrderData()
        Try
            con.Open()
            daOrder = New SqlDataAdapter("SELECT * FROM [Order]", con)
            ds.Tables.Add("Order")
            daOrder.Fill(ds.Tables("Order"))
            DataGridView2.DataSource = ds.Tables("Order")
        Catch ex As Exception
            MessageBox.Show("Error loading Order data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadFeedbackData()
        Try
            con.Open()
            daFeedback = New SqlDataAdapter("SELECT * FROM Feedback", con)
            ds.Tables.Add("Feedback")
            daFeedback.Fill(ds.Tables("Feedback"))
            DataGridView3.DataSource = ds.Tables("Feedback")
        Catch ex As Exception
            MessageBox.Show("Error loading Feedback data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadServiceProviderData() ' New method for ServiceProvider table
        Try
            con.Open()
            daServiceProvider = New SqlDataAdapter("SELECT * FROM ServiceProvider", con)
            ds.Tables.Add("ServiceProvider")
            daServiceProvider.Fill(ds.Tables("ServiceProvider"))
            DataGridView4.DataSource = ds.Tables("ServiceProvider") ' Link to DataGridView4
        Catch ex As Exception
            MessageBox.Show("Error loading ServiceProvider data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs)
        Try
            con.Open()

            Dim cbLocation As New SqlCommandBuilder(daLocation)
            Dim cbOrder As New SqlCommandBuilder(daOrder)
            Dim cbFeedback As New SqlCommandBuilder(daFeedback)
            Dim cbServiceProvider As New SqlCommandBuilder(daServiceProvider) ' CommandBuilder for ServiceProvider

            daLocation.Update(ds.Tables("Location"))
            daOrder.Update(ds.Tables("Order"))
            daFeedback.Update(ds.Tables("Feedback"))
            daServiceProvider.Update(ds.Tables("ServiceProvider")) ' Update ServiceProvider table

            MessageBox.Show("Changes updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error saving changes: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class