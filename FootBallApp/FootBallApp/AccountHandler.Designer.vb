<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountHandler
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cp1txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddBTn = New System.Windows.Forms.Button()
        Me.P1txt = New System.Windows.Forms.TextBox()
        Me.Utxt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.CP2txt = New System.Windows.Forms.TextBox()
        Me.Nptxt = New System.Windows.Forms.TextBox()
        Me.Optxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UsernameConfirmtxt = New System.Windows.Forms.TextBox()
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cp1txt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AddBTn)
        Me.GroupBox1.Controls.Add(Me.P1txt)
        Me.GroupBox1.Controls.Add(Me.Utxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 201)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Account"
        '
        'Cp1txt
        '
        Me.Cp1txt.Location = New System.Drawing.Point(22, 123)
        Me.Cp1txt.Name = "Cp1txt"
        Me.Cp1txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Cp1txt.Size = New System.Drawing.Size(100, 20)
        Me.Cp1txt.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Confirm Password"
        '
        'AddBTn
        '
        Me.AddBTn.Location = New System.Drawing.Point(36, 151)
        Me.AddBTn.Name = "AddBTn"
        Me.AddBTn.Size = New System.Drawing.Size(75, 23)
        Me.AddBTn.TabIndex = 4
        Me.AddBTn.Text = "Add"
        Me.AddBTn.UseVisualStyleBackColor = True
        '
        'P1txt
        '
        Me.P1txt.Location = New System.Drawing.Point(22, 83)
        Me.P1txt.Name = "P1txt"
        Me.P1txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.P1txt.Size = New System.Drawing.Size(100, 20)
        Me.P1txt.TabIndex = 3
        '
        'Utxt
        '
        Me.Utxt.Location = New System.Drawing.Point(22, 43)
        Me.Utxt.Name = "Utxt"
        Me.Utxt.Size = New System.Drawing.Size(100, 20)
        Me.Utxt.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UpdateBtn)
        Me.GroupBox2.Controls.Add(Me.CP2txt)
        Me.GroupBox2.Controls.Add(Me.Nptxt)
        Me.GroupBox2.Controls.Add(Me.Optxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(174, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 201)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change Password"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(34, 151)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBtn.TabIndex = 6
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'CP2txt
        '
        Me.CP2txt.Location = New System.Drawing.Point(18, 123)
        Me.CP2txt.Name = "CP2txt"
        Me.CP2txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CP2txt.Size = New System.Drawing.Size(100, 20)
        Me.CP2txt.TabIndex = 5
        '
        'Nptxt
        '
        Me.Nptxt.Location = New System.Drawing.Point(18, 83)
        Me.Nptxt.Name = "Nptxt"
        Me.Nptxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Nptxt.Size = New System.Drawing.Size(100, 20)
        Me.Nptxt.TabIndex = 4
        '
        'Optxt
        '
        Me.Optxt.Location = New System.Drawing.Point(18, 43)
        Me.Optxt.Name = "Optxt"
        Me.Optxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Optxt.Size = New System.Drawing.Size(100, 20)
        Me.Optxt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Old Password"
        '
        'UsernameConfirmtxt
        '
        Me.UsernameConfirmtxt.Location = New System.Drawing.Point(112, 23)
        Me.UsernameConfirmtxt.Name = "UsernameConfirmtxt"
        Me.UsernameConfirmtxt.Size = New System.Drawing.Size(100, 20)
        Me.UsernameConfirmtxt.TabIndex = 4
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.Location = New System.Drawing.Point(218, 20)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmBtn.TabIndex = 5
        Me.ConfirmBtn.Text = "Confirm"
        Me.ConfirmBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm Username"
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(12, 268)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(316, 23)
        Me.CancelBtn.TabIndex = 7
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AccountHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 303)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Controls.Add(Me.UsernameConfirmtxt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AccountHandler"
        Me.Text = "AccountHandler"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cp1txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddBTn As Button
    Friend WithEvents P1txt As TextBox
    Friend WithEvents Utxt As TextBox
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents CP2txt As TextBox
    Friend WithEvents Nptxt As TextBox
    Friend WithEvents Optxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UsernameConfirmtxt As TextBox
    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CancelBtn As Button
End Class
