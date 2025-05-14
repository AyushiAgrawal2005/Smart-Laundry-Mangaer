<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SP

    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        DataGridView2 = New DataGridView()
        Offlinebtn = New Button()
        Onlinebtn = New Button()
        Label3 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(181, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 31)
        Label1.TabIndex = 5
        Label1.Text = "ORDER DETAILS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 85)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(504, 321)
        DataGridView1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(694, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 31)
        Label2.TabIndex = 7
        Label2.Text = "PAYMENT DETAILS"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.ControlLight
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(569, 85)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(504, 321)
        DataGridView2.TabIndex = 6
        ' 
        ' Offlinebtn
        ' 
        Offlinebtn.BackColor = Color.Red
        Offlinebtn.Location = New Point(691, 636)
        Offlinebtn.Name = "Offlinebtn"
        Offlinebtn.Size = New Size(139, 55)
        Offlinebtn.TabIndex = 8
        Offlinebtn.Text = "OFFLINE"
        Offlinebtn.UseVisualStyleBackColor = False
        ' 
        ' Onlinebtn
        ' 
        Onlinebtn.BackColor = Color.Green
        Onlinebtn.Location = New Point(504, 636)
        Onlinebtn.Name = "Onlinebtn"
        Onlinebtn.Size = New Size(139, 55)
        Onlinebtn.TabIndex = 9
        Onlinebtn.Text = "ONLINE"
        Onlinebtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(193, 645)
        Label3.Name = "Label3"
        Label3.Size = New Size(274, 39)
        Label3.TabIndex = 10
        Label3.Text = "Update Your Status"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Location = New Point(12, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 40)
        Button1.TabIndex = 11
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(538, 493)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(149, 27)
        TextBox1.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(538, 542)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(149, 27)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(538, 589)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(149, 27)
        TextBox3.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(294, 500)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 20)
        Label4.TabIndex = 15
        Label4.Text = "Set WashingPrice( per kg)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(294, 549)
        Label5.Name = "Label5"
        Label5.Size = New Size(189, 20)
        Label5.TabIndex = 16
        Label5.Text = "Set IroningPrice( per piece)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(294, 596)
        Label6.Name = "Label6"
        Label6.Size = New Size(223, 20)
        Label6.TabIndex = 17
        Label6.Text = "Set DryCleaningPrice( per piece)"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.AppWorkspace
        Button2.Location = New Point(736, 542)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 42)
        Button2.TabIndex = 18
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.BackColor = SystemColors.ControlLight
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(289, 442)
        Label7.Name = "Label7"
        Label7.Size = New Size(398, 25)
        Label7.TabIndex = 19
        Label7.Text = "Set Price =0 for the service you are not available"
        ' 
        ' SP
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = My.Resources.Resources.OIP__6_
        ClientSize = New Size(1100, 703)
        Controls.Add(Label7)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Onlinebtn)
        Controls.Add(Offlinebtn)
        Controls.Add(Label2)
        Controls.Add(DataGridView2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "SP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SP Dashboard"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Offlinebtn As Button
    Friend WithEvents Onlinebtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
End Class
