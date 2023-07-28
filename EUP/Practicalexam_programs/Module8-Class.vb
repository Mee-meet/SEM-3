Module Module8
    Class Rectangle
        Dim Length As Integer, Breadth As Integer, Height As Integer
        Public Function GetL(ByVal l As Integer) As Integer
            Length = l
            Return Length
        End Function
        Public Function GetB(ByVal b As Integer) As Integer
            Breadth = b
            Return Breadth
        End Function
        Public Function GetH(ByVal h As Integer) As Integer
            Height = h
            Return Height
        End Function
        Public Function Volume(ByVal l As Integer, ByVal b As Integer, ByVal h As Integer) As Integer

            Dim V As Integer
            V = l * b * h
            Return V



        End Function

    End Class
    Sub Main()
        Dim R As New Rectangle()
        Console.WriteLine(R.GetL(10))
        'Dim l1 As Integer
        'l1 = R.GetL(10)
        'Console.WriteLine("length is:" & l1)
        Console.WriteLine(R.GetB(5))
        Console.WriteLine(R.GetH(5))
        Console.WriteLine(R.Volume(10, 5, 5))



        Console.ReadLine()








    End Sub


End Module
