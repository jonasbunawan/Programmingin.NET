' Title:    INF20013 Business Systems Programming in .NET - Assignment 3
' Due Date: Monday, 27th October 2014 08:30 AM
' Author:   700513X - Jonas Bunawan

Public Class Form2

#Region "Event Handlers"
    ' Event Handler that handles data filling into existing datagridview when the form is loaded. Result data will be uploaded.
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ass3DataSet.RESULT' table. You can move, or remove it, as needed.
        Me.RESULTTableAdapter.Fill(Me.Ass3DataSet.RESULT)
    End Sub

    ' Event Handler that handles form closing. When Exit button is clicked by the user, Sub-Application will be closed.
    Private Sub Exit_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub
#End Region

End Class