Imports System

Module Program
    Sub Main(args As String())
        Dim timesRight As Integer = 0
        Dim timesWrong As Integer = 0
        Dim keyPressed As String = "a"
        Dim diceCup As New DiceCup(2)

        While keyPressed <> "81"
            Console.WriteLine(timesRight.ToString() + " times you guessed right")
            Console.WriteLine(timesWrong.ToString() + " times you guessed wrong")
            Console.WriteLine("Will the dice total be lower of higher than the average? (↑ OR ↓) (Q to quit)")
            keyPressed = Console.ReadKey().Key
            Console.WriteLine()

            If keyPressed <> "81" Then
                diceCup.ThrowDices()
                Console.WriteLine(diceCup.Faces)

                If keyPressed = "38" Then
                    'UP KEY
                    If diceCup.Total > diceCup.AverageTotal Then
                        timesRight += 1
                        Console.WriteLine("You guessed right!")
                    Else
                        timesWrong += 1
                        Console.WriteLine("You guessed wrong!")
                    End If
                ElseIf keyPressed = "40" Then
                    'DOWN KEY
                    If diceCup.Total < diceCup.AverageTotal Then
                        timesRight += 1
                        Console.WriteLine("You guessed right!")
                    Else
                        timesWrong += 1
                        Console.WriteLine("You guessed wrong!")
                    End If
                End If

                Console.WriteLine("Press any button to continue")
                Console.ReadKey()
                Console.Clear()
            End If
        End While
    End Sub
End Module
