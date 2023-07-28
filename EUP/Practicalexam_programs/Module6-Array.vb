Module Module6
    Sub Main()
        Dim num(5) As Integer
        Dim i As Integer
        ReDim num(1)
        num(0) = 10
        num(1) = 20
        ReDim Preserve num(3)
        num(2) = 30
        num(3) = 40
        ReDim Preserve num(5)
        num(4) = 50
        num(5) = 60
        For i = 0 To 5

            Console.WriteLine(num(i))

        Next

        Console.ReadLine()





    End Sub
End Module
