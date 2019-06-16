<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.MemBTn = New System.Windows.Forms.ToolStripButton()
        Me.TBtn = New System.Windows.Forms.ToolStripButton()
        Me.MBtn = New System.Windows.Forms.ToolStripButton()
        Me.LoginBtn = New System.Windows.Forms.ToolStripButton()
        Me.AboBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.Time = New System.Windows.Forms.Label()
        Me.DateLBl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemBTn, Me.TBtn, Me.MBtn, Me.LoginBtn, Me.AboBtn, Me.ToolStripButton1, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1493, 50)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'MemBTn
        '
        Me.MemBTn.Image = CType(resources.GetObject("MemBTn.Image"), System.Drawing.Image)
        Me.MemBTn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MemBTn.Name = "MemBTn"
        Me.MemBTn.Size = New System.Drawing.Size(77, 47)
        Me.MemBTn.Text = "Members"
        '
        'TBtn
        '
        Me.TBtn.Image = CType(resources.GetObject("TBtn.Image"), System.Drawing.Image)
        Me.TBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBtn.Name = "TBtn"
        Me.TBtn.Size = New System.Drawing.Size(89, 47)
        Me.TBtn.Text = "Team Setup"
        '
        'MBtn
        '
        Me.MBtn.Image = CType(resources.GetObject("MBtn.Image"), System.Drawing.Image)
        Me.MBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MBtn.Name = "MBtn"
        Me.MBtn.Size = New System.Drawing.Size(72, 47)
        Me.MBtn.Text = "Matches"
        '
        'LoginBtn
        '
        Me.LoginBtn.Image = CType(resources.GetObject("LoginBtn.Image"), System.Drawing.Image)
        Me.LoginBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(94, 47)
        Me.LoginBtn.Text = "Coach Login"
        '
        'AboBtn
        '
        Me.AboBtn.Image = CType(resources.GetObject("AboBtn.Image"), System.Drawing.Image)
        Me.AboBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboBtn.Name = "AboBtn"
        Me.AboBtn.Size = New System.Drawing.Size(60, 47)
        Me.AboBtn.Text = "About"
        '
        'ExitBtn
        '
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(45, 47)
        Me.ExitBtn.Text = "Exit"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Time.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Time.Location = New System.Drawing.Point(1415, 9)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(30, 13)
        Me.Time.TabIndex = 2
        Me.Time.Text = "Time"
        '
        'DateLBl
        '
        Me.DateLBl.AutoSize = True
        Me.DateLBl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DateLBl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateLBl.Location = New System.Drawing.Point(1415, 27)
        Me.DateLBl.Name = "DateLBl"
        Me.DateLBl.Size = New System.Drawing.Size(30, 13)
        Me.DateLBl.TabIndex = 3
        Me.DateLBl.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 47)
        Me.ToolStripButton1.Text = "Close All"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1493, 898)
        Me.Controls.Add(Me.DateLBl)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Football Club Manager"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents MemBTn As ToolStripButton
    Friend WithEvents TBtn As ToolStripButton
    Friend WithEvents MBtn As ToolStripButton
    Friend WithEvents AboBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents Time As Label
    Friend WithEvents DateLBl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LoginBtn As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
