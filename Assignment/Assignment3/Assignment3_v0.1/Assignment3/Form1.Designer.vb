<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Task3RestoretoDefault_Btn = New System.Windows.Forms.Button()
        Me.Task4Transaction_Btn = New System.Windows.Forms.Button()
        Me.Task5DisplayLogFile_Btn = New System.Windows.Forms.Button()
        Me.DisplayLogFile_RTBx = New System.Windows.Forms.RichTextBox()
        Me.Task6DisplayResults_Btn = New System.Windows.Forms.Button()
        Me.Task7DisplayStudentData_Btn = New System.Windows.Forms.Button()
        Me.Task8GenerateExcel_Btn = New System.Windows.Forms.Button()
        Me.Task9DumpStudentData_Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Task3RestoretoDefault_Btn
        '
        Me.Task3RestoretoDefault_Btn.Location = New System.Drawing.Point(30, 12)
        Me.Task3RestoretoDefault_Btn.Name = "Task3RestoretoDefault_Btn"
        Me.Task3RestoretoDefault_Btn.Size = New System.Drawing.Size(208, 41)
        Me.Task3RestoretoDefault_Btn.TabIndex = 0
        Me.Task3RestoretoDefault_Btn.Text = "Task 3. Restore to Default"
        Me.Task3RestoretoDefault_Btn.UseVisualStyleBackColor = True
        '
        'Task4Transaction_Btn
        '
        Me.Task4Transaction_Btn.Location = New System.Drawing.Point(30, 59)
        Me.Task4Transaction_Btn.Name = "Task4Transaction_Btn"
        Me.Task4Transaction_Btn.Size = New System.Drawing.Size(208, 43)
        Me.Task4Transaction_Btn.TabIndex = 1
        Me.Task4Transaction_Btn.Text = "Task 4. Transaction"
        Me.Task4Transaction_Btn.UseVisualStyleBackColor = True
        '
        'Task5DisplayLogFile_Btn
        '
        Me.Task5DisplayLogFile_Btn.Location = New System.Drawing.Point(30, 109)
        Me.Task5DisplayLogFile_Btn.Name = "Task5DisplayLogFile_Btn"
        Me.Task5DisplayLogFile_Btn.Size = New System.Drawing.Size(208, 50)
        Me.Task5DisplayLogFile_Btn.TabIndex = 2
        Me.Task5DisplayLogFile_Btn.Text = "Task 5. Display Log File"
        Me.Task5DisplayLogFile_Btn.UseVisualStyleBackColor = True
        '
        'DisplayLogFile_RTBx
        '
        Me.DisplayLogFile_RTBx.Location = New System.Drawing.Point(30, 166)
        Me.DisplayLogFile_RTBx.Name = "DisplayLogFile_RTBx"
        Me.DisplayLogFile_RTBx.Size = New System.Drawing.Size(208, 115)
        Me.DisplayLogFile_RTBx.TabIndex = 3
        Me.DisplayLogFile_RTBx.Text = ""
        '
        'Task6DisplayResults_Btn
        '
        Me.Task6DisplayResults_Btn.Location = New System.Drawing.Point(30, 287)
        Me.Task6DisplayResults_Btn.Name = "Task6DisplayResults_Btn"
        Me.Task6DisplayResults_Btn.Size = New System.Drawing.Size(208, 50)
        Me.Task6DisplayResults_Btn.TabIndex = 4
        Me.Task6DisplayResults_Btn.Text = "Task 6. Display Results"
        Me.Task6DisplayResults_Btn.UseVisualStyleBackColor = True
        '
        'Task7DisplayStudentData_Btn
        '
        Me.Task7DisplayStudentData_Btn.Location = New System.Drawing.Point(30, 343)
        Me.Task7DisplayStudentData_Btn.Name = "Task7DisplayStudentData_Btn"
        Me.Task7DisplayStudentData_Btn.Size = New System.Drawing.Size(208, 50)
        Me.Task7DisplayStudentData_Btn.TabIndex = 5
        Me.Task7DisplayStudentData_Btn.Text = "Task 7. Display Student Data"
        Me.Task7DisplayStudentData_Btn.UseVisualStyleBackColor = True
        '
        'Task8GenerateExcel_Btn
        '
        Me.Task8GenerateExcel_Btn.Location = New System.Drawing.Point(30, 399)
        Me.Task8GenerateExcel_Btn.Name = "Task8GenerateExcel_Btn"
        Me.Task8GenerateExcel_Btn.Size = New System.Drawing.Size(208, 50)
        Me.Task8GenerateExcel_Btn.TabIndex = 6
        Me.Task8GenerateExcel_Btn.Text = "Task 8. Generate Excel"
        Me.Task8GenerateExcel_Btn.UseVisualStyleBackColor = True
        '
        'Task9DumpStudentData_Btn
        '
        Me.Task9DumpStudentData_Btn.Location = New System.Drawing.Point(30, 455)
        Me.Task9DumpStudentData_Btn.Name = "Task9DumpStudentData_Btn"
        Me.Task9DumpStudentData_Btn.Size = New System.Drawing.Size(208, 50)
        Me.Task9DumpStudentData_Btn.TabIndex = 7
        Me.Task9DumpStudentData_Btn.Text = "Task 9. Dump Student Data"
        Me.Task9DumpStudentData_Btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 515)
        Me.Controls.Add(Me.Task9DumpStudentData_Btn)
        Me.Controls.Add(Me.Task8GenerateExcel_Btn)
        Me.Controls.Add(Me.Task7DisplayStudentData_Btn)
        Me.Controls.Add(Me.Task6DisplayResults_Btn)
        Me.Controls.Add(Me.DisplayLogFile_RTBx)
        Me.Controls.Add(Me.Task5DisplayLogFile_Btn)
        Me.Controls.Add(Me.Task4Transaction_Btn)
        Me.Controls.Add(Me.Task3RestoretoDefault_Btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Task3RestoretoDefault_Btn As System.Windows.Forms.Button
    Friend WithEvents Task4Transaction_Btn As System.Windows.Forms.Button
    Friend WithEvents Task5DisplayLogFile_Btn As System.Windows.Forms.Button
    Friend WithEvents DisplayLogFile_RTBx As System.Windows.Forms.RichTextBox
    Friend WithEvents Task6DisplayResults_Btn As System.Windows.Forms.Button
    Friend WithEvents Task7DisplayStudentData_Btn As System.Windows.Forms.Button
    Friend WithEvents Task8GenerateExcel_Btn As System.Windows.Forms.Button
    Friend WithEvents Task9DumpStudentData_Btn As System.Windows.Forms.Button

End Class
