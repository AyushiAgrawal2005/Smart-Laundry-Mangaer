<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(59, 204)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(61, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Cash"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(59, 297)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(102, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Debit Card"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(216, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 36)
        Label1.TabIndex = 2
        Label1.Text = "PAYMENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(59, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(254, 28)
        Label2.TabIndex = 3
        Label2.Text = "Choose Payment Method:"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(229, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 25)
        Label3.TabIndex = 4
        Label3.Text = "Enter Card Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(229, 327)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(147, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(122, 461)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 36)
        Button1.TabIndex = 6
        Button1.Text = "Pay Now"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.OIP__3_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 576)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        DoubleBuffered = True
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
