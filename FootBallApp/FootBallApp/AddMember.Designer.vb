<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IDtxt = New System.Windows.Forms.TextBox()
        Me.FnameTXT = New System.Windows.Forms.TextBox()
        Me.LNametxt = New System.Windows.Forms.TextBox()
        Me.etxt = New System.Windows.Forms.TextBox()
        Me.gendertxt = New System.Windows.Forms.ComboBox()
        Me.agetxt = New System.Windows.Forms.NumericUpDown()
        Me.datetxt = New System.Windows.Forms.DateTimePicker()
        Me.Role = New System.Windows.Forms.GroupBox()
        Me.Player = New System.Windows.Forms.RadioButton()
        Me.coach = New System.Windows.Forms.RadioButton()
        Me.Position = New System.Windows.Forms.GroupBox()
        Me.g1 = New System.Windows.Forms.RadioButton()
        Me.d1 = New System.Windows.Forms.RadioButton()
        Me.m1 = New System.Windows.Forms.RadioButton()
        Me.s1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmailGen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MedicalInfo = New System.Windows.Forms.GroupBox()
        Me.EDtxt = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FootballlClubDataSet = New FootBallApp.FootballlClubDataSet()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New FootBallApp.FootballlClubDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New FootBallApp.FootballlClubDataSetTableAdapters.TableAdapterManager()
        Me.MedicalDetailsTableAdapter = New FootBallApp.FootballlClubDataSetTableAdapters.MedicalDetailsTableAdapter()
        Me.MedicalDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTtxt = New System.Windows.Forms.ComboBox()
        CType(Me.agetxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Role.SuspendLayout()
        Me.Position.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MedicalInfo.SuspendLayout()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Join Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Email"
        '
        'IDtxt
        '
        Me.IDtxt.Location = New System.Drawing.Point(80, 20)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.Size = New System.Drawing.Size(100, 20)
        Me.IDtxt.TabIndex = 9
        '
        'FnameTXT
        '
        Me.FnameTXT.Location = New System.Drawing.Point(80, 46)
        Me.FnameTXT.Name = "FnameTXT"
        Me.FnameTXT.Size = New System.Drawing.Size(100, 20)
        Me.FnameTXT.TabIndex = 10
        '
        'LNametxt
        '
        Me.LNametxt.Location = New System.Drawing.Point(80, 76)
        Me.LNametxt.Name = "LNametxt"
        Me.LNametxt.Size = New System.Drawing.Size(100, 20)
        Me.LNametxt.TabIndex = 11
        '
        'etxt
        '
        Me.etxt.Location = New System.Drawing.Point(80, 118)
        Me.etxt.Name = "etxt"
        Me.etxt.Size = New System.Drawing.Size(231, 20)
        Me.etxt.TabIndex = 17
        '
        'gendertxt
        '
        Me.gendertxt.FormattingEnabled = True
        Me.gendertxt.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.gendertxt.Location = New System.Drawing.Point(271, 20)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(120, 21)
        Me.gendertxt.TabIndex = 18
        Me.gendertxt.Text = "Male"
        '
        'agetxt
        '
        Me.agetxt.Location = New System.Drawing.Point(271, 50)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(120, 20)
        Me.agetxt.TabIndex = 19
        '
        'datetxt
        '
        Me.datetxt.Location = New System.Drawing.Point(271, 80)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(120, 20)
        Me.datetxt.TabIndex = 20
        '
        'Role
        '
        Me.Role.Controls.Add(Me.Player)
        Me.Role.Controls.Add(Me.coach)
        Me.Role.Location = New System.Drawing.Point(12, 244)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(200, 100)
        Me.Role.TabIndex = 21
        Me.Role.TabStop = False
        Me.Role.Text = "Role"
        '
        'Player
        '
        Me.Player.AutoSize = True
        Me.Player.Location = New System.Drawing.Point(17, 59)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(54, 17)
        Me.Player.TabIndex = 1
        Me.Player.TabStop = True
        Me.Player.Text = "Player"
        Me.Player.UseVisualStyleBackColor = True
        '
        'coach
        '
        Me.coach.AutoSize = True
        Me.coach.Location = New System.Drawing.Point(17, 20)
        Me.coach.Name = "coach"
        Me.coach.Size = New System.Drawing.Size(56, 17)
        Me.coach.TabIndex = 0
        Me.coach.TabStop = True
        Me.coach.Text = "Coach"
        Me.coach.UseVisualStyleBackColor = True
        '
        'Position
        '
        Me.Position.Controls.Add(Me.g1)
        Me.Position.Controls.Add(Me.d1)
        Me.Position.Controls.Add(Me.m1)
        Me.Position.Controls.Add(Me.s1)
        Me.Position.Location = New System.Drawing.Point(241, 244)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(209, 100)
        Me.Position.TabIndex = 22
        Me.Position.TabStop = False
        Me.Position.Text = "Position"
        '
        'g1
        '
        Me.g1.AutoSize = True
        Me.g1.Location = New System.Drawing.Point(110, 59)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(81, 17)
        Me.g1.TabIndex = 3
        Me.g1.TabStop = True
        Me.g1.Text = "GoalKeeper"
        Me.g1.UseVisualStyleBackColor = True
        '
        'd1
        '
        Me.d1.AutoSize = True
        Me.d1.Location = New System.Drawing.Point(110, 20)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(69, 17)
        Me.d1.TabIndex = 2
        Me.d1.TabStop = True
        Me.d1.Text = "Defender"
        Me.d1.UseVisualStyleBackColor = True
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.Location = New System.Drawing.Point(6, 58)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(79, 17)
        Me.m1.TabIndex = 1
        Me.m1.TabStop = True
        Me.m1.Text = "MiddFeilder"
        Me.m1.UseVisualStyleBackColor = True
        '
        's1
        '
        Me.s1.AutoSize = True
        Me.s1.Location = New System.Drawing.Point(6, 20)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(55, 17)
        Me.s1.TabIndex = 0
        Me.s1.TabStop = True
        Me.s1.Text = "Striker"
        Me.s1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EmailGen)
        Me.Panel1.Controls.Add(Me.IDtxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.FnameTXT)
        Me.Panel1.Controls.Add(Me.etxt)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.datetxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.agetxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.gendertxt)
        Me.Panel1.Controls.Add(Me.LNametxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 214)
        Me.Panel1.TabIndex = 23
        '
        'EmailGen
        '
        Me.EmailGen.Location = New System.Drawing.Point(317, 116)
        Me.EmailGen.Name = "EmailGen"
        Me.EmailGen.Size = New System.Drawing.Size(112, 22)
        Me.EmailGen.TabIndex = 21
        Me.EmailGen.Text = "Auto Generate Email"
        Me.EmailGen.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(598, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MedicalInfo
        '
        Me.MedicalInfo.Controls.Add(Me.BTtxt)
        Me.MedicalInfo.Controls.Add(Me.EDtxt)
        Me.MedicalInfo.Controls.Add(Me.Label9)
        Me.MedicalInfo.Controls.Add(Me.Label8)
        Me.MedicalInfo.Location = New System.Drawing.Point(477, 13)
        Me.MedicalInfo.Name = "MedicalInfo"
        Me.MedicalInfo.Size = New System.Drawing.Size(196, 331)
        Me.MedicalInfo.TabIndex = 26
        Me.MedicalInfo.TabStop = False
        Me.MedicalInfo.Text = "Medical Information"
        '
        'EDtxt
        '
        Me.EDtxt.Location = New System.Drawing.Point(13, 92)
        Me.EDtxt.Name = "EDtxt"
        Me.EDtxt.Size = New System.Drawing.Size(177, 233)
        Me.EDtxt.TabIndex = 2
        Me.EDtxt.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Extra Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Blood Type "
        '
        'FootballlClubDataSet
        '
        Me.FootballlClubDataSet.DataSetName = "FootballlClubDataSet"
        Me.FootballlClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.FootballlClubDataSet
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CoachLoginTableAdapter = Nothing
        Me.TableAdapterManager.LineUpTableAdapter = Nothing
        Me.TableAdapterManager.MatchsTableAdapter = Nothing
        Me.TableAdapterManager.MedicalDetailsTableAdapter = Me.MedicalDetailsTableAdapter
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = FootBallApp.FootballlClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MedicalDetailsTableAdapter
        '
        Me.MedicalDetailsTableAdapter.ClearBeforeFill = True
        '
        'MedicalDetailsBindingSource
        '
        Me.MedicalDetailsBindingSource.DataMember = "MedicalDetails"
        Me.MedicalDetailsBindingSource.DataSource = Me.FootballlClubDataSet
        '
        'BTtxt
        '
        Me.BTtxt.FormattingEnabled = True
        Me.BTtxt.Items.AddRange(New Object() {"O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"})
        Me.BTtxt.Location = New System.Drawing.Point(10, 37)
        Me.BTtxt.Name = "BTtxt"
        Me.BTtxt.Size = New System.Drawing.Size(180, 21)
        Me.BTtxt.TabIndex = 3
        '
        'AddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 415)
        Me.Controls.Add(Me.MedicalInfo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Position)
        Me.Controls.Add(Me.Role)
        Me.Name = "AddMember"
        Me.Text = "AddMember"
        CType(Me.agetxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Role.ResumeLayout(False)
        Me.Role.PerformLayout()
        Me.Position.ResumeLayout(False)
        Me.Position.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MedicalInfo.ResumeLayout(False)
        Me.MedicalInfo.PerformLayout()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents IDtxt As TextBox
    Friend WithEvents FnameTXT As TextBox
    Friend WithEvents LNametxt As TextBox
    Friend WithEvents etxt As TextBox
    Friend WithEvents gendertxt As ComboBox
    Friend WithEvents agetxt As NumericUpDown
    Friend WithEvents datetxt As DateTimePicker
    Friend WithEvents Role As GroupBox
    Friend WithEvents Player As RadioButton
    Friend WithEvents coach As RadioButton
    Friend WithEvents Position As GroupBox
    Friend WithEvents g1 As RadioButton
    Friend WithEvents d1 As RadioButton
    Friend WithEvents m1 As RadioButton
    Friend WithEvents s1 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents EmailGen As Button
    Friend WithEvents MedicalInfo As GroupBox
    Friend WithEvents EDtxt As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FootballlClubDataSet As FootballlClubDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As FootballlClubDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As FootballlClubDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicalDetailsTableAdapter As FootballlClubDataSetTableAdapters.MedicalDetailsTableAdapter
    Friend WithEvents MedicalDetailsBindingSource As BindingSource
    Friend WithEvents BTtxt As ComboBox
End Class
