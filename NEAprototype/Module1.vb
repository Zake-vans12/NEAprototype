Imports System.Drawing
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



    Function convertimagetovalues(ByVal inputimage As Bitmap) As Double()
        Dim pixelcolour As New Color
        Dim temp As Integer
        Dim pointer As Integer
        Dim nodearray(inputimage.Height + 1 * inputimage.Width + 1) As Double

        For y = 0 To inputimage.Height
            For x = 0 To inputimage.Width

                pixelcolour = inputimage.GetPixel(x, y)

                Dim pixelcolourarray = {pixelcolour.A, pixelcolour.R, pixelcolour.G, pixelcolour.B} 'takes the aRGB value for the current pixel

                For i = 1 To 3
                    temp += pixelcolourarray(i)
                Next
                temp = temp / 3

                temp = Getvaluefromcolour(temp)

                nodearray(pointer) = temp
            Next
        Next


        Return nodearray

    End Function

    Function Getvaluefromcolour(ByVal inputtoconvert As Integer) As Double
        Dim binarynumber(7) As Boolean
        Dim returnvalue As Double
        For i = 7 To 0 Step -1
            If inputtoconvert Mod 2 = 1 Then
                binarynumber(i) = True
                inputtoconvert = inputtoconvert / 2 - 0.5
            Else
                binarynumber(i) = False
                inputtoconvert = inputtoconvert / 2
            End If
        Next

        For i = 0 To 7
            If binarynumber(i) Then
                returnvalue += 1 / 2 ^ (i + 1)
            End If

        Next
        Return t
    End Function





End Module
