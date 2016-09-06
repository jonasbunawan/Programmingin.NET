Public Class AddCard
    Private Sub AddCardButton_Click(sender As System.Object, e As System.EventArgs) Handles AddCardButton.Click
        CardSuit()
        CardValue()
        Me.Close()
    End Sub

    Private Sub CardSuit()
        If HeartsRadioButton.Checked Then
            CardGameMainMenu.vcCardSuit = HeartsRadioButton.Text
        ElseIf ClubsRadioButton.Checked Then
            CardGameMainMenu.vcCardSuit = ClubsRadioButton.Text
        ElseIf SpadesRadioButton.Checked Then
            CardGameMainMenu.vcCardSuit = SpadesRadioButton.Text
        ElseIf DiamondsRadioButton.Checked Then
            CardGameMainMenu.vcCardSuit = DiamondsRadioButton.Text
        End If
    End Sub

    Private Sub CardValue()
        If RadioButton1.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton3.Text
        ElseIf RadioButton4.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton4.Text
        ElseIf RadioButton5.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton5.Text
        ElseIf RadioButton6.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton6.Text
        ElseIf RadioButton7.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton7.Text
        ElseIf RadioButton8.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton8.Text
        ElseIf RadioButton9.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton9.Text
        ElseIf RadioButton10.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton10.Text
        ElseIf RadioButton11.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton11.Text
        ElseIf RadioButton12.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton12.Text
        ElseIf RadioButton13.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton13.Text
        ElseIf RadioButton14.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton14.Text
        ElseIf RadioButton15.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton15.Text
        ElseIf RadioButton16.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton16.Text
        ElseIf RadioButton17.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton17.Text
        ElseIf RadioButton18.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton18.Text
        ElseIf RadioButton19.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton19.Text
        ElseIf RadioButton20.Checked Then
            CardGameMainMenu.vcCardValue = RadioButton20.Text
        End If
    End Sub
End Class