Public Class Card
    Private mSuit As String
    Private mNumericValue As Integer
    Private mPlayerList As New ArrayList

    Public Sub New()
        mSuit = vbNullString
        mNumericValue = 0
    End Sub

    Public Sub New(ByVal Suit As String, ByVal NumericValue As Integer)
        mSuit = Suit
        mNumericValue = NumericValue
    End Sub

    Public ReadOnly Property Suit As String
        Get
            Return mSuit
        End Get
    End Property

    Public ReadOnly Property NumericValue As Integer
        Get
            Return mNumericValue
        End Get
    End Property

    Public ReadOnly Property PlayerList As ArrayList
        Get
            Return mPlayerList
        End Get
    End Property

    Public Function ShortName() As String
        If mSuit = "Hearts" Then
            Return mNumericValue & "H"
        ElseIf mSuit = "Clubs" Then
            Return mNumericValue & "C"
        ElseIf mSuit = "Spades" Then
            Return mNumericValue & "S"
        ElseIf mSuit = "Diamonds" Then
            Return mNumericValue & "D"
        Else
            Return "Card"
        End If
    End Function

    Public Sub AddPlayerToHistory(ByVal Player As Player)
        mPlayerList.Add(Player)
    End Sub
End Class
