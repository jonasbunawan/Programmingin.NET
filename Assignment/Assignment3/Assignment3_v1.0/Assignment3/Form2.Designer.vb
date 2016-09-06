<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.StuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ass3DataSet = New Assignment3.Ass3DataSet()
        Me.RESULTTableAdapter = New Assignment3.Ass3DataSetTableAdapters.RESULTTableAdapter()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESULTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ass3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StuIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.UnitCodeDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RESULTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'StuIDDataGridViewTextBoxColumn
        '
        Me.StuIDDataGridViewTextBoxColumn.DataPropertyName = "StuID"
        Me.StuIDDataGridViewTextBoxColumn.HeaderText = "StuID"
        Me.StuIDDataGridViewTextBoxColumn.Name = "StuIDDataGridViewTextBoxColumn"
        Me.StuIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitCodeDataGridViewTextBoxColumn
        '
        Me.UnitCodeDataGridViewTextBoxColumn.DataPropertyName = "UnitCode"
        Me.UnitCodeDataGridViewTextBoxColumn.HeaderText = "UnitCode"
        Me.UnitCodeDataGridViewTextBoxColumn.Name = "UnitCodeDataGridViewTextBoxColumn"
        Me.UnitCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RESULTBindingSource
        '
        Me.RESULTBindingSource.DataMember = "RESULT"
        Me.RESULTBindingSource.DataSource = Me.Ass3DataSet
        '
        'Ass3DataSet
        '
        Me.Ass3DataSet.DataSetName = "Ass3DataSet"
        Me.Ass3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RESULTTableAdapter
        '
        Me.RESULTTableAdapter.ClearBeforeFill = True
        '
        'Exit_Btn
        '
        Me.Exit_Btn.Location = New System.Drawing.Point(256, 169)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Btn.TabIndex = 1
        Me.Exit_Btn.Text = "Exit"
        Me.Exit_Btn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 198)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESULTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ass3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Ass3DataSet As Assignment3.Ass3DataSet
    Friend WithEvents RESULTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RESULTTableAdapter As Assignment3.Ass3DataSetTableAdapters.RESULTTableAdapter
    Friend WithEvents StuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
End Class
