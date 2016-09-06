<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.ProceedingButton = New System.Windows.Forms.Button()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProceedingButton
        '
        Me.ProceedingButton.Location = New System.Drawing.Point(75, 138)
        Me.ProceedingButton.Name = "ProceedingButton"
        Me.ProceedingButton.Size = New System.Drawing.Size(127, 43)
        Me.ProceedingButton.TabIndex = 0
        Me.ProceedingButton.Text = "Click To Proceed"
        Me.ProceedingButton.UseVisualStyleBackColor = True
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Location = New System.Drawing.Point(47, 94)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(199, 13)
        Me.WelcomeLabel.TabIndex = 1
        Me.WelcomeLabel.Text = "Welcome to Falcon Financial Application"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.ProceedingButton)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProceedingButton As System.Windows.Forms.Button
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
End Class
