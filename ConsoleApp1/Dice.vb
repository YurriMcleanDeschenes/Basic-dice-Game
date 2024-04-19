Public Class Dice

    'Create the parameters
    Private diceValue As Integer

    Public Property Value() As Integer
        Get
            ' Gets the property value.
            Return diceValue
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            diceValue = Value
        End Set
    End Property

    Private visualFace1 As String = "┌───────┐"
    Private visualFace2 = New String() {"│       │", "│ 〇     │", "│     〇 │", "│ 〇   〇 │", "│ 〇   〇 │", "│ 〇 〇 〇 │"}
    Private visualFace3 = New String() {"│   〇   │", "│       │", "│   〇   │", "│       │", "│   〇   │", "│       │"}
    Private visualFace4 = New String() {"│       │", "│     〇 │", "│ 〇     │", "│ 〇   〇 │", "│ 〇   〇 │", "│ 〇 〇 〇 │"}
    Private visualFace5 As String = "└───────┘"

    Public Property Face1() As String
        Get
            ' Gets the property value.
            Return visualFace1
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Public Property Face2() As String
        Get
            Return visualFace2(diceValue - 1)
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Public Property Face3() As String
        Get
            Return visualFace3(diceValue - 1)
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Public Property Face4() As String
        Get
            Return visualFace4(diceValue - 1)
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Public Property Face5() As String
        Get
            ' Gets the property value.
            Return visualFace5
        End Get
        Set(ByVal visual As String)
        End Set
    End Property

    ' These are the methods
    Public Sub ThrowDice()
        ' use the method to randomize the dice
        Randomize()
        Value = Int((6 * Rnd()) + 1)
    End Sub
    Public Sub New()
        ' use the method to randomize the dice
        ThrowDice()
    End Sub
End Class
