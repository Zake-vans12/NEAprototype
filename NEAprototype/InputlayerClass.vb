Imports System.Drawing

Public Class Inputlayernodes
    Inherits node

    Private nodearray() As Double


    Sub New(ByVal filelocation As String)
        MyBase.new()
        Dim Inputactivation As New inputData(filelocation)
        Dim inputActivationresized As New Bitmap(Inputactivation.getimage, Inputactivation.getimage.Width / 4, Inputactivation.getimage.Height / 4)
        Dim nodearray = converttoblackandwhite(inputActivationresized)
    End Sub

    Function converttoblackandwhite(ByVal inputimage As Bitmap) As Double()
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

                temp = convertTodouble(temp)

                nodearray(pointer) = temp
            Next
        Next



        Return nodearray

    End Function

    Private Function convertTodouble(ByVal numbertoconvert As Integer) As Double
        Dim tempbinary(7) As Boolean
        Dim returnvalue As Double

        For i = 7 To 0 Step -1
            If numbertoconvert Mod 2 = 0 Then
                tempbinary(i) = False
            Else
                tempbinary(i) = True
            End If
            numbertoconvert = numbertoconvert \ 2
        Next

        For i = 0 To 7
            If tempbinary(i) Then
                returnvalue += 1 / 2 ^ i + 1
            End If
        Next

        Return returnvalue
    End Function

    Public Function getnodearray() As Double()
        Return nodearray
    End Function







End Class
