Public Class Game
    Private mPlayerList As New ArrayList
    Private mDeck As New Deck

    Public ReadOnly Property PlayerList() As ArrayList
        Get
            Return mPlayerList
        End Get
    End Property

    Public ReadOnly Property Deck() As Deck
        Get
            Return mDeck
        End Get
    End Property

    Public Sub AddCardToDeck(ByVal aCard As Card)
        mDeck.AddCard(aCard)
    End Sub

    Public Function RemoveCardFromDeck() As Card
        Return mDeck.RemoveCard
    End Function

    Public Function FindPlayer(ByVal rtvPlayer As Player) As Boolean
        For Each Item As Player In PlayerList
            If rtvPlayer.Name = Item.Name Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function GetPlayer(ByVal rtvPlayer As Player) As Player
        For Each Item As Player In PlayerList
            If rtvPlayer.Name = Item.Name Then
                Return Item
            End If
        Next
        Return Nothing
    End Function

    Public Function AddPlayer(ByVal Player As Player) As Boolean
        mPlayerList.Add(Player)
        Return True
    End Function

    Public Function GetPlayerWithCard(ByVal CardShortName As String) As Player
        For Each rtvPlayer As Player In mPlayerList
            For Each Item As Card In rtvPlayer.CardList
                If CardShortName = Item.ShortName Then
                    Return rtvPlayer
                End If
            Next
        Next
        Return Nothing
    End Function

    Public Function DealOneCardToPlayer(ByVal aPlayer As Player) As Boolean
        Dim rtvDealedCard As New Card

        If Deck.Cards.Count <= 0 Then
            Return False
        Else
            rtvDealedCard = RemoveCardFromDeck()
            aPlayer.AddCard(rtvDealedCard)
            Return True
        End If
    End Function

    Public Function RemoveOneCardFromPlayer(ByVal aPlayer As Player) As Boolean
        Dim rtvRemovedCard As New Card

        If aPlayer.CardList.Count <= 0 Then
            Return False
        Else
            rtvRemovedCard = aPlayer.RemoveCard
            AddCardToDeck(rtvRemovedCard)
            Return True
        End If
    End Function

    Public Sub SwapPlayerCards(ByVal vPlayer1Name As String, ByVal vPlayer2Name As String)

    End Sub
End Class
