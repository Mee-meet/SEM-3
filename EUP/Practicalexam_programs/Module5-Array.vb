Module Module5
    Sub Main()
        Dim num(1, 1) As Integer
        Dim i As Integer, J As Integer


        num(0, 0) = Console.ReadLine()
        num(0, 1) = Console.ReadLine()
        num(1, 0) = Console.ReadLine()
        num(1, 1) = Console.ReadLine()
        'For i = 0 To 1
        '    For J = 0 To 1
        '        num(i, J) = Console.ReadLine(num(i, J))
        '    Next

        'Next
        For i = 0 To 1
            For J = 0 To 1
                Console.WriteLine(num(i, J))

            Next


        Next
        Console.ReadLine()


    End Sub
End Module
