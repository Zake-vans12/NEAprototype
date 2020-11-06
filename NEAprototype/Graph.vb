Imports System.Drawing
Public Class Graph

    Private activations() As vector
    Private biases() As vector
    Private errors() As vector
    Private zvalues() As vector
    Private costgradient As vector
    Private weightsmatrix() As Matrix
    Private imagelookupIMAGE() As Bitmap
    Private imagelookupLABLE() As Integer
    Private minibatchIMAGE(,) As Bitmap
    Private minibatchLABLE(,) As Integer

    Sub New(ByVal isnewnetwork As Boolean, ByVal networksize As Integer())
        If isnewnetwork Then

        End If

    End Sub


    Public Sub weightsandbiasesfrombinaryfile()

    End Sub

    Public Sub readimagesfrombinaryfile()

    End Sub

    Public Sub makeminibatch(ByVal minibatchsize As Integer)
        Dim howmanyminibatches As Integer = imagelookupLABLE.Length \ minibatchsize
        ReDim minibatchIMAGE(minibatchsize - 1, howmanyminibatches)
        ReDim minibatchLABLE(minibatchsize - 1, howmanyminibatches)
        Dim dataindex As Integer = 0
        For i = 0 To howmanyminibatches
            For j = 0 To minibatchsize - 1
                minibatchIMAGE(i, j) = imagelookupIMAGE(dataindex)
                minibatchLABLE(i, j) = imagelookupLABLE(dataindex)
                dataindex += 1
            Next

        Next
    End Sub


    Public Sub sendmimibatchthroughnetwork()

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




End Class
