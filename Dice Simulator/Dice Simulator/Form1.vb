Public Class Form1
    Private Sub btnDice_Click(sender As Object, e As EventArgs) Handles btnDice.Click

        Dim Dice1 As Integer 'Indicate first dice roll
        Dim Dice2 As Integer 'Indicate second dice roll
        Dim ran As New Random 'Roll the dices randomly

        pic1DiceSide1.Visible = False
        pic1DiceSide2.Visible = False
        pic1DiceSide3.Visible = False
        pic1DiceSide4.Visible = False
        pic1DiceSide5.Visible = False
        pic1DiceSide6.Visible = False
        pic2DiceSide1.Visible = False
        pic2DiceSide2.Visible = False
        pic2DiceSide3.Visible = False
        pic2DiceSide4.Visible = False
        pic2DiceSide5.Visible = False
        pic2DiceSide6.Visible = False

        Dice1 = ran.Next(1, 6)
        Dice2 = ran.Next(1, 6)

        Select Case Dice1

            Case 1
                pic1DiceSide1.Visible = True

            Case 2
                pic1DiceSide2.Visible = True

            Case 3
                pic1DiceSide3.Visible = True

            Case 4
                pic1DiceSide4.Visible = True

            Case 5
                pic1DiceSide5.Visible = True

            Case 6
                pic1DiceSide6.Visible = True

        End Select

        Select Case Dice2

            Case 1
                pic2DiceSide1.Visible = True

            Case 2
                pic2DiceSide2.Visible = True

            Case 3
                pic2DiceSide3.Visible = True

            Case 4
                pic2DiceSide4.Visible = True

            Case 5
                pic2DiceSide5.Visible = True

            Case 6
                pic2DiceSide6.Visible = True

        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
