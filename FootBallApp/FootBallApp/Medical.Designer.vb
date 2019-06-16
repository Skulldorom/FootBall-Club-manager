<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medical
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Injtxt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Extradettxt = New System.Windows.Forms.RichTextBox()
        Me.IDTxt = New System.Windows.Forms.TextBox()
        Me.BTtxt = New System.Windows.Forms.TextBox()
        Me.Injured = New System.Windows.Forms.TextBox()
        Me.RecUP = New System.Windows.Forms.Button()
        Me.RecDown = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InjuredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtraDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FootballlClubDataSet = New FootBallApp.FootballlClubDataSet()
        Me.MedicalDetailsTableAdapter = New FootBallApp.FootballlClubDataSetTableAdapters.MedicalDetailsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(937, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(937, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Append Details"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(789, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(789, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Blood Type"
        '
        'Injtxt
        '
        Me.Injtxt.AutoSize = True
        Me.Injtxt.Location = New System.Drawing.Point(789, 130)
        Me.Injtxt.Name = "Injtxt"
        Me.Injtxt.Size = New System.Drawing.Size(39, 13)
        Me.Injtxt.TabIndex = 5
        Me.Injtxt.Text = "Injured"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(789, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Extra Details"
        '
        'Extradettxt
        '
        Me.Extradettxt.Location = New System.Drawing.Point(792, 186)
        Me.Extradettxt.Name = "Extradettxt"
        Me.Extradettxt.Size = New System.Drawing.Size(204, 96)
        Me.Extradettxt.TabIndex = 7
        Me.Extradettxt.Text = ""
        '
        'IDTxt
        '
        Me.IDTxt.Location = New System.Drawing.Point(792, 67)
        Me.IDTxt.Name = "IDTxt"
        Me.IDTxt.Size = New System.Drawing.Size(100, 20)
        Me.IDTxt.TabIndex = 8
        '
        'BTtxt
        '
        Me.BTtxt.Location = New System.Drawing.Point(792, 107)
        Me.BTtxt.Name = "BTtxt"
        Me.BTtxt.Size = New System.Drawing.Size(100, 20)
        Me.BTtxt.TabIndex = 9
        '
        'Injured
        '
        Me.Injured.Location = New System.Drawing.Point(792, 146)
        Me.Injured.Name = "Injured"
        Me.Injured.Size = New System.Drawing.Size(100, 20)
        Me.Injured.TabIndex = 10
        '
        'RecUP
        '
        Me.RecUP.Location = New System.Drawing.Point(937, 116)
        Me.RecUP.Name = "RecUP"
        Me.RecUP.Size = New System.Drawing.Size(50, 50)
        Me.RecUP.TabIndex = 11
        Me.RecUP.Text = "▼"
        Me.RecUP.UseVisualStyleBackColor = True
        '
        'RecDown
        '
        Me.RecDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecDown.Location = New System.Drawing.Point(937, 67)
        Me.RecDown.Name = "RecDown"
        Me.RecDown.Size = New System.Drawing.Size(50, 50)
        Me.RecDown.TabIndex = 12
        Me.RecDown.Text = "▲"
        Me.RecDown.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.BloodTypeDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.InjuredDataGridViewTextBoxColumn, Me.ExtraDetailsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicalDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(770, 489)
        Me.DataGridView1.TabIndex = 13
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
        'BloodTypeDataGridViewTextBoxColumn
        '
        Me.BloodTypeDataGridViewTextBoxColumn.DataPropertyName = "Blood Type"
        Me.BloodTypeDataGridViewTextBoxColumn.HeaderText = "Blood Type"
        Me.BloodTypeDataGridViewTextBoxColumn.Name = "BloodTypeDataGridViewTextBoxColumn"
        Me.BloodTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InjuredDataGridViewTextBoxColumn
        '
        Me.InjuredDataGridViewTextBoxColumn.DataPropertyName = "Injured"
        Me.InjuredDataGridViewTextBoxColumn.HeaderText = "Injured"
        Me.InjuredDataGridViewTextBoxColumn.Name = "InjuredDataGridViewTextBoxColumn"
        Me.InjuredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExtraDetailsDataGridViewTextBoxColumn
        '
        Me.ExtraDetailsDataGridViewTextBoxColumn.DataPropertyName = "Extra Details"
        Me.ExtraDetailsDataGridViewTextBoxColumn.HeaderText = "Extra Details"
        Me.ExtraDetailsDataGridViewTextBoxColumn.Name = "ExtraDetailsDataGridViewTextBoxColumn"
        Me.ExtraDetailsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicalDetailsBindingSource
        '
        Me.MedicalDetailsBindingSource.DataMember = "MedicalDetails"
        Me.MedicalDetailsBindingSource.DataSource = Me.FootballlClubDataSet
        '
        'FootballlClubDataSet
        '
        Me.FootballlClubDataSet.DataSetName = "FootballlClubDataSet"
        Me.FootballlClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicalDetailsTableAdapter
        '
        Me.MedicalDetailsTableAdapter.ClearBeforeFill = True
        '
        'Medical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 514)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RecDown)
        Me.Controls.Add(Me.RecUP)
        Me.Controls.Add(Me.Injured)
        Me.Controls.Add(Me.BTtxt)
        Me.Controls.Add(Me.IDTxt)
        Me.Controls.Add(Me.Extradettxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Injtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Medical"
        Me.Text = "Medical"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FootballlClubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Injtxt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Extradettxt As RichTextBox
    Friend WithEvents IDTxt As TextBox
    Friend WithEvents BTtxt As TextBox
    Friend WithEvents Injured As TextBox
    Friend WithEvents RecUP As Button
    Friend WithEvents RecDown As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FootballlClubDataSet As FootballlClubDataSet
    Friend WithEvents MedicalDetailsBindingSource As BindingSource
    Friend WithEvents MedicalDetailsTableAdapter As FootballlClubDataSetTableAdapters.MedicalDetailsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InjuredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtraDetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
