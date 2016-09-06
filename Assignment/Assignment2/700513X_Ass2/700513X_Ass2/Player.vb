Public Class Player
    Private mName As String
    Private mCardList As ArrayList

    Public Sub New()
        mName = vbNullString
        mCardList = New ArrayList
    End Sub

    Public Sub New(ByVal PlayerName As String)
        mName = PlayerName
        mCardList = New ArrayList
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return mName
        End Get
    End Property

    Public ReadOnly Property CardList As ArrayList
        Get
            Return mCardList
        End Get
    End Property

    Public Function FindCard(ByVal Suit As String, ByVal NumericValue As Integer) As Boolean
        For Each Item As Card In mCardList
            If Suit = Item.Suit And NumericValue = Item.NumericValue Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub AddCard(ByVal aCard As Card)
        mCardList.Add(aCard)
    End Sub

    Public Function RemoveCard() As Card
        Dim rtvRemovedCard As New Card
        rtvRemovedCard = mCardList.Item(0)
        mCardList.Remove(rtvRemovedCard)
        Return rtvRemovedCard
    End Function

    Public Function Total() As Integer
        Dim vTotal As Integer
        For Each Item As Card In mCardList
            vTotal += Item.NumericValue
        Next
        Return vTotal
    End Function
End Class