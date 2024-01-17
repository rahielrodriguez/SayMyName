'Rahiel Rodriguez
'RCET 2265
'Spring 2024
'https://github.com/rahielrodriguez/SayMyName.git

Module SayMyName

    Sub Main()
        Dim userInput As String

        Console.WriteLine("What is your name?")

        userInput = Console.ReadLine()

        Console.WriteLine($"Hello, {userInput}! Nice to meet you.")

        Console.Read()
    End Sub

End Module
