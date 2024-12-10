<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeManagement
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
        TbxEID = New TextBox()
        TbxFN = New TextBox()
        TbxMN = New TextBox()
        TbxLN = New TextBox()
        Label1 = New Label()
        TbxAge = New TextBox()
        TbxPN = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' TbxEID
        ' 
        TbxEID.Location = New Point(164, 58)
        TbxEID.Name = "TbxEID"
        TbxEID.Size = New Size(144, 23)
        TbxEID.TabIndex = 0
        ' 
        ' TbxFN
        ' 
        TbxFN.Location = New Point(164, 96)
        TbxFN.Name = "TbxFN"
        TbxFN.Size = New Size(144, 23)
        TbxFN.TabIndex = 1
        ' 
        ' TbxMN
        ' 
        TbxMN.Location = New Point(164, 134)
        TbxMN.Name = "TbxMN"
        TbxMN.Size = New Size(144, 23)
        TbxMN.TabIndex = 2
        ' 
        ' TbxLN
        ' 
        TbxLN.Location = New Point(164, 176)
        TbxLN.Name = "TbxLN"
        TbxLN.Size = New Size(144, 23)
        TbxLN.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 15)
        Label1.TabIndex = 5
        Label1.Text = "Employee Management"
        ' 
        ' TbxAge
        ' 
        TbxAge.Location = New Point(164, 264)
        TbxAge.Name = "TbxAge"
        TbxAge.Size = New Size(144, 23)
        TbxAge.TabIndex = 6
        ' 
        ' TbxPN
        ' 
        TbxPN.Location = New Point(164, 300)
        TbxPN.Name = "TbxPN"
        TbxPN.Size = New Size(144, 23)
        TbxPN.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 9
        Label2.Text = "Emloyee ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 10
        Label3.Text = "First Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 11
        Label4.Text = "Middle Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 12
        Label5.Text = "Last Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(21, 227)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 13
        Label6.Text = "Birthday"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(21, 272)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 15)
        Label7.TabIndex = 14
        Label7.Text = "Age"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(21, 308)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 15)
        Label8.TabIndex = 15
        Label8.Text = "Phone Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(21, 346)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 16
        Label9.Text = "Status"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(164, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 17
        Button1.Text = "SAVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(164, 221)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(144, 23)
        DateTimePicker1.TabIndex = 18
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(164, 338)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(144, 23)
        ComboBox1.TabIndex = 19
        ' 
        ' EmployeeManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TbxPN)
        Controls.Add(TbxAge)
        Controls.Add(Label1)
        Controls.Add(TbxLN)
        Controls.Add(TbxMN)
        Controls.Add(TbxFN)
        Controls.Add(TbxEID)
        Name = "EmployeeManagement"
        Text = "EmployeeManagement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TbxEID As TextBox
    Friend WithEvents TbxFN As TextBox
    Friend WithEvents TbxMN As TextBox
    Friend WithEvents TbxLN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbxAge As TextBox
    Friend WithEvents TbxPN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class
