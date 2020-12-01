Public Class vector
    Inherits Matrix

    Public Sub New(ByVal dimensionsofvector As Integer)
        MyBase.New(0, dimensionsofvector, False)

    End Sub

    Public Sub New(ByVal dimensionsofvector As Integer, ByVal initalvalues As Double())
        MyBase.New(0, dimensionsofvector, False)
        Dim vectortopush(dimensionsofvector) As Double
        If dimensionsofvector = initalvalues.Length - 1 Then
            For i = 0 To dimensionsofvector
                vectortopush(i) = initalvalues(i)
            Next
        End If
        MyBase.pushtoarryvector(vectortopush)
    End Sub

    Public Function addvectors(ByVal vectorin As vector) As vector
        Dim temparray(MyBase.returnY) As Double
        Dim tempbase, tempin As Double
        If MyBase.getdimesions()(1) = vectorin.getdimesions()(1) Then
            For i = 0 To MyBase.getdimesions()(1)
                tempbase = MyBase.getarrayout()(0, i)
                tempin = vectorin.getarrayout()(0, i)
                temparray(i) = tempbase + tempin
            Next
        End If
        Dim vectoroutput As New vector(temparray.Length() - 1, temparray)
        Return vectoroutput
    End Function

    Public Function hadamardproduct(ByVal vectorin As vector) As vector
        Dim temparray(MyBase.returnY) As Double
        Dim tempbase, tempin As Double
        If MyBase.getdimesions()(1) = vectorin.getdimesions()(1) Then
            For i = 0 To MyBase.getdimesions()(1)
                tempbase = MyBase.getarrayout()(0, i)
                tempin = vectorin.getarrayout()(0, i)
                temparray(i) = tempbase * tempin
            Next
        End If
        Dim vectoroutput As New vector(temparray.Length() - 1, temparray)
        Return vectoroutput
    End Function

    Public Function sigmoid() As Double()
        Dim tempmatrixarray(,) As Double = MyBase.getarrayout()
        Dim temparray(MyBase.returnY) As Double
        For i = 0 To MyBase.getdimesions()(1)
            temparray(i) = 1 / (1 + Math.E ^ (-tempmatrixarray(0, i)))
        Next
        Return temparray
    End Function

    Public Sub sigmoid_prime()
        Dim tempmatrixarray(,) As Double = MyBase.getarrayout()
        Dim temparray(MyBase.returnY) As Double
        For i = 0 To MyBase.getdimesions()(1)
            temparray(i) = (1 / (1 + Math.E ^ -tempmatrixarray(0, i))) * (1 - (1 / (1 + Math.E ^ -tempmatrixarray(0, i))))
        Next
        pushtoarryvector(temparray)
    End Sub



End Class
