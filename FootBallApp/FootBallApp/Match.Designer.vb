<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Match
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RowDIsp = New System.Windows.Forms.TextBox()
        Me.RecUP = New System.Windows.Forms.Button()
        Me.RecDown = New System.Windows.Forms.Button()
        Me.DIsp = New System.Windows.Forms.Button()
        Me.AddBTn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.CLoseBtn = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Match ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Home Ground"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 20)
        Me.TextBox2.TabIndex = 5
        '
        'RowDIsp
        '
        Me.RowDIsp.Location = New System.Drawing.Point(111, 178)
        Me.RowDIsp.Name = "RowDIsp"
        Me.RowDIsp.Size = New System.Drawing.Size(30, 20)
        Me.RowDIsp.TabIndex = 8
        '
        'RecUP
        '
        Me.RecUP.Location = New System.Drawing.Point(84, 175)
        Me.RecUP.Name = "RecUP"
        Me.RecUP.Size = New System.Drawing.Size(25, 25)
        Me.RecUP.TabIndex = 9
        Me.RecUP.Text = "▲"
        Me.RecUP.UseVisualStyleBackColor = True
        '
        'RecDown
        '
        Me.RecDown.Location = New System.Drawing.Point(142, 175)
        Me.RecDown.Name = "RecDown"
        Me.RecDown.Size = New System.Drawing.Size(25, 25)
        Me.RecDown.TabIndex = 10
        Me.RecDown.Text = "▼"
        Me.RecDown.UseVisualStyleBackColor = True
        '
        'DIsp
        '
        Me.DIsp.Location = New System.Drawing.Point(410, 19)
        Me.DIsp.Name = "DIsp"
        Me.DIsp.Size = New System.Drawing.Size(75, 175)
        Me.DIsp.TabIndex = 11
        Me.DIsp.Text = "Display All Matches"
        Me.DIsp.UseVisualStyleBackColor = True
        '
        'AddBTn
        '
        Me.AddBTn.Location = New System.Drawing.Point(299, 63)
        Me.AddBTn.Name = "AddBTn"
        Me.AddBTn.Size = New System.Drawing.Size(75, 23)
        Me.AddBTn.TabIndex = 12
        Me.AddBTn.Text = "Add"
        Me.AddBTn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(299, 101)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 13
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'CLoseBtn
        '
        Me.CLoseBtn.Location = New System.Drawing.Point(410, 206)
        Me.CLoseBtn.Name = "CLoseBtn"
        Me.CLoseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CLoseBtn.TabIndex = 14
        Me.CLoseBtn.Text = "Back"
        Me.CLoseBtn.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(140, 100)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Win", "Loss", "Draw", "Upcoming"})
        Me.ComboBox1.Location = New System.Drawing.Point(140, 134)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Match
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 241)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CLoseBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.AddBTn)
        Me.Controls.Add(Me.DIsp)
        Me.Controls.Add(Me.RecDown)
        Me.Controls.Add(Me.RecUP)
        Me.Controls.Add(Me.RowDIsp)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Match"
        Me.Text = "Match"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RowDIsp As TextBox
    Friend WithEvents RecUP As Button
    Friend WithEvents RecDown As Button
    Friend WithEvents DIsp As Button
    Friend WithEvents AddBTn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents CLoseBtn As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class
