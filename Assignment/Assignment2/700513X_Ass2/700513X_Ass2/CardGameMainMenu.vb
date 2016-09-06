Public Class CardGameMainMenu

    Dim rtvGame As New Game
    Public vcCardSuit As String
    Public vcCardValue As Integer

    Private Sub AddPlayerButton_Click(sender As System.Object, e As System.EventArgs) Handles AddPlayerButton.Click
        AddPlayer()
        Message()
    End Sub

    Sub AddPlayer()
        Dim rtvPlayer As New Player(InputBox("Enter Player Name: "))

        If rtvGame.FindPlayer(rtvPlayer) Then
            MessageBox.Show("Player already exists")
            Exit Sub
        Else
            rtvGame.AddPlayer(rtvPlayer)
        End If
    End Sub

    Private Sub AddOneCardButton_Click(sender As System.Object, e As System.EventArgs) Handles AddOneCardButton.Click
        AddCard.ShowDialog()
        AddOneCard()
        Message()
    End Sub

    Sub AddOneCard()
        If rtvGame.Deck.FindCard(vcCardSuit, vcCardValue) Then
            MessageBox.Show("Card already exists")
            Exit Sub
        Else
            Dim rtvCard As New Card(vcCardSuit, vcCardValue)
            rtvGame.Deck.AddCard(rtvCard)
        End If
    End Sub

    Private Sub Add20CardsButton_Click(sender As System.Object, e As System.EventArgs) Handles Add20CardsButton.Click
        Create20DefaultCards()
        Message()
        MessageBox.Show("Successfully created 20 Cards")
    End Sub

    Sub Create20DefaultCards()
        Dim RandomClass As New Random
        Dim vCardValue As Integer

        For Index = 1 To 5
            vCardValue = RandomClass.Next(1, 20)
            Dim rtvCard As New Card("Hearts", vCardValue)
            rtvGame.Deck.AddCard(rtvCard)
        Next

        For Index = 1 To 5
            vCardValue = RandomClass.Next(1, 20)
            Dim rtvCard As New Card("Clubs", vCardValue)
            rtvGame.Deck.AddCard(rtvCard)
        Next

        For Index = 1 To 5
            vCardValue = RandomClass.Next(1, 20)
            Dim rtvCard As New Card("Spades", vCardValue)
            rtvGame.Deck.AddCard(rtvCard)
        Next

        For Index = 1 To 5
            vCardValue = RandomClass.Next(1, 20)
            Dim rtvCard As New Card("Diamonds", vCardValue)
            rtvGame.Deck.AddCard(rtvCard)
        Next
    End Sub

    Private Sub DealaCardButton_Click(sender As System.Object, e As System.EventArgs) Handles DealaCardButton.Click
        DealOneCard()
        Message()
    End Sub

    Sub DealOneCard()
        Dim rtvPlayer As New Player(InputBox("Enter Player Name: "))

        If rtvGame.FindPlayer(rtvPlayer) Then
            rtvGame.DealOneCardToPlayer(rtvGame.GetPlayer(rtvPlayer))
        Else
            MessageBox.Show("Player does not exist")
            Exit Sub
        End If
    End Sub

    Private Sub DealaCardtoeachPlayerButton_Click(sender As System.Object, e As System.EventArgs) Handles DealaCardtoeachPlayerButton.Click
        DealaCardToEachPlayer()
        Message()
    End Sub

    Sub DealaCardToEachPlayer()
        For Each rtvPlayer As Player In rtvGame.PlayerList
            If rtvGame.Deck.Cards.Count >= 1 Then
                rtvGame.DealOneCardToPlayer(rtvGame.GetPlayer(rtvPlayer))
            Else
                Exit Sub
            End If
        Next
    End Sub

    Private Sub RemoveaCardButton_Click(sender As System.Object, e As System.EventArgs) Handles RemoveaCardButton.Click
        RemoveOneCard()
        Message()
    End Sub

    Sub RemoveOneCard()
        Dim rtvPlayer As New Player(InputBox("Enter Player Name: "))

        If rtvGame.FindPlayer(rtvPlayer) Then
            rtvGame.RemoveOneCardFromPlayer(rtvGame.GetPlayer(rtvPlayer))
        Else
            MessageBox.Show("Player does not exist")
            Exit Sub
        End If
    End Sub

    Private Sub RemoveaCardfromeachPlayerButton_Click(sender As System.Object, e As System.EventArgs) Handles RemoveaCardfromeachPlayerButton.Click
        RemoveACardFromEachPlayer()
        Message()
    End Sub

    Sub RemoveACardFromEachPlayer()
        For Each rtvPlayer As Player In rtvGame.PlayerList
            rtvGame.RemoveOneCardFromPlayer(rtvGame.GetPlayer(rtvPlayer))
        Next
    End Sub

    Private Sub DisplayTotalsButton_Click(sender As System.Object, e As System.EventArgs) Handles DisplayTotalsButton.Click
        MessageBox.Show(DisplayTotals(rtvGame.PlayerList))
    End Sub

    Private Function DisplayTotals(ByVal vPlayerList As ArrayList) As String
        Dim vMessage As String = "Totals: " & vbCrLf
        Dim rtvPlayer As New Player

        For Index = 0 To vPlayerList.Count - 1
            rtvPlayer = rtvGame.GetPlayer(vPlayerList.Item(Index))
            vMessage &= vbCrLf & rtvPlayer.Name & Chr(9) & rtvPlayer.Total
        Next

        Return vMessage
    End Function

    Private Sub FindaCardButton_Click(sender As System.Object, e As System.EventArgs) Handles FindaCardButton.Click
        FindaCard()
    End Sub

    Sub FindaCard()
        Dim vCardSuit As String = InputBox("Enter Card Suit: (Hearts, Clubs, Spades, or Diamonds)")
        Dim vCardValue As Integer = Val(InputBox("Enter Card Value: (1-20)"))
        Dim rtvCard As New Card(vCardSuit, vCardValue)
        Dim vPlayerCard As Boolean = False

        For Each rtvPlayer As Player In rtvGame.PlayerList
            If rtvPlayer.FindCard(rtvCard.Suit, rtvCard.NumericValue) Then
                vPlayerCard = True
            End If
        Next

        If rtvGame.Deck.FindCard(rtvCard.Suit, rtvCard.NumericValue) Then
            MessageBox.Show(rtvCard.ShortName & " is not owned by anyone")
        ElseIf vPlayerCard Then
            MessageBox.Show(rtvCard.ShortName & " is owned by " & rtvGame.GetPlayerWithCard(rtvCard.ShortName).Name.ToString)
        Else
            MessageBox.Show(rtvCard.ShortName & " does not exist")
            Exit Sub
        End If
    End Sub

    Sub Message()
        Dim vMessage As String = ""

        For Each Player As Player In rtvGame.PlayerList
            vMessage &= Player.Name
            For Each Card As Card In Player.CardList
                vMessage &= " " & Card.ShortName & ","
            Next
            vMessage &= vbCrLf
        Next
        PlayerDetailsInformationLabel.Text = vMessage

        vMessage = ""

        For Each Card As Card In rtvGame.Deck.Cards
            vMessage &= Card.ShortName & ", "
        Next
        DeckofCardsInformationLabel.Text = vMessage
    End Sub
End Class

