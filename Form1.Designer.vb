<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        signupbtn = New Button()
        signinbtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(184, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 43)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(159, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(159, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(169, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 3
        Label4.Text = "ROLE"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(280, 228)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(165, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(280, 163)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(165, 27)
        TextBox2.TabIndex = 5
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Admin", "Customer", "Service Providers"})
        ComboBox1.Location = New Point(280, 316)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(165, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' signupbtn
        ' 
        signupbtn.Font = New Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold)
        signupbtn.Location = New Point(108, 437)
        signupbtn.Name = "signupbtn"
        signupbtn.Size = New Size(117, 40)
        signupbtn.TabIndex = 7
        signupbtn.Text = "SIGNUP"
        signupbtn.UseVisualStyleBackColor = True
        ' 
        ' signinbtn
        ' 
        signinbtn.Font = New Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold)
        signinbtn.Location = New Point(353, 437)
        signinbtn.Name = "signinbtn"
        signinbtn.Size = New Size(117, 40)
        signinbtn.TabIndex = 8
        signinbtn.Text = "SIGN IN"
        signinbtn.UseVisualStyleBackColor = True
        ' 
        ' Loginpage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.Best_Publisher_Wallpaper
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(653, 565)
        Controls.Add(signinbtn)
        Controls.Add(signupbtn)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Loginpage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents signupbtn As Button
    Friend WithEvents signinbtn As Button

End Class
