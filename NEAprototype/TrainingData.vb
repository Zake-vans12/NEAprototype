Imports System.Drawing

Public Class TrainingData
    Inherits inputData
    Private Datalable As Integer

    Sub New(ByVal filename As String, ByVal lable As Integer)
        MyBase.New(filename)
        Datalable = lable
    End Sub

    Public Function GetLable()
        Return Datalable
    End Function

End Class
