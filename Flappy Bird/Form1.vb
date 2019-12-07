Public Class Form1

    Dim posicoes() As String = {"234,-114", "381,33", "180,-225", "102,-303", "324,-81", "159,-245", "387,-18", "275,-130", "94,-311", "169,-236"}

    Private Sub fundo_Tick(sender As Object, e As EventArgs) Handles fundo.Tick
        If back1.Location.X <= "-256" Then
            back1.Location = New Point(485, back1.Location.Y)
        Else
            back1.Location = New Point(back1.Location.X - 1, back1.Location.Y)
            back2.Location = New Point(back2.Location.X - 1, back2.Location.Y)
            back3.Location = New Point(back3.Location.X - 1, back3.Location.Y)

        End If

        If back2.Location.X <= "-256" Then
            back2.Location = New Point(485, back2.Location.Y)
        Else
            back1.Location = New Point(back1.Location.X - 1, back1.Location.Y)
            back2.Location = New Point(back2.Location.X - 1, back2.Location.Y)
            back3.Location = New Point(back3.Location.X - 1, back3.Location.Y)
        End If

        If back3.Location.X <= "-256" Then
            back3.Location = New Point(485, back3.Location.Y)
        Else
            back1.Location = New Point(back1.Location.X - 1, back1.Location.Y)
            back2.Location = New Point(back2.Location.X - 1, back2.Location.Y)
            back3.Location = New Point(back3.Location.X - 1, back3.Location.Y)

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub voar_Tick(sender As Object, e As EventArgs) Handles voar.Tick
        If bird.Location.Y <= 381 Then
            bird.Location = New Point(bird.Location.X, bird.Location.Y + 2)
        Else
            voar.Stop()
            fundo.Stop()
            andar.Stop()
            barreiras.Stop()
            MsgBox("Gamer Over", MsgBoxStyle.Critical)
        End If
    End Sub

    Protected Overloads Overrides Function ProcessCmdKey(ByRef m As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.W
                bird.Location = New Point(bird.Location.X, bird.Location.Y - 4)
                Return True
            Case Keys.S
                bird.Location = New Point(bird.Location.X, bird.Location.Y + 4)
                Return True
        End Select
    End Function

    Private Sub andar_Tick(sender As Object, e As EventArgs) Handles andar.Tick
        If chao1.Location.X <= "-256" Then
            chao1.Location = New Point(475, chao1.Location.Y)
        Else
            chao1.Location = New Point(chao1.Location.X - 1, chao1.Location.Y)
            chao2.Location = New Point(chao2.Location.X - 1, chao2.Location.Y)
            chao3.Location = New Point(chao3.Location.X - 1, chao3.Location.Y)

        End If

        If chao2.Location.X <= "-256" Then
            chao2.Location = New Point(475, chao2.Location.Y)
        Else
            chao1.Location = New Point(chao1.Location.X - 1, chao1.Location.Y)
            chao2.Location = New Point(chao2.Location.X - 1, chao2.Location.Y)
            chao3.Location = New Point(chao3.Location.X - 1, chao3.Location.Y)
        End If

        If chao3.Location.X <= "-256" Then
            chao3.Location = New Point(475, chao3.Location.Y)
        Else
            chao1.Location = New Point(chao1.Location.X - 1, chao1.Location.Y)
            chao2.Location = New Point(chao2.Location.X - 1, chao2.Location.Y)
            chao3.Location = New Point(chao3.Location.X - 1, chao3.Location.Y)

        End If
    End Sub

    Private Sub barreiras_Tick(sender As Object, e As EventArgs) Handles barreiras.Tick
        If barreira11.Location.X >= "-256" Then
            barreira11.Location = New Point(barreira11.Location.X - 1, 228)
            barreira21.Location = New Point(barreira21.Location.X - 1, 228)
        Else
            barreira11.Location = New Point(500, 228)
            barreira21.Location = New Point(500, 228)
        End If
    End Sub
End Class