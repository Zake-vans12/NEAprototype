Public Class Matrix
    Private matrixarray(,) As Double
    Private xsize, ysize As Integer
    Public Sub New(ByVal xsizein As Integer, ByVal ysizein As Integer, ByVal istoberandomized As Boolean)
        Randomize()
        ReDim matrixarray(xsizein, ysizein)
        xsize = xsizein
        ysize = ysizein
        If istoberandomized Then
            setrandomvalues()
        End If
    End Sub

    Public Sub setrandomvalues()
        For x = 0 To xsize
            For y = 0 To ysize
                matrixarray(x, y) = Rnd()
            Next
        Next
    End Sub


    Public Function getdimesions() As Integer()
        Dim returnarray() As Integer = {xsize, ysize}
        Return returnarray
    End Function

    Public Function matrixtimesvector(ByVal vectorin As vector) As vector 'Any matrix * Vector will always give a vector and it will most likley to then have to be added to another vector
        Dim tempinarray() As Double
        Dim tempsumvalue As Double
        If vectorin.getdimesions()(1) = xsize Then
            For i = 0 To ysize
                For j = 0 To xsize
                    tempsumvalue += matrixarray(i, j) * vectorin.getarrayout()(0, j)
                Next
                tempinarray(i) = tempsumvalue
                tempsumvalue = 0
            Next
        End If
        Dim tempvector As vector
        tempvector = New vector(ysize, tempinarray)
        Return tempvector
    End Function

    Public Function getarrayout() As Double(,)
        Return matrixarray
    End Function

    Public Sub pushtoarry(ByVal Inputarray As Double(,))
        For X = 0 To xsize
            For Y = 0 To ysize
                matrixarray(X, Y) = Inputarray(X, Y)
            Next
        Next

    End Sub


End Class
