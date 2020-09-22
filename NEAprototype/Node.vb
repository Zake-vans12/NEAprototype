Public Class Node
    Private nodevector As Double()
    Private numberofnodes As Integer
    Public Sub New(ByVal nodesinlayertemp As Integer)
        numberofnodes = nodesinlayertemp
        ReDim nodevector(numberofnodes)
    End Sub

    Public Function GetNumberOfNodes() As Integer
        Return numberofnodes
    End Function
End Class
