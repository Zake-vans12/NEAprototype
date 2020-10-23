Module Module1
    Sub main()
        Dim matrix1 As New Matrix(2, 2, False)
        Dim matrixarray As Double(,) = {{3, 4, 2}, {2, 9, 3}, {1, 5, 1}}
        matrix1.pushtoarry(matrixarray)
        Dim vector1 As New vector(2, {1, 2, 3})
        Dim outputvector As vector = matrix1.matrixtimesvector(vector1)
        For i = 0 To 2
            Console.WriteLine(outputvector.getarrayout()(0, i))
        Next
        Console.ReadLine()
        Dim outputvector2 As vector = outputvector.addvectors(vector1)
        For i = 0 To 2
            Console.WriteLine(outputvector2.getarrayout(0, i))
        Next
        Console.ReadKey()
    End Sub






End Module
