' Title:    INF20013 Business Systems Programming in .NET - Assignment 3
' Due Date: Monday, 27th October 2014 08:30 AM
' Author:   700513X - Jonas Bunawan

Public Class Form3

    ' Event Handler that handles data filling into existing datagridview when the form is loaded. Student data will be uploaded.
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ass3DataSet.STUDENT' table. You can move, or remove it, as needed.
        Me.STUDENTTableAdapter.Fill(Me.Ass3DataSet.STUDENT)
    End Sub

    ' Event Handler that handles form closing. When Exit button is clicked by the user, Sub-Application will be closed.
    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub
    ' Event Handler that handles data update. When Save button is clicked by the user, Sub-Application will update relevant database based
    ' on any changes on the datagridview.
    Private Sub Save_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_Btn.Click
        Me.STUDENTTableAdapter.Update(Me.Ass3DataSet.STUDENT)
    End Sub
End Class