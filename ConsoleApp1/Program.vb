Imports System

Module Program
    Sub Main(args As String())
        Dim dice As New Dice()
        For index As Integer = 1 To 10
            dice.ThrowDice()
            Console.WriteLine(dice.Face1)
            Console.WriteLine(dice.Face2)
            Console.WriteLine(dice.Face3)
            Console.WriteLine(dice.Face4)
            Console.WriteLine(dice.Face5)
        Next
    End Sub
End Module
