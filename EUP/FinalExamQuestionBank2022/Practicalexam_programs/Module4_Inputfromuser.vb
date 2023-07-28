Imports System.Console


Module Module4
    Sub Main()
        Dim i As Integer
        WriteLine("Enter value for i:")

        i = ReadLine()
        If (i > 5) Then
            WriteLine("value of i is:" & i)

        Else
            WriteLine("Invalid value")

        End If


        ReadLine()
    End Sub

End Module
