Public Class Form1
    Dim Jogadas(11) As Integer
    Dim Matriz(11) As Integer
    Dim quadros() As Integer
    Dim Anterior, passo As Integer
    Sub imagens(quadro)
        Dim fig As New PictureBox
        Dim i = Int(Rnd() * 6)
        Select Case i
            Case 0 : fig.BackgroundImage = My.Resources.imagem
            Case 2 : fig.BackgroundImage = My.Resources.imagem
            Case 3 : fig.BackgroundImage = My.Resources.imagem
            Case 4 : fig.BackgroundImage = My.Resources.imagem
            Case 5 : fig.BackgroundImage = My.Resources.imagem
        End Select
        quadros(quadro).backgroundImage = fig.BackgroundImage
        Refresh()
        Threading.Thread.Sleep(500)
        Jogadas(quadro) = 1
        If passo = 1 Then : Anterior = quadro
            Elsif Matriz(quadro) <> Matriz(Anterior) Then
            Jogadas(quadro) = 0
            Jogadas(Anterior) = 0
            quadros(quadro).BackgroundImage = My.Resources.nada
            quadros(Anterior).BackgroundImage = My.Resources.nada
        End Sub
    Sub Inicializa()
        Dim i As Integer
        For i = 0 To 11
            quadros(i).BackgroundImage = My.Resources.Nada
            Matriz(i) = 0
            Jogadas(i) = 0
        Next

        For par = 0 To 5
            For x = 0 To 1
                Do i  =  Int(Rdn) 
            Next
        Next
    End Sub
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
        End Select
        If Jogadas(quadro) <> 0 Then Return
        Call imagens(quadro)
        If passo = 1 Then : passo = 2
        Else : passo = 1
        End If
        Dim ganhou = True
        For i = 0 To 11
            If Jogadas(i) = 0 Then ganhou = False
        Next
        If ganhou Then
            Beep()
            MsgBox()


        End If
     End Class
