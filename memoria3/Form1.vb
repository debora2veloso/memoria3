Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.BackgroundImage = imagem(0)

    End Sub

    Function imagem(i)
        Select Case i

            Case 0
                Return My.Resources.Resources.imagem
            Case 1
                Return My.Resources.Resources.imagem
            Case 2
                Return My.Resources.Resources.imagem
            Case 3
                Return My.Resources.Resources.imagem
            Case 4
                Return My.Resources.Resources.imagem
            Case 5
                Return My.Resources.Resources.imagem
            Case 6
                Return My.Resources.Resources.imagem
            Case 7
                Return My.Resources.Resources.imagem

End Class


