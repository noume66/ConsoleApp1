Module Module1

    Sub Main()
        Dim valIn(2) As Integer
        Dim min As Integer = Nothing
        Dim max As Integer = Nothing
        Console.WriteLine("Veuillez entrer 3 nombre entier")
        For i = 0 To 2
            Select Case i
                Case 0
                    System.Console.WriteLine("Entrez le premier nombre")
                Case 1
                    System.Console.WriteLine("Entrez le deuxième nombre")
                Case 2
                    System.Console.WriteLine("Entrez e troisième nombre")
            End Select
            valIn(i) = CInt(System.Console.ReadLine())
        Next

        min = valIn(0)
        max = valIn(0)

        For j = 0 To 2
            If min > valIn(j) Then min = valIn(j)
            If max < valIn(j) Then max = valIn(j)
        Next


        Console.WriteLine("Plus petit nombre {0}", min)
        Console.WriteLine("Plus grand nombre {0}", max)
        Console.WriteLine("Différence entre les deux {0}", max - min)
        Console.ReadLine()
    End Sub

End Module
