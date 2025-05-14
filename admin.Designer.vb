<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        DataGridView3 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SaveBtn = New Button()
        Button1 = New Button()
        Label4 = New Label()
        DataGridView4 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(81, 112)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(446, 237)
        DataGridView1.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.ControlLight
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(888, 100)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(424, 249)
        DataGridView2.TabIndex = 1
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = SystemColors.ControlLight
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(81, 426)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.Size = New Size(446, 265)
        DataGridView3.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(235, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 31)
        Label1.TabIndex = 3
        Label1.Text = "LOCATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1023, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 31)
        Label2.TabIndex = 4
        Label2.Text = "ORDER DETAILS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(268, 375)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 31)
        Label3.TabIndex = 5
        Label3.Text = "FEEDBACK"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = SystemColors.ActiveCaption
        SaveBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveBtn.Location = New Point(655, 359)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(109, 64)
        SaveBtn.TabIndex = 6
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Location = New Point(26, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 40)
        Button1.TabIndex = 7
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(1001, 375)
        Label4.Name = "Label4"
        Label4.Size = New Size(233, 31)
        Label4.TabIndex = 9
        Label4.Text = "SERVICE PROVIDERS"
        ' 
        ' DataGridView4
        ' 
        DataGridView4.BackgroundColor = SystemColors.ControlLight
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Location = New Point(888, 426)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowHeadersWidth = 51
        DataGridView4.Size = New Size(424, 265)
        DataGridView4.TabIndex = 8
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.OIP__6_
        ClientSize = New Size(1324, 740)
        Controls.Add(Label4)
        Controls.Add(DataGridView4)
        Controls.Add(Button1)
        Controls.Add(SaveBtn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView3)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Name = "admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "admin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView4 As DataGridView
End Class
