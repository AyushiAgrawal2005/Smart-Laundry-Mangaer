Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Windows.Win32.System

Public Class Form2
    Public Property Cust_ID As String
    Dim con As New SqlConnection("Data Source=DESKTOP-CVU8TFE\SQLEXPRESS;Initial Catalog=Smart Laundry Manager;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
    Dim serviceProviderDict As New Dictionary(Of String, String)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            con.Open()

            ' Get unique States
            Dim cmd As New SqlCommand("SELECT DISTINCT State FROM Location", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ComboBox1.Items.Clear()

            While reader.Read()
                ComboBox1.Items.Add(reader("State").ToString())
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading states: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedState As String = ComboBox1.SelectedItem.ToString()

        Try
            con.Open()

            Dim cmd As New SqlCommand("SELECT DISTINCT City FROM Location WHERE State = @state", con)
            cmd.Parameters.AddWithValue("@state", selectedState)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ComboBox2.Items.Clear()

            While reader.Read()
                ComboBox2.Items.Add(reader("City").ToString())
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading cities: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim selectedState As String = ComboBox1.SelectedItem.ToString()
        Dim selectedCity As String = ComboBox2.SelectedItem.ToString()

        Try
            con.Open()

            Dim cmd As New SqlCommand("SELECT DISTINCT Branch FROM Location WHERE State = @state AND City = @city", con)
            cmd.Parameters.AddWithValue("@state", selectedState)
            cmd.Parameters.AddWithValue("@city", selectedCity)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ComboBox3.Items.Clear()

            While reader.Read()
                ComboBox3.Items.Add(reader("Branch").ToString())
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading branches: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim selectedState As String = ComboBox1.SelectedItem.ToString()
        Dim selectedCity As String = ComboBox2.SelectedItem.ToString()
        Dim selectedBranch As String = ComboBox3.SelectedItem.ToString()

        Try
            con.Open()

            ' Find the Location_ID for the selected combination
            Dim cmd As New SqlCommand("SELECT Location_ID FROM Location WHERE State = @state AND City = @city AND Branch = @branch", con)
            cmd.Parameters.AddWithValue("@state", selectedState)
            cmd.Parameters.AddWithValue("@city", selectedCity)
            cmd.Parameters.AddWithValue("@branch", selectedBranch)

            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Dim locationID As String = result.ToString()

                ' Now fetch service providers with their ratings
                Dim query As String = "SELECT sp.SP_ID, sp.Name, sp.Phone, " &
                                  "COALESCE(AVG(CAST(f.Rating AS FLOAT)),0) AS AvgRating " &
                                  "FROM ServiceProvider sp " &
                                  "LEFT JOIN Feedback f ON sp.SP_ID = f.SP_ID " &
                                  "WHERE sp.Location_ID = @locID AND sp.Status='Active' " &
                                  "GROUP BY sp.SP_ID, sp.Name, sp.Phone"

                Dim cmdSP As New SqlCommand(query, con)
                cmdSP.Parameters.AddWithValue("@locID", locationID)

                Dim reader As SqlDataReader = cmdSP.ExecuteReader()

                Listbox.Items.Clear()
                serviceProviderDict.Clear()

                While reader.Read()
                    Dim spID As String = reader("SP_ID").ToString()
                    Dim spName As String = reader("Name").ToString()
                    Dim phoneNumber As String = reader("Phone").ToString()
                    Dim avgRating As String = reader("AvgRating").ToString()

                    ' Format ListBox entry: Name | Phone | Rating ⭐
                    Dim displayText As String = $"{spName} | {phoneNumber} | Rating: {avgRating}/5 ⭐"

                    ' Store in dictionary
                    If Not serviceProviderDict.ContainsKey(displayText) Then
                        serviceProviderDict.Add(displayText, spID)
                        Listbox.Items.Add(displayText)
                    End If
                End While

                reader.Close()
            Else
                MessageBox.Show("No location found for the selected combination.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading service providers: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Listbox.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Service Provider from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedKey As String = Listbox.SelectedItem.ToString()
        If serviceProviderDict.ContainsKey(selectedKey) Then
            Dim spID As String = serviceProviderDict(selectedKey)
            Dim phoneNumber As Long = selectedKey.Split("|"c)(1).Trim() ' Extract the phone number from the key
            Dim spName As String = String.Join(" ", selectedKey.Split(" "c).Reverse().Skip(1).Reverse())



            Dim Form3 As New Form3
            Form3.SPID = spID
            Form3.SPName = spName
            Form3.Cust_ID = Me.Cust_ID
            Form3.phone = phoneNumber


            MessageBox.Show("You have selected Service Provider: " & spName & vbCrLf & "SP_ID: " & spID & vbCrLf & "SPphone: " & Form3.phone, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("The selected Service Provider is not found in the dictionary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class