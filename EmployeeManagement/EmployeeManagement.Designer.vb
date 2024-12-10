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
        BtnSave = New Button()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        Button3 = New Button()
        BtnUpdate = New Button()
        Button1 = New Button()
        BtnDelete = New Button()
        DataGridView1 = New DataGridView()
        TbxSearch = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Font = New Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(467, 43)
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
        TbxPN.Location = New Point(164, 336)
        TbxPN.Name = "TbxPN"
        TbxPN.Size = New Size(144, 23)
        TbxPN.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label2.Location = New Point(21, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 18)
        Label2.TabIndex = 9
        Label2.Text = "Emloyee ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label3.Location = New Point(21, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 18)
        Label3.TabIndex = 10
        Label3.Text = "First Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label4.Location = New Point(21, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 18)
        Label4.TabIndex = 11
        Label4.Text = "Middle Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label5.Location = New Point(21, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 18)
        Label5.TabIndex = 12
        Label5.Text = "Last Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label6.Location = New Point(21, 227)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 18)
        Label6.TabIndex = 13
        Label6.Text = "Birthday"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label7.Location = New Point(21, 264)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 18)
        Label7.TabIndex = 14
        Label7.Text = "Age"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label8.Location = New Point(21, 336)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 18)
        Label8.TabIndex = 15
        Label8.Text = "Phone Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label9.Location = New Point(21, 374)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 18)
        Label9.TabIndex = 16
        Label9.Text = "Status"
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(83, 406)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 17
        BtnSave.Text = "SAVE"
        BtnSave.UseVisualStyleBackColor = True
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
        ComboBox1.Location = New Point(164, 374)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(144, 23)
        ComboBox1.TabIndex = 19
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(618, 9)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 23)
        Button2.TabIndex = 20
        Button2.Text = "DASHBOARD"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(713, 9)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 21
        Button3.Text = "SIGNOUT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(164, 406)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(75, 23)
        BtnUpdate.TabIndex = 22
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(83, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 23
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(164, 435)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 24
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(350, 66)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(841, 295)
        DataGridView1.TabIndex = 25
        ' 
        ' TbxSearch
        ' 
        TbxSearch.Location = New Point(434, 367)
        TbxSearch.Name = "TbxSearch"
        TbxSearch.Size = New Size(192, 23)
        TbxSearch.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(350, 367)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 18)
        Label10.TabIndex = 28
        Label10.Text = "SEARCH"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label11.Location = New Point(22, 300)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 18)
        Label11.TabIndex = 29
        Label11.Text = "Gender"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(164, 299)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 19)
        RadioButton1.TabIndex = 30
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(235, 299)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 19)
        RadioButton2.TabIndex = 31
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' EmployeeManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1208, 483)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(TbxSearch)
        Controls.Add(DataGridView1)
        Controls.Add(BtnDelete)
        Controls.Add(Button1)
        Controls.Add(BtnUpdate)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(BtnSave)
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnSave As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TbxSearch As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
