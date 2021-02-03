'Brayden Peck
'RCET0265
'Spring 2021
'Fortune Cookie
'https://github.com/PeckBray/FortuneCookie
Option Explicit On
Option Strict On
Module FortuneCookie

    Sub Main()
        Dim value As Integer
        Dim userInput As String
        While userInput <> "q" And userInput <> "Q"
            Console.WriteLine("Press enter to receive a fortune or press Q to quit")
            userInput = Console.ReadLine()
            If userInput = "Q" Then

            ElseIf userInput = "q" Then

            Else
                value = Fortune()
                Select Case value
                    Case = 1
                        Console.WriteLine("A lifetime of happiness lies ahead of you." & vbNewLine)
                    Case = 2
                        Console.WriteLine("The best prediction of future is the past." & vbNewLine)
                    Case = 3
                        Console.WriteLine("The greatest achievement in life is to stand up again after falling." & vbNewLine)
                End Select
            End If
        End While
    End Sub

    Function Fortune() As Integer
        Dim _fortune As Integer
        Randomize()
        _fortune = CInt(Int((3 * Rnd()) + 1))
        Return _fortune
    End Function
End Module
