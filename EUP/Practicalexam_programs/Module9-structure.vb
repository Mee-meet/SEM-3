Module Module9
    Structure student
        Private name As String
        Dim rollno As Integer
        Dim marks As Integer
        Sub getdata()
            Console.WriteLine("Enter name")
            name = Console.ReadLine()
            Console.WriteLine("Enter rollno")
            rollno = Console.ReadLine()
            Console.WriteLine("Enter marks")
            marks = Console.ReadLine()
        End Sub
        Sub display()
            Console.WriteLine("name is:  " & name)
            Console.WriteLine("Rollno is:  " & rollno)
            Console.WriteLine("Marks is:  " & marks)
        End Sub
    End Structure

    Sub Main()
        Dim s As student
        s.getdata()
        s.display()
        
        Console.ReadLine()




    End Sub
End Module
