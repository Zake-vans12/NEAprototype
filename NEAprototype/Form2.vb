Imports System.Drawing

Public Class Form2


    Dim image1 As Bitmap = New Bitmap("D:\zak\All my NEA stuff\Example Worksheet.PNG", True)

    Dim imageresized As New Bitmap(image1, image1.Width / 4, image1.Height / 4)

    Dim Xpointer, Ypointer As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Button2.Hide()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        PictureBox1.Image = imageresized

        Button2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        PictureBox1_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Hide()

        splitnumbers()

    End Sub


    Private Sub splitnumbers()

    End Sub

End Class