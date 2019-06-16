<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Team
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LineUpDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FootballlClubDataSet = New FootBallApp.FootballlClubDataSet()
        Me.AddPlayer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RemovePlayer = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RecDown = New System.Windows.Forms.Button()
        Me.RecUp = New System.Windows.Forms.Button()
        Me.LineUpTableAdapter = New FootBallApp.FootballlClubDataSetTableAdapters.LineUpTableAdapter()
        CType(Me.LineUpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 69)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LineUpDataGridView
        '
        Me.LineUpDataGridView.AllowUserToAddRows = False
        Me.LineUpDataGridView.AllowUserToDeleteRows = False
        Me.LineUpDataGridView.AutoGenerateColumns = False
        Me.LineUpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LineUpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn})
        Me.LineUpDataGridView.DataSource = Me.LineUpBindingSource
        Me.LineUpDataGridView.Location = New System.Drawing.Point(2, 12)
        Me.LineUpDataGridView.Name = "LineUpDataGridView"
        Me.LineUpDataGridView.ReadOnly = True
        Me.LineUpDataGridView.Size = New System.Drawing.Size(344, 565)
        Me.LineUpDataGridView.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LineUpBindingSource
        '
        Me.LineUpBindingSource.DataMember = "LineUp"
        Me.LineUpBindingSource.DataSource = Me.FootballlClubDataSet
        '
        'FootballlClubDataSet
        '
        Me.FootballlClubDataSet.DataSetName = "FootballlClubDataSet"
        Me.FootballlClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddPlayer
        '
        Me.AddPlayer.Location = New System.Drawing.Point(366, 365)
        Me.AddPlayer.Name = "AddPlayer"
        Me.AddPlayer.Size = New System.Drawing.Size(117, 57)
        Me.AddPlayer.TabIndex = 2
        Me.AddPlayer.Text = "Add"
        Me.AddPlayer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Position"
        '
        'RemovePlayer
        '
        Me.RemovePlayer.Location = New System.Drawing.Point(366, 435)
        Me.RemovePlayer.Name = "RemovePlayer"
        Me.RemovePlayer.Size = New System.Drawing.Size(117, 57)
        Me.RemovePlayer.TabIndex = 6
        Me.RemovePlayer.Text = "Remove"
        Me.RemovePlayer.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(366, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(366, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(366, 130)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 9
        '
        'RecDown
        '
        Me.RecDown.Location = New System.Drawing.Point(366, 172)
        Me.RecDown.Name = "RecDown"
        Me.RecDown.Size = New System.Drawing.Size(50, 50)
        Me.RecDown.TabIndex = 10
        Me.RecDown.Text = "◄"
        Me.RecDown.UseVisualStyleBackColor = True
        '
        'RecUp
        '
        Me.RecUp.Location = New System.Drawing.Point(416, 172)
        Me.RecUp.Name = "RecUp"
        Me.RecUp.Size = New System.Drawing.Size(50, 50)
        Me.RecUp.TabIndex = 11
        Me.RecUp.Text = "►"
        Me.RecUp.UseVisualStyleBackColor = True
        '
        'LineUpTableAdapter
        '
        Me.LineUpTableAdapter.ClearBeforeFill = True
        '
        'Team
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 579)
        Me.Controls.Add(Me.RecUp)
        Me.Controls.Add(Me.RecDown)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RemovePlayer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddPlayer)
        Me.Controls.Add(Me.LineUpDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Team"
        Me.Text = "Team"
        CType(Me.LineUpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LineUpDataGridView As DataGridView
    Friend WithEvents AddPlayer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RemovePlayer As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RecDown As Button
    Friend WithEvents RecUp As Button
    Friend WithEvents FootballlClubDataSet As FootballlClubDataSet
    Friend WithEvents LineUpBindingSource As BindingSource
    Friend WithEvents LineUpTableAdapter As FootballlClubDataSetTableAdapters.LineUpTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
