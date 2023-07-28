Module Module7
    Sub Main()
        Dim num(2) As Integer, i As Integer
        num(0) = 10
        num(1) = 20
        num(2) = 30
        ReDim Preserve num(4)
        num(3) = 40
        num(4) = 50

        For i = 0 To 4
            Console.WriteLine(num(i))
        Next
        Console.ReadLine()


    End Sub
End Module
