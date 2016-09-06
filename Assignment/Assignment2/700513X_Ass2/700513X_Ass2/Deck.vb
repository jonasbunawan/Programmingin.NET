Public Class Deck
    Private mCards As New ArrayList

    Public Sub New()
        mCards = New ArrayList
    End Sub

    Public ReadOnly Property Cards As ArrayList
        Get
            Return mCards
        End Get
    End Property

    Public Function FindCard(ByVal Suit As String, ByVal NumericValue As Integer) As Boolean
        For Each Item As Card In mCards
            If Suit = Item.Suit And NumericValue = Item.NumericValue Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub AddCard(ByVal aCard As Card)
        mCards.Add(aCard)
    End Sub

    Public Function RemoveCard() As Card
        Dim rtvRemovedCard As New Card
        rtvRemovedCard = mCards.Item(0)
        mCards.Remove(rtvRemovedCard)
        Return rtvRemovedCard
    End Function

    Public Sub ExchangePositions()

    End Sub
End Class
