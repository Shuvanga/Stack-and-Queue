Imports System

Module Program
    Sub Main()
        Dim Stack(10), Queue(10), Input As Integer
        Console.WriteLine("Enter 10 numbers!")
        For i = 1 To 10
            Input = Console.ReadLine
            Stack(i) = Input
            Queue(i) = Input
        Next
        Console.WriteLine("Queue")
        For i = 1 To 10
            Console.WriteLine(Queue(i))
        Next
        Console.WriteLine("Stack")
        For i = 10 To 1 Step -1
            Console.WriteLine(Stack(i))
        Next
        Console.ReadKey()
    End Sub
End Module
