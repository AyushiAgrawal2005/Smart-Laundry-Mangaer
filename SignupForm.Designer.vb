<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        signinbtn = New Button()
        signupbtn = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox7 = New TextBox()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CheckBoxShowPassword = New CheckBox()
        TextBox8 = New TextBox()
        Label11 = New Label()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' signinbtn
        ' 
        signinbtn.Font = New Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold)
        signinbtn.Location = New Point(395, 521)
        signinbtn.Name = "signinbtn"
        signinbtn.Size = New Size(117, 40)
        signinbtn.TabIndex = 15
        signinbtn.Text = "LOGIN"
        signinbtn.UseVisualStyleBackColor = True
        ' 
        ' signupbtn
        ' 
        signupbtn.Font = New Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold)
        signupbtn.Location = New Point(149, 522)
        signupbtn.Name = "signupbtn"
        signupbtn.Size = New Size(117, 40)
        signupbtn.TabIndex = 14
        signupbtn.Text = "SIGNUP"
        signupbtn.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(160, 216)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(185, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(160, 281)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(185, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 288)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(39, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(257, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 43)
        Label1.TabIndex = 0
        Label1.Text = "SIGNUP"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(39, 405)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 4
        Label4.Text = "NAME"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(160, 402)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(185, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(39, 478)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 20)
        Label5.TabIndex = 6
        Label5.Text = "PHONE NO."
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(160, 471)
        TextBox4.MaxLength = 10
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(185, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(469, 222)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 20)
        Label9.TabIndex = 37
        Label9.Text = "ADDRESS"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(505, 352)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(165, 27)
        TextBox6.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(384, 359)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 20)
        Label7.TabIndex = 10
        Label7.Text = "CITY"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(505, 284)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(165, 27)
        TextBox7.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(384, 291)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 20)
        Label8.TabIndex = 8
        Label8.Text = "STATE"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(505, 420)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(165, 27)
        TextBox5.TabIndex = 13
        TextBox5.Visible = False
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(384, 420)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 12
        Label6.Text = "BRANCH"
        Label6.Visible = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(39, 154)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 20)
        Label10.TabIndex = 0
        Label10.Text = "ROLE"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Service Provider", "Customer"})
        ComboBox1.Location = New Point(160, 152)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(185, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' CheckBoxShowPassword
        ' 
        CheckBoxShowPassword.BackColor = SystemColors.Window
        CheckBoxShowPassword.Location = New Point(294, 284)
        CheckBoxShowPassword.Name = "CheckBoxShowPassword"
        CheckBoxShowPassword.Size = New Size(49, 22)
        CheckBoxShowPassword.TabIndex = 41
        CheckBoxShowPassword.Text = "👁️"
        CheckBoxShowPassword.UseVisualStyleBackColor = False
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(160, 339)
        TextBox8.Name = "TextBox8"
        TextBox8.PasswordChar = "*"c
        TextBox8.Size = New Size(185, 27)
        TextBox8.TabIndex = 43
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(39, 339)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 40)
        Label11.TabIndex = 42
        Label11.Text = "CONFIRM" & vbCrLf & "PASSWORD"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.BackColor = SystemColors.Window
        CheckBox1.Location = New Point(295, 341)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(49, 22)
        CheckBox1.TabIndex = 44
        CheckBox1.Text = "👁️"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Best_Publisher_Wallpaper
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(721, 607)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox8)
        Controls.Add(Label11)
        Controls.Add(CheckBoxShowPassword)
        Controls.Add(ComboBox1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(TextBox7)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(signinbtn)
        Controls.Add(signupbtn)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "SignupForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignupForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents signinbtn As Button
    Friend WithEvents signupbtn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckBoxShowPassword As CheckBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
