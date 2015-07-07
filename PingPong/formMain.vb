Public Class formMain

    Dim gBall, gPlayer1, gPlayer2 As Graphics

    Dim gBallDirX, gBallDirY As Boolean
    Dim gBallPosX, gBallPosY As Integer
    Dim gBallSizeX, gBallSizeY As Integer

    Dim gPlayer1PosX, gPlayer1PosY As Integer
    Dim gPlayer1SizeX, gPlayer1SizeY As Integer

    Dim gPlayer2PosX, gPlayer2PosY As Integer
    Dim gPlayer2SizeX, gPlayer2SizeY As Integer
    Dim speed As Integer

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gBallPosX = Size.Width / 2
        gBallPosY = Size.Height / 2
        gBallDirX = True

        gBallSizeX = 5
        gBallSizeY = 5

        gPlayer1SizeX = 5
        gPlayer1SizeY = 30

        gPlayer2SizeX = 5
        gPlayer2SizeY = 30

        gPlayer1PosX = 0
        gPlayer1PosY = Size.Height / 2

        gPlayer2PosX = Size.Width - gPlayer2SizeX
        gPlayer2PosY = Size.Height / 2

        speed = 3

        timerGame.Interval = 1
        timerView.Interval = 1

        timerView.Start()
        timerGame.Start()
    End Sub

    Private Sub formMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 87 'w
                If gPlayer1PosY > 0 Then
                    gPlayer1PosY -= speed * 2
                End If

            Case 83 's
                If gPlayer1PosY < Size.Height - gPlayer1SizeY Then
                    gPlayer1PosY += speed * 2
                End If

            Case 38 'Up
                If gPlayer2PosY > 0 Then
                    gPlayer2PosY -= speed * 2
                End If

            Case 40 'Down
                If gPlayer2PosY < Size.Height - gPlayer2SizeY Then
                    gPlayer2PosY += speed * 2
                End If

            Case 74 'j
                If speed > 1 Then
                    speed -= 1
                End If

            Case 75 'k
                If speed < 256 Then
                    speed += 1
                End If

            Case 82 'r
                gBallPosX = Size.Width / 2
                gBallPosY = Size.Height / 2
                gBallDirX = True
                outputStatus.Text = ""
                timerGame.Start()

            Case 32 'Space
                If timerGame.Enabled = True Then
                    timerGame.Stop()
                Else
                    timerGame.Start()
                End If

            Case 27 'Escape
                End

        End Select
    End Sub

    Private Sub timerGame_Tick(sender As Object, e As EventArgs) Handles timerGame.Tick
#If 0 Then
        If gBallPosX <= 0 Then
            gBallDirX = True
        End If
        If gBallPosX >= Size.Width - gBallSizeX Then
            gBallDirX = False
        End If
#End If
        If gBallPosX <= 0 + gPlayer1SizeX Then
            If gBallPosY <= gPlayer1PosY + gPlayer1SizeY And gBallPosY >= gPlayer1PosY - gPlayer1SizeY Then
                gBallDirX = True
            Else
                outputStatus.Text = "Player 1 Dead"
                timerGame.Stop()
            End If
        End If
        If gBallPosX >= Size.Width - gPlayer2SizeX - gBallSizeX Then
            If gBallPosY <= gPlayer2PosY + gPlayer2SizeY And gBallPosY >= gPlayer2PosY - gPlayer2SizeY Then
                gBallDirX = False
            Else
                outputStatus.Text = "Player 2 Dead"
                timerGame.Stop()
            End If
        End If

        If gBallPosY <= 0 Then
            gBallDirY = True
        End If
        If gBallPosY >= Size.Height - gBallSizeY Then
            gBallDirY = False
        End If

        Select Case gBallDirX
            Case True
                gBallPosX += speed
            Case False
                gBallPosX -= speed
        End Select

        Select Case gBallDirY
            Case True
                gBallPosY += speed
            Case False
                gBallPosY -= speed
        End Select

    End Sub

    Private Sub timerView_Tick(sender As Object, e As EventArgs) Handles timerView.Tick
        gPlayer1 = CreateGraphics()
        gPlayer2 = CreateGraphics()
        gBall = CreateGraphics()

        Refresh()

        gBall.FillRectangle(Brushes.Red, gBallPosX, gBallPosY, gBallSizeX, gBallSizeY)
        gPlayer1.FillRectangle(Brushes.Black, gPlayer1PosX, gPlayer1PosY, gPlayer1SizeX, gPlayer1SizeY)
        gPlayer2.FillRectangle(Brushes.Black, gPlayer2PosX, gPlayer2PosY, gPlayer2SizeX, gPlayer2SizeY)
    End Sub
End Class
