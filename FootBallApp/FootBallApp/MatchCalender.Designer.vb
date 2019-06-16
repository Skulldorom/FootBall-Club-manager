<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchCalender
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MatchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeGroundDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatchsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FootballlClubDataSet = New FootBallApp.FootballlClubDataSet()
        Me.CloseBTn = New System.Windows.Forms.Button()
        Me.MatchsTableAdapter = New FootBallApp.FootballlClubDataSetTableAdapters.MatchsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatchsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatchIDDataGridViewTextBoxColumn, Me.HomeGroundDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MatchsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(443, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'MatchIDDataGridViewTextBoxColumn
        '
        Me.MatchIDDataGridViewTextBoxColumn.DataPropertyName = "Match ID"
        Me.MatchIDDataGridViewTextBoxColumn.HeaderText = "Match ID"
        Me.MatchIDDataGridViewTextBoxColumn.Name = "MatchIDDataGridViewTextBoxColumn"
        Me.MatchIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HomeGroundDataGridViewTextBoxColumn
        '
        Me.HomeGroundDataGridViewTextBoxColumn.DataPropertyName = "Home Ground"
        Me.HomeGroundDataGridViewTextBoxColumn.HeaderText = "Home Ground"
        Me.HomeGroundDataGridViewTextBoxColumn.Name = "HomeGroundDataGridViewTextBoxColumn"
        Me.HomeGroundDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatchsBindingSource
        '
        Me.MatchsBindingSource.DataMember = "Matchs"
        Me.MatchsBindingSource.DataSource = Me.FootballlClubDataSet
        '
        'FootballlClubDataSet
        '
        Me.FootballlClubDataSet.DataSetName = "FootballlClubDataSet"
        Me.FootballlClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CloseBTn
        '
        Me.CloseBTn.Location = New System.Drawing.Point(473, 369)
        Me.CloseBTn.Name = "CloseBTn"
        Me.CloseBTn.Size = New System.Drawing.Size(75, 69)
        Me.CloseBTn.TabIndex = 1
        Me.CloseBTn.Text = "Close"
        Me.CloseBTn.UseVisualStyleBackColor = True
        '
        'MatchsTableAdapter
        '
        Me.MatchsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 69)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MatchCalender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CloseBTn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MatchCalender"
        Me.Text = "MatchCalender"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatchsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CloseBTn As Button
    Friend WithEvents FootballlClubDataSet As FootballlClubDataSet
    Friend WithEvents MatchsBindingSource As BindingSource
    Friend WithEvents MatchsTableAdapter As FootballlClubDataSetTableAdapters.MatchsTableAdapter
    Friend WithEvents MatchIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomeGroundDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
