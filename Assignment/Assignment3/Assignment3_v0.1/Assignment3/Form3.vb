Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ass3DataSet.STUDENT' table. You can move, or remove it, as needed.
        Me.STUDENTTableAdapter.Fill(Me.Ass3DataSet.STUDENT)

    End Sub

    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub

    Private Sub Save_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_Btn.Click
        Me.STUDENTTableAdapter.Update(Me.Ass3DataSet.STUDENT)
    End Sub
End Class