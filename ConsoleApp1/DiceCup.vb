Public Class DiceCup
    Private dices = New List(Of Dice)
    Private average As Double

    Public Property AverageTotal() As Double
        Get
            Return average
        End Get
        Set()
        End Set
    End Property

    Public Property Total() As Integer
        Get
            Dim totalNumber As Integer = 0
            For Each dice As Dice In dices
                totalNumber += dice.Value
            Next
            Return totalNumber
        End Get
        Set()
        End Set
    End Property

    Private Property Face1() As String
        Get
            ' Gets the property value.
            Dim diceText As String = ""
            For Each dice As Dice In dices
                diceText += dice.Face1
            Next
            Return diceText
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Private Property Face2() As String
        Get
            Dim diceText As String = ""
            For Each dice As Dice In dices
                diceText += dice.Face2
            Next
            Return diceText
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Private Property Face3() As String
        Get
            Dim diceText As String = ""
            For Each dice As Dice In dices
                diceText += dice.Face3
            Next
            Return diceText
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Private Property Face4() As String
        Get
            Dim diceText As String = ""
            For Each dice As Dice In dices
                diceText += dice.Face4
            Next
            Return diceText
        End Get
        Set(ByVal visual As String)
        End Set
    End Property
    Private Property Face5() As String
        Get
            ' Gets the property value.
            Dim diceText As String = ""
            For Each dice As Dice In dices
                diceText += dice.Face5
            Next
            Return diceText
        End Get
        Set(ByVal visual As String)
        End Set
    End Property

    Public Property Faces() As String
        Get
            ' Gets the property value.
            Dim diceText As String = ""
            diceText += Face1 + vbCrLf
            diceText += Face2 + vbCrLf
            diceText += Face3 + vbCrLf
            diceText += Face4 + vbCrLf
            diceText += Face5
            Return diceText
        End Get
        Set(ByVal visual As String)
        End Set
    End Property

    Public Sub ThrowDices()
        For Each dice As Dice In dices
            dice.ThrowDice()
        Next
    End Sub

    Public Sub New(numberDice As Integer)
        For number As Integer = 1 To numberDice
            dices.Add(New Dice)
        Next

        average = ((6 * numberDice) + 1) / 2
    End Sub
End Class
