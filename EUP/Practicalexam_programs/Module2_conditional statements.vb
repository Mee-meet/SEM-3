Imports System.Console
Module Module2
    Sub Main()
        Dim i As Integer
        i = ReadLine()
        'If (i >= 10) And (i <= 50) Then
        '    WriteLine("value of i" & i)
        'End If
        'If (i >= 10) Then
        '    WriteLine("value of i" & i)
        'Else
        '    WriteLine("Invalid value")

        'End If
        'If (i > 0) Then
        '    WriteLine("value of i is Positive")
        'ElseIf (i < 0) Then

        '    WriteLine("value of i is Negative")
        'Else
        '    WriteLine("value of i is Zero")

        'End If
        Select Case i
            Case 1
                WriteLine("Entered 1")
            Case 2
                WriteLine("Entered 2")
            Case 3
                WriteLine("Entered 3")
            Case Else
                WriteLine("Invalid Input")
        End Select
        ReadLine()

    End Sub
End Module
