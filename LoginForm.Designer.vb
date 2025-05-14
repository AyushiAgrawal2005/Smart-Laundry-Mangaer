<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
        RoleCombobox = New ComboBox()
        CheckBoxShowPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' signinbtn
        ' 
        signinbtn.Font = New Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold)
        signinbtn.Location = New Point(351, 421)
        signinbtn.Name = "signinbtn"
        signinbtn.Size = New Size(117, 40)
        signinbtn.TabIndex = 8
        signinbtn.Text = "SIGN IN"
        signinbtn.UseVisualStyleBackColor = True
        ' 
        ' signupbtn
        ' 
        signupbtn.Font = New Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold)
        signupbtn.Location = New Point(158, 421)
        signupbtn.Name = "signupbtn"
        signupbtn.Size = New Size(117, 40)
        signupbtn.TabIndex = 7
        signupbtn.Text = "SIGNUP"
        signupbtn.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(279, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(279, 239)
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.Size = New Size(205, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(158, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 3
        Label3.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(158, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(183, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 43)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(158, 318)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 5
        Label4.Text = "ROLE"
        ' 
        ' RoleCombobox
        ' 
        RoleCombobox.FormattingEnabled = True
        RoleCombobox.Items.AddRange(New Object() {"Admin", "ServiceProvider", "Customer"})
        RoleCombobox.Location = New Point(279, 310)
        RoleCombobox.Name = "RoleCombobox"
        RoleCombobox.Size = New Size(205, 28)
        RoleCombobox.TabIndex = 6
        ' 
        ' CheckBoxShowPassword
        ' 
        CheckBoxShowPassword.BackColor = SystemColors.Window
        CheckBoxShowPassword.Location = New Point(438, 242)
        CheckBoxShowPassword.Name = "CheckBoxShowPassword"
        CheckBoxShowPassword.Size = New Size(46, 22)
        CheckBoxShowPassword.TabIndex = 9
        CheckBoxShowPassword.Text = "👁️"
        CheckBoxShowPassword.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Best_Publisher_Wallpaper
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(640, 534)
        Controls.Add(CheckBoxShowPassword)
        Controls.Add(RoleCombobox)
        Controls.Add(Label4)
        Controls.Add(signinbtn)
        Controls.Add(signupbtn)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
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
    Friend WithEvents RoleCombobox As ComboBox
    Friend WithEvents CheckBoxShowPassword As CheckBox

End Class
