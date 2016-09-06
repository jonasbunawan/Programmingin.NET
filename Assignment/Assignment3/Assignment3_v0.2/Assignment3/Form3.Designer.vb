<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.SubjectsPassedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ass3DataSet = New Assignment3.Ass3DataSet()
        Me.STUDENTTableAdapter = New Assignment3.Ass3DataSetTableAdapters.STUDENTTableAdapter()
        Me.Exit_Btn = New System.Windows.Forms.Button()
        Me.Save_Btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ass3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StuIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SubjectsPassedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.STUDENTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 150)
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
        '
        'SubjectsPassedDataGridViewTextBoxColumn
        '
        Me.SubjectsPassedDataGridViewTextBoxColumn.DataPropertyName = "SubjectsPassed"
        Me.SubjectsPassedDataGridViewTextBoxColumn.HeaderText = "SubjectsPassed"
        Me.SubjectsPassedDataGridViewTextBoxColumn.Name = "SubjectsPassedDataGridViewTextBoxColumn"
        Me.SubjectsPassedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STUDENTBindingSource
        '
        Me.STUDENTBindingSource.DataMember = "STUDENT"
        Me.STUDENTBindingSource.DataSource = Me.Ass3DataSet
        '
        'Ass3DataSet
        '
        Me.Ass3DataSet.DataSetName = "Ass3DataSet"
        Me.Ass3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'Exit_Btn
        '
        Me.Exit_Btn.Location = New System.Drawing.Point(282, 169)
        Me.Exit_Btn.Name = "Exit_Btn"
        Me.Exit_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Btn.TabIndex = 1
        Me.Exit_Btn.Text = "Exit"
        Me.Exit_Btn.UseVisualStyleBackColor = True
        '
        'Save_Btn
        '
        Me.Save_Btn.Location = New System.Drawing.Point(13, 169)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Save_Btn.TabIndex = 2
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 200)
        Me.Controls.Add(Me.Save_Btn)
        Me.Controls.Add(Me.Exit_Btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ass3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Ass3DataSet As Assignment3.Ass3DataSet
    Friend WithEvents STUDENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STUDENTTableAdapter As Assignment3.Ass3DataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents StuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectsPassedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exit_Btn As System.Windows.Forms.Button
    Friend WithEvents Save_Btn As System.Windows.Forms.Button
End Class
