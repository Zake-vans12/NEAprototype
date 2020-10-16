Public Class Graph
    Dim hidenlayernodes() As HiddenLayerClass
    Dim inputLayerNodes As New Inputlayernodes("")
    Dim outputlayerNodes As OutputLayerClass
    Dim weightactivationMatrix(,) As Integer


    Sub New(ByVal NumberOfHiddenLayers As Integer)
        Dim temp(NumberOfHiddenLayers) As HiddenLayerClass
        hidenlayernodes = temp


    End Sub


    Public Function weightsMatrix() As Integer(,)
    End Function







End Class
