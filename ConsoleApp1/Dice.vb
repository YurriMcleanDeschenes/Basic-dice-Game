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

    Private numberOfFaces As Integer = 6

    Public Property Faces() As Integer
        Get
            ' Gets the property value.
            Return numberOfFaces
        End Get
        Set(ByVal Faces As Integer)
            ' Sets the property value.
            numberOfFaces = Faces
        End Set
    End Property

    ' These are the methods
    Public Sub ThrowDice()
        ' use the method to randomize the dice
        Value = Int(((numberOfFaces + 1) * Rnd()) + 1)
    End Sub
    Public Sub New(ByVal numberFaces As Integer)
        ' use the method to randomize the dice
        Console.WriteLine(numberFaces)
        Faces = numberFaces
        ThrowDice()
    End Sub
End Class
