Public Class Matrix
    Private matrixarray(,) As Double
    Private xsize, ysize As Integer
    Public Sub New(ByVal xsizein As Integer, ByVal ysizein As Integer, ByVal istoberandomized As Boolean)
        Randomize()
        ReDim matrixarray(xsizein, ysizein)
        xsize = xsizein
        ysize = ysizein

    End Sub

    Public Sub setrandomvalues()
        For x = 0 To xsize
            For y = 0 To ysize
                matrixarray(x, y) = Rnd()
            Next
        Next
    End Sub

End Class
