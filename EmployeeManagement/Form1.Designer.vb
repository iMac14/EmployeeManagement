<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TbxUser = New TextBox()
        TbxPw = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' TbxUser
        ' 
        TbxUser.Location = New Point(276, 69)
        TbxUser.Name = "TbxUser"
        TbxUser.Size = New Size(184, 23)
        TbxUser.TabIndex = 0
        ' 
        ' TbxPw
        ' 
        TbxPw.Location = New Point(276, 129)
        TbxPw.Name = "TbxPw"
        TbxPw.Size = New Size(184, 23)
        TbxPw.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(164, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 18)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(164, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 18)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 25)
        Label3.TabIndex = 4
        Label3.Text = "Login Form"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(276, 179)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 261)
        Controls.Add(BtnLogin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TbxPw)
        Controls.Add(TbxUser)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TbxUser As TextBox
    Friend WithEvents TbxPw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLogin As Button

End Class
