Module Module1

    Sub Main()

        Dim nombre As String
        Dim edad As Integer

        Console.Write("Dime nombre")
        nombre = Console.ReadLine
        Console.Write("Dime edad")
        edad = Console.ReadLine

        Console.Write("Nombre {0}, edad{1}", nombre, edad)

    End Sub

End Module
