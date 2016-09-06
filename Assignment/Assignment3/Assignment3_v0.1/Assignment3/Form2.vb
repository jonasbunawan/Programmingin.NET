Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ass3DataSet.RESULT' table. You can move, or remove it, as needed.
        Me.RESULTTableAdapter.Fill(Me.Ass3DataSet.RESULT)

    End Sub

    Private Sub Exit_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Btn.Click
        Me.Close()
    End Sub
End Class