<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        IroningBox = New GroupBox()
        Button6 = New Button()
        Label15 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label13 = New Label()
        TextBox11 = New TextBox()
        Label16 = New Label()
        Button8 = New Button()
        WashingBox = New GroupBox()
        Totalbtn = New Button()
        Paymentbtn = New Button()
        DryCleaningBox = New GroupBox()
        Label9 = New Label()
        Button5 = New Button()
        Label14 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        IroningBox.SuspendLayout()
        WashingBox.SuspendLayout()
        DryCleaningBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(31, 50)
        Button1.Name = "Button1"
        Button1.Size = New Size(230, 102)
        Button1.TabIndex = 0
        Button1.Text = "Washing"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(31, 170)
        Button2.Name = "Button2"
        Button2.Size = New Size(230, 102)
        Button2.TabIndex = 1
        Button2.Text = "Ironing"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 13.8F)
        Button3.Location = New Point(31, 290)
        Button3.Name = "Button3"
        Button3.Size = New Size(230, 102)
        Button3.TabIndex = 2
        Button3.Text = "Dry Cleaning"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 13.8F)
        Button4.Location = New Point(31, 409)
        Button4.Name = "Button4"
        Button4.Size = New Size(230, 102)
        Button4.TabIndex = 3
        Button4.Text = "Total"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' IroningBox
        ' 
        IroningBox.Controls.Add(Button6)
        IroningBox.Controls.Add(Label15)
        IroningBox.Controls.Add(TextBox5)
        IroningBox.Controls.Add(Label8)
        IroningBox.Controls.Add(Label4)
        IroningBox.Controls.Add(Label5)
        IroningBox.Controls.Add(Label6)
        IroningBox.Location = New Point(297, 46)
        IroningBox.Name = "IroningBox"
        IroningBox.Size = New Size(693, 332)
        IroningBox.TabIndex = 7
        IroningBox.TabStop = False
        IroningBox.Text = "Ironing"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(295, 266)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 13
        Button6.Text = "Calculate"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.Location = New Point(444, 186)
        Label15.Name = "Label15"
        Label15.Size = New Size(125, 27)
        Label15.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(444, 109)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(444, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(125, 27)
        Label8.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(123, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 9
        Label4.Text = "Total Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(123, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 20)
        Label5.TabIndex = 8
        Label5.Text = "Total number of Clothes"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(123, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 20)
        Label6.TabIndex = 7
        Label6.Text = "Ironing Price(per piece)"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(92, 66)
        Label12.Name = "Label12"
        Label12.Size = New Size(153, 20)
        Label12.TabIndex = 0
        Label12.Text = "Washing Price(per kg)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(92, 138)
        Label11.Name = "Label11"
        Label11.Size = New Size(98, 20)
        Label11.TabIndex = 1
        Label11.Text = "Weight(in kg)"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(92, 219)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 20)
        Label10.TabIndex = 2
        Label10.Text = "Total Price"
        ' 
        ' Label13
        ' 
        Label13.Location = New Point(413, 63)
        Label13.Name = "Label13"
        Label13.Size = New Size(125, 27)
        Label13.TabIndex = 3
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(413, 135)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(125, 27)
        TextBox11.TabIndex = 4
        ' 
        ' Label16
        ' 
        Label16.Location = New Point(413, 212)
        Label16.Name = "Label16"
        Label16.Size = New Size(125, 27)
        Label16.TabIndex = 5
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(264, 292)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 29)
        Button8.TabIndex = 6
        Button8.Text = "Calculate"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' WashingBox
        ' 
        WashingBox.Controls.Add(Button8)
        WashingBox.Controls.Add(Label16)
        WashingBox.Controls.Add(TextBox11)
        WashingBox.Controls.Add(Label13)
        WashingBox.Controls.Add(Label10)
        WashingBox.Controls.Add(Label11)
        WashingBox.Controls.Add(Label12)
        WashingBox.Location = New Point(297, 46)
        WashingBox.Name = "WashingBox"
        WashingBox.Size = New Size(693, 332)
        WashingBox.TabIndex = 14
        WashingBox.TabStop = False
        WashingBox.Text = "Washing"
        ' 
        ' Totalbtn
        ' 
        Totalbtn.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Totalbtn.Location = New Point(667, 470)
        Totalbtn.Name = "Totalbtn"
        Totalbtn.Size = New Size(116, 41)
        Totalbtn.TabIndex = 16
        Totalbtn.Text = "Calculate Total"
        Totalbtn.UseVisualStyleBackColor = False
        ' 
        ' Paymentbtn
        ' 
        Paymentbtn.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Paymentbtn.Location = New Point(898, 441)
        Paymentbtn.Name = "Paymentbtn"
        Paymentbtn.Size = New Size(121, 48)
        Paymentbtn.TabIndex = 17
        Paymentbtn.Text = "Payment"
        Paymentbtn.UseVisualStyleBackColor = False
        ' 
        ' DryCleaningBox
        ' 
        DryCleaningBox.Controls.Add(Label9)
        DryCleaningBox.Controls.Add(Button5)
        DryCleaningBox.Controls.Add(Label14)
        DryCleaningBox.Controls.Add(TextBox2)
        DryCleaningBox.Controls.Add(Label1)
        DryCleaningBox.Controls.Add(Label2)
        DryCleaningBox.Controls.Add(Label3)
        DryCleaningBox.Location = New Point(297, 46)
        DryCleaningBox.Name = "DryCleaningBox"
        DryCleaningBox.Size = New Size(693, 338)
        DryCleaningBox.TabIndex = 7
        DryCleaningBox.TabStop = False
        DryCleaningBox.Text = "Dry Cleaning"
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(444, 37)
        Label9.Name = "Label9"
        Label9.Size = New Size(125, 27)
        Label9.TabIndex = 28
        Label9.Text = "Label9"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(295, 269)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 27
        Button5.Text = "Calculate"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.Location = New Point(444, 189)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 27)
        Label14.TabIndex = 26
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(444, 112)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(123, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 23
        Label1.Text = "Total Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(123, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 20)
        Label2.TabIndex = 22
        Label2.Text = "Total number of Clothes"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(123, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 20)
        Label3.TabIndex = 21
        Label3.Text = "DryCleaning Price(per piece)"
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(651, 441)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 25)
        Label7.TabIndex = 18
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(710, 9)
        Label17.Name = "Label17"
        Label17.Size = New Size(73, 20)
        Label17.TabIndex = 19
        Label17.Text = "PhoneNo."
        ' 
        ' Label18
        ' 
        Label18.BackColor = SystemColors.ControlLight
        Label18.Location = New Point(805, 9)
        Label18.Name = "Label18"
        Label18.Size = New Size(185, 20)
        Label18.TabIndex = 20
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Laundry3
        ClientSize = New Size(1042, 523)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label7)
        Controls.Add(DryCleaningBox)
        Controls.Add(Paymentbtn)
        Controls.Add(Totalbtn)
        Controls.Add(WashingBox)
        Controls.Add(IroningBox)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        IroningBox.ResumeLayout(False)
        IroningBox.PerformLayout()
        WashingBox.ResumeLayout(False)
        WashingBox.PerformLayout()
        DryCleaningBox.ResumeLayout(False)
        DryCleaningBox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents IroningBox As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents WashingBox As GroupBox
    Friend WithEvents Totalbtn As Button
    Friend WithEvents Paymentbtn As Button
    Friend WithEvents DryCleaningBox As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
