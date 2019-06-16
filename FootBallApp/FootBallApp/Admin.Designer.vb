<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.MDBtn = New System.Windows.Forms.Button()
        Me.HAbtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What would you like to do?"
        '
        'MDBtn
        '
        Me.MDBtn.Location = New System.Drawing.Point(11, 43)
        Me.MDBtn.Name = "MDBtn"
        Me.MDBtn.Size = New System.Drawing.Size(75, 38)
        Me.MDBtn.TabIndex = 1
        Me.MDBtn.Text = "Medical Details"
        Me.MDBtn.UseVisualStyleBackColor = True
        '
        'HAbtn
        '
        Me.HAbtn.Location = New System.Drawing.Point(102, 43)
        Me.HAbtn.Name = "HAbtn"
        Me.HAbtn.Size = New System.Drawing.Size(75, 38)
        Me.HAbtn.TabIndex = 2
        Me.HAbtn.Text = "Handle Account/s"
        Me.HAbtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(11, 87)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(166, 23)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(195, 117)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.HAbtn)
        Me.Controls.Add(Me.MDBtn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MDBtn As Button
    Friend WithEvents HAbtn As Button
    Friend WithEvents CancelBtn As Button
End Class
