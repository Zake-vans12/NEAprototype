Public Class vector
    Inherits Matrix

    Public Sub New(ByVal dimensionsofvector As Integer)
        MyBase.New(0, dimensionsofvector, False)

    End Sub

    Public Sub New(ByVal dimensionsofvector As Integer, ByVal initalvalues As Double())
        MyBase.New(0, dimensionsofvector, False)
        Dim vectortopush(0, dimensionsofvector) As Double
        If dimensionsofvector = initalvalues.Length - 1 Then
            For i = 0 To dimensionsofvector
                vectortopush(0, i) = initalvalues(i)
            Next
        End If
        MyBase.pushtoarry(vectortopush)
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


End Class
