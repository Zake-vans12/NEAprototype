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
    Private networksizefinal() As Integer

    Sub New(ByVal isnewnetwork As Boolean, ByVal networksize As Integer())
        Dim nullarray() As Double = {}
        ReDim activations(networksize.Length-1)
        ReDim biases(networksize.Length - 2)
        ReDim zvalues(networksize.Length - 2)
        ReDim errors(networksize.Length - 2)
        ReDim weightsmatrix(networksize.Length - 2)
        ReDim networksizefinal(networksize.Length - 1)
        networksizefinal = networksize
        If isnewnetwork Then
            activations(0) = New vector(networksize(0), nullarray)

            For i = 1 To networksize.Length - 1
                activations(i) = New vector(networksize(i - 1), nullarray)
                biases(i - 1) = New vector(networksize(i - 1), nullarray)
                zvalues(i - 1) = New vector(networksize(i - 1), nullarray)
                errors(i - 1) = New vector(networksize(i - 1), nullarray)
                weightsmatrix(i - 1) = New Matrix(networksize(i), networksize(i - 1), True)
            Next




        Else

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

    Public Function senddatathroughnetwrok(ByVal inputarray() As Double, ByVal Istrainingdata As Boolean) As Integer
        Dim newinputarray(inputarray.Length - 1) As Double
        Dim highestoutput As Integer

        For i = 0 To inputarray.Length - 1
            newinputarray(i) = inputarray(i)
        Next
        activations(0).pushtoarryvector(newinputarray)
        For i = 0 To networksizefinal.Length - 2
            zvalues(i) = weightsmatrix(i).matrixtimesvector(activations(i))
            zvalues(i) = zvalues(i).addvectors(biases(i))
            activations(i + 1) = New vector(inputarray.Length - 1, zvalues(i).sigmoid())
        Next
        If Not Istrainingdata Then
            Return findhighestinarray()
        End If
        Return 0
    End Function


    Public Sub sendTrainingData(ByVal inputarray() As Double, ByVal lable As Integer)
        senddatathroughnetwrok(inputarray, True)
        Dim lasterrortemp(networksizefinal.Last - 1) As Double

        errors.(networksizefinal.Length - 2) = New vector(0)
    End Sub

    Public Sub backpropagation()

    End Sub

    Public Function findhighestinarray()
        Dim readoutputvalue As Double = 0
        Dim highestoutput As Integer
        For i = 0 To networksizefinal.Last - 1

            If activations.Last.getarrayout()(0, i) > readoutputvalue Then
                readoutputvalue = activations.Last.getarrayout()(0, i)
                highestoutput = i + 1
            End If
        Next
        Return highestoutput
    End Function




End Class
