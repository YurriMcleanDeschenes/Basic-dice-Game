Imports System

Module Program
    Sub Main(args As String())
        Dim dice As New Dice(6)
        For index As Integer = 1 To 10
            dice.ThrowDice()
            Console.WriteLine(dice.Value)
        Next
    End Sub
End Module
