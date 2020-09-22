Imports System.Drawing
Public Class inputData

    Private image As Bitmap

    Sub New(ByVal filename As String)
        image = New Bitmap(filename, True)
    End Sub


    Public Function getimage() As Bitmap
        Return image
    End Function


End Class
